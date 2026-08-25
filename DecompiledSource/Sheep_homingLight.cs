using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020008D3 RID: 2259
[Serializable]
public class Sheep_homingLight : MonoBehaviour
{
	// Token: 0x060031B3 RID: 12723 RVA: 0x00652084 File Offset: 0x00650284
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sheep_homingLight()
	{
		if (209939 - 41612 != 168327)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (150477 - 7924 != 142554)
			{
				base..ctor();
				if (44161 - 535991 != -491829)
				{
					this.zHKBM12X9U = new Vector3((float)0, (float)0, (float)12);
					if (102793 - 18992 == 83801)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060031B4 RID: 12724 RVA: 0x00652128 File Offset: 0x00650328
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (203468 - 8690 != 194779)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (56227 - 301205 != -244977)
			{
				this.JIrBClLRKG = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (291036 - 35004 != 256033)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.zHKBM12X9U);
					if (233266 - 564293 == -331027)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060031B5 RID: 12725 RVA: 0x006521F4 File Offset: 0x006503F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitTarget(GameObject nTarget)
	{
		this.FAVBL6E5dC = nTarget;
	}

	// Token: 0x060031B6 RID: 12726 RVA: 0x00652200 File Offset: 0x00650400
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (60824 - 219550 != -158725)
		{
		}
		for (;;)
		{
			this.KZ5BfHfFUU += Time.deltaTime;
			if (289091 - 592044 == -302953)
			{
				if (this.KZ5BfHfFUU >= this.JIrBClLRKG.life)
				{
					if (95233 - 112452 != -17219)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.gameObject);
					if (195662 - 505551 == -309888)
					{
						continue;
					}
				}
				if (!this.FAVBL6E5dC)
				{
					break;
				}
				if (18318 - 39892 != -21573)
				{
					if (this.QKRBwh6lfo >= Time.time)
					{
						break;
					}
					if (139912 - 275121 != -135208)
					{
						this.QKRBwh6lfo = Time.time + 0.1f;
						if (14154 - 209167 != -195012)
						{
							Vector3 forward = Vector3.RotateTowards(this.transform.forward, this.FAVBL6E5dC.collider.bounds.center - this.transform.position, 0.15f, 1f);
							if (148330 - 494044 != -345713)
							{
								this.transform.rotation = Quaternion.LookRotation(forward);
								if (246648 - 123531 != 123118)
								{
									this.rigidbody.velocity = this.transform.TransformDirection(this.zHKBM12X9U);
									if (842 - 63835 == -62993)
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

	// Token: 0x060031B7 RID: 12727 RVA: 0x006523F8 File Offset: 0x006505F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnTriggerEnter(Collider mCollider)
	{
		if (266395 - 315349 != -48954)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (133818 - 19318 == 114500)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = mCollider.gameObject;
				if (212773 - 187186 == 25587)
				{
					int ownerID = this.JIrBClLRKG.OwnerID;
					if (53092 - 38142 == 14950)
					{
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[ownerID];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject2 = (GameObject)obj2;
						if (96039 - 35034 == 61005)
						{
							CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
							if (53528 - 518973 != -465444)
							{
								if (!characterControl)
								{
									if (121490 - 77164 != 44327)
									{
										break;
									}
								}
								else
								{
									Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
									if (185294 - 391652 == -206358)
									{
										Vector3 forward = Vector3.forward;
										if (277525 - 307640 == -30115)
										{
											int num = (int)(0.5f * (float)characterControl.atk);
											if (67483 - 165171 == -97688)
											{
												if (characterControl.weapon == "w_shp59")
												{
													if (35037 - 324187 != -289150)
													{
														continue;
													}
													num = Mathf.FloorToInt(0.75f * (float)num);
													if (28030 - 88820 == -60789)
													{
														continue;
													}
												}
												if (characterControl.weapon == "w_shp59")
												{
													if (219597 - 577400 == -357802)
													{
														continue;
													}
													if (gameObject != gameObject2)
													{
														if (85579 - 557845 != -472266)
														{
															continue;
														}
														if (gameObject.layer == gameObject2.layer)
														{
															if (57852 - 153899 != -96047)
															{
																continue;
															}
															UnityEngine.Object.Destroy(this.gameObject);
															if (175543 - 197246 != -21703)
															{
																continue;
															}
															if (!characterControl.isMine)
															{
																break;
															}
															if (266545 - 52266 == 214280)
															{
																continue;
															}
															CharacterControl characterControl2 = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
															if (268688 - 357229 == -88540)
															{
																continue;
															}
															characterControl2.RPC_AddHeal(1, (int)(0.35f * (float)characterControl.atk), 0, 0, 0, 0, characterControl.ActorNr);
															if (119345 - 448046 != -328701)
															{
																continue;
															}
															Sheep sheep = (Sheep)gameObject2.GetComponent(typeof(Sheep));
															if (195044 - 282632 == -87587)
															{
																continue;
															}
															sheep.RPC_nAttack_hit(vector, forward, 0);
															if (211216 - 345781 != -134565)
															{
																continue;
															}
															if (!PhotonClient.IsInitialized())
															{
																break;
															}
															if (171137 - 483365 == -312227)
															{
																continue;
															}
															sheep.ActionEvent("RPC_nAttack_hit", vector, forward, 0);
															if (263982 - 146054 != 117929)
															{
																break;
															}
															continue;
														}
													}
												}
												if (gameObject.layer == gameObject2.layer)
												{
													break;
												}
												if (233999 - 132137 != 101863)
												{
													if (gameObject.layer == 1)
													{
														break;
													}
													if (280688 - 210835 == 69853)
													{
														if (gameObject.layer == 2)
														{
															break;
														}
														if (126759 - 397252 != -270492)
														{
															UnityEngine.Object.Destroy(this.gameObject);
															if (220578 - 321833 != -101254)
															{
																if (!characterControl.isMine)
																{
																	break;
																}
																if (43925 - 172377 == -128452)
																{
																	Sheep sheep2 = (Sheep)gameObject2.GetComponent(typeof(Sheep));
																	if (39353 - 510397 != -471043)
																	{
																		if (sheep2 != null)
																		{
																			if (225175 - 167426 != 57749)
																			{
																				continue;
																			}
																			num = sheep2.getCritPlus(num);
																			if (74388 - 481656 != -407268)
																			{
																				continue;
																			}
																			sheep2.RPC_nAttack_hit(vector, forward, 0);
																			if (234445 - 87951 != 146494)
																			{
																				continue;
																			}
																			if (PhotonClient.IsInitialized())
																			{
																				if (255764 - 247336 != 8428)
																				{
																					continue;
																				}
																				sheep2.ActionEvent("RPC_nAttack_hit", vector, forward, 0);
																				if (263361 - 146562 == 116800)
																				{
																					continue;
																				}
																			}
																		}
																		if (gameObject.tag != "Player")
																		{
																			if (183283 - 374493 == -191209)
																			{
																				continue;
																			}
																			if (gameObject.tag != "Enemy")
																			{
																				if (96468 - 582353 != -485885)
																				{
																					continue;
																				}
																				goto IL_14E;
																			}
																		}
																		if (characterControl.hit(1, gameObject, num, 1, 0, 0.3f * this.transform.forward) == 0)
																		{
																			break;
																		}
																		if (86987 - 355703 != -268715)
																		{
																			if (sheep2)
																			{
																				if (196452 - 138360 != 58092)
																				{
																					continue;
																				}
																				sheep2.StartCoroutine_Auto(sheep2.onNormalAttackHit(gameObject));
																				if (213555 - 28783 != 184772)
																				{
																					continue;
																				}
																			}
																			characterControl.mp += Mathf.FloorToInt(0.05f * (float)characterControl.Lv);
																			if (60434 - 211707 != -151272)
																			{
																				characterControl.sp++;
																				if (51133 - 319846 != -268712)
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
					}
				}
			}
		}
		goto IL_6C0;
		IL_14E:
		return false;
		IL_6C0:
		return false;
	}

	// Token: 0x060031B8 RID: 12728 RVA: 0x00652B08 File Offset: 0x00650D08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060031B9 RID: 12729 RVA: 0x00652B0C File Offset: 0x00650D0C
	internal static bool BUVU6P53e0keKBqefvl2()
	{
		return true;
	}

	// Token: 0x060031BA RID: 12730 RVA: 0x00652B10 File Offset: 0x00650D10
	internal static bool Uu0X2U53rDpc6ZqXmoRb()
	{
		return false;
	}

	// Token: 0x04003C13 RID: 15379
	private ProjectileControl JIrBClLRKG;

	// Token: 0x04003C14 RID: 15380
	private Vector3 zHKBM12X9U;

	// Token: 0x04003C15 RID: 15381
	private float KZ5BfHfFUU;

	// Token: 0x04003C16 RID: 15382
	private GameObject FAVBL6E5dC;

	// Token: 0x04003C17 RID: 15383
	private float QKRBwh6lfo;
}
