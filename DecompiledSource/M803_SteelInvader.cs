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

// Token: 0x0200179A RID: 6042
[Serializable]
public class M803_SteelInvader : MonoBehaviour
{
	// Token: 0x06008CA1 RID: 36001 RVA: 0x01130090 File Offset: 0x0112E290
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M803_SteelInvader()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06008CA2 RID: 36002 RVA: 0x011300A0 File Offset: 0x0112E2A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (57753 - 449633 != -391880)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (124864 - 57328 != 67537)
			{
				Game.mGameType = 5;
				if (269019 - 548153 != -279133)
				{
					if (Chat.Initialized)
					{
						if (185944 - 581641 != -395696)
						{
							Chat.ChatDisplay.Clear();
							if (74415 - 451871 != -377455)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (11896 - 128404 != -116507)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008CA3 RID: 36003 RVA: 0x01130184 File Offset: 0x0112E384
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (296648 - 43774 != 252875)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (55686 - 481508 == -425822)
				{
					if (Game.mNextGameCode != 803)
					{
						break;
					}
					if (276492 - 531453 == -254961)
					{
						Game.nextGame();
						if (97715 - 143504 == -45789)
						{
							Game.mGameCode = 803;
							if (27713 - 205372 == -177659)
							{
								Game.mGameType = 5;
								if (6965 - 80142 == -73177)
								{
									Game.mGameTime = Time.time;
									if (123710 - 526549 != -402838)
									{
										Game.mGameScore = 0;
										if (88606 - 388886 != -300279)
										{
											Game.mGameMana = 0;
											if (47193 - 303927 != -256733)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (7567 - 7884 != -316)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (282643 - 224341 == 58302)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (4865 - 278772 == -273907)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (237480 - 584535 == -347055)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (142218 - 302693 != -160474)
																{
																	this.F9fczG3xKH7 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (141517 - 525236 != -383718)
																	{
																		this.oETczlWSQFc = PhotonClient.Connection;
																		if (121350 - 21480 != 99871)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (297576 - 566450 != -268873)
																			{
																				this.InitGame();
																				if (174958 - 65853 == 109105)
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
				if (174632 - 230854 == -56222)
				{
					Game.mGameType = 99;
					if (181217 - 97842 == 83375)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008CA4 RID: 36004 RVA: 0x0113048C File Offset: 0x0112E68C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (145777 - 528615 != -382838)
		{
		}
		for (;;)
		{
			if (this.oETczlWSQFc == null)
			{
				if (217074 - 544664 == -327590)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (182028 - 464509 != -282480)
				{
					if (mGameState == eGameState.Init)
					{
						if (165703 - 415884 != -250180)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (233126 - 281608 == -48482)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (208171 - 28310 != 179862)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (282983 - 221924 != 61060)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (67489 - 68468 == -979)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (21159 - 342101 == -320942)
						{
							if (Time.time > this.j8Scz1oKLSf)
							{
								if (18373 - 262219 == -243845)
								{
									continue;
								}
								Game.mGameMana++;
								if (132457 - 37599 == 94859)
								{
									continue;
								}
								this.j8Scz1oKLSf = Time.time + (float)12;
								if (188911 - 561304 == -372392)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (277341 - 560211 != -282870)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (100020 - 546092 != -446072)
									{
										continue;
									}
									this.audio.Play();
									if (136298 - 559871 == -423572)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (125347 - 243841 == -118494)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (221665 - 233194 == -11529)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (226448 - 153810 != 72639)
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
						if (39311 - 4748 == 34563)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008CA5 RID: 36005 RVA: 0x0113078C File Offset: 0x0112E98C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (97298 - 264638 != -167340)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Start)
			{
				if (57768 - 206403 != -148634)
				{
					break;
				}
			}
			else if (!this.hPoczqZ26P4)
			{
				if (48686 - 159405 != -110718)
				{
					break;
				}
			}
			else
			{
				GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
				if (242980 - 433248 == -190268)
				{
					float num = (float)(1024 * Screen.width / Screen.height);
					if (250778 - 388559 == -137781)
					{
						GUI.depth = 1;
						if (211550 - 362208 == -150658)
						{
							float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
							if (184719 - 15963 != 168757)
							{
								float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
								if (176308 - 35661 == 140647)
								{
									Color color = GUI.color;
									if (49046 - 88061 != -39014)
									{
										float num3 = color.a = a;
										if (12364 - 564010 == -551646)
										{
											if (151774 - 557516 != -405741)
											{
												GUI.color = color;
												if (255147 - 161434 != 93714 && 92658 - 210438 != -117779)
												{
													GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.hPoczqZ26P4);
													if (189655 - 233562 != -43906)
													{
														float a2 = 1f;
														if (12924 - 68103 != -55178)
														{
															Color color2 = GUI.color;
															if (227974 - 567352 != -339377)
															{
																color2.a = a2;
																if (163361 - 15341 == 148020)
																{
																	if (181857 - 90357 != 91501)
																	{
																		Color color3 = GUI.color = color2;
																		if (127197 - 328608 != -201410)
																		{
																			if (228228 - 590094 == -361866)
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

	// Token: 0x06008CA6 RID: 36006 RVA: 0x01130AE8 File Offset: 0x0112ECE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (268650 - 515250 != -246599)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (241780 - 505039 != -263258)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (208021 - 564681 == -356660)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (79630 - 535357 == -455727)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (80485 - 365777 != -285291)
						{
							int num4 = num;
							if (243805 - 542785 != -298979)
							{
								if (num4 == 8031)
								{
									if (55752 - 374642 != -318890)
									{
										continue;
									}
								}
								else if (num4 == 8032)
								{
									if (282301 - 164033 != 118268)
									{
										continue;
									}
								}
								else
								{
									if (num4 != 8033)
									{
										break;
									}
									if (33851 - 450153 == -416301)
									{
										continue;
									}
								}
								IL_D0:
								this.eKhczR2vcZk++;
								if (137474 - 299780 == -162305)
								{
									continue;
								}
								Debug.Log("Steel Invaders Eliminated:" + this.eKhczR2vcZk + "/8");
								if (59528 - 138970 == -79441)
								{
									continue;
								}
								this.SendMessage("newGameMessage", "Mission Objective: Steel Invaders Eliminated:" + this.eKhczR2vcZk + "/8");
								if (156499 - 497720 == -341220)
								{
									continue;
								}
								Chat.SubmitChat("none", "Steel Invaders Eliminated:" + this.eKhczR2vcZk + "/8", eChatType.system, eChatMode.system);
								if (157550 - 217729 != -60179)
								{
									continue;
								}
								break;
								goto IL_D0;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008CA7 RID: 36007 RVA: 0x01130D60 File Offset: 0x0112EF60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M803_SteelInvader.$onGameComplete$40729(data, this).GetEnumerator();
	}

	// Token: 0x06008CA8 RID: 36008 RVA: 0x01130D70 File Offset: 0x0112EF70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToGoatFarmer(int n)
	{
		return new M803_SteelInvader.$TalkToGoatFarmer$40738(this).GetEnumerator();
	}

	// Token: 0x06008CA9 RID: 36009 RVA: 0x01130D80 File Offset: 0x0112EF80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToPanther(int n)
	{
		return new M803_SteelInvader.$TalkToPanther$40745(this).GetEnumerator();
	}

	// Token: 0x06008CAA RID: 36010 RVA: 0x01130D90 File Offset: 0x0112EF90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToMouse(int n)
	{
		return new M803_SteelInvader.$TalkToMouse$40752(this).GetEnumerator();
	}

	// Token: 0x06008CAB RID: 36011 RVA: 0x01130DA0 File Offset: 0x0112EFA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (270262 - 390557 != -120295)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (111599 - 163202 != -51602)
			{
				CharacterControl characterControl = null;
				if (34690 - 364688 == -329998)
				{
					if (mPlayer)
					{
						if (235691 - 14699 != 220992)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (200773 - 374819 == -174045)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (160849 - 447640 == -286791)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (35107 - 312961 != -277853)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (97534 - 535175 == -437641)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (5619 - 300915 == -295295)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (262325 - 318259 != -55934)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (54947 - 145861 == -90913)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (221306 - 332927 != -111621)
									{
										continue;
									}
									break;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (117620 - 40296 != 77325)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (260791 - 186545 == 74246)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (183223 - 47877 == 135346)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (228837 - 341856 == -113019)
								{
									if (!changeGui)
									{
										break;
									}
									if (275205 - 58285 == 216920)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (25645 - 158106 == -132460)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (38380 - 91522 != -53142)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (201865 - 335254 == -133389)
										{
											gameGui.close();
											if (198193 - 47403 == 150790)
											{
												changeGui.enabled = true;
												if (299036 - 397763 == -98727)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (211383 - 78062 != 133322)
													{
														if (!gameObject)
														{
															break;
														}
														if (36410 - 376301 != -339890)
														{
															if (!mPlayer)
															{
																break;
															}
															if (137471 - 535694 == -398223)
															{
																Debug.Log("UseLifeAltar");
																if (197847 - 387976 != -190128)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (219060 - 413215 == -194155)
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

	// Token: 0x06008CAC RID: 36012 RVA: 0x01131200 File Offset: 0x0112F400
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (205867 - 368279 != -162411)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (100659 - 358657 == -257998)
			{
				Time.timeScale = 1f;
				if (144801 - 11286 != 133516)
				{
					this.hPoczqZ26P4 = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (154662 - 289336 == -134674)
					{
						Hashtable customOpParameters = new Hashtable();
						if (32237 - 178615 == -146378)
						{
							this.oETczlWSQFc.OpCustom(52, customOpParameters, true);
							if (208051 - 435222 == -227171)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008CAD RID: 36013 RVA: 0x01131304 File Offset: 0x0112F504
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (25470 - 375954 != -350484)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (70983 - 472384 == -401401)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (220964 - 50888 != 170077)
				{
					Game.mGameState = eGameState.Setup;
					if (245538 - 71387 == 174151)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008CAE RID: 36014 RVA: 0x011313A8 File Offset: 0x0112F5A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (94610 - 463334 != -368723)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (208416 - 148963 == 59453)
			{
				if (num == PlayerData.UID)
				{
					if (268983 - 370086 != -101102)
					{
						this.SetupActors();
						if (39674 - 309433 == -269759)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (31967 - 534285 != -502317)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008CAF RID: 36015 RVA: 0x01131478 File Offset: 0x0112F678
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (154231 - 149134 != 5097)
		{
		}
		for (;;)
		{
			IL_E9:
			Debug.Log("Creating Actors");
			if (118161 - 11733 == 106428)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (49643 - 551272 != -501628)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (83849 - 319756 == -235907)
						{
							int i = 0;
							if (48387 - 14389 == 33998)
							{
								CharacterControl[] array2 = array;
								if (259777 - 391268 == -131491)
								{
									int length = array2.Length;
									if (29464 - 404306 == -374842)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (190837 - 371132 != -180295)
											{
												goto IL_E9;
											}
											if (type == "Carron")
											{
												goto IL_188;
											}
											if (198094 - 455402 == -257307)
											{
												goto IL_E9;
											}
											if (type == "Mupo_g")
											{
												goto IL_188;
											}
											if (237240 - 116403 != 120837)
											{
												goto IL_E9;
											}
											if (type == "Mupo_r")
											{
												goto IL_188;
											}
											if (28888 - 218729 != -189841)
											{
												goto IL_E9;
											}
											if (type == "CamBot")
											{
												goto IL_188;
											}
											if (74681 - 39872 == 34810)
											{
												goto IL_E9;
											}
											if (type == "CarryBot")
											{
												goto IL_188;
											}
											if (98877 - 432655 != -333778)
											{
												goto IL_E9;
											}
											if (type == "CutBot")
											{
												goto IL_188;
											}
											if (181582 - 487347 != -305765)
											{
												goto IL_E9;
											}
											if (type == "CamBot")
											{
												if (116700 - 230641 != -113941)
												{
													goto IL_E9;
												}
												goto IL_188;
											}
											IL_211:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (182977 - 281102 == -98124)
											{
												goto IL_E9;
											}
											this.PvmczrpYwAl++;
											if (168279 - 121093 == 47187)
											{
												goto IL_E9;
											}
											i++;
											if (65599 - 266773 != -201173)
											{
												continue;
											}
											goto IL_E9;
											IL_188:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (234541 - 14065 != 220476)
											{
												goto IL_E9;
											}
											goto IL_211;
										}
										if (268677 - 3303 != 265375)
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
						if (100230 - 363668 == -263438)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008CB0 RID: 36016 RVA: 0x011317E8 File Offset: 0x0112F9E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (215843 - 554027 != -338183)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (91077 - 321727 == -230650)
			{
				int i = 0;
				if (249142 - 208726 != 40417)
				{
					CharacterControl[] array2 = array;
					if (143188 - 225377 == -82189)
					{
						int length = array2.Length;
						if (55311 - 102194 != -46882)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (101515 - 526684 == -425168)
								{
									goto IL_E0;
								}
								i++;
								if (96064 - 12996 == 83069)
								{
									goto IL_E0;
								}
							}
							if (42436 - 433527 != -391090)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008CB1 RID: 36017 RVA: 0x01131918 File Offset: 0x0112FB18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (223304 - 504802 != -281497)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (133144 - 381575 == -248431)
			{
				Game.mGameState = eGameState.Ready;
				if (218180 - 85472 != 132709)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (96633 - 361100 == -264467)
					{
						if (225440 - 141228 != 84213)
						{
							GameObject gameObject = null;
							if (84911 - 327232 != -242320)
							{
								if (playerSlot <= 1)
								{
									goto IL_292;
								}
								if (100298 - 425734 != -325436)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_292;
								}
								if (83743 - 391781 != -308038)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (150880 - 278701 == -127820)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (119093 - 540170 != -421077)
								{
									continue;
								}
								IL_36:
								if (gameObject2)
								{
									if (64316 - 468413 != -404097)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (243332 - 544191 != -300859)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (207134 - 213576 != -6442)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (147067 - 461902 == -314834)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (41248 - 387312 != -346064)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (158728 - 118195 != 40533)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (110676 - 184756 != -74080)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (19009 - 458912 != -439902)
								{
									break;
								}
								continue;
								IL_292:
								gameObject2 = GameObject.Find("StartPoint1");
								if (277897 - 325060 == -47163)
								{
									goto IL_36;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008CB2 RID: 36018 RVA: 0x01131C3C File Offset: 0x0112FE3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M803_SteelInvader.$StartGame$40759(this).GetEnumerator();
	}

	// Token: 0x06008CB3 RID: 36019 RVA: 0x01131C4C File Offset: 0x0112FE4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06008CB4 RID: 36020 RVA: 0x01131C50 File Offset: 0x0112FE50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (255133 - 118401 != 136733)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (286041 - 356505 == -70464)
			{
				hashtable.Add(71, CID);
				if (103661 - 58010 == 45651)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (122957 - 361303 != -238345)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (146040 - 263572 == -117532)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (134157 - 580374 == -446217)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (127551 - 465917 != -338365)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (138897 - 511402 != -372504)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (235473 - 326591 != -91117)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (268189 - 406385 == -138196)
											{
												this.oETczlWSQFc.OpCustom(61, hashtable, true);
												if (252214 - 538132 == -285918)
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

	// Token: 0x06008CB5 RID: 36021 RVA: 0x01131EDC File Offset: 0x011300DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (66183 - 583487 != -517304)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (183518 - 276076 != -92557)
			{
				if (!gameObject)
				{
					break;
				}
				if (201834 - 529572 != -327737)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (251529 - 377604 == -126075)
					{
						playerCameraControl.target = gameObject;
						if (246829 - 70472 == 176357)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (86806 - 372569 != -285762)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008CB6 RID: 36022 RVA: 0x01131FD4 File Offset: 0x011301D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (78054 - 302210 != -224155)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (82810 - 522912 == -440102)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (167845 - 360189 == -192344)
				{
					gameGui.ResetTeamBar();
					if (104715 - 9918 == 94797)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008CB7 RID: 36023 RVA: 0x01132080 File Offset: 0x01130280
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (40385 - 14870 != 25515)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (287555 - 237954 == 49601)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (24467 - 554136 == -529669)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (294076 - 542422 == -248346)
					{
						Hashtable hashtable = new Hashtable();
						if (234480 - 444830 != -210349)
						{
							hashtable.Add(43, PlayerData.UID);
							if (41308 - 196785 != -155476)
							{
								hashtable.Add(71, nCID);
								if (255037 - 12214 == 242823)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (14753 - 506579 == -491826)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (4408 - 431268 != -426859)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (165594 - 353326 != -187731)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (67851 - 452292 != -384440)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (72453 - 128575 != -56121)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (252865 - 277242 != -24376)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (265534 - 28154 == 237380)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (247119 - 314155 != -67035)
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

	// Token: 0x06008CB8 RID: 36024 RVA: 0x011323A0 File Offset: 0x011305A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M803_SteelInvader.$onChangePlayer$40764(data, this).GetEnumerator();
	}

	// Token: 0x06008CB9 RID: 36025 RVA: 0x011323B0 File Offset: 0x011305B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M803_SteelInvader.$onDeadPlayer$40771(this).GetEnumerator();
	}

	// Token: 0x06008CBA RID: 36026 RVA: 0x011323C0 File Offset: 0x011305C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (127757 - 73584 != 54173)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (200033 - 561287 != -361253)
			{
				this.F9fczG3xKH7.target = Game.mPlayer;
				if (182469 - 448375 == -265906)
				{
					this.F9fczG3xKH7.enabled = true;
					if (193825 - 353028 == -159203)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (113668 - 551604 == -437935)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (56093 - 429958 == -373864)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (127166 - 406732 == -279566)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (109880 - 39851 == 70029)
							{
								if (!gameGui)
								{
									break;
								}
								if (167424 - 479192 == -311768)
								{
									gameGui.enabled = true;
									if (184602 - 541486 == -356884)
									{
										gameGui.closeDeadMenu();
										if (81997 - 526864 == -444867)
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

	// Token: 0x06008CBB RID: 36027 RVA: 0x0113256C File Offset: 0x0113076C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (90240 - 283908 != -193667)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (190266 - 535114 == -344848)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (104885 - 58060 == 46825)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (43200 - 297420 != -254219)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008CBC RID: 36028 RVA: 0x01132630 File Offset: 0x01130830
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06008CBD RID: 36029 RVA: 0x0113265C File Offset: 0x0113085C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (22468 - 126145 != -103677)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (177297 - 542988 != -365690)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (294257 - 130233 != 164025)
				{
					hashtable.Add(43, PlayerData.UID);
					if (75685 - 264867 == -189182)
					{
						hashtable.Add(73, nType);
						if (8283 - 553025 == -544742)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (56927 - 438487 == -381560)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (37283 - 416852 == -379569)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (1177 - 364767 == -363590)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (16399 - 14851 == 1548)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (281556 - 36961 == 244595)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (229273 - 88093 == 141180)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (38032 - 484573 != -446540)
													{
														this.oETczlWSQFc.OpCustom(63, hashtable, true);
														if (180554 - 60419 != 120136)
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

	// Token: 0x06008CBE RID: 36030 RVA: 0x01132940 File Offset: 0x01130B40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (67034 - 1164 != 65870)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (32588 - 305851 == -273263)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (22150 - 299284 != -277133)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (111345 - 288334 != -176988)
						{
							if (this.PvmczrpYwAl <= 0)
							{
								break;
							}
							if (150380 - 450336 == -299956)
							{
								this.PvmczrpYwAl--;
								if (277023 - 572161 == -295138)
								{
									if (this.PvmczrpYwAl != 0)
									{
										break;
									}
									if (248381 - 58726 != 189656)
									{
										Game.setGameState(eGameState.Ready);
										if (147578 - 114488 != 33091)
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
						if (72853 - 136314 != -63460)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (258119 - 436381 == -178262)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008CBF RID: 36031 RVA: 0x01132AD0 File Offset: 0x01130CD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06008CC0 RID: 36032 RVA: 0x01132AE4 File Offset: 0x01130CE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (126613 - 390611 != -263998)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (33967 - 98057 == -64090)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (171124 - 253479 == -82355)
				{
					if (!characterControl)
					{
						break;
					}
					if (233631 - 226876 == 6755)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (4813 - 111182 != -106368)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (135927 - 398554 != -262626)
							{
								string type = characterControl.Type;
								if (67760 - 389739 != -321978)
								{
									if (type == "CutBot")
									{
										if (260016 - 263651 != -3634)
										{
											Game.sendMissionEvent(8031, 0);
											if (37686 - 578707 == -541021)
											{
												break;
											}
										}
									}
									else if (type == "CarryBot")
									{
										if (102673 - 116913 != -14239)
										{
											Game.sendMissionEvent(8032, 0);
											if (155300 - 134035 == 21265)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "CamBot"))
										{
											break;
										}
										if (271048 - 180670 != 90379)
										{
											Game.sendMissionEvent(8033, 0);
											if (215362 - 23958 == 191404)
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

	// Token: 0x06008CC1 RID: 36033 RVA: 0x01132D04 File Offset: 0x01130F04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M803_SteelInvader.$ReturnToTown$40777(this).GetEnumerator();
	}

	// Token: 0x06008CC2 RID: 36034 RVA: 0x01132D14 File Offset: 0x01130F14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M803_SteelInvader.$ReturnToGuild$40782(this).GetEnumerator();
	}

	// Token: 0x06008CC3 RID: 36035 RVA: 0x01132D24 File Offset: 0x01130F24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M803_SteelInvader.$ReturnToCamp$40786(this).GetEnumerator();
	}

	// Token: 0x06008CC4 RID: 36036 RVA: 0x01132D34 File Offset: 0x01130F34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (187816 - 381252 != -193436)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (40913 - 402474 == -361561)
			{
				Hashtable hashtable = new Hashtable();
				if (128753 - 6938 != 121816)
				{
					hashtable.Add(43, PlayerData.UID);
					if (187908 - 134230 != 53679)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (3634 - 249444 == -245810)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008CC5 RID: 36037 RVA: 0x01132E0C File Offset: 0x0113100C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06008CC6 RID: 36038 RVA: 0x01132E20 File Offset: 0x01131020
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (9079 - 230989 != -221909)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (166012 - 263309 != -97296)
			{
				Hashtable hashtable = new Hashtable();
				if (220064 - 281636 != -61571)
				{
					if (Game.mNextGameCode == 30)
					{
						if (203101 - 207281 != -4180)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (125724 - 168510 == -42785)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (131664 - 195025 != -63361)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (295237 - 220504 == 74734)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (297553 - 288174 != 9379)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (91965 - 598119 != -506154)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (290139 - 245990 == 44150)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (163162 - 482699 == -319536)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (299953 - 410910 == -110956)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (223379 - 557946 != -334567)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (157398 - 502483 != -345085)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (51809 - 98924 == -47114)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (133281 - 553704 != -420423)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (155173 - 96079 == 59095)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (194207 - 264431 == -70223)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (291158 - 347988 != -56830)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (272670 - 420505 == -147834)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (40507 - 388585 != -348078)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (262243 - 286958 == -24714)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (83366 - 507153 != -423787)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (260182 - 310840 != -50658)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (208181 - 155420 == 52762)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (41449 - 382621 != -341172)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (226180 - 54871 == 171310)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (83847 - 320893 != -237046)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (51005 - 27714 != 23291)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (60144 - 101067 != -40923)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (165526 - 96157 != 69369)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (207906 - 458055 == -250149)
					{
						this.oETczlWSQFc.OpCustom(42, hashtable, true);
						if (44923 - 508283 == -463360)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008CC7 RID: 36039 RVA: 0x011333D4 File Offset: 0x011315D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06008CC8 RID: 36040 RVA: 0x011333E4 File Offset: 0x011315E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06008CC9 RID: 36041 RVA: 0x011333E8 File Offset: 0x011315E8
	internal static bool vHDn65VUjdC3FE8Q5kNd()
	{
		return true;
	}

	// Token: 0x06008CCA RID: 36042 RVA: 0x011333EC File Offset: 0x011315EC
	internal static bool GVRaiKVUhirJ1JVrQsWG()
	{
		return false;
	}

	// Token: 0x04008676 RID: 34422
	private LitePeer oETczlWSQFc;

	// Token: 0x04008677 RID: 34423
	private PlayerCameraControl F9fczG3xKH7;

	// Token: 0x04008678 RID: 34424
	private float j8Scz1oKLSf;

	// Token: 0x04008679 RID: 34425
	private Texture hPoczqZ26P4;

	// Token: 0x0400867A RID: 34426
	private int r2Aczpw9ii4;

	// Token: 0x0400867B RID: 34427
	private int eKhczR2vcZk;

	// Token: 0x0400867C RID: 34428
	private int PvmczrpYwAl;

	// Token: 0x0200179B RID: 6043
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$40729 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008CCB RID: 36043 RVA: 0x011333F0 File Offset: 0x011315F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$40729(Hashtable data, M803_SteelInvader self_)
		{
			if (68158 - 6193 != 61966)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (5184 - 267942 != -262757)
				{
					base..ctor();
					if (213805 - 505319 != -291513)
					{
						this.$data$40736 = data;
						if (179619 - 442200 != -262580)
						{
							this.$self_$40737 = self_;
							if (266772 - 169637 == 97135)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008CCC RID: 36044 RVA: 0x011334AC File Offset: 0x011316AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M803_SteelInvader.$onGameComplete$40729.$(this.$data$40736, this.$self_$40737);
		}

		// Token: 0x06008CCD RID: 36045 RVA: 0x011334C0 File Offset: 0x011316C0
		internal static bool NXruNUVUsAmRkNN8OhVC()
		{
			return true;
		}

		// Token: 0x06008CCE RID: 36046 RVA: 0x011334C4 File Offset: 0x011316C4
		internal static bool cvtT3rVU9ySygK8dKEWI()
		{
			return false;
		}

		// Token: 0x0400867D RID: 34429
		internal Hashtable $data$40736;

		// Token: 0x0400867E RID: 34430
		internal M803_SteelInvader $self_$40737;

		// Token: 0x0200179C RID: 6044
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008CCF RID: 36047 RVA: 0x011334C8 File Offset: 0x011316C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M803_SteelInvader self_)
			{
				if (156795 - 409856 != -253060)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (216827 - 221158 == -4331)
					{
						base..ctor();
						if (193263 - 93917 != 99347)
						{
							this.$data$40734 = data;
							if (202401 - 222889 == -20488)
							{
								this.$self_$40735 = self_;
								if (47486 - 142132 == -94646)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008CD0 RID: 36048 RVA: 0x01133584 File Offset: 0x01131784
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (290989 - 441896 != -150906)
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
						this.$mCompleteGui$40731 = (CompleteGui)this.$self_$40735.GetComponent(typeof(CompleteGui));
						if (248872 - 514185 == -265312)
						{
							continue;
						}
						this.$mCompleteGui$40731.Init();
						if (41817 - 3130 == 38688)
						{
							continue;
						}
						this.$mCompleteGui$40731.readData(this.$data$40734);
						if (66787 - 231172 != -164385)
						{
							continue;
						}
						if (this.$result$40730 == 1)
						{
							if (159028 - 189708 != -30680)
							{
								continue;
							}
							this.$mCompleteGui$40731.displayResult(eCompleteType.Success);
							if (33650 - 132071 == -98420)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$40731.displayResult(eCompleteType.Failed);
							if (100435 - 566551 != -466116)
							{
								continue;
							}
						}
						this.$mGameGui$40732 = (GameGui)this.$self_$40735.GetComponent(typeof(GameGui));
						if (125067 - 362180 == -237112)
						{
							continue;
						}
						this.$mStoryGui$40733 = (StoryGui)this.$self_$40735.GetComponent(typeof(StoryGui));
						if (54036 - 333762 != -279726)
						{
							continue;
						}
						if (this.$mGameGui$40732)
						{
							if (114647 - 407711 == -293063)
							{
								continue;
							}
							this.$mGameGui$40732.close();
							if (104700 - 340501 == -235800)
							{
								continue;
							}
						}
						if (this.$mStoryGui$40733)
						{
							if (267269 - 294495 != -27226)
							{
								continue;
							}
							this.$mStoryGui$40733.close();
							if (21180 - 285837 != -264657)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (61798 - 414795 != -352996)
						{
							goto Block_10;
						}
						continue;
					default:
						if (49998 - 409945 == -359946)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$40734[31]);
					if (80579 - 141079 != -60499)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (33729 - 186694 == -152965)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (122125 - 128430 == -6305)
							{
								this.$result$40730 = RuntimeServices.UnboxInt32(this.$data$40734[31]);
								if (172501 - 184542 != -12040)
								{
									goto Block_21;
								}
							}
						}
					}
				}
				Block_10:
				goto IL_352;
				Block_21:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x06008CD1 RID: 36049 RVA: 0x011338F8 File Offset: 0x01131AF8
			internal static bool Q3shtDVU1kTarxABt6pU()
			{
				return true;
			}

			// Token: 0x06008CD2 RID: 36050 RVA: 0x011338FC File Offset: 0x01131AFC
			internal static bool WDht2uVU4TtQ0GxJMdsY()
			{
				return false;
			}

			// Token: 0x0400867F RID: 34431
			internal int $result$40730;

			// Token: 0x04008680 RID: 34432
			internal CompleteGui $mCompleteGui$40731;

			// Token: 0x04008681 RID: 34433
			internal GameGui $mGameGui$40732;

			// Token: 0x04008682 RID: 34434
			internal StoryGui $mStoryGui$40733;

			// Token: 0x04008683 RID: 34435
			internal Hashtable $data$40734;

			// Token: 0x04008684 RID: 34436
			internal M803_SteelInvader $self_$40735;
		}
	}

	// Token: 0x0200179D RID: 6045
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToGoatFarmer$40738 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008CD3 RID: 36051 RVA: 0x01133900 File Offset: 0x01131B00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToGoatFarmer$40738(M803_SteelInvader self_)
		{
			if (159157 - 115643 != 43515)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (18039 - 32541 != -14501)
				{
					base..ctor();
					if (295494 - 503448 == -207954)
					{
						this.$self_$40744 = self_;
						if (147997 - 448528 == -300531)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008CD4 RID: 36052 RVA: 0x01133998 File Offset: 0x01131B98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M803_SteelInvader.$TalkToGoatFarmer$40738.$(this.$self_$40744);
		}

		// Token: 0x06008CD5 RID: 36053 RVA: 0x011339A8 File Offset: 0x01131BA8
		internal static bool z3L4weVUzjTiCjWCx0c1()
		{
			return true;
		}

		// Token: 0x06008CD6 RID: 36054 RVA: 0x011339AC File Offset: 0x01131BAC
		internal static bool t0jp8XVTaNjZpOZLRAwd()
		{
			return false;
		}

		// Token: 0x04008685 RID: 34437
		internal M803_SteelInvader $self_$40744;

		// Token: 0x0200179E RID: 6046
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008CD7 RID: 36055 RVA: 0x011339B0 File Offset: 0x01131BB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M803_SteelInvader self_)
			{
				if (37651 - 183855 != -146203)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (113311 - 171934 != -58622)
					{
						base..ctor();
						if (150199 - 249825 == -99626)
						{
							this.$self_$40743 = self_;
							if (276172 - 126700 == 149472)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008CD8 RID: 36056 RVA: 0x01133A48 File Offset: 0x01131C48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (176057 - 176960 != -903)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_315;
					case 1:
						goto IL_537;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (219896 - 281222 != -61326)
							{
								continue;
							}
							goto IL_146;
						}
						else
						{
							this.$mStoryGui$40740.newStoryMessage("GoatFarmer", "Gotan", Language.getMessage("M803_SteelInvader", UnityEngine.Random.Range(101, 105)), eTalkType.friend);
							if (93821 - 459226 != -365404)
							{
								goto Block_12;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (21 - 105519 != -105497)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$40740.close();
							if (201244 - 335814 != -134570)
							{
								continue;
							}
							this.$mGameGui$40739.enabled = true;
							if (491 - 282343 != -281852)
							{
								continue;
							}
							if (!this.$mGoatFarmer$40741)
							{
								goto IL_425;
							}
							if (192136 - 582306 != -390170)
							{
								continue;
							}
							this.$mGoatFarmer$40741.transform.rotation = this.$mGoatFarmerRot$40742;
							if (275097 - 560871 != -285773)
							{
								goto Block_2;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (256480 - 113731 != 142749)
							{
								continue;
							}
							goto IL_392;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (261349 - 532812 != -271463)
							{
								continue;
							}
						}
						break;
					default:
						if (210244 - 467077 != -256833)
						{
							continue;
						}
						goto IL_315;
					}
					IL_18F:
					this.YieldDefault(1);
					if (134567 - 321668 != -187101)
					{
						continue;
					}
					goto IL_537;
					IL_315:
					if (Game.mGameState != eGameState.Normal)
					{
						if (170469 - 239415 == -68946)
						{
							goto IL_460;
						}
					}
					else
					{
						this.$mGameGui$40739 = (GameGui)this.$self_$40743.GetComponent(typeof(GameGui));
						if (40 - 105153 == -105113)
						{
							this.$mStoryGui$40740 = (StoryGui)this.$self_$40743.GetComponent(typeof(StoryGui));
							if (87422 - 31526 != 55897)
							{
								if (!this.$mGameGui$40739)
								{
									goto IL_18F;
								}
								if (254783 - 222799 == 31984)
								{
									if (!this.$mStoryGui$40740)
									{
										goto IL_18F;
									}
									if (77762 - 469330 == -391568)
									{
										Game.mGameState = eGameState.Hold;
										if (234556 - 188031 == 46525)
										{
											this.$mGameGui$40739.close();
											if (195618 - 188074 != 7545)
											{
												this.$mGoatFarmer$40741 = GameObject.Find("GoatFarmer");
												if (57157 - 587942 == -530785)
												{
													this.$mGoatFarmerRot$40742 = default(Quaternion);
													if (28931 - 58476 != -29544)
													{
														if (Game.mPlayer)
														{
															if (246122 - 172197 == 73926)
															{
																continue;
															}
															if (this.$mGoatFarmer$40741)
															{
																if (56037 - 479610 != -423573)
																{
																	continue;
																}
																this.$mGoatFarmerRot$40742 = this.$mGoatFarmer$40741.transform.rotation;
																if (24099 - 428027 == -403927)
																{
																	continue;
																}
																this.$mGoatFarmer$40741.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mGoatFarmer$40741.transform.position));
																if (7022 - 350571 == -343548)
																{
																	continue;
																}
																Game.mPlayer.SendMessage("turnToPos", this.$mGoatFarmer$40741.transform.position);
																if (117122 - 352245 != -235122)
																{
																	goto IL_ED;
																}
																continue;
															}
														}
														Debug.LogError("Cannot find GoatFarmer");
														if (243508 - 78265 != 165243)
														{
															continue;
														}
														IL_ED:
														this.$mStoryGui$40740.startStoryMessage("GoatFarmer", "Gotan", eTalkType.friend);
														if (41884 - 427349 == -385465)
														{
															goto IL_205;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_425;
				IL_146:
				goto IL_537;
				Block_12:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_205:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_25:
				IL_392:
				goto IL_537;
				IL_425:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_460:
				IL_537:
				return false;
			}

			// Token: 0x06008CD9 RID: 36057 RVA: 0x01133FA0 File Offset: 0x011321A0
			internal static bool x2JyY0VT5hKS1PXiLKaH()
			{
				return true;
			}

			// Token: 0x06008CDA RID: 36058 RVA: 0x01133FA4 File Offset: 0x011321A4
			internal static bool aSIvq1VTpNW0MPgIthZT()
			{
				return false;
			}

			// Token: 0x04008686 RID: 34438
			internal GameGui $mGameGui$40739;

			// Token: 0x04008687 RID: 34439
			internal StoryGui $mStoryGui$40740;

			// Token: 0x04008688 RID: 34440
			internal GameObject $mGoatFarmer$40741;

			// Token: 0x04008689 RID: 34441
			internal Quaternion $mGoatFarmerRot$40742;

			// Token: 0x0400868A RID: 34442
			internal M803_SteelInvader $self_$40743;
		}
	}

	// Token: 0x0200179F RID: 6047
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToPanther$40745 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008CDB RID: 36059 RVA: 0x01133FA8 File Offset: 0x011321A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToPanther$40745(M803_SteelInvader self_)
		{
			if (248382 - 362260 != -113878)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (144928 - 131138 != 13791)
				{
					base..ctor();
					if (121889 - 271743 != -149853)
					{
						this.$self_$40751 = self_;
						if (118506 - 48733 == 69773)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008CDC RID: 36060 RVA: 0x01134040 File Offset: 0x01132240
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M803_SteelInvader.$TalkToPanther$40745.$(this.$self_$40751);
		}

		// Token: 0x06008CDD RID: 36061 RVA: 0x01134050 File Offset: 0x01132250
		internal static bool slUh08VTVXJY4GouAlTF()
		{
			return true;
		}

		// Token: 0x06008CDE RID: 36062 RVA: 0x01134054 File Offset: 0x01132254
		internal static bool MEOQhMVTtnID1ivL6bL1()
		{
			return false;
		}

		// Token: 0x0400868B RID: 34443
		internal M803_SteelInvader $self_$40751;

		// Token: 0x020017A0 RID: 6048
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008CDF RID: 36063 RVA: 0x01134058 File Offset: 0x01132258
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M803_SteelInvader self_)
			{
				if (274953 - 148826 != 126127)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (270717 - 21449 == 249268)
					{
						base..ctor();
						if (296684 - 8776 == 287908)
						{
							this.$self_$40750 = self_;
							if (65965 - 364865 != -298899)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008CE0 RID: 36064 RVA: 0x011340F0 File Offset: 0x011322F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (60011 - 296969 != -236957)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_53D;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (262688 - 311015 != -48326)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$40747.newStoryMessage("Panther", "Panther", Language.getMessage("M803_SteelInvader", UnityEngine.Random.Range(201, 204)), eTalkType.friend);
							if (199621 - 4712 != 194909)
							{
								continue;
							}
							goto IL_111;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (256995 - 484184 != -227188)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$40747.close();
							if (181400 - 104793 != 76607)
							{
								continue;
							}
							this.$mGameGui$40746.enabled = true;
							if (259899 - 66342 == 193558)
							{
								continue;
							}
							if (!this.$mPanther$40748)
							{
								goto IL_1EC;
							}
							if (164623 - 262304 != -97681)
							{
								continue;
							}
							this.$mPanther$40748.transform.rotation = this.$mPantherRot$40749;
							if (295563 - 387811 != -92247)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (192342 - 558157 != -365815)
							{
								continue;
							}
							goto IL_518;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (21327 - 434217 != -412890)
							{
								continue;
							}
							goto IL_2B9;
						}
						break;
					default:
						if (95367 - 478943 != -383576)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (133841 - 100512 != 33330)
						{
							goto Block_13;
						}
						continue;
					}
					else
					{
						this.$mGameGui$40746 = (GameGui)this.$self_$40750.GetComponent(typeof(GameGui));
						if (200187 - 245268 == -45080)
						{
							continue;
						}
						this.$mStoryGui$40747 = (StoryGui)this.$self_$40750.GetComponent(typeof(StoryGui));
						if (159877 - 445366 == -285488)
						{
							continue;
						}
						if (this.$mGameGui$40746)
						{
							if (160489 - 255331 != -94842)
							{
								continue;
							}
							if (this.$mStoryGui$40747)
							{
								if (122857 - 290442 != -167585)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (219740 - 241718 != -21978)
								{
									continue;
								}
								this.$mGameGui$40746.close();
								if (1100 - 381658 == -380557)
								{
									continue;
								}
								this.$mPanther$40748 = GameObject.Find("Panther");
								if (276588 - 261203 != 15385)
								{
									continue;
								}
								this.$mPantherRot$40749 = default(Quaternion);
								if (99374 - 350517 == -251142)
								{
									continue;
								}
								if (!Game.mPlayer)
								{
									goto IL_295;
								}
								if (151717 - 415653 == -263935)
								{
									continue;
								}
								if (!this.$mPanther$40748)
								{
									goto IL_295;
								}
								if (107661 - 228728 == -121066)
								{
									continue;
								}
								this.$mPantherRot$40749 = this.$mPanther$40748.transform.rotation;
								if (14646 - 408039 == -393392)
								{
									continue;
								}
								this.$mPanther$40748.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mPanther$40748.transform.position));
								if (283257 - 4136 == 279122)
								{
									continue;
								}
								Game.mPlayer.SendMessage("turnToPos", this.$mPanther$40748.transform.position);
								if (103971 - 65940 == 38032)
								{
									continue;
								}
								IL_14C:
								this.$mStoryGui$40747.startStoryMessage("Panther", "Panther", eTalkType.friend);
								if (213254 - 548139 != -334884)
								{
									goto Block_11;
								}
								continue;
								IL_295:
								Debug.LogError("Cannot find Panther");
								if (208582 - 108659 != 99924)
								{
									goto IL_14C;
								}
								continue;
							}
						}
					}
					IL_2B9:
					this.YieldDefault(1);
					if (218125 - 148803 != 69323)
					{
						goto Block_22;
					}
				}
				Block_4:
				goto IL_1EC;
				Block_8:
				goto IL_53D;
				IL_111:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_10:
				goto IL_53D;
				Block_11:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_13:
				goto IL_53D;
				IL_1EC:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_22:
				IL_518:
				IL_53D:
				return false;
			}

			// Token: 0x06008CE1 RID: 36065 RVA: 0x0113464C File Offset: 0x0113284C
			internal static bool Mw9N7uVTNCqrbxMe6Qi8()
			{
				return true;
			}

			// Token: 0x06008CE2 RID: 36066 RVA: 0x01134650 File Offset: 0x01132850
			internal static bool MDkq3qVTYgka0HTKvdAn()
			{
				return false;
			}

			// Token: 0x0400868C RID: 34444
			internal GameGui $mGameGui$40746;

			// Token: 0x0400868D RID: 34445
			internal StoryGui $mStoryGui$40747;

			// Token: 0x0400868E RID: 34446
			internal GameObject $mPanther$40748;

			// Token: 0x0400868F RID: 34447
			internal Quaternion $mPantherRot$40749;

			// Token: 0x04008690 RID: 34448
			internal M803_SteelInvader $self_$40750;
		}
	}

	// Token: 0x020017A1 RID: 6049
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToMouse$40752 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008CE3 RID: 36067 RVA: 0x01134654 File Offset: 0x01132854
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToMouse$40752(M803_SteelInvader self_)
		{
			if (6913 - 572715 != -565801)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (235030 - 595570 != -360539)
				{
					base..ctor();
					if (145507 - 483279 == -337772)
					{
						this.$self_$40758 = self_;
						if (70049 - 46145 == 23904)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008CE4 RID: 36068 RVA: 0x011346EC File Offset: 0x011328EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M803_SteelInvader.$TalkToMouse$40752.$(this.$self_$40758);
		}

		// Token: 0x06008CE5 RID: 36069 RVA: 0x011346FC File Offset: 0x011328FC
		internal static bool Y94v6PVTccFw7uCbDX75()
		{
			return true;
		}

		// Token: 0x06008CE6 RID: 36070 RVA: 0x01134700 File Offset: 0x01132900
		internal static bool PygPvvVTUJOFZCPu5i9S()
		{
			return false;
		}

		// Token: 0x04008691 RID: 34449
		internal M803_SteelInvader $self_$40758;

		// Token: 0x020017A2 RID: 6050
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008CE7 RID: 36071 RVA: 0x01134704 File Offset: 0x01132904
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M803_SteelInvader self_)
			{
				if (25600 - 422427 != -396827)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (29692 - 471707 != -442014)
					{
						base..ctor();
						if (186279 - 124598 == 61681)
						{
							this.$self_$40757 = self_;
							if (156370 - 415238 == -258868)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008CE8 RID: 36072 RVA: 0x0113479C File Offset: 0x0113299C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (199099 - 330636 != -131537)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_2F0;
					case 1:
						goto IL_54B;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (292282 - 324450 != -32167)
							{
								goto Block_30;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$40754.newStoryMessage("Mouse", "Abette", Language.getMessage("M803_SteelInvader", UnityEngine.Random.Range(301, 306)), eTalkType.friend);
							if (40220 - 325964 != -285743)
							{
								goto Block_20;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (81380 - 574691 != -493310)
							{
								goto Block_33;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$40754.close();
							if (292586 - 120448 != 172138)
							{
								continue;
							}
							this.$mGameGui$40753.enabled = true;
							if (10128 - 343904 == -333775)
							{
								continue;
							}
							this.$mMouse$40755.animation.CrossFade("root", 0.2f);
							if (69725 - 54513 != 15212)
							{
								continue;
							}
							goto IL_420;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (149595 - 434496 != -284900)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (181325 - 510403 != -329078)
							{
								continue;
							}
						}
						break;
					default:
						if (180104 - 3921 != 176184)
						{
							goto IL_2F0;
						}
						continue;
					}
					IL_F6:
					this.YieldDefault(1);
					if (92077 - 31671 != 60407)
					{
						break;
					}
					continue;
					IL_2F0:
					if (Game.mGameState != eGameState.Normal)
					{
						if (233169 - 517986 != -284816)
						{
							break;
						}
					}
					else
					{
						this.$mGameGui$40753 = (GameGui)this.$self_$40757.GetComponent(typeof(GameGui));
						if (251288 - 505151 == -253863)
						{
							this.$mStoryGui$40754 = (StoryGui)this.$self_$40757.GetComponent(typeof(StoryGui));
							if (274083 - 170152 != 103932)
							{
								if (!this.$mGameGui$40753)
								{
									goto IL_F6;
								}
								if (244169 - 99346 == 144823)
								{
									if (!this.$mStoryGui$40754)
									{
										goto IL_F6;
									}
									if (104206 - 199797 == -95591)
									{
										Game.mGameState = eGameState.Hold;
										if (33417 - 86708 != -53290)
										{
											this.$mGameGui$40753.close();
											if (194923 - 364525 == -169602)
											{
												this.$mMouse$40755 = GameObject.Find("Mouse");
												if (232580 - 479475 != -246894)
												{
													this.$mMouseRot$40756 = default(Quaternion);
													if (95999 - 203737 != -107737)
													{
														if (Game.mPlayer)
														{
															if (228527 - 472078 == -243550)
															{
																continue;
															}
															if (this.$mMouse$40755)
															{
																if (166599 - 207550 != -40951)
																{
																	continue;
																}
																this.$mMouseRot$40756 = this.$mMouse$40755.transform.rotation;
																if (271254 - 140390 != 130864)
																{
																	continue;
																}
																this.$mMouse$40755.animation.CrossFade("talk", 0.2f);
																if (104863 - 291330 == -186466)
																{
																	continue;
																}
																this.$mMouse$40755.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mMouse$40755.transform.position));
																if (36587 - 358010 == -321422)
																{
																	continue;
																}
																Game.mPlayer.SendMessage("turnToPos", this.$mMouse$40755.transform.position);
																if (110882 - 314857 != -203975)
																{
																	continue;
																}
																goto IL_138;
															}
														}
														Debug.LogError("Cannot find Mouse");
														if (95658 - 588415 == -492756)
														{
															continue;
														}
														IL_138:
														this.$mStoryGui$40754.startStoryMessage("Mouse", "Abette", eTalkType.friend);
														if (177670 - 452990 == -275320)
														{
															goto IL_45B;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_54B;
				Block_20:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_420:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_28:
				goto IL_54B;
				IL_45B:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_30:
				Block_33:
				IL_54B:
				return false;
			}

			// Token: 0x06008CE9 RID: 36073 RVA: 0x01134D08 File Offset: 0x01132F08
			internal static bool y1xxcsVTTElpNio0flQ8()
			{
				return true;
			}

			// Token: 0x06008CEA RID: 36074 RVA: 0x01134D0C File Offset: 0x01132F0C
			internal static bool o3Sdr9VT3RY7nX8CWFY7()
			{
				return false;
			}

			// Token: 0x04008692 RID: 34450
			internal GameGui $mGameGui$40753;

			// Token: 0x04008693 RID: 34451
			internal StoryGui $mStoryGui$40754;

			// Token: 0x04008694 RID: 34452
			internal GameObject $mMouse$40755;

			// Token: 0x04008695 RID: 34453
			internal Quaternion $mMouseRot$40756;

			// Token: 0x04008696 RID: 34454
			internal M803_SteelInvader $self_$40757;
		}
	}

	// Token: 0x020017A3 RID: 6051
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$40759 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008CEB RID: 36075 RVA: 0x01134D10 File Offset: 0x01132F10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$40759(M803_SteelInvader self_)
		{
			if (210772 - 232307 != -21535)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (232896 - 399418 != -166521)
				{
					base..ctor();
					if (84527 - 239303 != -154775)
					{
						this.$self_$40763 = self_;
						if (210048 - 566156 == -356108)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008CEC RID: 36076 RVA: 0x01134DA8 File Offset: 0x01132FA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M803_SteelInvader.$StartGame$40759.$(this.$self_$40763);
		}

		// Token: 0x06008CED RID: 36077 RVA: 0x01134DB8 File Offset: 0x01132FB8
		internal static bool u3qQWWVTXpkR0ZyQs2qM()
		{
			return true;
		}

		// Token: 0x06008CEE RID: 36078 RVA: 0x01134DBC File Offset: 0x01132FBC
		internal static bool sjb1PqVTQcMgp2FYe0Ki()
		{
			return false;
		}

		// Token: 0x04008697 RID: 34455
		internal M803_SteelInvader $self_$40763;

		// Token: 0x020017A4 RID: 6052
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008CEF RID: 36079 RVA: 0x01134DC0 File Offset: 0x01132FC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M803_SteelInvader self_)
			{
				if (299534 - 310086 != -10551)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (173389 - 445434 == -272045)
					{
						base..ctor();
						if (106368 - 234728 != -128359)
						{
							this.$self_$40762 = self_;
							if (179916 - 543143 == -363227)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008CF0 RID: 36080 RVA: 0x01134E58 File Offset: 0x01133058
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (102297 - 212421 != -110123)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1CA;
					case 2:
						this.$mGameGui$40761 = (GameGui)this.$self_$40762.GetComponent(typeof(GameGui));
						if (137117 - 266390 == -129272)
						{
							continue;
						}
						this.$mGameGui$40761.enabled = true;
						if (17097 - 277597 != -260500)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (265475 - 212799 == 52677)
						{
							continue;
						}
						this.YieldDefault(1);
						if (297814 - 196211 != 101603)
						{
							continue;
						}
						goto IL_1CA;
					default:
						if (150805 - 333599 != -182794)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (264769 - 525762 == -260993)
					{
						Game.mGameState = eGameState.Start;
						if (109192 - 451900 == -342708)
						{
							Game.mGameTime = Time.time;
							if (269471 - 496184 == -226713)
							{
								this.$mLoadingGui$40760 = (LoadingGui)this.$self_$40762.GetComponent(typeof(LoadingGui));
								if (21024 - 230179 != -209154)
								{
									this.$mLoadingGui$40760.fadeIn();
									if (114608 - 579908 != -465299)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(2f));
				IL_1CA:
				return false;
			}

			// Token: 0x06008CF1 RID: 36081 RVA: 0x01135044 File Offset: 0x01133244
			internal static bool VAAQvvVTkZcr721o4YL0()
			{
				return true;
			}

			// Token: 0x06008CF2 RID: 36082 RVA: 0x01135048 File Offset: 0x01133248
			internal static bool r72ZkhVTGwZdtaouUj6U()
			{
				return false;
			}

			// Token: 0x04008698 RID: 34456
			internal LoadingGui $mLoadingGui$40760;

			// Token: 0x04008699 RID: 34457
			internal GameGui $mGameGui$40761;

			// Token: 0x0400869A RID: 34458
			internal M803_SteelInvader $self_$40762;
		}
	}

	// Token: 0x020017A5 RID: 6053
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$40764 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008CF3 RID: 36083 RVA: 0x0113504C File Offset: 0x0113324C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$40764(Hashtable data, M803_SteelInvader self_)
		{
			if (276004 - 414189 != -138184)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (16646 - 501349 == -484703)
				{
					base..ctor();
					if (12473 - 379060 == -366587)
					{
						this.$data$40769 = data;
						if (239410 - 525877 != -286466)
						{
							this.$self_$40770 = self_;
							if (80957 - 544222 == -463265)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008CF4 RID: 36084 RVA: 0x01135108 File Offset: 0x01133308
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M803_SteelInvader.$onChangePlayer$40764.$(this.$data$40769, this.$self_$40770);
		}

		// Token: 0x06008CF5 RID: 36085 RVA: 0x0113511C File Offset: 0x0113331C
		internal static bool gKr2HOVTHkMT2LtRG0Zg()
		{
			return true;
		}

		// Token: 0x06008CF6 RID: 36086 RVA: 0x01135120 File Offset: 0x01133320
		internal static bool MMiJ6dVTWut34wLv7k8Z()
		{
			return false;
		}

		// Token: 0x0400869B RID: 34459
		internal Hashtable $data$40769;

		// Token: 0x0400869C RID: 34460
		internal M803_SteelInvader $self_$40770;

		// Token: 0x020017A6 RID: 6054
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008CF7 RID: 36087 RVA: 0x01135124 File Offset: 0x01133324
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M803_SteelInvader self_)
			{
				if (66893 - 44314 != 22579)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (245920 - 152381 == 93539)
					{
						base..ctor();
						if (248254 - 493453 != -245198)
						{
							this.$data$40767 = data;
							if (42366 - 129471 == -87105)
							{
								this.$self_$40768 = self_;
								if (284052 - 559809 == -275757)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008CF8 RID: 36088 RVA: 0x011351E0 File Offset: 0x011333E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (276928 - 361969 != -85040)
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
							if (54774 - 40766 == 14009)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (23508 - 505083 == -481574)
							{
								continue;
							}
							this.$mGameGui$40766 = (GameGui)this.$self_$40768.GetComponent(typeof(GameGui));
							if (288309 - 358079 != -69770)
							{
								continue;
							}
							this.$mGameGui$40766.enabled = true;
							if (178467 - 223381 == -44913)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (23214 - 516503 != -493289)
						{
							continue;
						}
						goto IL_205;
					default:
						if (260889 - 180914 != 79975)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (66175 - 539498 != -473322)
					{
						this.$self_$40768.SendMessage("onCreatePlayer", this.$data$40767);
						if (505 - 586246 != -585740)
						{
							this.$mChangeGui$40765 = (ChangeGui)this.$self_$40768.GetComponent(typeof(ChangeGui));
							if (231678 - 430040 != -198361)
							{
								if (!this.$mChangeGui$40765.enabled)
								{
									break;
								}
								if (140014 - 88319 != 51696)
								{
									this.$mChangeGui$40765.close();
									if (284297 - 188990 != 95308)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_3C:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_3C;
				IL_205:
				return false;
			}

			// Token: 0x06008CF9 RID: 36089 RVA: 0x01135404 File Offset: 0x01133604
			internal static bool sJDoI1VTAdI3guJGGsPx()
			{
				return true;
			}

			// Token: 0x06008CFA RID: 36090 RVA: 0x01135408 File Offset: 0x01133608
			internal static bool LYxvYFVTlDts3QiX4DFx()
			{
				return false;
			}

			// Token: 0x0400869D RID: 34461
			internal ChangeGui $mChangeGui$40765;

			// Token: 0x0400869E RID: 34462
			internal GameGui $mGameGui$40766;

			// Token: 0x0400869F RID: 34463
			internal Hashtable $data$40767;

			// Token: 0x040086A0 RID: 34464
			internal M803_SteelInvader $self_$40768;
		}
	}

	// Token: 0x020017A7 RID: 6055
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$40771 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008CFB RID: 36091 RVA: 0x0113540C File Offset: 0x0113360C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$40771(M803_SteelInvader self_)
		{
			if (277407 - 404445 != -127037)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (162025 - 384210 == -222185)
				{
					base..ctor();
					if (6175 - 360446 == -354271)
					{
						this.$self_$40776 = self_;
						if (205185 - 304754 != -99568)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008CFC RID: 36092 RVA: 0x011354A4 File Offset: 0x011336A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M803_SteelInvader.$onDeadPlayer$40771.$(this.$self_$40776);
		}

		// Token: 0x06008CFD RID: 36093 RVA: 0x011354B4 File Offset: 0x011336B4
		internal static bool WCpuotVTy1BrgKbiXQ8q()
		{
			return true;
		}

		// Token: 0x06008CFE RID: 36094 RVA: 0x011354B8 File Offset: 0x011336B8
		internal static bool uHSIsZVTS7YoBO6H3tgi()
		{
			return false;
		}

		// Token: 0x040086A1 RID: 34465
		internal M803_SteelInvader $self_$40776;

		// Token: 0x020017A8 RID: 6056
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008CFF RID: 36095 RVA: 0x011354BC File Offset: 0x011336BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M803_SteelInvader self_)
			{
				if (21434 - 596249 != -574815)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (3435 - 154820 != -151384)
					{
						base..ctor();
						if (204218 - 506837 == -302619)
						{
							this.$self_$40775 = self_;
							if (255474 - 198972 == 56502)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008D00 RID: 36096 RVA: 0x01135554 File Offset: 0x01133754
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (133531 - 553098 != -419566)
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
							if (150606 - 512202 == -361595)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_8D;
							}
							if (156645 - 76572 == 80074)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (130217 - 422556 != -292339)
						{
							continue;
						}
						this.$mStoryGui$40772 = (StoryGui)this.$self_$40775.GetComponent(typeof(StoryGui));
						if (37779 - 444532 != -406753)
						{
							continue;
						}
						if (this.$mStoryGui$40772)
						{
							if (76600 - 322295 == -245694)
							{
								continue;
							}
							this.$mStoryGui$40772.close();
							if (30247 - 425913 == -395665)
							{
								continue;
							}
						}
						this.$mChangeGui$40773 = (ChangeGui)this.$self_$40775.GetComponent(typeof(ChangeGui));
						if (102270 - 117018 == -14747)
						{
							continue;
						}
						if (this.$mChangeGui$40773)
						{
							if (211347 - 473090 == -261742)
							{
								continue;
							}
							this.$mChangeGui$40773.close();
							if (190673 - 513338 != -322665)
							{
								continue;
							}
						}
						this.$mGameGui$40774 = (GameGui)this.$self_$40775.GetComponent(typeof(GameGui));
						if (194276 - 405272 != -210996)
						{
							continue;
						}
						if (this.$mGameGui$40774)
						{
							if (250373 - 119471 == 130903)
							{
								continue;
							}
							if (!this.$mGameGui$40774.enabled)
							{
								if (48161 - 477203 != -429042)
								{
									continue;
								}
								this.$mGameGui$40774.enabled = true;
								if (87896 - 386893 == -298996)
								{
									continue;
								}
							}
							this.$mGameGui$40774.openDeadMenu();
							if (93565 - 34351 != 59214)
							{
								continue;
							}
						}
						IL_8D:
						this.YieldDefault(1);
						if (127817 - 368298 != -240480)
						{
							goto Block_6;
						}
						continue;
					default:
						if (50419 - 471443 == -421023)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (255251 - 451565 == -196314)
					{
						goto IL_AF;
					}
				}
				Block_6:
				goto IL_2F9;
				IL_AF:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06008D01 RID: 36097 RVA: 0x0113586C File Offset: 0x01133A6C
			internal static bool TEjttCVToWA30TCF5TkX()
			{
				return true;
			}

			// Token: 0x06008D02 RID: 36098 RVA: 0x01135870 File Offset: 0x01133A70
			internal static bool OXUPlpVTEKb9FGjNPLhK()
			{
				return false;
			}

			// Token: 0x040086A2 RID: 34466
			internal StoryGui $mStoryGui$40772;

			// Token: 0x040086A3 RID: 34467
			internal ChangeGui $mChangeGui$40773;

			// Token: 0x040086A4 RID: 34468
			internal GameGui $mGameGui$40774;

			// Token: 0x040086A5 RID: 34469
			internal M803_SteelInvader $self_$40775;
		}
	}

	// Token: 0x020017A9 RID: 6057
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$40777 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008D03 RID: 36099 RVA: 0x01135874 File Offset: 0x01133A74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$40777(M803_SteelInvader self_)
		{
			if (78424 - 160039 != -81615)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (15770 - 110069 != -94298)
				{
					base..ctor();
					if (111512 - 589105 != -477592)
					{
						this.$self_$40781 = self_;
						if (286781 - 551532 != -264750)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008D04 RID: 36100 RVA: 0x0113590C File Offset: 0x01133B0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M803_SteelInvader.$ReturnToTown$40777.$(this.$self_$40781);
		}

		// Token: 0x06008D05 RID: 36101 RVA: 0x0113591C File Offset: 0x01133B1C
		internal static bool VJfRs9VT2SlO3hfBafPQ()
		{
			return true;
		}

		// Token: 0x06008D06 RID: 36102 RVA: 0x01135920 File Offset: 0x01133B20
		internal static bool mX1208VT8DVMTSeatrE4()
		{
			return false;
		}

		// Token: 0x040086A6 RID: 34470
		internal M803_SteelInvader $self_$40781;

		// Token: 0x020017AA RID: 6058
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008D07 RID: 36103 RVA: 0x01135924 File Offset: 0x01133B24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M803_SteelInvader self_)
			{
				if (115466 - 232986 != -117519)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (43273 - 14231 != 29043)
					{
						base..ctor();
						if (168153 - 455302 != -287148)
						{
							this.$self_$40780 = self_;
							if (163692 - 546310 != -382617)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008D08 RID: 36104 RVA: 0x011359BC File Offset: 0x01133BBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (295911 - 249182 != 46730)
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
						this.$self_$40780.LeaveGame();
						if (252267 - 160847 != 91420)
						{
							continue;
						}
						this.YieldDefault(1);
						if (252338 - 87310 != 165029)
						{
							goto Block_24;
						}
						continue;
					default:
						if (16482 - 534525 == -518042)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (166630 - 14007 != 152624)
					{
						Game.mStateTime = Time.time;
						if (243500 - 464422 != -220921)
						{
							this.$$switch$7303$40778 = PlayerData.SaveGuild;
							if (117816 - 527856 != -410039)
							{
								if (this.$$switch$7303$40778 == 1)
								{
									if (123802 - 165224 == -41421)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (225431 - 300203 == -74771)
									{
										continue;
									}
								}
								else if (this.$$switch$7303$40778 == 2)
								{
									if (130168 - 220611 == -90442)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (102325 - 392786 == -290460)
									{
										continue;
									}
								}
								else if (this.$$switch$7303$40778 == 3)
								{
									if (123440 - 423181 != -299741)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (20898 - 505657 != -484759)
									{
										continue;
									}
								}
								else if (this.$$switch$7303$40778 == 4)
								{
									if (141286 - 456758 == -315471)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (251027 - 98623 != 152404)
									{
										continue;
									}
								}
								else if (this.$$switch$7303$40778 == 5)
								{
									if (26373 - 261128 != -234755)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (40113 - 147121 != -107008)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (281238 - 61738 == 219501)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (274746 - 559921 == -285174)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (151951 - 565543 == -413591)
									{
										continue;
									}
								}
								this.$mGameGui$40779 = (GameGui)this.$self_$40780.GetComponent(typeof(GameGui));
								if (9700 - 511265 != -501564)
								{
									if (this.$mGameGui$40779)
									{
										if (192579 - 350960 == -158380)
										{
											continue;
										}
										this.$mGameGui$40779.close();
										if (184261 - 350016 == -165754)
										{
											continue;
										}
									}
									this.$self_$40780.SendMessage("fadeOut");
									if (220632 - 456602 == -235970)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_24:
				IL_3AD:
				return false;
			}

			// Token: 0x06008D09 RID: 36105 RVA: 0x01135D88 File Offset: 0x01133F88
			internal static bool W5RLjHVTZun1TmDKKLn7()
			{
				return true;
			}

			// Token: 0x06008D0A RID: 36106 RVA: 0x01135D8C File Offset: 0x01133F8C
			internal static bool UrdYwUVTCvF90wq5Oe2d()
			{
				return false;
			}

			// Token: 0x040086A7 RID: 34471
			internal int $$switch$7303$40778;

			// Token: 0x040086A8 RID: 34472
			internal GameGui $mGameGui$40779;

			// Token: 0x040086A9 RID: 34473
			internal M803_SteelInvader $self_$40780;
		}
	}

	// Token: 0x020017AB RID: 6059
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$40782 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008D0B RID: 36107 RVA: 0x01135D90 File Offset: 0x01133F90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$40782(M803_SteelInvader self_)
		{
			if (12880 - 434828 != -421948)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (116828 - 311973 != -195144)
				{
					base..ctor();
					if (272294 - 16341 != 255954)
					{
						this.$self_$40785 = self_;
						if (36973 - 100347 != -63373)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008D0C RID: 36108 RVA: 0x01135E28 File Offset: 0x01134028
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M803_SteelInvader.$ReturnToGuild$40782.$(this.$self_$40785);
		}

		// Token: 0x06008D0D RID: 36109 RVA: 0x01135E38 File Offset: 0x01134038
		internal static bool guPlA1VTLWjjPQC3hin8()
		{
			return true;
		}

		// Token: 0x06008D0E RID: 36110 RVA: 0x01135E3C File Offset: 0x0113403C
		internal static bool XoN7D5VTOxKSE5Dlsrph()
		{
			return false;
		}

		// Token: 0x040086AA RID: 34474
		internal M803_SteelInvader $self_$40785;

		// Token: 0x020017AC RID: 6060
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008D0F RID: 36111 RVA: 0x01135E40 File Offset: 0x01134040
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M803_SteelInvader self_)
			{
				if (243888 - 551182 != -307294)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (213876 - 350414 == -136538)
					{
						base..ctor();
						if (268664 - 217761 != 50904)
						{
							this.$self_$40784 = self_;
							if (30424 - 546917 == -516493)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008D10 RID: 36112 RVA: 0x01135ED8 File Offset: 0x011340D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (255212 - 11720 != 243493)
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
						this.$self_$40784.LeaveGame();
						if (129399 - 102194 != 27205)
						{
							continue;
						}
						this.YieldDefault(1);
						if (31500 - 99668 != -68167)
						{
							goto Block_10;
						}
						continue;
					default:
						if (109651 - 459380 == -349728)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (89059 - 362794 == -273735)
					{
						Game.mStateTime = Time.time;
						if (207019 - 614 != 206406)
						{
							Game.mNextGameCode = 31;
							if (165016 - 292017 == -127001)
							{
								this.$mGameGui$40783 = (GameGui)this.$self_$40784.GetComponent(typeof(GameGui));
								if (18391 - 2274 != 16118)
								{
									if (this.$mGameGui$40783)
									{
										if (144790 - 584424 != -439634)
										{
											continue;
										}
										this.$mGameGui$40783.close();
										if (76910 - 175124 == -98213)
										{
											continue;
										}
									}
									this.$self_$40784.SendMessage("fadeOut");
									if (86286 - 7048 != 79239)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_10:
				IL_1BD:
				return false;
			}

			// Token: 0x06008D11 RID: 36113 RVA: 0x011360B4 File Offset: 0x011342B4
			internal static bool KqPW7JVTm8xb2ORRlF2S()
			{
				return true;
			}

			// Token: 0x06008D12 RID: 36114 RVA: 0x011360B8 File Offset: 0x011342B8
			internal static bool GnlHXQVTFk6VrdOUsb7X()
			{
				return false;
			}

			// Token: 0x040086AB RID: 34475
			internal GameGui $mGameGui$40783;

			// Token: 0x040086AC RID: 34476
			internal M803_SteelInvader $self_$40784;
		}
	}

	// Token: 0x020017AD RID: 6061
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$40786 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008D13 RID: 36115 RVA: 0x011360BC File Offset: 0x011342BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$40786(M803_SteelInvader self_)
		{
			if (8916 - 364389 != -355473)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (199704 - 267201 == -67497)
				{
					base..ctor();
					if (120422 - 366449 != -246026)
					{
						this.$self_$40790 = self_;
						if (11487 - 283787 == -272300)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008D14 RID: 36116 RVA: 0x01136154 File Offset: 0x01134354
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M803_SteelInvader.$ReturnToCamp$40786.$(this.$self_$40790);
		}

		// Token: 0x06008D15 RID: 36117 RVA: 0x01136164 File Offset: 0x01134364
		internal static bool veRepNVTMpZmI3Y6U5ZS()
		{
			return true;
		}

		// Token: 0x06008D16 RID: 36118 RVA: 0x01136168 File Offset: 0x01134368
		internal static bool C6Eu36VTxsULj8ikXWXK()
		{
			return false;
		}

		// Token: 0x040086AD RID: 34477
		internal M803_SteelInvader $self_$40790;

		// Token: 0x020017AE RID: 6062
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008D17 RID: 36119 RVA: 0x0113616C File Offset: 0x0113436C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M803_SteelInvader self_)
			{
				if (225758 - 527805 != -302046)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (203339 - 154628 != 48712)
					{
						base..ctor();
						if (6514 - 318844 != -312329)
						{
							this.$self_$40789 = self_;
							if (254216 - 387653 != -133436)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008D18 RID: 36120 RVA: 0x01136204 File Offset: 0x01134404
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (189480 - 567853 != -378372)
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
						this.$self_$40789.LeaveGame();
						if (57514 - 36395 != 21119)
						{
							continue;
						}
						this.YieldDefault(1);
						if (150006 - 45720 != 104286)
						{
							continue;
						}
						goto IL_363;
					default:
						if (187778 - 310524 == -122745)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (157039 - 453374 != -296334)
					{
						Game.mStateTime = Time.time;
						if (261915 - 204765 == 57150)
						{
							this.$$switch$7305$40787 = PlayerData.SaveGuild;
							if (44096 - 582025 != -537928)
							{
								if (this.$$switch$7305$40787 == 1)
								{
									if (90649 - 259277 == -168627)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (170852 - 19318 == 151535)
									{
										continue;
									}
								}
								else if (this.$$switch$7305$40787 == 2)
								{
									if (265939 - 94060 == 171880)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (62107 - 403648 != -341541)
									{
										continue;
									}
								}
								else if (this.$$switch$7305$40787 == 3)
								{
									if (114162 - 396733 != -282571)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (63794 - 34593 != 29201)
									{
										continue;
									}
								}
								else if (this.$$switch$7305$40787 == 4)
								{
									if (256021 - 253681 != 2340)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (212444 - 400838 == -188393)
									{
										continue;
									}
								}
								else if (this.$$switch$7305$40787 == 5)
								{
									if (22241 - 559169 == -536927)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (215992 - 295511 == -79518)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (45311 - 65969 == -20657)
									{
										continue;
									}
								}
								this.$mGameGui$40788 = (GameGui)this.$self_$40789.GetComponent(typeof(GameGui));
								if (152010 - 574497 == -422487)
								{
									if (this.$mGameGui$40788)
									{
										if (192824 - 367466 != -174642)
										{
											continue;
										}
										this.$mGameGui$40788.close();
										if (296620 - 3706 != 292914)
										{
											continue;
										}
									}
									this.$self_$40789.SendMessage("fadeOut");
									if (66947 - 94787 == -27840)
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

			// Token: 0x06008D19 RID: 36121 RVA: 0x01136588 File Offset: 0x01134788
			internal static bool DoImJAVTgMsDqY2VXl8f()
			{
				return true;
			}

			// Token: 0x06008D1A RID: 36122 RVA: 0x0113658C File Offset: 0x0113478C
			internal static bool A6XWykVTfrOOoSNWES9v()
			{
				return false;
			}

			// Token: 0x040086AE RID: 34478
			internal int $$switch$7305$40787;

			// Token: 0x040086AF RID: 34479
			internal GameGui $mGameGui$40788;

			// Token: 0x040086B0 RID: 34480
			internal M803_SteelInvader $self_$40789;
		}
	}
}
