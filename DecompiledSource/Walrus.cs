using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000DC9 RID: 3529
[Serializable]
public class Walrus : MonoBehaviour
{
	// Token: 0x06004FB2 RID: 20402 RVA: 0x009C820C File Offset: 0x009C640C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Walrus()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004FB3 RID: 20403 RVA: 0x009C821C File Offset: 0x009C641C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (299326 - 548416 != -249090)
		{
		}
		for (;;)
		{
			this.MTZcQQBYv9O = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (189692 - 133860 == 55832)
			{
				this.MTZcQQBYv9O.actionState = "standby";
				if (259344 - 326108 != -66763)
				{
					this.MTZcQQBYv9O.actionTime = Time.time;
					if (177278 - 148475 != 28804)
					{
						this.MTZcQQBYv9O.myCommand = "none";
						if (291519 - 202728 == 88791)
						{
							if (Game.mGameType == 99)
							{
								if (200202 - 171623 != 28579)
								{
									continue;
								}
								this.MTZcQQBYv9O.isMine = true;
								if (292586 - 535997 != -243411)
								{
									continue;
								}
							}
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								break;
							}
							if (10998 - 344624 != -333625)
							{
								if (!this.MTZcQQBYv9O.isSummon)
								{
									break;
								}
								if (59074 - 111410 == -52336)
								{
									if (this.awake_vc)
									{
										if (143286 - 3085 == 140201)
										{
											this.audio.PlayOneShot(this.awake_vc);
											if (109459 - 31754 != 77706)
											{
												break;
											}
										}
									}
									else
									{
										Debug.LogError("Missing awake_vc audio");
										if (139192 - 49124 == 90068)
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

	// Token: 0x06004FB4 RID: 20404 RVA: 0x009C8428 File Offset: 0x009C6628
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (254804 - 196506 != 58298)
		{
		}
		for (;;)
		{
			if (this.MTZcQQBYv9O.isControlled)
			{
				if (254711 - 279759 == -25047)
				{
					continue;
				}
				if (!(this.MTZcQQBYv9O.actionState == "standby"))
				{
					if (9542 - 6271 != 3271)
					{
						continue;
					}
					if (!(this.MTZcQQBYv9O.actionState == "run"))
					{
						goto IL_17C;
					}
					if (273037 - 463517 != -190480)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (82544 - 154531 != -71987)
				{
					continue;
				}
			}
			IL_17C:
			if (this.MTZcQQBYv9O.hp <= 0)
			{
				if (259188 - 62482 != 196706)
				{
					continue;
				}
				if (this.MTZcQQBYv9O.actionState != "dead")
				{
					if (128479 - 499479 == -370999)
					{
						continue;
					}
					if (this.MTZcQQBYv9O.isMine)
					{
						if (283431 - 320532 != -37101)
						{
							continue;
						}
						statusClass status = this.MTZcQQBYv9O.getStatus("autoLife");
						if (171498 - 316975 != -145477)
						{
							continue;
						}
						if (status != null)
						{
							if (91545 - 71874 == 19672)
							{
								continue;
							}
							this.MTZcQQBYv9O.hp = 1;
							if (74438 - 304919 == -230480)
							{
								continue;
							}
							this.MTZcQQBYv9O.RPC_RemoveStatus("autoLife");
							if (146528 - 247386 != -100858)
							{
								continue;
							}
							this.MTZcQQBYv9O.RPC_createEffect("autoLife");
							if (85502 - 282050 == -196547)
							{
								continue;
							}
							this.MTZcQQBYv9O.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (103044 - 405081 != -302036)
							{
								break;
							}
							continue;
						}
						else
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (85140 - 251663 == -166522)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (24624 - 240609 == -215984)
							{
								continue;
							}
							this.MTZcQQBYv9O.DeadEvent();
							if (271435 - 550885 != -279449)
							{
								break;
							}
							continue;
						}
					}
					else
					{
						this.MTZcQQBYv9O.hp = 1;
						if (26085 - 34413 != -8328)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.MTZcQQBYv9O.hp <= 0)
			{
				break;
			}
			if (193823 - 378211 == -184388)
			{
				if (this.MTZcQQBYv9O.ko > 0)
				{
					break;
				}
				if (132238 - 597650 == -465412)
				{
					if (!(this.MTZcQQBYv9O.actionState != "ko"))
					{
						break;
					}
					if (39538 - 341635 == -302097)
					{
						if (!(this.MTZcQQBYv9O.actionState != "dead"))
						{
							break;
						}
						if (156182 - 185193 == -29011)
						{
							if (this.MTZcQQBYv9O.isMine)
							{
								if (288036 - 161131 == 126905)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (45516 - 315373 != -269856)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (125612 - 573335 != -447722)
										{
											this.MTZcQQBYv9O.KoEvent();
											if (129445 - 317447 != -188001)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.MTZcQQBYv9O.ko = 1;
								if (19274 - 492064 == -472790)
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

	// Token: 0x06004FB5 RID: 20405 RVA: 0x009C8928 File Offset: 0x009C6B28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (88335 - 462561 != -374226)
		{
		}
		for (;;)
		{
			float num = this.MTZcQQBYv9O.moveSpeed;
			if (230578 - 314894 == -84316)
			{
				float num2 = this.MTZcQQBYv9O.runSpeed;
				if (195604 - 280704 == -85100)
				{
					Vector3 a = default(Vector3);
					if (173673 - 228320 != -54646)
					{
						Vector3 vector = Vector3.zero;
						if (174910 - 364562 != -189651)
						{
							float num3 = (float)0;
							if (101993 - 483972 == -381979)
							{
								if (Game.mGameType == 2)
								{
									goto IL_ACC;
								}
								if (59982 - 80604 == -20621)
								{
									continue;
								}
								if (Game.mGameType == 3)
								{
									if (169372 - 507768 != -338395)
									{
										goto IL_ACC;
									}
									continue;
								}
								IL_2FE:
								if (this.MTZcQQBYv9O.isMine)
								{
									if (15912 - 122861 == -106948)
									{
										continue;
									}
									if ((this.MTZcQQBYv9O.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (166888 - 83034 == 83855)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (212894 - 263672 == -50777)
										{
											continue;
										}
										a.y = (float)0;
										if (124244 - 313400 == -189155)
										{
											continue;
										}
										a = a.normalized;
										if (38479 - 242394 != -203915)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (30391 - 323162 == -292770)
										{
											continue;
										}
										vector = vector.normalized;
										if (233144 - 393490 != -160346)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (122191 - 129738 == -7546)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (148613 - 145464 != 3149)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (127811 - 361155 != -233344)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (62629 - 520457 == -457827)
														{
															continue;
														}
														this.MTZcQQBYv9O.actionState = "run";
														if (199641 - 45164 != 154477)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(num2, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (184788 - 497999 != -313211)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (66676 - 508608 != -441932)
														{
															continue;
														}
														this.animation.Play("run");
														if (222966 - 399783 != -176817)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (194713 - 13121 != 181593)
														{
															goto IL_182;
														}
														continue;
													}
												}
											}
										}
										this.MTZcQQBYv9O.actionState = "standby";
										if (194621 - 148912 == 45710)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (102492 - 257752 != -155260)
										{
											continue;
										}
										if (num < 0.1f * num2)
										{
											if (176653 - 258264 == -81610)
											{
												continue;
											}
											num = (float)0;
											if (69598 - 220887 != -151289)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (76890 - 211351 != -134461)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (52635 - 328069 != -275434)
										{
											continue;
										}
									}
									IL_182:;
								}
								else
								{
									vector = global::Math.vFlat(this.MTZcQQBYv9O.nPosition - this.transform.position);
									if (226599 - 448468 != -221869)
									{
										continue;
									}
									num3 = vector.sqrMagnitude;
									if (258253 - 576786 != -318533)
									{
										continue;
									}
									if (this.MTZcQQBYv9O.nSpeed != (float)0)
									{
										if (215025 - 248149 != -33124)
										{
											continue;
										}
										if (num3 > num2)
										{
											if (22289 - 180939 == -158649)
											{
												continue;
											}
											this.transform.position = this.MTZcQQBYv9O.nPosition;
											if (8094 - 141100 == -133005)
											{
												continue;
											}
										}
										else if (num3 > 0.01f)
										{
											if (236080 - 331177 != -95097)
											{
												continue;
											}
											if (num3 > (float)1)
											{
												if (54451 - 155749 == -101297)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * num2, (float)10 * Time.deltaTime);
												if (235946 - 223024 != 12922)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.MTZcQQBYv9O.nSpeed, (float)10 * Time.deltaTime);
												if (155373 - 580202 != -424829)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (34337 - 130936 != -96599)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (276465 - 370762 != -94297)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (226542 - 291097 == -64554)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (178417 - 521845 == -343427)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (238315 - 407215 == -168899)
											{
												continue;
											}
										}
										else if (Time.time > this.MTZcQQBYv9O.nSpeed + 0.3f)
										{
											if (189084 - 334950 == -145865)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (157955 - 578739 != -420784)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (66820 - 565265 == -498444)
												{
													continue;
												}
												num = (float)0;
												if (102699 - 160766 == -58066)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.MTZcQQBYv9O.nDirection);
											if (143908 - 122564 != 21344)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (265051 - 563525 != -298474)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (119042 - 554779 != -435737)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (201536 - 240007 == -38470)
										{
											continue;
										}
										if (num3 > num2)
										{
											if (83317 - 149590 == -66272)
											{
												continue;
											}
											this.transform.position = this.MTZcQQBYv9O.nPosition;
											if (289793 - 279013 == 10781)
											{
												continue;
											}
										}
										else if (num3 > 0.01f)
										{
											if (174812 - 115008 != 59804)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (108510 - 402832 == -294321)
											{
												continue;
											}
											if (num3 > 0.1f)
											{
												if (50433 - 420615 == -370181)
												{
													continue;
												}
												num = Mathf.Lerp(num, num2, (float)10 * Time.deltaTime);
												if (108663 - 145045 == -36381)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (83702 - 498223 == -414520)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (201991 - 304930 != -102939)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (210298 - 568575 != -358277)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.MTZcQQBYv9O.nDirection);
											if (202077 - 444785 != -242708)
											{
												continue;
											}
											num = (float)0;
											if (47587 - 17052 != 30535)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (263804 - 50810 != 212994)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (187046 - 357167 == -170120)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (20138 - 241117 != -220979)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (96146 - 132079 != -35933)
										{
											continue;
										}
									}
								}
								this.MTZcQQBYv9O.vMovement = vector;
								if (96143 - 217667 == -121523)
								{
									continue;
								}
								this.MTZcQQBYv9O.moveSpeed = num;
								if (71682 - 133851 != -62169)
								{
									continue;
								}
								break;
								IL_ACC:
								num2 = Mathf.Clamp(num2, 4f, 8f);
								if (67530 - 355644 == -288114)
								{
									goto IL_2FE;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004FB6 RID: 20406 RVA: 0x009C9504 File Offset: 0x009C7704
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tDir, int tID)
	{
		if (226942 - 459503 != -232560)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (187695 - 82677 != 105019)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (115875 - 355383 == -239508)
				{
					if (94122 - 135841 == -41719)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (252061 - 31021 != 221040)
							{
								continue;
							}
							v = 1;
							if (172625 - 582796 != -410171)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cometMissile_fire")
						{
							if (243471 - 94493 == 148979)
							{
								continue;
							}
							v = 2;
							if (145213 - 403499 != -258286)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cometMissile_hit")
						{
							if (77743 - 252477 == -174733)
							{
								continue;
							}
							v = -1;
							if (4503 - 588612 != -584109)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_randomCast")
						{
							if (45976 - 365603 == -319626)
							{
								continue;
							}
							v = 11;
							if (186557 - 236221 == -49663)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_lightBind_fire")
						{
							if (130234 - 227741 == -97506)
							{
								continue;
							}
							v = 12;
							if (36962 - 225111 == -188148)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_fireBall_fire")
						{
							if (193850 - 560072 == -366221)
							{
								continue;
							}
							v = 13;
							if (154584 - 293748 != -139164)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_fireBall_hit")
						{
							if (150278 - 171619 == -21340)
							{
								continue;
							}
							v = -13;
							if (140580 - 38693 != 101887)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_frozenBlast_fire")
						{
							if (74678 - 589567 != -514889)
							{
								continue;
							}
							v = 14;
							if (200060 - 210023 != -9963)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_groundLock_fire")
						{
							if (48593 - 142686 != -94093)
							{
								continue;
							}
							v = 15;
							if (168713 - 69650 != 99063)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_blink")
						{
							if (58994 - 7742 == 51253)
							{
								continue;
							}
							v = 21;
							if (262638 - 260688 != 1950)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_manaArc")
						{
							if (128970 - 291015 == -162044)
							{
								continue;
							}
							v = 31;
							if (26355 - 51658 != -25303)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (167813 - 269853 == -102039)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (264053 - 570366 != -306312)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (220534 - 466170 == -245636)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (14525 - 123951 == -109426)
								{
									int v5 = Mathf.RoundToInt((float)200 * tDir.x);
									if (296092 - 507305 == -211213)
									{
										int v6 = Mathf.RoundToInt((float)200 * tDir.y);
										if (157152 - 95120 == 62032)
										{
											int v7 = Mathf.RoundToInt((float)200 * tDir.z);
											if (12596 - 222375 != -209778)
											{
												Hashtable hashtable = new Hashtable();
												if (262102 - 100350 == 161752)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (282651 - 240898 != 41754)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (60529 - 194816 == -134287)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (2656 - 15990 != -13333)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (209010 - 343055 == -134045)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (215127 - 495184 != -280056)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (46982 - 10779 == 36203)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (136776 - 540863 == -404087)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (149170 - 414024 != -264853)
																				{
																					PhotonClient.SendEvent(this.MTZcQQBYv9O.ActorNr, 74, hashtable, true, true);
																					if (96292 - 285810 != -189517)
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
		}
	}

	// Token: 0x06004FB7 RID: 20407 RVA: 0x009C9C2C File Offset: 0x009C7E2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (221367 - 147104 != 74263)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (6270 - 326322 != -320051)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (29266 - 492893 == -463627)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (235103 - 61716 == 173387)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (6070 - 125868 == -119798)
						{
							int num3 = num;
							if (82858 - 120553 == -37695)
							{
								if (num3 == 1)
								{
									if (93895 - 415239 == -321344)
									{
										if (this.MTZcQQBYv9O.isMine)
										{
											break;
										}
										if (90285 - 530320 == -440035)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (127618 - 281677 != -154058)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (288436 - 406985 == -118549)
									{
										if (this.MTZcQQBYv9O.isMine)
										{
											break;
										}
										if (5036 - 592052 == -587016)
										{
											this.StartCoroutine_Auto(this.RPC_cometMissile_fire(vector, vector2, num2));
											if (254252 - 442504 != -188251)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (223336 - 505494 == -282158)
									{
										if (this.MTZcQQBYv9O.isMine)
										{
											break;
										}
										if (91505 - 198516 != -107010)
										{
											this.RPC_cometMissile_hit(vector, vector2, num2);
											if (223970 - 219022 == 4948)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (233016 - 303103 == -70087)
									{
										if (this.MTZcQQBYv9O.isMine)
										{
											break;
										}
										if (101129 - 96717 != 4413)
										{
											this.StartCoroutine_Auto(this.RPC_randomCast(vector, vector2, num2));
											if (64549 - 4416 != 60134)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 12)
								{
									if (128531 - 595290 != -466758)
									{
										if (this.MTZcQQBYv9O.isMine)
										{
											break;
										}
										if (178089 - 325578 == -147489)
										{
											this.RPC_lightBind_fire(vector, vector2, num2);
											if (128827 - 133132 == -4305)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 13)
								{
									if (93972 - 175734 == -81762)
									{
										if (this.MTZcQQBYv9O.isMine)
										{
											break;
										}
										if (23486 - 453737 != -430250)
										{
											this.RPC_fireBall_fire(vector, vector2, num2);
											if (64153 - 276778 != -212624)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -13)
								{
									if (147967 - 437655 != -289687)
									{
										if (this.MTZcQQBYv9O.isMine)
										{
											break;
										}
										if (168552 - 561758 != -393205)
										{
											this.RPC_fireBall_hit(vector, vector2, num2);
											if (139868 - 223962 == -84094)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 14)
								{
									if (190912 - 278 == 190634)
									{
										if (this.MTZcQQBYv9O.isMine)
										{
											break;
										}
										if (19553 - 597236 != -577682)
										{
											this.StartCoroutine_Auto(this.RPC_frozenBlast_fire(vector, vector2, num2));
											if (88533 - 92909 != -4375)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 15)
								{
									if (121727 - 184469 != -62741)
									{
										if (this.MTZcQQBYv9O.isMine)
										{
											break;
										}
										if (1461 - 364765 != -363303)
										{
											this.RPC_groundLock_fire(vector, vector2, num2);
											if (298217 - 13064 != 285154)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (76134 - 248886 == -172752)
									{
										if (this.MTZcQQBYv9O.isMine)
										{
											break;
										}
										if (249959 - 98553 == 151406)
										{
											this.StartCoroutine_Auto(this.RPC_blink(vector, vector2, num2));
											if (78640 - 571168 == -492528)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (62433 - 406142 == -343709)
									{
										if (this.MTZcQQBYv9O.isMine)
										{
											break;
										}
										if (108155 - 217033 == -108878)
										{
											this.RPC_manaArc(vector, vector2, num2);
											if (145504 - 276605 == -131101)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (25871 - 86194 == -60323)
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

	// Token: 0x06004FB8 RID: 20408 RVA: 0x009CA2F8 File Offset: 0x009C84F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (65254 - 206934 != -141679)
		{
		}
		for (;;)
		{
			if (!this.MTZcQQBYv9O.isMine)
			{
				if (89250 - 6393 == 82857)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (231166 - 450547 != -219380)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (169339 - 156931 != 12409)
					{
						Vector3 tDir = vector.normalized;
						if (212768 - 77426 != 135343)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (198068 - 230887 == -32819)
							{
								if (150616 - 36334 != 114283)
								{
									if (gameObject)
									{
										if (220148 - 33103 == 187046)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (275699 - 414240 == -138540)
										{
											continue;
										}
									}
									if (!(this.MTZcQQBYv9O.actionState == "standby"))
									{
										if (127588 - 366423 == -238834)
										{
											continue;
										}
										if (!(this.MTZcQQBYv9O.actionState == "run"))
										{
											break;
										}
										if (133565 - 65655 != 67910)
										{
											continue;
										}
									}
									if (this.MTZcQQBYv9O.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (291359 - 164562 != 126798)
									{
										if (gameObject == this.gameObject)
										{
											if (249387 - 108883 == 140505)
											{
												continue;
											}
											tDir = this.transform.forward;
											if (136557 - 514597 != -378040)
											{
												continue;
											}
										}
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, tDir, 0));
										if (73843 - 280971 != -207127)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (226775 - 536278 == -309503)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, tDir, 0);
												if (120241 - 432640 == -312399)
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

	// Token: 0x06004FB9 RID: 20409 RVA: 0x009CA608 File Offset: 0x009C8808
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (287123 - 492935 != -205811)
		{
		}
		for (;;)
		{
			if (!this.MTZcQQBYv9O.isMine)
			{
				if (130309 - 308616 == -178307)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (215240 - 179793 == 35447)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (137829 - 366785 == -228956)
					{
						Vector3 normalized = vector.normalized;
						if (188421 - 145524 != 42898)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (15628 - 539319 != -523690)
							{
								CharacterControl characterControl = null;
								if (161777 - 130747 != 31031)
								{
									if (gameObject)
									{
										if (259007 - 117168 == 141840)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (186206 - 252985 == -66778)
										{
											continue;
										}
									}
									if (!(this.MTZcQQBYv9O.actionState == "standby"))
									{
										if (127668 - 521593 != -393925)
										{
											continue;
										}
										if (!(this.MTZcQQBYv9O.actionState == "run"))
										{
											break;
										}
										if (40331 - 457147 == -416815)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (97644 - 87891 == 9754)
										{
											continue;
										}
										if (gameObject.layer == this.gameObject.layer)
										{
											if (116946 - 385680 != -268734)
											{
												continue;
											}
										}
										else if (this.MTZcQQBYv9O.isTimeOut("randomCast") != (float)0)
										{
											if (68236 - 486686 != -418450)
											{
												continue;
											}
											Camera.main.SendMessage("newGameMessage", "RandomCast is not ready");
											if (4054 - 548904 != -544849)
											{
												break;
											}
											continue;
										}
										else
										{
											this.StartCoroutine_Auto(this.RPC_randomCast(this.transform.position, normalized, characterControl.ActorNr));
											if (296705 - 196373 == 100333)
											{
												continue;
											}
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (225227 - 448957 == -223729)
											{
												continue;
											}
											this.ActionEvent("RPC_randomCast", this.transform.position, normalized, characterControl.ActorNr);
											if (196296 - 552895 != -356599)
											{
												continue;
											}
											break;
										}
									}
									Camera.main.SendMessage("newGameMessage", "Target is not valid");
									if (121373 - 223132 == -101759)
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

	// Token: 0x06004FBA RID: 20410 RVA: 0x009CA98C File Offset: 0x009C8B8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(Vector3 tDir, GameObject targetObject)
	{
	}

	// Token: 0x06004FBB RID: 20411 RVA: 0x009CA990 File Offset: 0x009C8B90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Walrus.$RPC_nAttack$33607(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004FBC RID: 20412 RVA: 0x009CA9A0 File Offset: 0x009C8BA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cometMissile_fire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Walrus.$RPC_cometMissile_fire$33614(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004FBD RID: 20413 RVA: 0x009CA9B0 File Offset: 0x009C8BB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cometMissile_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (186910 - 507796 != -320886)
		{
		}
		for (;;)
		{
			if (this.cometMissile_hit)
			{
				if (59786 - 201696 != -141909)
				{
					UnityEngine.Object.Instantiate(this.cometMissile_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (275132 - 592611 == -317479)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find cometMissile_hit effect");
				if (151003 - 202630 == -51627)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004FBE RID: 20414 RVA: 0x009CAA68 File Offset: 0x009C8C68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_randomCast(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Walrus.$RPC_randomCast$33626(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06004FBF RID: 20415 RVA: 0x009CAA78 File Offset: 0x009C8C78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_lightBind_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (247735 - 290840 != -43105)
		{
		}
		while (PlayerPrefs.GetInt("pvoice", 1) != 0)
		{
			if (175603 - 270093 == -94490)
			{
				if (this.lightBind_vc)
				{
					if (275734 - 430846 == -155112)
					{
						this.audio.PlayOneShot(this.lightBind_vc);
						if (45357 - 350763 != -305405)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Cannot find lightBind voice");
					if (182667 - 57915 == 124752)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004FC0 RID: 20416 RVA: 0x009CAB58 File Offset: 0x009C8D58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_fireBall_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (102774 - 539541 != -436766)
		{
		}
		for (;;)
		{
			if (this.fireBall)
			{
				if (202475 - 225277 != -22802)
				{
					continue;
				}
				GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.fireBall, firePos, Quaternion.LookRotation(fireDir));
				if (113297 - 563870 == -450572)
				{
					continue;
				}
				ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
				if (263556 - 563990 == -300433)
				{
					continue;
				}
				projectileControl.Init(this.MTZcQQBYv9O.ActorNr);
				if (16234 - 506306 != -490072)
				{
					continue;
				}
				projectileControl.life = (float)2 * this.MTZcQQBYv9O.rangeMod;
				if (218602 - 234214 == -15611)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Cannot find fireBall Effect");
				if (14223 - 538064 != -523841)
				{
					continue;
				}
			}
			if (PlayerPrefs.GetInt("pvoice", 1) == 0)
			{
				break;
			}
			if (58859 - 90528 == -31669)
			{
				if (this.fireBall_vc)
				{
					if (248631 - 97210 != 151422)
					{
						this.audio.PlayOneShot(this.fireBall_vc);
						if (288716 - 265487 != 23230)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Cannot find fireBall voice");
					if (73230 - 116981 == -43751)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004FC1 RID: 20417 RVA: 0x009CAD48 File Offset: 0x009C8F48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_fireBall_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (94508 - 250460 != -155951)
		{
		}
		for (;;)
		{
			if (this.fireBall_hit)
			{
				if (176584 - 544849 == -368265)
				{
					UnityEngine.Object.Instantiate(this.fireBall_hit, hitPos, this.transform.rotation);
					if (126214 - 304375 != -178160)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find fireBall_hit Effect");
				if (135956 - 449973 == -314017)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004FC2 RID: 20418 RVA: 0x009CAE08 File Offset: 0x009C9008
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_frozenBlast_fire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Walrus.$RPC_frozenBlast_fire$33641(mPos, this).GetEnumerator();
	}

	// Token: 0x06004FC3 RID: 20419 RVA: 0x009CAE18 File Offset: 0x009C9018
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_groundLock_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (239320 - 478386 != -239066)
		{
		}
		while (PlayerPrefs.GetInt("pvoice", 1) != 0)
		{
			if (267005 - 555197 != -288191)
			{
				if (this.groundLock_vc)
				{
					if (254011 - 584497 == -330486)
					{
						this.audio.PlayOneShot(this.groundLock_vc);
						if (282212 - 87150 != 195063)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Cannot find groundLock voice");
					if (248785 - 427779 == -178994)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004FC4 RID: 20420 RVA: 0x009CAEF8 File Offset: 0x009C90F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_blink(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Walrus.$RPC_blink$33651(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004FC5 RID: 20421 RVA: 0x009CAF08 File Offset: 0x009C9108
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_manaArc(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (137126 - 504071 != -366944)
		{
		}
		for (;;)
		{
			IL_255:
			this.MTZcQQBYv9O.addTimeOut("manaArc", (float)2);
			if (245957 - 435824 == -189867)
			{
				UnityEngine.Object.Instantiate(this.manaArc, mPos + 0.5f * Vector3.up, UnityEngine.Random.rotation);
				if (173629 - 204620 == -30991)
				{
					if (this.MTZcQQBYv9O.isMine)
					{
						if (204907 - 273485 == -68577)
						{
							continue;
						}
						int layerMask = 130816 - (1 << this.gameObject.layer);
						if (279098 - 351120 == -72021)
						{
							continue;
						}
						UnityScript.Lang.Array obj = Damage.FindAreaTarget(mPos, (float)6 * this.MTZcQQBYv9O.rangeMod, (float)3 * this.MTZcQQBYv9O.rangeMod, layerMask);
						if (76527 - 529627 != -453100)
						{
							continue;
						}
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (706 - 104163 == -103456)
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
							if (42900 - 580677 == -537776)
							{
								goto IL_255;
							}
							this.MTZcQQBYv9O.hit(21, gameObject, this.MTZcQQBYv9O.talAdjust(50), 0, 0, (gameObject.transform.position - this.transform.position).normalized);
							if (162036 - 270753 == -108716)
							{
								goto IL_255;
							}
							UnityRuntimeServices.Update(enumerator, gameObject);
							if (105747 - 586202 != -480455)
							{
								goto IL_255;
							}
						}
						if (23192 - 410045 != -386853)
						{
							continue;
						}
					}
					if (PlayerPrefs.GetInt("pvoice", 1) == 0)
					{
						break;
					}
					if (60873 - 267616 == -206743)
					{
						if (this.manaArc_vc)
						{
							if (149934 - 457961 != -308026)
							{
								this.audio.PlayOneShot(this.manaArc_vc);
								if (103015 - 388961 == -285946)
								{
									break;
								}
							}
						}
						else
						{
							Debug.LogError("Cannot find manaArc voice");
							if (272164 - 597561 != -325396)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004FC6 RID: 20422 RVA: 0x009CB1F4 File Offset: 0x009C93F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Walrus.$RPC_ko$33658(nArray, this).GetEnumerator();
	}

	// Token: 0x06004FC7 RID: 20423 RVA: 0x009CB204 File Offset: 0x009C9404
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Walrus.$RPC_dead$33665(nArray, this).GetEnumerator();
	}

	// Token: 0x06004FC8 RID: 20424 RVA: 0x009CB214 File Offset: 0x009C9414
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004FC9 RID: 20425 RVA: 0x009CB218 File Offset: 0x009C9418
	internal static bool Qchxdi5IIq04vwQpx8lj()
	{
		return true;
	}

	// Token: 0x06004FCA RID: 20426 RVA: 0x009CB21C File Offset: 0x009C941C
	internal static bool LMsim65IBkEelHuIv09S()
	{
		return false;
	}

	// Token: 0x0400594E RID: 22862
	private CharacterControl MTZcQQBYv9O;

	// Token: 0x0400594F RID: 22863
	public eWalrusType mWalrusType;

	// Token: 0x04005950 RID: 22864
	public AudioClip awake_vc;

	// Token: 0x04005951 RID: 22865
	public AudioClip nAttack1_vc;

	// Token: 0x04005952 RID: 22866
	public AudioClip nAttack2_vc;

	// Token: 0x04005953 RID: 22867
	public GameObject cometMissile;

	// Token: 0x04005954 RID: 22868
	public GameObject cometMissile_hit;

	// Token: 0x04005955 RID: 22869
	public GameObject castEffect;

	// Token: 0x04005956 RID: 22870
	public AudioClip cast_vc;

	// Token: 0x04005957 RID: 22871
	public AudioClip lightBind_vc;

	// Token: 0x04005958 RID: 22872
	public GameObject fireBall;

	// Token: 0x04005959 RID: 22873
	public AudioClip fireBall_vc;

	// Token: 0x0400595A RID: 22874
	public GameObject fireBall_hit;

	// Token: 0x0400595B RID: 22875
	public GameObject frozenBlast;

	// Token: 0x0400595C RID: 22876
	public AudioClip frozenBlast_vc;

	// Token: 0x0400595D RID: 22877
	public AudioClip groundLock_vc;

	// Token: 0x0400595E RID: 22878
	public GameObject blink;

	// Token: 0x0400595F RID: 22879
	public AudioClip blink_vc;

	// Token: 0x04005960 RID: 22880
	public GameObject manaArc;

	// Token: 0x04005961 RID: 22881
	public AudioClip manaArc_vc;

	// Token: 0x04005962 RID: 22882
	public AudioClip ko_vc;

	// Token: 0x04005963 RID: 22883
	public AudioClip dead_vc;

	// Token: 0x02000DCA RID: 3530
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$33607 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004FCB RID: 20427 RVA: 0x009CB220 File Offset: 0x009C9420
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$33607(Vector3 mPos, Vector3 tDir, Walrus self_)
		{
			if (503 - 592531 != -592027)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (102264 - 133804 == -31540)
				{
					base..ctor();
					if (263747 - 353780 != -90032)
					{
						this.$mPos$33611 = mPos;
						if (278846 - 322712 != -43865)
						{
							this.$tDir$33612 = tDir;
							if (4420 - 285089 == -280669)
							{
								this.$self_$33613 = self_;
								if (202147 - 305272 != -103124)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004FCC RID: 20428 RVA: 0x009CB2FC File Offset: 0x009C94FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Walrus.$RPC_nAttack$33607.$(this.$mPos$33611, this.$tDir$33612, this.$self_$33613);
		}

		// Token: 0x06004FCD RID: 20429 RVA: 0x009CB318 File Offset: 0x009C9518
		internal static bool dju7cE5IekXD5g9I9hJd()
		{
			return true;
		}

		// Token: 0x06004FCE RID: 20430 RVA: 0x009CB31C File Offset: 0x009C951C
		internal static bool CthUqt5Ir3hcbqoGQKsF()
		{
			return false;
		}

		// Token: 0x04005964 RID: 22884
		internal Vector3 $mPos$33611;

		// Token: 0x04005965 RID: 22885
		internal Vector3 $tDir$33612;

		// Token: 0x04005966 RID: 22886
		internal Walrus $self_$33613;

		// Token: 0x02000DCB RID: 3531
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004FCF RID: 20431 RVA: 0x009CB320 File Offset: 0x009C9520
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Walrus self_)
			{
				if (283664 - 556415 != -272750)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (118982 - 555379 == -436397)
					{
						base..ctor();
						if (80840 - 227715 != -146874)
						{
							this.$mPos$33608 = mPos;
							if (104385 - 456826 != -352440)
							{
								this.$tDir$33609 = tDir;
								if (47565 - 549168 == -501603)
								{
									this.$self_$33610 = self_;
									if (1779 - 371878 != -370098)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004FD0 RID: 20432 RVA: 0x009CB3FC File Offset: 0x009C95FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (11800 - 297880 != -286079)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_769;
					case 2:
						if (this.$self_$33610.MTZcQQBYv9O.actionState != "attack")
						{
							goto IL_647;
						}
						if (222914 - 431636 != -208722)
						{
							continue;
						}
						if (this.$self_$33610.MTZcQQBYv9O.myCommand != "nAttack")
						{
							if (225543 - 442732 != -217189)
							{
								continue;
							}
							goto IL_647;
						}
						else
						{
							if (!this.$self_$33610.MTZcQQBYv9O.isMine)
							{
								goto IL_286;
							}
							if (1233 - 274827 == -273593)
							{
								continue;
							}
							this.$self_$33610.StartCoroutine_Auto(this.$self_$33610.RPC_cometMissile_fire(this.$self_$33610.transform.position, this.$self_$33610.transform.forward, 0));
							if (125534 - 17145 != 108389)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_286;
							}
							if (78138 - 496476 == -418337)
							{
								continue;
							}
							this.$self_$33610.ActionEvent("RPC_cometMissile_fire", this.$self_$33610.transform.position, this.$self_$33610.transform.forward, 0);
							if (69903 - 47484 != 22420)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$33610.MTZcQQBYv9O.actionState == "attack")
						{
							if (42585 - 101360 == -58774)
							{
								continue;
							}
							if (this.$self_$33610.MTZcQQBYv9O.myCommand == "nAttack")
							{
								if (189241 - 142917 == 46325)
								{
									continue;
								}
								this.$self_$33610.MTZcQQBYv9O.moveSpeed = (float)0;
								if (145983 - 146539 != -556)
								{
									continue;
								}
								this.$self_$33610.MTZcQQBYv9O.actionState = "standby";
								if (28197 - 563288 != -535091)
								{
									continue;
								}
								this.$self_$33610.MTZcQQBYv9O.actionTime = Time.time;
								if (20418 - 279004 != -258586)
								{
									continue;
								}
								this.$self_$33610.MTZcQQBYv9O.myCommand = "none";
								if (70258 - 170614 == -100355)
								{
									continue;
								}
								if (!this.$self_$33610.MTZcQQBYv9O.isMine)
								{
									if (86581 - 494738 == -408156)
									{
										continue;
									}
									this.$self_$33610.MTZcQQBYv9O.nPosition = this.$self_$33610.transform.position;
									if (60060 - 272913 != -212853)
									{
										continue;
									}
									this.$self_$33610.MTZcQQBYv9O.oPosition = this.$self_$33610.transform.position;
									if (289765 - 467823 == -178057)
									{
										continue;
									}
									this.$self_$33610.MTZcQQBYv9O.nDirection = this.$self_$33610.transform.forward;
									if (106960 - 328667 == -221706)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (167536 - 590499 != -422963)
						{
							continue;
						}
						goto IL_769;
					default:
						if (57094 - 422060 == -364965)
						{
							continue;
						}
						break;
					}
					this.$self_$33610.MTZcQQBYv9O.actionState = "attack";
					if (94618 - 385331 != -290712)
					{
						this.$self_$33610.MTZcQQBYv9O.actionTime = Time.time;
						if (24770 - 401831 == -377061)
						{
							this.$self_$33610.MTZcQQBYv9O.myCommand = "nAttack";
							if (97784 - 221638 != -123853)
							{
								this.$self_$33610.MTZcQQBYv9O.addTimeOut("nAttack", (float)5);
								if (138654 - 411516 != -272861)
								{
									this.$self_$33610.transform.position = this.$mPos$33608;
									if (128658 - 354957 != -226298)
									{
										this.$self_$33610.transform.LookAt(this.$mPos$33608 + global::Math.vFlat(this.$tDir$33609));
										if (173445 - 430220 == -256775)
										{
											this.$self_$33610.animation.CrossFade("nAttack");
											if (27334 - 331572 == -304238)
											{
												this.$self_$33610.animation.wrapMode = WrapMode.Once;
												if (225229 - 183236 != 41994)
												{
													this.$self_$33610.MTZcQQBYv9O.vMovement = this.$self_$33610.transform.forward;
													if (254836 - 319719 != -64882)
													{
														this.$self_$33610.MTZcQQBYv9O.moveSpeed = (float)0;
														if (73351 - 171023 == -97672)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																break;
															}
															if (191861 - 80696 == 111165)
															{
																if (UnityEngine.Random.Range(0, 2) == 0)
																{
																	if (175729 - 564191 == -388462)
																	{
																		if (this.$self_$33610.nAttack1_vc)
																		{
																			if (96927 - 228447 == -131520)
																			{
																				this.$self_$33610.audio.PlayOneShot(this.$self_$33610.nAttack1_vc);
																				if (269530 - 17203 != 252328)
																				{
																					break;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Cannot find nAttack1 voice");
																			if (122717 - 271330 == -148613)
																			{
																				break;
																			}
																		}
																	}
																}
																else if (this.$self_$33610.nAttack2_vc)
																{
																	if (101473 - 599355 == -497882)
																	{
																		this.$self_$33610.audio.PlayOneShot(this.$self_$33610.nAttack2_vc);
																		if (188532 - 180527 == 8005)
																		{
																			break;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Cannot find nAttack2 voice");
																	if (5861 - 398063 != -392201)
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
				IL_13D:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_1B5:
				goto IL_13D;
				IL_286:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_19:
				goto IL_286;
				goto IL_1B5;
				IL_647:
				goto IL_769;
				goto IL_13D;
				IL_769:
				return false;
			}

			// Token: 0x06004FD1 RID: 20433 RVA: 0x009CBB84 File Offset: 0x009C9D84
			internal static bool eHPrIO5IjlUd3KGLEwuc()
			{
				return true;
			}

			// Token: 0x06004FD2 RID: 20434 RVA: 0x009CBB88 File Offset: 0x009C9D88
			internal static bool GApsTs5IhkQEOltPxLeY()
			{
				return false;
			}

			// Token: 0x04005967 RID: 22887
			internal Vector3 $mPos$33608;

			// Token: 0x04005968 RID: 22888
			internal Vector3 $tDir$33609;

			// Token: 0x04005969 RID: 22889
			internal Walrus $self_$33610;
		}
	}

	// Token: 0x02000DCC RID: 3532
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cometMissile_fire$33614 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004FD3 RID: 20435 RVA: 0x009CBB8C File Offset: 0x009C9D8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cometMissile_fire$33614(Vector3 mPos, Vector3 tDir, Walrus self_)
		{
			if (20194 - 232381 != -212186)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (186152 - 194090 != -7937)
				{
					base..ctor();
					if (100363 - 16864 != 83500)
					{
						this.$mPos$33623 = mPos;
						if (224189 - 479559 != -255369)
						{
							this.$tDir$33624 = tDir;
							if (10216 - 450883 != -440666)
							{
								this.$self_$33625 = self_;
								if (99779 - 531088 == -431309)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004FD4 RID: 20436 RVA: 0x009CBC68 File Offset: 0x009C9E68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Walrus.$RPC_cometMissile_fire$33614.$(this.$mPos$33623, this.$tDir$33624, this.$self_$33625);
		}

		// Token: 0x06004FD5 RID: 20437 RVA: 0x009CBC84 File Offset: 0x009C9E84
		internal static bool Sqwb8k5IsJhLa2h9H5Jx()
		{
			return true;
		}

		// Token: 0x06004FD6 RID: 20438 RVA: 0x009CBC88 File Offset: 0x009C9E88
		internal static bool MTrteZ5I9dcCnefPpamU()
		{
			return false;
		}

		// Token: 0x0400596A RID: 22890
		internal Vector3 $mPos$33623;

		// Token: 0x0400596B RID: 22891
		internal Vector3 $tDir$33624;

		// Token: 0x0400596C RID: 22892
		internal Walrus $self_$33625;

		// Token: 0x02000DCD RID: 3533
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004FD7 RID: 20439 RVA: 0x009CBC8C File Offset: 0x009C9E8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Walrus self_)
			{
				if (22351 - 235027 != -212675)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (176405 - 45061 != 131345)
					{
						base..ctor();
						if (91167 - 356761 != -265593)
						{
							this.$mPos$33620 = mPos;
							if (229770 - 505484 != -275713)
							{
								this.$tDir$33621 = tDir;
								if (155171 - 489667 == -334496)
								{
									this.$self_$33622 = self_;
									if (130915 - 393270 != -262354)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004FD8 RID: 20440 RVA: 0x009CBD68 File Offset: 0x009C9F68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (149413 - 323672 != -174258)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_27E;
					case 2:
						this.$i$33615++;
						if (53205 - 91836 != -38630)
						{
							goto IL_1E9;
						}
						continue;
					default:
						if (180262 - 58878 != 121384)
						{
							continue;
						}
						break;
					}
					this.$i$33615 = 0;
					if (180783 - 348997 == -168213)
					{
						continue;
					}
					IL_1E9:
					if (this.$i$33615 > 8)
					{
						if (248241 - 470589 != -222347)
						{
							this.YieldDefault(1);
							if (39417 - 212512 == -173095)
							{
								goto IL_27E;
							}
						}
					}
					else
					{
						this.$firePos$33616 = this.$mPos$33620 + global::Math.rotateH(this.$tDir$33621, (float)(-(float)this.$i$33615 * 40)) + Vector3.up;
						if (225421 - 291203 != -65781)
						{
							this.$fireDir$33617 = global::Math.rotateH(this.$tDir$33621, (float)(-(float)this.$i$33615 * 40));
							if (280905 - 486765 == -205860)
							{
								this.$mMissile$33618 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$33622.cometMissile, this.$firePos$33616, Quaternion.LookRotation(this.$fireDir$33617));
								if (176836 - 523628 != -346791)
								{
									this.$mMissileControl$33619 = (ProjectileControl)this.$mMissile$33618.GetComponent(typeof(ProjectileControl));
									if (172490 - 129090 != 43401)
									{
										if (!this.$mMissileControl$33619)
										{
											break;
										}
										if (142275 - 230942 == -88667)
										{
											this.$mMissileControl$33619.Init(this.$self_$33622.MTZcQQBYv9O.ActorNr);
											if (190588 - 372241 == -181653)
											{
												this.$mMissileControl$33619.life = (float)2;
												if (232148 - 264035 == -31887)
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
				return this.Yield(2, new WaitForSeconds(0.02f));
				IL_27E:
				return false;
			}

			// Token: 0x06004FD9 RID: 20441 RVA: 0x009CC008 File Offset: 0x009CA208
			internal static bool XYkNpa5I1sCD1JACFDlF()
			{
				return true;
			}

			// Token: 0x06004FDA RID: 20442 RVA: 0x009CC00C File Offset: 0x009CA20C
			internal static bool UABNJK5I4KBIZQGSumHx()
			{
				return false;
			}

			// Token: 0x0400596D RID: 22893
			internal int $i$33615;

			// Token: 0x0400596E RID: 22894
			internal Vector3 $firePos$33616;

			// Token: 0x0400596F RID: 22895
			internal Vector3 $fireDir$33617;

			// Token: 0x04005970 RID: 22896
			internal GameObject $mMissile$33618;

			// Token: 0x04005971 RID: 22897
			internal ProjectileControl $mMissileControl$33619;

			// Token: 0x04005972 RID: 22898
			internal Vector3 $mPos$33620;

			// Token: 0x04005973 RID: 22899
			internal Vector3 $tDir$33621;

			// Token: 0x04005974 RID: 22900
			internal Walrus $self_$33622;
		}
	}

	// Token: 0x02000DCE RID: 3534
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_randomCast$33626 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004FDB RID: 20443 RVA: 0x009CC010 File Offset: 0x009CA210
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_randomCast$33626(Vector3 mPos, Vector3 tDir, int tID, Walrus self_)
		{
			if (183980 - 393762 != -209781)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (205880 - 474956 == -269076)
				{
					base..ctor();
					if (290410 - 76027 != 214384)
					{
						this.$mPos$33637 = mPos;
						if (133755 - 30621 == 103134)
						{
							this.$tDir$33638 = tDir;
							if (67053 - 188994 == -121941)
							{
								this.$tID$33639 = tID;
								if (72441 - 462314 == -389873)
								{
									this.$self_$33640 = self_;
									if (109312 - 545396 == -436084)
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

		// Token: 0x06004FDC RID: 20444 RVA: 0x009CC110 File Offset: 0x009CA310
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Walrus.$RPC_randomCast$33626.$(this.$mPos$33637, this.$tDir$33638, this.$tID$33639, this.$self_$33640);
		}

		// Token: 0x06004FDD RID: 20445 RVA: 0x009CC130 File Offset: 0x009CA330
		internal static bool m6XbvV5IzW8C8NtqVS3L()
		{
			return true;
		}

		// Token: 0x06004FDE RID: 20446 RVA: 0x009CC134 File Offset: 0x009CA334
		internal static bool YU6oXS5BaNQTWFCbs877()
		{
			return false;
		}

		// Token: 0x04005975 RID: 22901
		internal Vector3 $mPos$33637;

		// Token: 0x04005976 RID: 22902
		internal Vector3 $tDir$33638;

		// Token: 0x04005977 RID: 22903
		internal int $tID$33639;

		// Token: 0x04005978 RID: 22904
		internal Walrus $self_$33640;

		// Token: 0x02000DCF RID: 3535
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004FDF RID: 20447 RVA: 0x009CC138 File Offset: 0x009CA338
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Walrus self_)
			{
				if (166250 - 365872 != -199621)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (243459 - 403172 == -159713)
					{
						base..ctor();
						if (260916 - 43201 == 217715)
						{
							this.$mPos$33633 = mPos;
							if (61555 - 514703 == -453148)
							{
								this.$tDir$33634 = tDir;
								if (53484 - 111251 == -57767)
								{
									this.$tID$33635 = tID;
									if (94204 - 232681 != -138476)
									{
										this.$self_$33636 = self_;
										if (281206 - 389062 == -107856)
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

			// Token: 0x06004FE0 RID: 20448 RVA: 0x009CC238 File Offset: 0x009CA438
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (167130 - 63499 != 103631)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_D51;
					case 2:
						if (this.$self_$33636.MTZcQQBYv9O.actionState != "attack")
						{
							goto IL_3CF;
						}
						if (194916 - 519169 != -324253)
						{
							continue;
						}
						if (this.$self_$33636.MTZcQQBYv9O.myCommand != "randomCast")
						{
							if (85990 - 186584 != -100594)
							{
								continue;
							}
							goto IL_3CF;
						}
						else
						{
							if (!this.$self_$33636.MTZcQQBYv9O.isMine)
							{
								goto IL_287;
							}
							if (148414 - 116205 != 32209)
							{
								continue;
							}
							this.$tObject$33627 = null;
							if (111882 - 31935 != 79947)
							{
								continue;
							}
							this.$tChar$33628 = null;
							if (145832 - 550227 != -404395)
							{
								continue;
							}
							if (this.$tID$33635 != 0)
							{
								if (248415 - 82435 != 165980)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$33635];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$33627 = (GameObject)obj2;
								if (152366 - 322545 != -170179)
								{
									continue;
								}
							}
							if (!this.$tObject$33627)
							{
								goto IL_287;
							}
							if (40183 - 317257 != -277074)
							{
								continue;
							}
							this.$hitChar$33629 = (CharacterControl)this.$tObject$33627.GetComponent(typeof(CharacterControl));
							if (15720 - 295707 != -279987)
							{
								continue;
							}
							this.$mRandom$33630 = UnityEngine.Random.Range(0, 100);
							if (250017 - 325807 == -75789)
							{
								continue;
							}
							if (this.$mRandom$33630 < 25)
							{
								if (222241 - 377675 != -155434)
								{
									continue;
								}
								if (this.$hitChar$33629)
								{
									if (203016 - 138602 == 64415)
									{
										continue;
									}
									this.$hitChar$33629.RPC_AddStatus("lightBind", 5, Damage.getDebuff((float)3, this.$self_$33636.MTZcQQBYv9O.cha, this.$hitChar$33629.cha), 0, this.$self_$33636.MTZcQQBYv9O.ActorNr);
									if (179801 - 506254 != -326453)
									{
										continue;
									}
								}
								this.$self_$33636.RPC_lightBind_fire(this.$self_$33636.transform.position, this.$self_$33636.transform.forward, this.$tID$33635);
								if (190553 - 174764 != 15789)
								{
									continue;
								}
								if (!PhotonClient.IsInitialized())
								{
									goto IL_ADD;
								}
								if (295246 - 302824 != -7578)
								{
									continue;
								}
								this.$self_$33636.ActionEvent("RPC_lightBind_fire", this.$self_$33636.transform.position, this.$self_$33636.transform.forward, this.$tID$33635);
								if (54060 - 210654 != -156593)
								{
									goto Block_45;
								}
								continue;
							}
							else if (this.$mRandom$33630 < 50)
							{
								if (267305 - 466354 == -199048)
								{
									continue;
								}
								this.$firePos$33631 = this.$self_$33636.transform.position + global::Math.vFlat(this.$tObject$33627.collider.bounds.center - this.$self_$33636.transform.position).normalized + Vector3.up;
								if (80864 - 254358 != -173494)
								{
									continue;
								}
								this.$fireDir$33632 = this.$tObject$33627.collider.bounds.center - this.$firePos$33631;
								if (56446 - 294741 == -238294)
								{
									continue;
								}
								this.$self_$33636.RPC_fireBall_fire(this.$firePos$33631, this.$fireDir$33632, 0);
								if (157001 - 557746 == -400744)
								{
									continue;
								}
								if (!PhotonClient.IsInitialized())
								{
									goto IL_68B;
								}
								if (129894 - 76856 != 53038)
								{
									continue;
								}
								this.$self_$33636.ActionEvent("RPC_fireBall_fire", this.$firePos$33631, this.$fireDir$33632, 0);
								if (215493 - 240355 != -24861)
								{
									goto Block_49;
								}
								continue;
							}
							else if (this.$mRandom$33630 < 75)
							{
								if (232670 - 251403 == -18732)
								{
									continue;
								}
								this.$self_$33636.StartCoroutine_Auto(this.$self_$33636.RPC_frozenBlast_fire(this.$tObject$33627.transform.position, this.$self_$33636.transform.forward, 0));
								if (81268 - 524914 == -443645)
								{
									continue;
								}
								if (!PhotonClient.IsInitialized())
								{
									goto IL_C08;
								}
								if (286471 - 289196 != -2725)
								{
									continue;
								}
								this.$self_$33636.ActionEvent("RPC_frozenBlast_fire", this.$tObject$33627.transform.position, this.$self_$33636.transform.forward, 0);
								if (6883 - 197703 != -190819)
								{
									goto Block_52;
								}
								continue;
							}
							else
							{
								if (this.$self_$33636.MTZcQQBYv9O.hit(14, this.$tObject$33627, this.$self_$33636.MTZcQQBYv9O.talAdjust(40), 1, 0, 0.5f * Vector3.up) == 0)
								{
									goto IL_287;
								}
								if (140649 - 306206 == -165556)
								{
									continue;
								}
								this.$self_$33636.RPC_groundLock_fire(this.$self_$33636.transform.position, this.$self_$33636.transform.forward, this.$tID$33635);
								if (76423 - 46646 == 29778)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (49501 - 516414 != -466913)
									{
										continue;
									}
									this.$self_$33636.ActionEvent("RPC_groundLock_fire", this.$self_$33636.transform.position, this.$self_$33636.transform.forward, this.$tID$33635);
									if (22895 - 500531 != -477636)
									{
										continue;
									}
								}
								if (!this.$hitChar$33629)
								{
									goto IL_287;
								}
								if (112981 - 145830 != -32849)
								{
									continue;
								}
								this.$hitChar$33629.RPC_AddStatus("groundLock", 5, Damage.getDebuff((float)3, this.$self_$33636.MTZcQQBYv9O.cha, this.$hitChar$33629.cha), 0, this.$self_$33636.MTZcQQBYv9O.ActorNr);
								if (40230 - 25495 != 14735)
								{
									continue;
								}
								goto IL_287;
							}
						}
						break;
					case 3:
						if (this.$self_$33636.MTZcQQBYv9O.actionState == "attack")
						{
							if (195878 - 79402 != 116476)
							{
								continue;
							}
							if (this.$self_$33636.MTZcQQBYv9O.myCommand == "randomCast")
							{
								if (221506 - 93947 == 127560)
								{
									continue;
								}
								this.$self_$33636.MTZcQQBYv9O.moveSpeed = (float)0;
								if (128569 - 576979 == -448409)
								{
									continue;
								}
								this.$self_$33636.MTZcQQBYv9O.actionState = "standby";
								if (110590 - 316942 == -206351)
								{
									continue;
								}
								this.$self_$33636.MTZcQQBYv9O.actionTime = Time.time;
								if (113073 - 470461 == -357387)
								{
									continue;
								}
								this.$self_$33636.MTZcQQBYv9O.myCommand = "none";
								if (286244 - 290941 != -4697)
								{
									continue;
								}
								if (!this.$self_$33636.MTZcQQBYv9O.isMine)
								{
									if (63045 - 507937 == -444891)
									{
										continue;
									}
									this.$self_$33636.MTZcQQBYv9O.nPosition = this.$self_$33636.transform.position;
									if (126006 - 139563 != -13557)
									{
										continue;
									}
									this.$self_$33636.MTZcQQBYv9O.oPosition = this.$self_$33636.transform.position;
									if (232257 - 360430 == -128172)
									{
										continue;
									}
									this.$self_$33636.MTZcQQBYv9O.nDirection = this.$self_$33636.transform.forward;
									if (76315 - 28203 != 48112)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (299734 - 162641 != 137093)
						{
							continue;
						}
						goto IL_D51;
					default:
						if (3610 - 293078 == -289467)
						{
							continue;
						}
						break;
					}
					this.$self_$33636.MTZcQQBYv9O.actionState = "attack";
					if (231327 - 228897 == 2430)
					{
						this.$self_$33636.MTZcQQBYv9O.actionTime = Time.time;
						if (118255 - 345969 != -227713)
						{
							this.$self_$33636.MTZcQQBYv9O.myCommand = "randomCast";
							if (215487 - 357572 == -142085)
							{
								this.$self_$33636.MTZcQQBYv9O.addTimeOut("randomCast", (float)12);
								if (226568 - 241912 == -15344)
								{
									this.$self_$33636.transform.position = this.$mPos$33633;
									if (148712 - 27202 != 121511)
									{
										this.$self_$33636.transform.LookAt(this.$mPos$33633 + global::Math.vFlat(this.$tDir$33634));
										if (133259 - 137828 == -4569)
										{
											this.$self_$33636.animation.CrossFade("cast1");
											if (273754 - 108197 == 165557)
											{
												this.$self_$33636.animation.wrapMode = WrapMode.Once;
												if (58616 - 34832 != 23785)
												{
													this.$self_$33636.MTZcQQBYv9O.vMovement = this.$self_$33636.transform.forward;
													if (198583 - 444291 != -245707)
													{
														this.$self_$33636.MTZcQQBYv9O.moveSpeed = (float)0;
														if (142646 - 284102 != -141455)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) != 0)
															{
																if (161762 - 135838 == 25925)
																{
																	continue;
																}
																if (this.$self_$33636.cast_vc)
																{
																	if (40210 - 535922 != -495712)
																	{
																		continue;
																	}
																	this.$self_$33636.audio.PlayOneShot(this.$self_$33636.cast_vc);
																	if (234422 - 250327 == -15904)
																	{
																		continue;
																	}
																}
																else
																{
																	Debug.LogError("Cannot find cast voice");
																	if (69552 - 376305 != -306753)
																	{
																		continue;
																	}
																}
															}
															if (this.$self_$33636.castEffect)
															{
																if (210545 - 164115 == 46430)
																{
																	UnityEngine.Object.Instantiate(this.$self_$33636.castEffect, this.$self_$33636.transform.position, this.$self_$33636.transform.rotation);
																	if (223391 - 224293 == -902)
																	{
																		goto IL_50D;
																	}
																}
															}
															else
															{
																Debug.LogError("Cannot find castEffect Effect");
																if (187918 - 62804 != 125115)
																{
																	goto Block_33;
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
				IL_287:
				return this.Yield(3, new WaitForSeconds(0.4f));
				IL_3CF:
				goto IL_D51;
				IL_50D:
				Block_33:
				goto IL_7B3;
				IL_68B:
				goto IL_287;
				Block_45:
				Block_49:
				goto IL_68B;
				IL_7B3:
				return this.Yield(2, new WaitForSeconds(0.4f));
				Block_52:
				IL_ADD:
				IL_C08:
				goto IL_287;
				IL_D51:
				return false;
			}

			// Token: 0x06004FE1 RID: 20449 RVA: 0x009CCFA8 File Offset: 0x009CB1A8
			internal static bool c8VNU45B5xocLIoqDBZa()
			{
				return true;
			}

			// Token: 0x06004FE2 RID: 20450 RVA: 0x009CCFAC File Offset: 0x009CB1AC
			internal static bool vD0kFJ5BpA5aLOvlNxtG()
			{
				return false;
			}

			// Token: 0x04005979 RID: 22905
			internal GameObject $tObject$33627;

			// Token: 0x0400597A RID: 22906
			internal CharacterControl $tChar$33628;

			// Token: 0x0400597B RID: 22907
			internal CharacterControl $hitChar$33629;

			// Token: 0x0400597C RID: 22908
			internal int $mRandom$33630;

			// Token: 0x0400597D RID: 22909
			internal Vector3 $firePos$33631;

			// Token: 0x0400597E RID: 22910
			internal Vector3 $fireDir$33632;

			// Token: 0x0400597F RID: 22911
			internal Vector3 $mPos$33633;

			// Token: 0x04005980 RID: 22912
			internal Vector3 $tDir$33634;

			// Token: 0x04005981 RID: 22913
			internal int $tID$33635;

			// Token: 0x04005982 RID: 22914
			internal Walrus $self_$33636;
		}
	}

	// Token: 0x02000DD0 RID: 3536
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_frozenBlast_fire$33641 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004FE3 RID: 20451 RVA: 0x009CCFB0 File Offset: 0x009CB1B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_frozenBlast_fire$33641(Vector3 mPos, Walrus self_)
		{
			if (270381 - 9156 != 261225)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (145184 - 192150 == -46966)
				{
					base..ctor();
					if (174459 - 566863 != -392403)
					{
						this.$mPos$33649 = mPos;
						if (44530 - 173250 != -128719)
						{
							this.$self_$33650 = self_;
							if (17090 - 498998 != -481907)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004FE4 RID: 20452 RVA: 0x009CD06C File Offset: 0x009CB26C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Walrus.$RPC_frozenBlast_fire$33641.$(this.$mPos$33649, this.$self_$33650);
		}

		// Token: 0x06004FE5 RID: 20453 RVA: 0x009CD080 File Offset: 0x009CB280
		internal static bool QxX6l55BVKuGNv6cW51M()
		{
			return true;
		}

		// Token: 0x06004FE6 RID: 20454 RVA: 0x009CD084 File Offset: 0x009CB284
		internal static bool OdacDK5BtEpOKZ6T1pc4()
		{
			return false;
		}

		// Token: 0x04005983 RID: 22915
		internal Vector3 $mPos$33649;

		// Token: 0x04005984 RID: 22916
		internal Walrus $self_$33650;

		// Token: 0x02000DD1 RID: 3537
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004FE7 RID: 20455 RVA: 0x009CD088 File Offset: 0x009CB288
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Walrus self_)
			{
				if (192732 - 439031 != -246298)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (241330 - 489930 != -248599)
					{
						base..ctor();
						if (48297 - 357035 == -308738)
						{
							this.$mPos$33647 = mPos;
							if (114787 - 593204 != -478416)
							{
								this.$self_$33648 = self_;
								if (183257 - 226870 == -43613)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004FE8 RID: 20456 RVA: 0x009CD144 File Offset: 0x009CB344
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (187512 - 564567 != -377055)
				{
				}
				for (;;)
				{
					IL_388:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_44D;
					case 2:
						if (this.$self_$33648.MTZcQQBYv9O.isMine)
						{
							if (113970 - 183603 == -69632)
							{
								continue;
							}
							this.$hitLayer$33642 = 130816 - (1 << this.$self_$33648.gameObject.layer);
							if (104643 - 120001 != -15358)
							{
								continue;
							}
							this.$hitList$33643 = Damage.FindAreaTarget(this.$mPos$33647, (float)4, (float)3, this.$hitLayer$33642);
							if (90077 - 175117 != -85040)
							{
								continue;
							}
							this.$$iterator$10838$33646 = UnityRuntimeServices.GetEnumerator(this.$hitList$33643);
							if (244009 - 271396 != -27387)
							{
								continue;
							}
							while (this.$$iterator$10838$33646.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10838$33646.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$33644 = (GameObject)obj2;
								if (165764 - 356849 != -191085)
								{
									goto IL_388;
								}
								if (this.$self_$33648.MTZcQQBYv9O.hit(13, this.$hitObject$33644, this.$self_$33648.MTZcQQBYv9O.talAdjust(65), 1, 0, 0.5f * Vector3.up) != 0)
								{
									if (24249 - 14524 != 9725)
									{
										goto IL_388;
									}
									this.$tChar$33645 = (CharacterControl)this.$hitObject$33644.GetComponent(typeof(CharacterControl));
									if (82678 - 508836 != -426158)
									{
										goto IL_388;
									}
									UnityRuntimeServices.Update(this.$$iterator$10838$33646, this.$hitObject$33644);
									if (206547 - 369412 == -162864)
									{
										goto IL_388;
									}
									this.$tChar$33645.RPC_AddStatus("ice", 5, this.$self_$33648.MTZcQQBYv9O.chaAdjust(3), 0, this.$self_$33648.MTZcQQBYv9O.ActorNr);
									if (124041 - 488168 != -364127)
									{
										goto IL_388;
									}
									this.$self_$33648.MTZcQQBYv9O.sp = this.$self_$33648.MTZcQQBYv9O.sp + 1;
									if (88058 - 544144 != -456086)
									{
										goto IL_388;
									}
								}
							}
							if (231329 - 403029 == -171699)
							{
								continue;
							}
						}
						if (PlayerPrefs.GetInt("pvoice", 1) != 0)
						{
							if (4593 - 571289 == -566695)
							{
								continue;
							}
							if (this.$self_$33648.frozenBlast_vc)
							{
								if (193678 - 588023 != -394345)
								{
									continue;
								}
								this.$self_$33648.audio.PlayOneShot(this.$self_$33648.frozenBlast_vc);
								if (108219 - 500842 == -392622)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find frozenBlast voice");
								if (92099 - 499665 == -407565)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (293712 - 35542 != 258170)
						{
							continue;
						}
						goto IL_44D;
					default:
						if (2783 - 424074 != -421291)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33648.frozenBlast)
					{
						if (206440 - 181293 != 25148)
						{
							UnityEngine.Object.Instantiate(this.$self_$33648.frozenBlast, this.$mPos$33647, Quaternion.identity);
							if (172822 - 259920 != -87097)
							{
								break;
							}
						}
					}
					else
					{
						Debug.LogError("Cannot find frozenBlast Effect");
						if (79603 - 65894 == 13709)
						{
							break;
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_44D:
				return false;
			}

			// Token: 0x06004FE9 RID: 20457 RVA: 0x009CD5B0 File Offset: 0x009CB7B0
			internal static bool MKCCBb5BNqNnxoXujr0n()
			{
				return true;
			}

			// Token: 0x06004FEA RID: 20458 RVA: 0x009CD5B4 File Offset: 0x009CB7B4
			internal static bool dSdEPS5BYy9qBah5vuSn()
			{
				return false;
			}

			// Token: 0x04005985 RID: 22917
			internal int $hitLayer$33642;

			// Token: 0x04005986 RID: 22918
			internal UnityScript.Lang.Array $hitList$33643;

			// Token: 0x04005987 RID: 22919
			internal GameObject $hitObject$33644;

			// Token: 0x04005988 RID: 22920
			internal CharacterControl $tChar$33645;

			// Token: 0x04005989 RID: 22921
			internal IEnumerator $$iterator$10838$33646;

			// Token: 0x0400598A RID: 22922
			internal Vector3 $mPos$33647;

			// Token: 0x0400598B RID: 22923
			internal Walrus $self_$33648;
		}
	}

	// Token: 0x02000DD2 RID: 3538
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_blink$33651 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004FEB RID: 20459 RVA: 0x009CD5B8 File Offset: 0x009CB7B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_blink$33651(Vector3 mPos, Vector3 tDir, Walrus self_)
		{
			if (102502 - 92979 != 9523)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (1227 - 356169 == -354942)
				{
					base..ctor();
					if (250442 - 422207 == -171765)
					{
						this.$mPos$33655 = mPos;
						if (84218 - 83452 == 766)
						{
							this.$tDir$33656 = tDir;
							if (160158 - 75784 == 84374)
							{
								this.$self_$33657 = self_;
								if (148126 - 409750 == -261624)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004FEC RID: 20460 RVA: 0x009CD694 File Offset: 0x009CB894
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Walrus.$RPC_blink$33651.$(this.$mPos$33655, this.$tDir$33656, this.$self_$33657);
		}

		// Token: 0x06004FED RID: 20461 RVA: 0x009CD6B0 File Offset: 0x009CB8B0
		internal static bool VIbXwo5BcAkHtevb9bSi()
		{
			return true;
		}

		// Token: 0x06004FEE RID: 20462 RVA: 0x009CD6B4 File Offset: 0x009CB8B4
		internal static bool aTW8cD5BU834V2DBZ1y7()
		{
			return false;
		}

		// Token: 0x0400598C RID: 22924
		internal Vector3 $mPos$33655;

		// Token: 0x0400598D RID: 22925
		internal Vector3 $tDir$33656;

		// Token: 0x0400598E RID: 22926
		internal Walrus $self_$33657;

		// Token: 0x02000DD3 RID: 3539
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004FEF RID: 20463 RVA: 0x009CD6B8 File Offset: 0x009CB8B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Walrus self_)
			{
				if (160635 - 208265 != -47629)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (218034 - 395067 != -177032)
					{
						base..ctor();
						if (253713 - 38708 != 215006)
						{
							this.$mPos$33652 = mPos;
							if (267476 - 133567 == 133909)
							{
								this.$tDir$33653 = tDir;
								if (37930 - 142270 != -104339)
								{
									this.$self_$33654 = self_;
									if (179335 - 204267 == -24932)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004FF0 RID: 20464 RVA: 0x009CD794 File Offset: 0x009CB994
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (134196 - 271307 != -137110)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_708;
					case 2:
						if (this.$self_$33654.MTZcQQBYv9O.actionState != "attack")
						{
							goto IL_7E;
						}
						if (188329 - 509105 == -320775)
						{
							continue;
						}
						if (this.$self_$33654.MTZcQQBYv9O.myCommand != "blink")
						{
							if (248643 - 522220 != -273577)
							{
								continue;
							}
							goto IL_7E;
						}
						else
						{
							if (this.$self_$33654.blink)
							{
								if (6800 - 430856 != -424056)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$33654.blink, this.$self_$33654.transform.position, this.$self_$33654.transform.rotation);
								if (9971 - 227180 != -217209)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find blink Effect");
								if (86017 - 192319 == -106301)
								{
									continue;
								}
							}
							this.$self_$33654.transform.position = this.$mPos$33652;
							if (159676 - 577312 == -417635)
							{
								continue;
							}
							this.$self_$33654.transform.LookAt(this.$mPos$33652 + global::Math.vFlat(this.$tDir$33653));
							if (234847 - 187375 != 47472)
							{
								continue;
							}
							if (this.$self_$33654.blink)
							{
								if (46910 - 507968 == -461057)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$33654.blink, this.$self_$33654.transform.position, this.$self_$33654.transform.rotation);
								if (265915 - 572267 != -306351)
								{
									goto Block_31;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find blink Effect");
								if (76037 - 570424 != -494387)
								{
									continue;
								}
								goto IL_2B0;
							}
						}
						break;
					case 3:
						if (this.$self_$33654.MTZcQQBYv9O.actionState == "attack")
						{
							if (248473 - 303412 == -54938)
							{
								continue;
							}
							if (this.$self_$33654.MTZcQQBYv9O.myCommand == "blink")
							{
								if (197125 - 155669 == 41457)
								{
									continue;
								}
								this.$self_$33654.MTZcQQBYv9O.moveSpeed = (float)0;
								if (217338 - 385183 == -167844)
								{
									continue;
								}
								this.$self_$33654.MTZcQQBYv9O.actionState = "standby";
								if (261130 - 500838 != -239708)
								{
									continue;
								}
								this.$self_$33654.MTZcQQBYv9O.actionTime = Time.time;
								if (120269 - 70642 != 49627)
								{
									continue;
								}
								this.$self_$33654.MTZcQQBYv9O.myCommand = "none";
								if (130203 - 8888 == 121316)
								{
									continue;
								}
								if (!this.$self_$33654.MTZcQQBYv9O.isMine)
								{
									if (199749 - 70420 == 129330)
									{
										continue;
									}
									this.$self_$33654.MTZcQQBYv9O.nPosition = this.$self_$33654.transform.position;
									if (10390 - 8284 == 2107)
									{
										continue;
									}
									this.$self_$33654.MTZcQQBYv9O.oPosition = this.$self_$33654.transform.position;
									if (297017 - 61963 == 235055)
									{
										continue;
									}
									this.$self_$33654.MTZcQQBYv9O.nDirection = this.$self_$33654.transform.forward;
									if (1136 - 223238 == -222101)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (75050 - 304701 != -229651)
						{
							continue;
						}
						goto IL_708;
					default:
						if (272423 - 315373 == -42949)
						{
							continue;
						}
						break;
					}
					this.$self_$33654.MTZcQQBYv9O.actionState = "attack";
					if (25902 - 159068 == -133166)
					{
						this.$self_$33654.MTZcQQBYv9O.actionTime = Time.time;
						if (194565 - 235628 == -41063)
						{
							this.$self_$33654.MTZcQQBYv9O.myCommand = "blink";
							if (6124 - 357105 == -350981)
							{
								this.$self_$33654.MTZcQQBYv9O.addTimeOut("blink", (float)30);
								if (66613 - 569466 == -502853)
								{
									this.$self_$33654.animation.CrossFade("cast1");
									if (150547 - 282082 == -131535)
									{
										this.$self_$33654.animation.wrapMode = WrapMode.Once;
										if (119426 - 206742 != -87315)
										{
											this.$self_$33654.MTZcQQBYv9O.vMovement = this.$self_$33654.transform.forward;
											if (294846 - 505775 == -210929)
											{
												this.$self_$33654.MTZcQQBYv9O.moveSpeed = (float)0;
												if (116241 - 169551 != -53309)
												{
													if (PlayerPrefs.GetInt("pvoice", 1) == 0)
													{
														goto IL_42E;
													}
													if (280697 - 14198 == 266499)
													{
														if (this.$self_$33654.blink_vc)
														{
															if (13761 - 522027 == -508266)
															{
																this.$self_$33654.audio.PlayOneShot(this.$self_$33654.blink_vc);
																if (139205 - 334789 == -195584)
																{
																	goto IL_6DF;
																}
															}
														}
														else
														{
															Debug.LogError("Cannot find blink voice");
															if (140625 - 150307 == -9682)
															{
																goto IL_42E;
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
				IL_7E:
				goto IL_708;
				IL_2B0:
				return this.Yield(3, new WaitForSeconds(0.4f));
				IL_42E:
				return this.Yield(2, new WaitForSeconds(0.4f));
				Block_31:
				goto IL_2B0;
				IL_6DF:
				goto IL_42E;
				IL_708:
				return false;
			}

			// Token: 0x06004FF1 RID: 20465 RVA: 0x009CDEBC File Offset: 0x009CC0BC
			internal static bool xxlJ3g5BTUyGTmyClBhR()
			{
				return true;
			}

			// Token: 0x06004FF2 RID: 20466 RVA: 0x009CDEC0 File Offset: 0x009CC0C0
			internal static bool IxAwXO5B3SW0hltUJVLO()
			{
				return false;
			}

			// Token: 0x0400598F RID: 22927
			internal Vector3 $mPos$33652;

			// Token: 0x04005990 RID: 22928
			internal Vector3 $tDir$33653;

			// Token: 0x04005991 RID: 22929
			internal Walrus $self_$33654;
		}
	}

	// Token: 0x02000DD4 RID: 3540
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$33658 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004FF3 RID: 20467 RVA: 0x009CDEC4 File Offset: 0x009CC0C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$33658(UnityScript.Lang.Array nArray, Walrus self_)
		{
			if (100769 - 198011 != -97242)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (176425 - 109253 != 67173)
				{
					base..ctor();
					if (194423 - 201764 == -7341)
					{
						this.$nArray$33663 = nArray;
						if (71407 - 515467 == -444060)
						{
							this.$self_$33664 = self_;
							if (250839 - 339543 != -88703)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004FF4 RID: 20468 RVA: 0x009CDF80 File Offset: 0x009CC180
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Walrus.$RPC_ko$33658.$(this.$nArray$33663, this.$self_$33664);
		}

		// Token: 0x06004FF5 RID: 20469 RVA: 0x009CDF94 File Offset: 0x009CC194
		internal static bool SDfUBS5BXuBkAaV8xs7s()
		{
			return true;
		}

		// Token: 0x06004FF6 RID: 20470 RVA: 0x009CDF98 File Offset: 0x009CC198
		internal static bool P0XSPY5BQROnFGCAkrls()
		{
			return false;
		}

		// Token: 0x04005992 RID: 22930
		internal UnityScript.Lang.Array $nArray$33663;

		// Token: 0x04005993 RID: 22931
		internal Walrus $self_$33664;

		// Token: 0x02000DD5 RID: 3541
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004FF7 RID: 20471 RVA: 0x009CDF9C File Offset: 0x009CC19C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Walrus self_)
			{
				if (118589 - 290639 != -172049)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (135285 - 310245 == -174960)
					{
						base..ctor();
						if (204665 - 190507 == 14158)
						{
							this.$nArray$33661 = nArray;
							if (218890 - 139887 != 79004)
							{
								this.$self_$33662 = self_;
								if (244662 - 76929 != 167734)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004FF8 RID: 20472 RVA: 0x009CE058 File Offset: 0x009CC258
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (187150 - 550016 != -362866)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_543;
					case 2:
						if (this.$self_$33662.MTZcQQBYv9O.actionState != "ko")
						{
							if (85592 - 423466 != -337874)
							{
								continue;
							}
							goto IL_1D5;
						}
						else
						{
							this.$self_$33662.animation.Play("getUp");
							if (46808 - 78607 == -31798)
							{
								continue;
							}
							this.$self_$33662.animation.wrapMode = WrapMode.Once;
							if (94540 - 591402 != -496862)
							{
								continue;
							}
							goto IL_45E;
						}
						break;
					case 3:
						if (this.$self_$33662.MTZcQQBYv9O.actionState != "ko")
						{
							if (248508 - 527689 != -279181)
							{
								continue;
							}
							goto IL_30C;
						}
						else
						{
							this.$self_$33662.MTZcQQBYv9O.actionState = "standby";
							if (211376 - 61193 != 150183)
							{
								continue;
							}
							this.$self_$33662.MTZcQQBYv9O.actionTime = Time.time;
							if (4061 - 170985 != -166924)
							{
								continue;
							}
							this.$self_$33662.MTZcQQBYv9O.myCommand = "none";
							if (47669 - 345757 != -298088)
							{
								continue;
							}
							this.$self_$33662.MTZcQQBYv9O.ko = this.$self_$33662.MTZcQQBYv9O.mko;
							if (128885 - 97348 == 31538)
							{
								continue;
							}
							this.YieldDefault(1);
							if (260323 - 244991 != 15332)
							{
								continue;
							}
							goto IL_543;
						}
						break;
					default:
						if (98456 - 205811 == -107354)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33662.MTZcQQBYv9O.actionState == "ko")
					{
						goto IL_4AD;
					}
					if (56310 - 160095 == -103785)
					{
						if (this.$self_$33662.MTZcQQBYv9O.actionState == "dead")
						{
							if (107785 - 7384 == 100401)
							{
								goto IL_4AD;
							}
						}
						else
						{
							this.$mPos$33659 = (Vector3)this.$nArray$33661[0];
							if (77368 - 472452 != -395083)
							{
								this.$mDir$33660 = (Vector3)this.$nArray$33661[1];
								if (284575 - 365304 == -80729)
								{
									this.$self_$33662.MTZcQQBYv9O.ko = 0;
									if (284834 - 420194 == -135360)
									{
										this.$self_$33662.MTZcQQBYv9O.actionState = "ko";
										if (154789 - 3019 == 151770)
										{
											this.$self_$33662.MTZcQQBYv9O.actionTime = Time.time;
											if (272198 - 518189 == -245991)
											{
												this.$self_$33662.MTZcQQBYv9O.myCommand = "none";
												if (220682 - 231805 == -11123)
												{
													this.$self_$33662.MTZcQQBYv9O.vMovement = Vector3.zero;
													if (210406 - 319525 != -109118)
													{
														this.$self_$33662.MTZcQQBYv9O.moveSpeed = (float)0;
														if (159086 - 250671 == -91585)
														{
															this.$self_$33662.animation.Play("ko");
															if (166240 - 29480 != 136761)
															{
																this.$self_$33662.animation.wrapMode = WrapMode.Once;
																if (39584 - 266368 == -226784)
																{
																	if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																	{
																		break;
																	}
																	if (172895 - 322295 == -149400)
																	{
																		if (this.$self_$33662.ko_vc)
																		{
																			if (141221 - 393579 == -252358)
																			{
																				this.$self_$33662.audio.PlayOneShot(this.$self_$33662.ko_vc);
																				if (117091 - 23227 != 93865)
																				{
																					break;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Cannot find ko voice");
																			if (157394 - 444212 == -286818)
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
				IL_1A:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_1D5:
				goto IL_543;
				goto IL_1A;
				IL_30C:
				goto IL_543;
				IL_45E:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_4AD:
				IL_543:
				return false;
			}

			// Token: 0x06004FF9 RID: 20473 RVA: 0x009CE5BC File Offset: 0x009CC7BC
			internal static bool Gfm8Nf5Bkd14hSR7pdJT()
			{
				return true;
			}

			// Token: 0x06004FFA RID: 20474 RVA: 0x009CE5C0 File Offset: 0x009CC7C0
			internal static bool kh79XF5BGVYYv0u7DCKC()
			{
				return false;
			}

			// Token: 0x04005994 RID: 22932
			internal Vector3 $mPos$33659;

			// Token: 0x04005995 RID: 22933
			internal Vector3 $mDir$33660;

			// Token: 0x04005996 RID: 22934
			internal UnityScript.Lang.Array $nArray$33661;

			// Token: 0x04005997 RID: 22935
			internal Walrus $self_$33662;
		}
	}

	// Token: 0x02000DD6 RID: 3542
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$33665 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004FFB RID: 20475 RVA: 0x009CE5C4 File Offset: 0x009CC7C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$33665(UnityScript.Lang.Array nArray, Walrus self_)
		{
			if (164189 - 585347 != -421157)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (102200 - 11663 != 90538)
				{
					base..ctor();
					if (212445 - 194740 != 17706)
					{
						this.$nArray$33675 = nArray;
						if (254320 - 76250 == 178070)
						{
							this.$self_$33676 = self_;
							if (233819 - 129314 == 104505)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004FFC RID: 20476 RVA: 0x009CE680 File Offset: 0x009CC880
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Walrus.$RPC_dead$33665.$(this.$nArray$33675, this.$self_$33676);
		}

		// Token: 0x06004FFD RID: 20477 RVA: 0x009CE694 File Offset: 0x009CC894
		internal static bool dClWH55BHNE12Zr0Hgdn()
		{
			return true;
		}

		// Token: 0x06004FFE RID: 20478 RVA: 0x009CE698 File Offset: 0x009CC898
		internal static bool F1n6UO5BWoBMHeyK4luZ()
		{
			return false;
		}

		// Token: 0x04005998 RID: 22936
		internal UnityScript.Lang.Array $nArray$33675;

		// Token: 0x04005999 RID: 22937
		internal Walrus $self_$33676;

		// Token: 0x02000DD7 RID: 3543
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004FFF RID: 20479 RVA: 0x009CE69C File Offset: 0x009CC89C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Walrus self_)
			{
				if (191678 - 421013 != -229334)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (952 - 87150 != -86197)
					{
						base..ctor();
						if (158526 - 18706 == 139820)
						{
							this.$nArray$33673 = nArray;
							if (194072 - 52616 != 141457)
							{
								this.$self_$33674 = self_;
								if (96942 - 97028 == -86)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06005000 RID: 20480 RVA: 0x009CE758 File Offset: 0x009CC958
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (150347 - 475793 != -325445)
				{
				}
				for (;;)
				{
					IL_E4:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_64C;
					case 2:
						if (this.$self_$33674.MTZcQQBYv9O.actionState != "dead")
						{
							if (298978 - 294028 != 4951)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							if (!this.$self_$33674.MTZcQQBYv9O.isPlayer)
							{
								if (189848 - 214075 != -24227)
								{
									continue;
								}
								this.$mGameObjectList$33668 = (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), GameObject.FindGameObjectsWithTag("Player"), GameObject.FindGameObjectsWithTag("Enemy"));
								if (215634 - 42833 != 172801)
								{
									continue;
								}
								this.$$11496$33670 = 0;
								if (121239 - 486762 != -365523)
								{
									continue;
								}
								this.$$11497$33671 = this.$mGameObjectList$33668;
								if (59308 - 595223 != -535915)
								{
									continue;
								}
								this.$$11498$33672 = this.$$11497$33671.Length;
								if (135713 - 378016 == -242302)
								{
									continue;
								}
								while (this.$$11496$33670 < this.$$11498$33672)
								{
									if (this.$$11497$33671[this.$$11496$33670] != this.$self_$33674.gameObject)
									{
										if (73507 - 125320 != -51813)
										{
											goto IL_E4;
										}
										Physics.IgnoreCollision(this.$$11497$33671[this.$$11496$33670].collider, this.$self_$33674.gameObject.collider, true);
										if (250586 - 84611 != 165975)
										{
											goto IL_E4;
										}
									}
									this.$$11496$33670++;
									if (41667 - 216120 != -174453)
									{
										goto IL_E4;
									}
								}
								if (283385 - 378443 != -95058)
								{
									continue;
								}
							}
							else if (this.$self_$33674.MTZcQQBYv9O.isMine)
							{
								if (204390 - 479663 == -275272)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$33674.gameObject);
								if (139275 - 354278 != -215003)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (138950 - 472481 != -333530)
							{
								goto Block_8;
							}
							continue;
						}
						break;
					default:
						if (117314 - 440563 == -323248)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33674.MTZcQQBYv9O.actionState == "dead")
					{
						if (80546 - 599074 != -518527)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$33666 = (Vector3)this.$nArray$33673[0];
						if (269145 - 293107 == -23962)
						{
							this.$myDirection$33667 = (Vector3)this.$nArray$33673[1];
							if (282533 - 174673 != 107861)
							{
								this.$self_$33674.transform.position = this.$myPosition$33666;
								if (37062 - 103307 != -66244)
								{
									this.$self_$33674.transform.LookAt(this.$myPosition$33666 + this.$myDirection$33667);
									if (47415 - 126107 != -78691)
									{
										this.$self_$33674.MTZcQQBYv9O.hp = 0;
										if (225652 - 207305 == 18347)
										{
											this.$self_$33674.MTZcQQBYv9O.actionState = "dead";
											if (224181 - 25667 != 198515)
											{
												this.$self_$33674.MTZcQQBYv9O.actionTime = Time.time;
												if (227774 - 48765 == 179009)
												{
													this.$self_$33674.MTZcQQBYv9O.myCommand = "none";
													if (241002 - 597060 == -356058)
													{
														this.$self_$33674.MTZcQQBYv9O.vMovement = Vector3.zero;
														if (124115 - 362958 == -238843)
														{
															this.$self_$33674.MTZcQQBYv9O.moveSpeed = (float)0;
															if (253617 - 594244 == -340627)
															{
																this.$self_$33674.animation.Rewind();
																if (9244 - 313786 == -304542)
																{
																	this.$self_$33674.animation.Play("ko");
																	if (137289 - 247604 != -110314)
																	{
																		this.$self_$33674.animation.wrapMode = WrapMode.Once;
																		if (40568 - 256588 == -216020)
																		{
																			if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																			{
																				goto IL_3EC;
																			}
																			if (137879 - 387780 != -249900)
																			{
																				if (this.$self_$33674.dead_vc)
																				{
																					if (97509 - 242384 != -144874)
																					{
																						this.$self_$33674.audio.PlayOneShot(this.$self_$33674.dead_vc);
																						if (160896 - 269348 != -108451)
																						{
																							goto Block_32;
																						}
																					}
																				}
																				else
																				{
																					Debug.LogError("Cannot find dead voice");
																					if (270321 - 29844 != 240478)
																					{
																						goto Block_29;
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
				Block_8:
				goto IL_64C;
				IL_3EC:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_27:
				goto IL_64C;
				Block_29:
				Block_32:
				goto IL_3EC;
				IL_64C:
				return false;
			}

			// Token: 0x06005001 RID: 20481 RVA: 0x009CEDC4 File Offset: 0x009CCFC4
			internal static bool MPlSdi5BAOtAiNOv9j6Z()
			{
				return true;
			}

			// Token: 0x06005002 RID: 20482 RVA: 0x009CEDC8 File Offset: 0x009CCFC8
			internal static bool KXfxjp5BlKulTOCNWT4n()
			{
				return false;
			}

			// Token: 0x0400599A RID: 22938
			internal Vector3 $myPosition$33666;

			// Token: 0x0400599B RID: 22939
			internal Vector3 $myDirection$33667;

			// Token: 0x0400599C RID: 22940
			internal GameObject[] $mGameObjectList$33668;

			// Token: 0x0400599D RID: 22941
			internal GameObject $mGameObject$33669;

			// Token: 0x0400599E RID: 22942
			internal int $$11496$33670;

			// Token: 0x0400599F RID: 22943
			internal GameObject[] $$11497$33671;

			// Token: 0x040059A0 RID: 22944
			internal int $$11498$33672;

			// Token: 0x040059A1 RID: 22945
			internal UnityScript.Lang.Array $nArray$33673;

			// Token: 0x040059A2 RID: 22946
			internal Walrus $self_$33674;
		}
	}
}
