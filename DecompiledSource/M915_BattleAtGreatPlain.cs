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

// Token: 0x0200194D RID: 6477
[Serializable]
public class M915_BattleAtGreatPlain : MonoBehaviour
{
	// Token: 0x060096C2 RID: 38594 RVA: 0x011CCF04 File Offset: 0x011CB104
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M915_BattleAtGreatPlain()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060096C3 RID: 38595 RVA: 0x011CCF14 File Offset: 0x011CB114
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (120881 - 366763 != -245882)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (91584 - 71707 != 19878)
			{
				Game.mGameType = 5;
				if (25122 - 255795 != -230672)
				{
					if (Chat.Initialized)
					{
						if (48293 - 444606 == -396313)
						{
							Chat.ChatDisplay.Clear();
							if (150751 - 18543 == 132208)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (181603 - 136953 != 44651)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060096C4 RID: 38596 RVA: 0x011CCFF8 File Offset: 0x011CB1F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (109048 - 527940 != -418892)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (112609 - 181902 != -69292)
				{
					if (Game.mNextGameCode != 915)
					{
						break;
					}
					if (83344 - 542723 == -459379)
					{
						Game.nextGame();
						if (299136 - 183331 != 115806)
						{
							Game.mGameCode = 915;
							if (140071 - 345067 == -204996)
							{
								Game.mGameType = 5;
								if (54722 - 225424 != -170701)
								{
									Game.mGameTime = Time.time;
									if (59006 - 335372 != -276365)
									{
										Game.mGameScore = 0;
										if (175741 - 275106 == -99365)
										{
											Game.mGameMana = 0;
											if (210755 - 370162 != -159406)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (126065 - 64413 == 61652)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (212197 - 160406 == 51791)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (4687 - 95370 == -90683)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (12005 - 34486 == -22481)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (105929 - 386998 == -281069)
																{
																	this.fTsnnwT7Ve1 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (253891 - 391151 != -137259)
																	{
																		this.fTsnnwT7Ve1.enabled = false;
																		if (212354 - 202166 == 10188)
																		{
																			this.UhennLVIimK = PhotonClient.Connection;
																			if (251911 - 487132 == -235221)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (177949 - 580395 == -402446)
																				{
																					this.InitGame();
																					if (231581 - 374951 == -143370)
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
			else
			{
				Debug.Log("Not Connected");
				if (118759 - 181843 != -63083)
				{
					Game.mGameType = 99;
					if (261603 - 812 != 260792)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060096C5 RID: 38597 RVA: 0x011CD324 File Offset: 0x011CB524
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (175599 - 20826 != 154774)
		{
		}
		for (;;)
		{
			if (this.UhennLVIimK == null)
			{
				if (109510 - 27753 == 81757)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (249313 - 38197 != 211117)
				{
					if (mGameState == eGameState.Init)
					{
						if (213072 - 361813 == -148741)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (42895 - 7022 == 35873)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (117343 - 349167 != -231823)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (54036 - 214088 != -160051)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (91267 - 317376 != -226108)
						{
							if (Game.music != 0)
							{
								if (102495 - 55643 == 46853)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (197109 - 181323 != 15786)
									{
										continue;
									}
									this.audio.Play();
									if (241863 - 593362 != -351499)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (264367 - 112574 != 151794)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
									if (6543 - 211993 == -205450)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (147948 - 502495 != -354546)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (253410 - 208888 != 44523)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (139521 - 218934 == -79413)
							{
								if (Time.time > this.JMxnnUMR5hK)
								{
									if (140749 - 282822 == -142072)
									{
										continue;
									}
									Game.mGameMana++;
									if (8300 - 392565 == -384264)
									{
										continue;
									}
									this.JMxnnUMR5hK = Time.time + (float)12;
									if (277564 - 152693 != 124871)
									{
										continue;
									}
								}
								this.GameEventUpdate();
								if (197016 - 344860 != -147843)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (217440 - 539413 == -321973)
						{
							this.GameEventUpdate();
							if (276642 - 115682 != 160961)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (292946 - 374073 == -81127)
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
						if (184177 - 441443 != -257265)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060096C6 RID: 38598 RVA: 0x011CD70C File Offset: 0x011CB90C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameEventUpdate()
	{
		if (148417 - 201619 != -53201)
		{
		}
		while (Time.time > this.EiAnn08jIty)
		{
			if (242891 - 308481 != -65589)
			{
				if (this.WRqnnEytaTh >= 12)
				{
					break;
				}
				if (111660 - 420737 == -309077)
				{
					this.EiAnn08jIty = Time.time + (float)6;
					if (261606 - 463513 == -201907)
					{
						if (this.YEZnnSVANw4 - this.G3QnnBnx7gI >= 6)
						{
							break;
						}
						if (240718 - 575354 != -334635)
						{
							Game.sendMissionEvent(9152, this.WRqnnEytaTh + 1);
							if (84720 - 477427 != -392706)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060096C7 RID: 38599 RVA: 0x011CD818 File Offset: 0x011CBA18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (215405 - 216268 != -862)
		{
		}
		for (;;)
		{
			if (!this.nO9nnNQW3JG)
			{
				if (174770 - 381566 == -206796)
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
				if (173556 - 59722 == 113834)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (4584 - 207327 == -202743)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (37481 - 204271 == -166790)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (208594 - 271785 == -63191)
							{
								GUI.depth = 1;
								if (91397 - 596898 != -505500)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (224104 - 5119 != 218986)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (106824 - 16142 == 90682)
										{
											Color color = GUI.color;
											if (182181 - 307909 != -125727)
											{
												color.a = a;
												if (159593 - 382904 == -223311)
												{
													if (269271 - 43207 == 226064)
													{
														GUI.color = color;
														if (60885 - 561566 != -500680)
														{
															if (186430 - 20707 == 165723)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.nO9nnNQW3JG);
																if (229826 - 547691 != -317864)
																{
																	float a2 = 1f;
																	if (103399 - 259002 != -155602)
																	{
																		Color color2 = GUI.color;
																		if (158855 - 148772 == 10083)
																		{
																			color2.a = a2;
																			if (289255 - 12618 != 276638)
																			{
																				if (80085 - 54434 == 25651)
																				{
																					GUI.color = color2;
																					if (184867 - 261862 != -76994)
																					{
																						if (22172 - 317808 == -295636)
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

	// Token: 0x060096C8 RID: 38600 RVA: 0x011CDB98 File Offset: 0x011CBD98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (225885 - 193844 != 32042)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (147179 - 428030 != -280850)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (61004 - 577399 != -516394)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (263738 - 377949 != -114210)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (196528 - 117965 == 78563)
						{
							int num4 = num;
							if (243461 - 475581 == -232120)
							{
								if (num4 == 9151)
								{
									if (90341 - 310823 != -220481)
									{
										break;
									}
								}
								else if (num4 == 9152)
								{
									if (106264 - 407436 != -301171)
									{
										break;
									}
								}
								else if (num4 == -9152)
								{
									if (267642 - 494712 == -227070)
									{
										if (this.WRqnnEytaTh >= num2)
										{
											break;
										}
										if (16456 - 563479 == -547023)
										{
											this.WRqnnEytaTh = num2;
											if (279781 - 427559 == -147778)
											{
												int wrqnnEytaTh = this.WRqnnEytaTh;
												if (126420 - 292021 != -165600)
												{
													if (wrqnnEytaTh == 1)
													{
														if (159348 - 537862 == -378514)
														{
															this.EiAnn08jIty = Time.time + (float)60;
															if (213176 - 525717 != -312540)
															{
																if (num3 != PlayerData.UID)
																{
																	break;
																}
																if (106585 - 390864 == -284279)
																{
																	this.spawnActor("CutBot", 9, 1);
																	if (101144 - 405884 != -304739)
																	{
																		this.spawnActor("CutBot", 9, 2);
																		if (223621 - 344919 != -121297)
																		{
																			this.spawnActor("CutBot", 9, 3);
																			if (266338 - 477008 != -210669)
																			{
																				this.spawnActor("CutBot", 9, 4);
																				if (132455 - 375300 != -242844)
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
													else if (wrqnnEytaTh == 2)
													{
														if (177840 - 515686 != -337845)
														{
															this.EiAnn08jIty = Time.time + (float)60;
															if (274772 - 268558 != 6215)
															{
																if (num3 != PlayerData.UID)
																{
																	break;
																}
																if (119359 - 169255 == -49896)
																{
																	this.spawnActor("CutBot", 9, 1);
																	if (191055 - 44912 == 146143)
																	{
																		this.spawnActor("CutBot", 9, 2);
																		if (187569 - 167550 == 20019)
																		{
																			this.spawnActor("CutBot", 9, 3);
																			if (55410 - 578139 != -522728)
																			{
																				this.spawnActor("CutBot", 9, 4);
																				if (169611 - 589562 != -419950)
																				{
																					this.spawnActor("CarryBot", 9, 5);
																					if (182206 - 551281 != -369074)
																					{
																						this.spawnActor("CarryBot", 9, 6);
																						if (151584 - 468743 != -317158)
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
													else if (wrqnnEytaTh == 3)
													{
														if (98130 - 4956 == 93174)
														{
															this.EiAnn08jIty = Time.time + (float)60;
															if (14200 - 431961 != -417760)
															{
																if (num3 != PlayerData.UID)
																{
																	break;
																}
																if (188522 - 219773 != -31250)
																{
																	this.spawnActor("CutBot", 9, 1);
																	if (105660 - 3343 == 102317)
																	{
																		this.spawnActor("FireBot", 9, 2);
																		if (223606 - 399453 != -175846)
																		{
																			this.spawnActor("FireBot", 9, 3);
																			if (136001 - 417045 == -281044)
																			{
																				this.spawnActor("CutBot", 9, 4);
																				if (66171 - 80213 != -14041)
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
													else if (wrqnnEytaTh == 4)
													{
														if (237355 - 172847 != 64509)
														{
															this.EiAnn08jIty = Time.time + (float)60;
															if (174602 - 15415 == 159187)
															{
																if (num3 != PlayerData.UID)
																{
																	break;
																}
																if (62786 - 196888 == -134102)
																{
																	this.spawnActor("CutBot", 9, 1);
																	if (163558 - 78432 == 85126)
																	{
																		this.spawnActor("CutBot", 9, 2);
																		if (128841 - 280070 != -151228)
																		{
																			this.spawnActor("CutBot", 9, 3);
																			if (122043 - 326474 == -204431)
																			{
																				this.spawnActor("CutBot", 9, 4);
																				if (145277 - 122974 != 22304)
																				{
																					this.spawnActor("CutBot", 9, 5);
																					if (247244 - 249012 == -1768)
																					{
																						this.spawnActor("CutBot", 9, 6);
																						if (259475 - 497287 == -237812)
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
													else if (wrqnnEytaTh == 6)
													{
														if (92117 - 469797 != -377679)
														{
															this.EiAnn08jIty = Time.time + (float)60;
															if (129461 - 587883 != -458421)
															{
																if (num3 != PlayerData.UID)
																{
																	break;
																}
																if (116402 - 462319 == -345917)
																{
																	this.spawnActor("CarryBot", 9, 1);
																	if (75089 - 300640 == -225551)
																	{
																		this.spawnActor("CarryBot", 9, 2);
																		if (243920 - 30751 != 213170)
																		{
																			this.spawnActor("CarryBot", 9, 3);
																			if (83287 - 444596 == -361309)
																			{
																				this.spawnActor("CarryBot", 9, 4);
																				if (81466 - 351697 != -270230)
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
													else if (wrqnnEytaTh == 7)
													{
														if (97202 - 119236 == -22034)
														{
															this.EiAnn08jIty = Time.time + (float)60;
															if (247146 - 37647 == 209499)
															{
																if (num3 != PlayerData.UID)
																{
																	break;
																}
																if (286142 - 19494 == 266648)
																{
																	this.spawnActor("FireBot", 9, 1);
																	if (238441 - 207995 == 30446)
																	{
																		this.spawnActor("FireBot", 9, 2);
																		if (270267 - 556028 == -285761)
																		{
																			this.spawnActor("FireBot", 9, 3);
																			if (221658 - 216714 != 4945)
																			{
																				this.spawnActor("FireBot", 9, 4);
																				if (220659 - 108465 != 112195)
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
													else if (wrqnnEytaTh == 8)
													{
														if (264873 - 4545 == 260328)
														{
															this.EiAnn08jIty = Time.time + (float)45;
															if (76806 - 352525 != -275718)
															{
																if (num3 != PlayerData.UID)
																{
																	break;
																}
																if (93794 - 161387 != -67592)
																{
																	this.spawnActor("CutBot", 9, 1);
																	if (27039 - 22234 == 4805)
																	{
																		this.spawnActor("CutBot", 9, 2);
																		if (288492 - 278074 == 10418)
																		{
																			this.spawnActor("CutBot", 9, 3);
																			if (56406 - 426629 == -370223)
																			{
																				this.spawnActor("CutBot", 9, 4);
																				if (122921 - 172089 == -49168)
																				{
																					this.spawnActor("CutBot", 9, 5);
																					if (32240 - 203629 == -171389)
																					{
																						this.spawnActor("CutBot", 9, 6);
																						if (156198 - 319331 != -163132)
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
													else if (wrqnnEytaTh == 9)
													{
														if (150569 - 200406 == -49837)
														{
															this.EiAnn08jIty = Time.time + (float)60;
															if (102155 - 123148 != -20992)
															{
																if (num3 != PlayerData.UID)
																{
																	break;
																}
																if (165228 - 435336 != -270107)
																{
																	this.spawnActor("CarryBot", 9, 1);
																	if (162701 - 569882 == -407181)
																	{
																		this.spawnActor("CarryBot", 9, 2);
																		if (134736 - 183261 == -48525)
																		{
																			this.spawnActor("CarryBot", 9, 3);
																			if (249190 - 252839 == -3649)
																			{
																				this.spawnActor("CarryBot", 9, 4);
																				if (46314 - 502453 == -456139)
																				{
																					this.spawnActor("CutBot", 9, 5);
																					if (50338 - 77597 == -27259)
																					{
																						this.spawnActor("CutBot", 9, 6);
																						if (299154 - 262813 == 36341)
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
													else if (wrqnnEytaTh == 10)
													{
														if (232628 - 4767 == 227861)
														{
															this.EiAnn08jIty = Time.time + (float)60;
															if (107834 - 323028 != -215193)
															{
																if (num3 != PlayerData.UID)
																{
																	break;
																}
																if (21544 - 243915 == -222371)
																{
																	this.spawnActor("FireBot", 9, 1);
																	if (234006 - 454113 != -220106)
																	{
																		this.spawnActor("FireBot", 9, 2);
																		if (264733 - 218781 != 45953)
																		{
																			this.spawnActor("FireBot", 9, 3);
																			if (272816 - 129159 == 143657)
																			{
																				this.spawnActor("FireBot", 9, 4);
																				if (217200 - 143940 == 73260)
																				{
																					this.spawnActor("FireBot", 9, 5);
																					if (122306 - 40714 == 81592)
																					{
																						this.spawnActor("FireBot", 9, 6);
																						if (253314 - 155364 != 97951)
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
													else if (wrqnnEytaTh == 11)
													{
														if (281045 - 292210 == -11165)
														{
															this.EiAnn08jIty = Time.time + (float)15;
															if (6436 - 266020 != -259583)
															{
																if (num3 != PlayerData.UID)
																{
																	break;
																}
																if (404 - 575795 != -575390)
																{
																	this.spawnActor("CutBot", 9, 1);
																	if (186164 - 216617 == -30453)
																	{
																		this.spawnActor("CutBot", 9, 2);
																		if (109038 - 82994 == 26044)
																		{
																			this.spawnActor("CarryBot", 9, 3);
																			if (159659 - 325928 != -166268)
																			{
																				this.spawnActor("CarryBot", 9, 4);
																				if (84572 - 117066 == -32494)
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
														if (wrqnnEytaTh != 12)
														{
															break;
														}
														if (277450 - 593634 != -316183)
														{
															this.EiAnn08jIty = Time.time + (float)15;
															if (273294 - 26367 != 246928)
															{
																if (num3 != PlayerData.UID)
																{
																	break;
																}
																if (138925 - 107829 == 31096)
																{
																	this.spawnActor("CutBot", 9, 1);
																	if (232636 - 502399 == -269763)
																	{
																		this.spawnActor("CutBot", 9, 2);
																		if (298156 - 63871 == 234285)
																		{
																			this.spawnActor("CarryBot", 9, 3);
																			if (218630 - 104614 != 114017)
																			{
																				this.spawnActor("CarryBot", 9, 4);
																				if (43990 - 64982 != -20991)
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
								else if (num4 == 9153)
								{
									if (141882 - 43289 != 98594)
									{
										this.G3QnnBnx7gI++;
										if (289523 - 61829 == 227694)
										{
											this.SendMessage("newGameMessage", "Mission Objective: Robot destroyed:" + this.G3QnnBnx7gI + "/54");
											if (218435 - 130161 == 88274)
											{
												Chat.SubmitChat("none", "Robot destroyed:" + this.G3QnnBnx7gI + "/54", eChatType.system, eChatMode.system);
												if (170430 - 12761 != 157670)
												{
													if (this.G3QnnBnx7gI < 54)
													{
														break;
													}
													if (140244 - 373902 != -233657)
													{
														this.StartCoroutine_Auto(this.EndEvent());
														if (271864 - 576696 != -304831)
														{
															break;
														}
													}
												}
											}
										}
									}
								}
								else if (num4 == 9154)
								{
									if (183047 - 350591 != -167543)
									{
										this.ojdnnPx2kX7++;
										if (50465 - 106665 != -56199)
										{
											this.SendMessage("newGameMessage", "Warning: Soldier dead:" + this.ojdnnPx2kX7 + "/60");
											if (211004 - 66639 != 144366)
											{
												Chat.SubmitChat("none", "Soldier dead:" + this.ojdnnPx2kX7 + "/60", eChatType.system, eChatMode.system);
												if (254326 - 60593 != 193734)
												{
													int num5 = this.ojdnnPx2kX7;
													if (89657 - 377622 != -287964)
													{
														if (num5 != 8)
														{
															if (146758 - 78508 == 68251)
															{
																continue;
															}
															if (num5 != 12)
															{
																if (293359 - 208991 == 84369)
																{
																	continue;
																}
																if (num5 != 16)
																{
																	if (43384 - 274530 != -231146)
																	{
																		continue;
																	}
																	if (num5 != 20)
																	{
																		if (191310 - 401718 == -210407)
																		{
																			continue;
																		}
																		if (num5 != 24)
																		{
																			if (51758 - 329603 != -277845)
																			{
																				continue;
																			}
																			if (num5 != 28)
																			{
																				if (5300 - 299517 == -294216)
																				{
																					continue;
																				}
																				if (num5 != 32)
																				{
																					if (240689 - 542069 != -301380)
																					{
																						continue;
																					}
																					if (num5 != 36)
																					{
																						if (140129 - 376646 != -236517)
																						{
																							continue;
																						}
																						if (num5 != 40)
																						{
																							if (114485 - 319965 == -205479)
																							{
																								continue;
																							}
																							if (num5 != 44)
																							{
																								if (269887 - 20264 != 249623)
																								{
																									continue;
																								}
																								if (num5 != 48)
																								{
																									if (229021 - 169413 != 59608)
																									{
																										continue;
																									}
																									if (num5 != 52)
																									{
																										if (77554 - 573673 == -496118)
																										{
																											continue;
																										}
																										if (num5 == 56)
																										{
																											if (175435 - 392961 != -217526)
																											{
																												continue;
																											}
																										}
																										else
																										{
																											if (num5 != 60)
																											{
																												break;
																											}
																											if (98871 - 35276 == 63596)
																											{
																												continue;
																											}
																											Game.sendMissionEvent(9151, 2);
																											if (217573 - 65163 != 152410)
																											{
																												continue;
																											}
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
														if (num3 == PlayerData.UID)
														{
															if (114592 - 204566 == -89973)
															{
																continue;
															}
															this.spawnActor("Panther", 1, 7);
															if (244997 - 585655 != -340658)
															{
																continue;
															}
															this.spawnActor("Leopard", 1, 8);
															if (12695 - 206483 != -193788)
															{
																continue;
															}
															this.spawnActor("Leopard", 1, 9);
															if (242671 - 258153 != -15482)
															{
																continue;
															}
															this.spawnActor("Panther", 1, 10);
															if (82756 - 99514 != -16758)
															{
																continue;
															}
														}
														this.SendMessage("newGameMessage", "New reenforcement has arrived!");
														if (85690 - 586302 != -500611)
														{
															Chat.SubmitChat("none", "New reenforcement has arrived!", eChatType.system, eChatMode.system);
															if (30505 - 397022 != -366516)
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
									Debug.LogError("Warning unknown returnCode:" + num);
									if (187140 - 251411 != -64270)
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

	// Token: 0x060096C9 RID: 38601 RVA: 0x011CF090 File Offset: 0x011CD290
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M915_BattleAtGreatPlain.$StartEvent$42190(this).GetEnumerator();
	}

	// Token: 0x060096CA RID: 38602 RVA: 0x011CF0A0 File Offset: 0x011CD2A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndEvent()
	{
		return new M915_BattleAtGreatPlain.$EndEvent$42195(this).GetEnumerator();
	}

	// Token: 0x060096CB RID: 38603 RVA: 0x011CF0B0 File Offset: 0x011CD2B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (278193 - 405201 != -127008)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (125327 - 385292 != -259964)
			{
				Time.timeScale = 1f;
				if (102524 - 403251 != -300726)
				{
					this.nO9nnNQW3JG = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (38789 - 341789 != -302999)
					{
						Hashtable customOpParameters = new Hashtable();
						if (69971 - 501633 != -431661)
						{
							this.UhennLVIimK.OpCustom(52, customOpParameters, true);
							if (206874 - 92473 == 114401)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060096CC RID: 38604 RVA: 0x011CF1B4 File Offset: 0x011CD3B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (172708 - 115927 != 56781)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (34867 - 327183 == -292316)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (58896 - 94759 != -35862)
				{
					Game.mGameState = eGameState.Setup;
					if (170514 - 421623 != -251108)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060096CD RID: 38605 RVA: 0x011CF258 File Offset: 0x011CD458
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (90391 - 422441 != -332050)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (11050 - 202605 != -191554)
			{
				if (num == PlayerData.UID)
				{
					if (241961 - 397679 != -155717)
					{
						this.SetupActors();
						if (120194 - 232454 != -112259)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (256338 - 138366 == 117972)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060096CE RID: 38606 RVA: 0x011CF328 File Offset: 0x011CD528
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (785 - 508598 != -507813)
		{
		}
		for (;;)
		{
			IL_E9:
			Debug.Log("Creating Actors");
			if (295271 - 377262 != -81990)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (88769 - 20371 != 68399)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (165200 - 131541 != 33660)
						{
							int i = 0;
							if (10700 - 152534 == -141834)
							{
								CharacterControl[] array2 = array;
								if (229826 - 450500 == -220674)
								{
									int length = array2.Length;
									if (47295 - 72455 != -25159)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (44536 - 489726 == -445189)
												{
													goto IL_E9;
												}
												string type = array2[i].Type;
												if (4647 - 103554 != -98907)
												{
													goto IL_E9;
												}
												if (type == "Liger")
												{
													goto IL_6A;
												}
												if (190869 - 58171 == 132699)
												{
													goto IL_E9;
												}
												if (type == "Leopard")
												{
													goto IL_6A;
												}
												if (214769 - 48654 == 166116)
												{
													goto IL_E9;
												}
												if (type == "Panther")
												{
													if (125582 - 573267 != -447685)
													{
														goto IL_E9;
													}
													goto IL_6A;
												}
												IL_188:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (237562 - 577053 == -339490)
												{
													goto IL_E9;
												}
												this.yFSnn83ZRC2++;
												if (216144 - 414187 != -198042)
												{
													goto IL_28E;
												}
												goto IL_E9;
												IL_6A:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (98937 - 266582 != -167645)
												{
													goto IL_E9;
												}
												goto IL_188;
											}
											IL_28E:
											i++;
											if (247873 - 539999 != -292126)
											{
												goto IL_E9;
											}
										}
										if (193617 - 191116 == 2501)
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
						if (3251 - 235709 == -232458)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060096CF RID: 38607 RVA: 0x011CF618 File Offset: 0x011CD818
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (298276 - 278524 != 19752)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (293410 - 133712 != 159699)
			{
				int i = 0;
				if (107464 - 387338 == -279874)
				{
					CharacterControl[] array2 = array;
					if (272500 - 105301 == 167199)
					{
						int length = array2.Length;
						if (211174 - 57417 == 153757)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (258200 - 575440 == -317239)
								{
									goto IL_E0;
								}
								i++;
								if (53792 - 205516 == -151723)
								{
									goto IL_E0;
								}
							}
							if (191619 - 431105 == -239486)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060096D0 RID: 38608 RVA: 0x011CF748 File Offset: 0x011CD948
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (122928 - 411263 != -288334)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (111305 - 16882 != 94424)
			{
				Game.mGameState = eGameState.Ready;
				if (45512 - 375567 != -330054)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (217402 - 104136 != 113267 && 61239 - 409385 != -348145)
					{
						GameObject gameObject = null;
						if (233516 - 533131 == -299615)
						{
							if (playerSlot < 1)
							{
								goto IL_90;
							}
							if (260130 - 132915 == 127216)
							{
								continue;
							}
							if (playerSlot > 12)
							{
								goto IL_90;
							}
							if (144124 - 273547 == -129422)
							{
								continue;
							}
							GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
							if (459 - 358588 != -358129)
							{
								continue;
							}
							gameObject = GameObject.Find("StartCamera" + playerSlot);
							if (288284 - 497314 == -209029)
							{
								continue;
							}
							IL_101:
							if (gameObject2)
							{
								if (201452 - 177172 != 24280)
								{
									continue;
								}
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
								if (141971 - 342474 == -200502)
								{
									continue;
								}
								if (spawnPos != Vector3.zero)
								{
									if (144359 - 118525 == 25835)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
									if (156084 - 301849 == -145764)
									{
										continue;
									}
								}
								else
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (140243 - 282705 == -142461)
									{
										continue;
									}
								}
							}
							if (!gameObject)
							{
								break;
							}
							if (154186 - 339338 != -185152)
							{
								continue;
							}
							this.transform.position = gameObject.transform.position;
							if (272473 - 585031 == -312557)
							{
								continue;
							}
							this.transform.rotation = gameObject.transform.rotation;
							if (94227 - 411869 != -317641)
							{
								break;
							}
							continue;
							IL_90:
							gameObject2 = GameObject.Find("StartPoint1");
							if (96782 - 379327 == -282545)
							{
								goto IL_101;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060096D1 RID: 38609 RVA: 0x011CFA6C File Offset: 0x011CDC6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		Debug.Log("Start Game");
		this.StartCoroutine_Auto(this.StartEvent());
	}

	// Token: 0x060096D2 RID: 38610 RVA: 0x011CFA88 File Offset: 0x011CDC88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060096D3 RID: 38611 RVA: 0x011CFA8C File Offset: 0x011CDC8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (100931 - 123497 != -22566)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (290981 - 394234 == -103253)
			{
				if (gameObject)
				{
					if (49820 - 443973 != -394152)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (145903 - 176864 == -30961)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (221501 - 471472 == -249971)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060096D4 RID: 38612 RVA: 0x011CFB88 File Offset: 0x011CDD88
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (278586 - 132070 != 146517)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (83137 - 287226 == -204089)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (44628 - 556913 == -512285)
				{
					hashtable.Add(43, PlayerData.UID);
					if (90942 - 456195 == -365253)
					{
						hashtable.Add(73, nType);
						if (42943 - 445131 == -402188)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (126773 - 229410 != -102636)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (274519 - 576878 == -302359)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (184350 - 283579 == -99229)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (134217 - 261431 == -127214)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (239058 - 590482 == -351424)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (174292 - 389894 == -215602)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (216234 - 587388 == -371154)
													{
														this.UhennLVIimK.OpCustom(63, hashtable, true);
														if (176420 - 18005 == 158415)
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

	// Token: 0x060096D5 RID: 38613 RVA: 0x011CFE6C File Offset: 0x011CE06C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (236042 - 185582 != 50460)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (296653 - 198036 == 98617)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (116606 - 429428 != -312821)
				{
					object lhs = data[73];
					if (198744 - 479428 != -280683)
					{
						if (RuntimeServices.EqualityOperator(lhs, "Liger"))
						{
							if (36171 - 273611 != -237440)
							{
								continue;
							}
							gameObject.name = "Boldas";
							if (244563 - 79312 != 165251)
							{
								continue;
							}
						}
						else
						{
							if (!RuntimeServices.EqualityOperator(lhs, "CutBot"))
							{
								if (240086 - 338740 != -98654)
								{
									continue;
								}
								if (!RuntimeServices.EqualityOperator(lhs, "CarryBot"))
								{
									if (234771 - 584946 == -350174)
									{
										continue;
									}
									if (!RuntimeServices.EqualityOperator(lhs, "FireBot"))
									{
										goto IL_1DF;
									}
									if (262639 - 366017 == -103377)
									{
										continue;
									}
								}
							}
							this.YEZnnSVANw4++;
							if (216868 - 398698 != -181830)
							{
								continue;
							}
							Debug.Log("RobotSpawn:" + this.YEZnnSVANw4);
							if (195343 - 234186 == -38842)
							{
								continue;
							}
						}
						IL_1DF:
						if (Game.mGameState == eGameState.Setup)
						{
							if (258049 - 563279 != -305229)
							{
								if (this.yFSnn83ZRC2 <= 0)
								{
									break;
								}
								if (176842 - 500319 == -323477)
								{
									this.yFSnn83ZRC2--;
									if (290190 - 221139 == 69051)
									{
										if (this.yFSnn83ZRC2 != 0)
										{
											break;
										}
										if (241482 - 117077 != 124406)
										{
											Game.setGameState(eGameState.Ready);
											if (129441 - 86136 == 43305)
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
							if (29075 - 489464 == -460389)
							{
								gameObject.SendMessage("createSpecialEffect", 1);
								if (97904 - 130045 == -32141)
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

	// Token: 0x060096D6 RID: 38614 RVA: 0x011D0158 File Offset: 0x011CE358
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x060096D7 RID: 38615 RVA: 0x011D016C File Offset: 0x011CE36C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (120292 - 116711 != 3581)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (22913 - 165156 == -142243)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (170328 - 558036 != -387707)
				{
					if (!characterControl)
					{
						break;
					}
					if (243304 - 357815 != -114510)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (274086 - 487535 == -213449)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (143446 - 325422 != -181975)
							{
								string type = characterControl.Type;
								if (126981 - 200570 != -73588)
								{
									if (type == "CutBot")
									{
										if (261190 - 247370 != 13821)
										{
											Game.sendMissionEvent(9153, 1);
											if (221355 - 253947 == -32592)
											{
												break;
											}
										}
									}
									else if (type == "CarryBot")
									{
										if (271166 - 160131 != 111036)
										{
											Game.sendMissionEvent(9153, 2);
											if (149566 - 418417 == -268851)
											{
												break;
											}
										}
									}
									else if (type == "FireBot")
									{
										if (26422 - 230337 != -203914)
										{
											Game.sendMissionEvent(9153, 3);
											if (10169 - 295369 == -285200)
											{
												break;
											}
										}
									}
									else if (type == "Panther")
									{
										if (503 - 238378 != -237874)
										{
											Game.sendMissionEvent(9154, 1);
											if (214030 - 466051 != -252020)
											{
												break;
											}
										}
									}
									else if (type == "Leopard")
									{
										if (228257 - 244526 != -16268)
										{
											Game.sendMissionEvent(9154, 2);
											if (57255 - 485448 != -428192)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "Liger"))
										{
											break;
										}
										if (181442 - 279081 != -97638)
										{
											Game.sendMissionEvent(9151, 2);
											if (108381 - 227542 != -119160)
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

	// Token: 0x060096D8 RID: 38616 RVA: 0x011D0488 File Offset: 0x011CE688
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (98253 - 353973 != -255719)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (75777 - 403781 == -328004)
			{
				hashtable.Add(71, CID);
				if (109329 - 193477 != -84147)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (196027 - 375026 == -178999)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (294869 - 250524 == 44345)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (125830 - 249762 == -123932)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (240534 - 390156 != -149621)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (166781 - 186285 != -19503)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (229878 - 511089 != -281210)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (60915 - 435966 != -375050)
											{
												this.UhennLVIimK.OpCustom(61, hashtable, true);
												if (263092 - 27138 == 235954)
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

	// Token: 0x060096D9 RID: 38617 RVA: 0x011D0714 File Offset: 0x011CE914
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (144669 - 298117 != -153448)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (158754 - 228601 != -69846)
			{
				if (!gameObject)
				{
					break;
				}
				if (108967 - 59028 == 49939)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (128452 - 493962 != -365509)
					{
						playerCameraControl.target = gameObject;
						if (9411 - 307420 == -298009)
						{
							this.StartGame();
							if (304 - 172587 != -172282)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060096DA RID: 38618 RVA: 0x011D0804 File Offset: 0x011CEA04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (275216 - 482288 != -207072)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (6771 - 145663 == -138892)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (6965 - 134286 == -127321)
				{
					gameGui.ResetTeamBar();
					if (150528 - 20914 != 129615)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060096DB RID: 38619 RVA: 0x011D08B0 File Offset: 0x011CEAB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M915_BattleAtGreatPlain.$onDeadPlayer$42213(this).GetEnumerator();
	}

	// Token: 0x060096DC RID: 38620 RVA: 0x011D08C0 File Offset: 0x011CEAC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (223336 - 525243 != -301907)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (280483 - 574903 == -294420)
			{
				this.fTsnnwT7Ve1.target = Game.mPlayer;
				if (240213 - 540064 == -299851)
				{
					this.fTsnnwT7Ve1.enabled = true;
					if (171270 - 313902 != -142631)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (230105 - 232765 == -2659)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (266974 - 594608 != -327634)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (276049 - 310012 != -33962)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (233074 - 196648 == 36426)
							{
								if (!gameGui)
								{
									break;
								}
								if (66190 - 527340 == -461150)
								{
									gameGui.enabled = true;
									if (107388 - 445797 == -338409)
									{
										gameGui.closeDeadMenu();
										if (181510 - 513450 == -331940)
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

	// Token: 0x060096DD RID: 38621 RVA: 0x011D0A6C File Offset: 0x011CEC6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (175160 - 590261 != -415100)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (228924 - 348901 != -119976)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (265387 - 545784 == -280397)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (129311 - 138932 == -9621)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060096DE RID: 38622 RVA: 0x011D0B30 File Offset: 0x011CED30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x060096DF RID: 38623 RVA: 0x011D0B5C File Offset: 0x011CED5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (256696 - 338627 != -81930)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (183526 - 92014 == 91512)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (20803 - 253356 != -232552)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (199875 - 445931 != -246055)
					{
						Hashtable hashtable = new Hashtable();
						if (103463 - 335993 != -232529)
						{
							hashtable.Add(43, PlayerData.UID);
							if (6209 - 45925 != -39715)
							{
								hashtable.Add(71, nCID);
								if (91765 - 94129 != -2363)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (252846 - 550139 == -297293)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (179326 - 202399 == -23073)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (136201 - 521351 != -385149)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (151405 - 131567 != 19839)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (163227 - 342613 != -179385)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (114795 - 389688 == -274893)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (107926 - 353565 != -245638)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (112950 - 588456 != -475505)
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

	// Token: 0x060096E0 RID: 38624 RVA: 0x011D0E7C File Offset: 0x011CF07C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M915_BattleAtGreatPlain.$onChangePlayer$42219(data, this).GetEnumerator();
	}

	// Token: 0x060096E1 RID: 38625 RVA: 0x011D0E8C File Offset: 0x011CF08C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M915_BattleAtGreatPlain.$onGameComplete$42226(data, this).GetEnumerator();
	}

	// Token: 0x060096E2 RID: 38626 RVA: 0x011D0E9C File Offset: 0x011CF09C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M915_BattleAtGreatPlain.$ReturnToTown$42236(this).GetEnumerator();
	}

	// Token: 0x060096E3 RID: 38627 RVA: 0x011D0EAC File Offset: 0x011CF0AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M915_BattleAtGreatPlain.$ReturnToGuild$42241(this).GetEnumerator();
	}

	// Token: 0x060096E4 RID: 38628 RVA: 0x011D0EBC File Offset: 0x011CF0BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M915_BattleAtGreatPlain.$ReturnToCamp$42245(this).GetEnumerator();
	}

	// Token: 0x060096E5 RID: 38629 RVA: 0x011D0ECC File Offset: 0x011CF0CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (86405 - 263652 != -177247)
		{
		}
		for (;;)
		{
			Debug.Log("Leaving Guild");
			if (161686 - 67791 != 93896)
			{
				Hashtable hashtable = new Hashtable();
				if (188867 - 559412 == -370545)
				{
					hashtable.Add(43, PlayerData.UID);
					if (157866 - 271411 == -113545)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (171119 - 393645 == -222526)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060096E6 RID: 38630 RVA: 0x011D0FA4 File Offset: 0x011CF1A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x060096E7 RID: 38631 RVA: 0x011D0FB8 File Offset: 0x011CF1B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (216384 - 323620 != -107236)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (86025 - 523726 == -437701)
			{
				Hashtable hashtable = new Hashtable();
				if (156447 - 321961 == -165514)
				{
					if (Game.mNextGameCode == 30)
					{
						if (297969 - 282929 != 15040)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (146528 - 377859 == -231330)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (112382 - 258537 == -146154)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (14944 - 228419 == -213474)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (286227 - 591359 == -305131)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (175492 - 364278 == -188785)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (80916 - 503205 != -422289)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (133107 - 203010 == -69902)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (274538 - 124820 == 149719)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (156201 - 151804 != 4397)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (199591 - 284565 == -84973)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (70526 - 61794 == 8733)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (208765 - 589302 == -380536)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (215417 - 112431 == 102987)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (148116 - 221625 != -73509)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (47411 - 276176 != -228765)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (74032 - 441938 == -367905)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (159781 - 494793 == -335011)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (11876 - 165850 == -153973)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (138450 - 259513 == -121062)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (290422 - 393375 == -102952)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (271422 - 335218 == -63795)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (226891 - 486006 != -259115)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (233732 - 558378 == -324645)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (161975 - 489615 != -327640)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (246195 - 357131 != -110936)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (202197 - 479625 == -277427)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (298358 - 16439 == 281920)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (80269 - 262550 == -182281)
					{
						this.UhennLVIimK.OpCustom(42, hashtable, true);
						if (215268 - 24959 != 190310)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060096E8 RID: 38632 RVA: 0x011D156C File Offset: 0x011CF76C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x060096E9 RID: 38633 RVA: 0x011D157C File Offset: 0x011CF77C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060096EA RID: 38634 RVA: 0x011D1580 File Offset: 0x011CF780
	internal static bool a5NW1ZVEsEJFNl9tMgQ8()
	{
		return true;
	}

	// Token: 0x060096EB RID: 38635 RVA: 0x011D1584 File Offset: 0x011CF784
	internal static bool fJBOjJVE9i8uhmw06qRR()
	{
		return false;
	}

	// Token: 0x04008C46 RID: 35910
	private LitePeer UhennLVIimK;

	// Token: 0x04008C47 RID: 35911
	private PlayerCameraControl fTsnnwT7Ve1;

	// Token: 0x04008C48 RID: 35912
	private float JMxnnUMR5hK;

	// Token: 0x04008C49 RID: 35913
	private Texture nO9nnNQW3JG;

	// Token: 0x04008C4A RID: 35914
	private int WRqnnEytaTh;

	// Token: 0x04008C4B RID: 35915
	private int ojdnnPx2kX7;

	// Token: 0x04008C4C RID: 35916
	private int YEZnnSVANw4;

	// Token: 0x04008C4D RID: 35917
	private int G3QnnBnx7gI;

	// Token: 0x04008C4E RID: 35918
	private float EiAnn08jIty;

	// Token: 0x04008C4F RID: 35919
	public GameObject FakeFireGod;

	// Token: 0x04008C50 RID: 35920
	public GameObject FakeCutBot;

	// Token: 0x04008C51 RID: 35921
	public GameObject FakeCarrierBot;

	// Token: 0x04008C52 RID: 35922
	public GameObject RobotExplode;

	// Token: 0x04008C53 RID: 35923
	private int yFSnn83ZRC2;

	// Token: 0x0200194E RID: 6478
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$42190 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060096EC RID: 38636 RVA: 0x011D1588 File Offset: 0x011CF788
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$42190(M915_BattleAtGreatPlain self_)
		{
			if (239037 - 90897 != 148140)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (113871 - 284432 != -170560)
				{
					base..ctor();
					if (29691 - 88934 != -59242)
					{
						this.$self_$42194 = self_;
						if (260052 - 277298 == -17246)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060096ED RID: 38637 RVA: 0x011D1620 File Offset: 0x011CF820
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M915_BattleAtGreatPlain.$StartEvent$42190.$(this.$self_$42194);
		}

		// Token: 0x060096EE RID: 38638 RVA: 0x011D1630 File Offset: 0x011CF830
		internal static bool DSvAE5VE1abPUmfr56nN()
		{
			return true;
		}

		// Token: 0x060096EF RID: 38639 RVA: 0x011D1634 File Offset: 0x011CF834
		internal static bool e3ZemaVE4VI6aXgxoR13()
		{
			return false;
		}

		// Token: 0x04008C54 RID: 35924
		internal M915_BattleAtGreatPlain $self_$42194;

		// Token: 0x0200194F RID: 6479
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060096F0 RID: 38640 RVA: 0x011D1638 File Offset: 0x011CF838
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M915_BattleAtGreatPlain self_)
			{
				if (201750 - 433519 != -231769)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (277560 - 19653 == 257907)
					{
						base..ctor();
						if (128983 - 178642 != -49658)
						{
							this.$self_$42193 = self_;
							if (222605 - 200823 != 21783)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060096F1 RID: 38641 RVA: 0x011D16D0 File Offset: 0x011CF8D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (220968 - 128492 != 92476)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_682;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (270982 - 249171 != 21811)
							{
								continue;
							}
							goto IL_50E;
						}
						else
						{
							this.$mStoryGui$42191 = (StoryGui)this.$self_$42193.GetComponent(typeof(StoryGui));
							if (58233 - 146573 == -88339)
							{
								continue;
							}
							if (!this.$mStoryGui$42191)
							{
								goto IL_28C;
							}
							if (159408 - 113982 != 45426)
							{
								continue;
							}
							this.$mStoryGui$42191.startStoryMessage("Liger", "Boldas", eTalkType.friend);
							if (24097 - 392037 != -367939)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (76050 - 499326 != -423276)
							{
								continue;
							}
							goto IL_40B;
						}
						else
						{
							this.$mStoryGui$42191.newStoryMessage("Liger", "Boldas", Language.getMessage("M915_BattleAtGreatPlain", 101), eTalkType.friend);
							if (154034 - 559650 != -405615)
							{
								goto Block_29;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (101798 - 221573 != -119774)
							{
								goto Block_9;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42191.newStoryMessage("Liger", "Boldas", Language.getMessage("M915_BattleAtGreatPlain", 102), eTalkType.friend);
							if (166075 - 100281 != 65794)
							{
								continue;
							}
							this.$self_$42193.fTsnnwT7Ve1.StartCoroutine_Auto(this.$self_$42193.fTsnnwT7Ve1.slerpToObject("EventCamera2", (float)3));
							if (67988 - 25573 != 42416)
							{
								goto Block_20;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (230050 - 519282 != -289231)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42191.newStoryMessage("Liger", "Boldas", Language.getMessage("M915_BattleAtGreatPlain", 103), eTalkType.friend);
							if (214195 - 24651 != 189544)
							{
								continue;
							}
							goto IL_149;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (31276 - 339592 != -308316)
							{
								continue;
							}
							goto IL_38E;
						}
						else
						{
							this.$mStoryGui$42191.newStoryMessage("Liger", "Boldas", Language.getMessage("M915_BattleAtGreatPlain", 104), eTalkType.friend);
							if (36707 - 301150 != -264443)
							{
								continue;
							}
							goto IL_184;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (222780 - 128065 != 94716)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42191.newStoryMessage("Liger", "Boldas", Language.getMessage("M915_BattleAtGreatPlain", 105), eTalkType.friend);
							if (276435 - 330520 != -54084)
							{
								goto Block_32;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (242187 - 13585 != 228602)
							{
								continue;
							}
							goto IL_44D;
						}
						else
						{
							this.$mStoryGui$42191.close();
							if (72441 - 392810 != -320369)
							{
								continue;
							}
							goto IL_A8;
						}
						break;
					case 9:
						if (Game.mGameState == eGameState.Start)
						{
							goto IL_28C;
						}
						if (55776 - 346976 != -291200)
						{
							continue;
						}
						goto IL_287;
					case 10:
						if (Game.mGameState != eGameState.Start)
						{
							if (44170 - 521874 != -477703)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							this.$mGameGui$42192 = (GameGui)this.$self_$42193.GetComponent(typeof(GameGui));
							if (38483 - 328578 != -290095)
							{
								continue;
							}
							this.$mGameGui$42192.enabled = true;
							if (167580 - 59187 != 108394)
							{
								goto Block_34;
							}
							continue;
						}
						break;
					case 11:
						Game.mGameState = eGameState.Normal;
						if (212961 - 135214 == 77748)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (194061 - 451719 == -257657)
						{
							continue;
						}
						this.YieldDefault(1);
						if (296710 - 343459 != -46748)
						{
							goto Block_40;
						}
						continue;
					default:
						if (294206 - 144129 == 150078)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Start;
					if (213133 - 144521 != 68612)
					{
						continue;
					}
					Game.mGameTime = Time.time;
					if (146211 - 127490 != 18721)
					{
						continue;
					}
					this.$self_$42193.fTsnnwT7Ve1.alignToObject("EventCamera1");
					if (86101 - 55540 == 30562)
					{
						continue;
					}
					this.$self_$42193.SendMessage("fadeIn");
					if (241003 - 182030 != 58974)
					{
						goto Block_10;
					}
					continue;
					IL_28C:
					this.$self_$42193.fTsnnwT7Ve1.enabled = true;
					if (136165 - 371128 == -234963)
					{
						goto IL_5AE;
					}
				}
				IL_A8:
				return this.Yield(9, new WaitForSeconds(0.5f));
				Block_9:
				goto IL_682;
				Block_10:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_149:
				return this.Yield(6, new WaitForSeconds(3.5f));
				IL_184:
				return this.Yield(7, new WaitForSeconds(3.5f));
				Block_14:
				IL_287:
				goto IL_682;
				Block_20:
				return this.Yield(5, new WaitForSeconds(3.5f));
				Block_22:
				goto IL_682;
				Block_23:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_38E:
				IL_40B:
				goto IL_682;
				Block_29:
				return this.Yield(4, new WaitForSeconds(3.5f));
				IL_44D:
				goto IL_682;
				Block_32:
				return this.Yield(8, new WaitForSeconds(3.5f));
				IL_50E:
				goto IL_682;
				Block_34:
				return this.Yield(11, new WaitForSeconds(0.5f));
				IL_5AE:
				return this.Yield(10, new WaitForSeconds(0.5f));
				Block_38:
				Block_40:
				IL_682:
				return false;
			}

			// Token: 0x060096F2 RID: 38642 RVA: 0x011D1D74 File Offset: 0x011CFF74
			internal static bool I1a3eMVEzR0XFxlTWlDS()
			{
				return true;
			}

			// Token: 0x060096F3 RID: 38643 RVA: 0x011D1D78 File Offset: 0x011CFF78
			internal static bool jvh3OIV2a829qCTt6BoV()
			{
				return false;
			}

			// Token: 0x04008C55 RID: 35925
			internal StoryGui $mStoryGui$42191;

			// Token: 0x04008C56 RID: 35926
			internal GameGui $mGameGui$42192;

			// Token: 0x04008C57 RID: 35927
			internal M915_BattleAtGreatPlain $self_$42193;
		}
	}

	// Token: 0x02001950 RID: 6480
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$42195 : GenericGenerator<YieldInstruction>
	{
		// Token: 0x060096F4 RID: 38644 RVA: 0x011D1D7C File Offset: 0x011CFF7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$42195(M915_BattleAtGreatPlain self_)
		{
			if (184600 - 351493 != -166893)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (63852 - 370324 != -306471)
				{
					base..ctor();
					if (182564 - 173985 == 8579)
					{
						this.$self_$42212 = self_;
						if (62003 - 526306 == -464303)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060096F5 RID: 38645 RVA: 0x011D1E14 File Offset: 0x011D0014
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return new M915_BattleAtGreatPlain.$EndEvent$42195.$(this.$self_$42212);
		}

		// Token: 0x060096F6 RID: 38646 RVA: 0x011D1E24 File Offset: 0x011D0024
		internal static bool pM6FARV2519wb77JRiBb()
		{
			return true;
		}

		// Token: 0x060096F7 RID: 38647 RVA: 0x011D1E28 File Offset: 0x011D0028
		internal static bool eJjgI0V2pPVfD5ls4MGR()
		{
			return false;
		}

		// Token: 0x04008C58 RID: 35928
		internal M915_BattleAtGreatPlain $self_$42212;

		// Token: 0x02001951 RID: 6481
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			// Token: 0x060096F8 RID: 38648 RVA: 0x011D1E2C File Offset: 0x011D002C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M915_BattleAtGreatPlain self_)
			{
				if (165061 - 270454 != -105393)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (229041 - 370401 == -141360)
					{
						base..ctor();
						if (12027 - 221340 == -209313)
						{
							this.$self_$42211 = self_;
							if (288441 - 540171 == -251730)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060096F9 RID: 38649 RVA: 0x011D1EC4 File Offset: 0x011D00C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (150262 - 503847 != -353584)
				{
				}
				for (;;)
				{
					IL_1338:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_156F;
					case 2:
						this.$self_$42211.fTsnnwT7Ve1.enabled = false;
						if (197890 - 552423 != -354533)
						{
							continue;
						}
						this.$mGameGui$42196.close();
						if (173077 - 498823 != -325746)
						{
							continue;
						}
						goto IL_1092;
					case 3:
						this.$self_$42211.SendMessage("fadeOut");
						if (101632 - 184238 != -82606)
						{
							continue;
						}
						goto IL_850;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (282970 - 245499 != 37472)
							{
								goto Block_57;
							}
							continue;
						}
						else
						{
							this.$mObjectList$42198 = GameObject.FindGameObjectsWithTag("Enemy");
							if (287329 - 439305 != -151976)
							{
								continue;
							}
							this.$$12896$42208 = 0;
							if (107844 - 97164 == 10681)
							{
								continue;
							}
							this.$$12897$42209 = this.$mObjectList$42198;
							if (33356 - 278225 != -244869)
							{
								continue;
							}
							this.$$12898$42210 = this.$$12897$42209.Length;
							if (286952 - 220049 != 66903)
							{
								continue;
							}
							while (this.$$12896$42208 < this.$$12898$42210)
							{
								if (this.$$12897$42209[this.$$12896$42208].layer == 8)
								{
									if (266114 - 589346 != -323232)
									{
										goto IL_1338;
									}
									this.$nChar$42200 = (CharacterControl)this.$$12897$42209[this.$$12896$42208].GetComponent(typeof(CharacterControl));
									if (274519 - 386138 != -111619)
									{
										goto IL_1338;
									}
									if (!(this.$nChar$42200.Type == "Leopard"))
									{
										if (169205 - 280378 != -111173)
										{
											goto IL_1338;
										}
										if (!(this.$nChar$42200.Type == "Panther"))
										{
											goto IL_F40;
										}
										if (162001 - 331 != 161670)
										{
											goto IL_1338;
										}
									}
									UnityEngine.Object.Destroy(this.$$12897$42209[this.$$12896$42208]);
									if (221566 - 508297 == -286730)
									{
										goto IL_1338;
									}
								}
								IL_F40:
								this.$$12896$42208++;
								if (40975 - 39502 != 1473)
								{
									goto IL_1338;
								}
							}
							if (267375 - 299180 == -31804)
							{
								continue;
							}
							this.$mPlayer$42201 = Game.mPlayer;
							if (26698 - 439624 != -412926)
							{
								continue;
							}
							this.$mStartPoint$42202 = GameObject.Find("StartPoint" + Game.getPlayerSlot(PlayerData.UID));
							if (20512 - 161994 != -141482)
							{
								continue;
							}
							if (this.$mPlayer$42201)
							{
								if (150461 - 359978 == -209516)
								{
									continue;
								}
								if (this.$mStartPoint$42202)
								{
									if (160797 - 111698 == 49100)
									{
										continue;
									}
									this.$mPlayer$42201.transform.position = this.$mStartPoint$42202.transform.position;
									if (209780 - 334322 == -124541)
									{
										continue;
									}
									this.$mPlayer$42201.transform.rotation = this.$mStartPoint$42202.transform.rotation;
									if (52289 - 313193 != -260904)
									{
										continue;
									}
									this.$mPlayer$42201.SendMessage("PositionEvent");
									if (146937 - 390429 == -243491)
									{
										continue;
									}
								}
							}
							this.$mBoldas$42203 = GameObject.Find("Boldas");
							if (288842 - 370281 == -81438)
							{
								continue;
							}
							if (this.$mBoldas$42203)
							{
								if (218659 - 360832 != -142173)
								{
									continue;
								}
								this.$mBoldas$42203.transform.position = new Vector3(-1.6f, 49.8f, 85.5f);
								if (73957 - 117466 != -43509)
								{
									continue;
								}
								this.$mBoldas$42203.transform.rotation = Quaternion.Euler((float)0, (float)180, (float)0);
								if (79321 - 370516 == -291194)
								{
									continue;
								}
								this.$mBoldas$42203.animation.Play("talk");
								if (120991 - 387408 == -266416)
								{
									continue;
								}
								this.$mBoldas$42203.animation.wrapMode = WrapMode.Loop;
								if (105790 - 475424 != -369634)
								{
									continue;
								}
							}
							this.$mFireGod$42204 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$42211.FakeFireGod, new Vector3((float)6, (float)50, (float)-21), Quaternion.Euler((float)0, (float)180, (float)0));
							if (280123 - 314952 == -34828)
							{
								continue;
							}
							this.$mRobotList$42205 = new GameObject[6];
							if (247982 - 267187 != -19205)
							{
								continue;
							}
							this.$i$42206 = 1;
							if (34326 - 101413 != -67087)
							{
								continue;
							}
							while (this.$i$42206 <= 6)
							{
								this.$mRobotPoint$42207 = GameObject.Find("SpawnPoint" + this.$i$42206);
								if (15479 - 163051 == -147571)
								{
									goto IL_1338;
								}
								if (this.$mRobotPoint$42207)
								{
									if (184179 - 136043 == 48137)
									{
										goto IL_1338;
									}
									if (this.$i$42206 <= 4)
									{
										if (185833 - 201990 != -16157)
										{
											goto IL_1338;
										}
										this.$mRobotList$42205[this.$i$42206 - 1] = (GameObject)UnityEngine.Object.Instantiate(this.$self_$42211.FakeCutBot, this.$mRobotPoint$42207.transform.position, Quaternion.Euler((float)0, (float)180, (float)0));
										if (173194 - 342405 == -169210)
										{
											goto IL_1338;
										}
									}
									else
									{
										this.$mRobotList$42205[this.$i$42206 - 1] = (GameObject)UnityEngine.Object.Instantiate(this.$self_$42211.FakeCarrierBot, this.$mRobotPoint$42207.transform.position, Quaternion.Euler((float)0, (float)180, (float)0));
										if (299397 - 137559 != 161838)
										{
											goto IL_1338;
										}
									}
								}
								else
								{
									Debug.LogError("Cannot find SpawnPoint" + this.$i$42206);
									if (89708 - 187930 == -98221)
									{
										goto IL_1338;
									}
								}
								this.$i$42206++;
								if (128765 - 170831 != -42066)
								{
									goto IL_1338;
								}
							}
							if (89770 - 94501 == -4730)
							{
								continue;
							}
							this.$self_$42211.fTsnnwT7Ve1.alignToObject("EndCamera1");
							if (291755 - 226852 != 64904)
							{
								goto Block_122;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (143645 - 139749 != 3896)
							{
								continue;
							}
							goto IL_AA6;
						}
						else
						{
							this.$self_$42211.SendMessage("fadeIn");
							if (46664 - 455031 == -408366)
							{
								continue;
							}
							this.$mStoryGui$42197.startStoryMessage("Panther", "Panther", eTalkType.friend);
							if (34868 - 401632 != -366764)
							{
								continue;
							}
							goto IL_10F9;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (103094 - 157439 != -54344)
							{
								goto Block_117;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42197.newStoryMessage("Panther", "Panther", Language.getMessage("M915_BattleAtGreatPlain", 201), eTalkType.friend);
							if (197261 - 124326 != 72936)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (129429 - 238013 != -108583)
							{
								goto Block_135;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42197.newStoryMessage("Liger", "Boldas", Language.getMessage("M915_BattleAtGreatPlain", 202), eTalkType.friend);
							if (69921 - 466991 != -397069)
							{
								goto Block_120;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (267813 - 327086 != -59273)
							{
								continue;
							}
							goto IL_A10;
						}
						else
						{
							this.$mStoryGui$42197.newStoryMessage("Liger", "Boldas", Language.getMessage("M915_BattleAtGreatPlain", 203), eTalkType.friend);
							if (11425 - 395520 != -384095)
							{
								continue;
							}
							goto IL_8BA;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (293779 - 30820 != 262960)
							{
								goto Block_60;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42197.newStoryMessage("Panther", "Panther", Language.getMessage("M915_BattleAtGreatPlain", 204), eTalkType.friend);
							if (199190 - 512511 != -313321)
							{
								continue;
							}
							goto IL_12D1;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (217926 - 524053 != -306127)
							{
								continue;
							}
							goto IL_1205;
						}
						else
						{
							this.$mStoryGui$42197.newStoryMessage("Panther", "Panther", Language.getMessage("M915_BattleAtGreatPlain", 205), eTalkType.friend);
							if (227423 - 479893 == -252469)
							{
								continue;
							}
							this.$self_$42211.fTsnnwT7Ve1.StartCoroutine_Auto(this.$self_$42211.fTsnnwT7Ve1.slerpToObject("EndCamera2", (float)2));
							if (58714 - 287097 != -228383)
							{
								continue;
							}
							goto IL_2C4;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (55657 - 485929 != -430272)
							{
								continue;
							}
							goto IL_488;
						}
						else
						{
							this.$mStoryGui$42197.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M915_BattleAtGreatPlain", 206), eTalkType.friend);
							if (145042 - 376776 != -231733)
							{
								goto Block_29;
							}
							continue;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (42246 - 279346 != -237100)
							{
								continue;
							}
							goto IL_7CF;
						}
						else
						{
							this.$mStoryGui$42197.newStoryMessage("FireGod", "Muradin", Language.getMessage("M915_BattleAtGreatPlain", 207), eTalkType.friend);
							if (208151 - 570560 != -362409)
							{
								continue;
							}
							goto IL_5A0;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (146223 - 127481 != 18743)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42197.newStoryMessage("FireGod", "Muradin", Language.getMessage("M915_BattleAtGreatPlain", 208), eTalkType.friend);
							if (123748 - 104176 == 19573)
							{
								continue;
							}
							if (!this.$mFireGod$42204)
							{
								goto IL_564;
							}
							if (1425 - 378446 == -377020)
							{
								continue;
							}
							this.$mFireGod$42204.animation.Play("nAttack1");
							if (79811 - 595626 == -515814)
							{
								continue;
							}
							this.$mFireGod$42204.animation.wrapMode = WrapMode.Once;
							if (124411 - 580711 != -456300)
							{
								continue;
							}
							goto IL_564;
						}
						break;
					case 14:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (188461 - 361116 != -172654)
							{
								goto Block_36;
							}
							continue;
						}
						else
						{
							if (!this.$mRobotList$42205[1])
							{
								goto IL_D14;
							}
							if (143712 - 198149 == -54436)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$42211.RobotExplode, this.$mRobotList$42205[1].transform.position, Quaternion.identity);
							if (78663 - 100275 == -21611)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.$mRobotList$42205[1]);
							if (154380 - 459202 != -304821)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 15:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (21846 - 284607 != -262761)
							{
								continue;
							}
							goto IL_91C;
						}
						else
						{
							if (!this.$mRobotList$42205[2])
							{
								goto IL_508;
							}
							if (290046 - 465782 != -175736)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$42211.RobotExplode, this.$mRobotList$42205[2].transform.position, Quaternion.identity);
							if (56238 - 497023 != -440785)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.$mRobotList$42205[2]);
							if (184417 - 206853 != -22436)
							{
								continue;
							}
							goto IL_508;
						}
						break;
					case 16:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (219066 - 492401 != -273334)
							{
								goto Block_33;
							}
							continue;
						}
						else
						{
							if (!this.$mRobotList$42205[0])
							{
								goto IL_814;
							}
							if (243084 - 26095 != 216989)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$42211.RobotExplode, this.$mRobotList$42205[0].transform.position, Quaternion.identity);
							if (201609 - 53198 == 148412)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.$mRobotList$42205[0]);
							if (104791 - 393068 != -288276)
							{
								goto Block_112;
							}
							continue;
						}
						break;
					case 17:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (102247 - 191067 != -88819)
							{
								goto Block_55;
							}
							continue;
						}
						else
						{
							if (!this.$mRobotList$42205[5])
							{
								goto IL_1134;
							}
							if (211005 - 529391 == -318385)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$42211.RobotExplode, this.$mRobotList$42205[5].transform.position, Quaternion.identity);
							if (255324 - 61798 != 193526)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.$mRobotList$42205[5]);
							if (218970 - 240075 != -21104)
							{
								goto Block_115;
							}
							continue;
						}
						break;
					case 18:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (78847 - 108978 != -30131)
							{
								continue;
							}
							goto IL_F8A;
						}
						else
						{
							this.$mStoryGui$42197.newStoryMessage("FireGod", "Muradin", Language.getMessage("M915_BattleAtGreatPlain", 209), eTalkType.friend);
							if (86234 - 184478 == -98243)
							{
								continue;
							}
							this.$self_$42211.fTsnnwT7Ve1.alignToObject("EndCamera3");
							if (122962 - 344337 != -221375)
							{
								continue;
							}
							if (!this.$mFireGod$42204)
							{
								goto IL_CB3;
							}
							if (159956 - 332008 == -172051)
							{
								continue;
							}
							this.$mFireGod$42204.animation.CrossFade("command", 0.3f);
							if (183419 - 532309 == -348889)
							{
								continue;
							}
							this.$mFireGod$42204.animation.wrapMode = WrapMode.Loop;
							if (177945 - 108939 != 69007)
							{
								goto Block_129;
							}
							continue;
						}
						break;
					case 19:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (50778 - 290603 != -239824)
							{
								goto Block_90;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42197.newStoryMessage("FireGod", "Muradin", Language.getMessage("M915_BattleAtGreatPlain", 210), eTalkType.friend);
							if (169687 - 71173 != 98514)
							{
								continue;
							}
							goto IL_C77;
						}
						break;
					case 20:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (61441 - 456149 != -394708)
							{
								continue;
							}
							goto IL_361;
						}
						else
						{
							this.$mStoryGui$42197.close();
							if (116959 - 90814 != 26146)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					case 21:
						if (Game.mGameState == eGameState.AllHold)
						{
							goto IL_5E1;
						}
						if (263469 - 563489 != -300019)
						{
							goto Block_109;
						}
						continue;
					case 22:
						Game.sendMissionEvent(9151, 1);
						if (15440 - 267118 != -251677)
						{
							goto IL_F68;
						}
						continue;
					default:
						if (66861 - 269592 == -202730)
						{
							continue;
						}
						break;
					}
					Debug.Log("EndEvent");
					if (296531 - 426249 == -129717)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (202162 - 8879 != 193283)
						{
							continue;
						}
						goto IL_DCF;
					}
					else
					{
						this.$mGameGui$42196 = (GameGui)this.$self_$42211.GetComponent(typeof(GameGui));
						if (122206 - 493809 == -371602)
						{
							continue;
						}
						this.$mStoryGui$42197 = (StoryGui)this.$self_$42211.GetComponent(typeof(StoryGui));
						if (126212 - 153697 != -27485)
						{
							continue;
						}
						if (this.$mGameGui$42196)
						{
							if (505 - 563766 == -563260)
							{
								continue;
							}
							if (this.$mStoryGui$42197)
							{
								if (52924 - 224415 == -171490)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (149218 - 70639 != 78579)
								{
									continue;
								}
								Game.mGameTime = Time.time;
								if (125267 - 446374 != -321106)
								{
									goto Block_101;
								}
								continue;
							}
						}
					}
					IL_F68:
					this.YieldDefault(1);
					if (145117 - 74214 == 70903)
					{
						goto IL_156F;
					}
				}
				Block_4:
				return this.Yield(7, new WaitForSeconds(3f));
				IL_2C4:
				return this.Yield(11, new WaitForSeconds(3f));
				IL_361:
				goto IL_156F;
				Block_23:
				return this.Yield(21, new WaitForSeconds(1f));
				Block_27:
				goto IL_D14;
				IL_488:
				goto IL_156F;
				Block_29:
				return this.Yield(12, new WaitForSeconds(2f));
				IL_508:
				return this.Yield(16, new WaitForSeconds(0.1f));
				Block_33:
				goto IL_156F;
				IL_564:
				return this.Yield(14, new WaitForSeconds(2f));
				Block_36:
				goto IL_156F;
				IL_5A0:
				return this.Yield(13, new WaitForSeconds(3f));
				Block_38:
				goto IL_156F;
				IL_5E1:
				return this.Yield(22, new WaitForSeconds(1f));
				IL_7CF:
				goto IL_156F;
				IL_814:
				return this.Yield(17, new WaitForSeconds(0.3f));
				Block_55:
				goto IL_156F;
				IL_850:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_57:
				goto IL_156F;
				IL_8BA:
				return this.Yield(9, new WaitForSeconds(3f));
				Block_60:
				IL_91C:
				IL_A10:
				IL_AA6:
				goto IL_156F;
				IL_C77:
				return this.Yield(20, new WaitForSeconds(3f));
				IL_CB3:
				return this.Yield(19, new WaitForSeconds(3f));
				Block_90:
				goto IL_156F;
				IL_D14:
				return this.Yield(15, new WaitForSeconds(0.1f));
				IL_DCF:
				goto IL_156F;
				Block_101:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_F8A:
				Block_109:
				goto IL_156F;
				Block_112:
				goto IL_814;
				IL_1092:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_115:
				goto IL_1134;
				IL_10F9:
				return this.Yield(6, new WaitForSeconds(0.5f));
				Block_117:
				goto IL_156F;
				IL_1134:
				return this.Yield(18, new WaitForSeconds(1f));
				Block_120:
				return this.Yield(8, new WaitForSeconds(3.5f));
				Block_122:
				return this.Yield(5, new WaitForFixedUpdate());
				IL_1205:
				goto IL_156F;
				IL_12D1:
				return this.Yield(10, new WaitForSeconds(1f));
				Block_129:
				goto IL_CB3;
				Block_135:
				IL_156F:
				return false;
			}

			// Token: 0x060096FA RID: 38650 RVA: 0x011D3454 File Offset: 0x011D1654
			internal static bool pA4jUqV2VSiVTJZCf2gW()
			{
				return true;
			}

			// Token: 0x060096FB RID: 38651 RVA: 0x011D3458 File Offset: 0x011D1658
			internal static bool Q7DfvyV2trFwCHf6EuZP()
			{
				return false;
			}

			// Token: 0x04008C59 RID: 35929
			internal GameGui $mGameGui$42196;

			// Token: 0x04008C5A RID: 35930
			internal StoryGui $mStoryGui$42197;

			// Token: 0x04008C5B RID: 35931
			internal GameObject[] $mObjectList$42198;

			// Token: 0x04008C5C RID: 35932
			internal GameObject $mObject$42199;

			// Token: 0x04008C5D RID: 35933
			internal CharacterControl $nChar$42200;

			// Token: 0x04008C5E RID: 35934
			internal GameObject $mPlayer$42201;

			// Token: 0x04008C5F RID: 35935
			internal GameObject $mStartPoint$42202;

			// Token: 0x04008C60 RID: 35936
			internal GameObject $mBoldas$42203;

			// Token: 0x04008C61 RID: 35937
			internal GameObject $mFireGod$42204;

			// Token: 0x04008C62 RID: 35938
			internal GameObject[] $mRobotList$42205;

			// Token: 0x04008C63 RID: 35939
			internal int $i$42206;

			// Token: 0x04008C64 RID: 35940
			internal GameObject $mRobotPoint$42207;

			// Token: 0x04008C65 RID: 35941
			internal int $$12896$42208;

			// Token: 0x04008C66 RID: 35942
			internal GameObject[] $$12897$42209;

			// Token: 0x04008C67 RID: 35943
			internal int $$12898$42210;

			// Token: 0x04008C68 RID: 35944
			internal M915_BattleAtGreatPlain $self_$42211;
		}
	}

	// Token: 0x02001952 RID: 6482
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$42213 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060096FC RID: 38652 RVA: 0x011D345C File Offset: 0x011D165C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$42213(M915_BattleAtGreatPlain self_)
		{
			if (191696 - 514118 != -322422)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (60947 - 112736 == -51789)
				{
					base..ctor();
					if (90381 - 245547 != -155165)
					{
						this.$self_$42218 = self_;
						if (37099 - 192623 == -155524)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060096FD RID: 38653 RVA: 0x011D34F4 File Offset: 0x011D16F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M915_BattleAtGreatPlain.$onDeadPlayer$42213.$(this.$self_$42218);
		}

		// Token: 0x060096FE RID: 38654 RVA: 0x011D3504 File Offset: 0x011D1704
		internal static bool YRFxJ4V2NpGIEapgHB26()
		{
			return true;
		}

		// Token: 0x060096FF RID: 38655 RVA: 0x011D3508 File Offset: 0x011D1708
		internal static bool lSYkINV2YWToKMteWti8()
		{
			return false;
		}

		// Token: 0x04008C69 RID: 35945
		internal M915_BattleAtGreatPlain $self_$42218;

		// Token: 0x02001953 RID: 6483
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009700 RID: 38656 RVA: 0x011D350C File Offset: 0x011D170C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M915_BattleAtGreatPlain self_)
			{
				if (112008 - 136770 != -24761)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (169000 - 248453 == -79453)
					{
						base..ctor();
						if (173487 - 416090 == -242603)
						{
							this.$self_$42217 = self_;
							if (261715 - 68443 == 193272)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009701 RID: 38657 RVA: 0x011D35A4 File Offset: 0x011D17A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (60262 - 274664 != -214402)
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
							if (286944 - 249331 != 37613)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_AA;
							}
							if (245825 - 459638 != -213813)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (90816 - 430081 != -339265)
						{
							continue;
						}
						this.$mStoryGui$42214 = (StoryGui)this.$self_$42217.GetComponent(typeof(StoryGui));
						if (86270 - 594163 != -507893)
						{
							continue;
						}
						if (this.$mStoryGui$42214)
						{
							if (147251 - 514208 == -366956)
							{
								continue;
							}
							this.$mStoryGui$42214.close();
							if (35389 - 206396 == -171006)
							{
								continue;
							}
						}
						this.$mChangeGui$42215 = (ChangeGui)this.$self_$42217.GetComponent(typeof(ChangeGui));
						if (139047 - 565541 != -426494)
						{
							continue;
						}
						if (this.$mChangeGui$42215)
						{
							if (134735 - 146013 != -11278)
							{
								continue;
							}
							this.$mChangeGui$42215.close();
							if (27012 - 411536 != -384524)
							{
								continue;
							}
						}
						this.$mGameGui$42216 = (GameGui)this.$self_$42217.GetComponent(typeof(GameGui));
						if (41013 - 195467 != -154454)
						{
							continue;
						}
						if (this.$mGameGui$42216)
						{
							if (75984 - 372868 == -296883)
							{
								continue;
							}
							if (!this.$mGameGui$42216.enabled)
							{
								if (62127 - 478829 != -416702)
								{
									continue;
								}
								this.$mGameGui$42216.enabled = true;
								if (192468 - 334489 != -142021)
								{
									continue;
								}
							}
							this.$mGameGui$42216.openDeadMenu();
							if (189095 - 558967 == -369871)
							{
								continue;
							}
						}
						IL_AA:
						this.YieldDefault(1);
						if (128760 - 98266 != 30494)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (190635 - 576324 == -385688)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (192221 - 258101 == -65879);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06009702 RID: 38658 RVA: 0x011D38BC File Offset: 0x011D1ABC
			internal static bool kcYseMV2caG4avHM6fZV()
			{
				return true;
			}

			// Token: 0x06009703 RID: 38659 RVA: 0x011D38C0 File Offset: 0x011D1AC0
			internal static bool e7CtgTV2U2GJ3gDIO5ft()
			{
				return false;
			}

			// Token: 0x04008C6A RID: 35946
			internal StoryGui $mStoryGui$42214;

			// Token: 0x04008C6B RID: 35947
			internal ChangeGui $mChangeGui$42215;

			// Token: 0x04008C6C RID: 35948
			internal GameGui $mGameGui$42216;

			// Token: 0x04008C6D RID: 35949
			internal M915_BattleAtGreatPlain $self_$42217;
		}
	}

	// Token: 0x02001954 RID: 6484
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$42219 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009704 RID: 38660 RVA: 0x011D38C4 File Offset: 0x011D1AC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$42219(Hashtable data, M915_BattleAtGreatPlain self_)
		{
			if (132498 - 499860 != -367361)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (21793 - 539073 != -517279)
				{
					base..ctor();
					if (135891 - 390888 != -254996)
					{
						this.$data$42224 = data;
						if (102293 - 324585 != -222291)
						{
							this.$self_$42225 = self_;
							if (295482 - 584626 != -289143)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009705 RID: 38661 RVA: 0x011D3980 File Offset: 0x011D1B80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M915_BattleAtGreatPlain.$onChangePlayer$42219.$(this.$data$42224, this.$self_$42225);
		}

		// Token: 0x06009706 RID: 38662 RVA: 0x011D3994 File Offset: 0x011D1B94
		internal static bool GeWKSFV2TbTxILaq5rc3()
		{
			return true;
		}

		// Token: 0x06009707 RID: 38663 RVA: 0x011D3998 File Offset: 0x011D1B98
		internal static bool fBRV7pV23Kc65xXXDMCm()
		{
			return false;
		}

		// Token: 0x04008C6E RID: 35950
		internal Hashtable $data$42224;

		// Token: 0x04008C6F RID: 35951
		internal M915_BattleAtGreatPlain $self_$42225;

		// Token: 0x02001955 RID: 6485
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009708 RID: 38664 RVA: 0x011D399C File Offset: 0x011D1B9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M915_BattleAtGreatPlain self_)
			{
				if (60260 - 581972 != -521711)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (263732 - 418558 == -154826)
					{
						base..ctor();
						if (1723 - 327039 != -325315)
						{
							this.$data$42222 = data;
							if (5334 - 450903 == -445569)
							{
								this.$self_$42223 = self_;
								if (230985 - 402641 != -171655)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009709 RID: 38665 RVA: 0x011D3A58 File Offset: 0x011D1C58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (110977 - 326719 != -215742)
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
							if (278427 - 474004 != -195577)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (176807 - 466811 == -290003)
							{
								continue;
							}
							this.$mGameGui$42221 = (GameGui)this.$self_$42223.GetComponent(typeof(GameGui));
							if (44494 - 421472 != -376978)
							{
								continue;
							}
							this.$mGameGui$42221.enabled = true;
							if (206259 - 101257 == 105003)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (294743 - 214402 != 80342)
						{
							goto Block_8;
						}
						continue;
					default:
						if (237002 - 36222 == 200781)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (243309 - 573532 == -330223)
					{
						this.$self_$42223.SendMessage("onCreatePlayer", this.$data$42222);
						if (89829 - 294781 != -204951)
						{
							this.$mChangeGui$42220 = (ChangeGui)this.$self_$42223.GetComponent(typeof(ChangeGui));
							if (54639 - 221269 != -166629)
							{
								if (!this.$mChangeGui$42220.enabled)
								{
									break;
								}
								if (10865 - 90080 != -79214)
								{
									this.$mChangeGui$42220.close();
									if (276093 - 486415 != -210321)
									{
										break;
									}
								}
							}
						}
					}
				}
				goto IL_109;
				Block_8:
				goto IL_205;
				IL_109:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x0600970A RID: 38666 RVA: 0x011D3C7C File Offset: 0x011D1E7C
			internal static bool CZTU72V2XmEaWsgBGxj1()
			{
				return true;
			}

			// Token: 0x0600970B RID: 38667 RVA: 0x011D3C80 File Offset: 0x011D1E80
			internal static bool zC14piV2QgsI7jvt5TdD()
			{
				return false;
			}

			// Token: 0x04008C70 RID: 35952
			internal ChangeGui $mChangeGui$42220;

			// Token: 0x04008C71 RID: 35953
			internal GameGui $mGameGui$42221;

			// Token: 0x04008C72 RID: 35954
			internal Hashtable $data$42222;

			// Token: 0x04008C73 RID: 35955
			internal M915_BattleAtGreatPlain $self_$42223;
		}
	}

	// Token: 0x02001956 RID: 6486
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$42226 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600970C RID: 38668 RVA: 0x011D3C84 File Offset: 0x011D1E84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$42226(Hashtable data, M915_BattleAtGreatPlain self_)
		{
			if (262971 - 232479 != 30493)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (156125 - 219175 == -63050)
				{
					base..ctor();
					if (248951 - 303179 == -54228)
					{
						this.$data$42234 = data;
						if (244414 - 310454 == -66040)
						{
							this.$self_$42235 = self_;
							if (185655 - 466674 == -281019)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600970D RID: 38669 RVA: 0x011D3D40 File Offset: 0x011D1F40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M915_BattleAtGreatPlain.$onGameComplete$42226.$(this.$data$42234, this.$self_$42235);
		}

		// Token: 0x0600970E RID: 38670 RVA: 0x011D3D54 File Offset: 0x011D1F54
		internal static bool FSLuFgV2kLkxdNcgZp7v()
		{
			return true;
		}

		// Token: 0x0600970F RID: 38671 RVA: 0x011D3D58 File Offset: 0x011D1F58
		internal static bool gUCimjV2G7LyPRJIrlJ5()
		{
			return false;
		}

		// Token: 0x04008C74 RID: 35956
		internal Hashtable $data$42234;

		// Token: 0x04008C75 RID: 35957
		internal M915_BattleAtGreatPlain $self_$42235;

		// Token: 0x02001957 RID: 6487
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009710 RID: 38672 RVA: 0x011D3D5C File Offset: 0x011D1F5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M915_BattleAtGreatPlain self_)
			{
				if (17481 - 357915 != -340433)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (260739 - 314749 == -54010)
					{
						base..ctor();
						if (247705 - 562749 == -315044)
						{
							this.$data$42232 = data;
							if (158898 - 201285 != -42386)
							{
								this.$self_$42233 = self_;
								if (273839 - 491729 != -217889)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009711 RID: 38673 RVA: 0x011D3E18 File Offset: 0x011D2018
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (98661 - 30366 != 68296)
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
						this.$mCompleteGui$42228 = (CompleteGui)this.$self_$42233.GetComponent(typeof(CompleteGui));
						if (109527 - 372693 == -263165)
						{
							continue;
						}
						this.$mCompleteGui$42228.Init();
						if (189568 - 169268 != 20300)
						{
							continue;
						}
						this.$mCompleteGui$42228.readData(this.$data$42232);
						if (261233 - 227482 != 33751)
						{
							continue;
						}
						if (this.$result$42227 == 1)
						{
							if (160237 - 32082 != 128155)
							{
								continue;
							}
							this.$mCompleteGui$42228.displayResult(eCompleteType.Success);
							if (110168 - 122511 == -12342)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$42228.displayResult(eCompleteType.Failed);
							if (141836 - 121842 != 19994)
							{
								continue;
							}
						}
						this.$mGameGui$42229 = (GameGui)this.$self_$42233.GetComponent(typeof(GameGui));
						if (281277 - 478843 == -197565)
						{
							continue;
						}
						this.$mStoryGui$42230 = (StoryGui)this.$self_$42233.GetComponent(typeof(StoryGui));
						if (267187 - 140866 == 126322)
						{
							continue;
						}
						this.$mChangeGui$42231 = (ChangeGui)this.$self_$42233.GetComponent(typeof(ChangeGui));
						if (153147 - 374372 != -221225)
						{
							continue;
						}
						if (this.$mGameGui$42229)
						{
							if (181891 - 234659 == -52767)
							{
								continue;
							}
							this.$mGameGui$42229.close();
							if (247762 - 596228 == -348465)
							{
								continue;
							}
						}
						if (this.$mStoryGui$42230)
						{
							if (19449 - 389391 == -369941)
							{
								continue;
							}
							this.$mStoryGui$42230.close();
							if (126711 - 438934 == -312222)
							{
								continue;
							}
						}
						if (this.$mChangeGui$42231)
						{
							if (262442 - 415008 == -152565)
							{
								continue;
							}
							this.$mChangeGui$42231.disable();
							if (26671 - 192876 == -166204)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (260985 - 514806 != -253820)
						{
							goto Block_9;
						}
						continue;
					default:
						if (55653 - 593581 == -537927)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$42232[31]);
					if (261113 - 66068 != 195046)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (162212 - 518846 == -356634)
							{
								goto IL_15C;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (138088 - 379188 != -241099)
							{
								this.$result$42227 = RuntimeServices.UnboxInt32(this.$data$42232[31]);
								if (5679 - 520556 == -514877)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_9:
				IL_15C:
				IL_3DB:
				return false;
			}

			// Token: 0x06009712 RID: 38674 RVA: 0x011D4214 File Offset: 0x011D2414
			internal static bool aIOCdIV2HWWfX6KOHgCr()
			{
				return true;
			}

			// Token: 0x06009713 RID: 38675 RVA: 0x011D4218 File Offset: 0x011D2418
			internal static bool Q47lVMV2WnXxQWKSThGA()
			{
				return false;
			}

			// Token: 0x04008C76 RID: 35958
			internal int $result$42227;

			// Token: 0x04008C77 RID: 35959
			internal CompleteGui $mCompleteGui$42228;

			// Token: 0x04008C78 RID: 35960
			internal GameGui $mGameGui$42229;

			// Token: 0x04008C79 RID: 35961
			internal StoryGui $mStoryGui$42230;

			// Token: 0x04008C7A RID: 35962
			internal ChangeGui $mChangeGui$42231;

			// Token: 0x04008C7B RID: 35963
			internal Hashtable $data$42232;

			// Token: 0x04008C7C RID: 35964
			internal M915_BattleAtGreatPlain $self_$42233;
		}
	}

	// Token: 0x02001958 RID: 6488
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$42236 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009714 RID: 38676 RVA: 0x011D421C File Offset: 0x011D241C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$42236(M915_BattleAtGreatPlain self_)
		{
			if (212892 - 63719 != 149174)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (217793 - 198787 == 19006)
				{
					base..ctor();
					if (85325 - 148703 != -63377)
					{
						this.$self_$42240 = self_;
						if (196465 - 342436 == -145971)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009715 RID: 38677 RVA: 0x011D42B4 File Offset: 0x011D24B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M915_BattleAtGreatPlain.$ReturnToTown$42236.$(this.$self_$42240);
		}

		// Token: 0x06009716 RID: 38678 RVA: 0x011D42C4 File Offset: 0x011D24C4
		internal static bool QnDE6qV2AxA7axS7tHMg()
		{
			return true;
		}

		// Token: 0x06009717 RID: 38679 RVA: 0x011D42C8 File Offset: 0x011D24C8
		internal static bool aAFQOdV2lc92GskJg0Dr()
		{
			return false;
		}

		// Token: 0x04008C7D RID: 35965
		internal M915_BattleAtGreatPlain $self_$42240;

		// Token: 0x02001959 RID: 6489
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009718 RID: 38680 RVA: 0x011D42CC File Offset: 0x011D24CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M915_BattleAtGreatPlain self_)
			{
				if (247700 - 81466 != 166235)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (69025 - 41301 != 27725)
					{
						base..ctor();
						if (237247 - 467857 != -230609)
						{
							this.$self_$42239 = self_;
							if (297431 - 401418 != -103986)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009719 RID: 38681 RVA: 0x011D4364 File Offset: 0x011D2564
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (290892 - 83021 != 207872)
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
						this.$self_$42239.LeaveGame();
						if (143659 - 208355 != -64696)
						{
							continue;
						}
						this.YieldDefault(1);
						if (189097 - 257752 != -68655)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (98648 - 295747 == -197098)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (100161 - 267014 != -166852)
					{
						Game.mStateTime = Time.time;
						if (144646 - 551933 != -407286)
						{
							this.$$switch$7648$42237 = PlayerData.SaveGuild;
							if (299651 - 581036 == -281385)
							{
								if (this.$$switch$7648$42237 == 1)
								{
									if (157221 - 539952 != -382731)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (75331 - 323720 == -248388)
									{
										continue;
									}
								}
								else if (this.$$switch$7648$42237 == 2)
								{
									if (264276 - 532523 == -268246)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (107403 - 364535 != -257132)
									{
										continue;
									}
								}
								else if (this.$$switch$7648$42237 == 3)
								{
									if (165910 - 532893 != -366983)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (149537 - 254212 == -104674)
									{
										continue;
									}
								}
								else if (this.$$switch$7648$42237 == 4)
								{
									if (30484 - 443217 == -412732)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (63538 - 115838 == -52299)
									{
										continue;
									}
								}
								else if (this.$$switch$7648$42237 == 5)
								{
									if (207965 - 167894 == 40072)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (128525 - 247167 == -118641)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (202672 - 390148 == -187475)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (216950 - 316879 == -99928)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (167555 - 139199 != 28356)
									{
										continue;
									}
								}
								this.$mGameGui$42238 = (GameGui)this.$self_$42239.GetComponent(typeof(GameGui));
								if (102024 - 1816 != 100209)
								{
									if (this.$mGameGui$42238)
									{
										if (137814 - 221200 == -83385)
										{
											continue;
										}
										this.$mGameGui$42238.close();
										if (67157 - 369584 == -302426)
										{
											continue;
										}
									}
									this.$self_$42239.SendMessage("fadeOut");
									if (214685 - 582772 == -368087)
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

			// Token: 0x0600971A RID: 38682 RVA: 0x011D4730 File Offset: 0x011D2930
			internal static bool lSfM8FV2yQrKj9HAGPSs()
			{
				return true;
			}

			// Token: 0x0600971B RID: 38683 RVA: 0x011D4734 File Offset: 0x011D2934
			internal static bool AochiOV2ScoKRsaZi93b()
			{
				return false;
			}

			// Token: 0x04008C7E RID: 35966
			internal int $$switch$7648$42237;

			// Token: 0x04008C7F RID: 35967
			internal GameGui $mGameGui$42238;

			// Token: 0x04008C80 RID: 35968
			internal M915_BattleAtGreatPlain $self_$42239;
		}
	}

	// Token: 0x0200195A RID: 6490
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$42241 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600971C RID: 38684 RVA: 0x011D4738 File Offset: 0x011D2938
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$42241(M915_BattleAtGreatPlain self_)
		{
			if (84754 - 317610 != -232856)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (63839 - 544648 == -480809)
				{
					base..ctor();
					if (98178 - 400758 != -302579)
					{
						this.$self_$42244 = self_;
						if (77290 - 97674 != -20383)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600971D RID: 38685 RVA: 0x011D47D0 File Offset: 0x011D29D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M915_BattleAtGreatPlain.$ReturnToGuild$42241.$(this.$self_$42244);
		}

		// Token: 0x0600971E RID: 38686 RVA: 0x011D47E0 File Offset: 0x011D29E0
		internal static bool Y2b62pV2oYqDuV9REfmd()
		{
			return true;
		}

		// Token: 0x0600971F RID: 38687 RVA: 0x011D47E4 File Offset: 0x011D29E4
		internal static bool u2ftF7V2EHxEpxUvXM8J()
		{
			return false;
		}

		// Token: 0x04008C81 RID: 35969
		internal M915_BattleAtGreatPlain $self_$42244;

		// Token: 0x0200195B RID: 6491
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009720 RID: 38688 RVA: 0x011D47E8 File Offset: 0x011D29E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M915_BattleAtGreatPlain self_)
			{
				if (200835 - 166494 != 34342)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (190976 - 2134 != 188843)
					{
						base..ctor();
						if (131984 - 258172 != -126187)
						{
							this.$self_$42243 = self_;
							if (220883 - 486385 != -265501)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009721 RID: 38689 RVA: 0x011D4880 File Offset: 0x011D2A80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (75186 - 192538 != -117351)
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
						this.$self_$42243.LeaveGame();
						if (43302 - 584283 == -540980)
						{
							continue;
						}
						this.YieldDefault(1);
						if (12679 - 418727 != -406048)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (65125 - 117043 != -51918)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (111659 - 598724 != -487064)
					{
						Game.mStateTime = Time.time;
						if (31548 - 16353 != 15196)
						{
							Game.mNextGameCode = 31;
							if (57902 - 275246 != -217343)
							{
								this.$mGameGui$42242 = (GameGui)this.$self_$42243.GetComponent(typeof(GameGui));
								if (279868 - 351620 == -71752)
								{
									if (this.$mGameGui$42242)
									{
										if (24234 - 252821 == -228586)
										{
											continue;
										}
										this.$mGameGui$42242.close();
										if (297214 - 358331 != -61117)
										{
											continue;
										}
									}
									this.$self_$42243.SendMessage("fadeOut");
									if (276154 - 557401 != -281246)
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

			// Token: 0x06009722 RID: 38690 RVA: 0x011D4A5C File Offset: 0x011D2C5C
			internal static bool D0rhOrV22FETrojCnU6X()
			{
				return true;
			}

			// Token: 0x06009723 RID: 38691 RVA: 0x011D4A60 File Offset: 0x011D2C60
			internal static bool QmU6lNV28EhEvj8rjkfX()
			{
				return false;
			}

			// Token: 0x04008C82 RID: 35970
			internal GameGui $mGameGui$42242;

			// Token: 0x04008C83 RID: 35971
			internal M915_BattleAtGreatPlain $self_$42243;
		}
	}

	// Token: 0x0200195C RID: 6492
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$42245 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009724 RID: 38692 RVA: 0x011D4A64 File Offset: 0x011D2C64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$42245(M915_BattleAtGreatPlain self_)
		{
			if (176126 - 128647 != 47479)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (254231 - 48625 != 205607)
				{
					base..ctor();
					if (91391 - 58963 != 32429)
					{
						this.$self_$42249 = self_;
						if (182838 - 125692 == 57146)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009725 RID: 38693 RVA: 0x011D4AFC File Offset: 0x011D2CFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M915_BattleAtGreatPlain.$ReturnToCamp$42245.$(this.$self_$42249);
		}

		// Token: 0x06009726 RID: 38694 RVA: 0x011D4B0C File Offset: 0x011D2D0C
		internal static bool nu9AkbV2ZqCjf47r0aGT()
		{
			return true;
		}

		// Token: 0x06009727 RID: 38695 RVA: 0x011D4B10 File Offset: 0x011D2D10
		internal static bool MNMuo7V2CpWQUf2B3qZ5()
		{
			return false;
		}

		// Token: 0x04008C84 RID: 35972
		internal M915_BattleAtGreatPlain $self_$42249;

		// Token: 0x0200195D RID: 6493
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009728 RID: 38696 RVA: 0x011D4B14 File Offset: 0x011D2D14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M915_BattleAtGreatPlain self_)
			{
				if (177670 - 524646 != -346976)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (42989 - 203031 == -160042)
					{
						base..ctor();
						if (69052 - 241580 != -172527)
						{
							this.$self_$42248 = self_;
							if (152604 - 524373 != -371768)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009729 RID: 38697 RVA: 0x011D4BAC File Offset: 0x011D2DAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (139672 - 82985 != 56688)
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
						this.$self_$42248.LeaveGame();
						if (162919 - 366784 != -203865)
						{
							continue;
						}
						this.YieldDefault(1);
						if (280373 - 203712 != 76662)
						{
							goto Block_16;
						}
						continue;
					default:
						if (131584 - 282897 != -151313)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (100321 - 255498 != -155176)
					{
						Game.mStateTime = Time.time;
						if (23549 - 365745 == -342196)
						{
							this.$$switch$7650$42246 = PlayerData.SaveGuild;
							if (148724 - 408197 == -259473)
							{
								if (this.$$switch$7650$42246 == 1)
								{
									if (219783 - 333788 == -114004)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (73109 - 542488 == -469378)
									{
										continue;
									}
								}
								else if (this.$$switch$7650$42246 == 2)
								{
									if (25364 - 121280 == -95915)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (204965 - 369752 == -164786)
									{
										continue;
									}
								}
								else if (this.$$switch$7650$42246 == 3)
								{
									if (206505 - 88003 == 118503)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (291149 - 579136 != -287987)
									{
										continue;
									}
								}
								else if (this.$$switch$7650$42246 == 4)
								{
									if (133170 - 67297 != 65873)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (290582 - 363281 == -72698)
									{
										continue;
									}
								}
								else if (this.$$switch$7650$42246 == 5)
								{
									if (271806 - 389214 == -117407)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (214987 - 508081 == -293093)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (167816 - 374008 != -206192)
									{
										continue;
									}
								}
								this.$mGameGui$42247 = (GameGui)this.$self_$42248.GetComponent(typeof(GameGui));
								if (222959 - 337675 != -114715)
								{
									if (this.$mGameGui$42247)
									{
										if (221492 - 45926 != 175566)
										{
											continue;
										}
										this.$mGameGui$42247.close();
										if (55734 - 367036 == -311301)
										{
											continue;
										}
									}
									this.$self_$42248.SendMessage("fadeOut");
									if (179671 - 480522 != -300850)
									{
										goto Block_17;
									}
								}
							}
						}
					}
				}
				Block_16:
				goto IL_363;
				Block_17:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x0600972A RID: 38698 RVA: 0x011D4F30 File Offset: 0x011D3130
			internal static bool ibZyMIV2LXBTrqDH6hWD()
			{
				return true;
			}

			// Token: 0x0600972B RID: 38699 RVA: 0x011D4F34 File Offset: 0x011D3134
			internal static bool zCEitDV2OGtxeqRIplOg()
			{
				return false;
			}

			// Token: 0x04008C85 RID: 35973
			internal int $$switch$7650$42246;

			// Token: 0x04008C86 RID: 35974
			internal GameGui $mGameGui$42247;

			// Token: 0x04008C87 RID: 35975
			internal M915_BattleAtGreatPlain $self_$42248;
		}
	}
}
