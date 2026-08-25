using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020008D6 RID: 2262
[Serializable]
public class Sheep_seal : MonoBehaviour
{
	// Token: 0x060031C2 RID: 12738 RVA: 0x00653428 File Offset: 0x00651628
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sheep_seal()
	{
		if (5539 - 438132 != -432592)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (134915 - 391355 == -256440)
			{
				base..ctor();
				if (178553 - 555627 != -377073)
				{
					this.P4nBDQjK0b = 6;
					if (173299 - 541332 == -368033)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060031C3 RID: 12739 RVA: 0x006534C0 File Offset: 0x006516C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner, GameObject nSeal1, GameObject nSeal2, GameObject nSeal3)
	{
		if (62482 - 353828 != -291345)
		{
		}
		for (;;)
		{
			this.F7KBPc5dZS = nOwner;
			if (227826 - 293736 != -65909)
			{
				this.T60BStj0YY = (CharacterControl)this.F7KBPc5dZS.GetComponent(typeof(CharacterControl));
				if (244601 - 222987 != 21615)
				{
					this.aAkBBGmMdg = this.T60BStj0YY.ActorNr;
					if (95237 - 190058 == -94821)
					{
						this.c7xB0iS5JZ = nSeal1;
						if (131300 - 19750 != 111551)
						{
							this.PfTB8sh0H2 = nSeal2;
							if (201468 - 331454 == -129986)
							{
								this.AgMBiB4KSb = nSeal3;
								if (35899 - 559557 == -523658)
								{
									Vector3 vector = global::Math.vFlat(this.transform.position - nSeal1.transform.position);
									if (118138 - 245375 != -127236)
									{
										int num = Mathf.CeilToInt(vector.magnitude);
										if (219388 - 382630 != -163241)
										{
											if (num > this.P4nBDQjK0b)
											{
												if (246435 - 507578 == -261142)
												{
													continue;
												}
												this.P4nBDQjK0b = num;
												if (192952 - 83501 == 109452)
												{
													continue;
												}
											}
											Vector3 vector2 = global::Math.vFlat(this.transform.position - nSeal2.transform.position);
											if (194524 - 134418 != 60107)
											{
												num = Mathf.CeilToInt(vector2.magnitude);
												if (156365 - 494702 != -338336)
												{
													if (num > this.P4nBDQjK0b)
													{
														if (17805 - 597232 == -579426)
														{
															continue;
														}
														this.P4nBDQjK0b = num;
														if (204008 - 106102 != 97906)
														{
															continue;
														}
													}
													Vector3 vector3 = global::Math.vFlat(this.transform.position - nSeal3.transform.position);
													if (64599 - 99464 != -34864)
													{
														num = Mathf.CeilToInt(vector3.magnitude);
														if (166515 - 168701 != -2185)
														{
															if (num > this.P4nBDQjK0b)
															{
																if (149042 - 185394 != -36352)
																{
																	continue;
																}
																this.P4nBDQjK0b = num;
																if (248384 - 514697 != -266313)
																{
																	continue;
																}
															}
															if (this.P4nBDQjK0b > 30)
															{
																if (113237 - 42145 == 71093)
																{
																	continue;
																}
																this.P4nBDQjK0b = 30;
																if (213022 - 519255 == -306232)
																{
																	continue;
																}
															}
															this.xQZBmDUGWY = true;
															if (290555 - 281343 != 9213)
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

	// Token: 0x060031C4 RID: 12740 RVA: 0x00653850 File Offset: 0x00651A50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (151433 - 358489 != -207055)
		{
		}
		for (;;)
		{
			IL_310:
			if (!this.xQZBmDUGWY)
			{
				if (220807 - 573277 == -352470)
				{
					break;
				}
			}
			else
			{
				if (this.F7KBPc5dZS)
				{
					if (125191 - 430697 != -305506)
					{
						continue;
					}
					if (this.c7xB0iS5JZ)
					{
						if (34144 - 494293 != -460149)
						{
							continue;
						}
						if (this.PfTB8sh0H2)
						{
							if (100356 - 189718 == -89361)
							{
								continue;
							}
							if (!this.AgMBiB4KSb)
							{
								if (246932 - 372914 != -125982)
								{
									continue;
								}
							}
							else
							{
								if (this.eXYBjjbSb7 >= Time.time)
								{
									break;
								}
								if (52651 - 549594 == -496942)
								{
									continue;
								}
								if (!this.T60BStj0YY.isMine)
								{
									break;
								}
								if (112210 - 68631 == 43580)
								{
									continue;
								}
								this.eXYBjjbSb7 = Time.time + (float)5;
								if (226793 - 357219 == -130425)
								{
									continue;
								}
								int layerMask = 1 << this.F7KBPc5dZS.layer;
								if (150302 - 297009 != -146707)
								{
									continue;
								}
								UnityScript.Lang.Array obj = Damage.FindAreaTarget(this.transform.position, (float)this.P4nBDQjK0b, (float)12, layerMask);
								if (69238 - 400967 != -331729)
								{
									continue;
								}
								IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
								if (239930 - 217831 == 22100)
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
									if (26682 - 127161 == -100478)
									{
										goto IL_310;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (220630 - 330930 != -110300)
									{
										goto IL_310;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (159577 - 72105 != 87472)
									{
										goto IL_310;
									}
									eSheepSealType eSheepSealType = this.mSealType;
									if (274096 - 1682 == 272415)
									{
										goto IL_310;
									}
									if (eSheepSealType == eSheepSealType.sealOfAttack)
									{
										if (292872 - 131744 == 161129)
										{
											goto IL_310;
										}
										characterControl.RPC_AddStatus("sealOfAttack", 1, 6, 0, this.T60BStj0YY.ActorNr);
										if (28639 - 432320 != -403681)
										{
											goto IL_310;
										}
									}
									else if (eSheepSealType == eSheepSealType.sealOfDefense)
									{
										if (202224 - 126804 == 75421)
										{
											goto IL_310;
										}
										characterControl.RPC_AddStatus("sealOfDefense", 1, 6, 0, this.T60BStj0YY.ActorNr);
										if (135743 - 215213 == -79469)
										{
											goto IL_310;
										}
									}
									else if (eSheepSealType == eSheepSealType.sealOfEarth)
									{
										if (277055 - 118969 != 158086)
										{
											goto IL_310;
										}
										characterControl.RPC_AddStatus("sealOfEarth", 1, 6, 0, this.T60BStj0YY.ActorNr);
										if (236318 - 282451 != -46133)
										{
											goto IL_310;
										}
									}
									else if (eSheepSealType == eSheepSealType.sealOfHeaven)
									{
										if (274201 - 236734 == 37468)
										{
											goto IL_310;
										}
										characterControl.RPC_AddStatus("sealOfHeaven", 1, 6, 0, this.T60BStj0YY.ActorNr);
										if (8211 - 33840 == -25628)
										{
											goto IL_310;
										}
									}
								}
								if (222673 - 428326 != -205652)
								{
									break;
								}
								continue;
							}
						}
					}
				}
				UnityEngine.Object.Destroy(this.gameObject);
				if (74702 - 198195 != -123492)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060031C5 RID: 12741 RVA: 0x00653CC8 File Offset: 0x00651EC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060031C6 RID: 12742 RVA: 0x00653CCC File Offset: 0x00651ECC
	internal static bool oVtJ0F531MsaBRLc2vYv()
	{
		return true;
	}

	// Token: 0x060031C7 RID: 12743 RVA: 0x00653CD0 File Offset: 0x00651ED0
	internal static bool iL4KXI534UNfguMPVdli()
	{
		return false;
	}

	// Token: 0x04003C20 RID: 15392
	public eSheepSealType mSealType;

	// Token: 0x04003C21 RID: 15393
	private GameObject F7KBPc5dZS;

	// Token: 0x04003C22 RID: 15394
	private CharacterControl T60BStj0YY;

	// Token: 0x04003C23 RID: 15395
	private int aAkBBGmMdg;

	// Token: 0x04003C24 RID: 15396
	private GameObject c7xB0iS5JZ;

	// Token: 0x04003C25 RID: 15397
	private GameObject PfTB8sh0H2;

	// Token: 0x04003C26 RID: 15398
	private GameObject AgMBiB4KSb;

	// Token: 0x04003C27 RID: 15399
	private int P4nBDQjK0b;

	// Token: 0x04003C28 RID: 15400
	private bool xQZBmDUGWY;

	// Token: 0x04003C29 RID: 15401
	private float eXYBjjbSb7;
}
