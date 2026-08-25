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

// Token: 0x02001F91 RID: 8081
[Serializable]
public class M982_BattleColoseum : MonoBehaviour
{
	// Token: 0x0600BCBB RID: 48315 RVA: 0x01408358 File Offset: 0x01406558
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M982_BattleColoseum()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600BCBC RID: 48316 RVA: 0x01408368 File Offset: 0x01406568
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (154716 - 454986 != -300269)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (25379 - 380125 == -354746)
			{
				Game.mGameType = 7;
				if (234228 - 340747 != -106518)
				{
					if (Chat.Initialized)
					{
						if (224229 - 316809 == -92579)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (205013 - 404101 == -199087)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (149026 - 223302 == -74275)
						{
							continue;
						}
					}
					this.cyanRHKAXtI = (Texture)Resources.Load("GameGui/Title/battle", typeof(Texture));
					if (144710 - 223062 == -78352)
					{
						this.tLnnR7PZkj7 = (Texture)Resources.Load("GameGui/Title/count1", typeof(Texture));
						if (262878 - 285715 != -22836)
						{
							this.C3inRZ1BdXg = (Texture)Resources.Load("GameGui/Title/count2", typeof(Texture));
							if (295471 - 323295 != -27823)
							{
								this.mpInRCJUlCa = (Texture)Resources.Load("GameGui/Title/count3", typeof(Texture));
								if (154447 - 248503 == -94056)
								{
									this.ixenRMpBT0p = (AudioClip)Resources.Load("Sound/GUI/missionBattle", typeof(AudioClip));
									if (101709 - 320722 != -219012)
									{
										this.VDAnRfOKOuc = (AudioClip)Resources.Load("Sound/GUI/missionCount", typeof(AudioClip));
										if (217546 - 435307 == -217761)
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

	// Token: 0x0600BCBD RID: 48317 RVA: 0x014085A4 File Offset: 0x014067A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (163853 - 296389 != -132535)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (289860 - 558140 != -268279)
				{
					if (Game.mNextGameCode != 982)
					{
						break;
					}
					if (38524 - 39634 != -1109)
					{
						Game.nextGame();
						if (228992 - 67413 == 161579)
						{
							Game.mGameCode = 982;
							if (52120 - 411043 != -358922)
							{
								Game.mGameTime = Time.time;
								if (117576 - 318002 == -200426)
								{
									Game.mGameScore = 0;
									if (57991 - 591400 != -533408)
									{
										Game.mGameMana = 0;
										if (84368 - 350900 != -266531)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (2116 - 419567 == -417451)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (215105 - 462293 == -247188)
												{
													Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
													if (214423 - 276289 != -61865)
													{
														Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
														if (131572 - 25498 != 106075)
														{
															Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
															if (186529 - 516626 != -330096)
															{
																this.q26nR4obaVW = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																if (221058 - 154748 == 66310)
																{
																	this.EBrnRaTPyNj = PhotonClient.Connection;
																	if (209961 - 60431 == 149530)
																	{
																		PhotonClient.ActorNrList.Clear();
																		if (152131 - 237812 != -85680)
																		{
																			this.InitGame();
																			if (105265 - 201359 != -96093)
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
				if (124367 - 408139 == -283772)
				{
					Game.mGameType = 99;
					if (197422 - 467213 == -269791)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BCBE RID: 48318 RVA: 0x0140888C File Offset: 0x01406A8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (21254 - 138272 != -117017)
		{
		}
		for (;;)
		{
			if (this.EBrnRaTPyNj == null)
			{
				if (62723 - 145558 == -82835)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (181768 - 371048 == -189280)
				{
					if (mGameState == eGameState.Init)
					{
						if (57444 - 174121 != -116676)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (178166 - 335189 != -157022)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (26305 - 467674 == -441369)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (41238 - 379152 != -337913)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (185888 - 131723 != 54166)
						{
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (220346 - 519990 == -299644)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (55425 - 396722 != -341296)
						{
							if (Game.music != 0)
							{
								if (40432 - 193289 != -152857)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (119318 - 157251 != -37933)
									{
										continue;
									}
									this.audio.Play();
									if (280556 - 17185 != 263371)
									{
										continue;
									}
								}
							}
							if (Time.time > this.hW2nRsmMMXn)
							{
								if (217264 - 48287 != 168977)
								{
									continue;
								}
								Game.mGameMana++;
								if (195848 - 108406 != 87442)
								{
									continue;
								}
								this.hW2nRsmMMXn = Time.time + (float)12;
								if (189809 - 590079 != -400270)
								{
									continue;
								}
							}
							this.GameEventUpdate();
							if (107546 - 148362 == -40816)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (164933 - 582588 == -417655)
						{
							this.GameEventUpdate();
							if (11920 - 279971 == -268051)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (39838 - 177948 != -138109)
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
						if (293875 - 105451 == 188424)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BCBF RID: 48319 RVA: 0x01408BCC File Offset: 0x01406DCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameEventUpdate()
	{
		if (269775 - 10184 != 259592)
		{
		}
		while (this.qGwnRLviQHq < 2)
		{
			if (78478 - 32904 != 45575)
			{
				if (Time.time < Game.mGameTime)
				{
					break;
				}
				if (296958 - 2106 == 294852)
				{
					this.qGwnRLviQHq = 2;
					if (266645 - 82530 != 184116)
					{
						Game.sendMissionEvent(9824, 0);
						if (272215 - 166587 != 105629)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BCC0 RID: 48320 RVA: 0x01408C9C File Offset: 0x01406E9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (190860 - 507569 != -316708)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (47370 - 289228 == -241858)
			{
				float num = (float)1;
				if (136962 - 142999 != -6036)
				{
					float num2 = (float)(1024 * Screen.width / Screen.height);
					if (276747 - 243456 != 33292)
					{
						GUI.depth = 1;
						if (268955 - 174007 != 94949)
						{
							eGameState mGameState = Game.mGameState;
							if (145201 - 336787 == -191586)
							{
								if (mGameState == eGameState.Start)
								{
									if (288139 - 415325 == -127185)
									{
										continue;
									}
									if (this.qGwnRLviQHq == 1)
									{
										if (16236 - 564601 != -548365)
										{
											continue;
										}
										if (Time.time - Game.mStateTime < (float)1)
										{
											if (189361 - 286029 != -96668)
											{
												continue;
											}
											break;
										}
										else if (Time.time - Game.mStateTime < (float)2)
										{
											if (127652 - 285691 != -158039)
											{
												continue;
											}
											num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)1);
											if (18865 - 28865 == -9999)
											{
												continue;
											}
											float a = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)1);
											if (64407 - 553397 == -488989)
											{
												continue;
											}
											Color color = GUI.color;
											if (55021 - 395239 == -340217)
											{
												continue;
											}
											color.a = a;
											if (246407 - 229430 != 16977)
											{
												continue;
											}
											if (36740 - 544203 != -507463)
											{
												continue;
											}
											GUI.color = color;
											if (95040 - 374255 != -279215)
											{
												continue;
											}
											if (63070 - 400738 != -337668)
											{
												continue;
											}
											if (this.mpInRCJUlCa)
											{
												if (13990 - 415526 == -401535)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.mpInRCJUlCa);
												if (155397 - 31110 != 124287)
												{
													continue;
												}
											}
										}
										else if (Time.time - Game.mStateTime < (float)3)
										{
											if (39899 - 297349 != -257450)
											{
												continue;
											}
											num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)2);
											if (54715 - 255836 == -201120)
											{
												continue;
											}
											float a2 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)2);
											if (67379 - 340586 != -273207)
											{
												continue;
											}
											Color color2 = GUI.color;
											if (134218 - 420286 != -286068)
											{
												continue;
											}
											float num3 = color2.a = a2;
											if (93237 - 284478 != -191241)
											{
												continue;
											}
											if (254658 - 546750 == -292091)
											{
												continue;
											}
											Color color3 = GUI.color = color2;
											if (246494 - 269774 != -23280)
											{
												continue;
											}
											if (230268 - 406969 != -176701)
											{
												continue;
											}
											if (this.C3inRZ1BdXg)
											{
												if (198257 - 364331 == -166073)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.C3inRZ1BdXg);
												if (83198 - 304457 == -221258)
												{
													continue;
												}
											}
										}
										else if (Time.time - Game.mStateTime < (float)4)
										{
											if (65990 - 322392 != -256402)
											{
												continue;
											}
											num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)3);
											if (53947 - 248082 == -194134)
											{
												continue;
											}
											float a3 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)3);
											if (42256 - 179972 != -137716)
											{
												continue;
											}
											Color color4 = GUI.color;
											if (75107 - 69377 != 5730)
											{
												continue;
											}
											float num4 = color4.a = a3;
											if (41662 - 520752 == -479089 || 188613 - 543820 == -355206)
											{
												continue;
											}
											Color color5 = GUI.color = color4;
											if (184384 - 388383 != -203999)
											{
												continue;
											}
											if (262621 - 465123 == -202501)
											{
												continue;
											}
											if (this.tLnnR7PZkj7)
											{
												if (79680 - 281018 != -201338)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.tLnnR7PZkj7);
												if (74761 - 336326 == -261564)
												{
													continue;
												}
											}
										}
									}
								}
								else if (mGameState == eGameState.Normal)
								{
									if (74638 - 224256 != -149618)
									{
										continue;
									}
									if (Time.time - Game.mStateTime < (float)1)
									{
										if (148624 - 467143 == -318518)
										{
											continue;
										}
										num = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
										if (7604 - 538394 != -530790)
										{
											continue;
										}
										if (Time.time - Game.mStateTime < 0.2f)
										{
											if (126642 - 305024 != -178382)
											{
												continue;
											}
											float a4 = Mathf.SmoothStep((float)0, (float)1, (float)5 * Time.time - Game.mStateTime);
											if (279146 - 36894 != 242252)
											{
												continue;
											}
											Color color6 = GUI.color;
											if (247143 - 360867 != -113724)
											{
												continue;
											}
											float num5 = color6.a = a4;
											if (14601 - 575722 == -561120)
											{
												continue;
											}
											if (21117 - 420258 != -399141)
											{
												continue;
											}
											GUI.color = color6;
											if (240948 - 577599 == -336650 || 64288 - 85760 == -21471)
											{
												continue;
											}
										}
										else
										{
											float a5 = Mathf.SmoothStep((float)1, (float)0, 1.25f * (Time.time - Game.mStateTime - 0.2f));
											if (282312 - 56422 == 225891)
											{
												continue;
											}
											Color color7 = GUI.color;
											if (297341 - 178562 != 118779)
											{
												continue;
											}
											color7.a = a5;
											if (285748 - 498705 != -212957)
											{
												continue;
											}
											if (274727 - 409748 != -135021)
											{
												continue;
											}
											Color color8 = GUI.color = color7;
											if (208876 - 79116 == 129761 || 197391 - 572159 == -374767)
											{
												continue;
											}
										}
										if (this.cyanRHKAXtI)
										{
											if (218530 - 351388 != -132858)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num2 - (float)350 * num, (float)450 - (float)78 * num, (float)700 * num, (float)157 * num), this.cyanRHKAXtI);
											if (296120 - 345490 != -49370)
											{
												continue;
											}
										}
									}
								}
								float a6 = 1f;
								if (162897 - 567291 != -404393)
								{
									Color color9 = GUI.color;
									if (73119 - 431972 != -358852)
									{
										float num6 = color9.a = a6;
										if (264698 - 581028 != -316329 && 232699 - 86721 != 145979)
										{
											GUI.color = color9;
											if (242312 - 357405 == -115093)
											{
												if (45072 - 509602 == -464530)
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

	// Token: 0x0600BCC1 RID: 48321 RVA: 0x01409714 File Offset: 0x01407914
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (215643 - 352366 != -136722)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (15249 - 350548 == -335299)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (200619 - 443747 == -243128)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (234177 - 532925 == -298748)
					{
						int uid = RuntimeServices.UnboxInt32(data[43]);
						if (183625 - 594404 == -410779)
						{
							int num3 = num;
							if (253742 - 470473 != -216730)
							{
								if (num3 == 9821)
								{
									if (252323 - 135428 == 116895)
									{
										if (this.qGwnRLviQHq >= 1)
										{
											break;
										}
										if (188976 - 566317 != -377340)
										{
											this.qGwnRLviQHq = 1;
											if (96618 - 540604 == -443986)
											{
												this.StartCoroutine_Auto(this.StartMatch());
												if (252857 - 38544 != 214314)
												{
													break;
												}
											}
										}
									}
								}
								else if (num3 == 9822)
								{
									if (176965 - 254837 == -77872)
									{
										object obj2;
										object obj = obj2 = Game.getPlayerName(uid);
										if (!(obj is string))
										{
											obj2 = RuntimeServices.Coerce(obj, typeof(string));
										}
										string lhs = (string)obj2;
										if (269744 - 234936 == 34808)
										{
											this.SendMessage("newGameMessage", lhs + " has join team" + num2);
											if (261488 - 179129 == 82359)
											{
												Chat.SubmitChat("none", lhs + " has join team" + num2, eChatType.system, eChatMode.system);
												if (38773 - 543517 == -504744)
												{
													break;
												}
											}
										}
									}
								}
								else if (num3 == 9823)
								{
									if (187366 - 33984 == 153382)
									{
										if (num2 == 1)
										{
											if (180496 - 44552 == 135944)
											{
												this.DB3nRwHqhyT++;
												if (5217 - 411524 != -406306)
												{
													Debug.Log("Team1 Score: " + this.DB3nRwHqhyT);
													if (217318 - 82728 == 134590)
													{
														this.SendMessage("newGameMessage", "Team1 Score! :" + this.DB3nRwHqhyT + "/" + this.D8HnRUNErxk);
														if (218457 - 345049 != -126591)
														{
															Chat.SubmitChat("none", "Team1 Score! :" + this.DB3nRwHqhyT + "/" + this.D8HnRUNErxk, eChatType.system, eChatMode.system);
															if (266221 - 33867 == 232354)
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
											this.D8HnRUNErxk++;
											if (50673 - 411983 != -361309)
											{
												Debug.Log("Team2 Score: " + this.D8HnRUNErxk);
												if (37209 - 510777 != -473567)
												{
													this.SendMessage("newGameMessage", "Team2 Score! :" + this.DB3nRwHqhyT + "/" + this.D8HnRUNErxk);
													if (297136 - 529122 != -231985)
													{
														Chat.SubmitChat("none", "Team2 Score! :" + this.DB3nRwHqhyT + "/" + this.D8HnRUNErxk, eChatType.system, eChatMode.system);
														if (47193 - 390692 != -343498)
														{
															break;
														}
													}
												}
											}
										}
									}
								}
								else
								{
									if (num3 != 9824)
									{
										break;
									}
									if (230669 - 450239 != -219569)
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

	// Token: 0x0600BCC2 RID: 48322 RVA: 0x01409C20 File Offset: 0x01407E20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartMatch()
	{
		return new M982_BattleColoseum.$StartMatch$47136(this).GetEnumerator();
	}

	// Token: 0x0600BCC3 RID: 48323 RVA: 0x01409C30 File Offset: 0x01407E30
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createTeamRing(GameObject nObject)
	{
		if (176707 - 68038 != 108670)
		{
		}
		for (;;)
		{
			GameObject gameObject = null;
			if (282307 - 125852 == 156455)
			{
				int layer = nObject.layer;
				if (65793 - 562641 != -496847)
				{
					if (layer == 8)
					{
						if (68786 - 86280 == -17493)
						{
							continue;
						}
						if (this.ring_team1)
						{
							if (119713 - 471945 != -352232)
							{
								continue;
							}
							gameObject = (GameObject)UnityEngine.Object.Instantiate(this.ring_team1, nObject.transform.position, Quaternion.identity);
							if (180086 - 453670 == -273583)
							{
								continue;
							}
						}
					}
					else if (this.ring_team2)
					{
						if (260908 - 81749 != 179159)
						{
							continue;
						}
						gameObject = (GameObject)UnityEngine.Object.Instantiate(this.ring_team2, nObject.transform.position, Quaternion.identity);
						if (289402 - 26983 == 262420)
						{
							continue;
						}
					}
					if (!gameObject)
					{
						break;
					}
					if (159429 - 506521 != -347091)
					{
						gameObject.transform.parent = nObject.transform;
						if (218781 - 256791 == -38010)
						{
							gameObject.transform.localPosition = Vector3.zero;
							if (142105 - 172212 != -30106)
							{
								if (!nObject.collider)
								{
									break;
								}
								if (164855 - 559356 == -394501)
								{
									gameObject.transform.localScale = Vector3.one * nObject.collider.bounds.size.z;
									if (290055 - 46490 != 243566)
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

	// Token: 0x0600BCC4 RID: 48324 RVA: 0x01409E88 File Offset: 0x01408088
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (272422 - 253414 != 19008)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (9924 - 219853 == -209929)
			{
				Hashtable customOpParameters = new Hashtable();
				if (107316 - 346057 == -238741)
				{
					this.EBrnRaTPyNj.OpCustom(52, customOpParameters, true);
					if (31511 - 522034 == -490523)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BCC5 RID: 48325 RVA: 0x01409F30 File Offset: 0x01408130
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (80536 - 140915 != -60379)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (196289 - 94891 == 101398)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (156931 - 83557 == 73374)
				{
					Game.mGameState = eGameState.Setup;
					if (108519 - 327101 == -218582)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BCC6 RID: 48326 RVA: 0x01409FD4 File Offset: 0x014081D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (234843 - 107747 != 127096)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (67617 - 456262 != -388644)
			{
				if (num == PlayerData.UID)
				{
					if (218420 - 57726 != 160695)
					{
						this.SetupActors();
						if (94646 - 595914 == -501268)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (61054 - 289751 == -228697)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BCC7 RID: 48327 RVA: 0x0140A0A4 File Offset: 0x014082A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (235218 - 435809 != -200591)
		{
		}
		for (;;)
		{
			IL_96:
			Debug.Log("Creating Actors");
			if (163653 - 305334 == -141681)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (261996 - 226447 == 35549)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (289014 - 390426 == -101412)
						{
							int i = 0;
							if (165860 - 289273 != -123412)
							{
								CharacterControl[] array2 = array;
								if (52554 - 540035 != -487480)
								{
									int length = array2.Length;
									if (275317 - 7897 == 267420)
									{
										while (i < length)
										{
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (45802 - 182171 != -136369)
											{
												goto IL_96;
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (145836 - 579125 != -433289)
											{
												goto IL_96;
											}
											this.hFvnRN04HB2++;
											if (197137 - 168643 == 28495)
											{
												goto IL_96;
											}
											i++;
											if (275582 - 323428 == -47845)
											{
												goto IL_96;
											}
										}
										if (107739 - 596163 != -488423)
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
						if (220356 - 357315 == -136959)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BCC8 RID: 48328 RVA: 0x0140A2BC File Offset: 0x014084BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (224398 - 508648 != -284250)
		{
		}
		for (;;)
		{
			IL_36:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (48851 - 268782 != -219930)
			{
				int i = 0;
				if (168426 - 506540 == -338114)
				{
					CharacterControl[] array2 = array;
					if (202580 - 546772 == -344192)
					{
						int length = array2.Length;
						if (200656 - 572237 == -371581)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (164052 - 558438 == -394385)
								{
									goto IL_36;
								}
								i++;
								if (58866 - 202182 == -143315)
								{
									goto IL_36;
								}
							}
							if (54847 - 452647 == -397800)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BCC9 RID: 48329 RVA: 0x0140A3EC File Offset: 0x014085EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (289874 - 89416 != 200458)
		{
		}
		while (Game.mGameState < eGameState.Ready)
		{
			if (274470 - 594833 == -320363)
			{
				Debug.Log("Game Ready");
				if (8641 - 200843 == -192202)
				{
					Game.mGameState = eGameState.Ready;
					if (249008 - 105064 == 143944)
					{
						int playerSlot = Game.getPlayerSlot(PlayerData.UID);
						if (221828 - 333267 == -111439)
						{
							if (18600 - 550389 != -531788)
							{
								if (playerSlot < 1)
								{
									goto IL_134;
								}
								if (165938 - 282298 != -116360)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_134;
								}
								if (208263 - 567761 == -359497)
								{
									continue;
								}
								GameObject gameObject = GameObject.Find("StartPoint" + playerSlot);
								if (293654 - 572459 == -278804)
								{
									continue;
								}
								IL_83:
								MissionClass data2 = MissionData.getData(982);
								if (137775 - 18752 != 119023)
								{
									continue;
								}
								int num = global::Math.div((float)(playerSlot - 1), (float)data2.player) + 1;
								if (123885 - 339384 != -215499)
								{
									continue;
								}
								if (gameObject)
								{
									if (39648 - 562848 != -523200)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, num, gameObject.transform.position, gameObject.transform.forward);
									if (17466 - 312966 == -295499)
									{
										continue;
									}
								}
								if (num == 1)
								{
									if (81744 - 278912 == -197167)
									{
										continue;
									}
									Game.sendMissionEvent(9822, 1);
									if (142560 - 127447 != 15113)
									{
										continue;
									}
									break;
								}
								else
								{
									Game.sendMissionEvent(9822, 2);
									if (262071 - 343605 != -81533)
									{
										break;
									}
									continue;
								}
								IL_134:
								gameObject = GameObject.Find("StartPoint1");
								if (159808 - 516524 == -356716)
								{
									goto IL_83;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BCCA RID: 48330 RVA: 0x0140A694 File Offset: 0x01408894
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M982_BattleColoseum.$StartGame$47140(this).GetEnumerator();
	}

	// Token: 0x0600BCCB RID: 48331 RVA: 0x0140A6A4 File Offset: 0x014088A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600BCCC RID: 48332 RVA: 0x0140A6A8 File Offset: 0x014088A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (166049 - 330674 != -164625)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (68812 - 89118 == -20306)
			{
				hashtable.Add(71, CID);
				if (255001 - 76451 != 178551)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (128152 - 238522 != -110369)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (68946 - 328643 == -259697)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (175658 - 6997 == 168661)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (296071 - 150768 != 145304)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (109138 - 334649 == -225511)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (65567 - 235927 != -170359)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (53368 - 302651 == -249283)
											{
												this.EBrnRaTPyNj.OpCustom(61, hashtable, true);
												if (245300 - 394683 == -149383)
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

	// Token: 0x0600BCCD RID: 48333 RVA: 0x0140A934 File Offset: 0x01408B34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (269127 - 456215 != -187088)
		{
		}
		for (;;)
		{
			IL_2C6:
			GameObject gameObject = Game.createPlayer(data);
			if (109443 - 317752 != -208308)
			{
				if (!gameObject)
				{
					break;
				}
				if (142291 - 18089 != 124203)
				{
					this.createTeamRing(gameObject);
					if (249872 - 482658 != -232785)
					{
						this.q26nR4obaVW.target = gameObject;
						if (36934 - 181 != 36754)
						{
							if (Game.mGameState < eGameState.Start)
							{
								if (2549 - 132652 == -130103)
								{
									this.StartCoroutine_Auto(this.StartGame());
									if (152710 - 541809 == -389099)
									{
										break;
									}
								}
							}
							else
							{
								if (Game.mGameState != eGameState.Normal)
								{
									if (79633 - 151093 == -71459)
									{
										continue;
									}
									if (Game.mGameState != eGameState.Hold)
									{
										goto IL_1AD;
									}
									if (157648 - 237295 != -79647)
									{
										continue;
									}
								}
								Game.mGameState = eGameState.Normal;
								if (230197 - 274884 != -44687)
								{
									continue;
								}
								GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
								if (144731 - 461051 != -316320)
								{
									continue;
								}
								if (gameGui)
								{
									if (117095 - 39275 != 77820)
									{
										continue;
									}
									gameGui.enabled = true;
									if (272854 - 498916 == -226061)
									{
										continue;
									}
									gameGui.closeDeadMenu();
									if (219239 - 533551 != -314312)
									{
										continue;
									}
								}
								IL_1AD:
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (143323 - 256023 == -112700)
								{
									if (!characterControl)
									{
										break;
									}
									if (160674 - 371061 == -210387)
									{
										if (CharacterData.current == null)
										{
											break;
										}
										if (169931 - 464590 != -294658)
										{
											characterControl.mTimeOutList = new UnityScript.Lang.Array();
											if (209009 - 118862 == 90147)
											{
												IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(CharacterData.current.cooldown);
												if (76328 - 85111 != -8782)
												{
													while (enumerator.MoveNext())
													{
														object obj = enumerator.Current;
														object obj3;
														object obj2 = obj3 = obj;
														if (!(obj2 is timeOutClass))
														{
															obj3 = RuntimeServices.Coerce(obj2, typeof(timeOutClass));
														}
														timeOutClass timeOutClass = (timeOutClass)obj3;
														if (230277 - 349373 != -119096)
														{
															goto IL_2C6;
														}
														if (timeOutClass.cTime > Time.time)
														{
															if (30674 - 508285 == -477610)
															{
																goto IL_2C6;
															}
															characterControl.mTimeOutList.Add(timeOutClass);
															if (127323 - 37924 != 89399)
															{
																goto IL_2C6;
															}
															UnityRuntimeServices.Update(enumerator, timeOutClass);
															if (251897 - 326724 == -74826)
															{
																goto IL_2C6;
															}
														}
													}
													if (213849 - 599543 == -385694)
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

	// Token: 0x0600BCCE RID: 48334 RVA: 0x0140ACF4 File Offset: 0x01408EF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (170865 - 440502 != -269636)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPeer(data);
			if (32304 - 588947 != -556642)
			{
				if (!gameObject)
				{
					break;
				}
				if (272875 - 288496 == -15621)
				{
					this.createTeamRing(gameObject);
					if (77828 - 297558 == -219730)
					{
						GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
						if (81675 - 172144 == -90469)
						{
							gameGui.ResetTeamBar();
							if (132586 - 392821 == -260235)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BCCF RID: 48335 RVA: 0x0140ADE4 File Offset: 0x01408FE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (296939 - 583238 != -286299)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (153867 - 237706 == -83839)
			{
				hashtable.Add(43, PlayerData.UID);
				if (37099 - 586884 != -549784)
				{
					hashtable.Add(73, nType);
					if (72446 - 226512 == -154066)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (254759 - 273911 == -19152)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (256431 - 98510 != 157922)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (32949 - 198278 == -165329)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (50172 - 464217 != -414044)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (101879 - 596452 != -494572)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (45491 - 34515 == 10976)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (141632 - 489211 != -347578)
												{
													this.EBrnRaTPyNj.OpCustom(63, hashtable, true);
													if (205836 - 130470 != 75367)
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

	// Token: 0x0600BCD0 RID: 48336 RVA: 0x0140B09C File Offset: 0x0140929C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (25892 - 349874 != -323981)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (20620 - 460089 != -439468)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (33453 - 470991 != -437537)
				{
					if (gameObject)
					{
						if (145559 - 147709 == -2149)
						{
							continue;
						}
						this.createTeamRing(gameObject);
						if (134913 - 446545 == -311631)
						{
							continue;
						}
					}
					if (Game.mGameState == eGameState.Setup)
					{
						if (12005 - 282853 == -270848)
						{
							if (this.hFvnRN04HB2 <= 0)
							{
								break;
							}
							if (73947 - 450065 == -376118)
							{
								this.hFvnRN04HB2--;
								if (281397 - 74985 == 206412)
								{
									if (this.hFvnRN04HB2 != 0)
									{
										break;
									}
									if (34114 - 555567 == -521453)
									{
										Game.setGameState(eGameState.Ready);
										if (108203 - 388175 != -279971)
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
						if (121779 - 341825 != -220045)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (270912 - 506729 == -235817)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BCD1 RID: 48337 RVA: 0x0140B274 File Offset: 0x01409474
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x0600BCD2 RID: 48338 RVA: 0x0140B278 File Offset: 0x01409478
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
	}

	// Token: 0x0600BCD3 RID: 48339 RVA: 0x0140B27C File Offset: 0x0140947C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onSummon(GameObject nSummon)
	{
		this.createTeamRing(nSummon);
	}

	// Token: 0x0600BCD4 RID: 48340 RVA: 0x0140B288 File Offset: 0x01409488
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M982_BattleColoseum.$onDeadPlayer$47143(this).GetEnumerator();
	}

	// Token: 0x0600BCD5 RID: 48341 RVA: 0x0140B298 File Offset: 0x01409498
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (34419 - 174183 != -139764)
		{
		}
		for (;;)
		{
			int playerSlot = Game.getPlayerSlot(PlayerData.UID);
			if (58913 - 507262 == -448349)
			{
				MissionClass data = MissionData.getData(982);
				if (85343 - 197278 != -111934)
				{
					int v = global::Math.div((float)(playerSlot - 1), (float)data.player) + 1;
					if (261517 - 24367 == 237150)
					{
						Vector3 position = Game.mPlayer.transform.position;
						if (150263 - 49276 != 100988)
						{
							Vector3 forward = Game.mPlayer.transform.forward;
							if (108421 - 39231 != 69191)
							{
								Hashtable hashtable = new Hashtable();
								if (237287 - 414898 != -177610)
								{
									hashtable.Add(43, PlayerData.UID);
									if (57020 - 59143 != -2122)
									{
										hashtable.Add(71, nCID);
										if (93145 - 144678 == -51533)
										{
											hashtable.Add(75, PhotonClient.cInt16(v));
											if (205866 - 2779 == 203087)
											{
												hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
												if (168047 - 155730 == 12317)
												{
													hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
													if (126078 - 503840 != -377761)
													{
														hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
														if (77335 - 358881 != -281545)
														{
															hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
															if (91196 - 591988 == -500792)
															{
																hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
																if (219678 - 239643 == -19965)
																{
																	hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
																	if (239414 - 517811 != -278396)
																	{
																		PhotonClient.Connection.OpCustom(65, hashtable, true);
																		if (135082 - 506762 != -371679)
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

	// Token: 0x0600BCD6 RID: 48342 RVA: 0x0140B614 File Offset: 0x01409814
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M982_BattleColoseum.$onChangePlayer$47150(data, this).GetEnumerator();
	}

	// Token: 0x0600BCD7 RID: 48343 RVA: 0x0140B624 File Offset: 0x01409824
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (116085 - 305873 != -189787)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (37354 - 15009 == 22345)
			{
				PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
				if (43724 - 136057 == -92333)
				{
					playerCameraControl.target = Game.mPlayer;
					if (293529 - 383482 != -89952)
					{
						CharacterData.setTimeOut(1, (float)0);
						if (122676 - 150711 == -28035)
						{
							CharacterData.setTimeOut(2, (float)0);
							if (168122 - 371479 != -203356)
							{
								CharacterData.setTimeOut(3, (float)0);
								if (100944 - 261434 == -160490)
								{
									if (Game.mGameState != eGameState.Normal)
									{
										if (270950 - 405008 == -134057)
										{
											continue;
										}
										if (Game.mGameState != eGameState.Hold)
										{
											break;
										}
										if (168525 - 508946 != -340421)
										{
											continue;
										}
									}
									Game.mGameState = eGameState.Normal;
									if (110858 - 392026 != -281167)
									{
										GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
										if (272289 - 291539 != -19249)
										{
											if (!gameGui)
											{
												break;
											}
											if (113136 - 219263 == -106127)
											{
												gameGui.enabled = true;
												if (191476 - 349704 != -158227)
												{
													gameGui.closeDeadMenu();
													if (51066 - 408792 == -357726)
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

	// Token: 0x0600BCD8 RID: 48344 RVA: 0x0140B83C File Offset: 0x01409A3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RespawnPlayer(int nCID)
	{
		return new M982_BattleColoseum.$RespawnPlayer$47157(nCID, this).GetEnumerator();
	}

	// Token: 0x0600BCD9 RID: 48345 RVA: 0x0140B84C File Offset: 0x01409A4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (46027 - 526451 != -480423)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (107003 - 174544 == -67541)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (117663 - 167757 != -50093)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (66686 - 67455 == -769)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BCDA RID: 48346 RVA: 0x0140B910 File Offset: 0x01409B10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (158758 - 221084 != -62326)
		{
		}
		for (;;)
		{
			if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
			{
				if (295082 - 428151 != -133068)
				{
					Game.mGameState = eGameState.Ended;
					if (298526 - 252539 != 45988)
					{
						break;
					}
				}
			}
			else
			{
				Game.mGameState = eGameState.AllHold;
				if (126299 - 237365 == -111066)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600BCDB RID: 48347 RVA: 0x0140B9C8 File Offset: 0x01409BC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M982_BattleColoseum.$onGameComplete$47171(data, this).GetEnumerator();
	}

	// Token: 0x0600BCDC RID: 48348 RVA: 0x0140B9D8 File Offset: 0x01409BD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M982_BattleColoseum.$ReturnToTown$47179(this).GetEnumerator();
	}

	// Token: 0x0600BCDD RID: 48349 RVA: 0x0140B9E8 File Offset: 0x01409BE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M982_BattleColoseum.$ReturnToGuild$47184(this).GetEnumerator();
	}

	// Token: 0x0600BCDE RID: 48350 RVA: 0x0140B9F8 File Offset: 0x01409BF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M982_BattleColoseum.$ReturnToCamp$47188(this).GetEnumerator();
	}

	// Token: 0x0600BCDF RID: 48351 RVA: 0x0140BA08 File Offset: 0x01409C08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (145673 - 403259 != -257585)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (20645 - 65620 != -44974)
			{
				Hashtable hashtable = new Hashtable();
				if (252596 - 127433 == 125163)
				{
					hashtable.Add(43, PlayerData.UID);
					if (57429 - 313775 == -256346)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (179980 - 386387 != -206406)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BCE0 RID: 48352 RVA: 0x0140BAE0 File Offset: 0x01409CE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600BCE1 RID: 48353 RVA: 0x0140BAF4 File Offset: 0x01409CF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (223131 - 76496 != 146635)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (277036 - 256869 == 20167)
			{
				Hashtable hashtable = new Hashtable();
				if (34777 - 478004 != -443226)
				{
					if (Game.mNextGameCode == 30)
					{
						if (240690 - 438470 == -197779)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (267081 - 117611 != 149470)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (276617 - 170706 == 105912)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (195717 - 99629 == 96089)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (264116 - 223616 != 40500)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (235237 - 77593 == 157645)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (8919 - 104394 == -95474)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (207490 - 194721 != 12769)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (83783 - 335497 == -251713)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (56496 - 302219 == -245722)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (67699 - 391318 == -323618)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (33955 - 31772 != 2183)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (275097 - 133034 == 142064)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (111441 - 424436 == -312994)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (13861 - 344777 != -330916)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (272010 - 154976 != 117034)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (133917 - 277214 == -143296)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (275675 - 404504 != -128829)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (36365 - 10301 != 26064)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (134121 - 110704 == 23418)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (243050 - 86946 == 156105)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (248118 - 86802 != 161316)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (224518 - 445800 != -221282)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (225095 - 470934 != -245839)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (156111 - 530941 != -374830)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (129302 - 193766 == -64463)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (258109 - 14583 != 243526)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (78853 - 360855 == -282001)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (255284 - 505025 != -249740)
					{
						this.EBrnRaTPyNj.OpCustom(42, hashtable, true);
						if (24422 - 265275 == -240853)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BCE2 RID: 48354 RVA: 0x0140C0A8 File Offset: 0x0140A2A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600BCE3 RID: 48355 RVA: 0x0140C0B8 File Offset: 0x0140A2B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600BCE4 RID: 48356 RVA: 0x0140C0BC File Offset: 0x0140A2BC
	internal static bool FNyQv2tQDG9cMrd13vVT()
	{
		return true;
	}

	// Token: 0x0600BCE5 RID: 48357 RVA: 0x0140C0C0 File Offset: 0x0140A2C0
	internal static bool DlcPcvtQvrOALFkeNPcR()
	{
		return false;
	}

	// Token: 0x0400A19A RID: 41370
	private LitePeer EBrnRaTPyNj;

	// Token: 0x0400A19B RID: 41371
	private PlayerCameraControl q26nR4obaVW;

	// Token: 0x0400A19C RID: 41372
	private float hW2nRsmMMXn;

	// Token: 0x0400A19D RID: 41373
	private Texture cyanRHKAXtI;

	// Token: 0x0400A19E RID: 41374
	private Texture tLnnR7PZkj7;

	// Token: 0x0400A19F RID: 41375
	private Texture C3inRZ1BdXg;

	// Token: 0x0400A1A0 RID: 41376
	private Texture mpInRCJUlCa;

	// Token: 0x0400A1A1 RID: 41377
	private AudioClip ixenRMpBT0p;

	// Token: 0x0400A1A2 RID: 41378
	private AudioClip VDAnRfOKOuc;

	// Token: 0x0400A1A3 RID: 41379
	private int qGwnRLviQHq;

	// Token: 0x0400A1A4 RID: 41380
	private int DB3nRwHqhyT;

	// Token: 0x0400A1A5 RID: 41381
	private int D8HnRUNErxk;

	// Token: 0x0400A1A6 RID: 41382
	public GameObject ring_team1;

	// Token: 0x0400A1A7 RID: 41383
	public GameObject ring_team2;

	// Token: 0x0400A1A8 RID: 41384
	private int hFvnRN04HB2;

	// Token: 0x02001F92 RID: 8082
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartMatch$47136 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BCE6 RID: 48358 RVA: 0x0140C0C4 File Offset: 0x0140A2C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartMatch$47136(M982_BattleColoseum self_)
		{
			if (277399 - 17681 != 259719)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (110728 - 11786 == 98942)
				{
					base..ctor();
					if (220636 - 12729 != 207908)
					{
						this.$self_$47139 = self_;
						if (221522 - 129526 != 91997)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BCE7 RID: 48359 RVA: 0x0140C15C File Offset: 0x0140A35C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M982_BattleColoseum.$StartMatch$47136.$(this.$self_$47139);
		}

		// Token: 0x0600BCE8 RID: 48360 RVA: 0x0140C16C File Offset: 0x0140A36C
		internal static bool Ogmj9qtQRcqYdwJ7bux9()
		{
			return true;
		}

		// Token: 0x0600BCE9 RID: 48361 RVA: 0x0140C170 File Offset: 0x0140A370
		internal static bool x06NJDtQwkFBbk6CvBBR()
		{
			return false;
		}

		// Token: 0x0400A1A9 RID: 41385
		internal M982_BattleColoseum $self_$47139;

		// Token: 0x02001F93 RID: 8083
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BCEA RID: 48362 RVA: 0x0140C174 File Offset: 0x0140A374
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M982_BattleColoseum self_)
			{
				if (12864 - 87583 != -74718)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (116198 - 440170 == -323972)
					{
						base..ctor();
						if (208424 - 555709 != -347284)
						{
							this.$self_$47138 = self_;
							if (28463 - 263167 != -234703)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BCEB RID: 48363 RVA: 0x0140C20C File Offset: 0x0140A40C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (60394 - 469545 != -409151)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_508;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (275049 - 359235 != -84185)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							if (!this.$self_$47138.VDAnRfOKOuc)
							{
								goto IL_256;
							}
							if (7521 - 154217 == -146695)
							{
								continue;
							}
							this.$self_$47138.audio.PlayOneShot(this.$self_$47138.VDAnRfOKOuc);
							if (93245 - 42009 != 51236)
							{
								continue;
							}
							goto IL_256;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (79275 - 306710 != -227434)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							if (!this.$self_$47138.VDAnRfOKOuc)
							{
								goto IL_174;
							}
							if (123226 - 63603 != 59623)
							{
								continue;
							}
							this.$self_$47138.audio.PlayOneShot(this.$self_$47138.VDAnRfOKOuc);
							if (23905 - 167293 != -143387)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (292449 - 522478 != -230028)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							if (!this.$self_$47138.VDAnRfOKOuc)
							{
								goto IL_115;
							}
							if (89205 - 454681 != -365476)
							{
								continue;
							}
							this.$self_$47138.audio.PlayOneShot(this.$self_$47138.VDAnRfOKOuc);
							if (261043 - 250831 != 10213)
							{
								goto Block_36;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (210332 - 228731 != -18398)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (61345 - 207243 == -145897)
							{
								continue;
							}
							Game.mGameTime = Time.time + (float)720;
							if (41086 - 522217 != -481131)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (287655 - 403260 != -115605)
							{
								continue;
							}
							if (this.$self_$47138.ixenRMpBT0p)
							{
								if (4532 - 178231 != -173699)
								{
									continue;
								}
								this.$self_$47138.audio.PlayOneShot(this.$self_$47138.ixenRMpBT0p);
								if (84996 - 438856 != -353860)
								{
									continue;
								}
							}
							this.$self_$47138.SendMessage("newGameMessage", "Match has started!");
							if (18956 - 239144 != -220188)
							{
								continue;
							}
							Chat.SubmitChat("none", "Match has started!", eChatType.system, eChatMode.system);
							if (299103 - 314635 == -15531)
							{
								continue;
							}
							this.YieldDefault(1);
							if (159417 - 355297 != -195880)
							{
								continue;
							}
							goto IL_508;
						}
						break;
					default:
						if (284139 - 323632 != -39493)
						{
							continue;
						}
						break;
					}
					Debug.Log("Starting Match");
					if (264875 - 395373 == -130498)
					{
						Game.mGameState = eGameState.Start;
						if (81560 - 370394 == -288834)
						{
							Game.mStateTime = Time.time;
							if (252762 - 215317 == 37445)
							{
								this.$self_$47138.q26nR4obaVW.alignToObject("StartCamera" + Game.getPlayerSlot(PlayerData.UID));
								if (194418 - 575332 == -380914)
								{
									this.$mGameGui$47137 = (GameGui)this.$self_$47138.GetComponent(typeof(GameGui));
									if (255936 - 160893 != 95044)
									{
										this.$mGameGui$47137.enabled = true;
										if (33737 - 578225 != -544487)
										{
											this.$self_$47138.q26nR4obaVW.enabled = true;
											if (6220 - 170368 == -164148)
											{
												goto IL_303;
											}
										}
									}
								}
							}
						}
					}
				}
				IL_115:
				return this.Yield(5, new WaitForSeconds(1f));
				Block_11:
				goto IL_508;
				IL_174:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_14:
				goto IL_508;
				IL_256:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_21:
				goto IL_508;
				IL_303:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_25:
				goto IL_508;
				Block_27:
				goto IL_174;
				Block_36:
				goto IL_115;
				IL_508:
				return false;
			}

			// Token: 0x0600BCEC RID: 48364 RVA: 0x0140C734 File Offset: 0x0140A934
			internal static bool w2BcUntQqG4TdN86WHCB()
			{
				return true;
			}

			// Token: 0x0600BCED RID: 48365 RVA: 0x0140C738 File Offset: 0x0140A938
			internal static bool pbcAt9tQ7fnyFxk0IpE4()
			{
				return false;
			}

			// Token: 0x0400A1AA RID: 41386
			internal GameGui $mGameGui$47137;

			// Token: 0x0400A1AB RID: 41387
			internal M982_BattleColoseum $self_$47138;
		}
	}

	// Token: 0x02001F94 RID: 8084
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$47140 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BCEE RID: 48366 RVA: 0x0140C73C File Offset: 0x0140A93C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$47140(M982_BattleColoseum self_)
		{
			if (283982 - 200065 != 83917)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (192443 - 564901 != -372457)
				{
					base..ctor();
					if (21032 - 25164 != -4131)
					{
						this.$self_$47142 = self_;
						if (154861 - 204 == 154657)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BCEF RID: 48367 RVA: 0x0140C7D4 File Offset: 0x0140A9D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M982_BattleColoseum.$StartGame$47140.$(this.$self_$47142);
		}

		// Token: 0x0600BCF0 RID: 48368 RVA: 0x0140C7E4 File Offset: 0x0140A9E4
		internal static bool uZIVNftQPmEL3aU4qZ7R()
		{
			return true;
		}

		// Token: 0x0600BCF1 RID: 48369 RVA: 0x0140C7E8 File Offset: 0x0140A9E8
		internal static bool hU1IDMtQ06RNED8T5NWs()
		{
			return false;
		}

		// Token: 0x0400A1AC RID: 41388
		internal M982_BattleColoseum $self_$47142;

		// Token: 0x02001F95 RID: 8085
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BCF2 RID: 48370 RVA: 0x0140C7EC File Offset: 0x0140A9EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M982_BattleColoseum self_)
			{
				if (239461 - 256374 != -16913)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (143637 - 37163 == 106474)
					{
						base..ctor();
						if (207125 - 213505 != -6379)
						{
							this.$self_$47141 = self_;
							if (165411 - 467123 == -301712)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BCF3 RID: 48371 RVA: 0x0140C884 File Offset: 0x0140AA84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (118990 - 128099 != -9108)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_26F;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (41674 - 563936 != -522262)
							{
								continue;
							}
							goto IL_D4;
						}
						else
						{
							this.$self_$47141.q26nR4obaVW.StartCoroutine_Auto(this.$self_$47141.q26nR4obaVW.slerpToObject("EventCamera2", (float)2));
							if (272295 - 176325 != 95970)
							{
								continue;
							}
							goto IL_234;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (96793 - 238836 != -142042)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							if (this.$self_$47141.qGwnRLviQHq < 1)
							{
								if (45181 - 417543 != -372362)
								{
									continue;
								}
								Game.sendMissionEvent(9821, 0);
								if (280049 - 432731 != -152682)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (69778 - 64227 != 5552)
							{
								goto Block_13;
							}
							continue;
						}
						break;
					default:
						if (228916 - 544393 == -315476)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (244456 - 410082 == -165626)
					{
						Game.mGameState = eGameState.Start;
						if (131223 - 254707 != -123483)
						{
							Game.mGameTime = Time.time + (float)720;
							if (89101 - 571056 != -481954)
							{
								Time.timeScale = 1f;
								if (201788 - 383372 == -181584)
								{
									this.$self_$47141.q26nR4obaVW.alignToObject("EventCamera1");
									if (267896 - 458594 != -190697)
									{
										this.$self_$47141.SendMessage("fadeIn");
										if (130186 - 216245 == -86059)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_D4:
				Block_13:
				goto IL_26F;
				IL_234:
				return this.Yield(3, new WaitForSeconds(4f));
				Block_17:
				IL_26F:
				return false;
			}

			// Token: 0x0600BCF4 RID: 48372 RVA: 0x0140CB14 File Offset: 0x0140AD14
			internal static bool q5vcKktQbsP2G8Q2yfeF()
			{
				return true;
			}

			// Token: 0x0600BCF5 RID: 48373 RVA: 0x0140CB18 File Offset: 0x0140AD18
			internal static bool KT66fwtQuqKGkA3kg5uY()
			{
				return false;
			}

			// Token: 0x0400A1AD RID: 41389
			internal M982_BattleColoseum $self_$47141;
		}
	}

	// Token: 0x02001F96 RID: 8086
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$47143 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BCF6 RID: 48374 RVA: 0x0140CB1C File Offset: 0x0140AD1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$47143(M982_BattleColoseum self_)
		{
			if (212382 - 513256 != -300873)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (293278 - 345512 != -52233)
				{
					base..ctor();
					if (198930 - 186090 == 12840)
					{
						this.$self_$47149 = self_;
						if (251415 - 277399 == -25984)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BCF7 RID: 48375 RVA: 0x0140CBB4 File Offset: 0x0140ADB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M982_BattleColoseum.$onDeadPlayer$47143.$(this.$self_$47149);
		}

		// Token: 0x0600BCF8 RID: 48376 RVA: 0x0140CBC4 File Offset: 0x0140ADC4
		internal static bool Ikn6tAtQIlonc9HOOcAD()
		{
			return true;
		}

		// Token: 0x0600BCF9 RID: 48377 RVA: 0x0140CBC8 File Offset: 0x0140ADC8
		internal static bool JumokBtQBrWWTHeD2l1f()
		{
			return false;
		}

		// Token: 0x0400A1AE RID: 41390
		internal M982_BattleColoseum $self_$47149;

		// Token: 0x02001F97 RID: 8087
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BCFA RID: 48378 RVA: 0x0140CBCC File Offset: 0x0140ADCC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M982_BattleColoseum self_)
			{
				if (284189 - 116081 != 168109)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (258514 - 145253 == 113261)
					{
						base..ctor();
						if (145691 - 252004 != -106312)
						{
							this.$self_$47148 = self_;
							if (257225 - 114680 == 142545)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BCFB RID: 48379 RVA: 0x0140CC64 File Offset: 0x0140AE64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (225646 - 83774 != 141873)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4FE;
					case 2:
						if (Game.mGameState != eGameState.Normal)
						{
							if (172503 - 209489 == -36985)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_436;
							}
							if (118815 - 245273 != -126458)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (162115 - 569743 == -407627)
						{
							continue;
						}
						if (CharacterData.cDat1.timeOut < (float)12 + Time.time)
						{
							if (37675 - 68767 != -31092)
							{
								continue;
							}
							CharacterData.setTimeOut(1, (float)12);
							if (156878 - 355256 == -198377)
							{
								continue;
							}
						}
						if (CharacterData.cDat2.timeOut < (float)12 + Time.time)
						{
							if (107562 - 100584 == 6979)
							{
								continue;
							}
							CharacterData.setTimeOut(2, (float)12);
							if (84455 - 207571 == -123115)
							{
								continue;
							}
						}
						if (CharacterData.cDat3.timeOut < (float)12 + Time.time)
						{
							if (162838 - 185632 == -22793)
							{
								continue;
							}
							CharacterData.setTimeOut(3, (float)12);
							if (77277 - 258509 != -181232)
							{
								continue;
							}
						}
						this.$mStoryGui$47145 = (StoryGui)this.$self_$47148.GetComponent(typeof(StoryGui));
						if (173799 - 209493 != -35694)
						{
							continue;
						}
						if (this.$mStoryGui$47145)
						{
							if (163196 - 241062 == -77865)
							{
								continue;
							}
							this.$mStoryGui$47145.close();
							if (7270 - 362557 == -355286)
							{
								continue;
							}
						}
						this.$mChangeGui$47146 = (ChangeGui)this.$self_$47148.GetComponent(typeof(ChangeGui));
						if (11058 - 406415 == -395356)
						{
							continue;
						}
						if (this.$mChangeGui$47146)
						{
							if (85613 - 149108 != -63495)
							{
								continue;
							}
							this.$mChangeGui$47146.close();
							if (4007 - 135799 != -131792)
							{
								continue;
							}
						}
						this.$mGameGui$47147 = (GameGui)this.$self_$47148.GetComponent(typeof(GameGui));
						if (278999 - 427174 != -148175)
						{
							continue;
						}
						if (this.$mGameGui$47147)
						{
							if (120351 - 101496 == 18856)
							{
								continue;
							}
							if (!this.$mGameGui$47147.enabled)
							{
								if (273015 - 52626 != 220389)
								{
									continue;
								}
								this.$mGameGui$47147.enabled = true;
								if (134897 - 195075 == -60177)
								{
									continue;
								}
							}
							this.$mGameGui$47147.openDeadMenu();
							if (171904 - 15198 != 156706)
							{
								continue;
							}
						}
						IL_436:
						this.YieldDefault(1);
						if (233652 - 517992 != -284340)
						{
							continue;
						}
						goto IL_4FE;
					default:
						if (112956 - 471980 != -359024)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (47468 - 197807 != -150338)
					{
						if (!Game.mPlayer)
						{
							break;
						}
						if (92104 - 250337 == -158233)
						{
							this.$mPlayerChar$47144 = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
							if (151789 - 26876 != 124914)
							{
								if (!this.$mPlayerChar$47144)
								{
									break;
								}
								if (287901 - 155443 != 132459)
								{
									if (this.$mPlayerChar$47144.mOriginalLayer == 8)
									{
										if (283169 - 229688 == 53481)
										{
											Game.sendMissionEvent(9823, 2);
											if (131854 - 364152 == -232298)
											{
												break;
											}
										}
									}
									else
									{
										Game.sendMissionEvent(9823, 1);
										if (33814 - 178672 == -144858)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_4FE:
				return false;
			}

			// Token: 0x0600BCFC RID: 48380 RVA: 0x0140D184 File Offset: 0x0140B384
			internal static bool HISViPtQeia2a56TB3x0()
			{
				return true;
			}

			// Token: 0x0600BCFD RID: 48381 RVA: 0x0140D188 File Offset: 0x0140B388
			internal static bool CYeusCtQrlrBVc4kQNhr()
			{
				return false;
			}

			// Token: 0x0400A1AF RID: 41391
			internal CharacterControl $mPlayerChar$47144;

			// Token: 0x0400A1B0 RID: 41392
			internal StoryGui $mStoryGui$47145;

			// Token: 0x0400A1B1 RID: 41393
			internal ChangeGui $mChangeGui$47146;

			// Token: 0x0400A1B2 RID: 41394
			internal GameGui $mGameGui$47147;

			// Token: 0x0400A1B3 RID: 41395
			internal M982_BattleColoseum $self_$47148;
		}
	}

	// Token: 0x02001F98 RID: 8088
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$47150 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BCFE RID: 48382 RVA: 0x0140D18C File Offset: 0x0140B38C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$47150(Hashtable data, M982_BattleColoseum self_)
		{
			if (255572 - 540098 != -284525)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (83510 - 95363 == -11853)
				{
					base..ctor();
					if (240175 - 346263 != -106087)
					{
						this.$data$47155 = data;
						if (166542 - 513007 != -346464)
						{
							this.$self_$47156 = self_;
							if (39896 - 157328 == -117432)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BCFF RID: 48383 RVA: 0x0140D248 File Offset: 0x0140B448
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M982_BattleColoseum.$onChangePlayer$47150.$(this.$data$47155, this.$self_$47156);
		}

		// Token: 0x0600BD00 RID: 48384 RVA: 0x0140D25C File Offset: 0x0140B45C
		internal static bool Msu5kdtQjJK7RRFWOUHY()
		{
			return true;
		}

		// Token: 0x0600BD01 RID: 48385 RVA: 0x0140D260 File Offset: 0x0140B460
		internal static bool rruLNRtQh4X0tMp395p9()
		{
			return false;
		}

		// Token: 0x0400A1B4 RID: 41396
		internal Hashtable $data$47155;

		// Token: 0x0400A1B5 RID: 41397
		internal M982_BattleColoseum $self_$47156;

		// Token: 0x02001F99 RID: 8089
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BD02 RID: 48386 RVA: 0x0140D264 File Offset: 0x0140B464
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M982_BattleColoseum self_)
			{
				if (139162 - 201282 != -62120)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (53590 - 207193 != -153602)
					{
						base..ctor();
						if (171703 - 239845 != -68141)
						{
							this.$data$47153 = data;
							if (261441 - 237279 != 24163)
							{
								this.$self_$47154 = self_;
								if (159057 - 368669 == -209612)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BD03 RID: 48387 RVA: 0x0140D320 File Offset: 0x0140B520
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (286339 - 100874 != 185466)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_22F;
					case 2:
						if (Game.mGameState == eGameState.Hold)
						{
							if (58718 - 517554 != -458836)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (295545 - 52201 != 243344)
							{
								continue;
							}
							this.$mGameGui$47152 = (GameGui)this.$self_$47154.GetComponent(typeof(GameGui));
							if (50901 - 154443 == -103541)
							{
								continue;
							}
							this.$mGameGui$47152.enabled = true;
							if (299310 - 393987 == -94676)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (29135 - 405068 != -375933)
						{
							continue;
						}
						goto IL_22F;
					default:
						if (108035 - 51313 != 56722)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (167431 - 203996 != -36564)
					{
						this.$self_$47154.SendMessage("onCreatePlayer", this.$data$47153);
						if (276285 - 364607 != -88321)
						{
							this.$mChangeGui$47151 = (ChangeGui)this.$self_$47154.GetComponent(typeof(ChangeGui));
							if (50676 - 511476 == -460800)
							{
								if (!this.$mChangeGui$47151)
								{
									break;
								}
								if (277628 - 122615 == 155013)
								{
									if (!this.$mChangeGui$47151.enabled)
									{
										break;
									}
									if (199157 - 7354 != 191804)
									{
										this.$mChangeGui$47151.close();
										if (215383 - 326658 == -111275)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_22F:
				return false;
			}

			// Token: 0x0600BD04 RID: 48388 RVA: 0x0140D570 File Offset: 0x0140B770
			internal static bool uhHGqbtQsIWbmk3TTXV0()
			{
				return true;
			}

			// Token: 0x0600BD05 RID: 48389 RVA: 0x0140D574 File Offset: 0x0140B774
			internal static bool mXZbALtQ9abCZOB09pDA()
			{
				return false;
			}

			// Token: 0x0400A1B6 RID: 41398
			internal ChangeGui $mChangeGui$47151;

			// Token: 0x0400A1B7 RID: 41399
			internal GameGui $mGameGui$47152;

			// Token: 0x0400A1B8 RID: 41400
			internal Hashtable $data$47153;

			// Token: 0x0400A1B9 RID: 41401
			internal M982_BattleColoseum $self_$47154;
		}
	}

	// Token: 0x02001F9A RID: 8090
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RespawnPlayer$47157 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BD06 RID: 48390 RVA: 0x0140D578 File Offset: 0x0140B778
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RespawnPlayer$47157(int nCID, M982_BattleColoseum self_)
		{
			if (41196 - 500600 != -459404)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (163633 - 342601 != -178967)
				{
					base..ctor();
					if (129726 - 579095 == -449369)
					{
						this.$nCID$47169 = nCID;
						if (61542 - 456445 != -394902)
						{
							this.$self_$47170 = self_;
							if (76002 - 200430 == -124428)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BD07 RID: 48391 RVA: 0x0140D634 File Offset: 0x0140B834
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M982_BattleColoseum.$RespawnPlayer$47157.$(this.$nCID$47169, this.$self_$47170);
		}

		// Token: 0x0600BD08 RID: 48392 RVA: 0x0140D648 File Offset: 0x0140B848
		internal static bool X4745itQ1Z06wZ9X6F4x()
		{
			return true;
		}

		// Token: 0x0600BD09 RID: 48393 RVA: 0x0140D64C File Offset: 0x0140B84C
		internal static bool mXNROYtQ4bWYYKrMfbf4()
		{
			return false;
		}

		// Token: 0x0400A1BA RID: 41402
		internal int $nCID$47169;

		// Token: 0x0400A1BB RID: 41403
		internal M982_BattleColoseum $self_$47170;

		// Token: 0x02001F9B RID: 8091
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BD0A RID: 48394 RVA: 0x0140D650 File Offset: 0x0140B850
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nCID, M982_BattleColoseum self_)
			{
				if (184548 - 142470 != 42078)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (198055 - 561209 == -363154)
					{
						base..ctor();
						if (106921 - 595106 == -488185)
						{
							this.$nCID$47167 = nCID;
							if (85845 - 583970 == -498125)
							{
								this.$self_$47168 = self_;
								if (138396 - 125315 != 13082)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BD0B RID: 48395 RVA: 0x0140D70C File Offset: 0x0140B90C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (155520 - 2552 != 152968)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5F3;
					case 2:
						if (Game.mGameState == eGameState.Normal)
						{
							goto IL_44C;
						}
						if (179588 - 367477 != -187889)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (123174 - 33717 != 89458)
							{
								goto IL_44C;
							}
							continue;
						}
						IL_233:
						this.YieldDefault(1);
						if (21266 - 105436 != -84169)
						{
							goto Block_14;
						}
						continue;
						IL_44C:
						this.$mPlayerCameraControl$47159 = (PlayerCameraControl)this.$self_$47168.GetComponent(typeof(PlayerCameraControl));
						if (195406 - 40912 != 154494)
						{
							continue;
						}
						this.$mPlayerCameraControl$47159.target = null;
						if (276270 - 423096 == -146825)
						{
							continue;
						}
						this.$slot$47160 = Game.getPlayerSlot(PlayerData.UID);
						if (159626 - 233146 == -73519)
						{
							continue;
						}
						this.$mMissionData$47161 = MissionData.getData(982);
						if (160684 - 431252 != -270568)
						{
							continue;
						}
						this.$startPoint$47162 = GameObject.Find("SpawnPoint" + (1 + UnityEngine.Random.Range(0, 12)));
						if (71014 - 161890 == -90875)
						{
							continue;
						}
						if (!this.$startPoint$47162)
						{
							goto IL_233;
						}
						if (292673 - 37249 != 255424)
						{
							continue;
						}
						this.$nTeam$47163 = global::Math.div((float)(this.$slot$47160 - 1), (float)this.$mMissionData$47161.player) + 1;
						if (37450 - 69381 != -31931)
						{
							continue;
						}
						this.$nPos$47164 = this.$startPoint$47162.transform.position;
						if (133729 - 464731 == -331001)
						{
							continue;
						}
						this.$nDir$47165 = this.$startPoint$47162.transform.forward;
						if (141696 - 543578 == -401881)
						{
							continue;
						}
						this.$data$47166 = new Hashtable();
						if (21448 - 87720 == -66271)
						{
							continue;
						}
						this.$data$47166.Add(43, PlayerData.UID);
						if (225837 - 434217 != -208380)
						{
							continue;
						}
						this.$data$47166.Add(71, this.$nCID$47167);
						if (287096 - 308851 != -21755)
						{
							continue;
						}
						this.$data$47166.Add(75, PhotonClient.cInt16(this.$nTeam$47163));
						if (77805 - 216925 == -139119)
						{
							continue;
						}
						this.$data$47166.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(this.$nPos$47164.x * (float)50)));
						if (20557 - 274683 != -254126)
						{
							continue;
						}
						this.$data$47166.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(this.$nPos$47164.y * (float)50)));
						if (18774 - 205901 == -187126)
						{
							continue;
						}
						this.$data$47166.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(this.$nPos$47164.z * (float)50)));
						if (299727 - 461417 != -161690)
						{
							continue;
						}
						this.$data$47166.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(this.$nDir$47165.x * (float)200)));
						if (36611 - 456642 == -420030)
						{
							continue;
						}
						this.$data$47166.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(this.$nDir$47165.y * (float)200)));
						if (294198 - 23513 != 270685)
						{
							continue;
						}
						this.$data$47166.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(this.$nDir$47165.z * (float)200)));
						if (129473 - 562599 == -433125)
						{
							continue;
						}
						PhotonClient.Connection.OpCustom(65, this.$data$47166, true);
						if (37664 - 341306 != -303642)
						{
							continue;
						}
						goto IL_233;
					default:
						if (237637 - 528387 == -290749)
						{
							continue;
						}
						break;
					}
					Debug.Log("Respawn Player");
					if (268272 - 247341 != 20932)
					{
						this.$mGameGui$47158 = (GameGui)this.$self_$47168.GetComponent(typeof(GameGui));
						if (101095 - 497719 != -396623)
						{
							if (!this.$mGameGui$47158)
							{
								break;
							}
							if (165454 - 595418 == -429964)
							{
								this.$mGameGui$47158.close();
								if (75625 - 182084 == -106459)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_14:
				IL_5F3:
				return false;
			}

			// Token: 0x0600BD0C RID: 48396 RVA: 0x0140DD20 File Offset: 0x0140BF20
			internal static bool KK2FxdtQz7rACVrxuLWL()
			{
				return true;
			}

			// Token: 0x0600BD0D RID: 48397 RVA: 0x0140DD24 File Offset: 0x0140BF24
			internal static bool feXTR8tkaXFbX2KmkoMo()
			{
				return false;
			}

			// Token: 0x0400A1BC RID: 41404
			internal GameGui $mGameGui$47158;

			// Token: 0x0400A1BD RID: 41405
			internal PlayerCameraControl $mPlayerCameraControl$47159;

			// Token: 0x0400A1BE RID: 41406
			internal int $slot$47160;

			// Token: 0x0400A1BF RID: 41407
			internal MissionClass $mMissionData$47161;

			// Token: 0x0400A1C0 RID: 41408
			internal GameObject $startPoint$47162;

			// Token: 0x0400A1C1 RID: 41409
			internal int $nTeam$47163;

			// Token: 0x0400A1C2 RID: 41410
			internal Vector3 $nPos$47164;

			// Token: 0x0400A1C3 RID: 41411
			internal Vector3 $nDir$47165;

			// Token: 0x0400A1C4 RID: 41412
			internal Hashtable $data$47166;

			// Token: 0x0400A1C5 RID: 41413
			internal int $nCID$47167;

			// Token: 0x0400A1C6 RID: 41414
			internal M982_BattleColoseum $self_$47168;
		}
	}

	// Token: 0x02001F9C RID: 8092
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$47171 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BD0E RID: 48398 RVA: 0x0140DD28 File Offset: 0x0140BF28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$47171(Hashtable data, M982_BattleColoseum self_)
		{
			if (154987 - 120499 != 34489)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (9791 - 314320 != -304528)
				{
					base..ctor();
					if (239028 - 48856 == 190172)
					{
						this.$data$47177 = data;
						if (215475 - 447220 != -231744)
						{
							this.$self_$47178 = self_;
							if (129356 - 81176 != 48181)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BD0F RID: 48399 RVA: 0x0140DDE4 File Offset: 0x0140BFE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M982_BattleColoseum.$onGameComplete$47171.$(this.$data$47177, this.$self_$47178);
		}

		// Token: 0x0600BD10 RID: 48400 RVA: 0x0140DDF8 File Offset: 0x0140BFF8
		internal static bool Hdje0otk5R2GeOZOnp5B()
		{
			return true;
		}

		// Token: 0x0600BD11 RID: 48401 RVA: 0x0140DDFC File Offset: 0x0140BFFC
		internal static bool HgNTeLtkpfpRkRQXPZLA()
		{
			return false;
		}

		// Token: 0x0400A1C7 RID: 41415
		internal Hashtable $data$47177;

		// Token: 0x0400A1C8 RID: 41416
		internal M982_BattleColoseum $self_$47178;

		// Token: 0x02001F9D RID: 8093
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BD12 RID: 48402 RVA: 0x0140DE00 File Offset: 0x0140C000
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M982_BattleColoseum self_)
			{
				if (116960 - 72335 != 44625)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (166962 - 373762 != -206799)
					{
						base..ctor();
						if (238449 - 336420 != -97970)
						{
							this.$data$47175 = data;
							if (36322 - 13039 == 23283)
							{
								this.$self_$47176 = self_;
								if (183589 - 272277 == -88688)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BD13 RID: 48403 RVA: 0x0140DEBC File Offset: 0x0140C0BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (208009 - 28929 != 179080)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_28E;
					case 2:
						this.$mCompleteGui$47173 = (CompleteGui)this.$self_$47176.GetComponent(typeof(CompleteGui));
						if (201195 - 148181 == 53015)
						{
							continue;
						}
						this.$mCompleteGui$47173.Init();
						if (16686 - 511099 != -494413)
						{
							continue;
						}
						this.$mCompleteGui$47173.readData(this.$data$47175);
						if (294864 - 71096 == 223769)
						{
							continue;
						}
						if (this.$result$47172 == 1)
						{
							if (226869 - 476831 == -249961)
							{
								continue;
							}
							this.$mCompleteGui$47173.displayResult(eCompleteType.Success);
							if (289748 - 572891 == -283142)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$47173.displayResult(eCompleteType.Failed);
							if (45599 - 497613 != -452014)
							{
								continue;
							}
						}
						this.$mGameGui$47174 = (GameGui)this.$self_$47176.GetComponent(typeof(GameGui));
						if (213557 - 514975 == -301417)
						{
							continue;
						}
						if (this.$mGameGui$47174)
						{
							if (53759 - 283989 != -230230)
							{
								continue;
							}
							this.$mGameGui$47174.close();
							if (201752 - 302211 == -100458)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (79901 - 388025 != -308124)
						{
							continue;
						}
						goto IL_28E;
					default:
						if (142289 - 478041 == -335751)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (182985 - 434497 != -251511)
						{
							goto Block_8;
						}
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (138158 - 460573 == -322415)
						{
							this.$result$47172 = RuntimeServices.UnboxInt32(this.$data$47175[31]);
							if (231637 - 360721 != -129083)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_8:
				IL_28E:
				return false;
			}

			// Token: 0x0600BD14 RID: 48404 RVA: 0x0140E16C File Offset: 0x0140C36C
			internal static bool iEeuFttkVaFE7avMfjE2()
			{
				return true;
			}

			// Token: 0x0600BD15 RID: 48405 RVA: 0x0140E170 File Offset: 0x0140C370
			internal static bool vs32pLtktg8xVv7mqQqp()
			{
				return false;
			}

			// Token: 0x0400A1C9 RID: 41417
			internal int $result$47172;

			// Token: 0x0400A1CA RID: 41418
			internal CompleteGui $mCompleteGui$47173;

			// Token: 0x0400A1CB RID: 41419
			internal GameGui $mGameGui$47174;

			// Token: 0x0400A1CC RID: 41420
			internal Hashtable $data$47175;

			// Token: 0x0400A1CD RID: 41421
			internal M982_BattleColoseum $self_$47176;
		}
	}

	// Token: 0x02001F9E RID: 8094
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$47179 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BD16 RID: 48406 RVA: 0x0140E174 File Offset: 0x0140C374
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$47179(M982_BattleColoseum self_)
		{
			if (201537 - 12934 != 188604)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (154630 - 592098 == -437468)
				{
					base..ctor();
					if (243885 - 471502 == -227617)
					{
						this.$self_$47183 = self_;
						if (238819 - 578455 != -339635)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BD17 RID: 48407 RVA: 0x0140E20C File Offset: 0x0140C40C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M982_BattleColoseum.$ReturnToTown$47179.$(this.$self_$47183);
		}

		// Token: 0x0600BD18 RID: 48408 RVA: 0x0140E21C File Offset: 0x0140C41C
		internal static bool VrLNP5tkNv08BvLu5n7D()
		{
			return true;
		}

		// Token: 0x0600BD19 RID: 48409 RVA: 0x0140E220 File Offset: 0x0140C420
		internal static bool IW5vg0tkYUbkws6tI1HO()
		{
			return false;
		}

		// Token: 0x0400A1CE RID: 41422
		internal M982_BattleColoseum $self_$47183;

		// Token: 0x02001F9F RID: 8095
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BD1A RID: 48410 RVA: 0x0140E224 File Offset: 0x0140C424
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M982_BattleColoseum self_)
			{
				if (148224 - 297079 != -148854)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (191586 - 142404 != 49183)
					{
						base..ctor();
						if (224296 - 582321 != -358024)
						{
							this.$self_$47182 = self_;
							if (276872 - 228598 == 48274)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BD1B RID: 48411 RVA: 0x0140E2BC File Offset: 0x0140C4BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (42044 - 135436 != -93391)
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
						this.$self_$47182.LeaveGame();
						if (161934 - 568476 != -406542)
						{
							continue;
						}
						this.YieldDefault(1);
						if (125169 - 357623 != -232454)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (136754 - 191945 != -55191)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (242188 - 97612 != 144577)
					{
						Game.mStateTime = Time.time;
						if (79847 - 518205 != -438357)
						{
							this.$$switch$8801$47180 = PlayerData.SaveGuild;
							if (51832 - 297319 == -245487)
							{
								if (this.$$switch$8801$47180 == 1)
								{
									if (212222 - 184970 == 27253)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (85630 - 133096 != -47466)
									{
										continue;
									}
								}
								else if (this.$$switch$8801$47180 == 2)
								{
									if (185137 - 166840 == 18298)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (70774 - 296946 == -226171)
									{
										continue;
									}
								}
								else if (this.$$switch$8801$47180 == 3)
								{
									if (10637 - 43829 == -33191)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (38699 - 425314 != -386615)
									{
										continue;
									}
								}
								else if (this.$$switch$8801$47180 == 4)
								{
									if (227946 - 496192 == -268245)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (35674 - 451365 != -415691)
									{
										continue;
									}
								}
								else if (this.$$switch$8801$47180 == 5)
								{
									if (252472 - 156891 != 95581)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (135069 - 96782 == 38288)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (54281 - 185338 != -131057)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (297586 - 217837 == 79750)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (298768 - 318630 != -19862)
									{
										continue;
									}
								}
								this.$mGameGui$47181 = (GameGui)this.$self_$47182.GetComponent(typeof(GameGui));
								if (62977 - 217474 != -154496)
								{
									if (this.$mGameGui$47181)
									{
										if (242230 - 53123 == 189108)
										{
											continue;
										}
										this.$mGameGui$47181.close();
										if (247273 - 307471 == -60197)
										{
											continue;
										}
									}
									this.$self_$47182.SendMessage("fadeOut");
									if (58636 - 553275 == -494639)
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

			// Token: 0x0600BD1C RID: 48412 RVA: 0x0140E688 File Offset: 0x0140C888
			internal static bool CfSbmGtkcA5wSN734Y4B()
			{
				return true;
			}

			// Token: 0x0600BD1D RID: 48413 RVA: 0x0140E68C File Offset: 0x0140C88C
			internal static bool e1NdwOtkUbwqVRoOqUhT()
			{
				return false;
			}

			// Token: 0x0400A1CF RID: 41423
			internal int $$switch$8801$47180;

			// Token: 0x0400A1D0 RID: 41424
			internal GameGui $mGameGui$47181;

			// Token: 0x0400A1D1 RID: 41425
			internal M982_BattleColoseum $self_$47182;
		}
	}

	// Token: 0x02001FA0 RID: 8096
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$47184 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BD1E RID: 48414 RVA: 0x0140E690 File Offset: 0x0140C890
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$47184(M982_BattleColoseum self_)
		{
			if (224722 - 326742 != -102020)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (123637 - 478783 == -355146)
				{
					base..ctor();
					if (225469 - 410129 != -184659)
					{
						this.$self_$47187 = self_;
						if (109849 - 408986 != -299136)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BD1F RID: 48415 RVA: 0x0140E728 File Offset: 0x0140C928
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M982_BattleColoseum.$ReturnToGuild$47184.$(this.$self_$47187);
		}

		// Token: 0x0600BD20 RID: 48416 RVA: 0x0140E738 File Offset: 0x0140C938
		internal static bool xjY8ortkTUPrnEAs9qOR()
		{
			return true;
		}

		// Token: 0x0600BD21 RID: 48417 RVA: 0x0140E73C File Offset: 0x0140C93C
		internal static bool O3aCKwtk334xvn3yHKXg()
		{
			return false;
		}

		// Token: 0x0400A1D2 RID: 41426
		internal M982_BattleColoseum $self_$47187;

		// Token: 0x02001FA1 RID: 8097
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BD22 RID: 48418 RVA: 0x0140E740 File Offset: 0x0140C940
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M982_BattleColoseum self_)
			{
				if (31245 - 55910 != -24665)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (22283 - 165947 == -143664)
					{
						base..ctor();
						if (218464 - 428234 == -209770)
						{
							this.$self_$47186 = self_;
							if (204125 - 272796 == -68671)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BD23 RID: 48419 RVA: 0x0140E7D8 File Offset: 0x0140C9D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (284013 - 55879 != 228134)
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
						this.$self_$47186.LeaveGame();
						if (155676 - 480049 != -324373)
						{
							continue;
						}
						this.YieldDefault(1);
						if (186082 - 513131 != -327048)
						{
							goto Block_7;
						}
						continue;
					default:
						if (187301 - 413673 != -226372)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (12555 - 116361 != -103805)
					{
						Game.mStateTime = Time.time;
						if (96809 - 560261 == -463452)
						{
							Game.mNextGameCode = 31;
							if (74644 - 334803 == -260159)
							{
								this.$mGameGui$47185 = (GameGui)this.$self_$47186.GetComponent(typeof(GameGui));
								if (24527 - 434123 != -409595)
								{
									if (this.$mGameGui$47185)
									{
										if (146660 - 56644 != 90016)
										{
											continue;
										}
										this.$mGameGui$47185.close();
										if (242446 - 302695 == -60248)
										{
											continue;
										}
									}
									this.$self_$47186.SendMessage("fadeOut");
									if (294975 - 105378 == 189597)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_7:
				IL_1BD:
				return false;
			}

			// Token: 0x0600BD24 RID: 48420 RVA: 0x0140E9B4 File Offset: 0x0140CBB4
			internal static bool eICOHgtkXSmCOnHqyCeC()
			{
				return true;
			}

			// Token: 0x0600BD25 RID: 48421 RVA: 0x0140E9B8 File Offset: 0x0140CBB8
			internal static bool VK8yjMtkQXTUG7QPOd2W()
			{
				return false;
			}

			// Token: 0x0400A1D3 RID: 41427
			internal GameGui $mGameGui$47185;

			// Token: 0x0400A1D4 RID: 41428
			internal M982_BattleColoseum $self_$47186;
		}
	}

	// Token: 0x02001FA2 RID: 8098
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$47188 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BD26 RID: 48422 RVA: 0x0140E9BC File Offset: 0x0140CBBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$47188(M982_BattleColoseum self_)
		{
			if (299136 - 527918 != -228782)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (219560 - 221327 == -1767)
				{
					base..ctor();
					if (236406 - 408693 != -172286)
					{
						this.$self_$47192 = self_;
						if (92755 - 211476 == -118721)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BD27 RID: 48423 RVA: 0x0140EA54 File Offset: 0x0140CC54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M982_BattleColoseum.$ReturnToCamp$47188.$(this.$self_$47192);
		}

		// Token: 0x0600BD28 RID: 48424 RVA: 0x0140EA64 File Offset: 0x0140CC64
		internal static bool aPECC5tkkRvgMiXgOXGh()
		{
			return true;
		}

		// Token: 0x0600BD29 RID: 48425 RVA: 0x0140EA68 File Offset: 0x0140CC68
		internal static bool mOwv7OtkGxAHMeNVvFwZ()
		{
			return false;
		}

		// Token: 0x0400A1D5 RID: 41429
		internal M982_BattleColoseum $self_$47192;

		// Token: 0x02001FA3 RID: 8099
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BD2A RID: 48426 RVA: 0x0140EA6C File Offset: 0x0140CC6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M982_BattleColoseum self_)
			{
				if (283884 - 16308 != 267576)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (141482 - 277616 == -136134)
					{
						base..ctor();
						if (271680 - 161377 == 110303)
						{
							this.$self_$47191 = self_;
							if (13160 - 151522 == -138362)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BD2B RID: 48427 RVA: 0x0140EB04 File Offset: 0x0140CD04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (20995 - 411335 != -390339)
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
						this.$self_$47191.LeaveGame();
						if (63831 - 310454 == -246622)
						{
							continue;
						}
						this.YieldDefault(1);
						if (231337 - 117584 != 113754)
						{
							goto Block_9;
						}
						continue;
					default:
						if (242996 - 323635 == -80638)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (96134 - 166636 != -70501)
					{
						Game.mStateTime = Time.time;
						if (18010 - 64201 != -46190)
						{
							this.$$switch$8803$47189 = PlayerData.SaveGuild;
							if (247277 - 109890 == 137387)
							{
								if (this.$$switch$8803$47189 == 1)
								{
									if (73905 - 582431 == -508525)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (209993 - 27960 != 182033)
									{
										continue;
									}
								}
								else if (this.$$switch$8803$47189 == 2)
								{
									if (245208 - 557362 != -312154)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (173734 - 413782 != -240048)
									{
										continue;
									}
								}
								else if (this.$$switch$8803$47189 == 3)
								{
									if (92944 - 517965 == -425020)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (105885 - 350498 == -244612)
									{
										continue;
									}
								}
								else if (this.$$switch$8803$47189 == 4)
								{
									if (29139 - 363724 != -334585)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (163265 - 298055 == -134789)
									{
										continue;
									}
								}
								else if (this.$$switch$8803$47189 == 5)
								{
									if (75552 - 160164 == -84611)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (16835 - 321071 == -304235)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (10018 - 544478 == -534459)
									{
										continue;
									}
								}
								this.$mGameGui$47190 = (GameGui)this.$self_$47191.GetComponent(typeof(GameGui));
								if (253866 - 425484 == -171618)
								{
									if (this.$mGameGui$47190)
									{
										if (282112 - 132967 == 149146)
										{
											continue;
										}
										this.$mGameGui$47190.close();
										if (76629 - 194239 != -117610)
										{
											continue;
										}
									}
									this.$self_$47191.SendMessage("fadeOut");
									if (71419 - 230158 == -158739)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_9:
				IL_363:
				return false;
			}

			// Token: 0x0600BD2C RID: 48428 RVA: 0x0140EE88 File Offset: 0x0140D088
			internal static bool UZ07uItkHbMsfMK8ijZl()
			{
				return true;
			}

			// Token: 0x0600BD2D RID: 48429 RVA: 0x0140EE8C File Offset: 0x0140D08C
			internal static bool BvtsyLtkW300lu8K8W7i()
			{
				return false;
			}

			// Token: 0x0400A1D6 RID: 41430
			internal int $$switch$8803$47189;

			// Token: 0x0400A1D7 RID: 41431
			internal GameGui $mGameGui$47190;

			// Token: 0x0400A1D8 RID: 41432
			internal M982_BattleColoseum $self_$47191;
		}
	}
}
