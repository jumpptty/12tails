<#
.SYNOPSIS
  Decodes CharacterControl base stats (hp/atk/def/agi/vit/mag/cha/tal/lck/...) out of a
  12TailsOnline binary .assets/level file. See ../SKILL.md for the full recipe and the
  validation this implements.

.PARAMETER AssetPath
  Path to the binary .assets or level* file to scan.

.PARAMETER Names
  Optional list of unit names to search for (recolor/variant suffixes like trailing digits or
  "_r"/"_i"/"_colorSuffix" are stripped and retried if the exact name isn't found). Omit to
  scan the whole file for every valid decode (slower; use to build a full ranking).

.PARAMETER MaxHits
  Max valid decodes to keep per requested name before moving on (default 5) — cosmetic
  variants often share one underlying serialized Name/offset, so this also bounds a
  pathological all-scan.
#>
param(
    [Parameter(Mandatory=$true)][string]$AssetPath,
    [string[]]$Names,
    [int]$MaxHits = 5
)

if (-not (Test-Path $AssetPath)) { throw "Asset file not found: $AssetPath" }

$bytes  = [IO.File]::ReadAllBytes($AssetPath)
$latin1 = [System.Text.Encoding]::GetEncoding("ISO-8859-1")   # byte-preserving 1:1 string view
$text   = $latin1.GetString($bytes)

# Declaration order after Name/Type (Sep-2024 build; re-verify per SKILL.md step 1)
$FieldNames = @('Lv','Skin','Race','hp','sp','mp','ko','mhp','msp','mmp','mko','atk','def','agi','vit','mag','cha','tal','lck')

function Read-Int32([byte[]]$b, [int]$off) {
    if ($off -lt 0 -or $off + 4 -gt $b.Length) { return $null }
    [BitConverter]::ToInt32($b, $off)
}

function Test-PrintableAsciiRun([byte[]]$b, [int]$off, [int]$len) {
    if ($len -le 0 -or $len -gt 128) { return $false }
    if ($off -lt 0 -or $off + $len -gt $b.Length) { return $false }
    for ($k = 0; $k -lt $len; $k++) {
        $c = $b[$off + $k]
        if ($c -lt 0x20 -or $c -gt 0x7E) { return $false }
    }
    return $true
}

# $nameOff = offset of the 4-byte length prefix that precedes the Name string
function Try-DecodeAt([byte[]]$b, [int]$nameOff) {
    $nameLen = Read-Int32 $b $nameOff
    if ($null -eq $nameLen -or -not (Test-PrintableAsciiRun $b ($nameOff + 4) $nameLen)) { return $null }
    $name = $latin1.GetString($b, $nameOff + 4, $nameLen)
    $namePad = [int]([Math]::Ceiling($nameLen / 4.0) * 4)

    $typeOff = $nameOff + 4 + $namePad
    $typeLen = Read-Int32 $b $typeOff
    if ($null -eq $typeLen -or -not (Test-PrintableAsciiRun $b ($typeOff + 4) $typeLen)) { return $null }
    $type = $latin1.GetString($b, $typeOff + 4, $typeLen)
    $typePad = [int]([Math]::Ceiling($typeLen / 4.0) * 4)

    $statsOff = $typeOff + 4 + $typePad
    $vals = New-Object int[] 19
    for ($i = 0; $i -lt 19; $i++) {
        $v = Read-Int32 $b ($statsOff + $i * 4)
        if ($null -eq $v) { return $null }
        $vals[$i] = $v
    }

    $row = [ordered]@{ Name = $name; Type = $type; ByteOffset = $nameOff }
    for ($i = 0; $i -lt 19; $i++) { $row[$FieldNames[$i]] = $vals[$i] }

    # validation (see SKILL.md step 4)
    if ($row.Lv -lt 0 -or $row.Lv -gt 999) { return $null }
    if ($row.Race -lt 0 -or $row.Race -gt 20) { return $null }
    foreach ($fn in @('hp','sp','mp','ko','mhp','msp','mmp','mko','atk','def','agi','vit','mag','cha','tal','lck')) {
        if ([Math]::Abs($row[$fn]) -gt 500000) { return $null }
    }
    return [PSCustomObject]$row
}

function Find-Decodes([string]$searchName, [int]$maxHits) {
    $hits = @()
    $searchIdx = 0
    while ($hits.Count -lt $maxHits) {
        $idx = $text.IndexOf($searchName, $searchIdx)
        if ($idx -lt 0) { break }
        $searchIdx = $idx + 1
        $nameOff = $idx - 4   # 4-byte length prefix sits immediately before the string bytes
        $row = Try-DecodeAt $bytes $nameOff
        if ($row) { $hits += $row }
    }
    return $hits
}

function Get-NameVariants([string]$n) {
    $variants = [ordered]@{}
    $variants[$n] = $true
    $stripped = $n -replace '(_[A-Za-z]{1,3}|\d+)+$', ''   # trailing digits / _r,_i,_colorSuffix-style
    if ($stripped -and $stripped -ne $n) { $variants[$stripped] = $true }
    return $variants.Keys
}

$results = New-Object System.Collections.Generic.List[object]
$seenOffsets = New-Object System.Collections.Generic.HashSet[int]

if ($Names -and $Names.Count -gt 0) {
    foreach ($requested in $Names) {
        $found = $false
        foreach ($variant in (Get-NameVariants $requested)) {
            $hits = Find-Decodes $variant $MaxHits
            foreach ($h in $hits) {
                if ($seenOffsets.Add([int]$h.ByteOffset)) {
                    $h | Add-Member -NotePropertyName RequestedAs -NotePropertyValue $requested
                    $results.Add($h)
                }
                $found = $true
            }
            if ($found) { break }
        }
        if (-not $found) {
            Write-Warning "No validated decode found for '$requested' (tried: $((Get-NameVariants $requested) -join ', '))"
        }
    }
} else {
    # Full-file scan: every 4-byte-aligned offset could be a length prefix. Slow but thorough.
    for ($off = 0; $off -le $bytes.Length - 4; $off += 4) {
        $row = Try-DecodeAt $bytes $off
        if ($row -and $seenOffsets.Add([int]$row.ByteOffset)) {
            $results.Add($row)
        }
    }
}

$results | Sort-Object Name | Format-Table -AutoSize
Write-Host "`n$($results.Count) validated row(s)."
