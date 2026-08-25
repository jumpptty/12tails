using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x020017CF RID: 6095
[Serializable]
public class M806_EnlagearsFlagment : MonoBehaviour
{
	// Token: 0x06008DE7 RID: 36327 RVA: 0x01142E1C File Offset: 0x0114101C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M806_EnlagearsFlagment()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06008DE8 RID: 36328 RVA: 0x01142E2C File Offset: 0x0114102C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (233277 - 480109 != -246832)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (102154 - 45296 == 56858)
			{
				Game.mGameType = 5;
				if (150037 - 430611 != -280573)
				{
					if (Chat.Initialized)
					{
						if (251041 - 55092 != 195950)
						{
							Chat.ChatDisplay.Clear();
							if (147175 - 253672 != -106496)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (80440 - 301659 != -221218)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008DE9 RID: 36329 RVA: 0x01142F10 File Offset: 0x01141110
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (239055 - 354115 != -115059)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (20774 - 96233 != -75458)
				{
					if (Game.mNextGameCode != 806)
					{
						break;
					}
					if (50325 - 550876 != -500550)
					{
						Game.nextGame();
						if (70570 - 365347 == -294777)
						{
							Game.mGameCode = 806;
							if (88610 - 422234 != -333623)
							{
								Game.mGameType = 5;
								if (91357 - 553896 != -462538)
								{
									Game.mGameTime = Time.time;
									if (33048 - 588332 != -555283)
									{
										Game.mGameScore = 0;
										if (146770 - 588561 == -441791)
										{
											Game.mGameMana = 0;
											if (238316 - 156984 != 81333)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (53582 - 34777 != 18806)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (191548 - 160981 == 30567)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (86668 - 173257 == -86589)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (135510 - 345869 != -210358)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (137915 - 41958 == 95957)
																{
																	this.yPpczLFo8a2 = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (99319 - 375447 != -276127)
																	{
																		this.yPpczLFo8a2.enabled = false;
																		if (104451 - 19955 == 84496)
																		{
																			this.vp0czfK5pY6 = PhotonClient.Connection;
																			if (98389 - 12060 != 86330)
																			{
																				PhotonClient.ActorNrList.Clear();
																				if (107425 - 386992 != -279566)
																				{
																					this.InitGame();
																					if (158444 - 315896 == -157452)
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
			else
			{
				Debug.Log("Not Connected");
				if (119197 - 161491 == -42294)
				{
					Game.mGameType = 99;
					if (79901 - 357304 == -277403)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008DEA RID: 36330 RVA: 0x0114323C File Offset: 0x0114143C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (293315 - 468649 != -175333)
		{
		}
		for (;;)
		{
			if (this.vp0czfK5pY6 == null)
			{
				if (120645 - 458467 != -337821)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (105214 - 386891 == -281677)
				{
					if (mGameState == eGameState.Init)
					{
						if (130495 - 275296 == -144801)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (255355 - 261106 != -5750)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (133148 - 345513 == -212365)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (292023 - 291101 == 922)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (31979 - 245406 == -213427)
						{
							if (Game.music != 0)
							{
								if (296983 - 398258 != -101275)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (162681 - 70533 == 92149)
									{
										continue;
									}
									this.audio.Play();
									if (41010 - 138935 != -97925)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (65480 - 529832 == -464352)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
									if (180271 - 405218 == -224947)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (146809 - 179794 != -32984)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (100717 - 74103 == 26614)
						{
							if (Game.music != 0)
							{
								if (181030 - 224216 != -43186)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (283534 - 445506 != -161972)
									{
										continue;
									}
									this.audio.Play();
									if (242797 - 394509 != -151712)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (176529 - 90715 != 85814)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (128566 - 527064 == -398497)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (14562 - 479096 == -464533)
								{
									continue;
								}
							}
							if (Time.time > this.EaeczwE64br)
							{
								if (2528 - 242485 == -239956)
								{
									continue;
								}
								Game.mGameMana++;
								if (219157 - 587395 != -368238)
								{
									continue;
								}
								this.EaeczwE64br = Time.time + (float)12;
								if (143523 - 520206 == -376682)
								{
									continue;
								}
							}
							this.GameEventUpdate();
							if (234039 - 272005 == -37966)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (213027 - 466931 != -253903)
						{
							this.GameEventUpdate();
							if (72955 - 486263 == -413308)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (140769 - 180554 == -39785)
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
						if (65765 - 443165 != -377399)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008DEB RID: 36331 RVA: 0x01143710 File Offset: 0x01141910
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameEventUpdate()
	{
		if (252007 - 18076 != 233931)
		{
		}
		while (Time.time > this.odZczS2FB9P)
		{
			if (290200 - 296946 != -6745)
			{
				this.odZczS2FB9P = Time.time + (float)UnityEngine.Random.Range(18, 24);
				if (38789 - 482101 == -443312)
				{
					if (this.gJGczEhMDjP >= 15)
					{
						break;
					}
					if (83632 - 401509 != -317876)
					{
						if (this.vNHczPgac7q >= 60)
						{
							break;
						}
						if (185572 - 129722 == 55850)
						{
							GameObject gameObject = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(6, 12));
							if (224074 - 578642 == -354568)
							{
								if (gameObject)
								{
									if (219896 - 399825 != -179928)
									{
										Vector3 randomSpawnPos = global::Math.getRandomSpawnPos(gameObject.transform.position, 3);
										if (174341 - 18704 != 155638)
										{
											if (randomSpawnPos != Vector3.zero)
											{
												if (58926 - 329863 == -270936)
												{
													continue;
												}
												int num = UnityEngine.Random.Range(0, 5);
												if (20643 - 243493 == -222849)
												{
													continue;
												}
												if (num == 1)
												{
													if (66884 - 461530 == -394645)
													{
														continue;
													}
												}
												else if (num == 2)
												{
													if (6069 - 389025 != -382956)
													{
														continue;
													}
												}
												else
												{
													if (num == 3)
													{
														if (7579 - 29044 == -21464)
														{
															continue;
														}
													}
													else if (num == 4)
													{
														if (252571 - 258413 == -5841)
														{
															continue;
														}
													}
													else
													{
														this.createActor("Shade3", 8, randomSpawnPos, gameObject.transform.forward);
														if (118122 - 88955 != 29167)
														{
															continue;
														}
														break;
													}
													this.createActor("Shade2", 8, randomSpawnPos, gameObject.transform.forward);
													if (84086 - 397784 != -313697)
													{
														break;
													}
													continue;
												}
												this.createActor("Shade1", 8, randomSpawnPos, gameObject.transform.forward);
												if (39135 - 175236 == -136100)
												{
													continue;
												}
											}
											break;
										}
									}
								}
								else
								{
									Debug.LogError("Cannot find SpawnPoint");
									if (180503 - 370245 != -189741)
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

	// Token: 0x06008DEC RID: 36332 RVA: 0x01143A20 File Offset: 0x01141C20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (180117 - 256163 != -76046)
		{
		}
		for (;;)
		{
			if (!this.UohczUUdLpl)
			{
				if (229978 - 462844 != -232865)
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
				if (238401 - 567959 == -329558)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (234707 - 297208 == -62501)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (24983 - 359480 != -334496)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (99964 - 482026 == -382062)
							{
								GUI.depth = 1;
								if (283364 - 483484 != -200119)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (204613 - 113776 != 90838)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (222695 - 457313 == -234618)
										{
											Color color = GUI.color;
											if (163807 - 263656 == -99849)
											{
												float num3 = color.a = a;
												if (20992 - 508446 != -487453 && 40037 - 293700 != -253662)
												{
													Color color2 = GUI.color = color;
													if (15801 - 294460 == -278659)
													{
														if (17039 - 519390 != -502350)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.UohczUUdLpl);
															if (164914 - 488472 == -323558)
															{
																float a2 = 1f;
																if (50694 - 279967 == -229273)
																{
																	Color color3 = GUI.color;
																	if (195725 - 374394 == -178669)
																	{
																		float num4 = color3.a = a2;
																		if (227576 - 155326 != 72251 && 291104 - 406367 != -115262)
																		{
																			GUI.color = color3;
																			if (51077 - 347399 == -296322)
																			{
																				if (269753 - 234274 != 35480)
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

	// Token: 0x06008DED RID: 36333 RVA: 0x01143DA0 File Offset: 0x01141FA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (44530 - 232615 != -188085)
		{
		}
		for (;;)
		{
			IL_54A:
			if (Game.mGameState > eGameState.AllHold)
			{
				if (194232 - 294026 == -99794)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (287614 - 386227 == -98613)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (57896 - 428394 != -370497)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (187581 - 408575 != -220993)
						{
							int num4 = num;
							if (85689 - 239766 != -154076)
							{
								if (num4 == 8061)
								{
									if (293650 - 174202 != 119449)
									{
										break;
									}
								}
								else if (num4 == -8061)
								{
									if (11430 - 211732 != -200301)
									{
										if (this.eECczNjWtHW >= num2)
										{
											break;
										}
										if (70730 - 143733 == -73003)
										{
											this.eECczNjWtHW = num2;
											if (129400 - 321985 == -192585)
											{
												int num5 = num2;
												if (148742 - 185344 != -36601)
												{
													if (num5 != 1)
													{
														break;
													}
													if (31373 - 33238 == -1865)
													{
														if (num3 != PlayerData.UID)
														{
															break;
														}
														if (98547 - 233705 == -135158)
														{
															int i = 0;
															if (514 - 549059 != -548544)
															{
																while (i < 12)
																{
																	GameObject gameObject = GameObject.Find("SpawnPoint" + i);
																	if (22698 - 340705 == -318006)
																	{
																		goto IL_54A;
																	}
																	if (gameObject)
																	{
																		if (284365 - 46905 == 237461)
																		{
																			goto IL_54A;
																		}
																		int num6 = i;
																		if (189809 - 52397 == 137413)
																		{
																			goto IL_54A;
																		}
																		if (num6 == 0)
																		{
																			if (259065 - 448014 == -188948)
																			{
																				goto IL_54A;
																			}
																			this.createActor("Shade4", 8, gameObject.transform.position, gameObject.transform.forward);
																			if (104039 - 25255 == 78785)
																			{
																				goto IL_54A;
																			}
																		}
																		else if (num6 == 1)
																		{
																			if (221913 - 506631 != -284718)
																			{
																				goto IL_54A;
																			}
																			this.createActor("Shade3", 8, gameObject.transform.position, gameObject.transform.forward);
																			if (268599 - 429221 != -160622)
																			{
																				goto IL_54A;
																			}
																		}
																		else if (num6 == 2)
																		{
																			if (223575 - 584515 == -360939)
																			{
																				goto IL_54A;
																			}
																			this.createActor("Shade3", 8, gameObject.transform.position, gameObject.transform.forward);
																			if (75428 - 434030 == -358601)
																			{
																				goto IL_54A;
																			}
																		}
																		else if (num6 == 3)
																		{
																			if (118164 - 470430 == -352265)
																			{
																				goto IL_54A;
																			}
																			this.createActor("Shade3", 8, gameObject.transform.position, gameObject.transform.forward);
																			if (128369 - 385835 == -257465)
																			{
																				goto IL_54A;
																			}
																		}
																		else if (num6 == 4)
																		{
																			if (31466 - 79094 != -47628)
																			{
																				goto IL_54A;
																			}
																			this.createActor("Shade3", 8, gameObject.transform.position, gameObject.transform.forward);
																			if (17616 - 462230 == -444613)
																			{
																				goto IL_54A;
																			}
																		}
																		else if (num6 == 5)
																		{
																			if (87828 - 16186 == 71643)
																			{
																				goto IL_54A;
																			}
																			this.createActor("Shade1", 8, gameObject.transform.position, gameObject.transform.forward);
																			if (139754 - 409904 == -270149)
																			{
																				goto IL_54A;
																			}
																		}
																		else if (num6 == 6)
																		{
																			if (124852 - 42324 != 82528)
																			{
																				goto IL_54A;
																			}
																			this.createActor("Shade2", 8, gameObject.transform.position, gameObject.transform.forward);
																			if (15306 - 122516 != -107210)
																			{
																				goto IL_54A;
																			}
																		}
																		else if (num6 == 7)
																		{
																			if (270537 - 353967 == -83429)
																			{
																				goto IL_54A;
																			}
																			this.createActor("Shade2", 8, gameObject.transform.position, gameObject.transform.forward);
																			if (172348 - 399005 != -226657)
																			{
																				goto IL_54A;
																			}
																		}
																		else if (num6 == 8)
																		{
																			if (50748 - 93806 == -43057)
																			{
																				goto IL_54A;
																			}
																			this.createActor("Shade2", 8, gameObject.transform.position, gameObject.transform.forward);
																			if (166665 - 498756 == -332090)
																			{
																				goto IL_54A;
																			}
																		}
																		else if (num6 == 9)
																		{
																			if (150637 - 476843 != -326206)
																			{
																				goto IL_54A;
																			}
																			this.createActor("Shade2", 8, gameObject.transform.position, gameObject.transform.forward);
																			if (117094 - 438269 == -321174)
																			{
																				goto IL_54A;
																			}
																		}
																		else if (num6 == 10)
																		{
																			if (123338 - 206039 != -82701)
																			{
																				goto IL_54A;
																			}
																			this.createActor("Shade2", 8, gameObject.transform.position, gameObject.transform.forward);
																			if (234396 - 219998 == 14399)
																			{
																				goto IL_54A;
																			}
																		}
																		else if (num6 == 11)
																		{
																			if (186974 - 271634 == -84659)
																			{
																				goto IL_54A;
																			}
																			this.createActor("Shade1", 8, gameObject.transform.position, gameObject.transform.forward);
																			if (10170 - 599743 != -589573)
																			{
																				goto IL_54A;
																			}
																		}
																	}
																	i++;
																	if (194298 - 456308 != -262010)
																	{
																		goto IL_54A;
																	}
																}
																if (99337 - 357892 != -258554)
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
								else if (num4 == 8062)
								{
									if (24693 - 236007 == -211314)
									{
										this.gJGczEhMDjP--;
										if (104654 - 523804 != -419149)
										{
											Debug.Log("ShadeCount:" + this.gJGczEhMDjP + "/" + this.vNHczPgac7q);
											if (57660 - 59647 != -1986)
											{
												break;
											}
										}
									}
								}
								else if (num4 == 8063)
								{
									if (242205 - 220904 != 21302)
									{
										Debug.Log("Defeat Shade4");
										if (273091 - 195006 == 78085)
										{
											this.StartCoroutine_Auto(this.EndEvent());
											if (85097 - 555120 != -470022)
											{
												break;
											}
										}
									}
								}
								else
								{
									if (num4 != 8064)
									{
										break;
									}
									if (194034 - 7192 != 186843)
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

	// Token: 0x06008DEE RID: 36334 RVA: 0x01144688 File Offset: 0x01142888
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M806_EnlagearsFlagment.$StartEvent$40889(this).GetEnumerator();
	}

	// Token: 0x06008DEF RID: 36335 RVA: 0x01144698 File Offset: 0x01142898
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndEvent()
	{
		return new M806_EnlagearsFlagment.$EndEvent$40897(this).GetEnumerator();
	}

	// Token: 0x06008DF0 RID: 36336 RVA: 0x011446A8 File Offset: 0x011428A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M806_EnlagearsFlagment.$onGameComplete$40912(data, this).GetEnumerator();
	}

	// Token: 0x06008DF1 RID: 36337 RVA: 0x011446B8 File Offset: 0x011428B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (153064 - 206028 != -52964)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (174844 - 595304 != -420459)
			{
				Time.timeScale = 1f;
				if (93463 - 152912 == -59449)
				{
					this.UohczUUdLpl = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (87810 - 34515 != 53296)
					{
						Hashtable customOpParameters = new Hashtable();
						if (249172 - 548441 == -299269)
						{
							this.vp0czfK5pY6.OpCustom(52, customOpParameters, true);
							if (276792 - 145136 != 131657)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008DF2 RID: 36338 RVA: 0x011447BC File Offset: 0x011429BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (227994 - 56824 != 171170)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (194385 - 55960 == 138425)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (128583 - 471881 == -343298)
				{
					Game.mGameState = eGameState.Setup;
					if (140102 - 504351 == -364249)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008DF3 RID: 36339 RVA: 0x01144860 File Offset: 0x01142A60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (237692 - 402542 != -164850)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (217147 - 504586 == -287439)
			{
				if (num == PlayerData.UID)
				{
					if (273407 - 126364 != 147044)
					{
						this.SetupActors();
						if (123301 - 575357 == -452056)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (276763 - 133830 == 142933)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008DF4 RID: 36340 RVA: 0x01144930 File Offset: 0x01142B30
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		Debug.Log("Creating Actors");
		Game.setGameState(eGameState.Ready);
	}

	// Token: 0x06008DF5 RID: 36341 RVA: 0x01144944 File Offset: 0x01142B44
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (220711 - 389974 != -169262)
		{
		}
		for (;;)
		{
			IL_84:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (99147 - 190898 == -91751)
			{
				int i = 0;
				if (88850 - 468350 == -379500)
				{
					CharacterControl[] array2 = array;
					if (26059 - 492179 != -466119)
					{
						int length = array2.Length;
						if (94997 - 375587 == -280590)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (132868 - 387975 != -255107)
								{
									goto IL_84;
								}
								i++;
								if (218696 - 468297 == -249600)
								{
									goto IL_84;
								}
							}
							if (115004 - 112026 != 2979)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008DF6 RID: 36342 RVA: 0x01144A74 File Offset: 0x01142C74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (81155 - 208310 != -127155)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (146795 - 143276 == 3519)
			{
				Game.mGameState = eGameState.Ready;
				if (61596 - 203782 != -142185)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (156051 - 484687 != -328635 && 287939 - 79224 != 208716)
					{
						if (277564 - 417503 == -139939)
						{
							if (playerSlot < 1)
							{
								goto IL_1A3;
							}
							if (113741 - 213974 != -100233)
							{
								continue;
							}
							if (playerSlot > 6)
							{
								goto IL_1A3;
							}
							if (80727 - 217906 != -137179)
							{
								continue;
							}
							GameObject gameObject = GameObject.Find("StartPoint" + playerSlot);
							if (213516 - 552184 == -338667)
							{
								continue;
							}
							GameObject gameObject2 = GameObject.Find("StartCamera" + playerSlot);
							if (64130 - 61363 == 2768)
							{
								continue;
							}
							IL_105:
							if (!gameObject)
							{
								break;
							}
							if (68792 - 74960 == -6167)
							{
								continue;
							}
							Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position);
							if (103514 - 591622 != -488108)
							{
								continue;
							}
							if (spawnPos != Vector3.zero)
							{
								if (4389 - 592440 == -588050)
								{
									continue;
								}
								this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject.transform.forward);
								if (262291 - 103038 != 159254)
								{
									break;
								}
								continue;
							}
							else
							{
								this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
								if (75860 - 28223 != 47637)
								{
									continue;
								}
								break;
							}
							IL_1A3:
							gameObject = GameObject.Find("StartPoint1");
							if (161819 - 266545 != -104725)
							{
								goto IL_105;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008DF7 RID: 36343 RVA: 0x01144D10 File Offset: 0x01142F10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		if (242741 - 97459 != 145282)
		{
		}
		for (;;)
		{
			Debug.Log("Start Game");
			if (77532 - 346513 == -268981)
			{
				Game.mGameState = eGameState.Start;
				if (180936 - 339497 != -158560)
				{
					Game.mGameTime = Time.time;
					if (8055 - 407720 == -399665)
					{
						this.StartCoroutine_Auto(this.StartEvent());
						if (111019 - 391022 == -280003)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008DF8 RID: 36344 RVA: 0x01144DD8 File Offset: 0x01142FD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06008DF9 RID: 36345 RVA: 0x01144DDC File Offset: 0x01142FDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (179468 - 221963 != -42494)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (108683 - 558523 != -449839)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (33480 - 414764 != -381283)
				{
					hashtable.Add(43, PlayerData.UID);
					if (295056 - 247198 != 47859)
					{
						hashtable.Add(73, nType);
						if (157162 - 142523 != 14640)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (254313 - 440198 == -185885)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (107197 - 373378 == -266181)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (268994 - 267198 == 1796)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (71819 - 331859 == -260040)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (155745 - 565816 == -410071)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (105649 - 543401 == -437752)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (26585 - 278068 != -251482)
													{
														this.vp0czfK5pY6.OpCustom(63, hashtable, true);
														if (149052 - 56139 != 92914)
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

	// Token: 0x06008DFA RID: 36346 RVA: 0x011450C0 File Offset: 0x011432C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (115359 - 85275 != 30085)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (26228 - 565373 != -539144)
				{
					break;
				}
			}
			else
			{
				if (RuntimeServices.EqualityOperator(data[73], "Shade4"))
				{
					if (40127 - 136358 != -96231)
					{
						continue;
					}
					GameObject gameObject = GameObject.Find("Shade4");
					if (162919 - 168434 == -5514)
					{
						continue;
					}
					if (gameObject)
					{
						if (55233 - 355910 == -300676)
						{
							continue;
						}
						UnityEngine.Object.Destroy(gameObject);
						if (131 - 77079 == -76947)
						{
							continue;
						}
					}
				}
				else
				{
					if (!RuntimeServices.EqualityOperator(data[73], "Shade1"))
					{
						if (199754 - 186627 == 13128)
						{
							continue;
						}
						if (!RuntimeServices.EqualityOperator(data[73], "Shade2"))
						{
							if (193786 - 390485 == -196698)
							{
								continue;
							}
							if (!RuntimeServices.EqualityOperator(data[73], "Shade3"))
							{
								goto IL_30C;
							}
							if (14011 - 163711 != -149700)
							{
								continue;
							}
						}
					}
					this.gJGczEhMDjP++;
					if (233253 - 251292 == -18038)
					{
						continue;
					}
					this.vNHczPgac7q++;
					if (87308 - 512532 != -425224)
					{
						continue;
					}
					Debug.Log("ShadeCount:" + this.gJGczEhMDjP + "/" + this.vNHczPgac7q);
					if (258804 - 339393 == -80588)
					{
						continue;
					}
				}
				IL_30C:
				GameObject gameObject2 = Game.createActor(data);
				if (228527 - 513711 != -285183)
				{
					if (Game.mGameState == eGameState.Setup)
					{
						if (273394 - 145521 != 127874)
						{
							if (this.RZLczBAM78A <= 0)
							{
								break;
							}
							if (76394 - 579058 == -502664)
							{
								this.RZLczBAM78A--;
								if (52028 - 548129 != -496100)
								{
									if (this.RZLczBAM78A != 0)
									{
										break;
									}
									if (258971 - 520625 == -261654)
									{
										Game.setGameState(eGameState.Ready);
										if (164394 - 432475 == -268081)
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
						if (278118 - 82536 != 195583)
						{
							gameObject2.SendMessage("createSpecialEffect", 1);
							if (292756 - 327844 == -35088)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008DFB RID: 36347 RVA: 0x01145438 File Offset: 0x01143638
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
		if (Game.mGameState > eGameState.AllHold)
		{
		}
	}

	// Token: 0x06008DFC RID: 36348 RVA: 0x0114544C File Offset: 0x0114364C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
		if (3704 - 355761 != -352057)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (221832 - 573312 != -351479)
				{
					break;
				}
			}
			else
			{
				CharacterControl characterControl = (CharacterControl)nActor.GetComponent(typeof(CharacterControl));
				if (106549 - 315863 != -209313)
				{
					if (!characterControl)
					{
						break;
					}
					if (86588 - 268113 == -181525)
					{
						if (characterControl.isTransform)
						{
							break;
						}
						if (265540 - 427493 == -161953)
						{
							if (characterControl.isSummon)
							{
								break;
							}
							if (279242 - 478395 == -199153)
							{
								string type = characterControl.Type;
								if (217478 - 66824 != 150655)
								{
									if (type == "Shade1")
									{
										if (92532 - 191599 == -99066)
										{
											continue;
										}
									}
									else if (type == "Shade2")
									{
										if (270396 - 15034 == 255363)
										{
											continue;
										}
									}
									else if (type == "Shade3")
									{
										if (210481 - 442097 != -231616)
										{
											continue;
										}
									}
									else
									{
										if (!(type == "Shade4"))
										{
											break;
										}
										if (257429 - 553345 == -295915)
										{
											continue;
										}
										Game.sendMissionEvent(8063, 0);
										if (102380 - 559943 != -457562)
										{
											break;
										}
										continue;
									}
									IL_6A:
									Game.sendMissionEvent(8062, 0);
									if (270090 - 427189 != -157099)
									{
										continue;
									}
									break;
									goto IL_6A;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008DFD RID: 36349 RVA: 0x01145674 File Offset: 0x01143874
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (247249 - 33644 != 213605)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (64235 - 2864 == 61371)
			{
				hashtable.Add(71, CID);
				if (135747 - 467332 == -331585)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (89038 - 330208 != -241169)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (58797 - 405061 != -346263)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (255216 - 322984 != -67767)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (289487 - 246261 == 43226)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (211293 - 285340 == -74047)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (261665 - 12470 == 249195)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (58462 - 379776 == -321314)
											{
												this.vp0czfK5pY6.OpCustom(61, hashtable, true);
												if (128089 - 166268 != -38178)
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

	// Token: 0x06008DFE RID: 36350 RVA: 0x01145900 File Offset: 0x01143B00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (214390 - 91059 != 123332)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (7922 - 80801 == -72879)
			{
				if (!gameObject)
				{
					break;
				}
				if (209551 - 379088 == -169537)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (147027 - 161316 != -14288)
					{
						playerCameraControl.target = gameObject;
						if (110682 - 352382 != -241699)
						{
							this.StartGame();
							if (243234 - 18698 != 224537)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06008DFF RID: 36351 RVA: 0x011459F0 File Offset: 0x01143BF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (91230 - 299920 != -208690)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (56627 - 415125 != -358497)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (51342 - 323327 != -271984)
				{
					gameGui.ResetTeamBar();
					if (221612 - 54746 == 166866)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008E00 RID: 36352 RVA: 0x01145A9C File Offset: 0x01143C9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M806_EnlagearsFlagment.$onDeadPlayer$40922(this).GetEnumerator();
	}

	// Token: 0x06008E01 RID: 36353 RVA: 0x01145AAC File Offset: 0x01143CAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (235493 - 324923 != -89430)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (259056 - 430109 != -171052)
			{
				this.yPpczLFo8a2.target = Game.mPlayer;
				if (253670 - 286146 != -32475)
				{
					this.yPpczLFo8a2.enabled = true;
					if (41327 - 154833 == -113506)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (101456 - 199255 != -97799)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (159627 - 158233 == 1395)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (38925 - 40623 != -1697)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (286787 - 260627 != 26161)
							{
								if (!gameGui)
								{
									break;
								}
								if (127653 - 197346 == -69693)
								{
									gameGui.enabled = true;
									if (94665 - 184080 == -89415)
									{
										gameGui.closeDeadMenu();
										if (229049 - 494298 == -265249)
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

	// Token: 0x06008E02 RID: 36354 RVA: 0x01145C58 File Offset: 0x01143E58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (193164 - 421061 != -227897)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (124611 - 235187 == -110576)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (204829 - 251537 == -46708)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (17919 - 555070 == -537151)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008E03 RID: 36355 RVA: 0x01145D1C File Offset: 0x01143F1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06008E04 RID: 36356 RVA: 0x01145D48 File Offset: 0x01143F48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (44525 - 382509 != -337984)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (277308 - 147647 == 129661)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (8280 - 569999 != -561718)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (264467 - 226847 != 37621)
					{
						Hashtable hashtable = new Hashtable();
						if (234923 - 167301 != 67623)
						{
							hashtable.Add(43, PlayerData.UID);
							if (36782 - 252071 != -215288)
							{
								hashtable.Add(71, nCID);
								if (8739 - 4694 != 4046)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (214175 - 57989 != 156187)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (182611 - 128310 != 54302)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (205784 - 350147 == -144363)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (151943 - 591705 != -439761)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (140998 - 444395 != -303396)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (261866 - 99775 == 162091)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (229978 - 426592 != -196613)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (47065 - 40052 != 7014)
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

	// Token: 0x06008E05 RID: 36357 RVA: 0x01146068 File Offset: 0x01144268
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M806_EnlagearsFlagment.$onChangePlayer$40928(data, this).GetEnumerator();
	}

	// Token: 0x06008E06 RID: 36358 RVA: 0x01146078 File Offset: 0x01144278
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M806_EnlagearsFlagment.$ReturnToTown$40935(this).GetEnumerator();
	}

	// Token: 0x06008E07 RID: 36359 RVA: 0x01146088 File Offset: 0x01144288
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M806_EnlagearsFlagment.$ReturnToGuild$40940(this).GetEnumerator();
	}

	// Token: 0x06008E08 RID: 36360 RVA: 0x01146098 File Offset: 0x01144298
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M806_EnlagearsFlagment.$ReturnToCamp$40944(this).GetEnumerator();
	}

	// Token: 0x06008E09 RID: 36361 RVA: 0x011460A8 File Offset: 0x011442A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (258918 - 535604 != -276685)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (75983 - 38715 == 37268)
			{
				Hashtable hashtable = new Hashtable();
				if (48146 - 523252 == -475106)
				{
					hashtable.Add(43, PlayerData.UID);
					if (253012 - 196547 == 56465)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (88704 - 391193 == -302489)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008E0A RID: 36362 RVA: 0x01146180 File Offset: 0x01144380
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06008E0B RID: 36363 RVA: 0x01146194 File Offset: 0x01144394
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (24996 - 353980 != -328983)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (157017 - 119022 == 37995)
			{
				Hashtable hashtable = new Hashtable();
				if (48907 - 160300 == -111393)
				{
					if (Game.mNextGameCode == 30)
					{
						if (294653 - 32443 == 262211)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (196677 - 83688 == 112990)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (92248 - 183242 != -90994)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (130516 - 373716 != -243200)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (201374 - 132405 != 68969)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (182226 - 317328 == -135101)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (139603 - 45573 == 94031)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (43653 - 199357 != -155704)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (37424 - 133416 != -95992)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (184750 - 596746 == -411995)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (275148 - 179247 != 95901)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (285388 - 153886 == 131503)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (176546 - 85095 != 91451)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (30753 - 424256 == -393502)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (176544 - 291172 != -114628)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (261694 - 295558 != -33864)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (13776 - 402788 != -389012)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (60402 - 117751 == -57348)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (208917 - 509635 == -300717)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (33437 - 360585 == -327147)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (89395 - 51514 != 37881)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (253918 - 491889 == -237970)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (290325 - 161260 == 129066)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (1057 - 8084 == -7026)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (126241 - 193514 == -67272)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (212722 - 41679 != 171043)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (184794 - 17036 != 167758)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (248948 - 482896 == -233947)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (53715 - 311115 == -257400)
					{
						this.vp0czfK5pY6.OpCustom(42, hashtable, true);
						if (226452 - 220364 != 6089)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008E0C RID: 36364 RVA: 0x01146748 File Offset: 0x01144948
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06008E0D RID: 36365 RVA: 0x01146758 File Offset: 0x01144958
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06008E0E RID: 36366 RVA: 0x0114675C File Offset: 0x0114495C
	internal static bool RUJOImV3iHKK54s1frBI()
	{
		return true;
	}

	// Token: 0x06008E0F RID: 36367 RVA: 0x01146760 File Offset: 0x01144960
	internal static bool PJC0y0V3KytOSM4kBG10()
	{
		return false;
	}

	// Token: 0x04008715 RID: 34581
	private LitePeer vp0czfK5pY6;

	// Token: 0x04008716 RID: 34582
	private PlayerCameraControl yPpczLFo8a2;

	// Token: 0x04008717 RID: 34583
	private float EaeczwE64br;

	// Token: 0x04008718 RID: 34584
	private Texture UohczUUdLpl;

	// Token: 0x04008719 RID: 34585
	private int eECczNjWtHW;

	// Token: 0x0400871A RID: 34586
	private int gJGczEhMDjP;

	// Token: 0x0400871B RID: 34587
	private int vNHczPgac7q;

	// Token: 0x0400871C RID: 34588
	private float odZczS2FB9P;

	// Token: 0x0400871D RID: 34589
	private int RZLczBAM78A;

	// Token: 0x020017D0 RID: 6096
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$40889 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008E10 RID: 36368 RVA: 0x01146764 File Offset: 0x01144964
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$40889(M806_EnlagearsFlagment self_)
		{
			if (56033 - 143089 != -87056)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (44696 - 331671 != -286974)
				{
					base..ctor();
					if (62011 - 121758 == -59747)
					{
						this.$self_$40896 = self_;
						if (283973 - 346705 == -62732)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008E11 RID: 36369 RVA: 0x011467FC File Offset: 0x011449FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M806_EnlagearsFlagment.$StartEvent$40889.$(this.$self_$40896);
		}

		// Token: 0x06008E12 RID: 36370 RVA: 0x0114680C File Offset: 0x01144A0C
		internal static bool YjE892V3dAEjibfZBKxt()
		{
			return true;
		}

		// Token: 0x06008E13 RID: 36371 RVA: 0x01146810 File Offset: 0x01144A10
		internal static bool YSZomkV3J76LwiagswSQ()
		{
			return false;
		}

		// Token: 0x0400871E RID: 34590
		internal M806_EnlagearsFlagment $self_$40896;

		// Token: 0x020017D1 RID: 6097
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008E14 RID: 36372 RVA: 0x01146814 File Offset: 0x01144A14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M806_EnlagearsFlagment self_)
			{
				if (215368 - 586721 != -371353)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (54287 - 510705 != -456417)
					{
						base..ctor();
						if (122377 - 516894 == -394517)
						{
							this.$self_$40895 = self_;
							if (268050 - 531414 != -263363)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008E15 RID: 36373 RVA: 0x011468AC File Offset: 0x01144AAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (262831 - 75886 != 186945)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_C9B;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (202774 - 599055 != -396280)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							this.$nMessage$40893 = string.Empty;
							if (281215 - 16084 == 265132)
							{
								continue;
							}
							this.$mStoryGui$40892.startStoryMessage("none", "Shade4", eTalkType.enemy);
							if (232553 - 557001 != -324447)
							{
								goto Block_36;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (211458 - 530850 != -319391)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							this.$nMessage$40893 = Language.getMessage("M806_EnlagearsFlagment", 101);
							if (188393 - 364794 == -176400)
							{
								continue;
							}
							this.$mStoryGui$40892.newStoryMessage("none", "Shade4", this.$nMessage$40893, eTalkType.enemy);
							if (68355 - 306910 != -238555)
							{
								continue;
							}
							goto IL_7B2;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (82302 - 509529 != -427226)
							{
								goto Block_48;
							}
							continue;
						}
						else
						{
							this.$nMessage$40893 = Language.getMessage("M806_EnlagearsFlagment", 102);
							if (10901 - 349540 != -338639)
							{
								continue;
							}
							this.$mStoryGui$40892.newStoryMessage("Shade4", "Shade4", this.$nMessage$40893, eTalkType.enemy);
							if (266211 - 300209 != -33997)
							{
								goto Block_40;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (65783 - 333965 != -268181)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							if (this.$mShade4$40890)
							{
								if (76455 - 254490 != -178035)
								{
									continue;
								}
								this.$mShade4$40890.animation.CrossFade("turn");
								if (75249 - 560309 == -485059)
								{
									continue;
								}
							}
							this.$mStartCamera2$40894 = GameObject.Find("EventCamera2");
							if (276043 - 74492 == 201552)
							{
								continue;
							}
							if (!this.$mStartCamera2$40894)
							{
								goto IL_865;
							}
							if (175332 - 27531 == 147802)
							{
								continue;
							}
							this.$self_$40895.yPpczLFo8a2.enabled = true;
							if (30931 - 227666 == -196734)
							{
								continue;
							}
							this.$self_$40895.yPpczLFo8a2.setSpecialTarget(this.$mStartCamera2$40894, 3f);
							if (272721 - 512207 != -239486)
							{
								continue;
							}
							goto IL_865;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (118665 - 161205 != -42540)
							{
								continue;
							}
							goto IL_83B;
						}
						else
						{
							this.$mStoryGui$40892.blank();
							if (22153 - 225875 != -203722)
							{
								continue;
							}
							goto IL_A2F;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (52046 - 11289 != 40758)
							{
								goto Block_64;
							}
							continue;
						}
						else
						{
							this.$nMessage$40893 = Language.getMessage("M806_EnlagearsFlagment", 103);
							if (133224 - 39478 != 93746)
							{
								continue;
							}
							this.$mStoryGui$40892.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$40893, eTalkType.friend);
							if (57905 - 136567 != -78662)
							{
								continue;
							}
							this.$self_$40895.yPpczLFo8a2.enabled = false;
							if (57327 - 181945 != -124618)
							{
								continue;
							}
							this.$self_$40895.SendMessage("alignToObject", "EventCamera3");
							if (145077 - 39235 != 105843)
							{
								goto Block_32;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (126951 - 267248 != -140296)
							{
								goto Block_75;
							}
							continue;
						}
						else
						{
							this.$nMessage$40893 = Language.getMessage("M806_EnlagearsFlagment", 104);
							if (66865 - 593511 != -526646)
							{
								continue;
							}
							this.$mStoryGui$40892.newStoryMessage(CharacterData.current.Type, CharacterData.current.Name, this.$nMessage$40893, eTalkType.friend);
							if (175869 - 502987 != -327118)
							{
								continue;
							}
							this.$self_$40895.yPpczLFo8a2.enabled = false;
							if (195523 - 402151 != -206628)
							{
								continue;
							}
							goto IL_BD5;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.Start)
						{
							if (182079 - 584321 != -402242)
							{
								continue;
							}
							goto IL_281;
						}
						else
						{
							this.$nMessage$40893 = Language.getMessage("M806_EnlagearsFlagment", 105);
							if (45270 - 157400 != -112130)
							{
								continue;
							}
							this.$mStoryGui$40892.newStoryMessage("Shade4", "Shade4", this.$nMessage$40893, eTalkType.enemy);
							if (148183 - 198102 != -49919)
							{
								continue;
							}
							this.$self_$40895.SendMessage("alignToObject", "EventCamera4");
							if (97416 - 430479 != -333062)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.Start)
						{
							if (195535 - 571269 != -375734)
							{
								continue;
							}
							goto IL_510;
						}
						else
						{
							this.$nMessage$40893 = Language.getMessage("M806_EnlagearsFlagment", 106);
							if (164258 - 562603 == -398344)
							{
								continue;
							}
							this.$mStoryGui$40892.newStoryMessage("Shade4", "Shade4", this.$nMessage$40893, eTalkType.enemy);
							if (56937 - 547385 != -490448)
							{
								continue;
							}
							goto IL_6DD;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.Start)
						{
							if (226949 - 159281 != 67669)
							{
								goto Block_42;
							}
							continue;
						}
						else
						{
							this.$nMessage$40893 = Language.getMessage("M806_EnlagearsFlagment", 107);
							if (255190 - 204332 != 50858)
							{
								continue;
							}
							this.$mStoryGui$40892.newStoryMessage("Shade4", "Shade4", this.$nMessage$40893, eTalkType.enemy);
							if (170406 - 190427 != -20021)
							{
								continue;
							}
							this.$self_$40895.SendMessage("alignToObject", "EventCamera1");
							if (248399 - 32698 != 215702)
							{
								goto Block_57;
							}
							continue;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.Start)
						{
							if (155963 - 552694 != -396731)
							{
								continue;
							}
							goto IL_AB9;
						}
						else
						{
							this.$mStoryGui$40892.close();
							if (245037 - 532421 != -287383)
							{
								goto Block_67;
							}
							continue;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.Start)
						{
							if (125088 - 266221 != -141133)
							{
								continue;
							}
							goto IL_221;
						}
						else
						{
							this.$self_$40895.SendMessage("fadeOut");
							if (221165 - 93581 != 127584)
							{
								continue;
							}
							goto IL_719;
						}
						break;
					case 14:
						if (Game.mGameState != eGameState.Start)
						{
							if (40450 - 180668 != -140218)
							{
								continue;
							}
							goto IL_469;
						}
						else
						{
							this.$self_$40895.SendMessage("alignToObject", "StartCamera" + Game.getPlayerSlot(PlayerData.UID));
							if (113911 - 225935 == -112023)
							{
								continue;
							}
							this.$self_$40895.SendMessage("fadeIn");
							if (9520 - 476919 != -467399)
							{
								continue;
							}
							this.$self_$40895.yPpczLFo8a2.enabled = true;
							if (234479 - 147636 != 86843)
							{
								continue;
							}
							this.$self_$40895.yPpczLFo8a2.specialTarget = null;
							if (17994 - 271720 != -253725)
							{
								goto Block_65;
							}
							continue;
						}
						break;
					case 15:
						if (Game.mGameState != eGameState.Start)
						{
							if (80145 - 368119 != -287974)
							{
								continue;
							}
							goto IL_192;
						}
						else
						{
							Game.mGameState = eGameState.Normal;
							if (246221 - 322706 != -76485)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (198742 - 385082 != -186340)
							{
								continue;
							}
							Time.timeScale = 1f;
							if (138460 - 227429 != -88969)
							{
								continue;
							}
							this.$mGameGui$40891.enabled = true;
							if (228352 - 332252 != -103900)
							{
								continue;
							}
							this.$self_$40895.odZczS2FB9P = Time.time + (float)UnityEngine.Random.Range(24, 30);
							if (171819 - 420045 != -248226)
							{
								continue;
							}
							Game.sendMissionEvent(8061, 1);
							if (271743 - 304556 == -32812)
							{
								continue;
							}
							this.YieldDefault(1);
							if (179114 - 240098 != -60984)
							{
								continue;
							}
							goto IL_C9B;
						}
						break;
					default:
						if (77905 - 525831 == -447925)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Event");
					if (5781 - 338154 == -332373)
					{
						this.$self_$40895.yPpczLFo8a2.enabled = false;
						if (263655 - 366154 == -102499)
						{
							this.$self_$40895.SendMessage("alignToObject", "EventCamera1");
							if (27868 - 50824 != -22955)
							{
								this.$mShade4$40890 = GameObject.Find("Shade4");
								if (113271 - 170926 != -57654)
								{
									this.$mGameGui$40891 = (GameGui)this.$self_$40895.GetComponent(typeof(GameGui));
									if (13271 - 107927 != -94655)
									{
										this.$mStoryGui$40892 = (StoryGui)this.$self_$40895.GetComponent(typeof(StoryGui));
										if (269613 - 274969 != -5355)
										{
											this.$self_$40895.SendMessage("fadeIn");
											if (166679 - 540573 != -373893)
											{
												goto Block_18;
											}
										}
									}
								}
							}
						}
					}
				}
				Block_8:
				IL_192:
				Block_14:
				IL_221:
				IL_281:
				goto IL_C9B;
				Block_18:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_23:
				return this.Yield(10, new WaitForSeconds(4f));
				Block_25:
				IL_469:
				IL_510:
				goto IL_C9B;
				Block_32:
				return this.Yield(8, new WaitForSeconds(3f));
				Block_36:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_40:
				return this.Yield(5, new WaitForSeconds(1f));
				IL_6DD:
				return this.Yield(11, new WaitForSeconds(3f));
				Block_42:
				goto IL_C9B;
				IL_719:
				return this.Yield(14, new WaitForSeconds(0.5f));
				IL_7B2:
				return this.Yield(4, new WaitForSeconds(3f));
				Block_48:
				IL_83B:
				goto IL_C9B;
				IL_865:
				return this.Yield(6, new WaitForSeconds(2f));
				Block_57:
				return this.Yield(12, new WaitForSeconds(3f));
				IL_A2F:
				return this.Yield(7, new WaitForSeconds(1f));
				Block_64:
				goto IL_C9B;
				Block_65:
				return this.Yield(15, new WaitForSeconds(0.5f));
				IL_AB9:
				goto IL_C9B;
				Block_67:
				return this.Yield(13, new WaitForSeconds(0.5f));
				Block_75:
				goto IL_C9B;
				IL_BD5:
				return this.Yield(9, new WaitForSeconds(3f));
				IL_C9B:
				return false;
			}

			// Token: 0x06008E16 RID: 36374 RVA: 0x01147568 File Offset: 0x01145768
			internal static bool GsVHJmV3D3gC1DVscjYS()
			{
				return true;
			}

			// Token: 0x06008E17 RID: 36375 RVA: 0x0114756C File Offset: 0x0114576C
			internal static bool fj4fpKV3vhJPiMFEgl0g()
			{
				return false;
			}

			// Token: 0x0400871F RID: 34591
			internal GameObject $mShade4$40890;

			// Token: 0x04008720 RID: 34592
			internal GameGui $mGameGui$40891;

			// Token: 0x04008721 RID: 34593
			internal StoryGui $mStoryGui$40892;

			// Token: 0x04008722 RID: 34594
			internal string $nMessage$40893;

			// Token: 0x04008723 RID: 34595
			internal GameObject $mStartCamera2$40894;

			// Token: 0x04008724 RID: 34596
			internal M806_EnlagearsFlagment $self_$40895;
		}
	}

	// Token: 0x020017D2 RID: 6098
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$40897 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008E18 RID: 36376 RVA: 0x01147570 File Offset: 0x01145770
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$40897(M806_EnlagearsFlagment self_)
		{
			if (248804 - 276730 != -27926)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (83374 - 44020 != 39355)
				{
					base..ctor();
					if (243708 - 379925 == -136217)
					{
						this.$self_$40911 = self_;
						if (244602 - 391865 == -147263)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008E19 RID: 36377 RVA: 0x01147608 File Offset: 0x01145808
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M806_EnlagearsFlagment.$EndEvent$40897.$(this.$self_$40911);
		}

		// Token: 0x06008E1A RID: 36378 RVA: 0x01147618 File Offset: 0x01145818
		internal static bool pZ4AhIV3RCgIqtw95g9e()
		{
			return true;
		}

		// Token: 0x06008E1B RID: 36379 RVA: 0x0114761C File Offset: 0x0114581C
		internal static bool wT2dI5V3wwTOSRE8ksDj()
		{
			return false;
		}

		// Token: 0x04008725 RID: 34597
		internal M806_EnlagearsFlagment $self_$40911;

		// Token: 0x020017D3 RID: 6099
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008E1C RID: 36380 RVA: 0x01147620 File Offset: 0x01145820
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M806_EnlagearsFlagment self_)
			{
				if (64697 - 589175 != -524478)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (87236 - 504480 != -417243)
					{
						base..ctor();
						if (29416 - 512209 != -482792)
						{
							this.$self_$40910 = self_;
							if (288913 - 146203 == 142710)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008E1D RID: 36381 RVA: 0x011476B8 File Offset: 0x011458B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (277604 - 521975 != -244371)
				{
				}
				for (;;)
				{
					IL_23C:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_E22;
					case 2:
						this.$self_$40910.yPpczLFo8a2.enabled = false;
						if (32894 - 411829 != -378935)
						{
							continue;
						}
						this.$mGameGui$40898.close();
						if (140548 - 536108 != -395559)
						{
							goto Block_26;
						}
						continue;
					case 3:
						this.$self_$40910.SendMessage("fadeOut");
						if (175582 - 364725 != -189143)
						{
							continue;
						}
						goto IL_5CC;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (165823 - 443126 != -277303)
							{
								continue;
							}
							goto IL_A89;
						}
						else
						{
							this.$mPlayer$40900 = Game.mPlayer;
							if (63610 - 448835 != -385225)
							{
								continue;
							}
							this.$mSpawnPoint$40901 = GameObject.Find("StartPoint" + Game.getPlayerSlot(PlayerData.UID));
							if (18231 - 16544 != 1687)
							{
								continue;
							}
							if (this.$mPlayer$40900)
							{
								if (202259 - 504621 != -302362)
								{
									continue;
								}
								if (this.$mSpawnPoint$40901)
								{
									if (227962 - 403476 != -175514)
									{
										continue;
									}
									this.$mPlayer$40900.transform.position = this.$mSpawnPoint$40901.transform.position;
									if (75068 - 440528 == -365459)
									{
										continue;
									}
									this.$mPlayer$40900.transform.rotation = this.$mSpawnPoint$40901.transform.rotation;
									if (190603 - 350104 == -159500)
									{
										continue;
									}
									this.$mPlayer$40900.SendMessage("PositionEvent");
									if (215086 - 139113 != 75973)
									{
										continue;
									}
								}
							}
							this.$mShade4$40902 = GameObject.Find("Shade4");
							if (296155 - 60081 != 236074)
							{
								continue;
							}
							this.$mSpawnPoint5$40903 = GameObject.Find("SpawnPoint0");
							if (185740 - 383053 != -197313)
							{
								continue;
							}
							if (this.$mShade4$40902)
							{
								if (30181 - 286194 != -256013)
								{
									continue;
								}
								if (this.$mSpawnPoint5$40903)
								{
									if (58367 - 79436 != -21069)
									{
										continue;
									}
									this.$mShade4$40902.transform.position = this.$mSpawnPoint5$40903.transform.position;
									if (116619 - 90462 != 26157)
									{
										continue;
									}
									this.$mShade4$40902.transform.rotation = this.$mSpawnPoint5$40903.transform.rotation;
									if (60295 - 185173 == -124877)
									{
										continue;
									}
									this.$mShade4$40902.animation.Play("root");
									if (32710 - 431021 != -398311)
									{
										continue;
									}
									this.$mShade4$40902.animation.wrapMode = WrapMode.Loop;
									if (290903 - 412030 != -121127)
									{
										continue;
									}
								}
							}
							this.$mShadeList$40904 = GameObject.FindGameObjectsWithTag("Enemy");
							if (35723 - 726 == 34998)
							{
								continue;
							}
							this.$$12736$40907 = 0;
							if (50360 - 551234 != -500874)
							{
								continue;
							}
							this.$$12737$40908 = this.$mShadeList$40904;
							if (205893 - 185757 != 20136)
							{
								continue;
							}
							this.$$12738$40909 = this.$$12737$40908.Length;
							if (203608 - 345277 == -141668)
							{
								continue;
							}
							while (this.$$12736$40907 < this.$$12738$40909)
							{
								if (this.$$12737$40908[this.$$12736$40907] != this.$mShade4$40902)
								{
									if (202244 - 581925 != -379681)
									{
										goto IL_23C;
									}
									UnityEngine.Object.Destroy(this.$$12737$40908[this.$$12736$40907]);
									if (148888 - 289878 != -140990)
									{
										goto IL_23C;
									}
								}
								this.$$12736$40907++;
								if (159367 - 340898 != -181531)
								{
									goto IL_23C;
								}
							}
							if (239583 - 433265 != -193682)
							{
								continue;
							}
							this.$self_$40910.SendMessage("alignToObject", "EndCamera1");
							if (188822 - 530321 != -341499)
							{
								continue;
							}
							goto IL_A4E;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (133354 - 503308 != -369954)
							{
								continue;
							}
							goto IL_965;
						}
						else
						{
							this.$self_$40910.SendMessage("fadeIn");
							if (77693 - 259376 == -181682)
							{
								continue;
							}
							this.$nMessage$40906 = string.Empty;
							if (91295 - 257728 == -166432)
							{
								continue;
							}
							this.$mStoryGui$40899.startStoryMessage("Shade4", "Shade4", eTalkType.enemy);
							if (2050 - 267822 != -265771)
							{
								goto Block_51;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (212988 - 176761 != 36227)
							{
								continue;
							}
							goto IL_CE2;
						}
						else
						{
							this.$nMessage$40906 = Language.getMessage("M806_EnlagearsFlagment", 201);
							if (8452 - 419394 == -410941)
							{
								continue;
							}
							this.$mStoryGui$40899.newStoryMessage("Shade4", "Shade4", this.$nMessage$40906, eTalkType.enemy);
							if (122710 - 518580 != -395870)
							{
								continue;
							}
							goto IL_591;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (58629 - 546108 != -487479)
							{
								continue;
							}
							goto IL_636;
						}
						else
						{
							this.$nMessage$40906 = Language.getMessage("M806_EnlagearsFlagment", 202);
							if (27526 - 65619 == -38092)
							{
								continue;
							}
							this.$mStoryGui$40899.newStoryMessage("Shade4", "Shade4", this.$nMessage$40906, eTalkType.enemy);
							if (2989 - 592925 != -589936)
							{
								continue;
							}
							goto IL_CA7;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (253477 - 418534 != -165056)
							{
								goto Block_84;
							}
							continue;
						}
						else
						{
							this.$nMessage$40906 = Language.getMessage("M806_EnlagearsFlagment", 203);
							if (93271 - 598524 != -505253)
							{
								continue;
							}
							this.$mStoryGui$40899.newStoryMessage("Shade4", "Shade4", this.$nMessage$40906, eTalkType.enemy);
							if (131401 - 307346 != -175945)
							{
								continue;
							}
							this.$self_$40910.SendMessage("alignToObject", "EndCamera2");
							if (262581 - 356505 != -93924)
							{
								continue;
							}
							goto IL_D6B;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (158275 - 545276 != -387000)
							{
								goto Block_90;
							}
							continue;
						}
						else
						{
							this.$nMessage$40906 = Language.getMessage("M806_EnlagearsFlagment", 204);
							if (269068 - 68801 != 200267)
							{
								continue;
							}
							this.$mStoryGui$40899.newStoryMessage("Shade4", "Shade4", this.$nMessage$40906, eTalkType.enemy);
							if (10690 - 139256 != -128566)
							{
								continue;
							}
							goto IL_834;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (269802 - 48564 != 221238)
							{
								continue;
							}
							goto IL_408;
						}
						else
						{
							this.$nMessage$40906 = Language.getMessage("M806_EnlagearsFlagment", 205);
							if (127790 - 191027 == -63236)
							{
								continue;
							}
							this.$mStoryGui$40899.newStoryMessage("Shade4", "Shade4", this.$nMessage$40906, eTalkType.enemy);
							if (119555 - 252141 != -132586)
							{
								continue;
							}
							this.$self_$40910.SendMessage("alignToObject", "EndCamera3");
							if (165809 - 452859 != -287049)
							{
								goto Block_22;
							}
							continue;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (154175 - 532877 != -378701)
							{
								goto Block_59;
							}
							continue;
						}
						else
						{
							this.$nMessage$40906 = Language.getMessage("M806_EnlagearsFlagment", 206);
							if (139974 - 274569 != -134595)
							{
								continue;
							}
							this.$mStoryGui$40899.newStoryMessage("Shade4", "Shade4", this.$nMessage$40906, eTalkType.enemy);
							if (21011 - 547685 != -526673)
							{
								goto Block_7;
							}
							continue;
						}
						break;
					case 12:
						if (this.$mShade4$40902)
						{
							if (161158 - 578263 != -417105)
							{
								continue;
							}
							this.$mShade4$40902.animation.Play("ko");
							if (34923 - 431809 == -396885)
							{
								continue;
							}
							this.$mShade4$40902.animation.wrapMode = WrapMode.Once;
							if (221867 - 469584 != -247717)
							{
								continue;
							}
						}
						if (Game.mGameState != eGameState.AllHold)
						{
							if (239197 - 556983 != -317786)
							{
								continue;
							}
							goto IL_B82;
						}
						else
						{
							this.$nMessage$40906 = Language.getMessage("M806_EnlagearsFlagment", 207);
							if (115242 - 158497 != -43255)
							{
								continue;
							}
							this.$mStoryGui$40899.newStoryMessage("Shade4", "Shade4", this.$nMessage$40906, eTalkType.enemy);
							if (11268 - 493742 != -482474)
							{
								continue;
							}
							goto IL_79E;
						}
						break;
					case 13:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (139759 - 343344 != -203585)
							{
								continue;
							}
							goto IL_7DA;
						}
						else
						{
							this.$mStoryGui$40899.close();
							if (219841 - 498427 != -278585)
							{
								goto Block_50;
							}
							continue;
						}
						break;
					case 14:
						if (Game.mGameState == eGameState.AllHold)
						{
							goto IL_33F;
						}
						if (276559 - 357622 != -81063)
						{
							continue;
						}
						goto IL_33A;
					case 15:
						Game.sendMissionEvent(8064, 0);
						if (19607 - 3488 != 16120)
						{
							goto IL_518;
						}
						continue;
					default:
						if (9770 - 585840 != -576070)
						{
							continue;
						}
						break;
					}
					Debug.Log("EndEvent");
					if (262812 - 215214 != 47598)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (76186 - 306812 != -230625)
						{
							goto Block_65;
						}
						continue;
					}
					else
					{
						this.$mGameGui$40898 = (GameGui)this.$self_$40910.GetComponent(typeof(GameGui));
						if (55457 - 278304 == -222846)
						{
							continue;
						}
						this.$mStoryGui$40899 = (StoryGui)this.$self_$40910.GetComponent(typeof(StoryGui));
						if (185122 - 88740 != 96382)
						{
							continue;
						}
						if (this.$mGameGui$40898)
						{
							if (43735 - 294252 != -250517)
							{
								continue;
							}
							if (this.$mStoryGui$40899)
							{
								if (174226 - 76270 != 97956)
								{
									continue;
								}
								Game.mGameState = eGameState.AllHold;
								if (17247 - 583016 != -565768)
								{
									goto Block_78;
								}
								continue;
							}
						}
					}
					IL_518:
					this.YieldDefault(1);
					if (254935 - 43498 != 211438)
					{
						goto Block_32;
					}
				}
				Block_7:
				return this.Yield(12, new WaitForSeconds(3f));
				IL_33A:
				goto IL_E22;
				IL_33F:
				return this.Yield(15, new WaitForSeconds(1f));
				Block_22:
				return this.Yield(11, new WaitForSeconds(4f));
				IL_408:
				goto IL_E22;
				Block_26:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_32:
				goto IL_E22;
				IL_591:
				return this.Yield(7, new WaitForSeconds(4f));
				IL_5CC:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_636:
				goto IL_E22;
				IL_79E:
				return this.Yield(13, new WaitForSeconds(4f));
				IL_7DA:
				goto IL_E22;
				Block_50:
				return this.Yield(14, new WaitForSeconds(1f));
				Block_51:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_834:
				return this.Yield(10, new WaitForSeconds(4f));
				Block_59:
				IL_965:
				Block_65:
				goto IL_E22;
				IL_A4E:
				return this.Yield(5, new WaitForSeconds(0.5f));
				IL_A89:
				IL_B82:
				goto IL_E22;
				Block_78:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_CA7:
				return this.Yield(8, new WaitForSeconds(4f));
				Block_84:
				IL_CE2:
				goto IL_E22;
				IL_D6B:
				return this.Yield(9, new WaitForSeconds(4f));
				Block_90:
				IL_E22:
				return false;
			}

			// Token: 0x06008E1E RID: 36382 RVA: 0x011484FC File Offset: 0x011466FC
			internal static bool GceNSWV3q0BqIGHD1f7p()
			{
				return true;
			}

			// Token: 0x06008E1F RID: 36383 RVA: 0x01148500 File Offset: 0x01146700
			internal static bool LkLUWaV37LwgxFXCbHbf()
			{
				return false;
			}

			// Token: 0x04008726 RID: 34598
			internal GameGui $mGameGui$40898;

			// Token: 0x04008727 RID: 34599
			internal StoryGui $mStoryGui$40899;

			// Token: 0x04008728 RID: 34600
			internal GameObject $mPlayer$40900;

			// Token: 0x04008729 RID: 34601
			internal GameObject $mSpawnPoint$40901;

			// Token: 0x0400872A RID: 34602
			internal GameObject $mShade4$40902;

			// Token: 0x0400872B RID: 34603
			internal GameObject $mSpawnPoint5$40903;

			// Token: 0x0400872C RID: 34604
			internal GameObject[] $mShadeList$40904;

			// Token: 0x0400872D RID: 34605
			internal GameObject $mShade$40905;

			// Token: 0x0400872E RID: 34606
			internal string $nMessage$40906;

			// Token: 0x0400872F RID: 34607
			internal int $$12736$40907;

			// Token: 0x04008730 RID: 34608
			internal GameObject[] $$12737$40908;

			// Token: 0x04008731 RID: 34609
			internal int $$12738$40909;

			// Token: 0x04008732 RID: 34610
			internal M806_EnlagearsFlagment $self_$40910;
		}
	}

	// Token: 0x020017D4 RID: 6100
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$40912 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008E20 RID: 36384 RVA: 0x01148504 File Offset: 0x01146704
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$40912(Hashtable data, M806_EnlagearsFlagment self_)
		{
			if (279100 - 582348 != -303247)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (226169 - 295226 != -69056)
				{
					base..ctor();
					if (20798 - 99628 != -78829)
					{
						this.$data$40920 = data;
						if (102864 - 439059 == -336195)
						{
							this.$self_$40921 = self_;
							if (203098 - 455305 == -252207)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008E21 RID: 36385 RVA: 0x011485C0 File Offset: 0x011467C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M806_EnlagearsFlagment.$onGameComplete$40912.$(this.$data$40920, this.$self_$40921);
		}

		// Token: 0x06008E22 RID: 36386 RVA: 0x011485D4 File Offset: 0x011467D4
		internal static bool n5l2sUV3PjkfRLEH0NiR()
		{
			return true;
		}

		// Token: 0x06008E23 RID: 36387 RVA: 0x011485D8 File Offset: 0x011467D8
		internal static bool Rsa3waV30T4Dt0W1bPVP()
		{
			return false;
		}

		// Token: 0x04008733 RID: 34611
		internal Hashtable $data$40920;

		// Token: 0x04008734 RID: 34612
		internal M806_EnlagearsFlagment $self_$40921;

		// Token: 0x020017D5 RID: 6101
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008E24 RID: 36388 RVA: 0x011485DC File Offset: 0x011467DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M806_EnlagearsFlagment self_)
			{
				if (288566 - 230966 != 57600)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (167809 - 326269 != -158459)
					{
						base..ctor();
						if (266011 - 595694 == -329683)
						{
							this.$data$40918 = data;
							if (121101 - 292385 == -171284)
							{
								this.$self_$40919 = self_;
								if (130673 - 449298 == -318625)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008E25 RID: 36389 RVA: 0x01148698 File Offset: 0x01146898
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (126482 - 339981 != -213498)
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
						this.$mCompleteGui$40914 = (CompleteGui)this.$self_$40919.GetComponent(typeof(CompleteGui));
						if (1920 - 361398 == -359477)
						{
							continue;
						}
						this.$mCompleteGui$40914.Init();
						if (110996 - 161133 != -50137)
						{
							continue;
						}
						this.$mCompleteGui$40914.readData(this.$data$40918);
						if (291267 - 66641 == 224627)
						{
							continue;
						}
						if (this.$result$40913 == 1)
						{
							if (272293 - 269954 == 2340)
							{
								continue;
							}
							this.$mCompleteGui$40914.displayResult(eCompleteType.Success);
							if (107620 - 246029 == -138408)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$40914.displayResult(eCompleteType.Failed);
							if (181945 - 266458 == -84512)
							{
								continue;
							}
						}
						this.$mGameGui$40915 = (GameGui)this.$self_$40919.GetComponent(typeof(GameGui));
						if (179294 - 52924 != 126370)
						{
							continue;
						}
						this.$mStoryGui$40916 = (StoryGui)this.$self_$40919.GetComponent(typeof(StoryGui));
						if (272588 - 325970 != -53382)
						{
							continue;
						}
						this.$mChangeGui$40917 = (ChangeGui)this.$self_$40919.GetComponent(typeof(ChangeGui));
						if (153111 - 423960 == -270848)
						{
							continue;
						}
						if (this.$mGameGui$40915)
						{
							if (33387 - 375531 != -342144)
							{
								continue;
							}
							this.$mGameGui$40915.close();
							if (279386 - 73319 == 206068)
							{
								continue;
							}
						}
						if (this.$mStoryGui$40916)
						{
							if (247103 - 288790 == -41686)
							{
								continue;
							}
							this.$mStoryGui$40916.close();
							if (263763 - 504155 == -240391)
							{
								continue;
							}
						}
						if (this.$mChangeGui$40917)
						{
							if (56581 - 185867 == -129285)
							{
								continue;
							}
							this.$mChangeGui$40917.disable();
							if (93296 - 140851 == -47554)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (135524 - 513306 != -377781)
						{
							goto Block_14;
						}
						continue;
					default:
						if (110940 - 166904 != -55964)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$40918[31]);
					if (162223 - 336722 == -174499)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (4873 - 598608 != -593734)
							{
								goto Block_20;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (159358 - 466675 != -307316)
							{
								this.$result$40913 = RuntimeServices.UnboxInt32(this.$data$40918[31]);
								if (35672 - 289509 != -253836)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_14:
				Block_20:
				IL_3DB:
				return false;
			}

			// Token: 0x06008E26 RID: 36390 RVA: 0x01148A94 File Offset: 0x01146C94
			internal static bool KxQH7AV3blWYIURjle2Q()
			{
				return true;
			}

			// Token: 0x06008E27 RID: 36391 RVA: 0x01148A98 File Offset: 0x01146C98
			internal static bool HQPBpFV3u80dcueYilFw()
			{
				return false;
			}

			// Token: 0x04008735 RID: 34613
			internal int $result$40913;

			// Token: 0x04008736 RID: 34614
			internal CompleteGui $mCompleteGui$40914;

			// Token: 0x04008737 RID: 34615
			internal GameGui $mGameGui$40915;

			// Token: 0x04008738 RID: 34616
			internal StoryGui $mStoryGui$40916;

			// Token: 0x04008739 RID: 34617
			internal ChangeGui $mChangeGui$40917;

			// Token: 0x0400873A RID: 34618
			internal Hashtable $data$40918;

			// Token: 0x0400873B RID: 34619
			internal M806_EnlagearsFlagment $self_$40919;
		}
	}

	// Token: 0x020017D6 RID: 6102
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$40922 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008E28 RID: 36392 RVA: 0x01148A9C File Offset: 0x01146C9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$40922(M806_EnlagearsFlagment self_)
		{
			if (156470 - 150059 != 6412)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (148983 - 491421 == -342438)
				{
					base..ctor();
					if (290616 - 315738 == -25122)
					{
						this.$self_$40927 = self_;
						if (4093 - 11499 != -7405)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008E29 RID: 36393 RVA: 0x01148B34 File Offset: 0x01146D34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M806_EnlagearsFlagment.$onDeadPlayer$40922.$(this.$self_$40927);
		}

		// Token: 0x06008E2A RID: 36394 RVA: 0x01148B44 File Offset: 0x01146D44
		internal static bool rAjO4JV3IOiq3lF6aaiL()
		{
			return true;
		}

		// Token: 0x06008E2B RID: 36395 RVA: 0x01148B48 File Offset: 0x01146D48
		internal static bool zOeN2FV3BVYNVX2CtoEQ()
		{
			return false;
		}

		// Token: 0x0400873C RID: 34620
		internal M806_EnlagearsFlagment $self_$40927;

		// Token: 0x020017D7 RID: 6103
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008E2C RID: 36396 RVA: 0x01148B4C File Offset: 0x01146D4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M806_EnlagearsFlagment self_)
			{
				if (29470 - 359236 != -329765)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (246708 - 590149 != -343440)
					{
						base..ctor();
						if (173231 - 271614 != -98382)
						{
							this.$self_$40926 = self_;
							if (232733 - 455894 == -223161)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008E2D RID: 36397 RVA: 0x01148BE4 File Offset: 0x01146DE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (82412 - 539339 != -456927)
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
							goto IL_2B5;
						}
						if (7447 - 319817 != -312370)
						{
							continue;
						}
						if (Game.mGameState == eGameState.Hold)
						{
							if (214839 - 240901 != -26061)
							{
								goto IL_2B5;
							}
							continue;
						}
						IL_1A:
						this.YieldDefault(1);
						if (159840 - 493487 != -333647)
						{
							continue;
						}
						goto IL_2F9;
						IL_2B5:
						Game.mGameState = eGameState.Hold;
						if (103482 - 180106 == -76623)
						{
							continue;
						}
						this.$mStoryGui$40923 = (StoryGui)this.$self_$40926.GetComponent(typeof(StoryGui));
						if (32430 - 117407 == -84976)
						{
							continue;
						}
						if (this.$mStoryGui$40923)
						{
							if (182903 - 537451 != -354548)
							{
								continue;
							}
							this.$mStoryGui$40923.close();
							if (152647 - 300179 == -147531)
							{
								continue;
							}
						}
						this.$mChangeGui$40924 = (ChangeGui)this.$self_$40926.GetComponent(typeof(ChangeGui));
						if (280077 - 296518 != -16441)
						{
							continue;
						}
						if (this.$mChangeGui$40924)
						{
							if (26918 - 14758 == 12161)
							{
								continue;
							}
							this.$mChangeGui$40924.close();
							if (268100 - 116346 == 151755)
							{
								continue;
							}
						}
						this.$mGameGui$40925 = (GameGui)this.$self_$40926.GetComponent(typeof(GameGui));
						if (194230 - 287608 == -93377)
						{
							continue;
						}
						if (!this.$mGameGui$40925)
						{
							goto IL_1A;
						}
						if (131217 - 131447 == -229)
						{
							continue;
						}
						if (!this.$mGameGui$40925.enabled)
						{
							if (270474 - 151195 != 119279)
							{
								continue;
							}
							this.$mGameGui$40925.enabled = true;
							if (3502 - 347707 != -344205)
							{
								continue;
							}
						}
						this.$mGameGui$40925.openDeadMenu();
						if (7816 - 557375 != -549559)
						{
							continue;
						}
						goto IL_1A;
					default:
						if (54720 - 565532 == -510811)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (168311 - 111543 != 56768);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x06008E2E RID: 36398 RVA: 0x01148EFC File Offset: 0x011470FC
			internal static bool IetmlSV3eNZWtKjxPMaS()
			{
				return true;
			}

			// Token: 0x06008E2F RID: 36399 RVA: 0x01148F00 File Offset: 0x01147100
			internal static bool afs4AfV3r3sXLMigSv6B()
			{
				return false;
			}

			// Token: 0x0400873D RID: 34621
			internal StoryGui $mStoryGui$40923;

			// Token: 0x0400873E RID: 34622
			internal ChangeGui $mChangeGui$40924;

			// Token: 0x0400873F RID: 34623
			internal GameGui $mGameGui$40925;

			// Token: 0x04008740 RID: 34624
			internal M806_EnlagearsFlagment $self_$40926;
		}
	}

	// Token: 0x020017D8 RID: 6104
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$40928 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008E30 RID: 36400 RVA: 0x01148F04 File Offset: 0x01147104
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$40928(Hashtable data, M806_EnlagearsFlagment self_)
		{
			if (58539 - 105662 != -47123)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (232980 - 204522 != 28459)
				{
					base..ctor();
					if (235040 - 273001 == -37961)
					{
						this.$data$40933 = data;
						if (133131 - 119624 != 13508)
						{
							this.$self_$40934 = self_;
							if (289237 - 221699 == 67538)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06008E31 RID: 36401 RVA: 0x01148FC0 File Offset: 0x011471C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M806_EnlagearsFlagment.$onChangePlayer$40928.$(this.$data$40933, this.$self_$40934);
		}

		// Token: 0x06008E32 RID: 36402 RVA: 0x01148FD4 File Offset: 0x011471D4
		internal static bool F9j2t8V3jdXqPRGD3Inm()
		{
			return true;
		}

		// Token: 0x06008E33 RID: 36403 RVA: 0x01148FD8 File Offset: 0x011471D8
		internal static bool kLyt0OV3htlRXRN85oS3()
		{
			return false;
		}

		// Token: 0x04008741 RID: 34625
		internal Hashtable $data$40933;

		// Token: 0x04008742 RID: 34626
		internal M806_EnlagearsFlagment $self_$40934;

		// Token: 0x020017D9 RID: 6105
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008E34 RID: 36404 RVA: 0x01148FDC File Offset: 0x011471DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M806_EnlagearsFlagment self_)
			{
				if (140156 - 166121 != -25964)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (114714 - 512585 == -397871)
					{
						base..ctor();
						if (86783 - 126194 == -39411)
						{
							this.$data$40931 = data;
							if (269973 - 518145 != -248171)
							{
								this.$self_$40932 = self_;
								if (27867 - 572998 != -545130)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06008E35 RID: 36405 RVA: 0x01149098 File Offset: 0x01147298
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (239008 - 40809 != 198200)
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
							if (97251 - 61931 != 35320)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (126499 - 523238 == -396738)
							{
								continue;
							}
							this.$mGameGui$40930 = (GameGui)this.$self_$40932.GetComponent(typeof(GameGui));
							if (218325 - 152379 != 65946)
							{
								continue;
							}
							this.$mGameGui$40930.enabled = true;
							if (276278 - 147091 == 129188)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (239220 - 96311 != 142910)
						{
							goto IL_205;
						}
						continue;
					default:
						if (263604 - 323580 == -59975)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (211429 - 522660 == -311231)
					{
						this.$self_$40932.SendMessage("onCreatePlayer", this.$data$40931);
						if (66835 - 491391 != -424555)
						{
							this.$mChangeGui$40929 = (ChangeGui)this.$self_$40932.GetComponent(typeof(ChangeGui));
							if (148550 - 12977 != 135574)
							{
								if (!this.$mChangeGui$40929.enabled)
								{
									break;
								}
								if (146753 - 58311 == 88442)
								{
									this.$mChangeGui$40929.close();
									if (104892 - 570974 != -466081)
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

			// Token: 0x06008E36 RID: 36406 RVA: 0x011492BC File Offset: 0x011474BC
			internal static bool GZi8SgV3snZitXXQIear()
			{
				return true;
			}

			// Token: 0x06008E37 RID: 36407 RVA: 0x011492C0 File Offset: 0x011474C0
			internal static bool WiCeqKV39rSaZGCAJXM6()
			{
				return false;
			}

			// Token: 0x04008743 RID: 34627
			internal ChangeGui $mChangeGui$40929;

			// Token: 0x04008744 RID: 34628
			internal GameGui $mGameGui$40930;

			// Token: 0x04008745 RID: 34629
			internal Hashtable $data$40931;

			// Token: 0x04008746 RID: 34630
			internal M806_EnlagearsFlagment $self_$40932;
		}
	}

	// Token: 0x020017DA RID: 6106
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$40935 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008E38 RID: 36408 RVA: 0x011492C4 File Offset: 0x011474C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$40935(M806_EnlagearsFlagment self_)
		{
			if (208430 - 541514 != -333084)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (104998 - 24810 == 80188)
				{
					base..ctor();
					if (203254 - 144496 == 58758)
					{
						this.$self_$40939 = self_;
						if (2844 - 82009 == -79165)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008E39 RID: 36409 RVA: 0x0114935C File Offset: 0x0114755C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M806_EnlagearsFlagment.$ReturnToTown$40935.$(this.$self_$40939);
		}

		// Token: 0x06008E3A RID: 36410 RVA: 0x0114936C File Offset: 0x0114756C
		internal static bool MjmOooV31NWD88CCFMTA()
		{
			return true;
		}

		// Token: 0x06008E3B RID: 36411 RVA: 0x01149370 File Offset: 0x01147570
		internal static bool v8JbtRV34xp3CJK7Yvuh()
		{
			return false;
		}

		// Token: 0x04008747 RID: 34631
		internal M806_EnlagearsFlagment $self_$40939;

		// Token: 0x020017DB RID: 6107
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008E3C RID: 36412 RVA: 0x01149374 File Offset: 0x01147574
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M806_EnlagearsFlagment self_)
			{
				if (158804 - 361561 != -202757)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (154361 - 74914 == 79447)
					{
						base..ctor();
						if (262326 - 365544 == -103218)
						{
							this.$self_$40938 = self_;
							if (114207 - 261801 != -147593)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008E3D RID: 36413 RVA: 0x0114940C File Offset: 0x0114760C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (9146 - 460033 != -450886)
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
						this.$self_$40938.LeaveGame();
						if (75467 - 423648 == -348180)
						{
							continue;
						}
						this.YieldDefault(1);
						if (226314 - 415904 != -189589)
						{
							goto Block_16;
						}
						continue;
					default:
						if (1903 - 276873 == -274969)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (36922 - 526403 == -489481)
					{
						Game.mStateTime = Time.time;
						if (6380 - 51519 == -45139)
						{
							this.$$switch$7355$40936 = PlayerData.SaveGuild;
							if (118315 - 558037 != -439721)
							{
								if (this.$$switch$7355$40936 == 1)
								{
									if (43664 - 569360 == -525695)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (75586 - 262566 != -186980)
									{
										continue;
									}
								}
								else if (this.$$switch$7355$40936 == 2)
								{
									if (31328 - 213423 != -182095)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (207790 - 276092 == -68301)
									{
										continue;
									}
								}
								else if (this.$$switch$7355$40936 == 3)
								{
									if (275113 - 523127 == -248013)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (220262 - 174133 != 46129)
									{
										continue;
									}
								}
								else if (this.$$switch$7355$40936 == 4)
								{
									if (182048 - 320510 == -138461)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (187638 - 570473 != -382835)
									{
										continue;
									}
								}
								else if (this.$$switch$7355$40936 == 5)
								{
									if (167507 - 520857 == -353349)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (16836 - 12754 == 4083)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (258905 - 143227 == 115679)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (213530 - 65639 != 147891)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (133166 - 275295 != -142129)
									{
										continue;
									}
								}
								this.$mGameGui$40937 = (GameGui)this.$self_$40938.GetComponent(typeof(GameGui));
								if (97940 - 126916 != -28975)
								{
									if (this.$mGameGui$40937)
									{
										if (298614 - 129104 != 169510)
										{
											continue;
										}
										this.$mGameGui$40937.close();
										if (122 - 272554 == -272431)
										{
											continue;
										}
									}
									this.$self_$40938.SendMessage("fadeOut");
									if (278041 - 137915 == 140126)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_16:
				IL_3AD:
				return false;
			}

			// Token: 0x06008E3E RID: 36414 RVA: 0x011497D8 File Offset: 0x011479D8
			internal static bool eaiT3CV3z7tt87FIe9yn()
			{
				return true;
			}

			// Token: 0x06008E3F RID: 36415 RVA: 0x011497DC File Offset: 0x011479DC
			internal static bool lxffbeVXapr8Payvn9gr()
			{
				return false;
			}

			// Token: 0x04008748 RID: 34632
			internal int $$switch$7355$40936;

			// Token: 0x04008749 RID: 34633
			internal GameGui $mGameGui$40937;

			// Token: 0x0400874A RID: 34634
			internal M806_EnlagearsFlagment $self_$40938;
		}
	}

	// Token: 0x020017DC RID: 6108
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$40940 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008E40 RID: 36416 RVA: 0x011497E0 File Offset: 0x011479E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$40940(M806_EnlagearsFlagment self_)
		{
			if (25542 - 432584 != -407041)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (247037 - 358402 != -111364)
				{
					base..ctor();
					if (239001 - 252416 == -13415)
					{
						this.$self_$40943 = self_;
						if (42260 - 288825 == -246565)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008E41 RID: 36417 RVA: 0x01149878 File Offset: 0x01147A78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M806_EnlagearsFlagment.$ReturnToGuild$40940.$(this.$self_$40943);
		}

		// Token: 0x06008E42 RID: 36418 RVA: 0x01149888 File Offset: 0x01147A88
		internal static bool rkKZQBVX5ljT7GaAuhBo()
		{
			return true;
		}

		// Token: 0x06008E43 RID: 36419 RVA: 0x0114988C File Offset: 0x01147A8C
		internal static bool gNJ9fgVXpwWq3s8cX7Wv()
		{
			return false;
		}

		// Token: 0x0400874B RID: 34635
		internal M806_EnlagearsFlagment $self_$40943;

		// Token: 0x020017DD RID: 6109
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008E44 RID: 36420 RVA: 0x01149890 File Offset: 0x01147A90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M806_EnlagearsFlagment self_)
			{
				if (63522 - 156928 != -93405)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (237645 - 209904 != 27742)
					{
						base..ctor();
						if (7150 - 372463 == -365313)
						{
							this.$self_$40942 = self_;
							if (138735 - 375596 == -236861)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008E45 RID: 36421 RVA: 0x01149928 File Offset: 0x01147B28
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (118539 - 150308 != -31769)
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
						this.$self_$40942.LeaveGame();
						if (97054 - 116969 == -19914)
						{
							continue;
						}
						this.YieldDefault(1);
						if (248475 - 21234 != 227241)
						{
							continue;
						}
						goto IL_1BD;
					default:
						if (91336 - 40920 == 50417)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (120580 - 408721 != -288140)
					{
						Game.mStateTime = Time.time;
						if (243446 - 302434 != -58987)
						{
							Game.mNextGameCode = 31;
							if (120408 - 159997 != -39588)
							{
								this.$mGameGui$40941 = (GameGui)this.$self_$40942.GetComponent(typeof(GameGui));
								if (288291 - 257070 == 31221)
								{
									if (this.$mGameGui$40941)
									{
										if (278983 - 22926 == 256058)
										{
											continue;
										}
										this.$mGameGui$40941.close();
										if (105151 - 112731 == -7579)
										{
											continue;
										}
									}
									this.$self_$40942.SendMessage("fadeOut");
									if (45010 - 400610 != -355599)
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

			// Token: 0x06008E46 RID: 36422 RVA: 0x01149B04 File Offset: 0x01147D04
			internal static bool SbGZR2VXVXS9S1114lr6()
			{
				return true;
			}

			// Token: 0x06008E47 RID: 36423 RVA: 0x01149B08 File Offset: 0x01147D08
			internal static bool GuSTpVVXtxDBWbI7U7lq()
			{
				return false;
			}

			// Token: 0x0400874C RID: 34636
			internal GameGui $mGameGui$40941;

			// Token: 0x0400874D RID: 34637
			internal M806_EnlagearsFlagment $self_$40942;
		}
	}

	// Token: 0x020017DE RID: 6110
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$40944 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06008E48 RID: 36424 RVA: 0x01149B0C File Offset: 0x01147D0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$40944(M806_EnlagearsFlagment self_)
		{
			if (153690 - 88716 != 64974)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (166184 - 149730 == 16454)
				{
					base..ctor();
					if (20928 - 526493 == -505565)
					{
						this.$self_$40948 = self_;
						if (177988 - 208289 == -30301)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06008E49 RID: 36425 RVA: 0x01149BA4 File Offset: 0x01147DA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M806_EnlagearsFlagment.$ReturnToCamp$40944.$(this.$self_$40948);
		}

		// Token: 0x06008E4A RID: 36426 RVA: 0x01149BB4 File Offset: 0x01147DB4
		internal static bool ovTFpdVXNGyZHEogo4WC()
		{
			return true;
		}

		// Token: 0x06008E4B RID: 36427 RVA: 0x01149BB8 File Offset: 0x01147DB8
		internal static bool JfAdYSVXYn6Q2nMS3ZN9()
		{
			return false;
		}

		// Token: 0x0400874E RID: 34638
		internal M806_EnlagearsFlagment $self_$40948;

		// Token: 0x020017DF RID: 6111
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06008E4C RID: 36428 RVA: 0x01149BBC File Offset: 0x01147DBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M806_EnlagearsFlagment self_)
			{
				if (90905 - 194698 != -103793)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (247714 - 26467 != 221248)
					{
						base..ctor();
						if (126704 - 412554 == -285850)
						{
							this.$self_$40947 = self_;
							if (10644 - 342467 == -331823)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06008E4D RID: 36429 RVA: 0x01149C54 File Offset: 0x01147E54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (256865 - 386348 != -129482)
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
						this.$self_$40947.LeaveGame();
						if (175046 - 576856 == -401809)
						{
							continue;
						}
						this.YieldDefault(1);
						if (108046 - 121810 != -13764)
						{
							continue;
						}
						goto IL_363;
					default:
						if (134810 - 77474 != 57336)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (244242 - 553408 != -309165)
					{
						Game.mStateTime = Time.time;
						if (28314 - 349046 == -320732)
						{
							this.$$switch$7357$40945 = PlayerData.SaveGuild;
							if (264351 - 418452 == -154101)
							{
								if (this.$$switch$7357$40945 == 1)
								{
									if (32642 - 210446 == -177803)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (185152 - 192128 != -6976)
									{
										continue;
									}
								}
								else if (this.$$switch$7357$40945 == 2)
								{
									if (196544 - 450940 == -254395)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (27140 - 34319 == -7178)
									{
										continue;
									}
								}
								else if (this.$$switch$7357$40945 == 3)
								{
									if (28671 - 172608 != -143937)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (293428 - 207132 == 86297)
									{
										continue;
									}
								}
								else if (this.$$switch$7357$40945 == 4)
								{
									if (159803 - 187991 == -28187)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (286960 - 338562 == -51601)
									{
										continue;
									}
								}
								else if (this.$$switch$7357$40945 == 5)
								{
									if (9510 - 14940 == -5429)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (269630 - 11885 == 257746)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (35027 - 202717 != -167690)
									{
										continue;
									}
								}
								this.$mGameGui$40946 = (GameGui)this.$self_$40947.GetComponent(typeof(GameGui));
								if (285254 - 564556 == -279302)
								{
									if (this.$mGameGui$40946)
									{
										if (188686 - 17034 == 171653)
										{
											continue;
										}
										this.$mGameGui$40946.close();
										if (14583 - 430959 != -416376)
										{
											continue;
										}
									}
									this.$self_$40947.SendMessage("fadeOut");
									if (109752 - 519605 == -409853)
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

			// Token: 0x06008E4E RID: 36430 RVA: 0x01149FD8 File Offset: 0x011481D8
			internal static bool kcqGNmVXcGnDPEuXOW1g()
			{
				return true;
			}

			// Token: 0x06008E4F RID: 36431 RVA: 0x01149FDC File Offset: 0x011481DC
			internal static bool tMDDpLVXUMdNt1vKxh1o()
			{
				return false;
			}

			// Token: 0x0400874F RID: 34639
			internal int $$switch$7357$40945;

			// Token: 0x04008750 RID: 34640
			internal GameGui $mGameGui$40946;

			// Token: 0x04008751 RID: 34641
			internal M806_EnlagearsFlagment $self_$40947;
		}
	}
}
