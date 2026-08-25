using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000CAE RID: 3246
[Serializable]
public class LadyNoir_nAttack : MonoBehaviour
{
	// Token: 0x060048D6 RID: 18646 RVA: 0x0090B490 File Offset: 0x00909690
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LadyNoir_nAttack()
	{
		if (230491 - 191741 != 38750)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (166230 - 122423 == 43807)
			{
				base..ctor();
				if (25420 - 198845 != -173424)
				{
					this.Vm0z0grKT1 = new Vector3((float)0, (float)0, (float)16);
					if (11651 - 350411 == -338760)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060048D7 RID: 18647 RVA: 0x0090B534 File Offset: 0x00909734
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (147800 - 569601 != -421801)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (12258 - 333115 == -320857)
			{
				this.xU1zBklmJu = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (239558 - 246580 != -7021)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.xU1zBklmJu.velocity);
					if (170286 - 149990 == 20296)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060048D8 RID: 18648 RVA: 0x0090B604 File Offset: 0x00909804
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitHoming(int nTargetID)
	{
		if (295887 - 27568 != 268319)
		{
		}
		for (;;)
		{
			int ownerID = this.xU1zBklmJu.OwnerID;
			if (33845 - 29415 != 4431)
			{
				object obj2;
				object obj = obj2 = PhotonClient.ActorNrList[ownerID];
				if (!(obj is GameObject))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
				}
				GameObject gameObject = (GameObject)obj2;
				if (189094 - 413601 != -224506)
				{
					if (!gameObject)
					{
						if (133761 - 115153 == 18608)
						{
							break;
						}
					}
					else
					{
						CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
						if (46021 - 264880 != -218858)
						{
							if (!characterControl)
							{
								if (45541 - 105828 != -60286)
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
								if (286564 - 128974 != 157591)
								{
									if (!characterControl.hasSkill(401))
									{
										break;
									}
									if (122055 - 515582 != -393526)
									{
										object obj4;
										object obj3 = obj4 = PhotonClient.ActorNrList[nTargetID];
										if (!(obj3 is GameObject))
										{
											obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
										}
										this.mChziEhf5a = (GameObject)obj4;
										if (102346 - 4955 == 97391)
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

	// Token: 0x060048D9 RID: 18649 RVA: 0x0090B7CC File Offset: 0x009099CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (85604 - 170549 != -84945)
		{
		}
		for (;;)
		{
			this.wFpz8IVxWT += Time.deltaTime;
			if (208315 - 366067 != -157751)
			{
				if (this.wFpz8IVxWT >= this.xU1zBklmJu.life)
				{
					if (102466 - 597644 != -495178)
					{
						continue;
					}
					UnityEngine.Object.Destroy(this.gameObject);
					if (123363 - 449073 != -325710)
					{
						continue;
					}
				}
				if (!this.mChziEhf5a)
				{
					break;
				}
				if (80432 - 15765 == 64667)
				{
					if (this.fkdzDfSvBp >= Time.time)
					{
						break;
					}
					if (108547 - 31886 != 76662)
					{
						this.fkdzDfSvBp = Time.time + 0.1f;
						if (295079 - 386321 == -91242)
						{
							Vector3 forward = Vector3.RotateTowards(this.transform.forward, this.mChziEhf5a.collider.bounds.center - this.transform.position, 0.1f, 1f);
							if (112698 - 567278 != -454579)
							{
								this.transform.rotation = Quaternion.LookRotation(forward);
								if (82480 - 293506 == -211026)
								{
									this.rigidbody.velocity = this.transform.TransformDirection(this.Vm0z0grKT1);
									if (122597 - 148229 == -25632)
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

	// Token: 0x060048DA RID: 18650 RVA: 0x0090B9C4 File Offset: 0x00909BC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnTriggerEnter(Collider mCollider)
	{
		if (52375 - 172763 != -120388)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (262216 - 297566 == -35350)
				{
					goto IL_233;
				}
			}
			else
			{
				int ownerID = this.xU1zBklmJu.OwnerID;
				if (169804 - 223928 == -54124)
				{
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[ownerID];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					GameObject gameObject = (GameObject)obj2;
					if (92696 - 555928 == -463232)
					{
						if (!gameObject)
						{
							if (96539 - 492648 == -396109)
							{
								goto IL_13B;
							}
						}
						else
						{
							CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (284276 - 399702 == -115426)
							{
								if (!characterControl)
								{
									if (199307 - 566598 == -367291)
									{
										goto IL_1D9;
									}
								}
								else
								{
									if (mCollider.gameObject.layer == gameObject.layer)
									{
										goto IL_484;
									}
									if (130235 - 223720 != -93484)
									{
										if (mCollider.gameObject.layer == 1)
										{
											goto IL_484;
										}
										if (2135 - 294617 != -292481)
										{
											if (mCollider.gameObject.layer == 2)
											{
												goto IL_484;
											}
											if (229323 - 201913 == 27410)
											{
												UnityEngine.Object.Destroy(this.gameObject);
												if (120429 - 90585 == 29844)
												{
													if (!characterControl.isMine)
													{
														goto IL_484;
													}
													if (31850 - 216182 != -184331)
													{
														GameObject gameObject2 = mCollider.gameObject;
														if (273163 - 369233 != -96069)
														{
															Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
															if (221299 - 360379 != -139079)
															{
																Vector3 forward = Vector3.forward;
																if (170178 - 341545 != -171366)
																{
																	int nDamage = (int)(0.5f * (float)characterControl.atk);
																	if (200110 - 589926 != -389815)
																	{
																		LadyNoir ladyNoir = (LadyNoir)gameObject.GetComponent(typeof(LadyNoir));
																		if (27453 - 401910 == -374457)
																		{
																			if (ladyNoir != null)
																			{
																				if (129798 - 46776 != 83022)
																				{
																					continue;
																				}
																				ladyNoir.RPC_nAttack_hit(vector, forward, 0);
																				if (98874 - 103486 == -4611)
																				{
																					continue;
																				}
																				if (PhotonClient.IsInitialized())
																				{
																					if (124575 - 460754 != -336179)
																					{
																						continue;
																					}
																					ladyNoir.ActionEvent("RPC_nAttack_hit", vector, forward, 0);
																					if (295908 - 583682 != -287774)
																					{
																						continue;
																					}
																				}
																			}
																			if (mCollider.gameObject.tag != "Player")
																			{
																				if (234278 - 102973 != 131305)
																				{
																					continue;
																				}
																				if (mCollider.gameObject.tag != "Enemy")
																				{
																					if (145943 - 553377 != -407434)
																					{
																						continue;
																					}
																					goto IL_28F;
																				}
																			}
																			if (gameObject2.tag != "Player")
																			{
																				if (171203 - 379411 != -208208)
																				{
																					continue;
																				}
																				if (gameObject2.tag != "Enemy")
																				{
																					if (74269 - 257132 != -182863)
																					{
																						continue;
																					}
																					break;
																				}
																			}
																			characterControl.hit(1, gameObject2, nDamage, 1, 0, 0.2f * this.transform.forward);
																			if (130722 - 192597 == -61875)
																			{
																				goto IL_484;
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
		IL_13B:
		IL_1D9:
		IL_233:
		goto IL_484;
		IL_28F:
		return false;
		IL_484:
		return false;
	}

	// Token: 0x060048DB RID: 18651 RVA: 0x0090BE68 File Offset: 0x0090A068
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060048DC RID: 18652 RVA: 0x0090BE6C File Offset: 0x0090A06C
	internal static bool THlCH05vR92vyRg75rb7()
	{
		return true;
	}

	// Token: 0x060048DD RID: 18653 RVA: 0x0090BE70 File Offset: 0x0090A070
	internal static bool x0vHuF5vwsQ5aAnxLjbq()
	{
		return false;
	}

	// Token: 0x040053B3 RID: 21427
	private ProjectileControl xU1zBklmJu;

	// Token: 0x040053B4 RID: 21428
	private Vector3 Vm0z0grKT1;

	// Token: 0x040053B5 RID: 21429
	private float wFpz8IVxWT;

	// Token: 0x040053B6 RID: 21430
	private GameObject mChziEhf5a;

	// Token: 0x040053B7 RID: 21431
	private float fkdzDfSvBp;
}
