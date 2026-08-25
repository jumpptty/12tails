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

// Token: 0x02001C7C RID: 7292
[Serializable]
public class M965_UltimateQuiz : MonoBehaviour
{
	// Token: 0x0600AA5F RID: 43615 RVA: 0x01300E04 File Offset: 0x012FF004
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M965_UltimateQuiz()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600AA60 RID: 43616 RVA: 0x01300E14 File Offset: 0x012FF014
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (60696 - 327337 != -266641)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (244835 - 435144 == -190309)
			{
				Game.mGameType = 5;
				if (215427 - 34715 != 180713)
				{
					if (Chat.Initialized)
					{
						if (262485 - 486132 == -223647)
						{
							Chat.ChatDisplay.Clear();
							if (148650 - 167636 == -18986)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (58634 - 312610 == -253976)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AA61 RID: 43617 RVA: 0x01300EF8 File Offset: 0x012FF0F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (200658 - 238277 != -37618)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (171412 - 550053 == -378641)
				{
					if (Game.mNextGameCode != 965)
					{
						break;
					}
					if (282512 - 186398 == 96114)
					{
						Game.nextGame();
						if (135914 - 67600 != 68315)
						{
							Game.mGameCode = 965;
							if (221911 - 52009 != 169903)
							{
								Game.mGameType = 5;
								if (119821 - 116623 == 3198)
								{
									Game.mGameTime = Time.time;
									if (44625 - 438729 == -394104)
									{
										Game.mGameScore = 0;
										if (1409 - 308874 == -307465)
										{
											Game.mGameMana = 0;
											if (210542 - 107200 == 103342)
											{
												this.NrTn2aLk9Os = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
												if (52635 - 496696 == -444061)
												{
													this.lHln2gkYXgR = PhotonClient.Connection;
													if (152122 - 599930 != -447807)
													{
														PhotonClient.ActorNrList.Clear();
														if (200038 - 203270 != -3231)
														{
															this.InitGame();
															if (228716 - 564483 != -335766)
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
			else
			{
				Debug.Log("Not Connected");
				if (1840 - 367255 != -365414)
				{
					Game.mGameType = 99;
					if (181561 - 25115 == 156446)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AA62 RID: 43618 RVA: 0x01301134 File Offset: 0x012FF334
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (217502 - 296367 != -78864)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (228870 - 401893 == -173023)
			{
				GUI.depth = 2;
				if (95637 - 582995 != -487357)
				{
					this.oahn24EsKUS = (float)(1024 * Screen.width / Screen.height);
					if (9780 - 436142 == -426362)
					{
						int gfmn273nI5V = this.GFMn273nI5V;
						if (34065 - 489597 == -455532)
						{
							if (gfmn273nI5V == 0)
							{
								if (123677 - 587019 == -463342)
								{
									break;
								}
							}
							else if (gfmn273nI5V == 1)
							{
								if (8179 - 76038 != -67858)
								{
									break;
								}
							}
							else if (gfmn273nI5V == 2)
							{
								if (77560 - 344860 != -267299)
								{
									this.RenderUltimateQuiz();
									if (172471 - 399782 != -227310)
									{
										this.RenderUltimateQuizTimer();
										if (289069 - 8038 != 281032)
										{
											this.RenderGameMessage();
											if (229117 - 197758 != 31360)
											{
												this.RenderChatBar();
												if (298940 - 90713 != 208228)
												{
													if (Time.time <= this.diQn2knFGZg)
													{
														break;
													}
													if (182910 - 379574 != -196663)
													{
														if (this.diQn2knFGZg == (float)0)
														{
															break;
														}
														if (134426 - 162795 != -28368)
														{
															this.StartNewQuestion();
															if (11457 - 498168 != -486710)
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
							else
							{
								if (gfmn273nI5V != 3)
								{
									break;
								}
								if (284555 - 478803 != -194247)
								{
									this.RenderUltimateQuizTimer();
									if (208195 - 493517 != -285321)
									{
										this.RenderGameMessage();
										if (55840 - 510051 != -454210)
										{
											this.RenderChatBar();
											if (166909 - 347152 == -180243)
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

	// Token: 0x0600AA63 RID: 43619 RVA: 0x01301418 File Offset: 0x012FF618
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (112926 - 392223 != -279297)
		{
		}
		for (;;)
		{
			if (this.GFMn273nI5V == 2)
			{
				if (263122 - 245598 == 17524)
				{
					if (!Input.GetKeyDown(KeyCode.Return))
					{
						break;
					}
					if (60072 - 553660 != -493587)
					{
						if (Chat.ChatTimeOut >= Time.time)
						{
							break;
						}
						if (104878 - 270129 == -165251)
						{
							Chat.ChatActive = true;
							if (76576 - 526945 != -450368)
							{
								break;
							}
						}
					}
				}
			}
			else
			{
				Chat.ChatActive = false;
				if (129944 - 554313 == -424369)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600AA64 RID: 43620 RVA: 0x0130150C File Offset: 0x012FF70C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (264623 - 20469 != 244154)
		{
		}
		for (;;)
		{
			if (this.lHln2gkYXgR == null)
			{
				if (76551 - 522146 != -445594)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (19520 - 464261 != -444740)
				{
					if (mGameState == eGameState.Init)
					{
						if (164362 - 524068 != -359705)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (36872 - 372460 == -335588)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (194522 - 30351 == 164171)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (121413 - 121273 == 140)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (128361 - 495821 == -367460)
						{
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (249484 - 564610 == -315125)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (157058 - 274848 == -117789)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (232749 - 260362 != -27613)
								{
									continue;
								}
							}
							if (Game.music == 0)
							{
								break;
							}
							if (13638 - 86793 != -73154)
							{
								if (this.audio.isPlaying)
								{
									break;
								}
								if (181327 - 325361 == -144034)
								{
									this.audio.Play();
									if (106913 - 68990 == 37923)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (48352 - 412298 != -363945)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (234925 - 578275 == -343350)
							{
								if (Game.music != 0)
								{
									if (93119 - 168014 == -74894)
									{
										continue;
									}
									if (!this.audio.isPlaying)
									{
										if (271511 - 62822 == 208690)
										{
											continue;
										}
										this.audio.Play();
										if (110454 - 141856 == -31401)
										{
											continue;
										}
									}
								}
								this.audio.volume = 0.1f * (float)Game.music;
								if (37972 - 281008 != -243035)
								{
									this.AnimateCamera();
									if (245795 - 469490 != -223694)
									{
										this.PlayDancerAnimation();
										if (88358 - 257402 == -169044)
										{
											if (Time.time <= this.RMVn2ZYyurT + (float)300)
											{
												break;
											}
											if (293743 - 300833 != -7089)
											{
												this.StartCoroutine_Auto(this.EndEvent());
												if (191743 - 41941 != 149803)
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
					else if (mGameState == eGameState.AllHold)
					{
						if (145354 - 91684 != 53671)
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
						if (192297 - 342438 != -150140)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AA65 RID: 43621 RVA: 0x01301950 File Offset: 0x012FFB50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (165820 - 375252 != -209431)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (282645 - 309106 != -26460)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (117224 - 42919 == 74305)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (60003 - 53371 == 6632)
					{
						int uid = RuntimeServices.UnboxInt32(data[43]);
						if (117199 - 470573 != -353373)
						{
							int playerSlot = Game.getPlayerSlot(uid);
							if (147005 - 29336 == 117669)
							{
								int num3 = num;
								if (289269 - 13178 == 276091)
								{
									if (num3 == 9651)
									{
										if (285171 - 438499 != -153327)
										{
											this.YBKn2sffAwf++;
											if (16876 - 134525 != -117648)
											{
												break;
											}
										}
									}
									else if (num3 == 9652)
									{
										if (124446 - 195092 != -70645)
										{
											if (this.NS3nv6pUlqZ != null)
											{
												if (120982 - 301450 == -180467)
												{
													continue;
												}
												GameObject gameObject = this.NS3nv6pUlqZ[playerSlot - 1];
												if (227431 - 157438 == 69994)
												{
													continue;
												}
												if (gameObject)
												{
													if (158030 - 518605 == -360574)
													{
														continue;
													}
													UnityEngine.Object.Instantiate(this.mQuizEffect, gameObject.transform.position, Quaternion.identity);
													if (62703 - 231600 != -168897)
													{
														continue;
													}
												}
												this.THJnvtBliH7[playerSlot - 1] = Time.time + (float)1;
												if (117952 - 220367 != -102415)
												{
													continue;
												}
												this.hcNn2mTNsXP[playerSlot - 1] = this.hcNn2mTNsXP[playerSlot - 1] + 1;
												if (65234 - 251908 != -186674)
												{
													continue;
												}
											}
											Chat.SubmitChat("none", "Player" + playerSlot + " answers q#" + this.hcNn2mTNsXP[playerSlot - 1], eChatType.system, eChatMode.system);
											if (56656 - 191026 != -134369)
											{
												break;
											}
										}
									}
									else if (num3 == 9653)
									{
										if (149548 - 322149 == -172601)
										{
											Chat.SubmitChat("none", "Player" + playerSlot + " has completed all 125 questions!", eChatType.system, eChatMode.system);
											if (103459 - 481808 == -378349)
											{
												this.cdVn2H55GKo++;
												if (99462 - 176744 == -77282)
												{
													if (this.cdVn2H55GKo < this.YBKn2sffAwf)
													{
														break;
													}
													if (145667 - 504359 != -358691)
													{
														this.StartCoroutine_Auto(this.EndEvent());
														if (78592 - 196130 == -117538)
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
										if (num3 != 9654)
										{
											break;
										}
										if (216237 - 297003 != -80765)
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

	// Token: 0x0600AA66 RID: 43622 RVA: 0x01301D64 File Offset: 0x012FFF64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M965_UltimateQuiz.$StartEvent$44685(this).GetEnumerator();
	}

	// Token: 0x0600AA67 RID: 43623 RVA: 0x01301D74 File Offset: 0x012FFF74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndEvent()
	{
		return new M965_UltimateQuiz.$EndEvent$44690(this).GetEnumerator();
	}

	// Token: 0x0600AA68 RID: 43624 RVA: 0x01301D84 File Offset: 0x012FFF84
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitGame()
	{
		if (78161 - 353311 != -275150)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (30476 - 481006 != -450529)
			{
				Time.timeScale = 1f;
				if (264055 - 578706 == -314651)
				{
					AudioListener.volume = 0.1f * (float)Game.volume;
					if (61609 - 173483 == -111874)
					{
						this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
						if (127795 - 487409 == -359614)
						{
							this.InitUltimateQuiz();
							if (62588 - 120070 == -57482)
							{
								this.InitChatBar();
								if (76618 - 114004 != -37385)
								{
									this.InitGameMessage();
									if (209298 - 596128 == -386830)
									{
										this.InitDancerList();
										if (114216 - 6653 == 107563)
										{
											this.ResetUltimateQuiz();
											if (114989 - 423425 != -308435)
											{
												Hashtable customOpParameters = new Hashtable();
												if (149157 - 530353 != -381195)
												{
													this.lHln2gkYXgR.OpCustom(52, customOpParameters, true);
													if (160020 - 471892 != -311871)
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

	// Token: 0x0600AA69 RID: 43625 RVA: 0x01301F50 File Offset: 0x01300150
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (269096 - 361040 != -91943)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (197827 - 176332 == 21495)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (233281 - 559741 == -326460)
				{
					Game.mGameState = eGameState.Setup;
					if (39317 - 259593 != -220275)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AA6A RID: 43626 RVA: 0x01301FF4 File Offset: 0x013001F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (69650 - 483525 != -413874)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (284881 - 421507 != -136625)
			{
				if (num != PlayerData.UID)
				{
					break;
				}
				if (173534 - 411573 != -238038)
				{
					Hashtable hashtable = new Hashtable();
					if (257670 - 543446 == -285776)
					{
						hashtable.Add(7, PhotonClient.cInt16(2));
						if (19641 - 456036 == -436395)
						{
							this.lHln2gkYXgR.OpCustom(55, hashtable, true);
							if (154866 - 300074 == -145208)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AA6B RID: 43627 RVA: 0x013020FC File Offset: 0x013002FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (294700 - 574470 != -279770)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (200667 - 308959 != -108291)
			{
				Game.mGameState = eGameState.Ready;
				if (274524 - 381350 == -106826)
				{
					this.CreatePlayer(CharacterData.current.CID, 1, new Vector3((float)0, (float)25, (float)0), Vector3.forward);
					if (250073 - 100993 == 149080)
					{
						Game.sendMissionEvent(9651, Game.getPlayerSlot(PlayerData.UID));
						if (143982 - 310744 != -166761)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AA6C RID: 43628 RVA: 0x013021E4 File Offset: 0x013003E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StartGame()
	{
		Debug.Log("Start Game");
		this.StartCoroutine_Auto(this.StartEvent());
	}

	// Token: 0x0600AA6D RID: 43629 RVA: 0x01302200 File Offset: 0x01300400
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitUltimateQuiz()
	{
		if (115872 - 126104 != -10232)
		{
		}
		for (;;)
		{
			this.DGLn2CqoXeY = (Texture)Resources.Load("GameGui/UltimateQuiz/quiz_questionBar", typeof(Texture));
			if (80207 - 77333 == 2874)
			{
				this.IImn2MOK7TO = (Texture)Resources.Load("GameGui/UltimateQuiz/quiz_timerBar", typeof(Texture));
				if (256198 - 45560 != 210639)
				{
					this.NNen2fpnZOX = new GUIStyle();
					if (157970 - 393308 == -235338)
					{
						this.NNen2fpnZOX.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/UltimateQuiz/quiz_answerBar", typeof(Texture)));
						if (27092 - 583457 != -556364)
						{
							this.NNen2fpnZOX.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/UltimateQuiz/quiz_answerBar_h", typeof(Texture)));
							if (55249 - 473841 != -418591)
							{
								this.ugEn2LD1cgU = (Texture)Resources.Load("GameGui/UltimateQuiz/quiz_answerBar_i", typeof(Texture));
								if (189653 - 387793 == -198140)
								{
									this.Y9Zn2w0A5FT = (Texture)Resources.Load("GameGui/UltimateQuiz/quiz_circle", typeof(Texture));
									if (151465 - 344957 != -193491)
									{
										this.Gndn2UhxgCC = (Texture)Resources.Load("GameGui/UltimateQuiz/answer_a", typeof(Texture));
										if (178116 - 51796 == 126320)
										{
											this.dUXn2NQ5I1l = (Texture)Resources.Load("GameGui/UltimateQuiz/answer_b", typeof(Texture));
											if (117249 - 7494 == 109755)
											{
												this.UgSn2EYFbal = (Texture)Resources.Load("GameGui/UltimateQuiz/answer_c", typeof(Texture));
												if (285575 - 593932 == -308357)
												{
													this.eyjn2PgHYtC = (Texture)Resources.Load("GameGui/UltimateQuiz/answer_d", typeof(Texture));
													if (149576 - 27332 != 122245)
													{
														this.liqn2Sp2bjx = new GUIStyle();
														if (111752 - 143411 == -31659)
														{
															this.liqn2Sp2bjx.font = (Font)Resources.Load("GameGui/Fonts/GMO48", typeof(Font));
															if (244824 - 248443 != -3618)
															{
																this.liqn2Sp2bjx.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
																if (113195 - 540768 == -427573)
																{
																	this.liqn2Sp2bjx.alignment = TextAnchor.MiddleLeft;
																	if (44660 - 582535 == -537875)
																	{
																		this.liqn2Sp2bjx.wordWrap = true;
																		if (8890 - 456695 == -447805)
																		{
																			this.n9An2BDlaeA = new GUIStyle();
																			if (151435 - 128964 != 22472)
																			{
																				this.n9An2BDlaeA.font = (Font)Resources.Load("GameGui/Fonts/GMO38", typeof(Font));
																				if (183477 - 489123 != -305645)
																				{
																					this.n9An2BDlaeA.normal.textColor = new Color(0.14f, 0.11f, 0.07f, (float)1);
																					if (229801 - 493033 == -263232)
																					{
																						this.n9An2BDlaeA.alignment = TextAnchor.MiddleLeft;
																						if (240414 - 484025 == -243611)
																						{
																							this.n9An2BDlaeA.wordWrap = false;
																							if (241065 - 140216 == 100849)
																							{
																								this.Sjwn2FEVwGT = (AudioClip)Resources.Load("Sound/GUI/tick", typeof(AudioClip));
																								if (52491 - 179954 == -127463)
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

	// Token: 0x0600AA6E RID: 43630 RVA: 0x013026C4 File Offset: 0x013008C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetUltimateQuiz()
	{
		if (39303 - 73535 != -34232)
		{
		}
		for (;;)
		{
			this.xJGn28JVDi1 = UltimateQuizData.maxQueston;
			if (184055 - 571391 != -387335)
			{
				this.GDDn20DdGR4 = global::Math.shuffleNumList(global::Math.createNumList(1, this.xJGn28JVDi1));
				if (187342 - 295459 == -108117)
				{
					this.oAOn2iI5r8c = UltimateQuizData.GetQuizData(this.GDDn20DdGR4[0]);
					if (96661 - 78537 == 18124)
					{
						this.Cjln2DcvwIn = 1;
						if (269396 - 245632 == 23764)
						{
							this.hcNn2mTNsXP = new int[4];
							if (243788 - 78024 != 165765)
							{
								this.oKIn2j85r11 = Time.time;
								if (214694 - 88091 != 126604)
								{
									this.rpYn2opvXy2 = string.Empty;
									if (199624 - 431841 != -232216)
									{
										this.diQn2knFGZg = (float)0;
										if (140899 - 53195 != 87705)
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

	// Token: 0x0600AA6F RID: 43631 RVA: 0x01302834 File Offset: 0x01300A34
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderUltimateQuiz()
	{
		if (263749 - 298228 != -34478)
		{
		}
		for (;;)
		{
			GUI.DrawTexture(new Rect(0.5f * this.oahn24EsKUS - (float)512, (float)36, (float)1024, (float)230), this.DGLn2CqoXeY);
			if (109041 - 138715 == -29674)
			{
				GUI.Label(new Rect(0.5f * this.oahn24EsKUS - (float)300, (float)36, (float)680, (float)200), Stringf.timed(this.oAOn2iI5r8c.q + "?", Time.time - this.oKIn2j85r11), this.liqn2Sp2bjx);
				if (180704 - 388496 == -207792)
				{
					if (this.diQn2knFGZg == (float)0)
					{
						if (48790 - 111978 != -63188)
						{
							continue;
						}
						if (GUI.Button(new Rect(0.5f * this.oahn24EsKUS - (float)532, (float)640, (float)512, (float)153), string.Empty, this.NNen2fpnZOX))
						{
							if (25539 - 97056 != -71517)
							{
								continue;
							}
							this.PlayerAnswer("a");
							if (211678 - 581840 == -370161)
							{
								continue;
							}
						}
						if (GUI.Button(new Rect(0.5f * this.oahn24EsKUS + (float)8, (float)640, (float)512, (float)153), string.Empty, this.NNen2fpnZOX))
						{
							if (213954 - 30031 != 183923)
							{
								continue;
							}
							this.PlayerAnswer("b");
							if (210088 - 365638 != -155550)
							{
								continue;
							}
						}
						if (GUI.Button(new Rect(0.5f * this.oahn24EsKUS - (float)532, (float)800, (float)512, (float)153), string.Empty, this.NNen2fpnZOX))
						{
							if (191807 - 83473 == 108335)
							{
								continue;
							}
							this.PlayerAnswer("c");
							if (179468 - 216551 != -37083)
							{
								continue;
							}
						}
						if (GUI.Button(new Rect(0.5f * this.oahn24EsKUS + (float)8, (float)800, (float)512, (float)153), string.Empty, this.NNen2fpnZOX))
						{
							if (246651 - 226328 != 20323)
							{
								continue;
							}
							this.PlayerAnswer("d");
							if (198723 - 422368 == -223644)
							{
								continue;
							}
						}
					}
					else
					{
						if (this.rpYn2opvXy2 == "a")
						{
							if (13024 - 144842 == -131817)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.oahn24EsKUS - (float)532, (float)640, (float)512, (float)153), this.NNen2fpnZOX.hover.background);
							if (236300 - 101193 == 135108)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.oahn24EsKUS - (float)560, (float)636, (float)116, (float)116), this.Y9Zn2w0A5FT);
							if (24019 - 585180 == -561160)
							{
								continue;
							}
						}
						else
						{
							GUI.DrawTexture(new Rect(0.5f * this.oahn24EsKUS - (float)532, (float)640, (float)512, (float)153), this.ugEn2LD1cgU);
							if (250237 - 134418 != 115819)
							{
								continue;
							}
						}
						if (this.rpYn2opvXy2 == "b")
						{
							if (245398 - 179021 != 66377)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.oahn24EsKUS + (float)8, (float)640, (float)512, (float)153), this.NNen2fpnZOX.hover.background);
							if (151082 - 40856 != 110226)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.oahn24EsKUS - (float)20, (float)636, (float)116, (float)116), this.Y9Zn2w0A5FT);
							if (269165 - 1305 == 267861)
							{
								continue;
							}
						}
						else
						{
							GUI.DrawTexture(new Rect(0.5f * this.oahn24EsKUS + (float)8, (float)640, (float)512, (float)153), this.ugEn2LD1cgU);
							if (213723 - 493567 == -279843)
							{
								continue;
							}
						}
						if (this.rpYn2opvXy2 == "c")
						{
							if (77142 - 570452 != -493310)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.oahn24EsKUS - (float)532, (float)800, (float)512, (float)153), this.NNen2fpnZOX.hover.background);
							if (84473 - 395468 != -310995)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.oahn24EsKUS - (float)560, (float)796, (float)116, (float)116), this.Y9Zn2w0A5FT);
							if (105933 - 433762 == -327828)
							{
								continue;
							}
						}
						else
						{
							GUI.DrawTexture(new Rect(0.5f * this.oahn24EsKUS - (float)532, (float)800, (float)512, (float)153), this.ugEn2LD1cgU);
							if (248877 - 388661 != -139784)
							{
								continue;
							}
						}
						if (this.rpYn2opvXy2 == "d")
						{
							if (253124 - 6097 != 247027)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.oahn24EsKUS + (float)8, (float)800, (float)512, (float)153), this.NNen2fpnZOX.hover.background);
							if (29856 - 117055 == -87198)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.oahn24EsKUS - (float)20, (float)796, (float)116, (float)116), this.Y9Zn2w0A5FT);
							if (271315 - 106950 != 164365)
							{
								continue;
							}
						}
						else
						{
							GUI.DrawTexture(new Rect(0.5f * this.oahn24EsKUS + (float)8, (float)800, (float)512, (float)153), this.ugEn2LD1cgU);
							if (59897 - 587460 != -527563)
							{
								continue;
							}
						}
					}
					GUI.DrawTexture(new Rect(0.5f * this.oahn24EsKUS - (float)534, (float)658, (float)70, (float)64), this.Gndn2UhxgCC);
					if (144228 - 403672 == -259444)
					{
						GUI.DrawTexture(new Rect(0.5f * this.oahn24EsKUS + (float)6, (float)658, (float)70, (float)64), this.dUXn2NQ5I1l);
						if (80857 - 390377 != -309519)
						{
							GUI.DrawTexture(new Rect(0.5f * this.oahn24EsKUS - (float)534, (float)818, (float)70, (float)64), this.UgSn2EYFbal);
							if (241151 - 273210 == -32059)
							{
								GUI.DrawTexture(new Rect(0.5f * this.oahn24EsKUS + (float)6, (float)818, (float)70, (float)64), this.eyjn2PgHYtC);
								if (9516 - 316365 == -306849)
								{
									GUI.Label(new Rect(0.5f * this.oahn24EsKUS - (float)440, (float)702, (float)360, (float)50), this.oAOn2iI5r8c.a, this.n9An2BDlaeA);
									if (167959 - 265641 != -97681)
									{
										GUI.Label(new Rect(0.5f * this.oahn24EsKUS + (float)100, (float)702, (float)360, (float)50), this.oAOn2iI5r8c.b, this.n9An2BDlaeA);
										if (669 - 51642 != -50972)
										{
											GUI.Label(new Rect(0.5f * this.oahn24EsKUS - (float)440, (float)862, (float)360, (float)50), this.oAOn2iI5r8c.c, this.n9An2BDlaeA);
											if (282807 - 228295 == 54512)
											{
												GUI.Label(new Rect(0.5f * this.oahn24EsKUS + (float)100, (float)862, (float)360, (float)50), this.oAOn2iI5r8c.d, this.n9An2BDlaeA);
												if (89550 - 70281 != 19270)
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

	// Token: 0x0600AA70 RID: 43632 RVA: 0x01303238 File Offset: 0x01301438
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderUltimateQuizTimer()
	{
		if (36994 - 137137 != -100143)
		{
		}
		for (;;)
		{
			GUI.DrawTexture(new Rect(this.oahn24EsKUS - (float)255, (float)0, (float)255, (float)105), this.IImn2MOK7TO);
			if (210123 - 75830 != 134294)
			{
				int nMinute = global::Math.div((float)300 - Time.time + this.RMVn2ZYyurT, (float)60);
				if (91373 - 337361 != -245987)
				{
					int nSecond = Mathf.FloorToInt((float)300 - Time.time + this.RMVn2ZYyurT) % 60;
					if (72372 - 430326 != -357953)
					{
						Guix.renderBigNumberTime((int)(this.oahn24EsKUS - (float)60), 12, 0, nMinute, nSecond, 0.5f);
						if (224401 - 346663 == -122262)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AA71 RID: 43633 RVA: 0x01303354 File Offset: 0x01301554
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StartNewQuestion()
	{
		if (152899 - 389960 != -237061)
		{
		}
		for (;;)
		{
			if (this.Cjln2DcvwIn < this.xJGn28JVDi1)
			{
				if (137323 - 142928 != -5604)
				{
					this.Cjln2DcvwIn++;
					if (197127 - 398636 == -201509)
					{
						this.oAOn2iI5r8c = UltimateQuizData.GetQuizData(this.GDDn20DdGR4[this.Cjln2DcvwIn - 1]);
						if (176952 - 318296 != -141343)
						{
							this.oKIn2j85r11 = Time.time;
							if (72802 - 204261 == -131459)
							{
								this.rpYn2opvXy2 = string.Empty;
								if (46332 - 543075 == -496743)
								{
									this.diQn2knFGZg = (float)0;
									if (179940 - 573977 == -394037)
									{
										if (this.audio_text)
										{
											if (137913 - 322151 != -184238)
											{
												continue;
											}
											this.audio.PlayOneShot(this.audio_text);
											if (55215 - 89865 == -34649)
											{
												continue;
											}
										}
										Debug.Log("Question#" + (this.Cjln2DcvwIn - 1));
										if (177473 - 205320 != -27846)
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
			else
			{
				Game.sendMissionEvent(9653, 1);
				if (260015 - 467552 == -207537)
				{
					this.GFMn273nI5V = 3;
					if (95073 - 315606 != -220532)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AA72 RID: 43634 RVA: 0x01303558 File Offset: 0x01301758
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayerAnswer(string nAnswer)
	{
		if (90693 - 360431 != -269737)
		{
		}
		for (;;)
		{
			if (this.diQn2knFGZg != (float)0)
			{
				if (129904 - 3687 == 126217)
				{
					break;
				}
			}
			else
			{
				this.rpYn2opvXy2 = nAnswer;
				if (156920 - 140577 == 16343)
				{
					this.diQn2knFGZg = Time.time + (float)1;
					if (115220 - 506983 == -391763)
					{
						if (this.Sjwn2FEVwGT)
						{
							if (66623 - 472123 == -405499)
							{
								continue;
							}
							this.audio.PlayOneShot(this.Sjwn2FEVwGT);
							if (112779 - 322915 != -210136)
							{
								continue;
							}
						}
						if (nAnswer == this.oAOn2iI5r8c.r)
						{
							if (75706 - 472766 == -397060)
							{
								Game.sendMissionEvent(9652, 1);
								if (37086 - 329372 != -292285)
								{
									break;
								}
							}
						}
						else
						{
							Game.sendMissionEvent(9652, 0);
							if (165181 - 441669 == -276488)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AA73 RID: 43635 RVA: 0x013036DC File Offset: 0x013018DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AnimateCamera()
	{
		if (292695 - 121903 != 170793)
		{
		}
		while (this.Di1n2Aa3r0M < Time.time)
		{
			if (266770 - 131474 != 135297)
			{
				int num = UnityEngine.Random.Range(0, 10);
				if (254022 - 68293 != 185730)
				{
					if (num == 1)
					{
						if (80852 - 445223 == -364371)
						{
							this.Di1n2Aa3r0M = Time.time + (float)6;
							if (181264 - 104387 == 76877)
							{
								this.NrTn2aLk9Os.alignToObject("QuizCamera2");
								if (162457 - 299816 != -137358)
								{
									this.NrTn2aLk9Os.StartCoroutine_Auto(this.NrTn2aLk9Os.slerpToObject("QuizCamera3", 6f));
									if (54262 - 411826 != -357563)
									{
										break;
									}
								}
							}
						}
					}
					else if (num == 2)
					{
						if (128754 - 105765 == 22989)
						{
							this.Di1n2Aa3r0M = Time.time + (float)6;
							if (291931 - 230720 != 61212)
							{
								this.NrTn2aLk9Os.alignToObject("QuizCamera2");
								if (198104 - 436008 != -237903)
								{
									this.NrTn2aLk9Os.StartCoroutine_Auto(this.NrTn2aLk9Os.slerpToObject("QuizCamera3", 6f));
									if (261577 - 46326 != 215252)
									{
										break;
									}
								}
							}
						}
					}
					else if (num == 3)
					{
						if (52361 - 167563 == -115202)
						{
							this.Di1n2Aa3r0M = Time.time + (float)6;
							if (149159 - 75427 != 73733)
							{
								this.NrTn2aLk9Os.alignToObject("QuizCamera4");
								if (10213 - 123586 == -113373)
								{
									this.NrTn2aLk9Os.StartCoroutine_Auto(this.NrTn2aLk9Os.slerpToObject("QuizCamera5", 6f));
									if (153830 - 119415 != 34416)
									{
										break;
									}
								}
							}
						}
					}
					else if (num == 4)
					{
						if (92905 - 543963 == -451058)
						{
							this.Di1n2Aa3r0M = Time.time + (float)6;
							if (223247 - 482350 != -259102)
							{
								this.NrTn2aLk9Os.alignToObject("QuizCamera5");
								if (75091 - 578652 == -503561)
								{
									this.NrTn2aLk9Os.StartCoroutine_Auto(this.NrTn2aLk9Os.slerpToObject("QuizCamera4", 6f));
									if (50602 - 477855 != -427252)
									{
										break;
									}
								}
							}
						}
					}
					else if (num == 5)
					{
						if (279971 - 428689 != -148717)
						{
							this.Di1n2Aa3r0M = Time.time + (float)6;
							if (182672 - 118820 != 63853)
							{
								this.NrTn2aLk9Os.alignToObject("QuizCamera6");
								if (34118 - 324134 == -290016)
								{
									this.NrTn2aLk9Os.StartCoroutine_Auto(this.NrTn2aLk9Os.slerpToObject("QuizCamera4", 6f));
									if (224063 - 173147 != 50917)
									{
										break;
									}
								}
							}
						}
					}
					else if (num == 6)
					{
						if (230105 - 528739 == -298634)
						{
							this.Di1n2Aa3r0M = Time.time + (float)6;
							if (153858 - 369109 == -215251)
							{
								this.NrTn2aLk9Os.alignToObject("QuizCamera7");
								if (102122 - 307154 == -205032)
								{
									this.NrTn2aLk9Os.StartCoroutine_Auto(this.NrTn2aLk9Os.slerpToObject("QuizCamera5", 6f));
									if (183520 - 531348 == -347828)
									{
										break;
									}
								}
							}
						}
					}
					else if (num == 7)
					{
						if (186368 - 499139 != -312770)
						{
							this.Di1n2Aa3r0M = Time.time + (float)6;
							if (258224 - 11433 == 246791)
							{
								this.NrTn2aLk9Os.alignToObject("QuizCamera9");
								if (204832 - 380202 != -175369)
								{
									this.NrTn2aLk9Os.StartCoroutine_Auto(this.NrTn2aLk9Os.slerpToObject("QuizCamera10", 6f));
									if (177225 - 249251 == -72026)
									{
										break;
									}
								}
							}
						}
					}
					else if (num == 8)
					{
						if (79708 - 36880 != 42829)
						{
							this.Di1n2Aa3r0M = Time.time + (float)6;
							if (272382 - 318904 == -46522)
							{
								this.NrTn2aLk9Os.alignToObject("QuizCamera10");
								if (118515 - 587329 != -468813)
								{
									this.NrTn2aLk9Os.StartCoroutine_Auto(this.NrTn2aLk9Os.slerpToObject("QuizCamera9", 6f));
									if (280414 - 361125 == -80711)
									{
										break;
									}
								}
							}
						}
					}
					else if (num == 9)
					{
						if (112544 - 456668 == -344124)
						{
							this.Di1n2Aa3r0M = Time.time + (float)9;
							if (159421 - 384497 == -225076)
							{
								this.NrTn2aLk9Os.alignToObject("QuizCamera8");
								if (66406 - 530529 == -464123)
								{
									this.NrTn2aLk9Os.StartCoroutine_Auto(this.NrTn2aLk9Os.slerpToObject("QuizCamera1", 9f));
									if (91001 - 77147 != 13855)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.Di1n2Aa3r0M = Time.time + (float)9;
						if (54433 - 224600 != -170166)
						{
							this.NrTn2aLk9Os.alignToObject("QuizCamera1");
							if (29602 - 410629 != -381026)
							{
								this.NrTn2aLk9Os.StartCoroutine_Auto(this.NrTn2aLk9Os.slerpToObject("QuizCamera8", 9f));
								if (170092 - 371985 != -201892)
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

	// Token: 0x0600AA74 RID: 43636 RVA: 0x01303E44 File Offset: 0x01302044
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitChatBar()
	{
		if (215208 - 474623 != -259415)
		{
		}
		for (;;)
		{
			this.V1nn29QLKBk = string.Empty;
			if (248039 - 180128 != 67912)
			{
				this.yb8n2WyN4tc = (Texture)Resources.Load("GameGui/Common/TypeField", typeof(Texture));
				if (240120 - 202919 == 37201)
				{
					this.tMan2uFPFJd = new GUIStyle();
					if (296864 - 20263 == 276601)
					{
						this.tMan2uFPFJd.font = (Font)Resources.Load("GameGui/Fonts/GMO28", typeof(Font));
						if (80839 - 75830 == 5009)
						{
							this.QTen2y6FHfK = new GUIStyle();
							if (216074 - 79970 != 136105)
							{
								this.QTen2y6FHfK.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
								if (254348 - 271704 == -17356)
								{
									this.O5Gn2VybkZ7 = new GUIStyle();
									if (203583 - 107686 == 95897)
									{
										this.O5Gn2VybkZ7.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
										if (120959 - 18617 != 102343)
										{
											this.O5Gn2VybkZ7.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/chatFontBG", typeof(Texture)));
											if (12843 - 496106 == -483263)
											{
												this.U80n2hdOTGi = Chat.TextColor;
												if (103893 - 592617 != -488723)
												{
													this.GY7n2KR6bmp = Chat.SelfColor;
													if (51745 - 174773 != -123027)
													{
														this.IdBn2zrL0Sr = Chat.AllyColor;
														if (230684 - 502417 != -271732)
														{
															this.tIEnv54D6bj = Chat.EnemyColor;
															if (16129 - 18112 != -1982)
															{
																this.tDynvcGuomF = Chat.GuildColor;
																if (82994 - 188657 != -105662)
																{
																	this.ufenvn8jnkQ = Chat.NPCColor;
																	if (101075 - 309217 == -208142)
																	{
																		this.OefnvQiNSgc = Chat.SystemColor;
																		if (12462 - 223456 != -210993)
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

	// Token: 0x0600AA75 RID: 43637 RVA: 0x01304150 File Offset: 0x01302350
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderChatBar()
	{
		if (87423 - 12133 != 75291)
		{
		}
		for (;;)
		{
			IL_209E:
			if (!Chat.ChatActive)
			{
				if (271253 - 232439 == 38815)
				{
					continue;
				}
				if (PlayerPrefs.GetInt("display", 1) == 0)
				{
					if (3181 - 88281 != -85099)
					{
						break;
					}
					continue;
				}
			}
			Rect screenRect = new Rect(this.oahn24EsKUS - (float)650, (float)150, (float)600, (float)550);
			if (85105 - 570601 != -485495)
			{
				GUILayout.BeginArea(screenRect);
				if (172588 - 91434 == 81154)
				{
					GUILayout.BeginVertical(new GUILayoutOption[0]);
					if (112325 - 584902 != -472576)
					{
						GUILayout.FlexibleSpace();
						if (271278 - 280606 == -9328)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(Chat.ChatDisplay);
							if (190695 - 394799 == -204104)
							{
								while (enumerator.MoveNext())
								{
									object obj = enumerator.Current;
									object obj3;
									object obj2 = obj3 = obj;
									if (!(obj2 is ChatEntry))
									{
										obj3 = RuntimeServices.Coerce(obj2, typeof(ChatEntry));
									}
									ChatEntry chatEntry = (ChatEntry)obj3;
									if (74402 - 195333 == -120930)
									{
										goto IL_209E;
									}
									float num = Mathf.Clamp((float)30 - Time.time + chatEntry.time, (float)0, 1f);
									if (93824 - 311425 == -217600)
									{
										goto IL_209E;
									}
									UnityRuntimeServices.Update(enumerator, chatEntry);
									if (274928 - 140409 == 134520)
									{
										goto IL_209E;
									}
									if (num > (float)0)
									{
										if (239396 - 562596 == -323199)
										{
											goto IL_209E;
										}
										eChatMode mode = chatEntry.mode;
										if (139708 - 570498 != -430790)
										{
											goto IL_209E;
										}
										UnityRuntimeServices.Update(enumerator, chatEntry);
										if (40659 - 550519 == -509859)
										{
											goto IL_209E;
										}
										if (mode == eChatMode.area)
										{
											if (104561 - 549319 == -444757)
											{
												goto IL_209E;
											}
											if (Chat.showAreaChat)
											{
												if (36427 - 323025 == -286597)
												{
													goto IL_209E;
												}
												GUILayout.BeginHorizontal(new GUILayoutOption[0]);
												if (149218 - 487459 == -338240)
												{
													goto IL_209E;
												}
												GUILayout.FlexibleSpace();
												if (220118 - 260649 != -40531)
												{
													goto IL_209E;
												}
												this.QTen2y6FHfK.normal.textColor = this.ufenvn8jnkQ;
												if (262909 - 577336 == -314426)
												{
													goto IL_209E;
												}
												float a = num;
												if (285758 - 509224 == -223465)
												{
													goto IL_209E;
												}
												Color textColor = this.QTen2y6FHfK.normal.textColor;
												if (80324 - 267085 != -186761)
												{
													goto IL_209E;
												}
												textColor.a = a;
												if (278827 - 563934 != -285107)
												{
													goto IL_209E;
												}
												if (9209 - 369331 == -360121)
												{
													goto IL_209E;
												}
												this.QTen2y6FHfK.normal.textColor = textColor;
												if (50593 - 569583 != -518990)
												{
													goto IL_209E;
												}
												if (221697 - 572622 != -350925)
												{
													goto IL_209E;
												}
												GUILayout.Label("[ALL]", this.QTen2y6FHfK, new GUILayoutOption[0]);
												if (60271 - 587512 == -527240)
												{
													goto IL_209E;
												}
												GUILayout.Space((float)5);
												if (115086 - 88652 != 26434)
												{
													goto IL_209E;
												}
												this.QTen2y6FHfK.normal.textColor = this.GY7n2KR6bmp;
												if (235779 - 8073 != 227706)
												{
													goto IL_209E;
												}
												float a2 = num;
												if (12492 - 200861 != -188369)
												{
													goto IL_209E;
												}
												Color textColor2 = this.QTen2y6FHfK.normal.textColor;
												if (137117 - 134716 != 2401)
												{
													goto IL_209E;
												}
												float num2 = textColor2.a = a2;
												if (41253 - 208447 != -167194)
												{
													goto IL_209E;
												}
												if (109631 - 529360 != -419729)
												{
													goto IL_209E;
												}
												Color color = this.QTen2y6FHfK.normal.textColor = textColor2;
												if (216935 - 337046 == -120110)
												{
													goto IL_209E;
												}
												if (43472 - 258207 != -214735)
												{
													goto IL_209E;
												}
												GUILayout.Label(chatEntry.name + ":", this.QTen2y6FHfK, new GUILayoutOption[0]);
												if (278795 - 33191 != 245604)
												{
													goto IL_209E;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (138094 - 387314 == -249219)
												{
													goto IL_209E;
												}
												this.O5Gn2VybkZ7.normal.textColor = this.U80n2hdOTGi;
												if (265854 - 110062 != 155792)
												{
													goto IL_209E;
												}
												float a3 = num;
												if (206620 - 422430 != -215810)
												{
													goto IL_209E;
												}
												Color textColor3 = this.O5Gn2VybkZ7.normal.textColor;
												if (252224 - 528917 == -276692)
												{
													goto IL_209E;
												}
												float num3 = textColor3.a = a3;
												if (175121 - 358832 != -183711)
												{
													goto IL_209E;
												}
												if (74189 - 497555 == -423365)
												{
													goto IL_209E;
												}
												this.O5Gn2VybkZ7.normal.textColor = textColor3;
												if (32827 - 198233 != -165406)
												{
													goto IL_209E;
												}
												if (21198 - 55784 != -34586)
												{
													goto IL_209E;
												}
												GUILayout.Label(" " + chatEntry.text + " ", this.O5Gn2VybkZ7, new GUILayoutOption[0]);
												if (96550 - 580937 != -484387)
												{
													goto IL_209E;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (146353 - 116330 != 30023)
												{
													goto IL_209E;
												}
												GUILayout.EndHorizontal();
												if (76683 - 89483 == -12799)
												{
													goto IL_209E;
												}
											}
										}
										else if (mode == eChatMode.party)
										{
											if (96143 - 255835 == -159691)
											{
												goto IL_209E;
											}
											if (Chat.showAreaChat)
											{
												if (210007 - 428029 == -218021)
												{
													goto IL_209E;
												}
												GUILayout.BeginHorizontal(new GUILayoutOption[0]);
												if (131031 - 281460 != -150429)
												{
													goto IL_209E;
												}
												GUILayout.FlexibleSpace();
												if (248300 - 141586 != 106714)
												{
													goto IL_209E;
												}
												this.QTen2y6FHfK.normal.textColor = new Color(0.8f, 0.2f, 0.2f, num);
												if (106103 - 358172 != -252069)
												{
													goto IL_209E;
												}
												GUILayout.Label("[TEAM]", this.QTen2y6FHfK, new GUILayoutOption[0]);
												if (114880 - 255584 != -140704)
												{
													goto IL_209E;
												}
												GUILayout.Space((float)5);
												if (89498 - 39208 == 50291)
												{
													goto IL_209E;
												}
												this.QTen2y6FHfK.normal.textColor = this.GY7n2KR6bmp;
												if (144432 - 480450 == -336017)
												{
													goto IL_209E;
												}
												float a4 = num;
												if (52360 - 397800 == -345439)
												{
													goto IL_209E;
												}
												Color textColor4 = this.QTen2y6FHfK.normal.textColor;
												if (92487 - 39499 != 52988)
												{
													goto IL_209E;
												}
												float num4 = textColor4.a = a4;
												if (51084 - 10305 == 40780)
												{
													goto IL_209E;
												}
												if (72793 - 394545 != -321752)
												{
													goto IL_209E;
												}
												Color color2 = this.QTen2y6FHfK.normal.textColor = textColor4;
												if (127844 - 442843 != -314999)
												{
													goto IL_209E;
												}
												if (9324 - 400529 != -391205)
												{
													goto IL_209E;
												}
												GUILayout.Label(chatEntry.name + ":", this.QTen2y6FHfK, new GUILayoutOption[0]);
												if (28681 - 435071 != -406390)
												{
													goto IL_209E;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (260222 - 24386 == 235837)
												{
													goto IL_209E;
												}
												this.O5Gn2VybkZ7.normal.textColor = this.U80n2hdOTGi;
												if (245445 - 293356 != -47911)
												{
													goto IL_209E;
												}
												float a5 = num;
												if (297753 - 444225 == -146471)
												{
													goto IL_209E;
												}
												Color textColor5 = this.O5Gn2VybkZ7.normal.textColor;
												if (104488 - 29665 != 74823)
												{
													goto IL_209E;
												}
												float num5 = textColor5.a = a5;
												if (6216 - 42282 != -36066)
												{
													goto IL_209E;
												}
												if (69360 - 184010 == -114649)
												{
													goto IL_209E;
												}
												this.O5Gn2VybkZ7.normal.textColor = textColor5;
												if (139831 - 482595 == -342763)
												{
													goto IL_209E;
												}
												if (200590 - 169729 != 30861)
												{
													goto IL_209E;
												}
												GUILayout.Label(" " + chatEntry.text + " ", this.O5Gn2VybkZ7, new GUILayoutOption[0]);
												if (34462 - 549531 != -515069)
												{
													goto IL_209E;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (174212 - 473724 != -299512)
												{
													goto IL_209E;
												}
												GUILayout.EndHorizontal();
												if (6575 - 508745 != -502170)
												{
													goto IL_209E;
												}
											}
										}
										else if (mode == eChatMode.guild)
										{
											if (57583 - 488567 != -430984)
											{
												goto IL_209E;
											}
											if (Chat.showGuildChat)
											{
												if (255737 - 565819 != -310082)
												{
													goto IL_209E;
												}
												GUILayout.BeginHorizontal(new GUILayoutOption[0]);
												if (53634 - 81426 != -27792)
												{
													goto IL_209E;
												}
												GUILayout.FlexibleSpace();
												if (254432 - 491688 != -237256)
												{
													goto IL_209E;
												}
												this.QTen2y6FHfK.normal.textColor = this.tDynvcGuomF;
												if (194156 - 340000 == -145843)
												{
													goto IL_209E;
												}
												float a6 = num;
												if (184655 - 169336 == 15320)
												{
													goto IL_209E;
												}
												Color textColor6 = this.QTen2y6FHfK.normal.textColor;
												if (299755 - 577248 == -277492)
												{
													goto IL_209E;
												}
												float num6 = textColor6.a = a6;
												if (259996 - 276595 != -16599)
												{
													goto IL_209E;
												}
												if (265960 - 505955 != -239995)
												{
													goto IL_209E;
												}
												this.QTen2y6FHfK.normal.textColor = textColor6;
												if (165129 - 562654 != -397525)
												{
													goto IL_209E;
												}
												if (185230 - 212636 != -27406)
												{
													goto IL_209E;
												}
												GUILayout.Label("[GLD]", this.QTen2y6FHfK, new GUILayoutOption[0]);
												if (3940 - 72265 == -68324)
												{
													goto IL_209E;
												}
												GUILayout.Space((float)5);
												if (216963 - 222997 != -6034)
												{
													goto IL_209E;
												}
												this.QTen2y6FHfK.normal.textColor = this.GY7n2KR6bmp;
												if (55324 - 422732 != -367408)
												{
													goto IL_209E;
												}
												float a7 = num;
												if (222015 - 143311 != 78704)
												{
													goto IL_209E;
												}
												Color textColor7 = this.QTen2y6FHfK.normal.textColor;
												if (183539 - 304330 == -120790)
												{
													goto IL_209E;
												}
												textColor7.a = a7;
												if (217320 - 495337 != -278017)
												{
													goto IL_209E;
												}
												if (237669 - 526620 != -288951)
												{
													goto IL_209E;
												}
												Color color3 = this.QTen2y6FHfK.normal.textColor = textColor7;
												if (278266 - 214913 != 63353)
												{
													goto IL_209E;
												}
												if (20031 - 218912 == -198880)
												{
													goto IL_209E;
												}
												GUILayout.Label(chatEntry.name + ":", this.QTen2y6FHfK, new GUILayoutOption[0]);
												if (112161 - 566936 != -454775)
												{
													goto IL_209E;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (73545 - 489617 != -416072)
												{
													goto IL_209E;
												}
												this.O5Gn2VybkZ7.normal.textColor = this.tDynvcGuomF;
												if (6873 - 95399 == -88525)
												{
													goto IL_209E;
												}
												float a8 = num;
												if (54103 - 464218 != -410115)
												{
													goto IL_209E;
												}
												Color textColor8 = this.O5Gn2VybkZ7.normal.textColor;
												if (247909 - 388759 == -140849)
												{
													goto IL_209E;
												}
												float num7 = textColor8.a = a8;
												if (244781 - 243142 != 1639)
												{
													goto IL_209E;
												}
												if (99598 - 328373 == -228774)
												{
													goto IL_209E;
												}
												this.O5Gn2VybkZ7.normal.textColor = textColor8;
												if (144379 - 457246 == -312866)
												{
													goto IL_209E;
												}
												if (55077 - 576653 != -521576)
												{
													goto IL_209E;
												}
												GUILayout.Label(" " + chatEntry.text + " ", this.O5Gn2VybkZ7, new GUILayoutOption[0]);
												if (101335 - 316310 != -214975)
												{
													goto IL_209E;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (22647 - 330813 == -308165)
												{
													goto IL_209E;
												}
												GUILayout.EndHorizontal();
												if (235421 - 151372 != 84049)
												{
													goto IL_209E;
												}
											}
										}
										else if (mode == eChatMode.whisper)
										{
											if (162576 - 239204 != -76628)
											{
												goto IL_209E;
											}
											if (Chat.showPrivateChat)
											{
												if (197937 - 581573 != -383636)
												{
													goto IL_209E;
												}
												GUILayout.BeginHorizontal(new GUILayoutOption[0]);
												if (20692 - 582621 != -561929)
												{
													goto IL_209E;
												}
												GUILayout.FlexibleSpace();
												if (258619 - 336712 == -78092)
												{
													goto IL_209E;
												}
												this.QTen2y6FHfK.normal.textColor = new Color(0.69f, 0.29f, 0.53f, num);
												if (146373 - 80405 != 65968)
												{
													goto IL_209E;
												}
												GUILayout.Label("[WSP]", this.QTen2y6FHfK, new GUILayoutOption[0]);
												if (19204 - 194058 != -174854)
												{
													goto IL_209E;
												}
												GUILayout.Space((float)5);
												if (215886 - 416745 == -200858)
												{
													goto IL_209E;
												}
												this.QTen2y6FHfK.normal.textColor = this.GY7n2KR6bmp;
												if (88317 - 136060 != -47743)
												{
													goto IL_209E;
												}
												float a9 = num;
												if (210870 - 40535 != 170335)
												{
													goto IL_209E;
												}
												Color textColor9 = this.QTen2y6FHfK.normal.textColor;
												if (286960 - 480533 == -193572)
												{
													goto IL_209E;
												}
												textColor9.a = a9;
												if (169422 - 356278 != -186856)
												{
													goto IL_209E;
												}
												if (273556 - 558601 == -285044)
												{
													goto IL_209E;
												}
												this.QTen2y6FHfK.normal.textColor = textColor9;
												if (232489 - 198162 == 34328 || 80146 - 381646 == -301499)
												{
													goto IL_209E;
												}
												GUILayout.Label(chatEntry.name + ":", this.QTen2y6FHfK, new GUILayoutOption[0]);
												if (201773 - 470617 != -268844)
												{
													goto IL_209E;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (275259 - 96068 != 179191)
												{
													goto IL_209E;
												}
												this.O5Gn2VybkZ7.normal.textColor = this.U80n2hdOTGi;
												if (281300 - 4454 != 276846)
												{
													goto IL_209E;
												}
												float a10 = num;
												if (139179 - 523561 != -384382)
												{
													goto IL_209E;
												}
												Color textColor10 = this.O5Gn2VybkZ7.normal.textColor;
												if (215080 - 533787 != -318707)
												{
													goto IL_209E;
												}
												float num8 = textColor10.a = a10;
												if (149610 - 301005 == -151394)
												{
													goto IL_209E;
												}
												if (34784 - 122168 != -87384)
												{
													goto IL_209E;
												}
												Color color4 = this.O5Gn2VybkZ7.normal.textColor = textColor10;
												if (169273 - 583725 != -414452)
												{
													goto IL_209E;
												}
												if (34186 - 71385 != -37199)
												{
													goto IL_209E;
												}
												GUILayout.Label(" " + chatEntry.text + " ", this.O5Gn2VybkZ7, new GUILayoutOption[0]);
												if (93805 - 105909 != -12104)
												{
													goto IL_209E;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (173372 - 383841 != -210469)
												{
													goto IL_209E;
												}
												GUILayout.EndHorizontal();
												if (20667 - 31446 == -10778)
												{
													goto IL_209E;
												}
											}
										}
										else if (mode == eChatMode.system)
										{
											if (283104 - 578176 != -295072)
											{
												goto IL_209E;
											}
											if (Chat.showSystemChat)
											{
												if (160069 - 489801 != -329732)
												{
													goto IL_209E;
												}
												GUILayout.BeginHorizontal(new GUILayoutOption[0]);
												if (251042 - 529110 != -278068)
												{
													goto IL_209E;
												}
												GUILayout.FlexibleSpace();
												if (193371 - 440173 != -246802)
												{
													goto IL_209E;
												}
												eChatType type = chatEntry.type;
												if (186958 - 107978 == 78981)
												{
													goto IL_209E;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (33577 - 485610 != -452033)
												{
													goto IL_209E;
												}
												if (type == eChatType.system)
												{
													if (154852 - 376822 == -221969)
													{
														goto IL_209E;
													}
													this.O5Gn2VybkZ7.normal.textColor = this.OefnvQiNSgc;
													if (76624 - 534623 != -457999)
													{
														goto IL_209E;
													}
													float a11 = num;
													if (225713 - 355414 == -129700)
													{
														goto IL_209E;
													}
													Color textColor11 = this.O5Gn2VybkZ7.normal.textColor;
													if (192502 - 438062 != -245560)
													{
														goto IL_209E;
													}
													textColor11.a = a11;
													if (130678 - 559946 == -429267 || 213167 - 455097 == -241929)
													{
														goto IL_209E;
													}
													this.O5Gn2VybkZ7.normal.textColor = textColor11;
													if (137667 - 583688 == -446020 || 55221 - 351195 == -295973)
													{
														goto IL_209E;
													}
													GUILayout.Label(" " + chatEntry.text + " ", this.O5Gn2VybkZ7, new GUILayoutOption[0]);
													if (208285 - 237802 == -29516)
													{
														goto IL_209E;
													}
													UnityRuntimeServices.Update(enumerator, chatEntry);
													if (48890 - 291937 == -243046)
													{
														goto IL_209E;
													}
												}
												else if (type == eChatType.self)
												{
													if (56151 - 463198 != -407047)
													{
														goto IL_209E;
													}
													this.QTen2y6FHfK.normal.textColor = this.GY7n2KR6bmp;
													if (254995 - 380606 != -125611)
													{
														goto IL_209E;
													}
													float a12 = num;
													if (82730 - 215483 == -132752)
													{
														goto IL_209E;
													}
													Color textColor12 = this.QTen2y6FHfK.normal.textColor;
													if (45950 - 385902 != -339952)
													{
														goto IL_209E;
													}
													float num9 = textColor12.a = a12;
													if (28786 - 341934 == -313147 || 142744 - 535915 == -393170)
													{
														goto IL_209E;
													}
													this.QTen2y6FHfK.normal.textColor = textColor12;
													if (277186 - 530768 == -253581 || 65548 - 361432 == -295883)
													{
														goto IL_209E;
													}
													GUILayout.Label(chatEntry.name + ":", this.QTen2y6FHfK, new GUILayoutOption[0]);
													if (211333 - 583162 != -371829)
													{
														goto IL_209E;
													}
													UnityRuntimeServices.Update(enumerator, chatEntry);
													if (235742 - 472573 != -236831)
													{
														goto IL_209E;
													}
													this.O5Gn2VybkZ7.normal.textColor = this.U80n2hdOTGi;
													if (147933 - 527745 != -379812)
													{
														goto IL_209E;
													}
													float a13 = num;
													if (47210 - 424967 == -377756)
													{
														goto IL_209E;
													}
													Color textColor13 = this.O5Gn2VybkZ7.normal.textColor;
													if (34231 - 295765 == -261533)
													{
														goto IL_209E;
													}
													float num10 = textColor13.a = a13;
													if (93015 - 533981 == -440965 || 46438 - 347866 == -301427)
													{
														goto IL_209E;
													}
													this.O5Gn2VybkZ7.normal.textColor = textColor13;
													if (90318 - 262282 != -171964)
													{
														goto IL_209E;
													}
													if (234325 - 57851 != 176474)
													{
														goto IL_209E;
													}
													GUILayout.Label(" " + chatEntry.text + " ", this.O5Gn2VybkZ7, new GUILayoutOption[0]);
													if (120239 - 23041 == 97199)
													{
														goto IL_209E;
													}
													UnityRuntimeServices.Update(enumerator, chatEntry);
													if (48432 - 358590 == -310157)
													{
														goto IL_209E;
													}
												}
												else if (type == eChatType.ally)
												{
													if (160715 - 6215 == 154501)
													{
														goto IL_209E;
													}
													this.QTen2y6FHfK.normal.textColor = this.IdBn2zrL0Sr;
													if (202779 - 9272 == 193508)
													{
														goto IL_209E;
													}
													float a14 = num;
													if (263846 - 5961 == 257886)
													{
														goto IL_209E;
													}
													Color textColor14 = this.QTen2y6FHfK.normal.textColor;
													if (297658 - 108503 != 189155)
													{
														goto IL_209E;
													}
													float num11 = textColor14.a = a14;
													if (66898 - 460771 == -393872)
													{
														goto IL_209E;
													}
													if (105980 - 492211 != -386231)
													{
														goto IL_209E;
													}
													this.QTen2y6FHfK.normal.textColor = textColor14;
													if (62850 - 42491 != 20359)
													{
														goto IL_209E;
													}
													if (265354 - 506293 != -240939)
													{
														goto IL_209E;
													}
													GUILayout.Label(chatEntry.name + ":", this.QTen2y6FHfK, new GUILayoutOption[0]);
													if (6072 - 361804 != -355732)
													{
														goto IL_209E;
													}
													UnityRuntimeServices.Update(enumerator, chatEntry);
													if (267169 - 343108 == -75938)
													{
														goto IL_209E;
													}
													this.O5Gn2VybkZ7.normal.textColor = this.U80n2hdOTGi;
													if (49273 - 52113 != -2840)
													{
														goto IL_209E;
													}
													float a15 = num;
													if (122526 - 66166 != 56360)
													{
														goto IL_209E;
													}
													Color textColor15 = this.O5Gn2VybkZ7.normal.textColor;
													if (11069 - 42670 != -31601)
													{
														goto IL_209E;
													}
													float num12 = textColor15.a = a15;
													if (238677 - 195706 != 42971)
													{
														goto IL_209E;
													}
													if (236146 - 216714 != 19432)
													{
														goto IL_209E;
													}
													this.O5Gn2VybkZ7.normal.textColor = textColor15;
													if (30095 - 465887 == -435791 || 249745 - 446993 == -197247)
													{
														goto IL_209E;
													}
													GUILayout.Label(" " + chatEntry.text + " ", this.O5Gn2VybkZ7, new GUILayoutOption[0]);
													if (23847 - 106360 == -82512)
													{
														goto IL_209E;
													}
													UnityRuntimeServices.Update(enumerator, chatEntry);
													if (292365 - 77188 == 215178)
													{
														goto IL_209E;
													}
												}
												else if (type == eChatType.enemy)
												{
													if (163373 - 343025 == -179651)
													{
														goto IL_209E;
													}
													this.QTen2y6FHfK.normal.textColor = this.tIEnv54D6bj;
													if (126168 - 402118 != -275950)
													{
														goto IL_209E;
													}
													float a16 = num;
													if (56445 - 47865 != 8580)
													{
														goto IL_209E;
													}
													Color textColor16 = this.QTen2y6FHfK.normal.textColor;
													if (58496 - 200242 == -141745)
													{
														goto IL_209E;
													}
													float num13 = textColor16.a = a16;
													if (140270 - 40123 == 100148 || 256699 - 147049 == 109651)
													{
														goto IL_209E;
													}
													Color color5 = this.QTen2y6FHfK.normal.textColor = textColor16;
													if (171801 - 109597 != 62204)
													{
														goto IL_209E;
													}
													if (94085 - 54524 != 39561)
													{
														goto IL_209E;
													}
													GUILayout.Label(chatEntry.name + ":", this.QTen2y6FHfK, new GUILayoutOption[0]);
													if (102300 - 180600 == -78299)
													{
														goto IL_209E;
													}
													UnityRuntimeServices.Update(enumerator, chatEntry);
													if (187996 - 398426 == -210429)
													{
														goto IL_209E;
													}
													this.O5Gn2VybkZ7.normal.textColor = this.U80n2hdOTGi;
													if (89746 - 334727 != -244981)
													{
														goto IL_209E;
													}
													float a17 = num;
													if (1214 - 542042 != -540828)
													{
														goto IL_209E;
													}
													Color textColor17 = this.O5Gn2VybkZ7.normal.textColor;
													if (268711 - 408456 != -139745)
													{
														goto IL_209E;
													}
													textColor17.a = a17;
													if (117545 - 540393 == -422847 || 65188 - 83536 == -18347)
													{
														goto IL_209E;
													}
													Color color6 = this.O5Gn2VybkZ7.normal.textColor = textColor17;
													if (217836 - 325536 == -107699)
													{
														goto IL_209E;
													}
													if (34227 - 442327 != -408100)
													{
														goto IL_209E;
													}
													GUILayout.Label(" " + chatEntry.text + " ", this.O5Gn2VybkZ7, new GUILayoutOption[0]);
													if (14196 - 433863 == -419666)
													{
														goto IL_209E;
													}
													UnityRuntimeServices.Update(enumerator, chatEntry);
													if (73667 - 508283 != -434616)
													{
														goto IL_209E;
													}
												}
												else if (type == eChatType.npc)
												{
													if (25515 - 478398 != -452883)
													{
														goto IL_209E;
													}
													this.QTen2y6FHfK.normal.textColor = this.ufenvn8jnkQ;
													if (113431 - 162450 != -49019)
													{
														goto IL_209E;
													}
													float a18 = num;
													if (19474 - 107285 == -87810)
													{
														goto IL_209E;
													}
													Color textColor18 = this.QTen2y6FHfK.normal.textColor;
													if (41650 - 458432 == -416781)
													{
														goto IL_209E;
													}
													textColor18.a = a18;
													if (130268 - 60490 != 69778)
													{
														goto IL_209E;
													}
													if (107513 - 296026 == -188512)
													{
														goto IL_209E;
													}
													Color color7 = this.QTen2y6FHfK.normal.textColor = textColor18;
													if (253789 - 277808 == -24018 || 31912 - 178068 == -146155)
													{
														goto IL_209E;
													}
													GUILayout.Label(chatEntry.name + ":", this.QTen2y6FHfK, new GUILayoutOption[0]);
													if (52964 - 553511 == -500546)
													{
														goto IL_209E;
													}
													UnityRuntimeServices.Update(enumerator, chatEntry);
													if (104126 - 535649 == -431522)
													{
														goto IL_209E;
													}
													this.O5Gn2VybkZ7.normal.textColor = this.U80n2hdOTGi;
													if (185991 - 43444 == 142548)
													{
														goto IL_209E;
													}
													float a19 = num;
													if (188856 - 331452 != -142596)
													{
														goto IL_209E;
													}
													Color textColor19 = this.O5Gn2VybkZ7.normal.textColor;
													if (199928 - 171352 != 28576)
													{
														goto IL_209E;
													}
													textColor19.a = a19;
													if (80694 - 130037 != -49343)
													{
														goto IL_209E;
													}
													if (139935 - 495827 != -355892)
													{
														goto IL_209E;
													}
													Color color8 = this.O5Gn2VybkZ7.normal.textColor = textColor19;
													if (150561 - 441839 == -291277 || 59136 - 240894 == -181757)
													{
														goto IL_209E;
													}
													GUILayout.Label(" " + chatEntry.text + " ", this.O5Gn2VybkZ7, new GUILayoutOption[0]);
													if (117783 - 530454 != -412671)
													{
														goto IL_209E;
													}
													UnityRuntimeServices.Update(enumerator, chatEntry);
													if (218537 - 479867 != -261330)
													{
														goto IL_209E;
													}
												}
												else if (type == eChatType.world)
												{
													if (95087 - 22439 != 72648)
													{
														goto IL_209E;
													}
													this.O5Gn2VybkZ7.normal.textColor = new Color(0.95f, 0.25f, 0.25f, num);
													if (55580 - 216693 == -161112)
													{
														goto IL_209E;
													}
													GUILayout.Label(chatEntry.text, this.O5Gn2VybkZ7, new GUILayoutOption[0]);
													if (212340 - 580407 != -368067)
													{
														goto IL_209E;
													}
													UnityRuntimeServices.Update(enumerator, chatEntry);
													if (291938 - 522642 == -230703)
													{
														goto IL_209E;
													}
												}
												GUILayout.EndHorizontal();
												if (41246 - 106370 == -65123)
												{
													goto IL_209E;
												}
											}
										}
										else if (mode == eChatMode.world)
										{
											if (213710 - 4547 == 209164)
											{
												goto IL_209E;
											}
											GUILayout.BeginHorizontal(new GUILayoutOption[0]);
											if (85887 - 46796 == 39092)
											{
												goto IL_209E;
											}
											GUILayout.FlexibleSpace();
											if (59032 - 110193 != -51161)
											{
												goto IL_209E;
											}
											this.O5Gn2VybkZ7.normal.textColor = new Color(0.95f, 0.25f, 0.25f, num);
											if (202472 - 225490 != -23018)
											{
												goto IL_209E;
											}
											GUILayout.Label(chatEntry.text, this.O5Gn2VybkZ7, new GUILayoutOption[0]);
											if (75772 - 513244 == -437471)
											{
												goto IL_209E;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (253587 - 517371 == -263783)
											{
												goto IL_209E;
											}
											GUILayout.EndHorizontal();
											if (35378 - 527438 != -492060)
											{
												goto IL_209E;
											}
										}
									}
								}
								if (206252 - 100153 == 106099)
								{
									GUILayout.EndVertical();
									if (41813 - 352011 == -310198)
									{
										GUILayout.EndArea();
										if (246688 - 307764 != -61075)
										{
											if (Chat.ChatActive)
											{
												if (14015 - 503382 != -489367)
												{
													continue;
												}
												bool flag = true;
												if (36308 - 437474 != -401166)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(this.oahn24EsKUS - (float)387, (float)700, (float)335, (float)33), this.yb8n2WyN4tc);
												if (275622 - 94009 == 181614)
												{
													continue;
												}
												if (Input.GetKeyDown(KeyCode.UpArrow))
												{
													if (7482 - 281593 != -274111)
													{
														continue;
													}
													this.V1nn29QLKBk = Chat.switchChatModeUp(this.V1nn29QLKBk);
													if (198090 - 437167 != -239077)
													{
														continue;
													}
												}
												else if (Input.GetKeyDown(KeyCode.DownArrow))
												{
													if (65879 - 511696 != -445817)
													{
														continue;
													}
													this.V1nn29QLKBk = Chat.switchChatModeDown(this.V1nn29QLKBk);
													if (257598 - 222436 == 35163)
													{
														continue;
													}
												}
												else
												{
													if (Event.current.type == EventType.KeyDown)
													{
														if (13444 - 206566 == -193121)
														{
															continue;
														}
														if (Event.current.character == "\n")
														{
															if (282147 - 143108 == 139040)
															{
																continue;
															}
															string[] array = (string[])Stringf.splitToArray(this.V1nn29QLKBk, " ").ToBuiltin(typeof(string));
															if (224757 - 261433 == -36675)
															{
																continue;
															}
															if (Extensions.get_length(array) > 0)
															{
																if (38608 - 464340 == -425731)
																{
																	continue;
																}
																string a20 = array[0];
																if (232441 - 280075 != -47634)
																{
																	continue;
																}
																if (a20 == "/a")
																{
																	if (185955 - 351076 == -165120)
																	{
																		continue;
																	}
																	Chat.ChatMode = 1;
																	if (2369 - 544252 == -541882)
																	{
																		continue;
																	}
																	this.V1nn29QLKBk = Stringf.getString(this.V1nn29QLKBk, 2, Extensions.get_length(this.V1nn29QLKBk));
																	if (240285 - 534092 == -293806)
																	{
																		continue;
																	}
																}
																else if (a20 == "/g")
																{
																	if (99996 - 459325 != -359329)
																	{
																		continue;
																	}
																	if (!RuntimeServices.EqualityOperator(PlayerData.GID, "none"))
																	{
																		if (23260 - 529705 == -506444)
																		{
																			continue;
																		}
																		Chat.ChatMode = 2;
																		if (239010 - 45029 != 193981)
																		{
																			continue;
																		}
																		this.V1nn29QLKBk = Stringf.getString(this.V1nn29QLKBk, 2, Extensions.get_length(this.V1nn29QLKBk));
																		if (281333 - 374627 != -93294)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		this.newGameMessage("You are not in a guild");
																		if (31834 - 285796 == -253961)
																		{
																			continue;
																		}
																		flag = false;
																		if (51388 - 233094 == -181705)
																		{
																			continue;
																		}
																	}
																}
																else if (a20 == "/t")
																{
																	if (21623 - 578707 != -557084)
																	{
																		continue;
																	}
																	if (Game.mGameType > 4)
																	{
																		if (152432 - 31872 == 120561)
																		{
																			continue;
																		}
																		Chat.ChatMode = 3;
																		if (149441 - 241873 != -92432)
																		{
																			continue;
																		}
																		this.V1nn29QLKBk = Stringf.getString(this.V1nn29QLKBk, 2, Extensions.get_length(this.V1nn29QLKBk));
																		if (261288 - 337899 != -76611)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		this.newGameMessage("Cannot use team chat");
																		if (218461 - 522514 == -304052)
																		{
																			continue;
																		}
																		this.V1nn29QLKBk = string.Empty;
																		if (235743 - 111372 == 124372)
																		{
																			continue;
																		}
																	}
																}
																else if (a20 == "/w")
																{
																	if (34675 - 306707 == -272031)
																	{
																		continue;
																	}
																	Chat.ChatMode = 4;
																	if (291023 - 216659 != 74364)
																	{
																		continue;
																	}
																	this.V1nn29QLKBk = Stringf.getString(this.V1nn29QLKBk, 3, Extensions.get_length(this.V1nn29QLKBk));
																	if (233479 - 315900 == -82420)
																	{
																		continue;
																	}
																	if (Extensions.get_length(array) > 1)
																	{
																		if (257777 - 596896 == -339118)
																		{
																			continue;
																		}
																		int buddyID = PlayerData.getBuddyID(array[1]);
																		if (174579 - 332609 == -158029)
																		{
																			continue;
																		}
																		if (buddyID != 0)
																		{
																			if (77668 - 68545 == 9124)
																			{
																				continue;
																			}
																			Chat.TargetID = buddyID;
																			if (129881 - 63670 != 66211)
																			{
																				continue;
																			}
																			this.V1nn29QLKBk = Stringf.getString(this.V1nn29QLKBk, Extensions.get_length(array[1]) + 1, Extensions.get_length(this.V1nn29QLKBk));
																			if (60660 - 589420 != -528760)
																			{
																				continue;
																			}
																		}
																	}
																}
															}
															if (flag)
															{
																if (294212 - 496409 != -202197)
																{
																	continue;
																}
																if (this.V1nn29QLKBk.Length > 0)
																{
																	if (8677 - 306890 != -298213)
																	{
																		continue;
																	}
																	if (Chat.ChatMode == 4)
																	{
																		if (270814 - 516725 == -245910)
																		{
																			continue;
																		}
																		if (Chat.TargetID == 0)
																		{
																			if (39721 - 12500 != 27221)
																			{
																				continue;
																			}
																			this.newGameMessage("Whisper target not found!");
																			if (5613 - 33147 != -27533)
																			{
																				goto IL_14D3;
																			}
																			continue;
																		}
																	}
																	Chat.SubmitChat(PlayerData.User, this.V1nn29QLKBk, eChatType.self, (eChatMode)Chat.ChatMode);
																	if (9040 - 188856 != -179816)
																	{
																		continue;
																	}
																}
															}
															IL_14D3:
															this.V1nn29QLKBk = string.Empty;
															if (38361 - 374203 == -335841)
															{
																continue;
															}
															Chat.ChatTimeOut = Time.time + 0.5f;
															if (19378 - 493882 == -474503)
															{
																continue;
															}
															Chat.ChatActive = false;
															if (139155 - 104268 != 34888)
															{
																goto IL_28A8;
															}
															continue;
														}
													}
													GUI.SetNextControlName("DanceChatField");
													if (53062 - 379988 == -326925)
													{
														continue;
													}
													this.V1nn29QLKBk = GUI.TextField(new Rect(this.oahn24EsKUS - (float)380, (float)700, (float)300, (float)30), this.V1nn29QLKBk, 36, this.tMan2uFPFJd);
													if (135240 - 231834 == -96593)
													{
														continue;
													}
												}
											}
											IL_28A8:
											if (!Chat.ChatActive)
											{
												break;
											}
											if (153958 - 481040 == -327082)
											{
												GUI.FocusControl("DanceChatField");
												if (50810 - 403997 == -353187)
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

	// Token: 0x0600AA76 RID: 43638 RVA: 0x01306E90 File Offset: 0x01305090
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitGameMessage()
	{
		if (101598 - 557653 != -456055)
		{
		}
		for (;;)
		{
			this.DXanvJqTkCn = new GUIStyle();
			if (202458 - 243834 == -41376)
			{
				this.DXanvJqTkCn.font = (Font)Resources.Load("GameGui/Fonts/Berlin24", typeof(Font));
				if (84511 - 584973 == -500462)
				{
					this.DXanvJqTkCn.normal.textColor = new Color(0.8f, 0.2f, 0.1f, 0.8f);
					if (53129 - 321662 == -268533)
					{
						this.DXanvJqTkCn.alignment = TextAnchor.MiddleCenter;
						if (93597 - 490648 == -397051)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AA77 RID: 43639 RVA: 0x01306F94 File Offset: 0x01305194
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderGameMessage()
	{
		if (25966 - 316128 != -290161)
		{
		}
		for (;;)
		{
			if (Event.current.type != EventType.Repaint)
			{
				if (16950 - 211664 != -194713)
				{
					break;
				}
			}
			else
			{
				if (this.WbmnvIfObDs + (float)2 <= Time.time)
				{
					break;
				}
				if (276034 - 192575 == 83459)
				{
					GUI.Label(new Rect(0.5f * this.oahn24EsKUS - (float)250, (float)260, (float)500, (float)40), this.klAnve9bVxM, this.DXanvJqTkCn);
					if (241169 - 157928 != 83242)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AA78 RID: 43640 RVA: 0x0130707C File Offset: 0x0130527C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void newGameMessage(string Message)
	{
		if (4003 - 199227 != -195223)
		{
		}
		while (PlayerPrefs.GetInt("smessage", 1) != 0)
		{
			if (139129 - 78945 == 60184)
			{
				this.klAnve9bVxM = Message;
				if (149547 - 451054 != -301506)
				{
					this.WbmnvIfObDs = Time.time;
					if (42498 - 420578 == -378080)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AA79 RID: 43641 RVA: 0x01307124 File Offset: 0x01305324
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitDancerList()
	{
		this.NS3nv6pUlqZ = new GameObject[4];
		this.THJnvtBliH7 = new float[4];
	}

	// Token: 0x0600AA7A RID: 43642 RVA: 0x01307140 File Offset: 0x01305340
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual GameObject CreateDancer(Hashtable data)
	{
		if (124806 - 236174 != -111368)
		{
		}
		GameObject gameObject;
		for (;;)
		{
			IL_E1F:
			object obj2;
			object obj = obj2 = data[73];
			if (!(obj is string))
			{
				obj2 = RuntimeServices.Coerce(obj, typeof(string));
			}
			string text = NetworkUtility.DecodeRace((string)obj2);
			if (106956 - 118945 == -11989)
			{
				if (274113 - 362156 != -88042)
				{
					string a = text;
					if (64796 - 351602 == -286806)
					{
						GameObject original;
						if (a == "Wolf")
						{
							if (119866 - 18969 == 100898)
							{
								continue;
							}
							original = (GameObject)Resources.Load("GameAssets/Characters/Dancers/WolfDancer", typeof(GameObject));
							if (126665 - 157900 != -31235)
							{
								continue;
							}
						}
						else if (a == "Bison")
						{
							if (155235 - 219208 != -63973)
							{
								continue;
							}
							original = (GameObject)Resources.Load("GameAssets/Characters/Dancers/BisonDancer", typeof(GameObject));
							if (8708 - 141347 != -132639)
							{
								continue;
							}
						}
						else if (a == "Panda")
						{
							if (289351 - 309212 == -19860)
							{
								continue;
							}
							original = (GameObject)Resources.Load("GameAssets/Characters/Dancers/PandaDancer", typeof(GameObject));
							if (138747 - 482459 != -343712)
							{
								continue;
							}
						}
						else if (a == "Whale")
						{
							if (206592 - 545794 == -339201)
							{
								continue;
							}
							original = (GameObject)Resources.Load("GameAssets/Characters/Dancers/WhaleDancer", typeof(GameObject));
							if (41520 - 460611 != -419091)
							{
								continue;
							}
						}
						else if (a == "Cat")
						{
							if (102566 - 9718 != 92848)
							{
								continue;
							}
							original = (GameObject)Resources.Load("GameAssets/Characters/Dancers/CatDancer", typeof(GameObject));
							if (167782 - 580087 != -412305)
							{
								continue;
							}
						}
						else if (a == "Chameleon")
						{
							if (151627 - 248900 != -97273)
							{
								continue;
							}
							original = (GameObject)Resources.Load("GameAssets/Characters/Dancers/ChameleonDancer", typeof(GameObject));
							if (102118 - 477801 != -375683)
							{
								continue;
							}
						}
						else if (a == "Mole")
						{
							if (245257 - 393364 == -148106)
							{
								continue;
							}
							original = (GameObject)Resources.Load("GameAssets/Characters/Dancers/MoleDancer", typeof(GameObject));
							if (37349 - 317891 != -280542)
							{
								continue;
							}
						}
						else if (a == "Rabbit")
						{
							if (222265 - 212023 != 10242)
							{
								continue;
							}
							original = (GameObject)Resources.Load("GameAssets/Characters/Dancers/RabbitDancer", typeof(GameObject));
							if (270613 - 34451 != 236162)
							{
								continue;
							}
						}
						else if (a == "Monkey")
						{
							if (284145 - 263064 != 21081)
							{
								continue;
							}
							original = (GameObject)Resources.Load("GameAssets/Characters/Dancers/MonkeyDancer", typeof(GameObject));
							if (220601 - 327472 != -106871)
							{
								continue;
							}
						}
						else if (a == "Sheep")
						{
							if (147290 - 134221 == 13070)
							{
								continue;
							}
							original = (GameObject)Resources.Load("GameAssets/Characters/Dancers/SheepDancer", typeof(GameObject));
							if (258518 - 78459 == 180060)
							{
								continue;
							}
						}
						else if (a == "Penguin")
						{
							if (93228 - 157937 == -64708)
							{
								continue;
							}
							original = (GameObject)Resources.Load("GameAssets/Characters/Dancers/PenguinDancer", typeof(GameObject));
							if (67893 - 18554 != 49339)
							{
								continue;
							}
						}
						else if (a == "Bat")
						{
							if (201180 - 545279 == -344098)
							{
								continue;
							}
							original = (GameObject)Resources.Load("GameAssets/Characters/Dancers/BatDancer", typeof(GameObject));
							if (86831 - 310563 != -223732)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("OnCreateChar Error:" + data[73]);
							if (284888 - 293340 != -8451)
							{
								break;
							}
							continue;
						}
						Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(data[122]), RuntimeServices.UnboxSingle(data[123]), RuntimeServices.UnboxSingle(data[124]));
						if (257883 - 583688 == -325805)
						{
							Vector3 forward = 0.005f * new Vector3(RuntimeServices.UnboxSingle(data[126]), RuntimeServices.UnboxSingle(data[127]), RuntimeServices.UnboxSingle(data[128]));
							if (4863 - 389026 == -384163)
							{
								gameObject = (GameObject)UnityEngine.Object.Instantiate(original, vector, Quaternion.LookRotation(forward));
								if (12804 - 143342 != -130537)
								{
									gameObject.layer = RuntimeServices.UnboxInt32(data[75]);
									if (61357 - 204672 != -143314)
									{
										gameObject.layer += 7;
										if (133880 - 363496 != -229615)
										{
											gameObject.tag = "Player";
											if (142046 - 595903 != -453856)
											{
												DancerControl dancerControl = (DancerControl)gameObject.GetComponent(typeof(DancerControl));
												if (129315 - 384507 == -255192)
												{
													if (dancerControl)
													{
														if (16254 - 396613 == -380358)
														{
															continue;
														}
														dancerControl.ActorNr = RuntimeServices.UnboxInt32(data[9]);
														if (127787 - 355671 == -227883)
														{
															continue;
														}
														dancerControl.ActorNr *= 10;
														if (30300 - 96537 != -66237)
														{
															continue;
														}
														DancerControl dancerControl2 = dancerControl;
														object obj4;
														object obj3 = obj4 = data[72];
														if (!(obj3 is string))
														{
															obj4 = RuntimeServices.Coerce(obj3, typeof(string));
														}
														dancerControl2.Name = (string)obj4;
														if (280042 - 107907 != 172135)
														{
															continue;
														}
														dancerControl.Lv = RuntimeServices.UnboxInt32(data[76]);
														if (210253 - 365859 != -155606)
														{
															continue;
														}
														dancerControl.Skin = RuntimeServices.UnboxInt32(data[74]);
														if (84742 - 412079 != -327337)
														{
															continue;
														}
														dancerControl.ownerID = RuntimeServices.UnboxInt32(data[81]);
														if (263293 - 99911 != 163382)
														{
															continue;
														}
														DancerControl dancerControl3 = dancerControl;
														object obj6;
														object obj5 = obj6 = data[82];
														if (!(obj5 is string))
														{
															obj6 = RuntimeServices.Coerce(obj5, typeof(string));
														}
														dancerControl3.ownerName = (string)obj6;
														if (273725 - 232968 == 40758)
														{
															continue;
														}
														DancerControl dancerControl4 = dancerControl;
														object obj8;
														object obj7 = obj8 = data[83];
														if (!(obj7 is string))
														{
															obj8 = RuntimeServices.Coerce(obj7, typeof(string));
														}
														dancerControl4.readGuildData((string)obj8);
														if (294592 - 415775 == -121182)
														{
															continue;
														}
														dancerControl.isMine = true;
														if (60126 - 519455 != -459329)
														{
															continue;
														}
													}
													int num = RuntimeServices.UnboxInt32(data[74]);
													if (6992 - 153502 != -146509)
													{
														if (25477 - 406342 == -380865)
														{
															string a2 = "none";
															if (40168 - 511988 != -471819)
															{
																if (20570 - 12744 == 7826)
																{
																	if (206560 - 484991 != -278430 && 196868 - 21956 != 174913)
																	{
																		if (125729 - 134211 == -8482)
																		{
																			gameObject.SendMessage("SetSkin", num);
																			if (186119 - 386056 == -199937)
																			{
																				object obj10;
																				object obj9 = obj10 = data[116];
																				if (!(obj9 is string))
																				{
																					obj10 = RuntimeServices.Coerce(obj9, typeof(string));
																				}
																				string text2 = (string)obj10;
																				if (297702 - 571303 == -273601)
																				{
																					if (text2 != null)
																					{
																						if (157258 - 97532 != 59726)
																						{
																							continue;
																						}
																						if (text2 != "0")
																						{
																							if (18875 - 64769 != -45894)
																							{
																								continue;
																							}
																							UnityScript.Lang.Array array = Stringf.getArray(text2);
																							if (174278 - 221607 != -47329)
																							{
																								continue;
																							}
																							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(array);
																							if (291867 - 492362 == -200494)
																							{
																								continue;
																							}
																							while (enumerator.MoveNext())
																							{
																								object obj11 = enumerator.Current;
																								object obj13;
																								object obj12 = obj13 = obj11;
																								if (!(obj12 is string))
																								{
																									obj13 = RuntimeServices.Coerce(obj12, typeof(string));
																								}
																								string text3 = (string)obj13;
																								if (263745 - 233632 != 30113)
																								{
																									goto IL_E1F;
																								}
																								string heading = Stringf.getHeading(text3);
																								if (70727 - 215787 == -145059)
																								{
																									goto IL_E1F;
																								}
																								UnityRuntimeServices.Update(enumerator, text3);
																								if (25443 - 591652 == -566208)
																								{
																									goto IL_E1F;
																								}
																								if (heading == "w")
																								{
																									if (82189 - 529063 == -446873)
																									{
																										goto IL_E1F;
																									}
																									if (text == "Panda")
																									{
																										if (37919 - 270702 != -232783)
																										{
																											goto IL_E1F;
																										}
																										gameObject.SendMessage("EquipWeapon", text3);
																										if (291805 - 14016 == 277790)
																										{
																											goto IL_E1F;
																										}
																										UnityRuntimeServices.Update(enumerator, text3);
																										if (97031 - 385122 != -288091)
																										{
																											goto IL_E1F;
																										}
																										if (132189 - 165904 == -33714)
																										{
																											goto IL_E1F;
																										}
																										UnityRuntimeServices.Update(enumerator, text3);
																										if (114274 - 284740 == -170465)
																										{
																											goto IL_E1F;
																										}
																									}
																								}
																								else if (heading == "a")
																								{
																									if (64015 - 177169 == -113153)
																									{
																										goto IL_E1F;
																									}
																									a2 = text3;
																									if (185564 - 399855 != -214291)
																									{
																										goto IL_E1F;
																									}
																									UnityRuntimeServices.Update(enumerator, text3);
																									if (170759 - 468486 == -297726)
																									{
																										goto IL_E1F;
																									}
																									gameObject.SendMessage("EquipArmor", text3);
																									if (253002 - 564506 != -311504)
																									{
																										goto IL_E1F;
																									}
																									UnityRuntimeServices.Update(enumerator, text3);
																									if (201445 - 199889 == 1557)
																									{
																										goto IL_E1F;
																									}
																								}
																								else if (heading == "c")
																								{
																									if (281460 - 245077 == 36384 || 207228 - 115120 == 92109)
																									{
																										goto IL_E1F;
																									}
																									UnityRuntimeServices.Update(enumerator, text3);
																									if (64775 - 99608 != -34833)
																									{
																										goto IL_E1F;
																									}
																									gameObject.SendMessage("EquipAccessory", text3);
																									if (119937 - 232448 != -112511)
																									{
																										goto IL_E1F;
																									}
																									UnityRuntimeServices.Update(enumerator, text3);
																									if (152482 - 79383 != 73099)
																									{
																										goto IL_E1F;
																									}
																								}
																								else if (heading == "b")
																								{
																									if (12187 - 283247 == -271059)
																									{
																										goto IL_E1F;
																									}
																									if (119152 - 213173 != -94021)
																									{
																										goto IL_E1F;
																									}
																									UnityRuntimeServices.Update(enumerator, text3);
																									if (129435 - 230537 != -101102)
																									{
																										goto IL_E1F;
																									}
																									gameObject.SendMessage("EquipBoot", text3);
																									if (103225 - 400139 != -296914)
																									{
																										goto IL_E1F;
																									}
																									UnityRuntimeServices.Update(enumerator, text3);
																									if (198592 - 150084 == 48509)
																									{
																										goto IL_E1F;
																									}
																								}
																								else if (heading == "t")
																								{
																									if (200825 - 440300 == -239474)
																									{
																										goto IL_E1F;
																									}
																									if (188731 - 567781 != -379050)
																									{
																										goto IL_E1F;
																									}
																									UnityRuntimeServices.Update(enumerator, text3);
																									if (69402 - 570020 != -500618)
																									{
																										goto IL_E1F;
																									}
																									gameObject.SendMessage("EquipTrinket", text3);
																									if (2198 - 569313 == -567114)
																									{
																										goto IL_E1F;
																									}
																									UnityRuntimeServices.Update(enumerator, text3);
																									if (108339 - 224888 != -116549)
																									{
																										goto IL_E1F;
																									}
																								}
																								else if (heading == "p")
																								{
																									if (164014 - 185384 != -21370)
																									{
																										goto IL_E1F;
																									}
																									if (155520 - 382241 != -226721)
																									{
																										goto IL_E1F;
																									}
																									UnityRuntimeServices.Update(enumerator, text3);
																									if (13072 - 147396 == -134323)
																									{
																										goto IL_E1F;
																									}
																									gameObject.SendMessage("EquipPet", text3);
																									if (73972 - 24891 == 49082)
																									{
																										goto IL_E1F;
																									}
																									UnityRuntimeServices.Update(enumerator, text3);
																									if (94419 - 343164 == -248744)
																									{
																										goto IL_E1F;
																									}
																								}
																							}
																							if (130161 - 411691 == -281529)
																							{
																								continue;
																							}
																							if (a2 == "none")
																							{
																								if (61302 - 469179 == -407876)
																								{
																									continue;
																								}
																								gameObject.SendMessage("EquipArmor", "a_none");
																								if (23234 - 207691 == -184456)
																								{
																									continue;
																								}
																							}
																						}
																					}
																					if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[dancerControl.ActorNr], null))
																					{
																						if (134068 - 593661 != -459593)
																						{
																							continue;
																						}
																						Debug.Log("ActorNr: " + dancerControl.ActorNr + " already existed");
																						if (117503 - 98602 == 18902)
																						{
																							continue;
																						}
																						object obj15;
																						object obj14 = obj15 = PhotonClient.ActorNrList[dancerControl.ActorNr];
																						if (!(obj14 is GameObject))
																						{
																							obj15 = RuntimeServices.Coerce(obj14, typeof(GameObject));
																						}
																						GameObject obj16 = (GameObject)obj15;
																						if (173345 - 490026 != -316681)
																						{
																							continue;
																						}
																						UnityEngine.Object.Destroy(obj16);
																						if (46818 - 550153 == -503334)
																						{
																							continue;
																						}
																						PhotonClient.ActorNrList[dancerControl.ActorNr] = gameObject;
																						if (85147 - 569930 != -484783)
																						{
																							continue;
																						}
																					}
																					else
																					{
																						PhotonClient.ActorNrList.Add(dancerControl.ActorNr, gameObject);
																						if (191752 - 405056 != -213304)
																						{
																							continue;
																						}
																					}
																					int playerSlot = Game.getPlayerSlot(dancerControl.ownerID);
																					if (225089 - 251359 != -26269)
																					{
																						gameObject.name = "Player" + playerSlot;
																						if (88223 - 56219 != 32005)
																						{
																							if (Game.mGamePlayerList.Contains(playerSlot))
																							{
																								if (160686 - 315728 != -155042)
																								{
																									continue;
																								}
																								Game.mGamePlayerList[playerSlot] = gameObject;
																								if (110809 - 87135 == 23675)
																								{
																									continue;
																								}
																							}
																							else
																							{
																								Game.mGamePlayerList.Add(playerSlot, gameObject);
																								if (113383 - 175512 == -62128)
																								{
																									continue;
																								}
																							}
																							if (Game.mGamePlayerName.Contains(playerSlot))
																							{
																								if (231178 - 380829 == -149650)
																								{
																									continue;
																								}
																								Game.mGamePlayerName[playerSlot] = dancerControl.Name;
																								if (85327 - 377204 != -291877)
																								{
																									continue;
																								}
																							}
																							else
																							{
																								Game.mGamePlayerName.Add(playerSlot, dancerControl.Name);
																								if (165006 - 160328 != 4678)
																								{
																									continue;
																								}
																							}
																							if (Game.mGamePlayerType.Contains(gameObject.name))
																							{
																								if (293021 - 10103 == 282919)
																								{
																									continue;
																								}
																								Game.mGamePlayerType[gameObject.name] = text;
																								if (89978 - 555076 == -465097)
																								{
																									continue;
																								}
																							}
																							else
																							{
																								Game.mGamePlayerType.Add(gameObject.name, text);
																								if (58098 - 143853 != -85755)
																								{
																									continue;
																								}
																							}
																							Debug.Log(gameObject.name + " created : ID=" + dancerControl.ActorNr + "@" + vector + " Team : " + gameObject.layer);
																							if (198062 - 11689 != 186374)
																							{
																								Collider collider = (Collider)gameObject.GetComponent(typeof(Collider));
																								if (166091 - 149750 != 16342)
																								{
																									GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
																									if (86441 - 67995 == 18446)
																									{
																										if (gameObject2)
																										{
																											if (228310 - 338035 == -109724)
																											{
																												continue;
																											}
																											if (collider)
																											{
																												if (11794 - 190465 != -178671)
																												{
																													continue;
																												}
																												gameObject.transform.position = gameObject2.transform.position - collider.bounds.extents.z * gameObject2.transform.forward;
																												if (191625 - 107274 == 84352)
																												{
																													continue;
																												}
																												gameObject.transform.rotation = gameObject2.transform.rotation;
																												if (106289 - 488962 == -382672)
																												{
																													continue;
																												}
																											}
																										}
																										if (playerSlot <= 0)
																										{
																											goto IL_166A;
																										}
																										if (260159 - 67619 == 192540)
																										{
																											if (playerSlot > 4)
																											{
																												goto IL_166A;
																											}
																											if (98949 - 332933 != -233983)
																											{
																												this.NS3nv6pUlqZ[playerSlot - 1] = gameObject;
																												if (66769 - 46647 != 20123)
																												{
																													goto Block_80;
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		return null;
		Block_80:
		IL_166A:
		return gameObject;
	}

	// Token: 0x0600AA7B RID: 43643 RVA: 0x013087D0 File Offset: 0x013069D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayDancerAnimation()
	{
		if (60091 - 299066 != -238974)
		{
		}
		IL_F7:
		while (this.NS3nv6pUlqZ != null)
		{
			if (128455 - 241427 == -112972)
			{
				if (this.THJnvtBliH7 == null)
				{
					if (258023 - 215982 == 42041)
					{
						break;
					}
				}
				else
				{
					int i = 0;
					if (40024 - 334952 != -294927)
					{
						while (i < 4)
						{
							GameObject gameObject = this.NS3nv6pUlqZ[i];
							if (86254 - 187615 != -101361)
							{
								goto IL_F7;
							}
							if (gameObject)
							{
								if (53332 - 414457 != -361125)
								{
									goto IL_F7;
								}
								if (Time.time > this.THJnvtBliH7[i])
								{
									if (212000 - 332168 != -120168)
									{
										goto IL_F7;
									}
									gameObject.animation.Play("root");
									if (32974 - 551429 != -518455)
									{
										goto IL_F7;
									}
								}
								else
								{
									gameObject.animation.Play("cheer");
									if (297582 - 587307 != -289725)
									{
										goto IL_F7;
									}
								}
							}
							i++;
							if (145079 - 581348 == -436268)
							{
								goto IL_F7;
							}
						}
						if (299842 - 554780 == -254938)
						{
							return;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AA7C RID: 43644 RVA: 0x0130898C File Offset: 0x01306B8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (299323 - 290853 != 8470)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (161488 - 49454 != 112035)
			{
				hashtable.Add(71, CID);
				if (2417 - 539778 == -537361)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (95067 - 496038 != -400970)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (167715 - 76550 != 91166)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (68073 - 161380 == -93307)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (159847 - 9817 != 150031)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (86204 - 586955 == -500751)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (19140 - 86960 != -67819)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (53199 - 349891 == -296692)
											{
												this.lHln2gkYXgR.OpCustom(61, hashtable, true);
												if (150720 - 300780 != -150059)
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

	// Token: 0x0600AA7D RID: 43645 RVA: 0x01308C18 File Offset: 0x01306E18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (267979 - 455208 != -187229)
		{
		}
		for (;;)
		{
			Game.createPlayer(data);
			if (3153 - 337495 != -334341)
			{
				this.CreateDancer(data);
				if (205968 - 99795 == 106173)
				{
					this.StartGame();
					if (176419 - 106366 != 70054)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AA7E RID: 43646 RVA: 0x01308CB4 File Offset: 0x01306EB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		Game.createPeer(data);
		this.CreateDancer(data);
	}

	// Token: 0x0600AA7F RID: 43647 RVA: 0x01308CC8 File Offset: 0x01306EC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (1050 - 287823 != -286772)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (181294 - 428434 == -247140)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (163684 - 418452 == -254768)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (161888 - 249034 != -87145)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AA80 RID: 43648 RVA: 0x01308D8C File Offset: 0x01306F8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (133680 - 535103 != -401423)
		{
		}
		for (;;)
		{
			if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
			{
				if (289276 - 44169 == 245107)
				{
					Game.mGameState = eGameState.Ended;
					if (78905 - 295925 == -217020)
					{
						break;
					}
				}
			}
			else
			{
				this.YBKn2sffAwf--;
				if (208422 - 212971 == -4549)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600AA81 RID: 43649 RVA: 0x01308E4C File Offset: 0x0130704C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M965_UltimateQuiz.$onGameComplete$44695(data, this).GetEnumerator();
	}

	// Token: 0x0600AA82 RID: 43650 RVA: 0x01308E5C File Offset: 0x0130705C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M965_UltimateQuiz.$ReturnToTown$44703(this).GetEnumerator();
	}

	// Token: 0x0600AA83 RID: 43651 RVA: 0x01308E6C File Offset: 0x0130706C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M965_UltimateQuiz.$ReturnToGuild$44706(this).GetEnumerator();
	}

	// Token: 0x0600AA84 RID: 43652 RVA: 0x01308E7C File Offset: 0x0130707C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M965_UltimateQuiz.$ReturnToCamp$44709(this).GetEnumerator();
	}

	// Token: 0x0600AA85 RID: 43653 RVA: 0x01308E8C File Offset: 0x0130708C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (152759 - 259202 != -106443)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (194912 - 570804 != -375891)
			{
				Hashtable hashtable = new Hashtable();
				if (129175 - 193253 != -64077)
				{
					hashtable.Add(43, PlayerData.UID);
					if (103213 - 526479 == -423266)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (288454 - 124613 != 163842)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AA86 RID: 43654 RVA: 0x01308F64 File Offset: 0x01307164
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600AA87 RID: 43655 RVA: 0x01308F78 File Offset: 0x01307178
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (232196 - 38888 != 193309)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (227754 - 88015 != 139740)
			{
				Hashtable hashtable = new Hashtable();
				if (3896 - 36191 == -32295)
				{
					if (Game.mNextGameCode == 30)
					{
						if (54690 - 424818 == -370127)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (105497 - 108984 == -3486)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (56226 - 160224 != -103998)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (223567 - 164816 == 58752)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (279934 - 248133 != 31801)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (260535 - 122979 != 137556)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (123507 - 75774 != 47733)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (16253 - 151840 != -135587)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (148944 - 316009 != -167065)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (136410 - 453534 != -317124)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (281319 - 448751 != -167432)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (294131 - 268740 == 25392)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (34710 - 53583 == -18872)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (248187 - 140542 == 107646)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (231113 - 215859 != 15254)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (254263 - 389477 != -135214)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (14774 - 37877 == -23102)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (49309 - 589148 != -539839)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (134765 - 468356 != -333591)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (61925 - 167687 != -105762)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (16284 - 316981 == -300696)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (20892 - 130028 != -109136)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (183034 - 46035 == 137000)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (112656 - 283942 != -171286)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (60751 - 155209 == -94457)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (190322 - 101139 == 89184)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (176379 - 265193 != -88814)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (41137 - 378726 == -337588)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (17365 - 585455 == -568090)
					{
						this.lHln2gkYXgR.OpCustom(42, hashtable, true);
						if (299164 - 287794 == 11370)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AA88 RID: 43656 RVA: 0x0130952C File Offset: 0x0130772C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600AA89 RID: 43657 RVA: 0x0130953C File Offset: 0x0130773C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600AA8A RID: 43658 RVA: 0x01309540 File Offset: 0x01307740
	internal static bool vpRdxOVbk5BPQcbU2IOU()
	{
		return true;
	}

	// Token: 0x0600AA8B RID: 43659 RVA: 0x01309544 File Offset: 0x01307744
	internal static bool anM5e5VbGM7CPCUksLXe()
	{
		return false;
	}

	// Token: 0x04009788 RID: 38792
	private LitePeer lHln2gkYXgR;

	// Token: 0x04009789 RID: 38793
	private PlayerCameraControl NrTn2aLk9Os;

	// Token: 0x0400978A RID: 38794
	private float oahn24EsKUS;

	// Token: 0x0400978B RID: 38795
	private int YBKn2sffAwf;

	// Token: 0x0400978C RID: 38796
	private int cdVn2H55GKo;

	// Token: 0x0400978D RID: 38797
	public GameObject mQuizEffect;

	// Token: 0x0400978E RID: 38798
	private int GFMn273nI5V;

	// Token: 0x0400978F RID: 38799
	private float RMVn2ZYyurT;

	// Token: 0x04009790 RID: 38800
	private Texture DGLn2CqoXeY;

	// Token: 0x04009791 RID: 38801
	private Texture IImn2MOK7TO;

	// Token: 0x04009792 RID: 38802
	private GUIStyle NNen2fpnZOX;

	// Token: 0x04009793 RID: 38803
	private Texture ugEn2LD1cgU;

	// Token: 0x04009794 RID: 38804
	private Texture Y9Zn2w0A5FT;

	// Token: 0x04009795 RID: 38805
	private Texture Gndn2UhxgCC;

	// Token: 0x04009796 RID: 38806
	private Texture dUXn2NQ5I1l;

	// Token: 0x04009797 RID: 38807
	private Texture UgSn2EYFbal;

	// Token: 0x04009798 RID: 38808
	private Texture eyjn2PgHYtC;

	// Token: 0x04009799 RID: 38809
	private GUIStyle liqn2Sp2bjx;

	// Token: 0x0400979A RID: 38810
	private GUIStyle n9An2BDlaeA;

	// Token: 0x0400979B RID: 38811
	private int[] GDDn20DdGR4;

	// Token: 0x0400979C RID: 38812
	private int xJGn28JVDi1;

	// Token: 0x0400979D RID: 38813
	private UltimateQuizClass oAOn2iI5r8c;

	// Token: 0x0400979E RID: 38814
	private int Cjln2DcvwIn;

	// Token: 0x0400979F RID: 38815
	private int[] hcNn2mTNsXP;

	// Token: 0x040097A0 RID: 38816
	private float oKIn2j85r11;

	// Token: 0x040097A1 RID: 38817
	private string rpYn2opvXy2;

	// Token: 0x040097A2 RID: 38818
	private float diQn2knFGZg;

	// Token: 0x040097A3 RID: 38819
	private AudioClip Sjwn2FEVwGT;

	// Token: 0x040097A4 RID: 38820
	public AudioClip audio_applause;

	// Token: 0x040097A5 RID: 38821
	public AudioClip audio_text;

	// Token: 0x040097A6 RID: 38822
	private float Di1n2Aa3r0M;

	// Token: 0x040097A7 RID: 38823
	private string V1nn29QLKBk;

	// Token: 0x040097A8 RID: 38824
	private Texture yb8n2WyN4tc;

	// Token: 0x040097A9 RID: 38825
	private GUIStyle tMan2uFPFJd;

	// Token: 0x040097AA RID: 38826
	private GUIStyle QTen2y6FHfK;

	// Token: 0x040097AB RID: 38827
	private GUIStyle O5Gn2VybkZ7;

	// Token: 0x040097AC RID: 38828
	private Color U80n2hdOTGi;

	// Token: 0x040097AD RID: 38829
	private Color GY7n2KR6bmp;

	// Token: 0x040097AE RID: 38830
	private Color IdBn2zrL0Sr;

	// Token: 0x040097AF RID: 38831
	private Color tIEnv54D6bj;

	// Token: 0x040097B0 RID: 38832
	private Color tDynvcGuomF;

	// Token: 0x040097B1 RID: 38833
	private Color ufenvn8jnkQ;

	// Token: 0x040097B2 RID: 38834
	private Color OefnvQiNSgc;

	// Token: 0x040097B3 RID: 38835
	private string klAnve9bVxM;

	// Token: 0x040097B4 RID: 38836
	private float WbmnvIfObDs;

	// Token: 0x040097B5 RID: 38837
	private GUIStyle DXanvJqTkCn;

	// Token: 0x040097B6 RID: 38838
	private GameObject[] NS3nv6pUlqZ;

	// Token: 0x040097B7 RID: 38839
	private float[] THJnvtBliH7;

	// Token: 0x02001C7D RID: 7293
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$44685 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AA8C RID: 43660 RVA: 0x01309548 File Offset: 0x01307748
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$44685(M965_UltimateQuiz self_)
		{
			if (238955 - 552500 != -313544)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (140062 - 584965 != -444902)
				{
					base..ctor();
					if (10165 - 201854 == -191689)
					{
						this.$self_$44689 = self_;
						if (192123 - 485597 != -293473)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AA8D RID: 43661 RVA: 0x013095E0 File Offset: 0x013077E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M965_UltimateQuiz.$StartEvent$44685.$(this.$self_$44689);
		}

		// Token: 0x0600AA8E RID: 43662 RVA: 0x013095F0 File Offset: 0x013077F0
		internal static bool RlO7K3VbHnSH3LsKFSo8()
		{
			return true;
		}

		// Token: 0x0600AA8F RID: 43663 RVA: 0x013095F4 File Offset: 0x013077F4
		internal static bool LENCNkVbWnZQ8ZOaWmGh()
		{
			return false;
		}

		// Token: 0x040097B8 RID: 38840
		internal M965_UltimateQuiz $self_$44689;

		// Token: 0x02001C7E RID: 7294
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AA90 RID: 43664 RVA: 0x013095F8 File Offset: 0x013077F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M965_UltimateQuiz self_)
			{
				if (99329 - 248923 != -149594)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (108033 - 72181 != 35853)
					{
						base..ctor();
						if (24786 - 474317 == -449531)
						{
							this.$self_$44688 = self_;
							if (239492 - 554359 == -314867)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AA91 RID: 43665 RVA: 0x01309690 File Offset: 0x01307890
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (15794 - 574896 != -559101)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_798;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (251738 - 13206 != 238533)
							{
								goto Block_43;
							}
							continue;
						}
						else
						{
							if (!this.$self_$44688.audio_applause)
							{
								goto IL_63B;
							}
							if (96017 - 35375 == 60643)
							{
								continue;
							}
							this.$self_$44688.audio.PlayOneShot(this.$self_$44688.audio_applause);
							if (198170 - 302880 != -104709)
							{
								goto Block_2;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (17116 - 299112 != -281995)
							{
								goto Block_45;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44687 = (StoryGui)this.$self_$44688.GetComponent(typeof(StoryGui));
							if (52783 - 590204 == -537420)
							{
								continue;
							}
							if (!this.$mStoryGui$44687)
							{
								if (217641 - 454408 != -236766)
								{
									goto Block_35;
								}
								continue;
							}
							else
							{
								this.$self_$44688.NrTn2aLk9Os.alignToObject("QuizCamera2");
								if (132710 - 30441 != 102269)
								{
									continue;
								}
								this.$self_$44688.NrTn2aLk9Os.StartCoroutine_Auto(this.$self_$44688.NrTn2aLk9Os.slerpToObject("QuizCamera3", 1f));
								if (181873 - 46120 != 135753)
								{
									continue;
								}
								this.$mStoryGui$44687.startStoryMessage("Walrus", "Reggu", eTalkType.friend);
								if (95722 - 217353 != -121631)
								{
									continue;
								}
								goto IL_424;
							}
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (122998 - 187029 != -64030)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44687.newStoryMessage("Walrus", "Reggu", Language.getMessage("M965_UltimateQuiz", 101), eTalkType.friend);
							if (164382 - 184204 != -19822)
							{
								continue;
							}
							if (!this.$mWalrus$44686)
							{
								goto IL_48F;
							}
							if (117456 - 465964 == -348507)
							{
								continue;
							}
							this.$mWalrus$44686.animation.CrossFade("talk", 0.5f);
							if (215133 - 14685 != 200449)
							{
								goto Block_36;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (120039 - 274529 != -154490)
							{
								continue;
							}
							goto IL_168;
						}
						else
						{
							this.$mStoryGui$44687.newStoryMessage("Walrus", "Reggu", Language.getMessage("M965_UltimateQuiz", 102), eTalkType.friend);
							if (174825 - 324101 != -149275)
							{
								goto Block_8;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (265204 - 28228 != 236976)
							{
								continue;
							}
							goto IL_D0;
						}
						else
						{
							this.$mStoryGui$44687.newStoryMessage("Walrus", "Reggu", Language.getMessage("M965_UltimateQuiz", 103), eTalkType.friend);
							if (79059 - 497482 != -418423)
							{
								continue;
							}
							goto IL_676;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (140580 - 307641 != -167061)
							{
								continue;
							}
							goto IL_3F5;
						}
						else
						{
							if (!this.$mWalrus$44686)
							{
								goto IL_2B1;
							}
							if (294358 - 142097 == 152262)
							{
								continue;
							}
							this.$mWalrus$44686.animation.Play("cast1");
							if (252367 - 189816 != 62551)
							{
								continue;
							}
							goto IL_2B1;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (187785 - 381791 != -194005)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							if (this.$mWalrus$44686)
							{
								if (111660 - 31171 == 80490)
								{
									continue;
								}
								this.$mWalrus$44686.animation.CrossFade("root", 0.2f);
								if (126962 - 279983 != -153021)
								{
									continue;
								}
							}
							this.$mStoryGui$44687.close();
							if (286522 - 80230 != 206293)
							{
								goto Block_50;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.Start)
						{
							if (159691 - 309094 != -149403)
							{
								continue;
							}
							goto IL_359;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (186786 - 146520 == 40267)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (20471 - 409148 != -388677)
							{
								continue;
							}
							this.$self_$44688.GFMn273nI5V = 2;
							if (4142 - 494428 != -490286)
							{
								continue;
							}
							this.$self_$44688.RMVn2ZYyurT = Time.time;
							if (73617 - 289764 != -216147)
							{
								continue;
							}
							this.YieldDefault(1);
							if (151094 - 112765 != 38330)
							{
								goto Block_37;
							}
							continue;
						}
						break;
					default:
						if (13524 - 498231 == -484706)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Start;
					if (280110 - 413797 != -133686)
					{
						Game.mGameTime = Time.time;
						if (267464 - 118541 == 148923)
						{
							this.$self_$44688.GFMn273nI5V = 1;
							if (40522 - 82081 == -41559)
							{
								this.$self_$44688.RMVn2ZYyurT = Time.time;
								if (95897 - 491654 == -395757)
								{
									this.$mWalrus$44686 = GameObject.Find("Walrus");
									if (70416 - 459531 == -389115)
									{
										this.$self_$44688.NrTn2aLk9Os.alignToObject("QuizCamera1");
										if (169618 - 60626 != 108993)
										{
											this.$self_$44688.SendMessage("fadeIn");
											if (259724 - 377901 != -118176)
											{
												goto Block_14;
											}
										}
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_63B;
				IL_D0:
				IL_168:
				goto IL_798;
				Block_8:
				return this.Yield(6, new WaitForSeconds(3f));
				Block_14:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_2B1:
				return this.Yield(8, new WaitForSeconds(0.8f));
				Block_16:
				IL_359:
				IL_3F5:
				goto IL_798;
				IL_424:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_28:
				goto IL_798;
				IL_48F:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_35:
				goto IL_798;
				Block_36:
				goto IL_48F;
				Block_37:
				Block_43:
				goto IL_798;
				IL_63B:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_45:
				goto IL_798;
				IL_676:
				return this.Yield(7, new WaitForSeconds(2.2f));
				Block_50:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_798:
				return false;
			}

			// Token: 0x0600AA92 RID: 43666 RVA: 0x01309E48 File Offset: 0x01308048
			internal static bool FZ4xMnVbAy3A4OPeoKZY()
			{
				return true;
			}

			// Token: 0x0600AA93 RID: 43667 RVA: 0x01309E4C File Offset: 0x0130804C
			internal static bool tsDOk4Vbl6NJ1SkcQMiF()
			{
				return false;
			}

			// Token: 0x040097B9 RID: 38841
			internal GameObject $mWalrus$44686;

			// Token: 0x040097BA RID: 38842
			internal StoryGui $mStoryGui$44687;

			// Token: 0x040097BB RID: 38843
			internal M965_UltimateQuiz $self_$44688;
		}
	}

	// Token: 0x02001C7F RID: 7295
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$44690 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AA94 RID: 43668 RVA: 0x01309E50 File Offset: 0x01308050
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$44690(M965_UltimateQuiz self_)
		{
			if (146804 - 450118 != -303313)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (162896 - 508454 != -345557)
				{
					base..ctor();
					if (41448 - 382712 != -341263)
					{
						this.$self_$44694 = self_;
						if (114424 - 414531 == -300107)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AA95 RID: 43669 RVA: 0x01309EE8 File Offset: 0x013080E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M965_UltimateQuiz.$EndEvent$44690.$(this.$self_$44694);
		}

		// Token: 0x0600AA96 RID: 43670 RVA: 0x01309EF8 File Offset: 0x013080F8
		internal static bool S3tUHNVbybvTrnELWJwr()
		{
			return true;
		}

		// Token: 0x0600AA97 RID: 43671 RVA: 0x01309EFC File Offset: 0x013080FC
		internal static bool p92Nd5VbSNEVuoliRTs5()
		{
			return false;
		}

		// Token: 0x040097BC RID: 38844
		internal M965_UltimateQuiz $self_$44694;

		// Token: 0x02001C80 RID: 7296
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AA98 RID: 43672 RVA: 0x01309F00 File Offset: 0x01308100
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M965_UltimateQuiz self_)
			{
				if (140912 - 584095 != -443182)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (293144 - 273353 == 19791)
					{
						base..ctor();
						if (74168 - 578155 != -503986)
						{
							this.$self_$44693 = self_;
							if (93827 - 141413 == -47586)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AA99 RID: 43673 RVA: 0x01309F98 File Offset: 0x01308198
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (145607 - 318957 != -173349)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_572;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (210497 - 124869 != 85629)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44692 = (StoryGui)this.$self_$44693.GetComponent(typeof(StoryGui));
							if (77966 - 37034 != 40932)
							{
								continue;
							}
							if (!this.$mStoryGui$44692)
							{
								if (162046 - 321423 != -159376)
								{
									goto Block_13;
								}
								continue;
							}
							else
							{
								this.$mStoryGui$44692.startStoryMessage("Walrus", "Reggu", eTalkType.friend);
								if (299440 - 172244 != 127196)
								{
									continue;
								}
								this.$self_$44693.NrTn2aLk9Os.StartCoroutine_Auto(this.$self_$44693.NrTn2aLk9Os.slerpToObject("QuizCamera3", 1f));
								if (171097 - 156362 != 14735)
								{
									continue;
								}
								goto IL_368;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (205152 - 139519 != 65633)
							{
								continue;
							}
							goto IL_4F2;
						}
						else
						{
							this.$mStoryGui$44692.newStoryMessage("Walrus", "Reggu", Language.getMessage("M965_UltimateQuiz", 201), eTalkType.friend);
							if (138415 - 213797 != -75382)
							{
								continue;
							}
							if (!this.$mWalrus$44691)
							{
								goto IL_6F;
							}
							if (294845 - 240526 == 54320)
							{
								continue;
							}
							this.$mWalrus$44691.animation.CrossFade("talk", 0.5f);
							if (57786 - 65172 != -7386)
							{
								continue;
							}
							goto IL_6F;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (252375 - 362928 != -110553)
							{
								continue;
							}
							goto IL_178;
						}
						else
						{
							this.$mStoryGui$44692.newStoryMessage("Walrus", "Reggu", Language.getMessage("M965_UltimateQuiz", 202), eTalkType.friend);
							if (29979 - 110374 != -80395)
							{
								continue;
							}
							goto IL_537;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (257512 - 252405 != 5108)
							{
								goto Block_37;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$44692.close();
							if (248776 - 587668 != -338892)
							{
								continue;
							}
							if (!this.$mWalrus$44691)
							{
								goto IL_13D;
							}
							if (183173 - 59595 == 123579)
							{
								continue;
							}
							this.$mWalrus$44691.animation.CrossFade("root", 0.5f);
							if (94483 - 436501 != -342017)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (22306 - 157080 != -134774)
							{
								continue;
							}
							goto IL_47C;
						}
						else
						{
							Game.sendMissionEvent(9654, 0);
							if (92294 - 62216 == 30079)
							{
								continue;
							}
							this.YieldDefault(1);
							if (88778 - 51403 != 37376)
							{
								goto Block_34;
							}
							continue;
						}
						break;
					default:
						if (85062 - 129941 == -44878)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.AllHold;
					if (161606 - 266610 != -105003)
					{
						Game.mGameTime = Time.time;
						if (206886 - 12836 == 194050)
						{
							this.$self_$44693.GFMn273nI5V = 4;
							if (45141 - 453298 != -408156)
							{
								this.$self_$44693.RMVn2ZYyurT = Time.time;
								if (213147 - 431891 != -218743)
								{
									this.$mWalrus$44691 = GameObject.Find("Walrus");
									if (279283 - 180986 != 98298)
									{
										this.$self_$44693.NrTn2aLk9Os.alignToObject("QuizCamera2");
										if (90735 - 113528 == -22793)
										{
											if (!this.$self_$44693.audio_applause)
											{
												goto IL_3A3;
											}
											if (14920 - 98569 == -83649)
											{
												this.$self_$44693.audio.PlayOneShot(this.$self_$44693.audio_applause);
												if (262258 - 23021 == 239237)
												{
													goto IL_3A3;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_6F:
				return this.Yield(4, new WaitForSeconds(3f));
				IL_13D:
				return this.Yield(6, new WaitForSeconds(2f));
				IL_178:
				Block_13:
				goto IL_572;
				Block_16:
				goto IL_13D;
				IL_368:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_3A3:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_25:
				IL_47C:
				Block_34:
				IL_4F2:
				goto IL_572;
				IL_537:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_37:
				IL_572:
				return false;
			}

			// Token: 0x0600AA9A RID: 43674 RVA: 0x0130A52C File Offset: 0x0130872C
			internal static bool auXuexVborcf1vMXKorM()
			{
				return true;
			}

			// Token: 0x0600AA9B RID: 43675 RVA: 0x0130A530 File Offset: 0x01308730
			internal static bool HAsG88VbEmdUZn9n2qiZ()
			{
				return false;
			}

			// Token: 0x040097BD RID: 38845
			internal GameObject $mWalrus$44691;

			// Token: 0x040097BE RID: 38846
			internal StoryGui $mStoryGui$44692;

			// Token: 0x040097BF RID: 38847
			internal M965_UltimateQuiz $self_$44693;
		}
	}

	// Token: 0x02001C81 RID: 7297
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$44695 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AA9C RID: 43676 RVA: 0x0130A534 File Offset: 0x01308734
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$44695(Hashtable data, M965_UltimateQuiz self_)
		{
			if (40590 - 226942 != -186352)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (193131 - 373634 != -180502)
				{
					base..ctor();
					if (34910 - 472764 != -437853)
					{
						this.$data$44701 = data;
						if (282947 - 443830 != -160882)
						{
							this.$self_$44702 = self_;
							if (13176 - 260047 == -246871)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AA9D RID: 43677 RVA: 0x0130A5F0 File Offset: 0x013087F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M965_UltimateQuiz.$onGameComplete$44695.$(this.$data$44701, this.$self_$44702);
		}

		// Token: 0x0600AA9E RID: 43678 RVA: 0x0130A604 File Offset: 0x01308804
		internal static bool EohubmVb2bx4j2YAABWg()
		{
			return true;
		}

		// Token: 0x0600AA9F RID: 43679 RVA: 0x0130A608 File Offset: 0x01308808
		internal static bool Wxb2MOVb8broCRHexaJO()
		{
			return false;
		}

		// Token: 0x040097C0 RID: 38848
		internal Hashtable $data$44701;

		// Token: 0x040097C1 RID: 38849
		internal M965_UltimateQuiz $self_$44702;

		// Token: 0x02001C82 RID: 7298
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AAA0 RID: 43680 RVA: 0x0130A60C File Offset: 0x0130880C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M965_UltimateQuiz self_)
			{
				if (286936 - 413129 != -126192)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (277228 - 471323 == -194095)
					{
						base..ctor();
						if (112831 - 188 != 112644)
						{
							this.$data$44699 = data;
							if (11972 - 96016 != -84043)
							{
								this.$self_$44700 = self_;
								if (26809 - 391288 == -364479)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AAA1 RID: 43681 RVA: 0x0130A6C8 File Offset: 0x013088C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (298901 - 575027 != -276126)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2C9;
					case 2:
						this.$mCompleteGui$44697 = (CompleteGui)this.$self_$44700.GetComponent(typeof(CompleteGui));
						if (194727 - 40006 == 154722)
						{
							continue;
						}
						this.$mCompleteGui$44697.Init();
						if (130651 - 370855 == -240203)
						{
							continue;
						}
						this.$mCompleteGui$44697.readData(this.$data$44699);
						if (246494 - 197121 == 49374)
						{
							continue;
						}
						if (this.$result$44696 == 1)
						{
							if (268888 - 332584 == -63695)
							{
								continue;
							}
							this.$mCompleteGui$44697.displayResult(eCompleteType.Success);
							if (273830 - 340147 == -66316)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$44697.displayResult(eCompleteType.Failed);
							if (137907 - 466391 == -328483)
							{
								continue;
							}
						}
						this.$mStoryGui$44698 = (StoryGui)this.$self_$44700.GetComponent(typeof(StoryGui));
						if (228672 - 463370 == -234697)
						{
							continue;
						}
						if (this.$mStoryGui$44698)
						{
							if (137801 - 386795 != -248994)
							{
								continue;
							}
							this.$mStoryGui$44698.close();
							if (39387 - 555247 != -515860)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (217100 - 289346 != -72245)
						{
							goto Block_5;
						}
						continue;
					default:
						if (288359 - 320407 == -32047)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$44699[31]);
					if (94097 - 110671 == -16574)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (174389 - 385878 != -211488)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (265749 - 577553 != -311803)
							{
								this.$result$44696 = RuntimeServices.UnboxInt32(this.$data$44699[31]);
								if (133706 - 449590 != -315883)
								{
									goto Block_10;
								}
							}
						}
					}
				}
				Block_5:
				goto IL_2C9;
				Block_10:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_2C9:
				return false;
			}

			// Token: 0x0600AAA2 RID: 43682 RVA: 0x0130A9B0 File Offset: 0x01308BB0
			internal static bool J5riFbVbZLu7j5ZtX16s()
			{
				return true;
			}

			// Token: 0x0600AAA3 RID: 43683 RVA: 0x0130A9B4 File Offset: 0x01308BB4
			internal static bool m98utVVbCtcmEZZIFQvt()
			{
				return false;
			}

			// Token: 0x040097C2 RID: 38850
			internal int $result$44696;

			// Token: 0x040097C3 RID: 38851
			internal CompleteGui $mCompleteGui$44697;

			// Token: 0x040097C4 RID: 38852
			internal StoryGui $mStoryGui$44698;

			// Token: 0x040097C5 RID: 38853
			internal Hashtable $data$44699;

			// Token: 0x040097C6 RID: 38854
			internal M965_UltimateQuiz $self_$44700;
		}
	}

	// Token: 0x02001C83 RID: 7299
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$44703 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AAA4 RID: 43684 RVA: 0x0130A9B8 File Offset: 0x01308BB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$44703(M965_UltimateQuiz self_)
		{
			if (65121 - 131153 != -66032)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (134351 - 477653 == -343302)
				{
					base..ctor();
					if (160364 - 490658 != -330293)
					{
						this.$self_$44705 = self_;
						if (126595 - 84553 != 42043)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AAA5 RID: 43685 RVA: 0x0130AA50 File Offset: 0x01308C50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M965_UltimateQuiz.$ReturnToTown$44703.$(this.$self_$44705);
		}

		// Token: 0x0600AAA6 RID: 43686 RVA: 0x0130AA60 File Offset: 0x01308C60
		internal static bool tqqNTHVbLpXW7sxr5UZg()
		{
			return true;
		}

		// Token: 0x0600AAA7 RID: 43687 RVA: 0x0130AA64 File Offset: 0x01308C64
		internal static bool P0mrnkVbOroibayYCNqX()
		{
			return false;
		}

		// Token: 0x040097C7 RID: 38855
		internal M965_UltimateQuiz $self_$44705;

		// Token: 0x02001C84 RID: 7300
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AAA8 RID: 43688 RVA: 0x0130AA68 File Offset: 0x01308C68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M965_UltimateQuiz self_)
			{
				if (177403 - 499854 != -322451)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (202558 - 97076 != 105483)
					{
						base..ctor();
						if (110893 - 148501 == -37608)
						{
							this.$self_$44704 = self_;
							if (6764 - 192485 != -185720)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AAA9 RID: 43689 RVA: 0x0130AB00 File Offset: 0x01308D00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (221566 - 592280 != -370713)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_134;
					case 2:
						this.$self_$44704.LeaveGame();
						if (285700 - 306375 != -20675)
						{
							continue;
						}
						this.YieldDefault(1);
						if (104246 - 476352 != -372106)
						{
							continue;
						}
						goto IL_134;
					default:
						if (240901 - 595748 == -354846)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (164716 - 484609 == -319893)
					{
						Game.mStateTime = Time.time;
						if (178536 - 232943 != -54406)
						{
							Game.mNextGameCode = 52;
							if (284891 - 388124 == -103233)
							{
								this.$self_$44704.SendMessage("fadeOut");
								if (211929 - 363227 == -151298)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_134:
				return false;
			}

			// Token: 0x0600AAAA RID: 43690 RVA: 0x0130AC54 File Offset: 0x01308E54
			internal static bool XIVr3WVbms4jG72oi6op()
			{
				return true;
			}

			// Token: 0x0600AAAB RID: 43691 RVA: 0x0130AC58 File Offset: 0x01308E58
			internal static bool VGeiy6VbFJU5JiTpV8Wr()
			{
				return false;
			}

			// Token: 0x040097C8 RID: 38856
			internal M965_UltimateQuiz $self_$44704;
		}
	}

	// Token: 0x02001C85 RID: 7301
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$44706 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AAAC RID: 43692 RVA: 0x0130AC5C File Offset: 0x01308E5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$44706(M965_UltimateQuiz self_)
		{
			if (7476 - 21069 != -13592)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (195360 - 394675 == -199315)
				{
					base..ctor();
					if (23404 - 69758 != -46353)
					{
						this.$self_$44708 = self_;
						if (8222 - 491251 == -483029)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AAAD RID: 43693 RVA: 0x0130ACF4 File Offset: 0x01308EF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M965_UltimateQuiz.$ReturnToGuild$44706.$(this.$self_$44708);
		}

		// Token: 0x0600AAAE RID: 43694 RVA: 0x0130AD04 File Offset: 0x01308F04
		internal static bool eh8vOQVbMpIZ16Eew59i()
		{
			return true;
		}

		// Token: 0x0600AAAF RID: 43695 RVA: 0x0130AD08 File Offset: 0x01308F08
		internal static bool o98CtAVbxnRF7hoVFv7o()
		{
			return false;
		}

		// Token: 0x040097C9 RID: 38857
		internal M965_UltimateQuiz $self_$44708;

		// Token: 0x02001C86 RID: 7302
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AAB0 RID: 43696 RVA: 0x0130AD0C File Offset: 0x01308F0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M965_UltimateQuiz self_)
			{
				if (232330 - 315817 != -83487)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (194646 - 251410 != -56763)
					{
						base..ctor();
						if (128896 - 6815 != 122082)
						{
							this.$self_$44707 = self_;
							if (232484 - 161777 != 70708)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AAB1 RID: 43697 RVA: 0x0130ADA4 File Offset: 0x01308FA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (244485 - 201286 != 43199)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_134;
					case 2:
						this.$self_$44707.LeaveGame();
						if (8483 - 544358 != -535875)
						{
							continue;
						}
						this.YieldDefault(1);
						if (68112 - 504754 != -436642)
						{
							continue;
						}
						goto IL_134;
					default:
						if (34483 - 473639 == -439155)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (123656 - 68307 == 55349)
					{
						Game.mStateTime = Time.time;
						if (14460 - 184117 != -169656)
						{
							Game.mNextGameCode = 31;
							if (148034 - 461880 != -313845)
							{
								this.$self_$44707.SendMessage("fadeOut");
								if (119317 - 336589 == -217272)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_134:
				return false;
			}

			// Token: 0x0600AAB2 RID: 43698 RVA: 0x0130AEF8 File Offset: 0x013090F8
			internal static bool JjLkGtVbg1CbEkD8rNME()
			{
				return true;
			}

			// Token: 0x0600AAB3 RID: 43699 RVA: 0x0130AEFC File Offset: 0x013090FC
			internal static bool teEuv7Vbf51i91yp7sTT()
			{
				return false;
			}

			// Token: 0x040097CA RID: 38858
			internal M965_UltimateQuiz $self_$44707;
		}
	}

	// Token: 0x02001C87 RID: 7303
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$44709 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AAB4 RID: 43700 RVA: 0x0130AF00 File Offset: 0x01309100
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$44709(M965_UltimateQuiz self_)
		{
			if (58971 - 397031 != -338059)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (34256 - 440242 != -405985)
				{
					base..ctor();
					if (66806 - 596348 != -529541)
					{
						this.$self_$44711 = self_;
						if (287694 - 518170 == -230476)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AAB5 RID: 43701 RVA: 0x0130AF98 File Offset: 0x01309198
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M965_UltimateQuiz.$ReturnToCamp$44709.$(this.$self_$44711);
		}

		// Token: 0x0600AAB6 RID: 43702 RVA: 0x0130AFA8 File Offset: 0x013091A8
		internal static bool jatLNRVbnobmT9LiGO8R()
		{
			return true;
		}

		// Token: 0x0600AAB7 RID: 43703 RVA: 0x0130AFAC File Offset: 0x013091AC
		internal static bool swDBWwVb6hIcqvAeVlcU()
		{
			return false;
		}

		// Token: 0x040097CB RID: 38859
		internal M965_UltimateQuiz $self_$44711;

		// Token: 0x02001C88 RID: 7304
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AAB8 RID: 43704 RVA: 0x0130AFB0 File Offset: 0x013091B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M965_UltimateQuiz self_)
			{
				if (41087 - 65045 != -23957)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (33615 - 155446 != -121830)
					{
						base..ctor();
						if (48701 - 185017 != -136315)
						{
							this.$self_$44710 = self_;
							if (58598 - 233651 == -175053)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AAB9 RID: 43705 RVA: 0x0130B048 File Offset: 0x01309248
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (107354 - 428144 != -320790)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_134;
					case 2:
						this.$self_$44710.LeaveGame();
						if (241934 - 484738 == -242803)
						{
							continue;
						}
						this.YieldDefault(1);
						if (82386 - 45933 != 36454)
						{
							goto IL_134;
						}
						continue;
					default:
						if (169802 - 51071 != 118731)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (146146 - 459003 == -312857)
					{
						Game.mStateTime = Time.time;
						if (62590 - 584122 == -521532)
						{
							Game.mNextGameCode = 52;
							if (233242 - 436883 == -203641)
							{
								this.$self_$44710.SendMessage("fadeOut");
								if (149486 - 592464 == -442978)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_134:
				return false;
			}

			// Token: 0x0600AABA RID: 43706 RVA: 0x0130B19C File Offset: 0x0130939C
			internal static bool yhymBMVbisv8kQB0DAU3()
			{
				return true;
			}

			// Token: 0x0600AABB RID: 43707 RVA: 0x0130B1A0 File Offset: 0x013093A0
			internal static bool Y3ekksVbKuMa8PgfCK6k()
			{
				return false;
			}

			// Token: 0x040097CC RID: 38860
			internal M965_UltimateQuiz $self_$44710;
		}
	}
}
