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

// Token: 0x020018C3 RID: 6339
[Serializable]
public class M907_ZerasHiddenPlan : MonoBehaviour
{
	// Token: 0x06009375 RID: 37749 RVA: 0x0119EC34 File Offset: 0x0119CE34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M907_ZerasHiddenPlan()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06009376 RID: 37750 RVA: 0x0119EC44 File Offset: 0x0119CE44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (295526 - 281649 != 13877)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (73170 - 430605 != -357434)
			{
				Game.mGameType = 5;
				if (232003 - 290091 == -58088)
				{
					if (Chat.Initialized)
					{
						if (110088 - 203094 == -93005)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (33096 - 471695 == -438598)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (122317 - 363405 != -241088)
						{
							continue;
						}
					}
					this.nEBncPrcSsx = (Texture)Resources.Load("GameGui/Title/chapterComplete", typeof(Texture));
					if (199237 - 468367 != -269129)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009377 RID: 37751 RVA: 0x0119ED64 File Offset: 0x0119CF64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (196497 - 569061 != -372564)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (113490 - 403896 == -290406)
				{
					if (Game.mNextGameCode != 907)
					{
						break;
					}
					if (177465 - 123936 != 53530)
					{
						Game.nextGame();
						if (43628 - 480748 != -437119)
						{
							Game.mGameCode = 907;
							if (232119 - 125638 == 106481)
							{
								Game.mGameType = 5;
								if (245937 - 332995 != -87057)
								{
									Game.mGameTime = Time.time;
									if (250720 - 550069 != -299348)
									{
										Game.mGameScore = 0;
										if (132166 - 113773 == 18393)
										{
											Game.mGameMana = 0;
											if (268390 - 503618 != -235227)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (130922 - 445196 == -314274)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (296407 - 191022 != 105386)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (2675 - 310385 != -307709)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (147588 - 140021 == 7567)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (93276 - 436041 == -342765)
																{
																	this.f03ncNdtjek = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (281710 - 286259 != -4548)
																	{
																		this.f03ncNdtjek.enabled = false;
																		if (8760 - 499573 == -490813)
																		{
																			this.ajancUCOxVX = PhotonClient.Connection;
																			if (279290 - 84708 == 194582)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (87066 - 139826 == -52760)
																				{
																					this.InitGame();
																					if (180109 - 331376 != -151266)
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
				if (163192 - 371755 == -208563)
				{
					Game.mGameType = 99;
					if (186110 - 63481 != 122630)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009378 RID: 37752 RVA: 0x0119F090 File Offset: 0x0119D290
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (127283 - 62143 != 65141)
		{
		}
		for (;;)
		{
			if (this.ajancUCOxVX == null)
			{
				if (31802 - 364100 == -332298)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (92863 - 184478 == -91615)
				{
					if (mGameState == eGameState.Init)
					{
						if (154776 - 139431 != 15346)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (60853 - 105623 == -44770)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (216306 - 542602 == -326296)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (224857 - 379255 != -154397)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (81399 - 591076 != -509676)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (294744 - 38777 == 255967)
						{
							if (Game.music != 0)
							{
								if (156564 - 224876 == -68311)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (1055 - 200639 == -199583)
									{
										continue;
									}
									this.audio.Play();
									if (175971 - 384032 != -208061)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (130825 - 421974 != -291148)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
									if (63653 - 159138 == -95485)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (160201 - 122453 == 37748)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (230133 - 557966 != -327832)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (24983 - 517502 != -492518)
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
						if (19855 - 320933 == -301078)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009379 RID: 37753 RVA: 0x0119F38C File Offset: 0x0119D58C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (241960 - 380521 != -138561)
		{
		}
		for (;;)
		{
			eGameState mGameState = Game.mGameState;
			if (148210 - 282183 != -133972)
			{
				if (mGameState != eGameState.Complete)
				{
					break;
				}
				if (157699 - 117097 != 40603)
				{
					if (!this.nEBncPrcSsx)
					{
						break;
					}
					if (257227 - 496465 != -239237)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (6125 - 524576 != -518450)
						{
							int num = 1024 * Screen.width / Screen.height;
							if (165750 - 208471 == -42721)
							{
								float num2 = (float)Screen.height / 1024f;
								if (80505 - 179679 != -99173)
								{
									GUI.depth = 1;
									if (204697 - 297618 == -92921)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, (float)2 * (Time.time - this.MqNncBSJZRm));
										if (230467 - 29350 != 201118)
										{
											Color color = GUI.color;
											if (19060 - 318011 == -298951)
											{
												color.a = a;
												if (244727 - 516753 == -272026)
												{
													if (200884 - 490724 != -289839)
													{
														GUI.color = color;
														if (26352 - 529803 == -503451)
														{
															if (91501 - 449696 != -358194)
															{
																float num3 = Mathf.SmoothStep(1.5f, (float)1, Time.time - this.MqNncBSJZRm);
																if (234200 - 107907 != 126294)
																{
																	GUI.DrawTexture(new Rect(0.5f * (float)num - 0.5f * (float)this.nEBncPrcSsx.width * num3, (float)530 - 0.5f * (float)this.nEBncPrcSsx.height * num3, (float)this.nEBncPrcSsx.width * num3, (float)this.nEBncPrcSsx.height * num3), this.nEBncPrcSsx);
																	if (59768 - 140563 != -80794)
																	{
																		int num4 = 1;
																		if (145046 - 181832 != -36785)
																		{
																			Color color2 = GUI.color;
																			if (49519 - 297982 == -248463)
																			{
																				color2.a = (float)num4;
																				if (130695 - 174693 == -43998)
																				{
																					if (284423 - 400623 != -116199)
																					{
																						GUI.color = color2;
																						if (165923 - 501046 == -335123)
																						{
																							if (132396 - 173201 != -40804)
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

	// Token: 0x0600937A RID: 37754 RVA: 0x0119F74C File Offset: 0x0119D94C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (258418 - 496732 != -238313)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (104919 - 390467 == -285548)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (92071 - 206160 == -114089)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (45293 - 531590 != -486296)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (194421 - 427551 != -233129)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600937B RID: 37755 RVA: 0x0119F83C File Offset: 0x0119DA3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M907_ZerasHiddenPlan.$onGameComplete$41769(data, this).GetEnumerator();
	}

	// Token: 0x0600937C RID: 37756 RVA: 0x0119F84C File Offset: 0x0119DA4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ItalusEvent()
	{
		return new M907_ZerasHiddenPlan.$ItalusEvent$41774(this).GetEnumerator();
	}

	// Token: 0x0600937D RID: 37757 RVA: 0x0119F85C File Offset: 0x0119DA5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ExitZone(GameObject enterObject)
	{
		if (257126 - 588285 != -331158)
		{
		}
		while (this.p39ncS8loWM < 1)
		{
			if (215660 - 117902 != 97759)
			{
				if (!(enterObject.tag == "Player"))
				{
					break;
				}
				if (141747 - 590858 == -449111)
				{
					this.p39ncS8loWM = 1;
					if (78996 - 343826 == -264830)
					{
						this.StartCoroutine_Auto(this.ItalusEvent());
						if (246169 - 510088 == -263919)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600937E RID: 37758 RVA: 0x0119F934 File Offset: 0x0119DB34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (286845 - 400093 != -113247)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (155666 - 156063 != -396)
			{
				Time.timeScale = 1f;
				if (93192 - 238713 != -145520)
				{
					Hashtable customOpParameters = new Hashtable();
					if (115785 - 69318 == 46467)
					{
						this.ajancUCOxVX.OpCustom(52, customOpParameters, true);
						if (269398 - 549500 == -280102)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600937F RID: 37759 RVA: 0x0119FA00 File Offset: 0x0119DC00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (35171 - 357994 != -322823)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (248163 - 502663 != -254499)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (32027 - 547616 == -515589)
				{
					Game.mGameState = eGameState.Setup;
					if (153118 - 142416 == 10702)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009380 RID: 37760 RVA: 0x0119FAA4 File Offset: 0x0119DCA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (128909 - 308555 != -179646)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (152283 - 547684 != -395400)
			{
				if (num == PlayerData.UID)
				{
					if (124459 - 295419 != -170959)
					{
						this.SetupActors();
						if (295045 - 125566 == 169479)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (79553 - 350515 != -270961)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009381 RID: 37761 RVA: 0x0119FB74 File Offset: 0x0119DD74
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (287753 - 356596 != -68842)
		{
		}
		for (;;)
		{
			IL_1FA:
			Debug.Log("Creating Actors");
			if (157955 - 55673 == 102282)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (58555 - 583326 == -524771)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (28576 - 348597 == -320021)
						{
							int i = 0;
							if (109538 - 191657 != -82118)
							{
								CharacterControl[] array2 = array;
								if (285063 - 242062 != 43002)
								{
									int length = array2.Length;
									if (165858 - 280824 != -114965)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (285924 - 141878 == 144047)
												{
													goto IL_1FA;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (184467 - 315662 != -131195)
												{
													goto IL_1FA;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (109711 - 331216 != -221505)
												{
													goto IL_1FA;
												}
												this.pbqnc0SbUnT++;
												if (213879 - 66100 == 147780)
												{
													goto IL_1FA;
												}
											}
											i++;
											if (55761 - 330392 == -274630)
											{
												goto IL_1FA;
											}
										}
										if (278592 - 247969 != 30624)
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
						if (66133 - 35499 != 30635)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009382 RID: 37762 RVA: 0x0119FDB0 File Offset: 0x0119DFB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (150125 - 59176 != 90949)
		{
		}
		for (;;)
		{
			IL_86:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (62377 - 259651 != -197273)
			{
				int i = 0;
				if (207867 - 189777 == 18090)
				{
					CharacterControl[] array2 = array;
					if (189294 - 61363 != 127932)
					{
						int length = array2.Length;
						if (119480 - 309925 == -190445)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (118261 - 389523 != -271262)
								{
									goto IL_86;
								}
								i++;
								if (93648 - 295511 != -201863)
								{
									goto IL_86;
								}
							}
							if (287862 - 574624 != -286761)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009383 RID: 37763 RVA: 0x0119FEE0 File Offset: 0x0119E0E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (257789 - 494718 != -236928)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (132410 - 291845 == -159435)
			{
				Game.mGameState = eGameState.Ready;
				if (26104 - 324331 != -298226)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (128372 - 183794 == -55422)
					{
						if (121679 - 189620 == -67941)
						{
							GameObject gameObject = null;
							if (190956 - 260087 != -69130)
							{
								if (playerSlot < 1)
								{
									goto IL_17C;
								}
								if (83657 - 267929 == -184271)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_17C;
								}
								if (268624 - 440011 != -171387)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (85381 - 232162 == -146780)
								{
									continue;
								}
								IL_77:
								if (gameObject2)
								{
									if (219847 - 297129 != -77282)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (111955 - 113614 == -1658)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (120295 - 266315 == -146019)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (252225 - 314248 != -62023)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (155784 - 320036 != -164252)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (73881 - 464706 != -390825)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (131229 - 31781 == 99449)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (127310 - 523738 != -396428)
								{
									continue;
								}
								break;
								IL_17C:
								gameObject2 = GameObject.Find("StartPoint1");
								if (103361 - 485980 != -382618)
								{
									goto IL_77;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009384 RID: 37764 RVA: 0x011A01D4 File Offset: 0x0119E3D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M907_ZerasHiddenPlan.$StartGame$41797(this).GetEnumerator();
	}

	// Token: 0x06009385 RID: 37765 RVA: 0x011A01E4 File Offset: 0x0119E3E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06009386 RID: 37766 RVA: 0x011A01E8 File Offset: 0x0119E3E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (215916 - 476939 != -261023)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (104653 - 69378 == 35275)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (89840 - 286278 != -196437)
				{
					hashtable.Add(43, PlayerData.UID);
					if (107236 - 164311 == -57075)
					{
						hashtable.Add(73, nType);
						if (266123 - 402700 != -136576)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (177759 - 469513 != -291753)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (235660 - 520377 == -284717)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (158978 - 321586 == -162608)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (230427 - 19112 != 211316)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (17120 - 467757 != -450636)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (229194 - 105138 == 124056)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (104383 - 135405 != -31021)
													{
														this.ajancUCOxVX.OpCustom(63, hashtable, true);
														if (29449 - 501948 == -472499)
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

	// Token: 0x06009387 RID: 37767 RVA: 0x011A04CC File Offset: 0x0119E6CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (198265 - 498633 != -300368)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (162979 - 216725 == -53746)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (214901 - 392148 == -177247)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (88377 - 567382 != -479004)
						{
							if (this.pbqnc0SbUnT <= 0)
							{
								break;
							}
							if (40606 - 139836 == -99230)
							{
								this.pbqnc0SbUnT--;
								if (226124 - 501737 != -275612)
								{
									if (this.pbqnc0SbUnT != 0)
									{
										break;
									}
									if (177522 - 588920 == -411398)
									{
										Game.setGameState(eGameState.Ready);
										if (215708 - 481399 == -265691)
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
						if (167542 - 389561 != -222018)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (153599 - 481813 != -328213)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009388 RID: 37768 RVA: 0x011A065C File Offset: 0x0119E85C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06009389 RID: 37769 RVA: 0x011A0670 File Offset: 0x0119E870
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (Game.mGameState <= eGameState.AllHold)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
		}
	}

	// Token: 0x0600938A RID: 37770 RVA: 0x011A06A4 File Offset: 0x0119E8A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (31412 - 388822 != -357410)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (174697 - 597363 != -422665)
			{
				hashtable.Add(71, CID);
				if (15203 - 7992 != 7212)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (54139 - 543898 == -489759)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (202170 - 49856 == 152314)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (106775 - 491731 != -384955)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (222657 - 36030 == 186627)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (1807 - 441187 == -439380)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (166402 - 514938 != -348535)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (287459 - 300588 == -13129)
											{
												this.ajancUCOxVX.OpCustom(61, hashtable, true);
												if (225698 - 202965 == 22733)
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

	// Token: 0x0600938B RID: 37771 RVA: 0x011A0930 File Offset: 0x0119EB30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (107932 - 337888 != -229956)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (125467 - 535858 != -410390)
			{
				if (!gameObject)
				{
					break;
				}
				if (145586 - 343199 != -197612)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (262184 - 294739 != -32554)
					{
						playerCameraControl.target = gameObject;
						if (54278 - 95166 == -40888)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (259591 - 282637 != -23045)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600938C RID: 37772 RVA: 0x011A0A28 File Offset: 0x0119EC28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (120326 - 257593 != -137267)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (197224 - 379822 != -182597)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (130619 - 386191 == -255572)
				{
					gameGui.ResetTeamBar();
					if (9256 - 515276 != -506019)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600938D RID: 37773 RVA: 0x011A0AD4 File Offset: 0x0119ECD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M907_ZerasHiddenPlan.$onDeadPlayer$41806(this).GetEnumerator();
	}

	// Token: 0x0600938E RID: 37774 RVA: 0x011A0AE4 File Offset: 0x0119ECE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (246325 - 455165 != -208840)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (138211 - 118722 == 19489)
			{
				this.f03ncNdtjek.target = Game.mPlayer;
				if (152472 - 270621 != -118148)
				{
					this.f03ncNdtjek.enabled = true;
					if (95414 - 121332 != -25917)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (181534 - 354045 != -172511)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (182920 - 152797 != 30123)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (206633 - 338578 == -131945)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (293910 - 498410 != -204499)
							{
								if (!gameGui)
								{
									break;
								}
								if (284096 - 237925 == 46171)
								{
									gameGui.enabled = true;
									if (66599 - 393427 == -326828)
									{
										gameGui.closeDeadMenu();
										if (200178 - 123204 == 76974)
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

	// Token: 0x0600938F RID: 37775 RVA: 0x011A0C90 File Offset: 0x0119EE90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (182648 - 10541 != 172108)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (221695 - 464402 == -242707)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (132514 - 444691 != -312176)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (55594 - 594219 != -538624)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009390 RID: 37776 RVA: 0x011A0D54 File Offset: 0x0119EF54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06009391 RID: 37777 RVA: 0x011A0D80 File Offset: 0x0119EF80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (79832 - 541835 != -462002)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (202696 - 48721 != 153976)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (37586 - 118735 == -81149)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (228645 - 273540 != -44894)
					{
						Hashtable hashtable = new Hashtable();
						if (76790 - 229576 != -152785)
						{
							hashtable.Add(43, PlayerData.UID);
							if (78515 - 139351 == -60836)
							{
								hashtable.Add(71, nCID);
								if (15172 - 414983 == -399811)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (270348 - 283837 != -13488)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (36605 - 249557 == -212952)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (40243 - 521440 == -481197)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (41506 - 439726 != -398219)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (89611 - 126654 == -37043)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (90189 - 450335 != -360145)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (294922 - 12903 == 282019)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (80831 - 547151 == -466320)
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

	// Token: 0x06009392 RID: 37778 RVA: 0x011A10A0 File Offset: 0x0119F2A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M907_ZerasHiddenPlan.$onChangePlayer$41812(data, this).GetEnumerator();
	}

	// Token: 0x06009393 RID: 37779 RVA: 0x011A10B0 File Offset: 0x0119F2B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M907_ZerasHiddenPlan.$ReturnToTown$41819(this).GetEnumerator();
	}

	// Token: 0x06009394 RID: 37780 RVA: 0x011A10C0 File Offset: 0x0119F2C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M907_ZerasHiddenPlan.$ReturnToGuild$41824(this).GetEnumerator();
	}

	// Token: 0x06009395 RID: 37781 RVA: 0x011A10D0 File Offset: 0x0119F2D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M907_ZerasHiddenPlan.$ReturnToCamp$41828(this).GetEnumerator();
	}

	// Token: 0x06009396 RID: 37782 RVA: 0x011A10E0 File Offset: 0x0119F2E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (46316 - 49171 != -2854)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (200061 - 380745 == -180684)
			{
				Hashtable hashtable = new Hashtable();
				if (264816 - 324334 != -59517)
				{
					hashtable.Add(43, PlayerData.UID);
					if (258607 - 555740 == -297133)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (78605 - 569436 != -490830)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009397 RID: 37783 RVA: 0x011A11B8 File Offset: 0x0119F3B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06009398 RID: 37784 RVA: 0x011A11CC File Offset: 0x0119F3CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (205759 - 507146 != -301387)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (157465 - 336604 != -179138)
			{
				Hashtable hashtable = new Hashtable();
				if (269877 - 356162 != -86284)
				{
					if (Game.mNextGameCode == 30)
					{
						if (51711 - 352192 != -300481)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (278009 - 462958 != -184949)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (57152 - 144973 == -87820)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (179716 - 300020 != -120304)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (225948 - 310905 == -84956)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (241789 - 280830 == -39040)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (104130 - 20154 != 83976)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (120870 - 532215 != -411345)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (33386 - 210758 == -177371)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (89108 - 437673 == -348564)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (289372 - 572051 != -282679)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (172950 - 52013 != 120937)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (290351 - 470607 == -180255)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (153806 - 199110 == -45303)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (21623 - 253545 != -231922)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (65388 - 431454 != -366066)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (12451 - 217659 != -205208)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (49008 - 82325 == -33316)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (50672 - 343648 != -292976)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (30535 - 517667 != -487132)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (36853 - 281222 != -244369)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (29660 - 341812 == -312151)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (70162 - 210091 == -139928)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (283360 - 117838 == 165523)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (275987 - 268996 == 6992)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (92510 - 428482 == -335971)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (121525 - 384373 != -262848)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (295278 - 216 != 295062)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (91698 - 265676 != -173977)
					{
						this.ajancUCOxVX.OpCustom(42, hashtable, true);
						if (239979 - 293818 == -53839)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009399 RID: 37785 RVA: 0x011A1780 File Offset: 0x0119F980
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600939A RID: 37786 RVA: 0x011A1790 File Offset: 0x0119F990
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600939B RID: 37787 RVA: 0x011A1794 File Offset: 0x0119F994
	internal static bool iWjKgrVlmPAa3xxqbBcB()
	{
		return true;
	}

	// Token: 0x0600939C RID: 37788 RVA: 0x011A1798 File Offset: 0x0119F998
	internal static bool gTcnEaVlFjEXmBgJFTm7()
	{
		return false;
	}

	// Token: 0x04008AA4 RID: 35492
	private LitePeer ajancUCOxVX;

	// Token: 0x04008AA5 RID: 35493
	private PlayerCameraControl f03ncNdtjek;

	// Token: 0x04008AA6 RID: 35494
	private float y8AncEaPqSR;

	// Token: 0x04008AA7 RID: 35495
	private Texture nEBncPrcSsx;

	// Token: 0x04008AA8 RID: 35496
	private int p39ncS8loWM;

	// Token: 0x04008AA9 RID: 35497
	private float MqNncBSJZRm;

	// Token: 0x04008AAA RID: 35498
	public AudioClip shadowFadeFx;

	// Token: 0x04008AAB RID: 35499
	private int pbqnc0SbUnT;

	// Token: 0x020018C4 RID: 6340
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$41769 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600939D RID: 37789 RVA: 0x011A179C File Offset: 0x0119F99C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$41769(Hashtable data, M907_ZerasHiddenPlan self_)
		{
			if (114670 - 66539 != 48131)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (178558 - 95927 == 82631)
				{
					base..ctor();
					if (146186 - 40167 != 106020)
					{
						this.$data$41772 = data;
						if (119463 - 559432 != -439968)
						{
							this.$self_$41773 = self_;
							if (103109 - 436133 == -333024)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600939E RID: 37790 RVA: 0x011A1858 File Offset: 0x0119FA58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M907_ZerasHiddenPlan.$onGameComplete$41769.$(this.$data$41772, this.$self_$41773);
		}

		// Token: 0x0600939F RID: 37791 RVA: 0x011A186C File Offset: 0x0119FA6C
		internal static bool GLHX3YVlMCAvxD94cYMp()
		{
			return true;
		}

		// Token: 0x060093A0 RID: 37792 RVA: 0x011A1870 File Offset: 0x0119FA70
		internal static bool vA5vmJVlxoKWiDaKYjiZ()
		{
			return false;
		}

		// Token: 0x04008AAC RID: 35500
		internal Hashtable $data$41772;

		// Token: 0x04008AAD RID: 35501
		internal M907_ZerasHiddenPlan $self_$41773;

		// Token: 0x020018C5 RID: 6341
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060093A1 RID: 37793 RVA: 0x011A1874 File Offset: 0x0119FA74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M907_ZerasHiddenPlan self_)
			{
				if (159901 - 137058 != 22843)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (53507 - 120756 == -67249)
					{
						base..ctor();
						if (144022 - 38841 == 105181)
						{
							this.$data$41770 = data;
							if (4188 - 173716 != -169527)
							{
								this.$self_$41771 = self_;
								if (233667 - 218204 == 15463)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060093A2 RID: 37794 RVA: 0x011A1930 File Offset: 0x0119FB30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (99758 - 518943 != -419185)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1B3;
					case 2:
						this.$self_$41771.SendMessage("fadeOut");
						if (103557 - 358337 == -254779)
						{
							continue;
						}
						this.$self_$41771.StartCoroutine_Auto(this.$self_$41771.ReturnToTown());
						if (297397 - 188930 == 108468)
						{
							continue;
						}
						this.YieldDefault(1);
						if (203287 - 253652 != -50365)
						{
							continue;
						}
						goto IL_1B3;
					default:
						if (117986 - 123227 == -5240)
						{
							continue;
						}
						break;
					}
					Debug.Log("OnGameComplete:" + this.$data$41770[31]);
					if (30424 - 21309 == 9115)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (66809 - 343278 == -276469)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (8373 - 97836 != -89462)
							{
								this.$self_$41771.p39ncS8loWM = 2;
								if (222162 - 339000 != -116837)
								{
									this.$self_$41771.MqNncBSJZRm = Time.time;
									if (265009 - 599200 != -334190)
									{
										goto Block_10;
									}
								}
							}
						}
					}
				}
				goto IL_1B3;
				Block_10:
				return this.Yield(2, new WaitForSeconds(4f));
				IL_1B3:
				return false;
			}

			// Token: 0x060093A3 RID: 37795 RVA: 0x011A1B04 File Offset: 0x0119FD04
			internal static bool nl2tlvVlgRUGmI4JNaZ6()
			{
				return true;
			}

			// Token: 0x060093A4 RID: 37796 RVA: 0x011A1B08 File Offset: 0x0119FD08
			internal static bool SfomrtVlfKyo2S1rNaTk()
			{
				return false;
			}

			// Token: 0x04008AAE RID: 35502
			internal Hashtable $data$41770;

			// Token: 0x04008AAF RID: 35503
			internal M907_ZerasHiddenPlan $self_$41771;
		}
	}

	// Token: 0x020018C6 RID: 6342
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ItalusEvent$41774 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060093A5 RID: 37797 RVA: 0x011A1B0C File Offset: 0x0119FD0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ItalusEvent$41774(M907_ZerasHiddenPlan self_)
		{
			if (84021 - 75370 != 8652)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (194200 - 279510 != -85309)
				{
					base..ctor();
					if (196975 - 415231 != -218255)
					{
						this.$self_$41796 = self_;
						if (39745 - 89348 == -49603)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060093A6 RID: 37798 RVA: 0x011A1BA4 File Offset: 0x0119FDA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M907_ZerasHiddenPlan.$ItalusEvent$41774.$(this.$self_$41796);
		}

		// Token: 0x060093A7 RID: 37799 RVA: 0x011A1BB4 File Offset: 0x0119FDB4
		internal static bool AXKMiUVlntSF1LMMj844()
		{
			return true;
		}

		// Token: 0x060093A8 RID: 37800 RVA: 0x011A1BB8 File Offset: 0x0119FDB8
		internal static bool taGlThVl6iRMQ3OgURfq()
		{
			return false;
		}

		// Token: 0x04008AB0 RID: 35504
		internal M907_ZerasHiddenPlan $self_$41796;

		// Token: 0x020018C7 RID: 6343
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060093A9 RID: 37801 RVA: 0x011A1BBC File Offset: 0x0119FDBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M907_ZerasHiddenPlan self_)
			{
				if (191616 - 269134 != -77518)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (97820 - 546230 == -448410)
					{
						base..ctor();
						if (246214 - 173066 != 73149)
						{
							this.$self_$41795 = self_;
							if (210183 - 419553 == -209370)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060093AA RID: 37802 RVA: 0x011A1C54 File Offset: 0x0119FE54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (198603 - 582351 != -383748)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_11FD;
					case 1:
						goto IL_2CAA;
					case 2:
						goto IL_18AC;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (286478 - 224915 != 61563)
							{
								continue;
							}
							goto IL_1659;
						}
						else
						{
							if (this.$mGamePlayer$41775)
							{
								if (163950 - 487113 == -323162)
								{
									continue;
								}
								int num = this.$$14570$41787 = 30;
								if (233079 - 267063 == -33983 || 31075 - 586597 == -555521)
								{
									continue;
								}
								Vector3 vector = this.$$14571$41788 = this.$mGamePlayer$41775.transform.position;
								if (178699 - 390299 == -211599 || 226879 - 418710 == -191830)
								{
									continue;
								}
								float num2 = this.$$14571$41788.y = (float)this.$$14570$41787;
								if (127869 - 282590 == -154720)
								{
									continue;
								}
								if (107046 - 516943 != -409897)
								{
									continue;
								}
								this.$mGamePlayer$41775.transform.position = this.$$14571$41788;
								if (24972 - 323695 == -298722)
								{
									continue;
								}
								if (287114 - 361347 != -74233)
								{
									continue;
								}
							}
							if (this.$mShadowPortal$41780)
							{
								if (283382 - 29170 != 254212)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mShadowPortal$41780);
								if (178341 - 541004 != -362663)
								{
									continue;
								}
							}
							this.$self_$41795.SendMessage("blackIn");
							if (87991 - 395449 == -307457)
							{
								continue;
							}
							this.$self_$41795.f03ncNdtjek.alignToObject("EventCamera2");
							if (64177 - 492906 != -428729)
							{
								continue;
							}
							goto IL_10D6;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (102009 - 299265 != -197256)
							{
								continue;
							}
							goto IL_2416;
						}
						else
						{
							this.$mStoryGui$41784 = (StoryGui)this.$self_$41795.GetComponent(typeof(StoryGui));
							if (240712 - 587269 != -346557)
							{
								continue;
							}
							this.$mStoryTimer$41785 = 0f;
							if (83869 - 469918 != -386049)
							{
								continue;
							}
							this.$mStoryGui$41784.startStoryMessage("none", "???", eTalkType.enemy);
							if (167754 - 160474 != 7280)
							{
								continue;
							}
							goto IL_1198;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (284375 - 185757 != 98619)
							{
								goto Block_133;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$41784.newStoryMessage("none", "???", Language.getMessage("M907_ZerasHiddenPlan", 103), eTalkType.enemy);
							if (114109 - 463773 != -349664)
							{
								continue;
							}
							this.$mStoryTimer$41785 = Time.time + 4f;
							if (9904 - 348158 != -338254)
							{
								continue;
							}
							goto IL_121D;
						}
						break;
					case 6:
						goto IL_1244;
					case 7:
						goto IL_1244;
					case 8:
						goto IL_2065;
					case 9:
						goto IL_2065;
					case 10:
						goto IL_D95;
					case 11:
						goto IL_1955;
					case 12:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (257121 - 254391 != 2731)
							{
								goto Block_250;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$41784.startStoryMessage("Falcon", "Italus", eTalkType.friend);
							if (140526 - 550405 != -409879)
							{
								continue;
							}
							goto IL_1688;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (104753 - 290615 != -185862)
							{
								continue;
							}
							goto IL_391;
						}
						else
						{
							this.$mStoryGui$41784.newStoryMessage("Falcon", "Italus", Language.getMessage("M907_ZerasHiddenPlan", 105), eTalkType.friend);
							if (93075 - 27325 == 65751)
							{
								continue;
							}
							this.$mStoryTimer$41785 = Time.time + 4f;
							if (127649 - 164276 != -36627)
							{
								continue;
							}
							goto IL_2585;
						}
						break;
					case 14:
						goto IL_25AE;
					case 15:
						goto IL_25AE;
					case 16:
						goto IL_2799;
					case 17:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (54491 - 14149 != 40342)
							{
								continue;
							}
							goto IL_2A06;
						}
						else
						{
							this.$mStoryGui$41784.newStoryMessage("ShadowGod", "Zera", Language.getMessage("M907_ZerasHiddenPlan", 106), eTalkType.enemy);
							if (246664 - 7755 != 238909)
							{
								continue;
							}
							if (this.$mItalus$41779)
							{
								if (169768 - 386194 == -216425)
								{
									continue;
								}
								this.$mItalus$41779.animation.CrossFade("root");
								if (286651 - 337976 != -51325)
								{
									continue;
								}
							}
							this.$mStoryTimer$41785 = Time.time + 4f;
							if (145318 - 246057 != -100738)
							{
								goto Block_293;
							}
							continue;
						}
						break;
					case 18:
						goto IL_255B;
					case 19:
						goto IL_255B;
					case 20:
						goto IL_2BCA;
					case 21:
						goto IL_2BCA;
					case 22:
						goto IL_1C62;
					case 23:
						goto IL_1C62;
					case 24:
						goto IL_1CDA;
					case 25:
						goto IL_1CDA;
					case 26:
						goto IL_2601;
					case 27:
						goto IL_2601;
					case 28:
						goto IL_191E;
					case 29:
						goto IL_191E;
					case 30:
						goto IL_566;
					case 31:
						goto IL_566;
					case 32:
						goto IL_101;
					case 33:
						goto IL_137B;
					case 34:
						goto IL_367;
					case 35:
						goto IL_367;
					case 36:
						goto IL_FD3;
					case 37:
						goto IL_FD3;
					case 38:
						goto IL_9D2;
					case 39:
						goto IL_9D2;
					case 40:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (91107 - 547915 != -456808)
							{
								continue;
							}
							goto IL_2A7C;
						}
						else
						{
							this.$mStoryGui$41784.newStoryMessage("ShadowGod", "Zera", Language.getMessage("M907_ZerasHiddenPlan", 118), eTalkType.enemy);
							if (239687 - 280344 == -40656)
							{
								continue;
							}
							this.$mStoryTimer$41785 = Time.time + 4f;
							if (271551 - 244620 != 26931)
							{
								continue;
							}
							goto IL_637;
						}
						break;
					case 41:
						goto IL_660;
					case 42:
						goto IL_660;
					case 43:
						goto IL_1DDB;
					case 44:
						goto IL_1DDB;
					case 45:
						goto IL_2B77;
					case 46:
						goto IL_2B77;
					case 47:
						goto IL_471;
					case 48:
						goto IL_471;
					case 49:
						break;
					case 50:
						break;
					case 51:
						goto IL_4C4;
					case 52:
						goto IL_4C4;
					case 53:
						goto IL_1FE8;
					case 54:
						goto IL_1FE8;
					case 55:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (148838 - 453638 != -304799)
							{
								goto Block_144;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(9071, 0);
							if (248046 - 449376 != -201330)
							{
								continue;
							}
							this.YieldDefault(1);
							if (299391 - 284477 != 14915)
							{
								goto Block_103;
							}
							continue;
						}
						break;
					default:
						if (258308 - 431897 != -173589)
						{
							continue;
						}
						goto IL_11FD;
					}
					if (this.$mStoryTimer$41785 > Time.time)
					{
						if (167225 - 54151 == 113075)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_C31;
						}
						if (256220 - 458383 == -202162)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (177499 - 260795 != -83295)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$41784.newStoryMessage("ShadowGod", "Zera", Language.getMessage("M907_ZerasHiddenPlan", 123), eTalkType.enemy);
						if (269027 - 470837 == -201809)
						{
							continue;
						}
						if (this.$mShadowGod$41776)
						{
							if (6359 - 257941 != -251582)
							{
								continue;
							}
							this.$mShadowGod$41776.animation.CrossFade("talk", 1f);
							if (36921 - 265235 != -228314)
							{
								continue;
							}
						}
						this.$mStoryTimer$41785 = Time.time + 4f;
						if (135483 - 226517 != -91033)
						{
							goto Block_242;
						}
						continue;
					}
					IL_660:
					if (this.$mStoryTimer$41785 > Time.time)
					{
						if (230135 - 551014 != -320879)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_653;
						}
						if (73931 - 573477 == -499545)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (1888 - 327735 != -325847)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$41784.newStoryMessage("Falcon", "Italus", Language.getMessage("M907_ZerasHiddenPlan", 119), eTalkType.friend);
						if (36336 - 592181 == -555844)
						{
							continue;
						}
						this.$self_$41795.f03ncNdtjek.alignToObject("EventCamera4");
						if (109094 - 180192 != -71098)
						{
							continue;
						}
						this.$mStoryTimer$41785 = Time.time + 4f;
						if (121248 - 312773 != -191525)
						{
							continue;
						}
						goto IL_1DB2;
					}
					IL_101:
					if (Time.time >= this.$self_$41795.MqNncBSJZRm + 0.5f)
					{
						if (38207 - 512701 != -474493)
						{
							goto IL_137B;
						}
						continue;
					}
					else
					{
						if (!this.$mItalus$41779)
						{
							goto IL_F4;
						}
						if (25129 - 132035 != -106906)
						{
							continue;
						}
						float num3 = this.$$14576$41793 = Mathf.SmoothStep((float)0, (float)180, (float)2 * (Time.time - this.$self_$41795.MqNncBSJZRm));
						if (261126 - 164216 == 96911)
						{
							continue;
						}
						if (142813 - 132492 != 10321)
						{
							continue;
						}
						this.$$14577$41794 = this.$mItalus$41779.transform.eulerAngles;
						if (244507 - 207632 != 36875)
						{
							continue;
						}
						if (144421 - 302387 == -157965)
						{
							continue;
						}
						float num4 = this.$$14577$41794.y = this.$$14576$41793;
						if (85484 - 510175 == -424690 || 203018 - 279723 == -76704)
						{
							continue;
						}
						Vector3 vector2 = this.$mItalus$41779.transform.eulerAngles = this.$$14577$41794;
						if (41888 - 297294 != -255406)
						{
							continue;
						}
						if (50950 - 591381 != -540431)
						{
							continue;
						}
						goto IL_F4;
					}
					IL_471:
					if (this.$mStoryTimer$41785 > Time.time)
					{
						if (256953 - 578676 != -321723)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_464;
						}
						if (126389 - 343173 != -216784)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (197254 - 42258 != 154997)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$41784.newStoryMessage("ShadowGod", "Zera", Language.getMessage("M907_ZerasHiddenPlan", 122), eTalkType.enemy);
						if (52119 - 42464 != 9655)
						{
							continue;
						}
						this.$mStoryTimer$41785 = Time.time + 4f;
						if (107925 - 444956 != -337030)
						{
							goto Block_67;
						}
						continue;
					}
					IL_1DDB:
					if (this.$mStoryTimer$41785 > Time.time)
					{
						if (56 - 522344 != -522288)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1DCE;
						}
						if (39464 - 158428 != -118964)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (266990 - 400422 != -133431)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$41784.newStoryMessage("ShadowGod", "Zera", Language.getMessage("M907_ZerasHiddenPlan", 120), eTalkType.enemy);
						if (12083 - 185060 == -172976)
						{
							continue;
						}
						this.$mStoryTimer$41785 = Time.time + 4f;
						if (103707 - 106606 != -2898)
						{
							goto Block_120;
						}
						continue;
					}
					IL_137B:
					if (this.$mStoryTimer$41785 > Time.time)
					{
						if (238543 - 134313 != 104230)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_136E;
						}
						if (169409 - 112489 != 56920)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (153513 - 255788 != -102274)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$41784.newStoryMessage("ShadowGod", "Zera", Language.getMessage("M907_ZerasHiddenPlan", 114), eTalkType.enemy);
						if (265582 - 365572 != -99990)
						{
							continue;
						}
						this.$mStoryTimer$41785 = Time.time + 4f;
						if (202360 - 160771 != 41589)
						{
							continue;
						}
						goto IL_33E;
					}
					IL_18AC:
					if (Time.time >= Game.mStateTime + (float)2)
					{
						if (182433 - 532426 == -349992)
						{
							continue;
						}
						this.$self_$41795.SendMessage("blackOut");
						if (182254 - 243756 != -61501)
						{
							goto Block_108;
						}
						continue;
					}
					else
					{
						if (!this.$mGamePlayer$41775)
						{
							goto IL_18A0;
						}
						if (255927 - 373763 == -117835)
						{
							continue;
						}
						this.$mGamePlayer$41775.transform.Translate((float)0, (float)0, (float)5 * Time.deltaTime);
						if (27516 - 555368 != -527852)
						{
							continue;
						}
						this.$mGamePlayer$41775.animation.Play("run");
						if (241510 - 4628 != 236882)
						{
							continue;
						}
						goto IL_18A0;
					}
					IL_367:
					if (this.$mStoryTimer$41785 > Time.time)
					{
						if (86658 - 347879 == -261220)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_35A;
						}
						if (228072 - 69868 == 158205)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (61834 - 33456 != 28378)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$41784.newStoryMessage("ShadowGod", "Zera", Language.getMessage("M907_ZerasHiddenPlan", 115), eTalkType.enemy);
						if (35718 - 27686 == 8033)
						{
							continue;
						}
						this.$mStoryTimer$41785 = Time.time + 4f;
						if (111475 - 353465 != -241989)
						{
							goto Block_225;
						}
						continue;
					}
					IL_191E:
					if (this.$mStoryTimer$41785 > Time.time)
					{
						if (167872 - 534021 == -366148)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1911;
						}
						if (147812 - 567776 == -419963)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (133990 - 67587 != 66403)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$41784.newStoryMessage("Falcon", "Italus", Language.getMessage("M907_ZerasHiddenPlan", 112), eTalkType.friend);
						if (218817 - 294513 != -75696)
						{
							continue;
						}
						this.$self_$41795.f03ncNdtjek.alignToObject("EventCamera3");
						if (14596 - 293528 != -278932)
						{
							continue;
						}
						if (this.$mShadowGod$41776)
						{
							if (46195 - 336349 == -290153)
							{
								continue;
							}
							this.$mShadowGod$41776.animation.CrossFade("root", 1f);
							if (46342 - 216904 == -170561)
							{
								continue;
							}
						}
						this.$mStoryTimer$41785 = Time.time + 4f;
						if (50491 - 190540 != -140049)
						{
							continue;
						}
						goto IL_53D;
					}
					IL_4C4:
					if (this.$mStoryTimer$41785 > Time.time)
					{
						if (11321 - 366914 == -355592)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_4B7;
						}
						if (36910 - 224288 != -187378)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (131248 - 324412 != -193164)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$41784.newStoryMessage("ShadowGod", "Zera", Language.getMessage("M907_ZerasHiddenPlan", 124), eTalkType.enemy);
						if (180360 - 28052 == 152309)
						{
							continue;
						}
						this.$mStoryTimer$41785 = Time.time + 4f;
						if (289684 - 106040 != 183644)
						{
							continue;
						}
						goto IL_1FBF;
					}
					IL_2601:
					if (this.$mStoryTimer$41785 > Time.time)
					{
						if (126888 - 283867 == -156978)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_25F4;
						}
						if (57595 - 236973 != -179378)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (108171 - 158844 != -50673)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$41784.newStoryMessage("ShadowGod", "Zera", Language.getMessage("M907_ZerasHiddenPlan", 111), eTalkType.enemy);
						if (158276 - 395480 != -237204)
						{
							continue;
						}
						this.$mStoryTimer$41785 = Time.time + 4f;
						if (215893 - 154002 != 61891)
						{
							continue;
						}
						goto IL_18F5;
					}
					IL_566:
					if (this.$mStoryTimer$41785 > Time.time)
					{
						if (15797 - 353329 == -337531)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_559;
						}
						if (215684 - 253699 != -38015)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (81326 - 349418 != -268092)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$41784.newStoryMessage("Falcon", "Italus", Language.getMessage("M907_ZerasHiddenPlan", 113), eTalkType.friend);
						if (166057 - 584156 == -418098)
						{
							continue;
						}
						this.$mStoryTimer$41785 = Time.time + 4f;
						if (177861 - 310859 != -132998)
						{
							continue;
						}
						this.$self_$41795.MqNncBSJZRm = Time.time;
						if (191096 - 17291 != 173805)
						{
							continue;
						}
						goto IL_101;
					}
					IL_2065:
					if (this.$mStoryTimer$41785 > Time.time)
					{
						if (160543 - 86179 == 74365)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2058;
						}
						if (27197 - 242190 != -214993)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (195586 - 62279 != 133308)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$41784.close();
						if (228309 - 189336 != 38973)
						{
							continue;
						}
						if (this.$mItalus$41779)
						{
							if (61306 - 259886 != -198580)
							{
								continue;
							}
							if (this.$mEventPoint2$41782)
							{
								if (248251 - 230571 == 17681)
								{
									continue;
								}
								this.$mItalus$41779.transform.position = this.$mEventPoint2$41782.transform.position;
								if (117659 - 32721 == 84939)
								{
									continue;
								}
								this.$mItalus$41779.transform.rotation = this.$mEventPoint2$41782.transform.rotation;
								if (77509 - 71475 == 6035)
								{
									continue;
								}
								this.$mItalus$41779.animation.Play("run");
								if (263253 - 308482 != -45229)
								{
									continue;
								}
							}
						}
						this.$self_$41795.MqNncBSJZRm = Time.time;
						if (9501 - 479836 != -470334)
						{
							goto IL_D95;
						}
						continue;
					}
					IL_FD3:
					if (this.$mStoryTimer$41785 > Time.time)
					{
						if (89526 - 37889 == 51638)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_FC6;
						}
						if (31881 - 290804 != -258923)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (159978 - 130078 != 29901)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$41784.newStoryMessage("ShadowGod", "Zera", Language.getMessage("M907_ZerasHiddenPlan", 116), eTalkType.enemy);
						if (120655 - 565937 != -445282)
						{
							continue;
						}
						this.$mStoryTimer$41785 = Time.time + 4f;
						if (129894 - 388693 != -258799)
						{
							continue;
						}
						goto IL_9A9;
					}
					IL_1C62:
					if (this.$mStoryTimer$41785 > Time.time)
					{
						if (264836 - 574014 != -309178)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1C55;
						}
						if (9637 - 61545 != -51908)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (44659 - 538154 != -493495)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$41784.newStoryMessage("ShadowGod", "Zera", Language.getMessage("M907_ZerasHiddenPlan", 109), eTalkType.enemy);
						if (45264 - 526721 != -481457)
						{
							continue;
						}
						if (this.$mItalus$41779)
						{
							if (242969 - 545181 != -302212)
							{
								continue;
							}
							this.$mItalus$41779.animation.CrossFade("root");
							if (45671 - 157363 != -111692)
							{
								continue;
							}
						}
						this.$mStoryTimer$41785 = Time.time + 4f;
						if (120076 - 318963 != -198886)
						{
							goto Block_200;
						}
						continue;
					}
					IL_D95:
					if (Time.time >= this.$self_$41795.MqNncBSJZRm + (float)1)
					{
						if (126175 - 47219 != 78956)
						{
							continue;
						}
						if (this.$mItalus$41779)
						{
							if (40979 - 43868 == -2888)
							{
								continue;
							}
							this.$mItalus$41779.animation.CrossFade("talk");
							if (172158 - 266795 == -94636)
							{
								continue;
							}
						}
						this.$self_$41795.MqNncBSJZRm = Time.time;
						if (96847 - 313766 != -216919)
						{
							continue;
						}
						goto IL_1955;
					}
					else
					{
						if (!this.$mItalus$41779)
						{
							goto IL_D88;
						}
						if (256603 - 36550 != 220053)
						{
							continue;
						}
						if (!this.$mEventPoint2$41782)
						{
							goto IL_D88;
						}
						if (165196 - 545261 == -380064)
						{
							continue;
						}
						if (!this.$mEventPoint3$41783)
						{
							goto IL_D88;
						}
						if (288041 - 460681 == -172639)
						{
							continue;
						}
						this.$mItalus$41779.transform.position = Vector3.Slerp(this.$mEventPoint2$41782.transform.position, this.$mEventPoint3$41783.transform.position, Time.time - this.$self_$41795.MqNncBSJZRm);
						if (281917 - 210435 != 71483)
						{
							goto Block_230;
						}
						continue;
					}
					IL_9D2:
					if (this.$mStoryTimer$41785 > Time.time)
					{
						if (154218 - 194062 != -39844)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_9C5;
						}
						if (217723 - 579787 == -362063)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (47028 - 456521 != -409493)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$41784.newStoryMessage("Falcon", "Italus", Language.getMessage("M907_ZerasHiddenPlan", 117), eTalkType.friend);
						if (46071 - 9882 != 36190)
						{
							goto Block_265;
						}
						continue;
					}
					IL_255B:
					if (this.$mStoryTimer$41785 > Time.time)
					{
						if (249890 - 379723 == -129832)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_254E;
						}
						if (36169 - 78682 == -42512)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (128386 - 360316 != -231930)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$41784.newStoryMessage("ShadowGod", "Zera", Language.getMessage("M907_ZerasHiddenPlan", 107), eTalkType.enemy);
						if (115958 - 286514 == -170555)
						{
							continue;
						}
						this.$mStoryTimer$41785 = Time.time + 4f;
						if (260989 - 89373 != 171617)
						{
							goto Block_236;
						}
						continue;
					}
					IL_1244:
					if (this.$mStoryTimer$41785 > Time.time)
					{
						if (178851 - 31743 == 147109)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1238;
						}
						if (125136 - 15877 != 109259)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (299326 - 503883 != -204556)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$41784.newStoryMessage("Falcon", "Italus", Language.getMessage("M907_ZerasHiddenPlan", 104), eTalkType.friend);
						if (153872 - 62097 != 91775)
						{
							continue;
						}
						this.$mStoryTimer$41785 = Time.time + 4f;
						if (34964 - 565569 != -530604)
						{
							goto Block_79;
						}
						continue;
					}
					IL_25AE:
					if (this.$mStoryTimer$41785 > Time.time)
					{
						if (176349 - 341766 == -165416)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_25A1;
						}
						if (75916 - 126710 == -50793)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (7557 - 11477 != -3919)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$41784.blank();
						if (292439 - 247047 != 45392)
						{
							continue;
						}
						if (this.$self_$41795.shadowFadeFx)
						{
							if (48345 - 421166 == -372820)
							{
								continue;
							}
							this.$self_$41795.audio.PlayOneShot(this.$self_$41795.shadowFadeFx);
							if (127147 - 179823 != -52676)
							{
								continue;
							}
						}
						this.$mCameraEffect$41786 = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
						if (297237 - 255356 == 41882)
						{
							continue;
						}
						if (this.$mCameraEffect$41786)
						{
							if (153755 - 211102 != -57347)
							{
								continue;
							}
							this.$mCameraEffect$41786.AddColorRamp("reverseRamp", "none", (float)1, new Vector4((float)0, 0.1f, 0.1f, 0.3f));
							if (73821 - 71708 != 2113)
							{
								continue;
							}
						}
						this.$self_$41795.MqNncBSJZRm = Time.time;
						if (201158 - 239158 != -38000)
						{
							continue;
						}
						if (this.$mShadowGod$41776)
						{
							if (228126 - 204775 != 23351)
							{
								continue;
							}
							this.$mShadowGod$41776.transform.position = new Vector3((float)0, 50.5f, (float)24);
							if (266961 - 284689 == -17727)
							{
								continue;
							}
						}
						goto IL_2799;
					}
					IL_1FE8:
					if (this.$mStoryTimer$41785 > Time.time)
					{
						if (192390 - 451779 != -259389)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1FDB;
						}
						if (292726 - 149421 == 143306)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (185513 - 146743 != 38770)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$41784.close();
						if (52086 - 517284 != -465197)
						{
							goto Block_237;
						}
						continue;
					}
					IL_2799:
					if (Time.time >= this.$self_$41795.MqNncBSJZRm + (float)1)
					{
						if (138419 - 534461 == -396041)
						{
							continue;
						}
						this.$mStoryGui$41784.startStoryMessage("ShadowGod", "Zera", eTalkType.enemy);
						if (151414 - 13133 != 138281)
						{
							continue;
						}
						goto IL_1A13;
					}
					else
					{
						if (!this.$mShadowGodRenderer$41778)
						{
							goto IL_278C;
						}
						if (36351 - 321710 != -285359)
						{
							continue;
						}
						this.$$14574$41791 = Time.time - this.$self_$41795.MqNncBSJZRm;
						if (178581 - 408830 == -230248 || 173663 - 40731 == 132933)
						{
							continue;
						}
						Color color = this.$$14575$41792 = this.$mShadowGodRenderer$41778.materials[0].color;
						if (247408 - 481615 != -234207)
						{
							continue;
						}
						if (214739 - 366028 != -151289)
						{
							continue;
						}
						float num5 = this.$$14575$41792.a = this.$$14574$41791;
						if (107469 - 56298 != 51171)
						{
							continue;
						}
						if (51278 - 506591 != -455313)
						{
							continue;
						}
						Color color2 = this.$mShadowGodRenderer$41778.materials[0].color = this.$$14575$41792;
						if (128265 - 170022 != -41757)
						{
							continue;
						}
						if (154404 - 186094 != -31690)
						{
							continue;
						}
						goto IL_278C;
					}
					IL_2B77:
					if (this.$mStoryTimer$41785 > Time.time)
					{
						if (206295 - 42411 != 163884)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2B6A;
						}
						if (49020 - 505767 != -456747)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (63109 - 434737 != -371627)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$41784.newStoryMessage("ShadowGod", "Zera", Language.getMessage("M907_ZerasHiddenPlan", 121), eTalkType.enemy);
						if (86425 - 396424 == -309998)
						{
							continue;
						}
						this.$mStoryTimer$41785 = Time.time + 4f;
						if (264521 - 202464 != 62057)
						{
							continue;
						}
						goto IL_448;
					}
					IL_11FD:
					Game.mGameState = eGameState.AllHold;
					if (21090 - 407482 != -386392)
					{
						continue;
					}
					Game.mStateTime = Time.time;
					if (93513 - 390591 == -297077)
					{
						continue;
					}
					this.$mGamePlayer$41775 = Game.mPlayer;
					if (145483 - 189174 != -43691)
					{
						continue;
					}
					this.$mShadowGod$41776 = GameObject.Find("ShadowGod");
					if (296315 - 401287 != -104972)
					{
						continue;
					}
					this.$mShadowGodModel$41777 = null;
					if (3180 - 91532 == -88351)
					{
						continue;
					}
					this.$mShadowGodRenderer$41778 = null;
					if (7834 - 412947 == -405112)
					{
						continue;
					}
					if (this.$mShadowGod$41776)
					{
						if (102793 - 105429 != -2636)
						{
							continue;
						}
						this.$mShadowGodModel$41777 = this.$mShadowGod$41776.transform.Find("ShadowGod_tri").gameObject;
						if (147142 - 353681 == -206538)
						{
							continue;
						}
					}
					if (this.$mShadowGodModel$41777)
					{
						if (157328 - 312568 == -155239)
						{
							continue;
						}
						this.$mShadowGodRenderer$41778 = (SkinnedMeshRenderer)this.$mShadowGodModel$41777.GetComponent(typeof(SkinnedMeshRenderer));
						if (146746 - 593002 == -446255)
						{
							continue;
						}
					}
					this.$mItalus$41779 = GameObject.Find("Italus");
					if (4731 - 420735 != -416004)
					{
						continue;
					}
					this.$mShadowPortal$41780 = GameObject.Find("ShadowPortal");
					if (160828 - 452650 == -291821)
					{
						continue;
					}
					this.$mEventPoint1$41781 = GameObject.Find("EventPoint1");
					if (224499 - 511194 == -286694)
					{
						continue;
					}
					this.$mEventPoint2$41782 = GameObject.Find("EventPoint2");
					if (208769 - 356267 == -147497)
					{
						continue;
					}
					this.$mEventPoint3$41783 = GameObject.Find("EventPoint3");
					if (67601 - 435242 != -367641)
					{
						continue;
					}
					goto IL_18AC;
					IL_1CDA:
					if (this.$mStoryTimer$41785 > Time.time)
					{
						if (269628 - 135420 != 134208)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1CCD;
						}
						if (274660 - 392122 == -117461)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (112449 - 414007 != -301558)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$41784.newStoryMessage("ShadowGod", "Zera", Language.getMessage("M907_ZerasHiddenPlan", 110), eTalkType.enemy);
						if (237797 - 120274 == 117524)
						{
							continue;
						}
						if (this.$mShadowGod$41776)
						{
							if (162428 - 65938 != 96490)
							{
								continue;
							}
							this.$mShadowGod$41776.animation.CrossFade("talk", 1f);
							if (5979 - 205712 != -199733)
							{
								continue;
							}
						}
						this.$mStoryTimer$41785 = Time.time + 4f;
						if (231858 - 44234 != 187625)
						{
							goto Block_183;
						}
						continue;
					}
					IL_2BCA:
					if (this.$mStoryTimer$41785 > Time.time)
					{
						if (242754 - 376471 != -133717)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2BBD;
						}
						if (150776 - 286803 != -136027)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (110834 - 344472 != -233638)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$41784.newStoryMessage("Falcon", "Italus", Language.getMessage("M907_ZerasHiddenPlan", 108), eTalkType.friend);
						if (281874 - 36184 == 245691)
						{
							continue;
						}
						if (this.$mItalus$41779)
						{
							if (24357 - 389693 == -365335)
							{
								continue;
							}
							this.$mItalus$41779.animation.CrossFade("talk");
							if (267496 - 428427 == -160930)
							{
								continue;
							}
						}
						this.$mStoryTimer$41785 = Time.time + 4f;
						if (224365 - 167617 != 56749)
						{
							goto Block_180;
						}
						continue;
					}
					IL_1955:
					if (Time.time >= this.$self_$41795.MqNncBSJZRm + 0.25f)
					{
						if (97542 - 414018 != -316475)
						{
							goto Block_198;
						}
					}
					else
					{
						if (!this.$mItalus$41779)
						{
							goto IL_1948;
						}
						if (259444 - 397456 != -138011)
						{
							this.$$14572$41789 = Mathf.SmoothStep((float)90, (float)0, (float)4 * (Time.time - this.$self_$41795.MqNncBSJZRm));
							if (75016 - 434366 == -359350)
							{
								if (71959 - 229255 == -157296)
								{
									this.$$14573$41790 = this.$mItalus$41779.transform.eulerAngles;
									if (58030 - 114902 != -56871)
									{
										if (256515 - 481994 == -225479)
										{
											this.$$14573$41790.y = this.$$14572$41789;
											if (291208 - 17714 == 273494)
											{
												if (156232 - 315767 == -159535)
												{
													Vector3 vector3 = this.$mItalus$41779.transform.eulerAngles = this.$$14573$41790;
													if (245881 - 523071 == -277190)
													{
														if (170133 - 479033 == -308900)
														{
															goto IL_1948;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_2CAA;
				IL_F4:
				return this.YieldDefault(32);
				goto IL_2CAA;
				IL_33E:
				return this.Yield(34, new WaitForSeconds(0.5f));
				IL_35A:
				return this.YieldDefault(35);
				IL_391:
				goto IL_2CAA;
				IL_448:
				return this.Yield(47, new WaitForSeconds(0.5f));
				IL_464:
				return this.YieldDefault(48);
				IL_4B7:
				return this.YieldDefault(52);
				IL_53D:
				return this.Yield(30, new WaitForSeconds(0.5f));
				IL_559:
				return this.YieldDefault(31);
				goto IL_2CAA;
				IL_637:
				return this.Yield(41, new WaitForSeconds(0.5f));
				IL_653:
				return this.YieldDefault(42);
				Block_67:
				return this.Yield(49, new WaitForSeconds(0.5f));
				goto IL_2CAA;
				IL_9A9:
				return this.Yield(38, new WaitForSeconds(0.5f));
				IL_9C5:
				return this.YieldDefault(39);
				Block_79:
				return this.Yield(8, new WaitForSeconds(0.5f));
				goto IL_2CAA;
				IL_C31:
				return this.YieldDefault(50);
				Block_103:
				goto IL_2CAA;
				IL_D88:
				return this.YieldDefault(10);
				Block_108:
				return this.Yield(3, new WaitForSeconds(1f));
				goto IL_2CAA;
				IL_FC6:
				return this.YieldDefault(37);
				Block_120:
				return this.Yield(45, new WaitForSeconds(0.5f));
				IL_10D6:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_1198:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_133:
				goto IL_2CAA;
				IL_121D:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_1238:
				return this.YieldDefault(7);
				Block_144:
				goto IL_2CAA;
				IL_136E:
				return this.YieldDefault(33);
				IL_1659:
				goto IL_2CAA;
				IL_1688:
				return this.Yield(13, new WaitForSeconds(0.5f));
				Block_180:
				return this.Yield(22, new WaitForSeconds(0.5f));
				Block_183:
				return this.Yield(26, new WaitForSeconds(0.5f));
				goto IL_2CAA;
				IL_18A0:
				return this.YieldDefault(2);
				IL_18F5:
				return this.Yield(28, new WaitForSeconds(0.5f));
				IL_1911:
				return this.YieldDefault(29);
				IL_1948:
				return this.YieldDefault(11);
				Block_198:
				return this.Yield(12, new WaitForSeconds(0.5f));
				Block_200:
				return this.Yield(24, new WaitForSeconds(0.5f));
				IL_1A13:
				return this.Yield(17, new WaitForSeconds(0.5f));
				IL_1C55:
				return this.YieldDefault(23);
				IL_1CCD:
				return this.YieldDefault(25);
				Block_225:
				return this.Yield(36, new WaitForSeconds(0.5f));
				IL_1DB2:
				return this.Yield(43, new WaitForSeconds(0.5f));
				IL_1DCE:
				return this.YieldDefault(44);
				Block_230:
				goto IL_D88;
				Block_236:
				return this.Yield(20, new WaitForSeconds(0.5f));
				goto IL_2CAA;
				Block_237:
				return this.Yield(55, new WaitForSeconds(1f));
				IL_1FBF:
				return this.Yield(53, new WaitForSeconds(0.5f));
				IL_1FDB:
				return this.YieldDefault(54);
				Block_242:
				return this.Yield(51, new WaitForSeconds(0.5f));
				IL_2058:
				return this.YieldDefault(9);
				Block_250:
				goto IL_2CAA;
				Block_265:
				return this.Yield(40, new WaitForSeconds(2f));
				IL_2416:
				goto IL_2CAA;
				IL_254E:
				return this.YieldDefault(19);
				IL_2585:
				return this.Yield(14, new WaitForSeconds(0.5f));
				IL_25A1:
				return this.YieldDefault(15);
				IL_25F4:
				return this.YieldDefault(27);
				goto IL_2CAA;
				Block_293:
				return this.Yield(18, new WaitForSeconds(0.5f));
				IL_278C:
				return this.YieldDefault(16);
				IL_2A06:
				IL_2A7C:
				goto IL_2CAA;
				IL_2B6A:
				return this.YieldDefault(46);
				IL_2BBD:
				return this.YieldDefault(21);
				IL_2CAA:
				return false;
			}

			// Token: 0x060093AB RID: 37803 RVA: 0x011A4920 File Offset: 0x011A2B20
			internal static bool sA4mWXVliQTs0aecSS2F()
			{
				return true;
			}

			// Token: 0x060093AC RID: 37804 RVA: 0x011A4924 File Offset: 0x011A2B24
			internal static bool w2u4mwVlKVcLkZxZrxPw()
			{
				return false;
			}

			// Token: 0x04008AB1 RID: 35505
			internal GameObject $mGamePlayer$41775;

			// Token: 0x04008AB2 RID: 35506
			internal GameObject $mShadowGod$41776;

			// Token: 0x04008AB3 RID: 35507
			internal GameObject $mShadowGodModel$41777;

			// Token: 0x04008AB4 RID: 35508
			internal SkinnedMeshRenderer $mShadowGodRenderer$41778;

			// Token: 0x04008AB5 RID: 35509
			internal GameObject $mItalus$41779;

			// Token: 0x04008AB6 RID: 35510
			internal GameObject $mShadowPortal$41780;

			// Token: 0x04008AB7 RID: 35511
			internal GameObject $mEventPoint1$41781;

			// Token: 0x04008AB8 RID: 35512
			internal GameObject $mEventPoint2$41782;

			// Token: 0x04008AB9 RID: 35513
			internal GameObject $mEventPoint3$41783;

			// Token: 0x04008ABA RID: 35514
			internal StoryGui $mStoryGui$41784;

			// Token: 0x04008ABB RID: 35515
			internal float $mStoryTimer$41785;

			// Token: 0x04008ABC RID: 35516
			internal CameraEffect $mCameraEffect$41786;

			// Token: 0x04008ABD RID: 35517
			internal int $$14570$41787;

			// Token: 0x04008ABE RID: 35518
			internal Vector3 $$14571$41788;

			// Token: 0x04008ABF RID: 35519
			internal float $$14572$41789;

			// Token: 0x04008AC0 RID: 35520
			internal Vector3 $$14573$41790;

			// Token: 0x04008AC1 RID: 35521
			internal float $$14574$41791;

			// Token: 0x04008AC2 RID: 35522
			internal Color $$14575$41792;

			// Token: 0x04008AC3 RID: 35523
			internal float $$14576$41793;

			// Token: 0x04008AC4 RID: 35524
			internal Vector3 $$14577$41794;

			// Token: 0x04008AC5 RID: 35525
			internal M907_ZerasHiddenPlan $self_$41795;
		}
	}

	// Token: 0x020018C8 RID: 6344
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$41797 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060093AD RID: 37805 RVA: 0x011A4928 File Offset: 0x011A2B28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$41797(M907_ZerasHiddenPlan self_)
		{
			if (13362 - 48749 != -35386)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (234998 - 586234 == -351236)
				{
					base..ctor();
					if (244264 - 207493 == 36771)
					{
						this.$self_$41805 = self_;
						if (276144 - 434688 == -158544)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060093AE RID: 37806 RVA: 0x011A49C0 File Offset: 0x011A2BC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M907_ZerasHiddenPlan.$StartGame$41797.$(this.$self_$41805);
		}

		// Token: 0x060093AF RID: 37807 RVA: 0x011A49D0 File Offset: 0x011A2BD0
		internal static bool nKmdXWVldQ3LnKfxwZUb()
		{
			return true;
		}

		// Token: 0x060093B0 RID: 37808 RVA: 0x011A49D4 File Offset: 0x011A2BD4
		internal static bool EW5ASRVlJvJEmC5bUw5w()
		{
			return false;
		}

		// Token: 0x04008AC6 RID: 35526
		internal M907_ZerasHiddenPlan $self_$41805;

		// Token: 0x020018C9 RID: 6345
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060093B1 RID: 37809 RVA: 0x011A49D8 File Offset: 0x011A2BD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M907_ZerasHiddenPlan self_)
			{
				if (164950 - 238204 != -73253)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (154533 - 4077 == 150456)
					{
						base..ctor();
						if (160821 - 585748 != -424926)
						{
							this.$self_$41804 = self_;
							if (242528 - 359230 != -116701)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060093B2 RID: 37810 RVA: 0x011A4A70 File Offset: 0x011A2C70
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (140983 - 175909 != -34925)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6E6;
					case 2:
						this.$mStoryGui$41801 = (StoryGui)this.$self_$41804.GetComponent(typeof(StoryGui));
						if (54121 - 420762 == -366640)
						{
							continue;
						}
						this.$mStoryTimer$41802 = 0f;
						if (274060 - 449181 == -175120)
						{
							continue;
						}
						this.$mStoryGui$41801.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
						if (238522 - 468837 != -230314)
						{
							goto Block_24;
						}
						continue;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (150646 - 64830 != 85817)
							{
								goto Block_45;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$41801.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M907_ZerasHiddenPlan", 101), eTalkType.friend);
							if (72203 - 503457 != -431254)
							{
								continue;
							}
							this.$mStoryTimer$41802 = Time.time + 4f;
							if (123621 - 442244 != -318623)
							{
								continue;
							}
							goto IL_395;
						}
						break;
					case 4:
						goto IL_3BC;
					case 5:
						goto IL_3BC;
					case 6:
						goto IL_431;
					case 7:
						goto IL_431;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (223406 - 50645 != 172762)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (142224 - 507586 == -365361)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (298487 - 255492 == 42996)
							{
								continue;
							}
							this.$self_$41804.f03ncNdtjek.enabled = false;
							if (106198 - 21503 == 84696)
							{
								continue;
							}
							this.$self_$41804.f03ncNdtjek.specialTarget = null;
							if (45596 - 315794 == -270197)
							{
								continue;
							}
							this.YieldDefault(1);
							if (213836 - 505637 != -291801)
							{
								continue;
							}
							goto IL_6E6;
						}
						break;
					default:
						if (272455 - 530748 != -258293)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (236201 - 502710 != -266509)
					{
						continue;
					}
					Game.mGameState = eGameState.Start;
					if (114512 - 522545 != -408033)
					{
						continue;
					}
					Game.mStateTime = Time.time;
					if (159631 - 199003 != -39372)
					{
						continue;
					}
					this.$mPlayer$41798 = Game.mPlayer;
					if (90448 - 10288 == 80161)
					{
						continue;
					}
					this.$mShadowGod$41799 = GameObject.Find("ShadowGod");
					if (14968 - 128589 == -113620)
					{
						continue;
					}
					this.$mItalus$41800 = GameObject.Find("Italus");
					if (299451 - 519725 == -220273)
					{
						continue;
					}
					if (this.$mShadowGod$41799)
					{
						if (188264 - 71828 == 116437)
						{
							continue;
						}
						this.$mShadowGod$41799.transform.position = Vector3.zero;
						if (192521 - 145257 == 47265)
						{
							continue;
						}
					}
					if (this.$mItalus$41800)
					{
						if (21456 - 565106 == -543649)
						{
							continue;
						}
						this.$mItalus$41800.transform.position = Vector3.zero;
						if (223929 - 504792 == -280862)
						{
							continue;
						}
					}
					this.$self_$41804.SendMessage("fadeIn");
					if (220917 - 420163 != -199246)
					{
						continue;
					}
					goto IL_20B;
					IL_431:
					if (this.$mStoryTimer$41802 > Time.time)
					{
						if (156807 - 239413 != -82606)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_425;
						}
						if (141034 - 310074 != -169040)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (64840 - 309671 != -244831)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$41801.close();
						if (282587 - 232334 == 50254)
						{
							continue;
						}
						this.$mEventCamera1$41803 = GameObject.Find("EventCamera1");
						if (196664 - 279914 != -83250)
						{
							continue;
						}
						if (!this.$mEventCamera1$41803)
						{
							goto IL_1AC;
						}
						if (98538 - 231080 == -132541)
						{
							continue;
						}
						this.$self_$41804.f03ncNdtjek.setSpecialTarget(this.$mEventCamera1$41803, 1f);
						if (41679 - 466574 != -424894)
						{
							goto Block_22;
						}
						continue;
					}
					IL_3BC:
					if (this.$mStoryTimer$41802 > Time.time)
					{
						if (228351 - 152277 == 76075)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_3B0;
						}
						if (200402 - 319183 == -118780)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (149469 - 454113 != -304643)
						{
							break;
						}
					}
					else
					{
						this.$mStoryGui$41801.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M907_ZerasHiddenPlan", 102), eTalkType.friend);
						if (136641 - 251923 != -115281)
						{
							this.$mStoryTimer$41802 = Time.time + 4f;
							if (239675 - 280608 == -40933)
							{
								goto IL_40A;
							}
						}
					}
				}
				goto IL_6E6;
				IL_1AC:
				return this.Yield(8, new WaitForSeconds(1f));
				Block_16:
				goto IL_6E6;
				IL_20B:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_22:
				goto IL_1AC;
				goto IL_6E6;
				Block_24:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_395:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_3B0:
				return this.YieldDefault(5);
				IL_40A:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_425:
				return this.YieldDefault(7);
				Block_45:
				IL_6E6:
				return false;
			}

			// Token: 0x060093B3 RID: 37811 RVA: 0x011A5178 File Offset: 0x011A3378
			internal static bool Ed25I9VlD4nm8dASsuwM()
			{
				return true;
			}

			// Token: 0x060093B4 RID: 37812 RVA: 0x011A517C File Offset: 0x011A337C
			internal static bool euuSZmVlvKYqeehAo5kA()
			{
				return false;
			}

			// Token: 0x04008AC7 RID: 35527
			internal GameObject $mPlayer$41798;

			// Token: 0x04008AC8 RID: 35528
			internal GameObject $mShadowGod$41799;

			// Token: 0x04008AC9 RID: 35529
			internal GameObject $mItalus$41800;

			// Token: 0x04008ACA RID: 35530
			internal StoryGui $mStoryGui$41801;

			// Token: 0x04008ACB RID: 35531
			internal float $mStoryTimer$41802;

			// Token: 0x04008ACC RID: 35532
			internal GameObject $mEventCamera1$41803;

			// Token: 0x04008ACD RID: 35533
			internal M907_ZerasHiddenPlan $self_$41804;
		}
	}

	// Token: 0x020018CA RID: 6346
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$41806 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060093B5 RID: 37813 RVA: 0x011A5180 File Offset: 0x011A3380
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$41806(M907_ZerasHiddenPlan self_)
		{
			if (83316 - 379563 != -296246)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (24364 - 347053 == -322689)
				{
					base..ctor();
					if (10620 - 183163 == -172543)
					{
						this.$self_$41811 = self_;
						if (109359 - 103087 != 6273)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060093B6 RID: 37814 RVA: 0x011A5218 File Offset: 0x011A3418
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M907_ZerasHiddenPlan.$onDeadPlayer$41806.$(this.$self_$41811);
		}

		// Token: 0x060093B7 RID: 37815 RVA: 0x011A5228 File Offset: 0x011A3428
		internal static bool rHQPPbVlRfekarAK1E8N()
		{
			return true;
		}

		// Token: 0x060093B8 RID: 37816 RVA: 0x011A522C File Offset: 0x011A342C
		internal static bool gNtp67VlwdKjwNmPAVxx()
		{
			return false;
		}

		// Token: 0x04008ACE RID: 35534
		internal M907_ZerasHiddenPlan $self_$41811;

		// Token: 0x020018CB RID: 6347
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060093B9 RID: 37817 RVA: 0x011A5230 File Offset: 0x011A3430
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M907_ZerasHiddenPlan self_)
			{
				if (283016 - 360785 != -77769)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (66721 - 465455 != -398733)
					{
						base..ctor();
						if (7849 - 158469 != -150619)
						{
							this.$self_$41810 = self_;
							if (149002 - 561666 != -412663)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060093BA RID: 37818 RVA: 0x011A52C8 File Offset: 0x011A34C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (93914 - 70540 != 23375)
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
							if (260492 - 594799 == -334306)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_205;
							}
							if (53693 - 434278 != -380585)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (283014 - 202665 == 80350)
						{
							continue;
						}
						this.$mStoryGui$41807 = (StoryGui)this.$self_$41810.GetComponent(typeof(StoryGui));
						if (121972 - 343455 != -221483)
						{
							continue;
						}
						if (this.$mStoryGui$41807)
						{
							if (253039 - 49901 == 203139)
							{
								continue;
							}
							this.$mStoryGui$41807.close();
							if (267813 - 207620 != 60193)
							{
								continue;
							}
						}
						this.$mChangeGui$41808 = (ChangeGui)this.$self_$41810.GetComponent(typeof(ChangeGui));
						if (140320 - 505553 == -365232)
						{
							continue;
						}
						if (this.$mChangeGui$41808)
						{
							if (294917 - 242418 == 52500)
							{
								continue;
							}
							this.$mChangeGui$41808.close();
							if (161742 - 145026 == 16717)
							{
								continue;
							}
						}
						this.$mGameGui$41809 = (GameGui)this.$self_$41810.GetComponent(typeof(GameGui));
						if (253655 - 288173 == -34517)
						{
							continue;
						}
						if (this.$mGameGui$41809)
						{
							if (130356 - 97691 == 32666)
							{
								continue;
							}
							if (!this.$mGameGui$41809.enabled)
							{
								if (281202 - 242485 != 38717)
								{
									continue;
								}
								this.$mGameGui$41809.enabled = true;
								if (18099 - 182035 == -163935)
								{
									continue;
								}
							}
							this.$mGameGui$41809.openDeadMenu();
							if (75647 - 450110 != -374463)
							{
								continue;
							}
						}
						IL_205:
						this.YieldDefault(1);
						if (18702 - 85774 != -67072)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (7165 - 170717 != -163552)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (108324 - 416781 != -308457);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x060093BB RID: 37819 RVA: 0x011A55E0 File Offset: 0x011A37E0
			internal static bool hCVRIvVlqwLt94JOEfky()
			{
				return true;
			}

			// Token: 0x060093BC RID: 37820 RVA: 0x011A55E4 File Offset: 0x011A37E4
			internal static bool PyympAVl7fTdLIj4x6g2()
			{
				return false;
			}

			// Token: 0x04008ACF RID: 35535
			internal StoryGui $mStoryGui$41807;

			// Token: 0x04008AD0 RID: 35536
			internal ChangeGui $mChangeGui$41808;

			// Token: 0x04008AD1 RID: 35537
			internal GameGui $mGameGui$41809;

			// Token: 0x04008AD2 RID: 35538
			internal M907_ZerasHiddenPlan $self_$41810;
		}
	}

	// Token: 0x020018CC RID: 6348
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$41812 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060093BD RID: 37821 RVA: 0x011A55E8 File Offset: 0x011A37E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$41812(Hashtable data, M907_ZerasHiddenPlan self_)
		{
			if (176349 - 256848 != -80498)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (170887 - 539445 != -368557)
				{
					base..ctor();
					if (46934 - 111794 != -64859)
					{
						this.$data$41817 = data;
						if (149433 - 149621 == -188)
						{
							this.$self_$41818 = self_;
							if (274911 - 423562 == -148651)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060093BE RID: 37822 RVA: 0x011A56A4 File Offset: 0x011A38A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M907_ZerasHiddenPlan.$onChangePlayer$41812.$(this.$data$41817, this.$self_$41818);
		}

		// Token: 0x060093BF RID: 37823 RVA: 0x011A56B8 File Offset: 0x011A38B8
		internal static bool flOYbxVlP0BxxPloiXKs()
		{
			return true;
		}

		// Token: 0x060093C0 RID: 37824 RVA: 0x011A56BC File Offset: 0x011A38BC
		internal static bool uIH45QVl0v9FN7yXe2uK()
		{
			return false;
		}

		// Token: 0x04008AD3 RID: 35539
		internal Hashtable $data$41817;

		// Token: 0x04008AD4 RID: 35540
		internal M907_ZerasHiddenPlan $self_$41818;

		// Token: 0x020018CD RID: 6349
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060093C1 RID: 37825 RVA: 0x011A56C0 File Offset: 0x011A38C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M907_ZerasHiddenPlan self_)
			{
				if (30479 - 448157 != -417677)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (247748 - 514283 != -266534)
					{
						base..ctor();
						if (87791 - 494932 == -407141)
						{
							this.$data$41815 = data;
							if (120764 - 297002 != -176237)
							{
								this.$self_$41816 = self_;
								if (85241 - 160894 == -75653)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060093C2 RID: 37826 RVA: 0x011A577C File Offset: 0x011A397C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (65315 - 590546 != -525230)
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
							if (293526 - 597464 == -303937)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (167653 - 432849 == -265195)
							{
								continue;
							}
							this.$mGameGui$41814 = (GameGui)this.$self_$41816.GetComponent(typeof(GameGui));
							if (244834 - 520138 == -275303)
							{
								continue;
							}
							this.$mGameGui$41814.enabled = true;
							if (183447 - 101291 == 82157)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (221694 - 273929 != -52235)
						{
							continue;
						}
						goto IL_205;
					default:
						if (240664 - 60605 == 180060)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (74280 - 69480 != 4801)
					{
						this.$self_$41816.SendMessage("onCreatePlayer", this.$data$41815);
						if (217154 - 340290 == -123136)
						{
							this.$mChangeGui$41813 = (ChangeGui)this.$self_$41816.GetComponent(typeof(ChangeGui));
							if (287442 - 145193 == 142249)
							{
								if (!this.$mChangeGui$41813.enabled)
								{
									break;
								}
								if (96603 - 527974 != -431370)
								{
									this.$mChangeGui$41813.close();
									if (192719 - 331094 != -138374)
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

			// Token: 0x060093C3 RID: 37827 RVA: 0x011A59A0 File Offset: 0x011A3BA0
			internal static bool TkRoTHVlbhNX6SHg3xgM()
			{
				return true;
			}

			// Token: 0x060093C4 RID: 37828 RVA: 0x011A59A4 File Offset: 0x011A3BA4
			internal static bool LTpwYaVlubtiSBSRPiBq()
			{
				return false;
			}

			// Token: 0x04008AD5 RID: 35541
			internal ChangeGui $mChangeGui$41813;

			// Token: 0x04008AD6 RID: 35542
			internal GameGui $mGameGui$41814;

			// Token: 0x04008AD7 RID: 35543
			internal Hashtable $data$41815;

			// Token: 0x04008AD8 RID: 35544
			internal M907_ZerasHiddenPlan $self_$41816;
		}
	}

	// Token: 0x020018CE RID: 6350
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$41819 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060093C5 RID: 37829 RVA: 0x011A59A8 File Offset: 0x011A3BA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$41819(M907_ZerasHiddenPlan self_)
		{
			if (76996 - 31477 != 45519)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (257394 - 138034 != 119361)
				{
					base..ctor();
					if (187807 - 224775 != -36967)
					{
						this.$self_$41823 = self_;
						if (67772 - 304218 != -236445)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060093C6 RID: 37830 RVA: 0x011A5A40 File Offset: 0x011A3C40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M907_ZerasHiddenPlan.$ReturnToTown$41819.$(this.$self_$41823);
		}

		// Token: 0x060093C7 RID: 37831 RVA: 0x011A5A50 File Offset: 0x011A3C50
		internal static bool xZ4kdYVlIK6HuCVWibbg()
		{
			return true;
		}

		// Token: 0x060093C8 RID: 37832 RVA: 0x011A5A54 File Offset: 0x011A3C54
		internal static bool TXcTMcVlBCYPvLswUyHS()
		{
			return false;
		}

		// Token: 0x04008AD9 RID: 35545
		internal M907_ZerasHiddenPlan $self_$41823;

		// Token: 0x020018CF RID: 6351
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060093C9 RID: 37833 RVA: 0x011A5A58 File Offset: 0x011A3C58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M907_ZerasHiddenPlan self_)
			{
				if (35953 - 277258 != -241305)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (1862 - 261886 != -260023)
					{
						base..ctor();
						if (74817 - 320325 != -245507)
						{
							this.$self_$41822 = self_;
							if (131509 - 332835 != -201325)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060093CA RID: 37834 RVA: 0x011A5AF0 File Offset: 0x011A3CF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (75997 - 38725 != 37273)
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
						this.$self_$41822.LeaveGame();
						if (151949 - 82273 == 69677)
						{
							continue;
						}
						this.YieldDefault(1);
						if (148410 - 416033 != -267622)
						{
							goto Block_2;
						}
						continue;
					default:
						if (94072 - 521742 == -427669)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (1273 - 229857 == -228584)
					{
						Game.mStateTime = Time.time;
						if (83490 - 576548 != -493057)
						{
							this.$$switch$7538$41820 = PlayerData.SaveGuild;
							if (59175 - 307529 != -248353)
							{
								if (this.$$switch$7538$41820 == 1)
								{
									if (179770 - 195392 != -15622)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (93273 - 555287 == -462013)
									{
										continue;
									}
								}
								else if (this.$$switch$7538$41820 == 2)
								{
									if (646 - 563920 == -563273)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (232 - 245942 == -245709)
									{
										continue;
									}
								}
								else if (this.$$switch$7538$41820 == 3)
								{
									if (191160 - 122162 == 68999)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (62322 - 251276 == -188953)
									{
										continue;
									}
								}
								else if (this.$$switch$7538$41820 == 4)
								{
									if (131798 - 113872 != 17926)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (18876 - 522626 != -503750)
									{
										continue;
									}
								}
								else if (this.$$switch$7538$41820 == 5)
								{
									if (181795 - 206247 == -24451)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (128670 - 581367 == -452696)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (160405 - 303781 == -143375)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (115191 - 530266 == -415074)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (269870 - 514662 != -244792)
									{
										continue;
									}
								}
								this.$mGameGui$41821 = (GameGui)this.$self_$41822.GetComponent(typeof(GameGui));
								if (119699 - 489078 == -369379)
								{
									if (this.$mGameGui$41821)
									{
										if (14163 - 178897 != -164734)
										{
											continue;
										}
										this.$mGameGui$41821.close();
										if (149389 - 456911 != -307522)
										{
											continue;
										}
									}
									this.$self_$41822.SendMessage("fadeOut");
									if (237364 - 229149 != 8216)
									{
										goto Block_27;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_3AD;
				Block_27:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x060093CB RID: 37835 RVA: 0x011A5EBC File Offset: 0x011A40BC
			internal static bool AKFvgvVleu1pAd6oMOXQ()
			{
				return true;
			}

			// Token: 0x060093CC RID: 37836 RVA: 0x011A5EC0 File Offset: 0x011A40C0
			internal static bool XNMAKCVlr1QeORhqQQ2s()
			{
				return false;
			}

			// Token: 0x04008ADA RID: 35546
			internal int $$switch$7538$41820;

			// Token: 0x04008ADB RID: 35547
			internal GameGui $mGameGui$41821;

			// Token: 0x04008ADC RID: 35548
			internal M907_ZerasHiddenPlan $self_$41822;
		}
	}

	// Token: 0x020018D0 RID: 6352
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$41824 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060093CD RID: 37837 RVA: 0x011A5EC4 File Offset: 0x011A40C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$41824(M907_ZerasHiddenPlan self_)
		{
			if (72775 - 563569 != -490794)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (132506 - 374959 != -242452)
				{
					base..ctor();
					if (73565 - 518731 == -445166)
					{
						this.$self_$41827 = self_;
						if (293006 - 564124 == -271118)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060093CE RID: 37838 RVA: 0x011A5F5C File Offset: 0x011A415C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M907_ZerasHiddenPlan.$ReturnToGuild$41824.$(this.$self_$41827);
		}

		// Token: 0x060093CF RID: 37839 RVA: 0x011A5F6C File Offset: 0x011A416C
		internal static bool dgryZdVlj4oPIIieGp5E()
		{
			return true;
		}

		// Token: 0x060093D0 RID: 37840 RVA: 0x011A5F70 File Offset: 0x011A4170
		internal static bool icKMorVlhNwhXvCWEqZ7()
		{
			return false;
		}

		// Token: 0x04008ADD RID: 35549
		internal M907_ZerasHiddenPlan $self_$41827;

		// Token: 0x020018D1 RID: 6353
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060093D1 RID: 37841 RVA: 0x011A5F74 File Offset: 0x011A4174
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M907_ZerasHiddenPlan self_)
			{
				if (114607 - 122364 != -7757)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (205577 - 405333 != -199755)
					{
						base..ctor();
						if (191156 - 234826 != -43669)
						{
							this.$self_$41826 = self_;
							if (117002 - 122471 != -5468)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060093D2 RID: 37842 RVA: 0x011A600C File Offset: 0x011A420C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (280169 - 367597 != -87427)
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
						this.$self_$41826.LeaveGame();
						if (121579 - 67937 == 53643)
						{
							continue;
						}
						this.YieldDefault(1);
						if (116196 - 598811 != -482615)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (177756 - 542714 == -364957)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (158893 - 251048 == -92155)
					{
						Game.mStateTime = Time.time;
						if (18825 - 82963 == -64138)
						{
							Game.mNextGameCode = 31;
							if (252557 - 161304 == 91253)
							{
								this.$mGameGui$41825 = (GameGui)this.$self_$41826.GetComponent(typeof(GameGui));
								if (74972 - 472539 != -397566)
								{
									if (this.$mGameGui$41825)
									{
										if (260535 - 111396 == 149140)
										{
											continue;
										}
										this.$mGameGui$41825.close();
										if (19387 - 208576 == -189188)
										{
											continue;
										}
									}
									this.$self_$41826.SendMessage("fadeOut");
									if (205053 - 536166 != -331112)
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

			// Token: 0x060093D3 RID: 37843 RVA: 0x011A61E8 File Offset: 0x011A43E8
			internal static bool wmi4cPVlsdIbKTnRQHLc()
			{
				return true;
			}

			// Token: 0x060093D4 RID: 37844 RVA: 0x011A61EC File Offset: 0x011A43EC
			internal static bool pHBOyWVl9yuEZ761wtkn()
			{
				return false;
			}

			// Token: 0x04008ADE RID: 35550
			internal GameGui $mGameGui$41825;

			// Token: 0x04008ADF RID: 35551
			internal M907_ZerasHiddenPlan $self_$41826;
		}
	}

	// Token: 0x020018D2 RID: 6354
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$41828 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060093D5 RID: 37845 RVA: 0x011A61F0 File Offset: 0x011A43F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$41828(M907_ZerasHiddenPlan self_)
		{
			if (298935 - 514974 != -216038)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (60192 - 263159 != -202966)
				{
					base..ctor();
					if (269694 - 143444 != 126251)
					{
						this.$self_$41832 = self_;
						if (169456 - 248727 != -79270)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060093D6 RID: 37846 RVA: 0x011A6288 File Offset: 0x011A4488
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M907_ZerasHiddenPlan.$ReturnToCamp$41828.$(this.$self_$41832);
		}

		// Token: 0x060093D7 RID: 37847 RVA: 0x011A6298 File Offset: 0x011A4498
		internal static bool Jv6XsDVl1oEQfK6eUaO1()
		{
			return true;
		}

		// Token: 0x060093D8 RID: 37848 RVA: 0x011A629C File Offset: 0x011A449C
		internal static bool y0fWNDVl4JrV9tlnKLn2()
		{
			return false;
		}

		// Token: 0x04008AE0 RID: 35552
		internal M907_ZerasHiddenPlan $self_$41832;

		// Token: 0x020018D3 RID: 6355
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060093D9 RID: 37849 RVA: 0x011A62A0 File Offset: 0x011A44A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M907_ZerasHiddenPlan self_)
			{
				if (28317 - 357858 != -329540)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (101851 - 71955 != 29897)
					{
						base..ctor();
						if (184688 - 311534 == -126846)
						{
							this.$self_$41831 = self_;
							if (171633 - 455416 != -283782)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060093DA RID: 37850 RVA: 0x011A6338 File Offset: 0x011A4538
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (28270 - 180451 != -152181)
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
						this.$self_$41831.LeaveGame();
						if (208096 - 145156 == 62941)
						{
							continue;
						}
						this.YieldDefault(1);
						if (131282 - 212578 != -81296)
						{
							continue;
						}
						goto IL_363;
					default:
						if (278595 - 23648 != 254947)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (134048 - 299231 == -165183)
					{
						Game.mStateTime = Time.time;
						if (268622 - 332444 == -63822)
						{
							this.$$switch$7540$41829 = PlayerData.SaveGuild;
							if (79904 - 248792 == -168888)
							{
								if (this.$$switch$7540$41829 == 1)
								{
									if (11096 - 128719 == -117622)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (102309 - 370807 == -268497)
									{
										continue;
									}
								}
								else if (this.$$switch$7540$41829 == 2)
								{
									if (64185 - 35061 != 29124)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (122308 - 274760 == -152451)
									{
										continue;
									}
								}
								else if (this.$$switch$7540$41829 == 3)
								{
									if (243682 - 194816 != 48866)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (8792 - 151194 != -142402)
									{
										continue;
									}
								}
								else if (this.$$switch$7540$41829 == 4)
								{
									if (189329 - 383602 != -194273)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (228691 - 72096 != 156595)
									{
										continue;
									}
								}
								else if (this.$$switch$7540$41829 == 5)
								{
									if (79666 - 418379 != -338713)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (278045 - 274033 != 4012)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (184958 - 260637 != -75679)
									{
										continue;
									}
								}
								this.$mGameGui$41830 = (GameGui)this.$self_$41831.GetComponent(typeof(GameGui));
								if (167989 - 427424 != -259434)
								{
									if (this.$mGameGui$41830)
									{
										if (49875 - 248804 == -198928)
										{
											continue;
										}
										this.$mGameGui$41830.close();
										if (264787 - 416833 == -152045)
										{
											continue;
										}
									}
									this.$self_$41831.SendMessage("fadeOut");
									if (19718 - 256279 == -236561)
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

			// Token: 0x060093DB RID: 37851 RVA: 0x011A66BC File Offset: 0x011A48BC
			internal static bool lAfD1QVlzVLRLWYplby7()
			{
				return true;
			}

			// Token: 0x060093DC RID: 37852 RVA: 0x011A66C0 File Offset: 0x011A48C0
			internal static bool zGfygpVyan8EvmP0vLOd()
			{
				return false;
			}

			// Token: 0x04008AE1 RID: 35553
			internal int $$switch$7540$41829;

			// Token: 0x04008AE2 RID: 35554
			internal GameGui $mGameGui$41830;

			// Token: 0x04008AE3 RID: 35555
			internal M907_ZerasHiddenPlan $self_$41831;
		}
	}
}
