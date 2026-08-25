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

// Token: 0x02001A8C RID: 6796
[Serializable]
public class M927_SilentEarth : MonoBehaviour
{
	// Token: 0x06009E80 RID: 40576 RVA: 0x012426F4 File Offset: 0x012408F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M927_SilentEarth()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06009E81 RID: 40577 RVA: 0x01242704 File Offset: 0x01240904
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (178881 - 431642 != -252760)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (125574 - 506968 != -381393)
			{
				Game.mGameType = 4;
				if (181872 - 416067 != -234194)
				{
					if (Chat.Initialized)
					{
						if (271892 - 542039 == -270146)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (70130 - 478753 == -408622)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (23742 - 559922 == -536179)
						{
							continue;
						}
					}
					this.XqZnIEHXq6u = (Texture)Resources.Load("GameGui/Title/chapterComplete", typeof(Texture));
					if (156563 - 310765 != -154201)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009E82 RID: 40578 RVA: 0x01242824 File Offset: 0x01240A24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (116687 - 76388 != 40299)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (170063 - 243743 == -73680)
				{
					if (Game.mNextGameCode != 927)
					{
						break;
					}
					if (201765 - 474936 == -273171)
					{
						Game.nextGame();
						if (67609 - 577000 != -509390)
						{
							Game.mGameCode = 927;
							if (167533 - 135963 != 31571)
							{
								Game.mGameType = 5;
								if (61437 - 20669 == 40768)
								{
									Game.mGameTime = Time.time;
									if (20507 - 179885 != -159377)
									{
										Game.mGameScore = 0;
										if (54708 - 145869 == -91161)
										{
											Game.mGameMana = 0;
											if (150047 - 499743 != -349695)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (205303 - 295282 != -89978)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (39071 - 17744 != 21328)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (21886 - 321656 == -299770)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (252064 - 403905 != -151840)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (157005 - 341519 == -184514)
																{
																	this.MI7nIUHUACj = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (145968 - 103034 == 42934)
																	{
																		this.MI7nIUHUACj.enabled = false;
																		if (104887 - 222578 != -117690)
																		{
																			this.D2ZnIwqnsAA = PhotonClient.Connection;
																			if (5099 - 200979 == -195880)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (234020 - 32336 == 201684)
																				{
																					this.InitGame();
																					if (4078 - 191480 != -187401)
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
				if (188974 - 289746 != -100771)
				{
					Game.mGameType = 99;
					if (92493 - 595358 == -502865)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009E83 RID: 40579 RVA: 0x01242B50 File Offset: 0x01240D50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (246894 - 548180 != -301285)
		{
		}
		for (;;)
		{
			if (this.D2ZnIwqnsAA == null)
			{
				if (73309 - 363375 == -290066)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (60128 - 289752 != -229623)
				{
					if (mGameState == eGameState.Init)
					{
						if (62018 - 291695 == -229677)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (90002 - 60445 != 29558)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (129960 - 175710 == -45750)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (341 - 219936 != -219594)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (223281 - 552408 == -329127)
						{
							if (Game.music != 0)
							{
								if (254059 - 84366 == 169694)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (663 - 432599 == -431935)
									{
										continue;
									}
									this.audio.Play();
									if (291417 - 298593 == -7175)
									{
										continue;
									}
								}
							}
							if (this.audio.volume < 0.1f * (float)Game.music)
							{
								if (150564 - 41066 != 109499)
								{
									this.audio.volume = this.audio.volume + Time.deltaTime;
									if (46265 - 293108 != -246842)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (98565 - 389006 != -290440)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (90742 - 464800 == -374058)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (292683 - 478849 == -186166)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (128502 - 359421 == -230919)
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
						if (292753 - 397991 != -105237)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009E84 RID: 40580 RVA: 0x01242E48 File Offset: 0x01241048
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (95093 - 196904 != -101811)
		{
		}
		for (;;)
		{
			eGameState mGameState = Game.mGameState;
			if (118302 - 73793 == 44509)
			{
				if (mGameState != eGameState.Complete)
				{
					break;
				}
				if (114571 - 358309 != -243737)
				{
					if (!this.XqZnIEHXq6u)
					{
						break;
					}
					if (181159 - 510666 != -329506)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (209108 - 370583 != -161474)
						{
							int num = 1024 * Screen.width / Screen.height;
							if (89471 - 288367 != -198895)
							{
								float num2 = (float)Screen.height / 1024f;
								if (192947 - 81515 != 111433)
								{
									GUI.depth = 1;
									if (197691 - 142884 != 54808)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, (float)2 * (Time.time - this.L7xnISD82NG));
										if (136961 - 185465 != -48503)
										{
											Color color = GUI.color;
											if (49397 - 381468 == -332071)
											{
												float num3 = color.a = a;
												if (182416 - 319870 == -137454)
												{
													if (125922 - 438915 != -312992)
													{
														Color color2 = GUI.color = color;
														if (45397 - 555347 == -509950)
														{
															if (131144 - 381432 != -250287)
															{
																float num4 = Mathf.SmoothStep(1.5f, (float)1, Time.time - this.L7xnISD82NG);
																if (122474 - 185888 == -63414)
																{
																	GUI.DrawTexture(new Rect(0.5f * (float)num - 0.5f * (float)this.XqZnIEHXq6u.width * num4, (float)530 - 0.5f * (float)this.XqZnIEHXq6u.height * num4, (float)this.XqZnIEHXq6u.width * num4, (float)this.XqZnIEHXq6u.height * num4), this.XqZnIEHXq6u);
																	if (220070 - 462002 != -241931)
																	{
																		int num5 = 1;
																		if (89445 - 409167 == -319722)
																		{
																			Color color3 = GUI.color;
																			if (227457 - 44817 == 182640)
																			{
																				color3.a = (float)num5;
																				if (74156 - 138045 != -63888)
																				{
																					if (215134 - 423672 == -208538)
																					{
																						GUI.color = color3;
																						if (273248 - 584532 == -311284)
																						{
																							if (115938 - 498279 != -382340)
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

	// Token: 0x06009E85 RID: 40581 RVA: 0x01243208 File Offset: 0x01241408
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (55263 - 474535 != -419271)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (297107 - 338049 != -40941)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (263218 - 220032 == 43186)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (24819 - 66798 != -41978)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (31517 - 229589 != -198071)
						{
							int num4 = num;
							if (120382 - 201102 != -80719)
							{
								if (num4 == 9271)
								{
									if (200130 - 67533 == 132597)
									{
										break;
									}
								}
								else
								{
									Debug.LogError("Warning unknown returnCode:" + num);
									if (86326 - 510388 != -424061)
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

	// Token: 0x06009E86 RID: 40582 RVA: 0x01243374 File Offset: 0x01241574
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StoryEvent()
	{
		return new M927_SilentEarth.$StoryEvent$43171(this).GetEnumerator();
	}

	// Token: 0x06009E87 RID: 40583 RVA: 0x01243384 File Offset: 0x01241584
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (178094 - 468580 != -290486)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (2577 - 221952 != -219374)
			{
				Time.timeScale = 1f;
				if (289382 - 255791 == 33591)
				{
					Hashtable customOpParameters = new Hashtable();
					if (49167 - 212279 == -163112)
					{
						this.D2ZnIwqnsAA.OpCustom(52, customOpParameters, true);
						if (194518 - 99192 != 95327)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009E88 RID: 40584 RVA: 0x01243450 File Offset: 0x01241650
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (44683 - 276608 != -231925)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (227292 - 560559 != -333266)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (218602 - 515848 == -297246)
				{
					Game.mGameState = eGameState.Setup;
					if (135382 - 361398 != -226015)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009E89 RID: 40585 RVA: 0x012434F4 File Offset: 0x012416F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		int num = RuntimeServices.UnboxInt32(data[43]);
		Game.setGameState(eGameState.Ready);
	}

	// Token: 0x06009E8A RID: 40586 RVA: 0x0124351C File Offset: 0x0124171C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (12774 - 547237 != -534462)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (264178 - 521138 != -256959)
			{
				Game.mGameState = eGameState.Ready;
				if (195423 - 120730 == 74693)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (95936 - 525192 != -429255)
					{
						GameObject gameObject = GameObject.Find("StartPoint1");
						if (32835 - 377868 == -345033)
						{
							if (!gameObject)
							{
								break;
							}
							if (299387 - 477352 == -177965)
							{
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position);
								if (264685 - 486909 == -222224)
								{
									if (spawnPos != Vector3.zero)
									{
										if (10642 - 8704 != 1939)
										{
											this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject.transform.forward);
											if (114733 - 483884 != -369150)
											{
												break;
											}
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
										if (189157 - 596290 != -407132)
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

	// Token: 0x06009E8B RID: 40587 RVA: 0x012436DC File Offset: 0x012418DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (161737 - 8736 != 153001)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (207735 - 64690 == 143045)
			{
				Game.mGameState = eGameState.Start;
				if (219585 - 95539 == 124046)
				{
					Game.mGameTime = Time.time;
					if (35664 - 405741 == -370077)
					{
						this.StartCoroutine_Auto(this.StoryEvent());
						if (33457 - 287160 == -253703)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009E8C RID: 40588 RVA: 0x012437A4 File Offset: 0x012419A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06009E8D RID: 40589 RVA: 0x012437A8 File Offset: 0x012419A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (78383 - 89407 != -11024)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (264747 - 436304 != -171556)
			{
				hashtable.Add(71, CID);
				if (109485 - 553080 == -443595)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (120382 - 204986 != -84603)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (267639 - 180590 != 87050)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (43595 - 498623 == -455028)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (149134 - 464481 == -315347)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (23205 - 286979 == -263774)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (75495 - 133016 == -57521)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (116946 - 150368 == -33422)
											{
												this.D2ZnIwqnsAA.OpCustom(61, hashtable, true);
												if (44836 - 74885 != -30048)
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

	// Token: 0x06009E8E RID: 40590 RVA: 0x01243A34 File Offset: 0x01241C34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (228371 - 300697 != -72325)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (212764 - 267643 == -54879)
			{
				if (!gameObject)
				{
					break;
				}
				if (88949 - 315371 == -226422)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (97528 - 82192 != 15337)
					{
						playerCameraControl.target = gameObject;
						if (205980 - 129753 == 76227)
						{
							this.StartGame();
							if (239054 - 179925 == 59129)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009E8F RID: 40591 RVA: 0x01243B24 File Offset: 0x01241D24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (6406 - 243457 != -237050)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (26483 - 408373 == -381890)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (289769 - 99545 == 190224)
				{
					gameGui.ResetTeamBar();
					if (13537 - 497605 != -484067)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009E90 RID: 40592 RVA: 0x01243BD0 File Offset: 0x01241DD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M927_SilentEarth.$onDeadPlayer$43212(this).GetEnumerator();
	}

	// Token: 0x06009E91 RID: 40593 RVA: 0x01243BE0 File Offset: 0x01241DE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (294559 - 219415 != 75144)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (213950 - 339556 != -125605)
			{
				this.MI7nIUHUACj.target = Game.mPlayer;
				if (223199 - 359884 != -136684)
				{
					this.MI7nIUHUACj.enabled = true;
					if (265350 - 547436 != -282085)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (36068 - 323104 == -287035)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (17351 - 99596 != -82245)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (268951 - 358179 != -89227)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (55711 - 451828 != -396116)
							{
								if (!gameGui)
								{
									break;
								}
								if (272875 - 350990 == -78115)
								{
									gameGui.enabled = true;
									if (280934 - 492263 != -211328)
									{
										gameGui.closeDeadMenu();
										if (44785 - 41371 != 3415)
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

	// Token: 0x06009E92 RID: 40594 RVA: 0x01243D8C File Offset: 0x01241F8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (198233 - 116101 != 82132)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (219671 - 206191 != 13481)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (14728 - 97677 != -82948)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (119145 - 531586 == -412441)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009E93 RID: 40595 RVA: 0x01243E50 File Offset: 0x01242050
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06009E94 RID: 40596 RVA: 0x01243E7C File Offset: 0x0124207C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (263200 - 283063 != -19863)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (145646 - 211886 != -66239)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (237445 - 563532 != -326086)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (124422 - 196976 == -72554)
					{
						Hashtable hashtable = new Hashtable();
						if (196472 - 411831 != -215358)
						{
							hashtable.Add(43, PlayerData.UID);
							if (878 - 357414 == -356536)
							{
								hashtable.Add(71, nCID);
								if (144372 - 312250 == -167878)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (160146 - 239897 == -79751)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (124990 - 378292 != -253301)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (206355 - 371011 != -164655)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (5621 - 29286 != -23664)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (169820 - 475702 == -305882)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (229502 - 68580 != 160923)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (199435 - 501187 != -301751)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (821 - 491212 == -490391)
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

	// Token: 0x06009E95 RID: 40597 RVA: 0x0124419C File Offset: 0x0124239C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M927_SilentEarth.$onChangePlayer$43218(data, this).GetEnumerator();
	}

	// Token: 0x06009E96 RID: 40598 RVA: 0x012441AC File Offset: 0x012423AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M927_SilentEarth.$onGameComplete$43225(data, this).GetEnumerator();
	}

	// Token: 0x06009E97 RID: 40599 RVA: 0x012441BC File Offset: 0x012423BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M927_SilentEarth.$ReturnToTown$43230(this).GetEnumerator();
	}

	// Token: 0x06009E98 RID: 40600 RVA: 0x012441CC File Offset: 0x012423CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M927_SilentEarth.$ReturnToGuild$43235(this).GetEnumerator();
	}

	// Token: 0x06009E99 RID: 40601 RVA: 0x012441DC File Offset: 0x012423DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M927_SilentEarth.$ReturnToCamp$43239(this).GetEnumerator();
	}

	// Token: 0x06009E9A RID: 40602 RVA: 0x012441EC File Offset: 0x012423EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (89907 - 162509 != -72601)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (61189 - 440354 == -379165)
			{
				Hashtable hashtable = new Hashtable();
				if (84518 - 476733 != -392214)
				{
					hashtable.Add(43, PlayerData.UID);
					if (282090 - 159015 != 123076)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (273292 - 387488 == -114196)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009E9B RID: 40603 RVA: 0x012442C4 File Offset: 0x012424C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06009E9C RID: 40604 RVA: 0x012442D8 File Offset: 0x012424D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (97855 - 350992 != -253136)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (60058 - 240248 == -180190)
			{
				Hashtable hashtable = new Hashtable();
				if (111770 - 254470 == -142700)
				{
					if (Game.mNextGameCode == 30)
					{
						if (246044 - 326954 == -80909)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (157896 - 595906 == -438009)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (200373 - 459537 == -259163)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (268626 - 411777 == -143150)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (160482 - 446448 != -285966)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (211005 - 419291 != -208286)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (241774 - 29593 != 212181)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (146019 - 114572 != 31447)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (288199 - 219623 == 68577)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (24426 - 342012 == -317585)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (80637 - 337736 == -257098)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (154101 - 438790 == -284688)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (76746 - 141739 != -64993)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (229316 - 259336 == -30019)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (63999 - 307723 != -243724)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (259355 - 32558 != 226797)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (141426 - 103955 != 37471)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (230730 - 459729 == -228998)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (104361 - 307391 == -203029)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (137622 - 219428 == -81805)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (167825 - 289976 != -122151)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (175848 - 395675 != -219827)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (252569 - 125980 == 126590)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (239947 - 108188 == 131760)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (250925 - 41662 == 209264)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (14782 - 93669 == -78886)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (29873 - 599058 == -569184)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (213107 - 156271 == 56837)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (293921 - 373980 != -80058)
					{
						this.D2ZnIwqnsAA.OpCustom(42, hashtable, true);
						if (213857 - 478395 == -264538)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009E9D RID: 40605 RVA: 0x0124488C File Offset: 0x01242A8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06009E9E RID: 40606 RVA: 0x0124489C File Offset: 0x01242A9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009E9F RID: 40607 RVA: 0x012448A0 File Offset: 0x01242AA0
	internal static bool Ej2u8KVgk2MsUdW6Vf3L()
	{
		return true;
	}

	// Token: 0x06009EA0 RID: 40608 RVA: 0x012448A4 File Offset: 0x01242AA4
	internal static bool FOn0yRVgGeNtPBgAXxvg()
	{
		return false;
	}

	// Token: 0x04009079 RID: 36985
	private LitePeer D2ZnIwqnsAA;

	// Token: 0x0400907A RID: 36986
	private PlayerCameraControl MI7nIUHUACj;

	// Token: 0x0400907B RID: 36987
	private float AKtnINmrUeD;

	// Token: 0x0400907C RID: 36988
	private Texture XqZnIEHXq6u;

	// Token: 0x0400907D RID: 36989
	private int MxunIPaq78T;

	// Token: 0x0400907E RID: 36990
	private float L7xnISD82NG;

	// Token: 0x0400907F RID: 36991
	public GameObject siegeBot_cAttackRing;

	// Token: 0x04009080 RID: 36992
	public GameObject siegeBot_cAttackFire;

	// Token: 0x04009081 RID: 36993
	public GameObject siegeBot_cAttackHit;

	// Token: 0x04009082 RID: 36994
	public GameObject earthGod_protectFall_ring;

	// Token: 0x04009083 RID: 36995
	private int WqMnIBxBndS;

	// Token: 0x02001A8D RID: 6797
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StoryEvent$43171 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009EA1 RID: 40609 RVA: 0x012448A8 File Offset: 0x01242AA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StoryEvent$43171(M927_SilentEarth self_)
		{
			if (296709 - 413944 != -117235)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (111842 - 100980 != 10863)
				{
					base..ctor();
					if (157521 - 211392 != -53870)
					{
						this.$self_$43211 = self_;
						if (207949 - 260066 == -52117)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009EA2 RID: 40610 RVA: 0x01244940 File Offset: 0x01242B40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M927_SilentEarth.$StoryEvent$43171.$(this.$self_$43211);
		}

		// Token: 0x06009EA3 RID: 40611 RVA: 0x01244950 File Offset: 0x01242B50
		internal static bool gONf76VgHWTaaLkWpcFX()
		{
			return true;
		}

		// Token: 0x06009EA4 RID: 40612 RVA: 0x01244954 File Offset: 0x01242B54
		internal static bool tVQDkJVgWprEP9yQMTKw()
		{
			return false;
		}

		// Token: 0x04009084 RID: 36996
		internal M927_SilentEarth $self_$43211;

		// Token: 0x02001A8E RID: 6798
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009EA5 RID: 40613 RVA: 0x01244958 File Offset: 0x01242B58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M927_SilentEarth self_)
			{
				if (214851 - 354219 != -139368)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (93437 - 152939 != -59501)
					{
						base..ctor();
						if (174253 - 18530 == 155723)
						{
							this.$self_$43210 = self_;
							if (264518 - 539755 != -275236)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009EA6 RID: 40614 RVA: 0x012449F0 File Offset: 0x01242BF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (194092 - 277321 != -83228)
				{
				}
				for (;;)
				{
					IL_3561:
					switch (this._state)
					{
					case 0:
						goto IL_3101;
					case 1:
						goto IL_41DD;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (199872 - 545876 != -346003)
							{
								goto Block_454;
							}
							continue;
						}
						else
						{
							this.$self_$43210.SendMessage("fadeIn");
							if (223902 - 232430 != -8528)
							{
								continue;
							}
							this.$self_$43210.MI7nIUHUACj.StartCoroutine_Auto(this.$self_$43210.MI7nIUHUACj.slerpToObject("EventCamera2", 2f));
							if (109044 - 232628 != -123584)
							{
								continue;
							}
							goto IL_139D;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (120126 - 194345 != -74218)
							{
								goto Block_130;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43191 = (StoryGui)this.$self_$43210.GetComponent(typeof(StoryGui));
							if (217173 - 484357 == -267183)
							{
								continue;
							}
							this.$mStoryTimer$43192 = 0f;
							if (26874 - 147576 != -120702)
							{
								continue;
							}
							this.$mStoryGui$43191.startStoryMessage(this.$mCDat1$43172.Type, this.$mCDat1$43172.Name, eTalkType.friend);
							if (270314 - 316709 != -46395)
							{
								continue;
							}
							goto IL_22FA;
						}
						break;
					case 4:
						this.$mStoryGui$43191.newStoryMessage(this.$mCDat1$43172.Type, this.$mCDat1$43172.Name, Language.getMessage("M927_SilentEarth", 101), eTalkType.friend);
						if (295839 - 158229 == 137611)
						{
							continue;
						}
						this.$mStoryTimer$43192 = Time.time + 3f;
						if (213093 - 490817 != -277724)
						{
							continue;
						}
						goto IL_6D;
					case 5:
						goto IL_94;
					case 6:
						goto IL_94;
					case 7:
						goto IL_30AD;
					case 8:
						goto IL_30AD;
					case 9:
						goto IL_4AA;
					case 10:
						goto IL_4AA;
					case 11:
						goto IL_2CEC;
					case 12:
						goto IL_2CEC;
					case 13:
						goto IL_2411;
					case 14:
						goto IL_2411;
					case 15:
						if (Game.mGameState != eGameState.Start)
						{
							if (143943 - 528506 != -384562)
							{
								goto Block_59;
							}
							continue;
						}
						else
						{
							this.$$iterator$10964$43194 = UnityRuntimeServices.GetEnumerator(this.$mSiegeBotList$43188);
							if (22057 - 487231 == -465173)
							{
								continue;
							}
							while (this.$$iterator$10964$43194.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10964$43194.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$mSiegeBot$43193 = (GameObject)obj2;
								if (62686 - 424107 != -361421)
								{
									goto IL_3561;
								}
								this.$mSiegeBot$43193.animation.CrossFade("run");
								if (236175 - 30858 == 205318)
								{
									goto IL_3561;
								}
								UnityRuntimeServices.Update(this.$$iterator$10964$43194, this.$mSiegeBot$43193);
								if (287912 - 278291 == 9622)
								{
									goto IL_3561;
								}
							}
							if (61596 - 437944 == -376347)
							{
								continue;
							}
							this.$mStoryTimer$43192 = Time.time + 2f;
							if (247036 - 240030 != 7007)
							{
								goto IL_E3A;
							}
							continue;
						}
						break;
					case 16:
						if (Game.mGameState == eGameState.Start)
						{
							goto IL_E3A;
						}
						if (110624 - 440202 != -329577)
						{
							goto Block_11;
						}
						continue;
					case 17:
						if (Game.mGameState != eGameState.Start)
						{
							if (226649 - 80814 != 145835)
							{
								continue;
							}
							goto IL_DE7;
						}
						else
						{
							this.$mStoryGui$43191.newStoryMessage(this.$mCDat1$43172.Type, this.$mCDat1$43172.Name, Language.getMessage("M927_SilentEarth", 107), eTalkType.friend);
							if (119767 - 535210 == -415442)
							{
								continue;
							}
							this.$$iterator$10967$43200 = UnityRuntimeServices.GetEnumerator(this.$mSiegeBotList$43188);
							if (195828 - 218151 != -22322)
							{
								goto IL_3C07;
							}
							continue;
						}
						break;
					case 18:
						goto IL_3C07;
					case 19:
						if (Game.mGameState != eGameState.Start)
						{
							if (29205 - 588494 != -559289)
							{
								continue;
							}
							goto IL_10CC;
						}
						else
						{
							this.$mStoryGui$43191.blank();
							if (132584 - 127533 != 5051)
							{
								continue;
							}
							this.$$iterator$10968$43202 = UnityRuntimeServices.GetEnumerator(this.$mSiegeBotList$43188);
							if (179144 - 575571 != -396426)
							{
								goto IL_1A7C;
							}
							continue;
						}
						break;
					case 20:
						goto IL_1A7C;
					case 21:
						if (Game.mGameState != eGameState.Start)
						{
							if (251039 - 457714 != -206674)
							{
								goto Block_207;
							}
							continue;
						}
						else
						{
							this.$self_$43210.SendMessage("fadeOut");
							if (244435 - 459391 != -214955)
							{
								goto Block_37;
							}
							continue;
						}
						break;
					case 22:
						if (Game.mGameState != eGameState.Start)
						{
							if (209772 - 487170 != -277397)
							{
								goto Block_285;
							}
							continue;
						}
						else
						{
							this.$self_$43210.MI7nIUHUACj.alignToObject("EventCamera5");
							if (198510 - 41320 == 157191)
							{
								continue;
							}
							if (this.$mEarthGod$43183)
							{
								if (54752 - 406245 == -351492)
								{
									continue;
								}
								this.$mEarthGod$43183.animation.Play("protect");
								if (242716 - 90078 != 152638)
								{
									continue;
								}
								this.$mEarthGod$43183.transform.position = new Vector3((float)-2, (float)49, (float)45);
								if (12571 - 130292 == -117720)
								{
									continue;
								}
								this.$mEarthGod$43183.transform.rotation = Quaternion.Euler((float)0, (float)270, (float)0);
								if (74110 - 539663 == -465552)
								{
									continue;
								}
								if (this.$self_$43210.siegeBot_cAttackHit)
								{
									if (11618 - 515197 == -503578)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$43210.siegeBot_cAttackHit, this.$mEarthGod$43183.transform.position, Quaternion.identity);
									if (99927 - 32435 == 67493)
									{
										continue;
									}
								}
							}
							this.$self_$43210.SendMessage("fadeIn");
							if (58099 - 183310 != -125210)
							{
								goto Block_221;
							}
							continue;
						}
						break;
					case 23:
						if (Game.mGameState != eGameState.Start)
						{
							if (250052 - 161680 != 88372)
							{
								continue;
							}
							goto IL_2907;
						}
						else
						{
							this.$mStoryGui$43191.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M927_SilentEarth", 108), eTalkType.friend);
							if (118641 - 427675 != -309034)
							{
								continue;
							}
							this.$self_$43210.MI7nIUHUACj.StartCoroutine_Auto(this.$self_$43210.MI7nIUHUACj.slerpToObject("EventCamera6", 2f));
							if (159876 - 597 != 159280)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 24:
						if (Game.mGameState != eGameState.Start)
						{
							if (292205 - 69424 != 222782)
							{
								goto Block_119;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43191.newStoryMessage(this.$mCDat1$43172.Type, this.$mCDat1$43172.Name, Language.getMessage("M927_SilentEarth", 109), eTalkType.friend);
							if (232856 - 572421 == -339564)
							{
								continue;
							}
							this.$mStoryTimer$43192 = Time.time + 3f;
							if (89311 - 99367 != -10055)
							{
								goto Block_348;
							}
							continue;
						}
						break;
					case 25:
						goto IL_24E2;
					case 26:
						goto IL_24E2;
					case 27:
						goto IL_209;
					case 28:
						goto IL_209;
					case 29:
						goto IL_3CA9;
					case 30:
						goto IL_3CA9;
					case 31:
						goto IL_2B90;
					case 32:
						if (Game.mGameState != eGameState.Start)
						{
							if (149171 - 189394 != -40223)
							{
								continue;
							}
							goto IL_3E84;
						}
						else
						{
							this.$$iterator$10970$43206 = UnityRuntimeServices.GetEnumerator(this.$mSiegeBotList$43188);
							if (225321 - 545804 != -320482)
							{
								goto IL_1FF1;
							}
							continue;
						}
						break;
					case 33:
						goto IL_1FF1;
					case 34:
						if (Game.mGameState != eGameState.Start)
						{
							if (109392 - 506807 != -397414)
							{
								goto Block_407;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43191.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M927_SilentEarth", 113), eTalkType.friend);
							if (216988 - 103598 != 113390)
							{
								continue;
							}
							this.$mStoryTimer$43192 = Time.time + 2.5f;
							if (76365 - 430792 != -354426)
							{
								goto Block_78;
							}
							continue;
						}
						break;
					case 35:
						goto IL_3DDC;
					case 36:
						goto IL_3DDC;
					case 37:
						if (Game.mGameState != eGameState.Start)
						{
							if (177708 - 36973 != 140735)
							{
								continue;
							}
							goto IL_19E4;
						}
						else
						{
							if (!this.$mEarthGod$43183)
							{
								goto IL_2998;
							}
							if (298904 - 152444 == 146461)
							{
								continue;
							}
							this.$mEarthGod$43183.animation.Play("protectFall");
							if (151166 - 582814 == -431647)
							{
								continue;
							}
							this.$mEarthGod$43183.animation.wrapMode = WrapMode.Once;
							if (177311 - 528112 != -350801)
							{
								continue;
							}
							goto IL_2998;
						}
						break;
					case 38:
						if (!this.$mEarthGod$43183)
						{
							goto IL_6C6;
						}
						if (116508 - 314362 == -197853)
						{
							continue;
						}
						if (!this.$self_$43210.earthGod_protectFall_ring)
						{
							goto IL_6C6;
						}
						if (9473 - 124847 != -115374)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$43210.earthGod_protectFall_ring, this.$mEarthGod$43183.transform.position, this.$mEarthGod$43183.transform.rotation);
						if (227818 - 228382 != -564)
						{
							continue;
						}
						goto IL_6C6;
					case 39:
						this.$self_$43210.MI7nIUHUACj.enabled = true;
						if (113556 - 368772 == -255215)
						{
							continue;
						}
						this.$self_$43210.MI7nIUHUACj.AddCamereShake(1f);
						if (145853 - 102555 != 43299)
						{
							goto Block_289;
						}
						continue;
					case 40:
						if (Game.mGameState != eGameState.Start)
						{
							if (37468 - 492924 != -455455)
							{
								goto Block_313;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43191.newStoryMessage(this.$mCDat1$43172.Type, this.$mCDat1$43172.Name, Language.getMessage("M927_SilentEarth", 115), eTalkType.friend);
							if (123865 - 449546 != -325681)
							{
								continue;
							}
							goto IL_1751;
						}
						break;
					case 41:
						if (Game.mGameState != eGameState.Start)
						{
							if (221411 - 156255 != 65156)
							{
								continue;
							}
							goto IL_26D;
						}
						else
						{
							this.$mStoryGui$43191.close();
							if (269867 - 514342 != -244475)
							{
								continue;
							}
							goto IL_2AD4;
						}
						break;
					case 42:
						if (Game.mGameState != eGameState.Start)
						{
							if (196409 - 26386 != 170023)
							{
								continue;
							}
							goto IL_144;
						}
						else
						{
							this.$self_$43210.SendMessage("fadeOut");
							if (34520 - 248078 != -213557)
							{
								goto Block_12;
							}
							continue;
						}
						break;
					case 43:
						if (Game.mGameState != eGameState.Start)
						{
							if (106670 - 557995 != -451324)
							{
								goto Block_271;
							}
							continue;
						}
						else
						{
							if (this.$mWindGod$43182)
							{
								if (206715 - 507384 == -300668)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mWindGod$43182);
								if (177766 - 21854 != 155912)
								{
									continue;
								}
							}
							if (this.$mEarthGod$43183)
							{
								if (177056 - 336844 == -159787)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mEarthGod$43183);
								if (72648 - 59151 == 13498)
								{
									continue;
								}
							}
							if (this.$mCarrierBot$43186)
							{
								if (287587 - 136672 == 150916)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mCarrierBot$43186);
								if (61649 - 309675 != -248026)
								{
									continue;
								}
							}
							if (this.$mCarrierBot_e$43187)
							{
								if (245896 - 148121 == 97776)
								{
									continue;
								}
								this.$mCarrierBot_e$43187.transform.position = new Vector3((float)-2, (float)49, (float)38);
								if (298393 - 321624 != -23231)
								{
									continue;
								}
							}
							this.$mStartPoint4$43207 = GameObject.Find("StartPoint4");
							if (184798 - 249314 == -64515)
							{
								continue;
							}
							if (this.$mPlayer1$43176)
							{
								if (164850 - 371207 == -206356)
								{
									continue;
								}
								if (this.$mStartPoint4$43207)
								{
									if (98403 - 449942 == -351538)
									{
										continue;
									}
									this.$mPlayer1$43176.transform.position = this.$mStartPoint4$43207.transform.position;
									if (45238 - 415330 == -370091)
									{
										continue;
									}
									this.$mPlayer1$43176.transform.rotation = this.$mStartPoint4$43207.transform.rotation;
									if (134727 - 300780 != -166053)
									{
										continue;
									}
								}
							}
							this.$mStartPoint5$43208 = GameObject.Find("StartPoint5");
							if (18229 - 452447 != -434218)
							{
								continue;
							}
							if (this.$mPlayer2$43177)
							{
								if (288268 - 320800 != -32532)
								{
									continue;
								}
								if (this.$mStartPoint5$43208)
								{
									if (104996 - 167516 == -62519)
									{
										continue;
									}
									this.$mPlayer2$43177.transform.position = this.$mStartPoint5$43208.transform.position;
									if (250371 - 175122 == 75250)
									{
										continue;
									}
									this.$mPlayer2$43177.transform.rotation = this.$mStartPoint5$43208.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0);
									if (221572 - 211212 != 10360)
									{
										continue;
									}
								}
							}
							this.$mStartPoint6$43209 = GameObject.Find("StartPoint6");
							if (154507 - 384702 != -230195)
							{
								continue;
							}
							if (this.$mPlayer3$43178)
							{
								if (271167 - 379222 == -108054)
								{
									continue;
								}
								if (this.$mStartPoint6$43209)
								{
									if (192603 - 262049 == -69445)
									{
										continue;
									}
									this.$mPlayer3$43178.transform.position = this.$mStartPoint6$43209.transform.position;
									if (270250 - 348722 != -78472)
									{
										continue;
									}
									this.$mPlayer3$43178.transform.rotation = this.$mStartPoint6$43209.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0);
									if (212879 - 440468 != -227589)
									{
										continue;
									}
								}
							}
							this.$self_$43210.MI7nIUHUACj.alignToObject("EventCamera7");
							if (258965 - 99814 == 159152)
							{
								continue;
							}
							this.$self_$43210.SendMessage("fadeIn");
							if (188295 - 381428 != -193133)
							{
								continue;
							}
							goto IL_32FA;
						}
						break;
					case 44:
						if (Game.mGameState != eGameState.Start)
						{
							if (180016 - 202049 != -22032)
							{
								goto Block_363;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43191.startStoryMessage("none", "???", eTalkType.enemy);
							if (21989 - 234007 != -212017)
							{
								goto Block_236;
							}
							continue;
						}
						break;
					case 45:
						if (Game.mGameState != eGameState.Start)
						{
							if (49967 - 89919 != -39952)
							{
								continue;
							}
							goto IL_5A3;
						}
						else
						{
							this.$mStoryGui$43191.newStoryMessage("none", "???", "10112 1002 2001", eTalkType.enemy);
							if (75542 - 265582 != -190040)
							{
								continue;
							}
							this.$mStoryTimer$43192 = Time.time + 3f;
							if (64786 - 455459 != -390673)
							{
								continue;
							}
							goto IL_134A;
						}
						break;
					case 46:
						goto IL_1373;
					case 47:
						goto IL_1373;
					case 48:
						if (Game.mGameState != eGameState.Start)
						{
							if (261735 - 550592 != -288857)
							{
								continue;
							}
							goto IL_1CC6;
						}
						else
						{
							this.$self_$43210.MI7nIUHUACj.StartCoroutine_Auto(this.$self_$43210.MI7nIUHUACj.slerpToObject("EventCamera9", (float)3));
							if (209067 - 387736 != -178669)
							{
								continue;
							}
							goto IL_10F6;
						}
						break;
					case 49:
						if (Game.mGameState != eGameState.Start)
						{
							if (157083 - 35916 != 121168)
							{
								goto Block_113;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43191.startStoryMessage("none", "???", eTalkType.enemy);
							if (84458 - 344156 != -259698)
							{
								continue;
							}
							this.$mStoryGui$43191.newStoryMessage("none", "???", "2100 21221228...", eTalkType.enemy);
							if (31444 - 453922 != -422477)
							{
								goto Block_140;
							}
							continue;
						}
						break;
					case 50:
						if (Game.mGameState != eGameState.Start)
						{
							if (3311 - 415734 != -412423)
							{
								continue;
							}
							goto IL_20FD;
						}
						else
						{
							this.$self_$43210.MI7nIUHUACj.StartCoroutine_Auto(this.$self_$43210.MI7nIUHUACj.slerpToObject("EventCamera10", (float)3));
							if (232783 - 222945 == 9839)
							{
								continue;
							}
							if (!this.$mCarrierBot_e$43187)
							{
								goto IL_289C;
							}
							if (157131 - 226442 != -69311)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.$mCarrierBot_e$43187);
							if (70866 - 49792 != 21074)
							{
								continue;
							}
							goto IL_289C;
						}
						break;
					case 51:
						if (Game.mGameState != eGameState.Start)
						{
							if (103562 - 407187 != -303625)
							{
								continue;
							}
							goto IL_26B7;
						}
						else
						{
							this.$mStoryGui$43191.startStoryMessage("Liger", "Boldas", eTalkType.friend);
							if (249976 - 267025 != -17048)
							{
								goto Block_276;
							}
							continue;
						}
						break;
					case 52:
						if (Game.mGameState != eGameState.Start)
						{
							if (280660 - 436480 != -155819)
							{
								goto Block_161;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43191.newStoryMessage("Liger", "Boldas", Language.getMessage("M927_SilentEarth", 116), eTalkType.friend);
							if (69663 - 107980 != -38317)
							{
								continue;
							}
							goto IL_272E;
						}
						break;
					case 53:
						if (Game.mGameState != eGameState.Start)
						{
							if (102968 - 596704 != -493735)
							{
								goto Block_279;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43191.newStoryMessage(this.$mCDat1$43172.Type, this.$mCDat1$43172.Name, Language.getMessage("M927_SilentEarth", 117), eTalkType.friend);
							if (117819 - 517763 == -399943)
							{
								continue;
							}
							this.$self_$43210.MI7nIUHUACj.alignToObject("EventCamera11");
							if (69637 - 38529 != 31108)
							{
								continue;
							}
							this.$mStoryTimer$43192 = Time.time + 4f;
							if (146804 - 82112 != 64692)
							{
								continue;
							}
							goto IL_BB1;
						}
						break;
					case 54:
						goto IL_BDA;
					case 55:
						goto IL_BDA;
					case 56:
						goto IL_1683;
					case 57:
						goto IL_1683;
					case 58:
						goto IL_103F;
					case 59:
						goto IL_103F;
					case 60:
						goto IL_2C0;
					case 61:
						goto IL_2C0;
					case 62:
						break;
					case 63:
						break;
					case 64:
						goto IL_3886;
					case 65:
						goto IL_3886;
					case 66:
						goto IL_2C6F;
					case 67:
						goto IL_2C6F;
					case 68:
						goto IL_36D3;
					case 69:
						goto IL_36D3;
					case 70:
						goto IL_2197;
					case 71:
						goto IL_2197;
					case 72:
						if (Game.mGameState != eGameState.Start)
						{
							if (151666 - 82063 != 69604)
							{
								goto Block_244;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(9271, 0);
							if (43754 - 461758 != -418004)
							{
								continue;
							}
							this.YieldDefault(1);
							if (122837 - 595287 != -472450)
							{
								continue;
							}
							goto IL_41DD;
						}
						break;
					default:
						if (191422 - 16089 != 175334)
						{
							goto IL_3101;
						}
						continue;
					}
					if (this.$mStoryTimer$43192 > Time.time)
					{
						if (12170 - 511007 != -498837)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							break;
						}
						if (292892 - 540617 != -247725)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (221950 - 145460 != 76491)
						{
							goto Block_416;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$43191.newStoryMessage("Liger", "Boldas", Language.getMessage("M927_SilentEarth", 122), eTalkType.friend);
						if (116947 - 565453 != -448506)
						{
							continue;
						}
						this.$mStoryTimer$43192 = Time.time + 4f;
						if (295990 - 457357 != -161366)
						{
							goto Block_314;
						}
						continue;
					}
					IL_94:
					if (this.$mStoryTimer$43192 > Time.time)
					{
						if (278278 - 560993 != -282715)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_88;
						}
						if (136735 - 110456 == 26280)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (233454 - 457786 != -224331)
						{
							goto Block_398;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$43191.newStoryMessage(this.$mCDat1$43172.Type, this.$mCDat1$43172.Name, Language.getMessage("M927_SilentEarth", 102), eTalkType.friend);
						if (244352 - 378562 != -134210)
						{
							continue;
						}
						this.$mStoryTimer$43192 = Time.time + 4f;
						if (3129 - 483881 != -480752)
						{
							continue;
						}
						goto IL_3086;
					}
					IL_E3A:
					if (this.$mStoryTimer$43192 <= Time.time)
					{
						if (5805 - 244640 != -238835)
						{
							continue;
						}
						if (!this.$mWindGod$43182)
						{
							goto IL_2F9F;
						}
						if (155503 - 81358 == 74146)
						{
							continue;
						}
						if (this.$mSiegeBotList$43188 == null)
						{
							goto IL_2F9F;
						}
						if (233954 - 496588 == -262633)
						{
							continue;
						}
						this.$$iterator$10966$43198 = UnityRuntimeServices.GetEnumerator(this.$mSiegeBotList$43188);
						if (212348 - 195811 == 16538)
						{
							continue;
						}
						while (this.$$iterator$10966$43198.MoveNext())
						{
							object obj4;
							object obj3 = obj4 = this.$$iterator$10966$43198.Current;
							if (!(obj3 is GameObject))
							{
								obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
							}
							this.$mSiegeBot$43197 = (GameObject)obj4;
							if (241824 - 513506 != -271682)
							{
								goto IL_3561;
							}
							this.$mSiegeBot$43197.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$mWindGod$43182.transform.position - this.$mSiegeBot$43197.transform.position));
							if (14792 - 56943 != -42151)
							{
								goto IL_3561;
							}
							UnityRuntimeServices.Update(this.$$iterator$10966$43198, this.$mSiegeBot$43197);
							if (26901 - 540668 == -513766)
							{
								goto IL_3561;
							}
							this.$mSiegeBot$43197.animation.CrossFade("root");
							if (182016 - 98311 != 83705)
							{
								goto IL_3561;
							}
							UnityRuntimeServices.Update(this.$$iterator$10966$43198, this.$mSiegeBot$43197);
							if (139954 - 293915 != -153961)
							{
								goto IL_3561;
							}
						}
						if (155918 - 370831 != -214913)
						{
							continue;
						}
						goto IL_2F9F;
					}
					else
					{
						this.$$iterator$10965$43196 = UnityRuntimeServices.GetEnumerator(this.$mSiegeBotList$43188);
						if (280000 - 196761 == 83240)
						{
							continue;
						}
						while (this.$$iterator$10965$43196.MoveNext())
						{
							object obj6;
							object obj5 = obj6 = this.$$iterator$10965$43196.Current;
							if (!(obj5 is GameObject))
							{
								obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
							}
							this.$mSiegeBot$43195 = (GameObject)obj6;
							if (142784 - 558196 == -415411)
							{
								goto IL_3561;
							}
							this.$mSiegeBot$43195.transform.position = this.$mSiegeBot$43195.transform.position + 7.5f * Time.deltaTime * this.$mSiegeBot$43195.transform.forward;
							if (58357 - 574941 == -516583)
							{
								goto IL_3561;
							}
							UnityRuntimeServices.Update(this.$$iterator$10965$43196, this.$mSiegeBot$43195);
							if (218740 - 544395 == -325654)
							{
								goto IL_3561;
							}
						}
						if (147744 - 304292 != -156547)
						{
							goto Block_391;
						}
						continue;
					}
					IL_209:
					if (this.$mStoryTimer$43192 > Time.time)
					{
						if (19658 - 216560 == -196901)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1FC;
						}
						if (112148 - 286696 == -174547)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (214113 - 266849 != -52735)
						{
							goto Block_159;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$43191.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M927_SilentEarth", 111), eTalkType.friend);
						if (1968 - 57843 != -55875)
						{
							continue;
						}
						this.$mStoryTimer$43192 = Time.time + 3f;
						if (132881 - 4560 != 128321)
						{
							continue;
						}
						goto IL_3C80;
					}
					IL_2C0:
					if (this.$mStoryTimer$43192 > Time.time)
					{
						if (203830 - 575042 == -371211)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2B3;
						}
						if (190731 - 274982 == -84250)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (291260 - 177681 != 113580)
						{
							goto Block_77;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$43191.newStoryMessage("Liger", "Boldas", Language.getMessage("M927_SilentEarth", 121), eTalkType.friend);
						if (284995 - 215847 != 69148)
						{
							continue;
						}
						this.$mStoryTimer$43192 = Time.time + 4f;
						if (120661 - 12430 != 108232)
						{
							goto Block_172;
						}
						continue;
					}
					IL_1683:
					if (this.$mStoryTimer$43192 > Time.time)
					{
						if (211183 - 579545 == -368361)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1676;
						}
						if (283579 - 547046 == -263466)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (274616 - 591323 != -316706)
						{
							goto Block_186;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$43191.newStoryMessage("Liger", "Boldas", Language.getMessage("M927_SilentEarth", 119), eTalkType.friend);
						if (157217 - 512234 == -355016)
						{
							continue;
						}
						if (this.$mLiger$43184)
						{
							if (262872 - 82905 == 179968)
							{
								continue;
							}
							this.$mLiger$43184.animation.Play("talk");
							if (193624 - 487084 != -293460)
							{
								continue;
							}
						}
						this.$mStoryTimer$43192 = Time.time + 4f;
						if (207150 - 515504 != -308353)
						{
							goto Block_394;
						}
						continue;
					}
					IL_BDA:
					if (this.$mStoryTimer$43192 > Time.time)
					{
						if (204433 - 590969 != -386536)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_BCD;
						}
						if (112407 - 246772 != -134365)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (294217 - 587284 != -293067)
						{
							continue;
						}
						goto IL_4022;
					}
					else
					{
						this.$mStoryGui$43191.newStoryMessage("Liger", "Boldas", Language.getMessage("M927_SilentEarth", 118), eTalkType.friend);
						if (290433 - 319242 != -28809)
						{
							continue;
						}
						this.$mStoryTimer$43192 = Time.time + 4f;
						if (117502 - 83675 != 33827)
						{
							continue;
						}
						goto IL_165A;
					}
					IL_4AA:
					if (this.$mStoryTimer$43192 > Time.time)
					{
						if (94763 - 170634 != -75871)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_49D;
						}
						if (191730 - 60617 == 131114)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (124789 - 94294 != 30496)
						{
							goto Block_217;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$43191.newStoryMessage("none", "???", Language.getMessage("M927_SilentEarth", 104), eTalkType.enemy);
						if (12733 - 311435 != -298702)
						{
							continue;
						}
						this.$self_$43210.MI7nIUHUACj.alignToObject("EventCamera3");
						if (89197 - 400196 == -310998)
						{
							continue;
						}
						this.$mStoryTimer$43192 = Time.time + 3f;
						if (161564 - 110989 != 50576)
						{
							goto Block_122;
						}
						continue;
					}
					IL_2CEC:
					if (this.$mStoryTimer$43192 > Time.time)
					{
						if (32167 - 225164 != -192997)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2CDF;
						}
						if (279703 - 253692 != 26011)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (273924 - 275557 != -1633)
						{
							continue;
						}
						goto IL_33E3;
					}
					else
					{
						this.$mStoryGui$43191.newStoryMessage(this.$mCDat1$43172.Type, this.$mCDat1$43172.Name, Language.getMessage("M927_SilentEarth", 105), eTalkType.friend);
						if (265522 - 579391 != -313869)
						{
							continue;
						}
						this.$mStoryTimer$43192 = Time.time + 3f;
						if (145168 - 136765 != 8404)
						{
							goto Block_43;
						}
						continue;
					}
					IL_1373:
					if (this.$mStoryTimer$43192 > Time.time)
					{
						if (84000 - 124970 == -40969)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1366;
						}
						if (141658 - 184095 == -42436)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (288201 - 306820 != -18619)
						{
							continue;
						}
						goto IL_CE6;
					}
					else
					{
						this.$mStoryGui$43191.close();
						if (181471 - 62848 != 118623)
						{
							continue;
						}
						if (this.$mCarrierBot_e$43187)
						{
							if (44095 - 242770 != -198675)
							{
								continue;
							}
							this.$mCarrierBot_e$43187.animation.Play("root");
							if (231800 - 542251 != -310451)
							{
								continue;
							}
						}
						this.$self_$43210.MI7nIUHUACj.StartCoroutine_Auto(this.$self_$43210.MI7nIUHUACj.slerpToObject("EventCamera8", (float)5));
						if (100250 - 592593 != -492342)
						{
							goto Block_46;
						}
						continue;
					}
					IL_1FF1:
					if (!this.$$iterator$10970$43206.MoveNext())
					{
						if (106168 - 14019 != 92149)
						{
							continue;
						}
						if (!this.$mEarthGod$43183)
						{
							goto IL_3A0D;
						}
						if (235231 - 197519 != 37712)
						{
							continue;
						}
						if (!this.$self_$43210.siegeBot_cAttackHit)
						{
							goto IL_3A0D;
						}
						if (164822 - 366299 != -201477)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$43210.siegeBot_cAttackHit, this.$mEarthGod$43183.transform.position, Quaternion.identity);
						if (124941 - 505619 != -380678)
						{
							continue;
						}
						goto IL_3A0D;
					}
					else
					{
						object obj8;
						object obj7 = obj8 = this.$$iterator$10970$43206.Current;
						if (!(obj7 is GameObject))
						{
							obj8 = RuntimeServices.Coerce(obj7, typeof(GameObject));
						}
						this.$mSiegeBot$43205 = (GameObject)obj8;
						if (188994 - 189824 != -830)
						{
							continue;
						}
						if (!this.$self_$43210.siegeBot_cAttackFire)
						{
							goto IL_1FDA;
						}
						if (36796 - 327996 != -291200)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$43210.siegeBot_cAttackFire, this.$mSiegeBot$43205.transform.position, Quaternion.LookRotation(this.$mWindGod$43182.transform.position - this.$mSiegeBot$43205.transform.position));
						if (236797 - 543632 == -306834)
						{
							continue;
						}
						UnityRuntimeServices.Update(this.$$iterator$10970$43206, this.$mSiegeBot$43205);
						if (159352 - 460984 != -301632)
						{
							continue;
						}
						goto IL_1FDA;
					}
					IL_2B90:
					if (!this.$$iterator$10969$43204.MoveNext())
					{
						if (119719 - 297414 != -177694)
						{
							goto Block_311;
						}
						continue;
					}
					else
					{
						object obj10;
						object obj9 = obj10 = this.$$iterator$10969$43204.Current;
						if (!(obj9 is GameObject))
						{
							obj10 = RuntimeServices.Coerce(obj9, typeof(GameObject));
						}
						this.$mSiegeBot$43203 = (GameObject)obj10;
						if (142117 - 550663 != -408546)
						{
							continue;
						}
						if (!this.$self_$43210.siegeBot_cAttackRing)
						{
							goto IL_2B79;
						}
						if (53871 - 288471 != -234600)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$43210.siegeBot_cAttackRing, this.$mSiegeBot$43203.transform.position, this.$mSiegeBot$43203.transform.rotation);
						if (256205 - 123598 == 132608)
						{
							continue;
						}
						UnityRuntimeServices.Update(this.$$iterator$10969$43204, this.$mSiegeBot$43203);
						if (117406 - 434486 != -317080)
						{
							continue;
						}
						goto IL_2B79;
					}
					IL_24E2:
					if (this.$mStoryTimer$43192 > Time.time)
					{
						if (32656 - 532215 == -499558)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_24D5;
						}
						if (89401 - 432099 != -342698)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (297563 - 527863 != -230300)
						{
							continue;
						}
						goto IL_8E7;
					}
					else
					{
						this.$mStoryGui$43191.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M927_SilentEarth", 110), eTalkType.friend);
						if (138892 - 502847 != -363955)
						{
							continue;
						}
						this.$mStoryTimer$43192 = Time.time + 3f;
						if (189100 - 588462 != -399362)
						{
							continue;
						}
						goto IL_1E0;
					}
					IL_1A7C:
					if (!this.$$iterator$10968$43202.MoveNext())
					{
						if (198593 - 423478 != -224884)
						{
							goto Block_183;
						}
						continue;
					}
					else
					{
						object obj12;
						object obj11 = obj12 = this.$$iterator$10968$43202.Current;
						if (!(obj11 is GameObject))
						{
							obj12 = RuntimeServices.Coerce(obj11, typeof(GameObject));
						}
						this.$mSiegeBot$43201 = (GameObject)obj12;
						if (118626 - 25179 != 93447)
						{
							continue;
						}
						if (!this.$self_$43210.siegeBot_cAttackFire)
						{
							goto IL_1A65;
						}
						if (28804 - 411248 == -382443)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$43210.siegeBot_cAttackFire, this.$mSiegeBot$43201.transform.position, Quaternion.LookRotation(this.$mWindGod$43182.transform.position - this.$mSiegeBot$43201.transform.position));
						if (144376 - 451180 == -306803)
						{
							continue;
						}
						UnityRuntimeServices.Update(this.$$iterator$10968$43202, this.$mSiegeBot$43201);
						if (93504 - 397056 != -303552)
						{
							continue;
						}
						goto IL_1A65;
					}
					IL_103F:
					if (this.$mStoryTimer$43192 > Time.time)
					{
						if (201090 - 145489 != 55601)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1032;
						}
						if (181405 - 581210 == -399804)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (64306 - 471895 != -407588)
						{
							goto Block_70;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$43191.newStoryMessage("Liger", "Boldas", Language.getMessage("M927_SilentEarth", 120), eTalkType.friend);
						if (274314 - 79826 != 194488)
						{
							continue;
						}
						this.$mStoryTimer$43192 = Time.time + 4f;
						if (4007 - 185610 != -181602)
						{
							goto Block_373;
						}
						continue;
					}
					IL_3DDC:
					if (this.$mStoryTimer$43192 > Time.time)
					{
						if (38280 - 120930 == -82649)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_3DCF;
						}
						if (259645 - 407890 != -148245)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (128571 - 119988 != 8584)
						{
							goto Block_355;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$43191.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M927_SilentEarth", 114), eTalkType.friend);
						if (262100 - 12400 != 249700)
						{
							continue;
						}
						goto IL_2A98;
					}
					IL_2411:
					if (this.$mStoryTimer$43192 > Time.time)
					{
						if (230971 - 437004 == -206032)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2404;
						}
						if (283018 - 579269 == -296250)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (68008 - 506388 != -438380)
						{
							continue;
						}
						goto IL_D10;
					}
					else
					{
						this.$mStoryGui$43191.newStoryMessage("none", "???", Language.getMessage("M927_SilentEarth", 106), eTalkType.enemy);
						if (6442 - 289022 == -282579)
						{
							continue;
						}
						this.$self_$43210.MI7nIUHUACj.StartCoroutine_Auto(this.$self_$43210.MI7nIUHUACj.slerpToObject("EventCamera4", 2f));
						if (118944 - 361304 != -242360)
						{
							continue;
						}
						goto IL_8AB;
					}
					IL_2C6F:
					if (this.$mStoryTimer$43192 > Time.time)
					{
						if (298641 - 121365 == 177277)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2C62;
						}
						if (79993 - 6942 == 73052)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (101021 - 18445 != 82577)
						{
							goto Block_194;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$43191.newStoryMessage("Liger", "Boldas", Language.getMessage("M927_SilentEarth", 124), eTalkType.friend);
						if (216930 - 179384 != 37546)
						{
							continue;
						}
						this.$mStoryTimer$43192 = Time.time + 4f;
						if (232004 - 347801 != -115797)
						{
							continue;
						}
						goto IL_36AA;
					}
					IL_36D3:
					if (this.$mStoryTimer$43192 > Time.time)
					{
						if (2221 - 50741 != -48520)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_36C6;
						}
						if (258100 - 578967 != -320867)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (266743 - 471537 != -204794)
						{
							continue;
						}
						goto IL_3774;
					}
					else
					{
						this.$mStoryGui$43191.newStoryMessage("Liger", "Boldas", Language.getMessage("M927_SilentEarth", 125), eTalkType.friend);
						if (196139 - 419664 == -223524)
						{
							continue;
						}
						this.$mStoryTimer$43192 = Time.time + 4f;
						if (4487 - 224633 != -220146)
						{
							continue;
						}
						goto IL_216E;
					}
					IL_2197:
					if (this.$mStoryTimer$43192 > Time.time)
					{
						if (244029 - 262903 != -18874)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_218A;
						}
						if (135654 - 176964 != -41310)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (256806 - 432496 != -175689)
						{
							goto Block_359;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$43191.close();
						if (287590 - 35152 != 252438)
						{
							continue;
						}
						this.$self_$43210.MI7nIUHUACj.StartCoroutine_Auto(this.$self_$43210.MI7nIUHUACj.slerpToObject("EventCamera12", (float)2));
						if (9175 - 436305 != -427130)
						{
							continue;
						}
						goto IL_2201;
					}
					IL_3101:
					this.$mCDat1$43172 = CharacterData.current;
					if (250679 - 415756 != -165077)
					{
						continue;
					}
					this.$mCDat2$43173 = null;
					if (120402 - 595284 == -474881)
					{
						continue;
					}
					this.$mCDat3$43174 = null;
					if (19903 - 310560 == -290656)
					{
						continue;
					}
					this.$$switch$7895$43175 = CharacterData.mSlot;
					if (116567 - 407162 != -290595)
					{
						continue;
					}
					if (this.$$switch$7895$43175 == 1)
					{
						if (270197 - 152589 == 117609)
						{
							continue;
						}
						this.$mCDat2$43173 = CharacterData.getCDat(2);
						if (152275 - 550591 == -398315)
						{
							continue;
						}
						this.$mCDat3$43174 = CharacterData.getCDat(3);
						if (254015 - 522342 == -268326)
						{
							continue;
						}
					}
					else if (this.$$switch$7895$43175 == 2)
					{
						if (192267 - 245231 == -52963)
						{
							continue;
						}
						this.$mCDat2$43173 = CharacterData.getCDat(1);
						if (65708 - 38401 == 27308)
						{
							continue;
						}
						this.$mCDat3$43174 = CharacterData.getCDat(3);
						if (114034 - 475447 == -361412)
						{
							continue;
						}
					}
					else if (this.$$switch$7895$43175 == 3)
					{
						if (3949 - 65454 != -61505)
						{
							continue;
						}
						this.$mCDat2$43173 = CharacterData.getCDat(1);
						if (273518 - 67499 == 206020)
						{
							continue;
						}
						this.$mCDat3$43174 = CharacterData.getCDat(2);
						if (167252 - 221273 == -54020)
						{
							continue;
						}
					}
					this.$mPlayer1$43176 = Game.mPlayer;
					if (58682 - 289835 == -231152)
					{
						continue;
					}
					this.$mPlayer2$43177 = null;
					if (55016 - 316661 == -261644)
					{
						continue;
					}
					this.$mPlayer3$43178 = null;
					if (77025 - 588115 != -511090)
					{
						continue;
					}
					this.$mStartPoint1$43179 = GameObject.Find("StartPoint1");
					if (271816 - 273157 != -1341)
					{
						continue;
					}
					if (this.$mPlayer1$43176)
					{
						if (48263 - 200770 != -152507)
						{
							continue;
						}
						if (this.$mStartPoint1$43179)
						{
							if (27032 - 163019 == -135986)
							{
								continue;
							}
							this.$mPlayer1$43176.transform.position = this.$mStartPoint1$43179.transform.position;
							if (69090 - 389717 == -320626)
							{
								continue;
							}
							this.$mPlayer1$43176.transform.rotation = this.$mStartPoint1$43179.transform.rotation;
							if (265898 - 263296 != 2602)
							{
								continue;
							}
						}
					}
					this.$mStartPoint2$43180 = GameObject.Find("StartPoint2");
					if (265809 - 117348 != 148461)
					{
						continue;
					}
					if (this.$mStartPoint2$43180)
					{
						if (57938 - 159760 != -101822)
						{
							continue;
						}
						if (this.$mCDat2$43173 != null)
						{
							if (200461 - 66735 != 133726)
							{
								continue;
							}
							if (this.$mCDat2$43173.Type != "none")
							{
								if (108248 - 327900 == -219651)
								{
									continue;
								}
								this.$mPlayer2$43177 = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("GameAssets/Characters/Lobby/viewChar/" + this.$mCDat2$43173.Type, typeof(GameObject)), this.$mStartPoint2$43180.transform.position, this.$mStartPoint2$43180.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
								if (63231 - 339557 == -276325)
								{
									continue;
								}
								if (this.$mPlayer2$43177)
								{
									if (266173 - 298246 == -32072)
									{
										continue;
									}
									this.$mPlayer2$43177.SendMessage("EquipCDat", this.$mCDat2$43173.slot);
									if (41846 - 496657 != -454811)
									{
										continue;
									}
								}
							}
						}
					}
					this.$mStartPoint3$43181 = GameObject.Find("StartPoint3");
					if (113524 - 562491 != -448967)
					{
						continue;
					}
					if (this.$mStartPoint3$43181)
					{
						if (291845 - 243479 == 48367)
						{
							continue;
						}
						if (this.$mCDat3$43174 != null)
						{
							if (257120 - 278063 == -20942)
							{
								continue;
							}
							if (this.$mCDat3$43174.Type != "none")
							{
								if (120707 - 586560 == -465852)
								{
									continue;
								}
								this.$mPlayer3$43178 = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("GameAssets/Characters/Lobby/viewChar/" + this.$mCDat3$43174.Type, typeof(GameObject)), this.$mStartPoint3$43181.transform.position, this.$mStartPoint3$43181.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
								if (140988 - 56319 != 84669)
								{
									continue;
								}
								if (this.$mPlayer3$43178)
								{
									if (162992 - 323050 != -160058)
									{
										continue;
									}
									this.$mPlayer3$43178.SendMessage("EquipCDat", this.$mCDat3$43174.slot);
									if (32663 - 78118 != -45455)
									{
										continue;
									}
								}
							}
						}
					}
					this.$mWindGod$43182 = GameObject.Find("WindGod");
					if (260094 - 137576 == 122519)
					{
						continue;
					}
					if (!this.$mWindGod$43182)
					{
						if (182195 - 494807 != -312612)
						{
							continue;
						}
						Debug.LogError("Warning cannot find WindGod object");
						if (180250 - 476643 == -296392)
						{
							continue;
						}
					}
					this.$mEarthGod$43183 = GameObject.Find("EarthGod");
					if (200576 - 414641 != -214065)
					{
						continue;
					}
					if (!this.$mEarthGod$43183)
					{
						if (266785 - 29119 != 237666)
						{
							continue;
						}
						Debug.LogError("Warning cannot find EarthGod object");
						if (163859 - 95424 != 68435)
						{
							continue;
						}
					}
					this.$mLiger$43184 = GameObject.Find("Liger");
					if (247427 - 461843 == -214415)
					{
						continue;
					}
					if (!this.$mLiger$43184)
					{
						if (23497 - 516326 == -492828)
						{
							continue;
						}
						Debug.LogError("Warning cannot find Liger object");
						if (180770 - 542485 == -361714)
						{
							continue;
						}
					}
					this.$mGravityBot$43185 = GameObject.Find("GravityBot");
					if (167468 - 9766 == 157703)
					{
						continue;
					}
					if (!this.$mGravityBot$43185)
					{
						if (174347 - 85484 == 88864)
						{
							continue;
						}
						Debug.LogError("Warning cannot find GravityBot object");
						if (187843 - 9203 == 178641)
						{
							continue;
						}
					}
					this.$mCarrierBot$43186 = GameObject.Find("CarrierBot");
					if (107140 - 381923 != -274783)
					{
						continue;
					}
					if (!this.$mCarrierBot$43186)
					{
						if (194415 - 351596 != -157181)
						{
							continue;
						}
						Debug.LogError("Warning cannot find CarrierBot object");
						if (150717 - 40260 != 110457)
						{
							continue;
						}
					}
					this.$mCarrierBot_e$43187 = GameObject.Find("CarrierBot_e");
					if (202549 - 469643 != -267094)
					{
						continue;
					}
					if (!this.$mCarrierBot_e$43187)
					{
						if (62903 - 85867 != -22964)
						{
							continue;
						}
						Debug.LogError("Warning cannot find CarrierBot_e object");
						if (244528 - 320512 != -75984)
						{
							continue;
						}
					}
					this.$mSiegeBotList$43188 = new UnityScript.Lang.Array();
					if (235711 - 170081 != 65630)
					{
						continue;
					}
					this.$s$43189 = 1;
					if (73071 - 544828 != -471757)
					{
						continue;
					}
					while (this.$s$43189 <= 6)
					{
						this.$tSiegeBot$43190 = GameObject.Find("SiegeBot" + this.$s$43189);
						if (104998 - 421633 == -316634)
						{
							goto IL_3561;
						}
						if (this.$tSiegeBot$43190)
						{
							if (24635 - 317838 != -293203)
							{
								goto IL_3561;
							}
							this.$mSiegeBotList$43188.Add(this.$tSiegeBot$43190);
							if (60256 - 21358 == 38899)
							{
								goto IL_3561;
							}
						}
						else
						{
							Debug.LogError("Warning cannot find SiegeBot" + this.$s$43189 + " object");
							if (191643 - 474618 == -282974)
							{
								goto IL_3561;
							}
						}
						this.$s$43189++;
						if (214105 - 216010 == -1904)
						{
							goto IL_3561;
						}
					}
					if (174083 - 305777 != -131694)
					{
						continue;
					}
					this.$self_$43210.MI7nIUHUACj.alignToObject("EventCamera1");
					if (187776 - 219870 != -32094)
					{
						continue;
					}
					goto IL_4108;
					IL_3C07:
					if (!this.$$iterator$10967$43200.MoveNext())
					{
						if (131920 - 399271 != -267350)
						{
							goto Block_418;
						}
						continue;
					}
					else
					{
						object obj14;
						object obj13 = obj14 = this.$$iterator$10967$43200.Current;
						if (!(obj13 is GameObject))
						{
							obj14 = RuntimeServices.Coerce(obj13, typeof(GameObject));
						}
						this.$mSiegeBot$43199 = (GameObject)obj14;
						if (70142 - 165335 == -95192)
						{
							continue;
						}
						this.$mSiegeBot$43199.animation.CrossFade("cAttack");
						if (207282 - 217390 != -10108)
						{
							continue;
						}
						UnityRuntimeServices.Update(this.$$iterator$10967$43200, this.$mSiegeBot$43199);
						if (4136 - 431338 == -427201)
						{
							continue;
						}
						if (!this.$self_$43210.siegeBot_cAttackRing)
						{
							goto IL_3BF0;
						}
						if (204683 - 339460 != -134777)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$43210.siegeBot_cAttackRing, this.$mSiegeBot$43199.transform.position, this.$mSiegeBot$43199.transform.rotation);
						if (247255 - 120035 == 127221)
						{
							continue;
						}
						UnityRuntimeServices.Update(this.$$iterator$10967$43200, this.$mSiegeBot$43199);
						if (270151 - 513233 != -243081)
						{
							goto Block_218;
						}
						continue;
					}
					IL_3886:
					if (this.$mStoryTimer$43192 > Time.time)
					{
						if (20769 - 180154 == -159384)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_3879;
						}
						if (278848 - 122896 != 155952)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (172210 - 536645 != -364435)
						{
							continue;
						}
						goto IL_36FD;
					}
					else
					{
						this.$mStoryGui$43191.newStoryMessage("Liger", "Boldas", Language.getMessage("M927_SilentEarth", 123), eTalkType.friend);
						if (237450 - 468057 != -230607)
						{
							continue;
						}
						this.$mStoryTimer$43192 = Time.time + 4f;
						if (55061 - 62838 != -7777)
						{
							continue;
						}
						goto IL_2C46;
					}
					IL_3CA9:
					if (this.$mStoryTimer$43192 > Time.time)
					{
						if (44521 - 280402 == -235880)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_3C9C;
						}
						if (354 - 473974 != -473620)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (43026 - 173134 != -130108)
						{
							continue;
						}
						goto IL_34E8;
					}
					else
					{
						this.$mStoryGui$43191.newStoryMessage(this.$mCDat1$43172.Type, this.$mCDat1$43172.Name, Language.getMessage("M927_SilentEarth", 112), eTalkType.friend);
						if (95879 - 479311 == -383431)
						{
							continue;
						}
						this.$$iterator$10969$43204 = UnityRuntimeServices.GetEnumerator(this.$mSiegeBotList$43188);
						if (245545 - 21394 != 224152)
						{
							goto IL_2B90;
						}
						continue;
					}
					IL_30AD:
					if (this.$mStoryTimer$43192 > Time.time)
					{
						if (212123 - 552651 == -340527)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_30A1;
						}
						if (215990 - 48016 != 167974)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (16682 - 470247 == -453565)
						{
							goto IL_3CFE;
						}
					}
					else
					{
						this.$mStoryGui$43191.newStoryMessage("WindGod", "Sun Sun", Language.getMessage("M927_SilentEarth", 103), eTalkType.friend);
						if (239304 - 78594 != 160711)
						{
							this.$mStoryTimer$43192 = Time.time + 4f;
							if (181275 - 563619 == -382344)
							{
								goto IL_481;
							}
						}
					}
				}
				return this.YieldDefault(63);
				IL_6D:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_88:
				return this.YieldDefault(6);
				Block_11:
				IL_144:
				goto IL_41DD;
				Block_12:
				return this.Yield(43, new WaitForSeconds(3f));
				IL_1E0:
				return this.Yield(27, new WaitForSeconds(0.5f));
				IL_1FC:
				return this.YieldDefault(28);
				IL_26D:
				goto IL_41DD;
				IL_2B3:
				return this.YieldDefault(61);
				Block_26:
				return this.Yield(24, new WaitForSeconds(2f));
				IL_481:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_49D:
				return this.YieldDefault(10);
				Block_37:
				return this.Yield(22, new WaitForSeconds(0.5f));
				IL_5A3:
				goto IL_41DD;
				Block_43:
				return this.Yield(13, new WaitForSeconds(0.5f));
				Block_46:
				return this.Yield(48, new WaitForSeconds(5f));
				IL_6C6:
				return this.Yield(39, new WaitForSeconds(0.5f));
				IL_8AB:
				return this.Yield(15, new WaitForSeconds(0.5f));
				Block_59:
				IL_8E7:
				Block_70:
				Block_77:
				goto IL_41DD;
				Block_78:
				return this.Yield(35, new WaitForSeconds(0.5f));
				IL_BB1:
				return this.Yield(54, new WaitForSeconds(0.5f));
				IL_BCD:
				return this.YieldDefault(55);
				IL_CE6:
				IL_D10:
				IL_DE7:
				goto IL_41DD;
				IL_1032:
				return this.YieldDefault(59);
				IL_10CC:
				goto IL_41DD;
				IL_10F6:
				return this.Yield(49, new WaitForSeconds(3f));
				Block_113:
				Block_119:
				goto IL_41DD;
				Block_122:
				return this.Yield(11, new WaitForSeconds(0.5f));
				IL_134A:
				return this.Yield(46, new WaitForSeconds(0.5f));
				IL_1366:
				return this.YieldDefault(47);
				IL_139D:
				return this.Yield(3, new WaitForSeconds(2f));
				Block_130:
				goto IL_41DD;
				Block_140:
				return this.Yield(50, new WaitForSeconds(3f));
				IL_165A:
				return this.Yield(56, new WaitForSeconds(0.5f));
				IL_1676:
				return this.YieldDefault(57);
				IL_1751:
				return this.Yield(41, new WaitForSeconds(3f));
				Block_159:
				Block_161:
				goto IL_41DD;
				Block_172:
				return this.Yield(62, new WaitForSeconds(0.5f));
				IL_19E4:
				goto IL_41DD;
				IL_1A65:
				return this.Yield(20, new WaitForSeconds(0.1f));
				Block_183:
				return this.Yield(21, new WaitForSeconds(0.3f));
				Block_186:
				Block_194:
				IL_1CC6:
				Block_207:
				Block_217:
				goto IL_41DD;
				Block_218:
				goto IL_3BF0;
				Block_221:
				return this.Yield(23, new WaitForSeconds(0.5f));
				IL_1FDA:
				return this.Yield(33, new WaitForSeconds(0.1f));
				Block_236:
				return this.Yield(45, new WaitForSeconds(0.5f));
				IL_20FD:
				goto IL_41DD;
				IL_216E:
				return this.Yield(70, new WaitForSeconds(0.5f));
				IL_218A:
				return this.YieldDefault(71);
				IL_2201:
				return this.Yield(72, new WaitForSeconds(2f));
				Block_244:
				goto IL_41DD;
				IL_22FA:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_2404:
				return this.YieldDefault(14);
				IL_24D5:
				return this.YieldDefault(26);
				Block_271:
				IL_26B7:
				goto IL_41DD;
				Block_276:
				return this.Yield(52, new WaitForSeconds(0.5f));
				IL_272E:
				return this.Yield(53, new WaitForSeconds(3.5f));
				Block_279:
				Block_285:
				goto IL_41DD;
				IL_289C:
				return this.Yield(51, new WaitForSeconds(2.5f));
				Block_289:
				return this.Yield(40, new WaitForSeconds(1f));
				IL_2907:
				goto IL_41DD;
				IL_2998:
				return this.Yield(38, new WaitForSeconds(0.5f));
				IL_2A98:
				return this.Yield(37, new WaitForSeconds(1f));
				IL_2AD4:
				return this.Yield(42, new WaitForSeconds(0.5f));
				IL_2B79:
				return this.Yield(31, new WaitForSeconds(0.1f));
				Block_311:
				return this.Yield(32, new WaitForSeconds(0.9f));
				Block_313:
				goto IL_41DD;
				Block_314:
				return this.Yield(64, new WaitForSeconds(0.5f));
				IL_2C46:
				return this.Yield(66, new WaitForSeconds(0.5f));
				IL_2C62:
				return this.YieldDefault(67);
				IL_2CDF:
				return this.YieldDefault(12);
				IL_2F9F:
				return this.Yield(17, new WaitForSeconds(0.5f));
				IL_3086:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_30A1:
				return this.YieldDefault(8);
				Block_348:
				return this.Yield(25, new WaitForSeconds(0.5f));
				Block_355:
				Block_359:
				goto IL_41DD;
				IL_32FA:
				return this.Yield(44, new WaitForSeconds(1f));
				Block_363:
				IL_33E3:
				goto IL_41DD;
				Block_373:
				return this.Yield(60, new WaitForSeconds(0.5f));
				IL_34E8:
				goto IL_41DD;
				IL_36AA:
				return this.Yield(68, new WaitForSeconds(0.5f));
				IL_36C6:
				return this.YieldDefault(69);
				IL_36FD:
				IL_3774:
				goto IL_41DD;
				Block_391:
				return this.YieldDefault(16);
				IL_3879:
				return this.YieldDefault(65);
				Block_394:
				return this.Yield(58, new WaitForSeconds(0.5f));
				Block_398:
				goto IL_41DD;
				IL_3A0D:
				return this.Yield(34, new WaitForSeconds(3f));
				Block_407:
				Block_416:
				goto IL_41DD;
				IL_3BF0:
				return this.Yield(18, new WaitForSeconds(0.1f));
				Block_418:
				return this.Yield(19, new WaitForSeconds(0.9f));
				IL_3C80:
				return this.Yield(29, new WaitForSeconds(0.5f));
				IL_3C9C:
				return this.YieldDefault(30);
				IL_3CFE:
				goto IL_41DD;
				IL_3DCF:
				return this.YieldDefault(36);
				IL_3E84:
				IL_4022:
				goto IL_41DD;
				IL_4108:
				return this.Yield(2, new WaitForSeconds(0.1f));
				Block_454:
				IL_41DD:
				return false;
			}

			// Token: 0x06009EA7 RID: 40615 RVA: 0x01248BEC File Offset: 0x01246DEC
			internal static bool MggBOqVgAsrw4sMqEI9A()
			{
				return true;
			}

			// Token: 0x06009EA8 RID: 40616 RVA: 0x01248BF0 File Offset: 0x01246DF0
			internal static bool AwmpZiVglUJQd7lKape7()
			{
				return false;
			}

			// Token: 0x04009085 RID: 36997
			internal CharacterDataClass $mCDat1$43172;

			// Token: 0x04009086 RID: 36998
			internal CharacterDataClass $mCDat2$43173;

			// Token: 0x04009087 RID: 36999
			internal CharacterDataClass $mCDat3$43174;

			// Token: 0x04009088 RID: 37000
			internal int $$switch$7895$43175;

			// Token: 0x04009089 RID: 37001
			internal GameObject $mPlayer1$43176;

			// Token: 0x0400908A RID: 37002
			internal GameObject $mPlayer2$43177;

			// Token: 0x0400908B RID: 37003
			internal GameObject $mPlayer3$43178;

			// Token: 0x0400908C RID: 37004
			internal GameObject $mStartPoint1$43179;

			// Token: 0x0400908D RID: 37005
			internal GameObject $mStartPoint2$43180;

			// Token: 0x0400908E RID: 37006
			internal GameObject $mStartPoint3$43181;

			// Token: 0x0400908F RID: 37007
			internal GameObject $mWindGod$43182;

			// Token: 0x04009090 RID: 37008
			internal GameObject $mEarthGod$43183;

			// Token: 0x04009091 RID: 37009
			internal GameObject $mLiger$43184;

			// Token: 0x04009092 RID: 37010
			internal GameObject $mGravityBot$43185;

			// Token: 0x04009093 RID: 37011
			internal GameObject $mCarrierBot$43186;

			// Token: 0x04009094 RID: 37012
			internal GameObject $mCarrierBot_e$43187;

			// Token: 0x04009095 RID: 37013
			internal UnityScript.Lang.Array $mSiegeBotList$43188;

			// Token: 0x04009096 RID: 37014
			internal int $s$43189;

			// Token: 0x04009097 RID: 37015
			internal GameObject $tSiegeBot$43190;

			// Token: 0x04009098 RID: 37016
			internal StoryGui $mStoryGui$43191;

			// Token: 0x04009099 RID: 37017
			internal float $mStoryTimer$43192;

			// Token: 0x0400909A RID: 37018
			internal GameObject $mSiegeBot$43193;

			// Token: 0x0400909B RID: 37019
			internal IEnumerator $$iterator$10964$43194;

			// Token: 0x0400909C RID: 37020
			internal GameObject $mSiegeBot$43195;

			// Token: 0x0400909D RID: 37021
			internal IEnumerator $$iterator$10965$43196;

			// Token: 0x0400909E RID: 37022
			internal GameObject $mSiegeBot$43197;

			// Token: 0x0400909F RID: 37023
			internal IEnumerator $$iterator$10966$43198;

			// Token: 0x040090A0 RID: 37024
			internal GameObject $mSiegeBot$43199;

			// Token: 0x040090A1 RID: 37025
			internal IEnumerator $$iterator$10967$43200;

			// Token: 0x040090A2 RID: 37026
			internal GameObject $mSiegeBot$43201;

			// Token: 0x040090A3 RID: 37027
			internal IEnumerator $$iterator$10968$43202;

			// Token: 0x040090A4 RID: 37028
			internal GameObject $mSiegeBot$43203;

			// Token: 0x040090A5 RID: 37029
			internal IEnumerator $$iterator$10969$43204;

			// Token: 0x040090A6 RID: 37030
			internal GameObject $mSiegeBot$43205;

			// Token: 0x040090A7 RID: 37031
			internal IEnumerator $$iterator$10970$43206;

			// Token: 0x040090A8 RID: 37032
			internal GameObject $mStartPoint4$43207;

			// Token: 0x040090A9 RID: 37033
			internal GameObject $mStartPoint5$43208;

			// Token: 0x040090AA RID: 37034
			internal GameObject $mStartPoint6$43209;

			// Token: 0x040090AB RID: 37035
			internal M927_SilentEarth $self_$43210;
		}
	}

	// Token: 0x02001A8F RID: 6799
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$43212 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009EA9 RID: 40617 RVA: 0x01248BF4 File Offset: 0x01246DF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$43212(M927_SilentEarth self_)
		{
			if (48327 - 250539 != -202212)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (201461 - 250670 != -49208)
				{
					base..ctor();
					if (194101 - 153259 != 40843)
					{
						this.$self_$43217 = self_;
						if (30877 - 411959 == -381082)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009EAA RID: 40618 RVA: 0x01248C8C File Offset: 0x01246E8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M927_SilentEarth.$onDeadPlayer$43212.$(this.$self_$43217);
		}

		// Token: 0x06009EAB RID: 40619 RVA: 0x01248C9C File Offset: 0x01246E9C
		internal static bool XZbJNUVgyncIQL9jqW3N()
		{
			return true;
		}

		// Token: 0x06009EAC RID: 40620 RVA: 0x01248CA0 File Offset: 0x01246EA0
		internal static bool q6tbNHVgSwiqeBhrBPvS()
		{
			return false;
		}

		// Token: 0x040090AC RID: 37036
		internal M927_SilentEarth $self_$43217;

		// Token: 0x02001A90 RID: 6800
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009EAD RID: 40621 RVA: 0x01248CA4 File Offset: 0x01246EA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M927_SilentEarth self_)
			{
				if (255895 - 539034 != -283139)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (274957 - 510664 != -235706)
					{
						base..ctor();
						if (208176 - 188722 == 19454)
						{
							this.$self_$43216 = self_;
							if (212340 - 81584 == 130756)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009EAE RID: 40622 RVA: 0x01248D3C File Offset: 0x01246F3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (252361 - 13051 != 239311)
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
							goto IL_2AF;
						}
						if (240347 - 596689 != -356342)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (124941 - 232456 != -107515)
							{
								continue;
							}
							goto IL_2AF;
						}
						IL_14B:
						this.YieldDefault(1);
						if (270764 - 473725 != -202961)
						{
							continue;
						}
						goto IL_2F9;
						IL_2AF:
						Game.mGameState = eGameState.Hold;
						if (18017 - 324784 == -306766)
						{
							continue;
						}
						this.$mStoryGui$43213 = (StoryGui)this.$self_$43216.GetComponent(typeof(StoryGui));
						if (268378 - 47025 != 221353)
						{
							continue;
						}
						if (this.$mStoryGui$43213)
						{
							if (251616 - 43010 == 208607)
							{
								continue;
							}
							this.$mStoryGui$43213.close();
							if (122237 - 31484 != 90753)
							{
								continue;
							}
						}
						this.$mChangeGui$43214 = (ChangeGui)this.$self_$43216.GetComponent(typeof(ChangeGui));
						if (382 - 41973 != -41591)
						{
							continue;
						}
						if (this.$mChangeGui$43214)
						{
							if (108222 - 467433 == -359210)
							{
								continue;
							}
							this.$mChangeGui$43214.close();
							if (162151 - 61987 != 100164)
							{
								continue;
							}
						}
						this.$mGameGui$43215 = (GameGui)this.$self_$43216.GetComponent(typeof(GameGui));
						if (23406 - 257796 == -234389)
						{
							continue;
						}
						if (!this.$mGameGui$43215)
						{
							goto IL_14B;
						}
						if (253292 - 7217 != 246075)
						{
							continue;
						}
						if (!this.$mGameGui$43215.enabled)
						{
							if (8130 - 587447 != -579317)
							{
								continue;
							}
							this.$mGameGui$43215.enabled = true;
							if (24196 - 345546 == -321349)
							{
								continue;
							}
						}
						this.$mGameGui$43215.openDeadMenu();
						if (53907 - 52343 != 1565)
						{
							goto IL_14B;
						}
						continue;
					default:
						if (167749 - 341234 == -173484)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (89428 - 546847 == -457418);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06009EAF RID: 40623 RVA: 0x01249054 File Offset: 0x01247254
			internal static bool OrGBk1Vgo3I85GxOqrXS()
			{
				return true;
			}

			// Token: 0x06009EB0 RID: 40624 RVA: 0x01249058 File Offset: 0x01247258
			internal static bool SOq0DVVgEhtgYKAdI3xX()
			{
				return false;
			}

			// Token: 0x040090AD RID: 37037
			internal StoryGui $mStoryGui$43213;

			// Token: 0x040090AE RID: 37038
			internal ChangeGui $mChangeGui$43214;

			// Token: 0x040090AF RID: 37039
			internal GameGui $mGameGui$43215;

			// Token: 0x040090B0 RID: 37040
			internal M927_SilentEarth $self_$43216;
		}
	}

	// Token: 0x02001A91 RID: 6801
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$43218 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009EB1 RID: 40625 RVA: 0x0124905C File Offset: 0x0124725C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$43218(Hashtable data, M927_SilentEarth self_)
		{
			if (63577 - 528910 != -465332)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (64365 - 15898 == 48467)
				{
					base..ctor();
					if (50039 - 288040 == -238001)
					{
						this.$data$43223 = data;
						if (254306 - 248435 != 5872)
						{
							this.$self_$43224 = self_;
							if (38519 - 544921 != -506401)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009EB2 RID: 40626 RVA: 0x01249118 File Offset: 0x01247318
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M927_SilentEarth.$onChangePlayer$43218.$(this.$data$43223, this.$self_$43224);
		}

		// Token: 0x06009EB3 RID: 40627 RVA: 0x0124912C File Offset: 0x0124732C
		internal static bool PsIaviVg2fYSqfyZ1Ngg()
		{
			return true;
		}

		// Token: 0x06009EB4 RID: 40628 RVA: 0x01249130 File Offset: 0x01247330
		internal static bool EO9O16Vg88CyUbpIuXQZ()
		{
			return false;
		}

		// Token: 0x040090B1 RID: 37041
		internal Hashtable $data$43223;

		// Token: 0x040090B2 RID: 37042
		internal M927_SilentEarth $self_$43224;

		// Token: 0x02001A92 RID: 6802
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009EB5 RID: 40629 RVA: 0x01249134 File Offset: 0x01247334
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M927_SilentEarth self_)
			{
				if (41491 - 423708 != -382217)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (216698 - 388993 == -172295)
					{
						base..ctor();
						if (53526 - 467412 != -413885)
						{
							this.$data$43221 = data;
							if (217630 - 592785 == -375155)
							{
								this.$self_$43222 = self_;
								if (125863 - 232341 != -106477)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009EB6 RID: 40630 RVA: 0x012491F0 File Offset: 0x012473F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (287548 - 331048 != -43500)
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
							if (253430 - 281698 == -28267)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (210079 - 296772 == -86692)
							{
								continue;
							}
							this.$mGameGui$43220 = (GameGui)this.$self_$43222.GetComponent(typeof(GameGui));
							if (183652 - 29826 != 153826)
							{
								continue;
							}
							this.$mGameGui$43220.enabled = true;
							if (124265 - 173864 != -49599)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (134952 - 173640 != -38688)
						{
							continue;
						}
						goto IL_205;
					default:
						if (255215 - 493819 != -238604)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (17314 - 343037 == -325723)
					{
						this.$self_$43222.SendMessage("onCreatePlayer", this.$data$43221);
						if (5332 - 131959 == -126627)
						{
							this.$mChangeGui$43219 = (ChangeGui)this.$self_$43222.GetComponent(typeof(ChangeGui));
							if (8097 - 237978 != -229880)
							{
								if (!this.$mChangeGui$43219.enabled)
								{
									break;
								}
								if (126308 - 100226 != 26083)
								{
									this.$mChangeGui$43219.close();
									if (22221 - 142167 != -119945)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_FC:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_FC;
				IL_205:
				return false;
			}

			// Token: 0x06009EB7 RID: 40631 RVA: 0x01249414 File Offset: 0x01247614
			internal static bool aQbZo6VgZAFMQMYhwC40()
			{
				return true;
			}

			// Token: 0x06009EB8 RID: 40632 RVA: 0x01249418 File Offset: 0x01247618
			internal static bool YBgA83VgCuVXMkW2Txi7()
			{
				return false;
			}

			// Token: 0x040090B3 RID: 37043
			internal ChangeGui $mChangeGui$43219;

			// Token: 0x040090B4 RID: 37044
			internal GameGui $mGameGui$43220;

			// Token: 0x040090B5 RID: 37045
			internal Hashtable $data$43221;

			// Token: 0x040090B6 RID: 37046
			internal M927_SilentEarth $self_$43222;
		}
	}

	// Token: 0x02001A93 RID: 6803
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$43225 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009EB9 RID: 40633 RVA: 0x0124941C File Offset: 0x0124761C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$43225(Hashtable data, M927_SilentEarth self_)
		{
			if (270402 - 393508 != -123106)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (152776 - 355916 == -203140)
				{
					base..ctor();
					if (120272 - 42119 != 78154)
					{
						this.$data$43228 = data;
						if (156818 - 553532 != -396713)
						{
							this.$self_$43229 = self_;
							if (201829 - 386229 != -184399)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009EBA RID: 40634 RVA: 0x012494D8 File Offset: 0x012476D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M927_SilentEarth.$onGameComplete$43225.$(this.$data$43228, this.$self_$43229);
		}

		// Token: 0x06009EBB RID: 40635 RVA: 0x012494EC File Offset: 0x012476EC
		internal static bool qLXbj3VgL15acE2cTi0b()
		{
			return true;
		}

		// Token: 0x06009EBC RID: 40636 RVA: 0x012494F0 File Offset: 0x012476F0
		internal static bool L23eahVgOI8ARSpnyJ9y()
		{
			return false;
		}

		// Token: 0x040090B7 RID: 37047
		internal Hashtable $data$43228;

		// Token: 0x040090B8 RID: 37048
		internal M927_SilentEarth $self_$43229;

		// Token: 0x02001A94 RID: 6804
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009EBD RID: 40637 RVA: 0x012494F4 File Offset: 0x012476F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M927_SilentEarth self_)
			{
				if (268804 - 457397 != -188593)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (252099 - 138547 != 113553)
					{
						base..ctor();
						if (284955 - 512567 == -227612)
						{
							this.$data$43226 = data;
							if (172021 - 101825 != 70197)
							{
								this.$self_$43227 = self_;
								if (224603 - 284076 != -59472)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009EBE RID: 40638 RVA: 0x012495B0 File Offset: 0x012477B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (125513 - 567784 != -442271)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_18D;
					case 2:
						this.$self_$43227.SendMessage("fadeOut");
						if (124989 - 280618 == -155628)
						{
							continue;
						}
						this.$self_$43227.StartCoroutine_Auto(this.$self_$43227.ReturnToTown());
						if (106772 - 269053 == -162280)
						{
							continue;
						}
						this.YieldDefault(1);
						if (90013 - 565987 != -475974)
						{
							continue;
						}
						goto IL_18D;
					default:
						if (203028 - 42393 != 160635)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Game Complete:" + this.$data$43226[31]);
					if (239280 - 232069 == 7211)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (164699 - 141780 == 22919)
							{
								goto IL_168;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (238737 - 74140 != 164598)
							{
								this.$self_$43227.L7xnISD82NG = Time.time;
								if (146539 - 295665 == -149126)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(4f));
				IL_168:
				IL_18D:
				return false;
			}

			// Token: 0x06009EBF RID: 40639 RVA: 0x0124975C File Offset: 0x0124795C
			internal static bool aadHMlVgmOc2TIIWoh0e()
			{
				return true;
			}

			// Token: 0x06009EC0 RID: 40640 RVA: 0x01249760 File Offset: 0x01247960
			internal static bool Hrs9urVgFJTDGl3GRnEC()
			{
				return false;
			}

			// Token: 0x040090B9 RID: 37049
			internal Hashtable $data$43226;

			// Token: 0x040090BA RID: 37050
			internal M927_SilentEarth $self_$43227;
		}
	}

	// Token: 0x02001A95 RID: 6805
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$43230 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009EC1 RID: 40641 RVA: 0x01249764 File Offset: 0x01247964
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$43230(M927_SilentEarth self_)
		{
			if (289514 - 100979 != 188536)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (4309 - 371660 == -367351)
				{
					base..ctor();
					if (144028 - 44196 != 99833)
					{
						this.$self_$43234 = self_;
						if (76614 - 4007 != 72608)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009EC2 RID: 40642 RVA: 0x012497FC File Offset: 0x012479FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M927_SilentEarth.$ReturnToTown$43230.$(this.$self_$43234);
		}

		// Token: 0x06009EC3 RID: 40643 RVA: 0x0124980C File Offset: 0x01247A0C
		internal static bool VbS2iMVgMQFrxtqByP0A()
		{
			return true;
		}

		// Token: 0x06009EC4 RID: 40644 RVA: 0x01249810 File Offset: 0x01247A10
		internal static bool WcPFnxVgxKOMmgP77ofx()
		{
			return false;
		}

		// Token: 0x040090BB RID: 37051
		internal M927_SilentEarth $self_$43234;

		// Token: 0x02001A96 RID: 6806
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009EC5 RID: 40645 RVA: 0x01249814 File Offset: 0x01247A14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M927_SilentEarth self_)
			{
				if (166529 - 250685 != -84156)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (281592 - 397598 == -116006)
					{
						base..ctor();
						if (188487 - 14224 != 174264)
						{
							this.$self_$43233 = self_;
							if (254864 - 462909 == -208045)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009EC6 RID: 40646 RVA: 0x012498AC File Offset: 0x01247AAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (23724 - 299771 != -276046)
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
						this.$self_$43233.LeaveGame();
						if (197356 - 155558 != 41798)
						{
							continue;
						}
						this.YieldDefault(1);
						if (153721 - 231427 != -77706)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (22677 - 564662 != -541985)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (22313 - 485339 == -463026)
					{
						Game.mStateTime = Time.time;
						if (166096 - 480242 != -314145)
						{
							this.$$switch$7897$43231 = PlayerData.SaveGuild;
							if (104647 - 126819 == -22172)
							{
								if (this.$$switch$7897$43231 == 1)
								{
									if (273896 - 498061 != -224165)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (179173 - 441169 == -261995)
									{
										continue;
									}
								}
								else if (this.$$switch$7897$43231 == 2)
								{
									if (80591 - 572381 == -491789)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (282759 - 372673 != -89914)
									{
										continue;
									}
								}
								else if (this.$$switch$7897$43231 == 3)
								{
									if (94279 - 556184 != -461905)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (283097 - 144544 == 138554)
									{
										continue;
									}
								}
								else if (this.$$switch$7897$43231 == 4)
								{
									if (53631 - 153703 != -100072)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (234377 - 586721 == -352343)
									{
										continue;
									}
								}
								else if (this.$$switch$7897$43231 == 5)
								{
									if (73674 - 570808 == -497133)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (16949 - 457622 != -440673)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (284613 - 168809 == 115805)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (164287 - 322716 != -158429)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (136542 - 263292 != -126750)
									{
										continue;
									}
								}
								this.$mGameGui$43232 = (GameGui)this.$self_$43233.GetComponent(typeof(GameGui));
								if (287372 - 377054 != -89681)
								{
									if (this.$mGameGui$43232)
									{
										if (167731 - 416919 == -249187)
										{
											continue;
										}
										this.$mGameGui$43232.close();
										if (279141 - 251324 == 27818)
										{
											continue;
										}
									}
									this.$self_$43233.SendMessage("fadeOut");
									if (60329 - 164935 == -104606)
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

			// Token: 0x06009EC7 RID: 40647 RVA: 0x01249C78 File Offset: 0x01247E78
			internal static bool H80fJaVggim8YKIJlYuR()
			{
				return true;
			}

			// Token: 0x06009EC8 RID: 40648 RVA: 0x01249C7C File Offset: 0x01247E7C
			internal static bool DuRDNxVgfl2w6iQjyETL()
			{
				return false;
			}

			// Token: 0x040090BC RID: 37052
			internal int $$switch$7897$43231;

			// Token: 0x040090BD RID: 37053
			internal GameGui $mGameGui$43232;

			// Token: 0x040090BE RID: 37054
			internal M927_SilentEarth $self_$43233;
		}
	}

	// Token: 0x02001A97 RID: 6807
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$43235 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009EC9 RID: 40649 RVA: 0x01249C80 File Offset: 0x01247E80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$43235(M927_SilentEarth self_)
		{
			if (252985 - 306894 != -53909)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (238197 - 53723 == 184474)
				{
					base..ctor();
					if (203824 - 262569 != -58744)
					{
						this.$self_$43238 = self_;
						if (219364 - 242516 != -23151)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009ECA RID: 40650 RVA: 0x01249D18 File Offset: 0x01247F18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M927_SilentEarth.$ReturnToGuild$43235.$(this.$self_$43238);
		}

		// Token: 0x06009ECB RID: 40651 RVA: 0x01249D28 File Offset: 0x01247F28
		internal static bool obl0nhVgn8rx58nU6CV1()
		{
			return true;
		}

		// Token: 0x06009ECC RID: 40652 RVA: 0x01249D2C File Offset: 0x01247F2C
		internal static bool uQLTfcVg6quI20nuHqdq()
		{
			return false;
		}

		// Token: 0x040090BF RID: 37055
		internal M927_SilentEarth $self_$43238;

		// Token: 0x02001A98 RID: 6808
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009ECD RID: 40653 RVA: 0x01249D30 File Offset: 0x01247F30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M927_SilentEarth self_)
			{
				if (90815 - 303559 != -212743)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (171829 - 89896 == 81933)
					{
						base..ctor();
						if (99971 - 455430 == -355459)
						{
							this.$self_$43237 = self_;
							if (106985 - 276641 != -169655)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009ECE RID: 40654 RVA: 0x01249DC8 File Offset: 0x01247FC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (268365 - 576745 != -308380)
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
						this.$self_$43237.LeaveGame();
						if (32770 - 97208 == -64437)
						{
							continue;
						}
						this.YieldDefault(1);
						if (139955 - 511978 != -372022)
						{
							goto Block_11;
						}
						continue;
					default:
						if (108856 - 417818 == -308961)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (96369 - 110303 == -13934)
					{
						Game.mStateTime = Time.time;
						if (5257 - 428877 == -423620)
						{
							Game.mNextGameCode = 31;
							if (131540 - 352479 != -220938)
							{
								this.$mGameGui$43236 = (GameGui)this.$self_$43237.GetComponent(typeof(GameGui));
								if (170787 - 65279 == 105508)
								{
									if (this.$mGameGui$43236)
									{
										if (171315 - 552739 != -381424)
										{
											continue;
										}
										this.$mGameGui$43236.close();
										if (270797 - 577880 == -307082)
										{
											continue;
										}
									}
									this.$self_$43237.SendMessage("fadeOut");
									if (177487 - 500369 == -322882)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_11:
				IL_1BD:
				return false;
			}

			// Token: 0x06009ECF RID: 40655 RVA: 0x01249FA4 File Offset: 0x012481A4
			internal static bool SBt9KpVgiCi3QnAXtQqI()
			{
				return true;
			}

			// Token: 0x06009ED0 RID: 40656 RVA: 0x01249FA8 File Offset: 0x012481A8
			internal static bool yvbp1pVgKm4O9qo1gXri()
			{
				return false;
			}

			// Token: 0x040090C0 RID: 37056
			internal GameGui $mGameGui$43236;

			// Token: 0x040090C1 RID: 37057
			internal M927_SilentEarth $self_$43237;
		}
	}

	// Token: 0x02001A99 RID: 6809
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$43239 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009ED1 RID: 40657 RVA: 0x01249FAC File Offset: 0x012481AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$43239(M927_SilentEarth self_)
		{
			if (245552 - 474956 != -229403)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (235132 - 199591 == 35541)
				{
					base..ctor();
					if (290779 - 62452 == 228327)
					{
						this.$self_$43243 = self_;
						if (251931 - 79408 != 172524)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009ED2 RID: 40658 RVA: 0x0124A044 File Offset: 0x01248244
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M927_SilentEarth.$ReturnToCamp$43239.$(this.$self_$43243);
		}

		// Token: 0x06009ED3 RID: 40659 RVA: 0x0124A054 File Offset: 0x01248254
		internal static bool Gbh76rVgdRyP1PZy13Si()
		{
			return true;
		}

		// Token: 0x06009ED4 RID: 40660 RVA: 0x0124A058 File Offset: 0x01248258
		internal static bool ggabPAVgJrtf3GR5I2jj()
		{
			return false;
		}

		// Token: 0x040090C2 RID: 37058
		internal M927_SilentEarth $self_$43243;

		// Token: 0x02001A9A RID: 6810
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009ED5 RID: 40661 RVA: 0x0124A05C File Offset: 0x0124825C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M927_SilentEarth self_)
			{
				if (92898 - 576253 != -483354)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (30874 - 234621 != -203746)
					{
						base..ctor();
						if (10682 - 501929 != -491246)
						{
							this.$self_$43242 = self_;
							if (14867 - 546125 != -531257)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009ED6 RID: 40662 RVA: 0x0124A0F4 File Offset: 0x012482F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (155750 - 93492 != 62259)
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
						this.$self_$43242.LeaveGame();
						if (147176 - 454971 == -307794)
						{
							continue;
						}
						this.YieldDefault(1);
						if (114027 - 387390 != -273362)
						{
							goto IL_363;
						}
						continue;
					default:
						if (297899 - 140149 == 157751)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (172256 - 462407 != -290150)
					{
						Game.mStateTime = Time.time;
						if (238877 - 394004 == -155127)
						{
							this.$$switch$7899$43240 = PlayerData.SaveGuild;
							if (194868 - 490327 != -295458)
							{
								if (this.$$switch$7899$43240 == 1)
								{
									if (192982 - 186538 != 6444)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (257125 - 45915 == 211211)
									{
										continue;
									}
								}
								else if (this.$$switch$7899$43240 == 2)
								{
									if (296856 - 246280 != 50576)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (206616 - 464875 != -258259)
									{
										continue;
									}
								}
								else if (this.$$switch$7899$43240 == 3)
								{
									if (215554 - 317367 == -101812)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (245984 - 529961 != -283977)
									{
										continue;
									}
								}
								else if (this.$$switch$7899$43240 == 4)
								{
									if (206545 - 76925 == 129621)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (111759 - 552839 == -441079)
									{
										continue;
									}
								}
								else if (this.$$switch$7899$43240 == 5)
								{
									if (231086 - 248910 == -17823)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (202847 - 537415 != -334568)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (191805 - 476095 == -284289)
									{
										continue;
									}
								}
								this.$mGameGui$43241 = (GameGui)this.$self_$43242.GetComponent(typeof(GameGui));
								if (263396 - 93589 != 169808)
								{
									if (this.$mGameGui$43241)
									{
										if (140953 - 318738 != -177785)
										{
											continue;
										}
										this.$mGameGui$43241.close();
										if (258067 - 363372 != -105305)
										{
											continue;
										}
									}
									this.$self_$43242.SendMessage("fadeOut");
									if (184883 - 593866 == -408983)
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

			// Token: 0x06009ED7 RID: 40663 RVA: 0x0124A478 File Offset: 0x01248678
			internal static bool EOAB2nVgDP3nOyl98p5k()
			{
				return true;
			}

			// Token: 0x06009ED8 RID: 40664 RVA: 0x0124A47C File Offset: 0x0124867C
			internal static bool qTDN0AVgvxqkfpm4IjlT()
			{
				return false;
			}

			// Token: 0x040090C3 RID: 37059
			internal int $$switch$7899$43240;

			// Token: 0x040090C4 RID: 37060
			internal GameGui $mGameGui$43241;

			// Token: 0x040090C5 RID: 37061
			internal M927_SilentEarth $self_$43242;
		}
	}
}
