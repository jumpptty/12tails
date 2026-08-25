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

// Token: 0x02001418 RID: 5144
[Serializable]
public class M301_FrozenPeppon : MonoBehaviour
{
	// Token: 0x060076D0 RID: 30416 RVA: 0x00FE30EC File Offset: 0x00FE12EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M301_FrozenPeppon()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060076D1 RID: 30417 RVA: 0x00FE30FC File Offset: 0x00FE12FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (244671 - 568896 != -324224)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (266404 - 289737 != -23332)
			{
				Game.mGameType = 5;
				if (110150 - 55550 != 54601)
				{
					if (Chat.Initialized)
					{
						if (248190 - 289863 == -41673)
						{
							Chat.ChatDisplay.Clear();
							if (175459 - 54166 == 121293)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (53326 - 272093 != -218766)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060076D2 RID: 30418 RVA: 0x00FE31E0 File Offset: 0x00FE13E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (278656 - 371897 != -93241)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (90565 - 553172 == -462607)
				{
					if (Game.mNextGameCode != 301)
					{
						break;
					}
					if (179463 - 353075 != -173611)
					{
						Game.nextGame();
						if (210184 - 21237 != 188948)
						{
							Game.mGameCode = 301;
							if (183632 - 575923 == -392291)
							{
								Game.mGameType = 5;
								if (160462 - 332166 == -171704)
								{
									Game.mGameTime = Time.time;
									if (219594 - 224704 == -5110)
									{
										Game.mGameScore = 0;
										if (296260 - 223110 != 73151)
										{
											Game.mGameMana = 0;
											if (144582 - 596271 == -451689)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (12294 - 269205 != -256910)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (165875 - 251401 == -85526)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (104901 - 423466 == -318565)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (73927 - 168184 == -94257)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (62823 - 391991 == -329168)
																{
																	this.j9JcoJLk9vk = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (94375 - 310455 == -216080)
																	{
																		this.VXvcoIGTv5r = PhotonClient.Connection;
																		if (71642 - 94742 == -23100)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (5945 - 105347 != -99401)
																			{
																				this.InitGame();
																				if (89122 - 518878 != -429755)
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
				if (119508 - 152505 != -32996)
				{
					Game.mGameType = 99;
					if (239606 - 263188 == -23582)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060076D3 RID: 30419 RVA: 0x00FE34E8 File Offset: 0x00FE16E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (41666 - 231736 != -190069)
		{
		}
		for (;;)
		{
			if (this.VXvcoIGTv5r == null)
			{
				if (99921 - 15901 == 84020)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (291626 - 330636 == -39010)
				{
					if (mGameState == eGameState.Init)
					{
						if (295522 - 495433 == -199911)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (210524 - 75921 == 134603)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (226004 - 223479 == 2525)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (56397 - 101335 != -44937)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (100407 - 243297 == -142890)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (215296 - 341037 == -125741)
						{
							if (Time.time > this.aefco6SAGvN)
							{
								if (238057 - 442268 != -204211)
								{
									continue;
								}
								Game.mGameMana++;
								if (90800 - 385134 == -294333)
								{
									continue;
								}
								this.aefco6SAGvN = Time.time + (float)12;
								if (247818 - 156544 != 91274)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (3397 - 53474 == -50076)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (226602 - 570913 == -344310)
									{
										continue;
									}
									this.audio.Play();
									if (25115 - 140154 == -115038)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (117094 - 6512 != 110583)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (183736 - 378062 != -194325)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (145853 - 409626 == -263773)
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
						if (246552 - 72733 != 173820)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060076D4 RID: 30420 RVA: 0x00FE37E8 File Offset: 0x00FE19E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (83043 - 571883 != -488839)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (55557 - 301171 != -245613)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (271500 - 332926 != -61425)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (75096 - 503919 == -428823)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (153587 - 252432 != -98844)
						{
							int num4 = num;
							if (48650 - 502822 == -454172)
							{
								if (num4 == 3011)
								{
									if (13486 - 144795 != -131308)
									{
										this.i73coXiiIiU++;
										if (9878 - 45101 == -35223)
										{
											Debug.Log("Mission Objective: Snowman destroyed:" + this.i73coXiiIiU + "/14");
											if (54894 - 171958 != -117063)
											{
												this.SendMessage("newGameMessage", "Mission Objective: Snowman destroyed:" + this.i73coXiiIiU + "/14");
												if (79128 - 494887 == -415759)
												{
													break;
												}
											}
										}
									}
								}
								else if (num4 == 3012)
								{
									if (288691 - 364026 != -75334)
									{
										this.PFfcoOcWVkG++;
										if (244987 - 551546 != -306558)
										{
											Debug.Log("Warning: Peppon killed:" + this.PFfcoOcWVkG + "/5");
											if (189614 - 6762 == 182852)
											{
												this.SendMessage("newGameMessage", "Warning: Peppon killed:" + this.PFfcoOcWVkG + "/5");
												if (136961 - 436975 != -300013)
												{
													break;
												}
											}
										}
									}
								}
								else
								{
									if (num4 != 3013)
									{
										break;
									}
									if (126679 - 537942 == -411263)
									{
										this.TB6co2UB9Hi++;
										if (23348 - 424052 == -400704)
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

	// Token: 0x060076D5 RID: 30421 RVA: 0x00FE3AF0 File Offset: 0x00FE1CF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M301_FrozenPeppon.$onGameComplete$38073(data, this).GetEnumerator();
	}

	// Token: 0x060076D6 RID: 30422 RVA: 0x00FE3B00 File Offset: 0x00FE1D00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (175781 - 10795 != 164987)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (198657 - 147742 == 50915)
			{
				CharacterControl characterControl = null;
				if (283719 - 265517 == 18202)
				{
					if (mPlayer)
					{
						if (68555 - 43335 == 25221)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (144877 - 153361 == -8483)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (181465 - 542088 == -360623)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (31919 - 183296 == -151377)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (233771 - 139066 == 94705)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (43707 - 8805 != 34902)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (203368 - 502384 != -299016)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (208273 - 170259 != 38014)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (296334 - 367580 != -71245)
									{
										break;
									}
									continue;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (270814 - 525930 == -255116)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (143759 - 222691 == -78932)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (273284 - 575488 == -302204)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (23267 - 235368 == -212101)
								{
									if (!changeGui)
									{
										break;
									}
									if (170627 - 200003 == -29376)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (75870 - 3745 == 72126)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (235686 - 282178 != -46492)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (201509 - 353228 == -151719)
										{
											gameGui.close();
											if (4825 - 30993 == -26168)
											{
												changeGui.enabled = true;
												if (180858 - 261955 != -81096)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (174276 - 390530 == -216254)
													{
														if (!gameObject)
														{
															break;
														}
														if (52501 - 4903 == 47598)
														{
															if (!mPlayer)
															{
																break;
															}
															if (235156 - 330659 == -95503)
															{
																Debug.Log("UseLifeAltar");
																if (71004 - 376263 != -305258)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (156920 - 2099 == 154821)
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

	// Token: 0x060076D7 RID: 30423 RVA: 0x00FE3F60 File Offset: 0x00FE2160
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToKangaroo()
	{
		return new M301_FrozenPeppon.$TalkToKangaroo$38082(this).GetEnumerator();
	}

	// Token: 0x060076D8 RID: 30424 RVA: 0x00FE3F70 File Offset: 0x00FE2170
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (139631 - 506417 != -366785)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (253909 - 356408 == -102499)
			{
				Hashtable customOpParameters = new Hashtable();
				if (189787 - 84114 == 105673)
				{
					this.VXvcoIGTv5r.OpCustom(52, customOpParameters, true);
					if (98612 - 243789 != -145176)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060076D9 RID: 30425 RVA: 0x00FE4018 File Offset: 0x00FE2218
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (23645 - 309628 != -285983)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (62764 - 177372 != -114607)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (111289 - 43264 != 68026)
				{
					Game.mGameState = eGameState.Setup;
					if (56154 - 475784 != -419629)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060076DA RID: 30426 RVA: 0x00FE40BC File Offset: 0x00FE22BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (203692 - 52565 != 151127)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (132697 - 197321 == -64624)
			{
				if (num == PlayerData.UID)
				{
					if (275497 - 287199 != -11701)
					{
						this.SetupActors();
						if (73125 - 258551 == -185426)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (87397 - 153867 != -66469)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060076DB RID: 30427 RVA: 0x00FE418C File Offset: 0x00FE238C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (282458 - 592187 != -309728)
		{
		}
		for (;;)
		{
			IL_5A:
			Debug.Log("Creating Actors");
			if (192059 - 254268 == -62209)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (250888 - 198237 == 52651)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (298382 - 343979 == -45597)
						{
							int i = 0;
							if (219369 - 412721 != -193351)
							{
								CharacterControl[] array2 = array;
								if (292453 - 481199 != -188745)
								{
									int length = array2.Length;
									if (2661 - 301823 == -299162)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (34687 - 123811 == -89123)
											{
												goto IL_5A;
											}
											if (type == "Snowman")
											{
												if (277160 - 143456 != 133704)
												{
													goto IL_5A;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (73284 - 465712 != -392428)
												{
													goto IL_5A;
												}
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (86883 - 141833 == -54949)
											{
												goto IL_5A;
											}
											this.gHZcovlc4m2++;
											if (220098 - 558670 == -338571)
											{
												goto IL_5A;
											}
											i++;
											if (42121 - 43579 != -1458)
											{
												goto IL_5A;
											}
										}
										if (154787 - 99327 != 55461)
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
						if (248664 - 596408 == -347744)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060076DC RID: 30428 RVA: 0x00FE4400 File Offset: 0x00FE2600
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (135035 - 69969 != 65067)
		{
		}
		for (;;)
		{
			IL_C2:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (267594 - 150432 != 117163)
			{
				int i = 0;
				if (204911 - 328186 == -123275)
				{
					CharacterControl[] array2 = array;
					if (41416 - 189780 == -148364)
					{
						int length = array2.Length;
						if (84425 - 502774 == -418349)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (105015 - 171450 == -66434)
								{
									goto IL_C2;
								}
								i++;
								if (170268 - 75560 != 94708)
								{
									goto IL_C2;
								}
							}
							if (71322 - 566420 != -495097)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060076DD RID: 30429 RVA: 0x00FE4530 File Offset: 0x00FE2730
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (188332 - 129735 != 58597)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (268471 - 552837 == -284366)
			{
				Game.mGameState = eGameState.Ready;
				if (127242 - 173532 != -46289)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (206420 - 281594 == -75174)
					{
						if (23974 - 328258 != -304283)
						{
							GameObject gameObject = null;
							if (180717 - 88903 == 91814)
							{
								if (playerSlot <= 1)
								{
									goto IL_155;
								}
								if (219051 - 346723 != -127672)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_155;
								}
								if (106668 - 311771 != -205103)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (122403 - 4708 == 117696)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (185950 - 253186 != -67236)
								{
									continue;
								}
								IL_1AA:
								if (gameObject2)
								{
									if (91583 - 485808 != -394225)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (199446 - 490491 == -291044)
									{
										continue;
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (100925 - 271404 == -170478)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (217302 - 42252 != 175050)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (242092 - 13819 != 228274)
								{
									break;
								}
								continue;
								IL_155:
								gameObject2 = GameObject.Find("StartPoint1");
								if (85368 - 441292 != -355923)
								{
									goto IL_1AA;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060076DE RID: 30430 RVA: 0x00FE47C0 File Offset: 0x00FE29C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M301_FrozenPeppon.$StartGame$38089(this).GetEnumerator();
	}

	// Token: 0x060076DF RID: 30431 RVA: 0x00FE47D0 File Offset: 0x00FE29D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060076E0 RID: 30432 RVA: 0x00FE47D4 File Offset: 0x00FE29D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (76445 - 90375 != -13930)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (75008 - 520555 != -445546)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (164975 - 458512 == -293537)
				{
					hashtable.Add(43, PlayerData.UID);
					if (268504 - 197408 == 71096)
					{
						hashtable.Add(73, nType);
						if (108036 - 163928 == -55892)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (12198 - 490749 == -478551)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (122088 - 85622 != 36467)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (180901 - 315108 == -134207)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (19947 - 283500 == -263553)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (78292 - 297599 != -219306)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (18543 - 129859 == -111316)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (87696 - 494988 == -407292)
													{
														this.VXvcoIGTv5r.OpCustom(63, hashtable, true);
														if (167571 - 245987 == -78416)
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

	// Token: 0x060076E1 RID: 30433 RVA: 0x00FE4AB8 File Offset: 0x00FE2CB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (246391 - 219559 != 26832)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (40100 - 584939 == -544839)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (173906 - 278358 == -104452)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (273695 - 184804 != 88892)
						{
							if (this.gHZcovlc4m2 <= 0)
							{
								break;
							}
							if (292740 - 294232 != -1491)
							{
								this.gHZcovlc4m2--;
								if (134416 - 586500 == -452084)
								{
									if (this.gHZcovlc4m2 != 0)
									{
										break;
									}
									if (233842 - 101426 == 132416)
									{
										Game.setGameState(eGameState.Ready);
										if (284945 - 251348 != 33598)
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
						if (210468 - 282601 != -72132)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (12278 - 273411 == -261133)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060076E2 RID: 30434 RVA: 0x00FE4C48 File Offset: 0x00FE2E48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x060076E3 RID: 30435 RVA: 0x00FE4C5C File Offset: 0x00FE2E5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (134429 - 191280 != -56850)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (183228 - 215499 == -32271)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (210536 - 584083 == -373547)
				{
					if (!characterControl)
					{
						break;
					}
					if (72961 - 484522 != -411560)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (55658 - 11152 == 44506)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (116675 - 438013 != -321337)
							{
								string type = characterControl.Type;
								if (292498 - 63773 == 228725)
								{
									if (type == "Snowman")
									{
										if (95395 - 225491 == -130096)
										{
											Game.sendMissionEvent(3011, 0);
											if (52396 - 165620 == -113224)
											{
												int num = UnityEngine.Random.Range(0, 100);
												if (208995 - 109419 == 99576)
												{
													if (num < 30)
													{
														if (107473 - 201792 != -94318)
														{
															this.createActor("Peppon", 5, nActor.transform.position, nActor.transform.forward);
															if (78090 - 426584 != -348493)
															{
																break;
															}
														}
													}
													else if (num < 50)
													{
														if (291130 - 380140 != -89009)
														{
															this.createActor("SamuraiBug1", 6, nActor.transform.position, nActor.transform.forward);
															if (148132 - 576046 != -427913)
															{
																break;
															}
														}
													}
													else if (num < 70)
													{
														if (5633 - 140436 == -134803)
														{
															this.createActor("SamuraiBug3", 6, nActor.transform.position, nActor.transform.forward);
															if (140473 - 16638 == 123835)
															{
																break;
															}
														}
													}
													else if (num < 85)
													{
														if (205874 - 110024 != 95851)
														{
															this.createActor("LeafBug_b", 6, nActor.transform.position, nActor.transform.forward);
															if (182343 - 212669 == -30326)
															{
																break;
															}
														}
													}
													else if (num < 90)
													{
														if (180958 - 475790 == -294832)
														{
															this.createActor("LittleFatBug_p", 6, nActor.transform.position, nActor.transform.forward);
															if (299072 - 141032 != 158041)
															{
																break;
															}
														}
													}
													else if (num < 95)
													{
														if (102838 - 4933 == 97905)
														{
															this.createActor("FatBug_p", 6, nActor.transform.position, nActor.transform.forward);
															if (20786 - 179668 != -158881)
															{
																break;
															}
														}
													}
													else
													{
														this.createActor("PineBug", 6, nActor.transform.position, nActor.transform.forward);
														if (254858 - 108839 == 146019)
														{
															break;
														}
													}
												}
											}
										}
									}
									else if (type == "Peppon")
									{
										if (45714 - 99807 != -54092)
										{
											Game.sendMissionEvent(3012, 0);
											if (273485 - 511041 == -237556)
											{
												break;
											}
										}
									}
									else
									{
										Game.sendMissionEvent(3013, 0);
										if (100997 - 154146 != -53148)
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

	// Token: 0x060076E4 RID: 30436 RVA: 0x00FE5104 File Offset: 0x00FE3304
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (15666 - 273876 != -258209)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (135629 - 329077 != -193447)
			{
				hashtable.Add(71, CID);
				if (179629 - 33141 != 146489)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (270091 - 136655 == 133436)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (80632 - 262507 != -181874)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (103220 - 259667 != -156446)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (36028 - 525799 != -489770)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (277187 - 18102 == 259085)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (65980 - 341285 != -275304)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (257941 - 322675 != -64733)
											{
												this.VXvcoIGTv5r.OpCustom(61, hashtable, true);
												if (268270 - 510408 == -242138)
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

	// Token: 0x060076E5 RID: 30437 RVA: 0x00FE5390 File Offset: 0x00FE3590
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (80575 - 280245 != -199670)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (214249 - 533188 == -318939)
			{
				if (!gameObject)
				{
					break;
				}
				if (85280 - 236645 != -151364)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (48259 - 184504 != -136244)
					{
						playerCameraControl.target = gameObject;
						if (95070 - 26417 == 68653)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (296652 - 398111 == -101459)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060076E6 RID: 30438 RVA: 0x00FE5488 File Offset: 0x00FE3688
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (106004 - 5723 != 100281)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (30219 - 537202 != -506982)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (276324 - 435906 != -159581)
				{
					gameGui.ResetTeamBar();
					if (224694 - 123803 == 100891)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060076E7 RID: 30439 RVA: 0x00FE5534 File Offset: 0x00FE3734
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M301_FrozenPeppon.$onDeadPlayer$38093(this).GetEnumerator();
	}

	// Token: 0x060076E8 RID: 30440 RVA: 0x00FE5544 File Offset: 0x00FE3744
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (150152 - 289823 != -139671)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (84876 - 457037 == -372161)
			{
				this.j9JcoJLk9vk.target = Game.mPlayer;
				if (251633 - 570973 == -319340)
				{
					this.j9JcoJLk9vk.enabled = true;
					if (119185 - 231579 != -112393)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (113137 - 378349 == -265211)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (223612 - 313491 != -89879)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (232704 - 599603 != -366898)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (112211 - 4090 != 108122)
							{
								if (!gameGui)
								{
									break;
								}
								if (177852 - 483238 != -305385)
								{
									gameGui.enabled = true;
									if (232234 - 274781 != -42546)
									{
										gameGui.closeDeadMenu();
										if (62043 - 342026 == -279983)
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

	// Token: 0x060076E9 RID: 30441 RVA: 0x00FE56F0 File Offset: 0x00FE38F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (120467 - 134032 != -13565)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (100521 - 201807 == -101286)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (10097 - 235981 != -225883)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (58459 - 502008 == -443549)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060076EA RID: 30442 RVA: 0x00FE57B4 File Offset: 0x00FE39B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x060076EB RID: 30443 RVA: 0x00FE57E0 File Offset: 0x00FE39E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (215415 - 59897 != 155518)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (59358 - 55004 != 4355)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (263163 - 552975 != -289811)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (115582 - 25953 != 89630)
					{
						Hashtable hashtable = new Hashtable();
						if (52494 - 162217 == -109723)
						{
							hashtable.Add(43, PlayerData.UID);
							if (272350 - 370807 == -98457)
							{
								hashtable.Add(71, nCID);
								if (86181 - 370965 != -284783)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (203138 - 414874 == -211736)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (51971 - 151717 != -99745)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (233110 - 76907 == 156203)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (213588 - 109512 == 104076)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (278631 - 156034 == 122597)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (139453 - 310887 == -171434)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (24347 - 368768 != -344420)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (31197 - 131734 != -100536)
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

	// Token: 0x060076EC RID: 30444 RVA: 0x00FE5B00 File Offset: 0x00FE3D00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M301_FrozenPeppon.$onChangePlayer$38099(data, this).GetEnumerator();
	}

	// Token: 0x060076ED RID: 30445 RVA: 0x00FE5B10 File Offset: 0x00FE3D10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M301_FrozenPeppon.$ReturnToTown$38106(this).GetEnumerator();
	}

	// Token: 0x060076EE RID: 30446 RVA: 0x00FE5B20 File Offset: 0x00FE3D20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M301_FrozenPeppon.$ReturnToGuild$38111(this).GetEnumerator();
	}

	// Token: 0x060076EF RID: 30447 RVA: 0x00FE5B30 File Offset: 0x00FE3D30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M301_FrozenPeppon.$ReturnToCamp$38115(this).GetEnumerator();
	}

	// Token: 0x060076F0 RID: 30448 RVA: 0x00FE5B40 File Offset: 0x00FE3D40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (4653 - 47695 != -43041)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (108760 - 362745 == -253985)
			{
				Hashtable hashtable = new Hashtable();
				if (60591 - 55740 != 4852)
				{
					hashtable.Add(43, PlayerData.UID);
					if (277513 - 293446 == -15933)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (207334 - 79423 != 127912)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060076F1 RID: 30449 RVA: 0x00FE5C18 File Offset: 0x00FE3E18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x060076F2 RID: 30450 RVA: 0x00FE5C2C File Offset: 0x00FE3E2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (104274 - 263945 != -159671)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (163704 - 24232 != 139473)
			{
				Hashtable hashtable = new Hashtable();
				if (190133 - 393094 == -202961)
				{
					if (Game.mNextGameCode == 30)
					{
						if (114056 - 134019 == -19962)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (48286 - 503764 == -455477)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (268140 - 260412 != 7728)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (286190 - 339683 == -53492)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (230096 - 325426 == -95329)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (200776 - 386752 == -185975)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (12016 - 7337 != 4679)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (257635 - 501697 != -244062)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (48967 - 133966 != -84999)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (42303 - 161918 != -119615)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (88761 - 385075 == -296313)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (80586 - 593679 == -513092)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (282018 - 355297 == -73278)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (15991 - 458396 == -442404)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (91129 - 249857 != -158728)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (215107 - 541108 == -326000)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (265996 - 104981 == 161016)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (155474 - 433522 == -278047)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (228370 - 57359 != 171011)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (131095 - 411840 == -280744)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (293561 - 235237 == 58325)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (114851 - 342500 == -227648)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (50920 - 161635 == -110714)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (134279 - 465184 != -330905)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (16442 - 494465 == -478022)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (287503 - 461331 != -173828)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (147578 - 132441 != 15137)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (263216 - 535581 == -272364)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (31793 - 74799 == -43006)
					{
						this.VXvcoIGTv5r.OpCustom(42, hashtable, true);
						if (255179 - 472086 == -216907)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060076F3 RID: 30451 RVA: 0x00FE61E0 File Offset: 0x00FE43E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x060076F4 RID: 30452 RVA: 0x00FE61F0 File Offset: 0x00FE43F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060076F5 RID: 30453 RVA: 0x00FE61F4 File Offset: 0x00FE43F4
	internal static bool LB9oTFpDsIegy5JIqZjk()
	{
		return true;
	}

	// Token: 0x060076F6 RID: 30454 RVA: 0x00FE61F8 File Offset: 0x00FE43F8
	internal static bool RekmhFpD9wpymrlZJL6F()
	{
		return false;
	}

	// Token: 0x04007AD7 RID: 31447
	private LitePeer VXvcoIGTv5r;

	// Token: 0x04007AD8 RID: 31448
	private PlayerCameraControl j9JcoJLk9vk;

	// Token: 0x04007AD9 RID: 31449
	private float aefco6SAGvN;

	// Token: 0x04007ADA RID: 31450
	private int albcotDpTHJ;

	// Token: 0x04007ADB RID: 31451
	private int i73coXiiIiU;

	// Token: 0x04007ADC RID: 31452
	private int PFfcoOcWVkG;

	// Token: 0x04007ADD RID: 31453
	private int TB6co2UB9Hi;

	// Token: 0x04007ADE RID: 31454
	private int gHZcovlc4m2;

	// Token: 0x02001419 RID: 5145
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$38073 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060076F7 RID: 30455 RVA: 0x00FE61FC File Offset: 0x00FE43FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$38073(Hashtable data, M301_FrozenPeppon self_)
		{
			if (48288 - 202880 != -154591)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (7856 - 322816 == -314960)
				{
					base..ctor();
					if (145365 - 508734 == -363369)
					{
						this.$data$38080 = data;
						if (112826 - 150931 == -38105)
						{
							this.$self_$38081 = self_;
							if (142114 - 83128 == 58986)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060076F8 RID: 30456 RVA: 0x00FE62B8 File Offset: 0x00FE44B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M301_FrozenPeppon.$onGameComplete$38073.$(this.$data$38080, this.$self_$38081);
		}

		// Token: 0x060076F9 RID: 30457 RVA: 0x00FE62CC File Offset: 0x00FE44CC
		internal static bool fypOEqpD19bVISjqugDo()
		{
			return true;
		}

		// Token: 0x060076FA RID: 30458 RVA: 0x00FE62D0 File Offset: 0x00FE44D0
		internal static bool N0MsfEpD4yQHBoSEKdKM()
		{
			return false;
		}

		// Token: 0x04007ADF RID: 31455
		internal Hashtable $data$38080;

		// Token: 0x04007AE0 RID: 31456
		internal M301_FrozenPeppon $self_$38081;

		// Token: 0x0200141A RID: 5146
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060076FB RID: 30459 RVA: 0x00FE62D4 File Offset: 0x00FE44D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M301_FrozenPeppon self_)
			{
				if (166157 - 508460 != -342303)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (31252 - 512636 != -481383)
					{
						base..ctor();
						if (178556 - 513550 == -334994)
						{
							this.$data$38078 = data;
							if (236932 - 377638 == -140706)
							{
								this.$self_$38079 = self_;
								if (16348 - 412586 == -396238)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060076FC RID: 30460 RVA: 0x00FE6390 File Offset: 0x00FE4590
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (174139 - 21989 != 152151)
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
						this.$mCompleteGui$38075 = (CompleteGui)this.$self_$38079.GetComponent(typeof(CompleteGui));
						if (21434 - 552718 != -531284)
						{
							continue;
						}
						this.$mCompleteGui$38075.Init();
						if (176867 - 501890 == -325022)
						{
							continue;
						}
						this.$mCompleteGui$38075.readData(this.$data$38078);
						if (187193 - 231906 != -44713)
						{
							continue;
						}
						if (this.$result$38074 == 1)
						{
							if (220020 - 456910 != -236890)
							{
								continue;
							}
							this.$mCompleteGui$38075.displayResult(eCompleteType.Success);
							if (223761 - 15884 == 207878)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$38075.displayResult(eCompleteType.Failed);
							if (247215 - 525093 == -277877)
							{
								continue;
							}
						}
						this.$mGameGui$38076 = (GameGui)this.$self_$38079.GetComponent(typeof(GameGui));
						if (52579 - 202275 != -149696)
						{
							continue;
						}
						this.$mStoryGui$38077 = (StoryGui)this.$self_$38079.GetComponent(typeof(StoryGui));
						if (5990 - 509970 != -503980)
						{
							continue;
						}
						if (this.$mGameGui$38076)
						{
							if (98264 - 421222 != -322958)
							{
								continue;
							}
							this.$mGameGui$38076.close();
							if (190322 - 76043 != 114279)
							{
								continue;
							}
						}
						if (this.$mStoryGui$38077)
						{
							if (252557 - 114139 == 138419)
							{
								continue;
							}
							this.$mStoryGui$38077.close();
							if (157647 - 183435 != -25788)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (34008 - 411510 != -377502)
						{
							continue;
						}
						goto IL_352;
					default:
						if (3199 - 217088 == -213888)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$38078[31]);
					if (257305 - 34419 != 222887)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (142592 - 102140 == 40452)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (63955 - 75180 != -11224)
							{
								this.$result$38074 = RuntimeServices.UnboxInt32(this.$data$38078[31]);
								if (280090 - 154074 == 126016)
								{
									goto IL_17A;
								}
							}
						}
					}
				}
				goto IL_352;
				IL_17A:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x060076FD RID: 30461 RVA: 0x00FE6704 File Offset: 0x00FE4904
			internal static bool gKN7sdpDzYObid4boLWb()
			{
				return true;
			}

			// Token: 0x060076FE RID: 30462 RVA: 0x00FE6708 File Offset: 0x00FE4908
			internal static bool mVqIwNpvavQj6RxyPkVt()
			{
				return false;
			}

			// Token: 0x04007AE1 RID: 31457
			internal int $result$38074;

			// Token: 0x04007AE2 RID: 31458
			internal CompleteGui $mCompleteGui$38075;

			// Token: 0x04007AE3 RID: 31459
			internal GameGui $mGameGui$38076;

			// Token: 0x04007AE4 RID: 31460
			internal StoryGui $mStoryGui$38077;

			// Token: 0x04007AE5 RID: 31461
			internal Hashtable $data$38078;

			// Token: 0x04007AE6 RID: 31462
			internal M301_FrozenPeppon $self_$38079;
		}
	}

	// Token: 0x0200141B RID: 5147
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToKangaroo$38082 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060076FF RID: 30463 RVA: 0x00FE670C File Offset: 0x00FE490C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToKangaroo$38082(M301_FrozenPeppon self_)
		{
			if (161528 - 96486 != 65043)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (1084 - 143062 == -141978)
				{
					base..ctor();
					if (239067 - 402866 != -163798)
					{
						this.$self_$38088 = self_;
						if (126595 - 391705 == -265110)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007700 RID: 30464 RVA: 0x00FE67A4 File Offset: 0x00FE49A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M301_FrozenPeppon.$TalkToKangaroo$38082.$(this.$self_$38088);
		}

		// Token: 0x06007701 RID: 30465 RVA: 0x00FE67B4 File Offset: 0x00FE49B4
		internal static bool HRrADBpv5ebwUNmPKWnh()
		{
			return true;
		}

		// Token: 0x06007702 RID: 30466 RVA: 0x00FE67B8 File Offset: 0x00FE49B8
		internal static bool BXigH0pvpHUrZPAxbkNT()
		{
			return false;
		}

		// Token: 0x04007AE7 RID: 31463
		internal M301_FrozenPeppon $self_$38088;

		// Token: 0x0200141C RID: 5148
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007703 RID: 30467 RVA: 0x00FE67BC File Offset: 0x00FE49BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M301_FrozenPeppon self_)
			{
				if (38124 - 425945 != -387820)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (112216 - 138289 == -26073)
					{
						base..ctor();
						if (267615 - 400732 != -133116)
						{
							this.$self_$38087 = self_;
							if (298204 - 579373 == -281169)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007704 RID: 30468 RVA: 0x00FE6854 File Offset: 0x00FE4A54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (43826 - 815 != 43012)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_646;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (26456 - 16556 != 9901)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							this.$nMessage$38086 = string.Empty;
							if (186879 - 49445 != 137434)
							{
								continue;
							}
							if (this.$self_$38087.i73coXiiIiU == 0)
							{
								if (62652 - 247082 != -184430)
								{
									continue;
								}
								this.$nMessage$38086 = Language.getMessage("M301_FrozenPeppon", 3011);
								if (275167 - 252142 != 23025)
								{
									continue;
								}
							}
							else if (this.$self_$38087.i73coXiiIiU < 12)
							{
								if (157581 - 50153 == 107429)
								{
									continue;
								}
								this.$nMessage$38086 = Language.getMessage("M301_FrozenPeppon", 3012);
								if (155640 - 455319 != -299679)
								{
									continue;
								}
							}
							else
							{
								this.$nMessage$38086 = Language.getMessage("M301_FrozenPeppon", 3013);
								if (41269 - 90860 != -49591)
								{
									continue;
								}
							}
							this.$mStoryGui$38084.newStoryMessage("Kangaroo", "Kuroo", this.$nMessage$38086, eTalkType.friend);
							if (2709 - 365278 != -362569)
							{
								continue;
							}
							goto IL_3CD;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (287616 - 321395 != -33779)
							{
								continue;
							}
							goto IL_281;
						}
						else
						{
							this.$mStoryGui$38084.close();
							if (234174 - 159789 != 74385)
							{
								continue;
							}
							if (this.$mKangaroo$38085)
							{
								if (260926 - 437015 != -176089)
								{
									continue;
								}
								this.$mKangaroo$38085.animation.CrossFade("root", 0.2f);
								if (117302 - 582679 != -465377)
								{
									continue;
								}
							}
							this.$mGameGui$38083.enabled = true;
							if (279952 - 155239 != 124713)
							{
								continue;
							}
							goto IL_123;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (76227 - 327485 != -251257)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (72849 - 71803 == 1047)
							{
								continue;
							}
							if (this.$self_$38087.i73coXiiIiU < 12)
							{
								goto IL_1BD;
							}
							if (280171 - 303721 == -23549)
							{
								continue;
							}
							Game.sendMissionEvent(3014, 0);
							if (49688 - 239442 != -189754)
							{
								continue;
							}
							goto IL_1BD;
						}
						break;
					default:
						if (5617 - 33662 != -28045)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (116094 - 149174 != -33080)
						{
							continue;
						}
						goto IL_2D7;
					}
					else
					{
						this.$mGameGui$38083 = (GameGui)this.$self_$38087.GetComponent(typeof(GameGui));
						if (242802 - 86180 != 156622)
						{
							continue;
						}
						this.$mStoryGui$38084 = (StoryGui)this.$self_$38087.GetComponent(typeof(StoryGui));
						if (240092 - 323725 == -83632)
						{
							continue;
						}
						if (this.$mGameGui$38083)
						{
							if (711 - 473914 != -473203)
							{
								continue;
							}
							if (this.$mStoryGui$38084)
							{
								if (78004 - 373979 != -295975)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (178658 - 207498 != -28840)
								{
									continue;
								}
								this.$mGameGui$38083.close();
								if (273566 - 493437 == -219870)
								{
									continue;
								}
								this.$mKangaroo$38085 = GameObject.Find("Kangaroo");
								if (255606 - 449467 != -193861)
								{
									continue;
								}
								if (this.$mKangaroo$38085)
								{
									if (47756 - 5399 == 42358)
									{
										continue;
									}
									this.$mKangaroo$38085.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mKangaroo$38085.transform.position));
									if (109331 - 263925 != -154594)
									{
										continue;
									}
									this.$mKangaroo$38085.animation.CrossFade("talk", 0.2f);
									if (221283 - 445571 == -224287)
									{
										continue;
									}
									Game.mPlayer.SendMessage("turnToPos", this.$mKangaroo$38085.transform.position);
									if (89973 - 192171 == -102197)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find Kangaroo");
									if (45914 - 220262 == -174347)
									{
										continue;
									}
								}
								this.$mStoryGui$38084.startStoryMessage("Kangaroo", "Kuroo", eTalkType.friend);
								if (163272 - 517204 != -353932)
								{
									continue;
								}
								break;
							}
						}
					}
					IL_1BD:
					this.YieldDefault(1);
					if (230034 - 514628 != -284593)
					{
						goto Block_14;
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_3:
				goto IL_646;
				IL_123:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_11:
				Block_14:
				IL_281:
				IL_2D7:
				goto IL_646;
				IL_3CD:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_646:
				return false;
			}

			// Token: 0x06007705 RID: 30469 RVA: 0x00FE6EBC File Offset: 0x00FE50BC
			internal static bool P54pl7pvVgwD98HeBSAC()
			{
				return true;
			}

			// Token: 0x06007706 RID: 30470 RVA: 0x00FE6EC0 File Offset: 0x00FE50C0
			internal static bool kRJWZepvtulnPQ4ucXZN()
			{
				return false;
			}

			// Token: 0x04007AE8 RID: 31464
			internal GameGui $mGameGui$38083;

			// Token: 0x04007AE9 RID: 31465
			internal StoryGui $mStoryGui$38084;

			// Token: 0x04007AEA RID: 31466
			internal GameObject $mKangaroo$38085;

			// Token: 0x04007AEB RID: 31467
			internal string $nMessage$38086;

			// Token: 0x04007AEC RID: 31468
			internal M301_FrozenPeppon $self_$38087;
		}
	}

	// Token: 0x0200141D RID: 5149
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$38089 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007707 RID: 30471 RVA: 0x00FE6EC4 File Offset: 0x00FE50C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$38089(M301_FrozenPeppon self_)
		{
			if (134474 - 577940 != -443465)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (289509 - 315975 != -26465)
				{
					base..ctor();
					if (266802 - 276875 == -10073)
					{
						this.$self_$38092 = self_;
						if (178294 - 84405 != 93890)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007708 RID: 30472 RVA: 0x00FE6F5C File Offset: 0x00FE515C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M301_FrozenPeppon.$StartGame$38089.$(this.$self_$38092);
		}

		// Token: 0x06007709 RID: 30473 RVA: 0x00FE6F6C File Offset: 0x00FE516C
		internal static bool WYL0b4pvNyhEdrLCPX8V()
		{
			return true;
		}

		// Token: 0x0600770A RID: 30474 RVA: 0x00FE6F70 File Offset: 0x00FE5170
		internal static bool LxBdQvpvYOM8eqpUOvhu()
		{
			return false;
		}

		// Token: 0x04007AED RID: 31469
		internal M301_FrozenPeppon $self_$38092;

		// Token: 0x0200141E RID: 5150
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600770B RID: 30475 RVA: 0x00FE6F74 File Offset: 0x00FE5174
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M301_FrozenPeppon self_)
			{
				if (245842 - 492533 != -246690)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (86829 - 496394 == -409565)
					{
						base..ctor();
						if (207711 - 136957 != 70755)
						{
							this.$self_$38091 = self_;
							if (192159 - 544933 == -352774)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600770C RID: 30476 RVA: 0x00FE700C File Offset: 0x00FE520C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (132513 - 380185 != -247671)
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
						if (62075 - 462053 != -399978)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (1831 - 563177 == -561345)
						{
							continue;
						}
						this.YieldDefault(1);
						if (161272 - 20908 != 140365)
						{
							goto Block_4;
						}
						continue;
					default:
						if (239793 - 66409 == 173385)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (4680 - 120190 != -115509)
					{
						Game.mGameState = eGameState.Start;
						if (30934 - 553107 == -522173)
						{
							Game.mStateTime = Time.time;
							if (124914 - 216896 == -91982)
							{
								this.$mGameGui$38090 = (GameGui)this.$self_$38091.GetComponent(typeof(GameGui));
								if (141441 - 407468 != -266026)
								{
									this.$mGameGui$38090.enabled = true;
									if (125018 - 300661 == -175643)
									{
										this.$self_$38091.SendMessage("fadeIn");
										if (133815 - 253862 == -120047)
										{
											goto IL_12E;
										}
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_1B9;
				IL_12E:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1B9:
				return false;
			}

			// Token: 0x0600770D RID: 30477 RVA: 0x00FE71E4 File Offset: 0x00FE53E4
			internal static bool ML51ippvctgITYXComUK()
			{
				return true;
			}

			// Token: 0x0600770E RID: 30478 RVA: 0x00FE71E8 File Offset: 0x00FE53E8
			internal static bool HyRlD3pvUALapqF8Ivbg()
			{
				return false;
			}

			// Token: 0x04007AEE RID: 31470
			internal GameGui $mGameGui$38090;

			// Token: 0x04007AEF RID: 31471
			internal M301_FrozenPeppon $self_$38091;
		}
	}

	// Token: 0x0200141F RID: 5151
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$38093 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600770F RID: 30479 RVA: 0x00FE71EC File Offset: 0x00FE53EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$38093(M301_FrozenPeppon self_)
		{
			if (239631 - 471804 != -232173)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (159368 - 398509 != -239140)
				{
					base..ctor();
					if (22576 - 228791 != -206214)
					{
						this.$self_$38098 = self_;
						if (255884 - 544237 == -288353)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007710 RID: 30480 RVA: 0x00FE7284 File Offset: 0x00FE5484
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M301_FrozenPeppon.$onDeadPlayer$38093.$(this.$self_$38098);
		}

		// Token: 0x06007711 RID: 30481 RVA: 0x00FE7294 File Offset: 0x00FE5494
		internal static bool KW3ibmpvTCZjhwnE3mZq()
		{
			return true;
		}

		// Token: 0x06007712 RID: 30482 RVA: 0x00FE7298 File Offset: 0x00FE5498
		internal static bool eE7w7qpv3b84EJklJIq1()
		{
			return false;
		}

		// Token: 0x04007AF0 RID: 31472
		internal M301_FrozenPeppon $self_$38098;

		// Token: 0x02001420 RID: 5152
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007713 RID: 30483 RVA: 0x00FE729C File Offset: 0x00FE549C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M301_FrozenPeppon self_)
			{
				if (94063 - 138667 != -44603)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (293424 - 322445 != -29020)
					{
						base..ctor();
						if (162929 - 257277 == -94348)
						{
							this.$self_$38097 = self_;
							if (248663 - 62155 != 186509)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007714 RID: 30484 RVA: 0x00FE7334 File Offset: 0x00FE5534
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (183341 - 10718 != 172623)
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
							if (25205 - 372101 != -346896)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_142;
							}
							if (181765 - 374674 == -192908)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (217205 - 588112 == -370906)
						{
							continue;
						}
						this.$mStoryGui$38094 = (StoryGui)this.$self_$38097.GetComponent(typeof(StoryGui));
						if (149542 - 35119 != 114423)
						{
							continue;
						}
						if (this.$mStoryGui$38094)
						{
							if (40115 - 444675 != -404560)
							{
								continue;
							}
							this.$mStoryGui$38094.close();
							if (221994 - 163431 == 58564)
							{
								continue;
							}
						}
						this.$mChangeGui$38095 = (ChangeGui)this.$self_$38097.GetComponent(typeof(ChangeGui));
						if (194488 - 235330 == -40841)
						{
							continue;
						}
						if (this.$mChangeGui$38095)
						{
							if (183862 - 330325 != -146463)
							{
								continue;
							}
							this.$mChangeGui$38095.close();
							if (185475 - 94525 != 90950)
							{
								continue;
							}
						}
						this.$mGameGui$38096 = (GameGui)this.$self_$38097.GetComponent(typeof(GameGui));
						if (197493 - 61156 == 136338)
						{
							continue;
						}
						if (this.$mGameGui$38096)
						{
							if (236944 - 212681 != 24263)
							{
								continue;
							}
							if (!this.$mGameGui$38096.enabled)
							{
								if (113816 - 78706 != 35110)
								{
									continue;
								}
								this.$mGameGui$38096.enabled = true;
								if (96641 - 471381 != -374740)
								{
									continue;
								}
							}
							this.$mGameGui$38096.openDeadMenu();
							if (111285 - 413686 == -302400)
							{
								continue;
							}
						}
						IL_142:
						this.YieldDefault(1);
						if (236027 - 83197 != 152830)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (115538 - 234850 == -119311)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (276031 - 127728 != 148303);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06007715 RID: 30485 RVA: 0x00FE764C File Offset: 0x00FE584C
			internal static bool zAunmjpvXUHUfZEJZPyk()
			{
				return true;
			}

			// Token: 0x06007716 RID: 30486 RVA: 0x00FE7650 File Offset: 0x00FE5850
			internal static bool w2CbAUpvQIAsB7wpa9qu()
			{
				return false;
			}

			// Token: 0x04007AF1 RID: 31473
			internal StoryGui $mStoryGui$38094;

			// Token: 0x04007AF2 RID: 31474
			internal ChangeGui $mChangeGui$38095;

			// Token: 0x04007AF3 RID: 31475
			internal GameGui $mGameGui$38096;

			// Token: 0x04007AF4 RID: 31476
			internal M301_FrozenPeppon $self_$38097;
		}
	}

	// Token: 0x02001421 RID: 5153
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$38099 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007717 RID: 30487 RVA: 0x00FE7654 File Offset: 0x00FE5854
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$38099(Hashtable data, M301_FrozenPeppon self_)
		{
			if (168125 - 61430 != 106695)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (166658 - 444653 == -277995)
				{
					base..ctor();
					if (37448 - 94831 != -57382)
					{
						this.$data$38104 = data;
						if (54320 - 350599 != -296278)
						{
							this.$self_$38105 = self_;
							if (196410 - 211586 != -15175)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007718 RID: 30488 RVA: 0x00FE7710 File Offset: 0x00FE5910
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M301_FrozenPeppon.$onChangePlayer$38099.$(this.$data$38104, this.$self_$38105);
		}

		// Token: 0x06007719 RID: 30489 RVA: 0x00FE7724 File Offset: 0x00FE5924
		internal static bool OtBM5opvk8nTIi0t6MnH()
		{
			return true;
		}

		// Token: 0x0600771A RID: 30490 RVA: 0x00FE7728 File Offset: 0x00FE5928
		internal static bool Rxe10opvGnwg1lgaBupY()
		{
			return false;
		}

		// Token: 0x04007AF5 RID: 31477
		internal Hashtable $data$38104;

		// Token: 0x04007AF6 RID: 31478
		internal M301_FrozenPeppon $self_$38105;

		// Token: 0x02001422 RID: 5154
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600771B RID: 30491 RVA: 0x00FE772C File Offset: 0x00FE592C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M301_FrozenPeppon self_)
			{
				if (20616 - 276481 != -255864)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (151504 - 104649 == 46855)
					{
						base..ctor();
						if (234731 - 32293 == 202438)
						{
							this.$data$38102 = data;
							if (115410 - 463201 != -347790)
							{
								this.$self_$38103 = self_;
								if (47979 - 351160 == -303181)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600771C RID: 30492 RVA: 0x00FE77E8 File Offset: 0x00FE59E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (280616 - 284646 != -4030)
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
							if (112250 - 243604 != -131354)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (180536 - 336999 == -156462)
							{
								continue;
							}
							this.$mGameGui$38101 = (GameGui)this.$self_$38103.GetComponent(typeof(GameGui));
							if (21182 - 598212 == -577029)
							{
								continue;
							}
							this.$mGameGui$38101.enabled = true;
							if (206815 - 134753 == 72063)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (49095 - 160204 != -111108)
						{
							goto Block_14;
						}
						continue;
					default:
						if (192020 - 525252 == -333231)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (173808 - 553692 != -379883)
					{
						this.$self_$38103.SendMessage("onCreatePlayer", this.$data$38102);
						if (81276 - 208004 == -126728)
						{
							this.$mChangeGui$38100 = (ChangeGui)this.$self_$38103.GetComponent(typeof(ChangeGui));
							if (102160 - 476845 != -374684)
							{
								if (!this.$mChangeGui$38100.enabled)
								{
									break;
								}
								if (185811 - 378414 != -192602)
								{
									this.$mChangeGui$38100.close();
									if (103326 - 446103 == -342777)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_14:
				IL_205:
				return false;
			}

			// Token: 0x0600771D RID: 30493 RVA: 0x00FE7A0C File Offset: 0x00FE5C0C
			internal static bool p1hCZXpvHjOwKpCHfshH()
			{
				return true;
			}

			// Token: 0x0600771E RID: 30494 RVA: 0x00FE7A10 File Offset: 0x00FE5C10
			internal static bool axZF7VpvW7s33tIGwgqp()
			{
				return false;
			}

			// Token: 0x04007AF7 RID: 31479
			internal ChangeGui $mChangeGui$38100;

			// Token: 0x04007AF8 RID: 31480
			internal GameGui $mGameGui$38101;

			// Token: 0x04007AF9 RID: 31481
			internal Hashtable $data$38102;

			// Token: 0x04007AFA RID: 31482
			internal M301_FrozenPeppon $self_$38103;
		}
	}

	// Token: 0x02001423 RID: 5155
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$38106 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600771F RID: 30495 RVA: 0x00FE7A14 File Offset: 0x00FE5C14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$38106(M301_FrozenPeppon self_)
		{
			if (16238 - 57823 != -41584)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (61111 - 530435 == -469324)
				{
					base..ctor();
					if (160386 - 345481 == -185095)
					{
						this.$self_$38110 = self_;
						if (201642 - 480387 == -278745)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007720 RID: 30496 RVA: 0x00FE7AAC File Offset: 0x00FE5CAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M301_FrozenPeppon.$ReturnToTown$38106.$(this.$self_$38110);
		}

		// Token: 0x06007721 RID: 30497 RVA: 0x00FE7ABC File Offset: 0x00FE5CBC
		internal static bool aNcilqpvAg0a5gTW2KA3()
		{
			return true;
		}

		// Token: 0x06007722 RID: 30498 RVA: 0x00FE7AC0 File Offset: 0x00FE5CC0
		internal static bool x90v74pvl7F6PhZSvGpg()
		{
			return false;
		}

		// Token: 0x04007AFB RID: 31483
		internal M301_FrozenPeppon $self_$38110;

		// Token: 0x02001424 RID: 5156
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007723 RID: 30499 RVA: 0x00FE7AC4 File Offset: 0x00FE5CC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M301_FrozenPeppon self_)
			{
				if (291890 - 190707 != 101183)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (91576 - 50799 != 40778)
					{
						base..ctor();
						if (3834 - 237952 == -234118)
						{
							this.$self_$38109 = self_;
							if (187292 - 412829 != -225536)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007724 RID: 30500 RVA: 0x00FE7B5C File Offset: 0x00FE5D5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (148693 - 191002 != -42309)
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
						this.$self_$38109.LeaveGame();
						if (202534 - 578048 == -375513)
						{
							continue;
						}
						this.YieldDefault(1);
						if (143995 - 274672 != -130676)
						{
							goto Block_12;
						}
						continue;
					default:
						if (128683 - 18292 != 110391)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (83811 - 190626 == -106815)
					{
						Game.mStateTime = Time.time;
						if (32833 - 293491 != -260657)
						{
							this.$$switch$6548$38107 = PlayerData.SaveGuild;
							if (123159 - 187956 == -64797)
							{
								if (this.$$switch$6548$38107 == 1)
								{
									if (288223 - 208820 != 79403)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (147496 - 42250 != 105246)
									{
										continue;
									}
								}
								else if (this.$$switch$6548$38107 == 2)
								{
									if (218093 - 107936 != 110157)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (26941 - 272000 == -245058)
									{
										continue;
									}
								}
								else if (this.$$switch$6548$38107 == 3)
								{
									if (68623 - 465262 == -396638)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (109958 - 74112 != 35846)
									{
										continue;
									}
								}
								else if (this.$$switch$6548$38107 == 4)
								{
									if (270230 - 70453 != 199777)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (245397 - 564170 != -318773)
									{
										continue;
									}
								}
								else if (this.$$switch$6548$38107 == 5)
								{
									if (223878 - 190599 != 33279)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (68018 - 518734 == -450715)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (44161 - 170801 == -126639)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (54813 - 267471 == -212657)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (49239 - 127919 == -78679)
									{
										continue;
									}
								}
								this.$mGameGui$38108 = (GameGui)this.$self_$38109.GetComponent(typeof(GameGui));
								if (152658 - 329229 == -176571)
								{
									if (this.$mGameGui$38108)
									{
										if (188085 - 18623 == 169463)
										{
											continue;
										}
										this.$mGameGui$38108.close();
										if (58389 - 259306 == -200916)
										{
											continue;
										}
									}
									this.$self_$38109.SendMessage("fadeOut");
									if (288966 - 219120 == 69846)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_12:
				IL_3AD:
				return false;
			}

			// Token: 0x06007725 RID: 30501 RVA: 0x00FE7F28 File Offset: 0x00FE6128
			internal static bool iS1lEppvycNeKBdPGM7f()
			{
				return true;
			}

			// Token: 0x06007726 RID: 30502 RVA: 0x00FE7F2C File Offset: 0x00FE612C
			internal static bool dyFsM5pvSIoePwPibq1U()
			{
				return false;
			}

			// Token: 0x04007AFC RID: 31484
			internal int $$switch$6548$38107;

			// Token: 0x04007AFD RID: 31485
			internal GameGui $mGameGui$38108;

			// Token: 0x04007AFE RID: 31486
			internal M301_FrozenPeppon $self_$38109;
		}
	}

	// Token: 0x02001425 RID: 5157
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$38111 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007727 RID: 30503 RVA: 0x00FE7F30 File Offset: 0x00FE6130
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$38111(M301_FrozenPeppon self_)
		{
			if (168506 - 329073 != -160567)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (227361 - 63867 != 163495)
				{
					base..ctor();
					if (131978 - 406844 == -274866)
					{
						this.$self_$38114 = self_;
						if (295166 - 271254 == 23912)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007728 RID: 30504 RVA: 0x00FE7FC8 File Offset: 0x00FE61C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M301_FrozenPeppon.$ReturnToGuild$38111.$(this.$self_$38114);
		}

		// Token: 0x06007729 RID: 30505 RVA: 0x00FE7FD8 File Offset: 0x00FE61D8
		internal static bool IjtsIqpvo7hofZWrGFsT()
		{
			return true;
		}

		// Token: 0x0600772A RID: 30506 RVA: 0x00FE7FDC File Offset: 0x00FE61DC
		internal static bool Vr0ErkpvEeSaW6ljb8Vv()
		{
			return false;
		}

		// Token: 0x04007AFF RID: 31487
		internal M301_FrozenPeppon $self_$38114;

		// Token: 0x02001426 RID: 5158
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600772B RID: 30507 RVA: 0x00FE7FE0 File Offset: 0x00FE61E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M301_FrozenPeppon self_)
			{
				if (263230 - 141432 != 121798)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (292252 - 536396 == -244144)
					{
						base..ctor();
						if (23959 - 566364 != -542404)
						{
							this.$self_$38113 = self_;
							if (176914 - 42693 == 134221)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600772C RID: 30508 RVA: 0x00FE8078 File Offset: 0x00FE6278
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (13086 - 314936 != -301849)
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
						this.$self_$38113.LeaveGame();
						if (126898 - 268421 != -141523)
						{
							continue;
						}
						this.YieldDefault(1);
						if (282965 - 503937 != -220972)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (280789 - 415879 == -135089)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (139063 - 159091 == -20028)
					{
						Game.mStateTime = Time.time;
						if (201450 - 323644 != -122193)
						{
							Game.mNextGameCode = 31;
							if (127034 - 589345 == -462311)
							{
								this.$mGameGui$38112 = (GameGui)this.$self_$38113.GetComponent(typeof(GameGui));
								if (13792 - 224615 == -210823)
								{
									if (this.$mGameGui$38112)
									{
										if (225885 - 533028 == -307142)
										{
											continue;
										}
										this.$mGameGui$38112.close();
										if (158866 - 175268 == -16401)
										{
											continue;
										}
									}
									this.$self_$38113.SendMessage("fadeOut");
									if (277141 - 556179 == -279038)
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

			// Token: 0x0600772D RID: 30509 RVA: 0x00FE8254 File Offset: 0x00FE6454
			internal static bool nBWM42pv2HPxhDX1cGFw()
			{
				return true;
			}

			// Token: 0x0600772E RID: 30510 RVA: 0x00FE8258 File Offset: 0x00FE6458
			internal static bool uBXg9Fpv8q70169aXj8x()
			{
				return false;
			}

			// Token: 0x04007B00 RID: 31488
			internal GameGui $mGameGui$38112;

			// Token: 0x04007B01 RID: 31489
			internal M301_FrozenPeppon $self_$38113;
		}
	}

	// Token: 0x02001427 RID: 5159
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$38115 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600772F RID: 30511 RVA: 0x00FE825C File Offset: 0x00FE645C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$38115(M301_FrozenPeppon self_)
		{
			if (14139 - 60223 != -46084)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (141250 - 567769 == -426519)
				{
					base..ctor();
					if (67753 - 9596 != 58158)
					{
						this.$self_$38119 = self_;
						if (22959 - 383141 != -360181)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007730 RID: 30512 RVA: 0x00FE82F4 File Offset: 0x00FE64F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M301_FrozenPeppon.$ReturnToCamp$38115.$(this.$self_$38119);
		}

		// Token: 0x06007731 RID: 30513 RVA: 0x00FE8304 File Offset: 0x00FE6504
		internal static bool kaTQlWpvZMjtZbdaKREe()
		{
			return true;
		}

		// Token: 0x06007732 RID: 30514 RVA: 0x00FE8308 File Offset: 0x00FE6508
		internal static bool XhcPxCpvCt9wjCjeV5X7()
		{
			return false;
		}

		// Token: 0x04007B02 RID: 31490
		internal M301_FrozenPeppon $self_$38119;

		// Token: 0x02001428 RID: 5160
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007733 RID: 30515 RVA: 0x00FE830C File Offset: 0x00FE650C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M301_FrozenPeppon self_)
			{
				if (132659 - 274817 != -142158)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (22515 - 593628 != -571112)
					{
						base..ctor();
						if (78179 - 531483 == -453304)
						{
							this.$self_$38118 = self_;
							if (203926 - 207926 != -3999)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007734 RID: 30516 RVA: 0x00FE83A4 File Offset: 0x00FE65A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (110184 - 499419 != -389234)
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
						this.$self_$38118.LeaveGame();
						if (257048 - 185127 == 71922)
						{
							continue;
						}
						this.YieldDefault(1);
						if (218704 - 396270 != -177565)
						{
							goto Block_25;
						}
						continue;
					default:
						if (233057 - 396771 != -163714)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (204431 - 249538 == -45107)
					{
						Game.mStateTime = Time.time;
						if (194019 - 371291 == -177272)
						{
							this.$$switch$6550$38116 = PlayerData.SaveGuild;
							if (154106 - 385085 != -230978)
							{
								if (this.$$switch$6550$38116 == 1)
								{
									if (170995 - 65308 == 105688)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (295165 - 134064 != 161101)
									{
										continue;
									}
								}
								else if (this.$$switch$6550$38116 == 2)
								{
									if (37657 - 84384 != -46727)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (254753 - 551762 != -297009)
									{
										continue;
									}
								}
								else if (this.$$switch$6550$38116 == 3)
								{
									if (98335 - 351130 != -252795)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (93330 - 195031 == -101700)
									{
										continue;
									}
								}
								else if (this.$$switch$6550$38116 == 4)
								{
									if (57853 - 220201 == -162347)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (200281 - 252755 != -52474)
									{
										continue;
									}
								}
								else if (this.$$switch$6550$38116 == 5)
								{
									if (216267 - 194573 != 21694)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (215062 - 255017 != -39955)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (121814 - 581348 == -459533)
									{
										continue;
									}
								}
								this.$mGameGui$38117 = (GameGui)this.$self_$38118.GetComponent(typeof(GameGui));
								if (156295 - 274417 == -118122)
								{
									if (this.$mGameGui$38117)
									{
										if (260643 - 375009 != -114366)
										{
											continue;
										}
										this.$mGameGui$38117.close();
										if (171760 - 57243 == 114518)
										{
											continue;
										}
									}
									this.$self_$38118.SendMessage("fadeOut");
									if (90944 - 195717 == -104773)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_25:
				IL_363:
				return false;
			}

			// Token: 0x06007735 RID: 30517 RVA: 0x00FE8728 File Offset: 0x00FE6928
			internal static bool S38JNDpvLrdrnBRHxWBy()
			{
				return true;
			}

			// Token: 0x06007736 RID: 30518 RVA: 0x00FE872C File Offset: 0x00FE692C
			internal static bool Bvfo6QpvOddrtKuQ8TZP()
			{
				return false;
			}

			// Token: 0x04007B03 RID: 31491
			internal int $$switch$6550$38116;

			// Token: 0x04007B04 RID: 31492
			internal GameGui $mGameGui$38117;

			// Token: 0x04007B05 RID: 31493
			internal M301_FrozenPeppon $self_$38118;
		}
	}
}
