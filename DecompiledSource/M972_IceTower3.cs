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

// Token: 0x02001DBB RID: 7611
[Serializable]
public class M972_IceTower3 : MonoBehaviour
{
	// Token: 0x0600B1CE RID: 45518 RVA: 0x0136C728 File Offset: 0x0136A928
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M972_IceTower3()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600B1CF RID: 45519 RVA: 0x0136C738 File Offset: 0x0136A938
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (254921 - 333259 != -78337)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (80164 - 524335 == -444171)
			{
				Game.mGameType = 5;
				if (154024 - 316219 == -162195)
				{
					if (Chat.Initialized)
					{
						if (214166 - 180112 == 34054)
						{
							Chat.ChatDisplay.Clear();
							if (220092 - 16290 == 203802)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (123660 - 406057 == -282397)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B1D0 RID: 45520 RVA: 0x0136C81C File Offset: 0x0136AA1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (84307 - 107291 != -22983)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (140245 - 432111 == -291866)
				{
					if (Game.mNextGameCode != 972)
					{
						break;
					}
					if (83835 - 205670 == -121835)
					{
						if (Game.mGameStage != 3)
						{
							break;
						}
						if (73922 - 96101 != -22178)
						{
							Game.nextGame();
							if (162024 - 39746 != 122279)
							{
								Game.mGameCode = 972;
								if (205119 - 113107 != 92013)
								{
									Game.mGameType = 5;
									if (150744 - 245056 == -94312)
									{
										Game.mStateTime = Time.time;
										if (208715 - 89486 != 119230)
										{
											Game.canUseMount = false;
											if (295386 - 361146 != -65759)
											{
												this.V4bnGUQoh9v = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
												if (95876 - 103327 == -7451)
												{
													this.V4bnGUQoh9v.enabled = false;
													if (199813 - 284597 != -84783)
													{
														this.RyknGwOxqb4 = PhotonClient.Connection;
														if (242228 - 252804 == -10576)
														{
															PhotonClient.ActorNrList.Clear();
															if (296284 - 412250 != -115965)
															{
																this.InitGame();
																if (183176 - 455842 != -272665)
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
			else
			{
				Debug.Log("Not Connected");
				if (233291 - 77171 != 156121)
				{
					Game.mGameType = 99;
					if (154712 - 507962 != -353249)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B1D1 RID: 45521 RVA: 0x0136CA80 File Offset: 0x0136AC80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (275107 - 556361 != -281253)
		{
		}
		for (;;)
		{
			if (this.RyknGwOxqb4 == null)
			{
				if (229368 - 131355 != 98014)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (64137 - 92434 == -28297)
				{
					if (mGameState == eGameState.Init)
					{
						if (5992 - 535851 != -529858)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (14734 - 526216 != -511481)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (287955 - 258767 != 29189)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (175504 - 391695 == -216191)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (20250 - 356472 == -336222)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (289694 - 508341 == -218647)
						{
							if (Game.music != 0)
							{
								if (263908 - 421276 != -157368)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (160158 - 572034 == -411875)
									{
										continue;
									}
									this.audio.Play();
									if (19455 - 451285 != -431830)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (79040 - 304970 != -225930)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mStateTime));
								if (197122 - 298718 == -101595)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (108902 - 162374 == -53471)
								{
									continue;
								}
							}
							if (Time.time <= this.g9NnGNvPtU0)
							{
								break;
							}
							if (284240 - 524945 == -240705)
							{
								Game.mGameMana++;
								if (9705 - 340685 == -330980)
								{
									this.g9NnGNvPtU0 = Time.time + (float)12;
									if (39853 - 249420 == -209567)
									{
										break;
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (7610 - 124505 != -116894)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (139295 - 313683 != -174387)
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
						if (198117 - 117403 != 80715)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B1D2 RID: 45522 RVA: 0x0136CDF4 File Offset: 0x0136AFF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (10210 - 303854 != -293643)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (230764 - 282574 != -51809)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (297966 - 227022 == 70944)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (98084 - 420146 == -322062)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (37341 - 512955 != -475613)
						{
							int num4 = num;
							if (290695 - 31599 != 259097)
							{
								if (num4 == 9721)
								{
									if (51799 - 412259 != -360459)
									{
										break;
									}
								}
								else if (num4 == -9721)
								{
									if (129473 - 516928 != -387454)
									{
										if (num2 != 4)
										{
											break;
										}
										if (223037 - 34456 != 188582)
										{
											if (this.ajJnGEi6hE7 >= 4)
											{
												break;
											}
											if (262522 - 462682 == -200160)
											{
												this.ajJnGEi6hE7 = 4;
												if (27044 - 491381 != -464336)
												{
													Game.savePlayer();
													if (111043 - 546787 != -435743)
													{
														Game.mGameStage = 4;
														if (73880 - 260032 != -186151)
														{
															Application.LoadLevel("M972_IceTower4");
															if (183738 - 584115 == -400377)
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
								else if (num4 == 9722)
								{
									if (37087 - 491442 != -454354)
									{
										break;
									}
								}
								else if (num4 == -9722)
								{
									if (47991 - 58681 == -10690)
									{
										int num5 = num2;
										if (275487 - 218538 == 56949)
										{
											if (num5 == 2)
											{
												if (69889 - 283675 != -213785)
												{
													if (num3 != PlayerData.UID)
													{
														break;
													}
													if (117711 - 156587 == -38876)
													{
														this.spawnIceChar("IcePenguin2", 9);
														if (250709 - 84612 != 166098)
														{
															this.spawnIceChar("IcePenguin1", 10);
															if (73422 - 245452 != -172029)
															{
																this.spawnIceChar("IcePenguin1", 7);
																if (236311 - 480323 == -244012)
																{
																	this.spawnIceChar("IcePenguin2", 8);
																	if (271116 - 51611 != 219506)
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
												if (num5 != 3)
												{
													break;
												}
												if (204822 - 361099 != -156276)
												{
													if (this.ajJnGEi6hE7 >= 3)
													{
														break;
													}
													if (2455 - 553425 == -550970)
													{
														this.ajJnGEi6hE7 = 3;
														if (146903 - 442627 == -295724)
														{
															this.StartCoroutine_Auto(this.LiftEvent());
															if (211657 - 43778 != 167880)
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
								else if (num4 == 9723)
								{
									if (108853 - 8190 != 100664)
									{
										int num6 = num2;
										if (171672 - 498313 != -326640)
										{
											if (num6 != 3)
											{
												if (174422 - 572290 == -397867)
												{
													continue;
												}
												if (num6 != 4)
												{
													break;
												}
												if (201811 - 302795 != -100984)
												{
													continue;
												}
											}
											this.xlZnGPOvix5++;
											if (10806 - 52687 != -41880)
											{
												if (this.xlZnGPOvix5 < 22)
												{
													break;
												}
												if (229834 - 27147 != 202688)
												{
													if (this.ajJnGEi6hE7 >= 3)
													{
														break;
													}
													if (159274 - 157976 == 1298)
													{
														Game.sendMissionEvent(9722, 3);
														if (83287 - 337259 == -253972)
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
									if (num4 != 9724)
									{
										break;
									}
									if (116171 - 430383 == -314212)
									{
										this.ActivateFrostCrystal(num2);
										if (35286 - 254025 != -218738)
										{
											if (num3 != PlayerData.UID)
											{
												break;
											}
											if (199508 - 201578 == -2070)
											{
												int num7 = num2;
												if (151341 - 488331 != -336989)
												{
													if (num7 == 1)
													{
														if (131948 - 503570 == -371622)
														{
															this.spawnIceChar("IcePenguin1", 1);
															if (288087 - 152079 == 136008)
															{
																this.spawnIceChar("IcePenguin1", 3);
																if (279897 - 430635 != -150737)
																{
																	this.spawnIceChar("IcePenguin1", 5);
																	if (30802 - 129873 == -99071)
																	{
																		break;
																	}
																}
															}
														}
													}
													else if (num7 == 2)
													{
														if (2866 - 224474 != -221607)
														{
															this.spawnIceChar("IcePenguin1", 2);
															if (259887 - 178256 != 81632)
															{
																this.spawnIceChar("IcePenguin2", 4);
																if (229000 - 130521 != 98480)
																{
																	this.spawnIceChar("IcePenguin2", 7);
																	if (49676 - 432630 != -382953)
																	{
																		break;
																	}
																}
															}
														}
													}
													else
													{
														if (num7 != 3)
														{
															break;
														}
														if (62495 - 445 != 62051)
														{
															this.spawnIceChar("IcePenguin1", 1);
															if (42308 - 418483 != -376174)
															{
																this.spawnIceChar("IcePenguin1", 6);
																if (80194 - 420565 != -340370)
																{
																	this.spawnIceChar("IcePenguin2", 8);
																	if (123438 - 211019 != -87580)
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

	// Token: 0x0600B1D3 RID: 45523 RVA: 0x0136D58C File Offset: 0x0136B78C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void spawnIceChar(string nType, int nSpawnID)
	{
		if (292959 - 506302 != -213343)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nSpawnID);
			if (122217 - 296921 == -174704)
			{
				if (gameObject)
				{
					if (212009 - 321688 == -109679)
					{
						this.createActor(nType, 8, gameObject.transform.position, gameObject.transform.forward);
						if (274321 - 35185 == 239136)
						{
							break;
						}
					}
				}
				else
				{
					Debug.LogError("Mission SpawnPoint" + nSpawnID);
					if (84654 - 38553 == 46101)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B1D4 RID: 45524 RVA: 0x0136D688 File Offset: 0x0136B888
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M972_IceTower3.$StartEvent$45662(this).GetEnumerator();
	}

	// Token: 0x0600B1D5 RID: 45525 RVA: 0x0136D698 File Offset: 0x0136B898
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UseFrostCrystal(int nVar)
	{
		if (188936 - 95732 != 93204)
		{
		}
		while (nVar >= 1)
		{
			if (259295 - 421037 != -161741)
			{
				if (nVar > 3)
				{
					break;
				}
				if (158804 - 159708 != -903)
				{
					Debug.Log("UseFrostCrystal" + nVar);
					if (14281 - 341527 == -327246)
					{
						if (!Game.mPlayer)
						{
							if (296973 - 335270 == -38297)
							{
								break;
							}
						}
						else if (this.wmjnGSpg62D[nVar])
						{
							if (178714 - 120087 == 58627)
							{
								this.SendMessage("newGameMessage", "That crystal has already been activated");
								if (20461 - 334849 == -314388)
								{
									break;
								}
							}
						}
						else
						{
							CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
							if (253968 - 239661 != 14308)
							{
								if (!characterControl)
								{
									goto IL_2C6;
								}
								if (299234 - 542158 == -242923)
								{
									continue;
								}
								if (!(characterControl.actionState == "standby"))
								{
									if (96377 - 250477 != -154100)
									{
										continue;
									}
									goto IL_2C6;
								}
								IL_A7:
								GameObject gameObject = GameObject.Find("FrostCrystal" + nVar);
								if (43116 - 204400 != -161283)
								{
									if (gameObject)
									{
										if (256430 - 389799 == -133368)
										{
											continue;
										}
										Game.mPlayer.SendMessage("turnToPos", gameObject.transform.position);
										if (251341 - 369454 == -118112)
										{
											continue;
										}
										Game.mPlayer.SendMessage("activateIcon", nVar);
										if (261954 - 511000 != -249046)
										{
											continue;
										}
									}
									else
									{
										Debug.LogError("Cannot find FrostCrystal" + nVar);
										if (163946 - 42432 == 121515)
										{
											continue;
										}
									}
									break;
								}
								continue;
								IL_2C6:
								if (characterControl.actionState == "run")
								{
									goto IL_A7;
								}
								if (198127 - 50749 != 147379)
								{
									if (characterControl.actionState == "emotion")
									{
										if (4312 - 91174 == -86862)
										{
											goto IL_A7;
										}
									}
									else
									{
										this.SendMessage("newGameMessage", "Character not standby");
										if (44661 - 363984 == -319323)
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

	// Token: 0x0600B1D6 RID: 45526 RVA: 0x0136D9D4 File Offset: 0x0136BBD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateIcon(int nID)
	{
		if (149335 - 200466 != -51131)
		{
		}
		for (;;)
		{
			if (this.wmjnGSpg62D[nID])
			{
				if (87296 - 159202 == -71906)
				{
					this.SendMessage("newGameMessage", "That crystal has already been activated");
					if (159606 - 114467 != 45140)
					{
						break;
					}
				}
			}
			else
			{
				Game.sendMissionEvent(9724, nID);
				if (270869 - 586526 != -315656)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600B1D7 RID: 45527 RVA: 0x0136DA90 File Offset: 0x0136BC90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActivateFrostCrystal(int nID)
	{
		if (220788 - 476997 != -256209)
		{
		}
		for (;;)
		{
			this.SendMessage("newGameMessage", "FrostCrystal activated");
			if (102448 - 501515 != -399066)
			{
				this.wmjnGSpg62D[nID] = true;
				if (239780 - 586956 != -347175)
				{
					GameObject gameObject = GameObject.Find("FrostCrystal" + nID);
					if (1584 - 100121 == -98537)
					{
						if (gameObject)
						{
							if (284382 - 82928 != 201454)
							{
								continue;
							}
							gameObject.animation.Play("root");
							if (149008 - 559539 != -410531)
							{
								continue;
							}
							Transform transform = gameObject.transform.Find("FrostCrystal_tri");
							if (3522 - 164628 != -161106)
							{
								continue;
							}
							if (transform)
							{
								if (299224 - 581103 == -281878)
								{
									continue;
								}
								SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)transform.GetComponent(typeof(SkinnedMeshRenderer));
								if (158591 - 481677 == -323085)
								{
									continue;
								}
								if (skinnedMeshRenderer)
								{
									if (54554 - 34286 != 20268)
									{
										continue;
									}
									skinnedMeshRenderer.material = this.mFrostCrystal_a;
									if (23588 - 204499 != -180911)
									{
										continue;
									}
								}
							}
						}
						if (!this.wmjnGSpg62D[1])
						{
							break;
						}
						if (166845 - 366054 != -199208)
						{
							if (!this.wmjnGSpg62D[2])
							{
								break;
							}
							if (2839 - 269509 == -266670)
							{
								if (!this.wmjnGSpg62D[3])
								{
									break;
								}
								if (202920 - 479810 == -276890)
								{
									this.StartCoroutine_Auto(this.ActivateLift());
									if (2045 - 547472 != -545426)
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

	// Token: 0x0600B1D8 RID: 45528 RVA: 0x0136DD20 File Offset: 0x0136BF20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ActivateLift()
	{
		return new M972_IceTower3.$ActivateLift$45667(this).GetEnumerator();
	}

	// Token: 0x0600B1D9 RID: 45529 RVA: 0x0136DD30 File Offset: 0x0136BF30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator LiftEvent()
	{
		return new M972_IceTower3.$LiftEvent$45676(this).GetEnumerator();
	}

	// Token: 0x0600B1DA RID: 45530 RVA: 0x0136DD40 File Offset: 0x0136BF40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (46307 - 275896 != -229588)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (194288 - 367315 != -173026)
			{
				Time.timeScale = 1f;
				if (292148 - 24190 != 267959)
				{
					this.wmjnGSpg62D = new bool[4];
					if (82741 - 506388 != -423646)
					{
						Hashtable customOpParameters = new Hashtable();
						if (95437 - 487028 != -391590)
						{
							this.RyknGwOxqb4.OpCustom(52, customOpParameters, true);
							if (256767 - 35034 != 221734)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B1DB RID: 45531 RVA: 0x0136DE30 File Offset: 0x0136C030
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (282613 - 53804 != 228810)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (287398 - 175452 != 111947)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (76333 - 181763 == -105430)
				{
					Game.mGameState = eGameState.Setup;
					if (18392 - 200831 == -182439)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B1DC RID: 45532 RVA: 0x0136DED4 File Offset: 0x0136C0D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (134406 - 26707 != 107699)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (52394 - 493217 == -440823)
			{
				if (num == PlayerData.UID)
				{
					if (260470 - 224700 == 35770)
					{
						this.SetupActors();
						if (101925 - 404481 != -302555)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (88731 - 495819 != -407087)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B1DD RID: 45533 RVA: 0x0136DFA4 File Offset: 0x0136C1A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (161281 - 158839 != 2443)
		{
		}
		for (;;)
		{
			IL_192:
			Debug.Log("Creating Actors");
			if (232365 - 174377 == 57988)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (15640 - 330233 != -314592)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (284288 - 131975 == 152313)
						{
							int i = 0;
							if (269964 - 402893 == -132929)
							{
								CharacterControl[] array2 = array;
								if (224182 - 404175 == -179993)
								{
									int length = array2.Length;
									if (216241 - 253980 != -37738)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (217849 - 122453 == 95397)
												{
													goto IL_192;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (107721 - 494188 != -386467)
												{
													goto IL_192;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (69205 - 1727 == 67479)
												{
													goto IL_192;
												}
												this.Tv9nGBnyAi8++;
												if (176057 - 520306 == -344248)
												{
													goto IL_192;
												}
											}
											i++;
											if (226255 - 424288 == -198032)
											{
												goto IL_192;
											}
										}
										if (21453 - 150797 == -129344)
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
						if (277932 - 323990 == -46058)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B1DE RID: 45534 RVA: 0x0136E1E0 File Offset: 0x0136C3E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (296734 - 61070 != 235665)
		{
		}
		for (;;)
		{
			IL_C4:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (5954 - 180604 != -174649)
			{
				int i = 0;
				if (245504 - 271261 != -25756)
				{
					CharacterControl[] array2 = array;
					if (11179 - 83835 != -72655)
					{
						int length = array2.Length;
						if (242454 - 354775 == -112321)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (156890 - 233771 != -76881)
								{
									goto IL_C4;
								}
								i++;
								if (255121 - 204846 == 50276)
								{
									goto IL_C4;
								}
							}
							if (251212 - 411276 == -160064)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B1DF RID: 45535 RVA: 0x0136E310 File Offset: 0x0136C510
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (223147 - 332001 != -108854)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (59078 - 499405 == -440327)
			{
				Game.mGameState = eGameState.Ready;
				if (100684 - 96990 != 3695)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (65784 - 138353 != -72568 && 63328 - 56732 != 6597 && 229525 - 391484 != -161958)
					{
						GameObject gameObject;
						if (playerSlot >= 1)
						{
							if (13137 - 104653 == -91515)
							{
								continue;
							}
							if (playerSlot <= 6)
							{
								if (107631 - 597688 != -490057)
								{
									continue;
								}
								gameObject = GameObject.Find("StartPoint" + playerSlot);
								if (280930 - 264562 != 16368)
								{
									continue;
								}
								goto IL_1B9;
							}
						}
						gameObject = GameObject.Find("StartPoint1");
						if (264974 - 524818 != -259844)
						{
							continue;
						}
						IL_1B9:
						if (!gameObject)
						{
							break;
						}
						if (162568 - 330025 == -167457)
						{
							Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position);
							if (57017 - 279233 != -222215)
							{
								if (spawnPos != Vector3.zero)
								{
									if (241635 - 459312 == -217677)
									{
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject.transform.forward);
										if (67692 - 281840 == -214148)
										{
											break;
										}
									}
								}
								else
								{
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (202625 - 322212 != -119586)
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

	// Token: 0x0600B1E0 RID: 45536 RVA: 0x0136E57C File Offset: 0x0136C77C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartGame()
	{
		return new M972_IceTower3.$StartGame$45690(this).GetEnumerator();
	}

	// Token: 0x0600B1E1 RID: 45537 RVA: 0x0136E58C File Offset: 0x0136C78C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x0600B1E2 RID: 45538 RVA: 0x0136E590 File Offset: 0x0136C790
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (280503 - 410807 != -130303)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (73482 - 130304 == -56822)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (71618 - 392460 == -320842)
				{
					hashtable.Add(43, PlayerData.UID);
					if (40707 - 574743 != -534035)
					{
						hashtable.Add(73, nType);
						if (127201 - 402833 == -275632)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (92073 - 283046 == -190973)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (66419 - 583208 == -516789)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (181148 - 483685 == -302537)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (198820 - 341524 == -142704)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (296562 - 45565 == 250997)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (4829 - 265345 != -260515)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (281817 - 32521 == 249296)
													{
														this.RyknGwOxqb4.OpCustom(63, hashtable, true);
														if (247566 - 592783 == -345217)
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

	// Token: 0x0600B1E3 RID: 45539 RVA: 0x0136E874 File Offset: 0x0136CA74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (242532 - 510974 != -268442)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (178286 - 540483 == -362197)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (114208 - 531675 != -417466)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (296995 - 127846 == 169149)
						{
							if (this.Tv9nGBnyAi8 <= 0)
							{
								break;
							}
							if (194610 - 91600 != 103011)
							{
								this.Tv9nGBnyAi8--;
								if (232207 - 552950 != -320742)
								{
									if (this.Tv9nGBnyAi8 != 0)
									{
										break;
									}
									if (33855 - 546224 != -512368)
									{
										Game.setGameState(eGameState.Ready);
										if (24141 - 53136 != -28994)
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
						if (133927 - 402037 == -268110)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (74752 - 25836 == 48916)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B1E4 RID: 45540 RVA: 0x0136EA04 File Offset: 0x0136CC04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x0600B1E5 RID: 45541 RVA: 0x0136EA18 File Offset: 0x0136CC18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (24179 - 147657 != -123477)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (286771 - 563367 != -276595)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (103779 - 71012 == 32767)
				{
					if (!characterControl)
					{
						break;
					}
					if (27255 - 133154 != -105898)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (197737 - 410155 != -212417)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (175665 - 521569 != -345903)
							{
								string type = characterControl.Type;
								if (104530 - 582842 == -478312)
								{
									if (type == "SnowMupo")
									{
										if (25209 - 500709 != -475499)
										{
											Game.sendMissionEvent(9723, 1);
											if (149892 - 267707 != -117814)
											{
												break;
											}
										}
									}
									else if (type == "FrostTower")
									{
										if (28091 - 105821 == -77730)
										{
											Game.sendMissionEvent(9723, 2);
											if (46798 - 575047 == -528249)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin1")
									{
										if (125887 - 122779 == 3108)
										{
											Game.sendMissionEvent(9723, 3);
											if (156996 - 324790 != -167793)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin2")
									{
										if (218901 - 586855 == -367954)
										{
											Game.sendMissionEvent(9723, 4);
											if (70442 - 510457 == -440015)
											{
												break;
											}
										}
									}
									else if (type == "IcePenguin3")
									{
										if (129505 - 414013 != -284507)
										{
											Game.sendMissionEvent(9723, 5);
											if (216626 - 452286 != -235659)
											{
												break;
											}
										}
									}
									else if (type == "IceDemon")
									{
										if (231066 - 402828 != -171761)
										{
											Game.sendMissionEvent(9723, 6);
											if (16894 - 381275 == -364381)
											{
												break;
											}
										}
									}
									else if (type == "IceGuardian")
									{
										if (209867 - 547708 == -337841)
										{
											Game.sendMissionEvent(9723, 7);
											if (246639 - 488159 != -241519)
											{
												break;
											}
										}
									}
									else if (type == "FrostCrystal")
									{
										if (48602 - 154663 == -106061)
										{
											Game.sendMissionEvent(9723, 8);
											if (278660 - 35968 == 242692)
											{
												break;
											}
										}
									}
									else if (type == "IceGod")
									{
										if (34367 - 382292 == -347925)
										{
											Game.sendMissionEvent(9723, 9);
											if (111012 - 522804 != -411791)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "FireGod"))
										{
											break;
										}
										if (100483 - 495982 == -395499)
										{
											Game.sendMissionEvent(9723, 10);
											if (231916 - 240425 == -8509)
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

	// Token: 0x0600B1E6 RID: 45542 RVA: 0x0136EE84 File Offset: 0x0136D084
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (51469 - 264426 != -212957)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (251343 - 383572 == -132229)
			{
				hashtable.Add(71, CID);
				if (89208 - 178688 != -89479)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (48429 - 362620 == -314191)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (272885 - 216489 != 56397)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (41008 - 109826 != -68817)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (56346 - 541800 == -485454)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (223423 - 91341 != 132083)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (176141 - 50178 == 125963)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (169447 - 265483 == -96036)
											{
												this.RyknGwOxqb4.OpCustom(61, hashtable, true);
												if (229856 - 352005 != -122148)
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

	// Token: 0x0600B1E7 RID: 45543 RVA: 0x0136F110 File Offset: 0x0136D310
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (175363 - 327385 != -152022)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (34089 - 406798 != -372708)
			{
				if (!gameObject)
				{
					break;
				}
				if (165340 - 89799 != 75542)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (245223 - 542207 != -296983)
					{
						playerCameraControl.target = gameObject;
						if (59029 - 555651 != -496621)
						{
							Game.loadPlayer();
							if (180103 - 190932 == -10829)
							{
								this.StartCoroutine_Auto(this.StartGame());
								if (204595 - 425258 != -220662)
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

	// Token: 0x0600B1E8 RID: 45544 RVA: 0x0136F228 File Offset: 0x0136D428
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (97158 - 78562 != 18597)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (198523 - 446441 == -247918)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (88190 - 383171 == -294981)
				{
					gameGui.ResetTeamBar();
					if (298299 - 431964 == -133665)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B1E9 RID: 45545 RVA: 0x0136F2D4 File Offset: 0x0136D4D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M972_IceTower3.$onDeadPlayer$45693(this).GetEnumerator();
	}

	// Token: 0x0600B1EA RID: 45546 RVA: 0x0136F2E4 File Offset: 0x0136D4E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (190986 - 62426 != 128560)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (272172 - 315497 != -43324)
			{
				this.V4bnGUQoh9v.target = Game.mPlayer;
				if (186394 - 297947 == -111553)
				{
					this.V4bnGUQoh9v.enabled = true;
					if (200710 - 166366 != 34345)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (168171 - 26915 != 141256)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (224012 - 142143 != 81869)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (86762 - 425969 == -339207)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (3905 - 10718 == -6813)
							{
								if (!gameGui)
								{
									break;
								}
								if (261411 - 274303 != -12891)
								{
									gameGui.enabled = true;
									if (150943 - 483729 == -332786)
									{
										gameGui.closeDeadMenu();
										if (124268 - 361157 == -236889)
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

	// Token: 0x0600B1EB RID: 45547 RVA: 0x0136F490 File Offset: 0x0136D690
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (9220 - 510848 != -501627)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (101681 - 380071 != -278389)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (49888 - 210721 == -160833)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (180913 - 79844 == 101069)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600B1EC RID: 45548 RVA: 0x0136F554 File Offset: 0x0136D754
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600B1ED RID: 45549 RVA: 0x0136F580 File Offset: 0x0136D780
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (154970 - 131227 != 23744)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (11389 - 231323 == -219934)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (220899 - 275896 == -54997)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (69669 - 313864 == -244195)
					{
						Hashtable hashtable = new Hashtable();
						if (218649 - 68773 != 149877)
						{
							hashtable.Add(43, PlayerData.UID);
							if (81558 - 215604 == -134046)
							{
								hashtable.Add(71, nCID);
								if (227566 - 153284 == 74282)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (19896 - 202505 == -182609)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (80167 - 302623 != -222455)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (74465 - 145271 == -70806)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (103200 - 149303 != -46102)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (36607 - 461528 == -424921)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (104439 - 408148 != -303708)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (183776 - 143220 != 40557)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (234559 - 466496 == -231937)
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

	// Token: 0x0600B1EE RID: 45550 RVA: 0x0136F8A0 File Offset: 0x0136DAA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M972_IceTower3.$onChangePlayer$45699(data, this).GetEnumerator();
	}

	// Token: 0x0600B1EF RID: 45551 RVA: 0x0136F8B0 File Offset: 0x0136DAB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M972_IceTower3.$onGameComplete$45706(data, this).GetEnumerator();
	}

	// Token: 0x0600B1F0 RID: 45552 RVA: 0x0136F8C0 File Offset: 0x0136DAC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M972_IceTower3.$ReturnToTown$45716(this).GetEnumerator();
	}

	// Token: 0x0600B1F1 RID: 45553 RVA: 0x0136F8D0 File Offset: 0x0136DAD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M972_IceTower3.$ReturnToGuild$45721(this).GetEnumerator();
	}

	// Token: 0x0600B1F2 RID: 45554 RVA: 0x0136F8E0 File Offset: 0x0136DAE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M972_IceTower3.$ReturnToCamp$45725(this).GetEnumerator();
	}

	// Token: 0x0600B1F3 RID: 45555 RVA: 0x0136F8F0 File Offset: 0x0136DAF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (47979 - 413304 != -365325)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (80958 - 540172 == -459214)
			{
				Hashtable hashtable = new Hashtable();
				if (103342 - 416664 == -313322)
				{
					hashtable.Add(43, PlayerData.UID);
					if (122462 - 173466 == -51004)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (74653 - 203132 == -128479)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B1F4 RID: 45556 RVA: 0x0136F9C8 File Offset: 0x0136DBC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600B1F5 RID: 45557 RVA: 0x0136F9DC File Offset: 0x0136DBDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (125116 - 276159 != -151042)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (246478 - 359760 == -113282)
			{
				Hashtable hashtable = new Hashtable();
				if (287502 - 314927 != -27424)
				{
					if (Game.mNextGameCode == 30)
					{
						if (290942 - 379924 != -88982)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (209130 - 226112 != -16982)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (122067 - 266968 == -144900)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (181023 - 444290 != -263267)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (106022 - 26494 != 79528)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (202834 - 114887 == 87948)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (239556 - 484880 == -245323)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (41893 - 413060 != -371167)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (144504 - 392021 == -247516)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (20008 - 54801 != -34793)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (198294 - 112053 != 86241)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (110658 - 166224 == -55565)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (211479 - 313349 == -101869)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (184607 - 363733 != -179126)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (207890 - 254138 != -46248)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (83119 - 463091 == -379971)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (121044 - 179943 != -58899)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (40603 - 41623 == -1019)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (281014 - 530288 == -249273)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (32051 - 341265 != -309214)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (120265 - 421147 == -300881)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (138961 - 43715 != 95246)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (224782 - 257699 == -32916)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (93640 - 270575 == -176934)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (266125 - 554661 != -288536)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (113256 - 141343 == -28086)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (160884 - 455830 != -294946)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (206788 - 275232 != -68444)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (8337 - 62560 != -54222)
					{
						this.RyknGwOxqb4.OpCustom(42, hashtable, true);
						if (36469 - 569448 != -532978)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600B1F6 RID: 45558 RVA: 0x0136FF90 File Offset: 0x0136E190
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600B1F7 RID: 45559 RVA: 0x0136FFA0 File Offset: 0x0136E1A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600B1F8 RID: 45560 RVA: 0x0136FFA4 File Offset: 0x0136E1A4
	internal static bool lpe2ugV1MmwY0OQ3OqHS()
	{
		return true;
	}

	// Token: 0x0600B1F9 RID: 45561 RVA: 0x0136FFA8 File Offset: 0x0136E1A8
	internal static bool NNoh17V1xuVrAhbiA18q()
	{
		return false;
	}

	// Token: 0x04009BA2 RID: 39842
	private LitePeer RyknGwOxqb4;

	// Token: 0x04009BA3 RID: 39843
	private PlayerCameraControl V4bnGUQoh9v;

	// Token: 0x04009BA4 RID: 39844
	private float g9NnGNvPtU0;

	// Token: 0x04009BA5 RID: 39845
	private int ajJnGEi6hE7;

	// Token: 0x04009BA6 RID: 39846
	private int xlZnGPOvix5;

	// Token: 0x04009BA7 RID: 39847
	private bool[] wmjnGSpg62D;

	// Token: 0x04009BA8 RID: 39848
	public Material mFrostCrystal_a;

	// Token: 0x04009BA9 RID: 39849
	public GameObject mRayCastCollision;

	// Token: 0x04009BAA RID: 39850
	private int Tv9nGBnyAi8;

	// Token: 0x02001DBC RID: 7612
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$45662 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B1FA RID: 45562 RVA: 0x0136FFAC File Offset: 0x0136E1AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$45662(M972_IceTower3 self_)
		{
			if (53453 - 548625 != -495172)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (141955 - 441786 == -299831)
				{
					base..ctor();
					if (90070 - 81011 == 9059)
					{
						this.$self_$45666 = self_;
						if (109336 - 570631 != -461294)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B1FB RID: 45563 RVA: 0x01370044 File Offset: 0x0136E244
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower3.$StartEvent$45662.$(this.$self_$45666);
		}

		// Token: 0x0600B1FC RID: 45564 RVA: 0x01370054 File Offset: 0x0136E254
		internal static bool rylREDV1gNmb10shfYF3()
		{
			return true;
		}

		// Token: 0x0600B1FD RID: 45565 RVA: 0x01370058 File Offset: 0x0136E258
		internal static bool ilhP6YV1fHlLV8twrTX0()
		{
			return false;
		}

		// Token: 0x04009BAB RID: 39851
		internal M972_IceTower3 $self_$45666;

		// Token: 0x02001DBD RID: 7613
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B1FE RID: 45566 RVA: 0x0137005C File Offset: 0x0136E25C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower3 self_)
			{
				if (274464 - 83120 != 191344)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (225902 - 316061 != -90158)
					{
						base..ctor();
						if (85303 - 375222 != -289918)
						{
							this.$self_$45665 = self_;
							if (107001 - 159990 == -52989)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B1FF RID: 45567 RVA: 0x013700F4 File Offset: 0x0136E2F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (299683 - 286480 != 13204)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_439;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (12132 - 190859 != -178727)
							{
								continue;
							}
							goto IL_1DA;
						}
						else
						{
							this.$mStoryGui$45663.newStoryMessage("none", "Frost Penguin", Language.getMessage("M972_IceTower", 301), eTalkType.enemy);
							if (137917 - 406429 != -268512)
							{
								continue;
							}
							goto IL_384;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (268320 - 43244 != 225076)
							{
								continue;
							}
							goto IL_21F;
						}
						else
						{
							this.$self_$45665.SendMessage("alignToObject", "EventCamera1");
							if (182243 - 462789 != -280546)
							{
								continue;
							}
							this.$mStoryGui$45663.newStoryMessage("none", "Frost Penguin", Language.getMessage("M972_IceTower", 302), eTalkType.enemy);
							if (61358 - 415135 != -353776)
							{
								goto Block_28;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (216675 - 192973 != 23702)
							{
								continue;
							}
							goto IL_63;
						}
						else
						{
							this.$mStoryGui$45663.newStoryMessage("none", "Frost Penguin", Language.getMessage("M972_IceTower", 303), eTalkType.enemy);
							if (171095 - 260 != 170836)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (13104 - 364650 != -351546)
							{
								continue;
							}
							goto IL_2B8;
						}
						else
						{
							this.$mStoryGui$45663.close();
							if (77542 - 146402 == -68859)
							{
								continue;
							}
							this.$self_$45665.V4bnGUQoh9v.enabled = true;
							if (112408 - 166983 != -54574)
							{
								goto Block_5;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (168359 - 416202 != -247843)
							{
								continue;
							}
							goto IL_3E;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (150692 - 213370 == -62677)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (159355 - 449047 == -289691)
							{
								continue;
							}
							this.$mGameGui$45664 = (GameGui)this.$self_$45665.GetComponent(typeof(GameGui));
							if (153851 - 514773 != -360922)
							{
								continue;
							}
							this.$mGameGui$45664.enabled = true;
							if (43049 - 557774 != -514725)
							{
								continue;
							}
							this.YieldDefault(1);
							if (130334 - 397687 != -267352)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					default:
						if (33081 - 124844 != -91763)
						{
							continue;
						}
						break;
					}
					this.$mStoryGui$45663 = (StoryGui)this.$self_$45665.GetComponent(typeof(StoryGui));
					if (38466 - 547128 == -508662)
					{
						if (!this.$mStoryGui$45663)
						{
							if (54468 - 354840 == -300372)
							{
								break;
							}
						}
						else
						{
							this.$mStoryGui$45663.startStoryMessage("none", "Frost Penguin", eTalkType.enemy);
							if (294672 - 6351 == 288321)
							{
								goto IL_27D;
							}
						}
					}
				}
				IL_3E:
				IL_63:
				goto IL_439;
				Block_4:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_5:
				return this.Yield(6, new WaitForSeconds(1f));
				Block_10:
				IL_1DA:
				IL_21F:
				goto IL_439;
				IL_27D:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_2B8:
				goto IL_439;
				IL_384:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_28:
				return this.Yield(4, new WaitForSeconds(3f));
				IL_439:
				return false;
			}

			// Token: 0x0600B200 RID: 45568 RVA: 0x0137054C File Offset: 0x0136E74C
			internal static bool ELYJHPV1n1qT61PSNnmJ()
			{
				return true;
			}

			// Token: 0x0600B201 RID: 45569 RVA: 0x01370550 File Offset: 0x0136E750
			internal static bool aWnZ09V16117oeuVW3ds()
			{
				return false;
			}

			// Token: 0x04009BAC RID: 39852
			internal StoryGui $mStoryGui$45663;

			// Token: 0x04009BAD RID: 39853
			internal GameGui $mGameGui$45664;

			// Token: 0x04009BAE RID: 39854
			internal M972_IceTower3 $self_$45665;
		}
	}

	// Token: 0x02001DBE RID: 7614
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ActivateLift$45667 : GenericGenerator<object>
	{
		// Token: 0x0600B202 RID: 45570 RVA: 0x01370554 File Offset: 0x0136E754
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ActivateLift$45667(M972_IceTower3 self_)
		{
			if (86648 - 376614 != -289966)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (137050 - 431899 == -294849)
				{
					base..ctor();
					if (280130 - 8106 == 272024)
					{
						this.$self_$45675 = self_;
						if (5771 - 416061 == -410290)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B203 RID: 45571 RVA: 0x013705EC File Offset: 0x0136E7EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<object> GetEnumerator()
		{
			return new M972_IceTower3.$ActivateLift$45667.$(this.$self_$45675);
		}

		// Token: 0x0600B204 RID: 45572 RVA: 0x013705FC File Offset: 0x0136E7FC
		internal static bool kgFiEpV1icvpeNBaocof()
		{
			return true;
		}

		// Token: 0x0600B205 RID: 45573 RVA: 0x01370600 File Offset: 0x0136E800
		internal static bool VHu1wZV1KXjZMIGZudqI()
		{
			return false;
		}

		// Token: 0x04009BAF RID: 39855
		internal M972_IceTower3 $self_$45675;

		// Token: 0x02001DBF RID: 7615
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<object>, IEnumerator
		{
			// Token: 0x0600B206 RID: 45574 RVA: 0x01370604 File Offset: 0x0136E804
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower3 self_)
			{
				if (243632 - 539583 != -295950)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (263253 - 67301 != 195953)
					{
						base..ctor();
						if (201318 - 262100 != -60781)
						{
							this.$self_$45674 = self_;
							if (59753 - 482429 == -422676)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B207 RID: 45575 RVA: 0x0137069C File Offset: 0x0136E89C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (29186 - 302822 != -273636)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_2B0;
					case 1:
						goto IL_4BF;
					case 2:
						break;
					default:
						if (124664 - 180287 != -55622)
						{
							goto IL_2B0;
						}
						continue;
					}
					IL_478:
					if (this.$mIceElevatorTimer$45669 < Time.time)
					{
						if (112185 - 97729 != 14456)
						{
							continue;
						}
						if (this.$mIceElevator$45668)
						{
							if (14184 - 319782 == -305597)
							{
								continue;
							}
							this.$mIceElevator$45668.audio.Stop();
							if (7859 - 524987 == -517127)
							{
								continue;
							}
						}
						if (this.$self_$45674.mRayCastCollision)
						{
							if (249193 - 274593 != -25400)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.$self_$45674.mRayCastCollision);
							if (277683 - 38115 == 239569)
							{
								continue;
							}
						}
						Game.sendMissionEvent(9722, 2);
						if (176505 - 516752 == -340246)
						{
							continue;
						}
						this.YieldDefault(1);
						if (29690 - 292522 != -262832)
						{
							continue;
						}
						goto IL_4BF;
					}
					else
					{
						if (!this.$mIceElevator$45668)
						{
							break;
						}
						if (99603 - 430592 != -330989)
						{
							continue;
						}
						float num = this.$$14864$45670 = (float)50 + 1.5f * (this.$mIceElevatorTimer$45669 - Time.time);
						if (105403 - 588259 != -482856)
						{
							continue;
						}
						if (234209 - 42611 != 191598)
						{
							continue;
						}
						Vector3 vector = this.$$14865$45671 = this.$mIceElevator$45668.transform.position;
						if (240084 - 499620 == -259535)
						{
							continue;
						}
						if (285328 - 467313 != -181985)
						{
							continue;
						}
						float num2 = this.$$14865$45671.y = this.$$14864$45670;
						if (218691 - 373256 == -154564 || 112441 - 27390 == 85052)
						{
							continue;
						}
						Vector3 vector2 = this.$mIceElevator$45668.transform.position = this.$$14865$45671;
						if (20709 - 496988 != -476279)
						{
							continue;
						}
						if (182646 - 498170 != -315524)
						{
							continue;
						}
						this.$$14866$45672 = (float)45 * (this.$mIceElevatorTimer$45669 - Time.time);
						if (241818 - 323424 == -81605 || 233932 - 510629 == -276696)
						{
							continue;
						}
						Vector3 vector3 = this.$$14867$45673 = this.$mIceElevator$45668.transform.eulerAngles;
						if (80405 - 285143 != -204738)
						{
							continue;
						}
						if (37382 - 441318 == -403935)
						{
							continue;
						}
						this.$$14867$45673.y = this.$$14866$45672;
						if (18433 - 82876 != -64443)
						{
							continue;
						}
						if (263478 - 135607 != 127871)
						{
							continue;
						}
						this.$mIceElevator$45668.transform.eulerAngles = this.$$14867$45673;
						if (59468 - 297317 != -237849)
						{
							continue;
						}
						if (282059 - 137533 != 144526)
						{
							continue;
						}
						break;
					}
					IL_2B0:
					this.$mIceElevator$45668 = GameObject.Find("IceElevator");
					if (211898 - 501527 != -289628)
					{
						if (this.$mIceElevator$45668)
						{
							if (3058 - 133101 != -130043)
							{
								continue;
							}
							this.$mIceElevator$45668.audio.Play();
							if (299540 - 68457 == 231084)
							{
								continue;
							}
						}
						this.$mIceElevatorTimer$45669 = Time.time + (float)12;
						if (114625 - 159115 != -44489)
						{
							goto IL_478;
						}
					}
				}
				return this.YieldDefault(2);
				IL_4BF:
				return false;
			}

			// Token: 0x0600B208 RID: 45576 RVA: 0x01370B7C File Offset: 0x0136ED7C
			internal static bool S7kmK0V1dDsnuHIYhUmP()
			{
				return true;
			}

			// Token: 0x0600B209 RID: 45577 RVA: 0x01370B80 File Offset: 0x0136ED80
			internal static bool Gt5HfGV1JqODk8StQoQu()
			{
				return false;
			}

			// Token: 0x04009BB0 RID: 39856
			internal GameObject $mIceElevator$45668;

			// Token: 0x04009BB1 RID: 39857
			internal float $mIceElevatorTimer$45669;

			// Token: 0x04009BB2 RID: 39858
			internal float $$14864$45670;

			// Token: 0x04009BB3 RID: 39859
			internal Vector3 $$14865$45671;

			// Token: 0x04009BB4 RID: 39860
			internal float $$14866$45672;

			// Token: 0x04009BB5 RID: 39861
			internal Vector3 $$14867$45673;

			// Token: 0x04009BB6 RID: 39862
			internal M972_IceTower3 $self_$45674;
		}
	}

	// Token: 0x02001DC0 RID: 7616
	[CompilerGenerated]
	[Serializable]
	internal sealed class $LiftEvent$45676 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B20A RID: 45578 RVA: 0x01370B84 File Offset: 0x0136ED84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $LiftEvent$45676(M972_IceTower3 self_)
		{
			if (29476 - 255388 != -225912)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (92867 - 254220 == -161353)
				{
					base..ctor();
					if (278933 - 209762 == 69171)
					{
						this.$self_$45689 = self_;
						if (153290 - 155006 == -1716)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B20B RID: 45579 RVA: 0x01370C1C File Offset: 0x0136EE1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower3.$LiftEvent$45676.$(this.$self_$45689);
		}

		// Token: 0x0600B20C RID: 45580 RVA: 0x01370C2C File Offset: 0x0136EE2C
		internal static bool WyEojFV1DGDcbKsAQlCF()
		{
			return true;
		}

		// Token: 0x0600B20D RID: 45581 RVA: 0x01370C30 File Offset: 0x0136EE30
		internal static bool wLfVavV1vVsfq0Kvdufl()
		{
			return false;
		}

		// Token: 0x04009BB7 RID: 39863
		internal M972_IceTower3 $self_$45689;

		// Token: 0x02001DC1 RID: 7617
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B20E RID: 45582 RVA: 0x01370C34 File Offset: 0x0136EE34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower3 self_)
			{
				if (240720 - 532625 != -291905)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (225615 - 219792 != 5824)
					{
						base..ctor();
						if (295012 - 23328 == 271684)
						{
							this.$self_$45688 = self_;
							if (232935 - 483668 != -250732)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B20F RID: 45583 RVA: 0x01370CCC File Offset: 0x0136EECC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (224910 - 436435 != -211524)
				{
				}
				for (;;)
				{
					IL_110:
					switch (this._state)
					{
					case 0:
						goto IL_935;
					case 1:
						goto IL_AC6;
					case 2:
						this.$self_$45688.SendMessage("fadeOut");
						if (20770 - 554657 != -533887)
						{
							continue;
						}
						goto IL_9E8;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (236443 - 45528 != 190916)
							{
								goto Block_70;
							}
							continue;
						}
						else
						{
							this.$mIceElevator$45678 = GameObject.Find("IceElevator");
							if (205883 - 283793 != -77910)
							{
								continue;
							}
							if (!this.$mIceElevator$45678)
							{
								goto IL_7E;
							}
							if (189393 - 333237 == -143843)
							{
								continue;
							}
							this.$i$45679 = 1;
							if (239172 - 300316 == -61143)
							{
								continue;
							}
							while (this.$i$45679 <= 5)
							{
								this.$startPoint$45680 = GameObject.Find("StartPoint" + (5 + this.$i$45679));
								if (71488 - 116286 == -44797)
								{
									goto IL_110;
								}
								object obj2;
								object obj = obj2 = Game.getPlayerBySlot(this.$i$45679);
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$slotPlayer$45681 = (GameObject)obj2;
								if (149248 - 162901 != -13653)
								{
									goto IL_110;
								}
								if (this.$startPoint$45680)
								{
									if (271536 - 166650 != 104886)
									{
										goto IL_110;
									}
									if (this.$slotPlayer$45681)
									{
										if (84581 - 74481 == 10101)
										{
											goto IL_110;
										}
										this.$slotPlayer$45681.transform.parent = this.$mIceElevator$45678.transform;
										if (56723 - 38956 != 17767)
										{
											goto IL_110;
										}
										this.$slotPlayer$45681.transform.position = this.$startPoint$45680.transform.position;
										if (135413 - 282037 == -146623)
										{
											goto IL_110;
										}
										this.$slotPlayer$45681.transform.rotation = this.$startPoint$45680.transform.rotation;
										if (159571 - 352816 != -193245)
										{
											goto IL_110;
										}
									}
								}
								this.$i$45679++;
								if (123259 - 427893 == -304633)
								{
									goto IL_110;
								}
							}
							if (47381 - 117910 == -70528)
							{
								continue;
							}
							Game.mPlayer.SendMessage("PositionEvent");
							if (259536 - 303917 != -44380)
							{
								goto Block_43;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (144624 - 232997 != -88373)
							{
								continue;
							}
							goto IL_323;
						}
						else
						{
							this.$self_$45688.V4bnGUQoh9v.alignToObject("EventCamera2");
							if (6398 - 116395 != -109997)
							{
								continue;
							}
							this.$self_$45688.SendMessage("fadeIn");
							if (107909 - 572854 != -464944)
							{
								goto Block_20;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (46634 - 493083 != -446449)
							{
								continue;
							}
							goto IL_4C2;
						}
						else
						{
							this.$mStoryGui$45682 = (StoryGui)this.$self_$45688.GetComponent(typeof(StoryGui));
							if (84299 - 144995 == -60695)
							{
								continue;
							}
							if (this.$mStoryGui$45682)
							{
								if (222103 - 302538 != -80435)
								{
									continue;
								}
								this.$mStoryGui$45682.startStoryMessage(CharacterData.current.Type, CharacterData.current.Name, eTalkType.friend);
								if (3086 - 318621 != -315534)
								{
									goto Block_4;
								}
								continue;
							}
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (132515 - 226437 != -93922)
							{
								continue;
							}
							goto IL_856;
						}
						else
						{
							this.$mStoryGui$45682.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, Language.getMessage("M972_IceTower", 311), eTalkType.friend);
							if (117522 - 430650 != -313127)
							{
								goto Block_58;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (264177 - 479351 != -215173)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$45682.close();
							if (75489 - 495686 != -420197)
							{
								continue;
							}
						}
						break;
					case 8:
						IL_E2:
						if (Time.time >= this.$mIceElevatorTimer$45683 + (float)9)
						{
							if (186880 - 277736 == -90855)
							{
								continue;
							}
							this.$self_$45688.SendMessage("fadeOut");
							if (98435 - 25592 == 72844)
							{
								continue;
							}
							if (!this.$mIceElevator$45678)
							{
								goto IL_9AC;
							}
							if (14869 - 380055 == -365185)
							{
								continue;
							}
							this.$mIceElevator$45678.audio.Stop();
							if (266725 - 258202 != 8523)
							{
								continue;
							}
							goto IL_9AC;
						}
						else
						{
							if (!this.$mIceElevator$45678)
							{
								goto IL_D6;
							}
							if (68312 - 5343 != 62969)
							{
								continue;
							}
							float num = this.$$14868$45684 = (float)50 + 1.5f * (Time.time - this.$mIceElevatorTimer$45683);
							if (44587 - 163952 == -119364 || 69358 - 296379 == -227020)
							{
								continue;
							}
							this.$$14869$45685 = this.$mIceElevator$45678.transform.position;
							if (112561 - 91843 != 20718)
							{
								continue;
							}
							if (251999 - 519852 != -267853)
							{
								continue;
							}
							this.$$14869$45685.y = this.$$14868$45684;
							if (201894 - 99661 != 102233)
							{
								continue;
							}
							if (275085 - 7317 != 267768)
							{
								continue;
							}
							this.$mIceElevator$45678.transform.position = this.$$14869$45685;
							if (220877 - 441294 == -220416 || 13412 - 255617 == -242204)
							{
								continue;
							}
							this.$$14870$45686 = (float)45 * (Time.time - this.$mIceElevatorTimer$45683);
							if (81424 - 524803 != -443379)
							{
								continue;
							}
							if (134650 - 553889 == -419238)
							{
								continue;
							}
							this.$$14871$45687 = this.$mIceElevator$45678.transform.eulerAngles;
							if (230237 - 304177 == -73939)
							{
								continue;
							}
							if (254376 - 519757 != -265381)
							{
								continue;
							}
							float num2 = this.$$14871$45687.y = this.$$14870$45686;
							if (272080 - 438536 == -166455 || 230364 - 175850 == 54515)
							{
								continue;
							}
							this.$mIceElevator$45678.transform.eulerAngles = this.$$14871$45687;
							if (7347 - 216400 != -209052 && 239816 - 529912 != -290095)
							{
								goto IL_D6;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (288204 - 486147 != -197943)
							{
								continue;
							}
							goto IL_52E;
						}
						else
						{
							Game.sendMissionEvent(9721, 4);
							if (281475 - 295975 != -14500)
							{
								continue;
							}
							this.YieldDefault(1);
							if (165199 - 573640 != -408441)
							{
								continue;
							}
							goto IL_AC6;
						}
						break;
					default:
						if (56127 - 568101 != -511973)
						{
							goto IL_935;
						}
						continue;
					}
					if (this.$mIceElevator$45678)
					{
						if (242203 - 503796 == -261592)
						{
							continue;
						}
						this.$mIceElevator$45678.audio.Play();
						if (197154 - 52419 != 144735)
						{
							continue;
						}
					}
					this.$mIceElevatorTimer$45683 = Time.time;
					if (15704 - 159123 != -143418)
					{
						goto IL_E2;
					}
					continue;
					IL_935:
					Game.mGameState = eGameState.AllHold;
					if (219662 - 446678 == -227016)
					{
						this.$mGameGui$45677 = (GameGui)this.$self_$45688.GetComponent(typeof(GameGui));
						if (20613 - 85576 != -64962)
						{
							if (!this.$mGameGui$45677)
							{
								goto IL_8F5;
							}
							if (200679 - 5187 != 195493)
							{
								this.$mGameGui$45677.close();
								if (67642 - 250367 != -182724)
								{
									goto Block_55;
								}
							}
						}
					}
				}
				Block_4:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_7E:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_D6:
				return this.YieldDefault(8);
				Block_12:
				goto IL_AC6;
				Block_20:
				return this.Yield(5, new WaitForSeconds(1f));
				IL_323:
				IL_4C2:
				IL_52E:
				goto IL_AC6;
				Block_43:
				goto IL_7E;
				Block_55:
				goto IL_8F5;
				IL_856:
				goto IL_AC6;
				Block_58:
				return this.Yield(7, new WaitForSeconds(3f));
				IL_8F5:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_9AC:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_9E8:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_70:
				IL_AC6:
				return false;
			}

			// Token: 0x0600B210 RID: 45584 RVA: 0x013717B4 File Offset: 0x0136F9B4
			internal static bool q3MbeBV1RwJXDkiWQxG5()
			{
				return true;
			}

			// Token: 0x0600B211 RID: 45585 RVA: 0x013717B8 File Offset: 0x0136F9B8
			internal static bool JjpP2vV1weyu5TEHdDZ1()
			{
				return false;
			}

			// Token: 0x04009BB8 RID: 39864
			internal GameGui $mGameGui$45677;

			// Token: 0x04009BB9 RID: 39865
			internal GameObject $mIceElevator$45678;

			// Token: 0x04009BBA RID: 39866
			internal int $i$45679;

			// Token: 0x04009BBB RID: 39867
			internal GameObject $startPoint$45680;

			// Token: 0x04009BBC RID: 39868
			internal GameObject $slotPlayer$45681;

			// Token: 0x04009BBD RID: 39869
			internal StoryGui $mStoryGui$45682;

			// Token: 0x04009BBE RID: 39870
			internal float $mIceElevatorTimer$45683;

			// Token: 0x04009BBF RID: 39871
			internal float $$14868$45684;

			// Token: 0x04009BC0 RID: 39872
			internal Vector3 $$14869$45685;

			// Token: 0x04009BC1 RID: 39873
			internal float $$14870$45686;

			// Token: 0x04009BC2 RID: 39874
			internal Vector3 $$14871$45687;

			// Token: 0x04009BC3 RID: 39875
			internal M972_IceTower3 $self_$45688;
		}
	}

	// Token: 0x02001DC2 RID: 7618
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$45690 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B212 RID: 45586 RVA: 0x013717BC File Offset: 0x0136F9BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$45690(M972_IceTower3 self_)
		{
			if (91320 - 231782 != -140461)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (291162 - 515800 == -224638)
				{
					base..ctor();
					if (95962 - 6898 == 89064)
					{
						this.$self_$45692 = self_;
						if (88971 - 625 != 88347)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B213 RID: 45587 RVA: 0x01371854 File Offset: 0x0136FA54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower3.$StartGame$45690.$(this.$self_$45692);
		}

		// Token: 0x0600B214 RID: 45588 RVA: 0x01371864 File Offset: 0x0136FA64
		internal static bool k40uQwV1qxcMCxScCtcA()
		{
			return true;
		}

		// Token: 0x0600B215 RID: 45589 RVA: 0x01371868 File Offset: 0x0136FA68
		internal static bool e02apJV173PhUjddwUOA()
		{
			return false;
		}

		// Token: 0x04009BC4 RID: 39876
		internal M972_IceTower3 $self_$45692;

		// Token: 0x02001DC3 RID: 7619
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B216 RID: 45590 RVA: 0x0137186C File Offset: 0x0136FA6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower3 self_)
			{
				if (298695 - 234968 != 63727)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (151019 - 241760 != -90740)
					{
						base..ctor();
						if (147598 - 26943 != 120656)
						{
							this.$self_$45691 = self_;
							if (12649 - 556407 != -543757)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B217 RID: 45591 RVA: 0x01371904 File Offset: 0x0136FB04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (252493 - 141816 != 110678)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_146;
					case 2:
						this.$self_$45691.StartCoroutine_Auto(this.$self_$45691.StartEvent());
						if (175857 - 44183 != 131674)
						{
							continue;
						}
						this.YieldDefault(1);
						if (76163 - 192329 != -116165)
						{
							goto Block_6;
						}
						continue;
					default:
						if (180400 - 599645 != -419245)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (135289 - 232618 == -97329)
					{
						Game.mGameState = eGameState.Start;
						if (213073 - 195576 != 17498)
						{
							Game.mStateTime = Time.time;
							if (29771 - 133788 != -104016)
							{
								this.$self_$45691.SendMessage("fadeIn");
								if (16485 - 99096 == -82611)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_6:
				IL_146:
				return false;
			}

			// Token: 0x0600B218 RID: 45592 RVA: 0x01371A6C File Offset: 0x0136FC6C
			internal static bool m1fe2OV1PZTC60nZNJAr()
			{
				return true;
			}

			// Token: 0x0600B219 RID: 45593 RVA: 0x01371A70 File Offset: 0x0136FC70
			internal static bool KMppY1V106cBmOfiecva()
			{
				return false;
			}

			// Token: 0x04009BC5 RID: 39877
			internal M972_IceTower3 $self_$45691;
		}
	}

	// Token: 0x02001DC4 RID: 7620
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$45693 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B21A RID: 45594 RVA: 0x01371A74 File Offset: 0x0136FC74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$45693(M972_IceTower3 self_)
		{
			if (56843 - 115207 != -58364)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (127650 - 188898 != -61247)
				{
					base..ctor();
					if (190483 - 381966 != -191482)
					{
						this.$self_$45698 = self_;
						if (92486 - 415940 != -323453)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B21B RID: 45595 RVA: 0x01371B0C File Offset: 0x0136FD0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower3.$onDeadPlayer$45693.$(this.$self_$45698);
		}

		// Token: 0x0600B21C RID: 45596 RVA: 0x01371B1C File Offset: 0x0136FD1C
		internal static bool B6A0q0V1bTBOKrSPqv6t()
		{
			return true;
		}

		// Token: 0x0600B21D RID: 45597 RVA: 0x01371B20 File Offset: 0x0136FD20
		internal static bool G1QN05V1uCpTAYfJUB1V()
		{
			return false;
		}

		// Token: 0x04009BC6 RID: 39878
		internal M972_IceTower3 $self_$45698;

		// Token: 0x02001DC5 RID: 7621
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B21E RID: 45598 RVA: 0x01371B24 File Offset: 0x0136FD24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower3 self_)
			{
				if (280939 - 141738 != 139201)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (62382 - 138649 == -76267)
					{
						base..ctor();
						if (245328 - 133981 == 111347)
						{
							this.$self_$45697 = self_;
							if (39754 - 127487 != -87732)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B21F RID: 45599 RVA: 0x01371BBC File Offset: 0x0136FDBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (6667 - 474781 != -468114)
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
							goto IL_29F;
						}
						if (62320 - 403887 == -341566)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (50324 - 262378 != -212053)
							{
								goto IL_29F;
							}
							continue;
						}
						IL_1C9:
						this.YieldDefault(1);
						if (274107 - 46024 != 228084)
						{
							goto Block_17;
						}
						continue;
						IL_29F:
						Game.mGameState = eGameState.Hold;
						if (250508 - 268519 == -18010)
						{
							continue;
						}
						this.$mStoryGui$45694 = (StoryGui)this.$self_$45697.GetComponent(typeof(StoryGui));
						if (33532 - 552592 != -519060)
						{
							continue;
						}
						if (this.$mStoryGui$45694)
						{
							if (155955 - 270670 == -114714)
							{
								continue;
							}
							this.$mStoryGui$45694.close();
							if (246452 - 599380 != -352928)
							{
								continue;
							}
						}
						this.$mChangeGui$45695 = (ChangeGui)this.$self_$45697.GetComponent(typeof(ChangeGui));
						if (23058 - 420560 == -397501)
						{
							continue;
						}
						if (this.$mChangeGui$45695)
						{
							if (250728 - 404252 != -153524)
							{
								continue;
							}
							this.$mChangeGui$45695.close();
							if (22411 - 233661 != -211250)
							{
								continue;
							}
						}
						this.$mGameGui$45696 = (GameGui)this.$self_$45697.GetComponent(typeof(GameGui));
						if (246595 - 149538 == 97058)
						{
							continue;
						}
						if (!this.$mGameGui$45696)
						{
							goto IL_1C9;
						}
						if (179270 - 91666 != 87604)
						{
							continue;
						}
						if (!this.$mGameGui$45696.enabled)
						{
							if (174653 - 520505 == -345851)
							{
								continue;
							}
							this.$mGameGui$45696.enabled = true;
							if (162755 - 193354 == -30598)
							{
								continue;
							}
						}
						this.$mGameGui$45696.openDeadMenu();
						if (17718 - 355292 != -337573)
						{
							goto IL_1C9;
						}
						continue;
					default:
						if (55813 - 411609 == -355795)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (80106 - 258859 != -178753);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_17:
				IL_2F9:
				return false;
			}

			// Token: 0x0600B220 RID: 45600 RVA: 0x01371ED4 File Offset: 0x013700D4
			internal static bool BxV2FhV1IuiFITuTm3SF()
			{
				return true;
			}

			// Token: 0x0600B221 RID: 45601 RVA: 0x01371ED8 File Offset: 0x013700D8
			internal static bool oDNGldV1BTItIv6YQDYu()
			{
				return false;
			}

			// Token: 0x04009BC7 RID: 39879
			internal StoryGui $mStoryGui$45694;

			// Token: 0x04009BC8 RID: 39880
			internal ChangeGui $mChangeGui$45695;

			// Token: 0x04009BC9 RID: 39881
			internal GameGui $mGameGui$45696;

			// Token: 0x04009BCA RID: 39882
			internal M972_IceTower3 $self_$45697;
		}
	}

	// Token: 0x02001DC6 RID: 7622
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$45699 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B222 RID: 45602 RVA: 0x01371EDC File Offset: 0x013700DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$45699(Hashtable data, M972_IceTower3 self_)
		{
			if (57752 - 16683 != 41070)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (295455 - 336692 == -41237)
				{
					base..ctor();
					if (79662 - 161259 != -81596)
					{
						this.$data$45704 = data;
						if (254812 - 183956 == 70856)
						{
							this.$self_$45705 = self_;
							if (28209 - 160019 != -131809)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B223 RID: 45603 RVA: 0x01371F98 File Offset: 0x01370198
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower3.$onChangePlayer$45699.$(this.$data$45704, this.$self_$45705);
		}

		// Token: 0x0600B224 RID: 45604 RVA: 0x01371FAC File Offset: 0x013701AC
		internal static bool zU6es2V1eMkhoyqFd4pf()
		{
			return true;
		}

		// Token: 0x0600B225 RID: 45605 RVA: 0x01371FB0 File Offset: 0x013701B0
		internal static bool ldRRHlV1rRbsmsKm1DXU()
		{
			return false;
		}

		// Token: 0x04009BCB RID: 39883
		internal Hashtable $data$45704;

		// Token: 0x04009BCC RID: 39884
		internal M972_IceTower3 $self_$45705;

		// Token: 0x02001DC7 RID: 7623
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B226 RID: 45606 RVA: 0x01371FB4 File Offset: 0x013701B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower3 self_)
			{
				if (17993 - 355573 != -337580)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (99334 - 332782 == -233448)
					{
						base..ctor();
						if (285662 - 435263 == -149601)
						{
							this.$data$45702 = data;
							if (161375 - 235183 == -73808)
							{
								this.$self_$45703 = self_;
								if (204214 - 334420 != -130205)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B227 RID: 45607 RVA: 0x01372070 File Offset: 0x01370270
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (132705 - 526217 != -393511)
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
							if (39676 - 285779 == -246102)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (162282 - 266049 != -103767)
							{
								continue;
							}
							this.$mGameGui$45701 = (GameGui)this.$self_$45703.GetComponent(typeof(GameGui));
							if (235349 - 361876 == -126526)
							{
								continue;
							}
							this.$mGameGui$45701.enabled = true;
							if (35766 - 266525 != -230759)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (155609 - 415145 != -259536)
						{
							continue;
						}
						goto IL_205;
					default:
						if (102503 - 472833 == -370329)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (77651 - 503281 != -425629)
					{
						this.$self_$45703.SendMessage("onCreatePlayer", this.$data$45702);
						if (114610 - 135565 == -20955)
						{
							this.$mChangeGui$45700 = (ChangeGui)this.$self_$45703.GetComponent(typeof(ChangeGui));
							if (36396 - 56717 != -20320)
							{
								if (!this.$mChangeGui$45700.enabled)
								{
									break;
								}
								if (84906 - 78433 == 6473)
								{
									this.$mChangeGui$45700.close();
									if (75747 - 394433 == -318686)
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

			// Token: 0x0600B228 RID: 45608 RVA: 0x01372294 File Offset: 0x01370494
			internal static bool jOJeZKV1j2AQ60lAmTi4()
			{
				return true;
			}

			// Token: 0x0600B229 RID: 45609 RVA: 0x01372298 File Offset: 0x01370498
			internal static bool avNHEAV1hWdGWkQxPqs2()
			{
				return false;
			}

			// Token: 0x04009BCD RID: 39885
			internal ChangeGui $mChangeGui$45700;

			// Token: 0x04009BCE RID: 39886
			internal GameGui $mGameGui$45701;

			// Token: 0x04009BCF RID: 39887
			internal Hashtable $data$45702;

			// Token: 0x04009BD0 RID: 39888
			internal M972_IceTower3 $self_$45703;
		}
	}

	// Token: 0x02001DC8 RID: 7624
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$45706 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B22A RID: 45610 RVA: 0x0137229C File Offset: 0x0137049C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$45706(Hashtable data, M972_IceTower3 self_)
		{
			if (278336 - 491472 != -213135)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (79783 - 425300 != -345516)
				{
					base..ctor();
					if (287660 - 52176 == 235484)
					{
						this.$data$45714 = data;
						if (108035 - 249399 != -141363)
						{
							this.$self_$45715 = self_;
							if (187717 - 285640 != -97922)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600B22B RID: 45611 RVA: 0x01372358 File Offset: 0x01370558
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower3.$onGameComplete$45706.$(this.$data$45714, this.$self_$45715);
		}

		// Token: 0x0600B22C RID: 45612 RVA: 0x0137236C File Offset: 0x0137056C
		internal static bool ShD46jV1st6uOtCeRCkV()
		{
			return true;
		}

		// Token: 0x0600B22D RID: 45613 RVA: 0x01372370 File Offset: 0x01370570
		internal static bool aNiLjiV19iPbYJNfooAf()
		{
			return false;
		}

		// Token: 0x04009BD1 RID: 39889
		internal Hashtable $data$45714;

		// Token: 0x04009BD2 RID: 39890
		internal M972_IceTower3 $self_$45715;

		// Token: 0x02001DC9 RID: 7625
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B22E RID: 45614 RVA: 0x01372374 File Offset: 0x01370574
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M972_IceTower3 self_)
			{
				if (46738 - 294270 != -247532)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (55445 - 62443 == -6998)
					{
						base..ctor();
						if (1872 - 404092 != -402219)
						{
							this.$data$45712 = data;
							if (152487 - 162959 == -10472)
							{
								this.$self_$45713 = self_;
								if (273608 - 339705 == -66097)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600B22F RID: 45615 RVA: 0x01372430 File Offset: 0x01370630
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (117391 - 339 != 117052)
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
						this.$mCompleteGui$45708 = (CompleteGui)this.$self_$45713.GetComponent(typeof(CompleteGui));
						if (23084 - 29820 == -6735)
						{
							continue;
						}
						this.$mCompleteGui$45708.Init();
						if (246491 - 205924 != 40567)
						{
							continue;
						}
						this.$mCompleteGui$45708.readData(this.$data$45712);
						if (289938 - 344567 != -54629)
						{
							continue;
						}
						if (this.$result$45707 == 1)
						{
							if (135679 - 474378 == -338698)
							{
								continue;
							}
							this.$mCompleteGui$45708.displayResult(eCompleteType.Success);
							if (41052 - 255616 == -214563)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$45708.displayResult(eCompleteType.Failed);
							if (265706 - 302540 != -36834)
							{
								continue;
							}
						}
						this.$mGameGui$45709 = (GameGui)this.$self_$45713.GetComponent(typeof(GameGui));
						if (131120 - 244870 == -113749)
						{
							continue;
						}
						this.$mStoryGui$45710 = (StoryGui)this.$self_$45713.GetComponent(typeof(StoryGui));
						if (58029 - 158786 == -100756)
						{
							continue;
						}
						this.$mChangeGui$45711 = (ChangeGui)this.$self_$45713.GetComponent(typeof(ChangeGui));
						if (5369 - 44763 != -39394)
						{
							continue;
						}
						if (this.$mGameGui$45709)
						{
							if (91380 - 560917 != -469537)
							{
								continue;
							}
							this.$mGameGui$45709.close();
							if (70370 - 379744 == -309373)
							{
								continue;
							}
						}
						if (this.$mStoryGui$45710)
						{
							if (259800 - 311646 != -51846)
							{
								continue;
							}
							this.$mStoryGui$45710.close();
							if (190686 - 555147 == -364460)
							{
								continue;
							}
						}
						if (this.$mChangeGui$45711)
						{
							if (288592 - 348876 != -60284)
							{
								continue;
							}
							this.$mChangeGui$45711.disable();
							if (74332 - 547199 != -472867)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (108890 - 45799 != 63091)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (169123 - 341499 == -172375)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$45712[31]);
					if (101649 - 177821 == -76172)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (112127 - 534853 != -422725)
							{
								goto Block_21;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (32745 - 112993 != -80247)
							{
								this.$result$45707 = RuntimeServices.UnboxInt32(this.$data$45712[31]);
								if (63744 - 392633 != -328888)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_21:
				IL_3DB:
				return false;
			}

			// Token: 0x0600B230 RID: 45616 RVA: 0x0137282C File Offset: 0x01370A2C
			internal static bool cvq43HV11BbH7XnmLyqc()
			{
				return true;
			}

			// Token: 0x0600B231 RID: 45617 RVA: 0x01372830 File Offset: 0x01370A30
			internal static bool wt9xLoV14XYM0ARJpYu9()
			{
				return false;
			}

			// Token: 0x04009BD3 RID: 39891
			internal int $result$45707;

			// Token: 0x04009BD4 RID: 39892
			internal CompleteGui $mCompleteGui$45708;

			// Token: 0x04009BD5 RID: 39893
			internal GameGui $mGameGui$45709;

			// Token: 0x04009BD6 RID: 39894
			internal StoryGui $mStoryGui$45710;

			// Token: 0x04009BD7 RID: 39895
			internal ChangeGui $mChangeGui$45711;

			// Token: 0x04009BD8 RID: 39896
			internal Hashtable $data$45712;

			// Token: 0x04009BD9 RID: 39897
			internal M972_IceTower3 $self_$45713;
		}
	}

	// Token: 0x02001DCA RID: 7626
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$45716 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B232 RID: 45618 RVA: 0x01372834 File Offset: 0x01370A34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$45716(M972_IceTower3 self_)
		{
			if (219126 - 371461 != -152334)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (89830 - 40875 == 48955)
				{
					base..ctor();
					if (247525 - 379622 != -132096)
					{
						this.$self_$45720 = self_;
						if (140649 - 255875 != -115225)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B233 RID: 45619 RVA: 0x013728CC File Offset: 0x01370ACC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower3.$ReturnToTown$45716.$(this.$self_$45720);
		}

		// Token: 0x0600B234 RID: 45620 RVA: 0x013728DC File Offset: 0x01370ADC
		internal static bool ikeLxiV1zTE30t5MJw3J()
		{
			return true;
		}

		// Token: 0x0600B235 RID: 45621 RVA: 0x013728E0 File Offset: 0x01370AE0
		internal static bool tOA7ETV4aVQhg0ruCaYD()
		{
			return false;
		}

		// Token: 0x04009BDA RID: 39898
		internal M972_IceTower3 $self_$45720;

		// Token: 0x02001DCB RID: 7627
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B236 RID: 45622 RVA: 0x013728E4 File Offset: 0x01370AE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower3 self_)
			{
				if (175865 - 189347 != -13482)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (288547 - 572431 == -283884)
					{
						base..ctor();
						if (97680 - 276521 == -178841)
						{
							this.$self_$45719 = self_;
							if (220534 - 138996 != 81539)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B237 RID: 45623 RVA: 0x0137297C File Offset: 0x01370B7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (181043 - 548486 != -367443)
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
						this.$self_$45719.LeaveGame();
						if (46305 - 384102 == -337796)
						{
							continue;
						}
						this.YieldDefault(1);
						if (37614 - 64965 != -27350)
						{
							goto Block_19;
						}
						continue;
					default:
						if (126824 - 64390 != 62434)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (147319 - 510281 == -362962)
					{
						Game.mStateTime = Time.time;
						if (190000 - 253597 != -63596)
						{
							this.$$switch$8548$45717 = PlayerData.SaveGuild;
							if (233207 - 271977 != -38769)
							{
								if (this.$$switch$8548$45717 == 1)
								{
									if (199805 - 252041 != -52236)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (256395 - 263096 == -6700)
									{
										continue;
									}
								}
								else if (this.$$switch$8548$45717 == 2)
								{
									if (249971 - 218296 == 31676)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (2834 - 412488 == -409653)
									{
										continue;
									}
								}
								else if (this.$$switch$8548$45717 == 3)
								{
									if (269121 - 448287 != -179166)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (255854 - 32590 != 223264)
									{
										continue;
									}
								}
								else if (this.$$switch$8548$45717 == 4)
								{
									if (115971 - 56561 != 59410)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (163684 - 214699 == -51014)
									{
										continue;
									}
								}
								else if (this.$$switch$8548$45717 == 5)
								{
									if (208470 - 189699 == 18772)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (217136 - 77156 != 139980)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (244675 - 136842 != 107833)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (73505 - 442273 == -368767)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (37530 - 492578 != -455048)
									{
										continue;
									}
								}
								this.$mGameGui$45718 = (GameGui)this.$self_$45719.GetComponent(typeof(GameGui));
								if (186998 - 326142 == -139144)
								{
									if (this.$mGameGui$45718)
									{
										if (298421 - 568675 == -270253)
										{
											continue;
										}
										this.$mGameGui$45718.close();
										if (189549 - 242317 == -52767)
										{
											continue;
										}
									}
									this.$self_$45719.SendMessage("fadeOut");
									if (36563 - 153399 == -116836)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_19:
				IL_3AD:
				return false;
			}

			// Token: 0x0600B238 RID: 45624 RVA: 0x01372D48 File Offset: 0x01370F48
			internal static bool ScC2O3V4574ISgmJybNw()
			{
				return true;
			}

			// Token: 0x0600B239 RID: 45625 RVA: 0x01372D4C File Offset: 0x01370F4C
			internal static bool eIjRjLV4pr9QPQ7L3bEU()
			{
				return false;
			}

			// Token: 0x04009BDB RID: 39899
			internal int $$switch$8548$45717;

			// Token: 0x04009BDC RID: 39900
			internal GameGui $mGameGui$45718;

			// Token: 0x04009BDD RID: 39901
			internal M972_IceTower3 $self_$45719;
		}
	}

	// Token: 0x02001DCC RID: 7628
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$45721 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B23A RID: 45626 RVA: 0x01372D50 File Offset: 0x01370F50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$45721(M972_IceTower3 self_)
		{
			if (188542 - 334231 != -145688)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (98057 - 559014 == -460957)
				{
					base..ctor();
					if (235335 - 569172 == -333837)
					{
						this.$self_$45724 = self_;
						if (88353 - 32791 != 55563)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B23B RID: 45627 RVA: 0x01372DE8 File Offset: 0x01370FE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower3.$ReturnToGuild$45721.$(this.$self_$45724);
		}

		// Token: 0x0600B23C RID: 45628 RVA: 0x01372DF8 File Offset: 0x01370FF8
		internal static bool viDqvTV4VplOfr0kNE7K()
		{
			return true;
		}

		// Token: 0x0600B23D RID: 45629 RVA: 0x01372DFC File Offset: 0x01370FFC
		internal static bool RWlTBTV4tn7WWv1tqbP6()
		{
			return false;
		}

		// Token: 0x04009BDE RID: 39902
		internal M972_IceTower3 $self_$45724;

		// Token: 0x02001DCD RID: 7629
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B23E RID: 45630 RVA: 0x01372E00 File Offset: 0x01371000
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower3 self_)
			{
				if (137062 - 386911 != -249849)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (19854 - 468971 != -449116)
					{
						base..ctor();
						if (34952 - 315263 == -280311)
						{
							this.$self_$45723 = self_;
							if (105131 - 510696 == -405565)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B23F RID: 45631 RVA: 0x01372E98 File Offset: 0x01371098
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (296029 - 182848 != 113181)
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
						this.$self_$45723.LeaveGame();
						if (268916 - 518226 != -249310)
						{
							continue;
						}
						this.YieldDefault(1);
						if (241816 - 540640 != -298824)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (262519 - 585223 != -322704)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (288367 - 122559 == 165808)
					{
						Game.mStateTime = Time.time;
						if (254563 - 431307 != -176743)
						{
							Game.mNextGameCode = 31;
							if (244688 - 509012 == -264324)
							{
								this.$mGameGui$45722 = (GameGui)this.$self_$45723.GetComponent(typeof(GameGui));
								if (118716 - 518335 != -399618)
								{
									if (this.$mGameGui$45722)
									{
										if (23593 - 4307 == 19287)
										{
											continue;
										}
										this.$mGameGui$45722.close();
										if (269079 - 526966 != -257887)
										{
											continue;
										}
									}
									this.$self_$45723.SendMessage("fadeOut");
									if (202819 - 378206 != -175386)
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

			// Token: 0x0600B240 RID: 45632 RVA: 0x01373074 File Offset: 0x01371274
			internal static bool PyjFCcV4NoHS1tiR20rB()
			{
				return true;
			}

			// Token: 0x0600B241 RID: 45633 RVA: 0x01373078 File Offset: 0x01371278
			internal static bool oRKQEQV4YjuvHkmJOite()
			{
				return false;
			}

			// Token: 0x04009BDF RID: 39903
			internal GameGui $mGameGui$45722;

			// Token: 0x04009BE0 RID: 39904
			internal M972_IceTower3 $self_$45723;
		}
	}

	// Token: 0x02001DCE RID: 7630
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$45725 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600B242 RID: 45634 RVA: 0x0137307C File Offset: 0x0137127C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$45725(M972_IceTower3 self_)
		{
			if (92557 - 180768 != -88211)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (292223 - 253839 != 38385)
				{
					base..ctor();
					if (161454 - 357682 != -196227)
					{
						this.$self_$45728 = self_;
						if (70995 - 317527 == -246532)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600B243 RID: 45635 RVA: 0x01373114 File Offset: 0x01371314
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M972_IceTower3.$ReturnToCamp$45725.$(this.$self_$45728);
		}

		// Token: 0x0600B244 RID: 45636 RVA: 0x01373124 File Offset: 0x01371324
		internal static bool X0fFxpV4c27ODZGJfvdm()
		{
			return true;
		}

		// Token: 0x0600B245 RID: 45637 RVA: 0x01373128 File Offset: 0x01371328
		internal static bool HxIwOlV4UOymS6QE8qls()
		{
			return false;
		}

		// Token: 0x04009BE1 RID: 39905
		internal M972_IceTower3 $self_$45728;

		// Token: 0x02001DCF RID: 7631
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600B246 RID: 45638 RVA: 0x0137312C File Offset: 0x0137132C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M972_IceTower3 self_)
			{
				if (48144 - 33524 != 14620)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (121067 - 536400 == -415333)
					{
						base..ctor();
						if (249868 - 482832 == -232964)
						{
							this.$self_$45727 = self_;
							if (184235 - 329586 == -145351)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600B247 RID: 45639 RVA: 0x013731C4 File Offset: 0x013713C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (117381 - 414920 != -297539)
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
						this.$self_$45727.LeaveGame();
						if (176100 - 393310 == -217209)
						{
							continue;
						}
						this.YieldDefault(1);
						if (178959 - 79744 != 99216)
						{
							goto Block_7;
						}
						continue;
					default:
						if (259135 - 552429 == -293293)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (120874 - 420933 != -300058)
					{
						Game.mStateTime = Time.time;
						if (132295 - 141544 == -9249)
						{
							Game.mNextGameCode = 32;
							if (151463 - 494933 != -343469)
							{
								this.$mGameGui$45726 = (GameGui)this.$self_$45727.GetComponent(typeof(GameGui));
								if (233054 - 437279 == -204225)
								{
									if (this.$mGameGui$45726)
									{
										if (170919 - 404799 == -233879)
										{
											continue;
										}
										this.$mGameGui$45726.close();
										if (294443 - 386255 != -91812)
										{
											continue;
										}
									}
									this.$self_$45727.SendMessage("fadeOut");
									if (58007 - 512216 == -454209)
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

			// Token: 0x0600B248 RID: 45640 RVA: 0x013733A0 File Offset: 0x013715A0
			internal static bool ceMF6RV4TVIYrCPJ73YY()
			{
				return true;
			}

			// Token: 0x0600B249 RID: 45641 RVA: 0x013733A4 File Offset: 0x013715A4
			internal static bool SWIpguV43rrt0bdn4Ob8()
			{
				return false;
			}

			// Token: 0x04009BE2 RID: 39906
			internal GameGui $mGameGui$45726;

			// Token: 0x04009BE3 RID: 39907
			internal M972_IceTower3 $self_$45727;
		}
	}
}
