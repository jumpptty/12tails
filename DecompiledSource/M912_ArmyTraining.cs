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

// Token: 0x0200190D RID: 6413
[Serializable]
public class M912_ArmyTraining : MonoBehaviour
{
	// Token: 0x06009531 RID: 38193 RVA: 0x011B7F98 File Offset: 0x011B6198
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M912_ArmyTraining()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06009532 RID: 38194 RVA: 0x011B7FA8 File Offset: 0x011B61A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (260263 - 28656 != 231608)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (8606 - 237704 == -229098)
			{
				Game.mGameType = 5;
				if (120003 - 378342 == -258339)
				{
					if (Chat.Initialized)
					{
						if (166803 - 491070 == -324267)
						{
							Chat.ChatDisplay.Clear();
							if (188145 - 360666 != -172520)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (180557 - 217181 != -36623)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009533 RID: 38195 RVA: 0x011B808C File Offset: 0x011B628C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (297192 - 97604 != 199589)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (117633 - 186401 == -68768)
				{
					if (Game.mNextGameCode != 912)
					{
						break;
					}
					if (83668 - 96705 != -13036)
					{
						Game.nextGame();
						if (234793 - 380702 != -145908)
						{
							Game.mGameCode = 912;
							if (169573 - 307391 == -137818)
							{
								Game.mGameType = 5;
								if (285030 - 592949 != -307918)
								{
									Game.mGameTime = Time.time;
									if (131509 - 181906 != -50396)
									{
										Game.mGameScore = 0;
										if (130108 - 511273 != -381164)
										{
											Game.mGameMana = 0;
											if (102564 - 29583 != 72982)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (172783 - 545636 == -372853)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (110300 - 163183 != -52882)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (96536 - 578200 == -481664)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (185154 - 472893 == -287739)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (242270 - 407843 == -165573)
																{
																	this.JN2nnXOZx7i = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (43304 - 31413 != 11892)
																	{
																		this.JN2nnXOZx7i.enabled = false;
																		if (274093 - 254624 == 19469)
																		{
																			this.fpYnntwPMJE = PhotonClient.Connection;
																			if (210376 - 299715 != -89338)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (177902 - 23349 != 154554)
																				{
																					this.InitGame();
																					if (156129 - 246307 != -90177)
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
				if (10244 - 199757 == -189513)
				{
					Game.mGameType = 99;
					if (298771 - 59539 == 239232)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009534 RID: 38196 RVA: 0x011B83B8 File Offset: 0x011B65B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (295401 - 447668 != -152266)
		{
		}
		for (;;)
		{
			if (this.fpYnntwPMJE == null)
			{
				if (35856 - 284863 == -249007)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (49476 - 567330 == -517854)
				{
					if (mGameState == eGameState.Init)
					{
						if (136931 - 366116 == -229185)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (214639 - 26374 != 188266)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (3712 - 566249 != -562536)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (188858 - 576418 == -387560)
						{
							break;
						}
					}
					else
					{
						if (mGameState != eGameState.Start)
						{
							if (119189 - 303956 != -184767)
							{
								continue;
							}
							if (mGameState == eGameState.Normal)
							{
								if (216459 - 280342 != -63883)
								{
									continue;
								}
							}
							else if (mGameState == eGameState.Hold)
							{
								if (241634 - 358883 == -117248)
								{
									continue;
								}
								this.GameEventUpdate();
								if (257015 - 362443 != -105428)
								{
									continue;
								}
								break;
							}
							else if (mGameState == eGameState.AllHold)
							{
								if (90107 - 56900 != 33207)
								{
									continue;
								}
								break;
							}
							else
							{
								if (mGameState != eGameState.Ended)
								{
									break;
								}
								if (52063 - 150035 != -97972)
								{
									continue;
								}
								break;
							}
						}
						if (Game.music != 0)
						{
							if (105262 - 195241 == -89978)
							{
								continue;
							}
							if (!this.audio.isPlaying)
							{
								if (96095 - 345018 != -248923)
								{
									continue;
								}
								this.audio.Play();
								if (49739 - 289790 != -240051)
								{
									continue;
								}
							}
						}
						if (Time.time - Game.mGameTime < (float)2)
						{
							if (145340 - 509260 == -363919)
							{
								continue;
							}
							this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
							if (70111 - 277055 != -206944)
							{
								continue;
							}
						}
						else
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (129694 - 575339 != -445645)
							{
								continue;
							}
						}
						if (Time.time > this.LbVnnOY9wQH)
						{
							if (65308 - 136005 == -70696)
							{
								continue;
							}
							Game.mGameMana++;
							if (174634 - 276149 == -101514)
							{
								continue;
							}
							this.LbVnnOY9wQH = Time.time + (float)12;
							if (288432 - 173041 == 115392)
							{
								continue;
							}
						}
						this.GameEventUpdate();
						if (7810 - 581823 == -574013)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009535 RID: 38197 RVA: 0x011B8768 File Offset: 0x011B6968
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameEventUpdate()
	{
		if (216212 - 512633 != -296420)
		{
		}
		while (this.F4Tnnv45BS1 < 1)
		{
			if (245141 - 252084 != -6942)
			{
				if (Time.time - Game.mGameTime <= (float)360)
				{
					break;
				}
				if (3285 - 195729 != -192443)
				{
					this.F4Tnnv45BS1 = 1;
					if (58408 - 222904 != -164495)
					{
						if (this.wm0nnlJbPtt >= 24)
						{
							if (71540 - 416574 != -345033)
							{
								Game.sendMissionEvent(9122, 1);
								if (87049 - 56038 != 31012)
								{
									break;
								}
							}
						}
						else
						{
							Game.sendMissionEvent(9122, 0);
							if (20507 - 60831 != -40323)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009536 RID: 38198 RVA: 0x011B8890 File Offset: 0x011B6A90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (100191 - 277906 != -177715)
		{
		}
		for (;;)
		{
			if (!this.aM4nn2HXJKY)
			{
				if (65879 - 347072 != -281192)
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
				if (27683 - 343977 != -316293)
				{
					if (Time.time - Game.mStateTime >= (float)2)
					{
						break;
					}
					if (125098 - 303421 == -178323)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (18384 - 234885 != -216500)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (146491 - 568684 != -422192)
							{
								GUI.depth = 1;
								if (181435 - 551279 != -369843)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (195392 - 392188 != -196795)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (166302 - 474943 == -308641)
										{
											Color color = GUI.color;
											if (123561 - 410403 == -286842)
											{
												float num3 = color.a = a;
												if (106501 - 429808 != -323306)
												{
													if (84525 - 74796 == 9729)
													{
														GUI.color = color;
														if (185735 - 490128 == -304393)
														{
															if (71459 - 187677 == -116218)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.aM4nn2HXJKY);
																if (200658 - 155053 != 45606)
																{
																	float a2 = 1f;
																	if (33002 - 236879 == -203877)
																	{
																		Color color2 = GUI.color;
																		if (72197 - 254688 != -182490)
																		{
																			float num4 = color2.a = a2;
																			if (125408 - 325471 == -200063)
																			{
																				if (229611 - 429706 == -200095)
																				{
																					Color color3 = GUI.color = color2;
																					if (256334 - 232865 == 23469)
																					{
																						if (103047 - 236020 != -132972)
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

	// Token: 0x06009537 RID: 38199 RVA: 0x011B8C10 File Offset: 0x011B6E10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (4740 - 138272 != -133531)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (261184 - 318326 == -57142)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (295584 - 91330 != 204255)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (36796 - 131693 != -94896)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (198147 - 313169 == -115022)
						{
							int num4 = num;
							if (233246 - 450743 != -217496)
							{
								if (num4 == 9121)
								{
									if (256899 - 206142 == 50757)
									{
										this.wm0nnlJbPtt++;
										if (287821 - 552008 != -264186)
										{
											this.SendMessage("newGameMessage", "Soldier trained:" + this.wm0nnlJbPtt);
											if (238837 - 530418 != -291580)
											{
												Chat.SubmitChat("none", "Soldier trained:" + this.wm0nnlJbPtt, eChatType.system, eChatMode.system);
												if (143554 - 466558 != -323003)
												{
													if (this.wm0nnlJbPtt < 36)
													{
														if (219921 - 147387 != 72535)
														{
															if (num3 != PlayerData.UID)
															{
																break;
															}
															if (148247 - 341786 != -193538)
															{
																if (UnityEngine.Random.Range(0, 100) < 40)
																{
																	if (91303 - 136945 != -45642)
																	{
																		continue;
																	}
																	this.spawnActor("Leopard", 7, this.wm0nnlJbPtt % 8 + 1);
																	if (273932 - 544190 == -270257)
																	{
																		continue;
																	}
																}
																else
																{
																	this.spawnActor("Panther", 7, this.wm0nnlJbPtt % 8 + 1);
																	if (271727 - 13566 != 258161)
																	{
																		continue;
																	}
																}
																if (this.wm0nnlJbPtt != 24)
																{
																	break;
																}
																if (110271 - 164311 != -54039)
																{
																	this.spawnActor("Alpaca", 7, (this.wm0nnlJbPtt + 4) % 8 + 1);
																	if (204969 - 135695 != 69275)
																	{
																		break;
																	}
																}
															}
														}
													}
													else
													{
														if (this.F4Tnnv45BS1 >= 1)
														{
															break;
														}
														if (266846 - 37316 == 229530)
														{
															this.F4Tnnv45BS1 = 1;
															if (220566 - 570943 != -350376)
															{
																Game.sendMissionEvent(9122, 1);
																if (81294 - 157910 == -76616)
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
								else if (num4 == 9122)
								{
									if (309 - 442995 != -442685)
									{
										break;
									}
								}
								else
								{
									Debug.LogError("Warning unknown returnCode:" + num);
									if (48432 - 124575 != -76142)
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

	// Token: 0x06009538 RID: 38200 RVA: 0x011B8FE4 File Offset: 0x011B71E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M912_ArmyTraining.$StartEvent$42008(this).GetEnumerator();
	}

	// Token: 0x06009539 RID: 38201 RVA: 0x011B8FF4 File Offset: 0x011B71F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (116211 - 408772 != -292560)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (175017 - 375725 != -200707)
			{
				Time.timeScale = 1f;
				if (61763 - 244863 != -183099)
				{
					this.aM4nn2HXJKY = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (32769 - 329948 == -297179)
					{
						Hashtable customOpParameters = new Hashtable();
						if (237509 - 235337 != 2173)
						{
							this.fpYnntwPMJE.OpCustom(52, customOpParameters, true);
							if (83468 - 547632 == -464164)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600953A RID: 38202 RVA: 0x011B90F8 File Offset: 0x011B72F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (52836 - 580285 != -527449)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (162102 - 49400 == 112702)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (84669 - 217086 != -132416)
				{
					Game.mGameState = eGameState.Setup;
					if (88513 - 1684 == 86829)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600953B RID: 38203 RVA: 0x011B919C File Offset: 0x011B739C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (82998 - 63018 != 19980)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (86074 - 349921 != -263846)
			{
				if (num == PlayerData.UID)
				{
					if (269306 - 129651 == 139655)
					{
						this.SetupActors();
						if (78079 - 488800 == -410721)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (58528 - 278692 != -220163)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600953C RID: 38204 RVA: 0x011B926C File Offset: 0x011B746C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (194878 - 569199 != -374321)
		{
		}
		for (;;)
		{
			IL_25A:
			Debug.Log("Creating Actors");
			if (286994 - 29997 != 256998)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (287281 - 127119 != 160163)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (288342 - 112341 != 176002)
						{
							int i = 0;
							if (372 - 366851 == -366479)
							{
								CharacterControl[] array2 = array;
								if (60497 - 435034 == -374537)
								{
									int length = array2.Length;
									if (174294 - 208796 != -34501)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (161355 - 461117 == -299761)
												{
													goto IL_25A;
												}
												string type = array2[i].Type;
												if (7476 - 26252 == -18775)
												{
													goto IL_25A;
												}
												if (type == "Panther")
												{
													if (173602 - 362736 == -189133)
													{
														goto IL_25A;
													}
													this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
													if (209534 - 14835 == 194700)
													{
														goto IL_25A;
													}
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (68285 - 536744 != -468459)
												{
													goto IL_25A;
												}
												this.OkInnG3wHYO++;
												if (240271 - 524014 == -283742)
												{
													goto IL_25A;
												}
											}
											i++;
											if (216282 - 124066 == 92217)
											{
												goto IL_25A;
											}
										}
										if (68158 - 599748 != -531589)
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
						if (39459 - 187892 == -148433)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600953D RID: 38205 RVA: 0x011B9508 File Offset: 0x011B7708
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (35101 - 71721 != -36620)
		{
		}
		for (;;)
		{
			IL_3C:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (268205 - 208713 == 59492)
			{
				int i = 0;
				if (126793 - 290175 == -163382)
				{
					CharacterControl[] array2 = array;
					if (17053 - 577283 != -560229)
					{
						int length = array2.Length;
						if (294364 - 360594 == -66230)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (278328 - 338587 == -60258)
								{
									goto IL_3C;
								}
								i++;
								if (199957 - 170683 != 29274)
								{
									goto IL_3C;
								}
							}
							if (205608 - 36816 != 168793)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600953E RID: 38206 RVA: 0x011B9638 File Offset: 0x011B7838
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (19016 - 542135 != -523119)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (93731 - 333207 != -239475)
			{
				Game.mGameState = eGameState.Ready;
				if (64617 - 390633 != -326015)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (52994 - 13378 != 39617)
					{
						GameObject gameObject = null;
						if (138302 - 365701 == -227399)
						{
							if (45680 - 274552 != -228871)
							{
								if (playerSlot >= 1)
								{
									if (265371 - 69217 != 196154)
									{
										continue;
									}
									if (playerSlot <= 3)
									{
										if (209766 - 475511 == -265744)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (299313 - 180555 != 118758)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (79376 - 556390 == -477014)
								{
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position);
									if (12902 - 397460 == -384558)
									{
										if (spawnPos != Vector3.zero)
										{
											if (122427 - 281091 != -158663)
											{
												this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject.transform.forward);
												if (185611 - 117499 != 68113)
												{
													break;
												}
											}
										}
										else
										{
											this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
											if (282239 - 267284 != 14956)
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

	// Token: 0x0600953F RID: 38207 RVA: 0x011B987C File Offset: 0x011B7A7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		Debug.Log("Start Game");
		this.StartCoroutine_Auto(this.StartEvent());
	}

	// Token: 0x06009540 RID: 38208 RVA: 0x011B9898 File Offset: 0x011B7A98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06009541 RID: 38209 RVA: 0x011B989C File Offset: 0x011B7A9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (61008 - 108612 != -47603)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (207643 - 597357 == -389714)
			{
				if (gameObject)
				{
					if (198829 - 363387 != -164557)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (58044 - 451402 == -393358)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (258924 - 495880 != -236955)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009542 RID: 38210 RVA: 0x011B9998 File Offset: 0x011B7B98
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (219967 - 254578 != -34610)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (36567 - 2134 != 34434)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (127209 - 490648 == -363439)
				{
					hashtable.Add(43, PlayerData.UID);
					if (48049 - 111780 == -63731)
					{
						hashtable.Add(73, nType);
						if (26691 - 140377 != -113685)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (87228 - 247258 == -160030)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (36135 - 111509 != -75373)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (8790 - 428360 == -419570)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (224498 - 437348 != -212849)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (209994 - 372127 != -162132)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (190519 - 302624 == -112105)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (292126 - 467139 != -175012)
													{
														this.fpYnntwPMJE.OpCustom(63, hashtable, true);
														if (70240 - 595065 == -524825)
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

	// Token: 0x06009543 RID: 38211 RVA: 0x011B9C7C File Offset: 0x011B7E7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (181343 - 465414 != -284070)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (188119 - 456689 == -268570)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (70748 - 392392 == -321644)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (275257 - 110197 == 165060)
						{
							if (this.OkInnG3wHYO <= 0)
							{
								break;
							}
							if (275705 - 54777 == 220928)
							{
								this.OkInnG3wHYO--;
								if (275179 - 88407 != 186773)
								{
									if (this.OkInnG3wHYO != 0)
									{
										break;
									}
									if (24553 - 263866 == -239313)
									{
										Game.setGameState(eGameState.Ready);
										if (269661 - 257254 == 12407)
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
						if (120399 - 232829 == -112430)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (41478 - 398362 != -356883)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009544 RID: 38212 RVA: 0x011B9E0C File Offset: 0x011B800C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06009545 RID: 38213 RVA: 0x011B9E20 File Offset: 0x011B8020
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (295718 - 150244 != 145475)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (134723 - 170675 == -35952)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (5242 - 450805 == -445563)
				{
					if (!characterControl)
					{
						break;
					}
					if (226942 - 33631 != 193312)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (146021 - 599645 != -453623)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (195699 - 31080 != 164620)
							{
								string type = characterControl.Type;
								if (173395 - 483219 != -309823)
								{
									if (type == "Panther")
									{
										if (17372 - 98832 == -81460)
										{
											Game.sendMissionEvent(9121, 1);
											if (226144 - 203745 == 22399)
											{
												break;
											}
										}
									}
									else if (type == "Leopard")
									{
										if (141244 - 244977 != -103732)
										{
											Game.sendMissionEvent(9121, 2);
											if (93045 - 32081 != 60965)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "Mouse"))
										{
											if (27684 - 243917 == -216232)
											{
												continue;
											}
											if (!(type == "Warthog"))
											{
												if (182619 - 265240 != -82621)
												{
													continue;
												}
												if (!(type == "Alpaca"))
												{
													if (74524 - 23818 != 50706)
													{
														continue;
													}
													if (!(type == "Crocodile"))
													{
														if (73971 - 451602 == -377630)
														{
															continue;
														}
														if (!(type == "Bear"))
														{
															break;
														}
														if (229491 - 16054 != 213437)
														{
															continue;
														}
													}
												}
											}
										}
										Game.sendMissionEvent(9122, 0);
										if (281271 - 364286 == -83015)
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

	// Token: 0x06009546 RID: 38214 RVA: 0x011BA0E8 File Offset: 0x011B82E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (12347 - 550415 != -538068)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (171481 - 494801 != -323319)
			{
				hashtable.Add(71, CID);
				if (151000 - 426386 == -275386)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (296123 - 394902 == -98779)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (290811 - 330796 != -39984)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (175178 - 94945 == 80233)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (46041 - 190799 == -144758)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (120115 - 37257 != 82859)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (161505 - 43897 != 117609)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (179656 - 369324 != -189667)
											{
												this.fpYnntwPMJE.OpCustom(61, hashtable, true);
												if (276286 - 1734 != 274553)
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

	// Token: 0x06009547 RID: 38215 RVA: 0x011BA374 File Offset: 0x011B8574
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (169324 - 534284 != -364959)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (25048 - 258103 != -233054)
			{
				if (!gameObject)
				{
					break;
				}
				if (44529 - 484876 != -440346)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (297522 - 85707 != 211816)
					{
						playerCameraControl.target = gameObject;
						if (242304 - 91692 == 150612)
						{
							this.StartGame();
							if (103668 - 428507 == -324839)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009548 RID: 38216 RVA: 0x011BA464 File Offset: 0x011B8664
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (69373 - 250005 != -180632)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (160188 - 86939 != 73250)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (180865 - 370858 != -189992)
				{
					gameGui.ResetTeamBar();
					if (3143 - 105578 != -102434)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009549 RID: 38217 RVA: 0x011BA510 File Offset: 0x011B8710
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M912_ArmyTraining.$onDeadPlayer$42013(this).GetEnumerator();
	}

	// Token: 0x0600954A RID: 38218 RVA: 0x011BA520 File Offset: 0x011B8720
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (48501 - 163406 != -114905)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (87213 - 285154 != -197940)
			{
				this.JN2nnXOZx7i.target = Game.mPlayer;
				if (186325 - 324111 == -137786)
				{
					this.JN2nnXOZx7i.enabled = true;
					if (37141 - 289911 == -252770)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (102534 - 459741 != -357207)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (248009 - 293177 == -45167)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (145011 - 437109 == -292098)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (22893 - 361386 != -338492)
							{
								if (!gameGui)
								{
									break;
								}
								if (288015 - 408726 == -120711)
								{
									gameGui.enabled = true;
									if (263282 - 86273 == 177009)
									{
										gameGui.closeDeadMenu();
										if (74716 - 319944 == -245228)
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

	// Token: 0x0600954B RID: 38219 RVA: 0x011BA6CC File Offset: 0x011B88CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (251677 - 81573 != 170104)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (73095 - 580385 == -507290)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (151466 - 154438 == -2972)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (118689 - 542920 == -424231)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600954C RID: 38220 RVA: 0x011BA790 File Offset: 0x011B8990
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600954D RID: 38221 RVA: 0x011BA7BC File Offset: 0x011B89BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (24300 - 148119 != -123818)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (284440 - 12710 != 271731)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (3860 - 128942 == -125082)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (199145 - 565249 != -366103)
					{
						Hashtable hashtable = new Hashtable();
						if (128670 - 436942 == -308272)
						{
							hashtable.Add(43, PlayerData.UID);
							if (15057 - 10867 != 4191)
							{
								hashtable.Add(71, nCID);
								if (266225 - 86928 == 179297)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (198357 - 85699 != 112659)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (214979 - 198 == 214781)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (127405 - 178136 == -50731)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (194080 - 23421 == 170659)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (62461 - 289105 != -226643)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (282999 - 381534 == -98535)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (142464 - 289775 != -147310)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (209206 - 162945 == 46261)
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

	// Token: 0x0600954E RID: 38222 RVA: 0x011BAADC File Offset: 0x011B8CDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M912_ArmyTraining.$onChangePlayer$42019(data, this).GetEnumerator();
	}

	// Token: 0x0600954F RID: 38223 RVA: 0x011BAAEC File Offset: 0x011B8CEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M912_ArmyTraining.$onGameComplete$42026(data, this).GetEnumerator();
	}

	// Token: 0x06009550 RID: 38224 RVA: 0x011BAAFC File Offset: 0x011B8CFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M912_ArmyTraining.$ReturnToTown$42036(this).GetEnumerator();
	}

	// Token: 0x06009551 RID: 38225 RVA: 0x011BAB0C File Offset: 0x011B8D0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M912_ArmyTraining.$ReturnToGuild$42041(this).GetEnumerator();
	}

	// Token: 0x06009552 RID: 38226 RVA: 0x011BAB1C File Offset: 0x011B8D1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M912_ArmyTraining.$ReturnToCamp$42045(this).GetEnumerator();
	}

	// Token: 0x06009553 RID: 38227 RVA: 0x011BAB2C File Offset: 0x011B8D2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (229645 - 117445 != 112201)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (67292 - 179075 != -111782)
			{
				Hashtable hashtable = new Hashtable();
				if (68117 - 227472 == -159355)
				{
					hashtable.Add(43, PlayerData.UID);
					if (164961 - 421711 != -256749)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (183366 - 120518 == 62848)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009554 RID: 38228 RVA: 0x011BAC04 File Offset: 0x011B8E04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06009555 RID: 38229 RVA: 0x011BAC18 File Offset: 0x011B8E18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (250928 - 15845 != 235084)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (65076 - 529378 != -464301)
			{
				Hashtable hashtable = new Hashtable();
				if (127452 - 64467 == 62985)
				{
					if (Game.mNextGameCode == 30)
					{
						if (103385 - 91933 == 11453)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (57879 - 408632 == -350752)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (104614 - 280829 == -176214)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (78612 - 115940 == -37327)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (11488 - 531957 != -520469)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (125606 - 29918 == 95689)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (278533 - 597438 == -318904)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (178676 - 4262 != 174414)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (285288 - 410170 != -124882)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (260242 - 442805 == -182562)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (111312 - 52920 == 58393)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (13131 - 413279 != -400148)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (282132 - 222909 == 59224)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (233318 - 120716 == 112603)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (286821 - 587900 != -301079)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (9295 - 587265 != -577970)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (27147 - 237241 != -210094)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (64856 - 271738 == -206881)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (153030 - 275070 != -122040)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (159361 - 425660 != -266299)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (232347 - 395915 == -163567)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (55581 - 485653 != -430072)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (230807 - 311781 == -80973)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (284489 - 343206 != -58717)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (84607 - 393578 == -308970)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (97162 - 334609 == -237446)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (251117 - 484807 == -233689)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (297412 - 227442 == 69971)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (69015 - 337977 != -268961)
					{
						this.fpYnntwPMJE.OpCustom(42, hashtable, true);
						if (15825 - 43982 == -28157)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009556 RID: 38230 RVA: 0x011BB1CC File Offset: 0x011B93CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06009557 RID: 38231 RVA: 0x011BB1DC File Offset: 0x011B93DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009558 RID: 38232 RVA: 0x011BB1E0 File Offset: 0x011B93E0
	internal static bool yOwDbyVSe85OlKcRbBmy()
	{
		return true;
	}

	// Token: 0x06009559 RID: 38233 RVA: 0x011BB1E4 File Offset: 0x011B93E4
	internal static bool mboAdMVSrnOWyob3Goxt()
	{
		return false;
	}

	// Token: 0x04008B92 RID: 35730
	private LitePeer fpYnntwPMJE;

	// Token: 0x04008B93 RID: 35731
	private PlayerCameraControl JN2nnXOZx7i;

	// Token: 0x04008B94 RID: 35732
	private float LbVnnOY9wQH;

	// Token: 0x04008B95 RID: 35733
	private Texture aM4nn2HXJKY;

	// Token: 0x04008B96 RID: 35734
	private int F4Tnnv45BS1;

	// Token: 0x04008B97 RID: 35735
	private int wm0nnlJbPtt;

	// Token: 0x04008B98 RID: 35736
	private int OkInnG3wHYO;

	// Token: 0x0200190E RID: 6414
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$42008 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600955A RID: 38234 RVA: 0x011BB1E8 File Offset: 0x011B93E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$42008(M912_ArmyTraining self_)
		{
			if (278803 - 331624 != -52820)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (294571 - 213570 != 81002)
				{
					base..ctor();
					if (244173 - 514528 != -270354)
					{
						this.$self_$42012 = self_;
						if (176703 - 383267 != -206563)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600955B RID: 38235 RVA: 0x011BB280 File Offset: 0x011B9480
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M912_ArmyTraining.$StartEvent$42008.$(this.$self_$42012);
		}

		// Token: 0x0600955C RID: 38236 RVA: 0x011BB290 File Offset: 0x011B9490
		internal static bool H0O2TqVSjCuxycwYpSWV()
		{
			return true;
		}

		// Token: 0x0600955D RID: 38237 RVA: 0x011BB294 File Offset: 0x011B9494
		internal static bool UnlnmKVSh7eD5aaa5yiy()
		{
			return false;
		}

		// Token: 0x04008B99 RID: 35737
		internal M912_ArmyTraining $self_$42012;

		// Token: 0x0200190F RID: 6415
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600955E RID: 38238 RVA: 0x011BB298 File Offset: 0x011B9498
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M912_ArmyTraining self_)
			{
				if (68831 - 423342 != -354511)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (294708 - 82224 != 212485)
					{
						base..ctor();
						if (21874 - 129182 == -107308)
						{
							this.$self_$42011 = self_;
							if (118559 - 87265 == 31294)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600955F RID: 38239 RVA: 0x011BB330 File Offset: 0x011B9530
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (64918 - 529639 != -464721)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_522;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (248437 - 585408 != -336970)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42009 = (StoryGui)this.$self_$42011.GetComponent(typeof(StoryGui));
							if (16344 - 76860 != -60516)
							{
								continue;
							}
							if (!this.$mStoryGui$42009)
							{
								goto IL_325;
							}
							if (94721 - 487124 != -392403)
							{
								continue;
							}
							this.$mStoryGui$42009.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
							if (106585 - 401774 != -295189)
							{
								continue;
							}
							goto IL_25D;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (106343 - 373052 != -266709)
							{
								continue;
							}
							goto IL_141;
						}
						else
						{
							this.$mStoryGui$42009.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M912_ArmyTraining", 101), eTalkType.friend);
							if (195811 - 11558 == 184254)
							{
								continue;
							}
							this.$self_$42011.JN2nnXOZx7i.StartCoroutine_Auto(this.$self_$42011.JN2nnXOZx7i.slerpToObject("EventCamera2", (float)2));
							if (93583 - 197835 != -104252)
							{
								continue;
							}
							goto IL_1A;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (81350 - 503582 != -422231)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42009.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M912_ArmyTraining", 102), eTalkType.friend);
							if (128744 - 269257 != -140513)
							{
								continue;
							}
							goto IL_1DD;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (220626 - 126667 != 93960)
							{
								goto Block_15;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42009.close();
							if (229366 - 213231 == 16136)
							{
								continue;
							}
							this.$self_$42011.JN2nnXOZx7i.enabled = true;
							if (214733 - 438737 != -224003)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState == eGameState.Start)
						{
							goto IL_325;
						}
						if (65259 - 251508 != -186248)
						{
							goto Block_6;
						}
						continue;
					case 7:
						Game.mGameState = eGameState.Normal;
						if (266329 - 274837 == -8507)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (186311 - 210028 != -23717)
						{
							continue;
						}
						this.YieldDefault(1);
						if (108251 - 75794 != 32458)
						{
							goto Block_30;
						}
						continue;
					default:
						if (163368 - 340587 != -177219)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Start;
					if (1766 - 472601 != -470835)
					{
						continue;
					}
					Game.mGameTime = Time.time;
					if (53817 - 80559 != -26742)
					{
						continue;
					}
					this.$self_$42011.JN2nnXOZx7i.alignToObject("EventCamera1");
					if (266030 - 402699 != -136669)
					{
						continue;
					}
					this.$self_$42011.SendMessage("fadeIn");
					if (191240 - 209267 != -18026)
					{
						goto Block_31;
					}
					continue;
					IL_325:
					this.$mGameGui$42010 = (GameGui)this.$self_$42011.GetComponent(typeof(GameGui));
					if (231997 - 269488 != -37490)
					{
						this.$mGameGui$42010.enableChargeAttack(false);
						if (241994 - 487259 != -245264)
						{
							this.$mGameGui$42010.enableSkill(false);
							if (288129 - 145510 != 142620)
							{
								this.$mGameGui$42010.enabled = true;
								if (224291 - 444281 == -219990)
								{
									goto IL_55;
								}
							}
						}
					}
				}
				IL_1A:
				return this.Yield(4, new WaitForSeconds(3f));
				Block_3:
				goto IL_522;
				IL_55:
				return this.Yield(7, new WaitForSeconds(0.5f));
				Block_6:
				IL_141:
				goto IL_522;
				IL_1DD:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_15:
				goto IL_522;
				IL_25D:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_25:
				goto IL_522;
				Block_26:
				return this.Yield(6, new WaitForSeconds(0.5f));
				Block_30:
				goto IL_522;
				Block_31:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_522:
				return false;
			}

			// Token: 0x06009560 RID: 38240 RVA: 0x011BB874 File Offset: 0x011B9A74
			internal static bool wXfTn7VSsRl3U7TdmXfm()
			{
				return true;
			}

			// Token: 0x06009561 RID: 38241 RVA: 0x011BB878 File Offset: 0x011B9A78
			internal static bool M4x9kDVS9GXkyv1sm5oV()
			{
				return false;
			}

			// Token: 0x04008B9A RID: 35738
			internal StoryGui $mStoryGui$42009;

			// Token: 0x04008B9B RID: 35739
			internal GameGui $mGameGui$42010;

			// Token: 0x04008B9C RID: 35740
			internal M912_ArmyTraining $self_$42011;
		}
	}

	// Token: 0x02001910 RID: 6416
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$42013 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009562 RID: 38242 RVA: 0x011BB87C File Offset: 0x011B9A7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$42013(M912_ArmyTraining self_)
		{
			if (12533 - 358446 != -345913)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (87754 - 489666 != -401911)
				{
					base..ctor();
					if (163423 - 491504 != -328080)
					{
						this.$self_$42018 = self_;
						if (239894 - 534239 != -294344)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009563 RID: 38243 RVA: 0x011BB914 File Offset: 0x011B9B14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M912_ArmyTraining.$onDeadPlayer$42013.$(this.$self_$42018);
		}

		// Token: 0x06009564 RID: 38244 RVA: 0x011BB924 File Offset: 0x011B9B24
		internal static bool KstJPFVS1UVmKtMmTXUv()
		{
			return true;
		}

		// Token: 0x06009565 RID: 38245 RVA: 0x011BB928 File Offset: 0x011B9B28
		internal static bool Ch5rELVS47UuR6W0NCM8()
		{
			return false;
		}

		// Token: 0x04008B9D RID: 35741
		internal M912_ArmyTraining $self_$42018;

		// Token: 0x02001911 RID: 6417
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009566 RID: 38246 RVA: 0x011BB92C File Offset: 0x011B9B2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M912_ArmyTraining self_)
			{
				if (220424 - 484239 != -263815)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (12502 - 273867 != -261364)
					{
						base..ctor();
						if (288820 - 390296 != -101475)
						{
							this.$self_$42017 = self_;
							if (224881 - 541886 != -317004)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009567 RID: 38247 RVA: 0x011BB9C4 File Offset: 0x011B9BC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (26035 - 69397 != -43362)
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
							goto IL_9E;
						}
						if (35535 - 381130 != -345595)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (125005 - 531913 != -406907)
							{
								goto IL_9E;
							}
							continue;
						}
						IL_7C:
						this.YieldDefault(1);
						if (82386 - 3342 != 79045)
						{
							goto Block_6;
						}
						continue;
						IL_9E:
						Game.mGameState = eGameState.Hold;
						if (199683 - 372321 != -172638)
						{
							continue;
						}
						this.$mStoryGui$42014 = (StoryGui)this.$self_$42017.GetComponent(typeof(StoryGui));
						if (36718 - 359220 != -322502)
						{
							continue;
						}
						if (this.$mStoryGui$42014)
						{
							if (192740 - 44384 != 148356)
							{
								continue;
							}
							this.$mStoryGui$42014.close();
							if (297672 - 367293 != -69621)
							{
								continue;
							}
						}
						this.$mChangeGui$42015 = (ChangeGui)this.$self_$42017.GetComponent(typeof(ChangeGui));
						if (272709 - 27373 != 245336)
						{
							continue;
						}
						if (this.$mChangeGui$42015)
						{
							if (228166 - 356674 == -128507)
							{
								continue;
							}
							this.$mChangeGui$42015.close();
							if (267657 - 438526 != -170869)
							{
								continue;
							}
						}
						this.$mGameGui$42016 = (GameGui)this.$self_$42017.GetComponent(typeof(GameGui));
						if (252007 - 17247 == 234761)
						{
							continue;
						}
						if (!this.$mGameGui$42016)
						{
							goto IL_7C;
						}
						if (23557 - 369259 == -345701)
						{
							continue;
						}
						if (!this.$mGameGui$42016.enabled)
						{
							if (13460 - 480393 == -466932)
							{
								continue;
							}
							this.$mGameGui$42016.enabled = true;
							if (13418 - 531333 == -517914)
							{
								continue;
							}
						}
						this.$mGameGui$42016.openDeadMenu();
						if (212540 - 86285 != 126255)
						{
							continue;
						}
						goto IL_7C;
					default:
						if (293637 - 205918 != 87719)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (101354 - 144054 != -42700);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_6:
				IL_2F9:
				return false;
			}

			// Token: 0x06009568 RID: 38248 RVA: 0x011BBCDC File Offset: 0x011B9EDC
			internal static bool YOYem3VSzRUcvRSYwjFO()
			{
				return true;
			}

			// Token: 0x06009569 RID: 38249 RVA: 0x011BBCE0 File Offset: 0x011B9EE0
			internal static bool fvkn2eVoa7n9WZ5VkHE7()
			{
				return false;
			}

			// Token: 0x04008B9E RID: 35742
			internal StoryGui $mStoryGui$42014;

			// Token: 0x04008B9F RID: 35743
			internal ChangeGui $mChangeGui$42015;

			// Token: 0x04008BA0 RID: 35744
			internal GameGui $mGameGui$42016;

			// Token: 0x04008BA1 RID: 35745
			internal M912_ArmyTraining $self_$42017;
		}
	}

	// Token: 0x02001912 RID: 6418
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$42019 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600956A RID: 38250 RVA: 0x011BBCE4 File Offset: 0x011B9EE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$42019(Hashtable data, M912_ArmyTraining self_)
		{
			if (21864 - 483619 != -461755)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (244364 - 302916 == -58552)
				{
					base..ctor();
					if (73165 - 518013 == -444848)
					{
						this.$data$42024 = data;
						if (116777 - 90706 == 26071)
						{
							this.$self_$42025 = self_;
							if (288847 - 376694 == -87847)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600956B RID: 38251 RVA: 0x011BBDA0 File Offset: 0x011B9FA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M912_ArmyTraining.$onChangePlayer$42019.$(this.$data$42024, this.$self_$42025);
		}

		// Token: 0x0600956C RID: 38252 RVA: 0x011BBDB4 File Offset: 0x011B9FB4
		internal static bool lIpWsVVo58JyumnKl8L1()
		{
			return true;
		}

		// Token: 0x0600956D RID: 38253 RVA: 0x011BBDB8 File Offset: 0x011B9FB8
		internal static bool xvS3HjVopZHy1bd4K4Ap()
		{
			return false;
		}

		// Token: 0x04008BA2 RID: 35746
		internal Hashtable $data$42024;

		// Token: 0x04008BA3 RID: 35747
		internal M912_ArmyTraining $self_$42025;

		// Token: 0x02001913 RID: 6419
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600956E RID: 38254 RVA: 0x011BBDBC File Offset: 0x011B9FBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M912_ArmyTraining self_)
			{
				if (121359 - 130861 != -9501)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (293891 - 541558 == -247667)
					{
						base..ctor();
						if (296399 - 177424 != 118976)
						{
							this.$data$42022 = data;
							if (246497 - 155596 != 90902)
							{
								this.$self_$42023 = self_;
								if (80461 - 200831 == -120370)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600956F RID: 38255 RVA: 0x011BBE78 File Offset: 0x011BA078
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (21273 - 431264 != -409990)
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
							if (148154 - 596089 == -447934)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (16702 - 54737 != -38035)
							{
								continue;
							}
							this.$mGameGui$42021 = (GameGui)this.$self_$42023.GetComponent(typeof(GameGui));
							if (92417 - 163242 == -70824)
							{
								continue;
							}
							this.$mGameGui$42021.enabled = true;
							if (182391 - 121088 != 61303)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (69415 - 449547 != -380131)
						{
							goto Block_5;
						}
						continue;
					default:
						if (114610 - 168775 != -54165)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (270508 - 558183 == -287675)
					{
						this.$self_$42023.SendMessage("onCreatePlayer", this.$data$42022);
						if (8505 - 173775 == -165270)
						{
							this.$mChangeGui$42020 = (ChangeGui)this.$self_$42023.GetComponent(typeof(ChangeGui));
							if (297329 - 551683 == -254354)
							{
								if (!this.$mChangeGui$42020.enabled)
								{
									goto IL_1CA;
								}
								if (23244 - 100447 == -77203)
								{
									this.$mChangeGui$42020.close();
									if (83756 - 586777 == -503021)
									{
										goto IL_1CA;
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_205;
				IL_1CA:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x06009570 RID: 38256 RVA: 0x011BC09C File Offset: 0x011BA29C
			internal static bool NKlqpdVoV2jPaU3SMLIo()
			{
				return true;
			}

			// Token: 0x06009571 RID: 38257 RVA: 0x011BC0A0 File Offset: 0x011BA2A0
			internal static bool RxkJvYVotTP4kJ4Qgn0n()
			{
				return false;
			}

			// Token: 0x04008BA4 RID: 35748
			internal ChangeGui $mChangeGui$42020;

			// Token: 0x04008BA5 RID: 35749
			internal GameGui $mGameGui$42021;

			// Token: 0x04008BA6 RID: 35750
			internal Hashtable $data$42022;

			// Token: 0x04008BA7 RID: 35751
			internal M912_ArmyTraining $self_$42023;
		}
	}

	// Token: 0x02001914 RID: 6420
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$42026 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009572 RID: 38258 RVA: 0x011BC0A4 File Offset: 0x011BA2A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$42026(Hashtable data, M912_ArmyTraining self_)
		{
			if (163450 - 350598 != -187147)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (94284 - 21730 != 72555)
				{
					base..ctor();
					if (192656 - 192237 != 420)
					{
						this.$data$42034 = data;
						if (175231 - 11833 != 163399)
						{
							this.$self_$42035 = self_;
							if (68198 - 342095 != -273896)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009573 RID: 38259 RVA: 0x011BC160 File Offset: 0x011BA360
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M912_ArmyTraining.$onGameComplete$42026.$(this.$data$42034, this.$self_$42035);
		}

		// Token: 0x06009574 RID: 38260 RVA: 0x011BC174 File Offset: 0x011BA374
		internal static bool qruiKeVoN5sAQ56WK7nf()
		{
			return true;
		}

		// Token: 0x06009575 RID: 38261 RVA: 0x011BC178 File Offset: 0x011BA378
		internal static bool JQj8tfVoYhGf8IJj1wBU()
		{
			return false;
		}

		// Token: 0x04008BA8 RID: 35752
		internal Hashtable $data$42034;

		// Token: 0x04008BA9 RID: 35753
		internal M912_ArmyTraining $self_$42035;

		// Token: 0x02001915 RID: 6421
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009576 RID: 38262 RVA: 0x011BC17C File Offset: 0x011BA37C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M912_ArmyTraining self_)
			{
				if (239170 - 544608 != -305438)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (246134 - 380435 == -134301)
					{
						base..ctor();
						if (253908 - 179089 == 74819)
						{
							this.$data$42032 = data;
							if (268513 - 238459 != 30055)
							{
								this.$self_$42033 = self_;
								if (134014 - 357531 != -223516)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009577 RID: 38263 RVA: 0x011BC238 File Offset: 0x011BA438
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (27420 - 33246 != -5825)
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
						this.$mCompleteGui$42028 = (CompleteGui)this.$self_$42033.GetComponent(typeof(CompleteGui));
						if (276936 - 334845 == -57908)
						{
							continue;
						}
						this.$mCompleteGui$42028.Init();
						if (56150 - 183148 == -126997)
						{
							continue;
						}
						this.$mCompleteGui$42028.readData(this.$data$42032);
						if (10501 - 273569 == -263067)
						{
							continue;
						}
						if (this.$result$42027 == 1)
						{
							if (102368 - 562089 == -459720)
							{
								continue;
							}
							this.$mCompleteGui$42028.displayResult(eCompleteType.Success);
							if (120523 - 534710 == -414186)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$42028.displayResult(eCompleteType.Failed);
							if (92133 - 556197 != -464064)
							{
								continue;
							}
						}
						this.$mGameGui$42029 = (GameGui)this.$self_$42033.GetComponent(typeof(GameGui));
						if (143899 - 456086 == -312186)
						{
							continue;
						}
						this.$mStoryGui$42030 = (StoryGui)this.$self_$42033.GetComponent(typeof(StoryGui));
						if (284000 - 494258 == -210257)
						{
							continue;
						}
						this.$mChangeGui$42031 = (ChangeGui)this.$self_$42033.GetComponent(typeof(ChangeGui));
						if (220752 - 321323 != -100571)
						{
							continue;
						}
						if (this.$mGameGui$42029)
						{
							if (8140 - 438526 == -430385)
							{
								continue;
							}
							this.$mGameGui$42029.close();
							if (20405 - 312660 != -292255)
							{
								continue;
							}
						}
						if (this.$mStoryGui$42030)
						{
							if (283365 - 405749 != -122384)
							{
								continue;
							}
							this.$mStoryGui$42030.close();
							if (178086 - 52876 == 125211)
							{
								continue;
							}
						}
						if (this.$mChangeGui$42031)
						{
							if (107616 - 266524 == -158907)
							{
								continue;
							}
							this.$mChangeGui$42031.disable();
							if (5846 - 579849 == -574002)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (131608 - 366624 != -235015)
						{
							goto Block_8;
						}
						continue;
					default:
						if (59694 - 47243 == 12452)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$42032[31]);
					if (248763 - 229822 != 18942)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (139009 - 363572 != -224562)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (173319 - 69247 == 104072)
							{
								this.$result$42027 = RuntimeServices.UnboxInt32(this.$data$42032[31]);
								if (175483 - 122974 != 52510)
								{
									goto Block_28;
								}
							}
						}
					}
				}
				Block_8:
				goto IL_3DB;
				Block_28:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x06009578 RID: 38264 RVA: 0x011BC634 File Offset: 0x011BA834
			internal static bool fZqxtBVoc4KLHfIYoneO()
			{
				return true;
			}

			// Token: 0x06009579 RID: 38265 RVA: 0x011BC638 File Offset: 0x011BA838
			internal static bool K1G7UDVoULKxwwwDCocL()
			{
				return false;
			}

			// Token: 0x04008BAA RID: 35754
			internal int $result$42027;

			// Token: 0x04008BAB RID: 35755
			internal CompleteGui $mCompleteGui$42028;

			// Token: 0x04008BAC RID: 35756
			internal GameGui $mGameGui$42029;

			// Token: 0x04008BAD RID: 35757
			internal StoryGui $mStoryGui$42030;

			// Token: 0x04008BAE RID: 35758
			internal ChangeGui $mChangeGui$42031;

			// Token: 0x04008BAF RID: 35759
			internal Hashtable $data$42032;

			// Token: 0x04008BB0 RID: 35760
			internal M912_ArmyTraining $self_$42033;
		}
	}

	// Token: 0x02001916 RID: 6422
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$42036 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600957A RID: 38266 RVA: 0x011BC63C File Offset: 0x011BA83C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$42036(M912_ArmyTraining self_)
		{
			if (103302 - 380372 != -277070)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (115311 - 29371 != 85941)
				{
					base..ctor();
					if (83683 - 47684 == 35999)
					{
						this.$self_$42040 = self_;
						if (278592 - 553722 != -275129)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600957B RID: 38267 RVA: 0x011BC6D4 File Offset: 0x011BA8D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M912_ArmyTraining.$ReturnToTown$42036.$(this.$self_$42040);
		}

		// Token: 0x0600957C RID: 38268 RVA: 0x011BC6E4 File Offset: 0x011BA8E4
		internal static bool aX3eFJVoTUtlUtsRKusj()
		{
			return true;
		}

		// Token: 0x0600957D RID: 38269 RVA: 0x011BC6E8 File Offset: 0x011BA8E8
		internal static bool TP1DWOVo31ChroCDjpZq()
		{
			return false;
		}

		// Token: 0x04008BB1 RID: 35761
		internal M912_ArmyTraining $self_$42040;

		// Token: 0x02001917 RID: 6423
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600957E RID: 38270 RVA: 0x011BC6EC File Offset: 0x011BA8EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M912_ArmyTraining self_)
			{
				if (36502 - 38934 != -2432)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (2175 - 115263 == -113088)
					{
						base..ctor();
						if (47945 - 565795 == -517850)
						{
							this.$self_$42039 = self_;
							if (119386 - 7697 == 111689)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600957F RID: 38271 RVA: 0x011BC784 File Offset: 0x011BA984
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (153044 - 414004 != -260959)
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
						this.$self_$42039.LeaveGame();
						if (51540 - 358689 == -307148)
						{
							continue;
						}
						this.YieldDefault(1);
						if (175149 - 234986 != -59836)
						{
							goto Block_30;
						}
						continue;
					default:
						if (139402 - 144795 == -5392)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (28566 - 471273 == -442707)
					{
						Game.mStateTime = Time.time;
						if (173551 - 334730 == -161179)
						{
							this.$$switch$7588$42037 = PlayerData.SaveGuild;
							if (281640 - 380711 == -99071)
							{
								if (this.$$switch$7588$42037 == 1)
								{
									if (207791 - 550024 != -342233)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (114799 - 199917 == -85117)
									{
										continue;
									}
								}
								else if (this.$$switch$7588$42037 == 2)
								{
									if (212854 - 241878 != -29024)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (207161 - 42823 == 164339)
									{
										continue;
									}
								}
								else if (this.$$switch$7588$42037 == 3)
								{
									if (6235 - 331757 != -325522)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (195046 - 120433 != 74613)
									{
										continue;
									}
								}
								else if (this.$$switch$7588$42037 == 4)
								{
									if (188491 - 306974 != -118483)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (206860 - 494178 != -287318)
									{
										continue;
									}
								}
								else if (this.$$switch$7588$42037 == 5)
								{
									if (59795 - 394302 != -334507)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (15766 - 23538 != -7772)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (79744 - 550096 == -470351)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (13846 - 106959 != -93113)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (68759 - 428575 == -359815)
									{
										continue;
									}
								}
								this.$mGameGui$42038 = (GameGui)this.$self_$42039.GetComponent(typeof(GameGui));
								if (43184 - 286828 == -243644)
								{
									if (this.$mGameGui$42038)
									{
										if (22459 - 581278 == -558818)
										{
											continue;
										}
										this.$mGameGui$42038.close();
										if (136382 - 126243 != 10139)
										{
											continue;
										}
									}
									this.$self_$42039.SendMessage("fadeOut");
									if (214163 - 474126 == -259963)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_30:
				IL_3AD:
				return false;
			}

			// Token: 0x06009580 RID: 38272 RVA: 0x011BCB50 File Offset: 0x011BAD50
			internal static bool Si77kZVoXOYT7qWhXyFu()
			{
				return true;
			}

			// Token: 0x06009581 RID: 38273 RVA: 0x011BCB54 File Offset: 0x011BAD54
			internal static bool p9ZtvAVoQOJxJUOxKwW1()
			{
				return false;
			}

			// Token: 0x04008BB2 RID: 35762
			internal int $$switch$7588$42037;

			// Token: 0x04008BB3 RID: 35763
			internal GameGui $mGameGui$42038;

			// Token: 0x04008BB4 RID: 35764
			internal M912_ArmyTraining $self_$42039;
		}
	}

	// Token: 0x02001918 RID: 6424
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$42041 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009582 RID: 38274 RVA: 0x011BCB58 File Offset: 0x011BAD58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$42041(M912_ArmyTraining self_)
		{
			if (210487 - 413800 != -203312)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (230258 - 363717 == -133459)
				{
					base..ctor();
					if (261559 - 598387 != -336827)
					{
						this.$self_$42044 = self_;
						if (248288 - 373005 != -124716)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009583 RID: 38275 RVA: 0x011BCBF0 File Offset: 0x011BADF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M912_ArmyTraining.$ReturnToGuild$42041.$(this.$self_$42044);
		}

		// Token: 0x06009584 RID: 38276 RVA: 0x011BCC00 File Offset: 0x011BAE00
		internal static bool DcHa9XVokI1aKKXJUhUM()
		{
			return true;
		}

		// Token: 0x06009585 RID: 38277 RVA: 0x011BCC04 File Offset: 0x011BAE04
		internal static bool sMBuBfVoGsUwUj3eXoR0()
		{
			return false;
		}

		// Token: 0x04008BB5 RID: 35765
		internal M912_ArmyTraining $self_$42044;

		// Token: 0x02001919 RID: 6425
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009586 RID: 38278 RVA: 0x011BCC08 File Offset: 0x011BAE08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M912_ArmyTraining self_)
			{
				if (34373 - 218972 != -184599)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (196973 - 66406 != 130568)
					{
						base..ctor();
						if (209095 - 414469 != -205373)
						{
							this.$self_$42043 = self_;
							if (165986 - 193579 != -27592)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009587 RID: 38279 RVA: 0x011BCCA0 File Offset: 0x011BAEA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (218451 - 77481 != 140970)
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
						this.$self_$42043.LeaveGame();
						if (202852 - 5345 == 197508)
						{
							continue;
						}
						this.YieldDefault(1);
						if (135176 - 40562 != 94615)
						{
							goto IL_1BD;
						}
						continue;
					default:
						if (228053 - 124972 != 103081)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (153988 - 360139 != -206150)
					{
						Game.mStateTime = Time.time;
						if (261155 - 241540 != 19616)
						{
							Game.mNextGameCode = 31;
							if (116582 - 255962 == -139380)
							{
								this.$mGameGui$42042 = (GameGui)this.$self_$42043.GetComponent(typeof(GameGui));
								if (118385 - 506397 != -388011)
								{
									if (this.$mGameGui$42042)
									{
										if (131117 - 91300 == 39818)
										{
											continue;
										}
										this.$mGameGui$42042.close();
										if (95567 - 95328 == 240)
										{
											continue;
										}
									}
									this.$self_$42043.SendMessage("fadeOut");
									if (102974 - 261116 == -158142)
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

			// Token: 0x06009588 RID: 38280 RVA: 0x011BCE7C File Offset: 0x011BB07C
			internal static bool Ev94ApVoHTydWsQpi2TF()
			{
				return true;
			}

			// Token: 0x06009589 RID: 38281 RVA: 0x011BCE80 File Offset: 0x011BB080
			internal static bool YlGEREVoWWqsbf1TutyQ()
			{
				return false;
			}

			// Token: 0x04008BB6 RID: 35766
			internal GameGui $mGameGui$42042;

			// Token: 0x04008BB7 RID: 35767
			internal M912_ArmyTraining $self_$42043;
		}
	}

	// Token: 0x0200191A RID: 6426
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$42045 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600958A RID: 38282 RVA: 0x011BCE84 File Offset: 0x011BB084
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$42045(M912_ArmyTraining self_)
		{
			if (124187 - 492224 != -368036)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (224083 - 72162 != 151922)
				{
					base..ctor();
					if (205938 - 411238 == -205300)
					{
						this.$self_$42049 = self_;
						if (156428 - 572549 == -416121)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600958B RID: 38283 RVA: 0x011BCF1C File Offset: 0x011BB11C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M912_ArmyTraining.$ReturnToCamp$42045.$(this.$self_$42049);
		}

		// Token: 0x0600958C RID: 38284 RVA: 0x011BCF2C File Offset: 0x011BB12C
		internal static bool FNnoBVVoAWa9uAZTu42j()
		{
			return true;
		}

		// Token: 0x0600958D RID: 38285 RVA: 0x011BCF30 File Offset: 0x011BB130
		internal static bool ckx0GdVolvPii1lppDko()
		{
			return false;
		}

		// Token: 0x04008BB8 RID: 35768
		internal M912_ArmyTraining $self_$42049;

		// Token: 0x0200191B RID: 6427
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600958E RID: 38286 RVA: 0x011BCF34 File Offset: 0x011BB134
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M912_ArmyTraining self_)
			{
				if (223057 - 406002 != -182944)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (292799 - 589224 == -296425)
					{
						base..ctor();
						if (238127 - 552253 == -314126)
						{
							this.$self_$42048 = self_;
							if (263217 - 424593 != -161375)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600958F RID: 38287 RVA: 0x011BCFCC File Offset: 0x011BB1CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (21911 - 545039 != -523127)
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
						this.$self_$42048.LeaveGame();
						if (127458 - 534598 != -407140)
						{
							continue;
						}
						this.YieldDefault(1);
						if (177382 - 540581 != -363198)
						{
							goto Block_7;
						}
						continue;
					default:
						if (246352 - 200313 == 46040)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (137625 - 231495 == -93870)
					{
						Game.mStateTime = Time.time;
						if (66126 - 472818 == -406692)
						{
							this.$$switch$7590$42046 = PlayerData.SaveGuild;
							if (143434 - 111915 == 31519)
							{
								if (this.$$switch$7590$42046 == 1)
								{
									if (43392 - 267949 == -224556)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (61041 - 101133 == -40091)
									{
										continue;
									}
								}
								else if (this.$$switch$7590$42046 == 2)
								{
									if (42654 - 386321 != -343667)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (18678 - 63181 != -44503)
									{
										continue;
									}
								}
								else if (this.$$switch$7590$42046 == 3)
								{
									if (243389 - 157056 == 86334)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (223590 - 582221 != -358631)
									{
										continue;
									}
								}
								else if (this.$$switch$7590$42046 == 4)
								{
									if (183117 - 157899 != 25218)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (260824 - 204445 != 56379)
									{
										continue;
									}
								}
								else if (this.$$switch$7590$42046 == 5)
								{
									if (248836 - 313786 != -64950)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (103419 - 125793 == -22373)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (264333 - 431984 != -167651)
									{
										continue;
									}
								}
								this.$mGameGui$42047 = (GameGui)this.$self_$42048.GetComponent(typeof(GameGui));
								if (3939 - 225444 == -221505)
								{
									if (this.$mGameGui$42047)
									{
										if (52201 - 477297 == -425095)
										{
											continue;
										}
										this.$mGameGui$42047.close();
										if (288103 - 312976 == -24872)
										{
											continue;
										}
									}
									this.$self_$42048.SendMessage("fadeOut");
									if (11499 - 126199 != -114699)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_7:
				IL_363:
				return false;
			}

			// Token: 0x06009590 RID: 38288 RVA: 0x011BD350 File Offset: 0x011BB550
			internal static bool qPtAckVoyAO3IIxuSmHY()
			{
				return true;
			}

			// Token: 0x06009591 RID: 38289 RVA: 0x011BD354 File Offset: 0x011BB554
			internal static bool vfNVmvVoSKVf0dMiyIFI()
			{
				return false;
			}

			// Token: 0x04008BB9 RID: 35769
			internal int $$switch$7590$42046;

			// Token: 0x04008BBA RID: 35770
			internal GameGui $mGameGui$42047;

			// Token: 0x04008BBB RID: 35771
			internal M912_ArmyTraining $self_$42048;
		}
	}
}
