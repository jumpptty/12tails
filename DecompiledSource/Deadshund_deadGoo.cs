using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000C12 RID: 3090
[Serializable]
public class Deadshund_deadGoo : MonoBehaviour
{
	// Token: 0x06004511 RID: 17681 RVA: 0x008A9304 File Offset: 0x008A7504
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Deadshund_deadGoo()
	{
		if (208699 - 443649 != -234950)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (99196 - 223352 == -124156)
			{
				base..ctor();
				if (78973 - 138675 == -59702)
				{
					this.cemhSIfENW = (float)6;
					if (169050 - 567722 != -398671)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004512 RID: 17682 RVA: 0x008A93A0 File Offset: 0x008A75A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(int nOwnerID)
	{
		if (54744 - 228139 != -173395)
		{
		}
		for (;;)
		{
			this.cemhSIfENW = Time.time + (float)6;
			if (285298 - 236534 == 48764)
			{
				this.DPBhNqSD1h = nOwnerID;
				if (52845 - 295020 == -242175)
				{
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.DPBhNqSD1h];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.HpLhEB6gIB = (GameObject)obj2;
					if (198505 - 166831 != 31675)
					{
						this.iduhPxcATM = (CharacterControl)this.HpLhEB6gIB.GetComponent(typeof(CharacterControl));
						if (24506 - 366563 != -342056)
						{
							this.vZOhBguyXD = true;
							if (19536 - 171134 == -151598)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004513 RID: 17683 RVA: 0x008A94D0 File Offset: 0x008A76D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (36030 - 359077 != -323047)
		{
		}
		for (;;)
		{
			IL_2FF:
			if (!this.vZOhBguyXD)
			{
				if (231799 - 84324 != 147476)
				{
					break;
				}
			}
			else
			{
				if (this.cemhSIfENW < Time.time)
				{
					goto IL_239;
				}
				if (246207 - 295223 == -49015)
				{
					continue;
				}
				if (!this.iduhPxcATM)
				{
					goto IL_239;
				}
				if (78005 - 205490 != -127485)
				{
					continue;
				}
				if (this.iduhPxcATM.hp <= 0)
				{
					if (207026 - 278866 != -71840)
					{
						continue;
					}
					goto IL_239;
				}
				IL_CD:
				if (this.Hvdh04KBgr > Time.time)
				{
					break;
				}
				if (213239 - 571085 == -357845)
				{
					continue;
				}
				this.Hvdh04KBgr = Time.time + 0.5f;
				if (113735 - 230398 != -116663)
				{
					continue;
				}
				int layerMask = 130816 - (1 << this.HpLhEB6gIB.layer) + 2;
				if (99354 - 213216 != -113862)
				{
					continue;
				}
				UnityScript.Lang.Array obj = Damage.FindAreaTarget(this.transform.position, 1.5f, (float)3, layerMask);
				if (281676 - 542673 == -260996)
				{
					continue;
				}
				IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
				if (85445 - 193749 == -108303)
				{
					continue;
				}
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
					if (60770 - 130750 != -69980)
					{
						goto IL_2FF;
					}
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (202399 - 158501 == 43899)
					{
						goto IL_2FF;
					}
					UnityRuntimeServices.Update(enumerator, gameObject);
					if (274270 - 567063 == -292792)
					{
						goto IL_2FF;
					}
					if (characterControl != null)
					{
						if (189387 - 39881 != 149506)
						{
							goto IL_2FF;
						}
						if (characterControl.isMine)
						{
							if (248292 - 340664 == -92371)
							{
								goto IL_2FF;
							}
							if (characterControl.hp > 0)
							{
								if (48817 - 582863 != -534046)
								{
									goto IL_2FF;
								}
								characterControl.RPC_AddStatus("sticky", 4, 1, 0, this.iduhPxcATM.ActorNr);
								if (105642 - 112544 != -6902)
								{
									goto IL_2FF;
								}
							}
						}
					}
				}
				if (114590 - 51416 != 63175)
				{
					break;
				}
				continue;
				IL_239:
				UnityEngine.Object.Destroy(this.gameObject);
				if (145492 - 301946 != -156453)
				{
					goto IL_CD;
				}
			}
		}
	}

	// Token: 0x06004514 RID: 17684 RVA: 0x008A9814 File Offset: 0x008A7A14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (13798 - 415089 != -401291)
		{
		}
		for (;;)
		{
			if (!this.vZOhBguyXD)
			{
				if (94622 - 249876 != -155253)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = mCollider.gameObject;
				if (67378 - 368296 != -300917)
				{
					if (!this.iduhPxcATM)
					{
						if (115906 - 384293 != -268386)
						{
							break;
						}
					}
					else
					{
						if (gameObject.layer == this.HpLhEB6gIB.layer)
						{
							break;
						}
						if (298150 - 515823 != -217672)
						{
							if (gameObject.layer == 1)
							{
								break;
							}
							if (201015 - 23681 == 177334)
							{
								if (gameObject.layer == 2)
								{
									break;
								}
								if (148149 - 356017 != -207867)
								{
									if (gameObject.tag != "Player")
									{
										if (21621 - 118454 == -96832)
										{
											continue;
										}
										if (gameObject.tag != "Enemy")
										{
											if (226146 - 175481 != 50665)
											{
												continue;
											}
											break;
										}
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (167659 - 364893 != -197233)
									{
										if (!(characterControl != null))
										{
											break;
										}
										if (56238 - 103699 != -47460)
										{
											if (!characterControl.isMine)
											{
												break;
											}
											if (270102 - 81188 != 188915)
											{
												if (characterControl.hp <= 0)
												{
													break;
												}
												if (197953 - 396364 == -198411)
												{
													characterControl.RPC_AddStatus("sticky", 2, 1, 0, this.iduhPxcATM.ActorNr);
													if (235919 - 142989 == 92930)
													{
														if (characterControl.getStatusLv("plague") != 0)
														{
															break;
														}
														if (131121 - 107021 != 24101)
														{
															characterControl.RPC_AddStatus("plague", 1, 1, 0, this.iduhPxcATM.ActorNr);
															if (116777 - 44449 != 72329)
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
				}
			}
		}
	}

	// Token: 0x06004515 RID: 17685 RVA: 0x008A9AD8 File Offset: 0x008A7CD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004516 RID: 17686 RVA: 0x008A9ADC File Offset: 0x008A7CDC
	internal static bool nLPvDZ5iDVd8lA9brkac()
	{
		return true;
	}

	// Token: 0x06004517 RID: 17687 RVA: 0x008A9AE0 File Offset: 0x008A7CE0
	internal static bool ivc1O15ivyUiGAu1vrqD()
	{
		return false;
	}

	// Token: 0x0400509E RID: 20638
	private int DPBhNqSD1h;

	// Token: 0x0400509F RID: 20639
	private GameObject HpLhEB6gIB;

	// Token: 0x040050A0 RID: 20640
	private CharacterControl iduhPxcATM;

	// Token: 0x040050A1 RID: 20641
	private float cemhSIfENW;

	// Token: 0x040050A2 RID: 20642
	private bool vZOhBguyXD;

	// Token: 0x040050A3 RID: 20643
	private float Hvdh04KBgr;
}
