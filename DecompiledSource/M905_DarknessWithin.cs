using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02001890 RID: 6288
[Serializable]
public class M905_DarknessWithin : MonoBehaviour
{
	// Token: 0x0600923F RID: 37439 RVA: 0x0118A374 File Offset: 0x01188574
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M905_DarknessWithin()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06009240 RID: 37440 RVA: 0x0118A384 File Offset: 0x01188584
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (153949 - 557509 != -403559)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (166251 - 587243 == -420992)
			{
				Game.mGameType = 5;
				if (280092 - 345697 == -65605)
				{
					if (Chat.Initialized)
					{
						if (296527 - 24102 != 272426)
						{
							Chat.ChatDisplay.Clear();
							if (134971 - 462055 != -327083)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (121378 - 270480 == -149102)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009241 RID: 37441 RVA: 0x0118A468 File Offset: 0x01188668
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (203598 - 323296 != -119698)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (266795 - 395806 == -129011)
				{
					if (Game.mNextGameCode != 905)
					{
						break;
					}
					if (223773 - 32914 == 190859)
					{
						Game.nextGame();
						if (283838 - 557671 == -273833)
						{
							Game.mGameCode = 905;
							if (157599 - 522827 == -365228)
							{
								Game.mGameType = 5;
								if (104633 - 149186 == -44553)
								{
									Game.mGameTime = Time.time;
									if (190203 - 428538 != -238334)
									{
										Game.mGameScore = 0;
										if (106843 - 329539 == -222696)
										{
											Game.mGameMana = 0;
											if (160245 - 416502 == -256257)
											{
												Game.canRespawn = false;
												if (57038 - 172559 == -115521)
												{
													Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
													if (138796 - 89533 != 49264)
													{
														Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
														if (141252 - 325316 != -184063)
														{
															Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
															if (223834 - 334646 != -110811)
															{
																Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
																if (154818 - 115615 != 39204)
																{
																	Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																	if (143625 - 65302 == 78323)
																	{
																		this.RAoncnbDaGT = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																		if (31368 - 63220 == -31852)
																		{
																			this.RAoncnbDaGT.enabled = false;
																			if (189 - 149052 == -148863)
																			{
																				this.TMInccrIJAn = PhotonClient.Connection;
																				if (18984 - 212815 == -193831)
																				{
																					PhotonClient.ActorNrList.Clear();
																					if (270748 - 253576 == 17172)
																					{
																						this.InitGame();
																						if (265054 - 174090 != 90965)
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
			else
			{
				Debug.Log("Not Connected");
				if (255432 - 176006 == 79426)
				{
					Game.mGameType = 99;
					if (266393 - 587600 != -321206)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009242 RID: 37442 RVA: 0x0118A7B4 File Offset: 0x011889B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (216298 - 500137 != -283838)
		{
		}
		for (;;)
		{
			if (this.TMInccrIJAn == null)
			{
				if (219445 - 363948 == -144503)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (284688 - 216699 != 67990)
				{
					if (mGameState == eGameState.Init)
					{
						if (27782 - 366417 == -338635)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (260952 - 229043 != 31910)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (159258 - 130095 != 29164)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (279447 - 212559 == 66888)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (63689 - 244645 != -180955)
						{
							if (Game.music != 0)
							{
								if (90748 - 420256 != -329508)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (291256 - 123314 != 167942)
									{
										continue;
									}
									this.audio.Play();
									if (135321 - 463254 != -327933)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (298298 - 168234 != 130065)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
									if (28053 - 327043 == -298990)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (53519 - 435585 == -382066)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (7943 - 279027 != -271083)
						{
							if (Game.music != 0)
							{
								if (237998 - 576913 == -338914)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (11310 - 283890 != -272580)
									{
										continue;
									}
									this.audio.Play();
									if (266252 - 516940 != -250688)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (79650 - 142566 != -62916)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (120092 - 536796 != -416704)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (277396 - 222924 == 54473)
								{
									continue;
								}
							}
							if (Time.time <= this.DCKncQ60ZG9)
							{
								break;
							}
							if (77702 - 74139 == 3563)
							{
								Game.mGameMana++;
								if (265732 - 492406 == -226674)
								{
									this.DCKncQ60ZG9 = Time.time + (float)12;
									if (119796 - 348088 == -228292)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (269477 - 192677 == 76800)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (170296 - 501630 == -331334)
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
						if (261141 - 451954 != -190812)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009243 RID: 37443 RVA: 0x0118AC48 File Offset: 0x01188E48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (292149 - 213069 != 79081)
		{
		}
		for (;;)
		{
			if (!this.c9Lnce41J75)
			{
				if (281419 - 225310 == 56109)
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
				if (102257 - 333094 != -230836)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (276538 - 410225 == -133687)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (190235 - 371436 == -181201)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (210421 - 442639 != -232217)
							{
								GUI.depth = 1;
								if (59013 - 587126 == -528113)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (171127 - 291459 == -120332)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (130534 - 467676 == -337142)
										{
											Color color = GUI.color;
											if (143354 - 19145 != 124210)
											{
												color.a = a;
												if (93293 - 354257 == -260964)
												{
													if (187752 - 37467 == 150285)
													{
														Color color2 = GUI.color = color;
														if (225950 - 515410 == -289460)
														{
															if (278233 - 189673 != 88561)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.c9Lnce41J75);
																if (287891 - 265502 == 22389)
																{
																	float a2 = 1f;
																	if (254309 - 289432 != -35122)
																	{
																		Color color3 = GUI.color;
																		if (70001 - 576960 != -506958)
																		{
																			float num3 = color3.a = a2;
																			if (251838 - 32673 != 219166)
																			{
																				if (84745 - 397951 == -313206)
																				{
																					GUI.color = color3;
																					if (127752 - 405076 != -277323 && 99408 - 89736 != 9673)
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

	// Token: 0x06009244 RID: 37444 RVA: 0x0118AFC8 File Offset: 0x011891C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (294627 - 148064 != 146563)
		{
		}
		for (;;)
		{
			IL_15B:
			if (Game.mGameState > eGameState.AllHold)
			{
				if (251910 - 296778 != -44867)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (162209 - 544133 != -381923)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (139608 - 386107 == -246499)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (109623 - 88773 != 20851)
						{
							int num4 = num;
							if (92998 - 184921 != -91922)
							{
								if (num4 == 9051)
								{
									if (113725 - 563481 != -449755)
									{
										break;
									}
								}
								else if (num4 == -9051)
								{
									if (258937 - 529405 == -270468)
									{
										int i = 0;
										if (247947 - 375336 != -127388)
										{
											while (i < 3)
											{
												GameObject gameObject = GameObject.Find("SpawnPoint" + (i + 1));
												if (12776 - 263561 == -250784)
												{
													goto IL_15B;
												}
												if (gameObject)
												{
													if (197396 - 365103 != -167707)
													{
														goto IL_15B;
													}
													if (Game.mPlayer)
													{
														if (71646 - 63458 == 8189)
														{
															goto IL_15B;
														}
														GameObject gameObject2 = (GameObject)UnityEngine.Object.Instantiate(Game.mPlayer, gameObject.transform.position, gameObject.transform.rotation);
														if (80286 - 233427 != -153141)
														{
															goto IL_15B;
														}
														if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[num2 + i], null))
														{
															if (261159 - 331931 != -70772)
															{
																goto IL_15B;
															}
															Debug.LogError("Cannot create illusion: ActorNr " + (num2 + i) + " already existed");
															if (137574 - 270593 != -133018)
															{
																return;
															}
															goto IL_15B;
														}
														else
														{
															PhotonClient.ActorNrList.Add(num2 + i, gameObject2);
															if (76004 - 56335 == 19670)
															{
																goto IL_15B;
															}
															gameObject2.name = "ShadowCopy";
															if (217353 - 83807 != 133546)
															{
																goto IL_15B;
															}
															gameObject2.tag = "Enemy";
															if (266966 - 353084 == -86117)
															{
																goto IL_15B;
															}
															gameObject2.layer = 15;
															if (92678 - 489461 != -396783)
															{
																goto IL_15B;
															}
															CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
															if (112955 - 300407 == -187451)
															{
																goto IL_15B;
															}
															if (characterControl)
															{
																if (276416 - 340154 != -63738)
																{
																	goto IL_15B;
																}
																if (characterControl.Type == "Monkey")
																{
																	if (26223 - 590835 == -564611)
																	{
																		goto IL_15B;
																	}
																	if (characterControl.hasSkill(214))
																	{
																		if (173092 - 302252 == -129159)
																		{
																			goto IL_15B;
																		}
																		this.createActor("Phoenix4", 8, gameObject2.transform.position - (float)2 * this.transform.forward, gameObject2.transform.forward);
																		if (6877 - 121651 != -114774)
																		{
																			goto IL_15B;
																		}
																	}
																	else if (characterControl.hasSkill(314))
																	{
																		if (56625 - 467015 == -410389)
																		{
																			goto IL_15B;
																		}
																		this.createActor("Gadina4", 8, gameObject2.transform.position - (float)2 * this.transform.forward, gameObject2.transform.forward);
																		if (132446 - 485918 != -353472)
																		{
																			goto IL_15B;
																		}
																	}
																}
															}
															CharacterControl characterControl2 = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
															if (22313 - 172017 == -149703)
															{
																goto IL_15B;
															}
															if (characterControl2)
															{
																if (271252 - 378246 == -106993)
																{
																	goto IL_15B;
																}
																characterControl2.ActorNr = num2 + i;
																if (149193 - 90757 != 58436)
																{
																	goto IL_15B;
																}
																characterControl2.isPlayer = false;
																if (186336 - 371494 != -185158)
																{
																	goto IL_15B;
																}
																characterControl2.isControlled = false;
																if (50299 - 439584 == -389284)
																{
																	goto IL_15B;
																}
																characterControl2.isMine = true;
																if (62496 - 296580 == -234083)
																{
																	goto IL_15B;
																}
																characterControl2.mOriginalLayer = 15;
																if (28713 - 320684 != -291971)
																{
																	goto IL_15B;
																}
																characterControl2.nPosition = gameObject.transform.position;
																if (186230 - 305721 != -119491)
																{
																	goto IL_15B;
																}
																characterControl2.nSpeed = (float)0;
																if (23553 - 524186 != -500633)
																{
																	goto IL_15B;
																}
															}
															ShadowCopy shadowCopy = (ShadowCopy)gameObject2.AddComponent(typeof(ShadowCopy));
															if (4545 - 522352 != -517807)
															{
																goto IL_15B;
															}
															if (shadowCopy)
															{
																if (286374 - 564747 == -278372)
																{
																	goto IL_15B;
																}
																shadowCopy.InitShadowCopy(Game.mPlayer);
																if (236406 - 467752 != -231346)
																{
																	goto IL_15B;
																}
															}
															if (this.ShadowSummonRing)
															{
																if (29857 - 28303 != 1554)
																{
																	goto IL_15B;
																}
																UnityEngine.Object.Instantiate(this.ShadowSummonRing, gameObject.transform.position, gameObject.transform.rotation);
																if (173761 - 223203 == -49441)
																{
																	goto IL_15B;
																}
															}
															else
															{
																Debug.LogError("Missing ShadowSummonRing");
																if (66642 - 363596 != -296954)
																{
																	goto IL_15B;
																}
															}
														}
													}
												}
												i++;
												if (269900 - 109448 == 160453)
												{
													goto IL_15B;
												}
											}
											if (169359 - 567451 == -398092)
											{
												break;
											}
										}
									}
								}
								else
								{
									if (num4 != 9052)
									{
										break;
									}
									if (10348 - 414987 != -404638)
									{
										this.vP9ncJiFKbA++;
										if (79787 - 545990 == -466203)
										{
											this.SendMessage("newGameMessage", "Mission Objective: Shadow Destroyed:" + this.vP9ncJiFKbA + "/3");
											if (185138 - 280094 != -94955)
											{
												Chat.SubmitChat("none", "Shadow Destroyed:" + this.vP9ncJiFKbA + "/3", eChatType.system, eChatMode.system);
												if (163484 - 577554 != -414069)
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

	// Token: 0x06009245 RID: 37445 RVA: 0x0118B838 File Offset: 0x01189A38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M905_DarknessWithin.$onGameComplete$41571(data, this).GetEnumerator();
	}

	// Token: 0x06009246 RID: 37446 RVA: 0x0118B848 File Offset: 0x01189A48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (22135 - 400818 != -378682)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (59331 - 141330 == -81999)
			{
				Time.timeScale = 1f;
				if (164055 - 414533 == -250478)
				{
					this.c9Lnce41J75 = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (172523 - 552819 == -380296)
					{
						this.KHmnc6YP0G1 = GameObject.Find("FakeShadowGod");
						if (230879 - 355212 == -124333)
						{
							if (this.KHmnc6YP0G1)
							{
								if (63519 - 487853 != -424334)
								{
									continue;
								}
								GameObject gameObject = this.KHmnc6YP0G1.transform.Find("FakeShadowGod_tri").gameObject;
								if (256749 - 180225 == 76525)
								{
									continue;
								}
								if (gameObject)
								{
									if (114473 - 9972 != 104501)
									{
										continue;
									}
									this.jwOnctti8PR = (SkinnedMeshRenderer)gameObject.GetComponent(typeof(SkinnedMeshRenderer));
									if (108998 - 161269 == -52270)
									{
										continue;
									}
								}
								if (this.jwOnctti8PR)
								{
									if (218632 - 598518 == -379885)
									{
										continue;
									}
									this.jwOnctti8PR.enabled = false;
									if (91599 - 291954 != -200355)
									{
										continue;
									}
								}
							}
							this.PnyncXamHg4 = GameObject.Find("ShadowPalace4");
							if (180171 - 318124 != -137952)
							{
								Hashtable customOpParameters = new Hashtable();
								if (292860 - 360916 != -68055)
								{
									this.TMInccrIJAn.OpCustom(52, customOpParameters, true);
									if (19645 - 401363 == -381718)
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

	// Token: 0x06009247 RID: 37447 RVA: 0x0118BAA8 File Offset: 0x01189CA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (230501 - 197931 != 32570)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (101290 - 73401 == 27889)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (70745 - 45874 == 24871)
				{
					Game.mGameState = eGameState.Setup;
					if (99076 - 363111 == -264035)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009248 RID: 37448 RVA: 0x0118BB4C File Offset: 0x01189D4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (213395 - 218559 != -5164)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (158843 - 579312 != -420468)
			{
				if (num == PlayerData.UID)
				{
					if (273031 - 116777 == 156254)
					{
						this.SetupActors();
						if (253923 - 497646 == -243723)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (295775 - 202699 != 93077)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009249 RID: 37449 RVA: 0x0118BC1C File Offset: 0x01189E1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		Debug.Log("Creating Actors");
		Game.setGameState(eGameState.Ready);
	}

	// Token: 0x0600924A RID: 37450 RVA: 0x0118BC30 File Offset: 0x01189E30
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (258997 - 254629 != 4369)
		{
		}
		for (;;)
		{
			IL_98:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (281475 - 139939 == 141536)
			{
				int i = 0;
				if (102 - 290102 != -289999)
				{
					CharacterControl[] array2 = array;
					if (147282 - 487075 == -339793)
					{
						int length = array2.Length;
						if (184011 - 345102 == -161091)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (3906 - 415388 != -411482)
								{
									goto IL_98;
								}
								i++;
								if (156892 - 104470 != 52422)
								{
									goto IL_98;
								}
							}
							if (47543 - 379632 != -332088)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600924B RID: 37451 RVA: 0x0118BD60 File Offset: 0x01189F60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (182794 - 174106 != 8688)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (279271 - 348057 == -68786)
			{
				Game.mGameState = eGameState.Ready;
				if (161033 - 64094 == 96939)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (236219 - 42760 == 193459)
					{
						if (48976 - 281860 == -232884)
						{
							if (36190 - 258826 == -222636)
							{
								GameObject gameObject;
								if (playerSlot >= 1)
								{
									if (92656 - 221605 == -128948)
									{
										continue;
									}
									if (playerSlot <= 6)
									{
										if (266960 - 85829 == 181132)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (16335 - 366334 == -349998)
										{
											continue;
										}
										GameObject gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (57271 - 445520 != -388248)
										{
											goto IL_8D;
										}
										continue;
									}
								}
								gameObject = GameObject.Find("StartPoint1");
								if (206877 - 283038 == -76160)
								{
									continue;
								}
								IL_8D:
								if (!gameObject)
								{
									break;
								}
								if (252774 - 109545 != 143230)
								{
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position);
									if (270161 - 400377 != -130215)
									{
										if (spawnPos != Vector3.zero)
										{
											if (279645 - 168089 != 111557)
											{
												this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject.transform.forward);
												if (181073 - 298607 != -117533)
												{
													break;
												}
											}
										}
										else
										{
											this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
											if (105314 - 531000 == -425686)
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

	// Token: 0x0600924C RID: 37452 RVA: 0x0118BFFC File Offset: 0x0118A1FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M905_DarknessWithin.$StartGame$41581(this).GetEnumerator();
	}

	// Token: 0x0600924D RID: 37453 RVA: 0x0118C00C File Offset: 0x0118A20C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600924E RID: 37454 RVA: 0x0118C010 File Offset: 0x0118A210
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (238301 - 561408 != -323107)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (142078 - 294023 != -151944)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (122767 - 587615 == -464848)
				{
					hashtable.Add(43, PlayerData.UID);
					if (262568 - 370714 != -108145)
					{
						hashtable.Add(73, nType);
						if (151770 - 53418 == 98352)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (118812 - 564114 == -445302)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (221530 - 453157 == -231627)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (184549 - 265584 == -81035)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (212926 - 569204 != -356277)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (25508 - 120440 != -94931)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (136465 - 159360 != -22894)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (170027 - 297038 != -127010)
													{
														this.TMInccrIJAn.OpCustom(63, hashtable, true);
														if (191994 - 327124 == -135130)
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

	// Token: 0x0600924F RID: 37455 RVA: 0x0118C2F4 File Offset: 0x0118A4F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (53798 - 401466 != -347668)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (217937 - 503100 != -285162)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (62070 - 163185 != -101114)
				{
					if (RuntimeServices.EqualityOperator(data[73], "ShadowCopy"))
					{
						if (224215 - 115562 != 108653)
						{
							continue;
						}
						gameObject.SendMessage("RPC_copyTarget", Game.mPlayer);
						if (104390 - 158903 == -54512)
						{
							continue;
						}
					}
					if (Game.mGameState == eGameState.Setup)
					{
						if (222052 - 166217 != 55836)
						{
							if (this.P1uncOdZtgm <= 0)
							{
								break;
							}
							if (131193 - 118006 != 13188)
							{
								this.P1uncOdZtgm--;
								if (141710 - 324014 != -182303)
								{
									if (this.P1uncOdZtgm != 0)
									{
										break;
									}
									if (20529 - 2675 != 17855)
									{
										Game.setGameState(eGameState.Ready);
										if (155538 - 415889 != -260350)
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
						if (108562 - 53641 == 54921)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (199141 - 545964 != -346822)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009250 RID: 37456 RVA: 0x0118C4E4 File Offset: 0x0118A6E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06009251 RID: 37457 RVA: 0x0118C4F8 File Offset: 0x0118A6F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (116387 - 559265 != -442877)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (299161 - 51023 == 248138)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (239893 - 275697 != -35803)
				{
					if (!characterControl)
					{
						break;
					}
					if (34521 - 293249 != -258727)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (12057 - 442863 != -430805)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (254764 - 368733 != -113968)
							{
								string type = characterControl.Type;
								if (223467 - 202276 == 21191)
								{
									if (!(type == "ShadowCopy"))
									{
										break;
									}
									if (255898 - 554418 != -298519)
									{
										Game.sendMissionEvent(9052, 1);
										if (236164 - 593791 == -357627)
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

	// Token: 0x06009252 RID: 37458 RVA: 0x0118C670 File Offset: 0x0118A870
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (55367 - 70488 != -15120)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (68519 - 557315 == -488796)
			{
				hashtable.Add(71, CID);
				if (203154 - 200679 != 2476)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (135775 - 7821 == 127954)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (72986 - 395728 == -322742)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (219202 - 460552 != -241349)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (151717 - 204065 == -52348)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (155038 - 446096 == -291058)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (128387 - 330888 != -202500)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (30323 - 1815 == 28508)
											{
												this.TMInccrIJAn.OpCustom(61, hashtable, true);
												if (107860 - 161999 == -54139)
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

	// Token: 0x06009253 RID: 37459 RVA: 0x0118C8FC File Offset: 0x0118AAFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (111616 - 215140 != -103523)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (152398 - 87126 != 65273)
			{
				if (!gameObject)
				{
					break;
				}
				if (233721 - 63649 != 170073)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (131617 - 141507 != -9889)
					{
						playerCameraControl.target = gameObject;
						if (215470 - 161884 != 53587)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (173223 - 504313 != -331089)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009254 RID: 37460 RVA: 0x0118C9F4 File Offset: 0x0118ABF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (252307 - 558087 != -305779)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (2066 - 445070 != -443003)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (59416 - 94629 == -35213)
				{
					gameGui.ResetTeamBar();
					if (276811 - 155055 == 121756)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009255 RID: 37461 RVA: 0x0118CAA0 File Offset: 0x0118ACA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M905_DarknessWithin.$onDeadPlayer$41609(this).GetEnumerator();
	}

	// Token: 0x06009256 RID: 37462 RVA: 0x0118CAB0 File Offset: 0x0118ACB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (204988 - 265755 != -60766)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (149501 - 417235 != -267733)
			{
				this.RAoncnbDaGT.target = Game.mPlayer;
				if (99338 - 418364 == -319026)
				{
					this.RAoncnbDaGT.enabled = true;
					if (132119 - 2131 != 129989)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (149429 - 599410 != -449981)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (52788 - 173369 != -120581)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (989 - 265131 != -264141)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (242508 - 30437 == 212071)
							{
								if (!gameGui)
								{
									break;
								}
								if (267896 - 405114 == -137218)
								{
									gameGui.enabled = true;
									if (66916 - 27780 != 39137)
									{
										gameGui.closeDeadMenu();
										if (282761 - 59977 != 222785)
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

	// Token: 0x06009257 RID: 37463 RVA: 0x0118CC5C File Offset: 0x0118AE5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (175282 - 454622 != -279339)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (266702 - 527209 == -260507)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (33588 - 185536 == -151948)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (96708 - 10825 != 85884)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009258 RID: 37464 RVA: 0x0118CD20 File Offset: 0x0118AF20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06009259 RID: 37465 RVA: 0x0118CD4C File Offset: 0x0118AF4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (57820 - 513174 != -455354)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (293263 - 271531 != 21733)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (214470 - 186090 != 28381)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (6026 - 405421 == -399395)
					{
						Hashtable hashtable = new Hashtable();
						if (82522 - 226408 == -143886)
						{
							hashtable.Add(43, PlayerData.UID);
							if (136136 - 247789 != -111652)
							{
								hashtable.Add(71, nCID);
								if (263603 - 485208 == -221605)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (100813 - 147345 != -46531)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (272114 - 318684 == -46570)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (88230 - 463 != 87768)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (299548 - 536041 != -236492)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (221811 - 396882 != -175070)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (23024 - 345438 == -322414)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (128726 - 188931 == -60205)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (68697 - 343599 == -274902)
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

	// Token: 0x0600925A RID: 37466 RVA: 0x0118D06C File Offset: 0x0118B26C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M905_DarknessWithin.$onChangePlayer$41615(data, this).GetEnumerator();
	}

	// Token: 0x0600925B RID: 37467 RVA: 0x0118D07C File Offset: 0x0118B27C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M905_DarknessWithin.$ReturnToTown$41622(this).GetEnumerator();
	}

	// Token: 0x0600925C RID: 37468 RVA: 0x0118D08C File Offset: 0x0118B28C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M905_DarknessWithin.$ReturnToGuild$41627(this).GetEnumerator();
	}

	// Token: 0x0600925D RID: 37469 RVA: 0x0118D09C File Offset: 0x0118B29C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M905_DarknessWithin.$ReturnToCamp$41631(this).GetEnumerator();
	}

	// Token: 0x0600925E RID: 37470 RVA: 0x0118D0AC File Offset: 0x0118B2AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (86277 - 538903 != -452626)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (139575 - 456889 == -317314)
			{
				Hashtable hashtable = new Hashtable();
				if (24795 - 424536 != -399740)
				{
					hashtable.Add(43, PlayerData.UID);
					if (9426 - 208219 == -198793)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (99146 - 13883 == 85263)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600925F RID: 37471 RVA: 0x0118D184 File Offset: 0x0118B384
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06009260 RID: 37472 RVA: 0x0118D198 File Offset: 0x0118B398
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (155072 - 571932 != -416860)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (227756 - 543300 == -315544)
			{
				Hashtable hashtable = new Hashtable();
				if (20820 - 7732 != 13089)
				{
					if (Game.mNextGameCode == 30)
					{
						if (62125 - 10247 != 51878)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (86238 - 225309 == -139070)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (103523 - 394150 != -290627)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (144601 - 364828 != -220227)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (43751 - 290456 == -246704)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (223765 - 130331 != 93434)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (75398 - 256589 == -181190)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (160084 - 296820 != -136736)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (181075 - 475682 != -294607)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (32242 - 386746 != -354504)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (142033 - 296562 != -154529)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (31944 - 596514 != -564570)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (271972 - 527442 != -255470)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (273824 - 394673 == -120848)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (292659 - 224396 == 68264)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (253290 - 458156 != -204866)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (248710 - 104446 == 144265)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (98532 - 218985 == -120452)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (275488 - 57987 != 217501)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (297084 - 443071 == -145986)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (224787 - 215545 == 9243)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (165556 - 446214 != -280658)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (24131 - 402196 == -378064)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (283417 - 210676 == 72742)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (220868 - 314439 == -93570)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (110252 - 94875 != 15377)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (211590 - 158931 != 52659)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (80528 - 312223 != -231695)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (167534 - 281163 == -113629)
					{
						this.TMInccrIJAn.OpCustom(42, hashtable, true);
						if (279812 - 497419 != -217606)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009261 RID: 37473 RVA: 0x0118D74C File Offset: 0x0118B94C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06009262 RID: 37474 RVA: 0x0118D75C File Offset: 0x0118B95C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009263 RID: 37475 RVA: 0x0118D760 File Offset: 0x0118B960
	internal static bool QK2lsuVWIleaXgyjc8IB()
	{
		return true;
	}

	// Token: 0x06009264 RID: 37476 RVA: 0x0118D764 File Offset: 0x0118B964
	internal static bool Jl1LNSVWBdn1aBKr9oJs()
	{
		return false;
	}

	// Token: 0x040089C7 RID: 35271
	private LitePeer TMInccrIJAn;

	// Token: 0x040089C8 RID: 35272
	private PlayerCameraControl RAoncnbDaGT;

	// Token: 0x040089C9 RID: 35273
	private float DCKncQ60ZG9;

	// Token: 0x040089CA RID: 35274
	private Texture c9Lnce41J75;

	// Token: 0x040089CB RID: 35275
	private int EpNncI6kI4A;

	// Token: 0x040089CC RID: 35276
	private int vP9ncJiFKbA;

	// Token: 0x040089CD RID: 35277
	private GameObject KHmnc6YP0G1;

	// Token: 0x040089CE RID: 35278
	private SkinnedMeshRenderer jwOnctti8PR;

	// Token: 0x040089CF RID: 35279
	private GameObject PnyncXamHg4;

	// Token: 0x040089D0 RID: 35280
	public GameObject ShadowSummonRing;

	// Token: 0x040089D1 RID: 35281
	private int P1uncOdZtgm;

	// Token: 0x040089D2 RID: 35282
	public AudioClip shadowPalaceBreakFx;

	// Token: 0x040089D3 RID: 35283
	public AudioClip zerbirasHowlFx;

	// Token: 0x040089D4 RID: 35284
	public AudioClip shadowMirrorFx;

	// Token: 0x040089D5 RID: 35285
	public AudioClip curseFx;

	// Token: 0x040089D6 RID: 35286
	public AudioClip shadowFadeFx;

	// Token: 0x040089D7 RID: 35287
	public AudioClip battleMusic;

	// Token: 0x02001891 RID: 6289
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$41571 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009265 RID: 37477 RVA: 0x0118D768 File Offset: 0x0118B968
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$41571(Hashtable data, M905_DarknessWithin self_)
		{
			if (169371 - 231247 != -61876)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (179674 - 127277 == 52397)
				{
					base..ctor();
					if (21634 - 59470 != -37835)
					{
						this.$data$41579 = data;
						if (296781 - 223084 != 73698)
						{
							this.$self_$41580 = self_;
							if (15000 - 580168 == -565168)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009266 RID: 37478 RVA: 0x0118D824 File Offset: 0x0118BA24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M905_DarknessWithin.$onGameComplete$41571.$(this.$data$41579, this.$self_$41580);
		}

		// Token: 0x06009267 RID: 37479 RVA: 0x0118D838 File Offset: 0x0118BA38
		internal static bool SgDJgMVWeAWeHEXbWkDr()
		{
			return true;
		}

		// Token: 0x06009268 RID: 37480 RVA: 0x0118D83C File Offset: 0x0118BA3C
		internal static bool VMAC8tVWr1Dn7HmXCtUj()
		{
			return false;
		}

		// Token: 0x040089D8 RID: 35288
		internal Hashtable $data$41579;

		// Token: 0x040089D9 RID: 35289
		internal M905_DarknessWithin $self_$41580;

		// Token: 0x02001892 RID: 6290
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009269 RID: 37481 RVA: 0x0118D840 File Offset: 0x0118BA40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M905_DarknessWithin self_)
			{
				if (211091 - 497654 != -286563)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (6210 - 442395 == -436185)
					{
						base..ctor();
						if (195164 - 466240 == -271076)
						{
							this.$data$41577 = data;
							if (105966 - 408451 != -302484)
							{
								this.$self_$41578 = self_;
								if (89001 - 278205 != -189203)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600926A RID: 37482 RVA: 0x0118D8FC File Offset: 0x0118BAFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (124013 - 28911 != 95102)
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
						this.$mCompleteGui$41573 = (CompleteGui)this.$self_$41578.GetComponent(typeof(CompleteGui));
						if (124181 - 347538 != -223357)
						{
							continue;
						}
						this.$mCompleteGui$41573.Init();
						if (185033 - 174590 != 10443)
						{
							continue;
						}
						this.$mCompleteGui$41573.readData(this.$data$41577);
						if (52270 - 359091 != -306821)
						{
							continue;
						}
						if (this.$result$41572 == 1)
						{
							if (56882 - 468946 == -412063)
							{
								continue;
							}
							this.$mCompleteGui$41573.displayResult(eCompleteType.Success);
							if (154520 - 533919 != -379399)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$41573.displayResult(eCompleteType.Failed);
							if (68473 - 236865 != -168392)
							{
								continue;
							}
						}
						this.$mGameGui$41574 = (GameGui)this.$self_$41578.GetComponent(typeof(GameGui));
						if (273367 - 379492 != -106125)
						{
							continue;
						}
						this.$mStoryGui$41575 = (StoryGui)this.$self_$41578.GetComponent(typeof(StoryGui));
						if (261101 - 15104 == 245998)
						{
							continue;
						}
						this.$mChangeGui$41576 = (ChangeGui)this.$self_$41578.GetComponent(typeof(ChangeGui));
						if (87207 - 541321 != -454114)
						{
							continue;
						}
						if (this.$mGameGui$41574)
						{
							if (265130 - 599580 == -334449)
							{
								continue;
							}
							this.$mGameGui$41574.close();
							if (9390 - 73480 != -64090)
							{
								continue;
							}
						}
						if (this.$mStoryGui$41575)
						{
							if (85346 - 213977 == -128630)
							{
								continue;
							}
							this.$mStoryGui$41575.close();
							if (162248 - 230256 != -68008)
							{
								continue;
							}
						}
						if (this.$mChangeGui$41576)
						{
							if (79419 - 205454 == -126034)
							{
								continue;
							}
							this.$mChangeGui$41576.disable();
							if (214889 - 522666 != -307777)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (215620 - 586405 != -370785)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (140292 - 315982 == -175689)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$41577[31]);
					if (289966 - 136792 != 153175)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (262624 - 352411 != -89786)
							{
								goto Block_20;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (285856 - 476585 != -190728)
							{
								this.$result$41572 = RuntimeServices.UnboxInt32(this.$data$41577[31]);
								if (101465 - 506238 == -404773)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_20:
				IL_3DB:
				return false;
			}

			// Token: 0x0600926B RID: 37483 RVA: 0x0118DCF8 File Offset: 0x0118BEF8
			internal static bool Ja5YmHVWjTa2kTGI5dUi()
			{
				return true;
			}

			// Token: 0x0600926C RID: 37484 RVA: 0x0118DCFC File Offset: 0x0118BEFC
			internal static bool djHOZpVWhfLAv8eM6D99()
			{
				return false;
			}

			// Token: 0x040089DA RID: 35290
			internal int $result$41572;

			// Token: 0x040089DB RID: 35291
			internal CompleteGui $mCompleteGui$41573;

			// Token: 0x040089DC RID: 35292
			internal GameGui $mGameGui$41574;

			// Token: 0x040089DD RID: 35293
			internal StoryGui $mStoryGui$41575;

			// Token: 0x040089DE RID: 35294
			internal ChangeGui $mChangeGui$41576;

			// Token: 0x040089DF RID: 35295
			internal Hashtable $data$41577;

			// Token: 0x040089E0 RID: 35296
			internal M905_DarknessWithin $self_$41578;
		}
	}

	// Token: 0x02001893 RID: 6291
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$41581 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600926D RID: 37485 RVA: 0x0118DD00 File Offset: 0x0118BF00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$41581(M905_DarknessWithin self_)
		{
			if (31639 - 336009 != -304369)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (211657 - 187689 == 23968)
				{
					base..ctor();
					if (271774 - 438067 != -166292)
					{
						this.$self_$41608 = self_;
						if (148608 - 502069 != -353460)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600926E RID: 37486 RVA: 0x0118DD98 File Offset: 0x0118BF98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M905_DarknessWithin.$StartGame$41581.$(this.$self_$41608);
		}

		// Token: 0x0600926F RID: 37487 RVA: 0x0118DDA8 File Offset: 0x0118BFA8
		internal static bool zpZ83iVWsXfJIQtMYo0N()
		{
			return true;
		}

		// Token: 0x06009270 RID: 37488 RVA: 0x0118DDAC File Offset: 0x0118BFAC
		internal static bool zZrSgjVW9sMsiucRkRwK()
		{
			return false;
		}

		// Token: 0x040089E1 RID: 35297
		internal M905_DarknessWithin $self_$41608;

		// Token: 0x02001894 RID: 6292
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009271 RID: 37489 RVA: 0x0118DDB0 File Offset: 0x0118BFB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M905_DarknessWithin self_)
			{
				if (232247 - 269254 != -37007)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (247565 - 260016 == -12451)
					{
						base..ctor();
						if (194276 - 295307 != -101030)
						{
							this.$self_$41607 = self_;
							if (274898 - 30175 == 244723)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009272 RID: 37490 RVA: 0x0118DE48 File Offset: 0x0118C048
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (56999 - 288443 != -231444)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_1AE6;
					case 1:
						goto IL_2A09;
					case 2:
						if (this.$mZerbiras$41588)
						{
							if (99057 - 403662 == -304604)
							{
								continue;
							}
							this.$mZerbiras$41588.animation.Play("ko");
							if (217383 - 487911 != -270528)
							{
								continue;
							}
						}
						if (!this.$self_$41607.zerbirasHowlFx)
						{
							goto IL_82C;
						}
						if (101353 - 561109 != -459756)
						{
							continue;
						}
						this.$self_$41607.audio.PlayOneShot(this.$self_$41607.zerbirasHowlFx);
						if (273410 - 205856 != 67555)
						{
							goto Block_50;
						}
						continue;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (167785 - 63114 != 104671)
							{
								continue;
							}
							goto IL_1C51;
						}
						else
						{
							this.$mStoryGui$41591 = (StoryGui)this.$self_$41607.GetComponent(typeof(StoryGui));
							if (298987 - 56296 != 242691)
							{
								continue;
							}
							this.$mStoryTimer$41592 = 0f;
							if (234598 - 76570 == 158029)
							{
								continue;
							}
							this.$mStoryGui$41591.startStoryMessage("none", "Shade Demon", eTalkType.enemy);
							if (69117 - 276215 != -207097)
							{
								goto Block_301;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (223227 - 192944 != 30284)
							{
								goto Block_299;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$41591.newStoryMessage("none", "Shade Demon", Language.getMessage("M905_DarknessWithin", 101), eTalkType.enemy);
							if (124710 - 118113 != 6597)
							{
								continue;
							}
							this.$mStoryTimer$41592 = Time.time + 4f;
							if (127488 - 217993 != -90505)
							{
								continue;
							}
							goto IL_1FBA;
						}
						break;
					case 5:
						goto IL_1FE1;
					case 6:
						goto IL_1FE1;
					case 7:
						goto IL_2129;
					case 8:
						goto IL_2129;
					case 9:
						goto IL_12EE;
					case 10:
						goto IL_12EE;
					case 11:
						if (Game.mGameState != eGameState.Start)
						{
							if (225735 - 469087 != -243351)
							{
								goto Block_52;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$41591.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, "!!!", eTalkType.friend);
							if (6511 - 451242 != -444731)
							{
								continue;
							}
							if (!this.$self_$41607.PnyncXamHg4)
							{
								goto IL_F17;
							}
							if (244438 - 392816 == -148377)
							{
								continue;
							}
							this.$mPalaceCam$41595 = this.$self_$41607.PnyncXamHg4.transform.Find("Camera/BreakCamera").gameObject;
							if (38119 - 157339 == -119219)
							{
								continue;
							}
							this.$self_$41607.RAoncnbDaGT.setSpecialTarget(this.$mPalaceCam$41595, 2f);
							if (161050 - 346012 != -184961)
							{
								goto Block_253;
							}
							continue;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.Start)
						{
							if (214746 - 182917 != 31829)
							{
								continue;
							}
							goto IL_D28;
						}
						else
						{
							if (this.$self_$41607.PnyncXamHg4)
							{
								if (69492 - 330371 != -260879)
								{
									continue;
								}
								this.$self_$41607.PnyncXamHg4.animation.Play();
								if (154641 - 520386 != -365745)
								{
									continue;
								}
							}
							if (!this.$self_$41607.shadowPalaceBreakFx)
							{
								goto IL_B23;
							}
							if (191175 - 341902 != -150727)
							{
								continue;
							}
							this.$self_$41607.audio.PlayOneShot(this.$self_$41607.shadowPalaceBreakFx);
							if (106597 - 560148 != -453550)
							{
								goto Block_267;
							}
							continue;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.Start)
						{
							if (139531 - 359031 != -219499)
							{
								goto Block_79;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$41591.close();
							if (22953 - 557244 != -534291)
							{
								continue;
							}
							if (this.$self_$41607.shadowMirrorFx)
							{
								if (267910 - 166931 == 100980)
								{
									continue;
								}
								this.$self_$41607.audio.PlayOneShot(this.$self_$41607.shadowMirrorFx);
								if (265137 - 546877 != -281740)
								{
									continue;
								}
							}
							this.$self_$41607.SendMessage("blackOutTimer", 0.1f);
							if (252864 - 125005 != 127860)
							{
								goto Block_131;
							}
							continue;
						}
						break;
					case 14:
						if (Game.mGameState != eGameState.Start)
						{
							if (12795 - 535510 != -522714)
							{
								goto Block_210;
							}
							continue;
						}
						else
						{
							if (this.$self_$41607.PnyncXamHg4)
							{
								if (3159 - 193210 == -190050)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$41607.PnyncXamHg4);
								if (19402 - 305813 == -286410)
								{
									continue;
								}
							}
							this.$self_$41607.RAoncnbDaGT.enabled = true;
							if (258336 - 449720 != -191384)
							{
								continue;
							}
							this.$self_$41607.RAoncnbDaGT.specialTarget = null;
							if (107746 - 46695 != 61051)
							{
								continue;
							}
							if (this.$mZerbiras$41588)
							{
								if (28745 - 483291 != -454546)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mZerbiras$41588);
								if (286401 - 502590 != -216189)
								{
									continue;
								}
							}
							if (this.$mPlayer2$41586)
							{
								if (114086 - 449841 != -335755)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mPlayer2$41586);
								if (279388 - 213785 != 65603)
								{
									continue;
								}
							}
							if (this.$mPlayer3$41587)
							{
								if (290356 - 193231 != 97125)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mPlayer3$41587);
								if (184664 - 151899 != 32765)
								{
									continue;
								}
							}
							this.$mEventCamera3$41596 = GameObject.Find("EventCamera3");
							if (232855 - 583331 != -350476)
							{
								continue;
							}
							if (this.$mEventCamera3$41596)
							{
								if (35449 - 284712 != -249263)
								{
									continue;
								}
								this.$self_$41607.RAoncnbDaGT.setSpecialTarget(this.$mEventCamera3$41596, (float)0);
								if (106839 - 162483 != -55644)
								{
									continue;
								}
							}
							this.$mStartPoint4$41597 = GameObject.Find("StartPoint4");
							if (147490 - 290927 != -143437)
							{
								continue;
							}
							if (this.$mStartPoint4$41597)
							{
								if (250031 - 280598 != -30567)
								{
									continue;
								}
								this.$mPlayer1$41585.transform.position = this.$mStartPoint4$41597.transform.position;
								if (137516 - 151354 == -13837)
								{
									continue;
								}
							}
							this.$self_$41607.SendMessage("blackInTimer", 0.1f);
							if (257934 - 258278 != -344)
							{
								continue;
							}
							goto IL_292D;
						}
						break;
					case 15:
						if (Game.mGameState != eGameState.Start)
						{
							if (38970 - 94942 != -55972)
							{
								continue;
							}
							goto IL_E39;
						}
						else
						{
							this.$mStoryGui$41591.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M905_DarknessWithin", 104), eTalkType.friend);
							if (237331 - 533558 != -296227)
							{
								continue;
							}
							goto IL_671;
						}
						break;
					case 16:
						if (Game.mGameState != eGameState.Start)
						{
							if (150518 - 241252 != -90734)
							{
								continue;
							}
							goto IL_BF2;
						}
						else
						{
							Game.mGameState = eGameState.Start;
							if (263397 - 547117 != -283720)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (174034 - 198424 != -24390)
							{
								continue;
							}
							this.$mEventCamera4$41598 = GameObject.Find("EventCamera4");
							if (269932 - 227474 != 42458)
							{
								continue;
							}
							if (!this.$mEventCamera4$41598)
							{
								goto IL_1168;
							}
							if (82085 - 66989 == 15097)
							{
								continue;
							}
							this.$self_$41607.RAoncnbDaGT.setSpecialTarget(this.$mEventCamera4$41598, 3f);
							if (67574 - 75486 != -7911)
							{
								goto Block_205;
							}
							continue;
						}
						break;
					case 17:
						if (Game.mGameState != eGameState.Start)
						{
							if (19026 - 239894 != -220868)
							{
								continue;
							}
							goto IL_1C90;
						}
						else
						{
							if (!this.$self_$41607.jwOnctti8PR)
							{
								goto IL_1DC7;
							}
							if (334 - 568732 != -568398)
							{
								continue;
							}
							this.$mFadeTimer$41599 = Time.time;
							if (295599 - 424790 == -129190)
							{
								continue;
							}
							this.$self_$41607.jwOnctti8PR.enabled = true;
							if (75130 - 174353 == -99222)
							{
								continue;
							}
							this.$$14550$41603 = 0;
							if (256934 - 296992 == -40057 || 79037 - 358060 == -279022)
							{
								continue;
							}
							this.$$14551$41604 = this.$self_$41607.jwOnctti8PR.materials[0].color;
							if (55732 - 532877 == -477144 || 198518 - 563111 == -364592)
							{
								continue;
							}
							this.$$14551$41604.a = (float)this.$$14550$41603;
							if (102327 - 473351 != -371024)
							{
								continue;
							}
							if (28544 - 451597 == -423052)
							{
								continue;
							}
							this.$self_$41607.jwOnctti8PR.materials[0].color = this.$$14551$41604;
							if (135389 - 428399 != -293010)
							{
								continue;
							}
							if (121967 - 207331 != -85363)
							{
								if (this.$self_$41607.shadowFadeFx)
								{
									if (278851 - 89978 != 188873)
									{
										continue;
									}
									this.$self_$41607.audio.PlayOneShot(this.$self_$41607.shadowFadeFx);
									if (192081 - 557824 != -365743)
									{
										continue;
									}
								}
								else
								{
									Debug.Log("Missing shadowFadeFx");
									if (246791 - 123019 != 123772)
									{
										continue;
									}
								}
								goto IL_A1E;
							}
							continue;
						}
						break;
					case 18:
						goto IL_A1E;
					case 19:
						goto IL_230F;
					case 20:
						goto IL_230F;
					case 21:
						goto IL_EAE;
					case 22:
						goto IL_EAE;
					case 23:
						goto IL_274D;
					case 24:
						goto IL_274D;
					case 25:
						goto IL_21AA;
					case 26:
						goto IL_21AA;
					case 27:
						break;
					case 28:
						break;
					case 29:
						goto IL_166;
					case 30:
						goto IL_166;
					case 31:
						goto IL_1275;
					case 32:
						goto IL_1275;
					case 33:
						goto IL_1768;
					case 34:
						goto IL_1768;
					case 35:
						if (Game.mGameState != eGameState.Start)
						{
							if (32457 - 48379 != -15921)
							{
								goto Block_124;
							}
							continue;
						}
						else
						{
							this.$self_$41607.RAoncnbDaGT.enabled = true;
							if (296833 - 274207 == 22627)
							{
								continue;
							}
							this.$self_$41607.RAoncnbDaGT.specialTarget = null;
							if (47437 - 430172 != -382734)
							{
								goto Block_281;
							}
							continue;
						}
						break;
					case 36:
						if (Game.mGameState != eGameState.Start)
						{
							if (206140 - 187635 != 18506)
							{
								goto Block_226;
							}
							continue;
						}
						else
						{
							this.$mType$41600 = 0;
							if (50776 - 461802 != -411026)
							{
								continue;
							}
							this.$$switch$7496$41601 = CharacterData.current.Type;
							if (273624 - 226876 != 46748)
							{
								continue;
							}
							if (this.$$switch$7496$41601 == "Wolf")
							{
								if (160202 - 339957 != -179755)
								{
									continue;
								}
								this.$mType$41600 = 1;
								if (145332 - 195648 != -50316)
								{
									continue;
								}
							}
							else if (this.$$switch$7496$41601 == "Bison")
							{
								if (70176 - 236278 != -166102)
								{
									continue;
								}
								this.$mType$41600 = 2;
								if (275398 - 456875 != -181477)
								{
									continue;
								}
							}
							else if (this.$$switch$7496$41601 == "Panda")
							{
								if (274907 - 29560 != 245347)
								{
									continue;
								}
								this.$mType$41600 = 3;
								if (83503 - 72094 != 11409)
								{
									continue;
								}
							}
							else if (this.$$switch$7496$41601 == "Whale")
							{
								if (229150 - 318954 != -89804)
								{
									continue;
								}
								this.$mType$41600 = 4;
								if (180199 - 34024 != 146175)
								{
									continue;
								}
							}
							else if (this.$$switch$7496$41601 == "Cat")
							{
								if (34658 - 406253 == -371594)
								{
									continue;
								}
								this.$mType$41600 = 5;
								if (136053 - 564511 != -428458)
								{
									continue;
								}
							}
							else if (this.$$switch$7496$41601 == "Chameleon")
							{
								if (233282 - 283488 != -50206)
								{
									continue;
								}
								this.$mType$41600 = 6;
								if (293941 - 428043 == -134101)
								{
									continue;
								}
							}
							else if (this.$$switch$7496$41601 == "Rabbit")
							{
								if (183324 - 461999 == -278674)
								{
									continue;
								}
								this.$mType$41600 = 7;
								if (185766 - 291375 == -105608)
								{
									continue;
								}
							}
							else if (this.$$switch$7496$41601 == "Mole")
							{
								if (97176 - 539202 == -442025)
								{
									continue;
								}
								this.$mType$41600 = 8;
								if (112957 - 205877 == -92919)
								{
									continue;
								}
							}
							else if (this.$$switch$7496$41601 == "Monkey")
							{
								if (271881 - 352270 != -80389)
								{
									continue;
								}
								this.$mType$41600 = 9;
								if (1716 - 530635 == -528918)
								{
									continue;
								}
							}
							else if (this.$$switch$7496$41601 == "Sheep")
							{
								if (191941 - 49745 == 142197)
								{
									continue;
								}
								this.$mType$41600 = 10;
								if (295854 - 36595 != 259259)
								{
									continue;
								}
							}
							else if (this.$$switch$7496$41601 == "Penguin")
							{
								if (223974 - 563414 != -339440)
								{
									continue;
								}
								this.$mType$41600 = 11;
								if (78660 - 5801 == 72860)
								{
									continue;
								}
							}
							else if (this.$$switch$7496$41601 == "Bat")
							{
								if (57587 - 335217 != -277630)
								{
									continue;
								}
								this.$mType$41600 = 12;
								if (254435 - 469479 == -215043)
								{
									continue;
								}
							}
							Game.sendMissionEvent(9051, this.$mType$41600);
							if (296194 - 500177 != -203982)
							{
								goto Block_270;
							}
							continue;
						}
						break;
					case 37:
						if (Game.mGameState != eGameState.Start)
						{
							if (146424 - 315870 != -169445)
							{
								goto Block_150;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (168703 - 236887 == -68183)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (131799 - 192147 != -60348)
							{
								continue;
							}
							this.$mGameGui$41602 = (GameGui)this.$self_$41607.GetComponent(typeof(GameGui));
							if (177772 - 91432 != 86340)
							{
								continue;
							}
							this.$mGameGui$41602.enabled = true;
							if (277672 - 530977 != -253305)
							{
								continue;
							}
							if (this.$self_$41607.battleMusic)
							{
								if (270942 - 360563 != -89621)
								{
									continue;
								}
								this.$self_$41607.audio.clip = this.$self_$41607.battleMusic;
								if (39512 - 242266 == -202753)
								{
									continue;
								}
								this.$self_$41607.audio.Play();
								if (251275 - 175156 == 76120)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (133074 - 581523 != -448449)
							{
								continue;
							}
							goto IL_2A09;
						}
						break;
					default:
						if (92408 - 233892 != -141483)
						{
							goto IL_1AE6;
						}
						continue;
					}
					if (this.$mStoryTimer$41592 > Time.time)
					{
						if (79212 - 525886 == -446673)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_10CB;
						}
						if (194401 - 88793 == 105609)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (122043 - 491830 != -369787)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$41591.newStoryMessage("ShadowGod", "Zera", Language.getMessage("M905_DarknessWithin", 110), eTalkType.enemy);
						if (181827 - 506241 != -324414)
						{
							continue;
						}
						this.$mStoryTimer$41592 = Time.time + 4f;
						if (159715 - 204605 != -44890)
						{
							continue;
						}
						goto IL_13D;
					}
					IL_166:
					if (this.$mStoryTimer$41592 > Time.time)
					{
						if (290563 - 104404 == 186160)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_159;
						}
						if (194939 - 462441 == -267501)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (151825 - 560836 != -409011)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$41591.newStoryMessage("ShadowGod", "Zera", Language.getMessage("M905_DarknessWithin", 111), eTalkType.enemy);
						if (53981 - 508324 == -454342)
						{
							continue;
						}
						this.$mStoryTimer$41592 = Time.time + 4f;
						if (69542 - 354571 != -285028)
						{
							goto Block_208;
						}
						continue;
					}
					IL_2129:
					if (this.$mStoryTimer$41592 > Time.time)
					{
						if (68565 - 499028 == -430462)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_211D;
						}
						if (291396 - 491966 == -200569)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (83113 - 593092 != -509978)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$41591.newStoryMessage("none", "???", Language.getMessage("M905_DarknessWithin", 103), eTalkType.enemy);
						if (265868 - 464504 == -198635)
						{
							continue;
						}
						this.$mStoryTimer$41592 = Time.time + 4f;
						if (280454 - 569623 != -289168)
						{
							goto Block_12;
						}
						continue;
					}
					IL_1768:
					if (this.$mStoryTimer$41592 > Time.time)
					{
						if (19312 - 386254 != -366942)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_175B;
						}
						if (101779 - 340604 == -238824)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (170062 - 23239 != 146824)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$41591.close();
						if (140354 - 39136 == 101219)
						{
							continue;
						}
						if (!this.$self_$41607.KHmnc6YP0G1)
						{
							goto IL_112C;
						}
						if (2523 - 194749 == -192225)
						{
							continue;
						}
						this.$self_$41607.KHmnc6YP0G1.animation.CrossFade("puppet", (float)1);
						if (204144 - 349156 != -145012)
						{
							continue;
						}
						goto IL_112C;
					}
					IL_12EE:
					if (this.$mStoryTimer$41592 > Time.time)
					{
						if (218896 - 459901 != -241005)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_12E1;
						}
						if (85379 - 392962 == -307582)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (9922 - 361309 != -351387)
						{
							continue;
						}
						break;
					}
					else
					{
						if (this.$self_$41607.curseFx)
						{
							if (265767 - 202053 == 63715)
							{
								continue;
							}
							this.$self_$41607.audio.PlayOneShot(this.$self_$41607.curseFx);
							if (224731 - 43870 != 180861)
							{
								continue;
							}
						}
						this.$mCameraEffect$41594 = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
						if (84661 - 518669 != -434008)
						{
							continue;
						}
						if (!this.$mCameraEffect$41594)
						{
							goto IL_6E2;
						}
						if (85198 - 574854 == -489655)
						{
							continue;
						}
						this.$mCameraEffect$41594.AddColorRamp("reverseRamp", "none", (float)1, new Vector4((float)0, 0.1f, 0.1f, 0.3f));
						if (91740 - 359391 != -267650)
						{
							goto Block_157;
						}
						continue;
					}
					IL_EAE:
					if (this.$mStoryTimer$41592 > Time.time)
					{
						if (273525 - 12006 != 261519)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_EA1;
						}
						if (290798 - 199762 != 91036)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (203924 - 283974 != -80050)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$41591.newStoryMessage("ShadowGod", "Zera", Language.getMessage("M905_DarknessWithin", 107), eTalkType.enemy);
						if (80362 - 576393 != -496031)
						{
							continue;
						}
						this.$mStoryTimer$41592 = Time.time + 4f;
						if (237731 - 50512 != 187219)
						{
							continue;
						}
						goto IL_2724;
					}
					IL_230F:
					if (this.$mStoryTimer$41592 > Time.time)
					{
						if (45116 - 531693 != -486577)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2302;
						}
						if (218207 - 232973 == -14765)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (79051 - 210442 != -131390)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$41591.newStoryMessage("ShadowGod", "Zera", Language.getMessage("M905_DarknessWithin", 106), eTalkType.enemy);
						if (272673 - 30378 == 242296)
						{
							continue;
						}
						this.$mStoryTimer$41592 = Time.time + 4f;
						if (223728 - 81104 != 142625)
						{
							goto Block_286;
						}
						continue;
					}
					IL_274D:
					if (this.$mStoryTimer$41592 > Time.time)
					{
						if (135933 - 188646 != -52713)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_2740;
						}
						if (3462 - 319318 == -315855)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (234488 - 245153 != -10664)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$41591.newStoryMessage("ShadowGod", "Zera", Language.getMessage("M905_DarknessWithin", 108), eTalkType.enemy);
						if (25938 - 56477 == -30538)
						{
							continue;
						}
						if (this.$self_$41607.KHmnc6YP0G1)
						{
							if (26998 - 45639 != -18641)
							{
								continue;
							}
							this.$self_$41607.KHmnc6YP0G1.animation.CrossFade("talk", (float)1);
							if (241321 - 350671 != -109350)
							{
								continue;
							}
						}
						this.$mStoryTimer$41592 = Time.time + 4f;
						if (138735 - 501903 != -363167)
						{
							goto Block_35;
						}
						continue;
					}
					IL_1AE6:
					Debug.Log("Start Game");
					if (255418 - 150495 != 104923)
					{
						continue;
					}
					Game.mGameState = eGameState.Start;
					if (217325 - 472053 == -254727)
					{
						continue;
					}
					Game.mStateTime = Time.time;
					if (242194 - 555570 == -313375)
					{
						continue;
					}
					this.$mCDat2$41582 = null;
					if (165807 - 79873 == 85935)
					{
						continue;
					}
					this.$mCDat3$41583 = null;
					if (190295 - 462809 != -272514)
					{
						continue;
					}
					this.$$switch$7494$41584 = CharacterData.mSlot;
					if (133539 - 468505 == -334965)
					{
						continue;
					}
					if (this.$$switch$7494$41584 == 1)
					{
						if (28964 - 469072 != -440108)
						{
							continue;
						}
						this.$mCDat2$41582 = CharacterData.getCDat(2);
						if (34511 - 445410 == -410898)
						{
							continue;
						}
						this.$mCDat3$41583 = CharacterData.getCDat(3);
						if (166170 - 23199 == 142972)
						{
							continue;
						}
					}
					else if (this.$$switch$7494$41584 == 2)
					{
						if (56182 - 450247 != -394065)
						{
							continue;
						}
						this.$mCDat2$41582 = CharacterData.getCDat(1);
						if (182549 - 143430 != 39119)
						{
							continue;
						}
						this.$mCDat3$41583 = CharacterData.getCDat(3);
						if (150992 - 94448 == 56545)
						{
							continue;
						}
					}
					else if (this.$$switch$7494$41584 == 3)
					{
						if (13666 - 178552 != -164886)
						{
							continue;
						}
						this.$mCDat2$41582 = CharacterData.getCDat(1);
						if (155580 - 454952 == -299371)
						{
							continue;
						}
						this.$mCDat3$41583 = CharacterData.getCDat(2);
						if (152686 - 70897 != 81789)
						{
							continue;
						}
					}
					this.$mPlayer1$41585 = Game.mPlayer;
					if (291918 - 103842 == 188077)
					{
						continue;
					}
					this.$mPlayer2$41586 = null;
					if (40300 - 35674 != 4626)
					{
						continue;
					}
					this.$mPlayer3$41587 = null;
					if (141958 - 164244 == -22285)
					{
						continue;
					}
					this.$mZerbiras$41588 = GameObject.Find("Zerbiras");
					if (63478 - 200079 != -136601)
					{
						continue;
					}
					this.$mStartPoint2$41589 = GameObject.Find("StartPoint2");
					if (226739 - 411170 != -184431)
					{
						continue;
					}
					if (this.$mStartPoint2$41589)
					{
						if (237169 - 550510 == -313340)
						{
							continue;
						}
						if (this.$mCDat2$41582 != null)
						{
							if (287378 - 100147 == 187232)
							{
								continue;
							}
							if (this.$mCDat2$41582.Type != "none")
							{
								if (71415 - 66747 != 4668)
								{
									continue;
								}
								this.$mPlayer2$41586 = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("GameAssets/Characters/Lobby/viewChar/" + this.$mCDat2$41582.Type, typeof(GameObject)), this.$mStartPoint2$41589.transform.position, this.$mStartPoint2$41589.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
								if (59164 - 321757 != -262593)
								{
									continue;
								}
								if (this.$mPlayer2$41586)
								{
									if (15868 - 514474 == -498605)
									{
										continue;
									}
									this.$mPlayer2$41586.SendMessage("EquipCDat", this.$mCDat2$41582.slot);
									if (193606 - 592143 == -398536)
									{
										continue;
									}
								}
							}
						}
					}
					this.$mStartPoint3$41590 = GameObject.Find("StartPoint3");
					if (153963 - 354483 == -200519)
					{
						continue;
					}
					if (this.$mStartPoint3$41590)
					{
						if (206856 - 143190 == 63667)
						{
							continue;
						}
						if (this.$mCDat3$41583 != null)
						{
							if (20168 - 305977 == -285808)
							{
								continue;
							}
							if (this.$mCDat3$41583.Type != "none")
							{
								if (294675 - 163600 == 131076)
								{
									continue;
								}
								this.$mPlayer3$41587 = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("GameAssets/Characters/Lobby/viewChar/" + this.$mCDat3$41583.Type, typeof(GameObject)), this.$mStartPoint3$41590.transform.position, this.$mStartPoint3$41590.transform.rotation * Quaternion.Euler((float)270, (float)90, (float)0));
								if (289109 - 400075 != -110966)
								{
									continue;
								}
								if (this.$mPlayer3$41587)
								{
									if (273458 - 433835 != -160377)
									{
										continue;
									}
									this.$mPlayer3$41587.SendMessage("EquipCDat", this.$mCDat3$41583.slot);
									if (111549 - 282601 != -171052)
									{
										continue;
									}
								}
							}
						}
					}
					this.$self_$41607.SendMessage("fadeIn");
					if (105414 - 313343 != -207928)
					{
						goto Block_130;
					}
					continue;
					IL_A1E:
					if (Time.time >= this.$mFadeTimer$41599 + (float)2)
					{
						if (45410 - 82588 != -37178)
						{
							continue;
						}
						goto IL_1DC7;
					}
					else
					{
						if (!this.$self_$41607.jwOnctti8PR)
						{
							goto IL_A11;
						}
						if (44824 - 127797 != -82973)
						{
							continue;
						}
						this.$$14552$41605 = 0.5f * (Time.time - this.$mFadeTimer$41599);
						if (54011 - 22022 != 31989)
						{
							continue;
						}
						if (211166 - 105920 == 105247)
						{
							continue;
						}
						this.$$14553$41606 = this.$self_$41607.jwOnctti8PR.materials[0].color;
						if (72298 - 56889 == 15410)
						{
							continue;
						}
						if (156568 - 127554 != 29014)
						{
							continue;
						}
						this.$$14553$41606.a = this.$$14552$41605;
						if (76122 - 66148 == 9975 || 254282 - 113793 == 140490)
						{
							continue;
						}
						this.$self_$41607.jwOnctti8PR.materials[0].color = this.$$14553$41606;
						if (149239 - 150476 != -1237)
						{
							continue;
						}
						if (199318 - 65285 != 134034)
						{
							goto Block_37;
						}
						continue;
					}
					IL_21AA:
					if (this.$mStoryTimer$41592 > Time.time)
					{
						if (39940 - 179469 != -139529)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_219D;
						}
						if (60199 - 432271 != -372072)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (244308 - 49726 != 194583)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$41591.newStoryMessage("ShadowGod", "Zera", Language.getMessage("M905_DarknessWithin", 109), eTalkType.enemy);
						if (211881 - 401895 != -190014)
						{
							continue;
						}
						this.$mStoryTimer$41592 = Time.time + 4f;
						if (163647 - 187359 != -23711)
						{
							goto Block_206;
						}
						continue;
					}
					IL_1275:
					if (this.$mStoryTimer$41592 > Time.time)
					{
						if (174243 - 43525 == 130719)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1268;
						}
						if (279519 - 586941 != -307422)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (84569 - 322328 != -237758)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$41591.newStoryMessage("ShadowGod", "Zera", Language.getMessage("M905_DarknessWithin", 112), eTalkType.enemy);
						if (291737 - 537582 == -245844)
						{
							continue;
						}
						this.$mStoryTimer$41592 = Time.time + 4f;
						if (173456 - 575232 != -401775)
						{
							goto Block_243;
						}
						continue;
					}
					IL_1DC7:
					this.$mStoryGui$41591.newStoryMessage("ShadowGod", "Zera", Language.getMessage("M905_DarknessWithin", 105), eTalkType.enemy);
					if (140704 - 221704 != -81000)
					{
						continue;
					}
					this.$mStoryTimer$41592 = Time.time + 4f;
					if (286551 - 15709 != 270842)
					{
						continue;
					}
					goto IL_22E6;
					IL_1FE1:
					if (this.$mStoryTimer$41592 > Time.time)
					{
						if (223670 - 301593 == -77922)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_1FD5;
						}
						if (147374 - 108095 != 39279)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (284000 - 369608 == -85608)
						{
							break;
						}
					}
					else
					{
						this.$mStoryGui$41591.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M905_DarknessWithin", 102), eTalkType.friend);
						if (218805 - 335215 != -116409)
						{
							this.$mEventCamera2$41593 = GameObject.Find("EventCamera2");
							if (262830 - 561467 == -298637)
							{
								if (this.$mEventCamera2$41593)
								{
									if (85057 - 545420 == -460362)
									{
										continue;
									}
									this.$self_$41607.RAoncnbDaGT.setSpecialTarget(this.$mEventCamera2$41593, 2f);
									if (107500 - 436566 == -329065)
									{
										continue;
									}
								}
								this.$mStoryTimer$41592 = Time.time + 4f;
								if (143639 - 597464 == -453825)
								{
									goto IL_2102;
								}
							}
						}
					}
				}
				goto IL_2A09;
				IL_13D:
				return this.Yield(29, new WaitForSeconds(0.5f));
				IL_159:
				return this.YieldDefault(30);
				Block_12:
				return this.Yield(9, new WaitForSeconds(0.5f));
				goto IL_2A09;
				Block_35:
				return this.Yield(25, new WaitForSeconds(0.5f));
				Block_37:
				goto IL_A11;
				IL_671:
				return this.Yield(16, new WaitForSeconds(2f));
				Block_50:
				goto IL_82C;
				IL_6E2:
				return this.Yield(11, new WaitForSeconds(0.3f));
				Block_52:
				goto IL_2A09;
				IL_82C:
				return this.Yield(3, new WaitForSeconds(0.2f));
				goto IL_2A09;
				IL_A11:
				return this.YieldDefault(18);
				IL_B23:
				return this.Yield(13, new WaitForSeconds(7.8f));
				Block_79:
				IL_BF2:
				IL_D28:
				IL_E39:
				goto IL_2A09;
				IL_EA1:
				return this.YieldDefault(22);
				IL_F17:
				return this.Yield(12, new WaitForSeconds(2f));
				IL_10CB:
				return this.YieldDefault(28);
				IL_112C:
				return this.Yield(35, new WaitForSeconds(1f));
				Block_124:
				goto IL_2A09;
				IL_1168:
				return this.Yield(17, new WaitForSeconds(2f));
				Block_130:
				return this.Yield(2, new WaitForSeconds(0.3f));
				Block_131:
				return this.Yield(14, new WaitForSeconds(0.1f));
				IL_1268:
				return this.YieldDefault(32);
				IL_12E1:
				return this.YieldDefault(10);
				Block_150:
				goto IL_2A09;
				Block_157:
				goto IL_6E2;
				IL_175B:
				return this.YieldDefault(34);
				goto IL_2A09;
				Block_205:
				goto IL_1168;
				Block_206:
				return this.Yield(27, new WaitForSeconds(0.5f));
				Block_208:
				return this.Yield(31, new WaitForSeconds(0.5f));
				Block_210:
				IL_1C51:
				IL_1C90:
				Block_226:
				goto IL_2A09;
				IL_1FBA:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_1FD5:
				return this.YieldDefault(6);
				Block_243:
				return this.Yield(33, new WaitForSeconds(0.5f));
				goto IL_2A09;
				IL_2102:
				return this.Yield(7, new WaitForSeconds(2f));
				IL_211D:
				return this.YieldDefault(8);
				IL_219D:
				return this.YieldDefault(26);
				Block_253:
				goto IL_F17;
				IL_22E6:
				return this.Yield(19, new WaitForSeconds(0.5f));
				IL_2302:
				return this.YieldDefault(20);
				Block_267:
				goto IL_B23;
				Block_270:
				return this.Yield(37, new WaitForSeconds(1f));
				Block_281:
				return this.Yield(36, new WaitForSeconds(1f));
				Block_286:
				return this.Yield(21, new WaitForSeconds(0.5f));
				IL_2724:
				return this.Yield(23, new WaitForSeconds(0.5f));
				IL_2740:
				return this.YieldDefault(24);
				Block_299:
				goto IL_2A09;
				Block_301:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_292D:
				return this.Yield(15, new WaitForSeconds(0.3f));
				IL_2A09:
				return false;
			}

			// Token: 0x06009273 RID: 37491 RVA: 0x01190870 File Offset: 0x0118EA70
			internal static bool zAU3lcVW1fimWx99PIyi()
			{
				return true;
			}

			// Token: 0x06009274 RID: 37492 RVA: 0x01190874 File Offset: 0x0118EA74
			internal static bool f5L8cqVW4wa3uBedY7k7()
			{
				return false;
			}

			// Token: 0x040089E2 RID: 35298
			internal CharacterDataClass $mCDat2$41582;

			// Token: 0x040089E3 RID: 35299
			internal CharacterDataClass $mCDat3$41583;

			// Token: 0x040089E4 RID: 35300
			internal int $$switch$7494$41584;

			// Token: 0x040089E5 RID: 35301
			internal GameObject $mPlayer1$41585;

			// Token: 0x040089E6 RID: 35302
			internal GameObject $mPlayer2$41586;

			// Token: 0x040089E7 RID: 35303
			internal GameObject $mPlayer3$41587;

			// Token: 0x040089E8 RID: 35304
			internal GameObject $mZerbiras$41588;

			// Token: 0x040089E9 RID: 35305
			internal GameObject $mStartPoint2$41589;

			// Token: 0x040089EA RID: 35306
			internal GameObject $mStartPoint3$41590;

			// Token: 0x040089EB RID: 35307
			internal StoryGui $mStoryGui$41591;

			// Token: 0x040089EC RID: 35308
			internal float $mStoryTimer$41592;

			// Token: 0x040089ED RID: 35309
			internal GameObject $mEventCamera2$41593;

			// Token: 0x040089EE RID: 35310
			internal CameraEffect $mCameraEffect$41594;

			// Token: 0x040089EF RID: 35311
			internal GameObject $mPalaceCam$41595;

			// Token: 0x040089F0 RID: 35312
			internal GameObject $mEventCamera3$41596;

			// Token: 0x040089F1 RID: 35313
			internal GameObject $mStartPoint4$41597;

			// Token: 0x040089F2 RID: 35314
			internal GameObject $mEventCamera4$41598;

			// Token: 0x040089F3 RID: 35315
			internal float $mFadeTimer$41599;

			// Token: 0x040089F4 RID: 35316
			internal int $mType$41600;

			// Token: 0x040089F5 RID: 35317
			internal string $$switch$7496$41601;

			// Token: 0x040089F6 RID: 35318
			internal GameGui $mGameGui$41602;

			// Token: 0x040089F7 RID: 35319
			internal int $$14550$41603;

			// Token: 0x040089F8 RID: 35320
			internal Color $$14551$41604;

			// Token: 0x040089F9 RID: 35321
			internal float $$14552$41605;

			// Token: 0x040089FA RID: 35322
			internal Color $$14553$41606;

			// Token: 0x040089FB RID: 35323
			internal M905_DarknessWithin $self_$41607;
		}
	}

	// Token: 0x02001895 RID: 6293
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$41609 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009275 RID: 37493 RVA: 0x01190878 File Offset: 0x0118EA78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$41609(M905_DarknessWithin self_)
		{
			if (137947 - 291183 != -153235)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (157419 - 173974 != -16554)
				{
					base..ctor();
					if (35883 - 147542 == -111659)
					{
						this.$self_$41614 = self_;
						if (176549 - 298095 == -121546)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009276 RID: 37494 RVA: 0x01190910 File Offset: 0x0118EB10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M905_DarknessWithin.$onDeadPlayer$41609.$(this.$self_$41614);
		}

		// Token: 0x06009277 RID: 37495 RVA: 0x01190920 File Offset: 0x0118EB20
		internal static bool wd3l3aVWzQvBmh5YAcEc()
		{
			return true;
		}

		// Token: 0x06009278 RID: 37496 RVA: 0x01190924 File Offset: 0x0118EB24
		internal static bool xPa9GhVAa2XCgLyAkOou()
		{
			return false;
		}

		// Token: 0x040089FC RID: 35324
		internal M905_DarknessWithin $self_$41614;

		// Token: 0x02001896 RID: 6294
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009279 RID: 37497 RVA: 0x01190928 File Offset: 0x0118EB28
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M905_DarknessWithin self_)
			{
				if (218361 - 566785 != -348424)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (31515 - 31404 == 111)
					{
						base..ctor();
						if (123564 - 202162 != -78597)
						{
							this.$self_$41613 = self_;
							if (253784 - 131586 != 122199)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600927A RID: 37498 RVA: 0x011909C0 File Offset: 0x0118EBC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (221068 - 212764 != 8304)
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
							goto IL_2AF;
						}
						if (84908 - 155580 == -70671)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (52173 - 452024 != -399850)
							{
								goto IL_2AF;
							}
							continue;
						}
						IL_1A0:
						this.YieldDefault(1);
						if (110064 - 240661 != -130597)
						{
							continue;
						}
						goto IL_2F9;
						IL_2AF:
						Game.mGameState = eGameState.Hold;
						if (161202 - 334357 != -173155)
						{
							continue;
						}
						this.$mStoryGui$41610 = (StoryGui)this.$self_$41613.GetComponent(typeof(StoryGui));
						if (183127 - 255096 != -71969)
						{
							continue;
						}
						if (this.$mStoryGui$41610)
						{
							if (170845 - 100956 != 69889)
							{
								continue;
							}
							this.$mStoryGui$41610.close();
							if (248515 - 25549 != 222966)
							{
								continue;
							}
						}
						this.$mChangeGui$41611 = (ChangeGui)this.$self_$41613.GetComponent(typeof(ChangeGui));
						if (154321 - 488314 != -333993)
						{
							continue;
						}
						if (this.$mChangeGui$41611)
						{
							if (189051 - 217954 != -28903)
							{
								continue;
							}
							this.$mChangeGui$41611.close();
							if (289695 - 451925 == -162229)
							{
								continue;
							}
						}
						this.$mGameGui$41612 = (GameGui)this.$self_$41613.GetComponent(typeof(GameGui));
						if (233109 - 357990 == -124880)
						{
							continue;
						}
						if (!this.$mGameGui$41612)
						{
							goto IL_1A0;
						}
						if (130068 - 575533 != -445465)
						{
							continue;
						}
						if (!this.$mGameGui$41612.enabled)
						{
							if (186132 - 70973 != 115159)
							{
								continue;
							}
							this.$mGameGui$41612.enabled = true;
							if (211828 - 308090 != -96262)
							{
								continue;
							}
						}
						this.$mGameGui$41612.openDeadMenu();
						if (146671 - 517625 != -370954)
						{
							continue;
						}
						goto IL_1A0;
					default:
						if (231954 - 189184 == 42771)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (24626 - 394519 == -369892);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600927B RID: 37499 RVA: 0x01190CD8 File Offset: 0x0118EED8
			internal static bool qPplPJVA5nuHXEEYb2vu()
			{
				return true;
			}

			// Token: 0x0600927C RID: 37500 RVA: 0x01190CDC File Offset: 0x0118EEDC
			internal static bool U7M54NVAp2noDjD9qi1Z()
			{
				return false;
			}

			// Token: 0x040089FD RID: 35325
			internal StoryGui $mStoryGui$41610;

			// Token: 0x040089FE RID: 35326
			internal ChangeGui $mChangeGui$41611;

			// Token: 0x040089FF RID: 35327
			internal GameGui $mGameGui$41612;

			// Token: 0x04008A00 RID: 35328
			internal M905_DarknessWithin $self_$41613;
		}
	}

	// Token: 0x02001897 RID: 6295
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$41615 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600927D RID: 37501 RVA: 0x01190CE0 File Offset: 0x0118EEE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$41615(Hashtable data, M905_DarknessWithin self_)
		{
			if (4781 - 120395 != -115613)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (274779 - 175601 == 99178)
				{
					base..ctor();
					if (175263 - 399687 == -224424)
					{
						this.$data$41620 = data;
						if (177677 - 274203 == -96526)
						{
							this.$self_$41621 = self_;
							if (176915 - 570619 == -393704)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600927E RID: 37502 RVA: 0x01190D9C File Offset: 0x0118EF9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M905_DarknessWithin.$onChangePlayer$41615.$(this.$data$41620, this.$self_$41621);
		}

		// Token: 0x0600927F RID: 37503 RVA: 0x01190DB0 File Offset: 0x0118EFB0
		internal static bool ApDOubVAVl5lvUq58k3j()
		{
			return true;
		}

		// Token: 0x06009280 RID: 37504 RVA: 0x01190DB4 File Offset: 0x0118EFB4
		internal static bool au2P4QVAtAausLEusoFe()
		{
			return false;
		}

		// Token: 0x04008A01 RID: 35329
		internal Hashtable $data$41620;

		// Token: 0x04008A02 RID: 35330
		internal M905_DarknessWithin $self_$41621;

		// Token: 0x02001898 RID: 6296
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009281 RID: 37505 RVA: 0x01190DB8 File Offset: 0x0118EFB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M905_DarknessWithin self_)
			{
				if (165436 - 525778 != -360342)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (262467 - 121775 != 140693)
					{
						base..ctor();
						if (93958 - 171556 != -77597)
						{
							this.$data$41618 = data;
							if (268467 - 508779 == -240312)
							{
								this.$self_$41619 = self_;
								if (99593 - 31255 != 68339)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009282 RID: 37506 RVA: 0x01190E74 File Offset: 0x0118F074
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (293323 - 104082 != 189241)
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
							if (217026 - 491275 == -274248)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (234612 - 525498 != -290886)
							{
								continue;
							}
							this.$mGameGui$41617 = (GameGui)this.$self_$41619.GetComponent(typeof(GameGui));
							if (203552 - 587336 != -383784)
							{
								continue;
							}
							this.$mGameGui$41617.enabled = true;
							if (189772 - 359916 != -170144)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (81769 - 227673 != -145904)
						{
							continue;
						}
						goto IL_205;
					default:
						if (101746 - 464699 == -362952)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (170567 - 188652 == -18085)
					{
						this.$self_$41619.SendMessage("onCreatePlayer", this.$data$41618);
						if (48151 - 488158 == -440007)
						{
							this.$mChangeGui$41616 = (ChangeGui)this.$self_$41619.GetComponent(typeof(ChangeGui));
							if (45134 - 431997 != -386862)
							{
								if (!this.$mChangeGui$41616.enabled)
								{
									break;
								}
								if (171698 - 400433 != -228734)
								{
									this.$mChangeGui$41616.close();
									if (172701 - 75886 == 96815)
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

			// Token: 0x06009283 RID: 37507 RVA: 0x01191098 File Offset: 0x0118F298
			internal static bool ARgUWuVANKBaOUWMTp6b()
			{
				return true;
			}

			// Token: 0x06009284 RID: 37508 RVA: 0x0119109C File Offset: 0x0118F29C
			internal static bool D16Qo1VAYom2BR17C9Ky()
			{
				return false;
			}

			// Token: 0x04008A03 RID: 35331
			internal ChangeGui $mChangeGui$41616;

			// Token: 0x04008A04 RID: 35332
			internal GameGui $mGameGui$41617;

			// Token: 0x04008A05 RID: 35333
			internal Hashtable $data$41618;

			// Token: 0x04008A06 RID: 35334
			internal M905_DarknessWithin $self_$41619;
		}
	}

	// Token: 0x02001899 RID: 6297
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$41622 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009285 RID: 37509 RVA: 0x011910A0 File Offset: 0x0118F2A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$41622(M905_DarknessWithin self_)
		{
			if (62387 - 203164 != -140776)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (60107 - 532998 != -472890)
				{
					base..ctor();
					if (231071 - 382918 == -151847)
					{
						this.$self_$41626 = self_;
						if (218722 - 31849 != 186874)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009286 RID: 37510 RVA: 0x01191138 File Offset: 0x0118F338
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M905_DarknessWithin.$ReturnToTown$41622.$(this.$self_$41626);
		}

		// Token: 0x06009287 RID: 37511 RVA: 0x01191148 File Offset: 0x0118F348
		internal static bool DXV0kYVAcQQsEd74lxLc()
		{
			return true;
		}

		// Token: 0x06009288 RID: 37512 RVA: 0x0119114C File Offset: 0x0118F34C
		internal static bool IZimxWVAUdK2pq4VKPD9()
		{
			return false;
		}

		// Token: 0x04008A07 RID: 35335
		internal M905_DarknessWithin $self_$41626;

		// Token: 0x0200189A RID: 6298
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009289 RID: 37513 RVA: 0x01191150 File Offset: 0x0118F350
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M905_DarknessWithin self_)
			{
				if (61722 - 242452 != -180730)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (180600 - 573719 == -393119)
					{
						base..ctor();
						if (11494 - 279825 != -268330)
						{
							this.$self_$41625 = self_;
							if (238806 - 439665 == -200859)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600928A RID: 37514 RVA: 0x011911E8 File Offset: 0x0118F3E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (97167 - 334623 != -237456)
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
						this.$self_$41625.LeaveGame();
						if (111106 - 178387 != -67281)
						{
							continue;
						}
						this.YieldDefault(1);
						if (91799 - 256802 != -165003)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (217908 - 446387 == -228478)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (125267 - 160712 != -35444)
					{
						Game.mStateTime = Time.time;
						if (119445 - 89899 != 29547)
						{
							this.$$switch$7500$41623 = PlayerData.SaveGuild;
							if (220618 - 415374 == -194756)
							{
								if (this.$$switch$7500$41623 == 1)
								{
									if (228082 - 246880 == -18797)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (213656 - 297982 == -84325)
									{
										continue;
									}
								}
								else if (this.$$switch$7500$41623 == 2)
								{
									if (73277 - 58010 != 15267)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (166243 - 331193 == -164949)
									{
										continue;
									}
								}
								else if (this.$$switch$7500$41623 == 3)
								{
									if (8673 - 247988 != -239315)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (25002 - 85919 != -60917)
									{
										continue;
									}
								}
								else if (this.$$switch$7500$41623 == 4)
								{
									if (263274 - 212467 == 50808)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (239937 - 243403 == -3465)
									{
										continue;
									}
								}
								else if (this.$$switch$7500$41623 == 5)
								{
									if (171834 - 392879 == -221044)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (188664 - 146421 == 42244)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (25418 - 164598 != -139180)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (207009 - 77589 != 129420)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (86848 - 498270 != -411422)
									{
										continue;
									}
								}
								this.$mGameGui$41624 = (GameGui)this.$self_$41625.GetComponent(typeof(GameGui));
								if (23517 - 441055 != -417537)
								{
									if (this.$mGameGui$41624)
									{
										if (122295 - 566639 != -444344)
										{
											continue;
										}
										this.$mGameGui$41624.close();
										if (201970 - 61496 == 140475)
										{
											continue;
										}
									}
									this.$self_$41625.SendMessage("fadeOut");
									if (4403 - 240428 == -236025)
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

			// Token: 0x0600928B RID: 37515 RVA: 0x011915B4 File Offset: 0x0118F7B4
			internal static bool EtosuOVAT9d1q46qpQcS()
			{
				return true;
			}

			// Token: 0x0600928C RID: 37516 RVA: 0x011915B8 File Offset: 0x0118F7B8
			internal static bool FaAu8SVA3bMjUGgrpGnN()
			{
				return false;
			}

			// Token: 0x04008A08 RID: 35336
			internal int $$switch$7500$41623;

			// Token: 0x04008A09 RID: 35337
			internal GameGui $mGameGui$41624;

			// Token: 0x04008A0A RID: 35338
			internal M905_DarknessWithin $self_$41625;
		}
	}

	// Token: 0x0200189B RID: 6299
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$41627 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600928D RID: 37517 RVA: 0x011915BC File Offset: 0x0118F7BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$41627(M905_DarknessWithin self_)
		{
			if (283542 - 550333 != -266790)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (216002 - 562024 != -346021)
				{
					base..ctor();
					if (257404 - 562981 != -305576)
					{
						this.$self_$41630 = self_;
						if (119561 - 323856 != -204294)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600928E RID: 37518 RVA: 0x01191654 File Offset: 0x0118F854
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M905_DarknessWithin.$ReturnToGuild$41627.$(this.$self_$41630);
		}

		// Token: 0x0600928F RID: 37519 RVA: 0x01191664 File Offset: 0x0118F864
		internal static bool I48jiYVAXGXb9SWtSW2v()
		{
			return true;
		}

		// Token: 0x06009290 RID: 37520 RVA: 0x01191668 File Offset: 0x0118F868
		internal static bool ucfRTjVAQJ5u17A7I0lt()
		{
			return false;
		}

		// Token: 0x04008A0B RID: 35339
		internal M905_DarknessWithin $self_$41630;

		// Token: 0x0200189C RID: 6300
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009291 RID: 37521 RVA: 0x0119166C File Offset: 0x0118F86C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M905_DarknessWithin self_)
			{
				if (126540 - 165649 != -39109)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (103972 - 548071 == -444099)
					{
						base..ctor();
						if (16311 - 367141 == -350830)
						{
							this.$self_$41629 = self_;
							if (52748 - 286331 == -233583)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009292 RID: 37522 RVA: 0x01191704 File Offset: 0x0118F904
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (118270 - 89146 != 29125)
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
						this.$self_$41629.LeaveGame();
						if (60219 - 151627 == -91407)
						{
							continue;
						}
						this.YieldDefault(1);
						if (62823 - 74213 != -11390)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (62027 - 119267 != -57240)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (25712 - 192152 != -166439)
					{
						Game.mStateTime = Time.time;
						if (91106 - 523451 != -432344)
						{
							Game.mNextGameCode = 31;
							if (174895 - 104673 != 70223)
							{
								this.$mGameGui$41628 = (GameGui)this.$self_$41629.GetComponent(typeof(GameGui));
								if (29952 - 299367 != -269414)
								{
									if (this.$mGameGui$41628)
									{
										if (250847 - 428034 == -177186)
										{
											continue;
										}
										this.$mGameGui$41628.close();
										if (116434 - 466311 == -349876)
										{
											continue;
										}
									}
									this.$self_$41629.SendMessage("fadeOut");
									if (208265 - 34259 != 174007)
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

			// Token: 0x06009293 RID: 37523 RVA: 0x011918E0 File Offset: 0x0118FAE0
			internal static bool oQ45yCVAkRlCM6rbUwtV()
			{
				return true;
			}

			// Token: 0x06009294 RID: 37524 RVA: 0x011918E4 File Offset: 0x0118FAE4
			internal static bool fwTsQPVAGYk1ulwC5tqh()
			{
				return false;
			}

			// Token: 0x04008A0C RID: 35340
			internal GameGui $mGameGui$41628;

			// Token: 0x04008A0D RID: 35341
			internal M905_DarknessWithin $self_$41629;
		}
	}

	// Token: 0x0200189D RID: 6301
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$41631 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009295 RID: 37525 RVA: 0x011918E8 File Offset: 0x0118FAE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$41631(M905_DarknessWithin self_)
		{
			if (245594 - 177677 != 67917)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (39324 - 240749 == -201425)
				{
					base..ctor();
					if (215185 - 529953 != -314767)
					{
						this.$self_$41635 = self_;
						if (57639 - 316760 != -259120)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009296 RID: 37526 RVA: 0x01191980 File Offset: 0x0118FB80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M905_DarknessWithin.$ReturnToCamp$41631.$(this.$self_$41635);
		}

		// Token: 0x06009297 RID: 37527 RVA: 0x01191990 File Offset: 0x0118FB90
		internal static bool hiNmP6VAHF3kGhQI2hMc()
		{
			return true;
		}

		// Token: 0x06009298 RID: 37528 RVA: 0x01191994 File Offset: 0x0118FB94
		internal static bool FP4t8lVAWS97vlmMN1L2()
		{
			return false;
		}

		// Token: 0x04008A0E RID: 35342
		internal M905_DarknessWithin $self_$41635;

		// Token: 0x0200189E RID: 6302
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009299 RID: 37529 RVA: 0x01191998 File Offset: 0x0118FB98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M905_DarknessWithin self_)
			{
				if (93023 - 445499 != -352476)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (93032 - 26424 != 66609)
					{
						base..ctor();
						if (151098 - 498842 != -347743)
						{
							this.$self_$41634 = self_;
							if (238624 - 122069 == 116555)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600929A RID: 37530 RVA: 0x01191A30 File Offset: 0x0118FC30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (39781 - 487677 != -447895)
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
						this.$self_$41634.LeaveGame();
						if (123262 - 510328 != -387066)
						{
							continue;
						}
						this.YieldDefault(1);
						if (195000 - 430126 != -235125)
						{
							goto Block_8;
						}
						continue;
					default:
						if (12978 - 435822 == -422843)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (47177 - 438801 == -391624)
					{
						Game.mStateTime = Time.time;
						if (255788 - 529937 == -274149)
						{
							this.$$switch$7502$41632 = PlayerData.SaveGuild;
							if (14371 - 583810 == -569439)
							{
								if (this.$$switch$7502$41632 == 1)
								{
									if (24776 - 8744 != 16032)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (111 - 114328 == -114216)
									{
										continue;
									}
								}
								else if (this.$$switch$7502$41632 == 2)
								{
									if (275351 - 94018 != 181333)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (100548 - 11671 == 88878)
									{
										continue;
									}
								}
								else if (this.$$switch$7502$41632 == 3)
								{
									if (9371 - 137096 != -127725)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (28702 - 539774 != -511072)
									{
										continue;
									}
								}
								else if (this.$$switch$7502$41632 == 4)
								{
									if (146623 - 349492 == -202868)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (221478 - 120385 == 101094)
									{
										continue;
									}
								}
								else if (this.$$switch$7502$41632 == 5)
								{
									if (47192 - 229631 == -182438)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (115446 - 227015 != -111569)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (227534 - 441319 != -213785)
									{
										continue;
									}
								}
								this.$mGameGui$41633 = (GameGui)this.$self_$41634.GetComponent(typeof(GameGui));
								if (45874 - 397649 != -351774)
								{
									if (this.$mGameGui$41633)
									{
										if (179621 - 348946 == -169324)
										{
											continue;
										}
										this.$mGameGui$41633.close();
										if (248540 - 276559 == -28018)
										{
											continue;
										}
									}
									this.$self_$41634.SendMessage("fadeOut");
									if (3471 - 232184 == -228713)
									{
										goto IL_253;
									}
								}
							}
						}
					}
				}
				Block_8:
				goto IL_363;
				IL_253:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x0600929B RID: 37531 RVA: 0x01191DB4 File Offset: 0x0118FFB4
			internal static bool pjNDXWVAAEUKPrSojBE5()
			{
				return true;
			}

			// Token: 0x0600929C RID: 37532 RVA: 0x01191DB8 File Offset: 0x0118FFB8
			internal static bool E0JIQvVAlkpsm47I2pPe()
			{
				return false;
			}

			// Token: 0x04008A0F RID: 35343
			internal int $$switch$7502$41632;

			// Token: 0x04008A10 RID: 35344
			internal GameGui $mGameGui$41633;

			// Token: 0x04008A11 RID: 35345
			internal M905_DarknessWithin $self_$41634;
		}
	}
}
