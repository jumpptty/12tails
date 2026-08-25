using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200013D RID: 317
[Serializable]
public class NinjaBug : MonoBehaviour
{
	// Token: 0x0600070C RID: 1804 RVA: 0x000B97D8 File Offset: 0x000B79D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NinjaBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600070D RID: 1805 RVA: 0x000B97E8 File Offset: 0x000B79E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (3813 - 341225 != -337412)
		{
		}
		for (;;)
		{
			this.cfmn8gdKD4 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (45289 - 104935 != -59645)
			{
				this.cfmn8gdKD4.actionState = "standby";
				if (148259 - 273814 != -125554)
				{
					this.cfmn8gdKD4.actionTime = Time.time;
					if (182057 - 586109 != -404051)
					{
						this.cfmn8gdKD4.myCommand = "none";
						if (185988 - 520291 != -334302)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (70317 - 31569 == 38748)
							{
								this.cfmn8gdKD4.isMine = true;
								if (266981 - 505916 != -238934)
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

	// Token: 0x0600070E RID: 1806 RVA: 0x000B9920 File Offset: 0x000B7B20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (283614 - 213388 != 70227)
		{
		}
		for (;;)
		{
			if (this.cfmn8gdKD4.isControlled)
			{
				if (287687 - 81408 == 206280)
				{
					continue;
				}
				if (!(this.cfmn8gdKD4.actionState == "standby"))
				{
					if (118647 - 233931 == -115283)
					{
						continue;
					}
					if (!(this.cfmn8gdKD4.actionState == "run"))
					{
						goto IL_10E;
					}
					if (194322 - 128568 != 65754)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (78427 - 272120 == -193692)
				{
					continue;
				}
			}
			IL_10E:
			if (this.cfmn8gdKD4.hp <= 0)
			{
				if (15372 - 95829 != -80457)
				{
					continue;
				}
				if (this.cfmn8gdKD4.actionState != "dead")
				{
					if (1451 - 595161 != -593710)
					{
						continue;
					}
					if (this.cfmn8gdKD4.isMine)
					{
						if (150933 - 244436 != -93503)
						{
							continue;
						}
						statusClass status = this.cfmn8gdKD4.getStatus("autoLife");
						if (296286 - 82426 != 213860)
						{
							continue;
						}
						if (status != null)
						{
							if (102699 - 29510 == 73190)
							{
								continue;
							}
							this.cfmn8gdKD4.hp = 1;
							if (58622 - 267434 == -208811)
							{
								continue;
							}
							this.cfmn8gdKD4.RPC_RemoveStatus("autoLife");
							if (175691 - 348401 != -172710)
							{
								continue;
							}
							this.cfmn8gdKD4.RPC_createEffect("autoLife");
							if (83156 - 414416 == -331259)
							{
								continue;
							}
							this.cfmn8gdKD4.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (253646 - 113027 != 140620)
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
							if (74589 - 245554 == -170964)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (287050 - 583624 != -296574)
							{
								continue;
							}
							this.cfmn8gdKD4.DeadEvent();
							if (31898 - 281139 != -249241)
							{
								continue;
							}
							break;
						}
					}
					else
					{
						this.cfmn8gdKD4.hp = 1;
						if (10896 - 490868 != -479972)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.cfmn8gdKD4.hp <= 0)
			{
				break;
			}
			if (238509 - 376638 != -138128)
			{
				if (this.cfmn8gdKD4.ko > 0)
				{
					break;
				}
				if (138657 - 313705 != -175047)
				{
					if (!(this.cfmn8gdKD4.actionState != "ko"))
					{
						break;
					}
					if (136383 - 342329 == -205946)
					{
						if (!(this.cfmn8gdKD4.actionState != "dead"))
						{
							break;
						}
						if (103158 - 91371 == 11787)
						{
							if (this.cfmn8gdKD4.isMine)
							{
								if (90640 - 110055 == -19415)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (157824 - 36270 == 121554)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (235632 - 85427 == 150205)
										{
											this.cfmn8gdKD4.KoEvent();
											if (272762 - 425186 == -152424)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.cfmn8gdKD4.ko = 1;
								if (182373 - 293346 != -110972)
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

	// Token: 0x0600070F RID: 1807 RVA: 0x000B9E20 File Offset: 0x000B8020
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (275604 - 110971 != 164633)
		{
		}
		for (;;)
		{
			float num = this.cfmn8gdKD4.moveSpeed;
			if (281136 - 263258 != 17879)
			{
				float runSpeed = this.cfmn8gdKD4.runSpeed;
				if (64533 - 526522 == -461989)
				{
					Vector3 a = default(Vector3);
					if (94005 - 548733 != -454727)
					{
						Vector3 vector = Vector3.zero;
						if (66981 - 506107 != -439125)
						{
							float num2 = (float)0;
							if (195909 - 521886 != -325976)
							{
								if (this.cfmn8gdKD4.isMine)
								{
									if (33509 - 493228 != -459719)
									{
										continue;
									}
									if ((this.cfmn8gdKD4.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (7026 - 508240 == -501213)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (98641 - 389149 != -290508)
										{
											continue;
										}
										a.y = (float)0;
										if (233046 - 576764 != -343718)
										{
											continue;
										}
										a = a.normalized;
										if (97228 - 283450 == -186221)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (39693 - 481967 == -442273)
										{
											continue;
										}
										vector = vector.normalized;
										if (250745 - 30841 == 219905)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (198978 - 442849 != -243871)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (67221 - 480395 != -413174)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (110428 - 307998 != -197570)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (136452 - 580656 != -444204)
														{
															continue;
														}
														this.cfmn8gdKD4.actionState = "run";
														if (256428 - 107658 == 148771)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (190438 - 576108 == -385669)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (267987 - 205432 != 62555)
														{
															continue;
														}
														this.animation.Play("run");
														if (232729 - 198982 != 33747)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (227106 - 456112 != -229005)
														{
															goto IL_21D;
														}
														continue;
													}
												}
											}
										}
										this.cfmn8gdKD4.actionState = "standby";
										if (241381 - 256266 != -14885)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (84193 - 220654 == -136460)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (146636 - 581748 != -435112)
											{
												continue;
											}
											num = (float)0;
											if (236804 - 449606 != -212802)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (188296 - 599947 != -411651)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (157829 - 173246 != -15417)
										{
											continue;
										}
									}
									IL_21D:;
								}
								else
								{
									vector = global::Math.vFlat(this.cfmn8gdKD4.nPosition - this.transform.position);
									if (174027 - 228748 == -54720)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (68877 - 396899 == -328021)
									{
										continue;
									}
									if (this.cfmn8gdKD4.nSpeed != (float)0)
									{
										if (232416 - 470152 == -237735)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (67932 - 221569 != -153637)
											{
												continue;
											}
											this.transform.position = this.cfmn8gdKD4.nPosition;
											if (86505 - 416530 == -330024)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (162267 - 170123 != -7856)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (223293 - 325445 == -102151)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (31240 - 594810 == -563569)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.cfmn8gdKD4.nSpeed, (float)10 * Time.deltaTime);
												if (184656 - 455811 != -271155)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (150381 - 324282 == -173900)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (25729 - 33029 != -7300)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (113985 - 495165 == -381179)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (281634 - 418529 == -136894)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (160890 - 509894 == -349003)
											{
												continue;
											}
										}
										else if (Time.time > this.cfmn8gdKD4.nSpeed + 0.3f)
										{
											if (105090 - 322169 != -217079)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (153559 - 417010 == -263450)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (28283 - 504590 != -476307)
												{
													continue;
												}
												num = (float)0;
												if (8903 - 23734 == -14830)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.cfmn8gdKD4.nDirection);
											if (26660 - 508097 != -481437)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (282436 - 59856 != 222580)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (193635 - 178917 != 14718)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (20160 - 201809 == -181648)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (142888 - 472016 != -329128)
											{
												continue;
											}
											this.transform.position = this.cfmn8gdKD4.nPosition;
											if (97431 - 210500 == -113068)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (133537 - 4315 != 129222)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (38161 - 479055 != -440894)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (120013 - 462037 == -342023)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (37999 - 31033 == 6967)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (114369 - 96737 != 17632)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (70253 - 372105 != -301852)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (177919 - 124066 != 53853)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.cfmn8gdKD4.nDirection);
											if (272375 - 542513 != -270138)
											{
												continue;
											}
											num = (float)0;
											if (290093 - 275290 != 14803)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (102011 - 598345 == -496333)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (70052 - 20723 == 49330)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (201220 - 394891 != -193671)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (19971 - 38842 == -18870)
										{
											continue;
										}
									}
								}
								this.cfmn8gdKD4.vMovement = vector;
								if (253485 - 372261 != -118775)
								{
									this.cfmn8gdKD4.moveSpeed = num;
									if (238851 - 242586 != -3734)
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

	// Token: 0x06000710 RID: 1808 RVA: 0x000BA984 File Offset: 0x000B8B84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (44727 - 95748 != -51020)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (287205 - 313137 == -25932)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (220042 - 541683 != -321640)
				{
					if (211038 - 91795 == 119243)
					{
						if (ActionName == "RPC_sword")
						{
							if (114574 - 288326 == -173751)
							{
								continue;
							}
							v = 1;
							if (168212 - 459503 == -291290)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_shuriken")
						{
							if (245821 - 25263 != 220558)
							{
								continue;
							}
							v = 2;
							if (54348 - 515928 != -461580)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_bomb")
						{
							if (257228 - 565895 != -308667)
							{
								continue;
							}
							v = 3;
							if (197344 - 267131 == -69786)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_scythe")
						{
							if (227359 - 221872 == 5488)
							{
								continue;
							}
							v = 4;
							if (200508 - 271029 != -70521)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_knife")
						{
							if (185680 - 586916 == -401235)
							{
								continue;
							}
							v = 5;
							if (8573 - 28166 != -19593)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_sword_hit")
						{
							if (215813 - 133958 != 81855)
							{
								continue;
							}
							v = -1;
							if (106833 - 398299 == -291465)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_shuriken_fire")
						{
							if (230316 - 485133 != -254817)
							{
								continue;
							}
							v = -2;
							if (59482 - 444322 != -384840)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_shuriken_hit")
						{
							if (54312 - 31088 != 23224)
							{
								continue;
							}
							v = -21;
							if (4293 - 550404 == -546110)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_bomb_fire")
						{
							if (71862 - 265733 != -193871)
							{
								continue;
							}
							v = -3;
							if (70662 - 348243 == -277580)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_bomb_hit")
						{
							if (193142 - 586559 != -393417)
							{
								continue;
							}
							v = -31;
							if (211474 - 349416 != -137942)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_scythe_hit")
						{
							if (29003 - 15580 == 13424)
							{
								continue;
							}
							v = -4;
							if (109423 - 438511 == -329087)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_knife_fire")
						{
							if (48364 - 323558 != -275194)
							{
								continue;
							}
							v = -5;
							if (144529 - 284854 != -140325)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_knife_hit")
						{
							if (217405 - 236975 != -19570)
							{
								continue;
							}
							v = -51;
							if (52672 - 444586 == -391913)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (93023 - 577477 != -484453)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (32703 - 223548 == -190845)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (90123 - 55168 == 34955)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (144712 - 27164 != 117549)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (159703 - 64684 != 95020)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (292754 - 187262 == 105492)
											{
												Hashtable hashtable = new Hashtable();
												if (161067 - 584989 == -423922)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (272782 - 557887 == -285105)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (168067 - 203515 == -35448)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (298185 - 93119 == 205066)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (76888 - 81249 == -4361)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (153209 - 92659 == 60550)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (150463 - 550207 != -399743)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (140567 - 524521 == -383954)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (1390 - 556401 != -555010)
																				{
																					PhotonClient.SendEvent(this.cfmn8gdKD4.ActorNr, 74, hashtable, true, true);
																					if (175189 - 547021 != -371831)
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

	// Token: 0x06000711 RID: 1809 RVA: 0x000BB118 File Offset: 0x000B9318
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (142596 - 536609 != -394013)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (49025 - 92490 == -43465)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (191979 - 92494 != 99486)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (34586 - 104297 == -69711)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (82574 - 167351 == -84777)
						{
							int num3 = num;
							if (142083 - 323395 != -181311)
							{
								if (num3 == 1)
								{
									if (97704 - 523504 == -425800)
									{
										if (this.cfmn8gdKD4.isMine)
										{
											break;
										}
										if (277553 - 153932 == 123621)
										{
											this.StartCoroutine_Auto(this.RPC_sword(vector, vector2, num2));
											if (140163 - 206556 != -66392)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (151657 - 111434 != 40224)
									{
										if (this.cfmn8gdKD4.isMine)
										{
											break;
										}
										if (68179 - 552063 != -483883)
										{
											this.StartCoroutine_Auto(this.RPC_shuriken(vector, vector2, num2));
											if (53455 - 281953 == -228498)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 3)
								{
									if (90479 - 332312 == -241833)
									{
										if (this.cfmn8gdKD4.isMine)
										{
											break;
										}
										if (112380 - 448430 == -336050)
										{
											this.StartCoroutine_Auto(this.RPC_bomb(vector, vector2, num2));
											if (55533 - 223837 != -168303)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 4)
								{
									if (249912 - 525831 != -275918)
									{
										if (this.cfmn8gdKD4.isMine)
										{
											break;
										}
										if (266662 - 91279 == 175383)
										{
											this.StartCoroutine_Auto(this.RPC_scythe(vector, vector2, num2));
											if (164258 - 9393 != 154866)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 5)
								{
									if (136281 - 406269 == -269988)
									{
										if (this.cfmn8gdKD4.isMine)
										{
											break;
										}
										if (114917 - 185361 == -70444)
										{
											this.StartCoroutine_Auto(this.RPC_knife(vector, vector2, num2));
											if (231910 - 89455 != 142456)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (161150 - 227506 == -66356)
									{
										if (this.cfmn8gdKD4.isMine)
										{
											break;
										}
										if (196067 - 112530 != 83538)
										{
											this.RPC_sword_hit(vector, vector2, num2);
											if (297384 - 92396 == 204988)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -2)
								{
									if (180693 - 155441 != 25253)
									{
										if (this.cfmn8gdKD4.isMine)
										{
											break;
										}
										if (290202 - 534433 != -244230)
										{
											this.RPC_shuriken_fire(vector, vector2, num2);
											if (289005 - 66707 != 222299)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -21)
								{
									if (135105 - 278242 == -143137)
									{
										if (this.cfmn8gdKD4.isMine)
										{
											break;
										}
										if (145439 - 217904 == -72465)
										{
											this.RPC_shuriken_hit(vector, vector2, num2);
											if (65733 - 365531 == -299798)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -3)
								{
									if (23972 - 346213 != -322240)
									{
										if (this.cfmn8gdKD4.isMine)
										{
											break;
										}
										if (253061 - 236173 == 16888)
										{
											this.RPC_bomb_fire(vector, vector2, num2);
											if (226797 - 317072 != -90274)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -31)
								{
									if (182719 - 72495 == 110224)
									{
										if (this.cfmn8gdKD4.isMine)
										{
											break;
										}
										if (273125 - 109568 == 163557)
										{
											this.RPC_bomb_hit(vector, vector2, num2);
											if (216075 - 508494 != -292418)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -4)
								{
									if (132267 - 514871 != -382603)
									{
										if (this.cfmn8gdKD4.isMine)
										{
											break;
										}
										if (74750 - 447820 == -373070)
										{
											this.RPC_scythe_hit(vector, vector2, num2);
											if (122107 - 67650 != 54458)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -5)
								{
									if (85998 - 429435 != -343436)
									{
										if (this.cfmn8gdKD4.isMine)
										{
											break;
										}
										if (202374 - 565759 != -363384)
										{
											this.RPC_knife_fire(vector, vector2, num2);
											if (293729 - 518779 == -225050)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -51)
								{
									if (149251 - 422988 != -273736)
									{
										if (this.cfmn8gdKD4.isMine)
										{
											break;
										}
										if (230021 - 222802 == 7219)
										{
											this.RPC_knife_hit(vector, vector2, num2);
											if (236338 - 177355 != 58984)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (73574 - 337735 != -264160)
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

	// Token: 0x06000712 RID: 1810 RVA: 0x000BB8CC File Offset: 0x000B9ACC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (39443 - 116637 != -77194)
		{
		}
		for (;;)
		{
			if (!this.cfmn8gdKD4.isMine)
			{
				if (229159 - 393504 != -164344)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (152408 - 84639 == 67769)
				{
					Vector3 vector = a - this.transform.position;
					if (43414 - 502614 == -459200)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (254011 - 368328 != -114316)
						{
							if (!(this.cfmn8gdKD4.actionState == "standby"))
							{
								if (132960 - 386154 != -253194)
								{
									continue;
								}
								if (!(this.cfmn8gdKD4.actionState == "run"))
								{
									break;
								}
								if (130264 - 416074 == -285809)
								{
									continue;
								}
							}
							if (this.cfmn8gdKD4.isTimeOut("nAttack") != (float)0)
							{
								break;
							}
							if (113377 - 171501 != -58123)
							{
								eNinjaBugType eNinjaBugType = this.ninjaBugType;
								if (95431 - 479040 == -383609)
								{
									if (eNinjaBugType == eNinjaBugType.sword)
									{
										if (255152 - 571420 == -316268)
										{
											this.StartCoroutine_Auto(this.RPC_sword(this.transform.position, vector, 0));
											if (184310 - 342864 != -158553)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (282741 - 201664 != 81078)
												{
													this.ActionEvent("RPC_sword", this.transform.position, vector, 0);
													if (231280 - 62417 == 168863)
													{
														break;
													}
												}
											}
										}
									}
									else if (eNinjaBugType == eNinjaBugType.shuriken)
									{
										if (85916 - 255579 != -169662)
										{
											this.StartCoroutine_Auto(this.RPC_shuriken(this.transform.position, vector, 0));
											if (233694 - 24144 != 209551)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (72347 - 375220 != -302872)
												{
													this.ActionEvent("RPC_shuriken", this.transform.position, vector, 0);
													if (124158 - 429423 == -305265)
													{
														break;
													}
												}
											}
										}
									}
									else if (eNinjaBugType == eNinjaBugType.bomb)
									{
										if (133931 - 328270 == -194339)
										{
											this.StartCoroutine_Auto(this.RPC_bomb(this.transform.position, vector, 0));
											if (88057 - 277432 == -189375)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (19276 - 298295 == -279019)
												{
													this.ActionEvent("RPC_bomb", this.transform.position, vector, 0);
													if (289627 - 263337 == 26290)
													{
														break;
													}
												}
											}
										}
									}
									else if (eNinjaBugType == eNinjaBugType.scythe)
									{
										if (78552 - 313970 != -235417)
										{
											this.StartCoroutine_Auto(this.RPC_scythe(this.transform.position, vector, 0));
											if (81199 - 164210 != -83010)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (244412 - 465355 != -220942)
												{
													this.ActionEvent("RPC_scythe", this.transform.position, vector, 0);
													if (250702 - 305789 != -55086)
													{
														break;
													}
												}
											}
										}
									}
									else
									{
										if (eNinjaBugType != eNinjaBugType.knife)
										{
											break;
										}
										if (32901 - 446452 != -413550)
										{
											this.StartCoroutine_Auto(this.RPC_knife(this.transform.position, vector, 0));
											if (213917 - 126687 == 87230)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (184921 - 290882 != -105960)
												{
													this.ActionEvent("RPC_knife", this.transform.position, vector, 0);
													if (134453 - 325388 != -190934)
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

	// Token: 0x06000713 RID: 1811 RVA: 0x000BBDF8 File Offset: 0x000B9FF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000714 RID: 1812 RVA: 0x000BBDFC File Offset: 0x000B9FFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000715 RID: 1813 RVA: 0x000BBE00 File Offset: 0x000BA000
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_sword(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new NinjaBug.$RPC_sword$16475(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000716 RID: 1814 RVA: 0x000BBE10 File Offset: 0x000BA010
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_sword_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.NinjaBug_sword_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x06000717 RID: 1815 RVA: 0x000BBE2C File Offset: 0x000BA02C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_shuriken(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new NinjaBug.$RPC_shuriken$16489(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06000718 RID: 1816 RVA: 0x000BBE3C File Offset: 0x000BA03C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_shuriken_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (186238 - 430590 != -244351)
		{
		}
		for (;;)
		{
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.NinjaBug_shuriken_fire, firePos, Quaternion.LookRotation(fireDir));
			if (122717 - 347407 == -224690)
			{
				ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
				if (126999 - 437591 == -310592)
				{
					projectileControl.Init(this.cfmn8gdKD4.ActorNr);
					if (63080 - 380309 == -317229)
					{
						projectileControl.life = (float)2 * this.cfmn8gdKD4.rangeMod;
						if (243643 - 211732 == 31911)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06000719 RID: 1817 RVA: 0x000BBF30 File Offset: 0x000BA130
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_shuriken_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.NinjaBug_shuriken_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x0600071A RID: 1818 RVA: 0x000BBF4C File Offset: 0x000BA14C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_bomb(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new NinjaBug.$RPC_bomb$16501(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600071B RID: 1819 RVA: 0x000BBF5C File Offset: 0x000BA15C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_bomb_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (227507 - 371330 != -143822)
		{
		}
		for (;;)
		{
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.NinjaBug_bomb_fire, firePos, Quaternion.FromToRotation(Vector3.forward, fireDir));
			if (247512 - 28397 == 219115)
			{
				ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
				if (2503 - 298487 == -295984)
				{
					projectileControl.Init(this.cfmn8gdKD4.ActorNr);
					if (210365 - 389194 == -178829)
					{
						projectileControl.life = (float)4 * this.cfmn8gdKD4.rangeMod;
						if (297042 - 201677 != 95366)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600071C RID: 1820 RVA: 0x000BC054 File Offset: 0x000BA254
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_bomb_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.NinjaBug_bomb_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x0600071D RID: 1821 RVA: 0x000BC070 File Offset: 0x000BA270
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_knife(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new NinjaBug.$RPC_knife$16510(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x0600071E RID: 1822 RVA: 0x000BC080 File Offset: 0x000BA280
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_knife_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (141232 - 263540 != -122308)
		{
		}
		for (;;)
		{
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.NinjaBug_knife_fire, firePos, Quaternion.LookRotation(fireDir));
			if (192968 - 586117 == -393149)
			{
				ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
				if (165108 - 294367 != -129258)
				{
					projectileControl.Init(this.cfmn8gdKD4.ActorNr);
					if (200947 - 12731 != 188217)
					{
						projectileControl.life = (float)2 * this.cfmn8gdKD4.rangeMod;
						if (69395 - 217606 == -148211)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600071F RID: 1823 RVA: 0x000BC174 File Offset: 0x000BA374
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_knife_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.NinjaBug_knife_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x06000720 RID: 1824 RVA: 0x000BC190 File Offset: 0x000BA390
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_scythe(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new NinjaBug.$RPC_scythe$16522(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000721 RID: 1825 RVA: 0x000BC1A0 File Offset: 0x000BA3A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_scythe_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.NinjaBug_scythe_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x06000722 RID: 1826 RVA: 0x000BC1BC File Offset: 0x000BA3BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new NinjaBug.$RPC_ko$16535(nArray, this).GetEnumerator();
	}

	// Token: 0x06000723 RID: 1827 RVA: 0x000BC1CC File Offset: 0x000BA3CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new NinjaBug.$RPC_dead$16542(nArray, this).GetEnumerator();
	}

	// Token: 0x06000724 RID: 1828 RVA: 0x000BC1DC File Offset: 0x000BA3DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000725 RID: 1829 RVA: 0x000BC1E0 File Offset: 0x000BA3E0
	internal static bool nYSJD23k0n7iGkJLBZr()
	{
		return true;
	}

	// Token: 0x06000726 RID: 1830 RVA: 0x000BC1E4 File Offset: 0x000BA3E4
	internal static bool MyMvNt3GMMYwAXHcnWA()
	{
		return false;
	}

	// Token: 0x04000685 RID: 1669
	private CharacterControl cfmn8gdKD4;

	// Token: 0x04000686 RID: 1670
	public eNinjaBugType ninjaBugType;

	// Token: 0x04000687 RID: 1671
	public GameObject NinjaBug_sword_slash;

	// Token: 0x04000688 RID: 1672
	public GameObject NinjaBug_sword_hit;

	// Token: 0x04000689 RID: 1673
	public GameObject NinjaBug_shuriken_fire;

	// Token: 0x0400068A RID: 1674
	public GameObject NinjaBug_shuriken_hit;

	// Token: 0x0400068B RID: 1675
	public GameObject NinjaBug_bomb_fire;

	// Token: 0x0400068C RID: 1676
	public GameObject NinjaBug_bomb_hit;

	// Token: 0x0400068D RID: 1677
	public GameObject NinjaBug_knife_fire;

	// Token: 0x0400068E RID: 1678
	public GameObject NinjaBug_knife_hit;

	// Token: 0x0400068F RID: 1679
	public GameObject NinjaBug_scythe_hit;

	// Token: 0x0200013E RID: 318
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_sword$16475 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000727 RID: 1831 RVA: 0x000BC1E8 File Offset: 0x000BA3E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_sword$16475(Vector3 mPos, Vector3 tDir, NinjaBug self_)
		{
			if (66928 - 262120 != -195192)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (82371 - 358357 != -275985)
				{
					base..ctor();
					if (196595 - 418708 != -222112)
					{
						this.$mPos$16486 = mPos;
						if (67628 - 319252 != -251623)
						{
							this.$tDir$16487 = tDir;
							if (3118 - 355845 != -352726)
							{
								this.$self_$16488 = self_;
								if (69007 - 263652 == -194645)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x000BC2C4 File Offset: 0x000BA4C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NinjaBug.$RPC_sword$16475.$(this.$mPos$16486, this.$tDir$16487, this.$self_$16488);
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x000BC2E0 File Offset: 0x000BA4E0
		internal static bool qicJC43HVD9q4eZaJqv()
		{
			return true;
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x000BC2E4 File Offset: 0x000BA4E4
		internal static bool LIuW4J3WjsfXknj39rO()
		{
			return false;
		}

		// Token: 0x04000690 RID: 1680
		internal Vector3 $mPos$16486;

		// Token: 0x04000691 RID: 1681
		internal Vector3 $tDir$16487;

		// Token: 0x04000692 RID: 1682
		internal NinjaBug $self_$16488;

		// Token: 0x0200013F RID: 319
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600072B RID: 1835 RVA: 0x000BC2E8 File Offset: 0x000BA4E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, NinjaBug self_)
			{
				if (25339 - 363017 != -337677)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (246679 - 137149 == 109530)
					{
						base..ctor();
						if (114700 - 181078 == -66378)
						{
							this.$mPos$16483 = mPos;
							if (37533 - 163960 != -126426)
							{
								this.$tDir$16484 = tDir;
								if (130006 - 273236 != -143229)
								{
									this.$self_$16485 = self_;
									if (49003 - 461645 == -412642)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600072C RID: 1836 RVA: 0x000BC3C4 File Offset: 0x000BA5C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (235919 - 199030 != 36889)
				{
				}
				for (;;)
				{
					IL_213:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_EDC;
					case 2:
						if (this.$self_$16485.cfmn8gdKD4.actionState != "attack")
						{
							goto IL_6D8;
						}
						if (170596 - 38992 != 131604)
						{
							continue;
						}
						if (this.$self_$16485.cfmn8gdKD4.myCommand != "sword")
						{
							if (250940 - 520058 != -269117)
							{
								goto Block_26;
							}
							continue;
						}
						else
						{
							this.$self_$16485.cfmn8gdKD4.moveSpeed = (float)0;
							if (171990 - 189418 != -17428)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$16485.NinjaBug_sword_slash, this.$self_$16485.transform.position + this.$self_$16485.transform.forward, Quaternion.identity);
							if (239553 - 154624 != 84929)
							{
								continue;
							}
							this.$hitLayer$16476 = 130816 - (1 << this.$self_$16485.gameObject.layer);
							if (218202 - 104406 != 113796)
							{
								continue;
							}
							this.$hitList$16477 = null;
							if (28107 - 138713 != -110606)
							{
								continue;
							}
							this.$hitPos$16478 = default(Vector3);
							if (2626 - 572841 == -570214)
							{
								continue;
							}
							if (!this.$self_$16485.cfmn8gdKD4.isMine)
							{
								goto IL_520;
							}
							if (35463 - 567706 != -532243)
							{
								continue;
							}
							this.$hitList$16477 = Damage.FindRecTarget(this.$self_$16485.transform.position - this.$self_$16485.cfmn8gdKD4.rangeMod * this.$self_$16485.transform.forward, this.$self_$16485.transform.forward, (float)1 * this.$self_$16485.cfmn8gdKD4.rangeMod, (float)1 * this.$self_$16485.cfmn8gdKD4.rangeMod, 2.5f * this.$self_$16485.cfmn8gdKD4.rangeMod, (float)2 * this.$self_$16485.cfmn8gdKD4.rangeMod, this.$hitLayer$16476);
							if (81379 - 155698 == -74318)
							{
								continue;
							}
							this.$$iterator$9971$16480 = UnityRuntimeServices.GetEnumerator(this.$hitList$16477);
							if (132650 - 432363 == -299712)
							{
								continue;
							}
							while (this.$$iterator$9971$16480.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9971$16480.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$16479 = (GameObject)obj2;
								if (92250 - 416854 != -324604)
								{
									goto IL_213;
								}
								if (this.$self_$16485.cfmn8gdKD4.hit(99, this.$hitObject$16479, this.$self_$16485.cfmn8gdKD4.atk, 1, 0, 0.5f * (this.$hitObject$16479.transform.position - this.$self_$16485.transform.position).normalized) != 0)
								{
									if (71516 - 414787 != -343271)
									{
										goto IL_213;
									}
									this.$hitPos$16478 = this.$hitObject$16479.collider.ClosestPointOnBounds(this.$self_$16485.transform.position + 0.3f * Vector3.up);
									if (219244 - 447757 != -228513)
									{
										goto IL_213;
									}
									UnityRuntimeServices.Update(this.$$iterator$9971$16480, this.$hitObject$16479);
									if (145355 - 269295 != -123940)
									{
										goto IL_213;
									}
									this.$self_$16485.RPC_sword_hit(this.$hitPos$16478, this.$self_$16485.transform.forward, 0);
									if (182593 - 403631 != -221038)
									{
										goto IL_213;
									}
									this.$self_$16485.ActionEvent("RPC_sword_hit", this.$hitPos$16478, this.$self_$16485.transform.forward, 0);
									if (170448 - 324188 != -153740)
									{
										goto IL_213;
									}
									this.$self_$16485.cfmn8gdKD4.sp = this.$self_$16485.cfmn8gdKD4.sp + 1;
									if (111456 - 210364 != -98908)
									{
										goto IL_213;
									}
								}
							}
							if (128656 - 495227 != -366570)
							{
								goto Block_17;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16485.cfmn8gdKD4.actionState != "attack")
						{
							goto IL_12E;
						}
						if (190508 - 313416 != -122908)
						{
							continue;
						}
						if (this.$self_$16485.cfmn8gdKD4.myCommand != "sword")
						{
							if (46566 - 30538 != 16029)
							{
								goto Block_39;
							}
							continue;
						}
						else
						{
							this.$self_$16485.cfmn8gdKD4.moveSpeed = (float)8;
							if (284581 - 114985 == 169597)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$16485.NinjaBug_sword_slash, this.$self_$16485.transform.position + this.$self_$16485.transform.forward, Quaternion.identity);
							if (148581 - 120479 != 28103)
							{
								goto Block_75;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$16485.cfmn8gdKD4.actionState != "attack")
						{
							goto IL_15F;
						}
						if (185523 - 414982 == -229458)
						{
							continue;
						}
						if (this.$self_$16485.cfmn8gdKD4.myCommand != "sword")
						{
							if (117076 - 295046 != -177970)
							{
								continue;
							}
							goto IL_15F;
						}
						else
						{
							if (!this.$self_$16485.cfmn8gdKD4.isMine)
							{
								goto IL_882;
							}
							if (285100 - 404356 != -119256)
							{
								continue;
							}
							this.$hitList$16477 = Damage.FindRecTarget(this.$self_$16485.transform.position - this.$self_$16485.cfmn8gdKD4.rangeMod * this.$self_$16485.transform.forward, this.$self_$16485.transform.forward, (float)1 * this.$self_$16485.cfmn8gdKD4.rangeMod, (float)1 * this.$self_$16485.cfmn8gdKD4.rangeMod, 2.5f * this.$self_$16485.cfmn8gdKD4.rangeMod, (float)2 * this.$self_$16485.cfmn8gdKD4.rangeMod, this.$hitLayer$16476);
							if (71739 - 315490 != -243751)
							{
								continue;
							}
							this.$$iterator$9972$16482 = UnityRuntimeServices.GetEnumerator(this.$hitList$16477);
							if (229130 - 152363 == 76768)
							{
								continue;
							}
							while (this.$$iterator$9972$16482.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$9972$16482.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$16481 = (GameObject)obj4;
								if (222974 - 182401 == 40574)
								{
									goto IL_213;
								}
								if (this.$self_$16485.cfmn8gdKD4.hit(99, this.$hitObject$16481, this.$self_$16485.cfmn8gdKD4.atk, 1, 0, 0.5f * (this.$hitObject$16481.transform.position - this.$self_$16485.transform.position).normalized) != 0)
								{
									if (34877 - 337070 == -302192)
									{
										goto IL_213;
									}
									this.$hitPos$16478 = this.$hitObject$16481.collider.ClosestPointOnBounds(this.$self_$16485.transform.position + 0.3f * Vector3.up);
									if (11859 - 34771 == -22911)
									{
										goto IL_213;
									}
									UnityRuntimeServices.Update(this.$$iterator$9972$16482, this.$hitObject$16481);
									if (32437 - 535887 == -503449)
									{
										goto IL_213;
									}
									this.$self_$16485.RPC_sword_hit(this.$hitPos$16478, this.$self_$16485.transform.forward, 0);
									if (252259 - 444689 == -192429)
									{
										goto IL_213;
									}
									this.$self_$16485.ActionEvent("RPC_sword_hit", this.$hitPos$16478, this.$self_$16485.transform.forward, 0);
									if (138870 - 427026 == -288155)
									{
										goto IL_213;
									}
									this.$self_$16485.cfmn8gdKD4.sp = this.$self_$16485.cfmn8gdKD4.sp + 1;
									if (122754 - 64747 != 58007)
									{
										goto IL_213;
									}
								}
							}
							if (153790 - 551931 != -398140)
							{
								goto Block_78;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$16485.cfmn8gdKD4.actionState != "attack")
						{
							goto IL_A56;
						}
						if (135122 - 111447 != 23675)
						{
							continue;
						}
						if (this.$self_$16485.cfmn8gdKD4.myCommand != "sword")
						{
							if (151849 - 305440 != -153590)
							{
								goto Block_74;
							}
							continue;
						}
						else
						{
							this.$self_$16485.cfmn8gdKD4.moveSpeed = (float)0;
							if (150816 - 371726 != -220910)
							{
								continue;
							}
							goto IL_76B;
						}
						break;
					case 6:
						if (this.$self_$16485.cfmn8gdKD4.actionState == "attack")
						{
							if (214053 - 386148 != -172095)
							{
								continue;
							}
							if (this.$self_$16485.cfmn8gdKD4.myCommand == "sword")
							{
								if (147137 - 333266 != -186129)
								{
									continue;
								}
								this.$self_$16485.cfmn8gdKD4.actionState = "standby";
								if (180331 - 337947 == -157615)
								{
									continue;
								}
								this.$self_$16485.cfmn8gdKD4.actionTime = Time.time;
								if (71713 - 401232 != -329519)
								{
									continue;
								}
								this.$self_$16485.cfmn8gdKD4.myCommand = "none";
								if (102561 - 588428 != -485867)
								{
									continue;
								}
								if (!this.$self_$16485.cfmn8gdKD4.isMine)
								{
									if (147296 - 31992 != 115304)
									{
										continue;
									}
									this.$self_$16485.cfmn8gdKD4.nPosition = this.$self_$16485.transform.position;
									if (234353 - 113979 == 120375)
									{
										continue;
									}
									this.$self_$16485.cfmn8gdKD4.oPosition = this.$self_$16485.transform.position;
									if (262368 - 454843 == -192474)
									{
										continue;
									}
									this.$self_$16485.cfmn8gdKD4.nDirection = this.$self_$16485.transform.forward;
									if (208549 - 276843 != -68294)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (240951 - 485651 != -244699)
						{
							goto Block_53;
						}
						continue;
					default:
						if (90255 - 37054 != 53201)
						{
							continue;
						}
						break;
					}
					this.$self_$16485.cfmn8gdKD4.actionState = "attack";
					if (168585 - 543673 != -375087)
					{
						this.$self_$16485.cfmn8gdKD4.actionTime = Time.time;
						if (296989 - 344895 == -47906)
						{
							this.$self_$16485.cfmn8gdKD4.myCommand = "sword";
							if (284932 - 291940 == -7008)
							{
								this.$self_$16485.cfmn8gdKD4.addTimeOut("nAttack", (float)2);
								if (120397 - 428213 == -307816)
								{
									this.$self_$16485.transform.position = this.$mPos$16483;
									if (163500 - 17845 == 145655)
									{
										this.$self_$16485.transform.LookAt(this.$mPos$16483 + global::Math.vFlat(this.$tDir$16484));
										if (54705 - 329015 != -274309)
										{
											this.$self_$16485.animation.CrossFade("sword");
											if (137039 - 109844 != 27196)
											{
												this.$self_$16485.animation.wrapMode = WrapMode.Once;
												if (54192 - 524654 == -470462)
												{
													this.$self_$16485.cfmn8gdKD4.vMovement = this.$self_$16485.transform.forward;
													if (293229 - 92094 != 201136)
													{
														this.$self_$16485.cfmn8gdKD4.moveSpeed = (float)4;
														if (153810 - 445600 != -291789)
														{
															goto Block_72;
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
				IL_12E:
				IL_15F:
				goto IL_EDC;
				Block_17:
				goto IL_520;
				Block_26:
				goto IL_6D8;
				IL_520:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_39:
				IL_6D8:
				goto IL_EDC;
				IL_76B:
				return this.Yield(6, new WaitForSeconds(0.3f));
				IL_882:
				return this.Yield(5, new WaitForSeconds(0.1f));
				Block_53:
				IL_A56:
				goto IL_EDC;
				Block_72:
				return this.Yield(2, new WaitForSeconds(0.3f));
				Block_74:
				goto IL_A56;
				Block_75:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_78:
				goto IL_882;
				IL_EDC:
				return false;
			}

			// Token: 0x0600072D RID: 1837 RVA: 0x000BD2C0 File Offset: 0x000BB4C0
			internal static bool UG9Nxx3A2bARqAyMlrI()
			{
				return true;
			}

			// Token: 0x0600072E RID: 1838 RVA: 0x000BD2C4 File Offset: 0x000BB4C4
			internal static bool Dvl7JX3lgNJ0N1fG5wi()
			{
				return false;
			}

			// Token: 0x04000693 RID: 1683
			internal int $hitLayer$16476;

			// Token: 0x04000694 RID: 1684
			internal UnityScript.Lang.Array $hitList$16477;

			// Token: 0x04000695 RID: 1685
			internal Vector3 $hitPos$16478;

			// Token: 0x04000696 RID: 1686
			internal GameObject $hitObject$16479;

			// Token: 0x04000697 RID: 1687
			internal IEnumerator $$iterator$9971$16480;

			// Token: 0x04000698 RID: 1688
			internal GameObject $hitObject$16481;

			// Token: 0x04000699 RID: 1689
			internal IEnumerator $$iterator$9972$16482;

			// Token: 0x0400069A RID: 1690
			internal Vector3 $mPos$16483;

			// Token: 0x0400069B RID: 1691
			internal Vector3 $tDir$16484;

			// Token: 0x0400069C RID: 1692
			internal NinjaBug $self_$16485;
		}
	}

	// Token: 0x02000140 RID: 320
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_shuriken$16489 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600072F RID: 1839 RVA: 0x000BD2C8 File Offset: 0x000BB4C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_shuriken$16489(Vector3 mPos, Vector3 tDir, int tID, NinjaBug self_)
		{
			if (75500 - 50454 != 25047)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (145319 - 204568 == -59249)
				{
					base..ctor();
					if (223817 - 486768 != -262950)
					{
						this.$mPos$16497 = mPos;
						if (231375 - 351784 == -120409)
						{
							this.$tDir$16498 = tDir;
							if (214118 - 574358 == -360240)
							{
								this.$tID$16499 = tID;
								if (15076 - 30479 == -15403)
								{
									this.$self_$16500 = self_;
									if (169114 - 277812 == -108698)
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

		// Token: 0x06000730 RID: 1840 RVA: 0x000BD3C8 File Offset: 0x000BB5C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NinjaBug.$RPC_shuriken$16489.$(this.$mPos$16497, this.$tDir$16498, this.$tID$16499, this.$self_$16500);
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x000BD3E8 File Offset: 0x000BB5E8
		internal static bool MpWecq3y2YcTqaCffB5()
		{
			return true;
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x000BD3EC File Offset: 0x000BB5EC
		internal static bool NxeONO3Srhw62BjcmcE()
		{
			return false;
		}

		// Token: 0x0400069D RID: 1693
		internal Vector3 $mPos$16497;

		// Token: 0x0400069E RID: 1694
		internal Vector3 $tDir$16498;

		// Token: 0x0400069F RID: 1695
		internal int $tID$16499;

		// Token: 0x040006A0 RID: 1696
		internal NinjaBug $self_$16500;

		// Token: 0x02000141 RID: 321
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000733 RID: 1843 RVA: 0x000BD3F0 File Offset: 0x000BB5F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, NinjaBug self_)
			{
				if (162959 - 520801 != -357842)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (187760 - 193227 != -5466)
					{
						base..ctor();
						if (2224 - 242319 != -240094)
						{
							this.$mPos$16493 = mPos;
							if (292602 - 503095 == -210493)
							{
								this.$tDir$16494 = tDir;
								if (206004 - 96950 == 109054)
								{
									this.$tID$16495 = tID;
									if (126850 - 341705 == -214855)
									{
										this.$self_$16496 = self_;
										if (271492 - 291026 != -19533)
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

			// Token: 0x06000734 RID: 1844 RVA: 0x000BD4F0 File Offset: 0x000BB6F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (227799 - 263369 != -35569)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7CA;
					case 2:
						if (this.$self_$16496.cfmn8gdKD4.actionState != "attack")
						{
							goto IL_2ED;
						}
						if (260297 - 49830 == 210468)
						{
							continue;
						}
						if (this.$self_$16496.cfmn8gdKD4.myCommand != "shuriken")
						{
							if (143155 - 193087 != -49931)
							{
								goto Block_49;
							}
							continue;
						}
						else
						{
							if (!this.$self_$16496.cfmn8gdKD4.isMine)
							{
								goto IL_4C9;
							}
							if (119878 - 215291 == -95412)
							{
								continue;
							}
							this.$firePos$16490 = this.$mPos$16493 + this.$self_$16496.transform.TransformDirection(new Vector3((float)0, (float)2, (float)1));
							if (4500 - 136060 == -131559)
							{
								continue;
							}
							this.$fireDir$16491 = this.$tDir$16494 - this.$self_$16496.transform.TransformDirection(new Vector3((float)0, (float)2, (float)1));
							if (164296 - 128637 != 35659)
							{
								continue;
							}
							if (this.$tID$16495 != 0)
							{
								if (72913 - 99343 == -26429)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$16495];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$16492 = (GameObject)obj2;
								if (168554 - 264552 == -95997)
								{
									continue;
								}
								if (this.$tObject$16492)
								{
									if (157283 - 380798 == -223514)
									{
										continue;
									}
									this.$fireDir$16491 = this.$tObject$16492.collider.bounds.center - this.$firePos$16490;
									if (82063 - 284458 != -202395)
									{
										continue;
									}
								}
							}
							this.$self_$16496.RPC_shuriken_fire(this.$firePos$16490, this.$fireDir$16491, 0);
							if (71568 - 158170 == -86601)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_4C9;
							}
							if (51810 - 306056 != -254246)
							{
								continue;
							}
							this.$self_$16496.ActionEvent("RPC_shuriken_fire", this.$firePos$16490, this.$fireDir$16491, 0);
							if (126390 - 578620 != -452229)
							{
								goto Block_18;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16496.cfmn8gdKD4.actionState != "attack")
						{
							goto IL_78;
						}
						if (98565 - 555184 != -456619)
						{
							continue;
						}
						if (this.$self_$16496.cfmn8gdKD4.myCommand != "shuriken")
						{
							if (116554 - 503655 != -387100)
							{
								goto Block_26;
							}
							continue;
						}
						else
						{
							this.$self_$16496.cfmn8gdKD4.moveSpeed = (float)0;
							if (2253 - 485856 != -483602)
							{
								goto Block_5;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$16496.cfmn8gdKD4.actionState == "attack")
						{
							if (160723 - 547851 == -387127)
							{
								continue;
							}
							if (this.$self_$16496.cfmn8gdKD4.myCommand == "shuriken")
							{
								if (278299 - 189884 == 88416)
								{
									continue;
								}
								this.$self_$16496.cfmn8gdKD4.actionState = "standby";
								if (298566 - 484415 != -185849)
								{
									continue;
								}
								this.$self_$16496.cfmn8gdKD4.actionTime = Time.time;
								if (253052 - 74552 != 178500)
								{
									continue;
								}
								this.$self_$16496.cfmn8gdKD4.myCommand = "none";
								if (7112 - 187568 != -180456)
								{
									continue;
								}
								if (!this.$self_$16496.cfmn8gdKD4.isMine)
								{
									if (118978 - 558857 == -439878)
									{
										continue;
									}
									this.$self_$16496.cfmn8gdKD4.nPosition = this.$self_$16496.transform.position;
									if (229487 - 371693 != -142206)
									{
										continue;
									}
									this.$self_$16496.cfmn8gdKD4.oPosition = this.$self_$16496.transform.position;
									if (65194 - 201659 != -136465)
									{
										continue;
									}
									this.$self_$16496.cfmn8gdKD4.nDirection = this.$self_$16496.transform.forward;
									if (89737 - 273257 == -183519)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (50494 - 592745 != -542250)
						{
							goto Block_27;
						}
						continue;
					default:
						if (99434 - 329770 == -230335)
						{
							continue;
						}
						break;
					}
					this.$self_$16496.cfmn8gdKD4.actionState = "attack";
					if (291819 - 230603 != 61217)
					{
						this.$self_$16496.cfmn8gdKD4.actionTime = Time.time;
						if (296432 - 103151 != 193282)
						{
							this.$self_$16496.cfmn8gdKD4.myCommand = "shuriken";
							if (262912 - 437854 != -174941)
							{
								this.$self_$16496.cfmn8gdKD4.addTimeOut("nAttack", (float)2);
								if (284829 - 455288 == -170459)
								{
									this.$self_$16496.transform.position = this.$mPos$16493;
									if (42985 - 392250 == -349265)
									{
										this.$self_$16496.transform.LookAt(this.$mPos$16493 + global::Math.vFlat(this.$tDir$16494));
										if (288585 - 380644 != -92058)
										{
											this.$self_$16496.animation.CrossFade("shuriken");
											if (196836 - 158613 == 38223)
											{
												this.$self_$16496.animation.wrapMode = WrapMode.Once;
												if (258365 - 466198 == -207833)
												{
													this.$self_$16496.cfmn8gdKD4.vMovement = this.$self_$16496.transform.forward;
													if (117139 - 282819 == -165680)
													{
														this.$self_$16496.cfmn8gdKD4.moveSpeed = (float)-4;
														if (170413 - 223633 == -53220)
														{
															goto IL_440;
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
				IL_78:
				goto IL_7CA;
				Block_5:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_18:
				goto IL_4C9;
				IL_2ED:
				Block_26:
				Block_27:
				goto IL_7CA;
				IL_440:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_4C9:
				return this.Yield(3, new WaitForSeconds(0.4f));
				Block_49:
				IL_7CA:
				return false;
			}

			// Token: 0x06000735 RID: 1845 RVA: 0x000BDCDC File Offset: 0x000BBEDC
			internal static bool LelbW43oyM22x8NKDOj()
			{
				return true;
			}

			// Token: 0x06000736 RID: 1846 RVA: 0x000BDCE0 File Offset: 0x000BBEE0
			internal static bool qHnhtY3EHBLy5AAsHuB()
			{
				return false;
			}

			// Token: 0x040006A1 RID: 1697
			internal Vector3 $firePos$16490;

			// Token: 0x040006A2 RID: 1698
			internal Vector3 $fireDir$16491;

			// Token: 0x040006A3 RID: 1699
			internal GameObject $tObject$16492;

			// Token: 0x040006A4 RID: 1700
			internal Vector3 $mPos$16493;

			// Token: 0x040006A5 RID: 1701
			internal Vector3 $tDir$16494;

			// Token: 0x040006A6 RID: 1702
			internal int $tID$16495;

			// Token: 0x040006A7 RID: 1703
			internal NinjaBug $self_$16496;
		}
	}

	// Token: 0x02000142 RID: 322
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_bomb$16501 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000737 RID: 1847 RVA: 0x000BDCE4 File Offset: 0x000BBEE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_bomb$16501(Vector3 mPos, Vector3 tDir, NinjaBug self_)
		{
			if (192641 - 438792 != -246150)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (136209 - 477721 != -341511)
				{
					base..ctor();
					if (134913 - 519867 == -384954)
					{
						this.$mPos$16507 = mPos;
						if (64564 - 167163 == -102599)
						{
							this.$tDir$16508 = tDir;
							if (88451 - 447615 == -359164)
							{
								this.$self_$16509 = self_;
								if (245236 - 183092 != 62145)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x000BDDC0 File Offset: 0x000BBFC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NinjaBug.$RPC_bomb$16501.$(this.$mPos$16507, this.$tDir$16508, this.$self_$16509);
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x000BDDDC File Offset: 0x000BBFDC
		internal static bool aZuaUA32nQOlrt7PG97()
		{
			return true;
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x000BDDE0 File Offset: 0x000BBFE0
		internal static bool mdbW93381bI0pRXb8Gl()
		{
			return false;
		}

		// Token: 0x040006A8 RID: 1704
		internal Vector3 $mPos$16507;

		// Token: 0x040006A9 RID: 1705
		internal Vector3 $tDir$16508;

		// Token: 0x040006AA RID: 1706
		internal NinjaBug $self_$16509;

		// Token: 0x02000143 RID: 323
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600073B RID: 1851 RVA: 0x000BDDE4 File Offset: 0x000BBFE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, NinjaBug self_)
			{
				if (198348 - 573102 != -374754)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (84308 - 529452 != -445143)
					{
						base..ctor();
						if (127906 - 378548 != -250641)
						{
							this.$mPos$16504 = mPos;
							if (112807 - 76101 != 36707)
							{
								this.$tDir$16505 = tDir;
								if (95094 - 101022 == -5928)
								{
									this.$self_$16506 = self_;
									if (209581 - 480540 == -270959)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600073C RID: 1852 RVA: 0x000BDEC0 File Offset: 0x000BC0C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (11920 - 562587 != -550667)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_72A;
					case 2:
						if (this.$self_$16506.cfmn8gdKD4.actionState != "attack")
						{
							goto IL_467;
						}
						if (252064 - 377706 != -125642)
						{
							continue;
						}
						if (this.$self_$16506.cfmn8gdKD4.myCommand != "bomb")
						{
							if (136967 - 229648 != -92681)
							{
								continue;
							}
							goto IL_467;
						}
						else
						{
							this.$self_$16506.cfmn8gdKD4.moveSpeed = (float)2;
							if (23372 - 229101 != -205729)
							{
								continue;
							}
							if (!this.$self_$16506.cfmn8gdKD4.isMine)
							{
								goto IL_204;
							}
							if (170017 - 34560 != 135457)
							{
								continue;
							}
							this.$firePos$16502 = this.$mPos$16504 + this.$self_$16506.transform.TransformDirection(0.2f, (float)1, 0.6f);
							if (271700 - 487805 != -216105)
							{
								continue;
							}
							this.$fireDir$16503 = global::Math.getMortarVector(this.$firePos$16502, this.$firePos$16502 + this.$tDir$16505 - this.$self_$16506.transform.TransformDirection(0.2f, (float)1, 0.6f), (float)9);
							if (77799 - 251612 == -173812)
							{
								continue;
							}
							this.$self_$16506.RPC_bomb_fire(this.$firePos$16502, this.$fireDir$16503, 0);
							if (251918 - 333129 != -81211)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_204;
							}
							if (286744 - 540050 == -253305)
							{
								continue;
							}
							this.$self_$16506.ActionEvent("RPC_bomb_fire", this.$firePos$16502, this.$fireDir$16503, 0);
							if (20904 - 240034 != -219129)
							{
								goto Block_24;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16506.cfmn8gdKD4.actionState != "attack")
						{
							goto IL_1D3;
						}
						if (272417 - 180401 != 92016)
						{
							continue;
						}
						if (this.$self_$16506.cfmn8gdKD4.myCommand != "bomb")
						{
							if (231725 - 372170 != -140444)
							{
								goto Block_20;
							}
							continue;
						}
						else
						{
							this.$self_$16506.cfmn8gdKD4.moveSpeed = (float)0;
							if (124585 - 166170 != -41584)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$16506.cfmn8gdKD4.actionState == "attack")
						{
							if (159147 - 253430 != -94283)
							{
								continue;
							}
							if (this.$self_$16506.cfmn8gdKD4.myCommand == "bomb")
							{
								if (93041 - 435043 == -342001)
								{
									continue;
								}
								this.$self_$16506.cfmn8gdKD4.actionState = "standby";
								if (38893 - 162800 != -123907)
								{
									continue;
								}
								this.$self_$16506.cfmn8gdKD4.actionTime = Time.time;
								if (242994 - 253922 == -10927)
								{
									continue;
								}
								this.$self_$16506.cfmn8gdKD4.myCommand = "none";
								if (179117 - 300757 != -121640)
								{
									continue;
								}
								if (!this.$self_$16506.cfmn8gdKD4.isMine)
								{
									if (144039 - 85851 == 58189)
									{
										continue;
									}
									this.$self_$16506.cfmn8gdKD4.nPosition = this.$self_$16506.transform.position;
									if (294520 - 485037 == -190516)
									{
										continue;
									}
									this.$self_$16506.cfmn8gdKD4.oPosition = this.$self_$16506.transform.position;
									if (205275 - 455470 != -250195)
									{
										continue;
									}
									this.$self_$16506.cfmn8gdKD4.nDirection = this.$self_$16506.transform.forward;
									if (133360 - 317300 != -183940)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (250311 - 481806 != -231495)
						{
							continue;
						}
						goto IL_72A;
					default:
						if (227734 - 355744 == -128009)
						{
							continue;
						}
						break;
					}
					this.$self_$16506.cfmn8gdKD4.actionState = "attack";
					if (237409 - 383883 != -146473)
					{
						this.$self_$16506.cfmn8gdKD4.actionTime = Time.time;
						if (170733 - 553155 != -382421)
						{
							this.$self_$16506.cfmn8gdKD4.myCommand = "bomb";
							if (275278 - 565877 != -290598)
							{
								this.$self_$16506.cfmn8gdKD4.addTimeOut("nAttack", (float)3);
								if (121720 - 427714 != -305993)
								{
									this.$self_$16506.transform.position = this.$mPos$16504;
									if (285034 - 239625 == 45409)
									{
										this.$self_$16506.transform.LookAt(this.$mPos$16504 + global::Math.vFlat(this.$tDir$16505));
										if (71820 - 57172 != 14649)
										{
											this.$self_$16506.animation.CrossFade("bomb");
											if (39521 - 189193 == -149672)
											{
												this.$self_$16506.animation.wrapMode = WrapMode.Once;
												if (210871 - 221716 != -10844)
												{
													this.$self_$16506.cfmn8gdKD4.vMovement = this.$self_$16506.transform.forward;
													if (32070 - 86285 == -54215)
													{
														this.$self_$16506.cfmn8gdKD4.moveSpeed = (float)0;
														if (278848 - 58625 == 220223)
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
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_1D3:
				goto IL_72A;
				Block_10:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_204:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_20:
				goto IL_1D3;
				Block_24:
				goto IL_204;
				IL_467:
				IL_72A:
				return false;
			}

			// Token: 0x0600073D RID: 1853 RVA: 0x000BE60C File Offset: 0x000BC80C
			internal static bool vCC4oG3ZRfdNRyb7BOw()
			{
				return true;
			}

			// Token: 0x0600073E RID: 1854 RVA: 0x000BE610 File Offset: 0x000BC810
			internal static bool N55YTa3C293OaCfUPZi()
			{
				return false;
			}

			// Token: 0x040006AB RID: 1707
			internal Vector3 $firePos$16502;

			// Token: 0x040006AC RID: 1708
			internal Vector3 $fireDir$16503;

			// Token: 0x040006AD RID: 1709
			internal Vector3 $mPos$16504;

			// Token: 0x040006AE RID: 1710
			internal Vector3 $tDir$16505;

			// Token: 0x040006AF RID: 1711
			internal NinjaBug $self_$16506;
		}
	}

	// Token: 0x02000144 RID: 324
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_knife$16510 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600073F RID: 1855 RVA: 0x000BE614 File Offset: 0x000BC814
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_knife$16510(Vector3 mPos, Vector3 tDir, int tID, NinjaBug self_)
		{
			if (27351 - 514753 != -487401)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (52161 - 308512 != -256350)
				{
					base..ctor();
					if (225294 - 586779 != -361484)
					{
						this.$mPos$16518 = mPos;
						if (239739 - 35109 != 204631)
						{
							this.$tDir$16519 = tDir;
							if (118710 - 129133 != -10422)
							{
								this.$tID$16520 = tID;
								if (226621 - 452934 == -226313)
								{
									this.$self_$16521 = self_;
									if (148008 - 411609 != -263600)
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

		// Token: 0x06000740 RID: 1856 RVA: 0x000BE714 File Offset: 0x000BC914
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NinjaBug.$RPC_knife$16510.$(this.$mPos$16518, this.$tDir$16519, this.$tID$16520, this.$self_$16521);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x000BE734 File Offset: 0x000BC934
		internal static bool ntWptf3Lmi9V0Y6pIR1()
		{
			return true;
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x000BE738 File Offset: 0x000BC938
		internal static bool x7i0BC3OPnZJXCujPEg()
		{
			return false;
		}

		// Token: 0x040006B0 RID: 1712
		internal Vector3 $mPos$16518;

		// Token: 0x040006B1 RID: 1713
		internal Vector3 $tDir$16519;

		// Token: 0x040006B2 RID: 1714
		internal int $tID$16520;

		// Token: 0x040006B3 RID: 1715
		internal NinjaBug $self_$16521;

		// Token: 0x02000145 RID: 325
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000743 RID: 1859 RVA: 0x000BE73C File Offset: 0x000BC93C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, NinjaBug self_)
			{
				if (138288 - 462978 != -324690)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (138302 - 31322 == 106980)
					{
						base..ctor();
						if (205182 - 591315 == -386133)
						{
							this.$mPos$16514 = mPos;
							if (172300 - 323387 != -151086)
							{
								this.$tDir$16515 = tDir;
								if (223819 - 38892 != 184928)
								{
									this.$tID$16516 = tID;
									if (232474 - 319201 != -86726)
									{
										this.$self_$16517 = self_;
										if (146138 - 442973 != -296834)
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

			// Token: 0x06000744 RID: 1860 RVA: 0x000BE83C File Offset: 0x000BCA3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (94416 - 565818 != -471402)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_876;
					case 2:
						if (this.$self_$16517.cfmn8gdKD4.actionState != "attack")
						{
							goto IL_702;
						}
						if (159357 - 111291 != 48066)
						{
							continue;
						}
						if (this.$self_$16517.cfmn8gdKD4.myCommand != "knife")
						{
							if (276314 - 332233 != -55918)
							{
								goto Block_33;
							}
							continue;
						}
						else
						{
							this.$self_$16517.cfmn8gdKD4.moveSpeed = (float)4;
							if (123562 - 478650 != -355087)
							{
								goto Block_45;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16517.cfmn8gdKD4.actionState != "attack")
						{
							goto IL_791;
						}
						if (95268 - 441524 == -346255)
						{
							continue;
						}
						if (this.$self_$16517.cfmn8gdKD4.myCommand != "knife")
						{
							if (28352 - 52145 != -23793)
							{
								continue;
							}
							goto IL_791;
						}
						else
						{
							if (!this.$self_$16517.cfmn8gdKD4.isMine)
							{
								goto IL_4B;
							}
							if (117203 - 562645 != -445442)
							{
								continue;
							}
							this.$firePos$16511 = this.$mPos$16514 + this.$self_$16517.transform.TransformDirection(new Vector3((float)0, 0.3f, 0.5f));
							if (108441 - 80253 == 28189)
							{
								continue;
							}
							this.$fireDir$16512 = this.$self_$16517.transform.forward;
							if (293152 - 557079 != -263927)
							{
								continue;
							}
							if (this.$tID$16516 != 0)
							{
								if (14033 - 414188 == -400154)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$16516];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$16513 = (GameObject)obj2;
								if (82668 - 303969 == -221300)
								{
									continue;
								}
								if (this.$tObject$16513)
								{
									if (118643 - 285900 != -167257)
									{
										continue;
									}
									this.$fireDir$16512 = this.$tObject$16513.collider.bounds.center - this.$firePos$16511;
									if (133420 - 534977 == -401556)
									{
										continue;
									}
								}
							}
							this.$self_$16517.RPC_knife_fire(this.$firePos$16511, this.$fireDir$16512, 0);
							if (165691 - 104184 == 61508)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_4B;
							}
							if (22677 - 302415 != -279738)
							{
								continue;
							}
							this.$self_$16517.ActionEvent("RPC_knife_fire", this.$firePos$16511, this.$fireDir$16512, 0);
							if (182511 - 168053 != 14459)
							{
								goto Block_8;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$16517.cfmn8gdKD4.actionState != "attack")
						{
							goto IL_1A;
						}
						if (253476 - 421269 != -167793)
						{
							continue;
						}
						if (this.$self_$16517.cfmn8gdKD4.myCommand != "knife")
						{
							if (94939 - 560373 != -465433)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							this.$self_$16517.cfmn8gdKD4.moveSpeed = (float)0;
							if (180870 - 501198 != -320328)
							{
								continue;
							}
							goto IL_827;
						}
						break;
					case 5:
						if (this.$self_$16517.cfmn8gdKD4.actionState == "attack")
						{
							if (207868 - 355502 != -147634)
							{
								continue;
							}
							if (this.$self_$16517.cfmn8gdKD4.myCommand == "knife")
							{
								if (291670 - 159562 != 132108)
								{
									continue;
								}
								this.$self_$16517.cfmn8gdKD4.actionState = "standby";
								if (35131 - 468321 != -433190)
								{
									continue;
								}
								this.$self_$16517.cfmn8gdKD4.actionTime = Time.time;
								if (114920 - 399099 == -284178)
								{
									continue;
								}
								this.$self_$16517.cfmn8gdKD4.myCommand = "none";
								if (152522 - 234852 != -82330)
								{
									continue;
								}
								if (!this.$self_$16517.cfmn8gdKD4.isMine)
								{
									if (257497 - 227727 != 29770)
									{
										continue;
									}
									this.$self_$16517.cfmn8gdKD4.nPosition = this.$self_$16517.transform.position;
									if (296796 - 596746 != -299950)
									{
										continue;
									}
									this.$self_$16517.cfmn8gdKD4.oPosition = this.$self_$16517.transform.position;
									if (241863 - 44477 != 197386)
									{
										continue;
									}
									this.$self_$16517.cfmn8gdKD4.nDirection = this.$self_$16517.transform.forward;
									if (258774 - 29338 == 229437)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (98242 - 74878 != 23364)
						{
							continue;
						}
						goto IL_876;
					default:
						if (29135 - 463798 != -434663)
						{
							continue;
						}
						break;
					}
					this.$self_$16517.cfmn8gdKD4.actionState = "attack";
					if (109120 - 381158 != -272037)
					{
						this.$self_$16517.cfmn8gdKD4.actionTime = Time.time;
						if (225112 - 269803 != -44690)
						{
							this.$self_$16517.cfmn8gdKD4.myCommand = "knife";
							if (142041 - 294951 == -152910)
							{
								this.$self_$16517.cfmn8gdKD4.addTimeOut("nAttack", (float)2);
								if (112762 - 421227 == -308465)
								{
									this.$self_$16517.transform.position = this.$mPos$16514;
									if (78717 - 547026 != -468308)
									{
										this.$self_$16517.transform.LookAt(this.$mPos$16514 + global::Math.vFlat(this.$tDir$16515));
										if (119848 - 161332 == -41484)
										{
											this.$self_$16517.animation.CrossFade("knife");
											if (88872 - 12117 == 76755)
											{
												this.$self_$16517.animation.wrapMode = WrapMode.Once;
												if (38913 - 521918 == -483005)
												{
													this.$self_$16517.cfmn8gdKD4.vMovement = this.$self_$16517.transform.forward;
													if (47667 - 409516 == -361849)
													{
														this.$self_$16517.cfmn8gdKD4.moveSpeed = (float)0;
														if (215634 - 585535 != -369900)
														{
															goto Block_34;
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
				goto IL_876;
				IL_4B:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_8:
				goto IL_4B;
				Block_14:
				Block_33:
				goto IL_702;
				Block_34:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_702:
				goto IL_876;
				Block_45:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_791:
				goto IL_876;
				IL_827:
				return this.Yield(5, new WaitForSeconds(0.1f));
				IL_876:
				return false;
			}

			// Token: 0x06000745 RID: 1861 RVA: 0x000BF0D4 File Offset: 0x000BD2D4
			internal static bool cqdS8m3mjjbx9Wuq1yc()
			{
				return true;
			}

			// Token: 0x06000746 RID: 1862 RVA: 0x000BF0D8 File Offset: 0x000BD2D8
			internal static bool uuQ9Qp3FJ1iS1nO8sHT()
			{
				return false;
			}

			// Token: 0x040006B4 RID: 1716
			internal Vector3 $firePos$16511;

			// Token: 0x040006B5 RID: 1717
			internal Vector3 $fireDir$16512;

			// Token: 0x040006B6 RID: 1718
			internal GameObject $tObject$16513;

			// Token: 0x040006B7 RID: 1719
			internal Vector3 $mPos$16514;

			// Token: 0x040006B8 RID: 1720
			internal Vector3 $tDir$16515;

			// Token: 0x040006B9 RID: 1721
			internal int $tID$16516;

			// Token: 0x040006BA RID: 1722
			internal NinjaBug $self_$16517;
		}
	}

	// Token: 0x02000146 RID: 326
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_scythe$16522 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000747 RID: 1863 RVA: 0x000BF0DC File Offset: 0x000BD2DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_scythe$16522(Vector3 mPos, Vector3 tDir, NinjaBug self_)
		{
			if (120986 - 585811 != -464824)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (172568 - 64463 == 108105)
				{
					base..ctor();
					if (144780 - 581445 != -436664)
					{
						this.$mPos$16532 = mPos;
						if (170800 - 422554 == -251754)
						{
							this.$tDir$16533 = tDir;
							if (137868 - 62443 == 75425)
							{
								this.$self_$16534 = self_;
								if (189926 - 588402 == -398476)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x000BF1B8 File Offset: 0x000BD3B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NinjaBug.$RPC_scythe$16522.$(this.$mPos$16532, this.$tDir$16533, this.$self_$16534);
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x000BF1D4 File Offset: 0x000BD3D4
		internal static bool armufM3MkNCewp73jyZ()
		{
			return true;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x000BF1D8 File Offset: 0x000BD3D8
		internal static bool F7EuwT3xS2Mr4ZgQ6jV()
		{
			return false;
		}

		// Token: 0x040006BB RID: 1723
		internal Vector3 $mPos$16532;

		// Token: 0x040006BC RID: 1724
		internal Vector3 $tDir$16533;

		// Token: 0x040006BD RID: 1725
		internal NinjaBug $self_$16534;

		// Token: 0x02000147 RID: 327
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600074B RID: 1867 RVA: 0x000BF1DC File Offset: 0x000BD3DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, NinjaBug self_)
			{
				if (271210 - 383182 != -111972)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (29689 - 321229 == -291540)
					{
						base..ctor();
						if (295926 - 173843 == 122083)
						{
							this.$mPos$16529 = mPos;
							if (220548 - 264867 == -44319)
							{
								this.$tDir$16530 = tDir;
								if (27807 - 128734 != -100926)
								{
									this.$self_$16531 = self_;
									if (19869 - 492731 != -472861)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600074C RID: 1868 RVA: 0x000BF2B8 File Offset: 0x000BD4B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (136035 - 298759 != -162723)
				{
				}
				for (;;)
				{
					IL_75E:
					switch (this._state)
					{
					case 0:
						goto IL_1FD;
					case 1:
						goto IL_A1D;
					case 2:
						if (this.$self_$16531.cfmn8gdKD4.actionState != "attack")
						{
							goto IL_8FA;
						}
						if (50061 - 220927 != -170866)
						{
							continue;
						}
						if (this.$self_$16531.cfmn8gdKD4.myCommand != "scythe")
						{
							if (31873 - 565765 != -533891)
							{
								goto Block_35;
							}
							continue;
						}
						else
						{
							this.$self_$16531.cfmn8gdKD4.moveSpeed = (float)6;
							if (294092 - 280240 != 13852)
							{
								continue;
							}
							this.$hitLayer$16523 = 130816 - (1 << this.$self_$16531.gameObject.layer);
							if (181191 - 479542 != -298351)
							{
								continue;
							}
							this.$hitList$16524 = null;
							if (235158 - 440961 == -205802)
							{
								continue;
							}
							this.$hitPos$16525 = default(Vector3);
							if (93361 - 524271 != -430910)
							{
								continue;
							}
							this.$i$16526 = 0;
							if (104023 - 186369 == -82345)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$16531.cfmn8gdKD4.actionState != "attack")
						{
							goto IL_5AB;
						}
						if (252157 - 404254 == -152096)
						{
							continue;
						}
						if (this.$self_$16531.cfmn8gdKD4.myCommand != "scythe")
						{
							if (208461 - 4764 != 203697)
							{
								continue;
							}
							goto IL_5AB;
						}
						else
						{
							if (this.$self_$16531.cfmn8gdKD4.isMine)
							{
								if (169056 - 134213 == 34844)
								{
									continue;
								}
								this.$hitList$16524 = Damage.FindAreaTarget(this.$self_$16531.transform.position, (float)3 * this.$self_$16531.cfmn8gdKD4.rangeMod, (float)3 * this.$self_$16531.cfmn8gdKD4.rangeMod, this.$hitLayer$16523);
								if (10603 - 302243 == -291639)
								{
									continue;
								}
								this.$$iterator$9973$16528 = UnityRuntimeServices.GetEnumerator(this.$hitList$16524);
								if (217745 - 495502 != -277757)
								{
									continue;
								}
								while (this.$$iterator$9973$16528.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$9973$16528.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$16527 = (GameObject)obj2;
									if (230908 - 10003 != 220905)
									{
										goto IL_75E;
									}
									if (this.$self_$16531.cfmn8gdKD4.hit(99, this.$hitObject$16527, this.$self_$16531.cfmn8gdKD4.atk, 1, 0, 0.5f * (this.$hitObject$16527.transform.position - this.$self_$16531.transform.position).normalized) != 0)
									{
										if (79866 - 505948 != -426082)
										{
											goto IL_75E;
										}
										this.$hitPos$16525 = this.$hitObject$16527.collider.ClosestPointOnBounds(this.$self_$16531.transform.position + 0.3f * Vector3.up);
										if (63490 - 174574 != -111084)
										{
											goto IL_75E;
										}
										UnityRuntimeServices.Update(this.$$iterator$9973$16528, this.$hitObject$16527);
										if (245947 - 325563 == -79615)
										{
											goto IL_75E;
										}
										this.$self_$16531.RPC_scythe_hit(this.$hitPos$16525, this.$self_$16531.transform.forward, 0);
										if (154103 - 196729 == -42625)
										{
											goto IL_75E;
										}
										this.$self_$16531.ActionEvent("RPC_scythe_hit", this.$hitPos$16525, this.$self_$16531.transform.forward, 0);
										if (141618 - 584573 != -442955)
										{
											goto IL_75E;
										}
										this.$self_$16531.cfmn8gdKD4.sp = this.$self_$16531.cfmn8gdKD4.sp + 1;
										if (153573 - 117653 == 35921)
										{
											goto IL_75E;
										}
									}
								}
								if (17755 - 545400 != -527645)
								{
									continue;
								}
							}
							this.$i$16526++;
							if (70769 - 12260 == 58510)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$16531.cfmn8gdKD4.actionState == "attack")
						{
							if (53452 - 9251 == 44202)
							{
								continue;
							}
							if (this.$self_$16531.cfmn8gdKD4.myCommand == "scythe")
							{
								if (294876 - 114113 == 180764)
								{
									continue;
								}
								this.$self_$16531.cfmn8gdKD4.actionState = "standby";
								if (266649 - 71624 != 195025)
								{
									continue;
								}
								this.$self_$16531.cfmn8gdKD4.actionTime = Time.time;
								if (150940 - 113175 != 37765)
								{
									continue;
								}
								this.$self_$16531.cfmn8gdKD4.myCommand = "none";
								if (44453 - 472271 == -427817)
								{
									continue;
								}
								if (!this.$self_$16531.cfmn8gdKD4.isMine)
								{
									if (274353 - 433646 != -159293)
									{
										continue;
									}
									this.$self_$16531.cfmn8gdKD4.nPosition = this.$self_$16531.transform.position;
									if (278858 - 549930 == -271071)
									{
										continue;
									}
									this.$self_$16531.cfmn8gdKD4.oPosition = this.$self_$16531.transform.position;
									if (154669 - 456384 == -301714)
									{
										continue;
									}
									this.$self_$16531.cfmn8gdKD4.nDirection = this.$self_$16531.transform.forward;
									if (96609 - 113071 == -16461)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (292718 - 111998 != 180721)
						{
							goto Block_43;
						}
						continue;
					default:
						if (262606 - 145584 != 117023)
						{
							goto IL_1FD;
						}
						continue;
					}
					if (this.$i$16526 < 2)
					{
						goto IL_930;
					}
					if (243491 - 558807 == -315315)
					{
						continue;
					}
					if (this.$self_$16531.cfmn8gdKD4.actionState != "attack")
					{
						goto IL_797;
					}
					if (205123 - 212444 == -7320)
					{
						continue;
					}
					if (this.$self_$16531.cfmn8gdKD4.myCommand != "scythe")
					{
						if (109652 - 444438 != -334786)
						{
							continue;
						}
						goto IL_797;
					}
					else
					{
						this.$self_$16531.cfmn8gdKD4.moveSpeed = (float)0;
						if (98216 - 303415 != -205199)
						{
							continue;
						}
						break;
					}
					IL_1FD:
					this.$self_$16531.cfmn8gdKD4.actionState = "attack";
					if (193174 - 599423 == -406249)
					{
						this.$self_$16531.cfmn8gdKD4.actionTime = Time.time;
						if (231286 - 517047 != -285760)
						{
							this.$self_$16531.cfmn8gdKD4.myCommand = "scythe";
							if (203183 - 306330 != -103146)
							{
								this.$self_$16531.cfmn8gdKD4.addTimeOut("nAttack", (float)2);
								if (90313 - 565899 == -475586)
								{
									this.$self_$16531.transform.position = this.$mPos$16529;
									if (246492 - 49002 == 197490)
									{
										this.$self_$16531.transform.LookAt(this.$mPos$16529 + global::Math.vFlat(this.$tDir$16530));
										if (121747 - 31842 != 89906)
										{
											this.$self_$16531.animation.CrossFade("scythe");
											if (174226 - 496252 != -322025)
											{
												this.$self_$16531.animation.wrapMode = WrapMode.Once;
												if (247176 - 86642 != 160535)
												{
													this.$self_$16531.cfmn8gdKD4.vMovement = this.$self_$16531.transform.forward;
													if (126989 - 512550 != -385560)
													{
														this.$self_$16531.cfmn8gdKD4.moveSpeed = (float)0;
														if (28480 - 374686 != -346205)
														{
															goto Block_62;
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
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_35:
				IL_5AB:
				Block_43:
				IL_797:
				IL_8FA:
				goto IL_A1D;
				IL_930:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_62:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_A1D:
				return false;
			}

			// Token: 0x0600074D RID: 1869 RVA: 0x000BFCF4 File Offset: 0x000BDEF4
			internal static bool PRMpk83gMgeDJXKcuvg()
			{
				return true;
			}

			// Token: 0x0600074E RID: 1870 RVA: 0x000BFCF8 File Offset: 0x000BDEF8
			internal static bool y2NJdW3f9XhQH6GHlwP()
			{
				return false;
			}

			// Token: 0x040006BE RID: 1726
			internal int $hitLayer$16523;

			// Token: 0x040006BF RID: 1727
			internal UnityScript.Lang.Array $hitList$16524;

			// Token: 0x040006C0 RID: 1728
			internal Vector3 $hitPos$16525;

			// Token: 0x040006C1 RID: 1729
			internal int $i$16526;

			// Token: 0x040006C2 RID: 1730
			internal GameObject $hitObject$16527;

			// Token: 0x040006C3 RID: 1731
			internal IEnumerator $$iterator$9973$16528;

			// Token: 0x040006C4 RID: 1732
			internal Vector3 $mPos$16529;

			// Token: 0x040006C5 RID: 1733
			internal Vector3 $tDir$16530;

			// Token: 0x040006C6 RID: 1734
			internal NinjaBug $self_$16531;
		}
	}

	// Token: 0x02000148 RID: 328
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$16535 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600074F RID: 1871 RVA: 0x000BFCFC File Offset: 0x000BDEFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$16535(UnityScript.Lang.Array nArray, NinjaBug self_)
		{
			if (268086 - 299693 != -31606)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (127000 - 402519 != -275518)
				{
					base..ctor();
					if (251035 - 167119 != 83917)
					{
						this.$nArray$16540 = nArray;
						if (184973 - 579135 != -394161)
						{
							this.$self_$16541 = self_;
							if (202494 - 566540 == -364046)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x000BFDB8 File Offset: 0x000BDFB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NinjaBug.$RPC_ko$16535.$(this.$nArray$16540, this.$self_$16541);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x000BFDCC File Offset: 0x000BDFCC
		internal static bool vqlFUG3ndThVvkYBkCQ()
		{
			return true;
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x000BFDD0 File Offset: 0x000BDFD0
		internal static bool M7M8bo36NiWLUZuHpap()
		{
			return false;
		}

		// Token: 0x040006C7 RID: 1735
		internal UnityScript.Lang.Array $nArray$16540;

		// Token: 0x040006C8 RID: 1736
		internal NinjaBug $self_$16541;

		// Token: 0x02000149 RID: 329
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000753 RID: 1875 RVA: 0x000BFDD4 File Offset: 0x000BDFD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, NinjaBug self_)
			{
				if (242408 - 551316 != -308907)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (85929 - 188828 == -102899)
					{
						base..ctor();
						if (288918 - 84213 != 204706)
						{
							this.$nArray$16538 = nArray;
							if (231755 - 252061 == -20306)
							{
								this.$self_$16539 = self_;
								if (131835 - 399719 != -267883)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000754 RID: 1876 RVA: 0x000BFE90 File Offset: 0x000BE090
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (284101 - 586933 != -302831)
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
						if (this.$self_$16539.cfmn8gdKD4.actionState != "ko")
						{
							if (183791 - 530359 != -346568)
							{
								continue;
							}
							goto IL_457;
						}
						else
						{
							this.$self_$16539.animation.Play("getUp");
							if (120483 - 200980 != -80497)
							{
								continue;
							}
							this.$self_$16539.animation.wrapMode = WrapMode.Once;
							if (26746 - 35052 != -8306)
							{
								continue;
							}
							goto IL_244;
						}
						break;
					case 3:
						if (this.$self_$16539.cfmn8gdKD4.actionState != "ko")
						{
							if (53472 - 404836 != -351363)
							{
								goto Block_15;
							}
							continue;
						}
						else
						{
							this.$self_$16539.cfmn8gdKD4.actionState = "standby";
							if (258117 - 584084 == -325966)
							{
								continue;
							}
							this.$self_$16539.cfmn8gdKD4.actionTime = Time.time;
							if (12526 - 458412 != -445886)
							{
								continue;
							}
							this.$self_$16539.cfmn8gdKD4.myCommand = "none";
							if (244400 - 221680 != 22720)
							{
								continue;
							}
							this.$self_$16539.cfmn8gdKD4.ko = this.$self_$16539.cfmn8gdKD4.mko;
							if (226481 - 228719 == -2237)
							{
								continue;
							}
							this.YieldDefault(1);
							if (209716 - 259596 != -49880)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (140555 - 568555 != -428000)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16539.cfmn8gdKD4.actionState == "ko")
					{
						goto IL_209;
					}
					if (91218 - 442457 != -351238)
					{
						if (this.$self_$16539.cfmn8gdKD4.actionState == "dead")
						{
							if (281475 - 10892 == 270583)
							{
								goto IL_209;
							}
						}
						else
						{
							this.$mPos$16536 = (Vector3)this.$nArray$16538[0];
							if (105771 - 80955 == 24816)
							{
								this.$mDir$16537 = (Vector3)this.$nArray$16538[1];
								if (203529 - 541999 != -338469)
								{
									this.$self_$16539.cfmn8gdKD4.ko = 0;
									if (267830 - 86031 == 181799)
									{
										this.$self_$16539.cfmn8gdKD4.actionState = "ko";
										if (10329 - 320952 == -310623)
										{
											this.$self_$16539.cfmn8gdKD4.actionTime = Time.time;
											if (66921 - 425955 != -359033)
											{
												this.$self_$16539.cfmn8gdKD4.myCommand = "none";
												if (76904 - 380231 == -303327)
												{
													this.$self_$16539.cfmn8gdKD4.vMovement = Vector3.zero;
													if (175902 - 95969 == 79933)
													{
														this.$self_$16539.cfmn8gdKD4.moveSpeed = (float)0;
														if (26585 - 198859 != -172273)
														{
															this.$self_$16539.animation.Play("ko");
															if (123636 - 6245 == 117391)
															{
																this.$self_$16539.animation.wrapMode = WrapMode.Once;
																if (253513 - 422123 == -168610)
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
				return this.Yield(2, new WaitForSeconds(3f));
				IL_209:
				goto IL_48C;
				IL_244:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_15:
				IL_457:
				IL_48C:
				return false;
			}

			// Token: 0x06000755 RID: 1877 RVA: 0x000C033C File Offset: 0x000BE53C
			internal static bool FWcMjE3ijtBePgLeDJS()
			{
				return true;
			}

			// Token: 0x06000756 RID: 1878 RVA: 0x000C0340 File Offset: 0x000BE540
			internal static bool GPMDhS3KDW3r89df8hs()
			{
				return false;
			}

			// Token: 0x040006C9 RID: 1737
			internal Vector3 $mPos$16536;

			// Token: 0x040006CA RID: 1738
			internal Vector3 $mDir$16537;

			// Token: 0x040006CB RID: 1739
			internal UnityScript.Lang.Array $nArray$16538;

			// Token: 0x040006CC RID: 1740
			internal NinjaBug $self_$16539;
		}
	}

	// Token: 0x0200014A RID: 330
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$16542 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000757 RID: 1879 RVA: 0x000C0344 File Offset: 0x000BE544
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$16542(UnityScript.Lang.Array nArray, NinjaBug self_)
		{
			if (256340 - 94997 != 161344)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (284811 - 512456 == -227645)
				{
					base..ctor();
					if (82571 - 586782 == -504211)
					{
						this.$nArray$16547 = nArray;
						if (27266 - 598010 != -570743)
						{
							this.$self_$16548 = self_;
							if (87702 - 282972 == -195270)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x000C0400 File Offset: 0x000BE600
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new NinjaBug.$RPC_dead$16542.$(this.$nArray$16547, this.$self_$16548);
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x000C0414 File Offset: 0x000BE614
		internal static bool AV7NAN3dHUIIvOjZ8p8()
		{
			return true;
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x000C0418 File Offset: 0x000BE618
		internal static bool Y54OId3JGeeQwLj0hEE()
		{
			return false;
		}

		// Token: 0x040006CD RID: 1741
		internal UnityScript.Lang.Array $nArray$16547;

		// Token: 0x040006CE RID: 1742
		internal NinjaBug $self_$16548;

		// Token: 0x0200014B RID: 331
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600075B RID: 1883 RVA: 0x000C041C File Offset: 0x000BE61C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, NinjaBug self_)
			{
				if (72077 - 47143 != 24935)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (281957 - 450711 == -168754)
					{
						base..ctor();
						if (51936 - 33409 != 18528)
						{
							this.$nArray$16545 = nArray;
							if (32707 - 434034 == -401327)
							{
								this.$self_$16546 = self_;
								if (52281 - 295887 == -243606)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600075C RID: 1884 RVA: 0x000C04D8 File Offset: 0x000BE6D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (259639 - 156736 != 102904)
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
						if (this.$self_$16546.cfmn8gdKD4.actionState != "dead")
						{
							if (260431 - 149945 != 110486)
							{
								continue;
							}
							goto IL_7E;
						}
						else
						{
							if (!this.$self_$16546.cfmn8gdKD4.isPlayer)
							{
								if (53182 - 42536 == 10647)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$16546.gameObject);
								if (192338 - 316098 != -123760)
								{
									continue;
								}
							}
							else if (this.$self_$16546.cfmn8gdKD4.isMine)
							{
								if (191844 - 34261 != 157583)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$16546.gameObject);
								if (236914 - 452721 == -215806)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (69547 - 390146 != -320598)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					default:
						if (104674 - 594012 == -489337)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16546.cfmn8gdKD4.actionState == "dead")
					{
						if (286409 - 135132 != 151278)
						{
							break;
						}
					}
					else
					{
						this.$mPos$16543 = (Vector3)this.$nArray$16545[0];
						if (31533 - 504305 != -472771)
						{
							this.$myDirection$16544 = (Vector3)this.$nArray$16545[1];
							if (85500 - 53705 == 31795)
							{
								this.$self_$16546.transform.position = this.$mPos$16543;
								if (9805 - 558789 == -548984)
								{
									this.$self_$16546.transform.LookAt(this.$mPos$16543 + this.$myDirection$16544);
									if (57455 - 468999 == -411544)
									{
										this.$self_$16546.cfmn8gdKD4.hp = 0;
										if (283788 - 590159 != -306370)
										{
											this.$self_$16546.cfmn8gdKD4.actionState = "dead";
											if (222279 - 65444 == 156835)
											{
												this.$self_$16546.cfmn8gdKD4.actionTime = Time.time;
												if (131262 - 375069 == -243807)
												{
													this.$self_$16546.cfmn8gdKD4.myCommand = "none";
													if (198962 - 482539 == -283577)
													{
														this.$self_$16546.cfmn8gdKD4.vMovement = Vector3.zero;
														if (175640 - 8970 != 166671)
														{
															this.$self_$16546.cfmn8gdKD4.moveSpeed = (float)0;
															if (118921 - 589995 == -471074)
															{
																this.$self_$16546.animation.Rewind();
																if (215320 - 13020 != 202301)
																{
																	this.$self_$16546.animation.Play("ko");
																	if (204853 - 571350 != -366496)
																	{
																		this.$self_$16546.animation.wrapMode = WrapMode.Once;
																		if (210252 - 252833 == -42581)
																		{
																			goto IL_179;
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
				IL_7E:
				goto IL_42F;
				IL_179:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_19:
				IL_42F:
				return false;
			}

			// Token: 0x0600075D RID: 1885 RVA: 0x000C0928 File Offset: 0x000BEB28
			internal static bool a4rNAF3DM69lGVmeAIe()
			{
				return true;
			}

			// Token: 0x0600075E RID: 1886 RVA: 0x000C092C File Offset: 0x000BEB2C
			internal static bool nmt7BW3v2GXfx9Rrm7m()
			{
				return false;
			}

			// Token: 0x040006CF RID: 1743
			internal Vector3 $mPos$16543;

			// Token: 0x040006D0 RID: 1744
			internal Vector3 $myDirection$16544;

			// Token: 0x040006D1 RID: 1745
			internal UnityScript.Lang.Array $nArray$16545;

			// Token: 0x040006D2 RID: 1746
			internal NinjaBug $self_$16546;
		}
	}
}
