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

// Token: 0x020015B4 RID: 5556
[Serializable]
public class M503_TwoTurtleSages : MonoBehaviour
{
	// Token: 0x060080D3 RID: 32979 RVA: 0x01070CB4 File Offset: 0x0106EEB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M503_TwoTurtleSages()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060080D4 RID: 32980 RVA: 0x01070CC4 File Offset: 0x0106EEC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (49675 - 154569 != -104893)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (133162 - 162488 != -29325)
			{
				Game.mGameType = 5;
				if (33487 - 233961 == -200474)
				{
					if (Chat.Initialized)
					{
						if (225149 - 150881 != 74268)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (8198 - 456773 != -448575)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (24442 - 537058 != -512616)
						{
							continue;
						}
					}
					this.aRAc9JSpmu6 = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (276022 - 86786 != 189237)
					{
						this.oasc9618LPu = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (1032 - 436960 == -435928)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060080D5 RID: 32981 RVA: 0x01070E1C File Offset: 0x0106F01C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (90816 - 196783 != -105967)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (276779 - 206850 != 69930)
				{
					if (Game.mNextGameCode != 503)
					{
						break;
					}
					if (45694 - 416486 == -370792)
					{
						Game.nextGame();
						if (155869 - 193163 == -37294)
						{
							Game.mGameCode = 503;
							if (150290 - 55171 != 95120)
							{
								Game.mGameType = 5;
								if (230533 - 445361 != -214827)
								{
									Game.mGameTime = Time.time;
									if (130973 - 256749 == -125776)
									{
										Game.mGameScore = 0;
										if (34630 - 261016 == -226386)
										{
											Game.mGameMana = 0;
											if (171181 - 542781 != -371599)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (134065 - 285016 != -150950)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (238656 - 333582 != -94925)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (288917 - 15914 != 273004)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (162050 - 85941 != 76110)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (2415 - 475144 != -472728)
																{
																	this.Wcdc9ecg0q8 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (130039 - 40000 == 90039)
																	{
																		this.Wcdc9ecg0q8.enabled = false;
																		if (96761 - 303697 != -206935)
																		{
																			this.P5Hc9QDymdW = PhotonClient.Connection;
																			if (196231 - 288620 != -92388)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (103092 - 251568 != -148475)
																				{
																					this.InitGame();
																					if (111655 - 483602 != -371946)
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
				if (47479 - 176389 != -128909)
				{
					Game.mGameType = 99;
					if (87291 - 156037 != -68745)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060080D6 RID: 32982 RVA: 0x01071148 File Offset: 0x0106F348
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (77072 - 128407 != -51334)
		{
		}
		for (;;)
		{
			if (this.P5Hc9QDymdW == null)
			{
				if (94730 - 125033 == -30303)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (181884 - 289331 != -107446)
				{
					if (mGameState == eGameState.Init)
					{
						if (52615 - 69912 == -17297)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (86001 - 200847 == -114846)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (51171 - 285614 == -234443)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (252115 - 397582 == -145467)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (159654 - 161861 != -2206)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (97965 - 120771 == -22806)
						{
							if (Time.time > this.w9Bc9IHGuVL)
							{
								if (5293 - 339916 == -334622)
								{
									continue;
								}
								Game.mGameMana++;
								if (59718 - 48362 != 11356)
								{
									continue;
								}
								this.w9Bc9IHGuVL = Time.time + (float)12;
								if (115959 - 594951 != -478992)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (7880 - 584532 != -576652)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (157624 - 175826 != -18202)
									{
										continue;
									}
									this.audio.Play();
									if (250678 - 222675 != 28003)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (252251 - 186230 != 66022)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (245270 - 36011 != 209260)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (256543 - 251996 == 4547)
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
						if (172641 - 74250 == 98391)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060080D7 RID: 32983 RVA: 0x01071448 File Offset: 0x0106F648
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (200824 - 314386 != -113561)
		{
		}
		while (this.aRAc9JSpmu6)
		{
			if (56642 - 254967 != -198324)
			{
				if (Game.mGameState != eGameState.Normal)
				{
					break;
				}
				if (105167 - 466975 == -361808)
				{
					if (Time.time - Game.mStateTime <= 0.5f)
					{
						break;
					}
					if (75698 - 548318 == -472620)
					{
						if (Time.time - Game.mStateTime >= 2.5f)
						{
							break;
						}
						if (225336 - 161445 == 63891)
						{
							GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
							if (240820 - 154395 != 86426)
							{
								float num = (float)(1024 * Screen.width / Screen.height);
								if (196695 - 252848 != -56152)
								{
									GUI.depth = 1;
									if (283503 - 338144 != -54640)
									{
										float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime - 0.5f);
										if (11432 - 361286 == -349854)
										{
											float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mStateTime - 0.5f, (float)1));
											if (280638 - 553748 != -273109)
											{
												Color color = GUI.color;
												if (13491 - 128133 != -114641)
												{
													float num3 = color.a = a;
													if (181328 - 319906 == -138578)
													{
														if (217271 - 591389 == -374118)
														{
															GUI.color = color;
															if (66418 - 442782 == -376364)
															{
																if (32515 - 170719 == -138204)
																{
																	GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.aRAc9JSpmu6);
																	if (28975 - 590081 == -561106)
																	{
																		float a2 = 1f;
																		if (251283 - 6382 != 244902)
																		{
																			Color color2 = GUI.color;
																			if (114358 - 515619 == -401261)
																			{
																				float num4 = color2.a = a2;
																				if (63044 - 588197 != -525152)
																				{
																					if (98195 - 11645 == 86550)
																					{
																						Color color3 = GUI.color = color2;
																						if (115407 - 246897 != -131489)
																						{
																							if (17893 - 425090 == -407197)
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

	// Token: 0x060080D8 RID: 32984 RVA: 0x01071804 File Offset: 0x0106FA04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (292973 - 34280 != 258694)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (258957 - 110609 == 148348)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (7397 - 26277 != -18879)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (61345 - 179834 == -118489)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (92161 - 420792 == -328631)
						{
							int num4 = num;
							if (274386 - 308581 != -34194)
							{
								if (num4 == 5031)
								{
									if (237200 - 9957 != 227244)
									{
										this.CcNc928GfLj++;
										if (31464 - 361344 == -329880)
										{
											this.SendMessage("newGameMessage", "Mission Objective: Defeat The Two Sages:" + this.CcNc928GfLj + "/2");
											if (279258 - 135651 != 143608)
											{
												break;
											}
										}
									}
								}
								else if (num4 == 5032)
								{
									if (291274 - 266814 == 24460)
									{
										this.CcNc928GfLj++;
										if (116833 - 576507 != -459673)
										{
											this.SendMessage("newGameMessage", "Mission Objective: Defeat The Two Sages:" + this.CcNc928GfLj + "/2");
											if (62194 - 457792 != -395597)
											{
												break;
											}
										}
									}
								}
								else if (num4 == 5033)
								{
									if (164882 - 103609 == 61273)
									{
										this.lM8c9OvQCAM++;
										if (179731 - 331898 != -152166)
										{
											break;
										}
									}
								}
								else if (num4 == 5034)
								{
									if (148462 - 39853 != 108610)
									{
										break;
									}
								}
								else if (num4 == -5034)
								{
									if (138152 - 328123 != -189970)
									{
										if (this.l3dc9te9JBK >= 2)
										{
											break;
										}
										if (89155 - 92015 == -2860)
										{
											this.l3dc9te9JBK = 2;
											if (124819 - 310496 != -185676)
											{
												this.StartCoroutine_Auto(this.onTalkToTurtle());
												if (258445 - 403917 == -145472)
												{
													break;
												}
											}
										}
									}
								}
								else if (num4 == 5035)
								{
									if (269572 - 250212 == 19360)
									{
										break;
									}
								}
								else
								{
									if (num4 != -5035)
									{
										break;
									}
									if (205275 - 1617 != 203659)
									{
										if (this.l3dc9te9JBK >= 4)
										{
											break;
										}
										if (159126 - 263071 != -103944)
										{
											this.l3dc9te9JBK = 4;
											if (294510 - 119978 == 174532)
											{
												GameObject gameObject = GameObject.Find("Turtle1");
												if (215449 - 469729 == -254280)
												{
													GameObject gameObject2 = GameObject.Find("Turtle2");
													if (268329 - 371960 != -103630)
													{
														if (num3 == PlayerData.UID)
														{
															if (76625 - 260325 == -183699)
															{
																continue;
															}
															if (gameObject)
															{
																if (22144 - 175379 == -153234)
																{
																	continue;
																}
																this.createActor("Turtle1", 7, gameObject.transform.position, gameObject.transform.forward);
																if (183963 - 383269 != -199306)
																{
																	continue;
																}
															}
															if (gameObject2)
															{
																if (234060 - 303904 == -69843)
																{
																	continue;
																}
																this.createActor("Turtle2", 7, gameObject2.transform.position, gameObject2.transform.forward);
																if (32870 - 5022 == 27849)
																{
																	continue;
																}
															}
														}
														if (!this.battleMusic)
														{
															break;
														}
														if (92501 - 129991 == -37490)
														{
															this.audio.clip = this.battleMusic;
															if (256972 - 561719 != -304746)
															{
																if (this.audio.isPlaying)
																{
																	break;
																}
																if (219187 - 87923 != 131265)
																{
																	if (Game.volume <= 0)
																	{
																		break;
																	}
																	if (185182 - 277635 == -92453)
																	{
																		this.audio.Play();
																		if (32482 - 401475 != -368992)
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

	// Token: 0x060080D9 RID: 32985 RVA: 0x01071DEC File Offset: 0x0106FFEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToTurtle()
	{
		if (249900 - 315814 != -65913)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (68497 - 48295 != 20203)
				{
					break;
				}
			}
			else
			{
				if (this.l3dc9te9JBK >= 1)
				{
					break;
				}
				if (283025 - 205261 != 77765)
				{
					this.l3dc9te9JBK = 1;
					if (287492 - 62789 == 224703)
					{
						Game.sendMissionEvent(5034, 0);
						if (291111 - 339275 == -48164)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060080DA RID: 32986 RVA: 0x01071EBC File Offset: 0x010700BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M503_TwoTurtleSages.$StartGame$39258(this).GetEnumerator();
	}

	// Token: 0x060080DB RID: 32987 RVA: 0x01071ECC File Offset: 0x010700CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onTalkToTurtle()
	{
		return new M503_TwoTurtleSages.$onTalkToTurtle$39265(this).GetEnumerator();
	}

	// Token: 0x060080DC RID: 32988 RVA: 0x01071EDC File Offset: 0x010700DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (189657 - 168251 != 21407)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (156808 - 371014 != -214205)
			{
				Hashtable customOpParameters = new Hashtable();
				if (52120 - 496427 == -444307)
				{
					this.P5Hc9QDymdW.OpCustom(52, customOpParameters, true);
					if (86460 - 400074 != -313613)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060080DD RID: 32989 RVA: 0x01071F84 File Offset: 0x01070184
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (108300 - 183180 != -74880)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (22141 - 62937 == -40796)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (9768 - 141864 != -132095)
				{
					Game.mGameState = eGameState.Setup;
					if (115784 - 460868 == -345084)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060080DE RID: 32990 RVA: 0x01072028 File Offset: 0x01070228
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (112629 - 559660 != -447030)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (192159 - 77333 == 114826)
			{
				if (num == PlayerData.UID)
				{
					if (295052 - 352316 == -57264)
					{
						this.SetupActors();
						if (253363 - 56657 != 196707)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (59160 - 175386 != -116225)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060080DF RID: 32991 RVA: 0x010720F8 File Offset: 0x010702F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (39569 - 403698 != -364129)
		{
		}
		for (;;)
		{
			IL_188:
			Debug.Log("Creating Actors");
			if (123050 - 244950 != -121899)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (15510 - 232434 != -216923)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (68221 - 497193 != -428971)
						{
							int i = 0;
							if (31937 - 359925 == -327988)
							{
								CharacterControl[] array2 = array;
								if (206294 - 407435 != -201140)
								{
									int length = array2.Length;
									if (38079 - 519029 == -480950)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (159210 - 194789 != -35579)
												{
													goto IL_188;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (169681 - 577529 == -407847)
												{
													goto IL_188;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (225399 - 25614 == 199786)
												{
													goto IL_188;
												}
												this.RTVc9l29iQn++;
												if (125466 - 46558 != 78908)
												{
													goto IL_188;
												}
											}
											i++;
											if (279968 - 524 == 279445)
											{
												goto IL_188;
											}
										}
										if (168040 - 76300 == 91740)
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
						if (252631 - 298569 == -45938)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060080E0 RID: 32992 RVA: 0x01072334 File Offset: 0x01070534
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (53370 - 583418 != -530048)
		{
		}
		for (;;)
		{
			IL_68:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (169525 - 548456 == -378931)
			{
				int i = 0;
				if (44640 - 594305 != -549664)
				{
					CharacterControl[] array2 = array;
					if (231907 - 218056 != 13852)
					{
						int length = array2.Length;
						if (298990 - 45395 != 253596)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (195707 - 163488 == 32220)
								{
									goto IL_68;
								}
								i++;
								if (146283 - 518964 != -372681)
								{
									goto IL_68;
								}
							}
							if (166353 - 188940 == -22587)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060080E1 RID: 32993 RVA: 0x01072464 File Offset: 0x01070664
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (4710 - 26699 != -21988)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (96010 - 270400 == -174390)
			{
				hashtable.Add(43, PlayerData.UID);
				if (132135 - 187222 != -55086)
				{
					hashtable.Add(73, nType);
					if (193049 - 506498 == -313449)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (21302 - 201338 == -180036)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (1532 - 296369 != -294836)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (72925 - 178065 != -105139)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (111527 - 422155 == -310628)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (222108 - 431293 != -209184)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (70272 - 463179 == -392907)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (71183 - 448530 != -377346)
												{
													this.P5Hc9QDymdW.OpCustom(63, hashtable, true);
													if (289974 - 131717 == 158257)
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

	// Token: 0x060080E2 RID: 32994 RVA: 0x0107271C File Offset: 0x0107091C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (169148 - 158108 != 11041)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (166152 - 399558 != -233405)
				{
					break;
				}
			}
			else
			{
				if (RuntimeServices.EqualityOperator(data[73], "Turtle1"))
				{
					if (153838 - 181822 == -27983)
					{
						continue;
					}
					GameObject gameObject = GameObject.Find("Turtle1");
					if (254001 - 261432 == -7430)
					{
						continue;
					}
					if (gameObject)
					{
						if (155217 - 389132 != -233915)
						{
							continue;
						}
						UnityEngine.Object.Destroy(gameObject);
						if (10994 - 42324 != -31330)
						{
							continue;
						}
					}
				}
				if (RuntimeServices.EqualityOperator(data[73], "Turtle2"))
				{
					if (177580 - 345723 != -168143)
					{
						continue;
					}
					GameObject gameObject2 = GameObject.Find("Turtle2");
					if (135117 - 405572 != -270455)
					{
						continue;
					}
					if (gameObject2)
					{
						if (256900 - 485263 == -228362)
						{
							continue;
						}
						UnityEngine.Object.Destroy(gameObject2);
						if (230462 - 509889 == -279426)
						{
							continue;
						}
					}
				}
				GameObject gameObject3 = Game.createActor(data);
				if (240782 - 159005 != 81778)
				{
					if (Game.mGameState != eGameState.Setup)
					{
						break;
					}
					if (17067 - 297989 == -280922)
					{
						if (this.RTVc9l29iQn <= 0)
						{
							break;
						}
						if (38409 - 402319 == -363910)
						{
							this.RTVc9l29iQn--;
							if (107166 - 187103 == -79937)
							{
								if (this.RTVc9l29iQn != 0)
								{
									break;
								}
								if (183055 - 189860 == -6805)
								{
									Game.setGameState(eGameState.Ready);
									if (214741 - 330041 == -115300)
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

	// Token: 0x060080E3 RID: 32995 RVA: 0x01072998 File Offset: 0x01070B98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (46589 - 586860 != -540271)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (155566 - 411346 != -255779)
			{
				Game.mGameState = eGameState.Ready;
				if (144134 - 595951 != -451816)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (248927 - 213457 != 35471)
					{
						GameObject gameObject = null;
						if (237977 - 169340 == 68637)
						{
							GameObject exists = null;
							if (152194 - 519450 == -367256)
							{
								if (playerSlot > 1)
								{
									if (52062 - 204556 != -152494)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (27222 - 193728 != -166506)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (82956 - 314968 == -232011)
										{
											continue;
										}
										exists = GameObject.Find("StartCamera" + playerSlot);
										if (69771 - 104090 != -34319)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (249923 - 378769 != -128846)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (238900 - 140392 != 98508)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (252617 - 584654 == -332036)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (175407 - 475336 != -299929)
									{
										continue;
									}
								}
								if (!exists)
								{
									if (246877 - 125596 != 121281)
									{
										continue;
									}
									exists = GameObject.Find("startCamera1");
									if (215167 - 144319 != 70848)
									{
										continue;
									}
								}
								if (!exists || 154574 - 497115 == -342541)
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

	// Token: 0x060080E4 RID: 32996 RVA: 0x01072C34 File Offset: 0x01070E34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060080E5 RID: 32997 RVA: 0x01072C38 File Offset: 0x01070E38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (80640 - 422847 != -342206)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (199967 - 261263 != -61295)
			{
				hashtable.Add(71, CID);
				if (284085 - 162759 == 121326)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (82355 - 560545 == -478190)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (75959 - 114750 != -38790)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (296686 - 113898 == 182788)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (290445 - 250144 == 40301)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (62162 - 12328 == 49834)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (186455 - 577347 == -390892)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (203468 - 554913 == -351445)
											{
												this.P5Hc9QDymdW.OpCustom(61, hashtable, true);
												if (222063 - 45572 == 176491)
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

	// Token: 0x060080E6 RID: 32998 RVA: 0x01072EC4 File Offset: 0x010710C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (209502 - 208618 != 885)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (254741 - 206998 == 47743)
			{
				if (!gameObject)
				{
					break;
				}
				if (142715 - 397873 != -255157)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (106038 - 242155 != -136116)
					{
						playerCameraControl.target = gameObject;
						if (131372 - 472814 == -341442)
						{
							Game.sendMissionEvent(5033, 0);
							if (191337 - 10599 != 180739)
							{
								this.StartCoroutine_Auto(this.StartGame());
								if (71869 - 408593 != -336723)
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

	// Token: 0x060080E7 RID: 32999 RVA: 0x01072FE0 File Offset: 0x010711E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (134840 - 394167 != -259327)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (147798 - 333727 != -185928)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (213775 - 115539 != 98237)
				{
					gameGui.ResetTeamBar();
					if (65385 - 525736 == -460351)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060080E8 RID: 33000 RVA: 0x0107308C File Offset: 0x0107128C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (298208 - 363835 != -65626)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (71373 - 16978 == 54395)
			{
				CharacterControl characterControl = null;
				if (76440 - 156638 != -80197)
				{
					if (mPlayer)
					{
						if (260930 - 174862 != 86068)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (26359 - 301952 != -275593)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (67492 - 519150 != -451657)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (32417 - 534197 == -501780)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (58796 - 237790 != -178993)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (177229 - 465019 != -287790)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (288689 - 308354 == -19664)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (212472 - 325618 == -113145)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (253815 - 51742 != 202073)
									{
										continue;
									}
									break;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (122713 - 15962 == 106751)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (111823 - 334450 == -222627)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (202129 - 345590 == -143461)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (48519 - 214375 == -165856)
								{
									if (!changeGui)
									{
										break;
									}
									if (6563 - 53152 != -46588)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (31002 - 491262 != -460260)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (258975 - 238513 != 20462)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (213152 - 359612 != -146459)
										{
											gameGui.close();
											if (175375 - 147249 == 28126)
											{
												changeGui.enabled = true;
												if (59337 - 367329 == -307992)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (197382 - 321656 != -124273)
													{
														if (!gameObject)
														{
															break;
														}
														if (269419 - 139552 == 129867)
														{
															if (!mPlayer)
															{
																break;
															}
															if (203716 - 272259 != -68542)
															{
																Debug.Log("UseLifeAltar");
																if (146163 - 235160 != -88996)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (19630 - 382944 != -363313)
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

	// Token: 0x060080E9 RID: 33001 RVA: 0x010734EC File Offset: 0x010716EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x060080EA RID: 33002 RVA: 0x010734F0 File Offset: 0x010716F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (228668 - 318610 != -89941)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
			if (82440 - 336309 == -253869)
			{
				if (!characterControl)
				{
					break;
				}
				if (266532 - 261701 == 4831)
				{
					if (characterControl.isTransform)
					{
						break;
					}
					if (209506 - 506119 != -296612)
					{
						if (characterControl.isSummon)
						{
							break;
						}
						if (66660 - 415090 == -348430)
						{
							string type = characterControl.Type;
							if (191209 - 327227 == -136018)
							{
								if (type == "Turtle1")
								{
									if (37004 - 560653 == -523649)
									{
										Game.sendMissionEvent(5031, 0);
										if (170603 - 38448 == 132155)
										{
											break;
										}
									}
								}
								else
								{
									if (!(type == "Turtle2"))
									{
										break;
									}
									if (60020 - 13794 != 46227)
									{
										Game.sendMissionEvent(5032, 0);
										if (149620 - 566222 != -416601)
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

	// Token: 0x060080EB RID: 33003 RVA: 0x01073690 File Offset: 0x01071890
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M503_TwoTurtleSages.$onDeadPlayer$39289(this).GetEnumerator();
	}

	// Token: 0x060080EC RID: 33004 RVA: 0x010736A0 File Offset: 0x010718A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (215481 - 416659 != -201178)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (255090 - 249264 != 5827)
			{
				this.Wcdc9ecg0q8.target = Game.mPlayer;
				if (195786 - 48718 == 147068)
				{
					this.Wcdc9ecg0q8.enabled = true;
					if (157601 - 414614 == -257013)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (227269 - 380711 != -153442)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (195593 - 58345 == 137249)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (171795 - 273250 == -101455)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (169381 - 468988 != -299606)
							{
								if (!gameGui)
								{
									break;
								}
								if (49177 - 545179 != -496001)
								{
									gameGui.enabled = true;
									if (225493 - 191536 == 33957)
									{
										gameGui.closeDeadMenu();
										if (116667 - 592902 != -476234)
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

	// Token: 0x060080ED RID: 33005 RVA: 0x0107384C File Offset: 0x01071A4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (229331 - 458945 != -229614)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (276097 - 432403 == -156306)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (134174 - 173581 == -39407)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (150864 - 9972 != 140893)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060080EE RID: 33006 RVA: 0x01073910 File Offset: 0x01071B10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x060080EF RID: 33007 RVA: 0x0107393C File Offset: 0x01071B3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M503_TwoTurtleSages.$onGameComplete$39295(data, this).GetEnumerator();
	}

	// Token: 0x060080F0 RID: 33008 RVA: 0x0107394C File Offset: 0x01071B4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M503_TwoTurtleSages.$ReturnToTown$39303(this).GetEnumerator();
	}

	// Token: 0x060080F1 RID: 33009 RVA: 0x0107395C File Offset: 0x01071B5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M503_TwoTurtleSages.$ReturnToGuild$39308(this).GetEnumerator();
	}

	// Token: 0x060080F2 RID: 33010 RVA: 0x0107396C File Offset: 0x01071B6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M503_TwoTurtleSages.$ReturnToCamp$39312(this).GetEnumerator();
	}

	// Token: 0x060080F3 RID: 33011 RVA: 0x0107397C File Offset: 0x01071B7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (125362 - 491000 != -365638)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (256086 - 297766 != -41679)
			{
				Hashtable hashtable = new Hashtable();
				if (185684 - 267819 != -82134)
				{
					hashtable.Add(43, PlayerData.UID);
					if (158609 - 308530 != -149920)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (72238 - 293067 == -220829)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060080F4 RID: 33012 RVA: 0x01073A54 File Offset: 0x01071C54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x060080F5 RID: 33013 RVA: 0x01073A68 File Offset: 0x01071C68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (271375 - 108450 != 162926)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (223869 - 486158 == -262289)
			{
				Hashtable hashtable = new Hashtable();
				if (13479 - 590783 == -577304)
				{
					if (Game.mNextGameCode == 30)
					{
						if (175223 - 362905 == -187681)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (174496 - 115505 != 58991)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (13438 - 388005 == -374566)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (159985 - 149639 != 10346)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (88702 - 547660 != -458958)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (63948 - 579882 == -515933)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (174626 - 108728 == 65899)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (178933 - 46102 != 132831)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (207943 - 403126 == -195182)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (197482 - 353383 != -155901)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (123886 - 540726 == -416839)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (88231 - 358634 == -270402)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (136125 - 256901 != -120776)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (182174 - 391766 != -209592)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (296028 - 457913 == -161884)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (9572 - 55114 == -45541)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (280105 - 445837 != -165732)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (168487 - 189171 != -20684)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (267536 - 222971 == 44566)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (248921 - 190963 != 57958)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (122687 - 569111 == -446423)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (163189 - 260297 == -97107)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (109681 - 515937 == -406255)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (137703 - 546139 != -408436)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (246619 - 397688 == -151068)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (266033 - 390031 == -123997)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (276197 - 55929 == 220269)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (194612 - 481938 != -287326)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (230419 - 558155 != -327735)
					{
						this.P5Hc9QDymdW.OpCustom(42, hashtable, true);
						if (298589 - 461381 != -162791)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060080F6 RID: 33014 RVA: 0x0107401C File Offset: 0x0107221C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x060080F7 RID: 33015 RVA: 0x0107402C File Offset: 0x0107222C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060080F8 RID: 33016 RVA: 0x01074030 File Offset: 0x01072230
	internal static bool DtH9C3pjksAH252Adc7e()
	{
		return true;
	}

	// Token: 0x060080F9 RID: 33017 RVA: 0x01074034 File Offset: 0x01072234
	internal static bool dmLkuppjGWOkASm02slt()
	{
		return false;
	}

	// Token: 0x04007FBD RID: 32701
	private LitePeer P5Hc9QDymdW;

	// Token: 0x04007FBE RID: 32702
	private PlayerCameraControl Wcdc9ecg0q8;

	// Token: 0x04007FBF RID: 32703
	private float w9Bc9IHGuVL;

	// Token: 0x04007FC0 RID: 32704
	private Texture aRAc9JSpmu6;

	// Token: 0x04007FC1 RID: 32705
	private AudioClip oasc9618LPu;

	// Token: 0x04007FC2 RID: 32706
	private int l3dc9te9JBK;

	// Token: 0x04007FC3 RID: 32707
	private float aCkc9XpMqjP;

	// Token: 0x04007FC4 RID: 32708
	private int lM8c9OvQCAM;

	// Token: 0x04007FC5 RID: 32709
	private int CcNc928GfLj;

	// Token: 0x04007FC6 RID: 32710
	private int Vyjc9vAHmcf;

	// Token: 0x04007FC7 RID: 32711
	public AudioClip battleMusic;

	// Token: 0x04007FC8 RID: 32712
	private int RTVc9l29iQn;

	// Token: 0x020015B5 RID: 5557
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$39258 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060080FA RID: 33018 RVA: 0x01074038 File Offset: 0x01072238
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$39258(M503_TwoTurtleSages self_)
		{
			if (78525 - 395125 != -316600)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (110814 - 31559 != 79256)
				{
					base..ctor();
					if (201367 - 323197 != -121829)
					{
						this.$self_$39264 = self_;
						if (7873 - 17942 != -10068)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060080FB RID: 33019 RVA: 0x010740D0 File Offset: 0x010722D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M503_TwoTurtleSages.$StartGame$39258.$(this.$self_$39264);
		}

		// Token: 0x060080FC RID: 33020 RVA: 0x010740E0 File Offset: 0x010722E0
		internal static bool hs9YjnpjHY0i2b8KNesi()
		{
			return true;
		}

		// Token: 0x060080FD RID: 33021 RVA: 0x010740E4 File Offset: 0x010722E4
		internal static bool o0s8lEpjWUyCFS2942Cs()
		{
			return false;
		}

		// Token: 0x04007FC9 RID: 32713
		internal M503_TwoTurtleSages $self_$39264;

		// Token: 0x020015B6 RID: 5558
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060080FE RID: 33022 RVA: 0x010740E8 File Offset: 0x010722E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M503_TwoTurtleSages self_)
			{
				if (54204 - 462440 != -408236)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (77968 - 234911 == -156943)
					{
						base..ctor();
						if (111723 - 224742 == -113019)
						{
							this.$self_$39263 = self_;
							if (92953 - 382770 == -289817)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060080FF RID: 33023 RVA: 0x01074180 File Offset: 0x01072380
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (111401 - 551912 != -440510)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6B2;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (243381 - 294555 != -51173)
							{
								goto Block_20;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$39259 = (StoryGui)this.$self_$39263.GetComponent(typeof(StoryGui));
							if (240992 - 282395 != -41403)
							{
								continue;
							}
							this.$mStoryGui$39259.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
							if (121997 - 319190 != -197192)
							{
								goto Block_6;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (42623 - 363789 != -321165)
							{
								goto Block_35;
							}
							continue;
						}
						else
						{
							this.$nMessage$39260 = string.Empty;
							if (105786 - 312660 != -206874)
							{
								continue;
							}
							this.$nMessage$39260 = Language.getMessage("M503_TwoTurtleSages", 101);
							if (244946 - 376254 != -131308)
							{
								continue;
							}
							this.$mStoryGui$39259.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$39260, eTalkType.friend);
							if (260742 - 87480 != 173263)
							{
								goto Block_24;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (120735 - 432245 != -311510)
							{
								continue;
							}
							goto IL_1FF;
						}
						else
						{
							this.$nMessage$39260 = Language.getMessage("M503_TwoTurtleSages", 102);
							if (104907 - 16215 == 88693)
							{
								continue;
							}
							this.$mStoryGui$39259.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$39260, eTalkType.friend);
							if (294030 - 323215 != -29185)
							{
								continue;
							}
							goto IL_4B1;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (215484 - 269793 != -54309)
							{
								continue;
							}
							goto IL_2B0;
						}
						else
						{
							this.$mStoryGui$39259.close();
							if (99614 - 546708 != -447094)
							{
								continue;
							}
							goto IL_10C;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (259470 - 302279 != -42808)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							this.$self_$39263.SendMessage("fadeOut");
							if (238165 - 166067 != 72099)
							{
								goto Block_36;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (218065 - 340718 != -122652)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$self_$39263.SendMessage("fadeIn");
							if (145130 - 245429 == -100298)
							{
								continue;
							}
							this.$mGameGui$39261 = (GameGui)this.$self_$39263.GetComponent(typeof(GameGui));
							if (209223 - 22658 == 186566)
							{
								continue;
							}
							this.$mGameGui$39261.enabled = true;
							if (285305 - 28300 != 257005)
							{
								continue;
							}
							this.$self_$39263.Wcdc9ecg0q8.enabled = true;
							if (120946 - 85176 == 35771)
							{
								continue;
							}
							this.$startCamera$39262 = GameObject.Find("StartCamera" + Game.getPlayerSlot(PlayerData.UID));
							if (188676 - 260737 != -72061)
							{
								continue;
							}
							if (this.$startCamera$39262)
							{
								if (179514 - 146340 != 33174)
								{
									continue;
								}
								this.$self_$39263.transform.position = this.$startCamera$39262.transform.position;
								if (31299 - 596014 != -564715)
								{
									continue;
								}
								this.$self_$39263.transform.rotation = this.$startCamera$39262.transform.rotation;
								if (239455 - 286017 == -46561)
								{
									continue;
								}
							}
							Game.mGameState = eGameState.Normal;
							if (149293 - 68461 != 80832)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (241246 - 371888 == -130641)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (109884 - 282362 == -172477)
							{
								continue;
							}
							if (this.$self_$39263.oasc9618LPu)
							{
								if (247597 - 401860 != -154263)
								{
									continue;
								}
								this.$self_$39263.audio.PlayOneShot(this.$self_$39263.oasc9618LPu);
								if (147504 - 550042 == -402537)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (244195 - 211523 != 32672)
							{
								continue;
							}
							goto IL_6B2;
						}
						break;
					default:
						if (229309 - 532287 == -302977)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (18124 - 378409 == -360285)
					{
						Game.mGameState = eGameState.Start;
						if (44925 - 346140 == -301215)
						{
							Game.mGameTime = Time.time;
							if (289975 - 227443 == 62532)
							{
								this.$self_$39263.SendMessage("fadeIn");
								if (101352 - 112666 == -11314)
								{
									goto IL_275;
								}
							}
						}
					}
				}
				Block_6:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_10C:
				return this.Yield(6, new WaitForSeconds(0.5f));
				Block_8:
				Block_12:
				IL_1FF:
				goto IL_6B2;
				IL_275:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_20:
				IL_2B0:
				goto IL_6B2;
				Block_24:
				return this.Yield(4, new WaitForSeconds(2.5f));
				IL_4B1:
				return this.Yield(5, new WaitForSeconds(2.5f));
				Block_35:
				goto IL_6B2;
				Block_36:
				return this.Yield(7, new WaitForSeconds(1f));
				IL_6B2:
				return false;
			}

			// Token: 0x06008100 RID: 33024 RVA: 0x01074854 File Offset: 0x01072A54
			internal static bool UjujfOpjArn1jtD2vBbZ()
			{
				return true;
			}

			// Token: 0x06008101 RID: 33025 RVA: 0x01074858 File Offset: 0x01072A58
			internal static bool w9So8XpjlDGx74EscAGZ()
			{
				return false;
			}

			// Token: 0x04007FCA RID: 32714
			internal StoryGui $mStoryGui$39259;

			// Token: 0x04007FCB RID: 32715
			internal string $nMessage$39260;

			// Token: 0x04007FCC RID: 32716
			internal GameGui $mGameGui$39261;

			// Token: 0x04007FCD RID: 32717
			internal GameObject $startCamera$39262;

			// Token: 0x04007FCE RID: 32718
			internal M503_TwoTurtleSages $self_$39263;
		}
	}

	// Token: 0x020015B7 RID: 5559
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onTalkToTurtle$39265 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008102 RID: 33026 RVA: 0x0107485C File Offset: 0x01072A5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onTalkToTurtle$39265(M503_TwoTurtleSages self_)
		{
			if (132672 - 66907 != 65766)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (292498 - 147099 == 145399)
				{
					base..ctor();
					if (196816 - 349964 != -153147)
					{
						this.$self_$39288 = self_;
						if (165259 - 421139 == -255880)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008103 RID: 33027 RVA: 0x010748F4 File Offset: 0x01072AF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M503_TwoTurtleSages.$onTalkToTurtle$39265.$(this.$self_$39288);
		}

		// Token: 0x06008104 RID: 33028 RVA: 0x01074904 File Offset: 0x01072B04
		internal static bool iCBcdBpjyXqYwZ3Jqyt3()
		{
			return true;
		}

		// Token: 0x06008105 RID: 33029 RVA: 0x01074908 File Offset: 0x01072B08
		internal static bool yrZdSupjS5ObgsT1ek9B()
		{
			return false;
		}

		// Token: 0x04007FCF RID: 32719
		internal M503_TwoTurtleSages $self_$39288;

		// Token: 0x020015B8 RID: 5560
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008106 RID: 33030 RVA: 0x0107490C File Offset: 0x01072B0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M503_TwoTurtleSages self_)
			{
				if (97827 - 539972 != -442145)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (73893 - 437374 == -363481)
					{
						base..ctor();
						if (117323 - 94640 != 22684)
						{
							this.$self_$39287 = self_;
							if (196716 - 110990 != 85727)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008107 RID: 33031 RVA: 0x010749A4 File Offset: 0x01072BA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (33003 - 194436 != -161432)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_C85;
					case 1:
						goto IL_1837;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (105249 - 317658 != -212409)
							{
								continue;
							}
							goto IL_616;
						}
						else
						{
							this.$mSpawnPoint$39268 = GameObject.Find("SpawnPoint" + Game.getPlayerSlot(PlayerData.UID));
							if (120945 - 446627 != -325682)
							{
								continue;
							}
							if (this.$mSpawnPoint$39268)
							{
								if (295347 - 140763 == 154585)
								{
									continue;
								}
								if (Game.mPlayer)
								{
									if (211134 - 272479 != -61345)
									{
										continue;
									}
									Game.mPlayer.transform.position = this.$mSpawnPoint$39268.transform.position;
									if (110603 - 419327 == -308723)
									{
										continue;
									}
									Game.mPlayer.transform.rotation = this.$mSpawnPoint$39268.transform.rotation;
									if (161963 - 510742 != -348779)
									{
										continue;
									}
									Game.mPlayer.SendMessage("PositionEvent");
									if (10804 - 111218 == -100413)
									{
										continue;
									}
								}
							}
							this.$mTurtle1$39269 = GameObject.Find("Turtle1");
							if (186607 - 204635 != -18028)
							{
								continue;
							}
							this.$mTurtle2$39270 = GameObject.Find("Turtle2");
							if (77833 - 139134 != -61301)
							{
								continue;
							}
							this.$mTurtleCam$39271 = GameObject.Find("TurtleCam");
							if (103148 - 157658 == -54509)
							{
								continue;
							}
							if (this.$mTurtleCam$39271)
							{
								if (240685 - 441445 != -200760)
								{
									continue;
								}
								Camera.main.transform.position = this.$mTurtleCam$39271.transform.position;
								if (162113 - 198029 != -35916)
								{
									continue;
								}
								Camera.main.transform.rotation = this.$mTurtleCam$39271.transform.rotation;
								if (278920 - 497511 != -218590)
								{
									goto Block_144;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find TurtleCam");
								if (290919 - 33811 != 257109)
								{
									goto Block_106;
								}
								continue;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (129409 - 348165 != -218756)
							{
								continue;
							}
							goto IL_1758;
						}
						else
						{
							this.$self_$39287.SendMessage("fadeIn");
							if (20779 - 40314 != -19535)
							{
								continue;
							}
							this.$mStoryGui$39267.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
							if (25710 - 521503 != -495793)
							{
								continue;
							}
							goto IL_17FC;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (245489 - 165374 != 80116)
							{
								goto Block_160;
							}
							continue;
						}
						else
						{
							this.$nMessage$39272 = string.Empty;
							if (177790 - 359066 != -181276)
							{
								continue;
							}
							this.$nMessage$39272 = Language.getMessage("M503_TwoTurtleSages", 201);
							if (128914 - 186007 != -57093)
							{
								continue;
							}
							this.$mStoryGui$39267.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$39272, eTalkType.friend);
							if (236917 - 401762 != -164844)
							{
								goto Block_137;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (152588 - 42368 != 110221)
							{
								goto Block_149;
							}
							continue;
						}
						else
						{
							this.$nMessage$39272 = Language.getMessage("M503_TwoTurtleSages", 202);
							if (125545 - 160358 != -34813)
							{
								continue;
							}
							this.$mStoryGui$39267.newStoryMessage("Turtle1", "Guibo", this.$nMessage$39272, eTalkType.friend);
							if (186337 - 589007 != -402670)
							{
								continue;
							}
							this.$mTurtle1Rotation$39273 = this.$mTurtle1$39269.transform.eulerAngles.y;
							if (81423 - 477309 != -395886)
							{
								continue;
							}
							this.$mTurtle2Rotation$39274 = this.$mTurtle2$39270.transform.eulerAngles.y;
							if (244673 - 182944 == 61730)
							{
								continue;
							}
							this.$self_$39287.aCkc9XpMqjP = Time.time;
							if (244358 - 185792 != 58566)
							{
								continue;
							}
							goto IL_1026;
						}
						break;
					case 6:
						goto IL_1026;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (72233 - 233637 != -161403)
							{
								goto Block_135;
							}
							continue;
						}
						else
						{
							this.$nMessage$39272 = Language.getMessage("M503_TwoTurtleSages", 203);
							if (93770 - 262771 != -169001)
							{
								continue;
							}
							this.$mStoryGui$39267.newStoryMessage("Turtle2", "Guili", this.$nMessage$39272, eTalkType.friend);
							if (255803 - 410561 != -154757)
							{
								goto Block_140;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (62929 - 389158 != -326228)
							{
								goto Block_97;
							}
							continue;
						}
						else
						{
							this.$nMessage$39272 = Language.getMessage("M503_TwoTurtleSages", 204);
							if (160330 - 85281 == 75050)
							{
								continue;
							}
							this.$mStoryGui$39267.newStoryMessage("Turtle1", "Guibo", this.$nMessage$39272, eTalkType.friend);
							if (258986 - 490891 != -231905)
							{
								continue;
							}
							this.$self_$39287.aCkc9XpMqjP = Time.time;
							if (183918 - 162153 != 21765)
							{
								continue;
							}
							goto IL_9C;
						}
						break;
					case 9:
						goto IL_9C;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (160261 - 318589 != -158328)
							{
								continue;
							}
							goto IL_21A;
						}
						else
						{
							this.$nMessage$39272 = Language.getMessage("M503_TwoTurtleSages", 205);
							if (162972 - 34135 == 128838)
							{
								continue;
							}
							this.$mStoryGui$39267.newStoryMessage("Turtle2", "Guili", this.$nMessage$39272, eTalkType.friend);
							if (54827 - 101900 != -47073)
							{
								continue;
							}
							this.$self_$39287.aCkc9XpMqjP = Time.time;
							if (253413 - 448580 != -195167)
							{
								continue;
							}
						}
						break;
					case 11:
						break;
					case 12:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (296320 - 103344 != 192977)
							{
								goto Block_139;
							}
							continue;
						}
						else
						{
							this.$nMessage$39272 = Language.getMessage("M503_TwoTurtleSages", 206);
							if (244147 - 481445 == -237297)
							{
								continue;
							}
							this.$mStoryGui$39267.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$39272, eTalkType.friend);
							if (265119 - 309914 != -44794)
							{
								goto Block_120;
							}
							continue;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (195186 - 391897 != -196710)
							{
								goto Block_142;
							}
							continue;
						}
						else
						{
							this.$nMessage$39272 = Language.getMessage("M503_TwoTurtleSages", 207);
							if (130795 - 414450 != -283655)
							{
								continue;
							}
							this.$mStoryGui$39267.newStoryMessage("Turtle1", "Guibo", this.$nMessage$39272, eTalkType.friend);
							if (16198 - 318675 != -302477)
							{
								continue;
							}
							if (this.$mTurtle1$39269)
							{
								if (69346 - 381577 != -312231)
								{
									continue;
								}
								this.$mTurtle1$39269.animation.Play("battleStance1");
								if (144308 - 92880 != 51428)
								{
									continue;
								}
								this.$mTurtle1$39269.animation.wrapMode = WrapMode.Once;
								if (54769 - 263330 != -208561)
								{
									continue;
								}
							}
							this.$self_$39287.aCkc9XpMqjP = Time.time;
							if (175470 - 222329 != -46858)
							{
								goto IL_7A1;
							}
							continue;
						}
						break;
					case 14:
						goto IL_7A1;
					case 15:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (168370 - 65349 != 103021)
							{
								continue;
							}
							goto IL_4E0;
						}
						else
						{
							this.$nMessage$39272 = Language.getMessage("M503_TwoTurtleSages", 208);
							if (150355 - 239971 != -89616)
							{
								continue;
							}
							this.$mStoryGui$39267.newStoryMessage("Turtle2", "Guili", this.$nMessage$39272, eTalkType.friend);
							if (74610 - 495504 == -420893)
							{
								continue;
							}
							if (!this.$mTurtle2$39270)
							{
								goto IL_31E;
							}
							if (178465 - 565720 != -387255)
							{
								continue;
							}
							this.$mTurtle2$39270.animation.Play("battleStance1");
							if (105538 - 339667 == -234128)
							{
								continue;
							}
							this.$mTurtle2$39270.animation.wrapMode = WrapMode.Once;
							if (122459 - 170887 != -48428)
							{
								continue;
							}
							goto IL_31E;
						}
						break;
					case 16:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (250044 - 150612 != 99432)
							{
								continue;
							}
							goto IL_CAA;
						}
						else
						{
							this.$mStoryGui$39267.close();
							if (82390 - 249012 == -166621)
							{
								continue;
							}
							this.$mGameGui$39266.enabled = true;
							if (178771 - 403339 != -224567)
							{
								goto Block_53;
							}
							continue;
						}
						break;
					case 17:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (75621 - 420379 != -344757)
							{
								goto Block_47;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (113877 - 66840 != 47037)
							{
								continue;
							}
							Game.sendMissionEvent(5035, 0);
							if (13022 - 31661 != -18638)
							{
								goto IL_1557;
							}
							continue;
						}
						break;
					default:
						if (26245 - 167715 != -141469)
						{
							goto IL_C85;
						}
						continue;
					}
					if (Time.time >= this.$self_$39287.aCkc9XpMqjP + 0.2f)
					{
						if (26627 - 556842 != -530214)
						{
							goto Block_4;
						}
						continue;
					}
					else
					{
						if (!this.$mTurtle2$39270)
						{
							break;
						}
						if (218011 - 350680 == -132668)
						{
							continue;
						}
						float num = this.$$14328$39281 = Mathf.SmoothStep(this.$mTurtle2Rotation$39274 + (float)180, this.$mTurtle2Rotation$39274 + (float)270, (float)5 * (Time.time - this.$self_$39287.aCkc9XpMqjP));
						if (46964 - 509027 == -462062)
						{
							continue;
						}
						if (221036 - 37300 != 183736)
						{
							continue;
						}
						Vector3 vector = this.$$14329$39282 = this.$mTurtle2$39270.transform.eulerAngles;
						if (77844 - 35887 != 41957)
						{
							continue;
						}
						if (69123 - 43202 == 25922)
						{
							continue;
						}
						float num2 = this.$$14329$39282.y = this.$$14328$39281;
						if (251923 - 33962 == 217962 || 106269 - 154545 == -48275)
						{
							continue;
						}
						Vector3 vector2 = this.$mTurtle2$39270.transform.eulerAngles = this.$$14329$39282;
						if (185994 - 419292 != -233298)
						{
							continue;
						}
						if (271598 - 454477 != -182878)
						{
							break;
						}
						continue;
					}
					IL_9C:
					if (Time.time >= this.$self_$39287.aCkc9XpMqjP + 0.2f)
					{
						if (159598 - 45657 != 113942)
						{
							goto Block_6;
						}
						continue;
					}
					else
					{
						if (!this.$mTurtle1$39269)
						{
							goto IL_8F;
						}
						if (140627 - 245391 == -104763)
						{
							continue;
						}
						float num3 = this.$$14326$39279 = Mathf.SmoothStep(this.$mTurtle1Rotation$39273 + (float)180, this.$mTurtle1Rotation$39273 + (float)90, (float)5 * (Time.time - this.$self_$39287.aCkc9XpMqjP));
						if (262586 - 366793 == -104206 || 175542 - 531781 == -356238)
						{
							continue;
						}
						Vector3 vector3 = this.$$14327$39280 = this.$mTurtle1$39269.transform.eulerAngles;
						if (24455 - 523023 != -498568)
						{
							continue;
						}
						if (160838 - 259669 == -98830)
						{
							continue;
						}
						float num4 = this.$$14327$39280.y = this.$$14326$39279;
						if (285118 - 312644 != -27526)
						{
							continue;
						}
						if (162146 - 40192 != 121954)
						{
							continue;
						}
						Vector3 vector4 = this.$mTurtle1$39269.transform.eulerAngles = this.$$14327$39280;
						if (109197 - 140849 != -31652)
						{
							continue;
						}
						if (287759 - 519531 != -231771)
						{
							goto Block_31;
						}
						continue;
					}
					IL_7A1:
					if (Time.time >= this.$self_$39287.aCkc9XpMqjP + 0.2f)
					{
						if (298595 - 488812 != -190216)
						{
							goto Block_49;
						}
						continue;
					}
					else
					{
						if (this.$mTurtle1$39269)
						{
							if (157096 - 570032 != -412936)
							{
								continue;
							}
							this.$$14330$39283 = Mathf.SmoothStep(this.$mTurtle1Rotation$39273 + (float)90, this.$mTurtle1Rotation$39273 + (float)180, (float)5 * (Time.time - this.$self_$39287.aCkc9XpMqjP));
							if (197607 - 220094 == -22486 || 232186 - 339214 == -107027)
							{
								continue;
							}
							Vector3 vector5 = this.$$14331$39284 = this.$mTurtle1$39269.transform.eulerAngles;
							if (268822 - 106983 != 161839)
							{
								continue;
							}
							if (281513 - 144742 == 136772)
							{
								continue;
							}
							this.$$14331$39284.y = this.$$14330$39283;
							if (79692 - 297119 == -217426 || 247189 - 372016 == -124826)
							{
								continue;
							}
							this.$mTurtle1$39269.transform.eulerAngles = this.$$14331$39284;
							if (41717 - 325238 != -283521)
							{
								continue;
							}
							if (124510 - 307840 != -183330)
							{
								continue;
							}
						}
						if (!this.$mTurtle2$39270)
						{
							goto IL_794;
						}
						if (223944 - 94453 == 129492)
						{
							continue;
						}
						this.$$14332$39285 = Mathf.SmoothStep(this.$mTurtle2Rotation$39274 + (float)270, this.$mTurtle2Rotation$39274 + (float)180, (float)5 * (Time.time - this.$self_$39287.aCkc9XpMqjP));
						if (281181 - 361458 == -80276)
						{
							continue;
						}
						if (154439 - 535928 != -381489)
						{
							continue;
						}
						Vector3 vector6 = this.$$14333$39286 = this.$mTurtle2$39270.transform.eulerAngles;
						if (29934 - 498798 != -468864)
						{
							continue;
						}
						if (24502 - 202143 == -177640)
						{
							continue;
						}
						this.$$14333$39286.y = this.$$14332$39285;
						if (117254 - 125321 == -8066)
						{
							continue;
						}
						if (54899 - 147457 != -92558)
						{
							continue;
						}
						this.$mTurtle2$39270.transform.eulerAngles = this.$$14333$39286;
						if (147708 - 360130 != -212422)
						{
							continue;
						}
						if (178522 - 443821 != -265299)
						{
							continue;
						}
						goto IL_794;
					}
					IL_1026:
					if (Time.time >= this.$self_$39287.aCkc9XpMqjP + 0.4f)
					{
						if (121761 - 54480 != 67282)
						{
							goto Block_110;
						}
						continue;
					}
					else
					{
						if (this.$mTurtle1$39269)
						{
							if (131020 - 360017 == -228996)
							{
								continue;
							}
							float num5 = this.$$14322$39275 = Mathf.SmoothStep(this.$mTurtle1Rotation$39273, this.$mTurtle1Rotation$39273 + (float)180, 2.5f * (Time.time - this.$self_$39287.aCkc9XpMqjP));
							if (45937 - 89692 != -43755)
							{
								continue;
							}
							if (205677 - 44833 == 160845)
							{
								continue;
							}
							this.$$14323$39276 = this.$mTurtle1$39269.transform.eulerAngles;
							if (104368 - 527281 == -422912)
							{
								continue;
							}
							if (208780 - 353471 != -144691)
							{
								continue;
							}
							float num6 = this.$$14323$39276.y = this.$$14322$39275;
							if (187156 - 245197 != -58041)
							{
								continue;
							}
							if (13766 - 121713 == -107946)
							{
								continue;
							}
							this.$mTurtle1$39269.transform.eulerAngles = this.$$14323$39276;
							if (189565 - 189798 != -233)
							{
								continue;
							}
							if (5953 - 442788 == -436834)
							{
								continue;
							}
						}
						if (!this.$mTurtle2$39270)
						{
							goto IL_101A;
						}
						if (248858 - 267319 == -18460)
						{
							continue;
						}
						this.$$14324$39277 = Mathf.SmoothStep(this.$mTurtle2Rotation$39274, this.$mTurtle2Rotation$39274 + (float)180, 2.5f * (Time.time - this.$self_$39287.aCkc9XpMqjP));
						if (213352 - 442574 != -229222)
						{
							continue;
						}
						if (265701 - 95054 != 170647)
						{
							continue;
						}
						this.$$14325$39278 = this.$mTurtle2$39270.transform.eulerAngles;
						if (81692 - 290790 == -209097 || 110974 - 422922 == -311947)
						{
							continue;
						}
						float num7 = this.$$14325$39278.y = this.$$14324$39277;
						if (11017 - 457797 == -446779)
						{
							continue;
						}
						if (209840 - 328233 != -118393)
						{
							continue;
						}
						Vector3 vector7 = this.$mTurtle2$39270.transform.eulerAngles = this.$$14325$39278;
						if (249034 - 537088 != -288054)
						{
							continue;
						}
						if (75027 - 317857 != -242829)
						{
							goto Block_125;
						}
						continue;
					}
					IL_C85:
					if (Game.mGameState != eGameState.Normal)
					{
						if (67323 - 11521 != 55802)
						{
							continue;
						}
						goto IL_D61;
					}
					else
					{
						this.$mGameGui$39266 = (GameGui)this.$self_$39287.GetComponent(typeof(GameGui));
						if (96275 - 568106 == -471830)
						{
							continue;
						}
						this.$mStoryGui$39267 = (StoryGui)this.$self_$39287.GetComponent(typeof(StoryGui));
						if (182895 - 570334 != -387439)
						{
							continue;
						}
						if (this.$mGameGui$39266)
						{
							if (59122 - 145509 == -86386)
							{
								continue;
							}
							if (this.$mStoryGui$39267)
							{
								if (213311 - 71622 == 141690)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (133657 - 562842 != -429185)
								{
									continue;
								}
								this.$mGameGui$39266.close();
								if (56844 - 107774 != -50930)
								{
									continue;
								}
								this.$self_$39287.SendMessage("fadeOut");
								if (118612 - 212140 != -93528)
								{
									continue;
								}
								goto IL_E82;
							}
						}
					}
					IL_1557:
					this.YieldDefault(1);
					if (284707 - 70677 != 214031)
					{
						goto Block_143;
					}
				}
				IL_4D:
				return this.YieldDefault(11);
				Block_4:
				return this.Yield(12, new WaitForSeconds(3f));
				IL_8F:
				return this.YieldDefault(9);
				Block_6:
				return this.Yield(10, new WaitForSeconds(2.8f));
				IL_21A:
				goto IL_1837;
				IL_31E:
				return this.Yield(16, new WaitForSeconds(3f));
				IL_4E0:
				goto IL_1837;
				Block_31:
				goto IL_8F;
				IL_616:
				Block_47:
				goto IL_1837;
				IL_794:
				return this.YieldDefault(14);
				Block_49:
				return this.Yield(15, new WaitForSeconds(2.8f));
				Block_53:
				return this.Yield(17, new WaitForSeconds(1f));
				goto IL_4D;
				IL_CAA:
				IL_D61:
				Block_97:
				goto IL_1837;
				IL_E82:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_106:
				goto IL_17A4;
				IL_101A:
				return this.YieldDefault(6);
				Block_110:
				return this.Yield(7, new WaitForSeconds(2.5f));
				Block_120:
				return this.Yield(13, new WaitForSeconds(2f));
				Block_125:
				goto IL_101A;
				Block_135:
				goto IL_1837;
				Block_137:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_139:
				goto IL_1837;
				Block_140:
				return this.Yield(8, new WaitForSeconds(3f));
				Block_142:
				Block_143:
				goto IL_1837;
				Block_144:
				goto IL_17A4;
				Block_149:
				IL_1758:
				goto IL_1837;
				IL_17A4:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_17FC:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_160:
				IL_1837:
				return false;
			}

			// Token: 0x06008108 RID: 33032 RVA: 0x010761FC File Offset: 0x010743FC
			internal static bool ILS9AjpjoD0H9e0ERjqr()
			{
				return true;
			}

			// Token: 0x06008109 RID: 33033 RVA: 0x01076200 File Offset: 0x01074400
			internal static bool JgCpeKpjE74R9IGhUOQk()
			{
				return false;
			}

			// Token: 0x04007FD0 RID: 32720
			internal GameGui $mGameGui$39266;

			// Token: 0x04007FD1 RID: 32721
			internal StoryGui $mStoryGui$39267;

			// Token: 0x04007FD2 RID: 32722
			internal GameObject $mSpawnPoint$39268;

			// Token: 0x04007FD3 RID: 32723
			internal GameObject $mTurtle1$39269;

			// Token: 0x04007FD4 RID: 32724
			internal GameObject $mTurtle2$39270;

			// Token: 0x04007FD5 RID: 32725
			internal GameObject $mTurtleCam$39271;

			// Token: 0x04007FD6 RID: 32726
			internal string $nMessage$39272;

			// Token: 0x04007FD7 RID: 32727
			internal float $mTurtle1Rotation$39273;

			// Token: 0x04007FD8 RID: 32728
			internal float $mTurtle2Rotation$39274;

			// Token: 0x04007FD9 RID: 32729
			internal float $$14322$39275;

			// Token: 0x04007FDA RID: 32730
			internal Vector3 $$14323$39276;

			// Token: 0x04007FDB RID: 32731
			internal float $$14324$39277;

			// Token: 0x04007FDC RID: 32732
			internal Vector3 $$14325$39278;

			// Token: 0x04007FDD RID: 32733
			internal float $$14326$39279;

			// Token: 0x04007FDE RID: 32734
			internal Vector3 $$14327$39280;

			// Token: 0x04007FDF RID: 32735
			internal float $$14328$39281;

			// Token: 0x04007FE0 RID: 32736
			internal Vector3 $$14329$39282;

			// Token: 0x04007FE1 RID: 32737
			internal float $$14330$39283;

			// Token: 0x04007FE2 RID: 32738
			internal Vector3 $$14331$39284;

			// Token: 0x04007FE3 RID: 32739
			internal float $$14332$39285;

			// Token: 0x04007FE4 RID: 32740
			internal Vector3 $$14333$39286;

			// Token: 0x04007FE5 RID: 32741
			internal M503_TwoTurtleSages $self_$39287;
		}
	}

	// Token: 0x020015B9 RID: 5561
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$39289 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600810A RID: 33034 RVA: 0x01076204 File Offset: 0x01074404
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$39289(M503_TwoTurtleSages self_)
		{
			if (253083 - 147649 != 105434)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (82376 - 90584 == -8208)
				{
					base..ctor();
					if (157285 - 362861 == -205576)
					{
						this.$self_$39294 = self_;
						if (279119 - 496766 == -217647)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600810B RID: 33035 RVA: 0x0107629C File Offset: 0x0107449C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M503_TwoTurtleSages.$onDeadPlayer$39289.$(this.$self_$39294);
		}

		// Token: 0x0600810C RID: 33036 RVA: 0x010762AC File Offset: 0x010744AC
		internal static bool MX0Gospj2b2vhVlI3Uqu()
		{
			return true;
		}

		// Token: 0x0600810D RID: 33037 RVA: 0x010762B0 File Offset: 0x010744B0
		internal static bool f5jV3tpj8uVnjFe0UrNJ()
		{
			return false;
		}

		// Token: 0x04007FE6 RID: 32742
		internal M503_TwoTurtleSages $self_$39294;

		// Token: 0x020015BA RID: 5562
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600810E RID: 33038 RVA: 0x010762B4 File Offset: 0x010744B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M503_TwoTurtleSages self_)
			{
				if (96231 - 443741 != -347510)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (91432 - 567779 != -476346)
					{
						base..ctor();
						if (36846 - 294184 == -257338)
						{
							this.$self_$39293 = self_;
							if (131629 - 538906 == -407277)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600810F RID: 33039 RVA: 0x0107634C File Offset: 0x0107454C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (290105 - 279675 != 10431)
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
							if (73826 - 218295 == -144468)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_2D7;
							}
							if (280397 - 103979 != 176418)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (49294 - 550924 == -501629)
						{
							continue;
						}
						this.$mStoryGui$39290 = (StoryGui)this.$self_$39293.GetComponent(typeof(StoryGui));
						if (129514 - 465470 == -335955)
						{
							continue;
						}
						if (this.$mStoryGui$39290)
						{
							if (167102 - 465998 == -298895)
							{
								continue;
							}
							this.$mStoryGui$39290.close();
							if (223426 - 562693 != -339267)
							{
								continue;
							}
						}
						this.$mChangeGui$39291 = (ChangeGui)this.$self_$39293.GetComponent(typeof(ChangeGui));
						if (72712 - 456517 != -383805)
						{
							continue;
						}
						if (this.$mChangeGui$39291)
						{
							if (122521 - 126093 != -3572)
							{
								continue;
							}
							this.$mChangeGui$39291.close();
							if (214822 - 427938 != -213116)
							{
								continue;
							}
						}
						this.$mGameGui$39292 = (GameGui)this.$self_$39293.GetComponent(typeof(GameGui));
						if (295948 - 486911 != -190963)
						{
							continue;
						}
						if (this.$mGameGui$39292)
						{
							if (237710 - 228285 != 9425)
							{
								continue;
							}
							if (!this.$mGameGui$39292.enabled)
							{
								if (116143 - 257786 == -141642)
								{
									continue;
								}
								this.$mGameGui$39292.enabled = true;
								if (76388 - 594102 == -517713)
								{
									continue;
								}
							}
							this.$mGameGui$39292.openDeadMenu();
							if (98202 - 244760 == -146557)
							{
								continue;
							}
						}
						IL_2D7:
						this.YieldDefault(1);
						if (119274 - 196527 != -77252)
						{
							goto IL_2F9;
						}
						continue;
					default:
						if (282716 - 268054 != 14662)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (132872 - 306807 != -173935);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06008110 RID: 33040 RVA: 0x01076664 File Offset: 0x01074864
			internal static bool YuDxabpjZfpt0DQGEEmt()
			{
				return true;
			}

			// Token: 0x06008111 RID: 33041 RVA: 0x01076668 File Offset: 0x01074868
			internal static bool YJ6bvopjCe4DIx9X37xu()
			{
				return false;
			}

			// Token: 0x04007FE7 RID: 32743
			internal StoryGui $mStoryGui$39290;

			// Token: 0x04007FE8 RID: 32744
			internal ChangeGui $mChangeGui$39291;

			// Token: 0x04007FE9 RID: 32745
			internal GameGui $mGameGui$39292;

			// Token: 0x04007FEA RID: 32746
			internal M503_TwoTurtleSages $self_$39293;
		}
	}

	// Token: 0x020015BB RID: 5563
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$39295 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008112 RID: 33042 RVA: 0x0107666C File Offset: 0x0107486C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$39295(Hashtable data, M503_TwoTurtleSages self_)
		{
			if (29360 - 95407 != -66047)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (226010 - 429796 == -203786)
				{
					base..ctor();
					if (242170 - 547050 != -304879)
					{
						this.$data$39301 = data;
						if (254211 - 75970 != 178242)
						{
							this.$self_$39302 = self_;
							if (58696 - 303459 == -244763)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008113 RID: 33043 RVA: 0x01076728 File Offset: 0x01074928
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M503_TwoTurtleSages.$onGameComplete$39295.$(this.$data$39301, this.$self_$39302);
		}

		// Token: 0x06008114 RID: 33044 RVA: 0x0107673C File Offset: 0x0107493C
		internal static bool mVrpUipjLoT1WU14qPwC()
		{
			return true;
		}

		// Token: 0x06008115 RID: 33045 RVA: 0x01076740 File Offset: 0x01074940
		internal static bool S29i0bpjOtHjwOiCofxF()
		{
			return false;
		}

		// Token: 0x04007FEB RID: 32747
		internal Hashtable $data$39301;

		// Token: 0x04007FEC RID: 32748
		internal M503_TwoTurtleSages $self_$39302;

		// Token: 0x020015BC RID: 5564
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008116 RID: 33046 RVA: 0x01076744 File Offset: 0x01074944
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M503_TwoTurtleSages self_)
			{
				if (164997 - 151564 != 13434)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (27734 - 581456 != -553721)
					{
						base..ctor();
						if (220507 - 599877 == -379370)
						{
							this.$data$39299 = data;
							if (14784 - 537878 == -523094)
							{
								this.$self_$39300 = self_;
								if (52696 - 484815 == -432119)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008117 RID: 33047 RVA: 0x01076800 File Offset: 0x01074A00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (127952 - 587023 != -459070)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_28E;
					case 2:
						this.$mCompleteGui$39297 = (CompleteGui)this.$self_$39300.GetComponent(typeof(CompleteGui));
						if (105918 - 381811 == -275892)
						{
							continue;
						}
						this.$mCompleteGui$39297.Init();
						if (31926 - 192988 != -161062)
						{
							continue;
						}
						this.$mCompleteGui$39297.readData(this.$data$39299);
						if (50008 - 458948 != -408940)
						{
							continue;
						}
						if (this.$result$39296 == 1)
						{
							if (116674 - 103625 == 13050)
							{
								continue;
							}
							this.$mCompleteGui$39297.displayResult(eCompleteType.Success);
							if (267111 - 596620 == -329508)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$39297.displayResult(eCompleteType.Failed);
							if (282109 - 246371 == 35739)
							{
								continue;
							}
						}
						this.$mGameGui$39298 = (GameGui)this.$self_$39300.GetComponent(typeof(GameGui));
						if (67515 - 53246 != 14269)
						{
							continue;
						}
						if (this.$mGameGui$39298)
						{
							if (238613 - 65021 != 173592)
							{
								continue;
							}
							this.$mGameGui$39298.close();
							if (117687 - 154499 != -36812)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (118421 - 253010 != -134589)
						{
							continue;
						}
						goto IL_28E;
					default:
						if (101169 - 166195 == -65025)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (70643 - 485618 != -414974)
						{
							goto Block_15;
						}
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (12264 - 278289 == -266025)
						{
							this.$result$39296 = RuntimeServices.UnboxInt32(this.$data$39299[31]);
							if (79795 - 578872 != -499076)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_15:
				IL_28E:
				return false;
			}

			// Token: 0x06008118 RID: 33048 RVA: 0x01076AB0 File Offset: 0x01074CB0
			internal static bool xBCojYpjmG12Vu3l4c75()
			{
				return true;
			}

			// Token: 0x06008119 RID: 33049 RVA: 0x01076AB4 File Offset: 0x01074CB4
			internal static bool aW4NaDpjFEIaNTSjavZO()
			{
				return false;
			}

			// Token: 0x04007FED RID: 32749
			internal int $result$39296;

			// Token: 0x04007FEE RID: 32750
			internal CompleteGui $mCompleteGui$39297;

			// Token: 0x04007FEF RID: 32751
			internal GameGui $mGameGui$39298;

			// Token: 0x04007FF0 RID: 32752
			internal Hashtable $data$39299;

			// Token: 0x04007FF1 RID: 32753
			internal M503_TwoTurtleSages $self_$39300;
		}
	}

	// Token: 0x020015BD RID: 5565
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$39303 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600811A RID: 33050 RVA: 0x01076AB8 File Offset: 0x01074CB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$39303(M503_TwoTurtleSages self_)
		{
			if (120027 - 29960 != 90068)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (240650 - 472765 == -232115)
				{
					base..ctor();
					if (86562 - 194445 == -107883)
					{
						this.$self_$39307 = self_;
						if (246159 - 271980 != -25820)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600811B RID: 33051 RVA: 0x01076B50 File Offset: 0x01074D50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M503_TwoTurtleSages.$ReturnToTown$39303.$(this.$self_$39307);
		}

		// Token: 0x0600811C RID: 33052 RVA: 0x01076B60 File Offset: 0x01074D60
		internal static bool m7pZ31pjMMs18J9lEx5L()
		{
			return true;
		}

		// Token: 0x0600811D RID: 33053 RVA: 0x01076B64 File Offset: 0x01074D64
		internal static bool xV12Q7pjx7wcgGPPVfjv()
		{
			return false;
		}

		// Token: 0x04007FF2 RID: 32754
		internal M503_TwoTurtleSages $self_$39307;

		// Token: 0x020015BE RID: 5566
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600811E RID: 33054 RVA: 0x01076B68 File Offset: 0x01074D68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M503_TwoTurtleSages self_)
			{
				if (188144 - 63937 != 124207)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (24730 - 494731 == -470001)
					{
						base..ctor();
						if (218323 - 292197 == -73874)
						{
							this.$self_$39306 = self_;
							if (220954 - 250928 != -29973)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600811F RID: 33055 RVA: 0x01076C00 File Offset: 0x01074E00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (163845 - 402381 != -238535)
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
						this.$self_$39306.LeaveGame();
						if (91389 - 342487 != -251098)
						{
							continue;
						}
						this.YieldDefault(1);
						if (18003 - 376450 != -358447)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (290467 - 582124 != -291657)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (165564 - 353944 != -188379)
					{
						Game.mStateTime = Time.time;
						if (239355 - 4255 == 235100)
						{
							this.$$switch$6901$39304 = PlayerData.SaveGuild;
							if (208851 - 304570 == -95719)
							{
								if (this.$$switch$6901$39304 == 1)
								{
									if (19047 - 228121 == -209073)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (258663 - 477736 == -219072)
									{
										continue;
									}
								}
								else if (this.$$switch$6901$39304 == 2)
								{
									if (270151 - 575573 == -305421)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (2633 - 523030 != -520397)
									{
										continue;
									}
								}
								else if (this.$$switch$6901$39304 == 3)
								{
									if (20158 - 549481 != -529323)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (70419 - 421082 == -350662)
									{
										continue;
									}
								}
								else if (this.$$switch$6901$39304 == 4)
								{
									if (128498 - 549825 != -421327)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (279462 - 437221 == -157758)
									{
										continue;
									}
								}
								else if (this.$$switch$6901$39304 == 5)
								{
									if (142434 - 217118 != -74684)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (249868 - 575345 != -325477)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (86075 - 206691 != -120616)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (83544 - 346220 == -262675)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (91344 - 224553 == -133208)
									{
										continue;
									}
								}
								this.$mGameGui$39305 = (GameGui)this.$self_$39306.GetComponent(typeof(GameGui));
								if (158963 - 210319 != -51355)
								{
									if (this.$mGameGui$39305)
									{
										if (16871 - 432305 == -415433)
										{
											continue;
										}
										this.$mGameGui$39305.close();
										if (223026 - 369135 == -146108)
										{
											continue;
										}
									}
									this.$self_$39306.SendMessage("fadeOut");
									if (167185 - 426839 == -259654)
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

			// Token: 0x06008120 RID: 33056 RVA: 0x01076FCC File Offset: 0x010751CC
			internal static bool EDXRgOpjg1pnKR6qk67l()
			{
				return true;
			}

			// Token: 0x06008121 RID: 33057 RVA: 0x01076FD0 File Offset: 0x010751D0
			internal static bool lVsiKhpjfsbVaKRcmjNU()
			{
				return false;
			}

			// Token: 0x04007FF3 RID: 32755
			internal int $$switch$6901$39304;

			// Token: 0x04007FF4 RID: 32756
			internal GameGui $mGameGui$39305;

			// Token: 0x04007FF5 RID: 32757
			internal M503_TwoTurtleSages $self_$39306;
		}
	}

	// Token: 0x020015BF RID: 5567
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$39308 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008122 RID: 33058 RVA: 0x01076FD4 File Offset: 0x010751D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$39308(M503_TwoTurtleSages self_)
		{
			if (273141 - 98277 != 174865)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (52376 - 231830 != -179453)
				{
					base..ctor();
					if (87321 - 548012 != -460690)
					{
						this.$self_$39311 = self_;
						if (145953 - 98471 == 47482)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008123 RID: 33059 RVA: 0x0107706C File Offset: 0x0107526C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M503_TwoTurtleSages.$ReturnToGuild$39308.$(this.$self_$39311);
		}

		// Token: 0x06008124 RID: 33060 RVA: 0x0107707C File Offset: 0x0107527C
		internal static bool UFrNynpjnt0tUWXx8OtN()
		{
			return true;
		}

		// Token: 0x06008125 RID: 33061 RVA: 0x01077080 File Offset: 0x01075280
		internal static bool aVBIFspj65nr0XcqtY2c()
		{
			return false;
		}

		// Token: 0x04007FF6 RID: 32758
		internal M503_TwoTurtleSages $self_$39311;

		// Token: 0x020015C0 RID: 5568
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008126 RID: 33062 RVA: 0x01077084 File Offset: 0x01075284
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M503_TwoTurtleSages self_)
			{
				if (157657 - 59803 != 97854)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (116284 - 383016 == -266732)
					{
						base..ctor();
						if (236248 - 298519 == -62271)
						{
							this.$self_$39310 = self_;
							if (44810 - 86787 == -41977)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008127 RID: 33063 RVA: 0x0107711C File Offset: 0x0107531C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (66705 - 551411 != -484706)
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
						this.$self_$39310.LeaveGame();
						if (33264 - 266526 == -233261)
						{
							continue;
						}
						this.YieldDefault(1);
						if (92450 - 164498 != -72047)
						{
							goto Block_11;
						}
						continue;
					default:
						if (234304 - 370353 == -136048)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (93540 - 29741 != 63800)
					{
						Game.mStateTime = Time.time;
						if (198079 - 272008 == -73929)
						{
							Game.mNextGameCode = 31;
							if (204983 - 146676 == 58307)
							{
								this.$mGameGui$39309 = (GameGui)this.$self_$39310.GetComponent(typeof(GameGui));
								if (236207 - 144573 != 91635)
								{
									if (this.$mGameGui$39309)
									{
										if (124352 - 77529 != 46823)
										{
											continue;
										}
										this.$mGameGui$39309.close();
										if (144177 - 583070 == -438892)
										{
											continue;
										}
									}
									this.$self_$39310.SendMessage("fadeOut");
									if (245469 - 549802 != -304332)
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

			// Token: 0x06008128 RID: 33064 RVA: 0x010772F8 File Offset: 0x010754F8
			internal static bool XW9H3vpjihPnErJR57vX()
			{
				return true;
			}

			// Token: 0x06008129 RID: 33065 RVA: 0x010772FC File Offset: 0x010754FC
			internal static bool EPbsfypjKnMHVxdmLJQx()
			{
				return false;
			}

			// Token: 0x04007FF7 RID: 32759
			internal GameGui $mGameGui$39309;

			// Token: 0x04007FF8 RID: 32760
			internal M503_TwoTurtleSages $self_$39310;
		}
	}

	// Token: 0x020015C1 RID: 5569
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$39312 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600812A RID: 33066 RVA: 0x01077300 File Offset: 0x01075500
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$39312(M503_TwoTurtleSages self_)
		{
			if (11708 - 48978 != -37270)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (23456 - 565451 != -541994)
				{
					base..ctor();
					if (36289 - 102182 == -65893)
					{
						this.$self_$39316 = self_;
						if (270429 - 163331 == 107098)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600812B RID: 33067 RVA: 0x01077398 File Offset: 0x01075598
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M503_TwoTurtleSages.$ReturnToCamp$39312.$(this.$self_$39316);
		}

		// Token: 0x0600812C RID: 33068 RVA: 0x010773A8 File Offset: 0x010755A8
		internal static bool gks7pZpjd5ItP2nErNVv()
		{
			return true;
		}

		// Token: 0x0600812D RID: 33069 RVA: 0x010773AC File Offset: 0x010755AC
		internal static bool Cvy57ypjJgNvVid0VPyx()
		{
			return false;
		}

		// Token: 0x04007FF9 RID: 32761
		internal M503_TwoTurtleSages $self_$39316;

		// Token: 0x020015C2 RID: 5570
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600812E RID: 33070 RVA: 0x010773B0 File Offset: 0x010755B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M503_TwoTurtleSages self_)
			{
				if (34907 - 456179 != -421272)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (281020 - 448978 != -167957)
					{
						base..ctor();
						if (283741 - 269991 != 13751)
						{
							this.$self_$39315 = self_;
							if (264869 - 44216 != 220654)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600812F RID: 33071 RVA: 0x01077448 File Offset: 0x01075648
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (32302 - 120592 != -88289)
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
						this.$self_$39315.LeaveGame();
						if (173374 - 501237 == -327862)
						{
							continue;
						}
						this.YieldDefault(1);
						if (172710 - 346101 != -173390)
						{
							goto Block_11;
						}
						continue;
					default:
						if (6810 - 364274 != -357464)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (166933 - 573736 != -406802)
					{
						Game.mStateTime = Time.time;
						if (95813 - 167131 != -71317)
						{
							this.$$switch$6903$39313 = PlayerData.SaveGuild;
							if (33489 - 208203 == -174714)
							{
								if (this.$$switch$6903$39313 == 1)
								{
									if (114460 - 533963 == -419502)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (105701 - 209370 == -103668)
									{
										continue;
									}
								}
								else if (this.$$switch$6903$39313 == 2)
								{
									if (200321 - 240412 == -40090)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (82335 - 251112 != -168777)
									{
										continue;
									}
								}
								else if (this.$$switch$6903$39313 == 3)
								{
									if (262963 - 417228 != -154265)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (247960 - 57488 != 190472)
									{
										continue;
									}
								}
								else if (this.$$switch$6903$39313 == 4)
								{
									if (222963 - 493856 != -270893)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (103302 - 596899 != -493597)
									{
										continue;
									}
								}
								else if (this.$$switch$6903$39313 == 5)
								{
									if (149916 - 45576 != 104340)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (86399 - 210844 != -124445)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (54982 - 425581 != -370599)
									{
										continue;
									}
								}
								this.$mGameGui$39314 = (GameGui)this.$self_$39315.GetComponent(typeof(GameGui));
								if (287878 - 308108 != -20229)
								{
									if (this.$mGameGui$39314)
									{
										if (295369 - 170204 != 125165)
										{
											continue;
										}
										this.$mGameGui$39314.close();
										if (271420 - 295523 == -24102)
										{
											continue;
										}
									}
									this.$self_$39315.SendMessage("fadeOut");
									if (180303 - 359473 == -179170)
									{
										goto IL_1FE;
									}
								}
							}
						}
					}
				}
				Block_11:
				goto IL_363;
				IL_1FE:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x06008130 RID: 33072 RVA: 0x010777CC File Offset: 0x010759CC
			internal static bool zvn1rjpjDXi3SGYqxXow()
			{
				return true;
			}

			// Token: 0x06008131 RID: 33073 RVA: 0x010777D0 File Offset: 0x010759D0
			internal static bool LBlEklpjvJ1IkOwGBYkQ()
			{
				return false;
			}

			// Token: 0x04007FFA RID: 32762
			internal int $$switch$6903$39313;

			// Token: 0x04007FFB RID: 32763
			internal GameGui $mGameGui$39314;

			// Token: 0x04007FFC RID: 32764
			internal M503_TwoTurtleSages $self_$39315;
		}
	}
}
