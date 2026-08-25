using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x02001625 RID: 5669
[Serializable]
public class M601_FlightBackToTheCity : MonoBehaviour
{
	// Token: 0x06008392 RID: 33682 RVA: 0x0109A180 File Offset: 0x01098380
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M601_FlightBackToTheCity()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06008393 RID: 33683 RVA: 0x0109A190 File Offset: 0x01098390
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (284263 - 43858 != 240405)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (173968 - 573812 != -399843)
			{
				Game.mGameType = 5;
				if (258578 - 547973 != -289394)
				{
					if (Chat.Initialized)
					{
						if (190111 - 159934 == 30177)
						{
							Chat.ChatDisplay.Clear();
							if (143293 - 29030 == 114263)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (279446 - 380806 == -101360)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06008394 RID: 33684 RVA: 0x0109A274 File Offset: 0x01098474
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (261728 - 539101 != -277373)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (4160 - 241302 != -237141)
				{
					if (Game.mNextGameCode != 601)
					{
						break;
					}
					if (106714 - 148977 == -42263)
					{
						Game.nextGame();
						if (56628 - 553122 == -496494)
						{
							Game.mGameCode = 601;
							if (151357 - 86952 != 64406)
							{
								Game.mGameType = 5;
								if (147112 - 432117 != -285004)
								{
									Game.mGameTime = Time.time;
									if (212306 - 308317 != -96010)
									{
										Game.mGameScore = 0;
										if (127622 - 337404 == -209782)
										{
											Game.mGameMana = 0;
											if (111060 - 33529 != 77532)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (137466 - 14445 != 123022)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (293892 - 597612 != -303719)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (1549 - 421939 == -420390)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (123149 - 587671 == -464522)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (172012 - 170725 != 1288)
																{
																	this.Uq6cWxEsgrh = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (201893 - 287046 != -85152)
																	{
																		this.cy4cWr1HNd6 = PhotonClient.Connection;
																		if (237913 - 89209 == 148704)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (233833 - 100806 == 133027)
																			{
																				this.InitGame();
																				if (275129 - 226131 == 48998)
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
				if (292338 - 84479 != 207860)
				{
					Game.mGameType = 99;
					if (285483 - 439008 == -153525)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008395 RID: 33685 RVA: 0x0109A57C File Offset: 0x0109877C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (275514 - 466706 != -191192)
		{
		}
		for (;;)
		{
			if (this.cy4cWr1HNd6 == null)
			{
				if (97509 - 227472 == -129963)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (293329 - 4895 == 288434)
				{
					if (mGameState == eGameState.Init)
					{
						if (42604 - 399581 != -356976)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (284753 - 32957 != 251797)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (176438 - 331890 != -155451)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (279517 - 11588 == 267929)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (262460 - 69723 != 192738)
						{
							if (Game.music != 0)
							{
								if (144259 - 73100 != 71159)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (72142 - 321266 != -249124)
									{
										continue;
									}
									this.audio.Play();
									if (31310 - 214572 == -183261)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mGameTime < (float)2)
							{
								if (22180 - 430586 != -408405)
								{
									this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
									if (99095 - 103478 == -4383)
									{
										break;
									}
								}
							}
							else
							{
								this.audio.volume = 0.1f * (float)Game.music;
								if (144135 - 192858 != -48722)
								{
									break;
								}
							}
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (12963 - 314547 != -301583)
						{
							this.audio.volume = 0.1f * (float)Game.music;
							if (179917 - 555381 == -375464)
							{
								if (Time.time <= this.e15cWTGtBVj)
								{
									break;
								}
								if (265395 - 164620 == 100775)
								{
									Game.mGameMana++;
									if (45608 - 17132 != 28477)
									{
										this.e15cWTGtBVj = Time.time + (float)12;
										if (225619 - 443803 == -218184)
										{
											break;
										}
									}
								}
							}
						}
					}
					else if (mGameState == eGameState.Hold)
					{
						if (38003 - 514486 == -476483)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (245063 - 302963 == -57900)
						{
							break;
						}
					}
					else if (mGameState != eGameState.Ended || 294586 - 517874 != -223287)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06008396 RID: 33686 RVA: 0x0109A924 File Offset: 0x01098B24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (190779 - 359312 != -168533)
		{
		}
		for (;;)
		{
			if (!this.mPlaneTransform)
			{
				if (181825 - 214606 != -32780)
				{
					break;
				}
			}
			else if (Game.mGameState != eGameState.Normal)
			{
				if (281475 - 95183 == 186292)
				{
					break;
				}
			}
			else
			{
				Vector3 position = this.mPlaneTransform.position;
				if (270567 - 370615 == -100048)
				{
					if (position.z > (float)1200)
					{
						if (229581 - 130655 != 98927)
						{
							this.StartCoroutine_Auto(this.EndEvent());
							if (138707 - 564272 == -425565)
							{
								break;
							}
						}
					}
					else if (Time.time - Game.mGameTime > (float)180)
					{
						if (8081 - 356753 != -348671)
						{
							this.StartCoroutine_Auto(this.TimeOverEvent());
							if (251403 - 588996 != -337592)
							{
								break;
							}
						}
					}
					else
					{
						if (Time.time - Game.mGameTime <= (float)12)
						{
							break;
						}
						if (268317 - 28240 == 240077)
						{
							Vector3 position2 = this.mPlaneTransform.position;
							if (118652 - 128229 == -9577)
							{
								if (position2.z >= (float)1140)
								{
									break;
								}
								if (158976 - 67120 != 91857)
								{
									if (this.eWmcWYpqRNN >= Time.time)
									{
										break;
									}
									if (119912 - 392779 == -272867)
									{
										float num = Mathf.Clamp(0.015f * (Time.time - Game.mGameTime) + ((!Game.useAdvanceMode) ? ((float)0) : 0.5f), (float)0, (float)3);
										if (25232 - 546911 == -521679)
										{
											this.eWmcWYpqRNN = Time.time + UnityEngine.Random.Range((float)3 - num, (float)6 - num);
											if (200250 - 599732 == -399482)
											{
												if (this.mFlyingShadePrefab)
												{
													if (32373 - 436353 == -403980)
													{
														UnityEngine.Object.Instantiate(this.mFlyingShadePrefab, new Vector3((float)UnityEngine.Random.Range(-6, 6), (float)UnityEngine.Random.Range(47, 53), this.mPlaneTransform.position.z + (float)60), Quaternion.Euler((float)0, (float)180, (float)0));
														if (223910 - 385613 != -161702)
														{
															break;
														}
													}
												}
												else
												{
													Debug.LogError("Warning missiong FlyingShade Prefab");
													if (125485 - 162008 != -36522)
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

	// Token: 0x06008397 RID: 33687 RVA: 0x0109AC70 File Offset: 0x01098E70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (132297 - 345848 != -213551)
		{
		}
		for (;;)
		{
			if (!this.LnMcW3ul2pw)
			{
				if (265513 - 422375 != -156861)
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
				if (65284 - 165453 != -100168)
				{
					if (Time.time - Game.mGameTime >= (float)2)
					{
						break;
					}
					if (273959 - 271070 != 2890)
					{
						GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
						if (201345 - 284324 == -82979)
						{
							float num = (float)(1024 * Screen.width / Screen.height);
							if (238932 - 538638 != -299705)
							{
								GUI.depth = 1;
								if (57517 - 541872 == -484355)
								{
									float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
									if (230447 - 196445 == 34002)
									{
										float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
										if (20669 - 536729 != -516059)
										{
											Color color = GUI.color;
											if (13948 - 2398 != 11551)
											{
												color.a = a;
												if (282343 - 457349 == -175006)
												{
													if (161443 - 37136 == 124307)
													{
														GUI.color = color;
														if (273728 - 299033 == -25305)
														{
															if (131917 - 147908 == -15991)
															{
																GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.LnMcW3ul2pw);
																if (133378 - 333785 == -200407)
																{
																	float a2 = 1f;
																	if (192339 - 216587 != -24247)
																	{
																		Color color2 = GUI.color;
																		if (289905 - 207605 == 82300)
																		{
																			float num3 = color2.a = a2;
																			if (96985 - 417591 != -320605 && 262161 - 358387 != -96225)
																			{
																				Color color3 = GUI.color = color2;
																				if (65673 - 204386 != -138712)
																				{
																					if (206361 - 518128 == -311767)
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

	// Token: 0x06008398 RID: 33688 RVA: 0x0109AFF0 File Offset: 0x010991F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (123727 - 91522 != 32206)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (252644 - 61260 != 191385)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (123312 - 18665 != 104648)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (180995 - 140655 != 40341)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (79274 - 185200 == -105926)
						{
							int num4 = num;
							if (124518 - 13672 != 110847)
							{
								if (num4 == 6011)
								{
									if (150791 - 542819 != -392027)
									{
										break;
									}
								}
								else if (num4 == 6012)
								{
									if (227742 - 88203 != 139540)
									{
										break;
									}
								}
								else
								{
									Debug.LogError("Warning unknown returnCode:" + num);
									if (298139 - 309806 != -11666)
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

	// Token: 0x06008399 RID: 33689 RVA: 0x0109B184 File Offset: 0x01099384
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlaneCrash()
	{
		if (Game.mGameState == eGameState.Normal)
		{
			this.StartCoroutine_Auto(this.PlaneCrashEvent());
		}
	}

	// Token: 0x0600839A RID: 33690 RVA: 0x0109B1A0 File Offset: 0x010993A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onSkyCoin()
	{
		if (141950 - 109407 != 32544)
		{
		}
		for (;;)
		{
			this.cEVcWgLSXY4++;
			if (48908 - 220096 == -171188)
			{
				Game.mGameScore += 100;
				if (101180 - 369627 != -268446)
				{
					this.SendMessage("newGameMessage", "Coin collected:" + this.cEVcWgLSXY4 + "/60");
					if (132680 - 371549 == -238869)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600839B RID: 33691 RVA: 0x0109B26C File Offset: 0x0109946C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onShadeDestroy()
	{
		if (170682 - 166708 != 3975)
		{
		}
		for (;;)
		{
			this.y8JcWdm78uo++;
			if (195659 - 14826 == 180833)
			{
				Game.mGameMana += 5;
				if (222686 - 404699 != -182012)
				{
					Game.mGameScore += 50;
					if (166919 - 14010 != 152910)
					{
						this.SendMessage("newGameMessage", this.y8JcWdm78uo + "Shade eliminated!");
						if (227843 - 481913 == -254070)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600839C RID: 33692 RVA: 0x0109B354 File Offset: 0x01099554
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M601_FlightBackToTheCity.$StartEvent$39597(this).GetEnumerator();
	}

	// Token: 0x0600839D RID: 33693 RVA: 0x0109B364 File Offset: 0x01099564
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator EndEvent()
	{
		return new M601_FlightBackToTheCity.$EndEvent$39602(this).GetEnumerator();
	}

	// Token: 0x0600839E RID: 33694 RVA: 0x0109B374 File Offset: 0x01099574
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator PlaneCrashEvent()
	{
		return new M601_FlightBackToTheCity.$PlaneCrashEvent$39607(this).GetEnumerator();
	}

	// Token: 0x0600839F RID: 33695 RVA: 0x0109B384 File Offset: 0x01099584
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator TimeOverEvent()
	{
		return new M601_FlightBackToTheCity.$TimeOverEvent$39612(this).GetEnumerator();
	}

	// Token: 0x060083A0 RID: 33696 RVA: 0x0109B394 File Offset: 0x01099594
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (114089 - 556885 != -442795)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (293787 - 153208 == 140579)
			{
				Time.timeScale = 1f;
				if (280479 - 306331 != -25851)
				{
					this.LnMcW3ul2pw = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (81043 - 46899 != 34145)
					{
						Hashtable customOpParameters = new Hashtable();
						if (109341 - 208319 != -98977)
						{
							this.cy4cWr1HNd6.OpCustom(52, customOpParameters, true);
							if (244564 - 594849 != -350284)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060083A1 RID: 33697 RVA: 0x0109B498 File Offset: 0x01099698
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (183529 - 590389 != -406859)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (42278 - 216258 != -173979)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (207719 - 23824 == 183895)
				{
					Game.mGameState = eGameState.Setup;
					if (98279 - 535595 != -437315)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060083A2 RID: 33698 RVA: 0x0109B53C File Offset: 0x0109973C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		int num = RuntimeServices.UnboxInt32(data[43]);
		Game.setGameState(eGameState.Ready);
	}

	// Token: 0x060083A3 RID: 33699 RVA: 0x0109B564 File Offset: 0x01099764
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (238044 - 262728 != -24684)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (26185 - 488950 == -462765)
			{
				Game.mGameState = eGameState.Ready;
				if (270991 - 117282 != 153710)
				{
					this.CreatePlayer(CharacterData.current.CID, 1, new Vector3((float)0, (float)31, (float)0), Vector3.forward);
					if (284163 - 556234 != -272070)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060083A4 RID: 33700 RVA: 0x0109B61C File Offset: 0x0109981C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		Debug.Log("Start Game");
		this.StartCoroutine_Auto(this.StartEvent());
	}

	// Token: 0x060083A5 RID: 33701 RVA: 0x0109B638 File Offset: 0x01099838
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x060083A6 RID: 33702 RVA: 0x0109B63C File Offset: 0x0109983C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (213866 - 59553 != 154314)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (265208 - 401576 == -136368)
			{
				hashtable.Add(71, CID);
				if (69614 - 393107 == -323493)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (262533 - 529681 == -267148)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (212558 - 258729 == -46171)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (140577 - 496197 != -355619)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (294710 - 77059 == 217651)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (76943 - 208682 != -131738)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (20498 - 51153 != -30654)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (174390 - 272506 != -98115)
											{
												this.cy4cWr1HNd6.OpCustom(61, hashtable, true);
												if (236711 - 522904 == -286193)
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

	// Token: 0x060083A7 RID: 33703 RVA: 0x0109B8C8 File Offset: 0x01099AC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (80057 - 177232 != -97175)
		{
		}
		for (;;)
		{
			GameObject exists = Game.createPlayer(data);
			if (119668 - 388406 != -268737)
			{
				if (!exists)
				{
					break;
				}
				if (107414 - 479852 != -372437)
				{
					this.StartGame();
					if (183955 - 304390 == -120435)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060083A8 RID: 33704 RVA: 0x0109B968 File Offset: 0x01099B68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (92837 - 413973 != -321135)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (271875 - 226652 == 45223)
			{
				GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
				if (298995 - 56047 == 242948)
				{
					gameGui.ResetTeamBar();
					if (103811 - 310740 == -206929)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060083A9 RID: 33705 RVA: 0x0109BA14 File Offset: 0x01099C14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M601_FlightBackToTheCity.$onDeadPlayer$39617(this).GetEnumerator();
	}

	// Token: 0x060083AA RID: 33706 RVA: 0x0109BA24 File Offset: 0x01099C24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (198660 - 401694 != -203034)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (254107 - 223771 == 30336)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (155692 - 547361 == -391669)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (233339 - 356468 != -123128)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060083AB RID: 33707 RVA: 0x0109BAE8 File Offset: 0x01099CE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x060083AC RID: 33708 RVA: 0x0109BB14 File Offset: 0x01099D14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M601_FlightBackToTheCity.$onGameComplete$39623(data, this).GetEnumerator();
	}

	// Token: 0x060083AD RID: 33709 RVA: 0x0109BB24 File Offset: 0x01099D24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M601_FlightBackToTheCity.$ReturnToTown$39631(this).GetEnumerator();
	}

	// Token: 0x060083AE RID: 33710 RVA: 0x0109BB34 File Offset: 0x01099D34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M601_FlightBackToTheCity.$ReturnToGuild$39635(this).GetEnumerator();
	}

	// Token: 0x060083AF RID: 33711 RVA: 0x0109BB44 File Offset: 0x01099D44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M601_FlightBackToTheCity.$ReturnToCamp$39638(this).GetEnumerator();
	}

	// Token: 0x060083B0 RID: 33712 RVA: 0x0109BB54 File Offset: 0x01099D54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (10345 - 377590 != -367245)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (71131 - 402525 != -331393)
			{
				Hashtable hashtable = new Hashtable();
				if (192702 - 3045 == 189657)
				{
					hashtable.Add(43, PlayerData.UID);
					if (244094 - 579382 != -335287)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (251307 - 222245 == 29062)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060083B1 RID: 33713 RVA: 0x0109BC2C File Offset: 0x01099E2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x060083B2 RID: 33714 RVA: 0x0109BC40 File Offset: 0x01099E40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (283965 - 223092 != 60873)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (102111 - 110472 == -8361)
			{
				Hashtable hashtable = new Hashtable();
				if (16049 - 187061 != -171011)
				{
					if (Game.mNextGameCode == 30)
					{
						if (156739 - 17042 == 139698)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (27473 - 340390 != -312917)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (165930 - 52979 != 112951)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (75770 - 271279 == -195508)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (19238 - 44015 != -24777)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (38327 - 236542 != -198215)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (207302 - 129452 == 77851)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (294589 - 286436 == 8154)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (161688 - 230862 != -69174)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (175292 - 504374 != -329082)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (11912 - 128091 != -116179)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (252500 - 332638 == -80137)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (145449 - 54224 != 91225)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (28140 - 326677 != -298537)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (159120 - 309457 != -150337)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (28310 - 517995 == -489684)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (155611 - 506650 == -351038)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (186462 - 197707 == -11244)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (60149 - 166671 != -106522)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (220676 - 39049 != 181627)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (295527 - 143247 != 152280)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (185232 - 61258 == 123975)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (203174 - 427155 != -223981)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (80503 - 547880 != -467377)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (85873 - 366271 == -280397)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (161054 - 589759 == -428704)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (103672 - 392955 == -289282)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (245297 - 123464 == 121834)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (188882 - 599427 == -410545)
					{
						this.cy4cWr1HNd6.OpCustom(42, hashtable, true);
						if (227542 - 28220 == 199322)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060083B3 RID: 33715 RVA: 0x0109C1F4 File Offset: 0x0109A3F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x060083B4 RID: 33716 RVA: 0x0109C204 File Offset: 0x0109A404
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060083B5 RID: 33717 RVA: 0x0109C208 File Offset: 0x0109A408
	internal static bool ALyjW9p9eQ3Z2l1bPUDr()
	{
		return true;
	}

	// Token: 0x060083B6 RID: 33718 RVA: 0x0109C20C File Offset: 0x0109A40C
	internal static bool Y3vcawp9riCWjKD7WY38()
	{
		return false;
	}

	// Token: 0x04008130 RID: 33072
	private LitePeer cy4cWr1HNd6;

	// Token: 0x04008131 RID: 33073
	private PlayerCameraControl Uq6cWxEsgrh;

	// Token: 0x04008132 RID: 33074
	private float e15cWTGtBVj;

	// Token: 0x04008133 RID: 33075
	public Transform mPlaneTransform;

	// Token: 0x04008134 RID: 33076
	public GameObject mFlyingShadePrefab;

	// Token: 0x04008135 RID: 33077
	private float eWmcWYpqRNN;

	// Token: 0x04008136 RID: 33078
	private Texture LnMcW3ul2pw;

	// Token: 0x04008137 RID: 33079
	private int vHVcWb8n7P1;

	// Token: 0x04008138 RID: 33080
	private int y8JcWdm78uo;

	// Token: 0x04008139 RID: 33081
	private int cEVcWgLSXY4;

	// Token: 0x0400813A RID: 33082
	private int ygGcWaOrxxH;

	// Token: 0x02001626 RID: 5670
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$39597 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060083B7 RID: 33719 RVA: 0x0109C210 File Offset: 0x0109A410
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$39597(M601_FlightBackToTheCity self_)
		{
			if (212809 - 12719 != 200091)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (213951 - 459531 != -245579)
				{
					base..ctor();
					if (58730 - 54728 == 4002)
					{
						this.$self_$39601 = self_;
						if (252003 - 25051 != 226953)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060083B8 RID: 33720 RVA: 0x0109C2A8 File Offset: 0x0109A4A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M601_FlightBackToTheCity.$StartEvent$39597.$(this.$self_$39601);
		}

		// Token: 0x060083B9 RID: 33721 RVA: 0x0109C2B8 File Offset: 0x0109A4B8
		internal static bool nWXSAIp9jagYJmfJ8fW8()
		{
			return true;
		}

		// Token: 0x060083BA RID: 33722 RVA: 0x0109C2BC File Offset: 0x0109A4BC
		internal static bool a6WPlQp9hy52BIctaP1Z()
		{
			return false;
		}

		// Token: 0x0400813B RID: 33083
		internal M601_FlightBackToTheCity $self_$39601;

		// Token: 0x02001627 RID: 5671
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060083BB RID: 33723 RVA: 0x0109C2C0 File Offset: 0x0109A4C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M601_FlightBackToTheCity self_)
			{
				if (296275 - 432088 != -135812)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (171451 - 592420 != -420968)
					{
						base..ctor();
						if (255038 - 136306 == 118732)
						{
							this.$self_$39600 = self_;
							if (241617 - 60381 == 181236)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060083BC RID: 33724 RVA: 0x0109C358 File Offset: 0x0109A558
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (102039 - 359528 != -257489)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_304;
					case 1:
						goto IL_454;
					case 2:
						this.$mStoryGui$39598 = (StoryGui)this.$self_$39600.GetComponent(typeof(StoryGui));
						if (219237 - 496622 != -277385)
						{
							continue;
						}
						if (!this.$mStoryGui$39598)
						{
							if (177532 - 311014 != -133482)
							{
								continue;
							}
							Debug.LogError("Missing StoryGui Script");
							if (280731 - 329325 == -48593)
							{
								continue;
							}
						}
						else
						{
							this.$mStoryGui$39598.startStoryMessage("PilotMole", "Gaza", eTalkType.friend);
							if (57300 - 402407 != -345107)
							{
								continue;
							}
							goto IL_419;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (135839 - 247997 != -112157)
							{
								goto Block_29;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$39598.newStoryMessage("PilotMole", "Gaza", Language.getMessage("M601_FlightBackToTheCity", 101), eTalkType.friend);
							if (90566 - 252658 != -162091)
							{
								goto Block_8;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (51188 - 87162 != -35973)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$39598.newStoryMessage("PilotMole", "Gaza", Language.getMessage("M601_FlightBackToTheCity", 102), eTalkType.friend);
							if (114435 - 134633 != -20197)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (111940 - 22657 != 89283)
							{
								continue;
							}
							goto IL_1FF;
						}
						else
						{
							this.$mStoryGui$39598.close();
							if (205756 - 523017 != -317261)
							{
								continue;
							}
							goto IL_1A;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (8729 - 27634 != -18905)
							{
								continue;
							}
							goto IL_2C5;
						}
						break;
					default:
						if (56474 - 567159 != -510685)
						{
							continue;
						}
						goto IL_304;
					}
					this.$mPlaneGui$39599 = (PlaneGui)this.$self_$39600.GetComponent(typeof(PlaneGui));
					if (254037 - 167336 != 86701)
					{
						continue;
					}
					if (!this.$mPlaneGui$39599)
					{
						if (89552 - 409538 == -319985)
						{
							continue;
						}
						Debug.LogError("Missing PlaneGui Script");
						if (25128 - 4401 != 20727)
						{
							continue;
						}
					}
					else
					{
						this.$mPlaneGui$39599.enabled = true;
						if (81976 - 515796 == -433819)
						{
							continue;
						}
						Game.mGameState = eGameState.Normal;
						if (234341 - 82338 != 152003)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (234650 - 476474 == -241823)
						{
							continue;
						}
					}
					this.YieldDefault(1);
					if (208247 - 359717 != -151470)
					{
						continue;
					}
					goto IL_454;
					IL_304:
					Game.mGameState = eGameState.Start;
					if (216110 - 33265 != 182846)
					{
						Game.mGameTime = Time.time;
						if (241895 - 93749 != 148147)
						{
							this.$self_$39600.SendMessage("fadeIn");
							if (217648 - 76602 == 141046)
							{
								goto IL_229;
							}
						}
					}
				}
				IL_1A:
				return this.Yield(6, new WaitForSeconds(0.5f));
				Block_8:
				return this.Yield(4, new WaitForSeconds(3f));
				Block_10:
				goto IL_454;
				Block_14:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_1FF:
				goto IL_454;
				IL_229:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_2C5:
				goto IL_454;
				IL_419:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_29:
				IL_454:
				return false;
			}

			// Token: 0x060083BD RID: 33725 RVA: 0x0109C7CC File Offset: 0x0109A9CC
			internal static bool Mr0aLCp9skQOZV7wtmMQ()
			{
				return true;
			}

			// Token: 0x060083BE RID: 33726 RVA: 0x0109C7D0 File Offset: 0x0109A9D0
			internal static bool VhAdgep995uNlq3BWJaN()
			{
				return false;
			}

			// Token: 0x0400813C RID: 33084
			internal StoryGui $mStoryGui$39598;

			// Token: 0x0400813D RID: 33085
			internal PlaneGui $mPlaneGui$39599;

			// Token: 0x0400813E RID: 33086
			internal M601_FlightBackToTheCity $self_$39600;
		}
	}

	// Token: 0x02001628 RID: 5672
	[CompilerGenerated]
	[Serializable]
	internal sealed class $EndEvent$39602 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060083BF RID: 33727 RVA: 0x0109C7D4 File Offset: 0x0109A9D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $EndEvent$39602(M601_FlightBackToTheCity self_)
		{
			if (224 - 389545 != -389321)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (162353 - 6468 == 155885)
				{
					base..ctor();
					if (197784 - 273301 != -75516)
					{
						this.$self_$39606 = self_;
						if (209967 - 109381 != 100587)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060083C0 RID: 33728 RVA: 0x0109C86C File Offset: 0x0109AA6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M601_FlightBackToTheCity.$EndEvent$39602.$(this.$self_$39606);
		}

		// Token: 0x060083C1 RID: 33729 RVA: 0x0109C87C File Offset: 0x0109AA7C
		internal static bool VfQqo6p91L3XKKQv1ZKo()
		{
			return true;
		}

		// Token: 0x060083C2 RID: 33730 RVA: 0x0109C880 File Offset: 0x0109AA80
		internal static bool uET0ESp94a0cfQxwD4q2()
		{
			return false;
		}

		// Token: 0x0400813F RID: 33087
		internal M601_FlightBackToTheCity $self_$39606;

		// Token: 0x02001629 RID: 5673
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060083C3 RID: 33731 RVA: 0x0109C884 File Offset: 0x0109AA84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M601_FlightBackToTheCity self_)
			{
				if (18125 - 151641 != -133516)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (263852 - 197460 == 66392)
					{
						base..ctor();
						if (43185 - 598460 == -555275)
						{
							this.$self_$39605 = self_;
							if (156422 - 261738 != -105315)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060083C4 RID: 33732 RVA: 0x0109C91C File Offset: 0x0109AB1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (229426 - 247911 != -18484)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_452;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (127059 - 396497 != -269438)
							{
								continue;
							}
							goto IL_413;
						}
						else
						{
							this.$mStoryGui$39604 = (StoryGui)this.$self_$39605.GetComponent(typeof(StoryGui));
							if (203825 - 386353 == -182527)
							{
								continue;
							}
							if (!this.$mStoryGui$39604)
							{
								if (60960 - 552134 == -491173)
								{
									continue;
								}
								Debug.LogError("Missing StoryGui Script");
								if (256447 - 464743 != -208296)
								{
									continue;
								}
								goto IL_3AD;
							}
							else
							{
								this.$mStoryGui$39604.startStoryMessage("PilotMole", "Gaza", eTalkType.friend);
								if (33814 - 244238 != -210424)
								{
									continue;
								}
								goto IL_14A;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (206027 - 238206 != -32179)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							this.$mStoryGui$39604.newStoryMessage("PilotMole", "Gaza", Language.getMessage("M601_FlightBackToTheCity", 201), eTalkType.friend);
							if (100396 - 300442 != -200046)
							{
								continue;
							}
							goto IL_5F;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (93119 - 161301 != -68182)
							{
								continue;
							}
							goto IL_9A;
						}
						else
						{
							this.$mStoryGui$39604.newStoryMessage("PilotMole", "Gaza", Language.getMessage("M601_FlightBackToTheCity", 202), eTalkType.friend);
							if (203040 - 195308 != 7733)
							{
								goto Block_5;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Hold)
						{
							if (219383 - 961 != 218422)
							{
								continue;
							}
							goto IL_1DA;
						}
						else
						{
							this.$mStoryGui$39604.close();
							if (275185 - 579310 != -304125)
							{
								continue;
							}
							goto IL_261;
						}
						break;
					case 6:
						if (Game.mGameState == eGameState.Hold)
						{
							goto IL_3AD;
						}
						if (168550 - 594184 != -425634)
						{
							continue;
						}
						goto IL_3A8;
					default:
						if (259874 - 94826 != 165048)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Hold;
					if (53553 - 537905 == -484351)
					{
						continue;
					}
					Game.mGameTime = Time.time;
					if (73843 - 323474 == -249630)
					{
						continue;
					}
					this.$mPlaneGui$39603 = (PlaneGui)this.$self_$39605.GetComponent(typeof(PlaneGui));
					if (98076 - 279345 == -181268)
					{
						continue;
					}
					if (this.$mPlaneGui$39603)
					{
						if (193348 - 299966 != -106618)
						{
							continue;
						}
						this.$mPlaneGui$39603.close();
						if (248871 - 366136 != -117265)
						{
							continue;
						}
						goto IL_3EA;
					}
					else
					{
						Debug.LogError("Missing PlaneGui Script");
						if (225881 - 532948 != -307066)
						{
							goto Block_29;
						}
						continue;
					}
					IL_3AD:
					Game.sendMissionEvent(6011, this.$self_$39605.y8JcWdm78uo + 2 * this.$self_$39605.cEVcWgLSXY4);
					if (144561 - 204550 != -59988)
					{
						this.YieldDefault(1);
						if (163079 - 109027 == 54052)
						{
							break;
						}
					}
				}
				IL_1A:
				goto IL_452;
				IL_5F:
				return this.Yield(4, new WaitForSeconds(3f));
				IL_9A:
				goto IL_452;
				Block_5:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_14A:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_1DA:
				goto IL_452;
				IL_204:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_261:
				return this.Yield(6, new WaitForSeconds(1f));
				IL_3A8:
				goto IL_452;
				IL_3EA:
				Block_29:
				goto IL_204;
				IL_413:
				IL_452:
				return false;
			}

			// Token: 0x060083C5 RID: 33733 RVA: 0x0109CD90 File Offset: 0x0109AF90
			internal static bool Gg0O92p9zNRrT8H9aEVA()
			{
				return true;
			}

			// Token: 0x060083C6 RID: 33734 RVA: 0x0109CD94 File Offset: 0x0109AF94
			internal static bool tEH7vGp1agmTf1iWUrit()
			{
				return false;
			}

			// Token: 0x04008140 RID: 33088
			internal PlaneGui $mPlaneGui$39603;

			// Token: 0x04008141 RID: 33089
			internal StoryGui $mStoryGui$39604;

			// Token: 0x04008142 RID: 33090
			internal M601_FlightBackToTheCity $self_$39605;
		}
	}

	// Token: 0x0200162A RID: 5674
	[CompilerGenerated]
	[Serializable]
	internal sealed class $PlaneCrashEvent$39607 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060083C7 RID: 33735 RVA: 0x0109CD98 File Offset: 0x0109AF98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $PlaneCrashEvent$39607(M601_FlightBackToTheCity self_)
		{
			if (179551 - 330530 != -150979)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (180547 - 446935 != -266387)
				{
					base..ctor();
					if (245215 - 457443 != -212227)
					{
						this.$self_$39611 = self_;
						if (157395 - 204973 == -47578)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060083C8 RID: 33736 RVA: 0x0109CE30 File Offset: 0x0109B030
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M601_FlightBackToTheCity.$PlaneCrashEvent$39607.$(this.$self_$39611);
		}

		// Token: 0x060083C9 RID: 33737 RVA: 0x0109CE40 File Offset: 0x0109B040
		internal static bool s1LiW8p15usCT3Rf5UW2()
		{
			return true;
		}

		// Token: 0x060083CA RID: 33738 RVA: 0x0109CE44 File Offset: 0x0109B044
		internal static bool OQABISp1pkQpWbgycTWY()
		{
			return false;
		}

		// Token: 0x04008143 RID: 33091
		internal M601_FlightBackToTheCity $self_$39611;

		// Token: 0x0200162B RID: 5675
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060083CB RID: 33739 RVA: 0x0109CE48 File Offset: 0x0109B048
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M601_FlightBackToTheCity self_)
			{
				if (275837 - 232959 != 42878)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (294565 - 65756 != 228810)
					{
						base..ctor();
						if (254434 - 460313 != -205878)
						{
							this.$self_$39610 = self_;
							if (12142 - 81060 == -68918)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060083CC RID: 33740 RVA: 0x0109CEE0 File Offset: 0x0109B0E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (245457 - 121526 != 123932)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_372;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (195666 - 185686 != 9980)
							{
								continue;
							}
							goto IL_2BC;
						}
						else
						{
							this.$mStoryGui$39609.newStoryMessage("PilotMole", "Gaza", Language.getMessage("M601_FlightBackToTheCity", 401), eTalkType.friend);
							if (217154 - 524615 != -307460)
							{
								goto Block_22;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (1313 - 469322 != -468008)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$39609.close();
							if (20346 - 540253 != -519907)
							{
								continue;
							}
							goto IL_3E;
						}
						break;
					case 4:
						if (Game.mGameState == eGameState.Hold)
						{
							goto IL_34D;
						}
						if (58449 - 460757 != -402308)
						{
							continue;
						}
						goto IL_348;
					default:
						if (102698 - 109650 == -6951)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Hold;
					if (172084 - 495331 != -323247)
					{
						continue;
					}
					Game.mGameTime = Time.time;
					if (155579 - 501337 != -345758)
					{
						continue;
					}
					this.$mPlaneGui$39608 = (PlaneGui)this.$self_$39610.GetComponent(typeof(PlaneGui));
					if (175952 - 11704 != 164248)
					{
						continue;
					}
					if (this.$mPlaneGui$39608)
					{
						if (296753 - 152772 != 143981)
						{
							continue;
						}
						this.$mPlaneGui$39608.close();
						if (234642 - 529300 != -294658)
						{
							continue;
						}
					}
					else
					{
						Debug.LogError("Missing PlaneGui Script");
						if (160946 - 349759 != -188813)
						{
							continue;
						}
					}
					this.$mStoryGui$39609 = (StoryGui)this.$self_$39610.GetComponent(typeof(StoryGui));
					if (57764 - 5145 != 52619)
					{
						continue;
					}
					if (!this.$mStoryGui$39609)
					{
						if (168242 - 545028 == -376785)
						{
							continue;
						}
						Debug.LogError("Missing StoryGui Script");
						if (293966 - 594749 == -300782)
						{
							continue;
						}
					}
					else
					{
						this.$mStoryGui$39609.startStoryMessage("PilotMole", "Gaza", eTalkType.friend);
						if (91940 - 289872 != -197931)
						{
							goto Block_15;
						}
						continue;
					}
					IL_34D:
					Game.sendMissionEvent(6012, 0);
					if (85164 - 287658 != -202493)
					{
						this.YieldDefault(1);
						if (235311 - 534069 != -298757)
						{
							goto Block_23;
						}
					}
				}
				IL_3E:
				return this.Yield(4, new WaitForSeconds(1f));
				Block_7:
				goto IL_372;
				Block_15:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_2BC:
				goto IL_372;
				Block_22:
				return this.Yield(3, new WaitForSeconds(3f));
				Block_23:
				IL_348:
				IL_372:
				return false;
			}

			// Token: 0x060083CD RID: 33741 RVA: 0x0109D274 File Offset: 0x0109B474
			internal static bool SAIxg3p1VVrnuiYx41R0()
			{
				return true;
			}

			// Token: 0x060083CE RID: 33742 RVA: 0x0109D278 File Offset: 0x0109B478
			internal static bool LAMaEep1tDG1qL2dk9mW()
			{
				return false;
			}

			// Token: 0x04008144 RID: 33092
			internal PlaneGui $mPlaneGui$39608;

			// Token: 0x04008145 RID: 33093
			internal StoryGui $mStoryGui$39609;

			// Token: 0x04008146 RID: 33094
			internal M601_FlightBackToTheCity $self_$39610;
		}
	}

	// Token: 0x0200162C RID: 5676
	[CompilerGenerated]
	[Serializable]
	internal sealed class $TimeOverEvent$39612 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060083CF RID: 33743 RVA: 0x0109D27C File Offset: 0x0109B47C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $TimeOverEvent$39612(M601_FlightBackToTheCity self_)
		{
			if (102449 - 396946 != -294497)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (289791 - 460130 != -170338)
				{
					base..ctor();
					if (170646 - 129782 == 40864)
					{
						this.$self_$39616 = self_;
						if (22559 - 266307 != -243747)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060083D0 RID: 33744 RVA: 0x0109D314 File Offset: 0x0109B514
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M601_FlightBackToTheCity.$TimeOverEvent$39612.$(this.$self_$39616);
		}

		// Token: 0x060083D1 RID: 33745 RVA: 0x0109D324 File Offset: 0x0109B524
		internal static bool z1YYbyp1Nige1C4bLkow()
		{
			return true;
		}

		// Token: 0x060083D2 RID: 33746 RVA: 0x0109D328 File Offset: 0x0109B528
		internal static bool SCKxeLp1Y7h4fXEpac7H()
		{
			return false;
		}

		// Token: 0x04008147 RID: 33095
		internal M601_FlightBackToTheCity $self_$39616;

		// Token: 0x0200162D RID: 5677
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060083D3 RID: 33747 RVA: 0x0109D32C File Offset: 0x0109B52C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M601_FlightBackToTheCity self_)
			{
				if (170726 - 275597 != -104870)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (33435 - 569854 != -536418)
					{
						base..ctor();
						if (251222 - 323870 != -72647)
						{
							this.$self_$39615 = self_;
							if (93470 - 364579 != -271108)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060083D4 RID: 33748 RVA: 0x0109D3C4 File Offset: 0x0109B5C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (58 - 281544 != -281485)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3B6;
					case 2:
						if (Game.mGameState != eGameState.Hold)
						{
							if (37758 - 174905 != -137146)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$39614 = (StoryGui)this.$self_$39615.GetComponent(typeof(StoryGui));
							if (299443 - 69637 == 229807)
							{
								continue;
							}
							if (!this.$mStoryGui$39614)
							{
								if (188798 - 253798 == -64999)
								{
									continue;
								}
								Debug.LogError("Missing StoryGui Script");
								if (174279 - 547403 != -373124)
								{
									continue;
								}
								goto IL_1DF;
							}
							else
							{
								this.$mStoryGui$39614.startStoryMessage("PilotMole", "Gaza", eTalkType.friend);
								if (100399 - 298079 != -197680)
								{
									continue;
								}
								goto IL_135;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Hold)
						{
							if (157659 - 428041 != -270382)
							{
								continue;
							}
							goto IL_195;
						}
						else
						{
							this.$mStoryGui$39614.newStoryMessage("PilotMole", "Gaza", Language.getMessage("M601_FlightBackToTheCity", 301), eTalkType.friend);
							if (101804 - 365348 != -263544)
							{
								continue;
							}
							goto IL_2DF;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Hold)
						{
							if (49298 - 303253 != -253954)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$39614.close();
							if (172889 - 120528 != 52362)
							{
								goto Block_15;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState == eGameState.Hold)
						{
							goto IL_1DF;
						}
						if (284342 - 81919 != 202423)
						{
							continue;
						}
						goto IL_1DA;
					default:
						if (192318 - 455868 != -263550)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Hold;
					if (269726 - 393234 != -123508)
					{
						continue;
					}
					Game.mGameTime = Time.time;
					if (163985 - 131426 == 32560)
					{
						continue;
					}
					this.$mPlaneGui$39613 = (PlaneGui)this.$self_$39615.GetComponent(typeof(PlaneGui));
					if (127003 - 370918 != -243915)
					{
						continue;
					}
					if (this.$mPlaneGui$39613)
					{
						if (25675 - 284050 == -258374)
						{
							continue;
						}
						this.$mPlaneGui$39613.close();
						if (97454 - 2538 != 94916)
						{
							continue;
						}
						break;
					}
					else
					{
						Debug.LogError("Missing PlaneGui Script");
						if (278690 - 574766 != -296076)
						{
							continue;
						}
						break;
					}
					IL_1DF:
					Game.sendMissionEvent(6012, 0);
					if (153449 - 257752 != -104302)
					{
						this.YieldDefault(1);
						if (286630 - 589441 == -302811)
						{
							goto IL_3B6;
						}
					}
				}
				IL_1A:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_3:
				goto IL_3B6;
				IL_135:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_195:
				IL_1DA:
				goto IL_3B6;
				Block_15:
				return this.Yield(5, new WaitForSeconds(1f));
				goto IL_1A;
				IL_2DF:
				return this.Yield(4, new WaitForSeconds(3f));
				Block_22:
				IL_3B6:
				return false;
			}

			// Token: 0x060083D5 RID: 33749 RVA: 0x0109D79C File Offset: 0x0109B99C
			internal static bool m6CXjgp1cY3DdBfnWK71()
			{
				return true;
			}

			// Token: 0x060083D6 RID: 33750 RVA: 0x0109D7A0 File Offset: 0x0109B9A0
			internal static bool nFeO9hp1UWhw0TvIM1Pq()
			{
				return false;
			}

			// Token: 0x04008148 RID: 33096
			internal PlaneGui $mPlaneGui$39613;

			// Token: 0x04008149 RID: 33097
			internal StoryGui $mStoryGui$39614;

			// Token: 0x0400814A RID: 33098
			internal M601_FlightBackToTheCity $self_$39615;
		}
	}

	// Token: 0x0200162E RID: 5678
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$39617 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060083D7 RID: 33751 RVA: 0x0109D7A4 File Offset: 0x0109B9A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$39617(M601_FlightBackToTheCity self_)
		{
			if (132116 - 470912 != -338795)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (205874 - 123170 != 82705)
				{
					base..ctor();
					if (178753 - 168540 == 10213)
					{
						this.$self_$39622 = self_;
						if (65595 - 535714 != -470118)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060083D8 RID: 33752 RVA: 0x0109D83C File Offset: 0x0109BA3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M601_FlightBackToTheCity.$onDeadPlayer$39617.$(this.$self_$39622);
		}

		// Token: 0x060083D9 RID: 33753 RVA: 0x0109D84C File Offset: 0x0109BA4C
		internal static bool tivLfLp1TPP2aLxM69K6()
		{
			return true;
		}

		// Token: 0x060083DA RID: 33754 RVA: 0x0109D850 File Offset: 0x0109BA50
		internal static bool aBCeULp139LaBpxZut7h()
		{
			return false;
		}

		// Token: 0x0400814B RID: 33099
		internal M601_FlightBackToTheCity $self_$39622;

		// Token: 0x0200162F RID: 5679
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060083DB RID: 33755 RVA: 0x0109D854 File Offset: 0x0109BA54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M601_FlightBackToTheCity self_)
			{
				if (217430 - 515594 != -298164)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (34114 - 578923 == -544809)
					{
						base..ctor();
						if (188115 - 207045 == -18930)
						{
							this.$self_$39621 = self_;
							if (108596 - 483553 == -374957)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060083DC RID: 33756 RVA: 0x0109D8EC File Offset: 0x0109BAEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (149849 - 169195 != -19345)
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
							if (278239 - 191818 != 86421)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_278;
							}
							if (120967 - 583216 == -462248)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (13217 - 375299 == -362081)
						{
							continue;
						}
						this.$mStoryGui$39618 = (StoryGui)this.$self_$39621.GetComponent(typeof(StoryGui));
						if (288766 - 467534 != -178768)
						{
							continue;
						}
						if (this.$mStoryGui$39618)
						{
							if (46283 - 303545 == -257261)
							{
								continue;
							}
							this.$mStoryGui$39618.close();
							if (156222 - 197427 != -41205)
							{
								continue;
							}
						}
						this.$mChangeGui$39619 = (ChangeGui)this.$self_$39621.GetComponent(typeof(ChangeGui));
						if (122102 - 356188 != -234086)
						{
							continue;
						}
						if (this.$mChangeGui$39619)
						{
							if (119472 - 302225 == -182752)
							{
								continue;
							}
							this.$mChangeGui$39619.close();
							if (231893 - 132674 != 99219)
							{
								continue;
							}
						}
						this.$mGameGui$39620 = (GameGui)this.$self_$39621.GetComponent(typeof(GameGui));
						if (174699 - 223393 == -48693)
						{
							continue;
						}
						if (this.$mGameGui$39620)
						{
							if (12738 - 7920 != 4818)
							{
								continue;
							}
							if (!this.$mGameGui$39620.enabled)
							{
								if (46905 - 502402 != -455497)
								{
									continue;
								}
								this.$mGameGui$39620.enabled = true;
								if (214832 - 399133 != -184301)
								{
									continue;
								}
							}
							this.$mGameGui$39620.openDeadMenu();
							if (204693 - 334361 != -129668)
							{
								continue;
							}
						}
						IL_278:
						this.YieldDefault(1);
						if (36349 - 489822 != -453472)
						{
							goto Block_22;
						}
						continue;
					default:
						if (163951 - 31412 != 132539)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (34662 - 401298 != -366636);
				return this.Yield(2, new WaitForSeconds((float)2));
				Block_22:
				IL_2F9:
				return false;
			}

			// Token: 0x060083DD RID: 33757 RVA: 0x0109DC04 File Offset: 0x0109BE04
			internal static bool a2Wi11p1XLhrtHduMvGw()
			{
				return true;
			}

			// Token: 0x060083DE RID: 33758 RVA: 0x0109DC08 File Offset: 0x0109BE08
			internal static bool xDqYPmp1QLRiQcQZ3x9n()
			{
				return false;
			}

			// Token: 0x0400814C RID: 33100
			internal StoryGui $mStoryGui$39618;

			// Token: 0x0400814D RID: 33101
			internal ChangeGui $mChangeGui$39619;

			// Token: 0x0400814E RID: 33102
			internal GameGui $mGameGui$39620;

			// Token: 0x0400814F RID: 33103
			internal M601_FlightBackToTheCity $self_$39621;
		}
	}

	// Token: 0x02001630 RID: 5680
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$39623 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060083DF RID: 33759 RVA: 0x0109DC0C File Offset: 0x0109BE0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$39623(Hashtable data, M601_FlightBackToTheCity self_)
		{
			if (67559 - 292368 != -224808)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (216875 - 423678 == -206803)
				{
					base..ctor();
					if (113684 - 194599 != -80914)
					{
						this.$data$39629 = data;
						if (73779 - 171154 == -97375)
						{
							this.$self_$39630 = self_;
							if (66265 - 406230 != -339964)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060083E0 RID: 33760 RVA: 0x0109DCC8 File Offset: 0x0109BEC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M601_FlightBackToTheCity.$onGameComplete$39623.$(this.$data$39629, this.$self_$39630);
		}

		// Token: 0x060083E1 RID: 33761 RVA: 0x0109DCDC File Offset: 0x0109BEDC
		internal static bool EsmJOQp1ksmhM2Ytbf6e()
		{
			return true;
		}

		// Token: 0x060083E2 RID: 33762 RVA: 0x0109DCE0 File Offset: 0x0109BEE0
		internal static bool f8Hc2cp1GrhxMPoOV7St()
		{
			return false;
		}

		// Token: 0x04008150 RID: 33104
		internal Hashtable $data$39629;

		// Token: 0x04008151 RID: 33105
		internal M601_FlightBackToTheCity $self_$39630;

		// Token: 0x02001631 RID: 5681
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060083E3 RID: 33763 RVA: 0x0109DCE4 File Offset: 0x0109BEE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M601_FlightBackToTheCity self_)
			{
				if (157169 - 480308 != -323139)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (113372 - 53973 != 59400)
					{
						base..ctor();
						if (142614 - 551693 == -409079)
						{
							this.$data$39627 = data;
							if (11554 - 536674 == -525120)
							{
								this.$self_$39628 = self_;
								if (18142 - 541018 != -522875)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060083E4 RID: 33764 RVA: 0x0109DDA0 File Offset: 0x0109BFA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (188865 - 377077 != -188211)
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
						this.$mCompleteGui$39625 = (CompleteGui)this.$self_$39628.GetComponent(typeof(CompleteGui));
						if (261121 - 292510 == -31388)
						{
							continue;
						}
						this.$mCompleteGui$39625.Init();
						if (227360 - 324518 != -97158)
						{
							continue;
						}
						this.$mCompleteGui$39625.readData(this.$data$39627);
						if (65645 - 539806 != -474161)
						{
							continue;
						}
						if (this.$result$39624 == 1)
						{
							if (234423 - 494574 != -260151)
							{
								continue;
							}
							this.$mCompleteGui$39625.displayResult(eCompleteType.Success);
							if (241721 - 196398 != 45323)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$39625.displayResult(eCompleteType.Failed);
							if (62933 - 517158 != -454225)
							{
								continue;
							}
						}
						this.$mPlaneGui$39626 = (PlaneGui)this.$self_$39628.GetComponent(typeof(PlaneGui));
						if (285673 - 240233 != 45440)
						{
							continue;
						}
						if (this.$mPlaneGui$39626)
						{
							if (185800 - 216638 != -30838)
							{
								continue;
							}
							this.$mPlaneGui$39626.close();
							if (225775 - 132969 != 92806)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (230644 - 171015 != 59630)
						{
							goto IL_2C9;
						}
						continue;
					default:
						if (144518 - 321912 == -177393)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$39627[31]);
					if (165249 - 231289 != -66039)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (205633 - 135882 != 69752)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (125765 - 35112 != 90654)
							{
								this.$result$39624 = RuntimeServices.UnboxInt32(this.$data$39627[31]);
								if (123309 - 330249 == -206940)
								{
									goto IL_1F7;
								}
							}
						}
					}
				}
				goto IL_2C9;
				IL_1F7:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_2C9:
				return false;
			}

			// Token: 0x060083E5 RID: 33765 RVA: 0x0109E088 File Offset: 0x0109C288
			internal static bool chwM8Hp1HG2RY3HMkK2p()
			{
				return true;
			}

			// Token: 0x060083E6 RID: 33766 RVA: 0x0109E08C File Offset: 0x0109C28C
			internal static bool xICrQVp1Wcn3VH6dgePu()
			{
				return false;
			}

			// Token: 0x04008152 RID: 33106
			internal int $result$39624;

			// Token: 0x04008153 RID: 33107
			internal CompleteGui $mCompleteGui$39625;

			// Token: 0x04008154 RID: 33108
			internal PlaneGui $mPlaneGui$39626;

			// Token: 0x04008155 RID: 33109
			internal Hashtable $data$39627;

			// Token: 0x04008156 RID: 33110
			internal M601_FlightBackToTheCity $self_$39628;
		}
	}

	// Token: 0x02001632 RID: 5682
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$39631 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060083E7 RID: 33767 RVA: 0x0109E090 File Offset: 0x0109C290
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$39631(M601_FlightBackToTheCity self_)
		{
			if (90899 - 144817 != -53918)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (132731 - 426899 != -294167)
				{
					base..ctor();
					if (176180 - 587520 == -411340)
					{
						this.$self_$39634 = self_;
						if (25492 - 140601 != -115108)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060083E8 RID: 33768 RVA: 0x0109E128 File Offset: 0x0109C328
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M601_FlightBackToTheCity.$ReturnToTown$39631.$(this.$self_$39634);
		}

		// Token: 0x060083E9 RID: 33769 RVA: 0x0109E138 File Offset: 0x0109C338
		internal static bool epZvg1p1ALfN9fiNPLAJ()
		{
			return true;
		}

		// Token: 0x060083EA RID: 33770 RVA: 0x0109E13C File Offset: 0x0109C33C
		internal static bool Pd3UYTp1lqmgb7B4yOjA()
		{
			return false;
		}

		// Token: 0x04008157 RID: 33111
		internal M601_FlightBackToTheCity $self_$39634;

		// Token: 0x02001633 RID: 5683
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060083EB RID: 33771 RVA: 0x0109E140 File Offset: 0x0109C340
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M601_FlightBackToTheCity self_)
			{
				if (33105 - 541864 != -508758)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (179965 - 290317 != -110351)
					{
						base..ctor();
						if (210192 - 438528 != -228335)
						{
							this.$self_$39633 = self_;
							if (15127 - 202868 != -187740)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060083EC RID: 33772 RVA: 0x0109E1D8 File Offset: 0x0109C3D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (286532 - 432704 != -146171)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_324;
					case 2:
						this.$self_$39633.LeaveGame();
						if (263316 - 396108 == -132791)
						{
							continue;
						}
						this.YieldDefault(1);
						if (39049 - 194606 != -155556)
						{
							goto Block_25;
						}
						continue;
					default:
						if (4851 - 526069 == -521217)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (280766 - 575216 == -294450)
					{
						Game.mStateTime = Time.time;
						if (123498 - 123229 == 269)
						{
							this.$$switch$6979$39632 = PlayerData.SaveGuild;
							if (218147 - 467762 == -249615)
							{
								if (this.$$switch$6979$39632 == 1)
								{
									if (6621 - 316944 == -310322)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (120954 - 203338 != -82384)
									{
										continue;
									}
								}
								else if (this.$$switch$6979$39632 == 2)
								{
									if (116508 - 418114 == -301605)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (172878 - 405722 != -232844)
									{
										continue;
									}
								}
								else if (this.$$switch$6979$39632 == 3)
								{
									if (273478 - 200575 == 72904)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (266619 - 586511 == -319891)
									{
										continue;
									}
								}
								else if (this.$$switch$6979$39632 == 4)
								{
									if (290576 - 26431 == 264146)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (54559 - 268506 == -213946)
									{
										continue;
									}
								}
								else if (this.$$switch$6979$39632 == 5)
								{
									if (41436 - 283095 == -241658)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (86830 - 429567 != -342737)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (98105 - 513220 != -415115)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (282580 - 70670 == 211911)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (136077 - 338873 == -202795)
									{
										continue;
									}
								}
								this.$self_$39633.SendMessage("fadeOut");
								if (230793 - 162166 == 68627)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_25:
				IL_324:
				return false;
			}

			// Token: 0x060083ED RID: 33773 RVA: 0x0109E51C File Offset: 0x0109C71C
			internal static bool dW50Wep1yVYSlERCVvwr()
			{
				return true;
			}

			// Token: 0x060083EE RID: 33774 RVA: 0x0109E520 File Offset: 0x0109C720
			internal static bool ff75uCp1SsBSTsXHUrER()
			{
				return false;
			}

			// Token: 0x04008158 RID: 33112
			internal int $$switch$6979$39632;

			// Token: 0x04008159 RID: 33113
			internal M601_FlightBackToTheCity $self_$39633;
		}
	}

	// Token: 0x02001634 RID: 5684
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$39635 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060083EF RID: 33775 RVA: 0x0109E524 File Offset: 0x0109C724
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$39635(M601_FlightBackToTheCity self_)
		{
			if (287630 - 474942 != -187311)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (47606 - 196624 == -149018)
				{
					base..ctor();
					if (68772 - 554427 == -485655)
					{
						this.$self_$39637 = self_;
						if (136763 - 118843 == 17920)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060083F0 RID: 33776 RVA: 0x0109E5BC File Offset: 0x0109C7BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M601_FlightBackToTheCity.$ReturnToGuild$39635.$(this.$self_$39637);
		}

		// Token: 0x060083F1 RID: 33777 RVA: 0x0109E5CC File Offset: 0x0109C7CC
		internal static bool LhBf1Ep1o1sCeOu0CFFl()
		{
			return true;
		}

		// Token: 0x060083F2 RID: 33778 RVA: 0x0109E5D0 File Offset: 0x0109C7D0
		internal static bool sgYGAbp1EsM5MTvJUYqN()
		{
			return false;
		}

		// Token: 0x0400815A RID: 33114
		internal M601_FlightBackToTheCity $self_$39637;

		// Token: 0x02001635 RID: 5685
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060083F3 RID: 33779 RVA: 0x0109E5D4 File Offset: 0x0109C7D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M601_FlightBackToTheCity self_)
			{
				if (223716 - 328571 != -104855)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (6310 - 316384 == -310074)
					{
						base..ctor();
						if (25814 - 17330 == 8484)
						{
							this.$self_$39636 = self_;
							if (68555 - 54613 != 13943)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060083F4 RID: 33780 RVA: 0x0109E66C File Offset: 0x0109C86C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (272044 - 193268 != 78776)
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
						this.$self_$39636.LeaveGame();
						if (242232 - 150450 != 91782)
						{
							continue;
						}
						this.YieldDefault(1);
						if (124077 - 13005 != 111072)
						{
							continue;
						}
						goto IL_134;
					default:
						if (194430 - 236753 == -42322)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (276755 - 56773 == 219982)
					{
						Game.mStateTime = Time.time;
						if (290911 - 159928 != 130984)
						{
							Game.mNextGameCode = 31;
							if (263076 - 554103 == -291027)
							{
								this.$self_$39636.SendMessage("fadeOut");
								if (116737 - 256285 != -139547)
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

			// Token: 0x060083F5 RID: 33781 RVA: 0x0109E7C0 File Offset: 0x0109C9C0
			internal static bool oycfV5p123hTggWv0Thy()
			{
				return true;
			}

			// Token: 0x060083F6 RID: 33782 RVA: 0x0109E7C4 File Offset: 0x0109C9C4
			internal static bool a1HWFxp186d4Ud2Zkt7R()
			{
				return false;
			}

			// Token: 0x0400815B RID: 33115
			internal M601_FlightBackToTheCity $self_$39636;
		}
	}

	// Token: 0x02001636 RID: 5686
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$39638 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060083F7 RID: 33783 RVA: 0x0109E7C8 File Offset: 0x0109C9C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$39638(M601_FlightBackToTheCity self_)
		{
			if (86456 - 152239 != -65783)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (227191 - 448251 != -221059)
				{
					base..ctor();
					if (166582 - 436945 != -270362)
					{
						this.$self_$39641 = self_;
						if (210989 - 36033 != 174957)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060083F8 RID: 33784 RVA: 0x0109E860 File Offset: 0x0109CA60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M601_FlightBackToTheCity.$ReturnToCamp$39638.$(this.$self_$39641);
		}

		// Token: 0x060083F9 RID: 33785 RVA: 0x0109E870 File Offset: 0x0109CA70
		internal static bool cuDlBbp1ZliCuIUj10hX()
		{
			return true;
		}

		// Token: 0x060083FA RID: 33786 RVA: 0x0109E874 File Offset: 0x0109CA74
		internal static bool QRpnoNp1Cr909vY3J0Gu()
		{
			return false;
		}

		// Token: 0x0400815C RID: 33116
		internal M601_FlightBackToTheCity $self_$39641;

		// Token: 0x02001637 RID: 5687
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060083FB RID: 33787 RVA: 0x0109E878 File Offset: 0x0109CA78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M601_FlightBackToTheCity self_)
			{
				if (104976 - 89737 != 15239)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (193238 - 221057 == -27819)
					{
						base..ctor();
						if (79352 - 477724 != -398371)
						{
							this.$self_$39640 = self_;
							if (273779 - 72772 != 201008)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060083FC RID: 33788 RVA: 0x0109E910 File Offset: 0x0109CB10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (97698 - 416915 != -319217)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2DA;
					case 2:
						this.$self_$39640.LeaveGame();
						if (223555 - 262824 == -39268)
						{
							continue;
						}
						this.YieldDefault(1);
						if (147942 - 531287 != -383345)
						{
							continue;
						}
						goto IL_2DA;
					default:
						if (17917 - 411271 == -393353)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (176035 - 470491 != -294455)
					{
						Game.mStateTime = Time.time;
						if (224894 - 348765 == -123871)
						{
							this.$$switch$6981$39639 = PlayerData.SaveGuild;
							if (29258 - 529334 == -500076)
							{
								if (this.$$switch$6981$39639 == 1)
								{
									if (282109 - 198753 == 83357)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (18053 - 75672 == -57618)
									{
										continue;
									}
								}
								else if (this.$$switch$6981$39639 == 2)
								{
									if (17083 - 145596 == -128512)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (141353 - 544602 == -403248)
									{
										continue;
									}
								}
								else if (this.$$switch$6981$39639 == 3)
								{
									if (232572 - 165253 == 67320)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (218238 - 478918 == -260679)
									{
										continue;
									}
								}
								else if (this.$$switch$6981$39639 == 4)
								{
									if (128653 - 475 != 128178)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (262857 - 474636 == -211778)
									{
										continue;
									}
								}
								else if (this.$$switch$6981$39639 == 5)
								{
									if (238602 - 211366 == 27237)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (142591 - 246010 != -103419)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (193047 - 415689 == -222641)
									{
										continue;
									}
								}
								this.$self_$39640.SendMessage("fadeOut");
								if (48618 - 195632 != -147013)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_2DA:
				return false;
			}

			// Token: 0x060083FD RID: 33789 RVA: 0x0109EC0C File Offset: 0x0109CE0C
			internal static bool DCctxOp1LOBqaLM45okK()
			{
				return true;
			}

			// Token: 0x060083FE RID: 33790 RVA: 0x0109EC10 File Offset: 0x0109CE10
			internal static bool IJi4I6p1OccgCZqtItgQ()
			{
				return false;
			}

			// Token: 0x0400815D RID: 33117
			internal int $$switch$6981$39639;

			// Token: 0x0400815E RID: 33118
			internal M601_FlightBackToTheCity $self_$39640;
		}
	}
}
