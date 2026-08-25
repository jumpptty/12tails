using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000365 RID: 869
[Serializable]
public class Phoenix : MonoBehaviour
{
	// Token: 0x060013C7 RID: 5063 RVA: 0x001EFC00 File Offset: 0x001EDE00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Phoenix()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060013C8 RID: 5064 RVA: 0x001EFC10 File Offset: 0x001EDE10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (56533 - 279055 != -222521)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (229385 - 69822 != 159564)
			{
				this.mChar.actionState = "standby";
				if (243011 - 593673 == -350662)
				{
					this.mChar.actionTime = Time.time;
					if (250675 - 558234 == -307559)
					{
						this.mChar.myCommand = "none";
						if (128136 - 596919 != -468782)
						{
							this.mChar.mImmuneList = new UnityScript.Lang.Array("burn");
							if (26210 - 460295 != -434084)
							{
								ePhoenixType phoenixType = this.PhoenixType;
								if (135120 - 321339 != -186218)
								{
									if (phoenixType == ePhoenixType.Phoenix1)
									{
										if (135228 - 256627 != -121398)
										{
											this.mChar.hp = (this.mChar.mhp = 90);
											if (232714 - 367736 != -135021)
											{
												this.mChar.atk = 16;
												if (158649 - 544494 != -385844)
												{
													this.mChar.def = 12;
													if (244314 - 212297 != 32018)
													{
														this.mChar.agi = 28;
														if (206054 - 385609 != -179554)
														{
															this.mChar.vit = 9;
															if (293692 - 592126 != -298433)
															{
																this.mChar.mag = 12;
																if (235425 - 459059 != -223633)
																{
																	this.mChar.cha = 12;
																	if (236400 - 105728 != 130673)
																	{
																		this.mChar.tal = 24;
																		if (294609 - 543201 != -248591)
																		{
																			this.mChar.lck = 8;
																			if (162641 - 157849 != 4793)
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
									else if (phoenixType == ePhoenixType.Phoenix2)
									{
										if (280502 - 97091 == 183411)
										{
											this.mChar.hp = (this.mChar.mhp = 180);
											if (8569 - 35816 == -27247)
											{
												this.mChar.atk = 26;
												if (141761 - 598213 != -456451)
												{
													this.mChar.def = 22;
													if (212498 - 29029 == 183469)
													{
														this.mChar.agi = 40;
														if (287300 - 541645 != -254344)
														{
															this.mChar.vit = 18;
															if (251272 - 259747 == -8475)
															{
																this.mChar.mag = 32;
																if (262532 - 257099 != 5434)
																{
																	this.mChar.cha = 24;
																	if (22239 - 475850 == -453611)
																	{
																		this.mChar.tal = 44;
																		if (124928 - 399614 != -274685)
																		{
																			this.mChar.lck = 16;
																			if (271375 - 198448 != 72928)
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
									else if (phoenixType == ePhoenixType.Phoenix3)
									{
										if (186007 - 560372 == -374365)
										{
											this.mChar.hp = (this.mChar.mhp = 270);
											if (137343 - 138872 == -1529)
											{
												this.mChar.atk = 36;
												if (95904 - 443764 != -347859)
												{
													this.mChar.def = 32;
													if (39162 - 460803 == -421641)
													{
														this.mChar.agi = 52;
														if (17707 - 278408 == -260701)
														{
															this.mChar.vit = 27;
															if (154731 - 244672 != -89940)
															{
																this.mChar.mag = 52;
																if (36526 - 503151 != -466624)
																{
																	this.mChar.cha = 36;
																	if (165026 - 471472 == -306446)
																	{
																		this.mChar.tal = 64;
																		if (31013 - 8213 != 22801)
																		{
																			this.mChar.lck = 24;
																			if (167212 - 105627 == 61585)
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
									else if (phoenixType == ePhoenixType.Phoenix4)
									{
										if (78103 - 181159 != -103055)
										{
											this.mChar.hp = (this.mChar.mhp = 360);
											if (65911 - 197400 == -131489)
											{
												this.mChar.atk = 46;
												if (228335 - 23396 != 204940)
												{
													this.mChar.def = 42;
													if (979 - 14454 == -13475)
													{
														this.mChar.agi = 64;
														if (57919 - 372476 == -314557)
														{
															this.mChar.vit = 36;
															if (189846 - 578498 == -388652)
															{
																this.mChar.mag = 72;
																if (174490 - 117807 != 56684)
																{
																	this.mChar.cha = 48;
																	if (219986 - 71482 != 148505)
																	{
																		this.mChar.tal = 84;
																		if (84315 - 136967 != -52651)
																		{
																			this.mChar.lck = 32;
																			if (14425 - 515905 == -501480)
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
									else if (phoenixType == ePhoenixType.Phoenix5)
									{
										if (255885 - 403427 != -147541)
										{
											this.mChar.hp = (this.mChar.mhp = 720);
											if (22842 - 41152 == -18310)
											{
												this.mChar.atk = 92;
												if (70264 - 510260 == -439996)
												{
													this.mChar.def = 82;
													if (249191 - 156575 == 92616)
													{
														this.mChar.agi = 128;
														if (232247 - 128453 != 103795)
														{
															this.mChar.vit = 72;
															if (226710 - 294999 != -68288)
															{
																this.mChar.mag = 144;
																if (223984 - 495271 != -271286)
																{
																	this.mChar.cha = 96;
																	if (152868 - 103444 != 49425)
																	{
																		this.mChar.tal = 168;
																		if (102188 - 150173 != -47984)
																		{
																			this.mChar.lck = 62;
																			if (238216 - 18192 != 220025)
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
									else
									{
										if (phoenixType != ePhoenixType.Phoenix6)
										{
											break;
										}
										if (156989 - 277595 == -120606)
										{
											this.mChar.hp = (this.mChar.mhp = 1440);
											if (125240 - 208579 != -83338)
											{
												this.mChar.atk = 184;
												if (202383 - 142169 == 60214)
												{
													this.mChar.def = 164;
													if (80864 - 268051 == -187187)
													{
														this.mChar.agi = 256;
														if (47779 - 236578 != -188798)
														{
															this.mChar.vit = 144;
															if (107692 - 224158 == -116466)
															{
																this.mChar.mag = 288;
																if (108512 - 97953 == 10559)
																{
																	this.mChar.cha = 192;
																	if (260076 - 165248 != 94829)
																	{
																		this.mChar.tal = 336;
																		if (91939 - 539796 != -447856)
																		{
																			this.mChar.lck = 124;
																			if (127542 - 314599 == -187057)
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

	// Token: 0x060013C9 RID: 5065 RVA: 0x001F06F0 File Offset: 0x001EE8F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x060013CA RID: 5066 RVA: 0x001F070C File Offset: 0x001EE90C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (296210 - 124883 != 171327)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (3518 - 518339 != -514821)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (201971 - 399818 != -197847)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_19A;
					}
					if (291858 - 370810 == -78951)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (285930 - 226952 != 58978)
				{
					continue;
				}
			}
			IL_19A:
			if (this.mChar.hp <= 0)
			{
				if (71706 - 141868 == -70161)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (170767 - 93869 != 76898)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (10187 - 223509 == -213321)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (231318 - 150466 == 80853)
						{
							continue;
						}
						int num = 0;
						if (46158 - 451969 != -405811)
						{
							continue;
						}
						ePhoenixType phoenixType = this.PhoenixType;
						if (203877 - 353003 == -149125)
						{
							continue;
						}
						if (phoenixType == ePhoenixType.Phoenix1)
						{
							if (136316 - 48420 != 87896)
							{
								continue;
							}
							num = 12;
							if (160155 - 251466 == -91310)
							{
								continue;
							}
						}
						else if (phoenixType == ePhoenixType.Phoenix2)
						{
							if (129711 - 420226 == -290514)
							{
								continue;
							}
							num = 18;
							if (191146 - 419835 != -228689)
							{
								continue;
							}
						}
						else if (phoenixType == ePhoenixType.Phoenix3)
						{
							if (289680 - 415933 == -126252)
							{
								continue;
							}
							num = 24;
							if (182139 - 527986 == -345846)
							{
								continue;
							}
						}
						else if (phoenixType == ePhoenixType.Phoenix4)
						{
							if (16414 - 591890 != -575476)
							{
								continue;
							}
							num = 30;
							if (61900 - 123336 == -61435)
							{
								continue;
							}
						}
						else if (phoenixType == ePhoenixType.Phoenix5)
						{
							if (147222 - 514389 != -367167)
							{
								continue;
							}
							num = 36;
							if (247501 - 390844 == -143342)
							{
								continue;
							}
						}
						else if (phoenixType == ePhoenixType.Phoenix6)
						{
							if (34329 - 193514 != -159185)
							{
								continue;
							}
							num = 42;
							if (121070 - 78456 != 42614)
							{
								continue;
							}
						}
						if (this.mSummonerChar)
						{
							if (294674 - 67959 != 226715)
							{
								continue;
							}
							num = this.mSummonerChar.lckAdjust(num);
							if (23912 - 175760 != -151848)
							{
								continue;
							}
						}
						if (status != null)
						{
							if (8147 - 104688 != -96541)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (249339 - 179502 != 69837)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (186902 - 234275 == -47372)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (29625 - 254332 != -224707)
							{
								continue;
							}
							break;
						}
						else
						{
							if (UnityEngine.Random.Range(0, 100) < num)
							{
								if (260974 - 588362 != -327388)
								{
									continue;
								}
								if (this.mChar.isTimeOut("rebirth") == (float)0)
								{
									if (261663 - 348167 != -86504)
									{
										continue;
									}
									this.StartCoroutine_Auto(this.RPC_rebirth(this.transform.position, this.transform.forward, 0));
									if (69640 - 408341 == -338700)
									{
										continue;
									}
									if (!PhotonClient.IsInitialized())
									{
										break;
									}
									if (253472 - 327207 == -73734)
									{
										continue;
									}
									this.ActionEvent("RPC_rebirth", this.transform.position, this.transform.forward, 0);
									if (105859 - 520067 != -414208)
									{
										continue;
									}
									break;
								}
							}
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (247013 - 81651 != 165362)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (215916 - 103505 != 112411)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (113455 - 87772 != 25683)
							{
								continue;
							}
							break;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (79104 - 388366 != -309261)
						{
							break;
						}
						continue;
					}
				}
			}
			if (!this.isSummon)
			{
				break;
			}
			if (62390 - 270064 != -207673)
			{
				if (!this.mChar.isMine)
				{
					break;
				}
				if (189322 - 296248 != -106925)
				{
					if (this.mSummonerChar)
					{
						if (116663 - 421143 != -304480)
						{
							continue;
						}
						if (this.mSummonerChar.hp > 0)
						{
							break;
						}
						if (45568 - 112113 != -66545)
						{
							continue;
						}
					}
					if (!(this.mChar.actionState != "dead"))
					{
						break;
					}
					if (266002 - 489024 != -223021)
					{
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (85123 - 154900 != -69776)
						{
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (92004 - 67367 == 24637)
							{
								this.mChar.DeadEvent();
								if (242561 - 348270 == -105709)
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

	// Token: 0x060013CB RID: 5067 RVA: 0x001F0EC4 File Offset: 0x001EF0C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (225155 - 288337 != -63182)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (54537 - 527334 != -472796)
			{
				float runSpeed = this.mChar.runSpeed;
				if (107479 - 139309 == -31830)
				{
					Vector3 a = default(Vector3);
					if (248194 - 115349 != 132846)
					{
						Vector3 vector = Vector3.zero;
						if (152010 - 9915 == 142095)
						{
							float num2 = (float)0;
							if (197712 - 341626 == -143914)
							{
								if (this.mChar.isMine)
								{
									if (253965 - 472071 == -218105)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (188242 - 460097 == -271854)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (84834 - 582928 == -498093)
										{
											continue;
										}
										a.y = (float)0;
										if (85992 - 84250 == 1743)
										{
											continue;
										}
										a = a.normalized;
										if (184423 - 522814 == -338390)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (85662 - 101870 == -16207)
										{
											continue;
										}
										vector = vector.normalized;
										if (141006 - 589877 == -448870)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (215911 - 211449 == 4463)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (25347 - 207105 != -181758)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (88930 - 201408 != -112478)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (209981 - 528288 != -318307)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (89602 - 316738 != -227136)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (141546 - 361688 == -220141)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (234302 - 572233 == -337930)
														{
															continue;
														}
														this.animation.Play("run");
														if (134399 - 124615 != 9784)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (61353 - 465887 != -404534)
														{
															continue;
														}
														goto IL_67;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (23143 - 563832 != -540689)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (245542 - 145311 == 100232)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (14237 - 528114 == -513876)
											{
												continue;
											}
											num = (float)0;
											if (262626 - 516007 == -253380)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (170667 - 406872 != -236205)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (78008 - 462477 == -384468)
										{
											continue;
										}
									}
									IL_67:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (299742 - 130943 != 168799)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (104553 - 361722 == -257168)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (249176 - 179112 == 70065)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (201212 - 271930 == -70717)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (80425 - 274085 == -193659)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (299390 - 420755 == -121364)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (283966 - 514132 == -230165)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (145188 - 4771 == 140418)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (126153 - 129113 == -2959)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (130874 - 115429 == 15446)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (229524 - 457169 != -227645)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (170781 - 416197 == -245415)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (110863 - 38542 == 72322)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (188161 - 103410 == 84752)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (148121 - 213493 != -65372)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (144429 - 94330 != 50099)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (299786 - 294944 != 4842)
												{
													continue;
												}
												num = (float)0;
												if (287683 - 303553 != -15870)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (17421 - 37935 == -20513)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (286394 - 48411 != 237983)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (37760 - 471839 == -434078)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (273111 - 36294 != 236817)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (42505 - 442609 == -400103)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (27055 - 59153 == -32097)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (143628 - 523998 == -380369)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (188703 - 213743 == -25039)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (278696 - 290418 == -11721)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (183344 - 526026 != -342682)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (229085 - 599127 != -370042)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (102732 - 266449 != -163717)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (180655 - 373864 != -193209)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (150015 - 218947 != -68932)
											{
												continue;
											}
											num = (float)0;
											if (182876 - 17147 != 165729)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (45759 - 474994 == -429234)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (101469 - 37545 == 63925)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (190548 - 165733 != 24815)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (33819 - 264734 == -230914)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (97305 - 337533 == -240228)
								{
									this.mChar.moveSpeed = num;
									if (240159 - 511330 != -271170)
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

	// Token: 0x060013CC RID: 5068 RVA: 0x001F1A28 File Offset: 0x001EFC28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (166001 - 239926 != -73925)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (196612 - 55941 != 140672)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (47437 - 440058 == -392621)
				{
					if (62263 - 477099 != -414835)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (160960 - 416899 == -255938)
							{
								continue;
							}
							v = 1;
							if (55362 - 273592 != -218230)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_fireball_fire")
						{
							if (78829 - 367554 != -288725)
							{
								continue;
							}
							v = 2;
							if (121186 - 736 == 120451)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_fireBall_hit")
						{
							if (82872 - 255723 == -172850)
							{
								continue;
							}
							v = -2;
							if (261331 - 86033 != 175298)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_instantBlaze")
						{
							if (4783 - 516683 != -511900)
							{
								continue;
							}
							v = 11;
							if (96478 - 598874 == -502395)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_skyCrimson")
						{
							if (254310 - 49616 != 204694)
							{
								continue;
							}
							v = 21;
							if (202881 - 232153 != -29272)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_skyCrimson_fire")
						{
							if (257383 - 277579 == -20195)
							{
								continue;
							}
							v = 22;
							if (137491 - 443607 == -306115)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_skyCrimson_hit")
						{
							if (30996 - 575738 != -544742)
							{
								continue;
							}
							v = -22;
							if (150032 - 4532 == 145501)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_rebirth")
						{
							if (278049 - 198405 != 79644)
							{
								continue;
							}
							v = 31;
							if (7413 - 480975 == -473561)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Command: " + ActionName);
							if (51304 - 413010 != -361706)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (212938 - 383464 == -170526)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (192365 - 432891 == -240526)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (203662 - 145990 == 57672)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (233017 - 147193 != 85825)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (213678 - 477921 != -264242)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (188009 - 376762 == -188753)
											{
												Hashtable hashtable = new Hashtable();
												if (100119 - 335853 != -235733)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (17231 - 75480 != -58248)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (12167 - 391446 == -379279)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (41132 - 92617 != -51484)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (118404 - 323566 == -205162)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (55734 - 10592 == 45142)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (82197 - 42900 == 39297)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (205156 - 476985 != -271828)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (100843 - 263047 == -162204)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (184393 - 392078 == -207685)
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

	// Token: 0x060013CD RID: 5069 RVA: 0x001F2070 File Offset: 0x001F0270
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (287376 - 123657 != 163719)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (135219 - 198670 != -63450)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (235395 - 382675 != -147279)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (30293 - 91779 == -61486)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (72580 - 550383 == -477803)
						{
							int num3 = num;
							if (24868 - 200613 == -175745)
							{
								if (num3 == 1)
								{
									if (55453 - 599398 != -543944)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (126323 - 475273 != -348949)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (158324 - 418987 == -260663)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (96503 - 17098 != 79406)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (152080 - 60114 == 91966)
										{
											this.RPC_fireball_fire(vector, vector2, num2);
											if (75998 - 572164 != -496165)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -2)
								{
									if (294229 - 249938 == 44291)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (250469 - 425369 != -174899)
										{
											this.RPC_fireBall_hit(vector, vector2, num2);
											if (95220 - 211022 == -115802)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (27776 - 180385 != -152608)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (89739 - 461046 != -371306)
										{
											this.StartCoroutine_Auto(this.RPC_instantBlaze(vector, vector2, num2));
											if (56750 - 533976 != -477225)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (75262 - 64643 == 10619)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (59503 - 432673 != -373169)
										{
											this.StartCoroutine_Auto(this.RPC_skyCrimson(vector, vector2, num2));
											if (30963 - 74439 != -43475)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 22)
								{
									if (179311 - 519843 != -340531)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (20877 - 340067 == -319190)
										{
											this.RPC_skyCrimson_fire(vector, vector2, num2);
											if (40238 - 430884 != -390645)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -22)
								{
									if (207827 - 82804 == 125023)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (161628 - 593650 != -432021)
										{
											this.RPC_skyCrimson_hit(vector, vector2, num2);
											if (141834 - 343109 != -201274)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (298000 - 464362 != -166361)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (287737 - 196241 != 91497)
										{
											this.StartCoroutine_Auto(this.RPC_rebirth(vector, vector2, num2));
											if (289625 - 168996 == 120629)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (214409 - 256674 == -42265)
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

	// Token: 0x060013CE RID: 5070 RVA: 0x001F25D8 File Offset: 0x001F07D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (150967 - 469306 != -318338)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (225739 - 511612 == -285873)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (59998 - 584834 == -524836)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (1855 - 385706 != -383850)
					{
						Vector3 normalized = vector.normalized;
						if (220450 - 52008 != 168443)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (217670 - 575301 != -357630)
							{
								CharacterControl characterControl = null;
								if (96723 - 66054 != 30670)
								{
									int tID = 0;
									if (122952 - 279099 != -156146)
									{
										if (gameObject)
										{
											if (32645 - 97081 == -64435)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (114163 - 378943 != -264780)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (77846 - 284079 != -206233)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (89416 - 229459 != -140043)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (196370 - 303805 != -107435)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (254016 - 570833 != -316817)
											{
												continue;
											}
										}
										if (this.mChar.isTimeOut("nAttack") != (float)0)
										{
											break;
										}
										if (295467 - 121796 == 173671)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, normalized, tID));
											if (291785 - 24559 == 267226)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (273434 - 592675 == -319241)
												{
													this.ActionEvent("RPC_nAttack", this.transform.position, normalized, tID);
													if (63140 - 282306 != -219165)
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

	// Token: 0x060013CF RID: 5071 RVA: 0x001F28FC File Offset: 0x001F0AFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (207311 - 333835 != -126523)
		{
		}
		for (;;)
		{
			if (this.PhoenixType <= ePhoenixType.Phoenix3)
			{
				if (234293 - 172547 != 61747)
				{
					Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
					if (218629 - 30082 == 188547)
					{
						break;
					}
				}
			}
			else if (!this.mChar.isMine)
			{
				if (118282 - 219718 == -101436)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (59552 - 106392 == -46840)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (34537 - 380236 == -345699)
					{
						Vector3 normalized = vector.normalized;
						if (28125 - 455839 == -427714)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (178017 - 333863 == -155846)
							{
								if (!(this.mChar.actionState == "standby"))
								{
									if (236600 - 64391 != 172209)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (15738 - 574127 == -558388)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("skyCrimson") != (float)0)
								{
									if (155699 - 584628 != -428928)
									{
										Camera.main.SendMessage("newGameMessage", "SkyCrimson is not ready");
										if (57944 - 217683 == -159739)
										{
											break;
										}
									}
								}
								else
								{
									this.StartCoroutine_Auto(this.RPC_skyCrimson(this.transform.position, normalized, 0));
									if (145648 - 517889 != -372240)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (101737 - 228778 == -127041)
										{
											this.ActionEvent("RPC_skyCrimson", this.transform.position, normalized, 0);
											if (260097 - 31951 != 228147)
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

	// Token: 0x060013D0 RID: 5072 RVA: 0x001F2BD4 File Offset: 0x001F0DD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060013D1 RID: 5073 RVA: 0x001F2BD8 File Offset: 0x001F0DD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Phoenix.$RPC_nAttack$18648(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x060013D2 RID: 5074 RVA: 0x001F2BE8 File Offset: 0x001F0DE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_fireball_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (60245 - 186396 != -126150)
		{
		}
		for (;;)
		{
			if (this.fireBall)
			{
				if (205045 - 508703 == -303658)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.fireBall, firePos, Quaternion.LookRotation(fireDir));
					if (244273 - 434720 == -190447)
					{
						ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
						if (117218 - 89307 != 27912)
						{
							projectileControl.Init(this.mChar.ActorNr);
							if (139012 - 86119 != 52894)
							{
								projectileControl.life = (float)2 * this.mChar.rangeMod;
								if (288200 - 299701 == -11501)
								{
									ePhoenixType phoenixType = this.PhoenixType;
									if (274672 - 255939 == 18733)
									{
										if (phoenixType == ePhoenixType.Phoenix1)
										{
											if (41563 - 489301 == -447738)
											{
												gameObject.transform.localScale = 0.5f * Vector3.one;
												if (113508 - 597613 != -484104)
												{
													break;
												}
											}
										}
										else if (phoenixType == ePhoenixType.Phoenix2)
										{
											if (6639 - 315846 != -309206)
											{
												gameObject.transform.localScale = 1f * Vector3.one;
												if (184926 - 474443 == -289517)
												{
													break;
												}
											}
										}
										else if (phoenixType == ePhoenixType.Phoenix3)
										{
											if (282650 - 2047 != 280604)
											{
												gameObject.transform.localScale = 1.5f * Vector3.one;
												if (191422 - 516790 == -325368)
												{
													break;
												}
											}
										}
										else if (phoenixType == ePhoenixType.Phoenix4)
										{
											if (15493 - 245963 != -230469)
											{
												gameObject.transform.localScale = 2f * Vector3.one;
												if (78007 - 327313 != -249305)
												{
													break;
												}
											}
										}
										else if (phoenixType == ePhoenixType.Phoenix5)
										{
											if (275985 - 78899 != 197087)
											{
												gameObject.transform.localScale = 2f * Vector3.one;
												if (219609 - 220889 == -1280)
												{
													break;
												}
											}
										}
										else
										{
											if (phoenixType != ePhoenixType.Phoenix6)
											{
												break;
											}
											if (5501 - 326748 != -321246)
											{
												gameObject.transform.localScale = 2f * Vector3.one;
												if (77831 - 469939 != -392107)
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
			else
			{
				Debug.Log("Cannot find fireball");
				if (107789 - 178307 != -70517)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060013D3 RID: 5075 RVA: 0x001F2F6C File Offset: 0x001F116C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_fireBall_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (68686 - 302103 != -233417)
		{
		}
		for (;;)
		{
			if (this.fireBall_hit)
			{
				if (251345 - 24642 == 226703)
				{
					UnityEngine.Object.Instantiate(this.fireBall_hit, hitPos, Quaternion.identity);
					if (48582 - 92074 == -43492)
					{
						break;
					}
				}
			}
			else
			{
				Debug.Log("Cannot find fireball hit effect");
				if (203117 - 105130 != 97988)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060013D4 RID: 5076 RVA: 0x001F3024 File Offset: 0x001F1224
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_instantBlaze(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Phoenix.$RPC_instantBlaze$18662(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060013D5 RID: 5077 RVA: 0x001F3034 File Offset: 0x001F1234
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_skyCrimson(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Phoenix.$RPC_skyCrimson$18683(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x060013D6 RID: 5078 RVA: 0x001F3044 File Offset: 0x001F1244
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_skyCrimson_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (197101 - 551895 != -354793)
		{
		}
		for (;;)
		{
			if (this.skyCrimson_fire)
			{
				if (230857 - 539759 != -308901)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.skyCrimson_fire, firePos, Quaternion.LookRotation(fireDir));
					if (101658 - 259974 == -158316)
					{
						ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
						if (2084 - 398645 == -396561)
						{
							projectileControl.Init(this.mChar.ActorNr);
							if (290045 - 482577 == -192532)
							{
								projectileControl.life = (float)2 * this.mChar.rangeMod;
								if (99980 - 396096 == -296116)
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
				Debug.Log("Cannot find skyCrimson");
				if (269706 - 140564 != 129143)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060013D7 RID: 5079 RVA: 0x001F318C File Offset: 0x001F138C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_skyCrimson_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (31046 - 258379 != -227333)
		{
		}
		for (;;)
		{
			if (this.skyCrimson_hit)
			{
				if (4564 - 548521 == -543957)
				{
					UnityEngine.Object.Instantiate(this.skyCrimson_hit, hitPos, Quaternion.identity);
					if (143004 - 189873 != -46868)
					{
						break;
					}
				}
			}
			else
			{
				Debug.Log("Cannot find skyCrimson hit effect");
				if (141051 - 142207 == -1156)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060013D8 RID: 5080 RVA: 0x001F3244 File Offset: 0x001F1444
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rebirth(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Phoenix.$RPC_rebirth$18708(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060013D9 RID: 5081 RVA: 0x001F3254 File Offset: 0x001F1454
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator summon(int nRapidFireLv, int nIntenseFireLv, int nSummonerID)
	{
		return new Phoenix.$summon$18722(nRapidFireLv, nIntenseFireLv, nSummonerID, this).GetEnumerator();
	}

	// Token: 0x060013DA RID: 5082 RVA: 0x001F3264 File Offset: 0x001F1464
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_summonAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (183443 - 397820 != -214377)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = this.mChar;
			object obj2;
			object obj = obj2 = PhotonClient.ActorNrList[tID];
			if (!(obj is GameObject))
			{
				obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
			}
			characterControl.myAttackTarget = (GameObject)obj2;
			if (83056 - 348430 != -265373)
			{
				this.mChar.mHateList = new UnityScript.Lang.Array();
				if (215480 - 33991 == 181489)
				{
					this.mChar.addHate(tID, 1200);
					if (148540 - 477457 == -328917)
					{
						this.mChar.isAlert = true;
						if (163842 - 590941 == -427099)
						{
							Phoenix_AI phoenix_AI = (Phoenix_AI)this.GetComponent(typeof(Phoenix_AI));
							if (132067 - 312506 == -180439)
							{
								if (!phoenix_AI)
								{
									break;
								}
								if (101406 - 418000 != -316593)
								{
									phoenix_AI.AI_setTimer(3f);
									if (236397 - 515284 == -278887)
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

	// Token: 0x060013DB RID: 5083 RVA: 0x001F33E8 File Offset: 0x001F15E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_summonDefense(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (129852 - 164907 != -35055)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "standby")
			{
				goto IL_1C7;
			}
			if (275312 - 570044 != -294732)
			{
				continue;
			}
			if (this.mChar.actionState == "run")
			{
				if (218648 - 90897 != 127752)
				{
					goto IL_1C7;
				}
				continue;
			}
			IL_DA:
			this.mChar.mHateList = new UnityScript.Lang.Array();
			if (82116 - 248401 == -166284)
			{
				continue;
			}
			this.mChar.myAttackTarget = null;
			if (256091 - 22338 != 233753)
			{
				continue;
			}
			this.mChar.isAlert = false;
			if (49063 - 478608 != -429545)
			{
				continue;
			}
			Phoenix_AI phoenix_AI = (Phoenix_AI)this.GetComponent(typeof(Phoenix_AI));
			if (235588 - 38121 != 197467)
			{
				continue;
			}
			if (!phoenix_AI)
			{
				break;
			}
			if (164322 - 32693 == 131630)
			{
				continue;
			}
			phoenix_AI.AI_state = "defense";
			if (15830 - 167896 != -152065)
			{
				break;
			}
			continue;
			IL_1C7:
			this.transform.LookAt(global::Math.vFlat(this.mSummoner.transform.position) + new Vector3((float)0, this.transform.position.y, (float)0));
			if (105205 - 167369 != -62163)
			{
				if (!this.pheonix_cry)
				{
					goto IL_DA;
				}
				if (167480 - 533243 != -365762)
				{
					this.audio.PlayOneShot(this.pheonix_cry);
					if (38827 - 590460 == -551633)
					{
						goto IL_DA;
					}
				}
			}
		}
	}

	// Token: 0x060013DC RID: 5084 RVA: 0x001F3628 File Offset: 0x001F1828
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator unsummon()
	{
		return new Phoenix.$unsummon$18738(this).GetEnumerator();
	}

	// Token: 0x060013DD RID: 5085 RVA: 0x001F3638 File Offset: 0x001F1838
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void summonRelease()
	{
		if (271476 - 180503 != 90973)
		{
		}
		for (;;)
		{
			this.mChar.addHate(this.mSummonerChar.ActorNr, 1200);
			if (287230 - 199366 != 87865)
			{
				this.isSummon = false;
				if (58668 - 49812 != 8857)
				{
					this.mSummoner = null;
					if (248487 - 235552 == 12935)
					{
						this.mSummonerChar = null;
						if (294323 - 277991 != 16333)
						{
							this.gameObject.layer = 15;
							if (279657 - 101235 != 178423)
							{
								this.mChar.mOriginalLayer = 15;
								if (209524 - 294014 == -84490)
								{
									this.mChar.mSummoner = null;
									if (226141 - 96182 == 129959)
									{
										this.mChar.isSummon = false;
										if (19894 - 61352 == -41458)
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

	// Token: 0x060013DE RID: 5086 RVA: 0x001F37A4 File Offset: 0x001F19A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
	}

	// Token: 0x060013DF RID: 5087 RVA: 0x001F37A8 File Offset: 0x001F19A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Phoenix.$RPC_dead$18741(nArray, this).GetEnumerator();
	}

	// Token: 0x060013E0 RID: 5088 RVA: 0x001F37B8 File Offset: 0x001F19B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060013E1 RID: 5089 RVA: 0x001F37BC File Offset: 0x001F19BC
	internal static bool g8y8m1O5IRA9Q9vQdw1()
	{
		return true;
	}

	// Token: 0x060013E2 RID: 5090 RVA: 0x001F37C0 File Offset: 0x001F19C0
	internal static bool hSaBvOOpFHnjWDYGJTP()
	{
		return false;
	}

	// Token: 0x04001127 RID: 4391
	public ePhoenixType PhoenixType;

	// Token: 0x04001128 RID: 4392
	public CharacterControl mChar;

	// Token: 0x04001129 RID: 4393
	public AudioClip pheonix_cry;

	// Token: 0x0400112A RID: 4394
	public GameObject fireBall;

	// Token: 0x0400112B RID: 4395
	public GameObject fireBall_hit;

	// Token: 0x0400112C RID: 4396
	public GameObject instantBlaze_ring;

	// Token: 0x0400112D RID: 4397
	public GameObject skyCrimson_dust;

	// Token: 0x0400112E RID: 4398
	public AudioClip pheonix_skyCrimsonFX;

	// Token: 0x0400112F RID: 4399
	public GameObject skyCrimson_fire;

	// Token: 0x04001130 RID: 4400
	public GameObject skyCrimson_hit;

	// Token: 0x04001131 RID: 4401
	public GameObject mSummoner;

	// Token: 0x04001132 RID: 4402
	public bool isSummon;

	// Token: 0x04001133 RID: 4403
	public float followDistance;

	// Token: 0x04001134 RID: 4404
	public CharacterControl mSummonerChar;

	// Token: 0x04001135 RID: 4405
	public int mRapidFireLv;

	// Token: 0x04001136 RID: 4406
	public int mIntenseFireLv;

	// Token: 0x04001137 RID: 4407
	public GameObject summon_ring;

	// Token: 0x04001138 RID: 4408
	public AudioClip pheonix_unsummon;

	// Token: 0x02000366 RID: 870
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$18648 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060013E3 RID: 5091 RVA: 0x001F37C4 File Offset: 0x001F19C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$18648(Vector3 mPos, Vector3 tDir, int tID, Phoenix self_)
		{
			if (125115 - 251934 != -126818)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (206375 - 463936 == -257561)
				{
					base..ctor();
					if (7317 - 256515 != -249197)
					{
						this.$mPos$18658 = mPos;
						if (220231 - 172063 != 48169)
						{
							this.$tDir$18659 = tDir;
							if (242914 - 17111 == 225803)
							{
								this.$tID$18660 = tID;
								if (277804 - 259697 != 18108)
								{
									this.$self_$18661 = self_;
									if (290771 - 259310 != 31462)
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

		// Token: 0x060013E4 RID: 5092 RVA: 0x001F38C4 File Offset: 0x001F1AC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Phoenix.$RPC_nAttack$18648.$(this.$mPos$18658, this.$tDir$18659, this.$tID$18660, this.$self_$18661);
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x001F38E4 File Offset: 0x001F1AE4
		internal static bool AuKaNoOV4RCmXfw50dA()
		{
			return true;
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x001F38E8 File Offset: 0x001F1AE8
		internal static bool nXMww0Otw1jnBpTlNLB()
		{
			return false;
		}

		// Token: 0x04001139 RID: 4409
		internal Vector3 $mPos$18658;

		// Token: 0x0400113A RID: 4410
		internal Vector3 $tDir$18659;

		// Token: 0x0400113B RID: 4411
		internal int $tID$18660;

		// Token: 0x0400113C RID: 4412
		internal Phoenix $self_$18661;

		// Token: 0x02000367 RID: 871
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060013E7 RID: 5095 RVA: 0x001F38EC File Offset: 0x001F1AEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Phoenix self_)
			{
				if (238222 - 366748 != -128525)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (26593 - 357209 != -330615)
					{
						base..ctor();
						if (151563 - 70076 == 81487)
						{
							this.$mPos$18654 = mPos;
							if (171496 - 447879 == -276383)
							{
								this.$tDir$18655 = tDir;
								if (249732 - 584053 == -334321)
								{
									this.$tID$18656 = tID;
									if (124288 - 244663 == -120375)
									{
										this.$self_$18657 = self_;
										if (67881 - 97536 != -29654)
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

			// Token: 0x060013E8 RID: 5096 RVA: 0x001F39EC File Offset: 0x001F1BEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (293201 - 115316 != 177885)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_90B;
					case 1:
						goto IL_C2B;
					case 2:
						break;
					case 3:
						if (this.$self_$18657.mChar.actionState == "attack")
						{
							if (251988 - 210476 == 41513)
							{
								continue;
							}
							if (this.$self_$18657.mChar.myCommand == "nAttack")
							{
								if (203886 - 165208 != 38678)
								{
									continue;
								}
								this.$self_$18657.mChar.actionState = "standby";
								if (70403 - 182176 == -111772)
								{
									continue;
								}
								this.$self_$18657.mChar.actionTime = Time.time;
								if (101470 - 575559 != -474089)
								{
									continue;
								}
								this.$self_$18657.mChar.myCommand = "none";
								if (247690 - 116332 == 131359)
								{
									continue;
								}
								if (!this.$self_$18657.mChar.isMine)
								{
									if (166567 - 440573 == -274005)
									{
										continue;
									}
									this.$self_$18657.mChar.nPosition = this.$self_$18657.transform.position;
									if (275298 - 291178 != -15880)
									{
										continue;
									}
									this.$self_$18657.mChar.oPosition = this.$self_$18657.transform.position;
									if (68563 - 334371 == -265807)
									{
										continue;
									}
									this.$self_$18657.mChar.nDirection = this.$self_$18657.transform.forward;
									if (209084 - 317368 == -108283)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (253865 - 119585 != 134281)
						{
							goto Block_22;
						}
						continue;
					default:
						if (297251 - 339250 != -41999)
						{
							continue;
						}
						goto IL_90B;
					}
					IL_A4E:
					if (this.$self_$18657.mChar.actionTime + 0.5f <= Time.time)
					{
						if (153788 - 440828 != -287040)
						{
							continue;
						}
						if (!this.$self_$18657.mChar.isMine)
						{
							goto IL_77B;
						}
						if (266547 - 442556 != -176009)
						{
							continue;
						}
						this.$firePos$18651 = default(Vector3);
						if (199367 - 549311 != -349944)
						{
							continue;
						}
						this.$fireDir$18652 = default(Vector3);
						if (55114 - 315033 != -259919)
						{
							continue;
						}
						this.$$switch$1211$18653 = this.$self_$18657.PhoenixType;
						if (121236 - 280366 != -159130)
						{
							continue;
						}
						if (this.$$switch$1211$18653 == ePhoenixType.Phoenix1)
						{
							if (209525 - 279267 != -69742)
							{
								continue;
							}
							this.$firePos$18651 = this.$self_$18657.transform.position + this.$self_$18657.transform.TransformDirection((float)0, (float)1, (float)1);
							if (288320 - 59279 != 229041)
							{
								continue;
							}
						}
						else if (this.$$switch$1211$18653 == ePhoenixType.Phoenix2)
						{
							if (237608 - 284295 == -46686)
							{
								continue;
							}
							this.$firePos$18651 = this.$self_$18657.transform.position + this.$self_$18657.transform.TransformDirection((float)0, (float)1, (float)1);
							if (31134 - 457133 == -425998)
							{
								continue;
							}
						}
						else if (this.$$switch$1211$18653 == ePhoenixType.Phoenix3)
						{
							if (213029 - 82021 != 131008)
							{
								continue;
							}
							this.$firePos$18651 = this.$self_$18657.transform.position + this.$self_$18657.transform.TransformDirection((float)0, 2.2f, (float)1);
							if (71001 - 486011 != -415010)
							{
								continue;
							}
						}
						else if (this.$$switch$1211$18653 == ePhoenixType.Phoenix4)
						{
							if (61695 - 437979 == -376283)
							{
								continue;
							}
							this.$firePos$18651 = this.$self_$18657.transform.position + this.$self_$18657.transform.TransformDirection((float)0, 2.4f, (float)1);
							if (221208 - 385439 != -164231)
							{
								continue;
							}
						}
						else if (this.$$switch$1211$18653 == ePhoenixType.Phoenix5)
						{
							if (149060 - 515911 != -366851)
							{
								continue;
							}
							this.$firePos$18651 = this.$self_$18657.transform.position + this.$self_$18657.transform.TransformDirection((float)0, 2.4f, (float)1);
							if (240163 - 90248 != 149915)
							{
								continue;
							}
						}
						else if (this.$$switch$1211$18653 == ePhoenixType.Phoenix6)
						{
							if (190570 - 551126 == -360555)
							{
								continue;
							}
							this.$firePos$18651 = this.$self_$18657.transform.position + this.$self_$18657.transform.TransformDirection((float)0, 2.4f, (float)1);
							if (9002 - 189306 != -180304)
							{
								continue;
							}
						}
						if (this.$tObject$18649)
						{
							if (298808 - 328394 != -29586)
							{
								continue;
							}
							this.$fireDir$18652 = (this.$tObject$18649.collider.bounds.center - this.$firePos$18651).normalized;
							if (299249 - 524277 != -225028)
							{
								continue;
							}
						}
						else
						{
							this.$fireDir$18652 = this.$self_$18657.transform.forward;
							if (173626 - 327222 != -153596)
							{
								continue;
							}
						}
						this.$self_$18657.RPC_fireball_fire(this.$firePos$18651, this.$fireDir$18652, this.$tID$18656);
						if (270561 - 133959 != 136602)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							goto IL_77B;
						}
						if (262116 - 115500 == 146617)
						{
							continue;
						}
						this.$self_$18657.ActionEvent("RPC_fireball_fire", this.$firePos$18651, this.$fireDir$18652, this.$tID$18656);
						if (214339 - 24232 != 190108)
						{
							goto Block_35;
						}
						continue;
					}
					else
					{
						if (this.$self_$18657.mChar.actionState != "attack")
						{
							break;
						}
						if (101267 - 20616 != 80651)
						{
							continue;
						}
						if (this.$self_$18657.mChar.myCommand != "nAttack")
						{
							if (98763 - 194140 != -95376)
							{
								break;
							}
							continue;
						}
						else
						{
							if (!this.$tObject$18649)
							{
								goto IL_A42;
							}
							if (137039 - 58965 == 78075)
							{
								continue;
							}
							this.$self_$18657.transform.LookAt(global::Math.cFlat(this.$tObject$18649.transform.position, this.$self_$18657.transform.position.y));
							if (101427 - 390702 != -289275)
							{
								continue;
							}
							goto IL_A42;
						}
					}
					IL_90B:
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.$tID$18656];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.$tObject$18649 = (GameObject)obj2;
					if (70694 - 593935 != -523240)
					{
						this.$self_$18657.mChar.actionState = "attack";
						if (224601 - 71103 == 153498)
						{
							this.$self_$18657.mChar.actionTime = Time.time;
							if (156875 - 270972 == -114097)
							{
								this.$self_$18657.mChar.myCommand = "nAttack";
								if (262374 - 398938 == -136564)
								{
									if (this.$self_$18657.isSummon)
									{
										if (117149 - 357683 == -240533)
										{
											continue;
										}
										if (this.$self_$18657.mSummonerChar)
										{
											if (20421 - 487131 != -466710)
											{
												continue;
											}
											if (this.$self_$18657.mRapidFireLv > 0)
											{
												if (264874 - 364395 != -99521)
												{
													continue;
												}
												this.$mMag$18650 = (int)Mathf.Clamp((0.1f * (float)this.$self_$18657.mRapidFireLv + 0.1f) * (float)this.$self_$18657.mSummonerChar.mag, (float)1, (float)512);
												if (264585 - 125334 != 139251)
												{
													continue;
												}
												this.$self_$18657.mChar.addTimeOut("nAttack", Mathf.Clamp((float)(5 - this.$mMag$18650 / 32), 0.1f, (float)5));
												if (24774 - 471244 != -446469)
												{
													goto IL_7CA;
												}
												continue;
											}
										}
									}
									this.$self_$18657.mChar.addTimeOut("nAttack", (float)5);
									if (29190 - 104735 == -75544)
									{
										continue;
									}
									IL_7CA:
									this.$self_$18657.transform.position = this.$mPos$18654;
									if (110459 - 2806 != 107654)
									{
										this.$self_$18657.transform.LookAt(this.$mPos$18654 + global::Math.vFlat(this.$tDir$18655));
										if (172684 - 522905 != -350220)
										{
											this.$self_$18657.animation.CrossFade("nAttack");
											if (215831 - 576746 != -360914)
											{
												this.$self_$18657.animation.wrapMode = WrapMode.Once;
												if (95307 - 302610 == -207303)
												{
													this.$self_$18657.mChar.vMovement = this.$self_$18657.transform.forward;
													if (238204 - 133991 == 104213)
													{
														this.$self_$18657.mChar.moveSpeed = (float)0;
														if (275443 - 10718 != 264726)
														{
															if (this.$self_$18657.pheonix_cry)
															{
																if (171648 - 85002 == 86647)
																{
																	continue;
																}
																this.$self_$18657.audio.PlayOneShot(this.$self_$18657.pheonix_cry);
																if (171065 - 470717 != -299652)
																{
																	continue;
																}
															}
															goto IL_A4E;
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
				Block_22:
				goto IL_C2B;
				Block_35:
				IL_77B:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_A42:
				return this.YieldDefault(2);
				IL_C2B:
				return false;
			}

			// Token: 0x060013E9 RID: 5097 RVA: 0x001F4638 File Offset: 0x001F2838
			internal static bool OFdMHAONj5v65JbNp90()
			{
				return true;
			}

			// Token: 0x060013EA RID: 5098 RVA: 0x001F463C File Offset: 0x001F283C
			internal static bool Sf7IJiOY6pYffPgmjNE()
			{
				return false;
			}

			// Token: 0x0400113D RID: 4413
			internal GameObject $tObject$18649;

			// Token: 0x0400113E RID: 4414
			internal int $mMag$18650;

			// Token: 0x0400113F RID: 4415
			internal Vector3 $firePos$18651;

			// Token: 0x04001140 RID: 4416
			internal Vector3 $fireDir$18652;

			// Token: 0x04001141 RID: 4417
			internal ePhoenixType $$switch$1211$18653;

			// Token: 0x04001142 RID: 4418
			internal Vector3 $mPos$18654;

			// Token: 0x04001143 RID: 4419
			internal Vector3 $tDir$18655;

			// Token: 0x04001144 RID: 4420
			internal int $tID$18656;

			// Token: 0x04001145 RID: 4421
			internal Phoenix $self_$18657;
		}
	}

	// Token: 0x02000368 RID: 872
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_instantBlaze$18662 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060013EB RID: 5099 RVA: 0x001F4640 File Offset: 0x001F2840
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_instantBlaze$18662(Vector3 mPos, Vector3 tDir, Phoenix self_)
		{
			if (170613 - 150065 != 20548)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (8250 - 111973 != -103722)
				{
					base..ctor();
					if (88155 - 72660 != 15496)
					{
						this.$mPos$18680 = mPos;
						if (284044 - 277667 != 6378)
						{
							this.$tDir$18681 = tDir;
							if (94330 - 428633 != -334302)
							{
								this.$self_$18682 = self_;
								if (115975 - 460102 != -344126)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x001F471C File Offset: 0x001F291C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Phoenix.$RPC_instantBlaze$18662.$(this.$mPos$18680, this.$tDir$18681, this.$self_$18682);
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x001F4738 File Offset: 0x001F2938
		internal static bool CEZBKeOcemUkBI9Wg8h()
		{
			return true;
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x001F473C File Offset: 0x001F293C
		internal static bool JOlncuOUyjtybUD8TkU()
		{
			return false;
		}

		// Token: 0x04001146 RID: 4422
		internal Vector3 $mPos$18680;

		// Token: 0x04001147 RID: 4423
		internal Vector3 $tDir$18681;

		// Token: 0x04001148 RID: 4424
		internal Phoenix $self_$18682;

		// Token: 0x02000369 RID: 873
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060013EF RID: 5103 RVA: 0x001F4740 File Offset: 0x001F2940
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Phoenix self_)
			{
				if (3624 - 122046 != -118422)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (126961 - 488524 == -361563)
					{
						base..ctor();
						if (32316 - 485057 != -452740)
						{
							this.$mPos$18677 = mPos;
							if (39523 - 392276 != -352752)
							{
								this.$tDir$18678 = tDir;
								if (168190 - 227571 == -59381)
								{
									this.$self_$18679 = self_;
									if (63800 - 349774 != -285973)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060013F0 RID: 5104 RVA: 0x001F481C File Offset: 0x001F2A1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (157652 - 19806 != 137846)
				{
				}
				for (;;)
				{
					IL_E50:
					switch (this._state)
					{
					case 0:
						goto IL_6EE;
					case 1:
						goto IL_101F;
					case 2:
						if (this.$self_$18679.mChar.actionState != "attack")
						{
							goto IL_71D;
						}
						if (103618 - 393236 == -289617)
						{
							continue;
						}
						if (this.$self_$18679.mChar.myCommand != "instantBlaze")
						{
							if (129815 - 244394 != -114578)
							{
								goto Block_76;
							}
							continue;
						}
						else
						{
							this.$self_$18679.mChar.vMovement = this.$self_$18679.transform.forward;
							if (135078 - 97000 != 38078)
							{
								continue;
							}
							this.$self_$18679.mChar.moveSpeed = (float)12;
							if (106107 - 27089 == 79019)
							{
								continue;
							}
							if (this.$self_$18679.instantBlaze_ring)
							{
								if (273316 - 544445 == -271128)
								{
									continue;
								}
								this.$self_$18679.mChar.createEffect(this.$self_$18679.instantBlaze_ring, this.$self_$18679.transform.position, this.$self_$18679.transform.rotation);
								if (156049 - 440560 != -284511)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing instantBlaze_ring effect");
								if (193923 - 256020 == -62096)
								{
									continue;
								}
							}
							this.$collisionLayer$18663 = 130818;
							if (29230 - 243386 == -214155)
							{
								continue;
							}
							this.$collisionList$18664 = Damage.FindAreaTarget(this.$self_$18679.transform.position, (float)50, (float)6, this.$collisionLayer$18663);
							if (47671 - 438640 != -390969)
							{
								continue;
							}
							this.$$iterator$9406$18666 = UnityRuntimeServices.GetEnumerator(this.$collisionList$18664);
							if (143678 - 80798 == 62881)
							{
								continue;
							}
							while (this.$$iterator$9406$18666.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9406$18666.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$collisionObject$18665 = (GameObject)obj2;
								if (18364 - 405006 != -386642)
								{
									goto IL_E50;
								}
								if (this.$collisionObject$18665)
								{
									if (67805 - 248137 == -180331)
									{
										goto IL_E50;
									}
									if (this.$self_$18679.gameObject != this.$collisionObject$18665)
									{
										if (57767 - 549940 != -492173)
										{
											goto IL_E50;
										}
										Physics.IgnoreCollision(this.$self_$18679.gameObject.collider, this.$collisionObject$18665.collider, true);
										if (49835 - 150088 == -100252)
										{
											goto IL_E50;
										}
										UnityRuntimeServices.Update(this.$$iterator$9406$18666, this.$collisionObject$18665);
										if (121445 - 285975 != -164530)
										{
											goto IL_E50;
										}
									}
								}
							}
							if (123922 - 74264 == 49659)
							{
								continue;
							}
							this.$i$18667 = 0;
							if (187158 - 32909 == 154250)
							{
								continue;
							}
						}
						break;
					case 3:
						if (!(this.$self_$18679.mChar.actionState != "attack"))
						{
							if (289778 - 461192 == -171413)
							{
								continue;
							}
							if (this.$self_$18679.mChar.myCommand != "instantBlaze")
							{
								if (181015 - 199036 != -18021)
								{
									continue;
								}
							}
							else
							{
								if (this.$self_$18679.mChar.isMine)
								{
									if (3576 - 393613 == -390036)
									{
										continue;
									}
									this.$hitLayer$18670 = 130816 - (1 << this.$self_$18679.gameObject.layer);
									if (79233 - 100364 != -21131)
									{
										continue;
									}
									this.$hitList$18671 = Damage.FindRecTarget(this.$self_$18679.transform.position - this.$self_$18679.transform.forward, this.$self_$18679.transform.forward, (float)2, (float)2, (float)3, (float)3, this.$hitLayer$18670);
									if (43424 - 301115 == -257690)
									{
										continue;
									}
									this.$$iterator$9408$18674 = UnityRuntimeServices.GetEnumerator(this.$hitList$18671);
									if (213132 - 529971 == -316838)
									{
										continue;
									}
									while (this.$$iterator$9408$18674.MoveNext())
									{
										object obj4;
										object obj3 = obj4 = this.$$iterator$9408$18674.Current;
										if (!(obj3 is GameObject))
										{
											obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
										}
										this.$hitObject$18672 = (GameObject)obj4;
										if (253744 - 352207 != -98463)
										{
											goto IL_E50;
										}
										if (this.$self_$18679.mChar.hit(21, this.$hitObject$18672, this.$self_$18679.mChar.talAdjust(80), 1, 0, Vector3.zero) != 0)
										{
											if (118564 - 314138 != -195574)
											{
												goto IL_E50;
											}
											this.$tChar$18673 = (CharacterControl)this.$hitObject$18672.GetComponent(typeof(CharacterControl));
											if (200767 - 396938 == -196170)
											{
												goto IL_E50;
											}
											UnityRuntimeServices.Update(this.$$iterator$9408$18674, this.$hitObject$18672);
											if (216466 - 304141 == -87674)
											{
												goto IL_E50;
											}
											if (this.$tChar$18673)
											{
												if (179616 - 372047 != -192431)
												{
													goto IL_E50;
												}
												this.$tChar$18673.RPC_AddStatus("burn", 4, Damage.getDebuff((float)8, this.$self_$18679.mChar.cha, this.$tChar$18673.cha), 0, this.$self_$18679.mChar.ActorNr);
												if (207007 - 16425 == 190583)
												{
													goto IL_E50;
												}
											}
										}
									}
									if (38394 - 440065 == -401670)
									{
										continue;
									}
								}
								this.$i$18667++;
								if (143933 - 150048 != -6115)
								{
									continue;
								}
								break;
							}
						}
						this.$$iterator$9407$18669 = UnityRuntimeServices.GetEnumerator(this.$collisionList$18664);
						if (15165 - 106256 != -91091)
						{
							continue;
						}
						while (this.$$iterator$9407$18669.MoveNext())
						{
							object obj6;
							object obj5 = obj6 = this.$$iterator$9407$18669.Current;
							if (!(obj5 is GameObject))
							{
								obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
							}
							this.$collisionObject$18668 = (GameObject)obj6;
							if (293848 - 299583 == -5734)
							{
								goto IL_E50;
							}
							if (this.$collisionObject$18668)
							{
								if (9039 - 599065 != -590026)
								{
									goto IL_E50;
								}
								if (this.$self_$18679.gameObject != this.$collisionObject$18668)
								{
									if (92991 - 595454 == -502462)
									{
										goto IL_E50;
									}
									Physics.IgnoreCollision(this.$self_$18679.gameObject.collider, this.$collisionObject$18668.collider, false);
									if (31356 - 310765 != -279409)
									{
										goto IL_E50;
									}
									UnityRuntimeServices.Update(this.$$iterator$9407$18669, this.$collisionObject$18668);
									if (32202 - 35762 == -3559)
									{
										goto IL_E50;
									}
								}
							}
						}
						if (161597 - 163554 != -1956)
						{
							goto Block_60;
						}
						continue;
					case 4:
						if (this.$self_$18679.mChar.actionState != "attack")
						{
							goto IL_E1F;
						}
						if (51226 - 544316 != -493090)
						{
							continue;
						}
						if (this.$self_$18679.mChar.myCommand != "instantBlaze")
						{
							if (93481 - 489747 != -396266)
							{
								continue;
							}
							goto IL_E1F;
						}
						else
						{
							this.$self_$18679.mChar.moveSpeed = (float)0;
							if (7711 - 232431 != -224720)
							{
								continue;
							}
							goto IL_562;
						}
						break;
					case 5:
						if (this.$self_$18679.mChar.actionState == "attack")
						{
							if (35084 - 447125 == -412040)
							{
								continue;
							}
							if (this.$self_$18679.mChar.myCommand == "instantBlaze")
							{
								if (109235 - 453534 != -344299)
								{
									continue;
								}
								this.$self_$18679.mChar.actionState = "standby";
								if (127595 - 314834 == -187238)
								{
									continue;
								}
								this.$self_$18679.mChar.actionTime = Time.time;
								if (15412 - 256463 == -241050)
								{
									continue;
								}
								this.$self_$18679.mChar.myCommand = "none";
								if (148709 - 160626 == -11916)
								{
									continue;
								}
								if (!this.$self_$18679.mChar.isMine)
								{
									if (141315 - 98065 == 43251)
									{
										continue;
									}
									this.$self_$18679.mChar.nPosition = this.$self_$18679.transform.position;
									if (54191 - 525796 == -471604)
									{
										continue;
									}
									this.$self_$18679.mChar.oPosition = this.$self_$18679.transform.position;
									if (209148 - 261866 == -52717)
									{
										continue;
									}
									this.$self_$18679.mChar.nDirection = this.$self_$18679.transform.forward;
									if (28248 - 231648 == -203399)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (89850 - 304975 != -215125)
						{
							continue;
						}
						goto IL_101F;
					default:
						if (611 - 435513 != -434902)
						{
							continue;
						}
						goto IL_6EE;
					}
					if (this.$i$18667 < 4)
					{
						goto IL_85D;
					}
					if (70326 - 490159 != -419833)
					{
						continue;
					}
					this.$self_$18679.mChar.moveSpeed = (float)6;
					if (7949 - 103167 != -95218)
					{
						continue;
					}
					if (this.$self_$18679.mChar.isMine)
					{
						if (132445 - 120891 != 11554)
						{
							continue;
						}
						this.$self_$18679.mChar.RPC_AddHeal(21, 200, 0, 0, 0, 0, this.$self_$18679.mChar.ActorNr);
						if (249847 - 330616 == -80768)
						{
							continue;
						}
					}
					this.$$iterator$9409$18676 = UnityRuntimeServices.GetEnumerator(this.$collisionList$18664);
					if (244830 - 363566 == -118735)
					{
						continue;
					}
					while (this.$$iterator$9409$18676.MoveNext())
					{
						object obj8;
						object obj7 = obj8 = this.$$iterator$9409$18676.Current;
						if (!(obj7 is GameObject))
						{
							obj8 = RuntimeServices.Coerce(obj7, typeof(GameObject));
						}
						this.$collisionObject$18675 = (GameObject)obj8;
						if (40719 - 344381 != -303662)
						{
							goto IL_E50;
						}
						if (this.$collisionObject$18675)
						{
							if (182841 - 165613 != 17228)
							{
								goto IL_E50;
							}
							if (this.$self_$18679.gameObject != this.$collisionObject$18675)
							{
								if (32466 - 424577 != -392111)
								{
									goto IL_E50;
								}
								Physics.IgnoreCollision(this.$self_$18679.gameObject.collider, this.$collisionObject$18675.collider, false);
								if (41013 - 364366 != -323353)
								{
									goto IL_E50;
								}
								UnityRuntimeServices.Update(this.$$iterator$9409$18676, this.$collisionObject$18675);
								if (227949 - 68424 == 159526)
								{
									goto IL_E50;
								}
							}
						}
					}
					if (211445 - 197225 != 14221)
					{
						goto Block_80;
					}
					continue;
					IL_6EE:
					this.$self_$18679.mChar.actionState = "attack";
					if (123448 - 161632 != -38183)
					{
						this.$self_$18679.mChar.actionTime = Time.time;
						if (11889 - 519389 != -507499)
						{
							this.$self_$18679.mChar.myCommand = "instantBlaze";
							if (279700 - 486111 != -206410)
							{
								this.$self_$18679.mChar.addTimeOut("instantBlaze", this.$self_$18679.mChar.agiAdjust((float)30));
								if (238770 - 169731 == 69039)
								{
									this.$self_$18679.transform.position = this.$mPos$18677;
									if (93894 - 364218 == -270324)
									{
										this.$self_$18679.transform.LookAt(this.$mPos$18677 + global::Math.vFlat(this.$tDir$18678));
										if (46462 - 326503 == -280041)
										{
											this.$self_$18679.animation.CrossFade("instantBlaze", 0.2f);
											if (280333 - 542621 != -262287)
											{
												this.$self_$18679.animation.wrapMode = WrapMode.Once;
												if (74582 - 259678 != -185095)
												{
													this.$self_$18679.mChar.vMovement = this.$self_$18679.transform.forward;
													if (184055 - 317527 == -133472)
													{
														this.$self_$18679.mChar.moveSpeed = (float)0;
														if (86140 - 411985 == -325845)
														{
															if (!this.$self_$18679.pheonix_cry)
															{
																break;
															}
															if (56876 - 273086 == -216210)
															{
																this.$self_$18679.audio.PlayOneShot(this.$self_$18679.pheonix_cry);
																if (76134 - 127359 == -51225)
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
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_562:
				return this.Yield(5, new WaitForSeconds(0.1f));
				IL_71D:
				goto IL_101F;
				IL_85D:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_60:
				Block_76:
				goto IL_71D;
				Block_80:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_E1F:
				IL_101F:
				return false;
			}

			// Token: 0x060013F1 RID: 5105 RVA: 0x001F585C File Offset: 0x001F3A5C
			internal static bool AracwiOTootkBDb3Kkk()
			{
				return true;
			}

			// Token: 0x060013F2 RID: 5106 RVA: 0x001F5860 File Offset: 0x001F3A60
			internal static bool xLVh1tO3qna3343G694()
			{
				return false;
			}

			// Token: 0x04001149 RID: 4425
			internal int $collisionLayer$18663;

			// Token: 0x0400114A RID: 4426
			internal UnityScript.Lang.Array $collisionList$18664;

			// Token: 0x0400114B RID: 4427
			internal GameObject $collisionObject$18665;

			// Token: 0x0400114C RID: 4428
			internal IEnumerator $$iterator$9406$18666;

			// Token: 0x0400114D RID: 4429
			internal int $i$18667;

			// Token: 0x0400114E RID: 4430
			internal GameObject $collisionObject$18668;

			// Token: 0x0400114F RID: 4431
			internal IEnumerator $$iterator$9407$18669;

			// Token: 0x04001150 RID: 4432
			internal int $hitLayer$18670;

			// Token: 0x04001151 RID: 4433
			internal UnityScript.Lang.Array $hitList$18671;

			// Token: 0x04001152 RID: 4434
			internal GameObject $hitObject$18672;

			// Token: 0x04001153 RID: 4435
			internal CharacterControl $tChar$18673;

			// Token: 0x04001154 RID: 4436
			internal IEnumerator $$iterator$9408$18674;

			// Token: 0x04001155 RID: 4437
			internal GameObject $collisionObject$18675;

			// Token: 0x04001156 RID: 4438
			internal IEnumerator $$iterator$9409$18676;

			// Token: 0x04001157 RID: 4439
			internal Vector3 $mPos$18677;

			// Token: 0x04001158 RID: 4440
			internal Vector3 $tDir$18678;

			// Token: 0x04001159 RID: 4441
			internal Phoenix $self_$18679;
		}
	}

	// Token: 0x0200036A RID: 874
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_skyCrimson$18683 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060013F3 RID: 5107 RVA: 0x001F5864 File Offset: 0x001F3A64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_skyCrimson$18683(Vector3 mPos, Vector3 tDir, int tID, Phoenix self_)
		{
			if (286194 - 352548 != -66353)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (82541 - 268344 == -185803)
				{
					base..ctor();
					if (266146 - 520739 == -254593)
					{
						this.$mPos$18704 = mPos;
						if (211446 - 417950 != -206503)
						{
							this.$tDir$18705 = tDir;
							if (32191 - 501907 != -469715)
							{
								this.$tID$18706 = tID;
								if (207929 - 247575 == -39646)
								{
									this.$self_$18707 = self_;
									if (41470 - 535511 == -494041)
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

		// Token: 0x060013F4 RID: 5108 RVA: 0x001F5964 File Offset: 0x001F3B64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Phoenix.$RPC_skyCrimson$18683.$(this.$mPos$18704, this.$tDir$18705, this.$tID$18706, this.$self_$18707);
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x001F5984 File Offset: 0x001F3B84
		internal static bool uGVuK8OXuEjXjq2MYmj()
		{
			return true;
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x001F5988 File Offset: 0x001F3B88
		internal static bool ADJSNYOQHneYivMqKk3()
		{
			return false;
		}

		// Token: 0x0400115A RID: 4442
		internal Vector3 $mPos$18704;

		// Token: 0x0400115B RID: 4443
		internal Vector3 $tDir$18705;

		// Token: 0x0400115C RID: 4444
		internal int $tID$18706;

		// Token: 0x0400115D RID: 4445
		internal Phoenix $self_$18707;

		// Token: 0x0200036B RID: 875
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060013F7 RID: 5111 RVA: 0x001F598C File Offset: 0x001F3B8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Phoenix self_)
			{
				if (207097 - 423441 != -216344)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (7472 - 297190 == -289718)
					{
						base..ctor();
						if (182383 - 372019 == -189636)
						{
							this.$mPos$18700 = mPos;
							if (261401 - 202029 == 59372)
							{
								this.$tDir$18701 = tDir;
								if (80710 - 536391 != -455680)
								{
									this.$tID$18702 = tID;
									if (258221 - 230510 != 27712)
									{
										this.$self_$18703 = self_;
										if (140044 - 232367 != -92322)
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

			// Token: 0x060013F8 RID: 5112 RVA: 0x001F5A8C File Offset: 0x001F3C8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (115646 - 545086 != -429440)
				{
				}
				for (;;)
				{
					IL_904:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_10BC;
					case 2:
						if (this.$self_$18703.mChar.actionState != "attack")
						{
							goto IL_2A5;
						}
						if (237141 - 528325 == -291183)
						{
							continue;
						}
						if (this.$self_$18703.mChar.myCommand != "skyCrimson")
						{
							if (269940 - 486631 != -216691)
							{
								continue;
							}
							goto IL_2A5;
						}
						else
						{
							this.$mRendererList$18684 = this.$self_$18703.gameObject.GetComponentsInChildren(typeof(Renderer));
							if (149314 - 192841 == -43526)
							{
								continue;
							}
							this.$$11064$18694 = 0;
							if (244502 - 597834 != -353332)
							{
								continue;
							}
							this.$$11065$18695 = this.$mRendererList$18684;
							if (292205 - 23912 != 268293)
							{
								continue;
							}
							this.$$11066$18696 = this.$$11065$18695.Length;
							if (264000 - 495420 == -231419)
							{
								continue;
							}
							while (this.$$11064$18694 < this.$$11066$18696)
							{
								((Renderer)this.$$11065$18695[this.$$11064$18694]).enabled = false;
								if (187349 - 151103 == 36247)
								{
									goto IL_904;
								}
								this.$$11064$18694++;
								if (202385 - 474343 != -271958)
								{
									goto IL_904;
								}
							}
							if (44663 - 54437 == -9773)
							{
								continue;
							}
							if (!(this.$self_$18703.gameObject == Game.mPlayer))
							{
								if (14260 - 479642 != -465382)
								{
									continue;
								}
								if (!this.$self_$18703.mSummoner)
								{
									goto IL_F87;
								}
								if (95179 - 11317 == 83863)
								{
									continue;
								}
								if (!(this.$self_$18703.mSummoner == Game.mPlayer))
								{
									goto IL_F87;
								}
								if (107922 - 486629 != -378707)
								{
									continue;
								}
							}
							this.$mCameraEffect$18686 = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
							if (248533 - 170565 == 77969)
							{
								continue;
							}
							this.$mCameraEffect$18686.AddColorRamp("crimsonRamp", "none", (float)1, new Vector4((float)0, 0.5f, 0.5f, 0.5f));
							if (183338 - 559745 != -376407)
							{
								continue;
							}
							goto IL_F87;
						}
						break;
					case 3:
						if (this.$self_$18703.mChar.actionState != "attack")
						{
							goto IL_783;
						}
						if (108950 - 202624 != -93674)
						{
							continue;
						}
						if (this.$self_$18703.mChar.myCommand != "skyCrimson")
						{
							if (106115 - 456602 != -350486)
							{
								goto Block_66;
							}
							continue;
						}
						else
						{
							if (this.$self_$18703.mChar.isMine)
							{
								if (104787 - 245752 == -140964)
								{
									continue;
								}
								this.$hitLayer$18687 = 130816;
								if (170681 - 339746 == -169064)
								{
									continue;
								}
								if (this.$self_$18703.mSummoner)
								{
									if (58104 - 335641 == -277536)
									{
										continue;
									}
									this.$hitLayer$18687 -= 1 << this.$self_$18703.mSummoner.layer;
									if (72178 - 385856 != -313678)
									{
										continue;
									}
								}
								this.$hitList$18688 = Damage.FindAreaTarget(this.$self_$18703.transform.position, (float)24, (float)6, this.$hitLayer$18687);
								if (105491 - 515517 != -410026)
								{
									continue;
								}
								this.$$iterator$9410$18692 = UnityRuntimeServices.GetEnumerator(this.$hitList$18688);
								if (131098 - 69864 == 61235)
								{
									continue;
								}
								while (this.$$iterator$9410$18692.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$9410$18692.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$18689 = (GameObject)obj2;
									if (36774 - 317377 == -280602)
									{
										goto IL_904;
									}
									this.$fireDir$18690 = (this.$hitObject$18689.collider.bounds.center - this.$self_$18703.transform.position - (float)20 * Vector3.up).normalized;
									if (16766 - 66260 != -49494)
									{
										goto IL_904;
									}
									UnityRuntimeServices.Update(this.$$iterator$9410$18692, this.$hitObject$18689);
									if (274957 - 344175 != -69218)
									{
										goto IL_904;
									}
									this.$firePos$18691 = this.$hitObject$18689.collider.bounds.center - this.$fireDir$18690 * (float)12;
									if (61017 - 499254 != -438237)
									{
										goto IL_904;
									}
									UnityRuntimeServices.Update(this.$$iterator$9410$18692, this.$hitObject$18689);
									if (169189 - 107996 != 61193)
									{
										goto IL_904;
									}
									this.$self_$18703.RPC_skyCrimson_fire(this.$firePos$18691, this.$fireDir$18690, this.$tID$18702);
									if (232350 - 202352 != 29998)
									{
										goto IL_904;
									}
									if (PhotonClient.IsInitialized())
									{
										if (202927 - 159875 != 43052)
										{
											goto IL_904;
										}
										this.$self_$18703.ActionEvent("RPC_skyCrimson_fire", this.$firePos$18691, this.$fireDir$18690, this.$tID$18702);
										if (202743 - 188677 != 14066)
										{
											goto IL_904;
										}
									}
								}
								if (84597 - 576156 != -491559)
								{
									continue;
								}
							}
							if (!this.$self_$18703.pheonix_skyCrimsonFX)
							{
								goto IL_40D;
							}
							if (113318 - 404866 != -291548)
							{
								continue;
							}
							this.$self_$18703.audio.PlayOneShot(this.$self_$18703.pheonix_skyCrimsonFX);
							if (239525 - 136155 != 103370)
							{
								continue;
							}
							goto IL_40D;
						}
						break;
					case 4:
						if (this.$self_$18703.mChar.actionState != "attack")
						{
							goto IL_3AD;
						}
						if (72853 - 511057 == -438203)
						{
							continue;
						}
						if (this.$self_$18703.mChar.myCommand != "skyCrimson")
						{
							if (196861 - 450683 != -253821)
							{
								goto Block_61;
							}
							continue;
						}
						else
						{
							this.$self_$18703.animation.Play("skyCrimson2");
							if (112665 - 75682 == 36984)
							{
								continue;
							}
							this.$$11068$18697 = 0;
							if (241499 - 336559 != -95060)
							{
								continue;
							}
							this.$$11069$18698 = this.$mRendererList$18684;
							if (219543 - 505977 != -286434)
							{
								continue;
							}
							this.$$11070$18699 = this.$$11069$18698.Length;
							if (55100 - 200068 != -144968)
							{
								continue;
							}
							while (this.$$11068$18697 < this.$$11070$18699)
							{
								if ((Renderer)this.$$11069$18698[this.$$11068$18697])
								{
									if (280934 - 540819 != -259885)
									{
										goto IL_904;
									}
									((Renderer)this.$$11069$18698[this.$$11068$18697]).enabled = true;
									if (276250 - 517563 == -241312)
									{
										goto IL_904;
									}
								}
								this.$$11068$18697++;
								if (69659 - 36271 != 33388)
								{
									goto IL_904;
								}
							}
							if (13865 - 436443 != -422577)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$18703.mChar.actionState != "attack")
						{
							goto IL_208;
						}
						if (265887 - 185301 == 80587)
						{
							continue;
						}
						if (this.$self_$18703.mChar.myCommand != "skyCrimson")
						{
							if (179613 - 237230 != -57616)
							{
								goto Block_54;
							}
							continue;
						}
						else
						{
							if (this.$self_$18703.skyCrimson_dust)
							{
								if (227120 - 267400 == -40279)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$18703.skyCrimson_dust, this.$self_$18703.transform.position, this.$self_$18703.transform.rotation);
								if (147643 - 465793 != -318150)
								{
									continue;
								}
							}
							else
							{
								Debug.Log("Cannot find skyCrimson dust");
								if (113858 - 579985 == -466126)
								{
									continue;
								}
							}
							if (!this.$self_$18703.mChar.isMine)
							{
								goto IL_575;
							}
							if (226046 - 543553 != -317507)
							{
								continue;
							}
							this.$self_$18703.mChar.RPC_AddHeal(21, 300, 0, 0, 0, 0, this.$self_$18703.mChar.ActorNr);
							if (89451 - 395410 != -305959)
							{
								continue;
							}
							goto IL_575;
						}
						break;
					case 6:
						if (this.$self_$18703.mChar.actionState == "attack")
						{
							if (185616 - 276384 == -90767)
							{
								continue;
							}
							if (this.$self_$18703.mChar.myCommand == "skyCrimson")
							{
								if (7268 - 439628 == -432359)
								{
									continue;
								}
								this.$self_$18703.mChar.actionState = "standby";
								if (221208 - 86322 != 134886)
								{
									continue;
								}
								this.$self_$18703.mChar.actionTime = Time.time;
								if (212161 - 54393 == 157769)
								{
									continue;
								}
								this.$self_$18703.mChar.myCommand = "none";
								if (248521 - 139369 != 109152)
								{
									continue;
								}
								if (!this.$self_$18703.mChar.isMine)
								{
									if (23012 - 200798 != -177786)
									{
										continue;
									}
									this.$self_$18703.mChar.nPosition = this.$self_$18703.transform.position;
									if (250537 - 522454 != -271917)
									{
										continue;
									}
									this.$self_$18703.mChar.oPosition = this.$self_$18703.transform.position;
									if (149007 - 592330 != -443323)
									{
										continue;
									}
									this.$self_$18703.mChar.nDirection = this.$self_$18703.transform.forward;
									if (87038 - 32594 == 54445)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (81392 - 79233 != 2160)
						{
							goto Block_33;
						}
						continue;
					default:
						if (79244 - 214665 != -135421)
						{
							continue;
						}
						break;
					}
					this.$self_$18703.mChar.actionState = "attack";
					if (164930 - 130528 != 34403)
					{
						this.$self_$18703.mChar.actionTime = Time.time;
						if (28418 - 283944 == -255526)
						{
							this.$self_$18703.mChar.myCommand = "skyCrimson";
							if (261421 - 466420 == -204999)
							{
								this.$self_$18703.mChar.addTimeOut("skyCrimson", this.$self_$18703.mChar.agiAdjust((float)60));
								if (144985 - 15630 == 129355)
								{
									this.$self_$18703.transform.position = this.$mPos$18700;
									if (167088 - 115606 == 51482)
									{
										this.$self_$18703.transform.LookAt(this.$mPos$18700 + global::Math.vFlat(this.$tDir$18701));
										if (169966 - 431154 != -261187)
										{
											this.$self_$18703.animation.CrossFade("skyCrimson1", 0.2f);
											if (221531 - 225330 != -3798)
											{
												this.$self_$18703.animation.wrapMode = WrapMode.Once;
												if (80407 - 402535 != -322127)
												{
													this.$self_$18703.mChar.vMovement = this.$self_$18703.transform.forward;
													if (105429 - 580080 == -474651)
													{
														this.$self_$18703.mChar.moveSpeed = (float)0;
														if (60400 - 488717 == -428317)
														{
															this.$self_$18703.mChar.StartCoroutine_Auto(this.$self_$18703.mChar.addStatus("noDamage", 1, 5, 0, this.$self_$18703.mChar.ActorNr));
															if (224963 - 508122 != -283158)
															{
																this.$self_$18703.mChar.StartCoroutine_Auto(this.$self_$18703.mChar.addStatus("noForce", 1, 5, 0, this.$self_$18703.mChar.ActorNr));
																if (230503 - 438489 != -207985)
																{
																	if (this.$self_$18703.pheonix_cry)
																	{
																		if (145384 - 97299 == 48086)
																		{
																			continue;
																		}
																		this.$self_$18703.audio.PlayOneShot(this.$self_$18703.pheonix_cry);
																		if (162386 - 319208 == -156821)
																		{
																			continue;
																		}
																	}
																	if (this.$self_$18703.skyCrimson_dust)
																	{
																		if (292265 - 592087 == -299822)
																		{
																			UnityEngine.Object.Instantiate(this.$self_$18703.skyCrimson_dust, this.$self_$18703.transform.position, this.$self_$18703.transform.rotation);
																			if (243999 - 64797 == 179202)
																			{
																				break;
																			}
																		}
																	}
																	else
																	{
																		Debug.Log("Cannot find skyCrimson dust");
																		if (76965 - 80418 != -3452)
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
				IL_79:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_208:
				IL_2A5:
				IL_3AD:
				goto IL_10BC;
				Block_26:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_40D:
				return this.Yield(4, new WaitForSeconds((float)2));
				Block_33:
				goto IL_10BC;
				IL_575:
				return this.Yield(6, new WaitForSeconds(0.5f));
				goto IL_79;
				IL_783:
				goto IL_10BC;
				Block_54:
				Block_61:
				Block_66:
				goto IL_783;
				IL_F87:
				return this.Yield(3, new WaitForSeconds((float)1));
				IL_10BC:
				return false;
			}

			// Token: 0x060013F9 RID: 5113 RVA: 0x001F6B68 File Offset: 0x001F4D68
			internal static bool mFKl4BOkOWRd2Aygn6U()
			{
				return true;
			}

			// Token: 0x060013FA RID: 5114 RVA: 0x001F6B6C File Offset: 0x001F4D6C
			internal static bool XojPw6OGpNJwFvjQ4F1()
			{
				return false;
			}

			// Token: 0x0400115E RID: 4446
			internal Component[] $mRendererList$18684;

			// Token: 0x0400115F RID: 4447
			internal Renderer $mRenderer$18685;

			// Token: 0x04001160 RID: 4448
			internal CameraEffect $mCameraEffect$18686;

			// Token: 0x04001161 RID: 4449
			internal int $hitLayer$18687;

			// Token: 0x04001162 RID: 4450
			internal UnityScript.Lang.Array $hitList$18688;

			// Token: 0x04001163 RID: 4451
			internal GameObject $hitObject$18689;

			// Token: 0x04001164 RID: 4452
			internal Vector3 $fireDir$18690;

			// Token: 0x04001165 RID: 4453
			internal Vector3 $firePos$18691;

			// Token: 0x04001166 RID: 4454
			internal IEnumerator $$iterator$9410$18692;

			// Token: 0x04001167 RID: 4455
			internal Renderer $mRenderer$18693;

			// Token: 0x04001168 RID: 4456
			internal int $$11064$18694;

			// Token: 0x04001169 RID: 4457
			internal Component[] $$11065$18695;

			// Token: 0x0400116A RID: 4458
			internal int $$11066$18696;

			// Token: 0x0400116B RID: 4459
			internal int $$11068$18697;

			// Token: 0x0400116C RID: 4460
			internal Component[] $$11069$18698;

			// Token: 0x0400116D RID: 4461
			internal int $$11070$18699;

			// Token: 0x0400116E RID: 4462
			internal Vector3 $mPos$18700;

			// Token: 0x0400116F RID: 4463
			internal Vector3 $tDir$18701;

			// Token: 0x04001170 RID: 4464
			internal int $tID$18702;

			// Token: 0x04001171 RID: 4465
			internal Phoenix $self_$18703;
		}
	}

	// Token: 0x0200036C RID: 876
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rebirth$18708 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060013FB RID: 5115 RVA: 0x001F6B70 File Offset: 0x001F4D70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rebirth$18708(Vector3 mPos, Vector3 tDir, Phoenix self_)
		{
			if (14165 - 513890 != -499724)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (256323 - 232170 != 24154)
				{
					base..ctor();
					if (114687 - 261117 == -146430)
					{
						this.$mPos$18719 = mPos;
						if (34047 - 345039 != -310991)
						{
							this.$tDir$18720 = tDir;
							if (84971 - 139262 == -54291)
							{
								this.$self_$18721 = self_;
								if (291603 - 382638 != -91034)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x001F6C4C File Offset: 0x001F4E4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Phoenix.$RPC_rebirth$18708.$(this.$mPos$18719, this.$tDir$18720, this.$self_$18721);
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x001F6C68 File Offset: 0x001F4E68
		internal static bool j6jlSoOH2hRAgLt49GS()
		{
			return true;
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x001F6C6C File Offset: 0x001F4E6C
		internal static bool Vb3ZBgOWkbyv19SQLiQ()
		{
			return false;
		}

		// Token: 0x04001172 RID: 4466
		internal Vector3 $mPos$18719;

		// Token: 0x04001173 RID: 4467
		internal Vector3 $tDir$18720;

		// Token: 0x04001174 RID: 4468
		internal Phoenix $self_$18721;

		// Token: 0x0200036D RID: 877
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060013FF RID: 5119 RVA: 0x001F6C70 File Offset: 0x001F4E70
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Phoenix self_)
			{
				if (25245 - 283985 != -258739)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (291473 - 439534 != -148060)
					{
						base..ctor();
						if (196991 - 363155 == -166164)
						{
							this.$mPos$18716 = mPos;
							if (286082 - 353741 != -67658)
							{
								this.$tDir$18717 = tDir;
								if (131962 - 283122 == -151160)
								{
									this.$self_$18718 = self_;
									if (240140 - 226129 == 14011)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06001400 RID: 5120 RVA: 0x001F6D4C File Offset: 0x001F4F4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (122415 - 424372 != -301957)
				{
				}
				for (;;)
				{
					IL_DD:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_AB1;
					case 2:
						if (this.$self_$18718.mChar.actionState != "dead")
						{
							goto IL_224;
						}
						if (178089 - 123067 != 55022)
						{
							continue;
						}
						if (this.$self_$18718.mChar.myCommand != "rebirth")
						{
							if (78556 - 53204 != 25352)
							{
								continue;
							}
							goto IL_224;
						}
						else
						{
							this.$self_$18718.mChar.hp = this.$self_$18718.mChar.mhp;
							if (181603 - 373451 == -191847)
							{
								continue;
							}
							this.$mRebirthLv$18709 = 1;
							if (248332 - 577929 == -329596)
							{
								continue;
							}
							this.$$switch$1215$18710 = this.$self_$18718.PhoenixType;
							if (248261 - 170477 != 77784)
							{
								continue;
							}
							if (this.$$switch$1215$18710 == ePhoenixType.Phoenix1)
							{
								if (148673 - 225094 == -76420)
								{
									continue;
								}
								this.$mRebirthLv$18709 = 1;
								if (53556 - 378881 != -325325)
								{
									continue;
								}
							}
							else if (this.$$switch$1215$18710 == ePhoenixType.Phoenix2)
							{
								if (233895 - 265974 != -32079)
								{
									continue;
								}
								this.$mRebirthLv$18709 = 2;
								if (42513 - 213320 != -170807)
								{
									continue;
								}
							}
							else if (this.$$switch$1215$18710 == ePhoenixType.Phoenix3)
							{
								if (23584 - 23040 != 544)
								{
									continue;
								}
								this.$mRebirthLv$18709 = 3;
								if (156576 - 339980 == -183403)
								{
									continue;
								}
							}
							else if (this.$$switch$1215$18710 == ePhoenixType.Phoenix4)
							{
								if (97597 - 118337 == -20739)
								{
									continue;
								}
								this.$mRebirthLv$18709 = 4;
								if (281090 - 597508 != -316418)
								{
									continue;
								}
							}
							else if (this.$$switch$1215$18710 == ePhoenixType.Phoenix5)
							{
								if (288726 - 565408 == -276681)
								{
									continue;
								}
								this.$mRebirthLv$18709 = 5;
								if (182568 - 241611 == -59042)
								{
									continue;
								}
							}
							else if (this.$$switch$1215$18710 == ePhoenixType.Phoenix6)
							{
								if (67997 - 576272 == -508274)
								{
									continue;
								}
								this.$mRebirthLv$18709 = 6;
								if (165637 - 317882 == -152244)
								{
									continue;
								}
							}
							this.$self_$18718.animation.Play("summon");
							if (223711 - 569032 == -345320)
							{
								continue;
							}
							this.$self_$18718.animation.wrapMode = WrapMode.Once;
							if (167679 - 13230 == 154450)
							{
								continue;
							}
							if (this.$self_$18718.summon_ring)
							{
								if (96205 - 254871 != -158666)
								{
									continue;
								}
								this.$mSummon_ring$18711 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$18718.summon_ring, this.$self_$18718.transform.position, Quaternion.identity);
								if (40461 - 421604 == -381142)
								{
									continue;
								}
								this.$mSummon_ring$18711.transform.localScale = 0.5f * (float)this.$mRebirthLv$18709 * Vector3.one;
								if (116904 - 282330 == -165425)
								{
									continue;
								}
							}
							else
							{
								Debug.Log("Cannot find summon ring Effect");
								if (18385 - 294655 != -276270)
								{
									continue;
								}
							}
							if (!this.$self_$18718.mChar.isMine)
							{
								goto IL_646;
							}
							if (171256 - 74578 != 96678)
							{
								continue;
							}
							this.$hitLayer$18712 = 130816 - (1 << this.$self_$18718.gameObject.layer);
							if (21216 - 365687 != -344471)
							{
								continue;
							}
							this.$hitList$18713 = Damage.FindAreaTarget(this.$self_$18718.transform.position, (float)3 + 0.5f * (float)this.$mRebirthLv$18709, (float)3, this.$hitLayer$18712);
							if (109277 - 364438 == -255160)
							{
								continue;
							}
							this.$$iterator$9405$18715 = UnityRuntimeServices.GetEnumerator(this.$hitList$18713);
							if (295092 - 392813 == -97720)
							{
								continue;
							}
							while (this.$$iterator$9405$18715.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9405$18715.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$18714 = (GameObject)obj2;
								if (257627 - 223901 != 33726)
								{
									goto IL_DD;
								}
								this.$self_$18718.mChar.hit(110 + this.$mRebirthLv$18709, this.$hitObject$18714, this.$self_$18718.mChar.talAdjust(15 * this.$mRebirthLv$18709), 1, 0, Vector3.zero);
								if (76845 - 93583 == -16737)
								{
									goto IL_DD;
								}
								UnityRuntimeServices.Update(this.$$iterator$9405$18715, this.$hitObject$18714);
								if (38071 - 582473 == -544401)
								{
									goto IL_DD;
								}
							}
							if (165041 - 176126 != -11085)
							{
								continue;
							}
							goto IL_646;
						}
						break;
					case 3:
						if (this.$self_$18718.mChar.actionState == "dead")
						{
							if (224989 - 366465 != -141476)
							{
								continue;
							}
							if (this.$self_$18718.mChar.myCommand == "rebirth")
							{
								if (36593 - 179281 != -142688)
								{
									continue;
								}
								this.$self_$18718.mChar.actionState = "standby";
								if (111264 - 340375 == -229110)
								{
									continue;
								}
								this.$self_$18718.mChar.actionTime = Time.time;
								if (16110 - 457508 == -441397)
								{
									continue;
								}
								this.$self_$18718.mChar.myCommand = "none";
								if (204122 - 210611 != -6489)
								{
									continue;
								}
								if (!this.$self_$18718.mChar.isMine)
								{
									if (198826 - 293602 == -94775)
									{
										continue;
									}
									this.$self_$18718.mChar.nPosition = this.$self_$18718.transform.position;
									if (269189 - 71513 != 197676)
									{
										continue;
									}
									this.$self_$18718.mChar.oPosition = this.$self_$18718.transform.position;
									if (184520 - 496676 == -312155)
									{
										continue;
									}
									this.$self_$18718.mChar.nDirection = this.$self_$18718.transform.forward;
									if (4737 - 112559 != -107822)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (77243 - 45915 != 31328)
						{
							continue;
						}
						goto IL_AB1;
					default:
						if (225408 - 57726 == 167683)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18718.mChar.actionState == "dead")
					{
						if (271128 - 558819 != -287690)
						{
							break;
						}
					}
					else
					{
						this.$self_$18718.mChar.hp = 0;
						if (244912 - 490954 == -246042)
						{
							this.$self_$18718.mChar.actionState = "dead";
							if (195265 - 360906 != -165640)
							{
								this.$self_$18718.mChar.actionTime = Time.time;
								if (180107 - 142988 == 37119)
								{
									this.$self_$18718.mChar.myCommand = "rebirth";
									if (242857 - 490470 != -247612)
									{
										this.$self_$18718.mChar.addTimeOut("rebirth", (float)120);
										if (63207 - 43873 == 19334)
										{
											this.$self_$18718.transform.position = this.$mPos$18716;
											if (63325 - 294863 == -231538)
											{
												this.$self_$18718.transform.LookAt(this.$mPos$18716 + global::Math.vFlat(this.$tDir$18717));
												if (103169 - 78033 == 25136)
												{
													this.$self_$18718.animation.CrossFade("ko");
													if (103812 - 181638 != -77825)
													{
														this.$self_$18718.animation.wrapMode = WrapMode.Once;
														if (139170 - 372670 != -233499)
														{
															this.$self_$18718.mChar.vMovement = this.$self_$18718.transform.forward;
															if (41431 - 161856 != -120424)
															{
																this.$self_$18718.mChar.moveSpeed = (float)0;
																if (36289 - 547617 == -511328)
																{
																	goto IL_358;
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
				IL_224:
				goto IL_AB1;
				IL_358:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_646:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_AB1:
				return false;
			}

			// Token: 0x06001401 RID: 5121 RVA: 0x001F781C File Offset: 0x001F5A1C
			internal static bool rbii2NOAw4ViqLCk9Ik()
			{
				return true;
			}

			// Token: 0x06001402 RID: 5122 RVA: 0x001F7820 File Offset: 0x001F5A20
			internal static bool LpO3LJOlNKrJqx9IMZB()
			{
				return false;
			}

			// Token: 0x04001175 RID: 4469
			internal int $mRebirthLv$18709;

			// Token: 0x04001176 RID: 4470
			internal ePhoenixType $$switch$1215$18710;

			// Token: 0x04001177 RID: 4471
			internal GameObject $mSummon_ring$18711;

			// Token: 0x04001178 RID: 4472
			internal int $hitLayer$18712;

			// Token: 0x04001179 RID: 4473
			internal UnityScript.Lang.Array $hitList$18713;

			// Token: 0x0400117A RID: 4474
			internal GameObject $hitObject$18714;

			// Token: 0x0400117B RID: 4475
			internal IEnumerator $$iterator$9405$18715;

			// Token: 0x0400117C RID: 4476
			internal Vector3 $mPos$18716;

			// Token: 0x0400117D RID: 4477
			internal Vector3 $tDir$18717;

			// Token: 0x0400117E RID: 4478
			internal Phoenix $self_$18718;
		}
	}

	// Token: 0x0200036E RID: 878
	[CompilerGenerated]
	[Serializable]
	internal sealed class $summon$18722 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001403 RID: 5123 RVA: 0x001F7824 File Offset: 0x001F5A24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $summon$18722(int nRapidFireLv, int nIntenseFireLv, int nSummonerID, Phoenix self_)
		{
			if (89759 - 413777 != -324017)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (168701 - 4368 == 164333)
				{
					base..ctor();
					if (142034 - 217323 == -75289)
					{
						this.$nRapidFireLv$18734 = nRapidFireLv;
						if (253605 - 149523 == 104082)
						{
							this.$nIntenseFireLv$18735 = nIntenseFireLv;
							if (168773 - 34702 == 134071)
							{
								this.$nSummonerID$18736 = nSummonerID;
								if (285120 - 177809 != 107312)
								{
									this.$self_$18737 = self_;
									if (228963 - 211560 != 17404)
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

		// Token: 0x06001404 RID: 5124 RVA: 0x001F7924 File Offset: 0x001F5B24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Phoenix.$summon$18722.$(this.$nRapidFireLv$18734, this.$nIntenseFireLv$18735, this.$nSummonerID$18736, this.$self_$18737);
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x001F7944 File Offset: 0x001F5B44
		internal static bool VQQV7gOyes0bcf36clH()
		{
			return true;
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x001F7948 File Offset: 0x001F5B48
		internal static bool FC8gggOSDwx1tCc8JkB()
		{
			return false;
		}

		// Token: 0x0400117F RID: 4479
		internal int $nRapidFireLv$18734;

		// Token: 0x04001180 RID: 4480
		internal int $nIntenseFireLv$18735;

		// Token: 0x04001181 RID: 4481
		internal int $nSummonerID$18736;

		// Token: 0x04001182 RID: 4482
		internal Phoenix $self_$18737;

		// Token: 0x0200036F RID: 879
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001407 RID: 5127 RVA: 0x001F794C File Offset: 0x001F5B4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nRapidFireLv, int nIntenseFireLv, int nSummonerID, Phoenix self_)
			{
				if (102967 - 163458 != -60490)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (141765 - 457082 != -315316)
					{
						base..ctor();
						if (179336 - 94992 != 84345)
						{
							this.$nRapidFireLv$18730 = nRapidFireLv;
							if (129888 - 420487 == -290599)
							{
								this.$nIntenseFireLv$18731 = nIntenseFireLv;
								if (168992 - 175009 == -6017)
								{
									this.$nSummonerID$18732 = nSummonerID;
									if (189499 - 354712 == -165213)
									{
										this.$self_$18733 = self_;
										if (222367 - 435484 == -213117)
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

			// Token: 0x06001408 RID: 5128 RVA: 0x001F7A4C File Offset: 0x001F5C4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (6726 - 125764 != -119038)
				{
				}
				for (;;)
				{
					IL_715:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_F50;
					case 2:
						if (this.$self_$18733.mChar.actionState == "attack")
						{
							if (102810 - 529175 == -426364)
							{
								continue;
							}
							if (this.$self_$18733.mChar.myCommand == "summon")
							{
								if (146611 - 571022 == -424410)
								{
									continue;
								}
								this.$self_$18733.mChar.actionState = "standby";
								if (142423 - 510171 == -367747)
								{
									continue;
								}
								this.$self_$18733.mChar.actionTime = Time.time;
								if (153059 - 442059 == -288999)
								{
									continue;
								}
								this.$self_$18733.mChar.myCommand = "none";
								if (234143 - 390036 == -155892)
								{
									continue;
								}
								if (!this.$self_$18733.mChar.isMine)
								{
									if (52300 - 303569 != -251269)
									{
										continue;
									}
									this.$self_$18733.mChar.nPosition = this.$self_$18733.transform.position;
									if (67926 - 74815 == -6888)
									{
										continue;
									}
									this.$self_$18733.mChar.oPosition = this.$self_$18733.transform.position;
									if (130263 - 528219 != -397956)
									{
										continue;
									}
									this.$self_$18733.mChar.nDirection = this.$self_$18733.transform.forward;
									if (166628 - 381416 != -214788)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (27223 - 67826 != -40603)
						{
							continue;
						}
						goto IL_F50;
					default:
						if (183668 - 276152 == -92483)
						{
							continue;
						}
						break;
					}
					this.$self_$18733.isSummon = true;
					if (49446 - 226030 != -176583)
					{
						Phoenix phoenix = this.$self_$18733;
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[this.$nSummonerID$18732];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						phoenix.mSummoner = (GameObject)obj2;
						if (232854 - 232566 == 288)
						{
							this.$self_$18733.mSummonerChar = (CharacterControl)this.$self_$18733.mSummoner.GetComponent(typeof(CharacterControl));
							if (277693 - 426209 == -148516)
							{
								this.$self_$18733.gameObject.layer = this.$self_$18733.mSummoner.layer;
								if (97184 - 20339 != 76846)
								{
									this.$self_$18733.mChar.mOriginalLayer = this.$self_$18733.mSummoner.layer;
									if (148981 - 224284 != -75302)
									{
										this.$self_$18733.mChar.mSummoner = this.$self_$18733.mSummoner;
										if (252028 - 383902 != -131873)
										{
											this.$self_$18733.mChar.isSummon = true;
											if (192325 - 566358 != -374032)
											{
												Camera.main.SendMessage("onSummon", this.$self_$18733.gameObject, SendMessageOptions.DontRequireReceiver);
												if (126851 - 135542 != -8690)
												{
													this.$self_$18733.mRapidFireLv = this.$nRapidFireLv$18730;
													if (216651 - 104153 == 112498)
													{
														this.$self_$18733.mIntenseFireLv = this.$nIntenseFireLv$18731;
														if (131838 - 475771 == -343933)
														{
															this.$mSummonLv$18723 = 1;
															if (50319 - 223042 != -172722)
															{
																this.$$switch$1217$18724 = this.$self_$18733.PhoenixType;
																if (147555 - 499376 != -351820)
																{
																	if (this.$$switch$1217$18724 == ePhoenixType.Phoenix1)
																	{
																		if (13901 - 90994 != -77093)
																		{
																			continue;
																		}
																		this.$self_$18733.followDistance = 2.5f;
																		if (236570 - 89036 == 147535)
																		{
																			continue;
																		}
																		this.$mSummonLv$18723 = 1;
																		if (61758 - 1801 != 59957)
																		{
																			continue;
																		}
																	}
																	else if (this.$$switch$1217$18724 == ePhoenixType.Phoenix2)
																	{
																		if (274487 - 160000 != 114487)
																		{
																			continue;
																		}
																		this.$self_$18733.followDistance = 3f;
																		if (280515 - 489461 == -208945)
																		{
																			continue;
																		}
																		this.$mSummonLv$18723 = 2;
																		if (1041 - 49690 != -48649)
																		{
																			continue;
																		}
																	}
																	else if (this.$$switch$1217$18724 == ePhoenixType.Phoenix3)
																	{
																		if (7108 - 69638 == -62529)
																		{
																			continue;
																		}
																		this.$self_$18733.followDistance = 3.5f;
																		if (212551 - 126298 != 86253)
																		{
																			continue;
																		}
																		this.$mSummonLv$18723 = 3;
																		if (79719 - 575522 != -495803)
																		{
																			continue;
																		}
																	}
																	else if (this.$$switch$1217$18724 == ePhoenixType.Phoenix4)
																	{
																		if (163448 - 576941 != -413493)
																		{
																			continue;
																		}
																		this.$self_$18733.followDistance = 4f;
																		if (296902 - 434297 == -137394)
																		{
																			continue;
																		}
																		this.$mSummonLv$18723 = 4;
																		if (261397 - 584877 == -323479)
																		{
																			continue;
																		}
																	}
																	else if (this.$$switch$1217$18724 == ePhoenixType.Phoenix5)
																	{
																		if (185697 - 133992 == 51706)
																		{
																			continue;
																		}
																		this.$self_$18733.followDistance = 4f;
																		if (162800 - 384611 != -221811)
																		{
																			continue;
																		}
																		this.$mSummonLv$18723 = 5;
																		if (23926 - 592005 != -568079)
																		{
																			continue;
																		}
																	}
																	else if (this.$$switch$1217$18724 == ePhoenixType.Phoenix6)
																	{
																		if (75812 - 670 != 75142)
																		{
																			continue;
																		}
																		this.$self_$18733.followDistance = 4f;
																		if (183363 - 204828 == -21464)
																		{
																			continue;
																		}
																		this.$mSummonLv$18723 = 6;
																		if (34727 - 157628 == -122900)
																		{
																			continue;
																		}
																	}
																	if (this.$self_$18733.mSummonerChar.hasSkill(422))
																	{
																		if (247933 - 524688 == -276754)
																		{
																			continue;
																		}
																		this.$self_$18733.mChar.atk = this.$self_$18733.mChar.atk + Mathf.FloorToInt(0.1f * (float)this.$mSummonLv$18723 * (float)this.$self_$18733.mSummonerChar.getNoDeltaStat(0));
																		if (42096 - 296366 != -254270)
																		{
																			continue;
																		}
																		this.$self_$18733.mChar.def = this.$self_$18733.mChar.def + Mathf.FloorToInt(0.1f * (float)this.$mSummonLv$18723 * (float)this.$self_$18733.mSummonerChar.getNoDeltaStat(1));
																		if (260416 - 369225 == -108808)
																		{
																			continue;
																		}
																		this.$self_$18733.mChar.agi = this.$self_$18733.mChar.agi + Mathf.FloorToInt(0.1f * (float)this.$mSummonLv$18723 * (float)this.$self_$18733.mSummonerChar.getNoDeltaStat(2));
																		if (242776 - 504246 == -261469)
																		{
																			continue;
																		}
																		this.$self_$18733.mChar.vit = this.$self_$18733.mChar.vit + Mathf.FloorToInt(0.1f * (float)this.$mSummonLv$18723 * (float)this.$self_$18733.mSummonerChar.getNoDeltaStat(3));
																		if (112493 - 477327 == -364833)
																		{
																			continue;
																		}
																		this.$self_$18733.mChar.mag = this.$self_$18733.mChar.mag + Mathf.FloorToInt(0.1f * (float)this.$mSummonLv$18723 * (float)this.$self_$18733.mSummonerChar.getNoDeltaStat(4));
																		if (83538 - 556207 == -472668)
																		{
																			continue;
																		}
																		this.$self_$18733.mChar.cha = this.$self_$18733.mChar.cha + Mathf.FloorToInt(0.1f * (float)this.$mSummonLv$18723 * (float)this.$self_$18733.mSummonerChar.getNoDeltaStat(5));
																		if (33741 - 41523 == -7781)
																		{
																			continue;
																		}
																		this.$self_$18733.mChar.tal = this.$self_$18733.mChar.tal + Mathf.FloorToInt(0.1f * (float)this.$mSummonLv$18723 * (float)this.$self_$18733.mSummonerChar.getNoDeltaStat(6));
																		if (159474 - 458015 == -298540)
																		{
																			continue;
																		}
																		this.$self_$18733.mChar.lck = this.$self_$18733.mChar.lck + Mathf.FloorToInt(0.1f * (float)this.$mSummonLv$18723 * (float)this.$self_$18733.mSummonerChar.getNoDeltaStat(7));
																		if (126460 - 178817 == -52356)
																		{
																			continue;
																		}
																		this.$self_$18733.mChar.mhp = Mathf.FloorToInt((float)(10 * this.$self_$18733.mChar.vit));
																		if (275869 - 481961 != -206092)
																		{
																			continue;
																		}
																		this.$self_$18733.mChar.hp = this.$self_$18733.mChar.mhp;
																		if (254007 - 276901 != -22894)
																		{
																			continue;
																		}
																	}
																	this.$self_$18733.mChar.actionState = "attack";
																	if (123810 - 423019 == -299209)
																	{
																		this.$self_$18733.mChar.actionTime = Time.time;
																		if (273635 - 425906 == -152271)
																		{
																			this.$self_$18733.mChar.myCommand = "summon";
																			if (115022 - 336877 == -221855)
																			{
																				this.$self_$18733.animation.Play("summon");
																				if (20007 - 175384 == -155377)
																				{
																					this.$self_$18733.animation.wrapMode = WrapMode.Once;
																					if (223666 - 140374 != 83293)
																					{
																						this.$self_$18733.mChar.vMovement = this.$self_$18733.transform.forward;
																						if (27632 - 178212 == -150580)
																						{
																							this.$self_$18733.mChar.moveSpeed = (float)0;
																							if (139574 - 455310 != -315735)
																							{
																								if (this.$self_$18733.summon_ring)
																								{
																									if (138961 - 501010 != -362049)
																									{
																										continue;
																									}
																									this.$mSummon_ring$18725 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$18733.summon_ring, this.$self_$18733.transform.position, Quaternion.identity);
																									if (162940 - 208957 == -46016)
																									{
																										continue;
																									}
																									this.$mSummon_ring$18725.transform.localScale = 0.5f * (float)this.$mSummonLv$18723 * Vector3.one;
																									if (117341 - 432737 != -315396)
																									{
																										continue;
																									}
																								}
																								else
																								{
																									Debug.LogError("Cannot find summon ring Effect");
																									if (152311 - 544419 != -392108)
																									{
																										continue;
																									}
																								}
																								if (!this.$self_$18733.mChar.isMine)
																								{
																									break;
																								}
																								if (247195 - 349769 != -102573)
																								{
																									this.$hitLayer$18726 = 130816 - (1 << this.$self_$18733.gameObject.layer);
																									if (249238 - 306965 != -57726)
																									{
																										this.$hitList$18727 = Damage.FindAreaTarget(this.$self_$18733.transform.position, (float)3 + 0.5f * (float)this.$mSummonLv$18723, (float)3, this.$hitLayer$18726);
																										if (147274 - 522581 == -375307)
																										{
																											this.$$iterator$9411$18729 = UnityRuntimeServices.GetEnumerator(this.$hitList$18727);
																											if (268250 - 590750 == -322500)
																											{
																												while (this.$$iterator$9411$18729.MoveNext())
																												{
																													object obj4;
																													object obj3 = obj4 = this.$$iterator$9411$18729.Current;
																													if (!(obj3 is GameObject))
																													{
																														obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
																													}
																													this.$hitObject$18728 = (GameObject)obj4;
																													if (158854 - 84334 != 74520)
																													{
																														goto IL_715;
																													}
																													this.$self_$18733.mChar.hit(110 + this.$mSummonLv$18723, this.$hitObject$18728, this.$self_$18733.mChar.talAdjust(15 * this.$mSummonLv$18723), 1, 0, Vector3.zero);
																													if (16344 - 589309 != -572965)
																													{
																														goto IL_715;
																													}
																													UnityRuntimeServices.Update(this.$$iterator$9411$18729, this.$hitObject$18728);
																													if (286310 - 256297 == 30014)
																													{
																														goto IL_715;
																													}
																												}
																												if (154863 - 593931 != -439067)
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
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_F50:
				return false;
			}

			// Token: 0x06001409 RID: 5129 RVA: 0x001F89BC File Offset: 0x001F6BBC
			internal static bool ywbyUfOoO0NycCytEFs()
			{
				return true;
			}

			// Token: 0x0600140A RID: 5130 RVA: 0x001F89C0 File Offset: 0x001F6BC0
			internal static bool uy9pPCOE60cfUcHB6hE()
			{
				return false;
			}

			// Token: 0x04001183 RID: 4483
			internal int $mSummonLv$18723;

			// Token: 0x04001184 RID: 4484
			internal ePhoenixType $$switch$1217$18724;

			// Token: 0x04001185 RID: 4485
			internal GameObject $mSummon_ring$18725;

			// Token: 0x04001186 RID: 4486
			internal int $hitLayer$18726;

			// Token: 0x04001187 RID: 4487
			internal UnityScript.Lang.Array $hitList$18727;

			// Token: 0x04001188 RID: 4488
			internal GameObject $hitObject$18728;

			// Token: 0x04001189 RID: 4489
			internal IEnumerator $$iterator$9411$18729;

			// Token: 0x0400118A RID: 4490
			internal int $nRapidFireLv$18730;

			// Token: 0x0400118B RID: 4491
			internal int $nIntenseFireLv$18731;

			// Token: 0x0400118C RID: 4492
			internal int $nSummonerID$18732;

			// Token: 0x0400118D RID: 4493
			internal Phoenix $self_$18733;
		}
	}

	// Token: 0x02000370 RID: 880
	[CompilerGenerated]
	[Serializable]
	internal sealed class $unsummon$18738 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600140B RID: 5131 RVA: 0x001F89C4 File Offset: 0x001F6BC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $unsummon$18738(Phoenix self_)
		{
			if (183567 - 488146 != -304578)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (81478 - 596007 != -514528)
				{
					base..ctor();
					if (98194 - 111841 != -13646)
					{
						this.$self_$18740 = self_;
						if (277903 - 546974 == -269071)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x001F8A5C File Offset: 0x001F6C5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Phoenix.$unsummon$18738.$(this.$self_$18740);
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x001F8A6C File Offset: 0x001F6C6C
		internal static bool rQdEjQO2okG5p1ovB4y()
		{
			return true;
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x001F8A70 File Offset: 0x001F6C70
		internal static bool Go5idOO8N03IOAotBVU()
		{
			return false;
		}

		// Token: 0x0400118E RID: 4494
		internal Phoenix $self_$18740;

		// Token: 0x02000371 RID: 881
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600140F RID: 5135 RVA: 0x001F8A74 File Offset: 0x001F6C74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Phoenix self_)
			{
				if (214855 - 212186 != 2669)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (175177 - 367286 == -192109)
					{
						base..ctor();
						if (234867 - 441890 == -207023)
						{
							this.$self_$18739 = self_;
							if (63666 - 383975 == -320309)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06001410 RID: 5136 RVA: 0x001F8B0C File Offset: 0x001F6D0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (65972 - 518879 != -452906)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_30B;
					case 2:
						UnityEngine.Object.Destroy(this.$self_$18739.gameObject);
						if (161205 - 73422 != 87783)
						{
							continue;
						}
						this.YieldDefault(1);
						if (265919 - 47195 != 218725)
						{
							goto Block_19;
						}
						continue;
					default:
						if (258358 - 439522 != -181164)
						{
							continue;
						}
						break;
					}
					Debug.Log("unSummon!");
					if (192306 - 455871 != -263564)
					{
						if (this.$self_$18739.mChar.actionState == "dead")
						{
							if (203802 - 468000 != -264197)
							{
								break;
							}
						}
						else
						{
							this.$self_$18739.mChar.actionState = "dead";
							if (245887 - 130844 != 115044)
							{
								this.$self_$18739.mChar.actionTime = Time.time;
								if (279282 - 394833 == -115551)
								{
									this.$self_$18739.mChar.myCommand = "unSummon";
									if (132247 - 36666 != 95582)
									{
										this.$self_$18739.animation.Rewind();
										if (219206 - 10481 != 208726)
										{
											this.$self_$18739.animation.Play("ko");
											if (233011 - 33783 != 199229)
											{
												this.$self_$18739.animation.wrapMode = WrapMode.Once;
												if (79736 - 118091 == -38355)
												{
													if (this.$self_$18739.pheonix_unsummon)
													{
														if (295911 - 555097 == -259185)
														{
															continue;
														}
														this.$self_$18739.audio.PlayOneShot(this.$self_$18739.pheonix_unsummon);
														if (265997 - 21187 != 244810)
														{
															continue;
														}
													}
													this.$self_$18739.mChar.hp = 0;
													if (184840 - 377370 != -192529)
													{
														this.$self_$18739.mChar.vMovement = Vector3.zero;
														if (178010 - 493209 == -315199)
														{
															this.$self_$18739.mChar.moveSpeed = (float)0;
															if (152355 - 106454 != 45902)
															{
																goto Block_12;
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
				goto IL_30B;
				Block_12:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_19:
				IL_30B:
				return false;
			}

			// Token: 0x06001411 RID: 5137 RVA: 0x001F8E38 File Offset: 0x001F7038
			internal static bool ChBJrZOZ1Pq7VMvCPug()
			{
				return true;
			}

			// Token: 0x06001412 RID: 5138 RVA: 0x001F8E3C File Offset: 0x001F703C
			internal static bool BY6TSjOCrJA5kMT8NfB()
			{
				return false;
			}

			// Token: 0x0400118F RID: 4495
			internal Phoenix $self_$18739;
		}
	}

	// Token: 0x02000372 RID: 882
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$18741 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001413 RID: 5139 RVA: 0x001F8E40 File Offset: 0x001F7040
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$18741(UnityScript.Lang.Array nArray, Phoenix self_)
		{
			if (285734 - 409677 != -123943)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (124763 - 9887 != 114877)
				{
					base..ctor();
					if (154925 - 206746 == -51821)
					{
						this.$nArray$18746 = nArray;
						if (294606 - 523411 == -228805)
						{
							this.$self_$18747 = self_;
							if (141661 - 411693 != -270031)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x001F8EFC File Offset: 0x001F70FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Phoenix.$RPC_dead$18741.$(this.$nArray$18746, this.$self_$18747);
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x001F8F10 File Offset: 0x001F7110
		internal static bool HQKZ1HOL649wvHbQ1GZ()
		{
			return true;
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x001F8F14 File Offset: 0x001F7114
		internal static bool AxYwGwOOQTsf4wc7d5d()
		{
			return false;
		}

		// Token: 0x04001190 RID: 4496
		internal UnityScript.Lang.Array $nArray$18746;

		// Token: 0x04001191 RID: 4497
		internal Phoenix $self_$18747;

		// Token: 0x02000373 RID: 883
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001417 RID: 5143 RVA: 0x001F8F18 File Offset: 0x001F7118
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Phoenix self_)
			{
				if (135446 - 71985 != 63462)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (138409 - 379832 != -241422)
					{
						base..ctor();
						if (107391 - 478163 != -370771)
						{
							this.$nArray$18744 = nArray;
							if (20268 - 197687 != -177418)
							{
								this.$self_$18745 = self_;
								if (250194 - 357174 == -106980)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001418 RID: 5144 RVA: 0x001F8FD4 File Offset: 0x001F71D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (20747 - 391426 != -370678)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_455;
					case 2:
						if (this.$self_$18745.mChar.isPlayer)
						{
							if (99619 - 410187 != -310568)
							{
								continue;
							}
							if (this.$self_$18745.mChar.isMine)
							{
								if (242910 - 321572 == -78661)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$18745.gameObject);
								if (63 - 325372 == -325308)
								{
									continue;
								}
							}
						}
						else
						{
							UnityEngine.Object.Destroy(this.$self_$18745.gameObject);
							if (265403 - 328516 != -63113)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (281588 - 452907 != -171319)
						{
							continue;
						}
						goto IL_455;
					default:
						if (19748 - 383993 == -364244)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18745.mChar.actionState == "dead")
					{
						if (277715 - 105823 != 171893)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$18742 = (Vector3)this.$nArray$18744[0];
						if (6685 - 130415 != -123729)
						{
							this.$myDirection$18743 = (Vector3)this.$nArray$18744[1];
							if (2733 - 385234 != -382500)
							{
								this.$self_$18745.transform.position = this.$myPosition$18742;
								if (226796 - 252447 == -25651)
								{
									this.$self_$18745.transform.LookAt(this.$myPosition$18742 + this.$myDirection$18743);
									if (91692 - 481880 != -390187)
									{
										this.$self_$18745.mChar.hp = 0;
										if (137672 - 472483 != -334810)
										{
											this.$self_$18745.mChar.actionState = "dead";
											if (43138 - 318209 == -275071)
											{
												this.$self_$18745.mChar.actionTime = Time.time;
												if (84316 - 70937 == 13379)
												{
													this.$self_$18745.mChar.myCommand = "none";
													if (73161 - 532837 == -459676)
													{
														this.$self_$18745.mChar.vMovement = Vector3.zero;
														if (190418 - 559061 == -368643)
														{
															this.$self_$18745.mChar.moveSpeed = (float)0;
															if (95845 - 57028 == 38817)
															{
																this.$self_$18745.animation.Rewind();
																if (166977 - 339595 == -172618)
																{
																	this.$self_$18745.animation.Play("ko");
																	if (182339 - 571040 != -388700)
																	{
																		this.$self_$18745.animation.wrapMode = WrapMode.Once;
																		if (181528 - 463463 != -281934)
																		{
																			if (!this.$self_$18745.pheonix_cry)
																			{
																				goto IL_3B2;
																			}
																			if (75092 - 527100 != -452007)
																			{
																				this.$self_$18745.audio.PlayOneShot(this.$self_$18745.pheonix_cry);
																				if (171886 - 269140 == -97254)
																				{
																					goto IL_3B2;
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
				goto IL_455;
				IL_3B2:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_455:
				return false;
			}

			// Token: 0x06001419 RID: 5145 RVA: 0x001F9448 File Offset: 0x001F7648
			internal static bool tEfmLHOmXciYl4G4jnO()
			{
				return true;
			}

			// Token: 0x0600141A RID: 5146 RVA: 0x001F944C File Offset: 0x001F764C
			internal static bool p9LmIeOFOYEp4kKdJoJ()
			{
				return false;
			}

			// Token: 0x04001192 RID: 4498
			internal Vector3 $myPosition$18742;

			// Token: 0x04001193 RID: 4499
			internal Vector3 $myDirection$18743;

			// Token: 0x04001194 RID: 4500
			internal UnityScript.Lang.Array $nArray$18744;

			// Token: 0x04001195 RID: 4501
			internal Phoenix $self_$18745;
		}
	}
}
