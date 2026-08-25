using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000249 RID: 585
[Serializable]
public class WormBug : MonoBehaviour
{
	// Token: 0x06000D4E RID: 3406 RVA: 0x00152574 File Offset: 0x00150774
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WormBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000D4F RID: 3407 RVA: 0x00152584 File Offset: 0x00150784
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (136988 - 341782 != -204794)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (169722 - 471085 == -301363)
			{
				this.mChar.actionState = "standby";
				if (109776 - 258287 == -148511)
				{
					this.mChar.actionTime = Time.time;
					if (245254 - 536405 != -291150)
					{
						this.mChar.myCommand = "none";
						if (256990 - 183365 != 73626)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06000D50 RID: 3408 RVA: 0x00152670 File Offset: 0x00150870
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (243329 - 137899 != 105431)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (42244 - 477578 == -435333)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (209560 - 575129 == -365568)
				{
					continue;
				}
			}
			Transform transform = this.transform.Find("WormBug_tri");
			if (159072 - 404873 != -245800)
			{
				if (!transform)
				{
					break;
				}
				if (8527 - 262046 != -253518)
				{
					Physics.IgnoreCollision(this.gameObject.collider, transform.collider, true);
					if (254055 - 544317 != -290261)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000D51 RID: 3409 RVA: 0x00152778 File Offset: 0x00150978
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (40293 - 565201 != -524908)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (207425 - 303015 != -95590)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (222688 - 22244 == 200445)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_35B;
					}
					if (129571 - 546999 != -417428)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (140552 - 343082 == -202529)
				{
					continue;
				}
			}
			IL_35B:
			if (this.mChar.hp <= 0)
			{
				if (271078 - 37915 == 233164)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (212901 - 516168 != -303267)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (163729 - 206244 != -42515)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (243555 - 597100 == -353544)
						{
							continue;
						}
						if (status != null)
						{
							if (199331 - 469215 == -269883)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (153317 - 554050 == -400732)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (257043 - 592727 != -335684)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (18529 - 249941 == -231411)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (111444 - 109711 != 1733)
							{
								continue;
							}
							break;
						}
						else
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (64162 - 383843 == -319680)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (182268 - 397931 != -215663)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (141282 - 403090 != -261807)
							{
								break;
							}
							continue;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (145834 - 283228 != -137393)
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
			if (79417 - 410425 != -331007)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (174960 - 565748 != -390787)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (134565 - 305922 == -171357)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (60693 - 527785 != -467091)
						{
							if (this.mChar.isMine)
							{
								if (1657 - 240791 != -239133)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (180416 - 472898 != -292481)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (277829 - 491157 != -213327)
										{
											this.mChar.KoEvent();
											if (52705 - 241678 != -188972)
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
								if (259041 - 143771 == 115270)
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

	// Token: 0x06000D52 RID: 3410 RVA: 0x00152C78 File Offset: 0x00150E78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (96711 - 215858 != -119147)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (240345 - 390847 != -150501)
			{
				float runSpeed = this.mChar.runSpeed;
				if (92558 - 151611 != -59052)
				{
					Vector3 a = default(Vector3);
					if (206480 - 75937 == 130543)
					{
						Vector3 vector = Vector3.zero;
						if (64378 - 46881 == 17497)
						{
							float num2 = (float)0;
							if (22950 - 213490 != -190539)
							{
								if (this.mChar.isMine)
								{
									if (102520 - 544298 == -441777)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (149928 - 471892 == -321963)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (226507 - 140819 != 85688)
										{
											continue;
										}
										a.y = (float)0;
										if (177957 - 69635 == 108323)
										{
											continue;
										}
										a = a.normalized;
										if (107046 - 52378 != 54668)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (84949 - 498580 != -413631)
										{
											continue;
										}
										vector = vector.normalized;
										if (135895 - 491499 == -355603)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (128626 - 395164 != -266538)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (115138 - 59233 != 55905)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (45033 - 165904 == -120870)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (202944 - 541912 == -338967)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (44564 - 537025 != -492461)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (136453 - 245167 != -108714)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (258555 - 106542 != 152013)
														{
															continue;
														}
														this.animation.Play("run");
														if (149364 - 421421 != -272057)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (28782 - 484603 != -455820)
														{
															goto IL_5C9;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (218247 - 523442 == -305194)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (241194 - 341198 == -100003)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (242121 - 333982 != -91861)
											{
												continue;
											}
											num = (float)0;
											if (89896 - 231948 != -142052)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (206953 - 186353 == 20601)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (272605 - 350837 != -78232)
										{
											continue;
										}
									}
									IL_5C9:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (226609 - 500941 != -274332)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (145195 - 166001 != -20806)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (255072 - 354781 == -99708)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (229723 - 205208 == 24516)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (105532 - 379133 == -273600)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (177627 - 381132 != -203505)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (101963 - 215328 == -113364)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (295237 - 448056 == -152818)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (164107 - 24955 == 139153)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (253706 - 59384 != 194322)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (57286 - 38784 == 18503)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (271975 - 473938 != -201963)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (278523 - 423815 != -145292)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (192196 - 99858 != 92338)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (140007 - 517526 == -377518)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (282323 - 184129 == 98195)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (241776 - 251080 != -9304)
												{
													continue;
												}
												num = (float)0;
												if (184767 - 499890 == -315122)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (182963 - 208604 != -25641)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (72089 - 394964 != -322875)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (133487 - 254680 != -121193)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (208624 - 317012 != -108388)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (239979 - 174503 != 65476)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (214767 - 131290 != 83477)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (153786 - 41344 != 112442)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (122046 - 113196 == 8851)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (268386 - 378119 == -109732)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (109220 - 355695 != -246475)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (181265 - 213758 != -32493)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (259951 - 127485 != 132466)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (46424 - 228949 != -182525)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (135877 - 432478 == -296600)
											{
												continue;
											}
											num = (float)0;
											if (64485 - 493672 != -429187)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (35620 - 41110 == -5489)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (38760 - 48719 != -9959)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (251243 - 255486 == -4242)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (228542 - 119110 == 109433)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (30693 - 578732 != -548038)
								{
									this.mChar.moveSpeed = num;
									if (298585 - 254463 != 44123)
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

	// Token: 0x06000D53 RID: 3411 RVA: 0x001537DC File Offset: 0x001519DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (154689 - 494177 != -339487)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (196483 - 79395 == 117088)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (125659 - 373777 != -248117)
				{
					if (196587 - 63745 == 132842)
					{
						if (ActionName == "RPC_multipleBites")
						{
							if (285112 - 217874 == 67239)
							{
								continue;
							}
							v = 1;
							if (205020 - 4417 != 200603)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_multipleBites_hit")
						{
							if (230268 - 562899 != -332631)
							{
								continue;
							}
							v = -1;
							if (181435 - 390351 != -208916)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_emeralSpit")
						{
							if (171314 - 341907 == -170592)
							{
								continue;
							}
							v = 11;
							if (127182 - 299015 == -171832)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_emeralSpit_fire")
						{
							if (7674 - 187857 != -180183)
							{
								continue;
							}
							v = 12;
							if (192089 - 451198 != -259109)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_emeralSpit_hit")
						{
							if (130840 - 358526 != -227686)
							{
								continue;
							}
							v = -11;
							if (76017 - 63903 == 12115)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_poisonSpit")
						{
							if (237171 - 281322 == -44150)
							{
								continue;
							}
							v = 21;
							if (131908 - 405187 == -273278)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_poisonSpit_fire")
						{
							if (135970 - 289953 != -153983)
							{
								continue;
							}
							v = 22;
							if (37080 - 194987 != -157907)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_poisonSpit_hit")
						{
							if (229233 - 598592 != -369359)
							{
								continue;
							}
							v = -21;
							if (196841 - 306929 == -110087)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (58968 - 189517 != -130548)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (224797 - 4810 != 219988)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (249636 - 575038 == -325402)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (98547 - 408589 == -310042)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (90091 - 393184 == -303093)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (264238 - 396451 == -132213)
											{
												Hashtable hashtable = new Hashtable();
												if (172932 - 410609 != -237676)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (245458 - 482398 != -236939)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (27910 - 254904 == -226994)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (35863 - 300580 != -264716)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (53752 - 527744 == -473992)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (143680 - 386594 == -242914)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (165747 - 107742 != 58006)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (46353 - 99451 != -53097)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (253172 - 334410 == -81238)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (186350 - 50923 == 135427)
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

	// Token: 0x06000D54 RID: 3412 RVA: 0x00153DF8 File Offset: 0x00151FF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (45124 - 510788 != -465664)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (34372 - 130810 != -96437)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (51034 - 346183 == -295149)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (200748 - 537062 != -336313)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (254118 - 6183 == 247935)
						{
							int num3 = num;
							if (218504 - 399527 == -181023)
							{
								if (num3 == 1)
								{
									if (85087 - 198048 == -112961)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (89402 - 506453 != -417050)
										{
											this.StartCoroutine_Auto(this.RPC_multipleBites(vector, vector2, num2));
											if (14830 - 46161 == -31331)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (6758 - 124569 != -117810)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (70233 - 70110 == 123)
										{
											this.RPC_multipleBites_hit(vector, vector2, num2);
											if (59128 - 291355 != -232226)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (45447 - 417427 != -371979)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (14208 - 251493 == -237285)
										{
											this.StartCoroutine_Auto(this.RPC_emeralSpit(vector, vector2, num2));
											if (151346 - 267260 != -115913)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 12)
								{
									if (91299 - 598742 != -507442)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (19224 - 64748 == -45524)
										{
											this.RPC_emeralSpit_fire(vector, vector2, num2);
											if (276817 - 455608 != -178790)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (43771 - 273642 == -229871)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (238388 - 145579 == 92809)
										{
											this.RPC_emeralSpit_hit(vector, vector2, num2);
											if (232295 - 246668 != -14372)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (65205 - 147137 == -81932)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (68598 - 112367 == -43769)
										{
											this.StartCoroutine_Auto(this.RPC_poisonSpit(vector, vector2, num2));
											if (109043 - 102463 != 6581)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 22)
								{
									if (152341 - 436714 == -284373)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (114471 - 68272 != 46200)
										{
											this.RPC_poisonSpit_fire(vector, vector2, num2);
											if (167716 - 359774 != -192057)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -21)
								{
									if (133749 - 32849 == 100900)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (124950 - 22749 == 102201)
										{
											this.RPC_poisonSpit_hit(vector, vector2, num2);
											if (91747 - 513798 != -422050)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (170806 - 326457 != -155650)
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

	// Token: 0x06000D55 RID: 3413 RVA: 0x00154358 File Offset: 0x00152558
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (75906 - 521579 != -445672)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (266466 - 332178 != -65711)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (243537 - 134081 != 109457)
				{
					Vector3 vector = a - this.transform.position;
					if (55505 - 253480 != -197974)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (230252 - 139 == 230113)
						{
							if (!(this.mChar.actionState == "standby"))
							{
								if (273395 - 578296 == -304900)
								{
									continue;
								}
								if (!(this.mChar.actionState == "run"))
								{
									break;
								}
								if (74765 - 428844 != -354079)
								{
									continue;
								}
							}
							if (this.mChar.isTimeOut("nAttack") != (float)0)
							{
								break;
							}
							if (276351 - 412846 == -136495)
							{
								this.StartCoroutine_Auto(this.RPC_multipleBites(this.transform.position, vector, 0));
								if (45418 - 156315 == -110897)
								{
									if (!PhotonClient.IsInitialized())
									{
										break;
									}
									if (116147 - 171111 == -54964)
									{
										this.ActionEvent("RPC_multipleBites", this.transform.position, vector, 0);
										if (236222 - 178135 == 58087)
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

	// Token: 0x06000D56 RID: 3414 RVA: 0x0015457C File Offset: 0x0015277C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (268045 - 356127 != -88081)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (192754 - 360964 != -168209)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (210337 - 469392 == -259055)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (119771 - 120869 != -1097)
					{
						Vector3 normalized = vector.normalized;
						if (5502 - 466702 == -461200)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (253249 - 182025 != 71225)
							{
								CharacterControl characterControl = null;
								if (252440 - 505282 == -252842)
								{
									if (gameObject)
									{
										if (150369 - 12596 != 137773)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (201323 - 408364 == -207040)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (275991 - 70461 == 205531)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (41303 - 491981 == -450677)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (192987 - 264681 == -71693)
										{
											continue;
										}
										if (gameObject.layer == this.gameObject.layer)
										{
											if (15591 - 524481 != -508890)
											{
												continue;
											}
										}
										else if (this.mChar.isTimeOut("spit") != (float)0)
										{
											if (86251 - 16149 == 70103)
											{
												continue;
											}
											Camera.main.SendMessage("newGameMessage", "Spit is not ready");
											if (286115 - 255725 != 30390)
											{
												continue;
											}
											break;
										}
										else
										{
											Vector3 vector2 = global::Math.vFlat(gameObject.transform.position - this.transform.position);
											if (177005 - 197358 == -20352)
											{
												continue;
											}
											normalized = vector2.normalized;
											if (253065 - 62776 != 190289)
											{
												continue;
											}
											if (this.mType == eWormBugType.normal)
											{
												if (131751 - 147330 != -15579)
												{
													continue;
												}
												this.StartCoroutine_Auto(this.RPC_emeralSpit(this.transform.position, normalized, characterControl.ActorNr));
												if (48513 - 123918 == -75404)
												{
													continue;
												}
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (148584 - 283450 != -134866)
												{
													continue;
												}
												this.ActionEvent("RPC_emeralSpit", this.transform.position, normalized, characterControl.ActorNr);
												if (187454 - 423954 != -236500)
												{
													continue;
												}
												break;
											}
											else
											{
												this.StartCoroutine_Auto(this.RPC_poisonSpit(this.transform.position, normalized, characterControl.ActorNr));
												if (188886 - 340268 == -151381)
												{
													continue;
												}
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (161373 - 223747 == -62373)
												{
													continue;
												}
												this.ActionEvent("RPC_poisonSpit", this.transform.position, normalized, characterControl.ActorNr);
												if (187376 - 417537 != -230161)
												{
													continue;
												}
												break;
											}
										}
									}
									Camera.main.SendMessage("newGameMessage", "Target is not valid");
									if (237527 - 394077 == -156550)
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

	// Token: 0x06000D57 RID: 3415 RVA: 0x00154A1C File Offset: 0x00152C1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000D58 RID: 3416 RVA: 0x00154A20 File Offset: 0x00152C20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_multipleBites(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new WormBug.$RPC_multipleBites$17534(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000D59 RID: 3417 RVA: 0x00154A30 File Offset: 0x00152C30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_multipleBites_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.multipleBites_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x06000D5A RID: 3418 RVA: 0x00154A4C File Offset: 0x00152C4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_emeralSpit(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new WormBug.$RPC_emeralSpit$17548(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06000D5B RID: 3419 RVA: 0x00154A5C File Offset: 0x00152C5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_emeralSpit_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (173806 - 285913 != -112107)
		{
		}
		for (;;)
		{
			if (!this.wnjIUArdmt)
			{
				if (232690 - 505809 != -273119)
				{
					continue;
				}
				this.wnjIUArdmt = (GameObject)Resources.Load("GameAssets/Characters/Bugs/WormBug/Effects/emeralSpit", typeof(GameObject));
				if (6959 - 155481 == -148521)
				{
					continue;
				}
			}
			if (this.wnjIUArdmt)
			{
				if (225466 - 164024 == 61442)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.wnjIUArdmt, firePos, Quaternion.LookRotation(fireDir));
					if (61752 - 513722 == -451970)
					{
						ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
						if (225717 - 238579 != -12861)
						{
							projectileControl.Init(this.mChar.ActorNr);
							if (122693 - 180951 != -58257)
							{
								projectileControl.life = (float)2 * this.mChar.rangeMod;
								if (295551 - 5388 != 290164)
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
				Debug.LogError("Cannot find emeralSpit Effect");
				if (205264 - 564304 == -359040)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000D5C RID: 3420 RVA: 0x00154C08 File Offset: 0x00152E08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_emeralSpit_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (111585 - 490388 != -378803)
		{
		}
		for (;;)
		{
			if (!this.HFFINHPw3h)
			{
				if (36443 - 301816 == -265372)
				{
					continue;
				}
				this.HFFINHPw3h = (GameObject)Resources.Load("GameAssets/Characters/Bugs/WormBug/Effects/emeralGoo", typeof(GameObject));
				if (230236 - 42498 != 187738)
				{
					continue;
				}
			}
			if (this.HFFINHPw3h)
			{
				if (98378 - 96492 == 1886)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.HFFINHPw3h, hitPos, this.transform.rotation);
					if (166918 - 161218 != 5701)
					{
						WormBug_emeralGoo wormBug_emeralGoo = (WormBug_emeralGoo)gameObject.GetComponent("WormBug_emeralGoo");
						if (252744 - 92246 != 160499)
						{
							wormBug_emeralGoo.Initialize(this.mChar.ActorNr);
							if (196403 - 54087 != 142317)
							{
								break;
							}
						}
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find emeralGoo Effect");
				if (182290 - 590397 == -408107)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000D5D RID: 3421 RVA: 0x00154D84 File Offset: 0x00152F84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_poisonSpit(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new WormBug.$RPC_poisonSpit$17563(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06000D5E RID: 3422 RVA: 0x00154D94 File Offset: 0x00152F94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_poisonSpit_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (179861 - 105524 != 74337)
		{
		}
		for (;;)
		{
			if (!this.U8AIEsZVSn)
			{
				if (8341 - 162957 != -154616)
				{
					continue;
				}
				this.U8AIEsZVSn = (GameObject)Resources.Load("GameAssets/Characters/Bugs/WormBug/Effects/poisonSpit", typeof(GameObject));
				if (166710 - 290383 == -123672)
				{
					continue;
				}
			}
			if (this.U8AIEsZVSn)
			{
				if (46037 - 437476 != -391438)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.U8AIEsZVSn, firePos, Quaternion.LookRotation(fireDir));
					if (267958 - 311820 == -43862)
					{
						ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
						if (2841 - 388258 != -385416)
						{
							projectileControl.Init(this.mChar.ActorNr);
							if (73036 - 207824 != -134787)
							{
								projectileControl.life = (float)2 * this.mChar.rangeMod;
								if (298703 - 205440 == 93263)
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
				Debug.LogError("Cannot find poisonSpit Effect");
				if (224957 - 235312 != -10354)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000D5F RID: 3423 RVA: 0x00154F40 File Offset: 0x00153140
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_poisonSpit_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (276423 - 233500 != 42923)
		{
		}
		for (;;)
		{
			if (!this.gqGIPo1YT2)
			{
				if (218609 - 216101 == 2509)
				{
					continue;
				}
				this.gqGIPo1YT2 = (GameObject)Resources.Load("GameAssets/Characters/Bugs/WormBug/Effects/poisonGoo", typeof(GameObject));
				if (155698 - 222118 == -66419)
				{
					continue;
				}
			}
			if (this.gqGIPo1YT2)
			{
				if (255157 - 436697 == -181540)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.gqGIPo1YT2, hitPos, this.transform.rotation);
					if (168005 - 319227 == -151222)
					{
						WormBug_poisonGoo wormBug_poisonGoo = (WormBug_poisonGoo)gameObject.GetComponent("WormBug_poisonGoo");
						if (92476 - 100091 == -7615)
						{
							wormBug_poisonGoo.Initialize(this.mChar.ActorNr);
							if (167549 - 335285 != -167735)
							{
								break;
							}
						}
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find poisonGoo Effect");
				if (139865 - 122758 != 17108)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000D60 RID: 3424 RVA: 0x001550BC File Offset: 0x001532BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new WormBug.$RPC_ko$17578(nArray, this).GetEnumerator();
	}

	// Token: 0x06000D61 RID: 3425 RVA: 0x001550CC File Offset: 0x001532CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new WormBug.$RPC_dead$17585(nArray, this).GetEnumerator();
	}

	// Token: 0x06000D62 RID: 3426 RVA: 0x001550DC File Offset: 0x001532DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000D63 RID: 3427 RVA: 0x001550E0 File Offset: 0x001532E0
	internal static bool OcysRLle3eJdw5twLmJ()
	{
		return true;
	}

	// Token: 0x06000D64 RID: 3428 RVA: 0x001550E4 File Offset: 0x001532E4
	internal static bool HwWhD8lr1atdJGMgDAB()
	{
		return false;
	}

	// Token: 0x04000B90 RID: 2960
	public CharacterControl mChar;

	// Token: 0x04000B91 RID: 2961
	public eWormBugType mType;

	// Token: 0x04000B92 RID: 2962
	public GameObject multipleBites_hit;

	// Token: 0x04000B93 RID: 2963
	private GameObject wnjIUArdmt;

	// Token: 0x04000B94 RID: 2964
	private GameObject HFFINHPw3h;

	// Token: 0x04000B95 RID: 2965
	private GameObject U8AIEsZVSn;

	// Token: 0x04000B96 RID: 2966
	private GameObject gqGIPo1YT2;

	// Token: 0x04000B97 RID: 2967
	public GameObject koEffect;

	// Token: 0x0200024A RID: 586
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_multipleBites$17534 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000D65 RID: 3429 RVA: 0x001550E8 File Offset: 0x001532E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_multipleBites$17534(Vector3 mPos, Vector3 tDir, WormBug self_)
		{
			if (213093 - 65258 != 147835)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (4446 - 3628 == 818)
				{
					base..ctor();
					if (250393 - 332789 == -82396)
					{
						this.$mPos$17545 = mPos;
						if (259618 - 193526 == 66092)
						{
							this.$tDir$17546 = tDir;
							if (214515 - 148153 != 66363)
							{
								this.$self_$17547 = self_;
								if (48724 - 571798 == -523074)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x001551C4 File Offset: 0x001533C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WormBug.$RPC_multipleBites$17534.$(this.$mPos$17545, this.$tDir$17546, this.$self_$17547);
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x001551E0 File Offset: 0x001533E0
		internal static bool VOuu08ljPsMKXqVYGRd()
		{
			return true;
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x001551E4 File Offset: 0x001533E4
		internal static bool H0KNRelhab9g8Om9MHS()
		{
			return false;
		}

		// Token: 0x04000B98 RID: 2968
		internal Vector3 $mPos$17545;

		// Token: 0x04000B99 RID: 2969
		internal Vector3 $tDir$17546;

		// Token: 0x04000B9A RID: 2970
		internal WormBug $self_$17547;

		// Token: 0x0200024B RID: 587
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000D69 RID: 3433 RVA: 0x001551E8 File Offset: 0x001533E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, WormBug self_)
			{
				if (199493 - 116301 != 83193)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (75989 - 125056 == -49067)
					{
						base..ctor();
						if (11104 - 319969 == -308865)
						{
							this.$mPos$17542 = mPos;
							if (268282 - 83126 != 185157)
							{
								this.$tDir$17543 = tDir;
								if (151093 - 74869 == 76224)
								{
									this.$self_$17544 = self_;
									if (263488 - 53836 == 209652)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000D6A RID: 3434 RVA: 0x001552C4 File Offset: 0x001534C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (286052 - 71499 != 214553)
				{
				}
				for (;;)
				{
					IL_95B:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_BC0;
					case 2:
						if (this.$self_$17544.mChar.actionState != "attack")
						{
							if (148146 - 99977 != 48170)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							this.$hitLayer$17535 = 130816 - (1 << this.$self_$17544.gameObject.layer);
							if (284572 - 500301 == -215728)
							{
								continue;
							}
							this.$hitList$17536 = null;
							if (54776 - 268070 != -213294)
							{
								continue;
							}
							this.$hitPos$17537 = default(Vector3);
							if (45436 - 581702 == -536265)
							{
								continue;
							}
							if (!this.$self_$17544.mChar.isMine)
							{
								goto IL_644;
							}
							if (4746 - 32238 != -27492)
							{
								continue;
							}
							this.$hitList$17536 = Damage.FindRecTarget(this.$self_$17544.transform.position, this.$self_$17544.transform.forward, (float)1 * this.$self_$17544.mChar.rangeMod, (float)1 * this.$self_$17544.mChar.rangeMod, (float)4 * this.$self_$17544.mChar.rangeMod, (float)2 * this.$self_$17544.mChar.rangeMod, this.$hitLayer$17535);
							if (113457 - 7180 == 106278)
							{
								continue;
							}
							this.$$iterator$10043$17539 = UnityRuntimeServices.GetEnumerator(this.$hitList$17536);
							if (110990 - 430187 == -319196)
							{
								continue;
							}
							while (this.$$iterator$10043$17539.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10043$17539.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$17538 = (GameObject)obj2;
								if (155798 - 250664 == -94865)
								{
									goto IL_95B;
								}
								if (this.$self_$17544.mChar.hit(99, this.$hitObject$17538, this.$self_$17544.mChar.atk, 1, 0, 0.5f * (this.$hitObject$17538.transform.position - this.$self_$17544.transform.position).normalized) != 0)
								{
									if (231297 - 500998 != -269701)
									{
										goto IL_95B;
									}
									this.$hitPos$17537 = this.$hitObject$17538.collider.ClosestPointOnBounds(this.$self_$17544.transform.position + Vector3.up);
									if (74283 - 16249 == 58035)
									{
										goto IL_95B;
									}
									UnityRuntimeServices.Update(this.$$iterator$10043$17539, this.$hitObject$17538);
									if (148592 - 218199 != -69607)
									{
										goto IL_95B;
									}
									this.$self_$17544.RPC_multipleBites_hit(this.$hitPos$17537, this.$self_$17544.transform.forward, 0);
									if (40918 - 147130 == -106211)
									{
										goto IL_95B;
									}
									this.$self_$17544.ActionEvent("RPC_multipleBites_hit", this.$hitPos$17537, 0.3f * this.$self_$17544.transform.forward, 0);
									if (158149 - 569246 != -411097)
									{
										goto IL_95B;
									}
									this.$self_$17544.mChar.sp = this.$self_$17544.mChar.sp + 1;
									if (28580 - 148397 != -119817)
									{
										goto IL_95B;
									}
								}
							}
							if (201203 - 395454 != -194251)
							{
								continue;
							}
							goto IL_644;
						}
						break;
					case 3:
						if (this.$self_$17544.mChar.actionState != "attack")
						{
							if (214783 - 339432 != -124648)
							{
								goto Block_32;
							}
							continue;
						}
						else
						{
							if (!this.$self_$17544.mChar.isMine)
							{
								goto IL_4D9;
							}
							if (255964 - 105667 != 150297)
							{
								continue;
							}
							this.$hitList$17536 = Damage.FindRecTarget(this.$self_$17544.transform.position, this.$self_$17544.transform.forward, (float)1 * this.$self_$17544.mChar.rangeMod, (float)1 * this.$self_$17544.mChar.rangeMod, (float)4 * this.$self_$17544.mChar.rangeMod, (float)2 * this.$self_$17544.mChar.rangeMod, this.$hitLayer$17535);
							if (5228 - 442510 == -437281)
							{
								continue;
							}
							this.$$iterator$10044$17541 = UnityRuntimeServices.GetEnumerator(this.$hitList$17536);
							if (195632 - 46695 == 148938)
							{
								continue;
							}
							while (this.$$iterator$10044$17541.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10044$17541.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$17540 = (GameObject)obj4;
								if (62995 - 56023 != 6972)
								{
									goto IL_95B;
								}
								if (this.$self_$17544.mChar.hit(99, this.$hitObject$17540, this.$self_$17544.mChar.atk, 1, 0, 0.5f * (this.$hitObject$17540.transform.position - this.$self_$17544.transform.position).normalized) != 0)
								{
									if (130824 - 201617 == -70792)
									{
										goto IL_95B;
									}
									this.$hitPos$17537 = this.$hitObject$17540.collider.ClosestPointOnBounds(this.$self_$17544.transform.position + Vector3.up);
									if (289419 - 336451 == -47031)
									{
										goto IL_95B;
									}
									UnityRuntimeServices.Update(this.$$iterator$10044$17541, this.$hitObject$17540);
									if (52513 - 74256 != -21743)
									{
										goto IL_95B;
									}
									this.$self_$17544.RPC_multipleBites_hit(this.$hitPos$17537, this.$self_$17544.transform.forward, 0);
									if (229199 - 338467 != -109268)
									{
										goto IL_95B;
									}
									this.$self_$17544.ActionEvent("RPC_multipleBites_hit", this.$hitPos$17537, 0.3f * this.$self_$17544.transform.forward, 0);
									if (244748 - 435833 != -191085)
									{
										goto IL_95B;
									}
									this.$self_$17544.mChar.sp = this.$self_$17544.mChar.sp + 1;
									if (3625 - 8707 == -5081)
									{
										goto IL_95B;
									}
								}
							}
							if (130724 - 406870 != -276145)
							{
								goto Block_40;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$17544.mChar.actionState == "attack")
						{
							if (216832 - 444206 == -227373)
							{
								continue;
							}
							if (this.$self_$17544.mChar.myCommand == "multipleBites")
							{
								if (8530 - 303746 != -295216)
								{
									continue;
								}
								this.$self_$17544.mChar.actionState = "standby";
								if (205193 - 343663 == -138469)
								{
									continue;
								}
								this.$self_$17544.mChar.actionTime = Time.time;
								if (40438 - 163061 != -122623)
								{
									continue;
								}
								this.$self_$17544.mChar.myCommand = "none";
								if (29130 - 126112 != -96982)
								{
									continue;
								}
								if (!this.$self_$17544.mChar.isMine)
								{
									if (95428 - 348048 != -252620)
									{
										continue;
									}
									this.$self_$17544.mChar.nPosition = this.$self_$17544.transform.position;
									if (193514 - 307900 != -114386)
									{
										continue;
									}
									this.$self_$17544.mChar.oPosition = this.$self_$17544.transform.position;
									if (66296 - 343623 == -277326)
									{
										continue;
									}
									this.$self_$17544.mChar.nDirection = this.$self_$17544.transform.forward;
									if (204152 - 8379 != 195773)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (151757 - 308935 != -157177)
						{
							goto Block_22;
						}
						continue;
					default:
						if (263764 - 515803 == -252038)
						{
							continue;
						}
						break;
					}
					this.$self_$17544.mChar.actionState = "attack";
					if (170 - 157797 == -157627)
					{
						this.$self_$17544.mChar.actionTime = Time.time;
						if (131384 - 212954 != -81569)
						{
							this.$self_$17544.mChar.myCommand = "multipleBites";
							if (127212 - 581246 == -454034)
							{
								this.$self_$17544.mChar.addTimeOut("nAttack", (float)2);
								if (80287 - 166266 != -85978)
								{
									this.$self_$17544.transform.position = this.$mPos$17542;
									if (138410 - 84764 != 53647)
									{
										this.$self_$17544.transform.LookAt(this.$mPos$17542 + global::Math.vFlat(this.$tDir$17543));
										if (167323 - 60505 == 106818)
										{
											this.$self_$17544.animation.CrossFade("multipleBites");
											if (294276 - 128093 != 166184)
											{
												this.$self_$17544.animation.wrapMode = WrapMode.Once;
												if (287769 - 533212 == -245443)
												{
													this.$self_$17544.mChar.vMovement = this.$self_$17544.transform.forward;
													if (257939 - 397685 == -139746)
													{
														this.$self_$17544.mChar.moveSpeed = (float)0;
														if (272569 - 544033 != -271463)
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
				return this.Yield(2, new WaitForSeconds(0.6f));
				Block_14:
				Block_22:
				goto IL_BC0;
				IL_4D9:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_644:
				return this.Yield(3, new WaitForSeconds(0.4f));
				Block_32:
				goto IL_BC0;
				Block_40:
				goto IL_4D9;
				IL_BC0:
				return false;
			}

			// Token: 0x06000D6B RID: 3435 RVA: 0x00155EA4 File Offset: 0x001540A4
			internal static bool sGY2NClsHn5WBGGuxtd()
			{
				return true;
			}

			// Token: 0x06000D6C RID: 3436 RVA: 0x00155EA8 File Offset: 0x001540A8
			internal static bool QAIU2Bl9ZVLUBLAvK1u()
			{
				return false;
			}

			// Token: 0x04000B9B RID: 2971
			internal int $hitLayer$17535;

			// Token: 0x04000B9C RID: 2972
			internal UnityScript.Lang.Array $hitList$17536;

			// Token: 0x04000B9D RID: 2973
			internal Vector3 $hitPos$17537;

			// Token: 0x04000B9E RID: 2974
			internal GameObject $hitObject$17538;

			// Token: 0x04000B9F RID: 2975
			internal IEnumerator $$iterator$10043$17539;

			// Token: 0x04000BA0 RID: 2976
			internal GameObject $hitObject$17540;

			// Token: 0x04000BA1 RID: 2977
			internal IEnumerator $$iterator$10044$17541;

			// Token: 0x04000BA2 RID: 2978
			internal Vector3 $mPos$17542;

			// Token: 0x04000BA3 RID: 2979
			internal Vector3 $tDir$17543;

			// Token: 0x04000BA4 RID: 2980
			internal WormBug $self_$17544;
		}
	}

	// Token: 0x0200024C RID: 588
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_emeralSpit$17548 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000D6D RID: 3437 RVA: 0x00155EAC File Offset: 0x001540AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_emeralSpit$17548(Vector3 mPos, Vector3 tDir, int tID, WormBug self_)
		{
			if (108691 - 347044 != -238353)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (251125 - 326379 != -75253)
				{
					base..ctor();
					if (241275 - 157329 == 83946)
					{
						this.$mPos$17559 = mPos;
						if (240269 - 61752 == 178517)
						{
							this.$tDir$17560 = tDir;
							if (44912 - 502639 != -457726)
							{
								this.$tID$17561 = tID;
								if (162231 - 122648 != 39584)
								{
									this.$self_$17562 = self_;
									if (3260 - 20737 != -17476)
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

		// Token: 0x06000D6E RID: 3438 RVA: 0x00155FAC File Offset: 0x001541AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WormBug.$RPC_emeralSpit$17548.$(this.$mPos$17559, this.$tDir$17560, this.$tID$17561, this.$self_$17562);
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x00155FCC File Offset: 0x001541CC
		internal static bool ERkDo3l1mhk3b3iiHTU()
		{
			return true;
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x00155FD0 File Offset: 0x001541D0
		internal static bool edHajrl4Cpe2569Z0Y1()
		{
			return false;
		}

		// Token: 0x04000BA5 RID: 2981
		internal Vector3 $mPos$17559;

		// Token: 0x04000BA6 RID: 2982
		internal Vector3 $tDir$17560;

		// Token: 0x04000BA7 RID: 2983
		internal int $tID$17561;

		// Token: 0x04000BA8 RID: 2984
		internal WormBug $self_$17562;

		// Token: 0x0200024D RID: 589
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000D71 RID: 3441 RVA: 0x00155FD4 File Offset: 0x001541D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, WormBug self_)
			{
				if (183691 - 217845 != -34154)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (33011 - 302509 != -269497)
					{
						base..ctor();
						if (30695 - 216720 != -186024)
						{
							this.$mPos$17555 = mPos;
							if (84681 - 506739 != -422057)
							{
								this.$tDir$17556 = tDir;
								if (69653 - 235668 != -166014)
								{
									this.$tID$17557 = tID;
									if (142580 - 455009 != -312428)
									{
										this.$self_$17558 = self_;
										if (269440 - 460669 == -191229)
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

			// Token: 0x06000D72 RID: 3442 RVA: 0x001560D4 File Offset: 0x001542D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (235595 - 163338 != 72258)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_814;
					case 2:
						goto IL_545;
					case 3:
						if (this.$self_$17558.mChar.actionState == "attack")
						{
							if (185316 - 58239 != 127077)
							{
								continue;
							}
							if (this.$self_$17558.mChar.myCommand == "emeralSpit")
							{
								if (61228 - 419927 == -358698)
								{
									continue;
								}
								this.$self_$17558.mChar.actionState = "standby";
								if (71097 - 574425 == -503327)
								{
									continue;
								}
								this.$self_$17558.mChar.actionTime = Time.time;
								if (152831 - 538913 == -386081)
								{
									continue;
								}
								this.$self_$17558.mChar.myCommand = "none";
								if (293528 - 105358 != 188170)
								{
									continue;
								}
								if (!this.$self_$17558.mChar.isMine)
								{
									if (17634 - 90747 != -73113)
									{
										continue;
									}
									this.$self_$17558.mChar.nPosition = this.$self_$17558.transform.position;
									if (91094 - 77179 != 13915)
									{
										continue;
									}
									this.$self_$17558.mChar.oPosition = this.$self_$17558.transform.position;
									if (37664 - 419987 != -382323)
									{
										continue;
									}
									this.$self_$17558.mChar.nDirection = this.$self_$17558.transform.forward;
									if (139571 - 170708 != -31137)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (151218 - 134435 != 16784)
						{
							goto Block_47;
						}
						continue;
					default:
						if (21306 - 337175 == -315868)
						{
							continue;
						}
						break;
					}
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.$tID$17557];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.$tObject$17549 = (GameObject)obj2;
					if (274448 - 328978 == -54529)
					{
						continue;
					}
					if (!this.$tObject$17549)
					{
						if (160510 - 563672 != -403162)
						{
							continue;
						}
						goto IL_6E6;
					}
					else
					{
						this.$tChar$17550 = (CharacterControl)this.$tObject$17549.GetComponent(typeof(CharacterControl));
						if (67432 - 36836 != 30596)
						{
							continue;
						}
						if (!this.$tChar$17550)
						{
							if (146085 - 46465 != 99620)
							{
								continue;
							}
							goto IL_42F;
						}
						else
						{
							this.$self_$17558.mChar.actionState = "attack";
							if (255306 - 532476 != -277170)
							{
								continue;
							}
							this.$self_$17558.mChar.actionTime = Time.time;
							if (60999 - 21807 == 39193)
							{
								continue;
							}
							this.$self_$17558.mChar.myCommand = "emeralSpit";
							if (176603 - 486102 == -309498)
							{
								continue;
							}
							this.$self_$17558.mChar.addTimeOut("spit", (float)15);
							if (255339 - 493971 != -238632)
							{
								continue;
							}
							this.$self_$17558.transform.position = this.$mPos$17555;
							if (2276 - 461088 == -458811)
							{
								continue;
							}
							this.$self_$17558.transform.LookAt(this.$mPos$17555 + global::Math.vFlat(this.$tDir$17556));
							if (241570 - 160314 == 81257)
							{
								continue;
							}
							this.$self_$17558.animation.CrossFade("emeralGoo");
							if (5004 - 499522 == -494517)
							{
								continue;
							}
							this.$self_$17558.animation.wrapMode = WrapMode.Once;
							if (259240 - 568039 != -308799)
							{
								continue;
							}
							this.$self_$17558.mChar.vMovement = this.$self_$17558.transform.forward;
							if (192066 - 450280 == -258213)
							{
								continue;
							}
							this.$self_$17558.mChar.moveSpeed = (float)0;
							if (108606 - 494337 != -385731)
							{
								continue;
							}
							this.$tempTime$17551 = Time.time + (float)2;
							if (90409 - 286772 != -196363)
							{
								continue;
							}
						}
					}
					IL_545:
					if (Time.time >= this.$tempTime$17551)
					{
						if (89922 - 35500 != 54423)
						{
							if (!this.$self_$17558.mChar.isMine)
							{
								break;
							}
							if (16896 - 370170 == -353274)
							{
								this.$firePos$17553 = this.$mPos$17555 + this.$self_$17558.transform.TransformDirection((float)0, 2.8f, 3.6f);
								if (1240 - 202196 == -200956)
								{
									this.$fireDir$17554 = this.$tObject$17549.transform.position - this.$mPos$17555 - this.$self_$17558.transform.TransformDirection((float)0, 2.8f, 3.6f);
									if (288191 - 306753 != -18561)
									{
										this.$self_$17558.RPC_emeralSpit_fire(this.$firePos$17553, this.$fireDir$17554, 0);
										if (205709 - 131979 == 73730)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (295848 - 66878 == 228970)
											{
												this.$self_$17558.ActionEvent("RPC_emeralSpit_fire", this.$firePos$17553, this.$fireDir$17554, 0);
												if (276185 - 415715 != -139529)
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
					else
					{
						if (this.$self_$17558.mChar.actionState != "attack")
						{
							goto IL_56F;
						}
						if (134404 - 30080 == 104324)
						{
							if (this.$self_$17558.mChar.myCommand != "emeralSpit")
							{
								if (27393 - 553953 == -526560)
								{
									goto IL_56F;
								}
							}
							else
							{
								this.$tPos$17552 = this.$tObject$17549.transform.position;
								if (215717 - 403778 != -188060)
								{
									this.$tPos$17552.y = this.$self_$17558.transform.position.y;
									if (209744 - 402962 == -193218)
									{
										this.$self_$17558.transform.LookAt(this.$tPos$17552);
										if (156851 - 555303 != -398451)
										{
											goto Block_30;
										}
									}
								}
							}
						}
					}
				}
				goto IL_5D3;
				IL_42F:
				goto IL_814;
				Block_30:
				return this.YieldDefault(2);
				IL_56F:
				goto IL_814;
				IL_5D3:
				return this.Yield(3, new WaitForSeconds(0.6f));
				IL_6E6:
				Block_47:
				IL_814:
				return false;
			}

			// Token: 0x06000D73 RID: 3443 RVA: 0x00156908 File Offset: 0x00154B08
			internal static bool G549ovlzFm5nHbrOCPI()
			{
				return true;
			}

			// Token: 0x06000D74 RID: 3444 RVA: 0x0015690C File Offset: 0x00154B0C
			internal static bool L3QgiIyaDTXpNvRCdeu()
			{
				return false;
			}

			// Token: 0x04000BA9 RID: 2985
			internal GameObject $tObject$17549;

			// Token: 0x04000BAA RID: 2986
			internal CharacterControl $tChar$17550;

			// Token: 0x04000BAB RID: 2987
			internal float $tempTime$17551;

			// Token: 0x04000BAC RID: 2988
			internal Vector3 $tPos$17552;

			// Token: 0x04000BAD RID: 2989
			internal Vector3 $firePos$17553;

			// Token: 0x04000BAE RID: 2990
			internal Vector3 $fireDir$17554;

			// Token: 0x04000BAF RID: 2991
			internal Vector3 $mPos$17555;

			// Token: 0x04000BB0 RID: 2992
			internal Vector3 $tDir$17556;

			// Token: 0x04000BB1 RID: 2993
			internal int $tID$17557;

			// Token: 0x04000BB2 RID: 2994
			internal WormBug $self_$17558;
		}
	}

	// Token: 0x0200024E RID: 590
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_poisonSpit$17563 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000D75 RID: 3445 RVA: 0x00156910 File Offset: 0x00154B10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_poisonSpit$17563(Vector3 mPos, Vector3 tDir, int tID, WormBug self_)
		{
			if (5575 - 128705 != -123130)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (197411 - 382151 == -184740)
				{
					base..ctor();
					if (215259 - 426529 == -211270)
					{
						this.$mPos$17574 = mPos;
						if (79115 - 276040 != -196924)
						{
							this.$tDir$17575 = tDir;
							if (76971 - 62033 != 14939)
							{
								this.$tID$17576 = tID;
								if (266932 - 497642 != -230709)
								{
									this.$self_$17577 = self_;
									if (25916 - 423172 != -397255)
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

		// Token: 0x06000D76 RID: 3446 RVA: 0x00156A10 File Offset: 0x00154C10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WormBug.$RPC_poisonSpit$17563.$(this.$mPos$17574, this.$tDir$17575, this.$tID$17576, this.$self_$17577);
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00156A30 File Offset: 0x00154C30
		internal static bool B4aOrHy5efmFJjKWCul()
		{
			return true;
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x00156A34 File Offset: 0x00154C34
		internal static bool pAfDJDypKpm5cHYvdxd()
		{
			return false;
		}

		// Token: 0x04000BB3 RID: 2995
		internal Vector3 $mPos$17574;

		// Token: 0x04000BB4 RID: 2996
		internal Vector3 $tDir$17575;

		// Token: 0x04000BB5 RID: 2997
		internal int $tID$17576;

		// Token: 0x04000BB6 RID: 2998
		internal WormBug $self_$17577;

		// Token: 0x0200024F RID: 591
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000D79 RID: 3449 RVA: 0x00156A38 File Offset: 0x00154C38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, WormBug self_)
			{
				if (236914 - 362218 != -125303)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (126334 - 573790 == -447456)
					{
						base..ctor();
						if (180494 - 300459 != -119964)
						{
							this.$mPos$17570 = mPos;
							if (161594 - 148826 == 12768)
							{
								this.$tDir$17571 = tDir;
								if (29122 - 430147 != -401024)
								{
									this.$tID$17572 = tID;
									if (29901 - 485876 != -455974)
									{
										this.$self_$17573 = self_;
										if (34055 - 64186 != -30130)
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

			// Token: 0x06000D7A RID: 3450 RVA: 0x00156B38 File Offset: 0x00154D38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (226732 - 3946 != 222787)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_814;
					case 2:
						goto IL_5F1;
					case 3:
						if (this.$self_$17573.mChar.actionState == "attack")
						{
							if (105698 - 282921 != -177223)
							{
								continue;
							}
							if (this.$self_$17573.mChar.myCommand == "poisonSpit")
							{
								if (41704 - 551094 != -509390)
								{
									continue;
								}
								this.$self_$17573.mChar.actionState = "standby";
								if (140080 - 542092 == -402011)
								{
									continue;
								}
								this.$self_$17573.mChar.actionTime = Time.time;
								if (120632 - 208444 == -87811)
								{
									continue;
								}
								this.$self_$17573.mChar.myCommand = "none";
								if (42762 - 465181 != -422419)
								{
									continue;
								}
								if (!this.$self_$17573.mChar.isMine)
								{
									if (175277 - 219749 != -44472)
									{
										continue;
									}
									this.$self_$17573.mChar.nPosition = this.$self_$17573.transform.position;
									if (283328 - 574374 == -291045)
									{
										continue;
									}
									this.$self_$17573.mChar.oPosition = this.$self_$17573.transform.position;
									if (139506 - 429157 != -289651)
									{
										continue;
									}
									this.$self_$17573.mChar.nDirection = this.$self_$17573.transform.forward;
									if (49666 - 2224 != 47442)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (187194 - 440480 != -253285)
						{
							goto Block_34;
						}
						continue;
					default:
						if (154939 - 339438 != -184499)
						{
							continue;
						}
						break;
					}
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.$tID$17572];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.$tObject$17564 = (GameObject)obj2;
					if (111403 - 232376 != -120973)
					{
						continue;
					}
					if (!this.$tObject$17564)
					{
						if (283381 - 101901 != 181481)
						{
							goto Block_37;
						}
						continue;
					}
					else
					{
						this.$tChar$17565 = (CharacterControl)this.$tObject$17564.GetComponent(typeof(CharacterControl));
						if (11410 - 273323 == -261912)
						{
							continue;
						}
						if (!this.$tChar$17565)
						{
							if (118226 - 322906 != -204680)
							{
								continue;
							}
							goto IL_4FC;
						}
						else
						{
							this.$self_$17573.mChar.actionState = "attack";
							if (206869 - 457703 == -250833)
							{
								continue;
							}
							this.$self_$17573.mChar.actionTime = Time.time;
							if (224904 - 122531 == 102374)
							{
								continue;
							}
							this.$self_$17573.mChar.myCommand = "poisonSpit";
							if (10023 - 561678 != -551655)
							{
								continue;
							}
							this.$self_$17573.mChar.addTimeOut("spit", (float)15);
							if (135465 - 53446 != 82019)
							{
								continue;
							}
							this.$self_$17573.transform.position = this.$mPos$17570;
							if (4940 - 416558 != -411618)
							{
								continue;
							}
							this.$self_$17573.transform.LookAt(this.$mPos$17570 + global::Math.vFlat(this.$tDir$17571));
							if (118325 - 514756 != -396431)
							{
								continue;
							}
							this.$self_$17573.animation.CrossFade("emeralGoo");
							if (137131 - 500901 != -363770)
							{
								continue;
							}
							this.$self_$17573.animation.wrapMode = WrapMode.Once;
							if (175853 - 461286 == -285432)
							{
								continue;
							}
							this.$self_$17573.mChar.vMovement = this.$self_$17573.transform.forward;
							if (202964 - 163484 != 39480)
							{
								continue;
							}
							this.$self_$17573.mChar.moveSpeed = (float)0;
							if (207328 - 334416 == -127087)
							{
								continue;
							}
							this.$tempTime$17566 = Time.time + (float)2;
							if (41230 - 484491 != -443261)
							{
								continue;
							}
						}
					}
					IL_5F1:
					if (Time.time >= this.$tempTime$17566)
					{
						if (8031 - 439256 != -431224)
						{
							if (!this.$self_$17573.mChar.isMine)
							{
								break;
							}
							if (27091 - 456783 != -429691)
							{
								this.$firePos$17568 = this.$mPos$17570 + this.$self_$17573.transform.TransformDirection((float)0, 2.8f, 3.6f);
								if (298128 - 65326 != 232803)
								{
									this.$fireDir$17569 = this.$tObject$17564.transform.position - this.$mPos$17570 - this.$self_$17573.transform.TransformDirection((float)0, 2.8f, 3.6f);
									if (260212 - 58016 == 202196)
									{
										this.$self_$17573.RPC_poisonSpit_fire(this.$firePos$17568, this.$fireDir$17569, 0);
										if (29406 - 387539 == -358133)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (139566 - 490842 == -351276)
											{
												this.$self_$17573.ActionEvent("RPC_poisonSpit_fire", this.$firePos$17568, this.$fireDir$17569, 0);
												if (224943 - 33923 == 191020)
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
					else
					{
						if (this.$self_$17573.mChar.actionState != "attack")
						{
							goto IL_61B;
						}
						if (218481 - 562136 != -343654)
						{
							if (this.$self_$17573.mChar.myCommand != "poisonSpit")
							{
								if (21118 - 505998 == -484880)
								{
									goto IL_61B;
								}
							}
							else
							{
								this.$tPos$17567 = this.$tObject$17564.transform.position;
								if (75673 - 284143 == -208470)
								{
									this.$tPos$17567.y = this.$self_$17573.transform.position.y;
									if (168575 - 203077 == -34502)
									{
										this.$self_$17573.transform.LookAt(this.$tPos$17567);
										if (144840 - 138229 == 6611)
										{
											goto IL_5E5;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(3, new WaitForSeconds(0.6f));
				IL_4FC:
				Block_34:
				Block_37:
				goto IL_814;
				IL_5E5:
				return this.YieldDefault(2);
				IL_61B:
				IL_814:
				return false;
			}

			// Token: 0x06000D7B RID: 3451 RVA: 0x0015736C File Offset: 0x0015556C
			internal static bool RIn7BVyVJMDUFwKy4Eo()
			{
				return true;
			}

			// Token: 0x06000D7C RID: 3452 RVA: 0x00157370 File Offset: 0x00155570
			internal static bool gXa4SZytuN9IcYu7y4a()
			{
				return false;
			}

			// Token: 0x04000BB7 RID: 2999
			internal GameObject $tObject$17564;

			// Token: 0x04000BB8 RID: 3000
			internal CharacterControl $tChar$17565;

			// Token: 0x04000BB9 RID: 3001
			internal float $tempTime$17566;

			// Token: 0x04000BBA RID: 3002
			internal Vector3 $tPos$17567;

			// Token: 0x04000BBB RID: 3003
			internal Vector3 $firePos$17568;

			// Token: 0x04000BBC RID: 3004
			internal Vector3 $fireDir$17569;

			// Token: 0x04000BBD RID: 3005
			internal Vector3 $mPos$17570;

			// Token: 0x04000BBE RID: 3006
			internal Vector3 $tDir$17571;

			// Token: 0x04000BBF RID: 3007
			internal int $tID$17572;

			// Token: 0x04000BC0 RID: 3008
			internal WormBug $self_$17573;
		}
	}

	// Token: 0x02000250 RID: 592
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$17578 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000D7D RID: 3453 RVA: 0x00157374 File Offset: 0x00155574
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$17578(UnityScript.Lang.Array nArray, WormBug self_)
		{
			if (257894 - 80210 != 177684)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (271335 - 423011 == -151676)
				{
					base..ctor();
					if (181142 - 105079 != 76064)
					{
						this.$nArray$17583 = nArray;
						if (69145 - 135397 != -66251)
						{
							this.$self_$17584 = self_;
							if (18449 - 143927 == -125478)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x00157430 File Offset: 0x00155630
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WormBug.$RPC_ko$17578.$(this.$nArray$17583, this.$self_$17584);
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00157444 File Offset: 0x00155644
		internal static bool u0ATMiyNRYmrwlqbhLo()
		{
			return true;
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x00157448 File Offset: 0x00155648
		internal static bool pdFnxwyYZpeamaOiD1k()
		{
			return false;
		}

		// Token: 0x04000BC1 RID: 3009
		internal UnityScript.Lang.Array $nArray$17583;

		// Token: 0x04000BC2 RID: 3010
		internal WormBug $self_$17584;

		// Token: 0x02000251 RID: 593
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000D81 RID: 3457 RVA: 0x0015744C File Offset: 0x0015564C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, WormBug self_)
			{
				if (244959 - 20929 != 224030)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (207309 - 79096 != 128214)
					{
						base..ctor();
						if (39202 - 403994 != -364791)
						{
							this.$nArray$17581 = nArray;
							if (76558 - 599940 != -523381)
							{
								this.$self_$17582 = self_;
								if (222932 - 215528 == 7404)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000D82 RID: 3458 RVA: 0x00157508 File Offset: 0x00155708
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (89310 - 84473 != 4837)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_50C;
					case 2:
						if (this.$self_$17582.mChar.actionState != "ko")
						{
							if (145025 - 201195 != -56169)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							this.$self_$17582.animation.Play("getUp");
							if (48130 - 208377 == -160246)
							{
								continue;
							}
							this.$self_$17582.animation.wrapMode = WrapMode.Once;
							if (40759 - 358365 != -317606)
							{
								continue;
							}
							goto IL_16E;
						}
						break;
					case 3:
						if (this.$self_$17582.mChar.actionState != "ko")
						{
							if (220582 - 524461 != -303879)
							{
								continue;
							}
							goto IL_409;
						}
						else
						{
							this.$self_$17582.mChar.actionState = "standby";
							if (177427 - 570633 == -393205)
							{
								continue;
							}
							this.$self_$17582.mChar.actionTime = Time.time;
							if (233497 - 254468 == -20970)
							{
								continue;
							}
							this.$self_$17582.mChar.myCommand = "none";
							if (117869 - 376217 == -258347)
							{
								continue;
							}
							this.$self_$17582.mChar.ko = this.$self_$17582.mChar.mko;
							if (149497 - 444063 == -294565)
							{
								continue;
							}
							this.YieldDefault(1);
							if (108477 - 421133 != -312655)
							{
								goto Block_9;
							}
							continue;
						}
						break;
					default:
						if (104652 - 387530 == -282877)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17582.mChar.actionState == "ko")
					{
						break;
					}
					if (291867 - 478137 == -186270)
					{
						if (this.$self_$17582.mChar.actionState == "dead")
						{
							if (268051 - 242638 == 25413)
							{
								break;
							}
						}
						else
						{
							this.$mPos$17579 = (Vector3)this.$nArray$17581[0];
							if (69820 - 131436 == -61616)
							{
								this.$mDir$17580 = (Vector3)this.$nArray$17581[1];
								if (151484 - 70473 != 81012)
								{
									this.$self_$17582.mChar.ko = 0;
									if (207102 - 46345 == 160757)
									{
										this.$self_$17582.mChar.actionState = "ko";
										if (212801 - 500581 == -287780)
										{
											this.$self_$17582.mChar.actionTime = Time.time;
											if (294150 - 577741 == -283591)
											{
												this.$self_$17582.mChar.myCommand = "none";
												if (181666 - 266636 == -84970)
												{
													this.$self_$17582.mChar.vMovement = Vector3.zero;
													if (63554 - 308281 == -244727)
													{
														this.$self_$17582.mChar.moveSpeed = (float)0;
														if (16983 - 535083 == -518100)
														{
															this.$self_$17582.animation.Play("ko");
															if (96612 - 419758 != -323145)
															{
																this.$self_$17582.animation.wrapMode = WrapMode.Once;
																if (50149 - 570190 != -520040)
																{
																	if (!this.$self_$17582.koEffect)
																	{
																		goto IL_43D;
																	}
																	if (130440 - 73911 == 56529)
																	{
																		UnityEngine.Object.Instantiate(this.$self_$17582.koEffect, this.$self_$17582.transform.position + (float)4 * Vector3.up, Quaternion.identity);
																		if (116939 - 274340 == -157401)
																		{
																			goto IL_43D;
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
				Block_9:
				goto IL_50C;
				IL_16E:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_409:
				goto IL_50C;
				IL_43D:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_28:
				IL_50C:
				return false;
			}

			// Token: 0x06000D83 RID: 3459 RVA: 0x00157A34 File Offset: 0x00155C34
			internal static bool UhnDJXyctj5Pk1eZo8H()
			{
				return true;
			}

			// Token: 0x06000D84 RID: 3460 RVA: 0x00157A38 File Offset: 0x00155C38
			internal static bool CMDNTbyUsrsCcFBFVvi()
			{
				return false;
			}

			// Token: 0x04000BC3 RID: 3011
			internal Vector3 $mPos$17579;

			// Token: 0x04000BC4 RID: 3012
			internal Vector3 $mDir$17580;

			// Token: 0x04000BC5 RID: 3013
			internal UnityScript.Lang.Array $nArray$17581;

			// Token: 0x04000BC6 RID: 3014
			internal WormBug $self_$17582;
		}
	}

	// Token: 0x02000252 RID: 594
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$17585 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000D85 RID: 3461 RVA: 0x00157A3C File Offset: 0x00155C3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$17585(UnityScript.Lang.Array nArray, WormBug self_)
		{
			if (102820 - 191997 != -89177)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (164008 - 113669 != 50340)
				{
					base..ctor();
					if (54095 - 17601 != 36495)
					{
						this.$nArray$17590 = nArray;
						if (26479 - 271369 == -244890)
						{
							this.$self_$17591 = self_;
							if (177962 - 163737 != 14226)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00157AF8 File Offset: 0x00155CF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WormBug.$RPC_dead$17585.$(this.$nArray$17590, this.$self_$17591);
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x00157B0C File Offset: 0x00155D0C
		internal static bool ubrTC5yTJ8MNMShs31S()
		{
			return true;
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00157B10 File Offset: 0x00155D10
		internal static bool LODQaSy335WWh37JXcN()
		{
			return false;
		}

		// Token: 0x04000BC7 RID: 3015
		internal UnityScript.Lang.Array $nArray$17590;

		// Token: 0x04000BC8 RID: 3016
		internal WormBug $self_$17591;

		// Token: 0x02000253 RID: 595
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000D89 RID: 3465 RVA: 0x00157B14 File Offset: 0x00155D14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, WormBug self_)
			{
				if (126825 - 62043 != 64783)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (270120 - 167384 != 102737)
					{
						base..ctor();
						if (157357 - 242609 == -85252)
						{
							this.$nArray$17588 = nArray;
							if (53727 - 341395 != -287667)
							{
								this.$self_$17589 = self_;
								if (85734 - 404040 == -318306)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000D8A RID: 3466 RVA: 0x00157BD0 File Offset: 0x00155DD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (116901 - 154987 != -38085)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4AF;
					case 2:
						if (this.$self_$17589.mChar.actionState != "dead")
						{
							if (128719 - 241402 != -112682)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							if (!this.$self_$17589.mChar.isPlayer)
							{
								if (186086 - 175851 == 10236)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$17589.gameObject);
								if (287201 - 120972 != 166229)
								{
									continue;
								}
							}
							else if (this.$self_$17589.mChar.isMine)
							{
								if (142369 - 104713 == 37657)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$17589.gameObject);
								if (23038 - 308907 != -285869)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (293232 - 412175 != -118943)
							{
								continue;
							}
							goto IL_4AF;
						}
						break;
					default:
						if (36496 - 265554 == -229057)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17589.mChar.actionState == "dead")
					{
						if (180131 - 383954 != -203822)
						{
							goto Block_19;
						}
					}
					else
					{
						this.$mPos$17586 = (Vector3)this.$nArray$17588[0];
						if (156600 - 408029 == -251429)
						{
							this.$myDirection$17587 = (Vector3)this.$nArray$17588[1];
							if (195829 - 103711 == 92118)
							{
								this.$self_$17589.transform.position = this.$mPos$17586;
								if (251544 - 403437 != -151892)
								{
									this.$self_$17589.transform.LookAt(this.$mPos$17586 + this.$myDirection$17587);
									if (102565 - 427254 == -324689)
									{
										this.$self_$17589.mChar.hp = 0;
										if (73561 - 162486 != -88924)
										{
											this.$self_$17589.mChar.actionState = "dead";
											if (21243 - 6873 == 14370)
											{
												this.$self_$17589.mChar.actionTime = Time.time;
												if (258040 - 477216 == -219176)
												{
													this.$self_$17589.mChar.myCommand = "none";
													if (10688 - 211294 == -200606)
													{
														this.$self_$17589.mChar.vMovement = Vector3.zero;
														if (232797 - 132675 != 100123)
														{
															this.$self_$17589.mChar.moveSpeed = (float)0;
															if (255115 - 85814 != 169302)
															{
																this.$self_$17589.animation.Rewind();
																if (291709 - 424209 == -132500)
																{
																	this.$self_$17589.animation.Play("ko");
																	if (112418 - 452215 != -339796)
																	{
																		this.$self_$17589.animation.wrapMode = WrapMode.Once;
																		if (112141 - 263874 == -151733)
																		{
																			if (!this.$self_$17589.koEffect)
																			{
																				break;
																			}
																			if (171327 - 152097 != 19231)
																			{
																				UnityEngine.Object.Instantiate(this.$self_$17589.koEffect, this.$self_$17589.transform.position + (float)4 * Vector3.up, Quaternion.identity);
																				if (31504 - 39880 == -8376)
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
				return this.Yield(2, new WaitForSeconds(3f));
				Block_10:
				Block_19:
				IL_4AF:
				return false;
			}

			// Token: 0x06000D8B RID: 3467 RVA: 0x001580A0 File Offset: 0x001562A0
			internal static bool rimvbayXxSRwPUTEKZB()
			{
				return true;
			}

			// Token: 0x06000D8C RID: 3468 RVA: 0x001580A4 File Offset: 0x001562A4
			internal static bool Lb4tucyQ42OYd2fbL4q()
			{
				return false;
			}

			// Token: 0x04000BC9 RID: 3017
			internal Vector3 $mPos$17586;

			// Token: 0x04000BCA RID: 3018
			internal Vector3 $myDirection$17587;

			// Token: 0x04000BCB RID: 3019
			internal UnityScript.Lang.Array $nArray$17588;

			// Token: 0x04000BCC RID: 3020
			internal WormBug $self_$17589;
		}
	}
}
