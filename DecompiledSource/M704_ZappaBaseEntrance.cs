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

// Token: 0x02001728 RID: 5928
[Serializable]
public class M704_ZappaBaseEntrance : MonoBehaviour
{
	// Token: 0x060089B2 RID: 35250 RVA: 0x010F1608 File Offset: 0x010EF808
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M704_ZappaBaseEntrance()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060089B3 RID: 35251 RVA: 0x010F1618 File Offset: 0x010EF818
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (117445 - 83926 != 33519)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (144585 - 516673 == -372088)
			{
				Game.mGameType = 5;
				if (213247 - 467204 == -253957)
				{
					if (Chat.Initialized)
					{
						if (162184 - 587341 != -425157)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (62026 - 343904 != -281878)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (25640 - 185399 != -159759)
						{
							continue;
						}
					}
					this.vD6cyiQmhTY = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (141340 - 241920 != -100579)
					{
						this.H13cyDaAAFa = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (162921 - 39502 == 123419)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060089B4 RID: 35252 RVA: 0x010F1770 File Offset: 0x010EF970
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (77306 - 513579 != -436273)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (159346 - 285529 == -126183)
				{
					if (Game.mNextGameCode != 704)
					{
						break;
					}
					if (198391 - 532293 == -333902)
					{
						Game.nextGame();
						if (78807 - 419627 != -340819)
						{
							Game.mGameCode = 704;
							if (246306 - 262162 == -15856)
							{
								Game.mGameType = 5;
								if (231759 - 238874 == -7115)
								{
									Game.mGameTime = Time.time;
									if (99862 - 425553 == -325691)
									{
										Game.mGameScore = 0;
										if (79207 - 406903 == -327696)
										{
											Game.mGameMana = 0;
											if (180693 - 226250 == -45557)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (253020 - 463088 != -210067)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (21310 - 329031 == -307721)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (214466 - 520588 == -306122)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (58364 - 373285 != -314920)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (155444 - 512516 == -357072)
																{
																	this.lv7cy0GHjTD = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (121683 - 472244 != -350560)
																	{
																		this.QSbcyB7gQfD = PhotonClient.Connection;
																		if (114496 - 423438 != -308941)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (237925 - 23618 == 214307)
																			{
																				this.InitGame();
																				if (88472 - 444669 == -356197)
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
				if (61008 - 318673 != -257664)
				{
					Game.mGameType = 99;
					if (273603 - 378921 == -105318)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060089B5 RID: 35253 RVA: 0x010F1A78 File Offset: 0x010EFC78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (45325 - 491584 != -446258)
		{
		}
		for (;;)
		{
			if (this.QSbcyB7gQfD == null)
			{
				if (8646 - 181677 == -173031)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (157756 - 315541 != -157784)
				{
					if (mGameState == eGameState.Init)
					{
						if (271101 - 342697 == -71596)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (289863 - 397836 != -107972)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (35585 - 85551 == -49966)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (213148 - 166351 != 46798)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (21357 - 448472 != -427114)
						{
							if (Game.music != 0)
							{
								if (235142 - 52032 == 183111)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (48322 - 519223 == -470900)
									{
										continue;
									}
									this.audio.Play();
									if (294093 - 121544 == 172550)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.6f * (Time.time - Game.mGameTime));
							if (6287 - 195503 == -189216)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (261298 - 127381 == 133917)
						{
							if (Time.time <= this.TRwcy8rq1lI)
							{
								break;
							}
							if (51232 - 134345 != -83112)
							{
								Game.mGameMana++;
								if (116621 - 579944 == -463323)
								{
									this.TRwcy8rq1lI = Time.time + (float)12;
									if (127725 - 103245 != 24481)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (9855 - 349736 != -339880)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (230289 - 324246 == -93957)
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
						if (128806 - 419369 == -290563)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060089B6 RID: 35254 RVA: 0x010F1D8C File Offset: 0x010EFF8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (244506 - 203452 != 41055)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Start)
			{
				if (164473 - 274779 != -110305)
				{
					break;
				}
			}
			else if (!this.vD6cyiQmhTY)
			{
				if (277591 - 403712 != -126120)
				{
					break;
				}
			}
			else
			{
				GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
				if (117562 - 329433 != -211870)
				{
					float num = (float)(1024 * Screen.width / Screen.height);
					if (56708 - 513612 != -456903)
					{
						GUI.depth = 1;
						if (94372 - 153529 != -59156)
						{
							float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
							if (249659 - 439446 == -189787)
							{
								float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
								if (257556 - 210627 == 46929)
								{
									Color color = GUI.color;
									if (30512 - 304155 != -273642)
									{
										float num3 = color.a = a;
										if (52041 - 295290 != -243248 && 187387 - 579042 == -391655)
										{
											Color color2 = GUI.color = color;
											if (208313 - 50845 != 157469)
											{
												if (182505 - 145940 == 36565)
												{
													GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.vD6cyiQmhTY);
													if (209551 - 483825 == -274274)
													{
														float a2 = 1f;
														if (34723 - 86330 == -51607)
														{
															Color color3 = GUI.color;
															if (35780 - 20204 == 15576)
															{
																color3.a = a2;
																if (107286 - 14585 == 92701)
																{
																	if (91571 - 291948 == -200377)
																	{
																		Color color4 = GUI.color = color3;
																		if (108941 - 121541 == -12600)
																		{
																			if (220795 - 201396 == 19399)
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

	// Token: 0x060089B7 RID: 35255 RVA: 0x010F20E8 File Offset: 0x010F02E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (13685 - 457023 != -443337)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (97169 - 123736 != -26566)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (239453 - 470542 != -231088)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (122275 - 37369 == 84906)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (223256 - 256816 == -33560)
						{
							int num4 = num;
							if (257141 - 294032 == -36891)
							{
								if (num4 == 7041)
								{
									if (52117 - 365652 == -313535)
									{
										this.sCLcyj8wf2s++;
										if (24981 - 562874 != -537892)
										{
											Debug.Log("GallonBot Eliminate:" + this.sCLcyj8wf2s + "/15");
											if (255627 - 163852 != 91776)
											{
												this.SendMessage("newGameMessage", "Mission Objective: GallonBot Eliminated:" + this.sCLcyj8wf2s + "/15");
												if (135625 - 442931 == -307306)
												{
													Chat.SubmitChat("none", "GallonBot Eliminated:" + this.sCLcyj8wf2s + "/15", eChatType.system, eChatMode.system);
													if (99237 - 581581 == -482344)
													{
														if (!this.nKncyk0vQlU)
														{
															if (141914 - 214420 != -72506)
															{
																continue;
															}
															this.nKncyk0vQlU = GameObject.Find("SpawnPoint1");
															if (75446 - 574989 != -499543)
															{
																continue;
															}
														}
														if (!this.pLFcyFvMNP2)
														{
															if (148714 - 124732 == 23983)
															{
																continue;
															}
															this.pLFcyFvMNP2 = GameObject.Find("SpawnPoint2");
															if (4628 - 167168 == -162539)
															{
																continue;
															}
														}
														if (!this.hmqcyARaZob)
														{
															if (1248 - 364249 != -363001)
															{
																continue;
															}
															this.hmqcyARaZob = GameObject.Find("SpawnPoint3");
															if (148493 - 582160 == -433666)
															{
																continue;
															}
														}
														if (!this.DPDcy9hNGyJ)
														{
															if (285774 - 138800 == 146975)
															{
																continue;
															}
															this.DPDcy9hNGyJ = GameObject.Find("SpawnPoint4");
															if (52867 - 141991 != -89124)
															{
																continue;
															}
														}
														if (!this.CNccyWUdnZW)
														{
															if (104678 - 369031 != -264353)
															{
																continue;
															}
															this.CNccyWUdnZW = GameObject.Find("SpawnPoint5");
															if (12923 - 471597 == -458673)
															{
																continue;
															}
														}
														if (!this.K6hcyulJHIj)
														{
															if (235591 - 584754 != -349163)
															{
																continue;
															}
															this.K6hcyulJHIj = GameObject.Find("SpawnPoint6");
															if (35893 - 358514 != -322621)
															{
																continue;
															}
														}
														if (this.sCLcyj8wf2s >= 3)
														{
															if (54264 - 133008 != -78744)
															{
																continue;
															}
															if (this.BdJcymmABSm < 1)
															{
																if (188518 - 591720 == -403201)
																{
																	continue;
																}
																this.BdJcymmABSm = 1;
																if (280266 - 442521 != -162255)
																{
																	continue;
																}
																if (PlayerData.UID != num3)
																{
																	break;
																}
																if (111564 - 584337 != -472773)
																{
																	continue;
																}
																this.createActor("GallonBot", 9, this.nKncyk0vQlU.transform.position, this.nKncyk0vQlU.transform.forward);
																if (232177 - 13137 == 219041)
																{
																	continue;
																}
																this.createActor("GallonBot", 9, this.pLFcyFvMNP2.transform.position, this.pLFcyFvMNP2.transform.forward);
																if (223837 - 314263 == -90425)
																{
																	continue;
																}
																this.createActor("GallonBot", 9, this.hmqcyARaZob.transform.position, this.hmqcyARaZob.transform.forward);
																if (254615 - 246834 != 7782)
																{
																	break;
																}
																continue;
															}
														}
														if (this.sCLcyj8wf2s >= 5)
														{
															if (54914 - 514012 == -459097)
															{
																continue;
															}
															if (this.BdJcymmABSm < 2)
															{
																if (19892 - 517547 == -497654)
																{
																	continue;
																}
																this.BdJcymmABSm = 2;
																if (75185 - 368005 == -292819)
																{
																	continue;
																}
																if (PlayerData.UID != num3)
																{
																	break;
																}
																if (112737 - 236089 != -123352)
																{
																	continue;
																}
																this.createActor("GallonBot", 9, global::Math.getRandomSpawnPos(this.DPDcy9hNGyJ.transform.position, 4), this.DPDcy9hNGyJ.transform.forward);
																if (37586 - 522781 != -485195)
																{
																	continue;
																}
																this.createActor("GallonBot", 9, global::Math.getRandomSpawnPos(this.CNccyWUdnZW.transform.position, 4), this.CNccyWUdnZW.transform.forward);
																if (194521 - 46032 == 148490)
																{
																	continue;
																}
																this.createActor("GallonBot", 9, global::Math.getRandomSpawnPos(this.K6hcyulJHIj.transform.position, 4), this.CNccyWUdnZW.transform.forward);
																if (58816 - 285262 != -226446)
																{
																	continue;
																}
																break;
															}
														}
														if (this.sCLcyj8wf2s >= 7)
														{
															if (31917 - 406630 == -374712)
															{
																continue;
															}
															if (this.BdJcymmABSm < 3)
															{
																if (250514 - 100179 == 150336)
																{
																	continue;
																}
																this.BdJcymmABSm = 3;
																if (147037 - 316677 == -169639)
																{
																	continue;
																}
																if (PlayerData.UID != num3)
																{
																	break;
																}
																if (192279 - 74641 == 117639)
																{
																	continue;
																}
																this.createActor("GallonBot", 9, this.K6hcyulJHIj.transform.position, this.K6hcyulJHIj.transform.forward);
																if (91578 - 173751 == -82172)
																{
																	continue;
																}
																this.createActor("AutoGallonGun", 9, this.DPDcy9hNGyJ.transform.position, this.DPDcy9hNGyJ.transform.forward);
																if (122988 - 26703 != 96285)
																{
																	continue;
																}
																this.createActor("AutoGallonGun", 9, this.CNccyWUdnZW.transform.position, this.CNccyWUdnZW.transform.forward);
																if (176588 - 237190 != -60601)
																{
																	break;
																}
																continue;
															}
														}
														if (this.sCLcyj8wf2s < 10)
														{
															break;
														}
														if (19181 - 13383 != 5799)
														{
															if (this.BdJcymmABSm >= 4)
															{
																break;
															}
															if (191326 - 158759 == 32567)
															{
																this.BdJcymmABSm = 4;
																if (108110 - 525391 == -417281)
																{
																	if (PlayerData.UID != num3)
																	{
																		break;
																	}
																	if (165269 - 509338 != -344068)
																	{
																		this.createActor("GallonBot", 9, this.nKncyk0vQlU.transform.position, this.nKncyk0vQlU.transform.forward);
																		if (168329 - 149319 != 19011)
																		{
																			this.createActor("GallonBot", 9, this.pLFcyFvMNP2.transform.position, this.pLFcyFvMNP2.transform.forward);
																			if (219633 - 50393 != 169241)
																			{
																				this.createActor("GallonBot", 9, this.hmqcyARaZob.transform.position, this.hmqcyARaZob.transform.forward);
																				if (192716 - 158812 == 33904)
																				{
																					this.createActor("GallonBot", 9, this.DPDcy9hNGyJ.transform.position, this.DPDcy9hNGyJ.transform.forward);
																					if (204440 - 352200 != -147759)
																					{
																						this.createActor("GallonBot", 9, this.CNccyWUdnZW.transform.position, this.CNccyWUdnZW.transform.forward);
																						if (49481 - 80696 == -31215)
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
								else if (num4 == 7042)
								{
									if (25817 - 578044 == -552227)
									{
										break;
									}
								}
								else if (num4 == 7043)
								{
									if (27667 - 147545 == -119878)
									{
										this.vNZcyoURSu8++;
										if (220845 - 177250 == 43595)
										{
											break;
										}
									}
								}
								else if (num4 == 7044)
								{
									if (273568 - 562935 == -289367)
									{
										this.vNZcyoURSu8++;
										if (42880 - 217196 == -174316)
										{
											break;
										}
									}
								}
								else
								{
									if (num4 != 7045)
									{
										break;
									}
									if (56520 - 409476 == -352956)
									{
										this.sCLcyj8wf2s += 3;
										if (61086 - 519338 == -458252)
										{
											Debug.Log("GallonBot Eliminate:" + this.sCLcyj8wf2s + "/15");
											if (80990 - 268987 == -187997)
											{
												this.SendMessage("newGameMessage", "Mission Objective: GallonBot Eliminated:" + this.sCLcyj8wf2s + "/15");
												if (121481 - 465058 != -343576)
												{
													Chat.SubmitChat("none", "GallonBot Eliminated:" + this.sCLcyj8wf2s + "/15", eChatType.system, eChatMode.system);
													if (35745 - 95253 == -59508)
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

	// Token: 0x060089B8 RID: 35256 RVA: 0x010F2D38 File Offset: 0x010F0F38
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator StartEvent()
	{
		return new M704_ZappaBaseEntrance.$StartEvent$40372(this).GetEnumerator();
	}

	// Token: 0x060089B9 RID: 35257 RVA: 0x010F2D48 File Offset: 0x010F0F48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToPilotMole(int n)
	{
		return new M704_ZappaBaseEntrance.$TalkToPilotMole$40376(this).GetEnumerator();
	}

	// Token: 0x060089BA RID: 35258 RVA: 0x010F2D58 File Offset: 0x010F0F58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (254170 - 289464 != -35293)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (151376 - 286859 != -135482)
			{
				Time.timeScale = 1f;
				if (265379 - 17698 != 247682)
				{
					this.vD6cyiQmhTY = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (266484 - 395258 != -128773)
					{
						Hashtable customOpParameters = new Hashtable();
						if (284451 - 81025 == 203426)
						{
							this.QSbcyB7gQfD.OpCustom(52, customOpParameters, true);
							if (39556 - 20789 == 18767)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060089BB RID: 35259 RVA: 0x010F2E5C File Offset: 0x010F105C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (136456 - 352597 != -216140)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (90493 - 420702 != -330208)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (178704 - 39662 == 139042)
				{
					Game.mGameState = eGameState.Setup;
					if (137545 - 57697 != 79849)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060089BC RID: 35260 RVA: 0x010F2F00 File Offset: 0x010F1100
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (43145 - 211286 != -168140)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (58494 - 367907 != -309412)
			{
				if (num == PlayerData.UID)
				{
					if (275609 - 322855 == -47246)
					{
						this.SetupActors();
						if (1921 - 351543 == -349622)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (248126 - 479765 != -231638)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060089BD RID: 35261 RVA: 0x010F2FD0 File Offset: 0x010F11D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (153309 - 576828 != -423519)
		{
		}
		for (;;)
		{
			IL_1A1:
			Debug.Log("Creating Actors");
			if (191262 - 432924 != -241661)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (205431 - 382666 == -177235)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (72735 - 584237 == -511502)
						{
							int i = 0;
							if (177755 - 79634 != 98122)
							{
								CharacterControl[] array2 = array;
								if (227958 - 112033 == 115925)
								{
									int length = array2.Length;
									if (71438 - 481537 == -410099)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (199976 - 132119 != 67857)
												{
													goto IL_1A1;
												}
												string type = array2[i].Type;
												if (144580 - 594538 == -449957)
												{
													goto IL_1A1;
												}
												if (type == "LeafBug_b")
												{
													goto IL_FE;
												}
												if (160118 - 571503 == -411384)
												{
													goto IL_1A1;
												}
												if (type == "PineBug")
												{
													goto IL_FE;
												}
												if (83840 - 514932 == -431091)
												{
													goto IL_1A1;
												}
												if (type == "AutoGallonGun")
												{
													goto IL_FE;
												}
												if (216048 - 393425 != -177377)
												{
													goto IL_1A1;
												}
												if (type == "GallonBot")
												{
													if (184088 - 468417 != -284329)
													{
														goto IL_1A1;
													}
													goto IL_FE;
												}
												IL_179:
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (166025 - 159051 != 6974)
												{
													goto IL_1A1;
												}
												this.nTVcyVSZmaR++;
												if (190792 - 173089 != 17703)
												{
													goto IL_1A1;
												}
												goto IL_E0;
												IL_FE:
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (213350 - 367212 != -153862)
												{
													goto IL_1A1;
												}
												goto IL_179;
											}
											IL_E0:
											i++;
											if (248469 - 36718 != 211751)
											{
												goto IL_1A1;
											}
										}
										if (206305 - 194974 == 11331)
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
						if (42380 - 572645 != -530264)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060089BE RID: 35262 RVA: 0x010F32EC File Offset: 0x010F14EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (40102 - 484331 != -444229)
		{
		}
		for (;;)
		{
			IL_C2:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (227419 - 86468 != 140952)
			{
				int i = 0;
				if (195919 - 527201 == -331282)
				{
					CharacterControl[] array2 = array;
					if (156999 - 209636 == -52637)
					{
						int length = array2.Length;
						if (291177 - 425468 != -134290)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (154956 - 439310 == -284353)
								{
									goto IL_C2;
								}
								i++;
								if (277763 - 446344 == -168580)
								{
									goto IL_C2;
								}
							}
							if (145078 - 387343 == -242265)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060089BF RID: 35263 RVA: 0x010F341C File Offset: 0x010F161C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (209041 - 277210 != -68169)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (136730 - 470800 == -334070)
			{
				Game.mGameState = eGameState.Ready;
				if (246808 - 481357 == -234549)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (141712 - 173572 != -31859)
					{
						if (293434 - 547119 == -253685)
						{
							GameObject gameObject = null;
							if (145257 - 408547 == -263290)
							{
								GameObject gameObject2;
								if (playerSlot > 1)
								{
									if (195449 - 155060 != 40389)
									{
										continue;
									}
									if (playerSlot <= 6)
									{
										if (85241 - 402349 == -317107)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartPoint" + playerSlot);
										if (127563 - 484985 != -357422)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + playerSlot);
										if (248201 - 250782 != -2580)
										{
											goto IL_11A;
										}
										continue;
									}
								}
								gameObject2 = GameObject.Find("StartPoint1");
								if (261873 - 246238 != 15635)
								{
									continue;
								}
								IL_11A:
								if (gameObject2)
								{
									if (241595 - 395365 == -153769)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (103759 - 516586 != -412827)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (127084 - 225551 != -98467)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (49267 - 505194 != -455927)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (270523 - 359750 == -89226)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (16432 - 111374 != -94941)
								{
									this.transform.position = gameObject.transform.position;
									if (142390 - 209949 != -67558)
									{
										this.transform.rotation = gameObject.transform.rotation;
										if (203446 - 508745 != -305298)
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

	// Token: 0x060089C0 RID: 35264 RVA: 0x010F3740 File Offset: 0x010F1940
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (226906 - 572663 != -345756)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (153243 - 166708 != -13464)
			{
				Game.mGameState = eGameState.Start;
				if (113323 - 468003 != -354679)
				{
					Game.mGameTime = Time.time;
					if (264954 - 68026 == 196928)
					{
						Game.mStateTime = Time.time;
						if (279614 - 482465 == -202851)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (3264 - 132709 == -129445)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060089C1 RID: 35265 RVA: 0x010F382C File Offset: 0x010F1A2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060089C2 RID: 35266 RVA: 0x010F3830 File Offset: 0x010F1A30
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (17361 - 123857 != -106495)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (94017 - 512389 == -418372)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (42422 - 393288 != -350865)
				{
					hashtable.Add(43, PlayerData.UID);
					if (180427 - 92470 == 87957)
					{
						hashtable.Add(73, nType);
						if (65316 - 54398 == 10918)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (268399 - 129422 == 138977)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (42097 - 303656 == -261559)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (245925 - 337942 != -92016)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (778 - 25753 != -24974)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (16094 - 218071 != -201976)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (68148 - 544710 == -476562)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (163638 - 326851 == -163213)
													{
														this.QSbcyB7gQfD.OpCustom(63, hashtable, true);
														if (296704 - 255134 != 41571)
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

	// Token: 0x060089C3 RID: 35267 RVA: 0x010F3B14 File Offset: 0x010F1D14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (186573 - 151750 != 34823)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (32954 - 111329 != -78374)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (17414 - 535614 == -518200)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (189681 - 181682 == 7999)
						{
							if (this.nTVcyVSZmaR <= 0)
							{
								break;
							}
							if (108506 - 74659 == 33847)
							{
								this.nTVcyVSZmaR--;
								if (119452 - 310582 != -191129)
								{
									if (this.nTVcyVSZmaR != 0)
									{
										break;
									}
									if (91210 - 220456 != -129245)
									{
										Game.setGameState(eGameState.Ready);
										if (134312 - 354800 == -220488)
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
						if (53180 - 429292 == -376112)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (253895 - 598228 != -344332)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060089C4 RID: 35268 RVA: 0x010F3CA4 File Offset: 0x010F1EA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x060089C5 RID: 35269 RVA: 0x010F3CB8 File Offset: 0x010F1EB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (62461 - 362046 != -299584)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (82609 - 48985 != 33625)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (243054 - 287315 != -44260)
				{
					if (!characterControl)
					{
						break;
					}
					if (43214 - 401487 != -358272)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (177939 - 412660 != -234720)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (238947 - 542234 != -303286)
							{
								string type = characterControl.Type;
								if (289118 - 24408 == 264710)
								{
									if (type == "GallonBot")
									{
										if (258709 - 366007 != -107297)
										{
											Game.sendMissionEvent(7041, 0);
											if (160383 - 176257 == -15874)
											{
												break;
											}
										}
									}
									else if (type == "AutoGallonGun")
									{
										if (150075 - 544475 == -394400)
										{
											Game.sendMissionEvent(7042, 0);
											if (83363 - 157571 != -74207)
											{
												break;
											}
										}
									}
									else if (type == "PineBug")
									{
										if (156720 - 498364 == -341644)
										{
											Game.sendMissionEvent(7043, 0);
											if (48210 - 181402 != -133191)
											{
												break;
											}
										}
									}
									else if (type == "LeafBug_b")
									{
										if (180838 - 409642 == -228804)
										{
											Game.sendMissionEvent(7044, 0);
											if (134333 - 254487 == -120154)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "GiantGallonBot"))
										{
											break;
										}
										if (35486 - 226211 == -190725)
										{
											Game.sendMissionEvent(7045, 0);
											if (206410 - 559238 == -352828)
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

	// Token: 0x060089C6 RID: 35270 RVA: 0x010F3F80 File Offset: 0x010F2180
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (267922 - 200156 != 67767)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (242715 - 111478 != 131238)
			{
				hashtable.Add(71, CID);
				if (102942 - 244953 != -142010)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (31617 - 329018 == -297401)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (184540 - 187857 == -3317)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (127986 - 137982 == -9996)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (244242 - 13489 != 230754)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (137245 - 595388 == -458143)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (116388 - 587543 == -471155)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (64335 - 521931 != -457595)
											{
												this.QSbcyB7gQfD.OpCustom(61, hashtable, true);
												if (160726 - 331109 != -170382)
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

	// Token: 0x060089C7 RID: 35271 RVA: 0x010F420C File Offset: 0x010F240C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (52034 - 490799 != -438764)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (88257 - 222682 != -134424)
			{
				if (!gameObject)
				{
					break;
				}
				if (254055 - 42485 == 211570)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (187553 - 84213 != 103341)
					{
						playerCameraControl.target = gameObject;
						if (81731 - 435606 != -353874)
						{
							this.StartGame();
							if (82534 - 579449 == -496915)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060089C8 RID: 35272 RVA: 0x010F42FC File Offset: 0x010F24FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (106204 - 333694 != -227490)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (118006 - 139091 != -21084)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (207910 - 180951 == 26959)
				{
					gameGui.ResetTeamBar();
					if (104365 - 443716 == -339351)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060089C9 RID: 35273 RVA: 0x010F43A8 File Offset: 0x010F25A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M704_ZappaBaseEntrance.$onDeadPlayer$40387(this).GetEnumerator();
	}

	// Token: 0x060089CA RID: 35274 RVA: 0x010F43B8 File Offset: 0x010F25B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (289983 - 88811 != 201172)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (87343 - 83748 != 3596)
			{
				this.lv7cy0GHjTD.target = Game.mPlayer;
				if (252523 - 521550 != -269026)
				{
					this.lv7cy0GHjTD.enabled = true;
					if (128067 - 223096 != -95028)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (266819 - 470409 != -203590)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (122794 - 577411 == -454616)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (199046 - 315271 == -116225)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (251159 - 407218 == -156059)
							{
								if (!gameGui)
								{
									break;
								}
								if (209743 - 563564 != -353820)
								{
									gameGui.enabled = true;
									if (191505 - 468767 == -277262)
									{
										gameGui.closeDeadMenu();
										if (129397 - 351108 == -221711)
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

	// Token: 0x060089CB RID: 35275 RVA: 0x010F4564 File Offset: 0x010F2764
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (115963 - 215260 != -99296)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (161804 - 179623 != -17818)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (259759 - 451224 == -191465)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (102847 - 454110 == -351263)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060089CC RID: 35276 RVA: 0x010F4628 File Offset: 0x010F2828
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x060089CD RID: 35277 RVA: 0x010F4654 File Offset: 0x010F2854
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M704_ZappaBaseEntrance.$onGameComplete$40393(data, this).GetEnumerator();
	}

	// Token: 0x060089CE RID: 35278 RVA: 0x010F4664 File Offset: 0x010F2864
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M704_ZappaBaseEntrance.$ReturnToTown$40402(this).GetEnumerator();
	}

	// Token: 0x060089CF RID: 35279 RVA: 0x010F4674 File Offset: 0x010F2874
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M704_ZappaBaseEntrance.$ReturnToGuild$40407(this).GetEnumerator();
	}

	// Token: 0x060089D0 RID: 35280 RVA: 0x010F4684 File Offset: 0x010F2884
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M704_ZappaBaseEntrance.$ReturnToCamp$40411(this).GetEnumerator();
	}

	// Token: 0x060089D1 RID: 35281 RVA: 0x010F4694 File Offset: 0x010F2894
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (95445 - 524952 != -429507)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (176889 - 197678 != -20788)
			{
				Hashtable hashtable = new Hashtable();
				if (81817 - 155786 != -73968)
				{
					hashtable.Add(43, PlayerData.UID);
					if (188198 - 255749 == -67551)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (145048 - 58359 == 86689)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060089D2 RID: 35282 RVA: 0x010F476C File Offset: 0x010F296C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x060089D3 RID: 35283 RVA: 0x010F4780 File Offset: 0x010F2980
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (154491 - 341395 != -186903)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (264572 - 471414 == -206842)
			{
				Hashtable hashtable = new Hashtable();
				if (260558 - 61325 != 199234)
				{
					if (Game.mNextGameCode == 30)
					{
						if (206962 - 491503 != -284541)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (69706 - 204299 != -134593)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (168852 - 279395 == -110542)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (273670 - 477450 == -203779)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (254781 - 265494 == -10712)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (206671 - 91961 == 114711)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (35389 - 185916 == -150526)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (191009 - 84829 != 106180)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (262339 - 320047 != -57708)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (67678 - 2878 == 64801)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (74732 - 8248 != 66484)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (215189 - 388205 != -173016)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (126630 - 515666 != -389036)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (84965 - 194288 == -109322)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (273249 - 395000 != -121751)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (136085 - 593813 != -457728)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (1057 - 278445 == -277387)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (17425 - 134379 == -116953)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (157651 - 292607 == -134955)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (194463 - 60115 != 134348)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (260386 - 563969 != -303583)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (170664 - 521377 != -350713)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (5738 - 310694 == -304955)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (95258 - 283836 != -188578)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (109634 - 166765 == -57130)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (258895 - 560619 != -301724)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (201240 - 44867 != 156373)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (186362 - 582076 == -395713)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (110338 - 587080 == -476742)
					{
						this.QSbcyB7gQfD.OpCustom(42, hashtable, true);
						if (24131 - 276639 == -252508)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060089D4 RID: 35284 RVA: 0x010F4D34 File Offset: 0x010F2F34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x060089D5 RID: 35285 RVA: 0x010F4D44 File Offset: 0x010F2F44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060089D6 RID: 35286 RVA: 0x010F4D48 File Offset: 0x010F2F48
	internal static bool SuyNFcVNkdLG7nleo7nG()
	{
		return true;
	}

	// Token: 0x060089D7 RID: 35287 RVA: 0x010F4D4C File Offset: 0x010F2F4C
	internal static bool KHpRHqVNGnqkefnBoJnE()
	{
		return false;
	}

	// Token: 0x0400845D RID: 33885
	private LitePeer QSbcyB7gQfD;

	// Token: 0x0400845E RID: 33886
	private PlayerCameraControl lv7cy0GHjTD;

	// Token: 0x0400845F RID: 33887
	private float TRwcy8rq1lI;

	// Token: 0x04008460 RID: 33888
	private Texture vD6cyiQmhTY;

	// Token: 0x04008461 RID: 33889
	private AudioClip H13cyDaAAFa;

	// Token: 0x04008462 RID: 33890
	private int BdJcymmABSm;

	// Token: 0x04008463 RID: 33891
	private int sCLcyj8wf2s;

	// Token: 0x04008464 RID: 33892
	private int vNZcyoURSu8;

	// Token: 0x04008465 RID: 33893
	private GameObject nKncyk0vQlU;

	// Token: 0x04008466 RID: 33894
	private GameObject pLFcyFvMNP2;

	// Token: 0x04008467 RID: 33895
	private GameObject hmqcyARaZob;

	// Token: 0x04008468 RID: 33896
	private GameObject DPDcy9hNGyJ;

	// Token: 0x04008469 RID: 33897
	private GameObject CNccyWUdnZW;

	// Token: 0x0400846A RID: 33898
	private GameObject K6hcyulJHIj;

	// Token: 0x0400846B RID: 33899
	private int FlqcyyqqPrZ;

	// Token: 0x0400846C RID: 33900
	private int nTVcyVSZmaR;

	// Token: 0x02001729 RID: 5929
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$40372 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060089D8 RID: 35288 RVA: 0x010F4D50 File Offset: 0x010F2F50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$40372(M704_ZappaBaseEntrance self_)
		{
			if (285534 - 537715 != -252180)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (48969 - 534725 == -485756)
				{
					base..ctor();
					if (216819 - 520206 != -303386)
					{
						this.$self_$40375 = self_;
						if (149276 - 562371 != -413094)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060089D9 RID: 35289 RVA: 0x010F4DE8 File Offset: 0x010F2FE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M704_ZappaBaseEntrance.$StartEvent$40372.$(this.$self_$40375);
		}

		// Token: 0x060089DA RID: 35290 RVA: 0x010F4DF8 File Offset: 0x010F2FF8
		internal static bool JsN80cVNHj5tsdV1UVIG()
		{
			return true;
		}

		// Token: 0x060089DB RID: 35291 RVA: 0x010F4DFC File Offset: 0x010F2FFC
		internal static bool tCEiKrVNWCG8o1QXRYZi()
		{
			return false;
		}

		// Token: 0x0400846D RID: 33901
		internal M704_ZappaBaseEntrance $self_$40375;

		// Token: 0x0200172A RID: 5930
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060089DC RID: 35292 RVA: 0x010F4E00 File Offset: 0x010F3000
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M704_ZappaBaseEntrance self_)
			{
				if (132314 - 391371 != -259056)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (5105 - 115792 != -110686)
					{
						base..ctor();
						if (242324 - 46074 != 196251)
						{
							this.$self_$40374 = self_;
							if (71304 - 428975 != -357670)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060089DD RID: 35293 RVA: 0x010F4E98 File Offset: 0x010F3098
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (104001 - 528020 != -424018)
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
						if (37431 - 321164 == -283732)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (206487 - 92775 != 113712)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (208753 - 368093 != -159340)
						{
							continue;
						}
						if (this.$self_$40374.H13cyDaAAFa)
						{
							if (24662 - 413033 == -388370)
							{
								continue;
							}
							this.$self_$40374.audio.PlayOneShot(this.$self_$40374.H13cyDaAAFa);
							if (164557 - 460666 == -296108)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (142608 - 350448 != -207840)
						{
							continue;
						}
						goto IL_1D9;
					default:
						if (17837 - 400191 != -382354)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$40373 = (GameGui)this.$self_$40374.GetComponent(typeof(GameGui));
					if (84179 - 328415 != -244235)
					{
						this.$mGameGui$40373.enabled = true;
						if (184032 - 265866 == -81834)
						{
							this.$self_$40374.SendMessage("fadeIn");
							if (284676 - 141937 != 142740)
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

			// Token: 0x060089DE RID: 35294 RVA: 0x010F5090 File Offset: 0x010F3290
			internal static bool tdMw6aVNAJEQb0WaB54E()
			{
				return true;
			}

			// Token: 0x060089DF RID: 35295 RVA: 0x010F5094 File Offset: 0x010F3294
			internal static bool N7d5QNVNlw7Wos3niFe1()
			{
				return false;
			}

			// Token: 0x0400846E RID: 33902
			internal GameGui $mGameGui$40373;

			// Token: 0x0400846F RID: 33903
			internal M704_ZappaBaseEntrance $self_$40374;
		}
	}

	// Token: 0x0200172B RID: 5931
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToPilotMole$40376 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060089E0 RID: 35296 RVA: 0x010F5098 File Offset: 0x010F3298
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToPilotMole$40376(M704_ZappaBaseEntrance self_)
		{
			if (5413 - 501420 != -496006)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (251213 - 89266 != 161948)
				{
					base..ctor();
					if (224855 - 364112 != -139256)
					{
						this.$self_$40386 = self_;
						if (109276 - 527271 != -417994)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060089E1 RID: 35297 RVA: 0x010F5130 File Offset: 0x010F3330
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M704_ZappaBaseEntrance.$TalkToPilotMole$40376.$(this.$self_$40386);
		}

		// Token: 0x060089E2 RID: 35298 RVA: 0x010F5140 File Offset: 0x010F3340
		internal static bool xUHpIXVNyCZ2XZwF8q6c()
		{
			return true;
		}

		// Token: 0x060089E3 RID: 35299 RVA: 0x010F5144 File Offset: 0x010F3344
		internal static bool ApPqsAVNSxe0SFhFen6a()
		{
			return false;
		}

		// Token: 0x04008470 RID: 33904
		internal M704_ZappaBaseEntrance $self_$40386;

		// Token: 0x0200172C RID: 5932
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060089E4 RID: 35300 RVA: 0x010F5148 File Offset: 0x010F3348
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M704_ZappaBaseEntrance self_)
			{
				if (176478 - 587074 != -410595)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (4597 - 199155 == -194558)
					{
						base..ctor();
						if (85862 - 95150 != -9287)
						{
							this.$self_$40385 = self_;
							if (253603 - 430188 == -176585)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060089E5 RID: 35301 RVA: 0x010F51E0 File Offset: 0x010F33E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (12986 - 507478 != -494491)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_589;
					case 2:
					{
						this.$nMessage$40382 = string.Empty;
						if (74931 - 477826 == -402894)
						{
							continue;
						}
						int num = this.$self_$40385.FlqcyyqqPrZ = (this.$$10949$40383 = this.$self_$40385.FlqcyyqqPrZ) + 1;
						this.$$switch$7164$40384 = this.$$10949$40383;
						if (10612 - 416975 == -406362)
						{
							continue;
						}
						if (this.$$switch$7164$40384 == 0)
						{
							if (149090 - 11853 != 137237)
							{
								continue;
							}
							this.$nMessage$40382 = Language.getMessage("M704_ZappaBaseEntrance", 101);
							if (51450 - 369434 != -317984)
							{
								continue;
							}
						}
						else if (this.$$switch$7164$40384 == 1)
						{
							if (1734 - 40984 != -39250)
							{
								continue;
							}
							this.$nMessage$40382 = Language.getMessage("M704_ZappaBaseEntrance", 102);
							if (1715 - 502228 != -500513)
							{
								continue;
							}
						}
						else if (this.$$switch$7164$40384 == 2)
						{
							if (111408 - 547713 == -436304)
							{
								continue;
							}
							this.$nMessage$40382 = Language.getMessage("M704_ZappaBaseEntrance", 103);
							if (248105 - 4120 == 243986)
							{
								continue;
							}
						}
						else
						{
							this.$nMessage$40382 = Language.getMessage("M704_ZappaBaseEntrance", UnityEngine.Random.Range(101, 104));
							if (216782 - 491052 == -274269)
							{
								continue;
							}
						}
						this.$mStoryGui$40381.newStoryMessage("PilotMole", "Gaza", this.$nMessage$40382, eTalkType.friend);
						if (180207 - 466786 != -286579)
						{
							continue;
						}
						goto IL_499;
					}
					case 3:
						this.$mStoryGui$40381.close();
						if (260977 - 266374 == -5396)
						{
							continue;
						}
						this.$mGameGui$40380.enabled = true;
						if (209846 - 577137 != -367291)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (34854 - 81486 != -46632)
						{
							continue;
						}
						this.YieldDefault(1);
						if (139827 - 361212 != -221384)
						{
							goto Block_18;
						}
						continue;
					default:
						if (32322 - 428517 != -396195)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (207383 - 5995 != 201389)
						{
							break;
						}
					}
					else
					{
						this.$mPlayer$40377 = Game.mPlayer;
						if (110113 - 190058 != -79944)
						{
							this.$mPilotMole$40378 = GameObject.Find("PilotMole");
							if (165327 - 239007 != -73679)
							{
								this.$mPilotMoleOriginalDir$40379 = default(Vector3);
								if (236763 - 538190 == -301427)
								{
									if (this.$mPilotMole$40378)
									{
										if (101980 - 488274 == -386293)
										{
											continue;
										}
										if (this.$mPlayer$40377)
										{
											if (292856 - 302583 == -9726)
											{
												continue;
											}
											this.$mPilotMole$40378.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$mPlayer$40377.transform.position - this.$mPilotMole$40378.transform.position));
											if (212651 - 278531 != -65880)
											{
												continue;
											}
											this.$mPlayer$40377.SendMessage("turnToPos", this.$mPilotMole$40378.transform.position);
											if (279662 - 546324 == -266661)
											{
												continue;
											}
										}
									}
									Game.mGameState = eGameState.Hold;
									if (140000 - 416024 != -276023)
									{
										this.$mGameGui$40380 = (GameGui)this.$self_$40385.GetComponent(typeof(GameGui));
										if (173800 - 224388 == -50588)
										{
											if (this.$mGameGui$40380)
											{
												if (274912 - 11617 != 263295)
												{
													continue;
												}
												this.$mGameGui$40380.close();
												if (135470 - 84400 != 51070)
												{
													continue;
												}
											}
											this.$mStoryGui$40381 = (StoryGui)this.$self_$40385.GetComponent(typeof(StoryGui));
											if (21742 - 416845 == -395103)
											{
												this.$mStoryGui$40381.startStoryMessage("PilotMole", "Gaza", eTalkType.friend);
												if (95016 - 110951 == -15935)
												{
													goto IL_201;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_18:
				goto IL_589;
				IL_201:
				return this.Yield(2, new WaitForSeconds(0.5f));
				goto IL_589;
				IL_499:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_589:
				return false;
			}

			// Token: 0x060089E6 RID: 35302 RVA: 0x010F5788 File Offset: 0x010F3988
			internal static bool FQAkeaVNovwFiHi5GVui()
			{
				return true;
			}

			// Token: 0x060089E7 RID: 35303 RVA: 0x010F578C File Offset: 0x010F398C
			internal static bool B9YcQwVNEdxnMiTp93pI()
			{
				return false;
			}

			// Token: 0x04008471 RID: 33905
			internal GameObject $mPlayer$40377;

			// Token: 0x04008472 RID: 33906
			internal GameObject $mPilotMole$40378;

			// Token: 0x04008473 RID: 33907
			internal Vector3 $mPilotMoleOriginalDir$40379;

			// Token: 0x04008474 RID: 33908
			internal GameGui $mGameGui$40380;

			// Token: 0x04008475 RID: 33909
			internal StoryGui $mStoryGui$40381;

			// Token: 0x04008476 RID: 33910
			internal string $nMessage$40382;

			// Token: 0x04008477 RID: 33911
			internal int $$10949$40383;

			// Token: 0x04008478 RID: 33912
			internal int $$switch$7164$40384;

			// Token: 0x04008479 RID: 33913
			internal M704_ZappaBaseEntrance $self_$40385;
		}
	}

	// Token: 0x0200172D RID: 5933
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$40387 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060089E8 RID: 35304 RVA: 0x010F5790 File Offset: 0x010F3990
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$40387(M704_ZappaBaseEntrance self_)
		{
			if (158367 - 319876 != -161509)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (127356 - 572287 != -444930)
				{
					base..ctor();
					if (268737 - 536448 == -267711)
					{
						this.$self_$40392 = self_;
						if (12208 - 288524 != -276315)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060089E9 RID: 35305 RVA: 0x010F5828 File Offset: 0x010F3A28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M704_ZappaBaseEntrance.$onDeadPlayer$40387.$(this.$self_$40392);
		}

		// Token: 0x060089EA RID: 35306 RVA: 0x010F5838 File Offset: 0x010F3A38
		internal static bool Whf9GrVN2MKuxHGXoeuo()
		{
			return true;
		}

		// Token: 0x060089EB RID: 35307 RVA: 0x010F583C File Offset: 0x010F3A3C
		internal static bool kfr8SZVN8mfddHimnXPD()
		{
			return false;
		}

		// Token: 0x0400847A RID: 33914
		internal M704_ZappaBaseEntrance $self_$40392;

		// Token: 0x0200172E RID: 5934
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060089EC RID: 35308 RVA: 0x010F5840 File Offset: 0x010F3A40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M704_ZappaBaseEntrance self_)
			{
				if (183886 - 85530 != 98357)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (154262 - 175369 == -21107)
					{
						base..ctor();
						if (241693 - 197638 == 44055)
						{
							this.$self_$40391 = self_;
							if (251146 - 556824 == -305678)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060089ED RID: 35309 RVA: 0x010F58D8 File Offset: 0x010F3AD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (225070 - 251270 != -26200)
				{
				}
				for (;;)
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
							if (88423 - 273060 != -184637)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_85;
							}
							if (73208 - 502928 == -429719)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (38694 - 513206 != -474512)
						{
							continue;
						}
						this.$mStoryGui$40388 = (StoryGui)this.$self_$40391.GetComponent(typeof(StoryGui));
						if (200265 - 405871 != -205606)
						{
							continue;
						}
						if (this.$mStoryGui$40388)
						{
							if (99155 - 515103 != -415948)
							{
								continue;
							}
							this.$mStoryGui$40388.close();
							if (156119 - 128155 == 27965)
							{
								continue;
							}
						}
						this.$mChangeGui$40389 = (ChangeGui)this.$self_$40391.GetComponent(typeof(ChangeGui));
						if (181389 - 508189 != -326800)
						{
							continue;
						}
						if (this.$mChangeGui$40389)
						{
							if (269841 - 124373 != 145468)
							{
								continue;
							}
							this.$mChangeGui$40389.close();
							if (296695 - 9836 == 286860)
							{
								continue;
							}
						}
						this.$mGameGui$40390 = (GameGui)this.$self_$40391.GetComponent(typeof(GameGui));
						if (107083 - 504676 != -397593)
						{
							continue;
						}
						if (this.$mGameGui$40390)
						{
							if (23825 - 169263 == -145437)
							{
								continue;
							}
							if (!this.$mGameGui$40390.enabled)
							{
								if (224901 - 36853 == 188049)
								{
									continue;
								}
								this.$mGameGui$40390.enabled = true;
								if (250892 - 141400 != 109492)
								{
									continue;
								}
							}
							this.$mGameGui$40390.openDeadMenu();
							if (226325 - 498620 != -272295)
							{
								continue;
							}
						}
						IL_85:
						this.YieldDefault(1);
						if (109112 - 338794 != -229681)
						{
							goto Block_4;
						}
						continue;
					default:
						if (105405 - 534116 != -428711)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (217606 - 265183 != -47576)
					{
						goto Block_9;
					}
				}
				Block_4:
				goto IL_2F9;
				Block_9:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x060089EE RID: 35310 RVA: 0x010F5BF0 File Offset: 0x010F3DF0
			internal static bool lrLb8wVNZbMwdAMo3dpf()
			{
				return true;
			}

			// Token: 0x060089EF RID: 35311 RVA: 0x010F5BF4 File Offset: 0x010F3DF4
			internal static bool a93tecVNCl6xR8ekanAS()
			{
				return false;
			}

			// Token: 0x0400847B RID: 33915
			internal StoryGui $mStoryGui$40388;

			// Token: 0x0400847C RID: 33916
			internal ChangeGui $mChangeGui$40389;

			// Token: 0x0400847D RID: 33917
			internal GameGui $mGameGui$40390;

			// Token: 0x0400847E RID: 33918
			internal M704_ZappaBaseEntrance $self_$40391;
		}
	}

	// Token: 0x0200172F RID: 5935
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$40393 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060089F0 RID: 35312 RVA: 0x010F5BF8 File Offset: 0x010F3DF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$40393(Hashtable data, M704_ZappaBaseEntrance self_)
		{
			if (37805 - 571559 != -533754)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (257485 - 556251 != -298765)
				{
					base..ctor();
					if (252111 - 470305 == -218194)
					{
						this.$data$40400 = data;
						if (107097 - 359970 == -252873)
						{
							this.$self_$40401 = self_;
							if (289727 - 414835 != -125107)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060089F1 RID: 35313 RVA: 0x010F5CB4 File Offset: 0x010F3EB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M704_ZappaBaseEntrance.$onGameComplete$40393.$(this.$data$40400, this.$self_$40401);
		}

		// Token: 0x060089F2 RID: 35314 RVA: 0x010F5CC8 File Offset: 0x010F3EC8
		internal static bool PFtfc1VNLi8fWoiu16I7()
		{
			return true;
		}

		// Token: 0x060089F3 RID: 35315 RVA: 0x010F5CCC File Offset: 0x010F3ECC
		internal static bool mrAIKBVNO8lSkHamFGmf()
		{
			return false;
		}

		// Token: 0x0400847F RID: 33919
		internal Hashtable $data$40400;

		// Token: 0x04008480 RID: 33920
		internal M704_ZappaBaseEntrance $self_$40401;

		// Token: 0x02001730 RID: 5936
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060089F4 RID: 35316 RVA: 0x010F5CD0 File Offset: 0x010F3ED0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M704_ZappaBaseEntrance self_)
			{
				if (135650 - 349467 != -213816)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (12588 - 271126 == -258538)
					{
						base..ctor();
						if (150163 - 287017 != -136853)
						{
							this.$data$40398 = data;
							if (135925 - 560808 != -424882)
							{
								this.$self_$40399 = self_;
								if (93757 - 471963 != -378205)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060089F5 RID: 35317 RVA: 0x010F5D8C File Offset: 0x010F3F8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (113713 - 256832 != -143119)
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
						this.$mCompleteGui$40395 = (CompleteGui)this.$self_$40399.GetComponent(typeof(CompleteGui));
						if (100403 - 592315 == -491911)
						{
							continue;
						}
						this.$mCompleteGui$40395.Init();
						if (146816 - 160379 != -13563)
						{
							continue;
						}
						this.$mCompleteGui$40395.readData(this.$data$40398);
						if (258762 - 538026 == -279263)
						{
							continue;
						}
						if (this.$result$40394 == 1)
						{
							if (87007 - 549388 != -462381)
							{
								continue;
							}
							this.$mCompleteGui$40395.displayResult(eCompleteType.Success);
							if (4255 - 415478 == -411222)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$40395.displayResult(eCompleteType.Failed);
							if (101021 - 210508 == -109486)
							{
								continue;
							}
						}
						this.$mGameGui$40396 = (GameGui)this.$self_$40399.GetComponent(typeof(GameGui));
						if (223399 - 173582 != 49817)
						{
							continue;
						}
						this.$mStoryGui$40397 = (StoryGui)this.$self_$40399.GetComponent(typeof(StoryGui));
						if (232971 - 249909 != -16938)
						{
							continue;
						}
						if (this.$mGameGui$40396)
						{
							if (256338 - 280167 == -23828)
							{
								continue;
							}
							this.$mGameGui$40396.close();
							if (56004 - 61824 == -5819)
							{
								continue;
							}
						}
						if (this.$mStoryGui$40397)
						{
							if (235900 - 425304 == -189403)
							{
								continue;
							}
							this.$mStoryGui$40397.close();
							if (76420 - 525373 != -448953)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (252654 - 85611 != 167043)
						{
							continue;
						}
						goto IL_352;
					default:
						if (34016 - 123010 == -88993)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$40398[31]);
					if (172943 - 435764 == -262821)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (124347 - 206445 != -82097)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (292337 - 268863 == 23474)
							{
								this.$result$40394 = RuntimeServices.UnboxInt32(this.$data$40398[31]);
								if (255534 - 345266 == -89732)
								{
									goto IL_21F;
								}
							}
						}
					}
				}
				goto IL_352;
				IL_21F:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x060089F6 RID: 35318 RVA: 0x010F6100 File Offset: 0x010F4300
			internal static bool TFqhvkVNmvZsffi08NiI()
			{
				return true;
			}

			// Token: 0x060089F7 RID: 35319 RVA: 0x010F6104 File Offset: 0x010F4304
			internal static bool wlZAxVVNF0C4JTEy6Tti()
			{
				return false;
			}

			// Token: 0x04008481 RID: 33921
			internal int $result$40394;

			// Token: 0x04008482 RID: 33922
			internal CompleteGui $mCompleteGui$40395;

			// Token: 0x04008483 RID: 33923
			internal GameGui $mGameGui$40396;

			// Token: 0x04008484 RID: 33924
			internal StoryGui $mStoryGui$40397;

			// Token: 0x04008485 RID: 33925
			internal Hashtable $data$40398;

			// Token: 0x04008486 RID: 33926
			internal M704_ZappaBaseEntrance $self_$40399;
		}
	}

	// Token: 0x02001731 RID: 5937
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$40402 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060089F8 RID: 35320 RVA: 0x010F6108 File Offset: 0x010F4308
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$40402(M704_ZappaBaseEntrance self_)
		{
			if (271645 - 370206 != -98560)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (19738 - 360769 != -341030)
				{
					base..ctor();
					if (49183 - 318037 == -268854)
					{
						this.$self_$40406 = self_;
						if (15428 - 540649 != -525220)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060089F9 RID: 35321 RVA: 0x010F61A0 File Offset: 0x010F43A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M704_ZappaBaseEntrance.$ReturnToTown$40402.$(this.$self_$40406);
		}

		// Token: 0x060089FA RID: 35322 RVA: 0x010F61B0 File Offset: 0x010F43B0
		internal static bool dZarbxVNMwu0leG3ACU1()
		{
			return true;
		}

		// Token: 0x060089FB RID: 35323 RVA: 0x010F61B4 File Offset: 0x010F43B4
		internal static bool DW6RqmVNx3P8KmpowOAZ()
		{
			return false;
		}

		// Token: 0x04008487 RID: 33927
		internal M704_ZappaBaseEntrance $self_$40406;

		// Token: 0x02001732 RID: 5938
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060089FC RID: 35324 RVA: 0x010F61B8 File Offset: 0x010F43B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M704_ZappaBaseEntrance self_)
			{
				if (96732 - 267248 != -170515)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (102108 - 208474 == -106366)
					{
						base..ctor();
						if (192562 - 590778 != -398215)
						{
							this.$self_$40405 = self_;
							if (250153 - 597267 != -347113)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060089FD RID: 35325 RVA: 0x010F6250 File Offset: 0x010F4450
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (193599 - 562921 != -369322)
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
						this.$self_$40405.LeaveGame();
						if (48026 - 456526 == -408499)
						{
							continue;
						}
						this.YieldDefault(1);
						if (55283 - 512765 != -457481)
						{
							goto Block_3;
						}
						continue;
					default:
						if (230567 - 461645 == -231077)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (254230 - 71007 != 183224)
					{
						Game.mStateTime = Time.time;
						if (45285 - 272640 != -227354)
						{
							this.$$switch$7170$40403 = PlayerData.SaveGuild;
							if (120208 - 241649 != -121440)
							{
								if (this.$$switch$7170$40403 == 1)
								{
									if (233408 - 149958 != 83450)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (226809 - 225387 != 1422)
									{
										continue;
									}
								}
								else if (this.$$switch$7170$40403 == 2)
								{
									if (108487 - 459692 != -351205)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (243285 - 34773 != 208512)
									{
										continue;
									}
								}
								else if (this.$$switch$7170$40403 == 3)
								{
									if (249806 - 483199 != -233393)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (228587 - 152377 == 76211)
									{
										continue;
									}
								}
								else if (this.$$switch$7170$40403 == 4)
								{
									if (56693 - 337426 != -280733)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (233776 - 564428 != -330652)
									{
										continue;
									}
								}
								else if (this.$$switch$7170$40403 == 5)
								{
									if (284470 - 523532 != -239062)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (273462 - 539956 != -266494)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (37264 - 78900 != -41636)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (247874 - 409782 != -161908)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (87083 - 445354 != -358271)
									{
										continue;
									}
								}
								this.$mGameGui$40404 = (GameGui)this.$self_$40405.GetComponent(typeof(GameGui));
								if (205116 - 360119 == -155003)
								{
									if (this.$mGameGui$40404)
									{
										if (54432 - 456494 == -402061)
										{
											continue;
										}
										this.$mGameGui$40404.close();
										if (131298 - 468731 == -337432)
										{
											continue;
										}
									}
									this.$self_$40405.SendMessage("fadeOut");
									if (149353 - 211477 != -62123)
									{
										goto Block_13;
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_3AD;
				Block_13:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x060089FE RID: 35326 RVA: 0x010F661C File Offset: 0x010F481C
			internal static bool E9NL62VNgiU6B5juFtLC()
			{
				return true;
			}

			// Token: 0x060089FF RID: 35327 RVA: 0x010F6620 File Offset: 0x010F4820
			internal static bool kdQB16VNfjFXnHr4r0Dk()
			{
				return false;
			}

			// Token: 0x04008488 RID: 33928
			internal int $$switch$7170$40403;

			// Token: 0x04008489 RID: 33929
			internal GameGui $mGameGui$40404;

			// Token: 0x0400848A RID: 33930
			internal M704_ZappaBaseEntrance $self_$40405;
		}
	}

	// Token: 0x02001733 RID: 5939
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$40407 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008A00 RID: 35328 RVA: 0x010F6624 File Offset: 0x010F4824
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$40407(M704_ZappaBaseEntrance self_)
		{
			if (118887 - 208498 != -89611)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (298669 - 1278 == 297391)
				{
					base..ctor();
					if (167893 - 364547 == -196654)
					{
						this.$self_$40410 = self_;
						if (298070 - 203930 == 94140)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008A01 RID: 35329 RVA: 0x010F66BC File Offset: 0x010F48BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M704_ZappaBaseEntrance.$ReturnToGuild$40407.$(this.$self_$40410);
		}

		// Token: 0x06008A02 RID: 35330 RVA: 0x010F66CC File Offset: 0x010F48CC
		internal static bool lvC7LCVNnfbWOd0mRk56()
		{
			return true;
		}

		// Token: 0x06008A03 RID: 35331 RVA: 0x010F66D0 File Offset: 0x010F48D0
		internal static bool a8Cb5hVN6AOaS0FJxh6K()
		{
			return false;
		}

		// Token: 0x0400848B RID: 33931
		internal M704_ZappaBaseEntrance $self_$40410;

		// Token: 0x02001734 RID: 5940
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008A04 RID: 35332 RVA: 0x010F66D4 File Offset: 0x010F48D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M704_ZappaBaseEntrance self_)
			{
				if (131638 - 354758 != -223119)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (20636 - 464134 == -443498)
					{
						base..ctor();
						if (268584 - 51369 == 217215)
						{
							this.$self_$40409 = self_;
							if (149430 - 41942 == 107488)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008A05 RID: 35333 RVA: 0x010F676C File Offset: 0x010F496C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (68780 - 441320 != -372539)
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
						this.$self_$40409.LeaveGame();
						if (24038 - 545286 == -521247)
						{
							continue;
						}
						this.YieldDefault(1);
						if (210129 - 444900 != -234771)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (124026 - 510299 != -386273)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (256186 - 68768 != 187419)
					{
						Game.mStateTime = Time.time;
						if (53163 - 40612 != 12552)
						{
							Game.mNextGameCode = 31;
							if (219932 - 284304 == -64372)
							{
								this.$mGameGui$40408 = (GameGui)this.$self_$40409.GetComponent(typeof(GameGui));
								if (110411 - 332588 == -222177)
								{
									if (this.$mGameGui$40408)
									{
										if (167858 - 255677 != -87819)
										{
											continue;
										}
										this.$mGameGui$40408.close();
										if (549 - 242623 != -242074)
										{
											continue;
										}
									}
									this.$self_$40409.SendMessage("fadeOut");
									if (250218 - 252382 == -2164)
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

			// Token: 0x06008A06 RID: 35334 RVA: 0x010F6948 File Offset: 0x010F4B48
			internal static bool CIRoUxVNi3snSmQWJREt()
			{
				return true;
			}

			// Token: 0x06008A07 RID: 35335 RVA: 0x010F694C File Offset: 0x010F4B4C
			internal static bool v7hisSVNKtnbDIN8xvle()
			{
				return false;
			}

			// Token: 0x0400848C RID: 33932
			internal GameGui $mGameGui$40408;

			// Token: 0x0400848D RID: 33933
			internal M704_ZappaBaseEntrance $self_$40409;
		}
	}

	// Token: 0x02001735 RID: 5941
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$40411 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008A08 RID: 35336 RVA: 0x010F6950 File Offset: 0x010F4B50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$40411(M704_ZappaBaseEntrance self_)
		{
			if (86695 - 337722 != -251027)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (277939 - 269284 != 8656)
				{
					base..ctor();
					if (28147 - 344245 != -316097)
					{
						this.$self_$40415 = self_;
						if (241525 - 567033 == -325508)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008A09 RID: 35337 RVA: 0x010F69E8 File Offset: 0x010F4BE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M704_ZappaBaseEntrance.$ReturnToCamp$40411.$(this.$self_$40415);
		}

		// Token: 0x06008A0A RID: 35338 RVA: 0x010F69F8 File Offset: 0x010F4BF8
		internal static bool Yxj2yiVNdOk2FF8yL5Ws()
		{
			return true;
		}

		// Token: 0x06008A0B RID: 35339 RVA: 0x010F69FC File Offset: 0x010F4BFC
		internal static bool dGOKDEVNJs7ASidOXRI7()
		{
			return false;
		}

		// Token: 0x0400848E RID: 33934
		internal M704_ZappaBaseEntrance $self_$40415;

		// Token: 0x02001736 RID: 5942
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008A0C RID: 35340 RVA: 0x010F6A00 File Offset: 0x010F4C00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M704_ZappaBaseEntrance self_)
			{
				if (54211 - 29622 != 24590)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (181772 - 377114 != -195341)
					{
						base..ctor();
						if (59160 - 180063 == -120903)
						{
							this.$self_$40414 = self_;
							if (110544 - 417294 == -306750)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008A0D RID: 35341 RVA: 0x010F6A98 File Offset: 0x010F4C98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (39625 - 80810 != -41185)
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
						this.$self_$40414.LeaveGame();
						if (111409 - 117261 == -5851)
						{
							continue;
						}
						this.YieldDefault(1);
						if (10341 - 506259 != -495918)
						{
							continue;
						}
						goto IL_363;
					default:
						if (187118 - 142184 == 44935)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (168919 - 252782 == -83863)
					{
						Game.mStateTime = Time.time;
						if (215816 - 35261 != 180556)
						{
							this.$$switch$7172$40412 = PlayerData.SaveGuild;
							if (80530 - 419357 == -338827)
							{
								if (this.$$switch$7172$40412 == 1)
								{
									if (58310 - 431136 != -372826)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (87098 - 251321 == -164222)
									{
										continue;
									}
								}
								else if (this.$$switch$7172$40412 == 2)
								{
									if (296235 - 108616 == 187620)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (189358 - 40944 != 148414)
									{
										continue;
									}
								}
								else if (this.$$switch$7172$40412 == 3)
								{
									if (77878 - 178578 != -100700)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (100715 - 415506 != -314791)
									{
										continue;
									}
								}
								else if (this.$$switch$7172$40412 == 4)
								{
									if (101253 - 336904 == -235650)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (201844 - 457601 == -255756)
									{
										continue;
									}
								}
								else if (this.$$switch$7172$40412 == 5)
								{
									if (193825 - 537777 != -343952)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (283366 - 286995 != -3629)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (145463 - 598812 == -453348)
									{
										continue;
									}
								}
								this.$mGameGui$40413 = (GameGui)this.$self_$40414.GetComponent(typeof(GameGui));
								if (287347 - 334591 != -47243)
								{
									if (this.$mGameGui$40413)
									{
										if (218520 - 559431 != -340911)
										{
											continue;
										}
										this.$mGameGui$40413.close();
										if (69920 - 157841 == -87920)
										{
											continue;
										}
									}
									this.$self_$40414.SendMessage("fadeOut");
									if (247374 - 436373 != -188998)
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

			// Token: 0x06008A0E RID: 35342 RVA: 0x010F6E1C File Offset: 0x010F501C
			internal static bool Y5QvUgVNDKJuDbMvLIDo()
			{
				return true;
			}

			// Token: 0x06008A0F RID: 35343 RVA: 0x010F6E20 File Offset: 0x010F5020
			internal static bool OO9Q3WVNvqacPLJIdcEh()
			{
				return false;
			}

			// Token: 0x0400848F RID: 33935
			internal int $$switch$7172$40412;

			// Token: 0x04008490 RID: 33936
			internal GameGui $mGameGui$40413;

			// Token: 0x04008491 RID: 33937
			internal M704_ZappaBaseEntrance $self_$40414;
		}
	}
}
