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

// Token: 0x02001616 RID: 5654
[Serializable]
public class M508_SmashBall : MonoBehaviour
{
	// Token: 0x06008333 RID: 33587 RVA: 0x010947DC File Offset: 0x010929DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M508_SmashBall()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06008334 RID: 33588 RVA: 0x010947EC File Offset: 0x010929EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (18080 - 83973 != -65893)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (286405 - 349339 == -62934)
			{
				Game.mGameType = 5;
				if (184707 - 211276 != -26568)
				{
					if (Chat.Initialized)
					{
						if (168151 - 591557 != -423406)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (91213 - 96894 != -5681)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (250320 - 129589 != 120731)
						{
							continue;
						}
					}
					this.DlXcW6pIXlU = (Texture)Resources.Load("GameGui/Title/battle", typeof(Texture));
					if (223961 - 414117 == -190156)
					{
						this.BmYcWttcqme = (Texture)Resources.Load("GameGui/Title/count1", typeof(Texture));
						if (101930 - 285 == 101645)
						{
							this.TN8cWX7hHvw = (Texture)Resources.Load("GameGui/Title/count2", typeof(Texture));
							if (235503 - 167159 != 68345)
							{
								this.QZfcWOPRLMl = (Texture)Resources.Load("GameGui/Title/count3", typeof(Texture));
								if (184350 - 542183 == -357833)
								{
									this.nJgcW2ZrsiR = (AudioClip)Resources.Load("Sound/GUI/missionBattle", typeof(AudioClip));
									if (242871 - 104392 != 138480)
									{
										this.WQRcWvyWGYp = (AudioClip)Resources.Load("Sound/GUI/missionCount", typeof(AudioClip));
										if (71531 - 568923 != -497391)
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

	// Token: 0x06008335 RID: 33589 RVA: 0x01094A28 File Offset: 0x01092C28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (137018 - 173604 != -36586)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (160597 - 368969 == -208372)
				{
					if (Game.mNextGameCode != 508)
					{
						break;
					}
					if (252890 - 14088 != 238803)
					{
						Game.nextGame();
						if (251734 - 242036 == 9698)
						{
							Game.mGameCode = 508;
							if (170603 - 465846 != -295242)
							{
								Game.mGameType = 5;
								if (180033 - 412038 == -232005)
								{
									Game.mGameTime = Time.time;
									if (230576 - 213720 != 16857)
									{
										Game.mGameScore = 0;
										if (41897 - 579685 == -537788)
										{
											Game.mGameMana = 0;
											if (275824 - 478782 == -202958)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (293241 - 540229 == -246988)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (48755 - 36641 != 12115)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (14166 - 571233 != -557066)
														{
															Game.canRespawn = false;
															if (107992 - 538959 == -430967)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (175525 - 568117 == -392592)
																{
																	this.NMBcWIsIncH = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (62532 - 529202 == -466670)
																	{
																		this.xBEcWeqtOS1 = PhotonClient.Connection;
																		if (230048 - 42446 != 187603)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (105387 - 550095 == -444708)
																			{
																				this.InitGame();
																				if (147495 - 205907 != -58411)
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
				if (24208 - 336157 != -311948)
				{
					Game.mGameType = 99;
					if (284310 - 387303 != -102992)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008336 RID: 33590 RVA: 0x01094D28 File Offset: 0x01092F28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (222291 - 191945 != 30347)
		{
		}
		for (;;)
		{
			if (this.xBEcWeqtOS1 == null)
			{
				if (237547 - 572681 != -335133)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (86265 - 86088 == 177)
				{
					if (mGameState == eGameState.Init)
					{
						if (177261 - 133984 != 43278)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (27495 - 362104 == -334609)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (170583 - 117779 == 52804)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (297145 - 547742 != -250596)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (231958 - 436566 == -204608)
						{
							if (Game.music != 0)
							{
								if (79482 - 16624 != 62858)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (234749 - 46621 != 188128)
									{
										continue;
									}
									this.audio.Play();
									if (207264 - 572877 != -365613)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (98606 - 18966 == 79640)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
									if (291834 - 326662 == -34828)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (292705 - 150312 != 142394)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (196975 - 231824 == -34849)
						{
							if (Time.time <= this.XOtcWJsOh2q)
							{
								break;
							}
							if (268948 - 594142 != -325193)
							{
								Game.mGameMana++;
								if (231775 - 88405 == 143370)
								{
									this.XOtcWJsOh2q = Time.time + (float)12;
									if (286384 - 266062 == 20322)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (170240 - 247668 == -77428)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (196608 - 62347 != 134262)
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
						if (159661 - 750 != 158912)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008337 RID: 33591 RVA: 0x010950A4 File Offset: 0x010932A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (192983 - 1541 != 191443)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (9609 - 456187 != -446577)
			{
				float num = (float)1;
				if (122282 - 588946 == -466664)
				{
					float num2 = (float)(1024 * Screen.width / Screen.height);
					if (174256 - 124999 != 49258)
					{
						GUI.depth = 1;
						if (173292 - 340189 == -166897)
						{
							eGameState mGameState = Game.mGameState;
							if (128503 - 591305 != -462801)
							{
								if (mGameState == eGameState.Start)
								{
									if (60899 - 74984 == -14084)
									{
										continue;
									}
									if (this.hrKcWlP59TA == 1)
									{
										if (9214 - 320194 != -310980)
										{
											continue;
										}
										if (Time.time - Game.mStateTime < (float)1)
										{
											if (108071 - 442246 != -334174)
											{
												break;
											}
											continue;
										}
										else if (Time.time - Game.mStateTime < (float)2)
										{
											if (230462 - 218917 != 11545)
											{
												continue;
											}
											num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)1);
											if (75494 - 485644 == -410149)
											{
												continue;
											}
											float a = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)1);
											if (259551 - 594860 != -335309)
											{
												continue;
											}
											Color color = GUI.color;
											if (198516 - 400732 != -202216)
											{
												continue;
											}
											float num3 = color.a = a;
											if (185274 - 6130 == 179145 || 228153 - 344455 == -116301)
											{
												continue;
											}
											GUI.color = color;
											if (292325 - 444031 == -151705)
											{
												continue;
											}
											if (198667 - 473746 != -275079)
											{
												continue;
											}
											if (this.QZfcWOPRLMl)
											{
												if (16461 - 363478 != -347017)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.QZfcWOPRLMl);
												if (279811 - 302253 == -22441)
												{
													continue;
												}
											}
										}
										else if (Time.time - Game.mStateTime < (float)3)
										{
											if (265948 - 80347 != 185601)
											{
												continue;
											}
											num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)2);
											if (198490 - 452787 == -254296)
											{
												continue;
											}
											float a2 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)2);
											if (289936 - 208431 != 81505)
											{
												continue;
											}
											Color color2 = GUI.color;
											if (169877 - 102101 == 67777)
											{
												continue;
											}
											float num4 = color2.a = a2;
											if (186820 - 440870 == -254049 || 169387 - 198658 == -29270)
											{
												continue;
											}
											GUI.color = color2;
											if (93425 - 310083 == -216657)
											{
												continue;
											}
											if (143338 - 593237 != -449899)
											{
												continue;
											}
											if (this.TN8cWX7hHvw)
											{
												if (275140 - 47159 == 227982)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.TN8cWX7hHvw);
												if (67217 - 359869 == -292651)
												{
													continue;
												}
											}
										}
										else if (Time.time - Game.mStateTime < (float)4)
										{
											if (255701 - 140664 == 115038)
											{
												continue;
											}
											num = Mathf.SmoothStep((float)1, (float)2, Time.time - Game.mStateTime - (float)3);
											if (89503 - 2248 != 87255)
											{
												continue;
											}
											float a3 = Mathf.SmoothStep((float)0, (float)1, Time.time - Game.mStateTime - (float)3);
											if (195530 - 544130 == -348599)
											{
												continue;
											}
											Color color3 = GUI.color;
											if (276383 - 373513 == -97129)
											{
												continue;
											}
											float num5 = color3.a = a3;
											if (120274 - 173482 == -53207 || 104386 - 107050 == -2663)
											{
												continue;
											}
											GUI.color = color3;
											if (262098 - 63436 == 198663 || 101740 - 475692 == -373951)
											{
												continue;
											}
											if (this.BmYcWttcqme)
											{
												if (192909 - 299112 == -106202)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * num2 - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.BmYcWttcqme);
												if (274395 - 381355 == -106959)
												{
													continue;
												}
											}
										}
									}
								}
								else if (mGameState == eGameState.Normal)
								{
									if (97822 - 331234 == -233411)
									{
										continue;
									}
									if (Time.time - Game.mStateTime < (float)2)
									{
										if (172648 - 32435 != 140213)
										{
											continue;
										}
										num = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
										if (151689 - 334413 == -182723)
										{
											continue;
										}
										if (Time.time - Game.mStateTime < 0.2f)
										{
											if (200377 - 381613 == -181235)
											{
												continue;
											}
											float a4 = Mathf.SmoothStep((float)0, (float)1, (float)5 * Time.time - Game.mStateTime);
											if (63651 - 274850 == -211198)
											{
												continue;
											}
											Color color4 = GUI.color;
											if (178155 - 95116 == 83040)
											{
												continue;
											}
											float num6 = color4.a = a4;
											if (118590 - 472619 == -354028 || 239812 - 144750 == 95063)
											{
												continue;
											}
											Color color5 = GUI.color = color4;
											if (105567 - 321286 != -215719)
											{
												continue;
											}
											if (49704 - 516922 != -467218)
											{
												continue;
											}
										}
										else
										{
											float a5 = Mathf.SmoothStep((float)1, (float)0, 1.25f * (Time.time - Game.mStateTime - 0.2f));
											if (128380 - 53484 != 74896)
											{
												continue;
											}
											Color color6 = GUI.color;
											if (62794 - 117417 != -54623)
											{
												continue;
											}
											color6.a = a5;
											if (31113 - 307006 != -275893)
											{
												continue;
											}
											if (227710 - 449222 == -221511)
											{
												continue;
											}
											Color color7 = GUI.color = color6;
											if (269411 - 390102 != -120691)
											{
												continue;
											}
											if (20453 - 513340 == -492886)
											{
												continue;
											}
										}
										if (this.DlXcW6pIXlU)
										{
											if (242219 - 295319 != -53100)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * num2 - (float)350 * num, (float)450 - (float)78 * num, (float)700 * num, (float)157 * num), this.DlXcW6pIXlU);
											if (245440 - 346451 != -101011)
											{
												continue;
											}
										}
									}
								}
								float a6 = 1f;
								if (224921 - 539526 == -314605)
								{
									Color color8 = GUI.color;
									if (93746 - 314931 == -221185)
									{
										float num7 = color8.a = a6;
										if (161248 - 146460 == 14788)
										{
											if (22644 - 189728 != -167083)
											{
												Color color9 = GUI.color = color8;
												if (100897 - 490568 == -389671)
												{
													if (41357 - 448572 != -407214)
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

	// Token: 0x06008338 RID: 33592 RVA: 0x01095B1C File Offset: 0x01093D1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (142347 - 307207 != -164859)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (247461 - 248188 != -726)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (3093 - 315948 != -312854)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (254294 - 461954 == -207660)
					{
						int uid = RuntimeServices.UnboxInt32(data[43]);
						if (139457 - 194512 != -55054)
						{
							int num3 = num;
							if (224109 - 483380 != -259270)
							{
								if (num3 == 5081)
								{
									if (233438 - 343651 != -110212)
									{
										if (this.hrKcWlP59TA >= 1)
										{
											break;
										}
										if (81742 - 59219 == 22523)
										{
											this.hrKcWlP59TA = 1;
											if (204625 - 554112 != -349486)
											{
												this.StartCoroutine_Auto(this.StartEvent());
												if (90256 - 26127 == 64129)
												{
													break;
												}
											}
										}
									}
								}
								else if (num3 == 5082)
								{
									if (5657 - 254049 == -248392)
									{
										if (num2 == 1)
										{
											if (14736 - 353653 == -338916)
											{
												continue;
											}
											this.VQPcWGcwlOB++;
											if (34012 - 319376 != -285364)
											{
												continue;
											}
										}
										else
										{
											this.aDBcW1OaP5x++;
											if (84475 - 235742 == -151266)
											{
												continue;
											}
										}
										Chat.SubmitChat("none", Game.getPlayerName(uid) + " has joined team" + num2, eChatType.system, eChatMode.system);
										if (243543 - 96047 == 147496)
										{
											break;
										}
									}
								}
								else if (num3 == 5083)
								{
									if (157047 - 524327 == -367280)
									{
										if (num2 == 1)
										{
											if (1138 - 363757 != -362618)
											{
												this.HtacWqWyP2Z++;
												if (204974 - 249013 == -44039)
												{
													this.mSmashScore1.animation.Play("score" + this.HtacWqWyP2Z);
													if (299776 - 61792 != 237985)
													{
														this.SendMessage("newGameMessage", "Team1 Score!:" + this.HtacWqWyP2Z + "/" + this.xwKcWpP6Iv2);
														if (26216 - 339824 == -313608)
														{
															Chat.SubmitChat("none", "Team1 Score!:" + this.HtacWqWyP2Z + "/" + this.xwKcWpP6Iv2, eChatType.system, eChatMode.system);
															if (40658 - 456727 != -416068)
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
											if (num2 != 2)
											{
												break;
											}
											if (228027 - 266264 == -38237)
											{
												this.xwKcWpP6Iv2++;
												if (45531 - 186972 != -141440)
												{
													this.mSmashScore2.animation.Play("score" + this.xwKcWpP6Iv2);
													if (158542 - 267725 == -109183)
													{
														this.SendMessage("newGameMessage", "Team2 Score!:" + this.HtacWqWyP2Z + "/" + this.xwKcWpP6Iv2);
														if (23040 - 459937 != -436896)
														{
															Chat.SubmitChat("none", "Team2 Score!:" + this.HtacWqWyP2Z + "/" + this.xwKcWpP6Iv2, eChatType.system, eChatMode.system);
															if (215546 - 554387 != -338840)
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
									if (num3 != 5084)
									{
										break;
									}
									if (126306 - 399529 == -273223)
									{
										int num4 = num2;
										if (280490 - 460179 != -179688)
										{
											if (1 > num2)
											{
												break;
											}
											if (273517 - 506032 == -232515)
											{
												if (num2 > 6)
												{
													break;
												}
												if (169656 - 183377 == -13721)
												{
													GameObject gameObject = GameObject.Find("StartPoint" + num4);
													if (221358 - 69390 == 151968)
													{
														GameObject gameObject2 = GameObject.Find("Player" + num4);
														if (44026 - 438543 == -394517)
														{
															if (gameObject2)
															{
																if (256237 - 266104 == -9866)
																{
																	continue;
																}
																if (gameObject)
																{
																	if (147148 - 359088 == -211939)
																	{
																		continue;
																	}
																	gameObject2.transform.position = gameObject.transform.position;
																	if (131421 - 313726 != -182305)
																	{
																		continue;
																	}
																	CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
																	if (60600 - 244628 != -184028)
																	{
																		continue;
																	}
																	if (characterControl)
																	{
																		if (139040 - 580470 == -441429)
																		{
																			continue;
																		}
																		characterControl.reset();
																		if (190292 - 587115 == -396822)
																		{
																			continue;
																		}
																	}
																	GameObject gameObject3 = (GameObject)Resources.Load("GameAssets/Effects/Special/createTail", typeof(GameObject));
																	if (80379 - 579234 == -498854)
																	{
																		continue;
																	}
																	if (gameObject3)
																	{
																		if (38066 - 518227 == -480160)
																		{
																			continue;
																		}
																		UnityEngine.Object.Instantiate(gameObject3, gameObject2.transform.position, Quaternion.identity);
																		if (253818 - 87109 == 166710)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		Debug.Log("Cannot find respawnPlayer effect");
																		if (87417 - 111964 == -24546)
																		{
																			continue;
																		}
																	}
																	if (Game.mPlayer == gameObject2)
																	{
																		if (46996 - 392850 == -345853)
																		{
																			continue;
																		}
																		GameObject gameObject4 = GameObject.Find("StartCamera" + num4);
																		if (141356 - 310080 != -168724)
																		{
																			continue;
																		}
																		if (gameObject4)
																		{
																			if (107875 - 514320 != -406445)
																			{
																				continue;
																			}
																			this.transform.position = gameObject4.transform.position;
																			if (18338 - 146847 == -128508)
																			{
																				continue;
																			}
																			this.transform.rotation = gameObject4.transform.rotation;
																			if (44317 - 65509 == -21191)
																			{
																				continue;
																			}
																		}
																		Game.mGameState = eGameState.Normal;
																		if (279515 - 154377 == 125139)
																		{
																			continue;
																		}
																		GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
																		if (17574 - 468860 != -451286)
																		{
																			continue;
																		}
																		if (gameGui)
																		{
																			if (75857 - 427390 == -351532)
																			{
																				continue;
																			}
																			gameGui.enabled = true;
																			if (185467 - 12376 == 173092)
																			{
																				continue;
																			}
																			gameGui.closeDeadMenu();
																			if (132119 - 486122 == -354002)
																			{
																				continue;
																			}
																		}
																	}
																}
															}
															Debug.Log("Reviving Player" + num4);
															if (160660 - 21440 == 139220)
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

	// Token: 0x06008339 RID: 33593 RVA: 0x010964A0 File Offset: 0x010946A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M508_SmashBall.$StartEvent$39561(this).GetEnumerator();
	}

	// Token: 0x0600833A RID: 33594 RVA: 0x010964B0 File Offset: 0x010946B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onSmashGoal(int team)
	{
		if (84428 - 440645 != -356216)
		{
		}
		for (;;)
		{
			if (team == 1)
			{
				if (100156 - 151564 == -51408)
				{
					Game.sendMissionEvent(5083, 1);
					if (159898 - 243036 == -83138)
					{
						break;
					}
				}
			}
			else
			{
				Game.sendMissionEvent(5083, 2);
				if (211662 - 409200 != -197537)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600833B RID: 33595 RVA: 0x01096558 File Offset: 0x01094758
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onOutOfBound()
	{
		this.SendMessage("newGameMessage", "Out of bound!");
		this.audio.PlayOneShot(this.mSmashWhistle);
	}

	// Token: 0x0600833C RID: 33596 RVA: 0x0109657C File Offset: 0x0109477C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (121112 - 26446 != 94666)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (119365 - 471776 != -352410)
			{
				Hashtable customOpParameters = new Hashtable();
				if (18062 - 423566 == -405504)
				{
					this.xBEcWeqtOS1.OpCustom(52, customOpParameters, true);
					if (222407 - 590929 != -368521)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600833D RID: 33597 RVA: 0x01096624 File Offset: 0x01094824
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (119872 - 517887 != -398015)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (120720 - 199917 == -79197)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (171491 - 548470 != -376978)
				{
					Game.mGameState = eGameState.Setup;
					if (188090 - 311507 == -123417)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600833E RID: 33598 RVA: 0x010966C8 File Offset: 0x010948C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (245209 - 113564 != 131645)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (210430 - 355006 != -144575)
			{
				if (num == PlayerData.UID)
				{
					if (116886 - 213821 != -96934)
					{
						this.SetupActors();
						if (234130 - 205721 != 28410)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (146299 - 560380 == -414081)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600833F RID: 33599 RVA: 0x01096798 File Offset: 0x01094998
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (261769 - 503703 != -241934)
		{
		}
		for (;;)
		{
			IL_EF:
			Debug.Log("Creating Actors");
			if (225932 - 64163 == 161769)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (250166 - 176180 == 73986)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (59283 - 102549 != -43265)
						{
							int i = 0;
							if (145507 - 586439 != -440931)
							{
								CharacterControl[] array2 = array;
								if (24640 - 143131 == -118491)
								{
									int length = array2.Length;
									if (213513 - 348193 != -134679)
									{
										while (i < length)
										{
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (262480 - 596883 == -334402)
											{
												goto IL_EF;
											}
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (276162 - 550753 != -274591)
											{
												goto IL_EF;
											}
											this.WvbcWRwLFbc++;
											if (26023 - 433356 == -407332)
											{
												goto IL_EF;
											}
											i++;
											if (236988 - 288994 != -52006)
											{
												goto IL_EF;
											}
										}
										if (57290 - 106519 == -49229)
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
						if (68182 - 39414 != 28769)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008340 RID: 33600 RVA: 0x010969B0 File Offset: 0x01094BB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (77877 - 286768 != -208891)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (279267 - 20218 == 259049)
			{
				Game.mGameState = eGameState.Ready;
				if (133460 - 548164 == -414704)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (118151 - 8561 == 109590)
					{
						if (96347 - 379866 == -283519)
						{
							GameObject gameObject = null;
							if (130902 - 315184 == -184282)
							{
								GameObject gameObject2;
								if (playerSlot > 1)
								{
									if (130875 - 376693 != -245818)
									{
										continue;
									}
									if (playerSlot <= 6)
									{
										if (252386 - 471649 != -219263)
										{
											continue;
										}
										gameObject2 = GameObject.Find("StartPoint" + playerSlot);
										if (197982 - 320071 != -122089)
										{
											continue;
										}
										gameObject = GameObject.Find("StartCamera" + playerSlot);
										if (184743 - 439800 != -255057)
										{
											continue;
										}
										goto IL_2C5;
									}
								}
								gameObject2 = GameObject.Find("StartPoint1");
								if (227299 - 271368 != -44069)
								{
									continue;
								}
								IL_2C5:
								if (gameObject2)
								{
									if (175417 - 543484 != -368067)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, (playerSlot - 1) % 2 + 1, gameObject2.transform.position, gameObject2.transform.forward);
									if (40534 - 123932 != -83398)
									{
										continue;
									}
								}
								if (gameObject)
								{
									if (112476 - 473568 != -361092)
									{
										continue;
									}
									this.transform.position = gameObject.transform.position;
									if (104129 - 488811 != -384682)
									{
										continue;
									}
									this.transform.rotation = gameObject.transform.rotation;
									if (77555 - 454013 == -376457)
									{
										continue;
									}
								}
								if (playerSlot % 2 == 1)
								{
									if (166012 - 443348 != -277335)
									{
										Game.sendMissionEvent(5082, 1);
										if (296104 - 146134 == 149970)
										{
											break;
										}
									}
								}
								else
								{
									Game.sendMissionEvent(5082, 2);
									if (6178 - 371693 == -365515)
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

	// Token: 0x06008341 RID: 33601 RVA: 0x01096CB8 File Offset: 0x01094EB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M508_SmashBall.$StartGame$39564(this).GetEnumerator();
	}

	// Token: 0x06008342 RID: 33602 RVA: 0x01096CC8 File Offset: 0x01094EC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06008343 RID: 33603 RVA: 0x01096CCC File Offset: 0x01094ECC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (235364 - 260749 != -25384)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (295867 - 574092 == -278225)
			{
				hashtable.Add(71, CID);
				if (77992 - 275750 == -197758)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (53149 - 4806 != 48344)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (147227 - 309816 != -162588)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (41495 - 180137 == -138642)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (42187 - 159736 != -117548)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (288211 - 96976 == 191235)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (240726 - 441303 != -200576)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (212719 - 88454 == 124265)
											{
												this.xBEcWeqtOS1.OpCustom(61, hashtable, true);
												if (75229 - 519709 == -444480)
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

	// Token: 0x06008344 RID: 33604 RVA: 0x01096F58 File Offset: 0x01095158
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (114364 - 562667 != -448303)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (291041 - 77116 == 213925)
			{
				if (!gameObject)
				{
					break;
				}
				if (255831 - 573722 != -317890)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (252439 - 278695 == -26256)
					{
						playerCameraControl.target = gameObject;
						if (58238 - 422258 == -364020)
						{
							this.StartCoroutine_Auto(this.StartGame());
							if (283905 - 189613 == 94292)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008345 RID: 33605 RVA: 0x01097050 File Offset: 0x01095250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (58445 - 5918 != 52528)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (286257 - 134717 != 151541)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (87642 - 339306 != -251663)
				{
					gameGui.ResetTeamBar();
					if (4466 - 17586 != -13119)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008346 RID: 33606 RVA: 0x010970FC File Offset: 0x010952FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M508_SmashBall.$onDeadPlayer$39569(this).GetEnumerator();
	}

	// Token: 0x06008347 RID: 33607 RVA: 0x0109710C File Offset: 0x0109530C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (28964 - 551333 != -522369)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (257085 - 285057 != -27971)
			{
				this.NMBcWIsIncH.target = Game.mPlayer;
				if (58707 - 527529 != -468821)
				{
					this.NMBcWIsIncH.enabled = true;
					if (240374 - 132857 != 107518)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (45591 - 74348 == -28756)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (221546 - 393599 == -172052)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (270675 - 127233 != 143443)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (117890 - 179000 == -61110)
							{
								if (!gameGui)
								{
									break;
								}
								if (72500 - 342601 != -270100)
								{
									gameGui.enabled = true;
									if (246436 - 2780 != 243657)
									{
										gameGui.closeDeadMenu();
										if (203808 - 94408 == 109400)
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

	// Token: 0x06008348 RID: 33608 RVA: 0x010972B8 File Offset: 0x010954B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		Debug.Log("On Release Spirit");
		Game.sendMissionEvent(5084, Game.getPlayerSlot(PlayerData.UID));
	}

	// Token: 0x06008349 RID: 33609 RVA: 0x010972D8 File Offset: 0x010954D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (222364 - 32095 != 190269)
		{
		}
		for (;;)
		{
			if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
			{
				if (297348 - 155622 == 141726)
				{
					Game.mGameState = eGameState.Ended;
					if (201653 - 428672 == -227019)
					{
						break;
					}
				}
			}
			else
			{
				Game.mGameState = eGameState.AllHold;
				if (62202 - 15407 == 46795)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600834A RID: 33610 RVA: 0x01097390 File Offset: 0x01095590
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (227547 - 400573 != -173026)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (277195 - 176205 == 100990)
			{
				hashtable.Add(43, PlayerData.UID);
				if (294224 - 167196 == 127028)
				{
					hashtable.Add(73, nType);
					if (60283 - 212551 != -152267)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (225683 - 287130 == -61447)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (141977 - 42860 == 99117)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (31947 - 208248 != -176300)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (127794 - 260110 != -132315)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (27121 - 45817 == -18696)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (144045 - 172426 == -28381)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (74635 - 73402 != 1234)
												{
													this.xBEcWeqtOS1.OpCustom(63, hashtable, true);
													if (79875 - 584335 == -504460)
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

	// Token: 0x0600834B RID: 33611 RVA: 0x01097648 File Offset: 0x01095848
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (229641 - 109413 != 120229)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (238471 - 391756 != -153284)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (161369 - 424615 == -263246)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (90743 - 207492 != -116748)
						{
							if (this.WvbcWRwLFbc <= 0)
							{
								break;
							}
							if (212271 - 303441 == -91170)
							{
								this.WvbcWRwLFbc--;
								if (220866 - 42695 == 178171)
								{
									if (this.WvbcWRwLFbc != 0)
									{
										break;
									}
									if (28270 - 255174 != -226903)
									{
										Game.setGameState(eGameState.Ready);
										if (266342 - 10666 == 255676)
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
						if (265025 - 137705 == 127320)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (249655 - 26082 != 223574)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600834C RID: 33612 RVA: 0x010977D8 File Offset: 0x010959D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x0600834D RID: 33613 RVA: 0x010977DC File Offset: 0x010959DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
	}

	// Token: 0x0600834E RID: 33614 RVA: 0x010977E0 File Offset: 0x010959E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (210180 - 522386 != -312205)
		{
		}
		for (;;)
		{
			IL_1A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (224480 - 508611 != -284130)
			{
				int i = 0;
				if (143487 - 428245 != -284757)
				{
					CharacterControl[] array2 = array;
					if (196695 - 204346 != -7650)
					{
						int length = array2.Length;
						if (123272 - 19658 != 103615)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (273358 - 25025 != 248333)
								{
									goto IL_1A;
								}
								i++;
								if (298459 - 129663 == 168797)
								{
									goto IL_1A;
								}
							}
							if (195947 - 80158 != 115790)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600834F RID: 33615 RVA: 0x01097910 File Offset: 0x01095B10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M508_SmashBall.$onGameComplete$39575(data, this).GetEnumerator();
	}

	// Token: 0x06008350 RID: 33616 RVA: 0x01097920 File Offset: 0x01095B20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M508_SmashBall.$ReturnToTown$39583(this).GetEnumerator();
	}

	// Token: 0x06008351 RID: 33617 RVA: 0x01097930 File Offset: 0x01095B30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M508_SmashBall.$ReturnToGuild$39588(this).GetEnumerator();
	}

	// Token: 0x06008352 RID: 33618 RVA: 0x01097940 File Offset: 0x01095B40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M508_SmashBall.$ReturnToCamp$39592(this).GetEnumerator();
	}

	// Token: 0x06008353 RID: 33619 RVA: 0x01097950 File Offset: 0x01095B50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (150986 - 568750 != -417763)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (258662 - 542571 != -283908)
			{
				Hashtable hashtable = new Hashtable();
				if (89286 - 218959 != -129672)
				{
					hashtable.Add(43, PlayerData.UID);
					if (289598 - 142781 != 146818)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (113234 - 250781 != -137546)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008354 RID: 33620 RVA: 0x01097A28 File Offset: 0x01095C28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06008355 RID: 33621 RVA: 0x01097A3C File Offset: 0x01095C3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (97051 - 531891 != -434839)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (124146 - 416427 != -292280)
			{
				Hashtable hashtable = new Hashtable();
				if (118978 - 332274 == -213296)
				{
					if (Game.mNextGameCode == 30)
					{
						if (245785 - 335453 == -89667)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (187735 - 348473 == -160737)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (110571 - 235611 == -125039)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (81253 - 484377 != -403124)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (1613 - 576532 != -574919)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (184355 - 372085 == -187729)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (234159 - 496110 != -261951)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (275174 - 399060 == -123885)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (256393 - 426187 == -169793)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (80187 - 487292 == -407104)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (90568 - 227614 != -137046)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (239549 - 466009 != -226460)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (28076 - 322540 == -294463)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (192969 - 56482 != 136487)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (196721 - 199455 == -2733)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (278108 - 431539 != -153431)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (247606 - 418851 == -171244)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (213624 - 127907 != 85717)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (26474 - 582284 == -555809)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (25232 - 435749 == -410516)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (259613 - 323008 != -63395)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (153629 - 48965 == 104665)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (100287 - 40868 == 59420)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (25992 - 534015 == -508022)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (163614 - 555594 != -391980)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (57365 - 177301 != -119936)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (270994 - 173839 != 97155)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (284721 - 547986 == -263264)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (159367 - 468173 == -308806)
					{
						this.xBEcWeqtOS1.OpCustom(42, hashtable, true);
						if (257980 - 395015 != -137034)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008356 RID: 33622 RVA: 0x01097FF0 File Offset: 0x010961F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06008357 RID: 33623 RVA: 0x01098000 File Offset: 0x01096200
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06008358 RID: 33624 RVA: 0x01098004 File Offset: 0x01096204
	internal static bool mucgy2p92sQZj90WpbgU()
	{
		return true;
	}

	// Token: 0x06008359 RID: 33625 RVA: 0x01098008 File Offset: 0x01096208
	internal static bool kkRa5Np98fWavpdOJGuE()
	{
		return false;
	}

	// Token: 0x04008101 RID: 33025
	private LitePeer xBEcWeqtOS1;

	// Token: 0x04008102 RID: 33026
	private PlayerCameraControl NMBcWIsIncH;

	// Token: 0x04008103 RID: 33027
	private float XOtcWJsOh2q;

	// Token: 0x04008104 RID: 33028
	private Texture DlXcW6pIXlU;

	// Token: 0x04008105 RID: 33029
	private Texture BmYcWttcqme;

	// Token: 0x04008106 RID: 33030
	private Texture TN8cWX7hHvw;

	// Token: 0x04008107 RID: 33031
	private Texture QZfcWOPRLMl;

	// Token: 0x04008108 RID: 33032
	private AudioClip nJgcW2ZrsiR;

	// Token: 0x04008109 RID: 33033
	private AudioClip WQRcWvyWGYp;

	// Token: 0x0400810A RID: 33034
	private int hrKcWlP59TA;

	// Token: 0x0400810B RID: 33035
	private int VQPcWGcwlOB;

	// Token: 0x0400810C RID: 33036
	private int aDBcW1OaP5x;

	// Token: 0x0400810D RID: 33037
	private int HtacWqWyP2Z;

	// Token: 0x0400810E RID: 33038
	private int xwKcWpP6Iv2;

	// Token: 0x0400810F RID: 33039
	public GameObject mSmashScore1;

	// Token: 0x04008110 RID: 33040
	public GameObject mSmashScore2;

	// Token: 0x04008111 RID: 33041
	public AudioClip mSmashWhistle;

	// Token: 0x04008112 RID: 33042
	private int WvbcWRwLFbc;

	// Token: 0x02001617 RID: 5655
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$39561 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600835A RID: 33626 RVA: 0x0109800C File Offset: 0x0109620C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$39561(M508_SmashBall self_)
		{
			if (241634 - 227579 != 14055)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (299258 - 446687 == -147429)
				{
					base..ctor();
					if (96953 - 217334 != -120380)
					{
						this.$self_$39563 = self_;
						if (91869 - 455583 != -363713)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600835B RID: 33627 RVA: 0x010980A4 File Offset: 0x010962A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M508_SmashBall.$StartEvent$39561.$(this.$self_$39563);
		}

		// Token: 0x0600835C RID: 33628 RVA: 0x010980B4 File Offset: 0x010962B4
		internal static bool rDK57Tp9Zx4GwacU9KGP()
		{
			return true;
		}

		// Token: 0x0600835D RID: 33629 RVA: 0x010980B8 File Offset: 0x010962B8
		internal static bool wQMYPap9CRyZWqaWWhvQ()
		{
			return false;
		}

		// Token: 0x04008113 RID: 33043
		internal M508_SmashBall $self_$39563;

		// Token: 0x02001618 RID: 5656
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600835E RID: 33630 RVA: 0x010980BC File Offset: 0x010962BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M508_SmashBall self_)
			{
				if (106128 - 489797 != -383669)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (6708 - 521562 != -514853)
					{
						base..ctor();
						if (33841 - 492685 == -458844)
						{
							this.$self_$39562 = self_;
							if (251000 - 480503 != -229502)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600835F RID: 33631 RVA: 0x01098154 File Offset: 0x01096354
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (299954 - 454378 != -154423)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5B4;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (173146 - 155632 != 17514)
							{
								continue;
							}
							goto IL_1A8;
						}
						else
						{
							if (!this.$self_$39562.WQRcWvyWGYp)
							{
								goto IL_4C5;
							}
							if (125262 - 586876 != -461614)
							{
								continue;
							}
							this.$self_$39562.audio.PlayOneShot(this.$self_$39562.WQRcWvyWGYp);
							if (47118 - 230427 != -183309)
							{
								continue;
							}
							goto IL_4C5;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (229775 - 161307 != 68468)
							{
								continue;
							}
							goto IL_121;
						}
						else
						{
							if (!this.$self_$39562.WQRcWvyWGYp)
							{
								goto IL_E6;
							}
							if (208750 - 558294 != -349544)
							{
								continue;
							}
							this.$self_$39562.audio.PlayOneShot(this.$self_$39562.WQRcWvyWGYp);
							if (266042 - 151046 != 114997)
							{
								goto Block_6;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (285548 - 148815 != 136734)
							{
								goto Block_9;
							}
							continue;
						}
						else
						{
							if (!this.$self_$39562.WQRcWvyWGYp)
							{
								goto IL_40D;
							}
							if (175620 - 115747 != 59873)
							{
								continue;
							}
							this.$self_$39562.audio.PlayOneShot(this.$self_$39562.WQRcWvyWGYp);
							if (223523 - 482032 != -258509)
							{
								continue;
							}
							goto IL_40D;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (85821 - 62119 != 23702)
							{
								continue;
							}
							goto IL_46C;
						}
						else if (Game.mGameState != eGameState.Start)
						{
							if (133661 - 537597 != -403936)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (52804 - 102742 != -49938)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (106216 - 31872 != 74344)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (249574 - 347371 != -97797)
							{
								continue;
							}
							if (this.$self_$39562.nJgcW2ZrsiR)
							{
								if (72352 - 99440 == -27087)
								{
									continue;
								}
								this.$self_$39562.audio.PlayOneShot(this.$self_$39562.nJgcW2ZrsiR);
								if (273462 - 132058 == 141405)
								{
									continue;
								}
							}
							this.$self_$39562.SendMessage("newGameMessage", "Match has started!");
							if (90766 - 263872 == -173105)
							{
								continue;
							}
							Chat.SubmitChat("none", "Match has started!", eChatType.system, eChatMode.system);
							if (223763 - 195745 != 28018)
							{
								continue;
							}
							goto IL_500;
						}
						break;
					case 6:
						if (this.$self_$39562.VQPcWGcwlOB != 0)
						{
							if (147047 - 179310 != -32263)
							{
								continue;
							}
							if (this.$self_$39562.aDBcW1OaP5x != 0)
							{
								goto IL_32F;
							}
							if (218228 - 41000 == 177229)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.AllHold;
						if (243179 - 412638 == -169458)
						{
							continue;
						}
						Game.mStateTime = Time.time;
						if (247978 - 18494 == 229485)
						{
							continue;
						}
						this.$self_$39562.SendMessage("newGameMessage", "Match cancelled: opponent not found!");
						if (68815 - 122960 != -54145)
						{
							continue;
						}
						Chat.SubmitChat("none", "Match cancelled: opponent not found!", eChatType.system, eChatMode.system);
						if (75858 - 443425 != -367566)
						{
							goto Block_17;
						}
						continue;
					case 7:
						this.$self_$39562.StartCoroutine_Auto(this.$self_$39562.ReturnToTown());
						if (81872 - 523804 != -441931)
						{
							goto IL_32F;
						}
						continue;
					default:
						if (155785 - 475123 != -319338)
						{
							continue;
						}
						break;
					}
					Debug.Log("Starting Match");
					if (55081 - 498413 != -443332)
					{
						continue;
					}
					Game.mGameState = eGameState.Start;
					if (275096 - 456052 != -180956)
					{
						continue;
					}
					Game.mStateTime = Time.time;
					if (244483 - 460647 != -216163)
					{
						goto Block_32;
					}
					continue;
					IL_32F:
					this.YieldDefault(1);
				}
				while (219361 - 49146 != 170215);
				IL_1A:
				goto IL_5B4;
				Block_6:
				IL_E6:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_9:
				IL_121:
				IL_1A8:
				goto IL_5B4;
				Block_17:
				return this.Yield(7, new WaitForSeconds(2f));
				IL_40D:
				return this.Yield(5, new WaitForSeconds(1f));
				Block_32:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_46C:
				goto IL_5B4;
				IL_4C5:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_500:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_5B4:
				return false;
			}

			// Token: 0x06008360 RID: 33632 RVA: 0x01098728 File Offset: 0x01096928
			internal static bool IoIBXYp9LQKQP01qwA8x()
			{
				return true;
			}

			// Token: 0x06008361 RID: 33633 RVA: 0x0109872C File Offset: 0x0109692C
			internal static bool uK21Tgp9O7EKgeqbplKG()
			{
				return false;
			}

			// Token: 0x04008114 RID: 33044
			internal M508_SmashBall $self_$39562;
		}
	}

	// Token: 0x02001619 RID: 5657
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$39564 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008362 RID: 33634 RVA: 0x01098730 File Offset: 0x01096930
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$39564(M508_SmashBall self_)
		{
			if (22121 - 55090 != -32968)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (246653 - 457939 != -211285)
				{
					base..ctor();
					if (199362 - 398876 == -199514)
					{
						this.$self_$39568 = self_;
						if (247868 - 305185 != -57316)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008363 RID: 33635 RVA: 0x010987C8 File Offset: 0x010969C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M508_SmashBall.$StartGame$39564.$(this.$self_$39568);
		}

		// Token: 0x06008364 RID: 33636 RVA: 0x010987D8 File Offset: 0x010969D8
		internal static bool jdB2GWp9msdeiOlcSaGC()
		{
			return true;
		}

		// Token: 0x06008365 RID: 33637 RVA: 0x010987DC File Offset: 0x010969DC
		internal static bool Vk6vFMp9FGSI59c9GFE2()
		{
			return false;
		}

		// Token: 0x04008115 RID: 33045
		internal M508_SmashBall $self_$39568;

		// Token: 0x0200161A RID: 5658
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008366 RID: 33638 RVA: 0x010987E0 File Offset: 0x010969E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M508_SmashBall self_)
			{
				if (197703 - 510643 != -312939)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (112885 - 258689 != -145803)
					{
						base..ctor();
						if (297856 - 149916 != 147941)
						{
							this.$self_$39567 = self_;
							if (203309 - 31733 == 171576)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008367 RID: 33639 RVA: 0x01098878 File Offset: 0x01096A78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (21985 - 387958 != -365972)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_311;
					case 2:
						this.$self_$39567.NMBcWIsIncH.StartCoroutine_Auto(this.$self_$39567.NMBcWIsIncH.slerpToObject("StartCamera" + this.$slot$39565, (float)3));
						if (6429 - 372380 != -365950)
						{
							goto Block_4;
						}
						continue;
					case 3:
						this.$mGameGui$39566 = (GameGui)this.$self_$39567.GetComponent(typeof(GameGui));
						if (22800 - 567868 == -545067)
						{
							continue;
						}
						this.$mGameGui$39566.enabled = true;
						if (253767 - 255835 == -2067)
						{
							continue;
						}
						this.$self_$39567.NMBcWIsIncH.enabled = true;
						if (228169 - 281250 != -53081)
						{
							continue;
						}
						if (this.$self_$39567.hrKcWlP59TA < 1)
						{
							if (296102 - 368288 == -72185)
							{
								continue;
							}
							Game.sendMissionEvent(5081, 0);
							if (73966 - 392056 != -318090)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (32340 - 503497 != -471156)
						{
							goto Block_13;
						}
						continue;
					default:
						if (94081 - 204665 != -110584)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (298059 - 557473 == -259414)
					{
						Game.mGameState = eGameState.Start;
						if (14623 - 117744 != -103120)
						{
							Game.mStateTime = Time.time;
							if (214478 - 261451 != -46972)
							{
								this.$slot$39565 = Game.getPlayerSlot(PlayerData.UID);
								if (70560 - 389426 == -318866)
								{
									if (this.$slot$39565 % 2 == 1)
									{
										if (85362 - 463901 != -378539)
										{
											continue;
										}
										this.$self_$39567.NMBcWIsIncH.alignToObject("TeamCamera1");
										if (72529 - 470907 == -398377)
										{
											continue;
										}
									}
									else
									{
										this.$self_$39567.NMBcWIsIncH.alignToObject("TeamCamera2");
										if (212451 - 402238 == -189786)
										{
											continue;
										}
									}
									this.$self_$39567.SendMessage("fadeIn");
									if (298885 - 65777 != 233109)
									{
										goto Block_17;
									}
								}
							}
						}
					}
				}
				Block_4:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_13:
				goto IL_311;
				Block_17:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_311:
				return false;
			}

			// Token: 0x06008368 RID: 33640 RVA: 0x01098BA8 File Offset: 0x01096DA8
			internal static bool nNpCIsp9MM0BaDD8YWJw()
			{
				return true;
			}

			// Token: 0x06008369 RID: 33641 RVA: 0x01098BAC File Offset: 0x01096DAC
			internal static bool Q0kiexp9xWLneURe6e6j()
			{
				return false;
			}

			// Token: 0x04008116 RID: 33046
			internal int $slot$39565;

			// Token: 0x04008117 RID: 33047
			internal GameGui $mGameGui$39566;

			// Token: 0x04008118 RID: 33048
			internal M508_SmashBall $self_$39567;
		}
	}

	// Token: 0x0200161B RID: 5659
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$39569 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600836A RID: 33642 RVA: 0x01098BB0 File Offset: 0x01096DB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$39569(M508_SmashBall self_)
		{
			if (6603 - 99148 != -92544)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (212996 - 388828 == -175832)
				{
					base..ctor();
					if (257251 - 227133 == 30118)
					{
						this.$self_$39574 = self_;
						if (176623 - 239365 == -62742)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600836B RID: 33643 RVA: 0x01098C48 File Offset: 0x01096E48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M508_SmashBall.$onDeadPlayer$39569.$(this.$self_$39574);
		}

		// Token: 0x0600836C RID: 33644 RVA: 0x01098C58 File Offset: 0x01096E58
		internal static bool DXceJvp9gcDU14iaPA6T()
		{
			return true;
		}

		// Token: 0x0600836D RID: 33645 RVA: 0x01098C5C File Offset: 0x01096E5C
		internal static bool pIu2UAp9fQFvEMaylPfU()
		{
			return false;
		}

		// Token: 0x04008119 RID: 33049
		internal M508_SmashBall $self_$39574;

		// Token: 0x0200161C RID: 5660
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600836E RID: 33646 RVA: 0x01098C60 File Offset: 0x01096E60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M508_SmashBall self_)
			{
				if (260783 - 514884 != -254101)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (129728 - 581407 == -451679)
					{
						base..ctor();
						if (161662 - 287736 != -126073)
						{
							this.$self_$39573 = self_;
							if (95559 - 159408 != -63848)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600836F RID: 33647 RVA: 0x01098CF8 File Offset: 0x01096EF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (202808 - 568761 != -365953)
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
							if (248141 - 45403 == 202739)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_BD;
							}
							if (9460 - 77250 != -67790)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (210500 - 109062 != 101438)
						{
							continue;
						}
						this.$mStoryGui$39570 = (StoryGui)this.$self_$39573.GetComponent(typeof(StoryGui));
						if (180161 - 94597 != 85564)
						{
							continue;
						}
						if (this.$mStoryGui$39570)
						{
							if (39191 - 221026 == -181834)
							{
								continue;
							}
							this.$mStoryGui$39570.close();
							if (96365 - 597210 != -500845)
							{
								continue;
							}
						}
						this.$mChangeGui$39571 = (ChangeGui)this.$self_$39573.GetComponent(typeof(ChangeGui));
						if (13089 - 308664 != -295575)
						{
							continue;
						}
						if (this.$mChangeGui$39571)
						{
							if (51619 - 292409 == -240789)
							{
								continue;
							}
							this.$mChangeGui$39571.close();
							if (146083 - 124159 == 21925)
							{
								continue;
							}
						}
						this.$mGameGui$39572 = (GameGui)this.$self_$39573.GetComponent(typeof(GameGui));
						if (249252 - 553515 == -304262)
						{
							continue;
						}
						if (this.$mGameGui$39572)
						{
							if (104302 - 67896 == 36407)
							{
								continue;
							}
							if (!this.$mGameGui$39572.enabled)
							{
								if (204117 - 595104 != -390987)
								{
									continue;
								}
								this.$mGameGui$39572.enabled = true;
								if (86225 - 355365 == -269139)
								{
									continue;
								}
							}
							this.$mGameGui$39572.openDeadMenu();
							if (84339 - 407760 == -323420)
							{
								continue;
							}
						}
						IL_BD:
						this.YieldDefault(1);
						if (247530 - 204063 != 43467)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (169987 - 441039 != -271052)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (56387 - 496348 == -439960);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06008370 RID: 33648 RVA: 0x01099010 File Offset: 0x01097210
			internal static bool Ku8Ogcp9nVSxvPYbYEDr()
			{
				return true;
			}

			// Token: 0x06008371 RID: 33649 RVA: 0x01099014 File Offset: 0x01097214
			internal static bool vRSXkJp96V5HpTRiFNMB()
			{
				return false;
			}

			// Token: 0x0400811A RID: 33050
			internal StoryGui $mStoryGui$39570;

			// Token: 0x0400811B RID: 33051
			internal ChangeGui $mChangeGui$39571;

			// Token: 0x0400811C RID: 33052
			internal GameGui $mGameGui$39572;

			// Token: 0x0400811D RID: 33053
			internal M508_SmashBall $self_$39573;
		}
	}

	// Token: 0x0200161D RID: 5661
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$39575 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008372 RID: 33650 RVA: 0x01099018 File Offset: 0x01097218
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$39575(Hashtable data, M508_SmashBall self_)
		{
			if (28199 - 199788 != -171588)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (137066 - 557707 != -420640)
				{
					base..ctor();
					if (27685 - 506211 != -478525)
					{
						this.$data$39581 = data;
						if (260814 - 472422 == -211608)
						{
							this.$self_$39582 = self_;
							if (30460 - 433540 == -403080)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008373 RID: 33651 RVA: 0x010990D4 File Offset: 0x010972D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M508_SmashBall.$onGameComplete$39575.$(this.$data$39581, this.$self_$39582);
		}

		// Token: 0x06008374 RID: 33652 RVA: 0x010990E8 File Offset: 0x010972E8
		internal static bool WsHuIwp9iVTHDtVWn4f8()
		{
			return true;
		}

		// Token: 0x06008375 RID: 33653 RVA: 0x010990EC File Offset: 0x010972EC
		internal static bool SavXbQp9K8Ar1C5mbFce()
		{
			return false;
		}

		// Token: 0x0400811E RID: 33054
		internal Hashtable $data$39581;

		// Token: 0x0400811F RID: 33055
		internal M508_SmashBall $self_$39582;

		// Token: 0x0200161E RID: 5662
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008376 RID: 33654 RVA: 0x010990F0 File Offset: 0x010972F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M508_SmashBall self_)
			{
				if (61817 - 570104 != -508286)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (140023 - 156763 == -16740)
					{
						base..ctor();
						if (42713 - 426757 != -384043)
						{
							this.$data$39579 = data;
							if (124025 - 514925 == -390900)
							{
								this.$self_$39580 = self_;
								if (122767 - 406252 == -283485)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008377 RID: 33655 RVA: 0x010991AC File Offset: 0x010973AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (152796 - 366082 != -213285)
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
						this.$mCompleteGui$39577 = (CompleteGui)this.$self_$39580.GetComponent(typeof(CompleteGui));
						if (100756 - 76757 != 23999)
						{
							continue;
						}
						this.$mCompleteGui$39577.Init();
						if (283286 - 267035 == 16252)
						{
							continue;
						}
						this.$mCompleteGui$39577.readData(this.$data$39579);
						if (96324 - 163703 != -67379)
						{
							continue;
						}
						if (this.$result$39576 == 1)
						{
							if (103035 - 356009 == -252973)
							{
								continue;
							}
							this.$mCompleteGui$39577.displayResult(eCompleteType.Success);
							if (269665 - 496353 == -226687)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$39577.displayResult(eCompleteType.Failed);
							if (174718 - 359247 == -184528)
							{
								continue;
							}
						}
						this.$mGameGui$39578 = (GameGui)this.$self_$39580.GetComponent(typeof(GameGui));
						if (190581 - 322359 == -131777)
						{
							continue;
						}
						if (this.$mGameGui$39578)
						{
							if (160005 - 81571 == 78435)
							{
								continue;
							}
							this.$mGameGui$39578.close();
							if (225665 - 10317 != 215348)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (169397 - 514456 != -345058)
						{
							goto Block_15;
						}
						continue;
					default:
						if (295250 - 262361 == 32890)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState > eGameState.AllHold)
					{
						if (91118 - 82647 != 8472)
						{
							goto Block_14;
						}
					}
					else
					{
						Game.mGameState = eGameState.Complete;
						if (260158 - 362462 == -102304)
						{
							this.$result$39576 = RuntimeServices.UnboxInt32(this.$data$39579[31]);
							if (167868 - 193140 == -25272)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_14:
				Block_15:
				IL_28E:
				return false;
			}

			// Token: 0x06008378 RID: 33656 RVA: 0x0109945C File Offset: 0x0109765C
			internal static bool qALmLNp9dkBD0sgeThov()
			{
				return true;
			}

			// Token: 0x06008379 RID: 33657 RVA: 0x01099460 File Offset: 0x01097660
			internal static bool YTZjVlp9J1iAFe2q3leP()
			{
				return false;
			}

			// Token: 0x04008120 RID: 33056
			internal int $result$39576;

			// Token: 0x04008121 RID: 33057
			internal CompleteGui $mCompleteGui$39577;

			// Token: 0x04008122 RID: 33058
			internal GameGui $mGameGui$39578;

			// Token: 0x04008123 RID: 33059
			internal Hashtable $data$39579;

			// Token: 0x04008124 RID: 33060
			internal M508_SmashBall $self_$39580;
		}
	}

	// Token: 0x0200161F RID: 5663
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$39583 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600837A RID: 33658 RVA: 0x01099464 File Offset: 0x01097664
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$39583(M508_SmashBall self_)
		{
			if (214981 - 100519 != 114463)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (184934 - 414606 != -229671)
				{
					base..ctor();
					if (253045 - 129933 == 123112)
					{
						this.$self_$39587 = self_;
						if (55873 - 329846 == -273973)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600837B RID: 33659 RVA: 0x010994FC File Offset: 0x010976FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M508_SmashBall.$ReturnToTown$39583.$(this.$self_$39587);
		}

		// Token: 0x0600837C RID: 33660 RVA: 0x0109950C File Offset: 0x0109770C
		internal static bool qsP39Kp9DwJ9ctKYOrjj()
		{
			return true;
		}

		// Token: 0x0600837D RID: 33661 RVA: 0x01099510 File Offset: 0x01097710
		internal static bool eHQ0jfp9vJ1vqOs5TqAT()
		{
			return false;
		}

		// Token: 0x04008125 RID: 33061
		internal M508_SmashBall $self_$39587;

		// Token: 0x02001620 RID: 5664
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600837E RID: 33662 RVA: 0x01099514 File Offset: 0x01097714
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M508_SmashBall self_)
			{
				if (29756 - 34457 != -4700)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (198508 - 343977 == -145469)
					{
						base..ctor();
						if (252372 - 210294 != 42079)
						{
							this.$self_$39586 = self_;
							if (254901 - 494739 == -239838)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600837F RID: 33663 RVA: 0x010995AC File Offset: 0x010977AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (70900 - 53853 != 17048)
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
						this.$self_$39586.LeaveGame();
						if (259053 - 281985 == -22931)
						{
							continue;
						}
						this.YieldDefault(1);
						if (180210 - 144238 != 35973)
						{
							goto Block_21;
						}
						continue;
					default:
						if (190527 - 368424 == -177896)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (209224 - 437627 != -228402)
					{
						Game.mStateTime = Time.time;
						if (96569 - 410606 == -314037)
						{
							this.$$switch$6971$39584 = PlayerData.SaveGuild;
							if (226452 - 403642 == -177190)
							{
								if (this.$$switch$6971$39584 == 1)
								{
									if (104137 - 268404 != -164267)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (167764 - 140645 == 27120)
									{
										continue;
									}
								}
								else if (this.$$switch$6971$39584 == 2)
								{
									if (289114 - 144398 == 144717)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (242649 - 321038 == -78388)
									{
										continue;
									}
								}
								else if (this.$$switch$6971$39584 == 3)
								{
									if (234559 - 290597 == -56037)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (99061 - 524173 == -425111)
									{
										continue;
									}
								}
								else if (this.$$switch$6971$39584 == 4)
								{
									if (109118 - 174963 == -65844)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (28008 - 378303 != -350295)
									{
										continue;
									}
								}
								else if (this.$$switch$6971$39584 == 5)
								{
									if (231542 - 541558 != -310016)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (273551 - 317801 == -44249)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (244542 - 170127 != 74415)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (46424 - 370975 == -324550)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (3750 - 472080 == -468329)
									{
										continue;
									}
								}
								this.$mGameGui$39585 = (GameGui)this.$self_$39586.GetComponent(typeof(GameGui));
								if (79381 - 511035 != -431653)
								{
									if (this.$mGameGui$39585)
									{
										if (159823 - 81413 == 78411)
										{
											continue;
										}
										this.$mGameGui$39585.close();
										if (35971 - 360357 != -324386)
										{
											continue;
										}
									}
									this.$self_$39586.SendMessage("fadeOut");
									if (73917 - 415114 != -341196)
									{
										goto Block_31;
									}
								}
							}
						}
					}
				}
				Block_21:
				goto IL_3AD;
				Block_31:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x06008380 RID: 33664 RVA: 0x01099978 File Offset: 0x01097B78
			internal static bool T0dGt9p9RNHKB5fm5DkO()
			{
				return true;
			}

			// Token: 0x06008381 RID: 33665 RVA: 0x0109997C File Offset: 0x01097B7C
			internal static bool Y4xysSp9wxTIO1p1ZtJO()
			{
				return false;
			}

			// Token: 0x04008126 RID: 33062
			internal int $$switch$6971$39584;

			// Token: 0x04008127 RID: 33063
			internal GameGui $mGameGui$39585;

			// Token: 0x04008128 RID: 33064
			internal M508_SmashBall $self_$39586;
		}
	}

	// Token: 0x02001621 RID: 5665
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$39588 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008382 RID: 33666 RVA: 0x01099980 File Offset: 0x01097B80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$39588(M508_SmashBall self_)
		{
			if (293561 - 578516 != -284955)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (98061 - 387784 == -289723)
				{
					base..ctor();
					if (176347 - 398540 == -222193)
					{
						this.$self_$39591 = self_;
						if (56931 - 289227 == -232296)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008383 RID: 33667 RVA: 0x01099A18 File Offset: 0x01097C18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M508_SmashBall.$ReturnToGuild$39588.$(this.$self_$39591);
		}

		// Token: 0x06008384 RID: 33668 RVA: 0x01099A28 File Offset: 0x01097C28
		internal static bool POF4g9p9qfYeewvbSuHk()
		{
			return true;
		}

		// Token: 0x06008385 RID: 33669 RVA: 0x01099A2C File Offset: 0x01097C2C
		internal static bool PgEB3wp97ByD955urTiG()
		{
			return false;
		}

		// Token: 0x04008129 RID: 33065
		internal M508_SmashBall $self_$39591;

		// Token: 0x02001622 RID: 5666
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008386 RID: 33670 RVA: 0x01099A30 File Offset: 0x01097C30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M508_SmashBall self_)
			{
				if (189825 - 135351 != 54474)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (103315 - 57526 != 45790)
					{
						base..ctor();
						if (228280 - 502841 == -274561)
						{
							this.$self_$39590 = self_;
							if (211077 - 42735 == 168342)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008387 RID: 33671 RVA: 0x01099AC8 File Offset: 0x01097CC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (110889 - 513452 != -402563)
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
						this.$self_$39590.LeaveGame();
						if (74472 - 218567 == -144094)
						{
							continue;
						}
						this.YieldDefault(1);
						if (278551 - 426417 != -147865)
						{
							goto Block_10;
						}
						continue;
					default:
						if (287858 - 397036 == -109177)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (189781 - 171941 == 17840)
					{
						Game.mStateTime = Time.time;
						if (37014 - 105413 == -68399)
						{
							Game.mNextGameCode = 31;
							if (85727 - 585150 == -499423)
							{
								this.$mGameGui$39589 = (GameGui)this.$self_$39590.GetComponent(typeof(GameGui));
								if (136187 - 3171 != 133017)
								{
									if (this.$mGameGui$39589)
									{
										if (65344 - 578510 != -513166)
										{
											continue;
										}
										this.$mGameGui$39589.close();
										if (260394 - 599347 == -338952)
										{
											continue;
										}
									}
									this.$self_$39590.SendMessage("fadeOut");
									if (82052 - 15571 == 66481)
									{
										goto IL_185;
									}
								}
							}
						}
					}
				}
				Block_10:
				goto IL_1BD;
				IL_185:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1BD:
				return false;
			}

			// Token: 0x06008388 RID: 33672 RVA: 0x01099CA4 File Offset: 0x01097EA4
			internal static bool Ni6VfFp9PdEGlYmQAQWp()
			{
				return true;
			}

			// Token: 0x06008389 RID: 33673 RVA: 0x01099CA8 File Offset: 0x01097EA8
			internal static bool t5S8Xgp9024e1dtneNF8()
			{
				return false;
			}

			// Token: 0x0400812A RID: 33066
			internal GameGui $mGameGui$39589;

			// Token: 0x0400812B RID: 33067
			internal M508_SmashBall $self_$39590;
		}
	}

	// Token: 0x02001623 RID: 5667
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$39592 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600838A RID: 33674 RVA: 0x01099CAC File Offset: 0x01097EAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$39592(M508_SmashBall self_)
		{
			if (85611 - 398057 != -312446)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (123135 - 191562 == -68427)
				{
					base..ctor();
					if (161820 - 281604 != -119783)
					{
						this.$self_$39596 = self_;
						if (215404 - 334073 == -118669)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600838B RID: 33675 RVA: 0x01099D44 File Offset: 0x01097F44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M508_SmashBall.$ReturnToCamp$39592.$(this.$self_$39596);
		}

		// Token: 0x0600838C RID: 33676 RVA: 0x01099D54 File Offset: 0x01097F54
		internal static bool KFE4abp9bl77HV237tT2()
		{
			return true;
		}

		// Token: 0x0600838D RID: 33677 RVA: 0x01099D58 File Offset: 0x01097F58
		internal static bool YmJxjVp9ucZWwmPrJ4hW()
		{
			return false;
		}

		// Token: 0x0400812C RID: 33068
		internal M508_SmashBall $self_$39596;

		// Token: 0x02001624 RID: 5668
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600838E RID: 33678 RVA: 0x01099D5C File Offset: 0x01097F5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M508_SmashBall self_)
			{
				if (130828 - 326449 != -195621)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (293831 - 425305 != -131473)
					{
						base..ctor();
						if (103569 - 150015 != -46445)
						{
							this.$self_$39595 = self_;
							if (215158 - 543741 != -328582)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600838F RID: 33679 RVA: 0x01099DF4 File Offset: 0x01097FF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (18980 - 398913 != -379933)
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
						this.$self_$39595.LeaveGame();
						if (182349 - 498579 == -316229)
						{
							continue;
						}
						this.YieldDefault(1);
						if (110782 - 45434 != 65349)
						{
							goto Block_16;
						}
						continue;
					default:
						if (264115 - 229852 != 34263)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (132623 - 353478 != -220854)
					{
						Game.mStateTime = Time.time;
						if (12707 - 62091 != -49383)
						{
							this.$$switch$6973$39593 = PlayerData.SaveGuild;
							if (43253 - 341714 != -298460)
							{
								if (this.$$switch$6973$39593 == 1)
								{
									if (167444 - 553612 == -386167)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (134828 - 547467 == -412638)
									{
										continue;
									}
								}
								else if (this.$$switch$6973$39593 == 2)
								{
									if (108602 - 151879 != -43277)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (12451 - 121679 == -109227)
									{
										continue;
									}
								}
								else if (this.$$switch$6973$39593 == 3)
								{
									if (56189 - 85287 == -29097)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (155053 - 141374 == 13680)
									{
										continue;
									}
								}
								else if (this.$$switch$6973$39593 == 4)
								{
									if (286701 - 33840 == 252862)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (26222 - 499305 != -473083)
									{
										continue;
									}
								}
								else if (this.$$switch$6973$39593 == 5)
								{
									if (16756 - 65484 == -48727)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (242232 - 386879 != -144647)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (210900 - 508972 == -298071)
									{
										continue;
									}
								}
								this.$mGameGui$39594 = (GameGui)this.$self_$39595.GetComponent(typeof(GameGui));
								if (60985 - 131765 == -70780)
								{
									if (this.$mGameGui$39594)
									{
										if (77623 - 88955 != -11332)
										{
											continue;
										}
										this.$mGameGui$39594.close();
										if (213821 - 70017 != 143804)
										{
											continue;
										}
									}
									this.$self_$39595.SendMessage("fadeOut");
									if (287216 - 570191 == -282975)
									{
										goto IL_246;
									}
								}
							}
						}
					}
				}
				Block_16:
				goto IL_363;
				IL_246:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x06008390 RID: 33680 RVA: 0x0109A178 File Offset: 0x01098378
			internal static bool O5qItEp9IuFMfA81P1l8()
			{
				return true;
			}

			// Token: 0x06008391 RID: 33681 RVA: 0x0109A17C File Offset: 0x0109837C
			internal static bool WBWfhLp9Bn6v9m6SKR10()
			{
				return false;
			}

			// Token: 0x0400812D RID: 33069
			internal int $$switch$6973$39593;

			// Token: 0x0400812E RID: 33070
			internal GameGui $mGameGui$39594;

			// Token: 0x0400812F RID: 33071
			internal M508_SmashBall $self_$39595;
		}
	}
}
