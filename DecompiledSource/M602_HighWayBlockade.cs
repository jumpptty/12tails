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

// Token: 0x02001638 RID: 5688
[Serializable]
public class M602_HighWayBlockade : MonoBehaviour
{
	// Token: 0x060083FF RID: 33791 RVA: 0x0109EC14 File Offset: 0x0109CE14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M602_HighWayBlockade()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06008400 RID: 33792 RVA: 0x0109EC24 File Offset: 0x0109CE24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (103278 - 414638 != -311360)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (226782 - 347173 == -120391)
			{
				Game.mGameType = 5;
				if (287205 - 72260 != 214946)
				{
					if (Chat.Initialized)
					{
						if (263423 - 417975 != -154552)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (29737 - 422904 == -393166)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (283958 - 548038 != -264080)
						{
							continue;
						}
					}
					this.my2cW7DUA5P = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (145478 - 568480 == -423002)
					{
						this.h3PcWZPk23L = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (297847 - 380062 == -82215)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008401 RID: 33793 RVA: 0x0109ED7C File Offset: 0x0109CF7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (261057 - 135567 != 125491)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (261293 - 92827 != 168467)
				{
					if (Game.mNextGameCode != 602)
					{
						break;
					}
					if (262300 - 458768 == -196468)
					{
						Game.nextGame();
						if (281698 - 331131 != -49432)
						{
							Game.mGameCode = 602;
							if (227209 - 149635 == 77574)
							{
								Game.mGameType = 5;
								if (57450 - 534503 == -477053)
								{
									Game.mGameTime = Time.time;
									if (166449 - 330571 != -164121)
									{
										Game.mGameScore = 0;
										if (234678 - 25528 != 209151)
										{
											Game.mGameMana = 0;
											if (55395 - 572035 == -516640)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (177770 - 345078 == -167308)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (153415 - 300762 == -147347)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (147745 - 404639 == -256894)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (257187 - 149759 == 107428)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (221239 - 516200 == -294961)
																{
																	this.eCvcWsUX2yt = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (206951 - 207492 == -541)
																	{
																		this.vuScW4n4Bk9 = PhotonClient.Connection;
																		if (286156 - 329579 != -43422)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (53481 - 392540 == -339059)
																			{
																				this.InitGame();
																				if (203152 - 357569 == -154417)
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
				if (60888 - 162390 == -101502)
				{
					Game.mGameType = 99;
					if (203798 - 122168 != 81631)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008402 RID: 33794 RVA: 0x0109F084 File Offset: 0x0109D284
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (79834 - 503522 != -423688)
		{
		}
		for (;;)
		{
			if (this.vuScW4n4Bk9 == null)
			{
				if (269058 - 376745 == -107687)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (116964 - 156354 == -39390)
				{
					if (mGameState == eGameState.Init)
					{
						if (79042 - 211031 != -131988)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (222479 - 242639 == -20160)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (179268 - 558365 != -379096)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (39332 - 277029 == -237697)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (177938 - 125861 != 52078)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (164734 - 378027 == -213293)
						{
							if (Time.time > this.av6cWHAeGno)
							{
								if (106927 - 157127 == -50199)
								{
									continue;
								}
								Game.mGameMana++;
								if (274121 - 165412 != 108709)
								{
									continue;
								}
								this.av6cWHAeGno = Time.time + (float)12;
								if (220572 - 5053 == 215520)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (259940 - 392978 != -133038)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (243536 - 351169 != -107633)
									{
										continue;
									}
									this.audio.Play();
									if (53588 - 244418 == -190829)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (24196 - 555380 != -531183)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (113260 - 210390 == -97130)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (112636 - 114585 != -1948)
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
						if (114493 - 562061 != -447567)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008403 RID: 33795 RVA: 0x0109F384 File Offset: 0x0109D584
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (135705 - 584938 != -449233)
		{
		}
		for (;;)
		{
			if (!this.my2cW7DUA5P)
			{
				if (217420 - 383326 != -165905)
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
				if (21446 - 548821 == -527375)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (6370 - 298846 != -292475)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (206954 - 471167 == -264213)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (285310 - 331357 == -46047)
							{
								GUI.depth = 1;
								if (160348 - 458982 != -298633)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (65150 - 63650 != 1501)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (94515 - 386914 != -292398)
										{
											Color color = GUI.color;
											if (127793 - 9641 == 118152)
											{
												color.a = a;
												if (216625 - 421089 != -204463 && 47798 - 162600 != -114801)
												{
													GUI.color = color;
													if (39456 - 164483 == -125027)
													{
														if (178488 - 530578 != -352089)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.my2cW7DUA5P);
															if (57388 - 496843 == -439455)
															{
																float a2 = 1f;
																if (134729 - 316966 != -182236)
																{
																	Color color2 = GUI.color;
																	if (80053 - 580070 == -500017)
																	{
																		color2.a = a2;
																		if (266865 - 510686 == -243821)
																		{
																			if (40834 - 29893 == 10941)
																			{
																				Color color3 = GUI.color = color2;
																				if (270783 - 550 == 270233)
																				{
																					if (156116 - 560507 != -404390)
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

	// Token: 0x06008404 RID: 33796 RVA: 0x0109F704 File Offset: 0x0109D904
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (172124 - 216448 != -44324)
		{
		}
		for (;;)
		{
			IL_956:
			if (Game.mGameState > eGameState.AllHold)
			{
				if (214905 - 107978 == 106927)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (179406 - 133364 == 46042)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (81494 - 232653 == -151159)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (260881 - 481695 != -220813)
						{
							if (11684 - 87913 == -76229)
							{
								Vector3 vector = default(Vector3);
								if (271770 - 98934 == 172836)
								{
									int num4 = num;
									if (149437 - 487921 != -338483)
									{
										if (num4 == 6021)
										{
											if (217429 - 561242 != -343812)
											{
												this.V2kcWMXgcCE++;
												if (180829 - 265160 != -84330)
												{
													if (PlayerData.UID != num3)
													{
														break;
													}
													if (80140 - 394497 != -314356)
													{
														if (this.V2kcWMXgcCE % 2 == 0)
														{
															if (253175 - 309665 != -56490)
															{
																continue;
															}
															if (this.V2kcWMXgcCE <= 10)
															{
																if (27216 - 360353 != -333137)
																{
																	continue;
																}
																int i = 0;
																if (142675 - 388704 != -246029)
																{
																	continue;
																}
																while (i < 2)
																{
																	GameObject gameObject = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(1, 7));
																	if (245003 - 205272 == 39732)
																	{
																		goto IL_956;
																	}
																	if (gameObject)
																	{
																		if (225220 - 366918 == -141697)
																		{
																			goto IL_956;
																		}
																		vector = global::Math.getRandomSpawnPos(gameObject.transform.position, 6);
																		if (289551 - 428082 == -138530)
																		{
																			goto IL_956;
																		}
																		if (vector != Vector3.zero)
																		{
																			if (34407 - 154274 == -119866)
																			{
																				goto IL_956;
																			}
																			this.createActor("Panther_d", 8, vector, gameObject.transform.forward);
																			if (161442 - 263087 != -101645)
																			{
																				goto IL_956;
																			}
																		}
																		else
																		{
																			this.createActor("Panther_d", 8, gameObject.transform.position, gameObject.transform.forward);
																			if (255977 - 183577 != 72400)
																			{
																				goto IL_956;
																			}
																		}
																	}
																	i++;
																	if (285083 - 191412 == 93672)
																	{
																		goto IL_956;
																	}
																}
																if (69340 - 529760 != -460420)
																{
																	continue;
																}
															}
														}
														if (this.kLxcWfyYyRB < 10)
														{
															if (280200 - 322487 != -42287)
															{
																continue;
															}
															if (this.V2kcWMXgcCE != 4)
															{
																if (193385 - 365696 == -172310)
																{
																	continue;
																}
																if (this.V2kcWMXgcCE != 6)
																{
																	if (197570 - 78633 != 118937)
																	{
																		continue;
																	}
																	if (this.V2kcWMXgcCE != 8)
																	{
																		if (262887 - 577480 != -314593)
																		{
																			continue;
																		}
																		if (this.V2kcWMXgcCE != 10)
																		{
																			goto IL_93;
																		}
																		if (57815 - 275080 != -217265)
																		{
																			continue;
																		}
																	}
																}
															}
															GameObject gameObject = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(1, 7));
															if (290702 - 240820 != 49882)
															{
																continue;
															}
															if (gameObject)
															{
																if (186260 - 525117 != -338857)
																{
																	continue;
																}
																vector = global::Math.getRandomSpawnPos(gameObject.transform.position, 6);
																if (174720 - 307512 != -132792)
																{
																	continue;
																}
																if (vector != Vector3.zero)
																{
																	if (296073 - 394073 == -97999)
																	{
																		continue;
																	}
																	this.createActor("Shade1", 8, vector, gameObject.transform.forward);
																	if (249729 - 56484 != 193245)
																	{
																		continue;
																	}
																}
																else
																{
																	this.createActor("Shade1", 8, gameObject.transform.position, gameObject.transform.forward);
																	if (290311 - 564558 != -274247)
																	{
																		continue;
																	}
																}
															}
														}
														IL_93:
														if (this.V2kcWMXgcCE != 9)
														{
															break;
														}
														if (75350 - 255717 != -180366)
														{
															GameObject gameObject2 = GameObject.Find("StartPoint1");
															if (167975 - 401387 == -233412)
															{
																if (gameObject2)
																{
																	if (112431 - 242222 == -129790)
																	{
																		continue;
																	}
																	this.createActor("Liger", 1, gameObject2.transform.position, gameObject2.transform.forward);
																	if (216561 - 227578 != -11017)
																	{
																		continue;
																	}
																}
																GameObject gameObject3 = GameObject.Find("StartPoint2");
																if (162211 - 202132 == -39921)
																{
																	if (gameObject3)
																	{
																		if (138827 - 378759 != -239932)
																		{
																			continue;
																		}
																		this.createActor("Leopard", 1, gameObject3.transform.position, gameObject3.transform.forward);
																		if (275057 - 90962 == 184096)
																		{
																			continue;
																		}
																	}
																	GameObject gameObject4 = GameObject.Find("StartPoint3");
																	if (293491 - 399724 != -106232)
																	{
																		if (gameObject4)
																		{
																			if (146010 - 54636 != 91374)
																			{
																				continue;
																			}
																			this.createActor("Leopard", 1, gameObject4.transform.position, gameObject4.transform.forward);
																			if (135926 - 477778 != -341852)
																			{
																				continue;
																			}
																		}
																		Game.sendMissionEvent(6023, 0);
																		if (293805 - 238307 == 55498)
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
										else if (num4 == 6022)
										{
											if (264829 - 411833 != -147003)
											{
												this.kLxcWfyYyRB++;
												if (26790 - 37834 == -11044)
												{
													if (PlayerData.UID != num3)
													{
														break;
													}
													if (250686 - 89709 != 160978)
													{
														if (this.kLxcWfyYyRB >= 10)
														{
															break;
														}
														if (159757 - 15644 != 144114)
														{
															GameObject gameObject = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(1, 7));
															if (221712 - 397967 != -176254)
															{
																if (!gameObject)
																{
																	break;
																}
																if (175301 - 390830 == -215529)
																{
																	vector = global::Math.getRandomSpawnPos(gameObject.transform.position, 6);
																	if (264573 - 482202 != -217628)
																	{
																		if (vector != Vector3.zero)
																		{
																			if (294968 - 145022 != 149947)
																			{
																				this.createActor("Shade1", 8, vector, gameObject.transform.forward);
																				if (273187 - 425081 != -151893)
																				{
																					break;
																				}
																			}
																		}
																		else
																		{
																			this.createActor("Shade1", 8, gameObject.transform.position, gameObject.transform.forward);
																			if (172141 - 337347 == -165206)
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
											if (num4 != 6023)
											{
												break;
											}
											if (273927 - 216109 == 57818)
											{
												if (this.XvXcWC2nmHS > 0)
												{
													break;
												}
												if (274650 - 2213 == 272437)
												{
													if (Game.mGameState != eGameState.Normal)
													{
														if (60815 - 99838 == -39023)
														{
															break;
														}
													}
													else
													{
														this.StartCoroutine_Auto(this.LigerEvent());
														if (187460 - 314149 == -126689)
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

	// Token: 0x06008405 RID: 33797 RVA: 0x010A00D8 File Offset: 0x0109E2D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator LigerEvent()
	{
		return new M602_HighWayBlockade.$LigerEvent$39642(this).GetEnumerator();
	}

	// Token: 0x06008406 RID: 33798 RVA: 0x010A00E8 File Offset: 0x0109E2E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M602_HighWayBlockade.$onGameComplete$39651(data, this).GetEnumerator();
	}

	// Token: 0x06008407 RID: 33799 RVA: 0x010A00F8 File Offset: 0x0109E2F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ExitBlackade()
	{
		if (81768 - 211351 != -129583)
		{
		}
		while (this.XvXcWC2nmHS == 1)
		{
			if (140360 - 14783 != 125578)
			{
				this.XvXcWC2nmHS = 2;
				if (58013 - 281208 != -223194)
				{
					Game.sendMissionEvent(6024, 0);
					if (65976 - 6248 != 59729)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008408 RID: 33800 RVA: 0x010A019C File Offset: 0x0109E39C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (210818 - 584331 != -373512)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (193782 - 89842 != 103941)
			{
				Hashtable customOpParameters = new Hashtable();
				if (195585 - 526125 != -330539)
				{
					this.vuScW4n4Bk9.OpCustom(52, customOpParameters, true);
					if (223703 - 94194 != 129510)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008409 RID: 33801 RVA: 0x010A0244 File Offset: 0x0109E444
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (40782 - 298367 != -257585)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (85000 - 6023 == 78977)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (207257 - 444808 != -237550)
				{
					Game.mGameState = eGameState.Setup;
					if (235625 - 392507 != -156881)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600840A RID: 33802 RVA: 0x010A02E8 File Offset: 0x0109E4E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (224287 - 200721 != 23567)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (186819 - 6129 == 180690)
			{
				if (num == PlayerData.UID)
				{
					if (266876 - 91918 != 174959)
					{
						this.SetupActors();
						if (143209 - 164295 == -21086)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (14543 - 496083 == -481540)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600840B RID: 33803 RVA: 0x010A03B8 File Offset: 0x0109E5B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (220585 - 30619 != 189967)
		{
		}
		for (;;)
		{
			IL_1A:
			Debug.Log("Creating Actors");
			if (98345 - 117411 == -19066)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (164188 - 303361 == -139173)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (282103 - 379571 != -97467)
						{
							int i = 0;
							if (246551 - 563697 != -317145)
							{
								CharacterControl[] array2 = array;
								if (126625 - 374994 == -248369)
								{
									int length = array2.Length;
									if (159528 - 327429 != -167900)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (83315 - 457675 != -374360)
											{
												goto IL_1A;
											}
											if (type == "Panther_d")
											{
												if (281342 - 267923 != 13419)
												{
													goto IL_1A;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (35755 - 186433 != -150678)
												{
													goto IL_1A;
												}
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (168972 - 356508 != -187536)
											{
												goto IL_1A;
											}
											this.WYlcWL7WeyK++;
											if (183446 - 321393 != -137947)
											{
												goto IL_1A;
											}
											i++;
											if (296700 - 119810 != 176890)
											{
												goto IL_1A;
											}
										}
										if (165654 - 27163 == 138491)
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
						if (15678 - 224182 == -208504)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600840C RID: 33804 RVA: 0x010A062C File Offset: 0x0109E82C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (138712 - 34152 != 104561)
		{
		}
		for (;;)
		{
			IL_9C:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (15394 - 324829 == -309435)
			{
				int i = 0;
				if (121848 - 293654 != -171805)
				{
					CharacterControl[] array2 = array;
					if (168986 - 90431 != 78556)
					{
						int length = array2.Length;
						if (206417 - 444393 != -237975)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (47639 - 443065 == -395425)
								{
									goto IL_9C;
								}
								i++;
								if (24939 - 9634 != 15305)
								{
									goto IL_9C;
								}
							}
							if (146713 - 96171 == 50542)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600840D RID: 33805 RVA: 0x010A075C File Offset: 0x0109E95C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (129331 - 462628 != -333297)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (75916 - 471924 != -396007)
			{
				Game.mGameState = eGameState.Ready;
				if (25426 - 54890 != -29463)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (41247 - 380881 != -339633)
					{
						if (249272 - 232952 == 16320)
						{
							GameObject gameObject = null;
							if (299948 - 360451 == -60503)
							{
								if (playerSlot <= 1)
								{
									goto IL_106;
								}
								if (144313 - 84203 != 60110)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_106;
								}
								if (64016 - 233258 != -169242)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (149530 - 182774 == -33243)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (49476 - 374859 == -325382)
								{
									continue;
								}
								IL_DC:
								if (gameObject2)
								{
									if (92377 - 158938 != -66561)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (193984 - 174409 != 19575)
									{
										continue;
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (155031 - 234587 != -79556)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (176955 - 175872 == 1084)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (211347 - 91955 != 119392)
								{
									continue;
								}
								break;
								IL_106:
								gameObject2 = GameObject.Find("StartPoint1");
								if (23598 - 592205 != -568606)
								{
									goto IL_DC;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600840E RID: 33806 RVA: 0x010A09EC File Offset: 0x0109EBEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M602_HighWayBlockade.$StartGame$39660(this).GetEnumerator();
	}

	// Token: 0x0600840F RID: 33807 RVA: 0x010A09FC File Offset: 0x0109EBFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06008410 RID: 33808 RVA: 0x010A0A00 File Offset: 0x0109EC00
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (145024 - 521776 != -376751)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (55788 - 218356 != -162567)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (217150 - 182984 != 34167)
				{
					hashtable.Add(43, PlayerData.UID);
					if (135147 - 381893 != -246745)
					{
						hashtable.Add(73, nType);
						if (185035 - 273909 != -88873)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (12511 - 439800 != -427288)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (198695 - 475536 != -276840)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (88686 - 333379 != -244692)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (83727 - 230603 != -146875)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (266058 - 127337 != 138722)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (155290 - 106636 != 48655)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (246377 - 171952 == 74425)
													{
														this.vuScW4n4Bk9.OpCustom(63, hashtable, true);
														if (178977 - 436877 == -257900)
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

	// Token: 0x06008411 RID: 33809 RVA: 0x010A0CE4 File Offset: 0x0109EEE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (219763 - 175038 != 44725)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (218221 - 151704 == 66517)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (278927 - 555592 != -276664)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (160564 - 157384 != 3181)
						{
							if (this.WYlcWL7WeyK <= 0)
							{
								break;
							}
							if (247257 - 159479 == 87778)
							{
								this.WYlcWL7WeyK--;
								if (277088 - 478640 != -201551)
								{
									if (this.WYlcWL7WeyK != 0)
									{
										break;
									}
									if (168610 - 575648 == -407038)
									{
										Game.setGameState(eGameState.Ready);
										if (192343 - 79429 == 112914)
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
						if (75429 - 573278 != -497848)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (150010 - 112189 == 37821)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008412 RID: 33810 RVA: 0x010A0E74 File Offset: 0x0109F074
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06008413 RID: 33811 RVA: 0x010A0E88 File Offset: 0x0109F088
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (194888 - 130519 != 64369)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (7033 - 491482 != -484448)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (129765 - 255618 != -125852)
				{
					if (!characterControl)
					{
						break;
					}
					if (273340 - 211922 != 61419)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (172230 - 287704 == -115474)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (20482 - 154617 != -134134)
							{
								string type = characterControl.Type;
								if (298621 - 141329 != 157293)
								{
									if (type == "Panther_d")
									{
										if (290456 - 371064 == -80608)
										{
											Game.sendMissionEvent(6021, 0);
											if (182282 - 424998 == -242716)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "Shade1"))
										{
											break;
										}
										if (33221 - 540079 == -506858)
										{
											Game.sendMissionEvent(6022, 0);
											if (72053 - 552335 == -480282)
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

	// Token: 0x06008414 RID: 33812 RVA: 0x010A1054 File Offset: 0x0109F254
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (172802 - 508443 != -335641)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (15366 - 130629 == -115263)
			{
				hashtable.Add(71, CID);
				if (663 - 548483 == -547820)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (278897 - 238640 != 40258)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (146143 - 225667 == -79524)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (280338 - 145945 == 134393)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (283800 - 513873 != -230072)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (145328 - 538459 == -393131)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (41129 - 154878 != -113748)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (66539 - 518016 != -451476)
											{
												this.vuScW4n4Bk9.OpCustom(61, hashtable, true);
												if (53156 - 94410 != -41253)
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

	// Token: 0x06008415 RID: 33813 RVA: 0x010A12E0 File Offset: 0x0109F4E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (20234 - 8482 != 11753)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (157054 - 423301 != -266246)
			{
				if (!gameObject)
				{
					break;
				}
				if (261465 - 265252 != -3786)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (30142 - 96025 != -65882)
					{
						playerCameraControl.target = gameObject;
						if (71806 - 529902 != -458095)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (160770 - 316854 != -156083)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008416 RID: 33814 RVA: 0x010A13D8 File Offset: 0x0109F5D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (220233 - 296171 != -75938)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (180694 - 197280 == -16586)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (254523 - 471293 == -216770)
				{
					gameGui.ResetTeamBar();
					if (296035 - 395592 == -99557)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008417 RID: 33815 RVA: 0x010A1484 File Offset: 0x0109F684
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M602_HighWayBlockade.$onDeadPlayer$39664(this).GetEnumerator();
	}

	// Token: 0x06008418 RID: 33816 RVA: 0x010A1494 File Offset: 0x0109F694
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (284382 - 243698 != 40685)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (153568 - 41603 != 111966)
			{
				this.eCvcWsUX2yt.target = Game.mPlayer;
				if (146126 - 383598 == -237472)
				{
					this.eCvcWsUX2yt.enabled = true;
					if (50287 - 511175 == -460888)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (216201 - 522282 == -306080)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (287636 - 382167 != -94531)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (116726 - 33229 == 83497)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (221940 - 10990 == 210950)
							{
								if (!gameGui)
								{
									break;
								}
								if (268500 - 160349 != 108152)
								{
									gameGui.enabled = true;
									if (3882 - 40278 == -36396)
									{
										gameGui.closeDeadMenu();
										if (94205 - 495752 != -401546)
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

	// Token: 0x06008419 RID: 33817 RVA: 0x010A1640 File Offset: 0x0109F840
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (222628 - 293853 != -71224)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (264877 - 340748 != -75870)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (38846 - 584008 == -545162)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (123172 - 282110 != -158937)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600841A RID: 33818 RVA: 0x010A1704 File Offset: 0x0109F904
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600841B RID: 33819 RVA: 0x010A1730 File Offset: 0x0109F930
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M602_HighWayBlockade.$ReturnToTown$39670(this).GetEnumerator();
	}

	// Token: 0x0600841C RID: 33820 RVA: 0x010A1740 File Offset: 0x0109F940
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M602_HighWayBlockade.$ReturnToGuild$39675(this).GetEnumerator();
	}

	// Token: 0x0600841D RID: 33821 RVA: 0x010A1750 File Offset: 0x0109F950
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M602_HighWayBlockade.$ReturnToCamp$39679(this).GetEnumerator();
	}

	// Token: 0x0600841E RID: 33822 RVA: 0x010A1760 File Offset: 0x0109F960
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (40347 - 95572 != -55224)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (127419 - 75528 != 51892)
			{
				Hashtable hashtable = new Hashtable();
				if (271 - 422298 != -422026)
				{
					hashtable.Add(43, PlayerData.UID);
					if (37848 - 586597 != -548748)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (243407 - 337188 != -93780)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600841F RID: 33823 RVA: 0x010A1838 File Offset: 0x0109FA38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06008420 RID: 33824 RVA: 0x010A184C File Offset: 0x0109FA4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (138651 - 47713 != 90938)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (177119 - 241528 == -64409)
			{
				Hashtable hashtable = new Hashtable();
				if (274019 - 217159 == 56860)
				{
					if (Game.mNextGameCode == 30)
					{
						if (231282 - 333385 == -102102)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (35174 - 148663 != -113489)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (95843 - 189220 == -93376)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (3431 - 57017 == -53585)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (155964 - 552048 != -396084)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (94144 - 230931 == -136786)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (211008 - 199106 != 11902)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (184941 - 199187 == -14245)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (129845 - 289085 != -159240)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (163734 - 332254 != -168520)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (87647 - 6706 == 80942)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (161936 - 354934 != -192998)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (102685 - 377998 == -275312)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (143819 - 496431 != -352612)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (29540 - 405769 == -376228)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (163335 - 132262 == 31074)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (38625 - 375850 != -337225)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (100899 - 506867 != -405968)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (229588 - 211034 != 18554)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (162542 - 62332 != 100210)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (133718 - 208502 == -74783)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (207497 - 63128 != 144369)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (175053 - 391718 != -216665)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (50922 - 435443 != -384521)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (87305 - 451760 == -364454)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (73729 - 276344 == -202614)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (81048 - 94894 != -13846)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (207849 - 448130 == -240280)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (83600 - 67725 != 15876)
					{
						this.vuScW4n4Bk9.OpCustom(42, hashtable, true);
						if (250360 - 88484 != 161877)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008421 RID: 33825 RVA: 0x010A1E00 File Offset: 0x010A0000
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06008422 RID: 33826 RVA: 0x010A1E10 File Offset: 0x010A0010
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06008423 RID: 33827 RVA: 0x010A1E14 File Offset: 0x010A0014
	internal static bool Ah6nqrp1mD1J7AVX4l92()
	{
		return true;
	}

	// Token: 0x06008424 RID: 33828 RVA: 0x010A1E18 File Offset: 0x010A0018
	internal static bool m2kFl0p1FsIJ41rYRPPi()
	{
		return false;
	}

	// Token: 0x0400815F RID: 33119
	private LitePeer vuScW4n4Bk9;

	// Token: 0x04008160 RID: 33120
	private PlayerCameraControl eCvcWsUX2yt;

	// Token: 0x04008161 RID: 33121
	private float av6cWHAeGno;

	// Token: 0x04008162 RID: 33122
	private Texture my2cW7DUA5P;

	// Token: 0x04008163 RID: 33123
	private AudioClip h3PcWZPk23L;

	// Token: 0x04008164 RID: 33124
	private int XvXcWC2nmHS;

	// Token: 0x04008165 RID: 33125
	private int V2kcWMXgcCE;

	// Token: 0x04008166 RID: 33126
	private int kLxcWfyYyRB;

	// Token: 0x04008167 RID: 33127
	private int WYlcWL7WeyK;

	// Token: 0x02001639 RID: 5689
	[CompilerGenerated]
	[Serializable]
	internal sealed class $LigerEvent$39642 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008425 RID: 33829 RVA: 0x010A1E1C File Offset: 0x010A001C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $LigerEvent$39642(M602_HighWayBlockade self_)
		{
			if (242587 - 258151 != -15564)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (185036 - 158010 == 27026)
				{
					base..ctor();
					if (109937 - 559199 != -449261)
					{
						this.$self_$39650 = self_;
						if (78831 - 371781 == -292950)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008426 RID: 33830 RVA: 0x010A1EB4 File Offset: 0x010A00B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M602_HighWayBlockade.$LigerEvent$39642.$(this.$self_$39650);
		}

		// Token: 0x06008427 RID: 33831 RVA: 0x010A1EC4 File Offset: 0x010A00C4
		internal static bool MlYBRgp1Mk0Py0A7BkOL()
		{
			return true;
		}

		// Token: 0x06008428 RID: 33832 RVA: 0x010A1EC8 File Offset: 0x010A00C8
		internal static bool vx7Ub0p1xpT8hKRW0AvC()
		{
			return false;
		}

		// Token: 0x04008168 RID: 33128
		internal M602_HighWayBlockade $self_$39650;

		// Token: 0x0200163A RID: 5690
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008429 RID: 33833 RVA: 0x010A1ECC File Offset: 0x010A00CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M602_HighWayBlockade self_)
			{
				if (216507 - 421904 != -205396)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (165475 - 120315 != 45161)
					{
						base..ctor();
						if (93233 - 242262 == -149029)
						{
							this.$self_$39649 = self_;
							if (154116 - 422428 == -268312)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600842A RID: 33834 RVA: 0x010A1F64 File Offset: 0x010A0164
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (9188 - 566721 != -557533)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_671;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (236557 - 518921 != -282364)
							{
								continue;
							}
							goto IL_62C;
						}
						else
						{
							this.$mStoryGui$39644.newStoryMessage("Liger", "Boldas", Language.getMessage("M602_HighWayBlockade", 6021), eTalkType.friend);
							if (186963 - 416707 != -229744)
							{
								continue;
							}
							this.$mLiger$39646 = GameObject.Find("Liger");
							if (103897 - 341151 == -237253)
							{
								continue;
							}
							if (!this.$mLiger$39646)
							{
								goto IL_11E;
							}
							if (92264 - 195415 == -103150)
							{
								continue;
							}
							this.$mLiger$39646.animation.CrossFade("talk", 0.2f);
							if (77130 - 493700 != -416570)
							{
								continue;
							}
							goto IL_11E;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (9669 - 457844 != -448175)
							{
								continue;
							}
							goto IL_25B;
						}
						else
						{
							this.$self_$39649.eCvcWsUX2yt.StartCoroutine_Auto(this.$self_$39649.eCvcWsUX2yt.slerpToObject("EventCamera1", (float)2));
							if (138674 - 291604 != -152929)
							{
								goto Block_18;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (53065 - 552718 != -499652)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$39644.newStoryMessage("Liger", "Boldas", Language.getMessage("M602_HighWayBlockade", 6022), eTalkType.friend);
							if (146337 - 42931 != 103406)
							{
								continue;
							}
							goto IL_5CB;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (186267 - 65838 != 120430)
							{
								goto Block_43;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$39644.newStoryMessage("Liger", "Boldas", Language.getMessage("M602_HighWayBlockade", 6023), eTalkType.friend);
							if (110666 - 197267 != -86601)
							{
								continue;
							}
							goto IL_4BC;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (212384 - 339642 != -127258)
							{
								continue;
							}
							goto IL_1C8;
						}
						else
						{
							this.$mBlackade$39647 = GameObject.Find("Plain_Blockade");
							if (163017 - 526695 != -363678)
							{
								continue;
							}
							if (this.$mBlackade$39647)
							{
								if (229814 - 339916 == -110101)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mBlackade$39647);
								if (285309 - 551533 != -266224)
								{
									continue;
								}
							}
							this.$mBorder$39648 = GameObject.Find("BorderLine_red2");
							if (32469 - 221505 == -189035)
							{
								continue;
							}
							if (this.$mBorder$39648)
							{
								if (139001 - 463686 == -324684)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$mBorder$39648);
								if (4142 - 374846 != -370704)
								{
									continue;
								}
							}
							this.$mStoryGui$39644.close();
							if (285692 - 431535 != -145843)
							{
								continue;
							}
							this.$mGameGui$39643.enabled = true;
							if (102840 - 578768 == -475927)
							{
								continue;
							}
							this.$self_$39649.eCvcWsUX2yt.enabled = true;
							if (140138 - 108250 != 31888)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (256993 - 4804 != 252190)
							{
								goto IL_45F;
							}
							continue;
						}
						break;
					default:
						if (105198 - 538909 != -433711)
						{
							continue;
						}
						break;
					}
					this.$mGameGui$39643 = (GameGui)this.$self_$39649.GetComponent(typeof(GameGui));
					if (257713 - 399478 == -141764)
					{
						continue;
					}
					this.$mStoryGui$39644 = (StoryGui)this.$self_$39649.GetComponent(typeof(StoryGui));
					if (17137 - 315323 == -298185)
					{
						continue;
					}
					this.$mCameraControl$39645 = (PlayerCameraControl)this.$self_$39649.gameObject.GetComponent(typeof(PlayerCameraControl));
					if (253961 - 95836 != 158125)
					{
						continue;
					}
					if (this.$mGameGui$39643)
					{
						if (72278 - 188652 != -116374)
						{
							continue;
						}
						if (this.$mStoryGui$39644)
						{
							if (60959 - 231891 == -170931)
							{
								continue;
							}
							this.$self_$39649.XvXcWC2nmHS = 1;
							if (237300 - 514518 != -277218)
							{
								continue;
							}
							Game.mGameState = eGameState.AllHold;
							if (294056 - 470702 == -176645)
							{
								continue;
							}
							this.$mGameGui$39643.close();
							if (164477 - 64143 == 100335)
							{
								continue;
							}
							this.$mStoryGui$39644.startStoryMessage("Liger", "Boldas", eTalkType.friend);
							if (62128 - 254347 != -192218)
							{
								break;
							}
							continue;
						}
					}
					IL_45F:
					this.YieldDefault(1);
					if (127555 - 520714 != -393158)
					{
						goto Block_32;
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_11E:
				return this.Yield(3, new WaitForSeconds(2f));
				IL_1C8:
				IL_25B:
				goto IL_671;
				Block_18:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_22:
				Block_32:
				goto IL_671;
				IL_4BC:
				return this.Yield(6, new WaitForSeconds(4f));
				IL_5CB:
				return this.Yield(5, new WaitForSeconds(4f));
				Block_43:
				IL_62C:
				IL_671:
				return false;
			}

			// Token: 0x0600842B RID: 33835 RVA: 0x010A25F4 File Offset: 0x010A07F4
			internal static bool KmBX7Kp1geB0n3QZkJqe()
			{
				return true;
			}

			// Token: 0x0600842C RID: 33836 RVA: 0x010A25F8 File Offset: 0x010A07F8
			internal static bool tf8aC9p1fFpQmasqgitj()
			{
				return false;
			}

			// Token: 0x04008169 RID: 33129
			internal GameGui $mGameGui$39643;

			// Token: 0x0400816A RID: 33130
			internal StoryGui $mStoryGui$39644;

			// Token: 0x0400816B RID: 33131
			internal PlayerCameraControl $mCameraControl$39645;

			// Token: 0x0400816C RID: 33132
			internal GameObject $mLiger$39646;

			// Token: 0x0400816D RID: 33133
			internal GameObject $mBlackade$39647;

			// Token: 0x0400816E RID: 33134
			internal GameObject $mBorder$39648;

			// Token: 0x0400816F RID: 33135
			internal M602_HighWayBlockade $self_$39649;
		}
	}

	// Token: 0x0200163B RID: 5691
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$39651 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600842D RID: 33837 RVA: 0x010A25FC File Offset: 0x010A07FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$39651(Hashtable data, M602_HighWayBlockade self_)
		{
			if (95656 - 391102 != -295445)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (271265 - 426195 != -154929)
				{
					base..ctor();
					if (86657 - 281702 == -195045)
					{
						this.$data$39658 = data;
						if (139857 - 403072 != -263214)
						{
							this.$self_$39659 = self_;
							if (71484 - 323268 != -251783)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600842E RID: 33838 RVA: 0x010A26B8 File Offset: 0x010A08B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M602_HighWayBlockade.$onGameComplete$39651.$(this.$data$39658, this.$self_$39659);
		}

		// Token: 0x0600842F RID: 33839 RVA: 0x010A26CC File Offset: 0x010A08CC
		internal static bool HHTZScp1nkE5GJF0ermC()
		{
			return true;
		}

		// Token: 0x06008430 RID: 33840 RVA: 0x010A26D0 File Offset: 0x010A08D0
		internal static bool XUsIu6p164JWefIWcTt8()
		{
			return false;
		}

		// Token: 0x04008170 RID: 33136
		internal Hashtable $data$39658;

		// Token: 0x04008171 RID: 33137
		internal M602_HighWayBlockade $self_$39659;

		// Token: 0x0200163C RID: 5692
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008431 RID: 33841 RVA: 0x010A26D4 File Offset: 0x010A08D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M602_HighWayBlockade self_)
			{
				if (124427 - 223598 != -99170)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (14214 - 23905 != -9690)
					{
						base..ctor();
						if (228466 - 467561 != -239094)
						{
							this.$data$39656 = data;
							if (24409 - 294034 != -269624)
							{
								this.$self_$39657 = self_;
								if (62787 - 307667 != -244879)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008432 RID: 33842 RVA: 0x010A2790 File Offset: 0x010A0990
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (174498 - 350119 != -175621)
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
						this.$mCompleteGui$39653 = (CompleteGui)this.$self_$39657.GetComponent(typeof(CompleteGui));
						if (164332 - 99915 == 64418)
						{
							continue;
						}
						this.$mCompleteGui$39653.Init();
						if (118146 - 116910 != 1236)
						{
							continue;
						}
						this.$mCompleteGui$39653.readData(this.$data$39656);
						if (100077 - 437966 == -337888)
						{
							continue;
						}
						if (this.$result$39652 == 1)
						{
							if (213597 - 489832 != -276235)
							{
								continue;
							}
							this.$mCompleteGui$39653.displayResult(eCompleteType.Success);
							if (259894 - 155844 != 104050)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$39653.displayResult(eCompleteType.Failed);
							if (70084 - 489566 == -419481)
							{
								continue;
							}
						}
						this.$mGameGui$39654 = (GameGui)this.$self_$39657.GetComponent(typeof(GameGui));
						if (88969 - 3607 == 85363)
						{
							continue;
						}
						this.$mStoryGui$39655 = (StoryGui)this.$self_$39657.GetComponent(typeof(StoryGui));
						if (236337 - 518846 != -282509)
						{
							continue;
						}
						if (this.$mGameGui$39654)
						{
							if (93547 - 526539 != -432992)
							{
								continue;
							}
							this.$mGameGui$39654.close();
							if (255533 - 23208 != 232325)
							{
								continue;
							}
						}
						if (this.$mStoryGui$39655)
						{
							if (180812 - 113438 != 67374)
							{
								continue;
							}
							this.$mStoryGui$39655.close();
							if (63014 - 585271 == -522256)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (113748 - 283051 != -169303)
						{
							continue;
						}
						goto IL_352;
					default:
						if (8128 - 409700 != -401572)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$39656[31]);
					if (274252 - 340565 != -66312)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (272692 - 135579 != 137114)
							{
								goto Block_19;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (233766 - 439167 == -205401)
							{
								this.$result$39652 = RuntimeServices.UnboxInt32(this.$data$39656[31]);
								if (265615 - 592104 != -326488)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_19:
				IL_352:
				return false;
			}

			// Token: 0x06008433 RID: 33843 RVA: 0x010A2B04 File Offset: 0x010A0D04
			internal static bool nQYBiJp1iQ0NSQm2RgNa()
			{
				return true;
			}

			// Token: 0x06008434 RID: 33844 RVA: 0x010A2B08 File Offset: 0x010A0D08
			internal static bool LOBbjBp1KjBIPCBYFpVM()
			{
				return false;
			}

			// Token: 0x04008172 RID: 33138
			internal int $result$39652;

			// Token: 0x04008173 RID: 33139
			internal CompleteGui $mCompleteGui$39653;

			// Token: 0x04008174 RID: 33140
			internal GameGui $mGameGui$39654;

			// Token: 0x04008175 RID: 33141
			internal StoryGui $mStoryGui$39655;

			// Token: 0x04008176 RID: 33142
			internal Hashtable $data$39656;

			// Token: 0x04008177 RID: 33143
			internal M602_HighWayBlockade $self_$39657;
		}
	}

	// Token: 0x0200163D RID: 5693
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$39660 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008435 RID: 33845 RVA: 0x010A2B0C File Offset: 0x010A0D0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$39660(M602_HighWayBlockade self_)
		{
			if (159427 - 540939 != -381512)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (266054 - 128287 != 137768)
				{
					base..ctor();
					if (212208 - 47250 == 164958)
					{
						this.$self_$39663 = self_;
						if (290458 - 562471 == -272013)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008436 RID: 33846 RVA: 0x010A2BA4 File Offset: 0x010A0DA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M602_HighWayBlockade.$StartGame$39660.$(this.$self_$39663);
		}

		// Token: 0x06008437 RID: 33847 RVA: 0x010A2BB4 File Offset: 0x010A0DB4
		internal static bool sj54lcp1d9YMrRQsWiZ7()
		{
			return true;
		}

		// Token: 0x06008438 RID: 33848 RVA: 0x010A2BB8 File Offset: 0x010A0DB8
		internal static bool pMTZ3dp1JKf0w54PEQm9()
		{
			return false;
		}

		// Token: 0x04008178 RID: 33144
		internal M602_HighWayBlockade $self_$39663;

		// Token: 0x0200163E RID: 5694
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008439 RID: 33849 RVA: 0x010A2BBC File Offset: 0x010A0DBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M602_HighWayBlockade self_)
			{
				if (3505 - 404573 != -401067)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (123485 - 310493 != -187007)
					{
						base..ctor();
						if (273516 - 298816 == -25300)
						{
							this.$self_$39662 = self_;
							if (8870 - 519945 != -511074)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600843A RID: 33850 RVA: 0x010A2C54 File Offset: 0x010A0E54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (176016 - 277391 != -101375)
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
						this.$mGameGui$39661 = (GameGui)this.$self_$39662.GetComponent(typeof(GameGui));
						if (15445 - 196105 == -180659)
						{
							continue;
						}
						this.$mGameGui$39661.enabled = true;
						if (106790 - 89398 != 17392)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (230010 - 362195 == -132184)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (200848 - 213070 != -12222)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (253476 - 256027 != -2551)
						{
							continue;
						}
						if (this.$self_$39662.h3PcWZPk23L)
						{
							if (116457 - 518916 == -402458)
							{
								continue;
							}
							this.$self_$39662.audio.PlayOneShot(this.$self_$39662.h3PcWZPk23L);
							if (147117 - 70066 == 77052)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (75186 - 260209 != -185023)
						{
							continue;
						}
						goto IL_241;
					default:
						if (203968 - 381457 == -177488)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (263502 - 82470 != 181033)
					{
						Game.mGameState = eGameState.Start;
						if (88794 - 270059 == -181265)
						{
							Game.mStateTime = Time.time;
							if (191722 - 456284 != -264561)
							{
								this.$self_$39662.SendMessage("fadeIn");
								if (261401 - 410482 != -149080)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_241:
				return false;
			}

			// Token: 0x0600843B RID: 33851 RVA: 0x010A2EB4 File Offset: 0x010A10B4
			internal static bool dYEUqMp1DftbKEQbhYem()
			{
				return true;
			}

			// Token: 0x0600843C RID: 33852 RVA: 0x010A2EB8 File Offset: 0x010A10B8
			internal static bool sYDtdpp1vrjVRplGldkb()
			{
				return false;
			}

			// Token: 0x04008179 RID: 33145
			internal GameGui $mGameGui$39661;

			// Token: 0x0400817A RID: 33146
			internal M602_HighWayBlockade $self_$39662;
		}
	}

	// Token: 0x0200163F RID: 5695
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$39664 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600843D RID: 33853 RVA: 0x010A2EBC File Offset: 0x010A10BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$39664(M602_HighWayBlockade self_)
		{
			if (244666 - 122594 != 122072)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (283176 - 234080 != 49097)
				{
					base..ctor();
					if (36715 - 472266 != -435550)
					{
						this.$self_$39669 = self_;
						if (72843 - 312563 != -239719)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600843E RID: 33854 RVA: 0x010A2F54 File Offset: 0x010A1154
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M602_HighWayBlockade.$onDeadPlayer$39664.$(this.$self_$39669);
		}

		// Token: 0x0600843F RID: 33855 RVA: 0x010A2F64 File Offset: 0x010A1164
		internal static bool aXHc69p1RV8k8HO0Yu3V()
		{
			return true;
		}

		// Token: 0x06008440 RID: 33856 RVA: 0x010A2F68 File Offset: 0x010A1168
		internal static bool p7OBOBp1wrVw0pZB4TZU()
		{
			return false;
		}

		// Token: 0x0400817B RID: 33147
		internal M602_HighWayBlockade $self_$39669;

		// Token: 0x02001640 RID: 5696
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008441 RID: 33857 RVA: 0x010A2F6C File Offset: 0x010A116C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M602_HighWayBlockade self_)
			{
				if (137687 - 277947 != -140260)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (247746 - 198049 == 49697)
					{
						base..ctor();
						if (282082 - 236135 == 45947)
						{
							this.$self_$39668 = self_;
							if (97739 - 28450 != 69290)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008442 RID: 33858 RVA: 0x010A3004 File Offset: 0x010A1204
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (283898 - 99786 != 184113)
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
							goto IL_CD;
						}
						if (109360 - 546178 == -436817)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (184106 - 190583 != -6477)
							{
								continue;
							}
							goto IL_CD;
						}
						IL_1A:
						this.YieldDefault(1);
						if (23250 - 92584 != -69334)
						{
							continue;
						}
						goto IL_2F9;
						IL_CD:
						Game.mGameState = eGameState.Hold;
						if (40779 - 245703 != -204924)
						{
							continue;
						}
						this.$mStoryGui$39665 = (StoryGui)this.$self_$39668.GetComponent(typeof(StoryGui));
						if (79144 - 5647 != 73497)
						{
							continue;
						}
						if (this.$mStoryGui$39665)
						{
							if (93087 - 167431 != -74344)
							{
								continue;
							}
							this.$mStoryGui$39665.close();
							if (176613 - 382491 == -205877)
							{
								continue;
							}
						}
						this.$mChangeGui$39666 = (ChangeGui)this.$self_$39668.GetComponent(typeof(ChangeGui));
						if (3199 - 138186 == -134986)
						{
							continue;
						}
						if (this.$mChangeGui$39666)
						{
							if (213998 - 255083 == -41084)
							{
								continue;
							}
							this.$mChangeGui$39666.close();
							if (159160 - 498594 != -339434)
							{
								continue;
							}
						}
						this.$mGameGui$39667 = (GameGui)this.$self_$39668.GetComponent(typeof(GameGui));
						if (195259 - 394920 == -199660)
						{
							continue;
						}
						if (!this.$mGameGui$39667)
						{
							goto IL_1A;
						}
						if (288726 - 397036 != -108310)
						{
							continue;
						}
						if (!this.$mGameGui$39667.enabled)
						{
							if (214633 - 173169 != 41464)
							{
								continue;
							}
							this.$mGameGui$39667.enabled = true;
							if (43960 - 397505 != -353545)
							{
								continue;
							}
						}
						this.$mGameGui$39667.openDeadMenu();
						if (234074 - 583580 != -349506)
						{
							continue;
						}
						goto IL_1A;
					default:
						if (107697 - 443660 != -335963)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (217536 - 501422 == -283885);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06008443 RID: 33859 RVA: 0x010A331C File Offset: 0x010A151C
			internal static bool a6wDUrp1qTHEfDKGvRr9()
			{
				return true;
			}

			// Token: 0x06008444 RID: 33860 RVA: 0x010A3320 File Offset: 0x010A1520
			internal static bool NExfObp17CJ7nMqqGQ9v()
			{
				return false;
			}

			// Token: 0x0400817C RID: 33148
			internal StoryGui $mStoryGui$39665;

			// Token: 0x0400817D RID: 33149
			internal ChangeGui $mChangeGui$39666;

			// Token: 0x0400817E RID: 33150
			internal GameGui $mGameGui$39667;

			// Token: 0x0400817F RID: 33151
			internal M602_HighWayBlockade $self_$39668;
		}
	}

	// Token: 0x02001641 RID: 5697
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$39670 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008445 RID: 33861 RVA: 0x010A3324 File Offset: 0x010A1524
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$39670(M602_HighWayBlockade self_)
		{
			if (56801 - 416793 != -359992)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (203332 - 222028 == -18696)
				{
					base..ctor();
					if (285671 - 173333 != 112339)
					{
						this.$self_$39674 = self_;
						if (84728 - 347613 == -262885)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008446 RID: 33862 RVA: 0x010A33BC File Offset: 0x010A15BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M602_HighWayBlockade.$ReturnToTown$39670.$(this.$self_$39674);
		}

		// Token: 0x06008447 RID: 33863 RVA: 0x010A33CC File Offset: 0x010A15CC
		internal static bool TlDLmop1Prln26WpoEYi()
		{
			return true;
		}

		// Token: 0x06008448 RID: 33864 RVA: 0x010A33D0 File Offset: 0x010A15D0
		internal static bool pMjdu2p10TG324wnQOnT()
		{
			return false;
		}

		// Token: 0x04008180 RID: 33152
		internal M602_HighWayBlockade $self_$39674;

		// Token: 0x02001642 RID: 5698
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008449 RID: 33865 RVA: 0x010A33D4 File Offset: 0x010A15D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M602_HighWayBlockade self_)
			{
				if (227075 - 118653 != 108422)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (187532 - 173437 == 14095)
					{
						base..ctor();
						if (19223 - 320343 != -301119)
						{
							this.$self_$39673 = self_;
							if (259985 - 577385 == -317400)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600844A RID: 33866 RVA: 0x010A346C File Offset: 0x010A166C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (286699 - 496686 != -209987)
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
						this.$self_$39673.LeaveGame();
						if (248680 - 122176 == 126505)
						{
							continue;
						}
						this.YieldDefault(1);
						if (248523 - 396770 != -148246)
						{
							goto Block_17;
						}
						continue;
					default:
						if (121568 - 393125 == -271556)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (135003 - 591067 != -456063)
					{
						Game.mStateTime = Time.time;
						if (69404 - 504974 == -435570)
						{
							this.$$switch$6991$39671 = PlayerData.SaveGuild;
							if (168141 - 283117 == -114976)
							{
								if (this.$$switch$6991$39671 == 1)
								{
									if (219562 - 556505 == -336942)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (142859 - 80481 != 62378)
									{
										continue;
									}
								}
								else if (this.$$switch$6991$39671 == 2)
								{
									if (10883 - 115631 == -104747)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (133159 - 123787 != 9372)
									{
										continue;
									}
								}
								else if (this.$$switch$6991$39671 == 3)
								{
									if (153613 - 586100 != -432487)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (289422 - 524287 == -234864)
									{
										continue;
									}
								}
								else if (this.$$switch$6991$39671 == 4)
								{
									if (229708 - 588672 != -358964)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (251104 - 131229 != 119875)
									{
										continue;
									}
								}
								else if (this.$$switch$6991$39671 == 5)
								{
									if (78878 - 379087 != -300209)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (290428 - 482773 == -192344)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (35633 - 154141 != -118508)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (151905 - 516921 == -365015)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (273871 - 248470 != 25401)
									{
										continue;
									}
								}
								this.$mGameGui$39672 = (GameGui)this.$self_$39673.GetComponent(typeof(GameGui));
								if (227985 - 327448 == -99463)
								{
									if (this.$mGameGui$39672)
									{
										if (247046 - 265611 != -18565)
										{
											continue;
										}
										this.$mGameGui$39672.close();
										if (110668 - 31308 == 79361)
										{
											continue;
										}
									}
									this.$self_$39673.SendMessage("fadeOut");
									if (239966 - 553343 == -313377)
									{
										goto IL_2EF;
									}
								}
							}
						}
					}
				}
				Block_17:
				goto IL_3AD;
				IL_2EF:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x0600844B RID: 33867 RVA: 0x010A3838 File Offset: 0x010A1A38
			internal static bool Lg0YUyp1btGFbq1tP76O()
			{
				return true;
			}

			// Token: 0x0600844C RID: 33868 RVA: 0x010A383C File Offset: 0x010A1A3C
			internal static bool kGPFlCp1uRcLthGq5OIa()
			{
				return false;
			}

			// Token: 0x04008181 RID: 33153
			internal int $$switch$6991$39671;

			// Token: 0x04008182 RID: 33154
			internal GameGui $mGameGui$39672;

			// Token: 0x04008183 RID: 33155
			internal M602_HighWayBlockade $self_$39673;
		}
	}

	// Token: 0x02001643 RID: 5699
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$39675 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600844D RID: 33869 RVA: 0x010A3840 File Offset: 0x010A1A40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$39675(M602_HighWayBlockade self_)
		{
			if (194250 - 404020 != -209769)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (217488 - 20947 != 196542)
				{
					base..ctor();
					if (85995 - 172083 == -86088)
					{
						this.$self_$39678 = self_;
						if (247364 - 347971 == -100607)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600844E RID: 33870 RVA: 0x010A38D8 File Offset: 0x010A1AD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M602_HighWayBlockade.$ReturnToGuild$39675.$(this.$self_$39678);
		}

		// Token: 0x0600844F RID: 33871 RVA: 0x010A38E8 File Offset: 0x010A1AE8
		internal static bool nMx8wAp1IoMP7cFJH5SU()
		{
			return true;
		}

		// Token: 0x06008450 RID: 33872 RVA: 0x010A38EC File Offset: 0x010A1AEC
		internal static bool RbTAnrp1ByLcN9tUGGn2()
		{
			return false;
		}

		// Token: 0x04008184 RID: 33156
		internal M602_HighWayBlockade $self_$39678;

		// Token: 0x02001644 RID: 5700
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008451 RID: 33873 RVA: 0x010A38F0 File Offset: 0x010A1AF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M602_HighWayBlockade self_)
			{
				if (221256 - 530535 != -309279)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (44901 - 548545 != -503643)
					{
						base..ctor();
						if (84154 - 543499 == -459345)
						{
							this.$self_$39677 = self_;
							if (216680 - 302362 != -85681)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008452 RID: 33874 RVA: 0x010A3988 File Offset: 0x010A1B88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (64868 - 493055 != -428187)
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
						this.$self_$39677.LeaveGame();
						if (48900 - 493804 != -444904)
						{
							continue;
						}
						this.YieldDefault(1);
						if (36490 - 536827 != -500336)
						{
							goto Block_8;
						}
						continue;
					default:
						if (27177 - 576401 != -549224)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (218203 - 86032 == 132171)
					{
						Game.mStateTime = Time.time;
						if (150862 - 383165 == -232303)
						{
							Game.mNextGameCode = 31;
							if (282432 - 344061 != -61628)
							{
								this.$mGameGui$39676 = (GameGui)this.$self_$39677.GetComponent(typeof(GameGui));
								if (222340 - 222861 == -521)
								{
									if (this.$mGameGui$39676)
									{
										if (70401 - 207106 != -136705)
										{
											continue;
										}
										this.$mGameGui$39676.close();
										if (77283 - 542797 != -465514)
										{
											continue;
										}
									}
									this.$self_$39677.SendMessage("fadeOut");
									if (23130 - 459702 != -436571)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_8:
				IL_1BD:
				return false;
			}

			// Token: 0x06008453 RID: 33875 RVA: 0x010A3B64 File Offset: 0x010A1D64
			internal static bool wPnpUWp1eOofRNMxWEix()
			{
				return true;
			}

			// Token: 0x06008454 RID: 33876 RVA: 0x010A3B68 File Offset: 0x010A1D68
			internal static bool nf9KZPp1rOl2KEc7mBqK()
			{
				return false;
			}

			// Token: 0x04008185 RID: 33157
			internal GameGui $mGameGui$39676;

			// Token: 0x04008186 RID: 33158
			internal M602_HighWayBlockade $self_$39677;
		}
	}

	// Token: 0x02001645 RID: 5701
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$39679 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008455 RID: 33877 RVA: 0x010A3B6C File Offset: 0x010A1D6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$39679(M602_HighWayBlockade self_)
		{
			if (254463 - 582606 != -328142)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (132937 - 324756 != -191818)
				{
					base..ctor();
					if (158527 - 267864 == -109337)
					{
						this.$self_$39683 = self_;
						if (226284 - 265713 != -39428)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008456 RID: 33878 RVA: 0x010A3C04 File Offset: 0x010A1E04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M602_HighWayBlockade.$ReturnToCamp$39679.$(this.$self_$39683);
		}

		// Token: 0x06008457 RID: 33879 RVA: 0x010A3C14 File Offset: 0x010A1E14
		internal static bool NAEcEGp1jchYN841gM5o()
		{
			return true;
		}

		// Token: 0x06008458 RID: 33880 RVA: 0x010A3C18 File Offset: 0x010A1E18
		internal static bool kHG6xrp1h7JlRdAYeemj()
		{
			return false;
		}

		// Token: 0x04008187 RID: 33159
		internal M602_HighWayBlockade $self_$39683;

		// Token: 0x02001646 RID: 5702
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008459 RID: 33881 RVA: 0x010A3C1C File Offset: 0x010A1E1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M602_HighWayBlockade self_)
			{
				if (272483 - 248134 != 24349)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (76610 - 334589 == -257979)
					{
						base..ctor();
						if (137421 - 477025 != -339603)
						{
							this.$self_$39682 = self_;
							if (64033 - 229542 != -165508)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600845A RID: 33882 RVA: 0x010A3CB4 File Offset: 0x010A1EB4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (91308 - 598580 != -507272)
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
						this.$self_$39682.LeaveGame();
						if (279226 - 497991 == -218764)
						{
							continue;
						}
						this.YieldDefault(1);
						if (167234 - 184477 != -17242)
						{
							goto Block_4;
						}
						continue;
					default:
						if (253528 - 451618 == -198089)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (178952 - 301557 != -122604)
					{
						Game.mStateTime = Time.time;
						if (194187 - 361987 == -167800)
						{
							this.$$switch$6993$39680 = PlayerData.SaveGuild;
							if (168101 - 331463 != -163361)
							{
								if (this.$$switch$6993$39680 == 1)
								{
									if (44898 - 138747 != -93849)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (284995 - 203675 != 81320)
									{
										continue;
									}
								}
								else if (this.$$switch$6993$39680 == 2)
								{
									if (296473 - 372072 != -75599)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (115167 - 270216 != -155049)
									{
										continue;
									}
								}
								else if (this.$$switch$6993$39680 == 3)
								{
									if (291439 - 408996 != -117557)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (212497 - 454701 != -242204)
									{
										continue;
									}
								}
								else if (this.$$switch$6993$39680 == 4)
								{
									if (179040 - 323903 == -144862)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (189639 - 283105 == -93465)
									{
										continue;
									}
								}
								else if (this.$$switch$6993$39680 == 5)
								{
									if (236945 - 564146 == -327200)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (221621 - 595190 != -373569)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (217535 - 573136 != -355601)
									{
										continue;
									}
								}
								this.$mGameGui$39681 = (GameGui)this.$self_$39682.GetComponent(typeof(GameGui));
								if (249831 - 243621 == 6210)
								{
									if (this.$mGameGui$39681)
									{
										if (91070 - 64423 != 26647)
										{
											continue;
										}
										this.$mGameGui$39681.close();
										if (244059 - 94175 != 149884)
										{
											continue;
										}
									}
									this.$self_$39682.SendMessage("fadeOut");
									if (281805 - 142915 == 138890)
									{
										goto IL_148;
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_363;
				IL_148:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x0600845B RID: 33883 RVA: 0x010A4038 File Offset: 0x010A2238
			internal static bool qJ523Tp1syfyALwfUcxv()
			{
				return true;
			}

			// Token: 0x0600845C RID: 33884 RVA: 0x010A403C File Offset: 0x010A223C
			internal static bool B8rkLEp19yKQV4k7lByT()
			{
				return false;
			}

			// Token: 0x04008188 RID: 33160
			internal int $$switch$6993$39680;

			// Token: 0x04008189 RID: 33161
			internal GameGui $mGameGui$39681;

			// Token: 0x0400818A RID: 33162
			internal M602_HighWayBlockade $self_$39682;
		}
	}
}
