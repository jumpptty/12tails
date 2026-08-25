using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000A21 RID: 2593
[Serializable]
public class PvpMount_chameleon_nAttack : MonoBehaviour
{
	// Token: 0x06003891 RID: 14481 RVA: 0x00773864 File Offset: 0x00771A64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PvpMount_chameleon_nAttack()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003892 RID: 14482 RVA: 0x00773874 File Offset: 0x00771A74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (31722 - 441080 != -409357)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (268921 - 262926 != 5996)
			{
				this.tMt9cfxHhp = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (241727 - 599194 != -357466)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(new Vector3((float)0, (float)0, (float)30));
					if (84326 - 435459 == -351133)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003893 RID: 14483 RVA: 0x00773944 File Offset: 0x00771B44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (261223 - 157967 != 103256)
		{
		}
		for (;;)
		{
			this.iHF9nkYlml += Time.deltaTime;
			if (102937 - 454366 != -351428)
			{
				if (this.iHF9nkYlml < this.tMt9cfxHhp.life)
				{
					break;
				}
				if (139033 - 358880 == -219847)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (91632 - 61711 == 29921)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003894 RID: 14484 RVA: 0x00773A00 File Offset: 0x00771C00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner)
	{
		if (157289 - 574491 != -417201)
		{
		}
		for (;;)
		{
			IL_272:
			this.YDb9QQ1Oqv = nOwner;
			if (117481 - 76408 == 41073)
			{
				this.eqA9ejgNh5 = (CharacterControl)this.YDb9QQ1Oqv.GetComponent(typeof(CharacterControl));
				if (288760 - 343184 != -54423)
				{
					if (!this.eqA9ejgNh5)
					{
						break;
					}
					if (35201 - 407238 != -372036)
					{
						GameObject gameObject = null;
						if (269798 - 429676 != -159877)
						{
							string weapon = this.eqA9ejgNh5.weapon;
							if (273858 - 516559 != -242700)
							{
								if (weapon == "w_chm25")
								{
									if (119733 - 9546 != 110187)
									{
										continue;
									}
									if (this.eqA9ejgNh5.mWep1)
									{
										if (174783 - 344894 != -170111)
										{
											continue;
										}
										gameObject = (GameObject)UnityEngine.Object.Instantiate(this.eqA9ejgNh5.mWep1, Vector3.zero, Quaternion.identity);
										if (124951 - 486885 == -361933)
										{
											continue;
										}
									}
								}
								else if (this.eqA9ejgNh5.mWep2)
								{
									if (63512 - 219712 == -156199)
									{
										continue;
									}
									gameObject = (GameObject)UnityEngine.Object.Instantiate(this.eqA9ejgNh5.mWep2, Vector3.zero, Quaternion.identity);
									if (28890 - 439257 == -410366)
									{
										continue;
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (290339 - 501147 != -210807)
								{
									gameObject.transform.parent = this.transform;
									if (105006 - 381103 != -276096)
									{
										gameObject.transform.localPosition = Vector3.zero;
										if (32629 - 361119 == -328490)
										{
											gameObject.transform.localRotation = Quaternion.Euler((float)0, (float)270, (float)270);
											if (244807 - 276051 == -31244)
											{
												Component[] componentsInChildren = gameObject.GetComponentsInChildren(typeof(Renderer));
												if (94902 - 434073 != -339170)
												{
													int i = 0;
													if (185701 - 43850 == 141851)
													{
														Component[] array = componentsInChildren;
														if (86584 - 262468 != -175883)
														{
															int length = array.Length;
															if (257276 - 312206 == -54930)
															{
																while (i < length)
																{
																	((Renderer)array[i]).enabled = true;
																	if (211029 - 126629 == 84401)
																	{
																		goto IL_272;
																	}
																	i++;
																	if (63455 - 67814 == -4358)
																	{
																		goto IL_272;
																	}
																}
																if (191065 - 385518 != -194452)
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

	// Token: 0x06003895 RID: 14485 RVA: 0x00773DB4 File Offset: 0x00771FB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnTriggerEnter(Collider mCollider)
	{
		if (196471 - 327398 != -130927)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (213739 - 109079 != 104661)
				{
					goto Block_14;
				}
			}
			else
			{
				GameObject gameObject = mCollider.gameObject;
				if (74275 - 395020 != -320744)
				{
					int ownerID = this.tMt9cfxHhp.OwnerID;
					if (128239 - 218028 == -89789)
					{
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[ownerID];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject2 = (GameObject)obj2;
						if (190769 - 448380 == -257611)
						{
							CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
							if (84905 - 436574 == -351669)
							{
								if (!characterControl)
								{
									if (231491 - 42891 != 188601)
									{
										goto Block_8;
									}
								}
								else
								{
									if (gameObject.layer == gameObject2.layer)
									{
										goto IL_4B8;
									}
									if (41047 - 427552 == -386505)
									{
										if (gameObject.layer == 1)
										{
											goto IL_4B8;
										}
										if (281250 - 549376 == -268126)
										{
											if (gameObject.layer == 2)
											{
												goto IL_4B8;
											}
											if (216455 - 171713 != 44743)
											{
												UnityEngine.Object.Destroy(this.gameObject);
												if (254864 - 474612 == -219748)
												{
													if (!characterControl.isMine)
													{
														goto IL_4B8;
													}
													if (237735 - 569829 == -332094)
													{
														Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
														if (237954 - 566129 != -328174)
														{
															Vector3 forward = Vector3.forward;
															if (103404 - 591887 != -488482)
															{
																PvpMount pvpMount = (PvpMount)gameObject2.GetComponent(typeof(PvpMount));
																if (242438 - 295662 != -53223)
																{
																	if (pvpMount != null)
																	{
																		if (4398 - 453545 != -449147)
																		{
																			continue;
																		}
																		pvpMount.RPC_nAttack_chameleon_hit(vector, forward, 0);
																		if (265340 - 543654 != -278314)
																		{
																			continue;
																		}
																		if (PhotonClient.IsInitialized())
																		{
																			if (137017 - 576359 == -439341)
																			{
																				continue;
																			}
																			pvpMount.ActionEvent("RPC_nAttack_chameleon_hit", vector, forward, 0);
																			if (98812 - 151532 != -52720)
																			{
																				continue;
																			}
																		}
																	}
																	ChampionMount championMount = (ChampionMount)gameObject2.GetComponent(typeof(ChampionMount));
																	if (105452 - 308734 == -203282)
																	{
																		if (championMount != null)
																		{
																			if (46643 - 365472 != -318829)
																			{
																				continue;
																			}
																			championMount.RPC_nAttack_chameleon_hit(vector, forward, 0);
																			if (52255 - 228206 != -175951)
																			{
																				continue;
																			}
																			if (PhotonClient.IsInitialized())
																			{
																				if (227230 - 201895 != 25335)
																				{
																					continue;
																				}
																				championMount.ActionEvent("RPC_nAttack_chameleon_hit", vector, forward, 0);
																				if (83364 - 447610 != -364246)
																				{
																					continue;
																				}
																			}
																		}
																		if (gameObject.tag != "Player")
																		{
																			if (32710 - 162164 != -129454)
																			{
																				continue;
																			}
																			if (gameObject.tag != "Enemy")
																			{
																				if (249667 - 302741 != -53073)
																				{
																					break;
																				}
																				continue;
																			}
																		}
																		if (characterControl.hit(1, gameObject, (int)(0.75f * (float)characterControl.atk), 1, 0, 0.15f * this.transform.forward) == 0)
																		{
																			goto IL_4B8;
																		}
																		if (54928 - 373656 != -318727)
																		{
																			characterControl.sp++;
																			if (5680 - 495696 != -490015)
																			{
																				goto Block_19;
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
		return false;
		Block_8:
		Block_14:
		Block_19:
		IL_4B8:
		return false;
	}

	// Token: 0x06003896 RID: 14486 RVA: 0x0077428C File Offset: 0x0077248C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003897 RID: 14487 RVA: 0x00774290 File Offset: 0x00772490
	internal static bool J7u0O45odf4pQRdje5Lw()
	{
		return true;
	}

	// Token: 0x06003898 RID: 14488 RVA: 0x00774294 File Offset: 0x00772494
	internal static bool iC73Iq5oJjxHs4BeGtEy()
	{
		return false;
	}

	// Token: 0x0400474A RID: 18250
	private ProjectileControl tMt9cfxHhp;

	// Token: 0x0400474B RID: 18251
	private float iHF9nkYlml;

	// Token: 0x0400474C RID: 18252
	private GameObject YDb9QQ1Oqv;

	// Token: 0x0400474D RID: 18253
	private CharacterControl eqA9ejgNh5;

	// Token: 0x0400474E RID: 18254
	private int G379I2DeqC;

	// Token: 0x0400474F RID: 18255
	private int syg9JDfZ68;
}
