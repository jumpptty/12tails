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

// Token: 0x02001827 RID: 6183
[Serializable]
public class M902_MadVegetables : MonoBehaviour
{
	// Token: 0x06008FDF RID: 36831 RVA: 0x01168158 File Offset: 0x01166358
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M902_MadVegetables()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06008FE0 RID: 36832 RVA: 0x01168168 File Offset: 0x01166368
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (140642 - 457448 != -316805)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (105824 - 141358 != -35533)
			{
				Game.mGameType = 5;
				if (23991 - 81726 == -57735)
				{
					if (Chat.Initialized)
					{
						if (171920 - 184374 == -12454)
						{
							Chat.ChatDisplay.Clear();
							if (175426 - 382259 == -206833)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (205884 - 394578 == -188694)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008FE1 RID: 36833 RVA: 0x0116824C File Offset: 0x0116644C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (61849 - 414342 != -352492)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (178122 - 362042 == -183920)
				{
					if (Game.mNextGameCode != 902)
					{
						break;
					}
					if (41416 - 185095 != -143678)
					{
						Game.nextGame();
						if (85538 - 502845 != -417306)
						{
							Game.mGameCode = 902;
							if (37212 - 390387 != -353174)
							{
								Game.mGameType = 5;
								if (113161 - 281139 != -167977)
								{
									Game.mGameTime = Time.time;
									if (87764 - 398225 != -310460)
									{
										Game.mGameScore = 0;
										if (279000 - 315171 != -36170)
										{
											Game.mGameMana = 0;
											if (169779 - 515261 != -345481)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (135120 - 537773 == -402653)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (141398 - 240003 == -98605)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (69221 - 13989 != 55233)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (142426 - 484788 != -342361)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (156678 - 414412 != -257733)
																{
																	this.Ub4n5aWEuNl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (277503 - 563149 == -285646)
																	{
																		this.tByn5gEptP4 = PhotonClient.Connection;
																		if (125547 - 551203 == -425656)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (214103 - 487142 != -273038)
																			{
																				this.InitGame();
																				if (299171 - 500530 != -201358)
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
				if (14869 - 384459 == -369590)
				{
					Game.mGameType = 99;
					if (118676 - 552846 != -434169)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008FE2 RID: 36834 RVA: 0x01168554 File Offset: 0x01166754
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (62783 - 130133 != -67349)
		{
		}
		for (;;)
		{
			if (this.tByn5gEptP4 == null)
			{
				if (294840 - 204658 == 90182)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (85358 - 272539 != -187180)
				{
					if (mGameState == eGameState.Init)
					{
						if (99786 - 400937 == -301151)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (226177 - 376491 == -150314)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (157349 - 180216 == -22867)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (248193 - 299019 == -50826)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (151491 - 12483 != 139009)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (144955 - 496974 == -352019)
						{
							if (Game.music != 0)
							{
								if (138130 - 373012 == -234881)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (282339 - 290964 == -8624)
									{
										continue;
									}
									this.audio.Play();
									if (1927 - 304339 != -302412)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (168462 - 391491 != -223029)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (66276 - 447276 != -381000)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (297486 - 423928 == -126441)
								{
									continue;
								}
							}
							if (Time.time <= this.asMn548HeII)
							{
								break;
							}
							if (290319 - 518250 == -227931)
							{
								Game.mGameMana++;
								if (145512 - 227618 != -82105)
								{
									this.asMn548HeII = Time.time + (float)12;
									if (15336 - 108082 != -92745)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (127405 - 492790 == -365385)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (112467 - 568257 != -455789)
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
						if (79299 - 512464 != -433164)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008FE3 RID: 36835 RVA: 0x011688C8 File Offset: 0x01166AC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (273572 - 296102 != -22530)
		{
		}
		for (;;)
		{
			if (!this.tf2n5sUvWKi)
			{
				if (250618 - 402499 == -151881)
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
				if (137172 - 158817 != -21644)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (185009 - 316089 != -131079)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (136605 - 53430 == 83175)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (205513 - 175982 != 29532)
							{
								GUI.depth = 1;
								if (173666 - 458147 != -284480)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (47217 - 105528 != -58310)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (86767 - 122849 != -36081)
										{
											Color color = GUI.color;
											if (228928 - 517739 != -288810)
											{
												color.a = a;
												if (3072 - 41621 == -38549)
												{
													if (104645 - 381867 == -277222)
													{
														Color color2 = GUI.color = color;
														if (9676 - 114271 == -104595)
														{
															if (139030 - 263738 == -124708)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.tf2n5sUvWKi);
																if (11477 - 234199 != -222721)
																{
																	float a2 = 1f;
																	if (139710 - 90166 != 49545)
																	{
																		Color color3 = GUI.color;
																		if (122859 - 516046 != -393186)
																		{
																			float num3 = color3.a = a2;
																			if (24370 - 462587 != -438216 && 33889 - 198257 != -164367)
																			{
																				GUI.color = color3;
																				if (183252 - 515354 != -332101 && 2879 - 374900 != -372020)
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

	// Token: 0x06008FE4 RID: 36836 RVA: 0x01168C48 File Offset: 0x01166E48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (136273 - 321093 != -184819)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (121407 - 206386 != -84978)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (66483 - 338489 == -272006)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (235529 - 101761 == 133768)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (114312 - 173751 == -59439)
						{
							int num4 = num;
							if (94211 - 191119 != -96907)
							{
								if (num4 == 9021)
								{
									if (20159 - 236207 != -216047)
									{
										this.Lsqn57mY01n++;
										if (7585 - 321680 != -314094)
										{
											this.SendMessage("newGameMessage", "Mission Objective: Mad Veggies captured:" + this.Lsqn57mY01n + "/12");
											if (243730 - 2723 == 241007)
											{
												Chat.SubmitChat("none", "Mission Objective: Mad Veggies captured:" + this.Lsqn57mY01n + "/12", eChatType.system, eChatMode.system);
												if (37804 - 113486 == -75682)
												{
													if (this.Lsqn57mY01n != 9)
													{
														break;
													}
													if (47912 - 70085 != -22172)
													{
														Game.sendMissionEvent(9022, 1);
														if (52927 - 38394 != 14534)
														{
															break;
														}
													}
												}
											}
										}
									}
								}
								else if (num4 == 9022)
								{
									if (225467 - 448550 != -223082)
									{
										break;
									}
								}
								else
								{
									if (num4 != -9022)
									{
										break;
									}
									if (171330 - 230605 == -59275)
									{
										if (num3 == PlayerData.UID)
										{
											if (40812 - 109897 != -69085)
											{
												continue;
											}
											GameObject gameObject = GameObject.Find("SpawnPoint1");
											if (192142 - 68343 == 123800)
											{
												continue;
											}
											GameObject gameObject2 = GameObject.Find("SpawnPoint2");
											if (111781 - 180831 == -69049)
											{
												continue;
											}
											GameObject gameObject3 = GameObject.Find("SpawnPoint3");
											if (9090 - 154517 == -145426)
											{
												continue;
											}
											if (gameObject)
											{
												if (119353 - 257584 == -138230)
												{
													continue;
												}
												this.createActor("MadCarron", 6, gameObject.transform.position, gameObject.transform.forward);
												if (192788 - 22161 == 170628)
												{
													continue;
												}
											}
											if (gameObject2)
											{
												if (52309 - 346291 == -293981)
												{
													continue;
												}
												this.createActor("MadPeppon", 6, gameObject2.transform.position, gameObject2.transform.forward);
												if (26994 - 84225 == -57230)
												{
													continue;
												}
											}
											if (gameObject3)
											{
												if (131132 - 114297 != 16835)
												{
													continue;
												}
												this.createActor("MadCocon", 6, gameObject3.transform.position, gameObject3.transform.forward);
												if (93942 - 31900 == 62043)
												{
													continue;
												}
											}
										}
										this.StartCoroutine_Auto(this.MadVeggieEvent());
										if (185400 - 371447 != -186046)
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

	// Token: 0x06008FE5 RID: 36837 RVA: 0x011690B8 File Offset: 0x011672B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator MadVeggieEvent()
	{
		return new M902_MadVegetables.$MadVeggieEvent$41199(this).GetEnumerator();
	}

	// Token: 0x06008FE6 RID: 36838 RVA: 0x011690C8 File Offset: 0x011672C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M902_MadVegetables.$onGameComplete$41203(data, this).GetEnumerator();
	}

	// Token: 0x06008FE7 RID: 36839 RVA: 0x011690D8 File Offset: 0x011672D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToGoatFarmer()
	{
		return new M902_MadVegetables.$TalkToGoatFarmer$41213(this).GetEnumerator();
	}

	// Token: 0x06008FE8 RID: 36840 RVA: 0x011690E8 File Offset: 0x011672E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToRedPanda()
	{
		return new M902_MadVegetables.$TalkToRedPanda$41220(this).GetEnumerator();
	}

	// Token: 0x06008FE9 RID: 36841 RVA: 0x011690F8 File Offset: 0x011672F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (151617 - 505764 != -354146)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (245643 - 213770 != 31874)
			{
				Time.timeScale = 1f;
				if (38664 - 69737 == -31073)
				{
					this.tf2n5sUvWKi = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (163689 - 207301 == -43612)
					{
						Hashtable customOpParameters = new Hashtable();
						if (102392 - 396918 != -294525)
						{
							this.tByn5gEptP4.OpCustom(52, customOpParameters, true);
							if (211393 - 66149 != 145245)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008FEA RID: 36842 RVA: 0x011691FC File Offset: 0x011673FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (243618 - 449419 != -205801)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (185799 - 175385 == 10414)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (12356 - 567078 == -554722)
				{
					Game.mGameState = eGameState.Setup;
					if (51750 - 294906 != -243155)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008FEB RID: 36843 RVA: 0x011692A0 File Offset: 0x011674A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (273155 - 556365 != -283209)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (19228 - 160891 == -141663)
			{
				if (num == PlayerData.UID)
				{
					if (137360 - 76302 == 61058)
					{
						this.SetupActors();
						if (232908 - 10379 != 222530)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (210526 - 322198 != -111671)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008FEC RID: 36844 RVA: 0x01169370 File Offset: 0x01167570
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (183238 - 417180 != -233942)
		{
		}
		for (;;)
		{
			IL_210:
			Debug.Log("Creating Actors");
			if (200703 - 521434 != -320730)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (180031 - 40996 == 139035)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (287712 - 261087 != 26626)
						{
							int i = 0;
							if (39713 - 469076 == -429363)
							{
								CharacterControl[] array2 = array;
								if (286288 - 470015 == -183727)
								{
									int length = array2.Length;
									if (207674 - 75618 != 132057)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (260756 - 502386 != -241630)
											{
												goto IL_210;
											}
											if (type == "MadCarron")
											{
												goto IL_3D;
											}
											if (118621 - 381663 != -263042)
											{
												goto IL_210;
											}
											if (type == "MadCocon")
											{
												goto IL_3D;
											}
											if (153085 - 108520 != 44565)
											{
												goto IL_210;
											}
											if (type == "MadPeppon")
											{
												goto IL_3D;
											}
											if (37527 - 420940 == -383412)
											{
												goto IL_210;
											}
											if (type == "StingBug_g")
											{
												goto IL_3D;
											}
											if (39862 - 118194 != -78332)
											{
												goto IL_210;
											}
											if (type == "StingBug_r")
											{
												if (81696 - 168028 != -86331)
												{
													goto IL_3D;
												}
												goto IL_210;
											}
											IL_151:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (90349 - 265273 != -174924)
											{
												goto IL_210;
											}
											this.pwkn5C3hGYo++;
											if (78471 - 468181 != -389710)
											{
												goto IL_210;
											}
											i++;
											if (169979 - 226100 != -56121)
											{
												goto IL_210;
											}
											continue;
											IL_3D:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (275367 - 60614 != 214754)
											{
												goto IL_151;
											}
											goto IL_210;
										}
										if (42346 - 491959 == -449613)
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
						if (76190 - 262822 != -186631)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008FED RID: 36845 RVA: 0x0116968C File Offset: 0x0116788C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (215762 - 569597 != -353835)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (231501 - 329999 != -98497)
			{
				int i = 0;
				if (49021 - 336809 != -287787)
				{
					CharacterControl[] array2 = array;
					if (176911 - 60109 != 116803)
					{
						int length = array2.Length;
						if (115665 - 158508 != -42842)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (51358 - 493272 == -441913)
								{
									goto IL_1A;
								}
								i++;
								if (255141 - 244308 != 10833)
								{
									goto IL_1A;
								}
							}
							if (192795 - 432228 != -239432)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008FEE RID: 36846 RVA: 0x011697BC File Offset: 0x011679BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (100752 - 157531 != -56779)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (254273 - 150252 == 104021)
			{
				Game.mGameState = eGameState.Ready;
				if (229420 - 478768 == -249348)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (91409 - 379726 != -288316 && 61177 - 298979 != -237801)
					{
						GameObject gameObject = null;
						if (236156 - 224763 == 11393)
						{
							GameObject gameObject2;
							if (playerSlot >= 1)
							{
								if (257242 - 140593 != 116649)
								{
									continue;
								}
								if (playerSlot <= 6)
								{
									if (230185 - 10015 == 220171)
									{
										continue;
									}
									gameObject2 = GameObject.Find("StartPoint" + playerSlot);
									if (231937 - 238016 != -6079)
									{
										continue;
									}
									gameObject = GameObject.Find("StartCamera" + playerSlot);
									if (40474 - 437827 != -397352)
									{
										goto IL_1A9;
									}
									continue;
								}
							}
							gameObject2 = GameObject.Find("StartPoint1");
							if (188906 - 485596 != -296690)
							{
								continue;
							}
							IL_1A9:
							if (gameObject2)
							{
								if (237716 - 568710 == -330993)
								{
									continue;
								}
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
								if (28625 - 68611 != -39986)
								{
									continue;
								}
								if (spawnPos != Vector3.zero)
								{
									if (64425 - 162744 != -98319)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
									if (8552 - 525279 == -516726)
									{
										continue;
									}
								}
								else
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (257785 - 447099 == -189313)
									{
										continue;
									}
								}
							}
							if (!gameObject)
							{
								break;
							}
							if (153500 - 321059 == -167559)
							{
								this.transform.position = gameObject.transform.position;
								if (31943 - 296665 != -264721)
								{
									this.transform.rotation = gameObject.transform.rotation;
									if (58473 - 136773 != -78299)
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

	// Token: 0x06008FEF RID: 36847 RVA: 0x01169AE0 File Offset: 0x01167CE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M902_MadVegetables.$StartGame$41228(this).GetEnumerator();
	}

	// Token: 0x06008FF0 RID: 36848 RVA: 0x01169AF0 File Offset: 0x01167CF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06008FF1 RID: 36849 RVA: 0x01169AF4 File Offset: 0x01167CF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (292981 - 377426 != -84445)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (234306 - 100303 != 134004)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (286308 - 439032 == -152724)
				{
					hashtable.Add(43, PlayerData.UID);
					if (37770 - 215947 == -178177)
					{
						hashtable.Add(73, nType);
						if (53272 - 498623 != -445350)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (226684 - 151729 == 74955)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (233767 - 284634 != -50866)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (69835 - 93553 == -23718)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (120786 - 532086 == -411300)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (28055 - 528532 == -500477)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (133678 - 530397 != -396718)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (87079 - 406142 != -319062)
													{
														this.tByn5gEptP4.OpCustom(63, hashtable, true);
														if (70157 - 16076 != 54082)
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

	// Token: 0x06008FF2 RID: 36850 RVA: 0x01169DD8 File Offset: 0x01167FD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (223815 - 239753 != -15937)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (158468 - 491920 == -333452)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (244169 - 359405 == -115236)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (68749 - 128163 != -59413)
						{
							if (this.pwkn5C3hGYo <= 0)
							{
								break;
							}
							if (248913 - 437184 != -188270)
							{
								this.pwkn5C3hGYo--;
								if (176374 - 6812 == 169562)
								{
									if (this.pwkn5C3hGYo != 0)
									{
										break;
									}
									if (78500 - 509922 == -431422)
									{
										Game.setGameState(eGameState.Ready);
										if (61961 - 343296 == -281335)
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
						if (149243 - 430408 == -281165)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (144349 - 488972 == -344623)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008FF3 RID: 36851 RVA: 0x01169F68 File Offset: 0x01168168
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06008FF4 RID: 36852 RVA: 0x01169F7C File Offset: 0x0116817C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (299170 - 69727 != 229443)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (7725 - 405051 != -397325)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (120355 - 515746 == -395391)
				{
					if (!characterControl)
					{
						break;
					}
					if (117821 - 366796 == -248975)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (150062 - 428857 != -278794)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (275215 - 16992 == 258223)
							{
								string type = characterControl.Type;
								if (39356 - 13896 != 25461)
								{
									if (type == "MadCarron")
									{
										if (8853 - 327596 != -318742)
										{
											Game.sendMissionEvent(9021, 1);
											if (48907 - 224114 == -175207)
											{
												break;
											}
										}
									}
									else if (type == "MadPeppon")
									{
										if (190641 - 250721 == -60080)
										{
											Game.sendMissionEvent(9021, 2);
											if (119750 - 423417 == -303667)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "MadCocon"))
										{
											break;
										}
										if (89569 - 200734 != -111164)
										{
											Game.sendMissionEvent(9021, 3);
											if (95938 - 249346 == -153408)
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

	// Token: 0x06008FF5 RID: 36853 RVA: 0x0116A19C File Offset: 0x0116839C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (29740 - 458451 != -428711)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (135287 - 255399 == -120112)
			{
				hashtable.Add(71, CID);
				if (227905 - 146064 != 81842)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (278309 - 590439 == -312130)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (50182 - 101018 != -50835)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (177883 - 108440 == 69443)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (233397 - 20959 == 212438)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (105352 - 476880 != -371527)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (139373 - 65277 != 74097)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (152341 - 308404 != -156062)
											{
												this.tByn5gEptP4.OpCustom(61, hashtable, true);
												if (135537 - 20042 != 115496)
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

	// Token: 0x06008FF6 RID: 36854 RVA: 0x0116A428 File Offset: 0x01168628
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (203781 - 466163 != -262382)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (121024 - 557018 == -435994)
			{
				if (!gameObject)
				{
					break;
				}
				if (296458 - 402761 != -106302)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (275648 - 460906 != -185257)
					{
						playerCameraControl.target = gameObject;
						if (208128 - 360817 == -152689)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (81611 - 92805 != -11193)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008FF7 RID: 36855 RVA: 0x0116A520 File Offset: 0x01168720
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (167320 - 202947 != -35626)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (183325 - 109762 == 73563)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (80202 - 207105 == -126903)
				{
					gameGui.ResetTeamBar();
					if (5282 - 459472 == -454190)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008FF8 RID: 36856 RVA: 0x0116A5CC File Offset: 0x011687CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M902_MadVegetables.$onDeadPlayer$41232(this).GetEnumerator();
	}

	// Token: 0x06008FF9 RID: 36857 RVA: 0x0116A5DC File Offset: 0x011687DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (81587 - 147132 != -65544)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (97772 - 560906 != -463133)
			{
				this.Ub4n5aWEuNl.target = Game.mPlayer;
				if (126798 - 171015 == -44217)
				{
					this.Ub4n5aWEuNl.enabled = true;
					if (216923 - 173070 != 43854)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (3295 - 241344 != -238049)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (181487 - 540671 != -359184)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (299030 - 338885 != -39854)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (122399 - 576956 != -454556)
							{
								if (!gameGui)
								{
									break;
								}
								if (29667 - 536248 == -506581)
								{
									gameGui.enabled = true;
									if (289441 - 246113 != 43329)
									{
										gameGui.closeDeadMenu();
										if (207095 - 407798 == -200703)
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

	// Token: 0x06008FFA RID: 36858 RVA: 0x0116A788 File Offset: 0x01168988
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (112103 - 175885 != -63782)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (210427 - 392082 == -181655)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (131831 - 167657 == -35826)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (208187 - 131006 == 77181)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008FFB RID: 36859 RVA: 0x0116A84C File Offset: 0x01168A4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06008FFC RID: 36860 RVA: 0x0116A878 File Offset: 0x01168A78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (190535 - 439021 != -248485)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (188569 - 440256 != -251686)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (134287 - 370412 == -236125)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (143597 - 423640 == -280043)
					{
						Hashtable hashtable = new Hashtable();
						if (112676 - 188999 != -76322)
						{
							hashtable.Add(43, PlayerData.UID);
							if (109397 - 34758 == 74639)
							{
								hashtable.Add(71, nCID);
								if (99995 - 509430 != -409434)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (233231 - 116970 != 116262)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (241053 - 139497 != 101557)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (36325 - 161488 != -125162)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (256838 - 146666 != 110173)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (78191 - 452465 != -374273)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (166721 - 11826 != 154896)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (135157 - 512073 == -376916)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (243365 - 41647 == 201718)
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

	// Token: 0x06008FFD RID: 36861 RVA: 0x0116AB98 File Offset: 0x01168D98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M902_MadVegetables.$onChangePlayer$41238(data, this).GetEnumerator();
	}

	// Token: 0x06008FFE RID: 36862 RVA: 0x0116ABA8 File Offset: 0x01168DA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M902_MadVegetables.$ReturnToTown$41245(this).GetEnumerator();
	}

	// Token: 0x06008FFF RID: 36863 RVA: 0x0116ABB8 File Offset: 0x01168DB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M902_MadVegetables.$ReturnToGuild$41250(this).GetEnumerator();
	}

	// Token: 0x06009000 RID: 36864 RVA: 0x0116ABC8 File Offset: 0x01168DC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M902_MadVegetables.$ReturnToCamp$41254(this).GetEnumerator();
	}

	// Token: 0x06009001 RID: 36865 RVA: 0x0116ABD8 File Offset: 0x01168DD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (97341 - 211956 != -114614)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (8097 - 506249 != -498151)
			{
				Hashtable hashtable = new Hashtable();
				if (74721 - 299332 == -224611)
				{
					hashtable.Add(43, PlayerData.UID);
					if (237367 - 553619 != -316251)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (280596 - 174351 != 106246)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009002 RID: 36866 RVA: 0x0116ACB0 File Offset: 0x01168EB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06009003 RID: 36867 RVA: 0x0116ACC4 File Offset: 0x01168EC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (160794 - 526622 != -365828)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (255602 - 530957 != -275354)
			{
				Hashtable hashtable = new Hashtable();
				if (102614 - 237486 == -134872)
				{
					if (Game.mNextGameCode == 30)
					{
						if (102314 - 310690 != -208376)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (53151 - 30271 == 22881)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (26872 - 531610 != -504738)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (129021 - 28122 != 100899)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (242041 - 244608 == -2566)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (136632 - 556362 != -419730)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (154412 - 170546 == -16133)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (34979 - 300905 != -265926)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (217716 - 261110 != -43394)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (152807 - 295144 != -142337)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (19160 - 432444 == -413283)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (12745 - 505861 != -493116)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (257256 - 491750 == -234493)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (55506 - 453706 != -398200)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (275155 - 94766 != 180389)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (70758 - 419469 == -348710)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (85534 - 282858 != -197324)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (164578 - 107437 == 57142)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (157707 - 337380 == -179672)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (279336 - 577272 == -297935)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (198890 - 394946 != -196056)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (259287 - 424660 == -165372)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (21116 - 515779 == -494662)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (22041 - 91337 != -69296)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (171901 - 578721 == -406819)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (124272 - 292183 == -167910)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (209243 - 313549 != -104306)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (161217 - 198169 != -36952)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (95906 - 182476 == -86570)
					{
						this.tByn5gEptP4.OpCustom(42, hashtable, true);
						if (31168 - 567865 != -536696)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009004 RID: 36868 RVA: 0x0116B278 File Offset: 0x01169478
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06009005 RID: 36869 RVA: 0x0116B288 File Offset: 0x01169488
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009006 RID: 36870 RVA: 0x0116B28C File Offset: 0x0116948C
	internal static bool pgFZJHVkLjUxHTB5hfdD()
	{
		return true;
	}

	// Token: 0x06009007 RID: 36871 RVA: 0x0116B290 File Offset: 0x01169490
	internal static bool aM4e1oVkON8W08TG7ZR7()
	{
		return false;
	}

	// Token: 0x04008857 RID: 34903
	private LitePeer tByn5gEptP4;

	// Token: 0x04008858 RID: 34904
	private PlayerCameraControl Ub4n5aWEuNl;

	// Token: 0x04008859 RID: 34905
	private float asMn548HeII;

	// Token: 0x0400885A RID: 34906
	private Texture tf2n5sUvWKi;

	// Token: 0x0400885B RID: 34907
	private int fEcn5HHKYiO;

	// Token: 0x0400885C RID: 34908
	private int Lsqn57mY01n;

	// Token: 0x0400885D RID: 34909
	public AudioClip madCarronFx;

	// Token: 0x0400885E RID: 34910
	public AudioClip madPepponFx;

	// Token: 0x0400885F RID: 34911
	public AudioClip madCoconFx;

	// Token: 0x04008860 RID: 34912
	private int MQkn5ZmZHtA;

	// Token: 0x04008861 RID: 34913
	private int pwkn5C3hGYo;

	// Token: 0x02001828 RID: 6184
	[CompilerGenerated]
	[Serializable]
	internal sealed class $MadVeggieEvent$41199 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009008 RID: 36872 RVA: 0x0116B294 File Offset: 0x01169494
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $MadVeggieEvent$41199(M902_MadVegetables self_)
		{
			if (284116 - 528398 != -244281)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (28882 - 290131 == -261249)
				{
					base..ctor();
					if (235599 - 590505 != -354905)
					{
						this.$self_$41202 = self_;
						if (67668 - 399410 == -331742)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009009 RID: 36873 RVA: 0x0116B32C File Offset: 0x0116952C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M902_MadVegetables.$MadVeggieEvent$41199.$(this.$self_$41202);
		}

		// Token: 0x0600900A RID: 36874 RVA: 0x0116B33C File Offset: 0x0116953C
		internal static bool wWvCLnVkmE9CdfOCJPaQ()
		{
			return true;
		}

		// Token: 0x0600900B RID: 36875 RVA: 0x0116B340 File Offset: 0x01169540
		internal static bool qD7xqPVkF5WIFS9XPTsA()
		{
			return false;
		}

		// Token: 0x04008862 RID: 34914
		internal M902_MadVegetables $self_$41202;

		// Token: 0x02001829 RID: 6185
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600900C RID: 36876 RVA: 0x0116B344 File Offset: 0x01169544
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M902_MadVegetables self_)
			{
				if (2415 - 197183 != -194767)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (270152 - 358973 != -88820)
					{
						base..ctor();
						if (140334 - 405573 == -265239)
						{
							this.$self_$41201 = self_;
							if (245502 - 384827 != -139324)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600900D RID: 36877 RVA: 0x0116B3DC File Offset: 0x011695DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (223943 - 48827 != 175116)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_77C;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (63375 - 427039 != -363663)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$self_$41201.Ub4n5aWEuNl.alignToObject("EventCamera1");
							if (212480 - 91918 != 120562)
							{
								continue;
							}
							this.$self_$41201.SendMessage("fadeIn");
							if (48162 - 47588 != 575)
							{
								goto Block_28;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (138171 - 350456 != -212285)
							{
								continue;
							}
							goto IL_28A;
						}
						else
						{
							if (!this.$self_$41201.madCarronFx)
							{
								goto IL_54E;
							}
							if (19220 - 84983 != -65763)
							{
								continue;
							}
							this.$self_$41201.audio.PlayOneShot(this.$self_$41201.madCarronFx);
							if (286265 - 493813 != -207548)
							{
								continue;
							}
							goto IL_54E;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (32177 - 495815 != -463638)
							{
								continue;
							}
							goto IL_31E;
						}
						else
						{
							if (!this.$self_$41201.madPepponFx)
							{
								goto IL_6A6;
							}
							if (247434 - 233882 != 13552)
							{
								continue;
							}
							this.$self_$41201.audio.PlayOneShot(this.$self_$41201.madPepponFx);
							if (247071 - 92174 != 154897)
							{
								continue;
							}
							goto IL_6A6;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (14294 - 271736 != -257441)
							{
								goto Block_52;
							}
							continue;
						}
						else
						{
							if (!this.$self_$41201.madCoconFx)
							{
								goto IL_2E3;
							}
							if (24665 - 331646 != -306981)
							{
								continue;
							}
							this.$self_$41201.audio.PlayOneShot(this.$self_$41201.madCoconFx);
							if (228375 - 426413 != -198037)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (91648 - 317132 != -225483)
							{
								goto Block_24;
							}
							continue;
						}
						else
						{
							if (!this.$self_$41201.madCarronFx)
							{
								goto IL_70C;
							}
							if (14870 - 549093 == -534222)
							{
								continue;
							}
							this.$self_$41201.audio.PlayOneShot(this.$self_$41201.madCarronFx);
							if (112409 - 491040 != -378630)
							{
								goto Block_56;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (225937 - 596414 != -370476)
							{
								goto Block_55;
							}
							continue;
						}
						else
						{
							if (!this.$self_$41201.madPepponFx)
							{
								goto IL_431;
							}
							if (22668 - 428201 == -405532)
							{
								continue;
							}
							this.$self_$41201.audio.PlayOneShot(this.$self_$41201.madPepponFx);
							if (103019 - 587257 != -484238)
							{
								continue;
							}
							goto IL_431;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (40111 - 117579 != -77468)
							{
								continue;
							}
							goto IL_672;
						}
						else
						{
							if (!this.$self_$41201.madCoconFx)
							{
								goto IL_E7;
							}
							if (142490 - 319199 == -176708)
							{
								continue;
							}
							this.$self_$41201.audio.PlayOneShot(this.$self_$41201.madCoconFx);
							if (89401 - 322321 != -232920)
							{
								continue;
							}
							goto IL_E7;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (242583 - 494994 != -252411)
							{
								continue;
							}
							goto IL_589;
						}
						else
						{
							this.$self_$41201.SendMessage("fadeOut");
							if (296555 - 138553 != 158003)
							{
								goto Block_43;
							}
							continue;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (157649 - 15710 != 141940)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							this.$self_$41201.Ub4n5aWEuNl.enabled = true;
							if (287165 - 174864 != 112301)
							{
								continue;
							}
							this.$self_$41201.Ub4n5aWEuNl.specialTarget = null;
							if (103365 - 485430 != -382065)
							{
								continue;
							}
							this.$self_$41201.SendMessage("fadeIn");
							if (282230 - 27450 != 254781)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (229463 - 306364 != -76900)
							{
								goto Block_46;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (265600 - 209866 == 55735)
							{
								continue;
							}
							this.$mGameGui$41200.enabled = true;
							if (266529 - 96035 == 170495)
							{
								continue;
							}
							this.YieldDefault(1);
							if (157961 - 534920 != -376958)
							{
								goto Block_48;
							}
							continue;
						}
						break;
					default:
						if (65180 - 156500 == -91319)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.AllHold;
					if (288383 - 127417 == 160966)
					{
						this.$mGameGui$41200 = (GameGui)this.$self_$41201.GetComponent(typeof(GameGui));
						if (135640 - 127133 != 8508)
						{
							if (this.$mGameGui$41200)
							{
								if (40258 - 398353 != -358095)
								{
									continue;
								}
								this.$mGameGui$41200.close();
								if (23390 - 534743 == -511352)
								{
									continue;
								}
							}
							this.$self_$41201.SendMessage("fadeOut");
							if (107938 - 527339 == -419401)
							{
								goto IL_1F9;
							}
						}
					}
				}
				Block_3:
				goto IL_77C;
				Block_4:
				return this.Yield(11, new WaitForSeconds((float)1));
				IL_E7:
				return this.Yield(9, new WaitForSeconds(0.3f));
				Block_14:
				goto IL_2E3;
				IL_1F9:
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_16:
				IL_28A:
				goto IL_77C;
				IL_2E3:
				return this.Yield(6, new WaitForSeconds(0.2f));
				Block_24:
				IL_31E:
				goto IL_77C;
				Block_28:
				return this.Yield(3, new WaitForSeconds((float)1));
				IL_431:
				return this.Yield(8, new WaitForSeconds(0.3f));
				IL_54E:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_589:
				goto IL_77C;
				Block_43:
				return this.Yield(10, new WaitForSeconds((float)1));
				Block_46:
				Block_48:
				IL_672:
				goto IL_77C;
				IL_6A6:
				return this.Yield(5, new WaitForSeconds(0.2f));
				Block_52:
				goto IL_77C;
				IL_70C:
				return this.Yield(7, new WaitForSeconds(0.3f));
				Block_55:
				goto IL_77C;
				Block_56:
				goto IL_70C;
				IL_77C:
				return false;
			}

			// Token: 0x0600900E RID: 36878 RVA: 0x0116BB78 File Offset: 0x01169D78
			internal static bool OAgEuTVkMq8XjUXuvSpj()
			{
				return true;
			}

			// Token: 0x0600900F RID: 36879 RVA: 0x0116BB7C File Offset: 0x01169D7C
			internal static bool kygMCVVkx2iGKS2JA0OJ()
			{
				return false;
			}

			// Token: 0x04008863 RID: 34915
			internal GameGui $mGameGui$41200;

			// Token: 0x04008864 RID: 34916
			internal M902_MadVegetables $self_$41201;
		}
	}

	// Token: 0x0200182A RID: 6186
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$41203 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009010 RID: 36880 RVA: 0x0116BB80 File Offset: 0x01169D80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$41203(Hashtable data, M902_MadVegetables self_)
		{
			if (153140 - 383690 != -230550)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (25715 - 539615 == -513900)
				{
					base..ctor();
					if (261932 - 167931 == 94001)
					{
						this.$data$41211 = data;
						if (148504 - 303445 != -154940)
						{
							this.$self_$41212 = self_;
							if (232226 - 270501 == -38275)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009011 RID: 36881 RVA: 0x0116BC3C File Offset: 0x01169E3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M902_MadVegetables.$onGameComplete$41203.$(this.$data$41211, this.$self_$41212);
		}

		// Token: 0x06009012 RID: 36882 RVA: 0x0116BC50 File Offset: 0x01169E50
		internal static bool koc0nAVkgHcE1CAuLCP2()
		{
			return true;
		}

		// Token: 0x06009013 RID: 36883 RVA: 0x0116BC54 File Offset: 0x01169E54
		internal static bool yeUcE8VkfViQvjt7pOuW()
		{
			return false;
		}

		// Token: 0x04008865 RID: 34917
		internal Hashtable $data$41211;

		// Token: 0x04008866 RID: 34918
		internal M902_MadVegetables $self_$41212;

		// Token: 0x0200182B RID: 6187
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009014 RID: 36884 RVA: 0x0116BC58 File Offset: 0x01169E58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M902_MadVegetables self_)
			{
				if (104884 - 523179 != -418295)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (218346 - 527391 != -309044)
					{
						base..ctor();
						if (264154 - 486875 == -222721)
						{
							this.$data$41209 = data;
							if (130453 - 462107 != -331653)
							{
								this.$self_$41210 = self_;
								if (165998 - 267905 == -101907)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009015 RID: 36885 RVA: 0x0116BD14 File Offset: 0x01169F14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (66781 - 155699 != -88918)
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
						this.$mCompleteGui$41205 = (CompleteGui)this.$self_$41210.GetComponent(typeof(CompleteGui));
						if (14303 - 406903 != -392600)
						{
							continue;
						}
						this.$mCompleteGui$41205.Init();
						if (192448 - 28887 != 163561)
						{
							continue;
						}
						this.$mCompleteGui$41205.readData(this.$data$41209);
						if (127829 - 3879 == 123951)
						{
							continue;
						}
						if (this.$result$41204 == 1)
						{
							if (124738 - 378481 != -253743)
							{
								continue;
							}
							this.$mCompleteGui$41205.displayResult(eCompleteType.Success);
							if (103828 - 433385 != -329557)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$41205.displayResult(eCompleteType.Failed);
							if (140690 - 553840 != -413150)
							{
								continue;
							}
						}
						this.$mGameGui$41206 = (GameGui)this.$self_$41210.GetComponent(typeof(GameGui));
						if (47532 - 81050 == -33517)
						{
							continue;
						}
						this.$mStoryGui$41207 = (StoryGui)this.$self_$41210.GetComponent(typeof(StoryGui));
						if (298942 - 399067 != -100125)
						{
							continue;
						}
						this.$mChangeGui$41208 = (ChangeGui)this.$self_$41210.GetComponent(typeof(ChangeGui));
						if (181968 - 405450 == -223481)
						{
							continue;
						}
						if (this.$mGameGui$41206)
						{
							if (136971 - 494102 == -357130)
							{
								continue;
							}
							this.$mGameGui$41206.close();
							if (95358 - 100127 != -4769)
							{
								continue;
							}
						}
						if (this.$mStoryGui$41207)
						{
							if (15762 - 391904 == -376141)
							{
								continue;
							}
							this.$mStoryGui$41207.close();
							if (209839 - 86388 == 123452)
							{
								continue;
							}
						}
						if (this.$mChangeGui$41208)
						{
							if (235214 - 590316 == -355101)
							{
								continue;
							}
							this.$mChangeGui$41208.disable();
							if (176289 - 537050 == -360760)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (162740 - 235594 != -72854)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (204346 - 270390 == -66043)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$41209[31]);
					if (158699 - 95073 != 63627)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (290328 - 44475 == 245853)
							{
								goto IL_320;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (165746 - 303612 == -137866)
							{
								this.$result$41204 = RuntimeServices.UnboxInt32(this.$data$41209[31]);
								if (289942 - 10963 != 278980)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_320:
				IL_3DB:
				return false;
			}

			// Token: 0x06009016 RID: 36886 RVA: 0x0116C110 File Offset: 0x0116A310
			internal static bool a7LFmTVkn9J2s0VMosL6()
			{
				return true;
			}

			// Token: 0x06009017 RID: 36887 RVA: 0x0116C114 File Offset: 0x0116A314
			internal static bool BKTCNdVk6Dt3yQpjcaDV()
			{
				return false;
			}

			// Token: 0x04008867 RID: 34919
			internal int $result$41204;

			// Token: 0x04008868 RID: 34920
			internal CompleteGui $mCompleteGui$41205;

			// Token: 0x04008869 RID: 34921
			internal GameGui $mGameGui$41206;

			// Token: 0x0400886A RID: 34922
			internal StoryGui $mStoryGui$41207;

			// Token: 0x0400886B RID: 34923
			internal ChangeGui $mChangeGui$41208;

			// Token: 0x0400886C RID: 34924
			internal Hashtable $data$41209;

			// Token: 0x0400886D RID: 34925
			internal M902_MadVegetables $self_$41210;
		}
	}

	// Token: 0x0200182C RID: 6188
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToGoatFarmer$41213 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009018 RID: 36888 RVA: 0x0116C118 File Offset: 0x0116A318
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToGoatFarmer$41213(M902_MadVegetables self_)
		{
			if (256793 - 315913 != -59119)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (292433 - 98301 != 194133)
				{
					base..ctor();
					if (257481 - 289847 == -32366)
					{
						this.$self_$41219 = self_;
						if (21629 - 273816 == -252187)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009019 RID: 36889 RVA: 0x0116C1B0 File Offset: 0x0116A3B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M902_MadVegetables.$TalkToGoatFarmer$41213.$(this.$self_$41219);
		}

		// Token: 0x0600901A RID: 36890 RVA: 0x0116C1C0 File Offset: 0x0116A3C0
		internal static bool CxS5MnVkiCCYMUrGgw1W()
		{
			return true;
		}

		// Token: 0x0600901B RID: 36891 RVA: 0x0116C1C4 File Offset: 0x0116A3C4
		internal static bool kQV8VIVkKSGGbF452Mpn()
		{
			return false;
		}

		// Token: 0x0400886E RID: 34926
		internal M902_MadVegetables $self_$41219;

		// Token: 0x0200182D RID: 6189
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600901C RID: 36892 RVA: 0x0116C1C8 File Offset: 0x0116A3C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M902_MadVegetables self_)
			{
				if (127622 - 156842 != -29220)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (131837 - 76405 == 55432)
					{
						base..ctor();
						if (189730 - 494717 != -304986)
						{
							this.$self_$41218 = self_;
							if (41155 - 434570 != -393414)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600901D RID: 36893 RVA: 0x0116C260 File Offset: 0x0116A460
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (262056 - 542435 != -280378)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6E7;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (198951 - 287788 != -88836)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$nMessage$41217 = null;
							if (168433 - 23810 != 144623)
							{
								continue;
							}
							if (this.$self_$41218.MQkn5ZmZHtA == 0)
							{
								if (118061 - 141749 == -23687)
								{
									continue;
								}
								this.$self_$41218.MQkn5ZmZHtA = this.$self_$41218.MQkn5ZmZHtA + 1;
								if (91281 - 523565 == -432283)
								{
									continue;
								}
								this.$nMessage$41217 = Language.getMessage("M902_MadVegetables", 101);
								if (193984 - 486603 == -292618)
								{
									continue;
								}
								this.$mStoryGui$41215.newStoryMessage("GoatFarmer", "Gotan", this.$nMessage$41217, eTalkType.friend);
								if (156945 - 237973 != -81027)
								{
									goto Block_48;
								}
								continue;
							}
							else
							{
								this.$nMessage$41217 = Language.getMessage("M902_MadVegetables", 103 + UnityEngine.Random.Range(0, 2));
								if (124187 - 207150 != -82963)
								{
									continue;
								}
								this.$mStoryGui$41215.newStoryMessage("GoatFarmer", "Gotan", this.$nMessage$41217, eTalkType.friend);
								if (4800 - 386052 != -381251)
								{
									goto Block_17;
								}
								continue;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (83258 - 398315 != -315056)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							this.$nMessage$41217 = Language.getMessage("M902_MadVegetables", 102);
							if (120659 - 154320 != -33661)
							{
								continue;
							}
							this.$mStoryGui$41215.newStoryMessage("GoatFarmer", "Gotan", this.$nMessage$41217, eTalkType.friend);
							if (178826 - 178853 != -26)
							{
								goto Block_37;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState == eGameState.Hold)
						{
							goto IL_3B0;
						}
						if (270240 - 429059 != -158819)
						{
							continue;
						}
						goto IL_5BB;
					case 5:
						if (Game.mGameState == eGameState.Hold)
						{
							goto IL_3B0;
						}
						if (225535 - 1612 != 223923)
						{
							continue;
						}
						goto IL_3AB;
					case 6:
						if (Game.mGameState != eGameState.Hold)
						{
							if (219322 - 17693 != 201630)
							{
								goto Block_36;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (233546 - 157676 != 75871)
							{
								goto IL_191;
							}
							continue;
						}
						break;
					default:
						if (78174 - 236232 == -158057)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (205247 - 154352 != 50896)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mGameGui$41214 = (GameGui)this.$self_$41218.GetComponent(typeof(GameGui));
						if (222575 - 124522 == 98054)
						{
							continue;
						}
						this.$mStoryGui$41215 = (StoryGui)this.$self_$41218.GetComponent(typeof(StoryGui));
						if (229349 - 30945 != 198404)
						{
							continue;
						}
						if (this.$mGameGui$41214)
						{
							if (213936 - 460317 == -246380)
							{
								continue;
							}
							if (this.$mStoryGui$41215)
							{
								if (65811 - 577435 == -511623)
								{
									continue;
								}
								Game.mGameState = eGameState.Hold;
								if (263391 - 370755 == -107363)
								{
									continue;
								}
								this.$mGameGui$41214.close();
								if (146742 - 322208 != -175466)
								{
									continue;
								}
								this.$mGoatFarmer$41216 = GameObject.Find("GoatFarmer");
								if (79507 - 592643 != -513136)
								{
									continue;
								}
								if (this.$mGoatFarmer$41216)
								{
									if (604 - 313865 != -313261)
									{
										continue;
									}
									this.$mGoatFarmer$41216.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(Game.mPlayer.transform.position - this.$mGoatFarmer$41216.transform.position));
									if (140955 - 242525 != -101570)
									{
										continue;
									}
									this.$mGoatFarmer$41216.animation.CrossFade("complain", 0.2f);
									if (85958 - 264826 != -178868)
									{
										continue;
									}
									Game.mPlayer.SendMessage("turnToPos", this.$mGoatFarmer$41216.transform.position);
									if (163211 - 28452 != 134759)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find GoatFarmer");
									if (168878 - 98627 != 70251)
									{
										continue;
									}
								}
								this.$mStoryGui$41215.startStoryMessage("GoatFarmer", "Gotan", eTalkType.friend);
								if (274106 - 356869 != -82762)
								{
									goto Block_31;
								}
								continue;
							}
						}
					}
					IL_191:
					this.YieldDefault(1);
					if (285990 - 238848 != 47143)
					{
						break;
					}
					continue;
					IL_3B0:
					this.$mStoryGui$41215.close();
					if (233971 - 411583 != -177611)
					{
						if (this.$mGoatFarmer$41216)
						{
							if (61249 - 482402 == -421152)
							{
								continue;
							}
							this.$mGoatFarmer$41216.animation.CrossFade("root", 0.2f);
							if (49529 - 147205 != -97676)
							{
								continue;
							}
						}
						this.$mGameGui$41214.enabled = true;
						if (144840 - 183794 != -38953)
						{
							goto Block_9;
						}
					}
				}
				goto IL_6E7;
				Block_9:
				return this.Yield(6, new WaitForSeconds(1f));
				Block_16:
				goto IL_6E7;
				Block_17:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_21:
				IL_3AB:
				goto IL_6E7;
				Block_31:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_36:
				goto IL_6E7;
				Block_37:
				return this.Yield(4, new WaitForSeconds(3f));
				IL_5BB:
				goto IL_6E7;
				Block_48:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_6E7:
				return false;
			}

			// Token: 0x0600901E RID: 36894 RVA: 0x0116C968 File Offset: 0x0116AB68
			internal static bool q4n0MyVkdPEqxZCD5x1G()
			{
				return true;
			}

			// Token: 0x0600901F RID: 36895 RVA: 0x0116C96C File Offset: 0x0116AB6C
			internal static bool cMoMcAVkJ8HTDmhC4MxO()
			{
				return false;
			}

			// Token: 0x0400886F RID: 34927
			internal GameGui $mGameGui$41214;

			// Token: 0x04008870 RID: 34928
			internal StoryGui $mStoryGui$41215;

			// Token: 0x04008871 RID: 34929
			internal GameObject $mGoatFarmer$41216;

			// Token: 0x04008872 RID: 34930
			internal string $nMessage$41217;

			// Token: 0x04008873 RID: 34931
			internal M902_MadVegetables $self_$41218;
		}
	}

	// Token: 0x0200182E RID: 6190
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToRedPanda$41220 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009020 RID: 36896 RVA: 0x0116C970 File Offset: 0x0116AB70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToRedPanda$41220(M902_MadVegetables self_)
		{
			if (71107 - 85213 != -14106)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (113262 - 115912 != -2649)
				{
					base..ctor();
					if (176336 - 458557 == -282221)
					{
						this.$self_$41227 = self_;
						if (195171 - 585944 != -390772)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009021 RID: 36897 RVA: 0x0116CA08 File Offset: 0x0116AC08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M902_MadVegetables.$TalkToRedPanda$41220.$(this.$self_$41227);
		}

		// Token: 0x06009022 RID: 36898 RVA: 0x0116CA18 File Offset: 0x0116AC18
		internal static bool BMZkHkVkDhy2KV5POutH()
		{
			return true;
		}

		// Token: 0x06009023 RID: 36899 RVA: 0x0116CA1C File Offset: 0x0116AC1C
		internal static bool j3KPexVkvT2BNFP9IoL5()
		{
			return false;
		}

		// Token: 0x04008874 RID: 34932
		internal M902_MadVegetables $self_$41227;

		// Token: 0x0200182F RID: 6191
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009024 RID: 36900 RVA: 0x0116CA20 File Offset: 0x0116AC20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M902_MadVegetables self_)
			{
				if (251511 - 30543 != 220968)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (98294 - 282462 != -184167)
					{
						base..ctor();
						if (172694 - 465117 != -292422)
						{
							this.$self_$41226 = self_;
							if (74862 - 150458 == -75596)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009025 RID: 36901 RVA: 0x0116CAB8 File Offset: 0x0116ACB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (38844 - 81928 != -43083)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3E7;
					case 2:
						this.$mStoryGui$41225.newStoryMessage("RedPanda", "RedPanda", Language.getMessage("M902_MadVegetables", 201), eTalkType.friend);
						if (257888 - 435278 != -177389)
						{
							goto Block_15;
						}
						continue;
					case 3:
						this.$mStoryGui$41225.newStoryMessage("RedPanda", "RedPanda", Language.getMessage("M902_MadVegetables", 202), eTalkType.friend);
						if (142970 - 81937 != 61034)
						{
							goto Block_3;
						}
						continue;
					case 4:
						this.$mStoryGui$41225.close();
						if (185867 - 541744 == -355876)
						{
							continue;
						}
						this.$mGameGui$41224.enabled = true;
						if (107745 - 72015 == 35731)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (28485 - 471404 != -442919)
						{
							continue;
						}
						this.YieldDefault(1);
						if (156581 - 544888 != -388306)
						{
							goto IL_3E7;
						}
						continue;
					default:
						if (56162 - 77104 != -20942)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (30031 - 188386 == -158355)
						{
							break;
						}
					}
					else
					{
						this.$mPlayer$41221 = Game.mPlayer;
						if (208068 - 399125 != -191056)
						{
							this.$mRedPanda$41222 = GameObject.Find("RedPanda");
							if (66279 - 532858 == -466579)
							{
								this.$mRedPandaOriginalDir$41223 = default(Vector3);
								if (90405 - 32305 != 58101)
								{
									if (this.$mRedPanda$41222)
									{
										if (114820 - 14064 == 100757)
										{
											continue;
										}
										if (this.$mPlayer$41221)
										{
											if (59592 - 310972 == -251379)
											{
												continue;
											}
											this.$mPlayer$41221.SendMessage("turnToPos", this.$mRedPanda$41222.transform.position);
											if (39454 - 457631 != -418177)
											{
												continue;
											}
										}
									}
									Game.mGameState = eGameState.Hold;
									if (268916 - 367850 != -98933)
									{
										this.$mGameGui$41224 = (GameGui)this.$self_$41226.GetComponent(typeof(GameGui));
										if (236888 - 530915 != -294026)
										{
											if (this.$mGameGui$41224)
											{
												if (48222 - 474351 != -426129)
												{
													continue;
												}
												this.$mGameGui$41224.close();
												if (248838 - 484815 == -235976)
												{
													continue;
												}
											}
											this.$mStoryGui$41225 = (StoryGui)this.$self_$41226.GetComponent(typeof(StoryGui));
											if (160001 - 526372 != -366370)
											{
												this.$mStoryGui$41225.startStoryMessage("RedPanda", "RedPanda", eTalkType.friend);
												if (180615 - 197919 == -17304)
												{
													goto IL_212;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_3E7;
				Block_3:
				return this.Yield(4, new WaitForSeconds(3f));
				IL_212:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_15:
				return this.Yield(3, new WaitForSeconds(3f));
				IL_3E7:
				return false;
			}

			// Token: 0x06009026 RID: 36902 RVA: 0x0116CEC0 File Offset: 0x0116B0C0
			internal static bool q5vtP5VkR9VOWQZWOijU()
			{
				return true;
			}

			// Token: 0x06009027 RID: 36903 RVA: 0x0116CEC4 File Offset: 0x0116B0C4
			internal static bool wffxqlVkwbAa2DFttXMg()
			{
				return false;
			}

			// Token: 0x04008875 RID: 34933
			internal GameObject $mPlayer$41221;

			// Token: 0x04008876 RID: 34934
			internal GameObject $mRedPanda$41222;

			// Token: 0x04008877 RID: 34935
			internal Vector3 $mRedPandaOriginalDir$41223;

			// Token: 0x04008878 RID: 34936
			internal GameGui $mGameGui$41224;

			// Token: 0x04008879 RID: 34937
			internal StoryGui $mStoryGui$41225;

			// Token: 0x0400887A RID: 34938
			internal M902_MadVegetables $self_$41226;
		}
	}

	// Token: 0x02001830 RID: 6192
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$41228 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009028 RID: 36904 RVA: 0x0116CEC8 File Offset: 0x0116B0C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$41228(M902_MadVegetables self_)
		{
			if (57464 - 346867 != -289403)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (20726 - 246102 == -225376)
				{
					base..ctor();
					if (177265 - 582784 != -405518)
					{
						this.$self_$41231 = self_;
						if (196760 - 45660 == 151100)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009029 RID: 36905 RVA: 0x0116CF60 File Offset: 0x0116B160
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M902_MadVegetables.$StartGame$41228.$(this.$self_$41231);
		}

		// Token: 0x0600902A RID: 36906 RVA: 0x0116CF70 File Offset: 0x0116B170
		internal static bool IdxrNrVkqvTm1LVg1COx()
		{
			return true;
		}

		// Token: 0x0600902B RID: 36907 RVA: 0x0116CF74 File Offset: 0x0116B174
		internal static bool BqFlyGVk7XhcXyCTxyns()
		{
			return false;
		}

		// Token: 0x0400887B RID: 34939
		internal M902_MadVegetables $self_$41231;

		// Token: 0x02001831 RID: 6193
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600902C RID: 36908 RVA: 0x0116CF78 File Offset: 0x0116B178
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M902_MadVegetables self_)
			{
				if (184337 - 131397 != 52940)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (202685 - 209075 != -6389)
					{
						base..ctor();
						if (184216 - 365528 == -181312)
						{
							this.$self_$41230 = self_;
							if (9912 - 1714 != 8199)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600902D RID: 36909 RVA: 0x0116D010 File Offset: 0x0116B210
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (263001 - 377348 != -114346)
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
						if (128471 - 175395 == -46923)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (274244 - 334673 == -60428)
						{
							continue;
						}
						this.YieldDefault(1);
						if (277067 - 101849 != 175219)
						{
							goto IL_1B9;
						}
						continue;
					default:
						if (53939 - 381969 == -328029)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (260257 - 474915 != -214657)
					{
						Game.mGameState = eGameState.Start;
						if (237495 - 385924 == -148429)
						{
							Game.mGameTime = Time.time;
							if (70156 - 443243 != -373086)
							{
								this.$mGameGui$41229 = (GameGui)this.$self_$41230.GetComponent(typeof(GameGui));
								if (184646 - 173143 != 11504)
								{
									this.$mGameGui$41229.enabled = true;
									if (262077 - 467151 != -205073)
									{
										this.$self_$41230.SendMessage("fadeIn");
										if (187577 - 233331 != -45753)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1B9:
				return false;
			}

			// Token: 0x0600902E RID: 36910 RVA: 0x0116D1E8 File Offset: 0x0116B3E8
			internal static bool RekmVkVkP4fctKpclscp()
			{
				return true;
			}

			// Token: 0x0600902F RID: 36911 RVA: 0x0116D1EC File Offset: 0x0116B3EC
			internal static bool eYpRE5Vk0nTyKRemEnnD()
			{
				return false;
			}

			// Token: 0x0400887C RID: 34940
			internal GameGui $mGameGui$41229;

			// Token: 0x0400887D RID: 34941
			internal M902_MadVegetables $self_$41230;
		}
	}

	// Token: 0x02001832 RID: 6194
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$41232 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009030 RID: 36912 RVA: 0x0116D1F0 File Offset: 0x0116B3F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$41232(M902_MadVegetables self_)
		{
			if (11910 - 46254 != -34344)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (218317 - 598989 == -380672)
				{
					base..ctor();
					if (42677 - 592910 != -550232)
					{
						this.$self_$41237 = self_;
						if (15433 - 262643 == -247210)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009031 RID: 36913 RVA: 0x0116D288 File Offset: 0x0116B488
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M902_MadVegetables.$onDeadPlayer$41232.$(this.$self_$41237);
		}

		// Token: 0x06009032 RID: 36914 RVA: 0x0116D298 File Offset: 0x0116B498
		internal static bool PRugSBVkbGQ75BnwMdvF()
		{
			return true;
		}

		// Token: 0x06009033 RID: 36915 RVA: 0x0116D29C File Offset: 0x0116B49C
		internal static bool oTFd5GVkuoial1VDTPey()
		{
			return false;
		}

		// Token: 0x0400887E RID: 34942
		internal M902_MadVegetables $self_$41237;

		// Token: 0x02001833 RID: 6195
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009034 RID: 36916 RVA: 0x0116D2A0 File Offset: 0x0116B4A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M902_MadVegetables self_)
			{
				if (76159 - 497900 != -421741)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (272995 - 150063 == 122932)
					{
						base..ctor();
						if (85900 - 12523 != 73378)
						{
							this.$self_$41236 = self_;
							if (43094 - 12190 != 30905)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009035 RID: 36917 RVA: 0x0116D338 File Offset: 0x0116B538
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (166847 - 345156 != -178308)
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
						if (11329 - 507239 != -495910)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (93754 - 3695 != 90059)
							{
								continue;
							}
							goto IL_28A;
						}
						IL_F3:
						this.YieldDefault(1);
						if (277440 - 21035 != 256405)
						{
							continue;
						}
						goto IL_2F9;
						IL_28A:
						Game.mGameState = eGameState.Hold;
						if (199852 - 569426 != -369574)
						{
							continue;
						}
						this.$mStoryGui$41233 = (StoryGui)this.$self_$41236.GetComponent(typeof(StoryGui));
						if (16256 - 574847 == -558590)
						{
							continue;
						}
						if (this.$mStoryGui$41233)
						{
							if (63574 - 456042 != -392468)
							{
								continue;
							}
							this.$mStoryGui$41233.close();
							if (22424 - 85538 == -63113)
							{
								continue;
							}
						}
						this.$mChangeGui$41234 = (ChangeGui)this.$self_$41236.GetComponent(typeof(ChangeGui));
						if (1754 - 15908 == -14153)
						{
							continue;
						}
						if (this.$mChangeGui$41234)
						{
							if (293646 - 1468 != 292178)
							{
								continue;
							}
							this.$mChangeGui$41234.close();
							if (112756 - 140036 == -27279)
							{
								continue;
							}
						}
						this.$mGameGui$41235 = (GameGui)this.$self_$41236.GetComponent(typeof(GameGui));
						if (123238 - 472114 == -348875)
						{
							continue;
						}
						if (!this.$mGameGui$41235)
						{
							goto IL_F3;
						}
						if (37973 - 14622 == 23352)
						{
							continue;
						}
						if (!this.$mGameGui$41235.enabled)
						{
							if (199108 - 418920 != -219812)
							{
								continue;
							}
							this.$mGameGui$41235.enabled = true;
							if (128615 - 586050 == -457434)
							{
								continue;
							}
						}
						this.$mGameGui$41235.openDeadMenu();
						if (32811 - 274733 != -241922)
						{
							continue;
						}
						goto IL_F3;
					default:
						if (246984 - 223869 == 23116)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (91203 - 327471 != -236268);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06009036 RID: 36918 RVA: 0x0116D650 File Offset: 0x0116B850
			internal static bool C0focGVkIOmRiTxcnbQJ()
			{
				return true;
			}

			// Token: 0x06009037 RID: 36919 RVA: 0x0116D654 File Offset: 0x0116B854
			internal static bool z6Nhv1VkBvsq1DLg6O9s()
			{
				return false;
			}

			// Token: 0x0400887F RID: 34943
			internal StoryGui $mStoryGui$41233;

			// Token: 0x04008880 RID: 34944
			internal ChangeGui $mChangeGui$41234;

			// Token: 0x04008881 RID: 34945
			internal GameGui $mGameGui$41235;

			// Token: 0x04008882 RID: 34946
			internal M902_MadVegetables $self_$41236;
		}
	}

	// Token: 0x02001834 RID: 6196
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$41238 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009038 RID: 36920 RVA: 0x0116D658 File Offset: 0x0116B858
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$41238(Hashtable data, M902_MadVegetables self_)
		{
			if (154021 - 29193 != 124829)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (140956 - 318909 == -177953)
				{
					base..ctor();
					if (204746 - 348134 != -143387)
					{
						this.$data$41243 = data;
						if (264435 - 569917 == -305482)
						{
							this.$self_$41244 = self_;
							if (176015 - 151121 != 24895)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009039 RID: 36921 RVA: 0x0116D714 File Offset: 0x0116B914
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M902_MadVegetables.$onChangePlayer$41238.$(this.$data$41243, this.$self_$41244);
		}

		// Token: 0x0600903A RID: 36922 RVA: 0x0116D728 File Offset: 0x0116B928
		internal static bool xVWZusVkejNNHC1DEl2I()
		{
			return true;
		}

		// Token: 0x0600903B RID: 36923 RVA: 0x0116D72C File Offset: 0x0116B92C
		internal static bool HFrKWGVkrjxKStGkZIPi()
		{
			return false;
		}

		// Token: 0x04008883 RID: 34947
		internal Hashtable $data$41243;

		// Token: 0x04008884 RID: 34948
		internal M902_MadVegetables $self_$41244;

		// Token: 0x02001835 RID: 6197
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600903C RID: 36924 RVA: 0x0116D730 File Offset: 0x0116B930
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M902_MadVegetables self_)
			{
				if (72777 - 548836 != -476059)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (199324 - 153690 == 45634)
					{
						base..ctor();
						if (238042 - 506281 == -268239)
						{
							this.$data$41241 = data;
							if (146906 - 441909 != -295002)
							{
								this.$self_$41242 = self_;
								if (113102 - 591311 != -478208)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600903D RID: 36925 RVA: 0x0116D7EC File Offset: 0x0116B9EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (63756 - 72014 != -8258)
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
							if (269718 - 449069 != -179351)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (90863 - 555086 != -464223)
							{
								continue;
							}
							this.$mGameGui$41240 = (GameGui)this.$self_$41242.GetComponent(typeof(GameGui));
							if (213251 - 421333 != -208082)
							{
								continue;
							}
							this.$mGameGui$41240.enabled = true;
							if (281651 - 336682 != -55031)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (130332 - 81873 != 48460)
						{
							goto IL_205;
						}
						continue;
					default:
						if (8460 - 32023 == -23562)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (81995 - 306167 == -224172)
					{
						this.$self_$41242.SendMessage("onCreatePlayer", this.$data$41241);
						if (276096 - 256684 == 19412)
						{
							this.$mChangeGui$41239 = (ChangeGui)this.$self_$41242.GetComponent(typeof(ChangeGui));
							if (13730 - 113377 == -99647)
							{
								if (!this.$mChangeGui$41239.enabled)
								{
									break;
								}
								if (14565 - 441746 != -427180)
								{
									this.$mChangeGui$41239.close();
									if (235629 - 400194 != -164564)
									{
										break;
									}
								}
							}
						}
					}
				}
				IL_7E:
				return this.Yield(2, new WaitForSeconds(1f));
				goto IL_7E;
				IL_205:
				return false;
			}

			// Token: 0x0600903E RID: 36926 RVA: 0x0116DA10 File Offset: 0x0116BC10
			internal static bool sK9IGVVkj4pWHjxApYUt()
			{
				return true;
			}

			// Token: 0x0600903F RID: 36927 RVA: 0x0116DA14 File Offset: 0x0116BC14
			internal static bool PxIX8NVkhGvhI0dnsjUZ()
			{
				return false;
			}

			// Token: 0x04008885 RID: 34949
			internal ChangeGui $mChangeGui$41239;

			// Token: 0x04008886 RID: 34950
			internal GameGui $mGameGui$41240;

			// Token: 0x04008887 RID: 34951
			internal Hashtable $data$41241;

			// Token: 0x04008888 RID: 34952
			internal M902_MadVegetables $self_$41242;
		}
	}

	// Token: 0x02001836 RID: 6198
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$41245 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009040 RID: 36928 RVA: 0x0116DA18 File Offset: 0x0116BC18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$41245(M902_MadVegetables self_)
		{
			if (81586 - 428099 != -346512)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (98989 - 543369 == -444380)
				{
					base..ctor();
					if (74669 - 410552 != -335882)
					{
						this.$self_$41249 = self_;
						if (216993 - 133769 == 83224)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009041 RID: 36929 RVA: 0x0116DAB0 File Offset: 0x0116BCB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M902_MadVegetables.$ReturnToTown$41245.$(this.$self_$41249);
		}

		// Token: 0x06009042 RID: 36930 RVA: 0x0116DAC0 File Offset: 0x0116BCC0
		internal static bool UZGAE7VksfU2hTUFw4xS()
		{
			return true;
		}

		// Token: 0x06009043 RID: 36931 RVA: 0x0116DAC4 File Offset: 0x0116BCC4
		internal static bool DMta88Vk9hB3TUPhcjAa()
		{
			return false;
		}

		// Token: 0x04008889 RID: 34953
		internal M902_MadVegetables $self_$41249;

		// Token: 0x02001837 RID: 6199
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009044 RID: 36932 RVA: 0x0116DAC8 File Offset: 0x0116BCC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M902_MadVegetables self_)
			{
				if (254762 - 443586 != -188824)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (96464 - 391147 != -294682)
					{
						base..ctor();
						if (266497 - 135079 != 131419)
						{
							this.$self_$41248 = self_;
							if (105986 - 571162 == -465176)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009045 RID: 36933 RVA: 0x0116DB60 File Offset: 0x0116BD60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (246524 - 24230 != 222295)
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
						this.$self_$41248.LeaveGame();
						if (155517 - 518343 == -362825)
						{
							continue;
						}
						this.YieldDefault(1);
						if (159584 - 392647 != -233062)
						{
							goto Block_29;
						}
						continue;
					default:
						if (133972 - 187693 == -53720)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (131571 - 347973 == -216402)
					{
						Game.mStateTime = Time.time;
						if (99644 - 55249 != 44396)
						{
							this.$$switch$7406$41246 = PlayerData.SaveGuild;
							if (202556 - 465474 != -262917)
							{
								if (this.$$switch$7406$41246 == 1)
								{
									if (37316 - 286176 == -248859)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (234193 - 239503 == -5309)
									{
										continue;
									}
								}
								else if (this.$$switch$7406$41246 == 2)
								{
									if (153405 - 316050 != -162645)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (57356 - 569368 == -512011)
									{
										continue;
									}
								}
								else if (this.$$switch$7406$41246 == 3)
								{
									if (81951 - 584361 != -502410)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (250221 - 535909 == -285687)
									{
										continue;
									}
								}
								else if (this.$$switch$7406$41246 == 4)
								{
									if (291460 - 4199 != 287261)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (173202 - 508518 != -335316)
									{
										continue;
									}
								}
								else if (this.$$switch$7406$41246 == 5)
								{
									if (137777 - 307399 != -169622)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (231562 - 145709 != 85853)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (124120 - 242658 != -118538)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (49849 - 39442 == 10408)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (106924 - 149686 == -42761)
									{
										continue;
									}
								}
								this.$mGameGui$41247 = (GameGui)this.$self_$41248.GetComponent(typeof(GameGui));
								if (270512 - 196210 == 74302)
								{
									if (this.$mGameGui$41247)
									{
										if (136899 - 78269 != 58630)
										{
											continue;
										}
										this.$mGameGui$41247.close();
										if (8668 - 530195 != -521527)
										{
											continue;
										}
									}
									this.$self_$41248.SendMessage("fadeOut");
									if (100056 - 299864 == -199808)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_29:
				IL_3AD:
				return false;
			}

			// Token: 0x06009046 RID: 36934 RVA: 0x0116DF2C File Offset: 0x0116C12C
			internal static bool yHMFmQVk1FllhuSkXflG()
			{
				return true;
			}

			// Token: 0x06009047 RID: 36935 RVA: 0x0116DF30 File Offset: 0x0116C130
			internal static bool VCnRXKVk4ZKJo14B0x87()
			{
				return false;
			}

			// Token: 0x0400888A RID: 34954
			internal int $$switch$7406$41246;

			// Token: 0x0400888B RID: 34955
			internal GameGui $mGameGui$41247;

			// Token: 0x0400888C RID: 34956
			internal M902_MadVegetables $self_$41248;
		}
	}

	// Token: 0x02001838 RID: 6200
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$41250 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009048 RID: 36936 RVA: 0x0116DF34 File Offset: 0x0116C134
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$41250(M902_MadVegetables self_)
		{
			if (202031 - 561755 != -359724)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (295612 - 230893 == 64719)
				{
					base..ctor();
					if (180395 - 261536 == -81141)
					{
						this.$self_$41253 = self_;
						if (287172 - 42817 != 244356)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009049 RID: 36937 RVA: 0x0116DFCC File Offset: 0x0116C1CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M902_MadVegetables.$ReturnToGuild$41250.$(this.$self_$41253);
		}

		// Token: 0x0600904A RID: 36938 RVA: 0x0116DFDC File Offset: 0x0116C1DC
		internal static bool PsYGX7Vkzk1woM5bAaKo()
		{
			return true;
		}

		// Token: 0x0600904B RID: 36939 RVA: 0x0116DFE0 File Offset: 0x0116C1E0
		internal static bool EmO7WuVGa77kESJGLx8q()
		{
			return false;
		}

		// Token: 0x0400888D RID: 34957
		internal M902_MadVegetables $self_$41253;

		// Token: 0x02001839 RID: 6201
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600904C RID: 36940 RVA: 0x0116DFE4 File Offset: 0x0116C1E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M902_MadVegetables self_)
			{
				if (131219 - 5052 != 126167)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (237588 - 261434 != -23845)
					{
						base..ctor();
						if (198001 - 331994 != -133992)
						{
							this.$self_$41252 = self_;
							if (194573 - 449672 == -255099)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600904D RID: 36941 RVA: 0x0116E07C File Offset: 0x0116C27C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (175035 - 267944 != -92909)
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
						this.$self_$41252.LeaveGame();
						if (35116 - 59256 != -24140)
						{
							continue;
						}
						this.YieldDefault(1);
						if (84699 - 559293 != -474593)
						{
							goto Block_2;
						}
						continue;
					default:
						if (216670 - 459480 != -242810)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (149094 - 534572 != -385477)
					{
						Game.mStateTime = Time.time;
						if (125653 - 462396 != -336742)
						{
							Game.mNextGameCode = 31;
							if (127606 - 481795 == -354189)
							{
								this.$mGameGui$41251 = (GameGui)this.$self_$41252.GetComponent(typeof(GameGui));
								if (55679 - 233123 != -177443)
								{
									if (this.$mGameGui$41251)
									{
										if (49053 - 69831 == -20777)
										{
											continue;
										}
										this.$mGameGui$41251.close();
										if (39124 - 505330 != -466206)
										{
											continue;
										}
									}
									this.$self_$41252.SendMessage("fadeOut");
									if (293261 - 482506 == -189245)
									{
										goto IL_185;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_1BD;
				IL_185:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x0600904E RID: 36942 RVA: 0x0116E258 File Offset: 0x0116C458
			internal static bool kVu5PYVG5Ph6DXOVQaOh()
			{
				return true;
			}

			// Token: 0x0600904F RID: 36943 RVA: 0x0116E25C File Offset: 0x0116C45C
			internal static bool xw5AOSVGpJKq0kKhBwOu()
			{
				return false;
			}

			// Token: 0x0400888E RID: 34958
			internal GameGui $mGameGui$41251;

			// Token: 0x0400888F RID: 34959
			internal M902_MadVegetables $self_$41252;
		}
	}

	// Token: 0x0200183A RID: 6202
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$41254 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009050 RID: 36944 RVA: 0x0116E260 File Offset: 0x0116C460
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$41254(M902_MadVegetables self_)
		{
			if (128919 - 543472 != -414553)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (118116 - 66184 != 51933)
				{
					base..ctor();
					if (157335 - 424541 == -267206)
					{
						this.$self_$41258 = self_;
						if (80924 - 487967 != -407042)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009051 RID: 36945 RVA: 0x0116E2F8 File Offset: 0x0116C4F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M902_MadVegetables.$ReturnToCamp$41254.$(this.$self_$41258);
		}

		// Token: 0x06009052 RID: 36946 RVA: 0x0116E308 File Offset: 0x0116C508
		internal static bool KAmR58VGVc1aaxImSTFc()
		{
			return true;
		}

		// Token: 0x06009053 RID: 36947 RVA: 0x0116E30C File Offset: 0x0116C50C
		internal static bool rY2Y55VGtqQ387R1CkSJ()
		{
			return false;
		}

		// Token: 0x04008890 RID: 34960
		internal M902_MadVegetables $self_$41258;

		// Token: 0x0200183B RID: 6203
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009054 RID: 36948 RVA: 0x0116E310 File Offset: 0x0116C510
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M902_MadVegetables self_)
			{
				if (163291 - 94156 != 69135)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (199385 - 365771 != -166385)
					{
						base..ctor();
						if (185160 - 51833 == 133327)
						{
							this.$self_$41257 = self_;
							if (280026 - 276813 != 3214)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009055 RID: 36949 RVA: 0x0116E3A8 File Offset: 0x0116C5A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (194692 - 420101 != -225409)
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
						this.$self_$41257.LeaveGame();
						if (118560 - 361335 == -242774)
						{
							continue;
						}
						this.YieldDefault(1);
						if (39389 - 88243 != -48853)
						{
							goto Block_25;
						}
						continue;
					default:
						if (165424 - 119104 == 46321)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (288567 - 127387 != 161181)
					{
						Game.mStateTime = Time.time;
						if (207130 - 420664 == -213534)
						{
							this.$$switch$7408$41255 = PlayerData.SaveGuild;
							if (168590 - 142143 != 26448)
							{
								if (this.$$switch$7408$41255 == 1)
								{
									if (182197 - 593276 == -411078)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (166478 - 509037 != -342559)
									{
										continue;
									}
								}
								else if (this.$$switch$7408$41255 == 2)
								{
									if (230240 - 126144 == 104097)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (237503 - 469551 == -232047)
									{
										continue;
									}
								}
								else if (this.$$switch$7408$41255 == 3)
								{
									if (269563 - 280855 == -11291)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (146438 - 407182 == -260743)
									{
										continue;
									}
								}
								else if (this.$$switch$7408$41255 == 4)
								{
									if (116282 - 409356 == -293073)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (119907 - 503705 != -383798)
									{
										continue;
									}
								}
								else if (this.$$switch$7408$41255 == 5)
								{
									if (158051 - 262930 == -104878)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (262543 - 339045 != -76502)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (143002 - 504047 != -361045)
									{
										continue;
									}
								}
								this.$mGameGui$41256 = (GameGui)this.$self_$41257.GetComponent(typeof(GameGui));
								if (223896 - 598311 != -374414)
								{
									if (this.$mGameGui$41256)
									{
										if (278971 - 92580 == 186392)
										{
											continue;
										}
										this.$mGameGui$41256.close();
										if (134325 - 557215 != -422890)
										{
											continue;
										}
									}
									this.$self_$41257.SendMessage("fadeOut");
									if (255197 - 201418 == 53779)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_25:
				IL_363:
				return false;
			}

			// Token: 0x06009056 RID: 36950 RVA: 0x0116E72C File Offset: 0x0116C92C
			internal static bool yqQpwaVGNs5CGrO77Hvg()
			{
				return true;
			}

			// Token: 0x06009057 RID: 36951 RVA: 0x0116E730 File Offset: 0x0116C930
			internal static bool ssLnC5VGYN0KUXby5C6x()
			{
				return false;
			}

			// Token: 0x04008891 RID: 34961
			internal int $$switch$7408$41255;

			// Token: 0x04008892 RID: 34962
			internal GameGui $mGameGui$41256;

			// Token: 0x04008893 RID: 34963
			internal M902_MadVegetables $self_$41257;
		}
	}
}
