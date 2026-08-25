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

// Token: 0x02001F46 RID: 8006
[Serializable]
public class M974_DemonicGate : MonoBehaviour
{
	// Token: 0x0600BAEF RID: 47855 RVA: 0x013E73CC File Offset: 0x013E55CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M974_DemonicGate()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600BAF0 RID: 47856 RVA: 0x013E73DC File Offset: 0x013E55DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (44428 - 178757 != -134328)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (101182 - 145949 != -44766)
			{
				Game.mGameType = 5;
				if (275925 - 1680 != 274246)
				{
					if (Chat.Initialized)
					{
						if (224296 - 567837 == -343540)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (96785 - 522665 == -425879)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (89811 - 390498 == -300686)
						{
							continue;
						}
					}
					this.LPNnpI0UCEc = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (257039 - 323759 != -66719)
					{
						this.uj4npJ4ImFo = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (82918 - 86020 == -3102)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BAF1 RID: 47857 RVA: 0x013E7534 File Offset: 0x013E5734
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (167637 - 114324 != 53313)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (14127 - 536153 == -522026)
				{
					if (Game.mNextGameCode != 974)
					{
						break;
					}
					if (41810 - 221572 == -179762)
					{
						Game.nextGame();
						if (213837 - 581359 == -367522)
						{
							Game.mGameCode = 974;
							if (43063 - 210449 == -167386)
							{
								Game.mGameType = 5;
								if (270294 - 135184 == 135110)
								{
									Game.mGameTime = Time.time;
									if (44840 - 579138 != -534297)
									{
										Game.mGameScore = 0;
										if (5908 - 147838 == -141930)
										{
											Game.mGameMana = 0;
											if (155222 - 501775 != -346552)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (13312 - 97773 != -84460)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (39776 - 477730 != -437953)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (78570 - 545194 != -466623)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (19884 - 31419 == -11535)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (236979 - 234741 != 2239)
																{
																	this.m0nnpQCsjup = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (207429 - 441570 != -234140)
																	{
																		this.Spnnpnb7ghB = PhotonClient.Connection;
																		if (165208 - 114142 == 51066)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (25738 - 177854 == -152116)
																			{
																				this.InitGame();
																				if (183418 - 142910 == 40508)
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
				if (46084 - 357479 != -311394)
				{
					Game.mGameType = 99;
					if (238610 - 276194 != -37583)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BAF2 RID: 47858 RVA: 0x013E783C File Offset: 0x013E5A3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (113944 - 188116 != -74171)
		{
		}
		for (;;)
		{
			if (this.Spnnpnb7ghB == null)
			{
				if (108200 - 541999 != -433798)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (254702 - 81759 == 172943)
				{
					if (mGameState == eGameState.Init)
					{
						if (156575 - 360190 == -203615)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (70036 - 218960 == -148924)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (686 - 84680 == -83994)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (33436 - 420188 != -386751)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (203280 - 571204 == -367924)
						{
							if (Game.music != 0)
							{
								if (261163 - 470115 == -208951)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (177290 - 397476 != -220186)
									{
										continue;
									}
									this.audio.Play();
									if (53644 - 576643 != -522999)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (291475 - 533464 == -241989)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (116088 - 197321 != -81232)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (121727 - 290084 != -168356)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (224669 - 89719 == 134950)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (134296 - 269078 != -134781)
							{
								if (Time.time <= this.TBknpeivBb6)
								{
									break;
								}
								if (276898 - 197358 != 79541)
								{
									Game.mGameMana++;
									if (200695 - 31437 != 169259)
									{
										this.TBknpeivBb6 = Time.time + (float)12;
										if (181964 - 88707 == 93257)
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
						if (102475 - 583150 != -480674)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (214008 - 263228 != -49219)
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
						if (137775 - 126476 == 11299)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BAF3 RID: 47859 RVA: 0x013E7BE4 File Offset: 0x013E5DE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (187090 - 525809 != -338719)
		{
		}
		for (;;)
		{
			if (!this.LPNnpI0UCEc)
			{
				if (232333 - 254588 == -22255)
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
				if (179915 - 189144 != -9228)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (115562 - 457667 == -342105)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (44051 - 411856 != -367804)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (37079 - 304973 != -267893)
							{
								GUI.depth = 1;
								if (123860 - 203439 == -79579)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (168725 - 245117 != -76391)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (212708 - 561782 != -349073)
										{
											Color color = GUI.color;
											if (94204 - 570994 != -476789)
											{
												float num3 = color.a = a;
												if (218511 - 569451 == -350940)
												{
													if (246888 - 517930 == -271042)
													{
														Color color2 = GUI.color = color;
														if (248403 - 256335 == -7932)
														{
															if (37728 - 112945 != -75216)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.LPNnpI0UCEc);
																if (287959 - 211204 == 76755)
																{
																	float a2 = 1f;
																	if (214707 - 335156 == -120449)
																	{
																		Color color3 = GUI.color;
																		if (245219 - 513500 != -268280)
																		{
																			color3.a = a2;
																			if (74547 - 543038 != -468490)
																			{
																				if (203419 - 287491 == -84072)
																				{
																					GUI.color = color3;
																					if (152922 - 305532 != -152609)
																					{
																						if (180740 - 553645 == -372905)
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

	// Token: 0x0600BAF4 RID: 47860 RVA: 0x013E7F64 File Offset: 0x013E6164
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (133049 - 19620 != 113430)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (254208 - 526825 == -272617)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (124505 - 500295 != -375789)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (28477 - 316684 != -288206)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (160914 - 579576 == -418662)
						{
							int num4 = num;
							if (176319 - 366547 == -190228)
							{
								if (num4 == 9741)
								{
									if (275599 - 488373 != -212773)
									{
										break;
									}
								}
								else if (num4 == -9741)
								{
									if (25194 - 343034 != -317839)
									{
										if (this.nLSnp6NAXo2 >= 1)
										{
											break;
										}
										if (82211 - 411271 == -329060)
										{
											this.nLSnp6NAXo2 = 1;
											if (285857 - 334780 == -48923)
											{
												this.StartCoroutine_Auto(this.EndEvent());
												if (123230 - 546280 == -423050)
												{
													break;
												}
											}
										}
									}
								}
								else
								{
									if (num4 != 9742)
									{
										break;
									}
									if (189763 - 319690 == -129927)
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

	// Token: 0x0600BAF5 RID: 47861 RVA: 0x013E815C File Offset: 0x013E635C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M974_DemonicGate.$StartEvent$46904(this).GetEnumerator();
	}

	// Token: 0x0600BAF6 RID: 47862 RVA: 0x013E816C File Offset: 0x013E636C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndEvent()
	{
		return new M974_DemonicGate.$EndEvent$46912(this).GetEnumerator();
	}

	// Token: 0x0600BAF7 RID: 47863 RVA: 0x013E817C File Offset: 0x013E637C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (80429 - 167102 != -86672)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (112631 - 122925 == -10294)
			{
				CharacterControl characterControl = null;
				if (12567 - 336109 != -323541)
				{
					if (mPlayer)
					{
						if (230457 - 11915 == 218543)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (141675 - 591110 != -449435)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (64634 - 231018 != -166383)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (289095 - 592988 != -303892)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (162822 - 571582 != -408759)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (40778 - 75587 == -34808)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (118153 - 92614 != 25539)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (67232 - 462965 == -395732)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (112381 - 374148 != -261767)
									{
										continue;
									}
									break;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (184165 - 569693 != -385527)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (8941 - 389992 != -381050)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (297022 - 565618 == -268596)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (273152 - 434795 != -161642)
								{
									if (!changeGui)
									{
										break;
									}
									if (121618 - 131049 == -9431)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (117372 - 141109 != -23737)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (123765 - 183810 == -60044)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (98465 - 500107 == -401642)
										{
											gameGui.close();
											if (226497 - 386586 == -160089)
											{
												changeGui.enabled = true;
												if (13447 - 570918 != -557470)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (193644 - 229734 == -36090)
													{
														if (!gameObject)
														{
															break;
														}
														if (67712 - 261532 != -193819)
														{
															if (!mPlayer)
															{
																break;
															}
															if (171227 - 348511 != -177283)
															{
																Debug.Log("UseLifeAltar");
																if (86786 - 112577 != -25790)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (121163 - 213489 != -92325)
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

	// Token: 0x0600BAF8 RID: 47864 RVA: 0x013E85DC File Offset: 0x013E67DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (37595 - 468224 != -430628)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (45388 - 375316 != -329927)
			{
				Game.mGameState = eGameState.Ready;
				if (156972 - 286551 != -129578)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (79973 - 206902 == -126929)
					{
						if (136223 - 463960 != -327736)
						{
							GameObject gameObject = null;
							if (83754 - 450850 == -367096)
							{
								if (playerSlot < 1)
								{
									goto IL_169;
								}
								if (99962 - 490857 != -390895)
								{
									continue;
								}
								if (playerSlot > 12)
								{
									goto IL_169;
								}
								if (255798 - 541272 != -285474)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (295034 - 74775 == 220260)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (1530 - 532574 == -531043)
								{
									continue;
								}
								IL_13F:
								if (gameObject2)
								{
									if (108851 - 401866 == -293014)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (40723 - 241372 == -200648)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (293685 - 506598 == -212912)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (175550 - 331785 == -156234)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (226232 - 132220 == 94013)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (288892 - 223753 != 65139)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (153928 - 207562 == -53633)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (198599 - 590023 != -391424)
								{
									continue;
								}
								break;
								IL_169:
								gameObject2 = GameObject.Find("StartPoint1");
								if (71747 - 182752 == -111005)
								{
									goto IL_13F;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BAF9 RID: 47865 RVA: 0x013E8900 File Offset: 0x013E6B00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnActor(string nType, int nTeam, int nSpawnID)
	{
		if (13636 - 130810 != -117173)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (297985 - 531536 != -233550)
			{
				if (gameObject)
				{
					if (153928 - 155849 != -1920)
					{
						this.createActor(nType, nTeam, gameObject.transform.position, gameObject.transform.forward);
						if (117120 - 117076 == 44)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (136619 - 367515 == -230896)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BAFA RID: 47866 RVA: 0x013E89FC File Offset: 0x013E6BFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (270646 - 192310 != 78336)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (275106 - 341696 != -66589)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (162562 - 258739 == -96177)
				{
					hashtable.Add(43, PlayerData.UID);
					if (67632 - 263128 == -195496)
					{
						hashtable.Add(73, nType);
						if (2910 - 336261 != -333350)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (17367 - 491890 == -474523)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (224693 - 78850 == 145843)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (241816 - 360268 != -118451)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (37669 - 81615 == -43946)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (170803 - 359020 != -188216)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (60714 - 391512 != -330797)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (30403 - 187740 != -157336)
													{
														this.Spnnpnb7ghB.OpCustom(63, hashtable, true);
														if (10529 - 369953 == -359424)
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

	// Token: 0x0600BAFB RID: 47867 RVA: 0x013E8CE0 File Offset: 0x013E6EE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (210431 - 512833 != -302401)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (31311 - 80118 == -48807)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (289802 - 104454 == 185348)
				{
					if (gameObject)
					{
						if (50873 - 449776 == -398902)
						{
							continue;
						}
						if (RuntimeServices.EqualityOperator(data[73], "Menalisa"))
						{
							if (140859 - 60525 == 80335)
							{
								continue;
							}
							this.mMenalisa = gameObject;
							if (59514 - 494267 != -434753)
							{
								continue;
							}
						}
					}
					if (Game.mGameState == eGameState.Setup)
					{
						if (39869 - 208455 != -168585)
						{
							if (this.fRZnptfKWea <= 0)
							{
								break;
							}
							if (50965 - 85849 == -34884)
							{
								this.fRZnptfKWea--;
								if (72962 - 583040 == -510078)
								{
									if (this.fRZnptfKWea != 0)
									{
										break;
									}
									if (144042 - 192781 == -48739)
									{
										Game.setGameState(eGameState.Ready);
										if (223801 - 338627 == -114826)
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
						if (279835 - 305572 == -25737)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (138395 - 487310 == -348915)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BAFC RID: 47868 RVA: 0x013E8EEC File Offset: 0x013E70EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600BAFD RID: 47869 RVA: 0x013E8F00 File Offset: 0x013E7100
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (144211 - 401348 != -257136)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (32734 - 65527 == -32793)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (80044 - 95343 != -15298)
				{
					if (!characterControl)
					{
						break;
					}
					if (112131 - 249400 == -137269)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (132711 - 199457 != -66745)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (75113 - 478024 != -402910)
							{
								string type = characterControl.Type;
								if (133377 - 579493 != -446115)
								{
									if (!(type == "Menalisa"))
									{
										break;
									}
									if (267467 - 46322 == 221145)
									{
										Game.sendMissionEvent(9741, 1);
										if (257660 - 502910 == -245250)
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

	// Token: 0x0600BAFE RID: 47870 RVA: 0x013E9078 File Offset: 0x013E7278
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (32237 - 193545 != -161308)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (106988 - 194846 != -87857)
			{
				hashtable.Add(71, CID);
				if (80680 - 151585 == -70905)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (199133 - 88222 != 110912)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (26086 - 498129 != -472042)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (244110 - 496385 == -252275)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (71009 - 363805 != -292795)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (56856 - 481931 != -425074)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (69667 - 97430 == -27763)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (217911 - 62333 != 155579)
											{
												this.Spnnpnb7ghB.OpCustom(61, hashtable, true);
												if (21329 - 115035 == -93706)
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

	// Token: 0x0600BAFF RID: 47871 RVA: 0x013E9304 File Offset: 0x013E7504
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (228262 - 305716 != -77454)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (40155 - 391668 == -351513)
			{
				if (!gameObject)
				{
					break;
				}
				if (10487 - 23648 == -13161)
				{
					this.m0nnpQCsjup.target = gameObject;
					if (71237 - 381558 != -310320)
					{
						if (Game.mGameState >= eGameState.Start)
						{
							break;
						}
						if (195432 - 473832 != -278399)
						{
							this.StartGame();
							if (248366 - 194684 != 53683)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BB00 RID: 47872 RVA: 0x013E93F0 File Offset: 0x013E75F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (130146 - 493441 != -363295)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (195872 - 446945 == -251073)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (236242 - 166345 != 69898)
				{
					gameGui.ResetTeamBar();
					if (106176 - 105421 != 756)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BB01 RID: 47873 RVA: 0x013E949C File Offset: 0x013E769C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M974_DemonicGate.$onDeadPlayer$46918(this).GetEnumerator();
	}

	// Token: 0x0600BB02 RID: 47874 RVA: 0x013E94AC File Offset: 0x013E76AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (48394 - 92972 != -44578)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (32094 - 257042 == -224948)
			{
				this.m0nnpQCsjup.target = Game.mPlayer;
				if (141901 - 286421 != -144519)
				{
					this.m0nnpQCsjup.enabled = true;
					if (204534 - 225604 != -21069)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (40453 - 462388 != -421935)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (22805 - 65541 != -42736)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (86658 - 576317 == -489659)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (283408 - 103205 != 180204)
							{
								if (!gameGui)
								{
									break;
								}
								if (204991 - 533197 == -328206)
								{
									gameGui.enabled = true;
									if (77143 - 319114 == -241971)
									{
										gameGui.closeDeadMenu();
										if (118488 - 312941 == -194453)
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

	// Token: 0x0600BB03 RID: 47875 RVA: 0x013E9658 File Offset: 0x013E7858
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (14878 - 371584 != -356706)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (7373 - 363363 == -355990)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (226820 - 340997 != -114176)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (239801 - 231135 != 8667)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BB04 RID: 47876 RVA: 0x013E971C File Offset: 0x013E791C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600BB05 RID: 47877 RVA: 0x013E9748 File Offset: 0x013E7948
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (176716 - 546313 != -369597)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (184694 - 245506 != -60811)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (117253 - 77745 != 39509)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (15313 - 64985 == -49672)
					{
						Hashtable hashtable = new Hashtable();
						if (20028 - 355072 != -335043)
						{
							hashtable.Add(43, PlayerData.UID);
							if (31875 - 416279 != -384403)
							{
								hashtable.Add(71, nCID);
								if (243626 - 186762 == 56864)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (199816 - 182441 != 17376)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (204193 - 40884 != 163310)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (29530 - 150492 == -120962)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (105457 - 503297 == -397840)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (274725 - 220717 != 54009)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (171954 - 29792 != 142163)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (232049 - 424853 != -192803)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (22964 - 476779 != -453814)
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

	// Token: 0x0600BB06 RID: 47878 RVA: 0x013E9A68 File Offset: 0x013E7C68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M974_DemonicGate.$onChangePlayer$46924(data, this).GetEnumerator();
	}

	// Token: 0x0600BB07 RID: 47879 RVA: 0x013E9A78 File Offset: 0x013E7C78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (262818 - 105154 != 157665)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (231371 - 33089 == 198282)
			{
				Time.timeScale = 1f;
				if (57791 - 323450 == -265659)
				{
					CharacterData.current.removeInventory("k_dun6", 1);
					if (87707 - 594068 != -506360)
					{
						Hashtable customOpParameters = new Hashtable();
						if (112586 - 551417 != -438830)
						{
							this.Spnnpnb7ghB.OpCustom(52, customOpParameters, true);
							if (47115 - 524143 == -477028)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BB08 RID: 47880 RVA: 0x013E9B70 File Offset: 0x013E7D70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (13019 - 306950 != -293931)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (287401 - 71083 != 216319)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (220844 - 429031 != -208186)
				{
					Game.mGameState = eGameState.Setup;
					if (49509 - 124490 != -74980)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BB09 RID: 47881 RVA: 0x013E9C14 File Offset: 0x013E7E14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (241383 - 407426 != -166042)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (55704 - 139489 != -83784)
			{
				if (num == PlayerData.UID)
				{
					if (184979 - 572378 != -387398)
					{
						this.SetupActors();
						if (213647 - 528638 == -314991)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (96509 - 363830 == -267321)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BB0A RID: 47882 RVA: 0x013E9CE4 File Offset: 0x013E7EE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (49977 - 160565 != -110588)
		{
		}
		for (;;)
		{
			IL_1A:
			Debug.Log("Creating Actors");
			if (100887 - 191985 == -91098)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (88 - 554444 != -554355)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (15705 - 353716 == -338011)
						{
							int i = 0;
							if (285467 - 471177 == -185710)
							{
								CharacterControl[] array2 = array;
								if (129357 - 204409 != -75051)
								{
									int length = array2.Length;
									if (38600 - 211878 == -173278)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (147919 - 520244 != -372325)
											{
												goto IL_1A;
											}
											if (type == "Menalisa")
											{
												if (112608 - 492386 != -379778)
												{
													goto IL_1A;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (24969 - 478093 != -453124)
												{
													goto IL_1A;
												}
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (117895 - 17770 != 100125)
											{
												goto IL_1A;
											}
											this.fRZnptfKWea++;
											if (165482 - 141493 == 23990)
											{
												goto IL_1A;
											}
											i++;
											if (273479 - 500524 != -227045)
											{
												goto IL_1A;
											}
										}
										if (219307 - 375271 != -155963)
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
						if (55970 - 430443 != -374472)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BB0B RID: 47883 RVA: 0x013E9F58 File Offset: 0x013E8158
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (233377 - 400445 != -167067)
		{
		}
		for (;;)
		{
			IL_96:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (280834 - 60649 == 220185)
			{
				int i = 0;
				if (40787 - 537136 != -496348)
				{
					CharacterControl[] array2 = array;
					if (142892 - 103043 == 39849)
					{
						int length = array2.Length;
						if (237444 - 477191 == -239747)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (68398 - 5694 == 62705)
								{
									goto IL_96;
								}
								i++;
								if (185496 - 175494 == 10003)
								{
									goto IL_96;
								}
							}
							if (267922 - 95449 != 172474)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BB0C RID: 47884 RVA: 0x013EA088 File Offset: 0x013E8288
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (69487 - 358297 != -288809)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (289824 - 341566 == -51742)
			{
				Game.mGameState = eGameState.Start;
				if (222490 - 458627 == -236137)
				{
					Game.mGameTime = Time.time;
					if (78815 - 82287 == -3472)
					{
						Game.mStateTime = Time.time;
						if (221344 - 571954 == -350610)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (134252 - 458870 != -324617)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BB0D RID: 47885 RVA: 0x013EA174 File Offset: 0x013E8374
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600BB0E RID: 47886 RVA: 0x013EA178 File Offset: 0x013E8378
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M974_DemonicGate.$onGameComplete$46931(data, this).GetEnumerator();
	}

	// Token: 0x0600BB0F RID: 47887 RVA: 0x013EA188 File Offset: 0x013E8388
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M974_DemonicGate.$ReturnToTown$46941(this).GetEnumerator();
	}

	// Token: 0x0600BB10 RID: 47888 RVA: 0x013EA198 File Offset: 0x013E8398
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M974_DemonicGate.$ReturnToGuild$46946(this).GetEnumerator();
	}

	// Token: 0x0600BB11 RID: 47889 RVA: 0x013EA1A8 File Offset: 0x013E83A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M974_DemonicGate.$ReturnToCamp$46950(this).GetEnumerator();
	}

	// Token: 0x0600BB12 RID: 47890 RVA: 0x013EA1B8 File Offset: 0x013E83B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (264459 - 406097 != -141637)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (100646 - 500417 == -399771)
			{
				Hashtable hashtable = new Hashtable();
				if (38355 - 225912 != -187556)
				{
					hashtable.Add(43, PlayerData.UID);
					if (72323 - 477545 == -405222)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (60591 - 424673 == -364082)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BB13 RID: 47891 RVA: 0x013EA290 File Offset: 0x013E8490
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600BB14 RID: 47892 RVA: 0x013EA2A4 File Offset: 0x013E84A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (112581 - 526387 != -413805)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (148200 - 337678 == -189478)
			{
				Hashtable hashtable = new Hashtable();
				if (98246 - 361564 == -263318)
				{
					if (Game.mNextGameCode == 30)
					{
						if (180645 - 282896 != -102251)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (60825 - 366488 != -305663)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (287898 - 593361 == -305462)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (51800 - 437240 != -385440)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (237711 - 164529 == 73183)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (155787 - 323243 != -167456)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (182682 - 368777 == -186094)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (143628 - 591816 == -448187)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (99661 - 409422 != -309761)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (176308 - 360740 == -184431)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (144306 - 272574 == -128267)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (257199 - 303970 != -46771)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (17289 - 61565 != -44276)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (258676 - 499100 == -240423)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (198325 - 337852 != -139527)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (82923 - 21043 != 61880)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (42761 - 272918 != -230157)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (297371 - 121357 != 176014)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (232250 - 124709 != 107541)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (246898 - 249866 == -2967)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (7820 - 394624 != -386804)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (112856 - 11955 == 100902)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (257224 - 499435 == -242210)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (220216 - 369259 == -149042)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (60493 - 520717 != -460224)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (267068 - 89587 == 177482)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (283923 - 149272 != 134651)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (223557 - 268808 != -45251)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (228301 - 214074 == 14227)
					{
						this.Spnnpnb7ghB.OpCustom(42, hashtable, true);
						if (296840 - 427149 == -130309)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BB15 RID: 47893 RVA: 0x013EA858 File Offset: 0x013E8A58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600BB16 RID: 47894 RVA: 0x013EA868 File Offset: 0x013E8A68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600BB17 RID: 47895 RVA: 0x013EA86C File Offset: 0x013E8A6C
	internal static bool Svxd0At3HBRkbMtp8XHr()
	{
		return true;
	}

	// Token: 0x0600BB18 RID: 47896 RVA: 0x013EA870 File Offset: 0x013E8A70
	internal static bool GsE6n6t3WoIBQ0T2CLRK()
	{
		return false;
	}

	// Token: 0x0400A066 RID: 41062
	private LitePeer Spnnpnb7ghB;

	// Token: 0x0400A067 RID: 41063
	private PlayerCameraControl m0nnpQCsjup;

	// Token: 0x0400A068 RID: 41064
	private float TBknpeivBb6;

	// Token: 0x0400A069 RID: 41065
	private Texture LPNnpI0UCEc;

	// Token: 0x0400A06A RID: 41066
	private AudioClip uj4npJ4ImFo;

	// Token: 0x0400A06B RID: 41067
	private int nLSnp6NAXo2;

	// Token: 0x0400A06C RID: 41068
	public GameObject mMenalisa;

	// Token: 0x0400A06D RID: 41069
	public GameObject mWarpEffect;

	// Token: 0x0400A06E RID: 41070
	private int fRZnptfKWea;

	// Token: 0x02001F47 RID: 8007
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$46904 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BB19 RID: 47897 RVA: 0x013EA874 File Offset: 0x013E8A74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$46904(M974_DemonicGate self_)
		{
			if (5289 - 160018 != -154728)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (122758 - 265472 != -142713)
				{
					base..ctor();
					if (223940 - 522456 != -298515)
					{
						this.$self_$46911 = self_;
						if (136447 - 35831 == 100616)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BB1A RID: 47898 RVA: 0x013EA90C File Offset: 0x013E8B0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_DemonicGate.$StartEvent$46904.$(this.$self_$46911);
		}

		// Token: 0x0600BB1B RID: 47899 RVA: 0x013EA91C File Offset: 0x013E8B1C
		internal static bool kuoctut3ActSIZQ7QyY9()
		{
			return true;
		}

		// Token: 0x0600BB1C RID: 47900 RVA: 0x013EA920 File Offset: 0x013E8B20
		internal static bool q4Z4E9t3lpt29tXVVTe1()
		{
			return false;
		}

		// Token: 0x0400A06F RID: 41071
		internal M974_DemonicGate $self_$46911;

		// Token: 0x02001F48 RID: 8008
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BB1D RID: 47901 RVA: 0x013EA924 File Offset: 0x013E8B24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M974_DemonicGate self_)
			{
				if (74440 - 126036 != -51596)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (16669 - 71145 == -54476)
					{
						base..ctor();
						if (277709 - 111025 != 166685)
						{
							this.$self_$46910 = self_;
							if (25836 - 96319 == -70483)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BB1E RID: 47902 RVA: 0x013EA9BC File Offset: 0x013E8BBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (208571 - 460576 != -252005)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_BBD;
					case 1:
						goto IL_E8F;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (295140 - 260420 != 34720)
							{
								continue;
							}
							goto IL_C95;
						}
						else
						{
							this.$mStoryGui$46905 = (StoryGui)this.$self_$46910.GetComponent(typeof(StoryGui));
							if (163090 - 382448 == -219357)
							{
								continue;
							}
							this.$mStoryTimer$46906 = 0f;
							if (29335 - 484107 == -454771)
							{
								continue;
							}
							if (!this.$mStoryGui$46905)
							{
								if (33950 - 165066 != -131115)
								{
									goto Block_72;
								}
								continue;
							}
							else
							{
								this.$mStoryGui$46905.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
								if (42720 - 592541 != -549821)
								{
									continue;
								}
								goto IL_216;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (299080 - 285891 != 13189)
							{
								continue;
							}
							goto IL_158;
						}
						else
						{
							this.$mStoryGui$46905.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M974_DemonicGate", 101), eTalkType.friend);
							if (120358 - 78058 == 42301)
							{
								continue;
							}
							this.$mStoryTimer$46906 = Time.time + 3.5f;
							if (235948 - 22257 != 213691)
							{
								continue;
							}
							goto IL_68F;
						}
						break;
					case 4:
						goto IL_6B6;
					case 5:
						goto IL_6B6;
					case 6:
						goto IL_857;
					case 7:
						goto IL_857;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (30580 - 592433 != -561852)
							{
								goto Block_101;
							}
							continue;
						}
						else
						{
							this.$self_$46910.SendMessage("blackInTimer", 2f);
							if (251634 - 35058 != 216576)
							{
								continue;
							}
							goto IL_362;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.Start)
						{
							if (84985 - 178898 != -93913)
							{
								continue;
							}
							goto IL_8CD;
						}
						else
						{
							this.$mStoryGui$46905.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
							if (244463 - 421328 != -176865)
							{
								continue;
							}
							goto IL_5C;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.Start)
						{
							if (229533 - 480057 != -250523)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46905.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M974_DemonicGate", 103), eTalkType.friend);
							if (142337 - 172331 == -29993)
							{
								continue;
							}
							this.$self_$46910.m0nnpQCsjup.StartCoroutine_Auto(this.$self_$46910.m0nnpQCsjup.slerpToObject("EventCamera2", (float)3));
							if (261915 - 56065 != 205851)
							{
								goto Block_92;
							}
							continue;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.Start)
						{
							if (164429 - 188032 != -23602)
							{
								goto Block_69;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46905.newStoryMessage("Menalisa", "???", Language.getMessage("M974_DemonicGate", 104), eTalkType.enemy);
							if (74611 - 120308 == -45696)
							{
								continue;
							}
							this.$mStoryTimer$46906 = Time.time + 3f;
							if (7782 - 229240 != -221458)
							{
								continue;
							}
							goto IL_A0F;
						}
						break;
					case 12:
						goto IL_A38;
					case 13:
						goto IL_A38;
					case 14:
						goto IL_58D;
					case 15:
						goto IL_58D;
					case 16:
						break;
					case 17:
						break;
					case 18:
						goto IL_935;
					case 19:
						goto IL_935;
					case 20:
						if (Game.mGameState != eGameState.Start)
						{
							if (274618 - 581122 != -306503)
							{
								goto Block_36;
							}
							continue;
						}
						else
						{
							this.$mGameGui$46907 = (GameGui)this.$self_$46910.GetComponent(typeof(GameGui));
							if (85776 - 58242 == 27535)
							{
								continue;
							}
							this.$mGameGui$46907.enabled = true;
							if (40420 - 588900 == -548479)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (215722 - 274367 == -58644)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (157161 - 356023 != -198862)
							{
								continue;
							}
							if (this.$self_$46910.uj4npJ4ImFo)
							{
								if (268857 - 302053 == -33195)
								{
									continue;
								}
								this.$self_$46910.audio.PlayOneShot(this.$self_$46910.uj4npJ4ImFo);
								if (285072 - 264578 == 20495)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (111805 - 439424 != -327619)
							{
								continue;
							}
							goto IL_E8F;
						}
						break;
					default:
						if (51917 - 160268 != -108350)
						{
							goto IL_BBD;
						}
						continue;
					}
					if (this.$mStoryTimer$46906 > Time.time)
					{
						if (28792 - 562308 != -533516)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_7F9;
						}
						if (14455 - 362272 != -347817)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (54723 - 328994 != -274270)
						{
							goto Block_6;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$46905.newStoryMessage("Menalisa", "Menalisa", Language.getMessage("M974_DemonicGate", 107), eTalkType.enemy);
						if (73333 - 313354 != -240021)
						{
							continue;
						}
						this.$mStoryTimer$46906 = Time.time + 3f;
						if (166447 - 108837 != 57610)
						{
							continue;
						}
						goto IL_90C;
					}
					IL_A38:
					if (this.$mStoryTimer$46906 > Time.time)
					{
						if (103469 - 295325 != -191856)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_A2B;
						}
						if (218070 - 432562 == -214491)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (33363 - 49168 != -15805)
						{
							continue;
						}
						goto IL_C37;
					}
					else
					{
						if (this.$self_$46910.mMenalisa)
						{
							if (248358 - 30554 != 217804)
							{
								continue;
							}
							int num = this.$$14910$46908 = 6;
							if (281849 - 205083 != 76766)
							{
								continue;
							}
							if (256569 - 119286 == 137284)
							{
								continue;
							}
							Vector3 vector = this.$$14911$46909 = this.$self_$46910.mMenalisa.transform.position;
							if (284817 - 407120 == -122302)
							{
								continue;
							}
							if (701 - 395458 != -394757)
							{
								continue;
							}
							this.$$14911$46909.z = (float)this.$$14910$46908;
							if (209378 - 289933 != -80555)
							{
								continue;
							}
							if (235395 - 78446 == 156950)
							{
								continue;
							}
							this.$self_$46910.mMenalisa.transform.position = this.$$14911$46909;
							if (257612 - 551168 != -293556)
							{
								continue;
							}
							if (51872 - 204493 == -152620)
							{
								continue;
							}
							if (this.$self_$46910.mWarpEffect)
							{
								if (11457 - 132074 != -120617)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$46910.mWarpEffect, this.$self_$46910.mMenalisa.transform.position, Quaternion.identity);
								if (157535 - 434253 == -276717)
								{
									continue;
								}
							}
						}
						this.$mStoryGui$46905.newStoryMessage("Menalisa", "Menalisa", Language.getMessage("M974_DemonicGate", 105), eTalkType.enemy);
						if (101380 - 376835 == -275454)
						{
							continue;
						}
						this.$mStoryTimer$46906 = Time.time + 3f;
						if (1091 - 183358 != -182266)
						{
							goto Block_21;
						}
						continue;
					}
					IL_935:
					if (this.$mStoryTimer$46906 > Time.time)
					{
						if (21578 - 498509 == -476930)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_928;
						}
						if (56447 - 257475 != -201028)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (131730 - 60935 != 70796)
						{
							goto Block_87;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$46905.close();
						if (161871 - 418127 != -256256)
						{
							continue;
						}
						this.$self_$46910.m0nnpQCsjup.enabled = true;
						if (35157 - 374177 != -339019)
						{
							goto Block_19;
						}
						continue;
					}
					IL_6B6:
					if (this.$mStoryTimer$46906 > Time.time)
					{
						if (286719 - 303169 == -16449)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_6AA;
						}
						if (297755 - 222408 == 75348)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (286048 - 390623 != -104574)
						{
							goto Block_41;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$46905.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M974_DemonicGate", 102), eTalkType.friend);
						if (84591 - 291319 != -206728)
						{
							continue;
						}
						this.$mStoryTimer$46906 = Time.time + 3.5f;
						if (125119 - 206639 != -81520)
						{
							continue;
						}
						goto IL_830;
					}
					IL_58D:
					if (this.$mStoryTimer$46906 > Time.time)
					{
						if (116725 - 40645 != 76080)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_580;
						}
						if (145082 - 453546 != -308464)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (164869 - 360820 != -195950)
						{
							goto Block_79;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$46905.newStoryMessage("Menalisa", "Menalisa", Language.getMessage("M974_DemonicGate", 106), eTalkType.enemy);
						if (236205 - 464118 == -227912)
						{
							continue;
						}
						this.$mStoryTimer$46906 = Time.time + 3f;
						if (218891 - 29646 != 189245)
						{
							continue;
						}
						goto IL_7DD;
					}
					IL_857:
					if (this.$mStoryTimer$46906 > Time.time)
					{
						if (64946 - 286795 == -221848)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_84B;
						}
						if (295745 - 351438 == -55692)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (218872 - 421486 != -202613)
						{
							goto Block_57;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$46905.close();
						if (228097 - 201408 != 26689)
						{
							continue;
						}
						goto IL_E1B;
					}
					IL_BBD:
					Game.mGameState = eGameState.Start;
					if (49870 - 253460 == -203590)
					{
						Game.mStateTime = Time.time;
						if (111370 - 14172 != 97199)
						{
							this.$self_$46910.m0nnpQCsjup.alignToObject("EventCamera1");
							if (282718 - 535172 != -252453)
							{
								this.$self_$46910.SendMessage("blackOutTimer", 0);
								if (149694 - 325741 == -176047)
								{
									goto IL_E6;
								}
							}
						}
					}
				}
				IL_5C:
				return this.Yield(10, new WaitForSeconds(0.5f));
				Block_4:
				Block_6:
				goto IL_E8F;
				IL_E6:
				return this.Yield(2, new WaitForSeconds(1.5f));
				IL_158:
				goto IL_E8F;
				IL_216:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_19:
				return this.Yield(20, new WaitForSeconds(1f));
				Block_21:
				return this.Yield(14, new WaitForSeconds(0.5f));
				IL_362:
				return this.Yield(9, new WaitForSeconds(2f));
				Block_36:
				Block_41:
				goto IL_E8F;
				IL_580:
				return this.YieldDefault(15);
				IL_68F:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_6AA:
				return this.YieldDefault(5);
				Block_57:
				goto IL_E8F;
				IL_7DD:
				return this.Yield(16, new WaitForSeconds(0.5f));
				IL_7F9:
				return this.YieldDefault(17);
				IL_830:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_84B:
				return this.YieldDefault(7);
				IL_8CD:
				goto IL_E8F;
				IL_90C:
				return this.Yield(18, new WaitForSeconds(0.5f));
				IL_928:
				return this.YieldDefault(19);
				Block_69:
				Block_72:
				goto IL_E8F;
				IL_A0F:
				return this.Yield(12, new WaitForSeconds(0.5f));
				IL_A2B:
				return this.YieldDefault(13);
				Block_79:
				Block_87:
				IL_C37:
				IL_C95:
				goto IL_E8F;
				Block_92:
				return this.Yield(11, new WaitForSeconds(3f));
				IL_E1B:
				return this.Yield(8, new WaitForSeconds(1f));
				Block_101:
				IL_E8F:
				return false;
			}

			// Token: 0x0600BB1F RID: 47903 RVA: 0x013EB86C File Offset: 0x013E9A6C
			internal static bool DRy2l7t3yImZBHvcDUyp()
			{
				return true;
			}

			// Token: 0x0600BB20 RID: 47904 RVA: 0x013EB870 File Offset: 0x013E9A70
			internal static bool dtKWWxt3SPIy4lOX06fy()
			{
				return false;
			}

			// Token: 0x0400A070 RID: 41072
			internal StoryGui $mStoryGui$46905;

			// Token: 0x0400A071 RID: 41073
			internal float $mStoryTimer$46906;

			// Token: 0x0400A072 RID: 41074
			internal GameGui $mGameGui$46907;

			// Token: 0x0400A073 RID: 41075
			internal int $$14910$46908;

			// Token: 0x0400A074 RID: 41076
			internal Vector3 $$14911$46909;

			// Token: 0x0400A075 RID: 41077
			internal M974_DemonicGate $self_$46910;
		}
	}

	// Token: 0x02001F49 RID: 8009
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$46912 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BB21 RID: 47905 RVA: 0x013EB874 File Offset: 0x013E9A74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$46912(M974_DemonicGate self_)
		{
			if (201918 - 186801 != 15117)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (181786 - 208236 == -26450)
				{
					base..ctor();
					if (21697 - 280068 == -258371)
					{
						this.$self_$46917 = self_;
						if (50985 - 90854 == -39869)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BB22 RID: 47906 RVA: 0x013EB90C File Offset: 0x013E9B0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_DemonicGate.$EndEvent$46912.$(this.$self_$46917);
		}

		// Token: 0x0600BB23 RID: 47907 RVA: 0x013EB91C File Offset: 0x013E9B1C
		internal static bool KOrijgt3oNbDw7KhMesb()
		{
			return true;
		}

		// Token: 0x0600BB24 RID: 47908 RVA: 0x013EB920 File Offset: 0x013E9B20
		internal static bool v0r12Gt3EWd7JxcpbSqR()
		{
			return false;
		}

		// Token: 0x0400A076 RID: 41078
		internal M974_DemonicGate $self_$46917;

		// Token: 0x02001F4A RID: 8010
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BB25 RID: 47909 RVA: 0x013EB924 File Offset: 0x013E9B24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M974_DemonicGate self_)
			{
				if (12979 - 230342 != -217363)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (99166 - 459406 != -360239)
					{
						base..ctor();
						if (37958 - 332391 == -294433)
						{
							this.$self_$46916 = self_;
							if (70491 - 142374 != -71882)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BB26 RID: 47910 RVA: 0x013EB9BC File Offset: 0x013E9BBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (67427 - 430294 != -362866)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_51D;
					case 1:
						goto IL_567;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (58847 - 55405 != 3443)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$46914.newStoryMessage("Menalisa", "Menalisa", Language.getMessage("M974_DemonicGate", 201), eTalkType.enemy);
							if (204052 - 92196 != 111856)
							{
								continue;
							}
							this.$mStoryTimer$46915 = Time.time + 3f;
							if (275545 - 161198 != 114348)
							{
								goto Block_22;
							}
							continue;
						}
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						goto IL_107;
					case 6:
						goto IL_107;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (133941 - 90527 != 43415)
							{
								goto Block_24;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (238628 - 510914 == -272285)
							{
								continue;
							}
							Game.sendMissionEvent(9742, 1);
							if (99118 - 353003 != -253885)
							{
								continue;
							}
							goto IL_3A4;
						}
						break;
					default:
						if (119637 - 41441 != 78197)
						{
							goto IL_51D;
						}
						continue;
					}
					if (this.$mStoryTimer$46915 > Time.time)
					{
						if (159444 - 258059 != -98615)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							break;
						}
						if (144312 - 326703 == -182390)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (169514 - 467774 != -298259)
						{
							goto Block_29;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$46914.newStoryMessage("Menalisa", "Menalisa", Language.getMessage("M974_DemonicGate", 202), eTalkType.enemy);
						if (156806 - 103847 == 52960)
						{
							continue;
						}
						this.$mStoryTimer$46915 = Time.time + 3f;
						if (170044 - 231931 != -61886)
						{
							goto Block_35;
						}
						continue;
					}
					IL_107:
					if (this.$mStoryTimer$46915 > Time.time)
					{
						if (141423 - 147390 == -5966)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_FB;
						}
						if (16480 - 11989 != 4491)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.AllHold)
					{
						if (179904 - 47124 != 132781)
						{
							goto Block_33;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$46914.close();
						if (152597 - 149000 != 3597)
						{
							continue;
						}
						this.$mGameGui$46913.enabled = true;
						if (265827 - 514674 != -248847)
						{
							continue;
						}
						goto IL_349;
					}
					IL_51D:
					if (Game.mGameState != eGameState.Normal)
					{
						if (105351 - 312515 != -207163)
						{
							goto Block_39;
						}
						continue;
					}
					else
					{
						this.$mGameGui$46913 = (GameGui)this.$self_$46916.GetComponent(typeof(GameGui));
						if (31101 - 266515 != -235414)
						{
							continue;
						}
						this.$mStoryGui$46914 = (StoryGui)this.$self_$46916.GetComponent(typeof(StoryGui));
						if (34211 - 204609 == -170397)
						{
							continue;
						}
						this.$mStoryTimer$46915 = 0f;
						if (266596 - 267335 != -739)
						{
							continue;
						}
						if (this.$mGameGui$46913)
						{
							if (118769 - 266032 == -147262)
							{
								continue;
							}
							if (this.$mStoryGui$46914)
							{
								if (76404 - 547044 != -470640)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (68688 - 553515 != -484827)
								{
									continue;
								}
								this.$self_$46916.m0nnpQCsjup.enabled = false;
								if (262179 - 36775 == 225405)
								{
									continue;
								}
								this.$mGameGui$46913.close();
								if (246714 - 519405 != -272691)
								{
									continue;
								}
								this.$mStoryGui$46914.startStoryMessage("Menalisa", "Menalisa", eTalkType.enemy);
								if (195046 - 168903 != 26144)
								{
									goto Block_5;
								}
								continue;
							}
						}
					}
					IL_3A4:
					this.YieldDefault(1);
					if (104679 - 394893 == -290214)
					{
						goto IL_567;
					}
				}
				return this.YieldDefault(4);
				Block_5:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_FB:
				return this.YieldDefault(6);
				Block_12:
				goto IL_567;
				Block_22:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_349:
				return this.Yield(7, new WaitForSeconds(1f));
				Block_24:
				Block_29:
				Block_33:
				goto IL_567;
				Block_35:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_39:
				IL_567:
				return false;
			}

			// Token: 0x0600BB27 RID: 47911 RVA: 0x013EBF44 File Offset: 0x013EA144
			internal static bool ayX4nOt3288BEyH7pm1j()
			{
				return true;
			}

			// Token: 0x0600BB28 RID: 47912 RVA: 0x013EBF48 File Offset: 0x013EA148
			internal static bool Gupcu9t38d1Js0wTm77Z()
			{
				return false;
			}

			// Token: 0x0400A077 RID: 41079
			internal GameGui $mGameGui$46913;

			// Token: 0x0400A078 RID: 41080
			internal StoryGui $mStoryGui$46914;

			// Token: 0x0400A079 RID: 41081
			internal float $mStoryTimer$46915;

			// Token: 0x0400A07A RID: 41082
			internal M974_DemonicGate $self_$46916;
		}
	}

	// Token: 0x02001F4B RID: 8011
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$46918 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BB29 RID: 47913 RVA: 0x013EBF4C File Offset: 0x013EA14C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$46918(M974_DemonicGate self_)
		{
			if (146172 - 2730 != 143442)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (287081 - 204512 != 82570)
				{
					base..ctor();
					if (209547 - 320950 != -111402)
					{
						this.$self_$46923 = self_;
						if (38763 - 41643 == -2880)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BB2A RID: 47914 RVA: 0x013EBFE4 File Offset: 0x013EA1E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_DemonicGate.$onDeadPlayer$46918.$(this.$self_$46923);
		}

		// Token: 0x0600BB2B RID: 47915 RVA: 0x013EBFF4 File Offset: 0x013EA1F4
		internal static bool Kajueot3ZyxfCChPxasg()
		{
			return true;
		}

		// Token: 0x0600BB2C RID: 47916 RVA: 0x013EBFF8 File Offset: 0x013EA1F8
		internal static bool d6WqJwt3C3M0rlFiFrxo()
		{
			return false;
		}

		// Token: 0x0400A07B RID: 41083
		internal M974_DemonicGate $self_$46923;

		// Token: 0x02001F4C RID: 8012
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BB2D RID: 47917 RVA: 0x013EBFFC File Offset: 0x013EA1FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M974_DemonicGate self_)
			{
				if (25625 - 428154 != -402528)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (169184 - 250523 == -81339)
					{
						base..ctor();
						if (184135 - 589535 == -405400)
						{
							this.$self_$46922 = self_;
							if (213875 - 83800 == 130075)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BB2E RID: 47918 RVA: 0x013EC094 File Offset: 0x013EA294
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (139793 - 117089 != 22705)
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
							if (276763 - 36547 == 240217)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_22A;
							}
							if (61882 - 318545 != -256663)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (111705 - 72352 == 39354)
						{
							continue;
						}
						this.$mStoryGui$46919 = (StoryGui)this.$self_$46922.GetComponent(typeof(StoryGui));
						if (147993 - 419524 != -271531)
						{
							continue;
						}
						if (this.$mStoryGui$46919)
						{
							if (15672 - 149722 == -134049)
							{
								continue;
							}
							this.$mStoryGui$46919.close();
							if (251141 - 90540 == 160602)
							{
								continue;
							}
						}
						this.$mChangeGui$46920 = (ChangeGui)this.$self_$46922.GetComponent(typeof(ChangeGui));
						if (270379 - 163253 == 107127)
						{
							continue;
						}
						if (this.$mChangeGui$46920)
						{
							if (165169 - 381181 == -216011)
							{
								continue;
							}
							this.$mChangeGui$46920.close();
							if (59378 - 112673 != -53295)
							{
								continue;
							}
						}
						this.$mGameGui$46921 = (GameGui)this.$self_$46922.GetComponent(typeof(GameGui));
						if (135149 - 63936 != 71213)
						{
							continue;
						}
						if (this.$mGameGui$46921)
						{
							if (18801 - 594180 != -575379)
							{
								continue;
							}
							if (!this.$mGameGui$46921.enabled)
							{
								if (6697 - 184364 != -177667)
								{
									continue;
								}
								this.$mGameGui$46921.enabled = true;
								if (168358 - 121209 != 47149)
								{
									continue;
								}
							}
							this.$mGameGui$46921.openDeadMenu();
							if (28152 - 454785 == -426632)
							{
								continue;
							}
						}
						IL_22A:
						this.YieldDefault(1);
						if (243198 - 540812 != -297613)
						{
							goto Block_18;
						}
						continue;
					default:
						if (104408 - 293081 != -188673)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (212158 - 112471 != 99687);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_18:
				IL_2F9:
				return false;
			}

			// Token: 0x0600BB2F RID: 47919 RVA: 0x013EC3AC File Offset: 0x013EA5AC
			internal static bool mULoOft3L98QPlCrJiW0()
			{
				return true;
			}

			// Token: 0x0600BB30 RID: 47920 RVA: 0x013EC3B0 File Offset: 0x013EA5B0
			internal static bool zBUUv8t3OYcZhXLertFi()
			{
				return false;
			}

			// Token: 0x0400A07C RID: 41084
			internal StoryGui $mStoryGui$46919;

			// Token: 0x0400A07D RID: 41085
			internal ChangeGui $mChangeGui$46920;

			// Token: 0x0400A07E RID: 41086
			internal GameGui $mGameGui$46921;

			// Token: 0x0400A07F RID: 41087
			internal M974_DemonicGate $self_$46922;
		}
	}

	// Token: 0x02001F4D RID: 8013
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$46924 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BB31 RID: 47921 RVA: 0x013EC3B4 File Offset: 0x013EA5B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$46924(Hashtable data, M974_DemonicGate self_)
		{
			if (7222 - 574315 != -567093)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (235715 - 301702 != -65986)
				{
					base..ctor();
					if (156848 - 250377 != -93528)
					{
						this.$data$46929 = data;
						if (280467 - 399978 != -119510)
						{
							this.$self_$46930 = self_;
							if (164068 - 461141 != -297072)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BB32 RID: 47922 RVA: 0x013EC470 File Offset: 0x013EA670
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_DemonicGate.$onChangePlayer$46924.$(this.$data$46929, this.$self_$46930);
		}

		// Token: 0x0600BB33 RID: 47923 RVA: 0x013EC484 File Offset: 0x013EA684
		internal static bool yijZLOt3mROnUd7e21LT()
		{
			return true;
		}

		// Token: 0x0600BB34 RID: 47924 RVA: 0x013EC488 File Offset: 0x013EA688
		internal static bool rjjgy7t3FXbUhR9sshZQ()
		{
			return false;
		}

		// Token: 0x0400A080 RID: 41088
		internal Hashtable $data$46929;

		// Token: 0x0400A081 RID: 41089
		internal M974_DemonicGate $self_$46930;

		// Token: 0x02001F4E RID: 8014
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BB35 RID: 47925 RVA: 0x013EC48C File Offset: 0x013EA68C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M974_DemonicGate self_)
			{
				if (59390 - 300305 != -240914)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (126107 - 95237 == 30870)
					{
						base..ctor();
						if (192998 - 101596 == 91402)
						{
							this.$data$46927 = data;
							if (48077 - 9962 != 38116)
							{
								this.$self_$46928 = self_;
								if (227549 - 521175 == -293626)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BB36 RID: 47926 RVA: 0x013EC548 File Offset: 0x013EA748
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (42779 - 85016 != -42236)
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
							if (8786 - 544301 == -535514)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (167500 - 271105 == -103604)
							{
								continue;
							}
							this.$mGameGui$46926 = (GameGui)this.$self_$46928.GetComponent(typeof(GameGui));
							if (218344 - 181672 == 36673)
							{
								continue;
							}
							this.$mGameGui$46926.enabled = true;
							if (154241 - 397535 == -243293)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (188805 - 505817 != -317012)
						{
							continue;
						}
						goto IL_205;
					default:
						if (230377 - 548824 == -318446)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (24189 - 238975 == -214786)
					{
						this.$self_$46928.SendMessage("onCreatePlayer", this.$data$46927);
						if (19911 - 87905 == -67994)
						{
							this.$mChangeGui$46925 = (ChangeGui)this.$self_$46928.GetComponent(typeof(ChangeGui));
							if (241484 - 120071 == 121413)
							{
								if (!this.$mChangeGui$46925.enabled)
								{
									break;
								}
								if (95383 - 54426 != 40958)
								{
									this.$mChangeGui$46925.close();
									if (172043 - 537971 == -365928)
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

			// Token: 0x0600BB37 RID: 47927 RVA: 0x013EC76C File Offset: 0x013EA96C
			internal static bool Vs7wgGt3MnoosgqDDmKm()
			{
				return true;
			}

			// Token: 0x0600BB38 RID: 47928 RVA: 0x013EC770 File Offset: 0x013EA970
			internal static bool Fxnfmyt3xyEUEr8qlIyM()
			{
				return false;
			}

			// Token: 0x0400A082 RID: 41090
			internal ChangeGui $mChangeGui$46925;

			// Token: 0x0400A083 RID: 41091
			internal GameGui $mGameGui$46926;

			// Token: 0x0400A084 RID: 41092
			internal Hashtable $data$46927;

			// Token: 0x0400A085 RID: 41093
			internal M974_DemonicGate $self_$46928;
		}
	}

	// Token: 0x02001F4F RID: 8015
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$46931 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BB39 RID: 47929 RVA: 0x013EC774 File Offset: 0x013EA974
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$46931(Hashtable data, M974_DemonicGate self_)
		{
			if (197543 - 375353 != -177810)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (284558 - 473798 == -189240)
				{
					base..ctor();
					if (213157 - 494633 != -281475)
					{
						this.$data$46939 = data;
						if (23209 - 303629 != -280419)
						{
							this.$self_$46940 = self_;
							if (63234 - 205295 != -142060)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BB3A RID: 47930 RVA: 0x013EC830 File Offset: 0x013EAA30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_DemonicGate.$onGameComplete$46931.$(this.$data$46939, this.$self_$46940);
		}

		// Token: 0x0600BB3B RID: 47931 RVA: 0x013EC844 File Offset: 0x013EAA44
		internal static bool CVyYAQt3gRPjK62LhL18()
		{
			return true;
		}

		// Token: 0x0600BB3C RID: 47932 RVA: 0x013EC848 File Offset: 0x013EAA48
		internal static bool AFgmvwt3fC3xverhpvXF()
		{
			return false;
		}

		// Token: 0x0400A086 RID: 41094
		internal Hashtable $data$46939;

		// Token: 0x0400A087 RID: 41095
		internal M974_DemonicGate $self_$46940;

		// Token: 0x02001F50 RID: 8016
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BB3D RID: 47933 RVA: 0x013EC84C File Offset: 0x013EAA4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M974_DemonicGate self_)
			{
				if (244504 - 4319 != 240186)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (265784 - 48195 == 217589)
					{
						base..ctor();
						if (259897 - 197311 == 62586)
						{
							this.$data$46937 = data;
							if (296588 - 64741 == 231847)
							{
								this.$self_$46938 = self_;
								if (96018 - 57832 != 38187)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BB3E RID: 47934 RVA: 0x013EC908 File Offset: 0x013EAB08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (278200 - 137903 != 140298)
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
						this.$mCompleteGui$46933 = (CompleteGui)this.$self_$46938.GetComponent(typeof(CompleteGui));
						if (252365 - 385987 == -133621)
						{
							continue;
						}
						this.$mCompleteGui$46933.Init();
						if (251583 - 492179 != -240596)
						{
							continue;
						}
						this.$mCompleteGui$46933.readData(this.$data$46937);
						if (171792 - 141777 != 30015)
						{
							continue;
						}
						if (this.$result$46932 == 1)
						{
							if (159009 - 489117 == -330107)
							{
								continue;
							}
							this.$mCompleteGui$46933.displayResult(eCompleteType.Success);
							if (118597 - 228763 == -110165)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$46933.displayResult(eCompleteType.Failed);
							if (153729 - 165271 == -11541)
							{
								continue;
							}
						}
						this.$mGameGui$46934 = (GameGui)this.$self_$46938.GetComponent(typeof(GameGui));
						if (77320 - 424602 != -347282)
						{
							continue;
						}
						this.$mStoryGui$46935 = (StoryGui)this.$self_$46938.GetComponent(typeof(StoryGui));
						if (180156 - 37404 != 142752)
						{
							continue;
						}
						this.$mChangeGui$46936 = (ChangeGui)this.$self_$46938.GetComponent(typeof(ChangeGui));
						if (19853 - 201929 != -182076)
						{
							continue;
						}
						if (this.$mGameGui$46934)
						{
							if (275227 - 270972 != 4255)
							{
								continue;
							}
							this.$mGameGui$46934.close();
							if (212290 - 443416 == -231125)
							{
								continue;
							}
						}
						if (this.$mStoryGui$46935)
						{
							if (27960 - 357931 == -329970)
							{
								continue;
							}
							this.$mStoryGui$46935.close();
							if (111696 - 395059 != -283363)
							{
								continue;
							}
						}
						if (this.$mChangeGui$46936)
						{
							if (158734 - 214858 != -56124)
							{
								continue;
							}
							this.$mChangeGui$46936.disable();
							if (212230 - 343148 != -130918)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (102797 - 114326 != -11529)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (137997 - 427167 == -289169)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$46937[31]);
					if (99267 - 111852 != -12584)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (205950 - 195047 == 10903)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (152806 - 506966 == -354160)
							{
								this.$result$46932 = RuntimeServices.UnboxInt32(this.$data$46937[31]);
								if (61564 - 371960 != -310395)
								{
									goto Block_24;
								}
							}
						}
					}
				}
				goto IL_3DB;
				Block_24:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x0600BB3F RID: 47935 RVA: 0x013ECD04 File Offset: 0x013EAF04
			internal static bool YIlqy3t3nLMg02LKQTB5()
			{
				return true;
			}

			// Token: 0x0600BB40 RID: 47936 RVA: 0x013ECD08 File Offset: 0x013EAF08
			internal static bool w3RYeLt36MGF2NB39Mdo()
			{
				return false;
			}

			// Token: 0x0400A088 RID: 41096
			internal int $result$46932;

			// Token: 0x0400A089 RID: 41097
			internal CompleteGui $mCompleteGui$46933;

			// Token: 0x0400A08A RID: 41098
			internal GameGui $mGameGui$46934;

			// Token: 0x0400A08B RID: 41099
			internal StoryGui $mStoryGui$46935;

			// Token: 0x0400A08C RID: 41100
			internal ChangeGui $mChangeGui$46936;

			// Token: 0x0400A08D RID: 41101
			internal Hashtable $data$46937;

			// Token: 0x0400A08E RID: 41102
			internal M974_DemonicGate $self_$46938;
		}
	}

	// Token: 0x02001F51 RID: 8017
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$46941 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BB41 RID: 47937 RVA: 0x013ECD0C File Offset: 0x013EAF0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$46941(M974_DemonicGate self_)
		{
			if (262889 - 426670 != -163781)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (131432 - 133810 == -2378)
				{
					base..ctor();
					if (92814 - 1323 == 91491)
					{
						this.$self_$46945 = self_;
						if (86574 - 362004 == -275430)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BB42 RID: 47938 RVA: 0x013ECDA4 File Offset: 0x013EAFA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_DemonicGate.$ReturnToTown$46941.$(this.$self_$46945);
		}

		// Token: 0x0600BB43 RID: 47939 RVA: 0x013ECDB4 File Offset: 0x013EAFB4
		internal static bool XXRnWft3i4iR7kR1WX9S()
		{
			return true;
		}

		// Token: 0x0600BB44 RID: 47940 RVA: 0x013ECDB8 File Offset: 0x013EAFB8
		internal static bool UJdfyjt3K2Ytl4YemqrI()
		{
			return false;
		}

		// Token: 0x0400A08F RID: 41103
		internal M974_DemonicGate $self_$46945;

		// Token: 0x02001F52 RID: 8018
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BB45 RID: 47941 RVA: 0x013ECDBC File Offset: 0x013EAFBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M974_DemonicGate self_)
			{
				if (21477 - 265738 != -244260)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (37142 - 344718 == -307576)
					{
						base..ctor();
						if (5087 - 347077 == -341990)
						{
							this.$self_$46944 = self_;
							if (52290 - 343634 == -291344)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BB46 RID: 47942 RVA: 0x013ECE54 File Offset: 0x013EB054
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (137682 - 419856 != -282173)
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
						this.$self_$46944.LeaveGame();
						if (264215 - 586492 == -322276)
						{
							continue;
						}
						this.YieldDefault(1);
						if (279419 - 438440 != -159021)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (154449 - 72141 != 82308)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (264999 - 148840 == 116159)
					{
						Game.mStateTime = Time.time;
						if (219465 - 170842 != 48624)
						{
							this.$$switch$8755$46942 = PlayerData.SaveGuild;
							if (191626 - 111639 != 79988)
							{
								if (this.$$switch$8755$46942 == 1)
								{
									if (95228 - 509079 == -413850)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (230403 - 304925 != -74522)
									{
										continue;
									}
								}
								else if (this.$$switch$8755$46942 == 2)
								{
									if (33259 - 138557 != -105298)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (263264 - 565074 == -301809)
									{
										continue;
									}
								}
								else if (this.$$switch$8755$46942 == 3)
								{
									if (243940 - 16855 == 227086)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (192833 - 132693 == 60141)
									{
										continue;
									}
								}
								else if (this.$$switch$8755$46942 == 4)
								{
									if (197789 - 238348 != -40559)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (50104 - 442397 != -392293)
									{
										continue;
									}
								}
								else if (this.$$switch$8755$46942 == 5)
								{
									if (230375 - 532353 == -301977)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (100196 - 76805 == 23392)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (291107 - 411005 != -119898)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (298882 - 178132 != 120750)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (217661 - 56273 == 161389)
									{
										continue;
									}
								}
								this.$mGameGui$46943 = (GameGui)this.$self_$46944.GetComponent(typeof(GameGui));
								if (26102 - 169376 != -143273)
								{
									if (this.$mGameGui$46943)
									{
										if (280125 - 471785 == -191659)
										{
											continue;
										}
										this.$mGameGui$46943.close();
										if (87753 - 578827 != -491074)
										{
											continue;
										}
									}
									this.$self_$46944.SendMessage("fadeOut");
									if (21831 - 203668 != -181836)
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

			// Token: 0x0600BB47 RID: 47943 RVA: 0x013ED220 File Offset: 0x013EB420
			internal static bool VGudpTt3dTYIkCs7BuIg()
			{
				return true;
			}

			// Token: 0x0600BB48 RID: 47944 RVA: 0x013ED224 File Offset: 0x013EB424
			internal static bool mIDvJEt3JkJINMuJdUkZ()
			{
				return false;
			}

			// Token: 0x0400A090 RID: 41104
			internal int $$switch$8755$46942;

			// Token: 0x0400A091 RID: 41105
			internal GameGui $mGameGui$46943;

			// Token: 0x0400A092 RID: 41106
			internal M974_DemonicGate $self_$46944;
		}
	}

	// Token: 0x02001F53 RID: 8019
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$46946 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BB49 RID: 47945 RVA: 0x013ED228 File Offset: 0x013EB428
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$46946(M974_DemonicGate self_)
		{
			if (294428 - 500172 != -205743)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (136206 - 284611 == -148405)
				{
					base..ctor();
					if (103273 - 581350 == -478077)
					{
						this.$self_$46949 = self_;
						if (233480 - 368888 == -135408)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BB4A RID: 47946 RVA: 0x013ED2C0 File Offset: 0x013EB4C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_DemonicGate.$ReturnToGuild$46946.$(this.$self_$46949);
		}

		// Token: 0x0600BB4B RID: 47947 RVA: 0x013ED2D0 File Offset: 0x013EB4D0
		internal static bool FqdYSst3DEuDas7sr6dp()
		{
			return true;
		}

		// Token: 0x0600BB4C RID: 47948 RVA: 0x013ED2D4 File Offset: 0x013EB4D4
		internal static bool DfyZFrt3v5ygdqJC6lHY()
		{
			return false;
		}

		// Token: 0x0400A093 RID: 41107
		internal M974_DemonicGate $self_$46949;

		// Token: 0x02001F54 RID: 8020
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BB4D RID: 47949 RVA: 0x013ED2D8 File Offset: 0x013EB4D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M974_DemonicGate self_)
			{
				if (211881 - 219980 != -8098)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (141311 - 443761 != -302449)
					{
						base..ctor();
						if (99726 - 305867 != -206140)
						{
							this.$self_$46948 = self_;
							if (164536 - 42748 == 121788)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BB4E RID: 47950 RVA: 0x013ED370 File Offset: 0x013EB570
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (260009 - 401158 != -141149)
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
						this.$self_$46948.LeaveGame();
						if (107242 - 404454 != -297212)
						{
							continue;
						}
						this.YieldDefault(1);
						if (101030 - 39352 != 61678)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (289082 - 102051 == 187032)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (85606 - 464857 == -379251)
					{
						Game.mStateTime = Time.time;
						if (283920 - 518091 == -234171)
						{
							Game.mNextGameCode = 31;
							if (215862 - 266127 == -50265)
							{
								this.$mGameGui$46947 = (GameGui)this.$self_$46948.GetComponent(typeof(GameGui));
								if (246711 - 574845 == -328134)
								{
									if (this.$mGameGui$46947)
									{
										if (261975 - 125496 != 136479)
										{
											continue;
										}
										this.$mGameGui$46947.close();
										if (181568 - 112111 != 69457)
										{
											continue;
										}
									}
									this.$self_$46948.SendMessage("fadeOut");
									if (133670 - 244752 != -111081)
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

			// Token: 0x0600BB4F RID: 47951 RVA: 0x013ED54C File Offset: 0x013EB74C
			internal static bool o0OHCDt3RhLmBcyi74UJ()
			{
				return true;
			}

			// Token: 0x0600BB50 RID: 47952 RVA: 0x013ED550 File Offset: 0x013EB750
			internal static bool AlXyLqt3wavu9iSDnldD()
			{
				return false;
			}

			// Token: 0x0400A094 RID: 41108
			internal GameGui $mGameGui$46947;

			// Token: 0x0400A095 RID: 41109
			internal M974_DemonicGate $self_$46948;
		}
	}

	// Token: 0x02001F55 RID: 8021
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$46950 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BB51 RID: 47953 RVA: 0x013ED554 File Offset: 0x013EB754
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$46950(M974_DemonicGate self_)
		{
			if (236899 - 380431 != -143531)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (71945 - 476200 != -404254)
				{
					base..ctor();
					if (103887 - 152591 == -48704)
					{
						this.$self_$46953 = self_;
						if (72366 - 188182 == -115816)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BB52 RID: 47954 RVA: 0x013ED5EC File Offset: 0x013EB7EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M974_DemonicGate.$ReturnToCamp$46950.$(this.$self_$46953);
		}

		// Token: 0x0600BB53 RID: 47955 RVA: 0x013ED5FC File Offset: 0x013EB7FC
		internal static bool SJYnDHt3qbbjNZkcF43e()
		{
			return true;
		}

		// Token: 0x0600BB54 RID: 47956 RVA: 0x013ED600 File Offset: 0x013EB800
		internal static bool EmdYg3t37YT37IgbiNhK()
		{
			return false;
		}

		// Token: 0x0400A096 RID: 41110
		internal M974_DemonicGate $self_$46953;

		// Token: 0x02001F56 RID: 8022
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BB55 RID: 47957 RVA: 0x013ED604 File Offset: 0x013EB804
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M974_DemonicGate self_)
			{
				if (248527 - 498418 != -249890)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (284710 - 440250 != -155539)
					{
						base..ctor();
						if (111555 - 117685 != -6129)
						{
							this.$self_$46952 = self_;
							if (79845 - 351741 != -271895)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BB56 RID: 47958 RVA: 0x013ED69C File Offset: 0x013EB89C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (22046 - 431078 != -409032)
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
						this.$self_$46952.LeaveGame();
						if (231251 - 304024 == -72772)
						{
							continue;
						}
						this.YieldDefault(1);
						if (289542 - 371096 != -81553)
						{
							goto Block_5;
						}
						continue;
					default:
						if (34151 - 336373 == -302221)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (111726 - 229468 != -117741)
					{
						Game.mStateTime = Time.time;
						if (253099 - 115449 == 137650)
						{
							Game.mNextGameCode = 35;
							if (159839 - 330856 != -171016)
							{
								this.$mGameGui$46951 = (GameGui)this.$self_$46952.GetComponent(typeof(GameGui));
								if (34564 - 434816 == -400252)
								{
									if (this.$mGameGui$46951)
									{
										if (73579 - 503866 == -430286)
										{
											continue;
										}
										this.$mGameGui$46951.close();
										if (101475 - 85362 == 16114)
										{
											continue;
										}
									}
									this.$self_$46952.SendMessage("fadeOut");
									if (296003 - 52347 != 243657)
									{
										goto Block_7;
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_1BD;
				Block_7:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600BB57 RID: 47959 RVA: 0x013ED878 File Offset: 0x013EBA78
			internal static bool feEBkKt3PmTBrs7WP6NJ()
			{
				return true;
			}

			// Token: 0x0600BB58 RID: 47960 RVA: 0x013ED87C File Offset: 0x013EBA7C
			internal static bool E4H0yet30wn2OELAmKah()
			{
				return false;
			}

			// Token: 0x0400A097 RID: 41111
			internal GameGui $mGameGui$46951;

			// Token: 0x0400A098 RID: 41112
			internal M974_DemonicGate $self_$46952;
		}
	}
}
