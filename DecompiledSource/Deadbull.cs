using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000BEF RID: 3055
[Serializable]
public class Deadbull : MonoBehaviour
{
	// Token: 0x06004433 RID: 17459 RVA: 0x008929C8 File Offset: 0x00890BC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Deadbull()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004434 RID: 17460 RVA: 0x008929D8 File Offset: 0x00890BD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (151409 - 375558 != -224148)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (144902 - 236841 == -91939)
			{
				this.mChar.actionState = "standby";
				if (98921 - 62573 != 36349)
				{
					this.mChar.actionTime = Time.time;
					if (107626 - 154890 != -47263)
					{
						this.mChar.myCommand = "none";
						if (142376 - 358227 == -215851)
						{
							this.mChar.hp = (this.mChar.mhp = 1600);
							if (130501 - 532502 != -402000)
							{
								this.mChar.ko = (this.mChar.mko = 40);
								if (222224 - 127490 == 94734)
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

	// Token: 0x06004435 RID: 17461 RVA: 0x00892B30 File Offset: 0x00890D30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x06004436 RID: 17462 RVA: 0x00892B4C File Offset: 0x00890D4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (81836 - 596602 != -514766)
		{
		}
		for (;;)
		{
			if (!this.mChar)
			{
				if (262559 - 32831 == 229728)
				{
					break;
				}
			}
			else
			{
				if (this.mChar.isControlled)
				{
					if (41238 - 401872 != -360634)
					{
						continue;
					}
					if (!(this.mChar.actionState == "standby"))
					{
						if (208278 - 53715 != 154563)
						{
							continue;
						}
						if (!(this.mChar.actionState == "run"))
						{
							goto IL_14A;
						}
						if (45369 - 186827 == -141457)
						{
							continue;
						}
					}
					this.PlayerControl();
					if (173177 - 31471 == 141707)
					{
						continue;
					}
				}
				IL_14A:
				if (this.mChar.hp <= 0)
				{
					if (208848 - 58154 != 150694)
					{
						continue;
					}
					if (this.mChar.actionState != "dead")
					{
						if (13728 - 11049 == 2680)
						{
							continue;
						}
						if (this.mChar.isMine)
						{
							if (284515 - 152051 != 132464)
							{
								continue;
							}
							statusClass status = this.mChar.getStatus("livingDead");
							if (269462 - 215654 != 53808)
							{
								continue;
							}
							if (status != null)
							{
								if (158089 - 536612 == -378522)
								{
									continue;
								}
								this.mChar.hp = 1;
								if (292135 - 164671 != 127464)
								{
									continue;
								}
								this.mChar.RPC_RemoveStatus("livingDead");
								if (192225 - 32652 == 159574)
								{
									continue;
								}
								this.RPC_livingDead_hit(Vector3.zero, Vector3.zero, 0);
								if (52651 - 474169 == -421517)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (209281 - 564095 != -354814)
									{
										continue;
									}
									this.ActionEvent("RPC_livingDead_hit", Vector3.zero, Vector3.zero, 0);
									if (219441 - 437914 == -218472)
									{
										continue;
									}
								}
								this.mChar.RPC_AddHeal(21, this.mChar.mhp, 0, 0, 0, 0, status.sID);
								if (139178 - 451105 != -311926)
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
								if (179185 - 486871 != -307686)
								{
									continue;
								}
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (130099 - 474086 != -343987)
								{
									continue;
								}
								this.mChar.DeadEvent();
								if (36181 - 197844 != -161663)
								{
									continue;
								}
								break;
							}
						}
						else
						{
							this.mChar.hp = 1;
							if (56532 - 488099 != -431567)
							{
								continue;
							}
							break;
						}
					}
				}
				if (this.mChar.hp <= 0)
				{
					break;
				}
				if (205343 - 264723 == -59380)
				{
					if (this.mChar.ko > 0)
					{
						break;
					}
					if (195788 - 464660 == -268872)
					{
						if (!(this.mChar.actionState != "ko"))
						{
							break;
						}
						if (100282 - 242571 != -142288)
						{
							if (!(this.mChar.actionState != "dead"))
							{
								break;
							}
							if (8740 - 474189 == -465449)
							{
								if (this.mChar.isMine)
								{
									if (178804 - 124486 != 54319)
									{
										this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
										{
											this.transform.position,
											this.transform.forward
										})));
										if (102278 - 256111 != -153832)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (188636 - 483486 == -294850)
											{
												this.mChar.KoEvent();
												if (149723 - 71845 == 77878)
												{
													break;
												}
											}
										}
									}
								}
								else
								{
									this.mChar.ko = 1;
									if (30799 - 282251 == -251452)
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

	// Token: 0x06004437 RID: 17463 RVA: 0x008930D0 File Offset: 0x008912D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (167209 - 538041 != -370832)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (4236 - 563270 == -559034)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (186442 - 276596 == -90154)
				{
					if (112286 - 22637 != 89650)
					{
						if (ActionName == "RPC_deadwave")
						{
							if (118969 - 412861 == -293891)
							{
								continue;
							}
							v = 1;
							if (67929 - 273173 != -205244)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_deadwave_fire")
						{
							if (245489 - 196026 != 49463)
							{
								continue;
							}
							v = 2;
							if (212780 - 311448 == -98667)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_deadSlam")
						{
							if (165094 - 407560 != -242466)
							{
								continue;
							}
							v = 11;
							if (236198 - 184596 == 51603)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_deadSlam_hit")
						{
							if (270168 - 218381 != 51787)
							{
								continue;
							}
							v = 12;
							if (86666 - 578418 == -491751)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_livingDead_hit")
						{
							if (47580 - 463345 != -415765)
							{
								continue;
							}
							v = -50;
							if (153256 - 286331 == -133074)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (146177 - 461716 == -315538)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (141727 - 529792 == -388065)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (21023 - 562343 == -541320)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (194711 - 119823 != 74889)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (167834 - 43159 == 124675)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (217912 - 321392 == -103480)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (138000 - 192017 == -54017)
											{
												Hashtable hashtable = new Hashtable();
												if (292480 - 358001 == -65521)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (45330 - 275285 == -229955)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (127519 - 146149 != -18629)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (78540 - 389170 == -310630)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (22023 - 288901 != -266877)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (8896 - 181063 == -172167)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (23961 - 397737 != -373775)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (298934 - 297257 == 1677)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (297571 - 437593 != -140021)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (251148 - 154606 != 96543)
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

	// Token: 0x06004438 RID: 17464 RVA: 0x00893634 File Offset: 0x00891834
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (90205 - 61205 != 29000)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (91511 - 478949 == -387438)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (278691 - 51194 != 227498)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (298258 - 363371 != -65112)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (209357 - 202037 != 7321)
						{
							int num2 = num;
							if (18327 - 325781 == -307454)
							{
								if (num2 == 1)
								{
									if (211596 - 393495 != -181898)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (100287 - 374632 == -274345)
										{
											this.StartCoroutine_Auto(this.RPC_deadwave(vector, vector2, tID));
											if (231041 - 115490 != 115552)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 2)
								{
									if (161788 - 270323 != -108534)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (119804 - 355441 != -235636)
										{
											this.RPC_deadwave_fire(vector, vector2, tID);
											if (289102 - 185290 != 103813)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 11)
								{
									if (50737 - 167459 == -116722)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (110511 - 93887 != 16625)
										{
											this.StartCoroutine_Auto(this.RPC_deadSlam(vector, vector2, tID));
											if (215143 - 312917 == -97774)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 12)
								{
									if (244498 - 489857 == -245359)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (13518 - 451276 != -437757)
										{
											this.RPC_deadSlam_hit(vector, vector2, tID);
											if (110514 - 67953 != 42562)
											{
												break;
											}
										}
									}
								}
								else if (num2 == -50)
								{
									if (236624 - 538516 == -301892)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (90864 - 520479 != -429614)
										{
											this.RPC_livingDead_hit(vector, vector2, tID);
											if (93149 - 183829 != -90679)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (129829 - 461228 != -331398)
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

	// Token: 0x06004439 RID: 17465 RVA: 0x00893A30 File Offset: 0x00891C30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (211116 - 99999 != 111117)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (29746 - 348271 == -318525)
			{
				float runSpeed = this.mChar.runSpeed;
				if (241083 - 460001 == -218918)
				{
					Vector3 a = default(Vector3);
					if (54518 - 108737 == -54219)
					{
						Vector3 vector = Vector3.zero;
						if (72085 - 142071 == -69986)
						{
							float num2 = (float)0;
							if (172606 - 424420 != -251813)
							{
								if (this.mChar.isMine)
								{
									if (179290 - 221263 == -41972)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (209957 - 520797 == -310839)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (87674 - 426872 != -339198)
										{
											continue;
										}
										a.y = (float)0;
										if (139581 - 432881 != -293300)
										{
											continue;
										}
										a = a.normalized;
										if (142973 - 555763 == -412789)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (68539 - 168726 != -100187)
										{
											continue;
										}
										vector = vector.normalized;
										if (161028 - 198155 != -37127)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (130114 - 409842 != -279728)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (222164 - 344447 != -122283)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (184043 - 305404 != -121361)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (277280 - 59512 != 217768)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (98657 - 222716 != -124059)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (219538 - 259551 == -40012)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (195524 - 401364 == -205839)
														{
															continue;
														}
														this.animation.Play("run");
														if (96727 - 120918 == -24190)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (177019 - 352051 != -175031)
														{
															goto IL_B9;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (179351 - 292994 == -113642)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (45679 - 528757 == -483077)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (62980 - 461113 != -398133)
											{
												continue;
											}
											num = (float)0;
											if (46906 - 559688 != -512782)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (92609 - 188789 != -96180)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (50986 - 193623 != -142637)
										{
											continue;
										}
									}
									IL_B9:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (287989 - 484525 == -196535)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (195505 - 195449 == 57)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (8890 - 14841 == -5950)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (221539 - 23856 == 197684)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (82933 - 362145 != -279212)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (170116 - 595814 != -425698)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (95093 - 348884 == -253790)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (232668 - 439399 != -206731)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (74544 - 378127 != -303583)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (291573 - 88378 != 203195)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (147946 - 596529 == -448582)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (34095 - 374404 == -340308)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (233248 - 56819 == 176430)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (61427 - 441320 == -379892)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (284962 - 373228 == -88265)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (131772 - 514471 == -382698)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (94679 - 414533 != -319854)
												{
													continue;
												}
												num = (float)0;
												if (233625 - 450281 == -216655)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (204435 - 322072 != -117637)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (282955 - 455773 != -172818)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (165606 - 521582 == -355975)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (8641 - 3783 != 4858)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (72712 - 460218 != -387506)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (61614 - 247470 == -185855)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (87366 - 526047 == -438680)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (77266 - 239778 == -162511)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (178582 - 376559 == -197976)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (162472 - 28606 != 133866)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (177427 - 131573 != 45854)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (235063 - 229900 != 5163)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (117034 - 59986 == 57049)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (110501 - 469361 != -358860)
											{
												continue;
											}
											num = (float)0;
											if (258471 - 507450 == -248978)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (45815 - 311494 == -265678)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (171734 - 265525 == -93790)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (210062 - 298696 != -88634)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (27687 - 383035 == -355347)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (180220 - 324091 != -143870)
								{
									this.mChar.moveSpeed = num;
									if (198100 - 296458 != -98357)
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

	// Token: 0x0600443A RID: 17466 RVA: 0x00894594 File Offset: 0x00892794
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (62220 - 134769 != -72549)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (87097 - 442318 == -355221)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (184487 - 150865 == 33622)
				{
					Vector3 vector = a - this.transform.position;
					if (212928 - 206680 != 6249)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (287180 - 506188 == -219008)
						{
							CharacterControl characterControl = null;
							if (235392 - 152513 == 82879)
							{
								if (110639 - 236876 != -126236)
								{
									if (gameObject)
									{
										if (170330 - 308341 != -138011)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (285150 - 397748 == -112597)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (117500 - 129693 == -12192)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (206462 - 577420 == -370957)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (245660 - 46361 == 199300)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (19759 - 473761 == -454001)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("deadwave") != (float)0)
									{
										break;
									}
									if (241048 - 147581 == 93467)
									{
										this.StartCoroutine_Auto(this.RPC_deadwave(this.transform.position, vector, 0));
										if (287252 - 427832 == -140580)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (34058 - 45898 != -11839)
											{
												this.ActionEvent("RPC_deadwave", this.transform.position, vector, 0);
												if (112307 - 457004 == -344697)
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

	// Token: 0x0600443B RID: 17467 RVA: 0x0089488C File Offset: 0x00892A8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (286814 - 19031 != 267783)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (72572 - 122047 == -49475)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (295583 - 403642 == -108059)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (134752 - 202191 != -67438)
					{
						Vector3 normalized = vector.normalized;
						if (234270 - 218458 != 15813)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (121406 - 547328 != -425921)
							{
								CharacterControl characterControl = null;
								if (103840 - 570530 != -466689 && 294161 - 153043 != 141119)
								{
									if (gameObject)
									{
										if (228292 - 69128 != 159164)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (29303 - 377429 == -348125)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (160296 - 361297 == -201000)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (256321 - 59475 == 196847)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (18964 - 59124 != -40160)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (260173 - 432455 == -172281)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("cAttack") != (float)0)
									{
										break;
									}
									if (25353 - 497255 != -471901)
									{
										this.StartCoroutine_Auto(this.RPC_deadSlam(this.transform.position, normalized, 0));
										if (87169 - 177210 != -90040)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (155153 - 517293 == -362140)
											{
												this.ActionEvent("RPC_deadSlam", this.transform.position, normalized, 0);
												if (20591 - 432453 != -411861)
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

	// Token: 0x0600443C RID: 17468 RVA: 0x00894BAC File Offset: 0x00892DAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x0600443D RID: 17469 RVA: 0x00894BB0 File Offset: 0x00892DB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_deadwave(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Deadbull.$RPC_deadwave$31746(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600443E RID: 17470 RVA: 0x00894BC0 File Offset: 0x00892DC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_deadwave_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (64502 - 70544 != -6041)
		{
		}
		for (;;)
		{
			if (this.deadWave)
			{
				if (61381 - 197591 != -136209)
				{
					Quaternion rotation = Quaternion.LookRotation(fireDir);
					if (260168 - 532260 == -272092)
					{
						GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.deadWave, firePos, rotation);
						if (149933 - 421981 == -272048)
						{
							ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
							if (262546 - 46880 == 215666)
							{
								projectileControl.Init(this.mChar.ActorNr);
								if (28057 - 393693 == -365636)
								{
									projectileControl.life = (float)2;
									if (56399 - 407353 == -350954)
									{
										Deadbull_deadwave deadbull_deadwave = (Deadbull_deadwave)gameObject.GetComponent(typeof(Deadbull_deadwave));
										if (81310 - 262752 == -181442)
										{
											deadbull_deadwave.Init(this.gameObject);
											if (288899 - 377943 == -89044)
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
			else
			{
				Debug.LogError("Cannot find deadWave Effect");
				if (298706 - 146286 != 152421)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600443F RID: 17471 RVA: 0x00894D6C File Offset: 0x00892F6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_deadSlam(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Deadbull.$RPC_deadSlam$31753(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004440 RID: 17472 RVA: 0x00894D7C File Offset: 0x00892F7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_deadSlam_hit(Vector3 hitPos, Vector3 hitDir, int tID)
	{
		if (104480 - 113623 != -9143)
		{
		}
		for (;;)
		{
			if (this.deadSlam_hit)
			{
				if (29576 - 4225 == 25351)
				{
					UnityEngine.Object.Instantiate(this.deadSlam_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (143919 - 326108 == -182189)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find deadSlam_hit effect");
				if (267148 - 538203 == -271055)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004441 RID: 17473 RVA: 0x00894E34 File Offset: 0x00893034
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_livingDead_hit(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (221071 - 19504 != 201567)
		{
		}
		for (;;)
		{
			if (this.livingDead_hit)
			{
				if (91531 - 518890 == -427359)
				{
					this.mChar.createEffect(this.livingDead_hit, this.transform.position + (float)3 * Vector3.up, this.transform.rotation);
					if (36586 - 323489 != -286902)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Warning cannot find livingDead_hit effect");
				if (201368 - 280851 != -79482)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004442 RID: 17474 RVA: 0x00894F14 File Offset: 0x00893114
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Deadbull.$RPC_ko$31766(nArray, this).GetEnumerator();
	}

	// Token: 0x06004443 RID: 17475 RVA: 0x00894F24 File Offset: 0x00893124
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Deadbull.$RPC_dead$31773(nArray, this).GetEnumerator();
	}

	// Token: 0x06004444 RID: 17476 RVA: 0x00894F34 File Offset: 0x00893134
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004445 RID: 17477 RVA: 0x00894F38 File Offset: 0x00893138
	internal static bool CRxN9b56gRdoTElB6t25()
	{
		return true;
	}

	// Token: 0x06004446 RID: 17478 RVA: 0x00894F3C File Offset: 0x0089313C
	internal static bool fpTlpD56fvA7fknJIlWK()
	{
		return false;
	}

	// Token: 0x04004FF9 RID: 20473
	public CharacterControl mChar;

	// Token: 0x04004FFA RID: 20474
	public GameObject deadWave;

	// Token: 0x04004FFB RID: 20475
	public GameObject deadSlam_hit;

	// Token: 0x04004FFC RID: 20476
	public GameObject livingDead_hit;

	// Token: 0x02000BF0 RID: 3056
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_deadwave$31746 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004447 RID: 17479 RVA: 0x00894F40 File Offset: 0x00893140
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_deadwave$31746(Vector3 mPos, Vector3 tDir, Deadbull self_)
		{
			if (189841 - 395157 != -205315)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (293482 - 392835 == -99353)
				{
					base..ctor();
					if (126979 - 48899 == 78080)
					{
						this.$mPos$31750 = mPos;
						if (21482 - 393428 != -371945)
						{
							this.$tDir$31751 = tDir;
							if (186768 - 101698 != 85071)
							{
								this.$self_$31752 = self_;
								if (85487 - 502162 != -416674)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004448 RID: 17480 RVA: 0x0089501C File Offset: 0x0089321C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Deadbull.$RPC_deadwave$31746.$(this.$mPos$31750, this.$tDir$31751, this.$self_$31752);
		}

		// Token: 0x06004449 RID: 17481 RVA: 0x00895038 File Offset: 0x00893238
		internal static bool vHDYa556nFognvS6XTHY()
		{
			return true;
		}

		// Token: 0x0600444A RID: 17482 RVA: 0x0089503C File Offset: 0x0089323C
		internal static bool e6LYgQ566Rsds97UtFRV()
		{
			return false;
		}

		// Token: 0x04004FFD RID: 20477
		internal Vector3 $mPos$31750;

		// Token: 0x04004FFE RID: 20478
		internal Vector3 $tDir$31751;

		// Token: 0x04004FFF RID: 20479
		internal Deadbull $self_$31752;

		// Token: 0x02000BF1 RID: 3057
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600444B RID: 17483 RVA: 0x00895040 File Offset: 0x00893240
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Deadbull self_)
			{
				if (291488 - 168062 != 123426)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (284973 - 562377 == -277404)
					{
						base..ctor();
						if (104524 - 452473 != -347948)
						{
							this.$mPos$31747 = mPos;
							if (14429 - 513726 == -499297)
							{
								this.$tDir$31748 = tDir;
								if (24435 - 359347 != -334911)
								{
									this.$self_$31749 = self_;
									if (263105 - 137925 == 125180)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600444C RID: 17484 RVA: 0x0089511C File Offset: 0x0089331C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (31110 - 72727 != -41616)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_868;
					case 2:
						if (this.$self_$31749.mChar.actionState != "attack")
						{
							if (185374 - 372995 != -187621)
							{
								continue;
							}
							if (this.$self_$31749.mChar.myCommand != "deadwave")
							{
								if (40518 - 453915 != -413397)
								{
									continue;
								}
								goto IL_B8;
							}
						}
						this.$self_$31749.mChar.moveSpeed = (float)1;
						if (23729 - 406891 == -383161)
						{
							continue;
						}
						if (!this.$self_$31749.mChar.isMine)
						{
							goto IL_E9;
						}
						if (95244 - 437625 == -342380)
						{
							continue;
						}
						this.$self_$31749.RPC_deadwave_fire(this.$self_$31749.transform.position + this.$self_$31749.transform.TransformDirection(-1.5f, 0.2f, 0.5f), this.$self_$31749.transform.forward, 0);
						if (255905 - 433776 != -177871)
						{
							continue;
						}
						this.$self_$31749.ActionEvent("RPC_deadwave_fire", this.$self_$31749.transform.position + this.$self_$31749.transform.TransformDirection(-1.5f, 0.2f, 0.5f), this.$self_$31749.transform.forward, 0);
						if (17018 - 110693 != -93675)
						{
							continue;
						}
						goto IL_E9;
					case 3:
						if (this.$self_$31749.mChar.actionState != "attack")
						{
							if (234334 - 537274 == -302939)
							{
								continue;
							}
							if (this.$self_$31749.mChar.myCommand != "deadwave")
							{
								if (109812 - 75496 != 34317)
								{
									goto Block_46;
								}
								continue;
							}
						}
						if (!this.$self_$31749.mChar.isMine)
						{
							goto IL_1F4;
						}
						if (117473 - 374796 == -257322)
						{
							continue;
						}
						this.$self_$31749.RPC_deadwave_fire(this.$self_$31749.transform.position + this.$self_$31749.transform.TransformDirection(1.5f, 0.2f, 0.5f), this.$self_$31749.transform.forward, 0);
						if (118316 - 574962 == -456645)
						{
							continue;
						}
						this.$self_$31749.ActionEvent("RPC_deadwave_fire", this.$self_$31749.transform.position + this.$self_$31749.transform.TransformDirection(1.5f, 0.2f, 0.5f), this.$self_$31749.transform.forward, 0);
						if (287589 - 88664 != 198926)
						{
							goto Block_41;
						}
						continue;
					case 4:
						if (this.$self_$31749.mChar.actionState != "attack")
						{
							if (237627 - 282235 == -44607)
							{
								continue;
							}
							if (this.$self_$31749.mChar.myCommand != "deadwave")
							{
								if (61411 - 475616 != -414205)
								{
									continue;
								}
								goto IL_1A1;
							}
						}
						this.$self_$31749.mChar.moveSpeed = (float)0;
						if (131016 - 243681 != -112665)
						{
							continue;
						}
						goto IL_747;
					case 5:
						if (this.$self_$31749.mChar.actionState == "attack")
						{
							if (240804 - 461470 != -220666)
							{
								continue;
							}
							if (this.$self_$31749.mChar.myCommand == "deadwave")
							{
								if (232359 - 558647 == -326287)
								{
									continue;
								}
								this.$self_$31749.mChar.actionState = "standby";
								if (236121 - 118782 == 117340)
								{
									continue;
								}
								this.$self_$31749.mChar.actionTime = Time.time;
								if (23089 - 126853 == -103763)
								{
									continue;
								}
								this.$self_$31749.mChar.myCommand = "none";
								if (12061 - 434341 == -422279)
								{
									continue;
								}
								if (!this.$self_$31749.mChar.isMine)
								{
									if (22034 - 186547 == -164512)
									{
										continue;
									}
									this.$self_$31749.mChar.nPosition = this.$self_$31749.transform.position;
									if (83137 - 149826 == -66688)
									{
										continue;
									}
									this.$self_$31749.mChar.oPosition = this.$self_$31749.transform.position;
									if (238260 - 2003 != 236257)
									{
										continue;
									}
									this.$self_$31749.mChar.nDirection = this.$self_$31749.transform.forward;
									if (246046 - 366991 == -120944)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (169600 - 553744 != -384143)
						{
							goto Block_11;
						}
						continue;
					default:
						if (88704 - 113583 == -24878)
						{
							continue;
						}
						break;
					}
					this.$self_$31749.mChar.actionState = "attack";
					if (44418 - 528204 != -483785)
					{
						this.$self_$31749.mChar.actionTime = Time.time;
						if (194389 - 439867 != -245477)
						{
							this.$self_$31749.mChar.myCommand = "deadwave";
							if (38888 - 308981 == -270093)
							{
								this.$self_$31749.mChar.addTimeOut("nAttack", (float)4);
								if (16086 - 205324 != -189237)
								{
									this.$self_$31749.transform.position = this.$mPos$31747;
									if (171852 - 186336 != -14483)
									{
										this.$self_$31749.transform.LookAt(this.$mPos$31747 + global::Math.vFlat(this.$tDir$31748));
										if (298653 - 158891 == 139762)
										{
											this.$self_$31749.animation.CrossFade("nAttack");
											if (46986 - 56707 != -9720)
											{
												this.$self_$31749.animation.wrapMode = WrapMode.Once;
												if (214097 - 220065 != -5967)
												{
													this.$self_$31749.mChar.vMovement = this.$self_$31749.transform.forward;
													if (284652 - 505070 == -220418)
													{
														this.$self_$31749.mChar.moveSpeed = (float)0;
														if (134391 - 438734 == -304343)
														{
															goto IL_689;
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
				IL_B8:
				goto IL_868;
				IL_E9:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_1A1:
				Block_11:
				goto IL_868;
				IL_1F4:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_689:
				return this.Yield(2, new WaitForSeconds(0.6f));
				Block_41:
				goto IL_1F4;
				IL_747:
				return this.Yield(5, new WaitForSeconds(0.2f));
				Block_46:
				IL_868:
				return false;
			}

			// Token: 0x0600444D RID: 17485 RVA: 0x008959A4 File Offset: 0x00893BA4
			internal static bool Ng0Jua56iNIH4BpktJid()
			{
				return true;
			}

			// Token: 0x0600444E RID: 17486 RVA: 0x008959A8 File Offset: 0x00893BA8
			internal static bool g6PaFZ56KwYJvIsd8PxF()
			{
				return false;
			}

			// Token: 0x04005000 RID: 20480
			internal Vector3 $mPos$31747;

			// Token: 0x04005001 RID: 20481
			internal Vector3 $tDir$31748;

			// Token: 0x04005002 RID: 20482
			internal Deadbull $self_$31749;
		}
	}

	// Token: 0x02000BF2 RID: 3058
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_deadSlam$31753 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600444F RID: 17487 RVA: 0x008959AC File Offset: 0x00893BAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_deadSlam$31753(Vector3 mPos, Vector3 tDir, Deadbull self_)
		{
			if (159046 - 381694 != -222647)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (246810 - 354929 == -108119)
				{
					base..ctor();
					if (37845 - 54862 == -17017)
					{
						this.$mPos$31763 = mPos;
						if (37492 - 234505 == -197013)
						{
							this.$tDir$31764 = tDir;
							if (191890 - 183413 != 8478)
							{
								this.$self_$31765 = self_;
								if (285853 - 393980 != -108126)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004450 RID: 17488 RVA: 0x00895A88 File Offset: 0x00893C88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Deadbull.$RPC_deadSlam$31753.$(this.$mPos$31763, this.$tDir$31764, this.$self_$31765);
		}

		// Token: 0x06004451 RID: 17489 RVA: 0x00895AA4 File Offset: 0x00893CA4
		internal static bool JOEFcX56do1dSMtuJtho()
		{
			return true;
		}

		// Token: 0x06004452 RID: 17490 RVA: 0x00895AA8 File Offset: 0x00893CA8
		internal static bool ls28cC56JjkBdvtscsA9()
		{
			return false;
		}

		// Token: 0x04005003 RID: 20483
		internal Vector3 $mPos$31763;

		// Token: 0x04005004 RID: 20484
		internal Vector3 $tDir$31764;

		// Token: 0x04005005 RID: 20485
		internal Deadbull $self_$31765;

		// Token: 0x02000BF3 RID: 3059
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004453 RID: 17491 RVA: 0x00895AAC File Offset: 0x00893CAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Deadbull self_)
			{
				if (214452 - 79526 != 134927)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (26166 - 220962 != -194795)
					{
						base..ctor();
						if (240010 - 288554 != -48543)
						{
							this.$mPos$31760 = mPos;
							if (115128 - 501815 != -386686)
							{
								this.$tDir$31761 = tDir;
								if (66113 - 401410 != -335296)
								{
									this.$self_$31762 = self_;
									if (7190 - 249870 == -242680)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004454 RID: 17492 RVA: 0x00895B88 File Offset: 0x00893D88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (15335 - 307080 != -291745)
				{
				}
				for (;;)
				{
					IL_273:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_968;
					case 2:
						if (this.$self_$31762.mChar.actionState != "attack")
						{
							if (33350 - 288686 == -255335)
							{
								continue;
							}
							if (this.$self_$31762.mChar.myCommand != "deadSlam")
							{
								if (43292 - 343879 != -300586)
								{
									goto Block_12;
								}
								continue;
							}
						}
						this.$self_$31762.mChar.moveSpeed = (float)4;
						if (161391 - 89270 != 72121)
						{
							continue;
						}
						this.$i$31754 = 0;
						if (164057 - 464571 != -300513)
						{
							goto IL_159;
						}
						continue;
					case 3:
						if (this.$self_$31762.mChar.actionState != "attack")
						{
							if (174653 - 547352 == -372698)
							{
								continue;
							}
							if (this.$self_$31762.mChar.myCommand != "deadSlam")
							{
								if (73568 - 539870 != -466302)
								{
									continue;
								}
								goto IL_9D;
							}
						}
						this.$self_$31762.mChar.moveSpeed = (float)6;
						if (129344 - 252635 == -123290)
						{
							continue;
						}
						if (this.$self_$31762.mChar.isMine)
						{
							if (100440 - 467397 == -366956)
							{
								continue;
							}
							this.$hitLayer$31755 = 130816 - (1 << this.$self_$31762.gameObject.layer);
							if (278177 - 44406 != 233771)
							{
								continue;
							}
							this.$hitList$31756 = Damage.FindRecTarget(this.$self_$31762.transform.position, this.$self_$31762.transform.forward, (float)2, (float)2, (float)2, (float)2, this.$hitLayer$31755);
							if (162896 - 226294 != -63398)
							{
								continue;
							}
							this.$$iterator$10717$31759 = UnityRuntimeServices.GetEnumerator(this.$hitList$31756);
							if (258812 - 222136 != 36676)
							{
								continue;
							}
							while (this.$$iterator$10717$31759.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10717$31759.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$31757 = (GameObject)obj2;
								if (271093 - 545180 == -274086)
								{
									goto IL_273;
								}
								if (this.$self_$31762.mChar.hit(11, this.$hitObject$31757, (int)(0.5f * (float)this.$self_$31762.mChar.atk), 3, 0, 0.5f * this.$self_$31762.transform.forward) != 0)
								{
									if (168250 - 456955 != -288705)
									{
										goto IL_273;
									}
									this.$hitPos$31758 = this.$hitObject$31757.collider.ClosestPointOnBounds(this.$self_$31762.transform.position + 1.7f * Vector3.up);
									if (196288 - 445624 != -249336)
									{
										goto IL_273;
									}
									UnityRuntimeServices.Update(this.$$iterator$10717$31759, this.$hitObject$31757);
									if (153755 - 512090 != -358335)
									{
										goto IL_273;
									}
									this.$self_$31762.RPC_deadSlam_hit(this.$hitPos$31758, this.$self_$31762.transform.forward, 0);
									if (253454 - 585497 == -332042)
									{
										goto IL_273;
									}
									this.$self_$31762.ActionEvent("RPC_deadSlam_hit", this.$hitPos$31758, this.$self_$31762.transform.forward, 0);
									if (190151 - 137482 != 52669)
									{
										goto IL_273;
									}
									this.$self_$31762.mChar.sp = this.$self_$31762.mChar.sp + 1;
									if (184590 - 87552 != 97038)
									{
										goto IL_273;
									}
								}
							}
							if (284301 - 182640 == 101662)
							{
								continue;
							}
						}
						this.$i$31754++;
						if (158316 - 377920 != -219604)
						{
							continue;
						}
						goto IL_159;
					case 4:
						if (this.$self_$31762.mChar.actionState == "attack")
						{
							if (242253 - 48965 != 193288)
							{
								continue;
							}
							if (this.$self_$31762.mChar.myCommand == "deadSlam")
							{
								if (18087 - 19929 != -1842)
								{
									continue;
								}
								this.$self_$31762.mChar.actionState = "standby";
								if (63383 - 156209 == -92825)
								{
									continue;
								}
								this.$self_$31762.mChar.actionTime = Time.time;
								if (31050 - 374309 == -343258)
								{
									continue;
								}
								this.$self_$31762.mChar.myCommand = "none";
								if (22276 - 565584 != -543308)
								{
									continue;
								}
								if (!this.$self_$31762.mChar.isMine)
								{
									if (120056 - 239474 != -119418)
									{
										continue;
									}
									this.$self_$31762.mChar.nPosition = this.$self_$31762.transform.position;
									if (224646 - 183247 == 41400)
									{
										continue;
									}
									this.$self_$31762.mChar.oPosition = this.$self_$31762.transform.position;
									if (4298 - 102108 == -97809)
									{
										continue;
									}
									this.$self_$31762.mChar.nDirection = this.$self_$31762.transform.forward;
									if (285340 - 397930 == -112589)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (67838 - 90537 != -22698)
						{
							goto Block_18;
						}
						continue;
					default:
						if (200160 - 20255 == 179906)
						{
							continue;
						}
						break;
					}
					this.$self_$31762.mChar.actionState = "attack";
					if (211059 - 266141 != -55082)
					{
						continue;
					}
					this.$self_$31762.mChar.actionTime = Time.time;
					if (109278 - 141110 == -31831)
					{
						continue;
					}
					this.$self_$31762.mChar.myCommand = "deadSlam";
					if (279185 - 413217 == -134031)
					{
						continue;
					}
					this.$self_$31762.mChar.addTimeOut("cAttack", (float)4);
					if (249618 - 493364 == -243745)
					{
						continue;
					}
					this.$self_$31762.transform.position = this.$mPos$31760;
					if (205250 - 252868 == -47617)
					{
						continue;
					}
					this.$self_$31762.transform.LookAt(this.$mPos$31760 + global::Math.vFlat(this.$tDir$31761));
					if (9845 - 324368 != -314523)
					{
						continue;
					}
					this.$self_$31762.animation.CrossFade("deadSlam");
					if (161408 - 422298 != -260890)
					{
						continue;
					}
					this.$self_$31762.animation.wrapMode = WrapMode.Once;
					if (285226 - 365025 == -79798)
					{
						continue;
					}
					this.$self_$31762.mChar.vMovement = this.$self_$31762.transform.forward;
					if (128129 - 438573 == -310443)
					{
						continue;
					}
					this.$self_$31762.mChar.moveSpeed = (float)0;
					if (209301 - 254409 != -45108)
					{
						continue;
					}
					goto IL_5D4;
					IL_159:
					if (this.$i$31754 < 4)
					{
						goto IL_224;
					}
					if (9087 - 164625 == -155538)
					{
						this.$self_$31762.mChar.moveSpeed = (float)0;
						if (99984 - 212004 != -112019)
						{
							goto Block_43;
						}
					}
				}
				IL_9D:
				Block_12:
				goto IL_968;
				IL_224:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_18:
				goto IL_968;
				IL_5D4:
				return this.Yield(2, new WaitForSeconds(0.3f));
				Block_43:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_968:
				return false;
			}

			// Token: 0x06004455 RID: 17493 RVA: 0x00896510 File Offset: 0x00894710
			internal static bool kZTTtX56Db7ZVfjIFYDR()
			{
				return true;
			}

			// Token: 0x06004456 RID: 17494 RVA: 0x00896514 File Offset: 0x00894714
			internal static bool UvAux956vojDErZtLwKD()
			{
				return false;
			}

			// Token: 0x04005006 RID: 20486
			internal int $i$31754;

			// Token: 0x04005007 RID: 20487
			internal int $hitLayer$31755;

			// Token: 0x04005008 RID: 20488
			internal UnityScript.Lang.Array $hitList$31756;

			// Token: 0x04005009 RID: 20489
			internal GameObject $hitObject$31757;

			// Token: 0x0400500A RID: 20490
			internal Vector3 $hitPos$31758;

			// Token: 0x0400500B RID: 20491
			internal IEnumerator $$iterator$10717$31759;

			// Token: 0x0400500C RID: 20492
			internal Vector3 $mPos$31760;

			// Token: 0x0400500D RID: 20493
			internal Vector3 $tDir$31761;

			// Token: 0x0400500E RID: 20494
			internal Deadbull $self_$31762;
		}
	}

	// Token: 0x02000BF4 RID: 3060
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$31766 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004457 RID: 17495 RVA: 0x00896518 File Offset: 0x00894718
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$31766(UnityScript.Lang.Array nArray, Deadbull self_)
		{
			if (178106 - 155025 != 23082)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (44837 - 189153 == -144316)
				{
					base..ctor();
					if (80512 - 272678 != -192165)
					{
						this.$nArray$31771 = nArray;
						if (138302 - 341828 == -203526)
						{
							this.$self_$31772 = self_;
							if (86990 - 60102 != 26889)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004458 RID: 17496 RVA: 0x008965D4 File Offset: 0x008947D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Deadbull.$RPC_ko$31766.$(this.$nArray$31771, this.$self_$31772);
		}

		// Token: 0x06004459 RID: 17497 RVA: 0x008965E8 File Offset: 0x008947E8
		internal static bool Q3h60r56RJfDSYHLEmCY()
		{
			return true;
		}

		// Token: 0x0600445A RID: 17498 RVA: 0x008965EC File Offset: 0x008947EC
		internal static bool U7dkgU56wK3k4rEiejao()
		{
			return false;
		}

		// Token: 0x0400500F RID: 20495
		internal UnityScript.Lang.Array $nArray$31771;

		// Token: 0x04005010 RID: 20496
		internal Deadbull $self_$31772;

		// Token: 0x02000BF5 RID: 3061
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600445B RID: 17499 RVA: 0x008965F0 File Offset: 0x008947F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Deadbull self_)
			{
				if (47140 - 121118 != -73977)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (84858 - 408191 == -323333)
					{
						base..ctor();
						if (53468 - 94689 == -41221)
						{
							this.$nArray$31769 = nArray;
							if (272022 - 464362 == -192340)
							{
								this.$self_$31770 = self_;
								if (135989 - 371139 == -235150)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600445C RID: 17500 RVA: 0x008966AC File Offset: 0x008948AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (154437 - 512242 != -357804)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_48C;
					case 2:
						if (this.$self_$31770.mChar.actionState != "ko")
						{
							if (35318 - 188556 != -153237)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							this.$self_$31770.animation.Play("getUp");
							if (71263 - 131322 == -60058)
							{
								continue;
							}
							this.$self_$31770.animation.wrapMode = WrapMode.Once;
							if (49769 - 247038 != -197269)
							{
								continue;
							}
							goto IL_EC;
						}
						break;
					case 3:
						if (this.$self_$31770.mChar.actionState != "ko")
						{
							if (260117 - 124258 != 135860)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							this.$self_$31770.mChar.actionState = "standby";
							if (16802 - 259822 == -243019)
							{
								continue;
							}
							this.$self_$31770.mChar.actionTime = Time.time;
							if (28191 - 381537 == -353345)
							{
								continue;
							}
							this.$self_$31770.mChar.myCommand = "none";
							if (289590 - 366822 == -77231)
							{
								continue;
							}
							this.$self_$31770.mChar.ko = this.$self_$31770.mChar.mko;
							if (209099 - 423194 == -214094)
							{
								continue;
							}
							this.YieldDefault(1);
							if (92360 - 319325 != -226964)
							{
								goto Block_9;
							}
							continue;
						}
						break;
					default:
						if (211304 - 295184 == -83879)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31770.mChar.actionState == "ko")
					{
						break;
					}
					if (104609 - 255290 == -150681)
					{
						if (this.$self_$31770.mChar.actionState == "dead")
						{
							if (67302 - 156880 == -89578)
							{
								break;
							}
						}
						else
						{
							this.$mPos$31767 = (Vector3)this.$nArray$31769[0];
							if (29416 - 197562 != -168145)
							{
								this.$mDir$31768 = (Vector3)this.$nArray$31769[1];
								if (60503 - 587346 != -526842)
								{
									this.$self_$31770.mChar.ko = 0;
									if (95288 - 251526 == -156238)
									{
										this.$self_$31770.mChar.actionState = "ko";
										if (103144 - 322983 != -219838)
										{
											this.$self_$31770.mChar.actionTime = Time.time;
											if (160103 - 570605 != -410501)
											{
												this.$self_$31770.mChar.myCommand = "none";
												if (91026 - 144834 != -53807)
												{
													this.$self_$31770.mChar.vMovement = Vector3.zero;
													if (185318 - 422966 != -237647)
													{
														this.$self_$31770.mChar.moveSpeed = (float)0;
														if (21083 - 351215 == -330132)
														{
															this.$self_$31770.animation.Play("ko");
															if (156144 - 288403 == -132259)
															{
																this.$self_$31770.animation.wrapMode = WrapMode.Once;
																if (81451 - 115212 != -33760)
																{
																	goto Block_17;
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
				goto IL_48C;
				IL_EC:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_8:
				Block_9:
				goto IL_48C;
				Block_17:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_23:
				IL_48C:
				return false;
			}

			// Token: 0x0600445D RID: 17501 RVA: 0x00896B58 File Offset: 0x00894D58
			internal static bool fjydFT56qeFs3LgMruJH()
			{
				return true;
			}

			// Token: 0x0600445E RID: 17502 RVA: 0x00896B5C File Offset: 0x00894D5C
			internal static bool ulg2rP567cqXZPymM4Qs()
			{
				return false;
			}

			// Token: 0x04005011 RID: 20497
			internal Vector3 $mPos$31767;

			// Token: 0x04005012 RID: 20498
			internal Vector3 $mDir$31768;

			// Token: 0x04005013 RID: 20499
			internal UnityScript.Lang.Array $nArray$31769;

			// Token: 0x04005014 RID: 20500
			internal Deadbull $self_$31770;
		}
	}

	// Token: 0x02000BF6 RID: 3062
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$31773 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600445F RID: 17503 RVA: 0x00896B60 File Offset: 0x00894D60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$31773(UnityScript.Lang.Array nArray, Deadbull self_)
		{
			if (274443 - 93398 != 181046)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (36634 - 290968 == -254334)
				{
					base..ctor();
					if (84970 - 152644 == -67674)
					{
						this.$nArray$31778 = nArray;
						if (162128 - 495701 != -333572)
						{
							this.$self_$31779 = self_;
							if (125559 - 103220 == 22339)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004460 RID: 17504 RVA: 0x00896C1C File Offset: 0x00894E1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Deadbull.$RPC_dead$31773.$(this.$nArray$31778, this.$self_$31779);
		}

		// Token: 0x06004461 RID: 17505 RVA: 0x00896C30 File Offset: 0x00894E30
		internal static bool UQNFMW56P4pJUlVYMxiC()
		{
			return true;
		}

		// Token: 0x06004462 RID: 17506 RVA: 0x00896C34 File Offset: 0x00894E34
		internal static bool Jckxt1560Hi1IVbZ5emZ()
		{
			return false;
		}

		// Token: 0x04005015 RID: 20501
		internal UnityScript.Lang.Array $nArray$31778;

		// Token: 0x04005016 RID: 20502
		internal Deadbull $self_$31779;

		// Token: 0x02000BF7 RID: 3063
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004463 RID: 17507 RVA: 0x00896C38 File Offset: 0x00894E38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Deadbull self_)
			{
				if (228256 - 544706 != -316450)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (247192 - 99444 == 147748)
					{
						base..ctor();
						if (11664 - 212802 == -201138)
						{
							this.$nArray$31776 = nArray;
							if (231813 - 255584 != -23770)
							{
								this.$self_$31777 = self_;
								if (149312 - 132117 != 17196)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004464 RID: 17508 RVA: 0x00896CF4 File Offset: 0x00894EF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (84548 - 19373 != 65176)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_42F;
					case 2:
						if (this.$self_$31777.mChar.actionState != "dead")
						{
							if (173169 - 53476 != 119693)
							{
								continue;
							}
							goto IL_356;
						}
						else
						{
							if (!this.$self_$31777.mChar.isPlayer)
							{
								if (280697 - 188702 == 91996)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$31777.gameObject);
								if (35741 - 475549 != -439808)
								{
									continue;
								}
							}
							else if (this.$self_$31777.mChar.isMine)
							{
								if (33500 - 592561 != -559061)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$31777.gameObject);
								if (235891 - 242094 == -6202)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (52936 - 449697 != -396760)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					default:
						if (109779 - 139975 != -30196)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31777.mChar.actionState == "dead")
					{
						if (245014 - 525222 != -280207)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$31774 = (Vector3)this.$nArray$31776[0];
						if (55840 - 220580 != -164739)
						{
							this.$myDirection$31775 = (Vector3)this.$nArray$31776[1];
							if (170931 - 329434 != -158502)
							{
								this.$self_$31777.transform.position = this.$myPosition$31774;
								if (179713 - 553422 != -373708)
								{
									this.$self_$31777.transform.LookAt(this.$myPosition$31774 + this.$myDirection$31775);
									if (51632 - 233193 != -181560)
									{
										this.$self_$31777.mChar.hp = 0;
										if (280987 - 438951 == -157964)
										{
											this.$self_$31777.mChar.actionState = "dead";
											if (216160 - 231719 != -15558)
											{
												this.$self_$31777.mChar.actionTime = Time.time;
												if (207699 - 378030 == -170331)
												{
													this.$self_$31777.mChar.myCommand = "none";
													if (123563 - 143571 != -20007)
													{
														this.$self_$31777.mChar.vMovement = Vector3.zero;
														if (127546 - 305978 == -178432)
														{
															this.$self_$31777.mChar.moveSpeed = (float)0;
															if (241639 - 49686 == 191953)
															{
																this.$self_$31777.animation.Rewind();
																if (7509 - 220632 == -213123)
																{
																	this.$self_$31777.animation.Play("ko");
																	if (219631 - 596956 == -377325)
																	{
																		this.$self_$31777.animation.wrapMode = WrapMode.Once;
																		if (27183 - 578523 == -551340)
																		{
																			goto IL_3E0;
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
				Block_14:
				IL_356:
				goto IL_42F;
				IL_3E0:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x06004465 RID: 17509 RVA: 0x00897144 File Offset: 0x00895344
			internal static bool dkKMlj56by3y4HucYmHG()
			{
				return true;
			}

			// Token: 0x06004466 RID: 17510 RVA: 0x00897148 File Offset: 0x00895348
			internal static bool uMUUm156utMw8M0hrqBQ()
			{
				return false;
			}

			// Token: 0x04005017 RID: 20503
			internal Vector3 $myPosition$31774;

			// Token: 0x04005018 RID: 20504
			internal Vector3 $myDirection$31775;

			// Token: 0x04005019 RID: 20505
			internal UnityScript.Lang.Array $nArray$31776;

			// Token: 0x0400501A RID: 20506
			internal Deadbull $self_$31777;
		}
	}
}
