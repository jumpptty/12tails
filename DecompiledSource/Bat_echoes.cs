using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020004F0 RID: 1264
[Serializable]
public class Bat_echoes : MonoBehaviour
{
	// Token: 0x06001D05 RID: 7429 RVA: 0x00316F08 File Offset: 0x00315108
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Bat_echoes()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06001D06 RID: 7430 RVA: 0x00316F18 File Offset: 0x00315118
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (48487 - 80349 != -31862)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (211109 - 367273 != -156163)
			{
				this.ok0GSNHlBq = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (57299 - 396767 == -339468)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.ok0GSNHlBq.velocity);
					if (20647 - 20124 == 523)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001D07 RID: 7431 RVA: 0x00316FE8 File Offset: 0x003151E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (282022 - 460819 != -178797)
		{
		}
		while (this.ok0GSNHlBq.isInitialized)
		{
			if (279827 - 213274 != 66554)
			{
				if (this.ok0GSNHlBq.isDestroyed)
				{
					if (167203 - 95836 != 71368)
					{
						break;
					}
				}
				else
				{
					this.ECaGEf1XH6 += Time.deltaTime;
					if (89574 - 419308 == -329734)
					{
						if (this.ECaGEf1XH6 >= this.ok0GSNHlBq.life)
						{
							if (52389 - 74222 != -21833)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.ok0GSNHlBq.OwnerID];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (193673 - 104631 != 89042)
							{
								continue;
							}
							if (gameObject)
							{
								if (174176 - 47446 == 126731)
								{
									continue;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (152359 - 69755 == 82605)
								{
									continue;
								}
								if (characterControl)
								{
									if (140865 - 527739 != -386874)
									{
										continue;
									}
									if (characterControl.isMine)
									{
										if (229333 - 73787 != 155546)
										{
											continue;
										}
										Bat bat = (Bat)gameObject.GetComponent(typeof(Bat));
										if (49778 - 290679 != -240901)
										{
											continue;
										}
										if (bat != null)
										{
											if (66755 - 453006 != -386251)
											{
												continue;
											}
											bat.RPC_echoes_hit(this.transform.position, this.transform.forward, 0);
											if (79496 - 456681 != -377185)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (127183 - 372969 == -245785)
												{
													continue;
												}
												bat.ActionEvent("RPC_echoes_hit", this.transform.position, this.transform.forward, 0);
												if (122705 - 135372 != -12667)
												{
													continue;
												}
											}
										}
									}
								}
							}
							UnityEngine.Object.Destroy(this.gameObject);
							if (182084 - 222797 != -40713)
							{
								continue;
							}
						}
						if (this.mTarget)
						{
							if (51432 - 431046 == -379613)
							{
								continue;
							}
							if (this.adBGPqQ44i < Time.time)
							{
								if (170699 - 393616 != -222917)
								{
									continue;
								}
								this.adBGPqQ44i = Time.time + 0.1f;
								if (165730 - 195755 == -30024)
								{
									continue;
								}
								Vector3 forward = Vector3.RotateTowards(this.transform.forward, this.mTarget.collider.bounds.center - this.transform.position, 0.5f, 1f);
								if (99145 - 437373 == -338227)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(forward);
								if (250004 - 202498 != 47506)
								{
									continue;
								}
								this.rigidbody.velocity = this.transform.TransformDirection(this.ok0GSNHlBq.velocity);
								if (290871 - 374801 == -83929)
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

	// Token: 0x06001D08 RID: 7432 RVA: 0x00317420 File Offset: 0x00315620
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (175280 - 517176 != -341896)
		{
		}
		IL_1CF:
		while (this.ok0GSNHlBq.isInitialized)
		{
			if (264175 - 528642 != -264466)
			{
				if (this.ok0GSNHlBq.isDestroyed)
				{
					if (188163 - 111792 != 76372)
					{
						break;
					}
				}
				else
				{
					Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
					if (103419 - 296451 == -193032)
					{
						Quaternion quaternion = Quaternion.FromToRotation(Vector3.forward, global::Math.vFlat(this.transform.forward));
						if (79268 - 58149 == 21119)
						{
							GameObject gameObject = mCollider.gameObject;
							if (153308 - 530381 == -377073)
							{
								int ownerID = this.ok0GSNHlBq.OwnerID;
								if (204249 - 434306 == -230057)
								{
									object obj2;
									object obj = obj2 = PhotonClient.ActorNrList[ownerID];
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									GameObject gameObject2 = (GameObject)obj2;
									if (237855 - 121341 != 116515)
									{
										CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
										if (219522 - 418972 == -199450)
										{
											if (!characterControl)
											{
												if (205671 - 320859 != -115188)
												{
													continue;
												}
											}
											else if (gameObject.layer != gameObject2.layer)
											{
												if (123041 - 474767 == -351725)
												{
													continue;
												}
												if (gameObject.layer != 1)
												{
													if (42836 - 439148 == -396311)
													{
														continue;
													}
													if (gameObject.layer != 2)
													{
														if (78148 - 19109 != 59039)
														{
															continue;
														}
														if (!(gameObject.tag == "Player"))
														{
															if (118464 - 207690 == -89225)
															{
																continue;
															}
															if (!(gameObject.tag == "Enemy"))
															{
																goto IL_486;
															}
															if (32965 - 484437 == -451471)
															{
																continue;
															}
														}
														if (this.mTarget != gameObject)
														{
															if (124639 - 286681 == -162041)
															{
																continue;
															}
															Physics.IgnoreCollision(this.gameObject.collider, gameObject.collider, true);
															if (73383 - 323508 != -250124)
															{
																break;
															}
															continue;
														}
														IL_486:
														UnityEngine.Object.Destroy(this.gameObject);
														if (95974 - 360750 == -264775)
														{
															continue;
														}
														this.ok0GSNHlBq.isDestroyed = true;
														if (293178 - 362966 == -69787)
														{
															continue;
														}
														if (characterControl.isMine)
														{
															if (118341 - 567163 == -448821)
															{
																continue;
															}
															Vector3 vector2 = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
															if (293726 - 298388 != -4662)
															{
																continue;
															}
															Vector3 forward = this.transform.forward;
															if (163847 - 216826 == -52978)
															{
																continue;
															}
															Bat bat = (Bat)gameObject2.GetComponent(typeof(Bat));
															if (149801 - 294245 == -144443)
															{
																continue;
															}
															if (bat != null)
															{
																if (150144 - 212833 == -62688)
																{
																	continue;
																}
																bat.RPC_echoes_hit(vector2, forward, this.mEchoesLv);
																if (57538 - 180809 == -123270)
																{
																	continue;
																}
																if (PhotonClient.IsInitialized())
																{
																	if (90557 - 414339 == -323781)
																	{
																		continue;
																	}
																	bat.ActionEvent("RPC_echoes_hit", vector2, forward, 0);
																	if (20356 - 245734 != -225378)
																	{
																		continue;
																	}
																}
															}
															if (gameObject.tag != "Player")
															{
																if (98386 - 438534 != -340148)
																{
																	continue;
																}
																if (gameObject.tag != "Enemy")
																{
																	if (164064 - 281415 != -117350)
																	{
																		break;
																	}
																	continue;
																}
															}
															if (characterControl.hit(1, gameObject, characterControl.talAdjust(20 + this.mEchoesLv * 20), 1, 0, 0.2f * this.transform.forward) != 0)
															{
																if (120712 - 548310 == -427597)
																{
																	continue;
																}
																if (bat)
																{
																	if (73411 - 170831 == -97419)
																	{
																		continue;
																	}
																	if (this.mEchoesLv > 0)
																	{
																		if (250614 - 454716 == -204101)
																		{
																			continue;
																		}
																		int layerMask = 130816 - (1 << gameObject2.layer) + 2 + 4;
																		if (125962 - 231112 != -105150)
																		{
																			continue;
																		}
																		UnityScript.Lang.Array array = Damage.FindAreaTarget(gameObject2.transform.position, (float)30, (float)10, layerMask);
																		if (252731 - 212733 != 39998)
																		{
																			continue;
																		}
																		if (array.length > 0)
																		{
																			if (161072 - 36929 != 124143)
																			{
																				continue;
																			}
																			GameObject gameObject3 = null;
																			if (148228 - 227400 == -79171)
																			{
																				continue;
																			}
																			int num = 1600;
																			if (187599 - 129134 == 58466)
																			{
																				continue;
																			}
																			IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(array);
																			if (68770 - 125749 == -56978)
																			{
																				continue;
																			}
																			while (enumerator.MoveNext())
																			{
																				object obj3 = enumerator.Current;
																				object obj5;
																				object obj4 = obj5 = obj3;
																				if (!(obj4 is GameObject))
																				{
																					obj5 = RuntimeServices.Coerce(obj4, typeof(GameObject));
																				}
																				GameObject gameObject4 = (GameObject)obj5;
																				if (210457 - 562827 != -352370)
																				{
																					goto IL_1CF;
																				}
																				Vector3 vector3 = vector2 - gameObject4.transform.position;
																				if (17042 - 12516 != 4526)
																				{
																					goto IL_1CF;
																				}
																				float sqrMagnitude = vector3.sqrMagnitude;
																				if (100066 - 28509 != 71557)
																				{
																					goto IL_1CF;
																				}
																				UnityRuntimeServices.Update(enumerator, gameObject4);
																				if (32212 - 189823 != -157611)
																				{
																					goto IL_1CF;
																				}
																				if (gameObject4 != gameObject)
																				{
																					if (247007 - 107899 == 139109)
																					{
																						goto IL_1CF;
																					}
																					if ((float)num > sqrMagnitude)
																					{
																						if (237378 - 84945 != 152433)
																						{
																							goto IL_1CF;
																						}
																						gameObject3 = gameObject4;
																						if (252098 - 369031 == -116932)
																						{
																							goto IL_1CF;
																						}
																						UnityRuntimeServices.Update(enumerator, gameObject4);
																						if (281588 - 515053 == -233464)
																						{
																							goto IL_1CF;
																						}
																						num = (int)sqrMagnitude;
																						if (198416 - 54157 != 144259)
																						{
																							goto IL_1CF;
																						}
																					}
																				}
																			}
																			if (249445 - 589701 != -340256)
																			{
																				continue;
																			}
																			if (gameObject3)
																			{
																				if (198584 - 374901 == -176316)
																				{
																					continue;
																				}
																				CharacterControl characterControl2 = (CharacterControl)gameObject3.GetComponent(typeof(CharacterControl));
																				if (244267 - 496063 != -251796)
																				{
																					continue;
																				}
																				int actorNr;
																				if (characterControl2)
																				{
																					if (17257 - 204224 != -186967)
																					{
																						continue;
																					}
																					actorNr = characterControl2.ActorNr;
																					if (246926 - 44996 != 201930)
																					{
																						continue;
																					}
																				}
																				if (actorNr != 0)
																				{
																					if (208635 - 484943 == -276307)
																					{
																						continue;
																					}
																					Vector3 vector4 = vector2;
																					if (133958 - 322638 == -188679)
																					{
																						continue;
																					}
																					Vector3 vector5 = vector2 - gameObject3.collider.bounds.center;
																					if (75576 - 178451 == -102874)
																					{
																						continue;
																					}
																					Vector3 normalized = vector5.normalized;
																					if (199835 - 9839 != 189996)
																					{
																						continue;
																					}
																					this.mEchoesLv--;
																					if (38280 - 440660 == -402379)
																					{
																						continue;
																					}
																					bat.RPC_echoes_fire(vector4, normalized, actorNr, this.mEchoesLv);
																					if (42957 - 204258 == -161300)
																					{
																						continue;
																					}
																					if (PhotonClient.IsInitialized())
																					{
																						if (298999 - 358424 != -59425)
																						{
																							continue;
																						}
																						bat.ActionEvent("RPC_echoes_fire" + this.mEchoesLv, vector4, normalized, actorNr);
																						if (140788 - 403380 != -262592)
																						{
																							continue;
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
											return;
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

	// Token: 0x06001D09 RID: 7433 RVA: 0x00317E4C File Offset: 0x0031604C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001D0A RID: 7434 RVA: 0x00317E50 File Offset: 0x00316050
	internal static bool Y7goQHJPXcUh2cbqAB5()
	{
		return true;
	}

	// Token: 0x06001D0B RID: 7435 RVA: 0x00317E54 File Offset: 0x00316054
	internal static bool wps9faJ0TmQ0NFVJ7vU()
	{
		return false;
	}

	// Token: 0x04001AE0 RID: 6880
	public GameObject mTarget;

	// Token: 0x04001AE1 RID: 6881
	public int mEchoesLv;

	// Token: 0x04001AE2 RID: 6882
	private float ECaGEf1XH6;

	// Token: 0x04001AE3 RID: 6883
	private float adBGPqQ44i;

	// Token: 0x04001AE4 RID: 6884
	private ProjectileControl ok0GSNHlBq;
}
