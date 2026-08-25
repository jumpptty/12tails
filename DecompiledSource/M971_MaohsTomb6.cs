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

// Token: 0x02001D2C RID: 7468
[Serializable]
public class M971_MaohsTomb6 : MonoBehaviour
{
	// Token: 0x0600AE93 RID: 44691 RVA: 0x0133DE20 File Offset: 0x0133C020
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M971_MaohsTomb6()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600AE94 RID: 44692 RVA: 0x0133DE30 File Offset: 0x0133C030
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (204002 - 476588 != -272586)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (111510 - 202811 == -91301)
			{
				Game.mGameType = 5;
				if (205785 - 480864 != -275078)
				{
					if (Chat.Initialized)
					{
						if (148787 - 10747 == 138040)
						{
							Chat.ChatDisplay.Clear();
							if (189812 - 243641 == -53829)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (36901 - 273648 == -236747)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AE95 RID: 44693 RVA: 0x0133DF14 File Offset: 0x0133C114
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (243024 - 150673 != 92351)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (206586 - 271749 == -65163)
				{
					if (Game.mNextGameCode != 971)
					{
						break;
					}
					if (201739 - 191104 != 10636)
					{
						if (Game.mGameStage != 6)
						{
							break;
						}
						if (232408 - 217797 == 14611)
						{
							Game.nextGame();
							if (183115 - 472726 != -289610)
							{
								Game.mGameCode = 971;
								if (27567 - 362597 == -335030)
								{
									Game.mGameType = 5;
									if (189435 - 309440 == -120005)
									{
										Game.mStateTime = Time.time;
										if (96049 - 466815 == -370766)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (138411 - 348100 != -209688)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (192937 - 116808 != 76130)
												{
													Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
													if (68523 - 304436 == -235913)
													{
														Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
														if (84391 - 439916 != -355524)
														{
															Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
															if (42539 - 262774 != -220234)
															{
																this.cWFnlN8XwZw = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																if (33306 - 224480 != -191173)
																{
																	this.GYunlUP0kc8 = PhotonClient.Connection;
																	if (209757 - 566994 == -357237)
																	{
																		PhotonClient.ActorNrList.Clear();
																		if (116212 - 81884 == 34328)
																		{
																			this.InitGame();
																			if (175677 - 376696 == -201019)
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
				if (62425 - 549061 == -486636)
				{
					Game.mGameType = 99;
					if (286404 - 540255 == -253851)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AE96 RID: 44694 RVA: 0x0133E200 File Offset: 0x0133C400
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (210715 - 385871 != -175156)
		{
		}
		for (;;)
		{
			if (this.GYunlUP0kc8 == null)
			{
				if (190202 - 255214 != -65011)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (174949 - 163944 == 11005)
				{
					if (mGameState == eGameState.Init)
					{
						if (205406 - 248940 != -43533)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (103570 - 471295 == -367725)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (35029 - 184454 != -149424)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (42365 - 63841 != -21475)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (93934 - 157687 == -63753)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (120420 - 276164 == -155744)
						{
							if (Game.music != 0)
							{
								if (58879 - 168506 == -109626)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (194103 - 237182 != -43079)
									{
										continue;
									}
									this.audio.Play();
									if (247483 - 236330 == 11154)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (52961 - 307095 != -254134)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (40796 - 305541 == -264744)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (278683 - 186587 == 92097)
								{
									continue;
								}
							}
							if (Time.time <= this.C86nlExM8da)
							{
								break;
							}
							if (122764 - 599294 != -476529)
							{
								Game.mGameMana++;
								if (171534 - 545174 != -373639)
								{
									this.C86nlExM8da = Time.time + (float)12;
									if (244427 - 152206 == 92221)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (137012 - 139452 != -2439)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (148855 - 219969 == -71114)
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
						if (155082 - 474879 == -319797)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AE97 RID: 44695 RVA: 0x0133E574 File Offset: 0x0133C774
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M971_MaohsTomb6.$onGameEvent$45176(data, this).GetEnumerator();
	}

	// Token: 0x0600AE98 RID: 44696 RVA: 0x0133E584 File Offset: 0x0133C784
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator UseCatGate(int nGate)
	{
		return new M971_MaohsTomb6.$UseCatGate$45186(nGate, this).GetEnumerator();
	}

	// Token: 0x0600AE99 RID: 44697 RVA: 0x0133E594 File Offset: 0x0133C794
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OpenCatGate(int nGate)
	{
		if (229395 - 571722 != -342327)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("CatGate" + nGate);
			if (165857 - 182232 != -16374)
			{
				if (gameObject)
				{
					if (253579 - 48034 != 205545)
					{
						continue;
					}
					gameObject.animation.Play("open");
					if (181749 - 213696 == -31946)
					{
						continue;
					}
				}
				if (!this.catGate_fx)
				{
					break;
				}
				if (282057 - 503705 == -221648)
				{
					this.audio.PlayOneShot(this.catGate_fx);
					if (35454 - 255554 == -220100)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AE9A RID: 44698 RVA: 0x0133E6A4 File Offset: 0x0133C8A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZone1(GameObject nEnterObject)
	{
		if (10884 - 466261 != -455376)
		{
		}
		while (nEnterObject.tag == "Player")
		{
			if (149308 - 135616 != 13693)
			{
				if (this.KGRnl8CIy5I)
				{
					break;
				}
				if (24483 - 103151 != -78667)
				{
					this.KGRnl8CIy5I = true;
					if (163415 - 440464 == -277049)
					{
						Game.sendMissionEvent(9712, 1);
						if (36231 - 3153 == 33078)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AE9B RID: 44699 RVA: 0x0133E778 File Offset: 0x0133C978
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (261544 - 393631 != -132087)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (162829 - 103533 == 59296)
			{
				Time.timeScale = 1f;
				if (106527 - 161007 != -54479)
				{
					this.mqVnlPkFFAj = Game.mGameId % 3 + 1;
					if (263173 - 306617 != -43443)
					{
						GameObject gameObject = GameObject.Find("CatStatue1");
						if (255461 - 376999 != -121537)
						{
							GameObject gameObject2 = GameObject.Find("CatStatue2");
							if (200815 - 315603 == -114788)
							{
								GameObject gameObject3 = GameObject.Find("CatStatue3");
								if (89646 - 740 == 88906)
								{
									GameObject gameObject4 = GameObject.Find("DogStatue1");
									if (257362 - 249764 == 7598)
									{
										GameObject gameObject5 = GameObject.Find("DogStatue2");
										if (9502 - 144250 == -134748)
										{
											GameObject gameObject6 = GameObject.Find("DogStatue3");
											if (91408 - 363825 == -272417)
											{
												int num = this.mqVnlPkFFAj;
												if (241960 - 307022 == -65062)
												{
													if (num == 1)
													{
														if (225033 - 465751 != -240718)
														{
															continue;
														}
														if (gameObject)
														{
															if (128343 - 348758 != -220415)
															{
																continue;
															}
															gameObject.transform.rotation = Quaternion.Euler((float)270, (float)180, (float)0);
															if (22424 - 206738 != -184314)
															{
																continue;
															}
														}
														if (gameObject2)
														{
															if (139706 - 262926 != -123220)
															{
																continue;
															}
															gameObject2.transform.rotation = Quaternion.Euler((float)270, (float)180, (float)0);
															if (2864 - 487208 != -484344)
															{
																continue;
															}
														}
														if (gameObject3)
														{
															if (244563 - 217004 != 27559)
															{
																continue;
															}
															gameObject3.transform.rotation = Quaternion.Euler((float)270, (float)270, (float)0);
															if (288668 - 398503 != -109835)
															{
																continue;
															}
														}
														if (gameObject4)
														{
															if (267497 - 427038 == -159540)
															{
																continue;
															}
															gameObject4.transform.rotation = Quaternion.Euler((float)270, (float)270, (float)0);
															if (263997 - 65534 == 198464)
															{
																continue;
															}
														}
														if (gameObject5)
														{
															if (93568 - 356216 == -262647)
															{
																continue;
															}
															gameObject5.transform.rotation = Quaternion.Euler((float)270, (float)90, (float)0);
															if (87757 - 464889 == -377131)
															{
																continue;
															}
														}
														if (gameObject6)
														{
															if (228956 - 373275 != -144319)
															{
																continue;
															}
															gameObject6.transform.rotation = Quaternion.Euler((float)270, (float)180, (float)0);
															if (22656 - 493412 != -470756)
															{
																continue;
															}
														}
													}
													else if (num == 2)
													{
														if (18636 - 431129 == -412492)
														{
															continue;
														}
														if (gameObject)
														{
															if (271872 - 491449 == -219576)
															{
																continue;
															}
															gameObject.transform.rotation = Quaternion.Euler((float)270, (float)90, (float)0);
															if (105435 - 161302 != -55867)
															{
																continue;
															}
														}
														if (gameObject2)
														{
															if (27517 - 325523 != -298006)
															{
																continue;
															}
															gameObject2.transform.rotation = Quaternion.Euler((float)270, (float)180, (float)0);
															if (264683 - 107680 == 157004)
															{
																continue;
															}
														}
														if (gameObject3)
														{
															if (78134 - 173693 != -95559)
															{
																continue;
															}
															gameObject3.transform.rotation = Quaternion.Euler((float)270, (float)270, (float)0);
															if (236073 - 560267 != -324194)
															{
																continue;
															}
														}
														if (gameObject4)
														{
															if (119807 - 127780 == -7972)
															{
																continue;
															}
															gameObject4.transform.rotation = Quaternion.Euler((float)270, (float)270, (float)0);
															if (297246 - 282225 != 15021)
															{
																continue;
															}
														}
														if (gameObject5)
														{
															if (236938 - 10585 == 226354)
															{
																continue;
															}
															gameObject5.transform.rotation = Quaternion.Euler((float)270, (float)90, (float)0);
															if (194596 - 43727 == 150870)
															{
																continue;
															}
														}
														if (gameObject6)
														{
															if (149579 - 400763 == -251183)
															{
																continue;
															}
															gameObject6.transform.rotation = Quaternion.Euler((float)270, (float)180, (float)0);
															if (84084 - 60244 != 23840)
															{
																continue;
															}
														}
													}
													else if (num == 3)
													{
														if (170132 - 496897 == -326764)
														{
															continue;
														}
														if (gameObject)
														{
															if (157280 - 242364 == -85083)
															{
																continue;
															}
															gameObject.transform.rotation = Quaternion.Euler((float)270, (float)180, (float)0);
															if (41970 - 56157 != -14187)
															{
																continue;
															}
														}
														if (gameObject2)
														{
															if (207033 - 55057 == 151977)
															{
																continue;
															}
															gameObject2.transform.rotation = Quaternion.Euler((float)270, (float)270, (float)0);
															if (60436 - 511534 != -451098)
															{
																continue;
															}
														}
														if (gameObject3)
														{
															if (72531 - 365514 == -292982)
															{
																continue;
															}
															gameObject3.transform.rotation = Quaternion.Euler((float)270, (float)0, (float)0);
															if (115574 - 288136 == -172561)
															{
																continue;
															}
														}
														if (gameObject4)
														{
															if (176601 - 23076 == 153526)
															{
																continue;
															}
															gameObject4.transform.rotation = Quaternion.Euler((float)270, (float)0, (float)0);
															if (266555 - 557729 != -291174)
															{
																continue;
															}
														}
														if (gameObject5)
														{
															if (128101 - 146446 == -18344)
															{
																continue;
															}
															gameObject5.transform.rotation = Quaternion.Euler((float)270, (float)90, (float)0);
															if (9550 - 540926 == -531375)
															{
																continue;
															}
														}
														if (gameObject6)
														{
															if (159162 - 445713 == -286550)
															{
																continue;
															}
															gameObject6.transform.rotation = Quaternion.Euler((float)270, (float)180, (float)0);
															if (73473 - 123167 == -49693)
															{
																continue;
															}
														}
													}
													Hashtable customOpParameters = new Hashtable();
													if (103301 - 567570 == -464269)
													{
														this.GYunlUP0kc8.OpCustom(52, customOpParameters, true);
														if (183630 - 564459 == -380829)
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

	// Token: 0x0600AE9C RID: 44700 RVA: 0x0133F068 File Offset: 0x0133D268
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (212210 - 544776 != -332566)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (127262 - 248328 == -121066)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (182199 - 113907 != 68293)
				{
					Game.mGameState = eGameState.Setup;
					if (47187 - 230255 == -183068)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AE9D RID: 44701 RVA: 0x0133F10C File Offset: 0x0133D30C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (263615 - 395864 != -132248)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (149446 - 4974 != 144473)
			{
				if (num == PlayerData.UID)
				{
					if (101574 - 38109 == 63465)
					{
						this.SetupActors();
						if (68392 - 15394 == 52998)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (169758 - 182917 != -13158)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AE9E RID: 44702 RVA: 0x0133F1DC File Offset: 0x0133D3DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (9521 - 519849 != -510327)
		{
		}
		for (;;)
		{
			IL_196:
			Debug.Log("Creating Actors");
			if (184406 - 251733 == -67327)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (275340 - 355224 == -79884)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (160680 - 475114 == -314434)
						{
							int i = 0;
							if (245610 - 415224 != -169613)
							{
								CharacterControl[] array2 = array;
								if (219934 - 509901 == -289967)
								{
									int length = array2.Length;
									if (75074 - 340155 != -265080)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (129779 - 405139 == -275359)
											{
												goto IL_196;
											}
											if (type == "Anubi")
											{
												goto IL_61;
											}
											if (122735 - 566157 == -443421)
											{
												goto IL_196;
											}
											if (type == "Deadbeagle")
											{
												goto IL_61;
											}
											if (7681 - 337472 != -329791)
											{
												goto IL_196;
											}
											if (type == "Deadshund")
											{
												goto IL_61;
											}
											if (72428 - 201407 == -128978)
											{
												goto IL_196;
											}
											if (type == "Deadbull")
											{
												if (227041 - 334347 != -107305)
												{
													goto IL_61;
												}
												goto IL_196;
											}
											IL_290:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (13537 - 265231 != -251694)
											{
												goto IL_196;
											}
											this.uuLnlinuRrN++;
											if (4969 - 234851 == -229881)
											{
												goto IL_196;
											}
											i++;
											if (10426 - 528092 != -517665)
											{
												continue;
											}
											goto IL_196;
											IL_61:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (3291 - 104325 != -101034)
											{
												goto IL_196;
											}
											goto IL_290;
										}
										if (27608 - 120975 != -93366)
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
						if (92497 - 78272 != 14226)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AE9F RID: 44703 RVA: 0x0133F4D0 File Offset: 0x0133D6D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (133778 - 62373 != 71405)
		{
		}
		for (;;)
		{
			IL_96:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (225073 - 564971 == -339898)
			{
				int i = 0;
				if (3235 - 158428 != -155192)
				{
					CharacterControl[] array2 = array;
					if (279588 - 587172 == -307584)
					{
						int length = array2.Length;
						if (292072 - 414884 != -122811)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (70743 - 87412 == -16668)
								{
									goto IL_96;
								}
								i++;
								if (83294 - 324701 != -241407)
								{
									goto IL_96;
								}
							}
							if (163176 - 194097 == -30921)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AEA0 RID: 44704 RVA: 0x0133F600 File Offset: 0x0133D800
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (145958 - 14509 != 131450)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (289582 - 532243 == -242661)
			{
				Game.mGameState = eGameState.Ready;
				if (40792 - 125474 != -84681)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (8048 - 215637 != -207588 && 196810 - 189751 != 7060)
					{
						GameObject gameObject = null;
						if (213009 - 368886 != -155876)
						{
							if (playerSlot < 1)
							{
								goto IL_12A;
							}
							if (93180 - 523385 == -430204)
							{
								continue;
							}
							if (playerSlot > 6)
							{
								goto IL_12A;
							}
							if (34985 - 184865 == -149879)
							{
								continue;
							}
							GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
							if (183094 - 197525 != -14431)
							{
								continue;
							}
							gameObject = GameObject.Find("StartCamera" + playerSlot);
							if (40243 - 192993 == -152749)
							{
								continue;
							}
							IL_E4:
							if (gameObject2)
							{
								if (10753 - 120459 != -109706)
								{
									continue;
								}
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
								if (110321 - 147410 != -37089)
								{
									continue;
								}
								if (spawnPos != Vector3.zero)
								{
									if (128157 - 43197 == 84961)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
									if (93700 - 451286 == -357585)
									{
										continue;
									}
								}
								else
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (298555 - 63205 != 235350)
									{
										continue;
									}
								}
							}
							if (!gameObject)
							{
								break;
							}
							if (42011 - 583245 != -541234)
							{
								continue;
							}
							this.transform.position = gameObject.transform.position;
							if (276953 - 8943 == 268011)
							{
								continue;
							}
							this.transform.rotation = gameObject.transform.rotation;
							if (168621 - 472362 != -303740)
							{
								break;
							}
							continue;
							IL_12A:
							gameObject2 = GameObject.Find("StartPoint1");
							if (266725 - 290315 != -23589)
							{
								goto IL_E4;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AEA1 RID: 44705 RVA: 0x0133F924 File Offset: 0x0133DB24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M971_MaohsTomb6.$StartGame$45191(this).GetEnumerator();
	}

	// Token: 0x0600AEA2 RID: 44706 RVA: 0x0133F934 File Offset: 0x0133DB34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600AEA3 RID: 44707 RVA: 0x0133F938 File Offset: 0x0133DB38
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (52755 - 202119 != -149364)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (280627 - 542140 != -261512)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (311 - 190197 != -189885)
				{
					hashtable.Add(43, PlayerData.UID);
					if (38668 - 2470 != 36199)
					{
						hashtable.Add(73, nType);
						if (39521 - 581319 != -541797)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (215635 - 200299 == 15336)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (255463 - 269528 == -14065)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (222696 - 337690 == -114994)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (101625 - 409635 != -308009)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (221271 - 109706 == 111565)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (41912 - 50270 == -8358)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (188850 - 366128 != -177277)
													{
														this.GYunlUP0kc8.OpCustom(63, hashtable, true);
														if (231074 - 217987 != 13088)
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

	// Token: 0x0600AEA4 RID: 44708 RVA: 0x0133FC1C File Offset: 0x0133DE1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (154807 - 330192 != -175385)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (194719 - 562815 == -368096)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (119389 - 325030 != -205640)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (103335 - 138512 != -35176)
						{
							if (this.uuLnlinuRrN <= 0)
							{
								break;
							}
							if (250400 - 531407 == -281007)
							{
								this.uuLnlinuRrN--;
								if (64420 - 310664 != -246243)
								{
									if (this.uuLnlinuRrN != 0)
									{
										break;
									}
									if (186901 - 257968 == -71067)
									{
										Game.setGameState(eGameState.Ready);
										if (299778 - 324466 == -24688)
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
						if (55148 - 404355 != -349206)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (267960 - 414016 == -146056)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AEA5 RID: 44709 RVA: 0x0133FDAC File Offset: 0x0133DFAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600AEA6 RID: 44710 RVA: 0x0133FDC0 File Offset: 0x0133DFC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (61921 - 274412 != -212490)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (54844 - 404568 != -349723)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (94052 - 53115 != 40938)
				{
					if (!characterControl)
					{
						break;
					}
					if (260685 - 372528 != -111842)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (219099 - 584735 == -365636)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (269644 - 535539 == -265895)
							{
								string type = characterControl.Type;
								if (37501 - 9134 == 28367)
								{
									if (type == "Anubi")
									{
										if (174137 - 422664 == -248526)
										{
											continue;
										}
									}
									else if (type == "Deadbeagle")
									{
										if (171411 - 450496 != -279085)
										{
											continue;
										}
									}
									else if (type == "Deadshund")
									{
										if (196382 - 73882 != 122500)
										{
											continue;
										}
									}
									else
									{
										if (!(type == "Deadbull"))
										{
											break;
										}
										if (95068 - 201451 == -106382)
										{
											continue;
										}
									}
									IL_1BB:
									Game.sendMissionEvent(9715, 1);
									if (143943 - 101425 != 42519)
									{
										break;
									}
									continue;
									IL_CD:
									goto IL_1BB;
									goto IL_CD;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AEA7 RID: 44711 RVA: 0x0133FFC4 File Offset: 0x0133E1C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (239250 - 482067 != -242816)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (65931 - 441392 != -375460)
			{
				hashtable.Add(71, CID);
				if (266713 - 456758 != -190044)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (182491 - 436645 == -254154)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (272803 - 444756 != -171952)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (260185 - 227421 != 32765)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (246677 - 149063 == 97614)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (69166 - 42685 != 26482)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (8883 - 38452 == -29569)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (178073 - 122654 == 55419)
											{
												this.GYunlUP0kc8.OpCustom(61, hashtable, true);
												if (33929 - 111317 != -77387)
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

	// Token: 0x0600AEA8 RID: 44712 RVA: 0x01340250 File Offset: 0x0133E450
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (177902 - 61958 != 115945)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (223613 - 192920 != 30694)
			{
				if (!gameObject)
				{
					break;
				}
				if (180738 - 406098 != -225359)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (84707 - 13732 != 70976)
					{
						playerCameraControl.target = gameObject;
						if (293204 - 578509 == -285305)
						{
							Game.loadPlayer();
							if (114603 - 3872 != 110732)
							{
								this.StartCoroutine_Auto(this.StartGame());
								if (8033 - 141569 != -133535)
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

	// Token: 0x0600AEA9 RID: 44713 RVA: 0x01340368 File Offset: 0x0133E568
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (108274 - 517501 != -409226)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (138650 - 30040 == 108610)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (78685 - 412706 == -334021)
				{
					gameGui.ResetTeamBar();
					if (74477 - 200832 != -126354)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AEAA RID: 44714 RVA: 0x01340414 File Offset: 0x0133E614
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M971_MaohsTomb6.$onDeadPlayer$45195(this).GetEnumerator();
	}

	// Token: 0x0600AEAB RID: 44715 RVA: 0x01340424 File Offset: 0x0133E624
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (210045 - 282415 != -72370)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (286200 - 410086 != -123885)
			{
				this.cWFnlN8XwZw.target = Game.mPlayer;
				if (126529 - 193919 != -67389)
				{
					this.cWFnlN8XwZw.enabled = true;
					if (232610 - 251002 != -18391)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (162153 - 431653 != -269500)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (215792 - 476674 == -260881)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (137795 - 547066 != -409270)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (41357 - 584285 != -542927)
							{
								if (!gameGui)
								{
									break;
								}
								if (135315 - 10404 != 124912)
								{
									gameGui.enabled = true;
									if (41194 - 341342 == -300148)
									{
										gameGui.closeDeadMenu();
										if (143274 - 228227 != -84952)
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

	// Token: 0x0600AEAC RID: 44716 RVA: 0x013405D0 File Offset: 0x0133E7D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (36246 - 370968 != -334721)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (241201 - 383731 == -142530)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (230067 - 342488 != -112420)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (98220 - 32867 == 65353)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AEAD RID: 44717 RVA: 0x01340694 File Offset: 0x0133E894
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600AEAE RID: 44718 RVA: 0x013406C0 File Offset: 0x0133E8C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (272389 - 482115 != -209725)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (143463 - 37695 == 105768)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (207508 - 401312 != -193803)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (165295 - 402138 != -236842)
					{
						Hashtable hashtable = new Hashtable();
						if (229090 - 88311 == 140779)
						{
							hashtable.Add(43, PlayerData.UID);
							if (295787 - 498868 != -203080)
							{
								hashtable.Add(71, nCID);
								if (92852 - 328457 == -235605)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (161191 - 59145 == 102046)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (252701 - 133242 == 119459)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (269610 - 99316 == 170294)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (173465 - 584579 == -411114)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (9032 - 383664 != -374631)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (28386 - 427954 != -399567)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (5259 - 501046 == -495787)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (285068 - 39598 == 245470)
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

	// Token: 0x0600AEAF RID: 44719 RVA: 0x013409E0 File Offset: 0x0133EBE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M971_MaohsTomb6.$onChangePlayer$45201(data, this).GetEnumerator();
	}

	// Token: 0x0600AEB0 RID: 44720 RVA: 0x013409F0 File Offset: 0x0133EBF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M971_MaohsTomb6.$onGameComplete$45208(data, this).GetEnumerator();
	}

	// Token: 0x0600AEB1 RID: 44721 RVA: 0x01340A00 File Offset: 0x0133EC00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M971_MaohsTomb6.$ReturnToTown$45217(this).GetEnumerator();
	}

	// Token: 0x0600AEB2 RID: 44722 RVA: 0x01340A10 File Offset: 0x0133EC10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M971_MaohsTomb6.$ReturnToGuild$45222(this).GetEnumerator();
	}

	// Token: 0x0600AEB3 RID: 44723 RVA: 0x01340A20 File Offset: 0x0133EC20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M971_MaohsTomb6.$ReturnToCamp$45226(this).GetEnumerator();
	}

	// Token: 0x0600AEB4 RID: 44724 RVA: 0x01340A30 File Offset: 0x0133EC30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (117304 - 594632 != -477328)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (186206 - 126705 != 59502)
			{
				Hashtable hashtable = new Hashtable();
				if (30379 - 404662 != -374282)
				{
					hashtable.Add(43, PlayerData.UID);
					if (49381 - 189803 == -140422)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (117783 - 199889 == -82106)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AEB5 RID: 44725 RVA: 0x01340B08 File Offset: 0x0133ED08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600AEB6 RID: 44726 RVA: 0x01340B1C File Offset: 0x0133ED1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (130009 - 429106 != -299097)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (97221 - 423139 == -325918)
			{
				Hashtable hashtable = new Hashtable();
				if (148447 - 374987 == -226540)
				{
					if (Game.mNextGameCode == 30)
					{
						if (151842 - 356625 == -204782)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (96224 - 166897 != -70673)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (176385 - 75556 != 100829)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (288664 - 152111 != 136553)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (52895 - 161086 != -108191)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (209717 - 317175 == -107457)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (44363 - 143019 == -98655)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (127906 - 345984 == -218077)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (203654 - 549258 != -345604)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (255778 - 115126 != 140652)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (290951 - 146229 == 144723)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (5528 - 465055 != -459527)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (49792 - 344099 != -294307)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (71526 - 596219 == -524692)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (265077 - 351599 != -86522)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (145363 - 15030 == 130334)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (212881 - 338718 != -125837)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (137942 - 318196 != -180254)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (111295 - 362909 == -251613)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (70414 - 384930 == -314515)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (79958 - 475964 != -396006)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (155165 - 62240 != 92925)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (46225 - 543595 == -497369)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (157880 - 113185 != 44695)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (261781 - 349192 != -87411)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (299230 - 135350 != 163880)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (246481 - 344632 == -98150)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (39417 - 204250 == -164832)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (81142 - 269974 == -188832)
					{
						this.GYunlUP0kc8.OpCustom(42, hashtable, true);
						if (202384 - 17182 != 185203)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AEB7 RID: 44727 RVA: 0x013410D0 File Offset: 0x0133F2D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600AEB8 RID: 44728 RVA: 0x013410E0 File Offset: 0x0133F2E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600AEB9 RID: 44729 RVA: 0x013410E4 File Offset: 0x0133F2E4
	internal static bool znObUuVrjopuKwb4AACa()
	{
		return true;
	}

	// Token: 0x0600AEBA RID: 44730 RVA: 0x013410E8 File Offset: 0x0133F2E8
	internal static bool AF3ZBWVrhK4fQtarGf4Q()
	{
		return false;
	}

	// Token: 0x040099B8 RID: 39352
	private LitePeer GYunlUP0kc8;

	// Token: 0x040099B9 RID: 39353
	private PlayerCameraControl cWFnlN8XwZw;

	// Token: 0x040099BA RID: 39354
	private float C86nlExM8da;

	// Token: 0x040099BB RID: 39355
	private int mqVnlPkFFAj;

	// Token: 0x040099BC RID: 39356
	private int XQYnlSoVq7n;

	// Token: 0x040099BD RID: 39357
	private int CFunlB7JYuO;

	// Token: 0x040099BE RID: 39358
	private bool dsVnl03KDBE;

	// Token: 0x040099BF RID: 39359
	public AudioClip catGate_fx;

	// Token: 0x040099C0 RID: 39360
	private bool KGRnl8CIy5I;

	// Token: 0x040099C1 RID: 39361
	private int uuLnlinuRrN;

	// Token: 0x02001D2D RID: 7469
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$45176 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AEBB RID: 44731 RVA: 0x013410EC File Offset: 0x0133F2EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$45176(Hashtable data, M971_MaohsTomb6 self_)
		{
			if (28037 - 22806 != 5232)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (241290 - 444202 == -202912)
				{
					base..ctor();
					if (81935 - 444006 != -362070)
					{
						this.$data$45184 = data;
						if (241404 - 524928 != -283523)
						{
							this.$self_$45185 = self_;
							if (227358 - 570985 == -343627)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AEBC RID: 44732 RVA: 0x013411A8 File Offset: 0x0133F3A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb6.$onGameEvent$45176.$(this.$data$45184, this.$self_$45185);
		}

		// Token: 0x0600AEBD RID: 44733 RVA: 0x013411BC File Offset: 0x0133F3BC
		internal static bool gkaJG8VrsLkoaBrKrMIE()
		{
			return true;
		}

		// Token: 0x0600AEBE RID: 44734 RVA: 0x013411C0 File Offset: 0x0133F3C0
		internal static bool RDmoGIVr90H9hSPZ2jSS()
		{
			return false;
		}

		// Token: 0x040099C2 RID: 39362
		internal Hashtable $data$45184;

		// Token: 0x040099C3 RID: 39363
		internal M971_MaohsTomb6 $self_$45185;

		// Token: 0x02001D2E RID: 7470
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AEBF RID: 44735 RVA: 0x013411C4 File Offset: 0x0133F3C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb6 self_)
			{
				if (66242 - 537456 != -471213)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (254562 - 506177 != -251614)
					{
						base..ctor();
						if (121126 - 267046 == -145920)
						{
							this.$data$45182 = data;
							if (15766 - 321055 != -305288)
							{
								this.$self_$45183 = self_;
								if (219506 - 51425 != 168082)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AEC0 RID: 44736 RVA: 0x01341280 File Offset: 0x0133F480
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (42302 - 566494 != -524191)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_556;
					case 2:
						Game.savePlayer();
						if (68349 - 414066 == -345716)
						{
							continue;
						}
						if (this.$returnValue$45178 == 7)
						{
							if (141422 - 509453 != -368031)
							{
								continue;
							}
							Game.mGameStage = 7;
							if (48437 - 81647 == -33209)
							{
								continue;
							}
							Application.LoadLevel("M971_MaohsTomb7");
							if (262962 - 234327 != 28636)
							{
								goto IL_120;
							}
							continue;
						}
						else
						{
							Game.mGameStage = 6;
							if (13129 - 457191 != -444062)
							{
								continue;
							}
							Application.LoadLevel("M971_MaohsTomb6");
							if (61772 - 372167 != -310394)
							{
								goto IL_120;
							}
							continue;
						}
						break;
					default:
						if (51387 - 467981 != -416594)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (28420 - 598150 != -569730)
						{
							continue;
						}
						goto IL_517;
					}
					else
					{
						this.$returnCode$45177 = RuntimeServices.UnboxInt32(this.$data$45182[141]);
						if (224254 - 385852 == -161597)
						{
							continue;
						}
						this.$returnValue$45178 = RuntimeServices.UnboxInt32(this.$data$45182[145]);
						if (104637 - 37060 != 67577)
						{
							continue;
						}
						this.$ownerID$45179 = RuntimeServices.UnboxInt32(this.$data$45182[43]);
						if (28531 - 44370 != -15839)
						{
							continue;
						}
						this.$$switch$8440$45180 = this.$returnCode$45177;
						if (174248 - 172704 == 1545)
						{
							continue;
						}
						if (this.$$switch$8440$45180 == 9711)
						{
							if (29228 - 12993 == 16236)
							{
								continue;
							}
						}
						else if (this.$$switch$8440$45180 == -9711)
						{
							if (203494 - 140799 == 62696)
							{
								continue;
							}
							if (this.$self_$45183.XQYnlSoVq7n < 1)
							{
								if (234439 - 199389 == 35051)
								{
									continue;
								}
								this.$self_$45183.XQYnlSoVq7n = 1;
								if (298557 - 166827 != 131730)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (266362 - 138681 != 127681)
								{
									continue;
								}
								this.$mGameGui$45181 = (GameGui)this.$self_$45183.GetComponent(typeof(GameGui));
								if (289451 - 177057 == 112395)
								{
									continue;
								}
								this.$mGameGui$45181.close();
								if (194696 - 404345 == -209648)
								{
									continue;
								}
								this.$self_$45183.SendMessage("fadeOut");
								if (65439 - 415896 != -350457)
								{
									continue;
								}
								break;
							}
						}
						else if (this.$$switch$8440$45180 == 9712)
						{
							if (50241 - 406141 != -355900)
							{
								continue;
							}
						}
						else if (this.$$switch$8440$45180 == -9712)
						{
							if (85838 - 372857 == -287018)
							{
								continue;
							}
						}
						else if (this.$$switch$8440$45180 == 9713)
						{
							if (28868 - 410438 == -381569)
							{
								continue;
							}
							this.$self_$45183.OpenCatGate(this.$returnValue$45178);
							if (133900 - 284250 != -150350)
							{
								continue;
							}
						}
						else if (this.$$switch$8440$45180 == 9715)
						{
							if (200361 - 452785 == -252423)
							{
								continue;
							}
							this.$self_$45183.CFunlB7JYuO = this.$self_$45183.CFunlB7JYuO + 1;
							if (75704 - 92643 != -16939)
							{
								continue;
							}
							this.$self_$45183.SendMessage("newGameMessage", "Mummy clean up:" + this.$self_$45183.CFunlB7JYuO + "/13");
							if (51733 - 382780 == -331046)
							{
								continue;
							}
							Chat.SubmitChat("none", "Mummy clean up:" + this.$self_$45183.CFunlB7JYuO + "/13", eChatType.system, eChatMode.system);
							if (289289 - 567168 != -277879)
							{
								continue;
							}
						}
					}
					IL_2B1:
					this.YieldDefault(1);
					if (108556 - 169576 != -61020)
					{
						continue;
					}
					goto IL_556;
					IL_120:
					goto IL_2B1;
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_517:
				IL_556:
				return false;
			}

			// Token: 0x0600AEC1 RID: 44737 RVA: 0x013417F8 File Offset: 0x0133F9F8
			internal static bool L2GIB4Vr1xpk5GEUU5pb()
			{
				return true;
			}

			// Token: 0x0600AEC2 RID: 44738 RVA: 0x013417FC File Offset: 0x0133F9FC
			internal static bool AhYpmZVr4VK16rVTUsFy()
			{
				return false;
			}

			// Token: 0x040099C4 RID: 39364
			internal int $returnCode$45177;

			// Token: 0x040099C5 RID: 39365
			internal int $returnValue$45178;

			// Token: 0x040099C6 RID: 39366
			internal int $ownerID$45179;

			// Token: 0x040099C7 RID: 39367
			internal int $$switch$8440$45180;

			// Token: 0x040099C8 RID: 39368
			internal GameGui $mGameGui$45181;

			// Token: 0x040099C9 RID: 39369
			internal Hashtable $data$45182;

			// Token: 0x040099CA RID: 39370
			internal M971_MaohsTomb6 $self_$45183;
		}
	}

	// Token: 0x02001D2F RID: 7471
	[CompilerGenerated]
	[Serializable]
	internal sealed class $UseCatGate$45186 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AEC3 RID: 44739 RVA: 0x01341800 File Offset: 0x0133FA00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $UseCatGate$45186(int nGate, M971_MaohsTomb6 self_)
		{
			if (67383 - 94021 != -26637)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (129521 - 199670 != -70148)
				{
					base..ctor();
					if (81286 - 58613 == 22673)
					{
						this.$nGate$45189 = nGate;
						if (90123 - 530021 == -439898)
						{
							this.$self_$45190 = self_;
							if (96081 - 78994 == 17087)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AEC4 RID: 44740 RVA: 0x013418BC File Offset: 0x0133FABC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb6.$UseCatGate$45186.$(this.$nGate$45189, this.$self_$45190);
		}

		// Token: 0x0600AEC5 RID: 44741 RVA: 0x013418D0 File Offset: 0x0133FAD0
		internal static bool vKk8qGVrzm7G9NJU6asm()
		{
			return true;
		}

		// Token: 0x0600AEC6 RID: 44742 RVA: 0x013418D4 File Offset: 0x0133FAD4
		internal static bool IsdhddVjaB8OmAXXq3XX()
		{
			return false;
		}

		// Token: 0x040099CB RID: 39371
		internal int $nGate$45189;

		// Token: 0x040099CC RID: 39372
		internal M971_MaohsTomb6 $self_$45190;

		// Token: 0x02001D30 RID: 7472
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AEC7 RID: 44743 RVA: 0x013418D8 File Offset: 0x0133FAD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nGate, M971_MaohsTomb6 self_)
			{
				if (23565 - 109728 != -86163)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (106709 - 339414 != -232704)
					{
						base..ctor();
						if (166729 - 381136 != -214406)
						{
							this.$nGate$45187 = nGate;
							if (219108 - 1508 == 217600)
							{
								this.$self_$45188 = self_;
								if (31169 - 244994 != -213824)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AEC8 RID: 44744 RVA: 0x01341994 File Offset: 0x0133FB94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (45361 - 24387 != 20974)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_13D;
					case 1:
						goto IL_254;
					case 2:
						if (Game.mGameState > eGameState.AllHold)
						{
							if (105943 - 234984 != -129040)
							{
								goto Block_5;
							}
							continue;
						}
						else if (this.$self_$45188.mqVnlPkFFAj == this.$nGate$45187)
						{
							if (285064 - 355779 != -70715)
							{
								continue;
							}
							Game.sendMissionEvent(9711, 7);
							if (244046 - 98705 != 145341)
							{
								continue;
							}
						}
						else
						{
							Game.sendMissionEvent(9711, -7);
							if (73015 - 547815 != -474800)
							{
								continue;
							}
						}
						break;
					default:
						if (283663 - 297412 != -13749)
						{
							continue;
						}
						goto IL_13D;
					}
					IL_40:
					this.YieldDefault(1);
					if (129216 - 82325 != 46892)
					{
						break;
					}
					continue;
					IL_13D:
					if (this.$self_$45188.CFunlB7JYuO < 13)
					{
						if (213661 - 142013 != 71649)
						{
							this.$self_$45188.SendMessage("newGameMessage", "Need to clear " + (13 - this.$self_$45188.CFunlB7JYuO) + " mummies");
							if (132652 - 222153 != -89500)
							{
								goto IL_40;
							}
						}
					}
					else
					{
						if (this.$self_$45188.dsVnl03KDBE)
						{
							goto IL_40;
						}
						if (9069 - 536870 == -527801)
						{
							this.$self_$45188.dsVnl03KDBE = true;
							if (196073 - 169996 == 26077)
							{
								this.$self_$45188.OpenCatGate(this.$nGate$45187);
								if (184092 - 442962 != -258869)
								{
									Game.sendMissionEvent(9713, this.$nGate$45187);
									if (122070 - 168995 == -46925)
									{
										goto IL_62;
									}
								}
							}
						}
					}
				}
				goto IL_254;
				IL_62:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_5:
				IL_254:
				return false;
			}

			// Token: 0x0600AEC9 RID: 44745 RVA: 0x01341C08 File Offset: 0x0133FE08
			internal static bool DTIohwVj5Nb3gYYDJZAG()
			{
				return true;
			}

			// Token: 0x0600AECA RID: 44746 RVA: 0x01341C0C File Offset: 0x0133FE0C
			internal static bool EvDZr5VjppqufJWhyXID()
			{
				return false;
			}

			// Token: 0x040099CD RID: 39373
			internal int $nGate$45187;

			// Token: 0x040099CE RID: 39374
			internal M971_MaohsTomb6 $self_$45188;
		}
	}

	// Token: 0x02001D31 RID: 7473
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$45191 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AECB RID: 44747 RVA: 0x01341C10 File Offset: 0x0133FE10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$45191(M971_MaohsTomb6 self_)
		{
			if (148147 - 135508 != 12640)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (142663 - 217988 != -75324)
				{
					base..ctor();
					if (271881 - 288104 == -16223)
					{
						this.$self_$45194 = self_;
						if (129965 - 332709 != -202743)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AECC RID: 44748 RVA: 0x01341CA8 File Offset: 0x0133FEA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb6.$StartGame$45191.$(this.$self_$45194);
		}

		// Token: 0x0600AECD RID: 44749 RVA: 0x01341CB8 File Offset: 0x0133FEB8
		internal static bool I1D1w3VjVqAnA7MnICmF()
		{
			return true;
		}

		// Token: 0x0600AECE RID: 44750 RVA: 0x01341CBC File Offset: 0x0133FEBC
		internal static bool DIMc1DVjtHZRq9fb45XC()
		{
			return false;
		}

		// Token: 0x040099CF RID: 39375
		internal M971_MaohsTomb6 $self_$45194;

		// Token: 0x02001D32 RID: 7474
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AECF RID: 44751 RVA: 0x01341CC0 File Offset: 0x0133FEC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb6 self_)
			{
				if (100607 - 378835 != -278228)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (160896 - 46650 != 114247)
					{
						base..ctor();
						if (200205 - 152859 == 47346)
						{
							this.$self_$45193 = self_;
							if (238153 - 518322 != -280168)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AED0 RID: 44752 RVA: 0x01341D58 File Offset: 0x0133FF58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (122674 - 234966 != -112291)
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
						if (77314 - 153740 == -76425)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (64576 - 437042 == -372465)
						{
							continue;
						}
						this.YieldDefault(1);
						if (87379 - 401992 != -314612)
						{
							goto Block_4;
						}
						continue;
					default:
						if (227507 - 523077 == -295569)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (181309 - 167303 == 14006)
					{
						Game.mGameState = eGameState.Start;
						if (8179 - 76829 == -68650)
						{
							Game.mStateTime = Time.time;
							if (96486 - 306924 != -210437)
							{
								this.$mGameGui$45192 = (GameGui)this.$self_$45193.GetComponent(typeof(GameGui));
								if (272394 - 48825 == 223569)
								{
									this.$mGameGui$45192.enabled = true;
									if (12764 - 247991 != -235226)
									{
										this.$self_$45193.SendMessage("fadeIn");
										if (149046 - 205397 == -56351)
										{
											goto IL_E4;
										}
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_1B9;
				IL_E4:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1B9:
				return false;
			}

			// Token: 0x0600AED1 RID: 44753 RVA: 0x01341F30 File Offset: 0x01340130
			internal static bool z5uSIYVjNc7r0KkjMeqy()
			{
				return true;
			}

			// Token: 0x0600AED2 RID: 44754 RVA: 0x01341F34 File Offset: 0x01340134
			internal static bool xh0wReVjYqJ2LEaVqCC9()
			{
				return false;
			}

			// Token: 0x040099D0 RID: 39376
			internal GameGui $mGameGui$45192;

			// Token: 0x040099D1 RID: 39377
			internal M971_MaohsTomb6 $self_$45193;
		}
	}

	// Token: 0x02001D33 RID: 7475
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$45195 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AED3 RID: 44755 RVA: 0x01341F38 File Offset: 0x01340138
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$45195(M971_MaohsTomb6 self_)
		{
			if (298725 - 475089 != -176364)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (201079 - 72904 != 128176)
				{
					base..ctor();
					if (251316 - 484160 != -232843)
					{
						this.$self_$45200 = self_;
						if (112456 - 108269 != 4188)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AED4 RID: 44756 RVA: 0x01341FD0 File Offset: 0x013401D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb6.$onDeadPlayer$45195.$(this.$self_$45200);
		}

		// Token: 0x0600AED5 RID: 44757 RVA: 0x01341FE0 File Offset: 0x013401E0
		internal static bool SPtPIjVjc2xHVemXV6lv()
		{
			return true;
		}

		// Token: 0x0600AED6 RID: 44758 RVA: 0x01341FE4 File Offset: 0x013401E4
		internal static bool EGAHY1VjULewnKnMsFuR()
		{
			return false;
		}

		// Token: 0x040099D2 RID: 39378
		internal M971_MaohsTomb6 $self_$45200;

		// Token: 0x02001D34 RID: 7476
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AED7 RID: 44759 RVA: 0x01341FE8 File Offset: 0x013401E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb6 self_)
			{
				if (288747 - 315905 != -27158)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (46376 - 596029 != -549652)
					{
						base..ctor();
						if (212493 - 26707 != 185787)
						{
							this.$self_$45199 = self_;
							if (288507 - 519734 == -231227)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AED8 RID: 44760 RVA: 0x01342080 File Offset: 0x01340280
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (47488 - 312174 != -264685)
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
							goto IL_17F;
						}
						if (82418 - 501848 != -419430)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (173202 - 264981 != -91779)
							{
								continue;
							}
							goto IL_17F;
						}
						IL_BF:
						this.YieldDefault(1);
						if (224098 - 433311 != -209213)
						{
							continue;
						}
						goto IL_2F9;
						IL_17F:
						Game.mGameState = eGameState.Hold;
						if (138836 - 301305 == -162468)
						{
							continue;
						}
						this.$mStoryGui$45196 = (StoryGui)this.$self_$45199.GetComponent(typeof(StoryGui));
						if (60493 - 336404 != -275911)
						{
							continue;
						}
						if (this.$mStoryGui$45196)
						{
							if (159737 - 156336 == 3402)
							{
								continue;
							}
							this.$mStoryGui$45196.close();
							if (100882 - 392884 != -292002)
							{
								continue;
							}
						}
						this.$mChangeGui$45197 = (ChangeGui)this.$self_$45199.GetComponent(typeof(ChangeGui));
						if (229170 - 86820 == 142351)
						{
							continue;
						}
						if (this.$mChangeGui$45197)
						{
							if (8807 - 441927 != -433120)
							{
								continue;
							}
							this.$mChangeGui$45197.close();
							if (201378 - 331544 != -130166)
							{
								continue;
							}
						}
						this.$mGameGui$45198 = (GameGui)this.$self_$45199.GetComponent(typeof(GameGui));
						if (183610 - 322355 == -138744)
						{
							continue;
						}
						if (!this.$mGameGui$45198)
						{
							goto IL_BF;
						}
						if (210216 - 217825 != -7609)
						{
							continue;
						}
						if (!this.$mGameGui$45198.enabled)
						{
							if (181078 - 139418 != 41660)
							{
								continue;
							}
							this.$mGameGui$45198.enabled = true;
							if (148338 - 481179 != -332841)
							{
								continue;
							}
						}
						this.$mGameGui$45198.openDeadMenu();
						if (196820 - 263348 != -66527)
						{
							goto IL_BF;
						}
						continue;
					default:
						if (245141 - 503417 != -258276)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (107196 - 26754 != 80442);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600AED9 RID: 44761 RVA: 0x01342398 File Offset: 0x01340598
			internal static bool aeai8nVjTcAlIoL5NNT2()
			{
				return true;
			}

			// Token: 0x0600AEDA RID: 44762 RVA: 0x0134239C File Offset: 0x0134059C
			internal static bool JudSxLVj3njxDFxwcN29()
			{
				return false;
			}

			// Token: 0x040099D3 RID: 39379
			internal StoryGui $mStoryGui$45196;

			// Token: 0x040099D4 RID: 39380
			internal ChangeGui $mChangeGui$45197;

			// Token: 0x040099D5 RID: 39381
			internal GameGui $mGameGui$45198;

			// Token: 0x040099D6 RID: 39382
			internal M971_MaohsTomb6 $self_$45199;
		}
	}

	// Token: 0x02001D35 RID: 7477
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$45201 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AEDB RID: 44763 RVA: 0x013423A0 File Offset: 0x013405A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$45201(Hashtable data, M971_MaohsTomb6 self_)
		{
			if (219765 - 28203 != 191562)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (155594 - 289497 != -133902)
				{
					base..ctor();
					if (259400 - 247315 != 12086)
					{
						this.$data$45206 = data;
						if (44183 - 111621 != -67437)
						{
							this.$self_$45207 = self_;
							if (1286 - 313081 != -311794)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AEDC RID: 44764 RVA: 0x0134245C File Offset: 0x0134065C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb6.$onChangePlayer$45201.$(this.$data$45206, this.$self_$45207);
		}

		// Token: 0x0600AEDD RID: 44765 RVA: 0x01342470 File Offset: 0x01340670
		internal static bool guK5XrVjX0yf5GUBE4aa()
		{
			return true;
		}

		// Token: 0x0600AEDE RID: 44766 RVA: 0x01342474 File Offset: 0x01340674
		internal static bool p2qAcFVjQBwCfo67A0fa()
		{
			return false;
		}

		// Token: 0x040099D7 RID: 39383
		internal Hashtable $data$45206;

		// Token: 0x040099D8 RID: 39384
		internal M971_MaohsTomb6 $self_$45207;

		// Token: 0x02001D36 RID: 7478
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AEDF RID: 44767 RVA: 0x01342478 File Offset: 0x01340678
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb6 self_)
			{
				if (269546 - 460503 != -190957)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (31252 - 541478 == -510226)
					{
						base..ctor();
						if (140720 - 139238 == 1482)
						{
							this.$data$45204 = data;
							if (196899 - 280611 == -83712)
							{
								this.$self_$45205 = self_;
								if (254635 - 215142 != 39494)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AEE0 RID: 44768 RVA: 0x01342534 File Offset: 0x01340734
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (38593 - 252533 != -213940)
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
							if (53887 - 299554 == -245666)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (165776 - 299430 != -133654)
							{
								continue;
							}
							this.$mGameGui$45203 = (GameGui)this.$self_$45205.GetComponent(typeof(GameGui));
							if (206619 - 334833 == -128213)
							{
								continue;
							}
							this.$mGameGui$45203.enabled = true;
							if (184309 - 400964 != -216655)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (250595 - 266468 != -15873)
						{
							continue;
						}
						goto IL_205;
					default:
						if (4663 - 201043 == -196379)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (106226 - 330446 == -224220)
					{
						this.$self_$45205.SendMessage("onCreatePlayer", this.$data$45204);
						if (93828 - 93330 == 498)
						{
							this.$mChangeGui$45202 = (ChangeGui)this.$self_$45205.GetComponent(typeof(ChangeGui));
							if (66097 - 525792 != -459694)
							{
								if (!this.$mChangeGui$45202.enabled)
								{
									break;
								}
								if (63922 - 123996 != -60073)
								{
									this.$mChangeGui$45202.close();
									if (80140 - 45109 != 35032)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_76:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_76;
				IL_205:
				return false;
			}

			// Token: 0x0600AEE1 RID: 44769 RVA: 0x01342758 File Offset: 0x01340958
			internal static bool iEt94jVjkrSHtJcPBHL0()
			{
				return true;
			}

			// Token: 0x0600AEE2 RID: 44770 RVA: 0x0134275C File Offset: 0x0134095C
			internal static bool zHn43UVjGhrmIcmpirvn()
			{
				return false;
			}

			// Token: 0x040099D9 RID: 39385
			internal ChangeGui $mChangeGui$45202;

			// Token: 0x040099DA RID: 39386
			internal GameGui $mGameGui$45203;

			// Token: 0x040099DB RID: 39387
			internal Hashtable $data$45204;

			// Token: 0x040099DC RID: 39388
			internal M971_MaohsTomb6 $self_$45205;
		}
	}

	// Token: 0x02001D37 RID: 7479
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$45208 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AEE3 RID: 44771 RVA: 0x01342760 File Offset: 0x01340960
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$45208(Hashtable data, M971_MaohsTomb6 self_)
		{
			if (177027 - 385304 != -208277)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (93753 - 168084 != -74330)
				{
					base..ctor();
					if (155392 - 492542 == -337150)
					{
						this.$data$45215 = data;
						if (180774 - 485979 != -305204)
						{
							this.$self_$45216 = self_;
							if (136908 - 584040 != -447131)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AEE4 RID: 44772 RVA: 0x0134281C File Offset: 0x01340A1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb6.$onGameComplete$45208.$(this.$data$45215, this.$self_$45216);
		}

		// Token: 0x0600AEE5 RID: 44773 RVA: 0x01342830 File Offset: 0x01340A30
		internal static bool r4ZdRvVjHJtcsAYkkyuj()
		{
			return true;
		}

		// Token: 0x0600AEE6 RID: 44774 RVA: 0x01342834 File Offset: 0x01340A34
		internal static bool JJlCXjVjWOeqsyS13kVa()
		{
			return false;
		}

		// Token: 0x040099DD RID: 39389
		internal Hashtable $data$45215;

		// Token: 0x040099DE RID: 39390
		internal M971_MaohsTomb6 $self_$45216;

		// Token: 0x02001D38 RID: 7480
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AEE7 RID: 44775 RVA: 0x01342838 File Offset: 0x01340A38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M971_MaohsTomb6 self_)
			{
				if (225751 - 310605 != -84854)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (71409 - 518810 == -447401)
					{
						base..ctor();
						if (172200 - 493261 != -321060)
						{
							this.$data$45213 = data;
							if (16543 - 42865 == -26322)
							{
								this.$self_$45214 = self_;
								if (187901 - 153159 != 34743)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AEE8 RID: 44776 RVA: 0x013428F4 File Offset: 0x01340AF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (142990 - 515619 != -372628)
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
						this.$mCompleteGui$45210 = (CompleteGui)this.$self_$45214.GetComponent(typeof(CompleteGui));
						if (233924 - 426976 == -193051)
						{
							continue;
						}
						this.$mCompleteGui$45210.Init();
						if (217840 - 350827 != -132987)
						{
							continue;
						}
						this.$mCompleteGui$45210.readData(this.$data$45213);
						if (207917 - 94829 == 113089)
						{
							continue;
						}
						if (this.$result$45209 == 1)
						{
							if (186550 - 182760 != 3790)
							{
								continue;
							}
							this.$mCompleteGui$45210.displayResult(eCompleteType.Success);
							if (107375 - 153026 != -45651)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$45210.displayResult(eCompleteType.Failed);
							if (107578 - 12068 != 95510)
							{
								continue;
							}
						}
						this.$mGameGui$45211 = (GameGui)this.$self_$45214.GetComponent(typeof(GameGui));
						if (183842 - 378944 == -195101)
						{
							continue;
						}
						this.$mStoryGui$45212 = (StoryGui)this.$self_$45214.GetComponent(typeof(StoryGui));
						if (81162 - 490693 != -409531)
						{
							continue;
						}
						if (this.$mGameGui$45211)
						{
							if (269495 - 415131 == -145635)
							{
								continue;
							}
							this.$mGameGui$45211.close();
							if (9787 - 109114 != -99327)
							{
								continue;
							}
						}
						if (this.$mStoryGui$45212)
						{
							if (46718 - 597349 == -550630)
							{
								continue;
							}
							this.$mStoryGui$45212.close();
							if (2609 - 473671 != -471062)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (295387 - 112297 != 183090)
						{
							continue;
						}
						goto IL_352;
					default:
						if (83219 - 65292 == 17928)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$45213[31]);
					if (44939 - 293329 != -248389)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (130988 - 301465 == -170477)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (153185 - 512066 == -358881)
							{
								this.$result$45209 = RuntimeServices.UnboxInt32(this.$data$45213[31]);
								if (18675 - 118121 != -99445)
								{
									goto Block_23;
								}
							}
						}
					}
				}
				goto IL_352;
				Block_23:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x0600AEE9 RID: 44777 RVA: 0x01342C68 File Offset: 0x01340E68
			internal static bool MlhnVKVjAtdTHdKICrRV()
			{
				return true;
			}

			// Token: 0x0600AEEA RID: 44778 RVA: 0x01342C6C File Offset: 0x01340E6C
			internal static bool EyRmvqVjlZmnCaSPWaOo()
			{
				return false;
			}

			// Token: 0x040099DF RID: 39391
			internal int $result$45209;

			// Token: 0x040099E0 RID: 39392
			internal CompleteGui $mCompleteGui$45210;

			// Token: 0x040099E1 RID: 39393
			internal GameGui $mGameGui$45211;

			// Token: 0x040099E2 RID: 39394
			internal StoryGui $mStoryGui$45212;

			// Token: 0x040099E3 RID: 39395
			internal Hashtable $data$45213;

			// Token: 0x040099E4 RID: 39396
			internal M971_MaohsTomb6 $self_$45214;
		}
	}

	// Token: 0x02001D39 RID: 7481
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$45217 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AEEB RID: 44779 RVA: 0x01342C70 File Offset: 0x01340E70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$45217(M971_MaohsTomb6 self_)
		{
			if (293916 - 551291 != -257374)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (202374 - 110294 == 92080)
				{
					base..ctor();
					if (97829 - 275677 != -177847)
					{
						this.$self_$45221 = self_;
						if (201790 - 91592 != 110199)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AEEC RID: 44780 RVA: 0x01342D08 File Offset: 0x01340F08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb6.$ReturnToTown$45217.$(this.$self_$45221);
		}

		// Token: 0x0600AEED RID: 44781 RVA: 0x01342D18 File Offset: 0x01340F18
		internal static bool nMQTt3Vjyje8eTEhrs4M()
		{
			return true;
		}

		// Token: 0x0600AEEE RID: 44782 RVA: 0x01342D1C File Offset: 0x01340F1C
		internal static bool xb64adVjSBoQegp23Zfi()
		{
			return false;
		}

		// Token: 0x040099E5 RID: 39397
		internal M971_MaohsTomb6 $self_$45221;

		// Token: 0x02001D3A RID: 7482
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AEEF RID: 44783 RVA: 0x01342D20 File Offset: 0x01340F20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb6 self_)
			{
				if (154422 - 515281 != -360859)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (205528 - 67787 == 137741)
					{
						base..ctor();
						if (218957 - 17575 != 201383)
						{
							this.$self_$45220 = self_;
							if (59145 - 169952 != -110806)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AEF0 RID: 44784 RVA: 0x01342DB8 File Offset: 0x01340FB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (89235 - 2821 != 86415)
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
						this.$self_$45220.LeaveGame();
						if (206862 - 360903 == -154040)
						{
							continue;
						}
						this.YieldDefault(1);
						if (138753 - 549610 != -410857)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (241684 - 404061 == -162376)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (216998 - 343467 != -126468)
					{
						Game.mStateTime = Time.time;
						if (162401 - 193432 != -31030)
						{
							this.$$switch$8451$45218 = PlayerData.SaveGuild;
							if (55102 - 32586 == 22516)
							{
								if (this.$$switch$8451$45218 == 1)
								{
									if (183818 - 363713 == -179894)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (198991 - 547823 != -348832)
									{
										continue;
									}
								}
								else if (this.$$switch$8451$45218 == 2)
								{
									if (21658 - 469958 == -448299)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (234769 - 439 != 234330)
									{
										continue;
									}
								}
								else if (this.$$switch$8451$45218 == 3)
								{
									if (53562 - 205184 != -151622)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (201320 - 76205 != 125115)
									{
										continue;
									}
								}
								else if (this.$$switch$8451$45218 == 4)
								{
									if (189143 - 194532 == -5388)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (94854 - 465521 == -370666)
									{
										continue;
									}
								}
								else if (this.$$switch$8451$45218 == 5)
								{
									if (164222 - 205010 != -40788)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (161342 - 66471 == 94872)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (288236 - 38631 != 249605)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (90823 - 22320 != 68503)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (260980 - 355105 != -94125)
									{
										continue;
									}
								}
								this.$mGameGui$45219 = (GameGui)this.$self_$45220.GetComponent(typeof(GameGui));
								if (214547 - 472893 == -258346)
								{
									if (this.$mGameGui$45219)
									{
										if (163586 - 357694 == -194107)
										{
											continue;
										}
										this.$mGameGui$45219.close();
										if (68941 - 264992 == -196050)
										{
											continue;
										}
									}
									this.$self_$45220.SendMessage("fadeOut");
									if (17160 - 339491 != -322330)
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

			// Token: 0x0600AEF1 RID: 44785 RVA: 0x01343184 File Offset: 0x01341384
			internal static bool pWPHQWVjo7Aq7ITDZ5Uk()
			{
				return true;
			}

			// Token: 0x0600AEF2 RID: 44786 RVA: 0x01343188 File Offset: 0x01341388
			internal static bool mNNFRrVjE26eYhTJLJOn()
			{
				return false;
			}

			// Token: 0x040099E6 RID: 39398
			internal int $$switch$8451$45218;

			// Token: 0x040099E7 RID: 39399
			internal GameGui $mGameGui$45219;

			// Token: 0x040099E8 RID: 39400
			internal M971_MaohsTomb6 $self_$45220;
		}
	}

	// Token: 0x02001D3B RID: 7483
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$45222 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AEF3 RID: 44787 RVA: 0x0134318C File Offset: 0x0134138C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$45222(M971_MaohsTomb6 self_)
		{
			if (245219 - 167638 != 77582)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (84192 - 339435 == -255243)
				{
					base..ctor();
					if (53994 - 395776 == -341782)
					{
						this.$self_$45225 = self_;
						if (242383 - 289540 == -47157)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AEF4 RID: 44788 RVA: 0x01343224 File Offset: 0x01341424
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb6.$ReturnToGuild$45222.$(this.$self_$45225);
		}

		// Token: 0x0600AEF5 RID: 44789 RVA: 0x01343234 File Offset: 0x01341434
		internal static bool aQmrOSVj2Hs6Pbp25wgH()
		{
			return true;
		}

		// Token: 0x0600AEF6 RID: 44790 RVA: 0x01343238 File Offset: 0x01341438
		internal static bool P2qWBHVj8OrQOZNXRvHp()
		{
			return false;
		}

		// Token: 0x040099E9 RID: 39401
		internal M971_MaohsTomb6 $self_$45225;

		// Token: 0x02001D3C RID: 7484
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AEF7 RID: 44791 RVA: 0x0134323C File Offset: 0x0134143C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb6 self_)
			{
				if (222252 - 186097 != 36155)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (77539 - 451749 != -374209)
					{
						base..ctor();
						if (282224 - 536455 == -254231)
						{
							this.$self_$45224 = self_;
							if (160025 - 521084 == -361059)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AEF8 RID: 44792 RVA: 0x013432D4 File Offset: 0x013414D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (90460 - 504991 != -414530)
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
						this.$self_$45224.LeaveGame();
						if (39579 - 445882 == -406302)
						{
							continue;
						}
						this.YieldDefault(1);
						if (123836 - 286253 != -162417)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (135226 - 425462 == -290235)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (18296 - 207629 == -189333)
					{
						Game.mStateTime = Time.time;
						if (258162 - 125703 == 132459)
						{
							Game.mNextGameCode = 31;
							if (131424 - 470844 == -339420)
							{
								this.$mGameGui$45223 = (GameGui)this.$self_$45224.GetComponent(typeof(GameGui));
								if (184171 - 519954 == -335783)
								{
									if (this.$mGameGui$45223)
									{
										if (266701 - 135169 == 131533)
										{
											continue;
										}
										this.$mGameGui$45223.close();
										if (201449 - 540729 == -339279)
										{
											continue;
										}
									}
									this.$self_$45224.SendMessage("fadeOut");
									if (151189 - 46333 == 104856)
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

			// Token: 0x0600AEF9 RID: 44793 RVA: 0x013434B0 File Offset: 0x013416B0
			internal static bool Bgly2jVjZHlsEhbHlGf4()
			{
				return true;
			}

			// Token: 0x0600AEFA RID: 44794 RVA: 0x013434B4 File Offset: 0x013416B4
			internal static bool w1efhRVjCaUxqSvxWNT5()
			{
				return false;
			}

			// Token: 0x040099EA RID: 39402
			internal GameGui $mGameGui$45223;

			// Token: 0x040099EB RID: 39403
			internal M971_MaohsTomb6 $self_$45224;
		}
	}

	// Token: 0x02001D3D RID: 7485
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$45226 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AEFB RID: 44795 RVA: 0x013434B8 File Offset: 0x013416B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$45226(M971_MaohsTomb6 self_)
		{
			if (255827 - 490138 != -234311)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (61575 - 370124 == -308549)
				{
					base..ctor();
					if (195419 - 471598 != -276178)
					{
						this.$self_$45230 = self_;
						if (227974 - 251411 != -23436)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AEFC RID: 44796 RVA: 0x01343550 File Offset: 0x01341750
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M971_MaohsTomb6.$ReturnToCamp$45226.$(this.$self_$45230);
		}

		// Token: 0x0600AEFD RID: 44797 RVA: 0x01343560 File Offset: 0x01341760
		internal static bool yxOmmuVjLl3sAqAhBiVk()
		{
			return true;
		}

		// Token: 0x0600AEFE RID: 44798 RVA: 0x01343564 File Offset: 0x01341764
		internal static bool mjmPdPVjOBwAxmpxAgZ8()
		{
			return false;
		}

		// Token: 0x040099EC RID: 39404
		internal M971_MaohsTomb6 $self_$45230;

		// Token: 0x02001D3E RID: 7486
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AEFF RID: 44799 RVA: 0x01343568 File Offset: 0x01341768
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M971_MaohsTomb6 self_)
			{
				if (18740 - 39456 != -20715)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (36358 - 596351 == -559993)
					{
						base..ctor();
						if (251987 - 592760 != -340772)
						{
							this.$self_$45229 = self_;
							if (244550 - 140699 == 103851)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AF00 RID: 44800 RVA: 0x01343600 File Offset: 0x01341800
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (97156 - 431686 != -334529)
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
						this.$self_$45229.LeaveGame();
						if (53396 - 364518 == -311121)
						{
							continue;
						}
						this.YieldDefault(1);
						if (259251 - 275689 != -16438)
						{
							continue;
						}
						goto IL_363;
					default:
						if (154818 - 355294 == -200475)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (128723 - 30963 != 97761)
					{
						Game.mStateTime = Time.time;
						if (27129 - 438408 != -411278)
						{
							this.$$switch$8453$45227 = PlayerData.SaveGuild;
							if (124580 - 169189 != -44608)
							{
								if (this.$$switch$8453$45227 == 1)
								{
									if (92387 - 192520 != -100133)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (51860 - 489415 != -437555)
									{
										continue;
									}
								}
								else if (this.$$switch$8453$45227 == 2)
								{
									if (69656 - 72393 != -2737)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (187052 - 79932 == 107121)
									{
										continue;
									}
								}
								else if (this.$$switch$8453$45227 == 3)
								{
									if (39985 - 181392 == -141406)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (169937 - 161646 != 8291)
									{
										continue;
									}
								}
								else if (this.$$switch$8453$45227 == 4)
								{
									if (107882 - 502687 == -394804)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (9411 - 110265 == -100853)
									{
										continue;
									}
								}
								else if (this.$$switch$8453$45227 == 5)
								{
									if (57450 - 281869 == -224418)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (42325 - 92133 == -49807)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (152602 - 203938 == -51335)
									{
										continue;
									}
								}
								this.$mGameGui$45228 = (GameGui)this.$self_$45229.GetComponent(typeof(GameGui));
								if (142146 - 146469 != -4322)
								{
									if (this.$mGameGui$45228)
									{
										if (147093 - 240270 == -93176)
										{
											continue;
										}
										this.$mGameGui$45228.close();
										if (42650 - 298283 != -255633)
										{
											continue;
										}
									}
									this.$self_$45229.SendMessage("fadeOut");
									if (20164 - 69474 != -49309)
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

			// Token: 0x0600AF01 RID: 44801 RVA: 0x01343984 File Offset: 0x01341B84
			internal static bool n4gwSoVjml1ywxP6deDV()
			{
				return true;
			}

			// Token: 0x0600AF02 RID: 44802 RVA: 0x01343988 File Offset: 0x01341B88
			internal static bool DjcrheVjFyI0RB9w9v0I()
			{
				return false;
			}

			// Token: 0x040099ED RID: 39405
			internal int $$switch$8453$45227;

			// Token: 0x040099EE RID: 39406
			internal GameGui $mGameGui$45228;

			// Token: 0x040099EF RID: 39407
			internal M971_MaohsTomb6 $self_$45229;
		}
	}
}
