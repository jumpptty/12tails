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

// Token: 0x02001605 RID: 5637
[Serializable]
public class M507_AnemoneDecision : MonoBehaviour
{
	// Token: 0x060082CD RID: 33485 RVA: 0x0108CF00 File Offset: 0x0108B100
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M507_AnemoneDecision()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060082CE RID: 33486 RVA: 0x0108CF10 File Offset: 0x0108B110
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (47855 - 170909 != -123054)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (268762 - 292384 != -23621)
			{
				Game.mGameType = 4;
				if (23012 - 128453 != -105440)
				{
					if (Chat.Initialized)
					{
						if (29202 - 40653 == -11450)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (256368 - 360620 == -104251)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (79790 - 440542 == -360751)
						{
							continue;
						}
					}
					this.hjtc9WytIu6 = (Texture)Resources.Load("GameGui/Title/chapterComplete", typeof(Texture));
					if (34730 - 549688 == -514958)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060082CF RID: 33487 RVA: 0x0108D030 File Offset: 0x0108B230
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (263036 - 344718 != -81682)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (65084 - 294741 != -229656)
				{
					if (Game.mNextGameCode != 507)
					{
						break;
					}
					if (268862 - 369022 != -100159)
					{
						Game.nextGame();
						if (34125 - 352251 == -318126)
						{
							Game.mGameCode = 507;
							if (164143 - 240254 == -76111)
							{
								Game.mGameType = 4;
								if (290356 - 580466 == -290110)
								{
									Game.mGameTime = Time.time;
									if (248317 - 35103 == 213214)
									{
										Game.mGameScore = 0;
										if (4325 - 593280 == -588955)
										{
											Game.mGameMana = 0;
											if (237512 - 183250 != 54263)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (153882 - 85174 == 68708)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (139234 - 275154 != -135919)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (271794 - 42142 == 229652)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (264461 - 271438 != -6976)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (4105 - 300154 == -296049)
																{
																	this.LVgc9AcqlTd = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (270485 - 532613 != -262127)
																	{
																		this.LVgc9AcqlTd.enabled = false;
																		if (32689 - 296612 == -263923)
																		{
																			this.Srvc9FG5bd5 = PhotonClient.Connection;
																			if (290956 - 477374 != -186417)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (187060 - 86559 == 100501)
																				{
																					this.InitGame();
																					if (105619 - 136611 == -30992)
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
				if (21224 - 186911 != -165686)
				{
					Game.mGameType = 99;
					if (29203 - 558807 != -529603)
					{
						this.LVgc9AcqlTd = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
						if (201997 - 545237 != -343239)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060082D0 RID: 33488 RVA: 0x0108D38C File Offset: 0x0108B58C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (161190 - 458317 != -297126)
		{
		}
		for (;;)
		{
			if (this.Srvc9FG5bd5 == null)
			{
				if (81536 - 395785 == -314249)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (51395 - 563348 != -511952)
				{
					if (mGameState == eGameState.Init)
					{
						if (198367 - 209809 == -11442)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (29853 - 301754 != -271900)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (172935 - 165493 == 7442)
						{
							break;
						}
					}
					else
					{
						if (mGameState != eGameState.Ready)
						{
							if (mGameState == eGameState.Start)
							{
								if (135553 - 510284 == -374730)
								{
									continue;
								}
							}
							else if (mGameState == eGameState.Normal)
							{
								if (298381 - 556252 != -257871)
								{
									continue;
								}
							}
							else if (mGameState == eGameState.Hold)
							{
								if (106146 - 205039 != -98893)
								{
									continue;
								}
							}
							else if (mGameState == eGameState.AllHold)
							{
								if (78964 - 473127 != -394162)
								{
									break;
								}
								continue;
							}
							else
							{
								if (mGameState != eGameState.Ended)
								{
									break;
								}
								if (278429 - 446847 != -168418)
								{
									continue;
								}
								break;
							}
							IL_126:
							if (Game.music != 0)
							{
								if (34343 - 542179 == -507835)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (221875 - 496847 == -274971)
									{
										continue;
									}
									this.audio.Play();
									if (251555 - 465663 != -214108)
									{
										continue;
									}
								}
							}
							if (this.audio.volume < 0.1f * (float)Game.music)
							{
								if (58636 - 406250 != -347614)
								{
									continue;
								}
								this.audio.volume = this.audio.volume + Time.deltaTime;
								if (166643 - 578928 != -412284)
								{
									break;
								}
								continue;
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (295966 - 554179 != -258213)
								{
									continue;
								}
								break;
							}
							goto IL_126;
						}
						if (187384 - 373200 != -185815)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060082D1 RID: 33489 RVA: 0x0108D684 File Offset: 0x0108B884
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (115964 - 243535 != -127570)
		{
		}
		for (;;)
		{
			eGameState mGameState = Game.mGameState;
			if (125286 - 412085 == -286799)
			{
				if (mGameState != eGameState.Complete)
				{
					break;
				}
				if (130910 - 179496 == -48586)
				{
					if (!this.hjtc9WytIu6)
					{
						break;
					}
					if (294482 - 136985 != 157498)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (153796 - 105552 == 48244)
						{
							int num = 1024 * Screen.width / Screen.height;
							if (289088 - 374862 == -85774)
							{
								float num2 = (float)Screen.height / 1024f;
								if (176224 - 530282 == -354058)
								{
									GUI.depth = 1;
									if (39800 - 412578 == -372778)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, (float)2 * (Time.time - this.cAFc9yLotKZ));
										if (290456 - 230489 != 59968)
										{
											Color color = GUI.color;
											if (97807 - 299527 == -201720)
											{
												float num3 = color.a = a;
												if (209782 - 194732 == 15050)
												{
													if (32545 - 423681 != -391135)
													{
														GUI.color = color;
														if (40118 - 48603 != -8484)
														{
															if (276596 - 110774 == 165822)
															{
																float num4 = Mathf.SmoothStep(1.5f, (float)1, Time.time - this.cAFc9yLotKZ);
																if (247706 - 10257 == 237449)
																{
																	GUI.DrawTexture(new Rect(0.5f * (float)num - 0.5f * (float)this.hjtc9WytIu6.width * num4, (float)530 - 0.5f * (float)this.hjtc9WytIu6.height * num4, (float)this.hjtc9WytIu6.width * num4, (float)this.hjtc9WytIu6.height * num4), this.hjtc9WytIu6);
																	if (76049 - 338321 != -262271)
																	{
																		int num5 = 1;
																		if (154123 - 551524 == -397401)
																		{
																			Color color2 = GUI.color;
																			if (23540 - 415332 == -391792)
																			{
																				color2.a = (float)num5;
																				if (19258 - 430302 == -411044)
																				{
																					if (169821 - 585299 == -415478)
																					{
																						Color color3 = GUI.color = color2;
																						if (288188 - 123475 == 164713)
																						{
																							if (53703 - 316286 != -262582)
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

	// Token: 0x060082D2 RID: 33490 RVA: 0x0108DA44 File Offset: 0x0108BC44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (80375 - 549066 != -468690)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (245939 - 93142 == 152797)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (280687 - 478387 == -197700)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (35165 - 506412 != -471246)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (17799 - 1329 == 16470)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060082D3 RID: 33491 RVA: 0x0108DB34 File Offset: 0x0108BD34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (290050 - 168819 != 121231)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (1344 - 530291 == -528947)
			{
				Time.timeScale = 0.85f;
				if (131011 - 158248 == -27237)
				{
					this.DS6c9VMkUCL = GameObject.Find("EventCamera1");
					if (227083 - 564903 == -337820)
					{
						this.MLCc9hJ3qgR = GameObject.Find("EventCamera2");
						if (180362 - 228046 == -47684)
						{
							this.whKc9Kon3Yk = GameObject.Find("EventCamera3");
							if (92456 - 345072 == -252616)
							{
								this.UaRc9z22oeC = GameObject.Find("EventCamera4");
								if (26912 - 271627 == -244715)
								{
									this.AV6cW5YQ2XD = GameObject.Find("SpawnPoint1");
									if (52761 - 305463 != -252701)
									{
										this.F6gcWcwZmCS = GameObject.Find("SpawnPoint2");
										if (123984 - 251222 == -127238)
										{
											this.fXUcWnxjvxR = GameObject.Find("SpawnPoint3");
											if (62644 - 138203 != -75558)
											{
												Hashtable customOpParameters = new Hashtable();
												if (256540 - 169396 == 87144)
												{
													this.Srvc9FG5bd5.OpCustom(52, customOpParameters, true);
													if (41149 - 397272 == -356123)
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

	// Token: 0x060082D4 RID: 33492 RVA: 0x0108DD24 File Offset: 0x0108BF24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (209500 - 294604 != -85104)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (281711 - 271236 == 10475)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (132016 - 389576 == -257560)
				{
					Game.mGameState = eGameState.Setup;
					if (57699 - 290421 != -232721)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060082D5 RID: 33493 RVA: 0x0108DDC8 File Offset: 0x0108BFC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (278273 - 432124 != -153850)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (269654 - 388821 == -119167)
			{
				if (num == PlayerData.UID)
				{
					if (88122 - 288430 == -200308)
					{
						this.SetupActors();
						if (140580 - 398101 == -257521)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (86724 - 333645 != -246920)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060082D6 RID: 33494 RVA: 0x0108DE98 File Offset: 0x0108C098
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (229060 - 212502 != 16558)
		{
		}
		for (;;)
		{
			IL_1D3:
			Debug.Log("Creating Actors");
			if (288464 - 328266 != -39801)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (38421 - 547436 == -509015)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (88907 - 81763 != 7145)
						{
							int i = 0;
							if (245800 - 249292 != -3491)
							{
								CharacterControl[] array2 = array;
								if (196916 - 317013 != -120096)
								{
									int length = array2.Length;
									if (270057 - 18025 != 252033)
									{
										while (i < length)
										{
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (137558 - 25530 != 112028)
											{
												goto IL_1D3;
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (190490 - 468695 != -278205)
											{
												goto IL_1D3;
											}
											this.jPBcWQ4X0Tu++;
											if (11479 - 451505 != -440026)
											{
												goto IL_1D3;
											}
											i++;
											if (253667 - 335825 != -82158)
											{
												goto IL_1D3;
											}
										}
										if (200752 - 465080 != -264327)
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
						if (255892 - 14222 != 241671)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060082D7 RID: 33495 RVA: 0x0108E0B0 File Offset: 0x0108C2B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (221813 - 148204 != 73609)
		{
		}
		for (;;)
		{
			IL_C4:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (112989 - 369975 == -256986)
			{
				int i = 0;
				if (140386 - 153930 != -13543)
				{
					CharacterControl[] array2 = array;
					if (28759 - 36032 != -7272)
					{
						int length = array2.Length;
						if (100667 - 59582 != 41086)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (203402 - 450357 != -246955)
								{
									goto IL_C4;
								}
								i++;
								if (64387 - 47727 != 16660)
								{
									goto IL_C4;
								}
							}
							if (103396 - 531027 == -427631)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060082D8 RID: 33496 RVA: 0x0108E1E0 File Offset: 0x0108C3E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (269777 - 375583 != -105806)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (262872 - 394776 == -131904)
			{
				Game.mGameState = eGameState.Ready;
				if (217141 - 492995 == -275854)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (198202 - 175183 == 23019)
					{
						GameObject gameObject = GameObject.Find("StartPoint1");
						if (78334 - 537892 != -459557)
						{
							if (!gameObject)
							{
								break;
							}
							if (259636 - 216752 != 42885)
							{
								this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
								if (280484 - 150322 == 130162)
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

	// Token: 0x060082D9 RID: 33497 RVA: 0x0108E30C File Offset: 0x0108C50C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M507_AnemoneDecision.$StartGame$39505(this).GetEnumerator();
	}

	// Token: 0x060082DA RID: 33498 RVA: 0x0108E31C File Offset: 0x0108C51C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060082DB RID: 33499 RVA: 0x0108E320 File Offset: 0x0108C520
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToWaterGod()
	{
		return new M507_AnemoneDecision.$TalkToWaterGod$39513(this).GetEnumerator();
	}

	// Token: 0x060082DC RID: 33500 RVA: 0x0108E330 File Offset: 0x0108C530
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToAmmonite()
	{
		return new M507_AnemoneDecision.$TalkToAmmonite$39528(this).GetEnumerator();
	}

	// Token: 0x060082DD RID: 33501 RVA: 0x0108E340 File Offset: 0x0108C540
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (286685 - 51417 != 235268)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (207778 - 221315 == -13537)
			{
				hashtable.Add(71, CID);
				if (151464 - 223050 == -71586)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (281424 - 337369 != -55944)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (135133 - 417451 == -282318)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (175230 - 236464 == -61234)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (243937 - 285377 != -41439)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (286658 - 233702 != 52957)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (138872 - 260509 != -121636)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (223814 - 453213 == -229399)
											{
												this.Srvc9FG5bd5.OpCustom(61, hashtable, true);
												if (51853 - 287935 == -236082)
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

	// Token: 0x060082DE RID: 33502 RVA: 0x0108E5CC File Offset: 0x0108C7CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (174898 - 195254 != -20356)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (204175 - 456009 != -251833)
			{
				if (!gameObject)
				{
					break;
				}
				if (128424 - 51381 == 77043)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (11452 - 493954 != -482501)
					{
						playerCameraControl.target = gameObject;
						if (294468 - 521443 == -226975)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (145787 - 439890 != -294102)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060082DF RID: 33503 RVA: 0x0108E6C4 File Offset: 0x0108C8C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (236035 - 298114 != -62078)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (274791 - 274533 != 259)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (41993 - 78618 == -36625)
				{
					gameGui.ResetTeamBar();
					if (227585 - 181976 != 45610)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060082E0 RID: 33504 RVA: 0x0108E770 File Offset: 0x0108C970
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M507_AnemoneDecision.$onDeadPlayer$39536(this).GetEnumerator();
	}

	// Token: 0x060082E1 RID: 33505 RVA: 0x0108E780 File Offset: 0x0108C980
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (293172 - 361136 != -67964)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (292287 - 225984 != 66304)
			{
				this.LVgc9AcqlTd.target = Game.mPlayer;
				if (66615 - 357419 != -290803)
				{
					this.LVgc9AcqlTd.enabled = true;
					if (112692 - 361762 == -249070)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (108734 - 256732 != -147998)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (21387 - 11847 == 9541)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (58459 - 80386 != -21926)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (232243 - 533989 != -301745)
							{
								if (!gameGui)
								{
									break;
								}
								if (196661 - 46042 == 150619)
								{
									gameGui.enabled = true;
									if (280721 - 455492 != -174770)
									{
										gameGui.closeDeadMenu();
										if (67918 - 421267 == -353349)
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

	// Token: 0x060082E2 RID: 33506 RVA: 0x0108E92C File Offset: 0x0108CB2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (180366 - 187846 != -7480)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (200343 - 295484 != -95140)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (137096 - 267903 != -130806)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (168615 - 38901 == 129714)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060082E3 RID: 33507 RVA: 0x0108E9F0 File Offset: 0x0108CBF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x060082E4 RID: 33508 RVA: 0x0108EA1C File Offset: 0x0108CC1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (66103 - 166470 != -100367)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (132034 - 26469 == 105565)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (34170 - 127250 != -93079)
				{
					hashtable.Add(43, PlayerData.UID);
					if (122748 - 116700 != 6049)
					{
						hashtable.Add(73, nType);
						if (111481 - 453110 != -341628)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (46087 - 269731 == -223644)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (160140 - 114246 != 45895)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (270681 - 198568 == 72113)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (134707 - 179571 == -44864)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (129785 - 314580 == -184795)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (240034 - 379720 != -139685)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (79678 - 103479 == -23801)
													{
														this.Srvc9FG5bd5.OpCustom(63, hashtable, true);
														if (71702 - 337055 == -265353)
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

	// Token: 0x060082E5 RID: 33509 RVA: 0x0108ED00 File Offset: 0x0108CF00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (185813 - 215061 != -29248)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (84528 - 400840 != -316311)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (280497 - 400092 == -119595)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (117322 - 203463 != -86140)
						{
							if (this.jPBcWQ4X0Tu <= 0)
							{
								break;
							}
							if (58720 - 439670 != -380949)
							{
								this.jPBcWQ4X0Tu--;
								if (147753 - 337931 == -190178)
								{
									if (this.jPBcWQ4X0Tu != 0)
									{
										break;
									}
									if (259600 - 20897 == 238703)
									{
										Game.setGameState(eGameState.Ready);
										if (202584 - 162719 == 39865)
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
						if (104369 - 29886 != 74484)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (191673 - 313847 != -122173)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060082E6 RID: 33510 RVA: 0x0108EE90 File Offset: 0x0108D090
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x060082E7 RID: 33511 RVA: 0x0108EEA4 File Offset: 0x0108D0A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x060082E8 RID: 33512 RVA: 0x0108EEB8 File Offset: 0x0108D0B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M507_AnemoneDecision.$onGameComplete$39542(data, this).GetEnumerator();
	}

	// Token: 0x060082E9 RID: 33513 RVA: 0x0108EEC8 File Offset: 0x0108D0C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M507_AnemoneDecision.$ReturnToTown$39547(this).GetEnumerator();
	}

	// Token: 0x060082EA RID: 33514 RVA: 0x0108EED8 File Offset: 0x0108D0D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M507_AnemoneDecision.$ReturnToGuild$39552(this).GetEnumerator();
	}

	// Token: 0x060082EB RID: 33515 RVA: 0x0108EEE8 File Offset: 0x0108D0E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M507_AnemoneDecision.$ReturnToCamp$39556(this).GetEnumerator();
	}

	// Token: 0x060082EC RID: 33516 RVA: 0x0108EEF8 File Offset: 0x0108D0F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (217170 - 80465 != 136705)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (196775 - 345538 == -148763)
			{
				Hashtable hashtable = new Hashtable();
				if (52218 - 506554 != -454335)
				{
					hashtable.Add(43, PlayerData.UID);
					if (211854 - 531236 != -319381)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (188702 - 206190 != -17487)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060082ED RID: 33517 RVA: 0x0108EFD0 File Offset: 0x0108D1D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x060082EE RID: 33518 RVA: 0x0108EFE4 File Offset: 0x0108D1E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (154128 - 422983 != -268854)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (141842 - 497594 == -355752)
			{
				Hashtable hashtable = new Hashtable();
				if (110786 - 278785 == -167999)
				{
					if (Game.mNextGameCode == 30)
					{
						if (177215 - 311533 != -134318)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (127539 - 116035 == 11505)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (222583 - 289248 != -66665)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (20481 - 107048 == -86566)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (45485 - 543616 == -498130)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (286569 - 203680 != 82889)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (39147 - 362228 == -323080)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (96449 - 180179 != -83730)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (273037 - 503206 != -230169)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (243869 - 505265 != -261396)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (199059 - 397639 != -198580)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (113806 - 83913 != 29893)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (133379 - 591492 != -458113)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (33600 - 534544 != -500944)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (255294 - 388514 != -133220)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (145545 - 252916 != -107371)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (158046 - 254552 != -96506)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (165338 - 539528 == -374189)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (113843 - 209816 == -95972)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (160431 - 459592 == -299160)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (268336 - 210953 != 57383)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (71965 - 97 == 71869)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (204534 - 514685 == -310150)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (23033 - 573115 != -550082)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (18150 - 79042 != -60892)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (31431 - 591340 != -559909)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (69348 - 414123 == -344774)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (86270 - 74751 == 11520)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (247193 - 272405 != -25211)
					{
						this.Srvc9FG5bd5.OpCustom(42, hashtable, true);
						if (18460 - 224505 != -206044)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060082EF RID: 33519 RVA: 0x0108F598 File Offset: 0x0108D798
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x060082F0 RID: 33520 RVA: 0x0108F5A8 File Offset: 0x0108D7A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060082F1 RID: 33521 RVA: 0x0108F5AC File Offset: 0x0108D7AC
	internal static bool i22hYApsIL2jhGInfcII()
	{
		return true;
	}

	// Token: 0x060082F2 RID: 33522 RVA: 0x0108F5B0 File Offset: 0x0108D7B0
	internal static bool k4TZVGpsBpd9tw9GOM7m()
	{
		return false;
	}

	// Token: 0x040080C2 RID: 32962
	private LitePeer Srvc9FG5bd5;

	// Token: 0x040080C3 RID: 32963
	private PlayerCameraControl LVgc9AcqlTd;

	// Token: 0x040080C4 RID: 32964
	private float xQwc99r9JO2;

	// Token: 0x040080C5 RID: 32965
	private Texture hjtc9WytIu6;

	// Token: 0x040080C6 RID: 32966
	private int Id0c9uGQDO6;

	// Token: 0x040080C7 RID: 32967
	private float cAFc9yLotKZ;

	// Token: 0x040080C8 RID: 32968
	private GameObject DS6c9VMkUCL;

	// Token: 0x040080C9 RID: 32969
	private GameObject MLCc9hJ3qgR;

	// Token: 0x040080CA RID: 32970
	private GameObject whKc9Kon3Yk;

	// Token: 0x040080CB RID: 32971
	private GameObject UaRc9z22oeC;

	// Token: 0x040080CC RID: 32972
	private GameObject AV6cW5YQ2XD;

	// Token: 0x040080CD RID: 32973
	private GameObject F6gcWcwZmCS;

	// Token: 0x040080CE RID: 32974
	private GameObject fXUcWnxjvxR;

	// Token: 0x040080CF RID: 32975
	private int jPBcWQ4X0Tu;

	// Token: 0x040080D0 RID: 32976
	public GameObject door_bubble;

	// Token: 0x02001606 RID: 5638
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$39505 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060082F3 RID: 33523 RVA: 0x0108F5B4 File Offset: 0x0108D7B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$39505(M507_AnemoneDecision self_)
		{
			if (113546 - 76823 != 36723)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (177405 - 494449 == -317044)
				{
					base..ctor();
					if (113962 - 527041 == -413079)
					{
						this.$self_$39512 = self_;
						if (215626 - 82615 == 133011)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060082F4 RID: 33524 RVA: 0x0108F64C File Offset: 0x0108D84C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M507_AnemoneDecision.$StartGame$39505.$(this.$self_$39512);
		}

		// Token: 0x060082F5 RID: 33525 RVA: 0x0108F65C File Offset: 0x0108D85C
		internal static bool Bx1J3xpsemOTQ849pdAb()
		{
			return true;
		}

		// Token: 0x060082F6 RID: 33526 RVA: 0x0108F660 File Offset: 0x0108D860
		internal static bool e1d1CupsrqoPoZBjJ3ho()
		{
			return false;
		}

		// Token: 0x040080D1 RID: 32977
		internal M507_AnemoneDecision $self_$39512;

		// Token: 0x02001607 RID: 5639
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060082F7 RID: 33527 RVA: 0x0108F664 File Offset: 0x0108D864
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M507_AnemoneDecision self_)
			{
				if (89345 - 413725 != -324380)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (118049 - 463819 != -345769)
					{
						base..ctor();
						if (69652 - 446859 != -377206)
						{
							this.$self_$39511 = self_;
							if (188213 - 535953 != -347739)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060082F8 RID: 33528 RVA: 0x0108F6FC File Offset: 0x0108D8FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (189193 - 482458 != -293265)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6D3;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (222407 - 189145 != 33262)
							{
								continue;
							}
							goto IL_4CC;
						}
						else
						{
							this.$mStoryGui$39506 = (StoryGui)this.$self_$39511.GetComponent(typeof(StoryGui));
							if (141206 - 324227 == -183020)
							{
								continue;
							}
							this.$mStoryTimer$39507 = 0f;
							if (150556 - 194 == 150363)
							{
								continue;
							}
							this.$mStoryGui$39506.startStoryMessage("none", "Anemone", eTalkType.friend);
							if (296304 - 416967 != -120662)
							{
								goto Block_3;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (171635 - 400917 != -229281)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$39506.newStoryMessage("none", "Anemone", Language.getMessage("M507_AnemoneDecision", 101), eTalkType.friend);
							if (67255 - 58708 == 8548)
							{
								continue;
							}
							this.$mStoryTimer$39507 = Time.time + 5f;
							if (122103 - 269589 != -147486)
							{
								continue;
							}
							goto IL_371;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (266587 - 12444 != 254144)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							this.$mWaterDoor$39508 = GameObject.Find("WaterDoor");
							if (195524 - 382437 == -186912)
							{
								continue;
							}
							if (!this.$mWaterDoor$39508)
							{
								goto IL_3AC;
							}
							if (258023 - 440894 != -182871)
							{
								continue;
							}
							this.$mWaterDoor$39508.animation.Play("open");
							if (92626 - 533633 == -441006)
							{
								continue;
							}
							if (!this.$self_$39511.door_bubble)
							{
								goto IL_3AC;
							}
							if (28357 - 6725 != 21632)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$39511.door_bubble, this.$mWaterDoor$39508.transform.position, Quaternion.identity);
							if (1896 - 333341 != -331445)
							{
								continue;
							}
							goto IL_3AC;
						}
						break;
					case 5:
						goto IL_3D3;
					case 6:
						goto IL_3D3;
					case 7:
						if (Game.mGameState != eGameState.Hold)
						{
							if (182841 - 479112 != -296271)
							{
								continue;
							}
							goto IL_3FD;
						}
						else
						{
							this.$mGameGui$39510 = (GameGui)this.$self_$39511.GetComponent(typeof(GameGui));
							if (119914 - 475894 != -355980)
							{
								continue;
							}
							this.$mGameGui$39510.enabled = true;
							if (62949 - 485484 == -422534)
							{
								continue;
							}
							this.$self_$39511.LVgc9AcqlTd.specialTarget = null;
							if (279607 - 243062 != 36546)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Hold)
						{
							if (34255 - 133167 != -98912)
							{
								continue;
							}
							goto IL_565;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (122001 - 410024 != -288023)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (174580 - 76003 == 98578)
							{
								continue;
							}
							this.YieldDefault(1);
							if (256704 - 307968 != -51263)
							{
								goto Block_5;
							}
							continue;
						}
						break;
					default:
						if (128518 - 158211 != -29693)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (250820 - 530554 == -279733)
					{
						continue;
					}
					Game.mGameState = eGameState.Hold;
					if (154670 - 38304 != 116366)
					{
						continue;
					}
					this.$self_$39511.SendMessage("fadeIn");
					if (164790 - 553459 == -388668)
					{
						continue;
					}
					if (!this.$self_$39511.DS6c9VMkUCL)
					{
						goto IL_B6;
					}
					if (94704 - 84869 == 9836)
					{
						continue;
					}
					this.$self_$39511.LVgc9AcqlTd.setSpecialTarget(this.$self_$39511.DS6c9VMkUCL, 4f);
					if (237842 - 59377 != 178465)
					{
						continue;
					}
					this.$self_$39511.LVgc9AcqlTd.enabled = true;
					if (108499 - 137747 != -29248)
					{
						continue;
					}
					goto IL_B6;
					IL_3D3:
					if (this.$mStoryTimer$39507 > Time.time)
					{
						if (147321 - 329164 == -181842)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_3C7;
						}
						if (53982 - 535734 != -481752)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (225873 - 249459 == -23586)
						{
							goto IL_347;
						}
					}
					else
					{
						this.$mStoryGui$39506.close();
						if (102503 - 229163 != -126659)
						{
							this.$mStartCamera1$39509 = GameObject.Find("StartCamera1");
							if (207709 - 88528 != 119182)
							{
								if (!this.$mStartCamera1$39509)
								{
									goto IL_5D4;
								}
								if (244916 - 355847 != -110930)
								{
									this.$self_$39511.LVgc9AcqlTd.setSpecialTarget(this.$mStartCamera1$39509, 4f);
									if (286617 - 493540 == -206923)
									{
										goto IL_5D4;
									}
								}
							}
						}
					}
				}
				Block_3:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_5:
				goto IL_6D3;
				IL_B6:
				return this.Yield(2, new WaitForSeconds(4.5f));
				Block_17:
				goto IL_6D3;
				Block_19:
				return this.Yield(8, new WaitForSeconds(1f));
				IL_347:
				goto IL_6D3;
				IL_371:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_27:
				goto IL_6D3;
				IL_3AC:
				return this.Yield(5, new WaitForSeconds(1f));
				IL_3C7:
				return this.YieldDefault(6);
				IL_3FD:
				IL_4CC:
				IL_565:
				goto IL_6D3;
				IL_5D4:
				return this.Yield(7, new WaitForSeconds(4f));
				IL_6D3:
				return false;
			}

			// Token: 0x060082F9 RID: 33529 RVA: 0x0108FDF0 File Offset: 0x0108DFF0
			internal static bool w5bv7kpsjKXFgtPT4iw5()
			{
				return true;
			}

			// Token: 0x060082FA RID: 33530 RVA: 0x0108FDF4 File Offset: 0x0108DFF4
			internal static bool aU80Vypshm2KwoS0uqnf()
			{
				return false;
			}

			// Token: 0x040080D2 RID: 32978
			internal StoryGui $mStoryGui$39506;

			// Token: 0x040080D3 RID: 32979
			internal float $mStoryTimer$39507;

			// Token: 0x040080D4 RID: 32980
			internal GameObject $mWaterDoor$39508;

			// Token: 0x040080D5 RID: 32981
			internal GameObject $mStartCamera1$39509;

			// Token: 0x040080D6 RID: 32982
			internal GameGui $mGameGui$39510;

			// Token: 0x040080D7 RID: 32983
			internal M507_AnemoneDecision $self_$39511;
		}
	}

	// Token: 0x02001608 RID: 5640
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToWaterGod$39513 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060082FB RID: 33531 RVA: 0x0108FDF8 File Offset: 0x0108DFF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToWaterGod$39513(M507_AnemoneDecision self_)
		{
			if (100068 - 197865 != -97797)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (172413 - 534482 == -362069)
				{
					base..ctor();
					if (92799 - 521705 == -428906)
					{
						this.$self_$39527 = self_;
						if (262763 - 104191 != 158573)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060082FC RID: 33532 RVA: 0x0108FE90 File Offset: 0x0108E090
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M507_AnemoneDecision.$TalkToWaterGod$39513.$(this.$self_$39527);
		}

		// Token: 0x060082FD RID: 33533 RVA: 0x0108FEA0 File Offset: 0x0108E0A0
		internal static bool cBIMPjpssZtEC77JNg1t()
		{
			return true;
		}

		// Token: 0x060082FE RID: 33534 RVA: 0x0108FEA4 File Offset: 0x0108E0A4
		internal static bool GnG4Lsps9UDaV3DmrxAv()
		{
			return false;
		}

		// Token: 0x040080D8 RID: 32984
		internal M507_AnemoneDecision $self_$39527;

		// Token: 0x02001609 RID: 5641
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060082FF RID: 33535 RVA: 0x0108FEA8 File Offset: 0x0108E0A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M507_AnemoneDecision self_)
			{
				if (252307 - 10898 != 241409)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (162447 - 113134 != 49314)
					{
						base..ctor();
						if (100843 - 86974 != 13870)
						{
							this.$self_$39526 = self_;
							if (245158 - 550972 != -305813)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008300 RID: 33536 RVA: 0x0108FF40 File Offset: 0x0108E140
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (280054 - 349044 != -68989)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_1836;
					case 1:
						goto IL_2CC1;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (178273 - 253827 != -75554)
							{
								continue;
							}
							goto IL_1A18;
						}
						else
						{
							this.$self_$39526.SendMessage("fadeOut");
							if (7085 - 366698 != -359612)
							{
								goto Block_193;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (208352 - 548357 != -340005)
							{
								continue;
							}
							goto IL_D33;
						}
						else
						{
							this.$mStoryGui$39515 = (StoryGui)this.$self_$39526.GetComponent(typeof(StoryGui));
							if (1666 - 551714 != -550048)
							{
								continue;
							}
							this.$mStoryTimer$39516 = 0f;
							if (282180 - 411015 != -128835)
							{
								continue;
							}
							this.$mHeroType$39517 = CharacterData.current.Type;
							if (2052 - 393780 == -391727)
							{
								continue;
							}
							this.$mHeroName$39518 = CharacterData.current.Name;
							if (147577 - 295415 != -147838)
							{
								continue;
							}
							this.$mWaterGod$39519 = GameObject.Find("WaterGod");
							if (77275 - 173419 != -96144)
							{
								continue;
							}
							this.$mPlayer1$39520 = Game.mPlayer;
							if (250287 - 69898 == 180390)
							{
								continue;
							}
							this.$mCDat2$39521 = null;
							if (27759 - 232609 != -204850)
							{
								continue;
							}
							this.$mCDat3$39522 = null;
							if (174100 - 8644 != 165456)
							{
								continue;
							}
							this.$$switch$6959$39523 = CharacterData.mSlot;
							if (223679 - 404915 != -181236)
							{
								continue;
							}
							if (this.$$switch$6959$39523 == 1)
							{
								if (20705 - 200884 == -180178)
								{
									continue;
								}
								this.$mCDat2$39521 = CharacterData.getCDat(2);
								if (206508 - 588215 != -381707)
								{
									continue;
								}
								this.$mCDat3$39522 = CharacterData.getCDat(3);
								if (75506 - 119203 == -43696)
								{
									continue;
								}
							}
							else if (this.$$switch$6959$39523 == 2)
							{
								if (270419 - 492757 == -222337)
								{
									continue;
								}
								this.$mCDat2$39521 = CharacterData.getCDat(1);
								if (79774 - 404773 == -324998)
								{
									continue;
								}
								this.$mCDat3$39522 = CharacterData.getCDat(3);
								if (285499 - 110619 != 174880)
								{
									continue;
								}
							}
							else if (this.$$switch$6959$39523 == 3)
							{
								if (155 - 568861 == -568705)
								{
									continue;
								}
								this.$mCDat2$39521 = CharacterData.getCDat(1);
								if (32585 - 50755 == -18169)
								{
									continue;
								}
								this.$mCDat3$39522 = CharacterData.getCDat(2);
								if (11384 - 226815 == -215430)
								{
									continue;
								}
							}
							if (this.$self_$39526.AV6cW5YQ2XD)
							{
								if (289789 - 172925 == 116865)
								{
									continue;
								}
								if (this.$mPlayer1$39520)
								{
									if (271118 - 216988 == 54131)
									{
										continue;
									}
									this.$mPlayer1$39520.transform.position = this.$self_$39526.AV6cW5YQ2XD.transform.position;
									if (132479 - 155648 == -23168)
									{
										continue;
									}
									this.$mPlayer1$39520.transform.rotation = this.$self_$39526.AV6cW5YQ2XD.transform.rotation;
									if (216460 - 406100 != -189640)
									{
										continue;
									}
								}
							}
							if (this.$self_$39526.F6gcWcwZmCS)
							{
								if (249379 - 509426 != -260047)
								{
									continue;
								}
								if (this.$mCDat2$39521 != null)
								{
									if (166047 - 125227 == 40821)
									{
										continue;
									}
									if (this.$mCDat2$39521.Type != "none")
									{
										if (255065 - 510013 == -254947)
										{
											continue;
										}
										this.$mPlayer2$39524 = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("GameAssets/Characters/Lobby/viewChar/" + this.$mCDat2$39521.Type, typeof(GameObject)), this.$self_$39526.F6gcWcwZmCS.transform.position, this.$self_$39526.F6gcWcwZmCS.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
										if (28725 - 597273 != -568548)
										{
											continue;
										}
										if (this.$mPlayer2$39524)
										{
											if (15557 - 29018 != -13461)
											{
												continue;
											}
											this.$mPlayer2$39524.SendMessage("EquipCDat", this.$mCDat2$39521.slot);
											if (203361 - 349234 == -145872)
											{
												continue;
											}
										}
									}
								}
							}
							if (this.$self_$39526.fXUcWnxjvxR)
							{
								if (209937 - 203498 != 6439)
								{
									continue;
								}
								if (this.$mCDat3$39522 != null)
								{
									if (39432 - 448569 != -409137)
									{
										continue;
									}
									if (this.$mCDat3$39522.Type != "none")
									{
										if (197988 - 432517 == -234528)
										{
											continue;
										}
										this.$mPlayer3$39525 = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("GameAssets/Characters/Lobby/viewChar/" + this.$mCDat3$39522.Type, typeof(GameObject)), this.$self_$39526.fXUcWnxjvxR.transform.position, this.$self_$39526.fXUcWnxjvxR.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
										if (240307 - 593262 == -352954)
										{
											continue;
										}
										if (this.$mPlayer3$39525)
										{
											if (128848 - 521497 == -392648)
											{
												continue;
											}
											this.$mPlayer3$39525.SendMessage("EquipCDat", this.$mCDat3$39522.slot);
											if (124406 - 369162 == -244755)
											{
												continue;
											}
										}
									}
								}
							}
							this.$self_$39526.SendMessage("alignToObject", "EventCamera2");
							if (76250 - 233730 != -157479)
							{
								goto Block_260;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (77382 - 324480 != -247098)
							{
								continue;
							}
							goto IL_148E;
						}
						else
						{
							this.$self_$39526.SendMessage("fadeIn");
							if (29761 - 60247 != -30485)
							{
								goto Block_148;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (172793 - 390350 != -217556)
							{
								goto Block_270;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$39515.startStoryMessage("WaterGod", "Anemone", eTalkType.friend);
							if (246439 - 508457 != -262017)
							{
								goto Block_146;
							}
							continue;
						}
						break;
					case 6:
						this.$mStoryGui$39515.newStoryMessage("WaterGod", "Anemone", Language.getMessage("M507_AnemoneDecision", 102), eTalkType.friend);
						if (53341 - 381299 == -327957)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (146454 - 273555 != -127101)
						{
							continue;
						}
						goto IL_867;
					case 7:
						goto IL_88E;
					case 8:
						goto IL_88E;
					case 9:
						goto IL_5C6;
					case 10:
						goto IL_5C6;
					case 11:
						goto IL_2B24;
					case 12:
						goto IL_2B24;
					case 13:
						goto IL_135E;
					case 14:
						goto IL_135E;
					case 15:
						goto IL_4EA;
					case 16:
						goto IL_4EA;
					case 17:
						goto IL_234E;
					case 18:
						goto IL_234E;
					case 19:
						goto IL_AFB;
					case 20:
						goto IL_AFB;
					case 21:
						goto IL_28B1;
					case 22:
						goto IL_28B1;
					case 23:
						goto IL_2632;
					case 24:
						goto IL_2632;
					case 25:
						goto IL_27B8;
					case 26:
						goto IL_27B8;
					case 27:
						break;
					case 28:
						break;
					case 29:
						goto IL_158B;
					case 30:
						goto IL_158B;
					case 31:
						goto IL_1187;
					case 32:
						goto IL_1187;
					case 33:
						goto IL_1708;
					case 34:
						goto IL_1708;
					case 35:
						goto IL_26AE;
					case 36:
						goto IL_26AE;
					case 37:
						goto IL_2208;
					case 38:
						goto IL_2208;
					case 39:
						goto IL_EB3;
					case 40:
						goto IL_EB3;
					case 41:
						goto IL_21D;
					case 42:
						goto IL_21D;
					case 43:
						goto IL_19C9;
					case 44:
						goto IL_19C9;
					case 45:
						goto IL_338;
					case 46:
						goto IL_338;
					case 47:
						goto IL_A41;
					case 48:
						goto IL_A41;
					case 49:
						goto IL_254D;
					case 50:
						goto IL_254D;
					case 51:
						goto IL_12AB;
					case 52:
						goto IL_12AB;
					case 53:
						goto IL_2E5;
					case 54:
						goto IL_2E5;
					case 55:
						goto IL_138;
					case 56:
						goto IL_138;
					case 57:
						goto IL_C1A;
					case 58:
						goto IL_C1A;
					case 59:
						goto IL_1C97;
					case 60:
						goto IL_1C97;
					case 61:
						goto IL_FAF;
					case 62:
						goto IL_FAF;
					case 63:
						goto IL_1404;
					case 64:
						goto IL_1404;
					case 65:
						goto IL_285E;
					case 66:
						goto IL_285E;
					case 67:
						if (Game.mGameState != eGameState.Hold)
						{
							if (135679 - 480049 != -344369)
							{
								goto Block_172;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(5071, 0);
							if (256521 - 349559 == -93037)
							{
								continue;
							}
							this.YieldDefault(1);
							if (45392 - 493882 != -448490)
							{
								continue;
							}
							goto IL_2CC1;
						}
						break;
					default:
						if (288219 - 480609 != -192389)
						{
							goto IL_1836;
						}
						continue;
					}
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (192917 - 410378 == -217460)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_36;
						}
						if (241153 - 349508 == -108354)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (151351 - 27790 != 123561)
						{
							continue;
						}
						goto IL_1FB6;
					}
					else
					{
						this.$mStoryGui$39515.newStoryMessage(this.$mHeroType$39517, this.$mHeroName$39518, Language.getMessage("M507_AnemoneDecision", 113), eTalkType.friend);
						if (171370 - 93788 == 77583)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (34351 - 257289 != -222938)
						{
							continue;
						}
						goto IL_1562;
					}
					IL_2B24:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (118292 - 568366 == -450073)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2B17;
						}
						if (9012 - 546191 == -537178)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (118565 - 537345 != -418779)
						{
							goto Block_5;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$39515.newStoryMessage(this.$mHeroType$39517, this.$mHeroName$39518, Language.getMessage("M507_AnemoneDecision", 105), eTalkType.friend);
						if (52255 - 78821 == -26565)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (209386 - 84840 != 124546)
						{
							continue;
						}
						goto IL_1335;
					}
					IL_C1A:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (271872 - 566201 != -294329)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_C0D;
						}
						if (257534 - 465908 == -208373)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (15523 - 485100 != -469577)
						{
							continue;
						}
						goto IL_1B49;
					}
					else
					{
						this.$self_$39526.SendMessage("alignToObject", "EventCamera2");
						if (295546 - 20468 == 275079)
						{
							continue;
						}
						this.$mStoryGui$39515.newStoryMessage("WaterGod", "Anemone", Language.getMessage("M507_AnemoneDecision", 128), eTalkType.friend);
						if (257142 - 448271 == -191128)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (16080 - 436927 != -420846)
						{
							goto Block_79;
						}
						continue;
					}
					IL_138:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (135253 - 157010 == -21756)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_12B;
						}
						if (196759 - 304096 == -107336)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (166080 - 70656 != 95425)
						{
							goto Block_101;
						}
						continue;
					}
					else
					{
						this.$mWaterGod$39519.animation.CrossFade("root");
						if (132568 - 139462 == -6893)
						{
							continue;
						}
						this.$mStoryGui$39515.newStoryMessage("WaterGod", "Anemone", Language.getMessage("M507_AnemoneDecision", 127), eTalkType.friend);
						if (107758 - 100105 == 7654)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (229954 - 149333 != 80622)
						{
							goto Block_61;
						}
						continue;
					}
					IL_21D:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (221782 - 350469 == -128686)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_210;
						}
						if (86706 - 594888 != -508182)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (32166 - 431435 != -399268)
						{
							goto Block_110;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$39515.newStoryMessage("WaterGod", "Anemone", Language.getMessage("M507_AnemoneDecision", 120), eTalkType.friend);
						if (118252 - 543998 != -425746)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (153473 - 381199 != -227726)
						{
							continue;
						}
						goto IL_19A0;
					}
					IL_2632:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (101024 - 210914 == -109889)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2625;
						}
						if (99655 - 402268 != -302613)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (38362 - 88767 != -50404)
						{
							goto Block_17;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$39515.newStoryMessage("WaterGod", "Anemone", Language.getMessage("M507_AnemoneDecision", 111), eTalkType.friend);
						if (166586 - 176565 != -9979)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (141311 - 481187 != -339876)
						{
							continue;
						}
						goto IL_278F;
					}
					IL_2E5:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (61637 - 119695 == -58057)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2D8;
						}
						if (163338 - 285055 != -121717)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (127784 - 546092 != -418308)
						{
							continue;
						}
						goto IL_2B73;
					}
					else
					{
						this.$mStoryGui$39515.newStoryMessage("WaterGod", "Anemone", Language.getMessage("M507_AnemoneDecision", 126), eTalkType.friend);
						if (241357 - 585665 == -344307)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (232319 - 380421 != -148102)
						{
							continue;
						}
						goto IL_10F;
					}
					IL_338:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (55845 - 330700 != -274855)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_32B;
						}
						if (106977 - 173426 == -66448)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (250026 - 457861 != -207834)
						{
							goto Block_86;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$39515.newStoryMessage(this.$mHeroType$39517, this.$mHeroName$39518, Language.getMessage("M507_AnemoneDecision", 122), eTalkType.friend);
						if (110983 - 193343 == -82359)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (203599 - 200881 != 2719)
						{
							goto Block_248;
						}
						continue;
					}
					IL_4EA:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (125368 - 137719 == -12350)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_4DD;
						}
						if (141818 - 477326 != -335508)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (148453 - 77189 != 71264)
						{
							continue;
						}
						goto IL_B25;
					}
					else
					{
						this.$self_$39526.SendMessage("alignToObject", "EventCamera3");
						if (286039 - 587823 != -301784)
						{
							continue;
						}
						this.$mStoryGui$39515.newStoryMessage("WaterGod", "Anemone", Language.getMessage("M507_AnemoneDecision", 107), eTalkType.friend);
						if (201816 - 550397 != -348581)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (133659 - 233093 != -99433)
						{
							goto Block_67;
						}
						continue;
					}
					IL_EB3:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (80288 - 107459 == -27170)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_EA6;
						}
						if (73785 - 231438 == -157652)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (4543 - 325291 != -320748)
						{
							continue;
						}
						goto IL_29C3;
					}
					else
					{
						this.$mStoryGui$39515.newStoryMessage("WaterGod", "Anemone", Language.getMessage("M507_AnemoneDecision", 119), eTalkType.friend);
						if (217094 - 448685 == -231590)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (249168 - 236163 != 13006)
						{
							goto Block_126;
						}
						continue;
					}
					IL_2208:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (237589 - 308933 != -71344)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_21FB;
						}
						if (247416 - 550383 != -302967)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (68956 - 528184 != -459227)
						{
							goto Block_188;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$39515.newStoryMessage("WaterGod", "Anemone", Language.getMessage("M507_AnemoneDecision", 118), eTalkType.friend);
						if (55156 - 400354 != -345198)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (256743 - 294235 != -37492)
						{
							continue;
						}
						goto IL_E8A;
					}
					IL_1C97:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (24904 - 523301 == -498396)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1C8A;
						}
						if (162369 - 367515 == -205145)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (276730 - 56167 != 220564)
						{
							goto Block_43;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$39515.newStoryMessage("WaterGod", "Anemone", Language.getMessage("M507_AnemoneDecision", 129), eTalkType.friend);
						if (38041 - 544769 != -506728)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (99544 - 466893 != -367348)
						{
							goto Block_261;
						}
						continue;
					}
					IL_5C6:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (252809 - 496681 == -243871)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_5B9;
						}
						if (243497 - 451460 == -207962)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (287204 - 292927 != -5722)
						{
							goto Block_322;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$39515.newStoryMessage("WaterGod", "Anemone", Language.getMessage("M507_AnemoneDecision", 104), eTalkType.friend);
						if (242543 - 368870 == -126326)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (200864 - 389475 != -188610)
						{
							goto Block_132;
						}
						continue;
					}
					IL_27B8:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (164098 - 214441 == -50342)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_27AB;
						}
						if (258229 - 260777 != -2548)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (223967 - 436926 != -212959)
						{
							continue;
						}
						goto IL_7DD;
					}
					else
					{
						this.$self_$39526.SendMessage("alignToObject", "EventCamera4");
						if (295945 - 413880 != -117935)
						{
							continue;
						}
						this.$mStoryGui$39515.newStoryMessage(this.$mHeroType$39517, this.$mHeroName$39518, Language.getMessage("M507_AnemoneDecision", 112), eTalkType.friend);
						if (29209 - 428387 == -399177)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (157258 - 583697 != -426439)
						{
							continue;
						}
						break;
					}
					IL_28B1:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (193647 - 372325 != -178678)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_28A4;
						}
						if (244931 - 328941 != -84010)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (110707 - 370668 != -259961)
						{
							continue;
						}
						goto IL_225D;
					}
					else
					{
						this.$mStoryGui$39515.newStoryMessage("WaterGod", "Anemone", Language.getMessage("M507_AnemoneDecision", 110), eTalkType.friend);
						if (86660 - 498393 != -411733)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (94682 - 300102 != -205419)
						{
							goto Block_259;
						}
						continue;
					}
					IL_234E:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (246061 - 491042 == -244980)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2341;
						}
						if (42645 - 117995 == -75349)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (33848 - 91573 != -57725)
						{
							continue;
						}
						goto IL_2023;
					}
					else
					{
						this.$mStoryGui$39515.newStoryMessage("WaterGod", "Anemone", Language.getMessage("M507_AnemoneDecision", 108), eTalkType.friend);
						if (254969 - 498053 != -243084)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (161705 - 469076 != -307370)
						{
							goto Block_68;
						}
						continue;
					}
					IL_88E:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (48529 - 371371 == -322841)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_882;
						}
						if (103882 - 138390 == -34507)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (295771 - 319945 != -24173)
						{
							goto Block_98;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$39515.newStoryMessage("WaterGod", "Anemone", Language.getMessage("M507_AnemoneDecision", 103), eTalkType.friend);
						if (185545 - 155966 != 29579)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (120905 - 190129 != -69224)
						{
							continue;
						}
						goto IL_59D;
					}
					IL_135E:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (236589 - 43675 == 192915)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1351;
						}
						if (155263 - 195849 != -40586)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (85808 - 82081 != 3728)
						{
							goto Block_75;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$39515.newStoryMessage(this.$mHeroType$39517, this.$mHeroName$39518, Language.getMessage("M507_AnemoneDecision", 106), eTalkType.friend);
						if (144138 - 587375 == -443236)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (240616 - 180437 != 60179)
						{
							continue;
						}
						goto IL_4C1;
					}
					IL_A41:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (143607 - 146330 != -2723)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_A34;
						}
						if (155012 - 383814 != -228802)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (163493 - 126887 != 36606)
						{
							continue;
						}
						goto IL_1CC1;
					}
					else
					{
						this.$self_$39526.SendMessage("alignToObject", "EventCamera3");
						if (4503 - 356201 != -351698)
						{
							continue;
						}
						this.$mStoryGui$39515.newStoryMessage("WaterGod", "Anemone", Language.getMessage("M507_AnemoneDecision", 123), eTalkType.friend);
						if (218128 - 14933 != 203195)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (44218 - 322747 != -278528)
						{
							goto Block_222;
						}
						continue;
					}
					IL_AFB:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (266950 - 308283 == -41332)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_AEE;
						}
						if (70086 - 435065 == -364978)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (295517 - 417877 != -122359)
						{
							goto Block_221;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$39515.newStoryMessage("WaterGod", "Anemone", Language.getMessage("M507_AnemoneDecision", 109), eTalkType.friend);
						if (211924 - 108705 == 103220)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (194621 - 411616 != -216995)
						{
							continue;
						}
						goto IL_2888;
					}
					IL_1187:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (82731 - 370969 != -288238)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_117A;
						}
						if (9495 - 320987 != -311492)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (123029 - 417950 != -294920)
						{
							goto Block_121;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$39515.newStoryMessage("WaterGod", "Anemone", Language.getMessage("M507_AnemoneDecision", 115), eTalkType.friend);
						if (154820 - 29555 != 125265)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (164096 - 559402 != -395305)
						{
							goto Block_91;
						}
						continue;
					}
					IL_12AB:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (36056 - 14102 == 21955)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_129E;
						}
						if (36832 - 88222 == -51389)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (52254 - 156760 != -104505)
						{
							goto Block_272;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$39515.newStoryMessage("WaterGod", "Anemone", Language.getMessage("M507_AnemoneDecision", 125), eTalkType.friend);
						if (56711 - 386396 == -329684)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (49830 - 141396 != -91566)
						{
							continue;
						}
						goto IL_2BC;
					}
					IL_FAF:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (146684 - 389791 == -243106)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_FA2;
						}
						if (5814 - 86270 != -80456)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (280320 - 213710 != 66610)
						{
							continue;
						}
						goto IL_2175;
					}
					else
					{
						this.$mStoryGui$39515.newStoryMessage("WaterGod", "Anemone", Language.getMessage("M507_AnemoneDecision", 130), eTalkType.friend);
						if (239144 - 326913 == -87768)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (136564 - 130940 != 5624)
						{
							continue;
						}
						goto IL_13DB;
					}
					IL_19C9:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (188714 - 350789 != -162075)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_19BC;
						}
						if (172989 - 283469 == -110479)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (280799 - 331856 != -51057)
						{
							continue;
						}
						goto IL_1A94;
					}
					else
					{
						this.$mWaterGod$39519.animation.CrossFade("root");
						if (216260 - 439410 == -223149)
						{
							continue;
						}
						this.$mStoryGui$39515.newStoryMessage("WaterGod", "Anemone", Language.getMessage("M507_AnemoneDecision", 121), eTalkType.friend);
						if (71323 - 493532 != -422209)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (62928 - 557843 != -494915)
						{
							continue;
						}
						goto IL_30F;
					}
					IL_285E:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (264768 - 135637 != 129131)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2851;
						}
						if (129633 - 572951 == -443317)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (191553 - 139943 != 51611)
						{
							goto Block_183;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$39515.close();
						if (206844 - 448384 != -241539)
						{
							goto Block_112;
						}
						continue;
					}
					IL_158B:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (267442 - 282063 == -14620)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_157E;
						}
						if (165796 - 501222 == -335425)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (234012 - 366224 != -132211)
						{
							goto Block_192;
						}
						continue;
					}
					else
					{
						this.$mWaterGod$39519.animation.CrossFade("think");
						if (220561 - 592600 != -372039)
						{
							continue;
						}
						this.$mStoryGui$39515.newStoryMessage("WaterGod", "Anemone", Language.getMessage("M507_AnemoneDecision", 114), eTalkType.friend);
						if (259028 - 496762 == -237733)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (93689 - 520512 != -426823)
						{
							continue;
						}
						goto IL_115E;
					}
					IL_1708:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (231088 - 267678 == -36589)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_16FB;
						}
						if (4307 - 203216 != -198909)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (172222 - 578964 != -406742)
						{
							continue;
						}
						goto IL_2133;
					}
					else
					{
						this.$mStoryGui$39515.newStoryMessage("WaterGod", "Anemone", Language.getMessage("M507_AnemoneDecision", 116), eTalkType.friend);
						if (36457 - 134805 == -98347)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (170338 - 260185 != -89847)
						{
							continue;
						}
						goto IL_2685;
					}
					IL_26AE:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (210435 - 590505 == -380069)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_26A1;
						}
						if (163244 - 396448 != -233204)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (19251 - 566769 != -547518)
						{
							continue;
						}
						goto IL_1201;
					}
					else
					{
						this.$mStoryGui$39515.newStoryMessage(this.$mHeroType$39517, this.$mHeroName$39518, Language.getMessage("M507_AnemoneDecision", 117), eTalkType.friend);
						if (229011 - 446295 == -217283)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (150407 - 79203 != 71204)
						{
							continue;
						}
						goto IL_21DF;
					}
					IL_1404:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (272559 - 511922 == -239362)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_13F7;
						}
						if (71583 - 284564 == -212980)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (197297 - 135289 != 62008)
						{
							continue;
						}
						goto IL_1B7D;
					}
					else
					{
						this.$mStoryGui$39515.newStoryMessage("WaterGod", "Anemone", Language.getMessage("M507_AnemoneDecision", 131), eTalkType.friend);
						if (221609 - 577638 == -356028)
						{
							continue;
						}
						this.$mStoryTimer$39516 = Time.time + 5f;
						if (224911 - 510325 != -285413)
						{
							goto Block_276;
						}
						continue;
					}
					IL_1836:
					Debug.Log("OnTalkToWindGod");
					if (294868 - 360994 == -66125)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (7306 - 27821 != -20514)
						{
							goto Block_19;
						}
						continue;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (136477 - 344090 != -207613)
						{
							continue;
						}
						this.$self_$39526.LVgc9AcqlTd.enabled = false;
						if (23573 - 485927 == -462353)
						{
							continue;
						}
						this.$mGameGui$39514 = (GameGui)this.$self_$39526.GetComponent(typeof(GameGui));
						if (36849 - 538850 == -502000)
						{
							continue;
						}
						if (!this.$mGameGui$39514)
						{
							goto IL_779;
						}
						if (173472 - 9422 != 164050)
						{
							continue;
						}
						this.$mGameGui$39514.close();
						if (6290 - 405098 != -398808)
						{
							continue;
						}
						goto IL_779;
					}
					IL_254D:
					if (this.$mStoryTimer$39516 > Time.time)
					{
						if (93006 - 430131 == -337124)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2540;
						}
						if (54078 - 329377 != -275299)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (145770 - 299006 != -153235)
						{
							goto Block_313;
						}
					}
					else
					{
						this.$mWaterGod$39519.animation.CrossFade("think");
						if (46133 - 161498 == -115365)
						{
							this.$mStoryGui$39515.newStoryMessage("WaterGod", "Anemone", Language.getMessage("M507_AnemoneDecision", 124), eTalkType.friend);
							if (19074 - 467936 == -448862)
							{
								this.$mStoryTimer$39516 = Time.time + 5f;
								if (183767 - 436482 == -252715)
								{
									goto IL_1282;
								}
							}
						}
					}
				}
				return this.Yield(27, new WaitForSeconds(0.5f));
				IL_36:
				return this.YieldDefault(28);
				Block_5:
				goto IL_2CC1;
				IL_10F:
				return this.Yield(55, new WaitForSeconds(0.5f));
				IL_12B:
				return this.YieldDefault(56);
				IL_210:
				return this.YieldDefault(42);
				Block_17:
				Block_19:
				goto IL_2CC1;
				IL_2BC:
				return this.Yield(53, new WaitForSeconds(0.5f));
				IL_2D8:
				return this.YieldDefault(54);
				IL_30F:
				return this.Yield(45, new WaitForSeconds(0.5f));
				IL_32B:
				return this.YieldDefault(46);
				IL_4C1:
				return this.Yield(15, new WaitForSeconds(0.5f));
				IL_4DD:
				return this.YieldDefault(16);
				Block_43:
				goto IL_2CC1;
				IL_59D:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_5B9:
				return this.YieldDefault(10);
				Block_61:
				return this.Yield(57, new WaitForSeconds(0.5f));
				IL_779:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_7DD:
				goto IL_2CC1;
				Block_67:
				return this.Yield(17, new WaitForSeconds(0.5f));
				Block_68:
				return this.Yield(19, new WaitForSeconds(0.5f));
				IL_867:
				return this.Yield(7, new WaitForSeconds(0.5f));
				IL_882:
				return this.YieldDefault(8);
				Block_75:
				goto IL_2CC1;
				Block_79:
				return this.Yield(59, new WaitForSeconds(0.5f));
				IL_A34:
				return this.YieldDefault(48);
				Block_86:
				goto IL_2CC1;
				IL_AEE:
				return this.YieldDefault(20);
				IL_B25:
				goto IL_2CC1;
				Block_91:
				return this.Yield(33, new WaitForSeconds(0.5f));
				IL_C0D:
				return this.YieldDefault(58);
				Block_98:
				Block_101:
				IL_D33:
				Block_110:
				goto IL_2CC1;
				Block_112:
				return this.Yield(67, new WaitForSeconds(1f));
				IL_E8A:
				return this.Yield(39, new WaitForSeconds(0.5f));
				IL_EA6:
				return this.YieldDefault(40);
				Block_121:
				goto IL_2CC1;
				IL_FA2:
				return this.YieldDefault(62);
				Block_126:
				return this.Yield(41, new WaitForSeconds(0.5f));
				IL_115E:
				return this.Yield(31, new WaitForSeconds(0.5f));
				IL_117A:
				return this.YieldDefault(32);
				Block_132:
				return this.Yield(11, new WaitForSeconds(0.5f));
				IL_1201:
				goto IL_2CC1;
				IL_1282:
				return this.Yield(51, new WaitForSeconds(0.5f));
				IL_129E:
				return this.YieldDefault(52);
				IL_1335:
				return this.Yield(13, new WaitForSeconds(0.5f));
				IL_1351:
				return this.YieldDefault(14);
				IL_13DB:
				return this.Yield(63, new WaitForSeconds(0.5f));
				IL_13F7:
				return this.YieldDefault(64);
				Block_146:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_148E:
				goto IL_2CC1;
				Block_148:
				return this.Yield(5, new WaitForSeconds(1f));
				IL_1562:
				return this.Yield(29, new WaitForSeconds(0.5f));
				IL_157E:
				return this.YieldDefault(30);
				IL_16FB:
				return this.YieldDefault(34);
				Block_172:
				Block_183:
				Block_188:
				goto IL_2CC1;
				IL_19A0:
				return this.Yield(43, new WaitForSeconds(0.5f));
				IL_19BC:
				return this.YieldDefault(44);
				Block_192:
				IL_1A18:
				goto IL_2CC1;
				Block_193:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_1A94:
				IL_1B49:
				IL_1B7D:
				goto IL_2CC1;
				IL_1C8A:
				return this.YieldDefault(60);
				IL_1CC1:
				Block_221:
				goto IL_2CC1;
				Block_222:
				return this.Yield(49, new WaitForSeconds(0.5f));
				IL_1FB6:
				IL_2023:
				IL_2133:
				IL_2175:
				goto IL_2CC1;
				IL_21DF:
				return this.Yield(37, new WaitForSeconds(0.5f));
				IL_21FB:
				return this.YieldDefault(38);
				Block_248:
				return this.Yield(47, new WaitForSeconds(0.5f));
				IL_225D:
				goto IL_2CC1;
				IL_2341:
				return this.YieldDefault(18);
				Block_259:
				return this.Yield(23, new WaitForSeconds(0.5f));
				Block_260:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_261:
				return this.Yield(61, new WaitForSeconds(0.5f));
				Block_270:
				Block_272:
				goto IL_2CC1;
				IL_2540:
				return this.YieldDefault(50);
				Block_276:
				return this.Yield(65, new WaitForSeconds(0.5f));
				IL_2625:
				return this.YieldDefault(24);
				IL_2685:
				return this.Yield(35, new WaitForSeconds(0.5f));
				IL_26A1:
				return this.YieldDefault(36);
				IL_278F:
				return this.Yield(25, new WaitForSeconds(0.5f));
				IL_27AB:
				return this.YieldDefault(26);
				IL_2851:
				return this.YieldDefault(66);
				IL_2888:
				return this.Yield(21, new WaitForSeconds(0.5f));
				IL_28A4:
				return this.YieldDefault(22);
				IL_29C3:
				goto IL_2CC1;
				IL_2B17:
				return this.YieldDefault(12);
				Block_313:
				IL_2B73:
				Block_322:
				IL_2CC1:
				return false;
			}

			// Token: 0x06008301 RID: 33537 RVA: 0x01092C20 File Offset: 0x01090E20
			internal static bool o5rY0Yps16gmTdnIZD7R()
			{
				return true;
			}

			// Token: 0x06008302 RID: 33538 RVA: 0x01092C24 File Offset: 0x01090E24
			internal static bool UDaomxps4blaEbUkdbVh()
			{
				return false;
			}

			// Token: 0x040080D9 RID: 32985
			internal GameGui $mGameGui$39514;

			// Token: 0x040080DA RID: 32986
			internal StoryGui $mStoryGui$39515;

			// Token: 0x040080DB RID: 32987
			internal float $mStoryTimer$39516;

			// Token: 0x040080DC RID: 32988
			internal string $mHeroType$39517;

			// Token: 0x040080DD RID: 32989
			internal string $mHeroName$39518;

			// Token: 0x040080DE RID: 32990
			internal GameObject $mWaterGod$39519;

			// Token: 0x040080DF RID: 32991
			internal GameObject $mPlayer1$39520;

			// Token: 0x040080E0 RID: 32992
			internal CharacterDataClass $mCDat2$39521;

			// Token: 0x040080E1 RID: 32993
			internal CharacterDataClass $mCDat3$39522;

			// Token: 0x040080E2 RID: 32994
			internal int $$switch$6959$39523;

			// Token: 0x040080E3 RID: 32995
			internal GameObject $mPlayer2$39524;

			// Token: 0x040080E4 RID: 32996
			internal GameObject $mPlayer3$39525;

			// Token: 0x040080E5 RID: 32997
			internal M507_AnemoneDecision $self_$39526;
		}
	}

	// Token: 0x0200160A RID: 5642
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToAmmonite$39528 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008303 RID: 33539 RVA: 0x01092C28 File Offset: 0x01090E28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToAmmonite$39528(M507_AnemoneDecision self_)
		{
			if (237135 - 444761 != -207625)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (169295 - 307763 == -138468)
				{
					base..ctor();
					if (22001 - 136004 != -114002)
					{
						this.$self_$39535 = self_;
						if (2181 - 75444 == -73263)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008304 RID: 33540 RVA: 0x01092CC0 File Offset: 0x01090EC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M507_AnemoneDecision.$TalkToAmmonite$39528.$(this.$self_$39535);
		}

		// Token: 0x06008305 RID: 33541 RVA: 0x01092CD0 File Offset: 0x01090ED0
		internal static bool c18CuTpszwNqNIwb7w3M()
		{
			return true;
		}

		// Token: 0x06008306 RID: 33542 RVA: 0x01092CD4 File Offset: 0x01090ED4
		internal static bool mI6omrp9avu8xB5Yew4I()
		{
			return false;
		}

		// Token: 0x040080E6 RID: 32998
		internal M507_AnemoneDecision $self_$39535;

		// Token: 0x0200160B RID: 5643
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008307 RID: 33543 RVA: 0x01092CD8 File Offset: 0x01090ED8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M507_AnemoneDecision self_)
			{
				if (204414 - 357264 != -152849)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (106170 - 332299 != -226128)
					{
						base..ctor();
						if (212263 - 84796 != 127468)
						{
							this.$self_$39534 = self_;
							if (76458 - 583120 == -506662)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008308 RID: 33544 RVA: 0x01092D70 File Offset: 0x01090F70
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (74417 - 282706 != -208288)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_579;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (130319 - 556383 != -426064)
							{
								continue;
							}
							goto IL_4FF;
						}
						else
						{
							this.$mStoryTimer$39533 = 0f;
							if (123610 - 379547 == -255936)
							{
								continue;
							}
							this.$mStoryGui$39532.newStoryMessage("none", "Ammonite", Language.getMessage("M507_AnemoneDecision", 201), eTalkType.friend);
							if (23175 - 381560 == -358384)
							{
								continue;
							}
							this.$mStoryTimer$39533 = Time.time + 5f;
							if (62823 - 43653 != 19170)
							{
								continue;
							}
							goto IL_125;
						}
						break;
					case 3:
						goto IL_14C;
					case 4:
						goto IL_14C;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (91954 - 280662 != -188707)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							this.$mGameGui$39531.enabled = true;
							if (153214 - 267411 != -114197)
							{
								continue;
							}
							goto IL_224;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (148215 - 37382 != 110833)
							{
								continue;
							}
							goto IL_3F;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (55622 - 301635 != -246013)
							{
								continue;
							}
							this.YieldDefault(1);
							if (229906 - 219554 != 10353)
							{
								goto Block_30;
							}
							continue;
						}
						break;
					default:
						if (242238 - 576536 != -334298)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Talk To Ammonite");
					if (256290 - 435492 == -179201)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (152524 - 455918 != -303394)
						{
							continue;
						}
						break;
					}
					else
					{
						Game.mGameState = eGameState.Hold;
						if (249759 - 256082 == -6322)
						{
							continue;
						}
						this.$mPlayer$39529 = Game.mPlayer;
						if (33816 - 485389 != -451573)
						{
							continue;
						}
						this.$mAmmonite$39530 = GameObject.Find("Ammonite");
						if (260131 - 64857 != 195274)
						{
							continue;
						}
						if (this.$mAmmonite$39530)
						{
							if (178165 - 339383 == -161217)
							{
								continue;
							}
							if (this.$mPlayer$39529)
							{
								if (4602 - 520180 != -515578)
								{
									continue;
								}
								this.$mAmmonite$39530.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$mPlayer$39529.transform.position - this.$mAmmonite$39530.transform.position));
								if (25918 - 285289 == -259370)
								{
									continue;
								}
								this.$mPlayer$39529.SendMessage("turnToPos", this.$mAmmonite$39530.transform.position);
								if (80705 - 443830 == -363124)
								{
									continue;
								}
							}
						}
						this.$mGameGui$39531 = (GameGui)this.$self_$39534.GetComponent(typeof(GameGui));
						if (55510 - 358165 == -302654)
						{
							continue;
						}
						if (this.$mGameGui$39531)
						{
							if (6777 - 510163 != -503386)
							{
								continue;
							}
							this.$mGameGui$39531.close();
							if (136591 - 121887 != 14704)
							{
								continue;
							}
						}
						this.$mStoryGui$39532 = (StoryGui)this.$self_$39534.GetComponent(typeof(StoryGui));
						if (67386 - 136682 != -69296)
						{
							continue;
						}
						this.$mStoryGui$39532.startStoryMessage("none", "Ammonite", eTalkType.friend);
						if (132267 - 182750 != -50482)
						{
							goto Block_22;
						}
						continue;
					}
					IL_14C:
					if (this.$mStoryTimer$39533 > Time.time)
					{
						if (251161 - 7513 != 243648)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_140;
						}
						if (84813 - 17591 == 67223)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (74702 - 320196 == -245494)
						{
							break;
						}
					}
					else
					{
						this.$mStoryGui$39532.close();
						if (276684 - 85809 == 190875)
						{
							goto IL_3EE;
						}
					}
				}
				IL_3F:
				goto IL_579;
				IL_125:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_140:
				return this.YieldDefault(4);
				goto IL_579;
				IL_224:
				return this.Yield(6, new WaitForSeconds(1f));
				Block_22:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_3EE:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_28:
				Block_30:
				IL_4FF:
				IL_579:
				return false;
			}

			// Token: 0x06008309 RID: 33545 RVA: 0x01093308 File Offset: 0x01091508
			internal static bool rxWc1yp95rdptGgvvjuF()
			{
				return true;
			}

			// Token: 0x0600830A RID: 33546 RVA: 0x0109330C File Offset: 0x0109150C
			internal static bool vJNWUcp9pqwZmlKEMRQM()
			{
				return false;
			}

			// Token: 0x040080E7 RID: 32999
			internal GameObject $mPlayer$39529;

			// Token: 0x040080E8 RID: 33000
			internal GameObject $mAmmonite$39530;

			// Token: 0x040080E9 RID: 33001
			internal GameGui $mGameGui$39531;

			// Token: 0x040080EA RID: 33002
			internal StoryGui $mStoryGui$39532;

			// Token: 0x040080EB RID: 33003
			internal float $mStoryTimer$39533;

			// Token: 0x040080EC RID: 33004
			internal M507_AnemoneDecision $self_$39534;
		}
	}

	// Token: 0x0200160C RID: 5644
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$39536 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600830B RID: 33547 RVA: 0x01093310 File Offset: 0x01091510
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$39536(M507_AnemoneDecision self_)
		{
			if (283620 - 279510 != 4111)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (276205 - 127357 == 148848)
				{
					base..ctor();
					if (4839 - 226231 != -221391)
					{
						this.$self_$39541 = self_;
						if (149753 - 266914 == -117161)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600830C RID: 33548 RVA: 0x010933A8 File Offset: 0x010915A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M507_AnemoneDecision.$onDeadPlayer$39536.$(this.$self_$39541);
		}

		// Token: 0x0600830D RID: 33549 RVA: 0x010933B8 File Offset: 0x010915B8
		internal static bool uYuUVqp9V4nNtqP5WKRy()
		{
			return true;
		}

		// Token: 0x0600830E RID: 33550 RVA: 0x010933BC File Offset: 0x010915BC
		internal static bool oF92Lpp9tB11N5lIkC9R()
		{
			return false;
		}

		// Token: 0x040080ED RID: 33005
		internal M507_AnemoneDecision $self_$39541;

		// Token: 0x0200160D RID: 5645
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600830F RID: 33551 RVA: 0x010933C0 File Offset: 0x010915C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M507_AnemoneDecision self_)
			{
				if (27669 - 323673 != -296003)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (174587 - 227869 != -53281)
					{
						base..ctor();
						if (143268 - 130083 != 13186)
						{
							this.$self_$39540 = self_;
							if (281577 - 316536 == -34959)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008310 RID: 33552 RVA: 0x01093458 File Offset: 0x01091658
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (204082 - 155379 != 48703)
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
							if (66515 - 54485 != 12030)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_2D7;
							}
							if (28565 - 122531 != -93966)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (260052 - 460001 != -199949)
						{
							continue;
						}
						this.$mStoryGui$39537 = (StoryGui)this.$self_$39540.GetComponent(typeof(StoryGui));
						if (78203 - 497827 != -419624)
						{
							continue;
						}
						if (this.$mStoryGui$39537)
						{
							if (123810 - 573802 == -449991)
							{
								continue;
							}
							this.$mStoryGui$39537.close();
							if (10534 - 201659 == -191124)
							{
								continue;
							}
						}
						this.$mChangeGui$39538 = (ChangeGui)this.$self_$39540.GetComponent(typeof(ChangeGui));
						if (271530 - 9813 == 261718)
						{
							continue;
						}
						if (this.$mChangeGui$39538)
						{
							if (143639 - 135586 == 8054)
							{
								continue;
							}
							this.$mChangeGui$39538.close();
							if (132721 - 373212 == -240490)
							{
								continue;
							}
						}
						this.$mGameGui$39539 = (GameGui)this.$self_$39540.GetComponent(typeof(GameGui));
						if (297008 - 317991 == -20982)
						{
							continue;
						}
						if (this.$mGameGui$39539)
						{
							if (118690 - 23790 != 94900)
							{
								continue;
							}
							if (!this.$mGameGui$39539.enabled)
							{
								if (64845 - 37737 != 27108)
								{
									continue;
								}
								this.$mGameGui$39539.enabled = true;
								if (230609 - 220661 == 9949)
								{
									continue;
								}
							}
							this.$mGameGui$39539.openDeadMenu();
							if (59052 - 442668 != -383616)
							{
								continue;
							}
						}
						IL_2D7:
						this.YieldDefault(1);
						if (69026 - 93784 != -24758)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (21135 - 321485 == -300349)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (85020 - 45623 != 39397);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06008311 RID: 33553 RVA: 0x01093770 File Offset: 0x01091970
			internal static bool nbnM3Lp9NVxk0iuSqDu4()
			{
				return true;
			}

			// Token: 0x06008312 RID: 33554 RVA: 0x01093774 File Offset: 0x01091974
			internal static bool dPCb5mp9YWP2NOAVMUvS()
			{
				return false;
			}

			// Token: 0x040080EE RID: 33006
			internal StoryGui $mStoryGui$39537;

			// Token: 0x040080EF RID: 33007
			internal ChangeGui $mChangeGui$39538;

			// Token: 0x040080F0 RID: 33008
			internal GameGui $mGameGui$39539;

			// Token: 0x040080F1 RID: 33009
			internal M507_AnemoneDecision $self_$39540;
		}
	}

	// Token: 0x0200160E RID: 5646
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$39542 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008313 RID: 33555 RVA: 0x01093778 File Offset: 0x01091978
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$39542(Hashtable data, M507_AnemoneDecision self_)
		{
			if (16904 - 395325 != -378420)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (254671 - 421050 != -166378)
				{
					base..ctor();
					if (283920 - 386828 != -102907)
					{
						this.$data$39545 = data;
						if (188473 - 246773 != -58299)
						{
							this.$self_$39546 = self_;
							if (259182 - 507239 == -248057)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008314 RID: 33556 RVA: 0x01093834 File Offset: 0x01091A34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M507_AnemoneDecision.$onGameComplete$39542.$(this.$data$39545, this.$self_$39546);
		}

		// Token: 0x06008315 RID: 33557 RVA: 0x01093848 File Offset: 0x01091A48
		internal static bool Aa607Qp9c7sYWPAvFILJ()
		{
			return true;
		}

		// Token: 0x06008316 RID: 33558 RVA: 0x0109384C File Offset: 0x01091A4C
		internal static bool E6PaaKp9UPBPvhSOutt1()
		{
			return false;
		}

		// Token: 0x040080F2 RID: 33010
		internal Hashtable $data$39545;

		// Token: 0x040080F3 RID: 33011
		internal M507_AnemoneDecision $self_$39546;

		// Token: 0x0200160F RID: 5647
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008317 RID: 33559 RVA: 0x01093850 File Offset: 0x01091A50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M507_AnemoneDecision self_)
			{
				if (188930 - 369122 != -180192)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (27790 - 274870 == -247080)
					{
						base..ctor();
						if (125571 - 477526 != -351954)
						{
							this.$data$39543 = data;
							if (293402 - 400319 == -106917)
							{
								this.$self_$39544 = self_;
								if (283167 - 594250 == -311083)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008318 RID: 33560 RVA: 0x0109390C File Offset: 0x01091B0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (77228 - 363510 != -286282)
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
						this.$self_$39544.SendMessage("fadeOut");
						if (37100 - 501240 == -464139)
						{
							continue;
						}
						this.$self_$39544.StartCoroutine_Auto(this.$self_$39544.ReturnToTown());
						if (227197 - 361212 != -134015)
						{
							continue;
						}
						this.YieldDefault(1);
						if (111092 - 371681 != -260589)
						{
							continue;
						}
						goto IL_18D;
					default:
						if (166121 - 587581 != -421460)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Event Complete:" + this.$data$39543[31]);
					if (274485 - 245814 == 28671)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (95042 - 249949 != -154906)
							{
								goto Block_11;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (83555 - 462149 != -378593)
							{
								this.$self_$39544.cAFc9yLotKZ = Time.time;
								if (245522 - 599603 == -354081)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(4f));
				Block_11:
				IL_18D:
				return false;
			}

			// Token: 0x06008319 RID: 33561 RVA: 0x01093AB8 File Offset: 0x01091CB8
			internal static bool yhpGvkp9T7bktdXcve8D()
			{
				return true;
			}

			// Token: 0x0600831A RID: 33562 RVA: 0x01093ABC File Offset: 0x01091CBC
			internal static bool vUCDB2p93liYAQ4b5Ey5()
			{
				return false;
			}

			// Token: 0x040080F4 RID: 33012
			internal Hashtable $data$39543;

			// Token: 0x040080F5 RID: 33013
			internal M507_AnemoneDecision $self_$39544;
		}
	}

	// Token: 0x02001610 RID: 5648
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$39547 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600831B RID: 33563 RVA: 0x01093AC0 File Offset: 0x01091CC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$39547(M507_AnemoneDecision self_)
		{
			if (3751 - 555747 != -551996)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (177293 - 18824 != 158470)
				{
					base..ctor();
					if (182205 - 223074 != -40868)
					{
						this.$self_$39551 = self_;
						if (44294 - 237049 != -192754)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600831C RID: 33564 RVA: 0x01093B58 File Offset: 0x01091D58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M507_AnemoneDecision.$ReturnToTown$39547.$(this.$self_$39551);
		}

		// Token: 0x0600831D RID: 33565 RVA: 0x01093B68 File Offset: 0x01091D68
		internal static bool iVJmi9p9XlqqcS5f65Di()
		{
			return true;
		}

		// Token: 0x0600831E RID: 33566 RVA: 0x01093B6C File Offset: 0x01091D6C
		internal static bool ziAqMQp9QG1vFIw6DIx0()
		{
			return false;
		}

		// Token: 0x040080F6 RID: 33014
		internal M507_AnemoneDecision $self_$39551;

		// Token: 0x02001611 RID: 5649
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600831F RID: 33567 RVA: 0x01093B70 File Offset: 0x01091D70
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M507_AnemoneDecision self_)
			{
				if (101805 - 501667 != -399861)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (140058 - 523722 == -383664)
					{
						base..ctor();
						if (113069 - 123630 != -10560)
						{
							this.$self_$39550 = self_;
							if (83231 - 460257 != -377025)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008320 RID: 33568 RVA: 0x01093C08 File Offset: 0x01091E08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (229737 - 569237 != -339500)
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
						this.$self_$39550.LeaveGame();
						if (109193 - 575729 != -466536)
						{
							continue;
						}
						this.YieldDefault(1);
						if (84815 - 285229 != -200413)
						{
							goto Block_24;
						}
						continue;
					default:
						if (21483 - 304353 == -282869)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (49426 - 337820 == -288394)
					{
						Game.mStateTime = Time.time;
						if (22939 - 194616 == -171677)
						{
							this.$$switch$6961$39548 = PlayerData.SaveGuild;
							if (133802 - 586318 == -452516)
							{
								if (this.$$switch$6961$39548 == 1)
								{
									if (210465 - 403445 != -192980)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (112030 - 100490 == 11541)
									{
										continue;
									}
								}
								else if (this.$$switch$6961$39548 == 2)
								{
									if (42611 - 429769 != -387158)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (172220 - 195157 != -22937)
									{
										continue;
									}
								}
								else if (this.$$switch$6961$39548 == 3)
								{
									if (111075 - 291268 == -180192)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (203768 - 425164 == -221395)
									{
										continue;
									}
								}
								else if (this.$$switch$6961$39548 == 4)
								{
									if (249402 - 280094 != -30692)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (199222 - 547201 != -347979)
									{
										continue;
									}
								}
								else if (this.$$switch$6961$39548 == 5)
								{
									if (287804 - 210016 != 77788)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (291501 - 417693 == -126191)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (206966 - 421758 == -214791)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (291558 - 407665 != -116107)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (99213 - 568028 != -468815)
									{
										continue;
									}
								}
								this.$mGameGui$39549 = (GameGui)this.$self_$39550.GetComponent(typeof(GameGui));
								if (96423 - 178851 != -82427)
								{
									if (this.$mGameGui$39549)
									{
										if (67098 - 99653 == -32554)
										{
											continue;
										}
										this.$mGameGui$39549.close();
										if (100154 - 230963 == -130808)
										{
											continue;
										}
									}
									this.$self_$39550.SendMessage("fadeOut");
									if (113493 - 332036 != -218542)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_24:
				IL_3AD:
				return false;
			}

			// Token: 0x06008321 RID: 33569 RVA: 0x01093FD4 File Offset: 0x010921D4
			internal static bool sSAcuQp9knuAVQ2op9s9()
			{
				return true;
			}

			// Token: 0x06008322 RID: 33570 RVA: 0x01093FD8 File Offset: 0x010921D8
			internal static bool d3xg5fp9GkVn6tkjiVW0()
			{
				return false;
			}

			// Token: 0x040080F7 RID: 33015
			internal int $$switch$6961$39548;

			// Token: 0x040080F8 RID: 33016
			internal GameGui $mGameGui$39549;

			// Token: 0x040080F9 RID: 33017
			internal M507_AnemoneDecision $self_$39550;
		}
	}

	// Token: 0x02001612 RID: 5650
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$39552 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008323 RID: 33571 RVA: 0x01093FDC File Offset: 0x010921DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$39552(M507_AnemoneDecision self_)
		{
			if (89386 - 97499 != -8112)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (191107 - 510639 == -319532)
				{
					base..ctor();
					if (215260 - 423504 != -208243)
					{
						this.$self_$39555 = self_;
						if (134043 - 168156 == -34113)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008324 RID: 33572 RVA: 0x01094074 File Offset: 0x01092274
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M507_AnemoneDecision.$ReturnToGuild$39552.$(this.$self_$39555);
		}

		// Token: 0x06008325 RID: 33573 RVA: 0x01094084 File Offset: 0x01092284
		internal static bool d3EnaGp9HjS0JBFIdDWb()
		{
			return true;
		}

		// Token: 0x06008326 RID: 33574 RVA: 0x01094088 File Offset: 0x01092288
		internal static bool eQD0xAp9W1xraoUFGGMq()
		{
			return false;
		}

		// Token: 0x040080FA RID: 33018
		internal M507_AnemoneDecision $self_$39555;

		// Token: 0x02001613 RID: 5651
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008327 RID: 33575 RVA: 0x0109408C File Offset: 0x0109228C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M507_AnemoneDecision self_)
			{
				if (197269 - 325301 != -128031)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (181275 - 309106 != -127830)
					{
						base..ctor();
						if (94921 - 169400 != -74478)
						{
							this.$self_$39554 = self_;
							if (206526 - 70702 == 135824)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008328 RID: 33576 RVA: 0x01094124 File Offset: 0x01092324
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (229846 - 468826 != -238980)
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
						this.$self_$39554.LeaveGame();
						if (52462 - 134179 == -81716)
						{
							continue;
						}
						this.YieldDefault(1);
						if (158970 - 337423 != -178453)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (293869 - 99312 != 194557)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (242456 - 41302 == 201154)
					{
						Game.mStateTime = Time.time;
						if (169233 - 273501 == -104268)
						{
							Game.mNextGameCode = 31;
							if (276309 - 130547 == 145762)
							{
								this.$mGameGui$39553 = (GameGui)this.$self_$39554.GetComponent(typeof(GameGui));
								if (203920 - 1332 == 202588)
								{
									if (this.$mGameGui$39553)
									{
										if (152736 - 123549 != 29187)
										{
											continue;
										}
										this.$mGameGui$39553.close();
										if (148141 - 192328 != -44187)
										{
											continue;
										}
									}
									this.$self_$39554.SendMessage("fadeOut");
									if (138043 - 215033 == -76990)
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

			// Token: 0x06008329 RID: 33577 RVA: 0x01094300 File Offset: 0x01092500
			internal static bool BaXxPGp9AMmZfwGWtc6w()
			{
				return true;
			}

			// Token: 0x0600832A RID: 33578 RVA: 0x01094304 File Offset: 0x01092504
			internal static bool le0gHHp9lHWaVWSoVM4d()
			{
				return false;
			}

			// Token: 0x040080FB RID: 33019
			internal GameGui $mGameGui$39553;

			// Token: 0x040080FC RID: 33020
			internal M507_AnemoneDecision $self_$39554;
		}
	}

	// Token: 0x02001614 RID: 5652
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$39556 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600832B RID: 33579 RVA: 0x01094308 File Offset: 0x01092508
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$39556(M507_AnemoneDecision self_)
		{
			if (43551 - 286216 != -242664)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (247307 - 389889 != -142581)
				{
					base..ctor();
					if (13862 - 337907 != -324044)
					{
						this.$self_$39560 = self_;
						if (78920 - 550885 == -471965)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600832C RID: 33580 RVA: 0x010943A0 File Offset: 0x010925A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M507_AnemoneDecision.$ReturnToCamp$39556.$(this.$self_$39560);
		}

		// Token: 0x0600832D RID: 33581 RVA: 0x010943B0 File Offset: 0x010925B0
		internal static bool UZ50CZp9yCH2LURZKOyu()
		{
			return true;
		}

		// Token: 0x0600832E RID: 33582 RVA: 0x010943B4 File Offset: 0x010925B4
		internal static bool HwBbZAp9SKE1tJCUvK2f()
		{
			return false;
		}

		// Token: 0x040080FD RID: 33021
		internal M507_AnemoneDecision $self_$39560;

		// Token: 0x02001615 RID: 5653
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600832F RID: 33583 RVA: 0x010943B8 File Offset: 0x010925B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M507_AnemoneDecision self_)
			{
				if (44040 - 35461 != 8580)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (264662 - 232614 == 32048)
					{
						base..ctor();
						if (178527 - 438020 != -259492)
						{
							this.$self_$39559 = self_;
							if (275440 - 482621 != -207180)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008330 RID: 33584 RVA: 0x01094450 File Offset: 0x01092650
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (10030 - 506799 != -496768)
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
						this.$self_$39559.LeaveGame();
						if (17495 - 61830 != -44335)
						{
							continue;
						}
						this.YieldDefault(1);
						if (41328 - 219835 != -178507)
						{
							continue;
						}
						goto IL_363;
					default:
						if (41921 - 194314 == -152392)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (116055 - 259247 != -143191)
					{
						Game.mStateTime = Time.time;
						if (103966 - 292456 != -188489)
						{
							this.$$switch$6963$39557 = PlayerData.SaveGuild;
							if (223017 - 212861 == 10156)
							{
								if (this.$$switch$6963$39557 == 1)
								{
									if (71439 - 572326 == -500886)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (283301 - 299117 == -15815)
									{
										continue;
									}
								}
								else if (this.$$switch$6963$39557 == 2)
								{
									if (186808 - 261469 == -74660)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (67622 - 528955 != -461333)
									{
										continue;
									}
								}
								else if (this.$$switch$6963$39557 == 3)
								{
									if (248828 - 184819 != 64009)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (164168 - 568683 == -404514)
									{
										continue;
									}
								}
								else if (this.$$switch$6963$39557 == 4)
								{
									if (97079 - 236579 == -139499)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (258261 - 126359 != 131902)
									{
										continue;
									}
								}
								else if (this.$$switch$6963$39557 == 5)
								{
									if (250637 - 18091 != 232546)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (5805 - 500412 == -494606)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (40114 - 311577 == -271462)
									{
										continue;
									}
								}
								this.$mGameGui$39558 = (GameGui)this.$self_$39559.GetComponent(typeof(GameGui));
								if (206422 - 174415 != 32008)
								{
									if (this.$mGameGui$39558)
									{
										if (175594 - 24129 == 151466)
										{
											continue;
										}
										this.$mGameGui$39558.close();
										if (101313 - 286948 == -185634)
										{
											continue;
										}
									}
									this.$self_$39559.SendMessage("fadeOut");
									if (137018 - 303319 != -166300)
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

			// Token: 0x06008331 RID: 33585 RVA: 0x010947D4 File Offset: 0x010929D4
			internal static bool mKsnZbp9obni7LLXaHo9()
			{
				return true;
			}

			// Token: 0x06008332 RID: 33586 RVA: 0x010947D8 File Offset: 0x010929D8
			internal static bool hqDITGp9E0PTv3JlSb4I()
			{
				return false;
			}

			// Token: 0x040080FE RID: 33022
			internal int $$switch$6963$39557;

			// Token: 0x040080FF RID: 33023
			internal GameGui $mGameGui$39558;

			// Token: 0x04008100 RID: 33024
			internal M507_AnemoneDecision $self_$39559;
		}
	}
}
