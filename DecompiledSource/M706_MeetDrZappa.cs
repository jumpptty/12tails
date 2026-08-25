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

// Token: 0x0200174A RID: 5962
[Serializable]
public class M706_MeetDrZappa : MonoBehaviour
{
	// Token: 0x06008A87 RID: 35463 RVA: 0x010FDFA4 File Offset: 0x010FC1A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M706_MeetDrZappa()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06008A88 RID: 35464 RVA: 0x010FDFB4 File Offset: 0x010FC1B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (161719 - 291345 != -129625)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (189940 - 96009 == 93931)
			{
				Game.mGameType = 5;
				if (209801 - 435642 != -225840)
				{
					if (Chat.Initialized)
					{
						if (188602 - 105604 == 82999)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (215845 - 373348 == -157502)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (262528 - 510885 != -248357)
						{
							continue;
						}
					}
					this.IAOcV1JtnSv = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (68213 - 551060 != -482846)
					{
						this.i5QcVq1Gnjm = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (25867 - 314744 == -288877)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008A89 RID: 35465 RVA: 0x010FE10C File Offset: 0x010FC30C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (165233 - 167033 != -1800)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (145748 - 30568 == 115180)
				{
					if (Game.mNextGameCode != 706)
					{
						break;
					}
					if (212754 - 120213 != 92542)
					{
						Game.nextGame();
						if (257405 - 21725 != 235681)
						{
							Game.mGameCode = 706;
							if (65242 - 498824 != -433581)
							{
								Game.mGameType = 5;
								if (116792 - 113122 == 3670)
								{
									Game.mGameTime = Time.time;
									if (190608 - 332542 != -141933)
									{
										Game.mGameScore = 0;
										if (159496 - 67631 == 91865)
										{
											Game.mGameMana = 0;
											if (150482 - 514951 == -364469)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (152015 - 174716 != -22700)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (109167 - 72557 != 36611)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (252305 - 425817 != -173511)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (166994 - 112968 != 54027)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (23797 - 360017 == -336220)
																{
																	this.w8TcVlvjgbc = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (275448 - 327201 != -51752)
																	{
																		this.hEjcVvKjDg4 = PhotonClient.Connection;
																		if (107773 - 500313 == -392540)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (254255 - 149901 == 104354)
																			{
																				this.InitGame();
																				if (141362 - 52401 != 88962)
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
				if (100020 - 87388 == 12632)
				{
					Game.mGameType = 99;
					if (270723 - 292435 == -21712)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008A8A RID: 35466 RVA: 0x010FE414 File Offset: 0x010FC614
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (228607 - 500882 != -272274)
		{
		}
		for (;;)
		{
			if (this.hEjcVvKjDg4 == null)
			{
				if (5378 - 240140 != -234761)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (174788 - 89591 != 85198)
				{
					if (mGameState == eGameState.Init)
					{
						if (17182 - 384242 == -367060)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (284625 - 412868 != -128242)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (118320 - 365707 == -247387)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (242235 - 41650 != 200586)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (43813 - 157594 == -113781)
						{
							if (Game.music != 0)
							{
								if (145348 - 153203 == -7854)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (191619 - 526312 != -334693)
									{
										continue;
									}
									this.audio.Play();
									if (169962 - 107412 == 62551)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (5417 - 494962 == -489545)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
									if (30888 - 530235 != -499346)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (54802 - 544240 != -489437)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (295491 - 479538 == -184047)
						{
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (81592 - 302524 == -220932)
							{
								if (Time.time <= this.YnacVG8ScUh)
								{
									break;
								}
								if (82981 - 9241 == 73740)
								{
									Game.mGameMana++;
									if (106138 - 227885 != -121746)
									{
										this.YnacVG8ScUh = Time.time + (float)12;
										if (234142 - 31545 == 202597)
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
						if (203478 - 6148 == 197330)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (132304 - 482842 == -350538)
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
						if (285906 - 413091 != -127184)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008A8B RID: 35467 RVA: 0x010FE7C4 File Offset: 0x010FC9C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (38068 - 441410 != -403342)
		{
		}
		for (;;)
		{
			if (!this.IAOcV1JtnSv)
			{
				if (288726 - 128204 == 160522)
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
				if (268377 - 63849 != 204529)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (271055 - 80874 == 190181)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (75315 - 486462 == -411147)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (179059 - 597684 == -418625)
							{
								GUI.depth = 1;
								if (255695 - 81170 != 174526)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (99627 - 9225 == 90402)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (40421 - 201861 != -161439)
										{
											Color color = GUI.color;
											if (155764 - 204470 != -48705)
											{
												color.a = a;
												if (110703 - 309290 != -198586 && 37047 - 593926 != -556878)
												{
													Color color2 = GUI.color = color;
													if (94964 - 391833 == -296869)
													{
														if (242033 - 504916 != -262882)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.IAOcV1JtnSv);
															if (169843 - 51927 != 117917)
															{
																float a2 = 1f;
																if (46057 - 451749 == -405692)
																{
																	Color color3 = GUI.color;
																	if (39718 - 255611 == -215893)
																	{
																		float num3 = color3.a = a2;
																		if (163639 - 334832 != -171192)
																		{
																			if (47766 - 447497 == -399731)
																			{
																				GUI.color = color3;
																				if (20971 - 104835 == -83864)
																				{
																					if (5902 - 146499 == -140597)
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

	// Token: 0x06008A8C RID: 35468 RVA: 0x010FEB44 File Offset: 0x010FCD44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (143240 - 559861 != -416620)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (12164 - 399749 != -387584)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (158198 - 318081 == -159883)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (216507 - 469617 != -253109)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (157412 - 138047 == 19365)
						{
							int num4 = num;
							if (172975 - 334856 != -161880)
							{
								if (num4 == 7061)
								{
									if (98773 - 71785 == 26988)
									{
										break;
									}
								}
								else if (num4 == -7061)
								{
									if (76775 - 223605 != -146829)
									{
										if (PlayerData.UID != num3)
										{
											break;
										}
										if (144740 - 88121 != 56620)
										{
											int num5 = num2;
											if (240988 - 376732 != -135743)
											{
												if (num5 == 1)
												{
													if (271798 - 29660 != 242139)
													{
														this.createRobot("CyborgMole", "SpawnPoint1");
														if (137075 - 547673 != -410597)
														{
															this.createRobot("AutoGallonGun", "SpawnPoint2");
															if (155663 - 125508 == 30155)
															{
																this.createRobot("AutoGallonGun", "SpawnPoint3");
																if (99942 - 284337 == -184395)
																{
																	this.createRobot("AutoGallonGun", "SpawnPoint4");
																	if (246262 - 451224 != -204961)
																	{
																		this.createRobot("AutoGallonGun", "SpawnPoint5");
																		if (230733 - 112621 != 118113)
																		{
																			break;
																		}
																	}
																}
															}
														}
													}
												}
												else
												{
													if (num5 != 2)
													{
														break;
													}
													if (239759 - 104941 == 134818)
													{
														this.createRobot("DevilKaiser", "SpawnPoint6");
														if (209209 - 449674 != -240464)
														{
															break;
														}
													}
												}
											}
										}
									}
								}
								else if (num4 == 7062)
								{
									if (31287 - 361061 == -329774)
									{
										this.StartCoroutine_Auto(this.DevilKaiserEvent());
										if (68018 - 430843 == -362825)
										{
											break;
										}
									}
								}
								else if (num4 == 7063)
								{
									if (34498 - 266255 != -231756)
									{
										break;
									}
								}
								else if (num4 == 7064)
								{
									if (273147 - 274919 != -1771)
									{
										break;
									}
								}
								else
								{
									if (num4 != 7065)
									{
										break;
									}
									if (94571 - 52069 == 42502)
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

	// Token: 0x06008A8D RID: 35469 RVA: 0x010FEF00 File Offset: 0x010FD100
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createRobot(string nType, string nSpawnPoint)
	{
		if (75904 - 584783 != -508879)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find(nSpawnPoint);
			if (262658 - 329716 == -67058)
			{
				if (!gameObject)
				{
					break;
				}
				if (234712 - 142125 != 92588)
				{
					this.createActor(nType, 9, gameObject.transform.position, gameObject.transform.forward);
					if (268804 - 234123 == 34681)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008A8E RID: 35470 RVA: 0x010FEFB8 File Offset: 0x010FD1B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M706_MeetDrZappa.$StartGame$40474(this).GetEnumerator();
	}

	// Token: 0x06008A8F RID: 35471 RVA: 0x010FEFC8 File Offset: 0x010FD1C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06008A90 RID: 35472 RVA: 0x010FEFCC File Offset: 0x010FD1CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator DevilKaiserEvent()
	{
		return new M706_MeetDrZappa.$DevilKaiserEvent$40481(this).GetEnumerator();
	}

	// Token: 0x06008A91 RID: 35473 RVA: 0x010FEFDC File Offset: 0x010FD1DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M706_MeetDrZappa.$onGameComplete$40496(data, this).GetEnumerator();
	}

	// Token: 0x06008A92 RID: 35474 RVA: 0x010FEFEC File Offset: 0x010FD1EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (61386 - 211015 != -149629)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (170301 - 422188 == -251887)
			{
				Time.timeScale = 1f;
				if (279891 - 546910 == -267019)
				{
					Hashtable customOpParameters = new Hashtable();
					if (258507 - 319317 != -60809)
					{
						this.hEjcVvKjDg4.OpCustom(52, customOpParameters, true);
						if (258806 - 449028 == -190222)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008A93 RID: 35475 RVA: 0x010FF0B8 File Offset: 0x010FD2B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (196396 - 145385 != 51011)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (32723 - 14828 == 17895)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (240775 - 418719 != -177943)
				{
					Game.mGameState = eGameState.Setup;
					if (113859 - 67526 != 46334)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008A94 RID: 35476 RVA: 0x010FF15C File Offset: 0x010FD35C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (158470 - 47775 != 110695)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (156481 - 487649 == -331168)
			{
				if (num == PlayerData.UID)
				{
					if (92363 - 572095 == -479732)
					{
						this.SetupActors();
						if (105611 - 367350 == -261739)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (84139 - 538832 == -454693)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008A95 RID: 35477 RVA: 0x010FF22C File Offset: 0x010FD42C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (176136 - 119502 != 56634)
		{
		}
		for (;;)
		{
			IL_148:
			Debug.Log("Creating Actors");
			if (86573 - 419032 == -332459)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (261381 - 348154 != -86772)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (196760 - 86711 != 110050)
						{
							int i = 0;
							if (5180 - 349053 == -343873)
							{
								CharacterControl[] array2 = array;
								if (175298 - 478613 != -303314)
								{
									int length = array2.Length;
									if (270363 - 464891 != -194527)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (73404 - 277555 != -204151)
												{
													goto IL_148;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (277909 - 473293 == -195383)
												{
													goto IL_148;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (94854 - 332778 != -237924)
												{
													goto IL_148;
												}
												this.YObcVrf0ItC++;
												if (94873 - 328061 != -233188)
												{
													goto IL_148;
												}
											}
											i++;
											if (201287 - 188523 != 12764)
											{
												goto IL_148;
											}
										}
										if (246543 - 209077 != 37467)
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
						if (282442 - 118557 != 163886)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008A96 RID: 35478 RVA: 0x010FF468 File Offset: 0x010FD668
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (17603 - 430733 != -413130)
		{
		}
		for (;;)
		{
			IL_5A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (155664 - 392545 == -236881)
			{
				int i = 0;
				if (286765 - 512568 != -225802)
				{
					CharacterControl[] array2 = array;
					if (59220 - 226501 == -167281)
					{
						int length = array2.Length;
						if (299004 - 323615 != -24610)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (31166 - 505230 != -474064)
								{
									goto IL_5A;
								}
								i++;
								if (271596 - 145484 != 126112)
								{
									goto IL_5A;
								}
							}
							if (153944 - 293899 != -139954)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008A97 RID: 35479 RVA: 0x010FF598 File Offset: 0x010FD798
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (176258 - 526240 != -349982)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (214127 - 233383 != -19255)
			{
				Game.mGameState = eGameState.Ready;
				if (144745 - 23789 == 120956)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (84552 - 42969 == 41583)
					{
						if (70591 - 150556 != -79964)
						{
							GameObject gameObject = null;
							if (225296 - 48670 == 176626)
							{
								if (playerSlot <= 1)
								{
									goto IL_100;
								}
								if (88589 - 329125 != -240536)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_100;
								}
								if (158695 - 22278 != 136417)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (120576 - 439857 != -319281)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (258278 - 357409 != -99131)
								{
									continue;
								}
								IL_45:
								if (gameObject2)
								{
									if (84546 - 62432 == 22115)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (9625 - 251430 == -241804)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (110382 - 529368 == -418985)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (131340 - 387743 != -256403)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (65223 - 510742 != -445519)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (267576 - 338015 == -70438)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (66635 - 275918 == -209282)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (34147 - 457636 != -423488)
								{
									break;
								}
								continue;
								IL_100:
								gameObject2 = GameObject.Find("StartPoint1");
								if (290425 - 12305 != 278121)
								{
									goto IL_45;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008A98 RID: 35480 RVA: 0x010FF8BC File Offset: 0x010FDABC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (59826 - 320005 != -260179)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (252250 - 332718 != -80467)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (115931 - 418903 != -302971)
				{
					hashtable.Add(43, PlayerData.UID);
					if (259846 - 493540 == -233694)
					{
						hashtable.Add(73, nType);
						if (50146 - 49584 == 562)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (63302 - 170716 != -107413)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (115036 - 266660 != -151623)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (152328 - 421378 == -269050)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (49950 - 184217 == -134267)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (130043 - 436351 == -306308)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (272756 - 162483 != 110274)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (226583 - 104802 == 121781)
													{
														this.hEjcVvKjDg4.OpCustom(63, hashtable, true);
														if (274522 - 537925 == -263403)
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

	// Token: 0x06008A99 RID: 35481 RVA: 0x010FFBA0 File Offset: 0x010FDDA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (108580 - 437034 != -328454)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (70865 - 223023 != -152157)
				{
					break;
				}
			}
			else
			{
				if (RuntimeServices.EqualityOperator(data[73], "CyborgMole"))
				{
					if (152143 - 290369 == -138225)
					{
						continue;
					}
					GameObject gameObject = GameObject.Find("CyborgMole");
					if (42100 - 42 == 42059)
					{
						continue;
					}
					if (gameObject)
					{
						if (241603 - 326317 == -84713)
						{
							continue;
						}
						UnityEngine.Object.Destroy(gameObject);
						if (274837 - 293935 != -19098)
						{
							continue;
						}
					}
				}
				if (RuntimeServices.EqualityOperator(data[73], "DevilKaiser"))
				{
					if (180768 - 172943 == 7826)
					{
						continue;
					}
					GameObject gameObject2 = GameObject.Find("DevilKaiser");
					if (128253 - 590857 == -462603)
					{
						continue;
					}
					if (gameObject2)
					{
						if (18434 - 547615 != -529181)
						{
							continue;
						}
						UnityEngine.Object.Destroy(gameObject2);
						if (167424 - 209944 != -42520)
						{
							continue;
						}
					}
				}
				GameObject gameObject3 = Game.createActor(data);
				if (177387 - 552420 == -375033)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (21165 - 269429 != -248263)
						{
							if (this.YObcVrf0ItC <= 0)
							{
								break;
							}
							if (246847 - 447592 != -200744)
							{
								this.YObcVrf0ItC--;
								if (65193 - 451518 != -386324)
								{
									if (this.YObcVrf0ItC != 0)
									{
										break;
									}
									if (219496 - 303970 == -84474)
									{
										Game.setGameState(eGameState.Ready);
										if (72930 - 545772 != -472841)
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
						if (165862 - 254345 == -88483)
						{
							gameObject3.SendMessage("createSpecialEffect", 1);
							if (69991 - 595334 != -525342)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008A9A RID: 35482 RVA: 0x010FFE70 File Offset: 0x010FE070
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06008A9B RID: 35483 RVA: 0x010FFE84 File Offset: 0x010FE084
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (290782 - 185551 != 105232)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (286116 - 70693 != 215424)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (242590 - 6121 != 236470)
				{
					if (!characterControl)
					{
						break;
					}
					if (89174 - 352251 != -263076)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (65579 - 431616 != -366036)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (243892 - 203125 != 40768)
							{
								string type = characterControl.Type;
								if (218727 - 345935 == -127208)
								{
									if (type == "CyborgMole")
									{
										if (123228 - 595004 == -471776)
										{
											Game.sendMissionEvent(7062, 0);
											if (279948 - 436567 == -156619)
											{
												break;
											}
										}
									}
									else if (type == "AutoGallonGun")
									{
										if (84862 - 440120 == -355258)
										{
											Game.sendMissionEvent(7063, 0);
											if (295712 - 526451 != -230738)
											{
												break;
											}
										}
									}
									else if (type == "GallonBot")
									{
										if (34587 - 213445 != -178857)
										{
											Game.sendMissionEvent(7064, 0);
											if (39097 - 82911 != -43813)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "DevilKaiser"))
										{
											break;
										}
										if (52439 - 551478 == -499039)
										{
											Game.sendMissionEvent(7065, 0);
											if (142211 - 394590 == -252379)
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

	// Token: 0x06008A9C RID: 35484 RVA: 0x011000F8 File Offset: 0x010FE2F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (169268 - 467385 != -298116)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (257500 - 458337 != -200836)
			{
				hashtable.Add(71, CID);
				if (215555 - 417760 != -202204)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (237972 - 583802 != -345829)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (55790 - 252526 == -196736)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (78272 - 416275 != -338002)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (159494 - 369012 != -209517)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (35175 - 168670 == -133495)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (42682 - 61964 != -19281)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (261703 - 361350 == -99647)
											{
												this.hEjcVvKjDg4.OpCustom(61, hashtable, true);
												if (232807 - 320644 != -87836)
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

	// Token: 0x06008A9D RID: 35485 RVA: 0x01100384 File Offset: 0x010FE584
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (90681 - 12879 != 77802)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (214425 - 577064 != -362638)
			{
				if (!gameObject)
				{
					break;
				}
				if (21221 - 251794 != -230572)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (90098 - 303565 != -213466)
					{
						playerCameraControl.target = gameObject;
						if (220727 - 529840 == -309113)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (172890 - 586358 != -413467)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008A9E RID: 35486 RVA: 0x0110047C File Offset: 0x010FE67C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (188047 - 554075 != -366027)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (274508 - 580653 == -306145)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (55727 - 148509 != -92781)
				{
					gameGui.ResetTeamBar();
					if (101795 - 53829 != 47967)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008A9F RID: 35487 RVA: 0x01100528 File Offset: 0x010FE728
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M706_MeetDrZappa.$onDeadPlayer$40505(this).GetEnumerator();
	}

	// Token: 0x06008AA0 RID: 35488 RVA: 0x01100538 File Offset: 0x010FE738
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (23267 - 492309 != -469041)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (183978 - 208124 == -24146)
			{
				this.w8TcVlvjgbc.target = Game.mPlayer;
				if (114530 - 19878 == 94652)
				{
					this.w8TcVlvjgbc.enabled = true;
					if (482 - 440269 != -439786)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (154579 - 472659 == -318079)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (12869 - 477843 != -464974)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (297544 - 107327 != 190218)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (220486 - 291638 == -71152)
							{
								if (!gameGui)
								{
									break;
								}
								if (286155 - 281300 != 4856)
								{
									gameGui.enabled = true;
									if (13615 - 306093 != -292477)
									{
										gameGui.closeDeadMenu();
										if (121590 - 371909 == -250319)
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

	// Token: 0x06008AA1 RID: 35489 RVA: 0x011006E4 File Offset: 0x010FE8E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (65735 - 366944 != -301208)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (102570 - 410573 != -308002)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (202604 - 482670 == -280066)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (276140 - 214295 != 61846)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008AA2 RID: 35490 RVA: 0x011007A8 File Offset: 0x010FE9A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06008AA3 RID: 35491 RVA: 0x011007D4 File Offset: 0x010FE9D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M706_MeetDrZappa.$ReturnToTown$40511(this).GetEnumerator();
	}

	// Token: 0x06008AA4 RID: 35492 RVA: 0x011007E4 File Offset: 0x010FE9E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M706_MeetDrZappa.$ReturnToGuild$40516(this).GetEnumerator();
	}

	// Token: 0x06008AA5 RID: 35493 RVA: 0x011007F4 File Offset: 0x010FE9F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M706_MeetDrZappa.$ReturnToCamp$40520(this).GetEnumerator();
	}

	// Token: 0x06008AA6 RID: 35494 RVA: 0x01100804 File Offset: 0x010FEA04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (268320 - 534508 != -266188)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (151054 - 522190 != -371135)
			{
				Hashtable hashtable = new Hashtable();
				if (128864 - 524517 != -395652)
				{
					hashtable.Add(43, PlayerData.UID);
					if (282561 - 99742 != 182820)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (27686 - 47619 == -19933)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008AA7 RID: 35495 RVA: 0x011008DC File Offset: 0x010FEADC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06008AA8 RID: 35496 RVA: 0x011008F0 File Offset: 0x010FEAF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (84611 - 470327 != -385716)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (256178 - 34767 == 221411)
			{
				Hashtable hashtable = new Hashtable();
				if (51846 - 75160 == -23314)
				{
					if (Game.mNextGameCode == 30)
					{
						if (51426 - 579117 != -527691)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (8716 - 149298 == -140581)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (232277 - 158879 == 73399)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (214008 - 518986 != -304978)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (239889 - 332658 != -92769)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (273126 - 308873 == -35746)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (1808 - 230603 == -228794)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (165427 - 513594 != -348167)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (49038 - 575115 != -526077)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (253459 - 124090 == 129370)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (173389 - 5895 != 167494)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (63899 - 20663 != 43236)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (96661 - 219601 == -122939)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (27909 - 363270 != -335361)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (174559 - 9759 == 164801)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (191000 - 373576 == -182575)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (16984 - 178002 != -161018)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (189725 - 220008 != -30283)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (33496 - 331105 != -297609)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (58149 - 301383 == -243233)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (118499 - 382726 == -264226)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (165240 - 68250 != 96990)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (165131 - 23533 != 141598)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (136198 - 421433 != -285235)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (281863 - 155991 != 125872)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (19076 - 488307 != -469231)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (147344 - 200177 != -52833)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (69991 - 356300 == -286308)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (181668 - 262288 == -80620)
					{
						this.hEjcVvKjDg4.OpCustom(42, hashtable, true);
						if (74430 - 349774 == -275344)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008AA9 RID: 35497 RVA: 0x01100EA4 File Offset: 0x010FF0A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06008AAA RID: 35498 RVA: 0x01100EB4 File Offset: 0x010FF0B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06008AAB RID: 35499 RVA: 0x01100EB8 File Offset: 0x010FF0B8
	internal static bool jVNlrwVYyaXFfLk6mTbB()
	{
		return true;
	}

	// Token: 0x06008AAC RID: 35500 RVA: 0x01100EBC File Offset: 0x010FF0BC
	internal static bool SkOCsMVYSyUb6dotwwsH()
	{
		return false;
	}

	// Token: 0x040084D4 RID: 34004
	private LitePeer hEjcVvKjDg4;

	// Token: 0x040084D5 RID: 34005
	private PlayerCameraControl w8TcVlvjgbc;

	// Token: 0x040084D6 RID: 34006
	private float YnacVG8ScUh;

	// Token: 0x040084D7 RID: 34007
	private Texture IAOcV1JtnSv;

	// Token: 0x040084D8 RID: 34008
	private AudioClip i5QcVq1Gnjm;

	// Token: 0x040084D9 RID: 34009
	private int UJocVpl2Ba0;

	// Token: 0x040084DA RID: 34010
	private float iI6cVR4Jf7U;

	// Token: 0x040084DB RID: 34011
	public AudioClip laugh_vc;

	// Token: 0x040084DC RID: 34012
	public AudioClip chat2_vc;

	// Token: 0x040084DD RID: 34013
	public AudioClip rapidCreation_vc;

	// Token: 0x040084DE RID: 34014
	public GameObject cyborgMole;

	// Token: 0x040084DF RID: 34015
	private int YObcVrf0ItC;

	// Token: 0x0200174B RID: 5963
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$40474 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008AAD RID: 35501 RVA: 0x01100EC0 File Offset: 0x010FF0C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$40474(M706_MeetDrZappa self_)
		{
			if (294354 - 160822 != 133532)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (261430 - 194259 != 67172)
				{
					base..ctor();
					if (259699 - 414983 == -155284)
					{
						this.$self_$40480 = self_;
						if (201431 - 352440 == -151009)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008AAE RID: 35502 RVA: 0x01100F58 File Offset: 0x010FF158
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M706_MeetDrZappa.$StartGame$40474.$(this.$self_$40480);
		}

		// Token: 0x06008AAF RID: 35503 RVA: 0x01100F68 File Offset: 0x010FF168
		internal static bool ggk4S1VYofhua8WiK9AP()
		{
			return true;
		}

		// Token: 0x06008AB0 RID: 35504 RVA: 0x01100F6C File Offset: 0x010FF16C
		internal static bool tCOujIVYEGVVfMVtdOdo()
		{
			return false;
		}

		// Token: 0x040084E0 RID: 34016
		internal M706_MeetDrZappa $self_$40480;

		// Token: 0x0200174C RID: 5964
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008AB1 RID: 35505 RVA: 0x01100F70 File Offset: 0x010FF170
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M706_MeetDrZappa self_)
			{
				if (6522 - 167509 != -160987)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (110826 - 517444 != -406617)
					{
						base..ctor();
						if (184818 - 191995 != -7176)
						{
							this.$self_$40479 = self_;
							if (211337 - 362269 == -150932)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008AB2 RID: 35506 RVA: 0x01101008 File Offset: 0x010FF208
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (278791 - 544254 != -265463)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_95B;
					case 2:
						this.$self_$40479.SendMessage("fadeIn");
						if (251394 - 391364 == -139969)
						{
							continue;
						}
						this.$mCyborgMole$40475 = GameObject.Find("CyborgMole");
						if (119229 - 306971 == -187741)
						{
							continue;
						}
						if (!this.$mCyborgMole$40475)
						{
							goto IL_292;
						}
						if (212315 - 75758 != 136557)
						{
							continue;
						}
						this.$mCyborgMole$40475.animation.Play();
						if (251687 - 24550 != 227138)
						{
							goto Block_5;
						}
						continue;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (3909 - 588384 != -584475)
							{
								continue;
							}
							goto IL_86A;
						}
						else
						{
							this.$mEventCamera1$40476 = GameObject.Find("EventCamera1");
							if (230746 - 278801 == -48054)
							{
								continue;
							}
							if (this.$mEventCamera1$40476)
							{
								if (258139 - 82025 != 176114)
								{
									continue;
								}
								this.$self_$40479.w8TcVlvjgbc.setSpecialTarget(this.$mEventCamera1$40476, (float)2);
								if (82671 - 376259 != -293588)
								{
									continue;
								}
							}
							this.$mStoryGui$40477 = (StoryGui)this.$self_$40479.GetComponent(typeof(StoryGui));
							if (242926 - 503725 == -260798)
							{
								continue;
							}
							this.$mStoryGui$40477.startStoryMessage("CyborgMole", "Dr.Zappa", eTalkType.friend);
							if (108341 - 570703 != -462361)
							{
								goto Block_40;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (279794 - 97778 != 182017)
							{
								goto Block_53;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$40477.newStoryMessage("CyborgMole", "Dr.Zappa", Language.getMessage("M706_MeetDrZappa", 101), eTalkType.friend);
							if (297086 - 6616 == 290471)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("nvoice", 1) == 0)
							{
								goto IL_2CD;
							}
							if (219585 - 213778 != 5807)
							{
								continue;
							}
							if (this.$self_$40479.laugh_vc)
							{
								if (57717 - 305665 != -247948)
								{
									continue;
								}
								this.$self_$40479.audio.PlayOneShot(this.$self_$40479.laugh_vc);
								if (292799 - 482761 != -189961)
								{
									goto Block_4;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find laugh voice");
								if (251388 - 585460 != -334071)
								{
									goto Block_30;
								}
								continue;
							}
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (2088 - 570838 != -568750)
							{
								continue;
							}
							goto IL_531;
						}
						else
						{
							this.$mStoryGui$40477.newStoryMessage("CyborgMole", "Dr.Zappa", Language.getMessage("M706_MeetDrZappa", 102), eTalkType.friend);
							if (101952 - 49099 != 52854)
							{
								goto Block_41;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (143499 - 495056 != -351557)
							{
								continue;
							}
							goto IL_60E;
						}
						else
						{
							this.$mStoryGui$40477.newStoryMessage("CyborgMole", "Dr.Zappa", Language.getMessage("M706_MeetDrZappa", 103), eTalkType.friend);
							if (282469 - 49283 == 233187)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("nvoice", 1) == 0)
							{
								goto IL_4A6;
							}
							if (266310 - 152405 == 113906)
							{
								continue;
							}
							if (this.$self_$40479.chat2_vc)
							{
								if (47919 - 473262 == -425342)
								{
									continue;
								}
								this.$self_$40479.audio.PlayOneShot(this.$self_$40479.chat2_vc);
								if (221217 - 424417 != -203200)
								{
									continue;
								}
								goto IL_42E;
							}
							else
							{
								Debug.LogError("Cannot find chat2 voice");
								if (73105 - 411143 != -338037)
								{
									goto Block_33;
								}
								continue;
							}
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (210676 - 368773 != -158097)
							{
								continue;
							}
							goto IL_6CC;
						}
						else
						{
							this.$mStoryGui$40477.newStoryMessage("CyborgMole", "Dr.Zappa", Language.getMessage("M706_MeetDrZappa", 104), eTalkType.friend);
							if (146731 - 581419 != -434687)
							{
								goto Block_51;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (71382 - 561402 != -490020)
							{
								continue;
							}
							goto IL_1E4;
						}
						else
						{
							this.$mStoryGui$40477.newStoryMessage("CyborgMole", "Dr.Zappa", Language.getMessage("M706_MeetDrZappa", 105), eTalkType.friend);
							if (171933 - 525404 != -353471)
							{
								continue;
							}
							goto IL_CE;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.Start)
						{
							if (144361 - 196239 != -51877)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$40477.close();
							if (230472 - 149419 != 81053)
							{
								continue;
							}
							this.$self_$40479.SendMessage("fadeOut");
							if (166062 - 51315 != 114747)
							{
								continue;
							}
							goto IL_597;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.Start)
						{
							if (237137 - 525859 != -288721)
							{
								goto Block_44;
							}
							continue;
						}
						else
						{
							this.$mGameGui$40478 = (GameGui)this.$self_$40479.GetComponent(typeof(GameGui));
							if (98817 - 157236 != -58419)
							{
								continue;
							}
							this.$mGameGui$40478.enabled = true;
							if (93732 - 332811 == -239078)
							{
								continue;
							}
							this.$self_$40479.w8TcVlvjgbc.specialTarget = null;
							if (185257 - 115202 == 70056)
							{
								continue;
							}
							this.$self_$40479.SendMessage("fadeIn");
							if (63572 - 57506 != 6067)
							{
								goto Block_6;
							}
							continue;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.Start)
						{
							if (289822 - 140734 != 149089)
							{
								goto Block_49;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (74958 - 180962 == -106003)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (110789 - 503209 == -392419)
							{
								continue;
							}
							if (this.$self_$40479.i5QcVq1Gnjm)
							{
								if (131336 - 294294 == -162957)
								{
									continue;
								}
								this.$self_$40479.audio.PlayOneShot(this.$self_$40479.i5QcVq1Gnjm);
								if (233678 - 75052 == 158627)
								{
									continue;
								}
							}
							Game.sendMissionEvent(7061, 1);
							if (18767 - 547687 != -528920)
							{
								continue;
							}
							this.YieldDefault(1);
							if (210074 - 440800 != -230726)
							{
								continue;
							}
							goto IL_95B;
						}
						break;
					default:
						if (256370 - 619 != 255751)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (265096 - 41071 != 224026)
					{
						Game.mGameState = eGameState.Start;
						if (240477 - 352925 != -112447)
						{
							Game.mGameTime = Time.time;
							if (61709 - 191195 == -129486)
							{
								goto IL_68C;
							}
						}
					}
				}
				Block_4:
				goto IL_2CD;
				Block_5:
				goto IL_292;
				Block_6:
				return this.Yield(11, new WaitForSeconds(0.5f));
				IL_CE:
				return this.Yield(9, new WaitForSeconds(3f));
				Block_8:
				IL_1E4:
				goto IL_95B;
				IL_292:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_2CD:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_30:
				goto IL_2CD;
				IL_42E:
				Block_33:
				IL_4A6:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_40:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_531:
				goto IL_95B;
				Block_41:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_597:
				return this.Yield(10, new WaitForSeconds(1f));
				Block_44:
				IL_60E:
				Block_49:
				goto IL_95B;
				IL_68C:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_6CC:
				goto IL_95B;
				Block_51:
				return this.Yield(8, new WaitForSeconds(3f));
				Block_53:
				IL_86A:
				IL_95B:
				return false;
			}

			// Token: 0x06008AB3 RID: 35507 RVA: 0x01101984 File Offset: 0x010FFB84
			internal static bool reXenUVY2UlMYcxQFDDt()
			{
				return true;
			}

			// Token: 0x06008AB4 RID: 35508 RVA: 0x01101988 File Offset: 0x010FFB88
			internal static bool KurckeVY8lUkiu1gvO1N()
			{
				return false;
			}

			// Token: 0x040084E1 RID: 34017
			internal GameObject $mCyborgMole$40475;

			// Token: 0x040084E2 RID: 34018
			internal GameObject $mEventCamera1$40476;

			// Token: 0x040084E3 RID: 34019
			internal StoryGui $mStoryGui$40477;

			// Token: 0x040084E4 RID: 34020
			internal GameGui $mGameGui$40478;

			// Token: 0x040084E5 RID: 34021
			internal M706_MeetDrZappa $self_$40479;
		}
	}

	// Token: 0x0200174D RID: 5965
	[CompilerGenerated]
	[Serializable]
	internal sealed class $DevilKaiserEvent$40481 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008AB5 RID: 35509 RVA: 0x0110198C File Offset: 0x010FFB8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $DevilKaiserEvent$40481(M706_MeetDrZappa self_)
		{
			if (77942 - 407766 != -329824)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (164675 - 515323 != -350647)
				{
					base..ctor();
					if (203830 - 36565 == 167265)
					{
						this.$self_$40495 = self_;
						if (105956 - 331810 != -225853)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008AB6 RID: 35510 RVA: 0x01101A24 File Offset: 0x010FFC24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M706_MeetDrZappa.$DevilKaiserEvent$40481.$(this.$self_$40495);
		}

		// Token: 0x06008AB7 RID: 35511 RVA: 0x01101A34 File Offset: 0x010FFC34
		internal static bool om6avKVYZEZaN6hyZ5lK()
		{
			return true;
		}

		// Token: 0x06008AB8 RID: 35512 RVA: 0x01101A38 File Offset: 0x010FFC38
		internal static bool wigi2KVYC06oJ9ZUsBvi()
		{
			return false;
		}

		// Token: 0x040084E6 RID: 34022
		internal M706_MeetDrZappa $self_$40495;

		// Token: 0x0200174E RID: 5966
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008AB9 RID: 35513 RVA: 0x01101A3C File Offset: 0x010FFC3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M706_MeetDrZappa self_)
			{
				if (12642 - 389814 != -377172)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (113816 - 86935 != 26882)
					{
						base..ctor();
						if (290718 - 234943 != 55776)
						{
							this.$self_$40494 = self_;
							if (131824 - 99660 == 32164)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008ABA RID: 35514 RVA: 0x01101AD4 File Offset: 0x010FFCD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (283731 - 422552 != -138821)
				{
				}
				for (;;)
				{
					IL_1B7:
					switch (this._state)
					{
					case 0:
						goto IL_F66;
					case 1:
						goto IL_F86;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (91246 - 127257 != -36010)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							this.$self_$40494.SendMessage("fadeOut");
							if (272782 - 178858 != 93925)
							{
								goto Block_106;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (85253 - 339259 != -254005)
							{
								goto Block_50;
							}
							continue;
						}
						else
						{
							this.$mEnemyList$40483 = GameObject.FindGameObjectsWithTag("Enemy");
							if (45182 - 337531 == -292348)
							{
								continue;
							}
							this.$$iterator$10950$40485 = UnityRuntimeServices.GetEnumerator(this.$mEnemyList$40483);
							if (78696 - 50179 == 28518)
							{
								continue;
							}
							while (this.$$iterator$10950$40485.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10950$40485.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$mEnemy$40484 = (GameObject)obj2;
								if (297908 - 304065 != -6157)
								{
									goto IL_1B7;
								}
								if (!(this.$mEnemy$40484.name == "CyborgMole"))
								{
									if (133527 - 126847 != 6680)
									{
										goto IL_1B7;
									}
									if (!(this.$mEnemy$40484.name == "GallonBot"))
									{
										if (173326 - 261617 == -88290)
										{
											goto IL_1B7;
										}
										if (!(this.$mEnemy$40484.name == "AutoGallonGun"))
										{
											continue;
										}
										if (83920 - 552345 != -468425)
										{
											goto IL_1B7;
										}
									}
								}
								UnityEngine.Object.Destroy(this.$mEnemy$40484);
								if (68178 - 359348 == -291169)
								{
									goto IL_1B7;
								}
								UnityRuntimeServices.Update(this.$$iterator$10950$40485, this.$mEnemy$40484);
								if (225230 - 352980 == -127749)
								{
									goto IL_1B7;
								}
							}
							if (214220 - 538111 != -323891)
							{
								continue;
							}
							this.$startPoint$40486 = GameObject.Find("StartPoint" + Game.getPlayerSlot(PlayerData.UID));
							if (42250 - 588722 != -546472)
							{
								continue;
							}
							if (this.$startPoint$40486)
							{
								if (156801 - 484480 != -327679)
								{
									continue;
								}
								if (Game.mPlayer)
								{
									if (271806 - 29991 != 241815)
									{
										continue;
									}
									Game.mPlayer.transform.position = this.$startPoint$40486.transform.position;
									if (27416 - 280361 == -252944)
									{
										continue;
									}
									Game.mPlayer.transform.rotation = this.$startPoint$40486.transform.rotation;
									if (32655 - 90500 == -57844)
									{
										continue;
									}
									Game.mPlayer.SendMessage("PositionEvent");
									if (91108 - 438985 != -347877)
									{
										continue;
									}
								}
							}
							if (this.$self_$40494.cyborgMole)
							{
								if (54442 - 348763 == -294320)
								{
									continue;
								}
								this.$mCyborgMole$40487 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$40494.cyborgMole, new Vector3((float)0, 49.5f, (float)12), Quaternion.LookRotation(-Vector3.forward));
								if (123743 - 562011 == -438267)
								{
									continue;
								}
								this.$mCyborgMole$40487.animation.Play();
								if (202096 - 9825 == 192272)
								{
									continue;
								}
							}
							this.$mEventCamera2$40488 = GameObject.Find("EventCamera2");
							if (139627 - 295703 != -156076)
							{
								continue;
							}
							if (this.$mEventCamera2$40488)
							{
								if (289097 - 416014 != -126917)
								{
									continue;
								}
								this.$self_$40494.w8TcVlvjgbc.setSpecialTarget(this.$mEventCamera2$40488, (float)0);
								if (238910 - 405342 != -166432)
								{
									continue;
								}
							}
							this.$self_$40494.SendMessage("fadeIn");
							if (222259 - 309100 != -86841)
							{
								continue;
							}
							goto IL_152;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (227647 - 123143 != 104504)
							{
								continue;
							}
							goto IL_4D0;
						}
						else
						{
							this.$mStoryGui$40489 = (StoryGui)this.$self_$40494.GetComponent(typeof(StoryGui));
							if (99112 - 309888 != -210776)
							{
								continue;
							}
							this.$mStoryGui$40489.startStoryMessage("CyborgMole", "Dr.Zappa", eTalkType.friend);
							if (242062 - 3465 != 238597)
							{
								continue;
							}
							goto IL_67A;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (192705 - 40939 != 151767)
							{
								goto Block_47;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$40489.newStoryMessage("CyborgMole", "Dr.Zappa", Language.getMessage("M706_MeetDrZappa", 201), eTalkType.friend);
							if (103013 - 287881 != -184868)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("nvoice", 1) == 0)
							{
								goto IL_A37;
							}
							if (209861 - 506638 != -296777)
							{
								continue;
							}
							if (this.$self_$40494.laugh_vc)
							{
								if (185459 - 326918 == -141458)
								{
									continue;
								}
								this.$self_$40494.audio.PlayOneShot(this.$self_$40494.laugh_vc);
								if (249834 - 209452 != 40383)
								{
									goto Block_67;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find laugh voice");
								if (25934 - 176708 != -150773)
								{
									goto Block_36;
								}
								continue;
							}
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (24707 - 21190 != 3517)
							{
								continue;
							}
							goto IL_E0D;
						}
						else
						{
							this.$mEventCamera3$40490 = GameObject.Find("EventCamera3");
							if (35916 - 378480 == -342563)
							{
								continue;
							}
							if (this.$mEventCamera3$40490)
							{
								if (11836 - 139432 != -127596)
								{
									continue;
								}
								this.$self_$40494.w8TcVlvjgbc.setSpecialTarget(this.$mEventCamera3$40490, (float)2);
								if (88734 - 336310 == -247575)
								{
									continue;
								}
							}
							this.$mStoryGui$40489.newStoryMessage("CyborgMole", "Dr.Zappa", Language.getMessage("M706_MeetDrZappa", 202), eTalkType.friend);
							if (55934 - 391643 != -335708)
							{
								goto Block_7;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (123486 - 341731 != -218245)
							{
								continue;
							}
							goto IL_C0B;
						}
						else
						{
							this.$mStoryGui$40489.newStoryMessage("CyborgMole", "Dr.Zappa", Language.getMessage("M706_MeetDrZappa", 203), eTalkType.friend);
							if (113596 - 578402 != -464806)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("nvoice", 1) != 0)
							{
								if (263694 - 593079 == -329384)
								{
									continue;
								}
								if (this.$self_$40494.rapidCreation_vc)
								{
									if (193026 - 253457 == -60430)
									{
										continue;
									}
									this.$self_$40494.audio.PlayOneShot(this.$self_$40494.rapidCreation_vc);
									if (242690 - 487836 != -245146)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find rapidCreation voice");
									if (200020 - 390124 != -190104)
									{
										continue;
									}
								}
							}
							this.$mZappaKaiserBox$40491 = GameObject.Find("ZappaKaiserBox");
							if (108338 - 336942 == -228603)
							{
								continue;
							}
							this.$self_$40494.w8TcVlvjgbc.AddCamereShake((float)1);
							if (257747 - 39573 != 218174)
							{
								continue;
							}
							this.$self_$40494.iI6cVR4Jf7U = Time.time;
							if (11503 - 217726 != -206223)
							{
								continue;
							}
						}
						break;
					case 8:
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (200304 - 170791 != 29514)
							{
								goto Block_79;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$40489.newStoryMessage("CyborgMole", "Dr.Zappa", Language.getMessage("M706_MeetDrZappa", 204), eTalkType.friend);
							if (104577 - 356555 != -251977)
							{
								goto Block_63;
							}
							continue;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (153518 - 117554 != 35965)
							{
								goto Block_42;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$40489.close();
							if (4578 - 311623 != -307045)
							{
								continue;
							}
							this.$self_$40494.SendMessage("fadeOut");
							if (239003 - 319202 != -80199)
							{
								continue;
							}
							goto IL_494;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (235034 - 364172 != -129138)
							{
								continue;
							}
							goto IL_25A;
						}
						else
						{
							if (this.$mCyborgMole$40487)
							{
								if (104145 - 560217 != -456072)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mCyborgMole$40487);
								if (50645 - 313232 == -262586)
								{
									continue;
								}
							}
							if (this.$mZappaKaiserBox$40491)
							{
								if (197063 - 144667 == 52397)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mZappaKaiserBox$40491);
								if (35645 - 592375 != -556730)
								{
									continue;
								}
							}
							Game.sendMissionEvent(7061, 2);
							if (206629 - 583593 != -376963)
							{
								goto Block_64;
							}
							continue;
						}
						break;
					case 12:
						this.$self_$40494.SendMessage("fadeIn");
						if (20761 - 129461 != -108700)
						{
							continue;
						}
						goto IL_9C0;
					case 13:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (114641 - 476729 != -362087)
							{
								goto Block_70;
							}
							continue;
						}
						else
						{
							this.$mGameGui$40482.enabled = true;
							if (141301 - 315023 == -173721)
							{
								continue;
							}
							this.$self_$40494.w8TcVlvjgbc.specialTarget = null;
							if (91473 - 394090 == -302616)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (219698 - 302214 == -82515)
							{
								continue;
							}
							this.YieldDefault(1);
							if (162568 - 597558 != -434989)
							{
								goto Block_107;
							}
							continue;
						}
						break;
					default:
						if (239303 - 485994 != -246691)
						{
							continue;
						}
						goto IL_F66;
					}
					if (Time.time >= this.$self_$40494.iI6cVR4Jf7U + (float)1)
					{
						if (114040 - 419998 != -305958)
						{
							continue;
						}
						goto IL_AD0;
					}
					else
					{
						if (!this.$mZappaKaiserBox$40491)
						{
							goto IL_7D9;
						}
						if (28187 - 360909 == -332721)
						{
							continue;
						}
						float num = this.$$14430$40492 = Mathf.SmoothStep((float)50, (float)38, Time.time - this.$self_$40494.iI6cVR4Jf7U);
						if (161535 - 592146 != -430611)
						{
							continue;
						}
						if (184977 - 497667 != -312690)
						{
							continue;
						}
						Vector3 vector = this.$$14431$40493 = this.$mZappaKaiserBox$40491.transform.position;
						if (86871 - 74618 == 12254 || 235887 - 322708 == -86820)
						{
							continue;
						}
						this.$$14431$40493.y = this.$$14430$40492;
						if (9932 - 345230 == -335297)
						{
							continue;
						}
						if (37471 - 515576 != -478105)
						{
							continue;
						}
						this.$mZappaKaiserBox$40491.transform.position = this.$$14431$40493;
						if (107884 - 329854 == -221969)
						{
							continue;
						}
						if (181828 - 438949 != -257121)
						{
							continue;
						}
						goto IL_7D9;
					}
					IL_F66:
					Game.mGameState = eGameState.AllHold;
					if (13597 - 230207 != -216609)
					{
						this.$mGameGui$40482 = (GameGui)this.$self_$40494.GetComponent(typeof(GameGui));
						if (30606 - 460390 != -429783)
						{
							if (!this.$mGameGui$40482)
							{
								break;
							}
							if (160294 - 231188 != -70893)
							{
								this.$mGameGui$40482.close();
								if (159953 - 164726 == -4773)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(2f));
				Block_3:
				goto IL_F86;
				Block_7:
				return this.Yield(7, new WaitForSeconds(3f));
				IL_152:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_25A:
				goto IL_F86;
				IL_494:
				return this.Yield(11, new WaitForSeconds(1f));
				IL_4D0:
				goto IL_F86;
				Block_36:
				goto IL_A37;
				Block_42:
				goto IL_F86;
				IL_67A:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_47:
				Block_50:
				goto IL_F86;
				IL_7D9:
				return this.YieldDefault(8);
				Block_63:
				return this.Yield(10, new WaitForSeconds(3f));
				Block_64:
				return this.Yield(12, new WaitForSeconds(0.25f));
				Block_67:
				goto IL_A37;
				IL_9C0:
				return this.Yield(13, new WaitForSeconds(1f));
				Block_70:
				goto IL_F86;
				IL_A37:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_AD0:
				return this.Yield(9, new WaitForSeconds(3f));
				Block_79:
				IL_C0B:
				IL_E0D:
				goto IL_F86;
				Block_106:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_107:
				IL_F86:
				return false;
			}

			// Token: 0x06008ABB RID: 35515 RVA: 0x01102A7C File Offset: 0x01100C7C
			internal static bool Bni6sgVYL2xWdrVTyFGc()
			{
				return true;
			}

			// Token: 0x06008ABC RID: 35516 RVA: 0x01102A80 File Offset: 0x01100C80
			internal static bool gaHCm7VYOMRsNRbhFv2S()
			{
				return false;
			}

			// Token: 0x040084E7 RID: 34023
			internal GameGui $mGameGui$40482;

			// Token: 0x040084E8 RID: 34024
			internal UnityScript.Lang.Array $mEnemyList$40483;

			// Token: 0x040084E9 RID: 34025
			internal GameObject $mEnemy$40484;

			// Token: 0x040084EA RID: 34026
			internal IEnumerator $$iterator$10950$40485;

			// Token: 0x040084EB RID: 34027
			internal GameObject $startPoint$40486;

			// Token: 0x040084EC RID: 34028
			internal GameObject $mCyborgMole$40487;

			// Token: 0x040084ED RID: 34029
			internal GameObject $mEventCamera2$40488;

			// Token: 0x040084EE RID: 34030
			internal StoryGui $mStoryGui$40489;

			// Token: 0x040084EF RID: 34031
			internal GameObject $mEventCamera3$40490;

			// Token: 0x040084F0 RID: 34032
			internal GameObject $mZappaKaiserBox$40491;

			// Token: 0x040084F1 RID: 34033
			internal float $$14430$40492;

			// Token: 0x040084F2 RID: 34034
			internal Vector3 $$14431$40493;

			// Token: 0x040084F3 RID: 34035
			internal M706_MeetDrZappa $self_$40494;
		}
	}

	// Token: 0x0200174F RID: 5967
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$40496 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008ABD RID: 35517 RVA: 0x01102A84 File Offset: 0x01100C84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$40496(Hashtable data, M706_MeetDrZappa self_)
		{
			if (237723 - 469319 != -231596)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (75471 - 190576 != -115104)
				{
					base..ctor();
					if (178874 - 529098 != -350223)
					{
						this.$data$40503 = data;
						if (272604 - 257645 != 14960)
						{
							this.$self_$40504 = self_;
							if (243562 - 517733 != -274170)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008ABE RID: 35518 RVA: 0x01102B40 File Offset: 0x01100D40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M706_MeetDrZappa.$onGameComplete$40496.$(this.$data$40503, this.$self_$40504);
		}

		// Token: 0x06008ABF RID: 35519 RVA: 0x01102B54 File Offset: 0x01100D54
		internal static bool I1n6vwVYmwu6eE0vPO3j()
		{
			return true;
		}

		// Token: 0x06008AC0 RID: 35520 RVA: 0x01102B58 File Offset: 0x01100D58
		internal static bool DAWJYRVYFY7MLbiU2MIA()
		{
			return false;
		}

		// Token: 0x040084F4 RID: 34036
		internal Hashtable $data$40503;

		// Token: 0x040084F5 RID: 34037
		internal M706_MeetDrZappa $self_$40504;

		// Token: 0x02001750 RID: 5968
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008AC1 RID: 35521 RVA: 0x01102B5C File Offset: 0x01100D5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M706_MeetDrZappa self_)
			{
				if (143808 - 268801 != -124993)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (49503 - 551252 != -501748)
					{
						base..ctor();
						if (218945 - 226592 != -7646)
						{
							this.$data$40501 = data;
							if (29817 - 19054 != 10764)
							{
								this.$self_$40502 = self_;
								if (42148 - 427320 != -385171)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008AC2 RID: 35522 RVA: 0x01102C18 File Offset: 0x01100E18
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (134642 - 506097 != -371455)
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
						this.$mCompleteGui$40498 = (CompleteGui)this.$self_$40502.GetComponent(typeof(CompleteGui));
						if (11639 - 303479 != -291840)
						{
							continue;
						}
						this.$mCompleteGui$40498.Init();
						if (231151 - 437251 == -206099)
						{
							continue;
						}
						this.$mCompleteGui$40498.readData(this.$data$40501);
						if (195250 - 370044 != -174794)
						{
							continue;
						}
						if (this.$result$40497 == 1)
						{
							if (60549 - 294680 == -234130)
							{
								continue;
							}
							this.$mCompleteGui$40498.displayResult(eCompleteType.Success);
							if (263242 - 325399 != -62157)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$40498.displayResult(eCompleteType.Failed);
							if (172903 - 229514 == -56610)
							{
								continue;
							}
						}
						this.$mGameGui$40499 = (GameGui)this.$self_$40502.GetComponent(typeof(GameGui));
						if (152398 - 177646 == -25247)
						{
							continue;
						}
						this.$mStoryGui$40500 = (StoryGui)this.$self_$40502.GetComponent(typeof(StoryGui));
						if (176638 - 276214 == -99575)
						{
							continue;
						}
						if (this.$mGameGui$40499)
						{
							if (122700 - 84508 == 38193)
							{
								continue;
							}
							this.$mGameGui$40499.close();
							if (43945 - 555865 != -511920)
							{
								continue;
							}
						}
						if (this.$mStoryGui$40500)
						{
							if (286552 - 487627 != -201075)
							{
								continue;
							}
							this.$mStoryGui$40500.close();
							if (142866 - 447888 == -305021)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (168573 - 436177 != -267603)
						{
							goto Block_8;
						}
						continue;
					default:
						if (98410 - 18785 != 79625)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$40501[31]);
					if (187152 - 66619 == 120533)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (75443 - 296190 != -220746)
							{
								goto Block_15;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (220281 - 592260 != -371978)
							{
								this.$result$40497 = RuntimeServices.UnboxInt32(this.$data$40501[31]);
								if (243057 - 444790 != -201732)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_8:
				Block_15:
				IL_352:
				return false;
			}

			// Token: 0x06008AC3 RID: 35523 RVA: 0x01102F8C File Offset: 0x0110118C
			internal static bool wrq3TtVYMnnCAvhqx2qN()
			{
				return true;
			}

			// Token: 0x06008AC4 RID: 35524 RVA: 0x01102F90 File Offset: 0x01101190
			internal static bool DQ4CVNVYxYcYDIbC6aVD()
			{
				return false;
			}

			// Token: 0x040084F6 RID: 34038
			internal int $result$40497;

			// Token: 0x040084F7 RID: 34039
			internal CompleteGui $mCompleteGui$40498;

			// Token: 0x040084F8 RID: 34040
			internal GameGui $mGameGui$40499;

			// Token: 0x040084F9 RID: 34041
			internal StoryGui $mStoryGui$40500;

			// Token: 0x040084FA RID: 34042
			internal Hashtable $data$40501;

			// Token: 0x040084FB RID: 34043
			internal M706_MeetDrZappa $self_$40502;
		}
	}

	// Token: 0x02001751 RID: 5969
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$40505 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008AC5 RID: 35525 RVA: 0x01102F94 File Offset: 0x01101194
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$40505(M706_MeetDrZappa self_)
		{
			if (93096 - 159991 != -66895)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (275289 - 109713 != 165577)
				{
					base..ctor();
					if (215719 - 67314 != 148406)
					{
						this.$self_$40510 = self_;
						if (161289 - 348389 != -187099)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008AC6 RID: 35526 RVA: 0x0110302C File Offset: 0x0110122C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M706_MeetDrZappa.$onDeadPlayer$40505.$(this.$self_$40510);
		}

		// Token: 0x06008AC7 RID: 35527 RVA: 0x0110303C File Offset: 0x0110123C
		internal static bool LqC2fkVYg233SRSXRJg5()
		{
			return true;
		}

		// Token: 0x06008AC8 RID: 35528 RVA: 0x01103040 File Offset: 0x01101240
		internal static bool JCuQ9YVYfjJogd0I3s4E()
		{
			return false;
		}

		// Token: 0x040084FC RID: 34044
		internal M706_MeetDrZappa $self_$40510;

		// Token: 0x02001752 RID: 5970
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008AC9 RID: 35529 RVA: 0x01103044 File Offset: 0x01101244
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M706_MeetDrZappa self_)
			{
				if (140874 - 167233 != -26359)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (108321 - 354291 != -245969)
					{
						base..ctor();
						if (267082 - 464734 != -197651)
						{
							this.$self_$40509 = self_;
							if (146093 - 506893 != -360799)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008ACA RID: 35530 RVA: 0x011030DC File Offset: 0x011012DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (94626 - 500982 != -406355)
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
							if (118556 - 251362 == -132805)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_264;
							}
							if (27724 - 101538 == -73813)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (286771 - 392259 != -105488)
						{
							continue;
						}
						this.$mStoryGui$40506 = (StoryGui)this.$self_$40509.GetComponent(typeof(StoryGui));
						if (287623 - 414221 == -126597)
						{
							continue;
						}
						if (this.$mStoryGui$40506)
						{
							if (229361 - 426642 != -197281)
							{
								continue;
							}
							this.$mStoryGui$40506.close();
							if (180555 - 374199 != -193644)
							{
								continue;
							}
						}
						this.$mChangeGui$40507 = (ChangeGui)this.$self_$40509.GetComponent(typeof(ChangeGui));
						if (57014 - 142346 == -85331)
						{
							continue;
						}
						if (this.$mChangeGui$40507)
						{
							if (211764 - 444082 != -232318)
							{
								continue;
							}
							this.$mChangeGui$40507.close();
							if (238724 - 514538 == -275813)
							{
								continue;
							}
						}
						this.$mGameGui$40508 = (GameGui)this.$self_$40509.GetComponent(typeof(GameGui));
						if (57347 - 174536 != -117189)
						{
							continue;
						}
						if (this.$mGameGui$40508)
						{
							if (112913 - 104454 != 8459)
							{
								continue;
							}
							if (!this.$mGameGui$40508.enabled)
							{
								if (212518 - 14946 != 197572)
								{
									continue;
								}
								this.$mGameGui$40508.enabled = true;
								if (104759 - 89273 != 15486)
								{
									continue;
								}
							}
							this.$mGameGui$40508.openDeadMenu();
							if (98067 - 84178 == 13890)
							{
								continue;
							}
						}
						IL_264:
						this.YieldDefault(1);
						if (124500 - 154676 != -30176)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (34883 - 426983 == -392099)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (214998 - 323074 == -108075);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06008ACB RID: 35531 RVA: 0x011033F4 File Offset: 0x011015F4
			internal static bool L8wFrrVYnkV9cPMxiPpF()
			{
				return true;
			}

			// Token: 0x06008ACC RID: 35532 RVA: 0x011033F8 File Offset: 0x011015F8
			internal static bool wjJIFUVY6MHT418yuMxc()
			{
				return false;
			}

			// Token: 0x040084FD RID: 34045
			internal StoryGui $mStoryGui$40506;

			// Token: 0x040084FE RID: 34046
			internal ChangeGui $mChangeGui$40507;

			// Token: 0x040084FF RID: 34047
			internal GameGui $mGameGui$40508;

			// Token: 0x04008500 RID: 34048
			internal M706_MeetDrZappa $self_$40509;
		}
	}

	// Token: 0x02001753 RID: 5971
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$40511 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008ACD RID: 35533 RVA: 0x011033FC File Offset: 0x011015FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$40511(M706_MeetDrZappa self_)
		{
			if (173176 - 447269 != -274092)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (202244 - 14920 != 187325)
				{
					base..ctor();
					if (105041 - 195685 != -90643)
					{
						this.$self_$40515 = self_;
						if (285537 - 448825 == -163288)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008ACE RID: 35534 RVA: 0x01103494 File Offset: 0x01101694
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M706_MeetDrZappa.$ReturnToTown$40511.$(this.$self_$40515);
		}

		// Token: 0x06008ACF RID: 35535 RVA: 0x011034A4 File Offset: 0x011016A4
		internal static bool NtIvEaVYicGGKgduHxD0()
		{
			return true;
		}

		// Token: 0x06008AD0 RID: 35536 RVA: 0x011034A8 File Offset: 0x011016A8
		internal static bool v19FDYVYKvAbUtxsFXlZ()
		{
			return false;
		}

		// Token: 0x04008501 RID: 34049
		internal M706_MeetDrZappa $self_$40515;

		// Token: 0x02001754 RID: 5972
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008AD1 RID: 35537 RVA: 0x011034AC File Offset: 0x011016AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M706_MeetDrZappa self_)
			{
				if (23791 - 497125 != -473334)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (266830 - 367478 == -100648)
					{
						base..ctor();
						if (232866 - 402511 == -169645)
						{
							this.$self_$40514 = self_;
							if (31347 - 261711 != -230363)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008AD2 RID: 35538 RVA: 0x01103544 File Offset: 0x01101744
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (176841 - 309886 != -133044)
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
						this.$self_$40514.LeaveGame();
						if (229121 - 363145 == -134023)
						{
							continue;
						}
						this.YieldDefault(1);
						if (295511 - 65864 != 229647)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (115210 - 471394 == -356183)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (250347 - 126642 == 123705)
					{
						Game.mStateTime = Time.time;
						if (47077 - 580867 == -533790)
						{
							this.$$switch$7199$40512 = PlayerData.SaveGuild;
							if (274441 - 382462 == -108021)
							{
								if (this.$$switch$7199$40512 == 1)
								{
									if (221857 - 496534 != -274677)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (267307 - 494071 == -226763)
									{
										continue;
									}
								}
								else if (this.$$switch$7199$40512 == 2)
								{
									if (71995 - 26440 != 45555)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (114173 - 77794 != 36379)
									{
										continue;
									}
								}
								else if (this.$$switch$7199$40512 == 3)
								{
									if (213352 - 439576 == -226223)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (198908 - 232930 == -34021)
									{
										continue;
									}
								}
								else if (this.$$switch$7199$40512 == 4)
								{
									if (277944 - 384879 != -106935)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (64276 - 423249 != -358973)
									{
										continue;
									}
								}
								else if (this.$$switch$7199$40512 == 5)
								{
									if (271601 - 62333 != 209268)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (203873 - 247932 == -44058)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (277038 - 318488 != -41450)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (6327 - 504011 != -497684)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (270407 - 495243 == -224835)
									{
										continue;
									}
								}
								this.$mGameGui$40513 = (GameGui)this.$self_$40514.GetComponent(typeof(GameGui));
								if (58142 - 104984 != -46841)
								{
									if (this.$mGameGui$40513)
									{
										if (234134 - 68024 != 166110)
										{
											continue;
										}
										this.$mGameGui$40513.close();
										if (48696 - 419037 == -370340)
										{
											continue;
										}
									}
									this.$self_$40514.SendMessage("fadeOut");
									if (234026 - 303214 == -69188)
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

			// Token: 0x06008AD3 RID: 35539 RVA: 0x01103910 File Offset: 0x01101B10
			internal static bool GDxy7mVYdyLBoxH1pL6f()
			{
				return true;
			}

			// Token: 0x06008AD4 RID: 35540 RVA: 0x01103914 File Offset: 0x01101B14
			internal static bool OyjtYOVYJH5hSiRSlWVm()
			{
				return false;
			}

			// Token: 0x04008502 RID: 34050
			internal int $$switch$7199$40512;

			// Token: 0x04008503 RID: 34051
			internal GameGui $mGameGui$40513;

			// Token: 0x04008504 RID: 34052
			internal M706_MeetDrZappa $self_$40514;
		}
	}

	// Token: 0x02001755 RID: 5973
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$40516 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008AD5 RID: 35541 RVA: 0x01103918 File Offset: 0x01101B18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$40516(M706_MeetDrZappa self_)
		{
			if (72042 - 438215 != -366172)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (274613 - 58982 != 215632)
				{
					base..ctor();
					if (112631 - 132411 != -19779)
					{
						this.$self_$40519 = self_;
						if (274796 - 256598 != 18199)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008AD6 RID: 35542 RVA: 0x011039B0 File Offset: 0x01101BB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M706_MeetDrZappa.$ReturnToGuild$40516.$(this.$self_$40519);
		}

		// Token: 0x06008AD7 RID: 35543 RVA: 0x011039C0 File Offset: 0x01101BC0
		internal static bool Tolfx8VYDKcYtOiKLOoX()
		{
			return true;
		}

		// Token: 0x06008AD8 RID: 35544 RVA: 0x011039C4 File Offset: 0x01101BC4
		internal static bool CsgnAOVYvBhIoOhYDo6Z()
		{
			return false;
		}

		// Token: 0x04008505 RID: 34053
		internal M706_MeetDrZappa $self_$40519;

		// Token: 0x02001756 RID: 5974
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008AD9 RID: 35545 RVA: 0x011039C8 File Offset: 0x01101BC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M706_MeetDrZappa self_)
			{
				if (43485 - 12801 != 30684)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (93992 - 393854 == -299862)
					{
						base..ctor();
						if (174706 - 230060 != -55353)
						{
							this.$self_$40518 = self_;
							if (285710 - 483070 == -197360)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008ADA RID: 35546 RVA: 0x01103A60 File Offset: 0x01101C60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (119483 - 271729 != -152245)
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
						this.$self_$40518.LeaveGame();
						if (54853 - 497328 != -442475)
						{
							continue;
						}
						this.YieldDefault(1);
						if (183154 - 478103 != -294948)
						{
							goto Block_10;
						}
						continue;
					default:
						if (121320 - 412434 != -291114)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (17155 - 220339 != -203183)
					{
						Game.mStateTime = Time.time;
						if (170269 - 306233 != -135963)
						{
							Game.mNextGameCode = 31;
							if (95813 - 372845 == -277032)
							{
								this.$mGameGui$40517 = (GameGui)this.$self_$40518.GetComponent(typeof(GameGui));
								if (284588 - 423120 != -138531)
								{
									if (this.$mGameGui$40517)
									{
										if (202873 - 348931 != -146058)
										{
											continue;
										}
										this.$mGameGui$40517.close();
										if (149505 - 77184 == 72322)
										{
											continue;
										}
									}
									this.$self_$40518.SendMessage("fadeOut");
									if (126352 - 424231 == -297879)
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

			// Token: 0x06008ADB RID: 35547 RVA: 0x01103C3C File Offset: 0x01101E3C
			internal static bool RtlkdGVYRM9O1coLQhIu()
			{
				return true;
			}

			// Token: 0x06008ADC RID: 35548 RVA: 0x01103C40 File Offset: 0x01101E40
			internal static bool UII1xtVYwFpbY4EFK8sV()
			{
				return false;
			}

			// Token: 0x04008506 RID: 34054
			internal GameGui $mGameGui$40517;

			// Token: 0x04008507 RID: 34055
			internal M706_MeetDrZappa $self_$40518;
		}
	}

	// Token: 0x02001757 RID: 5975
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$40520 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008ADD RID: 35549 RVA: 0x01103C44 File Offset: 0x01101E44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$40520(M706_MeetDrZappa self_)
		{
			if (65844 - 336596 != -270752)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (2683 - 163673 == -160990)
				{
					base..ctor();
					if (21393 - 158955 != -137561)
					{
						this.$self_$40524 = self_;
						if (3088 - 63495 == -60407)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008ADE RID: 35550 RVA: 0x01103CDC File Offset: 0x01101EDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M706_MeetDrZappa.$ReturnToCamp$40520.$(this.$self_$40524);
		}

		// Token: 0x06008ADF RID: 35551 RVA: 0x01103CEC File Offset: 0x01101EEC
		internal static bool q8b9cSVYquCDs6867uLs()
		{
			return true;
		}

		// Token: 0x06008AE0 RID: 35552 RVA: 0x01103CF0 File Offset: 0x01101EF0
		internal static bool DZ32sgVY7b3M7TBfmM5y()
		{
			return false;
		}

		// Token: 0x04008508 RID: 34056
		internal M706_MeetDrZappa $self_$40524;

		// Token: 0x02001758 RID: 5976
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008AE1 RID: 35553 RVA: 0x01103CF4 File Offset: 0x01101EF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M706_MeetDrZappa self_)
			{
				if (205862 - 355643 != -149781)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (109168 - 394512 == -285344)
					{
						base..ctor();
						if (57155 - 109280 == -52125)
						{
							this.$self_$40523 = self_;
							if (51529 - 123344 != -71814)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008AE2 RID: 35554 RVA: 0x01103D8C File Offset: 0x01101F8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (18479 - 429386 != -410906)
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
						this.$self_$40523.LeaveGame();
						if (79804 - 488260 != -408456)
						{
							continue;
						}
						this.YieldDefault(1);
						if (199292 - 84943 != 114349)
						{
							continue;
						}
						goto IL_363;
					default:
						if (81879 - 257177 != -175298)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (244565 - 232632 != 11934)
					{
						Game.mStateTime = Time.time;
						if (286807 - 422596 == -135789)
						{
							this.$$switch$7201$40521 = PlayerData.SaveGuild;
							if (234813 - 479888 == -245075)
							{
								if (this.$$switch$7201$40521 == 1)
								{
									if (241134 - 588627 == -347492)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (185391 - 279264 == -93872)
									{
										continue;
									}
								}
								else if (this.$$switch$7201$40521 == 2)
								{
									if (46670 - 83987 != -37317)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (138491 - 475380 == -336888)
									{
										continue;
									}
								}
								else if (this.$$switch$7201$40521 == 3)
								{
									if (31271 - 6380 == 24892)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (194899 - 465454 == -270554)
									{
										continue;
									}
								}
								else if (this.$$switch$7201$40521 == 4)
								{
									if (117294 - 166822 == -49527)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (65005 - 545532 == -480526)
									{
										continue;
									}
								}
								else if (this.$$switch$7201$40521 == 5)
								{
									if (31824 - 543881 != -512057)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (62913 - 262143 == -199229)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (72798 - 279099 != -206301)
									{
										continue;
									}
								}
								this.$mGameGui$40522 = (GameGui)this.$self_$40523.GetComponent(typeof(GameGui));
								if (223396 - 277848 == -54452)
								{
									if (this.$mGameGui$40522)
									{
										if (274940 - 212223 != 62717)
										{
											continue;
										}
										this.$mGameGui$40522.close();
										if (138420 - 266281 == -127860)
										{
											continue;
										}
									}
									this.$self_$40523.SendMessage("fadeOut");
									if (171537 - 53122 != 118416)
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

			// Token: 0x06008AE3 RID: 35555 RVA: 0x01104110 File Offset: 0x01102310
			internal static bool QIEt33VYPTZVUPSpsbNn()
			{
				return true;
			}

			// Token: 0x06008AE4 RID: 35556 RVA: 0x01104114 File Offset: 0x01102314
			internal static bool ir4OjUVY0GKgp7fk3JPV()
			{
				return false;
			}

			// Token: 0x04008509 RID: 34057
			internal int $$switch$7201$40521;

			// Token: 0x0400850A RID: 34058
			internal GameGui $mGameGui$40522;

			// Token: 0x0400850B RID: 34059
			internal M706_MeetDrZappa $self_$40523;
		}
	}
}
