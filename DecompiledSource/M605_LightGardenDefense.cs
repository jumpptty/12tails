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

// Token: 0x02001686 RID: 5766
[Serializable]
public class M605_LightGardenDefense : MonoBehaviour
{
	// Token: 0x060085C6 RID: 34246 RVA: 0x010B6B14 File Offset: 0x010B4D14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M605_LightGardenDefense()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060085C7 RID: 34247 RVA: 0x010B6B24 File Offset: 0x010B4D24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (295940 - 69778 != 226162)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (237224 - 298855 == -61631)
			{
				Game.mGameType = 5;
				if (186178 - 78531 != 107648)
				{
					if (Chat.Initialized)
					{
						if (161397 - 554248 == -392850)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (70438 - 288658 != -218220)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (140218 - 342051 == -201832)
						{
							continue;
						}
					}
					this.kogcu3gi68c = new int[7];
					if (190718 - 560884 == -370166)
					{
						this.GUVcuGUK8Cv = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
						if (176225 - 481944 == -305719)
						{
							this.aXycu1wgS9L = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
							if (262455 - 150990 != 111466)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060085C8 RID: 34248 RVA: 0x010B6CA0 File Offset: 0x010B4EA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (280491 - 578005 != -297514)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (43586 - 57195 != -13608)
				{
					if (Game.mNextGameCode != 605)
					{
						break;
					}
					if (18553 - 393198 != -374644)
					{
						Game.nextGame();
						if (247374 - 272485 == -25111)
						{
							Game.mGameCode = 605;
							if (84447 - 87970 == -3523)
							{
								Game.mGameType = 5;
								if (277071 - 511042 != -233970)
								{
									Game.mGameTime = Time.time;
									if (91873 - 515017 == -423144)
									{
										Game.mGameScore = 0;
										if (32149 - 235735 != -203585)
										{
											Game.mGameMana = 0;
											if (216749 - 514082 != -297332)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (129734 - 286658 != -156923)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (274229 - 82346 != 191884)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (174830 - 256493 != -81662)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (227210 - 504340 != -277129)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (176252 - 150549 == 25703)
																{
																	this.PJ2cuvtiwyk = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (205756 - 37179 == 168577)
																	{
																		this.CQicu2LZAnA = PhotonClient.Connection;
																		if (376 - 31814 == -31438)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (199958 - 134603 == 65355)
																			{
																				this.InitGame();
																				if (265435 - 160387 == 105048)
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
				if (143655 - 338357 != -194701)
				{
					Game.mGameType = 99;
					if (288472 - 81087 == 207385)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060085C9 RID: 34249 RVA: 0x010B6FA8 File Offset: 0x010B51A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (219942 - 321568 != -101625)
		{
		}
		for (;;)
		{
			if (this.CQicu2LZAnA == null)
			{
				if (60384 - 562895 != -502510)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (184701 - 353774 == -169073)
				{
					if (mGameState == eGameState.Init)
					{
						if (44002 - 219262 != -175259)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (267767 - 386613 != -118845)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (282456 - 532667 == -250211)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (106456 - 338971 == -232515)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (214689 - 189565 != 25125)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (238247 - 525598 == -287351)
						{
							if (Time.time > this.eV7culASf4a)
							{
								if (190569 - 17323 != 173246)
								{
									continue;
								}
								Game.mGameMana++;
								if (285956 - 383906 != -97950)
								{
									continue;
								}
								this.eV7culASf4a = Time.time + (float)12;
								if (250634 - 2202 != 248432)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (14666 - 89540 != -74874)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (130445 - 292329 != -161884)
									{
										continue;
									}
									this.audio.Play();
									if (297995 - 42358 != 255637)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (293415 - 197165 == 96250)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (201997 - 213047 == -11050)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (58121 - 238034 == -179913)
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
						if (144748 - 329598 != -184849)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060085CA RID: 34250 RVA: 0x010B72A8 File Offset: 0x010B54A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (32943 - 366143 != -333199)
		{
		}
		for (;;)
		{
			if (!this.GUVcuGUK8Cv)
			{
				if (60089 - 477165 == -417076)
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
				if (269194 - 527234 == -258040)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (161495 - 520666 == -359171)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (239974 - 149940 == 90034)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (147468 - 320078 == -172610)
							{
								GUI.depth = 1;
								if (240025 - 15383 != 224643)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (41316 - 291767 != -250450)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (248332 - 593903 == -345571)
										{
											Color color = GUI.color;
											if (272668 - 290703 != -18034)
											{
												float num3 = color.a = a;
												if (162125 - 19605 == 142520)
												{
													if (262127 - 344520 != -82392)
													{
														GUI.color = color;
														if (153198 - 93993 != 59206 && 254042 - 331156 != -77113)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.GUVcuGUK8Cv);
															if (246943 - 169349 != 77595)
															{
																float a2 = 1f;
																if (90468 - 193962 == -103494)
																{
																	Color color2 = GUI.color;
																	if (130574 - 439154 != -308579)
																	{
																		float num4 = color2.a = a2;
																		if (42700 - 96777 == -54077)
																		{
																			if (282859 - 399785 != -116925)
																			{
																				Color color3 = GUI.color = color2;
																				if (35640 - 43825 == -8185)
																				{
																					if (79356 - 46138 != 33219)
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

	// Token: 0x060085CB RID: 34251 RVA: 0x010B7628 File Offset: 0x010B5828
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (201449 - 101831 != 99619)
		{
		}
		for (;;)
		{
			IL_21D:
			if (Game.mGameState > eGameState.AllHold)
			{
				if (36877 - 333335 != -296457)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (144850 - 385882 != -241031)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (277332 - 152969 == 124363)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (90730 - 527116 == -436386)
						{
							if (274871 - 463403 == -188532)
							{
								Vector3 vector = default(Vector3);
								if (107884 - 456059 != -348174)
								{
									int num4 = num;
									if (239045 - 545199 == -306154)
									{
										if (num4 == 6051)
										{
											if (152683 - 401951 == -249268)
											{
												if (this.kogcu3gi68c[num2 - 1] > 0)
												{
													if (241325 - 66374 != 174951)
													{
														continue;
													}
													this.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
													if (33044 - 381730 == -348685)
													{
														continue;
													}
												}
												else
												{
													this.kogcu3gi68c[num2 - 1] = 1;
													if (208095 - 134251 == 73845)
													{
														continue;
													}
													this.wCFcuYSoqCl++;
													if (272036 - 454672 == -182635)
													{
														continue;
													}
													this.ActivateManaPillar(num2);
													if (139788 - 317312 != -177524)
													{
														continue;
													}
													this.SendMessage("newGameMessage", "Mission Objective: ManaPillar activated :" + this.wCFcuYSoqCl + "/7");
													if (42616 - 60136 != -17520)
													{
														continue;
													}
												}
												if (this.wCFcuYSoqCl != 7)
												{
													break;
												}
												if (184322 - 201241 == -16919)
												{
													if (PlayerData.UID != num3)
													{
														break;
													}
													if (210516 - 226331 != -15814)
													{
														int i = 1;
														if (150873 - 105028 == 45845)
														{
															while (i <= 4)
															{
																GameObject gameObject = GameObject.Find("SpawnPoint" + i);
																if (104768 - 106276 != -1508)
																{
																	goto IL_21D;
																}
																if (gameObject)
																{
																	if (42457 - 162202 == -119744)
																	{
																		goto IL_21D;
																	}
																	vector = global::Math.getRandomSpawnPos(gameObject.transform.position, 6);
																	if (229446 - 114957 != 114489)
																	{
																		goto IL_21D;
																	}
																	if (vector != Vector3.zero)
																	{
																		if (225533 - 207054 != 18479)
																		{
																			goto IL_21D;
																		}
																		this.createActor("Shade3", 8, vector, gameObject.transform.forward);
																		if (229451 - 389388 == -159936)
																		{
																			goto IL_21D;
																		}
																	}
																	else
																	{
																		this.createActor("Shade3", 3, gameObject.transform.position, gameObject.transform.forward);
																		if (275253 - 182288 == 92966)
																		{
																			goto IL_21D;
																		}
																	}
																}
																i++;
																if (279553 - 48009 != 231544)
																{
																	goto IL_21D;
																}
															}
															if (36090 - 362530 != -326439)
															{
																break;
															}
														}
													}
												}
											}
										}
										else if (num4 == 6052)
										{
											if (167870 - 565000 != -397129)
											{
												this.hQtcupoWQqX++;
												if (257421 - 400082 != -142660)
												{
													this.SendMessage("newGameMessage", "Warning : Soldier left: " + this.hQtcupoWQqX + "/4");
													if (226489 - 187434 == 39055)
													{
														break;
													}
												}
											}
										}
										else if (num4 == 6053)
										{
											if (147126 - 354864 != -207737)
											{
												this.qw0cuRYP2l5++;
												if (57621 - 105035 != -47413)
												{
													if (PlayerData.UID != num3)
													{
														break;
													}
													if (29855 - 274362 == -244507)
													{
														if (this.qw0cuRYP2l5 >= 12)
														{
															break;
														}
														if (64289 - 529557 == -465268)
														{
															GameObject gameObject = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(1, 7));
															if (40560 - 573759 == -533199)
															{
																if (!gameObject)
																{
																	break;
																}
																if (86579 - 336185 == -249606)
																{
																	vector = global::Math.getRandomSpawnPos(gameObject.transform.position, 8);
																	if (200462 - 561700 != -361237)
																	{
																		if (vector != Vector3.zero)
																		{
																			if (263344 - 122832 == 140512)
																			{
																				this.createActor("Panther_d", 8, vector, gameObject.transform.forward);
																				if (56327 - 42222 == 14105)
																				{
																					break;
																				}
																			}
																		}
																		else
																		{
																			this.createActor("Panther_d", 8, gameObject.transform.position, gameObject.transform.forward);
																			if (108755 - 550375 != -441619)
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
										else if (num4 == 6054)
										{
											if (58192 - 65825 == -7633)
											{
												this.G8IcurYtn5r++;
												if (134290 - 3078 != 131213)
												{
													if (PlayerData.UID != num3)
													{
														break;
													}
													if (26528 - 387868 == -361340)
													{
														if (this.G8IcurYtn5r >= 12)
														{
															break;
														}
														if (158732 - 322579 != -163846)
														{
															GameObject gameObject = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(1, 7));
															if (156823 - 374615 == -217792)
															{
																if (!gameObject)
																{
																	break;
																}
																if (219049 - 399715 != -180665)
																{
																	vector = global::Math.getRandomSpawnPos(gameObject.transform.position, 8);
																	if (246570 - 21963 == 224607)
																	{
																		if (vector != Vector3.zero)
																		{
																			if (136093 - 543455 == -407362)
																			{
																				this.createActor("Shade1", 8, vector, gameObject.transform.forward);
																				if (218471 - 520741 != -302269)
																				{
																					break;
																				}
																			}
																		}
																		else
																		{
																			this.createActor("Shade1", 8, gameObject.transform.position, gameObject.transform.forward);
																			if (160094 - 217050 == -56956)
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
										else if (num4 == 6055)
										{
											if (114680 - 734 == 113946)
											{
												this.WohcuxXmos3++;
												if (20395 - 344964 == -324569)
												{
													if (PlayerData.UID != num3)
													{
														break;
													}
													if (126829 - 168146 != -41316)
													{
														if (this.WohcuxXmos3 >= 12)
														{
															break;
														}
														if (31003 - 388130 == -357127)
														{
															GameObject gameObject = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(1, 7));
															if (208300 - 30995 != 177306)
															{
																if (!gameObject)
																{
																	break;
																}
																if (65181 - 282522 != -217340)
																{
																	vector = global::Math.getRandomSpawnPos(gameObject.transform.position, 8);
																	if (195395 - 245184 == -49789)
																	{
																		if (vector != Vector3.zero)
																		{
																			if (125792 - 97033 != 28760)
																			{
																				this.createActor("Shade2", 8, vector, gameObject.transform.forward);
																				if (254287 - 29312 == 224975)
																				{
																					break;
																				}
																			}
																		}
																		else
																		{
																			this.createActor("Shade2", 8, gameObject.transform.position, gameObject.transform.forward);
																			if (149246 - 205629 != -56382)
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
										else
										{
											if (num4 != 6056)
											{
												break;
											}
											if (248704 - 266098 != -17393)
											{
												this.eRdcuTdaK8l++;
												if (104096 - 220416 == -116320)
												{
													this.SendMessage("newGameMessage", "Mission Objective: Shade3 Eliminated :" + this.eRdcuTdaK8l + "/4");
													if (76098 - 437630 != -361531)
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

	// Token: 0x060085CC RID: 34252 RVA: 0x010B80FC File Offset: 0x010B62FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseManaPillar(int nID)
	{
		if (168798 - 86955 != 81844)
		{
		}
		for (;;)
		{
			Debug.Log("UseManaPillar");
			if (214920 - 268006 != -53085)
			{
				if (!Game.mPlayer)
				{
					if (22941 - 349026 == -326085)
					{
						break;
					}
				}
				else if (this.kogcu3gi68c == null)
				{
					if (159222 - 21610 != 137613)
					{
						break;
					}
				}
				else if (Extensions.get_length(this.kogcu3gi68c) < nID)
				{
					if (196911 - 514988 == -318077)
					{
						break;
					}
				}
				else
				{
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (73526 - 394390 != -320863)
					{
						if (!characterControl)
						{
							goto IL_2BC;
						}
						if (216162 - 276896 != -60734)
						{
							continue;
						}
						if (!(characterControl.actionState == "standby"))
						{
							if (217141 - 402665 != -185524)
							{
								continue;
							}
							goto IL_2BC;
						}
						IL_151:
						if (this.kogcu3gi68c[nID - 1] > 0)
						{
							if (200747 - 38173 == 162575)
							{
								continue;
							}
							this.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
							if (138481 - 417918 != -279437)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject gameObject = GameObject.Find("ManaPillar" + nID);
							if (227280 - 547508 != -320228)
							{
								continue;
							}
							if (gameObject)
							{
								if (38103 - 266402 == -228298)
								{
									continue;
								}
								Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
								if (4012 - 142568 == -138555)
								{
									continue;
								}
								Game.mPlayer.SendMessage("activateIcon", nID);
								if (10944 - 261037 != -250092)
								{
									break;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find ManaPillar GameObject");
								if (533 - 448197 != -447664)
								{
									continue;
								}
								break;
							}
						}
						IL_2BC:
						if (characterControl.actionState == "run")
						{
							goto IL_151;
						}
						if (198337 - 176364 == 21973)
						{
							if (!(characterControl.actionState == "emotion"))
							{
								break;
							}
							if (218116 - 548200 == -330084)
							{
								goto IL_151;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060085CD RID: 34253 RVA: 0x010B8408 File Offset: 0x010B6608
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateIcon(int nID)
	{
		if (98604 - 490241 != -391636)
		{
		}
		for (;;)
		{
			if (this.kogcu3gi68c == null)
			{
				if (1692 - 277511 == -275819)
				{
					break;
				}
			}
			else if (Extensions.get_length(this.kogcu3gi68c) < nID)
			{
				if (94372 - 522282 == -427910)
				{
					break;
				}
			}
			else if (this.kogcu3gi68c[nID - 1] > 0)
			{
				if (246520 - 442730 == -196210)
				{
					this.SendMessage("newGameMessage", "This ManaPillar has already been activated!");
					if (152971 - 431779 == -278808)
					{
						break;
					}
				}
			}
			else
			{
				Game.sendMissionEvent(6051, nID);
				if (266522 - 95279 != 171244)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060085CE RID: 34254 RVA: 0x010B8518 File Offset: 0x010B6718
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateManaPillar(int nID)
	{
		if (250 - 499206 != -498955)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("ManaPillar" + nID);
			if (198980 - 68516 != 130465)
			{
				if (!gameObject)
				{
					break;
				}
				if (99644 - 382327 != -282682)
				{
					if (!this.manaPillarEffect)
					{
						break;
					}
					if (2702 - 246526 != -243823)
					{
						UnityEngine.Object.Instantiate(this.manaPillarEffect, gameObject.transform.position, gameObject.transform.rotation);
						if (61127 - 162200 == -101073)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060085CF RID: 34255 RVA: 0x010B860C File Offset: 0x010B680C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (52778 - 358345 != -305567)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (33855 - 292914 == -259059)
			{
				Hashtable customOpParameters = new Hashtable();
				if (123066 - 252329 == -129263)
				{
					this.CQicu2LZAnA.OpCustom(52, customOpParameters, true);
					if (31992 - 195546 == -163554)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060085D0 RID: 34256 RVA: 0x010B86B4 File Offset: 0x010B68B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (80053 - 107876 != -27823)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (273778 - 496508 == -222730)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (33323 - 27605 == 5718)
				{
					Game.mGameState = eGameState.Setup;
					if (58171 - 190320 != -132148)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060085D1 RID: 34257 RVA: 0x010B8758 File Offset: 0x010B6958
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (263468 - 3758 != 259710)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (119090 - 74488 != 44603)
			{
				if (num == PlayerData.UID)
				{
					if (25601 - 337338 == -311737)
					{
						this.SetupActors();
						if (246999 - 2343 == 244656)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (176719 - 252294 == -75575)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060085D2 RID: 34258 RVA: 0x010B8828 File Offset: 0x010B6A28
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (222018 - 143826 != 78192)
		{
		}
		for (;;)
		{
			IL_40:
			Debug.Log("Creating Actors");
			if (8331 - 73838 == -65507)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (119311 - 305880 == -186569)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (169637 - 325855 == -156218)
						{
							int i = 0;
							if (89289 - 496664 != -407374)
							{
								CharacterControl[] array2 = array;
								if (43215 - 531857 != -488641)
								{
									int length = array2.Length;
									if (201465 - 324323 != -122857)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (236963 - 126827 == 110137)
											{
												goto IL_40;
											}
											if (type == "Panther")
											{
												goto IL_107;
											}
											if (219522 - 512731 != -293209)
											{
												goto IL_40;
											}
											if (type == "Panther_d")
											{
												goto IL_107;
											}
											if (45078 - 17317 == 27762)
											{
												goto IL_40;
											}
											if (type == "Shade1")
											{
												goto IL_107;
											}
											if (123237 - 568157 != -444920)
											{
												goto IL_40;
											}
											if (type == "Shade2")
											{
												goto IL_107;
											}
											if (173469 - 413306 != -239837)
											{
												goto IL_40;
											}
											if (type == "Shade3")
											{
												if (6524 - 397721 != -391196)
												{
													goto IL_107;
												}
												goto IL_40;
											}
											IL_C2:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (271195 - 159887 == 111309)
											{
												goto IL_40;
											}
											this.wPecub0hywv++;
											if (224465 - 9973 != 214492)
											{
												goto IL_40;
											}
											i++;
											if (80980 - 382700 != -301720)
											{
												goto IL_40;
											}
											continue;
											IL_107:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (189259 - 109257 != 80002)
											{
												goto IL_40;
											}
											goto IL_C2;
										}
										if (243311 - 222865 == 20446)
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
						if (290636 - 130280 == 160356)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060085D3 RID: 34259 RVA: 0x010B8B44 File Offset: 0x010B6D44
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (93259 - 373091 != -279832)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (199135 - 151459 != 47677)
			{
				int i = 0;
				if (72783 - 590600 == -517817)
				{
					CharacterControl[] array2 = array;
					if (211593 - 199490 != 12104)
					{
						int length = array2.Length;
						if (37066 - 488670 != -451603)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (231873 - 491006 == -259132)
								{
									goto IL_1A;
								}
								i++;
								if (291161 - 502183 != -211022)
								{
									goto IL_1A;
								}
							}
							if (263781 - 414821 == -151040)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060085D4 RID: 34260 RVA: 0x010B8C74 File Offset: 0x010B6E74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (164492 - 292693 != -128201)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (139238 - 49709 != 89530)
			{
				Game.mGameState = eGameState.Ready;
				if (272279 - 54920 != 217360)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (190457 - 322854 == -132397)
					{
						if (145530 - 558745 == -413215)
						{
							GameObject gameObject = null;
							if (240881 - 479730 != -238848)
							{
								if (playerSlot <= 1)
								{
									goto IL_15E;
								}
								if (34401 - 436022 == -401620)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_15E;
								}
								if (2514 - 465737 == -463222)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (212781 - 367037 == -154255)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (225401 - 533189 != -307788)
								{
									continue;
								}
								IL_183:
								if (gameObject2)
								{
									if (209181 - 190109 == 19073)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (176505 - 91466 == 85040)
									{
										continue;
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (121410 - 7758 != 113652)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (182510 - 111039 == 71472)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (122458 - 5363 != 117096)
								{
									break;
								}
								continue;
								IL_15E:
								gameObject2 = GameObject.Find("StartPoint1");
								if (6870 - 283705 == -276835)
								{
									goto IL_183;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060085D5 RID: 34261 RVA: 0x010B8F04 File Offset: 0x010B7104
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M605_LightGardenDefense.$StartGame$39880(this).GetEnumerator();
	}

	// Token: 0x060085D6 RID: 34262 RVA: 0x010B8F14 File Offset: 0x010B7114
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060085D7 RID: 34263 RVA: 0x010B8F18 File Offset: 0x010B7118
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (95906 - 309528 != -213621)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (58923 - 515381 == -456458)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (46967 - 212546 == -165579)
				{
					hashtable.Add(43, PlayerData.UID);
					if (43315 - 403563 == -360248)
					{
						hashtable.Add(73, nType);
						if (215125 - 78478 == 136647)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (133437 - 187901 == -54464)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (24260 - 327660 == -303400)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (25272 - 368565 == -343293)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (85643 - 514509 != -428865)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (86454 - 394745 != -308290)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (243530 - 423918 != -180387)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (76910 - 34740 != 42171)
													{
														this.CQicu2LZAnA.OpCustom(63, hashtable, true);
														if (13948 - 151882 != -137933)
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

	// Token: 0x060085D8 RID: 34264 RVA: 0x010B91FC File Offset: 0x010B73FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (168272 - 245541 != -77268)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (181813 - 394411 == -212598)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (27553 - 380444 == -352891)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (150693 - 333670 != -182976)
						{
							if (this.wPecub0hywv <= 0)
							{
								break;
							}
							if (101255 - 257551 == -156296)
							{
								this.wPecub0hywv--;
								if (227948 - 394428 != -166479)
								{
									if (this.wPecub0hywv != 0)
									{
										break;
									}
									if (81335 - 390179 == -308844)
									{
										Game.setGameState(eGameState.Ready);
										if (90828 - 126686 != -35857)
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
						if (202318 - 557931 != -355612)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (78443 - 465076 == -386633)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060085D9 RID: 34265 RVA: 0x010B938C File Offset: 0x010B758C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x060085DA RID: 34266 RVA: 0x010B93A0 File Offset: 0x010B75A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (101145 - 242890 != -141744)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (200643 - 302893 == -102250)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (218732 - 397193 == -178461)
				{
					if (!characterControl)
					{
						break;
					}
					if (21599 - 373510 == -351911)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (187795 - 464176 == -276381)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (265035 - 165951 == 99084)
							{
								string type = characterControl.Type;
								if (257203 - 277948 == -20745)
								{
									if (type == "Panther")
									{
										if (24544 - 56954 != -32409)
										{
											Game.sendMissionEvent(6052, 0);
											if (92974 - 501109 == -408135)
											{
												break;
											}
										}
									}
									else if (type == "Panther_d")
									{
										if (73453 - 462075 == -388622)
										{
											Game.sendMissionEvent(6053, 0);
											if (54208 - 227637 != -173428)
											{
												break;
											}
										}
									}
									else if (type == "Shade1")
									{
										if (284348 - 492414 == -208066)
										{
											Game.sendMissionEvent(6054, 0);
											if (293807 - 111184 == 182623)
											{
												break;
											}
										}
									}
									else if (type == "Shade2")
									{
										if (128924 - 103239 != 25686)
										{
											Game.sendMissionEvent(6055, 0);
											if (293581 - 323800 == -30219)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "Shade3"))
										{
											break;
										}
										if (267850 - 113879 == 153971)
										{
											Game.sendMissionEvent(6056, 0);
											if (74913 - 218749 == -143836)
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

	// Token: 0x060085DB RID: 34267 RVA: 0x010B9668 File Offset: 0x010B7868
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (287 - 259453 != -259166)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (107324 - 403697 != -296372)
			{
				hashtable.Add(71, CID);
				if (254257 - 97802 != 156456)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (69730 - 207144 != -137413)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (251023 - 549986 == -298963)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (100936 - 91373 == 9563)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (104125 - 2721 == 101404)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (176623 - 68412 == 108211)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (138169 - 80274 != 57896)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (168377 - 465294 == -296917)
											{
												this.CQicu2LZAnA.OpCustom(61, hashtable, true);
												if (230702 - 145914 == 84788)
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

	// Token: 0x060085DC RID: 34268 RVA: 0x010B98F4 File Offset: 0x010B7AF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (229875 - 401675 != -171800)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (122838 - 537003 == -414165)
			{
				if (!gameObject)
				{
					break;
				}
				if (72102 - 451918 != -379815)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (178576 - 367727 == -189151)
					{
						playerCameraControl.target = gameObject;
						if (53127 - 379371 == -326244)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (151702 - 9245 != 142458)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060085DD RID: 34269 RVA: 0x010B99EC File Offset: 0x010B7BEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (147288 - 530973 != -383684)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (13330 - 27777 == -14447)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (180725 - 341941 == -161216)
				{
					gameGui.ResetTeamBar();
					if (238371 - 338439 != -100067)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060085DE RID: 34270 RVA: 0x010B9A98 File Offset: 0x010B7C98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M605_LightGardenDefense.$onDeadPlayer$39884(this).GetEnumerator();
	}

	// Token: 0x060085DF RID: 34271 RVA: 0x010B9AA8 File Offset: 0x010B7CA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (137212 - 452969 != -315756)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (13513 - 476496 != -462982)
			{
				this.PJ2cuvtiwyk.target = Game.mPlayer;
				if (2303 - 176225 != -173921)
				{
					this.PJ2cuvtiwyk.enabled = true;
					if (239226 - 277482 == -38256)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (23669 - 465922 != -442253)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (173398 - 43125 != 130273)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (202048 - 308652 == -106604)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (198164 - 197068 == 1096)
							{
								if (!gameGui)
								{
									break;
								}
								if (274799 - 334184 != -59384)
								{
									gameGui.enabled = true;
									if (232789 - 513107 != -280317)
									{
										gameGui.closeDeadMenu();
										if (95646 - 437320 == -341674)
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

	// Token: 0x060085E0 RID: 34272 RVA: 0x010B9C54 File Offset: 0x010B7E54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (65025 - 352806 != -287780)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (97745 - 304957 != -207211)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (237168 - 523987 != -286818)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (54316 - 580051 == -525735)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060085E1 RID: 34273 RVA: 0x010B9D18 File Offset: 0x010B7F18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x060085E2 RID: 34274 RVA: 0x010B9D44 File Offset: 0x010B7F44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M605_LightGardenDefense.$onGameComplete$39890(data, this).GetEnumerator();
	}

	// Token: 0x060085E3 RID: 34275 RVA: 0x010B9D54 File Offset: 0x010B7F54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M605_LightGardenDefense.$ReturnToTown$39899(this).GetEnumerator();
	}

	// Token: 0x060085E4 RID: 34276 RVA: 0x010B9D64 File Offset: 0x010B7F64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M605_LightGardenDefense.$ReturnToGuild$39904(this).GetEnumerator();
	}

	// Token: 0x060085E5 RID: 34277 RVA: 0x010B9D74 File Offset: 0x010B7F74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M605_LightGardenDefense.$ReturnToCamp$39908(this).GetEnumerator();
	}

	// Token: 0x060085E6 RID: 34278 RVA: 0x010B9D84 File Offset: 0x010B7F84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (257548 - 297282 != -39734)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (30652 - 571412 != -540759)
			{
				Hashtable hashtable = new Hashtable();
				if (12598 - 190460 != -177861)
				{
					hashtable.Add(43, PlayerData.UID);
					if (296905 - 578809 == -281904)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (250287 - 578541 == -328254)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060085E7 RID: 34279 RVA: 0x010B9E5C File Offset: 0x010B805C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x060085E8 RID: 34280 RVA: 0x010B9E70 File Offset: 0x010B8070
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (102571 - 356020 != -253449)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (102491 - 133541 != -31049)
			{
				Hashtable hashtable = new Hashtable();
				if (202947 - 201865 == 1082)
				{
					if (Game.mNextGameCode == 30)
					{
						if (282406 - 110134 != 172272)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (240829 - 508792 == -267962)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (220792 - 226733 == -5940)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (108430 - 391730 == -283299)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (169275 - 575782 == -406506)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (269986 - 531190 == -261203)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (202251 - 189211 == 13041)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (97179 - 175964 != -78785)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (60930 - 25878 != 35052)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (92872 - 322005 != -229133)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (257375 - 353918 != -96543)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (19324 - 486106 == -466781)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (45408 - 518645 == -473236)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (63194 - 560595 == -497400)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (250314 - 318881 == -68566)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (36014 - 62138 == -26123)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (293734 - 149205 != 144529)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (286988 - 131216 == 155773)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (53159 - 574474 == -521314)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (68743 - 562879 == -494135)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (135992 - 17278 != 118714)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (10423 - 80877 != -70454)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (256008 - 586142 != -330134)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (11153 - 293951 != -282798)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (157584 - 401344 == -243759)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (133133 - 114056 != 19077)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (210165 - 57804 == 152362)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (182941 - 347185 == -164243)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (110845 - 76835 == 34010)
					{
						this.CQicu2LZAnA.OpCustom(42, hashtable, true);
						if (9085 - 557564 == -548479)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060085E9 RID: 34281 RVA: 0x010BA424 File Offset: 0x010B8624
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x060085EA RID: 34282 RVA: 0x010BA434 File Offset: 0x010B8634
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060085EB RID: 34283 RVA: 0x010BA438 File Offset: 0x010B8638
	internal static bool twEu7NpzzpcB9uQnhppo()
	{
		return true;
	}

	// Token: 0x060085EC RID: 34284 RVA: 0x010BA43C File Offset: 0x010B863C
	internal static bool uhc438Vaa7C8ue7NMfut()
	{
		return false;
	}

	// Token: 0x04008255 RID: 33365
	private LitePeer CQicu2LZAnA;

	// Token: 0x04008256 RID: 33366
	private PlayerCameraControl PJ2cuvtiwyk;

	// Token: 0x04008257 RID: 33367
	private float eV7culASf4a;

	// Token: 0x04008258 RID: 33368
	private Texture GUVcuGUK8Cv;

	// Token: 0x04008259 RID: 33369
	private AudioClip aXycu1wgS9L;

	// Token: 0x0400825A RID: 33370
	private int uOTcuqahXB1;

	// Token: 0x0400825B RID: 33371
	private int hQtcupoWQqX;

	// Token: 0x0400825C RID: 33372
	private int qw0cuRYP2l5;

	// Token: 0x0400825D RID: 33373
	private int G8IcurYtn5r;

	// Token: 0x0400825E RID: 33374
	private int WohcuxXmos3;

	// Token: 0x0400825F RID: 33375
	private int eRdcuTdaK8l;

	// Token: 0x04008260 RID: 33376
	private int wCFcuYSoqCl;

	// Token: 0x04008261 RID: 33377
	private int[] kogcu3gi68c;

	// Token: 0x04008262 RID: 33378
	public GameObject manaPillarEffect;

	// Token: 0x04008263 RID: 33379
	private int wPecub0hywv;

	// Token: 0x02001687 RID: 5767
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$39880 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060085ED RID: 34285 RVA: 0x010BA440 File Offset: 0x010B8640
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$39880(M605_LightGardenDefense self_)
		{
			if (242662 - 43584 != 199079)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (179103 - 462341 == -283238)
				{
					base..ctor();
					if (297931 - 473178 != -175246)
					{
						this.$self_$39883 = self_;
						if (60419 - 107531 != -47111)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060085EE RID: 34286 RVA: 0x010BA4D8 File Offset: 0x010B86D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M605_LightGardenDefense.$StartGame$39880.$(this.$self_$39883);
		}

		// Token: 0x060085EF RID: 34287 RVA: 0x010BA4E8 File Offset: 0x010B86E8
		internal static bool TjpA5iVa5s5jrW2I4dNs()
		{
			return true;
		}

		// Token: 0x060085F0 RID: 34288 RVA: 0x010BA4EC File Offset: 0x010B86EC
		internal static bool u9SN1IVapTqmvuQrsqiu()
		{
			return false;
		}

		// Token: 0x04008264 RID: 33380
		internal M605_LightGardenDefense $self_$39883;

		// Token: 0x02001688 RID: 5768
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060085F1 RID: 34289 RVA: 0x010BA4F0 File Offset: 0x010B86F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M605_LightGardenDefense self_)
			{
				if (75002 - 246929 != -171927)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (188705 - 538259 != -349553)
					{
						base..ctor();
						if (130791 - 576480 != -445688)
						{
							this.$self_$39882 = self_;
							if (261728 - 260787 != 942)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060085F2 RID: 34290 RVA: 0x010BA588 File Offset: 0x010B8788
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (26027 - 245270 != -219243)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_241;
					case 2:
						this.$mGameGui$39881 = (GameGui)this.$self_$39882.GetComponent(typeof(GameGui));
						if (107703 - 147179 != -39476)
						{
							continue;
						}
						this.$mGameGui$39881.enabled = true;
						if (51131 - 115462 != -64331)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (115256 - 167201 == -51944)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (133742 - 453222 == -319479)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (38909 - 191705 == -152795)
						{
							continue;
						}
						if (this.$self_$39882.aXycu1wgS9L)
						{
							if (9758 - 427662 == -417903)
							{
								continue;
							}
							this.$self_$39882.audio.PlayOneShot(this.$self_$39882.aXycu1wgS9L);
							if (291805 - 260768 != 31037)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (95975 - 393368 != -297392)
						{
							goto Block_6;
						}
						continue;
					default:
						if (104358 - 525647 == -421288)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (30728 - 93894 == -63166)
					{
						Game.mGameState = eGameState.Start;
						if (140093 - 398195 == -258102)
						{
							Game.mStateTime = Time.time;
							if (171261 - 440470 == -269209)
							{
								this.$self_$39882.SendMessage("fadeIn");
								if (192737 - 42450 != 150288)
								{
									goto Block_9;
								}
							}
						}
					}
				}
				Block_6:
				goto IL_241;
				Block_9:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_241:
				return false;
			}

			// Token: 0x060085F3 RID: 34291 RVA: 0x010BA7E8 File Offset: 0x010B89E8
			internal static bool VpII7lVaV6RiFCqHRiXy()
			{
				return true;
			}

			// Token: 0x060085F4 RID: 34292 RVA: 0x010BA7EC File Offset: 0x010B89EC
			internal static bool EBBmyiVat55OwpQpoaWD()
			{
				return false;
			}

			// Token: 0x04008265 RID: 33381
			internal GameGui $mGameGui$39881;

			// Token: 0x04008266 RID: 33382
			internal M605_LightGardenDefense $self_$39882;
		}
	}

	// Token: 0x02001689 RID: 5769
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$39884 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060085F5 RID: 34293 RVA: 0x010BA7F0 File Offset: 0x010B89F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$39884(M605_LightGardenDefense self_)
		{
			if (200391 - 593389 != -392998)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (198390 - 4374 != 194017)
				{
					base..ctor();
					if (268554 - 50979 == 217575)
					{
						this.$self_$39889 = self_;
						if (160512 - 135732 == 24780)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060085F6 RID: 34294 RVA: 0x010BA888 File Offset: 0x010B8A88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M605_LightGardenDefense.$onDeadPlayer$39884.$(this.$self_$39889);
		}

		// Token: 0x060085F7 RID: 34295 RVA: 0x010BA898 File Offset: 0x010B8A98
		internal static bool nkTUcmVaNDKBfquUR4hf()
		{
			return true;
		}

		// Token: 0x060085F8 RID: 34296 RVA: 0x010BA89C File Offset: 0x010B8A9C
		internal static bool yWmsqDVaYyWCmAZVbyOa()
		{
			return false;
		}

		// Token: 0x04008267 RID: 33383
		internal M605_LightGardenDefense $self_$39889;

		// Token: 0x0200168A RID: 5770
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060085F9 RID: 34297 RVA: 0x010BA8A0 File Offset: 0x010B8AA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M605_LightGardenDefense self_)
			{
				if (153882 - 9294 != 144588)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (229872 - 466259 == -236387)
					{
						base..ctor();
						if (136787 - 571402 != -434614)
						{
							this.$self_$39888 = self_;
							if (218183 - 6019 != 212165)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060085FA RID: 34298 RVA: 0x010BA938 File Offset: 0x010B8B38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (53446 - 122332 != -68886)
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
							if (112165 - 76835 == 35331)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_229;
							}
							if (140245 - 373796 != -233551)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (220230 - 387822 != -167592)
						{
							continue;
						}
						this.$mStoryGui$39885 = (StoryGui)this.$self_$39888.GetComponent(typeof(StoryGui));
						if (161957 - 153999 != 7958)
						{
							continue;
						}
						if (this.$mStoryGui$39885)
						{
							if (232263 - 555105 == -322841)
							{
								continue;
							}
							this.$mStoryGui$39885.close();
							if (255950 - 324559 == -68608)
							{
								continue;
							}
						}
						this.$mChangeGui$39886 = (ChangeGui)this.$self_$39888.GetComponent(typeof(ChangeGui));
						if (225687 - 194752 != 30935)
						{
							continue;
						}
						if (this.$mChangeGui$39886)
						{
							if (241673 - 446352 == -204678)
							{
								continue;
							}
							this.$mChangeGui$39886.close();
							if (235147 - 501178 == -266030)
							{
								continue;
							}
						}
						this.$mGameGui$39887 = (GameGui)this.$self_$39888.GetComponent(typeof(GameGui));
						if (179215 - 52837 != 126378)
						{
							continue;
						}
						if (this.$mGameGui$39887)
						{
							if (105153 - 413424 == -308270)
							{
								continue;
							}
							if (!this.$mGameGui$39887.enabled)
							{
								if (73282 - 447957 != -374675)
								{
									continue;
								}
								this.$mGameGui$39887.enabled = true;
								if (73231 - 168531 == -95299)
								{
									continue;
								}
							}
							this.$mGameGui$39887.openDeadMenu();
							if (126621 - 445578 != -318957)
							{
								continue;
							}
						}
						IL_229:
						this.YieldDefault(1);
						if (226440 - 477927 != -251487)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (107195 - 399251 == -292055)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (239020 - 208502 == 30519);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x060085FB RID: 34299 RVA: 0x010BAC50 File Offset: 0x010B8E50
			internal static bool cZkortVac1VJVFQGEdvH()
			{
				return true;
			}

			// Token: 0x060085FC RID: 34300 RVA: 0x010BAC54 File Offset: 0x010B8E54
			internal static bool IEgmu4VaUjPgyyXdq7Wf()
			{
				return false;
			}

			// Token: 0x04008268 RID: 33384
			internal StoryGui $mStoryGui$39885;

			// Token: 0x04008269 RID: 33385
			internal ChangeGui $mChangeGui$39886;

			// Token: 0x0400826A RID: 33386
			internal GameGui $mGameGui$39887;

			// Token: 0x0400826B RID: 33387
			internal M605_LightGardenDefense $self_$39888;
		}
	}

	// Token: 0x0200168B RID: 5771
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$39890 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060085FD RID: 34301 RVA: 0x010BAC58 File Offset: 0x010B8E58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$39890(Hashtable data, M605_LightGardenDefense self_)
		{
			if (42753 - 592052 != -549299)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (163247 - 270603 != -107355)
				{
					base..ctor();
					if (205555 - 178080 != 27476)
					{
						this.$data$39897 = data;
						if (81513 - 395572 == -314059)
						{
							this.$self_$39898 = self_;
							if (108575 - 260473 != -151897)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060085FE RID: 34302 RVA: 0x010BAD14 File Offset: 0x010B8F14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M605_LightGardenDefense.$onGameComplete$39890.$(this.$data$39897, this.$self_$39898);
		}

		// Token: 0x060085FF RID: 34303 RVA: 0x010BAD28 File Offset: 0x010B8F28
		internal static bool W2suDDVaTu3EdEm5a0mm()
		{
			return true;
		}

		// Token: 0x06008600 RID: 34304 RVA: 0x010BAD2C File Offset: 0x010B8F2C
		internal static bool Jw9lMfVa315FZeTrC7mH()
		{
			return false;
		}

		// Token: 0x0400826C RID: 33388
		internal Hashtable $data$39897;

		// Token: 0x0400826D RID: 33389
		internal M605_LightGardenDefense $self_$39898;

		// Token: 0x0200168C RID: 5772
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008601 RID: 34305 RVA: 0x010BAD30 File Offset: 0x010B8F30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M605_LightGardenDefense self_)
			{
				if (177734 - 579676 != -401941)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (254285 - 63573 == 190712)
					{
						base..ctor();
						if (219648 - 336724 != -117075)
						{
							this.$data$39895 = data;
							if (209582 - 265092 != -55509)
							{
								this.$self_$39896 = self_;
								if (202917 - 375423 == -172506)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008602 RID: 34306 RVA: 0x010BADEC File Offset: 0x010B8FEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (130524 - 238160 != -107636)
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
						this.$mCompleteGui$39892 = (CompleteGui)this.$self_$39896.GetComponent(typeof(CompleteGui));
						if (255754 - 143220 == 112535)
						{
							continue;
						}
						this.$mCompleteGui$39892.Init();
						if (172053 - 438797 != -266744)
						{
							continue;
						}
						this.$mCompleteGui$39892.readData(this.$data$39895);
						if (231484 - 512786 == -281301)
						{
							continue;
						}
						if (this.$result$39891 == 1)
						{
							if (278165 - 252222 != 25943)
							{
								continue;
							}
							this.$mCompleteGui$39892.displayResult(eCompleteType.Success);
							if (84072 - 211585 != -127513)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$39892.displayResult(eCompleteType.Failed);
							if (192537 - 32145 != 160392)
							{
								continue;
							}
						}
						this.$mGameGui$39893 = (GameGui)this.$self_$39896.GetComponent(typeof(GameGui));
						if (270069 - 90548 == 179522)
						{
							continue;
						}
						this.$mStoryGui$39894 = (StoryGui)this.$self_$39896.GetComponent(typeof(StoryGui));
						if (123679 - 81147 != 42532)
						{
							continue;
						}
						if (this.$mGameGui$39893)
						{
							if (290838 - 450756 == -159917)
							{
								continue;
							}
							this.$mGameGui$39893.close();
							if (6968 - 319066 == -312097)
							{
								continue;
							}
						}
						if (this.$mStoryGui$39894)
						{
							if (157849 - 42406 != 115443)
							{
								continue;
							}
							this.$mStoryGui$39894.close();
							if (81317 - 202975 != -121658)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (197213 - 480906 != -283693)
						{
							continue;
						}
						goto IL_352;
					default:
						if (233374 - 386028 != -152654)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$39895[31]);
					if (247302 - 148918 != 98385)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (175499 - 282598 != -107098)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (240329 - 176751 != 63579)
							{
								this.$result$39891 = RuntimeServices.UnboxInt32(this.$data$39895[31]);
								if (19476 - 288141 == -268665)
								{
									goto IL_11A;
								}
							}
						}
					}
				}
				goto IL_352;
				IL_11A:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x06008603 RID: 34307 RVA: 0x010BB160 File Offset: 0x010B9360
			internal static bool kWytAKVaXFQCj010SwpY()
			{
				return true;
			}

			// Token: 0x06008604 RID: 34308 RVA: 0x010BB164 File Offset: 0x010B9364
			internal static bool rE0k6VVaQcQGwkQuBdgn()
			{
				return false;
			}

			// Token: 0x0400826E RID: 33390
			internal int $result$39891;

			// Token: 0x0400826F RID: 33391
			internal CompleteGui $mCompleteGui$39892;

			// Token: 0x04008270 RID: 33392
			internal GameGui $mGameGui$39893;

			// Token: 0x04008271 RID: 33393
			internal StoryGui $mStoryGui$39894;

			// Token: 0x04008272 RID: 33394
			internal Hashtable $data$39895;

			// Token: 0x04008273 RID: 33395
			internal M605_LightGardenDefense $self_$39896;
		}
	}

	// Token: 0x0200168D RID: 5773
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$39899 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008605 RID: 34309 RVA: 0x010BB168 File Offset: 0x010B9368
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$39899(M605_LightGardenDefense self_)
		{
			if (183011 - 428788 != -245776)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (267002 - 88501 != 178502)
				{
					base..ctor();
					if (141538 - 91092 != 50447)
					{
						this.$self_$39903 = self_;
						if (179276 - 518898 != -339621)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008606 RID: 34310 RVA: 0x010BB200 File Offset: 0x010B9400
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M605_LightGardenDefense.$ReturnToTown$39899.$(this.$self_$39903);
		}

		// Token: 0x06008607 RID: 34311 RVA: 0x010BB210 File Offset: 0x010B9410
		internal static bool NuLU1XVakPJRhbg1JOHj()
		{
			return true;
		}

		// Token: 0x06008608 RID: 34312 RVA: 0x010BB214 File Offset: 0x010B9414
		internal static bool jQ0UgSVaGWrJYWnEd0a9()
		{
			return false;
		}

		// Token: 0x04008274 RID: 33396
		internal M605_LightGardenDefense $self_$39903;

		// Token: 0x0200168E RID: 5774
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008609 RID: 34313 RVA: 0x010BB218 File Offset: 0x010B9418
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M605_LightGardenDefense self_)
			{
				if (211717 - 555205 != -343488)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (217166 - 221983 != -4816)
					{
						base..ctor();
						if (147596 - 158412 == -10816)
						{
							this.$self_$39902 = self_;
							if (211534 - 223121 == -11587)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600860A RID: 34314 RVA: 0x010BB2B0 File Offset: 0x010B94B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (260552 - 194499 != 66054)
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
						this.$self_$39902.LeaveGame();
						if (261073 - 364384 == -103310)
						{
							continue;
						}
						this.YieldDefault(1);
						if (67532 - 388546 != -321013)
						{
							goto Block_27;
						}
						continue;
					default:
						if (268611 - 335721 != -67110)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (294599 - 393360 != -98760)
					{
						Game.mStateTime = Time.time;
						if (260246 - 10359 == 249887)
						{
							this.$$switch$7047$39900 = PlayerData.SaveGuild;
							if (281221 - 403629 != -122407)
							{
								if (this.$$switch$7047$39900 == 1)
								{
									if (146505 - 216012 != -69507)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (12501 - 193150 == -180648)
									{
										continue;
									}
								}
								else if (this.$$switch$7047$39900 == 2)
								{
									if (71656 - 225955 == -154298)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (37381 - 34732 == 2650)
									{
										continue;
									}
								}
								else if (this.$$switch$7047$39900 == 3)
								{
									if (129496 - 152082 == -22585)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (46374 - 153367 != -106993)
									{
										continue;
									}
								}
								else if (this.$$switch$7047$39900 == 4)
								{
									if (4562 - 412650 == -408087)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (183878 - 437277 != -253399)
									{
										continue;
									}
								}
								else if (this.$$switch$7047$39900 == 5)
								{
									if (208830 - 246278 != -37448)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (253877 - 573856 == -319978)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (220172 - 153018 == 67155)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (87198 - 589664 == -502465)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (238709 - 465453 != -226744)
									{
										continue;
									}
								}
								this.$mGameGui$39901 = (GameGui)this.$self_$39902.GetComponent(typeof(GameGui));
								if (101663 - 24403 == 77260)
								{
									if (this.$mGameGui$39901)
									{
										if (119122 - 122340 == -3217)
										{
											continue;
										}
										this.$mGameGui$39901.close();
										if (104772 - 19866 == 84907)
										{
											continue;
										}
									}
									this.$self_$39902.SendMessage("fadeOut");
									if (292490 - 372424 == -79934)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_27:
				IL_3AD:
				return false;
			}

			// Token: 0x0600860B RID: 34315 RVA: 0x010BB67C File Offset: 0x010B987C
			internal static bool ibUVmFVaH2xM1oIsUhlf()
			{
				return true;
			}

			// Token: 0x0600860C RID: 34316 RVA: 0x010BB680 File Offset: 0x010B9880
			internal static bool n2tS6mVaWvtEvLESqPBr()
			{
				return false;
			}

			// Token: 0x04008275 RID: 33397
			internal int $$switch$7047$39900;

			// Token: 0x04008276 RID: 33398
			internal GameGui $mGameGui$39901;

			// Token: 0x04008277 RID: 33399
			internal M605_LightGardenDefense $self_$39902;
		}
	}

	// Token: 0x0200168F RID: 5775
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$39904 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600860D RID: 34317 RVA: 0x010BB684 File Offset: 0x010B9884
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$39904(M605_LightGardenDefense self_)
		{
			if (28256 - 362427 != -334171)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (62139 - 474396 != -412256)
				{
					base..ctor();
					if (220171 - 440268 != -220096)
					{
						this.$self_$39907 = self_;
						if (282179 - 156959 != 125221)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600860E RID: 34318 RVA: 0x010BB71C File Offset: 0x010B991C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M605_LightGardenDefense.$ReturnToGuild$39904.$(this.$self_$39907);
		}

		// Token: 0x0600860F RID: 34319 RVA: 0x010BB72C File Offset: 0x010B992C
		internal static bool lysULVVaAyg3HLWE34VI()
		{
			return true;
		}

		// Token: 0x06008610 RID: 34320 RVA: 0x010BB730 File Offset: 0x010B9930
		internal static bool dxsOrDValbNMfL4ctSP5()
		{
			return false;
		}

		// Token: 0x04008278 RID: 33400
		internal M605_LightGardenDefense $self_$39907;

		// Token: 0x02001690 RID: 5776
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008611 RID: 34321 RVA: 0x010BB734 File Offset: 0x010B9934
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M605_LightGardenDefense self_)
			{
				if (20749 - 90123 != -69374)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (6833 - 413628 == -406795)
					{
						base..ctor();
						if (41463 - 301331 != -259867)
						{
							this.$self_$39906 = self_;
							if (238585 - 537293 == -298708)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008612 RID: 34322 RVA: 0x010BB7CC File Offset: 0x010B99CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (282477 - 188330 != 94147)
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
						this.$self_$39906.LeaveGame();
						if (124112 - 517965 != -393853)
						{
							continue;
						}
						this.YieldDefault(1);
						if (58109 - 73678 != -15569)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (188103 - 116379 != 71724)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (247558 - 256345 == -8787)
					{
						Game.mStateTime = Time.time;
						if (55200 - 4788 != 50413)
						{
							Game.mNextGameCode = 31;
							if (5433 - 595179 == -589746)
							{
								this.$mGameGui$39905 = (GameGui)this.$self_$39906.GetComponent(typeof(GameGui));
								if (261513 - 456808 == -195295)
								{
									if (this.$mGameGui$39905)
									{
										if (152630 - 59464 != 93166)
										{
											continue;
										}
										this.$mGameGui$39905.close();
										if (166857 - 584314 != -417457)
										{
											continue;
										}
									}
									this.$self_$39906.SendMessage("fadeOut");
									if (254652 - 158819 != 95834)
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

			// Token: 0x06008613 RID: 34323 RVA: 0x010BB9A8 File Offset: 0x010B9BA8
			internal static bool cgPpTcVayIx9vnupGC5l()
			{
				return true;
			}

			// Token: 0x06008614 RID: 34324 RVA: 0x010BB9AC File Offset: 0x010B9BAC
			internal static bool VWyc1sVaSMuyyD1Fn2Xv()
			{
				return false;
			}

			// Token: 0x04008279 RID: 33401
			internal GameGui $mGameGui$39905;

			// Token: 0x0400827A RID: 33402
			internal M605_LightGardenDefense $self_$39906;
		}
	}

	// Token: 0x02001691 RID: 5777
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$39908 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008615 RID: 34325 RVA: 0x010BB9B0 File Offset: 0x010B9BB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$39908(M605_LightGardenDefense self_)
		{
			if (288482 - 578632 != -290149)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (248164 - 290175 == -42011)
				{
					base..ctor();
					if (31150 - 550793 == -519643)
					{
						this.$self_$39912 = self_;
						if (232227 - 288592 == -56365)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008616 RID: 34326 RVA: 0x010BBA48 File Offset: 0x010B9C48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M605_LightGardenDefense.$ReturnToCamp$39908.$(this.$self_$39912);
		}

		// Token: 0x06008617 RID: 34327 RVA: 0x010BBA58 File Offset: 0x010B9C58
		internal static bool hsaHseVaonxbR8yM0equ()
		{
			return true;
		}

		// Token: 0x06008618 RID: 34328 RVA: 0x010BBA5C File Offset: 0x010B9C5C
		internal static bool fVMiNGVaEdfawE3CRKKa()
		{
			return false;
		}

		// Token: 0x0400827B RID: 33403
		internal M605_LightGardenDefense $self_$39912;

		// Token: 0x02001692 RID: 5778
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008619 RID: 34329 RVA: 0x010BBA60 File Offset: 0x010B9C60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M605_LightGardenDefense self_)
			{
				if (197631 - 265208 != -67577)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (216388 - 136067 != 80322)
					{
						base..ctor();
						if (30425 - 352874 != -322448)
						{
							this.$self_$39911 = self_;
							if (260657 - 268408 == -7751)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600861A RID: 34330 RVA: 0x010BBAF8 File Offset: 0x010B9CF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (118148 - 583195 != -465047)
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
						this.$self_$39911.LeaveGame();
						if (252846 - 252585 == 262)
						{
							continue;
						}
						this.YieldDefault(1);
						if (177507 - 209541 != -32033)
						{
							goto Block_3;
						}
						continue;
					default:
						if (113426 - 325306 == -211879)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (43517 - 55934 == -12417)
					{
						Game.mStateTime = Time.time;
						if (237719 - 589587 == -351868)
						{
							this.$$switch$7049$39909 = PlayerData.SaveGuild;
							if (185204 - 302227 != -117022)
							{
								if (this.$$switch$7049$39909 == 1)
								{
									if (96746 - 372223 == -275476)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (240450 - 553104 != -312654)
									{
										continue;
									}
								}
								else if (this.$$switch$7049$39909 == 2)
								{
									if (257548 - 259472 != -1924)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (82366 - 404837 == -322470)
									{
										continue;
									}
								}
								else if (this.$$switch$7049$39909 == 3)
								{
									if (249634 - 507436 == -257801)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (107498 - 387617 != -280119)
									{
										continue;
									}
								}
								else if (this.$$switch$7049$39909 == 4)
								{
									if (147807 - 599415 == -451607)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (55970 - 209338 == -153367)
									{
										continue;
									}
								}
								else if (this.$$switch$7049$39909 == 5)
								{
									if (176871 - 375305 != -198434)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (207136 - 205055 == 2082)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (69819 - 317014 != -247195)
									{
										continue;
									}
								}
								this.$mGameGui$39910 = (GameGui)this.$self_$39911.GetComponent(typeof(GameGui));
								if (185611 - 17371 != 168241)
								{
									if (this.$mGameGui$39910)
									{
										if (39802 - 385024 != -345222)
										{
											continue;
										}
										this.$mGameGui$39910.close();
										if (280239 - 277221 != 3018)
										{
											continue;
										}
									}
									this.$self_$39911.SendMessage("fadeOut");
									if (226683 - 129928 == 96755)
									{
										goto IL_B2;
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_363;
				IL_B2:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x0600861B RID: 34331 RVA: 0x010BBE7C File Offset: 0x010BA07C
			internal static bool Gc3NEOVa2lEq7fnH8fMn()
			{
				return true;
			}

			// Token: 0x0600861C RID: 34332 RVA: 0x010BBE80 File Offset: 0x010BA080
			internal static bool yEewJFVa8ok8VMMyn8ew()
			{
				return false;
			}

			// Token: 0x0400827C RID: 33404
			internal int $$switch$7049$39909;

			// Token: 0x0400827D RID: 33405
			internal GameGui $mGameGui$39910;

			// Token: 0x0400827E RID: 33406
			internal M605_LightGardenDefense $self_$39911;
		}
	}
}
