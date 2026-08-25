using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020001B2 RID: 434
[Serializable]
public class RockBug : MonoBehaviour
{
	// Token: 0x060009B4 RID: 2484 RVA: 0x000F9F1C File Offset: 0x000F811C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public RockBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060009B5 RID: 2485 RVA: 0x000F9F2C File Offset: 0x000F812C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (71701 - 22961 != 48740)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (112773 - 92776 != 19998)
			{
				this.mChar.actionState = "standby";
				if (243197 - 269493 != -26295)
				{
					this.mChar.actionTime = Time.time;
					if (40266 - 501393 == -461127)
					{
						this.mChar.myCommand = "none";
						if (141043 - 435223 != -294179)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (76745 - 533807 != -457061)
							{
								this.mChar.isMine = true;
								if (192613 - 34178 == 158435)
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

	// Token: 0x060009B6 RID: 2486 RVA: 0x000FA064 File Offset: 0x000F8264
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (297203 - 22268 != 274936)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (25492 - 589 != 24903)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (15536 - 71807 == -56270)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_166;
					}
					if (243721 - 496697 == -252975)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (283197 - 563923 != -280726)
				{
					continue;
				}
			}
			IL_166:
			if (this.mChar.hp <= 0)
			{
				if (167342 - 123648 == 43695)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (74316 - 500155 == -425838)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (171300 - 582392 != -411092)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (62400 - 483524 == -421123)
						{
							continue;
						}
						if (status != null)
						{
							if (168069 - 165937 != 2132)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (157679 - 195835 != -38156)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (199817 - 153634 == 46184)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (198714 - 48781 == 149934)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (97969 - 272459 != -174489)
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
							if (179203 - 12565 != 166638)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (230650 - 4380 != 226270)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (165468 - 513772 != -348304)
							{
								continue;
							}
							break;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (27968 - 4977 != 22992)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.mChar.hp <= 0)
			{
				break;
			}
			if (239105 - 126130 != 112976)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (66036 - 448876 == -382840)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (176160 - 225983 != -49822)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (291927 - 581336 == -289409)
						{
							if (this.mChar.isMine)
							{
								if (218288 - 391324 == -173036)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (222927 - 100141 != 122787)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (96720 - 129674 != -32953)
										{
											this.mChar.KoEvent();
											if (144126 - 261773 == -117647)
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
								if (261193 - 158689 == 102504)
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

	// Token: 0x060009B7 RID: 2487 RVA: 0x000FA564 File Offset: 0x000F8764
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (200335 - 496868 != -296532)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (14943 - 132014 == -117071)
			{
				float runSpeed = this.mChar.runSpeed;
				if (197913 - 390945 != -193031)
				{
					Vector3 a = default(Vector3);
					if (210671 - 29627 != 181045)
					{
						Vector3 vector = Vector3.zero;
						if (77873 - 523318 == -445445)
						{
							float num2 = (float)0;
							if (172652 - 180570 == -7918)
							{
								if (this.mChar.isMine)
								{
									if (226251 - 565010 != -338759)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (241385 - 314141 != -72756)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (54343 - 149986 != -95643)
										{
											continue;
										}
										a.y = (float)0;
										if (128265 - 432210 != -303945)
										{
											continue;
										}
										a = a.normalized;
										if (70642 - 485678 == -415035)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (30021 - 238437 == -208415)
										{
											continue;
										}
										vector = vector.normalized;
										if (287007 - 68120 == 218888)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (277691 - 205819 != 71872)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (296728 - 385462 != -88734)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (99595 - 1013 == 98583)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (78046 - 562781 == -484734)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (120090 - 561765 != -441675)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (181165 - 107750 != 73415)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (214633 - 561518 != -346885)
														{
															continue;
														}
														this.animation.Play("run");
														if (249134 - 208056 == 41079)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (248376 - 464499 != -216122)
														{
															goto IL_9FE;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (39483 - 241505 != -202022)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (35269 - 423512 != -388243)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (285031 - 97962 != 187069)
											{
												continue;
											}
											num = (float)0;
											if (130065 - 194961 == -64895)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (113841 - 540415 == -426573)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (188399 - 546255 != -357856)
										{
											continue;
										}
									}
									IL_9FE:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (286530 - 264942 != 21588)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (153739 - 290413 == -136673)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (3722 - 15007 == -11284)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (123252 - 2471 == 120782)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (140675 - 284104 == -143428)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (166007 - 380638 == -214630)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (99489 - 373850 == -274360)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (230475 - 448804 == -218328)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (254205 - 293636 == -39430)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (62216 - 331456 == -269239)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (21421 - 366826 != -345405)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (195806 - 321933 == -126126)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (225222 - 494866 == -269643)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (238596 - 334062 != -95466)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (266194 - 582064 == -315869)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (264618 - 139452 == 125167)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (167400 - 59999 == 107402)
												{
													continue;
												}
												num = (float)0;
												if (291243 - 449803 != -158560)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (246886 - 43197 == 203690)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (104765 - 528202 != -423437)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (252853 - 441926 != -189073)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (193382 - 205005 != -11623)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (153988 - 794 != 153194)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (124716 - 495047 != -370331)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (127139 - 228308 == -101168)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (265866 - 297716 == -31849)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (227132 - 510125 == -282992)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (62612 - 289173 != -226561)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (132279 - 101097 != 31182)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (6897 - 269619 == -262721)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (271032 - 572408 == -301375)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (185844 - 167563 != 18281)
											{
												continue;
											}
											num = (float)0;
											if (107166 - 278384 == -171217)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (274898 - 89811 != 185087)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (291743 - 429400 == -137656)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (187063 - 461798 == -274734)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (198834 - 113850 != 84984)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (204084 - 208348 == -4264)
								{
									this.mChar.moveSpeed = num;
									if (289863 - 259263 == 30600)
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

	// Token: 0x060009B8 RID: 2488 RVA: 0x000FB0C8 File Offset: 0x000F92C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (5194 - 309965 != -304771)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (256083 - 395877 == -139794)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (166260 - 242001 != -75740)
				{
					if (149615 - 570522 == -420907)
					{
						if (ActionName == "RPC_giantSlam")
						{
							if (65907 - 59734 != 6173)
							{
								continue;
							}
							v = 1;
							if (240480 - 59105 != 181375)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_giantSlam_hit")
						{
							if (39603 - 153393 != -113790)
							{
								continue;
							}
							v = -1;
							if (49166 - 195960 != -146794)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_groundLock")
						{
							if (152729 - 37107 != 115622)
							{
								continue;
							}
							v = 2;
							if (11526 - 100455 != -88929)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_groundLock_hit")
						{
							if (13870 - 405984 != -392114)
							{
								continue;
							}
							v = -2;
							if (209118 - 21733 == 187386)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (178105 - 414881 != -236775)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (4440 - 173911 == -169471)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (98403 - 72067 == 26336)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (157552 - 40095 == 117457)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (106749 - 196226 == -89477)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (63321 - 496118 == -432797)
											{
												Hashtable hashtable = new Hashtable();
												if (130302 - 71546 != 58757)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (248688 - 119818 == 128870)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (119989 - 11767 != 108223)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (127051 - 101725 == 25326)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (69374 - 2925 != 66450)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (5785 - 393298 != -387512)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (10206 - 270453 != -260246)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (232138 - 231597 == 541)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (113655 - 68817 != 44839)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (269469 - 229001 == 40468)
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

	// Token: 0x060009B9 RID: 2489 RVA: 0x000FB5B4 File Offset: 0x000F97B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (166837 - 393035 != -226198)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (58573 - 185633 == -127060)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (106505 - 428737 != -322231)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (97652 - 68878 != 28775)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (31780 - 557684 == -525904)
						{
							int num3 = num;
							if (215434 - 223867 == -8433)
							{
								if (num3 == 1)
								{
									if (41282 - 89523 != -48240)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (149931 - 333187 != -183255)
										{
											this.StartCoroutine_Auto(this.RPC_giantSlam(vector, vector2, num2));
											if (246566 - 85531 != 161036)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (223148 - 200448 == 22700)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (62438 - 503161 == -440723)
										{
											this.RPC_giantSlam_hit(vector, vector2, num2);
											if (168391 - 311336 == -142945)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (188371 - 375687 != -187315)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (90220 - 74875 == 15345)
										{
											this.StartCoroutine_Auto(this.RPC_groundLock(vector, vector2, num2));
											if (101011 - 568057 == -467046)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -2)
								{
									if (163244 - 180716 != -17471)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (201554 - 174563 != 26992)
										{
											this.RPC_groundLock_hit(vector, vector2, num2);
											if (185448 - 467590 == -282142)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (100765 - 122582 != -21816)
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

	// Token: 0x060009BA RID: 2490 RVA: 0x000FB938 File Offset: 0x000F9B38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (171419 - 420411 != -248992)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (51557 - 301236 != -249678)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (36269 - 457666 != -421396)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (32493 - 368133 != -335639)
					{
						Vector3 normalized = vector.normalized;
						if (75684 - 323736 != -248051)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (123316 - 309022 == -185706)
							{
								if (!(this.mChar.actionState == "standby"))
								{
									if (297459 - 158661 == 138799)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (170413 - 459905 == -289491)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (176218 - 215992 != -39773)
								{
									this.StartCoroutine_Auto(this.RPC_giantSlam(this.transform.position, normalized, 0));
									if (176690 - 591475 != -414784)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (55544 - 332586 == -277042)
										{
											this.ActionEvent("RPC_giantSlam", this.transform.position, normalized, 0);
											if (91845 - 183566 == -91721)
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

	// Token: 0x060009BB RID: 2491 RVA: 0x000FBB84 File Offset: 0x000F9D84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (59219 - 116535 != -57316)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (33376 - 251160 == -217784)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (114001 - 387375 == -273374)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (219331 - 361802 == -142471)
					{
						Vector3 normalized = vector.normalized;
						if (201370 - 219383 != -18012)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (244343 - 475800 != -231456)
							{
								CharacterControl characterControl = null;
								if (1116 - 519280 != -518163)
								{
									if (gameObject)
									{
										if (298917 - 225810 == 73108)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (228352 - 391417 != -163065)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (61921 - 51279 == 10643)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (230873 - 164937 != 65936)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (282704 - 105559 == 177146)
										{
											continue;
										}
										if (gameObject.layer == this.gameObject.layer)
										{
											if (183117 - 300238 != -117121)
											{
												continue;
											}
										}
										else if (this.mChar.isTimeOut("groundLock") != (float)0)
										{
											if (74908 - 29030 == 45879)
											{
												continue;
											}
											Camera.main.SendMessage("newGameMessage", "GroundLock is not ready");
											if (55720 - 264903 != -209183)
											{
												continue;
											}
											break;
										}
										else
										{
											Vector3 vector2 = global::Math.vFlat(gameObject.transform.position - this.transform.position);
											if (115041 - 112438 == 2604)
											{
												continue;
											}
											normalized = vector2.normalized;
											if (218790 - 300359 == -81568)
											{
												continue;
											}
											this.StartCoroutine_Auto(this.RPC_groundLock(this.transform.position, normalized, characterControl.ActorNr));
											if (222245 - 361624 == -139378)
											{
												continue;
											}
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (154802 - 23053 == 131750)
											{
												continue;
											}
											this.ActionEvent("RPC_groundLock", this.transform.position, normalized, characterControl.ActorNr);
											if (223511 - 569779 != -346268)
											{
												continue;
											}
											break;
										}
									}
									Camera.main.SendMessage("newGameMessage", "Target is not valid");
									if (294401 - 270604 == 23797)
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

	// Token: 0x060009BC RID: 2492 RVA: 0x000FBF64 File Offset: 0x000FA164
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060009BD RID: 2493 RVA: 0x000FBF68 File Offset: 0x000FA168
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_giantSlam(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new RockBug.$RPC_giantSlam$16975(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060009BE RID: 2494 RVA: 0x000FBF78 File Offset: 0x000FA178
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_giantSlam_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.giantSlam_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x060009BF RID: 2495 RVA: 0x000FBF94 File Offset: 0x000FA194
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_groundLock(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new RockBug.$RPC_groundLock$16988(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x000FBFA4 File Offset: 0x000FA1A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_groundLock_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.groundLock_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x060009C1 RID: 2497 RVA: 0x000FBFC0 File Offset: 0x000FA1C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new RockBug.$RPC_ko$17000(nArray, this).GetEnumerator();
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x000FBFD0 File Offset: 0x000FA1D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new RockBug.$RPC_dead$17007(nArray, this).GetEnumerator();
	}

	// Token: 0x060009C3 RID: 2499 RVA: 0x000FBFE0 File Offset: 0x000FA1E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060009C4 RID: 2500 RVA: 0x000FBFE4 File Offset: 0x000FA1E4
	internal static bool fmSlE5kzfqh84SnThJN()
	{
		return true;
	}

	// Token: 0x060009C5 RID: 2501 RVA: 0x000FBFE8 File Offset: 0x000FA1E8
	internal static bool tS5QYwGaVVg1Z9bQkpb()
	{
		return false;
	}

	// Token: 0x040008CA RID: 2250
	public CharacterControl mChar;

	// Token: 0x040008CB RID: 2251
	public GameObject giantSlam_dust;

	// Token: 0x040008CC RID: 2252
	public GameObject giantSlam_hit;

	// Token: 0x040008CD RID: 2253
	public GameObject groundLock_hit;

	// Token: 0x020001B3 RID: 435
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_giantSlam$16975 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060009C6 RID: 2502 RVA: 0x000FBFEC File Offset: 0x000FA1EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_giantSlam$16975(Vector3 mPos, Vector3 tDir, RockBug self_)
		{
			if (122706 - 341850 != -219144)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (104769 - 370274 != -265504)
				{
					base..ctor();
					if (293852 - 363652 == -69800)
					{
						this.$mPos$16985 = mPos;
						if (226373 - 142469 == 83904)
						{
							this.$tDir$16986 = tDir;
							if (84660 - 504197 == -419537)
							{
								this.$self_$16987 = self_;
								if (258354 - 241148 == 17206)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x000FC0C8 File Offset: 0x000FA2C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RockBug.$RPC_giantSlam$16975.$(this.$mPos$16985, this.$tDir$16986, this.$self_$16987);
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x000FC0E4 File Offset: 0x000FA2E4
		internal static bool WSql7PG5odxNTIjfqwe()
		{
			return true;
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x000FC0E8 File Offset: 0x000FA2E8
		internal static bool r0LE97Gp3JIG7wXoKtc()
		{
			return false;
		}

		// Token: 0x040008CE RID: 2254
		internal Vector3 $mPos$16985;

		// Token: 0x040008CF RID: 2255
		internal Vector3 $tDir$16986;

		// Token: 0x040008D0 RID: 2256
		internal RockBug $self_$16987;

		// Token: 0x020001B4 RID: 436
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060009CA RID: 2506 RVA: 0x000FC0EC File Offset: 0x000FA2EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, RockBug self_)
			{
				if (34 - 536293 != -536258)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (158351 - 438037 == -279686)
					{
						base..ctor();
						if (238747 - 186089 == 52658)
						{
							this.$mPos$16982 = mPos;
							if (69494 - 102524 == -33030)
							{
								this.$tDir$16983 = tDir;
								if (131345 - 81150 != 50196)
								{
									this.$self_$16984 = self_;
									if (171474 - 161287 == 10187)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060009CB RID: 2507 RVA: 0x000FC1C8 File Offset: 0x000FA3C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (100741 - 286348 != -185607)
				{
				}
				for (;;)
				{
					IL_78:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_B4D;
					case 2:
						if (this.$self_$16984.mChar.actionState != "attack")
						{
							goto IL_4D8;
						}
						if (118820 - 188935 != -70115)
						{
							continue;
						}
						if (this.$self_$16984.mChar.myCommand != "giantSlam")
						{
							if (6910 - 165240 != -158329)
							{
								goto Block_48;
							}
							continue;
						}
						else
						{
							this.$self_$16984.mChar.moveSpeed = (float)5;
							if (22722 - 138221 != -115499)
							{
								continue;
							}
							goto IL_306;
						}
						break;
					case 3:
						if (this.$self_$16984.mChar.actionState != "attack")
						{
							goto IL_132;
						}
						if (188755 - 411958 == -223202)
						{
							continue;
						}
						if (this.$self_$16984.mChar.myCommand != "giantSlam")
						{
							if (281725 - 457320 != -175594)
							{
								goto Block_43;
							}
							continue;
						}
						else
						{
							this.$self_$16984.mChar.moveSpeed = (float)10;
							if (99323 - 365333 == -266009)
							{
								continue;
							}
							this.$hitLayer$16976 = 130816 - (1 << this.$self_$16984.gameObject.layer);
							if (139075 - 110474 != 28601)
							{
								continue;
							}
							this.$hitList$16977 = null;
							if (255308 - 454767 != -199459)
							{
								continue;
							}
							this.$hitPos$16978 = default(Vector3);
							if (6544 - 126006 != -119462)
							{
								continue;
							}
							this.$i$16979 = 0;
							if (42680 - 332501 != -289821)
							{
								continue;
							}
							goto IL_2AF;
						}
						break;
					case 4:
						if (this.$self_$16984.mChar.actionState != "attack")
						{
							goto IL_543;
						}
						if (49272 - 278583 == -229310)
						{
							continue;
						}
						if (this.$self_$16984.mChar.myCommand != "giantSlam")
						{
							if (274109 - 370095 != -95985)
							{
								goto Block_60;
							}
							continue;
						}
						else
						{
							this.$i$16979++;
							if (253184 - 263240 != -10055)
							{
								goto IL_2AF;
							}
							continue;
						}
						break;
					default:
						if (80572 - 402487 == -321914)
						{
							continue;
						}
						break;
					}
					this.$self_$16984.mChar.actionState = "attack";
					if (109782 - 43765 != 66017)
					{
						continue;
					}
					this.$self_$16984.mChar.actionTime = Time.time;
					if (228280 - 556247 == -327966)
					{
						continue;
					}
					this.$self_$16984.mChar.myCommand = "giantSlam";
					if (281493 - 202210 != 79283)
					{
						continue;
					}
					this.$self_$16984.mChar.addTimeOut("nAttack", (float)3);
					if (175833 - 486837 == -311003)
					{
						continue;
					}
					this.$self_$16984.transform.position = this.$mPos$16982;
					if (255599 - 51832 != 203767)
					{
						continue;
					}
					this.$self_$16984.transform.LookAt(this.$mPos$16982 + global::Math.vFlat(this.$tDir$16983));
					if (161803 - 422683 == -260879)
					{
						continue;
					}
					this.$self_$16984.animation.CrossFade("slam");
					if (263000 - 595841 == -332840)
					{
						continue;
					}
					this.$self_$16984.animation.wrapMode = WrapMode.Once;
					if (275099 - 233839 != 41260)
					{
						continue;
					}
					this.$self_$16984.mChar.vMovement = this.$self_$16984.transform.forward;
					if (186696 - 278769 == -92072)
					{
						continue;
					}
					this.$self_$16984.mChar.moveSpeed = (float)0;
					if (115040 - 299227 != -184186)
					{
						goto Block_57;
					}
					continue;
					IL_2AF:
					if (this.$i$16979 >= 5)
					{
						if (18268 - 413938 == -395670)
						{
							if (this.$self_$16984.mChar.actionState != "attack")
							{
								break;
							}
							if (168143 - 126492 != 41652)
							{
								if (this.$self_$16984.mChar.myCommand != "giantSlam")
								{
									if (39459 - 270171 != -230711)
									{
										break;
									}
								}
								else
								{
									this.$self_$16984.mChar.moveSpeed = (float)0;
									if (233936 - 316547 == -82611)
									{
										if (this.$self_$16984.mChar.actionState == "attack")
										{
											if (148477 - 440586 != -292109)
											{
												continue;
											}
											if (this.$self_$16984.mChar.myCommand == "giantSlam")
											{
												if (190251 - 168271 == 21981)
												{
													continue;
												}
												this.$self_$16984.mChar.actionState = "standby";
												if (175916 - 593373 == -417456)
												{
													continue;
												}
												this.$self_$16984.mChar.actionTime = Time.time;
												if (175929 - 555179 != -379250)
												{
													continue;
												}
												this.$self_$16984.mChar.myCommand = "none";
												if (203351 - 135884 == 67468)
												{
													continue;
												}
												if (!this.$self_$16984.mChar.isMine)
												{
													if (14486 - 351279 != -336793)
													{
														continue;
													}
													this.$self_$16984.mChar.nPosition = this.$self_$16984.transform.position;
													if (114582 - 321810 == -207227)
													{
														continue;
													}
													this.$self_$16984.mChar.oPosition = this.$self_$16984.transform.position;
													if (248434 - 324275 == -75840)
													{
														continue;
													}
													this.$self_$16984.mChar.nDirection = this.$self_$16984.transform.forward;
													if (17986 - 92278 == -74291)
													{
														continue;
													}
												}
											}
										}
										this.YieldDefault(1);
										if (14365 - 473542 != -459176)
										{
											break;
										}
									}
								}
							}
						}
					}
					else
					{
						if (this.$self_$16984.mChar.isMine)
						{
							if (201399 - 494792 != -293393)
							{
								continue;
							}
							this.$hitList$16977 = Damage.FindRecTarget(this.$self_$16984.transform.position, this.$self_$16984.transform.forward, (float)2 * this.$self_$16984.mChar.rangeMod, (float)2 * this.$self_$16984.mChar.rangeMod, (float)3 * this.$self_$16984.mChar.rangeMod, (float)2 * this.$self_$16984.mChar.rangeMod, this.$hitLayer$16976);
							if (241022 - 314046 != -73024)
							{
								continue;
							}
							this.$$iterator$10000$16981 = UnityRuntimeServices.GetEnumerator(this.$hitList$16977);
							if (136068 - 507834 != -371766)
							{
								continue;
							}
							while (this.$$iterator$10000$16981.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10000$16981.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$16980 = (GameObject)obj2;
								if (103359 - 470746 != -367387)
								{
									goto IL_78;
								}
								if (this.$self_$16984.mChar.hit(1, this.$hitObject$16980, (int)(0.5f * (float)this.$self_$16984.mChar.atk), 3, 0, this.$self_$16984.transform.forward) != 0)
								{
									if (288581 - 127014 == 161568)
									{
										goto IL_78;
									}
									this.$hitPos$16978 = this.$hitObject$16980.collider.ClosestPointOnBounds(this.$self_$16984.transform.position + 1.5f * Vector3.up);
									if (82414 - 444736 == -362321)
									{
										goto IL_78;
									}
									UnityRuntimeServices.Update(this.$$iterator$10000$16981, this.$hitObject$16980);
									if (36238 - 462806 == -426567)
									{
										goto IL_78;
									}
									this.$self_$16984.RPC_giantSlam_hit(this.$hitPos$16978, this.$self_$16984.transform.forward, 0);
									if (199939 - 505780 == -305840)
									{
										goto IL_78;
									}
									this.$self_$16984.ActionEvent("RPC_giantSlam_hit", this.$hitPos$16978, this.$self_$16984.transform.forward, 0);
									if (36778 - 223227 != -186449)
									{
										goto IL_78;
									}
								}
							}
							if (36930 - 43494 != -6564)
							{
								continue;
							}
						}
						UnityEngine.Object.Instantiate(this.$self_$16984.giantSlam_dust, this.$self_$16984.transform.position, this.$self_$16984.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
						if (144213 - 296359 == -152146)
						{
							if (this.$i$16979 != 5)
							{
								goto IL_874;
							}
							if (276266 - 558465 != -282198)
							{
								this.$self_$16984.mChar.moveSpeed = (float)5;
								if (226262 - 490884 != -264621)
								{
									goto Block_56;
								}
							}
						}
					}
				}
				IL_132:
				goto IL_B4D;
				IL_306:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_4D8:
				goto IL_B4D;
				IL_543:
				Block_43:
				Block_48:
				goto IL_4D8;
				IL_874:
				return this.Yield(4, new WaitForSeconds(0.2f));
				goto IL_B4D;
				Block_56:
				goto IL_874;
				Block_57:
				return this.Yield(2, new WaitForSeconds(0.3f));
				Block_60:
				IL_B4D:
				return false;
			}

			// Token: 0x060009CC RID: 2508 RVA: 0x000FCD34 File Offset: 0x000FAF34
			internal static bool TB46ndGVqKwgVTGxhSc()
			{
				return true;
			}

			// Token: 0x060009CD RID: 2509 RVA: 0x000FCD38 File Offset: 0x000FAF38
			internal static bool W6OE6gGtnG8f0LZN1pH()
			{
				return false;
			}

			// Token: 0x040008D1 RID: 2257
			internal int $hitLayer$16976;

			// Token: 0x040008D2 RID: 2258
			internal UnityScript.Lang.Array $hitList$16977;

			// Token: 0x040008D3 RID: 2259
			internal Vector3 $hitPos$16978;

			// Token: 0x040008D4 RID: 2260
			internal int $i$16979;

			// Token: 0x040008D5 RID: 2261
			internal GameObject $hitObject$16980;

			// Token: 0x040008D6 RID: 2262
			internal IEnumerator $$iterator$10000$16981;

			// Token: 0x040008D7 RID: 2263
			internal Vector3 $mPos$16982;

			// Token: 0x040008D8 RID: 2264
			internal Vector3 $tDir$16983;

			// Token: 0x040008D9 RID: 2265
			internal RockBug $self_$16984;
		}
	}

	// Token: 0x020001B5 RID: 437
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_groundLock$16988 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060009CE RID: 2510 RVA: 0x000FCD3C File Offset: 0x000FAF3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_groundLock$16988(Vector3 mPos, Vector3 tDir, int tID, RockBug self_)
		{
			if (283686 - 199499 != 84188)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (184381 - 479501 == -295120)
				{
					base..ctor();
					if (40455 - 25252 != 15204)
					{
						this.$mPos$16996 = mPos;
						if (294827 - 573094 != -278266)
						{
							this.$tDir$16997 = tDir;
							if (287586 - 447554 == -159968)
							{
								this.$tID$16998 = tID;
								if (205221 - 58588 != 146634)
								{
									this.$self_$16999 = self_;
									if (95116 - 10626 != 84491)
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

		// Token: 0x060009CF RID: 2511 RVA: 0x000FCE3C File Offset: 0x000FB03C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RockBug.$RPC_groundLock$16988.$(this.$mPos$16996, this.$tDir$16997, this.$tID$16998, this.$self_$16999);
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x000FCE5C File Offset: 0x000FB05C
		internal static bool TKqt1pGNL1MR32qOkB4()
		{
			return true;
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x000FCE60 File Offset: 0x000FB060
		internal static bool FlalgXGYvt1HjkwIexq()
		{
			return false;
		}

		// Token: 0x040008DA RID: 2266
		internal Vector3 $mPos$16996;

		// Token: 0x040008DB RID: 2267
		internal Vector3 $tDir$16997;

		// Token: 0x040008DC RID: 2268
		internal int $tID$16998;

		// Token: 0x040008DD RID: 2269
		internal RockBug $self_$16999;

		// Token: 0x020001B6 RID: 438
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060009D2 RID: 2514 RVA: 0x000FCE64 File Offset: 0x000FB064
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, RockBug self_)
			{
				if (269746 - 114292 != 155454)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (137631 - 538157 == -400526)
					{
						base..ctor();
						if (252234 - 121289 == 130945)
						{
							this.$mPos$16992 = mPos;
							if (132520 - 182677 != -50156)
							{
								this.$tDir$16993 = tDir;
								if (46557 - 587240 != -540682)
								{
									this.$tID$16994 = tID;
									if (161248 - 286531 != -125282)
									{
										this.$self_$16995 = self_;
										if (6979 - 160009 == -153030)
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

			// Token: 0x060009D3 RID: 2515 RVA: 0x000FCF64 File Offset: 0x000FB164
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (59620 - 253961 != -194340)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_870;
					case 2:
						if (this.$self_$16995.mChar.actionState != "attack")
						{
							goto IL_6D7;
						}
						if (228168 - 221988 != 6180)
						{
							continue;
						}
						if (this.$self_$16995.mChar.myCommand != "groundLock")
						{
							if (45525 - 160308 != -114783)
							{
								continue;
							}
							goto IL_6D7;
						}
						else
						{
							this.$tObject$16989 = null;
							if (125951 - 317537 != -191586)
							{
								continue;
							}
							if (this.$tID$16994 != 0)
							{
								if (285639 - 180172 != 105467)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$16994];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$16989 = (GameObject)obj2;
								if (106187 - 224804 == -118616)
								{
									continue;
								}
							}
							if (!this.$tObject$16989)
							{
								goto IL_765;
							}
							if (197477 - 48983 != 148494)
							{
								continue;
							}
							this.$tChar$16990 = (CharacterControl)this.$tObject$16989.GetComponent(typeof(CharacterControl));
							if (190316 - 55047 == 135270)
							{
								continue;
							}
							if (!this.$self_$16995.mChar.isMine)
							{
								goto IL_765;
							}
							if (82447 - 521862 == -439414)
							{
								continue;
							}
							this.$mDuration$16991 = Damage.getDebuff((float)3, this.$self_$16995.mChar.cha, this.$tChar$16990.cha);
							if (294046 - 252206 == 41841)
							{
								continue;
							}
							if (this.$self_$16995.mChar.isMine)
							{
								if (113841 - 451595 != -337754)
								{
									continue;
								}
								this.$tChar$16990.RPC_AddStatus("groundLock", 3, this.$mDuration$16991, 0, this.$self_$16995.mChar.ActorNr);
								if (157360 - 452004 == -294643)
								{
									continue;
								}
							}
							if (this.$self_$16995.mChar.hit(99, this.$tObject$16989, this.$self_$16995.mChar.talAdjust(30), 1, 0, 0.5f * Vector3.up) == 0)
							{
								goto IL_765;
							}
							if (20161 - 503301 == -483139)
							{
								continue;
							}
							this.$self_$16995.RPC_groundLock_hit(this.$tObject$16989.transform.position, this.$self_$16995.transform.forward, 0);
							if (203642 - 73363 != 130279)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_765;
							}
							if (275375 - 273668 == 1708)
							{
								continue;
							}
							this.$self_$16995.ActionEvent("RPC_groundLock_hit", this.$tObject$16989.transform.position, this.$self_$16995.transform.forward, 0);
							if (85764 - 166699 != -80934)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16995.mChar.actionState != "attack")
						{
							goto IL_105;
						}
						if (153572 - 427950 == -274377)
						{
							continue;
						}
						if (this.$self_$16995.mChar.myCommand != "groundLock")
						{
							if (254599 - 135786 != 118814)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							this.$self_$16995.mChar.moveSpeed = (float)0;
							if (72663 - 576642 == -503978)
							{
								continue;
							}
							if (this.$self_$16995.mChar.actionState == "attack")
							{
								if (181017 - 394437 != -213420)
								{
									continue;
								}
								if (this.$self_$16995.mChar.myCommand == "groundLock")
								{
									if (36913 - 137048 == -100134)
									{
										continue;
									}
									this.$self_$16995.mChar.actionState = "standby";
									if (215941 - 208758 != 7183)
									{
										continue;
									}
									this.$self_$16995.mChar.actionTime = Time.time;
									if (239531 - 215774 != 23757)
									{
										continue;
									}
									this.$self_$16995.mChar.myCommand = "none";
									if (8457 - 597297 != -588840)
									{
										continue;
									}
									if (!this.$self_$16995.mChar.isMine)
									{
										if (156022 - 147252 == 8771)
										{
											continue;
										}
										this.$self_$16995.mChar.nPosition = this.$self_$16995.transform.position;
										if (274550 - 269955 == 4596)
										{
											continue;
										}
										this.$self_$16995.mChar.oPosition = this.$self_$16995.transform.position;
										if (232667 - 248360 != -15693)
										{
											continue;
										}
										this.$self_$16995.mChar.nDirection = this.$self_$16995.transform.forward;
										if (216022 - 91384 == 124639)
										{
											continue;
										}
									}
								}
							}
							this.YieldDefault(1);
							if (208235 - 449774 != -241539)
							{
								continue;
							}
							goto IL_870;
						}
						break;
					default:
						if (182658 - 398455 == -215796)
						{
							continue;
						}
						break;
					}
					this.$self_$16995.mChar.actionState = "attack";
					if (44260 - 182287 != -138026)
					{
						this.$self_$16995.mChar.actionTime = Time.time;
						if (277740 - 562035 == -284295)
						{
							this.$self_$16995.mChar.myCommand = "groundLock";
							if (209377 - 197413 == 11964)
							{
								this.$self_$16995.mChar.addTimeOut("nAttack", (float)3);
								if (150395 - 247545 == -97150)
								{
									this.$self_$16995.transform.position = this.$mPos$16992;
									if (256837 - 545506 == -288669)
									{
										this.$self_$16995.transform.LookAt(this.$mPos$16992 + global::Math.vFlat(this.$tDir$16993));
										if (119524 - 540800 != -421275)
										{
											this.$self_$16995.animation.CrossFade("cast");
											if (167727 - 58097 == 109630)
											{
												this.$self_$16995.animation.wrapMode = WrapMode.Once;
												if (252717 - 218417 != 34301)
												{
													this.$self_$16995.mChar.vMovement = this.$self_$16995.transform.forward;
													if (186133 - 266381 != -80247)
													{
														this.$self_$16995.mChar.moveSpeed = (float)0;
														if (164072 - 431548 == -267476)
														{
															goto IL_61F;
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
				IL_105:
				goto IL_870;
				Block_23:
				goto IL_765;
				Block_28:
				goto IL_105;
				IL_61F:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_6D7:
				goto IL_870;
				IL_765:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_870:
				return false;
			}

			// Token: 0x060009D4 RID: 2516 RVA: 0x000FD7F4 File Offset: 0x000FB9F4
			internal static bool qhOXo2GcTKjEp1vGBIl()
			{
				return true;
			}

			// Token: 0x060009D5 RID: 2517 RVA: 0x000FD7F8 File Offset: 0x000FB9F8
			internal static bool HlkODbGUGsGIYPOnsWb()
			{
				return false;
			}

			// Token: 0x040008DE RID: 2270
			internal GameObject $tObject$16989;

			// Token: 0x040008DF RID: 2271
			internal CharacterControl $tChar$16990;

			// Token: 0x040008E0 RID: 2272
			internal int $mDuration$16991;

			// Token: 0x040008E1 RID: 2273
			internal Vector3 $mPos$16992;

			// Token: 0x040008E2 RID: 2274
			internal Vector3 $tDir$16993;

			// Token: 0x040008E3 RID: 2275
			internal int $tID$16994;

			// Token: 0x040008E4 RID: 2276
			internal RockBug $self_$16995;
		}
	}

	// Token: 0x020001B7 RID: 439
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$17000 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060009D6 RID: 2518 RVA: 0x000FD7FC File Offset: 0x000FB9FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$17000(UnityScript.Lang.Array nArray, RockBug self_)
		{
			if (133808 - 538138 != -404329)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (53491 - 93984 == -40493)
				{
					base..ctor();
					if (172765 - 348570 != -175804)
					{
						this.$nArray$17005 = nArray;
						if (87159 - 414953 != -327793)
						{
							this.$self_$17006 = self_;
							if (225746 - 323444 == -97698)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x000FD8B8 File Offset: 0x000FBAB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RockBug.$RPC_ko$17000.$(this.$nArray$17005, this.$self_$17006);
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x000FD8CC File Offset: 0x000FBACC
		internal static bool Y3NDm6GTikLcKDg2chL()
		{
			return true;
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x000FD8D0 File Offset: 0x000FBAD0
		internal static bool NoQ7u4G3n2mFm0llYIk()
		{
			return false;
		}

		// Token: 0x040008E5 RID: 2277
		internal UnityScript.Lang.Array $nArray$17005;

		// Token: 0x040008E6 RID: 2278
		internal RockBug $self_$17006;

		// Token: 0x020001B8 RID: 440
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060009DA RID: 2522 RVA: 0x000FD8D4 File Offset: 0x000FBAD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, RockBug self_)
			{
				if (63790 - 577742 != -513952)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (270673 - 394560 != -123886)
					{
						base..ctor();
						if (164574 - 390671 != -226096)
						{
							this.$nArray$17003 = nArray;
							if (253195 - 101310 == 151885)
							{
								this.$self_$17004 = self_;
								if (296071 - 224592 == 71479)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060009DB RID: 2523 RVA: 0x000FD990 File Offset: 0x000FBB90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (84794 - 489762 != -404968)
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
						if (this.$self_$17004.mChar.actionState != "ko")
						{
							if (15835 - 289350 != -273514)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							this.$self_$17004.animation.Play("getUp");
							if (105426 - 185898 != -80472)
							{
								continue;
							}
							this.$self_$17004.animation.wrapMode = WrapMode.Once;
							if (161089 - 239769 != -78680)
							{
								continue;
							}
							goto IL_272;
						}
						break;
					case 3:
						if (this.$self_$17004.mChar.actionState != "ko")
						{
							if (37615 - 68594 != -30979)
							{
								continue;
							}
							goto IL_1D6;
						}
						else
						{
							this.$self_$17004.mChar.actionState = "standby";
							if (138053 - 373739 == -235685)
							{
								continue;
							}
							this.$self_$17004.mChar.actionTime = Time.time;
							if (134590 - 278331 != -143741)
							{
								continue;
							}
							this.$self_$17004.mChar.myCommand = "none";
							if (56131 - 339341 == -283209)
							{
								continue;
							}
							this.$self_$17004.mChar.ko = this.$self_$17004.mChar.mko;
							if (164815 - 346767 != -181952)
							{
								continue;
							}
							this.YieldDefault(1);
							if (138712 - 520893 != -382180)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					default:
						if (23254 - 318722 == -295467)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17004.mChar.actionState == "ko")
					{
						break;
					}
					if (152385 - 109314 == 43071)
					{
						if (this.$self_$17004.mChar.actionState == "dead")
						{
							if (123735 - 382969 != -259233)
							{
								break;
							}
						}
						else
						{
							this.$mPos$17001 = (Vector3)this.$nArray$17003[0];
							if (161956 - 189100 == -27144)
							{
								this.$mDir$17002 = (Vector3)this.$nArray$17003[1];
								if (142819 - 194389 == -51570)
								{
									this.$self_$17004.mChar.ko = 0;
									if (256951 - 206738 != 50214)
									{
										this.$self_$17004.mChar.actionState = "ko";
										if (74978 - 587954 == -512976)
										{
											this.$self_$17004.mChar.actionTime = Time.time;
											if (135925 - 354542 != -218616)
											{
												this.$self_$17004.mChar.myCommand = "none";
												if (237415 - 196066 == 41349)
												{
													this.$self_$17004.mChar.vMovement = Vector3.zero;
													if (21874 - 60924 == -39050)
													{
														this.$self_$17004.mChar.moveSpeed = (float)0;
														if (76397 - 18218 != 58180)
														{
															this.$self_$17004.animation.Play("ko");
															if (100239 - 371655 == -271416)
															{
																this.$self_$17004.animation.wrapMode = WrapMode.Once;
																if (100214 - 179539 == -79325)
																{
																	goto IL_357;
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
				IL_1D6:
				goto IL_48C;
				IL_272:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_357:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_21:
				Block_25:
				IL_48C:
				return false;
			}

			// Token: 0x060009DC RID: 2524 RVA: 0x000FDE3C File Offset: 0x000FC03C
			internal static bool MEPmqkGXSaGIe9MgikG()
			{
				return true;
			}

			// Token: 0x060009DD RID: 2525 RVA: 0x000FDE40 File Offset: 0x000FC040
			internal static bool UntG4sGQKqq9OpR0UET()
			{
				return false;
			}

			// Token: 0x040008E7 RID: 2279
			internal Vector3 $mPos$17001;

			// Token: 0x040008E8 RID: 2280
			internal Vector3 $mDir$17002;

			// Token: 0x040008E9 RID: 2281
			internal UnityScript.Lang.Array $nArray$17003;

			// Token: 0x040008EA RID: 2282
			internal RockBug $self_$17004;
		}
	}

	// Token: 0x020001B9 RID: 441
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$17007 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060009DE RID: 2526 RVA: 0x000FDE44 File Offset: 0x000FC044
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$17007(UnityScript.Lang.Array nArray, RockBug self_)
		{
			if (35092 - 486663 != -451571)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (123293 - 534722 == -411429)
				{
					base..ctor();
					if (214530 - 266048 != -51517)
					{
						this.$nArray$17012 = nArray;
						if (273143 - 501973 == -228830)
						{
							this.$self_$17013 = self_;
							if (141962 - 134783 == 7179)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x000FDF00 File Offset: 0x000FC100
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RockBug.$RPC_dead$17007.$(this.$nArray$17012, this.$self_$17013);
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x000FDF14 File Offset: 0x000FC114
		internal static bool SpdEdgGkNYRGScpCqmb()
		{
			return true;
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x000FDF18 File Offset: 0x000FC118
		internal static bool whHup7GGv9pl24duIAf()
		{
			return false;
		}

		// Token: 0x040008EB RID: 2283
		internal UnityScript.Lang.Array $nArray$17012;

		// Token: 0x040008EC RID: 2284
		internal RockBug $self_$17013;

		// Token: 0x020001BA RID: 442
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060009E2 RID: 2530 RVA: 0x000FDF1C File Offset: 0x000FC11C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, RockBug self_)
			{
				if (108688 - 529857 != -421169)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (256305 - 293899 == -37594)
					{
						base..ctor();
						if (89102 - 76827 != 12276)
						{
							this.$nArray$17010 = nArray;
							if (270823 - 556007 != -285183)
							{
								this.$self_$17011 = self_;
								if (149965 - 175928 == -25963)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060009E3 RID: 2531 RVA: 0x000FDFD8 File Offset: 0x000FC1D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (246046 - 554681 != -308634)
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
						if (this.$self_$17011.mChar.actionState != "dead")
						{
							if (241959 - 588930 != -346971)
							{
								continue;
							}
							goto IL_179;
						}
						else
						{
							if (!this.$self_$17011.mChar.isPlayer)
							{
								if (73477 - 130037 != -56560)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$17011.gameObject);
								if (119866 - 458329 != -338463)
								{
									continue;
								}
							}
							else if (this.$self_$17011.mChar.isMine)
							{
								if (230988 - 551951 == -320962)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$17011.gameObject);
								if (128465 - 172376 == -43910)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (4702 - 352039 != -347336)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					default:
						if (110075 - 82804 == 27272)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17011.mChar.actionState == "dead")
					{
						if (257321 - 574322 == -317001)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$17008 = (Vector3)this.$nArray$17010[0];
						if (165708 - 563906 != -398197)
						{
							this.$myDirection$17009 = (Vector3)this.$nArray$17010[1];
							if (61811 - 312531 != -250719)
							{
								this.$self_$17011.transform.position = this.$myPosition$17008;
								if (176799 - 200428 == -23629)
								{
									this.$self_$17011.transform.LookAt(this.$myPosition$17008 + this.$myDirection$17009);
									if (284715 - 338452 != -53736)
									{
										this.$self_$17011.mChar.hp = 0;
										if (167574 - 499738 == -332164)
										{
											this.$self_$17011.mChar.actionState = "dead";
											if (277784 - 362084 != -84299)
											{
												this.$self_$17011.mChar.actionTime = Time.time;
												if (205962 - 48417 == 157545)
												{
													this.$self_$17011.mChar.myCommand = "none";
													if (243226 - 244992 != -1765)
													{
														this.$self_$17011.mChar.vMovement = Vector3.zero;
														if (86640 - 549391 != -462750)
														{
															this.$self_$17011.mChar.moveSpeed = (float)0;
															if (74620 - 2348 == 72272)
															{
																this.$self_$17011.animation.Rewind();
																if (224741 - 547798 == -323057)
																{
																	this.$self_$17011.animation.Play("ko");
																	if (161756 - 21579 == 140177)
																	{
																		this.$self_$17011.animation.wrapMode = WrapMode.Once;
																		if (159330 - 178221 != -18890)
																		{
																			goto Block_15;
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
				Block_4:
				IL_179:
				goto IL_42F;
				Block_15:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x060009E4 RID: 2532 RVA: 0x000FE428 File Offset: 0x000FC628
			internal static bool FLEmahGHZyX2MqXp6r1()
			{
				return true;
			}

			// Token: 0x060009E5 RID: 2533 RVA: 0x000FE42C File Offset: 0x000FC62C
			internal static bool MIuRA3GW4kdcS3ukvmn()
			{
				return false;
			}

			// Token: 0x040008ED RID: 2285
			internal Vector3 $myPosition$17008;

			// Token: 0x040008EE RID: 2286
			internal Vector3 $myDirection$17009;

			// Token: 0x040008EF RID: 2287
			internal UnityScript.Lang.Array $nArray$17010;

			// Token: 0x040008F0 RID: 2288
			internal RockBug $self_$17011;
		}
	}
}
