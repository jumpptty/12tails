using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000650 RID: 1616
[Serializable]
public class Mole_missile : MonoBehaviour
{
	// Token: 0x06002462 RID: 9314 RVA: 0x00448824 File Offset: 0x00446A24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mole_missile()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06002463 RID: 9315 RVA: 0x00448834 File Offset: 0x00446A34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (158222 - 498926 != -340704)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (162636 - 106558 == 56078)
			{
				this.QNZbK12ShD = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (201436 - 238640 == -37204)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.QNZbK12ShD.velocity);
					if (221158 - 117871 == 103287)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002464 RID: 9316 RVA: 0x00448904 File Offset: 0x00446B04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (160409 - 493355 != -332946)
		{
		}
		while (this.QNZbK12ShD.isInitialized)
		{
			if (1995 - 318037 != -316041)
			{
				if (this.QNZbK12ShD.isDestroyed)
				{
					if (8853 - 358536 == -349683)
					{
						break;
					}
				}
				else
				{
					this.volbVYwgGo += Time.deltaTime;
					if (181596 - 569400 == -387804)
					{
						if (this.volbVYwgGo >= this.QNZbK12ShD.life)
						{
							if (199141 - 302050 != -102909)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.QNZbK12ShD.OwnerID];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (299722 - 111833 != 187889)
							{
								continue;
							}
							if (gameObject)
							{
								if (164934 - 246278 != -81344)
								{
									continue;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (218981 - 456277 != -237296)
								{
									continue;
								}
								if (characterControl)
								{
									if (205381 - 596945 == -391563)
									{
										continue;
									}
									if (characterControl.isMine)
									{
										if (177694 - 93863 == 83832)
										{
											continue;
										}
										Mole mole = (Mole)gameObject.GetComponent(typeof(Mole));
										if (50555 - 403156 == -352600)
										{
											continue;
										}
										if (mole != null)
										{
											if (16377 - 134084 != -117707)
											{
												continue;
											}
											mole.RPC_missile_hit(this.transform.position, this.transform.forward, 0);
											if (112218 - 369539 != -257321)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (267398 - 395587 == -128188)
												{
													continue;
												}
												mole.ActionEvent("RPC_missile_hit", this.transform.position, this.transform.forward, 0);
												if (71206 - 394313 == -323106)
												{
													continue;
												}
											}
										}
									}
								}
							}
							UnityEngine.Object.Destroy(this.gameObject);
							if (162541 - 409081 == -246539)
							{
								continue;
							}
						}
						if (this.mTarget)
						{
							if (192777 - 421121 != -228344)
							{
								continue;
							}
							if (this.M5wbhuaJDo < Time.time)
							{
								if (216947 - 65070 == 151878)
								{
									continue;
								}
								this.M5wbhuaJDo = Time.time + 0.2f;
								if (154869 - 140156 != 14713)
								{
									continue;
								}
								Vector3 forward = Vector3.RotateTowards(this.transform.forward, this.mTarget.collider.bounds.center - this.transform.position, 0.3f, 1f);
								if (162963 - 121051 == 41913)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(forward);
								if (64295 - 456781 == -392485)
								{
									continue;
								}
								this.rigidbody.velocity = this.transform.TransformDirection(this.QNZbK12ShD.velocity);
								if (125347 - 416275 != -290928)
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

	// Token: 0x06002465 RID: 9317 RVA: 0x00448D3C File Offset: 0x00446F3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnTriggerEnter(Collider mCollider)
	{
		if (151716 - 104429 != 47288)
		{
		}
		while (this.QNZbK12ShD.isInitialized)
		{
			if (106046 - 232746 != -126699)
			{
				if (this.QNZbK12ShD.isDestroyed)
				{
					if (226347 - 250823 != -24475)
					{
						break;
					}
				}
				else
				{
					Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
					if (164144 - 297404 != -133259)
					{
						Quaternion quaternion = Quaternion.FromToRotation(Vector3.forward, global::Math.vFlat(this.transform.forward));
						if (103561 - 213745 != -110183)
						{
							int ownerID = this.QNZbK12ShD.OwnerID;
							if (280350 - 180116 != 100235)
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[ownerID];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								GameObject gameObject = (GameObject)obj2;
								if (197691 - 368944 == -171253)
								{
									if (gameObject)
									{
										if (255352 - 533582 == -278229)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (222575 - 189941 == 32635)
										{
											continue;
										}
										if (mCollider.gameObject.layer != gameObject.layer)
										{
											if (92336 - 302016 != -209680)
											{
												continue;
											}
											if (mCollider.gameObject.layer != 1)
											{
												if (152230 - 353671 != -201441)
												{
													continue;
												}
												if (mCollider.gameObject.layer != 2)
												{
													if (210116 - 26392 != 183724)
													{
														continue;
													}
													UnityEngine.Object.Destroy(this.gameObject);
													if (259699 - 24714 != 234985)
													{
														continue;
													}
													this.QNZbK12ShD.isDestroyed = true;
													if (13203 - 126640 == -113436)
													{
														continue;
													}
													if (characterControl.isMine)
													{
														if (26550 - 146823 == -120272)
														{
															continue;
														}
														Vector3 vector2 = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
														if (67464 - 259521 == -192056)
														{
															continue;
														}
														Vector3 forward = this.transform.forward;
														if (181168 - 103202 == 77967)
														{
															continue;
														}
														Mole mole = (Mole)gameObject.GetComponent(typeof(Mole));
														if (213804 - 550786 != -336982)
														{
															continue;
														}
														if (mole != null)
														{
															if (228290 - 542243 != -313953)
															{
																continue;
															}
															mole.RPC_missile_hit(vector2, forward, 0);
															if (154651 - 128318 == 26334)
															{
																continue;
															}
															if (PhotonClient.IsInitialized())
															{
																if (89213 - 37372 == 51842)
																{
																	continue;
																}
																mole.ActionEvent("RPC_missile_hit", vector2, forward, 0);
																if (200965 - 529581 != -328616)
																{
																	continue;
																}
															}
														}
														if (mCollider.gameObject.tag != "Player")
														{
															if (200424 - 555730 == -355305)
															{
																continue;
															}
															if (mCollider.gameObject.tag != "Enemy")
															{
																if (57969 - 375611 != -317642)
																{
																	continue;
																}
																return false;
															}
														}
														CharacterControl characterControl2 = (CharacterControl)mCollider.gameObject.GetComponent(typeof(CharacterControl));
														if (186692 - 42334 != 144358)
														{
															continue;
														}
														if (characterControl2 != null)
														{
															if (250666 - 116504 != 134162)
															{
																continue;
															}
															if (characterControl2.hp <= 0)
															{
																if (263469 - 7767 != 255702)
																{
																	continue;
																}
																if (Time.time > characterControl2.actionTime + (float)3)
																{
																	if (74887 - 151478 != -76591)
																	{
																		continue;
																	}
																	break;
																}
															}
															int nDamage = characterControl2.defAdjust(characterControl.talAdjust(30));
															if (74739 - 137690 != -62951)
															{
																continue;
															}
															int nKo = 3;
															if (42960 - 80939 == -37978)
															{
																continue;
															}
															int nHate = 0;
															if (85505 - 102562 != -17057)
															{
																continue;
															}
															Vector3 nForce = characterControl2.forceAdjust(0.3f * this.transform.forward);
															if (58407 - 485783 == -427375)
															{
																continue;
															}
															characterControl2.RPC_AddDamage(1, nDamage, nKo, nHate, nForce, characterControl.ActorNr);
															if (250504 - 220948 != 29556)
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
										if (115661 - 398563 != -282902)
										{
											continue;
										}
										this.QNZbK12ShD.isDestroyed = true;
										if (181994 - 253753 != -71759)
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

	// Token: 0x06002466 RID: 9318 RVA: 0x00449364 File Offset: 0x00447564
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002467 RID: 9319 RVA: 0x00449368 File Offset: 0x00447568
	internal static bool x0ZXiBBcZOGuWd7pqZS()
	{
		return true;
	}

	// Token: 0x06002468 RID: 9320 RVA: 0x0044936C File Offset: 0x0044756C
	internal static bool aoy2dNBUiJMD4U8GeUj()
	{
		return false;
	}

	// Token: 0x04002768 RID: 10088
	private float volbVYwgGo;

	// Token: 0x04002769 RID: 10089
	private float M5wbhuaJDo;

	// Token: 0x0400276A RID: 10090
	private ProjectileControl QNZbK12ShD;

	// Token: 0x0400276B RID: 10091
	public GameObject mTarget;
}
