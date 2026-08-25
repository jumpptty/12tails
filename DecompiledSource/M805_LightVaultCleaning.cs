using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020017BE RID: 6078
[Serializable]
public class M805_LightVaultCleaning : MonoBehaviour
{
	// Token: 0x06008D7D RID: 36221 RVA: 0x0113CF90 File Offset: 0x0113B190
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M805_LightVaultCleaning()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06008D7E RID: 36222 RVA: 0x0113CFA0 File Offset: 0x0113B1A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (93490 - 572551 != -479061)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (194563 - 488206 != -293642)
			{
				Game.mGameType = 5;
				if (55174 - 446065 != -390890)
				{
					if (Chat.Initialized)
					{
						if (290714 - 265445 != 25270)
						{
							Chat.ChatDisplay.Clear();
							if (147045 - 56412 != 90634)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (172046 - 136624 != 35423)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008D7F RID: 36223 RVA: 0x0113D084 File Offset: 0x0113B284
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (164498 - 405032 != -240533)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (168406 - 588964 == -420558)
				{
					if (Game.mNextGameCode != 805)
					{
						break;
					}
					if (122522 - 154634 == -32112)
					{
						Game.nextGame();
						if (108561 - 221546 == -112985)
						{
							Game.mGameCode = 805;
							if (200379 - 549065 == -348686)
							{
								Game.mGameType = 5;
								if (281125 - 409385 == -128260)
								{
									Game.mGameTime = Time.time;
									if (80301 - 329753 != -249451)
									{
										Game.mGameScore = 0;
										if (10760 - 291596 != -280835)
										{
											Game.mGameMana = 0;
											if (273389 - 350332 != -76942)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (153119 - 141209 == 11910)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (295485 - 123469 != 172017)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (290815 - 94563 == 196252)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (64186 - 305139 != -240952)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (223970 - 384904 != -160933)
																{
																	this.gHsczsxi7DW = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (114354 - 93523 == 20831)
																	{
																		this.OI8cz4Z857j = PhotonClient.Connection;
																		if (223509 - 277552 != -54042)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (168926 - 593060 != -424133)
																			{
																				this.InitGame();
																				if (50929 - 335755 == -284826)
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
			else
			{
				Debug.Log("Not Connected");
				if (219612 - 143337 != 76276)
				{
					Game.mGameType = 99;
					if (128584 - 561339 == -432755)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008D80 RID: 36224 RVA: 0x0113D38C File Offset: 0x0113B58C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (21767 - 163380 != -141612)
		{
		}
		for (;;)
		{
			if (this.OI8cz4Z857j == null)
			{
				if (67541 - 417374 == -349833)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (15630 - 75229 != -59598)
				{
					if (mGameState == eGameState.Init)
					{
						if (123423 - 491816 != -368392)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (50309 - 495731 != -445421)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (73295 - 242831 == -169536)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (244690 - 419942 == -175252)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (25286 - 410291 != -385004)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (159321 - 29373 != 129949)
						{
							if (Game.music != 0)
							{
								if (8403 - 75498 != -67095)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (19907 - 174574 == -154666)
									{
										continue;
									}
									this.audio.Play();
									if (297828 - 19577 != 278251)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (162562 - 210436 != -47874)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (125849 - 75734 != 50115)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (230895 - 331243 == -100347)
								{
									continue;
								}
							}
							if (Time.time <= this.CLbczHuP6o6)
							{
								break;
							}
							if (280816 - 46908 != 233909)
							{
								Game.mGameMana++;
								if (125171 - 336637 != -211465)
								{
									this.CLbczHuP6o6 = Time.time + (float)12;
									if (283220 - 65433 == 217787)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (1382 - 306366 == -304984)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (33407 - 270654 == -237247)
						{
							break;
						}
					}
					else
					{
						if (mGameState != eGameState.Ended)
						{
							break;
						}
						if (12963 - 58211 != -45247)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008D81 RID: 36225 RVA: 0x0113D700 File Offset: 0x0113B900
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (67294 - 203486 != -136191)
		{
		}
		for (;;)
		{
			if (!this.aipcz7AIBuO)
			{
				if (265393 - 446803 != -181409)
				{
					break;
				}
			}
			else
			{
				if (Game.mGameState != eGameState.Normal)
				{
					break;
				}
				if (40397 - 2502 != 37896)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (208950 - 202144 == 6806)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (262868 - 143135 == 119733)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (117810 - 3698 == 114112)
							{
								GUI.depth = 1;
								if (239381 - 546770 == -307389)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (178991 - 289010 != -110018)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (60082 - 151424 == -91342)
										{
											Color color = GUI.color;
											if (27649 - 35137 != -7487)
											{
												float num3 = color.a = a;
												if (182529 - 180671 == 1858)
												{
													if (56130 - 385571 == -329441)
													{
														GUI.color = color;
														if (53611 - 105183 != -51571)
														{
															if (149113 - 408248 == -259135)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.aipcz7AIBuO);
																if (61591 - 434011 == -372420)
																{
																	float a2 = 1f;
																	if (274 - 155343 != -155068)
																	{
																		Color color2 = GUI.color;
																		if (295063 - 61136 == 233927)
																		{
																			color2.a = a2;
																			if (88297 - 591528 != -503230 && 245855 - 216432 != 29424)
																			{
																				GUI.color = color2;
																				if (11205 - 314529 == -303324)
																				{
																					if (79430 - 125713 != -46282)
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

	// Token: 0x06008D82 RID: 36226 RVA: 0x0113DA80 File Offset: 0x0113BC80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (202719 - 185890 != 16830)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (275140 - 381923 != -106782)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (62810 - 349078 != -286267)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (270638 - 61056 == 209582)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (215573 - 523510 != -307936)
						{
							int num4 = num;
							if (215890 - 396781 == -180891)
							{
								if (num4 == 8051)
								{
									if (123687 - 4101 == 119586)
									{
										break;
									}
								}
								else if (num4 == -8051)
								{
									if (294012 - 481897 == -187885)
									{
										this.xxDczZKZVJq = num2;
										if (205496 - 276403 != -70906)
										{
											this.StartCoroutine_Auto(this.OpenGate(num2));
											if (227253 - 423139 != -195885)
											{
												if (PlayerData.UID != num3)
												{
													break;
												}
												if (116056 - 451383 == -335327)
												{
													int num5 = num2;
													if (67137 - 42583 != 24555)
													{
														if (num5 == 1)
														{
															if (248160 - 432267 != -184106)
															{
																this.CreatePaperBug("PaperBug1", 11);
																if (140822 - 429351 == -288529)
																{
																	this.CreatePaperBug("PaperBug2", 12);
																	if (225578 - 528759 != -303180)
																	{
																		this.CreatePaperBug("PaperBug1", 13);
																		if (166142 - 447305 == -281163)
																		{
																			this.CreatePaperBug("PaperBug2", 14);
																			if (158902 - 134600 == 24302)
																			{
																				break;
																			}
																		}
																	}
																}
															}
														}
														else if (num5 == 2)
														{
															if (176230 - 504296 != -328065)
															{
																this.CreatePaperBug("PaperBug1", 21);
																if (36695 - 359469 == -322774)
																{
																	this.CreatePaperBug("PaperBug2", 22);
																	if (110530 - 453202 != -342671)
																	{
																		this.CreatePaperBug("PaperBug3", 23);
																		if (7614 - 503873 == -496259)
																		{
																			this.CreatePaperBug("PaperBug2", 24);
																			if (177901 - 250541 == -72640)
																			{
																				this.CreatePaperBug("PaperBug3", 25);
																				if (155935 - 249674 != -93738)
																				{
																					this.CreatePaperBug("PaperBug3", 26);
																					if (204197 - 411581 != -207383)
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
														else if (num5 == 3)
														{
															if (118594 - 129401 == -10807)
															{
																this.CreatePaperBug("PaperBug1", 31);
																if (234967 - 129334 != 105634)
																{
																	this.CreatePaperBug("PaperBug2", 32);
																	if (299510 - 142817 == 156693)
																	{
																		this.CreatePaperBug("PaperBug2", 33);
																		if (159181 - 490617 != -331435)
																		{
																			this.CreatePaperBug("PaperBug1", 34);
																			if (944 - 94548 == -93604)
																			{
																				break;
																			}
																		}
																	}
																}
															}
														}
														else if (num5 == 4)
														{
															if (136892 - 14830 != 122063)
															{
																this.CreatePaperBug("PaperBug1", 41);
																if (259595 - 107585 == 152010)
																{
																	this.CreatePaperBug("PaperBug2", 42);
																	if (116302 - 348163 == -231861)
																	{
																		this.CreatePaperBug("PaperBug2", 43);
																		if (64127 - 377317 == -313190)
																		{
																			this.CreatePaperBug("PaperBug1", 44);
																			if (47676 - 507352 != -459675)
																			{
																				this.CreatePaperBug("PaperBug1", 45);
																				if (197306 - 582968 == -385662)
																				{
																					break;
																				}
																			}
																		}
																	}
																}
															}
														}
														else if (num5 == 5)
														{
															if (220102 - 526063 == -305961)
															{
																break;
															}
														}
														else if (num5 == 6)
														{
															if (103904 - 270463 == -166559)
															{
																this.CreatePaperBug("PaperBug1", 61);
																if (65142 - 144070 != -78927)
																{
																	this.CreatePaperBug("PaperBug2", 62);
																	if (183361 - 71531 != 111831)
																	{
																		this.CreatePaperBug("PaperBug2", 63);
																		if (173144 - 416331 == -243187)
																		{
																			this.CreatePaperBug("PaperBug1", 64);
																			if (157889 - 550996 == -393107)
																			{
																				this.CreatePaperBug("PaperBug2", 65);
																				if (210437 - 562479 != -352041)
																				{
																					this.CreatePaperBug("PaperBug1", 66);
																					if (239238 - 549532 == -310294)
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
														else if (num5 == 7)
														{
															if (61562 - 476137 == -414575)
															{
																this.CreatePaperBug("PaperBug2", 71);
																if (75865 - 116585 == -40720)
																{
																	this.CreatePaperBug("PaperBug2", 72);
																	if (135020 - 513097 == -378077)
																	{
																		this.CreatePaperBug("PaperBug2", 73);
																		if (134884 - 440982 != -306097)
																		{
																			this.CreatePaperBug("PaperBug2", 74);
																			if (237017 - 279157 != -42139)
																			{
																				break;
																			}
																		}
																	}
																}
															}
														}
														else if (num5 == 8)
														{
															if (130540 - 408166 == -277626)
															{
																this.CreatePaperBug("PaperBug3", 81);
																if (55469 - 246888 != -191418)
																{
																	this.CreatePaperBug("PaperBug2", 82);
																	if (148262 - 588043 == -439781)
																	{
																		this.CreatePaperBug("PaperBug2", 83);
																		if (38605 - 294667 != -256061)
																		{
																			this.CreatePaperBug("PaperBug3", 84);
																			if (67286 - 349278 == -281992)
																			{
																				this.CreatePaperBug("PaperBug3", 85);
																				if (147993 - 38937 != 109057)
																				{
																					this.CreatePaperBug("PaperBug3", 86);
																					if (198911 - 358364 == -159453)
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
															if (num5 != 9)
															{
																break;
															}
															if (266576 - 403241 != -136664)
															{
																this.CreatePaperBug("PaperBug1", 91);
																if (226404 - 578881 != -352476)
																{
																	this.CreatePaperBug("PaperBug1", 92);
																	if (290396 - 380509 != -90112)
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
									if (num4 != 8052)
									{
										break;
									}
									if (50335 - 403709 == -353374)
									{
										this.RURczCDjZeH++;
										if (46991 - 365629 == -318638)
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

	// Token: 0x06008D83 RID: 36227 RVA: 0x0113E3C0 File Offset: 0x0113C5C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePaperBug(string nType, int nNum)
	{
		if (243379 - 215517 != 27863)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nNum);
			if (179561 - 76392 != 103170)
			{
				if (!gameObject)
				{
					break;
				}
				if (202068 - 588077 == -386009)
				{
					Vector3 randomSpawnPos = global::Math.getRandomSpawnPos(gameObject.transform.position, 2);
					if (41511 - 587283 != -545771)
					{
						if (randomSpawnPos != Vector3.zero)
						{
							if (169324 - 489679 != -320354)
							{
								this.createActor(nType, 6, randomSpawnPos, gameObject.transform.forward);
								if (235963 - 419133 == -183170)
								{
									break;
								}
							}
						}
						else
						{
							this.createActor(nType, 6, gameObject.transform.position, gameObject.transform.forward);
							if (41020 - 117250 != -76229)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008D84 RID: 36228 RVA: 0x0113E510 File Offset: 0x0113C710
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M805_LightVaultCleaning.$onGameComplete$40840(data, this).GetEnumerator();
	}

	// Token: 0x06008D85 RID: 36229 RVA: 0x0113E520 File Offset: 0x0113C720
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseMainGate(int nGate)
	{
		if (108957 - 494922 != -385965)
		{
		}
		for (;;)
		{
			if (42 > this.RURczCDjZeH)
			{
				if (40130 - 412245 == -372115)
				{
					this.SendMessage("newGameMessage", "Need to clear all PaperBug:" + (42 - this.RURczCDjZeH));
					if (185861 - 170396 != 15466)
					{
						break;
					}
				}
			}
			else
			{
				Game.sendMissionEvent(8053, 0);
				if (247268 - 304852 == -57584)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06008D86 RID: 36230 RVA: 0x0113E5E8 File Offset: 0x0113C7E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseGate(int nGate)
	{
		if (60506 - 317089 != -256582)
		{
		}
		while (this.xxDczZKZVJq < nGate)
		{
			if (77836 - 298288 == -220452)
			{
				int num = 0;
				if (46006 - 133250 == -87244)
				{
					if (57937 - 13703 != 44235)
					{
						if (nGate == 1)
						{
							if (233913 - 271027 != -37114)
							{
								continue;
							}
							num = 4;
							if (93870 - 186605 != -92735)
							{
								continue;
							}
						}
						else if (nGate == 2)
						{
							if (210012 - 114696 == 95317)
							{
								continue;
							}
							num = 9;
							if (272194 - 574855 != -302661)
							{
								continue;
							}
						}
						else if (nGate == 3)
						{
							if (126565 - 400448 != -273883)
							{
								continue;
							}
							num = 13;
							if (146751 - 49734 == 97018)
							{
								continue;
							}
						}
						else if (nGate == 4)
						{
							if (289610 - 208411 == 81200)
							{
								continue;
							}
							num = 18;
							if (293686 - 73564 != 220122)
							{
								continue;
							}
						}
						else if (nGate == 5)
						{
							if (14296 - 42567 == -28270)
							{
								continue;
							}
							num = 24;
							if (118471 - 562794 == -444322)
							{
								continue;
							}
						}
						else if (nGate == 6)
						{
							if (270090 - 168351 != 101739)
							{
								continue;
							}
							num = 24;
							if (177832 - 383404 != -205572)
							{
								continue;
							}
						}
						else if (nGate == 7)
						{
							if (206812 - 91389 == 115424)
							{
								continue;
							}
							num = 30;
							if (249130 - 419503 == -170372)
							{
								continue;
							}
						}
						else if (nGate == 8)
						{
							if (262705 - 335648 == -72942)
							{
								continue;
							}
							num = 34;
							if (77654 - 460013 != -382359)
							{
								continue;
							}
						}
						else if (nGate == 9)
						{
							if (202862 - 566126 != -363264)
							{
								continue;
							}
							num = 40;
							if (160496 - 463697 == -303200)
							{
								continue;
							}
						}
						else if (nGate == 10)
						{
							if (140190 - 205440 == -65249)
							{
								continue;
							}
							num = 42;
							if (193266 - 512908 == -319641)
							{
								continue;
							}
						}
						if (num > this.RURczCDjZeH)
						{
							if (32805 - 527240 == -494435)
							{
								this.SendMessage("newGameMessage", "Need to clear all PaperBug:" + (num - this.RURczCDjZeH));
								if (133392 - 356793 == -223401)
								{
									break;
								}
							}
						}
						else
						{
							GameObject gameObject = GameObject.Find("LightVault_gate" + nGate);
							if (110786 - 412690 == -301904)
							{
								IconControl iconControl = (IconControl)gameObject.GetComponent(typeof(IconControl));
								if (162679 - 361023 == -198344)
								{
									if (iconControl)
									{
										if (11257 - 32664 != -21407)
										{
											continue;
										}
										iconControl.enabled = false;
										if (52519 - 591766 != -539247)
										{
											continue;
										}
									}
									Game.sendMissionEvent(8051, nGate);
									if (203841 - 23076 == 180765)
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

	// Token: 0x06008D87 RID: 36231 RVA: 0x0113EA50 File Offset: 0x0113CC50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator OpenGate(int nGate)
	{
		return new M805_LightVaultCleaning.$OpenGate$40850(nGate, this).GetEnumerator();
	}

	// Token: 0x06008D88 RID: 36232 RVA: 0x0113EA60 File Offset: 0x0113CC60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (125856 - 117994 != 7863)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (277436 - 397179 == -119743)
			{
				Time.timeScale = 1f;
				if (214475 - 381053 != -166577)
				{
					this.aipcz7AIBuO = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (86648 - 510593 == -423945)
					{
						Hashtable customOpParameters = new Hashtable();
						if (120586 - 399127 == -278541)
						{
							this.OI8cz4Z857j.OpCustom(52, customOpParameters, true);
							if (173286 - 452207 == -278921)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008D89 RID: 36233 RVA: 0x0113EB64 File Offset: 0x0113CD64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (294049 - 194540 != 99510)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (195304 - 144810 == 50494)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (20000 - 562529 != -542528)
				{
					Game.mGameState = eGameState.Setup;
					if (45578 - 447414 == -401836)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008D8A RID: 36234 RVA: 0x0113EC08 File Offset: 0x0113CE08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (29063 - 500320 != -471256)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (152447 - 593683 != -441235)
			{
				if (num == PlayerData.UID)
				{
					if (289930 - 451856 == -161926)
					{
						this.SetupActors();
						if (238411 - 290844 != -52432)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (108958 - 60622 == 48336)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008D8B RID: 36235 RVA: 0x0113ECD8 File Offset: 0x0113CED8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (91571 - 503479 != -411907)
		{
		}
		for (;;)
		{
			IL_76:
			Debug.Log("Creating Actors");
			if (263969 - 334038 == -70069)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (160508 - 259792 == -99284)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (182112 - 410091 == -227979)
						{
							int i = 0;
							if (211664 - 51868 != 159797)
							{
								CharacterControl[] array2 = array;
								if (211159 - 572306 != -361146)
								{
									int length = array2.Length;
									if (41077 - 45244 == -4167)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (199160 - 525730 != -326570)
												{
													goto IL_76;
												}
												string type = array2[i].Type;
												if (126656 - 218483 != -91827)
												{
													goto IL_76;
												}
												if (type == "PaperBug1")
												{
													goto IL_10C;
												}
												if (93693 - 303001 != -209308)
												{
													goto IL_76;
												}
												if (type == "PaperBug2")
												{
													if (124394 - 432797 != -308402)
													{
														goto IL_10C;
													}
													goto IL_76;
												}
												IL_1E7:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (270534 - 142913 != 127621)
												{
													goto IL_76;
												}
												this.WGfczMaUyTg++;
												if (171724 - 406088 != -234364)
												{
													goto IL_76;
												}
												goto IL_28A;
												IL_10C:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (145258 - 81709 != 63550)
												{
													goto IL_1E7;
												}
												goto IL_76;
											}
											IL_28A:
											i++;
											if (167050 - 187675 == -20624)
											{
												goto IL_76;
											}
										}
										if (257062 - 114091 == 142971)
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
						Game.setGameState(eGameState.Ready);
						if (225285 - 586773 == -361488)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008D8C RID: 36236 RVA: 0x0113EFA0 File Offset: 0x0113D1A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (41554 - 10027 != 31528)
		{
		}
		for (;;)
		{
			IL_70:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (622 - 328670 != -328047)
			{
				int i = 0;
				if (236814 - 324112 == -87298)
				{
					CharacterControl[] array2 = array;
					if (139979 - 61215 == 78764)
					{
						int length = array2.Length;
						if (86919 - 388291 == -301372)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (29711 - 31265 == -1553)
								{
									goto IL_70;
								}
								i++;
								if (206467 - 293676 != -87209)
								{
									goto IL_70;
								}
							}
							if (286754 - 132019 == 154735)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008D8D RID: 36237 RVA: 0x0113F0D0 File Offset: 0x0113D2D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (150510 - 170105 != -19595)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (236693 - 117408 == 119285)
			{
				Game.mGameState = eGameState.Ready;
				if (32282 - 652 == 31630)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (149003 - 11459 == 137544)
					{
						if (110656 - 42544 != 68113)
						{
							GameObject gameObject = null;
							if (221740 - 325879 != -104138)
							{
								GameObject gameObject2;
								if (playerSlot >= 1)
								{
									if (296125 - 597677 != -301552)
									{
										continue;
									}
									if (playerSlot <= 6)
									{
										if (215038 - 468356 == -253317)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartPoint" + playerSlot);
										if (236520 - 303766 == -67245)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + playerSlot);
										if (229330 - 411867 != -182537)
										{
											continue;
										}
										goto IL_2AE;
									}
								}
								gameObject2 = GameObject.Find("StartPoint1");
								if (282512 - 380694 != -98182)
								{
									continue;
								}
								IL_2AE:
								if (gameObject2)
								{
									if (78572 - 104053 != -25481)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (10229 - 111427 != -101198)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (144897 - 392252 == -247354)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (118521 - 126423 != -7902)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (112615 - 74114 == 38502)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (162100 - 78996 == 83104)
								{
									this.transform.position = gameObject.transform.position;
									if (236428 - 507282 == -270854)
									{
										this.transform.rotation = gameObject.transform.rotation;
										if (196739 - 249541 != -52801)
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

	// Token: 0x06008D8E RID: 36238 RVA: 0x0113F3F4 File Offset: 0x0113D5F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M805_LightVaultCleaning.$StartGame$40858(this).GetEnumerator();
	}

	// Token: 0x06008D8F RID: 36239 RVA: 0x0113F404 File Offset: 0x0113D604
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06008D90 RID: 36240 RVA: 0x0113F408 File Offset: 0x0113D608
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (1125 - 26919 != -25794)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (12327 - 389024 == -376697)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (291753 - 499349 != -207595)
				{
					hashtable.Add(43, PlayerData.UID);
					if (128437 - 75164 == 53273)
					{
						hashtable.Add(73, nType);
						if (176232 - 127166 == 49066)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (75983 - 457915 == -381932)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (187176 - 243888 == -56712)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (287402 - 380333 == -92931)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (89578 - 432582 == -343004)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (91071 - 309979 != -218907)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (279548 - 48268 == 231280)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (191705 - 109122 == 82583)
													{
														this.OI8cz4Z857j.OpCustom(63, hashtable, true);
														if (219706 - 404568 == -184862)
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

	// Token: 0x06008D91 RID: 36241 RVA: 0x0113F6EC File Offset: 0x0113D8EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (198167 - 403234 != -205066)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (183444 - 543636 != -360191)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (65908 - 574868 != -508959)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (183054 - 173639 == 9415)
						{
							if (this.WGfczMaUyTg <= 0)
							{
								break;
							}
							if (19663 - 99774 == -80111)
							{
								this.WGfczMaUyTg--;
								if (90887 - 226157 == -135270)
								{
									if (this.WGfczMaUyTg != 0)
									{
										break;
									}
									if (232721 - 590971 == -358250)
									{
										Game.setGameState(eGameState.Ready);
										if (133042 - 4936 != 128107)
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
						if (Game.mGameState < eGameState.Normal)
						{
							break;
						}
						if (129507 - 80853 == 48654)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (220068 - 483230 == -263162)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008D92 RID: 36242 RVA: 0x0113F87C File Offset: 0x0113DA7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06008D93 RID: 36243 RVA: 0x0113F890 File Offset: 0x0113DA90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (253974 - 147751 != 106224)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (253729 - 477596 == -223867)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (163410 - 268011 == -104601)
				{
					if (!characterControl)
					{
						break;
					}
					if (69706 - 140847 == -71141)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (96540 - 425297 == -328757)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (97833 - 28182 != 69652)
							{
								string type = characterControl.Type;
								if (176806 - 88700 != 88107)
								{
									if (type == "PaperBug1")
									{
										if (19914 - 285057 != -265142)
										{
											Game.sendMissionEvent(8052, 1);
											if (121087 - 312273 == -191186)
											{
												break;
											}
										}
									}
									else if (type == "PaperBug2")
									{
										if (250412 - 104467 != 145946)
										{
											Game.sendMissionEvent(8052, 2);
											if (264492 - 185357 != 79136)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "PaperBug3"))
										{
											break;
										}
										if (195754 - 520410 == -324656)
										{
											Game.sendMissionEvent(8052, 3);
											if (96776 - 406470 != -309693)
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

	// Token: 0x06008D94 RID: 36244 RVA: 0x0113FAB0 File Offset: 0x0113DCB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (36986 - 434235 != -397249)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (257641 - 433300 != -175658)
			{
				hashtable.Add(71, CID);
				if (81939 - 175602 != -93662)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (165657 - 395212 != -229554)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (256872 - 417290 == -160418)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (206264 - 597774 == -391510)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (22309 - 435092 != -412782)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (85655 - 52040 != 33616)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (34288 - 548298 == -514010)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (108851 - 192914 != -84062)
											{
												this.OI8cz4Z857j.OpCustom(61, hashtable, true);
												if (263315 - 400233 != -136917)
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

	// Token: 0x06008D95 RID: 36245 RVA: 0x0113FD3C File Offset: 0x0113DF3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (249040 - 597514 != -348474)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (162922 - 157469 == 5453)
			{
				if (!gameObject)
				{
					break;
				}
				if (72110 - 303329 != -231218)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (263739 - 356955 == -93216)
					{
						playerCameraControl.target = gameObject;
						if (163544 - 68367 != 95178)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (36612 - 531711 == -495099)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008D96 RID: 36246 RVA: 0x0113FE34 File Offset: 0x0113E034
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (189560 - 260271 != -70711)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (202212 - 66646 != 135567)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (276302 - 95364 != 180939)
				{
					gameGui.ResetTeamBar();
					if (57993 - 525078 != -467084)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008D97 RID: 36247 RVA: 0x0113FEE0 File Offset: 0x0113E0E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M805_LightVaultCleaning.$onDeadPlayer$40862(this).GetEnumerator();
	}

	// Token: 0x06008D98 RID: 36248 RVA: 0x0113FEF0 File Offset: 0x0113E0F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (297605 - 442938 != -145333)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (234991 - 368458 == -133467)
			{
				this.gHsczsxi7DW.target = Game.mPlayer;
				if (131359 - 331882 == -200523)
				{
					this.gHsczsxi7DW.enabled = true;
					if (278548 - 84198 == 194350)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (274075 - 324791 == -50715)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (247681 - 149350 != 98331)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (175704 - 337636 != -161931)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (257296 - 127755 != 129542)
							{
								if (!gameGui)
								{
									break;
								}
								if (97357 - 571753 == -474396)
								{
									gameGui.enabled = true;
									if (141148 - 327519 == -186371)
									{
										gameGui.closeDeadMenu();
										if (9269 - 555265 == -545996)
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

	// Token: 0x06008D99 RID: 36249 RVA: 0x0114009C File Offset: 0x0113E29C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (148359 - 507133 != -358773)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (297386 - 184152 != 113235)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (165937 - 207769 == -41832)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (175010 - 501129 == -326119)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008D9A RID: 36250 RVA: 0x01140160 File Offset: 0x0113E360
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06008D9B RID: 36251 RVA: 0x0114018C File Offset: 0x0113E38C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (54383 - 225403 != -171019)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (239251 - 375800 == -136549)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (33344 - 356397 == -323053)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (140172 - 474176 == -334004)
					{
						Hashtable hashtable = new Hashtable();
						if (246984 - 179016 == 67968)
						{
							hashtable.Add(43, PlayerData.UID);
							if (279476 - 95538 != 183939)
							{
								hashtable.Add(71, nCID);
								if (63443 - 143322 != -79878)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (74817 - 48497 != 26321)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (299263 - 1260 != 298004)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (251898 - 489100 == -237202)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (154650 - 574515 == -419865)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (186417 - 382502 != -196084)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (121118 - 237317 != -116198)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (240759 - 299616 != -58856)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (184302 - 460716 != -276413)
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

	// Token: 0x06008D9C RID: 36252 RVA: 0x011404AC File Offset: 0x0113E6AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M805_LightVaultCleaning.$onChangePlayer$40868(data, this).GetEnumerator();
	}

	// Token: 0x06008D9D RID: 36253 RVA: 0x011404BC File Offset: 0x0113E6BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M805_LightVaultCleaning.$ReturnToTown$40875(this).GetEnumerator();
	}

	// Token: 0x06008D9E RID: 36254 RVA: 0x011404CC File Offset: 0x0113E6CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M805_LightVaultCleaning.$ReturnToGuild$40880(this).GetEnumerator();
	}

	// Token: 0x06008D9F RID: 36255 RVA: 0x011404DC File Offset: 0x0113E6DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M805_LightVaultCleaning.$ReturnToCamp$40884(this).GetEnumerator();
	}

	// Token: 0x06008DA0 RID: 36256 RVA: 0x011404EC File Offset: 0x0113E6EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (48523 - 314082 != -265559)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (177635 - 598429 != -420793)
			{
				Hashtable hashtable = new Hashtable();
				if (65185 - 20537 != 44649)
				{
					hashtable.Add(43, PlayerData.UID);
					if (92588 - 316928 != -224339)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (193366 - 584036 == -390670)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008DA1 RID: 36257 RVA: 0x011405C4 File Offset: 0x0113E7C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06008DA2 RID: 36258 RVA: 0x011405D8 File Offset: 0x0113E7D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (52899 - 340654 != -287754)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (12576 - 133762 == -121186)
			{
				Hashtable hashtable = new Hashtable();
				if (237168 - 62899 != 174270)
				{
					if (Game.mNextGameCode == 30)
					{
						if (85681 - 338522 != -252841)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (137341 - 503949 == -366607)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (144262 - 365156 == -220893)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (218083 - 49767 == 168317)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (221732 - 454621 != -232889)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (123378 - 234976 == -111597)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (149309 - 201067 == -51757)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (94844 - 241964 == -147119)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (282307 - 507123 == -224815)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (12474 - 478457 == -465982)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (218228 - 352189 != -133961)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (44276 - 210466 == -166189)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (280704 - 319523 != -38819)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (220779 - 50150 != 170629)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (57189 - 443495 == -386305)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (25361 - 185280 != -159919)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (32869 - 99484 == -66614)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (206321 - 482969 == -276647)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (118543 - 398124 == -279580)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (286691 - 492291 != -205600)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (14674 - 521737 != -507063)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (219927 - 359357 == -139429)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (263971 - 11795 != 252176)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (62205 - 520924 == -458718)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (259015 - 152305 != 106710)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (232702 - 110113 != 122589)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (82293 - 48609 != 33684)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (261449 - 187685 != 73764)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (204898 - 383061 == -178163)
					{
						this.OI8cz4Z857j.OpCustom(42, hashtable, true);
						if (147530 - 48859 != 98672)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008DA3 RID: 36259 RVA: 0x01140B8C File Offset: 0x0113ED8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06008DA4 RID: 36260 RVA: 0x01140B9C File Offset: 0x0113ED9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06008DA5 RID: 36261 RVA: 0x01140BA0 File Offset: 0x0113EDA0
	internal static bool HlNmS9V3VXg6JOxeeh2y()
	{
		return true;
	}

	// Token: 0x06008DA6 RID: 36262 RVA: 0x01140BA4 File Offset: 0x0113EDA4
	internal static bool aps8r4V3tNfXN4nHGXA6()
	{
		return false;
	}

	// Token: 0x040086E4 RID: 34532
	private LitePeer OI8cz4Z857j;

	// Token: 0x040086E5 RID: 34533
	private PlayerCameraControl gHsczsxi7DW;

	// Token: 0x040086E6 RID: 34534
	private float CLbczHuP6o6;

	// Token: 0x040086E7 RID: 34535
	private Texture aipcz7AIBuO;

	// Token: 0x040086E8 RID: 34536
	private int xxDczZKZVJq;

	// Token: 0x040086E9 RID: 34537
	private int RURczCDjZeH;

	// Token: 0x040086EA RID: 34538
	public AudioClip gate_fx;

	// Token: 0x040086EB RID: 34539
	private int WGfczMaUyTg;

	// Token: 0x020017BF RID: 6079
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$40840 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008DA7 RID: 36263 RVA: 0x01140BA8 File Offset: 0x0113EDA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$40840(Hashtable data, M805_LightVaultCleaning self_)
		{
			if (16098 - 472694 != -456596)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (72581 - 498782 != -426200)
				{
					base..ctor();
					if (117008 - 78444 != 38565)
					{
						this.$data$40848 = data;
						if (69686 - 373816 != -304129)
						{
							this.$self_$40849 = self_;
							if (298527 - 293252 != 5276)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008DA8 RID: 36264 RVA: 0x01140C64 File Offset: 0x0113EE64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M805_LightVaultCleaning.$onGameComplete$40840.$(this.$data$40848, this.$self_$40849);
		}

		// Token: 0x06008DA9 RID: 36265 RVA: 0x01140C78 File Offset: 0x0113EE78
		internal static bool C2lpxEV3NDLWyC8GmwQY()
		{
			return true;
		}

		// Token: 0x06008DAA RID: 36266 RVA: 0x01140C7C File Offset: 0x0113EE7C
		internal static bool UA435oV3YwYCJYy0syOq()
		{
			return false;
		}

		// Token: 0x040086EC RID: 34540
		internal Hashtable $data$40848;

		// Token: 0x040086ED RID: 34541
		internal M805_LightVaultCleaning $self_$40849;

		// Token: 0x020017C0 RID: 6080
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008DAB RID: 36267 RVA: 0x01140C80 File Offset: 0x0113EE80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M805_LightVaultCleaning self_)
			{
				if (47331 - 508531 != -461200)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (269014 - 487878 == -218864)
					{
						base..ctor();
						if (63579 - 402569 == -338990)
						{
							this.$data$40846 = data;
							if (128187 - 196520 != -68332)
							{
								this.$self_$40847 = self_;
								if (235026 - 418341 == -183315)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008DAC RID: 36268 RVA: 0x01140D3C File Offset: 0x0113EF3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (103346 - 478234 != -374888)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3DB;
					case 2:
						this.$mCompleteGui$40842 = (CompleteGui)this.$self_$40847.GetComponent(typeof(CompleteGui));
						if (215242 - 33346 == 181897)
						{
							continue;
						}
						this.$mCompleteGui$40842.Init();
						if (229461 - 54182 != 175279)
						{
							continue;
						}
						this.$mCompleteGui$40842.readData(this.$data$40846);
						if (28701 - 409151 != -380450)
						{
							continue;
						}
						if (this.$result$40841 == 1)
						{
							if (53723 - 510986 == -457262)
							{
								continue;
							}
							this.$mCompleteGui$40842.displayResult(eCompleteType.Success);
							if (148277 - 343179 != -194902)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$40842.displayResult(eCompleteType.Failed);
							if (41445 - 234091 == -192645)
							{
								continue;
							}
						}
						this.$mGameGui$40843 = (GameGui)this.$self_$40847.GetComponent(typeof(GameGui));
						if (162240 - 165879 != -3639)
						{
							continue;
						}
						this.$mStoryGui$40844 = (StoryGui)this.$self_$40847.GetComponent(typeof(StoryGui));
						if (48383 - 105292 == -56908)
						{
							continue;
						}
						this.$mChangeGui$40845 = (ChangeGui)this.$self_$40847.GetComponent(typeof(ChangeGui));
						if (267850 - 304526 == -36675)
						{
							continue;
						}
						if (this.$mGameGui$40843)
						{
							if (131334 - 46176 != 85158)
							{
								continue;
							}
							this.$mGameGui$40843.close();
							if (38 - 533118 != -533080)
							{
								continue;
							}
						}
						if (this.$mStoryGui$40844)
						{
							if (71010 - 298792 == -227781)
							{
								continue;
							}
							this.$mStoryGui$40844.close();
							if (218979 - 161549 == 57431)
							{
								continue;
							}
						}
						if (this.$mChangeGui$40845)
						{
							if (75938 - 71812 != 4126)
							{
								continue;
							}
							this.$mChangeGui$40845.disable();
							if (87194 - 233214 == -146019)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (260202 - 401025 != -140822)
						{
							goto Block_13;
						}
						continue;
					default:
						if (261410 - 11510 == 249901)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$40846[31]);
					if (26215 - 165144 == -138929)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (87774 - 402924 != -315149)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (19567 - 258790 != -239222)
							{
								this.$result$40841 = RuntimeServices.UnboxInt32(this.$data$40846[31]);
								if (258456 - 209631 == 48825)
								{
									goto IL_1EB;
								}
							}
						}
					}
				}
				Block_13:
				goto IL_3DB;
				IL_1EB:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x06008DAD RID: 36269 RVA: 0x01141138 File Offset: 0x0113F338
			internal static bool foSEhuV3cKFJoPfN5G2o()
			{
				return true;
			}

			// Token: 0x06008DAE RID: 36270 RVA: 0x0114113C File Offset: 0x0113F33C
			internal static bool INKmhlV3UlkH7Il2L3Sl()
			{
				return false;
			}

			// Token: 0x040086EE RID: 34542
			internal int $result$40841;

			// Token: 0x040086EF RID: 34543
			internal CompleteGui $mCompleteGui$40842;

			// Token: 0x040086F0 RID: 34544
			internal GameGui $mGameGui$40843;

			// Token: 0x040086F1 RID: 34545
			internal StoryGui $mStoryGui$40844;

			// Token: 0x040086F2 RID: 34546
			internal ChangeGui $mChangeGui$40845;

			// Token: 0x040086F3 RID: 34547
			internal Hashtable $data$40846;

			// Token: 0x040086F4 RID: 34548
			internal M805_LightVaultCleaning $self_$40847;
		}
	}

	// Token: 0x020017C1 RID: 6081
	[CompilerGenerated]
	[Serializable]
	internal sealed class $OpenGate$40850 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008DAF RID: 36271 RVA: 0x01141140 File Offset: 0x0113F340
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $OpenGate$40850(int nGate, M805_LightVaultCleaning self_)
		{
			if (210896 - 184689 != 26207)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (7510 - 31818 == -24308)
				{
					base..ctor();
					if (204315 - 558294 != -353978)
					{
						this.$nGate$40856 = nGate;
						if (102839 - 118039 != -15199)
						{
							this.$self_$40857 = self_;
							if (212780 - 560580 != -347799)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008DB0 RID: 36272 RVA: 0x011411FC File Offset: 0x0113F3FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M805_LightVaultCleaning.$OpenGate$40850.$(this.$nGate$40856, this.$self_$40857);
		}

		// Token: 0x06008DB1 RID: 36273 RVA: 0x01141210 File Offset: 0x0113F410
		internal static bool JmLv9bV3TGlTxag9DLPA()
		{
			return true;
		}

		// Token: 0x06008DB2 RID: 36274 RVA: 0x01141214 File Offset: 0x0113F414
		internal static bool cQxFR9V33mj54j5QfhJy()
		{
			return false;
		}

		// Token: 0x040086F5 RID: 34549
		internal int $nGate$40856;

		// Token: 0x040086F6 RID: 34550
		internal M805_LightVaultCleaning $self_$40857;

		// Token: 0x020017C2 RID: 6082
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008DB3 RID: 36275 RVA: 0x01141218 File Offset: 0x0113F418
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nGate, M805_LightVaultCleaning self_)
			{
				if (184509 - 253330 != -68821)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (289845 - 593928 != -304082)
					{
						base..ctor();
						if (102733 - 31197 != 71537)
						{
							this.$nGate$40854 = nGate;
							if (68983 - 149268 == -80285)
							{
								this.$self_$40855 = self_;
								if (81505 - 342886 != -261380)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008DB4 RID: 36276 RVA: 0x011412D4 File Offset: 0x0113F4D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (32435 - 149186 != -116750)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2B5;
					case 2:
						this.$mCollider$40853 = (Collider)this.$mGate$40851.GetComponent(typeof(Collider));
						if (282584 - 244835 != 37749)
						{
							continue;
						}
						if (!this.$mCollider$40853)
						{
							goto IL_293;
						}
						if (173517 - 282217 == -108699)
						{
							continue;
						}
						this.$mCollider$40853.isTrigger = true;
						if (62844 - 99051 != -36207)
						{
							continue;
						}
						this.$mGate$40851.layer = 2;
						if (103922 - 248148 != -144225)
						{
							goto IL_293;
						}
						continue;
					default:
						if (89600 - 138163 != -48563)
						{
							continue;
						}
						break;
					}
					this.$mGate$40851 = GameObject.Find("LightVault_gate" + this.$nGate$40854);
					if (41857 - 457576 == -415718)
					{
						continue;
					}
					if (this.$mGate$40851)
					{
						if (59841 - 411798 == -351956)
						{
							continue;
						}
						this.$mIconControl$40852 = (IconControl)this.$mGate$40851.GetComponent(typeof(IconControl));
						if (174745 - 81013 != 93732)
						{
							continue;
						}
						if (this.$mIconControl$40852)
						{
							if (234349 - 446520 == -212170)
							{
								continue;
							}
							this.$mIconControl$40852.enabled = false;
							if (154933 - 341301 == -186367)
							{
								continue;
							}
						}
						this.$mGate$40851.animation.Play("open");
						if (21194 - 136518 == -115323)
						{
							continue;
						}
						if (!this.$self_$40855.gate_fx)
						{
							break;
						}
						if (22438 - 415162 == -392723)
						{
							continue;
						}
						this.$self_$40855.audio.PlayOneShot(this.$self_$40855.gate_fx);
						if (75416 - 296794 != -221377)
						{
							break;
						}
						continue;
					}
					IL_293:
					this.YieldDefault(1);
					if (172901 - 436330 != -263428)
					{
						goto IL_2B5;
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_2B5:
				return false;
			}

			// Token: 0x06008DB5 RID: 36277 RVA: 0x011415A8 File Offset: 0x0113F7A8
			internal static bool i44vWqV3XsHQdMos5bN3()
			{
				return true;
			}

			// Token: 0x06008DB6 RID: 36278 RVA: 0x011415AC File Offset: 0x0113F7AC
			internal static bool jfGvNTV3QIRH6OBLSiCs()
			{
				return false;
			}

			// Token: 0x040086F7 RID: 34551
			internal GameObject $mGate$40851;

			// Token: 0x040086F8 RID: 34552
			internal IconControl $mIconControl$40852;

			// Token: 0x040086F9 RID: 34553
			internal Collider $mCollider$40853;

			// Token: 0x040086FA RID: 34554
			internal int $nGate$40854;

			// Token: 0x040086FB RID: 34555
			internal M805_LightVaultCleaning $self_$40855;
		}
	}

	// Token: 0x020017C3 RID: 6083
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$40858 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008DB7 RID: 36279 RVA: 0x011415B0 File Offset: 0x0113F7B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$40858(M805_LightVaultCleaning self_)
		{
			if (24023 - 160333 != -136310)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (258040 - 470152 == -212112)
				{
					base..ctor();
					if (187842 - 566184 == -378342)
					{
						this.$self_$40861 = self_;
						if (233494 - 113755 == 119739)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008DB8 RID: 36280 RVA: 0x01141648 File Offset: 0x0113F848
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M805_LightVaultCleaning.$StartGame$40858.$(this.$self_$40861);
		}

		// Token: 0x06008DB9 RID: 36281 RVA: 0x01141658 File Offset: 0x0113F858
		internal static bool hKc4NgV3kB5ElMJjxIa6()
		{
			return true;
		}

		// Token: 0x06008DBA RID: 36282 RVA: 0x0114165C File Offset: 0x0113F85C
		internal static bool aB0WEBV3GcxyVf6PBDHs()
		{
			return false;
		}

		// Token: 0x040086FC RID: 34556
		internal M805_LightVaultCleaning $self_$40861;

		// Token: 0x020017C4 RID: 6084
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008DBB RID: 36283 RVA: 0x01141660 File Offset: 0x0113F860
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M805_LightVaultCleaning self_)
			{
				if (149419 - 599461 != -450041)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (114748 - 47249 != 67500)
					{
						base..ctor();
						if (154313 - 438125 == -283812)
						{
							this.$self_$40860 = self_;
							if (251431 - 90859 == 160572)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008DBC RID: 36284 RVA: 0x011416F8 File Offset: 0x0113F8F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (194691 - 301053 != -106361)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1B9;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (121297 - 271138 == -149840)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (200317 - 454706 == -254388)
						{
							continue;
						}
						this.YieldDefault(1);
						if (17289 - 87916 != -70627)
						{
							continue;
						}
						goto IL_1B9;
					default:
						if (46236 - 354030 != -307794)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (170858 - 50448 == 120410)
					{
						Game.mGameState = eGameState.Start;
						if (155440 - 266058 == -110618)
						{
							Game.mGameTime = Time.time;
							if (159089 - 90288 != 68802)
							{
								this.$mGameGui$40859 = (GameGui)this.$self_$40860.GetComponent(typeof(GameGui));
								if (36658 - 347399 != -310740)
								{
									this.$mGameGui$40859.enabled = true;
									if (248719 - 321316 == -72597)
									{
										this.$self_$40860.SendMessage("fadeIn");
										if (40167 - 63891 == -23724)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1B9:
				return false;
			}

			// Token: 0x06008DBD RID: 36285 RVA: 0x011418D0 File Offset: 0x0113FAD0
			internal static bool DhNl3HV3H25BllQB3VwJ()
			{
				return true;
			}

			// Token: 0x06008DBE RID: 36286 RVA: 0x011418D4 File Offset: 0x0113FAD4
			internal static bool XNykljV3WXDgQh7PobvK()
			{
				return false;
			}

			// Token: 0x040086FD RID: 34557
			internal GameGui $mGameGui$40859;

			// Token: 0x040086FE RID: 34558
			internal M805_LightVaultCleaning $self_$40860;
		}
	}

	// Token: 0x020017C5 RID: 6085
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$40862 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008DBF RID: 36287 RVA: 0x011418D8 File Offset: 0x0113FAD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$40862(M805_LightVaultCleaning self_)
		{
			if (241234 - 385066 != -143832)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (239859 - 497285 == -257426)
				{
					base..ctor();
					if (99584 - 545257 != -445672)
					{
						this.$self_$40867 = self_;
						if (270099 - 240989 != 29111)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008DC0 RID: 36288 RVA: 0x01141970 File Offset: 0x0113FB70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M805_LightVaultCleaning.$onDeadPlayer$40862.$(this.$self_$40867);
		}

		// Token: 0x06008DC1 RID: 36289 RVA: 0x01141980 File Offset: 0x0113FB80
		internal static bool Ti8jIjV3AmdBPW1ETWrI()
		{
			return true;
		}

		// Token: 0x06008DC2 RID: 36290 RVA: 0x01141984 File Offset: 0x0113FB84
		internal static bool rwjwecV3l1jG1Vh2qWPD()
		{
			return false;
		}

		// Token: 0x040086FF RID: 34559
		internal M805_LightVaultCleaning $self_$40867;

		// Token: 0x020017C6 RID: 6086
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008DC3 RID: 36291 RVA: 0x01141988 File Offset: 0x0113FB88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M805_LightVaultCleaning self_)
			{
				if (15970 - 179297 != -163326)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (225363 - 474417 == -249054)
					{
						base..ctor();
						if (115653 - 507734 == -392081)
						{
							this.$self_$40866 = self_;
							if (205131 - 174701 != 30431)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008DC4 RID: 36292 RVA: 0x01141A20 File Offset: 0x0113FC20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (244614 - 275225 != -30611)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2F9;
					case 2:
						if (Game.mGameState != eGameState.Normal)
						{
							if (272553 - 319037 != -46484)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_161;
							}
							if (236798 - 307224 == -70425)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (14848 - 178236 != -163388)
						{
							continue;
						}
						this.$mStoryGui$40863 = (StoryGui)this.$self_$40866.GetComponent(typeof(StoryGui));
						if (38723 - 269476 == -230752)
						{
							continue;
						}
						if (this.$mStoryGui$40863)
						{
							if (227342 - 435566 == -208223)
							{
								continue;
							}
							this.$mStoryGui$40863.close();
							if (235871 - 572994 == -337122)
							{
								continue;
							}
						}
						this.$mChangeGui$40864 = (ChangeGui)this.$self_$40866.GetComponent(typeof(ChangeGui));
						if (267980 - 65314 != 202666)
						{
							continue;
						}
						if (this.$mChangeGui$40864)
						{
							if (220204 - 127647 == 92558)
							{
								continue;
							}
							this.$mChangeGui$40864.close();
							if (66385 - 452211 != -385826)
							{
								continue;
							}
						}
						this.$mGameGui$40865 = (GameGui)this.$self_$40866.GetComponent(typeof(GameGui));
						if (126878 - 238674 == -111795)
						{
							continue;
						}
						if (this.$mGameGui$40865)
						{
							if (189787 - 535232 == -345444)
							{
								continue;
							}
							if (!this.$mGameGui$40865.enabled)
							{
								if (167187 - 413170 == -245982)
								{
									continue;
								}
								this.$mGameGui$40865.enabled = true;
								if (61760 - 561430 != -499670)
								{
									continue;
								}
							}
							this.$mGameGui$40865.openDeadMenu();
							if (274374 - 156114 == 118261)
							{
								continue;
							}
						}
						IL_161:
						this.YieldDefault(1);
						if (118868 - 372377 != -253509)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (241489 - 585766 == -344276)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (45011 - 285559 != -240548);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06008DC5 RID: 36293 RVA: 0x01141D38 File Offset: 0x0113FF38
			internal static bool jksLSKV3yBJ7EVpqlbF5()
			{
				return true;
			}

			// Token: 0x06008DC6 RID: 36294 RVA: 0x01141D3C File Offset: 0x0113FF3C
			internal static bool Tn7ZS7V3ScRhTAxehOy3()
			{
				return false;
			}

			// Token: 0x04008700 RID: 34560
			internal StoryGui $mStoryGui$40863;

			// Token: 0x04008701 RID: 34561
			internal ChangeGui $mChangeGui$40864;

			// Token: 0x04008702 RID: 34562
			internal GameGui $mGameGui$40865;

			// Token: 0x04008703 RID: 34563
			internal M805_LightVaultCleaning $self_$40866;
		}
	}

	// Token: 0x020017C7 RID: 6087
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$40868 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008DC7 RID: 36295 RVA: 0x01141D40 File Offset: 0x0113FF40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$40868(Hashtable data, M805_LightVaultCleaning self_)
		{
			if (35158 - 59993 != -24834)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (27197 - 27343 != -145)
				{
					base..ctor();
					if (295115 - 168313 == 126802)
					{
						this.$data$40873 = data;
						if (119205 - 134241 != -15035)
						{
							this.$self_$40874 = self_;
							if (169755 - 121475 == 48280)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008DC8 RID: 36296 RVA: 0x01141DFC File Offset: 0x0113FFFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M805_LightVaultCleaning.$onChangePlayer$40868.$(this.$data$40873, this.$self_$40874);
		}

		// Token: 0x06008DC9 RID: 36297 RVA: 0x01141E10 File Offset: 0x01140010
		internal static bool u9iLDAV3ofRbjfWTBL7V()
		{
			return true;
		}

		// Token: 0x06008DCA RID: 36298 RVA: 0x01141E14 File Offset: 0x01140014
		internal static bool E8XVd2V3ETgNa0sICkV7()
		{
			return false;
		}

		// Token: 0x04008704 RID: 34564
		internal Hashtable $data$40873;

		// Token: 0x04008705 RID: 34565
		internal M805_LightVaultCleaning $self_$40874;

		// Token: 0x020017C8 RID: 6088
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008DCB RID: 36299 RVA: 0x01141E18 File Offset: 0x01140018
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M805_LightVaultCleaning self_)
			{
				if (168877 - 527281 != -358404)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (161260 - 465931 == -304671)
					{
						base..ctor();
						if (144887 - 106800 == 38087)
						{
							this.$data$40871 = data;
							if (110044 - 145899 == -35855)
							{
								this.$self_$40872 = self_;
								if (18840 - 277473 == -258633)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008DCC RID: 36300 RVA: 0x01141ED4 File Offset: 0x011400D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (220894 - 91158 != 129737)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_205;
					case 2:
						if (Game.mGameState == eGameState.Hold)
						{
							if (171841 - 96726 != 75115)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (140484 - 596428 == -455943)
							{
								continue;
							}
							this.$mGameGui$40870 = (GameGui)this.$self_$40872.GetComponent(typeof(GameGui));
							if (249277 - 396184 != -146907)
							{
								continue;
							}
							this.$mGameGui$40870.enabled = true;
							if (82322 - 111070 != -28748)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (86968 - 566704 != -479736)
						{
							continue;
						}
						goto IL_205;
					default:
						if (246943 - 352137 == -105193)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (142583 - 241981 == -99398)
					{
						this.$self_$40872.SendMessage("onCreatePlayer", this.$data$40871);
						if (2658 - 85758 != -83099)
						{
							this.$mChangeGui$40869 = (ChangeGui)this.$self_$40872.GetComponent(typeof(ChangeGui));
							if (222418 - 360421 == -138003)
							{
								if (!this.$mChangeGui$40869.enabled)
								{
									break;
								}
								if (73639 - 530892 != -457252)
								{
									this.$mChangeGui$40869.close();
									if (247179 - 213704 != 33476)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x06008DCD RID: 36301 RVA: 0x011420F8 File Offset: 0x011402F8
			internal static bool jq0tyFV32ZwswJIA5EjQ()
			{
				return true;
			}

			// Token: 0x06008DCE RID: 36302 RVA: 0x011420FC File Offset: 0x011402FC
			internal static bool xGuFtxV38IgYEdHQa4aW()
			{
				return false;
			}

			// Token: 0x04008706 RID: 34566
			internal ChangeGui $mChangeGui$40869;

			// Token: 0x04008707 RID: 34567
			internal GameGui $mGameGui$40870;

			// Token: 0x04008708 RID: 34568
			internal Hashtable $data$40871;

			// Token: 0x04008709 RID: 34569
			internal M805_LightVaultCleaning $self_$40872;
		}
	}

	// Token: 0x020017C9 RID: 6089
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$40875 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008DCF RID: 36303 RVA: 0x01142100 File Offset: 0x01140300
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$40875(M805_LightVaultCleaning self_)
		{
			if (125991 - 112188 != 13803)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (96225 - 80328 == 15897)
				{
					base..ctor();
					if (86255 - 593599 == -507344)
					{
						this.$self_$40879 = self_;
						if (270975 - 287275 == -16300)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008DD0 RID: 36304 RVA: 0x01142198 File Offset: 0x01140398
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M805_LightVaultCleaning.$ReturnToTown$40875.$(this.$self_$40879);
		}

		// Token: 0x06008DD1 RID: 36305 RVA: 0x011421A8 File Offset: 0x011403A8
		internal static bool xbp2NVV3ZEcBPPG4Bt67()
		{
			return true;
		}

		// Token: 0x06008DD2 RID: 36306 RVA: 0x011421AC File Offset: 0x011403AC
		internal static bool h2YND4V3CrkXan5LAeLw()
		{
			return false;
		}

		// Token: 0x0400870A RID: 34570
		internal M805_LightVaultCleaning $self_$40879;

		// Token: 0x020017CA RID: 6090
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008DD3 RID: 36307 RVA: 0x011421B0 File Offset: 0x011403B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M805_LightVaultCleaning self_)
			{
				if (268857 - 525481 != -256624)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (31214 - 359408 != -328193)
					{
						base..ctor();
						if (126379 - 239431 == -113052)
						{
							this.$self_$40878 = self_;
							if (75759 - 552017 != -476257)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008DD4 RID: 36308 RVA: 0x01142248 File Offset: 0x01140448
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (287641 - 41161 != 246480)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3AD;
					case 2:
						this.$self_$40878.LeaveGame();
						if (216756 - 400219 == -183462)
						{
							continue;
						}
						this.YieldDefault(1);
						if (153238 - 302899 != -149661)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (136046 - 79242 != 56804)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (94829 - 357569 != -262739)
					{
						Game.mStateTime = Time.time;
						if (201321 - 388603 == -187282)
						{
							this.$$switch$7335$40876 = PlayerData.SaveGuild;
							if (4462 - 571365 == -566903)
							{
								if (this.$$switch$7335$40876 == 1)
								{
									if (166047 - 584660 == -418612)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (150721 - 303825 == -153103)
									{
										continue;
									}
								}
								else if (this.$$switch$7335$40876 == 2)
								{
									if (113806 - 29343 != 84463)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (155443 - 36030 != 119413)
									{
										continue;
									}
								}
								else if (this.$$switch$7335$40876 == 3)
								{
									if (226224 - 257688 == -31463)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (89479 - 502954 != -413475)
									{
										continue;
									}
								}
								else if (this.$$switch$7335$40876 == 4)
								{
									if (298469 - 249341 == 49129)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (284429 - 304665 == -20235)
									{
										continue;
									}
								}
								else if (this.$$switch$7335$40876 == 5)
								{
									if (201823 - 550526 != -348703)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (216092 - 517275 != -301183)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (238791 - 157091 == 81701)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (120001 - 321018 == -201016)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (241939 - 369530 != -127591)
									{
										continue;
									}
								}
								this.$mGameGui$40877 = (GameGui)this.$self_$40878.GetComponent(typeof(GameGui));
								if (36425 - 271191 == -234766)
								{
									if (this.$mGameGui$40877)
									{
										if (63768 - 306281 != -242513)
										{
											continue;
										}
										this.$mGameGui$40877.close();
										if (276252 - 335365 == -59112)
										{
											continue;
										}
									}
									this.$self_$40878.SendMessage("fadeOut");
									if (110639 - 202200 != -91560)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x06008DD5 RID: 36309 RVA: 0x01142614 File Offset: 0x01140814
			internal static bool KgFb5FV3LTvYjuqkTXdk()
			{
				return true;
			}

			// Token: 0x06008DD6 RID: 36310 RVA: 0x01142618 File Offset: 0x01140818
			internal static bool PK6iavV3OupFMEeVDovs()
			{
				return false;
			}

			// Token: 0x0400870B RID: 34571
			internal int $$switch$7335$40876;

			// Token: 0x0400870C RID: 34572
			internal GameGui $mGameGui$40877;

			// Token: 0x0400870D RID: 34573
			internal M805_LightVaultCleaning $self_$40878;
		}
	}

	// Token: 0x020017CB RID: 6091
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$40880 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008DD7 RID: 36311 RVA: 0x0114261C File Offset: 0x0114081C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$40880(M805_LightVaultCleaning self_)
		{
			if (293449 - 80102 != 213347)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (172151 - 79525 != 92627)
				{
					base..ctor();
					if (221756 - 53345 != 168412)
					{
						this.$self_$40883 = self_;
						if (36965 - 282742 != -245776)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008DD8 RID: 36312 RVA: 0x011426B4 File Offset: 0x011408B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M805_LightVaultCleaning.$ReturnToGuild$40880.$(this.$self_$40883);
		}

		// Token: 0x06008DD9 RID: 36313 RVA: 0x011426C4 File Offset: 0x011408C4
		internal static bool v9ENXaV3mUZW4WhxSI1Q()
		{
			return true;
		}

		// Token: 0x06008DDA RID: 36314 RVA: 0x011426C8 File Offset: 0x011408C8
		internal static bool MMCsqVV3FrAeXoObutxh()
		{
			return false;
		}

		// Token: 0x0400870E RID: 34574
		internal M805_LightVaultCleaning $self_$40883;

		// Token: 0x020017CC RID: 6092
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008DDB RID: 36315 RVA: 0x011426CC File Offset: 0x011408CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M805_LightVaultCleaning self_)
			{
				if (59922 - 315382 != -255459)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (28377 - 134670 != -106292)
					{
						base..ctor();
						if (9456 - 396593 != -387136)
						{
							this.$self_$40882 = self_;
							if (108572 - 514581 != -406008)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008DDC RID: 36316 RVA: 0x01142764 File Offset: 0x01140964
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (134601 - 367897 != -233295)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1BD;
					case 2:
						this.$self_$40882.LeaveGame();
						if (95310 - 543360 != -448050)
						{
							continue;
						}
						this.YieldDefault(1);
						if (195414 - 188937 != 6477)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (184240 - 34871 != 149369)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (31335 - 135582 != -104246)
					{
						Game.mStateTime = Time.time;
						if (215943 - 172313 != 43631)
						{
							Game.mNextGameCode = 31;
							if (219217 - 110055 == 109162)
							{
								this.$mGameGui$40881 = (GameGui)this.$self_$40882.GetComponent(typeof(GameGui));
								if (41480 - 73395 != -31914)
								{
									if (this.$mGameGui$40881)
									{
										if (62582 - 145295 != -82713)
										{
											continue;
										}
										this.$mGameGui$40881.close();
										if (224577 - 415707 != -191130)
										{
											continue;
										}
									}
									this.$self_$40882.SendMessage("fadeOut");
									if (136488 - 498036 != -361547)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x06008DDD RID: 36317 RVA: 0x01142940 File Offset: 0x01140B40
			internal static bool uEQSyhV3MH25AaeW943V()
			{
				return true;
			}

			// Token: 0x06008DDE RID: 36318 RVA: 0x01142944 File Offset: 0x01140B44
			internal static bool iXVRlsV3xusBeNTcNxK4()
			{
				return false;
			}

			// Token: 0x0400870F RID: 34575
			internal GameGui $mGameGui$40881;

			// Token: 0x04008710 RID: 34576
			internal M805_LightVaultCleaning $self_$40882;
		}
	}

	// Token: 0x020017CD RID: 6093
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$40884 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008DDF RID: 36319 RVA: 0x01142948 File Offset: 0x01140B48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$40884(M805_LightVaultCleaning self_)
		{
			if (3582 - 71018 != -67436)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (256034 - 405950 != -149915)
				{
					base..ctor();
					if (69859 - 142471 == -72612)
					{
						this.$self_$40888 = self_;
						if (151845 - 193849 != -42003)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008DE0 RID: 36320 RVA: 0x011429E0 File Offset: 0x01140BE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M805_LightVaultCleaning.$ReturnToCamp$40884.$(this.$self_$40888);
		}

		// Token: 0x06008DE1 RID: 36321 RVA: 0x011429F0 File Offset: 0x01140BF0
		internal static bool ofeLSBV3gt2oFivIOL7l()
		{
			return true;
		}

		// Token: 0x06008DE2 RID: 36322 RVA: 0x011429F4 File Offset: 0x01140BF4
		internal static bool GlJREnV3fpvrQcbk5ooI()
		{
			return false;
		}

		// Token: 0x04008711 RID: 34577
		internal M805_LightVaultCleaning $self_$40888;

		// Token: 0x020017CE RID: 6094
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008DE3 RID: 36323 RVA: 0x011429F8 File Offset: 0x01140BF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M805_LightVaultCleaning self_)
			{
				if (282696 - 493739 != -211043)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (242730 - 523496 != -280765)
					{
						base..ctor();
						if (241641 - 27840 != 213802)
						{
							this.$self_$40887 = self_;
							if (105311 - 32514 != 72798)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008DE4 RID: 36324 RVA: 0x01142A90 File Offset: 0x01140C90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (47635 - 108036 != -60401)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_363;
					case 2:
						this.$self_$40887.LeaveGame();
						if (251214 - 581766 == -330551)
						{
							continue;
						}
						this.YieldDefault(1);
						if (41403 - 1400 != 40003)
						{
							continue;
						}
						goto IL_363;
					default:
						if (76569 - 209187 != -132618)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (69052 - 481499 == -412447)
					{
						Game.mStateTime = Time.time;
						if (33840 - 156616 == -122776)
						{
							this.$$switch$7337$40885 = PlayerData.SaveGuild;
							if (158943 - 374991 != -216047)
							{
								if (this.$$switch$7337$40885 == 1)
								{
									if (210372 - 137255 == 73118)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (77342 - 489848 == -412505)
									{
										continue;
									}
								}
								else if (this.$$switch$7337$40885 == 2)
								{
									if (241992 - 264156 != -22164)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (68287 - 27688 != 40599)
									{
										continue;
									}
								}
								else if (this.$$switch$7337$40885 == 3)
								{
									if (208259 - 393226 != -184967)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (165533 - 328019 == -162485)
									{
										continue;
									}
								}
								else if (this.$$switch$7337$40885 == 4)
								{
									if (241770 - 172847 == 68924)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (13462 - 434807 == -421344)
									{
										continue;
									}
								}
								else if (this.$$switch$7337$40885 == 5)
								{
									if (126303 - 315922 == -189618)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (28013 - 164962 == -136948)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (85031 - 230109 != -145078)
									{
										continue;
									}
								}
								this.$mGameGui$40886 = (GameGui)this.$self_$40887.GetComponent(typeof(GameGui));
								if (112292 - 257515 != -145222)
								{
									if (this.$mGameGui$40886)
									{
										if (161695 - 151779 == 9917)
										{
											continue;
										}
										this.$mGameGui$40886.close();
										if (188189 - 598069 != -409880)
										{
											continue;
										}
									}
									this.$self_$40887.SendMessage("fadeOut");
									if (275063 - 598806 == -323743)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x06008DE5 RID: 36325 RVA: 0x01142E14 File Offset: 0x01141014
			internal static bool TOo8slV3nGve1YUJ3GC0()
			{
				return true;
			}

			// Token: 0x06008DE6 RID: 36326 RVA: 0x01142E18 File Offset: 0x01141018
			internal static bool L86WnSV363EmW4t2bdXm()
			{
				return false;
			}

			// Token: 0x04008712 RID: 34578
			internal int $$switch$7337$40885;

			// Token: 0x04008713 RID: 34579
			internal GameGui $mGameGui$40886;

			// Token: 0x04008714 RID: 34580
			internal M805_LightVaultCleaning $self_$40887;
		}
	}
}
