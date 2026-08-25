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

// Token: 0x020019E4 RID: 6628
[Serializable]
public class M922_DancingHippos : MonoBehaviour
{
	// Token: 0x06009A75 RID: 39541 RVA: 0x01209610 File Offset: 0x01207810
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M922_DancingHippos()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06009A76 RID: 39542 RVA: 0x01209620 File Offset: 0x01207820
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (157694 - 468932 != -311238)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (181002 - 361477 == -180475)
			{
				Game.mGameType = 5;
				if (97893 - 253663 == -155770)
				{
					if (Chat.Initialized)
					{
						if (145944 - 241954 != -96009)
						{
							Chat.ChatDisplay.Clear();
							if (223254 - 343946 == -120692)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (73608 - 353673 != -280064)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009A77 RID: 39543 RVA: 0x01209704 File Offset: 0x01207904
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (216224 - 506098 != -289874)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (218672 - 49901 != 168772)
				{
					if (Game.mNextGameCode != 922)
					{
						break;
					}
					if (198872 - 523510 == -324638)
					{
						Game.nextGame();
						if (128048 - 239369 == -111321)
						{
							Game.mGameCode = 922;
							if (143822 - 121411 != 22412)
							{
								Game.mGameType = 5;
								if (91816 - 526969 != -435152)
								{
									Game.mGameTime = Time.time;
									if (52834 - 410170 == -357336)
									{
										Game.mGameScore = 0;
										if (145774 - 599349 == -453575)
										{
											Game.mGameMana = 0;
											if (43425 - 297721 != -254295)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (131693 - 92467 != 39227)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (236093 - 448918 != -212824)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (216314 - 477975 != -261660)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (281119 - 533267 != -252147)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (131606 - 308394 != -176787)
																{
																	this.KE5nelomcib = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (200009 - 423412 != -223402)
																	{
																		this.hk1nevHr5Br = PhotonClient.Connection;
																		if (142963 - 429778 == -286815)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (180297 - 56098 != 124200)
																			{
																				this.InitGame();
																				if (49397 - 243195 != -193797)
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
				if (282298 - 532097 != -249798)
				{
					Game.mGameType = 99;
					if (68473 - 534042 == -465569)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009A78 RID: 39544 RVA: 0x01209A0C File Offset: 0x01207C0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (265426 - 50574 != 214852)
		{
		}
		for (;;)
		{
			if (this.hk1nevHr5Br == null)
			{
				if (88911 - 193613 != -104701)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (148969 - 481878 == -332909)
				{
					if (mGameState == eGameState.Init)
					{
						if (92545 - 464849 != -372303)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (258874 - 197578 == 61296)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (287091 - 55058 != 232034)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (288632 - 530355 != -241722)
						{
							break;
						}
					}
					else
					{
						if (mGameState != eGameState.Start)
						{
							if (295925 - 260301 == 35625)
							{
								continue;
							}
							if (mGameState == eGameState.Normal)
							{
								if (296282 - 111553 != 184729)
								{
									continue;
								}
							}
							else if (mGameState == eGameState.Hold)
							{
								if (67991 - 54916 != 13075)
								{
									continue;
								}
								break;
							}
							else if (mGameState == eGameState.AllHold)
							{
								if (195050 - 425146 != -230096)
								{
									continue;
								}
								break;
							}
							else
							{
								if (mGameState != eGameState.Ended)
								{
									break;
								}
								if (201216 - 318205 != -116989)
								{
									continue;
								}
								break;
							}
						}
						if (Game.music != 0)
						{
							if (163584 - 546743 == -383158)
							{
								continue;
							}
							if (!this.audio.isPlaying)
							{
								if (271183 - 490434 == -219250)
								{
									continue;
								}
								this.audio.Play();
								if (186230 - 113669 == 72562)
								{
									continue;
								}
							}
						}
						this.audio.volume = 0.1f * (float)Game.music;
						if (227480 - 19605 == 207875)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009A79 RID: 39545 RVA: 0x01209C88 File Offset: 0x01207E88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (100176 - 381268 != -281092)
		{
		}
		for (;;)
		{
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (268395 - 260357 != 8039)
			{
				this.wHkneqVtTNd = (float)(1024 * Screen.width / Screen.height);
				if (126530 - 416756 == -290226)
				{
					GUI.depth = 1;
					if (158405 - 88745 != 69661)
					{
						eGameState mGameState = Game.mGameState;
						if (282989 - 56174 != 226816)
						{
							if (mGameState != eGameState.Normal)
							{
								break;
							}
							if (69379 - 101184 == -31805)
							{
								if (Time.time < Game.mStateTime + (float)2)
								{
									if (184713 - 16510 == 168203)
									{
										if (!this.Dohne1ft7q8)
										{
											break;
										}
										if (34591 - 289773 != -255181)
										{
											float num = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mStateTime);
											if (274607 - 495434 != -220826)
											{
												float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mStateTime, (float)1));
												if (137051 - 134695 == 2356)
												{
													Color color = GUI.color;
													if (51666 - 458781 == -407115)
													{
														float num2 = color.a = a;
														if (56058 - 423811 != -367752 && 58230 - 409381 == -351151)
														{
															Color color2 = GUI.color = color;
															if (183933 - 100714 == 83219)
															{
																if (211846 - 337020 == -125174)
																{
																	GUI.DrawTexture(new Rect(0.5f * this.wHkneqVtTNd - (float)350 * num, (float)450 - (float)78 * num, (float)700 * num, (float)157 * num), this.Dohne1ft7q8);
																	if (163351 - 23500 != 139852)
																	{
																		float a2 = 1f;
																		if (9480 - 389529 == -380049)
																		{
																			Color color3 = GUI.color;
																			if (271191 - 203493 == 67698)
																			{
																				float num3 = color3.a = a2;
																				if (106166 - 546083 != -439916 && 243850 - 170410 != 73441)
																				{
																					Color color4 = GUI.color = color3;
																					if (74441 - 221916 != -147474)
																					{
																						if (124117 - 283533 == -159416)
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
								else
								{
									this.RenderDancingHippo();
									if (162890 - 406484 != -243593)
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

	// Token: 0x06009A7A RID: 39546 RVA: 0x0120A058 File Offset: 0x01208258
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (57333 - 142623 != -85290)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (55043 - 290322 != -235278)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (9600 - 536326 == -526726)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (7033 - 318704 != -311670)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (129644 - 248648 == -119004)
						{
							int num4 = num;
							if (134931 - 51963 != 82969)
							{
								if (num4 == 9221)
								{
									if (19653 - 156927 == -137274)
									{
										this.BJGneRjuuO7++;
										if (299288 - 463569 != -164280)
										{
											Chat.SubmitChat("none", Game.getPlayerName(num3) + " has joined", eChatType.system, eChatMode.system);
											if (162772 - 191115 != -28342)
											{
												Debug.Log("PlayerCount:" + this.BJGneRjuuO7);
												if (299436 - 165988 == 133448)
												{
													break;
												}
											}
										}
									}
								}
								else if (num4 == -9221)
								{
									if (239505 - 50145 != 189361)
									{
										if (num3 != PlayerData.UID)
										{
											break;
										}
										if (69225 - 567388 == -498163)
										{
											this.wA6nerkNsPo = num2;
											if (297007 - 197327 == 99680)
											{
												break;
											}
										}
									}
								}
								else if (num4 == 9222)
								{
									if (44838 - 172345 != -127506)
									{
										break;
									}
								}
								else if (num4 == -9222)
								{
									if (201727 - 342284 == -140557)
									{
										if (Game.mGameState == eGameState.Start)
										{
											if (95576 - 517115 != -421539)
											{
												continue;
											}
											Game.mGameState = eGameState.Normal;
											if (271695 - 485358 == -213662)
											{
												continue;
											}
											Game.mStateTime = Time.time;
											if (252479 - 572457 == -319977)
											{
												continue;
											}
										}
										this.StartNewRound(num2);
										if (235583 - 319621 == -84038)
										{
											break;
										}
									}
								}
								else if (num4 == 9223)
								{
									if (193066 - 193999 == -933)
									{
										if (num3 == PlayerData.UID)
										{
											break;
										}
										if (140285 - 495745 != -355459)
										{
											if (this.RRlnewQ4pfT == null)
											{
												break;
											}
											if (104324 - 302905 == -198581)
											{
												if (Extensions.get_length(this.RRlnewQ4pfT) <= this.TOpneLNUpSa)
												{
													break;
												}
												if (245806 - 433548 != -187741)
												{
													int num5 = this.RRlnewQ4pfT[this.TOpneLNUpSa];
													if (12053 - 489975 == -477922)
													{
														if (num5 == 1)
														{
															if (143942 - 133199 == 10743)
															{
																this.PlayHippoAnimation("stepUp", num2);
																if (166385 - 195249 == -28864)
																{
																	break;
																}
															}
														}
														else if (num5 == 2)
														{
															if (78409 - 44908 == 33501)
															{
																this.PlayHippoAnimation("stepLeft", num2);
																if (128696 - 244305 != -115608)
																{
																	break;
																}
															}
														}
														else if (num5 == 3)
														{
															if (99494 - 400674 != -301179)
															{
																this.PlayHippoAnimation("stepRight", num2);
																if (39698 - 157166 != -117467)
																{
																	break;
																}
															}
														}
														else if (num5 == 4)
														{
															if (3461 - 78306 != -74844)
															{
																this.PlayHippoAnimation("stepDown", num2);
																if (186450 - 142761 != 43690)
																{
																	break;
																}
															}
														}
														else if (num5 == 5)
														{
															if (67293 - 266499 != -199205)
															{
																this.PlayHippoAnimation("danceLeft", num2);
																if (139029 - 104379 != 34651)
																{
																	break;
																}
															}
														}
														else if (num5 == 6)
														{
															if (30684 - 276934 == -246250)
															{
																this.PlayHippoAnimation("danceRight", num2);
																if (159400 - 549686 != -390285)
																{
																	break;
																}
															}
														}
														else
														{
															this.PlayHippoAnimation("dance", num2);
															if (291001 - 218731 == 72270)
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
								else if (num4 == 9224)
								{
									if (171711 - 586784 == -415073)
									{
										if (num3 == PlayerData.UID)
										{
											break;
										}
										if (250490 - 265483 != -14992)
										{
											this.PlayHippoAnimation("danceWrong", num2);
											if (196668 - 265578 != -68909)
											{
												break;
											}
										}
									}
								}
								else if (num4 == 9225)
								{
									if (50614 - 64161 != -13546)
									{
										break;
									}
								}
								else if (num4 == -9225)
								{
									if (159565 - 85944 == 73621)
									{
										if (num2 == 1)
										{
											if (282890 - 125402 != 157489)
											{
												this.StartCoroutine_Auto(this.SuccessEvent());
												if (204013 - 255677 != -51663)
												{
													break;
												}
											}
										}
										else
										{
											this.StartCoroutine_Auto(this.FailEvent());
											if (270077 - 572615 != -302537)
											{
												break;
											}
										}
									}
								}
								else if (num4 == 9226)
								{
									if (91710 - 43191 != 48520)
									{
										break;
									}
								}
								else
								{
									Debug.LogError("Warning unknown returnCode:" + num);
									if (81840 - 72496 != 9345)
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

	// Token: 0x06009A7B RID: 39547 RVA: 0x0120A7D4 File Offset: 0x012089D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M922_DancingHippos.$StartEvent$42685(this).GetEnumerator();
	}

	// Token: 0x06009A7C RID: 39548 RVA: 0x0120A7E4 File Offset: 0x012089E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator SuccessEvent()
	{
		return new M922_DancingHippos.$SuccessEvent$42690(this).GetEnumerator();
	}

	// Token: 0x06009A7D RID: 39549 RVA: 0x0120A7F4 File Offset: 0x012089F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator FailEvent()
	{
		return new M922_DancingHippos.$FailEvent$42694(this).GetEnumerator();
	}

	// Token: 0x06009A7E RID: 39550 RVA: 0x0120A804 File Offset: 0x01208A04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitDancingHippo()
	{
		if (287908 - 468714 != -180806)
		{
		}
		for (;;)
		{
			this.DRTnexrleuA = (((Texture)Resources.Load("GameGui/DancingHippo/button_blank", typeof(Texture))) as Texture);
			if (32949 - 368528 == -335579)
			{
				this.ojdneTJ3Orn = (((Texture)Resources.Load("GameGui/DancingHippo/button_up", typeof(Texture))) as Texture);
				if (290551 - 13185 == 277366)
				{
					this.kucneYOgGYS = (((Texture)Resources.Load("GameGui/DancingHippo/button_left", typeof(Texture))) as Texture);
					if (231987 - 181331 != 50657)
					{
						this.Yyfne3X1B3i = (((Texture)Resources.Load("GameGui/DancingHippo/button_right", typeof(Texture))) as Texture);
						if (224156 - 469307 != -245150)
						{
							this.ti2nebM4C4J = (((Texture)Resources.Load("GameGui/DancingHippo/button_down", typeof(Texture))) as Texture);
							if (132949 - 566099 != -433149)
							{
								this.FdCnedbZIjK = (((Texture)Resources.Load("GameGui/DancingHippo/button_mouse1", typeof(Texture))) as Texture);
								if (158181 - 257424 == -99243)
								{
									this.OpSnegoptcT = (((Texture)Resources.Load("GameGui/DancingHippo/button_mouse2", typeof(Texture))) as Texture);
									if (109443 - 4547 == 104896)
									{
										this.zyAneaX6Zlo = (((Texture)Resources.Load("GameGui/DancingHippo/button_wrong", typeof(Texture))) as Texture);
										if (41971 - 217609 == -175638)
										{
											this.fdTne45lmf8 = (AudioClip)Resources.Load("Sound/GUI/tick", typeof(AudioClip));
											if (128370 - 468763 == -340393)
											{
												this.ujanesgpQm9 = (AudioClip)Resources.Load("Sound/GUI/ring", typeof(AudioClip));
												if (15306 - 127734 != -112427)
												{
													this.FuKneH95Zth = (AudioClip)Resources.Load("Sound/GUI/cancel", typeof(AudioClip));
													if (104122 - 94236 == 9886)
													{
														this.Guyne7cI8qa = (AudioClip)Resources.Load("Sound/GUI/whistle", typeof(AudioClip));
														if (67515 - 408248 != -340732)
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

	// Token: 0x06009A7F RID: 39551 RVA: 0x0120AB10 File Offset: 0x01208D10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartNewRound(int nRandomDance)
	{
		if (40925 - 263318 != -222393)
		{
		}
		for (;;)
		{
			this.qdPneZwoHo7 = 0;
			if (284425 - 417293 == -132868)
			{
				this.sSnneCjghSj = (int)Time.time;
				if (57301 - 259967 != -202665)
				{
					this.rT2neMTSORG = 1;
					if (43190 - 133307 == -90117)
					{
						this.KMNnefEskBD++;
						if (44489 - 508238 != -463748)
						{
							this.TOpneLNUpSa = 0;
							if (231024 - 203690 == 27334)
							{
								this.KE5nelomcib.alignToObject("DanceCamera1");
								if (110417 - 436988 != -326570)
								{
									this.ResetDanceList(nRandomDance);
									if (90774 - 512809 == -422035)
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

	// Token: 0x06009A80 RID: 39552 RVA: 0x0120AC44 File Offset: 0x01208E44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderDancingHippo()
	{
		if (104549 - 33518 != 71031)
		{
		}
		for (;;)
		{
			IL_40:
			int num = this.qdPneZwoHo7;
			if (296149 - 69618 != 226532)
			{
				if (num == 0)
				{
					if (207586 - 590157 != -382570)
					{
						if (Time.time <= (float)(this.sSnneCjghSj + 2))
						{
							break;
						}
						if (95689 - 598393 != -502703)
						{
							this.sSnneCjghSj = (int)Time.time;
							if (35716 - 263712 != -227995)
							{
								this.rT2neMTSORG = 1;
								if (151547 - 181839 != -30291)
								{
									this.qdPneZwoHo7 = 1;
									if (227710 - 492208 != -264497)
									{
										break;
									}
								}
							}
						}
					}
				}
				else if (num == 1)
				{
					if (184374 - 521000 != -336625)
					{
						int i = 0;
						if (73905 - 24735 != 49171)
						{
							while (i < this.TOpneLNUpSa)
							{
								int num2 = this.RRlnewQ4pfT[i];
								if (206042 - 53007 != 153035)
								{
									goto IL_40;
								}
								if (num2 == 1)
								{
									if (238341 - 563154 == -324812)
									{
										goto IL_40;
									}
									GUI.DrawTexture(new Rect(0.5f * this.wHkneqVtTNd - (float)(50 * Extensions.get_length(this.RRlnewQ4pfT)) + (float)(100 * i), (float)180, (float)64, (float)64), this.ojdneTJ3Orn);
									if (183378 - 156741 == 26638)
									{
										goto IL_40;
									}
								}
								else if (num2 == 2)
								{
									if (37265 - 220434 != -183169)
									{
										goto IL_40;
									}
									GUI.DrawTexture(new Rect(0.5f * this.wHkneqVtTNd - (float)(50 * Extensions.get_length(this.RRlnewQ4pfT)) + (float)(100 * i), (float)180, (float)64, (float)64), this.kucneYOgGYS);
									if (13954 - 266805 == -252850)
									{
										goto IL_40;
									}
								}
								else if (num2 == 3)
								{
									if (22765 - 212158 == -189392)
									{
										goto IL_40;
									}
									GUI.DrawTexture(new Rect(0.5f * this.wHkneqVtTNd - (float)(50 * Extensions.get_length(this.RRlnewQ4pfT)) + (float)(100 * i), (float)180, (float)64, (float)64), this.Yyfne3X1B3i);
									if (177978 - 553752 != -375774)
									{
										goto IL_40;
									}
								}
								else if (num2 == 4)
								{
									if (231830 - 405559 != -173729)
									{
										goto IL_40;
									}
									GUI.DrawTexture(new Rect(0.5f * this.wHkneqVtTNd - (float)(50 * Extensions.get_length(this.RRlnewQ4pfT)) + (float)(100 * i), (float)180, (float)64, (float)64), this.ti2nebM4C4J);
									if (296992 - 360564 == -63571)
									{
										goto IL_40;
									}
								}
								else if (num2 == 5)
								{
									if (261320 - 201462 == 59859)
									{
										goto IL_40;
									}
									GUI.DrawTexture(new Rect(0.5f * this.wHkneqVtTNd - (float)(50 * Extensions.get_length(this.RRlnewQ4pfT)) + (float)(100 * i), (float)180, (float)64, (float)64), this.FdCnedbZIjK);
									if (152881 - 409806 == -256924)
									{
										goto IL_40;
									}
								}
								else if (num2 == 6)
								{
									if (204817 - 315166 == -110348)
									{
										goto IL_40;
									}
									GUI.DrawTexture(new Rect(0.5f * this.wHkneqVtTNd - (float)(50 * Extensions.get_length(this.RRlnewQ4pfT)) + (float)(100 * i), (float)180, (float)64, (float)64), this.OpSnegoptcT);
									if (62474 - 379912 != -317438)
									{
										goto IL_40;
									}
								}
								i++;
								if (210647 - 588771 != -378124)
								{
									goto IL_40;
								}
							}
							if (221484 - 23852 == 197632)
							{
								if (Time.time > (float)(this.sSnneCjghSj + this.rT2neMTSORG))
								{
									if (274790 - 393803 != -119012)
									{
										if (this.TOpneLNUpSa < Extensions.get_length(this.RRlnewQ4pfT))
										{
											if (196888 - 388762 == -191874)
											{
												this.sSnneCjghSj += this.rT2neMTSORG;
												if (73664 - 301302 != -227637)
												{
													if (this.RRlnewQ4pfT[this.TOpneLNUpSa] <= 4)
													{
														if (166542 - 193581 != -27039)
														{
															continue;
														}
														this.rT2neMTSORG = 1;
														if (76934 - 75221 != 1713)
														{
															continue;
														}
													}
													else
													{
														this.rT2neMTSORG = 3;
														if (272836 - 368815 != -95979)
														{
															continue;
														}
													}
													if (this.vlLneEVMbmb != null)
													{
														if (138727 - 37870 == 100858)
														{
															continue;
														}
														GameObject gameObject = this.vlLneEVMbmb[0];
														if (92147 - 125845 == -33697)
														{
															continue;
														}
														int num3 = this.RRlnewQ4pfT[this.TOpneLNUpSa];
														if (2599 - 155566 == -152966)
														{
															continue;
														}
														if (num3 == 1)
														{
															if (127035 - 491124 != -364089)
															{
																continue;
															}
															gameObject.animation.Play("stepUp");
															if (62390 - 232514 != -170124)
															{
																continue;
															}
															if (PlayerPrefs.GetInt("nvoice", 1) != 0)
															{
																if (109670 - 306876 != -197206)
																{
																	continue;
																}
																if (this.up_vc)
																{
																	if (157030 - 280816 == -123785)
																	{
																		continue;
																	}
																	this.audio.PlayOneShot(this.up_vc);
																	if (39039 - 214858 != -175819)
																	{
																		continue;
																	}
																}
															}
														}
														else if (num3 == 2)
														{
															if (66112 - 359312 != -293200)
															{
																continue;
															}
															gameObject.animation.Play("stepLeft");
															if (296850 - 354299 != -57449)
															{
																continue;
															}
															if (PlayerPrefs.GetInt("nvoice", 1) != 0)
															{
																if (251747 - 402284 == -150536)
																{
																	continue;
																}
																if (this.left_vc)
																{
																	if (298929 - 446266 == -147336)
																	{
																		continue;
																	}
																	this.audio.PlayOneShot(this.left_vc);
																	if (216114 - 577770 == -361655)
																	{
																		continue;
																	}
																}
															}
														}
														else if (num3 == 3)
														{
															if (295648 - 43488 == 252161)
															{
																continue;
															}
															gameObject.animation.Play("stepRight");
															if (159851 - 148369 != 11482)
															{
																continue;
															}
															if (PlayerPrefs.GetInt("nvoice", 1) != 0)
															{
																if (142472 - 412925 == -270452)
																{
																	continue;
																}
																if (this.right_vc)
																{
																	if (163544 - 257859 != -94315)
																	{
																		continue;
																	}
																	this.audio.PlayOneShot(this.right_vc);
																	if (59150 - 483748 != -424598)
																	{
																		continue;
																	}
																}
															}
														}
														else if (num3 == 4)
														{
															if (151788 - 297132 != -145344)
															{
																continue;
															}
															gameObject.animation.Play("stepDown");
															if (98704 - 526867 != -428163)
															{
																continue;
															}
															if (PlayerPrefs.GetInt("nvoice", 1) != 0)
															{
																if (167202 - 19519 != 147683)
																{
																	continue;
																}
																if (this.down_vc)
																{
																	if (197126 - 171286 != 25840)
																	{
																		continue;
																	}
																	this.audio.PlayOneShot(this.down_vc);
																	if (209397 - 381583 != -172186)
																	{
																		continue;
																	}
																}
															}
														}
														else if (num3 == 5)
														{
															if (49890 - 535655 == -485764)
															{
																continue;
															}
															gameObject.animation.Play("danceLeft");
															if (100420 - 550025 == -449604)
															{
																continue;
															}
															if (PlayerPrefs.GetInt("nvoice", 1) != 0)
															{
																if (242989 - 43385 == 199605)
																{
																	continue;
																}
																if (this.spin_vc)
																{
																	if (180108 - 359425 != -179317)
																	{
																		continue;
																	}
																	this.audio.PlayOneShot(this.spin_vc);
																	if (36820 - 35574 != 1246)
																	{
																		continue;
																	}
																}
															}
														}
														else if (num3 == 6)
														{
															if (280757 - 403760 == -123002)
															{
																continue;
															}
															gameObject.animation.Play("danceRight");
															if (206121 - 531298 != -325177)
															{
																continue;
															}
															if (PlayerPrefs.GetInt("nvoice", 1) != 0)
															{
																if (120973 - 505299 == -384325)
																{
																	continue;
																}
																if (this.spin_vc)
																{
																	if (292402 - 166763 == 125640)
																	{
																		continue;
																	}
																	this.audio.PlayOneShot(this.spin_vc);
																	if (30111 - 452699 == -422587)
																	{
																		continue;
																	}
																}
															}
														}
														else
														{
															gameObject.animation.Play("dance");
															if (278087 - 288142 != -10055)
															{
																continue;
															}
														}
													}
													this.TOpneLNUpSa++;
													if (39917 - 390887 == -350970)
													{
														if (!this.ujanesgpQm9)
														{
															break;
														}
														if (83969 - 537996 != -454026)
														{
															this.audio.PlayOneShot(this.ujanesgpQm9);
															if (234076 - 438980 != -204903)
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
											this.qdPneZwoHo7 = 2;
											if (38727 - 41122 != -2394)
											{
												this.TOpneLNUpSa = 0;
												if (117711 - 87883 == 29828)
												{
													this.sSnneCjghSj = (int)Time.time;
													if (272903 - 70772 != 202132)
													{
														this.rT2neMTSORG = 1;
														if (264836 - 31443 == 233393)
														{
															this.KE5nelomcib.alignToObject("DanceCamera2");
															if (36262 - 32794 == 3468)
															{
																this.PlayHippoAnimation("dance", 0);
																if (64733 - 390181 != -325447)
																{
																	if (!this.Guyne7cI8qa)
																	{
																		break;
																	}
																	if (255949 - 12685 != 243265)
																	{
																		this.audio.PlayOneShot(this.Guyne7cI8qa);
																		if (88911 - 507239 != -418327)
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
								else
								{
									if (this.rT2neMTSORG != 1)
									{
										break;
									}
									if (192405 - 56714 == 135691)
									{
										if (Time.time <= (float)this.sSnneCjghSj + 0.5f)
										{
											break;
										}
										if (78229 - 363337 == -285108)
										{
											if (this.vlLneEVMbmb == null)
											{
												break;
											}
											if (106307 - 48419 != 57889)
											{
												if (!(this.vlLneEVMbmb[0] != null))
												{
													break;
												}
												if (98363 - 414748 == -316385)
												{
													this.vlLneEVMbmb[0].animation.CrossFade("dance", 0.2f);
													if (243412 - 528657 == -285245)
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
				else if (num == 2)
				{
					if (44087 - 212761 == -168674)
					{
						int j = 0;
						if (110435 - 305762 == -195327)
						{
							while (j < this.TOpneLNUpSa)
							{
								int num4 = this.ScSneUc4GRx[j];
								if (109333 - 548727 != -439394)
								{
									goto IL_40;
								}
								if (num4 == 1)
								{
									if (259283 - 532419 != -273136)
									{
										goto IL_40;
									}
									GUI.DrawTexture(new Rect(0.5f * this.wHkneqVtTNd - (float)(50 * Extensions.get_length(this.RRlnewQ4pfT)) + (float)(100 * j), (float)180, (float)64, (float)64), this.ojdneTJ3Orn);
									if (63278 - 531905 != -468627)
									{
										goto IL_40;
									}
								}
								else if (num4 == 2)
								{
									if (19003 - 521485 == -502481)
									{
										goto IL_40;
									}
									GUI.DrawTexture(new Rect(0.5f * this.wHkneqVtTNd - (float)(50 * Extensions.get_length(this.RRlnewQ4pfT)) + (float)(100 * j), (float)180, (float)64, (float)64), this.kucneYOgGYS);
									if (108157 - 578120 != -469963)
									{
										goto IL_40;
									}
								}
								else if (num4 == 3)
								{
									if (47472 - 110103 == -62630)
									{
										goto IL_40;
									}
									GUI.DrawTexture(new Rect(0.5f * this.wHkneqVtTNd - (float)(50 * Extensions.get_length(this.RRlnewQ4pfT)) + (float)(100 * j), (float)180, (float)64, (float)64), this.Yyfne3X1B3i);
									if (20442 - 101772 != -81330)
									{
										goto IL_40;
									}
								}
								else if (num4 == 4)
								{
									if (160341 - 53177 != 107164)
									{
										goto IL_40;
									}
									GUI.DrawTexture(new Rect(0.5f * this.wHkneqVtTNd - (float)(50 * Extensions.get_length(this.RRlnewQ4pfT)) + (float)(100 * j), (float)180, (float)64, (float)64), this.ti2nebM4C4J);
									if (233809 - 502809 == -268999)
									{
										goto IL_40;
									}
								}
								else if (num4 == 5)
								{
									if (258681 - 134157 == 124525)
									{
										goto IL_40;
									}
									GUI.DrawTexture(new Rect(0.5f * this.wHkneqVtTNd - (float)(50 * Extensions.get_length(this.RRlnewQ4pfT)) + (float)(100 * j), (float)180, (float)64, (float)64), this.FdCnedbZIjK);
									if (293512 - 469986 != -176474)
									{
										goto IL_40;
									}
								}
								else if (num4 == 6)
								{
									if (294227 - 429080 == -134852)
									{
										goto IL_40;
									}
									GUI.DrawTexture(new Rect(0.5f * this.wHkneqVtTNd - (float)(50 * Extensions.get_length(this.RRlnewQ4pfT)) + (float)(100 * j), (float)180, (float)64, (float)64), this.OpSnegoptcT);
									if (60685 - 222119 == -161433)
									{
										goto IL_40;
									}
								}
								else if (num4 == -1)
								{
									if (41529 - 204512 == -162982)
									{
										goto IL_40;
									}
									GUI.DrawTexture(new Rect(0.5f * this.wHkneqVtTNd - (float)(50 * Extensions.get_length(this.RRlnewQ4pfT)) + (float)(100 * j), (float)180, (float)64, (float)64), this.zyAneaX6Zlo);
									if (118897 - 465503 == -346605)
									{
										goto IL_40;
									}
								}
								else
								{
									GUI.DrawTexture(new Rect(0.5f * this.wHkneqVtTNd - (float)(50 * Extensions.get_length(this.RRlnewQ4pfT)) + (float)(100 * j), (float)180, (float)64, (float)64), this.DRTnexrleuA);
									if (68125 - 567235 != -499110)
									{
										goto IL_40;
									}
								}
								j++;
								if (224025 - 354752 != -130727)
								{
									goto IL_40;
								}
							}
							if (211371 - 194011 != 17361)
							{
								if (this.TOpneLNUpSa > 0)
								{
									if (58103 - 265305 == -207201)
									{
										continue;
									}
									if (this.TOpneLNUpSa <= Extensions.get_length(this.RRlnewQ4pfT))
									{
										if (65759 - 377383 == -311623)
										{
											continue;
										}
										if (Input.GetKeyDown(KeyCode.W))
										{
											goto IL_71E;
										}
										if (186810 - 179293 == 7518)
										{
											continue;
										}
										if (Input.GetKeyDown(KeyCode.UpArrow))
										{
											if (128303 - 433813 != -305510)
											{
												continue;
											}
											goto IL_71E;
										}
										IL_1634:
										if (Input.GetKeyDown(KeyCode.A))
										{
											goto IL_1729;
										}
										if (184523 - 371999 == -187475)
										{
											continue;
										}
										if (Input.GetKeyDown(KeyCode.LeftArrow))
										{
											if (11526 - 136910 != -125383)
											{
												goto IL_1729;
											}
											continue;
										}
										IL_10E2:
										if (Input.GetKeyDown(KeyCode.D))
										{
											goto IL_2200;
										}
										if (279783 - 185425 == 94359)
										{
											continue;
										}
										if (Input.GetKeyDown(KeyCode.RightArrow))
										{
											if (27900 - 12196 != 15704)
											{
												continue;
											}
											goto IL_2200;
										}
										IL_1415:
										if (Input.GetKeyDown(KeyCode.S))
										{
											goto IL_1462;
										}
										if (267710 - 55144 != 212566)
										{
											continue;
										}
										if (Input.GetKeyDown(KeyCode.DownArrow))
										{
											if (136990 - 3656 != 133335)
											{
												goto IL_1462;
											}
											continue;
										}
										IL_55F:
										if (Input.GetMouseButtonDown(0))
										{
											if (3615 - 248616 != -245001)
											{
												continue;
											}
											if (this.ScSneUc4GRx[this.TOpneLNUpSa - 1] == 0)
											{
												if (10621 - 391470 != -380849)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (283788 - 285526 != -1737)
													{
														if (this.RRlnewQ4pfT[this.TOpneLNUpSa - 1] == 5)
														{
															if (12115 - 405179 != -393064)
															{
																continue;
															}
															this.ScSneUc4GRx[this.TOpneLNUpSa - 1] = 5;
															if (207308 - 30701 == 176608)
															{
																continue;
															}
															this.PlayHippoAnimation("danceLeft", this.wA6nerkNsPo);
															if (185017 - 47152 != 137865)
															{
																continue;
															}
															Game.sendMissionEvent(9223, this.wA6nerkNsPo);
															if (233265 - 205932 != 27333)
															{
																continue;
															}
															if (this.ujanesgpQm9)
															{
																if (93603 - 536123 != -442520)
																{
																	continue;
																}
																this.audio.PlayOneShot(this.ujanesgpQm9);
																if (9095 - 169753 == -160657)
																{
																	continue;
																}
															}
															if (PlayerPrefs.GetInt("nvoice", 1) != 0)
															{
																if (42476 - 126102 == -83625)
																{
																	continue;
																}
																if (this.spin_vc)
																{
																	if (220474 - 226848 == -6373)
																	{
																		continue;
																	}
																	this.audio.PlayOneShot(this.spin_vc);
																	if (34821 - 438076 == -403254)
																	{
																		continue;
																	}
																}
															}
														}
														else
														{
															this.ScSneUc4GRx[this.TOpneLNUpSa - 1] = -1;
															if (206864 - 65340 != 141524)
															{
																continue;
															}
															this.PlayHippoAnimation("danceWrong", this.wA6nerkNsPo);
															if (169206 - 43249 != 125957)
															{
																continue;
															}
															Game.sendMissionEvent(9224, this.wA6nerkNsPo);
															if (174831 - 57235 == 117597)
															{
																continue;
															}
															if (this.FuKneH95Zth)
															{
																if (16987 - 71220 != -54233)
																{
																	continue;
																}
																this.audio.PlayOneShot(this.FuKneH95Zth);
																if (101251 - 409276 == -308024)
																{
																	continue;
																}
															}
															if (PlayerPrefs.GetInt("nvoice", 1) != 0)
															{
																if (231739 - 389808 != -158069)
																{
																	continue;
																}
																if (this.wrong_vc)
																{
																	if (251523 - 37516 != 214007)
																	{
																		continue;
																	}
																	this.audio.PlayOneShot(this.wrong_vc);
																	if (235787 - 33262 == 202526)
																	{
																		continue;
																	}
																}
															}
														}
														goto IL_2432;
													}
													continue;
												}
											}
										}
										if (Input.GetMouseButtonDown(1))
										{
											if (250913 - 439879 == -188965)
											{
												continue;
											}
											if (this.ScSneUc4GRx[this.TOpneLNUpSa - 1] == 0)
											{
												if (269906 - 506189 == -236282)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (116349 - 27318 != 89032)
													{
														if (this.RRlnewQ4pfT[this.TOpneLNUpSa - 1] == 6)
														{
															if (271462 - 457596 == -186133)
															{
																continue;
															}
															this.ScSneUc4GRx[this.TOpneLNUpSa - 1] = 6;
															if (31247 - 492360 != -461113)
															{
																continue;
															}
															this.PlayHippoAnimation("danceRight", this.wA6nerkNsPo);
															if (255841 - 337538 != -81697)
															{
																continue;
															}
															Game.sendMissionEvent(9223, this.wA6nerkNsPo);
															if (39271 - 264067 != -224796)
															{
																continue;
															}
															if (this.ujanesgpQm9)
															{
																if (140053 - 151138 != -11085)
																{
																	continue;
																}
																this.audio.PlayOneShot(this.ujanesgpQm9);
																if (222073 - 496048 == -273974)
																{
																	continue;
																}
															}
															if (PlayerPrefs.GetInt("nvoice", 1) != 0)
															{
																if (243877 - 251279 == -7401)
																{
																	continue;
																}
																if (this.spin_vc)
																{
																	if (292986 - 576131 != -283145)
																	{
																		continue;
																	}
																	this.audio.PlayOneShot(this.spin_vc);
																	if (90175 - 396636 == -306460)
																	{
																		continue;
																	}
																}
															}
														}
														else
														{
															this.ScSneUc4GRx[this.TOpneLNUpSa - 1] = -1;
															if (151450 - 197076 != -45626)
															{
																continue;
															}
															this.PlayHippoAnimation("danceWrong", this.wA6nerkNsPo);
															if (256596 - 445002 == -188405)
															{
																continue;
															}
															Game.sendMissionEvent(9224, this.wA6nerkNsPo);
															if (280856 - 316436 == -35579)
															{
																continue;
															}
															if (this.FuKneH95Zth)
															{
																if (239691 - 256187 != -16496)
																{
																	continue;
																}
																this.audio.PlayOneShot(this.FuKneH95Zth);
																if (255990 - 215746 != 40244)
																{
																	continue;
																}
															}
															if (PlayerPrefs.GetInt("nvoice", 1) != 0)
															{
																if (87962 - 3017 == 84946)
																{
																	continue;
																}
																if (this.wrong_vc)
																{
																	if (258030 - 546553 == -288522)
																	{
																		continue;
																	}
																	this.audio.PlayOneShot(this.wrong_vc);
																	if (225071 - 225450 != -379)
																	{
																		continue;
																	}
																}
															}
														}
														goto IL_2432;
													}
													continue;
												}
											}
										}
										if (Time.time <= (float)this.sSnneCjghSj + 0.5f)
										{
											goto IL_2432;
										}
										if (162294 - 128018 == 34277)
										{
											continue;
										}
										if (this.ScSneUc4GRx[this.TOpneLNUpSa - 1] != 0)
										{
											goto IL_2432;
										}
										if (114295 - 11294 != 103001)
										{
											continue;
										}
										this.ScSneUc4GRx[this.TOpneLNUpSa - 1] = -1;
										if (192886 - 313414 != -120528)
										{
											continue;
										}
										this.PlayHippoAnimation("danceWrong", this.wA6nerkNsPo);
										if (291400 - 362061 == -70660)
										{
											continue;
										}
										Game.sendMissionEvent(9224, this.wA6nerkNsPo);
										if (283462 - 155355 != 128107)
										{
											continue;
										}
										if (this.FuKneH95Zth)
										{
											if (290679 - 39513 == 251167)
											{
												continue;
											}
											this.audio.PlayOneShot(this.FuKneH95Zth);
											if (191741 - 13774 == 177968)
											{
												continue;
											}
										}
										if (PlayerPrefs.GetInt("nvoice", 1) == 0)
										{
											goto IL_2432;
										}
										if (160038 - 523685 != -363647)
										{
											continue;
										}
										if (!this.wrong_vc)
										{
											goto IL_2432;
										}
										if (64260 - 129071 != -64811)
										{
											continue;
										}
										this.audio.PlayOneShot(this.wrong_vc);
										if (235139 - 187916 != 47224)
										{
											goto IL_2432;
										}
										continue;
										IL_1462:
										if (this.ScSneUc4GRx[this.TOpneLNUpSa - 1] != 0)
										{
											goto IL_55F;
										}
										if (252690 - 342951 == -90260)
										{
											continue;
										}
										if (Chat.ChatActive)
										{
											goto IL_55F;
										}
										if (103291 - 314937 != -211646)
										{
											continue;
										}
										if (this.RRlnewQ4pfT[this.TOpneLNUpSa - 1] == 4)
										{
											if (37016 - 235355 != -198339)
											{
												continue;
											}
											this.ScSneUc4GRx[this.TOpneLNUpSa - 1] = 4;
											if (35671 - 418569 == -382897)
											{
												continue;
											}
											this.PlayHippoAnimation("stepDown", this.wA6nerkNsPo);
											if (9362 - 366173 != -356811)
											{
												continue;
											}
											Game.sendMissionEvent(9223, this.wA6nerkNsPo);
											if (204501 - 150701 != 53800)
											{
												continue;
											}
											if (this.ujanesgpQm9)
											{
												if (43283 - 363553 == -320269)
												{
													continue;
												}
												this.audio.PlayOneShot(this.ujanesgpQm9);
												if (157009 - 516597 != -359588)
												{
													continue;
												}
											}
											if (PlayerPrefs.GetInt("nvoice", 1) != 0)
											{
												if (140144 - 94737 != 45407)
												{
													continue;
												}
												if (this.down_vc)
												{
													if (149552 - 445857 != -296305)
													{
														continue;
													}
													this.audio.PlayOneShot(this.down_vc);
													if (223296 - 113970 != 109326)
													{
														continue;
													}
												}
											}
										}
										else
										{
											this.ScSneUc4GRx[this.TOpneLNUpSa - 1] = -1;
											if (278675 - 30829 == 247847)
											{
												continue;
											}
											this.PlayHippoAnimation("danceWrong", this.wA6nerkNsPo);
											if (126256 - 549245 == -422988)
											{
												continue;
											}
											Game.sendMissionEvent(9224, this.wA6nerkNsPo);
											if (43178 - 391636 != -348458)
											{
												continue;
											}
											if (this.FuKneH95Zth)
											{
												if (159815 - 244842 != -85027)
												{
													continue;
												}
												this.audio.PlayOneShot(this.FuKneH95Zth);
												if (41362 - 393879 == -352516)
												{
													continue;
												}
											}
											if (PlayerPrefs.GetInt("nvoice", 1) != 0)
											{
												if (53329 - 193964 == -140634)
												{
													continue;
												}
												if (this.wrong_vc)
												{
													if (23501 - 129408 != -105907)
													{
														continue;
													}
													this.audio.PlayOneShot(this.wrong_vc);
													if (110920 - 139448 == -28527)
													{
														continue;
													}
												}
											}
										}
										goto IL_2432;
										IL_2200:
										if (this.ScSneUc4GRx[this.TOpneLNUpSa - 1] != 0)
										{
											goto IL_1415;
										}
										if (203899 - 481896 != -277997)
										{
											continue;
										}
										if (Chat.ChatActive)
										{
											goto IL_1415;
										}
										if (291950 - 375485 != -83534)
										{
											if (this.RRlnewQ4pfT[this.TOpneLNUpSa - 1] == 3)
											{
												if (262404 - 102894 != 159510)
												{
													continue;
												}
												this.ScSneUc4GRx[this.TOpneLNUpSa - 1] = 3;
												if (229444 - 161119 == 68326)
												{
													continue;
												}
												this.PlayHippoAnimation("stepRight", this.wA6nerkNsPo);
												if (85996 - 520294 == -434297)
												{
													continue;
												}
												Game.sendMissionEvent(9223, this.wA6nerkNsPo);
												if (271512 - 445390 == -173877)
												{
													continue;
												}
												if (this.ujanesgpQm9)
												{
													if (35645 - 298234 != -262589)
													{
														continue;
													}
													this.audio.PlayOneShot(this.ujanesgpQm9);
													if (166493 - 467998 != -301505)
													{
														continue;
													}
												}
												if (PlayerPrefs.GetInt("nvoice", 1) != 0)
												{
													if (156103 - 342897 == -186793)
													{
														continue;
													}
													if (this.right_vc)
													{
														if (254903 - 580889 == -325985)
														{
															continue;
														}
														this.audio.PlayOneShot(this.right_vc);
														if (155422 - 284147 == -128724)
														{
															continue;
														}
													}
												}
											}
											else
											{
												this.ScSneUc4GRx[this.TOpneLNUpSa - 1] = -1;
												if (77298 - 450661 == -373362)
												{
													continue;
												}
												this.PlayHippoAnimation("danceWrong", this.wA6nerkNsPo);
												if (189775 - 190210 == -434)
												{
													continue;
												}
												Game.sendMissionEvent(9224, this.wA6nerkNsPo);
												if (114285 - 169133 != -54848)
												{
													continue;
												}
												if (this.FuKneH95Zth)
												{
													if (12587 - 214645 == -202057)
													{
														continue;
													}
													this.audio.PlayOneShot(this.FuKneH95Zth);
													if (237280 - 108335 == 128946)
													{
														continue;
													}
												}
												if (PlayerPrefs.GetInt("nvoice", 1) != 0)
												{
													if (243684 - 490441 != -246757)
													{
														continue;
													}
													if (this.wrong_vc)
													{
														if (1884 - 151114 == -149229)
														{
															continue;
														}
														this.audio.PlayOneShot(this.wrong_vc);
														if (214053 - 252330 != -38277)
														{
															continue;
														}
													}
												}
											}
											goto IL_2432;
										}
										continue;
										IL_1729:
										if (this.ScSneUc4GRx[this.TOpneLNUpSa - 1] != 0)
										{
											goto IL_10E2;
										}
										if (109894 - 535498 == -425603)
										{
											continue;
										}
										if (Chat.ChatActive)
										{
											goto IL_10E2;
										}
										if (250338 - 446116 != -195778)
										{
											continue;
										}
										if (this.RRlnewQ4pfT[this.TOpneLNUpSa - 1] == 2)
										{
											if (62129 - 61959 != 170)
											{
												continue;
											}
											this.ScSneUc4GRx[this.TOpneLNUpSa - 1] = 2;
											if (149593 - 259433 == -109839)
											{
												continue;
											}
											this.PlayHippoAnimation("stepLeft", this.wA6nerkNsPo);
											if (11118 - 183079 == -171960)
											{
												continue;
											}
											Game.sendMissionEvent(9223, this.wA6nerkNsPo);
											if (31238 - 574931 != -543693)
											{
												continue;
											}
											if (this.ujanesgpQm9)
											{
												if (158212 - 519033 == -360820)
												{
													continue;
												}
												this.audio.PlayOneShot(this.ujanesgpQm9);
												if (193535 - 106435 == 87101)
												{
													continue;
												}
											}
											if (PlayerPrefs.GetInt("nvoice", 1) != 0)
											{
												if (193555 - 123510 == 70046)
												{
													continue;
												}
												if (this.left_vc)
												{
													if (167087 - 296964 == -129876)
													{
														continue;
													}
													this.audio.PlayOneShot(this.left_vc);
													if (226048 - 546780 != -320732)
													{
														continue;
													}
												}
											}
										}
										else
										{
											this.ScSneUc4GRx[this.TOpneLNUpSa - 1] = -1;
											if (32255 - 591060 == -558804)
											{
												continue;
											}
											this.PlayHippoAnimation("danceWrong", this.wA6nerkNsPo);
											if (83917 - 260775 == -176857)
											{
												continue;
											}
											Game.sendMissionEvent(9224, this.wA6nerkNsPo);
											if (94337 - 577676 != -483339)
											{
												continue;
											}
											if (this.FuKneH95Zth)
											{
												if (193036 - 576639 != -383603)
												{
													continue;
												}
												this.audio.PlayOneShot(this.FuKneH95Zth);
												if (133797 - 65903 != 67894)
												{
													continue;
												}
											}
											if (PlayerPrefs.GetInt("nvoice", 1) != 0)
											{
												if (30816 - 23756 != 7060)
												{
													continue;
												}
												if (this.wrong_vc)
												{
													if (290184 - 419590 != -129406)
													{
														continue;
													}
													this.audio.PlayOneShot(this.wrong_vc);
													if (255391 - 488150 != -232759)
													{
														continue;
													}
												}
											}
										}
										goto IL_2432;
										IL_71E:
										if (this.ScSneUc4GRx[this.TOpneLNUpSa - 1] != 0)
										{
											goto IL_1634;
										}
										if (151530 - 34688 == 116843)
										{
											continue;
										}
										if (Chat.ChatActive)
										{
											goto IL_1634;
										}
										if (138337 - 312033 == -173695)
										{
											continue;
										}
										if (this.RRlnewQ4pfT[this.TOpneLNUpSa - 1] == 1)
										{
											if (264835 - 579070 != -314235)
											{
												continue;
											}
											this.ScSneUc4GRx[this.TOpneLNUpSa - 1] = 1;
											if (157721 - 353188 == -195466)
											{
												continue;
											}
											this.PlayHippoAnimation("stepUp", 1);
											if (17995 - 143231 != -125236)
											{
												continue;
											}
											Game.sendMissionEvent(9223, this.wA6nerkNsPo);
											if (274631 - 142077 == 132555)
											{
												continue;
											}
											if (this.ujanesgpQm9)
											{
												if (259341 - 539821 != -280480)
												{
													continue;
												}
												this.audio.PlayOneShot(this.ujanesgpQm9);
												if (2543 - 409740 == -407196)
												{
													continue;
												}
											}
											if (PlayerPrefs.GetInt("nvoice", 1) != 0)
											{
												if (166872 - 489553 != -322681)
												{
													continue;
												}
												if (this.up_vc)
												{
													if (173520 - 126204 != 47316)
													{
														continue;
													}
													this.audio.PlayOneShot(this.up_vc);
													if (31711 - 74188 != -42477)
													{
														continue;
													}
												}
											}
										}
										else
										{
											this.ScSneUc4GRx[this.TOpneLNUpSa - 1] = -1;
											if (81908 - 81307 != 601)
											{
												continue;
											}
											this.PlayHippoAnimation("danceWrong", this.wA6nerkNsPo);
											if (78380 - 109295 == -30914)
											{
												continue;
											}
											Game.sendMissionEvent(9224, this.wA6nerkNsPo);
											if (233252 - 353447 != -120195)
											{
												continue;
											}
											if (this.FuKneH95Zth)
											{
												if (217962 - 98225 != 119737)
												{
													continue;
												}
												this.audio.PlayOneShot(this.FuKneH95Zth);
												if (14462 - 153597 != -139135)
												{
													continue;
												}
											}
											if (PlayerPrefs.GetInt("nvoice", 1) != 0)
											{
												if (84531 - 597858 == -513326)
												{
													continue;
												}
												if (this.wrong_vc)
												{
													if (183723 - 461655 != -277932)
													{
														continue;
													}
													this.audio.PlayOneShot(this.wrong_vc);
													if (248117 - 280932 != -32815)
													{
														continue;
													}
												}
											}
										}
									}
								}
								IL_2432:
								if (Time.time <= (float)(this.sSnneCjghSj + this.rT2neMTSORG))
								{
									break;
								}
								if (112568 - 374967 == -262399)
								{
									if (this.TOpneLNUpSa < Extensions.get_length(this.RRlnewQ4pfT))
									{
										if (116633 - 274034 == -157401)
										{
											this.sSnneCjghSj += this.rT2neMTSORG;
											if (72681 - 249924 != -177242)
											{
												if (this.RRlnewQ4pfT[this.TOpneLNUpSa] <= 4)
												{
													if (168505 - 364940 == -196434)
													{
														continue;
													}
													this.rT2neMTSORG = 1;
													if (73127 - 535214 != -462087)
													{
														continue;
													}
												}
												else
												{
													this.rT2neMTSORG = 3;
													if (169552 - 358751 != -189199)
													{
														continue;
													}
												}
												this.PlayHippoAnimation("dance", 0);
												if (77714 - 394210 == -316496)
												{
													this.TOpneLNUpSa++;
													if (134437 - 429140 == -294703)
													{
														if (!this.fdTne45lmf8)
														{
															break;
														}
														if (122640 - 508314 == -385674)
														{
															this.audio.PlayOneShot(this.fdTne45lmf8);
															if (126219 - 133320 == -7101)
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
										this.qdPneZwoHo7 = 3;
										if (68552 - 584800 == -516248)
										{
											this.sSnneCjghSj = (int)Time.time;
											if (113655 - 376940 == -263285)
											{
												this.PlayHippoAnimation("dance", 0);
												if (163503 - 34747 != 128757)
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
					if (num != 3)
					{
						break;
					}
					if (39623 - 313076 != -273452)
					{
						if (Time.time <= (float)(this.sSnneCjghSj + 2))
						{
							break;
						}
						if (156095 - 512836 != -356740)
						{
							this.qdPneZwoHo7 = 4;
							if (36591 - 14219 == 22372)
							{
								this.KE5nelomcib.alignToObject("DanceCamera1");
								if (184432 - 170967 == 13465)
								{
									if (this.KMNnefEskBD < 10)
									{
										if (96947 - 450713 == -353766)
										{
											Game.sendMissionEvent(9222, this.KMNnefEskBD + 1);
											if (292837 - 284416 != 8422)
											{
												break;
											}
										}
									}
									else
									{
										Game.sendMissionEvent(9225, this.EcsneNdiNeS);
										if (55827 - 485923 == -430096)
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

	// Token: 0x06009A81 RID: 39553 RVA: 0x0120D898 File Offset: 0x0120BA98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetDanceList(int nRandom)
	{
		if (19761 - 336871 != -317110)
		{
		}
		for (;;)
		{
			IL_437:
			this.rT2neMTSORG = 0;
			if (279591 - 59696 != 219896)
			{
				this.RRlnewQ4pfT = new int[Mathf.Clamp(2 + this.KMNnefEskBD, 2, 12)];
				if (289202 - 426600 != -137397)
				{
					this.ScSneUc4GRx = new int[Mathf.Clamp(2 + this.KMNnefEskBD, 2, 12)];
					if (96736 - 553462 != -456725)
					{
						int[] array = new int[12];
						if (13761 - 138861 != -125099)
						{
							int num = Mathf.Clamp(nRandom, 1, 24);
							if (261826 - 87713 == 174113)
							{
								if (num == 1)
								{
									if (293150 - 158251 != 134899)
									{
										continue;
									}
									array = new int[]
									{
										3,
										2,
										1,
										4,
										2,
										3,
										6,
										2,
										3,
										4,
										4,
										1
									};
									if (247933 - 54746 == 193188)
									{
										continue;
									}
								}
								else if (num == 2)
								{
									if (299374 - 383550 == -84175)
									{
										continue;
									}
									array = new int[]
									{
										2,
										3,
										2,
										2,
										3,
										2,
										2,
										3,
										2,
										3,
										3,
										3
									};
									if (114813 - 87357 == 27457)
									{
										continue;
									}
								}
								else if (num == 3)
								{
									if (254239 - 268402 != -14163)
									{
										continue;
									}
									array = new int[]
									{
										1,
										1,
										2,
										1,
										1,
										3,
										1,
										1,
										4,
										1,
										1,
										1
									};
									if (86004 - 28802 == 57203)
									{
										continue;
									}
								}
								else if (num == 4)
								{
									if (139027 - 71721 == 67307)
									{
										continue;
									}
									array = new int[]
									{
										2,
										2,
										3,
										1,
										1,
										4,
										3,
										3,
										2,
										4,
										4,
										1
									};
									if (153755 - 557450 == -403694)
									{
										continue;
									}
								}
								else if (num == 5)
								{
									if (190348 - 307526 == -117177)
									{
										continue;
									}
									array = new int[]
									{
										3,
										1,
										2,
										4,
										1,
										1,
										6,
										2,
										1,
										3,
										4,
										6
									};
									if (284477 - 83790 != 200687)
									{
										continue;
									}
								}
								else if (num == 6)
								{
									if (123559 - 343116 == -219556)
									{
										continue;
									}
									array = new int[]
									{
										1,
										4,
										2,
										3,
										5,
										1,
										2,
										4,
										3,
										5,
										1,
										2
									};
									if (13919 - 68196 != -54277)
									{
										continue;
									}
								}
								else if (num == 7)
								{
									if (209617 - 442219 != -232602)
									{
										continue;
									}
									array = new int[]
									{
										1,
										1,
										2,
										2,
										3,
										3,
										5,
										4,
										4,
										4,
										4,
										5
									};
									if (137816 - 140362 == -2545)
									{
										continue;
									}
								}
								else if (num == 8)
								{
									if (298360 - 209431 != 88929)
									{
										continue;
									}
									array = new int[]
									{
										2,
										3,
										2,
										3,
										5,
										2,
										3,
										2,
										3,
										6,
										3,
										2
									};
									if (100377 - 241381 == -141003)
									{
										continue;
									}
								}
								else if (num == 9)
								{
									if (165582 - 539884 != -374302)
									{
										continue;
									}
									array = new int[]
									{
										3,
										1,
										4,
										2,
										5,
										3,
										3,
										1,
										2,
										5,
										2,
										4
									};
									if (90754 - 373803 == -283048)
									{
										continue;
									}
								}
								else if (num == 10)
								{
									if (59181 - 569901 != -510720)
									{
										continue;
									}
									array = new int[]
									{
										4,
										4,
										2,
										3,
										1,
										1,
										2,
										3,
										5,
										6,
										4,
										4
									};
									if (57041 - 3683 != 53358)
									{
										continue;
									}
								}
								else if (num == 11)
								{
									if (209998 - 538682 != -328684)
									{
										continue;
									}
									array = new int[]
									{
										2,
										4,
										4,
										2,
										5,
										3,
										1,
										1,
										3,
										5,
										1,
										4
									};
									if (203877 - 320483 == -116605)
									{
										continue;
									}
								}
								else if (num == 12)
								{
									if (295686 - 368121 != -72435)
									{
										continue;
									}
									array = new int[]
									{
										3,
										3,
										3,
										3,
										2,
										3,
										2,
										3,
										5,
										6,
										2,
										3
									};
									if (288591 - 311927 != -23336)
									{
										continue;
									}
								}
								else if (num == 13)
								{
									if (176 - 544144 != -543968)
									{
										continue;
									}
									array = new int[]
									{
										4,
										2,
										1,
										3,
										6,
										4,
										2,
										1,
										3,
										6,
										4,
										2
									};
									if (145282 - 182848 != -37566)
									{
										continue;
									}
								}
								else if (num == 14)
								{
									if (198507 - 58327 != 140180)
									{
										continue;
									}
									array = new int[]
									{
										1,
										2,
										3,
										5,
										1,
										2,
										3,
										6,
										1,
										2,
										3,
										4
									};
									if (109577 - 491710 == -382132)
									{
										continue;
									}
								}
								else if (num == 15)
								{
									if (113492 - 128366 != -14874)
									{
										continue;
									}
									array = new int[]
									{
										2,
										4,
										1,
										4,
										6,
										2,
										1,
										2,
										3,
										5,
										2,
										2
									};
									if (264309 - 165741 != 98568)
									{
										continue;
									}
								}
								else if (num == 16)
								{
									if (255159 - 233090 == 22070)
									{
										continue;
									}
									array = new int[]
									{
										2,
										5,
										4,
										5,
										3,
										5,
										4,
										5,
										2,
										5,
										4,
										5
									};
									if (3547 - 147490 != -143943)
									{
										continue;
									}
								}
								else if (num == 17)
								{
									if (184354 - 395306 != -210952)
									{
										continue;
									}
									array = new int[]
									{
										1,
										4,
										1,
										1,
										4,
										1,
										1,
										1,
										5,
										6,
										1,
										2
									};
									if (83297 - 215772 != -132475)
									{
										continue;
									}
								}
								else if (num == 18)
								{
									if (80705 - 390661 != -309956)
									{
										continue;
									}
									array = new int[]
									{
										2,
										3,
										2,
										3,
										2,
										3,
										1,
										2,
										3,
										4,
										5,
										6
									};
									if (167436 - 132041 == 35396)
									{
										continue;
									}
								}
								else if (num == 19)
								{
									if (93781 - 504674 != -410893)
									{
										continue;
									}
									array = new int[]
									{
										1,
										1,
										2,
										2,
										3,
										3,
										4,
										4,
										1,
										2,
										3,
										4
									};
									if (183242 - 586637 == -403394)
									{
										continue;
									}
								}
								else if (num == 20)
								{
									if (257894 - 409323 != -151429)
									{
										continue;
									}
									array = new int[]
									{
										2,
										4,
										3,
										5,
										3,
										4,
										2,
										5,
										2,
										4,
										3,
										6
									};
									if (104072 - 25981 == 78092)
									{
										continue;
									}
								}
								else if (num == 21)
								{
									if (146187 - 217459 != -71272)
									{
										continue;
									}
									array = new int[]
									{
										3,
										1,
										2,
										4,
										6,
										3,
										1,
										2,
										4,
										6,
										3,
										1
									};
									if (282629 - 275797 != 6832)
									{
										continue;
									}
								}
								else if (num == 22)
								{
									if (226485 - 213276 == 13210)
									{
										continue;
									}
									array = new int[]
									{
										4,
										1,
										2,
										3,
										4,
										1,
										5,
										2,
										5,
										3,
										5,
										1
									};
									if (243398 - 99466 == 143933)
									{
										continue;
									}
								}
								else if (num == 23)
								{
									if (185378 - 475334 != -289956)
									{
										continue;
									}
									array = new int[]
									{
										1,
										2,
										3,
										4,
										1,
										2,
										5,
										6,
										1,
										2,
										3,
										4
									};
									if (260952 - 463237 == -202284)
									{
										continue;
									}
								}
								else if (num == 24)
								{
									if (152126 - 112842 == 39285)
									{
										continue;
									}
									array = new int[]
									{
										3,
										4,
										5,
										3,
										4,
										5,
										3,
										4,
										6,
										3,
										4,
										5
									};
									if (240488 - 471629 != -231141)
									{
										continue;
									}
								}
								else
								{
									array = new int[]
									{
										3,
										2,
										1,
										4,
										2,
										3,
										6,
										2,
										3,
										4,
										4,
										1
									};
									if (148217 - 21877 != 126340)
									{
										continue;
									}
								}
								int i = 0;
								if (81910 - 561553 != -479642)
								{
									while (i < Extensions.get_length(this.RRlnewQ4pfT))
									{
										this.RRlnewQ4pfT[i] = array[i];
										if (51280 - 156122 == -104841)
										{
											goto IL_437;
										}
										i++;
										if (253763 - 525435 == -271671)
										{
											goto IL_437;
										}
									}
									if (72804 - 439410 != -366605)
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

	// Token: 0x06009A82 RID: 39554 RVA: 0x0120E23C File Offset: 0x0120C43C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int GetTotalDanceTime(int nStep)
	{
		if (63519 - 378704 != -315184)
		{
		}
		for (;;)
		{
			IL_D5:
			if (Extensions.get_length(this.RRlnewQ4pfT) <= 0)
			{
				if (195959 - 114042 == 81917)
				{
					goto IL_90;
				}
			}
			else
			{
				int num = 0;
				if (189019 - 467090 != -278070)
				{
					int i = 0;
					if (16737 - 487390 == -470653)
					{
						while (i < Extensions.get_length(this.RRlnewQ4pfT))
						{
							if (this.RRlnewQ4pfT[i] <= 4)
							{
								if (245532 - 367659 == -122126)
								{
									goto IL_D5;
								}
								num++;
								if (281611 - 27101 != 254510)
								{
									goto IL_D5;
								}
							}
							else
							{
								num += 3;
								if (298260 - 279447 == 18814)
								{
									goto IL_D5;
								}
							}
							i++;
							if (54020 - 487119 != -433099)
							{
								goto IL_D5;
							}
						}
						if (190869 - 177407 != 13463)
						{
							break;
						}
					}
				}
			}
		}
		return 0;
		IL_90:
		return 0;
	}

	// Token: 0x06009A83 RID: 39555 RVA: 0x0120E398 File Offset: 0x0120C598
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ResetHippoList()
	{
		if (78117 - 465640 != -387523)
		{
		}
		for (;;)
		{
			IL_93:
			this.vlLneEVMbmb = new GameObject[9];
			if (200440 - 377097 != -176656)
			{
				int i = 0;
				if (65316 - 474488 != -409171)
				{
					while (i <= 8)
					{
						this.vlLneEVMbmb[i] = GameObject.Find("HippoDance" + i);
						if (268198 - 127659 == 140540)
						{
							goto IL_93;
						}
						if (!this.vlLneEVMbmb[i])
						{
							if (113215 - 234215 == -120999)
							{
								goto IL_93;
							}
							Debug.LogError("Cannot find HippoDance" + i);
							if (166745 - 29308 != 137437)
							{
								goto IL_93;
							}
						}
						i++;
						if (7416 - 507762 == -500345)
						{
							goto IL_93;
						}
					}
					if (200376 - 30362 == 170014)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009A84 RID: 39556 RVA: 0x0120E4EC File Offset: 0x0120C6EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayHippoAnimation(string nAnimation, int nPlayer)
	{
		if (9899 - 131071 != -121171)
		{
		}
		for (;;)
		{
			IL_DB:
			if (this.vlLneEVMbmb == null)
			{
				if (79117 - 524961 != -445843)
				{
					break;
				}
			}
			else if (Extensions.get_length(this.vlLneEVMbmb) != 9)
			{
				if (294649 - 380266 == -85617)
				{
					break;
				}
			}
			else
			{
				int i = 0;
				if (246763 - 189914 == 56849)
				{
					while (i <= 8)
					{
						if (nPlayer == 0)
						{
							goto IL_8A;
						}
						if (130462 - 112405 == 18058)
						{
							goto IL_DB;
						}
						if (nPlayer == i % this.BJGneRjuuO7 + 1)
						{
							if (23754 - 538773 != -515018)
							{
								goto IL_8A;
							}
							goto IL_DB;
						}
						IL_4B:
						i++;
						if (65376 - 192139 != -126762)
						{
							continue;
						}
						goto IL_DB;
						IL_8A:
						GameObject gameObject = GameObject.Find("HippoDance" + i);
						if (255099 - 535295 == -280195)
						{
							goto IL_DB;
						}
						if (!gameObject)
						{
							goto IL_4B;
						}
						if (174497 - 130174 == 44324)
						{
							goto IL_DB;
						}
						gameObject.animation.CrossFade(nAnimation, 0.2f);
						if (198312 - 17804 != 180508)
						{
							goto IL_DB;
						}
						goto IL_4B;
					}
					if (112397 - 85797 == 26600)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009A85 RID: 39557 RVA: 0x0120E6AC File Offset: 0x0120C8AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (66242 - 519875 != -453633)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (228014 - 479210 != -251195)
			{
				Time.timeScale = 1f;
				if (236716 - 371679 == -134963)
				{
					this.Dohne1ft7q8 = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
					if (83746 - 269250 == -185504)
					{
						this.ResetHippoList();
						if (237637 - 134075 != 103563)
						{
							this.InitDancingHippo();
							if (265965 - 255947 != 10019)
							{
								Hashtable customOpParameters = new Hashtable();
								if (105088 - 44718 == 60370)
								{
									this.hk1nevHr5Br.OpCustom(52, customOpParameters, true);
									if (276776 - 492396 == -215620)
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

	// Token: 0x06009A86 RID: 39558 RVA: 0x0120E7F0 File Offset: 0x0120C9F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (24878 - 113462 != -88584)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (266804 - 75810 == 190994)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (134081 - 568102 != -434020)
				{
					Game.mGameState = eGameState.Setup;
					if (206694 - 355851 != -149156)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009A87 RID: 39559 RVA: 0x0120E894 File Offset: 0x0120CA94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (283576 - 332596 != -49020)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (263275 - 567919 != -304643)
			{
				if (num != PlayerData.UID)
				{
					break;
				}
				if (10987 - 379832 != -368844)
				{
					Game.setGameState(eGameState.Ready);
					if (279406 - 535175 != -255768)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009A88 RID: 39560 RVA: 0x0120E940 File Offset: 0x0120CB40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (228019 - 479615 != -251596)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (3394 - 220047 == -216653)
			{
				Game.mGameState = eGameState.Ready;
				if (110364 - 264416 == -154052)
				{
					GameObject gameObject = GameObject.Find("StartPoint");
					if (201536 - 359845 != -158308)
					{
						if (gameObject)
						{
							if (44190 - 224871 == -180680)
							{
								continue;
							}
							Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position);
							if (97152 - 511519 != -414367)
							{
								continue;
							}
							if (spawnPos != Vector3.zero)
							{
								if (162932 - 530474 == -367541)
								{
									continue;
								}
								this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject.transform.forward);
								if (155851 - 167697 != -11846)
								{
									continue;
								}
							}
							else
							{
								this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
								if (271159 - 345586 == -74426)
								{
									continue;
								}
							}
						}
						Game.sendMissionEvent(9221, 1);
						if (46347 - 518508 == -472161)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009A89 RID: 39561 RVA: 0x0120EB00 File Offset: 0x0120CD00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		Debug.Log("Start Game");
		this.StartCoroutine_Auto(this.StartEvent());
	}

	// Token: 0x06009A8A RID: 39562 RVA: 0x0120EB1C File Offset: 0x0120CD1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06009A8B RID: 39563 RVA: 0x0120EB20 File Offset: 0x0120CD20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (133897 - 525742 != -391845)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (104661 - 132311 != -27649)
			{
				hashtable.Add(71, CID);
				if (35006 - 133655 != -98648)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (212878 - 193586 == 19292)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (220815 - 173322 != 47494)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (55375 - 592295 == -536920)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (147386 - 213014 != -65627)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (236691 - 368146 != -131454)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (147688 - 284719 == -137031)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (91304 - 26028 != 65277)
											{
												this.hk1nevHr5Br.OpCustom(61, hashtable, true);
												if (271593 - 538488 == -266895)
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

	// Token: 0x06009A8C RID: 39564 RVA: 0x0120EDAC File Offset: 0x0120CFAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (195343 - 71152 != 124192)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (250760 - 596099 != -345338)
			{
				if (!gameObject)
				{
					break;
				}
				if (53698 - 85288 != -31589)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (38405 - 356346 != -317940)
					{
						playerCameraControl.target = gameObject;
						if (234323 - 475232 == -240909)
						{
							this.StartGame();
							if (108897 - 143291 != -34393)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009A8D RID: 39565 RVA: 0x0120EE9C File Offset: 0x0120D09C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		Game.createPeer(data);
	}

	// Token: 0x06009A8E RID: 39566 RVA: 0x0120EEA8 File Offset: 0x0120D0A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06009A8F RID: 39567 RVA: 0x0120EED4 File Offset: 0x0120D0D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M922_DancingHippos.$onGameComplete$42698(data, this).GetEnumerator();
	}

	// Token: 0x06009A90 RID: 39568 RVA: 0x0120EEE4 File Offset: 0x0120D0E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M922_DancingHippos.$ReturnToTown$42707(this).GetEnumerator();
	}

	// Token: 0x06009A91 RID: 39569 RVA: 0x0120EEF4 File Offset: 0x0120D0F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M922_DancingHippos.$ReturnToGuild$42711(this).GetEnumerator();
	}

	// Token: 0x06009A92 RID: 39570 RVA: 0x0120EF04 File Offset: 0x0120D104
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M922_DancingHippos.$ReturnToCamp$42714(this).GetEnumerator();
	}

	// Token: 0x06009A93 RID: 39571 RVA: 0x0120EF14 File Offset: 0x0120D114
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (152550 - 307819 != -155268)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (34229 - 578545 != -544315)
			{
				Hashtable hashtable = new Hashtable();
				if (298202 - 184949 == 113253)
				{
					hashtable.Add(43, PlayerData.UID);
					if (74247 - 288615 != -214367)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (290192 - 48927 != 241266)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009A94 RID: 39572 RVA: 0x0120EFEC File Offset: 0x0120D1EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06009A95 RID: 39573 RVA: 0x0120F000 File Offset: 0x0120D200
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (287575 - 127668 != 159908)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (167017 - 197213 == -30196)
			{
				Hashtable hashtable = new Hashtable();
				if (161030 - 106687 == 54343)
				{
					if (Game.mNextGameCode == 30)
					{
						if (109782 - 358149 == -248366)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (10378 - 90201 != -79823)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (20261 - 452713 != -432452)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (175022 - 500387 == -325364)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (184480 - 510540 == -326059)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (84058 - 435120 != -351062)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (209482 - 79785 != 129697)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (212706 - 52340 != 160366)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (74623 - 359066 == -284442)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (87973 - 56890 == 31084)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (74394 - 538746 == -464351)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (135741 - 341709 != -205968)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (52533 - 579824 != -527291)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (286940 - 281972 == 4969)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (229748 - 546096 != -316348)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (235211 - 243516 != -8305)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (13158 - 276857 != -263699)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (274351 - 125372 == 148980)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (38019 - 80456 == -42436)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (285329 - 208632 != 76697)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (260099 - 579704 != -319605)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (277479 - 405619 != -128140)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (23707 - 436868 != -413161)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (204969 - 253918 != -48949)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (48683 - 462221 != -413538)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (215074 - 468255 == -253180)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (165911 - 15667 != 150244)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (14420 - 74694 != -60274)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (225798 - 441281 != -215482)
					{
						this.hk1nevHr5Br.OpCustom(42, hashtable, true);
						if (216887 - 28066 != 188822)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009A96 RID: 39574 RVA: 0x0120F5B4 File Offset: 0x0120D7B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06009A97 RID: 39575 RVA: 0x0120F5C4 File Offset: 0x0120D7C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009A98 RID: 39576 RVA: 0x0120F5C8 File Offset: 0x0120D7C8
	internal static bool kLiIroVLb7vvSCb5XsaR()
	{
		return true;
	}

	// Token: 0x06009A99 RID: 39577 RVA: 0x0120F5CC File Offset: 0x0120D7CC
	internal static bool hVkgUQVLuHQs9Rn9XV1q()
	{
		return false;
	}

	// Token: 0x04008E7C RID: 36476
	private LitePeer hk1nevHr5Br;

	// Token: 0x04008E7D RID: 36477
	private PlayerCameraControl KE5nelomcib;

	// Token: 0x04008E7E RID: 36478
	private float mWAneGw1CZ6;

	// Token: 0x04008E7F RID: 36479
	private Texture Dohne1ft7q8;

	// Token: 0x04008E80 RID: 36480
	private float wHkneqVtTNd;

	// Token: 0x04008E81 RID: 36481
	private int e7EnepI0BLJ;

	// Token: 0x04008E82 RID: 36482
	private int BJGneRjuuO7;

	// Token: 0x04008E83 RID: 36483
	private int wA6nerkNsPo;

	// Token: 0x04008E84 RID: 36484
	public AudioClip hi_vc;

	// Token: 0x04008E85 RID: 36485
	public AudioClip talk_vc;

	// Token: 0x04008E86 RID: 36486
	public AudioClip dance_vc;

	// Token: 0x04008E87 RID: 36487
	private Texture DRTnexrleuA;

	// Token: 0x04008E88 RID: 36488
	private Texture ojdneTJ3Orn;

	// Token: 0x04008E89 RID: 36489
	private Texture kucneYOgGYS;

	// Token: 0x04008E8A RID: 36490
	private Texture Yyfne3X1B3i;

	// Token: 0x04008E8B RID: 36491
	private Texture ti2nebM4C4J;

	// Token: 0x04008E8C RID: 36492
	private Texture FdCnedbZIjK;

	// Token: 0x04008E8D RID: 36493
	private Texture OpSnegoptcT;

	// Token: 0x04008E8E RID: 36494
	private Texture zyAneaX6Zlo;

	// Token: 0x04008E8F RID: 36495
	private AudioClip fdTne45lmf8;

	// Token: 0x04008E90 RID: 36496
	private AudioClip ujanesgpQm9;

	// Token: 0x04008E91 RID: 36497
	private AudioClip FuKneH95Zth;

	// Token: 0x04008E92 RID: 36498
	private AudioClip Guyne7cI8qa;

	// Token: 0x04008E93 RID: 36499
	public AudioClip up_vc;

	// Token: 0x04008E94 RID: 36500
	public AudioClip down_vc;

	// Token: 0x04008E95 RID: 36501
	public AudioClip left_vc;

	// Token: 0x04008E96 RID: 36502
	public AudioClip right_vc;

	// Token: 0x04008E97 RID: 36503
	public AudioClip spin_vc;

	// Token: 0x04008E98 RID: 36504
	public AudioClip wrong_vc;

	// Token: 0x04008E99 RID: 36505
	private int qdPneZwoHo7;

	// Token: 0x04008E9A RID: 36506
	private int sSnneCjghSj;

	// Token: 0x04008E9B RID: 36507
	private int rT2neMTSORG;

	// Token: 0x04008E9C RID: 36508
	private int KMNnefEskBD;

	// Token: 0x04008E9D RID: 36509
	private int TOpneLNUpSa;

	// Token: 0x04008E9E RID: 36510
	private int[] RRlnewQ4pfT;

	// Token: 0x04008E9F RID: 36511
	private int[] ScSneUc4GRx;

	// Token: 0x04008EA0 RID: 36512
	private int EcsneNdiNeS;

	// Token: 0x04008EA1 RID: 36513
	private GameObject[] vlLneEVMbmb;

	// Token: 0x04008EA2 RID: 36514
	private int rxQnePMDk08;

	// Token: 0x020019E5 RID: 6629
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$42685 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009A9A RID: 39578 RVA: 0x0120F5D0 File Offset: 0x0120D7D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$42685(M922_DancingHippos self_)
		{
			if (40668 - 145757 != -105088)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (147105 - 595494 == -448389)
				{
					base..ctor();
					if (126887 - 105000 != 21888)
					{
						this.$self_$42689 = self_;
						if (215436 - 532108 != -316671)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009A9B RID: 39579 RVA: 0x0120F668 File Offset: 0x0120D868
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M922_DancingHippos.$StartEvent$42685.$(this.$self_$42689);
		}

		// Token: 0x06009A9C RID: 39580 RVA: 0x0120F678 File Offset: 0x0120D878
		internal static bool fuw7ybVLIKne1BADx7ET()
		{
			return true;
		}

		// Token: 0x06009A9D RID: 39581 RVA: 0x0120F67C File Offset: 0x0120D87C
		internal static bool D1OJ42VLBdpq7vWBSDC7()
		{
			return false;
		}

		// Token: 0x04008EA3 RID: 36515
		internal M922_DancingHippos $self_$42689;

		// Token: 0x020019E6 RID: 6630
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009A9E RID: 39582 RVA: 0x0120F680 File Offset: 0x0120D880
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M922_DancingHippos self_)
			{
				if (9827 - 22971 != -13143)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (63213 - 100605 == -37392)
					{
						base..ctor();
						if (69860 - 316788 != -246927)
						{
							this.$self_$42688 = self_;
							if (81774 - 348085 == -266311)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009A9F RID: 39583 RVA: 0x0120F718 File Offset: 0x0120D918
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (265234 - 228559 != 36676)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8AF;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (37615 - 454898 != -417283)
							{
								continue;
							}
							goto IL_293;
						}
						else
						{
							this.$self_$42688.KE5nelomcib.StartCoroutine_Auto(this.$self_$42688.KE5nelomcib.slerpToObject("EventCamera2", (float)2));
							if (269718 - 36430 != 233288)
							{
								continue;
							}
							goto IL_84A;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (80439 - 536555 != -456115)
							{
								goto Block_58;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42686 = (StoryGui)this.$self_$42688.GetComponent(typeof(StoryGui));
							if (254472 - 447654 != -193182)
							{
								continue;
							}
							if (!this.$mStoryGui$42686)
							{
								if (29465 - 571648 != -542182)
								{
									goto Block_47;
								}
								continue;
							}
							else
							{
								this.$mStoryGui$42686.startStoryMessage("Hippo", "Hippo", eTalkType.friend);
								if (286645 - 476375 != -189730)
								{
									continue;
								}
								if (PlayerPrefs.GetInt("nvoice", 1) == 0)
								{
									goto IL_BC;
								}
								if (261667 - 595897 == -334229)
								{
									continue;
								}
								if (!this.$self_$42688.hi_vc)
								{
									goto IL_BC;
								}
								if (247693 - 217718 == 29976)
								{
									continue;
								}
								this.$self_$42688.audio.PlayOneShot(this.$self_$42688.hi_vc);
								if (78784 - 290243 != -211458)
								{
									goto Block_40;
								}
								continue;
							}
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (235783 - 219389 != 16395)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							this.$mHeadHippo$42687 = GameObject.Find("HippoDance0");
							if (81202 - 39032 != 42170)
							{
								continue;
							}
							if (this.$mHeadHippo$42687)
							{
								if (104739 - 176632 != -71893)
								{
									continue;
								}
								this.$mHeadHippo$42687.animation.Play("talk");
								if (141148 - 89481 == 51668)
								{
									continue;
								}
							}
							this.$mStoryGui$42686.newStoryMessage("Hippo", "Hippo", Language.getMessage("M922_DancingHippos", 101), eTalkType.friend);
							if (147160 - 353420 != -206260)
							{
								continue;
							}
							goto IL_81;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (247073 - 120650 != 126423)
							{
								continue;
							}
							goto IL_251;
						}
						else
						{
							this.$mStoryGui$42686.newStoryMessage("Hippo", "Hippo", Language.getMessage("M922_DancingHippos", 102), eTalkType.friend);
							if (220326 - 523273 != -302947)
							{
								continue;
							}
							goto IL_737;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (191270 - 16869 != 174402)
							{
								goto Block_51;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42686.newStoryMessage("Hippo", "Hippo", Language.getMessage("M922_DancingHippos", 103), eTalkType.friend);
							if (211074 - 399800 != -188726)
							{
								continue;
							}
							this.$self_$42688.KE5nelomcib.alignToObject("EventCamera3");
							if (170496 - 477275 != -306778)
							{
								goto Block_42;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (58185 - 178675 != -120490)
							{
								continue;
							}
							goto IL_3DB;
						}
						else
						{
							this.$mStoryGui$42686.newStoryMessage("Hippo", "Hippo", Language.getMessage("M922_DancingHippos", 104), eTalkType.friend);
							if (1188 - 15520 != -14332)
							{
								continue;
							}
							this.$self_$42688.PlayHippoAnimation("dance", 0);
							if (150445 - 369866 != -219421)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("nvoice", 1) == 0)
							{
								goto IL_31C;
							}
							if (242714 - 160510 == 82205)
							{
								continue;
							}
							if (!this.$self_$42688.dance_vc)
							{
								goto IL_31C;
							}
							if (106666 - 286802 != -180136)
							{
								continue;
							}
							this.$self_$42688.audio.PlayOneShot(this.$self_$42688.dance_vc);
							if (269455 - 346694 != -77239)
							{
								continue;
							}
							goto IL_31C;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (50738 - 417980 != -367241)
							{
								goto Block_24;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42686.newStoryMessage("Hippo", "Hippo", Language.getMessage("M922_DancingHippos", 105), eTalkType.friend);
							if (83001 - 121739 != -38737)
							{
								goto Block_22;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.Start)
						{
							if (283752 - 47121 != 236632)
							{
								goto Block_18;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42686.close();
							if (132178 - 349490 != -217312)
							{
								continue;
							}
							this.$self_$42688.SendMessage("fadeOut");
							if (181243 - 441479 != -260235)
							{
								goto Block_49;
							}
							continue;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.Start)
						{
							if (78880 - 345421 != -266541)
							{
								continue;
							}
							goto IL_41D;
						}
						else
						{
							this.$self_$42688.KE5nelomcib.alignToObject("DanceCamera1");
							if (257262 - 542711 != -285449)
							{
								continue;
							}
							this.$self_$42688.SendMessage("fadeIn");
							if (296999 - 59852 != 237148)
							{
								goto Block_48;
							}
							continue;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.Start)
						{
							if (199629 - 495280 != -295651)
							{
								continue;
							}
							goto IL_665;
						}
						else
						{
							Game.sendMissionEvent(9222, 1);
							if (123485 - 37292 != 86193)
							{
								continue;
							}
							this.YieldDefault(1);
							if (236861 - 217352 != 19510)
							{
								goto Block_34;
							}
							continue;
						}
						break;
					default:
						if (225373 - 320276 == -94902)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Start;
					if (82592 - 28108 == 54484)
					{
						Game.mStateTime = Time.time;
						if (6219 - 355579 == -349360)
						{
							this.$self_$42688.PlayHippoAnimation("root", 0);
							if (155787 - 578772 != -422984)
							{
								this.$self_$42688.KE5nelomcib.alignToObject("EventCamera1");
								if (75344 - 165400 == -90056)
								{
									this.$self_$42688.SendMessage("fadeIn");
									if (9213 - 73290 != -64076)
									{
										goto Block_59;
									}
								}
							}
						}
					}
				}
				IL_81:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_BC:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_8:
				Block_18:
				IL_251:
				IL_293:
				goto IL_8AF;
				Block_22:
				return this.Yield(9, new WaitForSeconds(3f));
				IL_31C:
				return this.Yield(8, new WaitForSeconds(3f));
				Block_24:
				IL_3DB:
				IL_41D:
				Block_34:
				goto IL_8AF;
				Block_40:
				goto IL_BC;
				Block_42:
				return this.Yield(7, new WaitForSeconds(3f));
				IL_665:
				Block_47:
				goto IL_8AF;
				Block_48:
				return this.Yield(11, new WaitForSeconds(0.5f));
				Block_49:
				return this.Yield(10, new WaitForSeconds(0.5f));
				IL_737:
				return this.Yield(6, new WaitForSeconds(3f));
				Block_51:
				goto IL_8AF;
				IL_84A:
				return this.Yield(3, new WaitForSeconds(2f));
				Block_58:
				goto IL_8AF;
				Block_59:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_8AF:
				return false;
			}

			// Token: 0x06009AA0 RID: 39584 RVA: 0x0120FFE8 File Offset: 0x0120E1E8
			internal static bool a9bRLlVLev6PiYGLSswt()
			{
				return true;
			}

			// Token: 0x06009AA1 RID: 39585 RVA: 0x0120FFEC File Offset: 0x0120E1EC
			internal static bool O4rZsEVLr6HGSliX2KrW()
			{
				return false;
			}

			// Token: 0x04008EA4 RID: 36516
			internal StoryGui $mStoryGui$42686;

			// Token: 0x04008EA5 RID: 36517
			internal GameObject $mHeadHippo$42687;

			// Token: 0x04008EA6 RID: 36518
			internal M922_DancingHippos $self_$42688;
		}
	}

	// Token: 0x020019E7 RID: 6631
	[CompilerGenerated]
	[Serializable]
	internal sealed class $SuccessEvent$42690 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009AA2 RID: 39586 RVA: 0x0120FFF0 File Offset: 0x0120E1F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $SuccessEvent$42690(M922_DancingHippos self_)
		{
			if (110706 - 253637 != -142930)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (188203 - 145837 == 42366)
				{
					base..ctor();
					if (9239 - 251158 == -241919)
					{
						this.$self_$42693 = self_;
						if (255829 - 486306 == -230477)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009AA3 RID: 39587 RVA: 0x01210088 File Offset: 0x0120E288
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M922_DancingHippos.$SuccessEvent$42690.$(this.$self_$42693);
		}

		// Token: 0x06009AA4 RID: 39588 RVA: 0x01210098 File Offset: 0x0120E298
		internal static bool pDSyQvVLjI5G2RMVZJMh()
		{
			return true;
		}

		// Token: 0x06009AA5 RID: 39589 RVA: 0x0121009C File Offset: 0x0120E29C
		internal static bool lBZfaSVLhagnTKvBHlV8()
		{
			return false;
		}

		// Token: 0x04008EA7 RID: 36519
		internal M922_DancingHippos $self_$42693;

		// Token: 0x020019E8 RID: 6632
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009AA6 RID: 39590 RVA: 0x012100A0 File Offset: 0x0120E2A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M922_DancingHippos self_)
			{
				if (255082 - 327001 != -71918)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (180425 - 68663 != 111763)
					{
						base..ctor();
						if (230913 - 548186 == -317273)
						{
							this.$self_$42692 = self_;
							if (209696 - 96208 == 113488)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009AA7 RID: 39591 RVA: 0x01210138 File Offset: 0x0120E338
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (158746 - 535505 != -376759)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_797;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (297370 - 530892 != -233522)
							{
								continue;
							}
							goto IL_65E;
						}
						else
						{
							this.$mStoryGui$42691 = (StoryGui)this.$self_$42692.GetComponent(typeof(StoryGui));
							if (160035 - 285681 != -125646)
							{
								continue;
							}
							if (!this.$mStoryGui$42691)
							{
								if (107055 - 191477 != -84422)
								{
									continue;
								}
								goto IL_31E;
							}
							else
							{
								this.$mStoryGui$42691.startStoryMessage("Hippo", "Hippo", eTalkType.friend);
								if (16661 - 301066 != -284404)
								{
									goto Block_23;
								}
								continue;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (295367 - 181192 != 114176)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42691.newStoryMessage("Hippo", "Hippo", Language.getMessage("M922_DancingHippos", 201), eTalkType.friend);
							if (149892 - 516873 == -366980)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("nvoice", 1) == 0)
							{
								goto IL_11A;
							}
							if (156530 - 446060 != -289530)
							{
								continue;
							}
							if (!this.$self_$42692.talk_vc)
							{
								goto IL_11A;
							}
							if (268258 - 576225 == -307966)
							{
								continue;
							}
							this.$self_$42692.audio.PlayOneShot(this.$self_$42692.talk_vc);
							if (52814 - 357347 != -304533)
							{
								continue;
							}
							goto IL_11A;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (207765 - 38751 != 169014)
							{
								continue;
							}
							goto IL_155;
						}
						else
						{
							this.$mStoryGui$42691.newStoryMessage("Liger", "Boldas", Language.getMessage("M922_DancingHippos", 202), eTalkType.friend);
							if (285552 - 49058 == 236495)
							{
								continue;
							}
							this.$self_$42692.KE5nelomcib.alignToObject("EventCamera5");
							if (38947 - 330348 != -291400)
							{
								goto Block_38;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (191922 - 233989 != -42067)
							{
								continue;
							}
							goto IL_244;
						}
						else
						{
							this.$mStoryGui$42691.newStoryMessage("Liger", "Boldas", Language.getMessage("M922_DancingHippos", 203), eTalkType.friend);
							if (20574 - 308327 != -287752)
							{
								goto Block_17;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (4992 - 228742 != -223749)
							{
								goto Block_43;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42691.newStoryMessage("Liger", "Boldas", Language.getMessage("M922_DancingHippos", 204), eTalkType.friend);
							if (137312 - 238335 != -101023)
							{
								continue;
							}
							goto IL_45A;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (14807 - 63881 != -49074)
							{
								continue;
							}
							goto IL_19A;
						}
						else
						{
							this.$mStoryGui$42691.newStoryMessage("Hornbill", "Hume", Language.getMessage("M922_DancingHippos", 205), eTalkType.friend);
							if (113113 - 289759 != -176646)
							{
								continue;
							}
							goto IL_38F;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (25268 - 214998 != -189729)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42691.newStoryMessage("Liger", "Boldas", Language.getMessage("M922_DancingHippos", 206), eTalkType.friend);
							if (171938 - 582820 != -410881)
							{
								goto Block_48;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (211339 - 533519 != -322179)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42691.newStoryMessage("Hornbill", "Hume", Language.getMessage("M922_DancingHippos", 207), eTalkType.friend);
							if (200235 - 378813 != -178577)
							{
								goto Block_50;
							}
							continue;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (259900 - 317757 != -57856)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42691.newStoryMessage("Liger", "Boldas", Language.getMessage("M922_DancingHippos", 208), eTalkType.friend);
							if (81634 - 510865 != -429230)
							{
								goto Block_47;
							}
							continue;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (169853 - 372716 != -202863)
							{
								continue;
							}
							goto IL_2C5;
						}
						else
						{
							this.$mStoryGui$42691.close();
							if (174137 - 306234 != -132097)
							{
								continue;
							}
							goto IL_289;
						}
						break;
					case 12:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (131869 - 81437 != 50433)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(9226, 1);
							if (139914 - 142168 != -2254)
							{
								continue;
							}
							this.YieldDefault(1);
							if (250241 - 314391 != -64150)
							{
								continue;
							}
							goto IL_797;
						}
						break;
					default:
						if (210678 - 308594 != -97916)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.AllHold;
					if (85206 - 451846 == -366640)
					{
						Game.mStateTime = Time.time;
						if (60099 - 504786 != -444686)
						{
							this.$self_$42692.KE5nelomcib.alignToObject("EventCamera4");
							if (170672 - 534918 != -364245)
							{
								this.$self_$42692.PlayHippoAnimation("danceComplete", 0);
								if (116380 - 494411 != -378030)
								{
									goto Block_49;
								}
							}
						}
					}
				}
				Block_6:
				goto IL_797;
				IL_11A:
				return this.Yield(4, new WaitForSeconds(3f));
				IL_155:
				IL_19A:
				Block_16:
				IL_244:
				goto IL_797;
				Block_17:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_289:
				return this.Yield(12, new WaitForSeconds(1f));
				Block_19:
				IL_2C5:
				IL_31E:
				goto IL_797;
				Block_23:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_25:
				goto IL_797;
				IL_38F:
				return this.Yield(8, new WaitForSeconds(3f));
				Block_27:
				goto IL_797;
				IL_45A:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_38:
				return this.Yield(5, new WaitForSeconds(2f));
				Block_43:
				IL_65E:
				goto IL_797;
				Block_47:
				return this.Yield(11, new WaitForSeconds(2f));
				Block_48:
				return this.Yield(9, new WaitForSeconds(3f));
				Block_49:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_50:
				return this.Yield(10, new WaitForSeconds(3f));
				IL_797:
				return false;
			}

			// Token: 0x06009AA8 RID: 39592 RVA: 0x012108F0 File Offset: 0x0120EAF0
			internal static bool sDFT2yVLsdsDqdtc16Yg()
			{
				return true;
			}

			// Token: 0x06009AA9 RID: 39593 RVA: 0x012108F4 File Offset: 0x0120EAF4
			internal static bool gGfC0EVL9MJgabGKQiQq()
			{
				return false;
			}

			// Token: 0x04008EA8 RID: 36520
			internal StoryGui $mStoryGui$42691;

			// Token: 0x04008EA9 RID: 36521
			internal M922_DancingHippos $self_$42692;
		}
	}

	// Token: 0x020019E9 RID: 6633
	[CompilerGenerated]
	[Serializable]
	internal sealed class $FailEvent$42694 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009AAA RID: 39594 RVA: 0x012108F8 File Offset: 0x0120EAF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $FailEvent$42694(M922_DancingHippos self_)
		{
			if (223383 - 16192 != 207192)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (219515 - 568637 == -349122)
				{
					base..ctor();
					if (155418 - 415460 == -260042)
					{
						this.$self_$42697 = self_;
						if (120421 - 74010 == 46411)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009AAB RID: 39595 RVA: 0x01210990 File Offset: 0x0120EB90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M922_DancingHippos.$FailEvent$42694.$(this.$self_$42697);
		}

		// Token: 0x06009AAC RID: 39596 RVA: 0x012109A0 File Offset: 0x0120EBA0
		internal static bool rDwB8qVL1K1Jy8qAdMdF()
		{
			return true;
		}

		// Token: 0x06009AAD RID: 39597 RVA: 0x012109A4 File Offset: 0x0120EBA4
		internal static bool DnIoI6VL4EtEv7s7WAg7()
		{
			return false;
		}

		// Token: 0x04008EAA RID: 36522
		internal M922_DancingHippos $self_$42697;

		// Token: 0x020019EA RID: 6634
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009AAE RID: 39598 RVA: 0x012109A8 File Offset: 0x0120EBA8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M922_DancingHippos self_)
			{
				if (51467 - 157346 != -105878)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (204448 - 516492 == -312044)
					{
						base..ctor();
						if (93462 - 192963 == -99501)
						{
							this.$self_$42696 = self_;
							if (38858 - 238515 != -199656)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009AAF RID: 39599 RVA: 0x01210A40 File Offset: 0x0120EC40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (4835 - 271941 != -267105)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4FF;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (205965 - 495127 != -289162)
							{
								continue;
							}
							goto IL_1DB;
						}
						else
						{
							this.$mStoryGui$42695 = (StoryGui)this.$self_$42696.GetComponent(typeof(StoryGui));
							if (247554 - 267779 == -20224)
							{
								continue;
							}
							if (!this.$mStoryGui$42695)
							{
								if (205727 - 311639 != -105912)
								{
									continue;
								}
								goto IL_117;
							}
							else
							{
								this.$mStoryGui$42695.startStoryMessage("Hippo", "Hippo", eTalkType.friend);
								if (114951 - 381287 != -266336)
								{
									continue;
								}
								goto IL_42C;
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (201358 - 269026 != -67668)
							{
								continue;
							}
							goto IL_A8;
						}
						else
						{
							this.$mStoryGui$42695.newStoryMessage("Hippo", "Hippo", Language.getMessage("M922_DancingHippos", 301), eTalkType.friend);
							if (175120 - 383307 != -208187)
							{
								continue;
							}
							if (PlayerPrefs.GetInt("nvoice", 1) != 0)
							{
								if (151719 - 247169 != -95450)
								{
									continue;
								}
								if (this.$self_$42696.talk_vc)
								{
									if (269232 - 507583 != -238351)
									{
										continue;
									}
									this.$self_$42696.audio.PlayOneShot(this.$self_$42696.talk_vc);
									if (283255 - 525492 == -242236)
									{
										continue;
									}
								}
							}
							this.$self_$42696.KE5nelomcib.alignToObject("EventCamera4");
							if (33462 - 218098 != -184636)
							{
								continue;
							}
							goto IL_176;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (231236 - 397647 != -166410)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42695.newStoryMessage("Hippo", "Hippo", Language.getMessage("M922_DancingHippos", 302), eTalkType.friend);
							if (222291 - 549824 != -327533)
							{
								continue;
							}
							goto IL_4C4;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (74848 - 2565 != 72284)
							{
								goto Block_34;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$42695.newStoryMessage("Hippo", "Hippo", Language.getMessage("M922_DancingHippos", 303), eTalkType.friend);
							if (204460 - 243653 != -39192)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (281140 - 319215 != -38075)
							{
								continue;
							}
							goto IL_7E;
						}
						else
						{
							this.$mStoryGui$42695.close();
							if (201366 - 13267 != 188100)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (151410 - 305398 != -153987)
							{
								goto Block_31;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(9226, 2);
							if (121919 - 171258 != -49339)
							{
								continue;
							}
							this.YieldDefault(1);
							if (49630 - 28807 != 20823)
							{
								continue;
							}
							goto IL_4FF;
						}
						break;
					default:
						if (198238 - 407323 == -209084)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.AllHold;
					if (187666 - 165999 == 21667)
					{
						Game.mStateTime = Time.time;
						if (177055 - 49246 == 127809)
						{
							this.$self_$42696.KE5nelomcib.alignToObject("EventCamera3");
							if (121031 - 157042 == -36011)
							{
								this.$self_$42696.PlayHippoAnimation("danceFail", 0);
								if (284261 - 395899 != -111637)
								{
									goto Block_15;
								}
							}
						}
					}
				}
				IL_7E:
				goto IL_4FF;
				Block_4:
				return this.Yield(7, new WaitForSeconds(1f));
				IL_A8:
				IL_117:
				goto IL_4FF;
				IL_176:
				return this.Yield(4, new WaitForSeconds(3f));
				Block_12:
				IL_1DB:
				goto IL_4FF;
				Block_15:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_23:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_42C:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_31:
				goto IL_4FF;
				IL_4C4:
				return this.Yield(5, new WaitForSeconds(3f));
				Block_34:
				IL_4FF:
				return false;
			}

			// Token: 0x06009AB0 RID: 39600 RVA: 0x01210F60 File Offset: 0x0120F160
			internal static bool gwq9MTVLzQdVQNcE6hxR()
			{
				return true;
			}

			// Token: 0x06009AB1 RID: 39601 RVA: 0x01210F64 File Offset: 0x0120F164
			internal static bool sTG5RDVOaIOHe7ieja5y()
			{
				return false;
			}

			// Token: 0x04008EAB RID: 36523
			internal StoryGui $mStoryGui$42695;

			// Token: 0x04008EAC RID: 36524
			internal M922_DancingHippos $self_$42696;
		}
	}

	// Token: 0x020019EB RID: 6635
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$42698 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009AB2 RID: 39602 RVA: 0x01210F68 File Offset: 0x0120F168
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$42698(Hashtable data, M922_DancingHippos self_)
		{
			if (69279 - 373567 != -304287)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (13543 - 453582 != -440038)
				{
					base..ctor();
					if (137499 - 25202 != 112298)
					{
						this.$data$42705 = data;
						if (286498 - 96682 == 189816)
						{
							this.$self_$42706 = self_;
							if (119042 - 162124 != -43081)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009AB3 RID: 39603 RVA: 0x01211024 File Offset: 0x0120F224
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M922_DancingHippos.$onGameComplete$42698.$(this.$data$42705, this.$self_$42706);
		}

		// Token: 0x06009AB4 RID: 39604 RVA: 0x01211038 File Offset: 0x0120F238
		internal static bool xXBskZVO5fsj23Cr9GxT()
		{
			return true;
		}

		// Token: 0x06009AB5 RID: 39605 RVA: 0x0121103C File Offset: 0x0120F23C
		internal static bool TQoXo3VOpcRjsfNIaF9W()
		{
			return false;
		}

		// Token: 0x04008EAD RID: 36525
		internal Hashtable $data$42705;

		// Token: 0x04008EAE RID: 36526
		internal M922_DancingHippos $self_$42706;

		// Token: 0x020019EC RID: 6636
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009AB6 RID: 39606 RVA: 0x01211040 File Offset: 0x0120F240
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M922_DancingHippos self_)
			{
				if (135297 - 412032 != -276734)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (227795 - 39990 != 187806)
					{
						base..ctor();
						if (273163 - 142052 == 131111)
						{
							this.$data$42703 = data;
							if (177552 - 419316 == -241764)
							{
								this.$self_$42704 = self_;
								if (125722 - 550000 != -424277)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009AB7 RID: 39607 RVA: 0x012110FC File Offset: 0x0120F2FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (230610 - 57614 != 172996)
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
						this.$mCompleteGui$42700 = (CompleteGui)this.$self_$42704.GetComponent(typeof(CompleteGui));
						if (97279 - 84410 == 12870)
						{
							continue;
						}
						this.$mCompleteGui$42700.Init();
						if (9929 - 179977 == -170047)
						{
							continue;
						}
						this.$mCompleteGui$42700.readData(this.$data$42703);
						if (26363 - 501905 == -475541)
						{
							continue;
						}
						if (this.$result$42699 == 1)
						{
							if (115660 - 328419 != -212759)
							{
								continue;
							}
							this.$mCompleteGui$42700.displayResult(eCompleteType.Success);
							if (40735 - 492373 == -451637)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$42700.displayResult(eCompleteType.Failed);
							if (270490 - 495934 == -225443)
							{
								continue;
							}
						}
						this.$mGameGui$42701 = (GameGui)this.$self_$42704.GetComponent(typeof(GameGui));
						if (250226 - 432463 != -182237)
						{
							continue;
						}
						this.$mStoryGui$42702 = (StoryGui)this.$self_$42704.GetComponent(typeof(StoryGui));
						if (78845 - 376718 != -297873)
						{
							continue;
						}
						if (this.$mGameGui$42701)
						{
							if (180849 - 540976 == -360126)
							{
								continue;
							}
							this.$mGameGui$42701.close();
							if (263750 - 532122 != -268372)
							{
								continue;
							}
						}
						if (this.$mStoryGui$42702)
						{
							if (114537 - 27671 != 86866)
							{
								continue;
							}
							this.$mStoryGui$42702.close();
							if (145365 - 576524 != -431159)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (171217 - 418214 != -246997)
						{
							continue;
						}
						goto IL_352;
					default:
						if (32085 - 346577 != -314492)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$42703[31]);
					if (245534 - 456036 != -210501)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (198552 - 204720 == -6168)
							{
								break;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (23117 - 471793 != -448675)
							{
								this.$result$42699 = RuntimeServices.UnboxInt32(this.$data$42703[31]);
								if (46042 - 536926 != -490883)
								{
									goto Block_11;
								}
							}
						}
					}
				}
				goto IL_352;
				Block_11:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_352:
				return false;
			}

			// Token: 0x06009AB8 RID: 39608 RVA: 0x01211470 File Offset: 0x0120F670
			internal static bool OscjVCVOVbo0rJSBMxjo()
			{
				return true;
			}

			// Token: 0x06009AB9 RID: 39609 RVA: 0x01211474 File Offset: 0x0120F674
			internal static bool Rp6ZnGVOttkiCnFJwOib()
			{
				return false;
			}

			// Token: 0x04008EAF RID: 36527
			internal int $result$42699;

			// Token: 0x04008EB0 RID: 36528
			internal CompleteGui $mCompleteGui$42700;

			// Token: 0x04008EB1 RID: 36529
			internal GameGui $mGameGui$42701;

			// Token: 0x04008EB2 RID: 36530
			internal StoryGui $mStoryGui$42702;

			// Token: 0x04008EB3 RID: 36531
			internal Hashtable $data$42703;

			// Token: 0x04008EB4 RID: 36532
			internal M922_DancingHippos $self_$42704;
		}
	}

	// Token: 0x020019ED RID: 6637
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$42707 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009ABA RID: 39610 RVA: 0x01211478 File Offset: 0x0120F678
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$42707(M922_DancingHippos self_)
		{
			if (297952 - 30126 != 267827)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (69853 - 450397 == -380544)
				{
					base..ctor();
					if (136000 - 345232 != -209231)
					{
						this.$self_$42710 = self_;
						if (215739 - 384217 != -168477)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009ABB RID: 39611 RVA: 0x01211510 File Offset: 0x0120F710
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M922_DancingHippos.$ReturnToTown$42707.$(this.$self_$42710);
		}

		// Token: 0x06009ABC RID: 39612 RVA: 0x01211520 File Offset: 0x0120F720
		internal static bool hN7GFiVONyrmPX6kND7B()
		{
			return true;
		}

		// Token: 0x06009ABD RID: 39613 RVA: 0x01211524 File Offset: 0x0120F724
		internal static bool sdbskZVOYrldJkkM2xDk()
		{
			return false;
		}

		// Token: 0x04008EB5 RID: 36533
		internal M922_DancingHippos $self_$42710;

		// Token: 0x020019EE RID: 6638
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009ABE RID: 39614 RVA: 0x01211528 File Offset: 0x0120F728
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M922_DancingHippos self_)
			{
				if (222882 - 2780 != 220103)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (53807 - 71880 == -18073)
					{
						base..ctor();
						if (135613 - 28884 != 106730)
						{
							this.$self_$42709 = self_;
							if (251398 - 254411 != -3012)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009ABF RID: 39615 RVA: 0x012115C0 File Offset: 0x0120F7C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (245972 - 254150 != -8177)
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
						this.$self_$42709.LeaveGame();
						if (246736 - 334607 != -87871)
						{
							continue;
						}
						this.YieldDefault(1);
						if (222445 - 29126 != 193320)
						{
							goto Block_17;
						}
						continue;
					default:
						if (120617 - 361841 != -241224)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (75609 - 181338 == -105729)
					{
						Game.mStateTime = Time.time;
						if (70554 - 201122 == -130568)
						{
							this.$$switch$7775$42708 = PlayerData.SaveGuild;
							if (75128 - 515472 == -440344)
							{
								if (this.$$switch$7775$42708 == 1)
								{
									if (271052 - 168564 != 102488)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (104507 - 516369 != -411862)
									{
										continue;
									}
								}
								else if (this.$$switch$7775$42708 == 2)
								{
									if (141138 - 190247 != -49109)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (39031 - 508870 == -469838)
									{
										continue;
									}
								}
								else if (this.$$switch$7775$42708 == 3)
								{
									if (212908 - 526687 != -313779)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (218858 - 290564 != -71706)
									{
										continue;
									}
								}
								else if (this.$$switch$7775$42708 == 4)
								{
									if (10979 - 377450 == -366470)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (258225 - 91722 == 166504)
									{
										continue;
									}
								}
								else if (this.$$switch$7775$42708 == 5)
								{
									if (270085 - 552459 != -282374)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (217965 - 353482 != -135517)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (130688 - 103561 != 27127)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (185172 - 508859 == -323686)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (33094 - 372281 != -339187)
									{
										continue;
									}
								}
								this.$self_$42709.SendMessage("fadeOut");
								if (8401 - 576614 == -568213)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_17:
				IL_324:
				return false;
			}

			// Token: 0x06009AC0 RID: 39616 RVA: 0x01211904 File Offset: 0x0120FB04
			internal static bool LTQlkIVOc1ICYlIxBZyc()
			{
				return true;
			}

			// Token: 0x06009AC1 RID: 39617 RVA: 0x01211908 File Offset: 0x0120FB08
			internal static bool mysNn1VOUSh1HL0Xq73M()
			{
				return false;
			}

			// Token: 0x04008EB6 RID: 36534
			internal int $$switch$7775$42708;

			// Token: 0x04008EB7 RID: 36535
			internal M922_DancingHippos $self_$42709;
		}
	}

	// Token: 0x020019EF RID: 6639
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$42711 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009AC2 RID: 39618 RVA: 0x0121190C File Offset: 0x0120FB0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$42711(M922_DancingHippos self_)
		{
			if (133274 - 149698 != -16424)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (19486 - 418580 == -399094)
				{
					base..ctor();
					if (170822 - 317210 != -146387)
					{
						this.$self_$42713 = self_;
						if (27559 - 378587 == -351028)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009AC3 RID: 39619 RVA: 0x012119A4 File Offset: 0x0120FBA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M922_DancingHippos.$ReturnToGuild$42711.$(this.$self_$42713);
		}

		// Token: 0x06009AC4 RID: 39620 RVA: 0x012119B4 File Offset: 0x0120FBB4
		internal static bool MyKmDIVOTSETPjCEgnL6()
		{
			return true;
		}

		// Token: 0x06009AC5 RID: 39621 RVA: 0x012119B8 File Offset: 0x0120FBB8
		internal static bool OUdxw0VO3CutS4G50fSw()
		{
			return false;
		}

		// Token: 0x04008EB8 RID: 36536
		internal M922_DancingHippos $self_$42713;

		// Token: 0x020019F0 RID: 6640
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009AC6 RID: 39622 RVA: 0x012119BC File Offset: 0x0120FBBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M922_DancingHippos self_)
			{
				if (159918 - 342183 != -182264)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (240829 - 567102 == -326273)
					{
						base..ctor();
						if (276658 - 112753 == 163905)
						{
							this.$self_$42712 = self_;
							if (75572 - 25220 != 50353)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009AC7 RID: 39623 RVA: 0x01211A54 File Offset: 0x0120FC54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (48097 - 101697 != -53600)
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
						this.$self_$42712.LeaveGame();
						if (94160 - 445479 == -351318)
						{
							continue;
						}
						this.YieldDefault(1);
						if (24797 - 325653 != -300855)
						{
							goto Block_4;
						}
						continue;
					default:
						if (60602 - 158215 == -97612)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (138630 - 571358 != -432727)
					{
						Game.mStateTime = Time.time;
						if (160823 - 368858 == -208035)
						{
							Game.mNextGameCode = 31;
							if (33803 - 281238 != -247434)
							{
								this.$self_$42712.SendMessage("fadeOut");
								if (22703 - 475565 == -452862)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				Block_4:
				IL_134:
				return false;
			}

			// Token: 0x06009AC8 RID: 39624 RVA: 0x01211BA8 File Offset: 0x0120FDA8
			internal static bool dueOoQVOXbvbfCstn7Ul()
			{
				return true;
			}

			// Token: 0x06009AC9 RID: 39625 RVA: 0x01211BAC File Offset: 0x0120FDAC
			internal static bool VVfbEeVOQdc8QcqlAkrU()
			{
				return false;
			}

			// Token: 0x04008EB9 RID: 36537
			internal M922_DancingHippos $self_$42712;
		}
	}

	// Token: 0x020019F1 RID: 6641
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$42714 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009ACA RID: 39626 RVA: 0x01211BB0 File Offset: 0x0120FDB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$42714(M922_DancingHippos self_)
		{
			if (151700 - 153179 != -1478)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (189024 - 441852 == -252828)
				{
					base..ctor();
					if (253030 - 39427 != 213604)
					{
						this.$self_$42717 = self_;
						if (110080 - 487953 == -377873)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009ACB RID: 39627 RVA: 0x01211C48 File Offset: 0x0120FE48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M922_DancingHippos.$ReturnToCamp$42714.$(this.$self_$42717);
		}

		// Token: 0x06009ACC RID: 39628 RVA: 0x01211C58 File Offset: 0x0120FE58
		internal static bool aMIckwVOkw9VaBpkqkl5()
		{
			return true;
		}

		// Token: 0x06009ACD RID: 39629 RVA: 0x01211C5C File Offset: 0x0120FE5C
		internal static bool yFugP9VOGWIP7mmpEe2d()
		{
			return false;
		}

		// Token: 0x04008EBA RID: 36538
		internal M922_DancingHippos $self_$42717;

		// Token: 0x020019F2 RID: 6642
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009ACE RID: 39630 RVA: 0x01211C60 File Offset: 0x0120FE60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M922_DancingHippos self_)
			{
				if (131426 - 534023 != -402597)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (276246 - 411959 != -135712)
					{
						base..ctor();
						if (296863 - 451349 == -154486)
						{
							this.$self_$42716 = self_;
							if (283730 - 359373 != -75642)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009ACF RID: 39631 RVA: 0x01211CF8 File Offset: 0x0120FEF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (264373 - 146153 != 118221)
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
						this.$self_$42716.LeaveGame();
						if (64528 - 182767 != -118239)
						{
							continue;
						}
						this.YieldDefault(1);
						if (182277 - 111275 != 71002)
						{
							continue;
						}
						goto IL_2DA;
					default:
						if (60911 - 58902 != 2009)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (275031 - 27915 == 247116)
					{
						Game.mStateTime = Time.time;
						if (235167 - 409797 != -174629)
						{
							this.$$switch$7777$42715 = PlayerData.SaveGuild;
							if (251181 - 276816 == -25635)
							{
								if (this.$$switch$7777$42715 == 1)
								{
									if (143893 - 56002 == 87892)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (94392 - 237257 != -142865)
									{
										continue;
									}
								}
								else if (this.$$switch$7777$42715 == 2)
								{
									if (15712 - 148961 == -133248)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (158258 - 483980 != -325722)
									{
										continue;
									}
								}
								else if (this.$$switch$7777$42715 == 3)
								{
									if (269408 - 4722 != 264686)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (114399 - 411509 == -297109)
									{
										continue;
									}
								}
								else if (this.$$switch$7777$42715 == 4)
								{
									if (175162 - 5616 != 169546)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (207050 - 533810 == -326759)
									{
										continue;
									}
								}
								else if (this.$$switch$7777$42715 == 5)
								{
									if (277552 - 101851 != 175701)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (170783 - 448747 != -277964)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (273151 - 362966 == -89814)
									{
										continue;
									}
								}
								this.$self_$42716.SendMessage("fadeOut");
								if (243706 - 340535 == -96829)
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

			// Token: 0x06009AD0 RID: 39632 RVA: 0x01211FF4 File Offset: 0x012101F4
			internal static bool hSZUqyVOHrTfGjVKZFgk()
			{
				return true;
			}

			// Token: 0x06009AD1 RID: 39633 RVA: 0x01211FF8 File Offset: 0x012101F8
			internal static bool kZSMGlVOWrNSoywq4Wio()
			{
				return false;
			}

			// Token: 0x04008EBB RID: 36539
			internal int $$switch$7777$42715;

			// Token: 0x04008EBC RID: 36540
			internal M922_DancingHippos $self_$42716;
		}
	}
}
