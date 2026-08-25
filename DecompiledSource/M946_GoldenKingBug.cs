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

// Token: 0x02001C2B RID: 7211
[Serializable]
public class M946_GoldenKingBug : MonoBehaviour
{
	// Token: 0x0600A85E RID: 43102 RVA: 0x012D6DBC File Offset: 0x012D4FBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M946_GoldenKingBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600A85F RID: 43103 RVA: 0x012D6DCC File Offset: 0x012D4FCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (194720 - 403832 != -209112)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (165471 - 229013 != -63541)
			{
				Game.mGameType = 5;
				if (137582 - 240331 == -102749)
				{
					if (Chat.Initialized)
					{
						if (221561 - 567331 == -345770)
						{
							Chat.ChatDisplay.Clear();
							if (146209 - 165246 == -19037)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (84277 - 61868 == 22409)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A860 RID: 43104 RVA: 0x012D6EB0 File Offset: 0x012D50B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (207186 - 130843 != 76344)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (133500 - 387871 != -254370)
				{
					if (Game.mNextGameCode != 946)
					{
						break;
					}
					if (10747 - 87944 != -77196)
					{
						Game.nextGame();
						if (261493 - 319342 != -57848)
						{
							Game.mGameCode = 946;
							if (90593 - 421496 == -330903)
							{
								Game.mGameType = 5;
								if (271932 - 503431 != -231498)
								{
									Game.mGameTime = Time.time;
									if (285134 - 298107 == -12973)
									{
										Game.mGameScore = 0;
										if (266611 - 347575 == -80964)
										{
											Game.mGameMana = 0;
											if (196653 - 205270 != -8616)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (25307 - 483083 == -457776)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (178399 - 171507 != 6893)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (259515 - 362076 != -102560)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (16626 - 270986 == -254360)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (130284 - 529236 != -398951)
																{
																	this.yIQntCO2Adu = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (5310 - 9133 != -3822)
																	{
																		this.yIQntCO2Adu.enabled = false;
																		if (61199 - 264059 == -202860)
																		{
																			this.TMUntZefLXP = PhotonClient.Connection;
																			if (267498 - 63507 != 203992)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (68506 - 599913 != -531406)
																				{
																					this.InitGame();
																					if (279866 - 282079 != -2212)
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
				if (299168 - 370364 != -71195)
				{
					Game.mGameType = 99;
					if (125206 - 468522 != -343315)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A861 RID: 43105 RVA: 0x012D71DC File Offset: 0x012D53DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (86794 - 118572 != -31777)
		{
		}
		for (;;)
		{
			if (this.TMUntZefLXP == null)
			{
				if (31371 - 500949 != -469577)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (46161 - 51390 != -5228)
				{
					if (mGameState == eGameState.Init)
					{
						if (62591 - 118813 != -56221)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (223196 - 450262 != -227065)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (158352 - 320627 != -162274)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (37211 - 369449 == -332238)
						{
							break;
						}
					}
					else
					{
						if (mGameState != eGameState.Start)
						{
							if (195792 - 415739 == -219946)
							{
								continue;
							}
							if (mGameState == eGameState.Normal)
							{
								if (113892 - 219340 == -105447)
								{
									continue;
								}
							}
							else if (mGameState == eGameState.Hold)
							{
								if (64544 - 266081 != -201536)
								{
									break;
								}
								continue;
							}
							else if (mGameState == eGameState.AllHold)
							{
								if (253821 - 186494 != 67328)
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
								if (178809 - 300499 != -121689)
								{
									break;
								}
								continue;
							}
						}
						if (Game.music != 0)
						{
							if (25809 - 578948 != -553139)
							{
								continue;
							}
							if (!this.audio.isPlaying)
							{
								if (153855 - 392335 == -238479)
								{
									continue;
								}
								this.audio.Play();
								if (287812 - 91883 == 195930)
								{
									continue;
								}
							}
						}
						this.audio.volume = 0.1f * (float)Game.music;
						if (167616 - 415594 == -247978)
						{
							if (Time.time <= this.FrRntMA1pRV)
							{
								break;
							}
							if (149163 - 419442 != -270278)
							{
								Game.mGameMana++;
								if (156740 - 420506 == -263766)
								{
									this.FrRntMA1pRV = Time.time + (float)12;
									if (91996 - 484728 == -392732)
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

	// Token: 0x0600A862 RID: 43106 RVA: 0x012D74D4 File Offset: 0x012D56D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (278823 - 419062 != -140239)
		{
		}
		for (;;)
		{
			if (!this.ovMntfpdvkS)
			{
				if (109960 - 524339 != -414378)
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
				if (280096 - 65265 != 214832)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (197960 - 206986 != -9025)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (260110 - 67992 == 192118)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (284697 - 303846 == -19149)
							{
								GUI.depth = 1;
								if (198288 - 496485 == -298197)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (208126 - 444121 != -235994)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (204551 - 491459 == -286908)
										{
											Color color = GUI.color;
											if (198176 - 229348 == -31172)
											{
												color.a = a;
												if (226072 - 326038 != -99965 && 160392 - 65166 != 95227)
												{
													Color color2 = GUI.color = color;
													if (141414 - 6115 != 135300 && 293286 - 525903 != -232616)
													{
														GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.ovMntfpdvkS);
														if (199241 - 290487 != -91245)
														{
															float a2 = 1f;
															if (4212 - 303795 == -299583)
															{
																Color color3 = GUI.color;
																if (200606 - 246469 != -45862)
																{
																	color3.a = a2;
																	if (169033 - 158087 != 10947 && 177149 - 545169 != -368019)
																	{
																		GUI.color = color3;
																		if (186307 - 223763 != -37455 && 21296 - 192046 != -170749)
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

	// Token: 0x0600A863 RID: 43107 RVA: 0x012D7854 File Offset: 0x012D5A54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M946_GoldenKingBug.$onGameEvent$44449(data, this).GetEnumerator();
	}

	// Token: 0x0600A864 RID: 43108 RVA: 0x012D7864 File Offset: 0x012D5A64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M946_GoldenKingBug.$StartEvent$44459(this).GetEnumerator();
	}

	// Token: 0x0600A865 RID: 43109 RVA: 0x012D7874 File Offset: 0x012D5A74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (171208 - 64232 != 106976)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (254958 - 306357 == -51399)
			{
				Time.timeScale = 1f;
				if (296354 - 391081 == -94727)
				{
					this.ovMntfpdvkS = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (66910 - 507651 == -440741)
					{
						Hashtable customOpParameters = new Hashtable();
						if (241426 - 116958 == 124468)
						{
							this.TMUntZefLXP.OpCustom(52, customOpParameters, true);
							if (156374 - 259207 != -102832)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A866 RID: 43110 RVA: 0x012D7978 File Offset: 0x012D5B78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (18241 - 338080 != -319838)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (273878 - 225925 != 47954)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (31389 - 220868 != -189478)
				{
					Game.mGameState = eGameState.Setup;
					if (299686 - 407701 != -108014)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A867 RID: 43111 RVA: 0x012D7A1C File Offset: 0x012D5C1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (99329 - 4033 != 95297)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (129255 - 107364 != 21892)
			{
				if (num == PlayerData.UID)
				{
					if (298273 - 570261 == -271988)
					{
						this.SetupActors();
						if (289400 - 145920 == 143480)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (290416 - 387753 == -97337)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A868 RID: 43112 RVA: 0x012D7AEC File Offset: 0x012D5CEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (243504 - 536453 != -292948)
		{
		}
		for (;;)
		{
			IL_87:
			Debug.Log("Creating Actors");
			if (142281 - 538463 == -396182)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (116604 - 201003 != -84398)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (115577 - 10651 != 104927)
						{
							int i = 0;
							if (153430 - 529803 != -376372)
							{
								CharacterControl[] array2 = array;
								if (71892 - 500460 == -428568)
								{
									int length = array2.Length;
									if (82697 - 419095 != -336397)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (284998 - 149432 == 135567)
												{
													goto IL_87;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (24304 - 263465 == -239160)
												{
													goto IL_87;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (90295 - 421593 == -331297)
												{
													goto IL_87;
												}
												this.cQ6ntwFBGt0++;
												if (148039 - 210126 != -62087)
												{
													goto IL_87;
												}
											}
											i++;
											if (36510 - 597271 != -560761)
											{
												goto IL_87;
											}
										}
										if (197620 - 322229 == -124609)
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
						if (33105 - 383306 == -350201)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A869 RID: 43113 RVA: 0x012D7D28 File Offset: 0x012D5F28
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (1253 - 461690 != -460436)
		{
		}
		for (;;)
		{
			IL_A8:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (291328 - 279515 == 11813)
			{
				int i = 0;
				if (97997 - 240334 != -142336)
				{
					CharacterControl[] array2 = array;
					if (65768 - 349201 != -283432)
					{
						int length = array2.Length;
						if (163793 - 171350 == -7557)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (113131 - 450740 == -337608)
								{
									goto IL_A8;
								}
								i++;
								if (7953 - 129470 == -121516)
								{
									goto IL_A8;
								}
							}
							if (47068 - 236630 != -189561)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A86A RID: 43114 RVA: 0x012D7E58 File Offset: 0x012D6058
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (135181 - 582808 != -447626)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (167181 - 101883 == 65298)
			{
				Game.mGameState = eGameState.Ready;
				if (276363 - 108252 == 168111)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (152895 - 482170 == -329275)
					{
						if (299015 - 431295 != -132279)
						{
							GameObject gameObject = null;
							if (11189 - 413990 == -402801)
							{
								GameObject gameObject2;
								if (playerSlot >= 1)
								{
									if (159647 - 533293 == -373645)
									{
										continue;
									}
									if (playerSlot <= 12)
									{
										if (276278 - 447172 == -170893)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartPoint" + playerSlot);
										if (189539 - 160713 == 28827)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + playerSlot);
										if (43137 - 247505 != -204368)
										{
											continue;
										}
										goto IL_186;
									}
								}
								gameObject2 = GameObject.Find("StartPoint1");
								if (115598 - 138281 != -22683)
								{
									continue;
								}
								IL_186:
								if (gameObject2)
								{
									if (132221 - 122624 != 9597)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (53568 - 592223 == -538654)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (224708 - 79718 == 144991)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (241378 - 263756 != -22378)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (95255 - 195202 == -99946)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (287048 - 532284 != -245235)
								{
									this.transform.position = gameObject.transform.position;
									if (229148 - 382703 == -153555)
									{
										this.transform.rotation = gameObject.transform.rotation;
										if (61145 - 388063 == -326918)
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

	// Token: 0x0600A86B RID: 43115 RVA: 0x012D817C File Offset: 0x012D637C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		Debug.Log("Start Game");
		this.StartCoroutine_Auto(this.StartEvent());
	}

	// Token: 0x0600A86C RID: 43116 RVA: 0x012D8198 File Offset: 0x012D6398
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600A86D RID: 43117 RVA: 0x012D819C File Offset: 0x012D639C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (255381 - 23424 != 231958)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (160986 - 128570 == 32416)
			{
				if (gameObject)
				{
					if (285032 - 287699 == -2667)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (128772 - 186003 == -57231)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (250307 - 408089 != -157781)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A86E RID: 43118 RVA: 0x012D8298 File Offset: 0x012D6498
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (131014 - 300453 != -169438)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (272144 - 531252 == -259108)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (98709 - 250971 == -152262)
				{
					hashtable.Add(43, PlayerData.UID);
					if (34146 - 344795 == -310649)
					{
						hashtable.Add(73, nType);
						if (174549 - 345580 != -171030)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (95522 - 194448 == -98926)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (214840 - 598599 != -383758)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (8738 - 48123 != -39384)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (197655 - 23330 == 174325)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (179573 - 234430 != -54856)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (272120 - 343466 == -71346)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (74732 - 288156 == -213424)
													{
														this.TMUntZefLXP.OpCustom(63, hashtable, true);
														if (132746 - 237015 == -104269)
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

	// Token: 0x0600A86F RID: 43119 RVA: 0x012D857C File Offset: 0x012D677C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (171882 - 591177 != -419294)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (33160 - 554334 == -521174)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (102777 - 49384 == 53393)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (64676 - 599085 == -534409)
						{
							if (this.cQ6ntwFBGt0 <= 0)
							{
								break;
							}
							if (222574 - 30060 != 192515)
							{
								this.cQ6ntwFBGt0--;
								if (286078 - 135722 != 150357)
								{
									if (this.cQ6ntwFBGt0 != 0)
									{
										break;
									}
									if (295909 - 596610 == -300701)
									{
										Game.setGameState(eGameState.Ready);
										if (244156 - 148660 == 95496)
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
						if (263193 - 578152 == -314959)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (21791 - 171269 == -149478)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A870 RID: 43120 RVA: 0x012D870C File Offset: 0x012D690C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600A871 RID: 43121 RVA: 0x012D8720 File Offset: 0x012D6920
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (3637 - 95378 != -91740)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (241362 - 61202 == 180160)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (159894 - 576614 == -416720)
				{
					if (!characterControl)
					{
						break;
					}
					if (295396 - 583824 != -288427)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (180014 - 580158 != -400143)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (88696 - 128468 == -39772)
							{
								string type = characterControl.Type;
								if (239328 - 582167 == -342839)
								{
									if (type == "GoldenKingBug")
									{
										if (57821 - 107664 != -49842)
										{
											Game.sendMissionEvent(9462, 0);
											if (247229 - 207332 == 39897)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "GoldenKingBug2"))
										{
											break;
										}
										if (92519 - 219912 != -127392)
										{
											Game.sendMissionEvent(9462, 1);
											if (5855 - 492362 == -486507)
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

	// Token: 0x0600A872 RID: 43122 RVA: 0x012D88EC File Offset: 0x012D6AEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (171518 - 306534 != -135016)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (273071 - 366134 == -93063)
			{
				hashtable.Add(71, CID);
				if (34940 - 524662 != -489721)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (81984 - 523167 == -441183)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (97064 - 433088 == -336024)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (178098 - 214157 == -36059)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (246517 - 350073 == -103556)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (243453 - 583585 != -340131)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (37521 - 52590 == -15069)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (224013 - 438109 != -214095)
											{
												this.TMUntZefLXP.OpCustom(61, hashtable, true);
												if (35209 - 533127 != -497917)
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

	// Token: 0x0600A873 RID: 43123 RVA: 0x012D8B78 File Offset: 0x012D6D78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (298616 - 553525 != -254909)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (102056 - 93649 != 8408)
			{
				if (!gameObject)
				{
					break;
				}
				if (116634 - 317602 == -200968)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (292977 - 375995 != -83017)
					{
						playerCameraControl.target = gameObject;
						if (19791 - 588419 != -568627)
						{
							this.StartGame();
							if (166670 - 310307 != -143636)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A874 RID: 43124 RVA: 0x012D8C68 File Offset: 0x012D6E68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (59093 - 300989 != -241896)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (139819 - 104718 == 35101)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (185345 - 355102 == -169757)
				{
					gameGui.ResetTeamBar();
					if (85857 - 367515 == -281658)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A875 RID: 43125 RVA: 0x012D8D14 File Offset: 0x012D6F14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M946_GoldenKingBug.$onDeadPlayer$44468(this).GetEnumerator();
	}

	// Token: 0x0600A876 RID: 43126 RVA: 0x012D8D24 File Offset: 0x012D6F24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (1377 - 378478 != -377101)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (82755 - 77956 != 4800)
			{
				this.yIQntCO2Adu.target = Game.mPlayer;
				if (255947 - 260963 != -5015)
				{
					this.yIQntCO2Adu.enabled = true;
					if (47996 - 430015 != -382018)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (291092 - 283924 == 7169)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (211786 - 294009 == -82222)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (244393 - 411911 != -167517)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (273827 - 216313 != 57515)
							{
								if (!gameGui)
								{
									break;
								}
								if (273150 - 193191 != 79960)
								{
									gameGui.enabled = true;
									if (179892 - 460254 != -280361)
									{
										gameGui.closeDeadMenu();
										if (54862 - 390238 == -335376)
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

	// Token: 0x0600A877 RID: 43127 RVA: 0x012D8ED0 File Offset: 0x012D70D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (128258 - 403875 != -275617)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (262608 - 58666 != 203943)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (268988 - 439868 != -170879)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (206861 - 73042 == 133819)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A878 RID: 43128 RVA: 0x012D8F94 File Offset: 0x012D7194
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600A879 RID: 43129 RVA: 0x012D8FC0 File Offset: 0x012D71C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (263531 - 27403 != 236128)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (85704 - 382965 == -297261)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (257878 - 302833 != -44954)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (146728 - 493288 != -346559)
					{
						Hashtable hashtable = new Hashtable();
						if (147097 - 399164 == -252067)
						{
							hashtable.Add(43, PlayerData.UID);
							if (77340 - 43792 == 33548)
							{
								hashtable.Add(71, nCID);
								if (70304 - 305318 == -235014)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (109068 - 348343 == -239275)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (152112 - 183533 != -31420)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (104546 - 425877 == -321331)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (144617 - 337662 == -193045)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (287935 - 482994 == -195059)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (278716 - 443420 == -164704)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (97866 - 23732 == 74134)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (123653 - 84144 != 39510)
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

	// Token: 0x0600A87A RID: 43130 RVA: 0x012D92E0 File Offset: 0x012D74E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M946_GoldenKingBug.$onChangePlayer$44474(data, this).GetEnumerator();
	}

	// Token: 0x0600A87B RID: 43131 RVA: 0x012D92F0 File Offset: 0x012D74F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M946_GoldenKingBug.$onGameComplete$44481(data, this).GetEnumerator();
	}

	// Token: 0x0600A87C RID: 43132 RVA: 0x012D9300 File Offset: 0x012D7500
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M946_GoldenKingBug.$ReturnToTown$44491(this).GetEnumerator();
	}

	// Token: 0x0600A87D RID: 43133 RVA: 0x012D9310 File Offset: 0x012D7510
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M946_GoldenKingBug.$ReturnToGuild$44496(this).GetEnumerator();
	}

	// Token: 0x0600A87E RID: 43134 RVA: 0x012D9320 File Offset: 0x012D7520
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M946_GoldenKingBug.$ReturnToCamp$44500(this).GetEnumerator();
	}

	// Token: 0x0600A87F RID: 43135 RVA: 0x012D9330 File Offset: 0x012D7530
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (38662 - 294096 != -255434)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (219913 - 274776 != -54862)
			{
				Hashtable hashtable = new Hashtable();
				if (46797 - 515546 == -468749)
				{
					hashtable.Add(43, PlayerData.UID);
					if (56657 - 259313 != -202655)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (244135 - 91470 != 152666)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A880 RID: 43136 RVA: 0x012D9408 File Offset: 0x012D7608
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600A881 RID: 43137 RVA: 0x012D941C File Offset: 0x012D761C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (68982 - 562716 != -493734)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (163703 - 220160 == -56457)
			{
				Hashtable hashtable = new Hashtable();
				if (261144 - 521515 != -260370)
				{
					if (Game.mNextGameCode == 30)
					{
						if (77557 - 79887 != -2330)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (216345 - 333315 != -116970)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (289722 - 387061 == -97338)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (164476 - 406634 != -242158)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (134331 - 106010 == 28322)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (8500 - 291050 == -282549)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (77652 - 156244 != -78592)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (135131 - 100671 == 34461)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (250044 - 508232 == -258187)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (9119 - 100251 == -91131)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (107547 - 69839 == 37709)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (226579 - 402073 == -175493)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (126598 - 235509 != -108911)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (213746 - 534939 != -321193)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (111104 - 461146 == -350041)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (75617 - 242427 != -166810)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (22682 - 237502 != -214820)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (252194 - 66346 == 185849)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (299525 - 334712 != -35187)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (195461 - 362434 != -166973)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (236957 - 124006 == 112952)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (184782 - 579751 != -394969)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (59760 - 519350 != -459590)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (298366 - 136727 != 161639)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (154666 - 388637 == -233970)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (271481 - 446691 == -175209)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (123212 - 520433 != -397221)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (21304 - 213884 != -192580)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (199635 - 471630 == -271995)
					{
						this.TMUntZefLXP.OpCustom(42, hashtable, true);
						if (291578 - 325787 == -34209)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A882 RID: 43138 RVA: 0x012D99D0 File Offset: 0x012D7BD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600A883 RID: 43139 RVA: 0x012D99E0 File Offset: 0x012D7BE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600A884 RID: 43140 RVA: 0x012D99E4 File Offset: 0x012D7BE4
	internal static bool T1x6iaV7ic6HN6MO87jX()
	{
		return true;
	}

	// Token: 0x0600A885 RID: 43141 RVA: 0x012D99E8 File Offset: 0x012D7BE8
	internal static bool slAmp3V7KDaL8ACQ4l2n()
	{
		return false;
	}

	// Token: 0x040095D3 RID: 38355
	private LitePeer TMUntZefLXP;

	// Token: 0x040095D4 RID: 38356
	private PlayerCameraControl yIQntCO2Adu;

	// Token: 0x040095D5 RID: 38357
	private float FrRntMA1pRV;

	// Token: 0x040095D6 RID: 38358
	private Texture ovMntfpdvkS;

	// Token: 0x040095D7 RID: 38359
	private int dHpntL0ElN4;

	// Token: 0x040095D8 RID: 38360
	public GameObject warp_cast;

	// Token: 0x040095D9 RID: 38361
	public GameObject warp_effect;

	// Token: 0x040095DA RID: 38362
	private int cQ6ntwFBGt0;

	// Token: 0x02001C2C RID: 7212
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$44449 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A886 RID: 43142 RVA: 0x012D99EC File Offset: 0x012D7BEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$44449(Hashtable data, M946_GoldenKingBug self_)
		{
			if (139718 - 291106 != -151387)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (14217 - 402293 == -388076)
				{
					base..ctor();
					if (298641 - 591059 != -292417)
					{
						this.$data$44457 = data;
						if (79058 - 17017 != 62042)
						{
							this.$self_$44458 = self_;
							if (56892 - 465314 == -408422)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A887 RID: 43143 RVA: 0x012D9AA8 File Offset: 0x012D7CA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M946_GoldenKingBug.$onGameEvent$44449.$(this.$data$44457, this.$self_$44458);
		}

		// Token: 0x0600A888 RID: 43144 RVA: 0x012D9ABC File Offset: 0x012D7CBC
		internal static bool Ioi478V7d3b9CK32VP9l()
		{
			return true;
		}

		// Token: 0x0600A889 RID: 43145 RVA: 0x012D9AC0 File Offset: 0x012D7CC0
		internal static bool KWaTqfV7JJiHfskF7TCE()
		{
			return false;
		}

		// Token: 0x040095DB RID: 38363
		internal Hashtable $data$44457;

		// Token: 0x040095DC RID: 38364
		internal M946_GoldenKingBug $self_$44458;

		// Token: 0x02001C2D RID: 7213
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A88A RID: 43146 RVA: 0x012D9AC4 File Offset: 0x012D7CC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M946_GoldenKingBug self_)
			{
				if (55499 - 410315 != -354815)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (233336 - 22400 == 210936)
					{
						base..ctor();
						if (176397 - 433063 != -256665)
						{
							this.$data$44455 = data;
							if (267757 - 166661 == 101096)
							{
								this.$self_$44456 = self_;
								if (132787 - 266434 == -133647)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A88B RID: 43147 RVA: 0x012D9B80 File Offset: 0x012D7D80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (272093 - 444637 != -172544)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_42C;
					case 2:
						if (Game.mGameState <= eGameState.AllHold)
						{
							if (277055 - 479660 == -202604)
							{
								continue;
							}
							Game.sendMissionEvent(9463, 0);
							if (278036 - 219110 == 58927)
							{
								continue;
							}
						}
						goto IL_149;
					default:
						if (150433 - 53121 != 97312)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (31451 - 255130 != -223678)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$returnCode$44450 = RuntimeServices.UnboxInt32(this.$data$44455[141]);
						if (232054 - 245410 == -13355)
						{
							continue;
						}
						this.$returnValue$44451 = RuntimeServices.UnboxInt32(this.$data$44455[145]);
						if (194865 - 172110 != 22755)
						{
							continue;
						}
						this.$ownerID$44452 = RuntimeServices.UnboxInt32(this.$data$44455[43]);
						if (238470 - 86553 != 151917)
						{
							continue;
						}
						this.$$switch$8206$44453 = this.$returnCode$44450;
						if (176423 - 402704 == -226280)
						{
							continue;
						}
						if (this.$$switch$8206$44453 == 9461)
						{
							if (198154 - 224634 != -26480)
							{
								continue;
							}
						}
						else if (this.$$switch$8206$44453 == -9461)
						{
							if (122194 - 287351 == -165156)
							{
								continue;
							}
							if (this.$ownerID$44452 == PlayerData.UID)
							{
								if (51894 - 252276 != -200382)
								{
									continue;
								}
								this.$mSpawnPoint$44454 = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(1, 6));
								if (269494 - 323684 != -54190)
								{
									continue;
								}
								if (this.$mSpawnPoint$44454)
								{
									if (69316 - 226198 != -156882)
									{
										continue;
									}
									if (Game.useAdvanceMode)
									{
										if (174194 - 364811 == -190616)
										{
											continue;
										}
										this.$self_$44456.createActor("GoldenKingBug2", 6, this.$mSpawnPoint$44454.transform.position, this.$mSpawnPoint$44454.transform.forward);
										if (128540 - 495514 != -366974)
										{
											continue;
										}
									}
									else
									{
										this.$self_$44456.createActor("GoldenKingBug", 6, this.$mSpawnPoint$44454.transform.position, this.$mSpawnPoint$44454.transform.forward);
										if (126913 - 303226 == -176312)
										{
											continue;
										}
									}
								}
							}
						}
						else if (this.$$switch$8206$44453 == 9462)
						{
							if (195711 - 408561 == -212849)
							{
								continue;
							}
							Debug.Log("On GoldenKingBug Dead");
							if (178670 - 116527 != 62144)
							{
								goto Block_6;
							}
							continue;
						}
						else if (this.$$switch$8206$44453 == 9463)
						{
							if (128861 - 333387 != -204526)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Warning unknown returnCode:" + this.$returnCode$44450);
							if (67137 - 536532 == -469394)
							{
								continue;
							}
						}
					}
					IL_149:
					this.YieldDefault(1);
				}
				while (92297 - 87851 != 4446);
				goto IL_42C;
				Block_6:
				return this.Yield(2, new WaitForSeconds((float)6));
				IL_42C:
				return false;
			}

			// Token: 0x0600A88C RID: 43148 RVA: 0x012D9FCC File Offset: 0x012D81CC
			internal static bool RD84sHV7D77eQZ6LKUgT()
			{
				return true;
			}

			// Token: 0x0600A88D RID: 43149 RVA: 0x012D9FD0 File Offset: 0x012D81D0
			internal static bool yxpwgDV7vL75xppHNRIn()
			{
				return false;
			}

			// Token: 0x040095DD RID: 38365
			internal int $returnCode$44450;

			// Token: 0x040095DE RID: 38366
			internal int $returnValue$44451;

			// Token: 0x040095DF RID: 38367
			internal int $ownerID$44452;

			// Token: 0x040095E0 RID: 38368
			internal int $$switch$8206$44453;

			// Token: 0x040095E1 RID: 38369
			internal GameObject $mSpawnPoint$44454;

			// Token: 0x040095E2 RID: 38370
			internal Hashtable $data$44455;

			// Token: 0x040095E3 RID: 38371
			internal M946_GoldenKingBug $self_$44456;
		}
	}

	// Token: 0x02001C2E RID: 7214
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$44459 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A88E RID: 43150 RVA: 0x012D9FD4 File Offset: 0x012D81D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$44459(M946_GoldenKingBug self_)
		{
			if (200768 - 196501 != 4267)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (103588 - 229191 != -125602)
				{
					base..ctor();
					if (194480 - 500282 == -305802)
					{
						this.$self_$44467 = self_;
						if (257331 - 507510 == -250179)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A88F RID: 43151 RVA: 0x012DA06C File Offset: 0x012D826C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M946_GoldenKingBug.$StartEvent$44459.$(this.$self_$44467);
		}

		// Token: 0x0600A890 RID: 43152 RVA: 0x012DA07C File Offset: 0x012D827C
		internal static bool vHNwvkV7RfFjmXWflwAC()
		{
			return true;
		}

		// Token: 0x0600A891 RID: 43153 RVA: 0x012DA080 File Offset: 0x012D8280
		internal static bool w5436jV7wCGFwxoKDP8H()
		{
			return false;
		}

		// Token: 0x040095E4 RID: 38372
		internal M946_GoldenKingBug $self_$44467;

		// Token: 0x02001C2F RID: 7215
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A892 RID: 43154 RVA: 0x012DA084 File Offset: 0x012D8284
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M946_GoldenKingBug self_)
			{
				if (62353 - 164592 != -102238)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (159626 - 53223 == 106403)
					{
						base..ctor();
						if (164010 - 422190 == -258180)
						{
							this.$self_$44466 = self_;
							if (112255 - 264533 != -152277)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A893 RID: 43155 RVA: 0x012DA11C File Offset: 0x012D831C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (676 - 213815 != -213138)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_114;
					case 1:
						goto IL_C05;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (181729 - 291599 != -109870)
							{
								continue;
							}
							goto IL_99A;
						}
						else
						{
							this.$self_$44466.yIQntCO2Adu.StartCoroutine_Auto(this.$self_$44466.yIQntCO2Adu.slerpToObject("EventCamera2", (float)2));
							if (16963 - 35401 != -18438)
							{
								continue;
							}
							goto IL_6A1;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (100114 - 348782 != -248667)
							{
								goto Block_46;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44461 = (StoryGui)this.$self_$44466.GetComponent(typeof(StoryGui));
							if (60703 - 48369 == 12335)
							{
								continue;
							}
							if (this.$mStoryGui$44461)
							{
								if (232598 - 346328 == -113729)
								{
									continue;
								}
								this.$mStoryGui$44461.startStoryMessage("Walrus", "Reggu", eTalkType.friend);
								if (154921 - 367507 != -212586)
								{
									continue;
								}
								goto IL_220;
							}
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (107333 - 166909 != -59575)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44461.newStoryMessage("Walrus", "Reggu", Language.getMessage("M946_GoldenKingBug", 101), eTalkType.friend);
							if (122924 - 321464 != -198540)
							{
								continue;
							}
							if (!this.$mWalrus$44460)
							{
								goto IL_33D;
							}
							if (214603 - 574707 == -360103)
							{
								continue;
							}
							this.$mWalrus$44460.animation.Play("talk");
							if (88541 - 589345 != -500803)
							{
								goto Block_79;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (38973 - 63414 != -24441)
							{
								continue;
							}
							goto IL_2FB;
						}
						else
						{
							this.$mStoryGui$44461.newStoryMessage("Walrus", "Reggu", Language.getMessage("M946_GoldenKingBug", 102), eTalkType.friend);
							if (183682 - 418305 != -234622)
							{
								goto Block_21;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (249332 - 433920 != -184588)
							{
								continue;
							}
							goto IL_7E;
						}
						else
						{
							this.$mStoryGui$44461.newStoryMessage("Walrus", "Reggu", Language.getMessage("M946_GoldenKingBug", 103), eTalkType.friend);
							if (104152 - 341868 != -237716)
							{
								continue;
							}
							if (!this.$mWalrus$44460)
							{
								goto IL_134;
							}
							if (195166 - 595050 == -399883)
							{
								continue;
							}
							this.$mWalrus$44460.animation.Play("root");
							if (229621 - 112733 != 116888)
							{
								continue;
							}
							goto IL_134;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (277714 - 382612 != -104898)
							{
								continue;
							}
							goto IL_5D1;
						}
						else
						{
							this.$mStoryGui$44461.newStoryMessage("Walrus", "Reggu", Language.getMessage("M946_GoldenKingBug", 104), eTalkType.friend);
							if (208415 - 304672 == -96256)
							{
								continue;
							}
							this.$self_$44466.yIQntCO2Adu.alignToObject("EventCamera3");
							if (260924 - 392544 != -131620)
							{
								continue;
							}
							goto IL_465;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (225616 - 76563 != 149053)
							{
								continue;
							}
							goto IL_25B;
						}
						else
						{
							this.$mStoryGui$44461.newStoryMessage("Walrus", "Reggu", Language.getMessage("M946_GoldenKingBug", 105), eTalkType.friend);
							if (258876 - 102019 != 156858)
							{
								goto Block_17;
							}
							continue;
						}
						break;
					case 9:
						if (!this.$mWalrus$44460)
						{
							goto IL_7D9;
						}
						if (100156 - 476374 == -376217)
						{
							continue;
						}
						this.$mWalrus$44460.animation.Play("cast1");
						if (230763 - 105148 != 125615)
						{
							continue;
						}
						if (!this.$self_$44466.warp_cast)
						{
							goto IL_7D9;
						}
						if (290634 - 234562 != 56072)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$44466.warp_cast, this.$mWalrus$44460.transform.position, this.$mWalrus$44460.transform.rotation);
						if (29938 - 563306 != -533368)
						{
							continue;
						}
						goto IL_7D9;
					case 10:
						if (Game.mGameState != eGameState.Start)
						{
							if (119202 - 66286 != 52917)
							{
								goto Block_56;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44461.close();
							if (237389 - 257143 == -19753)
							{
								continue;
							}
							this.$self_$44466.SendMessage("fadeOut");
							if (10502 - 190696 != -180193)
							{
								goto Block_68;
							}
							continue;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.Start)
						{
							if (79735 - 597026 != -517291)
							{
								continue;
							}
							goto IL_29D;
						}
						else
						{
							this.$slot$44462 = Game.getPlayerSlot(PlayerData.UID);
							if (12954 - 69302 == -56347)
							{
								continue;
							}
							this.$mWarpPoint$44463 = GameObject.Find("WarpPoint" + this.$slot$44462);
							if (166354 - 546064 == -379709)
							{
								continue;
							}
							if (this.$mWarpPoint$44463)
							{
								if (60226 - 61122 == -895)
								{
									continue;
								}
								Game.mPlayer.transform.position = this.$mWarpPoint$44463.transform.position;
								if (39152 - 130150 == -90997)
								{
									continue;
								}
								Game.mPlayer.transform.rotation = this.$mWarpPoint$44463.transform.rotation;
								if (198737 - 453704 != -254967)
								{
									continue;
								}
								if (this.$self_$44466.warp_effect)
								{
									if (53215 - 119653 != -66438)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$44466.warp_effect, this.$mWarpPoint$44463.transform.position, this.$mWarpPoint$44463.transform.rotation);
									if (282483 - 347758 == -65274)
									{
										continue;
									}
								}
								this.$mPlayerChar$44464 = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
								if (163398 - 38159 != 125239)
								{
									continue;
								}
								if (this.$mPlayerChar$44464)
								{
									if (50534 - 505721 != -455187)
									{
										continue;
									}
									this.$mPlayerChar$44464.PositionEvent();
									if (206303 - 225896 != -19593)
									{
										continue;
									}
								}
								this.$self_$44466.yIQntCO2Adu.alignToObject("WarpCamera" + this.$slot$44462);
								if (121858 - 327614 != -205756)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find WarpPoint" + this.$slot$44462);
								if (33703 - 357559 != -323856)
								{
									continue;
								}
							}
							Game.sendMissionEvent(9461, 0);
							if (10087 - 1833 == 8255)
							{
								continue;
							}
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.Start)
						{
							if (68838 - 258739 != -189900)
							{
								goto Block_73;
							}
							continue;
						}
						else
						{
							this.$mGameGui$44465 = (GameGui)this.$self_$44466.GetComponent(typeof(GameGui));
							if (117658 - 410341 != -292683)
							{
								continue;
							}
							this.$mGameGui$44465.enabled = true;
							if (66300 - 248991 != -182691)
							{
								continue;
							}
							goto IL_B24;
						}
						break;
					case 13:
						Game.mGameState = eGameState.Normal;
						if (88819 - 560410 == -471590)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (273124 - 590149 == -317024)
						{
							continue;
						}
						this.YieldDefault(1);
						if (287027 - 365256 != -78229)
						{
							continue;
						}
						goto IL_C05;
					default:
						if (29219 - 309649 != -280430)
						{
							continue;
						}
						goto IL_114;
					}
					if (this.$mWalrus$44460)
					{
						if (220113 - 259164 != -39051)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.$mWalrus$44460);
						if (54376 - 115630 == -61253)
						{
							continue;
						}
					}
					this.$self_$44466.SendMessage("fadeIn");
					if (18727 - 50590 != -31863)
					{
						continue;
					}
					this.$self_$44466.yIQntCO2Adu.enabled = true;
					if (29487 - 485270 != -455783)
					{
						continue;
					}
					goto IL_A7F;
					IL_114:
					Game.mGameState = eGameState.Start;
					if (57327 - 190227 != -132899)
					{
						Game.mGameTime = Time.time;
						if (296304 - 352710 != -56405)
						{
							this.$mWalrus$44460 = GameObject.Find("Walrus");
							if (284842 - 470400 == -185558)
							{
								this.$self_$44466.yIQntCO2Adu.alignToObject("EventCamera1");
								if (129479 - 61056 == 68423)
								{
									this.$self_$44466.SendMessage("fadeIn");
									if (11562 - 337302 != -325739)
									{
										goto Block_14;
									}
								}
							}
						}
					}
				}
				IL_7E:
				goto IL_C05;
				IL_134:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_14:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_220:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_16:
				IL_25B:
				goto IL_C05;
				Block_17:
				return this.Yield(9, new WaitForSeconds(2f));
				IL_29D:
				IL_2FB:
				goto IL_C05;
				Block_21:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_33D:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_465:
				return this.Yield(8, new WaitForSeconds(3f));
				IL_5D1:
				goto IL_C05;
				IL_6A1:
				return this.Yield(3, new WaitForSeconds(2f));
				Block_46:
				goto IL_C05;
				IL_7D9:
				return this.Yield(10, new WaitForSeconds(1f));
				Block_56:
				IL_99A:
				goto IL_C05;
				Block_68:
				return this.Yield(11, new WaitForSeconds(0.6f));
				IL_A7F:
				return this.Yield(12, new WaitForSeconds(0.5f));
				Block_73:
				goto IL_C05;
				IL_B24:
				return this.Yield(13, new WaitForSeconds(0.5f));
				Block_79:
				goto IL_33D;
				IL_C05:
				return false;
			}

			// Token: 0x0600A894 RID: 43156 RVA: 0x012DAD40 File Offset: 0x012D8F40
			internal static bool H16a6bV7qQPIwMMnHvF2()
			{
				return true;
			}

			// Token: 0x0600A895 RID: 43157 RVA: 0x012DAD44 File Offset: 0x012D8F44
			internal static bool mEFSEmV77DyDlLUExAuT()
			{
				return false;
			}

			// Token: 0x040095E5 RID: 38373
			internal GameObject $mWalrus$44460;

			// Token: 0x040095E6 RID: 38374
			internal StoryGui $mStoryGui$44461;

			// Token: 0x040095E7 RID: 38375
			internal int $slot$44462;

			// Token: 0x040095E8 RID: 38376
			internal GameObject $mWarpPoint$44463;

			// Token: 0x040095E9 RID: 38377
			internal CharacterControl $mPlayerChar$44464;

			// Token: 0x040095EA RID: 38378
			internal GameGui $mGameGui$44465;

			// Token: 0x040095EB RID: 38379
			internal M946_GoldenKingBug $self_$44466;
		}
	}

	// Token: 0x02001C30 RID: 7216
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$44468 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A896 RID: 43158 RVA: 0x012DAD48 File Offset: 0x012D8F48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$44468(M946_GoldenKingBug self_)
		{
			if (299519 - 345408 != -45888)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (233208 - 336631 == -103423)
				{
					base..ctor();
					if (38960 - 557471 == -518511)
					{
						this.$self_$44473 = self_;
						if (234824 - 73162 != 161663)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A897 RID: 43159 RVA: 0x012DADE0 File Offset: 0x012D8FE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M946_GoldenKingBug.$onDeadPlayer$44468.$(this.$self_$44473);
		}

		// Token: 0x0600A898 RID: 43160 RVA: 0x012DADF0 File Offset: 0x012D8FF0
		internal static bool MAP1q9V7P8krWWUWu0Zj()
		{
			return true;
		}

		// Token: 0x0600A899 RID: 43161 RVA: 0x012DADF4 File Offset: 0x012D8FF4
		internal static bool jfLIU6V70lV10wP3XKiX()
		{
			return false;
		}

		// Token: 0x040095EC RID: 38380
		internal M946_GoldenKingBug $self_$44473;

		// Token: 0x02001C31 RID: 7217
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A89A RID: 43162 RVA: 0x012DADF8 File Offset: 0x012D8FF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M946_GoldenKingBug self_)
			{
				if (31746 - 177407 != -145660)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (211214 - 54121 != 157094)
					{
						base..ctor();
						if (268865 - 420807 == -151942)
						{
							this.$self_$44472 = self_;
							if (191729 - 117791 != 73939)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A89B RID: 43163 RVA: 0x012DAE90 File Offset: 0x012D9090
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (299377 - 35018 != 264359)
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
							if (223423 - 393715 == -170291)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_C4;
							}
							if (203255 - 111453 != 91802)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (14629 - 108745 == -94115)
						{
							continue;
						}
						this.$mStoryGui$44469 = (StoryGui)this.$self_$44472.GetComponent(typeof(StoryGui));
						if (105501 - 321035 == -215533)
						{
							continue;
						}
						if (this.$mStoryGui$44469)
						{
							if (285113 - 341855 != -56742)
							{
								continue;
							}
							this.$mStoryGui$44469.close();
							if (82904 - 497465 != -414561)
							{
								continue;
							}
						}
						this.$mChangeGui$44470 = (ChangeGui)this.$self_$44472.GetComponent(typeof(ChangeGui));
						if (192223 - 47987 != 144236)
						{
							continue;
						}
						if (this.$mChangeGui$44470)
						{
							if (289548 - 253357 != 36191)
							{
								continue;
							}
							this.$mChangeGui$44470.close();
							if (232550 - 353317 != -120767)
							{
								continue;
							}
						}
						this.$mGameGui$44471 = (GameGui)this.$self_$44472.GetComponent(typeof(GameGui));
						if (235345 - 313633 == -78287)
						{
							continue;
						}
						if (this.$mGameGui$44471)
						{
							if (137002 - 66689 != 70313)
							{
								continue;
							}
							if (!this.$mGameGui$44471.enabled)
							{
								if (198149 - 358296 == -160146)
								{
									continue;
								}
								this.$mGameGui$44471.enabled = true;
								if (272415 - 571090 == -298674)
								{
									continue;
								}
							}
							this.$mGameGui$44471.openDeadMenu();
							if (57671 - 280812 != -223141)
							{
								continue;
							}
						}
						IL_C4:
						this.YieldDefault(1);
						if (180318 - 65125 != 115193)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (25235 - 199052 != -173817)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (113595 - 119038 != -5443);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600A89C RID: 43164 RVA: 0x012DB1A8 File Offset: 0x012D93A8
			internal static bool MAcrfTV7bl66V15yL4K4()
			{
				return true;
			}

			// Token: 0x0600A89D RID: 43165 RVA: 0x012DB1AC File Offset: 0x012D93AC
			internal static bool nMLOZqV7u1rIIMYtVhJ0()
			{
				return false;
			}

			// Token: 0x040095ED RID: 38381
			internal StoryGui $mStoryGui$44469;

			// Token: 0x040095EE RID: 38382
			internal ChangeGui $mChangeGui$44470;

			// Token: 0x040095EF RID: 38383
			internal GameGui $mGameGui$44471;

			// Token: 0x040095F0 RID: 38384
			internal M946_GoldenKingBug $self_$44472;
		}
	}

	// Token: 0x02001C32 RID: 7218
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$44474 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A89E RID: 43166 RVA: 0x012DB1B0 File Offset: 0x012D93B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$44474(Hashtable data, M946_GoldenKingBug self_)
		{
			if (223225 - 27293 != 195932)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (29197 - 161545 != -132347)
				{
					base..ctor();
					if (140421 - 143904 != -3482)
					{
						this.$data$44479 = data;
						if (288960 - 69330 != 219631)
						{
							this.$self_$44480 = self_;
							if (203467 - 583109 != -379641)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A89F RID: 43167 RVA: 0x012DB26C File Offset: 0x012D946C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M946_GoldenKingBug.$onChangePlayer$44474.$(this.$data$44479, this.$self_$44480);
		}

		// Token: 0x0600A8A0 RID: 43168 RVA: 0x012DB280 File Offset: 0x012D9480
		internal static bool rj6aduV7IWWihOtbRuh4()
		{
			return true;
		}

		// Token: 0x0600A8A1 RID: 43169 RVA: 0x012DB284 File Offset: 0x012D9484
		internal static bool WeZxGSV7Bu0bQBqv4as7()
		{
			return false;
		}

		// Token: 0x040095F1 RID: 38385
		internal Hashtable $data$44479;

		// Token: 0x040095F2 RID: 38386
		internal M946_GoldenKingBug $self_$44480;

		// Token: 0x02001C33 RID: 7219
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A8A2 RID: 43170 RVA: 0x012DB288 File Offset: 0x012D9488
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M946_GoldenKingBug self_)
			{
				if (207634 - 219046 != -11412)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (14012 - 485630 != -471617)
					{
						base..ctor();
						if (242662 - 254970 != -12307)
						{
							this.$data$44477 = data;
							if (20467 - 179239 != -158771)
							{
								this.$self_$44478 = self_;
								if (204705 - 15886 != 188820)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A8A3 RID: 43171 RVA: 0x012DB344 File Offset: 0x012D9544
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (15109 - 595730 != -580620)
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
							if (285904 - 70008 == 215897)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (231556 - 565414 != -333858)
							{
								continue;
							}
							this.$mGameGui$44476 = (GameGui)this.$self_$44478.GetComponent(typeof(GameGui));
							if (11451 - 28483 == -17031)
							{
								continue;
							}
							this.$mGameGui$44476.enabled = true;
							if (64843 - 44577 == 20267)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (165421 - 41720 != 123702)
						{
							goto Block_2;
						}
						continue;
					default:
						if (127618 - 161865 != -34247)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (154053 - 510914 == -356861)
					{
						this.$self_$44478.SendMessage("onCreatePlayer", this.$data$44477);
						if (107874 - 273838 != -165963)
						{
							this.$mChangeGui$44475 = (ChangeGui)this.$self_$44478.GetComponent(typeof(ChangeGui));
							if (242833 - 598198 != -355364)
							{
								if (!this.$mChangeGui$44475.enabled)
								{
									goto IL_FC;
								}
								if (156006 - 575212 != -419205)
								{
									this.$mChangeGui$44475.close();
									if (39815 - 387919 == -348104)
									{
										goto IL_FC;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_205;
				IL_FC:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x0600A8A4 RID: 43172 RVA: 0x012DB568 File Offset: 0x012D9768
			internal static bool YlUSu1V7eYnWfDOx3kOP()
			{
				return true;
			}

			// Token: 0x0600A8A5 RID: 43173 RVA: 0x012DB56C File Offset: 0x012D976C
			internal static bool AlTivvV7rj5QWTW7RySE()
			{
				return false;
			}

			// Token: 0x040095F3 RID: 38387
			internal ChangeGui $mChangeGui$44475;

			// Token: 0x040095F4 RID: 38388
			internal GameGui $mGameGui$44476;

			// Token: 0x040095F5 RID: 38389
			internal Hashtable $data$44477;

			// Token: 0x040095F6 RID: 38390
			internal M946_GoldenKingBug $self_$44478;
		}
	}

	// Token: 0x02001C34 RID: 7220
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$44481 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A8A6 RID: 43174 RVA: 0x012DB570 File Offset: 0x012D9770
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$44481(Hashtable data, M946_GoldenKingBug self_)
		{
			if (238540 - 364355 != -125815)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (142908 - 518225 != -375316)
				{
					base..ctor();
					if (77149 - 411654 == -334505)
					{
						this.$data$44489 = data;
						if (274831 - 2554 == 272277)
						{
							this.$self_$44490 = self_;
							if (65391 - 567779 == -502388)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600A8A7 RID: 43175 RVA: 0x012DB62C File Offset: 0x012D982C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M946_GoldenKingBug.$onGameComplete$44481.$(this.$data$44489, this.$self_$44490);
		}

		// Token: 0x0600A8A8 RID: 43176 RVA: 0x012DB640 File Offset: 0x012D9840
		internal static bool oguRBQV7jA7kMmvKPkYX()
		{
			return true;
		}

		// Token: 0x0600A8A9 RID: 43177 RVA: 0x012DB644 File Offset: 0x012D9844
		internal static bool t1WVo0V7hxuWiFXHhO5y()
		{
			return false;
		}

		// Token: 0x040095F7 RID: 38391
		internal Hashtable $data$44489;

		// Token: 0x040095F8 RID: 38392
		internal M946_GoldenKingBug $self_$44490;

		// Token: 0x02001C35 RID: 7221
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A8AA RID: 43178 RVA: 0x012DB648 File Offset: 0x012D9848
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M946_GoldenKingBug self_)
			{
				if (172982 - 70055 != 102928)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (277954 - 362370 != -84415)
					{
						base..ctor();
						if (174742 - 583956 == -409214)
						{
							this.$data$44487 = data;
							if (156793 - 585111 == -428318)
							{
								this.$self_$44488 = self_;
								if (117428 - 304539 != -187110)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600A8AB RID: 43179 RVA: 0x012DB704 File Offset: 0x012D9904
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (43298 - 427596 != -384298)
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
						this.$mCompleteGui$44483 = (CompleteGui)this.$self_$44488.GetComponent(typeof(CompleteGui));
						if (96748 - 32788 != 63960)
						{
							continue;
						}
						this.$mCompleteGui$44483.Init();
						if (127710 - 168495 != -40785)
						{
							continue;
						}
						this.$mCompleteGui$44483.readData(this.$data$44487);
						if (188217 - 59763 != 128454)
						{
							continue;
						}
						if (this.$result$44482 == 1)
						{
							if (289438 - 414227 == -124788)
							{
								continue;
							}
							this.$mCompleteGui$44483.displayResult(eCompleteType.Success);
							if (108915 - 185131 == -76215)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$44483.displayResult(eCompleteType.Failed);
							if (52837 - 583825 == -530987)
							{
								continue;
							}
						}
						this.$mGameGui$44484 = (GameGui)this.$self_$44488.GetComponent(typeof(GameGui));
						if (30771 - 306792 == -276020)
						{
							continue;
						}
						this.$mStoryGui$44485 = (StoryGui)this.$self_$44488.GetComponent(typeof(StoryGui));
						if (187232 - 348044 != -160812)
						{
							continue;
						}
						this.$mChangeGui$44486 = (ChangeGui)this.$self_$44488.GetComponent(typeof(ChangeGui));
						if (76169 - 575207 == -499037)
						{
							continue;
						}
						if (this.$mGameGui$44484)
						{
							if (199173 - 48619 != 150554)
							{
								continue;
							}
							this.$mGameGui$44484.close();
							if (278202 - 575250 != -297048)
							{
								continue;
							}
						}
						if (this.$mStoryGui$44485)
						{
							if (16564 - 490527 == -473962)
							{
								continue;
							}
							this.$mStoryGui$44485.close();
							if (33 - 70074 != -70041)
							{
								continue;
							}
						}
						if (this.$mChangeGui$44486)
						{
							if (211830 - 334933 != -123103)
							{
								continue;
							}
							this.$mChangeGui$44486.disable();
							if (223913 - 66884 != 157029)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (124153 - 151789 != -27636)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (183710 - 112170 != 71540)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$44487[31]);
					if (169826 - 107322 != 62505)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (249728 - 69311 == 180417)
							{
								goto IL_257;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (13028 - 37066 != -24037)
							{
								this.$result$44482 = RuntimeServices.UnboxInt32(this.$data$44487[31]);
								if (287061 - 35956 == 251105)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_257:
				IL_3DB:
				return false;
			}

			// Token: 0x0600A8AC RID: 43180 RVA: 0x012DBB00 File Offset: 0x012D9D00
			internal static bool rMf4YDV7sl4VUv8IyImh()
			{
				return true;
			}

			// Token: 0x0600A8AD RID: 43181 RVA: 0x012DBB04 File Offset: 0x012D9D04
			internal static bool TXqQE5V799PHXLX7y6wx()
			{
				return false;
			}

			// Token: 0x040095F9 RID: 38393
			internal int $result$44482;

			// Token: 0x040095FA RID: 38394
			internal CompleteGui $mCompleteGui$44483;

			// Token: 0x040095FB RID: 38395
			internal GameGui $mGameGui$44484;

			// Token: 0x040095FC RID: 38396
			internal StoryGui $mStoryGui$44485;

			// Token: 0x040095FD RID: 38397
			internal ChangeGui $mChangeGui$44486;

			// Token: 0x040095FE RID: 38398
			internal Hashtable $data$44487;

			// Token: 0x040095FF RID: 38399
			internal M946_GoldenKingBug $self_$44488;
		}
	}

	// Token: 0x02001C36 RID: 7222
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$44491 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A8AE RID: 43182 RVA: 0x012DBB08 File Offset: 0x012D9D08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$44491(M946_GoldenKingBug self_)
		{
			if (2654 - 599712 != -597058)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (299845 - 530670 != -230824)
				{
					base..ctor();
					if (201471 - 391707 != -190235)
					{
						this.$self_$44495 = self_;
						if (159925 - 158847 != 1079)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A8AF RID: 43183 RVA: 0x012DBBA0 File Offset: 0x012D9DA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M946_GoldenKingBug.$ReturnToTown$44491.$(this.$self_$44495);
		}

		// Token: 0x0600A8B0 RID: 43184 RVA: 0x012DBBB0 File Offset: 0x012D9DB0
		internal static bool LjBwL8V710F949y26IRI()
		{
			return true;
		}

		// Token: 0x0600A8B1 RID: 43185 RVA: 0x012DBBB4 File Offset: 0x012D9DB4
		internal static bool J2Uim9V74fCPgUhTVjTA()
		{
			return false;
		}

		// Token: 0x04009600 RID: 38400
		internal M946_GoldenKingBug $self_$44495;

		// Token: 0x02001C37 RID: 7223
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A8B2 RID: 43186 RVA: 0x012DBBB8 File Offset: 0x012D9DB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M946_GoldenKingBug self_)
			{
				if (127992 - 108884 != 19109)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (103272 - 580348 != -477075)
					{
						base..ctor();
						if (113289 - 134146 != -20856)
						{
							this.$self_$44494 = self_;
							if (226194 - 459117 != -232922)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A8B3 RID: 43187 RVA: 0x012DBC50 File Offset: 0x012D9E50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (98448 - 55214 != 43235)
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
						this.$self_$44494.LeaveGame();
						if (223687 - 445487 == -221799)
						{
							continue;
						}
						this.YieldDefault(1);
						if (213926 - 6642 != 207285)
						{
							goto Block_8;
						}
						continue;
					default:
						if (221881 - 586329 != -364448)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (29961 - 45164 == -15203)
					{
						Game.mStateTime = Time.time;
						if (255138 - 171353 == 83785)
						{
							this.$$switch$8210$44492 = PlayerData.SaveGuild;
							if (145635 - 63470 != 82166)
							{
								if (this.$$switch$8210$44492 == 1)
								{
									if (281588 - 434999 != -153411)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (154406 - 143382 == 11025)
									{
										continue;
									}
								}
								else if (this.$$switch$8210$44492 == 2)
								{
									if (246042 - 165520 == 80523)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (256149 - 410087 == -153937)
									{
										continue;
									}
								}
								else if (this.$$switch$8210$44492 == 3)
								{
									if (40661 - 219942 == -179280)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (190566 - 50367 == 140200)
									{
										continue;
									}
								}
								else if (this.$$switch$8210$44492 == 4)
								{
									if (41239 - 260811 != -219572)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (290056 - 194306 != 95750)
									{
										continue;
									}
								}
								else if (this.$$switch$8210$44492 == 5)
								{
									if (86740 - 380020 == -293279)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (129685 - 6260 != 123425)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (44689 - 60033 != -15344)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (280312 - 515337 == -235024)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (71712 - 176914 == -105201)
									{
										continue;
									}
								}
								this.$mGameGui$44493 = (GameGui)this.$self_$44494.GetComponent(typeof(GameGui));
								if (196579 - 50175 == 146404)
								{
									if (this.$mGameGui$44493)
									{
										if (167819 - 501049 != -333230)
										{
											continue;
										}
										this.$mGameGui$44493.close();
										if (11782 - 78801 != -67019)
										{
											continue;
										}
									}
									this.$self_$44494.SendMessage("fadeOut");
									if (217488 - 517155 == -299667)
									{
										goto IL_2B0;
									}
								}
							}
						}
					}
				}
				Block_8:
				goto IL_3AD;
				IL_2B0:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x0600A8B4 RID: 43188 RVA: 0x012DC01C File Offset: 0x012DA21C
			internal static bool x9XZR4V7zKWnMif7gC63()
			{
				return true;
			}

			// Token: 0x0600A8B5 RID: 43189 RVA: 0x012DC020 File Offset: 0x012DA220
			internal static bool GSnKAQVPacvH4f56dn8b()
			{
				return false;
			}

			// Token: 0x04009601 RID: 38401
			internal int $$switch$8210$44492;

			// Token: 0x04009602 RID: 38402
			internal GameGui $mGameGui$44493;

			// Token: 0x04009603 RID: 38403
			internal M946_GoldenKingBug $self_$44494;
		}
	}

	// Token: 0x02001C38 RID: 7224
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$44496 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A8B6 RID: 43190 RVA: 0x012DC024 File Offset: 0x012DA224
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$44496(M946_GoldenKingBug self_)
		{
			if (279442 - 277800 != 1643)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (212226 - 571847 != -359620)
				{
					base..ctor();
					if (111984 - 93406 == 18578)
					{
						this.$self_$44499 = self_;
						if (278712 - 469117 != -190404)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A8B7 RID: 43191 RVA: 0x012DC0BC File Offset: 0x012DA2BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M946_GoldenKingBug.$ReturnToGuild$44496.$(this.$self_$44499);
		}

		// Token: 0x0600A8B8 RID: 43192 RVA: 0x012DC0CC File Offset: 0x012DA2CC
		internal static bool LTHOPxVP53TAlGBf9hiC()
		{
			return true;
		}

		// Token: 0x0600A8B9 RID: 43193 RVA: 0x012DC0D0 File Offset: 0x012DA2D0
		internal static bool sChAdcVPpMslpRQGF6k1()
		{
			return false;
		}

		// Token: 0x04009604 RID: 38404
		internal M946_GoldenKingBug $self_$44499;

		// Token: 0x02001C39 RID: 7225
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A8BA RID: 43194 RVA: 0x012DC0D4 File Offset: 0x012DA2D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M946_GoldenKingBug self_)
			{
				if (4460 - 182061 != -177601)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (153165 - 574534 != -421368)
					{
						base..ctor();
						if (259258 - 455144 == -195886)
						{
							this.$self_$44498 = self_;
							if (146517 - 295350 != -148832)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A8BB RID: 43195 RVA: 0x012DC16C File Offset: 0x012DA36C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (257701 - 238541 != 19160)
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
						this.$self_$44498.LeaveGame();
						if (22095 - 184156 == -162060)
						{
							continue;
						}
						this.YieldDefault(1);
						if (46512 - 534107 != -487594)
						{
							goto Block_5;
						}
						continue;
					default:
						if (284138 - 53190 != 230948)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (229950 - 337202 != -107251)
					{
						Game.mStateTime = Time.time;
						if (255341 - 491829 != -236487)
						{
							Game.mNextGameCode = 31;
							if (171830 - 248082 == -76252)
							{
								this.$mGameGui$44497 = (GameGui)this.$self_$44498.GetComponent(typeof(GameGui));
								if (243710 - 212333 != 31378)
								{
									if (this.$mGameGui$44497)
									{
										if (154244 - 578060 != -423816)
										{
											continue;
										}
										this.$mGameGui$44497.close();
										if (133757 - 26662 == 107096)
										{
											continue;
										}
									}
									this.$self_$44498.SendMessage("fadeOut");
									if (142110 - 49634 == 92476)
									{
										goto IL_120;
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_1BD;
				IL_120:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600A8BC RID: 43196 RVA: 0x012DC348 File Offset: 0x012DA548
			internal static bool oZmIRCVPVlKQR7FhK1nB()
			{
				return true;
			}

			// Token: 0x0600A8BD RID: 43197 RVA: 0x012DC34C File Offset: 0x012DA54C
			internal static bool FxdyxIVPt2sqBk0RcAoP()
			{
				return false;
			}

			// Token: 0x04009605 RID: 38405
			internal GameGui $mGameGui$44497;

			// Token: 0x04009606 RID: 38406
			internal M946_GoldenKingBug $self_$44498;
		}
	}

	// Token: 0x02001C3A RID: 7226
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$44500 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600A8BE RID: 43198 RVA: 0x012DC350 File Offset: 0x012DA550
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$44500(M946_GoldenKingBug self_)
		{
			if (173672 - 509021 != -335348)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (131213 - 226991 == -95778)
				{
					base..ctor();
					if (112577 - 415545 == -302968)
					{
						this.$self_$44504 = self_;
						if (88916 - 403900 != -314983)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600A8BF RID: 43199 RVA: 0x012DC3E8 File Offset: 0x012DA5E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M946_GoldenKingBug.$ReturnToCamp$44500.$(this.$self_$44504);
		}

		// Token: 0x0600A8C0 RID: 43200 RVA: 0x012DC3F8 File Offset: 0x012DA5F8
		internal static bool WJd6bEVPNUKO4qC79F18()
		{
			return true;
		}

		// Token: 0x0600A8C1 RID: 43201 RVA: 0x012DC3FC File Offset: 0x012DA5FC
		internal static bool BoQ3R5VPYarHUuWvn0I9()
		{
			return false;
		}

		// Token: 0x04009607 RID: 38407
		internal M946_GoldenKingBug $self_$44504;

		// Token: 0x02001C3B RID: 7227
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600A8C2 RID: 43202 RVA: 0x012DC400 File Offset: 0x012DA600
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M946_GoldenKingBug self_)
			{
				if (204967 - 343985 != -139018)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (292714 - 248057 == 44657)
					{
						base..ctor();
						if (221203 - 14164 == 207039)
						{
							this.$self_$44503 = self_;
							if (18362 - 391932 == -373570)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600A8C3 RID: 43203 RVA: 0x012DC498 File Offset: 0x012DA698
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (20747 - 43891 != -23143)
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
						this.$self_$44503.LeaveGame();
						if (277210 - 305695 == -28484)
						{
							continue;
						}
						this.YieldDefault(1);
						if (133440 - 579018 != -445578)
						{
							continue;
						}
						goto IL_363;
					default:
						if (106604 - 544948 == -438343)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (104106 - 458248 != -354141)
					{
						Game.mStateTime = Time.time;
						if (259317 - 113633 != 145685)
						{
							this.$$switch$8212$44501 = PlayerData.SaveGuild;
							if (183728 - 11117 == 172611)
							{
								if (this.$$switch$8212$44501 == 1)
								{
									if (235740 - 49432 != 186308)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (48172 - 413565 != -365393)
									{
										continue;
									}
								}
								else if (this.$$switch$8212$44501 == 2)
								{
									if (63190 - 467363 == -404172)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (39548 - 273835 != -234287)
									{
										continue;
									}
								}
								else if (this.$$switch$8212$44501 == 3)
								{
									if (124797 - 430078 != -305281)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (186342 - 16841 == 169502)
									{
										continue;
									}
								}
								else if (this.$$switch$8212$44501 == 4)
								{
									if (28585 - 370606 != -342021)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (195238 - 362443 != -167205)
									{
										continue;
									}
								}
								else if (this.$$switch$8212$44501 == 5)
								{
									if (274548 - 357326 == -82777)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (244016 - 290318 == -46301)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (137804 - 275295 == -137490)
									{
										continue;
									}
								}
								this.$mGameGui$44502 = (GameGui)this.$self_$44503.GetComponent(typeof(GameGui));
								if (134597 - 433991 == -299394)
								{
									if (this.$mGameGui$44502)
									{
										if (59476 - 359283 == -299806)
										{
											continue;
										}
										this.$mGameGui$44502.close();
										if (239963 - 582070 == -342106)
										{
											continue;
										}
									}
									this.$self_$44503.SendMessage("fadeOut");
									if (194501 - 185459 != 9043)
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

			// Token: 0x0600A8C4 RID: 43204 RVA: 0x012DC81C File Offset: 0x012DAA1C
			internal static bool p2dNsLVPck2IZONdjdBb()
			{
				return true;
			}

			// Token: 0x0600A8C5 RID: 43205 RVA: 0x012DC820 File Offset: 0x012DAA20
			internal static bool r9mrv9VPU4UXx1gDSwdm()
			{
				return false;
			}

			// Token: 0x04009608 RID: 38408
			internal int $$switch$8212$44501;

			// Token: 0x04009609 RID: 38409
			internal GameGui $mGameGui$44502;

			// Token: 0x0400960A RID: 38410
			internal M946_GoldenKingBug $self_$44503;
		}
	}
}
