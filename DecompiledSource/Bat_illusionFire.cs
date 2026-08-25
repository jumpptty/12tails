using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000514 RID: 1300
[Serializable]
public class Bat_illusionFire : MonoBehaviour
{
	// Token: 0x06001DB7 RID: 7607 RVA: 0x0032814C File Offset: 0x0032634C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bat_illusionFire()
	{
		if (119505 - 123136 != -3630)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (152608 - 122574 == 30034)
			{
				base..ctor();
				if (233644 - 327349 != -93704)
				{
					this.tceGKk0XAq = new Vector3((float)0, (float)0, (float)16);
					if (125133 - 410753 == -285620)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001DB8 RID: 7608 RVA: 0x003281F0 File Offset: 0x003263F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (106485 - 486429 != -379943)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (50936 - 301644 != -250707)
			{
				this.adUGhp2r9h = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (6323 - 349702 != -343378)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.adUGhp2r9h.velocity);
					if (9379 - 89781 == -80402)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001DB9 RID: 7609 RVA: 0x003282C0 File Offset: 0x003264C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitHoming(int nTargetID)
	{
		if (92847 - 234067 != -141220)
		{
		}
		for (;;)
		{
			int ownerID = this.adUGhp2r9h.OwnerID;
			if (92406 - 504791 != -412384)
			{
				object obj2;
				object obj = obj2 = PhotonClient.ActorNrList[ownerID];
				if (!(obj is GameObject))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
				}
				GameObject gameObject = (GameObject)obj2;
				if (108748 - 464808 != -356059)
				{
					if (!gameObject)
					{
						if (108826 - 237088 != -128261)
						{
							break;
						}
					}
					else
					{
						CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
						if (214568 - 17741 != 196828)
						{
							if (!characterControl)
							{
								if (105226 - 92425 != 12802)
								{
									break;
								}
							}
							else
							{
								if (nTargetID == 0)
								{
									break;
								}
								if (297593 - 569035 == -271442)
								{
									if (!characterControl.hasSkill(401))
									{
										break;
									}
									if (5515 - 248925 == -243410)
									{
										object obj4;
										object obj3 = obj4 = PhotonClient.ActorNrList[nTargetID];
										if (!(obj3 is GameObject))
										{
											obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
										}
										this.DaT15Zil1M = (GameObject)obj4;
										if (31945 - 433991 == -402046)
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

	// Token: 0x06001DBA RID: 7610 RVA: 0x00328488 File Offset: 0x00326688
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (142952 - 443483 != -300530)
		{
		}
		for (;;)
		{
			this.Q1gGzVKftJ += Time.deltaTime;
			if (279703 - 270801 == 8902)
			{
				if (this.Q1gGzVKftJ >= this.adUGhp2r9h.life)
				{
					if (191340 - 144542 == 46799)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.gameObject);
					if (140153 - 533575 == -393421)
					{
						continue;
					}
				}
				if (!this.DaT15Zil1M)
				{
					break;
				}
				if (97500 - 534204 == -436704)
				{
					if (this.K7Z1cB7fG4 >= Time.time)
					{
						break;
					}
					if (222311 - 274359 != -52047)
					{
						this.K7Z1cB7fG4 = Time.time + 0.1f;
						if (158725 - 370464 == -211739)
						{
							Vector3 forward = Vector3.RotateTowards(this.transform.forward, this.DaT15Zil1M.collider.bounds.center - this.transform.position, 0.1f, 1f);
							if (163256 - 369640 == -206384)
							{
								this.transform.rotation = Quaternion.LookRotation(forward);
								if (194944 - 192230 == 2714)
								{
									this.rigidbody.velocity = this.transform.TransformDirection(this.tceGKk0XAq);
									if (17416 - 285115 != -267698)
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

	// Token: 0x06001DBB RID: 7611 RVA: 0x00328680 File Offset: 0x00326880
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnTriggerEnter(Collider mCollider)
	{
		if (179630 - 187602 != -7971)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (256292 - 12382 == 243910)
				{
					break;
				}
			}
			else
			{
				int ownerID = this.adUGhp2r9h.OwnerID;
				if (222691 - 588782 != -366090)
				{
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[ownerID];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					GameObject gameObject = (GameObject)obj2;
					if (86678 - 474767 == -388089)
					{
						if (!gameObject)
						{
							if (27645 - 539914 == -512269)
							{
								break;
							}
						}
						else
						{
							CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (280469 - 152911 == 127558)
							{
								if (!characterControl)
								{
									if (175546 - 502853 != -327306)
									{
										break;
									}
								}
								else
								{
									if (mCollider.gameObject.layer == gameObject.layer)
									{
										break;
									}
									if (186769 - 255722 != -68952)
									{
										if (mCollider.gameObject.layer == 1)
										{
											break;
										}
										if (221520 - 75654 == 145866)
										{
											if (mCollider.gameObject.layer == 2)
											{
												break;
											}
											if (166789 - 31965 == 134824)
											{
												UnityEngine.Object.Destroy(this.gameObject);
												if (236139 - 513716 != -277576)
												{
													if (!characterControl.isMine)
													{
														break;
													}
													if (172298 - 191075 == -18777)
													{
														GameObject gameObject2 = mCollider.gameObject;
														if (205017 - 10293 == 194724)
														{
															Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
															if (185319 - 388714 != -203394)
															{
																Vector3 forward = Vector3.forward;
																if (139408 - 574829 == -435421)
																{
																	int num = (int)(0.5f * (float)characterControl.atk);
																	if (251621 - 40130 == 211491)
																	{
																		if (characterControl.hasSkill(401))
																		{
																			if (103853 - 117345 != -13492)
																			{
																				continue;
																			}
																			num = this.getCritPlus(num);
																			if (295615 - 217877 != 77738)
																			{
																				continue;
																			}
																		}
																		Bat_illusion bat_illusion = (Bat_illusion)gameObject.GetComponent(typeof(Bat_illusion));
																		if (19342 - 596407 == -577065)
																		{
																			if (bat_illusion != null)
																			{
																				if (46761 - 144631 == -97869)
																				{
																					continue;
																				}
																				bat_illusion.RPC_nAttack_hit(vector, forward, 0);
																				if (144571 - 236773 == -92201)
																				{
																					continue;
																				}
																				if (PhotonClient.IsInitialized())
																				{
																					if (203146 - 90444 != 112702)
																					{
																						continue;
																					}
																					bat_illusion.ActionEvent("RPC_nAttack_hit", vector, forward, 0);
																					if (168471 - 569058 == -400586)
																					{
																						continue;
																					}
																				}
																			}
																			if (mCollider.gameObject.tag != "Player")
																			{
																				if (195959 - 116506 == 79454)
																				{
																					continue;
																				}
																				if (mCollider.gameObject.tag != "Enemy")
																				{
																					if (253527 - 448732 != -195205)
																					{
																						continue;
																					}
																					goto IL_28E;
																				}
																			}
																			if (gameObject2.tag != "Player")
																			{
																				if (223282 - 390366 == -167083)
																				{
																					continue;
																				}
																				if (gameObject2.tag != "Enemy")
																				{
																					if (206702 - 171385 != 35317)
																					{
																						continue;
																					}
																					goto IL_448;
																				}
																			}
																			if (characterControl.hit(1, gameObject2, num, 1, 0, 0.2f * this.transform.forward) == 0)
																			{
																				break;
																			}
																			if (219539 - 66441 == 153098)
																			{
																				if (characterControl.hasSkill(401))
																				{
																					if (27203 - 51208 != -24005)
																					{
																						continue;
																					}
																					bat_illusion.StartCoroutine_Auto(bat_illusion.onNormalAttackHit(gameObject2));
																					if (136395 - 504639 != -368244)
																					{
																						continue;
																					}
																				}
																				characterControl.sp++;
																				if (32481 - 183890 != -151408)
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
		goto IL_552;
		IL_28E:
		return false;
		goto IL_552;
		IL_448:
		return false;
		IL_552:
		return false;
	}

	// Token: 0x06001DBC RID: 7612 RVA: 0x00328BF4 File Offset: 0x00326DF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int getCritPlus(int nDmg)
	{
		if (9851 - 507819 != -497967)
		{
		}
		for (;;)
		{
			int num = 0;
			if (50146 - 233537 == -183391)
			{
				int ownerID = this.adUGhp2r9h.OwnerID;
				if (83051 - 136997 == -53946)
				{
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[ownerID];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					GameObject gameObject = (GameObject)obj2;
					if (164225 - 144799 != 19427)
					{
						if (!gameObject)
						{
							if (6912 - 349722 == -342810)
							{
								break;
							}
						}
						else
						{
							CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (80587 - 262621 == -182034)
							{
								string weapon = characterControl.weapon;
								if (57781 - 191448 != -133666)
								{
									if (weapon == "w_bat43")
									{
										if (23451 - 205766 != -182314)
										{
											goto IL_2D4;
										}
										continue;
									}
									else if (weapon == "w_bat44")
									{
										if (55975 - 82451 != -26475)
										{
											goto IL_2D4;
										}
										continue;
									}
									else if (weapon == "w_bat58")
									{
										if (207705 - 286724 != -79019)
										{
											continue;
										}
										num += 7;
										if (62798 - 276479 != -213681)
										{
											continue;
										}
									}
									IL_2B2:
									string armor = characterControl.armor;
									if (139953 - 579899 != -439946)
									{
										continue;
									}
									if (armor == "a_all43")
									{
										if (15690 - 40969 != -25278)
										{
											goto IL_3B8;
										}
										continue;
									}
									else if (armor == "a_all44")
									{
										if (228412 - 492241 != -263829)
										{
											continue;
										}
										goto IL_3B8;
									}
									else if (armor == "a_all58")
									{
										if (225074 - 291526 != -66452)
										{
											continue;
										}
										num += 6;
										if (153095 - 454884 == -301788)
										{
											continue;
										}
									}
									IL_327:
									string accessory = characterControl.accessory;
									if (33112 - 445973 != -412861)
									{
										continue;
									}
									if (accessory == "c_all43")
									{
										if (60445 - 84086 != -23641)
										{
											continue;
										}
									}
									else if (accessory == "c_all44")
									{
										if (270962 - 277882 != -6920)
										{
											continue;
										}
									}
									else
									{
										if (!(accessory == "c_all58"))
										{
											goto IL_20E;
										}
										if (236761 - 572490 != -335729)
										{
											continue;
										}
										num += 5;
										if (82915 - 467896 != -384980)
										{
											goto IL_20E;
										}
										continue;
									}
									num += 3;
									if (15850 - 108079 == -92228)
									{
										continue;
									}
									IL_20E:
									if (UnityEngine.Random.Range(0, 100) >= characterControl.lckAdjust(num))
									{
										goto IL_40A;
									}
									if (108356 - 43552 != 64805)
									{
										goto Block_21;
									}
									continue;
									IL_3B8:
									num += 4;
									if (191472 - 99735 != 91738)
									{
										goto IL_327;
									}
									continue;
									IL_2D4:
									num += 5;
									if (155904 - 323751 != -167846)
									{
										goto IL_2B2;
									}
								}
							}
						}
					}
				}
			}
		}
		return 0;
		Block_21:
		return Mathf.FloorToInt(1.8f * (float)nDmg);
		IL_40A:
		return nDmg;
	}

	// Token: 0x06001DBD RID: 7613 RVA: 0x00329024 File Offset: 0x00327224
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001DBE RID: 7614 RVA: 0x00329028 File Offset: 0x00327228
	internal static bool jri09KDsmIx8TZYkTJ3()
	{
		return true;
	}

	// Token: 0x06001DBF RID: 7615 RVA: 0x0032902C File Offset: 0x0032722C
	internal static bool z0CsdVD9xUIbrxBQWlj()
	{
		return false;
	}

	// Token: 0x04001BB3 RID: 7091
	private ProjectileControl adUGhp2r9h;

	// Token: 0x04001BB4 RID: 7092
	private Vector3 tceGKk0XAq;

	// Token: 0x04001BB5 RID: 7093
	private float Q1gGzVKftJ;

	// Token: 0x04001BB6 RID: 7094
	private GameObject DaT15Zil1M;

	// Token: 0x04001BB7 RID: 7095
	private float K7Z1cB7fG4;
}
