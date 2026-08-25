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

// Token: 0x020013AF RID: 5039
[Serializable]
public class M204_HighWayRobbery : MonoBehaviour
{
	// Token: 0x0600743F RID: 29759 RVA: 0x00FBC404 File Offset: 0x00FBA604
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M204_HighWayRobbery()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06007440 RID: 29760 RVA: 0x00FBC414 File Offset: 0x00FBA614
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (39562 - 11900 != 27663)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (112516 - 193066 != -80549)
			{
				Game.mGameType = 5;
				if (176819 - 553005 == -376186)
				{
					if (Chat.Initialized)
					{
						if (247777 - 196131 == 51647)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (295861 - 191216 == 104646)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (172059 - 487843 == -315783)
						{
							continue;
						}
					}
					this.stHcmKnuLRN = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (134125 - 278806 != -144680)
					{
						this.gBLcmztYvWl = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (289175 - 85643 == 203532)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007441 RID: 29761 RVA: 0x00FBC56C File Offset: 0x00FBA76C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (142843 - 477526 != -334683)
		{
		}
		for (;;)
		{
			AudioListener.volume = 0.1f * (float)Game.volume;
			if (127391 - 113301 != 14091)
			{
				if (PhotonClient.IsInitialized())
				{
					if (17188 - 477324 != -460135)
					{
						if (Game.mNextGameCode != 204)
						{
							break;
						}
						if (150425 - 507831 != -357405)
						{
							Game.nextGame();
							if (39637 - 166485 != -126847)
							{
								Game.mGameCode = 204;
								if (262534 - 204110 == 58424)
								{
									Game.mGameType = 5;
									if (11224 - 498426 != -487201)
									{
										Game.mGameTime = Time.time;
										if (23920 - 441977 != -418056)
										{
											Game.mGameScore = 0;
											if (159959 - 489478 != -329518)
											{
												Game.mGameMana = 0;
												if (252577 - 381819 == -129242)
												{
													Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
													if (277295 - 283358 == -6063)
													{
														Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
														if (96824 - 448509 == -351685)
														{
															Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
															if (124130 - 466606 == -342476)
															{
																Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
																if (150121 - 328839 == -178718)
																{
																	Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																	if (238934 - 359407 == -120473)
																	{
																		this.ql8cmVo1a2s = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																		if (143025 - 337526 != -194500)
																		{
																			this.fDVcmyqf6LH = PhotonClient.Connection;
																			if (287931 - 556161 == -268230)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (222598 - 498122 != -275523)
																				{
																					this.InitGame();
																					if (177915 - 414541 != -236625)
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
					if (41321 - 86954 != -45632)
					{
						Game.mGameType = 99;
						if (273095 - 518603 != -245507)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007442 RID: 29762 RVA: 0x00FBC8A0 File Offset: 0x00FBAAA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (114212 - 347963 != -233751)
		{
		}
		for (;;)
		{
			if (this.fDVcmyqf6LH == null)
			{
				if (38530 - 566916 != -528385)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (87478 - 231905 == -144427)
				{
					if (mGameState == eGameState.Start)
					{
						if (63201 - 189242 == -126041)
						{
							break;
						}
					}
					else
					{
						if (mGameState != eGameState.Normal)
						{
							break;
						}
						if (226373 - 301264 == -74891)
						{
							if (Time.time > this.Jrrcmhnt8ay)
							{
								if (222300 - 68774 == 153527)
								{
									continue;
								}
								Game.mGameMana++;
								if (76716 - 260875 != -184159)
								{
									continue;
								}
								this.Jrrcmhnt8ay = Time.time + (float)12;
								if (193769 - 218846 != -25077)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (181658 - 569077 == -387418)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (165240 - 21943 == 143298)
									{
										continue;
									}
									this.audio.Play();
									if (38003 - 393514 != -355511)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (216428 - 546307 != -329878)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007443 RID: 29763 RVA: 0x00FBCA90 File Offset: 0x00FBAC90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (296149 - 58271 != 237878)
		{
		}
		for (;;)
		{
			if (!this.stHcmKnuLRN)
			{
				if (295850 - 427351 == -131501)
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
				if (241250 - 368422 != -127171)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (201779 - 333828 == -132049)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (47606 - 595501 == -547895)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (13648 - 518218 != -504569)
							{
								GUI.depth = 1;
								if (128060 - 175587 == -47527)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (1140 - 201046 != -199905)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (13669 - 457612 != -443942)
										{
											Color color = GUI.color;
											if (155729 - 523796 == -368067)
											{
												color.a = a;
												if (58815 - 399684 == -340869)
												{
													if (195905 - 54580 == 141325)
													{
														GUI.color = color;
														if (54812 - 547941 == -493129)
														{
															if (205145 - 412396 == -207251)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.stHcmKnuLRN);
																if (106087 - 300759 != -194671)
																{
																	float a2 = 1f;
																	if (33471 - 299128 == -265657)
																	{
																		Color color2 = GUI.color;
																		if (299434 - 365702 != -66267)
																		{
																			float num3 = color2.a = a2;
																			if (259096 - 2841 == 256255)
																			{
																				if (108131 - 162570 == -54439)
																				{
																					GUI.color = color2;
																					if (168934 - 526721 == -357787)
																					{
																						if (114048 - 417385 != -303336)
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

	// Token: 0x06007444 RID: 29764 RVA: 0x00FBCE10 File Offset: 0x00FBB010
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (146622 - 116324 != 30298)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (272393 - 237075 != 35319)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (231626 - 390970 != -159343)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (105952 - 382063 == -276111)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (241898 - 511335 == -269437)
						{
							int num4 = num;
							if (164606 - 72989 != 91618)
							{
								if (num4 != 2041)
								{
									break;
								}
								if (45382 - 69542 == -24160)
								{
									this.LjUcjcP5uIh++;
									if (46370 - 491713 != -445342)
									{
										Debug.Log("Bug Eliminate:" + this.LjUcjcP5uIh + "/24");
										if (267312 - 187390 == 79922)
										{
											this.SendMessage("newGameMessage", "Mission Objective: Bug Eliminated:" + this.LjUcjcP5uIh + "/24");
											if (274338 - 498867 == -224529)
											{
												Chat.SubmitChat("none", "Bug Eliminated:" + this.LjUcjcP5uIh + "/24", eChatType.system, eChatMode.system);
												if (100512 - 257636 != -157123)
												{
													if (PlayerData.UID != num3)
													{
														break;
													}
													if (200610 - 500858 != -300247)
													{
														GameObject gameObject = GameObject.Find("SpawnPoint1");
														if (206577 - 362246 == -155669)
														{
															GameObject gameObject2 = GameObject.Find("SpawnPoint2");
															if (292923 - 274633 == 18290)
															{
																GameObject gameObject3 = GameObject.Find("SpawnPoint3");
																if (281752 - 432868 == -151116)
																{
																	GameObject gameObject4 = GameObject.Find("SpawnPoint4");
																	if (141380 - 537288 == -395908)
																	{
																		GameObject gameObject5 = GameObject.Find("SpawnPoint5");
																		if (296863 - 382313 == -85450)
																		{
																			GameObject gameObject6 = GameObject.Find("SpawnPoint6");
																			if (97544 - 133453 == -35909)
																			{
																				if (this.LjUcjcP5uIh == 1)
																				{
																					if (189644 - 51416 == 138229)
																					{
																						continue;
																					}
																					if (this.zvTcj5iD0Wv < 1)
																					{
																						if (46855 - 84769 != -37914)
																						{
																							continue;
																						}
																						this.zvTcj5iD0Wv = 1;
																						if (100350 - 410240 != -309890)
																						{
																							continue;
																						}
																						this.createActor("NinjaBug_r", 6, gameObject.transform.position, gameObject.transform.forward);
																						if (145250 - 79298 != 65952)
																						{
																							continue;
																						}
																						break;
																					}
																				}
																				if (this.LjUcjcP5uIh == 2)
																				{
																					if (60004 - 512861 != -452857)
																					{
																						continue;
																					}
																					if (this.zvTcj5iD0Wv < 2)
																					{
																						if (276905 - 295462 == -18556)
																						{
																							continue;
																						}
																						this.zvTcj5iD0Wv = 2;
																						if (162069 - 114807 == 47263)
																						{
																							continue;
																						}
																						this.createActor("NinjaBug_b", 6, gameObject2.transform.position, gameObject2.transform.forward);
																						if (188719 - 185107 != 3612)
																						{
																							continue;
																						}
																						break;
																					}
																				}
																				if (this.LjUcjcP5uIh == 3)
																				{
																					if (134412 - 303425 != -169013)
																					{
																						continue;
																					}
																					if (this.zvTcj5iD0Wv < 3)
																					{
																						if (45385 - 458486 == -413100)
																						{
																							continue;
																						}
																						this.zvTcj5iD0Wv = 3;
																						if (260427 - 103627 != 156800)
																						{
																							continue;
																						}
																						this.createActor("NinjaBug_r", 6, gameObject3.transform.position, gameObject3.transform.forward);
																						if (132423 - 275932 != -143508)
																						{
																							break;
																						}
																						continue;
																					}
																				}
																				if (this.LjUcjcP5uIh == 4)
																				{
																					if (282027 - 308161 != -26134)
																					{
																						continue;
																					}
																					if (this.zvTcj5iD0Wv < 4)
																					{
																						if (95958 - 559849 == -463890)
																						{
																							continue;
																						}
																						this.zvTcj5iD0Wv = 4;
																						if (197496 - 552259 != -354763)
																						{
																							continue;
																						}
																						this.createActor("NinjaBug_k", 6, gameObject4.transform.position, gameObject4.transform.forward);
																						if (67914 - 406739 != -338825)
																						{
																							continue;
																						}
																						break;
																					}
																				}
																				if (this.LjUcjcP5uIh == 5)
																				{
																					if (272274 - 263974 == 8301)
																					{
																						continue;
																					}
																					if (this.zvTcj5iD0Wv < 5)
																					{
																						if (205858 - 592183 != -386325)
																						{
																							continue;
																						}
																						this.zvTcj5iD0Wv = 5;
																						if (67419 - 459277 != -391858)
																						{
																							continue;
																						}
																						this.createActor(this.getRandomBugType(), 6, gameObject5.transform.position, gameObject5.transform.forward);
																						if (81337 - 144859 == -63521)
																						{
																							continue;
																						}
																						this.createActor(this.getRandomBugType(), 6, gameObject6.transform.position, gameObject6.transform.forward);
																						if (129856 - 244749 != -114892)
																						{
																							break;
																						}
																						continue;
																					}
																				}
																				if (this.LjUcjcP5uIh == 8)
																				{
																					if (84873 - 214828 == -129954)
																					{
																						continue;
																					}
																					if (this.zvTcj5iD0Wv < 6)
																					{
																						if (31349 - 124432 == -93082)
																						{
																							continue;
																						}
																						this.zvTcj5iD0Wv = 6;
																						if (153140 - 365119 == -211978)
																						{
																							continue;
																						}
																						this.createActor(this.getRandomBugType(), 6, gameObject2.transform.position, gameObject2.transform.forward);
																						if (213536 - 162915 == 50622)
																						{
																							continue;
																						}
																						this.createActor(this.getRandomBugType(), 6, gameObject4.transform.position, gameObject4.transform.forward);
																						if (220262 - 418196 != -197934)
																						{
																							continue;
																						}
																						this.createActor(this.getRandomBugType(), 6, gameObject5.transform.position, gameObject5.transform.forward);
																						if (225039 - 494230 != -269191)
																						{
																							continue;
																						}
																						break;
																					}
																				}
																				if (this.LjUcjcP5uIh == 12)
																				{
																					if (2253 - 310608 == -308354)
																					{
																						continue;
																					}
																					if (this.zvTcj5iD0Wv < 7)
																					{
																						if (218727 - 512489 != -293762)
																						{
																							continue;
																						}
																						this.zvTcj5iD0Wv = 7;
																						if (215829 - 106153 == 109677)
																						{
																							continue;
																						}
																						this.createActor(this.getRandomBugType(), 6, gameObject.transform.position, gameObject.transform.forward);
																						if (225600 - 69989 != 155611)
																						{
																							continue;
																						}
																						this.createActor(this.getRandomBugType(), 6, gameObject3.transform.position, gameObject3.transform.forward);
																						if (19253 - 469606 == -450352)
																						{
																							continue;
																						}
																						this.createActor(this.getRandomBugType(), 6, gameObject5.transform.position, gameObject5.transform.forward);
																						if (174989 - 551503 != -376513)
																						{
																							break;
																						}
																						continue;
																					}
																				}
																				if (this.LjUcjcP5uIh == 14)
																				{
																					if (245623 - 519575 != -273952)
																					{
																						continue;
																					}
																					if (this.zvTcj5iD0Wv < 8)
																					{
																						if (292086 - 526836 == -234749)
																						{
																							continue;
																						}
																						this.zvTcj5iD0Wv = 8;
																						if (249879 - 502351 == -252471)
																						{
																							continue;
																						}
																						this.createActor(this.getRandomBugType(), 6, gameObject2.transform.position, gameObject2.transform.forward);
																						if (171281 - 339461 == -168179)
																						{
																							continue;
																						}
																						this.createActor(this.getRandomBugType(), 6, gameObject4.transform.position, gameObject4.transform.forward);
																						if (130566 - 422950 != -292384)
																						{
																							continue;
																						}
																						this.createActor(this.getRandomBugType(), 6, gameObject6.transform.position, gameObject6.transform.forward);
																						if (203969 - 349174 != -145205)
																						{
																							continue;
																						}
																						break;
																					}
																				}
																				if (this.LjUcjcP5uIh != 16)
																				{
																					break;
																				}
																				if (210409 - 269792 == -59383)
																				{
																					if (this.zvTcj5iD0Wv >= 9)
																					{
																						break;
																					}
																					if (97556 - 312300 != -214743)
																					{
																						this.zvTcj5iD0Wv = 9;
																						if (171504 - 142446 != 29059)
																						{
																							this.createActor("NinjaBug_r", 6, gameObject5.transform.position, gameObject5.transform.forward);
																							if (92446 - 37972 != 54475)
																							{
																								this.createActor("NinjaBug_g", 6, gameObject2.transform.position, gameObject2.transform.forward);
																								if (251357 - 300429 != -49071)
																								{
																									this.createActor("NinjaBug_b", 6, gameObject3.transform.position, gameObject3.transform.forward);
																									if (269111 - 517647 != -248535)
																									{
																										this.createActor("NinjaBug_y", 6, gameObject4.transform.position, gameObject4.transform.forward);
																										if (179332 - 217577 != -38244)
																										{
																											this.createActor("NinjaBug_k", 6, gameObject.transform.position, gameObject.transform.forward);
																											if (13010 - 404227 != -391216)
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
			}
		}
	}

	// Token: 0x06007445 RID: 29765 RVA: 0x00FBDA24 File Offset: 0x00FBBC24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string getRandomBugType()
	{
		if (142138 - 1707 != 140431)
		{
		}
		string result;
		for (;;)
		{
			int num = UnityEngine.Random.Range(0, 5);
			if (185620 - 421010 != -235389 && 240343 - 299787 != -59443)
			{
				int num2 = num;
				if (53633 - 221225 == -167592)
				{
					if (num2 == 1)
					{
						if (235285 - 452703 != -217417)
						{
							result = "NinjaBug_r";
							if (25623 - 550389 == -524766)
							{
								break;
							}
						}
					}
					else if (num2 == 2)
					{
						if (154606 - 290215 != -135608)
						{
							result = "NinjaBug_g";
							if (254037 - 94140 != 159898)
							{
								break;
							}
						}
					}
					else if (num2 == 3)
					{
						if (275402 - 23159 == 252243)
						{
							result = "NinjaBug_b";
							if (16510 - 566436 != -549925)
							{
								break;
							}
						}
					}
					else if (num2 == 4)
					{
						if (130535 - 505904 == -375369)
						{
							result = "NinjaBug_y";
							if (272971 - 359862 != -86890)
							{
								break;
							}
						}
					}
					else
					{
						result = "NinjaBug_k";
						if (140659 - 554771 == -414112)
						{
							break;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06007446 RID: 29766 RVA: 0x00FBDBF8 File Offset: 0x00FBBDF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M204_HighWayRobbery.$onGameComplete$37763(data, this).GetEnumerator();
	}

	// Token: 0x06007447 RID: 29767 RVA: 0x00FBDC08 File Offset: 0x00FBBE08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (3927 - 88640 != -84712)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (101169 - 361529 == -260360)
			{
				Hashtable customOpParameters = new Hashtable();
				if (273523 - 59099 != 214425)
				{
					this.fDVcmyqf6LH.OpCustom(52, customOpParameters, true);
					if (10763 - 379642 == -368879)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007448 RID: 29768 RVA: 0x00FBDCB0 File Offset: 0x00FBBEB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (27284 - 303518 != -276233)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (144445 - 109217 != 35229)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (46812 - 171811 == -124999)
				{
					Game.mGameState = eGameState.Setup;
					if (127119 - 507173 == -380054)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007449 RID: 29769 RVA: 0x00FBDD54 File Offset: 0x00FBBF54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (194163 - 405796 != -211633)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (170888 - 171219 != -330)
			{
				if (num == PlayerData.UID)
				{
					if (100435 - 220274 == -119839)
					{
						this.SetupActors();
						if (100249 - 382845 != -282595)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (3723 - 19944 != -16220)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600744A RID: 29770 RVA: 0x00FBDE24 File Offset: 0x00FBC024
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (16518 - 457745 != -441226)
		{
		}
		for (;;)
		{
			IL_D2:
			Debug.Log("Creating Actors");
			if (80460 - 323104 == -242644)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (165130 - 333016 != -167885)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (157949 - 154945 == 3004)
						{
							int i = 0;
							if (113528 - 382127 != -268598)
							{
								CharacterControl[] array2 = array;
								if (273912 - 332706 != -58793)
								{
									int length = array2.Length;
									if (84165 - 166934 != -82768)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (73277 - 547928 == -474650)
											{
												goto IL_D2;
											}
											if (type == "NinjaBug_g")
											{
												goto IL_1BF;
											}
											if (184608 - 374219 == -189610)
											{
												goto IL_D2;
											}
											if (type == "NinjaBug_y")
											{
												if (166037 - 195081 != -29043)
												{
													goto IL_1BF;
												}
												goto IL_D2;
											}
											IL_174:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (169954 - 188843 == -18888)
											{
												goto IL_D2;
											}
											this.BpGcjnVBdKT++;
											if (179211 - 114873 != 64338)
											{
												goto IL_D2;
											}
											i++;
											if (216698 - 176314 != 40384)
											{
												goto IL_D2;
											}
											continue;
											IL_1BF:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (50671 - 518389 != -467718)
											{
												goto IL_D2;
											}
											goto IL_174;
										}
										if (235166 - 82138 != 153029)
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
						if (46412 - 315263 == -268851)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600744B RID: 29771 RVA: 0x00FBE0C4 File Offset: 0x00FBC2C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (180119 - 262877 != -82757)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (290498 - 571347 == -280849)
			{
				int i = 0;
				if (170130 - 162513 == 7617)
				{
					CharacterControl[] array2 = array;
					if (198353 - 200730 == -2377)
					{
						int length = array2.Length;
						if (124371 - 499032 == -374661)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (182168 - 586639 != -404471)
								{
									goto IL_E0;
								}
								i++;
								if (219538 - 438413 == -218874)
								{
									goto IL_E0;
								}
							}
							if (20295 - 44796 != -24500)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600744C RID: 29772 RVA: 0x00FBE1F4 File Offset: 0x00FBC3F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (21946 - 413545 != -391599)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (234494 - 26956 != 207539)
			{
				hashtable.Add(43, PlayerData.UID);
				if (219846 - 383823 != -163976)
				{
					hashtable.Add(73, nType);
					if (178964 - 567609 == -388645)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (134495 - 192028 != -57532)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (72899 - 250306 == -177407)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (23610 - 307079 != -283468)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (229286 - 583457 == -354171)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (87164 - 475820 != -388655)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (88694 - 27495 == 61199)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (288344 - 454183 == -165839)
												{
													this.fDVcmyqf6LH.OpCustom(63, hashtable, true);
													if (198678 - 116582 != 82097)
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

	// Token: 0x0600744D RID: 29773 RVA: 0x00FBE4AC File Offset: 0x00FBC6AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (290709 - 449168 != -158459)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (222752 - 494690 == -271938)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (83679 - 221757 != -138077)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (114672 - 243593 != -128920)
						{
							if (this.BpGcjnVBdKT <= 0)
							{
								break;
							}
							if (263534 - 198900 == 64634)
							{
								this.BpGcjnVBdKT--;
								if (200589 - 214705 != -14115)
								{
									if (this.BpGcjnVBdKT != 0)
									{
										break;
									}
									if (141967 - 319355 == -177388)
									{
										Game.setGameState(eGameState.Ready);
										if (2566 - 189118 != -186551)
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
						if (215182 - 117694 == 97488)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (21018 - 217941 == -196923)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600744E RID: 29774 RVA: 0x00FBE63C File Offset: 0x00FBC83C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x0600744F RID: 29775 RVA: 0x00FBE640 File Offset: 0x00FBC840
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (79605 - 239384 != -159779)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (82628 - 274578 == -191950)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (213342 - 533337 != -319994)
				{
					if (!characterControl)
					{
						break;
					}
					if (112072 - 309038 == -196966)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (67844 - 268839 != -200994)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (291278 - 542840 != -251561)
							{
								string type = characterControl.Type;
								if (153391 - 33624 != 119768)
								{
									if (type == "NinjaBug_r")
									{
										if (19954 - 423717 == -403762)
										{
											continue;
										}
									}
									else if (type == "NinjaBug_g")
									{
										if (144495 - 195263 == -50767)
										{
											continue;
										}
									}
									else if (type == "NinjaBug_b")
									{
										if (240806 - 519806 != -279000)
										{
											continue;
										}
									}
									else if (type == "NinjaBug_y")
									{
										if (166581 - 388025 != -221444)
										{
											continue;
										}
									}
									else
									{
										if (!(type == "NinjaBug_k"))
										{
											break;
										}
										if (226141 - 292326 == -66184)
										{
											continue;
										}
									}
									IL_3F:
									Game.sendMissionEvent(2041, 0);
									if (164142 - 317129 != -152987)
									{
										continue;
									}
									break;
									IL_11C:
									goto IL_3F;
									IL_64:
									goto IL_11C;
									goto IL_64;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007450 RID: 29776 RVA: 0x00FBE874 File Offset: 0x00FBCA74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (295385 - 495421 != -200035)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (20483 - 345133 != -324649)
			{
				Game.mGameState = eGameState.Ready;
				if (5562 - 453114 != -447551)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (294663 - 16325 != 278339 && 184117 - 579702 != -395584)
					{
						GameObject gameObject;
						if (playerSlot > 1)
						{
							if (87915 - 149359 == -61443)
							{
								continue;
							}
							if (playerSlot <= 4)
							{
								if (278048 - 330016 == -51967)
								{
									continue;
								}
								gameObject = GameObject.Find("StartPoint" + playerSlot);
								if (233624 - 34242 != 199383)
								{
									goto IL_CA;
								}
								continue;
							}
						}
						gameObject = GameObject.Find("StartPoint1");
						if (143350 - 219852 != -76502)
						{
							continue;
						}
						IL_CA:
						if (!gameObject)
						{
							break;
						}
						if (172630 - 267666 == -95036)
						{
							this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
							if (147700 - 339425 != -191724)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007451 RID: 29777 RVA: 0x00FBEA34 File Offset: 0x00FBCC34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M204_HighWayRobbery.$StartGame$37772(this).GetEnumerator();
	}

	// Token: 0x06007452 RID: 29778 RVA: 0x00FBEA44 File Offset: 0x00FBCC44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06007453 RID: 29779 RVA: 0x00FBEA48 File Offset: 0x00FBCC48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (190034 - 228914 != -38880)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (126204 - 310377 != -184172)
			{
				hashtable.Add(71, CID);
				if (286817 - 41900 == 244917)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (238645 - 148618 == 90027)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (5767 - 546113 != -540345)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (229638 - 358425 == -128787)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (219510 - 492255 != -272744)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (274630 - 502322 != -227691)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (2650 - 90538 != -87887)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (198898 - 419323 != -220424)
											{
												this.fDVcmyqf6LH.OpCustom(61, hashtable, true);
												if (135861 - 24591 == 111270)
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

	// Token: 0x06007454 RID: 29780 RVA: 0x00FBECD4 File Offset: 0x00FBCED4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (31142 - 593865 != -562723)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (112693 - 525340 != -412646)
			{
				if (!gameObject)
				{
					break;
				}
				if (37141 - 109799 != -72657)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (39608 - 421786 == -382178)
					{
						playerCameraControl.target = gameObject;
						if (160780 - 482748 != -321967)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (18335 - 40472 == -22137)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007455 RID: 29781 RVA: 0x00FBEDCC File Offset: 0x00FBCFCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (230183 - 339129 != -108945)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (176435 - 113091 == 63344)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (149316 - 374041 != -224724)
				{
					gameGui.ResetTeamBar();
					if (25692 - 146442 == -120750)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007456 RID: 29782 RVA: 0x00FBEE78 File Offset: 0x00FBD078
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (21046 - 292142 != -271096)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (262407 - 234237 == 28170)
			{
				CharacterControl characterControl = null;
				if (177239 - 49090 != 128150)
				{
					if (mPlayer)
					{
						if (210057 - 490507 != -280450)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (63347 - 286144 == -222796)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (53829 - 247904 == -194075)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (248873 - 308624 == -59751)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (192 - 106530 == -106338)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (196328 - 546703 != -350375)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (299841 - 70202 == 229640)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (107219 - 185021 != -77802)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (96422 - 588468 != -492046)
									{
										continue;
									}
									break;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (84643 - 85415 != -771)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (112932 - 592389 != -479456)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (194193 - 128447 != 65747)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (102591 - 155958 == -53367)
								{
									if (!changeGui)
									{
										break;
									}
									if (296726 - 565592 != -268865)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (151845 - 515257 != -363412)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (279552 - 579288 != -299736)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (79427 - 461694 == -382267)
										{
											gameGui.close();
											if (193304 - 524796 != -331491)
											{
												changeGui.enabled = true;
												if (142731 - 291365 == -148634)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (48108 - 115364 == -67256)
													{
														if (!gameObject)
														{
															break;
														}
														if (239923 - 321060 == -81137)
														{
															if (!mPlayer)
															{
																break;
															}
															if (171433 - 446662 != -275228)
															{
																Debug.Log("UseLifeAltar");
																if (47547 - 544017 == -496470)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (7621 - 434671 == -427050)
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

	// Token: 0x06007457 RID: 29783 RVA: 0x00FBF2D8 File Offset: 0x00FBD4D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M204_HighWayRobbery.$onDeadPlayer$37776(this).GetEnumerator();
	}

	// Token: 0x06007458 RID: 29784 RVA: 0x00FBF2E8 File Offset: 0x00FBD4E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (269408 - 50716 != 218692)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (31479 - 498669 != -467189)
			{
				this.ql8cmVo1a2s.target = Game.mPlayer;
				if (45447 - 513269 == -467822)
				{
					this.ql8cmVo1a2s.enabled = true;
					if (30179 - 297922 != -267742)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (58767 - 104508 == -45740)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (88406 - 203531 != -115125)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (61360 - 587393 == -526033)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (55073 - 583320 != -528246)
							{
								if (!gameGui)
								{
									break;
								}
								if (33081 - 461660 == -428579)
								{
									gameGui.enabled = true;
									if (161773 - 154527 != 7247)
									{
										gameGui.closeDeadMenu();
										if (255498 - 33957 != 221542)
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

	// Token: 0x06007459 RID: 29785 RVA: 0x00FBF494 File Offset: 0x00FBD694
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (210890 - 22429 != 188462)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (7602 - 58911 != -51308)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (214337 - 204741 == 9596)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (32119 - 360632 != -328512)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600745A RID: 29786 RVA: 0x00FBF558 File Offset: 0x00FBD758
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600745B RID: 29787 RVA: 0x00FBF584 File Offset: 0x00FBD784
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M204_HighWayRobbery.$ReturnToTown$37782(this).GetEnumerator();
	}

	// Token: 0x0600745C RID: 29788 RVA: 0x00FBF594 File Offset: 0x00FBD794
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M204_HighWayRobbery.$ReturnToGuild$37787(this).GetEnumerator();
	}

	// Token: 0x0600745D RID: 29789 RVA: 0x00FBF5A4 File Offset: 0x00FBD7A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M204_HighWayRobbery.$ReturnToCamp$37791(this).GetEnumerator();
	}

	// Token: 0x0600745E RID: 29790 RVA: 0x00FBF5B4 File Offset: 0x00FBD7B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (116348 - 466714 != -350366)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (26404 - 120716 != -94311)
			{
				Hashtable hashtable = new Hashtable();
				if (243565 - 357004 == -113439)
				{
					hashtable.Add(43, PlayerData.UID);
					if (253795 - 400530 == -146735)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (16091 - 164590 == -148499)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600745F RID: 29791 RVA: 0x00FBF68C File Offset: 0x00FBD88C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06007460 RID: 29792 RVA: 0x00FBF6A0 File Offset: 0x00FBD8A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (249100 - 311263 != -62162)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (44778 - 274307 == -229529)
			{
				Hashtable hashtable = new Hashtable();
				if (52015 - 387121 == -335106)
				{
					if (Game.mNextGameCode == 30)
					{
						if (102101 - 230270 != -128169)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (16191 - 206745 != -190554)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (255838 - 224938 != 30900)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (103565 - 10630 != 92935)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (274978 - 414286 != -139308)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (147164 - 391038 != -243874)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (191610 - 289407 == -97796)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (24401 - 433935 == -409533)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (8563 - 318101 == -309537)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (120263 - 54428 == 65836)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (160580 - 41992 == 118589)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (260399 - 254928 != 5471)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (266096 - 350198 == -84101)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (219498 - 498069 != -278571)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (100730 - 372211 == -271480)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (75711 - 417232 == -341520)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (110879 - 458946 == -348066)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (283602 - 154767 == 128836)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (155170 - 281355 == -126184)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (113430 - 409853 == -296422)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (198703 - 344707 != -146004)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (109755 - 333648 != -223893)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (151592 - 358092 != -206500)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (221044 - 530471 != -309427)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (69391 - 281567 == -212175)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (247865 - 220977 == 26889)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (41154 - 546844 == -505689)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (122764 - 432530 != -309766)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (207934 - 474999 == -267065)
					{
						this.fDVcmyqf6LH.OpCustom(42, hashtable, true);
						if (18798 - 75863 != -57064)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007461 RID: 29793 RVA: 0x00FBFC54 File Offset: 0x00FBDE54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06007462 RID: 29794 RVA: 0x00FBFC64 File Offset: 0x00FBDE64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06007463 RID: 29795 RVA: 0x00FBFC68 File Offset: 0x00FBDE68
	internal static bool aIZDJQpKgGFZs9dO76Pe()
	{
		return true;
	}

	// Token: 0x06007464 RID: 29796 RVA: 0x00FBFC6C File Offset: 0x00FBDE6C
	internal static bool KtY98XpKfC4LpjXrPGfm()
	{
		return false;
	}

	// Token: 0x04007989 RID: 31113
	private LitePeer fDVcmyqf6LH;

	// Token: 0x0400798A RID: 31114
	private PlayerCameraControl ql8cmVo1a2s;

	// Token: 0x0400798B RID: 31115
	private float Jrrcmhnt8ay;

	// Token: 0x0400798C RID: 31116
	private Texture stHcmKnuLRN;

	// Token: 0x0400798D RID: 31117
	private AudioClip gBLcmztYvWl;

	// Token: 0x0400798E RID: 31118
	private int zvTcj5iD0Wv;

	// Token: 0x0400798F RID: 31119
	private int LjUcjcP5uIh;

	// Token: 0x04007990 RID: 31120
	private int BpGcjnVBdKT;

	// Token: 0x020013B0 RID: 5040
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$37763 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007465 RID: 29797 RVA: 0x00FBFC70 File Offset: 0x00FBDE70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$37763(Hashtable data, M204_HighWayRobbery self_)
		{
			if (111365 - 586544 != -475178)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (243917 - 487328 == -243411)
				{
					base..ctor();
					if (67773 - 481310 != -413536)
					{
						this.$data$37770 = data;
						if (252616 - 161938 != 90679)
						{
							this.$self_$37771 = self_;
							if (192217 - 574951 != -382733)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007466 RID: 29798 RVA: 0x00FBFD2C File Offset: 0x00FBDF2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M204_HighWayRobbery.$onGameComplete$37763.$(this.$data$37770, this.$self_$37771);
		}

		// Token: 0x06007467 RID: 29799 RVA: 0x00FBFD40 File Offset: 0x00FBDF40
		internal static bool ViHQ1vpKnlO4aGsFIBfh()
		{
			return true;
		}

		// Token: 0x06007468 RID: 29800 RVA: 0x00FBFD44 File Offset: 0x00FBDF44
		internal static bool agbTvhpK63iiDjyRmMTF()
		{
			return false;
		}

		// Token: 0x04007991 RID: 31121
		internal Hashtable $data$37770;

		// Token: 0x04007992 RID: 31122
		internal M204_HighWayRobbery $self_$37771;

		// Token: 0x020013B1 RID: 5041
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007469 RID: 29801 RVA: 0x00FBFD48 File Offset: 0x00FBDF48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M204_HighWayRobbery self_)
			{
				if (58845 - 282295 != -223450)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (141697 - 595151 != -453453)
					{
						base..ctor();
						if (209265 - 364750 != -155484)
						{
							this.$data$37768 = data;
							if (72517 - 63315 != 9203)
							{
								this.$self_$37769 = self_;
								if (34578 - 105202 == -70624)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600746A RID: 29802 RVA: 0x00FBFE04 File Offset: 0x00FBE004
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (207837 - 295128 != -87290)
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
						this.$mCompleteGui$37765 = (CompleteGui)this.$self_$37769.GetComponent(typeof(CompleteGui));
						if (22386 - 232750 == -210363)
						{
							continue;
						}
						this.$mCompleteGui$37765.Init();
						if (150457 - 150300 == 158)
						{
							continue;
						}
						this.$mCompleteGui$37765.readData(this.$data$37768);
						if (234326 - 208224 == 26103)
						{
							continue;
						}
						if (this.$result$37764 == 1)
						{
							if (40318 - 186180 == -145861)
							{
								continue;
							}
							this.$mCompleteGui$37765.displayResult(eCompleteType.Success);
							if (201733 - 418738 != -217005)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$37765.displayResult(eCompleteType.Failed);
							if (253846 - 222440 != 31406)
							{
								continue;
							}
						}
						this.$mGameGui$37766 = (GameGui)this.$self_$37769.GetComponent(typeof(GameGui));
						if (193624 - 340515 != -146891)
						{
							continue;
						}
						this.$mStoryGui$37767 = (StoryGui)this.$self_$37769.GetComponent(typeof(StoryGui));
						if (145269 - 41865 != 103404)
						{
							continue;
						}
						if (this.$mGameGui$37766)
						{
							if (253474 - 53843 != 199631)
							{
								continue;
							}
							this.$mGameGui$37766.close();
							if (84370 - 595176 != -510806)
							{
								continue;
							}
						}
						if (this.$mStoryGui$37767)
						{
							if (37502 - 374035 == -336532)
							{
								continue;
							}
							this.$mStoryGui$37767.close();
							if (170962 - 417642 != -246680)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (166947 - 10243 != 156704)
						{
							continue;
						}
						goto IL_352;
					default:
						if (285 - 242516 != -242231)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$37768[31]);
					if (195441 - 200512 != -5070)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (235662 - 209975 == 25687)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (224773 - 448222 != -223448)
							{
								this.$result$37764 = RuntimeServices.UnboxInt32(this.$data$37768[31]);
								if (252634 - 69748 != 182887)
								{
									goto Block_5;
								}
							}
						}
					}
				}
				goto IL_352;
				Block_5:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x0600746B RID: 29803 RVA: 0x00FC0178 File Offset: 0x00FBE378
			internal static bool C3eKikpKinQwEBqdSHxb()
			{
				return true;
			}

			// Token: 0x0600746C RID: 29804 RVA: 0x00FC017C File Offset: 0x00FBE37C
			internal static bool EBQ6iUpKKxMnNHO1xaEc()
			{
				return false;
			}

			// Token: 0x04007993 RID: 31123
			internal int $result$37764;

			// Token: 0x04007994 RID: 31124
			internal CompleteGui $mCompleteGui$37765;

			// Token: 0x04007995 RID: 31125
			internal GameGui $mGameGui$37766;

			// Token: 0x04007996 RID: 31126
			internal StoryGui $mStoryGui$37767;

			// Token: 0x04007997 RID: 31127
			internal Hashtable $data$37768;

			// Token: 0x04007998 RID: 31128
			internal M204_HighWayRobbery $self_$37769;
		}
	}

	// Token: 0x020013B2 RID: 5042
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$37772 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600746D RID: 29805 RVA: 0x00FC0180 File Offset: 0x00FBE380
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$37772(M204_HighWayRobbery self_)
		{
			if (117704 - 589139 != -471435)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (71775 - 523782 == -452007)
				{
					base..ctor();
					if (170054 - 189947 == -19893)
					{
						this.$self_$37775 = self_;
						if (62387 - 159327 != -96939)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600746E RID: 29806 RVA: 0x00FC0218 File Offset: 0x00FBE418
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M204_HighWayRobbery.$StartGame$37772.$(this.$self_$37775);
		}

		// Token: 0x0600746F RID: 29807 RVA: 0x00FC0228 File Offset: 0x00FBE428
		internal static bool NPt8abpKdmWvpS0F23s4()
		{
			return true;
		}

		// Token: 0x06007470 RID: 29808 RVA: 0x00FC022C File Offset: 0x00FBE42C
		internal static bool XCwqMhpKJP00WugQqtXO()
		{
			return false;
		}

		// Token: 0x04007999 RID: 31129
		internal M204_HighWayRobbery $self_$37775;

		// Token: 0x020013B3 RID: 5043
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007471 RID: 29809 RVA: 0x00FC0230 File Offset: 0x00FBE430
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M204_HighWayRobbery self_)
			{
				if (139237 - 566880 != -427643)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (91826 - 449806 == -357980)
					{
						base..ctor();
						if (73462 - 411548 == -338086)
						{
							this.$self_$37774 = self_;
							if (156847 - 138840 != 18008)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007472 RID: 29810 RVA: 0x00FC02C8 File Offset: 0x00FBE4C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (275557 - 230052 != 45505)
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
						this.$mGameGui$37773 = (GameGui)this.$self_$37774.GetComponent(typeof(GameGui));
						if (18802 - 12760 == 6043)
						{
							continue;
						}
						this.$mGameGui$37773.enabled = true;
						if (227660 - 321743 == -94082)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (176434 - 298175 == -121740)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (158905 - 236754 != -77849)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (298018 - 418855 != -120837)
						{
							continue;
						}
						if (this.$self_$37774.gBLcmztYvWl)
						{
							if (100354 - 492293 != -391939)
							{
								continue;
							}
							this.$self_$37774.audio.PlayOneShot(this.$self_$37774.gBLcmztYvWl);
							if (295800 - 443033 != -147233)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (281229 - 165598 != 115632)
						{
							goto Block_13;
						}
						continue;
					default:
						if (146277 - 425378 == -279100)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (120869 - 332025 == -211156)
					{
						Game.mGameState = eGameState.Start;
						if (233581 - 309267 == -75686)
						{
							Game.mStateTime = Time.time;
							if (112524 - 121836 != -9311)
							{
								this.$self_$37774.SendMessage("fadeIn");
								if (273924 - 380530 != -106605)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_13:
				IL_241:
				return false;
			}

			// Token: 0x06007473 RID: 29811 RVA: 0x00FC0528 File Offset: 0x00FBE728
			internal static bool a2FMKbpKDYfrvGhk7TnZ()
			{
				return true;
			}

			// Token: 0x06007474 RID: 29812 RVA: 0x00FC052C File Offset: 0x00FBE72C
			internal static bool mQRFaepKvmWOkFK9hZZG()
			{
				return false;
			}

			// Token: 0x0400799A RID: 31130
			internal GameGui $mGameGui$37773;

			// Token: 0x0400799B RID: 31131
			internal M204_HighWayRobbery $self_$37774;
		}
	}

	// Token: 0x020013B4 RID: 5044
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$37776 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007475 RID: 29813 RVA: 0x00FC0530 File Offset: 0x00FBE730
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$37776(M204_HighWayRobbery self_)
		{
			if (37924 - 171386 != -133462)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (43498 - 534364 != -490865)
				{
					base..ctor();
					if (130139 - 432541 == -302402)
					{
						this.$self_$37781 = self_;
						if (276590 - 548342 == -271752)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007476 RID: 29814 RVA: 0x00FC05C8 File Offset: 0x00FBE7C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M204_HighWayRobbery.$onDeadPlayer$37776.$(this.$self_$37781);
		}

		// Token: 0x06007477 RID: 29815 RVA: 0x00FC05D8 File Offset: 0x00FBE7D8
		internal static bool XWuvFipKRoiqbPhyhEwu()
		{
			return true;
		}

		// Token: 0x06007478 RID: 29816 RVA: 0x00FC05DC File Offset: 0x00FBE7DC
		internal static bool rDO5ohpKw8DU9lZiku3b()
		{
			return false;
		}

		// Token: 0x0400799C RID: 31132
		internal M204_HighWayRobbery $self_$37781;

		// Token: 0x020013B5 RID: 5045
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007479 RID: 29817 RVA: 0x00FC05E0 File Offset: 0x00FBE7E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M204_HighWayRobbery self_)
			{
				if (81908 - 119675 != -37766)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (249636 - 434293 == -184657)
					{
						base..ctor();
						if (167888 - 272021 == -104133)
						{
							this.$self_$37780 = self_;
							if (246467 - 155538 == 90929)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600747A RID: 29818 RVA: 0x00FC0678 File Offset: 0x00FBE878
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (184448 - 484522 != -300074)
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
						if (Game.mGameState == eGameState.Normal)
						{
							goto IL_1AB;
						}
						if (44212 - 313150 != -268938)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (28769 - 558401 != -529632)
							{
								continue;
							}
							goto IL_1AB;
						}
						IL_3F:
						this.YieldDefault(1);
						if (151052 - 34820 != 116233)
						{
							goto Block_3;
						}
						continue;
						IL_1AB:
						Game.mGameState = eGameState.Hold;
						if (256216 - 389476 != -133260)
						{
							continue;
						}
						this.$mStoryGui$37777 = (StoryGui)this.$self_$37780.GetComponent(typeof(StoryGui));
						if (177414 - 204060 == -26645)
						{
							continue;
						}
						if (this.$mStoryGui$37777)
						{
							if (107892 - 560392 != -452500)
							{
								continue;
							}
							this.$mStoryGui$37777.close();
							if (75009 - 352037 == -277027)
							{
								continue;
							}
						}
						this.$mChangeGui$37778 = (ChangeGui)this.$self_$37780.GetComponent(typeof(ChangeGui));
						if (230598 - 349752 != -119154)
						{
							continue;
						}
						if (this.$mChangeGui$37778)
						{
							if (111606 - 381175 != -269569)
							{
								continue;
							}
							this.$mChangeGui$37778.close();
							if (148592 - 467237 != -318645)
							{
								continue;
							}
						}
						this.$mGameGui$37779 = (GameGui)this.$self_$37780.GetComponent(typeof(GameGui));
						if (127730 - 278124 == -150393)
						{
							continue;
						}
						if (!this.$mGameGui$37779)
						{
							goto IL_3F;
						}
						if (198944 - 140982 == 57963)
						{
							continue;
						}
						if (!this.$mGameGui$37779.enabled)
						{
							if (257832 - 197071 == 60762)
							{
								continue;
							}
							this.$mGameGui$37779.enabled = true;
							if (287252 - 23523 == 263730)
							{
								continue;
							}
						}
						this.$mGameGui$37779.openDeadMenu();
						if (118787 - 249671 != -130884)
						{
							continue;
						}
						goto IL_3F;
					default:
						if (68023 - 329782 != -261759)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (254073 - 308997 == -54924)
					{
						goto IL_86;
					}
				}
				Block_3:
				goto IL_2F9;
				IL_86:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600747B RID: 29819 RVA: 0x00FC0990 File Offset: 0x00FBEB90
			internal static bool yOdUpEpKqqUKn4sLrqK8()
			{
				return true;
			}

			// Token: 0x0600747C RID: 29820 RVA: 0x00FC0994 File Offset: 0x00FBEB94
			internal static bool BeyoLapK7h4Zg2GX7upR()
			{
				return false;
			}

			// Token: 0x0400799D RID: 31133
			internal StoryGui $mStoryGui$37777;

			// Token: 0x0400799E RID: 31134
			internal ChangeGui $mChangeGui$37778;

			// Token: 0x0400799F RID: 31135
			internal GameGui $mGameGui$37779;

			// Token: 0x040079A0 RID: 31136
			internal M204_HighWayRobbery $self_$37780;
		}
	}

	// Token: 0x020013B6 RID: 5046
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$37782 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600747D RID: 29821 RVA: 0x00FC0998 File Offset: 0x00FBEB98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$37782(M204_HighWayRobbery self_)
		{
			if (164895 - 3927 != 160969)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (158780 - 440373 != -281592)
				{
					base..ctor();
					if (151667 - 577948 == -426281)
					{
						this.$self_$37786 = self_;
						if (182449 - 282808 != -100358)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600747E RID: 29822 RVA: 0x00FC0A30 File Offset: 0x00FBEC30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M204_HighWayRobbery.$ReturnToTown$37782.$(this.$self_$37786);
		}

		// Token: 0x0600747F RID: 29823 RVA: 0x00FC0A40 File Offset: 0x00FBEC40
		internal static bool A1SNCbpKPHCmcS8tDGM5()
		{
			return true;
		}

		// Token: 0x06007480 RID: 29824 RVA: 0x00FC0A44 File Offset: 0x00FBEC44
		internal static bool sVymNwpK09p5FJN6JiE2()
		{
			return false;
		}

		// Token: 0x040079A1 RID: 31137
		internal M204_HighWayRobbery $self_$37786;

		// Token: 0x020013B7 RID: 5047
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007481 RID: 29825 RVA: 0x00FC0A48 File Offset: 0x00FBEC48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M204_HighWayRobbery self_)
			{
				if (26065 - 250340 != -224274)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (112418 - 431459 != -319040)
					{
						base..ctor();
						if (193599 - 324700 == -131101)
						{
							this.$self_$37785 = self_;
							if (105898 - 215421 == -109523)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007482 RID: 29826 RVA: 0x00FC0AE0 File Offset: 0x00FBECE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (283092 - 168768 != 114325)
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
						this.$self_$37785.LeaveGame();
						if (225099 - 353077 != -127978)
						{
							continue;
						}
						this.YieldDefault(1);
						if (39123 - 183699 != -144576)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (103151 - 138590 != -35439)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (209068 - 460700 != -251631)
					{
						Game.mStateTime = Time.time;
						if (27440 - 357067 == -329627)
						{
							this.$$switch$6462$37783 = PlayerData.SaveGuild;
							if (262011 - 366149 == -104138)
							{
								if (this.$$switch$6462$37783 == 1)
								{
									if (94019 - 89650 != 4369)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (133681 - 573695 == -440013)
									{
										continue;
									}
								}
								else if (this.$$switch$6462$37783 == 2)
								{
									if (41494 - 469029 != -427535)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (276084 - 330099 == -54014)
									{
										continue;
									}
								}
								else if (this.$$switch$6462$37783 == 3)
								{
									if (115166 - 122140 != -6974)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (124729 - 137742 == -13012)
									{
										continue;
									}
								}
								else if (this.$$switch$6462$37783 == 4)
								{
									if (81044 - 198433 != -117389)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (214365 - 412621 == -198255)
									{
										continue;
									}
								}
								else if (this.$$switch$6462$37783 == 5)
								{
									if (205719 - 296805 != -91086)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (86808 - 310003 != -223195)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (131126 - 435485 != -304359)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (77191 - 16298 == 60894)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (38731 - 349380 != -310649)
									{
										continue;
									}
								}
								this.$mGameGui$37784 = (GameGui)this.$self_$37785.GetComponent(typeof(GameGui));
								if (108093 - 65223 != 42871)
								{
									if (this.$mGameGui$37784)
									{
										if (200445 - 66123 == 134323)
										{
											continue;
										}
										this.$mGameGui$37784.close();
										if (173988 - 221989 != -48001)
										{
											continue;
										}
									}
									this.$self_$37785.SendMessage("fadeOut");
									if (32416 - 180501 == -148085)
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

			// Token: 0x06007483 RID: 29827 RVA: 0x00FC0EAC File Offset: 0x00FBF0AC
			internal static bool A39kTHpKbxdnuCFiNVBq()
			{
				return true;
			}

			// Token: 0x06007484 RID: 29828 RVA: 0x00FC0EB0 File Offset: 0x00FBF0B0
			internal static bool OAby6spKumJgqOXZRvAa()
			{
				return false;
			}

			// Token: 0x040079A2 RID: 31138
			internal int $$switch$6462$37783;

			// Token: 0x040079A3 RID: 31139
			internal GameGui $mGameGui$37784;

			// Token: 0x040079A4 RID: 31140
			internal M204_HighWayRobbery $self_$37785;
		}
	}

	// Token: 0x020013B8 RID: 5048
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$37787 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007485 RID: 29829 RVA: 0x00FC0EB4 File Offset: 0x00FBF0B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$37787(M204_HighWayRobbery self_)
		{
			if (41864 - 304929 != -263065)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (67104 - 491821 == -424717)
				{
					base..ctor();
					if (206316 - 337567 == -131251)
					{
						this.$self_$37790 = self_;
						if (106953 - 371766 == -264813)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007486 RID: 29830 RVA: 0x00FC0F4C File Offset: 0x00FBF14C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M204_HighWayRobbery.$ReturnToGuild$37787.$(this.$self_$37790);
		}

		// Token: 0x06007487 RID: 29831 RVA: 0x00FC0F5C File Offset: 0x00FBF15C
		internal static bool VjXV7WpKIc8605dCiq83()
		{
			return true;
		}

		// Token: 0x06007488 RID: 29832 RVA: 0x00FC0F60 File Offset: 0x00FBF160
		internal static bool gNampfpKBRa6w0Pf5eVQ()
		{
			return false;
		}

		// Token: 0x040079A5 RID: 31141
		internal M204_HighWayRobbery $self_$37790;

		// Token: 0x020013B9 RID: 5049
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007489 RID: 29833 RVA: 0x00FC0F64 File Offset: 0x00FBF164
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M204_HighWayRobbery self_)
			{
				if (268687 - 202373 != 66315)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (265230 - 140205 != 125026)
					{
						base..ctor();
						if (80811 - 5826 == 74985)
						{
							this.$self_$37789 = self_;
							if (243792 - 133054 == 110738)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600748A RID: 29834 RVA: 0x00FC0FFC File Offset: 0x00FBF1FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (185589 - 26043 != 159547)
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
						this.$self_$37789.LeaveGame();
						if (88381 - 492267 != -403886)
						{
							continue;
						}
						this.YieldDefault(1);
						if (266009 - 564710 != -298700)
						{
							goto Block_4;
						}
						continue;
					default:
						if (257101 - 412854 == -155752)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (163350 - 276266 != -112915)
					{
						Game.mStateTime = Time.time;
						if (228577 - 251327 == -22750)
						{
							Game.mNextGameCode = 31;
							if (253445 - 265586 == -12141)
							{
								this.$mGameGui$37788 = (GameGui)this.$self_$37789.GetComponent(typeof(GameGui));
								if (201179 - 157339 == 43840)
								{
									if (this.$mGameGui$37788)
									{
										if (107028 - 342230 != -235202)
										{
											continue;
										}
										this.$mGameGui$37788.close();
										if (160350 - 278733 != -118383)
										{
											continue;
										}
									}
									this.$self_$37789.SendMessage("fadeOut");
									if (232817 - 541746 == -308929)
									{
										goto IL_136;
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_1BD;
				IL_136:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600748B RID: 29835 RVA: 0x00FC11D8 File Offset: 0x00FBF3D8
			internal static bool L8lxcVpKeTCQbdstmZxX()
			{
				return true;
			}

			// Token: 0x0600748C RID: 29836 RVA: 0x00FC11DC File Offset: 0x00FBF3DC
			internal static bool TVyreYpKrh95BoIaGmJc()
			{
				return false;
			}

			// Token: 0x040079A6 RID: 31142
			internal GameGui $mGameGui$37788;

			// Token: 0x040079A7 RID: 31143
			internal M204_HighWayRobbery $self_$37789;
		}
	}

	// Token: 0x020013BA RID: 5050
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$37791 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600748D RID: 29837 RVA: 0x00FC11E0 File Offset: 0x00FBF3E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$37791(M204_HighWayRobbery self_)
		{
			if (129569 - 207846 != -78276)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (226906 - 94232 != 132675)
				{
					base..ctor();
					if (287263 - 115633 != 171631)
					{
						this.$self_$37795 = self_;
						if (161199 - 263340 == -102141)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600748E RID: 29838 RVA: 0x00FC1278 File Offset: 0x00FBF478
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M204_HighWayRobbery.$ReturnToCamp$37791.$(this.$self_$37795);
		}

		// Token: 0x0600748F RID: 29839 RVA: 0x00FC1288 File Offset: 0x00FBF488
		internal static bool arVJnJpKjkURIgDMgdBE()
		{
			return true;
		}

		// Token: 0x06007490 RID: 29840 RVA: 0x00FC128C File Offset: 0x00FBF48C
		internal static bool kDWkc4pKhDOOGamtq0TJ()
		{
			return false;
		}

		// Token: 0x040079A8 RID: 31144
		internal M204_HighWayRobbery $self_$37795;

		// Token: 0x020013BB RID: 5051
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007491 RID: 29841 RVA: 0x00FC1290 File Offset: 0x00FBF490
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M204_HighWayRobbery self_)
			{
				if (121643 - 47946 != 73697)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (23663 - 57031 == -33368)
					{
						base..ctor();
						if (197012 - 128307 == 68705)
						{
							this.$self_$37794 = self_;
							if (183048 - 460458 == -277410)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007492 RID: 29842 RVA: 0x00FC1328 File Offset: 0x00FBF528
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (217923 - 241479 != -23556)
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
						this.$self_$37794.LeaveGame();
						if (23542 - 225461 != -201919)
						{
							continue;
						}
						this.YieldDefault(1);
						if (170257 - 119766 != 50491)
						{
							continue;
						}
						goto IL_363;
					default:
						if (102584 - 222351 == -119766)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (172501 - 348491 != -175989)
					{
						Game.mStateTime = Time.time;
						if (177974 - 373558 != -195583)
						{
							this.$$switch$6464$37792 = PlayerData.SaveGuild;
							if (132348 - 74723 == 57625)
							{
								if (this.$$switch$6464$37792 == 1)
								{
									if (234154 - 471490 != -237336)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (63321 - 333732 != -270411)
									{
										continue;
									}
								}
								else if (this.$$switch$6464$37792 == 2)
								{
									if (99926 - 93667 == 6260)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (129271 - 46210 != 83061)
									{
										continue;
									}
								}
								else if (this.$$switch$6464$37792 == 3)
								{
									if (186438 - 330414 != -143976)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (231585 - 362826 == -131240)
									{
										continue;
									}
								}
								else if (this.$$switch$6464$37792 == 4)
								{
									if (95754 - 228375 != -132621)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (234336 - 134063 != 100273)
									{
										continue;
									}
								}
								else if (this.$$switch$6464$37792 == 5)
								{
									if (245917 - 398692 != -152775)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (45071 - 137048 == -91976)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (175186 - 68635 == 106552)
									{
										continue;
									}
								}
								this.$mGameGui$37793 = (GameGui)this.$self_$37794.GetComponent(typeof(GameGui));
								if (174958 - 566429 == -391471)
								{
									if (this.$mGameGui$37793)
									{
										if (6217 - 567789 != -561572)
										{
											continue;
										}
										this.$mGameGui$37793.close();
										if (225167 - 429492 == -204324)
										{
											continue;
										}
									}
									this.$self_$37794.SendMessage("fadeOut");
									if (120860 - 308220 != -187359)
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

			// Token: 0x06007493 RID: 29843 RVA: 0x00FC16AC File Offset: 0x00FBF8AC
			internal static bool rsuTpHpKsQPC8mLF4krj()
			{
				return true;
			}

			// Token: 0x06007494 RID: 29844 RVA: 0x00FC16B0 File Offset: 0x00FBF8B0
			internal static bool wGivN9pK9msYK70xtpZa()
			{
				return false;
			}

			// Token: 0x040079A9 RID: 31145
			internal int $$switch$6464$37792;

			// Token: 0x040079AA RID: 31146
			internal GameGui $mGameGui$37793;

			// Token: 0x040079AB RID: 31147
			internal M204_HighWayRobbery $self_$37794;
		}
	}
}
