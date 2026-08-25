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

// Token: 0x02001F7C RID: 8060
[Serializable]
public class M981_FireArena : MonoBehaviour
{
	// Token: 0x0600BC35 RID: 48181 RVA: 0x013F9E3C File Offset: 0x013F803C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M981_FireArena()
	{
		if (134736 - 50550 != 84187)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (152500 - 141018 == 11482)
			{
				base..ctor();
				if (200873 - 140296 == 60577)
				{
					this.M3SnpUC19o5 = new int[15];
					if (154970 - 233285 != -78314)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BC36 RID: 48182 RVA: 0x013F9EDC File Offset: 0x013F80DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (112634 - 395145 != -282510)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (49010 - 382529 == -333519)
			{
				Game.mGameType = 7;
				if (267480 - 209380 == 58100)
				{
					if (Chat.Initialized)
					{
						if (67607 - 82333 == -14725)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (104660 - 547437 != -442777)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (108197 - 284627 != -176430)
						{
							continue;
						}
					}
					this.LSxnp4x0pXp = (Texture)Resources.Load("GameGui/Title/battle", typeof(Texture));
					if (112942 - 370152 != -257209)
					{
						this.mU9npspCvXd = (Texture)Resources.Load("GameGui/Title/count1", typeof(Texture));
						if (248404 - 426540 != -178135)
						{
							this.cZZnpHp1b1a = (Texture)Resources.Load("GameGui/Title/count2", typeof(Texture));
							if (278771 - 582305 != -303533)
							{
								this.rZmnp7e8GvT = (Texture)Resources.Load("GameGui/Title/count3", typeof(Texture));
								if (152222 - 285679 == -133457)
								{
									this.yexnpZiqlKd = (AudioClip)Resources.Load("Sound/GUI/missionBattle", typeof(AudioClip));
									if (191807 - 33675 != 158133)
									{
										this.Jl4npC4aCc2 = (AudioClip)Resources.Load("Sound/GUI/missionCount", typeof(AudioClip));
										if (170816 - 198593 != -27776)
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

	// Token: 0x0600BC37 RID: 48183 RVA: 0x013FA118 File Offset: 0x013F8318
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (224104 - 304988 != -80884)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (38349 - 293289 != -254939)
				{
					if (Game.mNextGameCode != 981)
					{
						break;
					}
					if (124304 - 317269 == -192965)
					{
						Game.nextGame();
						if (9550 - 580886 == -571336)
						{
							Game.mGameCode = 981;
							if (122855 - 195824 == -72969)
							{
								Game.mGameTime = Time.time;
								if (46351 - 597762 != -551410)
								{
									Game.mGameScore = 0;
									if (1960 - 175504 == -173544)
									{
										Game.mGameMana = 0;
										if (204799 - 479995 == -275196)
										{
											Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
											if (252623 - 225802 == 26821)
											{
												Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
												if (296332 - 433397 == -137065)
												{
													Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
													if (291438 - 568863 != -277424)
													{
														Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
														if (299644 - 321032 != -21387)
														{
															Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
															if (140058 - 60190 == 79868)
															{
																this.k90npgySjJI = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																if (224156 - 548208 != -324051)
																{
																	if (this.k90npgySjJI)
																	{
																		if (90 - 303008 != -302918)
																		{
																			continue;
																		}
																		this.k90npgySjJI.enabled = false;
																		if (110565 - 453375 == -342809)
																		{
																			continue;
																		}
																	}
																	this.EYPnpdjPNdj = PhotonClient.Connection;
																	if (192659 - 113025 != 79635)
																	{
																		PhotonClient.ActorNrList.Clear();
																		if (299549 - 231537 != 68013)
																		{
																			this.InitGame();
																			if (32445 - 21069 == 11376)
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
				if (174599 - 563795 != -389195)
				{
					Game.mGameType = 99;
					if (200219 - 488433 != -288213)
					{
						Game.mGameState = eGameState.AllHold;
						if (95495 - 112049 != -16553)
						{
							this.k90npgySjJI = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
							if (248395 - 247779 == 616)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BC38 RID: 48184 RVA: 0x013FA4A4 File Offset: 0x013F86A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (117790 - 590327 != -472537)
		{
		}
		for (;;)
		{
			IL_150:
			if (this.EYPnpdjPNdj == null)
			{
				if (243055 - 426957 != -183901)
				{
					break;
				}
			}
			else
			{
				int num = this.a2snpMhw2aj;
				if (251754 - 210429 == 41325)
				{
					if (num == 0)
					{
						if (270845 - 349434 == -78589)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (214537 - 395469 == -180932)
							{
								break;
							}
						}
					}
					else if (num == 1)
					{
						if (198084 - 329555 == -131471)
						{
							this.transform.RotateAround(new Vector3((float)0, (float)54, (float)0), Vector3.up, (float)12 * Time.deltaTime);
							if (271191 - 37030 == 234161)
							{
								break;
							}
						}
					}
					else if (num == 2)
					{
						if (65967 - 324182 != -258214)
						{
							break;
						}
					}
					else if (num == 3)
					{
						if (117375 - 23496 == 93879)
						{
							if (Game.mGameState == eGameState.Hold)
							{
								if (258483 - 564519 == -306035)
								{
									continue;
								}
								if (Time.time - this.GtCnpfosCIs >= (float)6)
								{
									if (218557 - 570985 != -352428)
									{
										continue;
									}
									Game.mGameState = eGameState.Normal;
									if (25345 - 401075 != -375730)
									{
										continue;
									}
									Game.mGameTime = Time.time;
									if (224022 - 408855 != -184833)
									{
										continue;
									}
								}
							}
							else if (Game.mGameState == eGameState.Normal)
							{
								if (287599 - 59621 == 227979)
								{
									continue;
								}
								if (!this.A77npNtNpmE)
								{
									if (89807 - 559554 == -469746)
									{
										continue;
									}
									if (Time.time >= this.GtCnpfosCIs + (float)12)
									{
										if (295165 - 375599 == -80433)
										{
											continue;
										}
										Game.mGameState = eGameState.AllHold;
										if (103248 - 216826 != -113578)
										{
											continue;
										}
										this.a2snpMhw2aj = 5;
										if (54457 - 411583 != -357126)
										{
											continue;
										}
										this.GtCnpfosCIs = Time.time;
										if (209028 - 222767 != -13739)
										{
											continue;
										}
										Game.sendMissionEvent(9813, this.M3SnpUC19o5[this.UCMnpwUdA9f * 2 - 1]);
										if (27050 - 216279 != -189228)
										{
											goto IL_B3A;
										}
										continue;
									}
								}
								if (!this.Pw3npEG0Ymm)
								{
									if (4110 - 444259 == -440148)
									{
										continue;
									}
									if (Time.time >= this.GtCnpfosCIs + (float)12)
									{
										if (42987 - 129124 != -86137)
										{
											continue;
										}
										Game.mGameState = eGameState.AllHold;
										if (275771 - 440258 != -164487)
										{
											continue;
										}
										this.a2snpMhw2aj = 5;
										if (214731 - 466734 == -252002)
										{
											continue;
										}
										this.GtCnpfosCIs = Time.time;
										if (211296 - 537151 != -325855)
										{
											continue;
										}
										Game.sendMissionEvent(9813, this.M3SnpUC19o5[this.UCMnpwUdA9f * 2 - 2]);
										if (83921 - 301699 != -217777)
										{
											goto IL_B3A;
										}
										continue;
									}
								}
								if (Time.time >= this.GtCnpfosCIs + (float)120)
								{
									if (45927 - 315237 == -269309)
									{
										continue;
									}
									Game.mGameState = eGameState.AllHold;
									if (136336 - 497990 != -361654)
									{
										continue;
									}
									this.a2snpMhw2aj = 5;
									if (196474 - 250248 == -53773)
									{
										continue;
									}
									this.GtCnpfosCIs = Time.time;
									if (84009 - 383222 == -299212)
									{
										continue;
									}
									float num2 = 1f;
									if (259299 - 64512 != 194787)
									{
										continue;
									}
									CharacterControl characterControl = null;
									if (113982 - 365302 != -251320)
									{
										continue;
									}
									GameObject[] array = GameObject.FindGameObjectsWithTag("Player");
									if (134601 - 28986 != 105615)
									{
										continue;
									}
									int i = 0;
									if (140039 - 534527 == -394487)
									{
										continue;
									}
									GameObject[] array2 = array;
									if (140832 - 33037 == 107796)
									{
										continue;
									}
									int length = array2.Length;
									if (10856 - 63652 == -52795)
									{
										continue;
									}
									while (i < length)
									{
										CharacterControl characterControl2 = (CharacterControl)array2[i].GetComponent(typeof(CharacterControl));
										if (82842 - 195897 != -113055)
										{
											goto IL_150;
										}
										if (characterControl2)
										{
											if (254028 - 51465 == 202564)
											{
												goto IL_150;
											}
											if (num2 >= 1f * (float)characterControl2.hp / (float)characterControl2.mhp)
											{
												if (185688 - 257240 != -71552)
												{
													goto IL_150;
												}
												num2 = 1f * (float)characterControl2.hp / (float)characterControl2.mhp;
												if (132511 - 180626 != -48115)
												{
													goto IL_150;
												}
												characterControl = characterControl2;
												if (46858 - 474559 == -427700)
												{
													goto IL_150;
												}
											}
										}
										i++;
										if (220876 - 283872 == -62995)
										{
											goto IL_150;
										}
									}
									if (192627 - 452190 == -259562)
									{
										continue;
									}
									if (characterControl)
									{
										if (77475 - 543522 == -466046)
										{
											continue;
										}
										if (characterControl.isMine)
										{
											if (64360 - 339288 == -274927)
											{
												continue;
											}
											characterControl.RPC_AddStatus("death", 1, 1, 1, characterControl.ActorNr);
											if (134190 - 63277 == 70914)
											{
												continue;
											}
										}
									}
								}
								else if (Time.time > this.GjPnpax6Ibm)
								{
									if (234941 - 395740 != -160799)
									{
										continue;
									}
									Game.mGameMana++;
									if (141588 - 260381 == -118792)
									{
										continue;
									}
									this.GjPnpax6Ibm = Time.time + (float)12;
									if (106633 - 415899 == -309265)
									{
										continue;
									}
								}
							}
							IL_B3A:
							if (Game.music != 0)
							{
								if (197306 - 4333 == 192974)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (120269 - 144294 == -24024)
									{
										continue;
									}
									this.audio.Play();
									if (215316 - 510213 != -294897)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (45770 - 275790 != -230019)
							{
								break;
							}
						}
					}
					else if (num == 4)
					{
						if (292659 - 400960 != -108300)
						{
							if (!this.A77npNtNpmE)
							{
								if (223422 - 386291 != -162869)
								{
									continue;
								}
								if (!this.Pw3npEG0Ymm)
								{
									if (253786 - 218659 != 35127)
									{
										continue;
									}
									if (Time.time >= this.GtCnpfosCIs + (float)15)
									{
										if (244050 - 327530 == -83479)
										{
											continue;
										}
										Game.mGameState = eGameState.AllHold;
										if (296224 - 75448 != 220776)
										{
											continue;
										}
										this.a2snpMhw2aj = 5;
										if (140922 - 445531 == -304608)
										{
											continue;
										}
										this.GtCnpfosCIs = Time.time;
										if (175275 - 548471 == -373195)
										{
											continue;
										}
										Game.sendMissionEvent(9813, 9);
										if (109206 - 155139 != -45933)
										{
											continue;
										}
										break;
									}
								}
							}
							if (Chat.ChatActive)
							{
								break;
							}
							if (164362 - 194131 == -29769)
							{
								if (this.k90npgySjJI)
								{
									if (284393 - 267444 != 16949)
									{
										continue;
									}
									if (this.k90npgySjJI.enabled)
									{
										if (285613 - 274529 != 11084)
										{
											continue;
										}
										if (Input.GetMouseButton(1))
										{
											if (112514 - 212047 != -99533)
											{
												continue;
											}
											this.k90npgySjJI.rotation = Mathf.Clamp(1.4f * Input.GetAxis("Mouse X"), (float)-15, (float)15);
											if (179317 - 532804 == -353486)
											{
												continue;
											}
										}
									}
								}
								if (Input.GetKeyDown(KeyCode.Return))
								{
									if (127138 - 502549 == -375410)
									{
										continue;
									}
									if (Chat.ChatTimeOut <= Time.time)
									{
										if (249552 - 205930 != 43622)
										{
											continue;
										}
										Chat.ChatActive = true;
										if (291629 - 413218 != -121589)
										{
											continue;
										}
										Chat.ChatTimeOut = Time.time + 0.1f;
										if (188903 - 305149 == -116245)
										{
											continue;
										}
									}
								}
								this.k90npgySjJI.zoom = Mathf.Clamp(Input.GetAxis("Mouse ScrollWheel"), -0.3f, 0.3f);
								if (145489 - 184696 != -39206)
								{
									break;
								}
							}
						}
					}
					else if (num == 5)
					{
						if (192909 - 555482 != -362572)
						{
							break;
						}
					}
					else
					{
						if (num != 6)
						{
							break;
						}
						if (291723 - 418852 == -127129)
						{
							this.transform.RotateAround(new Vector3((float)0, (float)54, (float)0), Vector3.up, (float)12 * Time.deltaTime);
							if (206359 - 471255 != -264895)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BC39 RID: 48185 RVA: 0x013FB06C File Offset: 0x013F926C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (277677 - 339675 != -61998)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (279455 - 372525 != -93069)
			{
				float num = (float)(1024 * Screen.width / Screen.height);
				if (118409 - 176863 != -58453)
				{
					GUI.depth = 1;
					if (187408 - 383902 != -196493)
					{
						int num2 = this.a2snpMhw2aj;
						if (240734 - 28359 != 212376)
						{
							if (num2 == 1)
							{
								if (220443 - 57331 == 163112)
								{
									if (this.fireArena_welcome)
									{
										if (169582 - 472122 != -302540)
										{
											continue;
										}
										if (Time.time - this.GtCnpfosCIs < (float)2)
										{
											if (80809 - 288919 == -208109)
											{
												continue;
											}
											float num3 = Mathf.SmoothStep(0.8f, 1f, Time.time - this.GtCnpfosCIs);
											if (81144 - 397908 == -316763)
											{
												continue;
											}
											float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - this.GtCnpfosCIs, (float)1));
											if (128987 - 509609 != -380622)
											{
												continue;
											}
											Color color = GUI.color;
											if (52402 - 479436 == -427033)
											{
												continue;
											}
											color.a = a;
											if (43160 - 419012 == -375851 || 196965 - 97252 == 99714)
											{
												continue;
											}
											Color color2 = GUI.color = color;
											if (255370 - 553320 != -297950)
											{
												continue;
											}
											if (147310 - 562675 == -415364)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * (num - (float)this.fireArena_welcome.width * num3), (float)450 - 0.5f * (float)this.fireArena_welcome.height * num3, (float)this.fireArena_welcome.width * num3, (float)this.fireArena_welcome.height * num3), this.fireArena_welcome);
											if (89552 - 347380 != -257828)
											{
												continue;
											}
											float a2 = 1f;
											if (227233 - 500100 != -272867)
											{
												continue;
											}
											Color color3 = GUI.color;
											if (198842 - 204056 != -5214)
											{
												continue;
											}
											color3.a = a2;
											if (269082 - 82763 != 186319)
											{
												continue;
											}
											if (118098 - 265718 != -147620)
											{
												continue;
											}
											Color color4 = GUI.color = color3;
											if (237637 - 352590 != -114952 && 151366 - 34331 != 117036)
											{
												break;
											}
											continue;
										}
									}
									if (!this.fireArena_ready)
									{
										break;
									}
									if (284189 - 75513 != 208677)
									{
										if (Time.time - this.GtCnpfosCIs >= (float)4)
										{
											break;
										}
										if (22125 - 564762 != -542636)
										{
											float num4 = Mathf.SmoothStep(1f, 0.8f, Time.time - this.GtCnpfosCIs - (float)2);
											if (240801 - 501531 != -260729)
											{
												float a3 = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - this.GtCnpfosCIs - (float)2, (float)1));
												if (248129 - 450469 == -202340)
												{
													Color color5 = GUI.color;
													if (233579 - 565085 == -331506)
													{
														color5.a = a3;
														if (215189 - 525794 == -310605)
														{
															if (31348 - 401847 == -370499)
															{
																GUI.color = color5;
																if (148953 - 241288 == -92335)
																{
																	if (107517 - 597955 != -490437)
																	{
																		GUI.DrawTexture(new Rect(0.5f * (num - (float)this.fireArena_ready.width * num4), (float)450 - 0.5f * (float)this.fireArena_ready.height * num4, (float)this.fireArena_ready.width * num4, (float)this.fireArena_ready.height * num4), this.fireArena_ready);
																		if (49172 - 334253 != -285080)
																		{
																			float a4 = 1f;
																			if (80185 - 455716 != -375530)
																			{
																				Color color6 = GUI.color;
																				if (144784 - 214426 == -69642)
																				{
																					float num5 = color6.a = a4;
																					if (175200 - 326547 != -151346 && 124737 - 578305 != -453567)
																					{
																						Color color7 = GUI.color = color6;
																						if (26196 - 574693 == -548497)
																						{
																							if (280255 - 111493 == 168762)
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
							else if (num2 == 2)
							{
								if (126543 - 413097 != -286553)
								{
									this.RenderFireMatch();
									if (187504 - 47306 != 140199)
									{
										break;
									}
								}
							}
							else if (num2 == 3)
							{
								if (241927 - 240777 == 1150)
								{
									this.RenderCountDown(num);
									if (94494 - 39842 != 54653)
									{
										break;
									}
								}
							}
							else
							{
								if (num2 != 4)
								{
									break;
								}
								if (179672 - 520145 == -340473)
								{
									this.RenderCountDown(num);
									if (266769 - 575319 != -308549)
									{
										this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
										if (297829 - 132806 != 165024)
										{
											if (this.yIsnpytmmit)
											{
												if (163108 - 212865 == -49756)
												{
													continue;
												}
												this.RenderFireMatch();
												if (50004 - 518703 == -468698)
												{
													continue;
												}
											}
											this.RenderFireBar();
											if (89177 - 136474 != -47296)
											{
												this.RenderFireTargetBar1();
												if (108113 - 509862 != -401748)
												{
													this.RenderFireTargetBar2();
													if (74542 - 261897 != -187354)
													{
														this.RenderFireChat();
														if (57018 - 490171 == -433153)
														{
															this.RenderGameMessege();
															if (90436 - 156351 != -65914)
															{
																if (Chat.ChatActive)
																{
																	break;
																}
																if (97451 - 293277 == -195826)
																{
																	GUI.FocusControl("FireChatField");
																	if (65892 - 111542 == -45650)
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

	// Token: 0x0600BC3A RID: 48186 RVA: 0x013FB924 File Offset: 0x013F9B24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderCountDown(float screenWidth)
	{
		if (78855 - 580932 != -502077)
		{
		}
		for (;;)
		{
			float num = (float)1;
			if (206382 - 383303 == -176921)
			{
				if (Time.time - this.GtCnpfosCIs < (float)1)
				{
					if (287549 - 382323 == -94774)
					{
						break;
					}
				}
				else
				{
					if (Time.time - this.GtCnpfosCIs < (float)2)
					{
						if (15274 - 589720 == -574445)
						{
							continue;
						}
						num = Mathf.SmoothStep((float)1, (float)2, Time.time - this.GtCnpfosCIs - (float)1);
						if (158874 - 480256 != -321382)
						{
							continue;
						}
						float a = Mathf.SmoothStep((float)0, (float)1, Time.time - this.GtCnpfosCIs - (float)1);
						if (213175 - 390045 != -176870)
						{
							continue;
						}
						Color color = GUI.color;
						if (257426 - 98245 == 159182)
						{
							continue;
						}
						float num2 = color.a = a;
						if (7572 - 301892 != -294320)
						{
							continue;
						}
						if (276437 - 220666 != 55771)
						{
							continue;
						}
						GUI.color = color;
						if (186637 - 191723 != -5086)
						{
							continue;
						}
						if (95453 - 494855 == -399401)
						{
							continue;
						}
						if (this.rZmnp7e8GvT)
						{
							if (71497 - 479118 != -407621)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * screenWidth - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.rZmnp7e8GvT);
							if (10730 - 81368 == -70637)
							{
								continue;
							}
						}
					}
					else if (Time.time - this.GtCnpfosCIs < (float)3)
					{
						if (295426 - 426419 != -130993)
						{
							continue;
						}
						num = Mathf.SmoothStep((float)1, (float)2, Time.time - this.GtCnpfosCIs - (float)2);
						if (236706 - 568316 == -331609)
						{
							continue;
						}
						float a2 = Mathf.SmoothStep((float)0, (float)1, Time.time - this.GtCnpfosCIs - (float)2);
						if (171702 - 412979 != -241277)
						{
							continue;
						}
						Color color2 = GUI.color;
						if (133661 - 470507 != -336846)
						{
							continue;
						}
						float num3 = color2.a = a2;
						if (79329 - 165995 != -86666)
						{
							continue;
						}
						if (87563 - 314208 == -226644)
						{
							continue;
						}
						GUI.color = color2;
						if (172614 - 69176 == 103439)
						{
							continue;
						}
						if (1353 - 570197 != -568844)
						{
							continue;
						}
						if (this.cZZnpHp1b1a)
						{
							if (286024 - 473220 != -187196)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * screenWidth - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.cZZnpHp1b1a);
							if (147128 - 39334 == 107795)
							{
								continue;
							}
						}
					}
					else if (Time.time - this.GtCnpfosCIs < (float)4)
					{
						if (220888 - 384760 != -163872)
						{
							continue;
						}
						num = Mathf.SmoothStep((float)1, (float)2, Time.time - this.GtCnpfosCIs - (float)3);
						if (276034 - 435034 != -159000)
						{
							continue;
						}
						float a3 = Mathf.SmoothStep((float)0, (float)1, Time.time - this.GtCnpfosCIs - (float)3);
						if (40931 - 406222 == -365290)
						{
							continue;
						}
						Color color3 = GUI.color;
						if (93627 - 3858 != 89769)
						{
							continue;
						}
						float num4 = color3.a = a3;
						if (161790 - 555936 == -394145)
						{
							continue;
						}
						if (116147 - 353085 != -236938)
						{
							continue;
						}
						GUI.color = color3;
						if (237569 - 181919 != 55650)
						{
							continue;
						}
						if (7134 - 7087 != 47)
						{
							continue;
						}
						if (this.mU9npspCvXd)
						{
							if (274581 - 208890 != 65691)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * screenWidth - 34f * num, (float)350 - 43.5f * num, (float)68 * num, (float)87 * num), this.mU9npspCvXd);
							if (132782 - 528850 == -396067)
							{
								continue;
							}
						}
					}
					else if (Time.time - this.GtCnpfosCIs < (float)5)
					{
						if (95383 - 204847 != -109464)
						{
							continue;
						}
						num = Mathf.SmoothStep((float)1, 1.2f, Time.time - this.GtCnpfosCIs - (float)4);
						if (5220 - 270505 != -265285)
						{
							continue;
						}
						if (Time.time - Game.mStateTime < 0.2f)
						{
							if (83458 - 528091 == -444632)
							{
								continue;
							}
							float a4 = Mathf.SmoothStep((float)0, (float)1, (float)5 * (Time.time - Game.mStateTime - (float)5));
							if (83545 - 448925 != -365380)
							{
								continue;
							}
							Color color4 = GUI.color;
							if (57430 - 77064 != -19634)
							{
								continue;
							}
							color4.a = a4;
							if (125844 - 199460 != -73616)
							{
								continue;
							}
							if (59642 - 153674 == -94031)
							{
								continue;
							}
							Color color5 = GUI.color = color4;
							if (4983 - 74823 != -69840)
							{
								continue;
							}
							if (287150 - 576007 != -288857)
							{
								continue;
							}
						}
						else
						{
							float a5 = Mathf.SmoothStep((float)1, (float)0, 1.25f * (Time.time - Game.mStateTime - 5.2f));
							if (30584 - 395157 != -364573)
							{
								continue;
							}
							Color color6 = GUI.color;
							if (124022 - 431264 == -307241)
							{
								continue;
							}
							float num5 = color6.a = a5;
							if (234507 - 20788 != 213719)
							{
								continue;
							}
							if (252348 - 584041 != -331693)
							{
								continue;
							}
							GUI.color = color6;
							if (185231 - 588160 == -402928)
							{
								continue;
							}
							if (246937 - 485442 != -238505)
							{
								continue;
							}
						}
						if (this.LSxnp4x0pXp)
						{
							if (52888 - 140964 != -88076)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * screenWidth - (float)350 * num, (float)450 - (float)78 * num, (float)700 * num, (float)157 * num), this.LSxnp4x0pXp);
							if (90220 - 254291 == -164070)
							{
								continue;
							}
						}
					}
					float a6 = 1f;
					if (87252 - 560382 != -473129)
					{
						Color color7 = GUI.color;
						if (91939 - 376154 != -284214)
						{
							float num6 = color7.a = a6;
							if (111725 - 423658 == -311933)
							{
								if (81075 - 403560 == -322485)
								{
									GUI.color = color7;
									if (64315 - 25443 != 38873)
									{
										if (113265 - 207136 == -93871)
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

	// Token: 0x0600BC3B RID: 48187 RVA: 0x013FC284 File Offset: 0x013FA484
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameEvent(Hashtable data)
	{
		return new M981_FireArena.$onGameEvent$47057(data, this).GetEnumerator();
	}

	// Token: 0x0600BC3C RID: 48188 RVA: 0x013FC294 File Offset: 0x013FA494
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndEvent()
	{
		return new M981_FireArena.$EndEvent$47070(this).GetEnumerator();
	}

	// Token: 0x0600BC3D RID: 48189 RVA: 0x013FC2A4 File Offset: 0x013FA4A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (2666 - 480355 != -477688)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (98281 - 234931 == -136650)
			{
				Time.timeScale = 1f;
				if (201687 - 36087 != 165601)
				{
					this.InitFireMatch();
					if (227279 - 427202 == -199923)
					{
						this.InitFireBar();
						if (252416 - 317776 == -65360)
						{
							this.InitFireTargetBar();
							if (138062 - 325134 != -187071)
							{
								this.InitFireChat();
								if (297886 - 24957 == 272929)
								{
									this.InitGameMessage();
									if (53178 - 155882 != -102703)
									{
										Hashtable customOpParameters = new Hashtable();
										if (257501 - 596305 != -338803)
										{
											this.EYPnpdjPNdj.OpCustom(52, customOpParameters, true);
											if (187647 - 364471 == -176824)
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

	// Token: 0x0600BC3E RID: 48190 RVA: 0x013FC410 File Offset: 0x013FA610
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (41841 - 51071 != -9229)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (72427 - 443266 != -370838)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (184921 - 485088 == -300167)
				{
					Game.mGameState = eGameState.Setup;
					if (26021 - 561637 != -535615)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BC3F RID: 48191 RVA: 0x013FC4B4 File Offset: 0x013FA6B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (141146 - 529344 != -388198)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (5359 - 569100 != -563740)
			{
				if (num == PlayerData.UID)
				{
					if (47200 - 436618 == -389418)
					{
						this.SetupActors();
						if (9741 - 59855 == -50114)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (92336 - 132074 == -39738)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BC40 RID: 48192 RVA: 0x013FC584 File Offset: 0x013FA784
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (160522 - 61067 != 99455)
		{
		}
		for (;;)
		{
			IL_1AC:
			Debug.Log("Creating Actors");
			if (17085 - 195354 != -178268)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (42092 - 335266 != -293173)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (46924 - 190297 != -143372)
						{
							int i = 0;
							if (57446 - 184735 == -127289)
							{
								CharacterControl[] array2 = array;
								if (254240 - 456363 == -202123)
								{
									int length = array2.Length;
									if (267342 - 377760 != -110417)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (42552 - 485100 != -442548)
												{
													goto IL_1AC;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (190695 - 590375 == -399679)
												{
													goto IL_1AC;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (120033 - 24112 != 95921)
												{
													goto IL_1AC;
												}
												this.zPgnpPLfFHV++;
												if (111649 - 200723 != -89074)
												{
													goto IL_1AC;
												}
											}
											i++;
											if (158957 - 546155 == -387197)
											{
												goto IL_1AC;
											}
										}
										if (31814 - 439907 == -408093)
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
						if (217133 - 344150 != -127016)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BC41 RID: 48193 RVA: 0x013FC7C0 File Offset: 0x013FA9C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (75320 - 232400 != -157080)
		{
		}
		for (;;)
		{
			IL_3C:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (242853 - 377943 != -135089)
			{
				int i = 0;
				if (230947 - 551254 == -320307)
				{
					CharacterControl[] array2 = array;
					if (125613 - 131028 != -5414)
					{
						int length = array2.Length;
						if (17698 - 525509 != -507810)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (113703 - 446089 != -332386)
								{
									goto IL_3C;
								}
								i++;
								if (58149 - 243438 != -185289)
								{
									goto IL_3C;
								}
							}
							if (197681 - 229396 != -31714)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BC42 RID: 48194 RVA: 0x013FC8F0 File Offset: 0x013FAAF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (236114 - 487638 != -251523)
		{
		}
		while (Game.mGameState < eGameState.Ready)
		{
			if (4535 - 101997 != -97461)
			{
				Debug.Log("Game Ready");
				if (36799 - 548938 == -512139)
				{
					Game.mGameState = eGameState.Ready;
					if (268159 - 481451 == -213292)
					{
						this.RYHnpLCMKR7 = Game.getPlayerSlot(PlayerData.UID);
						if (272365 - 409480 == -137115)
						{
							if (this.RYHnpLCMKR7 <= 0)
							{
								break;
							}
							if (126201 - 511457 != -385255)
							{
								if (186640 - 292156 == -105516)
								{
									if (121524 - 513182 != -391657)
									{
										GameObject gameObject = GameObject.Find("SpawnPoint" + this.RYHnpLCMKR7);
										if (171472 - 262348 == -90876)
										{
											if (!gameObject)
											{
												break;
											}
											if (266759 - 537241 != -270481)
											{
												this.CreatePlayer(CharacterData.current.CID, this.RYHnpLCMKR7, gameObject.transform.position, gameObject.transform.forward);
												if (27827 - 528610 == -500783)
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

	// Token: 0x0600BC43 RID: 48195 RVA: 0x013FCABC File Offset: 0x013FACBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M981_FireArena.$StartGame$47074(this).GetEnumerator();
	}

	// Token: 0x0600BC44 RID: 48196 RVA: 0x013FCACC File Offset: 0x013FACCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600BC45 RID: 48197 RVA: 0x013FCAD0 File Offset: 0x013FACD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator InitNextRound()
	{
		return new M981_FireArena.$InitNextRound$47077(this).GetEnumerator();
	}

	// Token: 0x0600BC46 RID: 48198 RVA: 0x013FCAE0 File Offset: 0x013FACE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetNextRound()
	{
		if (2051 - 339622 != -337570)
		{
		}
		int i;
		for (;;)
		{
			IL_70:
			i = this.UCMnpwUdA9f + 1;
			if (6346 - 12578 == -6232)
			{
				while (i <= 7)
				{
					if (this.M3SnpUC19o5[i * 2 - 2] != 0)
					{
						if (73143 - 247660 != -174517)
						{
							goto IL_70;
						}
						if (this.M3SnpUC19o5[i * 2 - 1] != 0)
						{
							if (290310 - 363348 != -73038)
							{
								goto IL_70;
							}
							Debug.Log("New match found:" + i);
							if (109427 - 266726 != -157299)
							{
								goto IL_70;
							}
							goto IL_13A;
						}
					}
					if (this.M3SnpUC19o5[i * 2 - 2] != 0)
					{
						goto IL_28B;
					}
					if (195073 - 594442 != -399369)
					{
						goto IL_70;
					}
					if (this.M3SnpUC19o5[i * 2 - 1] == 0)
					{
						goto IL_28B;
					}
					if (264098 - 574875 != -310777)
					{
						goto IL_70;
					}
					Debug.Log("Player2 win round" + i + "by default.");
					if (83882 - 185608 == -101725)
					{
						goto IL_70;
					}
					this.M3SnpUC19o5[i + 7] = this.M3SnpUC19o5[i * 2 - 1];
					if (210598 - 204140 != 6458)
					{
						goto IL_70;
					}
					this.M3SnpUC19o5[i * 2 - 1] = 0;
					if (84719 - 177125 != -92406)
					{
						goto IL_70;
					}
					IL_1A4:
					i++;
					if (257737 - 178992 != 78746)
					{
						continue;
					}
					goto IL_70;
					IL_28B:
					if (this.M3SnpUC19o5[i * 2 - 2] == 0)
					{
						goto IL_1A4;
					}
					if (92966 - 219474 != -126508)
					{
						goto IL_70;
					}
					if (this.M3SnpUC19o5[i * 2 - 1] != 0)
					{
						goto IL_1A4;
					}
					if (117960 - 332788 != -214828)
					{
						goto IL_70;
					}
					Debug.Log("Player1 win round" + i + "by default.");
					if (247691 - 564498 != -316807)
					{
						goto IL_70;
					}
					this.M3SnpUC19o5[i + 7] = this.M3SnpUC19o5[i * 2 - 2];
					if (216227 - 329019 != -112792)
					{
						goto IL_70;
					}
					this.M3SnpUC19o5[i * 2 - 2] = 0;
					if (62495 - 339121 != -276626)
					{
						goto IL_70;
					}
					goto IL_1A4;
				}
				if (287291 - 194158 != 93134)
				{
					break;
				}
			}
		}
		return 8;
		IL_13A:
		return i;
	}

	// Token: 0x0600BC47 RID: 48199 RVA: 0x013FCDDC File Offset: 0x013FAFDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitFireMatch()
	{
		if (261548 - 489149 != -227601)
		{
		}
		for (;;)
		{
			this.y7EnpSYMvvn = new string[8];
			if (243052 - 341826 == -98774)
			{
				this.FOInpBlDpw0 = new Texture[8];
				if (111833 - 407005 == -295172)
				{
					this.wainp0EpSjt = new Texture[8];
					if (44584 - 25105 == 19479)
					{
						this.EnnnpDuHdx7 = new GUIStyle();
						if (25699 - 259354 == -233655)
						{
							this.EnnnpDuHdx7.font = (Font)Resources.Load("GameGui/Fonts/GMO48", typeof(Font));
							if (99685 - 115676 == -15991)
							{
								this.EnnnpDuHdx7.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
								if (251788 - 14460 != 237329)
								{
									this.EnnnpDuHdx7.alignment = TextAnchor.MiddleRight;
									if (9219 - 114330 == -105111)
									{
										this.mfGnpjPmo8U = new GUIStyle();
										if (224023 - 168896 != 55128)
										{
											this.mfGnpjPmo8U.font = (Font)Resources.Load("GameGui/Fonts/GMO48", typeof(Font));
											if (272345 - 9282 != 263064)
											{
												this.mfGnpjPmo8U.normal.textColor = new Color(0.15f, 0.1f, (float)0, (float)1);
												if (156452 - 211187 == -54735)
												{
													this.mfGnpjPmo8U.alignment = TextAnchor.MiddleRight;
													if (283930 - 286857 == -2927)
													{
														this.p7inpmSm46g = new GUIStyle();
														if (150218 - 131741 == 18477)
														{
															this.p7inpmSm46g.font = (Font)Resources.Load("GameGui/Fonts/GMO48", typeof(Font));
															if (102327 - 399932 != -297604)
															{
																this.p7inpmSm46g.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
																if (178767 - 156749 != 22019)
																{
																	this.p7inpmSm46g.alignment = TextAnchor.MiddleLeft;
																	if (112866 - 363398 == -250532)
																	{
																		this.KH4npo2xZuD = new GUIStyle();
																		if (229649 - 82979 == 146670)
																		{
																			this.KH4npo2xZuD.font = (Font)Resources.Load("GameGui/Fonts/GMO48", typeof(Font));
																			if (113988 - 70602 == 43386)
																			{
																				this.KH4npo2xZuD.normal.textColor = new Color(0.15f, 0.1f, (float)0, (float)1);
																				if (204910 - 541915 != -337004)
																				{
																					this.KH4npo2xZuD.alignment = TextAnchor.MiddleLeft;
																					if (270359 - 345731 != -75371)
																					{
																						this.TXknpkYj4bj = (AudioClip)Resources.Load("Sound/GUI/shuffle", typeof(AudioClip));
																						if (47904 - 245704 == -197800)
																						{
																							this.wYInpFkUpGH = (AudioClip)Resources.Load("Sound/GUI/toggle", typeof(AudioClip));
																							if (296114 - 492288 == -196174)
																							{
																								this.d8HnpAp3bec = new int[]
																								{
																									44,
																									137,
																									224,
																									311,
																									410,
																									497,
																									590,
																									677,
																									87,
																									266,
																									454,
																									632,
																									177,
																									543,
																									0
																								};
																								if (1418 - 316939 != -315520)
																								{
																									this.cMAnp9kx8a8 = new int[]
																									{
																										365,
																										365,
																										365,
																										365,
																										365,
																										365,
																										365,
																										365,
																										210,
																										210,
																										210,
																										210,
																										98,
																										98,
																										0
																									};
																									if (243873 - 295435 != -51561)
																									{
																										this.SkXnpiRo2u1 = false;
																										if (237522 - 455045 != -217522)
																										{
																											this.wB8np8nMvFp = true;
																											if (295119 - 178983 == 116136)
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

	// Token: 0x0600BC48 RID: 48200 RVA: 0x013FD2AC File Offset: 0x013FB4AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadPlayer(GameObject nPlayer)
	{
		if (146456 - 103904 != 42553)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nPlayer.GetComponent(typeof(CharacterControl));
			if (146588 - 483400 == -336812)
			{
				if (characterControl)
				{
					if (221422 - 273030 != -51607)
					{
						int playerSlot = Game.getPlayerSlot(characterControl.ownerID);
						if (68330 - 47064 == 21266)
						{
							if (playerSlot >= 1)
							{
								if (115735 - 108389 != 7346)
								{
									continue;
								}
								if (playerSlot <= 8)
								{
									if (67937 - 181795 != -113858)
									{
										continue;
									}
									int[] array = new int[]
									{
										1,
										5,
										3,
										7,
										2,
										6,
										4,
										8
									};
									if (167157 - 298098 != -130941)
									{
										continue;
									}
									this.M3SnpUC19o5[array[playerSlot - 1] - 1] = playerSlot;
									if (267117 - 179818 != 87299)
									{
										continue;
									}
									this.y7EnpSYMvvn[playerSlot - 1] = characterControl.Name;
									if (281279 - 355609 != -74330)
									{
										continue;
									}
									this.FOInpBlDpw0[playerSlot - 1] = (Texture)Resources.Load("GameGui/Icons/Heroes/" + characterControl.Type + Mathf.FloorToInt((float)(characterControl.Skin / 100)), typeof(Texture));
									if (234577 - 25660 == 208918)
									{
										continue;
									}
									this.wainp0EpSjt[playerSlot - 1] = (Texture)Resources.Load("GameGui/Story/Characters/" + characterControl.Type, typeof(Texture));
									if (199188 - 1965 != 197224)
									{
										break;
									}
									continue;
								}
							}
							Debug.LogError("Unknown PlayerSlot:" + playerSlot);
							if (8030 - 238959 == -230929)
							{
								break;
							}
						}
					}
				}
				else
				{
					Debug.LogError("Warning new player with no CharacterControl");
					if (60795 - 540853 == -480058)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BC49 RID: 48201 RVA: 0x013FD528 File Offset: 0x013FB728
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderFireMatch()
	{
		if (286647 - 54964 != 231683)
		{
		}
		for (;;)
		{
			IL_4B3:
			float num = (float)(1024 * Screen.width / Screen.height);
			if (175771 - 435365 == -259594)
			{
				this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
				if (254204 - 382186 != -127981)
				{
					if (!this.wB8np8nMvFp)
					{
						if (264886 - 238504 != 26383)
						{
							this.InitFireMatch();
							if (74472 - 351123 != -276650)
							{
								break;
							}
						}
					}
					else
					{
						GUI.BeginGroup(new Rect((float)(512 * Screen.width / Screen.height - 400), (float)200, (float)800, (float)500));
						if (51570 - 274360 == -222790)
						{
							if (this.fireArena_match)
							{
								if (58248 - 46568 == 11681)
								{
									continue;
								}
								GUI.DrawTexture(new Rect((float)0, (float)0, (float)800, (float)500), this.fireArena_match);
								if (63672 - 382114 == -318441)
								{
									continue;
								}
							}
							if (this.fireArena_highlight)
							{
								if (200248 - 115674 == 84575)
								{
									continue;
								}
								if (this.UCMnpwUdA9f > 0)
								{
									if (51743 - 301464 != -249721)
									{
										continue;
									}
									if (this.UCMnpwUdA9f <= 7)
									{
										if (245496 - 467766 == -222269)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)(this.d8HnpAp3bec[this.UCMnpwUdA9f * 2 - 2] - 12), (float)(this.cMAnp9kx8a8[this.UCMnpwUdA9f * 2 - 2] - 12), (float)100, (float)100), this.fireArena_highlight);
										if (173919 - 396934 != -223015)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)(this.d8HnpAp3bec[this.UCMnpwUdA9f * 2 - 1] - 12), (float)(this.cMAnp9kx8a8[this.UCMnpwUdA9f * 2 - 1] - 12), (float)100, (float)100), this.fireArena_highlight);
										if (292359 - 90139 != 202220)
										{
											continue;
										}
									}
								}
							}
							int i = 0;
							if (179079 - 428861 != -249781)
							{
								while (i < 14)
								{
									int num2 = this.M3SnpUC19o5[i];
									if (209436 - 397282 == -187845)
									{
										goto IL_4B3;
									}
									if (num2 != 0)
									{
										if (79805 - 126827 != -47022)
										{
											goto IL_4B3;
										}
										if (this.FOInpBlDpw0[Mathf.Abs(num2) - 1])
										{
											if (88759 - 458891 != -370132)
											{
												goto IL_4B3;
											}
											GUI.DrawTexture(new Rect((float)this.d8HnpAp3bec[i], (float)this.cMAnp9kx8a8[i], (float)75, (float)75), this.FOInpBlDpw0[Mathf.Abs(num2) - 1]);
											if (184884 - 134162 == 50723)
											{
												goto IL_4B3;
											}
										}
										if (num2 < 0)
										{
											if (50882 - 343518 != -292636)
											{
												goto IL_4B3;
											}
											GUI.DrawTexture(new Rect((float)(this.d8HnpAp3bec[i] - 22), (float)(this.cMAnp9kx8a8[i] - 22), (float)100, (float)100), this.fireArena_dead);
											if (71709 - 180111 == -108401)
											{
												goto IL_4B3;
											}
										}
									}
									i++;
									if (4343 - 426912 == -422568)
									{
										goto IL_4B3;
									}
								}
								if (163151 - 111043 != 52109)
								{
									GUI.EndGroup();
									if (269335 - 390749 == -121414)
									{
										if (Game.mGameState != eGameState.AllHold)
										{
											break;
										}
										if (149467 - 121681 == 27786)
										{
											if (this.UCMnpwUdA9f <= 0)
											{
												break;
											}
											if (284104 - 490795 != -206690)
											{
												if (this.UCMnpwUdA9f > 7)
												{
													break;
												}
												if (175595 - 62148 == 113447)
												{
													float num3 = (float)0;
													if (116122 - 178734 == -62612)
													{
														int num4 = this.M3SnpUC19o5[this.UCMnpwUdA9f * 2 - 2];
														if (67739 - 527328 != -459588)
														{
															int num5 = this.M3SnpUC19o5[this.UCMnpwUdA9f * 2 - 1];
															if (32153 - 180838 == -148685)
															{
																if (Time.time - this.GtCnpfosCIs < (float)1)
																{
																	if (290384 - 255769 == 34616)
																	{
																		continue;
																	}
																	num3 = Mathf.SmoothStep(1f, (float)0, Time.time - this.GtCnpfosCIs);
																	if (210949 - 73199 == 137751)
																	{
																		continue;
																	}
																}
																else if (Time.time - this.GtCnpfosCIs > (float)4)
																{
																	if (140050 - 502938 == -362887)
																	{
																		continue;
																	}
																	num3 = Mathf.SmoothStep((float)0, 1f, Time.time - this.GtCnpfosCIs - (float)4);
																	if (247233 - 428759 == -181525)
																	{
																		continue;
																	}
																}
																else
																{
																	if (num4 > 0)
																	{
																		if (238094 - 524492 != -286398)
																		{
																			continue;
																		}
																		Guix.renderTextOutline(new Rect(0.5f * num - (float)500, (float)800, (float)360, (float)60), this.y7EnpSYMvvn[num4 - 1], this.mfGnpjPmo8U);
																		if (225936 - 261082 == -35145)
																		{
																			continue;
																		}
																		GUI.Label(new Rect(0.5f * num - (float)500, (float)800, (float)360, (float)60), this.y7EnpSYMvvn[num4 - 1], this.EnnnpDuHdx7);
																		if (31786 - 448793 != -417007)
																		{
																			continue;
																		}
																	}
																	if (num5 > 0)
																	{
																		if (156474 - 229373 != -72899)
																		{
																			continue;
																		}
																		Guix.renderTextOutline(new Rect(0.5f * num + (float)200, (float)800, (float)360, (float)60), this.y7EnpSYMvvn[num5 - 1], this.KH4npo2xZuD);
																		if (245759 - 241919 == 3841)
																		{
																			continue;
																		}
																		GUI.Label(new Rect(0.5f * num + (float)200, (float)800, (float)360, (float)60), this.y7EnpSYMvvn[num5 - 1], this.p7inpmSm46g);
																		if (129288 - 19457 != 109831)
																		{
																			continue;
																		}
																	}
																}
																if (num4 <= 0)
																{
																	break;
																}
																if (15910 - 583665 == -567755)
																{
																	if (num5 <= 0)
																	{
																		break;
																	}
																	if (177597 - 14678 == 162919)
																	{
																		Texture texture = this.wainp0EpSjt[Mathf.Abs(num4) - 1];
																		if (178102 - 240585 == -62483)
																		{
																			Texture texture2 = this.wainp0EpSjt[Mathf.Abs(num5) - 1];
																			if (146016 - 118308 != 27709)
																			{
																				if (texture)
																				{
																					if (208857 - 1706 == 207152)
																					{
																						continue;
																					}
																					GUI.DrawTexture(new Rect((float)-1 * num3 * (float)texture.width, (float)(1024 - texture.height), (float)texture.width, (float)texture.height), texture);
																					if (292397 - 316366 != -23969)
																					{
																						continue;
																					}
																				}
																				if (texture2)
																				{
																					if (194588 - 166601 == 27988)
																					{
																						continue;
																					}
																					GUI.DrawTexture(new Rect(num3 * (float)texture.width + num, (float)(1024 - texture2.height), (float)(-(float)texture2.width), (float)texture2.height), texture2);
																					if (162543 - 185600 == -23056)
																					{
																						continue;
																					}
																				}
																				if (!this.fireArena_versus)
																				{
																					break;
																				}
																				if (19147 - 139478 == -120331)
																				{
																					GUI.DrawTexture(new Rect(0.5f * num - (float)200, (float)724 + num3 * (float)300, (float)399, (float)153), this.fireArena_versus);
																					if (280913 - 169795 == 111118)
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

	// Token: 0x0600BC4A RID: 48202 RVA: 0x013FDED8 File Offset: 0x013FC0D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitFireBar()
	{
		if (223170 - 492750 != -269579)
		{
		}
		for (;;)
		{
			this.LACnpWNUSUv = new GUIStyle();
			if (236068 - 575925 != -339856)
			{
				if (this.fireArena_tree)
				{
					if (237798 - 343422 != -105624)
					{
						continue;
					}
					this.LACnpWNUSUv.normal.background = (Texture2D)this.fireArena_tree;
					if (23723 - 302270 != -278547)
					{
						continue;
					}
				}
				if (this.fireArena_tree_h)
				{
					if (71346 - 514152 == -442805)
					{
						continue;
					}
					this.LACnpWNUSUv.hover.background = (Texture2D)this.fireArena_tree_h;
					if (229635 - 563433 != -333798)
					{
						continue;
					}
				}
				this.Lxxnpu5tLFS = new GUIStyle();
				if (189560 - 465978 == -276418)
				{
					if (this.fireArena_quit)
					{
						if (190355 - 45756 == 144600)
						{
							continue;
						}
						this.Lxxnpu5tLFS.normal.background = (Texture2D)this.fireArena_quit;
						if (197279 - 276613 == -79333)
						{
							continue;
						}
					}
					if (!this.fireArena_quit_h)
					{
						break;
					}
					if (105047 - 121007 != -15959)
					{
						this.Lxxnpu5tLFS.hover.background = (Texture2D)this.fireArena_quit_h;
						if (297343 - 312378 != -15034)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BC4B RID: 48203 RVA: 0x013FE0D8 File Offset: 0x013FC2D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderFireBar()
	{
		if (290315 - 544298 != -253982)
		{
		}
		while (this.UCMnpwUdA9f > 0)
		{
			if (275042 - 596218 != -321175)
			{
				if (this.UCMnpwUdA9f > 7)
				{
					break;
				}
				if (272835 - 382937 == -110102)
				{
					float num = (float)(1024 * Screen.width / Screen.height);
					if (158911 - 525934 != -367022)
					{
						int num2 = 0;
						if (101856 - 18609 != 83248)
						{
							int nNum = 0;
							if (7808 - 16562 == -8754)
							{
								if (Game.mGameTime != (float)0)
								{
									if (37428 - 204221 != -166793)
									{
										continue;
									}
									num2 = Mathf.Abs(Mathf.FloorToInt(Time.time - Game.mGameTime));
									if (47202 - 422465 != -375263)
									{
										continue;
									}
									nNum = global::Math.div((float)num2, (float)60);
									if (205053 - 437244 != -232191)
									{
										continue;
									}
									num2 %= 60;
									if (96958 - 94624 == 2335)
									{
										continue;
									}
								}
								GUI.DrawTexture(new Rect(0.5f * (num - (float)169), (float)4, (float)169, (float)96), this.fireArena_timerBar);
								if (182405 - 107851 == 74554)
								{
									Guix.renderSmallNumber((int)(0.5f * num - (float)30), 40, nNum, false, 1.25f);
									if (268762 - 166648 == 102114)
									{
										Guix.renderSmallNumber((int)(0.5f * num + (float)30), 40, num2, false, 1.25f);
										if (56007 - 27377 != 28631)
										{
											if (num2 < 10)
											{
												if (124284 - 66004 != 58280)
												{
													continue;
												}
												Guix.renderSmallNumber((int)(0.5f * num + (float)10), 40, 0, false, 1.25f);
												if (78064 - 212638 == -134573)
												{
													continue;
												}
											}
											if (!GUI.Button(new Rect(num - (float)226, (float)940, (float)196, (float)41), string.Empty, this.LACnpWNUSUv))
											{
												break;
											}
											if (220676 - 51035 != 169642)
											{
												if (this.zD6npVx34i3 >= Time.time)
												{
													break;
												}
												if (218018 - 286177 == -68159)
												{
													this.yIsnpytmmit = !this.yIsnpytmmit;
													if (154186 - 261865 != -107678)
													{
														this.zD6npVx34i3 = Time.time + 0.1f;
														if (167213 - 371593 == -204380)
														{
															if (!this.wYInpFkUpGH)
															{
																break;
															}
															if (272026 - 538184 != -266157)
															{
																this.audio.PlayOneShot(this.wYInpFkUpGH);
																if (294522 - 63514 != 231009)
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

	// Token: 0x0600BC4C RID: 48204 RVA: 0x013FE47C File Offset: 0x013FC67C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitFireTargetBar()
	{
		if (40353 - 112710 != -72356)
		{
		}
		for (;;)
		{
			this.zwYnphPYWjj = (Texture)Resources.Load("GameGui/GameWindow/targetBar/BG", typeof(Texture));
			if (124230 - 121500 != 2731)
			{
				this.wYqnpKFTUU1 = (Texture)Resources.Load("GameGui/GameWindow/targetBar/HP1", typeof(Texture));
				if (130539 - 39698 == 90841)
				{
					this.EE4npzdD2Lb = (Texture)Resources.Load("GameGui/GameWindow/targetBar/HP2", typeof(Texture));
					if (263183 - 396461 == -133278)
					{
						this.ngunR5YK2pH = (Texture)Resources.Load("GameGui/GameWindow/targetBar/HP3", typeof(Texture));
						if (165498 - 464271 != -298772)
						{
							this.OiUnRcj14lG = (Texture)Resources.Load("GameGui/GameWindow/targetBar/MHP1", typeof(Texture));
							if (122233 - 94475 != 27759)
							{
								this.uRPnRnLFx41 = (Texture)Resources.Load("GameGui/GameWindow/targetBar/MHP2", typeof(Texture));
								if (272320 - 567363 != -295042)
								{
									this.X0bnRQbgHc8 = (Texture)Resources.Load("GameGui/GameWindow/targetBar/MHP3", typeof(Texture));
									if (249208 - 127905 == 121303)
									{
										this.qYlnReu47lk = (Texture)Resources.Load("GameGui/GameWindow/targetBar/MHP4", typeof(Texture));
										if (122615 - 595899 != -473283)
										{
											this.CVenRIuhmel = new GUIStyle();
											if (267354 - 300777 != -33422)
											{
												this.CVenRIuhmel.font = (Font)Resources.Load("GameGui/Fonts/Berlin24", typeof(Font));
												if (72831 - 596657 != -523825)
												{
													this.jIsnRJZo87f = new GUIStyle();
													if (35930 - 43828 == -7898)
													{
														this.jIsnRJZo87f.hover.background = (Texture2D)this.TargetBar_buttonTexture1;
														if (295492 - 398507 != -103014)
														{
															this.G1YnR62scHK = new GUIStyle();
															if (248771 - 46752 != 202020)
															{
																this.G1YnR62scHK.hover.background = (Texture2D)this.TargetBar_buttonTexture2;
																if (98662 - 467844 == -369182)
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

	// Token: 0x0600BC4D RID: 48205 RVA: 0x013FE794 File Offset: 0x013FC994
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LoadTargetBar(GameObject nPlayer)
	{
		if (269551 - 202993 != 66559)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nPlayer.GetComponent(typeof(CharacterControl));
			if (123290 - 403574 == -280284)
			{
				if (characterControl)
				{
					if (151664 - 151650 != 15)
					{
						int playerSlot = Game.getPlayerSlot(characterControl.ownerID);
						if (140791 - 386027 != -245235)
						{
							Debug.Log("LoadTargetBar for player slot:" + playerSlot + "@" + this.UCMnpwUdA9f);
							if (49714 - 266246 != -216531)
							{
								if (this.M3SnpUC19o5[this.UCMnpwUdA9f * 2 - 2] == playerSlot)
								{
									if (213294 - 591803 != -378508)
									{
										this.oy6nROXJlQE = characterControl;
										if (254283 - 281805 != -27521)
										{
											this.N69nRtHA5sW = characterControl.mTargetAvartar;
											if (3054 - 120205 == -117151)
											{
												if (!this.TXknpkYj4bj)
												{
													break;
												}
												if (265981 - 139500 == 126481)
												{
													this.audio.PlayOneShot(this.TXknpkYj4bj);
													if (220196 - 362631 != -142434)
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
									if (this.M3SnpUC19o5[this.UCMnpwUdA9f * 2 - 1] != playerSlot)
									{
										break;
									}
									if (152609 - 30850 == 121759)
									{
										this.cfknR2Kxofy = characterControl;
										if (7178 - 174996 != -167817)
										{
											this.eLJnRXsPkX0 = characterControl.mTargetAvartar;
											if (248484 - 494467 != -245982)
											{
												if (!this.TXknpkYj4bj)
												{
													break;
												}
												if (3645 - 312517 == -308872)
												{
													this.audio.PlayOneShot(this.TXknpkYj4bj);
													if (156370 - 237725 == -81355)
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
					Debug.LogError("Cannot find CharacterControl");
					if (60608 - 469219 != -408610)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600BC4E RID: 48206 RVA: 0x013FEA58 File Offset: 0x013FCC58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderFireTargetBar1()
	{
		if (140524 - 430073 != -289548)
		{
		}
		for (;;)
		{
			IL_806:
			float num = (float)(1024 * Screen.width / Screen.height);
			if (139486 - 191032 == -51546)
			{
				if (!this.oy6nROXJlQE)
				{
					break;
				}
				if (122957 - 84440 != 38518)
				{
					if (this.N69nRtHA5sW)
					{
						if (161491 - 313197 == -151705)
						{
							continue;
						}
						GUI.DrawTexture(new Rect((float)138, (float)0, (float)-138, (float)128), this.N69nRtHA5sW);
						if (155203 - 295878 != -140675)
						{
							continue;
						}
					}
					GUI.DrawTexture(new Rect((float)293, (float)0, (float)-293, (float)143), this.zwYnphPYWjj);
					if (9765 - 22924 == -13159)
					{
						if (GUI.Button(new Rect((float)0, (float)0, (float)143, (float)143), string.Empty, this.jIsnRJZo87f))
						{
							if (250005 - 280213 != -30208)
							{
								continue;
							}
							if (this.k90npgySjJI.enabled)
							{
								if (241108 - 405865 == -164756)
								{
									continue;
								}
								if (this.oy6nROXJlQE.gameObject != this.k90npgySjJI.target)
								{
									if (285547 - 471771 != -186224)
									{
										continue;
									}
								}
								else
								{
									this.k90npgySjJI.target = null;
									if (275713 - 9078 != 266635)
									{
										continue;
									}
									this.k90npgySjJI.enabled = false;
									if (40233 - 588578 == -548344)
									{
										continue;
									}
									GameObject gameObject = GameObject.Find("StartCamera3");
									if (17580 - 312151 == -294570)
									{
										continue;
									}
									if (!gameObject)
									{
										goto IL_60F;
									}
									if (135292 - 299006 == -163713)
									{
										continue;
									}
									this.transform.position = gameObject.transform.position;
									if (294676 - 38880 != 255796)
									{
										continue;
									}
									this.transform.rotation = gameObject.transform.rotation;
									if (176069 - 461974 != -285905)
									{
										continue;
									}
									goto IL_60F;
								}
							}
							this.k90npgySjJI.target = this.oy6nROXJlQE.gameObject;
							if (217259 - 72177 == 145083)
							{
								continue;
							}
							this.k90npgySjJI.enabled = true;
							if (90914 - 519967 != -429053)
							{
								continue;
							}
						}
						IL_60F:
						GUI.DrawTexture(new Rect((float)140, (float)57, (float)13, (float)24), this.OiUnRcj14lG);
						if (179322 - 579539 != -400216)
						{
							GUI.DrawTexture(new Rect((float)153, (float)57, (float)256, (float)24), this.uRPnRnLFx41);
							if (222808 - 27354 == 195454)
							{
								GUI.DrawTexture(new Rect((float)409, (float)57, (float)13, (float)24), this.X0bnRQbgHc8);
								if (175872 - 80581 == 95291)
								{
									if (this.oy6nROXJlQE.hp == this.oy6nROXJlQE.mhp)
									{
										if (34418 - 49737 == -15318)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)409, (float)62, (float)7, (float)15), this.ngunR5YK2pH);
										if (94 - 552201 == -552106)
										{
											continue;
										}
									}
									if (this.oy6nROXJlQE.hp > 0)
									{
										if (136031 - 490298 == -354266)
										{
											continue;
										}
										float num2 = 1f * (float)this.oy6nROXJlQE.hp / (float)this.oy6nROXJlQE.mhp;
										if (106509 - 331838 != -225329)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)153, (float)62, (float)Mathf.RoundToInt(num2 * (float)256), (float)15), this.EE4npzdD2Lb);
										if (207182 - 565685 != -358503)
										{
											continue;
										}
									}
									if (this.oy6nROXJlQE.hp > 0)
									{
										if (57446 - 521354 != -463908)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)146, (float)62, (float)7, (float)15), this.wYqnpKFTUU1);
										if (279051 - 573416 != -294365)
										{
											continue;
										}
									}
									this.CVenRIuhmel.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
									if (179119 - 322696 == -143577)
									{
										this.CVenRIuhmel.alignment = TextAnchor.MiddleLeft;
										if (30673 - 175757 != -145083)
										{
											GUI.Label(new Rect((float)200, (float)50, (float)200, (float)36), this.oy6nROXJlQE.hp + "/" + this.oy6nROXJlQE.mhp, this.CVenRIuhmel);
											if (209103 - 480809 == -271706)
											{
												int num3 = 0;
												if (176698 - 223152 != -46453)
												{
													IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(this.oy6nROXJlQE.mStatusList);
													if (252567 - 7602 == 244965)
													{
														while (enumerator.MoveNext())
														{
															object obj = enumerator.Current;
															object obj3;
															object obj2 = obj3 = obj;
															if (!(obj2 is statusClass))
															{
																obj3 = RuntimeServices.Coerce(obj2, typeof(statusClass));
															}
															statusClass statusClass = (statusClass)obj3;
															if (49081 - 483504 != -434423)
															{
																goto IL_806;
															}
															if (num3 < 12)
															{
																if (39313 - 56763 == -17449)
																{
																	goto IL_806;
																}
																if (statusClass.sIcon)
																{
																	if (341 - 153258 != -152917)
																	{
																		goto IL_806;
																	}
																	GUI.DrawTexture(new Rect((float)(180 + 26 * num3), (float)8, (float)24, (float)24), statusClass.sIcon);
																	if (180030 - 474042 != -294012)
																	{
																		goto IL_806;
																	}
																	UnityRuntimeServices.Update(enumerator, statusClass);
																	if (47429 - 416430 != -369001)
																	{
																		goto IL_806;
																	}
																	num3++;
																	if (164602 - 255555 == -90952)
																	{
																		goto IL_806;
																	}
																}
															}
														}
														if (113875 - 155366 == -41491)
														{
															this.CVenRIuhmel.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
															if (49025 - 105283 != -56257)
															{
																this.CVenRIuhmel.alignment = TextAnchor.MiddleLeft;
																if (290721 - 295129 != -4407)
																{
																	Guix.renderTextOutline(new Rect((float)150, (float)25, (float)250, (float)40), this.oy6nROXJlQE.Name, this.CVenRIuhmel);
																	if (266108 - 418090 != -151981)
																	{
																		this.CVenRIuhmel.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
																		if (104283 - 63779 == 40504)
																		{
																			GUI.Label(new Rect((float)150, (float)25, (float)250, (float)40), this.oy6nROXJlQE.Name, this.CVenRIuhmel);
																			if (287679 - 175588 == 112091)
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

	// Token: 0x0600BC4F RID: 48207 RVA: 0x013FF318 File Offset: 0x013FD518
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderFireTargetBar2()
	{
		if (61355 - 376060 != -314704)
		{
		}
		for (;;)
		{
			IL_34D:
			float num = (float)(1024 * Screen.width / Screen.height);
			if (74379 - 493264 == -418885)
			{
				if (!this.cfknR2Kxofy)
				{
					break;
				}
				if (39227 - 516277 == -477050)
				{
					if (this.eLJnRXsPkX0)
					{
						if (153605 - 246241 != -92636)
						{
							continue;
						}
						GUI.DrawTexture(new Rect(num - (float)138, (float)0, (float)138, (float)128), this.eLJnRXsPkX0);
						if (218912 - 386357 != -167445)
						{
							continue;
						}
					}
					GUI.DrawTexture(new Rect(num - (float)293, (float)0, (float)293, (float)143), this.zwYnphPYWjj);
					if (188985 - 250087 != -61101)
					{
						if (GUI.Button(new Rect(num - (float)143, (float)0, (float)143, (float)143), string.Empty, this.G1YnR62scHK))
						{
							if (109342 - 509979 == -400636)
							{
								continue;
							}
							if (this.k90npgySjJI.enabled)
							{
								if (282596 - 519473 == -236876)
								{
									continue;
								}
								if (this.cfknR2Kxofy.gameObject != this.k90npgySjJI.target)
								{
									if (116097 - 379821 != -263724)
									{
										continue;
									}
								}
								else
								{
									this.k90npgySjJI.target = null;
									if (273683 - 73018 == 200666)
									{
										continue;
									}
									this.k90npgySjJI.enabled = false;
									if (104181 - 541726 == -437544)
									{
										continue;
									}
									GameObject gameObject = GameObject.Find("StartCamera3");
									if (16890 - 227380 != -210490)
									{
										continue;
									}
									if (!gameObject)
									{
										goto IL_259;
									}
									if (74817 - 292996 != -218179)
									{
										continue;
									}
									this.transform.position = gameObject.transform.position;
									if (263404 - 73948 == 189457)
									{
										continue;
									}
									this.transform.rotation = gameObject.transform.rotation;
									if (84343 - 328398 != -244054)
									{
										goto IL_259;
									}
									continue;
								}
							}
							this.k90npgySjJI.target = this.cfknR2Kxofy.gameObject;
							if (80068 - 398173 == -318104)
							{
								continue;
							}
							this.k90npgySjJI.enabled = true;
							if (140706 - 389299 == -248592)
							{
								continue;
							}
						}
						IL_259:
						GUI.DrawTexture(new Rect(num - (float)425, (float)57, (float)13, (float)24), this.OiUnRcj14lG);
						if (285748 - 292088 == -6340)
						{
							GUI.DrawTexture(new Rect(num - (float)412, (float)57, (float)256, (float)24), this.uRPnRnLFx41);
							if (92165 - 19335 != 72831)
							{
								GUI.DrawTexture(new Rect(num - (float)156, (float)57, (float)13, (float)24), this.X0bnRQbgHc8);
								if (293865 - 363209 == -69344)
								{
									if (this.cfknR2Kxofy.hp == this.cfknR2Kxofy.mhp)
									{
										if (43910 - 596301 == -552390)
										{
											continue;
										}
										GUI.DrawTexture(new Rect(num - (float)419, (float)62, (float)7, (float)15), this.wYqnpKFTUU1);
										if (178054 - 266806 != -88752)
										{
											continue;
										}
									}
									if (this.cfknR2Kxofy.hp > 0)
									{
										if (99023 - 164274 != -65251)
										{
											continue;
										}
										float num2 = 1f * (float)this.cfknR2Kxofy.hp / (float)this.cfknR2Kxofy.mhp;
										if (128913 - 137203 != -8290)
										{
											continue;
										}
										GUI.DrawTexture(new Rect(num - (float)156 - (float)256 * num2, (float)62, (float)Mathf.RoundToInt((float)256 * num2), (float)15), this.EE4npzdD2Lb);
										if (167596 - 550006 != -382410)
										{
											continue;
										}
									}
									if (this.cfknR2Kxofy.hp > 0)
									{
										if (159308 - 53983 != 105325)
										{
											continue;
										}
										GUI.DrawTexture(new Rect(num - (float)156, (float)62, (float)7, (float)15), this.ngunR5YK2pH);
										if (147255 - 263106 != -115851)
										{
											continue;
										}
									}
									this.CVenRIuhmel.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
									if (18148 - 115123 != -96974)
									{
										this.CVenRIuhmel.alignment = TextAnchor.MiddleRight;
										if (16146 - 539506 != -523359)
										{
											GUI.Label(new Rect(num - (float)400, (float)50, (float)200, (float)36), this.cfknR2Kxofy.hp + "/" + this.cfknR2Kxofy.mhp, this.CVenRIuhmel);
											if (237658 - 593081 != -355422)
											{
												int num3 = 0;
												if (46723 - 316669 == -269946)
												{
													IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(this.cfknR2Kxofy.mStatusList);
													if (189240 - 263913 != -74672)
													{
														while (enumerator.MoveNext())
														{
															object obj = enumerator.Current;
															object obj3;
															object obj2 = obj3 = obj;
															if (!(obj2 is statusClass))
															{
																obj3 = RuntimeServices.Coerce(obj2, typeof(statusClass));
															}
															statusClass statusClass = (statusClass)obj3;
															if (122947 - 99906 == 23042)
															{
																goto IL_34D;
															}
															if (num3 < 12)
															{
																if (58920 - 19049 != 39871)
																{
																	goto IL_34D;
																}
																if (statusClass.sIcon)
																{
																	if (85584 - 153596 == -68011)
																	{
																		goto IL_34D;
																	}
																	GUI.DrawTexture(new Rect(num - (float)180 - (float)(26 * num3), (float)8, (float)24, (float)24), statusClass.sIcon);
																	if (59085 - 132338 == -73252)
																	{
																		goto IL_34D;
																	}
																	UnityRuntimeServices.Update(enumerator, statusClass);
																	if (119420 - 27616 == 91805)
																	{
																		goto IL_34D;
																	}
																	num3++;
																	if (221810 - 541122 != -319312)
																	{
																		goto IL_34D;
																	}
																}
															}
														}
														if (472 - 318426 == -317954)
														{
															this.CVenRIuhmel.normal.textColor = new Color((float)0, (float)0, (float)0, (float)1);
															if (28945 - 81322 != -52376)
															{
																this.CVenRIuhmel.alignment = TextAnchor.MiddleRight;
																if (58443 - 415837 != -357393)
																{
																	Guix.renderTextOutline(new Rect(num - (float)400, (float)25, (float)250, (float)40), this.cfknR2Kxofy.Name, this.CVenRIuhmel);
																	if (42791 - 553941 != -511149)
																	{
																		this.CVenRIuhmel.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
																		if (207914 - 327759 != -119844)
																		{
																			GUI.Label(new Rect(num - (float)400, (float)25, (float)250, (float)40), this.cfknR2Kxofy.Name, this.CVenRIuhmel);
																			if (254649 - 124014 == 130635)
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

	// Token: 0x0600BC50 RID: 48208 RVA: 0x013FFC00 File Offset: 0x013FDE00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitFireChat()
	{
		if (140609 - 353294 != -212685)
		{
		}
		for (;;)
		{
			this.VmbnRvEUWQV = string.Empty;
			if (189936 - 115569 == 74367)
			{
				this.qvXnRlJ9Dfl = (Texture)Resources.Load("GameGui/Common/TypeField", typeof(Texture));
				if (98806 - 200681 != -101874)
				{
					this.XegnRGZnkZE = new GUIStyle();
					if (133493 - 379269 != -245775)
					{
						this.XegnRGZnkZE.font = (Font)Resources.Load("GameGui/Fonts/GMO28", typeof(Font));
						if (184678 - 443873 != -259194)
						{
							this.wUxnR1AD45l = new GUIStyle();
							if (270255 - 467665 == -197410)
							{
								this.wUxnR1AD45l.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
								if (51545 - 144160 != -92614)
								{
									this.UtynRqAECNp = Chat.TextColor;
									if (204457 - 243488 == -39031)
									{
										this.ohnnRpHLM4r = Chat.SelfColor;
										if (175249 - 584556 != -409306)
										{
											this.YJOnRR90UYx = Chat.AllyColor;
											if (56726 - 588689 == -531963)
											{
												this.ydGnRraG3HF = Chat.EnemyColor;
												if (102351 - 93072 != 9280)
												{
													this.aoZnRx9PsOo = Chat.GuildColor;
													if (216362 - 205080 == 11282)
													{
														this.J3JnRTe5inu = Chat.NPCColor;
														if (195071 - 54522 == 140549)
														{
															this.ujhnRYcV9fl = Chat.ShadowColor;
															if (84820 - 223246 != -138425)
															{
																this.YDKnR3R5xwQ = Chat.SystemColor;
																if (46166 - 235414 != -189247)
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

	// Token: 0x0600BC51 RID: 48209 RVA: 0x013FFE84 File Offset: 0x013FE084
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderFireChat()
	{
		if (158031 - 194371 != -36339)
		{
		}
		for (;;)
		{
			IL_1DB7:
			float num = (float)(1024 * Screen.width / Screen.height);
			if (226911 - 342510 == -115599)
			{
				GUILayout.BeginArea(new Rect(num - (float)650, (float)300, (float)600, (float)600));
				if (237172 - 4361 == 232811)
				{
					GUILayout.BeginVertical(new GUILayoutOption[0]);
					if (34067 - 483315 == -449248)
					{
						GUILayout.FlexibleSpace();
						if (259355 - 193985 != 65371)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(Chat.ChatDisplay);
							if (95223 - 10462 != 84762)
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
									if (258813 - 304999 == -46185)
									{
										goto IL_1DB7;
									}
									float num2 = Mathf.Clamp((float)30 - Time.time + chatEntry.time, (float)0, 1f);
									if (299326 - 578773 == -279446)
									{
										goto IL_1DB7;
									}
									UnityRuntimeServices.Update(enumerator, chatEntry);
									if (181156 - 6388 == 174769)
									{
										goto IL_1DB7;
									}
									eChatMode mode = chatEntry.mode;
									if (139444 - 217024 == -77579)
									{
										goto IL_1DB7;
									}
									UnityRuntimeServices.Update(enumerator, chatEntry);
									if (23728 - 344062 != -320334)
									{
										goto IL_1DB7;
									}
									if (mode == eChatMode.area)
									{
										if (213631 - 209189 == 4443)
										{
											goto IL_1DB7;
										}
										if (Chat.showAreaChat)
										{
											if (160641 - 213681 != -53040)
											{
												goto IL_1DB7;
											}
											GUILayout.BeginHorizontal(new GUILayoutOption[0]);
											if (2466 - 108789 == -106322)
											{
												goto IL_1DB7;
											}
											GUILayout.FlexibleSpace();
											if (65021 - 533429 == -468407)
											{
												goto IL_1DB7;
											}
											this.wUxnR1AD45l.normal.textColor = this.J3JnRTe5inu;
											if (285590 - 85854 != 199736)
											{
												goto IL_1DB7;
											}
											float a = num2;
											if (246583 - 303821 == -57237)
											{
												goto IL_1DB7;
											}
											Color textColor = this.wUxnR1AD45l.normal.textColor;
											if (52354 - 392155 != -339801)
											{
												goto IL_1DB7;
											}
											float num3 = textColor.a = a;
											if (93988 - 64244 == 29745 || 263962 - 110713 == 153250)
											{
												goto IL_1DB7;
											}
											this.wUxnR1AD45l.normal.textColor = textColor;
											if (140301 - 254122 == -113820)
											{
												goto IL_1DB7;
											}
											if (2496 - 447662 != -445166)
											{
												goto IL_1DB7;
											}
											GUILayout.Label("[ALL]", this.wUxnR1AD45l, new GUILayoutOption[0]);
											if (214585 - 449387 != -234802)
											{
												goto IL_1DB7;
											}
											GUILayout.Space((float)5);
											if (89881 - 44529 == 45353)
											{
												goto IL_1DB7;
											}
											this.wUxnR1AD45l.normal.textColor = this.ohnnRpHLM4r;
											if (20610 - 476027 == -455416)
											{
												goto IL_1DB7;
											}
											float a2 = num2;
											if (48703 - 329526 == -280822)
											{
												goto IL_1DB7;
											}
											Color textColor2 = this.wUxnR1AD45l.normal.textColor;
											if (78289 - 39261 != 39028)
											{
												goto IL_1DB7;
											}
											textColor2.a = a2;
											if (148481 - 169756 == -21274 || 276304 - 122118 == 154187)
											{
												goto IL_1DB7;
											}
											Color color = this.wUxnR1AD45l.normal.textColor = textColor2;
											if (31069 - 479949 == -448879 || 144891 - 286190 == -141298)
											{
												goto IL_1DB7;
											}
											GUILayout.Label(chatEntry.name + ":", this.wUxnR1AD45l, new GUILayoutOption[0]);
											if (155589 - 521695 != -366106)
											{
												goto IL_1DB7;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (176513 - 125078 == 51436)
											{
												goto IL_1DB7;
											}
											GUILayout.Space((float)5);
											if (279057 - 314356 == -35298)
											{
												goto IL_1DB7;
											}
											this.wUxnR1AD45l.normal.textColor = this.UtynRqAECNp;
											if (68196 - 493180 == -424983)
											{
												goto IL_1DB7;
											}
											float a3 = num2;
											if (80746 - 564955 == -484208)
											{
												goto IL_1DB7;
											}
											Color textColor3 = this.wUxnR1AD45l.normal.textColor;
											if (12035 - 271930 == -259894)
											{
												goto IL_1DB7;
											}
											textColor3.a = a3;
											if (47567 - 25782 != 21785)
											{
												goto IL_1DB7;
											}
											if (67238 - 400002 == -332763)
											{
												goto IL_1DB7;
											}
											Color color2 = this.wUxnR1AD45l.normal.textColor = textColor3;
											if (206857 - 332789 != -125932)
											{
												goto IL_1DB7;
											}
											if (108452 - 474901 == -366448)
											{
												goto IL_1DB7;
											}
											GUILayout.Label(chatEntry.text, this.wUxnR1AD45l, new GUILayoutOption[0]);
											if (30251 - 63769 != -33518)
											{
												goto IL_1DB7;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (10186 - 344663 == -334476)
											{
												goto IL_1DB7;
											}
											GUILayout.EndHorizontal();
											if (276133 - 247543 == 28591)
											{
												goto IL_1DB7;
											}
										}
									}
									else if (mode == eChatMode.party)
									{
										if (1997 - 584764 != -582767)
										{
											goto IL_1DB7;
										}
										if (Chat.showAreaChat)
										{
											if (209299 - 37637 == 171663)
											{
												goto IL_1DB7;
											}
											GUILayout.BeginHorizontal(new GUILayoutOption[0]);
											if (202960 - 486817 == -283856)
											{
												goto IL_1DB7;
											}
											GUILayout.FlexibleSpace();
											if (69622 - 69335 != 287)
											{
												goto IL_1DB7;
											}
											this.wUxnR1AD45l.normal.textColor = new Color(0.8f, 0.2f, 0.2f, num2);
											if (272361 - 356312 == -83950)
											{
												goto IL_1DB7;
											}
											GUILayout.Label("[TEAM]", this.wUxnR1AD45l, new GUILayoutOption[0]);
											if (104950 - 532117 == -427166)
											{
												goto IL_1DB7;
											}
											GUILayout.Space((float)5);
											if (249203 - 587793 == -338589)
											{
												goto IL_1DB7;
											}
											this.wUxnR1AD45l.normal.textColor = this.ohnnRpHLM4r;
											if (40261 - 479509 == -439247)
											{
												goto IL_1DB7;
											}
											float a4 = num2;
											if (25950 - 558218 == -532267)
											{
												goto IL_1DB7;
											}
											Color textColor4 = this.wUxnR1AD45l.normal.textColor;
											if (43709 - 48708 != -4999)
											{
												goto IL_1DB7;
											}
											float num4 = textColor4.a = a4;
											if (153629 - 463722 != -310093)
											{
												goto IL_1DB7;
											}
											if (59210 - 276668 != -217458)
											{
												goto IL_1DB7;
											}
											this.wUxnR1AD45l.normal.textColor = textColor4;
											if (97481 - 203312 == -105830 || 293599 - 490802 == -197202)
											{
												goto IL_1DB7;
											}
											GUILayout.Label(chatEntry.name + ":", this.wUxnR1AD45l, new GUILayoutOption[0]);
											if (103588 - 559694 == -456105)
											{
												goto IL_1DB7;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (234807 - 432445 == -197637)
											{
												goto IL_1DB7;
											}
											GUILayout.Space((float)5);
											if (132574 - 176123 == -43548)
											{
												goto IL_1DB7;
											}
											this.wUxnR1AD45l.normal.textColor = this.UtynRqAECNp;
											if (122776 - 45729 != 77047)
											{
												goto IL_1DB7;
											}
											float a5 = num2;
											if (180665 - 499486 == -318820)
											{
												goto IL_1DB7;
											}
											Color textColor5 = this.wUxnR1AD45l.normal.textColor;
											if (69896 - 576703 != -506807)
											{
												goto IL_1DB7;
											}
											textColor5.a = a5;
											if (166924 - 368490 != -201566)
											{
												goto IL_1DB7;
											}
											if (183060 - 362986 == -179925)
											{
												goto IL_1DB7;
											}
											this.wUxnR1AD45l.normal.textColor = textColor5;
											if (162475 - 391401 != -228926)
											{
												goto IL_1DB7;
											}
											if (62055 - 348268 != -286213)
											{
												goto IL_1DB7;
											}
											GUILayout.Label(chatEntry.text, this.wUxnR1AD45l, new GUILayoutOption[0]);
											if (224155 - 102807 != 121348)
											{
												goto IL_1DB7;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (201403 - 95689 == 105715)
											{
												goto IL_1DB7;
											}
											GUILayout.EndHorizontal();
											if (29056 - 209218 != -180162)
											{
												goto IL_1DB7;
											}
										}
									}
									else if (mode == eChatMode.guild)
									{
										if (212384 - 562560 != -350176)
										{
											goto IL_1DB7;
										}
										if (Chat.showGuildChat)
										{
											if (217674 - 557677 != -340003)
											{
												goto IL_1DB7;
											}
											GUILayout.BeginHorizontal(new GUILayoutOption[0]);
											if (26503 - 195241 == -168737)
											{
												goto IL_1DB7;
											}
											GUILayout.FlexibleSpace();
											if (8204 - 593155 == -584950)
											{
												goto IL_1DB7;
											}
											this.wUxnR1AD45l.normal.textColor = this.aoZnRx9PsOo;
											if (146003 - 281988 != -135985)
											{
												goto IL_1DB7;
											}
											float a6 = num2;
											if (159511 - 155530 == 3982)
											{
												goto IL_1DB7;
											}
											Color textColor6 = this.wUxnR1AD45l.normal.textColor;
											if (9095 - 227518 != -218423)
											{
												goto IL_1DB7;
											}
											textColor6.a = a6;
											if (8711 - 53148 != -44437)
											{
												goto IL_1DB7;
											}
											if (43952 - 211929 != -167977)
											{
												goto IL_1DB7;
											}
											Color color3 = this.wUxnR1AD45l.normal.textColor = textColor6;
											if (229873 - 551930 == -322056)
											{
												goto IL_1DB7;
											}
											if (268289 - 235472 != 32817)
											{
												goto IL_1DB7;
											}
											GUILayout.Label("[GLD]", this.wUxnR1AD45l, new GUILayoutOption[0]);
											if (85816 - 98150 == -12333)
											{
												goto IL_1DB7;
											}
											GUILayout.Space((float)5);
											if (189245 - 148638 != 40607)
											{
												goto IL_1DB7;
											}
											this.wUxnR1AD45l.normal.textColor = this.ohnnRpHLM4r;
											if (101819 - 67779 == 34041)
											{
												goto IL_1DB7;
											}
											float a7 = num2;
											if (39687 - 231508 == -191820)
											{
												goto IL_1DB7;
											}
											Color textColor7 = this.wUxnR1AD45l.normal.textColor;
											if (60957 - 586542 == -525584)
											{
												goto IL_1DB7;
											}
											textColor7.a = a7;
											if (274199 - 596344 != -322145)
											{
												goto IL_1DB7;
											}
											if (101838 - 226925 == -125086)
											{
												goto IL_1DB7;
											}
											this.wUxnR1AD45l.normal.textColor = textColor7;
											if (69424 - 215445 == -146020)
											{
												goto IL_1DB7;
											}
											if (11301 - 519891 != -508590)
											{
												goto IL_1DB7;
											}
											GUILayout.Label(chatEntry.name + ":", this.wUxnR1AD45l, new GUILayoutOption[0]);
											if (935 - 111167 != -110232)
											{
												goto IL_1DB7;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (74537 - 218444 == -143906)
											{
												goto IL_1DB7;
											}
											GUILayout.Space((float)5);
											if (172696 - 287907 == -115210)
											{
												goto IL_1DB7;
											}
											this.wUxnR1AD45l.normal.textColor = this.aoZnRx9PsOo;
											if (278326 - 336250 != -57924)
											{
												goto IL_1DB7;
											}
											float a8 = num2;
											if (116802 - 313132 == -196329)
											{
												goto IL_1DB7;
											}
											Color textColor8 = this.wUxnR1AD45l.normal.textColor;
											if (263497 - 517978 != -254481)
											{
												goto IL_1DB7;
											}
											float num5 = textColor8.a = a8;
											if (104105 - 280036 != -175931)
											{
												goto IL_1DB7;
											}
											if (85012 - 384095 != -299083)
											{
												goto IL_1DB7;
											}
											this.wUxnR1AD45l.normal.textColor = textColor8;
											if (65883 - 99624 == -33740)
											{
												goto IL_1DB7;
											}
											if (62392 - 484428 != -422036)
											{
												goto IL_1DB7;
											}
											GUILayout.Label(chatEntry.text, this.wUxnR1AD45l, new GUILayoutOption[0]);
											if (283850 - 98009 != 185841)
											{
												goto IL_1DB7;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (108558 - 259323 == -150764)
											{
												goto IL_1DB7;
											}
											GUILayout.EndHorizontal();
											if (251273 - 367263 != -115990)
											{
												goto IL_1DB7;
											}
										}
									}
									else if (mode == eChatMode.whisper)
									{
										if (209845 - 133334 != 76511)
										{
											goto IL_1DB7;
										}
										if (Chat.showPrivateChat)
										{
											if (102451 - 259245 == -156793)
											{
												goto IL_1DB7;
											}
											GUILayout.BeginHorizontal(new GUILayoutOption[0]);
											if (222986 - 333798 == -110811)
											{
												goto IL_1DB7;
											}
											GUILayout.FlexibleSpace();
											if (134514 - 329489 == -194974)
											{
												goto IL_1DB7;
											}
											this.wUxnR1AD45l.normal.textColor = new Color(0.69f, 0.29f, 0.53f, num2);
											if (30850 - 78072 == -47221)
											{
												goto IL_1DB7;
											}
											GUILayout.Label("[WSP]", this.wUxnR1AD45l, new GUILayoutOption[0]);
											if (161366 - 22661 == 138706)
											{
												goto IL_1DB7;
											}
											GUILayout.Space((float)5);
											if (224140 - 411841 == -187700)
											{
												goto IL_1DB7;
											}
											this.wUxnR1AD45l.normal.textColor = this.ohnnRpHLM4r;
											if (126050 - 573113 != -447063)
											{
												goto IL_1DB7;
											}
											float a9 = num2;
											if (297787 - 51325 != 246462)
											{
												goto IL_1DB7;
											}
											Color textColor9 = this.wUxnR1AD45l.normal.textColor;
											if (261130 - 468570 != -207440)
											{
												goto IL_1DB7;
											}
											float num6 = textColor9.a = a9;
											if (5956 - 290889 != -284933)
											{
												goto IL_1DB7;
											}
											if (123732 - 459403 != -335671)
											{
												goto IL_1DB7;
											}
											Color color4 = this.wUxnR1AD45l.normal.textColor = textColor9;
											if (56505 - 578214 == -521708 || 88697 - 459525 == -370827)
											{
												goto IL_1DB7;
											}
											GUILayout.Label(chatEntry.name + ":", this.wUxnR1AD45l, new GUILayoutOption[0]);
											if (272533 - 83242 != 189291)
											{
												goto IL_1DB7;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (166254 - 63265 == 102990)
											{
												goto IL_1DB7;
											}
											GUILayout.Space((float)5);
											if (55016 - 201143 == -146126)
											{
												goto IL_1DB7;
											}
											this.wUxnR1AD45l.normal.textColor = this.UtynRqAECNp;
											if (52449 - 352606 != -300157)
											{
												goto IL_1DB7;
											}
											float a10 = num2;
											if (167713 - 405497 == -237783)
											{
												goto IL_1DB7;
											}
											Color textColor10 = this.wUxnR1AD45l.normal.textColor;
											if (296949 - 360687 != -63738)
											{
												goto IL_1DB7;
											}
											float num7 = textColor10.a = a10;
											if (8741 - 505389 == -496647 || 177046 - 144977 == 32070)
											{
												goto IL_1DB7;
											}
											this.wUxnR1AD45l.normal.textColor = textColor10;
											if (36384 - 100311 != -63927)
											{
												goto IL_1DB7;
											}
											if (257311 - 391908 != -134597)
											{
												goto IL_1DB7;
											}
											GUILayout.Label(chatEntry.text, this.wUxnR1AD45l, new GUILayoutOption[0]);
											if (237826 - 309939 != -72113)
											{
												goto IL_1DB7;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (233411 - 369156 != -135745)
											{
												goto IL_1DB7;
											}
											GUILayout.EndHorizontal();
											if (71767 - 353235 != -281468)
											{
												goto IL_1DB7;
											}
										}
									}
									else if (mode == eChatMode.system)
									{
										if (216638 - 252338 == -35699)
										{
											goto IL_1DB7;
										}
										if (Chat.showSystemChat)
										{
											if (215894 - 552893 == -336998)
											{
												goto IL_1DB7;
											}
											GUILayout.BeginHorizontal(new GUILayoutOption[0]);
											if (58754 - 217296 != -158542)
											{
												goto IL_1DB7;
											}
											GUILayout.FlexibleSpace();
											if (83996 - 253162 != -169166)
											{
												goto IL_1DB7;
											}
											eChatType type = chatEntry.type;
											if (245261 - 595016 != -349755)
											{
												goto IL_1DB7;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (268670 - 235575 != 33095)
											{
												goto IL_1DB7;
											}
											if (type == eChatType.system)
											{
												if (88025 - 334256 == -246230)
												{
													goto IL_1DB7;
												}
												this.wUxnR1AD45l.normal.textColor = this.YDKnR3R5xwQ;
												if (139013 - 505937 != -366924)
												{
													goto IL_1DB7;
												}
												float a11 = num2;
												if (240464 - 437181 != -196717)
												{
													goto IL_1DB7;
												}
												Color textColor11 = this.wUxnR1AD45l.normal.textColor;
												if (22068 - 183009 != -160941)
												{
													goto IL_1DB7;
												}
												textColor11.a = a11;
												if (224086 - 27071 != 197015)
												{
													goto IL_1DB7;
												}
												if (103601 - 86154 != 17447)
												{
													goto IL_1DB7;
												}
												Color color5 = this.wUxnR1AD45l.normal.textColor = textColor11;
												if (85309 - 191617 == -106307 || 141251 - 190918 == -49666)
												{
													goto IL_1DB7;
												}
												GUILayout.Label(" " + chatEntry.text + " ", this.wUxnR1AD45l, new GUILayoutOption[0]);
												if (149812 - 150798 == -985)
												{
													goto IL_1DB7;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (208179 - 278804 != -70625)
												{
													goto IL_1DB7;
												}
											}
											else if (type == eChatType.self)
											{
												if (112043 - 458507 != -346464)
												{
													goto IL_1DB7;
												}
												this.wUxnR1AD45l.normal.textColor = this.ohnnRpHLM4r;
												if (268712 - 207161 == 61552)
												{
													goto IL_1DB7;
												}
												float a12 = num2;
												if (209588 - 148509 != 61079)
												{
													goto IL_1DB7;
												}
												Color textColor12 = this.wUxnR1AD45l.normal.textColor;
												if (62009 - 181699 == -119689)
												{
													goto IL_1DB7;
												}
												textColor12.a = a12;
												if (165217 - 546458 != -381241)
												{
													goto IL_1DB7;
												}
												if (188099 - 483391 != -295292)
												{
													goto IL_1DB7;
												}
												Color color6 = this.wUxnR1AD45l.normal.textColor = textColor12;
												if (7784 - 413908 == -406123)
												{
													goto IL_1DB7;
												}
												if (251074 - 573527 != -322453)
												{
													goto IL_1DB7;
												}
												GUILayout.Label(chatEntry.name + ":", this.wUxnR1AD45l, new GUILayoutOption[0]);
												if (71516 - 551366 != -479850)
												{
													goto IL_1DB7;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (285569 - 580824 != -295255)
												{
													goto IL_1DB7;
												}
												this.wUxnR1AD45l.normal.textColor = this.UtynRqAECNp;
												if (78763 - 480140 != -401377)
												{
													goto IL_1DB7;
												}
												float a13 = num2;
												if (137942 - 316142 != -178200)
												{
													goto IL_1DB7;
												}
												Color textColor13 = this.wUxnR1AD45l.normal.textColor;
												if (93904 - 326735 != -232831)
												{
													goto IL_1DB7;
												}
												float num8 = textColor13.a = a13;
												if (191438 - 596289 == -404850 || 262497 - 372493 == -109995)
												{
													goto IL_1DB7;
												}
												Color color7 = this.wUxnR1AD45l.normal.textColor = textColor13;
												if (129721 - 178286 == -48564)
												{
													goto IL_1DB7;
												}
												if (49485 - 499742 != -450257)
												{
													goto IL_1DB7;
												}
												GUILayout.Label(" " + chatEntry.text + " ", this.wUxnR1AD45l, new GUILayoutOption[0]);
												if (39828 - 507110 == -467281)
												{
													goto IL_1DB7;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (113813 - 384631 != -270818)
												{
													goto IL_1DB7;
												}
											}
											else if (type == eChatType.ally)
											{
												if (229238 - 211122 != 18116)
												{
													goto IL_1DB7;
												}
												this.wUxnR1AD45l.normal.textColor = this.YJOnRR90UYx;
												if (166781 - 380036 == -213254)
												{
													goto IL_1DB7;
												}
												float a14 = num2;
												if (83466 - 209345 == -125878)
												{
													goto IL_1DB7;
												}
												Color textColor14 = this.wUxnR1AD45l.normal.textColor;
												if (198892 - 80389 != 118503)
												{
													goto IL_1DB7;
												}
												float num9 = textColor14.a = a14;
												if (50565 - 168221 != -117656)
												{
													goto IL_1DB7;
												}
												if (20472 - 27568 == -7095)
												{
													goto IL_1DB7;
												}
												Color color8 = this.wUxnR1AD45l.normal.textColor = textColor14;
												if (32168 - 471867 == -439698)
												{
													goto IL_1DB7;
												}
												if (243938 - 195024 != 48914)
												{
													goto IL_1DB7;
												}
												GUILayout.Label(chatEntry.name + ":", this.wUxnR1AD45l, new GUILayoutOption[0]);
												if (122666 - 563239 == -440572)
												{
													goto IL_1DB7;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (175798 - 359140 == -183341)
												{
													goto IL_1DB7;
												}
												this.wUxnR1AD45l.normal.textColor = this.UtynRqAECNp;
												if (56395 - 431268 != -374873)
												{
													goto IL_1DB7;
												}
												float a15 = num2;
												if (108961 - 344156 != -235195)
												{
													goto IL_1DB7;
												}
												Color textColor15 = this.wUxnR1AD45l.normal.textColor;
												if (69058 - 415829 == -346770)
												{
													goto IL_1DB7;
												}
												textColor15.a = a15;
												if (252863 - 308955 != -56092)
												{
													goto IL_1DB7;
												}
												if (64330 - 505508 == -441177)
												{
													goto IL_1DB7;
												}
												Color color9 = this.wUxnR1AD45l.normal.textColor = textColor15;
												if (106787 - 160621 != -53834)
												{
													goto IL_1DB7;
												}
												if (161843 - 489193 != -327350)
												{
													goto IL_1DB7;
												}
												GUILayout.Label(" " + chatEntry.text + " ", this.wUxnR1AD45l, new GUILayoutOption[0]);
												if (257429 - 321707 != -64278)
												{
													goto IL_1DB7;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (164906 - 123432 != 41474)
												{
													goto IL_1DB7;
												}
											}
											else if (type == eChatType.enemy)
											{
												if (282583 - 449377 != -166794)
												{
													goto IL_1DB7;
												}
												this.wUxnR1AD45l.normal.textColor = this.ydGnRraG3HF;
												if (107528 - 416259 != -308731)
												{
													goto IL_1DB7;
												}
												float a16 = num2;
												if (88688 - 72114 != 16574)
												{
													goto IL_1DB7;
												}
												Color textColor16 = this.wUxnR1AD45l.normal.textColor;
												if (47704 - 39924 == 7781)
												{
													goto IL_1DB7;
												}
												textColor16.a = a16;
												if (5441 - 312980 == -307538)
												{
													goto IL_1DB7;
												}
												if (92711 - 259279 != -166568)
												{
													goto IL_1DB7;
												}
												this.wUxnR1AD45l.normal.textColor = textColor16;
												if (80937 - 532131 != -451194)
												{
													goto IL_1DB7;
												}
												if (47714 - 537264 != -489550)
												{
													goto IL_1DB7;
												}
												GUILayout.Label(chatEntry.name + ":", this.wUxnR1AD45l, new GUILayoutOption[0]);
												if (120253 - 574912 == -454658)
												{
													goto IL_1DB7;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (7047 - 337202 != -330155)
												{
													goto IL_1DB7;
												}
												this.wUxnR1AD45l.normal.textColor = this.UtynRqAECNp;
												if (184998 - 317708 == -132709)
												{
													goto IL_1DB7;
												}
												float a17 = num2;
												if (247937 - 380110 != -132173)
												{
													goto IL_1DB7;
												}
												Color textColor17 = this.wUxnR1AD45l.normal.textColor;
												if (164450 - 474438 == -309987)
												{
													goto IL_1DB7;
												}
												textColor17.a = a17;
												if (222587 - 353454 == -130866 || 166651 - 437576 == -270924)
												{
													goto IL_1DB7;
												}
												Color color10 = this.wUxnR1AD45l.normal.textColor = textColor17;
												if (152106 - 382437 == -230330)
												{
													goto IL_1DB7;
												}
												if (211266 - 198917 != 12349)
												{
													goto IL_1DB7;
												}
												GUILayout.Label(" " + chatEntry.text + " ", this.wUxnR1AD45l, new GUILayoutOption[0]);
												if (267600 - 260814 != 6786)
												{
													goto IL_1DB7;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (148521 - 173805 != -25284)
												{
													goto IL_1DB7;
												}
											}
											else if (type == eChatType.npc)
											{
												if (253102 - 151259 == 101844)
												{
													goto IL_1DB7;
												}
												this.wUxnR1AD45l.normal.textColor = this.J3JnRTe5inu;
												if (78541 - 157350 == -78808)
												{
													goto IL_1DB7;
												}
												float a18 = num2;
												if (257907 - 419777 == -161869)
												{
													goto IL_1DB7;
												}
												Color textColor18 = this.wUxnR1AD45l.normal.textColor;
												if (123296 - 43383 != 79913)
												{
													goto IL_1DB7;
												}
												textColor18.a = a18;
												if (294362 - 93443 == 200920 || 210907 - 479714 == -268806)
												{
													goto IL_1DB7;
												}
												this.wUxnR1AD45l.normal.textColor = textColor18;
												if (263360 - 373824 == -110463 || 153277 - 444168 == -290890)
												{
													goto IL_1DB7;
												}
												GUILayout.Label(chatEntry.name + ":", this.wUxnR1AD45l, new GUILayoutOption[0]);
												if (264477 - 5108 != 259369)
												{
													goto IL_1DB7;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (59122 - 192415 != -133293)
												{
													goto IL_1DB7;
												}
												this.wUxnR1AD45l.normal.textColor = this.UtynRqAECNp;
												if (37163 - 413447 == -376283)
												{
													goto IL_1DB7;
												}
												float a19 = num2;
												if (114896 - 468976 == -354079)
												{
													goto IL_1DB7;
												}
												Color textColor19 = this.wUxnR1AD45l.normal.textColor;
												if (160081 - 414291 == -254209)
												{
													goto IL_1DB7;
												}
												float num10 = textColor19.a = a19;
												if (102761 - 28699 != 74062)
												{
													goto IL_1DB7;
												}
												if (153481 - 189869 != -36388)
												{
													goto IL_1DB7;
												}
												this.wUxnR1AD45l.normal.textColor = textColor19;
												if (242173 - 320584 != -78411)
												{
													goto IL_1DB7;
												}
												if (132914 - 306752 != -173838)
												{
													goto IL_1DB7;
												}
												GUILayout.Label(" " + chatEntry.text + " ", this.wUxnR1AD45l, new GUILayoutOption[0]);
												if (189656 - 331040 == -141383)
												{
													goto IL_1DB7;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (48828 - 112734 == -63905)
												{
													goto IL_1DB7;
												}
											}
											else if (type == eChatType.world)
											{
												if (253129 - 387274 == -134144)
												{
													goto IL_1DB7;
												}
												this.wUxnR1AD45l.normal.textColor = new Color(0.95f, 0.25f, 0.25f, num2);
												if (42483 - 573881 == -531397)
												{
													goto IL_1DB7;
												}
												GUILayout.Label(chatEntry.text, this.wUxnR1AD45l, new GUILayoutOption[0]);
												if (143561 - 211950 != -68389)
												{
													goto IL_1DB7;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (93311 - 147223 == -53911)
												{
													goto IL_1DB7;
												}
											}
											GUILayout.EndHorizontal();
											if (96379 - 70272 == 26108)
											{
												goto IL_1DB7;
											}
										}
									}
									else if (mode == eChatMode.world)
									{
										if (102345 - 564455 != -462110)
										{
											goto IL_1DB7;
										}
										GUILayout.BeginHorizontal(new GUILayoutOption[0]);
										if (99318 - 407651 == -308332)
										{
											goto IL_1DB7;
										}
										GUILayout.FlexibleSpace();
										if (99473 - 13952 != 85521)
										{
											goto IL_1DB7;
										}
										this.wUxnR1AD45l.normal.textColor = new Color(0.95f, 0.25f, 0.25f, num2);
										if (270621 - 383543 != -112922)
										{
											goto IL_1DB7;
										}
										GUILayout.Label(chatEntry.text, this.wUxnR1AD45l, new GUILayoutOption[0]);
										if (152592 - 51240 == 101353)
										{
											goto IL_1DB7;
										}
										UnityRuntimeServices.Update(enumerator, chatEntry);
										if (117625 - 197617 != -79992)
										{
											goto IL_1DB7;
										}
										GUILayout.EndHorizontal();
										if (275056 - 271197 != 3859)
										{
											goto IL_1DB7;
										}
									}
								}
								if (3090 - 190346 == -187256)
								{
									GUILayout.EndVertical();
									if (95443 - 173613 == -78170)
									{
										GUILayout.EndArea();
										if (275284 - 123585 == 151699)
										{
											if (!Chat.ChatActive)
											{
												break;
											}
											if (257170 - 280095 == -22925)
											{
												bool flag = true;
												if (134453 - 126029 == 8424)
												{
													GUI.DrawTexture(new Rect(0.5f * num - (float)157, (float)700, (float)335, (float)33), this.qvXnRlJ9Dfl);
													if (64597 - 360946 != -296348)
													{
														if (Input.GetKeyDown(KeyCode.UpArrow))
														{
															if (179877 - 194842 == -14965)
															{
																this.VmbnRvEUWQV = Chat.switchChatModeUp(this.VmbnRvEUWQV);
																if (56531 - 220726 == -164195)
																{
																	break;
																}
															}
														}
														else if (Input.GetKeyDown(KeyCode.DownArrow))
														{
															if (118280 - 433617 != -315336)
															{
																this.VmbnRvEUWQV = Chat.switchChatModeDown(this.VmbnRvEUWQV);
																if (204381 - 442071 == -237690)
																{
																	break;
																}
															}
														}
														else
														{
															if (Event.current.type == EventType.KeyDown)
															{
																if (3756 - 346241 == -342484)
																{
																	continue;
																}
																if (Event.current.character == "\n")
																{
																	if (60839 - 349799 != -288960)
																	{
																		continue;
																	}
																	if (Chat.ChatTimeOut <= Time.time)
																	{
																		if (28525 - 299825 != -271300)
																		{
																			continue;
																		}
																		string[] array = (string[])Stringf.splitToArray(this.VmbnRvEUWQV, " ").ToBuiltin(typeof(string));
																		if (207331 - 48204 == 159128)
																		{
																			continue;
																		}
																		if (Extensions.get_length(array) > 0)
																		{
																			if (88054 - 360300 == -272245)
																			{
																				continue;
																			}
																			string a20 = array[0];
																			if (75613 - 49792 == 25822)
																			{
																				continue;
																			}
																			if (a20 == "/a")
																			{
																				if (77161 - 115349 == -38187)
																				{
																					continue;
																				}
																				Chat.ChatMode = 1;
																				if (30826 - 364034 != -333208)
																				{
																					continue;
																				}
																				this.VmbnRvEUWQV = Stringf.getString(this.VmbnRvEUWQV, 2, Extensions.get_length(this.VmbnRvEUWQV));
																				if (117037 - 21603 == 95435)
																				{
																					continue;
																				}
																			}
																			else if (a20 == "/g")
																			{
																				if (132849 - 545171 == -412321)
																				{
																					continue;
																				}
																				if (!RuntimeServices.EqualityOperator(PlayerData.GID, "none"))
																				{
																					if (174115 - 35659 == 138457)
																					{
																						continue;
																					}
																					Chat.ChatMode = 2;
																					if (18514 - 137072 == -118557)
																					{
																						continue;
																					}
																					this.VmbnRvEUWQV = Stringf.getString(this.VmbnRvEUWQV, 2, Extensions.get_length(this.VmbnRvEUWQV));
																					if (63154 - 220926 != -157772)
																					{
																						continue;
																					}
																				}
																				else
																				{
																					this.newGameMessage("You are not in a guild");
																					if (174662 - 306023 != -131361)
																					{
																						continue;
																					}
																					flag = false;
																					if (266726 - 98961 != 167765)
																					{
																						continue;
																					}
																				}
																			}
																			else if (a20 == "/t")
																			{
																				if (165575 - 426429 == -260853)
																				{
																					continue;
																				}
																				this.newGameMessage("Cannot use team chat");
																				if (233955 - 70777 == 163179)
																				{
																					continue;
																				}
																				this.VmbnRvEUWQV = string.Empty;
																				if (65193 - 493304 == -428110)
																				{
																					continue;
																				}
																			}
																			else if (a20 == "/w")
																			{
																				if (162712 - 415161 == -252448)
																				{
																					continue;
																				}
																				Chat.ChatMode = 4;
																				if (151792 - 482346 != -330554)
																				{
																					continue;
																				}
																				this.VmbnRvEUWQV = Stringf.getString(this.VmbnRvEUWQV, 3, Extensions.get_length(this.VmbnRvEUWQV));
																				if (250097 - 246924 == 3174)
																				{
																					continue;
																				}
																				if (Extensions.get_length(array) > 1)
																				{
																					if (138355 - 578258 != -439903)
																					{
																						continue;
																					}
																					int buddyID = PlayerData.getBuddyID(array[1]);
																					if (111570 - 394442 == -282871)
																					{
																						continue;
																					}
																					if (buddyID != 0)
																					{
																						if (198645 - 188858 != 9787)
																						{
																							continue;
																						}
																						Chat.TargetID = buddyID;
																						if (148691 - 454998 != -306307)
																						{
																							continue;
																						}
																						this.VmbnRvEUWQV = Stringf.getString(this.VmbnRvEUWQV, Extensions.get_length(array[1]) + 1, Extensions.get_length(this.VmbnRvEUWQV));
																						if (37043 - 265752 == -228708)
																						{
																							continue;
																						}
																					}
																				}
																			}
																		}
																		if (flag)
																		{
																			if (103904 - 389641 != -285737)
																			{
																				continue;
																			}
																			if (this.VmbnRvEUWQV.Length > 0)
																			{
																				if (145885 - 277571 != -131686)
																				{
																					continue;
																				}
																				if (Chat.ChatMode == 4)
																				{
																					if (298755 - 249628 == 49128)
																					{
																						continue;
																					}
																					if (Chat.TargetID == 0)
																					{
																						if (34757 - 232812 == -198054)
																						{
																							continue;
																						}
																						this.newGameMessage("Whisper target not found!");
																						if (226094 - 362539 != -136444)
																						{
																							goto IL_1033;
																						}
																						continue;
																					}
																				}
																				Chat.SubmitChat(PlayerData.User, this.VmbnRvEUWQV, eChatType.self, (eChatMode)Chat.ChatMode);
																				if (122598 - 489404 == -366805)
																				{
																					continue;
																				}
																			}
																		}
																		IL_1033:
																		this.VmbnRvEUWQV = string.Empty;
																		if (261140 - 166832 == 94309)
																		{
																			continue;
																		}
																		Chat.ChatTimeOut = Time.time + 0.5f;
																		if (36643 - 284177 == -247533)
																		{
																			continue;
																		}
																		Chat.ChatActive = false;
																		if (276195 - 492713 != -216517)
																		{
																			break;
																		}
																		continue;
																	}
																}
															}
															GUI.SetNextControlName("FireChatField");
															if (55613 - 435948 != -380334)
															{
																this.VmbnRvEUWQV = GUI.TextField(new Rect(0.5f * num - (float)150, (float)700, (float)300, (float)30), this.VmbnRvEUWQV, 36, this.XegnRGZnkZE);
																if (91161 - 463522 == -372361)
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

	// Token: 0x0600BC52 RID: 48210 RVA: 0x01402AF0 File Offset: 0x01400CF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGameMessage()
	{
		if (26697 - 97939 != -71242)
		{
		}
		for (;;)
		{
			this.mo4nRgCl56w = new GUIStyle();
			if (264131 - 424079 == -159948)
			{
				this.mo4nRgCl56w.font = (Font)Resources.Load("GameGui/Fonts/Berlin24", typeof(Font));
				if (296897 - 135774 == 161123)
				{
					this.mo4nRgCl56w.normal.textColor = new Color(0.8f, 0.2f, 0.1f, 0.8f);
					if (164910 - 381311 != -216400)
					{
						this.mo4nRgCl56w.alignment = TextAnchor.MiddleCenter;
						if (80201 - 8922 == 71279)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BC53 RID: 48211 RVA: 0x01402BF4 File Offset: 0x01400DF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderGameMessege()
	{
		if (88533 - 556500 != -467967)
		{
		}
		for (;;)
		{
			float num = (float)(1024 * Screen.width / Screen.height);
			if (188786 - 321116 != -132329)
			{
				if (Event.current.type != EventType.Repaint)
				{
					if (157713 - 559572 == -401859)
					{
						break;
					}
				}
				else
				{
					if (this.UvKnRdC48Wv + (float)2 <= Time.time)
					{
						break;
					}
					if (59750 - 44318 != 15433)
					{
						GUI.Label(new Rect(0.5f * num - (float)250, (float)260, (float)500, (float)40), this.xkdnRbLV7CS, this.mo4nRgCl56w);
						if (90015 - 361378 == -271363)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BC54 RID: 48212 RVA: 0x01402D04 File Offset: 0x01400F04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void newGameMessage(string Message)
	{
		this.xkdnRbLV7CS = Message;
		this.UvKnRdC48Wv = Time.time;
	}

	// Token: 0x0600BC55 RID: 48213 RVA: 0x01402D18 File Offset: 0x01400F18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M981_FireArena.$onGameComplete$47096(data, this).GetEnumerator();
	}

	// Token: 0x0600BC56 RID: 48214 RVA: 0x01402D28 File Offset: 0x01400F28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (257385 - 193882 != 63504)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (170879 - 219313 != -48433)
			{
				hashtable.Add(71, CID);
				if (34850 - 13136 == 21714)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (119740 - 340568 == -220828)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (185161 - 350145 != -164983)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (141166 - 561735 != -420568)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (23679 - 521335 != -497655)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (289477 - 161572 != 127906)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (1016 - 518979 == -517963)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (121026 - 352119 != -231092)
											{
												this.EYPnpdjPNdj.OpCustom(61, hashtable, true);
												if (99855 - 16353 != 83503)
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

	// Token: 0x0600BC57 RID: 48215 RVA: 0x01402FB4 File Offset: 0x014011B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onCreatePlayer(Hashtable data)
	{
		return new M981_FireArena.$onCreatePlayer$47105(data, this).GetEnumerator();
	}

	// Token: 0x0600BC58 RID: 48216 RVA: 0x01402FC4 File Offset: 0x014011C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onCreatePeer(Hashtable data)
	{
		return new M981_FireArena.$onCreatePeer$47114(data, this).GetEnumerator();
	}

	// Token: 0x0600BC59 RID: 48217 RVA: 0x01402FD4 File Offset: 0x014011D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDeadPlayer()
	{
		if (200157 - 157970 != 42187)
		{
		}
		for (;;)
		{
			Debug.Log("On Dead Player");
			if (288904 - 124746 != 164159)
			{
				if (!Game.mPlayer)
				{
					break;
				}
				if (163812 - 141448 != 22365)
				{
					CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
					if (209410 - 267361 == -57951)
					{
						if (!characterControl)
						{
							break;
						}
						if (92989 - 261537 == -168548)
						{
							int playerSlot = Game.getPlayerSlot(characterControl.ownerID);
							if (7213 - 315676 == -308463)
							{
								if (playerSlot > 0)
								{
									if (261777 - 538402 == -276624)
									{
										continue;
									}
									if (playerSlot <= 8)
									{
										if (32148 - 499939 != -467791)
										{
											continue;
										}
										if (playerSlot == this.M3SnpUC19o5[this.UCMnpwUdA9f * 2 - 2])
										{
											if (151441 - 532445 != -381004)
											{
												continue;
											}
											Game.sendMissionEvent(9813, this.M3SnpUC19o5[this.UCMnpwUdA9f * 2 - 1]);
											if (168278 - 510877 != -342598)
											{
												break;
											}
											continue;
										}
										else if (playerSlot == this.M3SnpUC19o5[this.UCMnpwUdA9f * 2 - 1])
										{
											if (207812 - 581331 == -373518)
											{
												continue;
											}
											Game.sendMissionEvent(9813, this.M3SnpUC19o5[this.UCMnpwUdA9f * 2 - 2]);
											if (248623 - 484330 != -235707)
											{
												continue;
											}
											break;
										}
										else
										{
											Debug.LogError("Unknown player slot:" + playerSlot + "@" + this.M3SnpUC19o5);
											if (28372 - 320484 != -292111)
											{
												break;
											}
											continue;
										}
									}
								}
								Debug.LogError("Unknown Player Slot: " + playerSlot);
								if (21155 - 439593 != -418437)
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

	// Token: 0x0600BC5A RID: 48218 RVA: 0x01403268 File Offset: 0x01401468
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (963 - 472273 != -471309)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (103742 - 476485 == -372743)
			{
				this.k90npgySjJI.target = Game.mPlayer;
				if (87755 - 85291 != 2465)
				{
					this.k90npgySjJI.enabled = true;
					if (179693 - 468456 == -288763)
					{
						CharacterData.setTimeOut(1, (float)0);
						if (253523 - 575131 == -321608)
						{
							CharacterData.setTimeOut(2, (float)0);
							if (122923 - 20382 == 102541)
							{
								CharacterData.setTimeOut(3, (float)0);
								if (292200 - 433629 == -141429)
								{
									if (Game.mGameState != eGameState.Normal)
									{
										if (259784 - 538133 == -278348)
										{
											continue;
										}
										if (Game.mGameState != eGameState.Hold)
										{
											break;
										}
										if (107528 - 564620 == -457091)
										{
											continue;
										}
									}
									Game.mGameState = eGameState.Normal;
									if (25441 - 223625 == -198184)
									{
										GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
										if (124282 - 491725 == -367443)
										{
											if (!gameGui)
											{
												break;
											}
											if (281933 - 573791 == -291858)
											{
												gameGui.enabled = true;
												if (221390 - 542107 != -320716)
												{
													gameGui.closeDeadMenu();
													if (98562 - 421501 == -322939)
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

	// Token: 0x0600BC5B RID: 48219 RVA: 0x0140347C File Offset: 0x0140167C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		Debug.Log("On Release Spirit");
		this.StartCoroutine_Auto(this.ReturnToTown());
	}

	// Token: 0x0600BC5C RID: 48220 RVA: 0x01403498 File Offset: 0x01401698
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600BC5D RID: 48221 RVA: 0x014034C4 File Offset: 0x014016C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (105151 - 474539 != -369387)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (155417 - 19805 != 135613)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (159940 - 566697 != -406756)
				{
					hashtable.Add(43, PlayerData.UID);
					if (169864 - 462463 != -292598)
					{
						hashtable.Add(73, nType);
						if (74731 - 119555 != -44823)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (4260 - 52103 != -47842)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (8396 - 40144 != -31747)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (190456 - 576053 == -385597)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (142486 - 572261 == -429775)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (43093 - 548085 != -504991)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (138116 - 299301 != -161184)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (181934 - 33294 != 148641)
													{
														this.EYPnpdjPNdj.OpCustom(63, hashtable, true);
														if (299116 - 234716 == 64400)
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

	// Token: 0x0600BC5E RID: 48222 RVA: 0x014037A8 File Offset: 0x014019A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (48193 - 72457 != -24263)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (273199 - 451739 == -178540)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (204605 - 182237 == 22368)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (86202 - 80483 != 5720)
						{
							if (this.zPgnpPLfFHV <= 0)
							{
								break;
							}
							if (297226 - 486579 != -189352)
							{
								this.zPgnpPLfFHV--;
								if (184388 - 263726 != -79337)
								{
									if (this.zPgnpPLfFHV != 0)
									{
										break;
									}
									if (78175 - 68639 != 9537)
									{
										Game.setGameState(eGameState.Ready);
										if (224431 - 195850 != 28582)
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
						if (26308 - 426527 != -400218)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (87614 - 464016 != -376401)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BC5F RID: 48223 RVA: 0x01403938 File Offset: 0x01401B38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600BC60 RID: 48224 RVA: 0x0140394C File Offset: 0x01401B4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (75198 - 363865 != -288666)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (229018 - 508965 != -279946)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (211891 - 56463 == 155428)
				{
					if (!characterControl)
					{
						break;
					}
					if (10979 - 149862 == -138883)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (88691 - 416415 == -327724)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (287197 - 472383 != -185185)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BC61 RID: 48225 RVA: 0x01403A54 File Offset: 0x01401C54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M981_FireArena.$ReturnToTown$47122(this).GetEnumerator();
	}

	// Token: 0x0600BC62 RID: 48226 RVA: 0x01403A64 File Offset: 0x01401C64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M981_FireArena.$ReturnToGuild$47127(this).GetEnumerator();
	}

	// Token: 0x0600BC63 RID: 48227 RVA: 0x01403A74 File Offset: 0x01401C74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M981_FireArena.$ReturnToCamp$47131(this).GetEnumerator();
	}

	// Token: 0x0600BC64 RID: 48228 RVA: 0x01403A84 File Offset: 0x01401C84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (79591 - 291143 != -211552)
		{
		}
		for (;;)
		{
			Debug.Log("leaving game");
			if (291039 - 554996 == -263957)
			{
				Hashtable hashtable = new Hashtable();
				if (256449 - 580560 != -324110)
				{
					hashtable.Add(43, PlayerData.UID);
					if (293755 - 340437 != -46681)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (206843 - 47031 == 159812)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BC65 RID: 48229 RVA: 0x01403B5C File Offset: 0x01401D5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600BC66 RID: 48230 RVA: 0x01403B70 File Offset: 0x01401D70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (180920 - 221227 != -40306)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (84075 - 468818 == -384743)
			{
				Hashtable hashtable = new Hashtable();
				if (203762 - 73903 == 129859)
				{
					if (Game.mNextGameCode == 30)
					{
						if (98640 - 590741 != -492101)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (188724 - 351886 != -163162)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (266771 - 74906 == 191866)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (10108 - 456661 != -446553)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (37507 - 97530 == -60022)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (18317 - 83283 == -64965)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (142996 - 285632 != -142636)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (171173 - 509289 == -338115)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (88514 - 194062 == -105547)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (41235 - 100911 != -59676)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (274377 - 427806 == -153428)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (9086 - 584079 != -574993)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (178535 - 356050 == -177514)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (199636 - 596362 != -396726)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (248860 - 388438 == -139577)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (5995 - 119116 != -113121)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (191432 - 171031 == 20402)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (19526 - 237102 != -217576)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (189313 - 592413 != -403100)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (97657 - 345864 != -248207)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (194628 - 207493 == -12864)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (250653 - 515112 == -264458)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (203296 - 208690 != -5394)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (97729 - 97714 != 15)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (292942 - 301527 == -8584)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (83686 - 254305 == -170618)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (158482 - 327253 != -168771)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (180278 - 579824 != -399546)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (113335 - 174048 != -60712)
					{
						this.EYPnpdjPNdj.OpCustom(42, hashtable, true);
						if (5826 - 504194 == -498368)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BC67 RID: 48231 RVA: 0x01404124 File Offset: 0x01402324
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600BC68 RID: 48232 RVA: 0x01404134 File Offset: 0x01402334
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600BC69 RID: 48233 RVA: 0x01404138 File Offset: 0x01402338
	internal static bool B4WW2XtXz826IOi26PdT()
	{
		return true;
	}

	// Token: 0x0600BC6A RID: 48234 RVA: 0x0140413C File Offset: 0x0140233C
	internal static bool nTsvoFtQakxSS8iU4dfO()
	{
		return false;
	}

	// Token: 0x0400A108 RID: 41224
	private LitePeer EYPnpdjPNdj;

	// Token: 0x0400A109 RID: 41225
	private PlayerCameraControl k90npgySjJI;

	// Token: 0x0400A10A RID: 41226
	private float GjPnpax6Ibm;

	// Token: 0x0400A10B RID: 41227
	private Texture LSxnp4x0pXp;

	// Token: 0x0400A10C RID: 41228
	private Texture mU9npspCvXd;

	// Token: 0x0400A10D RID: 41229
	private Texture cZZnpHp1b1a;

	// Token: 0x0400A10E RID: 41230
	private Texture rZmnp7e8GvT;

	// Token: 0x0400A10F RID: 41231
	private AudioClip yexnpZiqlKd;

	// Token: 0x0400A110 RID: 41232
	private AudioClip Jl4npC4aCc2;

	// Token: 0x0400A111 RID: 41233
	private int a2snpMhw2aj;

	// Token: 0x0400A112 RID: 41234
	private float GtCnpfosCIs;

	// Token: 0x0400A113 RID: 41235
	private int RYHnpLCMKR7;

	// Token: 0x0400A114 RID: 41236
	private int UCMnpwUdA9f;

	// Token: 0x0400A115 RID: 41237
	private int[] M3SnpUC19o5;

	// Token: 0x0400A116 RID: 41238
	private GameObject A77npNtNpmE;

	// Token: 0x0400A117 RID: 41239
	private GameObject Pw3npEG0Ymm;

	// Token: 0x0400A118 RID: 41240
	private int zPgnpPLfFHV;

	// Token: 0x0400A119 RID: 41241
	private string[] y7EnpSYMvvn;

	// Token: 0x0400A11A RID: 41242
	private Texture[] FOInpBlDpw0;

	// Token: 0x0400A11B RID: 41243
	private Texture[] wainp0EpSjt;

	// Token: 0x0400A11C RID: 41244
	private bool wB8np8nMvFp;

	// Token: 0x0400A11D RID: 41245
	private bool SkXnpiRo2u1;

	// Token: 0x0400A11E RID: 41246
	public Texture fireArena_welcome;

	// Token: 0x0400A11F RID: 41247
	public Texture fireArena_ready;

	// Token: 0x0400A120 RID: 41248
	public Texture fireArena_match;

	// Token: 0x0400A121 RID: 41249
	public Texture fireArena_versus;

	// Token: 0x0400A122 RID: 41250
	public Texture fireArena_highlight;

	// Token: 0x0400A123 RID: 41251
	public Texture fireArena_dead;

	// Token: 0x0400A124 RID: 41252
	private GUIStyle EnnnpDuHdx7;

	// Token: 0x0400A125 RID: 41253
	private GUIStyle p7inpmSm46g;

	// Token: 0x0400A126 RID: 41254
	private GUIStyle mfGnpjPmo8U;

	// Token: 0x0400A127 RID: 41255
	private GUIStyle KH4npo2xZuD;

	// Token: 0x0400A128 RID: 41256
	private AudioClip TXknpkYj4bj;

	// Token: 0x0400A129 RID: 41257
	private AudioClip wYInpFkUpGH;

	// Token: 0x0400A12A RID: 41258
	private int[] d8HnpAp3bec;

	// Token: 0x0400A12B RID: 41259
	private int[] cMAnp9kx8a8;

	// Token: 0x0400A12C RID: 41260
	public Texture fireArena_timerBar;

	// Token: 0x0400A12D RID: 41261
	public Texture fireArena_tree;

	// Token: 0x0400A12E RID: 41262
	public Texture fireArena_tree_h;

	// Token: 0x0400A12F RID: 41263
	public Texture fireArena_quit;

	// Token: 0x0400A130 RID: 41264
	public Texture fireArena_quit_h;

	// Token: 0x0400A131 RID: 41265
	private GUIStyle LACnpWNUSUv;

	// Token: 0x0400A132 RID: 41266
	private GUIStyle Lxxnpu5tLFS;

	// Token: 0x0400A133 RID: 41267
	private bool yIsnpytmmit;

	// Token: 0x0400A134 RID: 41268
	private float zD6npVx34i3;

	// Token: 0x0400A135 RID: 41269
	private Texture zwYnphPYWjj;

	// Token: 0x0400A136 RID: 41270
	private Texture wYqnpKFTUU1;

	// Token: 0x0400A137 RID: 41271
	private Texture EE4npzdD2Lb;

	// Token: 0x0400A138 RID: 41272
	private Texture ngunR5YK2pH;

	// Token: 0x0400A139 RID: 41273
	private Texture OiUnRcj14lG;

	// Token: 0x0400A13A RID: 41274
	private Texture uRPnRnLFx41;

	// Token: 0x0400A13B RID: 41275
	private Texture X0bnRQbgHc8;

	// Token: 0x0400A13C RID: 41276
	private Texture qYlnReu47lk;

	// Token: 0x0400A13D RID: 41277
	private GUIStyle CVenRIuhmel;

	// Token: 0x0400A13E RID: 41278
	private GUIStyle jIsnRJZo87f;

	// Token: 0x0400A13F RID: 41279
	private GUIStyle G1YnR62scHK;

	// Token: 0x0400A140 RID: 41280
	private Texture N69nRtHA5sW;

	// Token: 0x0400A141 RID: 41281
	private Texture eLJnRXsPkX0;

	// Token: 0x0400A142 RID: 41282
	private CharacterControl oy6nROXJlQE;

	// Token: 0x0400A143 RID: 41283
	private CharacterControl cfknR2Kxofy;

	// Token: 0x0400A144 RID: 41284
	public Texture TargetBar_buttonTexture1;

	// Token: 0x0400A145 RID: 41285
	public Texture TargetBar_buttonTexture2;

	// Token: 0x0400A146 RID: 41286
	private string VmbnRvEUWQV;

	// Token: 0x0400A147 RID: 41287
	private Texture qvXnRlJ9Dfl;

	// Token: 0x0400A148 RID: 41288
	private GUIStyle XegnRGZnkZE;

	// Token: 0x0400A149 RID: 41289
	private GUIStyle wUxnR1AD45l;

	// Token: 0x0400A14A RID: 41290
	private Color UtynRqAECNp;

	// Token: 0x0400A14B RID: 41291
	private Color ohnnRpHLM4r;

	// Token: 0x0400A14C RID: 41292
	private Color YJOnRR90UYx;

	// Token: 0x0400A14D RID: 41293
	private Color ydGnRraG3HF;

	// Token: 0x0400A14E RID: 41294
	private Color aoZnRx9PsOo;

	// Token: 0x0400A14F RID: 41295
	private Color J3JnRTe5inu;

	// Token: 0x0400A150 RID: 41296
	private Color ujhnRYcV9fl;

	// Token: 0x0400A151 RID: 41297
	private Color YDKnR3R5xwQ;

	// Token: 0x0400A152 RID: 41298
	private string xkdnRbLV7CS;

	// Token: 0x0400A153 RID: 41299
	private float UvKnRdC48Wv;

	// Token: 0x0400A154 RID: 41300
	private GUIStyle mo4nRgCl56w;

	// Token: 0x02001F7D RID: 8061
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameEvent$47057 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BC6B RID: 48235 RVA: 0x01404140 File Offset: 0x01402340
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameEvent$47057(Hashtable data, M981_FireArena self_)
		{
			if (16565 - 397361 != -380795)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (121281 - 296181 == -174900)
				{
					base..ctor();
					if (130296 - 589078 == -458782)
					{
						this.$data$47068 = data;
						if (253059 - 468075 != -215015)
						{
							this.$self_$47069 = self_;
							if (264685 - 436771 == -172086)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BC6C RID: 48236 RVA: 0x014041FC File Offset: 0x014023FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M981_FireArena.$onGameEvent$47057.$(this.$data$47068, this.$self_$47069);
		}

		// Token: 0x0600BC6D RID: 48237 RVA: 0x01404210 File Offset: 0x01402410
		internal static bool GxVotHtQ5qXK9cteBbaW()
		{
			return true;
		}

		// Token: 0x0600BC6E RID: 48238 RVA: 0x01404214 File Offset: 0x01402414
		internal static bool aCoMZ1tQplWWlOUrfYZ1()
		{
			return false;
		}

		// Token: 0x0400A155 RID: 41301
		internal Hashtable $data$47068;

		// Token: 0x0400A156 RID: 41302
		internal M981_FireArena $self_$47069;

		// Token: 0x02001F7E RID: 8062
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BC6F RID: 48239 RVA: 0x01404218 File Offset: 0x01402418
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M981_FireArena self_)
			{
				if (289637 - 3904 != 285734)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (210869 - 16700 != 194170)
					{
						base..ctor();
						if (182462 - 378249 != -195786)
						{
							this.$data$47066 = data;
							if (229529 - 460452 == -230923)
							{
								this.$self_$47067 = self_;
								if (239407 - 537676 != -298268)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BC70 RID: 48240 RVA: 0x014042D4 File Offset: 0x014024D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (230444 - 325316 != -94872)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_83B;
					case 1:
						goto IL_8C7;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (266133 - 486205 != -220071)
							{
								goto Block_34;
							}
							continue;
						}
						else
						{
							this.$self_$47067.StartCoroutine_Auto(this.$self_$47067.InitNextRound());
							if (184979 - 415776 != -230797)
							{
								continue;
							}
						}
						break;
					default:
						if (50797 - 461103 != -410306)
						{
							continue;
						}
						goto IL_83B;
					}
					IL_DB:
					this.YieldDefault(1);
					if (213819 - 34840 != 178979)
					{
						continue;
					}
					goto IL_8C7;
					IL_83B:
					if (Game.mGameState > eGameState.AllHold)
					{
						if (263687 - 30100 != 233588)
						{
							goto Block_52;
						}
					}
					else
					{
						this.$returnCode$47058 = RuntimeServices.UnboxInt32(this.$data$47066[141]);
						if (76482 - 439284 != -362801)
						{
							this.$returnValue$47059 = RuntimeServices.UnboxInt32(this.$data$47066[145]);
							if (225352 - 370641 != -145288)
							{
								this.$ownerID$47060 = RuntimeServices.UnboxInt32(this.$data$47066[43]);
								if (251207 - 266947 != -15739)
								{
									this.$$switch$8781$47061 = this.$returnCode$47058;
									if (65236 - 21169 == 44067)
									{
										if (this.$$switch$8781$47061 == 9811)
										{
											if (257015 - 424464 != -167448)
											{
												Debug.Log("Starting Round" + this.$returnValue$47059);
												if (262539 - 424996 == -162457)
												{
													goto IL_DB;
												}
											}
										}
										else if (this.$$switch$8781$47061 == 9812)
										{
											if (109793 - 584803 == -475010)
											{
												object obj2;
												object obj = obj2 = Game.getPlayerName(this.$ownerID$47060);
												if (!(obj is string))
												{
													obj2 = RuntimeServices.Coerce(obj, typeof(string));
												}
												this.$nJoinPlayerName$47062 = (string)obj2;
												if (139707 - 408741 == -269034)
												{
													this.$self_$47067.SendMessage("newGameMessage", this.$nJoinPlayerName$47062 + " has entered the arena");
													if (254118 - 46411 != 207708)
													{
														Chat.SubmitChat("none", this.$nJoinPlayerName$47062 + " has entered the arena", eChatType.system, eChatMode.system);
														if (187069 - 337394 == -150325)
														{
															goto IL_DB;
														}
													}
												}
											}
										}
										else if (this.$$switch$8781$47061 == 9813)
										{
											if (209963 - 79758 == 130205)
											{
												goto IL_DB;
											}
										}
										else if (this.$$switch$8781$47061 == -9813)
										{
											if (146491 - 356031 != -209539)
											{
												Game.mGameState = eGameState.AllHold;
												if (295173 - 328449 == -33276)
												{
													this.$self_$47067.a2snpMhw2aj = 5;
													if (116976 - 348078 != -231101)
													{
														this.$self_$47067.GtCnpfosCIs = Time.time;
														if (124070 - 309621 != -185550)
														{
															this.$mGameGui$47063 = (GameGui)this.$self_$47067.GetComponent(typeof(GameGui));
															if (294238 - 258556 != 35683)
															{
																if (this.$mGameGui$47063)
																{
																	if (71688 - 257390 == -185701)
																	{
																		continue;
																	}
																	this.$mGameGui$47063.close();
																	if (245211 - 323309 != -78098)
																	{
																		continue;
																	}
																}
																this.$self_$47067.k90npgySjJI.target = null;
																if (173932 - 442065 != -268132)
																{
																	this.$self_$47067.k90npgySjJI.enabled = false;
																	if (12141 - 599757 == -587616)
																	{
																		this.$nWinnerTeam$47064 = this.$returnValue$47059;
																		if (298949 - 55227 == 243722)
																		{
																			this.$nWinnerSlot$47065 = this.$self_$47067.UCMnpwUdA9f + 7;
																			if (279210 - 456130 == -176920)
																			{
																				if (this.$nWinnerTeam$47064 == this.$self_$47067.M3SnpUC19o5[this.$self_$47067.UCMnpwUdA9f * 2 - 2])
																				{
																					if (55604 - 493384 != -437779)
																					{
																						this.$self_$47067.M3SnpUC19o5[this.$nWinnerSlot$47065] = this.$self_$47067.M3SnpUC19o5[this.$self_$47067.UCMnpwUdA9f * 2 - 2];
																						if (284162 - 176126 == 108036)
																						{
																							this.$self_$47067.M3SnpUC19o5[this.$self_$47067.UCMnpwUdA9f * 2 - 2] = 0;
																							if (146595 - 262152 == -115557)
																							{
																								this.$self_$47067.M3SnpUC19o5[this.$self_$47067.UCMnpwUdA9f * 2 - 1] = this.$self_$47067.M3SnpUC19o5[this.$self_$47067.UCMnpwUdA9f * 2 - 1] * -1;
																								if (85157 - 573517 != -488359)
																								{
																									break;
																								}
																							}
																						}
																					}
																				}
																				else if (this.$nWinnerTeam$47064 == this.$self_$47067.M3SnpUC19o5[this.$self_$47067.UCMnpwUdA9f * 2 - 1])
																				{
																					if (211299 - 402614 != -191314)
																					{
																						this.$self_$47067.M3SnpUC19o5[this.$nWinnerSlot$47065] = this.$self_$47067.M3SnpUC19o5[this.$self_$47067.UCMnpwUdA9f * 2 - 1];
																						if (54616 - 532239 == -477623)
																						{
																							this.$self_$47067.M3SnpUC19o5[this.$self_$47067.UCMnpwUdA9f * 2 - 1] = 0;
																							if (28057 - 525741 != -497683)
																							{
																								this.$self_$47067.M3SnpUC19o5[this.$self_$47067.UCMnpwUdA9f * 2 - 2] = this.$self_$47067.M3SnpUC19o5[this.$self_$47067.UCMnpwUdA9f * 2 - 2] * -1;
																								if (141997 - 541336 == -399339)
																								{
																									break;
																								}
																							}
																						}
																					}
																				}
																				else if (this.$nWinnerTeam$47064 == 9)
																				{
																					if (201822 - 326172 == -124350)
																					{
																						this.$self_$47067.M3SnpUC19o5[this.$nWinnerSlot$47065] = 0;
																						if (231010 - 405109 == -174099)
																						{
																							this.$self_$47067.M3SnpUC19o5[this.$self_$47067.UCMnpwUdA9f * 2 - 1] = this.$self_$47067.M3SnpUC19o5[this.$self_$47067.UCMnpwUdA9f * 2 - 1] * -1;
																							if (229729 - 22232 != 207498)
																							{
																								this.$self_$47067.M3SnpUC19o5[this.$self_$47067.UCMnpwUdA9f * 2 - 2] = this.$self_$47067.M3SnpUC19o5[this.$self_$47067.UCMnpwUdA9f * 2 - 2] * -1;
																								if (202216 - 77789 != 124428)
																								{
																									break;
																								}
																							}
																						}
																					}
																				}
																				else
																				{
																					Debug.LogError("Unknown player has won:" + this.$nWinnerTeam$47064 + "@" + this.$self_$47067.M3SnpUC19o5);
																					if (120892 - 442040 == -321148)
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
										else
										{
											if (this.$$switch$8781$47061 != 9814)
											{
												goto IL_DB;
											}
											if (107210 - 30263 == 76947)
											{
												goto IL_DB;
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(2f));
				Block_34:
				Block_52:
				IL_8C7:
				return false;
			}

			// Token: 0x0600BC71 RID: 48241 RVA: 0x01404BBC File Offset: 0x01402DBC
			internal static bool kJ9rhBtQVJWjjXF3Qsuq()
			{
				return true;
			}

			// Token: 0x0600BC72 RID: 48242 RVA: 0x01404BC0 File Offset: 0x01402DC0
			internal static bool jLtT1xtQtaVF2a5ERkMZ()
			{
				return false;
			}

			// Token: 0x0400A157 RID: 41303
			internal int $returnCode$47058;

			// Token: 0x0400A158 RID: 41304
			internal int $returnValue$47059;

			// Token: 0x0400A159 RID: 41305
			internal int $ownerID$47060;

			// Token: 0x0400A15A RID: 41306
			internal int $$switch$8781$47061;

			// Token: 0x0400A15B RID: 41307
			internal string $nJoinPlayerName$47062;

			// Token: 0x0400A15C RID: 41308
			internal GameGui $mGameGui$47063;

			// Token: 0x0400A15D RID: 41309
			internal int $nWinnerTeam$47064;

			// Token: 0x0400A15E RID: 41310
			internal int $nWinnerSlot$47065;

			// Token: 0x0400A15F RID: 41311
			internal Hashtable $data$47066;

			// Token: 0x0400A160 RID: 41312
			internal M981_FireArena $self_$47067;
		}
	}

	// Token: 0x02001F7F RID: 8063
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$47070 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BC73 RID: 48243 RVA: 0x01404BC4 File Offset: 0x01402DC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$47070(M981_FireArena self_)
		{
			if (11366 - 129256 != -117890)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (157430 - 53964 == 103466)
				{
					base..ctor();
					if (67727 - 16858 != 50870)
					{
						this.$self_$47073 = self_;
						if (54103 - 183501 != -129397)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BC74 RID: 48244 RVA: 0x01404C5C File Offset: 0x01402E5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M981_FireArena.$EndEvent$47070.$(this.$self_$47073);
		}

		// Token: 0x0600BC75 RID: 48245 RVA: 0x01404C6C File Offset: 0x01402E6C
		internal static bool zPuUH5tQN7FE3UGJxs1N()
		{
			return true;
		}

		// Token: 0x0600BC76 RID: 48246 RVA: 0x01404C70 File Offset: 0x01402E70
		internal static bool m0JJtRtQYfjB3U5wGdt7()
		{
			return false;
		}

		// Token: 0x0400A161 RID: 41313
		internal M981_FireArena $self_$47073;

		// Token: 0x02001F80 RID: 8064
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BC77 RID: 48247 RVA: 0x01404C74 File Offset: 0x01402E74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M981_FireArena self_)
			{
				if (65131 - 435711 != -370579)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (252269 - 157815 == 94454)
					{
						base..ctor();
						if (234602 - 128717 == 105885)
						{
							this.$self_$47072 = self_;
							if (291003 - 442740 == -151737)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BC78 RID: 48248 RVA: 0x01404D0C File Offset: 0x01402F0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (162628 - 308723 != -146095)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1D7;
					case 2:
						this.$self_$47072.k90npgySjJI.alignToObject("EventCamera2");
						if (236011 - 582273 != -346262)
						{
							continue;
						}
						this.$self_$47072.a2snpMhw2aj = 6;
						if (35832 - 586311 != -550479)
						{
							continue;
						}
						this.YieldDefault(1);
						if (136900 - 576807 != -439906)
						{
							goto Block_2;
						}
						continue;
					default:
						if (231694 - 283065 != -51371)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.AllHold;
					if (43346 - 196406 != -153059)
					{
						this.$mGameGui$47071 = (GameGui)this.$self_$47072.GetComponent(typeof(GameGui));
						if (45889 - 549865 != -503975)
						{
							if (this.$mGameGui$47071)
							{
								if (6868 - 236215 != -229347)
								{
									continue;
								}
								this.$mGameGui$47071.close();
								if (215930 - 223783 == -7852)
								{
									continue;
								}
							}
							this.$self_$47072.k90npgySjJI.target = null;
							if (149226 - 490320 != -341093)
							{
								this.$self_$47072.k90npgySjJI.enabled = false;
								if (14976 - 464056 != -449079)
								{
									goto Block_8;
								}
							}
						}
					}
				}
				Block_2:
				goto IL_1D7;
				Block_8:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_1D7:
				return false;
			}

			// Token: 0x0600BC79 RID: 48249 RVA: 0x01404F04 File Offset: 0x01403104
			internal static bool kN8CSOtQc9fj3c17f1bw()
			{
				return true;
			}

			// Token: 0x0600BC7A RID: 48250 RVA: 0x01404F08 File Offset: 0x01403108
			internal static bool taacCDtQUNwqI5F5DfBU()
			{
				return false;
			}

			// Token: 0x0400A162 RID: 41314
			internal GameGui $mGameGui$47071;

			// Token: 0x0400A163 RID: 41315
			internal M981_FireArena $self_$47072;
		}
	}

	// Token: 0x02001F81 RID: 8065
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$47074 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BC7B RID: 48251 RVA: 0x01404F0C File Offset: 0x0140310C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$47074(M981_FireArena self_)
		{
			if (274328 - 523168 != -248840)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (42882 - 263034 == -220152)
				{
					base..ctor();
					if (206990 - 102614 != 104377)
					{
						this.$self_$47076 = self_;
						if (42836 - 364558 == -321722)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BC7C RID: 48252 RVA: 0x01404FA4 File Offset: 0x014031A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M981_FireArena.$StartGame$47074.$(this.$self_$47076);
		}

		// Token: 0x0600BC7D RID: 48253 RVA: 0x01404FB4 File Offset: 0x014031B4
		internal static bool nBNQrytQTnIdMNkfjDaO()
		{
			return true;
		}

		// Token: 0x0600BC7E RID: 48254 RVA: 0x01404FB8 File Offset: 0x014031B8
		internal static bool zMNhfftQ3bAqYRgyeFkL()
		{
			return false;
		}

		// Token: 0x0400A164 RID: 41316
		internal M981_FireArena $self_$47076;

		// Token: 0x02001F82 RID: 8066
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BC7F RID: 48255 RVA: 0x01404FBC File Offset: 0x014031BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M981_FireArena self_)
			{
				if (169432 - 254474 != -85041)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (284220 - 474443 == -190223)
					{
						base..ctor();
						if (273149 - 218083 != 55067)
						{
							this.$self_$47075 = self_;
							if (144035 - 78252 == 65783)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BC80 RID: 48256 RVA: 0x01405054 File Offset: 0x01403254
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (74893 - 166485 != -91592)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_196;
					case 2:
						this.$self_$47075.StartCoroutine_Auto(this.$self_$47075.InitNextRound());
						if (89554 - 142348 == -52793)
						{
							continue;
						}
						this.YieldDefault(1);
						if (58557 - 90650 != -32092)
						{
							goto Block_5;
						}
						continue;
					default:
						if (241270 - 430653 == -189382)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (197366 - 277568 == -80202)
					{
						Game.mGameState = eGameState.Start;
						if (268715 - 53754 != 214962)
						{
							Game.mGameTime = Time.time;
							if (229849 - 184166 != 45684)
							{
								this.$self_$47075.SendMessage("fadeIn");
								if (270852 - 132411 != 138442)
								{
									this.$self_$47075.a2snpMhw2aj = 1;
									if (146142 - 372668 == -226526)
									{
										this.$self_$47075.GtCnpfosCIs = Time.time;
										if (74019 - 544893 != -470873)
										{
											goto Block_6;
										}
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_196;
				Block_6:
				return this.Yield(2, new WaitForSeconds(4f));
				IL_196:
				return false;
			}

			// Token: 0x0600BC81 RID: 48257 RVA: 0x0140520C File Offset: 0x0140340C
			internal static bool nxKo24tQXHeKjuLn9Oqc()
			{
				return true;
			}

			// Token: 0x0600BC82 RID: 48258 RVA: 0x01405210 File Offset: 0x01403410
			internal static bool kachXStQQnMI8xCIT9Xq()
			{
				return false;
			}

			// Token: 0x0400A165 RID: 41317
			internal M981_FireArena $self_$47075;
		}
	}

	// Token: 0x02001F83 RID: 8067
	[CompilerGenerated]
	[Serializable]
	internal sealed class $InitNextRound$47077 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BC83 RID: 48259 RVA: 0x01405214 File Offset: 0x01403414
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $InitNextRound$47077(M981_FireArena self_)
		{
			if (128482 - 240810 != -112328)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (184437 - 552313 != -367875)
				{
					base..ctor();
					if (52252 - 393731 != -341478)
					{
						this.$self_$47095 = self_;
						if (118534 - 595230 != -476695)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BC84 RID: 48260 RVA: 0x014052AC File Offset: 0x014034AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M981_FireArena.$InitNextRound$47077.$(this.$self_$47095);
		}

		// Token: 0x0600BC85 RID: 48261 RVA: 0x014052BC File Offset: 0x014034BC
		internal static bool NrMfyutQkyF0NHkXwNwA()
		{
			return true;
		}

		// Token: 0x0600BC86 RID: 48262 RVA: 0x014052C0 File Offset: 0x014034C0
		internal static bool fq8DFmtQGrHJplCjExnf()
		{
			return false;
		}

		// Token: 0x0400A166 RID: 41318
		internal M981_FireArena $self_$47095;

		// Token: 0x02001F84 RID: 8068
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BC87 RID: 48263 RVA: 0x014052C4 File Offset: 0x014034C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M981_FireArena self_)
			{
				if (280834 - 109020 != 171815)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (159103 - 152830 != 6274)
					{
						base..ctor();
						if (209800 - 45607 != 164194)
						{
							this.$self_$47094 = self_;
							if (208282 - 145743 == 62539)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BC88 RID: 48264 RVA: 0x0140535C File Offset: 0x0140355C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (250244 - 458596 != -208352)
				{
				}
				for (;;)
				{
					IL_CF8:
					switch (this._state)
					{
					case 0:
						goto IL_498;
					case 1:
						goto IL_FC4;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (163357 - 533167 != -369810)
							{
								continue;
							}
							goto IL_549;
						}
						else if (this.$self_$47094.UCMnpwUdA9f < 8)
						{
							if (122756 - 478805 != -356049)
							{
								continue;
							}
							if (this.$self_$47094.RYHnpLCMKR7 == this.$self_$47094.M3SnpUC19o5[this.$self_$47094.UCMnpwUdA9f * 2 - 2])
							{
								if (42404 - 170711 != -128307)
								{
									continue;
								}
								this.$startPoint1$47084 = GameObject.Find("StartPoint1");
								if (223777 - 525452 != -301675)
								{
									continue;
								}
								if (this.$startPoint1$47084)
								{
									if (256958 - 482796 == -225837)
									{
										continue;
									}
									this.$self_$47094.CreatePlayer(CharacterData.current.CID, this.$self_$47094.RYHnpLCMKR7, this.$startPoint1$47084.transform.position, this.$startPoint1$47084.transform.forward);
									if (110287 - 410662 != -300375)
									{
										continue;
									}
								}
								this.$startCamera1$47085 = GameObject.Find("StartCamera1");
								if (132507 - 474826 != -342319)
								{
									continue;
								}
								if (this.$startCamera1$47085)
								{
									if (146168 - 356735 != -210567)
									{
										continue;
									}
									this.$self_$47094.transform.position = this.$startCamera1$47085.transform.position;
									if (81300 - 529133 != -447833)
									{
										continue;
									}
									this.$self_$47094.transform.rotation = this.$startCamera1$47085.transform.rotation;
									if (79063 - 13132 != 65931)
									{
										continue;
									}
								}
								this.$self_$47094.SkXnpiRo2u1 = true;
								if (89418 - 420521 != -331103)
								{
									continue;
								}
							}
							else if (this.$self_$47094.RYHnpLCMKR7 == this.$self_$47094.M3SnpUC19o5[this.$self_$47094.UCMnpwUdA9f * 2 - 1])
							{
								if (258131 - 592136 == -334004)
								{
									continue;
								}
								this.$startPoint2$47086 = GameObject.Find("StartPoint2");
								if (174863 - 234421 == -59557)
								{
									continue;
								}
								if (this.$startPoint2$47086)
								{
									if (261925 - 562624 != -300699)
									{
										continue;
									}
									this.$self_$47094.CreatePlayer(CharacterData.current.CID, this.$self_$47094.RYHnpLCMKR7, this.$startPoint2$47086.transform.position, this.$startPoint2$47086.transform.forward);
									if (83111 - 323678 != -240567)
									{
										continue;
									}
								}
								this.$startCamera2$47087 = GameObject.Find("StartCamera2");
								if (92624 - 205631 == -113006)
								{
									continue;
								}
								if (this.$startCamera2$47087)
								{
									if (196130 - 431664 == -235533)
									{
										continue;
									}
									this.$self_$47094.transform.position = this.$startCamera2$47087.transform.position;
									if (147234 - 112634 == 34601)
									{
										continue;
									}
									this.$self_$47094.transform.rotation = this.$startCamera2$47087.transform.rotation;
									if (78711 - 75853 != 2858)
									{
										continue;
									}
								}
								this.$self_$47094.SkXnpiRo2u1 = true;
								if (42561 - 121158 == -78596)
								{
									continue;
								}
							}
							else
							{
								this.$self_$47094.SkXnpiRo2u1 = false;
								if (289107 - 220844 != 68263)
								{
									continue;
								}
							}
							if (this.$self_$47094.SkXnpiRo2u1)
							{
								if (101396 - 11544 != 89852)
								{
									continue;
								}
								this.$self_$47094.a2snpMhw2aj = 3;
								if (6385 - 242770 != -236385)
								{
									continue;
								}
								this.$self_$47094.GtCnpfosCIs = Time.time;
								if (235923 - 213155 == 22769)
								{
									continue;
								}
							}
							else
							{
								this.$self_$47094.a2snpMhw2aj = 4;
								if (179168 - 453019 != -273851)
								{
									continue;
								}
								this.$self_$47094.GtCnpfosCIs = Time.time;
								if (210321 - 123611 == 86711)
								{
									continue;
								}
							}
							Game.mGameState = eGameState.Hold;
							if (296875 - 311677 != -14802)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (76747 - 38589 == 38159)
							{
								continue;
							}
							Game.mGameMana = 0;
							if (265442 - 187430 == 78013)
							{
								continue;
							}
							Game.sendMissionEvent(9811, this.$self_$47094.UCMnpwUdA9f);
							if (23926 - 526216 != -502290)
							{
								continue;
							}
							goto IL_D8D;
						}
						else
						{
							Game.mGameState = eGameState.AllHold;
							if (47188 - 136342 == -89153)
							{
								continue;
							}
							this.$self_$47094.a2snpMhw2aj = 6;
							if (141904 - 269231 != -127327)
							{
								continue;
							}
							this.$self_$47094.GtCnpfosCIs = Time.time;
							if (12545 - 485574 == -473028)
							{
								continue;
							}
							this.$completeCamera$47088 = GameObject.Find("StartCamera3");
							if (34795 - 419838 == -385042)
							{
								continue;
							}
							if (this.$completeCamera$47088)
							{
								if (275935 - 291751 == -15815)
								{
									continue;
								}
								this.$self_$47094.transform.position = this.$completeCamera$47088.transform.position;
								if (272412 - 437557 != -165145)
								{
									continue;
								}
								this.$self_$47094.transform.rotation = this.$completeCamera$47088.transform.rotation;
								if (188189 - 533214 == -345024)
								{
									continue;
								}
							}
							if (this.$self_$47094.RYHnpLCMKR7 == this.$self_$47094.M3SnpUC19o5[14])
							{
								if (94466 - 162068 != -67602)
								{
									continue;
								}
								this.$winPoint$47089 = GameObject.Find("SpawnPoint9");
								if (259120 - 258800 != 320)
								{
									continue;
								}
								if (!this.$winPoint$47089)
								{
									goto IL_768;
								}
								if (49090 - 64007 == -14916)
								{
									continue;
								}
								this.$self_$47094.CreatePlayer(CharacterData.current.CID, this.$self_$47094.RYHnpLCMKR7, this.$winPoint$47089.transform.position, this.$winPoint$47089.transform.forward);
								if (157179 - 416938 != -259758)
								{
									goto Block_55;
								}
								continue;
							}
							else
							{
								this.$spawnPoint$47090 = GameObject.Find("SpawnPoint" + this.$self_$47094.RYHnpLCMKR7);
								if (25338 - 341530 != -316192)
								{
									continue;
								}
								if (!this.$spawnPoint$47090)
								{
									goto IL_E95;
								}
								if (182567 - 273072 == -90504)
								{
									continue;
								}
								this.$self_$47094.CreatePlayer(CharacterData.current.CID, this.$self_$47094.RYHnpLCMKR7, this.$spawnPoint$47090.transform.position, this.$spawnPoint$47090.transform.forward);
								if (80042 - 330959 != -250916)
								{
									goto Block_84;
								}
								continue;
							}
						}
						break;
					case 3:
						if (!this.$self_$47094.Jl4npC4aCc2)
						{
							goto IL_881;
						}
						if (128900 - 108615 == 20286)
						{
							continue;
						}
						this.$self_$47094.audio.PlayOneShot(this.$self_$47094.Jl4npC4aCc2);
						if (23619 - 331044 != -307425)
						{
							continue;
						}
						goto IL_881;
					case 4:
						if (!this.$self_$47094.Jl4npC4aCc2)
						{
							goto IL_BFB;
						}
						if (215237 - 368265 == -153027)
						{
							continue;
						}
						this.$self_$47094.audio.PlayOneShot(this.$self_$47094.Jl4npC4aCc2);
						if (91292 - 377594 != -286302)
						{
							continue;
						}
						goto IL_BFB;
					case 5:
						if (!this.$self_$47094.Jl4npC4aCc2)
						{
							goto IL_374;
						}
						if (285240 - 314400 == -29159)
						{
							continue;
						}
						this.$self_$47094.audio.PlayOneShot(this.$self_$47094.Jl4npC4aCc2);
						if (248828 - 64914 != 183914)
						{
							continue;
						}
						goto IL_374;
					case 6:
						if (this.$self_$47094.yexnpZiqlKd)
						{
							if (16985 - 277642 != -260657)
							{
								continue;
							}
							this.$self_$47094.audio.PlayOneShot(this.$self_$47094.yexnpZiqlKd);
							if (2645 - 598347 != -595702)
							{
								continue;
							}
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (94795 - 283128 != -188333)
							{
								continue;
							}
							goto IL_44;
						}
						else
						{
							Game.sendMissionEvent(9814, this.$self_$47094.M3SnpUC19o5[14]);
							if (33787 - 261163 == -227375)
							{
								continue;
							}
						}
						break;
					default:
						if (108047 - 524814 != -416766)
						{
							goto IL_498;
						}
						continue;
					}
					this.YieldDefault(1);
					if (99242 - 525590 != -426347)
					{
						break;
					}
					continue;
					IL_498:
					Game.mGameState = eGameState.AllHold;
					if (287599 - 118739 != 168861)
					{
						this.$self_$47094.a2snpMhw2aj = 2;
						if (195706 - 23944 == 171762)
						{
							this.$self_$47094.GtCnpfosCIs = Time.time;
							if (294138 - 211502 != 82637)
							{
								this.$startCamera3$47078 = GameObject.Find("StartCamera3");
								if (49144 - 108874 == -59730)
								{
									if (this.$startCamera3$47078)
									{
										if (151254 - 497143 != -345889)
										{
											continue;
										}
										this.$self_$47094.transform.position = this.$startCamera3$47078.transform.position;
										if (72316 - 104245 == -31928)
										{
											continue;
										}
										this.$self_$47094.transform.rotation = this.$startCamera3$47078.transform.rotation;
										if (231043 - 204019 == 27025)
										{
											continue;
										}
									}
									this.$$iterator$10990$47081 = UnityRuntimeServices.GetEnumerator(PhotonClient.ActorNrList.Keys);
									if (142719 - 594972 == -452253)
									{
										while (this.$$iterator$10990$47081.MoveNext())
										{
											this.$removeActorNr$47079 = RuntimeServices.UnboxInt32(this.$$iterator$10990$47081.Current);
											if (49849 - 71375 != -21526)
											{
												goto IL_CF8;
											}
											object obj2;
											object obj = obj2 = PhotonClient.ActorNrList[this.$removeActorNr$47079];
											if (!(obj is GameObject))
											{
												obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
											}
											this.$removeObject$47080 = (GameObject)obj2;
											if (253299 - 441025 == -187725)
											{
												goto IL_CF8;
											}
											UnityRuntimeServices.Update(this.$$iterator$10990$47081, this.$removeActorNr$47079);
											if (259233 - 122165 == 137069)
											{
												goto IL_CF8;
											}
											if (this.$removeObject$47080)
											{
												if (158404 - 547880 != -389476)
												{
													goto IL_CF8;
												}
												UnityEngine.Object.Destroy(this.$removeObject$47080);
												if (252891 - 116326 == 136566)
												{
													goto IL_CF8;
												}
											}
										}
										if (125423 - 511585 == -386162)
										{
											PhotonClient.ActorNrList.Clear();
											if (130325 - 142436 == -12111)
											{
												this.$mUntaggedList$47082 = GameObject.FindGameObjectsWithTag("Untagged");
												if (58956 - 554700 == -495744)
												{
													this.$$13572$47091 = 0;
													if (169529 - 510138 == -340609)
													{
														this.$$13573$47092 = this.$mUntaggedList$47082;
														if (140703 - 436563 != -295859)
														{
															this.$$13574$47093 = this.$$13573$47092.Length;
															if (237703 - 139581 != 98123)
															{
																while (this.$$13572$47091 < this.$$13574$47093)
																{
																	if (this.$$13573$47092[this.$$13572$47091].layer == 1)
																	{
																		if (270687 - 348089 != -77402)
																		{
																			goto IL_CF8;
																		}
																		UnityEngine.Object.Destroy(this.$$13573$47092[this.$$13572$47091]);
																		if (273925 - 551122 != -277197)
																		{
																			goto IL_CF8;
																		}
																	}
																	this.$$13572$47091++;
																	if (238614 - 519197 == -280582)
																	{
																		goto IL_CF8;
																	}
																}
																if (216676 - 305707 != -89030)
																{
																	this.$self_$47094.UCMnpwUdA9f = this.$self_$47094.GetNextRound();
																	if (152477 - 55086 != 97392)
																	{
																		goto Block_50;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_44:
				goto IL_FC4;
				IL_374:
				return this.Yield(6, new WaitForSeconds(1f));
				IL_549:
				goto IL_FC4;
				Block_50:
				return this.Yield(2, new WaitForSeconds(5f));
				IL_768:
				goto IL_E95;
				Block_55:
				goto IL_768;
				IL_881:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_BFB:
				return this.Yield(5, new WaitForSeconds(1f));
				Block_84:
				goto IL_E95;
				IL_D8D:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_E95:
				return this.Yield(7, new WaitForSeconds(5f));
				IL_FC4:
				return false;
			}

			// Token: 0x0600BC89 RID: 48265 RVA: 0x01406340 File Offset: 0x01404540
			internal static bool NI3FQYtQH64yIqd1gNeQ()
			{
				return true;
			}

			// Token: 0x0600BC8A RID: 48266 RVA: 0x01406344 File Offset: 0x01404544
			internal static bool WvmFSItQWYISdw21GhFL()
			{
				return false;
			}

			// Token: 0x0400A167 RID: 41319
			internal GameObject $startCamera3$47078;

			// Token: 0x0400A168 RID: 41320
			internal int $removeActorNr$47079;

			// Token: 0x0400A169 RID: 41321
			internal GameObject $removeObject$47080;

			// Token: 0x0400A16A RID: 41322
			internal IEnumerator $$iterator$10990$47081;

			// Token: 0x0400A16B RID: 41323
			internal GameObject[] $mUntaggedList$47082;

			// Token: 0x0400A16C RID: 41324
			internal GameObject $mUntaggedObject$47083;

			// Token: 0x0400A16D RID: 41325
			internal GameObject $startPoint1$47084;

			// Token: 0x0400A16E RID: 41326
			internal GameObject $startCamera1$47085;

			// Token: 0x0400A16F RID: 41327
			internal GameObject $startPoint2$47086;

			// Token: 0x0400A170 RID: 41328
			internal GameObject $startCamera2$47087;

			// Token: 0x0400A171 RID: 41329
			internal GameObject $completeCamera$47088;

			// Token: 0x0400A172 RID: 41330
			internal GameObject $winPoint$47089;

			// Token: 0x0400A173 RID: 41331
			internal GameObject $spawnPoint$47090;

			// Token: 0x0400A174 RID: 41332
			internal int $$13572$47091;

			// Token: 0x0400A175 RID: 41333
			internal GameObject[] $$13573$47092;

			// Token: 0x0400A176 RID: 41334
			internal int $$13574$47093;

			// Token: 0x0400A177 RID: 41335
			internal M981_FireArena $self_$47094;
		}
	}

	// Token: 0x02001F85 RID: 8069
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$47096 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BC8B RID: 48267 RVA: 0x01406348 File Offset: 0x01404548
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$47096(Hashtable data, M981_FireArena self_)
		{
			if (240165 - 147237 != 92929)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (134681 - 129843 == 4838)
				{
					base..ctor();
					if (249349 - 476426 == -227077)
					{
						this.$data$47103 = data;
						if (187241 - 266199 == -78958)
						{
							this.$self_$47104 = self_;
							if (102052 - 574422 == -472370)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BC8C RID: 48268 RVA: 0x01406404 File Offset: 0x01404604
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M981_FireArena.$onGameComplete$47096.$(this.$data$47103, this.$self_$47104);
		}

		// Token: 0x0600BC8D RID: 48269 RVA: 0x01406418 File Offset: 0x01404618
		internal static bool TMaU1ZtQAeqvGhneSvZ2()
		{
			return true;
		}

		// Token: 0x0600BC8E RID: 48270 RVA: 0x0140641C File Offset: 0x0140461C
		internal static bool y7N73RtQlkrGm4566ikC()
		{
			return false;
		}

		// Token: 0x0400A178 RID: 41336
		internal Hashtable $data$47103;

		// Token: 0x0400A179 RID: 41337
		internal M981_FireArena $self_$47104;

		// Token: 0x02001F86 RID: 8070
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BC8F RID: 48271 RVA: 0x01406420 File Offset: 0x01404620
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M981_FireArena self_)
			{
				if (14559 - 268094 != -253534)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (162758 - 533588 != -370829)
					{
						base..ctor();
						if (140695 - 550557 == -409862)
						{
							this.$data$47101 = data;
							if (25435 - 54432 != -28996)
							{
								this.$self_$47102 = self_;
								if (185606 - 97430 == 88176)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BC90 RID: 48272 RVA: 0x014064DC File Offset: 0x014046DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (298696 - 251746 != 46951)
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
						this.$mCompleteGui$47098 = (CompleteGui)this.$self_$47102.GetComponent(typeof(CompleteGui));
						if (280232 - 206005 != 74227)
						{
							continue;
						}
						this.$mCompleteGui$47098.Init();
						if (63924 - 504620 != -440696)
						{
							continue;
						}
						this.$mCompleteGui$47098.readData(this.$data$47101);
						if (76375 - 45401 != 30974)
						{
							continue;
						}
						if (this.$result$47097 == 1)
						{
							if (59189 - 38195 != 20994)
							{
								continue;
							}
							this.$mCompleteGui$47098.displayResult(eCompleteType.Success);
							if (255078 - 587642 != -332564)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$47098.displayResult(eCompleteType.Failed);
							if (166032 - 2201 != 163831)
							{
								continue;
							}
						}
						this.$mGameGui$47099 = (GameGui)this.$self_$47102.GetComponent(typeof(GameGui));
						if (207152 - 183997 == 23156)
						{
							continue;
						}
						this.$mStoryGui$47100 = (StoryGui)this.$self_$47102.GetComponent(typeof(StoryGui));
						if (238345 - 194174 != 44171)
						{
							continue;
						}
						if (this.$mGameGui$47099)
						{
							if (288858 - 91655 == 197204)
							{
								continue;
							}
							this.$mGameGui$47099.close();
							if (188527 - 390547 != -202020)
							{
								continue;
							}
						}
						if (this.$mStoryGui$47100)
						{
							if (43401 - 317891 == -274489)
							{
								continue;
							}
							this.$mStoryGui$47100.close();
							if (196197 - 469708 == -273510)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (82574 - 449519 != -366944)
						{
							goto Block_20;
						}
						continue;
					default:
						if (8546 - 532289 == -523742)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$47101[31]);
					if (127201 - 121180 == 6021)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (62382 - 10379 != 52004)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (283377 - 60733 == 222644)
							{
								this.$result$47097 = RuntimeServices.UnboxInt32(this.$data$47101[31]);
								if (249964 - 375062 != -125097)
								{
									goto Block_15;
								}
							}
						}
					}
				}
				goto IL_352;
				Block_15:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_20:
				IL_352:
				return false;
			}

			// Token: 0x0600BC91 RID: 48273 RVA: 0x01406850 File Offset: 0x01404A50
			internal static bool XAKKartQyqHB2iJr2Mla()
			{
				return true;
			}

			// Token: 0x0600BC92 RID: 48274 RVA: 0x01406854 File Offset: 0x01404A54
			internal static bool Bbkt5AtQSgmm1rkANlhk()
			{
				return false;
			}

			// Token: 0x0400A17A RID: 41338
			internal int $result$47097;

			// Token: 0x0400A17B RID: 41339
			internal CompleteGui $mCompleteGui$47098;

			// Token: 0x0400A17C RID: 41340
			internal GameGui $mGameGui$47099;

			// Token: 0x0400A17D RID: 41341
			internal StoryGui $mStoryGui$47100;

			// Token: 0x0400A17E RID: 41342
			internal Hashtable $data$47101;

			// Token: 0x0400A17F RID: 41343
			internal M981_FireArena $self_$47102;
		}
	}

	// Token: 0x02001F87 RID: 8071
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onCreatePlayer$47105 : GenericGenerator<object>
	{
		// Token: 0x0600BC93 RID: 48275 RVA: 0x01406858 File Offset: 0x01404A58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onCreatePlayer$47105(Hashtable data, M981_FireArena self_)
		{
			if (260458 - 123889 != 136569)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (67817 - 545982 != -478164)
				{
					base..ctor();
					if (202280 - 233109 != -30828)
					{
						this.$data$47112 = data;
						if (146948 - 127502 != 19447)
						{
							this.$self_$47113 = self_;
							if (217700 - 557994 == -340294)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BC94 RID: 48276 RVA: 0x01406914 File Offset: 0x01404B14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<object> GetEnumerator()
		{
			return new M981_FireArena.$onCreatePlayer$47105.$(this.$data$47112, this.$self_$47113);
		}

		// Token: 0x0600BC95 RID: 48277 RVA: 0x01406928 File Offset: 0x01404B28
		internal static bool esxOW6tQoqfKiRot025l()
		{
			return true;
		}

		// Token: 0x0600BC96 RID: 48278 RVA: 0x0140692C File Offset: 0x01404B2C
		internal static bool rwpmEytQEiKmP4UkAw1y()
		{
			return false;
		}

		// Token: 0x0400A180 RID: 41344
		internal Hashtable $data$47112;

		// Token: 0x0400A181 RID: 41345
		internal M981_FireArena $self_$47113;

		// Token: 0x02001F88 RID: 8072
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<object>, IEnumerator
		{
			// Token: 0x0600BC97 RID: 48279 RVA: 0x01406930 File Offset: 0x01404B30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M981_FireArena self_)
			{
				if (168778 - 108213 != 60565)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (129949 - 483653 != -353703)
					{
						base..ctor();
						if (277992 - 369281 == -91289)
						{
							this.$data$47110 = data;
							if (243071 - 526141 == -283070)
							{
								this.$self_$47111 = self_;
								if (82893 - 502168 != -419274)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BC98 RID: 48280 RVA: 0x014069EC File Offset: 0x01404BEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (167147 - 419549 != -252401)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_ED;
					case 1:
						goto IL_5C7;
					case 2:
						if (this.$self_$47111.RYHnpLCMKR7 == this.$self_$47111.M3SnpUC19o5[14])
						{
							if (269292 - 42277 != 227015)
							{
								continue;
							}
							this.$nPlayer$47106.SendMessage("AddAnimation", "pose", SendMessageOptions.DontRequireReceiver);
							if (180927 - 81846 == 99082)
							{
								continue;
							}
							this.$nPlayer$47106.animation.Play("pose");
							if (261105 - 242246 == 18860)
							{
								continue;
							}
						}
						else
						{
							this.$nPlayer$47106.SendMessage("AddAnimation", "cry", SendMessageOptions.DontRequireReceiver);
							if (92094 - 553104 == -461009)
							{
								continue;
							}
							this.$nPlayer$47106.animation.Play("cry");
							if (208678 - 185726 == 22953)
							{
								continue;
							}
						}
						break;
					default:
						if (56473 - 416999 != -360526)
						{
							continue;
						}
						goto IL_ED;
					}
					IL_75:
					this.YieldDefault(1);
					if (146901 - 213605 != -66703)
					{
						break;
					}
					continue;
					IL_ED:
					this.$nPlayer$47106 = Game.createPlayer(this.$data$47110);
					if (58253 - 314710 != -256456)
					{
						if (!this.$nPlayer$47106)
						{
							goto IL_75;
						}
						if (53816 - 421543 != -367726)
						{
							if (this.$self_$47111.UCMnpwUdA9f == 0)
							{
								if (110613 - 40984 != 69630)
								{
									this.$self_$47111.LoadPlayer(this.$nPlayer$47106);
									if (226268 - 304317 != -78048)
									{
										this.$nPlayer$47106.SendMessage("AddAnimation", "battle", SendMessageOptions.DontRequireReceiver);
										if (56766 - 209969 != -153202)
										{
											this.$nPlayer$47106.animation.Play("battle");
											if (221803 - 23467 != 198337)
											{
												this.$self_$47111.StartCoroutine_Auto(this.$self_$47111.StartGame());
												if (59064 - 384066 == -325002)
												{
													goto IL_75;
												}
											}
										}
									}
								}
							}
							else
							{
								if (this.$self_$47111.UCMnpwUdA9f >= 8)
								{
									goto IL_514;
								}
								if (63284 - 121071 == -57787)
								{
									this.$nPlayerChar$47107 = (CharacterControl)this.$nPlayer$47106.GetComponent(typeof(CharacterControl));
									if (65092 - 11206 != 53887)
									{
										if (this.$nPlayerChar$47107)
										{
											if (198238 - 457442 == -259203)
											{
												continue;
											}
											this.$nPlayerSlot$47108 = Game.getPlayerSlot(this.$nPlayerChar$47107.ownerID);
											if (9463 - 558892 != -549429)
											{
												continue;
											}
											if (this.$nPlayerSlot$47108 == this.$self_$47111.M3SnpUC19o5[this.$self_$47111.UCMnpwUdA9f * 2 - 2])
											{
												if (280486 - 295039 == -14552)
												{
													continue;
												}
												this.$self_$47111.A77npNtNpmE = this.$nPlayer$47106;
												if (53320 - 26099 == 27222)
												{
													continue;
												}
											}
											else if (this.$nPlayerSlot$47108 == this.$self_$47111.M3SnpUC19o5[this.$self_$47111.UCMnpwUdA9f * 2 - 1])
											{
												if (134934 - 224309 == -89374)
												{
													continue;
												}
												this.$self_$47111.Pw3npEG0Ymm = this.$nPlayer$47106;
												if (79966 - 39603 == 40364)
												{
													continue;
												}
											}
											else
											{
												Debug.LogError("Error: Unknown player slot" + this.$nPlayerSlot$47108);
												if (239005 - 245465 != -6460)
												{
													continue;
												}
											}
										}
										this.$self_$47111.k90npgySjJI.target = this.$nPlayer$47106;
										if (203060 - 586514 != -383453)
										{
											this.$self_$47111.k90npgySjJI.enabled = true;
											if (193189 - 116236 != 76954)
											{
												if (Game.mPlayer)
												{
													if (78242 - 116341 == -38098)
													{
														continue;
													}
													this.$mGameGui$47109 = (GameGui)this.$self_$47111.GetComponent(typeof(GameGui));
													if (27800 - 276709 != -248909)
													{
														continue;
													}
													this.$mGameGui$47109.enabled = true;
													if (180701 - 162802 == 17900)
													{
														continue;
													}
												}
												this.$self_$47111.yIsnpytmmit = false;
												if (42533 - 94297 == -51764)
												{
													Game.sendMissionEvent(9812, this.$self_$47111.UCMnpwUdA9f);
													if (34411 - 234729 == -200318)
													{
														goto IL_75;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_5C7;
				IL_514:
				return this.YieldDefault(2);
				IL_5C7:
				return false;
			}

			// Token: 0x0600BC99 RID: 48281 RVA: 0x01406FD4 File Offset: 0x014051D4
			internal static bool p5yK04tQ2uQEmKVrTJfs()
			{
				return true;
			}

			// Token: 0x0600BC9A RID: 48282 RVA: 0x01406FD8 File Offset: 0x014051D8
			internal static bool OW8girtQ8l20VBdnPjLb()
			{
				return false;
			}

			// Token: 0x0400A182 RID: 41346
			internal GameObject $nPlayer$47106;

			// Token: 0x0400A183 RID: 41347
			internal CharacterControl $nPlayerChar$47107;

			// Token: 0x0400A184 RID: 41348
			internal int $nPlayerSlot$47108;

			// Token: 0x0400A185 RID: 41349
			internal GameGui $mGameGui$47109;

			// Token: 0x0400A186 RID: 41350
			internal Hashtable $data$47110;

			// Token: 0x0400A187 RID: 41351
			internal M981_FireArena $self_$47111;
		}
	}

	// Token: 0x02001F89 RID: 8073
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onCreatePeer$47114 : GenericGenerator<object>
	{
		// Token: 0x0600BC9B RID: 48283 RVA: 0x01406FDC File Offset: 0x014051DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onCreatePeer$47114(Hashtable data, M981_FireArena self_)
		{
			if (242635 - 490033 != -247397)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (69168 - 339163 == -269995)
				{
					base..ctor();
					if (289655 - 593193 == -303538)
					{
						this.$data$47120 = data;
						if (36613 - 325782 == -289169)
						{
							this.$self_$47121 = self_;
							if (129667 - 304769 == -175102)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600BC9C RID: 48284 RVA: 0x01407098 File Offset: 0x01405298
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<object> GetEnumerator()
		{
			return new M981_FireArena.$onCreatePeer$47114.$(this.$data$47120, this.$self_$47121);
		}

		// Token: 0x0600BC9D RID: 48285 RVA: 0x014070AC File Offset: 0x014052AC
		internal static bool KAo9mxtQZ4rhEncIggbH()
		{
			return true;
		}

		// Token: 0x0600BC9E RID: 48286 RVA: 0x014070B0 File Offset: 0x014052B0
		internal static bool M0YETItQC5xQlapK3ZDE()
		{
			return false;
		}

		// Token: 0x0400A188 RID: 41352
		internal Hashtable $data$47120;

		// Token: 0x0400A189 RID: 41353
		internal M981_FireArena $self_$47121;

		// Token: 0x02001F8A RID: 8074
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<object>, IEnumerator
		{
			// Token: 0x0600BC9F RID: 48287 RVA: 0x014070B4 File Offset: 0x014052B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M981_FireArena self_)
			{
				if (275218 - 544127 != -268909)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (35310 - 91872 == -56562)
					{
						base..ctor();
						if (138845 - 234537 == -95692)
						{
							this.$data$47118 = data;
							if (284834 - 218992 == 65842)
							{
								this.$self_$47119 = self_;
								if (248123 - 209086 == 39037)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600BCA0 RID: 48288 RVA: 0x01407170 File Offset: 0x01405370
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (101611 - 31567 != 70045)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_21C;
					case 1:
						goto IL_48F;
					case 2:
						if (this.$nPeerPlayer$47115.layer == this.$self_$47119.M3SnpUC19o5[14] + 7)
						{
							if (156704 - 553422 == -396717)
							{
								continue;
							}
							this.$nPeerPlayer$47115.SendMessage("AddAnimation", "pose", SendMessageOptions.DontRequireReceiver);
							if (177366 - 504537 == -327170)
							{
								continue;
							}
							this.$nPeerPlayer$47115.animation.Play("pose");
							if (285944 - 415224 == -129279)
							{
								continue;
							}
						}
						else
						{
							this.$nPeerPlayer$47115.SendMessage("AddAnimation", "cry", SendMessageOptions.DontRequireReceiver);
							if (111483 - 378351 == -266867)
							{
								continue;
							}
							this.$nPeerPlayer$47115.animation.Play("cry");
							if (67493 - 245777 == -178283)
							{
								continue;
							}
						}
						break;
					default:
						if (243911 - 104214 != 139698)
						{
							goto IL_21C;
						}
						continue;
					}
					IL_145:
					this.YieldDefault(1);
					if (159049 - 295130 != -136081)
					{
						continue;
					}
					goto IL_48F;
					IL_21C:
					this.$nPeerPlayer$47115 = Game.createPeer(this.$data$47118);
					if (294527 - 113283 == 181244)
					{
						if (!this.$nPeerPlayer$47115)
						{
							goto IL_145;
						}
						if (206141 - 566384 == -360243)
						{
							if (this.$self_$47119.UCMnpwUdA9f == 0)
							{
								if (43136 - 475842 != -432705)
								{
									this.$nPeerPlayer$47115.SendMessage("AddAnimation", "battle", SendMessageOptions.DontRequireReceiver);
									if (44867 - 285305 != -240437)
									{
										this.$nPeerPlayer$47115.animation.Play("battle");
										if (177274 - 587333 == -410059)
										{
											this.$self_$47119.LoadPlayer(this.$nPeerPlayer$47115);
											if (131358 - 501725 != -370366)
											{
												goto IL_145;
											}
										}
									}
								}
							}
							else
							{
								if (this.$self_$47119.UCMnpwUdA9f >= 8)
								{
									break;
								}
								if (117954 - 394074 == -276120)
								{
									this.$self_$47119.LoadTargetBar(this.$nPeerPlayer$47115);
									if (63978 - 262452 == -198474)
									{
										this.$nPlayerChar$47116 = (CharacterControl)this.$nPeerPlayer$47115.GetComponent(typeof(CharacterControl));
										if (91993 - 440403 == -348410)
										{
											if (this.$nPlayerChar$47116)
											{
												if (257473 - 354390 == -96916)
												{
													continue;
												}
												this.$nPlayerSlot$47117 = Game.getPlayerSlot(this.$nPlayerChar$47116.ownerID);
												if (176630 - 533206 == -356575)
												{
													continue;
												}
												if (this.$nPlayerSlot$47117 == this.$self_$47119.M3SnpUC19o5[this.$self_$47119.UCMnpwUdA9f * 2 - 2])
												{
													if (282252 - 402848 != -120596)
													{
														continue;
													}
													this.$self_$47119.A77npNtNpmE = this.$nPeerPlayer$47115;
													if (222325 - 351236 == -128910)
													{
														continue;
													}
												}
												else if (this.$nPlayerSlot$47117 == this.$self_$47119.M3SnpUC19o5[this.$self_$47119.UCMnpwUdA9f * 2 - 1])
												{
													if (194464 - 393439 == -198974)
													{
														continue;
													}
													this.$self_$47119.Pw3npEG0Ymm = this.$nPeerPlayer$47115;
													if (151779 - 411481 != -259702)
													{
														continue;
													}
												}
												else
												{
													Debug.LogError("Error: Unknown player layer @" + this.$nPeerPlayer$47115.layer);
													if (152771 - 91401 != 61370)
													{
														continue;
													}
												}
											}
											goto IL_145;
										}
									}
								}
							}
						}
					}
				}
				return this.YieldDefault(2);
				IL_48F:
				return false;
			}

			// Token: 0x0600BCA1 RID: 48289 RVA: 0x01407620 File Offset: 0x01405820
			internal static bool t879mCtQL1HjAV8o99TT()
			{
				return true;
			}

			// Token: 0x0600BCA2 RID: 48290 RVA: 0x01407624 File Offset: 0x01405824
			internal static bool fj7dGDtQOw4Dr8q5EC2n()
			{
				return false;
			}

			// Token: 0x0400A18A RID: 41354
			internal GameObject $nPeerPlayer$47115;

			// Token: 0x0400A18B RID: 41355
			internal CharacterControl $nPlayerChar$47116;

			// Token: 0x0400A18C RID: 41356
			internal int $nPlayerSlot$47117;

			// Token: 0x0400A18D RID: 41357
			internal Hashtable $data$47118;

			// Token: 0x0400A18E RID: 41358
			internal M981_FireArena $self_$47119;
		}
	}

	// Token: 0x02001F8B RID: 8075
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$47122 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BCA3 RID: 48291 RVA: 0x01407628 File Offset: 0x01405828
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$47122(M981_FireArena self_)
		{
			if (147823 - 251608 != -103784)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (298140 - 383265 == -85125)
				{
					base..ctor();
					if (19719 - 377410 != -357690)
					{
						this.$self_$47126 = self_;
						if (158426 - 20097 != 138330)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BCA4 RID: 48292 RVA: 0x014076C0 File Offset: 0x014058C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M981_FireArena.$ReturnToTown$47122.$(this.$self_$47126);
		}

		// Token: 0x0600BCA5 RID: 48293 RVA: 0x014076D0 File Offset: 0x014058D0
		internal static bool QWOMWutQmIDYD5jdiECY()
		{
			return true;
		}

		// Token: 0x0600BCA6 RID: 48294 RVA: 0x014076D4 File Offset: 0x014058D4
		internal static bool zAYElAtQFIkG2NO70r7c()
		{
			return false;
		}

		// Token: 0x0400A18F RID: 41359
		internal M981_FireArena $self_$47126;

		// Token: 0x02001F8C RID: 8076
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BCA7 RID: 48295 RVA: 0x014076D8 File Offset: 0x014058D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M981_FireArena self_)
			{
				if (159960 - 382049 != -222088)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (161954 - 593076 != -431121)
					{
						base..ctor();
						if (146738 - 252051 != -105312)
						{
							this.$self_$47125 = self_;
							if (237975 - 27873 == 210102)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BCA8 RID: 48296 RVA: 0x01407770 File Offset: 0x01405970
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (167679 - 133720 != 33959)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3B3;
					case 2:
						this.$self_$47125.LeaveGame();
						if (101908 - 587631 != -485723)
						{
							continue;
						}
						this.YieldDefault(1);
						if (126687 - 327197 != -200509)
						{
							goto Block_29;
						}
						continue;
					default:
						if (22022 - 106785 == -84762)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (27540 - 196430 != -168889)
					{
						this.$self_$47125.GtCnpfosCIs = Time.time;
						if (193745 - 416142 != -222396)
						{
							this.$$switch$8789$47123 = PlayerData.SaveGuild;
							if (116362 - 236020 == -119658)
							{
								if (this.$$switch$8789$47123 == 1)
								{
									if (116078 - 222640 != -106562)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (26293 - 64048 != -37755)
									{
										continue;
									}
								}
								else if (this.$$switch$8789$47123 == 2)
								{
									if (66702 - 190717 != -124015)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (51385 - 171871 != -120486)
									{
										continue;
									}
								}
								else if (this.$$switch$8789$47123 == 3)
								{
									if (295887 - 68634 != 227253)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (110205 - 183111 != -72906)
									{
										continue;
									}
								}
								else if (this.$$switch$8789$47123 == 4)
								{
									if (287222 - 595188 == -307965)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (265074 - 491200 != -226126)
									{
										continue;
									}
								}
								else if (this.$$switch$8789$47123 == 5)
								{
									if (175862 - 540783 != -364921)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (144045 - 225507 != -81462)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (149728 - 218500 == -68771)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (183611 - 466172 != -282561)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (85918 - 376661 == -290742)
									{
										continue;
									}
								}
								this.$mGameGui$47124 = (GameGui)this.$self_$47125.GetComponent(typeof(GameGui));
								if (56431 - 565920 != -509488)
								{
									if (this.$mGameGui$47124)
									{
										if (119091 - 246948 != -127857)
										{
											continue;
										}
										this.$mGameGui$47124.close();
										if (228823 - 206630 == 22194)
										{
											continue;
										}
									}
									this.$self_$47125.SendMessage("fadeOut");
									if (135186 - 399334 == -264148)
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
				IL_3B3:
				return false;
			}

			// Token: 0x0600BCA9 RID: 48297 RVA: 0x01407B44 File Offset: 0x01405D44
			internal static bool GcfOlKtQMIdQfELbp37r()
			{
				return true;
			}

			// Token: 0x0600BCAA RID: 48298 RVA: 0x01407B48 File Offset: 0x01405D48
			internal static bool VhaJnUtQxI3UDaruXLiW()
			{
				return false;
			}

			// Token: 0x0400A190 RID: 41360
			internal int $$switch$8789$47123;

			// Token: 0x0400A191 RID: 41361
			internal GameGui $mGameGui$47124;

			// Token: 0x0400A192 RID: 41362
			internal M981_FireArena $self_$47125;
		}
	}

	// Token: 0x02001F8D RID: 8077
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$47127 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BCAB RID: 48299 RVA: 0x01407B4C File Offset: 0x01405D4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$47127(M981_FireArena self_)
		{
			if (269340 - 357378 != -88038)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (168590 - 514647 != -346056)
				{
					base..ctor();
					if (111745 - 134554 == -22809)
					{
						this.$self_$47130 = self_;
						if (63599 - 413107 != -349507)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BCAC RID: 48300 RVA: 0x01407BE4 File Offset: 0x01405DE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M981_FireArena.$ReturnToGuild$47127.$(this.$self_$47130);
		}

		// Token: 0x0600BCAD RID: 48301 RVA: 0x01407BF4 File Offset: 0x01405DF4
		internal static bool ebsOWWtQg0bBwhtNvswH()
		{
			return true;
		}

		// Token: 0x0600BCAE RID: 48302 RVA: 0x01407BF8 File Offset: 0x01405DF8
		internal static bool yvPf3NtQfx2UtqQOCs07()
		{
			return false;
		}

		// Token: 0x0400A193 RID: 41363
		internal M981_FireArena $self_$47130;

		// Token: 0x02001F8E RID: 8078
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BCAF RID: 48303 RVA: 0x01407BFC File Offset: 0x01405DFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M981_FireArena self_)
			{
				if (123379 - 143165 != -19785)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (5066 - 98669 == -93603)
					{
						base..ctor();
						if (189537 - 119282 == 70255)
						{
							this.$self_$47129 = self_;
							if (203231 - 538488 == -335257)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BCB0 RID: 48304 RVA: 0x01407C94 File Offset: 0x01405E94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (139899 - 97034 != 42866)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1C3;
					case 2:
						this.$self_$47129.LeaveGame();
						if (293251 - 447935 != -154684)
						{
							continue;
						}
						this.YieldDefault(1);
						if (199119 - 441318 != -242199)
						{
							continue;
						}
						goto IL_1C3;
					default:
						if (96379 - 112133 != -15754)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (284635 - 194861 != 89775)
					{
						this.$self_$47129.GtCnpfosCIs = Time.time;
						if (97310 - 441064 == -343754)
						{
							Game.mNextGameCode = 31;
							if (204102 - 417119 == -213017)
							{
								this.$mGameGui$47128 = (GameGui)this.$self_$47129.GetComponent(typeof(GameGui));
								if (234346 - 147866 != 86481)
								{
									if (this.$mGameGui$47128)
									{
										if (24131 - 69594 == -45462)
										{
											continue;
										}
										this.$mGameGui$47128.close();
										if (173840 - 142741 != 31099)
										{
											continue;
										}
									}
									this.$self_$47129.SendMessage("fadeOut");
									if (279296 - 440006 == -160710)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_1C3:
				return false;
			}

			// Token: 0x0600BCB1 RID: 48305 RVA: 0x01407E78 File Offset: 0x01406078
			internal static bool JU5sMOtQngqwLAlnCoPW()
			{
				return true;
			}

			// Token: 0x0600BCB2 RID: 48306 RVA: 0x01407E7C File Offset: 0x0140607C
			internal static bool atfljgtQ6jxs6kV4mtKI()
			{
				return false;
			}

			// Token: 0x0400A194 RID: 41364
			internal GameGui $mGameGui$47128;

			// Token: 0x0400A195 RID: 41365
			internal M981_FireArena $self_$47129;
		}
	}

	// Token: 0x02001F8F RID: 8079
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$47131 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600BCB3 RID: 48307 RVA: 0x01407E80 File Offset: 0x01406080
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$47131(M981_FireArena self_)
		{
			if (220022 - 260160 != -40137)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (76510 - 598366 == -521856)
				{
					base..ctor();
					if (183611 - 346021 == -162410)
					{
						this.$self_$47135 = self_;
						if (225257 - 94670 != 130588)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600BCB4 RID: 48308 RVA: 0x01407F18 File Offset: 0x01406118
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M981_FireArena.$ReturnToCamp$47131.$(this.$self_$47135);
		}

		// Token: 0x0600BCB5 RID: 48309 RVA: 0x01407F28 File Offset: 0x01406128
		internal static bool TZQpCntQibJIuTa7abWo()
		{
			return true;
		}

		// Token: 0x0600BCB6 RID: 48310 RVA: 0x01407F2C File Offset: 0x0140612C
		internal static bool audBsXtQKdqBEurlm4LV()
		{
			return false;
		}

		// Token: 0x0400A196 RID: 41366
		internal M981_FireArena $self_$47135;

		// Token: 0x02001F90 RID: 8080
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600BCB7 RID: 48311 RVA: 0x01407F30 File Offset: 0x01406130
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M981_FireArena self_)
			{
				if (215588 - 297657 != -82068)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (71368 - 123675 == -52307)
					{
						base..ctor();
						if (150693 - 323956 != -173262)
						{
							this.$self_$47134 = self_;
							if (34561 - 75662 == -41101)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600BCB8 RID: 48312 RVA: 0x01407FC8 File Offset: 0x014061C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (233773 - 241462 != -7689)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_369;
					case 2:
						this.$self_$47134.LeaveGame();
						if (258329 - 21714 == 236616)
						{
							continue;
						}
						this.YieldDefault(1);
						if (132835 - 87500 != 45336)
						{
							goto Block_24;
						}
						continue;
					default:
						if (248522 - 580152 == -331629)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (264120 - 378821 == -114701)
					{
						this.$self_$47134.GtCnpfosCIs = Time.time;
						if (117692 - 349753 != -232060)
						{
							this.$$switch$8791$47132 = PlayerData.SaveGuild;
							if (175382 - 305925 != -130542)
							{
								if (this.$$switch$8791$47132 == 1)
								{
									if (69590 - 547469 != -477879)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (158282 - 406653 == -248370)
									{
										continue;
									}
								}
								else if (this.$$switch$8791$47132 == 2)
								{
									if (189513 - 407350 != -217837)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (42378 - 136884 == -94505)
									{
										continue;
									}
								}
								else if (this.$$switch$8791$47132 == 3)
								{
									if (231374 - 403293 != -171919)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (241327 - 329531 != -88204)
									{
										continue;
									}
								}
								else if (this.$$switch$8791$47132 == 4)
								{
									if (244766 - 248696 != -3930)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (233149 - 543444 == -310294)
									{
										continue;
									}
								}
								else if (this.$$switch$8791$47132 == 5)
								{
									if (27157 - 270942 == -243784)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (151336 - 570653 == -419316)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (177846 - 22426 == 155421)
									{
										continue;
									}
								}
								this.$mGameGui$47133 = (GameGui)this.$self_$47134.GetComponent(typeof(GameGui));
								if (81945 - 476085 != -394139)
								{
									if (this.$mGameGui$47133)
									{
										if (169831 - 449272 == -279440)
										{
											continue;
										}
										this.$mGameGui$47133.close();
										if (88197 - 432033 == -343835)
										{
											continue;
										}
									}
									this.$self_$47134.SendMessage("fadeOut");
									if (61359 - 242871 == -181512)
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
				IL_369:
				return false;
			}

			// Token: 0x0600BCB9 RID: 48313 RVA: 0x01408350 File Offset: 0x01406550
			internal static bool INhlRDtQdnvJGMhQlVgV()
			{
				return true;
			}

			// Token: 0x0600BCBA RID: 48314 RVA: 0x01408354 File Offset: 0x01406554
			internal static bool FqaSl9tQJM4DkR4Yohvh()
			{
				return false;
			}

			// Token: 0x0400A197 RID: 41367
			internal int $$switch$8791$47132;

			// Token: 0x0400A198 RID: 41368
			internal GameGui $mGameGui$47133;

			// Token: 0x0400A199 RID: 41369
			internal M981_FireArena $self_$47134;
		}
	}
}
