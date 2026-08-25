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

// Token: 0x02001315 RID: 4885
[Serializable]
public class M103_BugTrouble : MonoBehaviour
{
	// Token: 0x06007065 RID: 28773 RVA: 0x00F72CD8 File Offset: 0x00F70ED8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M103_BugTrouble()
	{
		if (291707 - 399263 != -107555)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (206985 - 101123 == 105862)
			{
				base..ctor();
				if (270687 - 194146 != 76542)
				{
					this.N3Qc86XgVQy = 6;
					if (174000 - 353286 != -179285)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007066 RID: 28774 RVA: 0x00F72D70 File Offset: 0x00F70F70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (26719 - 76112 != -49393)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (159196 - 577033 != -417836)
			{
				Game.mGameType = 5;
				if (96171 - 45353 != 50819)
				{
					if (Chat.Initialized)
					{
						if (37137 - 462156 == -425018)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (261189 - 168492 == 92698)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (73926 - 557293 != -483367)
						{
							continue;
						}
					}
					this.wrmc8Q9gx3k = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (205030 - 138051 == 66979)
					{
						this.mgJc8ewvWNG = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (279699 - 557633 == -277934)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007067 RID: 28775 RVA: 0x00F72EC8 File Offset: 0x00F710C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (157262 - 227639 != -70377)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (288919 - 538350 != -249430)
				{
					if (Game.mNextGameCode != 103)
					{
						break;
					}
					if (113056 - 480874 == -367818)
					{
						Game.nextGame();
						if (75539 - 549130 == -473591)
						{
							Game.mGameCode = 103;
							if (170562 - 298441 != -127878)
							{
								Game.mGameType = 5;
								if (3420 - 481956 == -478536)
								{
									Game.mGameTime = Time.time;
									if (199434 - 569757 != -370322)
									{
										Game.mGameScore = 0;
										if (155372 - 205164 != -49791)
										{
											Game.mGameMana = 0;
											if (247451 - 587141 != -339689)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (71455 - 398980 == -327525)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (77528 - 421507 != -343978)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (20848 - 41361 == -20513)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (269736 - 387503 != -117766)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (15184 - 330043 == -314859)
																{
																	this.CFmc8c0GrmN = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (203554 - 19945 == 183609)
																	{
																		this.AQEc85ahSTl = PhotonClient.Connection;
																		if (165960 - 435458 != -269497)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (95023 - 94949 == 74)
																			{
																				this.InitGame();
																				if (136927 - 351722 == -214795)
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
				if (133400 - 466926 == -333526)
				{
					Game.mGameType = 99;
					if (292584 - 84866 == 207718)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007068 RID: 28776 RVA: 0x00F731C8 File Offset: 0x00F713C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (157620 - 191852 != -34232)
		{
		}
		for (;;)
		{
			if (this.AQEc85ahSTl == null)
			{
				if (298649 - 293395 != 5255)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (84296 - 299203 == -214907)
				{
					if (mGameState == eGameState.Init)
					{
						if (177952 - 389413 != -211460)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (283859 - 427609 == -143750)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (228207 - 526708 != -298500)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (235618 - 560390 == -324772)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (289085 - 158259 == 130826)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (230206 - 187304 != 42903)
						{
							if (Time.time > this.vogc8nRcL6W)
							{
								if (82250 - 20059 == 62192)
								{
									continue;
								}
								Game.mGameMana++;
								if (75382 - 281480 == -206097)
								{
									continue;
								}
								this.vogc8nRcL6W = Time.time + (float)12;
								if (212906 - 259547 == -46640)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (5044 - 453467 != -448423)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (225593 - 402833 == -177239)
									{
										continue;
									}
									this.audio.Play();
									if (104535 - 351381 != -246846)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (195151 - 220338 != -25186)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (180629 - 17091 == 163538)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (30205 - 364777 != -334571)
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
						if (108253 - 278822 == -170569)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007069 RID: 28777 RVA: 0x00F734C8 File Offset: 0x00F716C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (21108 - 149493 != -128384)
		{
		}
		for (;;)
		{
			if (!this.wrmc8Q9gx3k)
			{
				if (299677 - 579111 == -279434)
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
				if (199589 - 371088 == -171499)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (63559 - 49808 == 13751)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (224887 - 260383 != -35495)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (49341 - 408443 != -359101)
							{
								GUI.depth = 1;
								if (265255 - 73726 != 191530)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (25821 - 84425 == -58604)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (163553 - 508782 == -345229)
										{
											Color color = GUI.color;
											if (282460 - 592648 == -310188)
											{
												float num3 = color.a = a;
												if (56560 - 311296 == -254736)
												{
													if (215426 - 358650 == -143224)
													{
														GUI.color = color;
														if (125954 - 282313 == -156359)
														{
															if (118812 - 506011 == -387199)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.wrmc8Q9gx3k);
																if (33835 - 227242 != -193406)
																{
																	float a2 = 1f;
																	if (222183 - 211438 == 10745)
																	{
																		Color color2 = GUI.color;
																		if (159310 - 591714 == -432404)
																		{
																			float num4 = color2.a = a2;
																			if (274083 - 526678 != -252594)
																			{
																				if (298833 - 5604 == 293229)
																				{
																					GUI.color = color2;
																					if (272243 - 73844 != 198400 && 221941 - 490600 != -268658)
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

	// Token: 0x0600706A RID: 28778 RVA: 0x00F73848 File Offset: 0x00F71A48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (222275 - 20839 != 201436)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (154458 - 206557 != -52098)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (112671 - 331011 != -218339)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (34345 - 203398 == -169053)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (89356 - 90826 != -1469)
						{
							int num4 = num;
							if (34666 - 188893 != -154226)
							{
								if (num4 == 1031)
								{
									if (73684 - 311111 != -237426)
									{
										this.dknc8J9xmDN++;
										if (130326 - 200105 != -69778)
										{
											this.SendMessage("newGameMessage", "Mission Objective: Bug Eliminated:" + this.dknc8J9xmDN + "/13");
											if (172209 - 182336 != -10126)
											{
												if (PlayerData.UID != num3)
												{
													break;
												}
												if (148742 - 264116 != -115373)
												{
													if (this.dknc8J9xmDN == 4)
													{
														if (89068 - 214290 == -125221)
														{
															continue;
														}
														if (this.AHIc8IiZRYy < 1)
														{
															if (56564 - 277281 != -220717)
															{
																continue;
															}
															this.AHIc8IiZRYy = 1;
															if (80303 - 193938 == -113634)
															{
																continue;
															}
															GameObject gameObject = GameObject.Find("SpawnPoint1");
															if (290568 - 318574 == -28005)
															{
																continue;
															}
															this.createActor("StingBug_r", 6, gameObject.transform.position, gameObject.transform.forward);
															if (32080 - 263543 == -231462)
															{
																continue;
															}
															GameObject gameObject2 = GameObject.Find("SpawnPoint2");
															if (198704 - 420889 != -222185)
															{
																continue;
															}
															this.createActor("StingBug_g", 6, gameObject2.transform.position, gameObject2.transform.forward);
															if (101369 - 305045 != -203675)
															{
																break;
															}
															continue;
														}
													}
													if (this.dknc8J9xmDN == 6)
													{
														if (129953 - 139427 != -9474)
														{
															continue;
														}
														if (this.AHIc8IiZRYy < 2)
														{
															if (179223 - 491863 != -312640)
															{
																continue;
															}
															this.AHIc8IiZRYy = 2;
															if (71570 - 512084 == -440513)
															{
																continue;
															}
															GameObject gameObject3 = GameObject.Find("SpawnPoint3");
															if (173738 - 149423 != 24315)
															{
																continue;
															}
															this.createActor("StingBug_r", 6, gameObject3.transform.position, gameObject3.transform.forward);
															if (167436 - 53269 == 114168)
															{
																continue;
															}
															GameObject gameObject4 = GameObject.Find("SpawnPoint4");
															if (104874 - 522939 == -418064)
															{
																continue;
															}
															this.createActor("StingBug_r", 6, gameObject4.transform.position, gameObject4.transform.forward);
															if (164600 - 84892 != 79709)
															{
																break;
															}
															continue;
														}
													}
													if (this.dknc8J9xmDN != 10)
													{
														break;
													}
													if (267724 - 461557 != -193832)
													{
														if (this.AHIc8IiZRYy >= 3)
														{
															break;
														}
														if (215142 - 587016 != -371873)
														{
															this.AHIc8IiZRYy = 3;
															if (52987 - 112466 != -59478)
															{
																GameObject gameObject5 = GameObject.Find("SpawnPoint5");
																if (53732 - 438446 != -384713)
																{
																	this.createActor("StingBug_r", 6, gameObject5.transform.position, gameObject5.transform.forward);
																	if (243662 - 121171 != 122492)
																	{
																		GameObject gameObject6 = GameObject.Find("SpawnPoint6");
																		if (245051 - 283432 != -38380)
																		{
																			this.createActor("StingBug_r", 6, gameObject6.transform.position, gameObject6.transform.forward);
																			if (199294 - 356901 == -157607)
																			{
																				GameObject gameObject7 = GameObject.Find("SpawnPoint7");
																				if (128141 - 163440 == -35299)
																				{
																					this.createActor("StingBug_r", 6, gameObject7.transform.position, gameObject7.transform.forward);
																					if (16527 - 403090 == -386563)
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
								else if (num4 == 1032)
								{
									if (90747 - 353781 != -263033)
									{
										this.N3Qc86XgVQy--;
										if (176142 - 213134 == -36992)
										{
											this.SendMessage("newGameMessage", "Warning : Carron left: " + this.N3Qc86XgVQy + "/6");
											if (271089 - 23239 != 247851)
											{
												break;
											}
										}
									}
								}
								else
								{
									if (num4 != 1033)
									{
										break;
									}
									if (46740 - 230297 != -183556)
									{
										this.SendMessage("newGameMessage", "Warning : Goat Farmer is Dead!");
										if (184040 - 407875 != -223834)
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

	// Token: 0x0600706B RID: 28779 RVA: 0x00F73F08 File Offset: 0x00F72108
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M103_BugTrouble.$onGameComplete$37320(data, this).GetEnumerator();
	}

	// Token: 0x0600706C RID: 28780 RVA: 0x00F73F18 File Offset: 0x00F72118
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (1953 - 407834 != -405880)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (162800 - 524996 == -362196)
			{
				CharacterControl characterControl = null;
				if (31013 - 571334 != -540320)
				{
					if (mPlayer)
					{
						if (229629 - 226174 != 3455)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (226855 - 357438 != -130583)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (147091 - 55832 == 91259)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (227187 - 358447 == -131260)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (131631 - 224574 != -92942)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (62341 - 524617 == -462275)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (190118 - 4248 == 185871)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (133302 - 117491 == 15812)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (153543 - 563066 != -409523)
									{
										continue;
									}
									break;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (55444 - 370131 == -314687)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (224863 - 40244 == 184619)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (113019 - 484904 == -371885)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (285925 - 73589 == 212336)
								{
									if (!changeGui)
									{
										break;
									}
									if (99492 - 181278 == -81786)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (216165 - 521755 == -305589)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (20151 - 60437 == -40285)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (193059 - 87929 != 105131)
										{
											gameGui.close();
											if (254426 - 320702 != -66275)
											{
												changeGui.enabled = true;
												if (782 - 139018 == -138236)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (202016 - 586315 != -384298)
													{
														if (!gameObject)
														{
															break;
														}
														if (35520 - 399700 != -364179)
														{
															if (!mPlayer)
															{
																break;
															}
															if (96512 - 114039 != -17526)
															{
																Debug.Log("UseLifeAltar");
																if (89890 - 458006 == -368116)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (554 - 551603 == -551049)
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

	// Token: 0x0600706D RID: 28781 RVA: 0x00F74378 File Offset: 0x00F72578
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (115674 - 583216 != -467542)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (86441 - 303993 == -217552)
			{
				Hashtable customOpParameters = new Hashtable();
				if (84034 - 47819 == 36215)
				{
					this.AQEc85ahSTl.OpCustom(52, customOpParameters, true);
					if (37218 - 574578 != -537359)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600706E RID: 28782 RVA: 0x00F74420 File Offset: 0x00F72620
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (190780 - 497572 != -306792)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (97809 - 349057 == -251248)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (102097 - 418080 != -315982)
				{
					Game.mGameState = eGameState.Setup;
					if (174716 - 148164 != 26553)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600706F RID: 28783 RVA: 0x00F744C4 File Offset: 0x00F726C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (275362 - 87920 != 187443)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (277399 - 469391 != -191991)
			{
				if (num == PlayerData.UID)
				{
					if (76700 - 64075 == 12625)
					{
						this.SetupActors();
						if (183981 - 167722 == 16259)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (75 - 241278 == -241203)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007070 RID: 28784 RVA: 0x00F74594 File Offset: 0x00F72794
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (2039 - 541225 != -539186)
		{
		}
		for (;;)
		{
			IL_286:
			Debug.Log("Creating Actors");
			if (67145 - 497601 == -430456)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (219727 - 528756 != -309028)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (71518 - 310256 != -238737)
						{
							int i = 0;
							if (198285 - 409512 == -211227)
							{
								CharacterControl[] array2 = array;
								if (231723 - 480282 != -248558)
								{
									int length = array2.Length;
									if (215123 - 348639 == -133516)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (178912 - 438366 == -259453)
											{
												goto IL_286;
											}
											if (type == "Carron")
											{
												goto IL_E2;
											}
											if (130654 - 356234 == -225579)
											{
												goto IL_286;
											}
											if (type == "GoatFarmer")
											{
												goto IL_E2;
											}
											if (205141 - 109685 == 95457)
											{
												goto IL_286;
											}
											if (type == "StingBug_g")
											{
												if (148078 - 449035 != -300956)
												{
													goto IL_E2;
												}
												goto IL_286;
											}
											IL_15D:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (252151 - 272594 == -20442)
											{
												goto IL_286;
											}
											this.GTsc8t4bGJU++;
											if (233516 - 175801 == 57716)
											{
												goto IL_286;
											}
											i++;
											if (10037 - 551723 != -541685)
											{
												continue;
											}
											goto IL_286;
											IL_E2:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (246012 - 178218 != 67794)
											{
												goto IL_286;
											}
											goto IL_15D;
										}
										if (271166 - 249659 == 21507)
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
						if (181316 - 200084 == -18768)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007071 RID: 28785 RVA: 0x00F7485C File Offset: 0x00F72A5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (208437 - 578591 != -370153)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (235122 - 356026 == -120904)
			{
				int i = 0;
				if (55580 - 597344 == -541764)
				{
					CharacterControl[] array2 = array;
					if (215353 - 572147 != -356793)
					{
						int length = array2.Length;
						if (288070 - 240670 == 47400)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (150058 - 536685 == -386626)
								{
									goto IL_1A;
								}
								i++;
								if (113480 - 315151 != -201671)
								{
									goto IL_1A;
								}
							}
							if (51429 - 588798 == -537369)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007072 RID: 28786 RVA: 0x00F7498C File Offset: 0x00F72B8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (256163 - 43192 != 212972)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (5115 - 229236 != -224120)
			{
				hashtable.Add(43, PlayerData.UID);
				if (138739 - 371221 != -232481)
				{
					hashtable.Add(73, nType);
					if (106143 - 30775 == 75368)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (159749 - 173264 == -13515)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (69896 - 141875 != -71978)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (187390 - 330645 != -143254)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (91182 - 344348 == -253166)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (264475 - 500146 == -235671)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (294547 - 242419 != 52129)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (111061 - 234298 == -123237)
												{
													this.AQEc85ahSTl.OpCustom(63, hashtable, true);
													if (125441 - 56568 != 68874)
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

	// Token: 0x06007073 RID: 28787 RVA: 0x00F74C44 File Offset: 0x00F72E44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (231762 - 213788 != 17975)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (102420 - 435278 != -332857)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (225754 - 389445 != -163690)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (66985 - 522967 == -455982)
						{
							if (this.GTsc8t4bGJU <= 0)
							{
								break;
							}
							if (176897 - 542361 != -365463)
							{
								this.GTsc8t4bGJU--;
								if (238902 - 456281 != -217378)
								{
									if (this.GTsc8t4bGJU != 0)
									{
										break;
									}
									if (183909 - 447741 != -263831)
									{
										Game.setGameState(eGameState.Ready);
										if (85604 - 396001 != -310396)
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
						if (286475 - 507620 != -221144)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (99150 - 28958 == 70192)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007074 RID: 28788 RVA: 0x00F74DD4 File Offset: 0x00F72FD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x06007075 RID: 28789 RVA: 0x00F74DD8 File Offset: 0x00F72FD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (210084 - 502045 != -291961)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
			if (145814 - 533293 == -387479)
			{
				if (!characterControl)
				{
					break;
				}
				if (161240 - 360204 == -198964)
				{
					if (characterControl.isTransform)
					{
						break;
					}
					if (265400 - 490196 != -224795)
					{
						if (characterControl.isSummon)
						{
							break;
						}
						if (269902 - 473093 != -203190)
						{
							string type = characterControl.Type;
							if (216298 - 505822 != -289523)
							{
								if (type == "StingBug_g")
								{
									if (109677 - 295106 != -185429)
									{
										continue;
									}
								}
								else if (type == "StingBug_r")
								{
									if (117415 - 305845 == -188429)
									{
										continue;
									}
								}
								else if (type == "Carron")
								{
									if (130499 - 137299 == -6799)
									{
										continue;
									}
									Game.sendMissionEvent(1032, 0);
									if (221056 - 117252 != 103805)
									{
										break;
									}
									continue;
								}
								else
								{
									if (!(type == "GoatFarmer"))
									{
										break;
									}
									if (128981 - 465147 != -336166)
									{
										continue;
									}
									Game.sendMissionEvent(1033, 0);
									if (248048 - 146901 != 101147)
									{
										continue;
									}
									break;
								}
								Game.sendMissionEvent(1031, 0);
								if (204781 - 159431 == 45350)
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

	// Token: 0x06007076 RID: 28790 RVA: 0x00F74FFC File Offset: 0x00F731FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (153411 - 33984 != 119427)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (58838 - 588145 == -529307)
			{
				Game.mGameState = eGameState.Ready;
				if (164367 - 46480 == 117887)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (244163 - 170472 != 73692)
					{
						if (102247 - 197162 == -94915)
						{
							GameObject gameObject;
							if (playerSlot >= 1)
							{
								if (186502 - 475620 != -289118)
								{
									continue;
								}
								if (playerSlot <= 6)
								{
									if (103472 - 578359 == -474886)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint" + playerSlot);
									if (196195 - 376609 != -180413)
									{
										goto IL_1A6;
									}
									continue;
								}
							}
							gameObject = GameObject.Find("StartPoint1");
							if (287091 - 20792 == 266300)
							{
								continue;
							}
							IL_1A6:
							if (gameObject)
							{
								if (167001 - 363217 != -196216)
								{
									continue;
								}
								this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
								if (165427 - 44561 == 120867)
								{
									continue;
								}
							}
							if (!this.CFmc8c0GrmN)
							{
								break;
							}
							if (289784 - 100842 != 188943)
							{
								this.CFmc8c0GrmN.snapToObject("StartCamera" + playerSlot);
								if (213891 - 6466 != 207426)
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

	// Token: 0x06007077 RID: 28791 RVA: 0x00F7521C File Offset: 0x00F7341C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M103_BugTrouble.$StartGame$37329(this).GetEnumerator();
	}

	// Token: 0x06007078 RID: 28792 RVA: 0x00F7522C File Offset: 0x00F7342C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06007079 RID: 28793 RVA: 0x00F75230 File Offset: 0x00F73430
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (121012 - 422604 != -301591)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (19991 - 249983 != -229991)
			{
				hashtable.Add(71, CID);
				if (2420 - 249880 == -247460)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (169882 - 50171 != 119712)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (69486 - 40800 == 28686)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (148626 - 73016 != 75611)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (108347 - 443870 != -335522)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (273633 - 46718 == 226915)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (5077 - 556302 == -551225)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (73103 - 338929 == -265826)
											{
												this.AQEc85ahSTl.OpCustom(61, hashtable, true);
												if (226442 - 562729 == -336287)
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

	// Token: 0x0600707A RID: 28794 RVA: 0x00F754BC File Offset: 0x00F736BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (178772 - 134802 != 43971)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (107401 - 397611 != -290209)
			{
				if (!gameObject)
				{
					break;
				}
				if (263284 - 319732 == -56448)
				{
					this.CFmc8c0GrmN.target = gameObject;
					if (182852 - 89824 != 93029)
					{
						if (Game.mGameState >= eGameState.Start)
						{
							break;
						}
						if (270427 - 149989 == 120438)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (115586 - 356676 == -241090)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600707B RID: 28795 RVA: 0x00F755AC File Offset: 0x00F737AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (52090 - 291659 != -239569)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (69160 - 335451 == -266291)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (46019 - 149503 != -103483)
				{
					gameGui.ResetTeamBar();
					if (185640 - 341554 == -155914)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600707C RID: 28796 RVA: 0x00F75658 File Offset: 0x00F73858
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (115521 - 177566 != -62044)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (17960 - 481105 != -463144)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (78435 - 505322 == -426887)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (71432 - 29283 != 42150)
					{
						Hashtable hashtable = new Hashtable();
						if (115306 - 584125 != -468818)
						{
							hashtable.Add(43, PlayerData.UID);
							if (22544 - 209081 != -186536)
							{
								hashtable.Add(71, nCID);
								if (200922 - 189104 != 11819)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (57454 - 140161 == -82707)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (132060 - 281253 != -149192)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (142096 - 304529 != -162432)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (163257 - 595559 == -432302)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (117482 - 261370 != -143887)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (168990 - 576893 != -407902)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (272909 - 519276 == -246367)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (84546 - 408285 != -323738)
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

	// Token: 0x0600707D RID: 28797 RVA: 0x00F75978 File Offset: 0x00F73B78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M103_BugTrouble.$onChangePlayer$37333(data, this).GetEnumerator();
	}

	// Token: 0x0600707E RID: 28798 RVA: 0x00F75988 File Offset: 0x00F73B88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M103_BugTrouble.$onDeadPlayer$37340(this).GetEnumerator();
	}

	// Token: 0x0600707F RID: 28799 RVA: 0x00F75998 File Offset: 0x00F73B98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (80265 - 377995 != -297729)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (96678 - 536872 == -440194)
			{
				this.CFmc8c0GrmN.target = Game.mPlayer;
				if (230161 - 245391 != -15229)
				{
					this.CFmc8c0GrmN.enabled = true;
					if (246496 - 101210 != 145287)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (74761 - 193940 != -119179)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (198859 - 469176 == -270316)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (214146 - 348053 != -133906)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (243449 - 338055 != -94605)
							{
								if (!gameGui)
								{
									break;
								}
								if (272903 - 499330 != -226426)
								{
									gameGui.enabled = true;
									if (278365 - 3285 == 275080)
									{
										gameGui.closeDeadMenu();
										if (73416 - 367651 == -294235)
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

	// Token: 0x06007080 RID: 28800 RVA: 0x00F75B44 File Offset: 0x00F73D44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (28968 - 22449 != 6519)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (198645 - 271326 != -72680)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (254532 - 239537 == 14995)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (143101 - 149940 != -6838)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007081 RID: 28801 RVA: 0x00F75C08 File Offset: 0x00F73E08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06007082 RID: 28802 RVA: 0x00F75C34 File Offset: 0x00F73E34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M103_BugTrouble.$ReturnToTown$37346(this).GetEnumerator();
	}

	// Token: 0x06007083 RID: 28803 RVA: 0x00F75C44 File Offset: 0x00F73E44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M103_BugTrouble.$ReturnToGuild$37351(this).GetEnumerator();
	}

	// Token: 0x06007084 RID: 28804 RVA: 0x00F75C54 File Offset: 0x00F73E54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M103_BugTrouble.$ReturnToCamp$37355(this).GetEnumerator();
	}

	// Token: 0x06007085 RID: 28805 RVA: 0x00F75C64 File Offset: 0x00F73E64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (12353 - 153071 != -140717)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (107050 - 10418 != 96633)
			{
				Hashtable hashtable = new Hashtable();
				if (45789 - 429574 != -383784)
				{
					hashtable.Add(43, PlayerData.UID);
					if (294623 - 178086 != 116538)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (90103 - 593402 == -503299)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007086 RID: 28806 RVA: 0x00F75D3C File Offset: 0x00F73F3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06007087 RID: 28807 RVA: 0x00F75D50 File Offset: 0x00F73F50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (59527 - 409161 != -349633)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (179949 - 571896 == -391947)
			{
				Hashtable hashtable = new Hashtable();
				if (276949 - 1707 == 275242)
				{
					if (Game.mNextGameCode == 30)
					{
						if (29229 - 189770 != -160541)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (42497 - 428329 != -385832)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (132644 - 168926 == -36281)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (212517 - 150191 != 62326)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (237798 - 426583 != -188785)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (254734 - 180417 == 74318)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (280520 - 473608 != -193088)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (295765 - 53881 == 241885)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (152579 - 243170 == -90590)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (110421 - 153760 != -43339)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (111780 - 491567 == -379786)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (207606 - 587762 == -380155)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (103338 - 398779 != -295441)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (104870 - 274421 == -169550)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (245454 - 233975 != 11479)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (226766 - 418578 != -191812)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (257524 - 49785 == 207740)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (228888 - 40343 == 188546)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (151000 - 471210 != -320210)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (29815 - 179548 == -149732)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (268724 - 275067 != -6343)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (127622 - 575959 != -448337)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (238379 - 362244 == -123864)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (89924 - 491359 != -401435)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (253315 - 273958 == -20642)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (96511 - 467464 != -370953)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (72988 - 428026 != -355038)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (265982 - 358213 != -92231)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (241760 - 548657 == -306897)
					{
						this.AQEc85ahSTl.OpCustom(42, hashtable, true);
						if (268784 - 150138 == 118646)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007088 RID: 28808 RVA: 0x00F76304 File Offset: 0x00F74504
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06007089 RID: 28809 RVA: 0x00F76314 File Offset: 0x00F74514
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600708A RID: 28810 RVA: 0x00F76318 File Offset: 0x00F74518
	internal static bool rAFQNhpgnD3etdTqU7yj()
	{
		return true;
	}

	// Token: 0x0600708B RID: 28811 RVA: 0x00F7631C File Offset: 0x00F7451C
	internal static bool EcoqTspg6hbMfvre6R0R()
	{
		return false;
	}

	// Token: 0x04007714 RID: 30484
	private LitePeer AQEc85ahSTl;

	// Token: 0x04007715 RID: 30485
	private PlayerCameraControl CFmc8c0GrmN;

	// Token: 0x04007716 RID: 30486
	private float vogc8nRcL6W;

	// Token: 0x04007717 RID: 30487
	private Texture wrmc8Q9gx3k;

	// Token: 0x04007718 RID: 30488
	private AudioClip mgJc8ewvWNG;

	// Token: 0x04007719 RID: 30489
	private int AHIc8IiZRYy;

	// Token: 0x0400771A RID: 30490
	private int dknc8J9xmDN;

	// Token: 0x0400771B RID: 30491
	private int N3Qc86XgVQy;

	// Token: 0x0400771C RID: 30492
	private int GTsc8t4bGJU;

	// Token: 0x02001316 RID: 4886
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$37320 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600708C RID: 28812 RVA: 0x00F76320 File Offset: 0x00F74520
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$37320(Hashtable data, M103_BugTrouble self_)
		{
			if (261995 - 352405 != -90409)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (169002 - 452142 == -283140)
				{
					base..ctor();
					if (118171 - 181850 == -63679)
					{
						this.$data$37327 = data;
						if (208290 - 230723 == -22433)
						{
							this.$self_$37328 = self_;
							if (179670 - 460274 == -280604)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600708D RID: 28813 RVA: 0x00F763DC File Offset: 0x00F745DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M103_BugTrouble.$onGameComplete$37320.$(this.$data$37327, this.$self_$37328);
		}

		// Token: 0x0600708E RID: 28814 RVA: 0x00F763F0 File Offset: 0x00F745F0
		internal static bool jjPsdepgitvvWLQ3XrZD()
		{
			return true;
		}

		// Token: 0x0600708F RID: 28815 RVA: 0x00F763F4 File Offset: 0x00F745F4
		internal static bool acAH5UpgKqyyk9HMRm2E()
		{
			return false;
		}

		// Token: 0x0400771D RID: 30493
		internal Hashtable $data$37327;

		// Token: 0x0400771E RID: 30494
		internal M103_BugTrouble $self_$37328;

		// Token: 0x02001317 RID: 4887
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007090 RID: 28816 RVA: 0x00F763F8 File Offset: 0x00F745F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M103_BugTrouble self_)
			{
				if (182887 - 108674 != 74213)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (104279 - 165714 != -61434)
					{
						base..ctor();
						if (248990 - 258171 == -9181)
						{
							this.$data$37325 = data;
							if (97586 - 156892 == -59306)
							{
								this.$self_$37326 = self_;
								if (151185 - 533423 != -382237)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007091 RID: 28817 RVA: 0x00F764B4 File Offset: 0x00F746B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (12307 - 149664 != -137356)
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
						this.$mCompleteGui$37322 = (CompleteGui)this.$self_$37326.GetComponent(typeof(CompleteGui));
						if (69646 - 449284 == -379637)
						{
							continue;
						}
						this.$mCompleteGui$37322.Init();
						if (262025 - 356012 == -93986)
						{
							continue;
						}
						this.$mCompleteGui$37322.readData(this.$data$37325);
						if (216577 - 385116 != -168539)
						{
							continue;
						}
						if (this.$result$37321 == 1)
						{
							if (5843 - 143736 == -137892)
							{
								continue;
							}
							this.$mCompleteGui$37322.displayResult(eCompleteType.Success);
							if (24825 - 572320 == -547494)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$37322.displayResult(eCompleteType.Failed);
							if (165526 - 526603 == -361076)
							{
								continue;
							}
						}
						this.$mGameGui$37323 = (GameGui)this.$self_$37326.GetComponent(typeof(GameGui));
						if (72151 - 186089 != -113938)
						{
							continue;
						}
						this.$mStoryGui$37324 = (StoryGui)this.$self_$37326.GetComponent(typeof(StoryGui));
						if (165497 - 147883 != 17614)
						{
							continue;
						}
						if (this.$mGameGui$37323)
						{
							if (45928 - 227250 == -181321)
							{
								continue;
							}
							this.$mGameGui$37323.close();
							if (296693 - 193221 != 103472)
							{
								continue;
							}
						}
						if (this.$mStoryGui$37324)
						{
							if (159107 - 53022 != 106085)
							{
								continue;
							}
							this.$mStoryGui$37324.close();
							if (124556 - 451189 != -326633)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (33741 - 139237 != -105495)
						{
							goto Block_3;
						}
						continue;
					default:
						if (152875 - 331685 != -178810)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$37325[31]);
					if (143908 - 208445 != -64536)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (228608 - 494164 == -265556)
							{
								goto IL_32D;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (235976 - 400186 == -164210)
							{
								this.$result$37321 = RuntimeServices.UnboxInt32(this.$data$37325[31]);
								if (45943 - 3478 == 42465)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_3:
				IL_32D:
				IL_352:
				return false;
			}

			// Token: 0x06007092 RID: 28818 RVA: 0x00F76828 File Offset: 0x00F74A28
			internal static bool EgAtpBpgdp7IL4KPXsJk()
			{
				return true;
			}

			// Token: 0x06007093 RID: 28819 RVA: 0x00F7682C File Offset: 0x00F74A2C
			internal static bool pvMoFepgJcuVmTtTcDDe()
			{
				return false;
			}

			// Token: 0x0400771F RID: 30495
			internal int $result$37321;

			// Token: 0x04007720 RID: 30496
			internal CompleteGui $mCompleteGui$37322;

			// Token: 0x04007721 RID: 30497
			internal GameGui $mGameGui$37323;

			// Token: 0x04007722 RID: 30498
			internal StoryGui $mStoryGui$37324;

			// Token: 0x04007723 RID: 30499
			internal Hashtable $data$37325;

			// Token: 0x04007724 RID: 30500
			internal M103_BugTrouble $self_$37326;
		}
	}

	// Token: 0x02001318 RID: 4888
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$37329 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007094 RID: 28820 RVA: 0x00F76830 File Offset: 0x00F74A30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$37329(M103_BugTrouble self_)
		{
			if (293226 - 544206 != -250980)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (123819 - 191227 != -67407)
				{
					base..ctor();
					if (272586 - 462833 != -190246)
					{
						this.$self_$37332 = self_;
						if (152508 - 413049 != -260540)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007095 RID: 28821 RVA: 0x00F768C8 File Offset: 0x00F74AC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M103_BugTrouble.$StartGame$37329.$(this.$self_$37332);
		}

		// Token: 0x06007096 RID: 28822 RVA: 0x00F768D8 File Offset: 0x00F74AD8
		internal static bool NrHe1kpgDp4TUuA6cqa0()
		{
			return true;
		}

		// Token: 0x06007097 RID: 28823 RVA: 0x00F768DC File Offset: 0x00F74ADC
		internal static bool YfvBqopgvj5aH5Ra5qgJ()
		{
			return false;
		}

		// Token: 0x04007725 RID: 30501
		internal M103_BugTrouble $self_$37332;

		// Token: 0x02001319 RID: 4889
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007098 RID: 28824 RVA: 0x00F768E0 File Offset: 0x00F74AE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M103_BugTrouble self_)
			{
				if (180674 - 529562 != -348888)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (258184 - 75728 == 182456)
					{
						base..ctor();
						if (188373 - 576799 != -388425)
						{
							this.$self_$37331 = self_;
							if (25568 - 151860 == -126292)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007099 RID: 28825 RVA: 0x00F76978 File Offset: 0x00F74B78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (40781 - 128044 != -87263)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_26C;
					case 2:
						this.$mGameGui$37330 = (GameGui)this.$self_$37331.GetComponent(typeof(GameGui));
						if (101193 - 121089 == -19895)
						{
							continue;
						}
						this.$mGameGui$37330.enabled = true;
						if (208511 - 128842 != 79669)
						{
							continue;
						}
						this.$self_$37331.CFmc8c0GrmN.enabled = true;
						if (261613 - 4176 == 257438)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (152657 - 408501 != -255844)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (29012 - 435351 != -406339)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (175030 - 307390 == -132359)
						{
							continue;
						}
						if (this.$self_$37331.mgJc8ewvWNG)
						{
							if (126523 - 72734 != 53789)
							{
								continue;
							}
							this.$self_$37331.audio.PlayOneShot(this.$self_$37331.mgJc8ewvWNG);
							if (24642 - 461019 != -436377)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (214176 - 363702 != -149526)
						{
							continue;
						}
						goto IL_26C;
					default:
						if (191214 - 539965 != -348751)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (175631 - 257753 == -82122)
					{
						Game.mGameState = eGameState.Start;
						if (279491 - 304181 == -24690)
						{
							Game.mStateTime = Time.time;
							if (64886 - 88598 != -23711)
							{
								this.$self_$37331.SendMessage("fadeIn");
								if (211203 - 276775 == -65572)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_26C:
				return false;
			}

			// Token: 0x0600709A RID: 28826 RVA: 0x00F76C04 File Offset: 0x00F74E04
			internal static bool CGuA0gpgRavaSQ5YmxDP()
			{
				return true;
			}

			// Token: 0x0600709B RID: 28827 RVA: 0x00F76C08 File Offset: 0x00F74E08
			internal static bool KiuXMtpgwDRmi3pEB9v6()
			{
				return false;
			}

			// Token: 0x04007726 RID: 30502
			internal GameGui $mGameGui$37330;

			// Token: 0x04007727 RID: 30503
			internal M103_BugTrouble $self_$37331;
		}
	}

	// Token: 0x0200131A RID: 4890
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$37333 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600709C RID: 28828 RVA: 0x00F76C0C File Offset: 0x00F74E0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$37333(Hashtable data, M103_BugTrouble self_)
		{
			if (169499 - 159509 != 9991)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (176344 - 65203 == 111141)
				{
					base..ctor();
					if (149979 - 116103 != 33877)
					{
						this.$data$37338 = data;
						if (233297 - 233661 == -364)
						{
							this.$self_$37339 = self_;
							if (166951 - 555711 != -388759)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600709D RID: 28829 RVA: 0x00F76CC8 File Offset: 0x00F74EC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M103_BugTrouble.$onChangePlayer$37333.$(this.$data$37338, this.$self_$37339);
		}

		// Token: 0x0600709E RID: 28830 RVA: 0x00F76CDC File Offset: 0x00F74EDC
		internal static bool mVuiPQpgqbKNyql697U0()
		{
			return true;
		}

		// Token: 0x0600709F RID: 28831 RVA: 0x00F76CE0 File Offset: 0x00F74EE0
		internal static bool PMfMw1pg7dCFA1UiphPJ()
		{
			return false;
		}

		// Token: 0x04007728 RID: 30504
		internal Hashtable $data$37338;

		// Token: 0x04007729 RID: 30505
		internal M103_BugTrouble $self_$37339;

		// Token: 0x0200131B RID: 4891
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060070A0 RID: 28832 RVA: 0x00F76CE4 File Offset: 0x00F74EE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M103_BugTrouble self_)
			{
				if (70065 - 269882 != -199817)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (283432 - 364802 == -81370)
					{
						base..ctor();
						if (237415 - 522137 == -284722)
						{
							this.$data$37336 = data;
							if (26934 - 73187 != -46252)
							{
								this.$self_$37337 = self_;
								if (106142 - 345657 == -239515)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060070A1 RID: 28833 RVA: 0x00F76DA0 File Offset: 0x00F74FA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (103053 - 35186 != 67867)
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
							if (11993 - 460494 == -448500)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (77336 - 348619 == -271282)
							{
								continue;
							}
							this.$mGameGui$37335 = (GameGui)this.$self_$37337.GetComponent(typeof(GameGui));
							if (286616 - 164065 != 122551)
							{
								continue;
							}
							this.$mGameGui$37335.enabled = true;
							if (250617 - 305504 == -54886)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (293726 - 484221 != -190495)
						{
							continue;
						}
						goto IL_205;
					default:
						if (103231 - 329220 != -225989)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (23804 - 578432 == -554628)
					{
						this.$self_$37337.SendMessage("onCreatePlayer", this.$data$37336);
						if (105362 - 480310 == -374948)
						{
							this.$mChangeGui$37334 = (ChangeGui)this.$self_$37337.GetComponent(typeof(ChangeGui));
							if (73124 - 83008 != -9883)
							{
								if (!this.$mChangeGui$37334.enabled)
								{
									break;
								}
								if (5064 - 22037 == -16973)
								{
									this.$mChangeGui$37334.close();
									if (291682 - 258872 != 32811)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_1A:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_1A;
				IL_205:
				return false;
			}

			// Token: 0x060070A2 RID: 28834 RVA: 0x00F76FC4 File Offset: 0x00F751C4
			internal static bool VpnGCBpgPnGmjJuiKuTZ()
			{
				return true;
			}

			// Token: 0x060070A3 RID: 28835 RVA: 0x00F76FC8 File Offset: 0x00F751C8
			internal static bool cGbdxnpg0MoBia3rHPCC()
			{
				return false;
			}

			// Token: 0x0400772A RID: 30506
			internal ChangeGui $mChangeGui$37334;

			// Token: 0x0400772B RID: 30507
			internal GameGui $mGameGui$37335;

			// Token: 0x0400772C RID: 30508
			internal Hashtable $data$37336;

			// Token: 0x0400772D RID: 30509
			internal M103_BugTrouble $self_$37337;
		}
	}

	// Token: 0x0200131C RID: 4892
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$37340 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060070A4 RID: 28836 RVA: 0x00F76FCC File Offset: 0x00F751CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$37340(M103_BugTrouble self_)
		{
			if (13396 - 499473 != -486077)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (267635 - 367226 != -99590)
				{
					base..ctor();
					if (6128 - 559170 == -553042)
					{
						this.$self_$37345 = self_;
						if (16754 - 519144 != -502389)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060070A5 RID: 28837 RVA: 0x00F77064 File Offset: 0x00F75264
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M103_BugTrouble.$onDeadPlayer$37340.$(this.$self_$37345);
		}

		// Token: 0x060070A6 RID: 28838 RVA: 0x00F77074 File Offset: 0x00F75274
		internal static bool mNHfLrpgbDaXk4jAtHtk()
		{
			return true;
		}

		// Token: 0x060070A7 RID: 28839 RVA: 0x00F77078 File Offset: 0x00F75278
		internal static bool S7doe5pguyXKyDfH4LMh()
		{
			return false;
		}

		// Token: 0x0400772E RID: 30510
		internal M103_BugTrouble $self_$37345;

		// Token: 0x0200131D RID: 4893
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060070A8 RID: 28840 RVA: 0x00F7707C File Offset: 0x00F7527C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M103_BugTrouble self_)
			{
				if (95714 - 502113 != -406399)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (257490 - 533822 == -276332)
					{
						base..ctor();
						if (145120 - 254608 == -109488)
						{
							this.$self_$37344 = self_;
							if (200126 - 229447 == -29321)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060070A9 RID: 28841 RVA: 0x00F77114 File Offset: 0x00F75314
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (261775 - 260145 != 1630)
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
							goto IL_28A;
						}
						if (105768 - 383415 != -277647)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (128598 - 143049 != -14451)
							{
								continue;
							}
							goto IL_28A;
						}
						IL_243:
						this.YieldDefault(1);
						if (186854 - 256473 != -69619)
						{
							continue;
						}
						goto IL_2F9;
						IL_28A:
						Game.mGameState = eGameState.Hold;
						if (78131 - 476007 == -397875)
						{
							continue;
						}
						this.$mStoryGui$37341 = (StoryGui)this.$self_$37344.GetComponent(typeof(StoryGui));
						if (100066 - 278776 != -178710)
						{
							continue;
						}
						if (this.$mStoryGui$37341)
						{
							if (224898 - 575331 == -350432)
							{
								continue;
							}
							this.$mStoryGui$37341.close();
							if (182682 - 249031 == -66348)
							{
								continue;
							}
						}
						this.$mChangeGui$37342 = (ChangeGui)this.$self_$37344.GetComponent(typeof(ChangeGui));
						if (135938 - 570808 == -434869)
						{
							continue;
						}
						if (this.$mChangeGui$37342)
						{
							if (160333 - 599015 != -438682)
							{
								continue;
							}
							this.$mChangeGui$37342.close();
							if (6809 - 14514 == -7704)
							{
								continue;
							}
						}
						this.$mGameGui$37343 = (GameGui)this.$self_$37344.GetComponent(typeof(GameGui));
						if (281286 - 320641 == -39354)
						{
							continue;
						}
						if (!this.$mGameGui$37343)
						{
							goto IL_243;
						}
						if (265432 - 103171 == 162262)
						{
							continue;
						}
						if (!this.$mGameGui$37343.enabled)
						{
							if (217204 - 223216 != -6012)
							{
								continue;
							}
							this.$mGameGui$37343.enabled = true;
							if (31929 - 238074 == -206144)
							{
								continue;
							}
						}
						this.$mGameGui$37343.openDeadMenu();
						if (213759 - 200680 != 13079)
						{
							continue;
						}
						goto IL_243;
					default:
						if (48258 - 588098 != -539840)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (88578 - 38709 == 49870);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x060070AA RID: 28842 RVA: 0x00F7742C File Offset: 0x00F7562C
			internal static bool fSCqr4pgIifmMK7DFfbH()
			{
				return true;
			}

			// Token: 0x060070AB RID: 28843 RVA: 0x00F77430 File Offset: 0x00F75630
			internal static bool qU7ZhEpgByaHkDVA1KDW()
			{
				return false;
			}

			// Token: 0x0400772F RID: 30511
			internal StoryGui $mStoryGui$37341;

			// Token: 0x04007730 RID: 30512
			internal ChangeGui $mChangeGui$37342;

			// Token: 0x04007731 RID: 30513
			internal GameGui $mGameGui$37343;

			// Token: 0x04007732 RID: 30514
			internal M103_BugTrouble $self_$37344;
		}
	}

	// Token: 0x0200131E RID: 4894
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$37346 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060070AC RID: 28844 RVA: 0x00F77434 File Offset: 0x00F75634
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$37346(M103_BugTrouble self_)
		{
			if (160957 - 103894 != 57063)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (79842 - 3611 != 76232)
				{
					base..ctor();
					if (199771 - 525986 == -326215)
					{
						this.$self_$37350 = self_;
						if (108832 - 121264 == -12432)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060070AD RID: 28845 RVA: 0x00F774CC File Offset: 0x00F756CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M103_BugTrouble.$ReturnToTown$37346.$(this.$self_$37350);
		}

		// Token: 0x060070AE RID: 28846 RVA: 0x00F774DC File Offset: 0x00F756DC
		internal static bool JOOsWMpgeR1ILY4XMDyJ()
		{
			return true;
		}

		// Token: 0x060070AF RID: 28847 RVA: 0x00F774E0 File Offset: 0x00F756E0
		internal static bool hjjJ5Npgrq4lXHlVgs0v()
		{
			return false;
		}

		// Token: 0x04007733 RID: 30515
		internal M103_BugTrouble $self_$37350;

		// Token: 0x0200131F RID: 4895
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060070B0 RID: 28848 RVA: 0x00F774E4 File Offset: 0x00F756E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M103_BugTrouble self_)
			{
				if (236711 - 375966 != -139254)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (82058 - 292358 != -210299)
					{
						base..ctor();
						if (24795 - 291070 == -266275)
						{
							this.$self_$37349 = self_;
							if (270442 - 425737 == -155295)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060070B1 RID: 28849 RVA: 0x00F7757C File Offset: 0x00F7577C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (246104 - 29765 != 216340)
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
						this.$self_$37349.LeaveGame();
						if (144525 - 488508 == -343982)
						{
							continue;
						}
						this.YieldDefault(1);
						if (169076 - 272260 != -103183)
						{
							goto Block_3;
						}
						continue;
					default:
						if (2627 - 456931 != -454304)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (70153 - 503985 != -433831)
					{
						Game.mStateTime = Time.time;
						if (38464 - 568325 == -529861)
						{
							this.$$switch$6288$37347 = PlayerData.SaveGuild;
							if (144205 - 479160 != -334954)
							{
								if (this.$$switch$6288$37347 == 1)
								{
									if (103240 - 194610 != -91370)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (233368 - 204711 == 28658)
									{
										continue;
									}
								}
								else if (this.$$switch$6288$37347 == 2)
								{
									if (118206 - 306693 == -188486)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (74664 - 412345 == -337680)
									{
										continue;
									}
								}
								else if (this.$$switch$6288$37347 == 3)
								{
									if (274198 - 232381 != 41817)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (7089 - 120733 != -113644)
									{
										continue;
									}
								}
								else if (this.$$switch$6288$37347 == 4)
								{
									if (63545 - 202519 == -138973)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (99511 - 409411 == -309899)
									{
										continue;
									}
								}
								else if (this.$$switch$6288$37347 == 5)
								{
									if (166070 - 332731 != -166661)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (121452 - 223466 == -102013)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (9539 - 264368 == -254828)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (210706 - 384973 != -174267)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (210587 - 249122 != -38535)
									{
										continue;
									}
								}
								this.$mGameGui$37348 = (GameGui)this.$self_$37349.GetComponent(typeof(GameGui));
								if (41752 - 29682 == 12070)
								{
									if (this.$mGameGui$37348)
									{
										if (4079 - 93296 == -89216)
										{
											continue;
										}
										this.$mGameGui$37348.close();
										if (206750 - 248870 == -42119)
										{
											continue;
										}
									}
									this.$self_$37349.SendMessage("fadeOut");
									if (259345 - 18339 != 241007)
									{
										goto Block_16;
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_3AD;
				Block_16:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x060070B2 RID: 28850 RVA: 0x00F77948 File Offset: 0x00F75B48
			internal static bool KGG7uapgjNEJGRbpsncv()
			{
				return true;
			}

			// Token: 0x060070B3 RID: 28851 RVA: 0x00F7794C File Offset: 0x00F75B4C
			internal static bool gheWhypghKgxgSZ56pIh()
			{
				return false;
			}

			// Token: 0x04007734 RID: 30516
			internal int $$switch$6288$37347;

			// Token: 0x04007735 RID: 30517
			internal GameGui $mGameGui$37348;

			// Token: 0x04007736 RID: 30518
			internal M103_BugTrouble $self_$37349;
		}
	}

	// Token: 0x02001320 RID: 4896
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$37351 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060070B4 RID: 28852 RVA: 0x00F77950 File Offset: 0x00F75B50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$37351(M103_BugTrouble self_)
		{
			if (133096 - 1776 != 131321)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (24743 - 599154 != -574410)
				{
					base..ctor();
					if (215870 - 167314 == 48556)
					{
						this.$self_$37354 = self_;
						if (152169 - 350019 == -197850)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060070B5 RID: 28853 RVA: 0x00F779E8 File Offset: 0x00F75BE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M103_BugTrouble.$ReturnToGuild$37351.$(this.$self_$37354);
		}

		// Token: 0x060070B6 RID: 28854 RVA: 0x00F779F8 File Offset: 0x00F75BF8
		internal static bool yKeJ7ipgssHNsQHH93Id()
		{
			return true;
		}

		// Token: 0x060070B7 RID: 28855 RVA: 0x00F779FC File Offset: 0x00F75BFC
		internal static bool AWhGiKpg9qYQgAB2sMfk()
		{
			return false;
		}

		// Token: 0x04007737 RID: 30519
		internal M103_BugTrouble $self_$37354;

		// Token: 0x02001321 RID: 4897
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060070B8 RID: 28856 RVA: 0x00F77A00 File Offset: 0x00F75C00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M103_BugTrouble self_)
			{
				if (126902 - 18210 != 108692)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (24689 - 95219 == -70530)
					{
						base..ctor();
						if (150560 - 74403 != 76158)
						{
							this.$self_$37353 = self_;
							if (66422 - 249261 != -182838)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060070B9 RID: 28857 RVA: 0x00F77A98 File Offset: 0x00F75C98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (90398 - 57477 != 32922)
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
						this.$self_$37353.LeaveGame();
						if (46667 - 490495 != -443828)
						{
							continue;
						}
						this.YieldDefault(1);
						if (201050 - 59329 != 141721)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (196294 - 574920 == -378625)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (12136 - 388142 == -376006)
					{
						Game.mStateTime = Time.time;
						if (244527 - 6910 != 237618)
						{
							Game.mNextGameCode = 31;
							if (96796 - 479403 != -382606)
							{
								this.$mGameGui$37352 = (GameGui)this.$self_$37353.GetComponent(typeof(GameGui));
								if (206110 - 113110 != 93001)
								{
									if (this.$mGameGui$37352)
									{
										if (153333 - 79347 != 73986)
										{
											continue;
										}
										this.$mGameGui$37352.close();
										if (176275 - 499639 == -323363)
										{
											continue;
										}
									}
									this.$self_$37353.SendMessage("fadeOut");
									if (256519 - 104097 != 152423)
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

			// Token: 0x060070BA RID: 28858 RVA: 0x00F77C74 File Offset: 0x00F75E74
			internal static bool RbuNpcpg1vthFutZCG68()
			{
				return true;
			}

			// Token: 0x060070BB RID: 28859 RVA: 0x00F77C78 File Offset: 0x00F75E78
			internal static bool voCHPPpg4MN8ZuyI9uFQ()
			{
				return false;
			}

			// Token: 0x04007738 RID: 30520
			internal GameGui $mGameGui$37352;

			// Token: 0x04007739 RID: 30521
			internal M103_BugTrouble $self_$37353;
		}
	}

	// Token: 0x02001322 RID: 4898
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$37355 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060070BC RID: 28860 RVA: 0x00F77C7C File Offset: 0x00F75E7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$37355(M103_BugTrouble self_)
		{
			if (24936 - 92994 != -68058)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (200108 - 313294 != -113185)
				{
					base..ctor();
					if (230826 - 294539 == -63713)
					{
						this.$self_$37359 = self_;
						if (241851 - 483182 == -241331)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060070BD RID: 28861 RVA: 0x00F77D14 File Offset: 0x00F75F14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M103_BugTrouble.$ReturnToCamp$37355.$(this.$self_$37359);
		}

		// Token: 0x060070BE RID: 28862 RVA: 0x00F77D24 File Offset: 0x00F75F24
		internal static bool IiJQJcpgzmlXpSnZCQlt()
		{
			return true;
		}

		// Token: 0x060070BF RID: 28863 RVA: 0x00F77D28 File Offset: 0x00F75F28
		internal static bool f2yLNgpfa9awTxi4Dv7r()
		{
			return false;
		}

		// Token: 0x0400773A RID: 30522
		internal M103_BugTrouble $self_$37359;

		// Token: 0x02001323 RID: 4899
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060070C0 RID: 28864 RVA: 0x00F77D2C File Offset: 0x00F75F2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M103_BugTrouble self_)
			{
				if (110985 - 46458 != 64527)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (236844 - 144347 == 92497)
					{
						base..ctor();
						if (47706 - 132617 == -84911)
						{
							this.$self_$37358 = self_;
							if (132984 - 575401 == -442417)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060070C1 RID: 28865 RVA: 0x00F77DC4 File Offset: 0x00F75FC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (13683 - 92310 != -78627)
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
						this.$self_$37358.LeaveGame();
						if (262780 - 351483 == -88702)
						{
							continue;
						}
						this.YieldDefault(1);
						if (100981 - 217918 != -116936)
						{
							goto Block_23;
						}
						continue;
					default:
						if (59468 - 194841 != -135373)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (69139 - 564103 != -494963)
					{
						Game.mStateTime = Time.time;
						if (189889 - 242398 == -52509)
						{
							this.$$switch$6290$37356 = PlayerData.SaveGuild;
							if (73614 - 478129 == -404515)
							{
								if (this.$$switch$6290$37356 == 1)
								{
									if (206857 - 10873 != 195984)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (79313 - 505022 != -425709)
									{
										continue;
									}
								}
								else if (this.$$switch$6290$37356 == 2)
								{
									if (18449 - 148816 != -130367)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (217692 - 163374 == 54319)
									{
										continue;
									}
								}
								else if (this.$$switch$6290$37356 == 3)
								{
									if (72326 - 362884 != -290558)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (181927 - 58767 == 123161)
									{
										continue;
									}
								}
								else if (this.$$switch$6290$37356 == 4)
								{
									if (297251 - 345613 == -48361)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (226484 - 516 == 225969)
									{
										continue;
									}
								}
								else if (this.$$switch$6290$37356 == 5)
								{
									if (241181 - 110126 == 131056)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (33988 - 390092 != -356104)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (205050 - 425490 == -220439)
									{
										continue;
									}
								}
								this.$mGameGui$37357 = (GameGui)this.$self_$37358.GetComponent(typeof(GameGui));
								if (89099 - 121028 == -31929)
								{
									if (this.$mGameGui$37357)
									{
										if (215573 - 436348 != -220775)
										{
											continue;
										}
										this.$mGameGui$37357.close();
										if (200979 - 433897 != -232918)
										{
											continue;
										}
									}
									this.$self_$37358.SendMessage("fadeOut");
									if (94649 - 595907 != -501257)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_23:
				IL_363:
				return false;
			}

			// Token: 0x060070C2 RID: 28866 RVA: 0x00F78148 File Offset: 0x00F76348
			internal static bool lIlYxWpf59PCRyg67rGl()
			{
				return true;
			}

			// Token: 0x060070C3 RID: 28867 RVA: 0x00F7814C File Offset: 0x00F7634C
			internal static bool wuLj73pfpDXH0oZ8RNpk()
			{
				return false;
			}

			// Token: 0x0400773B RID: 30523
			internal int $$switch$6290$37356;

			// Token: 0x0400773C RID: 30524
			internal GameGui $mGameGui$37357;

			// Token: 0x0400773D RID: 30525
			internal M103_BugTrouble $self_$37358;
		}
	}
}
