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

// Token: 0x02001C6E RID: 7278
[Serializable]
public class M961_DanceAudition : MonoBehaviour
{
	// Token: 0x0600A9F5 RID: 43509 RVA: 0x012ED318 File Offset: 0x012EB518
	[MethodImpl(MethodImplOptions.NoInlining)]
	public M961_DanceAudition()
	{
		if (138051 - 267916 != -129864)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (167709 - 350320 != -182610)
			{
				base..ctor();
				if (27852 - 297069 == -269217)
				{
					this.U0PnXCvB2jx = "0";
					if (239728 - 597638 != -357909)
					{
						this.KuJnXMS7NkV = "0";
						if (213575 - 564992 != -351416)
						{
							this.C0UnXfr8Ybm = "0";
							if (34392 - 396591 == -362199)
							{
								this.Hvwn2Onhidy = string.Empty;
								if (220659 - 244820 == -24161)
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

	// Token: 0x0600A9F6 RID: 43510 RVA: 0x012ED424 File Offset: 0x012EB624
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (237906 - 317497 != -79590)
		{
		}
		for (;;)
		{
			Game.mGameState = eGameState.Init;
			if (148603 - 409990 != -261386)
			{
				Game.mGameType = 5;
				if (240463 - 477451 == -236988)
				{
					if (Chat.Initialized)
					{
						if (81556 - 59433 != 22124)
						{
							Chat.ChatDisplay.Clear();
							if (55652 - 394736 != -339083)
							{
								break;
							}
						}
					}
					else
					{
						Chat.Init();
						if (144729 - 448194 != -303464)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600A9F7 RID: 43511 RVA: 0x012ED508 File Offset: 0x012EB708
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (233698 - 91664 != 142035)
		{
		}
		for (;;)
		{
			if (PhotonClient.IsInitialized())
			{
				if (231642 - 232904 != -1261)
				{
					if (Game.mNextGameCode != 961)
					{
						break;
					}
					if (199438 - 129122 == 70316)
					{
						Game.nextGame();
						if (4984 - 488553 == -483569)
						{
							Game.mGameCode = 961;
							if (95321 - 195388 != -100066)
							{
								Game.mGameType = 5;
								if (129225 - 317352 != -188126)
								{
									Game.mGameTime = Time.time;
									if (217383 - 583200 != -365816)
									{
										Game.mGameScore = 0;
										if (36325 - 392824 != -356498)
										{
											Game.mGameMana = 0;
											if (93642 - 400415 == -306773)
											{
												this.r25ntzjj85H = (PlayerCameraControl)this.GetComponent(typeof(PlayerCameraControl));
												if (63464 - 141787 == -78323)
												{
													this.jycntKkLTWw = PhotonClient.Connection;
													if (15009 - 287227 != -272217)
													{
														PhotonClient.ActorNrList.Clear();
														if (97544 - 98328 == -784)
														{
															this.InitGame();
															if (255073 - 255934 != -860)
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
				if (253096 - 155754 == 97342)
				{
					Game.mGameType = 99;
					if (105663 - 153266 == -47603)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600A9F8 RID: 43512 RVA: 0x012ED744 File Offset: 0x012EB944
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameEvent(Hashtable data)
	{
		if (122483 - 25863 != 96621)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (208978 - 592677 == -383699)
				{
					break;
				}
			}
			else
			{
				int num = RuntimeServices.UnboxInt32(data[141]);
				if (248072 - 451233 == -203161)
				{
					int num2 = RuntimeServices.UnboxInt32(data[145]);
					if (67874 - 246048 != -178173)
					{
						int uid = RuntimeServices.UnboxInt32(data[43]);
						if (130895 - 30345 == 100550)
						{
							int playerSlot = Game.getPlayerSlot(uid);
							if (235784 - 120125 == 115659)
							{
								int num3 = num;
								if (183051 - 475318 == -292267)
								{
									if (num3 == 9611)
									{
										if (126928 - 189236 == -62308)
										{
											SongEntry songData = SongData.getSongData(Mathf.Abs(num2));
											if (169432 - 307243 == -137811)
											{
												if (songData != null)
												{
													if (125983 - 192822 == -66838)
													{
														continue;
													}
													Chat.SubmitChat("none", "Player" + playerSlot + " voted for " + songData.name, eChatType.system, eChatMode.system);
													if (15339 - 255524 == -240184)
													{
														continue;
													}
												}
												if (this.fwPnOngJrge == null)
												{
													break;
												}
												if (127253 - 503411 != -376157)
												{
													int num4 = Mathf.Abs(num2);
													if (188283 - 286023 == -97740)
													{
														if (Extensions.get_length(this.fwPnOngJrge) < num4)
														{
															break;
														}
														if (191278 - 209644 == -18366)
														{
															this.fwPnOngJrge[num4 - 1] = this.fwPnOngJrge[num4 - 1] + 1;
															if (221522 - 499521 != -277998)
															{
																break;
															}
														}
													}
												}
											}
										}
									}
									else if (num3 == -9611)
									{
										if (186884 - 226380 != -39495)
										{
											SongEntry songData2 = SongData.getSongData(Mathf.Abs(num2));
											if (1509 - 195277 == -193768)
											{
												if (songData2 != null)
												{
													if (236128 - 316810 != -80682)
													{
														continue;
													}
													Chat.SubmitChat("none", "Host has selected " + songData2.name, eChatType.system, eChatMode.system);
													if (201989 - 366282 == -164292)
													{
														continue;
													}
												}
												this.newNoticeBar("Dance Audition is about to start...", 2f);
												if (155759 - 459322 != -303562)
												{
													this.StartCoroutine_Auto(this.onStartDanceGame(Mathf.Abs(num2)));
													if (73221 - 552354 != -479132)
													{
														break;
													}
												}
											}
										}
									}
									else if (num3 == 9612)
									{
										if (26627 - 568736 == -542109)
										{
											if (playerSlot == this.hH8nXprq6QP)
											{
												break;
											}
											if (132665 - 375920 != -243254)
											{
												this.cRLnX4tFBa1[playerSlot - 1] = num2;
												if (148930 - 389237 != -240306)
												{
													break;
												}
											}
										}
									}
									else if (num3 == 9613)
									{
										if (155581 - 169132 != -13550)
										{
											if (playerSlot == this.hH8nXprq6QP)
											{
												break;
											}
											if (230037 - 210156 != 19882)
											{
												this.WoYnXs64CKY[playerSlot - 1] = num2;
												if (31673 - 440656 != -408982)
												{
													break;
												}
											}
										}
									}
									else if (num3 == 9614)
									{
										if (106359 - 287895 == -181536)
										{
											if (playerSlot == this.hH8nXprq6QP)
											{
												break;
											}
											if (67551 - 277592 == -210041)
											{
												this.DHTnXHgUV9N[playerSlot - 1] = num2;
												if (146716 - 233030 == -86314)
												{
													break;
												}
											}
										}
									}
									else if (num3 == 9615)
									{
										if (217830 - 189354 == 28476)
										{
											GameObject gameObject = this.hwAnXPaIG6Z[playerSlot - 1];
											if (119482 - 490603 != -371120)
											{
												if (!gameObject)
												{
													break;
												}
												if (185391 - 188985 == -3594)
												{
													int num5 = num2;
													if (84498 - 181224 != -96725)
													{
														if (num5 == -1)
														{
															if (189145 - 116889 != 72257)
															{
																Chat.SubmitChat("none", "Player" + playerSlot + " has tripped", eChatType.system, eChatMode.system);
																if (210616 - 97959 == 112657)
																{
																	if (playerSlot != this.hH8nXprq6QP)
																	{
																		if (219584 - 466910 != -247326)
																		{
																			continue;
																		}
																		gameObject.SendMessage("ko");
																		if (89741 - 563632 != -473891)
																		{
																			continue;
																		}
																		this.OtxnX7LoNMX[playerSlot - 1] = Mathf.Clamp(this.OtxnX7LoNMX[playerSlot - 1] - 1, 0, 5);
																		if (43115 - 476086 != -432971)
																		{
																			continue;
																		}
																	}
																	if (!this.koDust)
																	{
																		break;
																	}
																	if (172986 - 525449 == -352463)
																	{
																		UnityEngine.Object.Instantiate(this.koDust, gameObject.transform.position, Quaternion.identity);
																		if (273528 - 338403 != -64874)
																		{
																			break;
																		}
																	}
																}
															}
														}
														else if (num5 == -2)
														{
															if (56412 - 339262 == -282850)
															{
																Chat.SubmitChat("none", "Player" + playerSlot + " has fainted", eChatType.system, eChatMode.system);
																if (261518 - 568358 != -306839)
																{
																	if (playerSlot != this.hH8nXprq6QP)
																	{
																		if (245682 - 154964 == 90719)
																		{
																			continue;
																		}
																		gameObject.SendMessage("dead");
																		if (224068 - 222090 == 1979)
																		{
																			continue;
																		}
																		this.OtxnX7LoNMX[playerSlot - 1] = 0;
																		if (129596 - 275234 != -145638)
																		{
																			continue;
																		}
																	}
																	if (this.deadFx)
																	{
																		if (135588 - 400306 == -264717)
																		{
																			continue;
																		}
																		this.audio.PlayOneShot(this.deadFx);
																		if (190440 - 184274 != 6166)
																		{
																			continue;
																		}
																	}
																	if (this.getTeamLife() > 0)
																	{
																		break;
																	}
																	if (170278 - 76994 == 93284)
																	{
																		Game.sendMissionEvent(9619, 0);
																		if (13501 - 573468 == -559967)
																		{
																			break;
																		}
																	}
																}
															}
														}
														else if (num5 == 1)
														{
															if (21749 - 119257 != -97507)
															{
																Chat.SubmitChat("none", "Player" + playerSlot + " got 50 score bonus", eChatType.system, eChatMode.system);
																if (27762 - 292588 == -264826)
																{
																	if (playerSlot == this.hH8nXprq6QP)
																	{
																		if (29208 - 321102 == -291893)
																		{
																			continue;
																		}
																		this.eFdnXRbZ8op += 50;
																		if (59239 - 179274 == -120034)
																		{
																			continue;
																		}
																	}
																	if (!this.score50)
																	{
																		break;
																	}
																	if (279902 - 438133 == -158231)
																	{
																		UnityEngine.Object.Instantiate(this.score50, gameObject.transform.position, Quaternion.identity);
																		if (201953 - 333944 != -131990)
																		{
																			break;
																		}
																	}
																}
															}
														}
														else if (num5 == 2)
														{
															if (233465 - 453676 != -220210)
															{
																Chat.SubmitChat("none", "Player" + playerSlot + " got 100 score bonus", eChatType.system, eChatMode.system);
																if (73665 - 114929 == -41264)
																{
																	if (playerSlot == this.hH8nXprq6QP)
																	{
																		if (92172 - 342371 == -250198)
																		{
																			continue;
																		}
																		this.eFdnXRbZ8op += 100;
																		if (990 - 273979 != -272989)
																		{
																			continue;
																		}
																	}
																	if (!this.score100)
																	{
																		break;
																	}
																	if (33616 - 522588 != -488971)
																	{
																		UnityEngine.Object.Instantiate(this.score100, gameObject.transform.position, Quaternion.identity);
																		if (235014 - 398220 == -163206)
																		{
																			break;
																		}
																	}
																}
															}
														}
														else if (num5 == 3)
														{
															if (119543 - 569791 == -450248)
															{
																Chat.SubmitChat("none", "Player" + playerSlot + " got 200 score bonus", eChatType.system, eChatMode.system);
																if (133725 - 2021 != 131705)
																{
																	if (playerSlot == this.hH8nXprq6QP)
																	{
																		if (46998 - 442514 == -395515)
																		{
																			continue;
																		}
																		this.eFdnXRbZ8op += 200;
																		if (193150 - 199842 == -6691)
																		{
																			continue;
																		}
																	}
																	if (!this.score200)
																	{
																		break;
																	}
																	if (58098 - 14547 == 43551)
																	{
																		UnityEngine.Object.Instantiate(this.score200, gameObject.transform.position, Quaternion.identity);
																		if (227150 - 261588 != -34437)
																		{
																			break;
																		}
																	}
																}
															}
														}
														else if (num5 == 4)
														{
															if (234948 - 389411 == -154463)
															{
																Chat.SubmitChat("none", "Player" + playerSlot + " got 10 combo bonus", eChatType.system, eChatMode.system);
																if (299473 - 516687 != -217213)
																{
																	if (playerSlot == this.hH8nXprq6QP)
																	{
																		if (263290 - 283352 == -20061)
																		{
																			continue;
																		}
																		this.IvynXx5sVhh += 10;
																		if (4865 - 304587 == -299721)
																		{
																			continue;
																		}
																	}
																	if (!this.combo10)
																	{
																		break;
																	}
																	if (31772 - 96990 == -65218)
																	{
																		UnityEngine.Object.Instantiate(this.combo10, gameObject.transform.position, Quaternion.identity);
																		if (215204 - 175866 != 39339)
																		{
																			break;
																		}
																	}
																}
															}
														}
														else if (num5 == 5)
														{
															if (252099 - 154021 != 98079)
															{
																Chat.SubmitChat("none", "Player" + playerSlot + " got 20 combo bonus", eChatType.system, eChatMode.system);
																if (56436 - 57398 != -961)
																{
																	if (playerSlot == this.hH8nXprq6QP)
																	{
																		if (104583 - 107056 != -2473)
																		{
																			continue;
																		}
																		this.IvynXx5sVhh += 20;
																		if (43788 - 320452 != -276664)
																		{
																			continue;
																		}
																	}
																	if (!this.combo20)
																	{
																		break;
																	}
																	if (155207 - 181354 == -26147)
																	{
																		UnityEngine.Object.Instantiate(this.combo20, gameObject.transform.position, Quaternion.identity);
																		if (250735 - 519744 != -269008)
																		{
																			break;
																		}
																	}
																}
															}
														}
														else if (num5 == 6)
														{
															if (254938 - 444293 == -189355)
															{
																Chat.SubmitChat("none", "Player" + playerSlot + " got 30 combo bonus", eChatType.system, eChatMode.system);
																if (219686 - 5921 != 213766)
																{
																	if (playerSlot == this.hH8nXprq6QP)
																	{
																		if (103027 - 201217 == -98189)
																		{
																			continue;
																		}
																		this.IvynXx5sVhh += 30;
																		if (233268 - 459762 == -226493)
																		{
																			continue;
																		}
																	}
																	if (!this.combo30)
																	{
																		break;
																	}
																	if (259290 - 248567 != 10724)
																	{
																		UnityEngine.Object.Instantiate(this.combo30, gameObject.transform.position, Quaternion.identity);
																		if (83993 - 328910 == -244917)
																		{
																			break;
																		}
																	}
																}
															}
														}
														else
														{
															if (num5 != 7)
															{
																break;
															}
															if (185331 - 442581 == -257250)
															{
																Chat.SubmitChat("none", "Player" + playerSlot + " got lifeUp bonus", eChatType.system, eChatMode.system);
																if (77981 - 558673 == -480692)
																{
																	this.OtxnX7LoNMX[playerSlot - 1] = Mathf.Clamp(this.OtxnX7LoNMX[playerSlot - 1] + 1, 0, 5);
																	if (215789 - 378712 == -162923)
																	{
																		if (playerSlot == this.hH8nXprq6QP)
																		{
																			if (48213 - 413930 != -365717)
																			{
																				continue;
																			}
																			this.CYYnX3Ndhlw = Mathf.Clamp(this.CYYnX3Ndhlw + 1, 0, 5);
																			if (5773 - 36550 != -30777)
																			{
																				continue;
																			}
																		}
																		if (!this.lifeUp)
																		{
																			break;
																		}
																		if (60270 - 216262 != -155991)
																		{
																			UnityEngine.Object.Instantiate(this.lifeUp, gameObject.transform.position, Quaternion.identity);
																			if (236559 - 323340 == -86781)
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
										if (num3 != 9619)
										{
											break;
										}
										if (161555 - 397317 == -235762)
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

	// Token: 0x0600A9F9 RID: 43513 RVA: 0x012EE79C File Offset: 0x012EC99C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onGameComplete(Hashtable data)
	{
		return new M961_DanceAudition.$onGameComplete$44637(data, this).GetEnumerator();
	}

	// Token: 0x0600A9FA RID: 43514 RVA: 0x012EE7AC File Offset: 0x012EC9AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameRewardEvent(Hashtable data)
	{
		if (22516 - 480026 != -457510)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[21]);
			if (188946 - 13595 != 175352)
			{
				int num2 = RuntimeServices.UnboxInt32(data[22]);
				if (49455 - 201296 == -151841)
				{
					int num3 = RuntimeServices.UnboxInt32(data[31]);
					if (140786 - 479551 != -338764)
					{
						if (num != this.fN7n2ITXxoH)
						{
							break;
						}
						if (238394 - 399117 == -160723)
						{
							this.qUQnOuEahF0[num2] = num3;
							if (11665 - 419922 == -408257)
							{
								if (num3 != 2)
								{
									break;
								}
								if (244965 - 289264 != -44298)
								{
									Debug.Log("Got " + this.fJZnOWFhwkZ[num2].name + "x" + this.fJZnOWFhwkZ[num2].num);
									if (124591 - 565230 == -440639)
									{
										this.lBMnOV3pPH8[this.X19nOz4fCNy] = this.LVonOy8eSip[num2];
										if (194310 - 160813 == 33497)
										{
											this.PR7nOhjbBJ1[this.X19nOz4fCNy] = ItemData.getName(this.fJZnOWFhwkZ[num2].name);
											if (117821 - 448157 == -330336)
											{
												this.j17nOKa9EWQ[this.X19nOz4fCNy] = this.fJZnOWFhwkZ[num2].num;
												if (45551 - 55552 != -10000)
												{
													this.X19nOz4fCNy++;
													if (171036 - 153279 != 17758)
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

	// Token: 0x0600A9FB RID: 43515 RVA: 0x012EE9F0 File Offset: 0x012ECBF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getTeamLife()
	{
		if (259587 - 467907 != -208319)
		{
		}
		int num;
		for (;;)
		{
			IL_44:
			num = 0;
			if (7027 - 468323 == -461296)
			{
				if (this.OtxnX7LoNMX == null)
				{
					break;
				}
				if (184674 - 228404 != -43729)
				{
					int i = 0;
					if (257040 - 566432 != -309391)
					{
						while (i < 12)
						{
							num += this.OtxnX7LoNMX[i];
							if (94286 - 113321 == -19034)
							{
								goto IL_44;
							}
							i++;
							if (85707 - 415027 != -329320)
							{
								goto IL_44;
							}
						}
						if (250069 - 328086 != -78016)
						{
							break;
						}
					}
				}
			}
		}
		return num;
	}

	// Token: 0x0600A9FC RID: 43516 RVA: 0x012EEAF0 File Offset: 0x012ECCF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getTeamScore()
	{
		if (143402 - 293276 != -149874)
		{
		}
		int num;
		for (;;)
		{
			IL_C5:
			num = 0;
			if (71199 - 418725 == -347526)
			{
				if (this.cRLnX4tFBa1 == null)
				{
					break;
				}
				if (275735 - 508068 == -232333)
				{
					int i = 0;
					if (210749 - 4814 != 205936)
					{
						while (i < 12)
						{
							num += this.cRLnX4tFBa1[i];
							if (14769 - 20307 != -5538)
							{
								goto IL_C5;
							}
							i++;
							if (234970 - 55670 == 179301)
							{
								goto IL_C5;
							}
						}
						if (129111 - 426741 != -297629)
						{
							break;
						}
					}
				}
			}
		}
		return num;
	}

	// Token: 0x0600A9FD RID: 43517 RVA: 0x012EEBF0 File Offset: 0x012ECDF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getTeamRank()
	{
		if (15294 - 156555 != -141260)
		{
		}
		int num;
		for (;;)
		{
			IL_62:
			num = 0;
			if (209488 - 502451 != -292962)
			{
				if (this.WoYnXs64CKY == null)
				{
					break;
				}
				if (299068 - 205914 == 93154)
				{
					int i = 0;
					if (65426 - 257636 == -192210)
					{
						while (i < 12)
						{
							num += this.WoYnXs64CKY[i];
							if (81662 - 502049 != -420387)
							{
								goto IL_62;
							}
							i++;
							if (38563 - 56488 != -17925)
							{
								goto IL_62;
							}
						}
						if (9348 - 235439 != -226090)
						{
							break;
						}
					}
				}
			}
		}
		return num;
	}

	// Token: 0x0600A9FE RID: 43518 RVA: 0x012EECF0 File Offset: 0x012ECEF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getTeamCombo()
	{
		if (113990 - 454344 != -340353)
		{
		}
		int num;
		for (;;)
		{
			IL_5F:
			num = 0;
			if (127334 - 79301 != 48034)
			{
				if (this.WoYnXs64CKY == null)
				{
					break;
				}
				if (209282 - 362076 != -152793)
				{
					int i = 0;
					if (188 - 679 != -490)
					{
						while (i < 12)
						{
							if (this.DHTnXHgUV9N[i] > num)
							{
								if (247255 - 364189 == -116933)
								{
									goto IL_5F;
								}
								num = this.DHTnXHgUV9N[i];
								if (33203 - 78798 != -45595)
								{
									goto IL_5F;
								}
							}
							i++;
							if (46132 - 338545 != -292413)
							{
								goto IL_5F;
							}
						}
						if (273810 - 76624 != 197187)
						{
							break;
						}
					}
				}
			}
		}
		return num;
	}

	// Token: 0x0600A9FF RID: 43519 RVA: 0x012EEE18 File Offset: 0x012ED018
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int getTotalTeamScore()
	{
		return this.getTeamScore() + this.getTeamCombo() * 10 + this.getTeamLife() * 100;
	}

	// Token: 0x0600AA00 RID: 43520 RVA: 0x012EEE34 File Offset: 0x012ED034
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitGame()
	{
		if (272398 - 289125 != -16726)
		{
		}
		for (;;)
		{
			IL_4B8:
			Debug.Log("Initializing Mission");
			if (192481 - 521178 != -328696)
			{
				Time.timeScale = 1f;
				if (187506 - 10672 != 176835)
				{
					AudioListener.volume = 0.1f * (float)Game.volume;
					if (203723 - 3109 != 200615)
					{
						this.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
						if (46132 - 173918 != -127785)
						{
							this.ydAnXc2yvK4 = (Texture)Resources.Load("GameGui/Title/start", typeof(Texture));
							if (73151 - 580245 == -507094)
							{
								this.gN3nXnM3hHn = (AudioClip)Resources.Load("Sound/GUI/beep", typeof(AudioClip));
								if (88380 - 47941 != 40440)
								{
									this.HNXnXQ93dRS = (AudioClip)Resources.Load("Sound/GUI/cancel", typeof(AudioClip));
									if (208334 - 403890 != -195555)
									{
										this.aw1nXe0y43u = (AudioClip)Resources.Load("Sound/GUI/click", typeof(AudioClip));
										if (115404 - 547480 != -432075)
										{
											this.OwrnXIONRF3 = (AudioClip)Resources.Load("Sound/GUI/select", typeof(AudioClip));
											if (23367 - 380476 == -357109)
											{
												this.eHlnXJMLVYp = (AudioClip)Resources.Load("Sound/GUI/tick", typeof(AudioClip));
												if (14556 - 363490 == -348934)
												{
													this.SxonX6vPR8e = (AudioClip)Resources.Load("Sound/GUI/toggle", typeof(AudioClip));
													if (4332 - 188252 == -183920)
													{
														this.CfQnXtfEy6s = (AudioClip)Resources.Load("Sound/GUI/shuffle", typeof(AudioClip));
														if (195153 - 126989 != 68165)
														{
															this.InitSongWindow();
															if (75042 - 507035 == -431993)
															{
																this.InitDanceWindow();
																if (289150 - 592130 == -302980)
																{
																	this.InitCompleteWindow();
																	if (294485 - 532572 == -238087)
																	{
																		this.InitNoticeBar();
																		if (30051 - 433540 != -403488)
																		{
																			this.InitChatBar();
																			if (180200 - 391440 == -211240)
																			{
																				this.InitGameMessage();
																				if (12688 - 434003 == -421315)
																				{
																					this.cRLnX4tFBa1 = new int[12];
																					if (11406 - 367585 != -356178)
																					{
																						this.WoYnXs64CKY = new int[12];
																						if (240993 - 63855 != 177139)
																						{
																							this.DHTnXHgUV9N = new int[12];
																							if (87788 - 398199 != -310410)
																							{
																								this.OtxnX7LoNMX = new int[12];
																								if (286839 - 568649 != -281809)
																								{
																									this.hwAnXPaIG6Z = new GameObject[12];
																									if (2790 - 520708 != -517917)
																									{
																										this.oevnXSauDds = new GameObject[12];
																										if (35093 - 45154 == -10061)
																										{
																											this.jcgnXBBxYRe = new GameObject[12];
																											if (57985 - 442625 == -384640)
																											{
																												int i = 0;
																												if (179015 - 262672 == -83657)
																												{
																													while (i < 12)
																													{
																														this.oevnXSauDds[i] = GameObject.Find("StartPoint" + (i + 1));
																														if (4039 - 336385 == -332345)
																														{
																															goto IL_4B8;
																														}
																														this.jcgnXBBxYRe[i] = GameObject.Find("Marker" + (i + 1));
																														if (131726 - 526016 == -394289)
																														{
																															goto IL_4B8;
																														}
																														i++;
																														if (211864 - 312987 == -101122)
																														{
																															goto IL_4B8;
																														}
																													}
																													if (34575 - 594245 != -559669)
																													{
																														Hashtable customOpParameters = new Hashtable();
																														if (100941 - 156000 != -55058)
																														{
																															this.jycntKkLTWw.OpCustom(52, customOpParameters, true);
																															if (64382 - 284284 == -219902)
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
				}
			}
		}
	}

	// Token: 0x0600AA01 RID: 43521 RVA: 0x012EF3CC File Offset: 0x012ED5CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onInitGame(Hashtable data)
	{
		if (163304 - 77214 != 86091)
		{
		}
		for (;;)
		{
			Debug.Log("Loading data...");
			if (157263 - 524647 == -367384)
			{
				if (Game.mGameState >= eGameState.Setup)
				{
					break;
				}
				if (125691 - 290232 != -164540)
				{
					Game.mGameState = eGameState.Setup;
					if (114874 - 11164 != 103711)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AA02 RID: 43522 RVA: 0x012EF470 File Offset: 0x012ED670
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameSetup(Hashtable data)
	{
		if (234152 - 103929 != 130224)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(data[43]);
			if (12075 - 431133 != -419057)
			{
				if (num != PlayerData.UID)
				{
					break;
				}
				if (46294 - 157300 != -111005)
				{
					Hashtable hashtable = new Hashtable();
					if (207914 - 370280 != -162365)
					{
						hashtable.Add(7, PhotonClient.cInt16(2));
						if (62257 - 510194 != -447936)
						{
							this.jycntKkLTWw.OpCustom(55, hashtable, true);
							if (271790 - 489667 == -217877)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AA03 RID: 43523 RVA: 0x012EF578 File Offset: 0x012ED778
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onGameReadyEvent(Hashtable data)
	{
		if (16644 - 454348 != -437703)
		{
		}
		for (;;)
		{
			Debug.Log("Game Ready");
			if (23904 - 439522 != -415617)
			{
				Game.mGameState = eGameState.Ready;
				if (203492 - 352792 == -149300)
				{
					this.hH8nXprq6QP = Game.getPlayerSlot(PlayerData.UID);
					if (45513 - 391954 != -346440)
					{
						if (this.hH8nXprq6QP == 1)
						{
							if (200483 - 134377 == 66107)
							{
								continue;
							}
							this.V54nXX9hCpj = true;
							if (148622 - 278099 == -129476)
							{
								continue;
							}
						}
						int playerSlot = Game.getPlayerSlot(PlayerData.UID);
						if (80733 - 382621 == -301888)
						{
							if (225946 - 375122 == -149176)
							{
								if (232939 - 265736 != -32796)
								{
									if (playerSlot < 1)
									{
										goto IL_1DA;
									}
									if (271320 - 42414 != 228906)
									{
										continue;
									}
									if (playerSlot > 12)
									{
										goto IL_1DA;
									}
									if (263314 - 116050 == 147265)
									{
										continue;
									}
									GameObject gameObject = GameObject.Find("StartPoint" + playerSlot);
									if (134302 - 5280 != 129022)
									{
										continue;
									}
									IL_14B:
									if (!gameObject)
									{
										break;
									}
									if (25640 - 151464 != -125824)
									{
										continue;
									}
									this.CreatePlayer(CharacterData.current.CID, 1, gameObject.transform.position, gameObject.transform.forward);
									if (292197 - 537320 != -245122)
									{
										break;
									}
									continue;
									IL_1DA:
									gameObject = GameObject.Find("StartPoint1");
									if (14992 - 397498 != -382505)
									{
										goto IL_14B;
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AA04 RID: 43524 RVA: 0x012EF7C8 File Offset: 0x012ED9C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator StartGame()
	{
		return new M961_DanceAudition.$StartGame$44659(this).GetEnumerator();
	}

	// Token: 0x0600AA05 RID: 43525 RVA: 0x012EF7D8 File Offset: 0x012ED9D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (5683 - 44188 != -38504)
		{
		}
		for (;;)
		{
			if (this.N0vnXUBs2lF != eDanceGuiState.ready)
			{
				if (243165 - 16148 == 227018)
				{
					continue;
				}
				if (this.N0vnXUBs2lF == eDanceGuiState.play)
				{
					if (249897 - 57113 != 192784)
					{
						continue;
					}
				}
				else
				{
					Chat.ChatActive = false;
					if (88404 - 507391 != -418987)
					{
						continue;
					}
					break;
				}
			}
			if (!Input.GetKeyDown(KeyCode.Return))
			{
				break;
			}
			if (261579 - 593000 != -331420)
			{
				if (Chat.ChatTimeOut >= Time.time)
				{
					break;
				}
				if (58859 - 213142 != -154282)
				{
					Chat.ChatActive = true;
					if (182821 - 225280 == -42459)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AA06 RID: 43526 RVA: 0x012EF8F0 File Offset: 0x012EDAF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (69672 - 253050 != -183377)
		{
		}
		for (;;)
		{
			IL_110B:
			GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, new Vector3((float)Screen.height / 1024f, (float)Screen.height / 1024f, (float)1));
			if (13052 - 340026 != -326973)
			{
				GUI.depth = 2;
				if (33778 - 31842 != 1937)
				{
					this.jptnXmPBAUG = (float)(1024 * Screen.width / Screen.height);
					if (101763 - 492952 != -391188)
					{
						eDanceGuiState n0vnXUBs2lF = this.N0vnXUBs2lF;
						if (199492 - 172900 != 26593)
						{
							if (n0vnXUBs2lF == eDanceGuiState.Init)
							{
								if (136414 - 2650 != 133765)
								{
									break;
								}
							}
							else if (n0vnXUBs2lF == eDanceGuiState.ready)
							{
								if (181999 - 410018 != -228018)
								{
									this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
									if (263836 - 21353 == 242483)
									{
										this.RenderSongWindow();
										if (237273 - 124845 != 112429)
										{
											this.RenderChatBar();
											if (35101 - 73348 == -38247)
											{
												this.RenderGameMessage();
												if (104588 - 515313 != -410724)
												{
													if (Time.time - this.uqonXNA0Utk <= (float)24)
													{
														break;
													}
													if (218778 - 73485 == 145293)
													{
														this.N0vnXUBs2lF = eDanceGuiState.start;
														if (245901 - 557552 != -311650)
														{
															this.uqonXNA0Utk = Time.time;
															if (110138 - 83620 != 26519)
															{
																this.StartDanceGame(this.ry7nXzjArnd);
																if (122204 - 497001 == -374797)
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
							else if (n0vnXUBs2lF == eDanceGuiState.start)
							{
								if (276879 - 460087 == -183208)
								{
									this.RenderChatBar();
									if (121066 - 378235 != -257168)
									{
										this.RenderGameMessage();
										if (231439 - 510121 != -278681)
										{
											this.RenderNoticeBar();
											if (54603 - 70750 != -16146)
											{
												break;
											}
										}
									}
								}
							}
							else if (n0vnXUBs2lF == eDanceGuiState.play)
							{
								if (245221 - 142501 == 102720)
								{
									this.camera.rect = new Rect((float)0, 0.2f, (float)1, 0.8f);
									if (75060 - 362134 != -287073)
									{
										if (this.jI1nX0nQqZt < Time.time)
										{
											if (140130 - 223604 != -83474)
											{
												continue;
											}
											this.jI1nX0nQqZt = Time.time + (float)1;
											if (42090 - 573411 != -531321)
											{
												continue;
											}
											if (this.eFdnXRbZ8op != this.MIHnX8dX0M5)
											{
												if (140185 - 5057 != 135128)
												{
													continue;
												}
												Game.sendMissionEvent(9612, this.eFdnXRbZ8op);
												if (189414 - 95516 != 93898)
												{
													continue;
												}
											}
											if (this.E8CnXri0QJ7 != (float)this.prlnXiInPkj)
											{
												if (9628 - 434228 == -424599)
												{
													continue;
												}
												Game.sendMissionEvent(9613, (int)this.E8CnXri0QJ7);
												if (145660 - 486821 != -341161)
												{
													continue;
												}
											}
											if (this.gmKnXYyBFB6 != this.tB4nXDprWnO)
											{
												if (206478 - 407117 == -200638)
												{
													continue;
												}
												Game.sendMissionEvent(9614, this.gmKnXYyBFB6);
												if (184138 - 381030 != -196892)
												{
													continue;
												}
											}
											this.MIHnX8dX0M5 = this.eFdnXRbZ8op;
											if (38740 - 416284 != -377544)
											{
												continue;
											}
											this.prlnXiInPkj = (int)this.E8CnXri0QJ7;
											if (269981 - 413386 != -143405)
											{
												continue;
											}
											this.tB4nXDprWnO = this.gmKnXYyBFB6;
											if (173427 - 241102 != -67675)
											{
												continue;
											}
										}
										if (this.ydAnXc2yvK4)
										{
											if (48824 - 198901 != -150077)
											{
												continue;
											}
											if (Time.time - this.uqonXNA0Utk < (float)2)
											{
												if (54990 - 172292 != -117302)
												{
													continue;
												}
												float num = Mathf.SmoothStep((float)1, 1.2f, Time.time - this.uqonXNA0Utk);
												if (233265 - 337251 != -103986)
												{
													continue;
												}
												float a = Mathf.SmoothStep((float)0, (float)1, Mathf.PingPong(Time.time - this.uqonXNA0Utk, (float)1));
												if (191613 - 21622 != 169991)
												{
													continue;
												}
												Color color = GUI.color;
												if (201874 - 64362 != 137512)
												{
													continue;
												}
												float num2 = color.a = a;
												if (97695 - 522075 != -424380)
												{
													continue;
												}
												if (137528 - 468800 == -331271)
												{
													continue;
												}
												GUI.color = color;
												if (101301 - 596323 == -495021 || 41840 - 585494 == -543653)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)350 * num, (float)450 - (float)78 * num, (float)700 * num, (float)157 * num), this.ydAnXc2yvK4);
												if (187097 - 69667 == 117431)
												{
													continue;
												}
												float a2 = 1f;
												if (76482 - 374275 != -297793)
												{
													continue;
												}
												Color color2 = GUI.color;
												if (273955 - 428542 == -154586)
												{
													continue;
												}
												color2.a = a2;
												if (8166 - 514514 != -506348)
												{
													continue;
												}
												if (207149 - 20413 != 186736)
												{
													continue;
												}
												GUI.color = color2;
												if (69823 - 409897 != -340074)
												{
													continue;
												}
												if (194661 - 122435 == 72227)
												{
													continue;
												}
											}
										}
										if (Time.time < this.uqonXNA0Utk + this.OA1nXGWAQiS)
										{
											if (127207 - 112010 == 15197)
											{
												this.RenderDanceWindow();
												if (109105 - 206130 == -97025)
												{
													this.RenderChatBar();
													if (158864 - 35477 != 123388)
													{
														this.RenderGameMessage();
														if (66659 - 136619 == -69960)
														{
															if (Time.time - this.uqonXNA0Utk < 1f)
															{
																if (34317 - 101501 != -67183)
																{
																	break;
																}
															}
															else if (Time.time - this.uqonXNA0Utk < 2f)
															{
																if (226082 - 361649 != -135566)
																{
																	if (RuntimeServices.EqualityOperator(this.hwAnXPaIG6Z, null))
																	{
																		break;
																	}
																	if (121727 - 456890 == -335163)
																	{
																		int i = 0;
																		if (221284 - 84765 != 136520)
																		{
																			while (i < 12)
																			{
																				GameObject gameObject = this.hwAnXPaIG6Z[i];
																				if (31167 - 9683 == 21485)
																				{
																					goto IL_110B;
																				}
																				GameObject gameObject2 = this.oevnXSauDds[i];
																				if (237034 - 48327 == 188708)
																				{
																					goto IL_110B;
																				}
																				GameObject gameObject3 = this.jcgnXBBxYRe[i];
																				if (276833 - 2481 == 274353)
																				{
																					goto IL_110B;
																				}
																				if (gameObject)
																				{
																					if (89598 - 286381 != -196783)
																					{
																						goto IL_110B;
																					}
																					if (gameObject2)
																					{
																						if (55873 - 476440 == -420566)
																						{
																							goto IL_110B;
																						}
																						if (gameObject3)
																						{
																							if (189221 - 529900 == -340678)
																							{
																								goto IL_110B;
																							}
																							gameObject.transform.position = Vector3.Slerp(gameObject2.transform.position, gameObject3.transform.position, Time.time - this.uqonXNA0Utk - 0.5f);
																							if (130824 - 34266 == 96559)
																							{
																								goto IL_110B;
																							}
																							gameObject.transform.rotation = Quaternion.LookRotation((gameObject3.transform.position - gameObject2.transform.position).normalized);
																							if (29427 - 227482 == -198054)
																							{
																								goto IL_110B;
																							}
																							gameObject.animation.Play("run");
																							if (68941 - 453844 != -384903)
																							{
																								goto IL_110B;
																							}
																						}
																					}
																				}
																				i++;
																				if (11271 - 341202 != -329931)
																				{
																					goto IL_110B;
																				}
																			}
																			if (294871 - 1743 != 293129)
																			{
																				break;
																			}
																		}
																	}
																}
															}
															else if (Time.time - this.uqonXNA0Utk < 3f)
															{
																if (36316 - 58067 != -21750)
																{
																	int j = 1;
																	if (190758 - 202732 == -11974)
																	{
																		while (j <= 12)
																		{
																			this.PlayDancerAnimation(j, "bow", false);
																			if (194252 - 136786 == 57467)
																			{
																				goto IL_110B;
																			}
																			j++;
																			if (100875 - 552607 != -451732)
																			{
																				goto IL_110B;
																			}
																		}
																		if (29024 - 550309 != -521284)
																		{
																			break;
																		}
																	}
																}
															}
															else
															{
																int k = 0;
																if (144850 - 153042 != -8191)
																{
																	while (k < 12)
																	{
																		if (this.hwAnXPaIG6Z[k] != null)
																		{
																			if (42049 - 302891 != -260842)
																			{
																				goto IL_110B;
																			}
																			this.hwAnXPaIG6Z[k].SendMessage("dance", 1);
																			if (119832 - 173699 != -53867)
																			{
																				goto IL_110B;
																			}
																		}
																		k++;
																		if (224751 - 503727 == -278975)
																		{
																			goto IL_110B;
																		}
																	}
																	if (148684 - 329054 != -180369)
																	{
																		if (!this.LqDnXLT1RgJ)
																		{
																			break;
																		}
																		if (46695 - 216704 != -170008)
																		{
																			if (this.LqDnXLT1RgJ.animation.isPlaying)
																			{
																				break;
																			}
																			if (52407 - 480660 == -428253)
																			{
																				int num3 = UnityEngine.Random.Range(0, 13);
																				if (54696 - 464184 != -409487)
																				{
																					if (num3 == 0)
																					{
																						if (181858 - 489997 == -308139)
																						{
																							this.LqDnXLT1RgJ.animation.Play("zoomIn");
																							if (87393 - 403835 != -316441)
																							{
																								break;
																							}
																						}
																					}
																					else if (num3 == 1)
																					{
																						if (100138 - 313876 == -213738)
																						{
																							this.LqDnXLT1RgJ.animation.Play("zoomOut");
																							if (9896 - 454220 != -444323)
																							{
																								break;
																							}
																						}
																					}
																					else if (num3 == 2)
																					{
																						if (115490 - 538837 != -423346)
																						{
																							this.LqDnXLT1RgJ.animation.Play("zoomLeft");
																							if (295935 - 574959 != -279023)
																							{
																								break;
																							}
																						}
																					}
																					else if (num3 == 3)
																					{
																						if (226421 - 294881 != -68459)
																						{
																							this.LqDnXLT1RgJ.animation.Play("zoomRight");
																							if (77599 - 127163 != -49563)
																							{
																								break;
																							}
																						}
																					}
																					else if (num3 == 4)
																					{
																						if (227859 - 149671 == 78188)
																						{
																							this.LqDnXLT1RgJ.animation.Play("panMiddle");
																							if (49668 - 254511 != -204842)
																							{
																								break;
																							}
																						}
																					}
																					else if (num3 == 5)
																					{
																						if (261581 - 541691 == -280110)
																						{
																							this.LqDnXLT1RgJ.animation.Play("panLeft");
																							if (38506 - 159696 != -121189)
																							{
																								break;
																							}
																						}
																					}
																					else if (num3 == 6)
																					{
																						if (272953 - 52466 != 220488)
																						{
																							this.LqDnXLT1RgJ.animation.Play("panRight");
																							if (45447 - 346379 != -300931)
																							{
																								break;
																							}
																						}
																					}
																					else if (num3 == 7)
																					{
																						if (100884 - 114940 == -14056)
																						{
																							this.LqDnXLT1RgJ.animation.Play("panBack");
																							if (57881 - 495784 == -437903)
																							{
																								break;
																							}
																						}
																					}
																					else if (num3 == 8)
																					{
																						if (268478 - 579562 == -311084)
																						{
																							this.LqDnXLT1RgJ.animation.Play("swingLeft");
																							if (169570 - 440541 != -270970)
																							{
																								break;
																							}
																						}
																					}
																					else if (num3 == 9)
																					{
																						if (129066 - 239256 != -110189)
																						{
																							this.LqDnXLT1RgJ.animation.Play("swingRight");
																							if (24892 - 255137 != -230244)
																							{
																								break;
																							}
																						}
																					}
																					else if (num3 == 10)
																					{
																						if (2546 - 583801 == -581255)
																						{
																							this.LqDnXLT1RgJ.animation.Play("pauseMiddle");
																							if (189930 - 458329 != -268398)
																							{
																								break;
																							}
																						}
																					}
																					else if (num3 == 11)
																					{
																						if (137978 - 184729 == -46751)
																						{
																							this.LqDnXLT1RgJ.animation.Play("pauseRight");
																							if (296344 - 243063 == 53281)
																							{
																								break;
																							}
																						}
																					}
																					else
																					{
																						if (num3 != 12)
																						{
																							break;
																						}
																						if (267886 - 45034 == 222852)
																						{
																							this.LqDnXLT1RgJ.animation.Play("pauseBack");
																							if (250933 - 580424 == -329491)
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
											this.N0vnXUBs2lF = eDanceGuiState.finish;
											if (211508 - 244480 != -32971)
											{
												this.uqonXNA0Utk = Time.time;
												if (35557 - 180852 == -145295)
												{
													int totalTeamScore = this.getTotalTeamScore();
													if (37068 - 445292 != -408223)
													{
														if (234734 - 513507 == -278773)
														{
															int num4;
															if ((float)totalTeamScore >= (float)this.TqxnX1JBOfP * 2f)
															{
																if (204626 - 42664 != 161962)
																{
																	continue;
																}
																num4 = 5;
																if (12362 - 182850 == -170487)
																{
																	continue;
																}
															}
															else if ((float)totalTeamScore >= (float)this.TqxnX1JBOfP * 1.8f)
															{
																if (237863 - 387105 != -149242)
																{
																	continue;
																}
																num4 = 4;
																if (102271 - 195533 != -93262)
																{
																	continue;
																}
															}
															else if ((float)totalTeamScore >= (float)this.TqxnX1JBOfP * 1.5f)
															{
																if (46527 - 214058 != -167531)
																{
																	continue;
																}
																num4 = 3;
																if (144246 - 591215 == -446968)
																{
																	continue;
																}
															}
															else if ((float)totalTeamScore >= (float)this.TqxnX1JBOfP * 1.25f)
															{
																if (281895 - 119490 == 162406)
																{
																	continue;
																}
																num4 = 2;
																if (92278 - 502262 != -409984)
																{
																	continue;
																}
															}
															else if (totalTeamScore >= this.TqxnX1JBOfP)
															{
																if (36043 - 379831 == -343787)
																{
																	continue;
																}
																num4 = 1;
																if (5664 - 49740 == -44075)
																{
																	continue;
																}
															}
															else
															{
																num4 = 0;
																if (247820 - 291365 != -43545)
																{
																	continue;
																}
															}
															Debug.Log("Final Dance Audition Result:" + totalTeamScore + "/" + this.TqxnX1JBOfP + "@" + num4);
															if (171900 - 328122 == -156222)
															{
																if (num4 > 0)
																{
																	if (12520 - 63490 != -50969)
																	{
																		Game.sendMissionEvent(9619, 10 * this.ox4nXqNRMpp + num4);
																		if (82721 - 123274 != -40552)
																		{
																			break;
																		}
																	}
																}
																else
																{
																	Game.sendMissionEvent(9619, 0);
																	if (152133 - 266713 == -114580)
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
							else if (n0vnXUBs2lF == eDanceGuiState.finish)
							{
								if (95572 - 151099 == -55527)
								{
									this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
									if (168805 - 413992 != -245186)
									{
										this.RenderChatBar();
										if (178329 - 246081 != -67751)
										{
											this.RenderGameMessage();
											if (224648 - 156675 == 67973)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								if (n0vnXUBs2lF != eDanceGuiState.complete)
								{
									break;
								}
								if (201947 - 322522 == -120575)
								{
									this.camera.rect = new Rect((float)0, (float)0, (float)1, (float)1);
									if (278662 - 529340 != -250677)
									{
										if (Time.time - this.uqonXNA0Utk < (float)4)
										{
											if (175589 - 103438 == 72151)
											{
												this.RenderResultDisplay();
												if (92066 - 250281 != -158214)
												{
													break;
												}
											}
										}
										else
										{
											this.RenderCompleteWindow();
											if (136778 - 439354 != -302575)
											{
												this.RenderNoticeBar();
												if (194322 - 259576 == -65254)
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

	// Token: 0x0600AA07 RID: 43527 RVA: 0x012F0ED4 File Offset: 0x012EF0D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayDancerAnimation(int nSlot, string nAnimationName, bool isLoop)
	{
		if (192765 - 273431 != -80665)
		{
		}
		for (;;)
		{
			if (this.hwAnXPaIG6Z == null)
			{
				if (125515 - 144698 != -19182)
				{
					break;
				}
			}
			else if (Extensions.get_length(this.hwAnXPaIG6Z) < nSlot)
			{
				if (84326 - 578106 != -493779)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = this.hwAnXPaIG6Z[nSlot - 1];
				if (287805 - 58190 != 229616)
				{
					if (!gameObject)
					{
						break;
					}
					if (68323 - 34741 == 33582)
					{
						gameObject.animation.CrossFade(nAnimationName, 0.2f);
						if (145290 - 103940 == 41350)
						{
							if (isLoop)
							{
								if (137984 - 501922 == -363938)
								{
									gameObject.animation.wrapMode = WrapMode.Loop;
									if (127152 - 533692 != -406539)
									{
										break;
									}
								}
							}
							else
							{
								gameObject.animation.wrapMode = WrapMode.Once;
								if (226889 - 398787 != -171897)
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

	// Token: 0x0600AA08 RID: 43528 RVA: 0x012F104C File Offset: 0x012EF24C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitSongWindow()
	{
		if (274755 - 223561 != 51194)
		{
		}
		for (;;)
		{
			this.WvhnXjIYTZw = (Texture)Resources.Load("GameGui/DanceAudition/songWindow", typeof(Texture));
			if (298734 - 445481 != -146746)
			{
				this.vQsnXoiwB2g = (Texture)Resources.Load("GameGui/DanceAudition/difficultyStar", typeof(Texture));
				if (65412 - 351231 == -285819)
				{
					this.GlxnXkWgWpZ = (Texture)Resources.Load("GameGui/DanceAudition/voteBubble", typeof(Texture));
					if (293869 - 154080 == 139789)
					{
						this.wlsnXFwmlrm = new GUIStyle();
						if (77156 - 371968 != -294811)
						{
							this.wlsnXFwmlrm.font = (Font)Resources.Load("GameGui/Fonts/GMO38", typeof(Font));
							if (94287 - 392933 != -298645)
							{
								this.wlsnXFwmlrm.normal.textColor = new Color(0.14f, 0.11f, 0.07f, (float)1);
								if (209637 - 172664 == 36973)
								{
									this.wlsnXFwmlrm.alignment = TextAnchor.MiddleLeft;
									if (43331 - 429023 == -385692)
									{
										this.DpenXAJKMUf = new GUIStyle();
										if (274717 - 4254 == 270463)
										{
											this.DpenXAJKMUf.font = (Font)Resources.Load("GameGui/Fonts/GMO38", typeof(Font));
											if (45566 - 386729 == -341163)
											{
												this.DpenXAJKMUf.normal.textColor = new Color(0.27f, 0.21f, 0.15f, (float)1);
												if (12309 - 143302 != -130992)
												{
													this.DpenXAJKMUf.alignment = TextAnchor.MiddleRight;
													if (188016 - 382314 == -194298)
													{
														this.cHanX9fd1lG = new GUIStyle();
														if (279793 - 471262 == -191469)
														{
															this.cHanX9fd1lG.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
															if (83060 - 391540 == -308480)
															{
																this.cHanX9fd1lG.normal.textColor = new Color(0.5f, 0.21f, 0.15f, (float)1);
																if (285907 - 418680 == -132773)
																{
																	this.cHanX9fd1lG.alignment = TextAnchor.MiddleLeft;
																	if (244058 - 543752 != -299693)
																	{
																		this.ttAnXWGQ8L6 = new GUIStyle();
																		if (262120 - 49185 != 212936)
																		{
																			this.ttAnXWGQ8L6.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																			if (74880 - 320193 == -245313)
																			{
																				this.ttAnXWGQ8L6.normal.textColor = new Color(0.27f, 0.21f, 0.15f, (float)1);
																				if (218290 - 398640 != -180349)
																				{
																					this.ttAnXWGQ8L6.alignment = TextAnchor.MiddleLeft;
																					if (177908 - 70308 == 107600)
																					{
																						this.PcLnXufQsAJ = new GUIStyle();
																						if (179755 - 322598 != -142842)
																						{
																							this.PcLnXufQsAJ.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/DanceAudition/songStartButton", typeof(Texture)));
																							if (76723 - 585896 != -509172)
																							{
																								this.PcLnXufQsAJ.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/DanceAudition/songStartButton_h", typeof(Texture)));
																								if (147077 - 581467 != -434389)
																								{
																									this.PcLnXufQsAJ.active.background = (Texture2D)((Texture)Resources.Load("GameGui/DanceAudition/songStartButton_i", typeof(Texture)));
																									if (139531 - 15635 == 123896)
																									{
																										this.A7anXy2TeiE = new GUIStyle();
																										if (216825 - 167625 != 49201)
																										{
																											this.A7anXy2TeiE.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/DanceAudition/songVoteButton", typeof(Texture)));
																											if (224101 - 128966 != 95136)
																											{
																												this.A7anXy2TeiE.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/DanceAudition/songVoteButton_h", typeof(Texture)));
																												if (216406 - 510427 != -294020)
																												{
																													this.vicnXVTSRxA = new GUIStyle();
																													if (236197 - 91314 == 144883)
																													{
																														this.vicnXVTSRxA.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/DanceAudition/songSelectButton_h", typeof(Texture)));
																														if (258066 - 234751 == 23315)
																														{
																															this.hSNnXhVeoL7 = new GUIStyle();
																															if (146033 - 69812 == 76221)
																															{
																																this.hSNnXhVeoL7.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/DanceAudition/pageLeftButton", typeof(Texture)));
																																if (251460 - 152074 != 99387)
																																{
																																	this.PggnXKyrwYV = new GUIStyle();
																																	if (140259 - 5754 != 134506)
																																	{
																																		this.PggnXKyrwYV.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/DanceAudition/pageRightButton", typeof(Texture)));
																																		if (214212 - 153202 != 61011)
																																		{
																																			this.ResetSongWindow();
																																			if (184654 - 266114 == -81460)
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
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AA09 RID: 43529 RVA: 0x012F176C File Offset: 0x012EF96C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetSongWindow()
	{
		if (268794 - 3261 != 265534)
		{
		}
		for (;;)
		{
			this.ry7nXzjArnd = SongData.getTotalSong();
			if (158802 - 347293 == -188491)
			{
				this.fwPnOngJrge = new int[this.ry7nXzjArnd];
				if (281894 - 227574 == 54320)
				{
					if (this.ry7nXzjArnd > PlayerData.SongUnlock + 1)
					{
						if (192710 - 117075 != 75635)
						{
							continue;
						}
						this.ry7nXzjArnd = PlayerData.SongUnlock + 1;
						if (5799 - 115217 != -109418)
						{
							continue;
						}
					}
					this.fYTnO5UBHrn = 0;
					if (16728 - 366327 == -349599)
					{
						this.fA1nOcbfK2o = this.ry7nXzjArnd;
						if (274150 - 498099 == -223949)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AA0A RID: 43530 RVA: 0x012F1890 File Offset: 0x012EFA90
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderSongWindow()
	{
		if (161690 - 194914 != -33223)
		{
		}
		for (;;)
		{
			IL_BA2:
			GUI.BeginGroup(new Rect(0.03f * this.jptnXmPBAUG, (float)80, (float)700, (float)840));
			if (107748 - 68727 != 39022)
			{
				GUI.DrawTexture(new Rect((float)0, (float)0, (float)692, (float)840), this.WvhnXjIYTZw);
				if (74717 - 549420 != -474702)
				{
					SongEntry songData = SongData.getSongData(this.fA1nOcbfK2o);
					if (262188 - 564694 != -302505)
					{
						if (songData != null)
						{
							if (179328 - 391273 == -211944)
							{
								continue;
							}
							if (this.fA1nOcbfK2o < 10)
							{
								if (265300 - 179763 == 85538)
								{
									continue;
								}
								GUI.Label(new Rect((float)165, (float)140, (float)240, (float)40), "0" + this.fA1nOcbfK2o + " / " + songData.name, this.wlsnXFwmlrm);
								if (11220 - 571998 == -560777)
								{
									continue;
								}
							}
							else
							{
								GUI.Label(new Rect((float)165, (float)140, (float)240, (float)40), this.fA1nOcbfK2o + " / " + songData.name, this.wlsnXFwmlrm);
								if (157439 - 53456 == 103984)
								{
									continue;
								}
							}
							GUI.Label(new Rect((float)360, (float)140, (float)180, (float)40), "[" + songData.album + "]", this.DpenXAJKMUf);
							if (225397 - 332819 != -107422)
							{
								continue;
							}
							GUI.Label(new Rect((float)218, (float)186, (float)80, (float)40), songData.time, this.cHanX9fd1lG);
							if (203148 - 511405 != -308257)
							{
								continue;
							}
							GUI.Label(new Rect((float)330, (float)186, (float)80, (float)40), string.Empty + songData.bpm, this.cHanX9fd1lG);
							if (264781 - 370600 == -105818)
							{
								continue;
							}
							GUI.Label(new Rect((float)449, (float)186, (float)80, (float)40), string.Empty + songData.score, this.cHanX9fd1lG);
							if (98460 - 91990 != 6470)
							{
								continue;
							}
							int i = 0;
							if (100805 - 102955 == -2149)
							{
								continue;
							}
							while (i < songData.difficulty)
							{
								GUI.DrawTexture(new Rect((float)(254 + i * 24), (float)243, (float)24, (float)24), this.vQsnXoiwB2g);
								if (276292 - 347662 != -71370)
								{
									goto IL_BA2;
								}
								i++;
								if (196942 - 237897 != -40955)
								{
									goto IL_BA2;
								}
							}
							if (328 - 521856 == -521527)
							{
								continue;
							}
							if (this.V54nXX9hCpj)
							{
								if (11987 - 123032 != -111045)
								{
									continue;
								}
								if (Time.time - this.uqonXNA0Utk < (float)6)
								{
									if (95203 - 334724 != -239521)
									{
										continue;
									}
									GUI.DrawTexture(new Rect((float)420, (float)234, (float)113, (float)46), this.PcLnXufQsAJ.active.background);
									if (239746 - 265038 == -25291)
									{
										continue;
									}
									GUI.Label(new Rect((float)535, (float)236, (float)40, (float)40), string.Empty + Mathf.FloorToInt((float)5 - Time.time - this.uqonXNA0Utk), this.cHanX9fd1lG);
									if (43780 - 160868 == -117087)
									{
										continue;
									}
								}
								else if (!this.HMTnXOdDYG5)
								{
									if (252843 - 45393 != 207450)
									{
										continue;
									}
									if (GUI.Button(new Rect((float)420, (float)234, (float)113, (float)46), string.Empty, this.PcLnXufQsAJ))
									{
										if (296885 - 131559 == 165327)
										{
											continue;
										}
										this.HMTnXOdDYG5 = true;
										if (43302 - 237681 != -194379)
										{
											continue;
										}
										this.StartDanceGame(this.fA1nOcbfK2o);
										if (72214 - 305153 == -232938)
										{
											continue;
										}
										if (this.SxonX6vPR8e)
										{
											if (218292 - 293442 != -75150)
											{
												continue;
											}
											this.audio.PlayOneShot(this.SxonX6vPR8e);
											if (257514 - 200567 == 56948)
											{
												continue;
											}
										}
									}
								}
							}
							else if (!this.HMTnXOdDYG5)
							{
								if (101341 - 287580 != -186239)
								{
									continue;
								}
								if (GUI.Button(new Rect((float)420, (float)234, (float)113, (float)46), string.Empty, this.A7anXy2TeiE))
								{
									if (132802 - 574860 != -442058)
									{
										continue;
									}
									this.HMTnXOdDYG5 = true;
									if (142773 - 339650 == -196876)
									{
										continue;
									}
									this.VoteDanceGame(this.fA1nOcbfK2o);
									if (271464 - 123338 == 148127)
									{
										continue;
									}
									if (this.SxonX6vPR8e)
									{
										if (138757 - 380539 != -241782)
										{
											continue;
										}
										this.audio.PlayOneShot(this.SxonX6vPR8e);
										if (167227 - 467342 == -300114)
										{
											continue;
										}
									}
								}
							}
						}
						int j = 0;
						if (223870 - 401537 == -177667)
						{
							while (j < 8)
							{
								int num = this.ry7nXzjArnd - j - this.fYTnO5UBHrn * 8;
								if (297775 - 24475 == 273301)
								{
									goto IL_BA2;
								}
								if (num > 0)
								{
									if (13574 - 85902 == -72327)
									{
										goto IL_BA2;
									}
									if (this.fwPnOngJrge != null)
									{
										if (135994 - 498433 != -362439)
										{
											goto IL_BA2;
										}
										if (Extensions.get_length(this.fwPnOngJrge) >= num)
										{
											if (33954 - 32787 != 1167)
											{
												goto IL_BA2;
											}
											if (this.fwPnOngJrge[num - 1] > 0)
											{
												if (124333 - 444748 != -320415)
												{
													goto IL_BA2;
												}
												GUI.DrawTexture(new Rect((float)110, (float)(288 + 47 * j), (float)71, (float)43), this.GlxnXkWgWpZ);
												if (101161 - 576384 == -475222)
												{
													goto IL_BA2;
												}
												GUI.Label(new Rect((float)150, (float)(294 + 47 * j), (float)30, (float)30), string.Empty + this.fwPnOngJrge[num - 1], this.cHanX9fd1lG);
												if (92066 - 300778 == -208711)
												{
													goto IL_BA2;
												}
											}
										}
									}
									SongEntry songData2 = SongData.getSongData(num);
									if (167116 - 150534 == 16583)
									{
										goto IL_BA2;
									}
									if (num < 10)
									{
										if (78930 - 47792 == 31139)
										{
											goto IL_BA2;
										}
										GUI.Label(new Rect((float)189, (float)(304 + 47 * j), (float)240, (float)40), "0" + num + " / " + songData2.name, this.ttAnXWGQ8L6);
										if (99844 - 456448 != -356604)
										{
											goto IL_BA2;
										}
									}
									else
									{
										GUI.Label(new Rect((float)189, (float)(304 + 47 * j), (float)240, (float)40), num + " / " + songData2.name, this.ttAnXWGQ8L6);
										if (161671 - 168036 != -6365)
										{
											goto IL_BA2;
										}
									}
									int k = 0;
									if (210610 - 356245 != -145635)
									{
										goto IL_BA2;
									}
									while (k < songData2.difficulty)
									{
										GUI.DrawTexture(new Rect((float)(500 - k * 21), (float)(314 + 48 * j), (float)19, (float)19), this.vQsnXoiwB2g);
										if (161096 - 581308 == -420211)
										{
											goto IL_BA2;
										}
										k++;
										if (127848 - 85141 != 42707)
										{
											goto IL_BA2;
										}
									}
									if (170554 - 122445 != 48109)
									{
										goto IL_BA2;
									}
									if (this.fA1nOcbfK2o == num)
									{
										if (45433 - 543441 != -498008)
										{
											goto IL_BA2;
										}
										GUI.DrawTexture(new Rect((float)154, (float)(301 + 48 * j), (float)395, (float)48), this.vicnXVTSRxA.hover.background);
										if (25739 - 63429 == -37689)
										{
											goto IL_BA2;
										}
									}
									else if (GUI.Button(new Rect((float)154, (float)(301 + 48 * j), (float)395, (float)48), string.Empty, this.vicnXVTSRxA))
									{
										if (18729 - 404354 == -385624)
										{
											goto IL_BA2;
										}
										this.fA1nOcbfK2o = num;
										if (245401 - 12192 == 233210)
										{
											goto IL_BA2;
										}
										if (this.CfQnXtfEy6s)
										{
											if (87145 - 518807 != -431662)
											{
												goto IL_BA2;
											}
											this.audio.PlayOneShot(this.CfQnXtfEy6s);
											if (265631 - 150225 == 115407)
											{
												goto IL_BA2;
											}
										}
									}
								}
								j++;
								if (177775 - 47488 == 130288)
								{
									goto IL_BA2;
								}
							}
							if (92383 - 159816 == -67433)
							{
								GUI.Label(new Rect((float)384, (float)723, (float)40, (float)40), string.Empty + (this.fYTnO5UBHrn + 1), this.wlsnXFwmlrm);
								if (139581 - 350829 != -211247)
								{
									if (GUI.Button(new Rect((float)198, (float)711, (float)104, (float)70), string.Empty, this.hSNnXhVeoL7))
									{
										if (286297 - 218217 == 68081)
										{
											continue;
										}
										this.fYTnO5UBHrn = Mathf.Clamp(this.fYTnO5UBHrn - 1, 0, Mathf.CeilToInt((float)this.ry7nXzjArnd / 8f) - 1);
										if (124896 - 550677 != -425781)
										{
											continue;
										}
										if (this.eHlnXJMLVYp)
										{
											if (37877 - 551607 == -513729)
											{
												continue;
											}
											this.audio.PlayOneShot(this.eHlnXJMLVYp);
											if (49263 - 373978 != -324715)
											{
												continue;
											}
										}
									}
									if (GUI.Button(new Rect((float)400, (float)711, (float)104, (float)70), string.Empty, this.PggnXKyrwYV))
									{
										if (237237 - 408997 != -171760)
										{
											continue;
										}
										this.fYTnO5UBHrn = Mathf.Clamp(this.fYTnO5UBHrn + 1, 0, Mathf.CeilToInt((float)this.ry7nXzjArnd / 8f) - 1);
										if (90323 - 31781 != 58542)
										{
											continue;
										}
										if (this.eHlnXJMLVYp)
										{
											if (96463 - 311420 != -214957)
											{
												continue;
											}
											this.audio.PlayOneShot(this.eHlnXJMLVYp);
											if (287662 - 80244 != 207418)
											{
												continue;
											}
										}
									}
									GUI.EndGroup();
									if (298890 - 482170 != -183279)
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

	// Token: 0x0600AA0B RID: 43531 RVA: 0x012F265C File Offset: 0x012F085C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitDanceWindow()
	{
		if (152241 - 320199 != -167957)
		{
		}
		for (;;)
		{
			IL_368:
			this.utInOQZVrr1 = (Texture)Resources.Load("GameGui/DanceAudition/headerBar", typeof(Texture));
			if (59679 - 598126 != -538446)
			{
				this.zJfnOeGmeEL = (Texture)Resources.Load("GameGui/DanceAudition/itemBar", typeof(Texture));
				if (297758 - 387747 == -89989)
				{
					this.dmSnOI9Nk1J = (Texture)Resources.Load("GameGui/DanceAudition/scoreBar", typeof(Texture));
					if (53057 - 227592 == -174535)
					{
						this.vwHnOJeIGFc = (Texture)Resources.Load("GameGui/DanceAudition/lifeStar", typeof(Texture));
						if (202936 - 424343 != -221406)
						{
							this.jUknO6OFxyw = (Texture)Resources.Load("GameGui/DanceAudition/rankPointer", typeof(Texture));
							if (117390 - 400290 != -282899)
							{
								this.VaNnOtM3sql = (Texture)Resources.Load("GameGui/DanceAudition/teamPointer", typeof(Texture));
								if (238066 - 481149 != -243082)
								{
									this.jRFnOXiAuJT = (Texture)Resources.Load("GameGui/DanceAudition/progressPointer", typeof(Texture));
									if (69931 - 459064 != -389132)
									{
										this.Tb8nOOLObl4 = (Texture)Resources.Load("GameGui/DanceAudition/rankBar", typeof(Texture));
										if (252631 - 321600 != -68968)
										{
											this.JnYnO2NdvKD = (Texture)Resources.Load("GameGui/DanceAudition/noteBar", typeof(Texture));
											if (43081 - 192935 == -149854)
											{
												this.fqjnOvQbgwb = (Texture)Resources.Load("GameGui/DanceAudition/noteBarBg", typeof(Texture));
												if (282550 - 483881 != -201330)
												{
													this.VQ5nOlC94Ad = (Texture)Resources.Load("GameGui/DanceAudition/note1", typeof(Texture));
													if (9433 - 60257 != -50823)
													{
														this.KdVnOGKEsQN = (Texture)Resources.Load("GameGui/DanceAudition/note2", typeof(Texture));
														if (212510 - 515209 != -302698)
														{
															this.R1WnO1atoAR = (Texture)Resources.Load("GameGui/DanceAudition/note3", typeof(Texture));
															if (135933 - 289525 != -153591)
															{
																this.sDBnOpoPRLL = (Texture)Resources.Load("GameGui/DanceAudition/beat", typeof(Texture));
																if (55471 - 387607 != -332135)
																{
																	this.PsVnORs1lrl = (Texture)Resources.Load("GameGui/DanceAudition/incorrect", typeof(Texture));
																	if (109217 - 515908 == -406691)
																	{
																		this.M7SnOrY02r5 = (Texture)Resources.Load("GameGui/DanceAudition/notefx1", typeof(Texture));
																		if (11833 - 451307 != -439473)
																		{
																			this.oMenOxlJtPK = (Texture)Resources.Load("GameGui/DanceAudition/notefx2", typeof(Texture));
																			if (44364 - 541479 == -497115)
																			{
																				this.UuQnOT8FhkE = (Texture)Resources.Load("GameGui/DanceAudition/notefx3", typeof(Texture));
																				if (95555 - 395187 != -299631)
																				{
																					this.WAvnOYkn9LN = (Texture)Resources.Load("GameGui/DanceAudition/notefx4", typeof(Texture));
																					if (249925 - 504809 != -254883)
																					{
																						this.LsWnO3wfiTX = (Texture)Resources.Load("GameGui/DanceAudition/notefx5", typeof(Texture));
																						if (189825 - 216527 == -26702)
																						{
																							this.gOsnOaNLm7U = (Texture)Resources.Load("GameGui/DanceAudition/item_score50", typeof(Texture));
																							if (9744 - 279540 == -269796)
																							{
																								this.A23nO4MbZTS = (Texture)Resources.Load("GameGui/DanceAudition/item_score100", typeof(Texture));
																								if (76061 - 483970 != -407908)
																								{
																									this.g6LnOsYLHs1 = (Texture)Resources.Load("GameGui/DanceAudition/item_score200", typeof(Texture));
																									if (102727 - 95171 == 7556)
																									{
																										this.UI5nOH3bLPW = (Texture)Resources.Load("GameGui/DanceAudition/item_combo10", typeof(Texture));
																										if (212690 - 401164 != -188473)
																										{
																											this.yljnO7Ubdfw = (Texture)Resources.Load("GameGui/DanceAudition/item_combo20", typeof(Texture));
																											if (17652 - 181154 != -163501)
																											{
																												this.EmXnOZZTVjS = (Texture)Resources.Load("GameGui/DanceAudition/item_combo30", typeof(Texture));
																												if (102454 - 512878 == -410424)
																												{
																													this.LdfnOCrphi8 = (Texture)Resources.Load("GameGui/DanceAudition/item_lifeUp", typeof(Texture));
																													if (260888 - 535382 == -274494)
																													{
																														this.YFknOMJl6hA = (Texture)Resources.Load("GameGui/DanceAudition/comboBar", typeof(Texture));
																														if (67570 - 58481 == 9089)
																														{
																															this.s5wnOfJtgSL = new Texture[10];
																															if (185262 - 525978 == -340716)
																															{
																																int i = 0;
																																if (236392 - 560314 != -323921)
																																{
																																	while (i < 10)
																																	{
																																		this.s5wnOfJtgSL[i] = (Texture)Resources.Load("GameGui/GameWindow/comboBar/" + i, typeof(Texture));
																																		if (265086 - 561734 == -296647)
																																		{
																																			goto IL_368;
																																		}
																																		i++;
																																		if (53989 - 235318 != -181329)
																																		{
																																			goto IL_368;
																																		}
																																	}
																																	if (248092 - 256549 == -8457)
																																	{
																																		this.RvKnOLBPQDX = new int[]
																																		{
																																			52,
																																			34,
																																			60,
																																			62,
																																			50,
																																			50,
																																			58,
																																			50,
																																			53,
																																			52
																																		};
																																		if (223044 - 470080 != -247035)
																																		{
																																			this.Bg9nOww4Osv = new GUIStyle();
																																			if (259540 - 459447 != -199906)
																																			{
																																				this.Bg9nOww4Osv.font = (Font)Resources.Load("GameGui/Fonts/GMO38", typeof(Font));
																																				if (268727 - 572858 == -304131)
																																				{
																																					this.Bg9nOww4Osv.normal.textColor = new Color(0.27f, 0.21f, 0.15f, (float)1);
																																					if (206468 - 503695 != -297226)
																																					{
																																						this.Bg9nOww4Osv.alignment = TextAnchor.MiddleRight;
																																						if (196614 - 248502 != -51887)
																																						{
																																							this.LqDnXLT1RgJ = GameObject.Find("TheaterCamera");
																																							if (99321 - 477027 == -377706)
																																							{
																																								this.LKxnXwyqIDk = GameObject.Find("TheaterCurtain");
																																								if (298856 - 383370 == -84514)
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
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AA0C RID: 43532 RVA: 0x012F2EF0 File Offset: 0x012F10F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetDanceGame()
	{
		if (14466 - 387245 != -372778)
		{
		}
		for (;;)
		{
			this.eFdnXRbZ8op = 0;
			if (272599 - 85610 == 186989)
			{
				this.E8CnXri0QJ7 = (float)0;
				if (276543 - 569407 != -292863)
				{
					this.IvynXx5sVhh = 0;
					if (155431 - 416806 == -261375)
					{
						this.gmKnXYyBFB6 = 0;
						if (26626 - 300519 == -273893)
						{
							this.CYYnX3Ndhlw = 3;
							if (194471 - 279263 == -84792)
							{
								this.pwenXbV454o = 10;
								if (254184 - 551618 != -297433)
								{
									this.Qf7nXd9fuDP = (float)0;
									if (117945 - 317542 == -199597)
									{
										this.wbJnXZdApuL = 0;
										if (75344 - 33487 == 41857)
										{
											this.U0PnXCvB2jx = "0";
											if (10050 - 38049 != -27998)
											{
												this.KuJnXMS7NkV = "0";
												if (298817 - 250735 != 48083)
												{
													this.C0UnXfr8Ybm = "0";
													if (204183 - 443175 == -238992)
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

	// Token: 0x0600AA0D RID: 43533 RVA: 0x012F30A4 File Offset: 0x012F12A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void StartDanceGame(int nTrack)
	{
		Game.sendMissionEvent(9611, nTrack);
	}

	// Token: 0x0600AA0E RID: 43534 RVA: 0x012F30B4 File Offset: 0x012F12B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void VoteDanceGame(int nTrack)
	{
		Game.sendMissionEvent(9611, -1 * nTrack);
	}

	// Token: 0x0600AA0F RID: 43535 RVA: 0x012F30C4 File Offset: 0x012F12C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator onStartDanceGame(int nTrack)
	{
		return new M961_DanceAudition.$onStartDanceGame$44662(nTrack, this).GetEnumerator();
	}

	// Token: 0x0600AA10 RID: 43536 RVA: 0x012F30D4 File Offset: 0x012F12D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	private AudioClip getAudio(int nTrack)
	{
		if (220753 - 525479 != -304726)
		{
		}
		AudioClip result;
		for (;;)
		{
			result = null;
			if (42493 - 363951 != -321457)
			{
				if (220435 - 335691 == -115256)
				{
					if (nTrack == 1)
					{
						if (82095 - 106300 != -24204)
						{
							result = this.song_sillyCreature;
							if (142491 - 186719 != -44227)
							{
								break;
							}
						}
					}
					else if (nTrack == 2)
					{
						if (153954 - 161780 == -7826)
						{
							result = this.song_city;
							if (148591 - 9332 != 139260)
							{
								break;
							}
						}
					}
					else if (nTrack == 3)
					{
						if (268180 - 584040 != -315859)
						{
							result = this.song_oneday;
							if (131482 - 195190 != -63707)
							{
								break;
							}
						}
					}
					else if (nTrack == 4)
					{
						if (244930 - 122453 != 122478)
						{
							result = this.song_arcadeLevel;
							if (273815 - 127520 != 146296)
							{
								break;
							}
						}
					}
					else if (nTrack == 5)
					{
						if (84431 - 372178 == -287747)
						{
							result = this.song_horseBack;
							if (88079 - 228059 == -139980)
							{
								break;
							}
						}
					}
					else if (nTrack == 6)
					{
						if (263877 - 533843 == -269966)
						{
							result = this.song_plain;
							if (202058 - 99687 == 102371)
							{
								break;
							}
						}
					}
					else if (nTrack == 7)
					{
						if (245667 - 74476 == 171191)
						{
							result = this.song_danceWithPeppers;
							if (361 - 465158 != -464796)
							{
								break;
							}
						}
					}
					else if (nTrack == 8)
					{
						if (34081 - 251493 == -217412)
						{
							result = this.song_funnyLevel;
							if (231479 - 268072 != -36592)
							{
								break;
							}
						}
					}
					else if (nTrack == 9)
					{
						if (123783 - 353505 != -229721)
						{
							result = this.song_bug;
							if (283921 - 367522 == -83601)
							{
								break;
							}
						}
					}
					else if (nTrack == 10)
					{
						if (24054 - 515051 == -490997)
						{
							result = this.song_rockNRoll;
							if (140849 - 212665 != -71815)
							{
								break;
							}
						}
					}
					else if (nTrack == 11)
					{
						if (190435 - 196353 == -5918)
						{
							result = this.song_control;
							if (244753 - 286045 == -41292)
							{
								break;
							}
						}
					}
					else if (nTrack == 12)
					{
						if (280668 - 535011 != -254342)
						{
							result = this.song_childishHero;
							if (215443 - 222574 == -7131)
							{
								break;
							}
						}
					}
					else if (nTrack == 13)
					{
						if (3786 - 279002 == -275216)
						{
							result = this.song_water2;
							if (251149 - 31588 == 219561)
							{
								break;
							}
						}
					}
					else if (nTrack == 14)
					{
						if (268720 - 416528 != -147807)
						{
							result = this.song_jump;
							if (3096 - 340483 != -337386)
							{
								break;
							}
						}
					}
					else if (nTrack == 15)
					{
						if (121831 - 164266 == -42435)
						{
							result = this.song_fire;
							if (298474 - 103228 == 195246)
							{
								break;
							}
						}
					}
					else if (nTrack == 16)
					{
						if (129457 - 10649 == 118808)
						{
							result = this.song_phoenix;
							if (94998 - 590944 != -495945)
							{
								break;
							}
						}
					}
					else if (nTrack == 17)
					{
						if (154238 - 205183 == -50945)
						{
							result = this.song_battle4;
							if (168839 - 594249 == -425410)
							{
								break;
							}
						}
					}
					else if (nTrack == 18)
					{
						if (233966 - 481422 == -247456)
						{
							result = this.song_anthem;
							if (187806 - 195482 != -7675)
							{
								break;
							}
						}
					}
					else if (nTrack == 19)
					{
						if (245141 - 242527 == 2614)
						{
							result = this.song_ice;
							if (181220 - 477623 != -296402)
							{
								break;
							}
						}
					}
					else if (nTrack == 20)
					{
						if (134954 - 470604 != -335649)
						{
							result = this.song_salamander;
							if (131690 - 175814 != -44123)
							{
								break;
							}
						}
					}
					else if (nTrack == 21)
					{
						if (226835 - 413577 == -186742)
						{
							result = this.song_battle3;
							if (103232 - 39809 == 63423)
							{
								break;
							}
						}
					}
					else
					{
						if (nTrack != 22)
						{
							break;
						}
						if (72070 - 522189 != -450118)
						{
							result = this.song_powerSurge;
							if (296226 - 149766 != 146461)
							{
								break;
							}
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x0600AA11 RID: 43537 RVA: 0x012F3770 File Offset: 0x012F1970
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator startSong(float nStartTime)
	{
		return new M961_DanceAudition.$startSong$44670(nStartTime, this).GetEnumerator();
	}

	// Token: 0x0600AA12 RID: 43538 RVA: 0x012F3780 File Offset: 0x012F1980
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderDanceWindow()
	{
		if (139191 - 388997 != -249806)
		{
		}
		for (;;)
		{
			IL_314D:
			GUI.DrawTexture(new Rect(0.5f * (this.jptnXmPBAUG - (float)568), (float)0, (float)568, (float)80), this.utInOQZVrr1);
			if (107236 - 61027 != 46210)
			{
				GUI.DrawTexture(new Rect(0.5f * (this.jptnXmPBAUG - (float)132), (float)80, (float)132, (float)132), this.zJfnOeGmeEL);
				if (117738 - 110769 != 6970)
				{
					if (this.fflnXg7WDRh != 0)
					{
						if (161973 - 106793 == 55181)
						{
							continue;
						}
						int num = this.fflnXg7WDRh;
						if (136037 - 156495 == -20457)
						{
							continue;
						}
						if (Time.time - this.VwPnXau8cB1 < 1.5f)
						{
							if (277073 - 128128 != 148945)
							{
								continue;
							}
							num = (int)((float)10 * (Time.time - this.VwPnXau8cB1) % (float)7 + (float)1);
							if (92834 - 523333 == -430498)
							{
								continue;
							}
						}
						else if (Time.time - this.VwPnXau8cB1 < 6f)
						{
							if (135712 - 590985 != -455273)
							{
								continue;
							}
							if (this.fflnXg7WDRh == -1)
							{
								if (1348 - 11414 == -10065)
								{
									continue;
								}
								this.fflnXg7WDRh = UnityEngine.Random.Range(1, 8);
								if (220401 - 334941 != -114540)
								{
									continue;
								}
								Game.sendMissionEvent(9615, this.fflnXg7WDRh);
								if (9317 - 92893 == -83575)
								{
									continue;
								}
							}
						}
						else
						{
							this.fflnXg7WDRh = 0;
							if (86688 - 498783 != -412095)
							{
								continue;
							}
						}
						int num2 = num;
						if (286482 - 279850 != 6632)
						{
							continue;
						}
						if (num2 == 1)
						{
							if (212920 - 579150 == -366229)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)43, (float)112, (float)86, (float)69), this.gOsnOaNLm7U);
							if (253717 - 535063 != -281346)
							{
								continue;
							}
						}
						else if (num2 == 2)
						{
							if (58192 - 533890 != -475698)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)43, (float)112, (float)86, (float)69), this.A23nO4MbZTS);
							if (137867 - 17506 == 120362)
							{
								continue;
							}
						}
						else if (num2 == 3)
						{
							if (261026 - 318338 != -57312)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)43, (float)112, (float)86, (float)69), this.g6LnOsYLHs1);
							if (211252 - 364369 == -153116)
							{
								continue;
							}
						}
						else if (num2 == 4)
						{
							if (58296 - 376369 != -318073)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)43, (float)112, (float)86, (float)69), this.UI5nOH3bLPW);
							if (220461 - 274370 != -53909)
							{
								continue;
							}
						}
						else if (num2 == 5)
						{
							if (248605 - 256976 == -8370)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)43, (float)112, (float)86, (float)69), this.yljnO7Ubdfw);
							if (49394 - 511469 != -462075)
							{
								continue;
							}
						}
						else if (num2 == 6)
						{
							if (83543 - 224759 != -141216)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)43, (float)112, (float)86, (float)69), this.EmXnOZZTVjS);
							if (25601 - 266 == 25336)
							{
								continue;
							}
						}
						else if (num2 == 7)
						{
							if (71104 - 558306 == -487201)
							{
								continue;
							}
							GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)43, (float)112, (float)86, (float)69), this.LdfnOCrphi8);
							if (250497 - 336486 == -85988)
							{
								continue;
							}
						}
					}
					GUI.DrawTexture(new Rect((float)60, (float)10, (float)148, (float)60), this.dmSnOI9Nk1J);
					if (121467 - 442599 == -321132)
					{
						GUI.DrawTexture(new Rect((float)0, (float)740, (float)512, (float)284), this.fqjnOvQbgwb);
						if (158067 - 509452 == -351385)
						{
							GUI.DrawTexture(new Rect(this.jptnXmPBAUG - (float)512, (float)740, (float)512, (float)284), this.fqjnOvQbgwb);
							if (101780 - 459129 == -357349)
							{
								GUI.DrawTexture(new Rect(0.5f * (this.jptnXmPBAUG - (float)1440), (float)636, (float)1440, (float)388), this.JnYnO2NdvKD);
								if (191475 - 89467 == 102008)
								{
									Guix.renderGoldenNumber(220, 12, this.eFdnXRbZ8op, true);
									if (22302 - 346034 == -323732)
									{
										Guix.renderGoldenNumber(220, 46, this.gmKnXYyBFB6, true);
										if (292630 - 400558 == -107928)
										{
											int i = 0;
											if (136487 - 142021 != -5533)
											{
												while (i < this.CYYnX3Ndhlw)
												{
													GUI.DrawTexture(new Rect(this.jptnXmPBAUG - (float)120 - (float)(64 * i), (float)12, (float)48, (float)48), this.vwHnOJeIGFc);
													if (214470 - 7556 != 206914)
													{
														goto IL_314D;
													}
													i++;
													if (254672 - 264987 != -10315)
													{
														goto IL_314D;
													}
												}
												if (53703 - 237308 == -183605)
												{
													int totalTeamScore = this.getTotalTeamScore();
													if (105790 - 549257 != -443466)
													{
														int teamRank = this.getTeamRank();
														if (247075 - 431707 == -184632)
														{
															this.zAjnONoasUx = Mathf.SmoothStep(this.zAjnONoasUx, (float)(teamRank / 12), (float)5 * Time.deltaTime);
															if (188868 - 450939 == -262071)
															{
																GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)25 + this.zAjnONoasUx * (float)2, (float)654 - Mathf.Abs(0.1f * this.zAjnONoasUx), (float)51, (float)70), this.VaNnOtM3sql);
																if (204715 - 209670 == -4955)
																{
																	this.hinnOUWpDpN = Mathf.SmoothStep(this.hinnOUWpDpN, this.E8CnXri0QJ7, (float)5 * Time.deltaTime);
																	if (97001 - 287697 == -190696)
																	{
																		GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)25 + this.hinnOUWpDpN * (float)2, (float)654 - Mathf.Abs(0.1f * this.hinnOUWpDpN), (float)51, (float)70), this.jUknO6OFxyw);
																		if (32616 - 287725 == -255109)
																		{
																			if (totalTeamScore > 0)
																			{
																				if (22717 - 378692 == -355974)
																				{
																					continue;
																				}
																				if (this.TqxnX1JBOfP > 0)
																				{
																					if (145237 - 294767 != -149530)
																					{
																						continue;
																					}
																					GUI.BeginGroup(new Rect(0.5f * this.jptnXmPBAUG - (float)239, (float)729, 505f * (float)totalTeamScore / (float)this.TqxnX1JBOfP, (float)27));
																					if (123779 - 261030 == -137250)
																					{
																						continue;
																					}
																					GUI.DrawTexture(new Rect((float)0, (float)0, (float)505, (float)27), this.Tb8nOOLObl4);
																					if (194456 - 478264 == -283807)
																					{
																						continue;
																					}
																					GUI.EndGroup();
																					if (40814 - 589373 == -548558)
																					{
																						continue;
																					}
																				}
																			}
																			if (this.AkbnObkqqJH > Time.time)
																			{
																				if (278623 - 261509 == 17115)
																				{
																					continue;
																				}
																				int num3 = Mathf.FloorToInt((float)10 * (this.AkbnObkqqJH - Time.time));
																				if (150972 - 297305 == -146332)
																				{
																					continue;
																				}
																				if (num3 == 4)
																				{
																					if (150338 - 380252 != -229914)
																					{
																						continue;
																					}
																					GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)389, (float)786, (float)77, (float)77), this.M7SnOrY02r5);
																					if (91240 - 307751 == -216510)
																					{
																						continue;
																					}
																				}
																				else if (num3 == 3)
																				{
																					if (142597 - 546366 != -403769)
																					{
																						continue;
																					}
																					GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)389, (float)786, (float)77, (float)77), this.oMenOxlJtPK);
																					if (148092 - 264308 == -116215)
																					{
																						continue;
																					}
																				}
																				else if (num3 == 2)
																				{
																					if (269383 - 229653 == 39731)
																					{
																						continue;
																					}
																					GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)389, (float)786, (float)77, (float)77), this.UuQnOT8FhkE);
																					if (195894 - 444731 == -248836)
																					{
																						continue;
																					}
																				}
																				else if (num3 == 1)
																				{
																					if (260189 - 130414 == 129776)
																					{
																						continue;
																					}
																					GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)389, (float)786, (float)77, (float)77), this.WAvnOYkn9LN);
																					if (11694 - 559933 != -548239)
																					{
																						continue;
																					}
																				}
																				else if (num3 == 0)
																				{
																					if (136367 - 394421 != -258054)
																					{
																						continue;
																					}
																					GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)389, (float)786, (float)77, (float)77), this.LsWnO3wfiTX);
																					if (223326 - 88933 == 134394)
																					{
																						continue;
																					}
																				}
																			}
																			if (this.AeanOdeNLEt > Time.time)
																			{
																				if (248606 - 582237 != -333631)
																				{
																					continue;
																				}
																				int num4 = Mathf.FloorToInt((float)10 * (this.AeanOdeNLEt - Time.time));
																				if (93301 - 444447 == -351145)
																				{
																					continue;
																				}
																				if (num4 == 4)
																				{
																					if (238476 - 250761 == -12284)
																					{
																						continue;
																					}
																					GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)389, (float)834, (float)77, (float)77), this.M7SnOrY02r5);
																					if (79239 - 278985 != -199746)
																					{
																						continue;
																					}
																				}
																				else if (num4 == 3)
																				{
																					if (59533 - 304535 != -245002)
																					{
																						continue;
																					}
																					GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)389, (float)834, (float)77, (float)77), this.oMenOxlJtPK);
																					if (17904 - 204226 != -186322)
																					{
																						continue;
																					}
																				}
																				else if (num4 == 2)
																				{
																					if (212400 - 303299 != -90899)
																					{
																						continue;
																					}
																					GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)389, (float)834, (float)77, (float)77), this.UuQnOT8FhkE);
																					if (178736 - 503967 != -325231)
																					{
																						continue;
																					}
																				}
																				else if (num4 == 1)
																				{
																					if (59914 - 314371 == -254456)
																					{
																						continue;
																					}
																					GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)389, (float)834, (float)77, (float)77), this.WAvnOYkn9LN);
																					if (246688 - 533011 == -286322)
																					{
																						continue;
																					}
																				}
																				else if (num4 == 0)
																				{
																					if (166970 - 180687 == -13716)
																					{
																						continue;
																					}
																					GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)389, (float)834, (float)77, (float)77), this.LsWnO3wfiTX);
																					if (94445 - 9855 != 84590)
																					{
																						continue;
																					}
																				}
																			}
																			if (this.VcqnOg5bHX4 > Time.time)
																			{
																				if (146239 - 342965 != -196726)
																				{
																					continue;
																				}
																				int num5 = Mathf.FloorToInt((float)10 * (this.VcqnOg5bHX4 - Time.time));
																				if (207222 - 371191 == -163968)
																				{
																					continue;
																				}
																				if (num5 == 4)
																				{
																					if (195443 - 424035 != -228592)
																					{
																						continue;
																					}
																					GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)389, (float)884, (float)77, (float)77), this.M7SnOrY02r5);
																					if (268905 - 281828 == -12922)
																					{
																						continue;
																					}
																				}
																				else if (num5 == 3)
																				{
																					if (153636 - 519255 != -365619)
																					{
																						continue;
																					}
																					GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)389, (float)884, (float)77, (float)77), this.oMenOxlJtPK);
																					if (99310 - 10067 == 89244)
																					{
																						continue;
																					}
																				}
																				else if (num5 == 2)
																				{
																					if (99181 - 579443 != -480262)
																					{
																						continue;
																					}
																					GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)389, (float)884, (float)77, (float)77), this.UuQnOT8FhkE);
																					if (209756 - 570194 != -360438)
																					{
																						continue;
																					}
																				}
																				else if (num5 == 1)
																				{
																					if (146175 - 77201 != 68974)
																					{
																						continue;
																					}
																					GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)389, (float)884, (float)77, (float)77), this.WAvnOYkn9LN);
																					if (147286 - 534368 != -387082)
																					{
																						continue;
																					}
																				}
																				else if (num5 == 0)
																				{
																					if (153589 - 318161 == -164571)
																					{
																						continue;
																					}
																					GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)389, (float)884, (float)77, (float)77), this.LsWnO3wfiTX);
																					if (262724 - 533979 != -271255)
																					{
																						continue;
																					}
																				}
																			}
																			GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)410 + (float)980 / this.OA1nXGWAQiS * (Time.time - this.uqonXNA0Utk), (float)950, (float)20, (float)33), this.jRFnOXiAuJT);
																			if (148685 - 56498 == 92187)
																			{
																				float num6 = Time.time - this.uqonXNA0Utk;
																				if (7077 - 299074 != -291996)
																				{
																					int j = 0;
																					if (248422 - 311273 == -62851)
																					{
																						while (j < 12)
																						{
																							int num7 = j - 12 + Mathf.FloorToInt(num6 / (0.001f * this.BiXnXlcf0sd));
																							if (109782 - 249748 == -139965)
																							{
																								goto IL_314D;
																							}
																							if (num7 >= 0)
																							{
																								if (106429 - 274409 != -167980)
																								{
																									goto IL_314D;
																								}
																								if (num7 < this.UgdnXvClMia.length)
																								{
																									if (173150 - 165122 == 8029)
																									{
																										goto IL_314D;
																									}
																									string text = string.Empty + this.UgdnXvClMia[num7];
																									if (294230 - 230298 != 63932)
																									{
																										goto IL_314D;
																									}
																									if (j != 0)
																									{
																										goto IL_3234;
																									}
																									if (57475 - 205839 != -148364)
																									{
																										goto IL_314D;
																									}
																									if (this.wbJnXZdApuL != num7)
																									{
																										goto IL_3234;
																									}
																									if (80292 - 96841 == -16548)
																									{
																										goto IL_314D;
																									}
																									this.wbJnXZdApuL++;
																									if (132982 - 51309 != 81673)
																									{
																										goto IL_314D;
																									}
																									if (this.U0PnXCvB2jx != "0")
																									{
																										if (232519 - 235472 != -2953)
																										{
																											goto IL_314D;
																										}
																										if (this.CYYnX3Ndhlw > 0)
																										{
																											if (129600 - 592211 == -462610)
																											{
																												goto IL_314D;
																											}
																											if (this.Qf7nXd9fuDP < Time.time)
																											{
																												if (221002 - 258548 == -37545)
																												{
																													goto IL_314D;
																												}
																												this.pwenXbV454o--;
																												if (55725 - 85005 != -29280)
																												{
																													goto IL_314D;
																												}
																												if (this.E8CnXri0QJ7 > (float)0)
																												{
																													if (78737 - 14677 != 64060)
																													{
																														goto IL_314D;
																													}
																													this.E8CnXri0QJ7 = (float)0;
																													if (131685 - 414349 == -282663)
																													{
																														goto IL_314D;
																													}
																												}
																												else
																												{
																													this.E8CnXri0QJ7 -= (float)10;
																													if (107371 - 494946 != -387575)
																													{
																														goto IL_314D;
																													}
																												}
																												this.IvynXx5sVhh = 0;
																												if (89801 - 550839 == -461037)
																												{
																													goto IL_314D;
																												}
																											}
																										}
																									}
																									if (this.KuJnXMS7NkV != "0")
																									{
																										if (181516 - 520243 == -338726)
																										{
																											goto IL_314D;
																										}
																										if (this.CYYnX3Ndhlw > 0)
																										{
																											if (66732 - 311163 == -244430)
																											{
																												goto IL_314D;
																											}
																											if (this.Qf7nXd9fuDP < Time.time)
																											{
																												if (280488 - 209753 != 70735)
																												{
																													goto IL_314D;
																												}
																												this.pwenXbV454o--;
																												if (251897 - 576228 != -324331)
																												{
																													goto IL_314D;
																												}
																												if (this.E8CnXri0QJ7 > (float)0)
																												{
																													if (175416 - 518909 == -343492)
																													{
																														goto IL_314D;
																													}
																													this.E8CnXri0QJ7 = (float)0;
																													if (48691 - 149986 != -101295)
																													{
																														goto IL_314D;
																													}
																												}
																												else
																												{
																													this.E8CnXri0QJ7 -= (float)10;
																													if (34817 - 195529 != -160712)
																													{
																														goto IL_314D;
																													}
																												}
																												this.IvynXx5sVhh = 0;
																												if (139953 - 513699 != -373746)
																												{
																													goto IL_314D;
																												}
																											}
																										}
																									}
																									if (this.C0UnXfr8Ybm != "0")
																									{
																										if (254158 - 463998 != -209840)
																										{
																											goto IL_314D;
																										}
																										if (this.CYYnX3Ndhlw > 0)
																										{
																											if (184091 - 172243 == 11849)
																											{
																												goto IL_314D;
																											}
																											if (this.Qf7nXd9fuDP < Time.time)
																											{
																												if (89230 - 250247 == -161016)
																												{
																													goto IL_314D;
																												}
																												this.pwenXbV454o--;
																												if (256757 - 418875 != -162118)
																												{
																													goto IL_314D;
																												}
																												if (this.E8CnXri0QJ7 > (float)0)
																												{
																													if (176986 - 316068 != -139082)
																													{
																														goto IL_314D;
																													}
																													this.E8CnXri0QJ7 = (float)0;
																													if (273714 - 159812 != 113902)
																													{
																														goto IL_314D;
																													}
																												}
																												else
																												{
																													this.E8CnXri0QJ7 -= (float)10;
																													if (34118 - 286947 == -252828)
																													{
																														goto IL_314D;
																													}
																												}
																												this.IvynXx5sVhh = 0;
																												if (180482 - 256699 == -76216)
																												{
																													goto IL_314D;
																												}
																											}
																										}
																									}
																									this.U0PnXCvB2jx = string.Empty + text[1];
																									if (297201 - 299188 == -1986)
																									{
																										goto IL_314D;
																									}
																									this.KuJnXMS7NkV = string.Empty + text[2];
																									if (297510 - 536994 == -239483)
																									{
																										goto IL_314D;
																									}
																									this.C0UnXfr8Ybm = string.Empty + text[3];
																									if (151854 - 291738 != -139884)
																									{
																										goto IL_314D;
																									}
																									IL_1DD8:
																									int k = 1;
																									if (5237 - 106974 != -101737)
																									{
																										goto IL_314D;
																									}
																									while (k < 4)
																									{
																										if (Extensions.get_length(text) > k)
																										{
																											if (109324 - 358563 == -249238)
																											{
																												goto IL_314D;
																											}
																											char lhs = text[k];
																											if (233517 - 471988 != -238471)
																											{
																												goto IL_314D;
																											}
																											if (lhs == "1")
																											{
																												if (222148 - 223348 != -1200)
																												{
																													goto IL_314D;
																												}
																												if (k == 1)
																												{
																													if (134863 - 168510 != -33647)
																													{
																														goto IL_314D;
																													}
																													GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)330 + (float)Mathf.FloorToInt((float)75 * ((float)j - num6 / (0.001f * this.BiXnXlcf0sd) % 1f)), (float)802, (float)47, (float)47), this.VQ5nOlC94Ad);
																													if (291653 - 78510 == 213144)
																													{
																														goto IL_314D;
																													}
																												}
																												else if (k == 2)
																												{
																													if (265936 - 73652 == 192285)
																													{
																														goto IL_314D;
																													}
																													GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)330 + (float)Mathf.FloorToInt((float)75 * ((float)j - num6 / (0.001f * this.BiXnXlcf0sd) % 1f)), (float)849, (float)47, (float)47), this.KdVnOGKEsQN);
																													if (191475 - 123373 != 68102)
																													{
																														goto IL_314D;
																													}
																												}
																												else
																												{
																													GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)330 + (float)Mathf.FloorToInt((float)75 * ((float)j - num6 / (0.001f * this.BiXnXlcf0sd) % 1f)), (float)898, (float)47, (float)47), this.R1WnO1atoAR);
																													if (161228 - 35953 == 125276)
																													{
																														goto IL_314D;
																													}
																												}
																											}
																										}
																										k++;
																										if (79398 - 254924 == -175525)
																										{
																											goto IL_314D;
																										}
																									}
																									if (263825 - 386973 != -123148)
																									{
																										goto IL_314D;
																									}
																									goto IL_D0B;
																									IL_3234:
																									if (j != 0)
																									{
																										goto IL_1DD8;
																									}
																									if (169432 - 432965 == -263532)
																									{
																										goto IL_314D;
																									}
																									text = "9" + this.U0PnXCvB2jx + this.KuJnXMS7NkV + this.C0UnXfr8Ybm;
																									if (295873 - 476346 != -180472)
																									{
																										goto IL_1DD8;
																									}
																									goto IL_314D;
																								}
																							}
																							IL_D0B:
																							j++;
																							if (159516 - 236527 != -77011)
																							{
																								goto IL_314D;
																							}
																						}
																						if (234122 - 434297 != -200174)
																						{
																							GUI.Label(new Rect(0.5f * this.jptnXmPBAUG - (float)720, (float)910, (float)180, (float)40), string.Empty + this.wbJnXZdApuL, this.Bg9nOww4Osv);
																							if (132932 - 563239 == -430307)
																							{
																								if (this.CYYnX3Ndhlw > 0)
																								{
																									if (203176 - 376072 == -172895)
																									{
																										continue;
																									}
																									if (this.Qf7nXd9fuDP < Time.time)
																									{
																										if (222929 - 54811 != 168118)
																										{
																											continue;
																										}
																										if (this.U0PnXCvB2jx == "1")
																										{
																											goto IL_8E3;
																										}
																										if (114404 - 5339 == 109066)
																										{
																											continue;
																										}
																										if (this.KuJnXMS7NkV == "1")
																										{
																											goto IL_8E3;
																										}
																										if (183318 - 591833 == -408514)
																										{
																											continue;
																										}
																										if (this.C0UnXfr8Ybm == "1")
																										{
																											if (89534 - 388587 != -299053)
																											{
																												continue;
																											}
																											goto IL_8E3;
																										}
																										IL_CE5:
																										if (Input.GetKey(KeyCode.A))
																										{
																											if (241098 - 5416 == 235683)
																											{
																												continue;
																											}
																											if (!Chat.ChatActive)
																											{
																												if (126484 - 152065 == -25580)
																												{
																													continue;
																												}
																												GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)375, (float)802, (float)47, (float)47), this.VQ5nOlC94Ad);
																												if (86390 - 200996 == -114605)
																												{
																													continue;
																												}
																												if (this.U0PnXCvB2jx == "9")
																												{
																													if (241660 - 167553 == 74108)
																													{
																														continue;
																													}
																													GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)375, (float)800, (float)52, (float)52), this.PsVnORs1lrl);
																													if (189444 - 499635 == -310190)
																													{
																														continue;
																													}
																												}
																												if (Event.current.type == EventType.KeyDown)
																												{
																													if (262553 - 14564 == 247990)
																													{
																														continue;
																													}
																													if (Event.current.keyCode == KeyCode.A)
																													{
																														if (13436 - 431189 != -417753)
																														{
																															continue;
																														}
																														if (this.U0PnXCvB2jx == "1")
																														{
																															if (38211 - 343483 == -305271)
																															{
																																continue;
																															}
																															this.eFdnXRbZ8op += Mathf.Clamp(10 + Mathf.FloorToInt((float)this.IvynXx5sVhh * 0.1f), 0, 20);
																															if (263158 - 67918 != 195240)
																															{
																																continue;
																															}
																															this.E8CnXri0QJ7 += 0.01f * this.BiXnXlcf0sd;
																															if (186294 - 817 != 185477)
																															{
																																continue;
																															}
																															this.IvynXx5sVhh++;
																															if (81128 - 73985 != 7143)
																															{
																																continue;
																															}
																															this.rASnXTryG5d = Time.time;
																															if (41224 - 420053 != -378829)
																															{
																																continue;
																															}
																															this.U0PnXCvB2jx = "0";
																															if (40645 - 253795 == -213149)
																															{
																																continue;
																															}
																															this.AkbnObkqqJH = Time.time + 0.5f;
																															if (91828 - 50264 == 41565)
																															{
																																continue;
																															}
																															this.audio.PlayOneShot(this.rightFx);
																															if (215622 - 57928 == 157695)
																															{
																																continue;
																															}
																															if (this.IvynXx5sVhh % 50 == 0)
																															{
																																if (248752 - 358449 != -109697)
																																{
																																	continue;
																																}
																																this.fflnXg7WDRh = -1;
																																if (228794 - 115247 == 113548)
																																{
																																	continue;
																																}
																																this.VwPnXau8cB1 = Time.time;
																																if (182316 - 449443 == -267126)
																																{
																																	continue;
																																}
																																if (this.scoreFx)
																																{
																																	if (77673 - 161499 != -83826)
																																	{
																																		continue;
																																	}
																																	this.audio.PlayOneShot(this.scoreFx);
																																	if (35704 - 68523 != -32819)
																																	{
																																		continue;
																																	}
																																}
																																if (this.LqDnXLT1RgJ)
																																{
																																	if (179931 - 137302 == 42630)
																																	{
																																		continue;
																																	}
																																	this.LqDnXLT1RgJ.animation.Play("panMiddle");
																																	if (87622 - 314265 != -226643)
																																	{
																																		continue;
																																	}
																																}
																															}
																														}
																														else
																														{
																															this.U0PnXCvB2jx = "9";
																															if (192031 - 458523 == -266491)
																															{
																																continue;
																															}
																															this.AkbnObkqqJH = Time.time + 0.5f;
																															if (107966 - 38905 != 69061)
																															{
																																continue;
																															}
																															this.audio.PlayOneShot(this.wrongFx);
																															if (179840 - 470571 != -290731)
																															{
																																continue;
																															}
																														}
																													}
																												}
																											}
																										}
																										if (Input.GetKey(KeyCode.S))
																										{
																											if (269717 - 472705 == -202987)
																											{
																												continue;
																											}
																											if (!Chat.ChatActive)
																											{
																												if (194554 - 10249 == 184306)
																												{
																													continue;
																												}
																												GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)375, (float)849, (float)47, (float)47), this.KdVnOGKEsQN);
																												if (232228 - 172948 == 59281)
																												{
																													continue;
																												}
																												if (this.KuJnXMS7NkV == "9")
																												{
																													if (207057 - 110701 != 96356)
																													{
																														continue;
																													}
																													GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)375, (float)848, (float)52, (float)52), this.PsVnORs1lrl);
																													if (29211 - 99282 == -70070)
																													{
																														continue;
																													}
																												}
																												if (Event.current.type == EventType.KeyDown)
																												{
																													if (263455 - 345264 != -81809)
																													{
																														continue;
																													}
																													if (Event.current.keyCode == KeyCode.S)
																													{
																														if (217805 - 523714 == -305908)
																														{
																															continue;
																														}
																														if (this.KuJnXMS7NkV == "1")
																														{
																															if (211501 - 560162 != -348661)
																															{
																																continue;
																															}
																															this.eFdnXRbZ8op += Mathf.Clamp(10 + Mathf.FloorToInt((float)this.IvynXx5sVhh * 0.1f), 0, 20);
																															if (25865 - 290075 != -264210)
																															{
																																continue;
																															}
																															this.E8CnXri0QJ7 += 0.01f * this.BiXnXlcf0sd;
																															if (30179 - 369375 != -339196)
																															{
																																continue;
																															}
																															this.IvynXx5sVhh++;
																															if (145564 - 231327 != -85763)
																															{
																																continue;
																															}
																															this.rASnXTryG5d = Time.time;
																															if (236464 - 30313 == 206152)
																															{
																																continue;
																															}
																															this.KuJnXMS7NkV = "0";
																															if (22934 - 356650 != -333716)
																															{
																																continue;
																															}
																															this.AeanOdeNLEt = Time.time + 0.5f;
																															if (24941 - 353990 != -329049)
																															{
																																continue;
																															}
																															this.audio.PlayOneShot(this.rightFx);
																															if (267370 - 418637 == -151266)
																															{
																																continue;
																															}
																															if (this.IvynXx5sVhh % 50 == 0)
																															{
																																if (121966 - 419669 == -297702)
																																{
																																	continue;
																																}
																																this.fflnXg7WDRh = -1;
																																if (54796 - 508612 != -453816)
																																{
																																	continue;
																																}
																																this.VwPnXau8cB1 = Time.time;
																																if (200594 - 354991 == -154396)
																																{
																																	continue;
																																}
																																if (this.scoreFx)
																																{
																																	if (249597 - 62002 == 187596)
																																	{
																																		continue;
																																	}
																																	this.audio.PlayOneShot(this.scoreFx);
																																	if (48257 - 54214 == -5956)
																																	{
																																		continue;
																																	}
																																}
																																if (this.LqDnXLT1RgJ)
																																{
																																	if (115228 - 86024 != 29204)
																																	{
																																		continue;
																																	}
																																	this.LqDnXLT1RgJ.animation.Play("panMiddle");
																																	if (277837 - 108472 == 169366)
																																	{
																																		continue;
																																	}
																																}
																															}
																														}
																														else
																														{
																															this.KuJnXMS7NkV = "9";
																															if (22407 - 182645 != -160238)
																															{
																																continue;
																															}
																															this.AeanOdeNLEt = Time.time + 0.5f;
																															if (271119 - 5116 == 266004)
																															{
																																continue;
																															}
																															this.audio.PlayOneShot(this.wrongFx);
																															if (172698 - 403784 == -231085)
																															{
																																continue;
																															}
																														}
																													}
																												}
																											}
																										}
																										if (Input.GetKey(KeyCode.D))
																										{
																											if (199492 - 481747 != -282255)
																											{
																												continue;
																											}
																											if (!Chat.ChatActive)
																											{
																												if (278467 - 357164 == -78696)
																												{
																													continue;
																												}
																												GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)375, (float)898, (float)47, (float)47), this.R1WnO1atoAR);
																												if (143577 - 355468 == -211890)
																												{
																													continue;
																												}
																												if (this.C0UnXfr8Ybm == "9")
																												{
																													if (93441 - 67682 == 25760)
																													{
																														continue;
																													}
																													GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)375, (float)896, (float)52, (float)52), this.PsVnORs1lrl);
																													if (136094 - 521588 != -385494)
																													{
																														continue;
																													}
																												}
																												if (Event.current.type == EventType.KeyDown)
																												{
																													if (35361 - 282467 != -247106)
																													{
																														continue;
																													}
																													if (Event.current.keyCode == KeyCode.D)
																													{
																														if (286437 - 328529 != -42092)
																														{
																															continue;
																														}
																														if (this.C0UnXfr8Ybm == "1")
																														{
																															if (239057 - 203118 != 35939)
																															{
																																continue;
																															}
																															this.eFdnXRbZ8op += Mathf.Clamp(10 + Mathf.FloorToInt((float)this.IvynXx5sVhh * 0.1f), 0, 20);
																															if (98261 - 260863 != -162602)
																															{
																																continue;
																															}
																															this.E8CnXri0QJ7 += 0.01f * this.BiXnXlcf0sd;
																															if (213127 - 103253 == 109875)
																															{
																																continue;
																															}
																															this.IvynXx5sVhh++;
																															if (253142 - 370592 == -117449)
																															{
																																continue;
																															}
																															this.rASnXTryG5d = Time.time;
																															if (98196 - 349272 != -251076)
																															{
																																continue;
																															}
																															this.C0UnXfr8Ybm = "0";
																															if (108354 - 200774 != -92420)
																															{
																																continue;
																															}
																															this.VcqnOg5bHX4 = Time.time + 0.5f;
																															if (265403 - 32454 != 232949)
																															{
																																continue;
																															}
																															this.audio.PlayOneShot(this.rightFx);
																															if (5073 - 130861 == -125787)
																															{
																																continue;
																															}
																															if (this.IvynXx5sVhh % 50 == 0)
																															{
																																if (296666 - 208976 != 87690)
																																{
																																	continue;
																																}
																																this.fflnXg7WDRh = -1;
																																if (268447 - 84587 != 183860)
																																{
																																	continue;
																																}
																																this.VwPnXau8cB1 = Time.time;
																																if (257541 - 389834 == -132292)
																																{
																																	continue;
																																}
																																if (this.scoreFx)
																																{
																																	if (216069 - 163394 == 52676)
																																	{
																																		continue;
																																	}
																																	this.audio.PlayOneShot(this.scoreFx);
																																	if (142882 - 473364 == -330481)
																																	{
																																		continue;
																																	}
																																}
																																if (this.LqDnXLT1RgJ)
																																{
																																	if (16179 - 67933 == -51753)
																																	{
																																		continue;
																																	}
																																	this.LqDnXLT1RgJ.animation.Play("panMiddle");
																																	if (278814 - 344246 == -65431)
																																	{
																																		continue;
																																	}
																																}
																															}
																														}
																														else
																														{
																															this.C0UnXfr8Ybm = "9";
																															if (272791 - 238292 == 34500)
																															{
																																continue;
																															}
																															this.VcqnOg5bHX4 = Time.time + 0.5f;
																															if (216383 - 37787 != 178596)
																															{
																																continue;
																															}
																															this.audio.PlayOneShot(this.wrongFx);
																															if (36602 - 326922 == -290319)
																															{
																																continue;
																															}
																														}
																													}
																												}
																											}
																										}
																										if (this.pwenXbV454o <= 0)
																										{
																											if (56969 - 562664 == -505694)
																											{
																												continue;
																											}
																											this.CYYnX3Ndhlw--;
																											if (273467 - 116322 != 157145)
																											{
																												continue;
																											}
																											this.Qf7nXd9fuDP = Time.time + 3f;
																											if (153346 - 422923 == -269576)
																											{
																												continue;
																											}
																											this.pwenXbV454o = 10;
																											if (86507 - 43664 != 42843)
																											{
																												continue;
																											}
																											this.IvynXx5sVhh = 0;
																											if (234800 - 36148 == 198653)
																											{
																												continue;
																											}
																											if (this.Sf3nXEShK6K)
																											{
																												if (235018 - 545172 == -310153)
																												{
																													continue;
																												}
																												if (this.CYYnX3Ndhlw > 0)
																												{
																													if (130619 - 458154 != -327535)
																													{
																														continue;
																													}
																													this.Sf3nXEShK6K.SendMessage("ko");
																													if (39335 - 599173 != -559838)
																													{
																														continue;
																													}
																													if (this.koFx)
																													{
																														if (17437 - 389651 != -372214)
																														{
																															continue;
																														}
																														this.audio.PlayOneShot(this.koFx);
																														if (52101 - 103041 == -50939)
																														{
																															continue;
																														}
																													}
																													Game.sendMissionEvent(9615, -1);
																													if (293425 - 288378 != 5047)
																													{
																														continue;
																													}
																												}
																												else
																												{
																													this.Sf3nXEShK6K.SendMessage("dead");
																													if (147395 - 360794 != -213399)
																													{
																														continue;
																													}
																													if (this.koFx)
																													{
																														if (240327 - 323124 != -82797)
																														{
																															continue;
																														}
																														this.audio.PlayOneShot(this.koFx);
																														if (22498 - 293711 != -271213)
																														{
																															continue;
																														}
																													}
																													Game.sendMissionEvent(9615, -2);
																													if (266544 - 240899 == 25646)
																													{
																														continue;
																													}
																												}
																											}
																											if (this.LqDnXLT1RgJ)
																											{
																												if (47260 - 192141 != -144881)
																												{
																													continue;
																												}
																												this.LqDnXLT1RgJ.animation.Play("ko");
																												if (161627 - 3407 == 158221)
																												{
																													continue;
																												}
																											}
																										}
																										if (this.gmKnXYyBFB6 < this.IvynXx5sVhh)
																										{
																											if (260100 - 122753 != 137347)
																											{
																												continue;
																											}
																											this.gmKnXYyBFB6 = this.IvynXx5sVhh;
																											if (184651 - 521731 != -337080)
																											{
																												continue;
																											}
																										}
																										goto IL_2807;
																										IL_8E3:
																										GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)360, (float)780, (float)16, (float)16), this.sDBnOpoPRLL);
																										if (208811 - 466354 != -257542)
																										{
																											goto IL_CE5;
																										}
																										continue;
																									}
																								}
																								GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)375, (float)800, (float)52, (float)52), this.PsVnORs1lrl);
																								if (212525 - 390934 == -178408)
																								{
																									continue;
																								}
																								GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)375, (float)848, (float)52, (float)52), this.PsVnORs1lrl);
																								if (266097 - 300844 != -34747)
																								{
																									continue;
																								}
																								GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)375, (float)896, (float)52, (float)52), this.PsVnORs1lrl);
																								if (181839 - 577827 == -395987)
																								{
																									continue;
																								}
																								IL_2807:
																								if (this.IvynXx5sVhh >= 3)
																								{
																									if (185649 - 210056 != -24407)
																									{
																										continue;
																									}
																									if (Time.time - this.rASnXTryG5d < 0.5f)
																									{
																										if (64634 - 578723 != -514089)
																										{
																											continue;
																										}
																										float a = Mathf.Clamp((float)10 * (Time.time - this.rASnXTryG5d), (float)0, 1f);
																										if (257244 - 491203 == -233958)
																										{
																											continue;
																										}
																										Color color = GUI.color;
																										if (87615 - 333658 == -246042)
																										{
																											continue;
																										}
																										color.a = a;
																										if (85338 - 70091 != 15247)
																										{
																											continue;
																										}
																										if (220695 - 239073 == -18377)
																										{
																											continue;
																										}
																										Color color2 = GUI.color = color;
																										if (287275 - 496881 == -209605)
																										{
																											continue;
																										}
																										if (41124 - 575180 != -534056)
																										{
																											continue;
																										}
																									}
																									else
																									{
																										float a2 = Mathf.SmoothStep(1f, (float)0, Time.time - this.rASnXTryG5d - 0.5f);
																										if (44852 - 432977 == -388124)
																										{
																											continue;
																										}
																										Color color3 = GUI.color;
																										if (278137 - 584277 == -306139)
																										{
																											continue;
																										}
																										float num8 = color3.a = a2;
																										if (89597 - 228266 != -138669)
																										{
																											continue;
																										}
																										if (218302 - 190757 != 27545)
																										{
																											continue;
																										}
																										GUI.color = color3;
																										if (41204 - 523436 == -482231)
																										{
																											continue;
																										}
																										if (55486 - 168611 != -113125)
																										{
																											continue;
																										}
																									}
																									GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG + (float)340 - Mathf.SmoothStep((float)40, (float)0, (float)5 * (Time.time - this.rASnXTryG5d)), (float)790, (float)212, (float)130), this.YFknOMJl6hA);
																									if (52393 - 473562 == -421168 || 228120 - 158383 == 69738)
																									{
																										continue;
																									}
																									int num9 = 0;
																									if (9584 - 317535 != -307951)
																									{
																										continue;
																									}
																									int num10 = 0;
																									if (231515 - 380004 == -148488)
																									{
																										continue;
																									}
																									int l = 0;
																									if (24337 - 401968 != -377631)
																									{
																										continue;
																									}
																									while (l < (string.Empty + this.IvynXx5sVhh).Length)
																									{
																										int num11 = (int)(((float)this.IvynXx5sVhh % Mathf.Pow((float)10, (float)(l + 1)) - (float)num9) / Mathf.Pow((float)10, (float)l));
																										if (121533 - 203736 == -82202)
																										{
																											goto IL_314D;
																										}
																										GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG + (float)325 - (float)num10 - (float)this.RvKnOLBPQDX[num11] - Mathf.SmoothStep((float)40, (float)0, (float)5 * (Time.time - this.rASnXTryG5d)), (float)(850 + 5 * l), (float)this.RvKnOLBPQDX[num11], (float)84), this.s5wnOfJtgSL[num11]);
																										if (62531 - 584216 != -521685)
																										{
																											goto IL_314D;
																										}
																										num9 = (int)((float)num9 + (float)num11 * Mathf.Pow((float)10, (float)l));
																										if (208180 - 237233 != -29053)
																										{
																											goto IL_314D;
																										}
																										num10 += this.RvKnOLBPQDX[num11] - 10;
																										if (196022 - 137071 != 58951)
																										{
																											goto IL_314D;
																										}
																										l++;
																										if (3998 - 325383 != -321385)
																										{
																											goto IL_314D;
																										}
																									}
																									if (190378 - 552394 == -362015)
																									{
																										continue;
																									}
																									float a3 = 1f;
																									if (252432 - 493242 != -240810)
																									{
																										continue;
																									}
																									Color color4 = GUI.color;
																									if (194818 - 124745 != 70073)
																									{
																										continue;
																									}
																									color4.a = a3;
																									if (290096 - 390310 == -100213 || 236798 - 206343 == 30456)
																									{
																										continue;
																									}
																									GUI.color = color4;
																									if (26202 - 204181 != -177979)
																									{
																										continue;
																									}
																									if (69645 - 478616 == -408970)
																									{
																										continue;
																									}
																								}
																								this.eFdnXRbZ8op = Mathf.Clamp(this.eFdnXRbZ8op, 0, 29999);
																								if (75755 - 19349 != 56407)
																								{
																									this.E8CnXri0QJ7 = Mathf.Clamp(this.E8CnXri0QJ7, (float)-120, (float)120);
																									if (3718 - 251479 != -247760)
																									{
																										this.OtxnX7LoNMX[this.hH8nXprq6QP - 1] = this.CYYnX3Ndhlw;
																										if (206831 - 487744 != -280912)
																										{
																											this.cRLnX4tFBa1[this.hH8nXprq6QP - 1] = this.eFdnXRbZ8op;
																											if (237969 - 306942 == -68973)
																											{
																												this.WoYnXs64CKY[this.hH8nXprq6QP - 1] = (int)this.E8CnXri0QJ7;
																												if (183105 - 521683 == -338578)
																												{
																													this.DHTnXHgUV9N[this.hH8nXprq6QP - 1] = this.gmKnXYyBFB6;
																													if (8384 - 236768 == -228384)
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
		}
	}

	// Token: 0x0600AA13 RID: 43539 RVA: 0x012F6B44 File Offset: 0x012F4D44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderResultDisplay()
	{
		if (208115 - 447581 != -239466)
		{
		}
		for (;;)
		{
			float num = Mathf.SmoothStep(1.5f, (float)1, (float)2 * (Time.time - this.uqonXNA0Utk));
			if (187942 - 407125 == -219183)
			{
				float a = Mathf.SmoothStep((float)0, (float)1, (float)3 * (Time.time - this.uqonXNA0Utk));
				if (224990 - 65422 == 159568)
				{
					Color color = GUI.color;
					if (48907 - 283324 != -234416)
					{
						color.a = a;
						if (26488 - 523244 != -496755)
						{
							if (188634 - 232258 == -43624)
							{
								Color color2 = GUI.color = color;
								if (60094 - 105369 == -45275)
								{
									if (177815 - 363264 == -185449)
									{
										if (this.a25n2JfxmUy)
										{
											if (295194 - 333789 == -38594)
											{
												continue;
											}
											GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)410 * num, (float)530 - (float)80 * num, (float)820 * num, (float)160 * num), this.OD2nOEpVtVH);
											if (177172 - 220449 != -43277)
											{
												continue;
											}
										}
										else
										{
											GUI.DrawTexture(new Rect(0.5f * this.jptnXmPBAUG - (float)256 * num, (float)530 - (float)45 * num, (float)512 * num, (float)94 * num), this.FZunOPCMZxX);
											if (233371 - 111897 != 121474)
											{
												continue;
											}
										}
										int num2 = 1;
										if (209580 - 195363 != 14218)
										{
											Color color3 = GUI.color;
											if (101622 - 210045 == -108423)
											{
												color3.a = (float)num2;
												if (222663 - 202445 == 20218)
												{
													if (142160 - 477670 == -335510)
													{
														Color color4 = GUI.color = color3;
														if (275897 - 545535 == -269638)
														{
															if (247580 - 179964 != 67617)
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

	// Token: 0x0600AA14 RID: 43540 RVA: 0x012F6E30 File Offset: 0x012F5030
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitCompleteWindow()
	{
		if (38868 - 475786 != -436918)
		{
		}
		for (;;)
		{
			IL_49C:
			this.OD2nOEpVtVH = (Texture)Resources.Load("GameGui/Title/missionComplete", typeof(Texture));
			if (2622 - 274615 != -271992)
			{
				this.FZunOPCMZxX = (Texture)Resources.Load("GameGui/Title/failed", typeof(Texture));
				if (297877 - 60961 == 236916)
				{
					this.rImnOSBQFev = (Texture)Resources.Load("GameGui/DanceAudition/completeWindow", typeof(Texture));
					if (298301 - 307777 != -9475)
					{
						this.aNinOBXHCEn = (Texture)Resources.Load("GameGui/DanceAudition/completeAvatar", typeof(Texture));
						if (270839 - 299164 == -28325)
						{
							this.CfCnO0uOfWJ = (Texture)Resources.Load("GameGui/DanceAudition/completeTeamA", typeof(Texture));
							if (216578 - 415471 != -198892)
							{
								this.mVqnO87Y5os = (Texture)Resources.Load("GameGui/DanceAudition/completeTeamB", typeof(Texture));
								if (55165 - 49567 == 5598)
								{
									this.nqmnODh2WqB = new GUIStyle();
									if (286964 - 157054 == 129910)
									{
										this.nqmnODh2WqB.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/DanceAudition/rewardButton_h", typeof(Texture)));
										if (62099 - 458370 != -396270)
										{
											this.nqmnODh2WqB.active.background = (Texture2D)((Texture)Resources.Load("GameGui/DanceAudition/rewardButton_i", typeof(Texture)));
											if (160365 - 192611 == -32246)
											{
												this.O3snOkfqYqx = (Texture)Resources.Load("GameGui/Icons/Common/Item_bubble", typeof(Texture));
												if (179685 - 492193 != -312507)
												{
													this.JuFnOirw3DM = new GUIStyle();
													if (149778 - 152350 == -2572)
													{
														this.JuFnOirw3DM.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/DanceAudition/finishButton_h", typeof(Texture)));
														if (266601 - 528414 == -261813)
														{
															this.qaXnOmcVeQB = new GUIStyle();
															if (155331 - 357230 == -201899)
															{
																this.qaXnOmcVeQB.font = (Font)Resources.Load("GameGui/Fonts/GMO38", typeof(Font));
																if (122111 - 324296 == -202185)
																{
																	this.qaXnOmcVeQB.normal.textColor = new Color(0.14f, 0.11f, 0.07f, (float)1);
																	if (94940 - 385350 != -290409)
																	{
																		this.qaXnOmcVeQB.alignment = TextAnchor.MiddleLeft;
																		if (290103 - 314861 == -24758)
																		{
																			this.IK1nOjJlJ4d = new GUIStyle();
																			if (36954 - 357605 != -320650)
																			{
																				this.IK1nOjJlJ4d.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																				if (249584 - 329776 == -80192)
																				{
																					this.IK1nOjJlJ4d.normal.textColor = new Color(0.14f, 0.11f, 0.07f, (float)1);
																					if (194077 - 386113 == -192036)
																					{
																						this.IK1nOjJlJ4d.alignment = TextAnchor.MiddleLeft;
																						if (164534 - 484652 == -320118)
																						{
																							this.PRdnOoxnUQ3 = new GUIStyle();
																							if (76928 - 576262 == -499334)
																							{
																								this.PRdnOoxnUQ3.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																								if (71998 - 205124 != -133125)
																								{
																									this.PRdnOoxnUQ3.normal.textColor = new Color(0.14f, 0.11f, 0.07f, (float)1);
																									if (71424 - 307510 != -236085)
																									{
																										this.PRdnOoxnUQ3.alignment = TextAnchor.MiddleRight;
																										if (42624 - 333891 == -291267)
																										{
																											this.MpanOFULWgB = new GUIStyle();
																											if (263730 - 148066 == 115664)
																											{
																												this.MpanOFULWgB.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																												if (287231 - 269346 != 17886)
																												{
																													this.MpanOFULWgB.normal.textColor = new Color((float)1, (float)1, (float)1, (float)1);
																													if (2514 - 84295 != -81780)
																													{
																														this.MpanOFULWgB.alignment = TextAnchor.MiddleCenter;
																														if (286973 - 519184 != -232210)
																														{
																															this.SjHn2cuF45c = new string[12];
																															if (133209 - 347973 != -214763)
																															{
																																this.cBun2n3bFGD = new Texture[12];
																																if (153035 - 342728 != -189692)
																																{
																																	this.qF0n2Q8dq0G = new int[12];
																																	if (55020 - 47697 == 7323)
																																	{
																																		this.qvNn2elJHsW = new int[12];
																																		if (150441 - 126271 != 24171)
																																		{
																																			this.fJZnOWFhwkZ = new InventoryClass[21];
																																			if (145427 - 596526 == -451099)
																																			{
																																				this.qUQnOuEahF0 = new int[21];
																																				if (17841 - 439243 == -421402)
																																				{
																																					this.LVonOy8eSip = new Texture[21];
																																					if (213027 - 279605 != -66577)
																																					{
																																						this.lBMnOV3pPH8 = new Texture[7];
																																						if (2502 - 569445 == -566943)
																																						{
																																							this.PR7nOhjbBJ1 = new string[7];
																																							if (200351 - 441090 == -240739)
																																							{
																																								this.j17nOKa9EWQ = new int[7];
																																								if (217539 - 397915 == -180376)
																																								{
																																									int i = 0;
																																									if (254001 - 263213 == -9212)
																																									{
																																										while (i < 21)
																																										{
																																											this.fJZnOWFhwkZ[i] = new InventoryClass();
																																											if (167001 - 402193 != -235192)
																																											{
																																												goto IL_49C;
																																											}
																																											i++;
																																											if (150427 - 4204 != 146223)
																																											{
																																												goto IL_49C;
																																											}
																																										}
																																										if (88862 - 75345 != 13518)
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
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AA15 RID: 43541 RVA: 0x012F7640 File Offset: 0x012F5840
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderCompleteWindow()
	{
		if (6552 - 438467 != -431914)
		{
		}
		for (;;)
		{
			IL_A26:
			GUI.BeginGroup(new Rect(0.5f * this.jptnXmPBAUG - (float)512, (float)80, (float)1024, (float)780));
			if (21844 - 404104 != -382259)
			{
				GUI.DrawTexture(new Rect((float)0, (float)0, (float)1024, (float)780), this.rImnOSBQFev);
				if (219552 - 319487 == -99935)
				{
					int num = this.eFdnXRbZ8op + this.gmKnXYyBFB6 * 10 + this.CYYnX3Ndhlw * 100;
					if (248614 - 376521 != -127906)
					{
						int nRank = 0;
						if (279023 - 33812 == 245211)
						{
							if (!this.a25n2JfxmUy)
							{
								if (148794 - 218280 != -69486)
								{
									continue;
								}
								nRank = 0;
								if (72663 - 310689 == -238025)
								{
									continue;
								}
							}
							else if ((float)num > (float)this.TqxnX1JBOfP * 0.2f)
							{
								if (26959 - 85156 != -58197)
								{
									continue;
								}
								nRank = 5;
								if (185882 - 307308 != -121426)
								{
									continue;
								}
							}
							else if ((float)num > (float)this.TqxnX1JBOfP * 0.18f)
							{
								if (130025 - 13229 == 116797)
								{
									continue;
								}
								nRank = 4;
								if (198079 - 230948 == -32868)
								{
									continue;
								}
							}
							else if ((float)num > (float)this.TqxnX1JBOfP * 0.15f)
							{
								if (13590 - 361324 == -347733)
								{
									continue;
								}
								nRank = 3;
								if (230276 - 23380 != 206896)
								{
									continue;
								}
							}
							else if ((float)num > (float)this.TqxnX1JBOfP * 0.125f)
							{
								if (233268 - 17719 != 215549)
								{
									continue;
								}
								nRank = 2;
								if (43270 - 346439 != -303169)
								{
									continue;
								}
							}
							else if ((float)num > (float)this.TqxnX1JBOfP * 0.1f)
							{
								if (179956 - 508024 != -328068)
								{
									continue;
								}
								nRank = 1;
								if (119813 - 298661 != -178848)
								{
									continue;
								}
							}
							Guix.renderSmallNumber(320, 178, this.eFdnXRbZ8op, false, 0.9f);
							if (29164 - 346559 == -317395)
							{
								Guix.renderSmallNumber(320, 218, this.gmKnXYyBFB6 * 10, false, 0.9f);
								if (119919 - 241347 == -121428)
								{
									Guix.renderSmallNumber(320, 258, this.CYYnX3Ndhlw * 100, false, 0.9f);
									if (130754 - 410991 != -280236)
									{
										Guix.renderSmallNumber(320, 298, num, false, 1.1f);
										if (148393 - 333555 != -185161)
										{
											Guix.renderRankNumber(300, 345, nRank, 1.4f);
											if (49043 - 189602 == -140559)
											{
												int num2 = 0;
												if (147092 - 357017 != -209924)
												{
													int i = 0;
													if (94814 - 24203 == 70611)
													{
														while (i < 12)
														{
															num2 += this.qvNn2elJHsW[i];
															if (249911 - 453676 == -203764)
															{
																goto IL_A26;
															}
															i++;
															if (149380 - 385016 == -235635)
															{
																goto IL_A26;
															}
														}
														if (272364 - 194799 == 77565)
														{
															int num3 = num2 + this.getTeamCombo() * 10 + this.getTeamLife() * 100;
															if (68857 - 326149 == -257292)
															{
																int nRank2 = 0;
																if (267323 - 485780 != -218456)
																{
																	if (!this.a25n2JfxmUy)
																	{
																		if (94462 - 206948 == -112485)
																		{
																			continue;
																		}
																		nRank2 = 0;
																		if (237854 - 168296 != 69558)
																		{
																			continue;
																		}
																	}
																	else if ((float)num3 > (float)this.TqxnX1JBOfP * 2f)
																	{
																		if (286104 - 599743 == -313638)
																		{
																			continue;
																		}
																		nRank2 = 5;
																		if (119236 - 417863 != -298627)
																		{
																			continue;
																		}
																	}
																	else if ((float)num3 > (float)this.TqxnX1JBOfP * 1.8f)
																	{
																		if (127616 - 575561 == -447944)
																		{
																			continue;
																		}
																		nRank2 = 4;
																		if (6712 - 207189 == -200476)
																		{
																			continue;
																		}
																	}
																	else if ((float)num3 > (float)this.TqxnX1JBOfP * 1.5f)
																	{
																		if (236999 - 67183 == 169817)
																		{
																			continue;
																		}
																		nRank2 = 3;
																		if (136984 - 198182 == -61197)
																		{
																			continue;
																		}
																	}
																	else if ((float)num3 > (float)this.TqxnX1JBOfP * 1.25f)
																	{
																		if (298910 - 410959 == -112048)
																		{
																			continue;
																		}
																		nRank2 = 2;
																		if (262930 - 335952 != -73022)
																		{
																			continue;
																		}
																	}
																	else if (num3 > this.TqxnX1JBOfP)
																	{
																		if (248887 - 460621 != -211734)
																		{
																			continue;
																		}
																		nRank2 = 1;
																		if (78242 - 312674 != -234432)
																		{
																			continue;
																		}
																	}
																	Guix.renderSmallNumber(450, 178, num2, false, 0.9f);
																	if (204788 - 486218 != -281429)
																	{
																		Guix.renderSmallNumber(450, 218, 10 * this.getTeamCombo(), false, 0.9f);
																		if (84758 - 532704 != -447945)
																		{
																			Guix.renderSmallNumber(450, 258, 100 * this.getTeamLife(), false, 0.9f);
																			if (128726 - 435828 == -307102)
																			{
																				Guix.renderSmallNumber(450, 298, num3, false, 1.1f);
																				if (102393 - 592022 != -489628)
																				{
																					Guix.renderRankNumber(420, 345, nRank2, 1.4f);
																					if (170024 - 468427 == -298403)
																					{
																						int j = 0;
																						if (182313 - 431284 == -248971)
																						{
																							while (j < 12)
																							{
																								if (this.SjHn2cuF45c[j] != string.Empty)
																								{
																									if (143042 - 285830 != -142788)
																									{
																										goto IL_A26;
																									}
																									if (this.SjHn2cuF45c[j] != "none")
																									{
																										if (221039 - 165843 != 55196)
																										{
																											goto IL_A26;
																										}
																										if (j < 3)
																										{
																											if (83307 - 32531 != 50776)
																											{
																												goto IL_A26;
																											}
																											if (this.cBun2n3bFGD[j] != null)
																											{
																												if (157071 - 272310 == -115238)
																												{
																													goto IL_A26;
																												}
																												GUI.DrawTexture(new Rect((float)610, (float)(110 + j * 92), (float)75, (float)75), this.cBun2n3bFGD[j]);
																												if (110680 - 373716 == -263035)
																												{
																													goto IL_A26;
																												}
																											}
																											GUI.DrawTexture(new Rect((float)602, (float)(100 + j * 92), (float)175, (float)89), this.aNinOBXHCEn);
																											if (163324 - 166502 != -3178)
																											{
																												goto IL_A26;
																											}
																											GUI.Label(new Rect((float)702, (float)(100 + j * 92), (float)200, (float)50), this.SjHn2cuF45c[j], this.qaXnOmcVeQB);
																											if (142381 - 10481 == 131901)
																											{
																												goto IL_A26;
																											}
																											GUI.DrawTexture(new Rect((float)700, (float)(148 + j * 92), (float)70, (float)20), this.CfCnO0uOfWJ);
																											if (55395 - 401102 == -345706)
																											{
																												goto IL_A26;
																											}
																											Guix.renderSmallNumber(880, 139 + j * 92, this.qvNn2elJHsW[j], false, 1.2f);
																											if (46535 - 83935 == -37399)
																											{
																												goto IL_A26;
																											}
																										}
																										else
																										{
																											GUI.Label(new Rect((float)612, (float)(275 + j * 34), (float)200, (float)40), this.SjHn2cuF45c[j], this.IK1nOjJlJ4d);
																											if (217500 - 116489 != 101011)
																											{
																												goto IL_A26;
																											}
																											GUI.DrawTexture(new Rect((float)740, (float)(287 + j * 34), (float)70, (float)20), this.CfCnO0uOfWJ);
																											if (35961 - 246192 != -210231)
																											{
																												goto IL_A26;
																											}
																											GUI.Label(new Rect((float)780, (float)(275 + j * 34), (float)100, (float)40), string.Empty + this.qvNn2elJHsW[j], this.PRdnOoxnUQ3);
																											if (261867 - 446130 != -184263)
																											{
																												goto IL_A26;
																											}
																										}
																									}
																								}
																								j++;
																								if (67238 - 168862 != -101624)
																								{
																									goto IL_A26;
																								}
																							}
																							if (251097 - 556025 != -304927)
																							{
																								int k = 0;
																								if (41069 - 517178 == -476109)
																								{
																									while (k < 7)
																									{
																										if (this.fJZnOWFhwkZ[k].name != "none")
																										{
																											if (28237 - 242845 != -214608)
																											{
																												goto IL_A26;
																											}
																											if (this.qUQnOuEahF0[k] == 1)
																											{
																												if (106232 - 317977 != -211745)
																												{
																													goto IL_A26;
																												}
																												if (this.LVonOy8eSip[k] != null)
																												{
																													if (180946 - 578240 == -397293)
																													{
																														goto IL_A26;
																													}
																													GUI.DrawTexture(new Rect((float)(99 + k * 52), (float)428, (float)60, (float)60), this.LVonOy8eSip[k]);
																													if (60199 - 552812 == -492612)
																													{
																														goto IL_A26;
																													}
																													if (Time.time <= this.KjTn25mRolY)
																													{
																														if (274043 - 103280 != 170763)
																														{
																															goto IL_A26;
																														}
																														GUI.DrawTexture(new Rect((float)(104 + k * 52), (float)435, (float)46, (float)46), this.nqmnODh2WqB.active.background);
																														if (222841 - 359471 == -136629)
																														{
																															goto IL_A26;
																														}
																													}
																													else if (GUI.Button(new Rect((float)(104 + k * 52), (float)435, (float)46, (float)46), string.Empty, this.nqmnODh2WqB))
																													{
																														if (34610 - 527733 == -493122)
																														{
																															goto IL_A26;
																														}
																														this.selectItem(k);
																														if (14635 - 197708 != -183073)
																														{
																															goto IL_A26;
																														}
																														this.audio.PlayOneShot(this.eHlnXJMLVYp);
																														if (241225 - 95609 != 145616)
																														{
																															goto IL_A26;
																														}
																													}
																												}
																											}
																										}
																										k++;
																										if (106784 - 195119 != -88335)
																										{
																											goto IL_A26;
																										}
																									}
																									if (142171 - 509704 != -367532)
																									{
																										int l = 0;
																										if (276420 - 69032 == 207388)
																										{
																											while (l < 7)
																											{
																												if (this.lBMnOV3pPH8[l])
																												{
																													if (78979 - 410360 == -331380)
																													{
																														goto IL_A26;
																													}
																													GUI.DrawTexture(new Rect((float)(99 + l * 52), (float)521, (float)60, (float)60), this.lBMnOV3pPH8[l]);
																													if (84284 - 103402 == -19117)
																													{
																														goto IL_A26;
																													}
																													if (this.j17nOKa9EWQ[l] > 1)
																													{
																														if (88638 - 256897 == -168258)
																														{
																															goto IL_A26;
																														}
																														GUI.DrawTexture(new Rect((float)(137 + 52 * l), (float)668, (float)24, (float)24), this.O3snOkfqYqx);
																														if (259932 - 328927 != -68995)
																														{
																															goto IL_A26;
																														}
																														GUI.Label(new Rect((float)(133 + 52 * l), (float)663, (float)32, (float)32), string.Empty + this.j17nOKa9EWQ[l], this.MpanOFULWgB);
																														if (28497 - 442331 == -413833)
																														{
																															goto IL_A26;
																														}
																													}
																												}
																												l++;
																												if (80598 - 502116 != -421518)
																												{
																													goto IL_A26;
																												}
																											}
																											if (71275 - 152780 == -81505)
																											{
																												Guix.renderSmallNumber(200, 654, this.gsZnOA66KUx, false, 1.4f);
																												if (110963 - 567034 != -456070)
																												{
																													Guix.renderSmallNumber(420, 654, this.B7vnO9xLAGb, false, 1.4f);
																													if (25199 - 472349 == -447150)
																													{
																														if (GUI.Button(new Rect((float)671, (float)680, (float)121, (float)45), string.Empty, this.JuFnOirw3DM))
																														{
																															if (283252 - 531264 == -248011)
																															{
																																continue;
																															}
																															this.N0vnXUBs2lF = eDanceGuiState.disable;
																															if (295117 - 375117 == -79999)
																															{
																																continue;
																															}
																															this.uqonXNA0Utk = Time.time;
																															if (299861 - 409873 == -110011)
																															{
																																continue;
																															}
																															this.audio.PlayOneShot(this.gN3nXnM3hHn);
																															if (271237 - 52168 == 219070)
																															{
																																continue;
																															}
																															this.StartCoroutine_Auto(this.ReturnToTown());
																															if (7428 - 168611 != -161183)
																															{
																																continue;
																															}
																														}
																														GUI.EndGroup();
																														if (21345 - 375346 != -354000)
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
			}
		}
	}

	// Token: 0x0600AA16 RID: 43542 RVA: 0x012F8674 File Offset: 0x012F6874
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void selectItem(int slot)
	{
		if (261772 - 378656 != -116884)
		{
		}
		for (;;)
		{
			if (CharacterData.current.getEmptyInventorySlot() == -1)
			{
				if (265371 - 124500 == 140871)
				{
					this.newNoticeBar("Your inventory is full", 2f);
					if (131304 - 20763 == 110541)
					{
						break;
					}
				}
			}
			else
			{
				this.KjTn25mRolY = Time.time + (float)7;
				if (162551 - 387321 == -224770)
				{
					Hashtable hashtable = new Hashtable();
					if (30832 - 149813 != -118980)
					{
						hashtable.Add(21, PhotonClient.cInt16(this.fN7n2ITXxoH));
						if (141409 - 56732 == 84677)
						{
							hashtable.Add(22, PhotonClient.cInt16(slot));
							if (119044 - 165531 != -46486)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (239965 - 17782 == 222183)
								{
									PhotonClient.Connection.OpCustom(144, hashtable, true);
									if (258491 - 139275 != 119217)
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

	// Token: 0x0600AA17 RID: 43543 RVA: 0x012F8808 File Offset: 0x012F6A08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitNoticeBar()
	{
		if (64140 - 510842 != -446701)
		{
		}
		for (;;)
		{
			this.oSDn26oC9FG = (Texture)Resources.Load("GameGui/Common/noticeBar", typeof(Texture));
			if (71 - 546791 == -546720)
			{
				this.hywn2tH1P2a = new GUIStyle();
				if (25566 - 246071 == -220505)
				{
					this.hywn2tH1P2a.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
					if (133923 - 559197 == -425274)
					{
						this.hywn2tH1P2a.normal.textColor = new Color(0.23f, 0.2f, 0.14f, (float)1);
						if (284664 - 450858 != -166193)
						{
							this.hywn2tH1P2a.alignment = TextAnchor.MiddleCenter;
							if (144065 - 467933 == -323868)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AA18 RID: 43544 RVA: 0x012F8944 File Offset: 0x012F6B44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void newNoticeBar(string s, float t)
	{
		this.Hvwn2Onhidy = s;
		this.VZHn2X4gLI4 = Time.time + t;
	}

	// Token: 0x0600AA19 RID: 43545 RVA: 0x012F895C File Offset: 0x012F6B5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RenderNoticeBar()
	{
		if (273060 - 126165 != 146895)
		{
		}
		while (this.VZHn2X4gLI4 > Time.time)
		{
			if (159579 - 276888 != -117308)
			{
				GUI.DrawTexture(new Rect(0.5f * (this.jptnXmPBAUG - (float)475), (float)570, (float)475, (float)102), this.oSDn26oC9FG);
				if (238669 - 92707 == 145962)
				{
					GUI.Label(new Rect(0.5f * (this.jptnXmPBAUG - (float)475) + (float)45, (float)600, (float)400, (float)40), this.Hvwn2Onhidy, this.hywn2tH1P2a);
					if (178883 - 1381 != 177503)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AA1A RID: 43546 RVA: 0x012F8A60 File Offset: 0x012F6C60
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitChatBar()
	{
		if (112835 - 368447 != -255611)
		{
		}
		for (;;)
		{
			this.gQPn22VevWt = string.Empty;
			if (82342 - 256344 == -174002)
			{
				this.C2wn2v1x0Xo = (Texture)Resources.Load("GameGui/Common/TypeField", typeof(Texture));
				if (32176 - 155801 != -123624)
				{
					this.jxhn2lRSC6l = new GUIStyle();
					if (22675 - 375396 == -352721)
					{
						this.jxhn2lRSC6l.font = (Font)Resources.Load("GameGui/Fonts/GMO28", typeof(Font));
						if (201198 - 271718 != -70519)
						{
							this.JXyn2GPB5Bx = new GUIStyle();
							if (289196 - 522430 == -233234)
							{
								this.JXyn2GPB5Bx.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
								if (26869 - 376856 == -349987)
								{
									this.JMZn21XOtm1 = new GUIStyle();
									if (117035 - 60020 != 57016)
									{
										this.JMZn21XOtm1.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
										if (288277 - 225459 == 62818)
										{
											this.JMZn21XOtm1.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/Common/chatFontBG", typeof(Texture)));
											if (272270 - 535534 == -263264)
											{
												this.iAUn2qkfu1q = Chat.TextColor;
												if (299685 - 387210 != -87524)
												{
													this.Xoyn2pmuQYS = Chat.SelfColor;
													if (27452 - 115216 == -87764)
													{
														this.a7Kn2RDT4tx = Chat.AllyColor;
														if (263657 - 371199 != -107541)
														{
															this.n2Rn2rhjxFy = Chat.EnemyColor;
															if (89217 - 175441 == -86224)
															{
																this.Lran2xaHWrY = Chat.GuildColor;
																if (42550 - 240429 == -197879)
																{
																	this.dBOn2T1O7dF = Chat.NPCColor;
																	if (222611 - 532677 == -310066)
																	{
																		this.dbZn2Yrsynu = Chat.SystemColor;
																		if (258491 - 489738 != -231246)
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

	// Token: 0x0600AA1B RID: 43547 RVA: 0x012F8D6C File Offset: 0x012F6F6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderChatBar()
	{
		if (32219 - 141128 != -108909)
		{
		}
		for (;;)
		{
			IL_1B68:
			if (!Chat.ChatActive)
			{
				if (276025 - 12202 == 263824)
				{
					continue;
				}
				if (PlayerPrefs.GetInt("display", 1) == 0)
				{
					if (241239 - 267837 != -26598)
					{
						continue;
					}
					break;
				}
			}
			Rect screenRect = new Rect(this.jptnXmPBAUG - (float)650, (float)150, (float)600, (float)550);
			if (141410 - 247602 == -106192)
			{
				GUILayout.BeginArea(screenRect);
				if (107208 - 299795 != -192586)
				{
					GUILayout.BeginVertical(new GUILayoutOption[0]);
					if (223337 - 11835 != 211503)
					{
						GUILayout.FlexibleSpace();
						if (218744 - 382240 != -163495)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(Chat.ChatDisplay);
							if (217867 - 169271 == 48596)
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
									if (4160 - 576107 == -571946)
									{
										goto IL_1B68;
									}
									float num = Mathf.Clamp((float)30 - Time.time + chatEntry.time, (float)0, 1f);
									if (65316 - 194621 == -129304)
									{
										goto IL_1B68;
									}
									UnityRuntimeServices.Update(enumerator, chatEntry);
									if (18435 - 516734 != -498299)
									{
										goto IL_1B68;
									}
									if (num > (float)0)
									{
										if (420 - 503244 != -502824)
										{
											goto IL_1B68;
										}
										eChatMode mode = chatEntry.mode;
										if (149477 - 379276 != -229799)
										{
											goto IL_1B68;
										}
										UnityRuntimeServices.Update(enumerator, chatEntry);
										if (242979 - 523882 != -280903)
										{
											goto IL_1B68;
										}
										if (mode == eChatMode.area)
										{
											if (22077 - 226287 != -204210)
											{
												goto IL_1B68;
											}
											if (Chat.showAreaChat)
											{
												if (80022 - 525792 != -445770)
												{
													goto IL_1B68;
												}
												GUILayout.BeginHorizontal(new GUILayoutOption[0]);
												if (197704 - 384703 != -186999)
												{
													goto IL_1B68;
												}
												GUILayout.FlexibleSpace();
												if (299911 - 590807 != -290896)
												{
													goto IL_1B68;
												}
												this.JXyn2GPB5Bx.normal.textColor = this.dBOn2T1O7dF;
												if (197177 - 121754 == 75424)
												{
													goto IL_1B68;
												}
												float a = num;
												if (25758 - 403534 == -377775)
												{
													goto IL_1B68;
												}
												Color textColor = this.JXyn2GPB5Bx.normal.textColor;
												if (194022 - 245974 == -51951)
												{
													goto IL_1B68;
												}
												textColor.a = a;
												if (185189 - 444038 != -258849)
												{
													goto IL_1B68;
												}
												if (166854 - 101003 == 65852)
												{
													goto IL_1B68;
												}
												this.JXyn2GPB5Bx.normal.textColor = textColor;
												if (249821 - 201142 == 48680)
												{
													goto IL_1B68;
												}
												if (51998 - 323805 != -271807)
												{
													goto IL_1B68;
												}
												GUILayout.Label("[ALL]", this.JXyn2GPB5Bx, new GUILayoutOption[0]);
												if (288468 - 76490 == 211979)
												{
													goto IL_1B68;
												}
												GUILayout.Space((float)5);
												if (203754 - 66993 != 136761)
												{
													goto IL_1B68;
												}
												this.JXyn2GPB5Bx.normal.textColor = this.Xoyn2pmuQYS;
												if (129230 - 124095 == 5136)
												{
													goto IL_1B68;
												}
												float a2 = num;
												if (154077 - 512858 != -358781)
												{
													goto IL_1B68;
												}
												Color textColor2 = this.JXyn2GPB5Bx.normal.textColor;
												if (254044 - 332477 == -78432)
												{
													goto IL_1B68;
												}
												float num2 = textColor2.a = a2;
												if (13410 - 350235 != -336825)
												{
													goto IL_1B68;
												}
												if (88554 - 475042 != -386488)
												{
													goto IL_1B68;
												}
												this.JXyn2GPB5Bx.normal.textColor = textColor2;
												if (40812 - 561080 == -520267 || 17203 - 412663 == -395459)
												{
													goto IL_1B68;
												}
												GUILayout.Label(chatEntry.name + ":", this.JXyn2GPB5Bx, new GUILayoutOption[0]);
												if (80663 - 135966 == -55302)
												{
													goto IL_1B68;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (154772 - 248510 == -93737)
												{
													goto IL_1B68;
												}
												this.JMZn21XOtm1.normal.textColor = this.iAUn2qkfu1q;
												if (228322 - 496841 == -268518)
												{
													goto IL_1B68;
												}
												float a3 = num;
												if (169374 - 596670 != -427296)
												{
													goto IL_1B68;
												}
												Color textColor3 = this.JMZn21XOtm1.normal.textColor;
												if (194675 - 272798 != -78123)
												{
													goto IL_1B68;
												}
												float num3 = textColor3.a = a3;
												if (54346 - 269133 == -214786 || 1575 - 108003 == -106427)
												{
													goto IL_1B68;
												}
												this.JMZn21XOtm1.normal.textColor = textColor3;
												if (78046 - 302370 != -224324)
												{
													goto IL_1B68;
												}
												if (229461 - 176808 == 52654)
												{
													goto IL_1B68;
												}
												GUILayout.Label(" " + chatEntry.text + " ", this.JMZn21XOtm1, new GUILayoutOption[0]);
												if (240383 - 286098 != -45715)
												{
													goto IL_1B68;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (25692 - 516647 != -490955)
												{
													goto IL_1B68;
												}
												GUILayout.EndHorizontal();
												if (4918 - 272009 == -267090)
												{
													goto IL_1B68;
												}
											}
										}
										else if (mode == eChatMode.party)
										{
											if (52095 - 436367 != -384272)
											{
												goto IL_1B68;
											}
											if (Chat.showAreaChat)
											{
												if (78196 - 482506 != -404310)
												{
													goto IL_1B68;
												}
												GUILayout.BeginHorizontal(new GUILayoutOption[0]);
												if (77810 - 488995 == -411184)
												{
													goto IL_1B68;
												}
												GUILayout.FlexibleSpace();
												if (65993 - 176572 != -110579)
												{
													goto IL_1B68;
												}
												this.JXyn2GPB5Bx.normal.textColor = new Color(0.8f, 0.2f, 0.2f, num);
												if (107324 - 540933 != -433609)
												{
													goto IL_1B68;
												}
												GUILayout.Label("[TEAM]", this.JXyn2GPB5Bx, new GUILayoutOption[0]);
												if (4657 - 567591 == -562933)
												{
													goto IL_1B68;
												}
												GUILayout.Space((float)5);
												if (204326 - 228158 == -23831)
												{
													goto IL_1B68;
												}
												this.JXyn2GPB5Bx.normal.textColor = this.Xoyn2pmuQYS;
												if (55404 - 220630 != -165226)
												{
													goto IL_1B68;
												}
												float a4 = num;
												if (129448 - 285753 != -156305)
												{
													goto IL_1B68;
												}
												Color textColor4 = this.JXyn2GPB5Bx.normal.textColor;
												if (223661 - 229723 == -6061)
												{
													goto IL_1B68;
												}
												textColor4.a = a4;
												if (52846 - 187278 == -134431 || 85974 - 377852 == -291877)
												{
													goto IL_1B68;
												}
												this.JXyn2GPB5Bx.normal.textColor = textColor4;
												if (38756 - 308483 != -269727)
												{
													goto IL_1B68;
												}
												if (288094 - 154509 != 133585)
												{
													goto IL_1B68;
												}
												GUILayout.Label(chatEntry.name + ":", this.JXyn2GPB5Bx, new GUILayoutOption[0]);
												if (260400 - 342843 == -82442)
												{
													goto IL_1B68;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (109194 - 93833 != 15361)
												{
													goto IL_1B68;
												}
												this.JMZn21XOtm1.normal.textColor = this.iAUn2qkfu1q;
												if (235961 - 587267 != -351306)
												{
													goto IL_1B68;
												}
												float a5 = num;
												if (65645 - 84656 != -19011)
												{
													goto IL_1B68;
												}
												Color textColor5 = this.JMZn21XOtm1.normal.textColor;
												if (14550 - 52052 == -37501)
												{
													goto IL_1B68;
												}
												float num4 = textColor5.a = a5;
												if (53907 - 279915 != -226008)
												{
													goto IL_1B68;
												}
												if (11091 - 87231 != -76140)
												{
													goto IL_1B68;
												}
												Color color = this.JMZn21XOtm1.normal.textColor = textColor5;
												if (137893 - 460515 == -322621 || 178715 - 425469 == -246753)
												{
													goto IL_1B68;
												}
												GUILayout.Label(" " + chatEntry.text + " ", this.JMZn21XOtm1, new GUILayoutOption[0]);
												if (213126 - 99795 != 113331)
												{
													goto IL_1B68;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (2750 - 164850 != -162100)
												{
													goto IL_1B68;
												}
												GUILayout.EndHorizontal();
												if (147063 - 432473 != -285410)
												{
													goto IL_1B68;
												}
											}
										}
										else if (mode == eChatMode.guild)
										{
											if (32300 - 346475 == -314174)
											{
												goto IL_1B68;
											}
											if (Chat.showGuildChat)
											{
												if (82091 - 520039 == -437947)
												{
													goto IL_1B68;
												}
												GUILayout.BeginHorizontal(new GUILayoutOption[0]);
												if (81261 - 251098 != -169837)
												{
													goto IL_1B68;
												}
												GUILayout.FlexibleSpace();
												if (146101 - 316167 != -170066)
												{
													goto IL_1B68;
												}
												this.JXyn2GPB5Bx.normal.textColor = this.Lran2xaHWrY;
												if (237343 - 501043 != -263700)
												{
													goto IL_1B68;
												}
												float a6 = num;
												if (133117 - 597076 == -463958)
												{
													goto IL_1B68;
												}
												Color textColor6 = this.JXyn2GPB5Bx.normal.textColor;
												if (171370 - 216892 == -45521)
												{
													goto IL_1B68;
												}
												float num5 = textColor6.a = a6;
												if (203666 - 519816 != -316150)
												{
													goto IL_1B68;
												}
												if (270183 - 55807 != 214376)
												{
													goto IL_1B68;
												}
												Color color2 = this.JXyn2GPB5Bx.normal.textColor = textColor6;
												if (217849 - 107373 != 110476)
												{
													goto IL_1B68;
												}
												if (129606 - 540419 == -410812)
												{
													goto IL_1B68;
												}
												GUILayout.Label("[GLD]", this.JXyn2GPB5Bx, new GUILayoutOption[0]);
												if (56405 - 358807 == -302401)
												{
													goto IL_1B68;
												}
												GUILayout.Space((float)5);
												if (166756 - 414251 != -247495)
												{
													goto IL_1B68;
												}
												this.JXyn2GPB5Bx.normal.textColor = this.Xoyn2pmuQYS;
												if (122507 - 311705 != -189198)
												{
													goto IL_1B68;
												}
												float a7 = num;
												if (31971 - 83165 != -51194)
												{
													goto IL_1B68;
												}
												Color textColor7 = this.JXyn2GPB5Bx.normal.textColor;
												if (83879 - 73369 == 10511)
												{
													goto IL_1B68;
												}
												float num6 = textColor7.a = a7;
												if (222753 - 240036 != -17283)
												{
													goto IL_1B68;
												}
												if (275306 - 591366 == -316059)
												{
													goto IL_1B68;
												}
												Color color3 = this.JXyn2GPB5Bx.normal.textColor = textColor7;
												if (122446 - 559559 != -437113)
												{
													goto IL_1B68;
												}
												if (67984 - 425753 != -357769)
												{
													goto IL_1B68;
												}
												GUILayout.Label(chatEntry.name + ":", this.JXyn2GPB5Bx, new GUILayoutOption[0]);
												if (238746 - 548760 != -310014)
												{
													goto IL_1B68;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (43843 - 130416 == -86572)
												{
													goto IL_1B68;
												}
												this.JMZn21XOtm1.normal.textColor = this.Lran2xaHWrY;
												if (241589 - 386269 != -144680)
												{
													goto IL_1B68;
												}
												float a8 = num;
												if (19653 - 374391 != -354738)
												{
													goto IL_1B68;
												}
												Color textColor8 = this.JMZn21XOtm1.normal.textColor;
												if (212987 - 336416 == -123428)
												{
													goto IL_1B68;
												}
												float num7 = textColor8.a = a8;
												if (87607 - 8996 != 78611)
												{
													goto IL_1B68;
												}
												if (215002 - 556864 != -341862)
												{
													goto IL_1B68;
												}
												this.JMZn21XOtm1.normal.textColor = textColor8;
												if (162347 - 594839 == -432491)
												{
													goto IL_1B68;
												}
												if (286817 - 124492 != 162325)
												{
													goto IL_1B68;
												}
												GUILayout.Label(" " + chatEntry.text + " ", this.JMZn21XOtm1, new GUILayoutOption[0]);
												if (131303 - 310959 != -179656)
												{
													goto IL_1B68;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (190034 - 336652 == -146617)
												{
													goto IL_1B68;
												}
												GUILayout.EndHorizontal();
												if (163962 - 234481 == -70518)
												{
													goto IL_1B68;
												}
											}
										}
										else if (mode == eChatMode.whisper)
										{
											if (18528 - 506169 != -487641)
											{
												goto IL_1B68;
											}
											if (Chat.showPrivateChat)
											{
												if (52223 - 222971 != -170748)
												{
													goto IL_1B68;
												}
												GUILayout.BeginHorizontal(new GUILayoutOption[0]);
												if (131489 - 524751 == -393261)
												{
													goto IL_1B68;
												}
												GUILayout.FlexibleSpace();
												if (135055 - 382979 != -247924)
												{
													goto IL_1B68;
												}
												this.JXyn2GPB5Bx.normal.textColor = new Color(0.69f, 0.29f, 0.53f, num);
												if (237862 - 154727 == 83136)
												{
													goto IL_1B68;
												}
												GUILayout.Label("[WSP]", this.JXyn2GPB5Bx, new GUILayoutOption[0]);
												if (194582 - 383554 != -188972)
												{
													goto IL_1B68;
												}
												GUILayout.Space((float)5);
												if (167570 - 267393 != -99823)
												{
													goto IL_1B68;
												}
												this.JXyn2GPB5Bx.normal.textColor = this.Xoyn2pmuQYS;
												if (225838 - 444292 != -218454)
												{
													goto IL_1B68;
												}
												float a9 = num;
												if (293909 - 300270 == -6360)
												{
													goto IL_1B68;
												}
												Color textColor9 = this.JXyn2GPB5Bx.normal.textColor;
												if (96124 - 456809 != -360685)
												{
													goto IL_1B68;
												}
												float num8 = textColor9.a = a9;
												if (179586 - 591011 != -411425)
												{
													goto IL_1B68;
												}
												if (97340 - 116432 == -19091)
												{
													goto IL_1B68;
												}
												Color color4 = this.JXyn2GPB5Bx.normal.textColor = textColor9;
												if (233595 - 53153 != 180442)
												{
													goto IL_1B68;
												}
												if (217802 - 492811 == -275008)
												{
													goto IL_1B68;
												}
												GUILayout.Label(chatEntry.name + ":", this.JXyn2GPB5Bx, new GUILayoutOption[0]);
												if (253202 - 444094 != -190892)
												{
													goto IL_1B68;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (162617 - 500952 == -338334)
												{
													goto IL_1B68;
												}
												this.JMZn21XOtm1.normal.textColor = this.iAUn2qkfu1q;
												if (196071 - 32923 != 163148)
												{
													goto IL_1B68;
												}
												float a10 = num;
												if (290579 - 496724 == -206144)
												{
													goto IL_1B68;
												}
												Color textColor10 = this.JMZn21XOtm1.normal.textColor;
												if (28902 - 223178 != -194276)
												{
													goto IL_1B68;
												}
												textColor10.a = a10;
												if (245050 - 317722 != -72672)
												{
													goto IL_1B68;
												}
												if (174936 - 388863 == -213926)
												{
													goto IL_1B68;
												}
												Color color5 = this.JMZn21XOtm1.normal.textColor = textColor10;
												if (112585 - 486047 == -373461 || 53918 - 508446 == -454527)
												{
													goto IL_1B68;
												}
												GUILayout.Label(" " + chatEntry.text + " ", this.JMZn21XOtm1, new GUILayoutOption[0]);
												if (244243 - 544376 == -300132)
												{
													goto IL_1B68;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (232407 - 169979 == 62429)
												{
													goto IL_1B68;
												}
												GUILayout.EndHorizontal();
												if (286751 - 383400 != -96649)
												{
													goto IL_1B68;
												}
											}
										}
										else if (mode == eChatMode.system)
										{
											if (99904 - 105973 != -6069)
											{
												goto IL_1B68;
											}
											if (Chat.showSystemChat)
											{
												if (167899 - 523040 == -355140)
												{
													goto IL_1B68;
												}
												GUILayout.BeginHorizontal(new GUILayoutOption[0]);
												if (150505 - 148304 == 2202)
												{
													goto IL_1B68;
												}
												GUILayout.FlexibleSpace();
												if (206895 - 158026 != 48869)
												{
													goto IL_1B68;
												}
												eChatType type = chatEntry.type;
												if (188050 - 284871 == -96820)
												{
													goto IL_1B68;
												}
												UnityRuntimeServices.Update(enumerator, chatEntry);
												if (274537 - 320005 == -45467)
												{
													goto IL_1B68;
												}
												if (type == eChatType.system)
												{
													if (10165 - 483719 != -473554)
													{
														goto IL_1B68;
													}
													this.JMZn21XOtm1.normal.textColor = this.iAUn2qkfu1q;
													if (277480 - 304959 == -27478)
													{
														goto IL_1B68;
													}
													float a11 = num;
													if (3331 - 398456 == -395124)
													{
														goto IL_1B68;
													}
													Color textColor11 = this.JMZn21XOtm1.normal.textColor;
													if (60720 - 334393 != -273673)
													{
														goto IL_1B68;
													}
													float num9 = textColor11.a = a11;
													if (270098 - 189925 == 80174)
													{
														goto IL_1B68;
													}
													if (78328 - 288811 != -210483)
													{
														goto IL_1B68;
													}
													this.JMZn21XOtm1.normal.textColor = textColor11;
													if (99744 - 408943 == -309198 || 229372 - 294619 == -65246)
													{
														goto IL_1B68;
													}
													GUILayout.Label(" " + chatEntry.text + " ", this.JMZn21XOtm1, new GUILayoutOption[0]);
													if (18175 - 48979 == -30803)
													{
														goto IL_1B68;
													}
													UnityRuntimeServices.Update(enumerator, chatEntry);
													if (273995 - 568326 != -294331)
													{
														goto IL_1B68;
													}
												}
												else if (type == eChatType.self)
												{
													if (91574 - 521712 != -430138)
													{
														goto IL_1B68;
													}
													this.JXyn2GPB5Bx.normal.textColor = this.Xoyn2pmuQYS;
													if (90605 - 89678 != 927)
													{
														goto IL_1B68;
													}
													float a12 = num;
													if (115913 - 397611 == -281697)
													{
														goto IL_1B68;
													}
													Color textColor12 = this.JXyn2GPB5Bx.normal.textColor;
													if (39070 - 35352 != 3718)
													{
														goto IL_1B68;
													}
													textColor12.a = a12;
													if (235680 - 189522 != 46158)
													{
														goto IL_1B68;
													}
													if (290966 - 509689 != -218723)
													{
														goto IL_1B68;
													}
													this.JXyn2GPB5Bx.normal.textColor = textColor12;
													if (270191 - 176231 == 93961 || 217447 - 516668 == -299220)
													{
														goto IL_1B68;
													}
													GUILayout.Label(chatEntry.name + ":", this.JXyn2GPB5Bx, new GUILayoutOption[0]);
													if (171008 - 210440 == -39431)
													{
														goto IL_1B68;
													}
													UnityRuntimeServices.Update(enumerator, chatEntry);
													if (91072 - 427658 == -336585)
													{
														goto IL_1B68;
													}
													this.JMZn21XOtm1.normal.textColor = this.iAUn2qkfu1q;
													if (201856 - 207590 != -5734)
													{
														goto IL_1B68;
													}
													float a13 = num;
													if (232365 - 246160 == -13794)
													{
														goto IL_1B68;
													}
													Color textColor13 = this.JMZn21XOtm1.normal.textColor;
													if (139404 - 584550 != -445146)
													{
														goto IL_1B68;
													}
													float num10 = textColor13.a = a13;
													if (244107 - 32200 != 211907)
													{
														goto IL_1B68;
													}
													if (71330 - 368081 != -296751)
													{
														goto IL_1B68;
													}
													this.JMZn21XOtm1.normal.textColor = textColor13;
													if (227623 - 31560 == 196064)
													{
														goto IL_1B68;
													}
													if (21614 - 135719 != -114105)
													{
														goto IL_1B68;
													}
													GUILayout.Label(" " + chatEntry.text + " ", this.JMZn21XOtm1, new GUILayoutOption[0]);
													if (20013 - 333873 != -313860)
													{
														goto IL_1B68;
													}
													UnityRuntimeServices.Update(enumerator, chatEntry);
													if (296607 - 268960 != 27647)
													{
														goto IL_1B68;
													}
												}
												else if (type == eChatType.ally)
												{
													if (174487 - 445769 == -271281)
													{
														goto IL_1B68;
													}
													this.JXyn2GPB5Bx.normal.textColor = this.a7Kn2RDT4tx;
													if (154371 - 141273 != 13098)
													{
														goto IL_1B68;
													}
													float a14 = num;
													if (16717 - 199713 == -182995)
													{
														goto IL_1B68;
													}
													Color textColor14 = this.JXyn2GPB5Bx.normal.textColor;
													if (84622 - 239588 == -154965)
													{
														goto IL_1B68;
													}
													textColor14.a = a14;
													if (23423 - 551526 != -528103)
													{
														goto IL_1B68;
													}
													if (25990 - 534040 == -508049)
													{
														goto IL_1B68;
													}
													Color color6 = this.JXyn2GPB5Bx.normal.textColor = textColor14;
													if (225471 - 432036 != -206565)
													{
														goto IL_1B68;
													}
													if (111201 - 390755 != -279554)
													{
														goto IL_1B68;
													}
													GUILayout.Label(chatEntry.name + ":", this.JXyn2GPB5Bx, new GUILayoutOption[0]);
													if (26540 - 252570 != -226030)
													{
														goto IL_1B68;
													}
													UnityRuntimeServices.Update(enumerator, chatEntry);
													if (276043 - 493283 == -217239)
													{
														goto IL_1B68;
													}
													this.JMZn21XOtm1.normal.textColor = this.iAUn2qkfu1q;
													if (117404 - 586672 != -469268)
													{
														goto IL_1B68;
													}
													float a15 = num;
													if (254608 - 468521 != -213913)
													{
														goto IL_1B68;
													}
													Color textColor15 = this.JMZn21XOtm1.normal.textColor;
													if (25303 - 554861 != -529558)
													{
														goto IL_1B68;
													}
													textColor15.a = a15;
													if (45597 - 333654 == -288056)
													{
														goto IL_1B68;
													}
													if (66997 - 207596 != -140599)
													{
														goto IL_1B68;
													}
													this.JMZn21XOtm1.normal.textColor = textColor15;
													if (74620 - 208482 == -133861)
													{
														goto IL_1B68;
													}
													if (91975 - 60306 != 31669)
													{
														goto IL_1B68;
													}
													GUILayout.Label(" " + chatEntry.text + " ", this.JMZn21XOtm1, new GUILayoutOption[0]);
													if (258940 - 264038 != -5098)
													{
														goto IL_1B68;
													}
													UnityRuntimeServices.Update(enumerator, chatEntry);
													if (274768 - 309574 != -34806)
													{
														goto IL_1B68;
													}
												}
												else if (type == eChatType.enemy)
												{
													if (86508 - 65746 != 20762)
													{
														goto IL_1B68;
													}
													this.JXyn2GPB5Bx.normal.textColor = this.n2Rn2rhjxFy;
													if (82787 - 300631 == -217843)
													{
														goto IL_1B68;
													}
													float a16 = num;
													if (39389 - 184568 != -145179)
													{
														goto IL_1B68;
													}
													Color textColor16 = this.JXyn2GPB5Bx.normal.textColor;
													if (193954 - 231553 != -37599)
													{
														goto IL_1B68;
													}
													textColor16.a = a16;
													if (275946 - 220942 != 55004)
													{
														goto IL_1B68;
													}
													if (32929 - 142648 == -109718)
													{
														goto IL_1B68;
													}
													Color color7 = this.JXyn2GPB5Bx.normal.textColor = textColor16;
													if (233994 - 41515 == 192480)
													{
														goto IL_1B68;
													}
													if (113145 - 454468 != -341323)
													{
														goto IL_1B68;
													}
													GUILayout.Label(chatEntry.name + ":", this.JXyn2GPB5Bx, new GUILayoutOption[0]);
													if (173444 - 366461 == -193016)
													{
														goto IL_1B68;
													}
													UnityRuntimeServices.Update(enumerator, chatEntry);
													if (24629 - 326782 == -302152)
													{
														goto IL_1B68;
													}
													this.JMZn21XOtm1.normal.textColor = this.iAUn2qkfu1q;
													if (242660 - 583313 != -340653)
													{
														goto IL_1B68;
													}
													float a17 = num;
													if (45749 - 242354 == -196604)
													{
														goto IL_1B68;
													}
													Color textColor17 = this.JMZn21XOtm1.normal.textColor;
													if (95443 - 93200 != 2243)
													{
														goto IL_1B68;
													}
													float num11 = textColor17.a = a17;
													if (25630 - 474631 == -449000)
													{
														goto IL_1B68;
													}
													if (222791 - 193268 != 29523)
													{
														goto IL_1B68;
													}
													this.JMZn21XOtm1.normal.textColor = textColor17;
													if (276268 - 435566 != -159298)
													{
														goto IL_1B68;
													}
													if (219501 - 408985 == -189483)
													{
														goto IL_1B68;
													}
													GUILayout.Label(" " + chatEntry.text + " ", this.JMZn21XOtm1, new GUILayoutOption[0]);
													if (116448 - 411287 != -294839)
													{
														goto IL_1B68;
													}
													UnityRuntimeServices.Update(enumerator, chatEntry);
													if (189343 - 129086 == 60258)
													{
														goto IL_1B68;
													}
												}
												else if (type == eChatType.npc)
												{
													if (280375 - 510827 == -230451)
													{
														goto IL_1B68;
													}
													this.JXyn2GPB5Bx.normal.textColor = this.dBOn2T1O7dF;
													if (209361 - 213018 == -3656)
													{
														goto IL_1B68;
													}
													float a18 = num;
													if (99607 - 513897 == -414289)
													{
														goto IL_1B68;
													}
													Color textColor18 = this.JXyn2GPB5Bx.normal.textColor;
													if (208417 - 57582 != 150835)
													{
														goto IL_1B68;
													}
													textColor18.a = a18;
													if (80470 - 147545 != -67075)
													{
														goto IL_1B68;
													}
													if (264413 - 594877 != -330464)
													{
														goto IL_1B68;
													}
													this.JXyn2GPB5Bx.normal.textColor = textColor18;
													if (194348 - 175251 == 19098 || 17891 - 250281 == -232389)
													{
														goto IL_1B68;
													}
													GUILayout.Label(chatEntry.name + ":", this.JXyn2GPB5Bx, new GUILayoutOption[0]);
													if (199348 - 302355 == -103006)
													{
														goto IL_1B68;
													}
													UnityRuntimeServices.Update(enumerator, chatEntry);
													if (3500 - 175467 != -171967)
													{
														goto IL_1B68;
													}
													this.JMZn21XOtm1.normal.textColor = this.iAUn2qkfu1q;
													if (75706 - 392069 != -316363)
													{
														goto IL_1B68;
													}
													float a19 = num;
													if (170355 - 5684 == 164672)
													{
														goto IL_1B68;
													}
													Color textColor19 = this.JMZn21XOtm1.normal.textColor;
													if (179489 - 595496 != -416007)
													{
														goto IL_1B68;
													}
													float num12 = textColor19.a = a19;
													if (201527 - 230605 != -29078)
													{
														goto IL_1B68;
													}
													if (18004 - 243192 == -225187)
													{
														goto IL_1B68;
													}
													Color color8 = this.JMZn21XOtm1.normal.textColor = textColor19;
													if (74178 - 506298 == -432119)
													{
														goto IL_1B68;
													}
													if (66825 - 229919 != -163094)
													{
														goto IL_1B68;
													}
													GUILayout.Label(" " + chatEntry.text + " ", this.JMZn21XOtm1, new GUILayoutOption[0]);
													if (249568 - 524006 != -274438)
													{
														goto IL_1B68;
													}
													UnityRuntimeServices.Update(enumerator, chatEntry);
													if (49682 - 171377 == -121694)
													{
														goto IL_1B68;
													}
												}
												else if (type == eChatType.world)
												{
													if (209892 - 414054 == -204161)
													{
														goto IL_1B68;
													}
													this.JMZn21XOtm1.normal.textColor = new Color(0.95f, 0.25f, 0.25f, num);
													if (119320 - 25745 == 93576)
													{
														goto IL_1B68;
													}
													GUILayout.Label(chatEntry.text, this.JMZn21XOtm1, new GUILayoutOption[0]);
													if (996 - 573810 != -572814)
													{
														goto IL_1B68;
													}
													UnityRuntimeServices.Update(enumerator, chatEntry);
													if (50996 - 541062 == -490065)
													{
														goto IL_1B68;
													}
												}
												GUILayout.EndHorizontal();
												if (66805 - 113313 != -46508)
												{
													goto IL_1B68;
												}
											}
										}
										else if (mode == eChatMode.world)
										{
											if (85649 - 299505 == -213855)
											{
												goto IL_1B68;
											}
											GUILayout.BeginHorizontal(new GUILayoutOption[0]);
											if (131292 - 330455 != -199163)
											{
												goto IL_1B68;
											}
											GUILayout.FlexibleSpace();
											if (65546 - 30771 != 34775)
											{
												goto IL_1B68;
											}
											this.JMZn21XOtm1.normal.textColor = new Color(0.95f, 0.25f, 0.25f, num);
											if (70770 - 291512 == -220741)
											{
												goto IL_1B68;
											}
											GUILayout.Label(chatEntry.text, this.JMZn21XOtm1, new GUILayoutOption[0]);
											if (1555 - 68670 == -67114)
											{
												goto IL_1B68;
											}
											UnityRuntimeServices.Update(enumerator, chatEntry);
											if (149688 - 528174 == -378485)
											{
												goto IL_1B68;
											}
											GUILayout.EndHorizontal();
											if (281249 - 184139 != 97110)
											{
												goto IL_1B68;
											}
										}
									}
								}
								if (36260 - 36423 != -162)
								{
									GUILayout.EndVertical();
									if (283279 - 236151 == 47128)
									{
										GUILayout.EndArea();
										if (268444 - 485225 != -216780)
										{
											if (Chat.ChatActive)
											{
												if (12938 - 289012 != -276074)
												{
													continue;
												}
												bool flag = true;
												if (170967 - 470864 != -299897)
												{
													continue;
												}
												GUI.DrawTexture(new Rect(this.jptnXmPBAUG - (float)387, (float)700, (float)335, (float)33), this.C2wn2v1x0Xo);
												if (42220 - 351694 != -309474)
												{
													continue;
												}
												if (Input.GetKeyDown(KeyCode.UpArrow))
												{
													if (90419 - 191811 == -101391)
													{
														continue;
													}
													this.gQPn22VevWt = Chat.switchChatModeUp(this.gQPn22VevWt);
													if (49049 - 89683 != -40634)
													{
														continue;
													}
												}
												else if (Input.GetKeyDown(KeyCode.DownArrow))
												{
													if (177203 - 240136 != -62933)
													{
														continue;
													}
													this.gQPn22VevWt = Chat.switchChatModeDown(this.gQPn22VevWt);
													if (118029 - 164670 == -46640)
													{
														continue;
													}
												}
												else
												{
													if (Event.current.type == EventType.KeyDown)
													{
														if (226921 - 62152 != 164769)
														{
															continue;
														}
														if (Event.current.character == "\n")
														{
															if (146292 - 383124 == -236831)
															{
																continue;
															}
															string[] array = (string[])Stringf.splitToArray(this.gQPn22VevWt, " ").ToBuiltin(typeof(string));
															if (264873 - 116791 != 148082)
															{
																continue;
															}
															if (Extensions.get_length(array) > 0)
															{
																if (110206 - 336709 == -226502)
																{
																	continue;
																}
																string a20 = array[0];
																if (38860 - 89667 == -50806)
																{
																	continue;
																}
																if (a20 == "/a")
																{
																	if (256221 - 416135 != -159914)
																	{
																		continue;
																	}
																	Chat.ChatMode = 1;
																	if (219240 - 159471 != 59769)
																	{
																		continue;
																	}
																	this.gQPn22VevWt = Stringf.getString(this.gQPn22VevWt, 2, Extensions.get_length(this.gQPn22VevWt));
																	if (288032 - 527756 != -239724)
																	{
																		continue;
																	}
																}
																else if (a20 == "/g")
																{
																	if (159576 - 115546 != 44030)
																	{
																		continue;
																	}
																	if (!RuntimeServices.EqualityOperator(PlayerData.GID, "none"))
																	{
																		if (77504 - 350240 != -272736)
																		{
																			continue;
																		}
																		Chat.ChatMode = 2;
																		if (108102 - 16203 != 91899)
																		{
																			continue;
																		}
																		this.gQPn22VevWt = Stringf.getString(this.gQPn22VevWt, 2, Extensions.get_length(this.gQPn22VevWt));
																		if (15912 - 398800 != -382888)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		this.newGameMessage("You are not in a guild");
																		if (106701 - 581000 != -474299)
																		{
																			continue;
																		}
																		flag = false;
																		if (58471 - 4121 == 54351)
																		{
																			continue;
																		}
																	}
																}
																else if (a20 == "/t")
																{
																	if (243332 - 499435 != -256103)
																	{
																		continue;
																	}
																	if (Game.mGameType > 4)
																	{
																		if (22121 - 587494 != -565373)
																		{
																			continue;
																		}
																		Chat.ChatMode = 3;
																		if (254573 - 486653 != -232080)
																		{
																			continue;
																		}
																		this.gQPn22VevWt = Stringf.getString(this.gQPn22VevWt, 2, Extensions.get_length(this.gQPn22VevWt));
																		if (84436 - 268598 == -184161)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		this.newGameMessage("Cannot use team chat");
																		if (214077 - 348200 != -134123)
																		{
																			continue;
																		}
																		this.gQPn22VevWt = string.Empty;
																		if (173304 - 176672 == -3367)
																		{
																			continue;
																		}
																	}
																}
																else if (a20 == "/w")
																{
																	if (88468 - 485930 == -397461)
																	{
																		continue;
																	}
																	Chat.ChatMode = 4;
																	if (259111 - 236230 != 22881)
																	{
																		continue;
																	}
																	this.gQPn22VevWt = Stringf.getString(this.gQPn22VevWt, 3, Extensions.get_length(this.gQPn22VevWt));
																	if (187397 - 367526 == -180128)
																	{
																		continue;
																	}
																	if (Extensions.get_length(array) > 1)
																	{
																		if (23617 - 465338 != -441721)
																		{
																			continue;
																		}
																		int buddyID = PlayerData.getBuddyID(array[1]);
																		if (156841 - 402541 == -245699)
																		{
																			continue;
																		}
																		if (buddyID != 0)
																		{
																			if (232341 - 562544 == -330202)
																			{
																				continue;
																			}
																			Chat.TargetID = buddyID;
																			if (273372 - 112720 == 160653)
																			{
																				continue;
																			}
																			this.gQPn22VevWt = Stringf.getString(this.gQPn22VevWt, Extensions.get_length(array[1]) + 1, Extensions.get_length(this.gQPn22VevWt));
																			if (73118 - 560186 != -487068)
																			{
																				continue;
																			}
																		}
																	}
																}
															}
															if (flag)
															{
																if (246103 - 476330 == -230226)
																{
																	continue;
																}
																if (this.gQPn22VevWt.Length > 0)
																{
																	if (143899 - 433333 == -289433)
																	{
																		continue;
																	}
																	if (Chat.ChatMode == 4)
																	{
																		if (50419 - 19176 != 31243)
																		{
																			continue;
																		}
																		if (Chat.TargetID == 0)
																		{
																			if (196921 - 418492 != -221571)
																			{
																				continue;
																			}
																			this.newGameMessage("Whisper target not found!");
																			if (116340 - 363981 != -247641)
																			{
																				continue;
																			}
																			goto IL_710;
																		}
																	}
																	Chat.SubmitChat(PlayerData.User, this.gQPn22VevWt, eChatType.self, (eChatMode)Chat.ChatMode);
																	if (1417 - 201555 == -200137)
																	{
																		continue;
																	}
																}
															}
															IL_710:
															this.gQPn22VevWt = string.Empty;
															if (25614 - 432006 != -406392)
															{
																continue;
															}
															Chat.ChatTimeOut = Time.time + 0.5f;
															if (117257 - 402904 == -285646)
															{
																continue;
															}
															Chat.ChatActive = false;
															if (95360 - 184717 != -89357)
															{
																continue;
															}
															goto IL_2134;
														}
													}
													GUI.SetNextControlName("DanceChatField");
													if (47176 - 317776 != -270600)
													{
														continue;
													}
													this.gQPn22VevWt = GUI.TextField(new Rect(this.jptnXmPBAUG - (float)380, (float)700, (float)300, (float)30), this.gQPn22VevWt, 36, this.jxhn2lRSC6l);
													if (30610 - 142699 == -112088)
													{
														continue;
													}
												}
											}
											IL_2134:
											if (!Chat.ChatActive)
											{
												break;
											}
											if (16725 - 531696 != -514970)
											{
												GUI.FocusControl("DanceChatField");
												if (89821 - 256846 == -167025)
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

	// Token: 0x0600AA1C RID: 43548 RVA: 0x012FBAAC File Offset: 0x012F9CAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitGameMessage()
	{
		if (47820 - 530413 != -482592)
		{
		}
		for (;;)
		{
			this.ekin2dyx40y = new GUIStyle();
			if (43419 - 281570 == -238151)
			{
				this.ekin2dyx40y.font = (Font)Resources.Load("GameGui/Fonts/Berlin24", typeof(Font));
				if (23648 - 210171 == -186523)
				{
					this.ekin2dyx40y.normal.textColor = new Color(0.8f, 0.2f, 0.1f, 0.8f);
					if (258815 - 389998 != -131182)
					{
						this.ekin2dyx40y.alignment = TextAnchor.MiddleCenter;
						if (150731 - 309522 == -158791)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AA1D RID: 43549 RVA: 0x012FBBB0 File Offset: 0x012F9DB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RenderGameMessage()
	{
		if (252266 - 419649 != -167383)
		{
		}
		for (;;)
		{
			if (Event.current.type != EventType.Repaint)
			{
				if (50670 - 523499 != -472828)
				{
					break;
				}
			}
			else
			{
				if (this.FMYn2baw5cC + (float)2 <= Time.time)
				{
					break;
				}
				if (54903 - 556495 != -501591)
				{
					GUI.Label(new Rect(0.5f * this.jptnXmPBAUG - (float)250, (float)260, (float)500, (float)40), this.CbKn23DgJ2F, this.ekin2dyx40y);
					if (66211 - 507590 == -441379)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AA1E RID: 43550 RVA: 0x012FBC98 File Offset: 0x012F9E98
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void newGameMessage(string Message)
	{
		if (28723 - 305598 != -276874)
		{
		}
		while (PlayerPrefs.GetInt("smessage", 1) != 0)
		{
			if (33635 - 42003 != -8367)
			{
				this.CbKn23DgJ2F = Message;
				if (101068 - 505317 == -404249)
				{
					this.FMYn2baw5cC = Time.time;
					if (126686 - 481248 == -354562)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AA1F RID: 43551 RVA: 0x012FBD40 File Offset: 0x012F9F40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void CreatePlayer(int CID, int team, Vector3 pos, Vector3 dir)
	{
		if (212744 - 226295 != -13550)
		{
		}
		for (;;)
		{
			Hashtable hashtable = new Hashtable();
			if (91829 - 403663 == -311834)
			{
				hashtable.Add(71, CID);
				if (19723 - 444435 == -424712)
				{
					hashtable.Add(75, PhotonClient.cInt16(team));
					if (66100 - 331952 == -265852)
					{
						hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(pos.x * (float)50)));
						if (181582 - 369400 != -187817)
						{
							hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(pos.y * (float)50)));
							if (30281 - 65302 != -35020)
							{
								hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(pos.z * (float)50)));
								if (237940 - 249856 != -11915)
								{
									hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(dir.x * (float)200)));
									if (146357 - 526991 == -380634)
									{
										hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(dir.y * (float)200)));
										if (17002 - 187879 != -170876)
										{
											hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(dir.z * (float)200)));
											if (193094 - 433258 != -240163)
											{
												this.jycntKkLTWw.OpCustom(61, hashtable, true);
												if (100250 - 450369 == -350119)
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

	// Token: 0x0600AA20 RID: 43552 RVA: 0x012FBFCC File Offset: 0x012FA1CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePlayer(Hashtable data)
	{
		if (103922 - 61675 != 42247)
		{
		}
		for (;;)
		{
			GameObject gameObject = this.CreateDancer(data);
			if (10097 - 77310 == -67213)
			{
				if (!gameObject)
				{
					break;
				}
				if (79019 - 388958 == -309939)
				{
					this.Sf3nXEShK6K = gameObject;
					if (74353 - 46457 != 27897)
					{
						this.StartCoroutine_Auto(this.StartGame());
						if (71605 - 354241 != -282635)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AA21 RID: 43553 RVA: 0x012FC094 File Offset: 0x012FA294
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onCreatePeer(Hashtable data)
	{
		GameObject gameObject = this.CreateDancer(data);
	}

	// Token: 0x0600AA22 RID: 43554 RVA: 0x012FC0AC File Offset: 0x012FA2AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual GameObject CreateDancer(Hashtable data)
	{
		if (255620 - 184081 != 71539)
		{
		}
		GameObject gameObject;
		for (;;)
		{
			IL_1260:
			object obj2;
			object obj = obj2 = data[73];
			if (!(obj is string))
			{
				obj2 = RuntimeServices.Coerce(obj, typeof(string));
			}
			string text = NetworkUtility.DecodeRace((string)obj2);
			if (1251 - 496506 != -495254)
			{
				if (71640 - 429688 == -358048)
				{
					string a = text;
					if (148095 - 192577 == -44482)
					{
						GameObject original;
						if (a == "Wolf")
						{
							if (89335 - 480014 == -390678)
							{
								continue;
							}
							original = (GameObject)Resources.Load("GameAssets/Characters/Dancers/WolfDancer", typeof(GameObject));
							if (199428 - 137805 != 61623)
							{
								continue;
							}
						}
						else if (a == "Bison")
						{
							if (127852 - 395708 != -267856)
							{
								continue;
							}
							original = (GameObject)Resources.Load("GameAssets/Characters/Dancers/BisonDancer", typeof(GameObject));
							if (249462 - 279505 != -30043)
							{
								continue;
							}
						}
						else if (a == "Panda")
						{
							if (175709 - 447213 == -271503)
							{
								continue;
							}
							original = (GameObject)Resources.Load("GameAssets/Characters/Dancers/PandaDancer", typeof(GameObject));
							if (90616 - 207368 != -116752)
							{
								continue;
							}
						}
						else if (a == "Whale")
						{
							if (63155 - 537444 != -474289)
							{
								continue;
							}
							original = (GameObject)Resources.Load("GameAssets/Characters/Dancers/WhaleDancer", typeof(GameObject));
							if (293315 - 552422 == -259106)
							{
								continue;
							}
						}
						else if (a == "Cat")
						{
							if (254743 - 295815 == -41071)
							{
								continue;
							}
							original = (GameObject)Resources.Load("GameAssets/Characters/Dancers/CatDancer", typeof(GameObject));
							if (82573 - 343410 == -260836)
							{
								continue;
							}
						}
						else if (a == "Chameleon")
						{
							if (182538 - 261804 == -79265)
							{
								continue;
							}
							original = (GameObject)Resources.Load("GameAssets/Characters/Dancers/ChameleonDancer", typeof(GameObject));
							if (105306 - 534138 != -428832)
							{
								continue;
							}
						}
						else if (a == "Mole")
						{
							if (280662 - 196497 == 84166)
							{
								continue;
							}
							original = (GameObject)Resources.Load("GameAssets/Characters/Dancers/MoleDancer", typeof(GameObject));
							if (93740 - 217462 != -123722)
							{
								continue;
							}
						}
						else if (a == "Rabbit")
						{
							if (159271 - 89706 != 69565)
							{
								continue;
							}
							original = (GameObject)Resources.Load("GameAssets/Characters/Dancers/RabbitDancer", typeof(GameObject));
							if (219126 - 276882 == -57755)
							{
								continue;
							}
						}
						else if (a == "Monkey")
						{
							if (27541 - 177416 == -149874)
							{
								continue;
							}
							original = (GameObject)Resources.Load("GameAssets/Characters/Dancers/MonkeyDancer", typeof(GameObject));
							if (136698 - 239535 == -102836)
							{
								continue;
							}
						}
						else if (a == "Sheep")
						{
							if (89436 - 23292 != 66144)
							{
								continue;
							}
							original = (GameObject)Resources.Load("GameAssets/Characters/Dancers/SheepDancer", typeof(GameObject));
							if (57852 - 566259 != -508407)
							{
								continue;
							}
						}
						else if (a == "Penguin")
						{
							if (82001 - 310200 == -228198)
							{
								continue;
							}
							original = (GameObject)Resources.Load("GameAssets/Characters/Dancers/PenguinDancer", typeof(GameObject));
							if (12394 - 307543 != -295149)
							{
								continue;
							}
						}
						else if (a == "Bat")
						{
							if (293568 - 254093 != 39475)
							{
								continue;
							}
							original = (GameObject)Resources.Load("GameAssets/Characters/Dancers/BatDancer", typeof(GameObject));
							if (253268 - 124501 == 128768)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("OnCreateChar Error:" + data[73]);
							if (158383 - 387485 != -229101)
							{
								goto Block_118;
							}
							continue;
						}
						Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(data[122]), RuntimeServices.UnboxSingle(data[123]), RuntimeServices.UnboxSingle(data[124]));
						if (111459 - 530150 != -418690)
						{
							Vector3 forward = 0.005f * new Vector3(RuntimeServices.UnboxSingle(data[126]), RuntimeServices.UnboxSingle(data[127]), RuntimeServices.UnboxSingle(data[128]));
							if (41717 - 359630 == -317913)
							{
								gameObject = (GameObject)UnityEngine.Object.Instantiate(original, vector, Quaternion.LookRotation(forward));
								if (236739 - 83311 == 153428)
								{
									gameObject.layer = RuntimeServices.UnboxInt32(data[75]);
									if (295976 - 42632 != 253345)
									{
										gameObject.layer += 7;
										if (22819 - 246839 != -224019)
										{
											gameObject.tag = "Player";
											if (248620 - 1326 == 247294)
											{
												DancerControl dancerControl = (DancerControl)gameObject.GetComponent(typeof(DancerControl));
												if (151155 - 252790 == -101635)
												{
													if (dancerControl)
													{
														if (294283 - 357352 != -63069)
														{
															continue;
														}
														dancerControl.ActorNr = RuntimeServices.UnboxInt32(data[9]);
														if (95159 - 196425 == -101265)
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
														if (20546 - 520823 == -500276)
														{
															continue;
														}
														dancerControl.Lv = RuntimeServices.UnboxInt32(data[76]);
														if (248171 - 317570 != -69399)
														{
															continue;
														}
														dancerControl.Skin = RuntimeServices.UnboxInt32(data[74]);
														if (259334 - 78579 != 180755)
														{
															continue;
														}
														dancerControl.ownerID = RuntimeServices.UnboxInt32(data[81]);
														if (36560 - 375748 == -339187)
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
														if (45100 - 410219 != -365119)
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
														if (116682 - 392247 != -275565)
														{
															continue;
														}
														dancerControl.isMine = true;
														if (138625 - 359821 == -221195)
														{
															continue;
														}
													}
													int num = RuntimeServices.UnboxInt32(data[74]);
													if (158655 - 401599 == -242944)
													{
														if (76590 - 491970 != -415379)
														{
															string a2 = "none";
															if (101954 - 474855 == -372901)
															{
																if (109113 - 21918 != 87196 && 109450 - 528468 != -419017 && 271310 - 349008 != -77697)
																{
																	if (21807 - 487778 == -465971)
																	{
																		gameObject.SendMessage("SetSkin", num);
																		if (196060 - 251326 != -55265)
																		{
																			object obj10;
																			object obj9 = obj10 = data[116];
																			if (!(obj9 is string))
																			{
																				obj10 = RuntimeServices.Coerce(obj9, typeof(string));
																			}
																			string text2 = (string)obj10;
																			if (77804 - 348489 != -270684)
																			{
																				if (text2 != null)
																				{
																					if (145746 - 61341 == 84406)
																					{
																						continue;
																					}
																					if (text2 != "0")
																					{
																						if (163767 - 6956 == 156812)
																						{
																							continue;
																						}
																						UnityScript.Lang.Array array = Stringf.getArray(text2);
																						if (131155 - 58757 == 72399)
																						{
																							continue;
																						}
																						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(array);
																						if (115313 - 202373 != -87060)
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
																							if (271088 - 412529 != -141441)
																							{
																								goto IL_1260;
																							}
																							string heading = Stringf.getHeading(text3);
																							if (223201 - 585898 == -362696)
																							{
																								goto IL_1260;
																							}
																							UnityRuntimeServices.Update(enumerator, text3);
																							if (253126 - 520443 == -267316)
																							{
																								goto IL_1260;
																							}
																							if (heading == "w")
																							{
																								if (254468 - 8542 != 245926)
																								{
																									goto IL_1260;
																								}
																								if (text == "Panda")
																								{
																									if (294432 - 22286 != 272146)
																									{
																										goto IL_1260;
																									}
																									gameObject.SendMessage("EquipWeapon", text3);
																									if (106566 - 223650 == -117083)
																									{
																										goto IL_1260;
																									}
																									UnityRuntimeServices.Update(enumerator, text3);
																									if (242128 - 549594 == -307465)
																									{
																										goto IL_1260;
																									}
																									if (151034 - 375947 != -224913)
																									{
																										goto IL_1260;
																									}
																									UnityRuntimeServices.Update(enumerator, text3);
																									if (230534 - 177129 != 53405)
																									{
																										goto IL_1260;
																									}
																								}
																							}
																							else if (heading == "a")
																							{
																								if (109007 - 187872 != -78865)
																								{
																									goto IL_1260;
																								}
																								a2 = text3;
																								if (98314 - 91848 != 6466)
																								{
																									goto IL_1260;
																								}
																								UnityRuntimeServices.Update(enumerator, text3);
																								if (106634 - 78181 == 28454)
																								{
																									goto IL_1260;
																								}
																								gameObject.SendMessage("EquipArmor", text3);
																								if (212105 - 64800 != 147305)
																								{
																									goto IL_1260;
																								}
																								UnityRuntimeServices.Update(enumerator, text3);
																								if (85106 - 11572 != 73534)
																								{
																									goto IL_1260;
																								}
																							}
																							else if (heading == "c")
																							{
																								if (54326 - 362549 == -308222 || 147324 - 332446 == -185121)
																								{
																									goto IL_1260;
																								}
																								UnityRuntimeServices.Update(enumerator, text3);
																								if (191121 - 234475 != -43354)
																								{
																									goto IL_1260;
																								}
																								gameObject.SendMessage("EquipAccessory", text3);
																								if (244779 - 475850 == -231070)
																								{
																									goto IL_1260;
																								}
																								UnityRuntimeServices.Update(enumerator, text3);
																								if (142772 - 409010 != -266238)
																								{
																									goto IL_1260;
																								}
																							}
																							else if (heading == "b")
																							{
																								if (217792 - 244925 == -27132)
																								{
																									goto IL_1260;
																								}
																								if (270798 - 347754 != -76956)
																								{
																									goto IL_1260;
																								}
																								UnityRuntimeServices.Update(enumerator, text3);
																								if (159709 - 469591 != -309882)
																								{
																									goto IL_1260;
																								}
																								gameObject.SendMessage("EquipBoot", text3);
																								if (78009 - 332470 == -254460)
																								{
																									goto IL_1260;
																								}
																								UnityRuntimeServices.Update(enumerator, text3);
																								if (298644 - 114478 != 184166)
																								{
																									goto IL_1260;
																								}
																							}
																							else if (heading == "t")
																							{
																								if (161374 - 472160 == -310785 || 104711 - 274819 == -170107)
																								{
																									goto IL_1260;
																								}
																								UnityRuntimeServices.Update(enumerator, text3);
																								if (84158 - 476041 == -391882)
																								{
																									goto IL_1260;
																								}
																								gameObject.SendMessage("EquipTrinket", text3);
																								if (276509 - 96352 != 180157)
																								{
																									goto IL_1260;
																								}
																								UnityRuntimeServices.Update(enumerator, text3);
																								if (111748 - 42137 == 69612)
																								{
																									goto IL_1260;
																								}
																							}
																							else if (heading == "p")
																							{
																								if (234426 - 169497 != 64929)
																								{
																									goto IL_1260;
																								}
																								if (255590 - 172290 != 83300)
																								{
																									goto IL_1260;
																								}
																								UnityRuntimeServices.Update(enumerator, text3);
																								if (298387 - 564277 != -265890)
																								{
																									goto IL_1260;
																								}
																								gameObject.SendMessage("EquipPet", text3);
																								if (36280 - 68181 != -31901)
																								{
																									goto IL_1260;
																								}
																								UnityRuntimeServices.Update(enumerator, text3);
																								if (204523 - 67649 != 136874)
																								{
																									goto IL_1260;
																								}
																							}
																						}
																						if (106065 - 456250 != -350185)
																						{
																							continue;
																						}
																						if (a2 == "none")
																						{
																							if (86750 - 7067 == 79684)
																							{
																								continue;
																							}
																							gameObject.SendMessage("EquipArmor", "a_none");
																							if (171957 - 560967 != -389010)
																							{
																								continue;
																							}
																						}
																					}
																				}
																				if (!RuntimeServices.EqualityOperator(PhotonClient.ActorNrList[dancerControl.ActorNr], null))
																				{
																					if (255219 - 409844 != -154625)
																					{
																						continue;
																					}
																					Debug.Log("ActorNr: " + dancerControl.ActorNr + " already existed");
																					if (238289 - 223973 != 14316)
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
																					if (24807 - 242133 == -217325)
																					{
																						continue;
																					}
																					UnityEngine.Object.Destroy(obj16);
																					if (102275 - 63213 == 39063)
																					{
																						continue;
																					}
																					PhotonClient.ActorNrList[dancerControl.ActorNr] = gameObject;
																					if (102639 - 120311 == -17671)
																					{
																						continue;
																					}
																				}
																				else
																				{
																					PhotonClient.ActorNrList.Add(dancerControl.ActorNr, gameObject);
																					if (91855 - 396188 != -304333)
																					{
																						continue;
																					}
																				}
																				int playerSlot = Game.getPlayerSlot(dancerControl.ownerID);
																				if (217041 - 543093 != -326051)
																				{
																					gameObject.name = "Player" + playerSlot;
																					if (179971 - 326308 != -146336)
																					{
																						if (Game.mGamePlayerList.Contains(playerSlot))
																						{
																							if (62131 - 127350 != -65219)
																							{
																								continue;
																							}
																							Game.mGamePlayerList[playerSlot] = gameObject;
																							if (44869 - 122114 == -77244)
																							{
																								continue;
																							}
																						}
																						else
																						{
																							Game.mGamePlayerList.Add(playerSlot, gameObject);
																							if (37668 - 171121 != -133453)
																							{
																								continue;
																							}
																						}
																						if (Game.mGamePlayerName.Contains(playerSlot))
																						{
																							if (289268 - 564964 != -275696)
																							{
																								continue;
																							}
																							Game.mGamePlayerName[playerSlot] = dancerControl.Name;
																							if (271822 - 406619 != -134797)
																							{
																								continue;
																							}
																						}
																						else
																						{
																							Game.mGamePlayerName.Add(playerSlot, dancerControl.Name);
																							if (64481 - 269773 == -205291)
																							{
																								continue;
																							}
																						}
																						if (Game.mGamePlayerType.Contains(gameObject.name))
																						{
																							if (155829 - 301656 == -145826)
																							{
																								continue;
																							}
																							Game.mGamePlayerType[gameObject.name] = text;
																							if (95782 - 73921 == 21862)
																							{
																								continue;
																							}
																						}
																						else
																						{
																							Game.mGamePlayerType.Add(gameObject.name, text);
																							if (248035 - 218955 == 29081)
																							{
																								continue;
																							}
																						}
																						string name = "Team" + (gameObject.layer - 7);
																						if (223797 - 109022 != 114776)
																						{
																							GameObject gameObject2 = GameObject.Find(name);
																							if (267341 - 338773 != -71431)
																							{
																								if (!gameObject2)
																								{
																									if (200176 - 157358 != 42818)
																									{
																										continue;
																									}
																									gameObject2 = new GameObject(name);
																									if (260518 - 596975 != -336457)
																									{
																										continue;
																									}
																								}
																								gameObject.transform.parent = gameObject2.transform;
																								if (68836 - 365783 == -296947)
																								{
																									Debug.Log(gameObject.name + " created : ID=" + dancerControl.ActorNr + "@" + vector + " Team : " + gameObject.layer);
																									if (11895 - 512639 == -500744)
																									{
																										if (playerSlot <= 0)
																										{
																											break;
																										}
																										if (188150 - 373929 == -185779)
																										{
																											if (playerSlot > 12)
																											{
																												break;
																											}
																											if (103653 - 320323 == -216670)
																											{
																												this.hwAnXPaIG6Z[playerSlot - 1] = gameObject;
																												if (97999 - 340952 != -242952)
																												{
																													this.OtxnX7LoNMX[playerSlot - 1] = 3;
																													if (47189 - 282230 != -235040)
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
		}
		goto IL_15F0;
		Block_118:
		return null;
		IL_15F0:
		return gameObject;
	}

	// Token: 0x0600AA23 RID: 43555 RVA: 0x012FD6C4 File Offset: 0x012FB8C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator onDeadPlayer()
	{
		return new M961_DanceAudition.$onDeadPlayer$44676(this).GetEnumerator();
	}

	// Token: 0x0600AA24 RID: 43556 RVA: 0x012FD6D4 File Offset: 0x012FB8D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onRevivePlayer()
	{
		if (93946 - 484338 != -390391)
		{
		}
		for (;;)
		{
			Debug.Log("On Revive Player");
			if (3165 - 11822 != -8656)
			{
				this.r25ntzjj85H.target = Game.mPlayer;
				if (258380 - 163659 == 94721)
				{
					this.r25ntzjj85H.enabled = true;
					if (117962 - 207493 != -89530)
					{
						if (Game.mGameState != eGameState.Normal)
						{
							if (199448 - 310525 != -111077)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								break;
							}
							if (40278 - 57811 != -17533)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Normal;
						if (151291 - 201023 != -49731)
						{
							GameGui gameGui = (GameGui)this.GetComponent(typeof(GameGui));
							if (21012 - 153230 != -132217)
							{
								if (!gameGui)
								{
									break;
								}
								if (241370 - 407614 != -166243)
								{
									gameGui.enabled = true;
									if (19950 - 69407 == -49457)
									{
										gameGui.closeDeadMenu();
										if (200313 - 327027 == -126714)
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

	// Token: 0x0600AA25 RID: 43557 RVA: 0x012FD880 File Offset: 0x012FBA80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onPlayerRelease(GameObject mPlayer)
	{
		if (14605 - 500790 != -486185)
		{
		}
		for (;;)
		{
			Debug.Log("On Release Spirit");
			if (215288 - 33928 == 181360)
			{
				PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] = PlayerData.MissionWithdraw[MissionData.getMissionNumber(Game.mGameCode) - 1] + 1;
				if (167388 - 324001 == -156613)
				{
					this.StartCoroutine_Auto(this.ReturnToTown());
					if (283416 - 476470 != -193053)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600AA26 RID: 43558 RVA: 0x012FD944 File Offset: 0x012FBB44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onDestroyPlayer(Hashtable data)
	{
		if (RuntimeServices.EqualityOperator(data[81], PlayerData.UID))
		{
			Game.mGameState = eGameState.Ended;
		}
	}

	// Token: 0x0600AA27 RID: 43559 RVA: 0x012FD970 File Offset: 0x012FBB70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator ReturnToTown()
	{
		return new M961_DanceAudition.$ReturnToTown$44682(this).GetEnumerator();
	}

	// Token: 0x0600AA28 RID: 43560 RVA: 0x012FD980 File Offset: 0x012FBB80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LeaveGame()
	{
		if (70404 - 389668 != -319263)
		{
		}
		for (;;)
		{
			Debug.Log("leaving guild");
			if (97749 - 483931 == -386182)
			{
				Hashtable hashtable = new Hashtable();
				if (240218 - 493918 != -253699)
				{
					hashtable.Add(43, PlayerData.UID);
					if (15888 - 84194 == -68306)
					{
						PhotonClient.Connection.OpCustom(54, hashtable, true);
						if (49981 - 190115 != -140133)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AA29 RID: 43561 RVA: 0x012FDA58 File Offset: 0x012FBC58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLeaveGame()
	{
		Debug.Log("onLeaveGame");
		this.JoinTown();
	}

	// Token: 0x0600AA2A RID: 43562 RVA: 0x012FDA6C File Offset: 0x012FBC6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void JoinTown()
	{
		if (224607 - 7219 != 217388)
		{
		}
		for (;;)
		{
			Debug.Log("Joining Town");
			if (110752 - 414238 != -303485)
			{
				Hashtable hashtable = new Hashtable();
				if (211513 - 587873 != -376359)
				{
					if (Game.mNextGameCode == 30)
					{
						if (26710 - 182240 != -155530)
						{
							continue;
						}
						hashtable.Add(47, "NoGuild");
						if (144106 - 125787 == 18320)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 31)
					{
						if (79952 - 587531 == -507578)
						{
							continue;
						}
						hashtable.Add(47, "G" + GuildData.Name);
						if (274617 - 226208 != 48409)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 32)
					{
						if (217586 - 548958 != -331372)
						{
							continue;
						}
						hashtable.Add(47, "SnowCamp");
						if (178299 - 162103 != 16196)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 33)
					{
						if (205375 - 15111 == 190265)
						{
							continue;
						}
						hashtable.Add(47, "CrystalBeach");
						if (262374 - 278626 == -16251)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 34)
					{
						if (61636 - 484993 != -423357)
						{
							continue;
						}
						hashtable.Add(47, "ExcavationCamp");
						if (101355 - 384848 != -283493)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 35)
					{
						if (213222 - 19447 == 193776)
						{
							continue;
						}
						hashtable.Add(47, "UndergroundCamp");
						if (205520 - 306038 == -100517)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 36)
					{
						if (173907 - 147541 != 26366)
						{
							continue;
						}
						hashtable.Add(47, "ForestCamp");
						if (237844 - 249405 == -11560)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 51)
					{
						if (3740 - 240045 != -236305)
						{
							continue;
						}
						hashtable.Add(47, "MainStreet");
						if (79532 - 469657 == -390124)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 52)
					{
						if (20283 - 383465 != -363182)
						{
							continue;
						}
						hashtable.Add(47, "CentralSquare");
						if (165639 - 534709 == -369069)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 53)
					{
						if (212555 - 593088 != -380533)
						{
							continue;
						}
						hashtable.Add(47, "CityLibrary");
						if (286296 - 173643 == 112654)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 54)
					{
						if (207175 - 127935 != 79240)
						{
							continue;
						}
						hashtable.Add(47, "LightPark");
						if (80847 - 387695 != -306848)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 55)
					{
						if (214716 - 59736 == 154981)
						{
							continue;
						}
						hashtable.Add(47, "LightPalace");
						if (137120 - 20987 != 116133)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 56)
					{
						if (209800 - 499245 != -289445)
						{
							continue;
						}
						hashtable.Add(47, "PlainColosseum");
						if (69209 - 423762 == -354552)
						{
							continue;
						}
					}
					else if (Game.mNextGameCode == 57)
					{
						if (146713 - 114688 == 32026)
						{
							continue;
						}
						hashtable.Add(47, "LightTheater");
						if (273377 - 11619 != 261758)
						{
							continue;
						}
					}
					hashtable.Add(21, PhotonClient.cInt16(Mathf.Clamp(PlayerPrefs.GetInt("channel", 0), 0, 99)));
					if (106226 - 564360 != -458133)
					{
						this.jycntKkLTWw.OpCustom(42, hashtable, true);
						if (272349 - 370479 != -98129)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600AA2B RID: 43563 RVA: 0x012FE020 File Offset: 0x012FC220
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onJoinTown()
	{
		Game.mGameStage = 0;
		Game.loadNextLevel();
	}

	// Token: 0x0600AA2C RID: 43564 RVA: 0x012FE030 File Offset: 0x012FC230
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600AA2D RID: 43565 RVA: 0x012FE034 File Offset: 0x012FC234
	internal static bool MV30qrV0ParOmShJlhcJ()
	{
		return true;
	}

	// Token: 0x0600AA2E RID: 43566 RVA: 0x012FE038 File Offset: 0x012FC238
	internal static bool arTjoqV00EHDSjK9lsXn()
	{
		return false;
	}

	// Token: 0x04009697 RID: 38551
	private LitePeer jycntKkLTWw;

	// Token: 0x04009698 RID: 38552
	private PlayerCameraControl r25ntzjj85H;

	// Token: 0x04009699 RID: 38553
	private float PyJnX5t0dFH;

	// Token: 0x0400969A RID: 38554
	public AudioClip applause;

	// Token: 0x0400969B RID: 38555
	public AudioClip rightFx;

	// Token: 0x0400969C RID: 38556
	public AudioClip wrongFx;

	// Token: 0x0400969D RID: 38557
	public AudioClip scoreFx;

	// Token: 0x0400969E RID: 38558
	public AudioClip koFx;

	// Token: 0x0400969F RID: 38559
	public AudioClip deadFx;

	// Token: 0x040096A0 RID: 38560
	public GameObject tailsEffect;

	// Token: 0x040096A1 RID: 38561
	public GameObject arcadeEffect;

	// Token: 0x040096A2 RID: 38562
	public GameObject softRockEffect;

	// Token: 0x040096A3 RID: 38563
	public GameObject epicRockEffect;

	// Token: 0x040096A4 RID: 38564
	public GameObject score50;

	// Token: 0x040096A5 RID: 38565
	public GameObject score100;

	// Token: 0x040096A6 RID: 38566
	public GameObject score200;

	// Token: 0x040096A7 RID: 38567
	public GameObject combo10;

	// Token: 0x040096A8 RID: 38568
	public GameObject combo20;

	// Token: 0x040096A9 RID: 38569
	public GameObject combo30;

	// Token: 0x040096AA RID: 38570
	public GameObject lifeUp;

	// Token: 0x040096AB RID: 38571
	public GameObject koDust;

	// Token: 0x040096AC RID: 38572
	private Texture ydAnXc2yvK4;

	// Token: 0x040096AD RID: 38573
	private AudioClip gN3nXnM3hHn;

	// Token: 0x040096AE RID: 38574
	private AudioClip HNXnXQ93dRS;

	// Token: 0x040096AF RID: 38575
	private AudioClip aw1nXe0y43u;

	// Token: 0x040096B0 RID: 38576
	private AudioClip OwrnXIONRF3;

	// Token: 0x040096B1 RID: 38577
	private AudioClip eHlnXJMLVYp;

	// Token: 0x040096B2 RID: 38578
	private AudioClip SxonX6vPR8e;

	// Token: 0x040096B3 RID: 38579
	private AudioClip CfQnXtfEy6s;

	// Token: 0x040096B4 RID: 38580
	private bool V54nXX9hCpj;

	// Token: 0x040096B5 RID: 38581
	private bool HMTnXOdDYG5;

	// Token: 0x040096B6 RID: 38582
	private int OxUnX2j39Ih;

	// Token: 0x040096B7 RID: 38583
	private UnityScript.Lang.Array UgdnXvClMia;

	// Token: 0x040096B8 RID: 38584
	private float BiXnXlcf0sd;

	// Token: 0x040096B9 RID: 38585
	private float OA1nXGWAQiS;

	// Token: 0x040096BA RID: 38586
	private int TqxnX1JBOfP;

	// Token: 0x040096BB RID: 38587
	private int ox4nXqNRMpp;

	// Token: 0x040096BC RID: 38588
	private int hH8nXprq6QP;

	// Token: 0x040096BD RID: 38589
	private int eFdnXRbZ8op;

	// Token: 0x040096BE RID: 38590
	private float E8CnXri0QJ7;

	// Token: 0x040096BF RID: 38591
	private int IvynXx5sVhh;

	// Token: 0x040096C0 RID: 38592
	private float rASnXTryG5d;

	// Token: 0x040096C1 RID: 38593
	private int gmKnXYyBFB6;

	// Token: 0x040096C2 RID: 38594
	private int CYYnX3Ndhlw;

	// Token: 0x040096C3 RID: 38595
	private int pwenXbV454o;

	// Token: 0x040096C4 RID: 38596
	private float Qf7nXd9fuDP;

	// Token: 0x040096C5 RID: 38597
	private int fflnXg7WDRh;

	// Token: 0x040096C6 RID: 38598
	private float VwPnXau8cB1;

	// Token: 0x040096C7 RID: 38599
	private int[] cRLnX4tFBa1;

	// Token: 0x040096C8 RID: 38600
	private int[] WoYnXs64CKY;

	// Token: 0x040096C9 RID: 38601
	private int[] DHTnXHgUV9N;

	// Token: 0x040096CA RID: 38602
	private int[] OtxnX7LoNMX;

	// Token: 0x040096CB RID: 38603
	private int wbJnXZdApuL;

	// Token: 0x040096CC RID: 38604
	private string U0PnXCvB2jx;

	// Token: 0x040096CD RID: 38605
	private string KuJnXMS7NkV;

	// Token: 0x040096CE RID: 38606
	private string C0UnXfr8Ybm;

	// Token: 0x040096CF RID: 38607
	private GameObject LqDnXLT1RgJ;

	// Token: 0x040096D0 RID: 38608
	private GameObject LKxnXwyqIDk;

	// Token: 0x040096D1 RID: 38609
	private eDanceGuiState N0vnXUBs2lF;

	// Token: 0x040096D2 RID: 38610
	private float uqonXNA0Utk;

	// Token: 0x040096D3 RID: 38611
	private GameObject Sf3nXEShK6K;

	// Token: 0x040096D4 RID: 38612
	private GameObject[] hwAnXPaIG6Z;

	// Token: 0x040096D5 RID: 38613
	private GameObject[] oevnXSauDds;

	// Token: 0x040096D6 RID: 38614
	private GameObject[] jcgnXBBxYRe;

	// Token: 0x040096D7 RID: 38615
	private float jI1nX0nQqZt;

	// Token: 0x040096D8 RID: 38616
	private int MIHnX8dX0M5;

	// Token: 0x040096D9 RID: 38617
	private int prlnXiInPkj;

	// Token: 0x040096DA RID: 38618
	private int tB4nXDprWnO;

	// Token: 0x040096DB RID: 38619
	private float jptnXmPBAUG;

	// Token: 0x040096DC RID: 38620
	private Texture WvhnXjIYTZw;

	// Token: 0x040096DD RID: 38621
	private Texture vQsnXoiwB2g;

	// Token: 0x040096DE RID: 38622
	private Texture GlxnXkWgWpZ;

	// Token: 0x040096DF RID: 38623
	private GUIStyle wlsnXFwmlrm;

	// Token: 0x040096E0 RID: 38624
	private GUIStyle DpenXAJKMUf;

	// Token: 0x040096E1 RID: 38625
	private GUIStyle cHanX9fd1lG;

	// Token: 0x040096E2 RID: 38626
	private GUIStyle ttAnXWGQ8L6;

	// Token: 0x040096E3 RID: 38627
	private GUIStyle PcLnXufQsAJ;

	// Token: 0x040096E4 RID: 38628
	private GUIStyle A7anXy2TeiE;

	// Token: 0x040096E5 RID: 38629
	private GUIStyle vicnXVTSRxA;

	// Token: 0x040096E6 RID: 38630
	private GUIStyle hSNnXhVeoL7;

	// Token: 0x040096E7 RID: 38631
	private GUIStyle PggnXKyrwYV;

	// Token: 0x040096E8 RID: 38632
	private int ry7nXzjArnd;

	// Token: 0x040096E9 RID: 38633
	private int fYTnO5UBHrn;

	// Token: 0x040096EA RID: 38634
	private int fA1nOcbfK2o;

	// Token: 0x040096EB RID: 38635
	private int[] fwPnOngJrge;

	// Token: 0x040096EC RID: 38636
	private Texture utInOQZVrr1;

	// Token: 0x040096ED RID: 38637
	private Texture zJfnOeGmeEL;

	// Token: 0x040096EE RID: 38638
	private Texture dmSnOI9Nk1J;

	// Token: 0x040096EF RID: 38639
	private Texture vwHnOJeIGFc;

	// Token: 0x040096F0 RID: 38640
	private Texture jUknO6OFxyw;

	// Token: 0x040096F1 RID: 38641
	private Texture VaNnOtM3sql;

	// Token: 0x040096F2 RID: 38642
	private Texture jRFnOXiAuJT;

	// Token: 0x040096F3 RID: 38643
	private Texture Tb8nOOLObl4;

	// Token: 0x040096F4 RID: 38644
	private Texture JnYnO2NdvKD;

	// Token: 0x040096F5 RID: 38645
	private Texture fqjnOvQbgwb;

	// Token: 0x040096F6 RID: 38646
	private Texture VQ5nOlC94Ad;

	// Token: 0x040096F7 RID: 38647
	private Texture KdVnOGKEsQN;

	// Token: 0x040096F8 RID: 38648
	private Texture R1WnO1atoAR;

	// Token: 0x040096F9 RID: 38649
	private Texture akinOqsUCHx;

	// Token: 0x040096FA RID: 38650
	private Texture sDBnOpoPRLL;

	// Token: 0x040096FB RID: 38651
	private Texture PsVnORs1lrl;

	// Token: 0x040096FC RID: 38652
	private Texture M7SnOrY02r5;

	// Token: 0x040096FD RID: 38653
	private Texture oMenOxlJtPK;

	// Token: 0x040096FE RID: 38654
	private Texture UuQnOT8FhkE;

	// Token: 0x040096FF RID: 38655
	private Texture WAvnOYkn9LN;

	// Token: 0x04009700 RID: 38656
	private Texture LsWnO3wfiTX;

	// Token: 0x04009701 RID: 38657
	private float AkbnObkqqJH;

	// Token: 0x04009702 RID: 38658
	private float AeanOdeNLEt;

	// Token: 0x04009703 RID: 38659
	private float VcqnOg5bHX4;

	// Token: 0x04009704 RID: 38660
	private Texture gOsnOaNLm7U;

	// Token: 0x04009705 RID: 38661
	private Texture A23nO4MbZTS;

	// Token: 0x04009706 RID: 38662
	private Texture g6LnOsYLHs1;

	// Token: 0x04009707 RID: 38663
	private Texture UI5nOH3bLPW;

	// Token: 0x04009708 RID: 38664
	private Texture yljnO7Ubdfw;

	// Token: 0x04009709 RID: 38665
	private Texture EmXnOZZTVjS;

	// Token: 0x0400970A RID: 38666
	private Texture LdfnOCrphi8;

	// Token: 0x0400970B RID: 38667
	private Texture YFknOMJl6hA;

	// Token: 0x0400970C RID: 38668
	private Texture[] s5wnOfJtgSL;

	// Token: 0x0400970D RID: 38669
	private int[] RvKnOLBPQDX;

	// Token: 0x0400970E RID: 38670
	private GUIStyle Bg9nOww4Osv;

	// Token: 0x0400970F RID: 38671
	public AudioClip song_sillyCreature;

	// Token: 0x04009710 RID: 38672
	public AudioClip song_city;

	// Token: 0x04009711 RID: 38673
	public AudioClip song_oneday;

	// Token: 0x04009712 RID: 38674
	public AudioClip song_arcadeLevel;

	// Token: 0x04009713 RID: 38675
	public AudioClip song_horseBack;

	// Token: 0x04009714 RID: 38676
	public AudioClip song_plain;

	// Token: 0x04009715 RID: 38677
	public AudioClip song_danceWithPeppers;

	// Token: 0x04009716 RID: 38678
	public AudioClip song_funnyLevel;

	// Token: 0x04009717 RID: 38679
	public AudioClip song_bug;

	// Token: 0x04009718 RID: 38680
	public AudioClip song_rockNRoll;

	// Token: 0x04009719 RID: 38681
	public AudioClip song_control;

	// Token: 0x0400971A RID: 38682
	public AudioClip song_childishHero;

	// Token: 0x0400971B RID: 38683
	public AudioClip song_water2;

	// Token: 0x0400971C RID: 38684
	public AudioClip song_jump;

	// Token: 0x0400971D RID: 38685
	public AudioClip song_fire;

	// Token: 0x0400971E RID: 38686
	public AudioClip song_phoenix;

	// Token: 0x0400971F RID: 38687
	public AudioClip song_battle4;

	// Token: 0x04009720 RID: 38688
	public AudioClip song_anthem;

	// Token: 0x04009721 RID: 38689
	public AudioClip song_ice;

	// Token: 0x04009722 RID: 38690
	public AudioClip song_salamander;

	// Token: 0x04009723 RID: 38691
	public AudioClip song_battle3;

	// Token: 0x04009724 RID: 38692
	public AudioClip song_powerSurge;

	// Token: 0x04009725 RID: 38693
	private float hinnOUWpDpN;

	// Token: 0x04009726 RID: 38694
	private float zAjnONoasUx;

	// Token: 0x04009727 RID: 38695
	private Texture OD2nOEpVtVH;

	// Token: 0x04009728 RID: 38696
	private Texture FZunOPCMZxX;

	// Token: 0x04009729 RID: 38697
	private Texture rImnOSBQFev;

	// Token: 0x0400972A RID: 38698
	private Texture aNinOBXHCEn;

	// Token: 0x0400972B RID: 38699
	private Texture CfCnO0uOfWJ;

	// Token: 0x0400972C RID: 38700
	private Texture mVqnO87Y5os;

	// Token: 0x0400972D RID: 38701
	private GUIStyle JuFnOirw3DM;

	// Token: 0x0400972E RID: 38702
	private GUIStyle nqmnODh2WqB;

	// Token: 0x0400972F RID: 38703
	private GUIStyle qaXnOmcVeQB;

	// Token: 0x04009730 RID: 38704
	private GUIStyle IK1nOjJlJ4d;

	// Token: 0x04009731 RID: 38705
	private GUIStyle PRdnOoxnUQ3;

	// Token: 0x04009732 RID: 38706
	private Texture O3snOkfqYqx;

	// Token: 0x04009733 RID: 38707
	private GUIStyle MpanOFULWgB;

	// Token: 0x04009734 RID: 38708
	private int gsZnOA66KUx;

	// Token: 0x04009735 RID: 38709
	private int B7vnO9xLAGb;

	// Token: 0x04009736 RID: 38710
	private InventoryClass[] fJZnOWFhwkZ;

	// Token: 0x04009737 RID: 38711
	private int[] qUQnOuEahF0;

	// Token: 0x04009738 RID: 38712
	private Texture[] LVonOy8eSip;

	// Token: 0x04009739 RID: 38713
	private Texture[] lBMnOV3pPH8;

	// Token: 0x0400973A RID: 38714
	private string[] PR7nOhjbBJ1;

	// Token: 0x0400973B RID: 38715
	private int[] j17nOKa9EWQ;

	// Token: 0x0400973C RID: 38716
	private int X19nOz4fCNy;

	// Token: 0x0400973D RID: 38717
	private float KjTn25mRolY;

	// Token: 0x0400973E RID: 38718
	private string[] SjHn2cuF45c;

	// Token: 0x0400973F RID: 38719
	private Texture[] cBun2n3bFGD;

	// Token: 0x04009740 RID: 38720
	private int[] qF0n2Q8dq0G;

	// Token: 0x04009741 RID: 38721
	private int[] qvNn2elJHsW;

	// Token: 0x04009742 RID: 38722
	private int fN7n2ITXxoH;

	// Token: 0x04009743 RID: 38723
	private bool a25n2JfxmUy;

	// Token: 0x04009744 RID: 38724
	private Texture oSDn26oC9FG;

	// Token: 0x04009745 RID: 38725
	private GUIStyle hywn2tH1P2a;

	// Token: 0x04009746 RID: 38726
	private float VZHn2X4gLI4;

	// Token: 0x04009747 RID: 38727
	private string Hvwn2Onhidy;

	// Token: 0x04009748 RID: 38728
	private string gQPn22VevWt;

	// Token: 0x04009749 RID: 38729
	private Texture C2wn2v1x0Xo;

	// Token: 0x0400974A RID: 38730
	private GUIStyle jxhn2lRSC6l;

	// Token: 0x0400974B RID: 38731
	private GUIStyle JXyn2GPB5Bx;

	// Token: 0x0400974C RID: 38732
	private GUIStyle JMZn21XOtm1;

	// Token: 0x0400974D RID: 38733
	private Color iAUn2qkfu1q;

	// Token: 0x0400974E RID: 38734
	private Color Xoyn2pmuQYS;

	// Token: 0x0400974F RID: 38735
	private Color a7Kn2RDT4tx;

	// Token: 0x04009750 RID: 38736
	private Color n2Rn2rhjxFy;

	// Token: 0x04009751 RID: 38737
	private Color Lran2xaHWrY;

	// Token: 0x04009752 RID: 38738
	private Color dBOn2T1O7dF;

	// Token: 0x04009753 RID: 38739
	private Color dbZn2Yrsynu;

	// Token: 0x04009754 RID: 38740
	private string CbKn23DgJ2F;

	// Token: 0x04009755 RID: 38741
	private float FMYn2baw5cC;

	// Token: 0x04009756 RID: 38742
	private GUIStyle ekin2dyx40y;

	// Token: 0x02001C6F RID: 7279
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onGameComplete$44637 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AA2F RID: 43567 RVA: 0x012FE03C File Offset: 0x012FC23C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onGameComplete$44637(Hashtable data, M961_DanceAudition self_)
		{
			if (274327 - 57857 != 216470)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (154602 - 502585 == -347983)
				{
					base..ctor();
					if (112811 - 335219 == -222408)
					{
						this.$data$44657 = data;
						if (40225 - 233184 != -192958)
						{
							this.$self_$44658 = self_;
							if (89372 - 575468 == -486096)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AA30 RID: 43568 RVA: 0x012FE0F8 File Offset: 0x012FC2F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M961_DanceAudition.$onGameComplete$44637.$(this.$data$44657, this.$self_$44658);
		}

		// Token: 0x0600AA31 RID: 43569 RVA: 0x012FE10C File Offset: 0x012FC30C
		internal static bool e9D1vrV0bJB2xbtrs5v9()
		{
			return true;
		}

		// Token: 0x0600AA32 RID: 43570 RVA: 0x012FE110 File Offset: 0x012FC310
		internal static bool zhaFfFV0uBeUuabiNRY7()
		{
			return false;
		}

		// Token: 0x04009757 RID: 38743
		internal Hashtable $data$44657;

		// Token: 0x04009758 RID: 38744
		internal M961_DanceAudition $self_$44658;

		// Token: 0x02001C70 RID: 7280
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AA33 RID: 43571 RVA: 0x012FE114 File Offset: 0x012FC314
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Hashtable data, M961_DanceAudition self_)
			{
				if (28894 - 165446 != -136551)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (230447 - 369924 == -139477)
					{
						base..ctor();
						if (299028 - 25508 != 273521)
						{
							this.$data$44655 = data;
							if (296563 - 220946 != 75618)
							{
								this.$self_$44656 = self_;
								if (76303 - 128478 != -52174)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AA34 RID: 43572 RVA: 0x012FE1D0 File Offset: 0x012FC3D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (53141 - 388975 != -335833)
				{
				}
				for (;;)
				{
					IL_ACB:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_F9E;
					case 2:
						if (Game.mGameState > eGameState.AllHold)
						{
							if (85669 - 393208 != -307539)
							{
								continue;
							}
							goto IL_3B;
						}
						else
						{
							if (this.$self_$44656.LqDnXLT1RgJ)
							{
								if (9153 - 357349 != -348196)
								{
									continue;
								}
								this.$self_$44656.LqDnXLT1RgJ.animation.Play("panMiddle");
								if (116014 - 56800 == 59215)
								{
									continue;
								}
							}
							this.$result$44638 = RuntimeServices.UnboxInt32(this.$data$44655[31]);
							if (90121 - 487600 == -397478)
							{
								continue;
							}
							if (this.$result$44638 == 1)
							{
								if (207043 - 466609 == -259565)
								{
									continue;
								}
								this.$self_$44656.a25n2JfxmUy = true;
								if (185968 - 161741 == 24228)
								{
									continue;
								}
								if (this.$self_$44656.OxUnX2j39Ih == PlayerData.SongUnlock + 1)
								{
									if (181575 - 335142 == -153566)
									{
										continue;
									}
									PlayerData.SongUnlock = this.$self_$44656.OxUnX2j39Ih;
									if (115547 - 274470 != -158923)
									{
										continue;
									}
								}
								this.$self_$44656.audio.clip = (AudioClip)Resources.Load("Sound/Jingle/MissionComplete", typeof(AudioClip));
								if (109148 - 567806 == -458657)
								{
									continue;
								}
								this.$self_$44656.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (234520 - 327068 == -92547)
								{
									continue;
								}
								this.$a$44639 = 1;
								if (104388 - 257354 == -152965)
								{
									continue;
								}
								while (this.$a$44639 <= 12)
								{
									this.$self_$44656.PlayDancerAnimation(this.$a$44639, "cheer", true);
									if (229671 - 11490 != 218181)
									{
										goto IL_ACB;
									}
									this.$a$44639++;
									if (192177 - 306410 == -114232)
									{
										goto IL_ACB;
									}
								}
								if (11245 - 162223 != -150978)
								{
									continue;
								}
							}
							else
							{
								this.$self_$44656.a25n2JfxmUy = false;
								if (84625 - 310253 == -225627)
								{
									continue;
								}
								this.$self_$44656.audio.clip = (AudioClip)Resources.Load("Sound/Jingle/MissionFail", typeof(AudioClip));
								if (143822 - 312649 == -168826)
								{
									continue;
								}
								this.$self_$44656.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music);
								if (188340 - 21496 != 166844)
								{
									continue;
								}
								this.$b$44640 = 1;
								if (126765 - 264073 != -137308)
								{
									continue;
								}
								while (this.$b$44640 <= 12)
								{
									this.$self_$44656.PlayDancerAnimation(this.$b$44640, "cry", true);
									if (248472 - 514917 == -266444)
									{
										goto IL_ACB;
									}
									this.$b$44640++;
									if (42025 - 475781 != -433756)
									{
										goto IL_ACB;
									}
								}
								if (223300 - 283396 != -60096)
								{
									continue;
								}
							}
							this.$self_$44656.audio.loop = false;
							if (284177 - 97532 != 186645)
							{
								continue;
							}
							this.$self_$44656.audio.Play();
							if (220597 - 417784 == -197186)
							{
								continue;
							}
							this.$uidList$44641 = null;
							if (148677 - 112639 == 36039)
							{
								continue;
							}
							this.$gilList$44642 = null;
							if (65792 - 447239 != -381447)
							{
								continue;
							}
							this.$rpList$44643 = null;
							if (10402 - 46981 != -36579)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = this.$data$44655[43];
							if (!(obj is int[]))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(int[]));
							}
							this.$uidList$44641 = (int[])obj2;
							if (88968 - 151850 == -62881)
							{
								continue;
							}
							object obj4;
							object obj3 = obj4 = this.$data$44655[48];
							if (!(obj3 is int[]))
							{
								obj4 = RuntimeServices.Coerce(obj3, typeof(int[]));
							}
							this.$gilList$44642 = (int[])obj4;
							if (182688 - 329567 == -146878)
							{
								continue;
							}
							object obj6;
							object obj5 = obj6 = this.$data$44655[53];
							if (!(obj5 is int[]))
							{
								obj6 = RuntimeServices.Coerce(obj5, typeof(int[]));
							}
							this.$rpList$44643 = (int[])obj6;
							if (186474 - 80251 != 106223)
							{
								continue;
							}
							this.$g$44644 = 0;
							if (118923 - 11613 == 107311)
							{
								continue;
							}
							while (this.$g$44644 < Extensions.get_length(this.$uidList$44641))
							{
								if (this.$uidList$44641[this.$g$44644] == PlayerData.UID)
								{
									if (41381 - 369267 != -327886)
									{
										goto IL_ACB;
									}
									this.$self_$44656.gsZnOA66KUx = this.$gilList$44642[this.$g$44644];
									if (181365 - 467356 == -285990)
									{
										goto IL_ACB;
									}
									this.$self_$44656.B7vnO9xLAGb = this.$rpList$44643[this.$g$44644];
									if (176618 - 45023 == 131596)
									{
										goto IL_ACB;
									}
								}
								this.$g$44644++;
								if (256520 - 589720 != -333200)
								{
									goto IL_ACB;
								}
							}
							if (153109 - 280263 == -127153)
							{
								continue;
							}
							this.$self_$44656.fN7n2ITXxoH = RuntimeServices.UnboxInt32(this.$data$44655[32]);
							if (270938 - 221793 == 49146)
							{
								continue;
							}
							object obj8;
							object obj7 = obj8 = this.$data$44655[55];
							if (!(obj7 is string))
							{
								obj8 = RuntimeServices.Coerce(obj7, typeof(string));
							}
							this.$rewardString$44645 = (string)obj8;
							if (203162 - 504057 != -300895)
							{
								continue;
							}
							if (this.$rewardString$44645 != "0")
							{
								if (169290 - 503059 != -333769)
								{
									continue;
								}
								this.$InventoryArray$44646 = (string[])Stringf.splitToArray(this.$rewardString$44645, ",").ToBuiltin(typeof(string));
								if (277518 - 482680 != -205162)
								{
									continue;
								}
								this.$i$44647 = 0;
								if (8280 - 255497 == -247216)
								{
									continue;
								}
								while (this.$i$44647 < Mathf.Min(Extensions.get_length(this.$InventoryArray$44646), 7))
								{
									this.$self_$44656.fJZnOWFhwkZ[this.$i$44647].readData(this.$InventoryArray$44646[this.$i$44647]);
									if (113694 - 525105 == -411410)
									{
										goto IL_ACB;
									}
									this.$self_$44656.qUQnOuEahF0[this.$i$44647] = 1;
									if (270838 - 411105 != -140267)
									{
										goto IL_ACB;
									}
									this.$self_$44656.LVonOy8eSip[this.$i$44647] = IconButton.getIconImage(this.$self_$44656.fJZnOWFhwkZ[this.$i$44647].name);
									if (165430 - 302141 == -136710)
									{
										goto IL_ACB;
									}
									if (this.$self_$44656.LVonOy8eSip[this.$i$44647] == null)
									{
										if (9585 - 493070 == -483484)
										{
											goto IL_ACB;
										}
										Debug.Log("Cannot find Icon");
										if (1853 - 242449 == -240595)
										{
											goto IL_ACB;
										}
									}
									this.$i$44647++;
									if (142607 - 522846 != -380239)
									{
										goto IL_ACB;
									}
								}
								if (256187 - 84934 == 171254)
								{
									continue;
								}
							}
							this.$c$44648 = 0;
							if (126947 - 222652 == -95704)
							{
								continue;
							}
							while (this.$c$44648 < 12)
							{
								this.$maxPlayer$44649 = -1;
								if (162319 - 168133 != -5814)
								{
									goto IL_ACB;
								}
								this.$maxScore$44650 = 0;
								if (22526 - 305776 != -283250)
								{
									goto IL_ACB;
								}
								this.$p$44651 = 0;
								if (282211 - 102177 == 180035)
								{
									goto IL_ACB;
								}
								while (this.$p$44651 < 12)
								{
									if (this.$self_$44656.cRLnX4tFBa1[this.$p$44651] >= this.$maxScore$44650)
									{
										if (136744 - 24690 == 112055)
										{
											goto IL_ACB;
										}
										this.$maxPlayer$44649 = this.$p$44651;
										if (227906 - 126403 != 101503)
										{
											goto IL_ACB;
										}
										this.$maxScore$44650 = this.$self_$44656.cRLnX4tFBa1[this.$p$44651];
										if (218255 - 411432 == -193176)
										{
											goto IL_ACB;
										}
									}
									this.$p$44651++;
									if (209005 - 593452 != -384447)
									{
										goto IL_ACB;
									}
								}
								if (21663 - 265093 == -243429)
								{
									goto IL_ACB;
								}
								if (this.$maxPlayer$44649 >= 0)
								{
									if (254057 - 110576 == 143482)
									{
										goto IL_ACB;
									}
									if (this.$maxScore$44650 > 0)
									{
										if (274472 - 255647 != 18825)
										{
											goto IL_ACB;
										}
										this.$slot$44652 = this.$maxPlayer$44649 + 1;
										if (74386 - 261004 == -186617)
										{
											goto IL_ACB;
										}
										if (Game.mGamePlayerName.Contains(this.$slot$44652))
										{
											if (197551 - 167134 != 30417)
											{
												goto IL_ACB;
											}
											object obj10;
											object obj9 = obj10 = Game.mGamePlayerName[this.$slot$44652];
											if (!(obj9 is string))
											{
												obj10 = RuntimeServices.Coerce(obj9, typeof(string));
											}
											this.$pName$44653 = (string)obj10;
											if (47479 - 71824 != -24345)
											{
												goto IL_ACB;
											}
											this.$self_$44656.SjHn2cuF45c[this.$c$44648] = this.$pName$44653;
											if (123544 - 228834 == -105289)
											{
												goto IL_ACB;
											}
											if (Game.mGamePlayerType.Contains("Player" + this.$slot$44652))
											{
												if (10740 - 9877 == 864)
												{
													goto IL_ACB;
												}
												object obj12;
												object obj11 = obj12 = Game.mGamePlayerType["Player" + this.$slot$44652];
												if (!(obj11 is string))
												{
													obj12 = RuntimeServices.Coerce(obj11, typeof(string));
												}
												this.$pType$44654 = (string)obj12;
												if (36678 - 159392 == -122713)
												{
													goto IL_ACB;
												}
												this.$self_$44656.cBun2n3bFGD[this.$c$44648] = (Texture)Resources.Load("GameGui/Icons/Heroes/" + this.$pType$44654 + "1", typeof(Texture));
												if (167107 - 575833 != -408726)
												{
													goto IL_ACB;
												}
											}
											if (this.$maxPlayer$44649 + 1 == this.$self_$44656.hH8nXprq6QP)
											{
												if (14468 - 172887 != -158419)
												{
													goto IL_ACB;
												}
												this.$self_$44656.KjTn25mRolY = Time.time + (float)this.$c$44648 + (float)5;
												if (128810 - 387044 == -258233)
												{
													goto IL_ACB;
												}
											}
											this.$self_$44656.qvNn2elJHsW[this.$c$44648] = this.$self_$44656.cRLnX4tFBa1[this.$maxPlayer$44649];
											if (228431 - 580122 != -351691)
											{
												goto IL_ACB;
											}
											this.$self_$44656.cRLnX4tFBa1[this.$maxPlayer$44649] = -1;
											if (142198 - 504295 == -362096)
											{
												goto IL_ACB;
											}
										}
										else
										{
											this.$self_$44656.SjHn2cuF45c[this.$c$44648] = "none";
											if (238708 - 33890 == 204819)
											{
												goto IL_ACB;
											}
										}
									}
								}
								this.$c$44648++;
								if (48848 - 280463 != -231615)
								{
									goto IL_ACB;
								}
							}
							if (178812 - 473183 != -294371)
							{
								continue;
							}
							if (this.$self_$44656.KjTn25mRolY == (float)0)
							{
								if (192160 - 324763 != -132603)
								{
									continue;
								}
								this.$self_$44656.KjTn25mRolY = Time.time + (float)12;
								if (142122 - 25477 == 116646)
								{
									continue;
								}
							}
							Game.mGameState = eGameState.Complete;
							if (91928 - 33875 == 58054)
							{
								continue;
							}
							this.$self_$44656.N0vnXUBs2lF = eDanceGuiState.complete;
							if (138908 - 428747 != -289839)
							{
								continue;
							}
							this.$self_$44656.uqonXNA0Utk = Time.time;
							if (156271 - 438080 == -281808)
							{
								continue;
							}
							this.YieldDefault(1);
							if (134032 - 133134 != 899)
							{
								goto IL_F9E;
							}
							continue;
						}
						break;
					default:
						if (250304 - 149104 != 101200)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Mission Complete:" + this.$data$44655[31]);
					if (17999 - 236458 != -218458)
					{
						goto Block_25;
					}
				}
				IL_3B:
				goto IL_F9E;
				Block_25:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_F9E:
				return false;
			}

			// Token: 0x0600AA35 RID: 43573 RVA: 0x012FF190 File Offset: 0x012FD390
			internal static bool s5Y1AnV0I1ybIOxaFKjX()
			{
				return true;
			}

			// Token: 0x0600AA36 RID: 43574 RVA: 0x012FF194 File Offset: 0x012FD394
			internal static bool C7p4QFV0BJbspsoKXYKF()
			{
				return false;
			}

			// Token: 0x04009759 RID: 38745
			internal int $result$44638;

			// Token: 0x0400975A RID: 38746
			internal int $a$44639;

			// Token: 0x0400975B RID: 38747
			internal int $b$44640;

			// Token: 0x0400975C RID: 38748
			internal int[] $uidList$44641;

			// Token: 0x0400975D RID: 38749
			internal int[] $gilList$44642;

			// Token: 0x0400975E RID: 38750
			internal int[] $rpList$44643;

			// Token: 0x0400975F RID: 38751
			internal int $g$44644;

			// Token: 0x04009760 RID: 38752
			internal string $rewardString$44645;

			// Token: 0x04009761 RID: 38753
			internal string[] $InventoryArray$44646;

			// Token: 0x04009762 RID: 38754
			internal int $i$44647;

			// Token: 0x04009763 RID: 38755
			internal int $c$44648;

			// Token: 0x04009764 RID: 38756
			internal int $maxPlayer$44649;

			// Token: 0x04009765 RID: 38757
			internal int $maxScore$44650;

			// Token: 0x04009766 RID: 38758
			internal int $p$44651;

			// Token: 0x04009767 RID: 38759
			internal int $slot$44652;

			// Token: 0x04009768 RID: 38760
			internal string $pName$44653;

			// Token: 0x04009769 RID: 38761
			internal string $pType$44654;

			// Token: 0x0400976A RID: 38762
			internal Hashtable $data$44655;

			// Token: 0x0400976B RID: 38763
			internal M961_DanceAudition $self_$44656;
		}
	}

	// Token: 0x02001C71 RID: 7281
	[CompilerGenerated]
	[Serializable]
	internal sealed class $StartGame$44659 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AA37 RID: 43575 RVA: 0x012FF198 File Offset: 0x012FD398
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $StartGame$44659(M961_DanceAudition self_)
		{
			if (173989 - 597723 != -423733)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (268360 - 425648 == -157288)
				{
					base..ctor();
					if (241617 - 99801 != 141817)
					{
						this.$self_$44661 = self_;
						if (142419 - 466374 != -323954)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AA38 RID: 43576 RVA: 0x012FF230 File Offset: 0x012FD430
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M961_DanceAudition.$StartGame$44659.$(this.$self_$44661);
		}

		// Token: 0x0600AA39 RID: 43577 RVA: 0x012FF240 File Offset: 0x012FD440
		internal static bool lxYgYBV0e8tDmEvNgs9Z()
		{
			return true;
		}

		// Token: 0x0600AA3A RID: 43578 RVA: 0x012FF244 File Offset: 0x012FD444
		internal static bool NdIMf0V0rWkIvRMyIhGP()
		{
			return false;
		}

		// Token: 0x0400976C RID: 38764
		internal M961_DanceAudition $self_$44661;

		// Token: 0x02001C72 RID: 7282
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AA3B RID: 43579 RVA: 0x012FF248 File Offset: 0x012FD448
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M961_DanceAudition self_)
			{
				if (99913 - 307392 != -207478)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (41538 - 232689 == -191151)
					{
						base..ctor();
						if (206798 - 7618 == 199180)
						{
							this.$self_$44660 = self_;
							if (290609 - 584945 != -294335)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AA3C RID: 43580 RVA: 0x012FF2E0 File Offset: 0x012FD4E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (182770 - 388771 != -206001)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1A9;
					case 2:
						Game.mGameState = eGameState.Normal;
						if (50929 - 209517 != -158588)
						{
							continue;
						}
						Game.mGameTime = Time.time;
						if (84378 - 485164 == -400785)
						{
							continue;
						}
						this.$self_$44660.N0vnXUBs2lF = eDanceGuiState.ready;
						if (9084 - 172943 != -163859)
						{
							continue;
						}
						this.$self_$44660.uqonXNA0Utk = Time.time;
						if (204625 - 404511 != -199886)
						{
							continue;
						}
						this.YieldDefault(1);
						if (134310 - 126019 != 8291)
						{
							continue;
						}
						goto IL_1A9;
					default:
						if (65385 - 58377 != 7008)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Game");
					if (195010 - 478154 == -283144)
					{
						Game.mGameState = eGameState.Start;
						if (63697 - 501034 == -437337)
						{
							Game.mGameTime = Time.time;
							if (96385 - 444392 != -348006)
							{
								this.$self_$44660.SendMessage("fadeIn");
								if (115292 - 482144 != -366851)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1A9:
				return false;
			}

			// Token: 0x0600AA3D RID: 43581 RVA: 0x012FF4A8 File Offset: 0x012FD6A8
			internal static bool wsPLe6V0jeiI9BTujkU6()
			{
				return true;
			}

			// Token: 0x0600AA3E RID: 43582 RVA: 0x012FF4AC File Offset: 0x012FD6AC
			internal static bool UuSrMjV0hYof56VKSkmK()
			{
				return false;
			}

			// Token: 0x0400976D RID: 38765
			internal M961_DanceAudition $self_$44660;
		}
	}

	// Token: 0x02001C73 RID: 7283
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onStartDanceGame$44662 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AA3F RID: 43583 RVA: 0x012FF4B0 File Offset: 0x012FD6B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onStartDanceGame$44662(int nTrack, M961_DanceAudition self_)
		{
			if (111077 - 394355 != -283278)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (53856 - 137116 != -83259)
				{
					base..ctor();
					if (26488 - 343360 == -316872)
					{
						this.$nTrack$44668 = nTrack;
						if (141437 - 436708 == -295271)
						{
							this.$self_$44669 = self_;
							if (194091 - 190539 != 3553)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AA40 RID: 43584 RVA: 0x012FF56C File Offset: 0x012FD76C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M961_DanceAudition.$onStartDanceGame$44662.$(this.$nTrack$44668, this.$self_$44669);
		}

		// Token: 0x0600AA41 RID: 43585 RVA: 0x012FF580 File Offset: 0x012FD780
		internal static bool ogUydGV0sgqFlYUkaOqS()
		{
			return true;
		}

		// Token: 0x0600AA42 RID: 43586 RVA: 0x012FF584 File Offset: 0x012FD784
		internal static bool tqri82V09EEU744wURpK()
		{
			return false;
		}

		// Token: 0x0400976E RID: 38766
		internal int $nTrack$44668;

		// Token: 0x0400976F RID: 38767
		internal M961_DanceAudition $self_$44669;

		// Token: 0x02001C74 RID: 7284
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AA43 RID: 43587 RVA: 0x012FF588 File Offset: 0x012FD788
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nTrack, M961_DanceAudition self_)
			{
				if (103208 - 483424 != -380215)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (147816 - 422473 != -274656)
					{
						base..ctor();
						if (82622 - 110799 != -28176)
						{
							this.$nTrack$44666 = nTrack;
							if (150540 - 482869 == -332329)
							{
								this.$self_$44667 = self_;
								if (166491 - 448081 == -281590)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AA44 RID: 43588 RVA: 0x012FF644 File Offset: 0x012FD844
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (48487 - 384910 != -336422)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_81A;
					case 2:
						this.$self_$44667.SendMessage("blackOut");
						if (131678 - 545279 == -413600)
						{
							continue;
						}
						this.$self_$44667.audio.Stop();
						if (97167 - 487362 == -390194)
						{
							continue;
						}
						this.$self_$44667.audio.clip = this.$self_$44667.getAudio(this.$nTrack$44666);
						if (166953 - 320284 != -153330)
						{
							goto IL_7AF;
						}
						continue;
					case 3:
						goto IL_7AF;
					case 4:
						if (this.$self_$44667.applause)
						{
							if (100070 - 26330 != 73740)
							{
								continue;
							}
							this.$self_$44667.audio.PlayOneShot(this.$self_$44667.applause);
							if (279123 - 369124 != -90001)
							{
								continue;
							}
						}
						if (!this.$self_$44667.LKxnXwyqIDk)
						{
							goto IL_22A;
						}
						if (224631 - 102845 == 121787)
						{
							continue;
						}
						this.$self_$44667.LKxnXwyqIDk.animation.Play("open");
						if (295765 - 134028 != 161738)
						{
							goto IL_22A;
						}
						continue;
					default:
						if (266409 - 473393 == -206983)
						{
							continue;
						}
						break;
					}
					Debug.Log("Start Dance Game : Track" + this.$nTrack$44666);
					if (55676 - 292565 != -236889)
					{
						continue;
					}
					this.$self_$44667.ResetDanceGame();
					if (180609 - 375441 == -194831)
					{
						continue;
					}
					this.$nSong$44663 = SongData.getSongData(this.$nTrack$44666);
					if (240486 - 379209 == -138722)
					{
						continue;
					}
					this.$self_$44667.OxUnX2j39Ih = this.$nTrack$44666;
					if (66948 - 178298 != -111350)
					{
						continue;
					}
					this.$self_$44667.UgdnXvClMia = SongData.getNote(this.$nTrack$44666);
					if (240317 - 594653 != -354336)
					{
						continue;
					}
					this.$self_$44667.BiXnXlcf0sd = (float)SongData.getBeat(this.$nTrack$44666);
					if (40730 - 291811 == -251080)
					{
						continue;
					}
					this.$self_$44667.OA1nXGWAQiS = (float)(this.$self_$44667.UgdnXvClMia.length + 12) * 0.001f * this.$self_$44667.BiXnXlcf0sd;
					if (187139 - 412967 == -225827)
					{
						continue;
					}
					this.$self_$44667.TqxnX1JBOfP = this.$nSong$44663.score;
					if (164772 - 364433 != -199661)
					{
						continue;
					}
					this.$self_$44667.ox4nXqNRMpp = this.$nSong$44663.difficulty;
					if (208943 - 543145 != -334202)
					{
						continue;
					}
					Debug.Log("songNote:" + this.$self_$44667.UgdnXvClMia.length);
					if (271684 - 130213 != 141471)
					{
						continue;
					}
					Debug.Log("songBeat:" + this.$self_$44667.BiXnXlcf0sd);
					if (172523 - 466100 == -293576)
					{
						continue;
					}
					Debug.Log("songTime:" + this.$self_$44667.OA1nXGWAQiS);
					if (54594 - 298874 != -244280)
					{
						continue;
					}
					Debug.Log("songScore:" + this.$self_$44667.TqxnX1JBOfP);
					if (147976 - 534140 == -386163)
					{
						continue;
					}
					Debug.Log("songDifficulty:" + this.$self_$44667.ox4nXqNRMpp);
					if (77733 - 43637 != 34096)
					{
						continue;
					}
					if (this.$self_$44667.UgdnXvClMia == null)
					{
						goto IL_22A;
					}
					if (287430 - 70622 != 216808)
					{
						continue;
					}
					if (this.$self_$44667.BiXnXlcf0sd <= (float)0)
					{
						goto IL_22A;
					}
					if (184351 - 207230 != -22879)
					{
						continue;
					}
					this.$self_$44667.N0vnXUBs2lF = eDanceGuiState.start;
					if (183873 - 302611 == -118737)
					{
						continue;
					}
					this.$self_$44667.uqonXNA0Utk = Time.time;
					if (197928 - 19248 != 178680)
					{
						continue;
					}
					break;
					IL_7AF:
					if (Time.time >= this.$self_$44667.uqonXNA0Utk + (float)1)
					{
						if (236565 - 598461 != -361896)
						{
							continue;
						}
						if (this.$self_$44667.LqDnXLT1RgJ)
						{
							if (5323 - 146651 == -141327)
							{
								continue;
							}
							this.$mCamParent$44664 = this.$self_$44667.LqDnXLT1RgJ.transform.Find("Camera");
							if (190233 - 565417 == -375183)
							{
								continue;
							}
							if (this.$mCamParent$44664)
							{
								if (239450 - 467859 == -228408)
								{
									continue;
								}
								this.$self_$44667.transform.parent = this.$mCamParent$44664;
								if (123755 - 7038 != 116717)
								{
									continue;
								}
								this.$self_$44667.transform.localPosition = Vector3.zero;
								if (245360 - 257987 == -12626)
								{
									continue;
								}
								this.$self_$44667.transform.localRotation = Quaternion.Euler((float)0, (float)270, (float)0);
								if (290756 - 502583 == -211826)
								{
									continue;
								}
							}
						}
						this.$self_$44667.SendMessage("blackIn");
						if (265032 - 597689 == -332656)
						{
							continue;
						}
						this.$startTime$44665 = SongData.getStartTime(this.$nTrack$44666);
						if (69668 - 341007 == -271338)
						{
							continue;
						}
						this.$self_$44667.StartCoroutine_Auto(this.$self_$44667.startSong(this.$startTime$44665));
						if (161412 - 95863 == 65550)
						{
							continue;
						}
						this.$self_$44667.N0vnXUBs2lF = eDanceGuiState.play;
						if (26841 - 280447 == -253605)
						{
							continue;
						}
						this.$self_$44667.uqonXNA0Utk = Time.time;
						if (224689 - 349272 != -124582)
						{
							goto Block_12;
						}
						continue;
					}
					else
					{
						this.$self_$44667.audio.volume = Mathf.SmoothStep(this.$self_$44667.audio.volume, (float)0, Time.time - this.$self_$44667.uqonXNA0Utk);
						if (123394 - 212345 != -88951)
						{
							continue;
						}
						goto IL_7A3;
					}
					IL_22A:
					this.YieldDefault(1);
					if (219741 - 189676 != 30066)
					{
						goto Block_14;
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				Block_12:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_14:
				goto IL_81A;
				IL_7A3:
				return this.YieldDefault(3);
				IL_81A:
				return false;
			}

			// Token: 0x0600AA45 RID: 43589 RVA: 0x012FFE80 File Offset: 0x012FE080
			internal static bool zy8HTDV01SCX2cbU7f4Q()
			{
				return true;
			}

			// Token: 0x0600AA46 RID: 43590 RVA: 0x012FFE84 File Offset: 0x012FE084
			internal static bool wBsRClV04HUJVPKMS4He()
			{
				return false;
			}

			// Token: 0x04009770 RID: 38768
			internal SongEntry $nSong$44663;

			// Token: 0x04009771 RID: 38769
			internal Transform $mCamParent$44664;

			// Token: 0x04009772 RID: 38770
			internal float $startTime$44665;

			// Token: 0x04009773 RID: 38771
			internal int $nTrack$44666;

			// Token: 0x04009774 RID: 38772
			internal M961_DanceAudition $self_$44667;
		}
	}

	// Token: 0x02001C75 RID: 7285
	[CompilerGenerated]
	[Serializable]
	internal sealed class $startSong$44670 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AA47 RID: 43591 RVA: 0x012FFE88 File Offset: 0x012FE088
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $startSong$44670(float nStartTime, M961_DanceAudition self_)
		{
			if (234705 - 543325 != -308619)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (229401 - 169607 != 59795)
				{
					base..ctor();
					if (206191 - 229449 != -23257)
					{
						this.$nStartTime$44674 = nStartTime;
						if (21845 - 89062 == -67217)
						{
							this.$self_$44675 = self_;
							if (278215 - 517876 != -239660)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600AA48 RID: 43592 RVA: 0x012FFF44 File Offset: 0x012FE144
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M961_DanceAudition.$startSong$44670.$(this.$nStartTime$44674, this.$self_$44675);
		}

		// Token: 0x0600AA49 RID: 43593 RVA: 0x012FFF58 File Offset: 0x012FE158
		internal static bool oqt6RxV0zPIRf63GjUjA()
		{
			return true;
		}

		// Token: 0x0600AA4A RID: 43594 RVA: 0x012FFF5C File Offset: 0x012FE15C
		internal static bool Hw7hteVbasp5TSqqBajo()
		{
			return false;
		}

		// Token: 0x04009775 RID: 38773
		internal float $nStartTime$44674;

		// Token: 0x04009776 RID: 38774
		internal M961_DanceAudition $self_$44675;

		// Token: 0x02001C76 RID: 7286
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AA4B RID: 43595 RVA: 0x012FFF60 File Offset: 0x012FE160
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(float nStartTime, M961_DanceAudition self_)
			{
				if (39842 - 457493 != -417651)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (13410 - 497549 != -484138)
					{
						base..ctor();
						if (92642 - 470172 == -377530)
						{
							this.$nStartTime$44672 = nStartTime;
							if (263063 - 451509 != -188445)
							{
								this.$self_$44673 = self_;
								if (213760 - 336112 == -122352)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600AA4C RID: 43596 RVA: 0x0130001C File Offset: 0x012FE21C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (9982 - 307746 != -297763)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_3A5;
					case 1:
						goto IL_6B2;
					case 2:
						this.$self_$44673.audio.volume = Mathf.Clamp01(0.1f * (float)Game.music + 0.2f);
						if (290823 - 365684 == -74861)
						{
							if (!this.$self_$44673.audio.clip)
							{
								goto IL_5EE;
							}
							if (224558 - 66101 != 158458)
							{
								this.$self_$44673.audio.Play();
								if (223917 - 593592 == -369675)
								{
									goto IL_5EE;
								}
							}
						}
						break;
					case 3:
						if (Game.mGameState != eGameState.Normal)
						{
							if (179432 - 437870 != -258437)
							{
								goto Block_57;
							}
						}
						else
						{
							this.$$switch$8258$44671 = this.$self_$44673.OxUnX2j39Ih;
							if (186297 - 552926 != -366628)
							{
								if (this.$$switch$8258$44671 == 2)
								{
									if (166377 - 508238 != -341861)
									{
										break;
									}
								}
								else if (this.$$switch$8258$44671 == 6)
								{
									if (226740 - 302583 == -75842)
									{
										break;
									}
								}
								else if (this.$$switch$8258$44671 == 9)
								{
									if (57866 - 40232 != 17634)
									{
										break;
									}
								}
								else if (this.$$switch$8258$44671 == 13)
								{
									if (166986 - 430332 == -263345)
									{
										break;
									}
								}
								else if (this.$$switch$8258$44671 == 15)
								{
									if (148909 - 14480 != 134429)
									{
										break;
									}
								}
								else if (this.$$switch$8258$44671 == 17)
								{
									if (27135 - 540909 == -513773)
									{
										break;
									}
								}
								else
								{
									if (this.$$switch$8258$44671 != 19)
									{
										if (this.$$switch$8258$44671 == 1)
										{
											if (227014 - 405068 == -178053)
											{
												break;
											}
										}
										else if (this.$$switch$8258$44671 == 4)
										{
											if (198396 - 397072 == -198675)
											{
												break;
											}
										}
										else if (this.$$switch$8258$44671 == 8)
										{
											if (107045 - 338490 != -231445)
											{
												break;
											}
										}
										else if (this.$$switch$8258$44671 == 10)
										{
											if (47338 - 431159 == -383820)
											{
												break;
											}
										}
										else
										{
											if (this.$$switch$8258$44671 != 12)
											{
												if (this.$$switch$8258$44671 == 3)
												{
													if (126395 - 472612 != -346217)
													{
														break;
													}
												}
												else if (this.$$switch$8258$44671 == 5)
												{
													if (104169 - 543776 != -439607)
													{
														break;
													}
												}
												else if (this.$$switch$8258$44671 == 7)
												{
													if (261168 - 391376 == -130207)
													{
														break;
													}
												}
												else
												{
													if (this.$$switch$8258$44671 != 14)
													{
														if (this.$$switch$8258$44671 == 11)
														{
															if (3733 - 116936 != -113203)
															{
																break;
															}
														}
														else if (this.$$switch$8258$44671 == 16)
														{
															if (173046 - 555058 != -382012)
															{
																break;
															}
														}
														else if (this.$$switch$8258$44671 == 18)
														{
															if (175827 - 189132 != -13305)
															{
																break;
															}
														}
														else
														{
															if (this.$$switch$8258$44671 != 20)
															{
																goto IL_690;
															}
															if (278411 - 100984 == 177428)
															{
																break;
															}
														}
														IL_F8:
														if (this.$self_$44673.epicRockEffect)
														{
															if (218252 - 472507 != -254255)
															{
																break;
															}
															UnityEngine.Object.Instantiate(this.$self_$44673.softRockEffect, new Vector3((float)0, (float)50, (float)0), Quaternion.identity);
															if (33494 - 171871 == -138376)
															{
																break;
															}
														}
														goto IL_690;
														IL_596:
														goto IL_F8;
														goto IL_596;
													}
													if (29930 - 108029 == -78098)
													{
														break;
													}
												}
												IL_9D:
												if (this.$self_$44673.softRockEffect)
												{
													if (253455 - 344667 == -91211)
													{
														break;
													}
													UnityEngine.Object.Instantiate(this.$self_$44673.softRockEffect, new Vector3((float)0, (float)50, (float)0), Quaternion.identity);
													if (292792 - 227813 == 64980)
													{
														break;
													}
												}
												goto IL_690;
												IL_1EE:
												goto IL_9D;
												goto IL_1EE;
											}
											if (41593 - 78825 == -37231)
											{
												break;
											}
										}
										IL_127:
										if (this.$self_$44673.arcadeEffect)
										{
											if (11092 - 510534 == -499441)
											{
												break;
											}
											UnityEngine.Object.Instantiate(this.$self_$44673.arcadeEffect, new Vector3((float)0, (float)50, (float)0), Quaternion.identity);
											if (124480 - 511747 != -387267)
											{
												break;
											}
										}
										goto IL_690;
										IL_1C2:
										goto IL_127;
										IL_34D:
										goto IL_1C2;
										goto IL_34D;
									}
									if (120734 - 183797 != -63063)
									{
										break;
									}
								}
								IL_31E:
								if (this.$self_$44673.tailsEffect)
								{
									if (77317 - 38426 != 38891)
									{
										break;
									}
									UnityEngine.Object.Instantiate(this.$self_$44673.tailsEffect, new Vector3((float)0, (float)50, (float)0), Quaternion.identity);
									if (195380 - 123850 == 71531)
									{
										break;
									}
								}
								goto IL_690;
								IL_5C2:
								goto IL_31E;
								IL_21A:
								goto IL_5C2;
								IL_1A:
								goto IL_21A;
								IL_CC:
								goto IL_1A;
								goto IL_CC;
								IL_690:
								this.YieldDefault(1);
								if (3918 - 434986 != -431067)
								{
									goto IL_6B2;
								}
							}
						}
						break;
					default:
						if (124813 - 166313 != -41499)
						{
							goto Block_37;
						}
						break;
					}
				}
				IL_3A5:
				return this.Yield(2, new WaitForSeconds(this.$nStartTime$44672));
				Block_37:
				goto IL_3A5;
				IL_5EE:
				return this.Yield(3, new WaitForSeconds(0.4f * this.$self_$44673.OA1nXGWAQiS));
				Block_57:
				IL_6B2:
				return false;
			}

			// Token: 0x0600AA4D RID: 43597 RVA: 0x013006F0 File Offset: 0x012FE8F0
			internal static bool yt3b10Vb5VyULAVlUNcZ()
			{
				return true;
			}

			// Token: 0x0600AA4E RID: 43598 RVA: 0x013006F4 File Offset: 0x012FE8F4
			internal static bool VUNCepVbpwrIM5ORbY9K()
			{
				return false;
			}

			// Token: 0x04009777 RID: 38775
			internal int $$switch$8258$44671;

			// Token: 0x04009778 RID: 38776
			internal float $nStartTime$44672;

			// Token: 0x04009779 RID: 38777
			internal M961_DanceAudition $self_$44673;
		}
	}

	// Token: 0x02001C77 RID: 7287
	[CompilerGenerated]
	[Serializable]
	internal sealed class $onDeadPlayer$44676 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AA4F RID: 43599 RVA: 0x013006F8 File Offset: 0x012FE8F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $onDeadPlayer$44676(M961_DanceAudition self_)
		{
			if (85832 - 504038 != -418206)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (21404 - 394876 != -373471)
				{
					base..ctor();
					if (288827 - 587365 != -298537)
					{
						this.$self_$44681 = self_;
						if (133123 - 142801 == -9678)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AA50 RID: 43600 RVA: 0x01300790 File Offset: 0x012FE990
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M961_DanceAudition.$onDeadPlayer$44676.$(this.$self_$44681);
		}

		// Token: 0x0600AA51 RID: 43601 RVA: 0x013007A0 File Offset: 0x012FE9A0
		internal static bool M07bt1VbVBbMFECgQXLV()
		{
			return true;
		}

		// Token: 0x0600AA52 RID: 43602 RVA: 0x013007A4 File Offset: 0x012FE9A4
		internal static bool rVaRNdVbtviBmCurM9Cr()
		{
			return false;
		}

		// Token: 0x0400977A RID: 38778
		internal M961_DanceAudition $self_$44681;

		// Token: 0x02001C78 RID: 7288
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AA53 RID: 43603 RVA: 0x013007A8 File Offset: 0x012FE9A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M961_DanceAudition self_)
			{
				if (82906 - 116688 != -33782)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (287828 - 176146 == 111682)
					{
						base..ctor();
						if (182743 - 317258 != -134514)
						{
							this.$self_$44680 = self_;
							if (249081 - 472060 == -222979)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AA54 RID: 43604 RVA: 0x01300840 File Offset: 0x012FEA40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (139389 - 189384 != -49994)
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
							if (247591 - 336044 == -88452)
							{
								continue;
							}
							if (Game.mGameState != eGameState.Hold)
							{
								goto IL_200;
							}
							if (38695 - 470132 == -431436)
							{
								continue;
							}
						}
						Game.mGameState = eGameState.Hold;
						if (7827 - 35580 == -27752)
						{
							continue;
						}
						this.$mStoryGui$44677 = (StoryGui)this.$self_$44680.GetComponent(typeof(StoryGui));
						if (202434 - 462898 == -260463)
						{
							continue;
						}
						if (this.$mStoryGui$44677)
						{
							if (229244 - 361043 != -131799)
							{
								continue;
							}
							this.$mStoryGui$44677.close();
							if (115487 - 212639 == -97151)
							{
								continue;
							}
						}
						this.$mChangeGui$44678 = (ChangeGui)this.$self_$44680.GetComponent(typeof(ChangeGui));
						if (120976 - 225701 != -104725)
						{
							continue;
						}
						if (this.$mChangeGui$44678)
						{
							if (247464 - 244018 != 3446)
							{
								continue;
							}
							this.$mChangeGui$44678.close();
							if (274688 - 232150 == 42539)
							{
								continue;
							}
						}
						this.$mGameGui$44679 = (GameGui)this.$self_$44680.GetComponent(typeof(GameGui));
						if (34056 - 458210 != -424154)
						{
							continue;
						}
						if (this.$mGameGui$44679)
						{
							if (291109 - 359692 != -68583)
							{
								continue;
							}
							if (!this.$mGameGui$44679.enabled)
							{
								if (172127 - 85451 == 86677)
								{
									continue;
								}
								this.$mGameGui$44679.enabled = true;
								if (101110 - 476289 == -375178)
								{
									continue;
								}
							}
							this.$mGameGui$44679.openDeadMenu();
							if (276351 - 307635 == -31283)
							{
								continue;
							}
						}
						IL_200:
						this.YieldDefault(1);
						if (245788 - 398691 != -152903)
						{
							continue;
						}
						goto IL_2F9;
					default:
						if (201957 - 176477 != 25480)
						{
							continue;
						}
						break;
					}
					Debug.Log("On Dead Player");
				}
				while (122637 - 278310 == -155672);
				return this.Yield(2, new WaitForSeconds((float)2));
				IL_2F9:
				return false;
			}

			// Token: 0x0600AA55 RID: 43605 RVA: 0x01300B58 File Offset: 0x012FED58
			internal static bool xqIygmVbNgTCaqDreZEd()
			{
				return true;
			}

			// Token: 0x0600AA56 RID: 43606 RVA: 0x01300B5C File Offset: 0x012FED5C
			internal static bool TVeInBVbYdks8sywjMaJ()
			{
				return false;
			}

			// Token: 0x0400977B RID: 38779
			internal StoryGui $mStoryGui$44677;

			// Token: 0x0400977C RID: 38780
			internal ChangeGui $mChangeGui$44678;

			// Token: 0x0400977D RID: 38781
			internal GameGui $mGameGui$44679;

			// Token: 0x0400977E RID: 38782
			internal M961_DanceAudition $self_$44680;
		}
	}

	// Token: 0x02001C79 RID: 7289
	[CompilerGenerated]
	[Serializable]
	internal sealed class $ReturnToTown$44682 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600AA57 RID: 43607 RVA: 0x01300B60 File Offset: 0x012FED60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $ReturnToTown$44682(M961_DanceAudition self_)
		{
			if (230974 - 348365 != -117390)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (13295 - 14570 == -1275)
				{
					base..ctor();
					if (42062 - 548796 == -506734)
					{
						this.$self_$44684 = self_;
						if (112011 - 206605 != -94593)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600AA58 RID: 43608 RVA: 0x01300BF8 File Offset: 0x012FEDF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new M961_DanceAudition.$ReturnToTown$44682.$(this.$self_$44684);
		}

		// Token: 0x0600AA59 RID: 43609 RVA: 0x01300C08 File Offset: 0x012FEE08
		internal static bool ELBfxgVbcfDsQnIRCnje()
		{
			return true;
		}

		// Token: 0x0600AA5A RID: 43610 RVA: 0x01300C0C File Offset: 0x012FEE0C
		internal static bool IwT6rkVbUJj2wxTQjkx3()
		{
			return false;
		}

		// Token: 0x0400977F RID: 38783
		internal M961_DanceAudition $self_$44684;

		// Token: 0x02001C7A RID: 7290
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600AA5B RID: 43611 RVA: 0x01300C10 File Offset: 0x012FEE10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(M961_DanceAudition self_)
			{
				if (296692 - 299845 != -3152)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (136235 - 538808 != -402572)
					{
						base..ctor();
						if (52457 - 220595 == -168138)
						{
							this.$self_$44683 = self_;
							if (77558 - 268290 == -190732)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600AA5C RID: 43612 RVA: 0x01300CA8 File Offset: 0x012FEEA8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (40450 - 440149 != -399699)
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
						this.$self_$44683.LeaveGame();
						if (144016 - 90554 == 53463)
						{
							continue;
						}
						this.YieldDefault(1);
						if (180518 - 464658 != -284140)
						{
							continue;
						}
						goto IL_134;
					default:
						if (286281 - 568989 != -282708)
						{
							continue;
						}
						break;
					}
					Game.mGameState = eGameState.Ended;
					if (71516 - 342117 != -270600)
					{
						Game.mStateTime = Time.time;
						if (191146 - 397474 != -206327)
						{
							Game.mNextGameCode = 52;
							if (276423 - 405845 == -129422)
							{
								this.$self_$44683.SendMessage("fadeOut");
								if (81313 - 380005 == -298692)
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

			// Token: 0x0600AA5D RID: 43613 RVA: 0x01300DFC File Offset: 0x012FEFFC
			internal static bool jUacS6VbT2AihAr6FXpE()
			{
				return true;
			}

			// Token: 0x0600AA5E RID: 43614 RVA: 0x01300E00 File Offset: 0x012FF000
			internal static bool KqafRNVb3c5q27wWMeSv()
			{
				return false;
			}

			// Token: 0x04009780 RID: 38784
			internal M961_DanceAudition $self_$44683;
		}
	}
}
