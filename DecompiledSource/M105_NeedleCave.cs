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

// Token: 0x02001333 RID: 4915
[Serializable]
public class M105_NeedleCave : MonoBehaviour
{
	// Token: 0x06007123 RID: 28963 RVA: 0x00F7CEF8 File Offset: 0x00F7B0F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M105_NeedleCave()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06007124 RID: 28964 RVA: 0x00F7CF08 File Offset: 0x00F7B108
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (110058 - 420849 != -310791)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (282860 - 584502 == -301642)
			{
				Game.mGameType = 5;
				if (241672 - 453759 == -212087)
				{
					if (Chat.Initialized)
					{
						if (107730 - 161048 == -53317)
						{
							continue;
						}
						Chat.ChatDisplay.Clear();
						if (70393 - 55216 == 15178)
						{
							continue;
						}
					}
					else
					{
						Chat.Init();
						if (205633 - 67581 != 138052)
						{
							continue;
						}
					}
					this.Rj1c8xrVBA2 = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (231896 - 376870 != -144973)
					{
						this.gqdc8T1CfY6 = (AudioClip)Resources.Load("Sound/GUI/missionStart", typeof(AudioClip));
						if (174796 - 159414 != 15383)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007125 RID: 28965 RVA: 0x00F7D060 File Offset: 0x00F7B260
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (59378 - 381005 != -321627)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (252905 - 445698 != -192792)
				{
					if (Game.mNextGameCode != 105)
					{
						break;
					}
					if (133707 - 513030 == -379323)
					{
						Game.nextGame();
						if (186760 - 98991 != 87770)
						{
							Game.mGameCode = 105;
							if (192413 - 470589 == -278176)
							{
								Game.mGameType = 5;
								if (250729 - 586842 != -336112)
								{
									Game.mGameTime = Time.time;
									if (292850 - 319529 != -26678)
									{
										Game.mGameScore = 0;
										if (79828 - 329222 != -249393)
										{
											Game.mGameMana = 0;
											if (146463 - 484221 == -337758)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (291549 - 224485 == 67064)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (80163 - 554192 != -474028)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (48266 - 192886 == -144620)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (108289 - 575205 != -466915)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (15873 - 39869 == -23996)
																{
																	this.TD3c8RpOfrk = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (151461 - 491823 == -340362)
																	{
																		this.qCJc8pXTHbh = PhotonClient.Connection;
																		if (72542 - 162244 == -89702)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (60140 - 127164 != -67023)
																			{
																				this.InitGame();
																				if (275824 - 202281 == 73543)
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
				if (118592 - 284613 != -166020)
				{
					Game.mGameType = 99;
					if (117459 - 352192 != -234732)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007126 RID: 28966 RVA: 0x00F7D360 File Offset: 0x00F7B560
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (59108 - 39531 != 19577)
		{
		}
		for (;;)
		{
			if (this.qCJc8pXTHbh == null)
			{
				if (250188 - 235372 != 14817)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (233417 - 543573 == -310156)
				{
					if (mGameState == eGameState.Start)
					{
						if (206421 - 2288 == 204133)
						{
							if (Game.music != 0)
							{
								if (27615 - 325188 != -297573)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (105897 - 471676 == -365778)
									{
										continue;
									}
									this.audio.Play();
									if (174272 - 81218 != 93054)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (295127 - 518466 != -223338)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
									if (156470 - 458974 == -302504)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (72562 - 349973 == -277411)
								{
									break;
								}
							}
						}
					}
					else
					{
						if (mGameState != eGameState.Normal)
						{
							break;
						}
						if (194354 - 463029 == -268675)
						{
							if (Time.time > this.jIIc8r2BNjX)
							{
								if (70157 - 200941 != -130784)
								{
									continue;
								}
								Game.mGameMana++;
								if (124924 - 377619 != -252695)
								{
									continue;
								}
								this.jIIc8r2BNjX = Time.time + (float)12;
								if (71652 - 315973 == -244320)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (168662 - 351666 != -183004)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (100856 - 446607 != -345751)
									{
										continue;
									}
									this.audio.Play();
									if (43133 - 566410 == -523276)
									{
										continue;
									}
								}
							}
							this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
							if (211502 - 535322 != -323819)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007127 RID: 28967 RVA: 0x00F7D674 File Offset: 0x00F7B874
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (150587 - 393968 != -243381)
		{
		}
		for (;;)
		{
			if (!this.Rj1c8xrVBA2)
			{
				if (101972 - 497244 == -395272)
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
				if (175183 - 528951 == -353768)
				{
					if (Time.time - Game.mStateTime >= (float)2)
					{
						break;
					}
					if (223632 - 465999 != -242366)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (185373 - 327709 != -142335)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (242956 - 99377 == 143579)
							{
								GUI.depth = 1;
								if (258885 - 316380 != -57494)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
									if (100194 - 512108 == -411914)
									{
										float smoothRatioOverTime = global::Math.getSmoothRatioOverTime(Time.time - Game.mStateTime, new Vector4((float)0, (float)1, 0.3f, 0.6f));
										if (79565 - 547086 == -467521)
										{
											Color color = GUI.color;
											if (115664 - 25844 == 89820)
											{
												color.a = smoothRatioOverTime;
												if (69409 - 451835 == -382426)
												{
													if (162872 - 234506 == -71634)
													{
														Color color2 = GUI.color = color;
														if (233999 - 403565 == -169566)
														{
															if (56856 - 359700 == -302844)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.Rj1c8xrVBA2);
																if (121729 - 269877 == -148148)
																{
																	float a = 1f;
																	if (254776 - 444071 != -189294)
																	{
																		Color color3 = GUI.color;
																		if (137754 - 549100 == -411346)
																		{
																			color3.a = a;
																			if (37176 - 29077 == 8099)
																			{
																				if (232104 - 42652 == 189452)
																				{
																					GUI.color = color3;
																					if (3803 - 437447 != -433643 && 72931 - 476995 != -404063)
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

	// Token: 0x06007128 RID: 28968 RVA: 0x00F7D9FC File Offset: 0x00F7BBFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (110938 - 413623 != -302685)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (219342 - 418338 != -198995)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (212494 - 259283 == -46789)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (237036 - 521258 != -284221)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (208698 - 196749 == 11949)
						{
							int num4 = num;
							if (116967 - 243015 == -126048)
							{
								if (num4 == 1051)
								{
									if (111009 - 444699 == -333690)
									{
										if (this.aGPc8YNwReF >= 2)
										{
											break;
										}
										if (133170 - 593272 == -460102)
										{
											this.aGPc8YNwReF = 2;
											if (38533 - 177093 == -138560)
											{
												this.StartCoroutine_Auto(this.EndEvent(num2));
												if (155135 - 396756 == -241621)
												{
													break;
												}
											}
										}
									}
								}
								else if (num4 == 1052)
								{
									if (67417 - 421681 == -354264)
									{
										break;
									}
								}
								else
								{
									if (num4 != 1053)
									{
										break;
									}
									if (95229 - 200071 != -104841)
									{
										if (num2 != 1)
										{
											break;
										}
										if (215600 - 599708 == -384108)
										{
											this.Nmfc8dmXCKE++;
											if (185126 - 597760 != -412633)
											{
												if (PlayerData.UID != num3)
												{
													break;
												}
												if (126924 - 143462 != -16537)
												{
													if (this.Nmfc8dmXCKE <= 4)
													{
														break;
													}
													if (272305 - 594907 == -322602)
													{
														GameObject gameObject = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(1, 7));
														if (36054 - 16628 != 19427)
														{
															if (!gameObject)
															{
																break;
															}
															if (24902 - 102133 != -77230)
															{
																if (210088 - 391275 == -181187)
																{
																	int num5 = UnityEngine.Random.Range(0, 7);
																	if (236037 - 186730 != 49308)
																	{
																		string text;
																		if (num5 == 1)
																		{
																			if (66998 - 394123 == -327124)
																			{
																				continue;
																			}
																			text = "NeedleBug_r";
																			if (145089 - 69033 != 76056)
																			{
																				continue;
																			}
																		}
																		else if (num5 == 2)
																		{
																			if (216752 - 439489 != -222737)
																			{
																				continue;
																			}
																			text = "NeedleBug_g";
																			if (138574 - 297993 == -159418)
																			{
																				continue;
																			}
																		}
																		else if (num5 == 3)
																		{
																			if (130162 - 58965 != 71197)
																			{
																				continue;
																			}
																			text = "NeedleBug_b";
																			if (152996 - 299866 == -146869)
																			{
																				continue;
																			}
																		}
																		else if (num5 == 4)
																		{
																			if (189905 - 200156 == -10250)
																			{
																				continue;
																			}
																			text = "NeedleBug_o";
																			if (109408 - 345841 != -236433)
																			{
																				continue;
																			}
																		}
																		else if (num5 == 5)
																		{
																			if (174081 - 104448 != 69633)
																			{
																				continue;
																			}
																			text = "NeedleBug_p";
																			if (102912 - 388309 != -285397)
																			{
																				continue;
																			}
																		}
																		else if (num5 == 6)
																		{
																			if (197847 - 271554 == -73706)
																			{
																				continue;
																			}
																			text = "NeedleBug_k";
																			if (98070 - 210049 != -111979)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			text = "NeedleBug_w";
																			if (203326 - 302750 != -99424)
																			{
																				continue;
																			}
																		}
																		if (!(text != "none"))
																		{
																			break;
																		}
																		if (271824 - 152250 != 119575)
																		{
																			this.createActor(text, 6, gameObject.transform.position, gameObject.transform.forward);
																			if (61641 - 287072 == -225431)
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

	// Token: 0x06007129 RID: 28969 RVA: 0x00F7DF68 File Offset: 0x00F7C168
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M105_NeedleCave.$StartEvent$37399(this).GetEnumerator();
	}

	// Token: 0x0600712A RID: 28970 RVA: 0x00F7DF78 File Offset: 0x00F7C178
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndEvent(int nFoundPlayerUID)
	{
		return new M105_NeedleCave.$EndEvent$37405(nFoundPlayerUID, this).GetEnumerator();
	}

	// Token: 0x0600712B RID: 28971 RVA: 0x00F7DF88 File Offset: 0x00F7C188
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TalkToMiniCat()
	{
		if (52188 - 415050 != -362862)
		{
		}
		while (this.aGPc8YNwReF < 1)
		{
			if (203792 - 465426 != -261633)
			{
				this.aGPc8YNwReF = 1;
				if (79837 - 491798 == -411961)
				{
					Game.sendMissionEvent(1051, PlayerData.UID);
					if (249827 - 353566 == -103739)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600712C RID: 28972 RVA: 0x00F7E030 File Offset: 0x00F7C230
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToMiniSheep()
	{
		return new M105_NeedleCave.$TalkToMiniSheep$37419(this).GetEnumerator();
	}

	// Token: 0x0600712D RID: 28973 RVA: 0x00F7E040 File Offset: 0x00F7C240
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TalkToWarthog()
	{
		return new M105_NeedleCave.$TalkToWarthog$37428(this).GetEnumerator();
	}

	// Token: 0x0600712E RID: 28974 RVA: 0x00F7E050 File Offset: 0x00F7C250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseLifeAltar(int mVar)
	{
		if (183157 - 555469 != -372311)
		{
		}
		for (;;)
		{
			GameObject mPlayer = Game.mPlayer;
			if (137739 - 417649 != -279909)
			{
				CharacterControl characterControl = null;
				if (277167 - 499032 != -221864)
				{
					if (mPlayer)
					{
						if (187729 - 257749 != -70020)
						{
							continue;
						}
						characterControl = (CharacterControl)mPlayer.GetComponent(typeof(CharacterControl));
						if (24115 - 88613 != -64498)
						{
							continue;
						}
					}
					if (!characterControl)
					{
						if (157062 - 121167 == 35895)
						{
							break;
						}
					}
					else if (characterControl.isTransform)
					{
						if (53642 - 368018 != -314375)
						{
							this.SendMessage("newGameMessage", "Cannot change while transformed");
							if (90929 - 192976 != -102046)
							{
								break;
							}
						}
					}
					else
					{
						if (characterControl.actionState != "standby")
						{
							if (145669 - 333054 != -187385)
							{
								continue;
							}
							if (characterControl.actionState != "run")
							{
								if (63858 - 139169 == -75310)
								{
									continue;
								}
								if (characterControl.actionState != "emotion")
								{
									if (178870 - 222792 == -43921)
									{
										continue;
									}
									this.SendMessage("newGameMessage", "Character not standby");
									if (14952 - 308438 != -293485)
									{
										break;
									}
									continue;
								}
							}
						}
						if (Time.time < characterControl.actionTime + 1f)
						{
							if (19054 - 36454 == -17400)
							{
								this.SendMessage("newGameMessage", "Character not action time out.");
								if (99376 - 203586 != -104209)
								{
									break;
								}
							}
						}
						else
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (268620 - 507694 != -239073)
							{
								ChangeGui changeGui = (ChangeGui)this.GetComponent(typeof(ChangeGui));
								if (100529 - 276617 != -176087)
								{
									if (!changeGui)
									{
										break;
									}
									if (172807 - 335386 != -162578)
									{
										if (changeGui.mState != eChangeState.Init)
										{
											if (198954 - 320909 != -121955)
											{
												continue;
											}
											if (changeGui.mState != eChangeState.Disabled)
											{
												break;
											}
											if (119314 - 591124 != -471810)
											{
												continue;
											}
										}
										Game.mGameState = eGameState.Hold;
										if (112025 - 445504 != -333478)
										{
											gameGui.close();
											if (275079 - 280112 == -5033)
											{
												changeGui.enabled = true;
												if (108739 - 204330 != -95590)
												{
													GameObject gameObject = GameObject.Find("LifeAltar");
													if (260161 - 502336 != -242174)
													{
														if (!gameObject)
														{
															break;
														}
														if (118716 - 417706 == -298990)
														{
															if (!mPlayer)
															{
																break;
															}
															if (166330 - 316478 == -150148)
															{
																Debug.Log("UseLifeAltar");
																if (266561 - 48419 == 218142)
																{
																	mPlayer.SendMessage("turnToPos", gameObject.transform.position);
																	if (188880 - 587264 == -398384)
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

	// Token: 0x0600712F RID: 28975 RVA: 0x00F7E4B0 File Offset: 0x00F7C6B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (36759 - 387972 != -351212)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (295782 - 46808 != 248975)
			{
				hashtable.Add(71, CID);
				if (290649 - 115227 == 175422)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (37663 - 569319 == -531656)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (242069 - 564074 == -322005)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (96109 - 65369 != 30741)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (183767 - 500578 == -316811)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (203154 - 421999 == -218845)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (246584 - 384214 == -137630)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (247559 - 215566 != 31994)
											{
												this.qCJc8pXTHbh.OpCustom(61, hashtable, true);
												if (99118 - 310440 == -211322)
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

	// Token: 0x06007130 RID: 28976 RVA: 0x00F7E73C File Offset: 0x00F7C93C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (291243 - 457689 != -166446)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (137746 - 426143 != -288396)
			{
				if (!gameObject)
				{
					break;
				}
				if (236653 - 536243 != -299589)
				{
					this.TD3c8RpOfrk.target = gameObject;
					if (63714 - 270362 == -206648)
					{
						if (Game.mGameState >= eGameState.Start)
						{
							break;
						}
						if (83581 - 309489 == -225908)
						{
							this.StartGame();
							if (139542 - 388544 != -249001)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007131 RID: 28977 RVA: 0x00F7E828 File Offset: 0x00F7CA28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (18558 - 467450 != -448891)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (141167 - 465413 == -324246)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (95492 - 363297 == -267805)
				{
					gameGui.ResetTeamBar();
					if (108469 - 545098 == -436629)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007132 RID: 28978 RVA: 0x00F7E8D4 File Offset: 0x00F7CAD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (248151 - 370192 != -122041)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (225439 - 57471 == 167968)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (135561 - 179435 != -43873)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (174888 - 322971 != -148082)
					{
						Hashtable hashtable = new Hashtable();
						if (192897 - 505847 == -312950)
						{
							hashtable.Add(43, PlayerData.UID);
							if (228514 - 448493 != -219978)
							{
								hashtable.Add(71, nCID);
								if (261081 - 533307 == -272226)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (293403 - 274886 == 18517)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (281036 - 554389 == -273353)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (293260 - 374323 == -81063)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (94367 - 206239 != -111871)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (215679 - 523047 != -307367)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (33036 - 588806 != -555769)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (298912 - 235218 != 63695)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (225314 - 406631 != -181316)
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

	// Token: 0x06007133 RID: 28979 RVA: 0x00F7EBF4 File Offset: 0x00F7CDF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M105_NeedleCave.$onChangePlayer$37437(data, this).GetEnumerator();
	}

	// Token: 0x06007134 RID: 28980 RVA: 0x00F7EC04 File Offset: 0x00F7CE04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M105_NeedleCave.$onDeadPlayer$37444(this).GetEnumerator();
	}

	// Token: 0x06007135 RID: 28981 RVA: 0x00F7EC14 File Offset: 0x00F7CE14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (268081 - 168804 != 99277)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (137587 - 326494 == -188907)
			{
				this.TD3c8RpOfrk.target = Game.mPlayer;
				if (241197 - 594999 == -353802)
				{
					this.TD3c8RpOfrk.enabled = true;
					if (56144 - 277485 != -221340)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (190401 - 463161 == -272759)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (247466 - 446548 != -199082)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (103303 - 499731 == -396428)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (46092 - 169441 != -123348)
							{
								if (!gameGui)
								{
									break;
								}
								if (96306 - 520155 != -423848)
								{
									gameGui.enabled = true;
									if (157869 - 376331 == -218462)
									{
										gameGui.closeDeadMenu();
										if (115554 - 219237 != -103682)
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

	// Token: 0x06007136 RID: 28982 RVA: 0x00F7EDC0 File Offset: 0x00F7CFC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (208735 - 329092 != -120356)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (258461 - 356640 != -98178)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (267466 - 198325 != 69142)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (286399 - 580073 == -293674)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007137 RID: 28983 RVA: 0x00F7EE84 File Offset: 0x00F7D084
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06007138 RID: 28984 RVA: 0x00F7EEB0 File Offset: 0x00F7D0B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (262969 - 219465 != 43504)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (160209 - 217347 != -57137)
			{
				hashtable.Add(43, PlayerData.UID);
				if (99713 - 256310 != -156596)
				{
					hashtable.Add(73, nType);
					if (69246 - 510623 == -441377)
					{
						hashtable.Add(75, PhotonClient.cInt16(nTeam));
						if (85422 - 477248 != -391825)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
							if (126218 - 13989 == 112229)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
								if (213002 - 284939 == -71937)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
									if (266474 - 185123 == 81351)
									{
										hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
										if (164805 - 184472 == -19667)
										{
											hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
											if (76637 - 523626 == -446989)
											{
												hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
												if (166628 - 528272 != -361643)
												{
													this.qCJc8pXTHbh.OpCustom(63, hashtable, true);
													if (177149 - 365219 != -188069)
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

	// Token: 0x06007139 RID: 28985 RVA: 0x00F7F168 File Offset: 0x00F7D368
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (133040 - 337268 != -204228)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (30084 - 190019 != -159934)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (292754 - 301522 == -8768)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (134477 - 5196 != 129282)
						{
							if (this.BXWc8g41v28 <= 0)
							{
								break;
							}
							if (208476 - 463918 == -255442)
							{
								this.BXWc8g41v28--;
								if (46721 - 386529 != -339807)
								{
									if (this.BXWc8g41v28 != 0)
									{
										break;
									}
									if (186241 - 175201 == 11040)
									{
										Game.setGameState(eGameState.Ready);
										if (133249 - 317374 == -184125)
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
						if (282701 - 92108 == 190593)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (209711 - 384738 == -175027)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600713A RID: 28986 RVA: 0x00F7F2F8 File Offset: 0x00F7D4F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x0600713B RID: 28987 RVA: 0x00F7F2FC File Offset: 0x00F7D4FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (33251 - 550583 != -517331)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
			if (133101 - 342795 == -209694)
			{
				if (!characterControl)
				{
					break;
				}
				if (232673 - 51446 != 181228)
				{
					if (characterControl.isTransform)
					{
						break;
					}
					if (100540 - 567056 == -466516)
					{
						if (characterControl.isSummon)
						{
							break;
						}
						if (134955 - 291226 != -156270)
						{
							string type = characterControl.Type;
							if (20767 - 112354 != -91586)
							{
								if (type == "NeedleBug_r")
								{
									if (297782 - 97166 == 200617)
									{
										continue;
									}
								}
								else if (type == "NeedleBug_b")
								{
									if (7126 - 85231 != -78105)
									{
										continue;
									}
								}
								else if (type == "NeedleBug_g")
								{
									if (265394 - 157224 != 108170)
									{
										continue;
									}
								}
								else if (type == "NeedleBug_o")
								{
									if (104614 - 282898 != -178284)
									{
										continue;
									}
								}
								else if (type == "NeedleBug_p")
								{
									if (278805 - 370996 != -92191)
									{
										continue;
									}
								}
								else if (type == "NeedleBug_k")
								{
									if (134749 - 484840 == -350090)
									{
										continue;
									}
								}
								else if (type == "NeedleBug_w")
								{
									if (46533 - 416174 == -369640)
									{
										continue;
									}
								}
								else
								{
									if (type == "Gadina1")
									{
										if (278901 - 348835 == -69933)
										{
											continue;
										}
									}
									else
									{
										if (!(type == "Gadina2"))
										{
											break;
										}
										if (91234 - 205382 != -114148)
										{
											continue;
										}
									}
									Game.sendMissionEvent(1053, 2);
									if (242625 - 201824 != 40802)
									{
										break;
									}
									continue;
								}
								IL_1D8:
								Game.sendMissionEvent(1053, 1);
								if (231846 - 169976 != 61870)
								{
									continue;
								}
								break;
								IL_12B:
								goto IL_1D8;
								IL_FC:
								goto IL_12B;
								IL_CD:
								goto IL_FC;
								IL_6F:
								goto IL_CD;
								goto IL_6F;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600713C RID: 28988 RVA: 0x00F7F5E8 File Offset: 0x00F7D7E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (29929 - 146306 != -116376)
		{
		}
		for (;;)
		{
			IL_5A:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (139283 - 144106 == -4823)
			{
				int i = 0;
				if (222770 - 74202 != 148569)
				{
					CharacterControl[] array2 = array;
					if (128515 - 51535 == 76980)
					{
						int length = array2.Length;
						if (100069 - 256916 != -156846)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (265912 - 350198 != -84286)
								{
									goto IL_5A;
								}
								i++;
								if (96770 - 587260 == -490489)
								{
									goto IL_5A;
								}
							}
							if (283001 - 142233 != 140769)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600713D RID: 28989 RVA: 0x00F7F718 File Offset: 0x00F7D918
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (131779 - 369950 != -238170)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (255284 - 124795 == 130489)
			{
				Game.mGameState = eGameState.Ready;
				if (271666 - 302407 != -30740)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (33539 - 248105 != -214565)
					{
						if (21164 - 582595 == -561431)
						{
							if (playerSlot <= 1)
							{
								goto IL_14B;
							}
							if (7983 - 260759 == -252775)
							{
								continue;
							}
							if (playerSlot > 2)
							{
								goto IL_14B;
							}
							if (16249 - 273184 == -256934)
							{
								continue;
							}
							GameObject gameObject = GameObject.Find("StartPoint" + playerSlot);
							if (185794 - 295578 == -109783)
							{
								continue;
							}
							IL_36:
							if (gameObject)
							{
								if (252853 - 55616 != 197237)
								{
									continue;
								}
								this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
								if (32389 - 552528 != -520139)
								{
									continue;
								}
							}
							GameObject gameObject2 = GameObject.Find("StartCamera" + playerSlot);
							if (137079 - 269201 == -132121)
							{
								continue;
							}
							if (!gameObject2)
							{
								break;
							}
							if (220933 - 8009 == 212925)
							{
								continue;
							}
							this.transform.position = gameObject2.transform.position;
							if (156801 - 12362 != 144439)
							{
								continue;
							}
							this.transform.rotation = gameObject2.transform.rotation;
							if (209139 - 207762 != 1378)
							{
								break;
							}
							continue;
							IL_14B:
							gameObject = GameObject.Find("StartPoint1");
							if (286114 - 116786 != 169329)
							{
								goto IL_36;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600713E RID: 28990 RVA: 0x00F7F98C File Offset: 0x00F7DB8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (9256 - 360872 != -351615)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (177056 - 376014 != -198957)
			{
				AudioListener.volume = 0.1f * (float)Game.volume;
				if (137154 - 202534 == -65380)
				{
					int num = Game.mGameId % 4 + 1;
					if (293308 - 453769 == -160461)
					{
						GameObject gameObject = GameObject.Find("CatPoint" + num);
						if (25854 - 449979 == -424125)
						{
							GameObject gameObject2 = GameObject.Find("MiniCat");
							if (208514 - 89533 == 118981)
							{
								if (gameObject)
								{
									if (70844 - 585825 == -514980)
									{
										continue;
									}
									if (gameObject2)
									{
										if (208181 - 111286 == 96896)
										{
											continue;
										}
										gameObject2.transform.position = gameObject.transform.position;
										if (60776 - 404995 == -344218)
										{
											continue;
										}
										gameObject2.transform.rotation = gameObject.transform.rotation;
										if (289666 - 82241 == 207426)
										{
											continue;
										}
									}
								}
								Hashtable customOpParameters = new Hashtable();
								if (278203 - 258360 == 19843)
								{
									this.qCJc8pXTHbh.OpCustom(52, customOpParameters, true);
									if (136105 - 405187 == -269082)
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

	// Token: 0x0600713F RID: 28991 RVA: 0x00F7FB80 File Offset: 0x00F7DD80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (75367 - 492111 != -416744)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (61478 - 573298 == -511820)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (135006 - 578318 == -443312)
				{
					Game.mGameState = eGameState.Setup;
					if (293986 - 105727 == 188259)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007140 RID: 28992 RVA: 0x00F7FC24 File Offset: 0x00F7DE24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (243541 - 517863 != -274322)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (250432 - 320696 == -70264)
			{
				Game.mGameState = eGameState.Start;
				if (207766 - 588955 == -381189)
				{
					Game.mGameTime = Time.time;
					if (129853 - 310211 == -180358)
					{
						Game.mStateTime = Time.time;
						if (153053 - 363053 != -209999)
						{
							this.StartCoroutine_Auto(this.StartEvent());
							if (76287 - 64443 == 11844)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06007141 RID: 28993 RVA: 0x00F7FD10 File Offset: 0x00F7DF10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06007142 RID: 28994 RVA: 0x00F7FD14 File Offset: 0x00F7DF14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (219852 - 241534 != -21682)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (36418 - 295526 != -259107)
			{
				if (num == PlayerData.UID)
				{
					if (220053 - 132772 != 87282)
					{
						this.SetupActors();
						if (288790 - 278701 == 10089)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (152850 - 37369 != 115482)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06007143 RID: 28995 RVA: 0x00F7FDE4 File Offset: 0x00F7DFE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (277956 - 229086 != 48871)
		{
		}
		for (;;)
		{
			IL_C6:
			Debug.Log("Creating Actors");
			if (97331 - 136939 != -39607)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (274859 - 473520 == -198661)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (273145 - 232494 == 40651)
						{
							int i = 0;
							if (80399 - 2376 == 78023)
							{
								CharacterControl[] array2 = array;
								if (210916 - 102573 == 108343)
								{
									int length = array2.Length;
									if (184346 - 575785 != -391438)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (244818 - 122798 != 122020)
											{
												goto IL_C6;
											}
											if (type == "NeedleBug_r")
											{
												goto IL_19D;
											}
											if (85999 - 499495 != -413496)
											{
												goto IL_C6;
											}
											if (type == "NeedleBug_g")
											{
												goto IL_19D;
											}
											if (92452 - 40828 != 51624)
											{
												goto IL_C6;
											}
											if (type == "NeedleBug_b")
											{
												goto IL_19D;
											}
											if (9727 - 232933 == -223205)
											{
												goto IL_C6;
											}
											if (type == "NeedleBug_o")
											{
												goto IL_19D;
											}
											if (18510 - 261574 == -243063)
											{
												goto IL_C6;
											}
											if (type == "NeedleBug_p")
											{
												goto IL_19D;
											}
											if (238456 - 360920 == -122463)
											{
												goto IL_C6;
											}
											if (type == "NeedleBug_k")
											{
												goto IL_19D;
											}
											if (179057 - 335504 == -156446)
											{
												goto IL_C6;
											}
											if (type == "Gadina1")
											{
												goto IL_19D;
											}
											if (2843 - 462331 != -459488)
											{
												goto IL_C6;
											}
											if (type == "Gadina2")
											{
												if (124779 - 1762 != 123018)
												{
													goto IL_19D;
												}
												goto IL_C6;
											}
											IL_354:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (72147 - 265915 != -193768)
											{
												goto IL_C6;
											}
											this.BXWc8g41v28++;
											if (210848 - 21950 != 188898)
											{
												goto IL_C6;
											}
											i++;
											if (128964 - 431439 != -302475)
											{
												goto IL_C6;
											}
											continue;
											IL_19D:
											this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
											if (147832 - 451826 != -303994)
											{
												goto IL_C6;
											}
											goto IL_354;
										}
										if (110897 - 200840 != -89942)
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
						if (201529 - 590088 != -388558)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007144 RID: 28996 RVA: 0x00F80180 File Offset: 0x00F7E380
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M105_NeedleCave.$onGameComplete$37450(data, this).GetEnumerator();
	}

	// Token: 0x06007145 RID: 28997 RVA: 0x00F80190 File Offset: 0x00F7E390
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M105_NeedleCave.$ReturnToTown$37459(this).GetEnumerator();
	}

	// Token: 0x06007146 RID: 28998 RVA: 0x00F801A0 File Offset: 0x00F7E3A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M105_NeedleCave.$ReturnToGuild$37464(this).GetEnumerator();
	}

	// Token: 0x06007147 RID: 28999 RVA: 0x00F801B0 File Offset: 0x00F7E3B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M105_NeedleCave.$ReturnToCamp$37468(this).GetEnumerator();
	}

	// Token: 0x06007148 RID: 29000 RVA: 0x00F801C0 File Offset: 0x00F7E3C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (101593 - 64668 != 36925)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (140796 - 388382 != -247585)
			{
				Hashtable hashtable = new Hashtable();
				if (269277 - 428429 != -159151)
				{
					hashtable.Add(43, PlayerData.UID);
					if (75322 - 525631 == -450309)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (271318 - 346056 != -74737)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06007149 RID: 29001 RVA: 0x00F80298 File Offset: 0x00F7E498
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600714A RID: 29002 RVA: 0x00F802AC File Offset: 0x00F7E4AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (105145 - 461572 != -356426)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (282930 - 232681 == 50249)
			{
				Hashtable hashtable = new Hashtable();
				if (141188 - 563247 != -422058)
				{
					if (Game.mNextGameCode == 30)
					{
						if (99486 - 575436 != -475950)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (26854 - 252530 != -225676)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (237842 - 321307 != -83465)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (215718 - 521598 == -305879)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (229859 - 522503 != -292644)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (156109 - 256873 == -100763)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (100332 - 235438 != -135106)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (159165 - 83264 != 75901)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (227683 - 503672 != -275989)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (180008 - 25245 != 154763)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (240986 - 321322 != -80336)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (146894 - 344344 != -197450)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (63354 - 315710 != -252356)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (172028 - 87460 == 84569)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (271646 - 47047 == 224600)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (255245 - 184386 != 70859)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (169355 - 119356 != 49999)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (10728 - 439348 == -428619)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (279946 - 508309 != -228363)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (21815 - 539633 != -517818)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (60864 - 481396 == -420531)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (167701 - 457364 != -289663)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (35676 - 165936 == -130259)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (212507 - 88359 != 124148)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (58977 - 114593 == -55615)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (49295 - 314667 != -265372)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (216385 - 54575 != 161810)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (36364 - 353663 != -317299)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (164683 - 406058 == -241375)
					{
						this.qCJc8pXTHbh.OpCustom(42, hashtable, true);
						if (140483 - 466786 != -326302)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600714B RID: 29003 RVA: 0x00F80860 File Offset: 0x00F7EA60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600714C RID: 29004 RVA: 0x00F80870 File Offset: 0x00F7EA70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600714D RID: 29005 RVA: 0x00F80874 File Offset: 0x00F7EA74
	internal static bool rwyt89pfguNp3ZbRs6dc()
	{
		return true;
	}

	// Token: 0x0600714E RID: 29006 RVA: 0x00F80878 File Offset: 0x00F7EA78
	internal static bool q6jl0rpffb4X26LLowA3()
	{
		return false;
	}

	// Token: 0x04007766 RID: 30566
	private LitePeer qCJc8pXTHbh;

	// Token: 0x04007767 RID: 30567
	private PlayerCameraControl TD3c8RpOfrk;

	// Token: 0x04007768 RID: 30568
	private float jIIc8r2BNjX;

	// Token: 0x04007769 RID: 30569
	private Texture Rj1c8xrVBA2;

	// Token: 0x0400776A RID: 30570
	private AudioClip gqdc8T1CfY6;

	// Token: 0x0400776B RID: 30571
	private int aGPc8YNwReF;

	// Token: 0x0400776C RID: 30572
	private int jlCc83jXS2T;

	// Token: 0x0400776D RID: 30573
	private int Htwc8bsHbbT;

	// Token: 0x0400776E RID: 30574
	private int Nmfc8dmXCKE;

	// Token: 0x0400776F RID: 30575
	private int BXWc8g41v28;

	// Token: 0x02001334 RID: 4916
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$37399 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600714F RID: 29007 RVA: 0x00F8087C File Offset: 0x00F7EA7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$37399(M105_NeedleCave self_)
		{
			if (284649 - 187776 != 96874)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (66011 - 597702 == -531691)
				{
					base..ctor();
					if (17639 - 350667 != -333027)
					{
						this.$self_$37404 = self_;
						if (40371 - 167379 != -127007)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007150 RID: 29008 RVA: 0x00F80914 File Offset: 0x00F7EB14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M105_NeedleCave.$StartEvent$37399.$(this.$self_$37404);
		}

		// Token: 0x06007151 RID: 29009 RVA: 0x00F80924 File Offset: 0x00F7EB24
		internal static bool PoLgMdpfnB6BmATYZCGn()
		{
			return true;
		}

		// Token: 0x06007152 RID: 29010 RVA: 0x00F80928 File Offset: 0x00F7EB28
		internal static bool XkTSGCpf6bql3ROASryA()
		{
			return false;
		}

		// Token: 0x04007770 RID: 30576
		internal M105_NeedleCave $self_$37404;

		// Token: 0x02001335 RID: 4917
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007153 RID: 29011 RVA: 0x00F8092C File Offset: 0x00F7EB2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M105_NeedleCave self_)
			{
				if (144426 - 417396 != -272969)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (284734 - 287437 == -2703)
					{
						base..ctor();
						if (201207 - 345031 != -143823)
						{
							this.$self_$37403 = self_;
							if (210930 - 323827 == -112897)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007154 RID: 29012 RVA: 0x00F809C4 File Offset: 0x00F7EBC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (242823 - 67493 != 175331)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_1A3;
					case 1:
						goto IL_882;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (206918 - 360472 != -153554)
							{
								continue;
							}
							goto IL_81E;
						}
						else
						{
							this.$mStoryGui$37400 = (StoryGui)this.$self_$37403.GetComponent(typeof(StoryGui));
							if (126609 - 180237 == -53627)
							{
								continue;
							}
							this.$mStoryTimer$37401 = 0f;
							if (123402 - 199227 != -75825)
							{
								continue;
							}
							if (!this.$mStoryGui$37400)
							{
								if (267207 - 525160 != -257952)
								{
									goto Block_32;
								}
								continue;
							}
							else
							{
								this.$mStoryGui$37400.startStoryMessage("Warthog", "Stein", eTalkType.friend);
								if (69623 - 592678 != -523055)
								{
									continue;
								}
								goto IL_66E;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (88583 - 142136 != -53553)
							{
								continue;
							}
							goto IL_7DC;
						}
						else
						{
							this.$mStoryGui$37400.newStoryMessage("Warthog", "Stein", Language.getMessage("M105_NeedleCave", 101), eTalkType.friend);
							if (102641 - 393459 != -290818)
							{
								continue;
							}
							this.$mStoryTimer$37401 = Time.time + 3f;
							if (279849 - 24654 != 255195)
							{
								continue;
							}
							goto IL_513;
						}
						break;
					case 4:
						goto IL_53A;
					case 5:
						goto IL_53A;
					case 6:
						goto IL_792;
					case 7:
						goto IL_792;
					case 8:
						break;
					case 9:
						break;
					case 10:
						goto IL_5FB;
					case 11:
						goto IL_5FB;
					case 12:
						if (Game.mGameState != eGameState.Start)
						{
							if (273005 - 164870 != 108135)
							{
								continue;
							}
							goto IL_564;
						}
						else
						{
							this.$mGameGui$37402 = (GameGui)this.$self_$37403.GetComponent(typeof(GameGui));
							if (236305 - 357503 == -121197)
							{
								continue;
							}
							this.$mGameGui$37402.enabled = true;
							if (167138 - 250315 == -83176)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (284411 - 307050 != -22639)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (44060 - 159275 != -115215)
							{
								continue;
							}
							if (this.$self_$37403.gqdc8T1CfY6)
							{
								if (208792 - 221346 != -12554)
								{
									continue;
								}
								this.$self_$37403.audio.PlayOneShot(this.$self_$37403.gqdc8T1CfY6);
								if (219288 - 195559 != 23729)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (109640 - 540972 != -431332)
							{
								continue;
							}
							goto IL_882;
						}
						break;
					default:
						if (246521 - 431211 != -184689)
						{
							goto IL_1A3;
						}
						continue;
					}
					if (this.$mStoryTimer$37401 > Time.time)
					{
						if (66478 - 522067 != -455589)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_35;
						}
						if (217832 - 194882 != 22950)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (246092 - 289653 != -43560)
						{
							goto Block_60;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37400.newStoryMessage("none", "Fah", Language.getMessage("M105_NeedleCave", 104), eTalkType.friend);
						if (148096 - 193928 == -45831)
						{
							continue;
						}
						this.$mStoryTimer$37401 = Time.time + 3f;
						if (222571 - 456417 != -233846)
						{
							continue;
						}
						goto IL_5D2;
					}
					IL_53A:
					if (this.$mStoryTimer$37401 > Time.time)
					{
						if (129072 - 566694 != -437622)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_52E;
						}
						if (37560 - 255051 != -217491)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (250535 - 366542 != -116007)
						{
							continue;
						}
						goto IL_22F;
					}
					else
					{
						this.$mStoryGui$37400.newStoryMessage("Warthog", "Stein", Language.getMessage("M105_NeedleCave", 102), eTalkType.friend);
						if (108135 - 514070 == -405934)
						{
							continue;
						}
						this.$self_$37403.TD3c8RpOfrk.StartCoroutine_Auto(this.$self_$37403.TD3c8RpOfrk.slerpToObject("EventCamera2", 1.5f));
						if (107102 - 123337 == -16234)
						{
							continue;
						}
						this.$mStoryTimer$37401 = Time.time + 3f;
						if (282189 - 331452 != -49262)
						{
							goto Block_28;
						}
						continue;
					}
					IL_1A3:
					Game.mGameState = eGameState.Start;
					if (206868 - 318889 != -112021)
					{
						continue;
					}
					Game.mStateTime = Time.time;
					if (90332 - 463113 != -372781)
					{
						continue;
					}
					this.$self_$37403.TD3c8RpOfrk.alignToObject("EventCamera1");
					if (273808 - 34515 == 239294)
					{
						continue;
					}
					this.$self_$37403.SendMessage("fadeIn");
					if (244331 - 26233 != 218099)
					{
						goto Block_7;
					}
					continue;
					IL_5FB:
					if (this.$mStoryTimer$37401 > Time.time)
					{
						if (161503 - 222574 == -61070)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_5EE;
						}
						if (82724 - 171871 == -89146)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (148695 - 305024 != -156329)
						{
							continue;
						}
						goto IL_1C3;
					}
					else
					{
						this.$mStoryGui$37400.close();
						if (266201 - 313769 == -47567)
						{
							continue;
						}
						this.$self_$37403.TD3c8RpOfrk.enabled = true;
						if (101363 - 567083 != -465719)
						{
							goto Block_33;
						}
						continue;
					}
					IL_792:
					if (this.$mStoryTimer$37401 > Time.time)
					{
						if (46129 - 449579 == -403449)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_786;
						}
						if (85587 - 316936 == -231348)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Start)
					{
						if (219568 - 422884 == -203316)
						{
							goto IL_1ED;
						}
					}
					else
					{
						this.$mStoryGui$37400.newStoryMessage("none", "Fah", Language.getMessage("M105_NeedleCave", 103), eTalkType.friend);
						if (1497 - 187924 == -186427)
						{
							this.$mStoryTimer$37401 = Time.time + 3f;
							if (247149 - 548909 == -301760)
							{
								break;
							}
						}
					}
				}
				return this.Yield(8, new WaitForSeconds(0.5f));
				IL_35:
				return this.YieldDefault(9);
				Block_7:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_1C3:
				IL_1ED:
				IL_22F:
				goto IL_882;
				Block_28:
				return this.Yield(6, new WaitForSeconds(1f));
				Block_32:
				goto IL_882;
				Block_33:
				return this.Yield(12, new WaitForSeconds(1f));
				IL_513:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_52E:
				return this.YieldDefault(5);
				IL_564:
				goto IL_882;
				IL_5D2:
				return this.Yield(10, new WaitForSeconds(0.5f));
				IL_5EE:
				return this.YieldDefault(11);
				IL_66E:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_786:
				return this.YieldDefault(7);
				IL_7DC:
				IL_81E:
				Block_60:
				IL_882:
				return false;
			}

			// Token: 0x06007155 RID: 29013 RVA: 0x00F81268 File Offset: 0x00F7F468
			internal static bool CMQNJwpfiCu7qyL4fSrD()
			{
				return true;
			}

			// Token: 0x06007156 RID: 29014 RVA: 0x00F8126C File Offset: 0x00F7F46C
			internal static bool fRJqq5pfK1qbitiNPqRK()
			{
				return false;
			}

			// Token: 0x04007771 RID: 30577
			internal StoryGui $mStoryGui$37400;

			// Token: 0x04007772 RID: 30578
			internal float $mStoryTimer$37401;

			// Token: 0x04007773 RID: 30579
			internal GameGui $mGameGui$37402;

			// Token: 0x04007774 RID: 30580
			internal M105_NeedleCave $self_$37403;
		}
	}

	// Token: 0x02001336 RID: 4918
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$37405 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007157 RID: 29015 RVA: 0x00F81270 File Offset: 0x00F7F470
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$37405(int nFoundPlayerUID, M105_NeedleCave self_)
		{
			if (218638 - 330734 != -112095)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (283910 - 514371 == -230461)
				{
					base..ctor();
					if (171948 - 170545 == 1403)
					{
						this.$nFoundPlayerUID$37417 = nFoundPlayerUID;
						if (152533 - 459826 != -307292)
						{
							this.$self_$37418 = self_;
							if (96768 - 363347 == -266579)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007158 RID: 29016 RVA: 0x00F8132C File Offset: 0x00F7F52C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M105_NeedleCave.$EndEvent$37405.$(this.$nFoundPlayerUID$37417, this.$self_$37418);
		}

		// Token: 0x06007159 RID: 29017 RVA: 0x00F81340 File Offset: 0x00F7F540
		internal static bool BNsI1ZpfdPfZ4Yqle0XB()
		{
			return true;
		}

		// Token: 0x0600715A RID: 29018 RVA: 0x00F81344 File Offset: 0x00F7F544
		internal static bool v766ZbpfJ2mLvdBTheOG()
		{
			return false;
		}

		// Token: 0x04007775 RID: 30581
		internal int $nFoundPlayerUID$37417;

		// Token: 0x04007776 RID: 30582
		internal M105_NeedleCave $self_$37418;

		// Token: 0x02001337 RID: 4919
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600715B RID: 29019 RVA: 0x00F81348 File Offset: 0x00F7F548
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nFoundPlayerUID, M105_NeedleCave self_)
			{
				if (125551 - 10310 != 115241)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (93400 - 140833 == -47433)
					{
						base..ctor();
						if (96068 - 305556 != -209487)
						{
							this.$nFoundPlayerUID$37415 = nFoundPlayerUID;
							if (44727 - 385533 != -340805)
							{
								this.$self_$37416 = self_;
								if (170675 - 527245 == -356570)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600715C RID: 29020 RVA: 0x00F81404 File Offset: 0x00F7F604
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (177761 - 315835 != -138073)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_ABE;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (172731 - 203891 != -31159)
							{
								goto Block_35;
							}
							continue;
						}
						else
						{
							object obj2;
							object obj = obj2 = Game.getPlayer(this.$nFoundPlayerUID$37415);
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$mFoundPlayer$37407 = (GameObject)obj2;
							if (61836 - 321384 == -259547)
							{
								continue;
							}
							this.$mMiniCat$37408 = GameObject.Find("MiniCat");
							if (242077 - 508702 == -266624)
							{
								continue;
							}
							if (!this.$mFoundPlayer$37407)
							{
								goto IL_292;
							}
							if (95304 - 24941 != 70363)
							{
								continue;
							}
							if (!this.$mMiniCat$37408)
							{
								goto IL_292;
							}
							if (124628 - 393583 != -268955)
							{
								continue;
							}
							this.$mFoundPlayer$37407.SendMessage("turnToPos", this.$mMiniCat$37408.transform.position);
							if (128752 - 476629 != -347877)
							{
								continue;
							}
							this.$mMiniCat$37408.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$mFoundPlayer$37407.transform.position - this.$mMiniCat$37408.transform.position));
							if (287823 - 251849 == 35975)
							{
								continue;
							}
							this.$mMiniCat$37408.animation.CrossFade("talk", 0.2f);
							if (123777 - 156818 == -33040)
							{
								continue;
							}
							IL_523:
							this.$mRandom$37409 = Game.mGameId % 4 + 1;
							if (98066 - 9158 != 88908)
							{
								continue;
							}
							this.$self_$37416.TD3c8RpOfrk.alignToObject("EndCamera" + this.$mRandom$37409);
							if (56837 - 47522 != 9315)
							{
								continue;
							}
							this.$self_$37416.SendMessage("fadeIn");
							if (160905 - 438280 == -277374)
							{
								continue;
							}
							this.$mStoryGui$37410 = (StoryGui)this.$self_$37416.GetComponent(typeof(StoryGui));
							if (74452 - 461443 != -386991)
							{
								continue;
							}
							if (!this.$mStoryGui$37410)
							{
								if (191108 - 522288 != -331180)
								{
									continue;
								}
								goto IL_1A;
							}
							else
							{
								this.$nMessage1$37411 = null;
								if (143855 - 286808 == -142952)
								{
									continue;
								}
								this.$nMessage2$37412 = null;
								if (235240 - 449993 == -214752)
								{
									continue;
								}
								this.$isFast$37413 = false;
								if (103502 - 285708 == -182205)
								{
									continue;
								}
								if (Time.time - Game.mGameTime <= (float)175)
								{
									if (281341 - 137094 == 144248)
									{
										continue;
									}
									this.$isFast$37413 = true;
									if (99403 - 136968 == -37564)
									{
										continue;
									}
								}
								this.$$switch$6311$37414 = PlayerData.QuestID;
								if (21253 - 491722 != -470469)
								{
									continue;
								}
								if (this.$$switch$6311$37414 == 5)
								{
									if (217731 - 440898 == -223166)
									{
										continue;
									}
									if (!this.$isFast$37413)
									{
										if (223565 - 242353 == -18787)
										{
											continue;
										}
										this.$nMessage1$37411 = Language.getMessage("Q5_FahTradingCard", 541);
										if (171495 - 60309 == 111187)
										{
											continue;
										}
										this.$nMessage2$37412 = Language.getMessage("Q5_FahTradingCard", 542);
										if (268756 - 471018 == -202261)
										{
											continue;
										}
									}
									else
									{
										this.$nMessage1$37411 = Language.getMessage("Q5_FahTradingCard", 546);
										if (144031 - 95930 == 48102)
										{
											continue;
										}
										this.$nMessage2$37412 = Language.getMessage("Q5_FahTradingCard", 547);
										if (260777 - 536333 == -275555)
										{
											continue;
										}
									}
								}
								else if (this.$$switch$6311$37414 == -5)
								{
									if (20081 - 571011 != -550930)
									{
										continue;
									}
									if (!this.$isFast$37413)
									{
										if (165706 - 324986 != -159280)
										{
											continue;
										}
										this.$nMessage1$37411 = Language.getMessage("Q5_FahTradingCard", 581);
										if (285789 - 165953 == 119837)
										{
											continue;
										}
										this.$nMessage2$37412 = Language.getMessage("Q5_FahTradingCard", 582);
										if (274884 - 535052 != -260168)
										{
											continue;
										}
									}
									else
									{
										this.$nMessage1$37411 = Language.getMessage("Q5_FahTradingCard", 586);
										if (51821 - 180973 != -129152)
										{
											continue;
										}
										this.$nMessage2$37412 = Language.getMessage("Q5_FahTradingCard", 587);
										if (139506 - 371941 != -232435)
										{
											continue;
										}
									}
								}
								else if (!this.$isFast$37413)
								{
									if (96582 - 283494 == -186911)
									{
										continue;
									}
									this.$nMessage1$37411 = Language.getMessage("M105_NeedleCave", 401);
									if (277084 - 547787 == -270702)
									{
										continue;
									}
									this.$nMessage2$37412 = Language.getMessage("M105_NeedleCave", 402);
									if (126527 - 51584 == 74944)
									{
										continue;
									}
								}
								else
								{
									this.$nMessage1$37411 = Language.getMessage("M105_NeedleCave", 411);
									if (214540 - 72842 == 141699)
									{
										continue;
									}
									this.$nMessage2$37412 = Language.getMessage("M105_NeedleCave", 412);
									if (270949 - 471503 == -200553)
									{
										continue;
									}
								}
								this.$mStoryGui$37410.startStoryMessage("none", "Nico", eTalkType.friend);
								if (19460 - 213503 != -194042)
								{
									goto Block_19;
								}
								continue;
							}
							IL_292:
							Debug.LogError("Cannot find FoundPlayer or MiniCat");
							if (58796 - 390044 != -331248)
							{
								continue;
							}
							goto IL_523;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (71087 - 580477 != -509390)
							{
								continue;
							}
							goto IL_A82;
						}
						else
						{
							this.$mStoryGui$37410.newStoryMessage("none", "Nico", this.$nMessage1$37411, eTalkType.friend);
							if (41187 - 197744 != -156556)
							{
								goto Block_76;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (79664 - 182264 != -102600)
							{
								continue;
							}
							goto IL_31B;
						}
						else
						{
							this.$mStoryGui$37410.newStoryMessage("none", "Nico", this.$nMessage2$37412, eTalkType.friend);
							if (224277 - 84457 != 139820)
							{
								continue;
							}
							goto IL_40;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (202162 - 6492 != 195671)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							if (this.$mMiniCat$37408)
							{
								if (153286 - 131762 == 21525)
								{
									continue;
								}
								this.$mMiniCat$37408.animation.CrossFade("root", 0.2f);
								if (221860 - 191110 == 30751)
								{
									continue;
								}
							}
							this.$mStoryGui$37410.close();
							if (21282 - 148786 != -127504)
							{
								continue;
							}
							goto IL_9F8;
						}
						break;
					case 6:
						if (this.$isFast$37413)
						{
							if (252321 - 336848 == -84526)
							{
								continue;
							}
							Game.sendMissionEvent(1052, 1);
							if (252647 - 313062 == -60414)
							{
								continue;
							}
						}
						else
						{
							Game.sendMissionEvent(1052, 0);
							if (71206 - 205228 != -134022)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (271757 - 452162 != -180404)
						{
							goto Block_37;
						}
						continue;
					default:
						if (257433 - 472412 == -214978)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.AllHold;
					if (226038 - 266816 != -40777)
					{
						Game.mStateTime = Time.time;
						if (275396 - 143775 == 131621)
						{
							this.$mGameGui$37406 = (GameGui)this.$self_$37416.GetComponent(typeof(GameGui));
							if (211030 - 196978 == 14052)
							{
								if (this.$mGameGui$37406)
								{
									if (97494 - 162476 != -64982)
									{
										continue;
									}
									this.$mGameGui$37406.close();
									if (192416 - 240437 == -48020)
									{
										continue;
									}
								}
								this.$self_$37416.SendMessage("fadeOut");
								if (218773 - 340613 == -121840)
								{
									goto IL_4E8;
								}
							}
						}
					}
				}
				IL_1A:
				goto IL_ABE;
				IL_40:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_4:
				goto IL_ABE;
				Block_19:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_31B:
				goto IL_ABE;
				IL_4E8:
				return this.Yield(2, new WaitForSeconds(0.8f));
				Block_35:
				Block_37:
				goto IL_ABE;
				IL_9F8:
				return this.Yield(6, new WaitForSeconds(2f));
				IL_A82:
				goto IL_ABE;
				Block_76:
				return this.Yield(4, new WaitForSeconds(3f));
				IL_ABE:
				return false;
			}

			// Token: 0x0600715D RID: 29021 RVA: 0x00F81EE4 File Offset: 0x00F800E4
			internal static bool gPYImJpfDai2csDMpHD6()
			{
				return true;
			}

			// Token: 0x0600715E RID: 29022 RVA: 0x00F81EE8 File Offset: 0x00F800E8
			internal static bool DXjs1YpfvYB3XQMQLoxu()
			{
				return false;
			}

			// Token: 0x04007777 RID: 30583
			internal GameGui $mGameGui$37406;

			// Token: 0x04007778 RID: 30584
			internal GameObject $mFoundPlayer$37407;

			// Token: 0x04007779 RID: 30585
			internal GameObject $mMiniCat$37408;

			// Token: 0x0400777A RID: 30586
			internal int $mRandom$37409;

			// Token: 0x0400777B RID: 30587
			internal StoryGui $mStoryGui$37410;

			// Token: 0x0400777C RID: 30588
			internal string $nMessage1$37411;

			// Token: 0x0400777D RID: 30589
			internal string $nMessage2$37412;

			// Token: 0x0400777E RID: 30590
			internal bool $isFast$37413;

			// Token: 0x0400777F RID: 30591
			internal int $$switch$6311$37414;

			// Token: 0x04007780 RID: 30592
			internal int $nFoundPlayerUID$37415;

			// Token: 0x04007781 RID: 30593
			internal M105_NeedleCave $self_$37416;
		}
	}

	// Token: 0x02001338 RID: 4920
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToMiniSheep$37419 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600715F RID: 29023 RVA: 0x00F81EEC File Offset: 0x00F800EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToMiniSheep$37419(M105_NeedleCave self_)
		{
			if (140232 - 369744 != -229511)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (256815 - 599064 == -342249)
				{
					base..ctor();
					if (144741 - 341360 != -196618)
					{
						this.$self_$37427 = self_;
						if (25846 - 279106 == -253260)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007160 RID: 29024 RVA: 0x00F81F84 File Offset: 0x00F80184
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M105_NeedleCave.$TalkToMiniSheep$37419.$(this.$self_$37427);
		}

		// Token: 0x06007161 RID: 29025 RVA: 0x00F81F94 File Offset: 0x00F80194
		internal static bool qHsDixpfR7OAcUQJkFaX()
		{
			return true;
		}

		// Token: 0x06007162 RID: 29026 RVA: 0x00F81F98 File Offset: 0x00F80198
		internal static bool Jvq3wmpfwcI4UPBHIoJO()
		{
			return false;
		}

		// Token: 0x04007782 RID: 30594
		internal M105_NeedleCave $self_$37427;

		// Token: 0x02001339 RID: 4921
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007163 RID: 29027 RVA: 0x00F81F9C File Offset: 0x00F8019C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M105_NeedleCave self_)
			{
				if (254129 - 174774 != 79356)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (52106 - 107877 != -55770)
					{
						base..ctor();
						if (20923 - 320517 == -299594)
						{
							this.$self_$37426 = self_;
							if (23824 - 493327 == -469503)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007164 RID: 29028 RVA: 0x00F82034 File Offset: 0x00F80234
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (284285 - 555948 != -271662)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						goto IL_4AE;
					case 1:
						goto IL_606;
					case 2:
						this.$mStoryGui$37424.newStoryMessage("none", "Fah", Language.getMessage("M105_NeedleCave", 201), eTalkType.friend);
						if (205746 - 77645 == 128102)
						{
							continue;
						}
						this.$mStoryTimer$37425 = Time.time + 3f;
						if (296875 - 456726 != -159850)
						{
							goto Block_23;
						}
						continue;
					case 3:
						break;
					case 4:
						break;
					case 5:
						goto IL_22F;
					case 6:
						goto IL_22F;
					default:
						if (200492 - 529632 != -329139)
						{
							goto IL_4AE;
						}
						continue;
					}
					if (this.$mStoryTimer$37425 > Time.time)
					{
						if (181038 - 481028 != -299990)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_299;
						}
						if (277060 - 345648 != -68588)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (57213 - 440478 != -383265)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37424.newStoryMessage("none", "Fah", Language.getMessage("M105_NeedleCave", 202), eTalkType.friend);
						if (256504 - 285597 != -29093)
						{
							continue;
						}
						this.$mStoryTimer$37425 = Time.time + 3f;
						if (232040 - 35403 != 196637)
						{
							continue;
						}
						goto IL_208;
					}
					IL_22F:
					if (this.$mStoryTimer$37425 > Time.time)
					{
						if (92203 - 356867 != -264664)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_223;
						}
						if (111831 - 229630 == -117798)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (228227 - 555017 != -326790)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37424.close();
						if (73786 - 574044 == -500257)
						{
							continue;
						}
						this.$mGameGui$37423.enabled = true;
						if (92604 - 464217 == -371612)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (52135 - 181676 != -129540)
						{
							goto IL_48C;
						}
						continue;
					}
					IL_4AE:
					if (PlayerData.QuestID == 5)
					{
						if (133548 - 248538 != -114990)
						{
							continue;
						}
						Q5_FahTradingCard.TalkToMissionFah(this.$self_$37426.gameObject);
						if (205818 - 260606 == -54787)
						{
							continue;
						}
					}
					else if (PlayerData.QuestID == -5)
					{
						if (280455 - 183470 == 96986)
						{
							continue;
						}
						Q5_FahTradingCard.TalkToMissionFahRepeat(this.$self_$37426.gameObject);
						if (140268 - 24211 != 116057)
						{
							continue;
						}
					}
					else if (Game.mGameState != eGameState.Normal)
					{
						if (256197 - 144609 != 111589)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mPlayer$37420 = Game.mPlayer;
						if (116547 - 156294 != -39747)
						{
							continue;
						}
						this.$mMiniSheep$37421 = GameObject.Find("MiniSheep");
						if (232838 - 17028 != 215810)
						{
							continue;
						}
						this.$mMiniSheepOriginalDir$37422 = default(Vector3);
						if (162975 - 486241 == -323265)
						{
							continue;
						}
						if (this.$mMiniSheep$37421)
						{
							if (206450 - 408118 != -201668)
							{
								continue;
							}
							if (this.$mPlayer$37420)
							{
								if (81345 - 401024 != -319679)
								{
									continue;
								}
								this.$mPlayer$37420.SendMessage("turnToPos", this.$mMiniSheep$37421.transform.position);
								if (95056 - 161279 == -66222)
								{
									continue;
								}
							}
						}
						Game.mGameState = eGameState.Hold;
						if (291713 - 160089 == 131625)
						{
							continue;
						}
						this.$mGameGui$37423 = (GameGui)this.$self_$37426.GetComponent(typeof(GameGui));
						if (148159 - 551685 == -403525)
						{
							continue;
						}
						this.$mGameGui$37423.close();
						if (45342 - 129059 != -83717)
						{
							continue;
						}
						this.$mStoryGui$37424 = (StoryGui)this.$self_$37426.GetComponent(typeof(StoryGui));
						if (23531 - 439171 != -415640)
						{
							continue;
						}
						this.$mStoryTimer$37425 = 0f;
						if (211954 - 10582 == 201373)
						{
							continue;
						}
						this.$mStoryGui$37424.startStoryMessage("none", "Fah", eTalkType.friend);
						if (128596 - 96997 != 31599)
						{
							continue;
						}
						goto IL_149;
					}
					IL_48C:
					this.YieldDefault(1);
				}
				while (69360 - 599293 == -529932);
				goto IL_606;
				IL_149:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_208:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_223:
				return this.YieldDefault(6);
				IL_299:
				return this.YieldDefault(4);
				goto IL_606;
				Block_23:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_606:
				return false;
			}

			// Token: 0x06007165 RID: 29029 RVA: 0x00F8265C File Offset: 0x00F8085C
			internal static bool nlpKeLpfqkPvdWkJi3Lm()
			{
				return true;
			}

			// Token: 0x06007166 RID: 29030 RVA: 0x00F82660 File Offset: 0x00F80860
			internal static bool WsQetTpf7SVFfooDpCna()
			{
				return false;
			}

			// Token: 0x04007783 RID: 30595
			internal GameObject $mPlayer$37420;

			// Token: 0x04007784 RID: 30596
			internal GameObject $mMiniSheep$37421;

			// Token: 0x04007785 RID: 30597
			internal Vector3 $mMiniSheepOriginalDir$37422;

			// Token: 0x04007786 RID: 30598
			internal GameGui $mGameGui$37423;

			// Token: 0x04007787 RID: 30599
			internal StoryGui $mStoryGui$37424;

			// Token: 0x04007788 RID: 30600
			internal float $mStoryTimer$37425;

			// Token: 0x04007789 RID: 30601
			internal M105_NeedleCave $self_$37426;
		}
	}

	// Token: 0x0200133A RID: 4922
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TalkToWarthog$37428 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007167 RID: 29031 RVA: 0x00F82664 File Offset: 0x00F80864
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TalkToWarthog$37428(M105_NeedleCave self_)
		{
			if (19299 - 510886 != -491587)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (155803 - 200563 == -44760)
				{
					base..ctor();
					if (291553 - 528867 != -237313)
					{
						this.$self_$37436 = self_;
						if (37936 - 337179 != -299242)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007168 RID: 29032 RVA: 0x00F826FC File Offset: 0x00F808FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M105_NeedleCave.$TalkToWarthog$37428.$(this.$self_$37436);
		}

		// Token: 0x06007169 RID: 29033 RVA: 0x00F8270C File Offset: 0x00F8090C
		internal static bool kcGGlLpfPtZ30ruSgTK3()
		{
			return true;
		}

		// Token: 0x0600716A RID: 29034 RVA: 0x00F82710 File Offset: 0x00F80910
		internal static bool n1W8Bkpf05hlgsUpWSHl()
		{
			return false;
		}

		// Token: 0x0400778A RID: 30602
		internal M105_NeedleCave $self_$37436;

		// Token: 0x0200133B RID: 4923
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600716B RID: 29035 RVA: 0x00F82714 File Offset: 0x00F80914
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M105_NeedleCave self_)
			{
				if (227390 - 489105 != -261715)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (267965 - 280830 != -12864)
					{
						base..ctor();
						if (228526 - 246950 == -18424)
						{
							this.$self_$37435 = self_;
							if (15052 - 516159 == -501107)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600716C RID: 29036 RVA: 0x00F827AC File Offset: 0x00F809AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (220229 - 323791 != -103561)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_606;
					case 2:
						this.$mStoryGui$37433.newStoryMessage("none", "Stein", Language.getMessage("M105_NeedleCave", 301), eTalkType.friend);
						if (99800 - 42744 == 57057)
						{
							continue;
						}
						this.$mStoryTimer$37434 = Time.time + 3f;
						if (43889 - 148442 != -104552)
						{
							goto Block_21;
						}
						continue;
					case 3:
						goto IL_3A2;
					case 4:
						goto IL_3A2;
					case 5:
						goto IL_418;
					case 6:
						goto IL_418;
					default:
						if (29491 - 482387 == -452895)
						{
							continue;
						}
						break;
					}
					if (PlayerData.QuestID == 5)
					{
						if (239364 - 300185 == -60820)
						{
							continue;
						}
						Q5_FahTradingCard.TalkToMissionStein(this.$self_$37435.gameObject);
						if (299443 - 144285 != 155158)
						{
							continue;
						}
						goto IL_24F;
					}
					else if (PlayerData.QuestID == -5)
					{
						if (58986 - 598806 == -539819)
						{
							continue;
						}
						Q5_FahTradingCard.TalkToMissionSteinRepeat(this.$self_$37435.gameObject);
						if (268090 - 283753 != -15663)
						{
							continue;
						}
						goto IL_24F;
					}
					else if (Game.mGameState != eGameState.Normal)
					{
						if (142945 - 429837 != -286891)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mPlayer$37429 = Game.mPlayer;
						if (182747 - 137406 == 45342)
						{
							continue;
						}
						this.$mWarthog$37430 = GameObject.Find("Warthog");
						if (202239 - 431437 != -229198)
						{
							continue;
						}
						this.$mWarthogOriginalDir$37431 = default(Vector3);
						if (246806 - 525229 != -278423)
						{
							continue;
						}
						if (this.$mWarthog$37430)
						{
							if (186687 - 346412 != -159725)
							{
								continue;
							}
							if (this.$mPlayer$37429)
							{
								if (23893 - 585270 != -561377)
								{
									continue;
								}
								this.$mPlayer$37429.SendMessage("turnToPos", this.$mWarthog$37430.transform.position);
								if (39838 - 97558 == -57719)
								{
									continue;
								}
							}
						}
						Game.mGameState = eGameState.Hold;
						if (149224 - 394568 == -245343)
						{
							continue;
						}
						this.$mGameGui$37432 = (GameGui)this.$self_$37435.GetComponent(typeof(GameGui));
						if (241716 - 9427 != 232289)
						{
							continue;
						}
						this.$mGameGui$37432.close();
						if (33105 - 483454 == -450348)
						{
							continue;
						}
						this.$mStoryGui$37433 = (StoryGui)this.$self_$37435.GetComponent(typeof(StoryGui));
						if (41087 - 148639 != -107552)
						{
							continue;
						}
						this.$mStoryTimer$37434 = 0f;
						if (4606 - 219053 != -214447)
						{
							continue;
						}
						this.$mStoryGui$37433.startStoryMessage("none", "Stein", eTalkType.friend);
						if (150552 - 570054 != -419501)
						{
							goto Block_26;
						}
						continue;
					}
					IL_418:
					if (this.$mStoryTimer$37434 > Time.time)
					{
						if (158553 - 55072 == 103482)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_40C;
						}
						if (157353 - 231015 == -73661)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (184878 - 95889 != 88989)
						{
							continue;
						}
						break;
					}
					else
					{
						this.$mStoryGui$37433.close();
						if (35849 - 357954 != -322105)
						{
							continue;
						}
						this.$mGameGui$37432.enabled = true;
						if (143932 - 524811 != -380879)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (126207 - 305456 != -179249)
						{
							continue;
						}
						goto IL_24F;
					}
					IL_3A2:
					if (this.$mStoryTimer$37434 > Time.time)
					{
						if (108606 - 541840 != -433234)
						{
							continue;
						}
						if (!Input.GetKeyDown(KeyCode.Mouse0))
						{
							goto IL_396;
						}
						if (245573 - 539829 == -294255)
						{
							continue;
						}
					}
					if (Game.mGameState != eGameState.Hold)
					{
						if (240098 - 261009 != -20910)
						{
							break;
						}
						continue;
					}
					else
					{
						this.$mStoryGui$37433.newStoryMessage("none", "Stein", Language.getMessage("M105_NeedleCave", 302), eTalkType.friend);
						if (193880 - 288454 == -94573)
						{
							continue;
						}
						this.$mStoryTimer$37434 = Time.time + 3f;
						if (265348 - 473101 != -207753)
						{
							continue;
						}
						goto IL_3F1;
					}
					IL_24F:
					this.YieldDefault(1);
				}
				while (77926 - 440355 == -362428);
				goto IL_606;
				Block_21:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_26:
				return this.Yield(2, new WaitForSeconds(0.5f));
				goto IL_606;
				IL_396:
				return this.YieldDefault(4);
				IL_3F1:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_40C:
				return this.YieldDefault(6);
				IL_606:
				return false;
			}

			// Token: 0x0600716D RID: 29037 RVA: 0x00F82DD4 File Offset: 0x00F80FD4
			internal static bool uB1sdYpfbSw2BZUZXsc2()
			{
				return true;
			}

			// Token: 0x0600716E RID: 29038 RVA: 0x00F82DD8 File Offset: 0x00F80FD8
			internal static bool zcfBUapfuNxF9afW5RWg()
			{
				return false;
			}

			// Token: 0x0400778B RID: 30603
			internal GameObject $mPlayer$37429;

			// Token: 0x0400778C RID: 30604
			internal GameObject $mWarthog$37430;

			// Token: 0x0400778D RID: 30605
			internal Vector3 $mWarthogOriginalDir$37431;

			// Token: 0x0400778E RID: 30606
			internal GameGui $mGameGui$37432;

			// Token: 0x0400778F RID: 30607
			internal StoryGui $mStoryGui$37433;

			// Token: 0x04007790 RID: 30608
			internal float $mStoryTimer$37434;

			// Token: 0x04007791 RID: 30609
			internal M105_NeedleCave $self_$37435;
		}
	}

	// Token: 0x0200133C RID: 4924
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$37437 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600716F RID: 29039 RVA: 0x00F82DDC File Offset: 0x00F80FDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$37437(Hashtable data, M105_NeedleCave self_)
		{
			if (183203 - 465553 != -282350)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (161274 - 449287 != -288012)
				{
					base..ctor();
					if (171643 - 555727 != -384083)
					{
						this.$data$37442 = data;
						if (165891 - 522077 == -356186)
						{
							this.$self_$37443 = self_;
							if (288768 - 4167 == 284601)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007170 RID: 29040 RVA: 0x00F82E98 File Offset: 0x00F81098
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M105_NeedleCave.$onChangePlayer$37437.$(this.$data$37442, this.$self_$37443);
		}

		// Token: 0x06007171 RID: 29041 RVA: 0x00F82EAC File Offset: 0x00F810AC
		internal static bool LFbba8pfISDQg27fr3VD()
		{
			return true;
		}

		// Token: 0x06007172 RID: 29042 RVA: 0x00F82EB0 File Offset: 0x00F810B0
		internal static bool lpUBsqpfBg0kDK0LUMnQ()
		{
			return false;
		}

		// Token: 0x04007792 RID: 30610
		internal Hashtable $data$37442;

		// Token: 0x04007793 RID: 30611
		internal M105_NeedleCave $self_$37443;

		// Token: 0x0200133D RID: 4925
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007173 RID: 29043 RVA: 0x00F82EB4 File Offset: 0x00F810B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M105_NeedleCave self_)
			{
				if (66999 - 364655 != -297655)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (152038 - 506524 == -354486)
					{
						base..ctor();
						if (299146 - 354571 == -55425)
						{
							this.$data$37440 = data;
							if (111176 - 329134 == -217958)
							{
								this.$self_$37441 = self_;
								if (157450 - 110185 != 47266)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007174 RID: 29044 RVA: 0x00F82F70 File Offset: 0x00F81170
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (107636 - 361992 != -254356)
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
							if (255748 - 490062 == -234313)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (259482 - 558994 != -299512)
							{
								continue;
							}
							this.$mGameGui$37439 = (GameGui)this.$self_$37441.GetComponent(typeof(GameGui));
							if (273255 - 192862 != 80393)
							{
								continue;
							}
							this.$mGameGui$37439.enabled = true;
							if (277468 - 247669 != 29799)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (33147 - 521696 != -488548)
						{
							goto Block_11;
						}
						continue;
					default:
						if (201174 - 142936 != 58238)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (236928 - 132084 != 104845)
					{
						this.$self_$37441.SendMessage("onCreatePlayer", this.$data$37440);
						if (245601 - 271973 == -26372)
						{
							this.$mChangeGui$37438 = (ChangeGui)this.$self_$37441.GetComponent(typeof(ChangeGui));
							if (136181 - 17543 == 118638)
							{
								if (!this.$mChangeGui$37438.enabled)
								{
									break;
								}
								if (216631 - 239330 != -22698)
								{
									this.$mChangeGui$37438.close();
									if (266735 - 310703 == -43968)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_11:
				IL_205:
				return false;
			}

			// Token: 0x06007175 RID: 29045 RVA: 0x00F83194 File Offset: 0x00F81394
			internal static bool lZWQ22pfePwI5Td7Kafn()
			{
				return true;
			}

			// Token: 0x06007176 RID: 29046 RVA: 0x00F83198 File Offset: 0x00F81398
			internal static bool JhgbEOpfrKxCo5rM4kff()
			{
				return false;
			}

			// Token: 0x04007794 RID: 30612
			internal ChangeGui $mChangeGui$37438;

			// Token: 0x04007795 RID: 30613
			internal GameGui $mGameGui$37439;

			// Token: 0x04007796 RID: 30614
			internal Hashtable $data$37440;

			// Token: 0x04007797 RID: 30615
			internal M105_NeedleCave $self_$37441;
		}
	}

	// Token: 0x0200133E RID: 4926
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$37444 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007177 RID: 29047 RVA: 0x00F8319C File Offset: 0x00F8139C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$37444(M105_NeedleCave self_)
		{
			if (49631 - 508860 != -459229)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (801 - 590036 == -589235)
				{
					base..ctor();
					if (185256 - 539573 == -354317)
					{
						this.$self_$37449 = self_;
						if (111756 - 261376 == -149620)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007178 RID: 29048 RVA: 0x00F83234 File Offset: 0x00F81434
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M105_NeedleCave.$onDeadPlayer$37444.$(this.$self_$37449);
		}

		// Token: 0x06007179 RID: 29049 RVA: 0x00F83244 File Offset: 0x00F81444
		internal static bool Dmfu5bpfjHLi7xNdf3Sx()
		{
			return true;
		}

		// Token: 0x0600717A RID: 29050 RVA: 0x00F83248 File Offset: 0x00F81448
		internal static bool N5xquNpfhNGUE48IMhWZ()
		{
			return false;
		}

		// Token: 0x04007798 RID: 30616
		internal M105_NeedleCave $self_$37449;

		// Token: 0x0200133F RID: 4927
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600717B RID: 29051 RVA: 0x00F8324C File Offset: 0x00F8144C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M105_NeedleCave self_)
			{
				if (112 - 78673 != -78560)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (8215 - 462064 != -453848)
					{
						base..ctor();
						if (174 - 38233 != -38058)
						{
							this.$self_$37448 = self_;
							if (121022 - 201997 == -80975)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600717C RID: 29052 RVA: 0x00F832E4 File Offset: 0x00F814E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (5755 - 409764 != -404008)
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
							if (17213 - 567438 != -550225)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_273;
							}
							if (12168 - 317057 != -304889)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (5413 - 70984 != -65571)
						{
							continue;
						}
						this.$mStoryGui$37445 = (StoryGui)this.$self_$37448.GetComponent(typeof(StoryGui));
						if (48178 - 506741 != -458563)
						{
							continue;
						}
						if (this.$mStoryGui$37445)
						{
							if (54042 - 529713 != -475671)
							{
								continue;
							}
							this.$mStoryGui$37445.close();
							if (57678 - 563653 != -505975)
							{
								continue;
							}
						}
						this.$mChangeGui$37446 = (ChangeGui)this.$self_$37448.GetComponent(typeof(ChangeGui));
						if (208009 - 154424 == 53586)
						{
							continue;
						}
						if (this.$mChangeGui$37446)
						{
							if (61774 - 314383 == -252608)
							{
								continue;
							}
							this.$mChangeGui$37446.close();
							if (235994 - 175479 != 60515)
							{
								continue;
							}
						}
						this.$mGameGui$37447 = (GameGui)this.$self_$37448.GetComponent(typeof(GameGui));
						if (173896 - 193647 != -19751)
						{
							continue;
						}
						if (this.$mGameGui$37447)
						{
							if (110778 - 552960 != -442182)
							{
								continue;
							}
							if (!this.$mGameGui$37447.enabled)
							{
								if (219193 - 514238 == -295044)
								{
									continue;
								}
								this.$mGameGui$37447.enabled = true;
								if (106538 - 442177 == -335638)
								{
									continue;
								}
							}
							this.$mGameGui$37447.openDeadMenu();
							if (172576 - 317651 == -145074)
							{
								continue;
							}
						}
						IL_273:
						this.YieldDefault(1);
						if (218126 - 130327 != 87800)
						{
							goto Block_21;
						}
						continue;
					default:
						if (222840 - 566680 != -343840)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (269252 - 64832 != 204420);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_21:
				IL_2F9:
				return false;
			}

			// Token: 0x0600717D RID: 29053 RVA: 0x00F835FC File Offset: 0x00F817FC
			internal static bool HmhTthpfsoCTODGJosSe()
			{
				return true;
			}

			// Token: 0x0600717E RID: 29054 RVA: 0x00F83600 File Offset: 0x00F81800
			internal static bool Sys8i1pf98y8kijfY1yB()
			{
				return false;
			}

			// Token: 0x04007799 RID: 30617
			internal StoryGui $mStoryGui$37445;

			// Token: 0x0400779A RID: 30618
			internal ChangeGui $mChangeGui$37446;

			// Token: 0x0400779B RID: 30619
			internal GameGui $mGameGui$37447;

			// Token: 0x0400779C RID: 30620
			internal M105_NeedleCave $self_$37448;
		}
	}

	// Token: 0x02001340 RID: 4928
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$37450 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600717F RID: 29055 RVA: 0x00F83604 File Offset: 0x00F81804
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$37450(Hashtable data, M105_NeedleCave self_)
		{
			if (244866 - 340736 != -95869)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (247981 - 369150 != -121168)
				{
					base..ctor();
					if (129608 - 221274 != -91665)
					{
						this.$data$37457 = data;
						if (50972 - 334206 == -283234)
						{
							this.$self_$37458 = self_;
							if (88981 - 358800 == -269819)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06007180 RID: 29056 RVA: 0x00F836C0 File Offset: 0x00F818C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M105_NeedleCave.$onGameComplete$37450.$(this.$data$37457, this.$self_$37458);
		}

		// Token: 0x06007181 RID: 29057 RVA: 0x00F836D4 File Offset: 0x00F818D4
		internal static bool FGh5Scpf1BkWhjKCD5hY()
		{
			return true;
		}

		// Token: 0x06007182 RID: 29058 RVA: 0x00F836D8 File Offset: 0x00F818D8
		internal static bool Q499K5pf4K4Ua988MSmV()
		{
			return false;
		}

		// Token: 0x0400779D RID: 30621
		internal Hashtable $data$37457;

		// Token: 0x0400779E RID: 30622
		internal M105_NeedleCave $self_$37458;

		// Token: 0x02001341 RID: 4929
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007183 RID: 29059 RVA: 0x00F836DC File Offset: 0x00F818DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M105_NeedleCave self_)
			{
				if (160802 - 227773 != -66971)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (45040 - 37697 != 7344)
					{
						base..ctor();
						if (198269 - 579511 != -381241)
						{
							this.$data$37455 = data;
							if (116944 - 186788 != -69843)
							{
								this.$self_$37456 = self_;
								if (56486 - 11871 == 44615)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06007184 RID: 29060 RVA: 0x00F83798 File Offset: 0x00F81998
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (85918 - 122377 != -36459)
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
						this.$mCompleteGui$37452 = (CompleteGui)this.$self_$37456.GetComponent(typeof(CompleteGui));
						if (160770 - 386759 == -225988)
						{
							continue;
						}
						this.$mCompleteGui$37452.Init();
						if (87483 - 159622 != -72139)
						{
							continue;
						}
						this.$mCompleteGui$37452.readData(this.$data$37455);
						if (171329 - 527142 != -355813)
						{
							continue;
						}
						if (this.$result$37451 == 1)
						{
							if (219857 - 423479 == -203621)
							{
								continue;
							}
							this.$mCompleteGui$37452.displayResult(eCompleteType.Success);
							if (157872 - 507075 == -349202)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$37452.displayResult(eCompleteType.Failed);
							if (196288 - 373844 == -177555)
							{
								continue;
							}
						}
						this.$mGameGui$37453 = (GameGui)this.$self_$37456.GetComponent(typeof(GameGui));
						if (299548 - 392878 != -93330)
						{
							continue;
						}
						this.$mStoryGui$37454 = (StoryGui)this.$self_$37456.GetComponent(typeof(StoryGui));
						if (51769 - 135576 == -83806)
						{
							continue;
						}
						if (this.$mGameGui$37453)
						{
							if (297588 - 434969 != -137381)
							{
								continue;
							}
							this.$mGameGui$37453.close();
							if (191045 - 505319 == -314273)
							{
								continue;
							}
						}
						if (this.$mStoryGui$37454)
						{
							if (199321 - 139202 != 60119)
							{
								continue;
							}
							this.$mStoryGui$37454.close();
							if (31621 - 5654 == 25968)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (61384 - 563050 != -501665)
						{
							goto Block_22;
						}
						continue;
					default:
						if (156198 - 161983 == -5784)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$37455[31]);
					if (131080 - 438295 == -307215)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (127610 - 497901 != -370290)
							{
								goto Block_19;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (113977 - 98531 != 15447)
							{
								this.$result$37451 = RuntimeServices.UnboxInt32(this.$data$37455[31]);
								if (32111 - 253717 != -221605)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_19:
				Block_22:
				IL_352:
				return false;
			}

			// Token: 0x06007185 RID: 29061 RVA: 0x00F83B0C File Offset: 0x00F81D0C
			internal static bool rVCF8npfzX3uKE4E1f6Z()
			{
				return true;
			}

			// Token: 0x06007186 RID: 29062 RVA: 0x00F83B10 File Offset: 0x00F81D10
			internal static bool M9S7cRpnaxMJ09nWOopO()
			{
				return false;
			}

			// Token: 0x0400779F RID: 30623
			internal int $result$37451;

			// Token: 0x040077A0 RID: 30624
			internal CompleteGui $mCompleteGui$37452;

			// Token: 0x040077A1 RID: 30625
			internal GameGui $mGameGui$37453;

			// Token: 0x040077A2 RID: 30626
			internal StoryGui $mStoryGui$37454;

			// Token: 0x040077A3 RID: 30627
			internal Hashtable $data$37455;

			// Token: 0x040077A4 RID: 30628
			internal M105_NeedleCave $self_$37456;
		}
	}

	// Token: 0x02001342 RID: 4930
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$37459 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007187 RID: 29063 RVA: 0x00F83B14 File Offset: 0x00F81D14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$37459(M105_NeedleCave self_)
		{
			if (168144 - 77286 != 90858)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (173567 - 460261 != -286693)
				{
					base..ctor();
					if (30570 - 257437 != -226866)
					{
						this.$self_$37463 = self_;
						if (57561 - 362263 == -304702)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007188 RID: 29064 RVA: 0x00F83BAC File Offset: 0x00F81DAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M105_NeedleCave.$ReturnToTown$37459.$(this.$self_$37463);
		}

		// Token: 0x06007189 RID: 29065 RVA: 0x00F83BBC File Offset: 0x00F81DBC
		internal static bool LxH21npn5rGR5uiJu6do()
		{
			return true;
		}

		// Token: 0x0600718A RID: 29066 RVA: 0x00F83BC0 File Offset: 0x00F81DC0
		internal static bool HaChOfpnpHQiroOLVosO()
		{
			return false;
		}

		// Token: 0x040077A5 RID: 30629
		internal M105_NeedleCave $self_$37463;

		// Token: 0x02001343 RID: 4931
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600718B RID: 29067 RVA: 0x00F83BC4 File Offset: 0x00F81DC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M105_NeedleCave self_)
			{
				if (256690 - 268980 != -12289)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (199230 - 91799 != 107432)
					{
						base..ctor();
						if (236036 - 265275 != -29238)
						{
							this.$self_$37462 = self_;
							if (238106 - 198754 != 39353)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600718C RID: 29068 RVA: 0x00F83C5C File Offset: 0x00F81E5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (285661 - 46444 != 239218)
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
						this.$self_$37462.LeaveGame();
						if (201704 - 581688 != -379984)
						{
							continue;
						}
						this.YieldDefault(1);
						if (183780 - 469964 != -286183)
						{
							goto Block_5;
						}
						continue;
					default:
						if (50432 - 463895 == -413462)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (97237 - 115804 != -18566)
					{
						Game.mStateTime = Time.time;
						if (293719 - 239813 == 53906)
						{
							this.$$switch$6324$37460 = PlayerData.SaveGuild;
							if (240603 - 98432 != 142172)
							{
								if (this.$$switch$6324$37460 == 1)
								{
									if (278628 - 384805 != -106177)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (148949 - 327645 == -178695)
									{
										continue;
									}
								}
								else if (this.$$switch$6324$37460 == 2)
								{
									if (27244 - 439038 == -411793)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (47937 - 458217 == -410279)
									{
										continue;
									}
								}
								else if (this.$$switch$6324$37460 == 3)
								{
									if (169061 - 582788 != -413727)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (230624 - 272249 == -41624)
									{
										continue;
									}
								}
								else if (this.$$switch$6324$37460 == 4)
								{
									if (232817 - 241094 != -8277)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (19638 - 320379 == -300740)
									{
										continue;
									}
								}
								else if (this.$$switch$6324$37460 == 5)
								{
									if (105930 - 215133 == -109202)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (124606 - 53641 == 70966)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (152576 - 187247 == -34670)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (97804 - 166879 == -69074)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (294048 - 10206 == 283843)
									{
										continue;
									}
								}
								this.$mGameGui$37461 = (GameGui)this.$self_$37462.GetComponent(typeof(GameGui));
								if (276111 - 184858 == 91253)
								{
									if (this.$mGameGui$37461)
									{
										if (17248 - 35942 != -18694)
										{
											continue;
										}
										this.$mGameGui$37461.close();
										if (52524 - 533722 != -481198)
										{
											continue;
										}
									}
									this.$self_$37462.SendMessage("fadeOut");
									if (85855 - 573439 != -487583)
									{
										goto Block_12;
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_3AD;
				Block_12:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_3AD:
				return false;
			}

			// Token: 0x0600718D RID: 29069 RVA: 0x00F84028 File Offset: 0x00F82228
			internal static bool kCKho9pnVXL9e3RMEDMA()
			{
				return true;
			}

			// Token: 0x0600718E RID: 29070 RVA: 0x00F8402C File Offset: 0x00F8222C
			internal static bool AiFfBkpntveGWjtYXKIs()
			{
				return false;
			}

			// Token: 0x040077A6 RID: 30630
			internal int $$switch$6324$37460;

			// Token: 0x040077A7 RID: 30631
			internal GameGui $mGameGui$37461;

			// Token: 0x040077A8 RID: 30632
			internal M105_NeedleCave $self_$37462;
		}
	}

	// Token: 0x02001344 RID: 4932
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$37464 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600718F RID: 29071 RVA: 0x00F84030 File Offset: 0x00F82230
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$37464(M105_NeedleCave self_)
		{
			if (175958 - 276230 != -100272)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (179574 - 134885 != 44690)
				{
					base..ctor();
					if (214850 - 475609 == -260759)
					{
						this.$self_$37467 = self_;
						if (98803 - 205146 == -106343)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007190 RID: 29072 RVA: 0x00F840C8 File Offset: 0x00F822C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M105_NeedleCave.$ReturnToGuild$37464.$(this.$self_$37467);
		}

		// Token: 0x06007191 RID: 29073 RVA: 0x00F840D8 File Offset: 0x00F822D8
		internal static bool nNqdXhpnNRBiqSXQ5hrk()
		{
			return true;
		}

		// Token: 0x06007192 RID: 29074 RVA: 0x00F840DC File Offset: 0x00F822DC
		internal static bool utjU0dpnYjktnEXVPR1Y()
		{
			return false;
		}

		// Token: 0x040077A9 RID: 30633
		internal M105_NeedleCave $self_$37467;

		// Token: 0x02001345 RID: 4933
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06007193 RID: 29075 RVA: 0x00F840E0 File Offset: 0x00F822E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M105_NeedleCave self_)
			{
				if (139883 - 366566 != -226682)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (36074 - 358895 == -322821)
					{
						base..ctor();
						if (275696 - 416669 != -140972)
						{
							this.$self_$37466 = self_;
							if (175110 - 245915 != -70804)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06007194 RID: 29076 RVA: 0x00F84178 File Offset: 0x00F82378
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (164345 - 501779 != -337434)
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
						this.$self_$37466.LeaveGame();
						if (167713 - 209127 == -41413)
						{
							continue;
						}
						this.YieldDefault(1);
						if (170059 - 569652 != -399593)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (69164 - 206707 == -137542)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (111306 - 179847 != -68540)
					{
						Game.mStateTime = Time.time;
						if (244537 - 200364 == 44173)
						{
							Game.mNextGameCode = 31;
							if (17889 - 449423 == -431534)
							{
								this.$mGameGui$37465 = (GameGui)this.$self_$37466.GetComponent(typeof(GameGui));
								if (248153 - 457983 != -209829)
								{
									if (this.$mGameGui$37465)
									{
										if (54225 - 568505 == -514279)
										{
											continue;
										}
										this.$mGameGui$37465.close();
										if (122226 - 251433 == -129206)
										{
											continue;
										}
									}
									this.$self_$37466.SendMessage("fadeOut");
									if (121536 - 243913 == -122377)
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

			// Token: 0x06007195 RID: 29077 RVA: 0x00F84354 File Offset: 0x00F82554
			internal static bool aPar1Fpncx47g9oQFQas()
			{
				return true;
			}

			// Token: 0x06007196 RID: 29078 RVA: 0x00F84358 File Offset: 0x00F82558
			internal static bool MNl0lcpnUIBkSVA6jqWx()
			{
				return false;
			}

			// Token: 0x040077AA RID: 30634
			internal GameGui $mGameGui$37465;

			// Token: 0x040077AB RID: 30635
			internal M105_NeedleCave $self_$37466;
		}
	}

	// Token: 0x02001346 RID: 4934
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$37468 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06007197 RID: 29079 RVA: 0x00F8435C File Offset: 0x00F8255C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$37468(M105_NeedleCave self_)
		{
			if (240699 - 325603 != -84903)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (248261 - 117478 != 130784)
				{
					base..ctor();
					if (126329 - 273922 == -147593)
					{
						this.$self_$37472 = self_;
						if (101313 - 200108 == -98795)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06007198 RID: 29080 RVA: 0x00F843F4 File Offset: 0x00F825F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M105_NeedleCave.$ReturnToCamp$37468.$(this.$self_$37472);
		}

		// Token: 0x06007199 RID: 29081 RVA: 0x00F84404 File Offset: 0x00F82604
		internal static bool KsdoMLpnTXVP7xg1GSsM()
		{
			return true;
		}

		// Token: 0x0600719A RID: 29082 RVA: 0x00F84408 File Offset: 0x00F82608
		internal static bool phVG74pn3wfsSAAEEXDn()
		{
			return false;
		}

		// Token: 0x040077AC RID: 30636
		internal M105_NeedleCave $self_$37472;

		// Token: 0x02001347 RID: 4935
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600719B RID: 29083 RVA: 0x00F8440C File Offset: 0x00F8260C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M105_NeedleCave self_)
			{
				if (150397 - 226419 != -76022)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (286111 - 457791 == -171680)
					{
						base..ctor();
						if (48907 - 556327 != -507419)
						{
							this.$self_$37471 = self_;
							if (7331 - 564705 == -557374)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600719C RID: 29084 RVA: 0x00F844A4 File Offset: 0x00F826A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (19744 - 469572 != -449827)
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
						this.$self_$37471.LeaveGame();
						if (97954 - 291016 == -193061)
						{
							continue;
						}
						this.YieldDefault(1);
						if (178341 - 295434 != -117092)
						{
							goto Block_2;
						}
						continue;
					default:
						if (26226 - 486928 == -460701)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (238790 - 505989 == -267199)
					{
						Game.mStateTime = Time.time;
						if (133306 - 371169 != -237862)
						{
							this.$$switch$6326$37469 = PlayerData.SaveGuild;
							if (85335 - 116712 != -31376)
							{
								if (this.$$switch$6326$37469 == 1)
								{
									if (80061 - 309078 == -229016)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (118541 - 407528 != -288987)
									{
										continue;
									}
								}
								else if (this.$$switch$6326$37469 == 2)
								{
									if (257406 - 308183 != -50777)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (295878 - 67591 == 228288)
									{
										continue;
									}
								}
								else if (this.$$switch$6326$37469 == 3)
								{
									if (150458 - 376842 == -226383)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (115168 - 454834 == -339665)
									{
										continue;
									}
								}
								else if (this.$$switch$6326$37469 == 4)
								{
									if (161355 - 519707 == -358351)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (142824 - 275721 != -132897)
									{
										continue;
									}
								}
								else if (this.$$switch$6326$37469 == 5)
								{
									if (25758 - 244034 == -218275)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (100523 - 357989 == -257465)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (223057 - 505488 == -282430)
									{
										continue;
									}
								}
								this.$mGameGui$37470 = (GameGui)this.$self_$37471.GetComponent(typeof(GameGui));
								if (89835 - 182752 == -92917)
								{
									if (this.$mGameGui$37470)
									{
										if (276373 - 527188 != -250815)
										{
											continue;
										}
										this.$mGameGui$37470.close();
										if (56854 - 255617 == -198762)
										{
											continue;
										}
									}
									this.$self_$37471.SendMessage("fadeOut");
									if (262764 - 566762 == -303998)
									{
										goto IL_238;
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_363;
				IL_238:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_363:
				return false;
			}

			// Token: 0x0600719D RID: 29085 RVA: 0x00F84828 File Offset: 0x00F82A28
			internal static bool K56pmEpnX4HxPdNuaWRM()
			{
				return true;
			}

			// Token: 0x0600719E RID: 29086 RVA: 0x00F8482C File Offset: 0x00F82A2C
			internal static bool RtQI4WpnQup3v4RhTdPg()
			{
				return false;
			}

			// Token: 0x040077AD RID: 30637
			internal int $$switch$6326$37469;

			// Token: 0x040077AE RID: 30638
			internal GameGui $mGameGui$37470;

			// Token: 0x040077AF RID: 30639
			internal M105_NeedleCave $self_$37471;
		}
	}
}
