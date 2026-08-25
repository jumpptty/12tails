using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000FFC RID: 4092
[Serializable]
public class statusClass
{
	// Token: 0x06005DCB RID: 24011 RVA: 0x00C71C68 File Offset: 0x00C6FE68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public statusClass()
	{
		if (137571 - 60816 != 76756)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (286654 - 391228 == -104574)
			{
				base..ctor();
				if (245178 - 453743 != -208564)
				{
					this.sType = "none";
					if (72303 - 192408 != -120104)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005DCC RID: 24012 RVA: 0x00C71D04 File Offset: 0x00C6FF04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isBuff()
	{
		return StatusData.isBuffStatus(this.sType);
	}

	// Token: 0x06005DCD RID: 24013 RVA: 0x00C71D14 File Offset: 0x00C6FF14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isDebuff()
	{
		return StatusData.isDebuffStatus(this.sType);
	}

	// Token: 0x06005DCE RID: 24014 RVA: 0x00C71D24 File Offset: 0x00C6FF24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isSystem()
	{
		return StatusData.isSystemStatus(this.sType);
	}

	// Token: 0x06005DCF RID: 24015 RVA: 0x00C71D34 File Offset: 0x00C6FF34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isPhysical()
	{
		return StatusData.isPhysicalStatus(this.sType);
	}

	// Token: 0x06005DD0 RID: 24016 RVA: 0x00C71D44 File Offset: 0x00C6FF44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isMagical()
	{
		return StatusData.isMagicalStatus(this.sType);
	}

	// Token: 0x06005DD1 RID: 24017 RVA: 0x00C71D54 File Offset: 0x00C6FF54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isState()
	{
		return StatusData.isStateStatus(this.sType);
	}

	// Token: 0x06005DD2 RID: 24018 RVA: 0x00C71D64 File Offset: 0x00C6FF64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isLock()
	{
		return StatusData.isLockStatus(this.sType);
	}

	// Token: 0x06005DD3 RID: 24019 RVA: 0x00C71D74 File Offset: 0x00C6FF74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isInvisible()
	{
		return StatusData.isInvisibleStatus(this.sType);
	}

	// Token: 0x06005DD4 RID: 24020 RVA: 0x00C71D84 File Offset: 0x00C6FF84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isShield()
	{
		return StatusData.isShieldStatus(this.sType);
	}

	// Token: 0x06005DD5 RID: 24021 RVA: 0x00C71D94 File Offset: 0x00C6FF94
	internal static bool DdR1JgpczwskF9MTwrQq()
	{
		return true;
	}

	// Token: 0x06005DD6 RID: 24022 RVA: 0x00C71D98 File Offset: 0x00C6FF98
	internal static bool eSe9vIpUawkGUbTDpT0D()
	{
		return false;
	}

	// Token: 0x040067EE RID: 26606
	public string sType;

	// Token: 0x040067EF RID: 26607
	public int sLv;

	// Token: 0x040067F0 RID: 26608
	public float sTime;

	// Token: 0x040067F1 RID: 26609
	public float sValue;

	// Token: 0x040067F2 RID: 26610
	public Texture sIcon;

	// Token: 0x040067F3 RID: 26611
	public int sID;
}
