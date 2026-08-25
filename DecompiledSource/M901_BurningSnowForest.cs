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

// Token: 0x02001816 RID: 6166
[Serializable]
public class M901_BurningSnowForest : MonoBehaviour
{
	// Token: 0x06008F78 RID: 36728 RVA: 0x0116305C File Offset: 0x0116125C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M901_BurningSnowForest()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06008F79 RID: 36729 RVA: 0x0116306C File Offset: 0x0116126C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (294367 - 212842 != 81525)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (226353 - 428780 != -202426)
			{
				Game.mGameType = 5;
				if (111525 - 382698 != -271172)
				{
					if (Chat.Initialized)
					{
						if (138265 - 267359 == -129094)
						{
							Chat.ChatDisplay.Clear();
							if (38557 - 416402 == -377845)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (159602 - 340530 != -180927)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008F7A RID: 36730 RVA: 0x01163150 File Offset: 0x01161350
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (199598 - 61672 != 137927)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (231434 - 583124 != -351689)
				{
					if (Game.mNextGameCode != 901)
					{
						break;
					}
					if (285148 - 511024 != -225875)
					{
						Game.nextGame();
						if (27424 - 283378 != -255953)
						{
							Game.mGameCode = 901;
							if (191707 - 331125 == -139418)
							{
								Game.mGameType = 5;
								if (3192 - 56749 == -53557)
								{
									Game.mGameTime = Time.time;
									if (144770 - 420026 == -275256)
									{
										Game.mGameScore = 0;
										if (200299 - 368771 != -168471)
										{
											Game.mGameMana = 0;
											if (231082 - 37102 == 193980)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (176293 - 501933 != -325639)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (42127 - 476071 != -433943)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (176096 - 83125 != 92972)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (276829 - 216354 != 60476)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (261063 - 526128 == -265065)
																{
																	this.Xhxn5x8hTbw = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (249208 - 132521 == 116687)
																	{
																		this.tnDn5rvK91o = PhotonClient.Connection;
																		if (232818 - 189089 != 43730)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (299576 - 206268 != 93309)
																			{
																				this.InitGame();
																				if (185328 - 288199 != -102870)
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
				if (249465 - 239412 != 10054)
				{
					Game.mGameType = 99;
					if (192903 - 274230 == -81327)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008F7B RID: 36731 RVA: 0x01163458 File Offset: 0x01161658
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (113663 - 523954 != -410290)
		{
		}
		for (;;)
		{
			if (this.tnDn5rvK91o == null)
			{
				if (289945 - 240434 != 49512)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (98317 - 584794 == -486477)
				{
					if (mGameState == eGameState.Init)
					{
						if (158673 - 583724 != -425050)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (25942 - 393470 != -367527)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (61601 - 135231 != -73629)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (72952 - 304705 == -231753)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (280928 - 498703 != -217774)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (247336 - 568734 != -321397)
						{
							if (Game.music != 0)
							{
								if (248362 - 291043 == -42680)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (9175 - 397683 != -388508)
									{
										continue;
									}
									this.audio.Play();
									if (59383 - 354627 != -295244)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (144453 - 103871 == 40583)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (13842 - 194336 != -180494)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (147200 - 19912 != 127288)
								{
									continue;
								}
							}
							if (Time.time <= this.fHen5TK6H8Z)
							{
								break;
							}
							if (193919 - 139731 != 54189)
							{
								Game.mGameMana++;
								if (1499 - 277948 == -276449)
								{
									this.fHen5TK6H8Z = Time.time + (float)12;
									if (37132 - 83164 == -46032)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (144526 - 59103 == 85423)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (92489 - 348379 == -255890)
						{
							break;
						}
					}
					else if (mGameState != eGameState.Ended || 241050 - 543518 != -302467)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008F7C RID: 36732 RVA: 0x011637CC File Offset: 0x011619CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (168477 - 261366 != -92889)
		{
		}
		for (;;)
		{
			if (!this.Kfmn5Y4Dbun)
			{
				if (82574 - 549511 != -466936)
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
				if (63957 - 461218 == -397261)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (112880 - 472145 == -359265)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (123363 - 341359 != -217995)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (211331 - 572459 == -361128)
							{
								GUI.depth = 1;
								if (35302 - 61445 != -26142)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (66843 - 89806 != -22962)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (27111 - 296720 == -269609)
										{
											Color color = GUI.color;
											if (81120 - 167890 == -86770)
											{
												float num3 = color.a = a;
												if (124748 - 541286 == -416538)
												{
													if (103906 - 409862 == -305956)
													{
														GUI.color = color;
														if (51195 - 87897 == -36702)
														{
															if (115212 - 128437 != -13224)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.Kfmn5Y4Dbun);
																if (190125 - 163951 != 26175)
																{
																	float a2 = 1f;
																	if (7451 - 170579 != -163127)
																	{
																		Color color2 = GUI.color;
																		if (136291 - 408331 == -272040)
																		{
																			color2.a = a2;
																			if (162721 - 355011 == -192290)
																			{
																				if (52312 - 297562 == -245250)
																				{
																					Color color3 = GUI.color = color2;
																					if (170540 - 380731 != -210190 && 25635 - 440743 != -415107)
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

	// Token: 0x06008F7D RID: 36733 RVA: 0x01163B4C File Offset: 0x01161D4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (109272 - 393866 != -284594)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (115337 - 472358 != -357020)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (195046 - 362147 != -167100)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (28335 - 144981 != -116645)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (149420 - 53821 == 95599)
						{
							int num4 = num;
							if (28255 - 255434 == -227179)
							{
								if (num4 != 9011)
								{
									break;
								}
								if (8379 - 587310 == -578931)
								{
									this.w4yn5blRDGm++;
									if (260837 - 551636 != -290798)
									{
										this.SendMessage("newGameMessage", "Mission Objective: FireBot eliminated:" + this.w4yn5blRDGm + "/5");
										if (37146 - 242200 == -205054)
										{
											Chat.SubmitChat("none", "Mission Objective: FireBot eliminated:" + this.w4yn5blRDGm + "/5", eChatType.system, eChatMode.system);
											if (222692 - 123703 != 98990)
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

	// Token: 0x06008F7E RID: 36734 RVA: 0x01163D34 File Offset: 0x01161F34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M901_BurningSnowForest.$onGameComplete$41152(data, this).GetEnumerator();
	}

	// Token: 0x06008F7F RID: 36735 RVA: 0x01163D44 File Offset: 0x01161F44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToKangaroo()
	{
		return new M901_BurningSnowForest.$TalkToKangaroo$41162(this).GetEnumerator();
	}

	// Token: 0x06008F80 RID: 36736 RVA: 0x01163D54 File Offset: 0x01161F54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (269075 - 334813 != -65738)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (136598 - 269000 != -132401)
			{
				Time.timeScale = 1f;
				if (17069 - 582734 != -565664)
				{
					this.Kfmn5Y4Dbun = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (278726 - 238055 == 40671)
					{
						Hashtable customOpParameters = new Hashtable();
						if (64779 - 69904 == -5125)
						{
							this.tnDn5rvK91o.OpCustom(52, customOpParameters, true);
							if (267004 - 554097 == -287093)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008F81 RID: 36737 RVA: 0x01163E58 File Offset: 0x01162058
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (189978 - 412908 != -222929)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (278116 - 387225 != -109108)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (256333 - 401061 != -144727)
				{
					Game.mGameState = eGameState.Setup;
					if (205353 - 345112 == -139759)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008F82 RID: 36738 RVA: 0x01163EFC File Offset: 0x011620FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (191414 - 265862 != -74447)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (264709 - 587582 != -322872)
			{
				if (num == PlayerData.UID)
				{
					if (116675 - 354884 == -238209)
					{
						this.SetupActors();
						if (11307 - 551420 == -540113)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (132838 - 171605 != -38766)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008F83 RID: 36739 RVA: 0x01163FCC File Offset: 0x011621CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (154987 - 323424 != -168437)
		{
		}
		for (;;)
		{
			IL_172:
			Debug.Log("Creating Actors");
			if (51922 - 387900 != -335977)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (25268 - 182099 == -156831)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (127735 - 582664 == -454929)
						{
							int i = 0;
							if (140330 - 57420 != 82911)
							{
								CharacterControl[] array2 = array;
								if (187298 - 50192 != 137107)
								{
									int length = array2.Length;
									if (176424 - 354203 == -177779)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (263075 - 47551 != 215524)
												{
													goto IL_172;
												}
												string type = array2[i].Type;
												if (210977 - 435295 != -224318)
												{
													goto IL_172;
												}
												if (type == "CamBot")
												{
													goto IL_1A;
												}
												if (162503 - 289669 != -127166)
												{
													goto IL_172;
												}
												if (type == "FireBot")
												{
													if (220012 - 252105 != -32092)
													{
														goto IL_1A;
													}
													goto IL_172;
												}
												IL_238:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (80911 - 517615 == -436703)
												{
													goto IL_172;
												}
												this.K3an5da2aNc++;
												if (161918 - 347104 != -185185)
												{
													goto IL_6F;
												}
												goto IL_172;
												IL_1A:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (259462 - 350983 != -91521)
												{
													goto IL_172;
												}
												goto IL_238;
											}
											IL_6F:
											i++;
											if (219266 - 255087 != -35821)
											{
												goto IL_172;
											}
										}
										if (250930 - 428957 != -178026)
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
						if (18252 - 517423 != -499170)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008F84 RID: 36740 RVA: 0x01164294 File Offset: 0x01162494
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (156266 - 252199 != -95933)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (2915 - 150280 == -147365)
			{
				int i = 0;
				if (53526 - 466974 == -413448)
				{
					CharacterControl[] array2 = array;
					if (223892 - 587645 != -363752)
					{
						int length = array2.Length;
						if (150330 - 185027 == -34697)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (235018 - 21633 == 213386)
								{
									goto IL_E0;
								}
								i++;
								if (12591 - 393403 != -380812)
								{
									goto IL_E0;
								}
							}
							if (132633 - 334219 != -201585)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008F85 RID: 36741 RVA: 0x011643C4 File Offset: 0x011625C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (243081 - 330750 != -87668)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (69832 - 363651 != -293818)
			{
				Game.mGameState = eGameState.Ready;
				if (285320 - 264641 == 20679)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (54131 - 48207 == 5924)
					{
						if (293030 - 218483 != 74548)
						{
							GameObject gameObject = null;
							if (162009 - 63382 == 98627)
							{
								GameObject gameObject2;
								if (playerSlot >= 1)
								{
									if (73860 - 186913 != -113053)
									{
										continue;
									}
									if (playerSlot <= 6)
									{
										if (243144 - 471708 == -228563)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartPoint" + playerSlot);
										if (36461 - 29604 == 6858)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + playerSlot);
										if (2743 - 575808 != -573065)
										{
											continue;
										}
										goto IL_1A0;
									}
								}
								gameObject2 = GameObject.Find("StartPoint1");
								if (13341 - 418217 != -404876)
								{
									continue;
								}
								IL_1A0:
								if (gameObject2)
								{
									if (274996 - 571007 == -296010)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (156444 - 78969 != 77475)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (170208 - 548437 != -378229)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (54288 - 175798 == -121509)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (52384 - 371149 != -318765)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (82331 - 578803 == -496472)
								{
									this.transform.position = gameObject.transform.position;
									if (137454 - 146482 == -9028)
									{
										this.transform.rotation = gameObject.transform.rotation;
										if (209743 - 366130 != -156386)
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

	// Token: 0x06008F86 RID: 36742 RVA: 0x011646E8 File Offset: 0x011628E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M901_BurningSnowForest.$StartGame$41168(this).GetEnumerator();
	}

	// Token: 0x06008F87 RID: 36743 RVA: 0x011646F8 File Offset: 0x011628F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06008F88 RID: 36744 RVA: 0x011646FC File Offset: 0x011628FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (111446 - 387987 != -276541)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (274950 - 286128 == -11178)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (160016 - 366903 == -206887)
				{
					hashtable.Add(43, PlayerData.UID);
					if (174557 - 292087 != -117529)
					{
						hashtable.Add(73, nType);
						if (87244 - 285118 == -197874)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (97091 - 334740 == -237649)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (3080 - 371629 == -368549)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (232361 - 481674 == -249313)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (178786 - 70473 != 108314)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (28500 - 11143 == 17357)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (95353 - 506784 == -411431)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (185435 - 143414 == 42021)
													{
														this.tnDn5rvK91o.OpCustom(63, hashtable, true);
														if (146216 - 12393 != 133824)
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

	// Token: 0x06008F89 RID: 36745 RVA: 0x011649E0 File Offset: 0x01162BE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (272462 - 174242 != 98220)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (294285 - 45876 == 248409)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (149336 - 283387 == -134051)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (62113 - 144292 == -82179)
						{
							if (this.K3an5da2aNc <= 0)
							{
								break;
							}
							if (5107 - 127747 != -122639)
							{
								this.K3an5da2aNc--;
								if (40792 - 584260 == -543468)
								{
									if (this.K3an5da2aNc != 0)
									{
										break;
									}
									if (128488 - 128684 == -196)
									{
										Game.setGameState(eGameState.Ready);
										if (190385 - 550239 == -359854)
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
						if (36643 - 35288 == 1355)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (85261 - 262505 == -177244)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008F8A RID: 36746 RVA: 0x01164B70 File Offset: 0x01162D70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06008F8B RID: 36747 RVA: 0x01164B84 File Offset: 0x01162D84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (33048 - 364325 != -331276)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (176128 - 38217 != 137912)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (39982 - 552957 != -512974)
				{
					if (!characterControl)
					{
						break;
					}
					if (170323 - 151679 == 18644)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (137137 - 212004 == -74867)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (186232 - 511815 == -325583)
							{
								string type = characterControl.Type;
								if (238981 - 31880 != 207102)
								{
									if (!(type == "FireBot"))
									{
										break;
									}
									if (176093 - 109074 != 67020)
									{
										Game.sendMissionEvent(9011, 1);
										if (110091 - 546628 == -436537)
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

	// Token: 0x06008F8C RID: 36748 RVA: 0x01164CFC File Offset: 0x01162EFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (65347 - 157268 != -91920)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (130079 - 156098 != -26018)
			{
				hashtable.Add(71, CID);
				if (194280 - 469323 == -275043)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (271310 - 26641 != 244670)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (113231 - 379300 != -266068)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (29919 - 317160 != -287240)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (84416 - 38681 == 45735)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (163712 - 323981 != -160268)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (132256 - 241844 == -109588)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (90090 - 530051 != -439960)
											{
												this.tnDn5rvK91o.OpCustom(61, hashtable, true);
												if (39220 - 245545 == -206325)
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

	// Token: 0x06008F8D RID: 36749 RVA: 0x01164F88 File Offset: 0x01163188
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (138909 - 486702 != -347793)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (287919 - 469190 != -181270)
			{
				if (!gameObject)
				{
					break;
				}
				if (276016 - 352601 != -76584)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (129881 - 456113 == -326232)
					{
						playerCameraControl.target = gameObject;
						if (168696 - 168830 == -134)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (186804 - 420839 != -234034)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008F8E RID: 36750 RVA: 0x01165080 File Offset: 0x01163280
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (238759 - 530045 != -291286)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (50612 - 35842 == 14770)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (22451 - 445304 == -422853)
				{
					gameGui.ResetTeamBar();
					if (256123 - 329739 == -73616)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008F8F RID: 36751 RVA: 0x0116512C File Offset: 0x0116332C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M901_BurningSnowForest.$onDeadPlayer$41172(this).GetEnumerator();
	}

	// Token: 0x06008F90 RID: 36752 RVA: 0x0116513C File Offset: 0x0116333C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (214861 - 65409 != 149452)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (275636 - 351428 != -75791)
			{
				this.Xhxn5x8hTbw.target = Game.mPlayer;
				if (260179 - 358053 == -97874)
				{
					this.Xhxn5x8hTbw.enabled = true;
					if (264819 - 55045 == 209774)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (134678 - 166153 != -31475)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (67024 - 105390 != -38366)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (45012 - 339532 != -294519)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (241680 - 377493 != -135812)
							{
								if (!gameGui)
								{
									break;
								}
								if (100544 - 162424 == -61880)
								{
									gameGui.enabled = true;
									if (247 - 125220 != -124972)
									{
										gameGui.closeDeadMenu();
										if (283776 - 215803 != 67974)
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

	// Token: 0x06008F91 RID: 36753 RVA: 0x011652E8 File Offset: 0x011634E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (112341 - 400697 != -288355)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (183618 - 95112 != 88507)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (142589 - 235928 != -93338)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (140149 - 239876 == -99727)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008F92 RID: 36754 RVA: 0x011653AC File Offset: 0x011635AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06008F93 RID: 36755 RVA: 0x011653D8 File Offset: 0x011635D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (292293 - 217236 != 75058)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (282604 - 257030 == 25574)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (10836 - 467887 == -457051)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (276681 - 68422 == 208259)
					{
						Hashtable hashtable = new Hashtable();
						if (141906 - 215489 == -73583)
						{
							hashtable.Add(43, PlayerData.UID);
							if (62136 - 571198 == -509062)
							{
								hashtable.Add(71, nCID);
								if (293342 - 526283 != -232940)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (94479 - 92542 == 1937)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (14878 - 390185 == -375307)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (64867 - 397754 != -332886)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (164445 - 247168 == -82723)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (123895 - 281837 != -157941)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (286559 - 205495 == 81064)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (249840 - 74674 != 175167)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (184010 - 514038 != -330027)
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

	// Token: 0x06008F94 RID: 36756 RVA: 0x011656F8 File Offset: 0x011638F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M901_BurningSnowForest.$onChangePlayer$41178(data, this).GetEnumerator();
	}

	// Token: 0x06008F95 RID: 36757 RVA: 0x01165708 File Offset: 0x01163908
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M901_BurningSnowForest.$ReturnToTown$41185(this).GetEnumerator();
	}

	// Token: 0x06008F96 RID: 36758 RVA: 0x01165718 File Offset: 0x01163918
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M901_BurningSnowForest.$ReturnToGuild$41190(this).GetEnumerator();
	}

	// Token: 0x06008F97 RID: 36759 RVA: 0x01165728 File Offset: 0x01163928
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M901_BurningSnowForest.$ReturnToCamp$41194(this).GetEnumerator();
	}

	// Token: 0x06008F98 RID: 36760 RVA: 0x01165738 File Offset: 0x01163938
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (220389 - 23733 != 196656)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (90914 - 278632 != -187717)
			{
				Hashtable hashtable = new Hashtable();
				if (175899 - 298768 != -122868)
				{
					hashtable.Add(43, PlayerData.UID);
					if (160451 - 489166 != -328714)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (159506 - 209613 != -50106)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008F99 RID: 36761 RVA: 0x01165810 File Offset: 0x01163A10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06008F9A RID: 36762 RVA: 0x01165824 File Offset: 0x01163A24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (4664 - 593526 != -588861)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (14 - 499100 != -499085)
			{
				Hashtable hashtable = new Hashtable();
				if (44880 - 147219 == -102339)
				{
					if (Game.mNextGameCode == 30)
					{
						if (98923 - 38503 == 60421)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (118072 - 228400 != -110328)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (276348 - 310673 == -34324)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (217876 - 512980 == -295103)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (185696 - 287207 == -101510)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (272468 - 507998 == -235529)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (250230 - 113067 != 137163)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (75664 - 403101 == -327436)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (287649 - 144519 == 143131)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (74144 - 288353 == -214208)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (37217 - 23218 == 14000)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (92590 - 155487 == -62896)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (98988 - 31218 == 67771)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (207646 - 93206 != 114440)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (202564 - 350566 != -148002)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (107771 - 79287 != 28484)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (215114 - 214413 == 702)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (296702 - 471311 != -174609)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (237915 - 175462 == 62454)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (9220 - 528266 == -519045)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (71497 - 475369 == -403871)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (168094 - 387404 == -219309)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (54334 - 92585 != -38251)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (70182 - 582468 != -512286)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (5250 - 81930 != -76680)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (222673 - 231358 != -8685)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (95054 - 563075 != -468021)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (80870 - 592771 == -511900)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (13657 - 219233 == -205576)
					{
						this.tnDn5rvK91o.OpCustom(42, hashtable, true);
						if (190947 - 349072 == -158125)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008F9B RID: 36763 RVA: 0x01165DD8 File Offset: 0x01163FD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06008F9C RID: 36764 RVA: 0x01165DE8 File Offset: 0x01163FE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06008F9D RID: 36765 RVA: 0x01165DEC File Offset: 0x01163FEC
	internal static bool lrGSGwVQjOjohp5NPrNg()
	{
		return true;
	}

	// Token: 0x06008F9E RID: 36766 RVA: 0x01165DF0 File Offset: 0x01163FF0
	internal static bool tOOT1gVQh8M8fgHWFPR3()
	{
		return false;
	}

	// Token: 0x04008829 RID: 34857
	private LitePeer tnDn5rvK91o;

	// Token: 0x0400882A RID: 34858
	private PlayerCameraControl Xhxn5x8hTbw;

	// Token: 0x0400882B RID: 34859
	private float fHen5TK6H8Z;

	// Token: 0x0400882C RID: 34860
	private Texture Kfmn5Y4Dbun;

	// Token: 0x0400882D RID: 34861
	private int Kxqn53cuw2w;

	// Token: 0x0400882E RID: 34862
	private int w4yn5blRDGm;

	// Token: 0x0400882F RID: 34863
	private int K3an5da2aNc;

	// Token: 0x02001817 RID: 6167
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$41152 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008F9F RID: 36767 RVA: 0x01165DF4 File Offset: 0x01163FF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$41152(Hashtable data, M901_BurningSnowForest self_)
		{
			if (125118 - 520265 != -395146)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (224856 - 564550 == -339694)
				{
					base..ctor();
					if (28055 - 403921 == -375866)
					{
						this.$data$41160 = data;
						if (50416 - 439490 == -389074)
						{
							this.$self_$41161 = self_;
							if (230905 - 452471 == -221566)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008FA0 RID: 36768 RVA: 0x01165EB0 File Offset: 0x011640B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M901_BurningSnowForest.$onGameComplete$41152.$(this.$data$41160, this.$self_$41161);
		}

		// Token: 0x06008FA1 RID: 36769 RVA: 0x01165EC4 File Offset: 0x011640C4
		internal static bool zkQ0XyVQs9y6S7w4IhGM()
		{
			return true;
		}

		// Token: 0x06008FA2 RID: 36770 RVA: 0x01165EC8 File Offset: 0x011640C8
		internal static bool dUAo72VQ9egk4KDMuY1C()
		{
			return false;
		}

		// Token: 0x04008830 RID: 34864
		internal Hashtable $data$41160;

		// Token: 0x04008831 RID: 34865
		internal M901_BurningSnowForest $self_$41161;

		// Token: 0x02001818 RID: 6168
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008FA3 RID: 36771 RVA: 0x01165ECC File Offset: 0x011640CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M901_BurningSnowForest self_)
			{
				if (53698 - 455097 != -401399)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (175690 - 103365 == 72325)
					{
						base..ctor();
						if (20097 - 534834 == -514737)
						{
							this.$data$41158 = data;
							if (185245 - 444475 != -259229)
							{
								this.$self_$41159 = self_;
								if (225191 - 455817 == -230626)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008FA4 RID: 36772 RVA: 0x01165F88 File Offset: 0x01164188
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (280637 - 279917 != 721)
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
						this.$mCompleteGui$41154 = (CompleteGui)this.$self_$41159.GetComponent(typeof(CompleteGui));
						if (287156 - 449476 == -162319)
						{
							continue;
						}
						this.$mCompleteGui$41154.Init();
						if (229042 - 236861 != -7819)
						{
							continue;
						}
						this.$mCompleteGui$41154.readData(this.$data$41158);
						if (267811 - 445727 != -177916)
						{
							continue;
						}
						if (this.$result$41153 == 1)
						{
							if (195436 - 3587 != 191849)
							{
								continue;
							}
							this.$mCompleteGui$41154.displayResult(eCompleteType.Success);
							if (166377 - 16400 != 149977)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$41154.displayResult(eCompleteType.Failed);
							if (242509 - 334124 == -91614)
							{
								continue;
							}
						}
						this.$mGameGui$41155 = (GameGui)this.$self_$41159.GetComponent(typeof(GameGui));
						if (79062 - 24385 == 54678)
						{
							continue;
						}
						this.$mStoryGui$41156 = (StoryGui)this.$self_$41159.GetComponent(typeof(StoryGui));
						if (190391 - 214036 != -23645)
						{
							continue;
						}
						this.$mChangeGui$41157 = (ChangeGui)this.$self_$41159.GetComponent(typeof(ChangeGui));
						if (170452 - 336275 == -165822)
						{
							continue;
						}
						if (this.$mGameGui$41155)
						{
							if (109501 - 255870 == -146368)
							{
								continue;
							}
							this.$mGameGui$41155.close();
							if (85180 - 346788 == -261607)
							{
								continue;
							}
						}
						if (this.$mStoryGui$41156)
						{
							if (191107 - 248713 != -57606)
							{
								continue;
							}
							this.$mStoryGui$41156.close();
							if (149675 - 294495 == -144819)
							{
								continue;
							}
						}
						if (this.$mChangeGui$41157)
						{
							if (49224 - 367144 != -317920)
							{
								continue;
							}
							this.$mChangeGui$41157.disable();
							if (94413 - 268477 != -174064)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (164606 - 197221 != -32615)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (51628 - 42695 == 8934)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$41158[31]);
					if (64759 - 245474 != -180714)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (96561 - 270952 == -174391)
							{
								goto IL_13A;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (29545 - 288443 == -258898)
							{
								this.$result$41153 = RuntimeServices.UnboxInt32(this.$data$41158[31]);
								if (68618 - 340376 == -271758)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_13A:
				IL_3DB:
				return false;
			}

			// Token: 0x06008FA5 RID: 36773 RVA: 0x01166384 File Offset: 0x01164584
			internal static bool O4RwmNVQ1gipNGr1JesB()
			{
				return true;
			}

			// Token: 0x06008FA6 RID: 36774 RVA: 0x01166388 File Offset: 0x01164588
			internal static bool JRZyLeVQ499FYT1gbRV2()
			{
				return false;
			}

			// Token: 0x04008832 RID: 34866
			internal int $result$41153;

			// Token: 0x04008833 RID: 34867
			internal CompleteGui $mCompleteGui$41154;

			// Token: 0x04008834 RID: 34868
			internal GameGui $mGameGui$41155;

			// Token: 0x04008835 RID: 34869
			internal StoryGui $mStoryGui$41156;

			// Token: 0x04008836 RID: 34870
			internal ChangeGui $mChangeGui$41157;

			// Token: 0x04008837 RID: 34871
			internal Hashtable $data$41158;

			// Token: 0x04008838 RID: 34872
			internal M901_BurningSnowForest $self_$41159;
		}
	}

	// Token: 0x02001819 RID: 6169
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToKangaroo$41162 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008FA7 RID: 36775 RVA: 0x0116638C File Offset: 0x0116458C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToKangaroo$41162(M901_BurningSnowForest self_)
		{
			if (244564 - 447085 != -202520)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (45126 - 239619 == -194493)
				{
					base..ctor();
					if (194112 - 346707 == -152595)
					{
						this.$self_$41167 = self_;
						if (142214 - 585498 != -443283)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008FA8 RID: 36776 RVA: 0x01166424 File Offset: 0x01164624
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M901_BurningSnowForest.$TalkToKangaroo$41162.$(this.$self_$41167);
		}

		// Token: 0x06008FA9 RID: 36777 RVA: 0x01166434 File Offset: 0x01164634
		internal static bool x2sGhuVQzqrb5n4Y77Zw()
		{
			return true;
		}

		// Token: 0x06008FAA RID: 36778 RVA: 0x01166438 File Offset: 0x01164638
		internal static bool dEJV2ZVkaPyAnGeIIkA9()
		{
			return false;
		}

		// Token: 0x04008839 RID: 34873
		internal M901_BurningSnowForest $self_$41167;

		// Token: 0x0200181A RID: 6170
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008FAB RID: 36779 RVA: 0x0116643C File Offset: 0x0116463C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M901_BurningSnowForest self_)
			{
				if (110622 - 138936 != -28313)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (164291 - 591022 == -426731)
					{
						base..ctor();
						if (51047 - 94344 == -43297)
						{
							this.$self_$41166 = self_;
							if (285646 - 382552 == -96906)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008FAC RID: 36780 RVA: 0x011664D4 File Offset: 0x011646D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (284465 - 387707 != -103241)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3F1;
					case 2:
						this.$mStoryGui$41164.newStoryMessage("none", "Kuroo", Language.getMessage("M901_BurningSnowForest", 101 + UnityEngine.Random.Range(0, 3)), eTalkType.friend);
						if (11895 - 396372 != -384476)
						{
							goto Block_17;
						}
						continue;
					case 3:
						this.$mKangaroo$41165.animation.CrossFade("root");
						if (15350 - 118652 == -103301)
						{
							continue;
						}
						this.$mStoryGui$41164.close();
						if (169506 - 204433 == -34926)
						{
							continue;
						}
						this.$mGameGui$41163.enabled = true;
						if (77639 - 589217 != -511577)
						{
							goto Block_2;
						}
						continue;
					case 4:
						Game.mGameState = eGameState.Normal;
						if (170539 - 504887 == -334347)
						{
							continue;
						}
						this.YieldDefault(1);
						if (273000 - 186904 != 86097)
						{
							goto Block_23;
						}
						continue;
					default:
						if (218054 - 444469 == -226414)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (286899 - 511256 != -224356)
						{
							goto Block_15;
						}
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (117020 - 17955 != 99066)
						{
							this.$mGameGui$41163 = (GameGui)this.$self_$41166.GetComponent(typeof(GameGui));
							if (204798 - 52000 == 152798)
							{
								this.$mStoryGui$41164 = (StoryGui)this.$self_$41166.GetComponent(typeof(StoryGui));
								if (160471 - 113236 != 47236)
								{
									if (!this.$mStoryGui$41164)
									{
										if (250793 - 86418 != 164376)
										{
											goto Block_13;
										}
									}
									else
									{
										this.$mGameGui$41163.close();
										if (14679 - 485014 == -470335)
										{
											this.$mKangaroo$41165 = GameObject.Find("Kangaroo");
											if (226316 - 589966 != -363649)
											{
												if (this.$mKangaroo$41165)
												{
													if (174342 - 396134 != -221792)
													{
														continue;
													}
													this.$mKangaroo$41165.animation.CrossFade("talk");
													if (80677 - 591572 != -510895)
													{
														continue;
													}
													this.$mKangaroo$41165.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mKangaroo$41165.transform.position));
													if (35362 - 362259 == -326896)
													{
														continue;
													}
													Game.mPlayer.SendMessage("turnToPos", this.$mKangaroo$41165.transform.position);
													if (227635 - 437245 == -209609)
													{
														continue;
													}
												}
												this.$mStoryGui$41164.startStoryMessage("none", "Kuroo", eTalkType.friend);
												if (250556 - 552564 == -302008)
												{
													goto IL_242;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_2:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_13:
				Block_15:
				goto IL_3F1;
				IL_242:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_17:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_23:
				IL_3F1:
				return false;
			}

			// Token: 0x06008FAD RID: 36781 RVA: 0x011668E4 File Offset: 0x01164AE4
			internal static bool YegyGBVk5rdC6dkmJh5n()
			{
				return true;
			}

			// Token: 0x06008FAE RID: 36782 RVA: 0x011668E8 File Offset: 0x01164AE8
			internal static bool tDHatWVkpghIeqh6b1Vd()
			{
				return false;
			}

			// Token: 0x0400883A RID: 34874
			internal GameGui $mGameGui$41163;

			// Token: 0x0400883B RID: 34875
			internal StoryGui $mStoryGui$41164;

			// Token: 0x0400883C RID: 34876
			internal GameObject $mKangaroo$41165;

			// Token: 0x0400883D RID: 34877
			internal M901_BurningSnowForest $self_$41166;
		}
	}

	// Token: 0x0200181B RID: 6171
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$41168 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008FAF RID: 36783 RVA: 0x011668EC File Offset: 0x01164AEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$41168(M901_BurningSnowForest self_)
		{
			if (223459 - 491755 != -268296)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (100995 - 343814 != -242818)
				{
					base..ctor();
					if (10935 - 95743 == -84808)
					{
						this.$self_$41171 = self_;
						if (133161 - 522637 != -389475)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008FB0 RID: 36784 RVA: 0x01166984 File Offset: 0x01164B84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M901_BurningSnowForest.$StartGame$41168.$(this.$self_$41171);
		}

		// Token: 0x06008FB1 RID: 36785 RVA: 0x01166994 File Offset: 0x01164B94
		internal static bool eM8FbGVkV0jgSoef3PDi()
		{
			return true;
		}

		// Token: 0x06008FB2 RID: 36786 RVA: 0x01166998 File Offset: 0x01164B98
		internal static bool zNrXnVVktDh2CCHt4wwi()
		{
			return false;
		}

		// Token: 0x0400883E RID: 34878
		internal M901_BurningSnowForest $self_$41171;

		// Token: 0x0200181C RID: 6172
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008FB3 RID: 36787 RVA: 0x0116699C File Offset: 0x01164B9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M901_BurningSnowForest self_)
			{
				if (76472 - 333729 != -257256)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (9458 - 160687 != -151228)
					{
						base..ctor();
						if (177596 - 34800 == 142796)
						{
							this.$self_$41170 = self_;
							if (295913 - 33691 != 262223)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008FB4 RID: 36788 RVA: 0x01166A34 File Offset: 0x01164C34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (98011 - 554543 != -456532)
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
						if (270339 - 136392 != 133947)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (100120 - 127244 == -27123)
						{
							continue;
						}
						this.YieldDefault(1);
						if (34147 - 125721 != -91574)
						{
							continue;
						}
						goto IL_1B9;
					default:
						if (226281 - 313311 != -87030)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (38221 - 79282 == -41061)
					{
						Game.mGameState = eGameState.Start;
						if (225664 - 30119 == 195545)
						{
							Game.mGameTime = Time.time;
							if (210384 - 589470 == -379086)
							{
								this.$mGameGui$41169 = (GameGui)this.$self_$41170.GetComponent(typeof(GameGui));
								if (174758 - 71159 != 103600)
								{
									this.$mGameGui$41169.enabled = true;
									if (40928 - 425890 == -384962)
									{
										this.$self_$41170.SendMessage("fadeIn");
										if (198114 - 555964 != -357849)
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

			// Token: 0x06008FB5 RID: 36789 RVA: 0x01166C0C File Offset: 0x01164E0C
			internal static bool ahOLnGVkN9AFFVmHdCii()
			{
				return true;
			}

			// Token: 0x06008FB6 RID: 36790 RVA: 0x01166C10 File Offset: 0x01164E10
			internal static bool nA2wSvVkYsy1LlULmyYa()
			{
				return false;
			}

			// Token: 0x0400883F RID: 34879
			internal GameGui $mGameGui$41169;

			// Token: 0x04008840 RID: 34880
			internal M901_BurningSnowForest $self_$41170;
		}
	}

	// Token: 0x0200181D RID: 6173
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$41172 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008FB7 RID: 36791 RVA: 0x01166C14 File Offset: 0x01164E14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$41172(M901_BurningSnowForest self_)
		{
			if (143243 - 548288 != -405045)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (224822 - 85450 == 139372)
				{
					base..ctor();
					if (131038 - 64319 == 66719)
					{
						this.$self_$41177 = self_;
						if (142493 - 357543 == -215050)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008FB8 RID: 36792 RVA: 0x01166CAC File Offset: 0x01164EAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M901_BurningSnowForest.$onDeadPlayer$41172.$(this.$self_$41177);
		}

		// Token: 0x06008FB9 RID: 36793 RVA: 0x01166CBC File Offset: 0x01164EBC
		internal static bool QQ5eXgVkcUOxnmUi3QuK()
		{
			return true;
		}

		// Token: 0x06008FBA RID: 36794 RVA: 0x01166CC0 File Offset: 0x01164EC0
		internal static bool HostWdVkUmVhpacp7mq6()
		{
			return false;
		}

		// Token: 0x04008841 RID: 34881
		internal M901_BurningSnowForest $self_$41177;

		// Token: 0x0200181E RID: 6174
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008FBB RID: 36795 RVA: 0x01166CC4 File Offset: 0x01164EC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M901_BurningSnowForest self_)
			{
				if (172981 - 460870 != -287888)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (207907 - 454125 == -246218)
					{
						base..ctor();
						if (33080 - 592118 != -559037)
						{
							this.$self_$41176 = self_;
							if (65260 - 585761 != -520500)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008FBC RID: 36796 RVA: 0x01166D5C File Offset: 0x01164F5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (203921 - 60460 != 143462)
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
							if (106941 - 270945 == -164003)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_1D7;
							}
							if (132006 - 88744 != 43262)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (78955 - 61826 != 17129)
						{
							continue;
						}
						this.$mStoryGui$41173 = (StoryGui)this.$self_$41176.GetComponent(typeof(StoryGui));
						if (129903 - 104373 != 25530)
						{
							continue;
						}
						if (this.$mStoryGui$41173)
						{
							if (41840 - 309264 == -267423)
							{
								continue;
							}
							this.$mStoryGui$41173.close();
							if (140808 - 585972 != -445164)
							{
								continue;
							}
						}
						this.$mChangeGui$41174 = (ChangeGui)this.$self_$41176.GetComponent(typeof(ChangeGui));
						if (30438 - 79520 != -49082)
						{
							continue;
						}
						if (this.$mChangeGui$41174)
						{
							if (239097 - 71769 != 167328)
							{
								continue;
							}
							this.$mChangeGui$41174.close();
							if (170624 - 226499 == -55874)
							{
								continue;
							}
						}
						this.$mGameGui$41175 = (GameGui)this.$self_$41176.GetComponent(typeof(GameGui));
						if (44168 - 284410 != -240242)
						{
							continue;
						}
						if (this.$mGameGui$41175)
						{
							if (72169 - 373258 == -301088)
							{
								continue;
							}
							if (!this.$mGameGui$41175.enabled)
							{
								if (121188 - 579289 == -458100)
								{
									continue;
								}
								this.$mGameGui$41175.enabled = true;
								if (115933 - 200876 == -84942)
								{
									continue;
								}
							}
							this.$mGameGui$41175.openDeadMenu();
							if (114297 - 269694 != -155397)
							{
								continue;
							}
						}
						IL_1D7:
						this.YieldDefault(1);
						if (214072 - 344050 != -129978)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (229773 - 266287 == -36513)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (172518 - 458809 == -286290);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06008FBD RID: 36797 RVA: 0x01167074 File Offset: 0x01165274
			internal static bool RNbIEBVkT7ho7dx2ujKN()
			{
				return true;
			}

			// Token: 0x06008FBE RID: 36798 RVA: 0x01167078 File Offset: 0x01165278
			internal static bool XQ7VqcVk3fGI9nEIPhGT()
			{
				return false;
			}

			// Token: 0x04008842 RID: 34882
			internal StoryGui $mStoryGui$41173;

			// Token: 0x04008843 RID: 34883
			internal ChangeGui $mChangeGui$41174;

			// Token: 0x04008844 RID: 34884
			internal GameGui $mGameGui$41175;

			// Token: 0x04008845 RID: 34885
			internal M901_BurningSnowForest $self_$41176;
		}
	}

	// Token: 0x0200181F RID: 6175
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$41178 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008FBF RID: 36799 RVA: 0x0116707C File Offset: 0x0116527C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$41178(Hashtable data, M901_BurningSnowForest self_)
		{
			if (272036 - 568769 != -296733)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (163168 - 284945 != -121776)
				{
					base..ctor();
					if (116173 - 31331 == 84842)
					{
						this.$data$41183 = data;
						if (168970 - 526815 == -357845)
						{
							this.$self_$41184 = self_;
							if (66198 - 99458 != -33259)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008FC0 RID: 36800 RVA: 0x01167138 File Offset: 0x01165338
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M901_BurningSnowForest.$onChangePlayer$41178.$(this.$data$41183, this.$self_$41184);
		}

		// Token: 0x06008FC1 RID: 36801 RVA: 0x0116714C File Offset: 0x0116534C
		internal static bool QSgWbHVkXww8TIxlZA45()
		{
			return true;
		}

		// Token: 0x06008FC2 RID: 36802 RVA: 0x01167150 File Offset: 0x01165350
		internal static bool VJROBsVkQo5qmFNBTpty()
		{
			return false;
		}

		// Token: 0x04008846 RID: 34886
		internal Hashtable $data$41183;

		// Token: 0x04008847 RID: 34887
		internal M901_BurningSnowForest $self_$41184;

		// Token: 0x02001820 RID: 6176
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008FC3 RID: 36803 RVA: 0x01167154 File Offset: 0x01165354
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M901_BurningSnowForest self_)
			{
				if (72513 - 241232 != -168719)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (235791 - 567892 != -332100)
					{
						base..ctor();
						if (145263 - 58904 == 86359)
						{
							this.$data$41181 = data;
							if (240591 - 70250 == 170341)
							{
								this.$self_$41182 = self_;
								if (209753 - 38295 != 171459)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008FC4 RID: 36804 RVA: 0x01167210 File Offset: 0x01165410
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (124125 - 245461 != -121336)
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
							if (290310 - 170659 != 119651)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (185026 - 416859 == -231832)
							{
								continue;
							}
							this.$mGameGui$41180 = (GameGui)this.$self_$41182.GetComponent(typeof(GameGui));
							if (265854 - 231729 == 34126)
							{
								continue;
							}
							this.$mGameGui$41180.enabled = true;
							if (69574 - 146608 == -77033)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (14317 - 453931 != -439614)
						{
							continue;
						}
						goto IL_205;
					default:
						if (153751 - 426599 == -272847)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (18025 - 37943 != -19917)
					{
						this.$self_$41182.SendMessage("onCreatePlayer", this.$data$41181);
						if (2667 - 3194 == -527)
						{
							this.$mChangeGui$41179 = (ChangeGui)this.$self_$41182.GetComponent(typeof(ChangeGui));
							if (104846 - 254269 == -149423)
							{
								if (!this.$mChangeGui$41179.enabled)
								{
									break;
								}
								if (32042 - 309162 == -277120)
								{
									this.$mChangeGui$41179.close();
									if (250696 - 263422 != -12725)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_8E:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_8E;
				IL_205:
				return false;
			}

			// Token: 0x06008FC5 RID: 36805 RVA: 0x01167434 File Offset: 0x01165634
			internal static bool LTYxeUVkkMXoVG1HRboG()
			{
				return true;
			}

			// Token: 0x06008FC6 RID: 36806 RVA: 0x01167438 File Offset: 0x01165638
			internal static bool uUj8LyVkGrs2msgBRUDU()
			{
				return false;
			}

			// Token: 0x04008848 RID: 34888
			internal ChangeGui $mChangeGui$41179;

			// Token: 0x04008849 RID: 34889
			internal GameGui $mGameGui$41180;

			// Token: 0x0400884A RID: 34890
			internal Hashtable $data$41181;

			// Token: 0x0400884B RID: 34891
			internal M901_BurningSnowForest $self_$41182;
		}
	}

	// Token: 0x02001821 RID: 6177
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$41185 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008FC7 RID: 36807 RVA: 0x0116743C File Offset: 0x0116563C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$41185(M901_BurningSnowForest self_)
		{
			if (9490 - 256648 != -247158)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (184053 - 216127 != -32073)
				{
					base..ctor();
					if (16301 - 543795 != -527493)
					{
						this.$self_$41189 = self_;
						if (174033 - 491160 != -317126)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008FC8 RID: 36808 RVA: 0x011674D4 File Offset: 0x011656D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M901_BurningSnowForest.$ReturnToTown$41185.$(this.$self_$41189);
		}

		// Token: 0x06008FC9 RID: 36809 RVA: 0x011674E4 File Offset: 0x011656E4
		internal static bool DHoj7FVkHRSXknA8PVSL()
		{
			return true;
		}

		// Token: 0x06008FCA RID: 36810 RVA: 0x011674E8 File Offset: 0x011656E8
		internal static bool r5sJuZVkW1SbC796BgJt()
		{
			return false;
		}

		// Token: 0x0400884C RID: 34892
		internal M901_BurningSnowForest $self_$41189;

		// Token: 0x02001822 RID: 6178
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008FCB RID: 36811 RVA: 0x011674EC File Offset: 0x011656EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M901_BurningSnowForest self_)
			{
				if (30991 - 295044 != -264052)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (258095 - 206063 == 52032)
					{
						base..ctor();
						if (293613 - 469381 != -175767)
						{
							this.$self_$41188 = self_;
							if (202954 - 121390 == 81564)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008FCC RID: 36812 RVA: 0x01167584 File Offset: 0x01165784
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (270405 - 262579 != 7826)
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
						this.$self_$41188.LeaveGame();
						if (49457 - 210927 != -161470)
						{
							continue;
						}
						this.YieldDefault(1);
						if (244324 - 214999 != 29325)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (144120 - 237083 != -92963)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (206054 - 22423 != 183632)
					{
						Game.mStateTime = Time.time;
						if (112895 - 238035 != -125139)
						{
							this.$$switch$7394$41186 = PlayerData.SaveGuild;
							if (163461 - 209942 == -46481)
							{
								if (this.$$switch$7394$41186 == 1)
								{
									if (90215 - 82128 == 8088)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (247295 - 150441 != 96854)
									{
										continue;
									}
								}
								else if (this.$$switch$7394$41186 == 2)
								{
									if (128464 - 324215 == -195750)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (127946 - 587097 == -459150)
									{
										continue;
									}
								}
								else if (this.$$switch$7394$41186 == 3)
								{
									if (237640 - 498751 != -261111)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (263744 - 227567 != 36177)
									{
										continue;
									}
								}
								else if (this.$$switch$7394$41186 == 4)
								{
									if (130996 - 563465 != -432469)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (32068 - 116867 == -84798)
									{
										continue;
									}
								}
								else if (this.$$switch$7394$41186 == 5)
								{
									if (215795 - 184596 != 31199)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (131555 - 531664 != -400109)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (68593 - 224968 != -156375)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (83334 - 147230 == -63895)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (276206 - 172243 != 103963)
									{
										continue;
									}
								}
								this.$mGameGui$41187 = (GameGui)this.$self_$41188.GetComponent(typeof(GameGui));
								if (32095 - 228522 == -196427)
								{
									if (this.$mGameGui$41187)
									{
										if (223474 - 448892 != -225418)
										{
											continue;
										}
										this.$mGameGui$41187.close();
										if (55328 - 16200 != 39128)
										{
											continue;
										}
									}
									this.$self_$41188.SendMessage("fadeOut");
									if (39159 - 432497 == -393338)
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

			// Token: 0x06008FCD RID: 36813 RVA: 0x01167950 File Offset: 0x01165B50
			internal static bool usNi1FVkABsmI1U3E6LZ()
			{
				return true;
			}

			// Token: 0x06008FCE RID: 36814 RVA: 0x01167954 File Offset: 0x01165B54
			internal static bool aij5vMVklSQHqnmFt39S()
			{
				return false;
			}

			// Token: 0x0400884D RID: 34893
			internal int $$switch$7394$41186;

			// Token: 0x0400884E RID: 34894
			internal GameGui $mGameGui$41187;

			// Token: 0x0400884F RID: 34895
			internal M901_BurningSnowForest $self_$41188;
		}
	}

	// Token: 0x02001823 RID: 6179
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$41190 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008FCF RID: 36815 RVA: 0x01167958 File Offset: 0x01165B58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$41190(M901_BurningSnowForest self_)
		{
			if (243861 - 63599 != 180262)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (37149 - 30073 != 7077)
				{
					base..ctor();
					if (68570 - 447402 != -378831)
					{
						this.$self_$41193 = self_;
						if (166096 - 406607 != -240510)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008FD0 RID: 36816 RVA: 0x011679F0 File Offset: 0x01165BF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M901_BurningSnowForest.$ReturnToGuild$41190.$(this.$self_$41193);
		}

		// Token: 0x06008FD1 RID: 36817 RVA: 0x01167A00 File Offset: 0x01165C00
		internal static bool TMaejVVky2XUJn9J5aYy()
		{
			return true;
		}

		// Token: 0x06008FD2 RID: 36818 RVA: 0x01167A04 File Offset: 0x01165C04
		internal static bool rw1EKjVkSSKksZEiLRqA()
		{
			return false;
		}

		// Token: 0x04008850 RID: 34896
		internal M901_BurningSnowForest $self_$41193;

		// Token: 0x02001824 RID: 6180
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008FD3 RID: 36819 RVA: 0x01167A08 File Offset: 0x01165C08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M901_BurningSnowForest self_)
			{
				if (72174 - 412690 != -340515)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (155357 - 36406 == 118951)
					{
						base..ctor();
						if (50542 - 143468 != -92925)
						{
							this.$self_$41192 = self_;
							if (146036 - 224995 != -78958)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008FD4 RID: 36820 RVA: 0x01167AA0 File Offset: 0x01165CA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (246871 - 55180 != 191692)
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
						this.$self_$41192.LeaveGame();
						if (89981 - 139261 != -49280)
						{
							continue;
						}
						this.YieldDefault(1);
						if (68047 - 118942 != -50894)
						{
							goto Block_6;
						}
						continue;
					default:
						if (209684 - 108320 != 101364)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (18280 - 485839 != -467558)
					{
						Game.mStateTime = Time.time;
						if (253829 - 69867 != 183963)
						{
							Game.mNextGameCode = 31;
							if (178887 - 334197 == -155310)
							{
								this.$mGameGui$41191 = (GameGui)this.$self_$41192.GetComponent(typeof(GameGui));
								if (192320 - 34845 == 157475)
								{
									if (this.$mGameGui$41191)
									{
										if (236918 - 320702 == -83783)
										{
											continue;
										}
										this.$mGameGui$41191.close();
										if (118267 - 569655 == -451387)
										{
											continue;
										}
									}
									this.$self_$41192.SendMessage("fadeOut");
									if (56437 - 26725 == 29712)
									{
										goto IL_DB;
									}
								}
							}
						}
					}
				}
				Block_6:
				goto IL_1BD;
				IL_DB:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x06008FD5 RID: 36821 RVA: 0x01167C7C File Offset: 0x01165E7C
			internal static bool Lpd4PUVkop7F8GEiP2u6()
			{
				return true;
			}

			// Token: 0x06008FD6 RID: 36822 RVA: 0x01167C80 File Offset: 0x01165E80
			internal static bool zfZQVPVkEp9IAmKwDg4Z()
			{
				return false;
			}

			// Token: 0x04008851 RID: 34897
			internal GameGui $mGameGui$41191;

			// Token: 0x04008852 RID: 34898
			internal M901_BurningSnowForest $self_$41192;
		}
	}

	// Token: 0x02001825 RID: 6181
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$41194 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008FD7 RID: 36823 RVA: 0x01167C84 File Offset: 0x01165E84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$41194(M901_BurningSnowForest self_)
		{
			if (276282 - 282088 != -5805)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (157907 - 287767 != -129859)
				{
					base..ctor();
					if (79157 - 145986 == -66829)
					{
						this.$self_$41198 = self_;
						if (212467 - 351867 != -139399)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008FD8 RID: 36824 RVA: 0x01167D1C File Offset: 0x01165F1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M901_BurningSnowForest.$ReturnToCamp$41194.$(this.$self_$41198);
		}

		// Token: 0x06008FD9 RID: 36825 RVA: 0x01167D2C File Offset: 0x01165F2C
		internal static bool iOWUBHVk2Ywt6KkCKtKA()
		{
			return true;
		}

		// Token: 0x06008FDA RID: 36826 RVA: 0x01167D30 File Offset: 0x01165F30
		internal static bool mPfW4PVk8kdk0VLAn23Z()
		{
			return false;
		}

		// Token: 0x04008853 RID: 34899
		internal M901_BurningSnowForest $self_$41198;

		// Token: 0x02001826 RID: 6182
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008FDB RID: 36827 RVA: 0x01167D34 File Offset: 0x01165F34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M901_BurningSnowForest self_)
			{
				if (286727 - 80825 != 205903)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (10181 - 360773 == -350592)
					{
						base..ctor();
						if (286577 - 295077 != -8499)
						{
							this.$self_$41197 = self_;
							if (78530 - 544217 == -465687)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008FDC RID: 36828 RVA: 0x01167DCC File Offset: 0x01165FCC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (80902 - 217427 != -136524)
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
						this.$self_$41197.LeaveGame();
						if (266294 - 381605 != -115311)
						{
							continue;
						}
						this.YieldDefault(1);
						if (178809 - 366775 != -187965)
						{
							goto Block_15;
						}
						continue;
					default:
						if (191840 - 403337 != -211497)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (280469 - 556891 == -276422)
					{
						Game.mStateTime = Time.time;
						if (229320 - 316255 == -86935)
						{
							this.$$switch$7396$41195 = PlayerData.SaveGuild;
							if (30050 - 387133 == -357083)
							{
								if (this.$$switch$7396$41195 == 1)
								{
									if (288306 - 477857 == -189550)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (230851 - 72975 == 157877)
									{
										continue;
									}
								}
								else if (this.$$switch$7396$41195 == 2)
								{
									if (21971 - 87585 != -65614)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (285732 - 73029 == 212704)
									{
										continue;
									}
								}
								else if (this.$$switch$7396$41195 == 3)
								{
									if (186239 - 575677 != -389438)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (48452 - 492523 != -444071)
									{
										continue;
									}
								}
								else if (this.$$switch$7396$41195 == 4)
								{
									if (141432 - 347470 != -206038)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (183947 - 242786 == -58838)
									{
										continue;
									}
								}
								else if (this.$$switch$7396$41195 == 5)
								{
									if (181768 - 432212 != -250444)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (44744 - 230221 == -185476)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (202272 - 599989 != -397717)
									{
										continue;
									}
								}
								this.$mGameGui$41196 = (GameGui)this.$self_$41197.GetComponent(typeof(GameGui));
								if (35672 - 248472 != -212799)
								{
									if (this.$mGameGui$41196)
									{
										if (14965 - 350363 == -335397)
										{
											continue;
										}
										this.$mGameGui$41196.close();
										if (186488 - 432277 != -245789)
										{
											continue;
										}
									}
									this.$self_$41197.SendMessage("fadeOut");
									if (113398 - 540055 == -426657)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_15:
				IL_363:
				return false;
			}

			// Token: 0x06008FDD RID: 36829 RVA: 0x01168150 File Offset: 0x01166350
			internal static bool haoI4TVkZJlYImSrVYWK()
			{
				return true;
			}

			// Token: 0x06008FDE RID: 36830 RVA: 0x01168154 File Offset: 0x01166354
			internal static bool cWlwRkVkC30BTLg6BeD2()
			{
				return false;
			}

			// Token: 0x04008854 RID: 34900
			internal int $$switch$7396$41195;

			// Token: 0x04008855 RID: 34901
			internal GameGui $mGameGui$41196;

			// Token: 0x04008856 RID: 34902
			internal M901_BurningSnowForest $self_$41197;
		}
	}
}
