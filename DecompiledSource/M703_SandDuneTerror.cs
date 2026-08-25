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

// Token: 0x02001717 RID: 5911
[Serializable]
public class M703_SandDuneTerror : MonoBehaviour
{
	// Token: 0x06008948 RID: 35144 RVA: 0x010EB898 File Offset: 0x010E9A98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M703_SandDuneTerror()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06008949 RID: 35145 RVA: 0x010EB8A8 File Offset: 0x010E9AA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (250202 - 571920 != -321718)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (217895 - 239963 == -22068)
			{
				Game.mGameType = 5;
				if (258487 - 539047 == -280560)
				{
					if (Chat.Initialized)
					{
						if (26403 - 190648 != -164245)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (30465 - 116434 == -85968)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (170194 - 268714 != -98520)
						{
							continue;
						}
					}
					this.aVJcyffG5cS = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (235772 - 313184 != -77411)
					{
						this.faqcyLdibTi = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (185755 - 516894 == -331139)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600894A RID: 35146 RVA: 0x010EBA00 File Offset: 0x010E9C00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (94967 - 386227 != -291259)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (166407 - 340299 != -173891)
				{
					if (Game.mNextGameCode != 703)
					{
						break;
					}
					if (164940 - 6947 != 157994)
					{
						Game.nextGame();
						if (13030 - 281358 != -268327)
						{
							Game.mGameCode = 703;
							if (187233 - 229508 == -42275)
							{
								Game.mGameType = 5;
								if (266367 - 194399 != 71969)
								{
									Game.mGameTime = Time.time;
									if (6076 - 300482 != -294405)
									{
										Game.mGameScore = 0;
										if (183528 - 535777 != -352248)
										{
											Game.mGameMana = 0;
											if (177661 - 546115 == -368454)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (239046 - 320131 == -81085)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (200429 - 311178 != -110748)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (229761 - 104551 == 125210)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (134128 - 128778 == 5350)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (163494 - 223404 == -59910)
																{
																	this.NdgcyCtEhQI = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (273535 - 292405 == -18870)
																	{
																		this.SPhcyZGUDDI = PhotonClient.Connection;
																		if (49631 - 355655 == -306024)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (284801 - 23102 == 261699)
																			{
																				this.InitGame();
																				if (35689 - 496182 != -460492)
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
				if (80252 - 584177 != -503924)
				{
					Game.mGameType = 99;
					if (265599 - 294203 == -28604)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600894B RID: 35147 RVA: 0x010EBD08 File Offset: 0x010E9F08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (167867 - 67645 != 100222)
		{
		}
		for (;;)
		{
			if (this.SPhcyZGUDDI == null)
			{
				if (140531 - 771 != 139761)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (152946 - 396073 == -243127)
				{
					if (mGameState == eGameState.Init)
					{
						if (259463 - 159031 != 100433)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (278519 - 276536 != 1984)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (60869 - 312160 == -251291)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (260305 - 234512 != 25794)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (199303 - 262798 != -63494)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (102894 - 246079 != -143184)
						{
							if (Game.music != 0)
							{
								if (145179 - 151488 == -6308)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (92299 - 81112 != 11187)
									{
										continue;
									}
									this.audio.Play();
									if (30468 - 183451 == -152982)
									{
										continue;
									}
								}
							}
							this.audio.volume = 0.1f * (float)Game.music;
							if (217248 - 224762 == -7514)
							{
								if (Time.time > this.dwKcyM0AKFt)
								{
									if (34341 - 414431 == -380089)
									{
										continue;
									}
									Game.mGameMana++;
									if (247035 - 446905 != -199870)
									{
										continue;
									}
									this.dwKcyM0AKFt = Time.time + (float)12;
									if (178723 - 85262 != 93461)
									{
										continue;
									}
								}
								this.GameEventUpdate();
								if (287364 - 286806 == 558)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (21517 - 206629 != -185111)
						{
							this.GameEventUpdate();
							if (157220 - 266404 == -109184)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (110461 - 343597 != -233135)
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
						if (142227 - 119426 == 22801)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600894C RID: 35148 RVA: 0x010EC044 File Offset: 0x010EA244
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameEventUpdate()
	{
		if (243640 - 529996 != -286356)
		{
		}
		while (Time.time > this.n2fcyEJYOS3)
		{
			if (299660 - 263922 != 35739)
			{
				this.n2fcyEJYOS3 = Time.time + (float)UnityEngine.Random.Range(24, 60);
				if (53251 - 293159 == -239908)
				{
					if (this.k5XcyN9vXMW >= 9)
					{
						break;
					}
					if (37182 - 425816 == -388634)
					{
						GameObject gameObject = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(1, 7));
						if (48727 - 531042 != -482314)
						{
							if (!gameObject)
							{
								break;
							}
							if (110062 - 489629 != -379566)
							{
								Vector3 randomSpawnPos = global::Math.getRandomSpawnPos(gameObject.transform.position, 5);
								if (238580 - 476700 == -238120)
								{
									if (randomSpawnPos != Vector3.zero)
									{
										if (286762 - 324036 != -37273)
										{
											this.createActor("StingBug2_y", 6, randomSpawnPos, gameObject.transform.forward);
											if (279792 - 435272 != -155479)
											{
												break;
											}
										}
									}
									else
									{
										this.createActor("StingBug2_y", 6, gameObject.transform.position, gameObject.transform.forward);
										if (162417 - 248235 != -85817)
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

	// Token: 0x0600894D RID: 35149 RVA: 0x010EC224 File Offset: 0x010EA424
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (213033 - 380004 != -166971)
		{
		}
		for (;;)
		{
			if (!this.aVJcyffG5cS)
			{
				if (881 - 588278 != -587396)
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
				if (130234 - 252234 != -121999)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (129485 - 38462 != 91024)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (16115 - 353716 == -337601)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (277827 - 532771 == -254944)
							{
								GUI.depth = 1;
								if (29194 - 204156 != -174961)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (158104 - 494091 != -335986)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (261819 - 27479 != 234341)
										{
											Color color = GUI.color;
											if (50517 - 411926 == -361409)
											{
												color.a = a;
												if (287604 - 7895 != 279710)
												{
													if (294672 - 261728 == 32944)
													{
														Color color2 = GUI.color = color;
														if (75364 - 59590 == 15774)
														{
															if (170358 - 406917 != -236558)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.aVJcyffG5cS);
																if (44814 - 179252 == -134438)
																{
																	float a2 = 1f;
																	if (233539 - 34043 != 199497)
																	{
																		Color color3 = GUI.color;
																		if (197117 - 84205 == 112912)
																		{
																			color3.a = a2;
																			if (162559 - 327023 != -164463)
																			{
																				if (198971 - 366424 == -167453)
																				{
																					GUI.color = color3;
																					if (166934 - 247068 != -80133 && 252836 - 455337 != -202500)
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

	// Token: 0x0600894E RID: 35150 RVA: 0x010EC5A4 File Offset: 0x010EA7A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (222398 - 273244 != -50846)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (140365 - 579884 == -439519)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (107897 - 41148 != 66750)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (61151 - 595028 == -533877)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (61021 - 273591 == -212570)
						{
							int num4 = num;
							if (238891 - 253378 == -14487)
							{
								if (num4 == 7031)
								{
									if (203754 - 418925 == -215171)
									{
										this.LxHcyUC4H7g++;
										if (206916 - 548381 != -341464)
										{
											this.SendMessage("newGameMessage", "Mission Objective: StingDune eliminated " + this.LxHcyUC4H7g + "/3");
											if (100600 - 244416 == -143816)
											{
												Chat.SubmitChat("none", "Mission Objective: StingDune eliminated " + this.LxHcyUC4H7g + "/3", eChatType.system, eChatMode.system);
												if (35675 - 321003 != -285327)
												{
													break;
												}
											}
										}
									}
								}
								else if (num4 == 7032)
								{
									if (95942 - 454702 == -358760)
									{
										this.k5XcyN9vXMW--;
										if (247505 - 286548 == -39043)
										{
											Debug.Log("Bug Count:" + this.k5XcyN9vXMW);
											if (9039 - 277487 == -268448)
											{
												break;
											}
										}
									}
								}
								else
								{
									if (num4 != 7033)
									{
										break;
									}
									if (172146 - 77321 != 94826)
									{
										this.k5XcyN9vXMW--;
										if (240430 - 257931 != -17500)
										{
											Debug.Log("Bug Count:" + this.k5XcyN9vXMW);
											if (19607 - 324644 == -305037)
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

	// Token: 0x0600894F RID: 35151 RVA: 0x010EC898 File Offset: 0x010EAA98
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator StartEvent()
	{
		return new M703_SandDuneTerror.$StartEvent$40321(this).GetEnumerator();
	}

	// Token: 0x06008950 RID: 35152 RVA: 0x010EC8A8 File Offset: 0x010EAAA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToLizard(int n)
	{
		return new M703_SandDuneTerror.$TalkToLizard$40325(this).GetEnumerator();
	}

	// Token: 0x06008951 RID: 35153 RVA: 0x010EC8B8 File Offset: 0x010EAAB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (76004 - 369878 != -293873)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (272842 - 267693 != 5150)
			{
				CharacterControl characterControl = null;
				if (110147 - 112236 != -2088)
				{
					if (mPlayer)
					{
						if (19396 - 445096 != -425700)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (183035 - 537583 != -354548)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (26012 - 35315 != -9302)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (240131 - 172345 != 67787)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (156366 - 10552 == 145814)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (292940 - 26591 == 266350)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (291395 - 484010 == -192614)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (206869 - 27089 == 179781)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (287565 - 299198 != -11633)
									{
										continue;
									}
									break;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (48516 - 451022 != -402505)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (151122 - 367139 == -216017)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (265046 - 474136 != -209089)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (249389 - 205954 != 43436)
								{
									if (!changeGui)
									{
										break;
									}
									if (233218 - 346355 == -113137)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (201104 - 277641 == -76536)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (257124 - 410300 != -153176)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (281184 - 286482 != -5297)
										{
											gameGui.close();
											if (181232 - 582542 == -401310)
											{
												changeGui.enabled = true;
												if (138224 - 509770 != -371545)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (90196 - 388168 != -297971)
													{
														if (!gameObject)
														{
															break;
														}
														if (122765 - 362467 != -239701)
														{
															if (!mPlayer)
															{
																break;
															}
															if (199723 - 490527 == -290804)
															{
																Debug.Log("UseLifeAltar");
																if (69679 - 532896 != -463216)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (74652 - 394405 != -319752)
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

	// Token: 0x06008952 RID: 35154 RVA: 0x010ECD18 File Offset: 0x010EAF18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (194997 - 516100 != -321103)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (197611 - 78147 == 119464)
			{
				Time.timeScale = 1f;
				if (233399 - 247333 != -13933)
				{
					Hashtable customOpParameters = new Hashtable();
					if (183458 - 32034 == 151424)
					{
						this.SPhcyZGUDDI.OpCustom(52, customOpParameters, true);
						if (154015 - 280619 != -126603)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008953 RID: 35155 RVA: 0x010ECDE4 File Offset: 0x010EAFE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (81374 - 13391 != 67984)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (93433 - 320569 != -227135)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (201196 - 120697 != 80500)
				{
					Game.mGameState = eGameState.Setup;
					if (207145 - 235148 == -28003)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008954 RID: 35156 RVA: 0x010ECE88 File Offset: 0x010EB088
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (275600 - 568927 != -293327)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (170863 - 47678 != 123186)
			{
				if (num == PlayerData.UID)
				{
					if (35481 - 533121 != -497639)
					{
						this.SetupActors();
						if (21426 - 139510 != -118083)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (210931 - 537279 != -326347)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008955 RID: 35157 RVA: 0x010ECF58 File Offset: 0x010EB158
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (204697 - 527000 != -322302)
		{
		}
		for (;;)
		{
			IL_AA:
			Debug.Log("Creating Actors");
			if (271235 - 108067 != 163169)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (276509 - 408556 != -132046)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (292973 - 420093 != -127119)
						{
							int i = 0;
							if (102604 - 386716 == -284112)
							{
								CharacterControl[] array2 = array;
								if (275080 - 482054 == -206974)
								{
									int length = array2.Length;
									if (67927 - 116093 == -48166)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (283520 - 263735 != 19785)
											{
												goto IL_AA;
											}
											if (type == "StingBug2_y")
											{
												goto IL_22B;
											}
											if (150268 - 36174 == 114095)
											{
												goto IL_AA;
											}
											if (type == "StingDune")
											{
												if (14081 - 206269 != -192187)
												{
													goto IL_22B;
												}
												goto IL_AA;
											}
											IL_F6:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (101798 - 137444 != -35646)
											{
												goto IL_AA;
											}
											this.t4UcySNrK0j++;
											if (284409 - 198576 == 85834)
											{
												goto IL_AA;
											}
											i++;
											if (66532 - 212967 != -146434)
											{
												continue;
											}
											goto IL_AA;
											IL_22B:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (296128 - 489536 != -193407)
											{
												goto IL_F6;
											}
											goto IL_AA;
										}
										if (141633 - 268958 == -127325)
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
						if (218550 - 82023 == 136527)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008956 RID: 35158 RVA: 0x010ED1F8 File Offset: 0x010EB3F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (243286 - 575980 != -332693)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (194754 - 447115 == -252361)
			{
				int i = 0;
				if (280606 - 483703 != -203096)
				{
					CharacterControl[] array2 = array;
					if (8991 - 271516 != -262524)
					{
						int length = array2.Length;
						if (274918 - 328836 == -53918)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (28678 - 123217 == -94538)
								{
									goto IL_1A;
								}
								i++;
								if (158695 - 208093 != -49398)
								{
									goto IL_1A;
								}
							}
							if (149699 - 384382 == -234683)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008957 RID: 35159 RVA: 0x010ED328 File Offset: 0x010EB528
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (261305 - 38763 != 222543)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (253171 - 521974 != -268802)
			{
				Game.mGameState = eGameState.Ready;
				if (146260 - 572086 == -425826)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (201819 - 397058 == -195239)
					{
						if (190712 - 486408 == -295696)
						{
							GameObject gameObject = null;
							if (277584 - 381957 != -104372)
							{
								if (playerSlot < 1)
								{
									goto IL_209;
								}
								if (266952 - 571951 == -304998)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_209;
								}
								if (222568 - 139350 != 83218)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (101496 - 331711 != -230215)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (193420 - 38408 == 155013)
								{
									continue;
								}
								IL_2DE:
								if (gameObject2)
								{
									if (137926 - 402386 != -264460)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (36440 - 598473 != -562033)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (90296 - 351718 == -261421)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (257584 - 592978 != -335394)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (39732 - 326458 != -286726)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (212511 - 395753 == -183241)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (46257 - 103230 == -56972)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (145077 - 350349 != -205271)
								{
									break;
								}
								continue;
								IL_209:
								gameObject2 = GameObject.Find("StartPoint1");
								if (98956 - 364969 == -266013)
								{
									goto IL_2DE;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008958 RID: 35160 RVA: 0x010ED64C File Offset: 0x010EB84C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (148794 - 463615 != -314820)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (276902 - 204919 == 71983)
			{
				Game.mGameState = eGameState.Start;
				if (31213 - 386027 == -354814)
				{
					Game.mGameTime = Time.time;
					if (145063 - 272825 == -127762)
					{
						Game.mStateTime = Time.time;
						if (277440 - 514301 != -236860)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (159574 - 365134 == -205560)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008959 RID: 35161 RVA: 0x010ED738 File Offset: 0x010EB938
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600895A RID: 35162 RVA: 0x010ED73C File Offset: 0x010EB93C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (134484 - 104292 != 30193)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (135189 - 49206 != 85984)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (138419 - 539386 == -400967)
				{
					hashtable.Add(43, PlayerData.UID);
					if (132765 - 575897 != -443131)
					{
						hashtable.Add(73, nType);
						if (238042 - 532076 != -294033)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (153197 - 150962 == 2235)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (77072 - 41721 == 35351)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (78710 - 84823 != -6112)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (291273 - 558701 != -267427)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (232936 - 196194 != 36743)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (138229 - 366551 == -228322)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (179158 - 174842 != 4317)
													{
														this.SPhcyZGUDDI.OpCustom(63, hashtable, true);
														if (21998 - 310635 == -288637)
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

	// Token: 0x0600895B RID: 35163 RVA: 0x010EDA20 File Offset: 0x010EBC20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (28809 - 72179 != -43370)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (290995 - 181872 == 109123)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (63496 - 172812 != -109315)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (256293 - 363380 != -107087)
						{
							continue;
						}
						if (this.t4UcySNrK0j > 0)
						{
							if (231904 - 448863 == -216958)
							{
								continue;
							}
							this.t4UcySNrK0j--;
							if (96692 - 426907 == -330214)
							{
								continue;
							}
							if (this.t4UcySNrK0j == 0)
							{
								if (174600 - 494428 == -319827)
								{
									continue;
								}
								Game.setGameState(eGameState.Ready);
								if (93494 - 100687 == -7192)
								{
									continue;
								}
							}
						}
					}
					else if (Game.mGameState >= eGameState.Normal)
					{
						if (93016 - 154023 == -61006)
						{
							continue;
						}
						gameObject.SendMessage("createSpecialEffect", 1);
						if (211281 - 10439 != 200842)
						{
							continue;
						}
					}
					if (gameObject.layer != 13)
					{
						break;
					}
					if (100663 - 432606 == -331943)
					{
						this.k5XcyN9vXMW++;
						if (60307 - 198963 != -138655)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600895C RID: 35164 RVA: 0x010EDC00 File Offset: 0x010EBE00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600895D RID: 35165 RVA: 0x010EDC14 File Offset: 0x010EBE14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (218613 - 18784 != 199829)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (249156 - 22880 != 226277)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (114039 - 216990 != -102950)
				{
					if (!characterControl)
					{
						break;
					}
					if (178918 - 289499 != -110580)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (266152 - 40832 == 225320)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (65806 - 124911 != -59104)
							{
								string type = characterControl.Type;
								if (113379 - 235145 != -121765)
								{
									if (type == "StingDune")
									{
										if (253694 - 432194 != -178499)
										{
											Game.sendMissionEvent(7031, 0);
											if (83240 - 294759 != -211518)
											{
												break;
											}
										}
									}
									else if (type == "StingQueen")
									{
										if (138918 - 265372 == -126454)
										{
											Game.sendMissionEvent(7032, 0);
											if (61707 - 57024 != 4684)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "StingBug2_y"))
										{
											break;
										}
										if (159868 - 591311 == -431443)
										{
											Game.sendMissionEvent(7033, 0);
											if (221575 - 252084 != -30508)
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

	// Token: 0x0600895E RID: 35166 RVA: 0x010EDE34 File Offset: 0x010EC034
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (101364 - 131432 != -30067)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (26920 - 438383 != -411462)
			{
				hashtable.Add(71, CID);
				if (76881 - 339267 != -262385)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (163291 - 68019 != 95273)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (65088 - 16744 == 48344)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (192460 - 460981 != -268520)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (216362 - 453683 == -237321)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (131182 - 523027 != -391844)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (299704 - 61140 == 238564)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (163772 - 336040 == -172268)
											{
												this.SPhcyZGUDDI.OpCustom(61, hashtable, true);
												if (71523 - 417226 != -345702)
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

	// Token: 0x0600895F RID: 35167 RVA: 0x010EE0C0 File Offset: 0x010EC2C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (123822 - 15927 != 107895)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (19255 - 126218 == -106963)
			{
				if (!gameObject)
				{
					break;
				}
				if (287630 - 354603 != -66972)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (117678 - 71356 != 46323)
					{
						playerCameraControl.target = gameObject;
						if (222107 - 305177 == -83070)
						{
							this.StartGame();
							if (221266 - 152191 != 69076)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008960 RID: 35168 RVA: 0x010EE1B0 File Offset: 0x010EC3B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (262140 - 15747 != 246393)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (67308 - 256288 == -188980)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (44612 - 227077 == -182465)
				{
					gameGui.ResetTeamBar();
					if (100721 - 599302 == -498581)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008961 RID: 35169 RVA: 0x010EE25C File Offset: 0x010EC45C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M703_SandDuneTerror.$onDeadPlayer$40335(this).GetEnumerator();
	}

	// Token: 0x06008962 RID: 35170 RVA: 0x010EE26C File Offset: 0x010EC46C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (163542 - 403623 != -240081)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (167379 - 280123 == -112744)
			{
				this.NdgcyCtEhQI.target = Game.mPlayer;
				if (120167 - 182385 != -62217)
				{
					this.NdgcyCtEhQI.enabled = true;
					if (254190 - 544117 != -289926)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (77213 - 519570 == -442356)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (103330 - 7396 == 95935)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (42896 - 64436 == -21540)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (253126 - 102046 != 151081)
							{
								if (!gameGui)
								{
									break;
								}
								if (148050 - 385023 == -236973)
								{
									gameGui.enabled = true;
									if (198953 - 243286 == -44333)
									{
										gameGui.closeDeadMenu();
										if (96328 - 475737 == -379409)
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

	// Token: 0x06008963 RID: 35171 RVA: 0x010EE418 File Offset: 0x010EC618
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (65578 - 15883 != 49695)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (150882 - 56554 == 94328)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (231974 - 159366 != 72609)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (227558 - 361241 != -133682)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008964 RID: 35172 RVA: 0x010EE4DC File Offset: 0x010EC6DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06008965 RID: 35173 RVA: 0x010EE508 File Offset: 0x010EC708
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (158347 - 566237 != -407889)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (234865 - 421488 == -186623)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (241764 - 217254 == 24510)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (142989 - 466189 != -323199)
					{
						Hashtable hashtable = new Hashtable();
						if (143623 - 88687 != 54937)
						{
							hashtable.Add(43, PlayerData.UID);
							if (72983 - 143175 == -70192)
							{
								hashtable.Add(71, nCID);
								if (226739 - 462155 == -235416)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (195918 - 431676 != -235757)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (165489 - 194225 != -28735)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (164106 - 440953 == -276847)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (108084 - 366376 != -258291)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (223256 - 132975 != 90282)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (17085 - 395505 != -378419)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (250424 - 284319 != -33894)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (136527 - 115020 != 21508)
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

	// Token: 0x06008966 RID: 35174 RVA: 0x010EE828 File Offset: 0x010ECA28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M703_SandDuneTerror.$onChangePlayer$40341(data, this).GetEnumerator();
	}

	// Token: 0x06008967 RID: 35175 RVA: 0x010EE838 File Offset: 0x010ECA38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M703_SandDuneTerror.$onGameComplete$40348(data, this).GetEnumerator();
	}

	// Token: 0x06008968 RID: 35176 RVA: 0x010EE848 File Offset: 0x010ECA48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M703_SandDuneTerror.$ReturnToTown$40358(this).GetEnumerator();
	}

	// Token: 0x06008969 RID: 35177 RVA: 0x010EE858 File Offset: 0x010ECA58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M703_SandDuneTerror.$ReturnToGuild$40363(this).GetEnumerator();
	}

	// Token: 0x0600896A RID: 35178 RVA: 0x010EE868 File Offset: 0x010ECA68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M703_SandDuneTerror.$ReturnToCamp$40367(this).GetEnumerator();
	}

	// Token: 0x0600896B RID: 35179 RVA: 0x010EE878 File Offset: 0x010ECA78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (282154 - 528693 != -246538)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (97802 - 334019 == -236217)
			{
				Hashtable hashtable = new Hashtable();
				if (121232 - 371308 == -250076)
				{
					hashtable.Add(43, PlayerData.UID);
					if (80441 - 446297 != -365855)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (127079 - 31565 != 95515)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600896C RID: 35180 RVA: 0x010EE950 File Offset: 0x010ECB50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600896D RID: 35181 RVA: 0x010EE964 File Offset: 0x010ECB64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (111318 - 342167 != -230849)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (63618 - 317266 != -253647)
			{
				Hashtable hashtable = new Hashtable();
				if (21193 - 245464 == -224271)
				{
					if (Game.mNextGameCode == 30)
					{
						if (113935 - 516547 == -402611)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (206350 - 66933 == 139418)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (129491 - 264367 != -134876)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (237191 - 213307 == 23885)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (270269 - 49160 == 221110)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (26850 - 588662 == -561811)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (275239 - 430637 == -155397)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (159318 - 362067 == -202748)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (154487 - 359459 != -204972)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (250844 - 579098 != -328254)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (86123 - 562669 != -476546)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (74806 - 359952 != -285146)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (271236 - 275793 != -4557)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (16689 - 180228 == -163538)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (38456 - 451305 == -412848)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (53592 - 325571 != -271979)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (40260 - 501383 == -461122)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (145072 - 301133 == -156060)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (266412 - 461075 == -194662)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (280538 - 435073 != -154535)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (83116 - 329700 != -246584)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (101248 - 284278 == -183029)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (200153 - 479591 != -279438)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (218060 - 262506 != -44446)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (121871 - 291473 != -169602)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (299858 - 231360 == 68499)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (91267 - 436198 != -344931)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (202625 - 553303 == -350677)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (205245 - 156612 == 48633)
					{
						this.SPhcyZGUDDI.OpCustom(42, hashtable, true);
						if (130457 - 538430 != -407972)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600896E RID: 35182 RVA: 0x010EEF18 File Offset: 0x010ED118
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600896F RID: 35183 RVA: 0x010EEF28 File Offset: 0x010ED128
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06008970 RID: 35184 RVA: 0x010EEF2C File Offset: 0x010ED12C
	internal static bool yFlsl7VtDnFgAKcpYHDj()
	{
		return true;
	}

	// Token: 0x06008971 RID: 35185 RVA: 0x010EEF30 File Offset: 0x010ED130
	internal static bool AE1JLIVtvrXp0JqXhZwX()
	{
		return false;
	}

	// Token: 0x04008427 RID: 33831
	private LitePeer SPhcyZGUDDI;

	// Token: 0x04008428 RID: 33832
	private PlayerCameraControl NdgcyCtEhQI;

	// Token: 0x04008429 RID: 33833
	private float dwKcyM0AKFt;

	// Token: 0x0400842A RID: 33834
	private Texture aVJcyffG5cS;

	// Token: 0x0400842B RID: 33835
	private AudioClip faqcyLdibTi;

	// Token: 0x0400842C RID: 33836
	private int Y59cyweL1nO;

	// Token: 0x0400842D RID: 33837
	private int LxHcyUC4H7g;

	// Token: 0x0400842E RID: 33838
	private int k5XcyN9vXMW;

	// Token: 0x0400842F RID: 33839
	private float n2fcyEJYOS3;

	// Token: 0x04008430 RID: 33840
	private int DCucyP2s0IG;

	// Token: 0x04008431 RID: 33841
	private int t4UcySNrK0j;

	// Token: 0x02001718 RID: 5912
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$40321 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008972 RID: 35186 RVA: 0x010EEF34 File Offset: 0x010ED134
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$40321(M703_SandDuneTerror self_)
		{
			if (140607 - 585687 != -445079)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (86938 - 519426 == -432488)
				{
					base..ctor();
					if (120762 - 196068 != -75305)
					{
						this.$self_$40324 = self_;
						if (263645 - 562349 != -298703)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008973 RID: 35187 RVA: 0x010EEFCC File Offset: 0x010ED1CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M703_SandDuneTerror.$StartEvent$40321.$(this.$self_$40324);
		}

		// Token: 0x06008974 RID: 35188 RVA: 0x010EEFDC File Offset: 0x010ED1DC
		internal static bool fgvwUYVtRrihiuqNE17c()
		{
			return true;
		}

		// Token: 0x06008975 RID: 35189 RVA: 0x010EEFE0 File Offset: 0x010ED1E0
		internal static bool zZRlPrVtwnsZobIGqWQU()
		{
			return false;
		}

		// Token: 0x04008432 RID: 33842
		internal M703_SandDuneTerror $self_$40324;

		// Token: 0x02001719 RID: 5913
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008976 RID: 35190 RVA: 0x010EEFE4 File Offset: 0x010ED1E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M703_SandDuneTerror self_)
			{
				if (206923 - 427468 != -220545)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (62245 - 68905 == -6660)
					{
						base..ctor();
						if (77041 - 361753 == -284712)
						{
							this.$self_$40323 = self_;
							if (289054 - 210161 == 78893)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008977 RID: 35191 RVA: 0x010EF07C File Offset: 0x010ED27C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (213767 - 214017 != -249)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1D9;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (70146 - 136962 == -66815)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (140172 - 346541 == -206368)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (55263 - 415562 != -360299)
						{
							continue;
						}
						if (this.$self_$40323.faqcyLdibTi)
						{
							if (247391 - 446615 != -199224)
							{
								continue;
							}
							this.$self_$40323.audio.PlayOneShot(this.$self_$40323.faqcyLdibTi);
							if (235675 - 454600 == -218924)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (241620 - 539775 != -298154)
						{
							goto Block_6;
						}
						continue;
					default:
						if (290171 - 43036 != 247135)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$40322 = (GameGui)this.$self_$40323.GetComponent(typeof(GameGui));
					if (253388 - 469274 == -215886)
					{
						this.$mGameGui$40322.enabled = true;
						if (191279 - 429224 != -237944)
						{
							this.$self_$40323.SendMessage("fadeIn");
							if (198729 - 468408 == -269679)
							{
								goto IL_17F;
							}
						}
					}
				}
				Block_6:
				goto IL_1D9;
				IL_17F:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1D9:
				return false;
			}

			// Token: 0x06008978 RID: 35192 RVA: 0x010EF274 File Offset: 0x010ED474
			internal static bool iYbTuTVtqiX4J4fNBicv()
			{
				return true;
			}

			// Token: 0x06008979 RID: 35193 RVA: 0x010EF278 File Offset: 0x010ED478
			internal static bool kTpr5MVt7qBJTg8gF9ik()
			{
				return false;
			}

			// Token: 0x04008433 RID: 33843
			internal GameGui $mGameGui$40322;

			// Token: 0x04008434 RID: 33844
			internal M703_SandDuneTerror $self_$40323;
		}
	}

	// Token: 0x0200171A RID: 5914
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToLizard$40325 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600897A RID: 35194 RVA: 0x010EF27C File Offset: 0x010ED47C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToLizard$40325(M703_SandDuneTerror self_)
		{
			if (228389 - 130083 != 98307)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (270030 - 17655 != 252376)
				{
					base..ctor();
					if (145987 - 567457 != -421469)
					{
						this.$self_$40334 = self_;
						if (226240 - 90322 == 135918)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600897B RID: 35195 RVA: 0x010EF314 File Offset: 0x010ED514
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M703_SandDuneTerror.$TalkToLizard$40325.$(this.$self_$40334);
		}

		// Token: 0x0600897C RID: 35196 RVA: 0x010EF324 File Offset: 0x010ED524
		internal static bool fx0YrUVtPHrTyxMVqp3g()
		{
			return true;
		}

		// Token: 0x0600897D RID: 35197 RVA: 0x010EF328 File Offset: 0x010ED528
		internal static bool cD2vp8Vt06vnaABSc0xt()
		{
			return false;
		}

		// Token: 0x04008435 RID: 33845
		internal M703_SandDuneTerror $self_$40334;

		// Token: 0x0200171B RID: 5915
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600897E RID: 35198 RVA: 0x010EF32C File Offset: 0x010ED52C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M703_SandDuneTerror self_)
			{
				if (170272 - 190348 != -20075)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (230355 - 112809 != 117547)
					{
						base..ctor();
						if (281308 - 438646 == -157338)
						{
							this.$self_$40333 = self_;
							if (56699 - 387803 == -331104)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600897F RID: 35199 RVA: 0x010EF3C4 File Offset: 0x010ED5C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (169545 - 111419 != 58127)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_73E;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (87033 - 573177 != -486144)
							{
								continue;
							}
							goto IL_2D0;
						}
						else
						{
							this.$nMessage$40330 = string.Empty;
							if (126205 - 11342 != 114863)
							{
								continue;
							}
							int num = this.$self_$40333.DCucyP2s0IG = (this.$$10948$40331 = this.$self_$40333.DCucyP2s0IG) + 1;
							this.$$switch$7150$40332 = this.$$10948$40331;
							if (11890 - 564112 != -552222)
							{
								continue;
							}
							if (this.$$switch$7150$40332 == 0)
							{
								if (156504 - 384029 == -227524)
								{
									continue;
								}
								this.$nMessage$40330 = Language.getMessage("M703_SandDuneTerror", 101);
								if (8072 - 535706 != -527634)
								{
									continue;
								}
							}
							else if (this.$$switch$7150$40332 == 1)
							{
								if (73303 - 88950 != -15647)
								{
									continue;
								}
								this.$nMessage$40330 = Language.getMessage("M703_SandDuneTerror", 102);
								if (104138 - 30871 == 73268)
								{
									continue;
								}
							}
							else if (this.$$switch$7150$40332 == 2)
							{
								if (117634 - 506130 != -388496)
								{
									continue;
								}
								this.$nMessage$40330 = Language.getMessage("M703_SandDuneTerror", 103);
								if (186120 - 578046 != -391926)
								{
									continue;
								}
							}
							else
							{
								this.$nMessage$40330 = Language.getMessage("M703_SandDuneTerror", UnityEngine.Random.Range(101, 104));
								if (231671 - 484436 != -252765)
								{
									continue;
								}
							}
							this.$mStoryGui$40327.newStoryMessage("Lizard", "Liza", this.$nMessage$40330, eTalkType.friend);
							if (4911 - 175160 != -170248)
							{
								goto Block_6;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (101840 - 513875 != -412034)
							{
								goto Block_46;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$40327.close();
							if (163600 - 543602 == -380001)
							{
								continue;
							}
							this.$mGameGui$40326.enabled = true;
							if (38465 - 267814 == -229348)
							{
								continue;
							}
							if (!this.$mLizard$40328)
							{
								goto IL_3CD;
							}
							if (68572 - 328417 != -259845)
							{
								continue;
							}
							this.$mLizard$40328.animation.CrossFade("root", 0.2f);
							if (235875 - 555103 != -319228)
							{
								continue;
							}
							this.$mLizard$40328.transform.rotation = this.$mLizardRot$40329;
							if (149569 - 326964 != -177395)
							{
								continue;
							}
							goto IL_3CD;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (234866 - 391369 != -156503)
							{
								continue;
							}
							goto IL_195;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (203648 - 147069 != 56580)
							{
								goto IL_538;
							}
							continue;
						}
						break;
					default:
						if (19252 - 555215 == -535962)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (299152 - 304190 != -5038)
						{
							continue;
						}
						goto IL_35E;
					}
					else
					{
						this.$mGameGui$40326 = (GameGui)this.$self_$40333.GetComponent(typeof(GameGui));
						if (119904 - 408797 == -288892)
						{
							continue;
						}
						this.$mStoryGui$40327 = (StoryGui)this.$self_$40333.GetComponent(typeof(StoryGui));
						if (204487 - 161566 == 42922)
						{
							continue;
						}
						if (this.$mGameGui$40326)
						{
							if (146376 - 85649 != 60727)
							{
								continue;
							}
							if (this.$mStoryGui$40327)
							{
								if (55905 - 41308 == 14598)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (100958 - 516430 == -415471)
								{
									continue;
								}
								this.$mGameGui$40326.close();
								if (192355 - 466180 == -273824)
								{
									continue;
								}
								this.$mLizard$40328 = GameObject.Find("Lizard");
								if (20895 - 345457 != -324562)
								{
									continue;
								}
								this.$mLizardRot$40329 = default(Quaternion);
								if (76062 - 572650 == -496587)
								{
									continue;
								}
								if (!Game.mPlayer)
								{
									goto IL_FA;
								}
								if (149131 - 295922 == -146790)
								{
									continue;
								}
								if (!this.$mLizard$40328)
								{
									goto IL_FA;
								}
								if (10563 - 237799 == -227235)
								{
									continue;
								}
								this.$mLizardRot$40329 = this.$mLizard$40328.transform.rotation;
								if (258209 - 469382 == -211172)
								{
									continue;
								}
								this.$mLizard$40328.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mLizard$40328.transform.position));
								if (215293 - 524095 == -308801)
								{
									continue;
								}
								this.$mLizard$40328.animation.CrossFade("talk", 0.2f);
								if (151214 - 326066 == -174851)
								{
									continue;
								}
								Game.mPlayer.SendMessage("turnToPos", this.$mLizard$40328.transform.position);
								if (241425 - 13099 != 228326)
								{
									continue;
								}
								IL_5F:
								this.$mStoryGui$40327.startStoryMessage("Lizard", "Liza", eTalkType.friend);
								if (189860 - 576447 != -386587)
								{
									continue;
								}
								goto IL_1E5;
								IL_FA:
								Debug.LogError("Cannot find Lizard");
								if (251586 - 133705 != 117882)
								{
									goto IL_5F;
								}
								continue;
							}
						}
					}
					IL_538:
					this.YieldDefault(1);
					if (236815 - 215383 != 21433)
					{
						goto Block_40;
					}
				}
				Block_6:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_195:
				goto IL_73E;
				IL_1E5:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_2D0:
				IL_35E:
				goto IL_73E;
				IL_3CD:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_40:
				Block_46:
				IL_73E:
				return false;
			}

			// Token: 0x06008980 RID: 35200 RVA: 0x010EFB24 File Offset: 0x010EDD24
			internal static bool Woy6QuVtbACcduQN850Z()
			{
				return true;
			}

			// Token: 0x06008981 RID: 35201 RVA: 0x010EFB28 File Offset: 0x010EDD28
			internal static bool i5Gat5VtudopLKP2k2Y1()
			{
				return false;
			}

			// Token: 0x04008436 RID: 33846
			internal GameGui $mGameGui$40326;

			// Token: 0x04008437 RID: 33847
			internal StoryGui $mStoryGui$40327;

			// Token: 0x04008438 RID: 33848
			internal GameObject $mLizard$40328;

			// Token: 0x04008439 RID: 33849
			internal Quaternion $mLizardRot$40329;

			// Token: 0x0400843A RID: 33850
			internal string $nMessage$40330;

			// Token: 0x0400843B RID: 33851
			internal int $$10948$40331;

			// Token: 0x0400843C RID: 33852
			internal int $$switch$7150$40332;

			// Token: 0x0400843D RID: 33853
			internal M703_SandDuneTerror $self_$40333;
		}
	}

	// Token: 0x0200171C RID: 5916
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$40335 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008982 RID: 35202 RVA: 0x010EFB2C File Offset: 0x010EDD2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$40335(M703_SandDuneTerror self_)
		{
			if (276705 - 51375 != 225330)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (106724 - 183206 != -76481)
				{
					base..ctor();
					if (193315 - 255221 != -61905)
					{
						this.$self_$40340 = self_;
						if (39308 - 127923 != -88614)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008983 RID: 35203 RVA: 0x010EFBC4 File Offset: 0x010EDDC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M703_SandDuneTerror.$onDeadPlayer$40335.$(this.$self_$40340);
		}

		// Token: 0x06008984 RID: 35204 RVA: 0x010EFBD4 File Offset: 0x010EDDD4
		internal static bool T26aCRVtIOGOL4sfgoTy()
		{
			return true;
		}

		// Token: 0x06008985 RID: 35205 RVA: 0x010EFBD8 File Offset: 0x010EDDD8
		internal static bool aWaelrVtBwQaSC0KEtRB()
		{
			return false;
		}

		// Token: 0x0400843E RID: 33854
		internal M703_SandDuneTerror $self_$40340;

		// Token: 0x0200171D RID: 5917
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008986 RID: 35206 RVA: 0x010EFBDC File Offset: 0x010EDDDC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M703_SandDuneTerror self_)
			{
				if (26191 - 526914 != -500722)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (168659 - 201481 != -32821)
					{
						base..ctor();
						if (164036 - 243557 != -79520)
						{
							this.$self_$40339 = self_;
							if (6071 - 216902 == -210831)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008987 RID: 35207 RVA: 0x010EFC74 File Offset: 0x010EDE74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (298269 - 175623 != 122647)
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
							goto IL_1F5;
						}
						if (77563 - 519224 == -441660)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (180952 - 390832 != -209880)
							{
								continue;
							}
							goto IL_1F5;
						}
						IL_70:
						this.YieldDefault(1);
						if (155909 - 438019 != -282110)
						{
							continue;
						}
						goto IL_2F9;
						IL_1F5:
						Game.mGameState = eGameState.Hold;
						if (233919 - 38826 == 195094)
						{
							continue;
						}
						this.$mStoryGui$40336 = (StoryGui)this.$self_$40339.GetComponent(typeof(StoryGui));
						if (62251 - 52138 != 10113)
						{
							continue;
						}
						if (this.$mStoryGui$40336)
						{
							if (24665 - 507515 != -482850)
							{
								continue;
							}
							this.$mStoryGui$40336.close();
							if (234069 - 414411 == -180341)
							{
								continue;
							}
						}
						this.$mChangeGui$40337 = (ChangeGui)this.$self_$40339.GetComponent(typeof(ChangeGui));
						if (277428 - 454837 == -177408)
						{
							continue;
						}
						if (this.$mChangeGui$40337)
						{
							if (41601 - 90205 != -48604)
							{
								continue;
							}
							this.$mChangeGui$40337.close();
							if (280507 - 121411 == 159097)
							{
								continue;
							}
						}
						this.$mGameGui$40338 = (GameGui)this.$self_$40339.GetComponent(typeof(GameGui));
						if (86645 - 175923 != -89278)
						{
							continue;
						}
						if (!this.$mGameGui$40338)
						{
							goto IL_70;
						}
						if (214779 - 299999 == -85219)
						{
							continue;
						}
						if (!this.$mGameGui$40338.enabled)
						{
							if (89937 - 450214 == -360276)
							{
								continue;
							}
							this.$mGameGui$40338.enabled = true;
							if (53150 - 359459 == -306308)
							{
								continue;
							}
						}
						this.$mGameGui$40338.openDeadMenu();
						if (74853 - 474254 != -399401)
						{
							continue;
						}
						goto IL_70;
					default:
						if (25463 - 512629 == -487165)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (292588 - 133324 != 159264);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06008988 RID: 35208 RVA: 0x010EFF8C File Offset: 0x010EE18C
			internal static bool dXo5pWVte921f3OMAqpR()
			{
				return true;
			}

			// Token: 0x06008989 RID: 35209 RVA: 0x010EFF90 File Offset: 0x010EE190
			internal static bool Y4qoKKVtrerIJMKpdNCH()
			{
				return false;
			}

			// Token: 0x0400843F RID: 33855
			internal StoryGui $mStoryGui$40336;

			// Token: 0x04008440 RID: 33856
			internal ChangeGui $mChangeGui$40337;

			// Token: 0x04008441 RID: 33857
			internal GameGui $mGameGui$40338;

			// Token: 0x04008442 RID: 33858
			internal M703_SandDuneTerror $self_$40339;
		}
	}

	// Token: 0x0200171E RID: 5918
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$40341 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600898A RID: 35210 RVA: 0x010EFF94 File Offset: 0x010EE194
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$40341(Hashtable data, M703_SandDuneTerror self_)
		{
			if (241787 - 424342 != -182554)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (42085 - 272936 != -230850)
				{
					base..ctor();
					if (87052 - 88677 == -1625)
					{
						this.$data$40346 = data;
						if (214278 - 439357 == -225079)
						{
							this.$self_$40347 = self_;
							if (243743 - 429061 != -185317)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600898B RID: 35211 RVA: 0x010F0050 File Offset: 0x010EE250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M703_SandDuneTerror.$onChangePlayer$40341.$(this.$data$40346, this.$self_$40347);
		}

		// Token: 0x0600898C RID: 35212 RVA: 0x010F0064 File Offset: 0x010EE264
		internal static bool SsLKr2VtjgSiytJdku7G()
		{
			return true;
		}

		// Token: 0x0600898D RID: 35213 RVA: 0x010F0068 File Offset: 0x010EE268
		internal static bool Rd6ApAVthG2KgGCr9itC()
		{
			return false;
		}

		// Token: 0x04008443 RID: 33859
		internal Hashtable $data$40346;

		// Token: 0x04008444 RID: 33860
		internal M703_SandDuneTerror $self_$40347;

		// Token: 0x0200171F RID: 5919
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600898E RID: 35214 RVA: 0x010F006C File Offset: 0x010EE26C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M703_SandDuneTerror self_)
			{
				if (54605 - 167080 != -112475)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (107036 - 416147 == -309111)
					{
						base..ctor();
						if (238916 - 86199 == 152717)
						{
							this.$data$40344 = data;
							if (181503 - 189475 == -7972)
							{
								this.$self_$40345 = self_;
								if (139339 - 594581 != -455241)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600898F RID: 35215 RVA: 0x010F0128 File Offset: 0x010EE328
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (159236 - 266384 != -107147)
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
							if (292488 - 96947 == 195542)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (28646 - 210886 == -182239)
							{
								continue;
							}
							this.$mGameGui$40343 = (GameGui)this.$self_$40345.GetComponent(typeof(GameGui));
							if (221844 - 98758 != 123086)
							{
								continue;
							}
							this.$mGameGui$40343.enabled = true;
							if (30747 - 492291 != -461544)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (138907 - 325353 != -186446)
						{
							continue;
						}
						goto IL_205;
					default:
						if (273355 - 231851 == 41505)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (260747 - 103508 != 157240)
					{
						this.$self_$40345.SendMessage("onCreatePlayer", this.$data$40344);
						if (164058 - 216604 != -52545)
						{
							this.$mChangeGui$40342 = (ChangeGui)this.$self_$40345.GetComponent(typeof(ChangeGui));
							if (260912 - 403341 != -142428)
							{
								if (!this.$mChangeGui$40342.enabled)
								{
									break;
								}
								if (29831 - 560153 == -530322)
								{
									this.$mChangeGui$40342.close();
									if (286398 - 177892 == 108506)
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

			// Token: 0x06008990 RID: 35216 RVA: 0x010F034C File Offset: 0x010EE54C
			internal static bool tBcpIRVtsAkgUymCWp6Z()
			{
				return true;
			}

			// Token: 0x06008991 RID: 35217 RVA: 0x010F0350 File Offset: 0x010EE550
			internal static bool hMwIhjVt9Fb1ZqIyQ2S9()
			{
				return false;
			}

			// Token: 0x04008445 RID: 33861
			internal ChangeGui $mChangeGui$40342;

			// Token: 0x04008446 RID: 33862
			internal GameGui $mGameGui$40343;

			// Token: 0x04008447 RID: 33863
			internal Hashtable $data$40344;

			// Token: 0x04008448 RID: 33864
			internal M703_SandDuneTerror $self_$40345;
		}
	}

	// Token: 0x02001720 RID: 5920
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$40348 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008992 RID: 35218 RVA: 0x010F0354 File Offset: 0x010EE554
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$40348(Hashtable data, M703_SandDuneTerror self_)
		{
			if (33200 - 179235 != -146035)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (162456 - 114912 == 47544)
				{
					base..ctor();
					if (50331 - 397748 == -347417)
					{
						this.$data$40356 = data;
						if (163223 - 133315 == 29908)
						{
							this.$self_$40357 = self_;
							if (144845 - 426683 != -281837)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008993 RID: 35219 RVA: 0x010F0410 File Offset: 0x010EE610
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M703_SandDuneTerror.$onGameComplete$40348.$(this.$data$40356, this.$self_$40357);
		}

		// Token: 0x06008994 RID: 35220 RVA: 0x010F0424 File Offset: 0x010EE624
		internal static bool fNycOjVt1VBuoglpEZd5()
		{
			return true;
		}

		// Token: 0x06008995 RID: 35221 RVA: 0x010F0428 File Offset: 0x010EE628
		internal static bool dqBc7xVt4P1jKiGKwE6e()
		{
			return false;
		}

		// Token: 0x04008449 RID: 33865
		internal Hashtable $data$40356;

		// Token: 0x0400844A RID: 33866
		internal M703_SandDuneTerror $self_$40357;

		// Token: 0x02001721 RID: 5921
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008996 RID: 35222 RVA: 0x010F042C File Offset: 0x010EE62C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M703_SandDuneTerror self_)
			{
				if (73843 - 458114 != -384271)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (4096 - 91294 == -87198)
					{
						base..ctor();
						if (52265 - 506911 != -454645)
						{
							this.$data$40354 = data;
							if (131359 - 340198 != -208838)
							{
								this.$self_$40355 = self_;
								if (155049 - 176739 != -21689)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008997 RID: 35223 RVA: 0x010F04E8 File Offset: 0x010EE6E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (250093 - 593918 != -343824)
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
						this.$mCompleteGui$40350 = (CompleteGui)this.$self_$40355.GetComponent(typeof(CompleteGui));
						if (112029 - 376882 == -264852)
						{
							continue;
						}
						this.$mCompleteGui$40350.Init();
						if (139661 - 530527 == -390865)
						{
							continue;
						}
						this.$mCompleteGui$40350.readData(this.$data$40354);
						if (211100 - 394641 == -183540)
						{
							continue;
						}
						if (this.$result$40349 == 1)
						{
							if (1334 - 398147 != -396813)
							{
								continue;
							}
							this.$mCompleteGui$40350.displayResult(eCompleteType.Success);
							if (156366 - 358410 == -202043)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$40350.displayResult(eCompleteType.Failed);
							if (286188 - 14347 == 271842)
							{
								continue;
							}
						}
						this.$mGameGui$40351 = (GameGui)this.$self_$40355.GetComponent(typeof(GameGui));
						if (157900 - 466704 != -308804)
						{
							continue;
						}
						this.$mStoryGui$40352 = (StoryGui)this.$self_$40355.GetComponent(typeof(StoryGui));
						if (28662 - 264313 == -235650)
						{
							continue;
						}
						this.$mChangeGui$40353 = (ChangeGui)this.$self_$40355.GetComponent(typeof(ChangeGui));
						if (80163 - 563725 != -483562)
						{
							continue;
						}
						if (this.$mGameGui$40351)
						{
							if (102293 - 195078 != -92785)
							{
								continue;
							}
							this.$mGameGui$40351.close();
							if (127219 - 245176 != -117957)
							{
								continue;
							}
						}
						if (this.$mStoryGui$40352)
						{
							if (201839 - 440781 != -238942)
							{
								continue;
							}
							this.$mStoryGui$40352.close();
							if (147855 - 116642 == 31214)
							{
								continue;
							}
						}
						if (this.$mChangeGui$40353)
						{
							if (173836 - 428205 == -254368)
							{
								continue;
							}
							this.$mChangeGui$40353.disable();
							if (266255 - 484734 != -218479)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (16049 - 178175 != -162126)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (207776 - 98791 != 108985)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$40354[31]);
					if (36532 - 460132 == -423600)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (25216 - 261913 == -236697)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (208172 - 303912 != -95739)
							{
								this.$result$40349 = RuntimeServices.UnboxInt32(this.$data$40354[31]);
								if (72767 - 337847 != -265079)
								{
									goto Block_22;
								}
							}
						}
					}
				}
				goto IL_3DB;
				Block_22:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x06008998 RID: 35224 RVA: 0x010F08E4 File Offset: 0x010EEAE4
			internal static bool Ggd6XlVtz8oRoycPYhhR()
			{
				return true;
			}

			// Token: 0x06008999 RID: 35225 RVA: 0x010F08E8 File Offset: 0x010EEAE8
			internal static bool tUUToFVNagGuUhqSMQIv()
			{
				return false;
			}

			// Token: 0x0400844B RID: 33867
			internal int $result$40349;

			// Token: 0x0400844C RID: 33868
			internal CompleteGui $mCompleteGui$40350;

			// Token: 0x0400844D RID: 33869
			internal GameGui $mGameGui$40351;

			// Token: 0x0400844E RID: 33870
			internal StoryGui $mStoryGui$40352;

			// Token: 0x0400844F RID: 33871
			internal ChangeGui $mChangeGui$40353;

			// Token: 0x04008450 RID: 33872
			internal Hashtable $data$40354;

			// Token: 0x04008451 RID: 33873
			internal M703_SandDuneTerror $self_$40355;
		}
	}

	// Token: 0x02001722 RID: 5922
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$40358 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600899A RID: 35226 RVA: 0x010F08EC File Offset: 0x010EEAEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$40358(M703_SandDuneTerror self_)
		{
			if (94109 - 291609 != -197499)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (177723 - 418964 == -241241)
				{
					base..ctor();
					if (35489 - 470221 == -434732)
					{
						this.$self_$40362 = self_;
						if (127129 - 124251 != 2879)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600899B RID: 35227 RVA: 0x010F0984 File Offset: 0x010EEB84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M703_SandDuneTerror.$ReturnToTown$40358.$(this.$self_$40362);
		}

		// Token: 0x0600899C RID: 35228 RVA: 0x010F0994 File Offset: 0x010EEB94
		internal static bool CMTKK6VN5lcjSsFglAJA()
		{
			return true;
		}

		// Token: 0x0600899D RID: 35229 RVA: 0x010F0998 File Offset: 0x010EEB98
		internal static bool SiPSSQVNp1m06s66LqCl()
		{
			return false;
		}

		// Token: 0x04008452 RID: 33874
		internal M703_SandDuneTerror $self_$40362;

		// Token: 0x02001723 RID: 5923
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600899E RID: 35230 RVA: 0x010F099C File Offset: 0x010EEB9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M703_SandDuneTerror self_)
			{
				if (154574 - 575963 != -421388)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (180799 - 76866 == 103933)
					{
						base..ctor();
						if (124453 - 415136 != -290682)
						{
							this.$self_$40361 = self_;
							if (208079 - 153124 == 54955)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600899F RID: 35231 RVA: 0x010F0A34 File Offset: 0x010EEC34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (129702 - 183280 != -53578)
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
						this.$self_$40361.LeaveGame();
						if (139392 - 536510 == -397117)
						{
							continue;
						}
						this.YieldDefault(1);
						if (83072 - 393720 != -310647)
						{
							goto Block_16;
						}
						continue;
					default:
						if (255656 - 461125 != -205469)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (231784 - 208909 != 22876)
					{
						Game.mStateTime = Time.time;
						if (22713 - 317376 != -294662)
						{
							this.$$switch$7156$40359 = PlayerData.SaveGuild;
							if (297532 - 525769 == -228237)
							{
								if (this.$$switch$7156$40359 == 1)
								{
									if (250373 - 275 == 250099)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (188483 - 158120 == 30364)
									{
										continue;
									}
								}
								else if (this.$$switch$7156$40359 == 2)
								{
									if (76918 - 200598 != -123680)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (148594 - 89675 != 58919)
									{
										continue;
									}
								}
								else if (this.$$switch$7156$40359 == 3)
								{
									if (182498 - 328274 != -145776)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (273797 - 395367 != -121570)
									{
										continue;
									}
								}
								else if (this.$$switch$7156$40359 == 4)
								{
									if (106011 - 407019 != -301008)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (46156 - 470613 != -424457)
									{
										continue;
									}
								}
								else if (this.$$switch$7156$40359 == 5)
								{
									if (258684 - 553942 == -295257)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (2989 - 103219 == -100229)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (244968 - 422317 == -177348)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (121824 - 541435 != -419611)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (91738 - 333048 != -241310)
									{
										continue;
									}
								}
								this.$mGameGui$40360 = (GameGui)this.$self_$40361.GetComponent(typeof(GameGui));
								if (219102 - 415534 != -196431)
								{
									if (this.$mGameGui$40360)
									{
										if (218207 - 441564 != -223357)
										{
											continue;
										}
										this.$mGameGui$40360.close();
										if (267556 - 598852 == -331295)
										{
											continue;
										}
									}
									this.$self_$40361.SendMessage("fadeOut");
									if (208758 - 492507 != -283748)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_16:
				IL_3AD:
				return false;
			}

			// Token: 0x060089A0 RID: 35232 RVA: 0x010F0E00 File Offset: 0x010EF000
			internal static bool j98JQAVNVWPBTbLZf23U()
			{
				return true;
			}

			// Token: 0x060089A1 RID: 35233 RVA: 0x010F0E04 File Offset: 0x010EF004
			internal static bool JVc5qYVNtxxZwOFKE78X()
			{
				return false;
			}

			// Token: 0x04008453 RID: 33875
			internal int $$switch$7156$40359;

			// Token: 0x04008454 RID: 33876
			internal GameGui $mGameGui$40360;

			// Token: 0x04008455 RID: 33877
			internal M703_SandDuneTerror $self_$40361;
		}
	}

	// Token: 0x02001724 RID: 5924
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$40363 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060089A2 RID: 35234 RVA: 0x010F0E08 File Offset: 0x010EF008
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$40363(M703_SandDuneTerror self_)
		{
			if (206076 - 588139 != -382062)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (60715 - 179890 == -119175)
				{
					base..ctor();
					if (296406 - 418496 != -122089)
					{
						this.$self_$40366 = self_;
						if (261041 - 214689 == 46352)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060089A3 RID: 35235 RVA: 0x010F0EA0 File Offset: 0x010EF0A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M703_SandDuneTerror.$ReturnToGuild$40363.$(this.$self_$40366);
		}

		// Token: 0x060089A4 RID: 35236 RVA: 0x010F0EB0 File Offset: 0x010EF0B0
		internal static bool xPBJeSVNNqYbO0Kqkpjm()
		{
			return true;
		}

		// Token: 0x060089A5 RID: 35237 RVA: 0x010F0EB4 File Offset: 0x010EF0B4
		internal static bool ptUdtDVNY4PR5QS0lK6c()
		{
			return false;
		}

		// Token: 0x04008456 RID: 33878
		internal M703_SandDuneTerror $self_$40366;

		// Token: 0x02001725 RID: 5925
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060089A6 RID: 35238 RVA: 0x010F0EB8 File Offset: 0x010EF0B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M703_SandDuneTerror self_)
			{
				if (116170 - 182091 != -65920)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (229034 - 408627 == -179593)
					{
						base..ctor();
						if (35935 - 205800 != -169864)
						{
							this.$self_$40365 = self_;
							if (236640 - 312729 != -76088)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060089A7 RID: 35239 RVA: 0x010F0F50 File Offset: 0x010EF150
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (135875 - 343530 != -207654)
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
						this.$self_$40365.LeaveGame();
						if (17974 - 169501 == -151526)
						{
							continue;
						}
						this.YieldDefault(1);
						if (43857 - 373840 != -329983)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (14664 - 553740 != -539076)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (178597 - 320719 == -142122)
					{
						Game.mStateTime = Time.time;
						if (127225 - 482406 != -355180)
						{
							Game.mNextGameCode = 31;
							if (75809 - 402039 == -326230)
							{
								this.$mGameGui$40364 = (GameGui)this.$self_$40365.GetComponent(typeof(GameGui));
								if (143687 - 442254 == -298567)
								{
									if (this.$mGameGui$40364)
									{
										if (2702 - 340793 == -338090)
										{
											continue;
										}
										this.$mGameGui$40364.close();
										if (118727 - 47262 != 71465)
										{
											continue;
										}
									}
									this.$self_$40365.SendMessage("fadeOut");
									if (233863 - 77033 == 156830)
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

			// Token: 0x060089A8 RID: 35240 RVA: 0x010F112C File Offset: 0x010EF32C
			internal static bool xbGxd8VNcMUqeCvSK7GV()
			{
				return true;
			}

			// Token: 0x060089A9 RID: 35241 RVA: 0x010F1130 File Offset: 0x010EF330
			internal static bool LiUmCUVNUACCcroEcKwy()
			{
				return false;
			}

			// Token: 0x04008457 RID: 33879
			internal GameGui $mGameGui$40364;

			// Token: 0x04008458 RID: 33880
			internal M703_SandDuneTerror $self_$40365;
		}
	}

	// Token: 0x02001726 RID: 5926
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$40367 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060089AA RID: 35242 RVA: 0x010F1134 File Offset: 0x010EF334
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$40367(M703_SandDuneTerror self_)
		{
			if (222904 - 148887 != 74018)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (172211 - 374704 != -202492)
				{
					base..ctor();
					if (150341 - 413672 == -263331)
					{
						this.$self_$40371 = self_;
						if (217705 - 255650 == -37945)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060089AB RID: 35243 RVA: 0x010F11CC File Offset: 0x010EF3CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M703_SandDuneTerror.$ReturnToCamp$40367.$(this.$self_$40371);
		}

		// Token: 0x060089AC RID: 35244 RVA: 0x010F11DC File Offset: 0x010EF3DC
		internal static bool dtqIfvVNTF3FQc7mYiLH()
		{
			return true;
		}

		// Token: 0x060089AD RID: 35245 RVA: 0x010F11E0 File Offset: 0x010EF3E0
		internal static bool B6ZMp4VN3Wpf7NnoSn4e()
		{
			return false;
		}

		// Token: 0x04008459 RID: 33881
		internal M703_SandDuneTerror $self_$40371;

		// Token: 0x02001727 RID: 5927
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060089AE RID: 35246 RVA: 0x010F11E4 File Offset: 0x010EF3E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M703_SandDuneTerror self_)
			{
				if (152213 - 310969 != -158755)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (251039 - 177473 != 73567)
					{
						base..ctor();
						if (23003 - 14745 == 8258)
						{
							this.$self_$40370 = self_;
							if (246684 - 470199 == -223515)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060089AF RID: 35247 RVA: 0x010F127C File Offset: 0x010EF47C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (102079 - 283788 != -181708)
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
						this.$self_$40370.LeaveGame();
						if (126014 - 12997 != 113017)
						{
							continue;
						}
						this.YieldDefault(1);
						if (65176 - 67697 != -2521)
						{
							continue;
						}
						goto IL_363;
					default:
						if (186892 - 50211 == 136682)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (179283 - 517891 == -338608)
					{
						Game.mStateTime = Time.time;
						if (206751 - 451092 == -244341)
						{
							this.$$switch$7158$40368 = PlayerData.SaveGuild;
							if (115370 - 431309 == -315939)
							{
								if (this.$$switch$7158$40368 == 1)
								{
									if (75812 - 438686 != -362874)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (31881 - 487732 == -455850)
									{
										continue;
									}
								}
								else if (this.$$switch$7158$40368 == 2)
								{
									if (39000 - 374280 == -335279)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (115542 - 290645 != -175103)
									{
										continue;
									}
								}
								else if (this.$$switch$7158$40368 == 3)
								{
									if (138686 - 487693 == -349006)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (38668 - 346057 != -307389)
									{
										continue;
									}
								}
								else if (this.$$switch$7158$40368 == 4)
								{
									if (105614 - 301314 != -195700)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (220671 - 59973 == 160699)
									{
										continue;
									}
								}
								else if (this.$$switch$7158$40368 == 5)
								{
									if (76187 - 334909 != -258722)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (10626 - 195070 == -184443)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (168460 - 28533 != 139927)
									{
										continue;
									}
								}
								this.$mGameGui$40369 = (GameGui)this.$self_$40370.GetComponent(typeof(GameGui));
								if (79309 - 471616 == -392307)
								{
									if (this.$mGameGui$40369)
									{
										if (273247 - 467845 != -194598)
										{
											continue;
										}
										this.$mGameGui$40369.close();
										if (126798 - 512137 != -385339)
										{
											continue;
										}
									}
									this.$self_$40370.SendMessage("fadeOut");
									if (286465 - 11080 == 275385)
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

			// Token: 0x060089B0 RID: 35248 RVA: 0x010F1600 File Offset: 0x010EF800
			internal static bool jg6ll1VNXwpuoH6M75e2()
			{
				return true;
			}

			// Token: 0x060089B1 RID: 35249 RVA: 0x010F1604 File Offset: 0x010EF804
			internal static bool yeptf5VNQhN90ghhNPm4()
			{
				return false;
			}

			// Token: 0x0400845A RID: 33882
			internal int $$switch$7158$40368;

			// Token: 0x0400845B RID: 33883
			internal GameGui $mGameGui$40369;

			// Token: 0x0400845C RID: 33884
			internal M703_SandDuneTerror $self_$40370;
		}
	}
}
