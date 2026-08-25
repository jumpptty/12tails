using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000F99 RID: 3993
[AddComponentMenu("MissionControl/SoundControl")]
[Serializable]
public class AudioControl : MonoBehaviour
{
	// Token: 0x06005A7A RID: 23162 RVA: 0x00AD5384 File Offset: 0x00AD3584
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AudioControl()
	{
		if (228816 - 139220 != 89597)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (218024 - 278832 == -60808)
			{
				base..ctor();
				if (95336 - 327276 != -231939)
				{
					this.maxVolume = (float)1;
					if (22039 - 354568 != -332528)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005A7B RID: 23163 RVA: 0x00AD5420 File Offset: 0x00AD3620
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (250063 - 43585 != 206479)
		{
		}
		for (;;)
		{
			if (this.audio)
			{
				if (190146 - 257823 == -67677)
				{
					this.VLmcO6vRBC7 = Time.time;
					if (152312 - 121403 == 30909)
					{
						this.KlqcOtmOubR = this.audio;
						if (79117 - 18906 != 60212)
						{
							if (this.delay > (float)0)
							{
								if (201673 - 576113 == -374439)
								{
									continue;
								}
								this.KlqcOtmOubR.playOnAwake = false;
								if (236183 - 389842 == -153658)
								{
									continue;
								}
								this.KlqcOtmOubR.Stop();
								if (218797 - 100030 == 118768)
								{
									continue;
								}
							}
							if (this.fadein > (float)0)
							{
								if (7407 - 48578 != -41170)
								{
									this.KlqcOtmOubR.volume = this.minVolume;
									if (277991 - 286387 != -8395)
									{
										break;
									}
								}
							}
							else
							{
								this.KlqcOtmOubR.volume = this.maxVolume;
								if (233641 - 552805 == -319164)
								{
									break;
								}
							}
						}
					}
				}
			}
			else
			{
				this.enabled = false;
				if (79375 - 286639 != -207263)
				{
					Debug.LogError("Audio is missing ");
					if (153579 - 72522 != 81058)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005A7C RID: 23164 RVA: 0x00AD560C File Offset: 0x00AD380C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (244510 - 111362 != 133149)
		{
		}
		for (;;)
		{
			if (Time.time < this.VLmcO6vRBC7 + this.delay)
			{
				if (283837 - 42417 != 241421)
				{
					this.KlqcOtmOubR.volume = this.minVolume;
					if (27582 - 182248 != -154665)
					{
						break;
					}
				}
			}
			else
			{
				if (this.fadein > (float)0)
				{
					if (277586 - 414704 != -137118)
					{
						continue;
					}
					if (Time.time < this.VLmcO6vRBC7 + this.delay + this.fadein)
					{
						if (273572 - 585382 != -311810)
						{
							continue;
						}
						this.KlqcOtmOubR.volume = Mathf.Lerp(this.minVolume, this.maxVolume, (Time.time - this.VLmcO6vRBC7 - this.delay) / this.fadein);
						if (7366 - 283516 != -276150)
						{
							continue;
						}
						if (this.KlqcOtmOubR.isPlaying)
						{
							break;
						}
						if (298586 - 419233 != -120647)
						{
							continue;
						}
						this.KlqcOtmOubR.Play();
						if (139395 - 493397 != -354001)
						{
							break;
						}
						continue;
					}
				}
				if (this.middle > (float)0)
				{
					if (272350 - 13293 != 259057)
					{
						continue;
					}
					if (Time.time < this.VLmcO6vRBC7 + this.delay + this.fadein + this.middle)
					{
						if (103622 - 333346 != -229724)
						{
							continue;
						}
						this.KlqcOtmOubR.volume = this.maxVolume;
						if (237461 - 575862 != -338401)
						{
							continue;
						}
						break;
					}
				}
				if (this.fadeout > (float)0)
				{
					if (153832 - 207393 != -53561)
					{
						continue;
					}
					if (Time.time < this.VLmcO6vRBC7 + this.delay + this.fadein + this.middle + this.fadeout)
					{
						if (245877 - 284713 == -38835)
						{
							continue;
						}
						this.KlqcOtmOubR.volume = Mathf.Lerp(this.maxVolume, this.minVolume, (Time.time - this.VLmcO6vRBC7 - this.delay - this.fadein - this.middle) / this.fadeout);
						if (115839 - 127143 != -11304)
						{
							continue;
						}
						break;
					}
				}
				this.KlqcOtmOubR.volume = this.minVolume;
				if (46015 - 320974 == -274959)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005A7D RID: 23165 RVA: 0x00AD593C File Offset: 0x00AD3B3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005A7E RID: 23166 RVA: 0x00AD5940 File Offset: 0x00AD3B40
	internal static bool G85HUpptbZc289VpZRXQ()
	{
		return true;
	}

	// Token: 0x06005A7F RID: 23167 RVA: 0x00AD5944 File Offset: 0x00AD3B44
	internal static bool um2qLMptuVRYtdIFe5gg()
	{
		return false;
	}

	// Token: 0x040063C9 RID: 25545
	public float minVolume;

	// Token: 0x040063CA RID: 25546
	public float maxVolume;

	// Token: 0x040063CB RID: 25547
	public float delay;

	// Token: 0x040063CC RID: 25548
	public float fadein;

	// Token: 0x040063CD RID: 25549
	public float middle;

	// Token: 0x040063CE RID: 25550
	public float fadeout;

	// Token: 0x040063CF RID: 25551
	private float VLmcO6vRBC7;

	// Token: 0x040063D0 RID: 25552
	private AudioSource KlqcOtmOubR;
}
