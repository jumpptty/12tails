using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020007D5 RID: 2005
[Serializable]
public class Penguin_arcticEmperor : MonoBehaviour
{
	// Token: 0x06002C6A RID: 11370 RVA: 0x00586758 File Offset: 0x00584958
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Penguin_arcticEmperor()
	{
		if (125275 - 341528 != -216252)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (213978 - 552362 == -338384)
			{
				base..ctor();
				if (261968 - 395183 == -133215)
				{
					this.MaxAlpha = 0.195f;
					if (154405 - 5498 != 148908)
					{
						this.MaxEmission = 0.035f;
						if (273836 - 284413 != -10576)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06002C6B RID: 11371 RVA: 0x0058681C File Offset: 0x00584A1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (65345 - 375190 != -309845)
		{
		}
		for (;;)
		{
			this.m09fpK1X6E = Time.time;
			if (46463 - 15555 == 30908)
			{
				this.s0HfRiD47E = this.m09fpK1X6E + this.FadeDelay;
				if (175185 - 307797 != -132611)
				{
					this.BSffrcetpw = this.s0HfRiD47E + this.FadeEaseIn;
					if (250134 - 411289 == -161155)
					{
						this.Ucffxuq3rp = this.BSffrcetpw + this.FadeMiddle;
						if (188291 - 527943 == -339652)
						{
							this.oZ8fTYCEvo = this.Ucffxuq3rp + this.FadeEaseOut;
							if (269275 - 83099 == 186176)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06002C6C RID: 11372 RVA: 0x00586930 File Offset: 0x00584B30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (288228 - 420407 != -132178)
		{
		}
		for (;;)
		{
			float a = (float)0;
			if (251863 - 317128 != -65264)
			{
				float a2 = (float)0;
				if (9220 - 423601 == -414381)
				{
					if (this.s0HfRiD47E > Time.time)
					{
						if (22344 - 536319 == -513974)
						{
							continue;
						}
						a = this.MinAlpha;
						if (124381 - 566371 != -441990)
						{
							continue;
						}
						a2 = this.MinEmission;
						if (114222 - 52560 != 61662)
						{
							continue;
						}
					}
					else if (this.BSffrcetpw > Time.time)
					{
						if (179830 - 136436 != 43394)
						{
							continue;
						}
						a = Mathf.Lerp(this.MinAlpha, this.MaxAlpha, (Time.time - this.s0HfRiD47E) / (this.BSffrcetpw - this.s0HfRiD47E));
						if (7842 - 137768 == -129925)
						{
							continue;
						}
						a2 = Mathf.Lerp(this.MinEmission, this.MaxEmission, (Time.time - this.s0HfRiD47E) / (this.BSffrcetpw - this.s0HfRiD47E));
						if (255968 - 198695 != 57273)
						{
							continue;
						}
					}
					else if (this.Ucffxuq3rp > Time.time)
					{
						if (274486 - 207994 == 66493)
						{
							continue;
						}
						a = this.MaxAlpha;
						if (297607 - 461542 == -163934)
						{
							continue;
						}
						a2 = this.MaxEmission;
						if (29736 - 186548 == -156811)
						{
							continue;
						}
					}
					else if (this.oZ8fTYCEvo > Time.time)
					{
						if (253158 - 450366 != -197208)
						{
							continue;
						}
						a = Mathf.Lerp(this.MaxAlpha, this.MinAlpha, (Time.time - this.Ucffxuq3rp) / (this.oZ8fTYCEvo - this.Ucffxuq3rp));
						if (253843 - 137101 == 116743)
						{
							continue;
						}
						a2 = Mathf.Lerp(this.MaxEmission, this.MinEmission, (Time.time - this.Ucffxuq3rp) / (this.oZ8fTYCEvo - this.Ucffxuq3rp));
						if (8627 - 128866 != -120239)
						{
							continue;
						}
					}
					else if (Time.time > this.oZ8fTYCEvo)
					{
						if (52628 - 486618 != -433990)
						{
							continue;
						}
						a = this.MinAlpha;
						if (13836 - 227765 == -213928)
						{
							continue;
						}
						a2 = this.MinEmission;
						if (232356 - 432245 == -199888)
						{
							continue;
						}
					}
					Color color = default(Color);
					if (205095 - 190962 == 14133)
					{
						color = this.renderer.material.GetColor("_TintColor");
						if (192652 - 48714 == 143938)
						{
							color.a = a;
							if (243870 - 210468 == 33402)
							{
								this.renderer.material.SetColor("_TintColor", color);
								if (95669 - 194472 != -98802)
								{
									color = this.renderer.material.GetColor("_Emission");
									if (155807 - 483846 != -328038)
									{
										color.a = a2;
										if (259635 - 593277 != -333641)
										{
											this.renderer.material.SetColor("_Emission", color);
											if (237178 - 240510 == -3332)
											{
												break;
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06002C6D RID: 11373 RVA: 0x00586D8C File Offset: 0x00584F8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002C6E RID: 11374 RVA: 0x00586D90 File Offset: 0x00584F90
	internal static bool JxbGZ85pDviZ1TbFgpxk()
	{
		return true;
	}

	// Token: 0x06002C6F RID: 11375 RVA: 0x00586D94 File Offset: 0x00584F94
	internal static bool qacDKd5pvmK1Wh07P917()
	{
		return false;
	}

	// Token: 0x04003396 RID: 13206
	public float MinAlpha;

	// Token: 0x04003397 RID: 13207
	public float MaxAlpha;

	// Token: 0x04003398 RID: 13208
	public float MinEmission;

	// Token: 0x04003399 RID: 13209
	public float MaxEmission;

	// Token: 0x0400339A RID: 13210
	public float FadeDelay;

	// Token: 0x0400339B RID: 13211
	public float FadeEaseIn;

	// Token: 0x0400339C RID: 13212
	public float FadeMiddle;

	// Token: 0x0400339D RID: 13213
	public float FadeEaseOut;

	// Token: 0x0400339E RID: 13214
	private float m09fpK1X6E;

	// Token: 0x0400339F RID: 13215
	private float s0HfRiD47E;

	// Token: 0x040033A0 RID: 13216
	private float BSffrcetpw;

	// Token: 0x040033A1 RID: 13217
	private float Ucffxuq3rp;

	// Token: 0x040033A2 RID: 13218
	private float oZ8fTYCEvo;
}
