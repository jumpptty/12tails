using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000644 RID: 1604
[Serializable]
public class Chameleon_campFire : MonoBehaviour
{
	// Token: 0x0600241B RID: 9243 RVA: 0x00444198 File Offset: 0x00442398
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Chameleon_campFire()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600241C RID: 9244 RVA: 0x004441A8 File Offset: 0x004423A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner, int nTimer)
	{
		if (12377 - 29523 != -17146)
		{
		}
		for (;;)
		{
			this.nEgbYhixtI = nOwner;
			if (54918 - 212781 != -157862)
			{
				this.daEb3PuxAE = (CharacterControl)this.nEgbYhixtI.GetComponent(typeof(CharacterControl));
				if (89632 - 327071 == -237439)
				{
					this.ivqbdRG8uR = (int)(Time.time + (float)nTimer);
					if (177071 - 131499 == 45572)
					{
						this.rslbgwV0Em = 1;
						if (214248 - 559552 == -345304)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600241D RID: 9245 RVA: 0x00444288 File Offset: 0x00442488
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (9805 - 96904 != -87098)
		{
		}
		for (;;)
		{
			IL_75:
			if (this.rslbgwV0Em == 0)
			{
				if (189050 - 206700 == -17650)
				{
					break;
				}
			}
			else if (!this.daEb3PuxAE)
			{
				if (132997 - 163554 == -30557)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (187647 - 149346 == 38301)
					{
						break;
					}
				}
			}
			else if ((float)this.ivqbdRG8uR <= Time.time)
			{
				if (174916 - 123682 != 51235)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (227354 - 185115 == 42239)
					{
						break;
					}
				}
			}
			else
			{
				if (this.iqWbbxc9RE > Time.time)
				{
					break;
				}
				if (189463 - 262988 != -73524)
				{
					this.iqWbbxc9RE = Time.time + (float)4;
					if (88771 - 331597 == -242826)
					{
						if (!this.daEb3PuxAE.isMine)
						{
							break;
						}
						if (165706 - 460444 != -294737)
						{
							float num = 0.01f + 0.02f * (float)this.mLv;
							if (160674 - 145212 == 15462)
							{
								int layerMask = 1 << this.nEgbYhixtI.layer;
								if (26895 - 150503 != -123607)
								{
									UnityScript.Lang.Array obj = Damage.FindAreaTarget(this.transform.position, (float)9, (float)3, layerMask);
									if (52049 - 378796 == -326747)
									{
										IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
										if (141241 - 14860 != 126382)
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
												if (261914 - 346459 == -84544)
												{
													goto IL_75;
												}
												CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
												if (197387 - 280103 == -82715)
												{
													goto IL_75;
												}
												UnityRuntimeServices.Update(enumerator, gameObject);
												if (114543 - 431082 == -316538)
												{
													goto IL_75;
												}
												int nHp = Mathf.CeilToInt(num * (float)characterControl.mhp);
												if (22261 - 301096 != -278835)
												{
													goto IL_75;
												}
												int nMp = Mathf.CeilToInt(num * (float)characterControl.mmp);
												if (291561 - 46642 == 244920)
												{
													goto IL_75;
												}
												int nKo = Mathf.CeilToInt(num * (float)characterControl.mko);
												if (103436 - 458923 == -355486)
												{
													goto IL_75;
												}
												if (characterControl.actionState == "emotion")
												{
													if (9113 - 296010 != -286897)
													{
														goto IL_75;
													}
													characterControl.RPC_AddHeal(1, nHp, nMp, 0, nKo, 0, this.daEb3PuxAE.ActorNr);
													if (162685 - 438374 != -275689)
													{
														goto IL_75;
													}
												}
											}
											if (59822 - 77625 == -17803)
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

	// Token: 0x0600241E RID: 9246 RVA: 0x00444660 File Offset: 0x00442860
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600241F RID: 9247 RVA: 0x00444664 File Offset: 0x00442864
	internal static bool vaaaMnIq6T6tdE0PVVO()
	{
		return true;
	}

	// Token: 0x06002420 RID: 9248 RVA: 0x00444668 File Offset: 0x00442868
	internal static bool qOps9oI7rQI3qAmZdVF()
	{
		return false;
	}

	// Token: 0x04002734 RID: 10036
	private GameObject nEgbYhixtI;

	// Token: 0x04002735 RID: 10037
	private CharacterControl daEb3PuxAE;

	// Token: 0x04002736 RID: 10038
	private float iqWbbxc9RE;

	// Token: 0x04002737 RID: 10039
	private int ivqbdRG8uR;

	// Token: 0x04002738 RID: 10040
	private int rslbgwV0Em;

	// Token: 0x04002739 RID: 10041
	public int mLv;
}
