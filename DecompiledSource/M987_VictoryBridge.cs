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

// Token: 0x02001FE6 RID: 8166
[Serializable]
public class M987_VictoryBridge : MonoBehaviour
{
	// Token: 0x0600BEEF RID: 48879 RVA: 0x0142EE24 File Offset: 0x0142D024
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M987_VictoryBridge()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600BEF0 RID: 48880 RVA: 0x0142EE34 File Offset: 0x0142D034
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (260080 - 313742 != -53661)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (242924 - 244505 == -1581)
			{
				Game.mGameType = 7;
				if (182758 - 22459 != 160300)
				{
					if (Chat.Initialized)
					{
						if (14421 - 131211 != -116790)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (130963 - 39668 != 91295)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (124550 - 34780 != 89770)
						{
							continue;
						}
					}
					this.KflnrmB6fg7 = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (266557 - 475702 != -209144)
					{
						this.ttxnrjH4Os6 = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (170679 - 452824 != -282144)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BEF1 RID: 48881 RVA: 0x0142EF8C File Offset: 0x0142D18C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (101997 - 588546 != -486548)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (178002 - 337264 == -159262)
				{
					if (Game.mNextGameCode != 987)
					{
						break;
					}
					if (256339 - 237049 == 19290)
					{
						Game.nextGame();
						if (108617 - 277044 == -168427)
						{
							Game.mGameCode = 987;
							if (189082 - 309302 != -120219)
							{
								Game.mGameTime = Time.time;
								if (116650 - 35450 != 81201)
								{
									Game.mGameScore = 0;
									if (49861 - 67376 != -17514)
									{
										Game.mGameMana = 0;
										if (257660 - 346370 != -88709)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (268393 - 473466 != -205072)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (25894 - 471652 != -445757)
												{
													Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
													if (244448 - 2957 != 241492)
													{
														Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
														if (192282 - 416380 != -224097)
														{
															Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
															if (64558 - 125505 == -60947)
															{
																this.KjLnric0ea1 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																if (287330 - 287458 == -128)
																{
																	this.nOunr8pfabP = PhotonClient.Connection;
																	if (279256 - 359946 != -80689)
																	{
																		PhotonClient.ActorNrList.Clear();
																		if (231846 - 184909 == 46937)
																		{
																			this.InitGame();
																			if (41652 - 214102 != -172449)
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
			else
			{
				Debug.Log("Not Connected");
				if (261595 - 384652 != -123056)
				{
					Game.mGameType = 99;
					if (216313 - 422117 != -205803)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BEF2 RID: 48882 RVA: 0x0142F274 File Offset: 0x0142D474
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (121325 - 407059 != -285733)
		{
		}
		for (;;)
		{
			if (this.nOunr8pfabP == null)
			{
				if (51689 - 275645 == -223956)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (23183 - 525184 == -502001)
				{
					if (mGameState == eGameState.Init)
					{
						if (19134 - 152619 != -133484)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (116882 - 557593 != -440710)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (16651 - 314843 != -298191)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (104475 - 587007 != -482531)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (40372 - 154776 == -114404)
						{
							if (Game.music != 0)
							{
								if (100502 - 550853 == -450350)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (207256 - 593838 != -386582)
									{
										continue;
									}
									this.audio.Play();
									if (218858 - 497474 == -278615)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (155411 - 107039 == 48372)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (184614 - 546048 == -361434)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (113477 - 416958 == -303481)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (4877 - 486755 == -481878)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (65500 - 296251 != -230750)
							{
								if (Time.time <= this.nJHnrDt1Ods)
								{
									break;
								}
								if (290625 - 549219 == -258594)
								{
									Game.mGameMana++;
									if (37289 - 541846 == -504557)
									{
										this.nJHnrDt1Ods = Time.time + (float)12;
										if (230197 - 200106 == 30091)
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
						if (124033 - 505888 != -381854)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (62757 - 527257 == -464500)
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
						if (78130 - 62573 == 15557)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BEF3 RID: 48883 RVA: 0x0142F61C File Offset: 0x0142D81C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (240792 - 575057 != -334265)
		{
		}
		for (;;)
		{
			if (!this.KflnrmB6fg7)
			{
				if (222880 - 442497 == -219617)
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
				if (197402 - 372323 == -174921)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (287060 - 463838 != -176777)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (246443 - 330456 == -84013)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (66186 - 319353 != -253166)
							{
								GUI.depth = 1;
								if (176810 - 290377 == -113567)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (27975 - 315476 == -287501)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (204616 - 150752 == 53864)
										{
											Color color = GUI.color;
											if (42554 - 194613 != -152058)
											{
												float num3 = color.a = a;
												if (159347 - 77495 == 81852)
												{
													if (59900 - 289994 != -230093)
													{
														GUI.color = color;
														if (27173 - 483238 == -456065)
														{
															if (149334 - 545728 != -396393)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.KflnrmB6fg7);
																if (261593 - 500727 != -239133)
																{
																	float a2 = 1f;
																	if (206309 - 376157 == -169848)
																	{
																		Color color2 = GUI.color;
																		if (184847 - 161345 != 23503)
																		{
																			color2.a = a2;
																			if (78866 - 143719 != -64852)
																			{
																				if (130614 - 171735 == -41121)
																				{
																					Color color3 = GUI.color = color2;
																					if (274530 - 106621 == 167909)
																					{
																						if (131903 - 440243 != -308339)
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

	// Token: 0x0600BEF4 RID: 48884 RVA: 0x0142F99C File Offset: 0x0142DB9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M987_VictoryBridge.$onGameEvent$47418(data, this).GetEnumerator();
	}

	// Token: 0x0600BEF5 RID: 48885 RVA: 0x0142F9AC File Offset: 0x0142DBAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M987_VictoryBridge.$StartEvent$47432(this).GetEnumerator();
	}

	// Token: 0x0600BEF6 RID: 48886 RVA: 0x0142F9BC File Offset: 0x0142DBBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EndEvent()
	{
	}

	// Token: 0x0600BEF7 RID: 48887 RVA: 0x0142F9C0 File Offset: 0x0142DBC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (226609 - 303339 != -76729)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (155110 - 431397 == -276287)
				{
					break;
				}
			}
			else if (Game.mPlayer.layer - 7 != mVar)
			{
				if (200684 - 481500 != -280815)
				{
					this.SendMessage("newGameMessage", "Cannot use other team's LifeAltar");
					if (31192 - 417017 == -385825)
					{
						Chat.SubmitChat("none", "Cannot use other team's LifeAltar", eChatType.system, eChatMode.system);
						if (163445 - 228003 == -64558)
						{
							break;
						}
					}
				}
			}
			else
			{
				GameObject mPlayer = Game.mPlayer;
				if (254073 - 364299 == -110226)
				{
					CharacterControl characterControl = null;
					if (205318 - 36216 == 169102)
					{
						if (mPlayer)
						{
							if (142599 - 270419 != -127820)
							{
								continue;
							}
							characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
							if (29979 - 63356 != -33377)
							{
								continue;
							}
						}
						if (!characterControl)
						{
							if (159987 - 134175 != 25813)
							{
								break;
							}
						}
						else if (characterControl.isTransform)
						{
							if (58132 - 353411 != -295278)
							{
								this.SendMessage("newGameMessage", "Cannot change while transformed");
								if (16624 - 537754 != -521129)
								{
									break;
								}
							}
						}
						else
						{
							if (characterControl.actionState != "standby")
							{
								if (21630 - 227851 == -206220)
								{
									continue;
								}
								if (characterControl.actionState != "run")
								{
									if (112316 - 536683 == -424366)
									{
										continue;
									}
									if (characterControl.actionState != "emotion")
									{
										if (246744 - 121431 == 125314)
										{
											continue;
										}
										this.SendMessage("newGameMessage", "Character not standby");
										if (185497 - 144415 != 41083)
										{
											break;
										}
										continue;
									}
								}
							}
							if (Time.time < characterControl.actionTime + 1f)
							{
								if (151159 - 176395 != -25235)
								{
									this.SendMessage("newGameMessage", "Character not action time out.");
									if (265786 - 322107 == -56321)
									{
										break;
									}
								}
							}
							else
							{
								GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
								if (272262 - 238467 == 33795)
								{
									ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
									if (189745 - 553543 == -363798)
									{
										if (!changeGui)
										{
											break;
										}
										if (2055 - 569922 != -567866)
										{
											if (changeGui.mState != eChangeState.Init)
											{
												if (47355 - 109676 == -62320)
												{
													continue;
												}
												if (changeGui.mState != eChangeState.Disabled)
												{
													break;
												}
												if (68091 - 199509 != -131418)
												{
													continue;
												}
											}
											Game.mGameState = eGameState.Hold;
											if (61142 - 506380 != -445237)
											{
												gameGui.close();
												if (121310 - 125742 != -4431)
												{
													changeGui.enabled = true;
													if (232295 - 318315 == -86020)
													{
														GameObject gameObject = GameObject.Find("LifeAltar");
														if (132590 - 281656 == -149066)
														{
															if (!gameObject)
															{
																break;
															}
															if (283877 - 392936 != -109058)
															{
																if (!mPlayer)
																{
																	break;
																}
																if (181131 - 318508 == -137377)
																{
																	Debug.Log("UseLifeAltar");
																	if (7281 - 62174 != -54892)
																	{
																		mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																		if (203750 - 74169 == 129581)
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

	// Token: 0x0600BEF8 RID: 48888 RVA: 0x0142FED0 File Offset: 0x0142E0D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (80825 - 584599 != -503773)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (64551 - 428454 == -363903)
			{
				Game.mGameState = eGameState.Ready;
				if (91633 - 492425 != -400791)
				{
					MissionClass data2 = MissionData.getData(987);
					if (8188 - 464035 != -455846)
					{
						int playerSlot = Game.getPlayerSlot(PlayerData.UID);
						if (72054 - 518049 == -445995)
						{
							int num = global::Math.div((float)(playerSlot - 1), (float)data2.player) + 1;
							if (47782 - 565399 == -517617)
							{
								if (playerSlot < 1)
								{
									break;
								}
								if (70270 - 83077 != -12806)
								{
									if (playerSlot > 24)
									{
										break;
									}
									if (87683 - 467265 != -379581)
									{
										if (num == 0)
										{
											break;
										}
										if (20390 - 484541 != -464150)
										{
											GameObject gameObject = GameObject.Find("StartPoint" + playerSlot);
											if (167708 - 403267 == -235559)
											{
												GameObject gameObject2 = GameObject.Find("StartCamera" + num);
												if (289842 - 366551 == -76709)
												{
													if (gameObject)
													{
														if (286199 - 399751 == -113551)
														{
															continue;
														}
														Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position);
														if (58139 - 35479 == 22661)
														{
															continue;
														}
														if (spawnPos != Vector3.zero)
														{
															if (159674 - 220395 != -60721)
															{
																continue;
															}
															this.CreatePlayer(CharacterData.current.CID, num, spawnPos, gameObject.transform.forward);
															if (153213 - 945 == 152269)
															{
																continue;
															}
														}
														else
														{
															this.CreatePlayer(CharacterData.current.CID, num, gameObject.transform.position, gameObject.transform.forward);
															if (217635 - 497714 == -280078)
															{
																continue;
															}
														}
													}
													else
													{
														gameObject = GameObject.Find("TestControl");
														if (98885 - 198535 != -99650)
														{
															continue;
														}
													}
													if (!gameObject2)
													{
														break;
													}
													if (226513 - 361382 != -134868)
													{
														this.transform.position = gameObject2.transform.position;
														if (144082 - 562456 != -418373)
														{
															this.transform.rotation = gameObject2.transform.rotation;
															if (276760 - 29446 == 247314)
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

	// Token: 0x0600BEF9 RID: 48889 RVA: 0x01430234 File Offset: 0x0142E434
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (228605 - 447804 != -219198)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (290209 - 397626 != -107416)
			{
				if (gameObject)
				{
					if (155666 - 213774 == -58108)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (155826 - 411623 == -255797)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (233550 - 309574 != -76023)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BEFA RID: 48890 RVA: 0x01430330 File Offset: 0x0142E530
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (33029 - 502748 != -469718)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (256267 - 444347 != -188079)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (248152 - 286483 != -38330)
				{
					hashtable.Add(43, PlayerData.UID);
					if (186699 - 152791 != 33909)
					{
						hashtable.Add(73, nType);
						if (277261 - 586566 == -309305)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (273675 - 454738 != -181062)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (211498 - 52612 != 158887)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (213915 - 502064 == -288149)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (109954 - 449236 != -339281)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (257892 - 74649 == 183243)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (248815 - 311016 == -62201)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (17410 - 185310 != -167899)
													{
														this.nOunr8pfabP.OpCustom(63, hashtable, true);
														if (121110 - 419217 != -298106)
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

	// Token: 0x0600BEFB RID: 48891 RVA: 0x01430614 File Offset: 0x0142E814
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (129733 - 23250 != 106483)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (125917 - 377219 != -251301)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (220764 - 183300 == 37464)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (165036 - 93143 != 71894)
						{
							if (this.AEcnrk5QRKX <= 0)
							{
								break;
							}
							if (150140 - 400966 == -250826)
							{
								this.AEcnrk5QRKX--;
								if (182980 - 543905 != -360924)
								{
									if (this.AEcnrk5QRKX != 0)
									{
										break;
									}
									if (213670 - 29633 == 184037)
									{
										Game.setGameState(eGameState.Ready);
										if (152406 - 367061 != -214654)
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
						if (59769 - 519080 == -459311)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (141257 - 180109 == -38852)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BEFC RID: 48892 RVA: 0x014307A4 File Offset: 0x0142E9A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600BEFD RID: 48893 RVA: 0x014307B8 File Offset: 0x0142E9B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (183704 - 179635 != 4070)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (143912 - 562857 != -418944)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (23298 - 60705 == -37407)
				{
					if (!characterControl)
					{
						break;
					}
					if (252633 - 470457 == -217824)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (129791 - 66318 == 63473)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (126036 - 36825 != 89212)
							{
								string type = characterControl.Type;
								if (59525 - 112733 != -53207)
								{
									if (type == "VictoryTower_b")
									{
										if (165002 - 534326 == -369324)
										{
											Game.sendMissionEvent(9871, 1);
											if (158895 - 228604 != -69708)
											{
												break;
											}
										}
									}
									else if (type == "VictoryTower_r")
									{
										if (47537 - 49771 != -2233)
										{
											Game.sendMissionEvent(9871, 2);
											if (148332 - 492495 != -344162)
											{
												break;
											}
										}
									}
									else if (type == "VictoryCore_b")
									{
										if (70159 - 513053 != -442893)
										{
											Game.sendMissionEvent(9872, 1);
											if (53566 - 534119 != -480552)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "VictoryCore_r"))
										{
											break;
										}
										if (226636 - 156015 != 70622)
										{
											Game.sendMissionEvent(9872, 2);
											if (111933 - 423557 == -311624)
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

	// Token: 0x0600BEFE RID: 48894 RVA: 0x01430A2C File Offset: 0x0142EC2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (199709 - 353219 != -153510)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (218529 - 169173 != 49357)
			{
				hashtable.Add(71, CID);
				if (208243 - 506407 != -298163)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (76641 - 252831 == -176190)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (40410 - 206015 != -165604)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (280754 - 43004 == 237750)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (100729 - 87266 != 13464)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (76650 - 415381 == -338731)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (288977 - 569117 != -280139)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (233822 - 566123 == -332301)
											{
												this.nOunr8pfabP.OpCustom(61, hashtable, true);
												if (86017 - 421953 == -335936)
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

	// Token: 0x0600BEFF RID: 48895 RVA: 0x01430CB8 File Offset: 0x0142EEB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (15118 - 583509 != -568390)
		{
		}
		for (;;)
		{
			IL_1FC:
			GameObject gameObject = Game.createPlayer(data);
			if (121332 - 222417 != -101084)
			{
				if (!gameObject)
				{
					break;
				}
				if (75814 - 252190 != -176375)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (201883 - 231196 != -29312)
					{
						if (characterControl)
						{
							if (81643 - 507721 != -426078)
							{
								continue;
							}
							characterControl.StartCoroutine_Auto(characterControl.addStatus("noDamage", 1, 12, 0, characterControl.ActorNr));
							if (272432 - 578623 != -306191)
							{
								continue;
							}
						}
						PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
						if (153798 - 387764 != -233965)
						{
							playerCameraControl.target = gameObject;
							if (163261 - 539626 != -376364)
							{
								if (Game.mGameState < eGameState.Start)
								{
									if (178170 - 365222 == -187052)
									{
										this.StartGame();
										if (163350 - 217541 == -54191)
										{
											break;
										}
									}
								}
								else
								{
									this.KjLnric0ea1.target = Game.mPlayer;
									if (87463 - 531762 != -444298)
									{
										this.KjLnric0ea1.enabled = true;
										if (237532 - 354597 != -117064)
										{
											if (Game.mGameState == eGameState.Normal)
											{
												goto IL_2B1;
											}
											if (155622 - 450306 == -294683)
											{
												continue;
											}
											if (Game.mGameState == eGameState.Hold)
											{
												if (205585 - 171361 != 34225)
												{
													goto IL_2B1;
												}
												continue;
											}
											IL_3D:
											if (!characterControl)
											{
												break;
											}
											if (35912 - 14275 == 21638)
											{
												continue;
											}
											if (CharacterData.current == null)
											{
												break;
											}
											if (262943 - 498838 != -235895)
											{
												continue;
											}
											characterControl.mTimeOutList = new UnityScript.Lang.Array();
											if (29906 - 596948 == -567041)
											{
												continue;
											}
											IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(CharacterData.current.cooldown);
											if (130172 - 222330 != -92158)
											{
												continue;
											}
											while (enumerator.MoveNext())
											{
												object obj = enumerator.Current;
												object obj3;
												object obj2 = obj3 = obj;
												if (!(obj2 is timeOutClass))
												{
													obj3 = RuntimeServices.Coerce(obj2, typeof(timeOutClass));
												}
												timeOutClass timeOutClass = (timeOutClass)obj3;
												if (154438 - 169971 == -15532)
												{
													goto IL_1FC;
												}
												if (timeOutClass.cTime > Time.time)
												{
													if (99275 - 363980 != -264705)
													{
														goto IL_1FC;
													}
													characterControl.mTimeOutList.Add(timeOutClass);
													if (44190 - 469554 != -425364)
													{
														goto IL_1FC;
													}
													UnityRuntimeServices.Update(enumerator, timeOutClass);
													if (47862 - 375886 == -328023)
													{
														goto IL_1FC;
													}
												}
											}
											if (124979 - 599127 != -474148)
											{
												continue;
											}
											break;
											IL_2B1:
											Game.mGameState = eGameState.Normal;
											if (156809 - 215669 == -58860)
											{
												GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
												if (167217 - 279919 == -112702)
												{
													if (!gameGui)
													{
														goto IL_3D;
													}
													if (65880 - 143189 != -77308)
													{
														gameGui.enabled = true;
														if (194767 - 78547 != 116221)
														{
															gameGui.closeDeadMenu();
															if (37210 - 88935 == -51725)
															{
																goto IL_3D;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BF00 RID: 48896 RVA: 0x0143112C File Offset: 0x0142F32C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (39364 - 362118 != -322753)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPeer(data);
			if (129709 - 577319 != -447609)
			{
				if (!gameObject)
				{
					break;
				}
				if (198185 - 436277 != -238091)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (113939 - 138007 == -24068)
					{
						if (characterControl)
						{
							if (95601 - 534142 != -438541)
							{
								continue;
							}
							characterControl.StartCoroutine_Auto(characterControl.addStatus("noDamage", 1, 12, 0, characterControl.ActorNr));
							if (454 - 571804 != -571350)
							{
								continue;
							}
						}
						GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
						if (99786 - 179807 != -80020)
						{
							gameGui.ResetTeamBar();
							if (263206 - 302869 != -39662)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BF01 RID: 48897 RVA: 0x01431288 File Offset: 0x0142F488
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M987_VictoryBridge.$onDeadPlayer$47436(this).GetEnumerator();
	}

	// Token: 0x0600BF02 RID: 48898 RVA: 0x01431298 File Offset: 0x0142F498
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (53127 - 296506 != -243378)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (160601 - 23630 == 136971)
			{
				this.KjLnric0ea1.target = Game.mPlayer;
				if (296227 - 99142 != 197086)
				{
					this.KjLnric0ea1.enabled = true;
					if (109764 - 374642 == -264878)
					{
						CharacterData.setTimeOut(1, (float)0);
						if (125928 - 237586 == -111658)
						{
							CharacterData.setTimeOut(2, (float)0);
							if (175334 - 198267 != -22932)
							{
								CharacterData.setTimeOut(3, (float)0);
								if (126444 - 32221 == 94223)
								{
									if (Game.mGameState != eGameState.Normal)
									{
										if (55873 - 273924 != -218051)
										{
											continue;
										}
										if (Game.mGameState != eGameState.Hold)
										{
											break;
										}
										if (27441 - 203672 != -176231)
										{
											continue;
										}
									}
									Game.mGameState = eGameState.Normal;
									if (21800 - 190658 == -168858)
									{
										GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
										if (140688 - 433369 != -292680)
										{
											if (!gameGui)
											{
												break;
											}
											if (127698 - 286575 != -158876)
											{
												gameGui.enabled = true;
												if (248516 - 282497 == -33981)
												{
													gameGui.closeDeadMenu();
													if (5510 - 206354 != -200843)
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

	// Token: 0x0600BF03 RID: 48899 RVA: 0x014314AC File Offset: 0x0142F6AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (220648 - 519320 != -298672)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (297755 - 34540 == 263215)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (57505 - 231797 != -174291)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (65620 - 348423 == -282803)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BF04 RID: 48900 RVA: 0x01431570 File Offset: 0x0142F770
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600BF05 RID: 48901 RVA: 0x0143159C File Offset: 0x0142F79C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (31153 - 4253 != 26900)
		{
		}
		for (;;)
		{
			int playerSlot = Game.getPlayerSlot(PlayerData.UID);
			if (144083 - 479409 != -335325)
			{
				MissionClass data = MissionData.getData(987);
				if (270391 - 1548 != 268844)
				{
					int v = global::Math.div((float)(playerSlot - 1), (float)data.player) + 1;
					if (196427 - 374204 == -177777)
					{
						Vector3 position = Game.mPlayer.transform.position;
						if (123423 - 144581 == -21158)
						{
							Vector3 forward = Game.mPlayer.transform.forward;
							if (182541 - 229182 == -46641)
							{
								Hashtable hashtable = new Hashtable();
								if (86022 - 574848 == -488826)
								{
									hashtable.Add(43, PlayerData.UID);
									if (297599 - 327034 == -29435)
									{
										hashtable.Add(71, nCID);
										if (7091 - 240625 != -233533)
										{
											hashtable.Add(75, PhotonClient.cInt16(v));
											if (116596 - 30371 == 86225)
											{
												hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
												if (190414 - 131216 != 59199)
												{
													hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
													if (233502 - 303730 == -70228)
													{
														hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
														if (201442 - 239238 != -37795)
														{
															hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
															if (265156 - 241720 != 23437)
															{
																hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
																if (175197 - 197627 == -22430)
																{
																	hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
																	if (163304 - 69690 != 93615)
																	{
																		PhotonClient.Connection.OpCustom(65, hashtable, true);
																		if (211392 - 554831 == -343439)
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

	// Token: 0x0600BF06 RID: 48902 RVA: 0x01431918 File Offset: 0x0142FB18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M987_VictoryBridge.$onChangePlayer$47442(data, this).GetEnumerator();
	}

	// Token: 0x0600BF07 RID: 48903 RVA: 0x01431928 File Offset: 0x0142FB28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RespawnPlayer(int nCID)
	{
		return new M987_VictoryBridge.$RespawnPlayer$47449(nCID, this).GetEnumerator();
	}

	// Token: 0x0600BF08 RID: 48904 RVA: 0x01431938 File Offset: 0x0142FB38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (251148 - 238641 != 12507)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (243550 - 359628 != -116077)
			{
				Time.timeScale = 1f;
				if (66860 - 199277 != -132416)
				{
					Hashtable customOpParameters = new Hashtable();
					if (201433 - 591579 != -390145)
					{
						this.nOunr8pfabP.OpCustom(52, customOpParameters, true);
						if (217640 - 30048 == 187592)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BF09 RID: 48905 RVA: 0x01431A04 File Offset: 0x0142FC04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (240947 - 290206 != -49258)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (179700 - 328022 != -148321)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (56459 - 245503 != -189043)
				{
					Game.mGameState = eGameState.Setup;
					if (147257 - 80034 != 67224)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BF0A RID: 48906 RVA: 0x01431AA8 File Offset: 0x0142FCA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (243296 - 525300 != -282004)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (11004 - 110080 != -99075)
			{
				if (num == PlayerData.UID)
				{
					if (236697 - 522744 == -286047)
					{
						this.SetupActors();
						if (205910 - 443469 != -237558)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (296014 - 593288 != -297273)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BF0B RID: 48907 RVA: 0x01431B78 File Offset: 0x0142FD78
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (173859 - 542070 != -368211)
		{
		}
		for (;;)
		{
			IL_169:
			Debug.Log("Creating Actors");
			if (34802 - 245693 != -210890)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (25612 - 368070 == -342458)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (243390 - 9370 != 234021)
						{
							int i = 0;
							if (4541 - 166188 == -161647)
							{
								CharacterControl[] array2 = array;
								if (175552 - 352183 == -176631)
								{
									int length = array2.Length;
									if (202180 - 173074 == 29106)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (192312 - 112553 != 79759)
												{
													goto IL_169;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (13837 - 274023 != -260186)
												{
													goto IL_169;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (134571 - 33084 == 101488)
												{
													goto IL_169;
												}
												this.AEcnrk5QRKX++;
												if (701 - 522187 == -521485)
												{
													goto IL_169;
												}
											}
											i++;
											if (196458 - 262204 == -65745)
											{
												goto IL_169;
											}
										}
										if (270714 - 245733 == 24981)
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
						if (84650 - 436926 == -352276)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BF0C RID: 48908 RVA: 0x01431DB4 File Offset: 0x0142FFB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (46751 - 561425 != -514674)
		{
		}
		for (;;)
		{
			IL_84:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (65958 - 135920 != -69961)
			{
				int i = 0;
				if (105161 - 92951 == 12210)
				{
					CharacterControl[] array2 = array;
					if (148599 - 451278 == -302679)
					{
						int length = array2.Length;
						if (114385 - 261699 == -147314)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (134541 - 482533 != -347992)
								{
									goto IL_84;
								}
								i++;
								if (115926 - 246719 != -130793)
								{
									goto IL_84;
								}
							}
							if (243141 - 469024 == -225883)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BF0D RID: 48909 RVA: 0x01431EE4 File Offset: 0x014300E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (212583 - 290739 != -78156)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (60465 - 437347 == -376882)
			{
				Game.mGameState = eGameState.Start;
				if (160129 - 293183 == -133054)
				{
					Game.mGameTime = Time.time;
					if (192639 - 26868 != 165772)
					{
						Game.mStateTime = Time.time;
						if (51826 - 374991 == -323165)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (125175 - 325162 != -199986)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BF0E RID: 48910 RVA: 0x01431FD0 File Offset: 0x014301D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600BF0F RID: 48911 RVA: 0x01431FD4 File Offset: 0x014301D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M987_VictoryBridge.$onGameComplete$47464(data, this).GetEnumerator();
	}

	// Token: 0x0600BF10 RID: 48912 RVA: 0x01431FE4 File Offset: 0x014301E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M987_VictoryBridge.$ReturnToTown$47474(this).GetEnumerator();
	}

	// Token: 0x0600BF11 RID: 48913 RVA: 0x01431FF4 File Offset: 0x014301F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M987_VictoryBridge.$ReturnToGuild$47479(this).GetEnumerator();
	}

	// Token: 0x0600BF12 RID: 48914 RVA: 0x01432004 File Offset: 0x01430204
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M987_VictoryBridge.$ReturnToCamp$47483(this).GetEnumerator();
	}

	// Token: 0x0600BF13 RID: 48915 RVA: 0x01432014 File Offset: 0x01430214
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (204851 - 571741 != -366890)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (204770 - 269302 == -64532)
			{
				Hashtable hashtable = new Hashtable();
				if (214714 - 599632 != -384917)
				{
					hashtable.Add(43, PlayerData.UID);
					if (45804 - 207029 == -161225)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (18038 - 356998 != -338959)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BF14 RID: 48916 RVA: 0x014320EC File Offset: 0x014302EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600BF15 RID: 48917 RVA: 0x01432100 File Offset: 0x01430300
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (239286 - 519208 != -279922)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (106509 - 40518 != 65992)
			{
				Hashtable hashtable = new Hashtable();
				if (154590 - 457910 == -303320)
				{
					if (Game.mNextGameCode == 30)
					{
						if (81186 - 338725 != -257539)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (59658 - 177846 == -118187)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (274288 - 370040 != -95752)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (102961 - 461922 != -358961)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (24991 - 381373 == -356381)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (151047 - 33000 != 118047)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (61648 - 344615 == -282966)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (190045 - 178210 == 11836)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (140469 - 422339 != -281870)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (92150 - 471596 != -379446)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (180698 - 451149 != -270451)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (29975 - 41898 != -11923)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (110612 - 534585 == -423972)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (44650 - 234919 != -190269)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (174804 - 230928 == -56123)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (177444 - 205892 != -28448)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (140605 - 440250 == -299644)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (183329 - 130730 == 52600)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (134912 - 244392 == -109479)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (18386 - 293816 == -275429)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (291344 - 269136 == 22209)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (161305 - 358564 != -197259)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (262044 - 282816 == -20771)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (251127 - 550759 == -299631)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (182877 - 54473 != 128404)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (209744 - 223422 == -13677)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (210392 - 515546 != -305154)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (65417 - 455770 == -390352)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (86047 - 551507 == -465460)
					{
						this.nOunr8pfabP.OpCustom(42, hashtable, true);
						if (198618 - 324301 == -125683)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BF16 RID: 48918 RVA: 0x014326B4 File Offset: 0x014308B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600BF17 RID: 48919 RVA: 0x014326C4 File Offset: 0x014308C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600BF18 RID: 48920 RVA: 0x014326C8 File Offset: 0x014308C8
	internal static bool dNnvvltHZVGTXgZwgstJ()
	{
		return true;
	}

	// Token: 0x0600BF19 RID: 48921 RVA: 0x014326CC File Offset: 0x014308CC
	internal static bool LiSuMitHCiJ9it5ShooC()
	{
		return false;
	}

	// Token: 0x0400A2FD RID: 41725
	private LitePeer nOunr8pfabP;

	// Token: 0x0400A2FE RID: 41726
	private PlayerCameraControl KjLnric0ea1;

	// Token: 0x0400A2FF RID: 41727
	private float nJHnrDt1Ods;

	// Token: 0x0400A300 RID: 41728
	private Texture KflnrmB6fg7;

	// Token: 0x0400A301 RID: 41729
	private AudioClip ttxnrjH4Os6;

	// Token: 0x0400A302 RID: 41730
	private int F30nroJUWAV;

	// Token: 0x0400A303 RID: 41731
	private int AEcnrk5QRKX;

	// Token: 0x02001FE7 RID: 8167
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$47418 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BF1A RID: 48922 RVA: 0x014326D0 File Offset: 0x014308D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$47418(Hashtable data, M987_VictoryBridge self_)
		{
			if (39686 - 140581 != -100895)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (295534 - 114968 != 180567)
				{
					base..ctor();
					if (78704 - 142100 == -63396)
					{
						this.$data$47430 = data;
						if (263546 - 548345 != -284798)
						{
							this.$self_$47431 = self_;
							if (233976 - 8601 == 225375)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BF1B RID: 48923 RVA: 0x0143278C File Offset: 0x0143098C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M987_VictoryBridge.$onGameEvent$47418.$(this.$data$47430, this.$self_$47431);
		}

		// Token: 0x0600BF1C RID: 48924 RVA: 0x014327A0 File Offset: 0x014309A0
		internal static bool KB37r5tHLOZwrS42rPi8()
		{
			return true;
		}

		// Token: 0x0600BF1D RID: 48925 RVA: 0x014327A4 File Offset: 0x014309A4
		internal static bool QeFPPLtHOk6eGSepYBkv()
		{
			return false;
		}

		// Token: 0x0400A304 RID: 41732
		internal Hashtable $data$47430;

		// Token: 0x0400A305 RID: 41733
		internal M987_VictoryBridge $self_$47431;

		// Token: 0x02001FE8 RID: 8168
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BF1E RID: 48926 RVA: 0x014327A8 File Offset: 0x014309A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M987_VictoryBridge self_)
			{
				if (83612 - 420148 != -336535)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (9441 - 310318 == -300877)
					{
						base..ctor();
						if (48707 - 201341 != -152633)
						{
							this.$data$47428 = data;
							if (214310 - 69650 == 144660)
							{
								this.$self_$47429 = self_;
								if (274668 - 215260 != 59409)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BF1F RID: 48927 RVA: 0x01432864 File Offset: 0x01430A64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (207766 - 445380 != -237613)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_13E;
					case 1:
						goto IL_677;
					case 2:
						this.$$switch$8879$47427 = this.$returnValue$47420;
						if (95793 - 95966 != -173)
						{
							continue;
						}
						if (this.$$switch$8879$47427 == 1)
						{
							if (51885 - 334594 != -282709)
							{
								continue;
							}
							if (this.$self_$47429.KjLnric0ea1)
							{
								if (114200 - 283384 == -169183)
								{
									continue;
								}
								this.$self_$47429.KjLnric0ea1.alignToObject("EndCamera1");
								if (136357 - 335532 != -199175)
								{
									continue;
								}
							}
						}
						else if (this.$$switch$8879$47427 == 2)
						{
							if (182006 - 120402 != 61604)
							{
								continue;
							}
							if (this.$self_$47429.KjLnric0ea1)
							{
								if (162563 - 262361 != -99798)
								{
									continue;
								}
								this.$self_$47429.KjLnric0ea1.alignToObject("EndCamera2");
								if (292795 - 429007 != -136212)
								{
									continue;
								}
							}
						}
						this.$self_$47429.SendMessage("fadeIn");
						if (103029 - 298673 != -195643)
						{
							goto Block_43;
						}
						continue;
					case 3:
						Game.sendMissionEvent(9873, this.$returnValue$47420);
						if (35025 - 43347 != -8322)
						{
							continue;
						}
						break;
					default:
						if (2436 - 549495 != -547059)
						{
							continue;
						}
						goto IL_13E;
					}
					IL_1F:
					this.YieldDefault(1);
					if (258013 - 28608 != 229405)
					{
						continue;
					}
					break;
					IL_13E:
					if (Game.mGameState > eGameState.AllHold)
					{
						if (30344 - 438464 != -408119)
						{
							break;
						}
					}
					else
					{
						this.$returnCode$47419 = RuntimeServices.UnboxInt32(this.$data$47428[141]);
						if (24999 - 99646 == -74647)
						{
							this.$returnValue$47420 = RuntimeServices.UnboxInt32(this.$data$47428[145]);
							if (224400 - 504 != 223897)
							{
								this.$ownerID$47421 = RuntimeServices.UnboxInt32(this.$data$47428[43]);
								if (46084 - 265679 != -219594)
								{
									this.$$switch$8881$47422 = this.$returnCode$47419;
									if (23494 - 395939 == -372445)
									{
										if (this.$$switch$8881$47422 == 9871)
										{
											if (296985 - 326328 != -29342)
											{
												this.$$switch$8877$47423 = this.$returnValue$47420;
												if (70392 - 406596 != -336203)
												{
													if (this.$$switch$8877$47423 == 1)
													{
														if (192860 - 46579 != 146281)
														{
															continue;
														}
														this.$self_$47429.SendMessage("newGameMessage", "Team2 capture a VictoryTower!");
														if (97847 - 260299 == -162451)
														{
															continue;
														}
													}
													else if (this.$$switch$8877$47423 == 2)
													{
														if (160844 - 83009 != 77835)
														{
															continue;
														}
														this.$self_$47429.SendMessage("newGameMessage", "Team1 capture a VictoryTower!");
														if (28318 - 357157 == -328838)
														{
															continue;
														}
													}
													goto IL_1F;
												}
											}
										}
										else if (this.$$switch$8881$47422 == 9872)
										{
											if (232447 - 328150 == -95703)
											{
												Game.mGameState = eGameState.AllHold;
												if (264683 - 599672 != -334988)
												{
													this.$mGameGui$47424 = (GameGui)this.$self_$47429.GetComponent(typeof(GameGui));
													if (17826 - 15281 != 2546)
													{
														this.$mStoryGui$47425 = (StoryGui)this.$self_$47429.GetComponent(typeof(StoryGui));
														if (140228 - 471803 != -331574)
														{
															this.$mChangeGui$47426 = (ChangeGui)this.$self_$47429.GetComponent(typeof(ChangeGui));
															if (32196 - 89358 == -57162)
															{
																if (this.$mGameGui$47424)
																{
																	if (254385 - 21543 != 232842)
																	{
																		continue;
																	}
																	this.$mGameGui$47424.close();
																	if (292311 - 438601 == -146289)
																	{
																		continue;
																	}
																}
																if (this.$mStoryGui$47425)
																{
																	if (6043 - 296777 == -290733)
																	{
																		continue;
																	}
																	this.$mStoryGui$47425.close();
																	if (99711 - 40691 != 59020)
																	{
																		continue;
																	}
																}
																if (this.$mChangeGui$47426)
																{
																	if (257693 - 142989 != 114704)
																	{
																		continue;
																	}
																	this.$mChangeGui$47426.disable();
																	if (215657 - 194839 != 20818)
																	{
																		continue;
																	}
																}
																this.$self_$47429.SendMessage("fadeOut");
																if (118815 - 536800 != -417984)
																{
																	goto Block_26;
																}
															}
														}
													}
												}
											}
										}
										else
										{
											Debug.LogError("Warning unknown returnCode:" + this.$returnCode$47419);
											if (138228 - 271656 != -133427)
											{
												goto IL_1F;
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_677;
				Block_26:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_43:
				return this.Yield(3, new WaitForSeconds((float)6));
				IL_677:
				return false;
			}

			// Token: 0x0600BF20 RID: 48928 RVA: 0x01432EFC File Offset: 0x014310FC
			internal static bool t9a5hntHm30Rji6wwMwF()
			{
				return true;
			}

			// Token: 0x0600BF21 RID: 48929 RVA: 0x01432F00 File Offset: 0x01431100
			internal static bool ne4ZXUtHF9eywdFsAI1X()
			{
				return false;
			}

			// Token: 0x0400A306 RID: 41734
			internal int $returnCode$47419;

			// Token: 0x0400A307 RID: 41735
			internal int $returnValue$47420;

			// Token: 0x0400A308 RID: 41736
			internal int $ownerID$47421;

			// Token: 0x0400A309 RID: 41737
			internal int $$switch$8881$47422;

			// Token: 0x0400A30A RID: 41738
			internal int $$switch$8877$47423;

			// Token: 0x0400A30B RID: 41739
			internal GameGui $mGameGui$47424;

			// Token: 0x0400A30C RID: 41740
			internal StoryGui $mStoryGui$47425;

			// Token: 0x0400A30D RID: 41741
			internal ChangeGui $mChangeGui$47426;

			// Token: 0x0400A30E RID: 41742
			internal int $$switch$8879$47427;

			// Token: 0x0400A30F RID: 41743
			internal Hashtable $data$47428;

			// Token: 0x0400A310 RID: 41744
			internal M987_VictoryBridge $self_$47429;
		}
	}

	// Token: 0x02001FE9 RID: 8169
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$47432 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BF22 RID: 48930 RVA: 0x01432F04 File Offset: 0x01431104
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$47432(M987_VictoryBridge self_)
		{
			if (232760 - 34393 != 198367)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (77427 - 299174 != -221746)
				{
					base..ctor();
					if (242208 - 67414 != 174795)
					{
						this.$self_$47435 = self_;
						if (2094 - 425228 != -423133)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BF23 RID: 48931 RVA: 0x01432F9C File Offset: 0x0143119C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M987_VictoryBridge.$StartEvent$47432.$(this.$self_$47435);
		}

		// Token: 0x0600BF24 RID: 48932 RVA: 0x01432FAC File Offset: 0x014311AC
		internal static bool a4yMVvtHM566N8Plq6ns()
		{
			return true;
		}

		// Token: 0x0600BF25 RID: 48933 RVA: 0x01432FB0 File Offset: 0x014311B0
		internal static bool utVITktHxZZxaVWmMlOo()
		{
			return false;
		}

		// Token: 0x0400A311 RID: 41745
		internal M987_VictoryBridge $self_$47435;

		// Token: 0x02001FEA RID: 8170
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BF26 RID: 48934 RVA: 0x01432FB4 File Offset: 0x014311B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M987_VictoryBridge self_)
			{
				if (291517 - 356147 != -64629)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (193495 - 174368 != 19128)
					{
						base..ctor();
						if (236728 - 305413 != -68684)
						{
							this.$self_$47434 = self_;
							if (193355 - 297530 == -104175)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BF27 RID: 48935 RVA: 0x0143304C File Offset: 0x0143124C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (92343 - 212390 != -120047)
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
						if (264055 - 490146 != -226091)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (13356 - 278726 == -265369)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (8061 - 81897 != -73836)
						{
							continue;
						}
						if (this.$self_$47434.ttxnrjH4Os6)
						{
							if (214360 - 435104 == -220743)
							{
								continue;
							}
							this.$self_$47434.audio.PlayOneShot(this.$self_$47434.ttxnrjH4Os6);
							if (262255 - 123551 == 138705)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (218255 - 113316 != 104939)
						{
							continue;
						}
						goto IL_1D9;
					default:
						if (105129 - 265074 != -159945)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$47433 = (GameGui)this.$self_$47434.GetComponent(typeof(GameGui));
					if (195686 - 187925 == 7761)
					{
						this.$mGameGui$47433.enabled = true;
						if (232908 - 308639 == -75731)
						{
							this.$self_$47434.SendMessage("fadeIn");
							if (43518 - 73534 == -30016)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1D9:
				return false;
			}

			// Token: 0x0600BF28 RID: 48936 RVA: 0x01433244 File Offset: 0x01431444
			internal static bool yve7QZtHgd5gj34OhBWk()
			{
				return true;
			}

			// Token: 0x0600BF29 RID: 48937 RVA: 0x01433248 File Offset: 0x01431448
			internal static bool YO5dsCtHf63vo8vm8wpC()
			{
				return false;
			}

			// Token: 0x0400A312 RID: 41746
			internal GameGui $mGameGui$47433;

			// Token: 0x0400A313 RID: 41747
			internal M987_VictoryBridge $self_$47434;
		}
	}

	// Token: 0x02001FEB RID: 8171
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$47436 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BF2A RID: 48938 RVA: 0x0143324C File Offset: 0x0143144C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$47436(M987_VictoryBridge self_)
		{
			if (71350 - 366491 != -295141)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (88997 - 233037 == -144040)
				{
					base..ctor();
					if (270307 - 81211 != 189097)
					{
						this.$self_$47441 = self_;
						if (216601 - 47005 != 169597)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BF2B RID: 48939 RVA: 0x014332E4 File Offset: 0x014314E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M987_VictoryBridge.$onDeadPlayer$47436.$(this.$self_$47441);
		}

		// Token: 0x0600BF2C RID: 48940 RVA: 0x014332F4 File Offset: 0x014314F4
		internal static bool lWgc9ttHnHTxrrRjgeRv()
		{
			return true;
		}

		// Token: 0x0600BF2D RID: 48941 RVA: 0x014332F8 File Offset: 0x014314F8
		internal static bool Hc07bmtH6Y83pMkDWVVW()
		{
			return false;
		}

		// Token: 0x0400A314 RID: 41748
		internal M987_VictoryBridge $self_$47441;

		// Token: 0x02001FEC RID: 8172
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BF2E RID: 48942 RVA: 0x014332FC File Offset: 0x014314FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M987_VictoryBridge self_)
			{
				if (106247 - 279595 != -173347)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (114615 - 252481 == -137866)
					{
						base..ctor();
						if (16487 - 74116 != -57628)
						{
							this.$self_$47440 = self_;
							if (121104 - 536883 == -415779)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BF2F RID: 48943 RVA: 0x01433394 File Offset: 0x01431594
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (259585 - 153368 != 106217)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_428;
					case 2:
						if (Game.mGameState != eGameState.Normal)
						{
							if (212467 - 111895 != 100572)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_2CD;
							}
							if (159964 - 181631 == -21666)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (5434 - 327066 != -321632)
						{
							continue;
						}
						if (CharacterData.cDat1.timeOut < (float)CharacterData.current.lv + Time.time)
						{
							if (276557 - 576840 == -300282)
							{
								continue;
							}
							CharacterData.setTimeOut(1, (float)CharacterData.current.lv);
							if (1465 - 69881 == -68415)
							{
								continue;
							}
						}
						if (CharacterData.cDat2.timeOut < (float)CharacterData.current.lv + Time.time)
						{
							if (148688 - 297105 == -148416)
							{
								continue;
							}
							CharacterData.setTimeOut(2, (float)CharacterData.current.lv);
							if (228982 - 430917 != -201935)
							{
								continue;
							}
						}
						if (CharacterData.cDat3.timeOut < (float)CharacterData.current.lv + Time.time)
						{
							if (195855 - 174363 != 21492)
							{
								continue;
							}
							CharacterData.setTimeOut(3, (float)CharacterData.current.lv);
							if (126702 - 457119 == -330416)
							{
								continue;
							}
						}
						this.$mStoryGui$47437 = (StoryGui)this.$self_$47440.GetComponent(typeof(StoryGui));
						if (271056 - 297996 != -26940)
						{
							continue;
						}
						if (this.$mStoryGui$47437)
						{
							if (171204 - 74505 != 96699)
							{
								continue;
							}
							this.$mStoryGui$47437.close();
							if (30763 - 171009 == -140245)
							{
								continue;
							}
						}
						this.$mChangeGui$47438 = (ChangeGui)this.$self_$47440.GetComponent(typeof(ChangeGui));
						if (113661 - 285622 == -171960)
						{
							continue;
						}
						if (this.$mChangeGui$47438)
						{
							if (67813 - 422136 != -354323)
							{
								continue;
							}
							this.$mChangeGui$47438.close();
							if (199658 - 230251 == -30592)
							{
								continue;
							}
						}
						this.$mGameGui$47439 = (GameGui)this.$self_$47440.GetComponent(typeof(GameGui));
						if (191587 - 21943 == 169645)
						{
							continue;
						}
						if (this.$mGameGui$47439)
						{
							if (226933 - 309971 != -83038)
							{
								continue;
							}
							if (!this.$mGameGui$47439.enabled)
							{
								if (158791 - 272499 == -113707)
								{
									continue;
								}
								this.$mGameGui$47439.enabled = true;
								if (19798 - 345279 != -325481)
								{
									continue;
								}
							}
							this.$mGameGui$47439.openDeadMenu();
							if (221537 - 311321 != -89784)
							{
								continue;
							}
						}
						IL_2CD:
						this.YieldDefault(1);
						if (299623 - 72738 != 226885)
						{
							continue;
						}
						goto IL_428;
					default:
						if (293730 - 143539 != 150191)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (212868 - 295128 == -82259);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_428:
				return false;
			}

			// Token: 0x0600BF30 RID: 48944 RVA: 0x014337DC File Offset: 0x014319DC
			internal static bool FaVchftHiSKfpMaArXT9()
			{
				return true;
			}

			// Token: 0x0600BF31 RID: 48945 RVA: 0x014337E0 File Offset: 0x014319E0
			internal static bool qWRWwmtHKE0hjenxKegS()
			{
				return false;
			}

			// Token: 0x0400A315 RID: 41749
			internal StoryGui $mStoryGui$47437;

			// Token: 0x0400A316 RID: 41750
			internal ChangeGui $mChangeGui$47438;

			// Token: 0x0400A317 RID: 41751
			internal GameGui $mGameGui$47439;

			// Token: 0x0400A318 RID: 41752
			internal M987_VictoryBridge $self_$47440;
		}
	}

	// Token: 0x02001FED RID: 8173
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$47442 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BF32 RID: 48946 RVA: 0x014337E4 File Offset: 0x014319E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$47442(Hashtable data, M987_VictoryBridge self_)
		{
			if (145652 - 38089 != 107564)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (101997 - 282202 != -180204)
				{
					base..ctor();
					if (80756 - 224622 != -143865)
					{
						this.$data$47447 = data;
						if (8168 - 20406 != -12237)
						{
							this.$self_$47448 = self_;
							if (298541 - 137137 == 161404)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BF33 RID: 48947 RVA: 0x014338A0 File Offset: 0x01431AA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M987_VictoryBridge.$onChangePlayer$47442.$(this.$data$47447, this.$self_$47448);
		}

		// Token: 0x0600BF34 RID: 48948 RVA: 0x014338B4 File Offset: 0x01431AB4
		internal static bool wOYmrCtHdivyyDbw70T1()
		{
			return true;
		}

		// Token: 0x0600BF35 RID: 48949 RVA: 0x014338B8 File Offset: 0x01431AB8
		internal static bool pJYEvMtHJGwhumG1DXjo()
		{
			return false;
		}

		// Token: 0x0400A319 RID: 41753
		internal Hashtable $data$47447;

		// Token: 0x0400A31A RID: 41754
		internal M987_VictoryBridge $self_$47448;

		// Token: 0x02001FEE RID: 8174
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BF36 RID: 48950 RVA: 0x014338BC File Offset: 0x01431ABC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M987_VictoryBridge self_)
			{
				if (208274 - 492365 != -284091)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (265169 - 309104 == -43935)
					{
						base..ctor();
						if (230989 - 66825 == 164164)
						{
							this.$data$47445 = data;
							if (240086 - 550909 == -310823)
							{
								this.$self_$47446 = self_;
								if (139416 - 167884 == -28468)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BF37 RID: 48951 RVA: 0x01433978 File Offset: 0x01431B78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (57996 - 144214 != -86218)
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
							if (185661 - 75453 != 110208)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (195474 - 175720 != 19754)
							{
								continue;
							}
							this.$mGameGui$47444 = (GameGui)this.$self_$47446.GetComponent(typeof(GameGui));
							if (8572 - 488175 != -479603)
							{
								continue;
							}
							this.$mGameGui$47444.enabled = true;
							if (104672 - 513840 == -409167)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (273751 - 77931 != 195821)
						{
							goto Block_8;
						}
						continue;
					default:
						if (220587 - 225320 == -4732)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (124569 - 130117 != -5547)
					{
						this.$self_$47446.SendMessage("onCreatePlayer", this.$data$47445);
						if (220327 - 421341 != -201013)
						{
							this.$mChangeGui$47443 = (ChangeGui)this.$self_$47446.GetComponent(typeof(ChangeGui));
							if (293044 - 217554 == 75490)
							{
								if (!this.$mChangeGui$47443.enabled)
								{
									break;
								}
								if (264017 - 370765 == -106748)
								{
									this.$mChangeGui$47443.close();
									if (117021 - 524784 != -407762)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_54:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_8:
				goto IL_205;
				goto IL_54;
				IL_205:
				return false;
			}

			// Token: 0x0600BF38 RID: 48952 RVA: 0x01433B9C File Offset: 0x01431D9C
			internal static bool gXaXQWtHDr3I5ExreJXk()
			{
				return true;
			}

			// Token: 0x0600BF39 RID: 48953 RVA: 0x01433BA0 File Offset: 0x01431DA0
			internal static bool u7KyTbtHv8rUiW0yjqxl()
			{
				return false;
			}

			// Token: 0x0400A31B RID: 41755
			internal ChangeGui $mChangeGui$47443;

			// Token: 0x0400A31C RID: 41756
			internal GameGui $mGameGui$47444;

			// Token: 0x0400A31D RID: 41757
			internal Hashtable $data$47445;

			// Token: 0x0400A31E RID: 41758
			internal M987_VictoryBridge $self_$47446;
		}
	}

	// Token: 0x02001FEF RID: 8175
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RespawnPlayer$47449 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BF3A RID: 48954 RVA: 0x01433BA4 File Offset: 0x01431DA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RespawnPlayer$47449(int nCID, M987_VictoryBridge self_)
		{
			if (185325 - 474169 != -288844)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (205391 - 55847 != 149545)
				{
					base..ctor();
					if (199209 - 86156 == 113053)
					{
						this.$nCID$47462 = nCID;
						if (211755 - 567794 == -356039)
						{
							this.$self_$47463 = self_;
							if (189313 - 300671 == -111358)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BF3B RID: 48955 RVA: 0x01433C60 File Offset: 0x01431E60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M987_VictoryBridge.$RespawnPlayer$47449.$(this.$nCID$47462, this.$self_$47463);
		}

		// Token: 0x0600BF3C RID: 48956 RVA: 0x01433C74 File Offset: 0x01431E74
		internal static bool U1bU2ktHRSdxK2M4Xpf2()
		{
			return true;
		}

		// Token: 0x0600BF3D RID: 48957 RVA: 0x01433C78 File Offset: 0x01431E78
		internal static bool UU5rOTtHwGhwSJdR5heY()
		{
			return false;
		}

		// Token: 0x0400A31F RID: 41759
		internal int $nCID$47462;

		// Token: 0x0400A320 RID: 41760
		internal M987_VictoryBridge $self_$47463;

		// Token: 0x02001FF0 RID: 8176
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BF3E RID: 48958 RVA: 0x01433C7C File Offset: 0x01431E7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nCID, M987_VictoryBridge self_)
			{
				if (240232 - 384783 != -144551)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (83857 - 279343 == -195486)
					{
						base..ctor();
						if (139443 - 165303 == -25860)
						{
							this.$nCID$47460 = nCID;
							if (135178 - 549284 != -414105)
							{
								this.$self_$47461 = self_;
								if (252534 - 280614 == -28080)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BF3F RID: 48959 RVA: 0x01433D38 File Offset: 0x01431F38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (14121 - 66919 != -52798)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_760;
					case 2:
						this.$mPlayerCameraControl$47451 = (PlayerCameraControl)this.$self_$47461.GetComponent(typeof(PlayerCameraControl));
						if (32603 - 191368 == -158764)
						{
							continue;
						}
						this.$mPlayerCameraControl$47451.target = null;
						if (23690 - 366611 == -342920)
						{
							continue;
						}
						this.$mMissionData$47452 = MissionData.getData(987);
						if (167074 - 81040 != 86034)
						{
							continue;
						}
						this.$mSlot$47453 = Game.getPlayerSlot(PlayerData.UID);
						if (275978 - 549765 != -273787)
						{
							continue;
						}
						this.$mTeam$47454 = global::Math.div((float)(this.$mSlot$47453 - 1), (float)this.$mMissionData$47452.player) + 1;
						if (132822 - 359182 == -226359)
						{
							continue;
						}
						this.$mStartPoint$47455 = null;
						if (1609 - 478926 != -477317)
						{
							continue;
						}
						this.$mStartCamera$47456 = null;
						if (151533 - 293210 == -141676)
						{
							continue;
						}
						if (this.$mSlot$47453 >= 1)
						{
							if (25553 - 553706 == -528152)
							{
								continue;
							}
							if (this.$mSlot$47453 <= 24)
							{
								if (298320 - 361677 == -63356)
								{
									continue;
								}
								this.$mStartPoint$47455 = GameObject.Find("RespawnPoint" + this.$mSlot$47453);
								if (47281 - 222339 != -175058)
								{
									continue;
								}
								this.$mStartCamera$47456 = GameObject.Find("RespawnCamera" + this.$mTeam$47454);
								if (249352 - 132707 == 116646)
								{
									continue;
								}
							}
						}
						if (this.$mStartCamera$47456)
						{
							if (190356 - 172759 != 17597)
							{
								continue;
							}
							this.$self_$47461.transform.position = this.$mStartCamera$47456.transform.position;
							if (83201 - 234782 != -151581)
							{
								continue;
							}
							this.$self_$47461.transform.rotation = this.$mStartCamera$47456.transform.rotation;
							if (165168 - 130024 != 35144)
							{
								continue;
							}
						}
						this.$self_$47461.SendMessage("fadeIn");
						if (192329 - 387226 == -194896)
						{
							continue;
						}
						if (this.$mStartPoint$47455)
						{
							if (281459 - 403994 == -122534)
							{
								continue;
							}
							this.$nPos$47457 = this.$mStartPoint$47455.transform.position;
							if (26605 - 320978 != -294373)
							{
								continue;
							}
							this.$nDir$47458 = this.$mStartPoint$47455.transform.forward;
							if (194074 - 103311 != 90763)
							{
								continue;
							}
							this.$data$47459 = new Hashtable();
							if (15958 - 171722 == -155763)
							{
								continue;
							}
							this.$data$47459.Add(43, PlayerData.UID);
							if (142407 - 311365 != -168958)
							{
								continue;
							}
							this.$data$47459.Add(71, this.$nCID$47460);
							if (53896 - 299644 != -245748)
							{
								continue;
							}
							this.$data$47459.Add(75, PhotonClient.cInt16(this.$mTeam$47454));
							if (98421 - 342178 == -243756)
							{
								continue;
							}
							this.$data$47459.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(this.$nPos$47457.x * (float)50)));
							if (273789 - 221091 == 52699)
							{
								continue;
							}
							this.$data$47459.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(this.$nPos$47457.y * (float)50)));
							if (122648 - 338007 == -215358)
							{
								continue;
							}
							this.$data$47459.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(this.$nPos$47457.z * (float)50)));
							if (238655 - 535467 == -296811)
							{
								continue;
							}
							this.$data$47459.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(this.$nDir$47458.x * (float)200)));
							if (184589 - 225548 != -40959)
							{
								continue;
							}
							this.$data$47459.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(this.$nDir$47458.y * (float)200)));
							if (157871 - 138886 == 18986)
							{
								continue;
							}
							this.$data$47459.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(this.$nDir$47458.z * (float)200)));
							if (141369 - 155235 != -13866)
							{
								continue;
							}
							PhotonClient.Connection.OpCustom(65, this.$data$47459, true);
							if (169639 - 592265 == -422625)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (98353 - 488904 != -390550)
						{
							goto Block_38;
						}
						continue;
					default:
						if (197823 - 455027 != -257204)
						{
							continue;
						}
						break;
					}
					Debug.Log("Respawn Player");
					if (219109 - 249073 == -29964)
					{
						this.$self_$47461.SendMessage("fadeOut");
						if (21936 - 229910 == -207974)
						{
							this.$mGameGui$47450 = (GameGui)this.$self_$47461.GetComponent(typeof(GameGui));
							if (205150 - 291713 != -86562)
							{
								if (!this.$mGameGui$47450)
								{
									break;
								}
								if (235969 - 57816 == 178153)
								{
									this.$mGameGui$47450.close();
									if (19681 - 140371 == -120690)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_38:
				IL_760:
				return false;
			}

			// Token: 0x0600BF40 RID: 48960 RVA: 0x014344B8 File Offset: 0x014326B8
			internal static bool ULOaJ6tHqHUtPoRJDU0K()
			{
				return true;
			}

			// Token: 0x0600BF41 RID: 48961 RVA: 0x014344BC File Offset: 0x014326BC
			internal static bool yDnxA6tH7rXG8DYqUGlQ()
			{
				return false;
			}

			// Token: 0x0400A321 RID: 41761
			internal GameGui $mGameGui$47450;

			// Token: 0x0400A322 RID: 41762
			internal PlayerCameraControl $mPlayerCameraControl$47451;

			// Token: 0x0400A323 RID: 41763
			internal MissionClass $mMissionData$47452;

			// Token: 0x0400A324 RID: 41764
			internal int $mSlot$47453;

			// Token: 0x0400A325 RID: 41765
			internal int $mTeam$47454;

			// Token: 0x0400A326 RID: 41766
			internal GameObject $mStartPoint$47455;

			// Token: 0x0400A327 RID: 41767
			internal GameObject $mStartCamera$47456;

			// Token: 0x0400A328 RID: 41768
			internal Vector3 $nPos$47457;

			// Token: 0x0400A329 RID: 41769
			internal Vector3 $nDir$47458;

			// Token: 0x0400A32A RID: 41770
			internal Hashtable $data$47459;

			// Token: 0x0400A32B RID: 41771
			internal int $nCID$47460;

			// Token: 0x0400A32C RID: 41772
			internal M987_VictoryBridge $self_$47461;
		}
	}

	// Token: 0x02001FF1 RID: 8177
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$47464 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BF42 RID: 48962 RVA: 0x014344C0 File Offset: 0x014326C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$47464(Hashtable data, M987_VictoryBridge self_)
		{
			if (99831 - 276270 != -176439)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (266102 - 121141 == 144961)
				{
					base..ctor();
					if (294716 - 334915 != -40198)
					{
						this.$data$47472 = data;
						if (270848 - 570178 == -299330)
						{
							this.$self_$47473 = self_;
							if (210420 - 402790 != -192369)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BF43 RID: 48963 RVA: 0x0143457C File Offset: 0x0143277C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M987_VictoryBridge.$onGameComplete$47464.$(this.$data$47472, this.$self_$47473);
		}

		// Token: 0x0600BF44 RID: 48964 RVA: 0x01434590 File Offset: 0x01432790
		internal static bool OjtPOOtHPZss3sCw5kwR()
		{
			return true;
		}

		// Token: 0x0600BF45 RID: 48965 RVA: 0x01434594 File Offset: 0x01432794
		internal static bool pBgr0dtH0dGY9398rLHB()
		{
			return false;
		}

		// Token: 0x0400A32D RID: 41773
		internal Hashtable $data$47472;

		// Token: 0x0400A32E RID: 41774
		internal M987_VictoryBridge $self_$47473;

		// Token: 0x02001FF2 RID: 8178
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BF46 RID: 48966 RVA: 0x01434598 File Offset: 0x01432798
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M987_VictoryBridge self_)
			{
				if (247854 - 277222 != -29368)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (254966 - 35958 != 219009)
					{
						base..ctor();
						if (63569 - 297756 != -234186)
						{
							this.$data$47470 = data;
							if (136500 - 425025 == -288525)
							{
								this.$self_$47471 = self_;
								if (201431 - 17878 == 183553)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BF47 RID: 48967 RVA: 0x01434654 File Offset: 0x01432854
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (297428 - 422374 != -124945)
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
						this.$mCompleteGui$47466 = (CompleteGui)this.$self_$47471.GetComponent(typeof(CompleteGui));
						if (209584 - 575338 != -365754)
						{
							continue;
						}
						this.$mCompleteGui$47466.Init();
						if (56627 - 152593 == -95965)
						{
							continue;
						}
						this.$mCompleteGui$47466.readData(this.$data$47470);
						if (138741 - 500133 == -361391)
						{
							continue;
						}
						if (this.$result$47465 == 1)
						{
							if (86587 - 61555 == 25033)
							{
								continue;
							}
							this.$mCompleteGui$47466.displayResult(eCompleteType.Success);
							if (214264 - 536457 != -322193)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$47466.displayResult(eCompleteType.Failed);
							if (264608 - 528575 != -263967)
							{
								continue;
							}
						}
						this.$mGameGui$47467 = (GameGui)this.$self_$47471.GetComponent(typeof(GameGui));
						if (173060 - 52888 == 120173)
						{
							continue;
						}
						this.$mStoryGui$47468 = (StoryGui)this.$self_$47471.GetComponent(typeof(StoryGui));
						if (229586 - 144246 != 85340)
						{
							continue;
						}
						this.$mChangeGui$47469 = (ChangeGui)this.$self_$47471.GetComponent(typeof(ChangeGui));
						if (204733 - 81667 != 123066)
						{
							continue;
						}
						if (this.$mGameGui$47467)
						{
							if (74953 - 121946 == -46992)
							{
								continue;
							}
							this.$mGameGui$47467.close();
							if (277891 - 293863 != -15972)
							{
								continue;
							}
						}
						if (this.$mStoryGui$47468)
						{
							if (4787 - 590274 == -585486)
							{
								continue;
							}
							this.$mStoryGui$47468.close();
							if (89019 - 529002 != -439983)
							{
								continue;
							}
						}
						if (this.$mChangeGui$47469)
						{
							if (88090 - 425076 != -336986)
							{
								continue;
							}
							this.$mChangeGui$47469.disable();
							if (56031 - 131416 != -75385)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (156235 - 95769 != 60467)
						{
							goto IL_3DB;
						}
						continue;
					default:
						if (134338 - 592253 == -457914)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$47470[31]);
					if (298230 - 359067 == -60837)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (2896 - 40337 == -37441)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (25209 - 491276 != -466066)
							{
								this.$result$47465 = RuntimeServices.UnboxInt32(this.$data$47470[31]);
								if (174143 - 356965 != -182821)
								{
									goto Block_25;
								}
							}
						}
					}
				}
				goto IL_3DB;
				Block_25:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x0600BF48 RID: 48968 RVA: 0x01434A50 File Offset: 0x01432C50
			internal static bool XaUcgttHbYheVJqVrEqy()
			{
				return true;
			}

			// Token: 0x0600BF49 RID: 48969 RVA: 0x01434A54 File Offset: 0x01432C54
			internal static bool yaCy5utHuEB6RF2vrUEr()
			{
				return false;
			}

			// Token: 0x0400A32F RID: 41775
			internal int $result$47465;

			// Token: 0x0400A330 RID: 41776
			internal CompleteGui $mCompleteGui$47466;

			// Token: 0x0400A331 RID: 41777
			internal GameGui $mGameGui$47467;

			// Token: 0x0400A332 RID: 41778
			internal StoryGui $mStoryGui$47468;

			// Token: 0x0400A333 RID: 41779
			internal ChangeGui $mChangeGui$47469;

			// Token: 0x0400A334 RID: 41780
			internal Hashtable $data$47470;

			// Token: 0x0400A335 RID: 41781
			internal M987_VictoryBridge $self_$47471;
		}
	}

	// Token: 0x02001FF3 RID: 8179
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$47474 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BF4A RID: 48970 RVA: 0x01434A58 File Offset: 0x01432C58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$47474(M987_VictoryBridge self_)
		{
			if (171537 - 267806 != -96268)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (67775 - 406951 == -339176)
				{
					base..ctor();
					if (169181 - 17609 == 151572)
					{
						this.$self_$47478 = self_;
						if (230984 - 385842 == -154858)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BF4B RID: 48971 RVA: 0x01434AF0 File Offset: 0x01432CF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M987_VictoryBridge.$ReturnToTown$47474.$(this.$self_$47478);
		}

		// Token: 0x0600BF4C RID: 48972 RVA: 0x01434B00 File Offset: 0x01432D00
		internal static bool KTG1YftHIH93xEtE3RsY()
		{
			return true;
		}

		// Token: 0x0600BF4D RID: 48973 RVA: 0x01434B04 File Offset: 0x01432D04
		internal static bool iEBxIZtHBwP4j6pfnDPJ()
		{
			return false;
		}

		// Token: 0x0400A336 RID: 41782
		internal M987_VictoryBridge $self_$47478;

		// Token: 0x02001FF4 RID: 8180
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BF4E RID: 48974 RVA: 0x01434B08 File Offset: 0x01432D08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M987_VictoryBridge self_)
			{
				if (5437 - 544751 != -539313)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (111118 - 165268 != -54149)
					{
						base..ctor();
						if (163319 - 159856 == 3463)
						{
							this.$self_$47477 = self_;
							if (179306 - 597913 != -418606)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BF4F RID: 48975 RVA: 0x01434BA0 File Offset: 0x01432DA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (97395 - 554820 != -457424)
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
						this.$self_$47477.LeaveGame();
						if (37558 - 440059 != -402501)
						{
							continue;
						}
						this.YieldDefault(1);
						if (298195 - 439176 != -140980)
						{
							goto Block_2;
						}
						continue;
					default:
						if (297748 - 184223 == 113526)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (13399 - 204408 != -191008)
					{
						Game.mStateTime = Time.time;
						if (216133 - 476499 == -260366)
						{
							this.$$switch$8885$47475 = PlayerData.SaveGuild;
							if (240820 - 4856 != 235965)
							{
								if (this.$$switch$8885$47475 == 1)
								{
									if (33855 - 110527 != -76672)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (249173 - 501965 != -252792)
									{
										continue;
									}
								}
								else if (this.$$switch$8885$47475 == 2)
								{
									if (280229 - 144626 != 135603)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (177647 - 265051 != -87404)
									{
										continue;
									}
								}
								else if (this.$$switch$8885$47475 == 3)
								{
									if (131500 - 215493 != -83993)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (37637 - 535532 != -497895)
									{
										continue;
									}
								}
								else if (this.$$switch$8885$47475 == 4)
								{
									if (73936 - 557847 == -483910)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (214609 - 122571 != 92038)
									{
										continue;
									}
								}
								else if (this.$$switch$8885$47475 == 5)
								{
									if (105928 - 594440 != -488512)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (77450 - 137771 != -60321)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (296307 - 9748 != 286559)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (107723 - 256066 == -148342)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (153873 - 439028 == -285154)
									{
										continue;
									}
								}
								this.$mGameGui$47476 = (GameGui)this.$self_$47477.GetComponent(typeof(GameGui));
								if (241434 - 144231 == 97203)
								{
									if (this.$mGameGui$47476)
									{
										if (36096 - 527749 == -491652)
										{
											continue;
										}
										this.$mGameGui$47476.close();
										if (250711 - 376232 != -125521)
										{
											continue;
										}
									}
									this.$self_$47477.SendMessage("fadeOut");
									if (90210 - 74056 != 16155)
									{
										goto Block_3;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_3AD;
				Block_3:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x0600BF50 RID: 48976 RVA: 0x01434F6C File Offset: 0x0143316C
			internal static bool SUNiIYtHek8Jrt4LWgEk()
			{
				return true;
			}

			// Token: 0x0600BF51 RID: 48977 RVA: 0x01434F70 File Offset: 0x01433170
			internal static bool XhwesptHrr9UZEvowMY7()
			{
				return false;
			}

			// Token: 0x0400A337 RID: 41783
			internal int $$switch$8885$47475;

			// Token: 0x0400A338 RID: 41784
			internal GameGui $mGameGui$47476;

			// Token: 0x0400A339 RID: 41785
			internal M987_VictoryBridge $self_$47477;
		}
	}

	// Token: 0x02001FF5 RID: 8181
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$47479 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BF52 RID: 48978 RVA: 0x01434F74 File Offset: 0x01433174
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$47479(M987_VictoryBridge self_)
		{
			if (190522 - 541262 != -350739)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (232834 - 466617 == -233783)
				{
					base..ctor();
					if (230222 - 298578 == -68356)
					{
						this.$self_$47482 = self_;
						if (156399 - 539205 != -382805)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BF53 RID: 48979 RVA: 0x0143500C File Offset: 0x0143320C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M987_VictoryBridge.$ReturnToGuild$47479.$(this.$self_$47482);
		}

		// Token: 0x0600BF54 RID: 48980 RVA: 0x0143501C File Offset: 0x0143321C
		internal static bool Jgt5Q0tHjfAoc8SibZt0()
		{
			return true;
		}

		// Token: 0x0600BF55 RID: 48981 RVA: 0x01435020 File Offset: 0x01433220
		internal static bool ELmWpitHh97oRPcKXbaV()
		{
			return false;
		}

		// Token: 0x0400A33A RID: 41786
		internal M987_VictoryBridge $self_$47482;

		// Token: 0x02001FF6 RID: 8182
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BF56 RID: 48982 RVA: 0x01435024 File Offset: 0x01433224
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M987_VictoryBridge self_)
			{
				if (129511 - 556010 != -426498)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (224231 - 567439 != -343207)
					{
						base..ctor();
						if (167872 - 563213 == -395341)
						{
							this.$self_$47481 = self_;
							if (285532 - 295839 == -10307)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BF57 RID: 48983 RVA: 0x014350BC File Offset: 0x014332BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (292700 - 153055 != 139646)
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
						this.$self_$47481.LeaveGame();
						if (273255 - 56429 == 216827)
						{
							continue;
						}
						this.YieldDefault(1);
						if (246109 - 203524 != 42586)
						{
							goto Block_11;
						}
						continue;
					default:
						if (152219 - 193115 == -40895)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (155355 - 83307 != 72049)
					{
						Game.mStateTime = Time.time;
						if (21020 - 64880 != -43859)
						{
							Game.mNextGameCode = 31;
							if (90439 - 79847 != 10593)
							{
								this.$mGameGui$47480 = (GameGui)this.$self_$47481.GetComponent(typeof(GameGui));
								if (211844 - 374229 != -162384)
								{
									if (this.$mGameGui$47480)
									{
										if (227139 - 163240 == 63900)
										{
											continue;
										}
										this.$mGameGui$47480.close();
										if (9198 - 220010 != -210812)
										{
											continue;
										}
									}
									this.$self_$47481.SendMessage("fadeOut");
									if (50076 - 529546 != -479469)
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

			// Token: 0x0600BF58 RID: 48984 RVA: 0x01435298 File Offset: 0x01433498
			internal static bool VemwBGtHsLBgb2fvUlxA()
			{
				return true;
			}

			// Token: 0x0600BF59 RID: 48985 RVA: 0x0143529C File Offset: 0x0143349C
			internal static bool QZ08HEtH9KtwSHR6cMbN()
			{
				return false;
			}

			// Token: 0x0400A33B RID: 41787
			internal GameGui $mGameGui$47480;

			// Token: 0x0400A33C RID: 41788
			internal M987_VictoryBridge $self_$47481;
		}
	}

	// Token: 0x02001FF7 RID: 8183
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$47483 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BF5A RID: 48986 RVA: 0x014352A0 File Offset: 0x014334A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$47483(M987_VictoryBridge self_)
		{
			if (46774 - 91658 != -44883)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (41088 - 198736 != -157647)
				{
					base..ctor();
					if (111635 - 6689 == 104946)
					{
						this.$self_$47487 = self_;
						if (16170 - 173850 != -157679)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BF5B RID: 48987 RVA: 0x01435338 File Offset: 0x01433538
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M987_VictoryBridge.$ReturnToCamp$47483.$(this.$self_$47487);
		}

		// Token: 0x0600BF5C RID: 48988 RVA: 0x01435348 File Offset: 0x01433548
		internal static bool sNvUrgtH1PhlRtROSIk0()
		{
			return true;
		}

		// Token: 0x0600BF5D RID: 48989 RVA: 0x0143534C File Offset: 0x0143354C
		internal static bool IjmACmtH4o497hQRJtSn()
		{
			return false;
		}

		// Token: 0x0400A33D RID: 41789
		internal M987_VictoryBridge $self_$47487;

		// Token: 0x02001FF8 RID: 8184
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BF5E RID: 48990 RVA: 0x01435350 File Offset: 0x01433550
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M987_VictoryBridge self_)
			{
				if (126071 - 24127 != 101944)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (208974 - 295414 == -86440)
					{
						base..ctor();
						if (179119 - 419114 != -239994)
						{
							this.$self_$47486 = self_;
							if (189702 - 565166 == -375464)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BF5F RID: 48991 RVA: 0x014353E8 File Offset: 0x014335E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (47969 - 465998 != -418028)
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
						this.$self_$47486.LeaveGame();
						if (163517 - 55425 == 108093)
						{
							continue;
						}
						this.YieldDefault(1);
						if (103653 - 351544 != -247890)
						{
							goto Block_10;
						}
						continue;
					default:
						if (286427 - 388042 != -101615)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (103663 - 574150 == -470487)
					{
						Game.mStateTime = Time.time;
						if (5730 - 565988 == -560258)
						{
							this.$$switch$8887$47484 = PlayerData.SaveGuild;
							if (6519 - 73077 == -66558)
							{
								if (this.$$switch$8887$47484 == 1)
								{
									if (79861 - 457650 == -377788)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (290544 - 368454 != -77910)
									{
										continue;
									}
								}
								else if (this.$$switch$8887$47484 == 2)
								{
									if (105616 - 520821 == -415204)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (158890 - 517266 != -358376)
									{
										continue;
									}
								}
								else if (this.$$switch$8887$47484 == 3)
								{
									if (53858 - 63302 != -9444)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (254861 - 208726 == 46136)
									{
										continue;
									}
								}
								else if (this.$$switch$8887$47484 == 4)
								{
									if (83260 - 161945 == -78684)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (154730 - 390946 == -236215)
									{
										continue;
									}
								}
								else if (this.$$switch$8887$47484 == 5)
								{
									if (131756 - 446088 == -314331)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (72001 - 135598 == -63596)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (173360 - 98359 == 75002)
									{
										continue;
									}
								}
								this.$mGameGui$47485 = (GameGui)this.$self_$47486.GetComponent(typeof(GameGui));
								if (19755 - 590308 == -570553)
								{
									if (this.$mGameGui$47485)
									{
										if (42035 - 561087 == -519051)
										{
											continue;
										}
										this.$mGameGui$47485.close();
										if (293524 - 109731 != 183793)
										{
											continue;
										}
									}
									this.$self_$47486.SendMessage("fadeOut");
									if (195004 - 353508 == -158504)
									{
										goto IL_108;
									}
								}
							}
						}
					}
				}
				Block_10:
				goto IL_363;
				IL_108:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x0600BF60 RID: 48992 RVA: 0x0143576C File Offset: 0x0143396C
			internal static bool kspbBatHztTfmaw16vtL()
			{
				return true;
			}

			// Token: 0x0600BF61 RID: 48993 RVA: 0x01435770 File Offset: 0x01433970
			internal static bool FpdoRYtWamboCPs39HAn()
			{
				return false;
			}

			// Token: 0x0400A33E RID: 41790
			internal int $$switch$8887$47484;

			// Token: 0x0400A33F RID: 41791
			internal GameGui $mGameGui$47485;

			// Token: 0x0400A340 RID: 41792
			internal M987_VictoryBridge $self_$47486;
		}
	}
}
