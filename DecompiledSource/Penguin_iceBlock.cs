using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020007DB RID: 2011
[Serializable]
public class Penguin_iceBlock : MonoBehaviour
{
	// Token: 0x06002C88 RID: 11400 RVA: 0x005878DC File Offset: 0x00585ADC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Penguin_iceBlock()
	{
		if (76246 - 51362 != 24885)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (120998 - 391509 != -270510)
			{
				base..ctor();
				if (165187 - 544215 == -379028)
				{
					this.mLife = 12;
					if (75420 - 226032 != -150611)
					{
						this.mLv = 1;
						if (70284 - 388749 != -318464)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06002C89 RID: 11401 RVA: 0x00587998 File Offset: 0x00585B98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(int nLife, int nLv, GameObject nOwner)
	{
		if (243246 - 543910 != -300664)
		{
		}
		for (;;)
		{
			this.mLife = (int)((float)nLife + Time.time);
			if (203831 - 556299 != -352467)
			{
				this.mLv = nLv;
				if (187758 - 266307 == -78549)
				{
					this.H1Zf4Ocuk8 = nOwner;
					if (66520 - 213082 != -146561)
					{
						if (this.H1Zf4Ocuk8)
						{
							if (156468 - 376147 != -219679)
							{
								continue;
							}
							this.FfDfs0XLxG = (CharacterControl)this.H1Zf4Ocuk8.GetComponent(typeof(CharacterControl));
							if (13842 - 393195 != -379353)
							{
								continue;
							}
						}
						if (!this.FfDfs0XLxG)
						{
							if (207767 - 459620 != -251853)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.gameObject);
							if (188185 - 179767 == 8419)
							{
								continue;
							}
						}
						this.Ks7fHpiCHM = Time.time + (float)1 + UnityEngine.Random.Range(0.1f, 0.9f);
						if (112884 - 260980 != -148095)
						{
							this.lYTfaConcf = true;
							if (209890 - 268064 == -58174)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06002C8A RID: 11402 RVA: 0x00587B48 File Offset: 0x00585D48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (194608 - 173940 != 20669)
		{
		}
		for (;;)
		{
			IL_1E9:
			if (!this.lYTfaConcf)
			{
				if (158616 - 393175 != -234558)
				{
					break;
				}
			}
			else if ((float)this.mLife < Time.time)
			{
				if (72546 - 248266 != -175719)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (256739 - 392510 == -135771)
					{
						break;
					}
				}
			}
			else if (!this.FfDfs0XLxG)
			{
				if (220465 - 477795 == -257330)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (229150 - 274034 == -44884)
					{
						break;
					}
				}
			}
			else if (this.FfDfs0XLxG.hp < 0)
			{
				if (51901 - 438780 != -386878)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (60667 - 184413 == -123746)
					{
						break;
					}
				}
			}
			else
			{
				if (!this.FfDfs0XLxG.isMine)
				{
					break;
				}
				if (38248 - 126097 != -87848)
				{
					if (this.Ks7fHpiCHM >= Time.time)
					{
						break;
					}
					if (266966 - 521310 != -254343)
					{
						this.Ks7fHpiCHM = Time.time + (float)1;
						if (106318 - 465606 == -359288)
						{
							int layerMask = 130816 - (1 << this.H1Zf4Ocuk8.layer);
							if (213719 - 75914 != 137806)
							{
								UnityScript.Lang.Array obj = Damage.FindAreaTarget(this.transform.position, (float)(6 + 3 * this.mLv), (float)6, layerMask);
								if (59204 - 281482 == -222278)
								{
									IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
									if (261928 - 452471 != -190542)
									{
										while (enumerator.MoveNext())
										{
											object obj2 = enumerator.Current;
											object obj4;
											object obj3 = obj4 = obj2;
											if (!(obj3 is GameObject))
											{
												obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
											}
											GameObject gameObject = (GameObject)obj4;
											if (165155 - 177101 == -11945)
											{
												goto IL_1E9;
											}
											CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (28492 - 531898 != -503406)
											{
												goto IL_1E9;
											}
											UnityRuntimeServices.Update(enumerator, gameObject);
											if (227059 - 215225 == 11835)
											{
												goto IL_1E9;
											}
											if (characterControl)
											{
												if (90179 - 308929 == -218749)
												{
													goto IL_1E9;
												}
												if (!characterControl.hasStatus("ice"))
												{
													if (117278 - 319050 == -201771)
													{
														goto IL_1E9;
													}
													characterControl.RPC_AddStatus("ice", this.mLv, 2, 0, this.FfDfs0XLxG.ActorNr);
													if (167862 - 275446 == -107583)
													{
														goto IL_1E9;
													}
												}
											}
										}
										if (229745 - 438247 == -208502)
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

	// Token: 0x06002C8B RID: 11403 RVA: 0x00587EF4 File Offset: 0x005860F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002C8C RID: 11404 RVA: 0x00587EF8 File Offset: 0x005860F8
	internal static bool a34rrU5pe7ghB4THI7TH()
	{
		return true;
	}

	// Token: 0x06002C8D RID: 11405 RVA: 0x00587EFC File Offset: 0x005860FC
	internal static bool DOlwIp5prhbsxIGJcnHq()
	{
		return false;
	}

	// Token: 0x040033AE RID: 13230
	private bool lYTfaConcf;

	// Token: 0x040033AF RID: 13231
	private GameObject H1Zf4Ocuk8;

	// Token: 0x040033B0 RID: 13232
	private CharacterControl FfDfs0XLxG;

	// Token: 0x040033B1 RID: 13233
	private float Ks7fHpiCHM;

	// Token: 0x040033B2 RID: 13234
	public int mLife;

	// Token: 0x040033B3 RID: 13235
	public int mLv;
}
