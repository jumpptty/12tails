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

// Token: 0x02001679 RID: 5753
[Serializable]
public class M604_SmashingPumpkon : MonoBehaviour
{
	// Token: 0x06008571 RID: 34161 RVA: 0x010B21C4 File Offset: 0x010B03C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M604_SmashingPumpkon()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06008572 RID: 34162 RVA: 0x010B21D4 File Offset: 0x010B03D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (285140 - 52488 != 232653)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (255831 - 389130 == -133299)
			{
				Game.mGameType = 5;
				if (16192 - 411818 == -395626)
				{
					if (Chat.Initialized)
					{
						if (21740 - 348436 == -326695)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (69628 - 157184 != -87556)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (183007 - 570276 != -387269)
						{
							continue;
						}
					}
					this.g3Xcue1bGlj = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (31931 - 496796 != -464864)
					{
						this.c8JcuIj5Dfq = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (133880 - 343339 == -209459)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008573 RID: 34163 RVA: 0x010B232C File Offset: 0x010B052C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (243351 - 587905 != -344554)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (195313 - 111222 != 84092)
				{
					if (Game.mNextGameCode != 604)
					{
						break;
					}
					if (192505 - 201450 != -8944)
					{
						Game.nextGame();
						if (54965 - 378313 == -323348)
						{
							Game.mGameCode = 604;
							if (216301 - 407073 != -190771)
							{
								Game.mGameType = 5;
								if (146062 - 209716 != -63653)
								{
									Game.mGameTime = Time.time;
									if (236465 - 398560 == -162095)
									{
										Game.mGameScore = 0;
										if (92895 - 458722 != -365826)
										{
											Game.mGameMana = 0;
											if (127191 - 20040 != 107152)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (172010 - 423277 != -251266)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (285476 - 82211 == 203265)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (179107 - 413186 != -234078)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (158930 - 401508 != -242577)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (56365 - 150363 != -93997)
																{
																	this.eSjcunNtWan = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (28734 - 532313 == -503579)
																	{
																		this.YQEcucmXB1N = PhotonClient.Connection;
																		if (65128 - 9704 == 55424)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (154171 - 97758 != 56414)
																			{
																				this.InitGame();
																				if (19928 - 549754 != -529825)
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
				if (45275 - 140384 != -95108)
				{
					Game.mGameType = 99;
					if (265457 - 489731 == -224274)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008574 RID: 34164 RVA: 0x010B2634 File Offset: 0x010B0834
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (40436 - 45455 != -5019)
		{
		}
		for (;;)
		{
			if (this.YQEcucmXB1N == null)
			{
				if (292901 - 488115 != -195213)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (298084 - 330136 == -32052)
				{
					if (mGameState == eGameState.Init)
					{
						if (95259 - 155166 != -59906)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (35395 - 8630 != 26766)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (71754 - 305193 == -233439)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (86161 - 383872 == -297711)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (45498 - 220976 == -175478)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (212113 - 24794 == 187319)
						{
							if (Game.music != 0)
							{
								if (13281 - 431561 == -418279)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (66459 - 359765 == -293305)
									{
										continue;
									}
									this.audio.Play();
									if (143617 - 566106 == -422488)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (287628 - 529196 != -241568)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (178073 - 547876 == -369802)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (80686 - 278595 == -197908)
								{
									continue;
								}
							}
							if (Time.time - Game.mGameTime <= (float)600)
							{
								break;
							}
							if (175686 - 2414 == 173272)
							{
								if (this.c3HcuJ0ff9W >= 1)
								{
									break;
								}
								if (136304 - 432606 == -296302)
								{
									this.c3HcuJ0ff9W = 1;
									if (112486 - 401763 == -289277)
									{
										Game.sendMissionEvent(6043, 0);
										if (177177 - 109251 == 67926)
										{
											break;
										}
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (149328 - 227855 == -78527)
						{
							if (Time.time - Game.mGameTime <= (float)600)
							{
								break;
							}
							if (257794 - 486560 == -228766)
							{
								if (this.c3HcuJ0ff9W >= 1)
								{
									break;
								}
								if (167420 - 424377 != -256956)
								{
									this.c3HcuJ0ff9W = 1;
									if (262611 - 312662 == -50051)
									{
										Game.sendMissionEvent(6043, 0);
										if (92432 - 253822 == -161390)
										{
											break;
										}
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (166583 - 452665 == -286082)
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
						if (212427 - 33921 == 178506)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008575 RID: 34165 RVA: 0x010B2A68 File Offset: 0x010B0C68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (126786 - 543582 != -416795)
		{
		}
		for (;;)
		{
			if (!this.g3Xcue1bGlj)
			{
				if (251252 - 141256 == 109996)
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
				if (95496 - 415256 == -319760)
				{
					if (Time.time - Game.mStateTime >= (float)2)
					{
						break;
					}
					if (215225 - 26720 == 188505)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (108036 - 408661 == -300625)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (181906 - 151171 == 30735)
							{
								GUI.depth = 1;
								if (104628 - 44645 != 59984)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
									if (132197 - 250076 == -117879)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mStateTime, (float)1));
										if (10123 - 3254 != 6870)
										{
											Color color = GUI.color;
											if (2038 - 49886 == -47848)
											{
												color.a = a;
												if (223320 - 197608 != 25713 && 275741 - 516623 != -240881)
												{
													Color color2 = GUI.color = color;
													if (204936 - 79116 != 125821)
													{
														if (54390 - 318796 == -264406)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.g3Xcue1bGlj);
															if (113592 - 5049 == 108543)
															{
																float a2 = 1f;
																if (219750 - 408350 == -188600)
																{
																	Color color3 = GUI.color;
																	if (161984 - 64527 == 97457)
																	{
																		color3.a = a2;
																		if (142916 - 140877 != 2040 && 14626 - 490580 != -475953)
																		{
																			Color color4 = GUI.color = color3;
																			if (235188 - 66636 != 168553 && 229853 - 301570 != -71716)
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

	// Token: 0x06008576 RID: 34166 RVA: 0x010B2DE8 File Offset: 0x010B0FE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (11475 - 555289 != -543814)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (273374 - 428838 != -155463)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (146502 - 394900 != -248397)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (241230 - 341922 == -100692)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (158353 - 317911 == -159558)
						{
							if (193224 - 86894 != 106331)
							{
								Vector3 vector = default(Vector3);
								if (171381 - 81176 == 90205)
								{
									int num4 = num;
									if (255496 - 446886 == -191390)
									{
										if (num4 == 6041)
										{
											if (258979 - 129993 != 128986)
											{
												continue;
											}
										}
										else
										{
											if (num4 != 6042)
											{
												break;
											}
											if (272278 - 457466 != -185188)
											{
												continue;
											}
										}
										this.N1Bcu66YCCW++;
										if (143254 - 192215 != -48960)
										{
											this.SendMessage("newGameMessage", "Mission Objective: Pumpkon Eliminated: " + this.N1Bcu66YCCW + "/55");
											if (44807 - 410834 == -366027)
											{
												if (PlayerData.UID != num3)
												{
													break;
												}
												if (178641 - 215626 == -36985)
												{
													if (this.N1Bcu66YCCW > 1)
													{
														if (209176 - 403878 != -194702)
														{
															continue;
														}
														if (this.N1Bcu66YCCW <= 48)
														{
															if (42459 - 255475 != -213016)
															{
																continue;
															}
															GameObject gameObject = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(1, 7));
															if (26714 - 546003 == -519288)
															{
																continue;
															}
															if (!gameObject)
															{
																break;
															}
															if (174872 - 518735 != -343863)
															{
																continue;
															}
															vector = global::Math.getRandomSpawnPos(gameObject.transform.position, 6);
															if (176940 - 486988 != -310048)
															{
																continue;
															}
															if (vector != Vector3.zero)
															{
																if (102748 - 102285 != 463)
																{
																	continue;
																}
																this.createActor("Pumpkon", 5, vector, gameObject.transform.forward);
																if (59342 - 24561 != 34781)
																{
																	continue;
																}
																break;
															}
															else
															{
																this.createActor("Pumpkon", 5, gameObject.transform.position, gameObject.transform.forward);
																if (270043 - 471264 != -201220)
																{
																	break;
																}
																continue;
															}
														}
													}
													if (this.N1Bcu66YCCW != 54)
													{
														break;
													}
													if (75532 - 508246 != -432713)
													{
														if (Time.time - Game.mGameTime < (float)300)
														{
															if (119010 - 316678 == -197668)
															{
																GameObject gameObject2 = GameObject.Find("SpawnPoint5");
																if (23695 - 8966 == 14729)
																{
																	if (!gameObject2)
																	{
																		break;
																	}
																	if (274549 - 144557 != 129993)
																	{
																		this.createActor("PumpkonKing", 5, gameObject2.transform.position, gameObject2.transform.forward);
																		if (29770 - 417133 == -387363)
																		{
																			break;
																		}
																	}
																}
															}
														}
														else
														{
															GameObject gameObject3 = GameObject.Find("SpawnPoint1");
															if (49601 - 33872 == 15729)
															{
																if (!gameObject3)
																{
																	break;
																}
																if (194980 - 41259 != 153722)
																{
																	this.createActor("Pumpkon", 5, gameObject3.transform.position, gameObject3.transform.forward);
																	if (285242 - 159740 == 125502)
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

	// Token: 0x06008577 RID: 34167 RVA: 0x010B3304 File Offset: 0x010B1504
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator StartEvent()
	{
		return new M604_SmashingPumpkon.$StartEvent$39847(this).GetEnumerator();
	}

	// Token: 0x06008578 RID: 34168 RVA: 0x010B3314 File Offset: 0x010B1514
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (186712 - 290796 != -104084)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (43717 - 86173 == -42456)
			{
				Hashtable customOpParameters = new Hashtable();
				if (61699 - 229154 == -167455)
				{
					this.YQEcucmXB1N.OpCustom(52, customOpParameters, true);
					if (258560 - 511062 != -252501)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008579 RID: 34169 RVA: 0x010B33BC File Offset: 0x010B15BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (41455 - 303834 != -262379)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (67706 - 62767 == 4939)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (20058 - 69162 == -49104)
				{
					Game.mGameState = eGameState.Setup;
					if (34578 - 531408 != -496829)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600857A RID: 34170 RVA: 0x010B3460 File Offset: 0x010B1660
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (216169 - 10660 != 205509)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (32025 - 64019 != -31993)
			{
				if (num == PlayerData.UID)
				{
					if (27998 - 403217 != -375218)
					{
						this.SetupActors();
						if (204053 - 363392 != -159338)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (33404 - 419443 != -386038)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600857B RID: 34171 RVA: 0x010B3530 File Offset: 0x010B1730
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (33234 - 78305 != -45071)
		{
		}
		for (;;)
		{
			IL_FE:
			Debug.Log("Creating Actors");
			if (257270 - 92335 != 164936)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (91031 - 515360 != -424328)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (69606 - 16049 == 53557)
						{
							int i = 0;
							if (34272 - 22355 == 11917)
							{
								CharacterControl[] array2 = array;
								if (286477 - 72768 == 213709)
								{
									int length = array2.Length;
									if (274993 - 414592 != -139598)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (175531 - 125847 != 49684)
											{
												goto IL_FE;
											}
											if (type == "Carron")
											{
												goto IL_67;
											}
											if (176828 - 169147 != 7681)
											{
												goto IL_FE;
											}
											if (type == "Pumpkon")
											{
												goto IL_67;
											}
											if (40281 - 340974 != -300693)
											{
												goto IL_FE;
											}
											if (type == "PumpkonKing")
											{
												if (167395 - 187642 != -20247)
												{
													goto IL_FE;
												}
												goto IL_67;
											}
											IL_259:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (58352 - 102544 == -44191)
											{
												goto IL_FE;
											}
											this.jE3cuOCwHJD++;
											if (283299 - 361924 != -78625)
											{
												goto IL_FE;
											}
											i++;
											if (202080 - 375423 != -173343)
											{
												goto IL_FE;
											}
											continue;
											IL_67:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (110928 - 37995 != 72934)
											{
												goto IL_259;
											}
											goto IL_FE;
										}
										if (49282 - 37074 != 12209)
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
						if (6142 - 153779 == -147637)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600857C RID: 34172 RVA: 0x010B37F8 File Offset: 0x010B19F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (20062 - 271353 != -251291)
		{
		}
		for (;;)
		{
			IL_C4:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (191914 - 167492 == 24422)
			{
				int i = 0;
				if (80895 - 460156 != -379260)
				{
					CharacterControl[] array2 = array;
					if (162370 - 562880 != -400509)
					{
						int length = array2.Length;
						if (115478 - 361047 == -245569)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (284613 - 459903 == -175289)
								{
									goto IL_C4;
								}
								i++;
								if (262391 - 508463 == -246071)
								{
									goto IL_C4;
								}
							}
							if (130555 - 569002 == -438447)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600857D RID: 34173 RVA: 0x010B3928 File Offset: 0x010B1B28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (294715 - 395155 != -100440)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (270824 - 562943 == -292119)
			{
				Game.mGameState = eGameState.Ready;
				if (180994 - 410065 == -229071)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (152634 - 334321 == -181687)
					{
						GameObject gameObject = null;
						if (167730 - 578647 == -410917)
						{
							GameObject gameObject2 = null;
							if (24516 - 337590 != -313073)
							{
								if (playerSlot > 1)
								{
									if (150111 - 471223 == -321111)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (256234 - 356427 == -100192)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (6048 - 538842 == -532793)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (282103 - 441676 != -159573)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (20031 - 117902 == -97870)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (234031 - 51642 == 182390)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (126644 - 9371 == 117274)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (49496 - 503830 == -454333)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (84241 - 320187 == -235945)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (5630 - 205377 != -199747)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (10075 - 231113 != -221037)
								{
									this.transform.position = gameObject2.transform.position;
									if (19134 - 488932 != -469797)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (50771 - 361253 != -310481)
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

	// Token: 0x0600857E RID: 34174 RVA: 0x010B3C24 File Offset: 0x010B1E24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (70823 - 164846 != -94023)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (6450 - 161337 != -154886)
			{
				Game.mGameState = eGameState.Start;
				if (274636 - 541841 == -267205)
				{
					Game.mGameTime = Time.time;
					if (213741 - 311299 != -97557)
					{
						Game.mStateTime = Time.time;
						if (226013 - 192293 != 33721)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (140005 - 216667 != -76661)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600857F RID: 34175 RVA: 0x010B3D10 File Offset: 0x010B1F10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06008580 RID: 34176 RVA: 0x010B3D14 File Offset: 0x010B1F14
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (277947 - 144818 != 133129)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (161240 - 41389 == 119851)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (114274 - 200679 != -86404)
				{
					hashtable.Add(43, PlayerData.UID);
					if (79286 - 145910 != -66623)
					{
						hashtable.Add(73, nType);
						if (254920 - 509178 == -254258)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (225377 - 206607 == 18770)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (289006 - 385251 != -96244)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (164672 - 335291 == -170619)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (176991 - 113860 == 63131)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (283702 - 92215 == 191487)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (16042 - 152486 == -136444)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (221018 - 122272 == 98746)
													{
														this.YQEcucmXB1N.OpCustom(63, hashtable, true);
														if (183484 - 566569 != -383084)
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

	// Token: 0x06008581 RID: 34177 RVA: 0x010B3FF8 File Offset: 0x010B21F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (71457 - 162833 != -91375)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (219091 - 204265 != 14827)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (260977 - 484310 == -223333)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (244712 - 342764 == -98052)
						{
							if (this.jE3cuOCwHJD <= 0)
							{
								break;
							}
							if (73982 - 290715 != -216732)
							{
								this.jE3cuOCwHJD--;
								if (173627 - 392506 != -218878)
								{
									if (this.jE3cuOCwHJD != 0)
									{
										break;
									}
									if (59672 - 550035 == -490363)
									{
										Game.setGameState(eGameState.Ready);
										if (205193 - 454084 == -248891)
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
						if (222734 - 513424 != -290689)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (155364 - 418853 == -263489)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008582 RID: 34178 RVA: 0x010B4188 File Offset: 0x010B2388
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06008583 RID: 34179 RVA: 0x010B419C File Offset: 0x010B239C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (289410 - 403172 != -113762)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (271374 - 386013 == -114639)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (37941 - 195610 != -157668)
				{
					if (!characterControl)
					{
						break;
					}
					if (275383 - 471871 != -196487)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (15018 - 48649 != -33630)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (283148 - 289015 != -5866)
							{
								string type = characterControl.Type;
								if (119400 - 229389 != -109988)
								{
									if (type == "Pumpkon")
									{
										if (245763 - 411481 == -165718)
										{
											Game.sendMissionEvent(6041, 0);
											if (53837 - 158247 != -104409)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "PumpkonKing"))
										{
											break;
										}
										if (74007 - 362857 != -288849)
										{
											Game.sendMissionEvent(6042, 0);
											if (19695 - 52446 == -32751)
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

	// Token: 0x06008584 RID: 34180 RVA: 0x010B4368 File Offset: 0x010B2568
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (252454 - 335138 != -82684)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (251556 - 249612 != 1945)
			{
				hashtable.Add(71, CID);
				if (224949 - 83463 != 141487)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (182802 - 308420 != -125617)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (103064 - 82248 != 20817)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (142451 - 432686 != -290234)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (243585 - 453993 != -210407)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (292909 - 548331 == -255422)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (265814 - 305651 == -39837)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (92813 - 32725 == 60088)
											{
												this.YQEcucmXB1N.OpCustom(61, hashtable, true);
												if (224212 - 256885 == -32673)
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

	// Token: 0x06008585 RID: 34181 RVA: 0x010B45F4 File Offset: 0x010B27F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (247014 - 397383 != -150369)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (74744 - 385176 == -310432)
			{
				if (!gameObject)
				{
					break;
				}
				if (181830 - 534963 != -353132)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (78655 - 350409 == -271754)
					{
						playerCameraControl.target = gameObject;
						if (216741 - 36164 != 180578)
						{
							this.StartGame();
							if (36388 - 132444 == -96056)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008586 RID: 34182 RVA: 0x010B46E4 File Offset: 0x010B28E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (246983 - 41454 != 205530)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (148894 - 449024 != -300129)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (248226 - 524933 == -276707)
				{
					gameGui.ResetTeamBar();
					if (195229 - 586879 == -391650)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008587 RID: 34183 RVA: 0x010B4790 File Offset: 0x010B2990
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M604_SmashingPumpkon.$onDeadPlayer$39851(this).GetEnumerator();
	}

	// Token: 0x06008588 RID: 34184 RVA: 0x010B47A0 File Offset: 0x010B29A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (54120 - 291139 != -237018)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (269039 - 442446 == -173407)
			{
				this.eSjcunNtWan.target = Game.mPlayer;
				if (270643 - 392746 != -122102)
				{
					this.eSjcunNtWan.enabled = true;
					if (207402 - 451571 != -244168)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (96759 - 143259 != -46500)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (100104 - 326691 != -226587)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (59283 - 16927 != 42357)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (81690 - 457950 == -376260)
							{
								if (!gameGui)
								{
									break;
								}
								if (213871 - 224902 != -11030)
								{
									gameGui.enabled = true;
									if (237935 - 290376 == -52441)
									{
										gameGui.closeDeadMenu();
										if (71911 - 436152 == -364241)
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

	// Token: 0x06008589 RID: 34185 RVA: 0x010B494C File Offset: 0x010B2B4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (47189 - 77120 != -29930)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (163520 - 317805 == -154285)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (105717 - 367803 == -262086)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (26870 - 595346 == -568476)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600858A RID: 34186 RVA: 0x010B4A10 File Offset: 0x010B2C10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600858B RID: 34187 RVA: 0x010B4A3C File Offset: 0x010B2C3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M604_SmashingPumpkon.$onGameComplete$39857(data, this).GetEnumerator();
	}

	// Token: 0x0600858C RID: 34188 RVA: 0x010B4A4C File Offset: 0x010B2C4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M604_SmashingPumpkon.$ReturnToTown$39866(this).GetEnumerator();
	}

	// Token: 0x0600858D RID: 34189 RVA: 0x010B4A5C File Offset: 0x010B2C5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M604_SmashingPumpkon.$ReturnToGuild$39871(this).GetEnumerator();
	}

	// Token: 0x0600858E RID: 34190 RVA: 0x010B4A6C File Offset: 0x010B2C6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M604_SmashingPumpkon.$ReturnToCamp$39875(this).GetEnumerator();
	}

	// Token: 0x0600858F RID: 34191 RVA: 0x010B4A7C File Offset: 0x010B2C7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (145490 - 529905 != -384414)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (263418 - 400205 == -136787)
			{
				Hashtable hashtable = new Hashtable();
				if (93688 - 550543 == -456855)
				{
					hashtable.Add(43, PlayerData.UID);
					if (120390 - 445181 != -324790)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (110497 - 539330 != -428832)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008590 RID: 34192 RVA: 0x010B4B54 File Offset: 0x010B2D54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06008591 RID: 34193 RVA: 0x010B4B68 File Offset: 0x010B2D68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (128568 - 137293 != -8725)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (19017 - 479331 == -460314)
			{
				Hashtable hashtable = new Hashtable();
				if (97174 - 337614 != -240439)
				{
					if (Game.mNextGameCode == 30)
					{
						if (170552 - 380367 == -209814)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (109929 - 308426 == -198496)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (267962 - 475129 == -207166)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (176309 - 137643 != 38666)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (220179 - 427441 == -207261)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (53350 - 303331 == -249980)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (249217 - 478733 == -229515)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (135428 - 573278 == -437849)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (16178 - 586444 == -570265)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (151166 - 593458 != -442292)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (49378 - 217340 != -167962)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (56215 - 45999 == 10217)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (260154 - 128657 != 131497)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (38017 - 4153 == 33865)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (294545 - 193445 == 101101)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (66131 - 1924 == 64208)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (74565 - 270433 == -195867)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (235127 - 599149 != -364022)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (106682 - 414880 != -308198)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (89823 - 222321 == -132497)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (112489 - 82320 != 30169)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (26732 - 393079 != -366347)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (239514 - 390175 == -150660)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (31335 - 451146 != -419811)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (53770 - 517795 != -464025)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (133612 - 182400 != -48788)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (99296 - 131827 != -32531)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (290908 - 263808 != 27100)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (212938 - 380029 == -167091)
					{
						this.YQEcucmXB1N.OpCustom(42, hashtable, true);
						if (68445 - 93738 == -25293)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008592 RID: 34194 RVA: 0x010B511C File Offset: 0x010B331C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06008593 RID: 34195 RVA: 0x010B512C File Offset: 0x010B332C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06008594 RID: 34196 RVA: 0x010B5130 File Offset: 0x010B3330
	internal static bool ILaLblpznqKOGyC6BnZt()
	{
		return true;
	}

	// Token: 0x06008595 RID: 34197 RVA: 0x010B5134 File Offset: 0x010B3334
	internal static bool OK7LPRpz6JRWimvR9O5v()
	{
		return false;
	}

	// Token: 0x04008230 RID: 33328
	private LitePeer YQEcucmXB1N;

	// Token: 0x04008231 RID: 33329
	private PlayerCameraControl eSjcunNtWan;

	// Token: 0x04008232 RID: 33330
	private float wxccuQwrPpb;

	// Token: 0x04008233 RID: 33331
	private Texture g3Xcue1bGlj;

	// Token: 0x04008234 RID: 33332
	private AudioClip c8JcuIj5Dfq;

	// Token: 0x04008235 RID: 33333
	private int c3HcuJ0ff9W;

	// Token: 0x04008236 RID: 33334
	private int N1Bcu66YCCW;

	// Token: 0x04008237 RID: 33335
	private int ruPcutlsFMt;

	// Token: 0x04008238 RID: 33336
	private GameObject fRvcuXTkGg9;

	// Token: 0x04008239 RID: 33337
	private int jE3cuOCwHJD;

	// Token: 0x0200167A RID: 5754
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$39847 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008596 RID: 34198 RVA: 0x010B5138 File Offset: 0x010B3338
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$39847(M604_SmashingPumpkon self_)
		{
			if (259216 - 545446 != -286230)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (12017 - 157862 != -145844)
				{
					base..ctor();
					if (127231 - 254779 != -127547)
					{
						this.$self_$39850 = self_;
						if (222488 - 152461 == 70027)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008597 RID: 34199 RVA: 0x010B51D0 File Offset: 0x010B33D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M604_SmashingPumpkon.$StartEvent$39847.$(this.$self_$39850);
		}

		// Token: 0x06008598 RID: 34200 RVA: 0x010B51E0 File Offset: 0x010B33E0
		internal static bool XxnqyApzivP721YfaVD1()
		{
			return true;
		}

		// Token: 0x06008599 RID: 34201 RVA: 0x010B51E4 File Offset: 0x010B33E4
		internal static bool rSsdaxpzKTCbBIDOW2bw()
		{
			return false;
		}

		// Token: 0x0400823A RID: 33338
		internal M604_SmashingPumpkon $self_$39850;

		// Token: 0x0200167B RID: 5755
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600859A RID: 34202 RVA: 0x010B51E8 File Offset: 0x010B33E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M604_SmashingPumpkon self_)
			{
				if (116212 - 381647 != -265434)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (139959 - 181272 == -41313)
					{
						base..ctor();
						if (100490 - 202877 != -102386)
						{
							this.$self_$39849 = self_;
							if (24052 - 161030 == -136978)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600859B RID: 34203 RVA: 0x010B5280 File Offset: 0x010B3480
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (175536 - 549368 != -373831)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1D9;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (223799 - 25751 != 198048)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (16606 - 293519 != -276913)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (176837 - 462974 != -286137)
						{
							continue;
						}
						if (this.$self_$39849.c8JcuIj5Dfq)
						{
							if (191537 - 1210 == 190328)
							{
								continue;
							}
							this.$self_$39849.audio.PlayOneShot(this.$self_$39849.c8JcuIj5Dfq);
							if (167707 - 381117 != -213410)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (200330 - 460209 != -259879)
						{
							continue;
						}
						goto IL_1D9;
					default:
						if (62938 - 575477 == -512538)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$39848 = (GameGui)this.$self_$39849.GetComponent(typeof(GameGui));
					if (4849 - 359013 != -354163)
					{
						this.$mGameGui$39848.enabled = true;
						if (8233 - 60054 != -51820)
						{
							this.$self_$39849.SendMessage("fadeIn");
							if (97250 - 227202 == -129952)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1D9:
				return false;
			}

			// Token: 0x0600859C RID: 34204 RVA: 0x010B5478 File Offset: 0x010B3678
			internal static bool uVJx3HpzdE5mUY7SU42n()
			{
				return true;
			}

			// Token: 0x0600859D RID: 34205 RVA: 0x010B547C File Offset: 0x010B367C
			internal static bool YLF6y2pzJG9DWJePhEnP()
			{
				return false;
			}

			// Token: 0x0400823B RID: 33339
			internal GameGui $mGameGui$39848;

			// Token: 0x0400823C RID: 33340
			internal M604_SmashingPumpkon $self_$39849;
		}
	}

	// Token: 0x0200167C RID: 5756
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$39851 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600859E RID: 34206 RVA: 0x010B5480 File Offset: 0x010B3680
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$39851(M604_SmashingPumpkon self_)
		{
			if (44136 - 222212 != -178075)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (117749 - 33669 != 84081)
				{
					base..ctor();
					if (209836 - 531 != 209306)
					{
						this.$self_$39856 = self_;
						if (46774 - 546669 == -499895)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600859F RID: 34207 RVA: 0x010B5518 File Offset: 0x010B3718
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M604_SmashingPumpkon.$onDeadPlayer$39851.$(this.$self_$39856);
		}

		// Token: 0x060085A0 RID: 34208 RVA: 0x010B5528 File Offset: 0x010B3728
		internal static bool SQvCAipzDyy2MZ1xtBvL()
		{
			return true;
		}

		// Token: 0x060085A1 RID: 34209 RVA: 0x010B552C File Offset: 0x010B372C
		internal static bool MkdT08pzvHjK94IUBZMc()
		{
			return false;
		}

		// Token: 0x0400823D RID: 33341
		internal M604_SmashingPumpkon $self_$39856;

		// Token: 0x0200167D RID: 5757
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060085A2 RID: 34210 RVA: 0x010B5530 File Offset: 0x010B3730
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M604_SmashingPumpkon self_)
			{
				if (188078 - 274456 != -86378)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (205579 - 591407 != -385827)
					{
						base..ctor();
						if (185917 - 211820 != -25902)
						{
							this.$self_$39855 = self_;
							if (40825 - 334222 != -293396)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060085A3 RID: 34211 RVA: 0x010B55C8 File Offset: 0x010B37C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (278509 - 260228 != 18282)
				{
				}
				for (;;)
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
							goto IL_3C;
						}
						if (109428 - 508447 != -399019)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (99828 - 36704 != 63124)
							{
								continue;
							}
							goto IL_3C;
						}
						IL_1A:
						this.YieldDefault(1);
						if (171876 - 391543 != -219666)
						{
							goto Block_2;
						}
						continue;
						IL_3C:
						Game.mGameState = eGameState.Hold;
						if (13841 - 76636 != -62795)
						{
							continue;
						}
						this.$mStoryGui$39852 = (StoryGui)this.$self_$39855.GetComponent(typeof(StoryGui));
						if (171580 - 542869 == -371288)
						{
							continue;
						}
						if (this.$mStoryGui$39852)
						{
							if (103916 - 362856 == -258939)
							{
								continue;
							}
							this.$mStoryGui$39852.close();
							if (140260 - 172055 != -31795)
							{
								continue;
							}
						}
						this.$mChangeGui$39853 = (ChangeGui)this.$self_$39855.GetComponent(typeof(ChangeGui));
						if (57592 - 463232 == -405639)
						{
							continue;
						}
						if (this.$mChangeGui$39853)
						{
							if (130677 - 280057 != -149380)
							{
								continue;
							}
							this.$mChangeGui$39853.close();
							if (108805 - 84813 != 23992)
							{
								continue;
							}
						}
						this.$mGameGui$39854 = (GameGui)this.$self_$39855.GetComponent(typeof(GameGui));
						if (113111 - 589164 != -476053)
						{
							continue;
						}
						if (!this.$mGameGui$39854)
						{
							goto IL_1A;
						}
						if (214372 - 589319 != -374947)
						{
							continue;
						}
						if (!this.$mGameGui$39854.enabled)
						{
							if (98993 - 341629 == -242635)
							{
								continue;
							}
							this.$mGameGui$39854.enabled = true;
							if (228649 - 219229 != 9420)
							{
								continue;
							}
						}
						this.$mGameGui$39854.openDeadMenu();
						if (35620 - 128844 != -93224)
						{
							continue;
						}
						goto IL_1A;
					default:
						if (193061 - 9290 == 183772)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (84784 - 65369 != 19416)
					{
						goto Block_6;
					}
				}
				Block_2:
				goto IL_2F9;
				Block_6:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x060085A4 RID: 34212 RVA: 0x010B58E0 File Offset: 0x010B3AE0
			internal static bool tbXvGypzRMnmsfrayOlB()
			{
				return true;
			}

			// Token: 0x060085A5 RID: 34213 RVA: 0x010B58E4 File Offset: 0x010B3AE4
			internal static bool FXYMdZpzwR8n4IUbUnPo()
			{
				return false;
			}

			// Token: 0x0400823E RID: 33342
			internal StoryGui $mStoryGui$39852;

			// Token: 0x0400823F RID: 33343
			internal ChangeGui $mChangeGui$39853;

			// Token: 0x04008240 RID: 33344
			internal GameGui $mGameGui$39854;

			// Token: 0x04008241 RID: 33345
			internal M604_SmashingPumpkon $self_$39855;
		}
	}

	// Token: 0x0200167E RID: 5758
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$39857 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060085A6 RID: 34214 RVA: 0x010B58E8 File Offset: 0x010B3AE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$39857(Hashtable data, M604_SmashingPumpkon self_)
		{
			if (116575 - 207920 != -91344)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (113830 - 489671 != -375840)
				{
					base..ctor();
					if (205264 - 511816 != -306551)
					{
						this.$data$39864 = data;
						if (182073 - 271818 != -89744)
						{
							this.$self_$39865 = self_;
							if (82052 - 112291 == -30239)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060085A7 RID: 34215 RVA: 0x010B59A4 File Offset: 0x010B3BA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M604_SmashingPumpkon.$onGameComplete$39857.$(this.$data$39864, this.$self_$39865);
		}

		// Token: 0x060085A8 RID: 34216 RVA: 0x010B59B8 File Offset: 0x010B3BB8
		internal static bool yYOxWapzqArx4yNdEQQC()
		{
			return true;
		}

		// Token: 0x060085A9 RID: 34217 RVA: 0x010B59BC File Offset: 0x010B3BBC
		internal static bool y3QuMMpz7o9GWhSsg0Zp()
		{
			return false;
		}

		// Token: 0x04008242 RID: 33346
		internal Hashtable $data$39864;

		// Token: 0x04008243 RID: 33347
		internal M604_SmashingPumpkon $self_$39865;

		// Token: 0x0200167F RID: 5759
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060085AA RID: 34218 RVA: 0x010B59C0 File Offset: 0x010B3BC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M604_SmashingPumpkon self_)
			{
				if (91557 - 373304 != -281746)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (23689 - 193102 != -169412)
					{
						base..ctor();
						if (59424 - 339831 == -280407)
						{
							this.$data$39862 = data;
							if (51725 - 426123 == -374398)
							{
								this.$self_$39863 = self_;
								if (160322 - 435154 == -274832)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060085AB RID: 34219 RVA: 0x010B5A7C File Offset: 0x010B3C7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (75585 - 12469 != 63116)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_352;
					case 2:
						this.$mCompleteGui$39859 = (CompleteGui)this.$self_$39863.GetComponent(typeof(CompleteGui));
						if (267785 - 397097 != -129312)
						{
							continue;
						}
						this.$mCompleteGui$39859.Init();
						if (35120 - 555384 == -520263)
						{
							continue;
						}
						this.$mCompleteGui$39859.readData(this.$data$39862);
						if (273556 - 129832 == 143725)
						{
							continue;
						}
						if (this.$result$39858 == 1)
						{
							if (224716 - 112337 == 112380)
							{
								continue;
							}
							this.$mCompleteGui$39859.displayResult(eCompleteType.Success);
							if (281238 - 153562 == 127677)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$39859.displayResult(eCompleteType.Failed);
							if (77604 - 153793 == -76188)
							{
								continue;
							}
						}
						this.$mGameGui$39860 = (GameGui)this.$self_$39863.GetComponent(typeof(GameGui));
						if (143273 - 564249 == -420975)
						{
							continue;
						}
						this.$mStoryGui$39861 = (StoryGui)this.$self_$39863.GetComponent(typeof(StoryGui));
						if (68254 - 196753 == -128498)
						{
							continue;
						}
						if (this.$mGameGui$39860)
						{
							if (23447 - 519750 == -496302)
							{
								continue;
							}
							this.$mGameGui$39860.close();
							if (57314 - 126550 == -69235)
							{
								continue;
							}
						}
						if (this.$mStoryGui$39861)
						{
							if (99005 - 79598 != 19407)
							{
								continue;
							}
							this.$mStoryGui$39861.close();
							if (91742 - 588024 != -496282)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (207124 - 422498 != -215373)
						{
							goto Block_2;
						}
						continue;
					default:
						if (221900 - 6666 == 215235)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$39862[31]);
					if (203891 - 467297 == -263406)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (42891 - 259942 != -217050)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (180948 - 264375 == -83427)
							{
								this.$result$39858 = RuntimeServices.UnboxInt32(this.$data$39862[31]);
								if (62910 - 545608 != -482697)
								{
									goto Block_9;
								}
							}
						}
					}
				}
				Block_2:
				goto IL_352;
				Block_9:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x060085AC RID: 34220 RVA: 0x010B5DF0 File Offset: 0x010B3FF0
			internal static bool rU0mh3pzPkin6DQUxkf8()
			{
				return true;
			}

			// Token: 0x060085AD RID: 34221 RVA: 0x010B5DF4 File Offset: 0x010B3FF4
			internal static bool tXFQJ7pz0mx8BSrIhkUR()
			{
				return false;
			}

			// Token: 0x04008244 RID: 33348
			internal int $result$39858;

			// Token: 0x04008245 RID: 33349
			internal CompleteGui $mCompleteGui$39859;

			// Token: 0x04008246 RID: 33350
			internal GameGui $mGameGui$39860;

			// Token: 0x04008247 RID: 33351
			internal StoryGui $mStoryGui$39861;

			// Token: 0x04008248 RID: 33352
			internal Hashtable $data$39862;

			// Token: 0x04008249 RID: 33353
			internal M604_SmashingPumpkon $self_$39863;
		}
	}

	// Token: 0x02001680 RID: 5760
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$39866 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060085AE RID: 34222 RVA: 0x010B5DF8 File Offset: 0x010B3FF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$39866(M604_SmashingPumpkon self_)
		{
			if (46795 - 502778 != -455982)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (180054 - 473947 != -293892)
				{
					base..ctor();
					if (265434 - 191653 != 73782)
					{
						this.$self_$39870 = self_;
						if (116084 - 320579 != -204494)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060085AF RID: 34223 RVA: 0x010B5E90 File Offset: 0x010B4090
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M604_SmashingPumpkon.$ReturnToTown$39866.$(this.$self_$39870);
		}

		// Token: 0x060085B0 RID: 34224 RVA: 0x010B5EA0 File Offset: 0x010B40A0
		internal static bool tanOeIpzbakxDy6JHf2S()
		{
			return true;
		}

		// Token: 0x060085B1 RID: 34225 RVA: 0x010B5EA4 File Offset: 0x010B40A4
		internal static bool DIdifvpzugHS07Wq1yoR()
		{
			return false;
		}

		// Token: 0x0400824A RID: 33354
		internal M604_SmashingPumpkon $self_$39870;

		// Token: 0x02001681 RID: 5761
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060085B2 RID: 34226 RVA: 0x010B5EA8 File Offset: 0x010B40A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M604_SmashingPumpkon self_)
			{
				if (4776 - 445093 != -440316)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (271053 - 285161 != -14107)
					{
						base..ctor();
						if (225965 - 156127 == 69838)
						{
							this.$self_$39869 = self_;
							if (70775 - 252212 != -181436)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060085B3 RID: 34227 RVA: 0x010B5F40 File Offset: 0x010B4140
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (105358 - 211922 != -106563)
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
						this.$self_$39869.LeaveGame();
						if (183146 - 94209 != 88937)
						{
							continue;
						}
						this.YieldDefault(1);
						if (25052 - 484422 != -459369)
						{
							goto Block_16;
						}
						continue;
					default:
						if (17877 - 246517 == -228639)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (55254 - 102489 != -47234)
					{
						Game.mStateTime = Time.time;
						if (127185 - 277307 != -150121)
						{
							this.$$switch$7035$39867 = PlayerData.SaveGuild;
							if (78016 - 259093 == -181077)
							{
								if (this.$$switch$7035$39867 == 1)
								{
									if (84052 - 367180 != -283128)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (16392 - 315019 != -298627)
									{
										continue;
									}
								}
								else if (this.$$switch$7035$39867 == 2)
								{
									if (121833 - 305519 == -183685)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (272364 - 133089 == 139276)
									{
										continue;
									}
								}
								else if (this.$$switch$7035$39867 == 3)
								{
									if (287181 - 160732 == 126450)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (158574 - 35546 == 123029)
									{
										continue;
									}
								}
								else if (this.$$switch$7035$39867 == 4)
								{
									if (83606 - 170520 != -86914)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (153423 - 10809 == 142615)
									{
										continue;
									}
								}
								else if (this.$$switch$7035$39867 == 5)
								{
									if (280882 - 119183 == 161700)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (186334 - 31304 != 155030)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (49796 - 448412 != -398616)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (156535 - 224667 == -68131)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (257231 - 453490 == -196258)
									{
										continue;
									}
								}
								this.$mGameGui$39868 = (GameGui)this.$self_$39869.GetComponent(typeof(GameGui));
								if (182387 - 173419 != 8969)
								{
									if (this.$mGameGui$39868)
									{
										if (19296 - 344869 == -325572)
										{
											continue;
										}
										this.$mGameGui$39868.close();
										if (269926 - 180974 == 88953)
										{
											continue;
										}
									}
									this.$self_$39869.SendMessage("fadeOut");
									if (23530 - 150029 == -126499)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_16:
				IL_3AD:
				return false;
			}

			// Token: 0x060085B4 RID: 34228 RVA: 0x010B630C File Offset: 0x010B450C
			internal static bool JOVHJApzIkG3b6DTlVTb()
			{
				return true;
			}

			// Token: 0x060085B5 RID: 34229 RVA: 0x010B6310 File Offset: 0x010B4510
			internal static bool mIMArOpzBRs1eX28M23U()
			{
				return false;
			}

			// Token: 0x0400824B RID: 33355
			internal int $$switch$7035$39867;

			// Token: 0x0400824C RID: 33356
			internal GameGui $mGameGui$39868;

			// Token: 0x0400824D RID: 33357
			internal M604_SmashingPumpkon $self_$39869;
		}
	}

	// Token: 0x02001682 RID: 5762
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$39871 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060085B6 RID: 34230 RVA: 0x010B6314 File Offset: 0x010B4514
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$39871(M604_SmashingPumpkon self_)
		{
			if (125150 - 547582 != -422431)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (275498 - 518109 != -242610)
				{
					base..ctor();
					if (262810 - 428167 != -165356)
					{
						this.$self_$39874 = self_;
						if (282690 - 34579 != 248112)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060085B7 RID: 34231 RVA: 0x010B63AC File Offset: 0x010B45AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M604_SmashingPumpkon.$ReturnToGuild$39871.$(this.$self_$39874);
		}

		// Token: 0x060085B8 RID: 34232 RVA: 0x010B63BC File Offset: 0x010B45BC
		internal static bool Et8bjZpzepfps8MTqcic()
		{
			return true;
		}

		// Token: 0x060085B9 RID: 34233 RVA: 0x010B63C0 File Offset: 0x010B45C0
		internal static bool EYOt69pzr2B39hfeU3Eu()
		{
			return false;
		}

		// Token: 0x0400824E RID: 33358
		internal M604_SmashingPumpkon $self_$39874;

		// Token: 0x02001683 RID: 5763
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060085BA RID: 34234 RVA: 0x010B63C4 File Offset: 0x010B45C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M604_SmashingPumpkon self_)
			{
				if (277747 - 130602 != 147146)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (262641 - 62017 == 200624)
					{
						base..ctor();
						if (186449 - 320770 == -134321)
						{
							this.$self_$39873 = self_;
							if (123741 - 84312 != 39430)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060085BB RID: 34235 RVA: 0x010B645C File Offset: 0x010B465C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (5689 - 315029 != -309340)
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
						this.$self_$39873.LeaveGame();
						if (125618 - 255489 != -129871)
						{
							continue;
						}
						this.YieldDefault(1);
						if (181712 - 299304 != -117591)
						{
							goto Block_5;
						}
						continue;
					default:
						if (244563 - 6965 == 237599)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (272008 - 425607 == -153599)
					{
						Game.mStateTime = Time.time;
						if (78101 - 156581 != -78479)
						{
							Game.mNextGameCode = 31;
							if (54054 - 167287 != -113232)
							{
								this.$mGameGui$39872 = (GameGui)this.$self_$39873.GetComponent(typeof(GameGui));
								if (196833 - 326032 != -129198)
								{
									if (this.$mGameGui$39872)
									{
										if (32462 - 25773 != 6689)
										{
											continue;
										}
										this.$mGameGui$39872.close();
										if (57124 - 428429 == -371304)
										{
											continue;
										}
									}
									this.$self_$39873.SendMessage("fadeOut");
									if (238301 - 32587 != 205715)
									{
										goto Block_8;
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_1BD;
				Block_8:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x060085BC RID: 34236 RVA: 0x010B6638 File Offset: 0x010B4838
			internal static bool lCCHISpzj3PmjUanjDSW()
			{
				return true;
			}

			// Token: 0x060085BD RID: 34237 RVA: 0x010B663C File Offset: 0x010B483C
			internal static bool TQFT6dpzh7VtMhFldoNl()
			{
				return false;
			}

			// Token: 0x0400824F RID: 33359
			internal GameGui $mGameGui$39872;

			// Token: 0x04008250 RID: 33360
			internal M604_SmashingPumpkon $self_$39873;
		}
	}

	// Token: 0x02001684 RID: 5764
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$39875 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060085BE RID: 34238 RVA: 0x010B6640 File Offset: 0x010B4840
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$39875(M604_SmashingPumpkon self_)
		{
			if (156963 - 557987 != -401023)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (107737 - 206097 == -98360)
				{
					base..ctor();
					if (76566 - 243230 != -166663)
					{
						this.$self_$39879 = self_;
						if (159038 - 280726 != -121687)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060085BF RID: 34239 RVA: 0x010B66D8 File Offset: 0x010B48D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M604_SmashingPumpkon.$ReturnToCamp$39875.$(this.$self_$39879);
		}

		// Token: 0x060085C0 RID: 34240 RVA: 0x010B66E8 File Offset: 0x010B48E8
		internal static bool YQuWpRpzsNfvabfeFnbF()
		{
			return true;
		}

		// Token: 0x060085C1 RID: 34241 RVA: 0x010B66EC File Offset: 0x010B48EC
		internal static bool XVha0gpz95yFK5mVyH7q()
		{
			return false;
		}

		// Token: 0x04008251 RID: 33361
		internal M604_SmashingPumpkon $self_$39879;

		// Token: 0x02001685 RID: 5765
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060085C2 RID: 34242 RVA: 0x010B66F0 File Offset: 0x010B48F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M604_SmashingPumpkon self_)
			{
				if (125678 - 492358 != -366679)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (67977 - 393297 == -325320)
					{
						base..ctor();
						if (53786 - 56839 == -3053)
						{
							this.$self_$39878 = self_;
							if (298587 - 597090 == -298503)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060085C3 RID: 34243 RVA: 0x010B6788 File Offset: 0x010B4988
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (125952 - 201377 != -75425)
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
						this.$self_$39878.LeaveGame();
						if (184639 - 483546 == -298906)
						{
							continue;
						}
						this.YieldDefault(1);
						if (275543 - 37297 != 238247)
						{
							goto Block_4;
						}
						continue;
					default:
						if (122009 - 501844 == -379834)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (96345 - 490145 == -393800)
					{
						Game.mStateTime = Time.time;
						if (212996 - 220419 == -7423)
						{
							this.$$switch$7037$39876 = PlayerData.SaveGuild;
							if (286240 - 186201 == 100039)
							{
								if (this.$$switch$7037$39876 == 1)
								{
									if (31931 - 595727 == -563795)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (274177 - 22845 == 251333)
									{
										continue;
									}
								}
								else if (this.$$switch$7037$39876 == 2)
								{
									if (4405 - 216717 != -212312)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (138826 - 241747 != -102921)
									{
										continue;
									}
								}
								else if (this.$$switch$7037$39876 == 3)
								{
									if (192038 - 253368 != -61330)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (10839 - 190834 == -179994)
									{
										continue;
									}
								}
								else if (this.$$switch$7037$39876 == 4)
								{
									if (161483 - 298879 != -137396)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (148868 - 343065 == -194196)
									{
										continue;
									}
								}
								else if (this.$$switch$7037$39876 == 5)
								{
									if (29640 - 76940 != -47300)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (261159 - 373268 == -112108)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (211347 - 419199 == -207851)
									{
										continue;
									}
								}
								this.$mGameGui$39877 = (GameGui)this.$self_$39878.GetComponent(typeof(GameGui));
								if (29991 - 226389 != -196397)
								{
									if (this.$mGameGui$39877)
									{
										if (52932 - 326760 == -273827)
										{
											continue;
										}
										this.$mGameGui$39877.close();
										if (134949 - 10421 == 124529)
										{
											continue;
										}
									}
									this.$self_$39878.SendMessage("fadeOut");
									if (152463 - 414884 == -262421)
									{
										goto IL_16B;
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_363;
				IL_16B:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x060085C4 RID: 34244 RVA: 0x010B6B0C File Offset: 0x010B4D0C
			internal static bool mUNmgVpz1m7iDQtvcDlg()
			{
				return true;
			}

			// Token: 0x060085C5 RID: 34245 RVA: 0x010B6B10 File Offset: 0x010B4D10
			internal static bool P9Tb3Bpz4dkEI08aIgfR()
			{
				return false;
			}

			// Token: 0x04008252 RID: 33362
			internal int $$switch$7037$39876;

			// Token: 0x04008253 RID: 33363
			internal GameGui $mGameGui$39877;

			// Token: 0x04008254 RID: 33364
			internal M604_SmashingPumpkon $self_$39878;
		}
	}
}
