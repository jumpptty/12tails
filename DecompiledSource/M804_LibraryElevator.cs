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

// Token: 0x020017AF RID: 6063
[Serializable]
public class M804_LibraryElevator : MonoBehaviour
{
	// Token: 0x06008D1B RID: 36123 RVA: 0x01136590 File Offset: 0x01134790
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M804_LibraryElevator()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06008D1C RID: 36124 RVA: 0x011365A0 File Offset: 0x011347A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (236958 - 348398 != -111439)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (35282 - 279804 != -244521)
			{
				Game.mGameType = 5;
				if (49643 - 547904 == -498261)
				{
					if (Chat.Initialized)
					{
						if (2533 - 486636 == -484103)
						{
							Chat.ChatDisplay.Clear();
							if (137796 - 142994 != -5197)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (275036 - 112374 == 162662)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008D1D RID: 36125 RVA: 0x01136684 File Offset: 0x01134884
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (172101 - 379329 != -207228)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (148134 - 29066 != 119069)
				{
					if (Game.mNextGameCode != 804)
					{
						break;
					}
					if (275280 - 502192 != -226911)
					{
						Game.nextGame();
						if (55841 - 586827 == -530986)
						{
							Game.mGameCode = 804;
							if (108421 - 166154 != -57732)
							{
								Game.mGameType = 5;
								if (214290 - 457157 == -242867)
								{
									Game.mGameTime = Time.time;
									if (60589 - 241629 == -181040)
									{
										Game.mGameScore = 0;
										if (237997 - 209279 == 28718)
										{
											Game.mGameMana = 0;
											if (46056 - 203702 == -157646)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (25239 - 207803 != -182563)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (131572 - 98094 != 33479)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (231096 - 302471 != -71374)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (264996 - 433035 != -168038)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (79056 - 399505 != -320448)
																{
																	this.ibFczTesLIy = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (95748 - 380926 != -285177)
																	{
																		this.fBCczxGmSmh = PhotonClient.Connection;
																		if (134666 - 315952 == -181286)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (132282 - 190955 != -58672)
																			{
																				this.InitGame();
																				if (47721 - 196734 == -149013)
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
				if (126889 - 308685 == -181796)
				{
					Game.mGameType = 99;
					if (276310 - 443453 != -167142)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008D1E RID: 36126 RVA: 0x0113698C File Offset: 0x01134B8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (124100 - 87585 != 36516)
		{
		}
		for (;;)
		{
			if (this.fBCczxGmSmh == null)
			{
				if (80384 - 67616 == 12768)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (222779 - 137549 == 85230)
				{
					if (mGameState == eGameState.Init)
					{
						if (13420 - 233473 == -220053)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (292705 - 254616 == 38089)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (250938 - 67368 == 183570)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (20175 - 500920 != -480744)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (113478 - 474010 != -360531)
						{
							if (Game.music != 0)
							{
								if (92767 - 300391 != -207624)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (82104 - 155746 != -73642)
									{
										continue;
									}
									this.audio.Play();
									if (78755 - 290316 != -211561)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (54512 - 485084 == -430572)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
									if (53957 - 81110 != -27152)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (105198 - 111161 != -5962)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (108720 - 105552 == 3168)
						{
							if (Game.music != 0)
							{
								if (205025 - 452847 == -247821)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (257784 - 505327 != -247543)
									{
										continue;
									}
									this.audio.Play();
									if (9898 - 69398 != -59500)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (253365 - 155348 == 98018)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (25354 - 260975 != -235621)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (228960 - 453640 == -224679)
								{
									continue;
								}
							}
							if (Time.time > this.yneczYv2nA6)
							{
								if (288517 - 141573 == 146945)
								{
									continue;
								}
								Game.mGameMana++;
								if (29711 - 270554 != -240843)
								{
									continue;
								}
								this.yneczYv2nA6 = Time.time + (float)12;
								if (159061 - 174246 == -15184)
								{
									continue;
								}
							}
							this.GameEventUpdate();
							if (223585 - 537556 != -313970)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (70417 - 511908 != -441490)
						{
							this.GameEventUpdate();
							if (64536 - 441606 == -377070)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (221058 - 57206 != 163853)
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
						if (76078 - 550744 == -474666)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008D1F RID: 36127 RVA: 0x01136E60 File Offset: 0x01135060
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameEventUpdate()
	{
		if (39656 - 531960 != -492304)
		{
		}
		for (;;)
		{
			int num = this.xe2czdXlqeY;
			if (219020 - 81301 != 137720)
			{
				if (num == 0)
				{
					if (269185 - 262554 != 6632)
					{
						this.NextEvent(16);
						if (48460 - 258976 == -210516)
						{
							break;
						}
					}
				}
				else if (num == 1)
				{
					if (37199 - 537856 != -500656)
					{
						this.NextEvent(28);
						if (170398 - 293604 != -123205)
						{
							break;
						}
					}
				}
				else if (num == 2)
				{
					if (160408 - 210726 != -50317)
					{
						this.NextEvent(64);
						if (247632 - 202296 != 45337)
						{
							break;
						}
					}
				}
				else if (num == 3)
				{
					if (10511 - 213587 != -203075)
					{
						this.NextEvent(76);
						if (73741 - 577830 == -504089)
						{
							break;
						}
					}
				}
				else if (num == 4)
				{
					if (27801 - 150143 == -122342)
					{
						this.NextEvent(106);
						if (81876 - 359654 == -277778)
						{
							break;
						}
					}
				}
				else if (num == 5)
				{
					if (254962 - 256280 == -1318)
					{
						this.NextEvent(118);
						if (103857 - 29256 != 74602)
						{
							break;
						}
					}
				}
				else if (num == 6)
				{
					if (288696 - 408807 == -120111)
					{
						this.NextEvent(136);
						if (284158 - 489933 != -205774)
						{
							break;
						}
					}
				}
				else if (num == 7)
				{
					if (181464 - 420577 != -239112)
					{
						this.NextEvent(148);
						if (76865 - 41637 != 35229)
						{
							break;
						}
					}
				}
				else if (num == 8)
				{
					if (77350 - 449052 != -371701)
					{
						this.NextEvent(180);
						if (25713 - 219997 == -194284)
						{
							break;
						}
					}
				}
				else if (num == 9)
				{
					if (24981 - 324420 != -299438)
					{
						this.NextEvent(190);
						if (123983 - 580248 != -456264)
						{
							break;
						}
					}
				}
				else if (num == 10)
				{
					if (122766 - 236029 != -113262)
					{
						this.NextEvent(226);
						if (151968 - 599692 != -447723)
						{
							break;
						}
					}
				}
				else if (num == 11)
				{
					if (24316 - 588288 != -563971)
					{
						this.NextEvent(238);
						if (179009 - 269249 == -90240)
						{
							break;
						}
					}
				}
				else
				{
					if (num != 12)
					{
						break;
					}
					if (28333 - 320833 == -292500)
					{
						if (this.aL8czgOA3aG < 34)
						{
							break;
						}
						if (42758 - 192037 == -149279)
						{
							if (Time.time < Game.mStateTime + (float)300)
							{
								break;
							}
							if (173276 - 193192 == -19916)
							{
								this.xe2czdXlqeY = 99;
								if (240206 - 434352 != -194145)
								{
									Game.sendMissionEvent(8043, this.xe2czdXlqeY);
									if (122515 - 249256 == -126741)
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

	// Token: 0x06008D20 RID: 36128 RVA: 0x011372F8 File Offset: 0x011354F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void NextEvent(int nTimer)
	{
		if (3014 - 420833 != -417818)
		{
		}
		while (Time.time >= Game.mStateTime + (float)nTimer)
		{
			if (155192 - 50870 == 104322)
			{
				this.xe2czdXlqeY++;
				if (283462 - 18567 == 264895)
				{
					Game.sendMissionEvent(8041, this.xe2czdXlqeY);
					if (240793 - 89627 == 151166)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008D21 RID: 36129 RVA: 0x011373B0 File Offset: 0x011355B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePaperBug(string nType, int nNum)
	{
		if (59040 - 419696 != -360655)
		{
		}
		for (;;)
		{
			GameObject gameObject = GameObject.Find("SpawnPoint" + nNum);
			if (126504 - 198913 != -72408)
			{
				if (gameObject)
				{
					if (225805 - 118134 != 107672)
					{
						Vector3 randomSpawnPos = global::Math.getRandomSpawnPos(gameObject.transform.position, 2);
						if (23120 - 192439 == -169319)
						{
							if (randomSpawnPos != Vector3.zero)
							{
								if (249582 - 41584 == 207999)
								{
									continue;
								}
								this.createActor(nType, 6, randomSpawnPos, gameObject.transform.forward);
								if (303 - 11104 != -10801)
								{
									continue;
								}
							}
							else
							{
								this.createActor(nType, 6, gameObject.transform.position, gameObject.transform.forward);
								if (162862 - 360441 != -197579)
								{
									continue;
								}
							}
							this.V3Acz35Zae1++;
							if (184517 - 510774 != -326256)
							{
								Debug.Log("Create bug#" + this.V3Acz35Zae1);
								if (26176 - 98288 != -72111)
								{
									break;
								}
							}
						}
					}
				}
				else
				{
					Debug.LogError("Cannont find SpawnPoint" + nNum);
					if (268100 - 152247 == 115853)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008D22 RID: 36130 RVA: 0x01137590 File Offset: 0x01135790
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (217677 - 227917 != -10240)
		{
		}
		for (;;)
		{
			if (!this.AXHczbrFTV3)
			{
				if (4285 - 434770 != -430484)
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
				if (156828 - 459597 != -302768)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (238176 - 492467 != -254290)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (157861 - 445921 == -288060)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (224678 - 343093 == -118415)
							{
								GUI.depth = 1;
								if (225549 - 413556 != -188006)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (70670 - 158706 != -88035)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (241166 - 301215 != -60048)
										{
											Color color = GUI.color;
											if (289363 - 240614 != 48750)
											{
												float num3 = color.a = a;
												if (104605 - 481973 == -377368)
												{
													if (37461 - 216889 == -179428)
													{
														Color color2 = GUI.color = color;
														if (180726 - 131937 == 48789)
														{
															if (150926 - 508491 != -357564)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.AXHczbrFTV3);
																if (55252 - 591257 == -536005)
																{
																	float a2 = 1f;
																	if (282816 - 560540 == -277724)
																	{
																		Color color3 = GUI.color;
																		if (106433 - 60992 != 45442)
																		{
																			float num4 = color3.a = a2;
																			if (206281 - 290775 == -84494)
																			{
																				if (112063 - 509217 != -397153)
																				{
																					Color color4 = GUI.color = color3;
																					if (5199 - 224504 != -219304)
																					{
																						if (195099 - 519713 == -324614)
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

	// Token: 0x06008D23 RID: 36131 RVA: 0x01137910 File Offset: 0x01135B10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (288200 - 437709 != -149508)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (129641 - 546475 == -416834)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (91509 - 85661 != 5849)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (169422 - 252304 == -82882)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (248487 - 494016 != -245528)
						{
							int num4 = num;
							if (289634 - 274585 == 15049)
							{
								if (num4 == 8041)
								{
									if (230397 - 35445 == 194952)
									{
										break;
									}
								}
								else if (num4 == -8041)
								{
									if (109318 - 152017 != -42698)
									{
										if (num3 != PlayerData.UID)
										{
											break;
										}
										if (111703 - 174968 == -63265)
										{
											int num5 = num2;
											if (245975 - 821 == 245154)
											{
												if (num5 == 1)
												{
													if (16828 - 557910 != -541081)
													{
														this.CreatePaperBug("PaperBug1", 11);
														if (189505 - 186881 != 2625)
														{
															break;
														}
													}
												}
												else if (num5 == 2)
												{
													if (52030 - 143460 == -91430)
													{
														this.CreatePaperBug("PaperBug1", 11);
														if (212327 - 396215 == -183888)
														{
															break;
														}
													}
												}
												else if (num5 == 3)
												{
													if (168669 - 168335 != 335)
													{
														this.CreatePaperBug("PaperBug1", 21);
														if (78860 - 449289 == -370429)
														{
															this.CreatePaperBug("PaperBug1", 22);
															if (78984 - 214785 != -135800)
															{
																break;
															}
														}
													}
												}
												else if (num5 == 4)
												{
													if (64189 - 167571 != -103381)
													{
														this.CreatePaperBug("PaperBug2", 21);
														if (102477 - 192985 != -90507)
														{
															this.CreatePaperBug("PaperBug1", 22);
															if (251331 - 49125 == 202206)
															{
																break;
															}
														}
													}
												}
												else if (num5 == 5)
												{
													if (142030 - 259941 == -117911)
													{
														this.CreatePaperBug("PaperBug1", 31);
														if (114203 - 300924 == -186721)
														{
															this.CreatePaperBug("PaperBug1", 32);
															if (21285 - 493341 == -472056)
															{
																this.CreatePaperBug("PaperBug1", 33);
																if (166702 - 493517 != -326814)
																{
																	break;
																}
															}
														}
													}
												}
												else if (num5 == 6)
												{
													if (63993 - 444820 == -380827)
													{
														this.CreatePaperBug("PaperBug1", 31);
														if (27583 - 594224 == -566641)
														{
															this.CreatePaperBug("PaperBug1", 32);
															if (58004 - 250495 != -192490)
															{
																this.CreatePaperBug("PaperBug1", 33);
																if (228699 - 20957 == 207742)
																{
																	break;
																}
															}
														}
													}
												}
												else if (num5 == 7)
												{
													if (173696 - 52296 != 121401)
													{
														this.CreatePaperBug("PaperBug1", 41);
														if (234203 - 351759 == -117556)
														{
															this.CreatePaperBug("PaperBug1", 42);
															if (147007 - 259385 != -112377)
															{
																this.CreatePaperBug("PaperBug2", 43);
																if (257040 - 130537 != 126504)
																{
																	break;
																}
															}
														}
													}
												}
												else if (num5 == 8)
												{
													if (21796 - 268887 != -247090)
													{
														this.CreatePaperBug("PaperBug1", 41);
														if (204082 - 263564 == -59482)
														{
															this.CreatePaperBug("PaperBug2", 42);
															if (186398 - 10565 == 175833)
															{
																this.CreatePaperBug("PaperBug1", 43);
																if (20743 - 576194 == -555451)
																{
																	break;
																}
															}
														}
													}
												}
												else if (num5 == 9)
												{
													if (94588 - 515303 == -420715)
													{
														this.CreatePaperBug("PaperBug1", 51);
														if (200455 - 155001 == 45454)
														{
															this.CreatePaperBug("PaperBug1", 52);
															if (157573 - 218314 != -60740)
															{
																this.CreatePaperBug("PaperBug2", 53);
																if (189052 - 347123 != -158070)
																{
																	this.CreatePaperBug("PaperBug1", 54);
																	if (229076 - 590055 == -360979)
																	{
																		break;
																	}
																}
															}
														}
													}
												}
												else if (num5 == 10)
												{
													if (47418 - 146412 == -98994)
													{
														this.CreatePaperBug("PaperBug1", 51);
														if (84888 - 503629 == -418741)
														{
															this.CreatePaperBug("PaperBug2", 52);
															if (285569 - 139073 != 146497)
															{
																this.CreatePaperBug("PaperBug1", 53);
																if (32233 - 350907 == -318674)
																{
																	this.CreatePaperBug("PaperBug2", 54);
																	if (287848 - 536640 != -248791)
																	{
																		break;
																	}
																}
															}
														}
													}
												}
												else if (num5 == 11)
												{
													if (293310 - 13905 == 279405)
													{
														this.CreatePaperBug("PaperBug1", 61);
														if (199807 - 11742 != 188066)
														{
															this.CreatePaperBug("PaperBug1", 62);
															if (225055 - 257966 != -32910)
															{
																this.CreatePaperBug("PaperBug1", 63);
																if (78426 - 534211 != -455784)
																{
																	this.CreatePaperBug("PaperBug2", 64);
																	if (186928 - 434479 != -247550)
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
													if (num5 != 12)
													{
														break;
													}
													if (196678 - 78380 != 118299)
													{
														this.CreatePaperBug("PaperBug2", 61);
														if (224647 - 416120 == -191473)
														{
															this.CreatePaperBug("PaperBug1", 62);
															if (10752 - 78357 != -67604)
															{
																this.CreatePaperBug("PaperBug2", 63);
																if (200900 - 463471 == -262571)
																{
																	this.CreatePaperBug("PaperBug2", 64);
																	if (189575 - 265927 == -76352)
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
									if (num4 != 8042)
									{
										break;
									}
									if (122438 - 531134 != -408695)
									{
										this.aL8czgOA3aG++;
										if (253868 - 248117 != 5752)
										{
											this.SendMessage("newGameMessage", "Mission Objective: PaperBug Eliminated:" + this.aL8czgOA3aG + "/34");
											if (269346 - 97383 != 171964)
											{
												Chat.SubmitChat("none", "PaperBug Eliminated:" + this.aL8czgOA3aG + "/34", eChatType.system, eChatMode.system);
												if (144646 - 81506 == 63140)
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

	// Token: 0x06008D24 RID: 36132 RVA: 0x01138294 File Offset: 0x01136494
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M804_LibraryElevator.$onGameComplete$40791(data, this).GetEnumerator();
	}

	// Token: 0x06008D25 RID: 36133 RVA: 0x011382A4 File Offset: 0x011364A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M804_LibraryElevator.$StartEvent$40801(this).GetEnumerator();
	}

	// Token: 0x06008D26 RID: 36134 RVA: 0x011382B4 File Offset: 0x011364B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (291932 - 323447 != -31515)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (12643 - 73836 == -61193)
			{
				Time.timeScale = 1f;
				if (140816 - 141204 == -388)
				{
					this.AXHczbrFTV3 = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (126226 - 217733 != -91506)
					{
						Hashtable customOpParameters = new Hashtable();
						if (107937 - 307085 == -199148)
						{
							this.fBCczxGmSmh.OpCustom(52, customOpParameters, true);
							if (30278 - 373497 == -343219)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008D27 RID: 36135 RVA: 0x011383B8 File Offset: 0x011365B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (167011 - 284854 != -117843)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (36679 - 415477 != -378797)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (252038 - 408530 == -156492)
				{
					Game.mGameState = eGameState.Setup;
					if (194927 - 536532 != -341604)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008D28 RID: 36136 RVA: 0x0113845C File Offset: 0x0113665C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (208150 - 154904 != 53247)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (246849 - 365380 != -118530)
			{
				if (num == PlayerData.UID)
				{
					if (27324 - 532014 != -504689)
					{
						this.SetupActors();
						if (92640 - 490197 != -397556)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (69349 - 60713 == 8636)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008D29 RID: 36137 RVA: 0x0113852C File Offset: 0x0113672C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (284146 - 117377 != 166769)
		{
		}
		for (;;)
		{
			IL_129:
			Debug.Log("Creating Actors");
			if (48731 - 67499 == -18768)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (204947 - 100401 == 104546)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (210934 - 2301 != 208634)
						{
							int i = 0;
							if (93556 - 18410 == 75146)
							{
								CharacterControl[] array2 = array;
								if (86452 - 401109 == -314657)
								{
									int length = array2.Length;
									if (53329 - 177357 != -124027)
									{
										while (i < length)
										{
											string type = array2[i].Type;
											if (139873 - 176539 != -36666)
											{
												goto IL_129;
											}
											if (type == "PaperBug1")
											{
												goto IL_DE;
											}
											if (262623 - 168817 == 93807)
											{
												goto IL_129;
											}
											if (type == "PaperBug2")
											{
												if (216462 - 333767 != -117305)
												{
													goto IL_129;
												}
												goto IL_DE;
											}
											IL_46:
											UnityEngine.Object.Destroy(array2[i].gameObject);
											if (245629 - 531411 == -285781)
											{
												goto IL_129;
											}
											this.h34czaCKnCg++;
											if (200614 - 409837 == -209222)
											{
												goto IL_129;
											}
											i++;
											if (277703 - 451339 != -173636)
											{
												goto IL_129;
											}
											continue;
											IL_DE:
											if (!array2[i].isChild)
											{
												if (106187 - 199741 != -93554)
												{
													goto IL_129;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (116208 - 522086 != -405878)
												{
													goto IL_129;
												}
											}
											goto IL_46;
										}
										if (215625 - 373501 == -157876)
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
						if (60903 - 327146 == -266243)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008D2A RID: 36138 RVA: 0x011387F4 File Offset: 0x011369F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (30500 - 380582 != -350081)
		{
		}
		for (;;)
		{
			IL_38:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (274615 - 465085 == -190470)
			{
				int i = 0;
				if (23438 - 176681 != -153242)
				{
					CharacterControl[] array2 = array;
					if (235139 - 518680 == -283541)
					{
						int length = array2.Length;
						if (107475 - 387108 == -279633)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (138685 - 371908 == -233222)
								{
									goto IL_38;
								}
								i++;
								if (221195 - 22973 == 198223)
								{
									goto IL_38;
								}
							}
							if (140557 - 479058 == -338501)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008D2B RID: 36139 RVA: 0x01138924 File Offset: 0x01136B24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (107802 - 67803 != 40000)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (174098 - 76480 != 97619)
			{
				Game.mGameState = eGameState.Ready;
				if (254863 - 484044 != -229180)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (139851 - 270157 == -130306)
					{
						if (183115 - 215786 == -32671)
						{
							GameObject gameObject = null;
							if (232857 - 176861 != 55997)
							{
								if (playerSlot < 1)
								{
									goto IL_1E6;
								}
								if (271743 - 305959 != -34216)
								{
									continue;
								}
								if (playerSlot > 6)
								{
									goto IL_1E6;
								}
								if (58993 - 480671 == -421677)
								{
									continue;
								}
								GameObject gameObject2 = GameObject.Find("StartPoint" + playerSlot);
								if (5534 - 329220 == -323685)
								{
									continue;
								}
								gameObject = GameObject.Find("StartCamera" + playerSlot);
								if (160684 - 160377 != 307)
								{
									continue;
								}
								IL_197:
								if (gameObject2)
								{
									if (58216 - 477459 == -419242)
									{
										continue;
									}
									Vector3 spawnPos = global::Math.getSpawnPos(gameObject2.transform.position);
									if (63901 - 252112 == -188210)
									{
										continue;
									}
									if (spawnPos != Vector3.zero)
									{
										if (245598 - 516721 == -271122)
										{
											continue;
										}
										this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject2.transform.forward);
										if (218737 - 574798 == -356060)
										{
											continue;
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject2.transform.position, gameObject2.transform.forward);
										if (224381 - 140400 != 83981)
										{
											continue;
										}
									}
								}
								if (!gameObject)
								{
									break;
								}
								if (110057 - 84516 == 25542)
								{
									continue;
								}
								this.transform.position = gameObject.transform.position;
								if (46827 - 95416 == -48588)
								{
									continue;
								}
								this.transform.rotation = gameObject.transform.rotation;
								if (154046 - 22289 != 131758)
								{
									break;
								}
								continue;
								IL_1E6:
								gameObject2 = GameObject.Find("StartPoint1");
								if (120793 - 72844 != 47950)
								{
									goto IL_197;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008D2C RID: 36140 RVA: 0x01138C48 File Offset: 0x01136E48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (3320 - 588851 != -585531)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (82835 - 560677 == -477842)
			{
				Game.mGameState = eGameState.Start;
				if (166814 - 425501 == -258687)
				{
					Game.mGameTime = Time.time;
					if (276661 - 402108 == -125447)
					{
						this.StartCoroutine_Auto(this.StartEvent());
						if (221303 - 593689 != -372385)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008D2D RID: 36141 RVA: 0x01138D10 File Offset: 0x01136F10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06008D2E RID: 36142 RVA: 0x01138D14 File Offset: 0x01136F14
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (243641 - 361834 != -118193)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (98096 - 523406 == -425310)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (182547 - 232193 != -49645)
				{
					hashtable.Add(43, PlayerData.UID);
					if (46285 - 330624 != -284338)
					{
						hashtable.Add(73, nType);
						if (266182 - 143315 != 122868)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (244699 - 54816 != 189884)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (188210 - 24010 != 164201)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (45207 - 218911 != -173703)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (17489 - 425408 == -407919)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (109677 - 129054 == -19377)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (131345 - 354409 == -223064)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (14444 - 513524 != -499079)
													{
														this.fBCczxGmSmh.OpCustom(63, hashtable, true);
														if (17208 - 357671 == -340463)
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

	// Token: 0x06008D2F RID: 36143 RVA: 0x01138FF8 File Offset: 0x011371F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (140192 - 460866 != -320673)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (272772 - 345576 != -72803)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (158885 - 184770 != -25884)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (194516 - 326376 != -131859)
						{
							if (this.h34czaCKnCg <= 0)
							{
								break;
							}
							if (68472 - 288935 != -220462)
							{
								this.h34czaCKnCg--;
								if (78032 - 22853 == 55179)
								{
									if (this.h34czaCKnCg != 0)
									{
										break;
									}
									if (262944 - 55129 != 207816)
									{
										Game.setGameState(eGameState.Ready);
										if (229029 - 84380 != 144650)
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
						if (267881 - 389245 != -121363)
						{
							gameObject.SendMessage("createSpecialEffect", 1);
							if (50294 - 270272 == -219978)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008D30 RID: 36144 RVA: 0x01139188 File Offset: 0x01137388
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06008D31 RID: 36145 RVA: 0x0113919C File Offset: 0x0113739C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (67826 - 368806 != -300980)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (102971 - 245892 != -142920)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (64457 - 345621 != -281163)
				{
					if (!characterControl)
					{
						break;
					}
					if (22044 - 79862 == -57818)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (259789 - 420089 != -160299)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (7251 - 386410 != -379158)
							{
								string type = characterControl.Type;
								if (44140 - 381195 == -337055)
								{
									if (type == "PaperBug1")
									{
										if (279615 - 373785 == -94170)
										{
											Game.sendMissionEvent(8042, 1);
											if (123291 - 188105 != -64813)
											{
												break;
											}
										}
									}
									else
									{
										if (!(type == "PaperBug2"))
										{
											break;
										}
										if (169659 - 194450 != -24790)
										{
											Game.sendMissionEvent(8042, 2);
											if (203318 - 19864 != 183455)
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

	// Token: 0x06008D32 RID: 36146 RVA: 0x01139368 File Offset: 0x01137568
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (230265 - 130032 != 100234)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (254428 - 558685 != -304256)
			{
				hashtable.Add(71, CID);
				if (229703 - 588798 != -359094)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (260344 - 17519 == 242825)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (119499 - 568119 != -448619)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (83338 - 538120 != -454781)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (1522 - 402336 != -400813)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (207754 - 501511 == -293757)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (199979 - 222219 != -22239)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (34024 - 310427 != -276402)
											{
												this.fBCczxGmSmh.OpCustom(61, hashtable, true);
												if (195002 - 593454 != -398451)
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

	// Token: 0x06008D33 RID: 36147 RVA: 0x011395F4 File Offset: 0x011377F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (199991 - 518909 != -318918)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (207665 - 217690 == -10025)
			{
				if (!gameObject)
				{
					break;
				}
				if (122973 - 263559 == -140586)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (103800 - 185043 != -81242)
					{
						playerCameraControl.target = gameObject;
						if (74280 - 586197 == -511917)
						{
							this.StartGame();
							if (255798 - 570082 != -314283)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008D34 RID: 36148 RVA: 0x011396E4 File Offset: 0x011378E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (85564 - 117095 != -31530)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (46040 - 264696 == -218656)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (77355 - 95714 == -18359)
				{
					gameGui.ResetTeamBar();
					if (222809 - 561833 != -339023)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008D35 RID: 36149 RVA: 0x01139790 File Offset: 0x01137990
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M804_LibraryElevator.$onDeadPlayer$40813(this).GetEnumerator();
	}

	// Token: 0x06008D36 RID: 36150 RVA: 0x011397A0 File Offset: 0x011379A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (99916 - 460093 != -360176)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (275625 - 392249 == -116624)
			{
				this.ibFczTesLIy.target = Game.mPlayer;
				if (209624 - 454922 != -245297)
				{
					this.ibFczTesLIy.enabled = true;
					if (39201 - 365528 == -326327)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (100585 - 546813 != -446228)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (207079 - 185075 != 22004)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (122965 - 269720 == -146755)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (234928 - 496261 == -261333)
							{
								if (!gameGui)
								{
									break;
								}
								if (67410 - 129917 != -62506)
								{
									gameGui.enabled = true;
									if (185291 - 319751 != -134459)
									{
										gameGui.closeDeadMenu();
										if (123369 - 64943 == 58426)
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

	// Token: 0x06008D37 RID: 36151 RVA: 0x0113994C File Offset: 0x01137B4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (143605 - 206127 != -62521)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (55134 - 32270 == 22864)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (10218 - 162664 == -152446)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (292385 - 116592 != 175794)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008D38 RID: 36152 RVA: 0x01139A10 File Offset: 0x01137C10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06008D39 RID: 36153 RVA: 0x01139A3C File Offset: 0x01137C3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (160518 - 355815 != -195296)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (241444 - 322210 == -80766)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (87326 - 467015 == -379689)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (114294 - 32453 == 81841)
					{
						Hashtable hashtable = new Hashtable();
						if (82996 - 60783 == 22213)
						{
							hashtable.Add(43, PlayerData.UID);
							if (132680 - 375662 == -242982)
							{
								hashtable.Add(71, nCID);
								if (200789 - 71246 == 129543)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (123258 - 287648 == -164390)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (71464 - 93167 != -21702)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (91202 - 403988 == -312786)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (231075 - 49781 == 181294)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (12848 - 424626 != -411777)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (185252 - 80211 != 105042)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (237618 - 594720 == -357102)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (215300 - 208786 != 6515)
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

	// Token: 0x06008D3A RID: 36154 RVA: 0x01139D5C File Offset: 0x01137F5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M804_LibraryElevator.$onChangePlayer$40819(data, this).GetEnumerator();
	}

	// Token: 0x06008D3B RID: 36155 RVA: 0x01139D6C File Offset: 0x01137F6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M804_LibraryElevator.$ReturnToTown$40826(this).GetEnumerator();
	}

	// Token: 0x06008D3C RID: 36156 RVA: 0x01139D7C File Offset: 0x01137F7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M804_LibraryElevator.$ReturnToGuild$40831(this).GetEnumerator();
	}

	// Token: 0x06008D3D RID: 36157 RVA: 0x01139D8C File Offset: 0x01137F8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M804_LibraryElevator.$ReturnToCamp$40835(this).GetEnumerator();
	}

	// Token: 0x06008D3E RID: 36158 RVA: 0x01139D9C File Offset: 0x01137F9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (225469 - 335777 != -110308)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (37339 - 551720 == -514381)
			{
				Hashtable hashtable = new Hashtable();
				if (204608 - 203597 != 1012)
				{
					hashtable.Add(43, PlayerData.UID);
					if (122413 - 32476 == 89937)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (145412 - 432004 == -286592)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008D3F RID: 36159 RVA: 0x01139E74 File Offset: 0x01138074
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06008D40 RID: 36160 RVA: 0x01139E88 File Offset: 0x01138088
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (66630 - 71054 != -4424)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (243059 - 100006 == 143053)
			{
				Hashtable hashtable = new Hashtable();
				if (232610 - 154585 == 78025)
				{
					if (Game.mNextGameCode == 30)
					{
						if (231135 - 564802 == -333666)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (59852 - 47931 == 11922)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (142162 - 520264 == -378101)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (96456 - 197750 == -101293)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (256659 - 567970 == -311310)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (40106 - 509136 == -469029)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (179132 - 265927 != -86795)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (159631 - 566724 == -407092)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (125985 - 218055 == -92069)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (108527 - 134200 != -25673)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (38684 - 367271 == -328586)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (139121 - 158747 != -19626)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (55361 - 534781 == -479419)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (46654 - 584014 == -537359)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (102196 - 28727 == 73470)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (269135 - 64543 != 204592)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (53452 - 311855 == -258402)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (227673 - 19527 != 208146)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (215568 - 177329 != 38239)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (79368 - 248129 != -168761)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (104000 - 474604 == -370603)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (1923 - 379287 == -377363)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (37613 - 311 != 37302)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (62043 - 496607 == -434563)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (161937 - 119804 != 42133)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (260658 - 99851 != 160807)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (193799 - 55360 != 138439)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (227657 - 243494 != -15837)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (268536 - 7735 == 260801)
					{
						this.fBCczxGmSmh.OpCustom(42, hashtable, true);
						if (144424 - 399622 != -255197)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008D41 RID: 36161 RVA: 0x0113A43C File Offset: 0x0113863C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06008D42 RID: 36162 RVA: 0x0113A44C File Offset: 0x0113864C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06008D43 RID: 36163 RVA: 0x0113A450 File Offset: 0x01138650
	internal static bool rlnUdTVTnZUJlZmWPeI7()
	{
		return true;
	}

	// Token: 0x06008D44 RID: 36164 RVA: 0x0113A454 File Offset: 0x01138654
	internal static bool CD6q0gVT6fxhtkNRQyk2()
	{
		return false;
	}

	// Token: 0x040086B1 RID: 34481
	private LitePeer fBCczxGmSmh;

	// Token: 0x040086B2 RID: 34482
	private PlayerCameraControl ibFczTesLIy;

	// Token: 0x040086B3 RID: 34483
	private float yneczYv2nA6;

	// Token: 0x040086B4 RID: 34484
	private int V3Acz35Zae1;

	// Token: 0x040086B5 RID: 34485
	private Texture AXHczbrFTV3;

	// Token: 0x040086B6 RID: 34486
	private int xe2czdXlqeY;

	// Token: 0x040086B7 RID: 34487
	private int aL8czgOA3aG;

	// Token: 0x040086B8 RID: 34488
	public AudioClip libraryElevator_fx;

	// Token: 0x040086B9 RID: 34489
	private int h34czaCKnCg;

	// Token: 0x020017B0 RID: 6064
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$40791 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008D45 RID: 36165 RVA: 0x0113A458 File Offset: 0x01138658
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$40791(Hashtable data, M804_LibraryElevator self_)
		{
			if (9826 - 486713 != -476887)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (138285 - 250358 != -112072)
				{
					base..ctor();
					if (176020 - 540574 == -364554)
					{
						this.$data$40799 = data;
						if (117910 - 187820 != -69909)
						{
							this.$self_$40800 = self_;
							if (265064 - 245559 == 19505)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008D46 RID: 36166 RVA: 0x0113A514 File Offset: 0x01138714
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M804_LibraryElevator.$onGameComplete$40791.$(this.$data$40799, this.$self_$40800);
		}

		// Token: 0x06008D47 RID: 36167 RVA: 0x0113A528 File Offset: 0x01138728
		internal static bool SYWYFdVTiDHjfGim8qB3()
		{
			return true;
		}

		// Token: 0x06008D48 RID: 36168 RVA: 0x0113A52C File Offset: 0x0113872C
		internal static bool YmmhjgVTKTSxR4MwoAh9()
		{
			return false;
		}

		// Token: 0x040086BA RID: 34490
		internal Hashtable $data$40799;

		// Token: 0x040086BB RID: 34491
		internal M804_LibraryElevator $self_$40800;

		// Token: 0x020017B1 RID: 6065
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008D49 RID: 36169 RVA: 0x0113A530 File Offset: 0x01138730
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M804_LibraryElevator self_)
			{
				if (160017 - 160761 != -743)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (282308 - 61696 != 220613)
					{
						base..ctor();
						if (150796 - 175682 == -24886)
						{
							this.$data$40797 = data;
							if (123649 - 314128 == -190479)
							{
								this.$self_$40798 = self_;
								if (211452 - 450910 != -239457)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008D4A RID: 36170 RVA: 0x0113A5EC File Offset: 0x011387EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (172727 - 469715 != -296987)
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
						this.$mCompleteGui$40793 = (CompleteGui)this.$self_$40798.GetComponent(typeof(CompleteGui));
						if (138121 - 594567 == -456445)
						{
							continue;
						}
						this.$mCompleteGui$40793.Init();
						if (136357 - 547184 == -410826)
						{
							continue;
						}
						this.$mCompleteGui$40793.readData(this.$data$40797);
						if (202756 - 15597 == 187160)
						{
							continue;
						}
						if (this.$result$40792 == 1)
						{
							if (65802 - 420611 == -354808)
							{
								continue;
							}
							this.$mCompleteGui$40793.displayResult(eCompleteType.Success);
							if (244960 - 521554 != -276594)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$40793.displayResult(eCompleteType.Failed);
							if (77113 - 500134 != -423021)
							{
								continue;
							}
						}
						this.$mGameGui$40794 = (GameGui)this.$self_$40798.GetComponent(typeof(GameGui));
						if (192962 - 322529 == -129566)
						{
							continue;
						}
						this.$mStoryGui$40795 = (StoryGui)this.$self_$40798.GetComponent(typeof(StoryGui));
						if (73610 - 492243 == -418632)
						{
							continue;
						}
						this.$mChangeGui$40796 = (ChangeGui)this.$self_$40798.GetComponent(typeof(ChangeGui));
						if (163782 - 129979 != 33803)
						{
							continue;
						}
						if (this.$mGameGui$40794)
						{
							if (197198 - 126427 != 70771)
							{
								continue;
							}
							this.$mGameGui$40794.close();
							if (176186 - 22531 != 153655)
							{
								continue;
							}
						}
						if (this.$mStoryGui$40795)
						{
							if (286714 - 392961 != -106247)
							{
								continue;
							}
							this.$mStoryGui$40795.close();
							if (40646 - 360571 == -319924)
							{
								continue;
							}
						}
						if (this.$mChangeGui$40796)
						{
							if (115932 - 139807 == -23874)
							{
								continue;
							}
							this.$mChangeGui$40796.disable();
							if (255265 - 499962 == -244696)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (59736 - 279961 != -220225)
						{
							continue;
						}
						goto IL_3DB;
					default:
						if (174284 - 75682 != 98602)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$40797[31]);
					if (260781 - 308614 == -47833)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (157607 - 68942 == 88665)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (253746 - 413360 == -159614)
							{
								this.$result$40792 = RuntimeServices.UnboxInt32(this.$data$40797[31]);
								if (243497 - 100712 == 142785)
								{
									goto IL_2E0;
								}
							}
						}
					}
				}
				goto IL_3DB;
				IL_2E0:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_3DB:
				return false;
			}

			// Token: 0x06008D4B RID: 36171 RVA: 0x0113A9E8 File Offset: 0x01138BE8
			internal static bool nVuaGNVTdgDknn8dKlt3()
			{
				return true;
			}

			// Token: 0x06008D4C RID: 36172 RVA: 0x0113A9EC File Offset: 0x01138BEC
			internal static bool J6X68YVTJEXZg8aFHfvb()
			{
				return false;
			}

			// Token: 0x040086BC RID: 34492
			internal int $result$40792;

			// Token: 0x040086BD RID: 34493
			internal CompleteGui $mCompleteGui$40793;

			// Token: 0x040086BE RID: 34494
			internal GameGui $mGameGui$40794;

			// Token: 0x040086BF RID: 34495
			internal StoryGui $mStoryGui$40795;

			// Token: 0x040086C0 RID: 34496
			internal ChangeGui $mChangeGui$40796;

			// Token: 0x040086C1 RID: 34497
			internal Hashtable $data$40797;

			// Token: 0x040086C2 RID: 34498
			internal M804_LibraryElevator $self_$40798;
		}
	}

	// Token: 0x020017B2 RID: 6066
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$40801 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008D4D RID: 36173 RVA: 0x0113A9F0 File Offset: 0x01138BF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$40801(M804_LibraryElevator self_)
		{
			if (292147 - 132438 != 159710)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (110279 - 457268 == -346989)
				{
					base..ctor();
					if (45003 - 410263 == -365260)
					{
						this.$self_$40812 = self_;
						if (149971 - 231070 == -81099)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008D4E RID: 36174 RVA: 0x0113AA88 File Offset: 0x01138C88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M804_LibraryElevator.$StartEvent$40801.$(this.$self_$40812);
		}

		// Token: 0x06008D4F RID: 36175 RVA: 0x0113AA98 File Offset: 0x01138C98
		internal static bool axMCWdVTD8RfKOy6AhaM()
		{
			return true;
		}

		// Token: 0x06008D50 RID: 36176 RVA: 0x0113AA9C File Offset: 0x01138C9C
		internal static bool V0M16wVTvZCAMts9YcIE()
		{
			return false;
		}

		// Token: 0x040086C3 RID: 34499
		internal M804_LibraryElevator $self_$40812;

		// Token: 0x020017B3 RID: 6067
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008D51 RID: 36177 RVA: 0x0113AAA0 File Offset: 0x01138CA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M804_LibraryElevator self_)
			{
				if (2831 - 366030 != -363199)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (293464 - 400261 != -106796)
					{
						base..ctor();
						if (143209 - 533324 != -390114)
						{
							this.$self_$40811 = self_;
							if (56214 - 563462 != -507247)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008D52 RID: 36178 RVA: 0x0113AB38 File Offset: 0x01138D38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (126061 - 315750 != -189689)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_EED;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (230500 - 434479 != -203978)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							if (!this.$mEventCamera2$40808)
							{
								goto IL_71D;
							}
							if (3361 - 173668 != -170307)
							{
								continue;
							}
							this.$self_$40811.ibFczTesLIy.enabled = true;
							if (94039 - 377743 != -283704)
							{
								continue;
							}
							this.$self_$40811.ibFczTesLIy.setSpecialTarget(this.$mEventCamera2$40808, 2f);
							if (237780 - 225945 != 11836)
							{
								goto Block_66;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (223535 - 177870 != 45665)
							{
								continue;
							}
							goto IL_BFA;
						}
						else
						{
							this.$nMessage$40810 = string.Empty;
							if (296781 - 158616 == 138166)
							{
								continue;
							}
							this.$mStoryGui$40805.startStoryMessage("Walrus", "Reggu", eTalkType.friend);
							if (24991 - 560480 != -535488)
							{
								goto Block_35;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (100009 - 512613 != -412604)
							{
								continue;
							}
							goto IL_6EC;
						}
						else
						{
							this.$nMessage$40810 = Language.getMessage("M804_LibraryElevator", 101);
							if (6598 - 549969 == -543370)
							{
								continue;
							}
							this.$mStoryGui$40805.newStoryMessage("Walrus", "Reggu", this.$nMessage$40810, eTalkType.friend);
							if (100777 - 212565 != -111788)
							{
								continue;
							}
							if (!this.$mWalrus$40802)
							{
								goto IL_C24;
							}
							if (193347 - 25510 != 167837)
							{
								continue;
							}
							this.$mWalrus$40802.animation.CrossFade("talk");
							if (154778 - 477735 != -322957)
							{
								continue;
							}
							goto IL_C24;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (169100 - 327848 != -158748)
							{
								continue;
							}
							goto IL_D26;
						}
						else
						{
							this.$nMessage$40810 = Language.getMessage("M804_LibraryElevator", 102);
							if (185190 - 251885 != -66695)
							{
								continue;
							}
							this.$mStoryGui$40805.newStoryMessage("Walrus", "Reggu", this.$nMessage$40810, eTalkType.friend);
							if (16574 - 400001 != -383427)
							{
								continue;
							}
							if (!this.$mWalrus$40802)
							{
								goto IL_193;
							}
							if (117227 - 179199 == -61971)
							{
								continue;
							}
							this.$mWalrus$40802.animation.CrossFade("root");
							if (46696 - 13924 != 32772)
							{
								continue;
							}
							goto IL_193;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (20465 - 566072 != -545607)
							{
								continue;
							}
							goto IL_68C;
						}
						else
						{
							this.$nMessage$40810 = Language.getMessage("M804_LibraryElevator", 103);
							if (84087 - 525227 == -441139)
							{
								continue;
							}
							this.$mStoryGui$40805.newStoryMessage("Walrus", "Reggu", this.$nMessage$40810, eTalkType.friend);
							if (36399 - 187511 == -151111)
							{
								continue;
							}
							if (!this.$mWalrus$40802)
							{
								goto IL_651;
							}
							if (29158 - 288553 == -259394)
							{
								continue;
							}
							this.$mWalrus$40802.animation.CrossFade("talk");
							if (134089 - 238541 != -104451)
							{
								goto Block_82;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (211432 - 385123 != -173691)
							{
								continue;
							}
							goto IL_DB8;
						}
						else
						{
							this.$nMessage$40810 = Language.getMessage("M804_LibraryElevator", 104);
							if (60941 - 529367 != -468426)
							{
								continue;
							}
							this.$mStoryGui$40805.newStoryMessage("Reindeer", "Reindeer", this.$nMessage$40810, eTalkType.friend);
							if (113477 - 196023 != -82546)
							{
								continue;
							}
							if (this.$mWalrus$40802)
							{
								if (97696 - 374773 == -277076)
								{
									continue;
								}
								this.$mWalrus$40802.animation.CrossFade("root");
								if (198219 - 25530 != 172689)
								{
									continue;
								}
							}
							if (!this.$mReindeer$40803)
							{
								goto IL_91F;
							}
							if (99578 - 491389 != -391811)
							{
								continue;
							}
							this.$mReindeer$40803.animation.CrossFade("talk");
							if (105421 - 468439 != -363018)
							{
								continue;
							}
							goto IL_91F;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (80983 - 416403 != -335419)
							{
								goto Block_64;
							}
							continue;
						}
						else
						{
							this.$self_$40811.ibFczTesLIy.enabled = false;
							if (162296 - 53126 != 109170)
							{
								continue;
							}
							this.$self_$40811.SendMessage("alignToObject", "EventCamera3");
							if (7023 - 297996 != -290973)
							{
								continue;
							}
							this.$nMessage$40810 = Language.getMessage("M804_LibraryElevator", 105);
							if (265486 - 49669 == 215818)
							{
								continue;
							}
							this.$mStoryGui$40805.newStoryMessage("Walrus", "Reggu", this.$nMessage$40810, eTalkType.friend);
							if (26251 - 352990 == -326738)
							{
								continue;
							}
							if (!this.$mReindeer$40803)
							{
								goto IL_A16;
							}
							if (36442 - 142160 == -105717)
							{
								continue;
							}
							this.$mReindeer$40803.animation.CrossFade("root");
							if (149886 - 389134 != -239247)
							{
								goto Block_41;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.Start)
						{
							if (261838 - 359485 != -97647)
							{
								continue;
							}
							goto IL_12A;
						}
						else
						{
							if (!this.$mWalrus$40802)
							{
								goto IL_CB3;
							}
							if (287004 - 204267 == 82738)
							{
								continue;
							}
							this.$mWalrus$40802.animation.CrossFade("cast1");
							if (162237 - 130722 != 31515)
							{
								continue;
							}
							goto IL_CB3;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.Start)
						{
							if (163926 - 325875 != -161948)
							{
								goto Block_90;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$40805.blank();
							if (110144 - 463724 != -353580)
							{
								continue;
							}
							if (this.$mWalrus$40802)
							{
								if (178407 - 112256 == 66152)
								{
									continue;
								}
								this.$mWalrus$40802.animation.CrossFade("root");
								if (56121 - 213557 == -157435)
								{
									continue;
								}
							}
							if (this.$mLibraryElevator$40806)
							{
								if (32828 - 105317 == -72488)
								{
									continue;
								}
								this.$mLibraryElevator$40806.animation.Play();
								if (148190 - 285233 != -137043)
								{
									continue;
								}
							}
							if (this.$self_$40811.libraryElevator_fx)
							{
								if (84166 - 373716 == -289549)
								{
									continue;
								}
								this.$self_$40811.audio.PlayOneShot(this.$self_$40811.libraryElevator_fx);
								if (66076 - 549473 == -483396)
								{
									continue;
								}
							}
							this.$self_$40811.ibFczTesLIy.enabled = true;
							if (22668 - 148477 != -125809)
							{
								continue;
							}
							Camera.main.SendMessage("AddCamereShake", 1);
							if (48998 - 589745 != -540746)
							{
								goto Block_58;
							}
							continue;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.Start)
						{
							if (61254 - 233730 != -172475)
							{
								goto Block_101;
							}
							continue;
						}
						else
						{
							this.$nMessage$40810 = Language.getMessage("M804_LibraryElevator", 106);
							if (183444 - 309128 == -125683)
							{
								continue;
							}
							this.$mStoryGui$40805.newStoryMessage("Walrus", "Reggu", this.$nMessage$40810, eTalkType.friend);
							if (264 - 480789 == -480524)
							{
								continue;
							}
							if (!this.$mWalrus$40802)
							{
								goto IL_82A;
							}
							if (46730 - 553102 == -506371)
							{
								continue;
							}
							this.$mWalrus$40802.animation.CrossFade("root");
							if (237346 - 561723 != -324376)
							{
								goto Block_39;
							}
							continue;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.Start)
						{
							if (290403 - 275343 != 15060)
							{
								continue;
							}
							goto IL_BA1;
						}
						else
						{
							this.$mStoryGui$40805.close();
							if (265240 - 246948 != 18292)
							{
								continue;
							}
							this.$self_$40811.ibFczTesLIy.enabled = true;
							if (128576 - 136046 != -7470)
							{
								continue;
							}
							this.$self_$40811.ibFczTesLIy.specialTarget = null;
							if (298864 - 107755 != 191109)
							{
								continue;
							}
							goto IL_283;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.Start)
						{
							if (152345 - 157505 != -5159)
							{
								goto Block_20;
							}
							continue;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (215300 - 126646 != 88654)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (159019 - 581693 != -422674)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (288127 - 528190 != -240063)
							{
								continue;
							}
							Time.timeScale = 1f;
							if (138094 - 267764 != -129670)
							{
								continue;
							}
							this.$mGameGui$40804.enabled = true;
							if (30699 - 505940 == -475240)
							{
								continue;
							}
							this.$mGameGui$40804.enableSkill(false);
							if (155684 - 28541 == 127144)
							{
								continue;
							}
							this.YieldDefault(1);
							if (101 - 171939 != -171837)
							{
								goto Block_80;
							}
							continue;
						}
						break;
					default:
						if (202846 - 198987 != 3859)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Event");
					if (155524 - 552495 != -396970)
					{
						this.$mWalrus$40802 = GameObject.Find("Walrus");
						if (175738 - 391660 == -215922)
						{
							this.$mReindeer$40803 = GameObject.Find("Reindeer");
							if (95649 - 263114 == -167465)
							{
								this.$mGameGui$40804 = (GameGui)this.$self_$40811.GetComponent(typeof(GameGui));
								if (105245 - 597337 != -492091)
								{
									this.$mStoryGui$40805 = (StoryGui)this.$self_$40811.GetComponent(typeof(StoryGui));
									if (162887 - 400731 == -237844)
									{
										this.$mLibraryElevator$40806 = GameObject.Find("LibraryElevator");
										if (101367 - 92259 == 9108)
										{
											this.$mEventCamera1$40807 = GameObject.Find("EventCamera1");
											if (156543 - 496339 != -339795)
											{
												this.$mEventCamera2$40808 = GameObject.Find("EventCamera2");
												if (131172 - 153523 != -22350)
												{
													this.$mEventCamera3$40809 = GameObject.Find("EventCamera3");
													if (52733 - 138494 == -85761)
													{
														this.$self_$40811.ibFczTesLIy.enabled = false;
														if (21014 - 459125 != -438110)
														{
															this.$self_$40811.SendMessage("alignToObject", "EventCamera1");
															if (155173 - 529382 != -374208)
															{
																this.$self_$40811.SendMessage("fadeIn");
																if (172402 - 166447 != 5956)
																{
																	goto Block_99;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_12A:
				goto IL_EED;
				IL_193:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_283:
				return this.Yield(13, new WaitForSeconds(0.5f));
				Block_20:
				Block_28:
				goto IL_EED;
				Block_35:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_39:
				goto IL_82A;
				Block_41:
				goto IL_A16;
				IL_651:
				return this.Yield(7, new WaitForSeconds(3f));
				IL_68C:
				IL_6EC:
				goto IL_EED;
				IL_71D:
				return this.Yield(3, new WaitForSeconds(2f));
				IL_82A:
				return this.Yield(12, new WaitForSeconds(3f));
				Block_58:
				return this.Yield(11, new WaitForSeconds(2f));
				IL_91F:
				return this.Yield(8, new WaitForSeconds(3f));
				Block_64:
				goto IL_EED;
				Block_66:
				goto IL_71D;
				IL_A16:
				return this.Yield(9, new WaitForSeconds(1f));
				Block_80:
				IL_BA1:
				goto IL_EED;
				Block_82:
				goto IL_651;
				IL_BFA:
				goto IL_EED;
				IL_C24:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_CB3:
				return this.Yield(10, new WaitForSeconds(1f));
				Block_90:
				IL_D26:
				IL_DB8:
				goto IL_EED;
				Block_99:
				return this.Yield(2, new WaitForSeconds(0.3f));
				Block_101:
				IL_EED:
				return false;
			}

			// Token: 0x06008D53 RID: 36179 RVA: 0x0113BA44 File Offset: 0x01139C44
			internal static bool CQyab1VTR2VxaYJSHYYK()
			{
				return true;
			}

			// Token: 0x06008D54 RID: 36180 RVA: 0x0113BA48 File Offset: 0x01139C48
			internal static bool JYQwUmVTwJZij5NZm6nu()
			{
				return false;
			}

			// Token: 0x040086C4 RID: 34500
			internal GameObject $mWalrus$40802;

			// Token: 0x040086C5 RID: 34501
			internal GameObject $mReindeer$40803;

			// Token: 0x040086C6 RID: 34502
			internal GameGui $mGameGui$40804;

			// Token: 0x040086C7 RID: 34503
			internal StoryGui $mStoryGui$40805;

			// Token: 0x040086C8 RID: 34504
			internal GameObject $mLibraryElevator$40806;

			// Token: 0x040086C9 RID: 34505
			internal GameObject $mEventCamera1$40807;

			// Token: 0x040086CA RID: 34506
			internal GameObject $mEventCamera2$40808;

			// Token: 0x040086CB RID: 34507
			internal GameObject $mEventCamera3$40809;

			// Token: 0x040086CC RID: 34508
			internal string $nMessage$40810;

			// Token: 0x040086CD RID: 34509
			internal M804_LibraryElevator $self_$40811;
		}
	}

	// Token: 0x020017B4 RID: 6068
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$40813 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008D55 RID: 36181 RVA: 0x0113BA4C File Offset: 0x01139C4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$40813(M804_LibraryElevator self_)
		{
			if (160973 - 474052 != -313078)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (86409 - 97230 != -10820)
				{
					base..ctor();
					if (279735 - 156167 == 123568)
					{
						this.$self_$40818 = self_;
						if (71859 - 290212 == -218353)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008D56 RID: 36182 RVA: 0x0113BAE4 File Offset: 0x01139CE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M804_LibraryElevator.$onDeadPlayer$40813.$(this.$self_$40818);
		}

		// Token: 0x06008D57 RID: 36183 RVA: 0x0113BAF4 File Offset: 0x01139CF4
		internal static bool cIFbOVVTqIIbGZX91cBE()
		{
			return true;
		}

		// Token: 0x06008D58 RID: 36184 RVA: 0x0113BAF8 File Offset: 0x01139CF8
		internal static bool H3vo3ZVT7wVe1uQttB4d()
		{
			return false;
		}

		// Token: 0x040086CE RID: 34510
		internal M804_LibraryElevator $self_$40818;

		// Token: 0x020017B5 RID: 6069
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008D59 RID: 36185 RVA: 0x0113BAFC File Offset: 0x01139CFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M804_LibraryElevator self_)
			{
				if (179877 - 470937 != -291059)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (184139 - 567815 != -383675)
					{
						base..ctor();
						if (237643 - 209249 != 28395)
						{
							this.$self_$40817 = self_;
							if (8969 - 367941 == -358972)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008D5A RID: 36186 RVA: 0x0113BB94 File Offset: 0x01139D94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (235257 - 99093 != 136165)
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
							goto IL_114;
						}
						if (280992 - 167102 != 113890)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (71957 - 557856 != -485899)
							{
								continue;
							}
							goto IL_114;
						}
						IL_A3:
						this.YieldDefault(1);
						if (248778 - 370043 != -121264)
						{
							goto Block_6;
						}
						continue;
						IL_114:
						Game.mGameState = eGameState.Hold;
						if (254724 - 520499 != -265775)
						{
							continue;
						}
						this.$mStoryGui$40814 = (StoryGui)this.$self_$40817.GetComponent(typeof(StoryGui));
						if (120181 - 193978 == -73796)
						{
							continue;
						}
						if (this.$mStoryGui$40814)
						{
							if (187916 - 426564 == -238647)
							{
								continue;
							}
							this.$mStoryGui$40814.close();
							if (227537 - 438661 != -211124)
							{
								continue;
							}
						}
						this.$mChangeGui$40815 = (ChangeGui)this.$self_$40817.GetComponent(typeof(ChangeGui));
						if (189408 - 115013 == 74396)
						{
							continue;
						}
						if (this.$mChangeGui$40815)
						{
							if (136038 - 494214 != -358176)
							{
								continue;
							}
							this.$mChangeGui$40815.close();
							if (117763 - 448723 == -330959)
							{
								continue;
							}
						}
						this.$mGameGui$40816 = (GameGui)this.$self_$40817.GetComponent(typeof(GameGui));
						if (1311 - 324736 != -323425)
						{
							continue;
						}
						if (!this.$mGameGui$40816)
						{
							goto IL_A3;
						}
						if (227517 - 127991 != 99526)
						{
							continue;
						}
						if (!this.$mGameGui$40816.enabled)
						{
							if (238745 - 89250 != 149495)
							{
								continue;
							}
							this.$mGameGui$40816.enabled = true;
							if (122464 - 281097 != -158633)
							{
								continue;
							}
						}
						this.$mGameGui$40816.openDeadMenu();
						if (119997 - 26326 != 93671)
						{
							continue;
						}
						goto IL_A3;
					default:
						if (140172 - 438748 == -298575)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
					if (37311 - 301175 == -263864)
					{
						goto IL_1CC;
					}
				}
				Block_6:
				goto IL_2F9;
				IL_1CC:
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06008D5B RID: 36187 RVA: 0x0113BEAC File Offset: 0x0113A0AC
			internal static bool WDrEXwVTPMc8R9v8AF1T()
			{
				return true;
			}

			// Token: 0x06008D5C RID: 36188 RVA: 0x0113BEB0 File Offset: 0x0113A0B0
			internal static bool Rx0RWfVT0Qhx3ZdErfIx()
			{
				return false;
			}

			// Token: 0x040086CF RID: 34511
			internal StoryGui $mStoryGui$40814;

			// Token: 0x040086D0 RID: 34512
			internal ChangeGui $mChangeGui$40815;

			// Token: 0x040086D1 RID: 34513
			internal GameGui $mGameGui$40816;

			// Token: 0x040086D2 RID: 34514
			internal M804_LibraryElevator $self_$40817;
		}
	}

	// Token: 0x020017B6 RID: 6070
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$40819 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008D5D RID: 36189 RVA: 0x0113BEB4 File Offset: 0x0113A0B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$40819(Hashtable data, M804_LibraryElevator self_)
		{
			if (250110 - 391159 != -141049)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (240533 - 274661 != -34127)
				{
					base..ctor();
					if (106914 - 371102 == -264188)
					{
						this.$data$40824 = data;
						if (140853 - 594333 != -453479)
						{
							this.$self_$40825 = self_;
							if (22873 - 536075 == -513202)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008D5E RID: 36190 RVA: 0x0113BF70 File Offset: 0x0113A170
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M804_LibraryElevator.$onChangePlayer$40819.$(this.$data$40824, this.$self_$40825);
		}

		// Token: 0x06008D5F RID: 36191 RVA: 0x0113BF84 File Offset: 0x0113A184
		internal static bool tP6WIOVTbxbZVcTNQuX7()
		{
			return true;
		}

		// Token: 0x06008D60 RID: 36192 RVA: 0x0113BF88 File Offset: 0x0113A188
		internal static bool fTQc5QVTuWYj3ZfFuawa()
		{
			return false;
		}

		// Token: 0x040086D3 RID: 34515
		internal Hashtable $data$40824;

		// Token: 0x040086D4 RID: 34516
		internal M804_LibraryElevator $self_$40825;

		// Token: 0x020017B7 RID: 6071
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008D61 RID: 36193 RVA: 0x0113BF8C File Offset: 0x0113A18C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M804_LibraryElevator self_)
			{
				if (65973 - 360682 != -294708)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (92577 - 52673 == 39904)
					{
						base..ctor();
						if (5850 - 422971 == -417121)
						{
							this.$data$40822 = data;
							if (228818 - 129621 != 99198)
							{
								this.$self_$40823 = self_;
								if (155744 - 205147 != -49402)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008D62 RID: 36194 RVA: 0x0113C048 File Offset: 0x0113A248
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (217999 - 302670 != -84671)
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
							if (213789 - 498545 == -284755)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (117308 - 400005 == -282696)
							{
								continue;
							}
							this.$mGameGui$40821 = (GameGui)this.$self_$40823.GetComponent(typeof(GameGui));
							if (24793 - 388655 != -363862)
							{
								continue;
							}
							this.$mGameGui$40821.enabled = true;
							if (201516 - 595369 == -393852)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (106728 - 222095 != -115367)
						{
							continue;
						}
						goto IL_205;
					default:
						if (136384 - 582702 == -446317)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (195671 - 523496 != -327824)
					{
						this.$self_$40823.SendMessage("onCreatePlayer", this.$data$40822);
						if (144581 - 51338 == 93243)
						{
							this.$mChangeGui$40820 = (ChangeGui)this.$self_$40823.GetComponent(typeof(ChangeGui));
							if (152097 - 581865 != -429767)
							{
								if (!this.$mChangeGui$40820.enabled)
								{
									break;
								}
								if (230878 - 54913 == 175965)
								{
									this.$mChangeGui$40820.close();
									if (184277 - 281749 == -97472)
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

			// Token: 0x06008D63 RID: 36195 RVA: 0x0113C26C File Offset: 0x0113A46C
			internal static bool vOgnWiVTIq9qkjSCZP5v()
			{
				return true;
			}

			// Token: 0x06008D64 RID: 36196 RVA: 0x0113C270 File Offset: 0x0113A470
			internal static bool apbamNVTBnCRm82kPOtX()
			{
				return false;
			}

			// Token: 0x040086D5 RID: 34517
			internal ChangeGui $mChangeGui$40820;

			// Token: 0x040086D6 RID: 34518
			internal GameGui $mGameGui$40821;

			// Token: 0x040086D7 RID: 34519
			internal Hashtable $data$40822;

			// Token: 0x040086D8 RID: 34520
			internal M804_LibraryElevator $self_$40823;
		}
	}

	// Token: 0x020017B8 RID: 6072
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$40826 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008D65 RID: 36197 RVA: 0x0113C274 File Offset: 0x0113A474
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$40826(M804_LibraryElevator self_)
		{
			if (253484 - 387566 != -134081)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (134811 - 524422 == -389611)
				{
					base..ctor();
					if (9660 - 101546 == -91886)
					{
						this.$self_$40830 = self_;
						if (257046 - 75417 == 181629)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008D66 RID: 36198 RVA: 0x0113C30C File Offset: 0x0113A50C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M804_LibraryElevator.$ReturnToTown$40826.$(this.$self_$40830);
		}

		// Token: 0x06008D67 RID: 36199 RVA: 0x0113C31C File Offset: 0x0113A51C
		internal static bool jitvlvVTeIks6pkT3ECA()
		{
			return true;
		}

		// Token: 0x06008D68 RID: 36200 RVA: 0x0113C320 File Offset: 0x0113A520
		internal static bool QBRkkEVTrpC1D5QBwf3K()
		{
			return false;
		}

		// Token: 0x040086D9 RID: 34521
		internal M804_LibraryElevator $self_$40830;

		// Token: 0x020017B9 RID: 6073
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008D69 RID: 36201 RVA: 0x0113C324 File Offset: 0x0113A524
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M804_LibraryElevator self_)
			{
				if (18165 - 546044 != -527878)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (221891 - 414444 == -192553)
					{
						base..ctor();
						if (21085 - 252179 == -231094)
						{
							this.$self_$40829 = self_;
							if (129728 - 332560 != -202831)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008D6A RID: 36202 RVA: 0x0113C3BC File Offset: 0x0113A5BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (249227 - 125933 != 123294)
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
						this.$self_$40829.LeaveGame();
						if (181070 - 206671 != -25601)
						{
							continue;
						}
						this.YieldDefault(1);
						if (190423 - 80919 != 109504)
						{
							continue;
						}
						goto IL_3AD;
					default:
						if (90757 - 589565 == -498807)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (13746 - 498410 != -484663)
					{
						Game.mStateTime = Time.time;
						if (179996 - 161501 != 18496)
						{
							this.$$switch$7319$40827 = PlayerData.SaveGuild;
							if (276554 - 431099 == -154545)
							{
								if (this.$$switch$7319$40827 == 1)
								{
									if (266916 - 586529 != -319613)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (88130 - 330338 == -242207)
									{
										continue;
									}
								}
								else if (this.$$switch$7319$40827 == 2)
								{
									if (265135 - 25137 == 239999)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (111968 - 153926 == -41957)
									{
										continue;
									}
								}
								else if (this.$$switch$7319$40827 == 3)
								{
									if (159810 - 321928 != -162118)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (261461 - 411834 != -150373)
									{
										continue;
									}
								}
								else if (this.$$switch$7319$40827 == 4)
								{
									if (119126 - 192586 != -73460)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (75988 - 58018 == 17971)
									{
										continue;
									}
								}
								else if (this.$$switch$7319$40827 == 5)
								{
									if (101411 - 506159 == -404747)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (132676 - 247414 != -114738)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (277795 - 79301 == 198495)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (70884 - 439579 != -368695)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (140482 - 379790 == -239307)
									{
										continue;
									}
								}
								this.$mGameGui$40828 = (GameGui)this.$self_$40829.GetComponent(typeof(GameGui));
								if (134853 - 9268 != 125586)
								{
									if (this.$mGameGui$40828)
									{
										if (173378 - 282775 != -109397)
										{
											continue;
										}
										this.$mGameGui$40828.close();
										if (270622 - 553648 != -283026)
										{
											continue;
										}
									}
									this.$self_$40829.SendMessage("fadeOut");
									if (98080 - 465619 == -367539)
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

			// Token: 0x06008D6B RID: 36203 RVA: 0x0113C788 File Offset: 0x0113A988
			internal static bool MFAVk3VTjnCqeCC70nYL()
			{
				return true;
			}

			// Token: 0x06008D6C RID: 36204 RVA: 0x0113C78C File Offset: 0x0113A98C
			internal static bool h18tDgVThJbkeHQ6CWKU()
			{
				return false;
			}

			// Token: 0x040086DA RID: 34522
			internal int $$switch$7319$40827;

			// Token: 0x040086DB RID: 34523
			internal GameGui $mGameGui$40828;

			// Token: 0x040086DC RID: 34524
			internal M804_LibraryElevator $self_$40829;
		}
	}

	// Token: 0x020017BA RID: 6074
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$40831 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008D6D RID: 36205 RVA: 0x0113C790 File Offset: 0x0113A990
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$40831(M804_LibraryElevator self_)
		{
			if (101980 - 294211 != -192231)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (207637 - 505944 == -298307)
				{
					base..ctor();
					if (211239 - 295205 == -83966)
					{
						this.$self_$40834 = self_;
						if (181313 - 145618 != 35696)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008D6E RID: 36206 RVA: 0x0113C828 File Offset: 0x0113AA28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M804_LibraryElevator.$ReturnToGuild$40831.$(this.$self_$40834);
		}

		// Token: 0x06008D6F RID: 36207 RVA: 0x0113C838 File Offset: 0x0113AA38
		internal static bool E6NwO2VTs1KM8lR70Fic()
		{
			return true;
		}

		// Token: 0x06008D70 RID: 36208 RVA: 0x0113C83C File Offset: 0x0113AA3C
		internal static bool u83R6jVT9236OhfY9Qh3()
		{
			return false;
		}

		// Token: 0x040086DD RID: 34525
		internal M804_LibraryElevator $self_$40834;

		// Token: 0x020017BB RID: 6075
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008D71 RID: 36209 RVA: 0x0113C840 File Offset: 0x0113AA40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M804_LibraryElevator self_)
			{
				if (96707 - 197873 != -101166)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (92206 - 120962 != -28755)
					{
						base..ctor();
						if (151171 - 434250 != -283078)
						{
							this.$self_$40833 = self_;
							if (103674 - 89843 != 13832)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008D72 RID: 36210 RVA: 0x0113C8D8 File Offset: 0x0113AAD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (220557 - 545752 != -325195)
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
						this.$self_$40833.LeaveGame();
						if (90102 - 285988 == -195885)
						{
							continue;
						}
						this.YieldDefault(1);
						if (63616 - 229706 != -166089)
						{
							goto Block_10;
						}
						continue;
					default:
						if (22689 - 7394 != 15295)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (77079 - 431121 != -354041)
					{
						Game.mStateTime = Time.time;
						if (141533 - 23727 == 117806)
						{
							Game.mNextGameCode = 31;
							if (218546 - 580834 != -362287)
							{
								this.$mGameGui$40832 = (GameGui)this.$self_$40833.GetComponent(typeof(GameGui));
								if (91498 - 13205 != 78294)
								{
									if (this.$mGameGui$40832)
									{
										if (160481 - 239304 == -78822)
										{
											continue;
										}
										this.$mGameGui$40832.close();
										if (129319 - 245773 == -116453)
										{
											continue;
										}
									}
									this.$self_$40833.SendMessage("fadeOut");
									if (99813 - 545496 == -445683)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_10:
				IL_1BD:
				return false;
			}

			// Token: 0x06008D73 RID: 36211 RVA: 0x0113CAB4 File Offset: 0x0113ACB4
			internal static bool Wd8Oj2VT1KbCHQyK7P88()
			{
				return true;
			}

			// Token: 0x06008D74 RID: 36212 RVA: 0x0113CAB8 File Offset: 0x0113ACB8
			internal static bool vDBNtAVT4Z8yI7LWsGFO()
			{
				return false;
			}

			// Token: 0x040086DE RID: 34526
			internal GameGui $mGameGui$40832;

			// Token: 0x040086DF RID: 34527
			internal M804_LibraryElevator $self_$40833;
		}
	}

	// Token: 0x020017BC RID: 6076
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$40835 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008D75 RID: 36213 RVA: 0x0113CABC File Offset: 0x0113ACBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$40835(M804_LibraryElevator self_)
		{
			if (293132 - 473755 != -180623)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (256978 - 148865 == 108113)
				{
					base..ctor();
					if (224842 - 100460 == 124382)
					{
						this.$self_$40839 = self_;
						if (122741 - 136923 != -14181)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008D76 RID: 36214 RVA: 0x0113CB54 File Offset: 0x0113AD54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M804_LibraryElevator.$ReturnToCamp$40835.$(this.$self_$40839);
		}

		// Token: 0x06008D77 RID: 36215 RVA: 0x0113CB64 File Offset: 0x0113AD64
		internal static bool Jgkl78VTz740OYdDvp71()
		{
			return true;
		}

		// Token: 0x06008D78 RID: 36216 RVA: 0x0113CB68 File Offset: 0x0113AD68
		internal static bool cVCSu8V3ahApQLGwj8kH()
		{
			return false;
		}

		// Token: 0x040086E0 RID: 34528
		internal M804_LibraryElevator $self_$40839;

		// Token: 0x020017BD RID: 6077
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008D79 RID: 36217 RVA: 0x0113CB6C File Offset: 0x0113AD6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M804_LibraryElevator self_)
			{
				if (197288 - 363845 != -166556)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (93130 - 127926 != -34795)
					{
						base..ctor();
						if (88361 - 450560 != -362198)
						{
							this.$self_$40838 = self_;
							if (95526 - 104663 != -9136)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008D7A RID: 36218 RVA: 0x0113CC04 File Offset: 0x0113AE04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (279043 - 491668 != -212624)
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
						this.$self_$40838.LeaveGame();
						if (160578 - 526955 == -366376)
						{
							continue;
						}
						this.YieldDefault(1);
						if (9247 - 432487 != -423239)
						{
							goto Block_24;
						}
						continue;
					default:
						if (90866 - 179939 == -89072)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (173268 - 333563 == -160295)
					{
						Game.mStateTime = Time.time;
						if (149447 - 126092 == 23355)
						{
							this.$$switch$7321$40836 = PlayerData.SaveGuild;
							if (246571 - 352820 != -106248)
							{
								if (this.$$switch$7321$40836 == 1)
								{
									if (131980 - 527240 != -395260)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (99225 - 510777 == -411551)
									{
										continue;
									}
								}
								else if (this.$$switch$7321$40836 == 2)
								{
									if (245403 - 537550 != -292147)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (78345 - 514086 == -435740)
									{
										continue;
									}
								}
								else if (this.$$switch$7321$40836 == 3)
								{
									if (165458 - 57724 != 107734)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (269760 - 556243 == -286482)
									{
										continue;
									}
								}
								else if (this.$$switch$7321$40836 == 4)
								{
									if (107511 - 104092 != 3419)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (223388 - 51876 == 171513)
									{
										continue;
									}
								}
								else if (this.$$switch$7321$40836 == 5)
								{
									if (228050 - 291943 == -63892)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (264833 - 565368 == -300534)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (26190 - 60322 != -34132)
									{
										continue;
									}
								}
								this.$mGameGui$40837 = (GameGui)this.$self_$40838.GetComponent(typeof(GameGui));
								if (163885 - 201888 != -38002)
								{
									if (this.$mGameGui$40837)
									{
										if (279336 - 410802 != -131466)
										{
											continue;
										}
										this.$mGameGui$40837.close();
										if (47852 - 128611 != -80759)
										{
											continue;
										}
									}
									this.$self_$40838.SendMessage("fadeOut");
									if (55118 - 405855 == -350737)
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
				IL_363:
				return false;
			}

			// Token: 0x06008D7B RID: 36219 RVA: 0x0113CF88 File Offset: 0x0113B188
			internal static bool HPu0btV35mahcugiZyvF()
			{
				return true;
			}

			// Token: 0x06008D7C RID: 36220 RVA: 0x0113CF8C File Offset: 0x0113B18C
			internal static bool qeqYwRV3pmjKWiWOMTBL()
			{
				return false;
			}

			// Token: 0x040086E1 RID: 34529
			internal int $$switch$7321$40836;

			// Token: 0x040086E2 RID: 34530
			internal GameGui $mGameGui$40837;

			// Token: 0x040086E3 RID: 34531
			internal M804_LibraryElevator $self_$40838;
		}
	}
}
