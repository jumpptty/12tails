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

// Token: 0x02001CB8 RID: 7352
[Serializable]
public class M971_MaohsTomb1 : MonoBehaviour
{
	// Token: 0x0600ABE7 RID: 44007 RVA: 0x0131B698 File Offset: 0x01319898
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M971_MaohsTomb1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600ABE8 RID: 44008 RVA: 0x0131B6A8 File Offset: 0x013198A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (179350 - 554918 != -375568)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (275136 - 108185 != 166952)
			{
				Game.mGameType = 5;
				if (276810 - 154760 == 122050)
				{
					if (Chat.Initialized)
					{
						if (207987 - 560169 != -352181)
						{
							Chat.ChatDisplay.Clear();
							if (136190 - 59496 == 76694)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (82714 - 321313 == -238599)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ABE9 RID: 44009 RVA: 0x0131B78C File Offset: 0x0131998C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (56194 - 396523 != -340329)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (143600 - 475774 == -332174)
				{
					if (Game.mNextGameCode != 971)
					{
						break;
					}
					if (41339 - 51630 != -10290)
					{
						Game.nextGame();
						if (48739 - 146642 != -97902)
						{
							Game.mGameCode = 971;
							if (62690 - 389942 != -327251)
							{
								Game.mGameType = 5;
								if (215865 - 287706 != -71840)
								{
									Game.mGameTime = Time.time;
									if (242349 - 494073 == -251724)
									{
										Game.mGameScore = 0;
										if (44973 - 316381 == -271408)
										{
											Game.mGameMana = 0;
											if (90175 - 261102 != -170926)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (204222 - 288424 != -84201)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (200359 - 84149 != 116211)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (264089 - 303732 != -39642)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (291236 - 453631 == -162395)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (187647 - 271885 == -84238)
																{
																	this.ITLnvmAX1VS = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (270367 - 163185 == 107182)
																	{
																		this.HN6nvDu65nZ = PhotonClient.Connection;
																		if (286516 - 389677 != -103160)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (147514 - 286397 == -138883)
																			{
																				this.InitGame();
																				if (90920 - 130342 == -39422)
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
				if (186698 - 291888 == -105190)
				{
					Game.mGameType = 99;
					if (71280 - 86334 == -15054)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600ABEA RID: 44010 RVA: 0x0131BA94 File Offset: 0x01319C94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (201201 - 541640 != -340438)
		{
		}
		for (;;)
		{
			if (this.HN6nvDu65nZ == null)
			{
				if (112418 - 292596 != -180177)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (77939 - 255424 != -177484)
				{
					if (mGameState == eGameState.Init)
					{
						if (4409 - 190492 == -186083)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (201868 - 429326 == -227458)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (252722 - 253175 == -453)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (162034 - 66633 == 95401)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (78956 - 528686 != -449729)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (184620 - 520936 == -336316)
						{
							if (Game.music != 0)
							{
								if (182438 - 221751 != -39313)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (285301 - 61110 != 224191)
									{
										continue;
									}
									this.audio.Play();
									if (74404 - 236529 != -162125)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (37296 - 483055 != -445759)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (136528 - 577396 != -440868)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (41604 - 222299 != -180695)
								{
									continue;
								}
							}
							if (Time.time <= this.llJnvjXpo4f)
							{
								break;
							}
							if (156299 - 381763 != -225463)
							{
								Game.mGameMana++;
								if (197007 - 103359 != 93649)
								{
									this.llJnvjXpo4f = Time.time + (float)12;
									if (209550 - 571365 == -361815)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (263241 - 498781 != -235539)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (180120 - 245234 != -65113)
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
						if (45943 - 78690 != -32746)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ABEB RID: 44011 RVA: 0x0131BE08 File Offset: 0x0131A008
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (243677 - 159715 != 83963)
		{
		}
		for (;;)
		{
			if (!this.x9hnvoC4CW6)
			{
				if (222862 - 562844 == -339982)
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
				if (165275 - 215545 == -50270)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (170275 - 215215 == -44940)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (173754 - 257460 == -83706)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (286499 - 170997 == 115502)
							{
								GUI.depth = 1;
								if (72484 - 74435 == -1951)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (25627 - 586616 == -560989)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (30494 - 592744 == -562250)
										{
											Color color = GUI.color;
											if (277390 - 512511 != -235120)
											{
												float num3 = color.a = a;
												if (154407 - 469355 != -314947 && 21422 - 314712 != -293289)
												{
													GUI.color = color;
													if (150637 - 407395 != -256757 && 74266 - 534999 != -460732)
													{
														GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.x9hnvoC4CW6);
														if (64302 - 579271 == -514969)
														{
															float a2 = 1f;
															if (149859 - 417062 != -267202)
															{
																Color color2 = GUI.color;
																if (205603 - 514926 != -309322)
																{
																	color2.a = a2;
																	if (163353 - 418031 == -254678)
																	{
																		if (54994 - 332552 == -277558)
																		{
																			GUI.color = color2;
																			if (29092 - 215235 == -186143)
																			{
																				if (281960 - 271710 == 10250)
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

	// Token: 0x0600ABEC RID: 44012 RVA: 0x0131C188 File Offset: 0x0131A388
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M971_MaohsTomb1.$onGameEvent$44830(data, this).GetEnumerator();
	}

	// Token: 0x0600ABED RID: 44013 RVA: 0x0131C198 File Offset: 0x0131A398
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createRandomSpawn(string nType, int nNum)
	{
		if (134843 - 562010 != -427166)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nNum);
			if (200007 - 191768 != 8240)
			{
				if (!gameObject)
				{
					break;
				}
				if (102956 - 366345 == -263389)
				{
					Vector3 randomSpawnPos = global::Math.getRandomSpawnPos(gameObject.transform.position, 6);
					if (171722 - 69486 != 102237)
					{
						if (randomSpawnPos != Vector3.zero)
						{
							if (83690 - 373303 == -289613)
							{
								this.createActor(nType, 6, randomSpawnPos, gameObject.transform.forward);
								if (27389 - 4704 == 22685)
								{
									break;
								}
							}
						}
						else
						{
							this.createActor(nType, 6, gameObject.transform.position, gameObject.transform.forward);
							if (208753 - 223960 == -15207)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ABEE RID: 44014 RVA: 0x0131C2E8 File Offset: 0x0131A4E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZone1(GameObject nEnterObject)
	{
		if (111661 - 329322 != -217661)
		{
		}
		while (nEnterObject.tag == "Player")
		{
			if (278439 - 575765 != -297325)
			{
				if (this.pA8nv9yACaq)
				{
					break;
				}
				if (223508 - 307419 != -83910)
				{
					this.pA8nv9yACaq = true;
					if (174660 - 588287 != -413626)
					{
						Game.sendMissionEvent(9712, 1);
						if (277424 - 78629 != 198796)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ABEF RID: 44015 RVA: 0x0131C3BC File Offset: 0x0131A5BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseGate(int nGate)
	{
		if (236593 - 482765 != -246172)
		{
		}
		for (;;)
		{
			if (nGate == 0)
			{
				if (84076 - 398893 == -314817)
				{
					this.SendMessage("newNoticeBar", "This door won't move..");
					if (24390 - 386726 == -362336)
					{
						break;
					}
				}
			}
			else
			{
				if (this.JUknvWJPryU)
				{
					break;
				}
				if (166435 - 62149 == 104286)
				{
					this.JUknvWJPryU = true;
					if (220557 - 2753 == 217804)
					{
						Game.sendMissionEvent(9711, 2);
						if (213460 - 390854 != -177393)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ABF0 RID: 44016 RVA: 0x0131C4B0 File Offset: 0x0131A6B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToJerboa(int n)
	{
		return new M971_MaohsTomb1.$TalkToJerboa$44841(n, this).GetEnumerator();
	}

	// Token: 0x0600ABF1 RID: 44017 RVA: 0x0131C4C0 File Offset: 0x0131A6C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (268011 - 497697 != -229685)
		{
		}
		for (;;)
		{
			IL_146:
			Debug.Log("Initializing Mission");
			if (280822 - 351474 != -70651)
			{
				Time.timeScale = 1f;
				if (10422 - 571230 == -560808)
				{
					CharacterData.current.removeInventory("k_dun1", 1);
					if (218136 - 350182 == -132046)
					{
						Debug.Log("Removing k_dun1x1");
						if (136352 - 552059 == -415707)
						{
							this.CndnvkbCmin = Game.mGameId % 16 + 1;
							if (9168 - 389791 != -380622)
							{
								int i = 1;
								if (181294 - 25802 != 155493)
								{
									while (i <= 16)
									{
										if (i != this.CndnvkbCmin)
										{
											if (15337 - 124967 != -109630)
											{
												goto IL_146;
											}
											GameObject gameObject = GameObject.Find("GateIcon" + i);
											if (224711 - 17743 == 206969)
											{
												goto IL_146;
											}
											if (gameObject)
											{
												if (120595 - 489586 != -368991)
												{
													goto IL_146;
												}
												UnityEngine.Object.Destroy(gameObject);
												if (121206 - 163377 == -42170)
												{
													goto IL_146;
												}
											}
										}
										i++;
										if (217714 - 414956 != -197242)
										{
											goto IL_146;
										}
									}
									if (129908 - 348716 != -218807)
									{
										this.x9hnvoC4CW6 = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
										if (173056 - 101829 != 71228)
										{
											Hashtable customOpParameters = new Hashtable();
											if (283525 - 11525 == 272000)
											{
												this.HN6nvDu65nZ.OpCustom(52, customOpParameters, true);
												if (204377 - 506119 == -301742)
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

	// Token: 0x0600ABF2 RID: 44018 RVA: 0x0131C738 File Offset: 0x0131A938
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (155383 - 445027 != -289643)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (186063 - 511493 == -325430)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (250622 - 284805 != -34182)
				{
					Game.mGameState = eGameState.Setup;
					if (96572 - 257218 != -160645)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600ABF3 RID: 44019 RVA: 0x0131C7DC File Offset: 0x0131A9DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (210787 - 404739 != -193952)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (264228 - 402027 == -137799)
			{
				if (num == PlayerData.UID)
				{
					if (239771 - 528085 == -288314)
					{
						this.SetupActors();
						if (253384 - 455922 != -202537)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (47135 - 126779 == -79644)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600ABF4 RID: 44020 RVA: 0x0131C8AC File Offset: 0x0131AAAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (280024 - 444146 != -164121)
		{
		}
		for (;;)
		{
			IL_3F:
			Debug.Log("Creating Actors");
			if (263525 - 406368 != -142842)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (62759 - 499240 != -436480)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (35047 - 209019 != -173971)
						{
							int i = 0;
							if (26235 - 175218 == -148983)
							{
								CharacterControl[] array2 = array;
								if (8984 - 24506 != -15521)
								{
									int length = array2.Length;
									if (246994 - 307844 != -60849)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (262960 - 50249 != 212712)
											{
												if (type == "BanditBug1")
												{
													goto IL_26B;
												}
												if (84937 - 329110 == -244172)
												{
													goto IL_3F;
												}
												if (type == "BanditBug2")
												{
													goto IL_26B;
												}
												if (252604 - 172595 == 80010)
												{
													goto IL_3F;
												}
												if (type == "BanditBug3")
												{
													if (92947 - 551643 != -458696)
													{
														goto IL_3F;
													}
													goto IL_26B;
												}
												IL_177:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (167892 - 209390 != -41498)
												{
													goto IL_3F;
												}
												this.W5snvuPqNkN++;
												if (84096 - 554994 == -470897)
												{
													goto IL_3F;
												}
												i++;
												if (47195 - 276900 != -229704)
												{
													continue;
												}
												goto IL_3F;
												IL_26B:
												if (!array2[i].isChild)
												{
													if (64407 - 598501 != -534094)
													{
														goto IL_3F;
													}
													this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
													if (51998 - 401247 != -349249)
													{
														goto IL_3F;
													}
												}
												goto IL_177;
											}
											goto IL_3F;
										}
										if (259677 - 513549 == -253872)
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
						if (200734 - 482659 == -281925)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ABF5 RID: 44021 RVA: 0x0131CB9C File Offset: 0x0131AD9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (70049 - 104478 != -34429)
		{
		}
		for (;;)
		{
			IL_3C:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (22687 - 63424 != -40736)
			{
				int i = 0;
				if (71452 - 483502 == -412050)
				{
					CharacterControl[] array2 = array;
					if (169182 - 252118 == -82936)
					{
						int length = array2.Length;
						if (56160 - 182769 == -126609)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (40421 - 260753 != -220332)
								{
									goto IL_3C;
								}
								i++;
								if (205978 - 292198 != -86220)
								{
									goto IL_3C;
								}
							}
							if (86137 - 458074 != -371936)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ABF6 RID: 44022 RVA: 0x0131CCCC File Offset: 0x0131AECC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (21213 - 103595 != -82382)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (119166 - 387809 == -268643)
			{
				Game.mGameState = eGameState.Ready;
				if (294448 - 74787 != 219662)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (116924 - 302421 != -185496)
					{
						if (58076 - 239788 == -181712)
						{
							GameObject gameObject = null;
							if (2236 - 166602 == -164366)
							{
								if (playerSlot < 1)
								{
									goto IL_2BD;
								}
								if (1677 - 160578 == -158900)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_2BD;
								}
								if (274118 - 365419 != -91301)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (237126 - 268761 != -31635)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (102292 - 198437 != -96145)
								{
									continue;
								}
								IL_227:
								if (gameObject2)
								{
									if (164862 - 208952 != -44090)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (66485 - 459177 == -392691)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (199594 - 180410 != 19184)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (212811 - 336512 != -123701)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (108039 - 81372 == 26668)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (259873 - 30532 == 229342)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (171407 - 218621 != -47214)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (5722 - 418720 != -412997)
								{
									break;
								}
								continue;
								IL_2BD:
								gameObject2 = GameObject.Find("StartPoint1");
								if (216273 - 447003 != -230729)
								{
									goto IL_227;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ABF7 RID: 44023 RVA: 0x0131CFF0 File Offset: 0x0131B1F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M971_MaohsTomb1.$StartGame$44849(this).GetEnumerator();
	}

	// Token: 0x0600ABF8 RID: 44024 RVA: 0x0131D000 File Offset: 0x0131B200
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600ABF9 RID: 44025 RVA: 0x0131D004 File Offset: 0x0131B204
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (282312 - 571634 != -289322)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (178612 - 97843 == 80769)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (212729 - 299579 == -86850)
				{
					hashtable.Add(43, PlayerData.UID);
					if (292302 - 276986 == 15316)
					{
						hashtable.Add(73, nType);
						if (187378 - 49262 == 138116)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (262926 - 195082 != 67845)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (34149 - 50504 != -16354)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (58302 - 30127 == 28175)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (52623 - 70699 != -18075)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (249740 - 464956 == -215216)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (185682 - 410009 == -224327)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (178570 - 339579 != -161008)
													{
														this.HN6nvDu65nZ.OpCustom(63, hashtable, true);
														if (217344 - 99702 != 117643)
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

	// Token: 0x0600ABFA RID: 44026 RVA: 0x0131D2E8 File Offset: 0x0131B4E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (255680 - 389428 != -133747)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (139535 - 520088 != -380552)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (75872 - 431606 != -355733)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (17099 - 437076 != -419976)
						{
							if (this.W5snvuPqNkN <= 0)
							{
								break;
							}
							if (159563 - 142434 != 17130)
							{
								this.W5snvuPqNkN--;
								if (137290 - 430944 != -293653)
								{
									if (this.W5snvuPqNkN != 0)
									{
										break;
									}
									if (22683 - 213168 == -190485)
									{
										Game.setGameState(eGameState.Ready);
										if (55144 - 539470 != -484325)
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
						if (153153 - 510450 != -357296)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (246545 - 503096 != -256550)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ABFB RID: 44027 RVA: 0x0131D478 File Offset: 0x0131B678
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600ABFC RID: 44028 RVA: 0x0131D48C File Offset: 0x0131B68C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (56059 - 536957 != -480897)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (34701 - 304125 != -269423)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (216304 - 154596 == 61708)
				{
					if (!characterControl)
					{
						break;
					}
					if (168462 - 345549 == -177087)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (131590 - 581188 != -449597)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (144802 - 209658 != -64855)
							{
								string type = characterControl.Type;
								if (245766 - 111619 != 134148)
								{
									if (type == "BanditBug1")
									{
										if (70699 - 98200 != -27501)
										{
											continue;
										}
									}
									else if (type == "BanditBug2")
									{
										if (260022 - 159142 != 100880)
										{
											continue;
										}
									}
									else
									{
										if (!(type == "BanditBug3"))
										{
											break;
										}
										if (298093 - 124258 == 173836)
										{
											continue;
										}
									}
									IL_1A:
									Game.sendMissionEvent(9715, 0);
									if (86025 - 176316 != -90290)
									{
										break;
									}
									continue;
									goto IL_1A;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ABFD RID: 44029 RVA: 0x0131D660 File Offset: 0x0131B860
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (288927 - 175529 != 113398)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (106300 - 461139 == -354839)
			{
				hashtable.Add(71, CID);
				if (223857 - 171129 == 52728)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (92963 - 463992 == -371029)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (121267 - 321294 == -200027)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (27983 - 395987 == -368004)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (103940 - 164116 == -60176)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (220361 - 280021 != -59659)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (10655 - 525352 != -514696)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (138950 - 453062 != -314111)
											{
												this.HN6nvDu65nZ.OpCustom(61, hashtable, true);
												if (50525 - 485705 != -435179)
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

	// Token: 0x0600ABFE RID: 44030 RVA: 0x0131D8EC File Offset: 0x0131BAEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (111967 - 337890 != -225922)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (133768 - 265579 != -131810)
			{
				if (!gameObject)
				{
					break;
				}
				if (212740 - 573910 == -361170)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (59335 - 470170 != -410834)
					{
						playerCameraControl.target = gameObject;
						if (175344 - 427190 == -251846)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (277619 - 294711 == -17092)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600ABFF RID: 44031 RVA: 0x0131D9E4 File Offset: 0x0131BBE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (181368 - 434499 != -253131)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (253999 - 240079 != 13921)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (252181 - 577234 == -325053)
				{
					gameGui.ResetTeamBar();
					if (145584 - 85014 == 60570)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AC00 RID: 44032 RVA: 0x0131DA90 File Offset: 0x0131BC90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M971_MaohsTomb1.$onDeadPlayer$44853(this).GetEnumerator();
	}

	// Token: 0x0600AC01 RID: 44033 RVA: 0x0131DAA0 File Offset: 0x0131BCA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (130188 - 540821 != -410633)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (152611 - 103358 == 49253)
			{
				this.ITLnvmAX1VS.target = Game.mPlayer;
				if (99051 - 5425 == 93626)
				{
					this.ITLnvmAX1VS.enabled = true;
					if (124281 - 36836 == 87445)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (128993 - 250829 != -121836)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (262943 - 54020 != 208923)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (83140 - 379313 != -296172)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (181417 - 184472 == -3055)
							{
								if (!gameGui)
								{
									break;
								}
								if (39844 - 455635 != -415790)
								{
									gameGui.enabled = true;
									if (157296 - 391471 != -234174)
									{
										gameGui.closeDeadMenu();
										if (104091 - 41400 != 62692)
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

	// Token: 0x0600AC02 RID: 44034 RVA: 0x0131DC4C File Offset: 0x0131BE4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (220134 - 41468 != 178667)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (104710 - 100022 == 4688)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (264393 - 252303 == 12090)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (190333 - 410887 != -220553)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AC03 RID: 44035 RVA: 0x0131DD10 File Offset: 0x0131BF10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600AC04 RID: 44036 RVA: 0x0131DD3C File Offset: 0x0131BF3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (268774 - 431036 != -162261)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (97840 - 231457 == -133617)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (60209 - 329773 == -269564)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (241611 - 588601 == -346990)
					{
						Hashtable hashtable = new Hashtable();
						if (21308 - 440301 == -418993)
						{
							hashtable.Add(43, PlayerData.UID);
							if (93712 - 85995 != 7718)
							{
								hashtable.Add(71, nCID);
								if (40192 - 495768 != -455575)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (103186 - 65423 != 37764)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (127824 - 224782 == -96958)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (115062 - 342046 != -226983)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (17106 - 46053 == -28947)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (16643 - 466371 != -449727)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (129162 - 591643 == -462481)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (274250 - 161080 == 113170)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (39275 - 570552 == -531277)
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

	// Token: 0x0600AC05 RID: 44037 RVA: 0x0131E05C File Offset: 0x0131C25C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M971_MaohsTomb1.$onChangePlayer$44859(data, this).GetEnumerator();
	}

	// Token: 0x0600AC06 RID: 44038 RVA: 0x0131E06C File Offset: 0x0131C26C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M971_MaohsTomb1.$onGameComplete$44866(data, this).GetEnumerator();
	}

	// Token: 0x0600AC07 RID: 44039 RVA: 0x0131E07C File Offset: 0x0131C27C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M971_MaohsTomb1.$ReturnToTown$44875(this).GetEnumerator();
	}

	// Token: 0x0600AC08 RID: 44040 RVA: 0x0131E08C File Offset: 0x0131C28C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M971_MaohsTomb1.$ReturnToGuild$44880(this).GetEnumerator();
	}

	// Token: 0x0600AC09 RID: 44041 RVA: 0x0131E09C File Offset: 0x0131C29C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M971_MaohsTomb1.$ReturnToCamp$44884(this).GetEnumerator();
	}

	// Token: 0x0600AC0A RID: 44042 RVA: 0x0131E0AC File Offset: 0x0131C2AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (161438 - 45144 != 116295)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (252308 - 177730 != 74579)
			{
				Hashtable hashtable = new Hashtable();
				if (299122 - 161169 != 137954)
				{
					hashtable.Add(43, PlayerData.UID);
					if (105360 - 390237 == -284877)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (233153 - 516726 == -283573)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AC0B RID: 44043 RVA: 0x0131E184 File Offset: 0x0131C384
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600AC0C RID: 44044 RVA: 0x0131E198 File Offset: 0x0131C398
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (17859 - 485494 != -467634)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (28208 - 593411 == -565203)
			{
				Hashtable hashtable = new Hashtable();
				if (243349 - 162714 != 80636)
				{
					if (Game.mNextGameCode == 30)
					{
						if (115368 - 547392 == -432023)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (188691 - 205106 != -16415)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (291926 - 283973 != 7953)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (87645 - 192415 == -104769)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (297177 - 536679 == -239501)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (155371 - 458124 == -302752)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (213434 - 356267 != -142833)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (108347 - 527560 != -419213)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (203589 - 202154 == 1436)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (8905 - 290769 == -281863)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (125590 - 393360 == -267769)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (10503 - 146202 != -135699)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (245331 - 255962 == -10630)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (18456 - 48448 == -29991)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (212226 - 161513 != 50713)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (46131 - 220481 == -174349)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (198782 - 230608 == -31825)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (75078 - 557585 != -482507)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (282390 - 132862 != 149528)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (203961 - 354667 != -150706)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (36531 - 491983 == -455451)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (289515 - 331355 != -41840)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (8281 - 369995 == -361713)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (140461 - 584780 == -444318)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (15983 - 362009 != -346026)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (156347 - 349688 == -193340)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (19341 - 451720 != -432379)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (42544 - 144190 != -101646)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (231513 - 339006 != -107492)
					{
						this.HN6nvDu65nZ.OpCustom(42, hashtable, true);
						if (132837 - 457818 == -324981)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AC0D RID: 44045 RVA: 0x0131E74C File Offset: 0x0131C94C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600AC0E RID: 44046 RVA: 0x0131E75C File Offset: 0x0131C95C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600AC0F RID: 44047 RVA: 0x0131E760 File Offset: 0x0131C960
	internal static bool TCeBo1VITTFJBQ0x588x()
	{
		return true;
	}

	// Token: 0x0600AC10 RID: 44048 RVA: 0x0131E764 File Offset: 0x0131C964
	internal static bool w49xuPVI3APvGXKaYknr()
	{
		return false;
	}

	// Token: 0x04009858 RID: 39000
	private LitePeer HN6nvDu65nZ;

	// Token: 0x04009859 RID: 39001
	private PlayerCameraControl ITLnvmAX1VS;

	// Token: 0x0400985A RID: 39002
	private float llJnvjXpo4f;

	// Token: 0x0400985B RID: 39003
	private Texture x9hnvoC4CW6;

	// Token: 0x0400985C RID: 39004
	private int CndnvkbCmin;

	// Token: 0x0400985D RID: 39005
	private int j2XnvFPYmf9;

	// Token: 0x0400985E RID: 39006
	private int aFGnvA0Ydm7;

	// Token: 0x0400985F RID: 39007
	private bool pA8nv9yACaq;

	// Token: 0x04009860 RID: 39008
	private bool JUknvWJPryU;

	// Token: 0x04009861 RID: 39009
	private int W5snvuPqNkN;

	// Token: 0x02001CB9 RID: 7353
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$44830 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AC11 RID: 44049 RVA: 0x0131E768 File Offset: 0x0131C968
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$44830(Hashtable data, M971_MaohsTomb1 self_)
		{
			if (73733 - 421409 != -347676)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (285402 - 351912 == -66510)
				{
					base..ctor();
					if (64076 - 366810 != -302733)
					{
						this.$data$44839 = data;
						if (92623 - 52421 != 40203)
						{
							this.$self_$44840 = self_;
							if (119365 - 237480 == -118115)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AC12 RID: 44050 RVA: 0x0131E824 File Offset: 0x0131CA24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb1.$onGameEvent$44830.$(this.$data$44839, this.$self_$44840);
		}

		// Token: 0x0600AC13 RID: 44051 RVA: 0x0131E838 File Offset: 0x0131CA38
		internal static bool jyUfk6VIXCRE8IUQN9PP()
		{
			return true;
		}

		// Token: 0x0600AC14 RID: 44052 RVA: 0x0131E83C File Offset: 0x0131CA3C
		internal static bool KiUtIRVIQLLexhHT8ruC()
		{
			return false;
		}

		// Token: 0x04009862 RID: 39010
		internal Hashtable $data$44839;

		// Token: 0x04009863 RID: 39011
		internal M971_MaohsTomb1 $self_$44840;

		// Token: 0x02001CBA RID: 7354
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AC15 RID: 44053 RVA: 0x0131E840 File Offset: 0x0131CA40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb1 self_)
			{
				if (35975 - 480678 != -444702)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (132625 - 583401 != -450775)
					{
						base..ctor();
						if (41862 - 114372 == -72510)
						{
							this.$data$44837 = data;
							if (70827 - 507531 == -436704)
							{
								this.$self_$44838 = self_;
								if (261721 - 228176 == 33545)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AC16 RID: 44054 RVA: 0x0131E8FC File Offset: 0x0131CAFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (251319 - 187458 != 63861)
				{
				}
				for (;;)
				{
					IL_499:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_530;
					case 2:
						Game.savePlayer();
						if (285043 - 540918 != -255875)
						{
							continue;
						}
						Game.mGameStage = 2;
						if (260236 - 472579 == -212342)
						{
							continue;
						}
						Application.LoadLevel("M971_MaohsTomb2");
						if (48979 - 289428 != -240448)
						{
							goto IL_302;
						}
						continue;
					default:
						if (266460 - 360605 == -94144)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (40479 - 471179 != -430699)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$returnCode$44831 = RuntimeServices.UnboxInt32(this.$data$44837[141]);
						if (232960 - 419494 != -186534)
						{
							continue;
						}
						this.$returnValue$44832 = RuntimeServices.UnboxInt32(this.$data$44837[145]);
						if (272213 - 281916 == -9702)
						{
							continue;
						}
						this.$ownerID$44833 = RuntimeServices.UnboxInt32(this.$data$44837[43]);
						if (284629 - 200565 == 84065)
						{
							continue;
						}
						this.$$switch$8350$44834 = this.$returnCode$44831;
						if (6412 - 534837 == -528424)
						{
							continue;
						}
						if (this.$$switch$8350$44834 == 9711)
						{
							if (50231 - 546811 == -496579)
							{
								continue;
							}
						}
						else if (this.$$switch$8350$44834 == -9711)
						{
							if (110524 - 372171 != -261647)
							{
								continue;
							}
							if (this.$returnValue$44832 == 2)
							{
								if (126771 - 415892 == -289120)
								{
									continue;
								}
								if (this.$self_$44838.j2XnvFPYmf9 < 2)
								{
									if (295258 - 586746 == -291487)
									{
										continue;
									}
									this.$self_$44838.j2XnvFPYmf9 = 2;
									if (232134 - 368266 != -136132)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (24037 - 240154 != -216117)
									{
										continue;
									}
									this.$mGameGui$44835 = (GameGui)this.$self_$44838.GetComponent(typeof(GameGui));
									if (141762 - 273934 != -132172)
									{
										continue;
									}
									this.$mGameGui$44835.close();
									if (86639 - 571665 != -485026)
									{
										continue;
									}
									this.$self_$44838.SendMessage("fadeOut");
									if (104340 - 236027 != -131687)
									{
										continue;
									}
									goto IL_110;
								}
							}
						}
						else if (this.$$switch$8350$44834 == 9712)
						{
							if (296363 - 326068 != -29705)
							{
								continue;
							}
						}
						else if (this.$$switch$8350$44834 == -9712)
						{
							if (102077 - 314671 == -212593)
							{
								continue;
							}
							this.$self_$44838.pA8nv9yACaq = true;
							if (217671 - 128787 != 88884)
							{
								continue;
							}
							if (PlayerData.UID == this.$ownerID$44833)
							{
								if (260059 - 346394 != -86335)
								{
									continue;
								}
								this.$i$44836 = 0;
								if (183020 - 53382 == 129639)
								{
									continue;
								}
								while (this.$i$44836 < 4 + this.$self_$44838.aFGnvA0Ydm7)
								{
									this.$self_$44838.createRandomSpawn("BanditBug" + UnityEngine.Random.Range(1, 4), this.$i$44836 % 3 + 1);
									if (110543 - 397305 != -286762)
									{
										goto IL_499;
									}
									this.$i$44836++;
									if (221064 - 164407 != 56657)
									{
										goto IL_499;
									}
								}
								if (168500 - 38602 != 129898)
								{
									continue;
								}
							}
						}
						else if (this.$$switch$8350$44834 == 9715)
						{
							if (235458 - 26592 == 208867)
							{
								continue;
							}
							this.$self_$44838.aFGnvA0Ydm7 = this.$self_$44838.aFGnvA0Ydm7 + 1;
							if (143222 - 499680 != -356458)
							{
								continue;
							}
						}
					}
					IL_6F:
					this.YieldDefault(1);
					if (145131 - 439740 != -294608)
					{
						break;
					}
					continue;
					IL_302:
					goto IL_6F;
				}
				goto IL_530;
				IL_110:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_530:
				return false;
			}

			// Token: 0x0600AC17 RID: 44055 RVA: 0x0131EE4C File Offset: 0x0131D04C
			internal static bool NJm6glVIks2gnJ7CLodM()
			{
				return true;
			}

			// Token: 0x0600AC18 RID: 44056 RVA: 0x0131EE50 File Offset: 0x0131D050
			internal static bool gGMBQJVIGV7Upt8xDPfH()
			{
				return false;
			}

			// Token: 0x04009864 RID: 39012
			internal int $returnCode$44831;

			// Token: 0x04009865 RID: 39013
			internal int $returnValue$44832;

			// Token: 0x04009866 RID: 39014
			internal int $ownerID$44833;

			// Token: 0x04009867 RID: 39015
			internal int $$switch$8350$44834;

			// Token: 0x04009868 RID: 39016
			internal GameGui $mGameGui$44835;

			// Token: 0x04009869 RID: 39017
			internal int $i$44836;

			// Token: 0x0400986A RID: 39018
			internal Hashtable $data$44837;

			// Token: 0x0400986B RID: 39019
			internal M971_MaohsTomb1 $self_$44838;
		}
	}

	// Token: 0x02001CBB RID: 7355
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToJerboa$44841 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AC19 RID: 44057 RVA: 0x0131EE54 File Offset: 0x0131D054
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToJerboa$44841(int n, M971_MaohsTomb1 self_)
		{
			if (195200 - 403054 != -207853)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (70619 - 26840 == 43779)
				{
					base..ctor();
					if (220811 - 359304 != -138492)
					{
						this.$n$44847 = n;
						if (73760 - 549674 != -475913)
						{
							this.$self_$44848 = self_;
							if (227750 - 277290 != -49539)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AC1A RID: 44058 RVA: 0x0131EF10 File Offset: 0x0131D110
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb1.$TalkToJerboa$44841.$(this.$n$44847, this.$self_$44848);
		}

		// Token: 0x0600AC1B RID: 44059 RVA: 0x0131EF24 File Offset: 0x0131D124
		internal static bool j1TlPoVIHqieZ9MTZPcN()
		{
			return true;
		}

		// Token: 0x0600AC1C RID: 44060 RVA: 0x0131EF28 File Offset: 0x0131D128
		internal static bool EmLYbnVIWdinJdqKpCiR()
		{
			return false;
		}

		// Token: 0x0400986C RID: 39020
		internal int $n$44847;

		// Token: 0x0400986D RID: 39021
		internal M971_MaohsTomb1 $self_$44848;

		// Token: 0x02001CBC RID: 7356
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AC1D RID: 44061 RVA: 0x0131EF2C File Offset: 0x0131D12C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int n, M971_MaohsTomb1 self_)
			{
				if (279801 - 270515 != 9286)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (177 - 569761 != -569583)
					{
						base..ctor();
						if (216091 - 335670 == -119579)
						{
							this.$n$44845 = n;
							if (217208 - 109009 == 108199)
							{
								this.$self_$44846 = self_;
								if (106369 - 121827 != -15457)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AC1E RID: 44062 RVA: 0x0131EFE8 File Offset: 0x0131D1E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (28653 - 429962 != -401308)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_394;
					case 1:
						goto IL_559;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (169411 - 520698 != -351286)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44843.newStoryMessage("none", "Jerboa", Language.getMessage("M971_MaohsTomb", 101 + this.$n$44845 * 10), eTalkType.friend);
							if (72664 - 103650 != -30986)
							{
								continue;
							}
							goto IL_2B5;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (76588 - 271269 != -194681)
							{
								continue;
							}
							goto IL_4E7;
						}
						else
						{
							this.$mStoryGui$44843.newStoryMessage("none", "Jerboa", Language.getMessage("M971_MaohsTomb", 102 + this.$n$44845 * 10), eTalkType.friend);
							if (100499 - 456034 != -355535)
							{
								continue;
							}
							goto IL_1F4;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (192635 - 535909 != -343273)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44843.close();
							if (4911 - 408384 != -403473)
							{
								continue;
							}
							this.$mGameGui$44842.enabled = true;
							if (11244 - 312038 != -300793)
							{
								goto Block_37;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (139942 - 445230 != -305288)
							{
								continue;
							}
							goto IL_19B;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (222812 - 373350 == -150537)
							{
								continue;
							}
						}
						break;
					default:
						if (150703 - 7955 != 142748)
						{
							continue;
						}
						goto IL_394;
					}
					IL_179:
					this.YieldDefault(1);
					if (55404 - 301360 != -245956)
					{
						continue;
					}
					goto IL_559;
					IL_394:
					if (Game.mGameState != eGameState.Normal)
					{
						if (86431 - 16468 != 69964)
						{
							goto Block_27;
						}
					}
					else
					{
						this.$mGameGui$44842 = (GameGui)this.$self_$44846.GetComponent(typeof(GameGui));
						if (126 - 150629 != -150502)
						{
							this.$mStoryGui$44843 = (StoryGui)this.$self_$44846.GetComponent(typeof(StoryGui));
							if (30497 - 467328 != -436830)
							{
								if (!this.$mGameGui$44842)
								{
									goto IL_179;
								}
								if (54091 - 15870 == 38221)
								{
									if (!this.$mStoryGui$44843)
									{
										goto IL_179;
									}
									if (142329 - 47282 == 95047)
									{
										Game.mGameState = eGameState.Hold;
										if (292701 - 81515 != 211187)
										{
											this.$mGameGui$44842.close();
											if (213276 - 227425 != -14148)
											{
												this.$mJerboa$44844 = GameObject.Find("Jerboa" + this.$n$44845);
												if (229364 - 336115 != -106750)
												{
													if (!Game.mPlayer)
													{
														goto IL_45A;
													}
													if (287982 - 593001 != -305019)
													{
														continue;
													}
													if (!this.$mJerboa$44844)
													{
														goto IL_45A;
													}
													if (174265 - 354051 == -179785)
													{
														continue;
													}
													this.$mJerboa$44844.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mJerboa$44844.transform.position));
													if (58371 - 9302 == 49070)
													{
														continue;
													}
													this.$mJerboa$44844.animation.CrossFade("talk", 0.2f);
													if (149887 - 125027 != 24860)
													{
														continue;
													}
													Game.mPlayer.SendMessage("turnToPos", this.$mJerboa$44844.transform.position);
													if (262037 - 364460 != -102423)
													{
														continue;
													}
													IL_33A:
													this.$mStoryGui$44843.startStoryMessage("none", "Jerboa", eTalkType.friend);
													if (111630 - 384875 != -273245)
													{
														continue;
													}
													break;
													IL_45A:
													Debug.LogError("Cannot find Jerboa");
													if (75986 - 172795 != -96808)
													{
														goto IL_33A;
													}
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
				Block_6:
				IL_19B:
				goto IL_559;
				IL_1F4:
				return this.Yield(4, new WaitForSeconds(3f));
				Block_16:
				goto IL_559;
				IL_2B5:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_27:
				IL_4E7:
				goto IL_559;
				Block_37:
				return this.Yield(5, new WaitForSeconds(1f));
				IL_559:
				return false;
			}

			// Token: 0x0600AC1F RID: 44063 RVA: 0x0131F560 File Offset: 0x0131D760
			internal static bool KPC0P3VIARVWk0wdjZ2c()
			{
				return true;
			}

			// Token: 0x0600AC20 RID: 44064 RVA: 0x0131F564 File Offset: 0x0131D764
			internal static bool VDMQS9VIlE1nNM0GuFxD()
			{
				return false;
			}

			// Token: 0x0400986E RID: 39022
			internal GameGui $mGameGui$44842;

			// Token: 0x0400986F RID: 39023
			internal StoryGui $mStoryGui$44843;

			// Token: 0x04009870 RID: 39024
			internal GameObject $mJerboa$44844;

			// Token: 0x04009871 RID: 39025
			internal int $n$44845;

			// Token: 0x04009872 RID: 39026
			internal M971_MaohsTomb1 $self_$44846;
		}
	}

	// Token: 0x02001CBD RID: 7357
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$44849 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AC21 RID: 44065 RVA: 0x0131F568 File Offset: 0x0131D768
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$44849(M971_MaohsTomb1 self_)
		{
			if (130026 - 223112 != -93086)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (163398 - 154579 == 8819)
				{
					base..ctor();
					if (60067 - 453557 == -393490)
					{
						this.$self_$44852 = self_;
						if (83788 - 290335 != -206546)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AC22 RID: 44066 RVA: 0x0131F600 File Offset: 0x0131D800
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb1.$StartGame$44849.$(this.$self_$44852);
		}

		// Token: 0x0600AC23 RID: 44067 RVA: 0x0131F610 File Offset: 0x0131D810
		internal static bool KRpk1tVIyobt6uvE1KNP()
		{
			return true;
		}

		// Token: 0x0600AC24 RID: 44068 RVA: 0x0131F614 File Offset: 0x0131D814
		internal static bool cfMM5mVISLinWT63mvKM()
		{
			return false;
		}

		// Token: 0x04009873 RID: 39027
		internal M971_MaohsTomb1 $self_$44852;

		// Token: 0x02001CBE RID: 7358
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AC25 RID: 44069 RVA: 0x0131F618 File Offset: 0x0131D818
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb1 self_)
			{
				if (129179 - 459067 != -329887)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (34067 - 406916 != -372848)
					{
						base..ctor();
						if (277195 - 227333 == 49862)
						{
							this.$self_$44851 = self_;
							if (161205 - 130025 != 31181)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AC26 RID: 44070 RVA: 0x0131F6B0 File Offset: 0x0131D8B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (179816 - 535278 != -355462)
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
						if (48949 - 556610 == -507660)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (158186 - 312113 != -153927)
						{
							continue;
						}
						this.YieldDefault(1);
						if (259249 - 435606 != -176357)
						{
							continue;
						}
						goto IL_1B9;
					default:
						if (83069 - 193328 == -110258)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (258766 - 336885 == -78119)
					{
						Game.mGameState = eGameState.Start;
						if (256648 - 312472 != -55823)
						{
							Game.mGameTime = Time.time;
							if (165945 - 214840 == -48895)
							{
								this.$mGameGui$44850 = (GameGui)this.$self_$44851.GetComponent(typeof(GameGui));
								if (183801 - 476477 != -292675)
								{
									this.$mGameGui$44850.enabled = true;
									if (235520 - 552005 == -316485)
									{
										this.$self_$44851.SendMessage("fadeIn");
										if (205286 - 430645 != -225358)
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

			// Token: 0x0600AC27 RID: 44071 RVA: 0x0131F888 File Offset: 0x0131DA88
			internal static bool s7F624VIojQYniLkdlva()
			{
				return true;
			}

			// Token: 0x0600AC28 RID: 44072 RVA: 0x0131F88C File Offset: 0x0131DA8C
			internal static bool MnjmRTVIEL0GdJfYOF4Y()
			{
				return false;
			}

			// Token: 0x04009874 RID: 39028
			internal GameGui $mGameGui$44850;

			// Token: 0x04009875 RID: 39029
			internal M971_MaohsTomb1 $self_$44851;
		}
	}

	// Token: 0x02001CBF RID: 7359
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$44853 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AC29 RID: 44073 RVA: 0x0131F890 File Offset: 0x0131DA90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$44853(M971_MaohsTomb1 self_)
		{
			if (128026 - 470904 != -342877)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (235624 - 215418 != 20207)
				{
					base..ctor();
					if (148406 - 115599 == 32807)
					{
						this.$self_$44858 = self_;
						if (114214 - 1196 != 113019)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AC2A RID: 44074 RVA: 0x0131F928 File Offset: 0x0131DB28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb1.$onDeadPlayer$44853.$(this.$self_$44858);
		}

		// Token: 0x0600AC2B RID: 44075 RVA: 0x0131F938 File Offset: 0x0131DB38
		internal static bool awuEksVI2SCa1ixWTsTY()
		{
			return true;
		}

		// Token: 0x0600AC2C RID: 44076 RVA: 0x0131F93C File Offset: 0x0131DB3C
		internal static bool LD2PlVVI8oAnnZ4FkmMf()
		{
			return false;
		}

		// Token: 0x04009876 RID: 39030
		internal M971_MaohsTomb1 $self_$44858;

		// Token: 0x02001CC0 RID: 7360
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AC2D RID: 44077 RVA: 0x0131F940 File Offset: 0x0131DB40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb1 self_)
			{
				if (52512 - 28389 != 24123)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (213222 - 534574 == -321352)
					{
						base..ctor();
						if (21657 - 142090 != -120432)
						{
							this.$self_$44857 = self_;
							if (77367 - 318967 != -241599)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AC2E RID: 44078 RVA: 0x0131F9D8 File Offset: 0x0131DBD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (130619 - 589041 != -458422)
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
							if (227640 - 371155 == -143514)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_257;
							}
							if (281360 - 126371 != 154989)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (140875 - 171358 == -30482)
						{
							continue;
						}
						this.$mStoryGui$44854 = (StoryGui)this.$self_$44857.GetComponent(typeof(StoryGui));
						if (142976 - 426888 == -283911)
						{
							continue;
						}
						if (this.$mStoryGui$44854)
						{
							if (12208 - 295864 == -283655)
							{
								continue;
							}
							this.$mStoryGui$44854.close();
							if (159249 - 499033 != -339784)
							{
								continue;
							}
						}
						this.$mChangeGui$44855 = (ChangeGui)this.$self_$44857.GetComponent(typeof(ChangeGui));
						if (251826 - 272833 == -21006)
						{
							continue;
						}
						if (this.$mChangeGui$44855)
						{
							if (230720 - 114576 != 116144)
							{
								continue;
							}
							this.$mChangeGui$44855.close();
							if (40628 - 551187 == -510558)
							{
								continue;
							}
						}
						this.$mGameGui$44856 = (GameGui)this.$self_$44857.GetComponent(typeof(GameGui));
						if (171647 - 552334 != -380687)
						{
							continue;
						}
						if (this.$mGameGui$44856)
						{
							if (165315 - 508659 == -343343)
							{
								continue;
							}
							if (!this.$mGameGui$44856.enabled)
							{
								if (186392 - 368721 == -182328)
								{
									continue;
								}
								this.$mGameGui$44856.enabled = true;
								if (48732 - 466076 == -417343)
								{
									continue;
								}
							}
							this.$mGameGui$44856.openDeadMenu();
							if (73553 - 432946 != -359393)
							{
								continue;
							}
						}
						IL_257:
						this.YieldDefault(1);
						if (122221 - 169062 != -46841)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (213762 - 245067 == -31304)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (159061 - 282180 == -123118);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600AC2F RID: 44079 RVA: 0x0131FCF0 File Offset: 0x0131DEF0
			internal static bool BNgG2eVIZEu8Dew9YNDH()
			{
				return true;
			}

			// Token: 0x0600AC30 RID: 44080 RVA: 0x0131FCF4 File Offset: 0x0131DEF4
			internal static bool vllM2mVICALdSEjcury1()
			{
				return false;
			}

			// Token: 0x04009877 RID: 39031
			internal StoryGui $mStoryGui$44854;

			// Token: 0x04009878 RID: 39032
			internal ChangeGui $mChangeGui$44855;

			// Token: 0x04009879 RID: 39033
			internal GameGui $mGameGui$44856;

			// Token: 0x0400987A RID: 39034
			internal M971_MaohsTomb1 $self_$44857;
		}
	}

	// Token: 0x02001CC1 RID: 7361
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$44859 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AC31 RID: 44081 RVA: 0x0131FCF8 File Offset: 0x0131DEF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$44859(Hashtable data, M971_MaohsTomb1 self_)
		{
			if (11611 - 452128 != -440517)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (280407 - 382323 == -101916)
				{
					base..ctor();
					if (269330 - 176142 != 93189)
					{
						this.$data$44864 = data;
						if (204833 - 549971 != -345137)
						{
							this.$self_$44865 = self_;
							if (94415 - 399790 == -305375)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AC32 RID: 44082 RVA: 0x0131FDB4 File Offset: 0x0131DFB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb1.$onChangePlayer$44859.$(this.$data$44864, this.$self_$44865);
		}

		// Token: 0x0600AC33 RID: 44083 RVA: 0x0131FDC8 File Offset: 0x0131DFC8
		internal static bool HRvgpmVIL2HZECHgL60M()
		{
			return true;
		}

		// Token: 0x0600AC34 RID: 44084 RVA: 0x0131FDCC File Offset: 0x0131DFCC
		internal static bool tswYMoVIOL0orfwNpXpC()
		{
			return false;
		}

		// Token: 0x0400987B RID: 39035
		internal Hashtable $data$44864;

		// Token: 0x0400987C RID: 39036
		internal M971_MaohsTomb1 $self_$44865;

		// Token: 0x02001CC2 RID: 7362
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AC35 RID: 44085 RVA: 0x0131FDD0 File Offset: 0x0131DFD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb1 self_)
			{
				if (20605 - 61319 != -40714)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (137832 - 484245 == -346413)
					{
						base..ctor();
						if (271321 - 233404 == 37917)
						{
							this.$data$44862 = data;
							if (47794 - 582259 != -534464)
							{
								this.$self_$44863 = self_;
								if (267480 - 325230 != -57749)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AC36 RID: 44086 RVA: 0x0131FE8C File Offset: 0x0131E08C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (262737 - 522193 != -259456)
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
							if (296736 - 423457 == -126720)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (6967 - 183820 != -176853)
							{
								continue;
							}
							this.$mGameGui$44861 = (GameGui)this.$self_$44863.GetComponent(typeof(GameGui));
							if (1532 - 325250 != -323718)
							{
								continue;
							}
							this.$mGameGui$44861.enabled = true;
							if (132662 - 18709 != 113953)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (104193 - 328236 != -224043)
						{
							continue;
						}
						goto IL_205;
					default:
						if (41876 - 220124 != -178248)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (228793 - 3278 == 225515)
					{
						this.$self_$44863.SendMessage("onCreatePlayer", this.$data$44862);
						if (293402 - 516750 != -223347)
						{
							this.$mChangeGui$44860 = (ChangeGui)this.$self_$44863.GetComponent(typeof(ChangeGui));
							if (81598 - 175121 == -93523)
							{
								if (!this.$mChangeGui$44860.enabled)
								{
									break;
								}
								if (16418 - 152734 != -136315)
								{
									this.$mChangeGui$44860.close();
									if (91702 - 201354 == -109652)
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

			// Token: 0x0600AC37 RID: 44087 RVA: 0x013200B0 File Offset: 0x0131E2B0
			internal static bool kUnpuhVImkcIHg1bhwbx()
			{
				return true;
			}

			// Token: 0x0600AC38 RID: 44088 RVA: 0x013200B4 File Offset: 0x0131E2B4
			internal static bool C7whIFVIFuKItkF6CigA()
			{
				return false;
			}

			// Token: 0x0400987D RID: 39037
			internal ChangeGui $mChangeGui$44860;

			// Token: 0x0400987E RID: 39038
			internal GameGui $mGameGui$44861;

			// Token: 0x0400987F RID: 39039
			internal Hashtable $data$44862;

			// Token: 0x04009880 RID: 39040
			internal M971_MaohsTomb1 $self_$44863;
		}
	}

	// Token: 0x02001CC3 RID: 7363
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$44866 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AC39 RID: 44089 RVA: 0x013200B8 File Offset: 0x0131E2B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$44866(Hashtable data, M971_MaohsTomb1 self_)
		{
			if (292632 - 144194 != 148439)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (161857 - 453034 != -291176)
				{
					base..ctor();
					if (179996 - 532663 == -352667)
					{
						this.$data$44873 = data;
						if (209301 - 559434 != -350132)
						{
							this.$self_$44874 = self_;
							if (293889 - 367517 != -73627)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AC3A RID: 44090 RVA: 0x01320174 File Offset: 0x0131E374
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb1.$onGameComplete$44866.$(this.$data$44873, this.$self_$44874);
		}

		// Token: 0x0600AC3B RID: 44091 RVA: 0x01320188 File Offset: 0x0131E388
		internal static bool sq8LP1VIMl0k8kYFMTBV()
		{
			return true;
		}

		// Token: 0x0600AC3C RID: 44092 RVA: 0x0132018C File Offset: 0x0131E38C
		internal static bool aaCRjwVIx4YZYU2j4o7F()
		{
			return false;
		}

		// Token: 0x04009881 RID: 39041
		internal Hashtable $data$44873;

		// Token: 0x04009882 RID: 39042
		internal M971_MaohsTomb1 $self_$44874;

		// Token: 0x02001CC4 RID: 7364
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AC3D RID: 44093 RVA: 0x01320190 File Offset: 0x0131E390
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb1 self_)
			{
				if (108378 - 563848 != -455470)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (220944 - 142677 == 78267)
					{
						base..ctor();
						if (206998 - 218297 != -11298)
						{
							this.$data$44871 = data;
							if (223072 - 47183 != 175890)
							{
								this.$self_$44872 = self_;
								if (130605 - 14734 != 115872)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AC3E RID: 44094 RVA: 0x0132024C File Offset: 0x0131E44C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (289703 - 458304 != -168601)
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
						this.$mCompleteGui$44868 = (CompleteGui)this.$self_$44872.GetComponent(typeof(CompleteGui));
						if (24125 - 458493 != -434368)
						{
							continue;
						}
						this.$mCompleteGui$44868.Init();
						if (265976 - 162337 != 103639)
						{
							continue;
						}
						this.$mCompleteGui$44868.readData(this.$data$44871);
						if (196953 - 578129 == -381175)
						{
							continue;
						}
						if (this.$result$44867 == 1)
						{
							if (233822 - 541572 != -307750)
							{
								continue;
							}
							this.$mCompleteGui$44868.displayResult(eCompleteType.Success);
							if (90136 - 414387 == -324250)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$44868.displayResult(eCompleteType.Failed);
							if (290619 - 561423 != -270804)
							{
								continue;
							}
						}
						this.$mGameGui$44869 = (GameGui)this.$self_$44872.GetComponent(typeof(GameGui));
						if (49934 - 102506 == -52571)
						{
							continue;
						}
						this.$mStoryGui$44870 = (StoryGui)this.$self_$44872.GetComponent(typeof(StoryGui));
						if (121950 - 376164 != -254214)
						{
							continue;
						}
						if (this.$mGameGui$44869)
						{
							if (201251 - 154579 == 46673)
							{
								continue;
							}
							this.$mGameGui$44869.close();
							if (29496 - 195066 == -165569)
							{
								continue;
							}
						}
						if (this.$mStoryGui$44870)
						{
							if (239998 - 320120 != -80122)
							{
								continue;
							}
							this.$mStoryGui$44870.close();
							if (259819 - 270651 == -10831)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (233721 - 411702 != -177980)
						{
							goto Block_3;
						}
						continue;
					default:
						if (45081 - 236523 == -191441)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$44871[31]);
					if (83912 - 375137 == -291225)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (205907 - 117094 == 88813)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (245172 - 500724 == -255552)
							{
								this.$result$44867 = RuntimeServices.UnboxInt32(this.$data$44871[31]);
								if (43791 - 150709 != -106917)
								{
									goto Block_11;
								}
							}
						}
					}
				}
				Block_3:
				goto IL_352;
				Block_11:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x0600AC3F RID: 44095 RVA: 0x013205C0 File Offset: 0x0131E7C0
			internal static bool MTho8yVIg8weSwd0fKQI()
			{
				return true;
			}

			// Token: 0x0600AC40 RID: 44096 RVA: 0x013205C4 File Offset: 0x0131E7C4
			internal static bool YQcJ1gVIfgKaI38lZY7W()
			{
				return false;
			}

			// Token: 0x04009883 RID: 39043
			internal int $result$44867;

			// Token: 0x04009884 RID: 39044
			internal CompleteGui $mCompleteGui$44868;

			// Token: 0x04009885 RID: 39045
			internal GameGui $mGameGui$44869;

			// Token: 0x04009886 RID: 39046
			internal StoryGui $mStoryGui$44870;

			// Token: 0x04009887 RID: 39047
			internal Hashtable $data$44871;

			// Token: 0x04009888 RID: 39048
			internal M971_MaohsTomb1 $self_$44872;
		}
	}

	// Token: 0x02001CC5 RID: 7365
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$44875 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AC41 RID: 44097 RVA: 0x013205C8 File Offset: 0x0131E7C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$44875(M971_MaohsTomb1 self_)
		{
			if (72052 - 68805 != 3247)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (285589 - 109176 != 176414)
				{
					base..ctor();
					if (108655 - 114935 == -6280)
					{
						this.$self_$44879 = self_;
						if (131027 - 569364 == -438337)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AC42 RID: 44098 RVA: 0x01320660 File Offset: 0x0131E860
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb1.$ReturnToTown$44875.$(this.$self_$44879);
		}

		// Token: 0x0600AC43 RID: 44099 RVA: 0x01320670 File Offset: 0x0131E870
		internal static bool QGG473VInF3ICnBFmi7X()
		{
			return true;
		}

		// Token: 0x0600AC44 RID: 44100 RVA: 0x01320674 File Offset: 0x0131E874
		internal static bool DLJtCfVI6kYsXRI5GMXt()
		{
			return false;
		}

		// Token: 0x04009889 RID: 39049
		internal M971_MaohsTomb1 $self_$44879;

		// Token: 0x02001CC6 RID: 7366
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AC45 RID: 44101 RVA: 0x01320678 File Offset: 0x0131E878
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb1 self_)
			{
				if (147552 - 558870 != -411317)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (297132 - 477208 != -180075)
					{
						base..ctor();
						if (246092 - 154233 == 91859)
						{
							this.$self_$44878 = self_;
							if (243039 - 531818 != -288778)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AC46 RID: 44102 RVA: 0x01320710 File Offset: 0x0131E910
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (238577 - 582751 != -344174)
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
						this.$self_$44878.LeaveGame();
						if (117589 - 178893 == -61303)
						{
							continue;
						}
						this.YieldDefault(1);
						if (214497 - 258255 != -43758)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (197814 - 493637 != -295823)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (202785 - 255016 != -52230)
					{
						Game.mStateTime = Time.time;
						if (288275 - 2008 != 286268)
						{
							this.$$switch$8358$44876 = PlayerData.SaveGuild;
							if (72842 - 146574 != -73731)
							{
								if (this.$$switch$8358$44876 == 1)
								{
									if (87927 - 116495 != -28568)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (124804 - 226764 == -101959)
									{
										continue;
									}
								}
								else if (this.$$switch$8358$44876 == 2)
								{
									if (251920 - 443772 != -191852)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (167672 - 374687 != -207015)
									{
										continue;
									}
								}
								else if (this.$$switch$8358$44876 == 3)
								{
									if (82664 - 254971 != -172307)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (54617 - 137039 == -82421)
									{
										continue;
									}
								}
								else if (this.$$switch$8358$44876 == 4)
								{
									if (170815 - 234381 == -63565)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (108953 - 500267 != -391314)
									{
										continue;
									}
								}
								else if (this.$$switch$8358$44876 == 5)
								{
									if (116194 - 574981 != -458787)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (253753 - 331021 != -77268)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (179522 - 26209 != 153313)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (188134 - 421074 == -232939)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (269457 - 41955 != 227502)
									{
										continue;
									}
								}
								this.$mGameGui$44877 = (GameGui)this.$self_$44878.GetComponent(typeof(GameGui));
								if (101424 - 480516 == -379092)
								{
									if (this.$mGameGui$44877)
									{
										if (73275 - 30892 != 42383)
										{
											continue;
										}
										this.$mGameGui$44877.close();
										if (112675 - 239800 != -127125)
										{
											continue;
										}
									}
									this.$self_$44878.SendMessage("fadeOut");
									if (236701 - 363022 != -126320)
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

			// Token: 0x0600AC47 RID: 44103 RVA: 0x01320ADC File Offset: 0x0131ECDC
			internal static bool sO5MdgVIi5ANdMgnhLMq()
			{
				return true;
			}

			// Token: 0x0600AC48 RID: 44104 RVA: 0x01320AE0 File Offset: 0x0131ECE0
			internal static bool Dt4Uj1VIKttNKZ1AKTjc()
			{
				return false;
			}

			// Token: 0x0400988A RID: 39050
			internal int $$switch$8358$44876;

			// Token: 0x0400988B RID: 39051
			internal GameGui $mGameGui$44877;

			// Token: 0x0400988C RID: 39052
			internal M971_MaohsTomb1 $self_$44878;
		}
	}

	// Token: 0x02001CC7 RID: 7367
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$44880 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AC49 RID: 44105 RVA: 0x01320AE4 File Offset: 0x0131ECE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$44880(M971_MaohsTomb1 self_)
		{
			if (249768 - 428789 != -179020)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (260444 - 71687 == 188757)
				{
					base..ctor();
					if (5804 - 106311 != -100506)
					{
						this.$self_$44883 = self_;
						if (160346 - 103664 == 56682)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AC4A RID: 44106 RVA: 0x01320B7C File Offset: 0x0131ED7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb1.$ReturnToGuild$44880.$(this.$self_$44883);
		}

		// Token: 0x0600AC4B RID: 44107 RVA: 0x01320B8C File Offset: 0x0131ED8C
		internal static bool vcLL2OVIdDWSRKjjSpW7()
		{
			return true;
		}

		// Token: 0x0600AC4C RID: 44108 RVA: 0x01320B90 File Offset: 0x0131ED90
		internal static bool a4Au8nVIJGumwW2aw11M()
		{
			return false;
		}

		// Token: 0x0400988D RID: 39053
		internal M971_MaohsTomb1 $self_$44883;

		// Token: 0x02001CC8 RID: 7368
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AC4D RID: 44109 RVA: 0x01320B94 File Offset: 0x0131ED94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb1 self_)
			{
				if (280575 - 409578 != -129002)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (60075 - 432113 != -372037)
					{
						base..ctor();
						if (128232 - 157151 != -28918)
						{
							this.$self_$44882 = self_;
							if (278594 - 543154 != -264559)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AC4E RID: 44110 RVA: 0x01320C2C File Offset: 0x0131EE2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (278895 - 177128 != 101768)
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
						this.$self_$44882.LeaveGame();
						if (87325 - 26167 == 61159)
						{
							continue;
						}
						this.YieldDefault(1);
						if (151991 - 546033 != -394041)
						{
							goto Block_10;
						}
						continue;
					default:
						if (223954 - 446204 == -222249)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (129104 - 28320 != 100785)
					{
						Game.mStateTime = Time.time;
						if (228144 - 572642 == -344498)
						{
							Game.mNextGameCode = 31;
							if (220991 - 22875 != 198117)
							{
								this.$mGameGui$44881 = (GameGui)this.$self_$44882.GetComponent(typeof(GameGui));
								if (61062 - 99665 != -38602)
								{
									if (this.$mGameGui$44881)
									{
										if (92061 - 377785 == -285723)
										{
											continue;
										}
										this.$mGameGui$44881.close();
										if (220536 - 325536 != -105000)
										{
											continue;
										}
									}
									this.$self_$44882.SendMessage("fadeOut");
									if (228004 - 584121 == -356117)
									{
										goto IL_15B;
									}
								}
							}
						}
					}
				}
				Block_10:
				goto IL_1BD;
				IL_15B:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600AC4F RID: 44111 RVA: 0x01320E08 File Offset: 0x0131F008
			internal static bool uq3ZxYVIDTOKlywqXJ1A()
			{
				return true;
			}

			// Token: 0x0600AC50 RID: 44112 RVA: 0x01320E0C File Offset: 0x0131F00C
			internal static bool ae65HbVIvqHM7ry298ja()
			{
				return false;
			}

			// Token: 0x0400988E RID: 39054
			internal GameGui $mGameGui$44881;

			// Token: 0x0400988F RID: 39055
			internal M971_MaohsTomb1 $self_$44882;
		}
	}

	// Token: 0x02001CC9 RID: 7369
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$44884 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AC51 RID: 44113 RVA: 0x01320E10 File Offset: 0x0131F010
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$44884(M971_MaohsTomb1 self_)
		{
			if (177923 - 246444 != -68521)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (238932 - 593935 == -355003)
				{
					base..ctor();
					if (227515 - 47446 == 180069)
					{
						this.$self_$44888 = self_;
						if (275677 - 5767 == 269910)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AC52 RID: 44114 RVA: 0x01320EA8 File Offset: 0x0131F0A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb1.$ReturnToCamp$44884.$(this.$self_$44888);
		}

		// Token: 0x0600AC53 RID: 44115 RVA: 0x01320EB8 File Offset: 0x0131F0B8
		internal static bool k2SHsvVIRm4TuyEhpYfK()
		{
			return true;
		}

		// Token: 0x0600AC54 RID: 44116 RVA: 0x01320EBC File Offset: 0x0131F0BC
		internal static bool LjZedXVIwTfugphNoMOC()
		{
			return false;
		}

		// Token: 0x04009890 RID: 39056
		internal M971_MaohsTomb1 $self_$44888;

		// Token: 0x02001CCA RID: 7370
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AC55 RID: 44117 RVA: 0x01320EC0 File Offset: 0x0131F0C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb1 self_)
			{
				if (117007 - 74813 != 42195)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (151595 - 90811 == 60784)
					{
						base..ctor();
						if (48532 - 178166 != -129633)
						{
							this.$self_$44887 = self_;
							if (57861 - 169778 == -111917)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AC56 RID: 44118 RVA: 0x01320F58 File Offset: 0x0131F158
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (204680 - 41116 != 163565)
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
						this.$self_$44887.LeaveGame();
						if (78113 - 570387 == -492273)
						{
							continue;
						}
						this.YieldDefault(1);
						if (213673 - 426392 != -212719)
						{
							continue;
						}
						goto IL_363;
					default:
						if (127743 - 325895 != -198152)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (226769 - 379872 == -153103)
					{
						Game.mStateTime = Time.time;
						if (218398 - 262399 != -44000)
						{
							this.$$switch$8360$44885 = PlayerData.SaveGuild;
							if (190592 - 578270 != -387677)
							{
								if (this.$$switch$8360$44885 == 1)
								{
									if (1002 - 446141 == -445138)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (41488 - 573630 != -532142)
									{
										continue;
									}
								}
								else if (this.$$switch$8360$44885 == 2)
								{
									if (143743 - 231802 != -88059)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (108538 - 262094 == -153555)
									{
										continue;
									}
								}
								else if (this.$$switch$8360$44885 == 3)
								{
									if (34405 - 424692 == -390286)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (73151 - 593273 == -520121)
									{
										continue;
									}
								}
								else if (this.$$switch$8360$44885 == 4)
								{
									if (74803 - 228253 != -153450)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (3467 - 348188 != -344721)
									{
										continue;
									}
								}
								else if (this.$$switch$8360$44885 == 5)
								{
									if (96031 - 585405 != -489374)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (62565 - 580483 == -517917)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (277305 - 460164 == -182858)
									{
										continue;
									}
								}
								this.$mGameGui$44886 = (GameGui)this.$self_$44887.GetComponent(typeof(GameGui));
								if (47894 - 503066 != -455171)
								{
									if (this.$mGameGui$44886)
									{
										if (101228 - 324703 != -223475)
										{
											continue;
										}
										this.$mGameGui$44886.close();
										if (115100 - 134719 == -19618)
										{
											continue;
										}
									}
									this.$self_$44887.SendMessage("fadeOut");
									if (38608 - 305539 == -266931)
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

			// Token: 0x0600AC57 RID: 44119 RVA: 0x013212DC File Offset: 0x0131F4DC
			internal static bool YHbIN3VIqiqXMxBLRaR8()
			{
				return true;
			}

			// Token: 0x0600AC58 RID: 44120 RVA: 0x013212E0 File Offset: 0x0131F4E0
			internal static bool twx5WTVI7ueFMQdUGIZ9()
			{
				return false;
			}

			// Token: 0x04009891 RID: 39057
			internal int $$switch$8360$44885;

			// Token: 0x04009892 RID: 39058
			internal GameGui $mGameGui$44886;

			// Token: 0x04009893 RID: 39059
			internal M971_MaohsTomb1 $self_$44887;
		}
	}
}
