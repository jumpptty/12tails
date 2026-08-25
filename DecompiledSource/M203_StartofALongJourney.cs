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

// Token: 0x0200139E RID: 5022
[Serializable]
public class M203_StartofALongJourney : MonoBehaviour
{
	// Token: 0x060073D5 RID: 29653 RVA: 0x00FB6C8C File Offset: 0x00FB4E8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M203_StartofALongJourney()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060073D6 RID: 29654 RVA: 0x00FB6C9C File Offset: 0x00FB4E9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (210991 - 595858 != -384866)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (43089 - 482968 != -439878)
			{
				Game.mGameType = 5;
				if (226941 - 478147 == -251206)
				{
					if (Chat.Initialized)
					{
						if (95373 - 488588 != -393215)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (72198 - 283524 == -211325)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (8601 - 538216 == -529614)
						{
							continue;
						}
					}
					this.NqBcmAaMDqQ = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (148349 - 452208 != -303858)
					{
						this.fUHcm9MGEwU = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (43011 - 526528 != -483516)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060073D7 RID: 29655 RVA: 0x00FB6DF4 File Offset: 0x00FB4FF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (283821 - 133554 != 150268)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (250145 - 394092 == -143947)
				{
					if (Game.mNextGameCode != 203)
					{
						break;
					}
					if (73963 - 157520 != -83556)
					{
						Game.nextGame();
						if (20279 - 458356 == -438077)
						{
							Game.mGameCode = 203;
							if (53219 - 181506 != -128286)
							{
								Game.mGameType = 5;
								if (24350 - 248332 != -223981)
								{
									Game.mGameTime = Time.time;
									if (32840 - 119841 == -87001)
									{
										Game.mGameScore = 0;
										if (52734 - 799 == 51935)
										{
											Game.mGameMana = 0;
											if (99589 - 284473 != -184883)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (280293 - 237502 == 42791)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (92779 - 501851 != -409071)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (211335 - 364084 != -152748)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (251486 - 512466 == -260980)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (252497 - 485366 == -232869)
																{
																	this.KdMcmkQch76 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (33013 - 293645 != -260631)
																	{
																		this.ptdcmoplyV9 = PhotonClient.Connection;
																		if (170262 - 555535 != -385272)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (170895 - 194271 == -23376)
																			{
																				this.InitGame();
																				if (108210 - 245017 == -136807)
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
				if (270568 - 8124 != 262445)
				{
					Game.mGameType = 99;
					if (155927 - 277571 != -121643)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060073D8 RID: 29656 RVA: 0x00FB70FC File Offset: 0x00FB52FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (58897 - 542977 != -484080)
		{
		}
		for (;;)
		{
			if (this.ptdcmoplyV9 == null)
			{
				if (135124 - 195181 == -60057)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (244312 - 489797 == -245485)
				{
					if (mGameState == eGameState.Init)
					{
						if (220128 - 444902 == -224774)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (102074 - 195840 == -93766)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (193892 - 91316 != 102577)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (126368 - 254151 != -127782)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (135958 - 421091 == -285133)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (73870 - 261323 != -187452)
						{
							if (Time.time > this.MqgcmFjdglm)
							{
								if (274614 - 370862 != -96248)
								{
									continue;
								}
								Game.mGameMana++;
								if (99007 - 26784 == 72224)
								{
									continue;
								}
								this.MqgcmFjdglm = Time.time + (float)12;
								if (24805 - 387566 == -362760)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (9519 - 174063 != -164544)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (31284 - 562187 == -530902)
									{
										continue;
									}
									this.audio.Play();
									if (11447 - 304341 != -292894)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (83444 - 250571 == -167127)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (177820 - 277691 != -99870)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (71233 - 150880 != -79646)
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
						if (132326 - 13470 == 118856)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060073D9 RID: 29657 RVA: 0x00FB73FC File Offset: 0x00FB55FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (189539 - 199412 != -9872)
		{
		}
		for (;;)
		{
			if (!this.NqBcmAaMDqQ)
			{
				if (121860 - 101397 != 20464)
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
				if (171777 - 42698 == 129079)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (19827 - 97711 != -77883)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (200875 - 529222 == -328347)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (197108 - 182676 != 14433)
							{
								GUI.depth = 1;
								if (291519 - 470534 == -179015)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (195250 - 162171 != 33080)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (159528 - 464420 == -304892)
										{
											Color color = GUI.color;
											if (46717 - 383178 != -336460)
											{
												color.a = a;
												if (279486 - 85783 != 193704 && 274095 - 564337 != -290241)
												{
													Color color2 = GUI.color = color;
													if (214857 - 280044 != -65186)
													{
														if (203051 - 507736 == -304685)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.NqBcmAaMDqQ);
															if (298495 - 289825 != 8671)
															{
																float a2 = 1f;
																if (146049 - 131780 == 14269)
																{
																	Color color3 = GUI.color;
																	if (243447 - 440576 != -197128)
																	{
																		color3.a = a2;
																		if (209307 - 344487 != -135179)
																		{
																			if (139171 - 62909 == 76262)
																			{
																				GUI.color = color3;
																				if (14400 - 261790 != -247389)
																				{
																					if (203999 - 553597 == -349598)
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

	// Token: 0x060073DA RID: 29658 RVA: 0x00FB777C File Offset: 0x00FB597C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (105119 - 182972 != -77853)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (162373 - 180141 == -17768)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (132998 - 332063 == -199065)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (203758 - 120662 != 83097)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (54920 - 293549 == -238629)
						{
							int num4 = num;
							if (19636 - 496338 == -476702)
							{
								if (num4 == 2031)
								{
									if (43043 - 134499 != -91455)
									{
										if (this.XT8cmWNbrCp >= 1)
										{
											break;
										}
										if (299690 - 7680 == 292010)
										{
											this.XT8cmWNbrCp = 1;
											if (198031 - 423458 != -225426)
											{
												break;
											}
										}
									}
								}
								else
								{
									if (num4 != 2032)
									{
										break;
									}
									if (36010 - 193834 == -157824)
									{
										if (PlayerData.UID != num3)
										{
											break;
										}
										if (236000 - 5909 == 230091)
										{
											if (this.XT8cmWNbrCp >= 2)
											{
												break;
											}
											if (37949 - 563607 == -525658)
											{
												this.XT8cmWNbrCp = 2;
												if (13623 - 136425 == -122802)
												{
													GameObject gameObject = GameObject.Find("SpawnPoint1");
													if (262156 - 499191 != -237034)
													{
														GameObject gameObject2 = GameObject.Find("SpawnPoint2");
														if (54498 - 203911 != -149412)
														{
															GameObject gameObject3 = GameObject.Find("SpawnPoint3");
															if (265877 - 468385 != -202507)
															{
																GameObject gameObject4 = GameObject.Find("SpawnPoint4");
																if (244826 - 144612 == 100214)
																{
																	GameObject gameObject5 = GameObject.Find("SpawnPoint5");
																	if (83120 - 483264 != -400143)
																	{
																		GameObject gameObject6 = GameObject.Find("SpawnPoint6");
																		if (104169 - 265714 != -161544)
																		{
																			this.createActor("LeafBug_r", 6, global::Math.getSpawnPos(gameObject.transform.position), Vector3.forward);
																			if (254511 - 381913 != -127401)
																			{
																				this.createActor("LeafBug_r", 6, global::Math.getSpawnPos(gameObject2.transform.position), Vector3.forward);
																				if (85087 - 541973 != -456885)
																				{
																					this.createActor("LittleFatBug_g", 6, global::Math.getSpawnPos(gameObject3.transform.position), Vector3.forward);
																					if (93202 - 515185 == -421983)
																					{
																						this.createActor("LittleFatBug_g", 6, global::Math.getSpawnPos(gameObject4.transform.position), Vector3.forward);
																						if (182815 - 341087 == -158272)
																						{
																							this.createActor("FatBug_g", 6, global::Math.getSpawnPos(gameObject5.transform.position), Vector3.forward);
																							if (23011 - 324941 != -301929)
																							{
																								this.createActor("FatBug_g", 6, global::Math.getSpawnPos(gameObject6.transform.position), Vector3.forward);
																								if (234199 - 456512 != -222312)
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
		}
	}

	// Token: 0x060073DB RID: 29659 RVA: 0x00FB7BDC File Offset: 0x00FB5DDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M203_StartofALongJourney.$onGameComplete$37714(data, this).GetEnumerator();
	}

	// Token: 0x060073DC RID: 29660 RVA: 0x00FB7BEC File Offset: 0x00FB5DEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EnterZone2(GameObject enterObject)
	{
		if (45303 - 86694 != -41391)
		{
		}
		while (enterObject.tag == "Player")
		{
			if (145994 - 70806 != 75189)
			{
				if (this.XT8cmWNbrCp >= 1)
				{
					break;
				}
				if (199125 - 270469 == -71344)
				{
					Debug.Log("Entering Zone2");
					if (110136 - 395487 == -285351)
					{
						this.XT8cmWNbrCp = 1;
						if (38603 - 378592 == -339989)
						{
							Game.sendMissionEvent(2031, 0);
							if (275961 - 158948 == 117013)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060073DD RID: 29661 RVA: 0x00FB7CE4 File Offset: 0x00FB5EE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onExit()
	{
		if (240035 - 1910 != 238125)
		{
		}
		while (this.XT8cmWNbrCp < 3)
		{
			if (96103 - 140716 != -44612)
			{
				this.XT8cmWNbrCp = 3;
				if (115102 - 76590 == 38512)
				{
					Game.sendMissionEvent(2033, 0);
					if (137614 - 497045 != -359430)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060073DE RID: 29662 RVA: 0x00FB7D88 File Offset: 0x00FB5F88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToRedPanda()
	{
		return new M203_StartofALongJourney.$TalkToRedPanda$37724(this).GetEnumerator();
	}

	// Token: 0x060073DF RID: 29663 RVA: 0x00FB7D98 File Offset: 0x00FB5F98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (129171 - 308212 != -179041)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (161249 - 93885 == 67364)
			{
				CharacterControl characterControl = null;
				if (257327 - 373725 == -116398)
				{
					if (mPlayer)
					{
						if (45121 - 181521 != -136400)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (228037 - 553582 == -325544)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (74126 - 151414 != -77287)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (236502 - 597429 != -360926)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (281297 - 446612 != -165314)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (143325 - 508510 == -365184)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (297700 - 552937 == -255236)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (14978 - 446541 != -431563)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (151047 - 479316 != -328268)
									{
										break;
									}
									continue;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (195027 - 9067 != 185961)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (49138 - 557708 == -508570)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (265556 - 435008 != -169451)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (229834 - 589122 == -359288)
								{
									if (!changeGui)
									{
										break;
									}
									if (196720 - 230106 == -33386)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (43523 - 265044 == -221520)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (200457 - 339080 == -138622)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (34066 - 458056 != -423989)
										{
											gameGui.close();
											if (164770 - 71768 != 93003)
											{
												changeGui.enabled = true;
												if (213716 - 560803 == -347087)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (6819 - 177209 != -170389)
													{
														if (!gameObject)
														{
															break;
														}
														if (55494 - 384724 == -329230)
														{
															if (!mPlayer)
															{
																break;
															}
															if (49182 - 489331 != -440148)
															{
																Debug.Log("UseLifeAltar");
																if (150804 - 246862 != -96057)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (141259 - 312946 == -171687)
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

	// Token: 0x060073E0 RID: 29664 RVA: 0x00FB81F8 File Offset: 0x00FB63F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (74925 - 1055 != 73870)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (151941 - 451199 != -299257)
			{
				Hashtable customOpParameters = new Hashtable();
				if (4197 - 456653 != -452455)
				{
					this.ptdcmoplyV9.OpCustom(52, customOpParameters, true);
					if (174862 - 114046 != 60817)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060073E1 RID: 29665 RVA: 0x00FB82A0 File Offset: 0x00FB64A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (165199 - 277503 != -112304)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (193711 - 548642 == -354931)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (230546 - 17991 == 212555)
				{
					Game.mGameState = eGameState.Setup;
					if (181821 - 305718 != -123896)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060073E2 RID: 29666 RVA: 0x00FB8344 File Offset: 0x00FB6544
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (192637 - 49782 != 142855)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (44654 - 339347 != -294692)
			{
				if (num == PlayerData.UID)
				{
					if (185064 - 254140 != -69075)
					{
						this.SetupActors();
						if (287752 - 20315 == 267437)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (63843 - 377064 != -313220)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060073E3 RID: 29667 RVA: 0x00FB8414 File Offset: 0x00FB6614
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (23598 - 526221 != -502622)
		{
		}
		for (;;)
		{
			IL_6A:
			Debug.Log("Creating Actors");
			if (267538 - 551424 != -283885)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (8226 - 315522 != -307295)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (299631 - 487844 != -188212)
						{
							int i = 0;
							if (126189 - 559959 == -433770)
							{
								CharacterControl[] array2 = array;
								if (250709 - 475099 != -224389)
								{
									int length = array2.Length;
									if (118466 - 115629 != 2838)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (215191 - 248251 == -33059)
											{
												goto IL_6A;
											}
											if (type == "Carron")
											{
												goto IL_E7;
											}
											if (29731 - 386314 != -356583)
											{
												goto IL_6A;
											}
											if (type == "FatBug_g")
											{
												goto IL_E7;
											}
											if (234471 - 97542 != 136929)
											{
												goto IL_6A;
											}
											if (type == "LittleFatBug_g")
											{
												goto IL_E7;
											}
											if (182775 - 587130 == -404354)
											{
												goto IL_6A;
											}
											if (type == "LeafBug_r")
											{
												goto IL_E7;
											}
											if (20118 - 125894 == -105775)
											{
												goto IL_6A;
											}
											if (type == "StingBug_g")
											{
												if (189931 - 551517 != -361586)
												{
													goto IL_6A;
												}
												goto IL_E7;
											}
											IL_24:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (115580 - 440334 != -324754)
											{
												goto IL_6A;
											}
											this.SJUcmuONlHt++;
											if (109080 - 131447 != -22367)
											{
												goto IL_6A;
											}
											i++;
											if (185393 - 250976 != -65583)
											{
												goto IL_6A;
											}
											continue;
											IL_E7:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (260892 - 534527 != -273634)
											{
												goto IL_24;
											}
											goto IL_6A;
										}
										if (202863 - 403595 == -200732)
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
						if (219649 - 574892 != -355242)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060073E4 RID: 29668 RVA: 0x00FB8730 File Offset: 0x00FB6930
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (287615 - 551637 != -264021)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (255401 - 206538 == 48863)
			{
				int i = 0;
				if (15979 - 220227 != -204247)
				{
					CharacterControl[] array2 = array;
					if (226716 - 507090 == -280374)
					{
						int length = array2.Length;
						if (149099 - 16671 != 132429)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (130609 - 477614 == -347004)
								{
									goto IL_1A;
								}
								i++;
								if (277299 - 69790 == 207510)
								{
									goto IL_1A;
								}
							}
							if (71579 - 505900 == -434321)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060073E5 RID: 29669 RVA: 0x00FB8860 File Offset: 0x00FB6A60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x060073E6 RID: 29670 RVA: 0x00FB8864 File Offset: 0x00FB6A64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
	}

	// Token: 0x060073E7 RID: 29671 RVA: 0x00FB8868 File Offset: 0x00FB6A68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (134866 - 45925 != 88941)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (225599 - 8055 != 217545)
			{
				hashtable.Add(43, PlayerData.UID);
				if (213432 - 227674 == -14242)
				{
					hashtable.Add(73, nType);
					if (149037 - 453621 != -304583)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (275284 - 589316 == -314032)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (244438 - 292907 != -48468)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (102986 - 123359 != -20372)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (116237 - 131775 == -15538)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (41918 - 458655 != -416736)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (40468 - 96782 != -56313)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (291995 - 371153 != -79157)
												{
													this.ptdcmoplyV9.OpCustom(63, hashtable, true);
													if (146500 - 523051 == -376551)
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

	// Token: 0x060073E8 RID: 29672 RVA: 0x00FB8B20 File Offset: 0x00FB6D20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (55700 - 114963 != -59262)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (6797 - 248878 != -242080)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (27309 - 273744 != -246434)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (265901 - 362406 == -96505)
						{
							if (this.SJUcmuONlHt <= 0)
							{
								break;
							}
							if (298520 - 85784 == 212736)
							{
								this.SJUcmuONlHt--;
								if (127602 - 274059 == -146457)
								{
									if (this.SJUcmuONlHt != 0)
									{
										break;
									}
									if (290186 - 305143 == -14957)
									{
										Game.setGameState(eGameState.Ready);
										if (148266 - 319287 == -171021)
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
						if (160339 - 522655 == -362316)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (288445 - 551671 == -263226)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060073E9 RID: 29673 RVA: 0x00FB8CB0 File Offset: 0x00FB6EB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (239123 - 514794 != -275671)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (167659 - 95139 == 72520)
			{
				Game.mGameState = eGameState.Ready;
				if (46973 - 97653 == -50680)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (284424 - 278923 == 5501)
					{
						GameObject gameObject = null;
						if (164117 - 494309 != -330191)
						{
							GameObject gameObject2 = null;
							if (191461 - 265825 == -74364)
							{
								if (playerSlot > 1)
								{
									if (112459 - 577219 != -464760)
									{
										continue;
									}
									if (playerSlot <= 5)
									{
										if (45943 - 451250 != -405307)
										{
											continue;
										}
										gameObject = GameObject.Find("StartPoint" + playerSlot);
										if (261110 - 219078 == 42033)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartCamera" + playerSlot);
										if (235246 - 348723 != -113477)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									if (3789 - 133186 == -129396)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint1");
									if (162423 - 203750 != -41327)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (10274 - 194702 != -184428)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (85612 - 232743 == -147130)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									if (26918 - 106891 != -79973)
									{
										continue;
									}
									gameObject2 = GameObject.Find("startCamera1");
									if (229509 - 55140 == 174370)
									{
										continue;
									}
								}
								if (!gameObject2)
								{
									break;
								}
								if (219809 - 413540 == -193731)
								{
									this.transform.position = gameObject2.transform.position;
									if (200133 - 300192 == -100059)
									{
										this.transform.rotation = gameObject2.transform.rotation;
										if (11921 - 373042 == -361121)
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

	// Token: 0x060073EA RID: 29674 RVA: 0x00FB8FAC File Offset: 0x00FB71AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M203_StartofALongJourney.$StartGame$37732(this).GetEnumerator();
	}

	// Token: 0x060073EB RID: 29675 RVA: 0x00FB8FBC File Offset: 0x00FB71BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060073EC RID: 29676 RVA: 0x00FB8FC0 File Offset: 0x00FB71C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (194158 - 457280 != -263122)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (242987 - 72898 != 170090)
			{
				hashtable.Add(71, CID);
				if (197870 - 403403 != -205532)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (235912 - 401696 != -165783)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (137949 - 458338 == -320389)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (91123 - 312784 != -221660)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (194477 - 584659 != -390181)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (161529 - 336155 == -174626)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (47242 - 50347 == -3105)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (183795 - 130983 == 52812)
											{
												this.ptdcmoplyV9.OpCustom(61, hashtable, true);
												if (167171 - 391638 == -224467)
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

	// Token: 0x060073ED RID: 29677 RVA: 0x00FB924C File Offset: 0x00FB744C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (208698 - 293855 != -85156)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (73123 - 138504 == -65381)
			{
				if (!gameObject)
				{
					break;
				}
				if (279005 - 597353 != -318347)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (10950 - 176155 != -165204)
					{
						playerCameraControl.target = gameObject;
						if (218622 - 270412 != -51789)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (246359 - 67038 != 179322)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060073EE RID: 29678 RVA: 0x00FB9344 File Offset: 0x00FB7544
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (254311 - 335301 != -80989)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (139440 - 427571 != -288130)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (177556 - 26896 != 150661)
				{
					gameGui.ResetTeamBar();
					if (132134 - 582785 == -450651)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060073EF RID: 29679 RVA: 0x00FB93F0 File Offset: 0x00FB75F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (153103 - 45807 != 107296)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (248159 - 295815 != -47655)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (18361 - 463992 != -445630)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (273972 - 449727 != -175754)
					{
						Hashtable hashtable = new Hashtable();
						if (75423 - 584253 == -508830)
						{
							hashtable.Add(43, PlayerData.UID);
							if (133848 - 488455 != -354606)
							{
								hashtable.Add(71, nCID);
								if (104301 - 354720 != -250418)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (204535 - 596432 != -391896)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (48773 - 475148 == -426375)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (253253 - 10802 == 242451)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (30224 - 78911 != -48686)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (220868 - 565477 == -344609)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (17739 - 283240 == -265501)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (170360 - 310492 == -140132)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (114288 - 28214 != 86075)
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

	// Token: 0x060073F0 RID: 29680 RVA: 0x00FB9710 File Offset: 0x00FB7910
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M203_StartofALongJourney.$onChangePlayer$37736(data, this).GetEnumerator();
	}

	// Token: 0x060073F1 RID: 29681 RVA: 0x00FB9720 File Offset: 0x00FB7920
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M203_StartofALongJourney.$onDeadPlayer$37743(this).GetEnumerator();
	}

	// Token: 0x060073F2 RID: 29682 RVA: 0x00FB9730 File Offset: 0x00FB7930
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (116064 - 569364 != -453300)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (99268 - 230094 == -130826)
			{
				this.KdMcmkQch76.target = Game.mPlayer;
				if (241745 - 128854 == 112891)
				{
					this.KdMcmkQch76.enabled = true;
					if (146544 - 533112 != -386567)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (141682 - 254040 == -112357)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (183814 - 516727 == -332912)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (204467 - 534542 == -330075)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (3154 - 281331 == -278177)
							{
								if (!gameGui)
								{
									break;
								}
								if (228955 - 171482 != 57474)
								{
									gameGui.enabled = true;
									if (245425 - 42740 != 202686)
									{
										gameGui.closeDeadMenu();
										if (14681 - 405659 != -390977)
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

	// Token: 0x060073F3 RID: 29683 RVA: 0x00FB98DC File Offset: 0x00FB7ADC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (180262 - 106921 != 73341)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (208702 - 441003 == -232301)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (233538 - 477110 != -243571)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (121826 - 548812 != -426985)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060073F4 RID: 29684 RVA: 0x00FB99A0 File Offset: 0x00FB7BA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x060073F5 RID: 29685 RVA: 0x00FB99CC File Offset: 0x00FB7BCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M203_StartofALongJourney.$ReturnToTown$37749(this).GetEnumerator();
	}

	// Token: 0x060073F6 RID: 29686 RVA: 0x00FB99DC File Offset: 0x00FB7BDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M203_StartofALongJourney.$ReturnToGuild$37754(this).GetEnumerator();
	}

	// Token: 0x060073F7 RID: 29687 RVA: 0x00FB99EC File Offset: 0x00FB7BEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M203_StartofALongJourney.$ReturnToCamp$37758(this).GetEnumerator();
	}

	// Token: 0x060073F8 RID: 29688 RVA: 0x00FB99FC File Offset: 0x00FB7BFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (103293 - 24939 != 78355)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (176920 - 549324 != -372403)
			{
				Hashtable hashtable = new Hashtable();
				if (128630 - 141473 == -12843)
				{
					hashtable.Add(43, PlayerData.UID);
					if (227077 - 419076 == -191999)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (85502 - 384918 != -299415)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060073F9 RID: 29689 RVA: 0x00FB9AD4 File Offset: 0x00FB7CD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x060073FA RID: 29690 RVA: 0x00FB9AE8 File Offset: 0x00FB7CE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (65286 - 188957 != -123671)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (290217 - 266130 != 24088)
			{
				Hashtable hashtable = new Hashtable();
				if (180026 - 207921 == -27895)
				{
					if (Game.mNextGameCode == 30)
					{
						if (5938 - 242749 == -236810)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (244820 - 220895 != 23925)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (130725 - 563242 != -432517)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (179352 - 362531 == -183178)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (5248 - 593241 != -587993)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (132529 - 376360 == -243830)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (66899 - 571892 != -504993)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (257994 - 188792 != 69202)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (200691 - 173805 != 26886)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (273195 - 184851 == 88345)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (43173 - 484931 == -441757)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (72502 - 381798 == -309295)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (85739 - 315412 == -229672)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (38060 - 132078 == -94017)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (249658 - 89075 == 160584)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (20222 - 338376 != -318154)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (66208 - 85079 != -18871)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (139679 - 423608 == -283928)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (210591 - 186270 != 24321)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (187644 - 430294 == -242649)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (34664 - 154106 == -119441)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (171211 - 99431 == 71781)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (233116 - 363381 == -130264)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (118112 - 477529 != -359417)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (219433 - 337069 == -117635)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (56877 - 272935 != -216058)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (241562 - 428931 == -187368)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (173319 - 182037 == -8717)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (296163 - 220463 == 75700)
					{
						this.ptdcmoplyV9.OpCustom(42, hashtable, true);
						if (213025 - 317662 != -104636)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060073FB RID: 29691 RVA: 0x00FBA09C File Offset: 0x00FB829C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x060073FC RID: 29692 RVA: 0x00FBA0AC File Offset: 0x00FB82AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060073FD RID: 29693 RVA: 0x00FBA0B0 File Offset: 0x00FB82B0
	internal static bool GrZSbPpizZdctHRsmDlj()
	{
		return true;
	}

	// Token: 0x060073FE RID: 29694 RVA: 0x00FBA0B4 File Offset: 0x00FB82B4
	internal static bool ymv4crpKafR8UMjRjMpE()
	{
		return false;
	}

	// Token: 0x04007959 RID: 31065
	private LitePeer ptdcmoplyV9;

	// Token: 0x0400795A RID: 31066
	private PlayerCameraControl KdMcmkQch76;

	// Token: 0x0400795B RID: 31067
	private float MqgcmFjdglm;

	// Token: 0x0400795C RID: 31068
	private Texture NqBcmAaMDqQ;

	// Token: 0x0400795D RID: 31069
	private AudioClip fUHcm9MGEwU;

	// Token: 0x0400795E RID: 31070
	private int XT8cmWNbrCp;

	// Token: 0x0400795F RID: 31071
	private int SJUcmuONlHt;

	// Token: 0x0200139F RID: 5023
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$37714 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060073FF RID: 29695 RVA: 0x00FBA0B8 File Offset: 0x00FB82B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$37714(Hashtable data, M203_StartofALongJourney self_)
		{
			if (97331 - 464330 != -366999)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (112547 - 153821 == -41274)
				{
					base..ctor();
					if (223628 - 328442 != -104813)
					{
						this.$data$37722 = data;
						if (95652 - 182308 == -86656)
						{
							this.$self_$37723 = self_;
							if (275628 - 168316 == 107312)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007400 RID: 29696 RVA: 0x00FBA174 File Offset: 0x00FB8374
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M203_StartofALongJourney.$onGameComplete$37714.$(this.$data$37722, this.$self_$37723);
		}

		// Token: 0x06007401 RID: 29697 RVA: 0x00FBA188 File Offset: 0x00FB8388
		internal static bool RFPlRRpK5suZWlJ7IAZU()
		{
			return true;
		}

		// Token: 0x06007402 RID: 29698 RVA: 0x00FBA18C File Offset: 0x00FB838C
		internal static bool RRwDDspKpqLY3as8DDHB()
		{
			return false;
		}

		// Token: 0x04007960 RID: 31072
		internal Hashtable $data$37722;

		// Token: 0x04007961 RID: 31073
		internal M203_StartofALongJourney $self_$37723;

		// Token: 0x020013A0 RID: 5024
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007403 RID: 29699 RVA: 0x00FBA190 File Offset: 0x00FB8390
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M203_StartofALongJourney self_)
			{
				if (132225 - 446212 != -313986)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (116704 - 440045 != -323340)
					{
						base..ctor();
						if (66681 - 543758 != -477076)
						{
							this.$data$37720 = data;
							if (3777 - 31346 != -27568)
							{
								this.$self_$37721 = self_;
								if (104306 - 338987 == -234681)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007404 RID: 29700 RVA: 0x00FBA24C File Offset: 0x00FB844C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (105388 - 460930 != -355542)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3A0;
					case 2:
						this.$mCompleteGui$37716 = (CompleteGui)this.$self_$37721.GetComponent(typeof(CompleteGui));
						if (30911 - 415553 != -384642)
						{
							continue;
						}
						this.$mCompleteGui$37716.Init();
						if (258885 - 454797 == -195911)
						{
							continue;
						}
						this.$mCompleteGui$37716.readData(this.$data$37720);
						if (47025 - 377973 == -330947)
						{
							continue;
						}
						if (this.$result$37715 == 1)
						{
							if (85705 - 242077 == -156371)
							{
								continue;
							}
							this.$mCompleteGui$37716.displayResult(eCompleteType.Success);
							if (290557 - 401359 != -110802)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$37716.displayResult(eCompleteType.Failed);
							if (104457 - 89858 != 14599)
							{
								continue;
							}
						}
						this.$mGameGui$37717 = (GameGui)this.$self_$37721.GetComponent(typeof(GameGui));
						if (196723 - 543292 == -346568)
						{
							continue;
						}
						this.$mStoryGui$37718 = (StoryGui)this.$self_$37721.GetComponent(typeof(StoryGui));
						if (255189 - 319963 == -64773)
						{
							continue;
						}
						this.$mChangeGui$37719 = (ChangeGui)this.$self_$37721.GetComponent(typeof(ChangeGui));
						if (98703 - 361808 == -263104)
						{
							continue;
						}
						if (this.$mGameGui$37717)
						{
							if (88633 - 485058 == -396424)
							{
								continue;
							}
							this.$mGameGui$37717.close();
							if (143008 - 80437 != 62571)
							{
								continue;
							}
						}
						if (this.$mStoryGui$37718)
						{
							if (264674 - 517880 == -253205)
							{
								continue;
							}
							this.$mStoryGui$37718.close();
							if (233799 - 599969 == -366169)
							{
								continue;
							}
						}
						if (this.$mChangeGui$37719)
						{
							if (218671 - 260371 != -41700)
							{
								continue;
							}
							this.$mChangeGui$37719.disable();
							if (222577 - 479926 == -257348)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (32819 - 501030 != -468210)
						{
							goto Block_8;
						}
						continue;
					default:
						if (7085 - 102883 == -95797)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (211650 - 557357 == -345707)
						{
							break;
						}
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (121969 - 7844 == 114125)
						{
							this.$result$37715 = RuntimeServices.UnboxInt32(this.$data$37720[31]);
							if (183283 - 191757 == -8474)
							{
								goto IL_2F5;
							}
						}
					}
				}
				Block_8:
				goto IL_3A0;
				IL_2F5:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3A0:
				return false;
			}

			// Token: 0x06007405 RID: 29701 RVA: 0x00FBA60C File Offset: 0x00FB880C
			internal static bool ledsNYpKVtQ0e2FfJOSQ()
			{
				return true;
			}

			// Token: 0x06007406 RID: 29702 RVA: 0x00FBA610 File Offset: 0x00FB8810
			internal static bool jQH3MFpKtj9yA0E6eBMl()
			{
				return false;
			}

			// Token: 0x04007962 RID: 31074
			internal int $result$37715;

			// Token: 0x04007963 RID: 31075
			internal CompleteGui $mCompleteGui$37716;

			// Token: 0x04007964 RID: 31076
			internal GameGui $mGameGui$37717;

			// Token: 0x04007965 RID: 31077
			internal StoryGui $mStoryGui$37718;

			// Token: 0x04007966 RID: 31078
			internal ChangeGui $mChangeGui$37719;

			// Token: 0x04007967 RID: 31079
			internal Hashtable $data$37720;

			// Token: 0x04007968 RID: 31080
			internal M203_StartofALongJourney $self_$37721;
		}
	}

	// Token: 0x020013A1 RID: 5025
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToRedPanda$37724 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007407 RID: 29703 RVA: 0x00FBA614 File Offset: 0x00FB8814
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToRedPanda$37724(M203_StartofALongJourney self_)
		{
			if (228905 - 419286 != -190380)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (126519 - 3759 == 122760)
				{
					base..ctor();
					if (97379 - 330478 == -233099)
					{
						this.$self_$37731 = self_;
						if (88168 - 522705 != -434536)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007408 RID: 29704 RVA: 0x00FBA6AC File Offset: 0x00FB88AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M203_StartofALongJourney.$TalkToRedPanda$37724.$(this.$self_$37731);
		}

		// Token: 0x06007409 RID: 29705 RVA: 0x00FBA6BC File Offset: 0x00FB88BC
		internal static bool UNYZripKNy8h8sElWa7x()
		{
			return true;
		}

		// Token: 0x0600740A RID: 29706 RVA: 0x00FBA6C0 File Offset: 0x00FB88C0
		internal static bool lVIcVppKYP1ggaxPFti1()
		{
			return false;
		}

		// Token: 0x04007969 RID: 31081
		internal M203_StartofALongJourney $self_$37731;

		// Token: 0x020013A2 RID: 5026
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600740B RID: 29707 RVA: 0x00FBA6C4 File Offset: 0x00FB88C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M203_StartofALongJourney self_)
			{
				if (139138 - 309608 != -170470)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (280846 - 154729 != 126118)
					{
						base..ctor();
						if (297837 - 108166 != 189672)
						{
							this.$self_$37730 = self_;
							if (83806 - 311930 != -228123)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600740C RID: 29708 RVA: 0x00FBA75C File Offset: 0x00FB895C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (188715 - 525131 != -336416)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_38D;
					case 2:
						this.$mStoryGui$37729.newStoryMessage("none", "RedPanda", Language.getMessage("M203_StartofALongJourney", 2031), eTalkType.friend);
						if (142442 - 372980 != -230537)
						{
							goto Block_10;
						}
						continue;
					case 3:
						this.$mStoryGui$37729.close();
						if (73397 - 75706 != -2309)
						{
							continue;
						}
						this.$mGameGui$37728.enabled = true;
						if (198366 - 356719 != -158353)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (131927 - 577596 != -445669)
						{
							continue;
						}
						this.YieldDefault(1);
						if (46796 - 471758 != -424962)
						{
							continue;
						}
						goto IL_38D;
					default:
						if (95194 - 442996 != -347802)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (150156 - 28798 != 121359)
						{
							break;
						}
					}
					else
					{
						this.$mPlayer$37725 = Game.mPlayer;
						if (139319 - 539164 == -399845)
						{
							this.$mRedPanda$37726 = GameObject.Find("RedPanda");
							if (190645 - 451947 == -261302)
							{
								this.$mRedPandaOriginalDir$37727 = default(Vector3);
								if (113637 - 440471 != -326833)
								{
									if (this.$mRedPanda$37726)
									{
										if (54915 - 331840 != -276925)
										{
											continue;
										}
										if (this.$mPlayer$37725)
										{
											if (182621 - 203722 == -21100)
											{
												continue;
											}
											this.$mPlayer$37725.SendMessage("turnToPos", this.$mRedPanda$37726.transform.position);
											if (20638 - 137983 == -117344)
											{
												continue;
											}
										}
									}
									Game.mGameState = eGameState.Hold;
									if (222105 - 170344 != 51762)
									{
										this.$mGameGui$37728 = (GameGui)this.$self_$37730.GetComponent(typeof(GameGui));
										if (24267 - 348669 == -324402)
										{
											if (this.$mGameGui$37728)
											{
												if (213713 - 27901 != 185812)
												{
													continue;
												}
												this.$mGameGui$37728.close();
												if (291302 - 442229 != -150927)
												{
													continue;
												}
											}
											this.$mStoryGui$37729 = (StoryGui)this.$self_$37730.GetComponent(typeof(StoryGui));
											if (94623 - 126622 == -31999)
											{
												this.$mStoryGui$37729.startStoryMessage("none", "RedPanda", eTalkType.friend);
												if (215525 - 38990 == 176535)
												{
													goto IL_172;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_38D;
				IL_172:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_10:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_38D:
				return false;
			}

			// Token: 0x0600740D RID: 29709 RVA: 0x00FBAB08 File Offset: 0x00FB8D08
			internal static bool lwTeoOpKcOYfTeuQcw50()
			{
				return true;
			}

			// Token: 0x0600740E RID: 29710 RVA: 0x00FBAB0C File Offset: 0x00FB8D0C
			internal static bool qM2xjHpKUDbw0Z68m28w()
			{
				return false;
			}

			// Token: 0x0400796A RID: 31082
			internal GameObject $mPlayer$37725;

			// Token: 0x0400796B RID: 31083
			internal GameObject $mRedPanda$37726;

			// Token: 0x0400796C RID: 31084
			internal Vector3 $mRedPandaOriginalDir$37727;

			// Token: 0x0400796D RID: 31085
			internal GameGui $mGameGui$37728;

			// Token: 0x0400796E RID: 31086
			internal StoryGui $mStoryGui$37729;

			// Token: 0x0400796F RID: 31087
			internal M203_StartofALongJourney $self_$37730;
		}
	}

	// Token: 0x020013A3 RID: 5027
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$37732 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600740F RID: 29711 RVA: 0x00FBAB10 File Offset: 0x00FB8D10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$37732(M203_StartofALongJourney self_)
		{
			if (137727 - 316831 != -179104)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (205200 - 534075 != -328874)
				{
					base..ctor();
					if (243624 - 424138 != -180513)
					{
						this.$self_$37735 = self_;
						if (262059 - 126319 == 135740)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007410 RID: 29712 RVA: 0x00FBABA8 File Offset: 0x00FB8DA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M203_StartofALongJourney.$StartGame$37732.$(this.$self_$37735);
		}

		// Token: 0x06007411 RID: 29713 RVA: 0x00FBABB8 File Offset: 0x00FB8DB8
		internal static bool kuaF5ApKTsU29NgL1dj0()
		{
			return true;
		}

		// Token: 0x06007412 RID: 29714 RVA: 0x00FBABBC File Offset: 0x00FB8DBC
		internal static bool hbDL6VpK3W0uqqgjQLvR()
		{
			return false;
		}

		// Token: 0x04007970 RID: 31088
		internal M203_StartofALongJourney $self_$37735;

		// Token: 0x020013A4 RID: 5028
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007413 RID: 29715 RVA: 0x00FBABC0 File Offset: 0x00FB8DC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M203_StartofALongJourney self_)
			{
				if (26135 - 298958 != -272823)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (150131 - 591234 == -441103)
					{
						base..ctor();
						if (88637 - 104263 == -15626)
						{
							this.$self_$37734 = self_;
							if (255922 - 321499 == -65577)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007414 RID: 29716 RVA: 0x00FBAC58 File Offset: 0x00FB8E58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (229211 - 66679 != 162532)
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
						this.$mGameGui$37733 = (GameGui)this.$self_$37734.GetComponent(typeof(GameGui));
						if (193373 - 60356 == 133018)
						{
							continue;
						}
						this.$mGameGui$37733.enabled = true;
						if (81075 - 584641 == -503565)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (199493 - 356216 != -156723)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (69937 - 263097 != -193160)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (111847 - 48402 == 63446)
						{
							continue;
						}
						if (this.$self_$37734.fUHcm9MGEwU)
						{
							if (4162 - 504839 == -500676)
							{
								continue;
							}
							this.$self_$37734.audio.PlayOneShot(this.$self_$37734.fUHcm9MGEwU);
							if (156439 - 558899 != -402460)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (280762 - 367916 != -87153)
						{
							goto Block_9;
						}
						continue;
					default:
						if (104849 - 87200 != 17649)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (84624 - 506196 == -421572)
					{
						Game.mGameState = eGameState.Start;
						if (205684 - 195303 != 10382)
						{
							Game.mStateTime = Time.time;
							if (234032 - 176589 != 57444)
							{
								this.$self_$37734.SendMessage("fadeIn");
								if (170826 - 590905 == -420079)
								{
									goto IL_1F1;
								}
							}
						}
					}
				}
				Block_9:
				goto IL_241;
				IL_1F1:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_241:
				return false;
			}

			// Token: 0x06007415 RID: 29717 RVA: 0x00FBAEB8 File Offset: 0x00FB90B8
			internal static bool vjYMBUpKXb5wyZwPkMBP()
			{
				return true;
			}

			// Token: 0x06007416 RID: 29718 RVA: 0x00FBAEBC File Offset: 0x00FB90BC
			internal static bool VORNKmpKQTaKUgZVtNwE()
			{
				return false;
			}

			// Token: 0x04007971 RID: 31089
			internal GameGui $mGameGui$37733;

			// Token: 0x04007972 RID: 31090
			internal M203_StartofALongJourney $self_$37734;
		}
	}

	// Token: 0x020013A5 RID: 5029
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$37736 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007417 RID: 29719 RVA: 0x00FBAEC0 File Offset: 0x00FB90C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$37736(Hashtable data, M203_StartofALongJourney self_)
		{
			if (165648 - 286349 != -120701)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (215564 - 544442 != -328877)
				{
					base..ctor();
					if (129183 - 184789 == -55606)
					{
						this.$data$37741 = data;
						if (176951 - 68116 == 108835)
						{
							this.$self_$37742 = self_;
							if (48338 - 154984 == -106646)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007418 RID: 29720 RVA: 0x00FBAF7C File Offset: 0x00FB917C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M203_StartofALongJourney.$onChangePlayer$37736.$(this.$data$37741, this.$self_$37742);
		}

		// Token: 0x06007419 RID: 29721 RVA: 0x00FBAF90 File Offset: 0x00FB9190
		internal static bool nE0be9pKk4lEM7urGKFk()
		{
			return true;
		}

		// Token: 0x0600741A RID: 29722 RVA: 0x00FBAF94 File Offset: 0x00FB9194
		internal static bool pImSytpKGS8ENhT66Hlm()
		{
			return false;
		}

		// Token: 0x04007973 RID: 31091
		internal Hashtable $data$37741;

		// Token: 0x04007974 RID: 31092
		internal M203_StartofALongJourney $self_$37742;

		// Token: 0x020013A6 RID: 5030
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600741B RID: 29723 RVA: 0x00FBAF98 File Offset: 0x00FB9198
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M203_StartofALongJourney self_)
			{
				if (127971 - 90090 != 37882)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (284943 - 5173 == 279770)
					{
						base..ctor();
						if (73611 - 590262 == -516651)
						{
							this.$data$37739 = data;
							if (23546 - 411458 != -387911)
							{
								this.$self_$37740 = self_;
								if (147764 - 502182 == -354418)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600741C RID: 29724 RVA: 0x00FBB054 File Offset: 0x00FB9254
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (178451 - 550542 != -372091)
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
							if (47000 - 330988 != -283988)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (145602 - 335982 != -190380)
							{
								continue;
							}
							this.$mGameGui$37738 = (GameGui)this.$self_$37740.GetComponent(typeof(GameGui));
							if (98735 - 492563 != -393828)
							{
								continue;
							}
							this.$mGameGui$37738.enabled = true;
							if (142707 - 89012 != 53695)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (188104 - 559246 != -371142)
						{
							continue;
						}
						goto IL_205;
					default:
						if (85642 - 550221 != -464579)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (299420 - 41686 != 257735)
					{
						this.$self_$37740.SendMessage("onCreatePlayer", this.$data$37739);
						if (97159 - 390118 == -292959)
						{
							this.$mChangeGui$37737 = (ChangeGui)this.$self_$37740.GetComponent(typeof(ChangeGui));
							if (294437 - 559236 == -264799)
							{
								if (!this.$mChangeGui$37737.enabled)
								{
									break;
								}
								if (180667 - 241225 == -60558)
								{
									this.$mChangeGui$37737.close();
									if (12991 - 480322 != -467330)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_60:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_60;
				IL_205:
				return false;
			}

			// Token: 0x0600741D RID: 29725 RVA: 0x00FBB278 File Offset: 0x00FB9478
			internal static bool VBNYTWpKHhH8DFiCjTS0()
			{
				return true;
			}

			// Token: 0x0600741E RID: 29726 RVA: 0x00FBB27C File Offset: 0x00FB947C
			internal static bool CED4H2pKWJ5VM87lVApG()
			{
				return false;
			}

			// Token: 0x04007975 RID: 31093
			internal ChangeGui $mChangeGui$37737;

			// Token: 0x04007976 RID: 31094
			internal GameGui $mGameGui$37738;

			// Token: 0x04007977 RID: 31095
			internal Hashtable $data$37739;

			// Token: 0x04007978 RID: 31096
			internal M203_StartofALongJourney $self_$37740;
		}
	}

	// Token: 0x020013A7 RID: 5031
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$37743 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600741F RID: 29727 RVA: 0x00FBB280 File Offset: 0x00FB9480
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$37743(M203_StartofALongJourney self_)
		{
			if (172340 - 329774 != -157433)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (293098 - 551252 == -258154)
				{
					base..ctor();
					if (214104 - 408826 == -194722)
					{
						this.$self_$37748 = self_;
						if (228948 - 549102 == -320154)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007420 RID: 29728 RVA: 0x00FBB318 File Offset: 0x00FB9518
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M203_StartofALongJourney.$onDeadPlayer$37743.$(this.$self_$37748);
		}

		// Token: 0x06007421 RID: 29729 RVA: 0x00FBB328 File Offset: 0x00FB9528
		internal static bool SW26oHpKAeRDGJPv6XBU()
		{
			return true;
		}

		// Token: 0x06007422 RID: 29730 RVA: 0x00FBB32C File Offset: 0x00FB952C
		internal static bool CL8HnmpKl2UKnOHv7BCc()
		{
			return false;
		}

		// Token: 0x04007979 RID: 31097
		internal M203_StartofALongJourney $self_$37748;

		// Token: 0x020013A8 RID: 5032
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007423 RID: 29731 RVA: 0x00FBB330 File Offset: 0x00FB9530
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M203_StartofALongJourney self_)
			{
				if (78005 - 112803 != -34798)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (153947 - 161158 != -7210)
					{
						base..ctor();
						if (219470 - 478015 != -258544)
						{
							this.$self_$37747 = self_;
							if (94761 - 398703 == -303942)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007424 RID: 29732 RVA: 0x00FBB3C8 File Offset: 0x00FB95C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (224738 - 282026 != -57288)
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
							goto IL_19B;
						}
						if (86513 - 36833 == 49681)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (43693 - 572326 != -528633)
							{
								continue;
							}
							goto IL_19B;
						}
						IL_1A:
						this.YieldDefault(1);
						if (171313 - 486139 != -314826)
						{
							continue;
						}
						goto IL_2F9;
						IL_19B:
						Game.mGameState = eGameState.Hold;
						if (108747 - 116800 == -8052)
						{
							continue;
						}
						this.$mStoryGui$37744 = (StoryGui)this.$self_$37747.GetComponent(typeof(StoryGui));
						if (279059 - 492448 == -213388)
						{
							continue;
						}
						if (this.$mStoryGui$37744)
						{
							if (222547 - 208009 == 14539)
							{
								continue;
							}
							this.$mStoryGui$37744.close();
							if (250453 - 102792 == 147662)
							{
								continue;
							}
						}
						this.$mChangeGui$37745 = (ChangeGui)this.$self_$37747.GetComponent(typeof(ChangeGui));
						if (17659 - 58200 == -40540)
						{
							continue;
						}
						if (this.$mChangeGui$37745)
						{
							if (237830 - 176682 != 61148)
							{
								continue;
							}
							this.$mChangeGui$37745.close();
							if (171786 - 484569 != -312783)
							{
								continue;
							}
						}
						this.$mGameGui$37746 = (GameGui)this.$self_$37747.GetComponent(typeof(GameGui));
						if (222240 - 347265 != -125025)
						{
							continue;
						}
						if (!this.$mGameGui$37746)
						{
							goto IL_1A;
						}
						if (101086 - 458466 != -357380)
						{
							continue;
						}
						if (!this.$mGameGui$37746.enabled)
						{
							if (177806 - 501169 == -323362)
							{
								continue;
							}
							this.$mGameGui$37746.enabled = true;
							if (249878 - 338487 != -88609)
							{
								continue;
							}
						}
						this.$mGameGui$37746.openDeadMenu();
						if (10595 - 27002 != -16407)
						{
							continue;
						}
						goto IL_1A;
					default:
						if (293478 - 269745 == 23734)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (49720 - 401977 != -352257);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06007425 RID: 29733 RVA: 0x00FBB6E0 File Offset: 0x00FB98E0
			internal static bool EDg1P3pKyEX4pHr8gpbG()
			{
				return true;
			}

			// Token: 0x06007426 RID: 29734 RVA: 0x00FBB6E4 File Offset: 0x00FB98E4
			internal static bool VUSZSopKS10I5x9xApje()
			{
				return false;
			}

			// Token: 0x0400797A RID: 31098
			internal StoryGui $mStoryGui$37744;

			// Token: 0x0400797B RID: 31099
			internal ChangeGui $mChangeGui$37745;

			// Token: 0x0400797C RID: 31100
			internal GameGui $mGameGui$37746;

			// Token: 0x0400797D RID: 31101
			internal M203_StartofALongJourney $self_$37747;
		}
	}

	// Token: 0x020013A9 RID: 5033
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$37749 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007427 RID: 29735 RVA: 0x00FBB6E8 File Offset: 0x00FB98E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$37749(M203_StartofALongJourney self_)
		{
			if (41517 - 199374 != -157857)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (2899 - 179115 != -176215)
				{
					base..ctor();
					if (281217 - 93225 == 187992)
					{
						this.$self_$37753 = self_;
						if (257747 - 568405 != -310657)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007428 RID: 29736 RVA: 0x00FBB780 File Offset: 0x00FB9980
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M203_StartofALongJourney.$ReturnToTown$37749.$(this.$self_$37753);
		}

		// Token: 0x06007429 RID: 29737 RVA: 0x00FBB790 File Offset: 0x00FB9990
		internal static bool UxiWEhpKoZs09iuyAWTI()
		{
			return true;
		}

		// Token: 0x0600742A RID: 29738 RVA: 0x00FBB794 File Offset: 0x00FB9994
		internal static bool slBvvIpKEWcTZiLvL03p()
		{
			return false;
		}

		// Token: 0x0400797E RID: 31102
		internal M203_StartofALongJourney $self_$37753;

		// Token: 0x020013AA RID: 5034
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600742B RID: 29739 RVA: 0x00FBB798 File Offset: 0x00FB9998
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M203_StartofALongJourney self_)
			{
				if (127786 - 379609 != -251822)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (126022 - 220254 == -94232)
					{
						base..ctor();
						if (95249 - 272967 != -177717)
						{
							this.$self_$37752 = self_;
							if (199285 - 466699 == -267414)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600742C RID: 29740 RVA: 0x00FBB830 File Offset: 0x00FB9A30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (199506 - 511834 != -312328)
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
						this.$self_$37752.LeaveGame();
						if (232615 - 513509 != -280894)
						{
							continue;
						}
						this.YieldDefault(1);
						if (225938 - 589802 != -363864)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (233704 - 363611 != -129907)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (240192 - 239115 != 1078)
					{
						Game.mStateTime = Time.time;
						if (61318 - 185049 == -123731)
						{
							this.$$switch$6444$37750 = PlayerData.SaveGuild;
							if (189153 - 37047 != 152107)
							{
								if (this.$$switch$6444$37750 == 1)
								{
									if (187798 - 169151 != 18647)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (65860 - 340015 == -274154)
									{
										continue;
									}
								}
								else if (this.$$switch$6444$37750 == 2)
								{
									if (204830 - 29656 != 175174)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (65229 - 503868 == -438638)
									{
										continue;
									}
								}
								else if (this.$$switch$6444$37750 == 3)
								{
									if (3947 - 283498 != -279551)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (152579 - 271038 == -118458)
									{
										continue;
									}
								}
								else if (this.$$switch$6444$37750 == 4)
								{
									if (212591 - 400801 != -188210)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (120873 - 357762 != -236889)
									{
										continue;
									}
								}
								else if (this.$$switch$6444$37750 == 5)
								{
									if (43432 - 251286 == -207853)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (138866 - 496382 != -357516)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (293627 - 270466 == 23162)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (175888 - 43307 != 132581)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (204876 - 307254 == -102377)
									{
										continue;
									}
								}
								this.$mGameGui$37751 = (GameGui)this.$self_$37752.GetComponent(typeof(GameGui));
								if (169332 - 376232 != -206899)
								{
									if (this.$mGameGui$37751)
									{
										if (234951 - 375368 != -140417)
										{
											continue;
										}
										this.$mGameGui$37751.close();
										if (174167 - 405368 == -231200)
										{
											continue;
										}
									}
									this.$self_$37752.SendMessage("fadeOut");
									if (274799 - 312795 != -37995)
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

			// Token: 0x0600742D RID: 29741 RVA: 0x00FBBBFC File Offset: 0x00FB9DFC
			internal static bool Cls3jkpK2H1a1DKX4tqc()
			{
				return true;
			}

			// Token: 0x0600742E RID: 29742 RVA: 0x00FBBC00 File Offset: 0x00FB9E00
			internal static bool fiIq16pK89j2nO0y4Wnt()
			{
				return false;
			}

			// Token: 0x0400797F RID: 31103
			internal int $$switch$6444$37750;

			// Token: 0x04007980 RID: 31104
			internal GameGui $mGameGui$37751;

			// Token: 0x04007981 RID: 31105
			internal M203_StartofALongJourney $self_$37752;
		}
	}

	// Token: 0x020013AB RID: 5035
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$37754 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600742F RID: 29743 RVA: 0x00FBBC04 File Offset: 0x00FB9E04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$37754(M203_StartofALongJourney self_)
		{
			if (245422 - 516042 != -270620)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (76203 - 590618 == -514415)
				{
					base..ctor();
					if (25612 - 232491 != -206878)
					{
						this.$self_$37757 = self_;
						if (35009 - 491063 != -456053)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007430 RID: 29744 RVA: 0x00FBBC9C File Offset: 0x00FB9E9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M203_StartofALongJourney.$ReturnToGuild$37754.$(this.$self_$37757);
		}

		// Token: 0x06007431 RID: 29745 RVA: 0x00FBBCAC File Offset: 0x00FB9EAC
		internal static bool Bxt6V2pKZQqc1rFo4YUW()
		{
			return true;
		}

		// Token: 0x06007432 RID: 29746 RVA: 0x00FBBCB0 File Offset: 0x00FB9EB0
		internal static bool Cw7heLpKCvYn6khpKIIS()
		{
			return false;
		}

		// Token: 0x04007982 RID: 31106
		internal M203_StartofALongJourney $self_$37757;

		// Token: 0x020013AC RID: 5036
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007433 RID: 29747 RVA: 0x00FBBCB4 File Offset: 0x00FB9EB4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M203_StartofALongJourney self_)
			{
				if (154566 - 331626 != -177059)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (143196 - 500616 != -357419)
					{
						base..ctor();
						if (162909 - 298784 == -135875)
						{
							this.$self_$37756 = self_;
							if (168342 - 86839 != 81504)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007434 RID: 29748 RVA: 0x00FBBD4C File Offset: 0x00FB9F4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (57627 - 289888 != -232261)
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
						this.$self_$37756.LeaveGame();
						if (145314 - 82599 == 62716)
						{
							continue;
						}
						this.YieldDefault(1);
						if (208753 - 476671 != -267918)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (244233 - 321493 == -77259)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (70328 - 378922 == -308594)
					{
						Game.mStateTime = Time.time;
						if (22521 - 119180 != -96658)
						{
							Game.mNextGameCode = 31;
							if (57406 - 366485 == -309079)
							{
								this.$mGameGui$37755 = (GameGui)this.$self_$37756.GetComponent(typeof(GameGui));
								if (160942 - 215933 != -54990)
								{
									if (this.$mGameGui$37755)
									{
										if (35886 - 85639 == -49752)
										{
											continue;
										}
										this.$mGameGui$37755.close();
										if (262014 - 139479 == 122536)
										{
											continue;
										}
									}
									this.$self_$37756.SendMessage("fadeOut");
									if (5326 - 275560 != -270233)
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

			// Token: 0x06007435 RID: 29749 RVA: 0x00FBBF28 File Offset: 0x00FBA128
			internal static bool mFoYAbpKLFv0GRaoLBfu()
			{
				return true;
			}

			// Token: 0x06007436 RID: 29750 RVA: 0x00FBBF2C File Offset: 0x00FBA12C
			internal static bool u8PiBHpKO28AJ7alJxJb()
			{
				return false;
			}

			// Token: 0x04007983 RID: 31107
			internal GameGui $mGameGui$37755;

			// Token: 0x04007984 RID: 31108
			internal M203_StartofALongJourney $self_$37756;
		}
	}

	// Token: 0x020013AD RID: 5037
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$37758 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007437 RID: 29751 RVA: 0x00FBBF30 File Offset: 0x00FBA130
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$37758(M203_StartofALongJourney self_)
		{
			if (207843 - 42617 != 165226)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (251356 - 315748 == -64392)
				{
					base..ctor();
					if (85679 - 269179 == -183500)
					{
						this.$self_$37762 = self_;
						if (151014 - 78048 != 72967)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007438 RID: 29752 RVA: 0x00FBBFC8 File Offset: 0x00FBA1C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M203_StartofALongJourney.$ReturnToCamp$37758.$(this.$self_$37762);
		}

		// Token: 0x06007439 RID: 29753 RVA: 0x00FBBFD8 File Offset: 0x00FBA1D8
		internal static bool AcjphOpKmgcJVJ59pGi7()
		{
			return true;
		}

		// Token: 0x0600743A RID: 29754 RVA: 0x00FBBFDC File Offset: 0x00FBA1DC
		internal static bool kFGm9UpKFJVKm28BgoVF()
		{
			return false;
		}

		// Token: 0x04007985 RID: 31109
		internal M203_StartofALongJourney $self_$37762;

		// Token: 0x020013AE RID: 5038
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600743B RID: 29755 RVA: 0x00FBBFE0 File Offset: 0x00FBA1E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M203_StartofALongJourney self_)
			{
				if (69547 - 364556 != -295009)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (164376 - 264903 != -100526)
					{
						base..ctor();
						if (216284 - 42086 == 174198)
						{
							this.$self_$37761 = self_;
							if (66800 - 2915 != 63886)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600743C RID: 29756 RVA: 0x00FBC078 File Offset: 0x00FBA278
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (148541 - 251805 != -103263)
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
						this.$self_$37761.LeaveGame();
						if (185624 - 313082 != -127458)
						{
							continue;
						}
						this.YieldDefault(1);
						if (269281 - 177360 != 91921)
						{
							continue;
						}
						goto IL_363;
					default:
						if (93128 - 136800 == -43671)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (11693 - 316283 != -304589)
					{
						Game.mStateTime = Time.time;
						if (24069 - 470904 != -446834)
						{
							this.$$switch$6446$37759 = PlayerData.SaveGuild;
							if (52665 - 246922 == -194257)
							{
								if (this.$$switch$6446$37759 == 1)
								{
									if (96623 - 581928 != -485305)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (39684 - 561936 == -522251)
									{
										continue;
									}
								}
								else if (this.$$switch$6446$37759 == 2)
								{
									if (178751 - 190343 == -11591)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (296284 - 80695 != 215589)
									{
										continue;
									}
								}
								else if (this.$$switch$6446$37759 == 3)
								{
									if (89793 - 46477 != 43316)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (37405 - 410502 == -373096)
									{
										continue;
									}
								}
								else if (this.$$switch$6446$37759 == 4)
								{
									if (174374 - 490844 == -316469)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (93943 - 378851 == -284907)
									{
										continue;
									}
								}
								else if (this.$$switch$6446$37759 == 5)
								{
									if (139874 - 274533 == -134658)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (68195 - 407755 != -339560)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (128368 - 511270 != -382902)
									{
										continue;
									}
								}
								this.$mGameGui$37760 = (GameGui)this.$self_$37761.GetComponent(typeof(GameGui));
								if (151287 - 432129 == -280842)
								{
									if (this.$mGameGui$37760)
									{
										if (4993 - 182611 == -177617)
										{
											continue;
										}
										this.$mGameGui$37760.close();
										if (23657 - 14564 != 9093)
										{
											continue;
										}
									}
									this.$self_$37761.SendMessage("fadeOut");
									if (291048 - 257530 != 33519)
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

			// Token: 0x0600743D RID: 29757 RVA: 0x00FBC3FC File Offset: 0x00FBA5FC
			internal static bool t7nNQXpKMQ9iDuGcHAPH()
			{
				return true;
			}

			// Token: 0x0600743E RID: 29758 RVA: 0x00FBC400 File Offset: 0x00FBA600
			internal static bool IoDC19pKxlyB5F1D4Pmc()
			{
				return false;
			}

			// Token: 0x04007986 RID: 31110
			internal int $$switch$6446$37759;

			// Token: 0x04007987 RID: 31111
			internal GameGui $mGameGui$37760;

			// Token: 0x04007988 RID: 31112
			internal M203_StartofALongJourney $self_$37761;
		}
	}
}
