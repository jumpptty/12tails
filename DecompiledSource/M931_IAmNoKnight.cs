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

// Token: 0x02001AAC RID: 6828
[Serializable]
public class M931_IAmNoKnight : MonoBehaviour
{
	// Token: 0x06009F43 RID: 40771 RVA: 0x01250598 File Offset: 0x0124E798
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M931_IAmNoKnight()
	{
		if (38089 - 242947 != -204858)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (155654 - 379277 != -223622)
			{
				base..ctor();
				if (230232 - 510202 == -279970)
				{
					this.E3mnJnXvmnI = 39;
					if (217440 - 461313 == -243873)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009F44 RID: 40772 RVA: 0x01250634 File Offset: 0x0124E834
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (294977 - 85442 != 209536)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (47921 - 238448 == -190527)
			{
				Game.mGameType = 5;
				if (184138 - 341556 == -157418)
				{
					if (Chat.Initialized)
					{
						if (93958 - 453002 != -359043)
						{
							Chat.ChatDisplay.Clear();
							if (49204 - 49902 == -698)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (275338 - 88658 == 186680)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009F45 RID: 40773 RVA: 0x01250718 File Offset: 0x0124E918
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (55629 - 512778 != -457149)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (187594 - 181510 != 6085)
				{
					if (Game.mNextGameCode != 931)
					{
						break;
					}
					if (196576 - 383741 == -187165)
					{
						Game.nextGame();
						if (119140 - 123540 != -4399)
						{
							Game.mGameCode = 931;
							if (62663 - 13210 != 49454)
							{
								Game.mGameType = 5;
								if (101982 - 401513 == -299531)
								{
									Game.mGameTime = Time.time;
									if (120884 - 9361 == 111523)
									{
										Game.mGameScore = 0;
										if (245364 - 327091 == -81727)
										{
											Game.mGameMana = 0;
											if (159249 - 190591 != -31341)
											{
												Game.canUseItem = MissionData.getAllowItem(Game.mGameCode);
												if (297190 - 223857 == 73333)
												{
													Game.canUseMount = MissionData.getAllowMount(Game.mGameCode);
													if (96417 - 299353 == -202936)
													{
														Game.canChangeChar = MissionData.getAllowChange(Game.mGameCode);
														if (151547 - 542700 != -391152)
														{
															Game.canRespawn = MissionData.getAllowRespawn(Game.mGameCode);
															if (145038 - 250325 != -105286)
															{
																Game.canUseCoin = MissionData.getAllowCoin(Game.mGameCode);
																if (95782 - 24412 == 71370)
																{
																	this.p5GnIVryeKM = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
																	if (3986 - 328645 != -324658)
																	{
																		this.A0pnIyLQoxp = PhotonClient.Connection;
																		if (97534 - 239184 == -141650)
																		{
																			PhotonClient.ActorNrList.Clear();
																			if (235715 - 181740 != 53976)
																			{
																				this.InitGame();
																				if (233792 - 95095 != 138698)
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
				if (283240 - 117956 != 165285)
				{
					Game.mGameType = 99;
					if (128512 - 23954 == 104558)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009F46 RID: 40774 RVA: 0x01250A20 File Offset: 0x0124EC20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (221842 - 77847 != 143995)
		{
		}
		for (;;)
		{
			if (this.A0pnIyLQoxp == null)
			{
				if (90134 - 304054 == -213920)
				{
					break;
				}
			}
			else
			{
				eGameState mGameState = Game.mGameState;
				if (103513 - 163386 != -59872)
				{
					if (mGameState == eGameState.Init)
					{
						if (188926 - 223317 != -34390)
						{
							AudioListener.volume = 0.1f * (float)Game.volume;
							if (49864 - 129384 == -79520)
							{
								break;
							}
						}
					}
					else if (mGameState == eGameState.Setup)
					{
						if (245462 - 368215 != -122752)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Ready)
					{
						if (87986 - 100868 != -12881)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Start)
					{
						if (28751 - 575862 != -547110)
						{
							break;
						}
					}
					else if (mGameState == eGameState.Normal)
					{
						if (296855 - 383420 == -86565)
						{
							if (Time.time > this.ImgnIhOqsSm)
							{
								if (188458 - 500368 != -311910)
								{
									continue;
								}
								Game.mGameMana++;
								if (178281 - 418299 != -240018)
								{
									continue;
								}
								this.ImgnIhOqsSm = Time.time + (float)12;
								if (231792 - 178383 != 53409)
								{
									continue;
								}
							}
							if (Game.music != 0)
							{
								if (105004 - 458168 == -353163)
								{
									continue;
								}
								if (!this.audio.isPlaying)
								{
									if (177561 - 63562 == 114000)
									{
										continue;
									}
									this.audio.Play();
									if (265649 - 196222 == 69428)
									{
										continue;
									}
								}
							}
							if (Time.time - Game.mStateTime < (float)2)
							{
								if (272850 - 275536 != -2686)
								{
									continue;
								}
								this.audio.volume = Mathf.Lerp((float)0, 0.1f * (float)Game.music, 0.5f * (Time.time - Game.mGameTime));
								if (16016 - 181589 != -165573)
								{
									continue;
								}
							}
							else
							{
								this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (27074 - 180018 == -152943)
								{
									continue;
								}
							}
							if (this.O6UnIzjM4P6 >= 1)
							{
								break;
							}
							if (151591 - 157544 == -5953)
							{
								if (this.U6UnJIvM9Rm + this.pOJnJJ1qAPn >= 15 + this.aR4nJQnl86N * 15)
								{
									if (250720 - 323341 != -72620)
									{
										this.O6UnIzjM4P6 = 1;
										if (262686 - 375305 != -112618)
										{
											Game.sendMissionEvent(9319, 1);
											if (44575 - 308587 == -264012)
											{
												break;
											}
										}
									}
								}
								else
								{
									if (this.aR4nJQnl86N <= 0)
									{
										break;
									}
									if (150970 - 549484 != -398513)
									{
										if (this.W47nJecbE2i >= 15 + this.aR4nJQnl86N * 15)
										{
											break;
										}
										if (234417 - 504665 != -270247)
										{
											if (Time.time <= this.LIVnJtW0SdV)
											{
												break;
											}
											if (54429 - 404534 == -350105)
											{
												this.W47nJecbE2i++;
												if (224981 - 4113 == 220868)
												{
													this.LIVnJtW0SdV = Time.time + Mathf.Clamp((float)(7 - Mathf.FloorToInt(0.01f * (Time.time - Game.mStateTime) * (float)this.aR4nJQnl86N)), 2f, 7f);
													if (27216 - 278630 != -251413)
													{
														int num = UnityEngine.Random.Range(0, 100);
														if (121746 - 441409 != -319662)
														{
															if (this.W47nJecbE2i < 5)
															{
																if (285041 - 326792 == -41751)
																{
																	Game.sendMissionEvent(9311, this.W47nJecbE2i);
																	if (13472 - 63876 == -50404)
																	{
																		break;
																	}
																}
															}
															else if (this.W47nJecbE2i < 15)
															{
																if (214552 - 159824 == 54728)
																{
																	if (num < 60)
																	{
																		if (153539 - 358209 != -204669)
																		{
																			Game.sendMissionEvent(9311, this.W47nJecbE2i);
																			if (105723 - 565937 != -460213)
																			{
																				break;
																			}
																		}
																	}
																	else
																	{
																		Game.sendMissionEvent(9312, this.W47nJecbE2i);
																		if (96963 - 424092 == -327129)
																		{
																			break;
																		}
																	}
																}
															}
															else if (num < 40)
															{
																if (178788 - 87597 == 91191)
																{
																	Game.sendMissionEvent(9311, this.W47nJecbE2i);
																	if (100136 - 176906 != -76769)
																	{
																		break;
																	}
																}
															}
															else if (num < 75)
															{
																if (120706 - 398875 != -278168)
																{
																	Game.sendMissionEvent(9312, this.W47nJecbE2i);
																	if (206465 - 492940 != -286474)
																	{
																		break;
																	}
																}
															}
															else
															{
																Game.sendMissionEvent(9313, this.W47nJecbE2i);
																if (252995 - 39614 != 213382)
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
					else if (mGameState == eGameState.Hold)
					{
						if (214126 - 294054 != -79927)
						{
							break;
						}
					}
					else if (mGameState == eGameState.AllHold)
					{
						if (28321 - 251604 != -223282)
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
						if (14641 - 178511 == -163870)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009F47 RID: 40775 RVA: 0x0125112C File Offset: 0x0124F32C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (61866 - 31250 != 30617)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (79235 - 108330 == -29095)
				{
					break;
				}
			}
			else if (!this.GWDnIK1cHR4)
			{
				if (188722 - 27276 == 161446)
				{
					break;
				}
			}
			else
			{
				if (Time.time - Game.mGameTime >= (float)2)
				{
					break;
				}
				if (63199 - 479234 == -416035)
				{
					GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
					if (32371 - 223961 == -191590)
					{
						float num = (float)(1024 * Screen.width / Screen.height);
						if (177461 - 266935 != -89473)
						{
							GUI.depth = 1;
							if (103022 - 431280 != -328257)
							{
								float num2 = Mathf.SmoothStep((float)1, 1.2f, Time.time - Game.mGameTime);
								if (69303 - 75121 == -5818)
								{
									float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - Game.mGameTime, (float)1));
									if (285666 - 498563 == -212897)
									{
										Color color = GUI.color;
										if (11759 - 524022 == -512263)
										{
											color.a = a;
											if (48177 - 234851 == -186674)
											{
												if (158118 - 176906 != -18787)
												{
													Color color2 = GUI.color = color;
													if (97531 - 448814 == -351283)
													{
														if (255623 - 208224 != 47400)
														{
															GUI.DrawTexture(new Rect(0.5f * num - (float)350 * num2, (float)450 - (float)78 * num2, (float)700 * num2, (float)157 * num2), this.GWDnIK1cHR4);
															if (121281 - 418905 != -297623)
															{
																float a2 = 1f;
																if (252280 - 158075 != 94206)
																{
																	Color color3 = GUI.color;
																	if (26627 - 591855 != -565227)
																	{
																		float num3 = color3.a = a2;
																		if (2962 - 495127 != -492164 && 252913 - 561164 != -308250)
																		{
																			Color color4 = GUI.color = color3;
																			if (123353 - 112789 != 10565)
																			{
																				if (155727 - 575510 == -419783)
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

	// Token: 0x06009F48 RID: 40776 RVA: 0x012514B4 File Offset: 0x0124F6B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (139087 - 114474 != 24613)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (299725 - 19793 != 279933)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (137847 - 402144 == -264297)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (221051 - 457414 != -236362)
					{
						int num3 = RuntimeServices.UnboxInt32(data[43]);
						if (9141 - 416670 == -407529)
						{
							int num4 = num;
							if (163435 - 549493 != -386057)
							{
								if (num4 == 9311)
								{
									if (47485 - 49259 != -1773)
									{
										break;
									}
								}
								else if (num4 == -9311)
								{
									if (125117 - 248338 != -123220)
									{
										this.SpawnNewMarch(1, num2);
										if (69244 - 269669 != -200424)
										{
											break;
										}
									}
								}
								else if (num4 == 9312)
								{
									if (21470 - 369904 == -348434)
									{
										break;
									}
								}
								else if (num4 == -9312)
								{
									if (126369 - 547662 == -421293)
									{
										this.SpawnNewMarch(2, num2);
										if (15717 - 471547 == -455830)
										{
											break;
										}
									}
								}
								else if (num4 == 9313)
								{
									if (181914 - 514152 != -332237)
									{
										break;
									}
								}
								else if (num4 == -9313)
								{
									if (185318 - 511175 == -325857)
									{
										this.SpawnNewMarch(3, num2);
										if (24449 - 337631 == -313182)
										{
											break;
										}
									}
								}
								else if (num4 == 9314)
								{
									if (222201 - 152435 == 69766)
									{
										if (!this.CpfnJ6Be6ib[num2])
										{
											break;
										}
										if (290828 - 376460 == -85632)
										{
											this.CpfnJ6Be6ib[num2].SendMessage("OnDead");
											if (21419 - 321216 == -299797)
											{
												this.CpfnJ6Be6ib[num2] = null;
												if (21896 - 133150 == -111254)
												{
													this.U6UnJIvM9Rm++;
													if (126824 - 9493 == 117331)
													{
														break;
													}
												}
											}
										}
									}
								}
								else if (num4 == 9315)
								{
									if (273832 - 179869 != 93964)
									{
										if (!this.CpfnJ6Be6ib[num2])
										{
											break;
										}
										if (255283 - 257557 != -2273)
										{
											this.CpfnJ6Be6ib[num2].SendMessage("OnExit");
											if (191889 - 464201 == -272312)
											{
												this.CpfnJ6Be6ib[num2] = null;
												if (10080 - 215972 == -205892)
												{
													this.pOJnJJ1qAPn++;
													if (130002 - 431196 == -301194)
													{
														break;
													}
												}
											}
										}
									}
								}
								else if (num4 == 9316)
								{
									if (117564 - 264991 == -147427)
									{
										if (this.TB9nJ5LsQSK >= num2)
										{
											break;
										}
										if (49939 - 518859 != -468919)
										{
											this.TB9nJ5LsQSK = num2;
											if (67762 - 581715 != -513952)
											{
												this.SendMessage("newGameMessage", "Mission Score: " + this.TB9nJ5LsQSK);
												if (280022 - 152271 != 127752)
												{
													Chat.SubmitChat("none", "Mission Score: " + this.TB9nJ5LsQSK, eChatType.system, eChatMode.system);
													if (250628 - 385012 != -134383)
													{
														break;
													}
												}
											}
										}
									}
								}
								else if (num4 == 9317)
								{
									if (213581 - 355009 != -141427)
									{
										if (this.a4hnJcb5uxU >= num2)
										{
											break;
										}
										if (154864 - 145402 != 9463)
										{
											this.a4hnJcb5uxU = num2;
											if (148913 - 485352 != -336438)
											{
												this.MarchDamage();
												if (269493 - 35581 == 233912)
												{
													break;
												}
											}
										}
									}
								}
								else if (num4 == 9318)
								{
									if (226676 - 359869 != -133192)
									{
										if (num2 < 10)
										{
											if (248672 - 239060 == 9612)
											{
												this.OnPearlCollected(num2);
												if (16026 - 155899 == -139873)
												{
													break;
												}
											}
										}
										else
										{
											this.OnTridenceCollected(num2);
											if (141158 - 67141 == 74017)
											{
												break;
											}
										}
									}
								}
								else if (num4 == 9319)
								{
									if (10859 - 499539 != -488679)
									{
										break;
									}
								}
								else if (num4 == -9319)
								{
									if (95770 - 288152 == -192382)
									{
										if (num2 != 1)
										{
											break;
										}
										if (297718 - 237466 == 60252)
										{
											if (this.O6UnIzjM4P6 < 1)
											{
												if (42041 - 414866 != -372825)
												{
													continue;
												}
												this.O6UnIzjM4P6 = 1;
												if (170783 - 419133 == -248349)
												{
													continue;
												}
											}
											this.StartCoroutine_Auto(this.CompleteEvent());
											if (151707 - 565708 != -414000)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Warning unknown returnCode:" + num);
									if (297058 - 515553 == -218495)
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

	// Token: 0x06009F49 RID: 40777 RVA: 0x01251BDC File Offset: 0x0124FDDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator StartEvent()
	{
		return new M931_IAmNoKnight.$StartEvent$43302(this).GetEnumerator();
	}

	// Token: 0x06009F4A RID: 40778 RVA: 0x01251BEC File Offset: 0x0124FDEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator CompleteEvent()
	{
		return new M931_IAmNoKnight.$CompleteEvent$43307(this).GetEnumerator();
	}

	// Token: 0x06009F4B RID: 40779 RVA: 0x01251BFC File Offset: 0x0124FDFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator GameOverEvent()
	{
		return new M931_IAmNoKnight.$GameOverEvent$43312(this).GetEnumerator();
	}

	// Token: 0x06009F4C RID: 40780 RVA: 0x01251C0C File Offset: 0x0124FE0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SpawnNewMarch(int nType, int nID)
	{
		if (74039 - 359001 != -284962)
		{
		}
		for (;;)
		{
			IL_132:
			if (29748 - 203488 != -173739)
			{
				GameObject gameObject = null;
				if (272817 - 537057 == -264240)
				{
					if (35786 - 358916 != -323129)
					{
						if (nType == 1)
						{
							if (33061 - 180022 == -146960)
							{
								continue;
							}
							GameObject gameObject2 = GameObject.Find("SpawnPoint1");
							if (282541 - 220905 != 61636)
							{
								continue;
							}
							if (this.neonBugMarch)
							{
								if (9627 - 96933 == -87305)
								{
									continue;
								}
								if (gameObject2)
								{
									if (89630 - 593518 == -503887)
									{
										continue;
									}
									gameObject = (GameObject)UnityEngine.Object.Instantiate(this.neonBugMarch, gameObject2.transform.position, gameObject2.transform.rotation);
									if (93208 - 530669 == -437460)
									{
										continue;
									}
								}
							}
						}
						else if (nType == 2)
						{
							if (260067 - 524523 != -264456)
							{
								continue;
							}
							GameObject gameObject2 = GameObject.Find("SpawnPoint2");
							if (147643 - 461021 == -313377)
							{
								continue;
							}
							if (this.waterBugMarch)
							{
								if (167894 - 63178 == 104717)
								{
									continue;
								}
								if (gameObject2)
								{
									if (235526 - 258313 == -22786)
									{
										continue;
									}
									gameObject = (GameObject)UnityEngine.Object.Instantiate(this.waterBugMarch, gameObject2.transform.position, gameObject2.transform.rotation);
									if (78292 - 201776 != -123484)
									{
										continue;
									}
								}
							}
						}
						else if (nType == 3)
						{
							if (95988 - 246636 != -150648)
							{
								continue;
							}
							GameObject gameObject2 = GameObject.Find("SpawnPoint3");
							if (239683 - 500838 != -261155)
							{
								continue;
							}
							if (this.coralBugMarch)
							{
								if (31253 - 552892 == -521638)
								{
									continue;
								}
								if (gameObject2)
								{
									if (43425 - 235955 != -192530)
									{
										continue;
									}
									gameObject = (GameObject)UnityEngine.Object.Instantiate(this.coralBugMarch, gameObject2.transform.position, gameObject2.transform.rotation);
									if (66085 - 246267 != -180182)
									{
										continue;
									}
								}
							}
						}
						else
						{
							Debug.LogError("Warning unknown marchType:" + nType);
							if (56135 - 118466 == -62330)
							{
								continue;
							}
						}
						if (gameObject)
						{
							if (159727 - 373979 == -214252)
							{
								gameObject.SendMessage("InitMarch", nID);
								if (291529 - 56060 == 235469)
								{
									if (!RuntimeServices.EqualityOperator(this.CpfnJ6Be6ib, null))
									{
										if (256088 - 37479 == 218610)
										{
											continue;
										}
										this.CpfnJ6Be6ib[nID] = gameObject;
										if (273749 - 20262 == 253488)
										{
											continue;
										}
									}
									GameObject[] array = (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), GameObject.FindGameObjectsWithTag("Player"), GameObject.FindGameObjectsWithTag("Enemy"));
									if (226364 - 533594 == -307230)
									{
										int i = 0;
										if (143926 - 552276 == -408350)
										{
											GameObject[] array2 = array;
											if (155760 - 279398 != -123637)
											{
												int length = array2.Length;
												if (63105 - 533093 == -469988)
												{
													while (i < length)
													{
														if (gameObject != array2[i])
														{
															if (35349 - 542739 == -507389)
															{
																goto IL_132;
															}
															Physics.IgnoreCollision(gameObject.collider, array2[i].collider, true);
															if (147123 - 115723 != 31400)
															{
																goto IL_132;
															}
														}
														i++;
														if (151074 - 377305 == -226230)
														{
															goto IL_132;
														}
													}
													if (285947 - 82305 == 203642)
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
							Debug.LogError("Warning SpawnNewMarch Error:" + nType + "@" + nID);
							if (15619 - 544211 != -528591)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009F4D RID: 40781 RVA: 0x01252188 File Offset: 0x01250388
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnMarchDead(int nID)
	{
		if (232405 - 402127 != -169721)
		{
		}
		for (;;)
		{
			this.U6UnJIvM9Rm++;
			if (178287 - 495288 == -317001)
			{
				this.CpfnJ6Be6ib[nID] = null;
				if (192875 - 93234 == 99641)
				{
					Game.sendMissionEvent(9314, nID);
					if (159489 - 374400 != -214910)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009F4E RID: 40782 RVA: 0x01252230 File Offset: 0x01250430
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnMarchExit(int nID)
	{
		if (173478 - 384487 != -211009)
		{
		}
		for (;;)
		{
			this.pOJnJJ1qAPn++;
			if (77901 - 341120 != -263218)
			{
				this.CpfnJ6Be6ib[nID] = null;
				if (109194 - 490606 != -381411)
				{
					Game.sendMissionEvent(9315, nID);
					if (258253 - 560172 != -301918)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009F4F RID: 40783 RVA: 0x012522D8 File Offset: 0x012504D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnMarchScore(int nScore)
	{
		if (255105 - 114804 != 140301)
		{
		}
		for (;;)
		{
			this.TB9nJ5LsQSK += nScore;
			if (200322 - 576693 != -376370 && 4577 - 77132 != -72554)
			{
				if (nScore == 1)
				{
					if (132460 - 181955 != -49495)
					{
						continue;
					}
					this.SendMessage("newGameMessage", "NeonBug eliminated. (+100 score)");
					if (89281 - 283819 == -194537)
					{
						continue;
					}
					Chat.SubmitChat("none", "NeonBug eliminated. (+100 score)", eChatType.system, eChatMode.system);
					if (99616 - 239854 == -140237)
					{
						continue;
					}
				}
				else if (nScore == 3)
				{
					if (22234 - 177507 != -155273)
					{
						continue;
					}
					this.SendMessage("newGameMessage", "WaterBug eliminated. (+300 score)");
					if (39438 - 589068 != -549630)
					{
						continue;
					}
					Chat.SubmitChat("none", "WaterBug eliminated. (+300 score)", eChatType.system, eChatMode.system);
					if (10962 - 48716 == -37753)
					{
						continue;
					}
				}
				else if (nScore == 7)
				{
					if (298204 - 78454 == 219751)
					{
						continue;
					}
					this.SendMessage("newGameMessage", "CoralBug eliminated. (+700 score)");
					if (199362 - 547156 == -347793)
					{
						continue;
					}
					Chat.SubmitChat("none", "CoralBug eliminated. (+700 score)", eChatType.system, eChatMode.system);
					if (253114 - 317256 == -64141)
					{
						continue;
					}
				}
				Game.mGameScore = this.TB9nJ5LsQSK * 100;
				if (278989 - 500732 == -221743)
				{
					Game.sendMissionEvent(9316, this.TB9nJ5LsQSK);
					if (213421 - 473138 == -259717)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009F50 RID: 40784 RVA: 0x01252518 File Offset: 0x01250718
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnMarchDamage(int nDamage)
	{
		if (49551 - 304461 != -254909)
		{
		}
		for (;;)
		{
			this.a4hnJcb5uxU += nDamage;
			if (142881 - 55307 != 87575)
			{
				this.MarchDamage();
				if (269409 - 587654 == -318245)
				{
					Game.sendMissionEvent(9317, this.a4hnJcb5uxU);
					if (130755 - 378598 != -247842)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009F51 RID: 40785 RVA: 0x012525C4 File Offset: 0x012507C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void MarchDamage()
	{
		if (192739 - 119628 != 73111)
		{
		}
		for (;;)
		{
			this.SendMessage("newGameMessage", "Water Palace damage: " + this.a4hnJcb5uxU + "!");
			if (77380 - 81552 == -4172)
			{
				Chat.SubmitChat("none", "Water Palace damage: " + this.a4hnJcb5uxU + "!", eChatType.system, eChatMode.system);
				if (32240 - 59622 != -27381)
				{
					this.SendMessage("UpdateMarchDamage", this.a4hnJcb5uxU);
					if (135833 - 266165 != -130331)
					{
						CameraEffect cameraEffect = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
						if (123900 - 187931 == -64031)
						{
							if (cameraEffect)
							{
								if (50908 - 337735 != -286827)
								{
									continue;
								}
								cameraEffect.AddColorRamp("redRamp", "none", (float)10, new Vector4((float)0, 0.1f, 0.1f, (float)0));
								if (172618 - 112999 != 59619)
								{
									continue;
								}
							}
							if (this.marchDamageFx)
							{
								if (60700 - 471587 == -410886)
								{
									continue;
								}
								this.audio.PlayOneShot(this.marchDamageFx);
								if (132376 - 75200 == 57177)
								{
									continue;
								}
							}
							if (this.a4hnJcb5uxU < 21)
							{
								break;
							}
							if (155613 - 162791 != -7177)
							{
								this.StartCoroutine_Auto(this.GameOverEvent());
								if (15621 - 507672 == -492051)
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

	// Token: 0x06009F52 RID: 40786 RVA: 0x012527F8 File Offset: 0x012509F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnPickUpIcon(int nIconID)
	{
		Game.sendMissionEvent(9318, nIconID);
	}

	// Token: 0x06009F53 RID: 40787 RVA: 0x01252808 File Offset: 0x01250A08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnPearlCollected(int nPearlID)
	{
		if (188282 - 257141 != -68859)
		{
		}
		for (;;)
		{
			this.a4hnJcb5uxU = Mathf.Clamp(this.a4hnJcb5uxU - 7, 0, 21);
			if (209446 - 163189 == 46257)
			{
				this.SendMessage("UpdateMarchDamage", this.a4hnJcb5uxU);
				if (249838 - 423394 == -173556)
				{
					this.SendMessage("newGameMessage", "A pearl has been collected! (+7)");
					if (219219 - 595532 == -376313)
					{
						Chat.SubmitChat("none", "A pearl has been collected! (+7)", eChatType.system, eChatMode.system);
						if (68016 - 24367 != 43650)
						{
							CameraEffect cameraEffect = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
							if (179158 - 565151 != -385992)
							{
								if (cameraEffect)
								{
									if (194245 - 119382 != 74863)
									{
										continue;
									}
									cameraEffect.AddColorRamp("whiteRamp", "none", (float)10, new Vector4((float)0, 0.2f, (float)0, 0.2f));
									if (30824 - 424094 != -393270)
									{
										continue;
									}
								}
								if (this.pearlCollectedFx)
								{
									if (164121 - 587364 != -423243)
									{
										continue;
									}
									this.audio.PlayOneShot(this.pearlCollectedFx);
									if (242748 - 87626 != 155122)
									{
										continue;
									}
								}
								this.TB9nJ5LsQSK += 10;
								if (275787 - 30866 != 244922)
								{
									Game.mGameScore = this.TB9nJ5LsQSK * 100;
									if (265086 - 448169 != -183082)
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

	// Token: 0x06009F54 RID: 40788 RVA: 0x01252A3C File Offset: 0x01250C3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTridenceCollected(int nTridenceID)
	{
		if (148424 - 222154 != -73729)
		{
		}
		for (;;)
		{
			this.E3mnJnXvmnI = Mathf.Clamp(this.E3mnJnXvmnI + 20, 0, 39);
			if (56368 - 267698 != -211329)
			{
				this.SendMessage("UpdateTridenceCount", this.E3mnJnXvmnI);
				if (236793 - 124826 != 111968)
				{
					this.SendMessage("newGameMessage", "+ 20 Tridence!");
					if (224726 - 580004 == -355278)
					{
						Chat.SubmitChat("none", "+20 Tridence!", eChatType.system, eChatMode.system);
						if (232109 - 207747 == 24362)
						{
							CameraEffect cameraEffect = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
							if (173636 - 512138 != -338501)
							{
								cameraEffect.AddColorRamp("whiteRamp", "burstMask", (float)1, new Vector4((float)0, 0.1f, 0.1f, 0.2f));
								if (79604 - 323455 == -243851)
								{
									if (this.tridenceCollectedFx)
									{
										if (22675 - 145599 == -122923)
										{
											continue;
										}
										this.audio.PlayOneShot(this.tridenceCollectedFx);
										if (12949 - 500945 != -487996)
										{
											continue;
										}
									}
									this.TB9nJ5LsQSK += 5;
									if (47083 - 161088 != -114004)
									{
										Game.mGameScore = this.TB9nJ5LsQSK * 100;
										if (192571 - 525343 != -332771)
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

	// Token: 0x06009F55 RID: 40789 RVA: 0x01252C4C File Offset: 0x01250E4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M931_IAmNoKnight.$onGameComplete$43317(data, this).GetEnumerator();
	}

	// Token: 0x06009F56 RID: 40790 RVA: 0x01252C5C File Offset: 0x01250E5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateMarchDamage(object nMarchDamage)
	{
		this.a4hnJcb5uxU = RuntimeServices.UnboxInt32(nMarchDamage);
	}

	// Token: 0x06009F57 RID: 40791 RVA: 0x01252C6C File Offset: 0x01250E6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateTridenceCount(object nTridenceCount)
	{
		this.E3mnJnXvmnI = RuntimeServices.UnboxInt32(nTridenceCount);
	}

	// Token: 0x06009F58 RID: 40792 RVA: 0x01252C7C File Offset: 0x01250E7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitGame()
	{
		if (199372 - 556036 != -356664)
		{
		}
		for (;;)
		{
			Debug.Log("Initializing Mission");
			if (133903 - 497982 == -364079)
			{
				Time.timeScale = 1f;
				if (26075 - 285211 == -259136)
				{
					Game.mStateTime = Time.time;
					if (115099 - 280052 != -164952)
					{
						this.CpfnJ6Be6ib = new GameObject[150];
						if (258251 - 3260 == 254991)
						{
							if (!this.GWDnIK1cHR4)
							{
								if (272197 - 126534 != 145663)
								{
									continue;
								}
								this.GWDnIK1cHR4 = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
								if (156984 - 209695 == -52710)
								{
									continue;
								}
							}
							Hashtable customOpParameters = new Hashtable();
							if (234540 - 534109 == -299569)
							{
								this.A0pnIyLQoxp.OpCustom(52, customOpParameters, true);
								if (16806 - 540993 != -524186)
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

	// Token: 0x06009F59 RID: 40793 RVA: 0x01252DF8 File Offset: 0x01250FF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (258931 - 511383 != -252452)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (204557 - 504373 != -299815)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (276289 - 128373 == 147916)
				{
					Game.mGameState = eGameState.Setup;
					if (78360 - 325811 != -247450)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009F5A RID: 40794 RVA: 0x01252E9C File Offset: 0x0125109C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (250044 - 500365 != -250321)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (151256 - 405078 != -253821)
			{
				if (num == PlayerData.UID)
				{
					if (113194 - 268070 == -154876)
					{
						this.SetupActors();
						if (172610 - 184523 != -11912)
						{
							break;
						}
					}
				}
				else
				{
					this.ClearActors();
					if (142600 - 415443 != -272842)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009F5B RID: 40795 RVA: 0x01252F6C File Offset: 0x0125116C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetupActors()
	{
		if (121707 - 108799 != 12909)
		{
		}
		for (;;)
		{
			IL_19F:
			Debug.Log("Creating Actors");
			if (154143 - 145893 == 8250)
			{
				CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
				if (261507 - 50611 != 210897)
				{
					if (Extensions.get_length(array) > 0)
					{
						if (141568 - 373227 == -231659)
						{
							int i = 0;
							if (45973 - 108701 != -62727)
							{
								CharacterControl[] array2 = array;
								if (100499 - 402848 != -302348)
								{
									int length = array2.Length;
									if (112588 - 92260 == 20328)
									{
										while (i < length)
										{
											if (!array2[i].isChild)
											{
												if (161 - 587695 != -587534)
												{
													goto IL_19F;
												}
												this.createActor(array2[i].Type, array2[i].gameObject.layer - 7, array2[i].transform.position, array2[i].transform.forward);
												if (200203 - 420261 == -220057)
												{
													goto IL_19F;
												}
												UnityEngine.Object.Destroy(array2[i].gameObject);
												if (9403 - 62819 != -53416)
												{
													goto IL_19F;
												}
												this.c1qnJXPIsaK++;
												if (184474 - 388334 != -203860)
												{
													goto IL_19F;
												}
											}
											i++;
											if (27020 - 496230 != -469210)
											{
												goto IL_19F;
											}
										}
										if (131717 - 45456 == 86261)
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
						if (50611 - 249118 != -198506)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009F5C RID: 40796 RVA: 0x012531A8 File Offset: 0x012513A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearActors()
	{
		if (195849 - 558114 != -362265)
		{
		}
		for (;;)
		{
			IL_E0:
			CharacterControl[] array = (CharacterControl[])UnityEngine.Object.FindObjectsOfType(typeof(CharacterControl));
			if (266100 - 437483 == -171383)
			{
				int i = 0;
				if (36338 - 244743 != -208404)
				{
					CharacterControl[] array2 = array;
					if (38993 - 111641 == -72648)
					{
						int length = array2.Length;
						if (144742 - 248967 != -104224)
						{
							while (i < length)
							{
								UnityEngine.Object.Destroy(array2[i].gameObject);
								if (189430 - 452911 == -263480)
								{
									goto IL_E0;
								}
								i++;
								if (152938 - 34270 == 118669)
								{
									goto IL_E0;
								}
							}
							if (220087 - 126935 != 93153)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06009F5D RID: 40797 RVA: 0x012532D8 File Offset: 0x012514D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (190049 - 251917 != -61867)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (2087 - 461627 != -459539)
			{
				Game.mGameState = eGameState.Ready;
				if (213819 - 580331 != -366511)
				{
					int playerSlot = Game.getPlayerSlot(PlayerData.UID);
					if (149393 - 237986 == -88593)
					{
						if (67011 - 366972 != -299960)
						{
							GameObject gameObject;
							if (playerSlot >= 1)
							{
								if (197740 - 541375 != -343635)
								{
									continue;
								}
								if (playerSlot <= 6)
								{
									if (244172 - 338406 != -94234)
									{
										continue;
									}
									gameObject = GameObject.Find("StartPoint" + playerSlot);
									if (160227 - 436328 != -276101)
									{
										continue;
									}
									goto IL_152;
								}
							}
							gameObject = GameObject.Find("StartPoint1");
							if (296303 - 388563 == -92259)
							{
								continue;
							}
							IL_152:
							if (!gameObject)
							{
								break;
							}
							if (255267 - 527265 != -271997)
							{
								Vector3 spawnPos = global::Math.getSpawnPos(gameObject.transform.position);
								if (153536 - 460249 != -306712)
								{
									if (spawnPos != Vector3.zero)
									{
										if (120730 - 454068 == -333338)
										{
											this.CreatePlayer(CharacterData.current.CID, 1, spawnPos, gameObject.transform.forward);
											if (92366 - 17328 == 75038)
											{
												break;
											}
										}
									}
									else
									{
										this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
										if (292994 - 137563 != 155432)
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

	// Token: 0x06009F5E RID: 40798 RVA: 0x01253528 File Offset: 0x01251728
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void StartGame()
	{
		Debug.Log("Start Game");
		this.StartCoroutine_Auto(this.StartEvent());
	}

	// Token: 0x06009F5F RID: 40799 RVA: 0x01253544 File Offset: 0x01251744
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onStartGame()
	{
	}

	// Token: 0x06009F60 RID: 40800 RVA: 0x01253548 File Offset: 0x01251748
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (231212 - 112289 != 118924)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (8622 - 398621 != -389998)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (77414 - 358876 == -281462)
				{
					hashtable.Add(43, PlayerData.UID);
					if (115571 - 215029 == -99458)
					{
						hashtable.Add(73, nType);
						if (210259 - 94684 != 115576)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (70107 - 502447 == -432340)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (65129 - 355147 == -290018)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (261261 - 276338 != -15076)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (176414 - 462061 == -285647)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (169374 - 200828 == -31454)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (200693 - 282469 == -81776)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (50416 - 339538 != -289121)
													{
														this.A0pnIyLQoxp.OpCustom(63, hashtable, true);
														if (129282 - 248015 == -118733)
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

	// Token: 0x06009F61 RID: 40801 RVA: 0x0125382C File Offset: 0x01251A2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreateActor(Hashtable data)
	{
		if (233935 - 453815 != -219880)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (60639 - 27031 != 33609)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = Game.createActor(data);
				if (206699 - 272502 == -65803)
				{
					if (Game.mGameState != eGameState.Setup)
					{
						break;
					}
					if (5056 - 388232 != -383175)
					{
						if (this.c1qnJXPIsaK <= 0)
						{
							break;
						}
						if (215192 - 126912 == 88280)
						{
							this.c1qnJXPIsaK--;
							if (166734 - 123481 == 43253)
							{
								if (this.c1qnJXPIsaK != 0)
								{
									break;
								}
								if (277472 - 223437 != 54036)
								{
									Game.setGameState(eGameState.Ready);
									if (54467 - 580628 != -526160)
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

	// Token: 0x06009F62 RID: 40802 RVA: 0x01253968 File Offset: 0x01251B68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorKo(GameObject nActor)
	{
	}

	// Token: 0x06009F63 RID: 40803 RVA: 0x0125396C File Offset: 0x01251B6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActorDead(GameObject nActor)
	{
	}

	// Token: 0x06009F64 RID: 40804 RVA: 0x01253970 File Offset: 0x01251B70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (12419 - 211639 != -199220)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (101360 - 351267 == -249907)
			{
				hashtable.Add(71, CID);
				if (61557 - 341505 == -279948)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (235067 - 464397 == -229330)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (254495 - 397707 == -143212)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (56912 - 418619 != -361706)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (35167 - 402431 == -367264)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (272352 - 538348 == -265996)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (147703 - 498041 == -350338)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (72058 - 42026 == 30032)
											{
												this.A0pnIyLQoxp.OpCustom(61, hashtable, true);
												if (270870 - 130530 != 140341)
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

	// Token: 0x06009F65 RID: 40805 RVA: 0x01253BFC File Offset: 0x01251DFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (98944 - 397896 != -298951)
		{
		}
		for (;;)
		{
			GameObject gameObject = Game.createPlayer(data);
			if (212649 - 349240 == -136591)
			{
				if (!gameObject)
				{
					break;
				}
				if (34423 - 58844 != -24420)
				{
					PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
					if (200096 - 172747 == 27349)
					{
						playerCameraControl.target = gameObject;
						if (126708 - 132251 == -5543)
						{
							this.aR4nJQnl86N++;
							if (191231 - 116652 == 74579)
							{
								CharacterControl characterControl = (CharacterControl)Game.mPlayer.GetComponent(typeof(CharacterControl));
								if (21304 - 477599 != -456294)
								{
									characterControl.TransformEvent("Annonite", Game.mPlayer.transform.position, Game.mPlayer.transform.forward, 9999);
									if (103711 - 136106 == -32395)
									{
										this.StartGame();
										if (21616 - 174680 == -153064)
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

	// Token: 0x06009F66 RID: 40806 RVA: 0x01253D90 File Offset: 0x01251F90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		if (15033 - 388376 != -373343)
		{
		}
		for (;;)
		{
			Game.createPeer(data);
			if (107409 - 577480 == -470071)
			{
				this.aR4nJQnl86N++;
				if (191477 - 435380 == -243903)
				{
					AnnoniteGui annoniteGui = (AnnoniteGui)this.GetComponent(typeof(AnnoniteGui));
					if (87222 - 486694 != -399471)
					{
						annoniteGui.ResetTeamBar();
						if (90566 - 277168 != -186601)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009F67 RID: 40807 RVA: 0x01253E64 File Offset: 0x01252064
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M931_IAmNoKnight.$onDeadPlayer$43326(this).GetEnumerator();
	}

	// Token: 0x06009F68 RID: 40808 RVA: 0x01253E74 File Offset: 0x01252074
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (99074 - 548381 != -449306)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (275110 - 543700 != -268589)
			{
				PlayerCameraControl playerCameraControl = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
				if (88598 - 427411 == -338813)
				{
					playerCameraControl.target = Game.mPlayer;
					if (176904 - 22520 == 154384)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (83502 - 289979 == -206476)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (24551 - 209921 != -185370)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (251147 - 209337 == 41810)
						{
							AnnoniteGui annoniteGui = (AnnoniteGui)this.GetComponent(typeof(AnnoniteGui));
							if (29359 - 413463 == -384104)
							{
								if (!annoniteGui)
								{
									break;
								}
								if (145690 - 22409 != 123282)
								{
									annoniteGui.close();
									if (141689 - 341466 == -199777)
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

	// Token: 0x06009F69 RID: 40809 RVA: 0x01254004 File Offset: 0x01252204
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (137795 - 505109 != -367314)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (200783 - 263067 != -62283)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (131560 - 272380 == -140820)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (118516 - 23184 == 95332)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06009F6A RID: 40810 RVA: 0x012540C8 File Offset: 0x012522C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x06009F6B RID: 40811 RVA: 0x012540F4 File Offset: 0x012522F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChangePlayer(int nCID)
	{
		if (273179 - 53110 != 220069)
		{
		}
		for (;;)
		{
			int v = Game.mPlayer.layer - 7;
			if (48258 - 92738 == -44480)
			{
				Vector3 position = Game.mPlayer.transform.position;
				if (258235 - 314443 != -56207)
				{
					Vector3 forward = Game.mPlayer.transform.forward;
					if (92391 - 278066 != -185674)
					{
						Hashtable hashtable = new Hashtable();
						if (140526 - 303910 == -163384)
						{
							hashtable.Add(43, PlayerData.UID);
							if (156065 - 375587 == -219522)
							{
								hashtable.Add(71, nCID);
								if (138712 - 362155 != -223442)
								{
									hashtable.Add(75, PhotonClient.cInt16(v));
									if (239993 - 169077 != 70917)
									{
										hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(position.x * (float)50)));
										if (111312 - 471742 == -360430)
										{
											hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(position.y * (float)50)));
											if (279039 - 199269 == 79770)
											{
												hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(position.z * (float)50)));
												if (101079 - 190440 == -89361)
												{
													hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(forward.x * (float)200)));
													if (88679 - 49333 != 39347)
													{
														hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(forward.y * (float)200)));
														if (21175 - 139096 != -117920)
														{
															hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(forward.z * (float)200)));
															if (297400 - 226932 != 70469)
															{
																PhotonClient.Connection.OpCustom(65, hashtable, true);
																if (212615 - 18907 == 193708)
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

	// Token: 0x06009F6C RID: 40812 RVA: 0x01254414 File Offset: 0x01252614
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onChangePlayer(Hashtable data)
	{
		return new M931_IAmNoKnight.$onChangePlayer$43331(data, this).GetEnumerator();
	}

	// Token: 0x06009F6D RID: 40813 RVA: 0x01254424 File Offset: 0x01252624
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M931_IAmNoKnight.$ReturnToTown$43338(this).GetEnumerator();
	}

	// Token: 0x06009F6E RID: 40814 RVA: 0x01254434 File Offset: 0x01252634
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToGuild()
	{
		return new M931_IAmNoKnight.$ReturnToGuild$43343(this).GetEnumerator();
	}

	// Token: 0x06009F6F RID: 40815 RVA: 0x01254444 File Offset: 0x01252644
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToCamp()
	{
		return new M931_IAmNoKnight.$ReturnToCamp$43347(this).GetEnumerator();
	}

	// Token: 0x06009F70 RID: 40816 RVA: 0x01254454 File Offset: 0x01252654
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (210769 - 529980 != -319210)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (495 - 245767 != -245271)
			{
				Hashtable hashtable = new Hashtable();
				if (152854 - 529208 != -376353)
				{
					hashtable.Add(43, PlayerData.UID);
					if (258188 - 87068 != 171121)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (53077 - 228057 == -174980)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009F71 RID: 40817 RVA: 0x0125452C File Offset: 0x0125272C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x06009F72 RID: 40818 RVA: 0x01254540 File Offset: 0x01252740
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (282134 - 387301 != -105167)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (286790 - 35198 != 251593)
			{
				Hashtable hashtable = new Hashtable();
				if (12750 - 105456 != -92705)
				{
					if (Game.mNextGameCode == 30)
					{
						if (116654 - 233368 == -116713)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (160422 - 428665 != -268243)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (197713 - 15902 == 181812)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (202678 - 445074 != -242396)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (10368 - 135241 != -124873)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (12072 - 474212 != -462140)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (153388 - 531313 == -377924)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (7594 - 388876 != -381282)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (239243 - 44225 != 195018)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (157867 - 266227 != -108360)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (173622 - 392121 != -218499)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (138069 - 381797 == -243727)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (197552 - 191318 == 6235)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (287106 - 456623 != -169517)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (258903 - 492811 != -233908)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (22760 - 441511 != -418751)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (92761 - 141194 == -48432)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (32022 - 47736 != -15714)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (105868 - 513807 != -407939)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (211491 - 201470 == 10022)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (172076 - 562401 == -390324)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (267907 - 450856 == -182948)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (119028 - 250716 != -131688)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (127132 - 356662 == -229529)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (82601 - 473360 == -390758)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (220284 - 59903 == 160382)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (121215 - 45429 == 75787)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (241586 - 501950 == -260363)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (112186 - 401324 == -289138)
					{
						this.A0pnIyLQoxp.OpCustom(42, hashtable, true);
						if (41684 - 377166 != -335481)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06009F73 RID: 40819 RVA: 0x01254AF4 File Offset: 0x01252CF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x06009F74 RID: 40820 RVA: 0x01254B04 File Offset: 0x01252D04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06009F75 RID: 40821 RVA: 0x01254B08 File Offset: 0x01252D08
	internal static bool fv81ABVfHXSjvGK3TL1t()
	{
		return true;
	}

	// Token: 0x06009F76 RID: 40822 RVA: 0x01254B0C File Offset: 0x01252D0C
	internal static bool AA5pGkVfW4Y62X8XOCL7()
	{
		return false;
	}

	// Token: 0x04009109 RID: 37129
	private LitePeer A0pnIyLQoxp;

	// Token: 0x0400910A RID: 37130
	private PlayerCameraControl p5GnIVryeKM;

	// Token: 0x0400910B RID: 37131
	private float ImgnIhOqsSm;

	// Token: 0x0400910C RID: 37132
	private Texture GWDnIK1cHR4;

	// Token: 0x0400910D RID: 37133
	private int O6UnIzjM4P6;

	// Token: 0x0400910E RID: 37134
	private int TB9nJ5LsQSK;

	// Token: 0x0400910F RID: 37135
	private int a4hnJcb5uxU;

	// Token: 0x04009110 RID: 37136
	private int E3mnJnXvmnI;

	// Token: 0x04009111 RID: 37137
	private int aR4nJQnl86N;

	// Token: 0x04009112 RID: 37138
	private int W47nJecbE2i;

	// Token: 0x04009113 RID: 37139
	private int U6UnJIvM9Rm;

	// Token: 0x04009114 RID: 37140
	private int pOJnJJ1qAPn;

	// Token: 0x04009115 RID: 37141
	private GameObject[] CpfnJ6Be6ib;

	// Token: 0x04009116 RID: 37142
	private float LIVnJtW0SdV;

	// Token: 0x04009117 RID: 37143
	public GameObject neonBugMarch;

	// Token: 0x04009118 RID: 37144
	public GameObject waterBugMarch;

	// Token: 0x04009119 RID: 37145
	public GameObject coralBugMarch;

	// Token: 0x0400911A RID: 37146
	public AudioClip marchDamageFx;

	// Token: 0x0400911B RID: 37147
	public AudioClip pearlCollectedFx;

	// Token: 0x0400911C RID: 37148
	public AudioClip tridenceCollectedFx;

	// Token: 0x0400911D RID: 37149
	private int c1qnJXPIsaK;

	// Token: 0x02001AAD RID: 6829
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartEvent$43302 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009F77 RID: 40823 RVA: 0x01254B10 File Offset: 0x01252D10
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartEvent$43302(M931_IAmNoKnight self_)
		{
			if (295396 - 313261 != -17865)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (143053 - 47549 == 95504)
				{
					base..ctor();
					if (185665 - 277124 == -91459)
					{
						this.$self_$43306 = self_;
						if (211585 - 193652 != 17934)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009F78 RID: 40824 RVA: 0x01254BA8 File Offset: 0x01252DA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M931_IAmNoKnight.$StartEvent$43302.$(this.$self_$43306);
		}

		// Token: 0x06009F79 RID: 40825 RVA: 0x01254BB8 File Offset: 0x01252DB8
		internal static bool Q1hvyEVfApSBb3F0U9Qx()
		{
			return true;
		}

		// Token: 0x06009F7A RID: 40826 RVA: 0x01254BBC File Offset: 0x01252DBC
		internal static bool m8gHHyVfl4RovPQEknNV()
		{
			return false;
		}

		// Token: 0x0400911E RID: 37150
		internal M931_IAmNoKnight $self_$43306;

		// Token: 0x02001AAE RID: 6830
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009F7B RID: 40827 RVA: 0x01254BC0 File Offset: 0x01252DC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M931_IAmNoKnight self_)
			{
				if (141809 - 596847 != -455037)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (61428 - 207282 != -145853)
					{
						base..ctor();
						if (68286 - 199584 == -131298)
						{
							this.$self_$43305 = self_;
							if (62403 - 85773 == -23370)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009F7C RID: 40828 RVA: 0x01254C58 File Offset: 0x01252E58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (59569 - 354724 != -295154)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_72F;
					case 2:
						if (Game.mGameState != eGameState.Start)
						{
							if (108536 - 555936 != -447399)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							this.$self_$43305.p5GnIVryeKM.StartCoroutine_Auto(this.$self_$43305.p5GnIVryeKM.slerpToObject("EventCamera2", (float)2));
							if (120035 - 473511 != -353475)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Start)
						{
							if (16857 - 56460 != -39603)
							{
								continue;
							}
							goto IL_594;
						}
						else
						{
							this.$mStoryGui$43303 = (StoryGui)this.$self_$43305.GetComponent(typeof(StoryGui));
							if (230568 - 523101 != -292533)
							{
								continue;
							}
							this.$mStoryGui$43303.startStoryMessage("none", "Shrimp Knight", eTalkType.friend);
							if (85488 - 332951 != -247462)
							{
								goto Block_22;
							}
							continue;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.Start)
						{
							if (137963 - 393165 != -255202)
							{
								continue;
							}
							goto IL_6B1;
						}
						else
						{
							this.$mStoryGui$43303.newStoryMessage("none", "Shrimp Knight", Language.getMessage("M931_IAmNoKnight", 101), eTalkType.friend);
							if (179451 - 133084 != 46368)
							{
								goto Block_43;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.Start)
						{
							if (258239 - 177349 != 80890)
							{
								continue;
							}
							goto IL_F6;
						}
						else
						{
							this.$mStoryGui$43303.newStoryMessage("none", "Shrimp Knight", Language.getMessage("M931_IAmNoKnight", 102), eTalkType.friend);
							if (58455 - 17443 == 41013)
							{
								continue;
							}
							this.$self_$43305.p5GnIVryeKM.alignToObject("EventCamera3");
							if (161291 - 423383 != -262091)
							{
								goto Block_37;
							}
							continue;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.Start)
						{
							if (27079 - 325669 != -298589)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43303.newStoryMessage("none", "Shrimp Knight", Language.getMessage("M931_IAmNoKnight", 103), eTalkType.friend);
							if (291035 - 119403 != 171633)
							{
								goto Block_40;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.Start)
						{
							if (198978 - 366624 != -167645)
							{
								goto Block_32;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43303.newStoryMessage("none", "Shrimp Knight", Language.getMessage("M931_IAmNoKnight", 104), eTalkType.friend);
							if (48093 - 518528 != -470434)
							{
								goto Block_41;
							}
							continue;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.Start)
						{
							if (155014 - 592642 != -437627)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43303.close();
							if (107563 - 530251 != -422688)
							{
								continue;
							}
							goto IL_6F3;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.Start)
						{
							if (116979 - 273097 != -156118)
							{
								continue;
							}
							goto IL_1ED;
						}
						else
						{
							this.$self_$43305.SendMessage("fadeOut");
							if (168503 - 283608 != -115104)
							{
								goto Block_13;
							}
							continue;
						}
						break;
					case 10:
						if (Game.mGameState != eGameState.Start)
						{
							if (58290 - 559058 != -500767)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$self_$43305.p5GnIVryeKM.alignToObject("StartPoint" + Game.getPlayerSlot(PlayerData.UID));
							if (115675 - 442855 != -327180)
							{
								continue;
							}
							this.$self_$43305.SendMessage("fadeIn");
							if (76392 - 336842 == -260449)
							{
								continue;
							}
							this.$self_$43305.p5GnIVryeKM.enabled = true;
							if (141209 - 431868 != -290659)
							{
								continue;
							}
							goto IL_505;
						}
						break;
					case 11:
						if (Game.mGameState != eGameState.Start)
						{
							if (234665 - 184774 != 49891)
							{
								continue;
							}
							goto IL_342;
						}
						else
						{
							this.$mAnnoniteGui$43304 = (AnnoniteGui)this.$self_$43305.GetComponent(typeof(AnnoniteGui));
							if (172417 - 379502 != -207085)
							{
								continue;
							}
							this.$mAnnoniteGui$43304.enabled = true;
							if (71207 - 393622 == -322414)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (51422 - 32415 == 19008)
							{
								continue;
							}
							Game.mGameTime = Time.time;
							if (273500 - 471788 == -198287)
							{
								continue;
							}
							Game.mStateTime = Time.time;
							if (19401 - 529412 == -510010)
							{
								continue;
							}
							this.YieldDefault(1);
							if (157909 - 536255 != -378345)
							{
								goto Block_3;
							}
							continue;
						}
						break;
					default:
						if (204344 - 122884 != 81460)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Start;
					if (35003 - 183385 != -148381)
					{
						Game.mStateTime = Time.time;
						if (220008 - 193761 != 26248)
						{
							this.$self_$43305.p5GnIVryeKM.alignToObject("EventCamera1");
							if (54669 - 284150 == -229481)
							{
								this.$self_$43305.SendMessage("fadeIn");
								if (155304 - 365928 != -210623)
								{
									goto Block_6;
								}
							}
						}
					}
				}
				Block_3:
				Block_5:
				goto IL_72F;
				Block_6:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_F6:
				IL_1ED:
				goto IL_72F;
				Block_13:
				return this.Yield(10, new WaitForSeconds(0.6f));
				Block_16:
				Block_21:
				goto IL_72F;
				Block_22:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_342:
				Block_25:
				goto IL_72F;
				Block_27:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_32:
				goto IL_72F;
				IL_505:
				return this.Yield(11, new WaitForSeconds(1f));
				Block_37:
				return this.Yield(6, new WaitForSeconds(3f));
				IL_594:
				goto IL_72F;
				Block_40:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_41:
				return this.Yield(8, new WaitForSeconds(3f));
				IL_6B1:
				goto IL_72F;
				Block_43:
				return this.Yield(5, new WaitForSeconds(3f));
				IL_6F3:
				return this.Yield(9, new WaitForSeconds(0.5f));
				IL_72F:
				return false;
			}

			// Token: 0x06009F7D RID: 40829 RVA: 0x012553A8 File Offset: 0x012535A8
			internal static bool tfa0GVVfyYWNqjee6xgT()
			{
				return true;
			}

			// Token: 0x06009F7E RID: 40830 RVA: 0x012553AC File Offset: 0x012535AC
			internal static bool LZtHvjVfS4Csf7fGMO8D()
			{
				return false;
			}

			// Token: 0x0400911F RID: 37151
			internal StoryGui $mStoryGui$43303;

			// Token: 0x04009120 RID: 37152
			internal AnnoniteGui $mAnnoniteGui$43304;

			// Token: 0x04009121 RID: 37153
			internal M931_IAmNoKnight $self_$43305;
		}
	}

	// Token: 0x02001AAF RID: 6831
	[CompilerGenerated]
	[Serializable]
	internal sealed class $CompleteEvent$43307 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009F7F RID: 40831 RVA: 0x012553B0 File Offset: 0x012535B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $CompleteEvent$43307(M931_IAmNoKnight self_)
		{
			if (195884 - 270694 != -74809)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (108911 - 468369 == -359458)
				{
					base..ctor();
					if (6553 - 510072 != -503518)
					{
						this.$self_$43311 = self_;
						if (99328 - 553771 == -454443)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009F80 RID: 40832 RVA: 0x01255448 File Offset: 0x01253648
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M931_IAmNoKnight.$CompleteEvent$43307.$(this.$self_$43311);
		}

		// Token: 0x06009F81 RID: 40833 RVA: 0x01255458 File Offset: 0x01253658
		internal static bool YjrCOSVfo3SF6tW8U6L4()
		{
			return true;
		}

		// Token: 0x06009F82 RID: 40834 RVA: 0x0125545C File Offset: 0x0125365C
		internal static bool qXSjJGVfEg4xsMLRnOJM()
		{
			return false;
		}

		// Token: 0x04009122 RID: 37154
		internal M931_IAmNoKnight $self_$43311;

		// Token: 0x02001AB0 RID: 6832
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009F83 RID: 40835 RVA: 0x01255460 File Offset: 0x01253660
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M931_IAmNoKnight self_)
			{
				if (13107 - 458568 != -445460)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (72398 - 178409 != -106010)
					{
						base..ctor();
						if (108943 - 220154 == -111211)
						{
							this.$self_$43310 = self_;
							if (30343 - 592814 == -562471)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009F84 RID: 40836 RVA: 0x012554F8 File Offset: 0x012536F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (75003 - 267071 != -192068)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_50E;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (133582 - 433438 != -299856)
							{
								continue;
							}
							goto IL_337;
						}
						else
						{
							this.$self_$43310.SendMessage("fadeOut");
							if (135076 - 548205 != -413129)
							{
								continue;
							}
							goto IL_240;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (20545 - 292928 != -272382)
							{
								goto Block_18;
							}
							continue;
						}
						else
						{
							this.$self_$43310.p5GnIVryeKM.alignToObject("EventCamera4");
							if (257190 - 325794 != -68604)
							{
								continue;
							}
							goto IL_103;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (69127 - 77618 != -8490)
							{
								goto Block_9;
							}
							continue;
						}
						else
						{
							this.$self_$43310.SendMessage("fadeIn");
							if (250693 - 18331 != 232362)
							{
								continue;
							}
							goto IL_45C;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (3451 - 416562 != -413111)
							{
								continue;
							}
							goto IL_201;
						}
						else
						{
							this.$mStoryGui$43309 = (StoryGui)this.$self_$43310.GetComponent(typeof(StoryGui));
							if (146668 - 560448 == -413779)
							{
								continue;
							}
							this.$mStoryGui$43309.startStoryMessage("none", "Shrimp Knight", eTalkType.friend);
							if (151548 - 445914 != -294366)
							{
								continue;
							}
							goto IL_4D3;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (195595 - 421887 != -226292)
							{
								continue;
							}
							goto IL_27B;
						}
						else
						{
							this.$mStoryGui$43309.newStoryMessage("none", "Shrimp Knight", Language.getMessage("M931_IAmNoKnight", 201), eTalkType.friend);
							if (270266 - 12990 != 257277)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (137106 - 355310 != -218204)
							{
								continue;
							}
							goto IL_3DC;
						}
						else
						{
							this.$mStoryGui$43309.newStoryMessage("none", "Shrimp Knight", Language.getMessage("M931_IAmNoKnight", 202), eTalkType.friend);
							if (53827 - 379975 != -326148)
							{
								continue;
							}
							goto IL_421;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (12388 - 192029 != -179641)
							{
								continue;
							}
							goto IL_13E;
						}
						else
						{
							this.$mStoryGui$43309.close();
							if (150290 - 59846 != 90445)
							{
								goto Block_10;
							}
							continue;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (270954 - 369902 != -98947)
							{
								goto Block_33;
							}
							continue;
						}
						else
						{
							Game.sendMissionEvent(9319, 2);
							if (268965 - 424734 != -155769)
							{
								continue;
							}
							this.YieldDefault(1);
							if (100574 - 346861 != -246287)
							{
								continue;
							}
							goto IL_50E;
						}
						break;
					default:
						if (143784 - 145771 == -1986)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.AllHold;
					if (231123 - 111510 == 119613)
					{
						Game.mStateTime = Time.time;
						if (85577 - 152814 == -67237)
						{
							this.$mAnnoniteGui$43308 = (AnnoniteGui)this.$self_$43310.GetComponent(typeof(AnnoniteGui));
							if (23825 - 243797 == -219972)
							{
								if (!this.$mAnnoniteGui$43308)
								{
									goto IL_168;
								}
								if (36137 - 407456 == -371319)
								{
									this.$mAnnoniteGui$43308.close();
									if (133406 - 519997 == -386591)
									{
										goto IL_168;
									}
								}
							}
						}
					}
				}
				IL_103:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_9:
				IL_13E:
				goto IL_50E;
				Block_10:
				return this.Yield(9, new WaitForSeconds(1f));
				IL_168:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_201:
				goto IL_50E;
				IL_240:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_18:
				IL_27B:
				goto IL_50E;
				Block_19:
				return this.Yield(7, new WaitForSeconds(3f));
				IL_337:
				IL_3DC:
				goto IL_50E;
				IL_421:
				return this.Yield(8, new WaitForSeconds(3f));
				IL_45C:
				return this.Yield(5, new WaitForSeconds(1f));
				Block_33:
				goto IL_50E;
				IL_4D3:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_50E:
				return false;
			}

			// Token: 0x06009F85 RID: 40837 RVA: 0x01255A28 File Offset: 0x01253C28
			internal static bool pByShVVf213hMMZ9w0l1()
			{
				return true;
			}

			// Token: 0x06009F86 RID: 40838 RVA: 0x01255A2C File Offset: 0x01253C2C
			internal static bool RWyXSEVf8Ivqcx4k545e()
			{
				return false;
			}

			// Token: 0x04009123 RID: 37155
			internal AnnoniteGui $mAnnoniteGui$43308;

			// Token: 0x04009124 RID: 37156
			internal StoryGui $mStoryGui$43309;

			// Token: 0x04009125 RID: 37157
			internal M931_IAmNoKnight $self_$43310;
		}
	}

	// Token: 0x02001AB1 RID: 6833
	[CompilerGenerated]
	[Serializable]
	internal sealed class $GameOverEvent$43312 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009F87 RID: 40839 RVA: 0x01255A30 File Offset: 0x01253C30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $GameOverEvent$43312(M931_IAmNoKnight self_)
		{
			if (63993 - 42291 != 21703)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (179215 - 268375 != -89159)
				{
					base..ctor();
					if (232700 - 107972 != 124729)
					{
						this.$self_$43316 = self_;
						if (164209 - 513065 != -348855)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009F88 RID: 40840 RVA: 0x01255AC8 File Offset: 0x01253CC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M931_IAmNoKnight.$GameOverEvent$43312.$(this.$self_$43316);
		}

		// Token: 0x06009F89 RID: 40841 RVA: 0x01255AD8 File Offset: 0x01253CD8
		internal static bool v1yh46VfZSZSZaMYUpXL()
		{
			return true;
		}

		// Token: 0x06009F8A RID: 40842 RVA: 0x01255ADC File Offset: 0x01253CDC
		internal static bool iIlneCVfCZSLe32IHOp5()
		{
			return false;
		}

		// Token: 0x04009126 RID: 37158
		internal M931_IAmNoKnight $self_$43316;

		// Token: 0x02001AB2 RID: 6834
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009F8B RID: 40843 RVA: 0x01255AE0 File Offset: 0x01253CE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M931_IAmNoKnight self_)
			{
				if (86822 - 496813 != -409991)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (121076 - 360353 == -239277)
					{
						base..ctor();
						if (234500 - 87745 == 146755)
						{
							this.$self_$43315 = self_;
							if (114105 - 271692 == -157587)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009F8C RID: 40844 RVA: 0x01255B78 File Offset: 0x01253D78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (13840 - 583467 != -569627)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_55C;
					case 2:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (213824 - 256415 != -42590)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							this.$self_$43315.SendMessage("fadeOut");
							if (64640 - 126395 != -61755)
							{
								continue;
							}
							goto IL_470;
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (208507 - 486391 != -277883)
							{
								goto Block_32;
							}
							continue;
						}
						else
						{
							this.$self_$43315.p5GnIVryeKM.alignToObject("EventCamera4");
							if (277029 - 126089 != 150940)
							{
								continue;
							}
							goto IL_4E6;
						}
						break;
					case 4:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (165461 - 186291 != -20830)
							{
								continue;
							}
							goto IL_249;
						}
						else
						{
							this.$self_$43315.SendMessage("fadeIn");
							if (289496 - 580141 != -290644)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					case 5:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (277432 - 201757 != 75676)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43314 = (StoryGui)this.$self_$43315.GetComponent(typeof(StoryGui));
							if (31780 - 15812 != 15968)
							{
								continue;
							}
							this.$mStoryGui$43314.startStoryMessage("none", "Shrimp Knight", eTalkType.friend);
							if (159292 - 259299 != -100007)
							{
								continue;
							}
							goto IL_521;
						}
						break;
					case 6:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (147432 - 327779 != -180347)
							{
								continue;
							}
							goto IL_12E;
						}
						else
						{
							this.$mStoryGui$43314.newStoryMessage("none", "Shrimp Knight", Language.getMessage("M931_IAmNoKnight", 301), eTalkType.friend);
							if (19871 - 47579 != -27708)
							{
								continue;
							}
							goto IL_4AB;
						}
						break;
					case 7:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (53380 - 365018 != -311637)
							{
								goto Block_34;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43314.newStoryMessage("none", "Shrimp Knight", Language.getMessage("M931_IAmNoKnight", 302), eTalkType.friend);
							if (122153 - 107011 != 15142)
							{
								continue;
							}
							goto IL_278;
						}
						break;
					case 8:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (9849 - 316144 != -306294)
							{
								goto Block_18;
							}
							continue;
						}
						else
						{
							this.$mStoryGui$43314.close();
							if (140475 - 151174 != -10699)
							{
								continue;
							}
							goto IL_1A;
						}
						break;
					case 9:
						if (Game.mGameState != eGameState.AllHold)
						{
							if (95378 - 517814 != -422436)
							{
								continue;
							}
							goto IL_1CB;
						}
						else
						{
							Game.sendMissionEvent(9319, 0);
							if (246832 - 366463 != -119631)
							{
								continue;
							}
							this.YieldDefault(1);
							if (196957 - 262934 != -65976)
							{
								goto Block_28;
							}
							continue;
						}
						break;
					default:
						if (75246 - 114937 != -39691)
						{
							continue;
						}
						break;
					}
					if (Game.mGameState != eGameState.Normal)
					{
						if (86122 - 390352 != -304229)
						{
							goto Block_25;
						}
					}
					else
					{
						Debug.Log("GameOver Event");
						if (280691 - 169010 == 111681)
						{
							Game.mGameState = eGameState.AllHold;
							if (236908 - 23892 == 213016)
							{
								Game.mStateTime = Time.time;
								if (56223 - 409944 == -353721)
								{
									this.$mAnnoniteGui$43313 = (AnnoniteGui)this.$self_$43315.GetComponent(typeof(AnnoniteGui));
									if (180611 - 237480 != -56868)
									{
										if (!this.$mAnnoniteGui$43313)
										{
											goto IL_56;
										}
										if (63238 - 204303 == -141065)
										{
											this.$mAnnoniteGui$43313.close();
											if (162789 - 23644 == 139145)
											{
												goto IL_56;
											}
										}
									}
								}
							}
						}
					}
				}
				IL_1A:
				return this.Yield(9, new WaitForSeconds(1f));
				IL_56:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_5:
				IL_12E:
				IL_1CB:
				IL_249:
				goto IL_55C;
				Block_16:
				return this.Yield(5, new WaitForSeconds(1f));
				IL_278:
				return this.Yield(8, new WaitForSeconds(3f));
				Block_18:
				Block_22:
				Block_25:
				Block_28:
				goto IL_55C;
				IL_470:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_32:
				goto IL_55C;
				IL_4AB:
				return this.Yield(7, new WaitForSeconds(3f));
				Block_34:
				goto IL_55C;
				IL_4E6:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_521:
				return this.Yield(6, new WaitForSeconds(0.5f));
				IL_55C:
				return false;
			}

			// Token: 0x06009F8D RID: 40845 RVA: 0x012560F4 File Offset: 0x012542F4
			internal static bool T65hy7VfL5AdYh3loFAA()
			{
				return true;
			}

			// Token: 0x06009F8E RID: 40846 RVA: 0x012560F8 File Offset: 0x012542F8
			internal static bool in24VKVfOPAPEa39Qg5i()
			{
				return false;
			}

			// Token: 0x04009127 RID: 37159
			internal AnnoniteGui $mAnnoniteGui$43313;

			// Token: 0x04009128 RID: 37160
			internal StoryGui $mStoryGui$43314;

			// Token: 0x04009129 RID: 37161
			internal M931_IAmNoKnight $self_$43315;
		}
	}

	// Token: 0x02001AB3 RID: 6835
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$43317 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009F8F RID: 40847 RVA: 0x012560FC File Offset: 0x012542FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$43317(Hashtable data, M931_IAmNoKnight self_)
		{
			if (153726 - 299071 != -145344)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (116514 - 341364 == -224850)
				{
					base..ctor();
					if (84625 - 155151 != -70525)
					{
						this.$data$43324 = data;
						if (9869 - 575020 == -565151)
						{
							this.$self_$43325 = self_;
							if (259249 - 423586 != -164336)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009F90 RID: 40848 RVA: 0x012561B8 File Offset: 0x012543B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M931_IAmNoKnight.$onGameComplete$43317.$(this.$data$43324, this.$self_$43325);
		}

		// Token: 0x06009F91 RID: 40849 RVA: 0x012561CC File Offset: 0x012543CC
		internal static bool sQa6luVfmAd1e8phYCJD()
		{
			return true;
		}

		// Token: 0x06009F92 RID: 40850 RVA: 0x012561D0 File Offset: 0x012543D0
		internal static bool EK9HnCVfF0l5fFEOLscp()
		{
			return false;
		}

		// Token: 0x0400912A RID: 37162
		internal Hashtable $data$43324;

		// Token: 0x0400912B RID: 37163
		internal M931_IAmNoKnight $self_$43325;

		// Token: 0x02001AB4 RID: 6836
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009F93 RID: 40851 RVA: 0x012561D4 File Offset: 0x012543D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M931_IAmNoKnight self_)
			{
				if (97119 - 15802 != 81318)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (264271 - 420246 == -155975)
					{
						base..ctor();
						if (91320 - 436645 != -345324)
						{
							this.$data$43322 = data;
							if (173378 - 427163 != -253784)
							{
								this.$self_$43323 = self_;
								if (180062 - 346846 != -166783)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009F94 RID: 40852 RVA: 0x01256290 File Offset: 0x01254490
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (25943 - 356131 != -330188)
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
						this.$mCompleteGui$43319 = (CompleteGui)this.$self_$43323.GetComponent(typeof(CompleteGui));
						if (57060 - 499869 != -442809)
						{
							continue;
						}
						this.$mCompleteGui$43319.Init();
						if (81267 - 568743 != -487476)
						{
							continue;
						}
						this.$mCompleteGui$43319.readData(this.$data$43322);
						if (80346 - 471752 == -391405)
						{
							continue;
						}
						if (this.$result$43318 == 1)
						{
							if (182930 - 208075 == -25144)
							{
								continue;
							}
							this.$mCompleteGui$43319.displayResult(eCompleteType.Success);
							if (48997 - 282172 != -233175)
							{
								continue;
							}
						}
						else
						{
							this.$mCompleteGui$43319.displayResult(eCompleteType.Failed);
							if (165000 - 509032 == -344031)
							{
								continue;
							}
						}
						this.$mAnnoniteGui$43320 = (AnnoniteGui)this.$self_$43323.GetComponent(typeof(AnnoniteGui));
						if (154760 - 260620 != -105860)
						{
							continue;
						}
						if (this.$mAnnoniteGui$43320)
						{
							if (252533 - 103417 != 149116)
							{
								continue;
							}
							this.$mAnnoniteGui$43320.close();
							if (21008 - 116445 != -95437)
							{
								continue;
							}
						}
						this.$mStoryGui$43321 = (StoryGui)this.$self_$43323.GetComponent(typeof(StoryGui));
						if (135813 - 20916 != 114897)
						{
							continue;
						}
						if (this.$mStoryGui$43321)
						{
							if (278172 - 431391 == -153218)
							{
								continue;
							}
							this.$mStoryGui$43321.close();
							if (259680 - 478484 != -218804)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (83339 - 213688 != -130348)
						{
							goto Block_14;
						}
						continue;
					default:
						if (134786 - 281819 != -147033)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$43322[31]);
					if (85354 - 71288 != 14067)
					{
						if (Game.mGameState > eGameState.AllHold)
						{
							if (110865 - 433111 == -322246)
							{
								goto IL_32D;
							}
						}
						else
						{
							Game.mGameState = eGameState.Complete;
							if (228201 - 174525 == 53676)
							{
								this.$result$43318 = RuntimeServices.UnboxInt32(this.$data$43322[31]);
								if (25186 - 31938 == -6752)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_14:
				IL_32D:
				IL_352:
				return false;
			}

			// Token: 0x06009F95 RID: 40853 RVA: 0x01256604 File Offset: 0x01254804
			internal static bool OV5jv1VfMVhHGwx7IjcN()
			{
				return true;
			}

			// Token: 0x06009F96 RID: 40854 RVA: 0x01256608 File Offset: 0x01254808
			internal static bool ivLKSrVfx07dZe2X0PgX()
			{
				return false;
			}

			// Token: 0x0400912C RID: 37164
			internal int $result$43318;

			// Token: 0x0400912D RID: 37165
			internal CompleteGui $mCompleteGui$43319;

			// Token: 0x0400912E RID: 37166
			internal AnnoniteGui $mAnnoniteGui$43320;

			// Token: 0x0400912F RID: 37167
			internal StoryGui $mStoryGui$43321;

			// Token: 0x04009130 RID: 37168
			internal Hashtable $data$43322;

			// Token: 0x04009131 RID: 37169
			internal M931_IAmNoKnight $self_$43323;
		}
	}

	// Token: 0x02001AB5 RID: 6837
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$43326 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009F97 RID: 40855 RVA: 0x0125660C File Offset: 0x0125480C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$43326(M931_IAmNoKnight self_)
		{
			if (146568 - 150484 != -3915)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (134652 - 368312 != -233659)
				{
					base..ctor();
					if (149770 - 126361 != 23410)
					{
						this.$self_$43330 = self_;
						if (57986 - 77362 == -19376)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009F98 RID: 40856 RVA: 0x012566A4 File Offset: 0x012548A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M931_IAmNoKnight.$onDeadPlayer$43326.$(this.$self_$43330);
		}

		// Token: 0x06009F99 RID: 40857 RVA: 0x012566B4 File Offset: 0x012548B4
		internal static bool FOX7GxVfg267G9IYlDNo()
		{
			return true;
		}

		// Token: 0x06009F9A RID: 40858 RVA: 0x012566B8 File Offset: 0x012548B8
		internal static bool gN0FrEVff8Q3lqQ65m6v()
		{
			return false;
		}

		// Token: 0x04009132 RID: 37170
		internal M931_IAmNoKnight $self_$43330;

		// Token: 0x02001AB6 RID: 6838
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009F9B RID: 40859 RVA: 0x012566BC File Offset: 0x012548BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M931_IAmNoKnight self_)
			{
				if (269243 - 26311 != 242933)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (296967 - 38558 != 258410)
					{
						base..ctor();
						if (125778 - 511765 == -385987)
						{
							this.$self_$43329 = self_;
							if (215435 - 285318 != -69882)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009F9C RID: 40860 RVA: 0x01256754 File Offset: 0x01254954
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (107459 - 170510 != -63051)
				{
				}
				do
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_220;
					case 2:
						if (Game.mGameState != eGameState.Normal)
						{
							if (80740 - 197094 != -116354)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_14C;
							}
							if (83465 - 121282 == -37816)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (110228 - 493866 != -383638)
						{
							continue;
						}
						this.$mStoryGui$43327 = (StoryGui)this.$self_$43329.GetComponent(typeof(StoryGui));
						if (106411 - 282674 == -176262)
						{
							continue;
						}
						if (this.$mStoryGui$43327)
						{
							if (88737 - 299515 == -210777)
							{
								continue;
							}
							this.$mStoryGui$43327.close();
							if (184319 - 41482 != 142837)
							{
								continue;
							}
						}
						this.$mAnnoniteGui$43328 = (AnnoniteGui)this.$self_$43329.GetComponent(typeof(AnnoniteGui));
						if (110702 - 324096 == -213393)
						{
							continue;
						}
						if (this.$mAnnoniteGui$43328)
						{
							if (34143 - 585313 == -551169)
							{
								continue;
							}
							this.$mAnnoniteGui$43328.close();
							if (230627 - 486377 == -255749)
							{
								continue;
							}
						}
						IL_14C:
						this.YieldDefault(1);
						if (71592 - 345104 != -273512)
						{
							continue;
						}
						goto IL_220;
					default:
						if (192646 - 246807 == -54160)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (103019 - 493612 == -390592);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_220:
				return false;
			}

			// Token: 0x06009F9D RID: 40861 RVA: 0x01256994 File Offset: 0x01254B94
			internal static bool jUHX8nVfnmttgUaW9dia()
			{
				return true;
			}

			// Token: 0x06009F9E RID: 40862 RVA: 0x01256998 File Offset: 0x01254B98
			internal static bool s9WkKXVf6PTvWkwvaPc1()
			{
				return false;
			}

			// Token: 0x04009133 RID: 37171
			internal StoryGui $mStoryGui$43327;

			// Token: 0x04009134 RID: 37172
			internal AnnoniteGui $mAnnoniteGui$43328;

			// Token: 0x04009135 RID: 37173
			internal M931_IAmNoKnight $self_$43329;
		}
	}

	// Token: 0x02001AB7 RID: 6839
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onChangePlayer$43331 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009F9F RID: 40863 RVA: 0x0125699C File Offset: 0x01254B9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onChangePlayer$43331(Hashtable data, M931_IAmNoKnight self_)
		{
			if (224735 - 505015 != -280279)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (155197 - 21292 == 133905)
				{
					base..ctor();
					if (105900 - 387109 != -281208)
					{
						this.$data$43336 = data;
						if (179495 - 115299 != 64197)
						{
							this.$self_$43337 = self_;
							if (111490 - 368125 == -256635)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06009FA0 RID: 40864 RVA: 0x01256A58 File Offset: 0x01254C58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M931_IAmNoKnight.$onChangePlayer$43331.$(this.$data$43336, this.$self_$43337);
		}

		// Token: 0x06009FA1 RID: 40865 RVA: 0x01256A6C File Offset: 0x01254C6C
		internal static bool AyrHRoVfiky7jKwJupdQ()
		{
			return true;
		}

		// Token: 0x06009FA2 RID: 40866 RVA: 0x01256A70 File Offset: 0x01254C70
		internal static bool aCh65EVfKkcPtVSuiSyU()
		{
			return false;
		}

		// Token: 0x04009136 RID: 37174
		internal Hashtable $data$43336;

		// Token: 0x04009137 RID: 37175
		internal M931_IAmNoKnight $self_$43337;

		// Token: 0x02001AB8 RID: 6840
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009FA3 RID: 40867 RVA: 0x01256A74 File Offset: 0x01254C74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M931_IAmNoKnight self_)
			{
				if (85368 - 571987 != -486618)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (215479 - 127383 == 88096)
					{
						base..ctor();
						if (201498 - 74199 == 127299)
						{
							this.$data$43334 = data;
							if (72817 - 12568 == 60249)
							{
								this.$self_$43335 = self_;
								if (105786 - 292365 != -186578)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06009FA4 RID: 40868 RVA: 0x01256B30 File Offset: 0x01254D30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (276918 - 284722 != -7804)
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
							if (118020 - 78711 != 39309)
							{
								continue;
							}
							Game.mGameState = eGameState.Normal;
							if (55131 - 537389 == -482257)
							{
								continue;
							}
							this.$mAnnoniteGui$43333 = (AnnoniteGui)this.$self_$43335.GetComponent(typeof(AnnoniteGui));
							if (171025 - 532833 == -361807)
							{
								continue;
							}
							this.$mAnnoniteGui$43333.enabled = true;
							if (142898 - 226027 == -83128)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (225755 - 144625 != 81131)
						{
							goto Block_10;
						}
						continue;
					default:
						if (292588 - 282903 != 9685)
						{
							continue;
						}
						break;
					}
					UnityEngine.Object.Destroy(Game.mPlayer);
					if (145456 - 555512 == -410056)
					{
						this.$self_$43335.SendMessage("onCreatePlayer", this.$data$43334);
						if (11150 - 335065 != -323914)
						{
							this.$mChangeGui$43332 = (ChangeGui)this.$self_$43335.GetComponent(typeof(ChangeGui));
							if (77692 - 198514 != -120821)
							{
								if (!this.$mChangeGui$43332.enabled)
								{
									break;
								}
								if (258848 - 594652 != -335803)
								{
									this.$mChangeGui$43332.close();
									if (138749 - 435032 != -296282)
									{
										break;
									}
								}
							}
						}
					}
				}
				goto IL_15F;
				Block_10:
				goto IL_205;
				IL_15F:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_205:
				return false;
			}

			// Token: 0x06009FA5 RID: 40869 RVA: 0x01256D54 File Offset: 0x01254F54
			internal static bool hAaDjqVfdWW4kl63ougn()
			{
				return true;
			}

			// Token: 0x06009FA6 RID: 40870 RVA: 0x01256D58 File Offset: 0x01254F58
			internal static bool axKOr5VfJ4ItiFejPRnY()
			{
				return false;
			}

			// Token: 0x04009138 RID: 37176
			internal ChangeGui $mChangeGui$43332;

			// Token: 0x04009139 RID: 37177
			internal AnnoniteGui $mAnnoniteGui$43333;

			// Token: 0x0400913A RID: 37178
			internal Hashtable $data$43334;

			// Token: 0x0400913B RID: 37179
			internal M931_IAmNoKnight $self_$43335;
		}
	}

	// Token: 0x02001AB9 RID: 6841
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$43338 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009FA7 RID: 40871 RVA: 0x01256D5C File Offset: 0x01254F5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$43338(M931_IAmNoKnight self_)
		{
			if (256147 - 354349 != -98201)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (54273 - 204248 == -149975)
				{
					base..ctor();
					if (205187 - 6158 != 199030)
					{
						this.$self_$43342 = self_;
						if (41487 - 121657 != -80169)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009FA8 RID: 40872 RVA: 0x01256DF4 File Offset: 0x01254FF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M931_IAmNoKnight.$ReturnToTown$43338.$(this.$self_$43342);
		}

		// Token: 0x06009FA9 RID: 40873 RVA: 0x01256E04 File Offset: 0x01255004
		internal static bool EbM1hcVfDb8a50U0QMjQ()
		{
			return true;
		}

		// Token: 0x06009FAA RID: 40874 RVA: 0x01256E08 File Offset: 0x01255008
		internal static bool P7sARrVfvxRvwpE3Ac4o()
		{
			return false;
		}

		// Token: 0x0400913C RID: 37180
		internal M931_IAmNoKnight $self_$43342;

		// Token: 0x02001ABA RID: 6842
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009FAB RID: 40875 RVA: 0x01256E0C File Offset: 0x0125500C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M931_IAmNoKnight self_)
			{
				if (75362 - 184845 != -109482)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (107665 - 230454 == -122789)
					{
						base..ctor();
						if (54135 - 327846 == -273711)
						{
							this.$self_$43341 = self_;
							if (160745 - 128659 != 32087)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009FAC RID: 40876 RVA: 0x01256EA4 File Offset: 0x012550A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (127660 - 296667 != -169007)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_383;
					case 2:
						this.$self_$43341.LeaveGame();
						if (251362 - 471224 == -219861)
						{
							continue;
						}
						this.YieldDefault(1);
						if (48144 - 19110 != 29034)
						{
							continue;
						}
						goto IL_383;
					default:
						if (62353 - 93313 == -30959)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (198887 - 128975 == 69912)
					{
						Game.mStateTime = Time.time;
						if (265724 - 577765 == -312041)
						{
							this.$$switch$7923$43339 = PlayerData.SaveGuild;
							if (282729 - 38683 == 244046)
							{
								if (this.$$switch$7923$43339 == 1)
								{
									if (55868 - 468395 != -412527)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (160132 - 453176 != -293044)
									{
										continue;
									}
								}
								else if (this.$$switch$7923$43339 == 2)
								{
									if (289793 - 193972 != 95821)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (188913 - 9781 == 179133)
									{
										continue;
									}
								}
								else if (this.$$switch$7923$43339 == 3)
								{
									if (36999 - 63659 == -26659)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (16711 - 310098 == -293386)
									{
										continue;
									}
								}
								else if (this.$$switch$7923$43339 == 4)
								{
									if (298 - 63038 != -62740)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (110463 - 203173 != -92710)
									{
										continue;
									}
								}
								else if (this.$$switch$7923$43339 == 5)
								{
									if (230744 - 307649 == -76904)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (117753 - 355785 != -238032)
									{
										continue;
									}
								}
								else if (PlayerData.GID == 0)
								{
									if (30669 - 382632 == -351962)
									{
										continue;
									}
									Game.mNextGameCode = 30;
									if (90022 - 20260 == 69763)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 31;
									if (43625 - 537706 != -494081)
									{
										continue;
									}
								}
								this.$mAnnoniteGui$43340 = (AnnoniteGui)this.$self_$43341.GetComponent(typeof(AnnoniteGui));
								if (181428 - 258904 == -77476)
								{
									this.$mAnnoniteGui$43340.close();
									if (296717 - 548162 == -251445)
									{
										this.$self_$43341.SendMessage("fadeOut");
										if (200055 - 487182 != -287126)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_383:
				return false;
			}

			// Token: 0x06009FAD RID: 40877 RVA: 0x01257248 File Offset: 0x01255448
			internal static bool j47bKeVfR8Skq3WqKITD()
			{
				return true;
			}

			// Token: 0x06009FAE RID: 40878 RVA: 0x0125724C File Offset: 0x0125544C
			internal static bool sDJeZVVfwNtqcdoijitv()
			{
				return false;
			}

			// Token: 0x0400913D RID: 37181
			internal int $$switch$7923$43339;

			// Token: 0x0400913E RID: 37182
			internal AnnoniteGui $mAnnoniteGui$43340;

			// Token: 0x0400913F RID: 37183
			internal M931_IAmNoKnight $self_$43341;
		}
	}

	// Token: 0x02001ABB RID: 6843
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToGuild$43343 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009FAF RID: 40879 RVA: 0x01257250 File Offset: 0x01255450
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToGuild$43343(M931_IAmNoKnight self_)
		{
			if (140929 - 233067 != -92138)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (76658 - 107165 != -30506)
				{
					base..ctor();
					if (156080 - 356045 == -199965)
					{
						this.$self_$43346 = self_;
						if (19788 - 47210 != -27421)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009FB0 RID: 40880 RVA: 0x012572E8 File Offset: 0x012554E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M931_IAmNoKnight.$ReturnToGuild$43343.$(this.$self_$43346);
		}

		// Token: 0x06009FB1 RID: 40881 RVA: 0x012572F8 File Offset: 0x012554F8
		internal static bool SnAorqVfqw11X68nhhPp()
		{
			return true;
		}

		// Token: 0x06009FB2 RID: 40882 RVA: 0x012572FC File Offset: 0x012554FC
		internal static bool ElWOL7Vf7NKvqdfF6lvq()
		{
			return false;
		}

		// Token: 0x04009140 RID: 37184
		internal M931_IAmNoKnight $self_$43346;

		// Token: 0x02001ABC RID: 6844
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009FB3 RID: 40883 RVA: 0x01257300 File Offset: 0x01255500
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M931_IAmNoKnight self_)
			{
				if (186738 - 25465 != 161274)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (261938 - 331862 == -69924)
					{
						base..ctor();
						if (85500 - 441965 != -356464)
						{
							this.$self_$43345 = self_;
							if (57968 - 504918 == -446950)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009FB4 RID: 40884 RVA: 0x01257398 File Offset: 0x01255598
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (98732 - 555220 != -456487)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_193;
					case 2:
						this.$self_$43345.LeaveGame();
						if (149933 - 38853 == 111081)
						{
							continue;
						}
						this.YieldDefault(1);
						if (98161 - 378648 != -280487)
						{
							continue;
						}
						goto IL_193;
					default:
						if (163820 - 512247 == -348426)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (7457 - 500992 != -493534)
					{
						Game.mStateTime = Time.time;
						if (298981 - 41269 != 257713)
						{
							Game.mNextGameCode = 31;
							if (7410 - 570406 == -562996)
							{
								this.$mAnnoniteGui$43344 = (AnnoniteGui)this.$self_$43345.GetComponent(typeof(AnnoniteGui));
								if (84736 - 507745 != -423008)
								{
									this.$mAnnoniteGui$43344.close();
									if (206502 - 334329 == -127827)
									{
										this.$self_$43345.SendMessage("fadeOut");
										if (268145 - 553851 != -285705)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_193:
				return false;
			}

			// Token: 0x06009FB5 RID: 40885 RVA: 0x0125754C File Offset: 0x0125574C
			internal static bool awCn1yVfPLsB2Ev0G4Po()
			{
				return true;
			}

			// Token: 0x06009FB6 RID: 40886 RVA: 0x01257550 File Offset: 0x01255750
			internal static bool zAgLXcVf0qR6mSnsPymf()
			{
				return false;
			}

			// Token: 0x04009141 RID: 37185
			internal AnnoniteGui $mAnnoniteGui$43344;

			// Token: 0x04009142 RID: 37186
			internal M931_IAmNoKnight $self_$43345;
		}
	}

	// Token: 0x02001ABD RID: 6845
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToCamp$43347 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06009FB7 RID: 40887 RVA: 0x01257554 File Offset: 0x01255754
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToCamp$43347(M931_IAmNoKnight self_)
		{
			if (208315 - 583034 != -374719)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (286013 - 218803 != 67211)
				{
					base..ctor();
					if (183035 - 556323 == -373288)
					{
						this.$self_$43351 = self_;
						if (39542 - 140476 != -100933)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06009FB8 RID: 40888 RVA: 0x012575EC File Offset: 0x012557EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M931_IAmNoKnight.$ReturnToCamp$43347.$(this.$self_$43351);
		}

		// Token: 0x06009FB9 RID: 40889 RVA: 0x012575FC File Offset: 0x012557FC
		internal static bool oL0xPdVfbTWGkIHjXlyT()
		{
			return true;
		}

		// Token: 0x06009FBA RID: 40890 RVA: 0x01257600 File Offset: 0x01255800
		internal static bool oD8rNuVfuWaWgpvXKlCI()
		{
			return false;
		}

		// Token: 0x04009143 RID: 37187
		internal M931_IAmNoKnight $self_$43351;

		// Token: 0x02001ABE RID: 6846
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06009FBB RID: 40891 RVA: 0x01257604 File Offset: 0x01255804
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M931_IAmNoKnight self_)
			{
				if (221007 - 69908 != 151099)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (272710 - 552653 != -279942)
					{
						base..ctor();
						if (61502 - 244659 != -183156)
						{
							this.$self_$43350 = self_;
							if (20232 - 595756 == -575524)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06009FBC RID: 40892 RVA: 0x0125769C File Offset: 0x0125589C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (59815 - 144394 != -84579)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_339;
					case 2:
						this.$self_$43350.LeaveGame();
						if (289893 - 383170 != -93277)
						{
							continue;
						}
						this.YieldDefault(1);
						if (181441 - 258439 != -76998)
						{
							continue;
						}
						goto IL_339;
					default:
						if (55666 - 173724 != -118058)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (116400 - 171321 == -54921)
					{
						Game.mStateTime = Time.time;
						if (86462 - 324276 == -237814)
						{
							this.$$switch$7925$43348 = PlayerData.SaveGuild;
							if (88549 - 155412 != -66862)
							{
								if (this.$$switch$7925$43348 == 1)
								{
									if (182961 - 394184 == -211222)
									{
										continue;
									}
									Game.mNextGameCode = 32;
									if (243178 - 202154 != 41024)
									{
										continue;
									}
								}
								else if (this.$$switch$7925$43348 == 2)
								{
									if (74384 - 547955 != -473571)
									{
										continue;
									}
									Game.mNextGameCode = 33;
									if (293768 - 23179 != 270589)
									{
										continue;
									}
								}
								else if (this.$$switch$7925$43348 == 3)
								{
									if (197847 - 89492 != 108355)
									{
										continue;
									}
									Game.mNextGameCode = 34;
									if (164018 - 304047 == -140028)
									{
										continue;
									}
								}
								else if (this.$$switch$7925$43348 == 4)
								{
									if (211841 - 332248 != -120407)
									{
										continue;
									}
									Game.mNextGameCode = 35;
									if (94207 - 486310 != -392103)
									{
										continue;
									}
								}
								else if (this.$$switch$7925$43348 == 5)
								{
									if (168468 - 453216 == -284747)
									{
										continue;
									}
									Game.mNextGameCode = 36;
									if (279685 - 273760 != 5925)
									{
										continue;
									}
								}
								else
								{
									Game.mNextGameCode = 30;
									if (276036 - 201999 == 74038)
									{
										continue;
									}
								}
								this.$mAnnoniteGui$43349 = (AnnoniteGui)this.$self_$43350.GetComponent(typeof(AnnoniteGui));
								if (227762 - 150536 != 77227)
								{
									this.$mAnnoniteGui$43349.close();
									if (254857 - 453469 != -198611)
									{
										this.$self_$43350.SendMessage("fadeOut");
										if (278718 - 543099 != -264380)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_339:
				return false;
			}

			// Token: 0x06009FBD RID: 40893 RVA: 0x012579F4 File Offset: 0x01255BF4
			internal static bool PxXl3nVfIkDwsROnGqHD()
			{
				return true;
			}

			// Token: 0x06009FBE RID: 40894 RVA: 0x012579F8 File Offset: 0x01255BF8
			internal static bool A4xwfFVfBiCZW00Ogt6V()
			{
				return false;
			}

			// Token: 0x04009144 RID: 37188
			internal int $$switch$7925$43348;

			// Token: 0x04009145 RID: 37189
			internal AnnoniteGui $mAnnoniteGui$43349;

			// Token: 0x04009146 RID: 37190
			internal M931_IAmNoKnight $self_$43350;
		}
	}
}
