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

// Token: 0x02001A7D RID: 6781
[Serializable]
public class M926_WhenWindStops : MonoBehaviour
{
	// Token: 0x06009E1F RID: 40479 RVA: 0x0123BD9C File Offset: 0x01239F9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M926_WhenWindStops()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06009E20 RID: 40480 RVA: 0x0123BDAC File Offset: 0x01239FAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (105966 - 149081 != -43114)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (123660 - 199890 == -76230)
			{
				Game.mGameType = 5;
				if (53430 - 276143 == -222713)
				{
					if (Chat.Initialized)
					{
						if (216838 - 200333 != 16506)
						{
							Chat.ChatDisplay.Clear();
							if (6122 - 573277 == -567155)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (167729 - 167603 != 127)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009E21 RID: 40481 RVA: 0x0123BE90 File Offset: 0x0123A090
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (163723 - 238807 != -75083)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (83067 - 233400 != -150332)
				{
					if (Game.mNextGameCode != 926)
					{
						break;
					}
					if (201873 - 584331 != -382457)
					{
						Game.nextGame();
						if (145312 - 471600 != -326287)
						{
							Game.mGameCode = 926;
							if (30627 - 371864 == -341237)
							{
								Game.mGameType = 5;
								if (225962 - 480049 == -254087)
								{
									Game.mGameTime = Time.time;
									if (296931 - 410255 != -113323)
									{
										Game.mGameScore = 0;
										if (110720 - 405215 == -294495)
										{
											Game.mGameMana = 0;
											if (221997 - 138910 != 83088)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (238683 - 578114 == -339431)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (288298 - 201224 == 87074)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (216937 - 187717 == 29220)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (282104 - 449696 == -167592)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (74113 - 61306 != 12808)
																{
																	this.BCjnI7kgeFE = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (59123 - 599700 != -540576)
																	{
																		this.BCjnI7kgeFE.enabled = false;
																		if (209022 - 67444 == 141578)
																		{
																			this.YVmnIHUH73B = PhotonClient.Connection;
																			if (87685 - 48197 != 39489)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (287073 - 93072 != 194002)
																				{
																					this.InitGame();
																					if (249243 - 526836 == -277593)
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
				if (126889 - 133580 != -6690)
				{
					Game.mGameType = 99;
					if (203212 - 586201 == -382989)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009E22 RID: 40482 RVA: 0x0123C1BC File Offset: 0x0123A3BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (294297 - 186998 != 107300)
		{
		}
		for (;;)
		{
			if (this.YVmnIHUH73B == null)
			{
				if (200468 - 158106 == 42362)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (204602 - 305072 != -100469)
				{
					if (mGameState == eGameState.Init)
					{
						if (119036 - 26761 != 92276)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (95329 - 403019 == -307690)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (130387 - 581473 == -451086)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (150915 - 569237 == -418322)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (205286 - 39507 == 165779)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (266497 - 76998 != 189500)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (99556 - 597321 == -497765)
						{
							if (Game.music != 0)
							{
								if (60897 - 462408 == -401510)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (277127 - 236883 != 40244)
									{
										continue;
									}
									this.audio.Play();
									if (264437 - 491419 != -226982)
									{
										continue;
									}
								}
							}
							this.audio.volume = 0.1f * (float)Game.music;
							if (190405 - 283077 != -92671)
							{
								if (Time.time > this.FZsnIZeOHmP)
								{
									if (145515 - 28039 != 117476)
									{
										continue;
									}
									Game.mGameMana++;
									if (163087 - 351404 == -188316)
									{
										continue;
									}
									this.FZsnIZeOHmP = Time.time + (float)12;
									if (287173 - 90410 == 196764)
									{
										continue;
									}
								}
								this.GameEventUpdate();
								if (113704 - 588204 == -474500)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (127310 - 125956 != 1355)
						{
							this.GameEventUpdate();
							if (44752 - 190614 != -145861)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (20674 - 424364 == -403690)
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
						if (85831 - 287974 != -202142)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009E23 RID: 40483 RVA: 0x0123C528 File Offset: 0x0123A728
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GameEventUpdate()
	{
		if (249638 - 163498 != 86140)
		{
		}
		while (Time.time - Game.mStateTime > (float)600)
		{
			if (254309 - 145981 == 108328)
			{
				Game.mGameState = eGameState.AllHold;
				if (6636 - 475440 != -468803)
				{
					Game.sendMissionEvent(9263, 1);
					if (100868 - 71366 == 29502)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009E24 RID: 40484 RVA: 0x0123C5D8 File Offset: 0x0123A7D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (236058 - 284603 != -48545)
		{
		}
		for (;;)
		{
			if (!this.K62nICiWBd7)
			{
				if (2502 - 423299 == -420797)
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
				if (263045 - 576591 == -313546)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (210943 - 555429 == -344486)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (155078 - 139564 != 15515)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (235078 - 529237 != -294158)
							{
								GUI.depth = 1;
								if (39375 - 84578 == -45203)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (137904 - 365604 == -227700)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (162459 - 346482 != -184022)
										{
											Color color = GUI.color;
											if (52690 - 396870 == -344180)
											{
												float num3 = color.a = a;
												if (291850 - 241503 == 50347)
												{
													if (120912 - 451976 != -331063)
													{
														GUI.color = color;
														if (197009 - 383987 == -186978)
														{
															if (249040 - 355736 == -106696)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.K62nICiWBd7);
																if (28423 - 493520 == -465097)
																{
																	float a2 = 1f;
																	if (127911 - 291349 != -163437)
																	{
																		Color color2 = GUI.color;
																		if (257370 - 308076 != -50705)
																		{
																			color2.a = a2;
																			if (239543 - 557288 == -317745)
																			{
																				if (214619 - 118127 == 96492)
																				{
																					GUI.color = color2;
																					if (178000 - 9265 == 168735)
																					{
																						if (143966 - 469553 != -325586)
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

	// Token: 0x06009E25 RID: 40485 RVA: 0x0123C958 File Offset: 0x0123AB58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (238435 - 533009 != -294573)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (94725 - 83465 == 11260)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (237078 - 117206 == 119872)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (210243 - 26929 == 183314)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (101255 - 390587 != -289331)
						{
							int num4 = num;
							if (219419 - 489759 != -270339)
							{
								if (num4 == 9261)
								{
									if (219932 - 541571 != -321638)
									{
										break;
									}
								}
								else if (num4 == -9261)
								{
									if (258357 - 1129 == 257228)
									{
										if (num3 != PlayerData.UID)
										{
											break;
										}
										if (246517 - 427601 != -181083)
										{
											GameObject gameObject = GameObject.Find("WindGod");
											if (271123 - 490427 != -219303)
											{
												if (!gameObject)
												{
													break;
												}
												if (248623 - 555452 == -306829)
												{
													this.createActor("WindGod_faint", 1, gameObject.transform.position, gameObject.transform.forward);
													if (164287 - 69805 == 94482)
													{
														break;
													}
												}
											}
										}
									}
								}
								else if (num4 == 9262)
								{
									if (162746 - 333047 != -170300)
									{
										this.Cs8nIfl0BGW++;
										if (99112 - 511413 == -412301)
										{
											this.SendMessage("newGameMessage", "Mission Objective: Robot destroyed:" + this.Cs8nIfl0BGW + "/60");
											if (136800 - 438823 == -302023)
											{
												Chat.SubmitChat("none", "Robot destroyed:" + this.Cs8nIfl0BGW + "/60", eChatType.system, eChatMode.system);
												if (19203 - 303048 == -283845)
												{
													if (this.Cs8nIfl0BGW >= 60)
													{
														if (249507 - 493334 == -243827)
														{
															Game.sendMissionEvent(9263, 1);
															if (48419 - 418170 != -369750)
															{
																break;
															}
														}
													}
													else
													{
														if (num3 != PlayerData.UID)
														{
															break;
														}
														if (211830 - 53849 == 157981)
														{
															if (this.Cs8nIfl0BGW < 20)
															{
																if (193314 - 20878 == 172436)
																{
																	int num5 = UnityEngine.Random.Range(0, 4);
																	if (185540 - 326813 == -141273)
																	{
																		if (num5 == 1)
																		{
																			if (118070 - 234738 == -116668)
																			{
																				this.spawnActor("CutBot", 9, this.Cs8nIfl0BGW % 9 + 1);
																				if (41765 - 151958 != -110192)
																				{
																					break;
																				}
																			}
																		}
																		else if (num5 == 2)
																		{
																			if (62879 - 23402 != 39478)
																			{
																				this.spawnActor("CarryBot", 9, this.Cs8nIfl0BGW % 9 + 1);
																				if (116412 - 48475 == 67937)
																				{
																					break;
																				}
																			}
																		}
																		else if (num5 == 3)
																		{
																			if (156482 - 193313 == -36831)
																			{
																				this.spawnActor("MissileBot", 9, this.Cs8nIfl0BGW % 9 + 1);
																				if (170874 - 197085 != -26210)
																				{
																					break;
																				}
																			}
																		}
																		else
																		{
																			this.spawnActor("CamBot", 9, this.Cs8nIfl0BGW % 9 + 1);
																			if (34554 - 32051 == 2503)
																			{
																				break;
																			}
																		}
																	}
																}
															}
															else if (this.Cs8nIfl0BGW < 40)
															{
																if (200181 - 201465 == -1284)
																{
																	int num6 = UnityEngine.Random.Range(0, 5);
																	if (224354 - 316258 != -91903)
																	{
																		if (num6 == 1)
																		{
																			if (167888 - 391843 != -223954)
																			{
																				this.spawnActor("CutBot", 9, this.Cs8nIfl0BGW % 9 + 1);
																				if (207618 - 76613 != 131006)
																				{
																					break;
																				}
																			}
																		}
																		else if (num6 == 2)
																		{
																			if (295552 - 48965 == 246587)
																			{
																				this.spawnActor("CarryBot", 9, this.Cs8nIfl0BGW % 9 + 1);
																				if (276714 - 420679 == -143965)
																				{
																					break;
																				}
																			}
																		}
																		else if (num6 == 3)
																		{
																			if (82985 - 381654 == -298669)
																			{
																				this.spawnActor("FireBot", 9, this.Cs8nIfl0BGW % 9 + 1);
																				if (151464 - 160975 == -9511)
																				{
																					break;
																				}
																			}
																		}
																		else if (num6 == 4)
																		{
																			if (54722 - 188448 != -133725)
																			{
																				this.spawnActor("MissileBot", 9, this.Cs8nIfl0BGW % 9 + 1);
																				if (157429 - 136170 != 21260)
																				{
																					break;
																				}
																			}
																		}
																		else
																		{
																			this.spawnActor("CamBot", 9, this.Cs8nIfl0BGW % 9 + 1);
																			if (144083 - 175832 != -31748)
																			{
																				break;
																			}
																		}
																	}
																}
															}
															else
															{
																if (this.Cs8nIfl0BGW > 50)
																{
																	break;
																}
																if (56538 - 491792 == -435254)
																{
																	int num7 = UnityEngine.Random.Range(0, 6);
																	if (79142 - 325196 == -246054)
																	{
																		if (num7 == 1)
																		{
																			if (197628 - 405425 == -207797)
																			{
																				this.spawnActor("CutBot", 9, this.Cs8nIfl0BGW % 9 + 1);
																				if (228073 - 187181 != 40893)
																				{
																					break;
																				}
																			}
																		}
																		else if (num7 == 2)
																		{
																			if (281760 - 471890 != -190129)
																			{
																				this.spawnActor("CarryBot", 9, this.Cs8nIfl0BGW % 9 + 1);
																				if (222996 - 117412 != 105585)
																				{
																					break;
																				}
																			}
																		}
																		else if (num7 == 3)
																		{
																			if (103987 - 424477 != -320489)
																			{
																				this.spawnActor("FireBot", 9, this.Cs8nIfl0BGW % 9 + 1);
																				if (118873 - 523769 != -404895)
																				{
																					break;
																				}
																			}
																		}
																		else if (num7 == 4)
																		{
																			if (173324 - 275555 == -102231)
																			{
																				this.spawnActor("MissileBot", 9, this.Cs8nIfl0BGW % 9 + 1);
																				if (205619 - 15535 != 190085)
																				{
																					break;
																				}
																			}
																		}
																		else if (num7 == 5)
																		{
																			if (162540 - 348048 == -185508)
																			{
																				this.spawnActor("SiegeBot", 9, this.Cs8nIfl0BGW % 9 + 1);
																				if (41918 - 123199 == -81281)
																				{
																					break;
																				}
																			}
																		}
																		else
																		{
																			this.spawnActor("CamBot", 9, this.Cs8nIfl0BGW % 9 + 1);
																			if (222847 - 422516 == -199669)
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
								else if (num4 == 9263)
								{
									if (271130 - 52563 != 218568)
									{
										break;
									}
								}
								else
								{
									Debug.LogError("Warning unknown returnCode:" + num);
									if (227670 - 484396 == -256726)
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

	// Token: 0x06009E26 RID: 40486 RVA: 0x0123D2D0 File Offset: 0x0123B4D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M926_WhenWindStops.$StartEvent$43124(this).GetEnumerator();
	}

	// Token: 0x06009E27 RID: 40487 RVA: 0x0123D2E0 File Offset: 0x0123B4E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (195926 - 66564 != 129363)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (101688 - 277786 == -176098)
			{
				Time.timeScale = 1f;
				if (131293 - 54249 != 77045)
				{
					this.K62nICiWBd7 = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (55647 - 50650 != 4998)
					{
						Hashtable customOpParameters = new Hashtable();
						if (91216 - 303881 != -212664)
						{
							this.YVmnIHUH73B.OpCustom(52, customOpParameters, true);
							if (253121 - 96803 != 156319)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009E28 RID: 40488 RVA: 0x0123D3E4 File Offset: 0x0123B5E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (93047 - 381737 != -288689)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (22380 - 261410 != -239029)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (268211 - 149060 != 119152)
				{
					Game.mGameState = eGameState.Setup;
					if (223544 - 393437 != -169892)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009E29 RID: 40489 RVA: 0x0123D488 File Offset: 0x0123B688
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (53737 - 596273 != -542536)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (115657 - 352182 == -236525)
			{
				if (num == PlayerData.UID)
				{
					if (254076 - 123983 != 130094)
					{
						this.SetupActors();
						if (231641 - 230755 == 886)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (118188 - 577269 != -459080)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009E2A RID: 40490 RVA: 0x0123D558 File Offset: 0x0123B758
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (206212 - 293709 != -87497)
		{
		}
		for (;;)
		{
			IL_2AE:
			Debug.Log("Creating Actors");
			if (297420 - 554026 == -256606)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (115202 - 591430 != -476227)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (149674 - 258533 != -108858)
						{
							int i = 0;
							if (50479 - 345356 != -294876)
							{
								CharacterControl[] array2 = array;
								if (215615 - 16330 == 199285)
								{
									int length = array2.Length;
									if (198530 - 562937 != -364406)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (90745 - 396732 == -305986)
												{
													goto IL_2AE;
												}
												string type = array2[i].Type;
												if (38107 - 39212 == -1104)
												{
													goto IL_2AE;
												}
												if (type == "CamBot")
												{
													goto IL_1EC;
												}
												if (123377 - 254002 != -130625)
												{
													goto IL_2AE;
												}
												if (type == "CutBot")
												{
													goto IL_1EC;
												}
												if (16639 - 90523 != -73884)
												{
													goto IL_2AE;
												}
												if (type == "CarryBot")
												{
													goto IL_1EC;
												}
												if (49282 - 418373 != -369091)
												{
													goto IL_2AE;
												}
												if (type == "MissileBot")
												{
													if (117057 - 93273 != 23785)
													{
														goto IL_1EC;
													}
													goto IL_2AE;
												}
												IL_7B:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (163690 - 310136 != -146446)
												{
													goto IL_2AE;
												}
												this.cQNnILWeai0++;
												if (192990 - 212321 != -19331)
												{
													goto IL_2AE;
												}
												goto IL_266;
												IL_1EC:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (168384 - 563655 != -395271)
												{
													goto IL_2AE;
												}
												goto IL_7B;
											}
											IL_266:
											i++;
											if (73827 - 542617 == -468789)
											{
												goto IL_2AE;
											}
										}
										if (107093 - 362586 != -255492)
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
						if (84203 - 23779 != 60425)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009E2B RID: 40491 RVA: 0x0123D874 File Offset: 0x0123BA74
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (272862 - 109307 != 163555)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (173185 - 468202 != -295016)
			{
				int i = 0;
				if (129742 - 425918 == -296176)
				{
					CharacterControl[] array2 = array;
					if (29278 - 454261 != -424982)
					{
						int length = array2.Length;
						if (45216 - 526728 == -481512)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (591 - 324364 != -323773)
								{
									goto IL_E0;
								}
								i++;
								if (235570 - 456058 != -220488)
								{
									goto IL_E0;
								}
							}
							if (281354 - 40127 != 241228)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009E2C RID: 40492 RVA: 0x0123D9A4 File Offset: 0x0123BBA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (258327 - 147798 != 110529)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (82403 - 56276 != 26128)
			{
				Game.mGameState = eGameState.Ready;
				if (55082 - 531434 != -476351)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (77572 - 251306 == -173734)
					{
						if (270273 - 100244 != 170030)
						{
							GameObject gameObject = null;
							if (171902 - 236281 == -64379)
							{
								if (playerSlot < 1)
								{
									goto IL_1F1;
								}
								if (274568 - 599820 == -325251)
								{
									continue;
								}
								if (playerSlot > 12)
								{
									goto IL_1F1;
								}
								if (40737 - 403006 == -362268)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (45606 - 71479 == -25872)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (290415 - 314575 == -24159)
								{
									continue;
								}
								IL_103:
								if (gameObject2)
								{
									if (247125 - 353546 == -106420)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (292611 - 78380 == 214232)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (262516 - 320346 == -57829)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (84150 - 437523 == -353372)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (290104 - 467179 == -177074)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (232749 - 155882 == 76868)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (84895 - 247147 == -162251)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (10272 - 481457 != -471184)
								{
									break;
								}
								continue;
								IL_1F1:
								gameObject2 = GameObject.Find("StartPoint1");
								if (8533 - 231345 != -222811)
								{
									goto IL_103;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009E2D RID: 40493 RVA: 0x0123DCC8 File Offset: 0x0123BEC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		Debug.Log("Start Game");
		this.StartCoroutine_Auto(this.StartEvent());
	}

	// Token: 0x06009E2E RID: 40494 RVA: 0x0123DCE4 File Offset: 0x0123BEE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06009E2F RID: 40495 RVA: 0x0123DCE8 File Offset: 0x0123BEE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (248313 - 436468 != -188155)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (25611 - 525208 != -499596)
			{
				if (gameObject)
				{
					if (4327 - 453473 == -449146)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (119464 - 556202 == -436738)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (125044 - 312768 == -187724)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009E30 RID: 40496 RVA: 0x0123DDE4 File Offset: 0x0123BFE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (10760 - 451657 != -440897)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (103790 - 85207 == 18583)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (103275 - 327793 != -224517)
				{
					hashtable.Add(43, PlayerData.UID);
					if (92052 - 40550 != 51503)
					{
						hashtable.Add(73, nType);
						if (205690 - 322255 != -116564)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (28250 - 365009 == -336759)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (194228 - 241202 == -46974)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (229038 - 320632 != -91593)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (73222 - 253204 == -179982)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (191243 - 151469 == 39774)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (66944 - 47851 != 19094)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (102437 - 258666 != -156228)
													{
														this.YVmnIHUH73B.OpCustom(63, hashtable, true);
														if (128099 - 271893 != -143793)
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

	// Token: 0x06009E31 RID: 40497 RVA: 0x0123E0C8 File Offset: 0x0123C2C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (164301 - 102231 != 62070)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (71912 - 40679 == 31233)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (106608 - 324434 == -217826)
				{
					object lhs = data[73];
					if (247436 - 153034 != 94403)
					{
						if (RuntimeServices.EqualityOperator(lhs, "WindGod_faint"))
						{
							if (44255 - 518149 != -473894)
							{
								continue;
							}
							GameObject gameObject2 = GameObject.Find("WindGod");
							if (55479 - 49336 != 6143)
							{
								continue;
							}
							if (gameObject2)
							{
								if (116940 - 566522 == -449581)
								{
									continue;
								}
								UnityEngine.Object.Destroy(gameObject2);
								if (37694 - 29154 != 8540)
								{
									continue;
								}
							}
							CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (73376 - 178256 == -104879)
							{
								continue;
							}
							if (characterControl)
							{
								if (234821 - 68899 != 165922)
								{
									continue;
								}
								characterControl.hp = Mathf.FloorToInt(0.03f * (float)characterControl.mhp);
								if (104464 - 366747 == -262282)
								{
									continue;
								}
							}
						}
						if (Game.mGameState == eGameState.Setup)
						{
							if (261406 - 380149 == -118743)
							{
								if (this.cQNnILWeai0 <= 0)
								{
									break;
								}
								if (288620 - 376930 == -88310)
								{
									this.cQNnILWeai0--;
									if (32579 - 442971 == -410392)
									{
										if (this.cQNnILWeai0 != 0)
										{
											break;
										}
										if (153672 - 565815 == -412143)
										{
											Game.setGameState(eGameState.Ready);
											if (113911 - 571513 != -457601)
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
							if (108183 - 370969 != -262785)
							{
								gameObject.SendMessage("createSpecialEffect", 1);
								if (264054 - 126327 == 137727)
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

	// Token: 0x06009E32 RID: 40498 RVA: 0x0123E3A0 File Offset: 0x0123C5A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06009E33 RID: 40499 RVA: 0x0123E3B4 File Offset: 0x0123C5B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (215267 - 441531 != -226264)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (92026 - 277479 == -185453)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (59161 - 152084 == -92923)
				{
					if (!characterControl)
					{
						break;
					}
					if (201376 - 284662 != -83285)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (35076 - 30027 != 5050)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (106329 - 117293 == -10964)
							{
								string type = characterControl.Type;
								if (167632 - 27241 != 140392)
								{
									if (!(type == "CamBot"))
									{
										if (276503 - 140474 == 136030)
										{
											continue;
										}
										if (!(type == "CutBot"))
										{
											if (112626 - 42215 != 70411)
											{
												continue;
											}
											if (!(type == "CarryBot"))
											{
												if (264959 - 224226 == 40734)
												{
													continue;
												}
												if (!(type == "MissileBot"))
												{
													if (195038 - 329493 == -134454)
													{
														continue;
													}
													if (!(type == "FireBot"))
													{
														if (103235 - 322987 != -219752)
														{
															continue;
														}
														if (!(type == "SiegeBot"))
														{
															if (247225 - 174276 != 72949)
															{
																continue;
															}
															if (type == "CarrierBot")
															{
																if (254874 - 419481 != -164607)
																{
																	continue;
																}
															}
															else
															{
																if (!(type == "WindGod_faint"))
																{
																	break;
																}
																if (28759 - 483790 != -455031)
																{
																	continue;
																}
																Game.sendMissionEvent(9263, -1);
																if (208669 - 597417 != -388748)
																{
																	continue;
																}
																break;
															}
														}
													}
												}
											}
										}
									}
									Game.sendMissionEvent(9262, 1);
									if (181684 - 419196 != -237511)
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

	// Token: 0x06009E34 RID: 40500 RVA: 0x0123E67C File Offset: 0x0123C87C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (284755 - 232615 != 52140)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (274494 - 581165 != -306670)
			{
				hashtable.Add(71, CID);
				if (239769 - 461082 != -221312)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (163008 - 347228 == -184220)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (23460 - 192018 == -168558)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (57744 - 5957 == 51787)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (204460 - 405951 != -201490)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (282060 - 353909 == -71849)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (288421 - 332827 == -44406)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (247726 - 491323 != -243596)
											{
												this.YVmnIHUH73B.OpCustom(61, hashtable, true);
												if (75596 - 429980 != -354383)
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

	// Token: 0x06009E35 RID: 40501 RVA: 0x0123E908 File Offset: 0x0123CB08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (28081 - 238951 != -210869)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (290271 - 194657 != 95615)
			{
				if (!gameObject)
				{
					break;
				}
				if (26729 - 277515 == -250786)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (225668 - 412260 != -186591)
					{
						playerCameraControl.target = gameObject;
						if (189221 - 558542 == -369321)
						{
							this.StartGame();
							if (50096 - 122438 != -72341)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009E36 RID: 40502 RVA: 0x0123E9F8 File Offset: 0x0123CBF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (12048 - 404285 != -392237)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (276183 - 376619 == -100436)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (257153 - 209840 == 47313)
				{
					gameGui.ResetTeamBar();
					if (150031 - 514503 != -364471)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009E37 RID: 40503 RVA: 0x0123EAA4 File Offset: 0x0123CCA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M926_WhenWindStops.$onDeadPlayer$43134(this).GetEnumerator();
	}

	// Token: 0x06009E38 RID: 40504 RVA: 0x0123EAB4 File Offset: 0x0123CCB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (135711 - 333011 != -197299)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (7235 - 1143 != 6093)
			{
				this.BCjnI7kgeFE.target = Game.mPlayer;
				if (83684 - 86664 != -2979)
				{
					this.BCjnI7kgeFE.enabled = true;
					if (246611 - 519705 == -273094)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (134020 - 98249 == 35772)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (97174 - 471003 == -373828)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (54364 - 83188 == -28824)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (36097 - 40341 != -4243)
							{
								if (!gameGui)
								{
									break;
								}
								if (40003 - 188979 == -148976)
								{
									gameGui.enabled = true;
									if (74716 - 25314 == 49402)
									{
										gameGui.closeDeadMenu();
										if (178984 - 427162 != -248177)
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

	// Token: 0x06009E39 RID: 40505 RVA: 0x0123EC60 File Offset: 0x0123CE60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (63099 - 224597 != -161497)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (36601 - 547204 != -510602)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (24134 - 497443 != -473308)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (191597 - 281046 == -89449)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009E3A RID: 40506 RVA: 0x0123ED24 File Offset: 0x0123CF24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06009E3B RID: 40507 RVA: 0x0123ED50 File Offset: 0x0123CF50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (290932 - 465014 != -174082)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (20535 - 566805 != -546269)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (213590 - 352411 != -138820)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (47488 - 305270 == -257782)
					{
						Hashtable hashtable = new Hashtable();
						if (233658 - 521943 == -288285)
						{
							hashtable.Add(43, PlayerData.UID);
							if (199163 - 271967 == -72804)
							{
								hashtable.Add(71, nCID);
								if (29971 - 111714 != -81742)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (179964 - 62705 != 117260)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (201329 - 446781 != -245451)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (173910 - 202719 == -28809)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (154775 - 99221 == 55554)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (177299 - 324855 == -147556)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (43260 - 560001 != -516740)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (79152 - 123309 == -44157)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (35768 - 12495 == 23273)
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

	// Token: 0x06009E3C RID: 40508 RVA: 0x0123F070 File Offset: 0x0123D270
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M926_WhenWindStops.$onChangePlayer$43140(data, this).GetEnumerator();
	}

	// Token: 0x06009E3D RID: 40509 RVA: 0x0123F080 File Offset: 0x0123D280
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M926_WhenWindStops.$onGameComplete$43147(data, this).GetEnumerator();
	}

	// Token: 0x06009E3E RID: 40510 RVA: 0x0123F090 File Offset: 0x0123D290
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M926_WhenWindStops.$ReturnToTown$43157(this).GetEnumerator();
	}

	// Token: 0x06009E3F RID: 40511 RVA: 0x0123F0A0 File Offset: 0x0123D2A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M926_WhenWindStops.$ReturnToGuild$43162(this).GetEnumerator();
	}

	// Token: 0x06009E40 RID: 40512 RVA: 0x0123F0B0 File Offset: 0x0123D2B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M926_WhenWindStops.$ReturnToCamp$43166(this).GetEnumerator();
	}

	// Token: 0x06009E41 RID: 40513 RVA: 0x0123F0C0 File Offset: 0x0123D2C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (120121 - 430091 != -309970)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (111585 - 147838 != -36252)
			{
				Hashtable hashtable = new Hashtable();
				if (59915 - 410400 == -350485)
				{
					hashtable.Add(43, PlayerData.UID);
					if (131578 - 161761 != -30182)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (256322 - 347012 != -90689)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009E42 RID: 40514 RVA: 0x0123F198 File Offset: 0x0123D398
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06009E43 RID: 40515 RVA: 0x0123F1AC File Offset: 0x0123D3AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (247502 - 446665 != -199162)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (125292 - 86198 != 39095)
			{
				Hashtable hashtable = new Hashtable();
				if (236347 - 577239 != -340891)
				{
					if (Game.mNextGameCode == 30)
					{
						if (217849 - 17681 != 200168)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (132221 - 543465 != -411244)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (154569 - 192173 != -37604)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (193354 - 55178 != 138176)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (68837 - 241583 != -172746)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (121190 - 415830 == -294639)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (47496 - 64035 == -16538)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (289543 - 529531 != -239988)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (155737 - 557645 == -401907)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (118446 - 477679 == -359232)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (38085 - 516824 == -478738)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (104462 - 316985 == -212522)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (11303 - 265912 == -254608)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (209572 - 340777 == -131204)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (272181 - 574795 == -302613)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (285929 - 30671 == 255259)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (29955 - 63178 == -33222)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (200184 - 482157 != -281973)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (280445 - 496302 == -215856)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (172266 - 597867 != -425601)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (184608 - 37155 == 147454)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (279665 - 116278 == 163388)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (201845 - 253144 != -51299)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (55148 - 255318 != -200170)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (235823 - 367231 == -131407)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (174206 - 446014 != -271808)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (2613 - 502735 == -500121)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (98048 - 319795 == -221746)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (68777 - 116195 != -47417)
					{
						this.YVmnIHUH73B.OpCustom(42, hashtable, true);
						if (115611 - 516112 != -400500)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009E44 RID: 40516 RVA: 0x0123F760 File Offset: 0x0123D960
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06009E45 RID: 40517 RVA: 0x0123F770 File Offset: 0x0123D970
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009E46 RID: 40518 RVA: 0x0123F774 File Offset: 0x0123D974
	internal static bool kCOOlJVxqBSe1kx1yVXM()
	{
		return true;
	}

	// Token: 0x06009E47 RID: 40519 RVA: 0x0123F778 File Offset: 0x0123D978
	internal static bool C4bTi0Vx7mtlevqpj1jS()
	{
		return false;
	}

	// Token: 0x04009045 RID: 36933
	private LitePeer YVmnIHUH73B;

	// Token: 0x04009046 RID: 36934
	private PlayerCameraControl BCjnI7kgeFE;

	// Token: 0x04009047 RID: 36935
	private float FZsnIZeOHmP;

	// Token: 0x04009048 RID: 36936
	private Texture K62nICiWBd7;

	// Token: 0x04009049 RID: 36937
	private int LM5nIMs01BR;

	// Token: 0x0400904A RID: 36938
	private int Cs8nIfl0BGW;

	// Token: 0x0400904B RID: 36939
	public GameObject CamBotExplosion;

	// Token: 0x0400904C RID: 36940
	public AudioClip MissionMusic;

	// Token: 0x0400904D RID: 36941
	public AudioClip talk_vc;

	// Token: 0x0400904E RID: 36942
	public AudioClip chat_vc;

	// Token: 0x0400904F RID: 36943
	public AudioClip ko_vc;

	// Token: 0x04009050 RID: 36944
	private int cQNnILWeai0;

	// Token: 0x02001A7E RID: 6782
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$43124 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009E48 RID: 40520 RVA: 0x0123F77C File Offset: 0x0123D97C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$43124(M926_WhenWindStops self_)
		{
			if (60167 - 452745 != -392578)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (42228 - 398563 == -356335)
				{
					base..ctor();
					if (111526 - 140995 != -29468)
					{
						this.$self_$43133 = self_;
						if (73067 - 134913 == -61846)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009E49 RID: 40521 RVA: 0x0123F814 File Offset: 0x0123DA14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M926_WhenWindStops.$StartEvent$43124.$(this.$self_$43133);
		}

		// Token: 0x06009E4A RID: 40522 RVA: 0x0123F824 File Offset: 0x0123DA24
		internal static bool uOD4WNVxPqm0E7ZI0L5f()
		{
			return true;
		}

		// Token: 0x06009E4B RID: 40523 RVA: 0x0123F828 File Offset: 0x0123DA28
		internal static bool HOJ1sqVx0nPh1Gc9a0HZ()
		{
			return false;
		}

		// Token: 0x04009051 RID: 36945
		internal M926_WhenWindStops $self_$43133;

		// Token: 0x02001A7F RID: 6783
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009E4C RID: 40524 RVA: 0x0123F82C File Offset: 0x0123DA2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M926_WhenWindStops self_)
			{
				if (236343 - 303493 != -67149)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (220673 - 12451 == 208222)
					{
						base..ctor();
						if (114580 - 402762 != -288181)
						{
							this.$self_$43132 = self_;
							if (363 - 195475 != -195111)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009E4D RID: 40525 RVA: 0x0123F8C4 File Offset: 0x0123DAC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (298913 - 500043 != -201129)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_7A8;
					case 1:
						goto IL_132D;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (282733 - 153508 != 129225)
							{
								continue;
							}
							goto IL_505;
						}
						else
						{
							this.$mStoryGui$43129 = (StoryGui)this.$self_$43132.GetComponent(typeof(StoryGui));
							if (87491 - 386650 != -299159)
							{
								continue;
							}
							if (!this.$mStoryGui$43129)
							{
								if (173765 - 360626 != -186860)
								{
									goto Block_91;
								}
								continue;
							}
							else
							{
								this.$mStoryGui$43129.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
								if (63589 - 372078 != -308489)
								{
									continue;
								}
								goto IL_B0B;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (246264 - 594556 != -348292)
							{
								continue;
							}
							goto IL_948;
						}
						else
						{
							this.$mStoryGui$43129.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M926_WhenWindStops", 101), eTalkType.friend);
							if (82185 - 449861 != -367675)
							{
								goto Block_62;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (270761 - 410479 != -139717)
							{
								goto Block_117;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43129.blank();
							if (251392 - 203708 != 47684)
							{
								continue;
							}
							this.$self_$43132.BCjnI7kgeFE.StartCoroutine_Auto(this.$self_$43132.BCjnI7kgeFE.slerpToObject("EventCamera2", 2.5f));
							if (8718 - 592538 != -583820)
							{
								continue;
							}
							goto IL_E0A;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (24679 - 355710 != -331031)
							{
								continue;
							}
							goto IL_81;
						}
						else
						{
							this.$mStoryGui$43129.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M926_WhenWindStops", 102), eTalkType.friend);
							if (68526 - 199932 != -131406)
							{
								continue;
							}
							this.$self_$43132.audio.Play();
							if (293921 - 35046 != 258875)
							{
								continue;
							}
							goto IL_187;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (191154 - 507724 != -316569)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43129.newStoryMessage("WindGod", "Sun Sun", Language.getMessage("M926_WhenWindStops", 103), eTalkType.friend);
							if (299070 - 411815 == -112744)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("nvoice", 1) == 0)
							{
								goto IL_A0C;
							}
							if (252449 - 336848 == -84398)
							{
								continue;
							}
							if (this.$self_$43132.talk_vc)
							{
								if (64694 - 305940 != -241246)
								{
									continue;
								}
								this.$self_$43132.audio.PlayOneShot(this.$self_$43132.talk_vc);
								if (97861 - 458086 != -360225)
								{
									continue;
								}
								goto IL_598;
							}
							else
							{
								Debug.LogError("Cannot find talk voice");
								if (28738 - 213225 != -184486)
								{
									goto Block_39;
								}
								continue;
							}
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (226886 - 544926 != -318039)
							{
								goto Block_66;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43129.newStoryMessage("WindGod", "Sun Sun", Language.getMessage("M926_WhenWindStops", 104), eTalkType.friend);
							if (41467 - 6886 == 34582)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("nvoice", 1) != 0)
							{
								if (44238 - 45799 != -1561)
								{
									continue;
								}
								if (this.$self_$43132.chat_vc)
								{
									if (96474 - 278759 != -182285)
									{
										continue;
									}
									this.$self_$43132.audio.PlayOneShot(this.$self_$43132.chat_vc);
									if (72756 - 574922 == -502165)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find chat voice");
									if (291251 - 276849 != 14402)
									{
										continue;
									}
								}
							}
							if (!this.$mFloatCamBot$43127)
							{
								goto IL_8B4;
							}
							if (102311 - 544481 != -442170)
							{
								continue;
							}
							this.$mFloatCamBot$43127.animation.CrossFade("drop", 0.2f);
							if (91302 - 244958 != -153655)
							{
								goto Block_118;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (20050 - 53535 != -33485)
							{
								continue;
							}
							goto IL_ADC;
						}
						else
						{
							if (!this.$mFloatCamBot$43127)
							{
								goto IL_BBC;
							}
							if (160909 - 283324 == -122414)
							{
								continue;
							}
							if (this.$self_$43132.CamBotExplosion)
							{
								if (29074 - 549419 != -520345)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$43132.CamBotExplosion, this.$mFloatCamBot$43127.transform.position, Quaternion.identity);
								if (103336 - 137925 != -34589)
								{
									continue;
								}
							}
							if (!this.$mFloatCamBot$43127)
							{
								goto IL_BBC;
							}
							if (236950 - 532268 != -295318)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.$mFloatCamBot$43127);
							if (159181 - 508497 != -349315)
							{
								goto Block_88;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.Start)
						{
							if (54280 - 18033 != 36247)
							{
								continue;
							}
							goto IL_7C8;
						}
						else
						{
							this.$mStoryGui$43129.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M926_WhenWindStops", 105), eTalkType.friend);
							if (84468 - 543788 == -459319)
							{
								continue;
							}
							this.$self_$43132.BCjnI7kgeFE.alignToObject("EventCamera3");
							if (190338 - 171767 != 18572)
							{
								goto Block_119;
							}
							continue;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.Start)
						{
							if (279200 - 103237 != 175963)
							{
								continue;
							}
							goto IL_9CA;
						}
						else
						{
							this.$mStoryGui$43129.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M926_WhenWindStops", 106), eTalkType.friend);
							if (53389 - 459336 != -405946)
							{
								goto Block_64;
							}
							continue;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.Start)
						{
							if (276797 - 433384 != -156587)
							{
								continue;
							}
							goto IL_FDD;
						}
						else
						{
							this.$mStoryGui$43129.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M926_WhenWindStops", 107), eTalkType.friend);
							if (272842 - 373949 != -101107)
							{
								continue;
							}
							this.$self_$43132.BCjnI7kgeFE.alignToObject("EventCamera4");
							if (249780 - 390820 == -141039)
							{
								continue;
							}
							this.$mStoryTimer$43130 = Time.time;
							if (169027 - 262119 == -93091)
							{
								continue;
							}
						}
						break;
					case 12:
						break;
					case 13:
						if (Game.mGameState != eGameState.Start)
						{
							if (241475 - 223447 != 18028)
							{
								continue;
							}
							goto IL_5C1;
						}
						else
						{
							this.$mStoryGui$43129.newStoryMessage("WindGod", "Sun Sun", Language.getMessage("M926_WhenWindStops", 109), eTalkType.friend);
							if (214960 - 4551 != 210409)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("nvoice", 1) != 0)
							{
								if (148544 - 444397 != -295853)
								{
									continue;
								}
								if (this.$self_$43132.ko_vc)
								{
									if (35341 - 265606 == -230264)
									{
										continue;
									}
									this.$self_$43132.audio.PlayOneShot(this.$self_$43132.ko_vc);
									if (76575 - 69417 == 7159)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find ko voice");
									if (217507 - 134641 != 82866)
									{
										continue;
									}
								}
							}
							this.$self_$43132.BCjnI7kgeFE.StartCoroutine_Auto(this.$self_$43132.BCjnI7kgeFE.slerpToObject("EventCamera5", 1f));
							if (166279 - 559433 != -393154)
							{
								continue;
							}
							goto IL_115A;
						}
						break;
					case 14:
						if (!this.$mWindGod$43125)
						{
							goto IL_D66;
						}
						if (128282 - 457968 == -329685)
						{
							continue;
						}
						this.$mWindGod$43125.animation.Play("ko");
						if (249239 - 12716 != 236523)
						{
							continue;
						}
						this.$mWindGod$43125.animation.wrapMode = WrapMode.Once;
						if (172456 - 147516 != 24940)
						{
							continue;
						}
						goto IL_D66;
					case 15:
						if (Game.mGameState != eGameState.Start)
						{
							if (140704 - 388430 != -247725)
							{
								goto Block_93;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43129.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M926_WhenWindStops", 110), eTalkType.friend);
							if (19300 - 530694 == -511393)
							{
								continue;
							}
							this.$self_$43132.BCjnI7kgeFE.alignToObject("EventCamera6");
							if (206702 - 232389 != -25687)
							{
								continue;
							}
							if (!this.$mEarthGod$43126)
							{
								goto IL_B46;
							}
							if (125871 - 479733 != -353862)
							{
								continue;
							}
							this.$mEarthGod$43126.animation.Play("ko");
							if (255241 - 572363 != -317122)
							{
								continue;
							}
							this.$mEarthGod$43126.animation.wrapMode = WrapMode.Once;
							if (133655 - 507274 != -373618)
							{
								goto Block_80;
							}
							continue;
						}
						break;
					case 16:
						if (Game.mGameState != eGameState.Start)
						{
							if (40113 - 136167 != -96054)
							{
								continue;
							}
							goto IL_393;
						}
						else
						{
							this.$mStoryGui$43129.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M926_WhenWindStops", 111), eTalkType.friend);
							if (236731 - 145394 != 91337)
							{
								continue;
							}
							goto IL_357;
						}
						break;
					case 17:
						if (Game.mGameState != eGameState.Start)
						{
							if (169792 - 180712 != -10920)
							{
								continue;
							}
							goto IL_668;
						}
						else
						{
							this.$mStoryGui$43129.newStoryMessage("EarthGod", "Barberock", Language.getMessage("M926_WhenWindStops", 112), eTalkType.friend);
							if (256812 - 203340 != 53473)
							{
								goto Block_44;
							}
							continue;
						}
						break;
					case 18:
						if (Game.mGameState != eGameState.Start)
						{
							if (111677 - 398369 != -286692)
							{
								continue;
							}
							goto IL_CB8;
						}
						else
						{
							this.$mStoryGui$43129.close();
							if (262469 - 534199 != -271730)
							{
								continue;
							}
							this.$self_$43132.BCjnI7kgeFE.enabled = true;
							if (186011 - 320067 != -134056)
							{
								continue;
							}
							goto IL_1A;
						}
						break;
					case 19:
						if (Game.mGameState != eGameState.Start)
						{
							if (86100 - 3195 != 82906)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (295985 - 269983 != 26002)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (22275 - 278396 != -256121)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (13682 - 18855 != -5173)
							{
								continue;
							}
							this.$mGameGui$43131 = (GameGui)this.$self_$43132.GetComponent(typeof(GameGui));
							if (10026 - 250911 == -240884)
							{
								continue;
							}
							this.$mGameGui$43131.enabled = true;
							if (89554 - 128774 == -39219)
							{
								continue;
							}
							Game.sendMissionEvent(9261, 1);
							if (235619 - 506951 == -271331)
							{
								continue;
							}
							this.YieldDefault(1);
							if (242275 - 285057 != -42781)
							{
								goto Block_113;
							}
							continue;
						}
						break;
					default:
						if (283545 - 359848 != -76302)
						{
							goto IL_7A8;
						}
						continue;
					}
					if (Time.time >= this.$mStoryTimer$43130 + (float)5)
					{
						if (17254 - 79529 == -62274)
						{
							continue;
						}
						this.$mStoryGui$43129.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M926_WhenWindStops", 108), eTalkType.friend);
						if (94746 - 348350 != -253604)
						{
							continue;
						}
						if (!this.$self_$43132.MissionMusic)
						{
							goto IL_C52;
						}
						if (230050 - 209089 != 20961)
						{
							continue;
						}
						this.$self_$43132.audio.clip = this.$self_$43132.MissionMusic;
						if (127648 - 496245 != -368597)
						{
							continue;
						}
						this.$self_$43132.audio.volume = 0.1f * (float)Game.music;
						if (200609 - 409758 == -209148)
						{
							continue;
						}
						this.$self_$43132.audio.Play();
						if (124801 - 448347 != -323546)
						{
							continue;
						}
						goto IL_C52;
					}
					else
					{
						if (this.$mFakeCarrierCore$43128)
						{
							if (201357 - 521347 != -319990)
							{
								continue;
							}
							this.$mFakeCarrierCore$43128.transform.position = new Vector3((float)4, (float)58, Mathf.SmoothStep((float)150, (float)96, 0.2f * (Time.time - this.$mStoryTimer$43130)));
							if (221379 - 336404 == -115024)
							{
								continue;
							}
						}
						this.$self_$43132.audio.volume = Mathf.SmoothStep(0.1f * (float)Game.music, (float)0, 0.2f * (Time.time - this.$mStoryTimer$43130));
						if (38534 - 498152 != -459618)
						{
							continue;
						}
						goto IL_1C2;
					}
					IL_7A8:
					Game.mGameState = eGameState.Start;
					if (173909 - 484253 == -310344)
					{
						Game.mGameTime = Time.time;
						if (60289 - 370895 != -310605)
						{
							this.$mWindGod$43125 = GameObject.Find("WindGod");
							if (231377 - 231002 == 375)
							{
								this.$mEarthGod$43126 = GameObject.Find("EarthGod");
								if (151971 - 481119 != -329147)
								{
									this.$mFloatCamBot$43127 = GameObject.Find("FloatCamBot");
									if (165262 - 284529 == -119267)
									{
										this.$mFakeCarrierCore$43128 = GameObject.Find("FakeCarrierBot_core");
										if (85966 - 575283 == -489317)
										{
											if (this.$mFakeCarrierCore$43128)
											{
												if (189141 - 123918 != 65223)
												{
													continue;
												}
												this.$mFakeCarrierCore$43128.transform.position = Vector3.zero;
												if (58701 - 389210 == -330508)
												{
													continue;
												}
											}
											this.$self_$43132.BCjnI7kgeFE.alignToObject("EventCamera1");
											if (43847 - 401862 != -358014)
											{
												this.$self_$43132.SendMessage("fadeIn");
												if (167467 - 599442 == -431975)
												{
													goto IL_A47;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_1A:
				return this.Yield(19, new WaitForSeconds(0.5f));
				Block_3:
				IL_81:
				goto IL_132D;
				IL_187:
				return this.Yield(6, new WaitForSeconds(2f));
				Block_12:
				goto IL_132D;
				IL_1C2:
				return this.YieldDefault(12);
				IL_357:
				return this.Yield(17, new WaitForSeconds(3f));
				IL_393:
				IL_505:
				goto IL_132D;
				IL_598:
				Block_39:
				goto IL_A0C;
				IL_5C1:
				IL_668:
				goto IL_132D;
				Block_44:
				return this.Yield(18, new WaitForSeconds(3f));
				IL_7C8:
				goto IL_132D;
				IL_8B4:
				return this.Yield(8, new WaitForSeconds(1f));
				IL_948:
				goto IL_132D;
				Block_62:
				return this.Yield(4, new WaitForSeconds(3f));
				IL_9CA:
				goto IL_132D;
				Block_64:
				return this.Yield(11, new WaitForSeconds(3f));
				IL_A0C:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_66:
				goto IL_132D;
				IL_A47:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_ADC:
				goto IL_132D;
				IL_B0B:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_B46:
				return this.Yield(16, new WaitForSeconds(3f));
				IL_BBC:
				return this.Yield(9, new WaitForSeconds(2f));
				Block_80:
				goto IL_B46;
				IL_C52:
				return this.Yield(13, new WaitForSeconds(3f));
				IL_CB8:
				goto IL_132D;
				Block_88:
				goto IL_BBC;
				Block_91:
				goto IL_132D;
				IL_D66:
				return this.Yield(15, new WaitForSeconds(2f));
				Block_93:
				goto IL_132D;
				IL_E0A:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_FDD:
				Block_113:
				goto IL_132D;
				IL_115A:
				return this.Yield(14, new WaitForSeconds(1f));
				Block_117:
				goto IL_132D;
				Block_118:
				goto IL_8B4;
				Block_119:
				return this.Yield(10, new WaitForSeconds(2.5f));
				IL_132D:
				return false;
			}

			// Token: 0x06009E4E RID: 40526 RVA: 0x01240C10 File Offset: 0x0123EE10
			internal static bool gQ6b2xVxbXuAHbkfnrHQ()
			{
				return true;
			}

			// Token: 0x06009E4F RID: 40527 RVA: 0x01240C14 File Offset: 0x0123EE14
			internal static bool OA9KdSVxuMvDyUCB5t81()
			{
				return false;
			}

			// Token: 0x04009052 RID: 36946
			internal GameObject $mWindGod$43125;

			// Token: 0x04009053 RID: 36947
			internal GameObject $mEarthGod$43126;

			// Token: 0x04009054 RID: 36948
			internal GameObject $mFloatCamBot$43127;

			// Token: 0x04009055 RID: 36949
			internal GameObject $mFakeCarrierCore$43128;

			// Token: 0x04009056 RID: 36950
			internal StoryGui $mStoryGui$43129;

			// Token: 0x04009057 RID: 36951
			internal float $mStoryTimer$43130;

			// Token: 0x04009058 RID: 36952
			internal GameGui $mGameGui$43131;

			// Token: 0x04009059 RID: 36953
			internal M926_WhenWindStops $self_$43132;
		}
	}

	// Token: 0x02001A80 RID: 6784
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$43134 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009E50 RID: 40528 RVA: 0x01240C18 File Offset: 0x0123EE18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$43134(M926_WhenWindStops self_)
		{
			if (128856 - 51657 != 77200)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (75051 - 309735 != -234683)
				{
					base..ctor();
					if (12352 - 42534 == -30182)
					{
						this.$self_$43139 = self_;
						if (173495 - 475653 == -302158)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009E51 RID: 40529 RVA: 0x01240CB0 File Offset: 0x0123EEB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M926_WhenWindStops.$onDeadPlayer$43134.$(this.$self_$43139);
		}

		// Token: 0x06009E52 RID: 40530 RVA: 0x01240CC0 File Offset: 0x0123EEC0
		internal static bool PcwgHaVxIgxR54vRKH6i()
		{
			return true;
		}

		// Token: 0x06009E53 RID: 40531 RVA: 0x01240CC4 File Offset: 0x0123EEC4
		internal static bool J5DpBrVxBDEZkHeWf1wp()
		{
			return false;
		}

		// Token: 0x0400905A RID: 36954
		internal M926_WhenWindStops $self_$43139;

		// Token: 0x02001A81 RID: 6785
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009E54 RID: 40532 RVA: 0x01240CC8 File Offset: 0x0123EEC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M926_WhenWindStops self_)
			{
				if (134714 - 128700 != 6014)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (21270 - 467255 != -445984)
					{
						base..ctor();
						if (171447 - 422695 == -251248)
						{
							this.$self_$43138 = self_;
							if (285498 - 24660 == 260838)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009E55 RID: 40533 RVA: 0x01240D60 File Offset: 0x0123EF60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (271823 - 570658 != -298835)
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
							if (291181 - 327504 == -36322)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_249;
							}
							if (242865 - 594604 == -351738)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (260318 - 538896 != -278578)
						{
							continue;
						}
						this.$mStoryGui$43135 = (StoryGui)this.$self_$43138.GetComponent(typeof(StoryGui));
						if (161581 - 173766 != -12185)
						{
							continue;
						}
						if (this.$mStoryGui$43135)
						{
							if (3741 - 310911 != -307170)
							{
								continue;
							}
							this.$mStoryGui$43135.close();
							if (197854 - 78139 != 119715)
							{
								continue;
							}
						}
						this.$mChangeGui$43136 = (ChangeGui)this.$self_$43138.GetComponent(typeof(ChangeGui));
						if (29129 - 613 != 28516)
						{
							continue;
						}
						if (this.$mChangeGui$43136)
						{
							if (40533 - 540274 != -499741)
							{
								continue;
							}
							this.$mChangeGui$43136.close();
							if (147536 - 548874 != -401338)
							{
								continue;
							}
						}
						this.$mGameGui$43137 = (GameGui)this.$self_$43138.GetComponent(typeof(GameGui));
						if (70565 - 261639 == -191073)
						{
							continue;
						}
						if (this.$mGameGui$43137)
						{
							if (3442 - 311133 != -307691)
							{
								continue;
							}
							if (!this.$mGameGui$43137.enabled)
							{
								if (68826 - 168101 != -99275)
								{
									continue;
								}
								this.$mGameGui$43137.enabled = true;
								if (134631 - 342604 != -207973)
								{
									continue;
								}
							}
							this.$mGameGui$43137.openDeadMenu();
							if (17628 - 247752 == -230123)
							{
								continue;
							}
						}
						IL_249:
						this.YieldDefault(1);
						if (114742 - 133520 != -18778)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (255969 - 357143 != -101174)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (137113 - 462376 != -325263);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06009E56 RID: 40534 RVA: 0x01241078 File Offset: 0x0123F278
			internal static bool B3b4HLVxeRxmDZjNrSb7()
			{
				return true;
			}

			// Token: 0x06009E57 RID: 40535 RVA: 0x0124107C File Offset: 0x0123F27C
			internal static bool wvEAi2VxrsGmWEXxLwr9()
			{
				return false;
			}

			// Token: 0x0400905B RID: 36955
			internal StoryGui $mStoryGui$43135;

			// Token: 0x0400905C RID: 36956
			internal ChangeGui $mChangeGui$43136;

			// Token: 0x0400905D RID: 36957
			internal GameGui $mGameGui$43137;

			// Token: 0x0400905E RID: 36958
			internal M926_WhenWindStops $self_$43138;
		}
	}

	// Token: 0x02001A82 RID: 6786
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$43140 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009E58 RID: 40536 RVA: 0x01241080 File Offset: 0x0123F280
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$43140(Hashtable data, M926_WhenWindStops self_)
		{
			if (231523 - 374057 != -142533)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (82883 - 27830 != 55054)
				{
					base..ctor();
					if (222229 - 98970 != 123260)
					{
						this.$data$43145 = data;
						if (216301 - 43648 == 172653)
						{
							this.$self_$43146 = self_;
							if (262262 - 582454 == -320192)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009E59 RID: 40537 RVA: 0x0124113C File Offset: 0x0123F33C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M926_WhenWindStops.$onChangePlayer$43140.$(this.$data$43145, this.$self_$43146);
		}

		// Token: 0x06009E5A RID: 40538 RVA: 0x01241150 File Offset: 0x0123F350
		internal static bool f9txBQVxjcSlMcB7dbgi()
		{
			return true;
		}

		// Token: 0x06009E5B RID: 40539 RVA: 0x01241154 File Offset: 0x0123F354
		internal static bool W2aAb9VxhnEf1dSfMtmM()
		{
			return false;
		}

		// Token: 0x0400905F RID: 36959
		internal Hashtable $data$43145;

		// Token: 0x04009060 RID: 36960
		internal M926_WhenWindStops $self_$43146;

		// Token: 0x02001A83 RID: 6787
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009E5C RID: 40540 RVA: 0x01241158 File Offset: 0x0123F358
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M926_WhenWindStops self_)
			{
				if (130584 - 320901 != -190316)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (218400 - 376584 == -158184)
					{
						base..ctor();
						if (139125 - 146284 != -7158)
						{
							this.$data$43143 = data;
							if (276742 - 206958 == 69784)
							{
								this.$self_$43144 = self_;
								if (30592 - 482536 != -451943)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009E5D RID: 40541 RVA: 0x01241214 File Offset: 0x0123F414
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (80290 - 13140 != 67151)
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
							if (114528 - 274077 == -159548)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (271208 - 224642 != 46566)
							{
								continue;
							}
							this.$mGameGui$43142 = (GameGui)this.$self_$43144.GetComponent(typeof(GameGui));
							if (128278 - 583755 != -455477)
							{
								continue;
							}
							this.$mGameGui$43142.enabled = true;
							if (166673 - 199703 == -33029)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (24405 - 171489 != -147083)
						{
							goto Block_5;
						}
						continue;
					default:
						if (222234 - 538254 == -316019)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (7233 - 388460 != -381226)
					{
						this.$self_$43144.SendMessage("onCreatePlayer", this.$data$43143);
						if (57119 - 202454 != -145334)
						{
							this.$mChangeGui$43141 = (ChangeGui)this.$self_$43144.GetComponent(typeof(ChangeGui));
							if (212273 - 272434 != -60160)
							{
								if (!this.$mChangeGui$43141.enabled)
								{
									goto IL_14A;
								}
								if (139938 - 519022 != -379083)
								{
									this.$mChangeGui$43141.close();
									if (138924 - 185727 != -46802)
									{
										goto Block_8;
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_205;
				Block_8:
				IL_14A:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x06009E5E RID: 40542 RVA: 0x01241438 File Offset: 0x0123F638
			internal static bool zR9S35Vxs6AE2qNojw7K()
			{
				return true;
			}

			// Token: 0x06009E5F RID: 40543 RVA: 0x0124143C File Offset: 0x0123F63C
			internal static bool BOiTpxVx9EscfDu6815Y()
			{
				return false;
			}

			// Token: 0x04009061 RID: 36961
			internal ChangeGui $mChangeGui$43141;

			// Token: 0x04009062 RID: 36962
			internal GameGui $mGameGui$43142;

			// Token: 0x04009063 RID: 36963
			internal Hashtable $data$43143;

			// Token: 0x04009064 RID: 36964
			internal M926_WhenWindStops $self_$43144;
		}
	}

	// Token: 0x02001A84 RID: 6788
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$43147 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009E60 RID: 40544 RVA: 0x01241440 File Offset: 0x0123F640
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$43147(Hashtable data, M926_WhenWindStops self_)
		{
			if (103794 - 11874 != 91920)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (250457 - 74626 == 175831)
				{
					base..ctor();
					if (247930 - 481863 == -233933)
					{
						this.$data$43155 = data;
						if (223828 - 538158 != -314329)
						{
							this.$self_$43156 = self_;
							if (185996 - 76167 == 109829)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009E61 RID: 40545 RVA: 0x012414FC File Offset: 0x0123F6FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M926_WhenWindStops.$onGameComplete$43147.$(this.$data$43155, this.$self_$43156);
		}

		// Token: 0x06009E62 RID: 40546 RVA: 0x01241510 File Offset: 0x0123F710
		internal static bool CnjFTJVx1dKPLEHF8k8x()
		{
			return true;
		}

		// Token: 0x06009E63 RID: 40547 RVA: 0x01241514 File Offset: 0x0123F714
		internal static bool ILW466Vx4WhTWmvjVvb2()
		{
			return false;
		}

		// Token: 0x04009065 RID: 36965
		internal Hashtable $data$43155;

		// Token: 0x04009066 RID: 36966
		internal M926_WhenWindStops $self_$43156;

		// Token: 0x02001A85 RID: 6789
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009E64 RID: 40548 RVA: 0x01241518 File Offset: 0x0123F718
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M926_WhenWindStops self_)
			{
				if (127392 - 272856 != -145463)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (195971 - 225066 == -29095)
					{
						base..ctor();
						if (290618 - 311359 != -20740)
						{
							this.$data$43153 = data;
							if (263239 - 530436 == -267197)
							{
								this.$self_$43154 = self_;
								if (277283 - 3609 == 273674)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009E65 RID: 40549 RVA: 0x012415D4 File Offset: 0x0123F7D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (154631 - 371843 != -217211)
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
						this.$mCompleteGui$43149 = (CompleteGui)this.$self_$43154.GetComponent(typeof(CompleteGui));
						if (62591 - 564365 == -501773)
						{
							continue;
						}
						this.$mCompleteGui$43149.Init();
						if (251386 - 399041 == -147654)
						{
							continue;
						}
						this.$mCompleteGui$43149.readData(this.$data$43153);
						if (251054 - 75094 == 175961)
						{
							continue;
						}
						if (this.$result$43148 == 1)
						{
							if (198749 - 376577 != -177828)
							{
								continue;
							}
							this.$mCompleteGui$43149.displayResult(eCompleteType.Success);
							if (101235 - 117652 != -16417)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$43149.displayResult(eCompleteType.Failed);
							if (158260 - 473802 != -315542)
							{
								continue;
							}
						}
						this.$mGameGui$43150 = (GameGui)this.$self_$43154.GetComponent(typeof(GameGui));
						if (33615 - 599676 == -566060)
						{
							continue;
						}
						this.$mStoryGui$43151 = (StoryGui)this.$self_$43154.GetComponent(typeof(StoryGui));
						if (69755 - 218984 == -149228)
						{
							continue;
						}
						this.$mChangeGui$43152 = (ChangeGui)this.$self_$43154.GetComponent(typeof(ChangeGui));
						if (4188 - 24414 == -20225)
						{
							continue;
						}
						if (this.$mGameGui$43150)
						{
							if (64736 - 383199 == -318462)
							{
								continue;
							}
							this.$mGameGui$43150.close();
							if (6797 - 518927 != -512130)
							{
								continue;
							}
						}
						if (this.$mStoryGui$43151)
						{
							if (228950 - 378001 != -149051)
							{
								continue;
							}
							this.$mStoryGui$43151.close();
							if (238015 - 563289 == -325273)
							{
								continue;
							}
						}
						if (this.$mChangeGui$43152)
						{
							if (149822 - 259928 == -110105)
							{
								continue;
							}
							this.$mChangeGui$43152.disable();
							if (62328 - 305440 == -243111)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (84843 - 7580 != 77263)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (204264 - 419698 != -215434)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$43153[31]);
					if (227221 - 67313 != 159909)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (13567 - 526502 != -512934)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (178865 - 28365 != 150501)
							{
								this.$result$43148 = RuntimeServices.UnboxInt32(this.$data$43153[31]);
								if (57708 - 386167 == -328459)
								{
									goto IL_23D;
								}
							}
						}
					}
				}
				goto IL_3DB;
				IL_23D:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x06009E66 RID: 40550 RVA: 0x012419D0 File Offset: 0x0123FBD0
			internal static bool NZaPeDVxzv7LfAe1xkOx()
			{
				return true;
			}

			// Token: 0x06009E67 RID: 40551 RVA: 0x012419D4 File Offset: 0x0123FBD4
			internal static bool k3rIZZVgafGVuIMxpGn6()
			{
				return false;
			}

			// Token: 0x04009067 RID: 36967
			internal int $result$43148;

			// Token: 0x04009068 RID: 36968
			internal CompleteGui $mCompleteGui$43149;

			// Token: 0x04009069 RID: 36969
			internal GameGui $mGameGui$43150;

			// Token: 0x0400906A RID: 36970
			internal StoryGui $mStoryGui$43151;

			// Token: 0x0400906B RID: 36971
			internal ChangeGui $mChangeGui$43152;

			// Token: 0x0400906C RID: 36972
			internal Hashtable $data$43153;

			// Token: 0x0400906D RID: 36973
			internal M926_WhenWindStops $self_$43154;
		}
	}

	// Token: 0x02001A86 RID: 6790
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$43157 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009E68 RID: 40552 RVA: 0x012419D8 File Offset: 0x0123FBD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$43157(M926_WhenWindStops self_)
		{
			if (259072 - 153589 != 105484)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (249924 - 339364 != -89439)
				{
					base..ctor();
					if (193471 - 201903 == -8432)
					{
						this.$self_$43161 = self_;
						if (127392 - 31175 == 96217)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009E69 RID: 40553 RVA: 0x01241A70 File Offset: 0x0123FC70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M926_WhenWindStops.$ReturnToTown$43157.$(this.$self_$43161);
		}

		// Token: 0x06009E6A RID: 40554 RVA: 0x01241A80 File Offset: 0x0123FC80
		internal static bool qQlBEqVg5PemAHihkh6E()
		{
			return true;
		}

		// Token: 0x06009E6B RID: 40555 RVA: 0x01241A84 File Offset: 0x0123FC84
		internal static bool wd6L7VVgpXUSioDx7GBa()
		{
			return false;
		}

		// Token: 0x0400906E RID: 36974
		internal M926_WhenWindStops $self_$43161;

		// Token: 0x02001A87 RID: 6791
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009E6C RID: 40556 RVA: 0x01241A88 File Offset: 0x0123FC88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M926_WhenWindStops self_)
			{
				if (201861 - 430660 != -228798)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (172074 - 125193 == 46881)
					{
						base..ctor();
						if (80514 - 243329 != -162814)
						{
							this.$self_$43160 = self_;
							if (52793 - 481960 != -429166)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009E6D RID: 40557 RVA: 0x01241B20 File Offset: 0x0123FD20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (27204 - 431117 != -403913)
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
						this.$self_$43160.LeaveGame();
						if (12829 - 366439 != -353610)
						{
							continue;
						}
						this.YieldDefault(1);
						if (298857 - 228106 != 70752)
						{
							goto Block_21;
						}
						continue;
					default:
						if (111099 - 565695 == -454595)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (58057 - 73778 == -15721)
					{
						Game.mStateTime = Time.time;
						if (82183 - 76070 != 6114)
						{
							this.$$switch$7885$43158 = PlayerData.SaveGuild;
							if (61488 - 289673 == -228185)
							{
								if (this.$$switch$7885$43158 == 1)
								{
									if (23583 - 529688 != -506105)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (241067 - 91150 == 149918)
									{
										continue;
									}
								}
								else if (this.$$switch$7885$43158 == 2)
								{
									if (39570 - 217075 != -177505)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (207053 - 416820 == -209766)
									{
										continue;
									}
								}
								else if (this.$$switch$7885$43158 == 3)
								{
									if (104141 - 345074 == -240932)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (6356 - 421380 != -415024)
									{
										continue;
									}
								}
								else if (this.$$switch$7885$43158 == 4)
								{
									if (63832 - 204531 != -140699)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (92025 - 439852 != -347827)
									{
										continue;
									}
								}
								else if (this.$$switch$7885$43158 == 5)
								{
									if (200196 - 519375 != -319179)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (16747 - 22745 == -5997)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (87871 - 38843 == 49029)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (103752 - 482464 != -378712)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (83994 - 205499 == -121504)
									{
										continue;
									}
								}
								this.$mGameGui$43159 = (GameGui)this.$self_$43160.GetComponent(typeof(GameGui));
								if (253438 - 584984 != -331545)
								{
									if (this.$mGameGui$43159)
									{
										if (234420 - 119364 != 115056)
										{
											continue;
										}
										this.$mGameGui$43159.close();
										if (285361 - 272401 == 12961)
										{
											continue;
										}
									}
									this.$self_$43160.SendMessage("fadeOut");
									if (233981 - 85727 != 148255)
									{
										goto Block_31;
									}
								}
							}
						}
					}
				}
				Block_21:
				goto IL_3AD;
				Block_31:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x06009E6E RID: 40558 RVA: 0x01241EEC File Offset: 0x012400EC
			internal static bool J7xcL3VgVlwkiEkoma5M()
			{
				return true;
			}

			// Token: 0x06009E6F RID: 40559 RVA: 0x01241EF0 File Offset: 0x012400F0
			internal static bool NRHyTuVgtIgeWsR05EGZ()
			{
				return false;
			}

			// Token: 0x0400906F RID: 36975
			internal int $$switch$7885$43158;

			// Token: 0x04009070 RID: 36976
			internal GameGui $mGameGui$43159;

			// Token: 0x04009071 RID: 36977
			internal M926_WhenWindStops $self_$43160;
		}
	}

	// Token: 0x02001A88 RID: 6792
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$43162 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009E70 RID: 40560 RVA: 0x01241EF4 File Offset: 0x012400F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$43162(M926_WhenWindStops self_)
		{
			if (32790 - 377629 != -344839)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (244516 - 42930 == 201586)
				{
					base..ctor();
					if (79199 - 398422 != -319222)
					{
						this.$self_$43165 = self_;
						if (276758 - 9772 != 266987)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009E71 RID: 40561 RVA: 0x01241F8C File Offset: 0x0124018C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M926_WhenWindStops.$ReturnToGuild$43162.$(this.$self_$43165);
		}

		// Token: 0x06009E72 RID: 40562 RVA: 0x01241F9C File Offset: 0x0124019C
		internal static bool XwXojNVgNboMZGBuFhBD()
		{
			return true;
		}

		// Token: 0x06009E73 RID: 40563 RVA: 0x01241FA0 File Offset: 0x012401A0
		internal static bool E2XAkJVgYn7G8tAKPBMq()
		{
			return false;
		}

		// Token: 0x04009072 RID: 36978
		internal M926_WhenWindStops $self_$43165;

		// Token: 0x02001A89 RID: 6793
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009E74 RID: 40564 RVA: 0x01241FA4 File Offset: 0x012401A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M926_WhenWindStops self_)
			{
				if (3333 - 143245 != -139912)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (224675 - 291523 != -66847)
					{
						base..ctor();
						if (47870 - 224872 == -177002)
						{
							this.$self_$43164 = self_;
							if (193311 - 168211 != 25101)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009E75 RID: 40565 RVA: 0x0124203C File Offset: 0x0124023C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (159991 - 123837 != 36155)
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
						this.$self_$43164.LeaveGame();
						if (245579 - 498332 != -252753)
						{
							continue;
						}
						this.YieldDefault(1);
						if (231597 - 244320 != -12722)
						{
							goto Block_8;
						}
						continue;
					default:
						if (42550 - 358714 != -316164)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (264970 - 449867 != -184896)
					{
						Game.mStateTime = Time.time;
						if (117840 - 211024 != -93183)
						{
							Game.mNextGameCode = 31;
							if (176644 - 316369 != -139724)
							{
								this.$mGameGui$43163 = (GameGui)this.$self_$43164.GetComponent(typeof(GameGui));
								if (152693 - 579934 == -427241)
								{
									if (this.$mGameGui$43163)
									{
										if (281771 - 37915 != 243856)
										{
											continue;
										}
										this.$mGameGui$43163.close();
										if (7112 - 281890 == -274777)
										{
											continue;
										}
									}
									this.$self_$43164.SendMessage("fadeOut");
									if (89104 - 460677 != -371572)
									{
										goto Block_12;
									}
								}
							}
						}
					}
				}
				Block_8:
				goto IL_1BD;
				Block_12:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x06009E76 RID: 40566 RVA: 0x01242218 File Offset: 0x01240418
			internal static bool PlPt5RVgc6tSJXlNlq3q()
			{
				return true;
			}

			// Token: 0x06009E77 RID: 40567 RVA: 0x0124221C File Offset: 0x0124041C
			internal static bool pc32TbVgUGto8krAyPWI()
			{
				return false;
			}

			// Token: 0x04009073 RID: 36979
			internal GameGui $mGameGui$43163;

			// Token: 0x04009074 RID: 36980
			internal M926_WhenWindStops $self_$43164;
		}
	}

	// Token: 0x02001A8A RID: 6794
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$43166 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009E78 RID: 40568 RVA: 0x01242220 File Offset: 0x01240420
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$43166(M926_WhenWindStops self_)
		{
			if (112816 - 332778 != -219962)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (4928 - 181978 == -177050)
				{
					base..ctor();
					if (10068 - 398150 != -388081)
					{
						this.$self_$43170 = self_;
						if (156079 - 114064 == 42015)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009E79 RID: 40569 RVA: 0x012422B8 File Offset: 0x012404B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M926_WhenWindStops.$ReturnToCamp$43166.$(this.$self_$43170);
		}

		// Token: 0x06009E7A RID: 40570 RVA: 0x012422C8 File Offset: 0x012404C8
		internal static bool M0rfB8VgTROTfNg42jb7()
		{
			return true;
		}

		// Token: 0x06009E7B RID: 40571 RVA: 0x012422CC File Offset: 0x012404CC
		internal static bool pQvl69Vg3uKKZ74tyJ92()
		{
			return false;
		}

		// Token: 0x04009075 RID: 36981
		internal M926_WhenWindStops $self_$43170;

		// Token: 0x02001A8B RID: 6795
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009E7C RID: 40572 RVA: 0x012422D0 File Offset: 0x012404D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M926_WhenWindStops self_)
			{
				if (230922 - 180978 != 49944)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (275599 - 154528 != 121072)
					{
						base..ctor();
						if (223156 - 132948 == 90208)
						{
							this.$self_$43169 = self_;
							if (262839 - 126207 != 136633)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009E7D RID: 40573 RVA: 0x01242368 File Offset: 0x01240568
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (123440 - 280006 != -156566)
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
						this.$self_$43169.LeaveGame();
						if (159047 - 37292 != 121755)
						{
							continue;
						}
						this.YieldDefault(1);
						if (95655 - 46922 != 48734)
						{
							goto Block_14;
						}
						continue;
					default:
						if (254319 - 72176 != 182143)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (85752 - 427612 == -341860)
					{
						Game.mStateTime = Time.time;
						if (221634 - 345964 == -124330)
						{
							this.$$switch$7887$43167 = PlayerData.SaveGuild;
							if (232551 - 295192 == -62641)
							{
								if (this.$$switch$7887$43167 == 1)
								{
									if (140109 - 143016 == -2906)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (64877 - 138880 != -74003)
									{
										continue;
									}
								}
								else if (this.$$switch$7887$43167 == 2)
								{
									if (60758 - 528028 == -467269)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (257606 - 112405 != 145201)
									{
										continue;
									}
								}
								else if (this.$$switch$7887$43167 == 3)
								{
									if (3917 - 151578 != -147661)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (54449 - 342641 != -288192)
									{
										continue;
									}
								}
								else if (this.$$switch$7887$43167 == 4)
								{
									if (263774 - 288738 != -24964)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (7134 - 192856 == -185721)
									{
										continue;
									}
								}
								else if (this.$$switch$7887$43167 == 5)
								{
									if (225542 - 272067 != -46525)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (116388 - 53566 == 62823)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (248659 - 141786 != 106873)
									{
										continue;
									}
								}
								this.$mGameGui$43168 = (GameGui)this.$self_$43169.GetComponent(typeof(GameGui));
								if (135487 - 80780 == 54707)
								{
									if (this.$mGameGui$43168)
									{
										if (137 - 372514 != -372377)
										{
											continue;
										}
										this.$mGameGui$43168.close();
										if (84922 - 391263 == -306340)
										{
											continue;
										}
									}
									this.$self_$43169.SendMessage("fadeOut");
									if (117029 - 355630 == -238601)
									{
										goto IL_2BF;
									}
								}
							}
						}
					}
				}
				Block_14:
				goto IL_363;
				IL_2BF:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x06009E7E RID: 40574 RVA: 0x012426EC File Offset: 0x012408EC
			internal static bool ca6svSVgXKniflUuUbnN()
			{
				return true;
			}

			// Token: 0x06009E7F RID: 40575 RVA: 0x012426F0 File Offset: 0x012408F0
			internal static bool chKPKSVgQeExbKMXJNKG()
			{
				return false;
			}

			// Token: 0x04009076 RID: 36982
			internal int $$switch$7887$43167;

			// Token: 0x04009077 RID: 36983
			internal GameGui $mGameGui$43168;

			// Token: 0x04009078 RID: 36984
			internal M926_WhenWindStops $self_$43169;
		}
	}
}
