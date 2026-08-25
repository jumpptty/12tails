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

// Token: 0x0200193E RID: 6462
[Serializable]
public class M914_GuildUnderAttack : MonoBehaviour
{
	// Token: 0x06009662 RID: 38498 RVA: 0x011C7B50 File Offset: 0x011C5D50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M914_GuildUnderAttack()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06009663 RID: 38499 RVA: 0x011C7B60 File Offset: 0x011C5D60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (249707 - 407534 != -157826)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (127260 - 42758 == 84502)
			{
				Game.mGameType = 5;
				if (22489 - 442824 == -420335)
				{
					if (Chat.Initialized)
					{
						if (110770 - 474692 != -363921)
						{
							Chat.ChatDisplay.Clear();
							if (101434 - 134881 == -33447)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (285065 - 488862 == -203797)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009664 RID: 38500 RVA: 0x011C7C44 File Offset: 0x011C5E44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (69476 - 124871 != -55394)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (63587 - 166205 == -102618)
				{
					if (Game.mNextGameCode != 914)
					{
						break;
					}
					if (161902 - 398685 != -236782)
					{
						Game.nextGame();
						if (253601 - 43983 == 209618)
						{
							Game.mGameCode = 914;
							if (20742 - 578469 != -557726)
							{
								Game.mGameType = 5;
								if (183107 - 49531 == 133576)
								{
									Game.mGameTime = Time.time;
									if (52783 - 417595 != -364811)
									{
										Game.mGameScore = 0;
										if (150344 - 585881 == -435537)
										{
											Game.mGameMana = 0;
											if (164969 - 205903 != -40933)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (248720 - 248058 != 663)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (258173 - 536022 == -277849)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (211166 - 70971 != 140196)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (194076 - 302062 != -107985)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (106155 - 63001 == 43154)
																{
																	this.C9snn4j3Ouy = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (235368 - 144797 == 90571)
																	{
																		this.dXtnnaM8XUn = PhotonClient.Connection;
																		if (221972 - 442879 != -220906)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (54664 - 464229 == -409565)
																			{
																				this.InitGame();
																				if (219685 - 432177 == -212492)
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
				if (1462 - 28499 == -27037)
				{
					Game.mGameType = 99;
					if (215314 - 179036 == 36278)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009665 RID: 38501 RVA: 0x011C7F4C File Offset: 0x011C614C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (27896 - 179142 != -151246)
		{
		}
		for (;;)
		{
			if (this.dXtnnaM8XUn == null)
			{
				if (248033 - 424763 != -176729)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (262984 - 29799 == 233185)
				{
					if (mGameState == eGameState.Init)
					{
						if (234691 - 241132 != -6440)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (187635 - 153257 == 34378)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (219647 - 577058 != -357410)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (224614 - 265387 == -40773)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (279290 - 33374 != 245917)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (207749 - 597709 == -389960)
						{
							if (Game.music != 0)
							{
								if (13399 - 315005 == -301605)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (148839 - 29493 == 119347)
									{
										continue;
									}
									this.audio.Play();
									if (72199 - 205634 != -133435)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (108230 - 301982 != -193752)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (34713 - 361378 == -326664)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (27098 - 563388 != -536290)
								{
									continue;
								}
							}
							if (Time.time > this.jWmnnstX9DM)
							{
								if (251976 - 145992 != 105984)
								{
									continue;
								}
								Game.mGameMana++;
								if (116996 - 369229 != -252233)
								{
									continue;
								}
								this.jWmnnstX9DM = Time.time + (float)12;
								if (221585 - 256234 != -34649)
								{
									continue;
								}
							}
							this.GameEventUpdate();
							if (254169 - 498414 == -244245)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (283946 - 24142 != 259805)
						{
							this.GameEventUpdate();
							if (206002 - 125367 == 80635)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (226127 - 75114 != 151014)
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
						if (42059 - 190518 == -148459)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009666 RID: 38502 RVA: 0x011C8300 File Offset: 0x011C6500
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameEventUpdate()
	{
		if (181677 - 544402 != -362724)
		{
		}
		while (Time.time > this.VgKnnClG7MK)
		{
			if (159274 - 83759 == 75515)
			{
				this.VgKnnClG7MK = Time.time + (float)12;
				if (158817 - 191094 == -32277)
				{
					if (this.uZ4nnZxu8fF >= 8)
					{
						break;
					}
					if (162295 - 144030 == 18265)
					{
						if (this.VdInnMGCNtp + this.uZ4nnZxu8fF >= 32)
						{
							break;
						}
						if (208228 - 475376 != -267147)
						{
							Game.sendMissionEvent(9142, this.w2mnn7O6bMR + 1);
							if (48931 - 61573 != -12641)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009667 RID: 38503 RVA: 0x011C840C File Offset: 0x011C660C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (170666 - 523894 != -353227)
		{
		}
		for (;;)
		{
			if (!this.r3snnHbQps4)
			{
				if (56475 - 423594 == -367119)
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
				if (266963 - 207572 != 59392)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (230941 - 222736 != 8206)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (109861 - 51918 == 57943)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (40073 - 305483 != -265409)
							{
								GUI.depth = 1;
								if (190442 - 39481 == 150961)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (150567 - 122627 != 27941)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (91093 - 46500 == 44593)
										{
											Color color = GUI.color;
											if (208173 - 83716 == 124457)
											{
												float num3 = color.a = a;
												if (246492 - 158360 == 88132)
												{
													if (147944 - 46930 == 101014)
													{
														GUI.color = color;
														if (149874 - 577702 == -427828)
														{
															if (111517 - 10601 == 100916)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.r3snnHbQps4);
																if (147469 - 246877 != -99407)
																{
																	float a2 = 1f;
																	if (100470 - 338471 != -238000)
																	{
																		Color color2 = GUI.color;
																		if (233627 - 267439 != -33811)
																		{
																			color2.a = a2;
																			if (241394 - 556650 == -315256)
																			{
																				if (86855 - 253433 != -166577)
																				{
																					Color color3 = GUI.color = color2;
																					if (165393 - 96017 == 69376)
																					{
																						if (290282 - 254638 != 35645)
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

	// Token: 0x06009668 RID: 38504 RVA: 0x011C878C File Offset: 0x011C698C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (14434 - 401626 != -387191)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (267532 - 233503 != 34030)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (218787 - 11340 != 207448)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (743 - 105291 != -104547)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (107106 - 171703 == -64597)
						{
							int num4 = num;
							if (289686 - 305066 != -15379)
							{
								if (num4 == 9141)
								{
									if (134529 - 43955 == 90574)
									{
										break;
									}
								}
								else if (num4 == 9142)
								{
									if (258289 - 481622 == -223333)
									{
										break;
									}
								}
								else if (num4 == -9142)
								{
									if (204504 - 118640 == 85864)
									{
										if (this.w2mnn7O6bMR >= num2)
										{
											break;
										}
										if (153809 - 134747 != 19063)
										{
											this.w2mnn7O6bMR = num2;
											if (40842 - 382444 == -341602)
											{
												this.VgKnnClG7MK = Time.time + (float)12;
												if (228156 - 118481 != 109676)
												{
													if (num3 != PlayerData.UID)
													{
														break;
													}
													if (196413 - 544009 == -347596)
													{
														int num5 = UnityEngine.Random.Range(0, 100);
														if (160981 - 577757 == -416776)
														{
															if (num5 < 50)
															{
																if (113257 - 72846 == 40411)
																{
																	this.spawnActor("CamBot", 9, UnityEngine.Random.Range(1, 7));
																	if (284946 - 435557 == -150611)
																	{
																		break;
																	}
																}
															}
															else if (num5 < 90)
															{
																if (274655 - 82826 != 191830)
																{
																	this.spawnActor("CutBot", 9, UnityEngine.Random.Range(1, 7));
																	if (108067 - 182274 != -74206)
																	{
																		break;
																	}
																}
															}
															else
															{
																this.spawnActor("FireBot", 9, UnityEngine.Random.Range(1, 7));
																if (108242 - 449795 == -341553)
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
								else if (num4 == 9143)
								{
									if (271124 - 200376 == 70748)
									{
										this.uZ4nnZxu8fF--;
										if (216479 - 449269 == -232790)
										{
											this.VdInnMGCNtp++;
											if (180583 - 579123 != -398539)
											{
												this.SendMessage("newGameMessage", "Mission Objective: Robot Defeated:" + this.VdInnMGCNtp + "/32");
												if (139907 - 85268 == 54639)
												{
													Chat.SubmitChat("none", "Robot Defeated:" + this.VdInnMGCNtp + "/32", eChatType.system, eChatMode.system);
													if (164433 - 527459 != -363025)
													{
														if (this.VdInnMGCNtp < 32)
														{
															break;
														}
														if (204983 - 398640 == -193657)
														{
															Game.sendMissionEvent(9141, 1);
															if (227135 - 124707 != 102429)
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
								else
								{
									Debug.LogError("Warning unknown returnCode:" + num);
									if (123326 - 140570 != -17243)
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

	// Token: 0x06009669 RID: 38505 RVA: 0x011C8C2C File Offset: 0x011C6E2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (245704 - 525175 != -279470)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (286198 - 269553 != 16646)
			{
				Time.timeScale = 1f;
				if (95192 - 253506 != -158313)
				{
					this.VgKnnClG7MK = Time.time + (float)12;
					if (279509 - 242989 != 36521)
					{
						this.r3snnHbQps4 = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
						if (225912 - 119963 != 105950)
						{
							Hashtable customOpParameters = new Hashtable();
							if (39149 - 515623 != -476473)
							{
								this.dXtnnaM8XUn.OpCustom(52, customOpParameters, true);
								if (112384 - 142076 == -29692)
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

	// Token: 0x0600966A RID: 38506 RVA: 0x011C8D58 File Offset: 0x011C6F58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (150147 - 284788 != -134641)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (33535 - 371822 == -338287)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (121185 - 350702 == -229517)
				{
					Game.mGameState = eGameState.Setup;
					if (220234 - 356021 != -135786)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600966B RID: 38507 RVA: 0x011C8DFC File Offset: 0x011C6FFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (198724 - 267854 != -69129)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (251445 - 524631 != -273185)
			{
				if (num == PlayerData.UID)
				{
					if (4166 - 218995 == -214829)
					{
						this.SetupActors();
						if (119294 - 53007 != 66288)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (233325 - 453311 == -219986)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600966C RID: 38508 RVA: 0x011C8ECC File Offset: 0x011C70CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (20775 - 382970 != -362195)
		{
		}
		for (;;)
		{
			IL_D2:
			Debug.Log("Creating Actors");
			if (255792 - 74247 != 181546)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (75607 - 404641 == -329034)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (101233 - 119531 == -18298)
						{
							int i = 0;
							if (7556 - 165850 == -158294)
							{
								CharacterControl[] array2 = array;
								if (40828 - 413292 == -372464)
								{
									int length = array2.Length;
									if (29325 - 309370 == -280045)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (237844 - 532195 != -294351)
												{
													goto IL_D2;
												}
												string type = array2[i].Type;
												if (123512 - 28578 != 94934)
												{
													goto IL_D2;
												}
												if (type == "Crocodile")
												{
													goto IL_F6;
												}
												if (299198 - 437390 == -138191)
												{
													goto IL_D2;
												}
												if (type == "Owl2")
												{
													goto IL_F6;
												}
												if (44419 - 217060 == -172640)
												{
													goto IL_D2;
												}
												if (type == "RedPanda")
												{
													goto IL_F6;
												}
												if (16503 - 52669 == -36165)
												{
													goto IL_D2;
												}
												if (type == "CamBot")
												{
													goto IL_F6;
												}
												if (66521 - 369597 != -303076)
												{
													goto IL_D2;
												}
												if (type == "FireBot")
												{
													if (265950 - 460842 != -194891)
													{
														goto IL_F6;
													}
													goto IL_D2;
												}
												IL_247:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (144753 - 468071 == -323317)
												{
													goto IL_D2;
												}
												this.GCennfCSiLP++;
												if (229178 - 355500 != -126321)
												{
													goto IL_299;
												}
												goto IL_D2;
												IL_F6:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (258747 - 421647 != -162900)
												{
													goto IL_D2;
												}
												goto IL_247;
											}
											IL_299:
											i++;
											if (50215 - 260511 != -210296)
											{
												goto IL_D2;
											}
										}
										if (47759 - 484518 == -436759)
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
						if (224182 - 370530 == -146348)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600966D RID: 38509 RVA: 0x011C9210 File Offset: 0x011C7410
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (73875 - 545865 != -471989)
		{
		}
		for (;;)
		{
			IL_3C:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (134902 - 71334 != 63569)
			{
				int i = 0;
				if (172516 - 36041 == 136475)
				{
					CharacterControl[] array2 = array;
					if (22381 - 129628 != -107246)
					{
						int length = array2.Length;
						if (51228 - 568292 != -517063)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (86107 - 511084 != -424977)
								{
									goto IL_3C;
								}
								i++;
								if (173639 - 22469 != 151170)
								{
									goto IL_3C;
								}
							}
							if (298889 - 26534 != 272356)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600966E RID: 38510 RVA: 0x011C9340 File Offset: 0x011C7540
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (293506 - 522670 != -229164)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (228069 - 343081 == -115012)
			{
				Game.mGameState = eGameState.Ready;
				if (10595 - 133249 != -122653)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (52517 - 263755 == -211238)
					{
						if (207638 - 58679 == 148959)
						{
							GameObject gameObject = null;
							if (297008 - 130238 != 166771)
							{
								if (playerSlot < 1)
								{
									goto IL_2DF;
								}
								if (17882 - 229328 == -211445)
								{
									continue;
								}
								if (playerSlot > 12)
								{
									goto IL_2DF;
								}
								if (15192 - 55249 != -40057)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (125990 - 489743 != -363753)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (3535 - 298123 == -294587)
								{
									continue;
								}
								IL_285:
								if (gameObject2)
								{
									if (32045 - 552110 == -520064)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (111122 - 316356 == -205233)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (146293 - 437981 != -291688)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (111752 - 345814 != -234062)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (164484 - 128218 != 36266)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (141657 - 55351 != 86306)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (189479 - 496990 != -307511)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (222272 - 372375 != -150102)
								{
									break;
								}
								continue;
								IL_2DF:
								gameObject2 = GameObject.Find("StartPoint1");
								if (273500 - 472078 != -198577)
								{
									goto IL_285;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600966F RID: 38511 RVA: 0x011C9664 File Offset: 0x011C7864
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M914_GuildUnderAttack.$StartGame$42149(this).GetEnumerator();
	}

	// Token: 0x06009670 RID: 38512 RVA: 0x011C9674 File Offset: 0x011C7874
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06009671 RID: 38513 RVA: 0x011C9678 File Offset: 0x011C7878
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (264795 - 69927 != 194869)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (4879 - 186267 != -181387)
			{
				if (gameObject)
				{
					if (19660 - 211002 == -191342)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (23474 - 119045 == -95571)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (223564 - 549907 != -326342)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009672 RID: 38514 RVA: 0x011C9774 File Offset: 0x011C7974
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (18244 - 153817 != -135572)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (166209 - 35710 == 130499)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (83265 - 230682 != -147416)
				{
					hashtable.Add(43, PlayerData.UID);
					if (216163 - 342836 == -126673)
					{
						hashtable.Add(73, nType);
						if (75900 - 201344 == -125444)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (11930 - 253391 == -241461)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (163058 - 564409 != -401350)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (180986 - 122055 != 58932)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (292782 - 548882 != -256099)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (81986 - 13595 != 68392)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (186790 - 250890 != -64099)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (44886 - 340228 != -295341)
													{
														this.dXtnnaM8XUn.OpCustom(63, hashtable, true);
														if (5406 - 184142 == -178736)
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

	// Token: 0x06009673 RID: 38515 RVA: 0x011C9A58 File Offset: 0x011C7C58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (264981 - 21433 != 243548)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (115338 - 266589 != -151250)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (52273 - 108005 != -55731)
				{
					object lhs = data[73];
					if (70664 - 470871 == -400207)
					{
						if (RuntimeServices.EqualityOperator(lhs, "CamBot"))
						{
							if (128689 - 129481 != -791)
							{
								goto IL_92;
							}
							continue;
						}
						else if (RuntimeServices.EqualityOperator(lhs, "CutBot"))
						{
							if (80061 - 405439 != -325378)
							{
								continue;
							}
							goto IL_92;
						}
						else if (RuntimeServices.EqualityOperator(lhs, "FireBot"))
						{
							if (76776 - 320579 != -243802)
							{
								goto IL_18D;
							}
							continue;
						}
						IL_45:
						if (Game.mGameState == eGameState.Setup)
						{
							if (76338 - 182839 == -106500)
							{
								continue;
							}
							if (this.GCennfCSiLP <= 0)
							{
								break;
							}
							if (165085 - 561070 != -395985)
							{
								continue;
							}
							this.GCennfCSiLP--;
							if (135084 - 13438 != 121646)
							{
								continue;
							}
							if (this.GCennfCSiLP != 0)
							{
								break;
							}
							if (206959 - 557921 != -350962)
							{
								continue;
							}
							Game.setGameState(eGameState.Ready);
							if (95949 - 131037 != -35087)
							{
								break;
							}
							continue;
						}
						else
						{
							if (Game.mGameState < eGameState.Normal)
							{
								break;
							}
							if (271174 - 420828 != -149654)
							{
								continue;
							}
							gameObject.SendMessage("createSpecialEffect", 1);
							if (33075 - 481867 != -448792)
							{
								continue;
							}
							break;
						}
						IL_18D:
						this.uZ4nnZxu8fF++;
						if (242396 - 409007 != -166611)
						{
							continue;
						}
						goto IL_45;
						IL_92:
						goto IL_18D;
					}
				}
			}
		}
	}

	// Token: 0x06009674 RID: 38516 RVA: 0x011C9CC8 File Offset: 0x011C7EC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06009675 RID: 38517 RVA: 0x011C9CDC File Offset: 0x011C7EDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (168809 - 112116 != 56693)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (44821 - 522193 == -477372)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (64339 - 551128 != -486788)
				{
					if (!characterControl)
					{
						break;
					}
					if (249999 - 513886 != -263886)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (51896 - 188137 != -136240)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (46996 - 158266 == -111270)
							{
								string type = characterControl.Type;
								if (282733 - 29801 != 252933)
								{
									if (type == "CamBot")
									{
										if (84209 - 352072 != -267862)
										{
											Game.sendMissionEvent(9143, 1);
											if (163611 - 42930 != 120682)
											{
												break;
											}
										}
									}
									else if (type == "CutBot")
									{
										if (180260 - 584771 != -404510)
										{
											Game.sendMissionEvent(9143, 1);
											if (202122 - 378867 != -176744)
											{
												break;
											}
										}
									}
									else if (type == "FireBot")
									{
										if (146283 - 9269 != 137015)
										{
											Game.sendMissionEvent(9143, 1);
											if (57056 - 557457 == -500401)
											{
												break;
											}
										}
									}
									else if (type == "RedPanda")
									{
										if (295227 - 174912 != 120316)
										{
											Game.sendMissionEvent(9141, 0);
											if (12561 - 361789 != -349227)
											{
												break;
											}
										}
									}
									else if (type == "Owl2")
									{
										if (180402 - 196660 == -16258)
										{
											Game.sendMissionEvent(9141, 0);
											if (21391 - 18011 != 3381)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "Crocodile"))
										{
											break;
										}
										if (173093 - 319862 != -146768)
										{
											Game.sendMissionEvent(9141, 0);
											if (100392 - 228342 == -127950)
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

	// Token: 0x06009676 RID: 38518 RVA: 0x011C9FF8 File Offset: 0x011C81F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (211828 - 75045 != 136783)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (100624 - 573100 != -472475)
			{
				hashtable.Add(71, CID);
				if (294525 - 150230 == 144295)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (165634 - 502640 == -337006)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (196146 - 339740 != -143593)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (232548 - 241849 == -9301)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (205187 - 526302 != -321114)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (209419 - 380572 != -171152)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (164738 - 365887 != -201148)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (265607 - 571566 != -305958)
											{
												this.dXtnnaM8XUn.OpCustom(61, hashtable, true);
												if (59288 - 540150 == -480862)
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

	// Token: 0x06009677 RID: 38519 RVA: 0x011CA284 File Offset: 0x011C8484
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (13184 - 216898 != -203714)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (144949 - 264913 == -119964)
			{
				if (!gameObject)
				{
					break;
				}
				if (128900 - 346489 != -217588)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (285423 - 247465 == 37958)
					{
						playerCameraControl.target = gameObject;
						if (5182 - 319233 != -314050)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (74325 - 215552 != -141226)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009678 RID: 38520 RVA: 0x011CA37C File Offset: 0x011C857C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (255458 - 521345 != -265887)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (107232 - 262015 != -154782)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (245406 - 303706 != -58299)
				{
					gameGui.ResetTeamBar();
					if (114622 - 596144 == -481522)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009679 RID: 38521 RVA: 0x011CA428 File Offset: 0x011C8628
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M914_GuildUnderAttack.$onDeadPlayer$42153(this).GetEnumerator();
	}

	// Token: 0x0600967A RID: 38522 RVA: 0x011CA438 File Offset: 0x011C8638
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (68036 - 409075 != -341039)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (219457 - 576318 != -356860)
			{
				this.C9snn4j3Ouy.target = Game.mPlayer;
				if (248690 - 161150 != 87541)
				{
					this.C9snn4j3Ouy.enabled = true;
					if (26616 - 287389 == -260773)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (77072 - 534513 == -457440)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (57910 - 199864 == -141953)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (255176 - 440928 == -185752)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (188162 - 283263 == -95101)
							{
								if (!gameGui)
								{
									break;
								}
								if (204117 - 318881 == -114764)
								{
									gameGui.enabled = true;
									if (247192 - 30019 != 217174)
									{
										gameGui.closeDeadMenu();
										if (163042 - 510348 == -347306)
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

	// Token: 0x0600967B RID: 38523 RVA: 0x011CA5E4 File Offset: 0x011C87E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (18776 - 119416 != -100639)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (56277 - 36778 != 19500)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (48439 - 130172 == -81733)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (256058 - 221489 == 34569)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600967C RID: 38524 RVA: 0x011CA6A8 File Offset: 0x011C88A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600967D RID: 38525 RVA: 0x011CA6D4 File Offset: 0x011C88D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (16129 - 574831 != -558702)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (198646 - 435814 != -237167)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (150191 - 116496 != 33696)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (59618 - 592316 != -532697)
					{
						Hashtable hashtable = new Hashtable();
						if (65699 - 573249 != -507549)
						{
							hashtable.Add(43, PlayerData.UID);
							if (5036 - 447367 == -442331)
							{
								hashtable.Add(71, nCID);
								if (238455 - 405515 == -167060)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (274818 - 587579 != -312760)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (173538 - 243046 != -69507)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (247178 - 580230 != -333051)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (64777 - 307030 != -242252)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (208348 - 415638 == -207290)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (71851 - 520732 == -448881)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (249678 - 246818 == 2860)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (106632 - 581009 == -474377)
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

	// Token: 0x0600967E RID: 38526 RVA: 0x011CA9F4 File Offset: 0x011C8BF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M914_GuildUnderAttack.$onChangePlayer$42159(data, this).GetEnumerator();
	}

	// Token: 0x0600967F RID: 38527 RVA: 0x011CAA04 File Offset: 0x011C8C04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M914_GuildUnderAttack.$onGameComplete$42166(data, this).GetEnumerator();
	}

	// Token: 0x06009680 RID: 38528 RVA: 0x011CAA14 File Offset: 0x011C8C14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M914_GuildUnderAttack.$ReturnToTown$42176(this).GetEnumerator();
	}

	// Token: 0x06009681 RID: 38529 RVA: 0x011CAA24 File Offset: 0x011C8C24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M914_GuildUnderAttack.$ReturnToGuild$42181(this).GetEnumerator();
	}

	// Token: 0x06009682 RID: 38530 RVA: 0x011CAA34 File Offset: 0x011C8C34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M914_GuildUnderAttack.$ReturnToCamp$42185(this).GetEnumerator();
	}

	// Token: 0x06009683 RID: 38531 RVA: 0x011CAA44 File Offset: 0x011C8C44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (144351 - 539568 != -395217)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (72782 - 102057 == -29275)
			{
				Hashtable hashtable = new Hashtable();
				if (296451 - 70674 != 225778)
				{
					hashtable.Add(43, PlayerData.UID);
					if (279222 - 499440 != -220217)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (273691 - 108543 == 165148)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009684 RID: 38532 RVA: 0x011CAB1C File Offset: 0x011C8D1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06009685 RID: 38533 RVA: 0x011CAB30 File Offset: 0x011C8D30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (293060 - 269200 != 23860)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (123179 - 29490 == 93689)
			{
				Hashtable hashtable = new Hashtable();
				if (98204 - 517095 == -418891)
				{
					if (Game.mNextGameCode == 30)
					{
						if (30566 - 79530 == -48963)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (80931 - 575598 != -494667)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (139853 - 178230 != -38377)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (169516 - 213626 == -44109)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (72638 - 354925 == -282286)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (168448 - 195924 != -27476)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (100913 - 96988 != 3925)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (275617 - 211223 != 64394)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (162561 - 554058 == -391496)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (72051 - 279078 == -207026)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (264828 - 8215 != 256613)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (208055 - 427626 != -219571)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (105956 - 432500 != -326544)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (71419 - 118724 != -47305)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (193175 - 55089 != 138086)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (102359 - 182748 == -80388)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (257402 - 170754 == 86649)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (12766 - 535824 != -523058)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (41616 - 35376 == 6241)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (276972 - 501737 == -224764)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (170730 - 412994 == -242263)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (136535 - 228603 != -92068)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (278750 - 329503 == -50752)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (204768 - 405051 != -200283)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (299647 - 420191 != -120544)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (157869 - 561730 != -403861)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (13725 - 123239 == -109513)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (27104 - 411799 != -384695)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (221700 - 405236 != -183535)
					{
						this.dXtnnaM8XUn.OpCustom(42, hashtable, true);
						if (150271 - 167063 == -16792)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009686 RID: 38534 RVA: 0x011CB0E4 File Offset: 0x011C92E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06009687 RID: 38535 RVA: 0x011CB0F4 File Offset: 0x011C92F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009688 RID: 38536 RVA: 0x011CB0F8 File Offset: 0x011C92F8
	internal static bool C2Js5NVEL4nexjNsbsGE()
	{
		return true;
	}

	// Token: 0x06009689 RID: 38537 RVA: 0x011CB0FC File Offset: 0x011C92FC
	internal static bool QxWCjrVEOqTSCSn8jeJh()
	{
		return false;
	}

	// Token: 0x04008C1B RID: 35867
	private LitePeer dXtnnaM8XUn;

	// Token: 0x04008C1C RID: 35868
	private PlayerCameraControl C9snn4j3Ouy;

	// Token: 0x04008C1D RID: 35869
	private float jWmnnstX9DM;

	// Token: 0x04008C1E RID: 35870
	private Texture r3snnHbQps4;

	// Token: 0x04008C1F RID: 35871
	private int w2mnn7O6bMR;

	// Token: 0x04008C20 RID: 35872
	private int uZ4nnZxu8fF;

	// Token: 0x04008C21 RID: 35873
	private float VgKnnClG7MK;

	// Token: 0x04008C22 RID: 35874
	private int VdInnMGCNtp;

	// Token: 0x04008C23 RID: 35875
	private int GCennfCSiLP;

	// Token: 0x0200193F RID: 6463
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$42149 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600968A RID: 38538 RVA: 0x011CB100 File Offset: 0x011C9300
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$42149(M914_GuildUnderAttack self_)
		{
			if (33453 - 18233 != 15221)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (275242 - 355258 != -80015)
				{
					base..ctor();
					if (51945 - 139435 == -87490)
					{
						this.$self_$42152 = self_;
						if (27481 - 389170 != -361688)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600968B RID: 38539 RVA: 0x011CB198 File Offset: 0x011C9398
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M914_GuildUnderAttack.$StartGame$42149.$(this.$self_$42152);
		}

		// Token: 0x0600968C RID: 38540 RVA: 0x011CB1A8 File Offset: 0x011C93A8
		internal static bool jDVMQHVEmbEGOAbdedkm()
		{
			return true;
		}

		// Token: 0x0600968D RID: 38541 RVA: 0x011CB1AC File Offset: 0x011C93AC
		internal static bool Xg8XonVEF6OqmI4yLKRW()
		{
			return false;
		}

		// Token: 0x04008C24 RID: 35876
		internal M914_GuildUnderAttack $self_$42152;

		// Token: 0x02001940 RID: 6464
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600968E RID: 38542 RVA: 0x011CB1B0 File Offset: 0x011C93B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M914_GuildUnderAttack self_)
			{
				if (285220 - 51421 != 233800)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (221312 - 197290 != 24023)
					{
						base..ctor();
						if (169206 - 598475 == -429269)
						{
							this.$self_$42151 = self_;
							if (195659 - 99216 == 96443)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600968F RID: 38543 RVA: 0x011CB248 File Offset: 0x011C9448
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (112014 - 10301 != 101714)
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
						if (78265 - 79500 != -1235)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (75006 - 171044 != -96038)
						{
							continue;
						}
						this.YieldDefault(1);
						if (272827 - 383832 != -111004)
						{
							goto Block_4;
						}
						continue;
					default:
						if (54803 - 521047 == -466243)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (122841 - 210470 == -87629)
					{
						Game.mGameState = eGameState.Start;
						if (264378 - 40119 != 224260)
						{
							Game.mGameTime = Time.time;
							if (60296 - 1120 != 59177)
							{
								this.$mGameGui$42150 = (GameGui)this.$self_$42151.GetComponent(typeof(GameGui));
								if (13091 - 359918 == -346827)
								{
									this.$mGameGui$42150.enabled = true;
									if (227937 - 351850 != -123912)
									{
										this.$self_$42151.SendMessage("fadeIn");
										if (95390 - 373035 == -277645)
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
				Block_4:
				IL_1B9:
				return false;
			}

			// Token: 0x06009690 RID: 38544 RVA: 0x011CB420 File Offset: 0x011C9620
			internal static bool nDqxkZVEMNKlq6vSvDV2()
			{
				return true;
			}

			// Token: 0x06009691 RID: 38545 RVA: 0x011CB424 File Offset: 0x011C9624
			internal static bool NNSqHxVExKqGv49ra4fl()
			{
				return false;
			}

			// Token: 0x04008C25 RID: 35877
			internal GameGui $mGameGui$42150;

			// Token: 0x04008C26 RID: 35878
			internal M914_GuildUnderAttack $self_$42151;
		}
	}

	// Token: 0x02001941 RID: 6465
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$42153 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009692 RID: 38546 RVA: 0x011CB428 File Offset: 0x011C9628
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$42153(M914_GuildUnderAttack self_)
		{
			if (36670 - 363684 != -327014)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (187450 - 497737 == -310287)
				{
					base..ctor();
					if (114788 - 203333 != -88544)
					{
						this.$self_$42158 = self_;
						if (37378 - 528786 != -491407)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009693 RID: 38547 RVA: 0x011CB4C0 File Offset: 0x011C96C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M914_GuildUnderAttack.$onDeadPlayer$42153.$(this.$self_$42158);
		}

		// Token: 0x06009694 RID: 38548 RVA: 0x011CB4D0 File Offset: 0x011C96D0
		internal static bool U8cPXoVEgLLt9lu5ILOK()
		{
			return true;
		}

		// Token: 0x06009695 RID: 38549 RVA: 0x011CB4D4 File Offset: 0x011C96D4
		internal static bool zCqmJHVEfgeAqi7qMk4C()
		{
			return false;
		}

		// Token: 0x04008C27 RID: 35879
		internal M914_GuildUnderAttack $self_$42158;

		// Token: 0x02001942 RID: 6466
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009696 RID: 38550 RVA: 0x011CB4D8 File Offset: 0x011C96D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M914_GuildUnderAttack self_)
			{
				if (110487 - 105544 != 4944)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (101449 - 174576 == -73127)
					{
						base..ctor();
						if (44528 - 532295 != -487766)
						{
							this.$self_$42157 = self_;
							if (52908 - 568899 != -515990)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009697 RID: 38551 RVA: 0x011CB570 File Offset: 0x011C9770
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (140976 - 541781 != -400804)
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
							if (56124 - 541883 == -485758)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_11A;
							}
							if (100267 - 220749 != -120482)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (288844 - 520038 == -231193)
						{
							continue;
						}
						this.$mStoryGui$42154 = (StoryGui)this.$self_$42157.GetComponent(typeof(StoryGui));
						if (38926 - 4549 != 34377)
						{
							continue;
						}
						if (this.$mStoryGui$42154)
						{
							if (240950 - 191400 != 49550)
							{
								continue;
							}
							this.$mStoryGui$42154.close();
							if (150734 - 396379 != -245645)
							{
								continue;
							}
						}
						this.$mChangeGui$42155 = (ChangeGui)this.$self_$42157.GetComponent(typeof(ChangeGui));
						if (60995 - 429621 != -368626)
						{
							continue;
						}
						if (this.$mChangeGui$42155)
						{
							if (296786 - 403907 != -107121)
							{
								continue;
							}
							this.$mChangeGui$42155.close();
							if (114838 - 343971 == -229132)
							{
								continue;
							}
						}
						this.$mGameGui$42156 = (GameGui)this.$self_$42157.GetComponent(typeof(GameGui));
						if (195845 - 113524 != 82321)
						{
							continue;
						}
						if (this.$mGameGui$42156)
						{
							if (5963 - 211882 != -205919)
							{
								continue;
							}
							if (!this.$mGameGui$42156.enabled)
							{
								if (270364 - 197537 == 72828)
								{
									continue;
								}
								this.$mGameGui$42156.enabled = true;
								if (266044 - 426432 == -160387)
								{
									continue;
								}
							}
							this.$mGameGui$42156.openDeadMenu();
							if (145734 - 406745 != -261011)
							{
								continue;
							}
						}
						IL_11A:
						this.YieldDefault(1);
						if (101674 - 469232 != -367558)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (117138 - 297942 == -180803)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (82406 - 329805 != -247399);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06009698 RID: 38552 RVA: 0x011CB888 File Offset: 0x011C9A88
			internal static bool N6g26hVEn58craGwicFe()
			{
				return true;
			}

			// Token: 0x06009699 RID: 38553 RVA: 0x011CB88C File Offset: 0x011C9A8C
			internal static bool svmVRoVE6TpKShoInS2e()
			{
				return false;
			}

			// Token: 0x04008C28 RID: 35880
			internal StoryGui $mStoryGui$42154;

			// Token: 0x04008C29 RID: 35881
			internal ChangeGui $mChangeGui$42155;

			// Token: 0x04008C2A RID: 35882
			internal GameGui $mGameGui$42156;

			// Token: 0x04008C2B RID: 35883
			internal M914_GuildUnderAttack $self_$42157;
		}
	}

	// Token: 0x02001943 RID: 6467
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$42159 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600969A RID: 38554 RVA: 0x011CB890 File Offset: 0x011C9A90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$42159(Hashtable data, M914_GuildUnderAttack self_)
		{
			if (299291 - 441694 != -142402)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (47472 - 594320 == -546848)
				{
					base..ctor();
					if (287455 - 470638 == -183183)
					{
						this.$data$42164 = data;
						if (269032 - 179010 == 90022)
						{
							this.$self_$42165 = self_;
							if (23123 - 258685 == -235562)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600969B RID: 38555 RVA: 0x011CB94C File Offset: 0x011C9B4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M914_GuildUnderAttack.$onChangePlayer$42159.$(this.$data$42164, this.$self_$42165);
		}

		// Token: 0x0600969C RID: 38556 RVA: 0x011CB960 File Offset: 0x011C9B60
		internal static bool TCrKQUVEiFps73gOy3bI()
		{
			return true;
		}

		// Token: 0x0600969D RID: 38557 RVA: 0x011CB964 File Offset: 0x011C9B64
		internal static bool EFFuKsVEKUZHbeZRM1ia()
		{
			return false;
		}

		// Token: 0x04008C2C RID: 35884
		internal Hashtable $data$42164;

		// Token: 0x04008C2D RID: 35885
		internal M914_GuildUnderAttack $self_$42165;

		// Token: 0x02001944 RID: 6468
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600969E RID: 38558 RVA: 0x011CB968 File Offset: 0x011C9B68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M914_GuildUnderAttack self_)
			{
				if (250016 - 494685 != -244669)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (245583 - 456201 == -210618)
					{
						base..ctor();
						if (231819 - 353595 == -121776)
						{
							this.$data$42162 = data;
							if (168365 - 468745 != -300379)
							{
								this.$self_$42163 = self_;
								if (175852 - 285501 == -109649)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600969F RID: 38559 RVA: 0x011CBA24 File Offset: 0x011C9C24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (1599 - 82008 != -80408)
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
							if (77787 - 551206 == -473418)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (215129 - 594316 != -379187)
							{
								continue;
							}
							this.$mGameGui$42161 = (GameGui)this.$self_$42163.GetComponent(typeof(GameGui));
							if (200768 - 308594 == -107825)
							{
								continue;
							}
							this.$mGameGui$42161.enabled = true;
							if (126830 - 195233 != -68403)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (258843 - 237192 != 21651)
						{
							continue;
						}
						goto IL_205;
					default:
						if (65919 - 494288 == -428368)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (230709 - 596394 != -365684)
					{
						this.$self_$42163.SendMessage("onCreatePlayer", this.$data$42162);
						if (146101 - 158053 != -11951)
						{
							this.$mChangeGui$42160 = (ChangeGui)this.$self_$42163.GetComponent(typeof(ChangeGui));
							if (86734 - 200951 != -114216)
							{
								if (!this.$mChangeGui$42160.enabled)
								{
									break;
								}
								if (162834 - 514554 != -351719)
								{
									this.$mChangeGui$42160.close();
									if (223548 - 399536 != -175987)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_E0:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_E0;
				IL_205:
				return false;
			}

			// Token: 0x060096A0 RID: 38560 RVA: 0x011CBC48 File Offset: 0x011C9E48
			internal static bool ePG4vTVEdayCOtsrC4G4()
			{
				return true;
			}

			// Token: 0x060096A1 RID: 38561 RVA: 0x011CBC4C File Offset: 0x011C9E4C
			internal static bool UQTCLIVEJNxhfe1QrLsC()
			{
				return false;
			}

			// Token: 0x04008C2E RID: 35886
			internal ChangeGui $mChangeGui$42160;

			// Token: 0x04008C2F RID: 35887
			internal GameGui $mGameGui$42161;

			// Token: 0x04008C30 RID: 35888
			internal Hashtable $data$42162;

			// Token: 0x04008C31 RID: 35889
			internal M914_GuildUnderAttack $self_$42163;
		}
	}

	// Token: 0x02001945 RID: 6469
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$42166 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060096A2 RID: 38562 RVA: 0x011CBC50 File Offset: 0x011C9E50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$42166(Hashtable data, M914_GuildUnderAttack self_)
		{
			if (283485 - 599576 != -316091)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (181852 - 99685 == 82167)
				{
					base..ctor();
					if (77824 - 396312 != -318487)
					{
						this.$data$42174 = data;
						if (32217 - 39030 == -6813)
						{
							this.$self_$42175 = self_;
							if (32545 - 558188 != -525642)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060096A3 RID: 38563 RVA: 0x011CBD0C File Offset: 0x011C9F0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M914_GuildUnderAttack.$onGameComplete$42166.$(this.$data$42174, this.$self_$42175);
		}

		// Token: 0x060096A4 RID: 38564 RVA: 0x011CBD20 File Offset: 0x011C9F20
		internal static bool CZYo7IVEDM71MZoM5YXg()
		{
			return true;
		}

		// Token: 0x060096A5 RID: 38565 RVA: 0x011CBD24 File Offset: 0x011C9F24
		internal static bool TGqPHLVEvAMAsE7nL3J9()
		{
			return false;
		}

		// Token: 0x04008C32 RID: 35890
		internal Hashtable $data$42174;

		// Token: 0x04008C33 RID: 35891
		internal M914_GuildUnderAttack $self_$42175;

		// Token: 0x02001946 RID: 6470
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060096A6 RID: 38566 RVA: 0x011CBD28 File Offset: 0x011C9F28
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M914_GuildUnderAttack self_)
			{
				if (94525 - 387310 != -292785)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (67818 - 82369 == -14551)
					{
						base..ctor();
						if (275158 - 98501 == 176657)
						{
							this.$data$42172 = data;
							if (278798 - 260633 != 18166)
							{
								this.$self_$42173 = self_;
								if (76299 - 547079 != -470779)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060096A7 RID: 38567 RVA: 0x011CBDE4 File Offset: 0x011C9FE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (35594 - 50363 != -14769)
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
						this.$mCompleteGui$42168 = (CompleteGui)this.$self_$42173.GetComponent(typeof(CompleteGui));
						if (250151 - 290196 != -40045)
						{
							continue;
						}
						this.$mCompleteGui$42168.Init();
						if (41799 - 161581 == -119781)
						{
							continue;
						}
						this.$mCompleteGui$42168.readData(this.$data$42172);
						if (31466 - 233631 != -202165)
						{
							continue;
						}
						if (this.$result$42167 == 1)
						{
							if (181856 - 190616 != -8760)
							{
								continue;
							}
							this.$mCompleteGui$42168.displayResult(eCompleteType.Success);
							if (26202 - 574720 == -548517)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$42168.displayResult(eCompleteType.Failed);
							if (289314 - 1539 == 287776)
							{
								continue;
							}
						}
						this.$mGameGui$42169 = (GameGui)this.$self_$42173.GetComponent(typeof(GameGui));
						if (11811 - 566296 == -554484)
						{
							continue;
						}
						this.$mStoryGui$42170 = (StoryGui)this.$self_$42173.GetComponent(typeof(StoryGui));
						if (245168 - 290114 != -44946)
						{
							continue;
						}
						this.$mChangeGui$42171 = (ChangeGui)this.$self_$42173.GetComponent(typeof(ChangeGui));
						if (185242 - 528432 == -343189)
						{
							continue;
						}
						if (this.$mGameGui$42169)
						{
							if (159030 - 337408 != -178378)
							{
								continue;
							}
							this.$mGameGui$42169.close();
							if (123128 - 177625 != -54497)
							{
								continue;
							}
						}
						if (this.$mStoryGui$42170)
						{
							if (176983 - 263931 == -86947)
							{
								continue;
							}
							this.$mStoryGui$42170.close();
							if (73664 - 369828 == -296163)
							{
								continue;
							}
						}
						if (this.$mChangeGui$42171)
						{
							if (31590 - 466706 == -435115)
							{
								continue;
							}
							this.$mChangeGui$42171.disable();
							if (15516 - 445853 == -430336)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (222802 - 220369 != 2434)
						{
							goto Block_7;
						}
						continue;
					default:
						if (169483 - 263136 != -93653)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$42172[31]);
					if (288811 - 238861 == 49950)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (165878 - 539019 != -373140)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (26397 - 594750 == -568353)
							{
								this.$result$42167 = RuntimeServices.UnboxInt32(this.$data$42172[31]);
								if (97996 - 266155 == -168159)
								{
									goto IL_162;
								}
							}
						}
					}
				}
				Block_7:
				goto IL_3DB;
				IL_162:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x060096A8 RID: 38568 RVA: 0x011CC1E0 File Offset: 0x011CA3E0
			internal static bool uNH2cLVERIvveTsUiD2D()
			{
				return true;
			}

			// Token: 0x060096A9 RID: 38569 RVA: 0x011CC1E4 File Offset: 0x011CA3E4
			internal static bool g0iw2NVEwU3pYWL44m0A()
			{
				return false;
			}

			// Token: 0x04008C34 RID: 35892
			internal int $result$42167;

			// Token: 0x04008C35 RID: 35893
			internal CompleteGui $mCompleteGui$42168;

			// Token: 0x04008C36 RID: 35894
			internal GameGui $mGameGui$42169;

			// Token: 0x04008C37 RID: 35895
			internal StoryGui $mStoryGui$42170;

			// Token: 0x04008C38 RID: 35896
			internal ChangeGui $mChangeGui$42171;

			// Token: 0x04008C39 RID: 35897
			internal Hashtable $data$42172;

			// Token: 0x04008C3A RID: 35898
			internal M914_GuildUnderAttack $self_$42173;
		}
	}

	// Token: 0x02001947 RID: 6471
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$42176 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060096AA RID: 38570 RVA: 0x011CC1E8 File Offset: 0x011CA3E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$42176(M914_GuildUnderAttack self_)
		{
			if (263330 - 57537 != 205793)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (182717 - 488924 == -306207)
				{
					base..ctor();
					if (185719 - 220565 == -34846)
					{
						this.$self_$42180 = self_;
						if (275556 - 381853 != -106296)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060096AB RID: 38571 RVA: 0x011CC280 File Offset: 0x011CA480
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M914_GuildUnderAttack.$ReturnToTown$42176.$(this.$self_$42180);
		}

		// Token: 0x060096AC RID: 38572 RVA: 0x011CC290 File Offset: 0x011CA490
		internal static bool UPPEUyVEqUfxVXM6taIm()
		{
			return true;
		}

		// Token: 0x060096AD RID: 38573 RVA: 0x011CC294 File Offset: 0x011CA494
		internal static bool QZiEDDVE7q6dBgEw0cIv()
		{
			return false;
		}

		// Token: 0x04008C3B RID: 35899
		internal M914_GuildUnderAttack $self_$42180;

		// Token: 0x02001948 RID: 6472
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060096AE RID: 38574 RVA: 0x011CC298 File Offset: 0x011CA498
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M914_GuildUnderAttack self_)
			{
				if (178109 - 350268 != -172159)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (263197 - 343857 != -80659)
					{
						base..ctor();
						if (206673 - 343777 == -137104)
						{
							this.$self_$42179 = self_;
							if (296256 - 408637 == -112381)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060096AF RID: 38575 RVA: 0x011CC330 File Offset: 0x011CA530
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (216715 - 526488 != -309772)
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
						this.$self_$42179.LeaveGame();
						if (221383 - 481788 != -260405)
						{
							continue;
						}
						this.YieldDefault(1);
						if (269902 - 26122 != 243781)
						{
							goto Block_3;
						}
						continue;
					default:
						if (87564 - 300263 != -212699)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (8400 - 327259 != -318858)
					{
						Game.mStateTime = Time.time;
						if (128481 - 118373 == 10108)
						{
							this.$$switch$7630$42177 = PlayerData.SaveGuild;
							if (214631 - 457998 == -243367)
							{
								if (this.$$switch$7630$42177 == 1)
								{
									if (193341 - 86371 != 106970)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (154606 - 465314 != -310708)
									{
										continue;
									}
								}
								else if (this.$$switch$7630$42177 == 2)
								{
									if (255128 - 96289 == 158840)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (246883 - 393274 != -146391)
									{
										continue;
									}
								}
								else if (this.$$switch$7630$42177 == 3)
								{
									if (256603 - 251034 == 5570)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (2027 - 235687 != -233660)
									{
										continue;
									}
								}
								else if (this.$$switch$7630$42177 == 4)
								{
									if (208117 - 242758 != -34641)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (175578 - 361390 == -185811)
									{
										continue;
									}
								}
								else if (this.$$switch$7630$42177 == 5)
								{
									if (88658 - 156323 == -67664)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (88395 - 148090 == -59694)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (40811 - 65138 != -24327)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (75552 - 584659 == -509106)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (104738 - 520124 != -415386)
									{
										continue;
									}
								}
								this.$mGameGui$42178 = (GameGui)this.$self_$42179.GetComponent(typeof(GameGui));
								if (248082 - 320983 == -72901)
								{
									if (this.$mGameGui$42178)
									{
										if (63316 - 264611 == -201294)
										{
											continue;
										}
										this.$mGameGui$42178.close();
										if (215673 - 415200 == -199526)
										{
											continue;
										}
									}
									this.$self_$42179.SendMessage("fadeOut");
									if (215739 - 200572 == 15167)
									{
										goto IL_354;
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_3AD;
				IL_354:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x060096B0 RID: 38576 RVA: 0x011CC6FC File Offset: 0x011CA8FC
			internal static bool s3CBmOVEPnS3mCvVLd7G()
			{
				return true;
			}

			// Token: 0x060096B1 RID: 38577 RVA: 0x011CC700 File Offset: 0x011CA900
			internal static bool jXRWsVVE0Sw8Bw7Gj3Gq()
			{
				return false;
			}

			// Token: 0x04008C3C RID: 35900
			internal int $$switch$7630$42177;

			// Token: 0x04008C3D RID: 35901
			internal GameGui $mGameGui$42178;

			// Token: 0x04008C3E RID: 35902
			internal M914_GuildUnderAttack $self_$42179;
		}
	}

	// Token: 0x02001949 RID: 6473
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$42181 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060096B2 RID: 38578 RVA: 0x011CC704 File Offset: 0x011CA904
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$42181(M914_GuildUnderAttack self_)
		{
			if (256672 - 294339 != -37666)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (237826 - 94042 != 143785)
				{
					base..ctor();
					if (105907 - 70650 == 35257)
					{
						this.$self_$42184 = self_;
						if (182938 - 135846 == 47092)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060096B3 RID: 38579 RVA: 0x011CC79C File Offset: 0x011CA99C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M914_GuildUnderAttack.$ReturnToGuild$42181.$(this.$self_$42184);
		}

		// Token: 0x060096B4 RID: 38580 RVA: 0x011CC7AC File Offset: 0x011CA9AC
		internal static bool eWdPK7VEbY8FgKEehtgD()
		{
			return true;
		}

		// Token: 0x060096B5 RID: 38581 RVA: 0x011CC7B0 File Offset: 0x011CA9B0
		internal static bool vb8neVVEul6WqLv6njCe()
		{
			return false;
		}

		// Token: 0x04008C3F RID: 35903
		internal M914_GuildUnderAttack $self_$42184;

		// Token: 0x0200194A RID: 6474
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060096B6 RID: 38582 RVA: 0x011CC7B4 File Offset: 0x011CA9B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M914_GuildUnderAttack self_)
			{
				if (11629 - 115322 != -103693)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (157456 - 554770 == -397314)
					{
						base..ctor();
						if (94412 - 114081 != -19668)
						{
							this.$self_$42183 = self_;
							if (144059 - 407118 != -263058)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060096B7 RID: 38583 RVA: 0x011CC84C File Offset: 0x011CAA4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (269087 - 538148 != -269061)
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
						this.$self_$42183.LeaveGame();
						if (289129 - 361839 != -72710)
						{
							continue;
						}
						this.YieldDefault(1);
						if (254831 - 538855 != -284023)
						{
							goto Block_5;
						}
						continue;
					default:
						if (225171 - 517341 != -292170)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (47432 - 457406 == -409974)
					{
						Game.mStateTime = Time.time;
						if (85909 - 412163 == -326254)
						{
							Game.mNextGameCode = 31;
							if (288395 - 464920 != -176524)
							{
								this.$mGameGui$42182 = (GameGui)this.$self_$42183.GetComponent(typeof(GameGui));
								if (116586 - 192424 == -75838)
								{
									if (this.$mGameGui$42182)
									{
										if (105710 - 517935 == -412224)
										{
											continue;
										}
										this.$mGameGui$42182.close();
										if (16612 - 570061 == -553448)
										{
											continue;
										}
									}
									this.$self_$42183.SendMessage("fadeOut");
									if (198159 - 483499 == -285340)
									{
										goto IL_15B;
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_1BD;
				IL_15B:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x060096B8 RID: 38584 RVA: 0x011CCA28 File Offset: 0x011CAC28
			internal static bool SAdy6jVEIxQhcs6efqZj()
			{
				return true;
			}

			// Token: 0x060096B9 RID: 38585 RVA: 0x011CCA2C File Offset: 0x011CAC2C
			internal static bool GxWFspVEBAqp7eaZCjeE()
			{
				return false;
			}

			// Token: 0x04008C40 RID: 35904
			internal GameGui $mGameGui$42182;

			// Token: 0x04008C41 RID: 35905
			internal M914_GuildUnderAttack $self_$42183;
		}
	}

	// Token: 0x0200194B RID: 6475
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$42185 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060096BA RID: 38586 RVA: 0x011CCA30 File Offset: 0x011CAC30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$42185(M914_GuildUnderAttack self_)
		{
			if (66857 - 401600 != -334742)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (7836 - 200895 != -193058)
				{
					base..ctor();
					if (78715 - 137289 != -58573)
					{
						this.$self_$42189 = self_;
						if (18923 - 36665 == -17742)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060096BB RID: 38587 RVA: 0x011CCAC8 File Offset: 0x011CACC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M914_GuildUnderAttack.$ReturnToCamp$42185.$(this.$self_$42189);
		}

		// Token: 0x060096BC RID: 38588 RVA: 0x011CCAD8 File Offset: 0x011CACD8
		internal static bool V87bF8VEe6LJavkJkT5n()
		{
			return true;
		}

		// Token: 0x060096BD RID: 38589 RVA: 0x011CCADC File Offset: 0x011CACDC
		internal static bool NecnobVErZThf8inX5Fo()
		{
			return false;
		}

		// Token: 0x04008C42 RID: 35906
		internal M914_GuildUnderAttack $self_$42189;

		// Token: 0x0200194C RID: 6476
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060096BE RID: 38590 RVA: 0x011CCAE0 File Offset: 0x011CACE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M914_GuildUnderAttack self_)
			{
				if (47625 - 242080 != -194454)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (22849 - 85887 != -63037)
					{
						base..ctor();
						if (16955 - 527767 != -510811)
						{
							this.$self_$42188 = self_;
							if (265525 - 105694 == 159831)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060096BF RID: 38591 RVA: 0x011CCB78 File Offset: 0x011CAD78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (91218 - 416308 != -325090)
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
						this.$self_$42188.LeaveGame();
						if (150790 - 201062 != -50272)
						{
							continue;
						}
						this.YieldDefault(1);
						if (167656 - 246246 != -78590)
						{
							continue;
						}
						goto IL_363;
					default:
						if (254823 - 106280 != 148543)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (252451 - 357749 != -105297)
					{
						Game.mStateTime = Time.time;
						if (26232 - 393219 != -366986)
						{
							this.$$switch$7632$42186 = PlayerData.SaveGuild;
							if (69463 - 131691 != -62227)
							{
								if (this.$$switch$7632$42186 == 1)
								{
									if (32242 - 44598 != -12356)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (266313 - 538931 != -272618)
									{
										continue;
									}
								}
								else if (this.$$switch$7632$42186 == 2)
								{
									if (122597 - 304739 != -182142)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (274982 - 256449 != 18533)
									{
										continue;
									}
								}
								else if (this.$$switch$7632$42186 == 3)
								{
									if (50208 - 579797 != -529589)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (192136 - 170702 != 21434)
									{
										continue;
									}
								}
								else if (this.$$switch$7632$42186 == 4)
								{
									if (173907 - 341125 != -167218)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (27286 - 429911 == -402624)
									{
										continue;
									}
								}
								else if (this.$$switch$7632$42186 == 5)
								{
									if (54766 - 291224 == -236457)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (185114 - 193458 != -8344)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (237691 - 525913 == -288221)
									{
										continue;
									}
								}
								this.$mGameGui$42187 = (GameGui)this.$self_$42188.GetComponent(typeof(GameGui));
								if (281029 - 316663 == -35634)
								{
									if (this.$mGameGui$42187)
									{
										if (186714 - 36556 == 150159)
										{
											continue;
										}
										this.$mGameGui$42187.close();
										if (45769 - 65354 == -19584)
										{
											continue;
										}
									}
									this.$self_$42188.SendMessage("fadeOut");
									if (206027 - 586896 == -380869)
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

			// Token: 0x060096C0 RID: 38592 RVA: 0x011CCEFC File Offset: 0x011CB0FC
			internal static bool LeVdKBVEjq8ryHaMJHNw()
			{
				return true;
			}

			// Token: 0x060096C1 RID: 38593 RVA: 0x011CCF00 File Offset: 0x011CB100
			internal static bool x15awMVEhEnn2R5skHUD()
			{
				return false;
			}

			// Token: 0x04008C43 RID: 35907
			internal int $$switch$7632$42186;

			// Token: 0x04008C44 RID: 35908
			internal GameGui $mGameGui$42187;

			// Token: 0x04008C45 RID: 35909
			internal M914_GuildUnderAttack $self_$42188;
		}
	}
}
