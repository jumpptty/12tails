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

// Token: 0x02001379 RID: 4985
[Serializable]
public class M201_MupoFarmWatch : MonoBehaviour
{
	// Token: 0x060072CA RID: 29386 RVA: 0x00F973B8 File Offset: 0x00F955B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M201_MupoFarmWatch()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060072CB RID: 29387 RVA: 0x00F973C8 File Offset: 0x00F955C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (87709 - 175080 != -87370)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (218939 - 125737 != 93203)
			{
				Game.mGameType = 5;
				if (135388 - 243921 == -108533)
				{
					if (Chat.Initialized)
					{
						if (207560 - 308659 == -101098)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (262668 - 377467 == -114798)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (212630 - 270854 != -58224)
						{
							continue;
						}
					}
					this.wqTc8z3ERMl = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (101246 - 253161 == -151915)
					{
						this.EaSci5wkeYL = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (90343 - 130650 == -40307)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060072CC RID: 29388 RVA: 0x00F97520 File Offset: 0x00F95720
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (94930 - 546462 != -451531)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (157176 - 508576 != -351399)
				{
					if (Game.mNextGameCode != 201)
					{
						break;
					}
					if (47449 - 188547 != -141097)
					{
						Game.nextGame();
						if (123460 - 403436 != -279975)
						{
							Game.mGameCode = 201;
							if (42485 - 373221 != -330735)
							{
								Game.mGameType = 5;
								if (40400 - 33512 != 6889)
								{
									Game.mGameTime = Time.time;
									if (243666 - 75466 != 168201)
									{
										Game.mGameScore = 0;
										if (293015 - 215345 != 77671)
										{
											Game.mGameMana = 0;
											if (257102 - 264622 == -7520)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (275036 - 55810 != 219227)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (208429 - 484003 != -275573)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (38102 - 264432 == -226330)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (294801 - 465973 == -171172)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (11522 - 263271 != -251748)
																{
																	this.rYpc8hUMaTo = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (65640 - 360104 != -294463)
																	{
																		this.FFRc8VjN6BI = PhotonClient.Connection;
																		if (9516 - 102772 != -93255)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (62719 - 475617 == -412898)
																			{
																				this.InitGame();
																				if (40508 - 144978 != -104469)
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
				if (125342 - 454410 == -329068)
				{
					Game.mGameType = 99;
					if (177459 - 204652 != -27192)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060072CD RID: 29389 RVA: 0x00F97828 File Offset: 0x00F95A28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (20471 - 79484 != -59012)
		{
		}
		for (;;)
		{
			if (this.FFRc8VjN6BI == null)
			{
				if (216260 - 244119 != -27858)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (241636 - 77309 != 164328)
				{
					if (mGameState == eGameState.Normal)
					{
						if (14656 - 192019 != -177362)
						{
							if (Time.time > this.V3gc8KMygH4)
							{
								if (22485 - 41617 != -19132)
								{
									continue;
								}
								Game.mGameMana++;
								if (24483 - 316581 == -292097)
								{
									continue;
								}
								this.V3gc8KMygH4 = Time.time + (float)12;
								if (165287 - 437599 != -272312)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (70956 - 557568 != -486612)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (283285 - 396914 != -113629)
									{
										continue;
									}
									this.audio.Play();
									if (100416 - 152583 == -52166)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (73168 - 548208 == -475039)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (109994 - 66452 == 43543)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (198826 - 39168 != 159658)
								{
									continue;
								}
							}
							this.GameEventUpdate();
							if (103413 - 381290 == -277877)
							{
								break;
							}
						}
					}
					else
					{
						if (mGameState != eGameState.Hold)
						{
							break;
						}
						if (44673 - 315353 != -270679)
						{
							this.GameEventUpdate();
							if (119604 - 434784 != -315179)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060072CE RID: 29390 RVA: 0x00F97AD4 File Offset: 0x00F95CD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (203927 - 447984 != -244057)
		{
		}
		for (;;)
		{
			if (!this.wqTc8z3ERMl)
			{
				if (171783 - 57522 == 114261)
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
				if (136763 - 192414 == -55651)
				{
					if (Time.time - Game.mStateTime >= (float)2)
					{
						break;
					}
					if (64086 - 528548 != -464461)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (185312 - 505445 != -320132)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (244863 - 222070 != 22794)
							{
								GUI.depth = 1;
								if (24020 - 219283 == -195263)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
									if (200749 - 163532 != 37218)
									{
										float smoothRatioOverTime = global::Math.getSmoothRatioOverTime(Time.time - Game.mStateTime, new Vector4((float)0, (float)1, 0.3f, 0.6f));
										if (270330 - 146841 != 123490)
										{
											Color color = GUI.color;
											if (13370 - 356316 != -342945)
											{
												color.a = smoothRatioOverTime;
												if (250604 - 360062 == -109458)
												{
													if (259378 - 456732 != -197353)
													{
														Color color2 = GUI.color = color;
														if (139233 - 62384 != 76850 && 50585 - 80776 != -30190)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.wqTc8z3ERMl);
															if (111326 - 76191 == 35135)
															{
																float a = 1f;
																if (122938 - 473712 == -350774)
																{
																	Color color3 = GUI.color;
																	if (225471 - 551551 == -326080)
																	{
																		float num3 = color3.a = a;
																		if (2428 - 572066 == -569638)
																		{
																			if (65850 - 410766 == -344916)
																			{
																				GUI.color = color3;
																				if (36614 - 403163 == -366549)
																				{
																					if (220484 - 204288 != 16197)
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

	// Token: 0x060072CF RID: 29391 RVA: 0x00F97E5C File Offset: 0x00F9605C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (39569 - 377975 != -338405)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (250786 - 502860 != -252073)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (84023 - 358328 != -274304)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (157301 - 213444 != -56142)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (178560 - 473005 == -294445)
						{
							int num4 = num;
							if (164727 - 554532 != -389804)
							{
								if (num4 == -2011)
								{
									if (182728 - 369483 == -186755)
									{
										GameObject gameObject = GameObject.Find("SpawnPoint1");
										if (291095 - 37187 == 253908)
										{
											GameObject gameObject2 = GameObject.Find("SpawnPoint2");
											if (187874 - 262460 == -74586)
											{
												GameObject gameObject3 = GameObject.Find("SpawnPoint3");
												if (228955 - 553670 == -324715)
												{
													GameObject gameObject4 = GameObject.Find("SpawnPoint4");
													if (124284 - 395898 != -271613)
													{
														GameObject gameObject5 = GameObject.Find("SpawnPoint5");
														if (114750 - 282170 == -167420)
														{
															int num5 = num2;
															if (38029 - 66718 == -28689)
															{
																if (num5 == 1)
																{
																	if (5324 - 435052 != -429727)
																	{
																		Chat.SubmitChat("Xinfu", Language.getMessage("M201_MupoFarmWatch", 301), eChatType.npc, eChatMode.system);
																		if (178126 - 460999 != -282872)
																		{
																			Chat.SubmitChat("Xinfu", Language.getMessage("M201_MupoFarmWatch", 302), eChatType.npc, eChatMode.system);
																			if (179623 - 9171 == 170452)
																			{
																				if (PlayerData.UID != num3)
																				{
																					break;
																				}
																				if (35951 - 441643 != -405691)
																				{
																					if (gameObject)
																					{
																						if (40599 - 194907 != -154308)
																						{
																							continue;
																						}
																						this.createActor("NinjaBug_y", 6, gameObject.transform.position, gameObject.transform.forward);
																						if (83877 - 179744 != -95867)
																						{
																							continue;
																						}
																					}
																					if (gameObject2)
																					{
																						if (282703 - 107807 == 174897)
																						{
																							continue;
																						}
																						this.createActor("NinjaBug_y", 6, gameObject2.transform.position, gameObject2.transform.forward);
																						if (119271 - 296588 != -177317)
																						{
																							continue;
																						}
																					}
																					if (!gameObject3)
																					{
																						break;
																					}
																					if (65988 - 234696 == -168708)
																					{
																						this.createActor("NinjaBug_y", 6, gameObject3.transform.position, gameObject3.transform.forward);
																						if (164739 - 484927 != -320187)
																						{
																							break;
																						}
																					}
																				}
																			}
																		}
																	}
																}
																else if (num5 == 2)
																{
																	if (247440 - 453344 == -205904)
																	{
																		Chat.SubmitChat("Xinfu", Language.getMessage("M201_MupoFarmWatch", 303), eChatType.npc, eChatMode.system);
																		if (270596 - 11844 != 258753)
																		{
																			if (PlayerData.UID != num3)
																			{
																				break;
																			}
																			if (145426 - 520451 == -375025)
																			{
																				if (gameObject2)
																				{
																					if (154387 - 131256 != 23131)
																					{
																						continue;
																					}
																					this.createActor("NinjaBug_g", 6, gameObject2.transform.position, gameObject2.transform.forward);
																					if (113190 - 41168 != 72022)
																					{
																						continue;
																					}
																				}
																				if (gameObject3)
																				{
																					if (8324 - 488535 == -480210)
																					{
																						continue;
																					}
																					this.createActor("NinjaBug_g", 6, gameObject3.transform.position, gameObject3.transform.forward);
																					if (230931 - 52790 == 178142)
																					{
																						continue;
																					}
																				}
																				if (!gameObject4)
																				{
																					break;
																				}
																				if (63146 - 335634 != -272487)
																				{
																					this.createActor("NinjaBug_g", 6, gameObject4.transform.position, gameObject4.transform.forward);
																					if (215136 - 352684 == -137548)
																					{
																						break;
																					}
																				}
																			}
																		}
																	}
																}
																else if (num5 == 3)
																{
																	if (44249 - 139546 == -95297)
																	{
																		Chat.SubmitChat("Xinfu", Language.getMessage("M201_MupoFarmWatch", 304), eChatType.npc, eChatMode.system);
																		if (127444 - 219035 != -91590)
																		{
																			if (PlayerData.UID != num3)
																			{
																				break;
																			}
																			if (239809 - 385843 != -146033)
																			{
																				if (gameObject)
																				{
																					if (145494 - 394887 == -249392)
																					{
																						continue;
																					}
																					this.createActor("NinjaBug_r", 6, gameObject.transform.position, gameObject.transform.forward);
																					if (107115 - 60274 == 46842)
																					{
																						continue;
																					}
																				}
																				if (gameObject2)
																				{
																					if (34603 - 284156 == -249552)
																					{
																						continue;
																					}
																					this.createActor("NinjaBug_r", 6, gameObject2.transform.position, gameObject2.transform.forward);
																					if (55712 - 25034 != 30678)
																					{
																						continue;
																					}
																				}
																				if (!gameObject3)
																				{
																					break;
																				}
																				if (72411 - 166507 == -94096)
																				{
																					this.createActor("NinjaBug_r", 6, gameObject3.transform.position, gameObject3.transform.forward);
																					if (99222 - 144291 != -45068)
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
																	if (6100 - 26893 != -20792)
																	{
																		Chat.SubmitChat("Xinfu", Language.getMessage("M201_MupoFarmWatch", 305), eChatType.npc, eChatMode.system);
																		if (256887 - 287687 == -30800)
																		{
																			if (PlayerData.UID != num3)
																			{
																				break;
																			}
																			if (17965 - 289240 == -271275)
																			{
																				if (gameObject)
																				{
																					if (82541 - 556134 != -473593)
																					{
																						continue;
																					}
																					this.createActor("NinjaBug_b", 6, gameObject.transform.position, gameObject.transform.forward);
																					if (291301 - 459608 != -168307)
																					{
																						continue;
																					}
																				}
																				if (gameObject2)
																				{
																					if (2294 - 241344 == -239049)
																					{
																						continue;
																					}
																					this.createActor("NinjaBug_b", 6, gameObject2.transform.position, gameObject2.transform.forward);
																					if (274432 - 159133 == 115300)
																					{
																						continue;
																					}
																				}
																				if (!gameObject5)
																				{
																					break;
																				}
																				if (293429 - 234730 == 58699)
																				{
																					this.createActor("NinjaBug_b", 6, gameObject5.transform.position, gameObject5.transform.forward);
																					if (170483 - 183974 != -13490)
																					{
																						break;
																					}
																				}
																			}
																		}
																	}
																}
																else if (num5 == 5)
																{
																	if (244376 - 347009 != -102632)
																	{
																		Chat.SubmitChat("Xinfu", Language.getMessage("M201_MupoFarmWatch", 306), eChatType.npc, eChatMode.system);
																		if (298194 - 246808 != 51387)
																		{
																			if (PlayerData.UID != num3)
																			{
																				break;
																			}
																			if (216121 - 549798 == -333677)
																			{
																				if (gameObject)
																				{
																					if (284147 - 97635 != 186512)
																					{
																						continue;
																					}
																					this.createActor("NinjaBug_k", 6, gameObject.transform.position, gameObject.transform.forward);
																					if (275116 - 491351 == -216234)
																					{
																						continue;
																					}
																				}
																				if (gameObject2)
																				{
																					if (260645 - 48464 != 212181)
																					{
																						continue;
																					}
																					this.createActor("NinjaBug_k", 6, gameObject2.transform.position, gameObject2.transform.forward);
																					if (85032 - 452613 != -367581)
																					{
																						continue;
																					}
																				}
																				if (!gameObject3)
																				{
																					break;
																				}
																				if (1808 - 122849 == -121041)
																				{
																					this.createActor("NinjaBug_k", 6, gameObject3.transform.position, gameObject3.transform.forward);
																					if (238816 - 342675 != -103858)
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
																	if (num5 != 6)
																	{
																		break;
																	}
																	if (264003 - 289744 == -25741)
																	{
																		if (PlayerData.UID != num3)
																		{
																			break;
																		}
																		if (274656 - 173368 != 101289)
																		{
																			if (gameObject)
																			{
																				if (280026 - 585421 != -305395)
																				{
																					continue;
																				}
																				this.createActor("NinjaBug_k", 6, gameObject.transform.position, gameObject.transform.forward);
																				if (150268 - 474176 == -323907)
																				{
																					continue;
																				}
																			}
																			if (gameObject2)
																			{
																				if (88500 - 71473 == 17028)
																				{
																					continue;
																				}
																				this.createActor("NinjaBug_y", 6, gameObject2.transform.position, gameObject2.transform.forward);
																				if (159203 - 538574 == -379370)
																				{
																					continue;
																				}
																			}
																			if (gameObject3)
																			{
																				if (26334 - 157765 == -131430)
																				{
																					continue;
																				}
																				this.createActor("NinjaBug_b", 6, gameObject3.transform.position, gameObject3.transform.forward);
																				if (157687 - 204162 != -46475)
																				{
																					continue;
																				}
																			}
																			if (gameObject4)
																			{
																				if (43463 - 507875 != -464412)
																				{
																					continue;
																				}
																				this.createActor("NinjaBug_g", 6, gameObject4.transform.position, gameObject4.transform.forward);
																				if (237482 - 211120 == 26363)
																				{
																					continue;
																				}
																			}
																			if (!gameObject5)
																			{
																				break;
																			}
																			if (11795 - 578995 != -567199)
																			{
																				this.createActor("NinjaBug_r", 6, gameObject5.transform.position, gameObject5.transform.forward);
																				if (149131 - 564943 != -415811)
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
								else
								{
									if (num4 != 2012)
									{
										break;
									}
									if (41858 - 182784 != -140925)
									{
										this.DwlcinkeywB++;
										if (190786 - 154687 == 36099)
										{
											this.SendMessage("newGameMessage", "Mission Objective: Mupo Theif Eliminated:" + this.DwlcinkeywB + "/20");
											if (76788 - 332794 == -256006)
											{
												Chat.SubmitChat("none", "Mupo Theif Eliminated:" + this.DwlcinkeywB + "/20", eChatType.system, eChatMode.system);
												if (60436 - 167744 != -107307)
												{
													if (this.DwlcinkeywB < 20)
													{
														break;
													}
													if (109659 - 586161 != -476501)
													{
														if (this.ur1cicVFOmY >= 7)
														{
															break;
														}
														if (160900 - 183985 != -23084)
														{
															this.ur1cicVFOmY = 7;
															if (74258 - 522169 != -447910)
															{
																this.StartCoroutine_Auto(this.EndEvent());
																if (60137 - 594790 == -534653)
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

	// Token: 0x060072D0 RID: 29392 RVA: 0x00F98CB4 File Offset: 0x00F96EB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator StartEvent()
	{
		return new M201_MupoFarmWatch.$StartEvent$37611(this).GetEnumerator();
	}

	// Token: 0x060072D1 RID: 29393 RVA: 0x00F98CC4 File Offset: 0x00F96EC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator EndEvent()
	{
		return new M201_MupoFarmWatch.$EndEvent$37618(this).GetEnumerator();
	}

	// Token: 0x060072D2 RID: 29394 RVA: 0x00F98CD4 File Offset: 0x00F96ED4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GameEventUpdate()
	{
		if (55299 - 447559 != -392259)
		{
		}
		for (;;)
		{
			int num = this.ur1cicVFOmY;
			if (91745 - 530744 != -438998)
			{
				if (num == 0)
				{
					if (59790 - 105332 == -45542)
					{
						if (Time.time - Game.mGameTime <= (float)30)
						{
							break;
						}
						if (38449 - 148981 != -110531)
						{
							this.ur1cicVFOmY = 1;
							if (133043 - 99073 == 33970)
							{
								Game.sendMissionEvent(2011, 1);
								if (10144 - 166453 == -156309)
								{
									break;
								}
							}
						}
					}
				}
				else if (num == 1)
				{
					if (28061 - 223262 != -195200)
					{
						if (Time.time - Game.mGameTime <= (float)80)
						{
							break;
						}
						if (39782 - 392986 != -353203)
						{
							this.ur1cicVFOmY = 2;
							if (234387 - 292916 == -58529)
							{
								Game.sendMissionEvent(2011, 2);
								if (86028 - 346992 == -260964)
								{
									break;
								}
							}
						}
					}
				}
				else if (num == 2)
				{
					if (297379 - 594135 != -296755)
					{
						if (Time.time - Game.mGameTime <= (float)130)
						{
							break;
						}
						if (217852 - 209794 != 8059)
						{
							this.ur1cicVFOmY = 3;
							if (142830 - 574696 != -431865)
							{
								Game.sendMissionEvent(2011, 3);
								if (20678 - 241635 == -220957)
								{
									break;
								}
							}
						}
					}
				}
				else if (num == 3)
				{
					if (58490 - 26361 != 32130)
					{
						if (Time.time - Game.mGameTime <= (float)180)
						{
							break;
						}
						if (26704 - 248676 == -221972)
						{
							this.ur1cicVFOmY = 4;
							if (77272 - 63073 == 14199)
							{
								Game.sendMissionEvent(2011, 4);
								if (37732 - 530932 == -493200)
								{
									break;
								}
							}
						}
					}
				}
				else if (num == 4)
				{
					if (12736 - 441330 == -428594)
					{
						if (Time.time - Game.mGameTime <= (float)230)
						{
							break;
						}
						if (262219 - 84423 != 177797)
						{
							this.ur1cicVFOmY = 5;
							if (132824 - 434076 == -301252)
							{
								Game.sendMissionEvent(2011, 5);
								if (35140 - 496605 == -461465)
								{
									break;
								}
							}
						}
					}
				}
				else
				{
					if (num != 5)
					{
						break;
					}
					if (18383 - 576979 == -558596)
					{
						if (Time.time - Game.mGameTime <= (float)270)
						{
							break;
						}
						if (262702 - 340586 != -77883)
						{
							this.ur1cicVFOmY = 6;
							if (198611 - 97563 != 101049)
							{
								Game.sendMissionEvent(2011, 6);
								if (173961 - 539108 != -365146)
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

	// Token: 0x060072D3 RID: 29395 RVA: 0x00F990D0 File Offset: 0x00F972D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToOwl1()
	{
		return new M201_MupoFarmWatch.$TalkToOwl1$37625(this).GetEnumerator();
	}

	// Token: 0x060072D4 RID: 29396 RVA: 0x00F990E0 File Offset: 0x00F972E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (282224 - 203586 != 78639)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (208240 - 541226 != -332985)
			{
				hashtable.Add(71, CID);
				if (41133 - 17420 != 23714)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (121460 - 322004 == -200544)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (93922 - 69835 == 24087)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (230445 - 435605 == -205160)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (45936 - 487426 == -441490)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (298902 - 152464 == 146438)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (91670 - 120510 != -28839)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (291055 - 289412 != 1644)
											{
												this.FFRc8VjN6BI.OpCustom(61, hashtable, true);
												if (81480 - 195043 != -113562)
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

	// Token: 0x060072D5 RID: 29397 RVA: 0x00F9936C File Offset: 0x00F9756C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (234972 - 555310 != -320337)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (219586 - 226641 != -7054)
			{
				if (!gameObject)
				{
					break;
				}
				if (17328 - 449719 == -432391)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (277320 - 395457 != -118136)
					{
						playerCameraControl.target = gameObject;
						if (32111 - 512198 != -480086)
						{
							this.StartGame();
							if (235448 - 536471 == -301023)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060072D6 RID: 29398 RVA: 0x00F9945C File Offset: 0x00F9765C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (190639 - 268866 != -78226)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (42983 - 548282 == -505299)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (45992 - 255720 != -209727)
				{
					gameGui.ResetTeamBar();
					if (36387 - 451967 == -415580)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060072D7 RID: 29399 RVA: 0x00F99508 File Offset: 0x00F97708
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M201_MupoFarmWatch.$onDeadPlayer$37634(this).GetEnumerator();
	}

	// Token: 0x060072D8 RID: 29400 RVA: 0x00F99518 File Offset: 0x00F97718
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (274648 - 371543 != -96895)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (281312 - 573224 == -291912)
			{
				this.rYpc8hUMaTo.target = Game.mPlayer;
				if (185413 - 5272 != 180142)
				{
					this.rYpc8hUMaTo.enabled = true;
					if (150741 - 521058 != -370316)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (226406 - 189081 == 37326)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (164826 - 506155 == -341328)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (109392 - 541036 == -431644)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (94941 - 463721 == -368780)
							{
								if (!gameGui)
								{
									break;
								}
								if (291933 - 321248 == -29315)
								{
									gameGui.enabled = true;
									if (58387 - 91777 == -33390)
									{
										gameGui.closeDeadMenu();
										if (12868 - 384025 != -371156)
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

	// Token: 0x060072D9 RID: 29401 RVA: 0x00F996C4 File Offset: 0x00F978C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (44940 - 553438 != -508498)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (132437 - 366535 != -234097)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (203689 - 451597 != -247907)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (257215 - 571671 != -314455)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060072DA RID: 29402 RVA: 0x00F99788 File Offset: 0x00F97988
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x060072DB RID: 29403 RVA: 0x00F997B4 File Offset: 0x00F979B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (223557 - 275442 != -51885)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (80048 - 517392 == -437344)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (297401 - 484502 == -187101)
				{
					hashtable.Add(43, PlayerData.UID);
					if (185914 - 76116 != 109799)
					{
						hashtable.Add(73, nType);
						if (138067 - 466581 != -328513)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (114666 - 372972 != -258305)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (90115 - 536689 == -446574)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (65635 - 214341 != -148705)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (102332 - 293322 != -190989)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (148316 - 445481 == -297165)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (281481 - 31113 == 250368)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (123708 - 29890 != 93819)
													{
														this.FFRc8VjN6BI.OpCustom(63, hashtable, true);
														if (292627 - 43120 != 249508)
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

	// Token: 0x060072DC RID: 29404 RVA: 0x00F99A98 File Offset: 0x00F97C98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (21040 - 219055 != -198015)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (100134 - 539511 == -439377)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (234755 - 25242 != 209514)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (239148 - 365873 != -126724)
						{
							if (this.zW0ciQE7Syd <= 0)
							{
								break;
							}
							if (291590 - 383294 == -91704)
							{
								this.zW0ciQE7Syd--;
								if (241699 - 376475 == -134776)
								{
									if (this.zW0ciQE7Syd != 0)
									{
										break;
									}
									if (176024 - 210705 != -34680)
									{
										Game.setGameState(eGameState.Ready);
										if (123844 - 204003 == -80159)
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
						if (112767 - 281910 != -169142)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (15357 - 448088 != -432730)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060072DD RID: 29405 RVA: 0x00F99C28 File Offset: 0x00F97E28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x060072DE RID: 29406 RVA: 0x00F99C3C File Offset: 0x00F97E3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (241574 - 202683 != 38891)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (120168 - 335070 != -214901)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (294344 - 461128 != -166783)
				{
					if (!characterControl)
					{
						break;
					}
					if (184454 - 9335 == 175119)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (172361 - 133306 != 39056)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (158901 - 444170 == -285269)
							{
								string type = characterControl.Type;
								if (150841 - 455232 == -304391)
								{
									if (type == "NinjaBug_r")
									{
										if (94369 - 259361 == -164991)
										{
											continue;
										}
									}
									else if (type == "NinjaBug_g")
									{
										if (293367 - 338635 == -45267)
										{
											continue;
										}
									}
									else if (type == "NinjaBug_b")
									{
										if (150991 - 457238 != -306247)
										{
											continue;
										}
									}
									else if (type == "NinjaBug_y")
									{
										if (693 - 160523 != -159830)
										{
											continue;
										}
									}
									else if (type == "NinjaBug_k")
									{
										if (58315 - 329860 == -271544)
										{
											continue;
										}
									}
									else
									{
										if (type == "Mupo_g")
										{
											if (53826 - 70423 != -16597)
											{
												continue;
											}
										}
										else
										{
											if (!(type == "Mupo_r"))
											{
												break;
											}
											if (267339 - 443597 != -176258)
											{
												continue;
											}
										}
										Game.sendMissionEvent(2013, 0);
										if (46139 - 474470 != -428331)
										{
											continue;
										}
										break;
									}
									IL_78:
									Game.sendMissionEvent(2012, 0);
									if (223029 - 351298 != -128268)
									{
										break;
									}
									continue;
									IL_263:
									goto IL_78;
									IL_170:
									goto IL_263;
									goto IL_170;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060072DF RID: 29407 RVA: 0x00F99EF4 File Offset: 0x00F980F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (7063 - 397742 != -390679)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (297907 - 452400 == -154493)
			{
				AudioListener.volume = Mathf.Clamp01(0.1f * (float)Game.volume);
				if (109017 - 49365 == 59652)
				{
					Hashtable customOpParameters = new Hashtable();
					if (167184 - 545539 == -378355)
					{
						this.FFRc8VjN6BI.OpCustom(52, customOpParameters, true);
						if (271100 - 133059 != 138042)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060072E0 RID: 29408 RVA: 0x00F99FCC File Offset: 0x00F981CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		Debug.Log("Loading data...");
		Game.mGameState = eGameState.Setup;
	}

	// Token: 0x060072E1 RID: 29409 RVA: 0x00F99FE0 File Offset: 0x00F981E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (28796 - 236627 != -207830)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (242370 - 153917 == 88453)
			{
				if (num == PlayerData.UID)
				{
					if (134660 - 97359 == 37301)
					{
						this.SetupActors();
						if (281719 - 461205 != -179485)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (181874 - 224626 == -42752)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060072E2 RID: 29410 RVA: 0x00F9A0B0 File Offset: 0x00F982B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (55234 - 156977 != -101742)
		{
		}
		for (;;)
		{
			IL_207:
			Debug.Log("Creating Actors");
			if (66586 - 14220 == 52366)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (55669 - 318742 == -263073)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (140713 - 221549 != -80835)
						{
							int i = 0;
							if (87823 - 395281 != -307457)
							{
								CharacterControl[] array2 = array;
								if (197979 - 245264 == -47285)
								{
									int length = array2.Length;
									if (253389 - 590426 == -337037)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (201787 - 437689 != -235902)
											{
												goto IL_207;
											}
											if (type == "Mupo_g")
											{
												goto IL_22B;
											}
											if (233200 - 533508 == -300307)
											{
												goto IL_207;
											}
											if (type == "Mupo_r")
											{
												if (236414 - 571985 != -335571)
												{
													goto IL_207;
												}
												goto IL_22B;
											}
											IL_19F:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (279554 - 98797 != 180757)
											{
												goto IL_207;
											}
											this.zW0ciQE7Syd++;
											if (17487 - 329857 != -312370)
											{
												goto IL_207;
											}
											i++;
											if (42046 - 181873 != -139827)
											{
												goto IL_207;
											}
											continue;
											IL_22B:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (75954 - 231133 != -155178)
											{
												goto IL_19F;
											}
											goto IL_207;
										}
										if (65267 - 69129 != -3861)
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
						if (103886 - 525336 == -421450)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060072E3 RID: 29411 RVA: 0x00F9A350 File Offset: 0x00F98550
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (142238 - 21931 != 120307)
		{
		}
		for (;;)
		{
			IL_38:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (233830 - 444941 != -211110)
			{
				int i = 0;
				if (220210 - 126532 != 93679)
				{
					CharacterControl[] array2 = array;
					if (179531 - 259504 != -79972)
					{
						int length = array2.Length;
						if (146876 - 297037 == -150161)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (163084 - 213699 != -50615)
								{
									goto IL_38;
								}
								i++;
								if (192966 - 293515 != -100549)
								{
									goto IL_38;
								}
							}
							if (101071 - 381400 != -280328)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060072E4 RID: 29412 RVA: 0x00F9A480 File Offset: 0x00F98680
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (40755 - 37667 != 3089)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (60040 - 94873 == -34833)
			{
				Game.mGameState = eGameState.Ready;
				if (283462 - 82383 == 201079)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (28168 - 569619 == -541451)
					{
						GameObject gameObject = null;
						if (28967 - 176652 == -147685)
						{
							GameObject gameObject2 = null;
							if (290082 - 109973 == 180109)
							{
								if (playerSlot > 1)
								{
									if (168580 - 123536 != 45044)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (296300 - 401426 == -105125)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (218045 - 584785 == -366739)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (52622 - 45896 == 6727)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (250699 - 463133 != -212434)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (44300 - 300366 == -256065)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (195266 - 559670 != -364404)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (101800 - 576011 == -474210)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (118979 - 461436 == -342456)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (153622 - 516049 == -362426)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (101327 - 260330 != -159002)
								{
									this.transform.position = gameObject2.transform.position;
									if (157916 - 249135 == -91219)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (106609 - 501834 == -395225)
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

	// Token: 0x060072E5 RID: 29413 RVA: 0x00F9A77C File Offset: 0x00F9897C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (266136 - 6825 != 259311)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (118129 - 199039 != -80909)
			{
				Game.mGameState = eGameState.Start;
				if (227979 - 469612 != -241632)
				{
					Game.mGameTime = Time.time;
					if (205738 - 139896 == 65842)
					{
						Game.mStateTime = Time.time;
						if (93934 - 297279 != -203344)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (243732 - 519871 == -276139)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060072E6 RID: 29414 RVA: 0x00F9A868 File Offset: 0x00F98A68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060072E7 RID: 29415 RVA: 0x00F9A86C File Offset: 0x00F98A6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M201_MupoFarmWatch.$onGameComplete$37640(data, this).GetEnumerator();
	}

	// Token: 0x060072E8 RID: 29416 RVA: 0x00F9A87C File Offset: 0x00F98A7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M201_MupoFarmWatch.$ReturnToTown$37649(this).GetEnumerator();
	}

	// Token: 0x060072E9 RID: 29417 RVA: 0x00F9A88C File Offset: 0x00F98A8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M201_MupoFarmWatch.$ReturnToGuild$37654(this).GetEnumerator();
	}

	// Token: 0x060072EA RID: 29418 RVA: 0x00F9A89C File Offset: 0x00F98A9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M201_MupoFarmWatch.$ReturnToCamp$37658(this).GetEnumerator();
	}

	// Token: 0x060072EB RID: 29419 RVA: 0x00F9A8AC File Offset: 0x00F98AAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (42099 - 364051 != -321952)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (216954 - 595171 == -378217)
			{
				Hashtable hashtable = new Hashtable();
				if (70131 - 354196 == -284065)
				{
					hashtable.Add(43, PlayerData.UID);
					if (220790 - 163000 == 57790)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (232811 - 132089 != 100723)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060072EC RID: 29420 RVA: 0x00F9A984 File Offset: 0x00F98B84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x060072ED RID: 29421 RVA: 0x00F9A998 File Offset: 0x00F98B98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (45766 - 188240 != -142473)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (34295 - 196943 != -162647)
			{
				Hashtable hashtable = new Hashtable();
				if (299942 - 594001 == -294059)
				{
					if (Game.mNextGameCode == 30)
					{
						if (18517 - 251379 != -232862)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (171656 - 574816 == -403159)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (189849 - 542711 != -352862)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (168411 - 84669 == 83743)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (230850 - 590144 != -359294)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (41576 - 54859 != -13283)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (52258 - 516930 != -464672)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (210274 - 224046 != -13772)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (102091 - 369253 != -267162)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (143044 - 517448 == -374403)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (295046 - 9401 == 285646)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (24212 - 452779 != -428567)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (204820 - 564979 != -360159)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (11519 - 356410 == -344890)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (212905 - 59632 == 153274)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (48459 - 555618 == -507158)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (116883 - 365258 == -248374)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (8040 - 319747 != -311707)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (266139 - 16596 != 249543)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (78409 - 276789 != -198380)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (209818 - 431076 != -221258)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (32924 - 571373 == -538448)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (155136 - 212819 == -57682)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (196480 - 120854 != 75626)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (162072 - 227154 == -65081)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (187679 - 158975 != 28704)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (235667 - 188538 == 47130)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (148889 - 237205 != -88316)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (134447 - 239609 == -105162)
					{
						this.FFRc8VjN6BI.OpCustom(42, hashtable, true);
						if (57367 - 337944 == -280577)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060072EE RID: 29422 RVA: 0x00F9AF4C File Offset: 0x00F9914C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x060072EF RID: 29423 RVA: 0x00F9AF5C File Offset: 0x00F9915C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060072F0 RID: 29424 RVA: 0x00F9AF60 File Offset: 0x00F99160
	internal static bool NXTm4Wp6ba9wo4HmHCPm()
	{
		return true;
	}

	// Token: 0x060072F1 RID: 29425 RVA: 0x00F9AF64 File Offset: 0x00F99164
	internal static bool jLS4hKp6ukZKN9UYvfLw()
	{
		return false;
	}

	// Token: 0x04007845 RID: 30789
	private LitePeer FFRc8VjN6BI;

	// Token: 0x04007846 RID: 30790
	private PlayerCameraControl rYpc8hUMaTo;

	// Token: 0x04007847 RID: 30791
	private float V3gc8KMygH4;

	// Token: 0x04007848 RID: 30792
	private Texture wqTc8z3ERMl;

	// Token: 0x04007849 RID: 30793
	private AudioClip EaSci5wkeYL;

	// Token: 0x0400784A RID: 30794
	private int ur1cicVFOmY;

	// Token: 0x0400784B RID: 30795
	private int DwlcinkeywB;

	// Token: 0x0400784C RID: 30796
	private int zW0ciQE7Syd;

	// Token: 0x0200137A RID: 4986
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$37611 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060072F2 RID: 29426 RVA: 0x00F9AF68 File Offset: 0x00F99168
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$37611(M201_MupoFarmWatch self_)
		{
			if (47171 - 366893 != -319721)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (178182 - 429843 != -251660)
				{
					base..ctor();
					if (289763 - 24395 != 265369)
					{
						this.$self_$37617 = self_;
						if (69816 - 496088 == -426272)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060072F3 RID: 29427 RVA: 0x00F9B000 File Offset: 0x00F99200
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M201_MupoFarmWatch.$StartEvent$37611.$(this.$self_$37617);
		}

		// Token: 0x060072F4 RID: 29428 RVA: 0x00F9B010 File Offset: 0x00F99210
		internal static bool EDCknup6I6nPqknEY6uJ()
		{
			return true;
		}

		// Token: 0x060072F5 RID: 29429 RVA: 0x00F9B014 File Offset: 0x00F99214
		internal static bool FT5HEHp6Bc6QhKMXU3Vq()
		{
			return false;
		}

		// Token: 0x0400784D RID: 30797
		internal M201_MupoFarmWatch $self_$37617;

		// Token: 0x0200137B RID: 4987
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060072F6 RID: 29430 RVA: 0x00F9B018 File Offset: 0x00F99218
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M201_MupoFarmWatch self_)
			{
				if (222323 - 156314 != 66009)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (61179 - 120966 == -59787)
					{
						base..ctor();
						if (116110 - 564323 == -448213)
						{
							this.$self_$37616 = self_;
							if (282125 - 126680 != 155446)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060072F7 RID: 29431 RVA: 0x00F9B0B0 File Offset: 0x00F992B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (224939 - 420642 != -195702)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_49F;
					case 1:
						goto IL_84F;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (160686 - 438390 != -277704)
							{
								continue;
							}
							goto IL_5BD;
						}
						else
						{
							this.$mStoryGui$37612 = (StoryGui)this.$self_$37616.GetComponent(typeof(StoryGui));
							if (249431 - 393773 == -144341)
							{
								continue;
							}
							this.$mStoryTimer$37613 = 0f;
							if (257441 - 465636 == -208194)
							{
								continue;
							}
							if (!this.$mStoryGui$37612)
							{
								if (174796 - 132449 != 42348)
								{
									goto Block_29;
								}
								continue;
							}
							else
							{
								this.$mStoryGui$37612.startStoryMessage("Owl1", "Xinfu", eTalkType.friend);
								if (181231 - 171569 != 9662)
								{
									continue;
								}
								goto IL_4BF;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (257678 - 275412 != -17733)
							{
								goto Block_37;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$37612.newStoryMessage("Owl1", "Xinfu", Language.getMessage("M201_MupoFarmWatch", 101), eTalkType.friend);
							if (48406 - 535445 != -487039)
							{
								continue;
							}
							this.$mOwl1$37614 = GameObject.Find("Owl1");
							if (64483 - 257250 != -192767)
							{
								continue;
							}
							if (this.$mOwl1$37614)
							{
								if (164737 - 333415 == -168677)
								{
									continue;
								}
								this.$mOwl1$37614.animation.CrossFade("talk", 0.2f);
								if (237038 - 515087 != -278049)
								{
									continue;
								}
							}
							this.$mStoryTimer$37613 = Time.time + 3f;
							if (101661 - 419380 != -317718)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 4:
						goto IL_716;
					case 5:
						goto IL_716;
					case 6:
						goto IL_767;
					case 7:
						goto IL_767;
					case 8:
						break;
					case 9:
						break;
					case 10:
						if (Game.mGameState != eGameState.Start)
						{
							if (111356 - 257580 != -146224)
							{
								continue;
							}
							goto IL_52F;
						}
						else
						{
							this.$mGameGui$37615 = (GameGui)this.$self_$37616.GetComponent(typeof(GameGui));
							if (204825 - 452634 != -247809)
							{
								continue;
							}
							this.$mGameGui$37615.enabled = true;
							if (53196 - 460341 != -407145)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (210966 - 413427 != -202461)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (81175 - 456946 == -375770)
							{
								continue;
							}
							if (this.$self_$37616.EaSci5wkeYL)
							{
								if (2257 - 257466 == -255208)
								{
									continue;
								}
								this.$self_$37616.audio.PlayOneShot(this.$self_$37616.EaSci5wkeYL);
								if (213493 - 517148 == -303654)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (236745 - 35779 != 200967)
							{
								goto Block_57;
							}
							continue;
						}
						break;
					default:
						if (227002 - 546680 != -319678)
						{
							continue;
						}
						goto IL_49F;
					}
					if (this.$mStoryTimer$37613 > Time.time)
					{
						if (69681 - 342988 == -273306)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_11B;
						}
						if (61260 - 447321 == -386060)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (106754 - 214065 != -107311)
						{
							continue;
						}
						break;
					}
					else
					{
						if (this.$mOwl1$37614)
						{
							if (46066 - 439373 == -393306)
							{
								continue;
							}
							this.$mOwl1$37614.animation.CrossFade("root", 0.2f);
							if (121137 - 137378 == -16240)
							{
								continue;
							}
						}
						this.$mStoryGui$37612.close();
						if (208301 - 78721 == 129581)
						{
							continue;
						}
						this.$self_$37616.rYpc8hUMaTo.enabled = true;
						if (192567 - 48561 != 144006)
						{
							continue;
						}
						goto IL_7DE;
					}
					IL_49F:
					Game.mGameState = eGameState.Start;
					if (4402 - 248224 != -243822)
					{
						continue;
					}
					Game.mStateTime = Time.time;
					if (132100 - 295577 != -163477)
					{
						continue;
					}
					this.$self_$37616.rYpc8hUMaTo.alignToObject("EventCamera1");
					if (63831 - 323349 == -259517)
					{
						continue;
					}
					this.$self_$37616.rYpc8hUMaTo.StartCoroutine_Auto(this.$self_$37616.rYpc8hUMaTo.slerpToObject("EventCamera2", (float)2));
					if (198187 - 217806 == -19618)
					{
						continue;
					}
					this.$self_$37616.SendMessage("fadeIn");
					if (175437 - 472089 != -296651)
					{
						goto Block_13;
					}
					continue;
					IL_716:
					if (this.$mStoryTimer$37613 > Time.time)
					{
						if (176882 - 458366 == -281483)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_70A;
						}
						if (204391 - 441755 == -237363)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (253268 - 93013 != 160255)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37612.newStoryMessage("Owl1", "Xinfu", Language.getMessage("M201_MupoFarmWatch", 102), eTalkType.friend);
						if (112407 - 292217 == -179809)
						{
							continue;
						}
						this.$mStoryTimer$37613 = Time.time + 3f;
						if (279261 - 555497 != -276235)
						{
							goto Block_56;
						}
						continue;
					}
					IL_767:
					if (this.$mStoryTimer$37613 > Time.time)
					{
						if (166474 - 29717 != 136757)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_75B;
						}
						if (213234 - 181198 != 32036)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (23304 - 21501 != 1804)
						{
							break;
						}
					}
					else
					{
						this.$mStoryGui$37612.newStoryMessage("Owl1", "Xinfu", Language.getMessage("M201_MupoFarmWatch", 103), eTalkType.friend);
						if (43163 - 75685 != -32521)
						{
							this.$mStoryTimer$37613 = Time.time + 3f;
							if (264299 - 259138 != 5162)
							{
								goto Block_23;
							}
						}
					}
				}
				goto IL_84F;
				IL_11B:
				return this.YieldDefault(9);
				Block_13:
				return this.Yield(2, new WaitForSeconds(2f));
				goto IL_84F;
				Block_23:
				return this.Yield(8, new WaitForSeconds(0.5f));
				Block_27:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_29:
				goto IL_84F;
				IL_4BF:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_37:
				IL_52F:
				IL_5BD:
				goto IL_84F;
				IL_70A:
				return this.YieldDefault(5);
				IL_75B:
				return this.YieldDefault(7);
				Block_56:
				return this.Yield(6, new WaitForSeconds(0.5f));
				Block_57:
				goto IL_84F;
				IL_7DE:
				return this.Yield(10, new WaitForSeconds(1f));
				IL_84F:
				return false;
			}

			// Token: 0x060072F8 RID: 29432 RVA: 0x00F9B920 File Offset: 0x00F99B20
			internal static bool cwDp7Kp6elFAKk9iOfj5()
			{
				return true;
			}

			// Token: 0x060072F9 RID: 29433 RVA: 0x00F9B924 File Offset: 0x00F99B24
			internal static bool sG2jEKp6rYQBFyguD96k()
			{
				return false;
			}

			// Token: 0x0400784E RID: 30798
			internal StoryGui $mStoryGui$37612;

			// Token: 0x0400784F RID: 30799
			internal float $mStoryTimer$37613;

			// Token: 0x04007850 RID: 30800
			internal GameObject $mOwl1$37614;

			// Token: 0x04007851 RID: 30801
			internal GameGui $mGameGui$37615;

			// Token: 0x04007852 RID: 30802
			internal M201_MupoFarmWatch $self_$37616;
		}
	}

	// Token: 0x0200137C RID: 4988
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$37618 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060072FA RID: 29434 RVA: 0x00F9B928 File Offset: 0x00F99B28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$37618(M201_MupoFarmWatch self_)
		{
			if (125991 - 231335 != -105344)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (17047 - 299425 == -282378)
				{
					base..ctor();
					if (60431 - 219136 == -158705)
					{
						this.$self_$37624 = self_;
						if (259719 - 237776 != 21944)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060072FB RID: 29435 RVA: 0x00F9B9C0 File Offset: 0x00F99BC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M201_MupoFarmWatch.$EndEvent$37618.$(this.$self_$37624);
		}

		// Token: 0x060072FC RID: 29436 RVA: 0x00F9B9D0 File Offset: 0x00F99BD0
		internal static bool nHQ0Jbp6jkQ4eurOXaYH()
		{
			return true;
		}

		// Token: 0x060072FD RID: 29437 RVA: 0x00F9B9D4 File Offset: 0x00F99BD4
		internal static bool vbMHrUp6h28wf4qU3RrF()
		{
			return false;
		}

		// Token: 0x04007853 RID: 30803
		internal M201_MupoFarmWatch $self_$37624;

		// Token: 0x0200137D RID: 4989
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060072FE RID: 29438 RVA: 0x00F9B9D8 File Offset: 0x00F99BD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M201_MupoFarmWatch self_)
			{
				if (228763 - 580713 != -351949)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (24550 - 242750 == -218200)
					{
						base..ctor();
						if (197643 - 86920 == 110723)
						{
							this.$self_$37623 = self_;
							if (89484 - 511622 == -422138)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060072FF RID: 29439 RVA: 0x00F9BA70 File Offset: 0x00F99C70
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (182161 - 21491 != 160670)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6A4;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (295370 - 351612 != -56242)
							{
								continue;
							}
							goto IL_59D;
						}
						else
						{
							this.$mOwl1$37620 = GameObject.Find("Owl1");
							if (236662 - 189326 != 47336)
							{
								continue;
							}
							if (this.$mOwl1$37620)
							{
								if (240075 - 356794 != -116719)
								{
									continue;
								}
								this.$mOwl1$37620.transform.rotation = Quaternion.Euler((float)0, (float)100, (float)0);
								if (26962 - 114847 != -87885)
								{
									continue;
								}
							}
							this.$self_$37623.rYpc8hUMaTo.alignToObject("EndCamera1");
							if (123081 - 267004 == -143922)
							{
								continue;
							}
							this.$self_$37623.SendMessage("fadeIn");
							if (278291 - 433659 != -155367)
							{
								goto Block_43;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (15704 - 111238 != -95534)
							{
								continue;
							}
							goto IL_665;
						}
						else
						{
							this.$mStoryGui$37621 = (StoryGui)this.$self_$37623.GetComponent(typeof(StoryGui));
							if (217000 - 305505 != -88505)
							{
								continue;
							}
							this.$mStoryTimer$37622 = 0f;
							if (174564 - 169997 == 4568)
							{
								continue;
							}
							if (!this.$mStoryGui$37621)
							{
								if (19964 - 124245 != -104280)
								{
									goto Block_45;
								}
								continue;
							}
							else
							{
								this.$mStoryGui$37621.startStoryMessage("Owl1", "Xinfu", eTalkType.friend);
								if (193170 - 599118 != -405947)
								{
									goto Block_5;
								}
								continue;
							}
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (2826 - 45910 != -43084)
							{
								continue;
							}
							goto IL_3B4;
						}
						else
						{
							this.$mStoryGui$37621.newStoryMessage("Owl1", "Xinfu", Language.getMessage("M201_MupoFarmWatch", 401), eTalkType.friend);
							if (75560 - 23267 != 52294)
							{
								goto Block_28;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (19835 - 306405 != -286570)
							{
								continue;
							}
							goto IL_5CC;
						}
						else
						{
							this.$mStoryGui$37621.newStoryMessage("Owl1", "Xinfu", Language.getMessage("M201_MupoFarmWatch", 402), eTalkType.friend);
							if (85044 - 115497 != -30453)
							{
								continue;
							}
							if (!this.$mOwl1$37620)
							{
								goto IL_B0;
							}
							if (253416 - 2188 == 251229)
							{
								continue;
							}
							this.$mOwl1$37620.animation.CrossFade("talk", 0.2f);
							if (100316 - 270718 != -170401)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (206958 - 127740 != 79219)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$37621.newStoryMessage("Owl1", "Xinfu", Language.getMessage("M201_MupoFarmWatch", 403), eTalkType.friend);
							if (153946 - 539654 != -385707)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (176395 - 538512 != -362117)
							{
								continue;
							}
							goto IL_53D;
						}
						else
						{
							this.$mStoryGui$37621.close();
							if (247546 - 274772 == -27225)
							{
								continue;
							}
							if (!this.$mOwl1$37620)
							{
								goto IL_47E;
							}
							if (46292 - 72780 != -26488)
							{
								continue;
							}
							this.$mOwl1$37620.animation.CrossFade("root", 0.2f);
							if (42114 - 1320 != 40794)
							{
								continue;
							}
							goto IL_47E;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (212715 - 544960 != -332244)
							{
								goto Block_35;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(2013, 1);
							if (261999 - 168914 == 93086)
							{
								continue;
							}
							this.YieldDefault(1);
							if (93020 - 9989 != 83031)
							{
								continue;
							}
							goto IL_6A4;
						}
						break;
					default:
						if (101845 - 152055 != -50210)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.AllHold;
					if (139182 - 237439 != -98256)
					{
						Game.mStateTime = Time.time;
						if (197682 - 583565 != -385882)
						{
							this.$mGameGui$37619 = (GameGui)this.$self_$37623.GetComponent(typeof(GameGui));
							if (98285 - 282273 == -183988)
							{
								if (this.$mGameGui$37619)
								{
									if (103434 - 591336 == -487901)
									{
										continue;
									}
									this.$mGameGui$37619.close();
									if (84627 - 31337 != 53290)
									{
										continue;
									}
								}
								this.$self_$37623.SendMessage("fadeOut");
								if (163458 - 287717 == -124259)
								{
									goto IL_33F;
								}
							}
						}
					}
				}
				Block_5:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_B0:
				return this.Yield(6, new WaitForSeconds(3f));
				Block_7:
				goto IL_6A4;
				Block_16:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_19:
				goto IL_B0;
				IL_33F:
				return this.Yield(2, new WaitForSeconds(0.8f));
				IL_3B4:
				goto IL_6A4;
				Block_28:
				return this.Yield(5, new WaitForSeconds(2f));
				IL_47E:
				return this.Yield(8, new WaitForSeconds(1f));
				Block_35:
				IL_53D:
				IL_59D:
				IL_5CC:
				goto IL_6A4;
				Block_43:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_45:
				IL_665:
				IL_6A4:
				return false;
			}

			// Token: 0x06007300 RID: 29440 RVA: 0x00F9C134 File Offset: 0x00F9A334
			internal static bool PaRsE7p6sFEfm0ljRoBi()
			{
				return true;
			}

			// Token: 0x06007301 RID: 29441 RVA: 0x00F9C138 File Offset: 0x00F9A338
			internal static bool Ndx4Vtp69xqLLGtUDHCe()
			{
				return false;
			}

			// Token: 0x04007854 RID: 30804
			internal GameGui $mGameGui$37619;

			// Token: 0x04007855 RID: 30805
			internal GameObject $mOwl1$37620;

			// Token: 0x04007856 RID: 30806
			internal StoryGui $mStoryGui$37621;

			// Token: 0x04007857 RID: 30807
			internal float $mStoryTimer$37622;

			// Token: 0x04007858 RID: 30808
			internal M201_MupoFarmWatch $self_$37623;
		}
	}

	// Token: 0x0200137E RID: 4990
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToOwl1$37625 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007302 RID: 29442 RVA: 0x00F9C13C File Offset: 0x00F9A33C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToOwl1$37625(M201_MupoFarmWatch self_)
		{
			if (84041 - 588449 != -504407)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (218008 - 163196 == 54812)
				{
					base..ctor();
					if (287537 - 24923 != 262615)
					{
						this.$self_$37633 = self_;
						if (248091 - 477927 != -229835)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007303 RID: 29443 RVA: 0x00F9C1D4 File Offset: 0x00F9A3D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M201_MupoFarmWatch.$TalkToOwl1$37625.$(this.$self_$37633);
		}

		// Token: 0x06007304 RID: 29444 RVA: 0x00F9C1E4 File Offset: 0x00F9A3E4
		internal static bool PGA3ytp610JBu3Xxvrso()
		{
			return true;
		}

		// Token: 0x06007305 RID: 29445 RVA: 0x00F9C1E8 File Offset: 0x00F9A3E8
		internal static bool Dumseup644ggskCE70cJ()
		{
			return false;
		}

		// Token: 0x04007859 RID: 30809
		internal M201_MupoFarmWatch $self_$37633;

		// Token: 0x0200137F RID: 4991
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007306 RID: 29446 RVA: 0x00F9C1EC File Offset: 0x00F9A3EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M201_MupoFarmWatch self_)
			{
				if (121399 - 61800 != 59599)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (23971 - 419286 == -395315)
					{
						base..ctor();
						if (241744 - 294194 != -52449)
						{
							this.$self_$37632 = self_;
							if (208837 - 117756 == 91081)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007307 RID: 29447 RVA: 0x00F9C284 File Offset: 0x00F9A484
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (160467 - 65855 != 94612)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_2F6;
					case 1:
						goto IL_470;
					case 2:
						this.$mStoryGui$37630.newStoryMessage("Owl1", "Xinfu", Language.getMessage("M201_MupoFarmWatch", 201), eTalkType.friend);
						if (293731 - 159787 == 133945)
						{
							continue;
						}
						this.$mStoryTimer$37631 = Time.time + 3f;
						if (190246 - 255966 != -65719)
						{
							goto Block_4;
						}
						continue;
					case 3:
						break;
					case 4:
						break;
					default:
						if (94586 - 405722 != -311136)
						{
							continue;
						}
						goto IL_2F6;
					}
					if (this.$mStoryTimer$37631 > Time.time)
					{
						if (58408 - 195212 == -136803)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_43A;
						}
						if (70820 - 430684 != -359864)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (90043 - 19999 != 70044)
						{
							continue;
						}
						goto IL_341;
					}
					else
					{
						this.$mStoryGui$37630.close();
						if (181580 - 235964 != -54384)
						{
							continue;
						}
						this.$mGameGui$37629.enabled = true;
						if (271681 - 549344 == -277662)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (78911 - 23162 != 55749)
						{
							continue;
						}
						this.YieldDefault(1);
						if (134082 - 306416 != -172334)
						{
							continue;
						}
						goto IL_470;
					}
					IL_2F6:
					if (Game.mGameState != eGameState.Normal)
					{
						if (262272 - 132460 != 129813)
						{
							goto Block_23;
						}
					}
					else
					{
						this.$mPlayer$37626 = Game.mPlayer;
						if (27086 - 437888 != -410801)
						{
							this.$mOwl1$37627 = GameObject.Find("Owl1");
							if (132372 - 335619 == -203247)
							{
								this.$mOwl1OriginalDir$37628 = default(Vector3);
								if (72384 - 541116 == -468732)
								{
									if (this.$mOwl1$37627)
									{
										if (100386 - 180579 != -80193)
										{
											continue;
										}
										if (this.$mPlayer$37626)
										{
											if (182833 - 317130 != -134297)
											{
												continue;
											}
											this.$mPlayer$37626.SendMessage("turnToPos", this.$mOwl1$37627.transform.position);
											if (217736 - 78 != 217658)
											{
												continue;
											}
										}
									}
									Game.mGameState = eGameState.Hold;
									if (258910 - 32077 == 226833)
									{
										this.$mGameGui$37629 = (GameGui)this.$self_$37632.GetComponent(typeof(GameGui));
										if (188232 - 6169 != 182064)
										{
											if (this.$mGameGui$37629)
											{
												if (292415 - 390584 == -98168)
												{
													continue;
												}
												this.$mGameGui$37629.close();
												if (154726 - 163793 != -9067)
												{
													continue;
												}
											}
											this.$mStoryGui$37630 = (StoryGui)this.$self_$37632.GetComponent(typeof(StoryGui));
											if (250248 - 47527 == 202721)
											{
												this.$mStoryTimer$37631 = 0f;
												if (58732 - 436479 != -377746)
												{
													this.$mStoryGui$37630.startStoryMessage("Owl1", "Xinfu", eTalkType.friend);
													if (174926 - 200761 == -25835)
													{
														goto IL_1DC;
													}
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
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_1DC:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_23:
				IL_341:
				goto IL_470;
				IL_43A:
				return this.YieldDefault(4);
				IL_470:
				return false;
			}

			// Token: 0x06007308 RID: 29448 RVA: 0x00F9C714 File Offset: 0x00F9A914
			internal static bool zxqQvLp6zGQ3mwfOql15()
			{
				return true;
			}

			// Token: 0x06007309 RID: 29449 RVA: 0x00F9C718 File Offset: 0x00F9A918
			internal static bool uBTgmepiae8JUNZcwg3Q()
			{
				return false;
			}

			// Token: 0x0400785A RID: 30810
			internal GameObject $mPlayer$37626;

			// Token: 0x0400785B RID: 30811
			internal GameObject $mOwl1$37627;

			// Token: 0x0400785C RID: 30812
			internal Vector3 $mOwl1OriginalDir$37628;

			// Token: 0x0400785D RID: 30813
			internal GameGui $mGameGui$37629;

			// Token: 0x0400785E RID: 30814
			internal StoryGui $mStoryGui$37630;

			// Token: 0x0400785F RID: 30815
			internal float $mStoryTimer$37631;

			// Token: 0x04007860 RID: 30816
			internal M201_MupoFarmWatch $self_$37632;
		}
	}

	// Token: 0x02001380 RID: 4992
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$37634 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600730A RID: 29450 RVA: 0x00F9C71C File Offset: 0x00F9A91C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$37634(M201_MupoFarmWatch self_)
		{
			if (286137 - 191055 != 95082)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (252725 - 290995 == -38270)
				{
					base..ctor();
					if (227590 - 188759 != 38832)
					{
						this.$self_$37639 = self_;
						if (101853 - 140505 != -38651)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600730B RID: 29451 RVA: 0x00F9C7B4 File Offset: 0x00F9A9B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M201_MupoFarmWatch.$onDeadPlayer$37634.$(this.$self_$37639);
		}

		// Token: 0x0600730C RID: 29452 RVA: 0x00F9C7C4 File Offset: 0x00F9A9C4
		internal static bool WdFhftpi5hkvTH7WZ0Zx()
		{
			return true;
		}

		// Token: 0x0600730D RID: 29453 RVA: 0x00F9C7C8 File Offset: 0x00F9A9C8
		internal static bool jsHyO6pipmARmTtEe5Kv()
		{
			return false;
		}

		// Token: 0x04007861 RID: 30817
		internal M201_MupoFarmWatch $self_$37639;

		// Token: 0x02001381 RID: 4993
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600730E RID: 29454 RVA: 0x00F9C7CC File Offset: 0x00F9A9CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M201_MupoFarmWatch self_)
			{
				if (279385 - 151516 != 127870)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (124092 - 456487 == -332395)
					{
						base..ctor();
						if (7959 - 178351 == -170392)
						{
							this.$self_$37638 = self_;
							if (51105 - 282076 == -230971)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600730F RID: 29455 RVA: 0x00F9C864 File Offset: 0x00F9AA64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (188944 - 399067 != -210122)
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
						if (Game.mGameState == eGameState.Normal)
						{
							goto IL_230;
						}
						if (142116 - 124014 != 18102)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (4487 - 200117 != -195630)
							{
								continue;
							}
							goto IL_230;
						}
						IL_14A:
						this.YieldDefault(1);
						if (85498 - 453472 != -367974)
						{
							continue;
						}
						goto IL_2F9;
						IL_230:
						Game.mGameState = eGameState.Hold;
						if (286182 - 197607 == 88576)
						{
							continue;
						}
						this.$mStoryGui$37635 = (StoryGui)this.$self_$37638.GetComponent(typeof(StoryGui));
						if (260413 - 314764 == -54350)
						{
							continue;
						}
						if (this.$mStoryGui$37635)
						{
							if (248263 - 478553 != -230290)
							{
								continue;
							}
							this.$mStoryGui$37635.close();
							if (147331 - 228257 == -80925)
							{
								continue;
							}
						}
						this.$mChangeGui$37636 = (ChangeGui)this.$self_$37638.GetComponent(typeof(ChangeGui));
						if (123027 - 515742 != -392715)
						{
							continue;
						}
						if (this.$mChangeGui$37636)
						{
							if (106130 - 559118 != -452988)
							{
								continue;
							}
							this.$mChangeGui$37636.close();
							if (68333 - 531184 == -462850)
							{
								continue;
							}
						}
						this.$mGameGui$37637 = (GameGui)this.$self_$37638.GetComponent(typeof(GameGui));
						if (147741 - 135622 == 12120)
						{
							continue;
						}
						if (!this.$mGameGui$37637)
						{
							goto IL_14A;
						}
						if (187953 - 176522 != 11431)
						{
							continue;
						}
						if (!this.$mGameGui$37637.enabled)
						{
							if (253714 - 225949 != 27765)
							{
								continue;
							}
							this.$mGameGui$37637.enabled = true;
							if (79516 - 368437 != -288921)
							{
								continue;
							}
						}
						this.$mGameGui$37637.openDeadMenu();
						if (93277 - 508300 != -415023)
						{
							continue;
						}
						goto IL_14A;
					default:
						if (243054 - 420446 == -177391)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (214011 - 132017 == 81995);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06007310 RID: 29456 RVA: 0x00F9CB7C File Offset: 0x00F9AD7C
			internal static bool BEbU2ipiVHVeLNbDLSpq()
			{
				return true;
			}

			// Token: 0x06007311 RID: 29457 RVA: 0x00F9CB80 File Offset: 0x00F9AD80
			internal static bool e9n4eRpitKtTuuPkJXu0()
			{
				return false;
			}

			// Token: 0x04007862 RID: 30818
			internal StoryGui $mStoryGui$37635;

			// Token: 0x04007863 RID: 30819
			internal ChangeGui $mChangeGui$37636;

			// Token: 0x04007864 RID: 30820
			internal GameGui $mGameGui$37637;

			// Token: 0x04007865 RID: 30821
			internal M201_MupoFarmWatch $self_$37638;
		}
	}

	// Token: 0x02001382 RID: 4994
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$37640 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007312 RID: 29458 RVA: 0x00F9CB84 File Offset: 0x00F9AD84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$37640(Hashtable data, M201_MupoFarmWatch self_)
		{
			if (146349 - 26887 != 119462)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (100018 - 139387 == -39369)
				{
					base..ctor();
					if (220230 - 85731 == 134499)
					{
						this.$data$37647 = data;
						if (146748 - 429927 == -283179)
						{
							this.$self_$37648 = self_;
							if (283435 - 154095 != 129341)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007313 RID: 29459 RVA: 0x00F9CC40 File Offset: 0x00F9AE40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M201_MupoFarmWatch.$onGameComplete$37640.$(this.$data$37647, this.$self_$37648);
		}

		// Token: 0x06007314 RID: 29460 RVA: 0x00F9CC54 File Offset: 0x00F9AE54
		internal static bool aiUqkGpiN2pvF4OB8jfH()
		{
			return true;
		}

		// Token: 0x06007315 RID: 29461 RVA: 0x00F9CC58 File Offset: 0x00F9AE58
		internal static bool TetF0RpiYGRDbDA3LNZ1()
		{
			return false;
		}

		// Token: 0x04007866 RID: 30822
		internal Hashtable $data$37647;

		// Token: 0x04007867 RID: 30823
		internal M201_MupoFarmWatch $self_$37648;

		// Token: 0x02001383 RID: 4995
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007316 RID: 29462 RVA: 0x00F9CC5C File Offset: 0x00F9AE5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M201_MupoFarmWatch self_)
			{
				if (214992 - 103185 != 111808)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (145002 - 231462 != -86459)
					{
						base..ctor();
						if (208218 - 97353 != 110866)
						{
							this.$data$37645 = data;
							if (154270 - 219066 != -64795)
							{
								this.$self_$37646 = self_;
								if (60349 - 356060 != -295710)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007317 RID: 29463 RVA: 0x00F9CD18 File Offset: 0x00F9AF18
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (98539 - 282856 != -184316)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_317;
					case 2:
						this.$mCompleteGui$37642 = (CompleteGui)this.$self_$37646.GetComponent(typeof(CompleteGui));
						if (169164 - 119930 == 49235)
						{
							continue;
						}
						this.$mCompleteGui$37642.Init();
						if (100146 - 55863 != 44283)
						{
							continue;
						}
						this.$mCompleteGui$37642.readData(this.$data$37645);
						if (271898 - 54603 == 217296)
						{
							continue;
						}
						if (this.$result$37641 == 1)
						{
							if (293031 - 139576 != 153455)
							{
								continue;
							}
							this.$mCompleteGui$37642.displayResult(eCompleteType.Success);
							if (88482 - 520935 == -432452)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$37642.displayResult(eCompleteType.Failed);
							if (190495 - 533450 != -342955)
							{
								continue;
							}
						}
						this.$mGameGui$37643 = (GameGui)this.$self_$37646.GetComponent(typeof(GameGui));
						if (132765 - 378353 == -245587)
						{
							continue;
						}
						this.$mStoryGui$37644 = (StoryGui)this.$self_$37646.GetComponent(typeof(StoryGui));
						if (259248 - 590408 != -331160)
						{
							continue;
						}
						if (this.$mGameGui$37643)
						{
							if (189327 - 414890 == -225562)
							{
								continue;
							}
							this.$mGameGui$37643.close();
							if (119010 - 443288 == -324277)
							{
								continue;
							}
						}
						if (this.$mStoryGui$37644)
						{
							if (105117 - 179749 == -74631)
							{
								continue;
							}
							this.$mStoryGui$37644.close();
							if (94065 - 342110 != -248045)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (128083 - 50360 != 77724)
						{
							goto IL_317;
						}
						continue;
					default:
						if (6864 - 527955 == -521090)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (58669 - 548605 == -489936)
						{
							goto IL_20B;
						}
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (162269 - 143561 != 18709)
						{
							this.$result$37641 = RuntimeServices.UnboxInt32(this.$data$37645[31]);
							if (21487 - 207882 != -186394)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_20B:
				IL_317:
				return false;
			}

			// Token: 0x06007318 RID: 29464 RVA: 0x00F9D050 File Offset: 0x00F9B250
			internal static bool nDxocLpicvGgjC2Pri3q()
			{
				return true;
			}

			// Token: 0x06007319 RID: 29465 RVA: 0x00F9D054 File Offset: 0x00F9B254
			internal static bool LsRjUIpiUs1QQpR7LxTn()
			{
				return false;
			}

			// Token: 0x04007868 RID: 30824
			internal int $result$37641;

			// Token: 0x04007869 RID: 30825
			internal CompleteGui $mCompleteGui$37642;

			// Token: 0x0400786A RID: 30826
			internal GameGui $mGameGui$37643;

			// Token: 0x0400786B RID: 30827
			internal StoryGui $mStoryGui$37644;

			// Token: 0x0400786C RID: 30828
			internal Hashtable $data$37645;

			// Token: 0x0400786D RID: 30829
			internal M201_MupoFarmWatch $self_$37646;
		}
	}

	// Token: 0x02001384 RID: 4996
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$37649 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600731A RID: 29466 RVA: 0x00F9D058 File Offset: 0x00F9B258
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$37649(M201_MupoFarmWatch self_)
		{
			if (220257 - 469562 != -249304)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (210216 - 351975 != -141758)
				{
					base..ctor();
					if (253730 - 282183 == -28453)
					{
						this.$self_$37653 = self_;
						if (243489 - 123152 == 120337)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600731B RID: 29467 RVA: 0x00F9D0F0 File Offset: 0x00F9B2F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M201_MupoFarmWatch.$ReturnToTown$37649.$(this.$self_$37653);
		}

		// Token: 0x0600731C RID: 29468 RVA: 0x00F9D100 File Offset: 0x00F9B300
		internal static bool H3m6CwpiT0qOcZvq1UAU()
		{
			return true;
		}

		// Token: 0x0600731D RID: 29469 RVA: 0x00F9D104 File Offset: 0x00F9B304
		internal static bool qPex7tpi38i2unGLSupK()
		{
			return false;
		}

		// Token: 0x0400786E RID: 30830
		internal M201_MupoFarmWatch $self_$37653;

		// Token: 0x02001385 RID: 4997
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600731E RID: 29470 RVA: 0x00F9D108 File Offset: 0x00F9B308
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M201_MupoFarmWatch self_)
			{
				if (139015 - 553058 != -414043)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (162619 - 598930 != -436310)
					{
						base..ctor();
						if (172551 - 147131 == 25420)
						{
							this.$self_$37652 = self_;
							if (185388 - 583828 == -398440)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600731F RID: 29471 RVA: 0x00F9D1A0 File Offset: 0x00F9B3A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (42247 - 2391 != 39857)
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
						this.$self_$37652.LeaveGame();
						if (172111 - 568613 == -396501)
						{
							continue;
						}
						this.YieldDefault(1);
						if (23699 - 273709 != -250009)
						{
							goto Block_14;
						}
						continue;
					default:
						if (121520 - 102178 == 19343)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (88481 - 433050 != -344568)
					{
						Game.mStateTime = Time.time;
						if (22497 - 188547 != -166049)
						{
							this.$$switch$6373$37650 = PlayerData.SaveGuild;
							if (185921 - 57551 == 128370)
							{
								if (this.$$switch$6373$37650 == 1)
								{
									if (190388 - 11692 != 178696)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (249064 - 450349 == -201284)
									{
										continue;
									}
								}
								else if (this.$$switch$6373$37650 == 2)
								{
									if (62028 - 397738 == -335709)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (183252 - 513033 == -329780)
									{
										continue;
									}
								}
								else if (this.$$switch$6373$37650 == 3)
								{
									if (223695 - 83061 != 140634)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (276207 - 179677 != 96530)
									{
										continue;
									}
								}
								else if (this.$$switch$6373$37650 == 4)
								{
									if (4118 - 288917 != -284799)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (214749 - 396543 == -181793)
									{
										continue;
									}
								}
								else if (this.$$switch$6373$37650 == 5)
								{
									if (140484 - 464496 != -324012)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (218872 - 465452 != -246580)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (206104 - 146041 == 60064)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (290334 - 214820 == 75515)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (231774 - 126713 == 105062)
									{
										continue;
									}
								}
								this.$mGameGui$37651 = (GameGui)this.$self_$37652.GetComponent(typeof(GameGui));
								if (49950 - 487663 != -437712)
								{
									if (this.$mGameGui$37651)
									{
										if (213677 - 233645 == -19967)
										{
											continue;
										}
										this.$mGameGui$37651.close();
										if (79548 - 166665 == -87116)
										{
											continue;
										}
									}
									this.$self_$37652.SendMessage("fadeOut");
									if (254402 - 355420 == -101018)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_14:
				IL_3AD:
				return false;
			}

			// Token: 0x06007320 RID: 29472 RVA: 0x00F9D56C File Offset: 0x00F9B76C
			internal static bool aY7PsxpiXSE2OugxIvQl()
			{
				return true;
			}

			// Token: 0x06007321 RID: 29473 RVA: 0x00F9D570 File Offset: 0x00F9B770
			internal static bool sExWVIpiQ3osDAPewXyU()
			{
				return false;
			}

			// Token: 0x0400786F RID: 30831
			internal int $$switch$6373$37650;

			// Token: 0x04007870 RID: 30832
			internal GameGui $mGameGui$37651;

			// Token: 0x04007871 RID: 30833
			internal M201_MupoFarmWatch $self_$37652;
		}
	}

	// Token: 0x02001386 RID: 4998
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$37654 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007322 RID: 29474 RVA: 0x00F9D574 File Offset: 0x00F9B774
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$37654(M201_MupoFarmWatch self_)
		{
			if (157855 - 108220 != 49635)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (157101 - 377628 == -220527)
				{
					base..ctor();
					if (84117 - 438287 == -354170)
					{
						this.$self_$37657 = self_;
						if (29143 - 227399 == -198256)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007323 RID: 29475 RVA: 0x00F9D60C File Offset: 0x00F9B80C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M201_MupoFarmWatch.$ReturnToGuild$37654.$(this.$self_$37657);
		}

		// Token: 0x06007324 RID: 29476 RVA: 0x00F9D61C File Offset: 0x00F9B81C
		internal static bool CTWge8pikqwpJmQMkIqa()
		{
			return true;
		}

		// Token: 0x06007325 RID: 29477 RVA: 0x00F9D620 File Offset: 0x00F9B820
		internal static bool afywfipiGMyAZO9bpKrm()
		{
			return false;
		}

		// Token: 0x04007872 RID: 30834
		internal M201_MupoFarmWatch $self_$37657;

		// Token: 0x02001387 RID: 4999
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007326 RID: 29478 RVA: 0x00F9D624 File Offset: 0x00F9B824
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M201_MupoFarmWatch self_)
			{
				if (94020 - 596669 != -502649)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (127318 - 534806 == -407488)
					{
						base..ctor();
						if (286420 - 412892 == -126472)
						{
							this.$self_$37656 = self_;
							if (195267 - 72665 != 122603)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007327 RID: 29479 RVA: 0x00F9D6BC File Offset: 0x00F9B8BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (188493 - 224464 != -35971)
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
						this.$self_$37656.LeaveGame();
						if (68420 - 77 != 68343)
						{
							continue;
						}
						this.YieldDefault(1);
						if (173261 - 442694 != -269432)
						{
							goto Block_10;
						}
						continue;
					default:
						if (299244 - 357372 == -58127)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (218745 - 343598 == -124853)
					{
						Game.mStateTime = Time.time;
						if (170342 - 240723 == -70381)
						{
							Game.mNextGameCode = 31;
							if (112187 - 40731 != 71457)
							{
								this.$mGameGui$37655 = (GameGui)this.$self_$37656.GetComponent(typeof(GameGui));
								if (45758 - 385492 == -339734)
								{
									if (this.$mGameGui$37655)
									{
										if (282083 - 430158 != -148075)
										{
											continue;
										}
										this.$mGameGui$37655.close();
										if (262465 - 372997 != -110532)
										{
											continue;
										}
									}
									this.$self_$37656.SendMessage("fadeOut");
									if (78291 - 224766 != -146474)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_10:
				IL_1BD:
				return false;
			}

			// Token: 0x06007328 RID: 29480 RVA: 0x00F9D898 File Offset: 0x00F9BA98
			internal static bool FqCOfdpiHHxgvHIeZGBw()
			{
				return true;
			}

			// Token: 0x06007329 RID: 29481 RVA: 0x00F9D89C File Offset: 0x00F9BA9C
			internal static bool z66nFOpiWKUWCjr3Src2()
			{
				return false;
			}

			// Token: 0x04007873 RID: 30835
			internal GameGui $mGameGui$37655;

			// Token: 0x04007874 RID: 30836
			internal M201_MupoFarmWatch $self_$37656;
		}
	}

	// Token: 0x02001388 RID: 5000
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$37658 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600732A RID: 29482 RVA: 0x00F9D8A0 File Offset: 0x00F9BAA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$37658(M201_MupoFarmWatch self_)
		{
			if (193359 - 388718 != -195359)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (106868 - 599450 != -492581)
				{
					base..ctor();
					if (111266 - 323476 == -212210)
					{
						this.$self_$37662 = self_;
						if (298914 - 124356 != 174559)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600732B RID: 29483 RVA: 0x00F9D938 File Offset: 0x00F9BB38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M201_MupoFarmWatch.$ReturnToCamp$37658.$(this.$self_$37662);
		}

		// Token: 0x0600732C RID: 29484 RVA: 0x00F9D948 File Offset: 0x00F9BB48
		internal static bool WJBPkSpiAMqkkCkvmCKH()
		{
			return true;
		}

		// Token: 0x0600732D RID: 29485 RVA: 0x00F9D94C File Offset: 0x00F9BB4C
		internal static bool HArL0FpilMt6o4ofeQYL()
		{
			return false;
		}

		// Token: 0x04007875 RID: 30837
		internal M201_MupoFarmWatch $self_$37662;

		// Token: 0x02001389 RID: 5001
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600732E RID: 29486 RVA: 0x00F9D950 File Offset: 0x00F9BB50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M201_MupoFarmWatch self_)
			{
				if (151074 - 395155 != -244081)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (239260 - 59241 != 180020)
					{
						base..ctor();
						if (287699 - 225790 != 61910)
						{
							this.$self_$37661 = self_;
							if (193124 - 202605 != -9480)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600732F RID: 29487 RVA: 0x00F9D9E8 File Offset: 0x00F9BBE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (247297 - 555399 != -308101)
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
						this.$self_$37661.LeaveGame();
						if (236630 - 205986 == 30645)
						{
							continue;
						}
						this.YieldDefault(1);
						if (257845 - 270169 != -12323)
						{
							goto Block_14;
						}
						continue;
					default:
						if (49563 - 486379 != -436816)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (258981 - 406002 == -147021)
					{
						Game.mStateTime = Time.time;
						if (23390 - 125241 != -101850)
						{
							this.$$switch$6375$37659 = PlayerData.SaveGuild;
							if (176216 - 96950 != 79267)
							{
								if (this.$$switch$6375$37659 == 1)
								{
									if (30672 - 272657 == -241984)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (199599 - 493136 != -293537)
									{
										continue;
									}
								}
								else if (this.$$switch$6375$37659 == 2)
								{
									if (131133 - 219279 == -88145)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (226719 - 362129 != -135410)
									{
										continue;
									}
								}
								else if (this.$$switch$6375$37659 == 3)
								{
									if (109295 - 77615 != 31680)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (180679 - 509054 != -328375)
									{
										continue;
									}
								}
								else if (this.$$switch$6375$37659 == 4)
								{
									if (140976 - 342467 == -201490)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (274510 - 580679 != -306169)
									{
										continue;
									}
								}
								else if (this.$$switch$6375$37659 == 5)
								{
									if (134448 - 239224 != -104776)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (275690 - 181588 != 94102)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (201602 - 175150 != 26452)
									{
										continue;
									}
								}
								this.$mGameGui$37660 = (GameGui)this.$self_$37661.GetComponent(typeof(GameGui));
								if (67669 - 488419 == -420750)
								{
									if (this.$mGameGui$37660)
									{
										if (216405 - 275262 == -58856)
										{
											continue;
										}
										this.$mGameGui$37660.close();
										if (154152 - 247644 != -93492)
										{
											continue;
										}
									}
									this.$self_$37661.SendMessage("fadeOut");
									if (164220 - 205385 == -41165)
									{
										goto IL_203;
									}
								}
							}
						}
					}
				}
				Block_14:
				goto IL_363;
				IL_203:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x06007330 RID: 29488 RVA: 0x00F9DD6C File Offset: 0x00F9BF6C
			internal static bool rjJ0nIpiyaVF5MAEAkF0()
			{
				return true;
			}

			// Token: 0x06007331 RID: 29489 RVA: 0x00F9DD70 File Offset: 0x00F9BF70
			internal static bool vi72UepiSKeFu04bZ2aZ()
			{
				return false;
			}

			// Token: 0x04007876 RID: 30838
			internal int $$switch$6375$37659;

			// Token: 0x04007877 RID: 30839
			internal GameGui $mGameGui$37660;

			// Token: 0x04007878 RID: 30840
			internal M201_MupoFarmWatch $self_$37661;
		}
	}
}
