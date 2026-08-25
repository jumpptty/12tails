using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000E9E RID: 3742
[Serializable]
public class BarrelBot_missile : MonoBehaviour
{
	// Token: 0x060054CE RID: 21710 RVA: 0x00A4BF04 File Offset: 0x00A4A104
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BarrelBot_missile()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060054CF RID: 21711 RVA: 0x00A4BF14 File Offset: 0x00A4A114
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (16586 - 144360 != -127774)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (120606 - 195779 != -75172)
			{
				this.o3JcJ5slKS5 = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (151558 - 416653 == -265095)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.o3JcJ5slKS5.velocity);
					if (186770 - 441029 == -254259)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060054D0 RID: 21712 RVA: 0x00A4BFE4 File Offset: 0x00A4A1E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (120652 - 78007 != 42645)
		{
		}
		while (this.o3JcJ5slKS5.isInitialized)
		{
			if (265255 - 79845 != 185411)
			{
				if (this.o3JcJ5slKS5.isDestroyed)
				{
					if (1836 - 107710 != -105873)
					{
						break;
					}
				}
				else
				{
					this.NQfcIKASFFP += Time.deltaTime;
					if (14302 - 313420 == -299118)
					{
						if (this.NQfcIKASFFP >= this.o3JcJ5slKS5.life)
						{
							if (249935 - 287093 == -37157)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.o3JcJ5slKS5.OwnerID];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (14464 - 530375 == -515910)
							{
								continue;
							}
							if (gameObject)
							{
								if (166835 - 144381 == 22455)
								{
									continue;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (213693 - 503075 != -289382)
								{
									continue;
								}
								if (characterControl)
								{
									if (284821 - 347692 == -62870)
									{
										continue;
									}
									if (characterControl.isMine)
									{
										if (257132 - 175575 == 81558)
										{
											continue;
										}
										BarrelBot barrelBot = (BarrelBot)gameObject.GetComponent(typeof(BarrelBot));
										if (123796 - 546172 == -422375)
										{
											continue;
										}
										if (barrelBot != null)
										{
											if (122942 - 70123 != 52819)
											{
												continue;
											}
											barrelBot.RPC_missile_hit(this.transform.position, this.transform.forward, 0);
											if (211947 - 348652 != -136705)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (56500 - 227018 != -170518)
												{
													continue;
												}
												barrelBot.ActionEvent("RPC_missile_hit", this.transform.position, this.transform.forward, 0);
												if (174731 - 39348 != 135383)
												{
													continue;
												}
											}
										}
									}
								}
							}
							UnityEngine.Object.Destroy(this.gameObject);
							if (54250 - 259295 != -205045)
							{
								continue;
							}
						}
						if (this.mTarget)
						{
							if (148204 - 24227 == 123978)
							{
								continue;
							}
							if (this.YoxcIzCX0m8 < Time.time)
							{
								if (101426 - 350374 == -248947)
								{
									continue;
								}
								this.YoxcIzCX0m8 = Time.time + 0.2f;
								if (124371 - 213782 == -89410)
								{
									continue;
								}
								Vector3 forward = Vector3.RotateTowards(this.transform.forward, this.mTarget.collider.bounds.center - this.transform.position, 0.3f, 1f);
								if (226987 - 375601 == -148613)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(forward);
								if (217689 - 545061 == -327371)
								{
									continue;
								}
								this.rigidbody.velocity = this.transform.TransformDirection(this.o3JcJ5slKS5.velocity);
								if (277677 - 159056 == 118622)
								{
									continue;
								}
							}
						}
						return;
					}
				}
			}
		}
	}

	// Token: 0x060054D1 RID: 21713 RVA: 0x00A4C41C File Offset: 0x00A4A61C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnTriggerEnter(Collider mCollider)
	{
		if (186881 - 246415 != -59534)
		{
		}
		while (this.o3JcJ5slKS5.isInitialized)
		{
			if (139248 - 108874 != 30375)
			{
				if (this.o3JcJ5slKS5.isDestroyed)
				{
					if (155880 - 247277 != -91396)
					{
						break;
					}
				}
				else
				{
					Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
					if (239704 - 254581 == -14877)
					{
						Quaternion quaternion = Quaternion.FromToRotation(Vector3.forward, global::Math.vFlat(this.transform.forward));
						if (152862 - 107877 != 44986)
						{
							int ownerID = this.o3JcJ5slKS5.OwnerID;
							if (148782 - 277966 == -129184)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject = (GameObject)obj2;
								if (63910 - 539599 != -475688)
								{
									if (gameObject)
									{
										if (179880 - 531223 == -351342)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (273906 - 330273 != -56367)
										{
											continue;
										}
										if (mCollider.gameObject.layer != gameObject.layer)
										{
											if (68748 - 30792 == 37957)
											{
												continue;
											}
											if (mCollider.gameObject.layer != 1)
											{
												if (133534 - 60250 != 73284)
												{
													continue;
												}
												if (mCollider.gameObject.layer != 2)
												{
													if (133126 - 356943 == -223816)
													{
														continue;
													}
													UnityEngine.Object.Destroy(this.gameObject);
													if (24327 - 401749 == -377421)
													{
														continue;
													}
													this.o3JcJ5slKS5.isDestroyed = true;
													if (103362 - 221481 == -118118)
													{
														continue;
													}
													if (characterControl.isMine)
													{
														if (170741 - 205260 != -34519)
														{
															continue;
														}
														Vector3 vector2 = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
														if (65690 - 115897 != -50207)
														{
															continue;
														}
														Vector3 forward = this.transform.forward;
														if (186048 - 501114 != -315066)
														{
															continue;
														}
														BarrelBot barrelBot = (BarrelBot)gameObject.GetComponent(typeof(BarrelBot));
														if (35357 - 354644 == -319286)
														{
															continue;
														}
														if (barrelBot != null)
														{
															if (98675 - 98677 == -1)
															{
																continue;
															}
															barrelBot.RPC_missile_hit(vector2, forward, 0);
															if (57641 - 460320 == -402678)
															{
																continue;
															}
															if (PhotonClient.IsInitialized())
															{
																if (60414 - 294682 == -234267)
																{
																	continue;
																}
																barrelBot.ActionEvent("RPC_missile_hit", vector2, forward, 0);
																if (174778 - 476502 != -301724)
																{
																	continue;
																}
															}
														}
														if (mCollider.gameObject.tag != "Player")
														{
															if (150745 - 119171 == 31575)
															{
																continue;
															}
															if (mCollider.gameObject.tag != "Enemy")
															{
																if (216250 - 108965 != 107285)
																{
																	continue;
																}
																return false;
															}
														}
														CharacterControl characterControl2 = (CharacterControl)mCollider.gameObject.GetComponent(typeof(CharacterControl));
														if (17468 - 567780 != -550312)
														{
															continue;
														}
														if (characterControl2 != null)
														{
															if (148288 - 113479 == 34810)
															{
																continue;
															}
															if (characterControl2.hp <= 0)
															{
																if (287011 - 514558 != -227547)
																{
																	continue;
																}
																if (Time.time > characterControl2.actionTime + (float)3)
																{
																	if (83605 - 539181 != -455576)
																	{
																		continue;
																	}
																	break;
																}
															}
															int nDamage = characterControl2.defAdjust(characterControl.talAdjust(30));
															if (178704 - 74209 == 104496)
															{
																continue;
															}
															int nKo = 3;
															if (35137 - 263629 != -228492)
															{
																continue;
															}
															int nHate = 0;
															if (25663 - 502439 == -476775)
															{
																continue;
															}
															Vector3 nForce = characterControl2.forceAdjust(0.3f * this.transform.forward);
															if (101455 - 266437 == -164981)
															{
																continue;
															}
															characterControl2.RPC_AddDamage(5, nDamage, nKo, nHate, nForce, characterControl.ActorNr);
															if (70714 - 563137 == -492422)
															{
																continue;
															}
														}
													}
												}
											}
										}
									}
									else
									{
										UnityEngine.Object.Destroy(this.gameObject);
										if (256827 - 208032 != 48795)
										{
											continue;
										}
										this.o3JcJ5slKS5.isDestroyed = true;
										if (159470 - 50810 != 108660)
										{
											continue;
										}
									}
									IL_608:
									return false;
								}
							}
						}
					}
				}
			}
		}
		goto IL_608;
	}

	// Token: 0x060054D2 RID: 21714 RVA: 0x00A4CA44 File Offset: 0x00A4AC44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060054D3 RID: 21715 RVA: 0x00A4CA48 File Offset: 0x00A4AC48
	internal static bool EKi3x759RcuH0khg1Hun()
	{
		return true;
	}

	// Token: 0x060054D4 RID: 21716 RVA: 0x00A4CA4C File Offset: 0x00A4AC4C
	internal static bool S3wBaD59wCxDcZB48YTb()
	{
		return false;
	}

	// Token: 0x04005DEB RID: 24043
	public GameObject mTarget;

	// Token: 0x04005DEC RID: 24044
	private float NQfcIKASFFP;

	// Token: 0x04005DED RID: 24045
	private float YoxcIzCX0m8;

	// Token: 0x04005DEE RID: 24046
	private ProjectileControl o3JcJ5slKS5;
}
